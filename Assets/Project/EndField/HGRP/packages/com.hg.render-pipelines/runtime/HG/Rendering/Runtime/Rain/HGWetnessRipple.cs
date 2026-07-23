using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public class HGWetnessRipple : HGBaseWetnessFeature // TypeDefIndex: 38853
	{
		// Fields
		private float m_rippleTimeOffset; // 0x18
		private float m_rippleWaveTimeOffset; // 0x1C
		private WetnessRippleRenderParams m_wetnessRippleRenderParams; // 0x20
	
		// Nested types
		private class WetnessRippleRenderParams // TypeDefIndex: 38852
		{
			// Fields
			public Texture2D rippleTexture; // 0x10
			public Vector2 rippleTexture_ST; // 0x18
			public float rippleNormalStrength; // 0x20
			public float rippleWaveNormalStrength; // 0x24
			public int rippleRowColumnCount; // 0x28
			public float rippleRoughnessMaskThreshold; // 0x2C
	
			// Constructors
			public WetnessRippleRenderParams() {} // 0x0000000182EDAE20-0x0000000182EDAE60
		}
	
		// Constructors
		public HGWetnessRipple() {} // 0x0000000182EDAC00-0x0000000182EDAC50
		// HGWetnessRipple()
		void HG::Rendering::Runtime::Rain::HGWetnessRipple::HGWetnessRipple(HGWetnessRipple *this, MethodInfo *method)
		{
		  HGWetnessRipple_WetnessRippleRenderParams *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGWetnessRipple_WetnessRippleRenderParams *v6; // rbx
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
		
		  v3 = (HGWetnessRipple_WetnessRippleRenderParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple::WetnessRippleRenderParams);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::Rain::HGWetnessRipple::WetnessRippleRenderParams::WetnessRippleRenderParams(v3, 0LL);
		  this->fields.m_wetnessRippleRenderParams = v6;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_wetnessRippleRenderParams,
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
		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime) {} // 0x0000000189CDB634-0x0000000189CDB7C4
		internal override void SetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDB490-0x0000000189CDB634
		// Void SetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessRipple::SetData(
		        HGWetnessRipple *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  HGWetnessRipple_WetnessRippleRenderParams *v5; // rdx
		  __int64 v6; // rcx
		  HGWetnessRipple_WetnessRippleRenderParams *m_wetnessRippleRenderParams; // rax
		  Vector4__Array *rainWetnessGlobalParams; // rsi
		  float m_rippleTimeOffset; // xmm9_4
		  float rippleNormalStrength; // xmm8_4
		  float m_rippleWaveTimeOffset; // xmm7_4
		  float rippleWaveNormalStrength; // xmm6_4
		  Vector4 *v13; // rax
		  Vector4__Array *v14; // rdi
		  Vector4 *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v17[3]; // [rsp+30h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5484, 0LL) )
		  {
		    m_wetnessRippleRenderParams = this->fields.m_wetnessRippleRenderParams;
		    if ( m_wetnessRippleRenderParams )
		    {
		      if ( m_wetnessRippleRenderParams->fields.rippleRoughnessMaskThreshold <= 0.0 )
		      {
		        sub_180073530(7LL, this, globalProps);
		        return;
		      }
		      if ( globalProps )
		      {
		        rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		        m_rippleTimeOffset = this->fields.m_rippleTimeOffset;
		        rippleNormalStrength = m_wetnessRippleRenderParams->fields.rippleNormalStrength;
		        m_rippleWaveTimeOffset = this->fields.m_rippleWaveTimeOffset;
		        rippleWaveNormalStrength = m_wetnessRippleRenderParams->fields.rippleWaveNormalStrength;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v13 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                v17,
		                m_rippleTimeOffset,
		                rippleNormalStrength,
		                m_rippleWaveTimeOffset,
		                rippleWaveNormalStrength,
		                0LL);
		        if ( rainWetnessGlobalParams )
		        {
		          v17[0] = *v13;
		          sub_18003FEF0(rainWetnessGlobalParams, 5LL, v17);
		          v5 = this->fields.m_wetnessRippleRenderParams;
		          v14 = globalProps->fields.rainWetnessGlobalParams;
		          if ( v5 )
		          {
		            v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    v17,
		                    v5->fields.rippleTexture_ST.x,
		                    v5->fields.rippleTexture_ST.y,
		                    (float)v5->fields.rippleRowColumnCount,
		                    v5->fields.rippleRoughnessMaskThreshold,
		                    0LL);
		            if ( v14 )
		            {
		              v17[0] = *v15;
		              sub_18003FEF0(v14, 6LL, v17);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5484, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)globalProps,
		    0LL);
		}
		
		internal override void ResetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDB34C-0x0000000189CDB490
		// Void ResetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessRipple::ResetData(
		        HGWetnessRipple *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  HGWetnessRipple_WetnessRippleRenderParams *m_wetnessRippleRenderParams; // rdx
		  __int64 v6; // rcx
		  Vector4__Array *rainWetnessGlobalParams; // rsi
		  float m_rippleTimeOffset; // xmm7_4
		  float m_rippleWaveTimeOffset; // xmm6_4
		  Vector4 *v10; // rax
		  Vector4__Array *v11; // rdi
		  Vector4 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v14[2]; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5485, 0LL) )
		  {
		    if ( globalProps )
		    {
		      rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		      m_rippleTimeOffset = this->fields.m_rippleTimeOffset;
		      m_rippleWaveTimeOffset = this->fields.m_rippleWaveTimeOffset;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v10 = HG::Rendering::Runtime::HGUtils::PackVector4(v14, m_rippleTimeOffset, 0.0, m_rippleWaveTimeOffset, 0.0, 0LL);
		      if ( rainWetnessGlobalParams )
		      {
		        v14[0] = *v10;
		        sub_18003FEF0(rainWetnessGlobalParams, 5LL, v14);
		        m_wetnessRippleRenderParams = this->fields.m_wetnessRippleRenderParams;
		        v11 = globalProps->fields.rainWetnessGlobalParams;
		        if ( m_wetnessRippleRenderParams )
		        {
		          v12 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                  v14,
		                  m_wetnessRippleRenderParams->fields.rippleTexture_ST.x,
		                  m_wetnessRippleRenderParams->fields.rippleTexture_ST.y,
		                  (float)m_wetnessRippleRenderParams->fields.rippleRowColumnCount,
		                  0.0,
		                  0LL);
		          if ( v11 )
		          {
		            v14[0] = *v12;
		            sub_18003FEF0(v11, 6LL, v14);
		            return;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, m_wetnessRippleRenderParams);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5485, 0LL);
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
