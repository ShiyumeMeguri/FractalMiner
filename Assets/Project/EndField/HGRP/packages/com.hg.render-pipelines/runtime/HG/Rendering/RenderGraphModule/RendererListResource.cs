using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal struct RendererListResource // TypeDefIndex: 37463
	{
		// Fields
		public RendererListDesc desc; // 0x00
		public RendererList rendererList; // 0xE0
	
		// Constructors
		internal RendererListResource([IsReadOnly] in RendererListDesc desc) {
			this.desc = default;
			rendererList = default;
		} // 0x0000000189B3F960-0x0000000189B3FA80
		// RendererListResource(RendererListDesc&)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource::RendererListResource(
		        RendererListResource_1 *this,
		        RendererListDesc *desc,
		        MethodInfo *method)
		{
		  __int128 v4; // xmm0
		  Material **p_overrideMaterial; // rdx
		  Material **v6; // rcx
		  __int64 v7; // r9
		  __int128 v8; // [rsp+20h] [rbp-E8h]
		  __int128 v9; // [rsp+30h] [rbp-D8h]
		  __int128 v10; // [rsp+40h] [rbp-C8h]
		  __int128 v11; // [rsp+50h] [rbp-B8h]
		  __int128 v12; // [rsp+60h] [rbp-A8h]
		  __int128 v13; // [rsp+70h] [rbp-98h]
		  __int128 v14; // [rsp+80h] [rbp-88h]
		  __int128 v15; // [rsp+A0h] [rbp-68h]
		  __int128 v16; // [rsp+B0h] [rbp-58h]
		  __int128 v17; // [rsp+C0h] [rbp-48h]
		  __int128 v18; // [rsp+D0h] [rbp-38h]
		  __int128 v19; // [rsp+E0h] [rbp-28h]
		  __int128 v20; // [rsp+F0h] [rbp-18h]
		
		  v8 = *(_OWORD *)&desc->sortingCriteria;
		  v9 = *(_OWORD *)&desc->stateBlock.hasValue;
		  v10 = *(_OWORD *)&desc->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  v11 = *(_OWORD *)&desc->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  v12 = *(_OWORD *)&desc->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  v13 = *(_OWORD *)&desc->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  v14 = *(_OWORD *)&desc->stateBlock.value.m_RasterState.m_OffsetFactor;
		  v4 = *(_OWORD *)&desc->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &desc->overrideMaterial;
		  v15 = *(_OWORD *)p_overrideMaterial;
		  v16 = *((_OWORD *)p_overrideMaterial + 1);
		  v17 = *((_OWORD *)p_overrideMaterial + 2);
		  v18 = *((_OWORD *)p_overrideMaterial + 3);
		  v19 = *((_OWORD *)p_overrideMaterial + 4);
		  v20 = *((_OWORD *)p_overrideMaterial + 5);
		  *(_OWORD *)&this->desc.sortingCriteria = v8;
		  *(_OWORD *)&this->desc.stateBlock.hasValue = v9;
		  *(_OWORD *)&this->desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v10;
		  *(_OWORD *)&this->desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v11;
		  *(_OWORD *)&this->desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v12;
		  *(_OWORD *)&this->desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v13;
		  *(_OWORD *)&this->desc.stateBlock.value.m_RasterState.m_OffsetFactor = v14;
		  v6 = &this->desc.overrideMaterial;
		  *((_OWORD *)v6 - 1) = v4;
		  *(_OWORD *)v6 = v15;
		  *((_OWORD *)v6 + 1) = v16;
		  *((_OWORD *)v6 + 2) = v17;
		  *((_OWORD *)v6 + 3) = v18;
		  *((_OWORD *)v6 + 4) = v19;
		  *((_OWORD *)v6 + 5) = v20;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->desc.overrideMaterial,
		    (Type *)p_overrideMaterial,
		    (PropertyInfo_1 *)0x80,
		    (Int32__Array **)this,
		    (MethodInfo *)v8);
		  *(_OWORD *)(v7 + 224) = 0LL;
		}
		
	}
}
