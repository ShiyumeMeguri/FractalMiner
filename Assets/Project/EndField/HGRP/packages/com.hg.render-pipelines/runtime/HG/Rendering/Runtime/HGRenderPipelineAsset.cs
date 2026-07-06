using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineAsset : RenderPipelineAsset, IVirtualTexturingEnabledRenderPipeline, IVersionable<HGRenderPipelineAsset.Version>, IMigratableAsset
	{
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000025D2 File Offset: 0x000007D2
		private HGRenderPipelineGlobalSettings globalSettings
		{
			get
			{
				// // HGRenderPipelineGlobalSettings get_globalSettings()
				// HGRenderPipelineGlobalSettings *HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D8EDA41 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
				//     byte_18D8EDA41 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings, method);
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGRenderPipelineRuntimeResources renderPipelineResources
		{
			get
			{
				// // HGRenderPipelineRuntimeResources get_renderPipelineResources()
				// HGRenderPipelineRuntimeResources *HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//   if ( !globalSettings )
				//     sub_180B536AC(v4, v3);
				//   return globalSettings.fields.m_RenderPipelineResources;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000025D2 File Offset: 0x000007D2
		public RenderPipelineSettings currentPlatformRenderPipelineSettings
		{
			get
			{
				// // RenderPipelineSettings get_currentPlatformRenderPipelineSettings()
				// RenderPipelineSettings *HG::Rendering::Runtime::HGRenderPipelineAsset::get_currentPlatformRenderPipelineSettings(
				//         RenderPipelineSettings *__return_ptr retstr,
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   RenderPipelineSettings *result; // rax
				//   __int128 v4; // xmm1
				//   __int128 v5; // xmm0
				//   __int128 v6; // xmm1
				//   __int128 v7; // xmm0
				//   __int128 v8; // xmm1
				//   __int128 v9; // xmm0
				// 
				//   result = retstr;
				//   v4 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
				//   *(_OWORD *)&retstr.colorBufferFormat = *(_OWORD *)&this.fields.m_RenderPipelineSettings.colorBufferFormat;
				//   v5 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
				//   *(_OWORD *)&retstr.dynamicResolutionSettings.DLSSSharpness = v4;
				//   v6 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
				//   *(_OWORD *)&retstr.dynamicResolutionSettings.forcedPercentage = v5;
				//   v7 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName0 = v6;
				//   v8 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName2 = v7;
				//   v9 = *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName4 = v8;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName6 = v9;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000025D2 File Offset: 0x000007D2
		public override string[] renderingLayerMaskNames
		{
			get
			{
				// // String[] get_renderingLayerMaskNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderingLayerMaskNames(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//   if ( !globalSettings )
				//     sub_180B536AC(v4, v3);
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerNames(globalSettings, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x000025D2 File Offset: 0x000007D2
		public override string[] prefixedRenderingLayerMaskNames
		{
			get
			{
				// // String[] get_prefixedRenderingLayerMaskNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_prefixedRenderingLayerMaskNames(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//   if ( !globalSettings )
				//     sub_180B536AC(v4, v3);
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerNames(globalSettings, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] lightLayerNames
		{
			get
			{
				// // String[] get_lightLayerNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_lightLayerNames(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//   if ( !globalSettings )
				//     sub_180B536AC(v4, v3);
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_lightLayerNames(globalSettings, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x000025D2 File Offset: 0x000007D2
		public override Shader defaultShader
		{
			get
			{
				// // Shader get_defaultShader()
				// Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_defaultShader(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGRenderPipelineRuntimeResources *m_RenderPipelineResources; // rax
				//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2475, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2475, 0LL);
				//     if ( !Patch )
				//       goto LABEL_8;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_908(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//     if ( globalSettings )
				//     {
				//       m_RenderPipelineResources = globalSettings.fields.m_RenderPipelineResources;
				//       if ( m_RenderPipelineResources )
				//       {
				//         shaders = m_RenderPipelineResources.fields.shaders;
				//         if ( shaders )
				//           return shaders.fields.defaultPS;
				// LABEL_8:
				//         sub_180B536AC(v5, v4);
				//       }
				//     }
				//     return 0LL;
				//   }
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000025D2 File Offset: 0x000007D2
		public Shader defaultUnlitShader
		{
			get
			{
				// // Shader get_defaultUnlitShader()
				// Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_defaultUnlitShader(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGRenderPipelineRuntimeResources *m_RenderPipelineResources; // rax
				//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2476, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2476, 0LL);
				//     if ( !Patch )
				//       goto LABEL_8;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_908(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//     if ( globalSettings )
				//     {
				//       m_RenderPipelineResources = globalSettings.fields.m_RenderPipelineResources;
				//       if ( m_RenderPipelineResources )
				//       {
				//         shaders = m_RenderPipelineResources.fields.shaders;
				//         if ( shaders )
				//           return shaders.fields.defaultUnlitPS;
				// LABEL_8:
				//         sub_180B536AC(v5, v4);
				//       }
				//     }
				//     return 0LL;
				//   }
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000025D2 File Offset: 0x000007D2
		public Shader singleColorShader
		{
			get
			{
				// // Shader get_singleColorShader()
				// Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_singleColorShader(
				//         HGRenderPipelineAsset *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineGlobalSettings *globalSettings; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGRenderPipelineRuntimeResources *m_RenderPipelineResources; // rax
				//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2477, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2477, 0LL);
				//     if ( !Patch )
				//       goto LABEL_8;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_908(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
				//     if ( globalSettings )
				//     {
				//       m_RenderPipelineResources = globalSettings.fields.m_RenderPipelineResources;
				//       if ( m_RenderPipelineResources )
				//       {
				//         shaders = m_RenderPipelineResources.fields.shaders;
				//         if ( shaders )
				//           return shaders.fields.singleColorPS;
				// LABEL_8:
				//         sub_180B536AC(v5, v4);
				//       }
				//     }
				//     return 0LL;
				//   }
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000025D0 File Offset: 0x000007D0
		internal bool useRenderGraph
		{
			get
			{
				// // Boolean get_maintainPositionOffset()
				// bool UnityEngine::Animations::Rigging::MultiParentConstraintData::get_maintainPositionOffset(
				//         MultiParentConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_MaintainPositionOffset;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_maintainPositionOffset(Boolean)
				// void UnityEngine::Animations::Rigging::MultiParentConstraintData::set_maintainPositionOffset(
				//         MultiParentConstraintData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.m_MaintainPositionOffset = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool virtualTexturingEnabled
		{
			get
			{
				// // Boolean get_alwaysRebindOnRefresh()
				// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
				//         VerticalVirtualizationController_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00002B18 File Offset: 0x00000D18
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x000025D0 File Offset: 0x000007D0
		private HGRenderPipelineAsset.Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineAsset.Version>.version
		{
			get
			{
				// // Int32 get_pressedButtons()
				// int32_t UnityEngine::UIElements::PointerEventBase<System::Object>::get_pressedButtons(
				//         PointerEventBase_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._pressedButtons_k__BackingField;
				// }
				// 
				return HGRenderPipelineAsset.Version.None;
			}
			set
			{
				// // Void set_pressedButtons(Int32)
				// void UnityEngine::UIElements::PointerEventBase<System::Object>::set_pressedButtons(
				//         PointerEventBase_1_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._pressedButtons_k__BackingField = value;
				// }
				// 
			}
		}

		private HGRenderPipelineAsset()
		{
			// // HGRenderPipelineAsset()
			// void HG::Rendering::Runtime::HGRenderPipelineAsset::HGRenderPipelineAsset(
			//         HGRenderPipelineAsset *this,
			//         MethodInfo *method)
			// {
			//   RenderPipelineSettings *v3; // rax
			//   __int128 v4; // xmm1
			//   __int128 v5; // xmm2
			//   __int128 v6; // xmm3
			//   __int128 v7; // xmm4
			//   __int128 v8; // xmm5
			//   __int128 v9; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   RenderPipelineSettings v13; // [rsp+20h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D8EDA3F )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineAsset::Version>);
			//     byte_18D8EDA3F = 1;
			//   }
			//   v3 = HG::Rendering::Runtime::RenderPipelineSettings::NewDefault(&v13, 0LL);
			//   v4 = *(_OWORD *)&v3.dynamicResolutionSettings.DLSSSharpness;
			//   v5 = *(_OWORD *)&v3.dynamicResolutionSettings.forcedPercentage;
			//   v6 = *(_OWORD *)&v3.m_ObsoleteLightLayerName0;
			//   v7 = *(_OWORD *)&v3.m_ObsoleteLightLayerName2;
			//   v8 = *(_OWORD *)&v3.m_ObsoleteLightLayerName4;
			//   v9 = *(_OWORD *)&v3.m_ObsoleteLightLayerName6;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.colorBufferFormat = *(_OWORD *)&v3.colorBufferFormat;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness = v4;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage = v5;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0 = v6;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2 = v7;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4 = v8;
			//   *(_OWORD *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6 = v9;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0,
			//     v10,
			//     v11,
			//     v12,
			//     *(MethodInfo **)&v13.colorBufferFormat,
			//     *(MethodInfo **)&v13.dynamicResolutionSettings.DLSSPerfQualitySetting);
			//   *(_WORD *)&this.fields.allowShaderVariantStripping = 257;
			//   *(_WORD *)&this.fields.enableSrpDirectCall = 257;
			//   this.fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineAsset::Version>);
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		private void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGRenderPipelineAsset::Reset(HGRenderPipelineAsset *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2472, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2472, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180040B30(31LL, this);
			//   }
			// }
			// 
		}

		protected override RenderPipeline CreatePipeline()
		{
			// // RenderPipeline CreatePipeline()
			// RenderPipeline *HG::Rendering::Runtime::HGRenderPipelineAsset::CreatePipeline(
			//         HGRenderPipelineAsset *this,
			//         MethodInfo *method)
			// {
			//   HGRenderPipeline *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   RenderPipeline *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA40 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     byte_18D8EDA40 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2473, 0LL) )
			//   {
			//     v3 = (HGRenderPipeline *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v6 = (RenderPipeline *)v3;
			//     if ( v3 )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipeline::HGRenderPipeline(v3, this, 0LL);
			//       return v6;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2473, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_907(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		protected override void OnValidate()
		{
			// // Void OnValidate()
			// void HG::Rendering::Runtime::HGRenderPipelineAsset::OnValidate(HGRenderPipelineAsset *this, MethodInfo *method)
			// {
			//   Object_1 *currentRenderPipeline; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9194F3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9194F3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2474, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2474, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.isInOnValidateCall = 1;
			//     currentRenderPipeline = (Object_1 *)UnityEngine::Rendering::GraphicsSettings::get_currentRenderPipeline(0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(currentRenderPipeline, (Object_1 *)this, 0LL) )
			//       UnityEngine::Rendering::RenderPipelineAsset::OnValidate((RenderPipelineAsset *)this, 0LL);
			//     this.fields.isInOnValidateCall = 0;
			//   }
			// }
			// 
		}

		private bool Migrate()
		{
			// // Boolean Migrate()
			// bool HG::Rendering::Runtime::HGRenderPipelineAsset::Migrate(HGRenderPipelineAsset *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGRenderPipelineAsset__Class *v4; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MigrationDescription_2_System_Int32Enum_System_Object_ v9; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDA42 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>::Migrate);
			//     byte_18D8EDA42 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2478, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2478, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset;
			//     }
			//     v9.Steps = (MigrationStep_2_System_Int32Enum_System_Object___Array *)v4.static_fields.k_Migration.Steps;
			//     return HG::Rendering::Runtime::MigrationDescription<System::Int32Enum,System::Object>::Migrate(
			//              &v9,
			//              (Object *)this,
			//              MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>::Migrate);
			//   }
			// }
			// 
			return default(bool);
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGRenderPipelineAsset::OnEnable(HGRenderPipelineAsset *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2479, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2479, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGRenderPipelineAsset::Migrate(this, 0LL);
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_OnValidate()
		{
			// // Void <>iFixBaseProxy_OnValidate()
			// void HG::Rendering::Runtime::HGRenderPipelineAsset::__iFixBaseProxy_OnValidate(
			//         HGRenderPipelineAsset *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::Rendering::RenderPipelineAsset::OnValidate((RenderPipelineAsset *)this, 0LL);
			// }
			// 
		}

		public Shader <>iFixBaseProxy_get_defaultShader()
		{
			// // Object GetBuiltinExtraResource[Object](String)
			// Object *HoudiniEngineUnity::HEU_AssetDatabase::GetBuiltinExtraResource<System::Object>(
			//         String *resourceName,
			//         MethodInfo *method)
			// {
			//   return 0LL;
			// }
			// 
			return null;
		}

		[NonSerialized]
		internal bool isInOnValidateCall;

		[SerializeField]
		[FormerlySerializedAs("renderPipelineSettings")]
		private RenderPipelineSettings m_RenderPipelineSettings;

		[SerializeField]
		internal bool allowShaderVariantStripping;

		[SerializeField]
		internal bool enableSRPBatcher;

		[SerializeField]
		internal bool enableSRPBatchInstancing;

		[NonSerialized]
		public bool enableSimpleUIRenderPath;

		[NonSerialized]
		public bool enableCppRenderPath;

		[NonSerialized]
		public bool enableSrpDirectCall;

		[SerializeField]
		private bool m_UseRenderGraph;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly MigrationDescription<HGRenderPipelineAsset.Version, HGRenderPipelineAsset> k_Migration;

		[SerializeField]
		private HGRenderPipelineAsset.Version m_Version;

		[FormerlySerializedAs("m_FrameSettings")]
		[FormerlySerializedAs("serializedFrameSettings")]
		[SerializeField]
		[Obsolete("For data migration")]
		private ObsoleteFrameSettings m_ObsoleteFrameSettings;

		[Obsolete("For data migration")]
		[FormerlySerializedAs("m_BakedOrCustomReflectionFrameSettings")]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteBakedOrCustomReflectionFrameSettings;

		[FormerlySerializedAs("m_RealtimeReflectionFrameSettings")]
		[SerializeField]
		[Obsolete("For data migration")]
		private ObsoleteFrameSettings m_ObsoleteRealtimeReflectionFrameSettings;

		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[FormerlySerializedAs("m_DefaultVolumeProfile")]
		[SerializeField]
		internal VolumeProfile m_ObsoleteDefaultVolumeProfile;

		[FormerlySerializedAs("m_DefaultLookDevProfile")]
		[SerializeField]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal VolumeProfile m_ObsoleteDefaultLookDevProfile;

		[FormerlySerializedAs("m_RenderingPathDefaultCameraFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal FrameSettings m_ObsoleteFrameSettingsMovedToDefaultSettings;

		[FormerlySerializedAs("m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal FrameSettings m_ObsoleteBakedOrCustomReflectionFrameSettingsMovedToDefaultSettings;

		[SerializeField]
		[FormerlySerializedAs("m_RenderingPathDefaultRealtimeReflectionFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal FrameSettings m_ObsoleteRealtimeReflectionFrameSettingsMovedToDefaultSettings;

		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[FormerlySerializedAs("m_RenderPipelineResources")]
		[SerializeField]
		internal HGRenderPipelineRuntimeResources m_ObsoleteRenderPipelineResources;

		[SerializeField]
		[FormerlySerializedAs("beforeTransparentCustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal List<string> m_ObsoleteBeforeTransparentCustomPostProcesses;

		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		[FormerlySerializedAs("beforePostProcessCustomPostProcesses")]
		internal List<string> m_ObsoleteBeforePostProcessCustomPostProcesses;

		[SerializeField]
		[FormerlySerializedAs("afterPostProcessCustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal List<string> m_ObsoleteAfterPostProcessCustomPostProcesses;

		[SerializeField]
		[FormerlySerializedAs("beforeTAACustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal List<string> m_ObsoleteBeforeTAACustomPostProcesses;

		[SerializeField]
		[FormerlySerializedAs("shaderVariantLogLevel")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal ShaderVariantLogLevel m_ObsoleteShaderVariantLogLevel;

		[SerializeField]
		[FormerlySerializedAs("m_LensAttenuation")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		internal LensAttenuationMode m_ObsoleteLensAttenuation;

		private enum Version
		{
			None,
			First,
			UpgradeFrameSettingsToStruct,
			AddAfterPostProcessFrameSetting,
			AddFrameSettingSpecularLighting = 5,
			AddReflectionSettings,
			AddPostProcessFrameSettings,
			AddRayTracingFrameSettings,
			AddFrameSettingDirectSpecularLighting,
			AddCustomPostprocessAndCustomPass,
			ScalableSettingsRefactor,
			ShadowFilteringVeryHighQualityRemoval,
			SeparateColorGradingAndTonemappingFrameSettings,
			ReplaceTextureArraysByAtlasForCookieAndPlanar,
			AddedAdaptiveSSS,
			RemoveCookieCubeAtlasToOctahedral2D,
			RoughDistortion,
			VirtualTexturing,
			AddedHGRenderPipelineGlobalSettings,
			DecalSurfaceGradient,
			RemovalOfUpscaleFilter
		}
	}
}
