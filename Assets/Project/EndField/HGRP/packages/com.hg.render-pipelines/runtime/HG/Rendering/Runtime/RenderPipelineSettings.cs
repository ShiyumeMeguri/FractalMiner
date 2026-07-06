using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
	public struct RenderPipelineSettings
	{
		internal static RenderPipelineSettings NewDefault()
		{
			// // RenderPipelineSettings NewDefault()
			// RenderPipelineSettings *HG::Rendering::Runtime::RenderPipelineSettings::NewDefault(
			//         RenderPipelineSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   GlobalDynamicResolutionSettings *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // xmm0_8
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   RenderPipelineSettings *v15; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   RenderPipelineSettings v22; // [rsp+20h] [rbp-A8h] BYREF
			//   GlobalDynamicResolutionSettings v23; // [rsp+90h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3125, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3125, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1096(&v22, Patch, 0LL);
			//     v16 = *(_OWORD *)&v15.dynamicResolutionSettings.DLSSSharpness;
			//     *(_OWORD *)&retstr.colorBufferFormat = *(_OWORD *)&v15.colorBufferFormat;
			//     v17 = *(_OWORD *)&v15.dynamicResolutionSettings.forcedPercentage;
			//     *(_OWORD *)&retstr.dynamicResolutionSettings.DLSSSharpness = v16;
			//     v18 = *(_OWORD *)&v15.m_ObsoleteLightLayerName0;
			//     *(_OWORD *)&retstr.dynamicResolutionSettings.forcedPercentage = v17;
			//     v19 = *(_OWORD *)&v15.m_ObsoleteLightLayerName2;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName0 = v18;
			//     v20 = *(_OWORD *)&v15.m_ObsoleteLightLayerName4;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName2 = v19;
			//     v21 = *(_OWORD *)&v15.m_ObsoleteLightLayerName6;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName4 = v20;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName6 = v21;
			//   }
			//   else
			//   {
			//     v22.colorBufferFormat = 74;
			//     memset(&v22.dynamicResolutionSettings.lowResTransparencyMinimumThreshold, 0, 76);
			//     v3 = UnityEngine::Rendering::GlobalDynamicResolutionSettings::NewDefault(&v23, 0LL);
			//     v4 = *(_OWORD *)&v3.maxPercentage;
			//     *(_OWORD *)&v22.dynamicResolutionSettings.enabled = *(_OWORD *)&v3.enabled;
			//     v5 = *(_QWORD *)&v3.lowResTransparencyMinimumThreshold;
			//     *(_OWORD *)&v22.dynamicResolutionSettings.maxPercentage = v4;
			//     *(_OWORD *)&retstr.colorBufferFormat = *(_OWORD *)&v22.colorBufferFormat;
			//     *(_QWORD *)&v22.dynamicResolutionSettings.lowResTransparencyMinimumThreshold = v5;
			//     v6 = *(_OWORD *)&v22.dynamicResolutionSettings.forcedPercentage;
			//     *(_OWORD *)&retstr.dynamicResolutionSettings.DLSSSharpness = *(_OWORD *)&v22.dynamicResolutionSettings.DLSSSharpness;
			//     v7 = *(_OWORD *)&v22.m_ObsoleteLightLayerName0;
			//     *(_OWORD *)&retstr.dynamicResolutionSettings.forcedPercentage = v6;
			//     v8 = *(_OWORD *)&v22.m_ObsoleteLightLayerName2;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName0 = v7;
			//     v9 = *(_OWORD *)&v22.m_ObsoleteLightLayerName4;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName2 = v8;
			//     v10 = *(_OWORD *)&v22.m_ObsoleteLightLayerName6;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName4 = v9;
			//     *(_OWORD *)&retstr.m_ObsoleteLightLayerName6 = v10;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal bool SupportsAlpha()
		{
			// // Boolean SupportsAlpha()
			// bool HG::Rendering::Runtime::RenderPipelineSettings::SupportsAlpha(RenderPipelineSettings *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91968C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D91968C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3126, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3126, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1097(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     return this.colorBufferFormat == 48;
			//   }
			// }
			// 
			return default(bool);
		}

		public RenderPipelineSettings.ColorBufferFormat colorBufferFormat;

		public GlobalDynamicResolutionSettings dynamicResolutionSettings;

		[Obsolete("For data migration")]
		internal bool m_ObsoleteincreaseSssSampleCount;

		[FormerlySerializedAs("lightLayerName0")]
		[SerializeField]
		[Obsolete("Moved to HDGlobal Settings")]
		internal string m_ObsoleteLightLayerName0;

		[SerializeField]
		[FormerlySerializedAs("lightLayerName1")]
		[Obsolete("Moved to HDGlobal Settings")]
		internal string m_ObsoleteLightLayerName1;

		[Obsolete("Moved to HDGlobal Settings")]
		[FormerlySerializedAs("lightLayerName2")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName2;

		[Obsolete("Moved to HDGlobal Settings")]
		[SerializeField]
		[FormerlySerializedAs("lightLayerName3")]
		internal string m_ObsoleteLightLayerName3;

		[SerializeField]
		[FormerlySerializedAs("lightLayerName4")]
		[Obsolete("Moved to HDGlobal Settings")]
		internal string m_ObsoleteLightLayerName4;

		[SerializeField]
		[FormerlySerializedAs("lightLayerName5")]
		[Obsolete("Moved to HDGlobal Settings")]
		internal string m_ObsoleteLightLayerName5;

		[Obsolete("Moved to HDGlobal Settings")]
		[FormerlySerializedAs("lightLayerName6")]
		[SerializeField]
		internal string m_ObsoleteLightLayerName6;

		[SerializeField]
		[FormerlySerializedAs("lightLayerName7")]
		[Obsolete("Moved to HDGlobal Settings")]
		internal string m_ObsoleteLightLayerName7;

		public enum SupportedLitShaderMode
		{
			ForwardOnly = 1,
			DeferredOnly,
			Both
		}

		public enum ColorBufferFormat
		{
			R11G11B10 = 74,
			R16G16B16A16 = 48
		}

		public enum CustomBufferFormat
		{
			R8G8B8A8 = 12,
			R16G16B16A16 = 48,
			R11G11B10 = 74
		}
	}
}
