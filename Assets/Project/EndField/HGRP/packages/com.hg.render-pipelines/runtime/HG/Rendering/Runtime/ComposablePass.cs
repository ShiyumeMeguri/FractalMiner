using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ComposablePass // TypeDefIndex: 38514
	{
		// Constructors
		public ComposablePass() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		protected virtual HGRenderGraphBuilder? GetRenderGraphBuilder(HGRenderGraph renderGraph) => default; // 0x0000000189BDBE74-0x0000000189BDBF24
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        ComposablePass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v11; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3551, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3551, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1090(&v11, Patch, (Object *)this, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    *(_OWORD *)&retstr->hasValue = 0LL;
		    *(_OWORD *)&retstr->value.m_Resources = 0LL;
		    *(_QWORD *)&retstr->value.m_Disposed = 0LL;
		    memset(&v11, 0, 32);
		    sub_1803683D4(retstr, &v11);
		  }
		  return retstr;
		}
		
		internal void SetChildPass(HGRenderGraph renderGraph, ComposablePass pass) {} // 0x0000000189BDBF24-0x0000000189BDC070
		// Void SetChildPass(HGRenderGraph, ComposablePass)
		void HG::Rendering::Runtime::ComposablePass::SetChildPass(
		        ComposablePass *this,
		        HGRenderGraph *renderGraph,
		        ComposablePass *pass,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rax
		  __m128i v12; // xmm2
		  __int128 v13; // xmm0
		  __int64 v14; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderGraphBuilder v16; // [rsp+38h] [rbp-69h] BYREF
		  Nullable_1_Beyond_Gameplay_Core_GameLevelLoader_SeamlessSetting_ v17; // [rsp+58h] [rbp-49h] BYREF
		  Nullable_1_Beyond_Gameplay_Core_GameLevelLoader_SeamlessSetting_ v18; // [rsp+88h] [rbp-19h] BYREF
		  HGRenderGraphBuilder v19; // [rsp+B0h] [rbp+Fh] BYREF
		  _BYTE v20[40]; // [rsp+D0h] [rbp+2Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3552, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3552, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)renderGraph,
		        (Object *)pass,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v10, v9);
		  }
		  v8 = sub_1808B0068(&v18, v7, this, renderGraph);
		  *(_QWORD *)&v17.value.keepCamera = *(_QWORD *)(v8 + 32);
		  *(_OWORD *)&v16.m_RenderPass = *(_OWORD *)v8;
		  *(_OWORD *)&v17.hasValue = *(_OWORD *)&v16.m_RenderPass;
		  *(_OWORD *)&v17.value.tpScreenFx = *(_OWORD *)(v8 + 16);
		  if ( !pass )
		    goto LABEL_7;
		  v11 = sub_1808B0068(v20, v9, pass, renderGraph);
		  v12 = *(__m128i *)v11;
		  v13 = *(_OWORD *)(v11 + 16);
		  v14 = *(_QWORD *)(v11 + 32);
		  *(_OWORD *)&v18.hasValue = *(_OWORD *)v11;
		  *(_OWORD *)&v18.value.tpScreenFx = v13;
		  *(_QWORD *)&v18.value.keepCamera = v14;
		  if ( LOBYTE(v16.m_RenderPass) )
		  {
		    if ( (unsigned __int8)_mm_cvtsi128_si32(v12) )
		    {
		      System::Nullable<Beyond::Gameplay::Core::GameLevelLoader::SeamlessSetting>::get_Value(
		        (GameLevelLoader_SeamlessSetting *)&v16,
		        &v17,
		        MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_Value);
		      v19 = v16;
		      System::Nullable<Beyond::Gameplay::Core::GameLevelLoader::SeamlessSetting>::get_Value(
		        (GameLevelLoader_SeamlessSetting *)&v16,
		        &v18,
		        MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_Value);
		      *(_OWORD *)&v17.hasValue = *(_OWORD *)&v16.m_RenderPass;
		      *(_OWORD *)&v17.value.tpScreenFx = *(_OWORD *)&v16.m_RenderGraph;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AddChildPass(&v19, (HGRenderGraphBuilder *)&v17, 0LL);
		    }
		  }
		}
		
	}
}
