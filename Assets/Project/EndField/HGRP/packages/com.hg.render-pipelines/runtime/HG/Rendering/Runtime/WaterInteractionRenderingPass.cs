using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class WaterInteractionRenderingPass : IPassConstructor
	{
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle interactionTexture
		{
			get
			{
				// // TextureHandle get_interactionTexture()
				// TextureHandle *HG::Rendering::Runtime::WaterInteractionRenderingPass::get_interactionTexture(
				//         TextureHandle *__return_ptr retstr,
				//         WaterInteractionRenderingPass *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_currNormalTexture;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal WaterInteractionRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // WaterInteractionRenderingPass(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::WaterInteractionRenderingPass(
			//         WaterInteractionRenderingPass *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   Array *v7; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
			//   VolumetricRenderer_VolumetricBounds *v9; // r8
			//   Material *v10; // r9
			//   __int64 v11; // rdx
			//   TextureHandle *v12; // rax
			//   __int64 v13; // rcx
			//   void *m_rippleTextureSize; // rdx
			//   TextureHandle v15; // xmm0
			//   int32_t v16; // edx
			//   int32_t v17; // ecx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v18; // rdx
			//   VolumetricRenderer_VolumetricBounds *v19; // r8
			//   Material *v20; // r9
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   Color clearColor; // xmm1
			//   int32_t v24; // edx
			//   int32_t v25; // ecx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v26; // rdx
			//   VolumetricRenderer_VolumetricBounds *v27; // r8
			//   Material *v28; // r9
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   Color v31; // xmm1
			//   __int64 v32; // rdx
			//   Texture2D *blackTexture; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v34; // rdx
			//   VolumetricRenderer_VolumetricBounds *v35; // r8
			//   Material *v36; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v38; // rdx
			//   VolumetricRenderer_VolumetricBounds *v39; // r8
			//   Material *v40; // r9
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v41; // rdx
			//   VolumetricRenderer_VolumetricBounds *v42; // r8
			//   Material *v43; // r9
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v44; // rdx
			//   VolumetricRenderer_VolumetricBounds *v45; // r8
			//   Material *v46; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v48; // rax
			//   MethodInfo *v49; // [rsp+20h] [rbp-19h] BYREF
			//   MethodInfo *v50; // [rsp+28h] [rbp-11h]
			//   TextureDesc P0; // [rsp+30h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D8EDADB )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&754109DB83C63E9C8C98A7C53D99E3E46F31281B7998A3A4D3D0A1A4A60508D5_Field);
			//     byte_18D8EDADB = 1;
			//   }
			//   v7 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 3LL, resources, method);
			//   System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//     v7,
			//     754109DB83C63E9C8C98A7C53D99E3E46F31281B7998A3A4D3D0A1A4A60508D5_Field,
			//     0LL);
			//   this.fields.m_rippleTextureSize = (Int32__Array *)v7;
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields,
			//     v8,
			//     v9,
			//     v10,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, v11);
			//   this.fields.m_prevAddTexture = *(TextureHandle *)sub_182E7CCD0(&v49);
			//   this.fields.m_currAddTexture = *(TextureHandle *)sub_182E7CCD0(&v49);
			//   this.fields.m_prevSimulateTexture = *(TextureHandle *)sub_182E7CCD0(&v49);
			//   this.fields.m_currSimulateTexture = *(TextureHandle *)sub_182E7CCD0(&v49);
			//   v12 = (TextureHandle *)sub_182E7CCD0(&v49);
			//   m_rippleTextureSize = this.fields.m_rippleTextureSize;
			//   v15 = *v12;
			//   this.fields.m_shouldRender = 1;
			//   this.fields.waterInteractionSafeDeltaTime = 0.01667;
			//   this.fields.m_currNormalTexture = v15;
			//   if ( !m_rippleTextureSize )
			//     goto LABEL_23;
			//   if ( *((_DWORD *)m_rippleTextureSize + 6) <= 1u )
			//     goto LABEL_24;
			//   v16 = *((_DWORD *)m_rippleTextureSize + 9);
			//   v17 = this.fields.m_rippleTextureSize.vector[1];
			//   memset(&P0.slices, 0, 88);
			//   P0.width = v16;
			//   P0.height = v17;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(Patch, &P0, 0LL);
			//   }
			//   else
			//   {
			//     P0.slices = 1;
			//     P0.dimension = 2;
			//   }
			//   *(_OWORD *)&this.fields.m_desc.width = *(_OWORD *)&P0.width;
			//   P0.colorFormat = 5;
			//   *(_OWORD *)&this.fields.m_desc.colorFormat = *(_OWORD *)&P0.colorFormat;
			//   *(_WORD *)&P0.useMipMap = 0;
			//   v21 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_desc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
			//   v22 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_desc.bindTextureMS = v21;
			//   clearColor = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_desc.fastMemoryDesc.inFastMemory = v22;
			//   this.fields.m_desc.clearColor = clearColor;
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_desc.name,
			//     v18,
			//     v19,
			//     v20,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			//   m_rippleTextureSize = this.fields.m_rippleTextureSize;
			//   if ( !m_rippleTextureSize )
			//     goto LABEL_23;
			//   if ( *((_DWORD *)m_rippleTextureSize + 6) <= 1u )
			// LABEL_24:
			//     sub_180070270(v13, m_rippleTextureSize);
			//   v24 = *((_DWORD *)m_rippleTextureSize + 9);
			//   v25 = this.fields.m_rippleTextureSize.vector[1];
			//   memset(&P0.slices, 0, 88);
			//   P0.width = v24;
			//   P0.height = v25;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     v48 = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !v48 )
			//       goto LABEL_23;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(v48, &P0, 0LL);
			//   }
			//   else
			//   {
			//     P0.slices = 1;
			//     P0.dimension = 2;
			//   }
			//   *(_OWORD *)&this.fields.m_normalDesc.width = *(_OWORD *)&P0.width;
			//   P0.colorFormat = 8;
			//   *(_OWORD *)&this.fields.m_normalDesc.colorFormat = *(_OWORD *)&P0.colorFormat;
			//   *(_WORD *)&P0.useMipMap = 0;
			//   v29 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_normalDesc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
			//   v30 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_normalDesc.bindTextureMS = v29;
			//   v31 = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_normalDesc.fastMemoryDesc.inFastMemory = v30;
			//   this.fields.m_normalDesc.clearColor = v31;
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_normalDesc.name,
			//     v26,
			//     v27,
			//     v28,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			//   blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RTHandles._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RTHandles, v32);
			//   this.fields.m_defaultTexture = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)blackTexture, 0LL);
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_defaultTexture,
			//     v34,
			//     v35,
			//     v36,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			//   if ( !resources.defaultResources )
			//     goto LABEL_23;
			//   shaders = resources.defaultResources.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_23;
			//   if ( !materialCollector )
			//     goto LABEL_23;
			//   this.fields.m_interactionAddMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                             materialCollector,
			//                                             shaders.fields.rippleRangePS,
			//                                             0,
			//                                             0LL);
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_interactionAddMaterial,
			//     v38,
			//     v39,
			//     v40,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			//   m_rippleTextureSize = resources.defaultResources;
			//   if ( !resources.defaultResources
			//     || (m_rippleTextureSize = (void *)*((_QWORD *)m_rippleTextureSize + 3)) == 0LL
			//     || (this.fields.m_interactionSimulateMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                        materialCollector,
			//                                                        *((Shader **)m_rippleTextureSize + 125),
			//                                                        0,
			//                                                        0LL),
			//         sub_1800054D0(
			//           (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_interactionSimulateMaterial,
			//           v41,
			//           v42,
			//           v43,
			//           v49,
			//           v50,
			//           P0.width,
			//           P0.slices,
			//           *(float *)&P0.colorFormat,
			//           P0.wrapMode,
			//           P0.enableRandomWrite,
			//           SLOBYTE(P0.mipMapBias),
			//           *(MethodInfo **)&P0.bindTextureMS),
			//         (m_rippleTextureSize = resources.defaultResources) == 0LL)
			//     || (m_rippleTextureSize = (void *)*((_QWORD *)m_rippleTextureSize + 3)) == 0LL )
			//   {
			// LABEL_23:
			//     sub_180B536AC(v13, m_rippleTextureSize);
			//   }
			//   this.fields.m_interactionHeightConvertMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                       materialCollector,
			//                                                       *((Shader **)m_rippleTextureSize + 126),
			//                                                       0,
			//                                                       0LL);
			//   sub_1800054D0(
			//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_interactionHeightConvertMaterial,
			//     v44,
			//     v45,
			//     v46,
			//     v49,
			//     v50,
			//     P0.width,
			//     P0.slices,
			//     *(float *)&P0.colorFormat,
			//     P0.wrapMode,
			//     P0.enableRandomWrite,
			//     SLOBYTE(P0.mipMapBias),
			//     *(MethodInfo **)&P0.bindTextureMS);
			// }
			// 
		}

		private bool ShouldRender(HGSettingParameters settingParameters)
		{
			// // Boolean ShouldRender(HGSettingParameters)
			// bool HG::Rendering::Runtime::WaterInteractionRenderingPass::ShouldRender(
			//         WaterInteractionRenderingPass *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9195FB )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D9195FB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2911, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         result = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(waterManager_k__BackingField, 0LL);
			//         this.fields.m_shouldRender = result;
			//         if ( !result )
			//           return result;
			//         if ( settingParameters )
			//           return HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    settingParameters.fields._waterInteractiveEnable_k__BackingField,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(waterManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2911, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)settingParameters,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private void Initialize()
		{
			// // Void Initialize()
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::Initialize(
			//         WaterInteractionRenderingPass *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2912, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2912, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(
			//         WaterInteractionRenderingPass *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   _BYTE v7[24]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDADC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDADC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2913, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2913, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, v3);
			//     this.fields.m_prevAddTexture = *(TextureHandle *)sub_182E7CCD0(v7);
			//     this.fields.m_prevSimulateTexture = *(TextureHandle *)sub_182E7CCD0(v7);
			//   }
			// }
			// 
		}

		public void Render(HGRenderGraph renderGraph, ScriptableRenderContext renderContext, HGSettingParameters settingParameters, float deltaTime)
		{
			// // Void Render(HGRenderGraph, ScriptableRenderContext, HGSettingParameters, Single)
			// // Hidden C++ exception states: #wind=4 #try_helpers=1
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
			//         WaterInteractionRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         ScriptableRenderContext renderContext,
			//         HGSettingParameters *settingParameters,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   Object *v7; // r14
			//   WaterInteractionRenderingPass *v8; // rsi
			//   ProfilingSampler *v9; // rax
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // rbx
			//   CBHandle *v14; // rax
			//   void *ptr; // xmm0_8
			//   __int64 v16; // rdx
			//   struct MethodInfo *v17; // rcx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   _DWORD *v20; // rax
			//   TextureHandle m_prevAddTexture; // xmm0
			//   TextureHandle m_prevSimulateTexture; // xmm0
			//   ProfilingSampler *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   Object__Class *v26; // xmm1_8
			//   Object *v27; // rax
			//   Object *v28; // rbx
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   TextureHandle v31; // xmm0
			//   Object *v32; // rdx
			//   unsigned int v33; // edx
			//   unsigned __int64 v34; // r8
			//   char v35; // dl
			//   signed __int64 v36; // rtt
			//   ProfilingSampler *v37; // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   Object__Class *v40; // xmm1_8
			//   Object *v41; // rax
			//   Object *v42; // r15
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   TextureHandle v45; // xmm0
			//   Object *v46; // r15
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   TextureHandle v49; // xmm0
			//   Object *v50; // rdx
			//   unsigned int v51; // edx
			//   unsigned __int64 v52; // r8
			//   char v53; // dl
			//   signed __int64 v54; // rtt
			//   Object *v55; // r15
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   TextureHandle v58; // xmm0
			//   ProfilingSampler *v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   Object__Class *v62; // xmm1_8
			//   Object *v63; // rax
			//   Object *v64; // r14
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   TextureHandle v67; // xmm0
			//   Object *v68; // rdx
			//   unsigned int v69; // edx
			//   unsigned __int64 v70; // r8
			//   char v71; // dl
			//   signed __int64 v72; // rtt
			//   Object *v73; // rbx
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   TextureHandle v76; // xmm0
			//   __int64 v77; // rdx
			//   __int64 v78; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v80; // rdx
			//   __int64 v81; // rcx
			//   TextureHandle v82; // [rsp+50h] [rbp-138h] BYREF
			//   Object *v83; // [rsp+60h] [rbp-128h] BYREF
			//   Object *v84; // [rsp+68h] [rbp-120h] BYREF
			//   Object *v85; // [rsp+70h] [rbp-118h] BYREF
			//   Color v86; // [rsp+80h] [rbp-108h] BYREF
			//   HGRenderGraphBuilder v87; // [rsp+90h] [rbp-F8h] BYREF
			//   _QWORD v88[2]; // [rsp+B0h] [rbp-D8h] BYREF
			//   HGRenderGraphBuilder v89; // [rsp+C0h] [rbp-C8h] BYREF
			//   HGRenderGraphBuilder v90; // [rsp+E0h] [rbp-A8h] BYREF
			//   HGRenderGraphBuilder v91; // [rsp+100h] [rbp-88h] BYREF
			//   HGRenderGraphProfilingScope v92; // [rsp+120h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v93; // [rsp+138h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v94; // [rsp+140h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v95; // [rsp+148h] [rbp-40h] BYREF
			//   ScriptableRenderContext P2; // [rsp+1A0h] [rbp+18h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   v7 = (Object *)renderGraph;
			//   v8 = this;
			//   if ( !byte_18D9195FC )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//     sub_18003C530(&off_18D502CC0);
			//     sub_18003C530(&off_18D502778);
			//     sub_18003C530(&off_18D502788);
			//     byte_18D9195FC = 1;
			//   }
			//   memset(&v92, 0, sizeof(v92));
			//   memset(&v90, 0, sizeof(v90));
			//   v85 = 0LL;
			//   memset(&v89, 0, sizeof(v89));
			//   v83 = 0LL;
			//   memset(&v91, 0, sizeof(v91));
			//   v84 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2914, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2914, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v81, v80);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1053(
			//       Patch,
			//       (Object *)v8,
			//       v7,
			//       P2,
			//       (Object *)settingParameters,
			//       deltaTime,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x32u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//       &v92,
			//       (HGRenderGraph *)v7,
			//       v9,
			//       0LL);
			//     v88[0] = 0LL;
			//     v88[1] = &v92;
			//     if ( HG::Rendering::Runtime::WaterInteractionRenderingPass::ShouldRender(v8, settingParameters, 0LL) )
			//     {
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         sub_1802DC2C8(v12, v11);
			//       waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v14 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v87, &P2, 320, 0LL);
			//       ptr = v14.ptr;
			//       *(_OWORD *)&v8.fields.m_cb.bufferId = *(_OWORD *)&v14.bufferId;
			//       v8.fields.m_cb.ptr = ptr;
			//       HG::Rendering::Runtime::WaterInteractionRenderingPass::UpdateWaterInteractionSafeDeltaTime(v8, deltaTime, 0LL);
			//       v17 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       if ( !waterManager_k__BackingField )
			//         sub_1802DC2C8(v17, v16);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//         (Void *)v8.fields.m_cb.ptr,
			//         waterManager_k__BackingField.fields.waterRippleData.m_Buffer,
			//         16 * waterManager_k__BackingField.fields.waterRippleData.m_Length,
			//         0LL);
			//       v20 = v8.fields.m_cb.ptr;
			//       if ( !v20 )
			//         sub_1802DC2C8(v19, v18);
			//       v20[3] = LODWORD(v8.fields.waterInteractionSafeDeltaTime);
			//       if ( !v7 )
			//         sub_1802DC2C8(v19, v18);
			//       v8.fields.m_currAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                        &v82,
			//                                        (HGRenderGraph *)v7,
			//                                        &v8.fields.m_desc,
			//                                        0LL);
			//       v8.fields.m_currSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                             &v82,
			//                                             (HGRenderGraph *)v7,
			//                                             &v8.fields.m_desc,
			//                                             0LL);
			//       v8.fields.m_currNormalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                           &v82,
			//                                           (HGRenderGraph *)v7,
			//                                           &v8.fields.m_normalDesc,
			//                                           0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8.fields.m_prevAddTexture, 0LL) )
			//         m_prevAddTexture = v8.fields.m_prevAddTexture;
			//       else
			//         m_prevAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                               &v82,
			//                               (HGRenderGraph *)v7,
			//                               v8.fields.m_defaultTexture,
			//                               0LL);
			//       v8.fields.m_prevAddTexture = m_prevAddTexture;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8.fields.m_prevSimulateTexture, 0LL) )
			//         m_prevSimulateTexture = v8.fields.m_prevSimulateTexture;
			//       else
			//         m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                    &v82,
			//                                    (HGRenderGraph *)v7,
			//                                    v8.fields.m_defaultTexture,
			//                                    0LL);
			//       v8.fields.m_prevSimulateTexture = m_prevSimulateTexture;
			//       v23 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x33u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v87,
			//         (HGRenderGraph *)v7,
			//         (String *)"Interaction Add",
			//         &v85,
			//         v23,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
			//       v90 = v87;
			//       v82.handle = 0LL;
			//       v82.fallBackResource = (ResourceHandle)&v90;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v90, 0, 0LL);
			//         v26 = (Object__Class *)v8.fields.m_cb.ptr;
			//         v27 = v85;
			//         if ( !v85 )
			//           sub_1802DC2C8(v25, v24);
			//         v85[1] = *(Object *)&v8.fields.m_cb.bufferId;
			//         v27[2].klass = v26;
			//         v28 = v85;
			//         v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v86,
			//                  &v90,
			//                  &v8.fields.m_prevSimulateTexture,
			//                  0LL);
			//         if ( !v28 )
			//           sub_1802DC2C8(v30, v29);
			//         *(TextureHandle *)&v28[2].monitor = v31;
			//         v32 = v85;
			//         if ( !v85 )
			//           sub_1802DC2C8(v30, 0LL);
			//         v85[3].monitor = (MonitorData *)v8.fields.m_interactionAddMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v33 = ((unsigned __int64)&v32[3].monitor >> 12) & 0x1FFFFF;
			//           v34 = (unsigned __int64)v33 >> 6;
			//           v35 = v33 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//           do
			//             v36 = qword_18D6405E0[v34 + 36190];
			//           while ( v36 != _InterlockedCompareExchange64(&qword_18D6405E0[v34 + 36190], v36 | (1LL << v35), v36) );
			//         }
			//         v86 = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v87,
			//           &v90,
			//           &v8.fields.m_currAddTexture,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           &v86,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v90,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass.static_fields.s_interactionAddRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v93 )
			//       {
			//         v82.handle = (ResourceHandle)v93.ex;
			//         sub_180222690(&v82);
			//         v7 = (Object *)renderGraph;
			//         v8 = this;
			//         goto LABEL_26;
			//       }
			//       sub_180222690(&v82);
			// LABEL_26:
			//       v37 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x34u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v87,
			//         (HGRenderGraph *)v7,
			//         (String *)"RippleSimulate",
			//         &v83,
			//         v37,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//       v89 = v87;
			//       v82.handle = 0LL;
			//       v82.fallBackResource = (ResourceHandle)&v89;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v89, 0, 0LL);
			//         v40 = (Object__Class *)v8.fields.m_cb.ptr;
			//         v41 = v83;
			//         if ( !v83 )
			//           sub_1802DC2C8(v39, v38);
			//         v83[1] = *(Object *)&v8.fields.m_cb.bufferId;
			//         v41[2].klass = v40;
			//         v42 = v83;
			//         v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v87,
			//                  &v89,
			//                  &v8.fields.m_prevAddTexture,
			//                  0LL);
			//         if ( !v42 )
			//           sub_1802DC2C8(v44, v43);
			//         *(TextureHandle *)&v42[2].monitor = v45;
			//         v46 = v83;
			//         v49 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v87,
			//                  &v89,
			//                  &v8.fields.m_currAddTexture,
			//                  0LL);
			//         if ( !v46 )
			//           sub_1802DC2C8(v48, v47);
			//         *(TextureHandle *)&v46[3].monitor = v49;
			//         v50 = v83;
			//         if ( !v83 )
			//           sub_1802DC2C8(v48, 0LL);
			//         v83[5].monitor = (MonitorData *)v8.fields.m_interactionSimulateMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v51 = ((unsigned __int64)&v50[5].monitor >> 12) & 0x1FFFFF;
			//           v52 = (unsigned __int64)v51 >> 6;
			//           v53 = v51 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v52 + 36190]);
			//           do
			//             v54 = qword_18D6405E0[v52 + 36190];
			//           while ( v54 != _InterlockedCompareExchange64(&qword_18D6405E0[v52 + 36190], v54 | (1LL << v53), v54) );
			//         }
			//         v55 = v83;
			//         v86 = 0LL;
			//         v58 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//                  (TextureHandle *)&v87,
			//                  &v89,
			//                  &v8.fields.m_currSimulateTexture,
			//                  0,
			//                  RenderBufferLoadAction__Enum_Clear,
			//                  RenderBufferStoreAction__Enum_Store,
			//                  &v86,
			//                  0,
			//                  0LL);
			//         if ( !v55 )
			//           sub_1802DC2C8(v57, v56);
			//         *(TextureHandle *)&v55[4].monitor = v58;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v89,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass.static_fields.s_interactionSimulateRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v94 )
			//       {
			//         v82.handle = (ResourceHandle)v94.ex;
			//         sub_180222690(&v82);
			//         v7 = (Object *)renderGraph;
			//         v8 = this;
			//         goto LABEL_37;
			//       }
			//       sub_180222690(&v82);
			// LABEL_37:
			//       v59 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x35u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v87,
			//         (HGRenderGraph *)v7,
			//         (String *)"RippleHeightConvertToNormal",
			//         &v84,
			//         v59,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
			//       v91 = v87;
			//       v82.handle = 0LL;
			//       v82.fallBackResource = (ResourceHandle)&v91;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v91, 0, 0LL);
			//         v62 = (Object__Class *)v8.fields.m_cb.ptr;
			//         v63 = v84;
			//         if ( !v84 )
			//           sub_1802DC2C8(v61, v60);
			//         v84[1] = *(Object *)&v8.fields.m_cb.bufferId;
			//         v63[2].klass = v62;
			//         v64 = v84;
			//         v67 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v87,
			//                  &v91,
			//                  &v8.fields.m_currSimulateTexture,
			//                  0LL);
			//         if ( !v64 )
			//           sub_1802DC2C8(v66, v65);
			//         *(TextureHandle *)&v64[2].monitor = v67;
			//         v68 = v84;
			//         if ( !v84 )
			//           sub_1802DC2C8(v66, 0LL);
			//         v84[4].monitor = (MonitorData *)v8.fields.m_interactionHeightConvertMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v69 = ((unsigned __int64)&v68[4].monitor >> 12) & 0x1FFFFF;
			//           v70 = (unsigned __int64)v69 >> 6;
			//           v71 = v69 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v70 + 36190]);
			//           do
			//             v72 = qword_18D6405E0[v70 + 36190];
			//           while ( v72 != _InterlockedCompareExchange64(&qword_18D6405E0[v70 + 36190], v72 | (1LL << v71), v72) );
			//         }
			//         v73 = v84;
			//         v86 = 0LL;
			//         v76 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//                  (TextureHandle *)&v87,
			//                  &v91,
			//                  &v8.fields.m_currNormalTexture,
			//                  0,
			//                  RenderBufferLoadAction__Enum_Clear,
			//                  RenderBufferStoreAction__Enum_Store,
			//                  &v86,
			//                  0,
			//                  0LL);
			//         if ( !v73 )
			//           sub_1802DC2C8(v75, v74);
			//         *(TextureHandle *)&v73[3].monitor = v76;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v91,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass.static_fields.s_interactionNormalConvertRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v95 )
			//       {
			//         v82.handle = (ResourceHandle)v95.ex;
			//         sub_180222690(&v82);
			//         sub_180224750(v88);
			//         return;
			//       }
			//       sub_180222690(&v82);
			//       sub_180224750(v88);
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(v8, 0LL);
			//       if ( !v7 )
			//         sub_1802DC2C8(v78, v77);
			//       v8.fields.m_currSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                             (TextureHandle *)&v87,
			//                                             (HGRenderGraph *)v7,
			//                                             v8.fields.m_defaultTexture,
			//                                             0LL);
			//       v8.fields.m_currNormalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                           (TextureHandle *)&v87,
			//                                           (HGRenderGraph *)v7,
			//                                           v8.fields.m_defaultTexture,
			//                                           0LL);
			//       HG::Rendering::Runtime::WaterInteractionRenderingPass::FallbackRender(v8, (HGRenderGraph *)v7, 0LL);
			//       sub_180224750(v88);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateWaterInteractionSafeDeltaTime(float dt)
		{
			// // Void UpdateWaterInteractionSafeDeltaTime(Single)
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::UpdateWaterInteractionSafeDeltaTime(
			//         WaterInteractionRenderingPass *this,
			//         float dt,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm6_4
			//   int v5; // xmm0_4
			//   float v6; // xmm0_4
			//   float v7; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   v4 = dt;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2916, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2916, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, dt, 0LL);
			//   }
			//   else
			//   {
			//     v5 = 1007192201;
			//     if ( dt < 0.0083333338 || (v5 = 1023969417, dt > 0.033333335) )
			//       v4 = *(float *)&v5;
			//     v6 = this.fields.waterInteractionSafeDeltaTime * 0.1;
			//     v7 = v4 - this.fields.waterInteractionSafeDeltaTime;
			//     if ( (float)-v6 > v7 )
			//     {
			//       v7 = -v6;
			//     }
			//     else if ( v7 > v6 )
			//     {
			//       v7 = this.fields.waterInteractionSafeDeltaTime * 0.1;
			//     }
			//     this.fields.waterInteractionSafeDeltaTime = v7 + this.fields.waterInteractionSafeDeltaTime;
			//   }
			// }
			// 
		}

		public void FallbackRender(HGRenderGraph renderGraph)
		{
			// // Void FallbackRender(HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::FallbackRender(
			//         WaterInteractionRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   int v8; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Il2CppExceptionWrapper *v12; // [rsp+40h] [rbp-58h] BYREF
			//   _QWORD v13[4]; // [rsp+48h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v14; // [rsp+68h] [rbp-30h] BYREF
			//   __int64 v15; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9195FD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//     sub_18003C530(&off_18D502788);
			//     byte_18D9195FD = 1;
			//   }
			//   memset(&v14, 0, sizeof(v14));
			//   v15 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2915, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2915, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     v5 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x34u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v7, v6);
			//     v14 = *(HGRenderGraphBuilder *)sub_180830C50(
			//                                      (unsigned int)v13,
			//                                      (_DWORD)renderGraph,
			//                                      v8,
			//                                      (unsigned int)&v15,
			//                                      (__int64)v5);
			//     v13[0] = 0LL;
			//     v13[1] = &v14;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v14, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v14,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass.static_fields.s_fallbackRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v12 )
			//     {
			//       v13[0] = v12.ex;
			//     }
			//     sub_180222690(v13);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         WaterInteractionRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2917, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2917, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         WaterInteractionRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   _BYTE v8[24]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195FE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9195FE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2918, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2918, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     this.fields.m_currAddTexture = *(TextureHandle *)sub_182E7CCD0(v8);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         WaterInteractionRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   HGRenderGraph *renderGraph; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v8; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195FF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D5027B0);
			//     byte_18D9195FF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2919, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2919, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     if ( !input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currAddTexture, 0LL) )
			//       {
			//         renderGraph = input.renderGraph;
			//         if ( renderGraph )
			//         {
			//           this.fields.m_prevAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                              &v8,
			//                                              renderGraph,
			//                                              &this.fields.m_currAddTexture,
			//                                              1,
			//                                              (String *)"WaterInteractionRenderingPass",
			//                                              0LL);
			//           renderGraph = input.renderGraph;
			//           if ( renderGraph )
			//           {
			//             this.fields.m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                     &v8,
			//                                                     renderGraph,
			//                                                     &this.fields.m_currSimulateTexture,
			//                                                     1,
			//                                                     (String *)"WaterInteractionRenderingPass",
			//                                                     0LL);
			//             return;
			//           }
			//         }
			// LABEL_11:
			//         sub_180B536AC(v5, renderGraph);
			//       }
			//     }
			//     HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(this, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private const string PASS_NAME = "WaterInteractionRenderingPass";

		private int[] m_rippleTextureSize;

		private CBHandle m_cb;

		private TextureDesc m_desc;

		private TextureDesc m_normalDesc;

		private TextureHandle m_prevAddTexture;

		private TextureHandle m_currAddTexture;

		private TextureHandle m_prevSimulateTexture;

		private TextureHandle m_currSimulateTexture;

		private TextureHandle m_currNormalTexture;

		private RTHandle m_defaultTexture;

		private Material m_interactionAddMaterial;

		private Material m_interactionSimulateMaterial;

		private Material m_interactionHeightConvertMaterial;

		private bool m_shouldRender;

		private float waterInteractionSafeDeltaTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<WaterInteractionRenderingPass.InteractionAddData> s_interactionAddRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<WaterInteractionRenderingPass.InteractionSimulateData> s_interactionSimulateRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<WaterInteractionRenderingPass.InteractionHeightConvertData> s_interactionNormalConvertRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<WaterInteractionRenderingPass.InteractionSimulateData> s_fallbackRenderFunc;

		private class InteractionAddData
		{
			public InteractionAddData()
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

			public CBHandle cb;

			public TextureHandle prevSimulationTexture;

			public Material material;
		}

		private class InteractionSimulateData
		{
			public InteractionSimulateData()
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

			public CBHandle cb;

			public TextureHandle prevAddTexture;

			public TextureHandle currAddTexture;

			public TextureHandle currSimulateTexture;

			public Material material;
		}

		private class InteractionHeightConvertData
		{
			public InteractionHeightConvertData()
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

			public CBHandle cb;

			public TextureHandle currSimulateTexture;

			public TextureHandle currSimulateNormalTexture;

			public Material material;
		}
	}
}
