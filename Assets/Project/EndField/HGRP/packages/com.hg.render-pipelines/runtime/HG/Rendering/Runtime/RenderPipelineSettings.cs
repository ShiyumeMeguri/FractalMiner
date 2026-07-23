using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct RenderPipelineSettings // TypeDefIndex: 38553
	{
		// Fields
		public ColorBufferFormat colorBufferFormat; // 0x00
		public GlobalDynamicResolutionSettings dynamicResolutionSettings; // 0x04
		[Obsolete("For data migration")]
		internal bool m_ObsoleteincreaseSssSampleCount; // 0x2C
		[FormerlySerializedAs("lightLayerName0")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName0; // 0x30
		[FormerlySerializedAs("lightLayerName1")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName1; // 0x38
		[FormerlySerializedAs("lightLayerName2")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName2; // 0x40
		[FormerlySerializedAs("lightLayerName3")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName3; // 0x48
		[FormerlySerializedAs("lightLayerName4")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName4; // 0x50
		[FormerlySerializedAs("lightLayerName5")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName5; // 0x58
		[FormerlySerializedAs("lightLayerName6")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName6; // 0x60
		[FormerlySerializedAs("lightLayerName7")]
		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName7; // 0x68
	
		// Nested types
		public enum SupportedLitShaderMode // TypeDefIndex: 38550
		{
			ForwardOnly = 1,
			DeferredOnly = 2,
			Both = 3
		}
	
		public enum ColorBufferFormat // TypeDefIndex: 38551
		{
			R16G16B16A16 = 48,
			R11G11B10 = 74
		}
	
		public enum CustomBufferFormat // TypeDefIndex: 38552
		{
			R8G8B8A8 = 12,
			R16G16B16A16 = 48,
			R11G11B10 = 74
		}
	
		// Methods
		internal static RenderPipelineSettings NewDefault() => default; // 0x0000000184671850-0x0000000184671920
		// RenderPipelineSettings NewDefault()
		RenderPipelineSettings *HG::Rendering::Runtime::RenderPipelineSettings::NewDefault(
		        RenderPipelineSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  GlobalDynamicResolutionSettings *v3; // rax
		  __int128 v4; // xmm1
		  __int64 v5; // xmm0_8
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  RenderPipelineSettings *v15; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  RenderPipelineSettings v22; // [rsp+20h] [rbp-A8h] BYREF
		  GlobalDynamicResolutionSettings v23; // [rsp+90h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3726, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3726, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1301(&v22, Patch, 0LL);
		    v16 = *(_OWORD *)&v15->dynamicResolutionSettings.DLSSSharpness;
		    *(_OWORD *)&retstr->colorBufferFormat = *(_OWORD *)&v15->colorBufferFormat;
		    v17 = *(_OWORD *)&v15->dynamicResolutionSettings.forcedPercentage;
		    *(_OWORD *)&retstr->dynamicResolutionSettings.DLSSSharpness = v16;
		    v18 = *(_OWORD *)&v15->m_ObsoleteLightLayerName0;
		    *(_OWORD *)&retstr->dynamicResolutionSettings.forcedPercentage = v17;
		    v19 = *(_OWORD *)&v15->m_ObsoleteLightLayerName2;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName0 = v18;
		    v20 = *(_OWORD *)&v15->m_ObsoleteLightLayerName4;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName2 = v19;
		    v21 = *(_OWORD *)&v15->m_ObsoleteLightLayerName6;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName4 = v20;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName6 = v21;
		  }
		  else
		  {
		    v22.colorBufferFormat = 74;
		    memset(&v22.dynamicResolutionSettings.lowResTransparencyMinimumThreshold, 0, 76);
		    v3 = UnityEngine::Rendering::GlobalDynamicResolutionSettings::NewDefault(&v23, 0LL);
		    v4 = *(_OWORD *)&v3->maxPercentage;
		    *(_OWORD *)&v22.dynamicResolutionSettings.enabled = *(_OWORD *)&v3->enabled;
		    v5 = *(_QWORD *)&v3->lowResTransparencyMinimumThreshold;
		    *(_OWORD *)&v22.dynamicResolutionSettings.maxPercentage = v4;
		    *(_OWORD *)&retstr->colorBufferFormat = *(_OWORD *)&v22.colorBufferFormat;
		    *(_QWORD *)&v22.dynamicResolutionSettings.lowResTransparencyMinimumThreshold = v5;
		    v6 = *(_OWORD *)&v22.dynamicResolutionSettings.forcedPercentage;
		    *(_OWORD *)&retstr->dynamicResolutionSettings.DLSSSharpness = *(_OWORD *)&v22.dynamicResolutionSettings.DLSSSharpness;
		    v7 = *(_OWORD *)&v22.m_ObsoleteLightLayerName0;
		    *(_OWORD *)&retstr->dynamicResolutionSettings.forcedPercentage = v6;
		    v8 = *(_OWORD *)&v22.m_ObsoleteLightLayerName2;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName0 = v7;
		    v9 = *(_OWORD *)&v22.m_ObsoleteLightLayerName4;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName2 = v8;
		    v10 = *(_OWORD *)&v22.m_ObsoleteLightLayerName6;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName4 = v9;
		    *(_OWORD *)&retstr->m_ObsoleteLightLayerName6 = v10;
		  }
		  return retstr;
		}
		
		internal bool SupportsAlpha() => default; // 0x0000000189C11910-0x0000000189C1196C
		// Boolean SupportsAlpha()
		bool HG::Rendering::Runtime::RenderPipelineSettings::SupportsAlpha(RenderPipelineSettings *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3727, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3727, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1302(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    return this->colorBufferFormat == 48;
		  }
		}
		
	}
}
