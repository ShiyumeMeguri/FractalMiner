using System;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	internal class HGRendererListUtils
	{
		public HGRendererListUtils()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		[IDTag(1)]
		public static void DrawRendererList(HGRenderGraphContext context, RendererList rendererList, [MetadataOffset(Offset = "0x01F91A17")] bool isPassEnabled = true)
		{
			// // Void DrawRendererList(HGRenderGraphContext, RendererList, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawRendererList(
			//         HGRenderGraphContext *context,
			//         RendererList *rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   void *m_Ptr; // rbx
			//   CommandBuffer *cmd; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RendererList v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91969D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D91969D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2631, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2631, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     v14 = *rendererList;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_966(Patch, (Object *)context, &v14, isPassEnabled, 0LL);
			//   }
			//   else
			//   {
			//     if ( !context )
			//       sub_180B536AC(v8, v7);
			//     m_Ptr = context.fields.renderContext.m_Ptr;
			//     cmd = context.fields.cmd;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     v14 = *rendererList;
			//     UnityEngine::Rendering::CoreUtils::DrawRendererList((ScriptableRenderContext)m_Ptr, cmd, &v14, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList, [MetadataOffset(Offset = "0x01F91A18")] bool isPassEnabled = true)
		{
			// // Void DrawRendererList(ScriptableRenderContext, CommandBuffer, RendererList, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawRendererList(
			//         ScriptableRenderContext renderContext,
			//         CommandBuffer *cmd,
			//         RendererList *rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   RendererList v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91969E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D91969E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1045, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1045, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = *rendererList;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_376(Patch, renderContext, (Object *)cmd, &v12, isPassEnabled, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     v12 = *rendererList;
			//     UnityEngine::Rendering::CoreUtils::DrawRendererList(renderContext, cmd, &v12, 0LL);
			//   }
			// }
			// 
		}

		public static void DrawECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A19")] bool isPassEnabled = true)
		{
			// // Void DrawECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2632, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGMeshRender::DrawECSRendererList(context.fields.cmd, ecsRendererList, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2632, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawECSMeshRendererListWithSRPRendererList(HGRenderGraphContext context, uint ecsList, RendererList srpList, [MetadataOffset(Offset = "0x01F91A1A")] bool isPassEnabled = true)
		{
			// // Void DrawECSMeshRendererListWithSRPRendererList(HGRenderGraphContext, UInt32, RendererList, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawECSMeshRendererListWithSRPRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsList,
			//         RendererList *srpList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   CommandBuffer *cmd; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RendererList v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2633, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       v13 = *srpList;
			//       UnityEngine::HyperGryph::HGMeshRender::DrawECSMeshRendererListWithSRPRendererList(cmd, ecsList, &v13, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2633, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v13 = *srpList;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_967(Patch, (Object *)context, ecsList, &v13, isPassEnabled, 0LL);
			// }
			// 
		}

		public static void DrawDecalECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A1B")] bool isPassEnabled = true)
		{
			// // Void DrawDecalECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawDecalECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2630, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGDecalRender::DrawECSRendererList(context.fields.cmd, ecsRendererList, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2630, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawGrassECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A1C")] bool isPassEnabled = true)
		{
			// // Void DrawGrassECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawGrassECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3133, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGGrassRender::DrawECSRendererList(context.fields.cmd, ecsRendererList, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3133, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawSludgeECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A1D")] bool isPassEnabled = true)
		{
			// // Void DrawSludgeECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawSludgeECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3134, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGSludgeRender::DrawECSRendererList(context.fields.cmd, ecsRendererList, 0LL, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3134, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawSludgeDecalECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A1E")] bool isPassEnabled = true)
		{
			// // Void DrawSludgeDecalECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawSludgeDecalECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3135, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGSludgeRender::DrawECSDecalRendererList(context.fields.cmd, ecsRendererList, 0LL, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3135, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawSludgeBlendECSRendererList(HGRenderGraphContext context, uint ecsRendererList, [MetadataOffset(Offset = "0x01F91A1F")] bool isPassEnabled = true)
		{
			// // Void DrawSludgeBlendECSRendererList(HGRenderGraphContext, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawSludgeBlendECSRendererList(
			//         HGRenderGraphContext *context,
			//         uint32_t ecsRendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3136, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGSludgeRender::DrawECSBlendRendererList(context.fields.cmd, ecsRendererList, 0LL, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3136, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)context,
			//     (EnergyShardType__Enum)ecsRendererList,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawShadows(HGRenderGraphContext context, ref ShadowDrawingSettings shadowSettings, [MetadataOffset(Offset = "0x01F91A20")] bool isPassEnabled = true)
		{
			// // Void DrawShadows(HGRenderGraphContext, ShadowDrawingSettings ByRef, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawShadows(
			//         HGRenderGraphContext *context,
			//         ShadowDrawingSettings *shadowSettings,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91969F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D91969F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3137, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       UnityEngine::Rendering::ScriptableRenderContext::DrawShadows(&context.fields.renderContext, shadowSettings, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3137, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1104(Patch, (Object *)context, shadowSettings, isPassEnabled, 0LL);
			// }
			// 
		}

		[IDTag(0)]
		internal static void DrawOpaqueRendererList(in ScriptableRenderContext renderContext, CommandBuffer cmd, in FrameSettings frameSettings, RendererList rendererList, [MetadataOffset(Offset = "0x01F91A21")] bool isPassEnabled = true)
		{
			// // Void DrawOpaqueRendererList(ScriptableRenderContext ByRef, CommandBuffer, FrameSettings ByRef, RendererList, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueRendererList(
			//         ScriptableRenderContext *renderContext,
			//         CommandBuffer *cmd,
			//         FrameSettings *frameSettings,
			//         RendererList *rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // xmm1_8
			//   void *m_Ptr; // rcx
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   FrameSettings v14; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1044, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1044, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     v14.bitDatas = (BitArray128)*rendererList;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_377(
			//       Patch,
			//       renderContext,
			//       (Object *)cmd,
			//       frameSettings,
			//       (RendererList *)&v14,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = *(_QWORD *)&frameSettings.materialQuality;
			//     v14.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v14.materialQuality = v10;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v14, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
			//     {
			//       m_Ptr = renderContext.m_Ptr;
			//       v14.bitDatas = (BitArray128)*rendererList;
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawRendererList(
			//         (ScriptableRenderContext)m_Ptr,
			//         cmd,
			//         (RendererList *)&v14,
			//         isPassEnabled,
			//         0LL);
			//     }
			//   }
			// }
			// 
		}

		internal static void DrawOpaqueECSRendererList(CommandBuffer cmd, in FrameSettings frameSettings, uint rendererList, [MetadataOffset(Offset = "0x01F91A22")] bool isPassEnabled = true)
		{
			// // Void DrawOpaqueECSRendererList(CommandBuffer, FrameSettings ByRef, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueECSRendererList(
			//         CommandBuffer *cmd,
			//         FrameSettings *frameSettings,
			//         uint32_t rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   FrameSettings v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2625, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2625, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_962(
			//       Patch,
			//       (Object *)cmd,
			//       frameSettings,
			//       rendererList,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = *(_QWORD *)&frameSettings.materialQuality;
			//     v13.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v13.materialQuality = v9;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v13, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
			//       UnityEngine::HyperGryph::HGMeshRender::DrawECSRendererList(cmd, rendererList, 0LL);
			//   }
			// }
			// 
		}

		internal static void DrawTransparentECSRendererList(CommandBuffer cmd, in FrameSettings frameSettings, uint rendererList, [MetadataOffset(Offset = "0x01F91A23")] bool isPassEnabled = true)
		{
			// // Void DrawTransparentECSRendererList(CommandBuffer, FrameSettings ByRef, UInt32, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentECSRendererList(
			//         CommandBuffer *cmd,
			//         FrameSettings *frameSettings,
			//         uint32_t rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   FrameSettings v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2626, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2626, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_962(
			//       Patch,
			//       (Object *)cmd,
			//       frameSettings,
			//       rendererList,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = *(_QWORD *)&frameSettings.materialQuality;
			//     v13.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v13.materialQuality = v9;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v13, FrameSettingsField__Enum_TransparentObjects, 0LL) )
			//       UnityEngine::HyperGryph::HGMeshRender::DrawECSRendererList(cmd, rendererList, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		internal static void DrawTransparentRendererList(in ScriptableRenderContext renderContext, CommandBuffer cmd, in FrameSettings frameSettings, RendererList rendererList, [MetadataOffset(Offset = "0x01F91A24")] bool isPassEnabled = true)
		{
			// // Void DrawTransparentRendererList(ScriptableRenderContext ByRef, CommandBuffer, FrameSettings ByRef, RendererList, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentRendererList(
			//         ScriptableRenderContext *renderContext,
			//         CommandBuffer *cmd,
			//         FrameSettings *frameSettings,
			//         RendererList *rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // xmm1_8
			//   void *m_Ptr; // rbx
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   FrameSettings v14; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196A0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196A0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1049, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1049, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     v14.bitDatas = (BitArray128)*rendererList;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_377(
			//       Patch,
			//       renderContext,
			//       (Object *)cmd,
			//       frameSettings,
			//       (RendererList *)&v14,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = *(_QWORD *)&frameSettings.materialQuality;
			//     v14.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v14.materialQuality = v10;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v14, FrameSettingsField__Enum_TransparentObjects, 0LL) )
			//     {
			//       m_Ptr = renderContext.m_Ptr;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       v14.bitDatas = (BitArray128)*rendererList;
			//       UnityEngine::Rendering::CoreUtils::DrawRendererList(
			//         (ScriptableRenderContext)m_Ptr,
			//         cmd,
			//         (RendererList *)&v14,
			//         0LL);
			//     }
			//   }
			// }
			// 
		}

		[IDTag(1)]
		internal static void DrawOpaqueRendererList(in HGRenderGraphContext context, in FrameSettings frameSettings, in RendererList rendererList, [MetadataOffset(Offset = "0x01F91A25")] bool isPassEnabled = true)
		{
			// // Void DrawOpaqueRendererList(HGRenderGraphContext ByRef, FrameSettings ByRef, RendererList ByRef, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueRendererList(
			//         HGRenderGraphContext **context,
			//         FrameSettings *frameSettings,
			//         RendererList *rendererList,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   HGRenderGraphContext *v10; // rcx
			//   CommandBuffer *cmd; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RendererList v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3138, 0LL) )
			//   {
			//     v10 = *context;
			//     if ( *context )
			//     {
			//       cmd = v10.fields.cmd;
			//       v13 = *rendererList;
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueRendererList(
			//         &v10.fields.renderContext,
			//         cmd,
			//         frameSettings,
			//         &v13,
			//         isPassEnabled,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3138, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1105(Patch, context, frameSettings, rendererList, isPassEnabled, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		internal static void DrawTransparentRendererList(in HGRenderGraphContext context, in FrameSettings frameSettings, RendererList rendererList)
		{
			// // Void DrawTransparentRendererList(HGRenderGraphContext ByRef, FrameSettings ByRef, RendererList)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentRendererList(
			//         HGRenderGraphContext **context,
			//         FrameSettings *frameSettings,
			//         RendererList *rendererList,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphContext *v8; // rcx
			//   CommandBuffer *cmd; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RendererList v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3139, 0LL) )
			//   {
			//     v8 = *context;
			//     if ( *context )
			//     {
			//       cmd = v8.fields.cmd;
			//       v11 = *rendererList;
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentRendererList(
			//         &v8.fields.renderContext,
			//         cmd,
			//         frameSettings,
			//         &v11,
			//         1,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3139, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v11 = *rendererList;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, context, frameSettings, &v11, 0LL);
			// }
			// 
		}

		internal static void RenderForwardRendererList(FrameSettings frameSettings, RendererList rendererList, bool opaque, ScriptableRenderContext renderContext, CommandBuffer cmd, [MetadataOffset(Offset = "0x01F91A26")] bool isPassEnabled = true)
		{
			// // Void RenderForwardRendererList(FrameSettings, RendererList, Boolean, ScriptableRenderContext, CommandBuffer, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(
			//         FrameSettings *frameSettings,
			//         RendererList *rendererList,
			//         bool opaque,
			//         ScriptableRenderContext renderContext,
			//         CommandBuffer *cmd,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   BitArray128 bitDatas; // xmm1
			//   RendererList v14; // [rsp+40h] [rbp-30h] BYREF
			//   FrameSettings v15; // [rsp+50h] [rbp-20h] BYREF
			//   ScriptableRenderContext v16; // [rsp+A8h] [rbp+38h] BYREF
			// 
			//   v16.m_Ptr = renderContext.m_Ptr;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2627, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2627, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     bitDatas = frameSettings.bitDatas;
			//     v14 = *rendererList;
			//     *(_QWORD *)&v15.materialQuality = *(_QWORD *)&frameSettings.materialQuality;
			//     v15.bitDatas = bitDatas;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_964(
			//       Patch,
			//       &v15,
			//       &v14,
			//       opaque,
			//       renderContext,
			//       (Object *)cmd,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     v14 = *rendererList;
			//     if ( opaque )
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueRendererList(
			//         &v16,
			//         cmd,
			//         frameSettings,
			//         &v14,
			//         isPassEnabled,
			//         0LL);
			//     else
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentRendererList(
			//         &v16,
			//         cmd,
			//         frameSettings,
			//         &v14,
			//         isPassEnabled,
			//         0LL);
			//   }
			// }
			// 
		}

		internal static void RenderForwardECSRendererList(FrameSettings frameSettings, uint rendererList, bool opaque, CommandBuffer cmd, [MetadataOffset(Offset = "0x01F91A27")] bool isPassEnabled = true)
		{
			// // Void RenderForwardECSRendererList(FrameSettings, UInt32, Boolean, CommandBuffer, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//         FrameSettings *frameSettings,
			//         uint32_t rendererList,
			//         bool opaque,
			//         CommandBuffer *cmd,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v12; // xmm1_8
			//   FrameSettings v13; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2624, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2624, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     v12 = *(_QWORD *)&frameSettings.materialQuality;
			//     v13.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v13.materialQuality = v12;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_963(
			//       Patch,
			//       &v13,
			//       rendererList,
			//       opaque,
			//       (Object *)cmd,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else if ( opaque )
			//   {
			//     HG::Rendering::Runtime::HGRendererListUtils::DrawOpaqueECSRendererList(
			//       cmd,
			//       frameSettings,
			//       rendererList,
			//       isPassEnabled,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGRendererListUtils::DrawTransparentECSRendererList(
			//       cmd,
			//       frameSettings,
			//       rendererList,
			//       isPassEnabled,
			//       0LL);
			//   }
			// }
			// 
		}

		internal static void RenderAllDistortionObjects(ScriptableRenderContext renderContext, FrameSettings frameSettings, CommandBuffer cmd, int cameraGuid, int cameraCullingMask, RendererListHandle distortionOpaque, RendererListHandle distortionTransparent, uint opaqueECSList, uint transparentECSList)
		{
			// // Void RenderAllDistortionObjects(ScriptableRenderContext, FrameSettings, CommandBuffer, Int32, Int32, RendererListHandle, RendererListHandle, UInt32, UInt32)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderAllDistortionObjects(
			//         ScriptableRenderContext renderContext,
			//         FrameSettings *frameSettings,
			//         CommandBuffer *cmd,
			//         int32_t cameraGuid,
			//         int32_t cameraCullingMask,
			//         RendererListHandle distortionOpaque,
			//         RendererListHandle distortionTransparent,
			//         uint32_t opaqueECSList,
			//         uint32_t transparentECSList,
			//         MethodInfo *method)
			// {
			//   RendererList v14; // xmm0
			//   __int64 v15; // xmm1_8
			//   RendererList v16; // xmm0
			//   __int64 v17; // xmm1_8
			//   __int64 v18; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v20; // xmm1_8
			//   RendererList v21; // [rsp+68h] [rbp-9h] BYREF
			//   FrameSettings v22; // [rsp+78h] [rbp+7h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3140, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3140, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v18);
			//     v20 = *(_QWORD *)&frameSettings.materialQuality;
			//     v22.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v22.materialQuality = v20;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1107(
			//       Patch,
			//       renderContext,
			//       &v22,
			//       (Object *)cmd,
			//       cameraGuid,
			//       cameraCullingMask,
			//       distortionOpaque,
			//       distortionTransparent,
			//       opaqueECSList,
			//       transparentECSList,
			//       0LL);
			//   }
			//   else
			//   {
			//     v14 = *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(&v21, distortionOpaque, 0LL);
			//     v22.bitDatas = frameSettings.bitDatas;
			//     v21 = v14;
			//     *(_QWORD *)&v22.materialQuality = *(_QWORD *)&frameSettings.materialQuality;
			//     HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(&v22, &v21, 1, renderContext, cmd, 1, 0LL);
			//     v15 = *(_QWORD *)&frameSettings.materialQuality;
			//     v22.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v22.materialQuality = v15;
			//     HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(&v22, opaqueECSList, 1, cmd, 1, 0LL);
			//     v16 = *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(&v21, distortionTransparent, 0LL);
			//     v22.bitDatas = frameSettings.bitDatas;
			//     v21 = v16;
			//     *(_QWORD *)&v22.materialQuality = *(_QWORD *)&frameSettings.materialQuality;
			//     HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(&v22, &v21, 0, renderContext, cmd, 1, 0LL);
			//     v17 = *(_QWORD *)&frameSettings.materialQuality;
			//     v22.bitDatas = frameSettings.bitDatas;
			//     *(_QWORD *)&v22.materialQuality = v17;
			//     HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(&v22, transparentECSList, 0, cmd, 1, 0LL);
			//   }
			// }
			// 
		}

		public static void RenderTerrain(HGRenderGraphContext context, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, [MetadataOffset(Offset = "0x01F91A28")] int tessellationPassIndex = -1, [MetadataOffset(Offset = "0x01F91A29")] int subdivisionPassIndex = -1, [MetadataOffset(Offset = "0x01F91A2A")] bool enableSubdivisionV2 = false, [MetadataOffset(Offset = "0x01F91A2B")] bool isPassEnabled = true)
		{
			// // Void RenderTerrain(HGRenderGraphContext, UInt32, Int32, Int32, Int32, Int32, Boolean, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderTerrain(
			//         HGRenderGraphContext *context,
			//         uint32_t terrainCullViewHandle,
			//         int32_t subdivisionHandle,
			//         int32_t passIndex,
			//         int32_t tessellationPassIndex,
			//         int32_t subdivisionPassIndex,
			//         bool enableSubdivisionV2,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3141, 0LL) )
			//   {
			//     if ( !isPassEnabled )
			//       return;
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGTerrainManager::RenderTerrain(
			//         context.fields.cmd,
			//         terrainCullViewHandle,
			//         subdivisionHandle,
			//         passIndex,
			//         tessellationPassIndex,
			//         subdivisionPassIndex,
			//         enableSubdivisionV2,
			//         0LL);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(Patch, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3141, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1108(
			//     Patch,
			//     (Object *)context,
			//     terrainCullViewHandle,
			//     subdivisionHandle,
			//     passIndex,
			//     tessellationPassIndex,
			//     subdivisionPassIndex,
			//     enableSubdivisionV2,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderEditorTerrain(HGRenderGraphContext context, uint editorTerrainCullViewHandle, int subdivisionHandle, int passIndex, [MetadataOffset(Offset = "0x01F91A2C")] int subdivisionPassIndex = -1, [MetadataOffset(Offset = "0x01F91A2D")] bool enableSubdivisionV2 = false, [MetadataOffset(Offset = "0x01F91A2E")] bool isPassEnabled = true)
		{
			// // Void RenderEditorTerrain(HGRenderGraphContext, UInt32, Int32, Int32, Int32, Boolean, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderEditorTerrain(
			//         HGRenderGraphContext *context,
			//         uint32_t editorTerrainCullViewHandle,
			//         int32_t subdivisionHandle,
			//         int32_t passIndex,
			//         int32_t subdivisionPassIndex,
			//         bool enableSubdivisionV2,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3142, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGEditorTerrainManager::RenderTerrain(
			//         context.fields.cmd,
			//         editorTerrainCullViewHandle,
			//         subdivisionHandle,
			//         passIndex,
			//         subdivisionPassIndex,
			//         enableSubdivisionV2,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3142, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1109(
			//     Patch,
			//     (Object *)context,
			//     editorTerrainCullViewHandle,
			//     subdivisionHandle,
			//     passIndex,
			//     subdivisionPassIndex,
			//     enableSubdivisionV2,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderScreenSpaceTerrain(HGRenderGraphContext context, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr terrainFeatures, [MetadataOffset(Offset = "0x01F91A2F")] bool isPassEnabled = true)
		{
			// // Void RenderScreenSpaceTerrain(HGRenderGraphContext, UInt32, Int32, Int32, IntPtr, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderScreenSpaceTerrain(
			//         HGRenderGraphContext *context,
			//         uint32_t terrainCullViewHandle,
			//         int32_t feedbackViewId,
			//         int32_t passIndex,
			//         void *terrainFeatures,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3143, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGTerrainManager::RenderScreenSpaceTerrain(
			//         context.fields.cmd,
			//         terrainCullViewHandle,
			//         feedbackViewId,
			//         passIndex,
			//         terrainFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3143, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1110(
			//     Patch,
			//     (Object *)context,
			//     terrainCullViewHandle,
			//     feedbackViewId,
			//     passIndex,
			//     terrainFeatures,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderEditorSeparateTerrain(HGRenderGraphContext context, uint terrainCullViewHandle, int passIndex, IntPtr terrainFeatures, [MetadataOffset(Offset = "0x01F91A30")] bool isPassEnabled = true)
		{
			// // Void RenderEditorSeparateTerrain(HGRenderGraphContext, UInt32, Int32, IntPtr, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderEditorSeparateTerrain(
			//         HGRenderGraphContext *context,
			//         uint32_t terrainCullViewHandle,
			//         int32_t passIndex,
			//         void *terrainFeatures,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3144, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGEditorTerrainManager::RenderSeparateTerrain(
			//         context.fields.cmd,
			//         terrainCullViewHandle,
			//         passIndex,
			//         terrainFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3144, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1111(
			//     Patch,
			//     (Object *)context,
			//     terrainCullViewHandle,
			//     passIndex,
			//     terrainFeatures,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderEditorScreenSpaceTerrain(HGRenderGraphContext context, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr terrainFeatures, [MetadataOffset(Offset = "0x01F91A31")] bool isPassEnabled = true)
		{
			// // Void RenderEditorScreenSpaceTerrain(HGRenderGraphContext, UInt32, Int32, Int32, IntPtr, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderEditorScreenSpaceTerrain(
			//         HGRenderGraphContext *context,
			//         uint32_t terrainCullViewHandle,
			//         int32_t feedbackViewId,
			//         int32_t passIndex,
			//         void *terrainFeatures,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3145, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGEditorTerrainManager::RenderScreenSpaceTerrain(
			//         context.fields.cmd,
			//         terrainCullViewHandle,
			//         feedbackViewId,
			//         passIndex,
			//         terrainFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3145, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1110(
			//     Patch,
			//     (Object *)context,
			//     terrainCullViewHandle,
			//     feedbackViewId,
			//     passIndex,
			//     terrainFeatures,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderTerrainAfterGBuffer(HGRenderGraphContext context, uint terrainCullViewHandle, int feedbackViewId, IntPtr terrainFeatures, [MetadataOffset(Offset = "0x01F91A32")] bool isPassEnabled = true)
		{
			// // Void RenderTerrainAfterGBuffer(HGRenderGraphContext, UInt32, Int32, IntPtr, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderTerrainAfterGBuffer(
			//         HGRenderGraphContext *context,
			//         uint32_t terrainCullViewHandle,
			//         int32_t feedbackViewId,
			//         void *terrainFeatures,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3146, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGTerrainManager::RenderTerrainAfterGBuffer(
			//         context.fields.cmd,
			//         terrainCullViewHandle,
			//         feedbackViewId,
			//         terrainFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3146, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1111(
			//     Patch,
			//     (Object *)context,
			//     terrainCullViewHandle,
			//     feedbackViewId,
			//     terrainFeatures,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void RenderEditorTerrainAfterGBuffer(HGRenderGraphContext context, uint editorTerrainCullViewHandle, int feedbackViewId, IntPtr terrainFeatures, [MetadataOffset(Offset = "0x01F91A33")] bool isPassEnabled = true)
		{
			// // Void RenderEditorTerrainAfterGBuffer(HGRenderGraphContext, UInt32, Int32, IntPtr, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::RenderEditorTerrainAfterGBuffer(
			//         HGRenderGraphContext *context,
			//         uint32_t editorTerrainCullViewHandle,
			//         int32_t feedbackViewId,
			//         void *terrainFeatures,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3147, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       UnityEngine::HyperGryph::HGEditorTerrainManager::RenderTerrainAfterGBuffer(
			//         context.fields.cmd,
			//         editorTerrainCullViewHandle,
			//         feedbackViewId,
			//         terrainFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3147, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1111(
			//     Patch,
			//     (Object *)context,
			//     editorTerrainCullViewHandle,
			//     feedbackViewId,
			//     terrainFeatures,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawDeferredLighting(HGRenderGraphContext context, Material deferredLightingMaterial, DeferredLightingPass.DeferredLightingRenderParams renderParams, [MetadataOffset(Offset = "0x01F91A34")] bool isPassEnabled = true)
		{
			// // Void DrawDeferredLighting(HGRenderGraphContext, Material, DeferredLightingPass+DeferredLightingRenderParams, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawDeferredLighting(
			//         HGRenderGraphContext *context,
			//         Material *deferredLightingMaterial,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   CommandBuffer *cmd; // rbx
			//   __int128 v12; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v14; // xmm1
			//   DeferredLightingPass_DeferredLightingRenderParams v15; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9196A1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//     byte_18D9196A1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3148, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//       v12 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v15.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       v15.quadIndexBuffer = renderParams.quadIndexBuffer;
			//       *(_OWORD *)&v15.drawTileArgs.handle._type_k__BackingField = v12;
			//       HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLighting(
			//         context,
			//         cmd,
			//         deferredLightingMaterial,
			//         &v15,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3148, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v14 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//   *(_OWORD *)&v15.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//   v15.quadIndexBuffer = renderParams.quadIndexBuffer;
			//   *(_OWORD *)&v15.drawTileArgs.handle._type_k__BackingField = v14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1112(
			//     Patch,
			//     (Object *)context,
			//     (Object *)deferredLightingMaterial,
			//     &v15,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawDeferredLightingWriteAlpha(HGRenderGraphContext context, HGCamera hgCamera, Material deferredLightingWriteAlphaMaterial, DeferredLightingPass.DeferredLightingRenderParams renderParams, [MetadataOffset(Offset = "0x01F91A35")] bool isPassEnabled = true)
		{
			// // Void DrawDeferredLightingWriteAlpha(HGRenderGraphContext, HGCamera, Material, DeferredLightingPass+DeferredLightingRenderParams, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawDeferredLightingWriteAlpha(
			//         HGRenderGraphContext *context,
			//         HGCamera *hgCamera,
			//         Material *deferredLightingWriteAlphaMaterial,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   CommandBuffer *cmd; // rbx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm1
			//   DeferredLightingPass_DeferredLightingRenderParams v15; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9196A2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//     byte_18D9196A2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3149, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//       v13 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v15.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       v15.quadIndexBuffer = renderParams.quadIndexBuffer;
			//       *(_OWORD *)&v15.drawTileArgs.handle._type_k__BackingField = v13;
			//       HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLightingWriteAlpha(
			//         context,
			//         cmd,
			//         hgCamera,
			//         deferredLightingWriteAlphaMaterial,
			//         &v15,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3149, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v14 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//   *(_OWORD *)&v15.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//   v15.quadIndexBuffer = renderParams.quadIndexBuffer;
			//   *(_OWORD *)&v15.drawTileArgs.handle._type_k__BackingField = v14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1113(
			//     Patch,
			//     (Object *)context,
			//     (Object *)hgCamera,
			//     (Object *)deferredLightingWriteAlphaMaterial,
			//     &v15,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		public static void DrawPerLightDeferredLighting(HGRenderGraphContext context, DeferredLightingPass.DeferredLightingRenderParams renderParams, int punctualLightCount, DeferredLightingPass.LightMeshDrawRequest[] drawRequests, Material deferredLightingPerLightMaterial, Mesh sphereMesh, Mesh coneMesh, [MetadataOffset(Offset = "0x01F91A36")] bool isPassEnabled = true)
		{
			// // Void DrawPerLightDeferredLighting(HGRenderGraphContext, DeferredLightingPass+DeferredLightingRenderParams, Int32, DeferredLightingPass+LightMeshDrawRequest[], Material, Mesh, Mesh, Boolean)
			// void HG::Rendering::Runtime::HGRendererListUtils::DrawPerLightDeferredLighting(
			//         HGRenderGraphContext *context,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         int32_t punctualLightCount,
			//         DeferredLightingPass_LightMeshDrawRequest__Array *drawRequests,
			//         Material *deferredLightingPerLightMaterial,
			//         Mesh *sphereMesh,
			//         Mesh *coneMesh,
			//         bool isPassEnabled,
			//         MethodInfo *method)
			// {
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   CommandBuffer *cmd; // rbx
			//   __int128 v16; // xmm1
			//   GraphicsBuffer *quadIndexBuffer; // xmm0_8
			//   __int128 v18; // xmm1
			//   GraphicsBuffer *v19; // xmm0_8
			//   DeferredLightingPass_DeferredLightingRenderParams v20; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9196A3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//     byte_18D9196A3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3150, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//       v16 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v20.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       quadIndexBuffer = renderParams.quadIndexBuffer;
			//       *(_OWORD *)&v20.drawTileArgs.handle._type_k__BackingField = v16;
			//       v20.quadIndexBuffer = quadIndexBuffer;
			//       HG::Rendering::Runtime::DeferredLightingPass::DrawPerLightDeferredLighting(
			//         context,
			//         cmd,
			//         &v20,
			//         punctualLightCount,
			//         drawRequests,
			//         deferredLightingPerLightMaterial,
			//         sphereMesh,
			//         coneMesh,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3150, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v18 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//   *(_OWORD *)&v20.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//   v19 = renderParams.quadIndexBuffer;
			//   *(_OWORD *)&v20.drawTileArgs.handle._type_k__BackingField = v18;
			//   v20.quadIndexBuffer = v19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1114(
			//     Patch,
			//     (Object *)context,
			//     &v20,
			//     punctualLightCount,
			//     (Object *)drawRequests,
			//     (Object *)deferredLightingPerLightMaterial,
			//     (Object *)sphereMesh,
			//     (Object *)coneMesh,
			//     isPassEnabled,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		internal static RendererListDesc CreateOpaqueRendererListDesc(CullingResults cull, Camera camera, ShaderTagId passName, [MetadataOffset(Offset = "0x01F91A37")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A3B")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A3F")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A40")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A41")] bool excludeObjectMotionVectors = false, IntPtr drawableFeedbackPtr = default(IntPtr))
		{
			// // RendererListDesc CreateOpaqueRendererListDesc(CullingResults, Camera, ShaderTagId, Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean, IntPtr)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId passName,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         void *drawableFeedbackPtr,
			//         MethodInfo *method)
			// {
			//   bool v18; // zf
			//   RenderQueueRange k_RenderQueue_AllOpaque; // rax
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   RendererListDesc *v29; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v31; // rcx
			//   void *v32; // xmm0_8
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   RendererListDesc *result; // rax
			//   String__Array *v47; // [rsp+28h] [rbp-E0h]
			//   String *v48; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v49; // [rsp+38h] [rbp-D0h]
			//   CullingResults v50; // [rsp+88h] [rbp-80h] BYREF
			//   CullingResults v51; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v52; // [rsp+A8h] [rbp-60h] BYREF
			//   RendererListDesc v53; // [rsp+188h] [rbp+80h] BYREF
			// 
			//   if ( !byte_18D9196A4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     byte_18D9196A4 = 1;
			//   }
			//   sub_1802F01E0(&v52, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1046, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1046, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v31, 0LL);
			//     v32 = *(void **)&renderQueueRange.hasValue;
			//     LODWORD(v50.m_AllocationInfo) = renderQueueRange.value.m_UpperBound;
			//     v50.ptr = v32;
			//     v51 = *cull;
			//     v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(
			//             &v53,
			//             Patch,
			//             &v51,
			//             (Object *)camera,
			//             passName,
			//             screenCullingRatio,
			//             screenRatioCullingDistance,
			//             screenCullingLayerMask,
			//             rendererConfiguration,
			//             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v50,
			//             stateBlock,
			//             (Object *)overrideMaterial,
			//             excludeObjectMotionVectors,
			//             drawableFeedbackPtr,
			//             0LL);
			//   }
			//   else
			//   {
			//     v50 = *cull;
			//     UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v52, passName, &v50, camera, 0LL);
			//     v52.screenCullingLayerMask = screenCullingLayerMask;
			//     v18 = !renderQueueRange.hasValue;
			//     v52.screenCullingRatio = screenCullingRatio;
			//     v52.screenRatioCullingDistance = screenRatioCullingDistance;
			//     v52.rendererConfiguration = rendererConfiguration;
			//     if ( v18 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       k_RenderQueue_AllOpaque = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//     }
			//     else
			//     {
			//       k_RenderQueue_AllOpaque = (RenderQueueRange)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                     (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)renderQueueRange,
			//                                                     MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     }
			//     v52.renderQueueRange = k_RenderQueue_AllOpaque;
			//     v52.sortingCriteria = 59;
			//     v23 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v52.stateBlock.hasValue = *(_OWORD *)&stateBlock.hasValue;
			//     v24 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v23;
			//     v25 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v24;
			//     v26 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v25;
			//     v27 = *(_OWORD *)&stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v26;
			//     v28 = *(_OWORD *)&stateBlock.value.m_StencilState.m_FailOperationFront;
			//     *(_OWORD *)&v52.stateBlock.value.m_RasterState.m_OffsetFactor = v27;
			//     *(_OWORD *)&v52.stateBlock.value.m_StencilState.m_FailOperationFront = v28;
			//     v52.overrideMaterial = overrideMaterial;
			//     sub_1800054D0((OneofDescriptor *)&v52.overrideMaterial, v20, v21, v22, v47, v48, v49);
			//     v52.drawableFeedbackPtr = drawableFeedbackPtr;
			//     v29 = &v52;
			//     v52.excludeObjectMotionVectors = excludeObjectMotionVectors;
			//   }
			//   v33 = *(_OWORD *)&v29.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v29.sortingCriteria;
			//   v34 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v33;
			//   v35 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v34;
			//   v36 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v35;
			//   v37 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v36;
			//   v38 = *(_OWORD *)&v29.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v37;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v38;
			//   v39 = *(_OWORD *)&v29.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v29.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v39;
			//   v41 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v42 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v41;
			//   v43 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v42;
			//   v44 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v43;
			//   v45 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v44;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v45;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal static RendererListDesc CreateOpaqueRendererListDesc(CullingResults cull, Camera camera, ShaderTagId[] passNames, [MetadataOffset(Offset = "0x01F91A42")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A46")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A4A")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A4B")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A4C")] bool excludeObjectMotionVectors = false)
		{
			// // RendererListDesc CreateOpaqueRendererListDesc(CullingResults, Camera, ShaderTagId[], Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId__Array *passNames,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         MethodInfo *method)
			// {
			//   bool v17; // zf
			//   RenderQueueRange k_RenderQueue_AllOpaque; // rax
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   RendererListDesc *v28; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v30; // rcx
			//   void *v31; // xmm0_8
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   RendererListDesc *result; // rax
			//   String__Array *v46; // [rsp+28h] [rbp-E0h]
			//   String *v47; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v48; // [rsp+38h] [rbp-D0h]
			//   CullingResults v49; // [rsp+78h] [rbp-90h] BYREF
			//   CullingResults v50; // [rsp+88h] [rbp-80h] BYREF
			//   RendererListDesc v51; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v52; // [rsp+178h] [rbp+70h] BYREF
			// 
			//   if ( !byte_18D9196A5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     byte_18D9196A5 = 1;
			//   }
			//   sub_1802F01E0(&v51, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1043, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1043, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, 0LL);
			//     v31 = *(void **)&renderQueueRange.hasValue;
			//     LODWORD(v49.m_AllocationInfo) = renderQueueRange.value.m_UpperBound;
			//     v49.ptr = v31;
			//     v50 = *cull;
			//     v28 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(
			//             &v52,
			//             Patch,
			//             &v50,
			//             (Object *)camera,
			//             (Object *)passNames,
			//             screenCullingRatio,
			//             screenRatioCullingDistance,
			//             screenCullingLayerMask,
			//             rendererConfiguration,
			//             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v49,
			//             stateBlock,
			//             (Object *)overrideMaterial,
			//             excludeObjectMotionVectors,
			//             0LL);
			//   }
			//   else
			//   {
			//     v49 = *cull;
			//     UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v51, passNames, &v49, camera, 0LL);
			//     v51.screenCullingLayerMask = screenCullingLayerMask;
			//     v17 = !renderQueueRange.hasValue;
			//     v51.screenCullingRatio = screenCullingRatio;
			//     v51.screenRatioCullingDistance = screenRatioCullingDistance;
			//     v51.rendererConfiguration = rendererConfiguration;
			//     if ( v17 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       k_RenderQueue_AllOpaque = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//     }
			//     else
			//     {
			//       k_RenderQueue_AllOpaque = (RenderQueueRange)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                     (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)renderQueueRange,
			//                                                     MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     }
			//     v51.renderQueueRange = k_RenderQueue_AllOpaque;
			//     v51.sortingCriteria = 59;
			//     v22 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v51.stateBlock.hasValue = *(_OWORD *)&stateBlock.hasValue;
			//     v23 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v51.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v22;
			//     v24 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v51.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v23;
			//     v25 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v51.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v24;
			//     v26 = *(_OWORD *)&stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&v51.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v25;
			//     v27 = *(_OWORD *)&stateBlock.value.m_StencilState.m_FailOperationFront;
			//     *(_OWORD *)&v51.stateBlock.value.m_RasterState.m_OffsetFactor = v26;
			//     *(_OWORD *)&v51.stateBlock.value.m_StencilState.m_FailOperationFront = v27;
			//     v51.overrideMaterial = overrideMaterial;
			//     sub_1800054D0((OneofDescriptor *)&v51.overrideMaterial, v19, v20, v21, v46, v47, v48);
			//     v28 = &v51;
			//     v51.excludeObjectMotionVectors = excludeObjectMotionVectors;
			//   }
			//   v32 = *(_OWORD *)&v28.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v28.sortingCriteria;
			//   v33 = *(_OWORD *)&v28.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v32;
			//   v34 = *(_OWORD *)&v28.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v33;
			//   v35 = *(_OWORD *)&v28.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v34;
			//   v36 = *(_OWORD *)&v28.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v35;
			//   v37 = *(_OWORD *)&v28.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v36;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v37;
			//   v38 = *(_OWORD *)&v28.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v28.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v38;
			//   v40 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v41 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v40;
			//   v42 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v41;
			//   v43 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v42;
			//   v44 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v43;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v44;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		internal static RendererListDesc CreateTransparentRendererListDesc(CullingResults cull, Camera camera, ShaderTagId passName, [MetadataOffset(Offset = "0x01F91A4D")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A51")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A55")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A56")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A57")] bool excludeObjectMotionVectors = false, IntPtr drawableFeedbackPtr = default(IntPtr))
		{
			// // RendererListDesc CreateTransparentRendererListDesc(CullingResults, Camera, ShaderTagId, Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean, IntPtr)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId passName,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         void *drawableFeedbackPtr,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v19; // rcx
			//   int32_t cullingMask; // ebx
			//   int32_t m_Mask; // ebx
			//   bool v22; // zf
			//   RenderQueueRange k_RenderQueue_AllTransparent; // rax
			//   OneofDescriptorProto *v24; // rdx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   RendererListDesc *v33; // rax
			//   void *v34; // xmm0_8
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   RendererListDesc *result; // rax
			//   String__Array *v49; // [rsp+28h] [rbp-E0h]
			//   String *v50; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v51; // [rsp+38h] [rbp-D0h]
			//   CullingResults v52; // [rsp+88h] [rbp-80h] BYREF
			//   CullingResults v53; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v54; // [rsp+A8h] [rbp-60h] BYREF
			//   RendererListDesc v55; // [rsp+188h] [rbp+80h] BYREF
			// 
			//   if ( !byte_18D9196A6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     byte_18D9196A6 = 1;
			//   }
			//   sub_1802F01E0(&v54, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2589, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2589, 0LL);
			//     if ( Patch )
			//     {
			//       v34 = *(void **)&renderQueueRange.hasValue;
			//       LODWORD(v52.m_AllocationInfo) = renderQueueRange.value.m_UpperBound;
			//       v52.ptr = v34;
			//       v53 = *cull;
			//       v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(
			//               &v55,
			//               Patch,
			//               &v53,
			//               (Object *)camera,
			//               passName,
			//               screenCullingRatio,
			//               screenRatioCullingDistance,
			//               screenCullingLayerMask,
			//               rendererConfiguration,
			//               (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v52,
			//               stateBlock,
			//               (Object *)overrideMaterial,
			//               excludeObjectMotionVectors,
			//               drawableFeedbackPtr,
			//               0LL);
			//       goto LABEL_12;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v19, Patch);
			//   }
			//   if ( !camera )
			//     goto LABEL_10;
			//   cullingMask = UnityEngine::Camera::get_cullingMask(camera, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer((LayerMask)cullingMask, 0LL).m_Mask;
			//   v52 = *cull;
			//   UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v54, passName, &v52, camera, 0LL);
			//   v54.screenCullingLayerMask = screenCullingLayerMask;
			//   v22 = !renderQueueRange.hasValue;
			//   v54.screenCullingRatio = screenCullingRatio;
			//   v54.screenRatioCullingDistance = screenRatioCullingDistance;
			//   v54.layerMask = m_Mask;
			//   v54.rendererConfiguration = rendererConfiguration;
			//   if ( v22 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     k_RenderQueue_AllTransparent = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllTransparent;
			//   }
			//   else
			//   {
			//     k_RenderQueue_AllTransparent = (RenderQueueRange)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                        (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)renderQueueRange,
			//                                                        MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//   }
			//   v54.renderQueueRange = k_RenderQueue_AllTransparent;
			//   v54.sortingCriteria = 87;
			//   v27 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v54.stateBlock.hasValue = *(_OWORD *)&stateBlock.hasValue;
			//   v28 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v54.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v27;
			//   v29 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v54.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v28;
			//   v30 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v54.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v29;
			//   v31 = *(_OWORD *)&stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&v54.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v30;
			//   v32 = *(_OWORD *)&stateBlock.value.m_StencilState.m_FailOperationFront;
			//   *(_OWORD *)&v54.stateBlock.value.m_RasterState.m_OffsetFactor = v31;
			//   *(_OWORD *)&v54.stateBlock.value.m_StencilState.m_FailOperationFront = v32;
			//   v54.overrideMaterial = overrideMaterial;
			//   sub_1800054D0((OneofDescriptor *)&v54.overrideMaterial, v24, v25, v26, v49, v50, v51);
			//   v54.drawableFeedbackPtr = drawableFeedbackPtr;
			//   v33 = &v54;
			//   v54.excludeObjectMotionVectors = excludeObjectMotionVectors;
			// LABEL_12:
			//   v35 = *(_OWORD *)&v33.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v33.sortingCriteria;
			//   v36 = *(_OWORD *)&v33.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v35;
			//   v37 = *(_OWORD *)&v33.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v36;
			//   v38 = *(_OWORD *)&v33.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v37;
			//   v39 = *(_OWORD *)&v33.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v38;
			//   v40 = *(_OWORD *)&v33.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v39;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v40;
			//   v41 = *(_OWORD *)&v33.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v33.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v41;
			//   v43 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v44 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v43;
			//   v45 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v44;
			//   v46 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v45;
			//   v47 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v46;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v47;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal static RendererListDesc CreateTransparentRendererListDesc(CullingResults cull, Camera camera, ShaderTagId[] passNames, [MetadataOffset(Offset = "0x01F91A58")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A5C")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A60")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A61")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A62")] bool excludeObjectMotionVectors = false)
		{
			// // RendererListDesc CreateTransparentRendererListDesc(CullingResults, Camera, ShaderTagId[], Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId__Array *passNames,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v18; // rcx
			//   int32_t cullingMask; // ebx
			//   int32_t m_Mask; // ebx
			//   bool v21; // zf
			//   RenderQueueRange k_RenderQueue_AllTransparent; // rax
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   RendererListDesc *v32; // rax
			//   void *v33; // xmm0_8
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   RendererListDesc *result; // rax
			//   String__Array *v48; // [rsp+28h] [rbp-E0h]
			//   String *v49; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v50; // [rsp+38h] [rbp-D0h]
			//   CullingResults v51; // [rsp+78h] [rbp-90h] BYREF
			//   CullingResults v52; // [rsp+88h] [rbp-80h] BYREF
			//   RendererListDesc v53; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v54; // [rsp+178h] [rbp+70h] BYREF
			// 
			//   if ( !byte_18D9196A7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     byte_18D9196A7 = 1;
			//   }
			//   sub_1802F01E0(&v53, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1047, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1047, 0LL);
			//     if ( Patch )
			//     {
			//       v33 = *(void **)&renderQueueRange.hasValue;
			//       LODWORD(v51.m_AllocationInfo) = renderQueueRange.value.m_UpperBound;
			//       v51.ptr = v33;
			//       v52 = *cull;
			//       v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(
			//               &v54,
			//               Patch,
			//               &v52,
			//               (Object *)camera,
			//               (Object *)passNames,
			//               screenCullingRatio,
			//               screenRatioCullingDistance,
			//               screenCullingLayerMask,
			//               rendererConfiguration,
			//               (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v51,
			//               stateBlock,
			//               (Object *)overrideMaterial,
			//               excludeObjectMotionVectors,
			//               0LL);
			//       goto LABEL_12;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v18, Patch);
			//   }
			//   if ( !camera )
			//     goto LABEL_10;
			//   cullingMask = UnityEngine::Camera::get_cullingMask(camera, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer((LayerMask)cullingMask, 0LL).m_Mask;
			//   v51 = *cull;
			//   UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v53, passNames, &v51, camera, 0LL);
			//   v53.screenCullingLayerMask = screenCullingLayerMask;
			//   v21 = !renderQueueRange.hasValue;
			//   v53.screenCullingRatio = screenCullingRatio;
			//   v53.screenRatioCullingDistance = screenRatioCullingDistance;
			//   v53.layerMask = m_Mask;
			//   v53.rendererConfiguration = rendererConfiguration;
			//   if ( v21 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     k_RenderQueue_AllTransparent = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllTransparent;
			//   }
			//   else
			//   {
			//     k_RenderQueue_AllTransparent = (RenderQueueRange)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                        (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)renderQueueRange,
			//                                                        MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//   }
			//   v53.renderQueueRange = k_RenderQueue_AllTransparent;
			//   v53.sortingCriteria = 87;
			//   v26 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v53.stateBlock.hasValue = *(_OWORD *)&stateBlock.hasValue;
			//   v27 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v53.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v26;
			//   v28 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v53.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v27;
			//   v29 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&v53.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v28;
			//   v30 = *(_OWORD *)&stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&v53.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v29;
			//   v31 = *(_OWORD *)&stateBlock.value.m_StencilState.m_FailOperationFront;
			//   *(_OWORD *)&v53.stateBlock.value.m_RasterState.m_OffsetFactor = v30;
			//   *(_OWORD *)&v53.stateBlock.value.m_StencilState.m_FailOperationFront = v31;
			//   v53.overrideMaterial = overrideMaterial;
			//   sub_1800054D0((OneofDescriptor *)&v53.overrideMaterial, v23, v24, v25, v48, v49, v50);
			//   v32 = &v53;
			//   v53.excludeObjectMotionVectors = excludeObjectMotionVectors;
			// LABEL_12:
			//   v34 = *(_OWORD *)&v32.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v32.sortingCriteria;
			//   v35 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v34;
			//   v36 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v35;
			//   v37 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v36;
			//   v38 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v37;
			//   v39 = *(_OWORD *)&v32.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v38;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v39;
			//   v40 = *(_OWORD *)&v32.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v32.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v40;
			//   v42 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v43 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v42;
			//   v44 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v43;
			//   v45 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v44;
			//   v46 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v45;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v46;
			//   return result;
			// }
			// 
			return null;
		}

		internal static RendererListDesc CreateUIRendererListDesc(CullingResults cull, Camera camera, ShaderTagId[] passNames, int layerMask, [MetadataOffset(Offset = "0x01F91A63")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A67")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A6B")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A6C")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A6D")] bool excludeObjectMotionVectors = false, [MetadataOffset(Offset = "0x01F91A6E")] SortingCriteria sortingCriteria = SortingCriteria.SortingLayer, [MetadataOffset(Offset = "0x01F91A6F")] short sortingOrderMin = -32768, [MetadataOffset(Offset = "0x01F91A71")] short sortingOrderMax = 32767)
		{
			// // RendererListDesc CreateUIRendererListDesc(CullingResults, Camera, ShaderTagId[], Int32, Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean, SortingCriteria, Int16, Int16)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId__Array *passNames,
			//         int32_t layerMask,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         SortingCriteria__Enum sortingCriteria,
			//         int16_t sortingOrderMin,
			//         int16_t sortingOrderMax,
			//         MethodInfo *method)
			// {
			//   bool v21; // zf
			//   RenderQueueRange k_RenderQueue_AllOpaque; // rax
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   RendererListDesc *v32; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v34; // rcx
			//   void *v35; // xmm0_8
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   RendererListDesc *result; // rax
			//   String__Array *v50; // [rsp+28h] [rbp-F0h]
			//   String *v51; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *v52; // [rsp+38h] [rbp-E0h]
			//   CullingResults v53; // [rsp+98h] [rbp-80h] BYREF
			//   CullingResults v54; // [rsp+A8h] [rbp-70h] BYREF
			//   RendererListDesc v55; // [rsp+B8h] [rbp-60h] BYREF
			//   RendererListDesc v56; // [rsp+198h] [rbp+80h] BYREF
			// 
			//   if ( !byte_18D9196A8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     byte_18D9196A8 = 1;
			//   }
			//   sub_1802F01E0(&v55, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2468, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2468, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v34, 0LL);
			//     v35 = *(void **)&renderQueueRange.hasValue;
			//     LODWORD(v53.m_AllocationInfo) = renderQueueRange.value.m_UpperBound;
			//     v53.ptr = v35;
			//     v54 = *cull;
			//     v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_903(
			//             &v56,
			//             Patch,
			//             &v54,
			//             (Object *)camera,
			//             (Object *)passNames,
			//             layerMask,
			//             screenCullingRatio,
			//             screenRatioCullingDistance,
			//             screenCullingLayerMask,
			//             rendererConfiguration,
			//             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v53,
			//             stateBlock,
			//             (Object *)overrideMaterial,
			//             excludeObjectMotionVectors,
			//             sortingCriteria,
			//             sortingOrderMin,
			//             sortingOrderMax,
			//             0LL);
			//   }
			//   else
			//   {
			//     v53 = *cull;
			//     UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v55, passNames, &v53, camera, 0LL);
			//     v55.layerMask = layerMask;
			//     v21 = !renderQueueRange.hasValue;
			//     v55.screenCullingLayerMask = screenCullingLayerMask;
			//     v55.screenCullingRatio = screenCullingRatio;
			//     v55.screenRatioCullingDistance = screenRatioCullingDistance;
			//     v55.rendererConfiguration = rendererConfiguration;
			//     if ( v21 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       k_RenderQueue_AllOpaque = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//     }
			//     else
			//     {
			//       k_RenderQueue_AllOpaque = (RenderQueueRange)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                     (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)renderQueueRange,
			//                                                     MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::get_Value);
			//     }
			//     v55.renderQueueRange = k_RenderQueue_AllOpaque;
			//     v55.sortingCriteria = sortingCriteria;
			//     v26 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v55.stateBlock.hasValue = *(_OWORD *)&stateBlock.hasValue;
			//     v27 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v26;
			//     v28 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v27;
			//     v29 = *(_OWORD *)&stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v28;
			//     v30 = *(_OWORD *)&stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v29;
			//     v31 = *(_OWORD *)&stateBlock.value.m_StencilState.m_FailOperationFront;
			//     *(_OWORD *)&v55.stateBlock.value.m_RasterState.m_OffsetFactor = v30;
			//     *(_OWORD *)&v55.stateBlock.value.m_StencilState.m_FailOperationFront = v31;
			//     v55.overrideMaterial = overrideMaterial;
			//     sub_1800054D0((OneofDescriptor *)&v55.overrideMaterial, v23, v24, v25, v50, v51, v52);
			//     v55.sortingOrderMin = sortingOrderMin;
			//     v55.sortingOrderMax = sortingOrderMax;
			//     v32 = &v55;
			//     v55.excludeObjectMotionVectors = excludeObjectMotionVectors;
			//   }
			//   v36 = *(_OWORD *)&v32.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v32.sortingCriteria;
			//   v37 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v36;
			//   v38 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v37;
			//   v39 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v38;
			//   v40 = *(_OWORD *)&v32.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v39;
			//   v41 = *(_OWORD *)&v32.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v40;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v41;
			//   v42 = *(_OWORD *)&v32.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v32.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v42;
			//   v44 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v45 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v44;
			//   v46 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v45;
			//   v47 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v46;
			//   v48 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v47;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v48;
			//   return result;
			// }
			// 
			return null;
		}

		internal static RendererListDesc CreateWorldUIRendererListDesc(CullingResults cull, Camera camera, ShaderTagId[] passNames, [MetadataOffset(Offset = "0x01F91A73")] float screenCullingRatio = 0f, [MetadataOffset(Offset = "0x01F91A77")] float screenRatioCullingDistance = 0f, [MetadataOffset(Offset = "0x01F91A7B")] uint screenCullingLayerMask = 4294967295U, [MetadataOffset(Offset = "0x01F91A7C")] PerObjectData rendererConfiguration = PerObjectData.None, Nullable<RenderQueueRange> renderQueueRange = null, in Nullable<RenderStateBlock> stateBlock = null, Material overrideMaterial = null, [MetadataOffset(Offset = "0x01F91A7D")] bool excludeObjectMotionVectors = false)
		{
			// // RendererListDesc CreateWorldUIRendererListDesc(CullingResults, Camera, ShaderTagId[], Single, Single, UInt32, PerObjectData, Nullable`1[UnityEngine.Rendering.RenderQueueRange], Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef, Material, Boolean)
			// RendererListDesc *HG::Rendering::Runtime::HGRendererListUtils::CreateWorldUIRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId__Array *passNames,
			//         float screenCullingRatio,
			//         float screenRatioCullingDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum rendererConfiguration,
			//         Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *renderQueueRange,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *stateBlock,
			//         Material *overrideMaterial,
			//         bool excludeObjectMotionVectors,
			//         MethodInfo *method)
			// {
			//   LayerMask v17; // eax
			//   int32_t m_UpperBound; // ecx
			//   CullingResults v19; // xmm0
			//   RendererListDesc *v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // xmm0_8
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   RendererListDesc *result; // rax
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v38; // [rsp+90h] [rbp-80h] BYREF
			//   CullingResults v39; // [rsp+A0h] [rbp-70h] BYREF
			//   RendererListDesc v40; // [rsp+B0h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D9196A9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D9196A9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2467, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2467, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, 0LL);
			//     v23 = *(_QWORD *)&renderQueueRange.hasValue;
			//     v38.value.m_UpperBound = renderQueueRange.value.m_UpperBound;
			//     *(_QWORD *)&v38.hasValue = v23;
			//     v39 = *cull;
			//     v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(
			//             &v40,
			//             Patch,
			//             &v39,
			//             (Object *)camera,
			//             (Object *)passNames,
			//             screenCullingRatio,
			//             screenRatioCullingDistance,
			//             screenCullingLayerMask,
			//             rendererConfiguration,
			//             &v38,
			//             stateBlock,
			//             (Object *)overrideMaterial,
			//             excludeObjectMotionVectors,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     v17.m_Mask = HG::Rendering::Runtime::HGCamera::AddWorldUILayer(0, 0LL).m_Mask;
			//     m_UpperBound = renderQueueRange.value.m_UpperBound;
			//     *(_QWORD *)&v38.hasValue = *(_QWORD *)&renderQueueRange.hasValue;
			//     v19 = *cull;
			//     v38.value.m_UpperBound = m_UpperBound;
			//     v39 = v19;
			//     v20 = HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
			//             &v40,
			//             &v39,
			//             camera,
			//             passNames,
			//             v17.m_Mask,
			//             screenCullingRatio,
			//             screenRatioCullingDistance,
			//             screenCullingLayerMask,
			//             rendererConfiguration,
			//             &v38,
			//             stateBlock,
			//             overrideMaterial,
			//             excludeObjectMotionVectors,
			//             SortingCriteria__Enum_CommonTransparent|SortingCriteria__Enum_RendererPriority,
			//             0x8000,
			//             0x7FFF,
			//             0LL);
			//   }
			//   v24 = *(_OWORD *)&v20.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v20.sortingCriteria;
			//   v25 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v24;
			//   v26 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v25;
			//   v27 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v26;
			//   v28 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v27;
			//   v29 = *(_OWORD *)&v20.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v28;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v29;
			//   v30 = *(_OWORD *)&v20.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v20.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v30;
			//   v32 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v33 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v32;
			//   v34 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v33;
			//   v35 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v34;
			//   v36 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v35;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v36;
			//   return result;
			// }
			// 
			return null;
		}
	}
}
