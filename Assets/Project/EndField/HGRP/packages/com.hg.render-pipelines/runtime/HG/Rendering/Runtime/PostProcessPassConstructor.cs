using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class PostProcessPassConstructor : ComposablePass, IPassConstructor
	{
		internal PostProcessPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		protected override Nullable<HGRenderGraphBuilder> GetRenderGraphBuilder(HGRenderGraph renderGraph)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::PostProcessPassConstructor::GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         PostProcessPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9194EC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::Nullable);
			//     byte_18D9194EC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2459, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2459, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_900(&v12, Patch, (Object *)this, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph;
			//     *(_OWORD *)&v12.hasValue = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass;
			//     *(_OWORD *)&retstr.hasValue = 0LL;
			//     *(_OWORD *)&retstr.value.m_Resources = 0LL;
			//     *(_QWORD *)&retstr.value.m_Disposed = 0LL;
			//     *(_OWORD *)&v12.value.m_Resources = v7;
			//     sub_18040CC8C(retstr, &v12);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         PostProcessPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2460, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2460, 0LL);
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
			// void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         PostProcessPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   RTHandle__Array *v5; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   RTHandle__Array *m_sceneFrostedGlassRTs; // rax
			//   HGRenderGraph *renderGraph; // rax
			//   HGRenderGraphContext *m_RenderGraphContext; // rdi
			//   CommandBuffer *cmd; // rdi
			//   int32_t FrostedGlassTexLight; // esi
			//   RenderTargetIdentifier *v12; // rax
			//   RTHandle__Array *v13; // rdx
			//   HGShaderIDs__StaticFields *v14; // rcx
			//   __int128 v15; // xmm1
			//   int32_t FrostedGlassTexMedium; // esi
			//   RenderTargetIdentifier *v17; // rax
			//   __int128 v18; // xmm1
			//   RTHandle__Array *v19; // rdx
			//   HGShaderIDs__StaticFields *v20; // rcx
			//   int32_t FrostedGlassTexHeavy; // esi
			//   RenderTargetIdentifier *v22; // rax
			//   __int128 v23; // xmm1
			//   RTHandle__Array *v24; // rdx
			//   HGShaderIDs__StaticFields *v25; // rcx
			//   int32_t FrostedGlassTexLightScene; // esi
			//   RenderTargetIdentifier *v27; // rax
			//   __int128 v28; // xmm1
			//   RTHandle__Array *v29; // rdx
			//   HGShaderIDs__StaticFields *v30; // rcx
			//   int32_t FrostedGlassTexMediumScene; // esi
			//   RenderTargetIdentifier *v32; // rax
			//   __int128 v33; // xmm1
			//   RTHandle__Array *v34; // rdx
			//   HGShaderIDs__StaticFields *v35; // rcx
			//   int32_t FrostedGlassTexHeavyScene; // esi
			//   RenderTargetIdentifier *v37; // rax
			//   __int128 v38; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RenderTargetIdentifier v40; // [rsp+20h] [rbp-60h] BYREF
			//   RenderTargetIdentifier v41; // [rsp+50h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9194ED )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D9194ED = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2461, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2461, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//       return;
			//     }
			//     goto LABEL_35;
			//   }
			//   *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass = 0LL;
			//   *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph = 0LL;
			//   m_sceneFrostedGlassRTs = this.fields.m_sceneFrostedGlassRTs;
			//   if ( !m_sceneFrostedGlassRTs )
			//     goto LABEL_35;
			//   if ( !m_sceneFrostedGlassRTs.max_length.size )
			//     goto LABEL_33;
			//   if ( !m_sceneFrostedGlassRTs.vector[0] )
			//     return;
			//   renderGraph = input.renderGraph;
			//   if ( !renderGraph
			//     || (m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext) == 0LL
			//     || (cmd = m_RenderGraphContext.fields.cmd,
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
			//         v5 = this.fields.m_sceneFrostedGlassRTs,
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields,
			//         FrostedGlassTexLight = static_fields._FrostedGlassTexLight,
			//         !v5) )
			//   {
			// LABEL_35:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   if ( !v5.max_length.size )
			// LABEL_33:
			//     sub_180070270(static_fields, v5);
			//   v12 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v5.vector[0], 0LL);
			//   if ( !cmd )
			//     goto LABEL_32;
			//   v15 = *(_OWORD *)&v12.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v12.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v12.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v15;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexLight, &v40, 0LL);
			//   v13 = this.fields.m_sceneFrostedGlassRTs;
			//   v14 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   FrostedGlassTexMedium = v14._FrostedGlassTexMedium;
			//   if ( !v13 )
			// LABEL_32:
			//     sub_180B536AC(v14, v13);
			//   if ( v13.max_length.size <= 1u )
			//     sub_180070270(v14, v13);
			//   v17 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v13.vector[1], 0LL);
			//   v18 = *(_OWORD *)&v17.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v17.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v17.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v18;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexMedium, &v40, 0LL);
			//   v19 = this.fields.m_sceneFrostedGlassRTs;
			//   v20 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   FrostedGlassTexHeavy = v20._FrostedGlassTexHeavy;
			//   if ( !v19 )
			//     sub_180B536AC(v20, 0LL);
			//   if ( v19.max_length.size <= 2u )
			//     sub_180070270(v20, v19);
			//   v22 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v19.vector[2], 0LL);
			//   v23 = *(_OWORD *)&v22.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v22.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v23;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexHeavy, &v40, 0LL);
			//   v24 = this.fields.m_sceneFrostedGlassRTs;
			//   v25 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   FrostedGlassTexLightScene = v25._FrostedGlassTexLightScene;
			//   if ( !v24 )
			//     sub_180B536AC(v25, 0LL);
			//   if ( !v24.max_length.size )
			//     sub_180070270(v25, v24);
			//   v27 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v24.vector[0], 0LL);
			//   v28 = *(_OWORD *)&v27.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v27.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v27.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v28;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexLightScene, &v40, 0LL);
			//   v29 = this.fields.m_sceneFrostedGlassRTs;
			//   v30 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   FrostedGlassTexMediumScene = v30._FrostedGlassTexMediumScene;
			//   if ( !v29 )
			//     sub_180B536AC(v30, 0LL);
			//   if ( v29.max_length.size <= 1u )
			//     sub_180070270(v30, v29);
			//   v32 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v29.vector[1], 0LL);
			//   v33 = *(_OWORD *)&v32.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v32.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v32.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v33;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexMediumScene, &v40, 0LL);
			//   v34 = this.fields.m_sceneFrostedGlassRTs;
			//   v35 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   FrostedGlassTexHeavyScene = v35._FrostedGlassTexHeavyScene;
			//   if ( !v34 )
			//     sub_180B536AC(v35, 0LL);
			//   if ( v34.max_length.size <= 2u )
			//     sub_180070270(v35, v34);
			//   v37 = UnityEngine::Rendering::RTHandle::op_Implicit(&v41, v34.vector[2], 0LL);
			//   v38 = *(_OWORD *)&v37.m_BufferPointer;
			//   *(_OWORD *)&v40.m_Type = *(_OWORD *)&v37.m_Type;
			//   *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v37.m_DepthSlice;
			//   *(_OWORD *)&v40.m_BufferPointer = v38;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexHeavyScene, &v40, 0LL);
			// }
			// 
		}

		internal void ConstructPass(ref PostProcessPassConstructor.PassInput input, ref PostProcessPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(PostProcessPassConstructor+PassInput ByRef, PostProcessPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// void HG::Rendering::Runtime::PostProcessPassConstructor::ConstructPass(
			//         PostProcessPassConstructor *this,
			//         PostProcessPassConstructor_PassInput *input,
			//         PostProcessPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // r10
			//   __int64 v16; // r10
			//   Vignette *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   __int64 v20; // r10
			//   HGVignette *v21; // r9
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   __int64 v24; // r10
			//   HGDirtyLens *v25; // r9
			//   HGRenderPathBase_HGRenderPathResources *v26; // rdx
			//   PassConstructorID__Enum__Array *v27; // r8
			//   __int64 v28; // r10
			//   HGSharpen *v29; // r9
			//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
			//   PassConstructorID__Enum__Array *v31; // r8
			//   __int64 v32; // r10
			//   HGRadialBlur *v33; // r9
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   __int64 v36; // r10
			//   HGBWFlash *v37; // r9
			//   HGRenderPathBase_HGRenderPathResources *v38; // rdx
			//   PassConstructorID__Enum__Array *v39; // r8
			//   __int64 v40; // r10
			//   HGFisheyeEffect *v41; // r9
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   __int64 v44; // r10
			//   HGChromaticAbberation *v45; // r9
			//   HGRenderPathBase_HGRenderPathResources *v46; // rdx
			//   PassConstructorID__Enum__Array *v47; // r8
			//   TextureHandle sceneColor; // xmm7
			//   TextureHandle target; // xmm0
			//   HGSharpen *m_Sharpen; // rdi
			//   Material *m_SharpenMaterial; // rbx
			//   BOOL v52; // eax
			//   TextureHandle sceneDepth; // xmm8
			//   HGFisheyeEffect *m_FisheyeEffect; // rsi
			//   Material *m_FisheyeEffectMaterial; // rdi
			//   Material *m_FisheyeEffectDepthMaterial; // rbx
			//   TextureHandle *v57; // rax
			//   int32_t m_LutSize; // esi
			//   unsigned int m_LutFormat; // edi
			//   Material *m_LutBuilder2DMaterial; // rbx
			//   TextureHandle v61; // xmm9
			//   Bloom *m_Bloom; // rsi
			//   TextureHandle sceneMV; // xmm6
			//   unsigned int taauQuality; // edi
			//   unsigned int renderPath; // ebx
			//   TextureHandle *v66; // rax
			//   int32_t v67; // r8d
			//   TextureHandle v68; // xmm10
			//   TextureHandle *v69; // rax
			//   TextureHandle v70; // xmm11
			//   TextureHandle v71; // xmm6
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3a; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3b; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3c; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3d; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3e; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3f; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3g; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3h; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4a; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4b; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4c; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4d; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4e; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4f; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4g; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P4h; // [rsp+30h] [rbp-D8h]
			//   BOOL m_EnableAlphaForUI; // [rsp+78h] [rbp-90h]
			//   TextureHandle v91; // [rsp+88h] [rbp-80h] BYREF
			//   TextureHandle v92; // [rsp+98h] [rbp-70h] BYREF
			//   TextureHandle v93; // [rsp+A8h] [rbp-60h] BYREF
			//   TextureHandle v94[7]; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   m_EnableAlphaForUI = 1;
			//   if ( !byte_18D9194EE )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D9194EE = 1;
			//   }
			//   v91 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2462, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2462, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_906(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         output,
			//         (Object *)renderGraph,
			//         (Object *)camera,
			//         (Object *)settingParameters,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_27;
			//   }
			//   if ( !camera )
			//     goto LABEL_27;
			//   m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_27;
			//   this.fields.m_Bloom = m_volumeComponentsData.fields.m_bloom;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_Bloom, v11, v13, v14, P3, P4);
			//   v17 = *(Vignette **)(v16 + 24);
			//   this.fields.m_Vignette = v17;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_Vignette, v18, v19, (HGCamera *)v17, P3a, P4a);
			//   v21 = *(HGVignette **)(v20 + 32);
			//   this.fields.m_HGVignette = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_HGVignette, v22, v23, (HGCamera *)v21, P3b, P4b);
			//   v25 = *(HGDirtyLens **)(v24 + 40);
			//   this.fields.m_HGDirtyLens = v25;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_HGDirtyLens, v26, v27, (HGCamera *)v25, P3c, P4c);
			//   v29 = *(HGSharpen **)(v28 + 48);
			//   this.fields.m_Sharpen = v29;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_Sharpen, v30, v31, (HGCamera *)v29, P3d, P4d);
			//   v33 = *(HGRadialBlur **)(v32 + 56);
			//   this.fields.m_RadialBlur = v33;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_RadialBlur, v34, v35, (HGCamera *)v33, P3e, P4e);
			//   v37 = *(HGBWFlash **)(v36 + 64);
			//   this.fields.m_BWFlash = v37;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_BWFlash, v38, v39, (HGCamera *)v37, P3f, P4f);
			//   v41 = *(HGFisheyeEffect **)(v40 + 72);
			//   this.fields.m_FisheyeEffect = v41;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_FisheyeEffect, v42, v43, (HGCamera *)v41, P3g, P4g);
			//   v45 = *(HGChromaticAbberation **)(v44 + 80);
			//   this.fields.m_chromaticAbberation = v45;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_chromaticAbberation, v46, v47, (HGCamera *)v45, P3h, P4h);
			//   this.fields.m_EnableAlphaForUI = input.render3DUI;
			//   sceneColor = input.sceneColor;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//   if ( !HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
			//   {
			//     target = input.target;
			//     v91 = sceneColor;
			//     v92 = target;
			//     HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(this, renderGraph, camera, &v92, &v91, 0LL);
			//     return;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_Sharpen;
			//   if ( !Patch )
			//     goto LABEL_27;
			//   if ( HG::Rendering::Runtime::HGSharpen::IsActive((HGSharpen *)Patch, 0LL) )
			//   {
			//     if ( !settingParameters )
			//       goto LABEL_27;
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParameters.fields._sharpenEnabled_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       m_Sharpen = this.fields.m_Sharpen;
			//       m_SharpenMaterial = this.fields.m_SharpenMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       v92 = sceneColor;
			//       sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::SharpenPass(
			//                       &v93,
			//                       renderGraph,
			//                       camera,
			//                       &v92,
			//                       m_Sharpen,
			//                       m_SharpenMaterial,
			//                       0LL);
			//     }
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_FisheyeEffect;
			//   if ( !Patch )
			// LABEL_27:
			//     sub_180B536AC(Patch, v11);
			//   if ( HG::Rendering::Runtime::HGFisheyeEffect::IsActive((HGFisheyeEffect *)Patch, 0LL) )
			//   {
			//     if ( settingParameters )
			//     {
			//       v52 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//               settingParameters.fields._fisheyeEffectEnabled_k__BackingField,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       goto LABEL_18;
			//     }
			//     goto LABEL_27;
			//   }
			//   v52 = 0;
			// LABEL_18:
			//   sceneDepth = input.sceneDepth;
			//   if ( v52 )
			//   {
			//     m_FisheyeEffect = this.fields.m_FisheyeEffect;
			//     m_FisheyeEffectMaterial = this.fields.m_FisheyeEffectMaterial;
			//     m_FisheyeEffectDepthMaterial = this.fields.m_FisheyeEffectDepthMaterial;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     v92 = sceneDepth;
			//     v93 = sceneColor;
			//     v57 = HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectPass(
			//             v94,
			//             settingParameters,
			//             renderGraph,
			//             camera,
			//             m_FisheyeEffect,
			//             m_FisheyeEffectMaterial,
			//             m_FisheyeEffectDepthMaterial,
			//             &v93,
			//             &v92,
			//             &v91,
			//             0LL);
			//     sceneDepth = v91;
			//     sceneColor = *v57;
			//   }
			//   m_LutSize = this.fields.m_LutSize;
			//   m_LutFormat = this.fields.m_LutFormat;
			//   m_LutBuilder2DMaterial = this.fields.m_LutBuilder2DMaterial;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//   v61 = *HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPass(
			//            v94,
			//            renderGraph,
			//            camera,
			//            m_LutSize,
			//            (GraphicsFormat__Enum)m_LutFormat,
			//            m_LutBuilder2DMaterial,
			//            &this.fields.m_cachedColorGradingPassData,
			//            &this.fields.m_cachedColorLut,
			//            0LL);
			//   if ( !this.fields.m_EnableAlpha )
			//     m_EnableAlphaForUI = this.fields.m_EnableAlphaForUI;
			//   m_Bloom = this.fields.m_Bloom;
			//   sceneMV = input.sceneMV;
			//   taauQuality = input.taauQuality;
			//   renderPath = input.renderPath;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//   v93 = sceneMV;
			//   v92 = sceneColor;
			//   v66 = HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
			//           v94,
			//           renderGraph,
			//           camera,
			//           settingParameters,
			//           m_Bloom,
			//           m_EnableAlphaForUI,
			//           &v92,
			//           &v93,
			//           (TAAUQuality__Enum)taauQuality,
			//           (HGRenderPathInternal__Enum)renderPath,
			//           &this.fields.m_bloomPSMaterials,
			//           &this.fields.m_BloomBicubicParams,
			//           0LL);
			//   v67 = this.fields.m_LutSize;
			//   v93 = v61;
			//   v92 = sceneColor;
			//   v68 = *v66;
			//   v69 = HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPass(
			//           v94,
			//           renderGraph,
			//           camera,
			//           settingParameters,
			//           &v92,
			//           &v93,
			//           v67,
			//           &this.fields.m_frostedGlassPSMaterials,
			//           &this.fields.m_sceneFrostedGlassRTs,
			//           &this.fields.m_sceneFrostedGlassRTSizes,
			//           0LL);
			//   v93 = sceneColor;
			//   v70 = *v69;
			//   HG::Rendering::Runtime::UberPostPassUtils::ExecuteAutoExposure(renderGraph, &v93, camera, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//   if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode )
			//     {
			//       v71 = input.target;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       v93 = sceneColor;
			//       v92 = sceneDepth;
			//       v91 = v71;
			//       sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectPass(
			//                       v94,
			//                       settingParameters,
			//                       renderGraph,
			//                       camera,
			//                       &v91,
			//                       &v92,
			//                       &v93,
			//                       0LL);
			//     }
			//   }
			//   v93 = v68;
			//   v92 = v61;
			//   v91 = sceneColor;
			//   HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
			//     v94,
			//     this,
			//     input,
			//     settingParameters,
			//     renderGraph,
			//     camera,
			//     &v91,
			//     &v92,
			//     &v93,
			//     0LL);
			//   camera.fields.didResetPostProcessingHistoryInLastFrame = camera.fields.resetPostProcessingHistory;
			//   camera.fields.resetPostProcessingHistory = 0;
			//   output.frostedGlassRT = v70;
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         PostProcessPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2470, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2470, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private void PrepareWorldUIData(UberPostPassUtils.UberPostPassData data, HGCamera hgCamera, TextureHandle depthRT)
		{
			// // Void PrepareWorldUIData(UberPostPassUtils+UberPostPassData, HGCamera, TextureHandle)
			// void HG::Rendering::Runtime::PostProcessPassConstructor::PrepareWorldUIData(
			//         PostProcessPassConstructor *this,
			//         UberPostPassUtils_UberPostPassData *data,
			//         HGCamera *hgCamera,
			//         TextureHandle *depthRT,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2466, 0LL) )
			//   {
			//     if ( data )
			//     {
			//       data.fields.sceneDepthBuffer = *depthRT;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2466, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v12 = *depthRT;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_902(Patch, (Object *)this, (Object *)data, (Object *)hgCamera, &v12, 0LL);
			// }
			// 
		}

		private TextureHandle UberPass(ref PostProcessPassConstructor.PassInput input, HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera camera, TextureHandle source, TextureHandle logLut, TextureHandle bloomTexture)
		{
			// // TextureHandle UberPass(PostProcessPassConstructor+PassInput ByRef, HGSettingParameters, HGRenderGraph, HGCamera, TextureHandle, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// TextureHandle *HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
			//         TextureHandle *__return_ptr retstr,
			//         PostProcessPassConstructor *this,
			//         PostProcessPassConstructor_PassInput *input,
			//         HGSettingParameters *settingParameters,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         TextureHandle *source,
			//         TextureHandle *logLut,
			//         TextureHandle *bloomTexture,
			//         MethodInfo *method)
			// {
			//   PostProcessPassConstructor *v12; // r13
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   int v17; // eax
			//   unsigned __int64 v18; // r8
			//   signed __int64 v19; // rtt
			//   UberPostPassUtils_UberPostPassData *v20; // rdx
			//   Material *m_UberPostMaterial; // rcx
			//   unsigned __int64 v22; // rdx
			//   unsigned __int64 v23; // r8
			//   signed __int64 v24; // rtt
			//   Material *uberPostMaterial; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   HGCamera *v28; // rbx
			//   __int64 v29; // rdi
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   Material *v32; // rbx
			//   __int64 v33; // rcx
			//   HGShaderKeyWords__StaticFields *static_fields; // rdx
			//   __int64 v35; // rdx
			//   float PostExposureLinear; // xmm0_4
			//   __int64 m_LutSize; // rcx
			//   float v38; // xmm3_4
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   HGColorGradingConfig *p_colorGradingConfig; // rax
			//   HGColorGradingConfig *v43; // rcx
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   UberPostPassUtils_UberPostPassData *v46; // rbx
			//   Texture2D *blackTexture; // rax
			//   unsigned __int64 v48; // rdx
			//   signed __int64 v49; // rcx
			//   unsigned __int64 v50; // r8
			//   signed __int64 v51; // rtt
			//   Material *v52; // rbx
			//   __int64 v53; // rcx
			//   HGShaderKeyWords__StaticFields *v54; // rdx
			//   signed __int64 v55; // rcx
			//   UberPostPassUtils_UberPostPassData *v56; // rdx
			//   unsigned __int64 v57; // rdx
			//   unsigned __int64 v58; // r8
			//   char v59; // dl
			//   signed __int64 v60; // rtt
			//   UberPostPassUtils_UberPostPassData *v61; // rbx
			//   __int64 v62; // rcx
			//   int v63; // r14d
			//   __int64 v64; // rcx
			//   int v65; // edi
			//   UberPostPassUtils_PPVignetteData *vignetteData; // r15
			//   Object *m_Vignette; // rbx
			//   Object *m_HGVignette; // r14
			//   Object *P4; // rdi
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   bool IsActive; // di
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   bool v77; // r12
			//   unsigned __int64 v78; // rdx
			//   signed __int64 v79; // rcx
			//   __int64 v80; // rdx
			//   __int64 v81; // rcx
			//   int v82; // r13d
			//   MonitorData *monitor; // rdi
			//   __int64 v84; // rdx
			//   __int64 v85; // rcx
			//   Object__Class *klass; // rdi
			//   __int64 v87; // rdx
			//   __int64 v88; // rcx
			//   uint32_t m_Value; // xmm14_4
			//   int32_t type_k__BackingField; // xmm15_4
			//   MonitorData *v91; // rdi
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   double v94; // xmm0_8
			//   float v95; // xmm12_4
			//   Object__Class *v96; // rdi
			//   __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   double v99; // xmm0_8
			//   float v100; // xmm10_4
			//   Object__Class *v101; // rdi
			//   __int64 v102; // rdx
			//   __int64 v103; // rcx
			//   MonitorData *v104; // rdi
			//   __int64 v105; // rdx
			//   __int64 v106; // rcx
			//   __m128 v107; // xmm7
			//   float v108; // xmm8_4
			//   float v109; // xmm9_4
			//   Object__Class *v110; // rdi
			//   __int64 v111; // rdx
			//   __int64 v112; // rcx
			//   __int64 v113; // rdi
			//   MonitorData *v114; // rbx
			//   __int64 v115; // rdx
			//   __int64 v116; // rcx
			//   double v117; // xmm0_8
			//   float v118; // xmm6_4
			//   MonitorData *v119; // rbx
			//   __int64 v120; // rdx
			//   __int64 v121; // rcx
			//   char v122; // r13
			//   Object__Class *v123; // rbx
			//   __int64 v124; // rdx
			//   __int64 v125; // rcx
			//   char v126; // r12
			//   Object__Class *v127; // rbx
			//   __int64 v128; // rdx
			//   __int64 v129; // rcx
			//   __m128 v130; // xmm6
			//   int32_t v131; // xmm11_4
			//   MonitorData *v132; // rbx
			//   __int64 v133; // rdx
			//   __int64 v134; // rcx
			//   double v135; // xmm0_8
			//   Object__Class *v136; // rbx
			//   double v137; // xmm0_8
			//   double v138; // xmm0_8
			//   __int64 v139; // rdx
			//   __int64 v140; // rcx
			//   Object__Class *v141; // rbx
			//   __int64 v142; // rcx
			//   HGShaderKeyWords__StaticFields *v143; // rdx
			//   Beyond::JobMathf *v144; // rcx
			//   __int64 v145; // rdx
			//   __int64 v146; // rcx
			//   __m128i si128; // xmm0
			//   unsigned __int64 v148; // r8
			//   signed __int64 v149; // rtt
			//   UberPostPassUtils_PPBloomData *bloomData; // r14
			//   Object *m_Bloom; // rdi
			//   Material *v152; // r13
			//   __m128i v153; // xmm12
			//   __int64 v154; // rdx
			//   __int64 v155; // rcx
			//   __int64 v156; // rdx
			//   __int64 v157; // rcx
			//   __int64 v158; // rdx
			//   __int64 v159; // rcx
			//   MonitorData *v160; // rbx
			//   __int64 v161; // rdx
			//   int v162; // ecx
			//   __int64 v163; // rdx
			//   __int64 v164; // rcx
			//   double v165; // xmm0_8
			//   float v166; // xmm9_4
			//   MonitorData *v167; // rbx
			//   __m128 v168; // xmm6
			//   float v169; // xmm3_4
			//   Vector4 *one; // rax
			//   __int64 v171; // rdx
			//   __int64 v172; // rcx
			//   __int64 v173; // rdx
			//   HGShaderKeyWords__StaticFields *v174; // rcx
			//   __int64 v175; // rdx
			//   __int64 v176; // rcx
			//   int32_t v177; // xmm0_4
			//   float r; // xmm2_4
			//   float v179; // xmm1_4
			//   int32_t v180; // xmm0_4
			//   unsigned __int64 v181; // r8
			//   signed __int64 v182; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v184; // rdx
			//   __int64 v185; // rcx
			//   __m128i v186; // xmm10
			//   MonitorData *v187; // rbx
			//   Object_1 *v188; // rbx
			//   __int64 v189; // rdx
			//   __int64 v190; // rcx
			//   Texture2D *v191; // rbx
			//   MonitorData *v192; // rbx
			//   __int64 v193; // rdx
			//   __int64 v194; // rcx
			//   bool dirtEnabled; // r12
			//   int v196; // r15d
			//   __int64 v197; // rdx
			//   float v198; // xmm6_4
			//   float v199; // xmm7_4
			//   Object__Class *v200; // r15
			//   __int64 v201; // rdx
			//   __int64 v202; // rcx
			//   double v203; // xmm0_8
			//   unsigned __int64 v204; // r9
			//   signed __int64 v205; // rtt
			//   int v206; // xmm1_4
			//   __int64 v207; // rdx
			//   __int64 v208; // rcx
			//   HGShaderKeyWords__StaticFields *v209; // rdx
			//   String *s_BloomDirt; // rdx
			//   HGSettingParameters *v211; // rbx
			//   HGCamera *v212; // r13
			//   UberPostPassUtils_UberPostPassData *v213; // rbx
			//   TextureHandle *v214; // rdi
			//   __int64 v215; // rdx
			//   __int64 v216; // rcx
			//   TextureHandle v217; // xmm0
			//   UberPostPassUtils_PPBloomData *v218; // rbx
			//   __int64 v219; // rdx
			//   __int64 v220; // rcx
			//   TextureHandle v221; // xmm0
			//   UberPostPassUtils_UberPostPassData *v222; // rbx
			//   __int64 v223; // rdx
			//   __int64 v224; // rcx
			//   TextureHandle v225; // xmm0
			//   UberPostPassUtils_UberPostPassData *v226; // rbx
			//   __int64 v227; // rdx
			//   __int64 v228; // rcx
			//   TextureHandle v229; // xmm0
			//   TextureHandle target; // xmm6
			//   __int64 v231; // rdx
			//   __int64 v232; // rcx
			//   CullingResults cullingResults; // xmm6
			//   Camera *v234; // rsi
			//   HGRenderPipeline *hgrp; // rax
			//   ShaderTagId__Array *uiPassNames; // r14
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm8_4
			//   uint32_t screenCullingLayerMask; // r15d
			//   RendererListDesc *v240; // rax
			//   UberPostPassUtils_UberPostPassData *v241; // rbx
			//   RendererListHandle v242; // rax
			//   RendererListHandle v243; // rdx
			//   RendererListHandle v244; // rcx
			//   __int64 v245; // rdx
			//   __int64 v246; // rcx
			//   uint32_t cullingLayerMask; // r15d
			//   UberPostPassUtils_UberPostPassData *v248; // rbx
			//   uint32_t cullingViewHandle; // r14d
			//   HGRenderGraphContext *m_RenderGraphContext; // rsi
			//   uint32_t RendererList; // eax
			//   __int64 v252; // rdx
			//   __int64 v253; // rcx
			//   UberPostPassUtils_UberPostPassData *v254; // rbx
			//   Camera *v255; // rcx
			//   __int64 v256; // rdx
			//   int32_t cullingMask; // esi
			//   Object_1 *v258; // rcx
			//   __int64 v259; // rdx
			//   __int64 v260; // rcx
			//   int32_t InstanceID; // r12d
			//   HGRenderGraphContext *v262; // r14
			//   uint32_t v263; // eax
			//   __int64 v264; // rdx
			//   __int64 v265; // rcx
			//   TextureHandle *p_sceneDepthBuffer; // rbx
			//   __int64 v267; // rdx
			//   __int64 v268; // rcx
			//   __int64 v269; // rdx
			//   __int64 v270; // rcx
			//   HGShaderKeyWords__StaticFields *v271; // rcx
			//   ILFixDynamicMethodWrapper_2 *v272; // rax
			//   __int64 v273; // rdx
			//   __int64 v274; // rcx
			//   TextureHandle *result; // rax
			//   __int64 v276; // rdx
			//   __int64 v277; // rcx
			//   ILFixDynamicMethodWrapper_2 *v278; // rbx
			//   HGRenderKeyword__Enum P3; // [rsp+20h] [rbp-508h]
			//   MethodInfo *methoda; // [rsp+30h] [rbp-4F8h]
			//   Vector4 sceneDepth; // [rsp+70h] [rbp-4B8h] BYREF
			//   UberPostPassUtils_UberPostPassData *data; // [rsp+80h] [rbp-4A8h] BYREF
			//   RendererListHandle inputa[2]; // [rsp+90h] [rbp-498h] BYREF
			//   char v284; // [rsp+A0h] [rbp-488h]
			//   TextureHandle v285; // [rsp+A8h] [rbp-480h] BYREF
			//   Color v286; // [rsp+B8h] [rbp-470h] BYREF
			//   HGRenderGraphBuilder v287; // [rsp+C8h] [rbp-460h] BYREF
			//   HGRenderGraphBuilder v288; // [rsp+F0h] [rbp-438h] BYREF
			//   Il2CppExceptionWrapper *v289; // [rsp+110h] [rbp-418h] BYREF
			//   HGColorGradingConfig v290; // [rsp+120h] [rbp-408h] BYREF
			//   RendererListDesc desc; // [rsp+290h] [rbp-298h] BYREF
			//   RendererListDesc v292; // [rsp+370h] [rbp-1B8h] BYREF
			// 
			//   v12 = this;
			//   if ( !byte_18D9194EF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     sub_18003C530(&off_18D4F3640);
			//     byte_18D9194EF = 1;
			//   }
			//   data = 0LL;
			//   sub_1802F01E0(&v290, 0LL, 368LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2464, 0LL) )
			//   {
			//     v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x9Cu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v16, v15);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v288,
			//       renderGraph,
			//       (String *)"Uber Post",
			//       (Object **)&data,
			//       v14,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
			//     v287 = v288;
			//     v288.m_RenderPass = 0LL;
			//     v288.m_Resources = (HGRenderGraphResourceRegistry *)&v287;
			//     try
			//     {
			//       v12.fields.m_renderGraphBuilder = v287;
			//       v17 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v18 = (((unsigned __int64)&v12.fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v18 + 36190]);
			//         do
			//           v19 = qword_18D6405E0[v18 + 36190];
			//         while ( v19 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v18 + 36190],
			//                          v19 | (1LL << (((unsigned __int64)&v12.fields.m_renderGraphBuilder >> 12) & 0x3F)),
			//                          v19) );
			//         v17 = dword_18D8E43F8;
			//       }
			//       v20 = data;
			//       m_UberPostMaterial = v12.fields.m_UberPostMaterial;
			//       if ( !data )
			//         sub_1802DC2C8(m_UberPostMaterial, 0LL);
			//       data.fields.uberPostMaterial = m_UberPostMaterial;
			//       if ( v17 )
			//       {
			//         v22 = ((unsigned __int64)&v20.fields >> 12) & 0x1FFFFF;
			//         v23 = v22 >> 6;
			//         v20 = (UberPostPassUtils_UberPostPassData *)(v22 & 0x3F);
			//         _m_prefetchw(&qword_18D6405E0[v23 + 36190]);
			//         do
			//         {
			//           m_UberPostMaterial = (Material *)(qword_18D6405E0[v23 + 36190] | (1LL << (char)v20));
			//           v24 = qword_18D6405E0[v23 + 36190];
			//         }
			//         while ( v24 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v23 + 36190],
			//                          (signed __int64)m_UberPostMaterial,
			//                          v24) );
			//       }
			//       if ( !data )
			//         sub_1802DC2C8(m_UberPostMaterial, v20);
			//       uberPostMaterial = data.fields.uberPostMaterial;
			//       if ( !uberPostMaterial )
			//         sub_1802DC2C8(0LL, v20);
			//       UnityEngine::Material::SetEnabledKeywords(uberPostMaterial, 0LL, 0LL);
			//       v28 = camera;
			//       if ( !camera )
			//         sub_1802DC2C8(v27, v26);
			//       v29 = 2LL;
			//       if ( ((camera.fields.m_antialiasingMode & 2) != 0
			//          || HG::Rendering::Runtime::HGCamera::get_enableMetalFXTemporalScaler(camera, 0LL))
			//         && !HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(camera, 0LL) )
			//       {
			//         if ( !data )
			//           sub_1802DC2C8(v31, v30);
			//         v32 = data.fields.uberPostMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v32 )
			//           sub_1802DC2C8(v33, static_fields);
			//         UnityEngine::Material::EnableKeyword(v32, static_fields.s_PerformSharpen, 0LL);
			//         v28 = camera;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       PostExposureLinear = HG::Rendering::Runtime::UberPostPassUtils::GetPostExposureLinear(v28, 0LL);
			//       m_LutSize = (unsigned int)v12.fields.m_LutSize;
			//       v38 = 1.0 / (float)v12.fields.m_LutSize;
			//       sceneDepth.x = 1.0 / (float)(v12.fields.m_LutSize * v12.fields.m_LutSize);
			//       sceneDepth.y = v38;
			//       sceneDepth.z = (float)(int)m_LutSize - 1.0;
			//       sceneDepth.w = PostExposureLinear;
			//       if ( !data )
			//         sub_1802DC2C8(m_LutSize, v35);
			//       data.fields.logLutSettings = sceneDepth;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//       InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v28, 0LL);
			//       if ( !InterpolatedPhase )
			//         sub_1802DC2C8(v41, v40);
			//       p_colorGradingConfig = &InterpolatedPhase.fields.colorGradingConfig;
			//       v43 = &v290;
			//       do
			//       {
			//         *(_OWORD *)&v43.tonemappingMode = *(_OWORD *)&p_colorGradingConfig.tonemappingMode;
			//         *(_OWORD *)&v43.colorLookupContribution = *(_OWORD *)&p_colorGradingConfig.colorLookupContribution;
			//         *(_OWORD *)&v43.colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled;
			//         *(_OWORD *)&v43.colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g;
			//         *(_OWORD *)&v43.colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation;
			//         *(_OWORD *)&v43.channelMixerRedOutBlueIn = *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn;
			//         *(_OWORD *)&v43.channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn;
			//         v43 = (HGColorGradingConfig *)((char *)v43 + 128);
			//         *(Vector4 *)&v43[-1].colorCurves.masterOverriding = p_colorGradingConfig.shadowsMidtonesHighlights.shadows;
			//         p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
			//         --v29;
			//       }
			//       while ( v29 );
			//       *(_OWORD *)&v43.tonemappingMode = *(_OWORD *)&p_colorGradingConfig.tonemappingMode;
			//       *(_OWORD *)&v43.colorLookupContribution = *(_OWORD *)&p_colorGradingConfig.colorLookupContribution;
			//       *(_OWORD *)&v43.colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled;
			//       *(_OWORD *)&v43.colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g;
			//       *(_OWORD *)&v43.colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation;
			//       *(_OWORD *)&v43.channelMixerRedOutBlueIn = *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn;
			//       *(_OWORD *)&v43.channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//       if ( HG::Rendering::Runtime::HGColorGradingConfig::IsColorLookupEnabled(&v290, 0LL) )
			//       {
			//         if ( !data )
			//           sub_1802DC2C8(v45, v44);
			//         v52 = data.fields.uberPostMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         v54 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v52 )
			//           sub_1802DC2C8(v53, v54);
			//         UnityEngine::Material::EnableKeyword(v52, v54.s_UserLUT, 0LL);
			//         v56 = data;
			//         if ( !data )
			//           sub_1802DC2C8(v55, 0LL);
			//         data.fields.userLut = (Texture *)v290.colorLookupTexture;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v57 = ((unsigned __int64)&v56.fields.userLut >> 12) & 0x1FFFFF;
			//           v58 = v57 >> 6;
			//           v59 = v57 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v58 + 36190]);
			//           do
			//           {
			//             v55 = qword_18D6405E0[v58 + 36190] | (1LL << v59);
			//             v60 = qword_18D6405E0[v58 + 36190];
			//           }
			//           while ( v60 != _InterlockedCompareExchange64(&qword_18D6405E0[v58 + 36190], v55, v60) );
			//         }
			//         v61 = data;
			//         if ( !v290.colorLookupTexture )
			//           sub_1802DC2C8(v55, 0LL);
			//         v63 = sub_18003ED00(5LL);
			//         if ( !v290.colorLookupTexture )
			//           sub_1802DC2C8(v62, 0LL);
			//         v65 = sub_18003ED00(7LL);
			//         if ( !v290.colorLookupTexture )
			//           sub_1802DC2C8(v64, 0LL);
			//         sceneDepth.x = 1.0 / (float)v63;
			//         sceneDepth.y = 1.0 / (float)v65;
			//         sceneDepth.z = (float)(int)sub_18003ED00(7LL) - 1.0;
			//         sceneDepth.w = v290.colorLookupContribution;
			//         if ( !v61 )
			//           sub_1802DC2C8(v49, v48);
			//         v61.fields.userLogLutSettings = sceneDepth;
			//       }
			//       else
			//       {
			//         v46 = data;
			//         blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//         if ( !v46 )
			//           sub_1802DC2C8(v49, v48);
			//         v46.fields.userLut = (Texture *)blackTexture;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v50 = (((unsigned __int64)&v46.fields.userLut >> 12) & 0x1FFFFF) >> 6;
			//           v48 = ((unsigned __int64)&v46.fields.userLut >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//           {
			//             v49 = qword_18D6405E0[v50 + 36190] | (1LL << v48);
			//             v51 = qword_18D6405E0[v50 + 36190];
			//           }
			//           while ( v51 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v49, v51) );
			//         }
			//         if ( !data )
			//           sub_1802DC2C8(v49, v48);
			//         data.fields.userLogLutSettings = 0LL;
			//       }
			//       if ( !data )
			//         sub_1802DC2C8(v49, v48);
			//       vignetteData = data.fields.vignetteData;
			//       m_Vignette = (Object *)v12.fields.m_Vignette;
			//       m_HGVignette = (Object *)v12.fields.m_HGVignette;
			//       P4 = (Object *)v12.fields.m_UberPostMaterial;
			//       inputa[0] = (RendererListHandle)P4;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       if ( !byte_18D9194DA )
			//       {
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//         byte_18D9194DA = 1;
			//       }
			//       sceneDepth = 0LL;
			//       if ( IFix::WrappersManagerImpl::IsPatched(2451, 0LL) )
			//       {
			//         Patch = IFix::WrappersManagerImpl::GetPatch(2451, 0LL);
			//         if ( !Patch )
			//           sub_1802DC2C8(v185, v184);
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
			//           (ILFixDynamicMethodWrapper_18 *)Patch,
			//           (Object *)settingParameters,
			//           (Object *)vignetteData,
			//           m_Vignette,
			//           m_HGVignette,
			//           P4,
			//           0LL);
			//       }
			//       else
			//       {
			//         if ( !m_Vignette )
			//           sub_1802DC2C8(v71, v70);
			//         IsActive = HG::Rendering::Runtime::Vignette::IsActive((Vignette *)m_Vignette, 0LL);
			//         if ( !m_HGVignette )
			//           sub_1802DC2C8(v73, v72);
			//         v77 = HG::Rendering::Runtime::HGVignette::IsActive((HGVignette *)m_HGVignette, 0LL);
			//         if ( !settingParameters )
			//           sub_1802DC2C8(v76, v75);
			//         if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                settingParameters.fields._vignetteEnabled_k__BackingField,
			//                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//           && (IsActive || v77) )
			//         {
			//           if ( !m_Vignette[3].klass )
			//             sub_1802DC2C8(v79, 0LL);
			//           v82 = sub_18003ED00(10LL);
			//           monitor = m_Vignette[5].monitor;
			//           if ( !monitor )
			//             sub_1802DC2C8(v81, v80);
			//           sub_180003EE0(*(_QWORD *)monitor);
			//           v286.r = (*(float (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)monitor + 480LL))(
			//                      monitor,
			//                      *(_QWORD *)(*(_QWORD *)monitor + 488LL));
			//           klass = m_Vignette[4].klass;
			//           if ( !klass )
			//             sub_1802DC2C8(v85, v84);
			//           sub_180003EE0(klass._0.image);
			//           v285.handle = (ResourceHandle)((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))klass._0.image[6].nameToClassHashTable)(
			//                                           klass,
			//                                           klass._0.image[6].codeGenModule);
			//           m_Value = v285.handle.m_Value;
			//           type_k__BackingField = v285.handle._type_k__BackingField;
			//           v91 = m_Vignette[4].monitor;
			//           if ( !v91 )
			//             sub_1802DC2C8(v88, v87);
			//           sub_180003EE0(*(_QWORD *)v91);
			//           v94 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v91 + 480LL))(
			//                   v91,
			//                   *(_QWORD *)(*(_QWORD *)v91 + 488LL));
			//           v95 = *(float *)&v94;
			//           v96 = m_Vignette[5].klass;
			//           if ( !v96 )
			//             sub_1802DC2C8(v93, v92);
			//           sub_180003EE0(v96._0.image);
			//           v99 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v96._0.image[6].nameToClassHashTable)(
			//                   v96,
			//                   v96._0.image[6].codeGenModule);
			//           v100 = *(float *)&v99;
			//           v101 = m_Vignette[6].klass;
			//           if ( !v101 )
			//             sub_1802DC2C8(v98, v97);
			//           sub_180003EE0(v101._0.image);
			//           v284 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v101._0.image[6].nameToClassHashTable)(
			//                    v101,
			//                    v101._0.image[6].codeGenModule);
			//           v104 = m_Vignette[3].monitor;
			//           if ( !v104 )
			//             sub_1802DC2C8(v103, v102);
			//           sub_180003EE0(*(_QWORD *)v104);
			//           v107 = (__m128)_mm_loadu_si128((const __m128i *)(*(__int64 (__fastcall **)(TextureHandle *, MonitorData *, _QWORD))(*(_QWORD *)v104 + 480LL))(
			//                                                             &v285,
			//                                                             v104,
			//                                                             *(_QWORD *)(*(_QWORD *)v104 + 488LL)));
			//           LODWORD(sceneDepth.x) = v107.m128_i32[0];
			//           LODWORD(v108) = _mm_shuffle_ps(v107, v107, 85).m128_u32[0];
			//           sceneDepth.y = v108;
			//           LODWORD(v109) = _mm_shuffle_ps(v107, v107, 170).m128_u32[0];
			//           sceneDepth.z = v109;
			//           LODWORD(sceneDepth.w) = _mm_shuffle_ps(v107, v107, 255).m128_u32[0];
			//           v110 = m_Vignette[7].klass;
			//           if ( !v110 )
			//             sub_1802DC2C8(v106, v105);
			//           sub_180003EE0(v110._0.image);
			//           v113 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v110._0.image[6].nameToClassHashTable)(
			//                    v110,
			//                    v110._0.image[6].codeGenModule);
			//           v114 = m_Vignette[7].monitor;
			//           if ( !v114 )
			//             sub_1802DC2C8(v112, v111);
			//           sub_180003EE0(*(_QWORD *)v114);
			//           v117 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v114 + 480LL))(
			//                    v114,
			//                    *(_QWORD *)(*(_QWORD *)v114 + 488LL));
			//           v118 = *(float *)&v117;
			//           if ( v77 )
			//           {
			//             v119 = m_HGVignette[4].monitor;
			//             if ( !v119 )
			//               sub_1802DC2C8(v116, v115);
			//             sub_180003EE0(*(_QWORD *)v119);
			//             v122 = (*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v119 + 480LL))(
			//                      v119,
			//                      *(_QWORD *)(*(_QWORD *)v119 + 488LL));
			//             v286.r = 1.0;
			//             v123 = m_HGVignette[5].klass;
			//             if ( !v123 )
			//               sub_1802DC2C8(v121, v120);
			//             sub_180003EE0(v123._0.image);
			//             v126 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v123._0.image[6].nameToClassHashTable)(
			//                      v123,
			//                      v123._0.image[6].codeGenModule);
			//             m_Value = 1056964608;
			//             type_k__BackingField = 1056964608;
			//             v127 = m_HGVignette[3].klass;
			//             if ( !v127 )
			//               sub_1802DC2C8(v125, v124);
			//             sub_180003EE0(v127._0.image);
			//             v130 = (__m128)_mm_loadu_si128((const __m128i *)((__int64 (__fastcall *)(TextureHandle *, Object__Class *, const Il2CppCodeGenModule *))v127._0.image[6].nameToClassHashTable)(
			//                                                               &v285,
			//                                                               v127,
			//                                                               v127._0.image[6].codeGenModule));
			//             v131 = 0;
			//             if ( v95 > 0.0 )
			//             {
			//               sceneDepth.x = UnityEngine::Mathf::Min(v107.m128_f32[0], v130.m128_f32[0], 0LL);
			//               sceneDepth.y = UnityEngine::Mathf::Min(v108, _mm_shuffle_ps(v130, v130, 85).m128_f32[0], 0LL);
			//               sceneDepth.z = UnityEngine::Mathf::Min(v109, _mm_shuffle_ps(v130, v130, 170).m128_f32[0], 0LL);
			//             }
			//             else
			//             {
			//               LODWORD(sceneDepth.x) = v130.m128_i32[0];
			//               LODWORD(sceneDepth.y) = _mm_shuffle_ps(v130, v130, 85).m128_u32[0];
			//               LODWORD(sceneDepth.z) = _mm_shuffle_ps(v130, v130, 170).m128_u32[0];
			//               LODWORD(sceneDepth.w) = _mm_shuffle_ps(v130, v130, 255).m128_u32[0];
			//             }
			//             v132 = m_HGVignette[3].monitor;
			//             if ( v126 )
			//             {
			//               if ( !v132 )
			//                 sub_1802DC2C8(v129, v128);
			//               sub_180003EE0(*(_QWORD *)v132);
			//               v135 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v132 + 480LL))(
			//                        v132,
			//                        *(_QWORD *)(*(_QWORD *)v132 + 488LL));
			//               v95 = *(float *)&v135;
			//               v136 = m_HGVignette[4].klass;
			//               if ( !v136 )
			//                 sub_1802DC2C8(v134, v133);
			//               sub_180003EE0(v136._0.image);
			//               v137 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v136._0.image[6].nameToClassHashTable)(
			//                        v136,
			//                        v136._0.image[6].codeGenModule);
			//             }
			//             else
			//             {
			//               if ( !v132 )
			//                 sub_1802DC2C8(v129, v128);
			//               sub_180003EE0(*(_QWORD *)v132);
			//               v138 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v132 + 480LL))(
			//                        v132,
			//                        *(_QWORD *)(*(_QWORD *)v132 + 488LL));
			//               v95 = UnityEngine::Mathf::Max(v95, *(float *)&v138, 0LL);
			//               v141 = m_HGVignette[4].klass;
			//               if ( !v141 )
			//                 sub_1802DC2C8(v140, v139);
			//               sub_180003EE0(v141._0.image);
			//               v137 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v141._0.image[6].nameToClassHashTable)(
			//                        v141,
			//                        v141._0.image[6].codeGenModule);
			//               *(float *)&v137 = UnityEngine::Mathf::Max(v100, *(float *)&v137, 0LL);
			//             }
			//             v100 = *(float *)&v137;
			//           }
			//           else
			//           {
			//             v126 = 0;
			//             if ( v82 )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//               v143 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//               if ( !*(_QWORD *)inputa )
			//                 sub_1802DC2C8(v142, v143);
			//               UnityEngine::Material::EnableKeyword(*(Material **)inputa, v143.s_VignetteMask, 0LL);
			//               LODWORD(sceneDepth.x) = v107.m128_i32[0];
			//               sceneDepth.y = v108;
			//               sceneDepth.z = v109;
			//               Beyond::JobMathf::Clamp01(v144);
			//               sceneDepth.w = v118;
			//               si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//               if ( !vignetteData )
			//                 sub_1802DC2C8(v146, v145);
			//               vignetteData.fields.vignetteParams1 = (Vector4)si128;
			//               vignetteData.fields.vignetteColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                                (Color *)inputa,
			//                                                                                                &sceneDepth,
			//                                                                                                0LL));
			//               vignetteData.fields.vignetteMask = (Texture *)v113;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v148 = (((unsigned __int64)&vignetteData.fields.vignetteMask >> 12) & 0x1FFFFF) >> 6;
			//                 v78 = ((unsigned __int64)&vignetteData.fields.vignetteMask >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6405E0[v148 + 36190]);
			//                 do
			//                 {
			//                   v79 = qword_18D6405E0[v148 + 36190] | (1LL << v78);
			//                   v149 = qword_18D6405E0[v148 + 36190];
			//                 }
			//                 while ( v149 != _InterlockedCompareExchange64(&qword_18D6405E0[v148 + 36190], v79, v149) );
			//               }
			//               v131 = 0;
			//               goto LABEL_86;
			//             }
			//             v131 = 0;
			//             v122 = v284;
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//           v174 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//           if ( !*(_QWORD *)inputa )
			//             sub_1802DC2C8(v174, v173);
			//           UnityEngine::Material::EnableKeyword(*(Material **)inputa, v174.s_Vignette, 0LL);
			//           v177 = 1065353216;
			//           r = v286.r;
			//           v179 = (float)(1.0 - v286.r) * 6.0;
			//           if ( !v126 )
			//             v177 = 0;
			//           *(_DWORD *)&inputa[0].m_IsValid = m_Value;
			//           inputa[0]._handle_k__BackingField = type_k__BackingField;
			//           *(_DWORD *)&inputa[1].m_IsValid = 0;
			//           inputa[1]._handle_k__BackingField = v177;
			//           if ( !vignetteData )
			//             sub_1802DC2C8(v176, v175);
			//           vignetteData.fields.vignetteParams1 = *(Vector4 *)&inputa[0].m_IsValid;
			//           if ( v122 )
			//             v180 = 1065353216;
			//           else
			//             v180 = 0;
			//           *(float *)&inputa[0].m_IsValid = v95 * 3.0;
			//           *(float *)&inputa[0]._handle_k__BackingField = v100 * 5.0;
			//           *(float *)&inputa[1].m_IsValid = r + v179;
			//           inputa[1]._handle_k__BackingField = v180;
			//           vignetteData.fields.vignetteParams2 = *(Vector4 *)&inputa[0].m_IsValid;
			//           vignetteData.fields.vignetteColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                            (Color *)inputa,
			//                                                                                            &sceneDepth,
			//                                                                                            0LL));
			//           vignetteData.fields.vignetteMask = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
			//           if ( dword_18D8E43F8 )
			//           {
			//             v181 = (((unsigned __int64)&vignetteData.fields.vignetteMask >> 12) & 0x1FFFFF) >> 6;
			//             v78 = ((unsigned __int64)&vignetteData.fields.vignetteMask >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v181 + 36190]);
			//             do
			//             {
			//               v79 = qword_18D6405E0[v181 + 36190] | (1LL << v78);
			//               v182 = qword_18D6405E0[v181 + 36190];
			//             }
			//             while ( v182 != _InterlockedCompareExchange64(&qword_18D6405E0[v181 + 36190], v79, v182) );
			//           }
			// LABEL_86:
			//           v12 = this;
			// LABEL_87:
			//           if ( !data )
			//             sub_1802DC2C8(v79, v78);
			//           bloomData = data.fields.bloomData;
			//           m_Bloom = (Object *)v12.fields.m_Bloom;
			//           v152 = v12.fields.m_UberPostMaterial;
			//           v153 = _mm_loadu_si128((const __m128i *)&this.fields.m_BloomBicubicParams);
			//           if ( !byte_18D9194C2 )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
			//             sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//             sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//             byte_18D9194C2 = 1;
			//           }
			//           v285 = 0LL;
			//           if ( IFix::WrappersManagerImpl::IsPatched(2413, 0LL) )
			//           {
			//             v272 = IFix::WrappersManagerImpl::GetPatch(2413, 0LL);
			//             if ( !v272 )
			//               sub_1802DC2C8(v274, v273);
			//             sceneDepth = (Vector4)v153;
			//             methoda = (MethodInfo *)v152;
			//             v212 = camera;
			//             v211 = settingParameters;
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_870(
			//               v272,
			//               (Object *)settingParameters,
			//               (Object *)bloomData,
			//               m_Bloom,
			//               &sceneDepth,
			//               (Object *)camera,
			//               (Object *)methoda,
			//               0LL);
			//           }
			//           else
			//           {
			//             if ( !m_Bloom )
			//               sub_1802DC2C8(v155, v154);
			//             if ( HG::Rendering::Runtime::Bloom::IsActive((Bloom *)m_Bloom, 0LL) )
			//             {
			//               if ( !settingParameters )
			//                 sub_1802DC2C8(v157, v156);
			//               if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                      settingParameters.fields._bloomEnabled_k__BackingField,
			//                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//               {
			//                 v160 = m_Bloom[6].monitor;
			//                 if ( !v160 )
			//                   sub_1802DC2C8(v159, v158);
			//                 sub_180003EE0(*(_QWORD *)v160);
			//                 (*(void (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v160 + 480LL))(
			//                   v160,
			//                   *(_QWORD *)(*(_QWORD *)v160 + 488LL));
			//                 v165 = sub_1802EB1B0(v162, v161);
			//                 v166 = *(float *)&v165 - 1.0;
			//                 v167 = m_Bloom[9].monitor;
			//                 if ( !v167 )
			//                   sub_1802DC2C8(v164, v163);
			//                 sub_180003EE0(*(_QWORD *)v167);
			//                 v285 = *(TextureHandle *)(*(__int64 (__fastcall **)(Vector4 *, MonitorData *, _QWORD))(*(_QWORD *)v167 + 480LL))(
			//                                            &sceneDepth,
			//                                            v167,
			//                                            *(_QWORD *)(*(_QWORD *)v167 + 488LL));
			//                 v168 = (__m128)_mm_loadu_si128((const __m128i *)sub_182F8C840(&sceneDepth, &v285));
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::ColorUtils);
			//                 v169 = (float)(_mm_shuffle_ps(v168, v168, 170).m128_f32[0] * 0.072175004)
			//                      + (float)((float)(_mm_shuffle_ps(v168, v168, 85).m128_f32[0] * 0.7151522)
			//                              + (float)(v168.m128_f32[0] * 0.2126729));
			//                 if ( v169 <= 0.0 )
			//                 {
			//                   one = UnityEngine::Vector4::get_one(&sceneDepth, 0LL);
			//                 }
			//                 else
			//                 {
			//                   sceneDepth = (Vector4)v168;
			//                   one = UnityEngine::Vector4::op_Multiply((Vector4 *)inputa, &sceneDepth, 1.0 / v169, 0LL);
			//                 }
			//                 v186 = _mm_loadu_si128((const __m128i *)one);
			//                 v187 = m_Bloom[12].monitor;
			//                 if ( !v187 )
			//                   sub_1802DC2C8(v172, v171);
			//                 sub_180003EE0(*(_QWORD *)v187);
			//                 v188 = (Object_1 *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v187 + 480LL))(
			//                                      v187,
			//                                      *(_QWORD *)(*(_QWORD *)v187 + 488LL));
			//                 sub_180002C70(TypeInfo::UnityEngine::Object);
			//                 if ( UnityEngine::Object::op_Equality(v188, 0LL, 0LL) )
			//                 {
			//                   v191 = UnityEngine::Texture2D::get_blackTexture(0LL);
			//                 }
			//                 else
			//                 {
			//                   v192 = m_Bloom[12].monitor;
			//                   if ( !v192 )
			//                     sub_1802DC2C8(v190, v189);
			//                   sub_180003EE0(*(_QWORD *)v192);
			//                   v191 = (Texture2D *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v192 + 480LL))(
			//                                         v192,
			//                                         *(_QWORD *)(*(_QWORD *)v192 + 488LL));
			//                 }
			//                 dirtEnabled = HG::Rendering::Runtime::Bloom::get_dirtEnabled((Bloom *)m_Bloom, 0LL);
			//                 if ( !v191 )
			//                   sub_1802DC2C8(v194, v193);
			//                 v196 = sub_18003ED00(5LL);
			//                 v198 = (float)v196 / (float)(int)sub_18003ED00(7LL);
			//                 v199 = (float)camera.fields._taauRTSize_k__BackingField.m_X
			//                      / (float)(int)HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField);
			//                 sceneDepth = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
			//                 v200 = m_Bloom[13].klass;
			//                 if ( !v200 )
			//                   sub_1802DC2C8(camera, v197);
			//                 sub_180003EE0(v200._0.image);
			//                 v203 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v200._0.image[6].nameToClassHashTable)(
			//                          v200,
			//                          v200._0.image[6].codeGenModule);
			//                 if ( v198 > v199 )
			//                 {
			//                   sceneDepth.x = v199 / v198;
			//                   sceneDepth.z = (float)(1.0 - (float)(v199 / v198)) * 0.5;
			//                 }
			//                 else if ( v199 > v198 )
			//                 {
			//                   sceneDepth.y = v198 / v199;
			//                   sceneDepth.w = (float)(1.0 - (float)(v198 / v199)) * 0.5;
			//                 }
			//                 if ( !bloomData )
			//                   sub_1802DC2C8(v202, v201);
			//                 bloomData.fields.bloomDirtTexture = (Texture *)v191;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v204 = (((unsigned __int64)&bloomData.fields.bloomDirtTexture >> 12) & 0x1FFFFF) >> 6;
			//                   _m_prefetchw(&qword_18D6405E0[v204 + 36190]);
			//                   do
			//                     v205 = qword_18D6405E0[v204 + 36190];
			//                   while ( v205 != _InterlockedCompareExchange64(
			//                                     &qword_18D6405E0[v204 + 36190],
			//                                     v205 | (1LL << (((unsigned __int64)&bloomData.fields.bloomDirtTexture >> 12) & 0x3F)),
			//                                     v205) );
			//                 }
			//                 if ( !m_Bloom[10].klass )
			//                   sub_1802DC2C8(v202, 0LL);
			//                 if ( (unsigned int)sub_18003ED00(10LL) )
			//                   v206 = 1065353216;
			//                 else
			//                   v206 = 0;
			//                 if ( dirtEnabled )
			//                   v131 = 1065353216;
			//                 *(float *)&inputa[0].m_IsValid = v166;
			//                 *(float *)&inputa[0]._handle_k__BackingField = *(float *)&v203 * v166;
			//                 *(_DWORD *)&inputa[1].m_IsValid = v206;
			//                 inputa[1]._handle_k__BackingField = v131;
			//                 bloomData.fields.bloomParams = *(Vector4 *)&inputa[0].m_IsValid;
			//                 *(__m128i *)&inputa[0].m_IsValid = v186;
			//                 bloomData.fields.bloomTint = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                           &v286,
			//                                                                                           (Vector4 *)inputa,
			//                                                                                           0LL));
			//                 bloomData.fields.bloomDirtTileOffset = sceneDepth;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//                 bloomData.fields.bloomThreshold = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
			//                                                                                                &sceneDepth,
			//                                                                                                (Bloom *)m_Bloom,
			//                                                                                                0LL));
			//                 bloomData.fields.bloomBicubicParams = (Vector4)v153;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//                 if ( dirtEnabled )
			//                 {
			//                   v271 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//                   if ( !v152 )
			//                     sub_1802DC2C8(v271, v207);
			//                   s_BloomDirt = v271.s_BloomDirt;
			//                 }
			//                 else
			//                 {
			//                   v209 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//                   if ( !v152 )
			//                     sub_1802DC2C8(v208, v209);
			//                   s_BloomDirt = v209.s_Bloom;
			//                 }
			//                 UnityEngine::Material::EnableKeyword(v152, s_BloomDirt, 0LL);
			//               }
			//             }
			//             v211 = settingParameters;
			//             v212 = camera;
			//           }
			//           HG::Rendering::Runtime::UberPostPassUtils::PrepareDirtyLensParameters(
			//             v211,
			//             data,
			//             this.fields.m_HGDirtyLens,
			//             0LL);
			//           HG::Rendering::Runtime::UberPostPassUtils::PrepareRadialBlurAndChromaticAberrationParameters(
			//             v211,
			//             data,
			//             v212,
			//             this.fields.m_RadialBlur,
			//             this.fields.m_chromaticAbberation,
			//             0LL);
			//           HG::Rendering::Runtime::UberPostPassUtils::PrepareBWFlashParameters(data, v212, this.fields.m_BWFlash, 0LL);
			//           v213 = data;
			//           v214 = source;
			//           v217 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&sceneDepth,
			//                     &v287,
			//                     source,
			//                     0LL);
			//           if ( !v213 )
			//             sub_1802DC2C8(v216, v215);
			//           v213.fields.source = v217;
			//           if ( !data )
			//             sub_1802DC2C8(v216, v215);
			//           v218 = data.fields.bloomData;
			//           v221 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&sceneDepth,
			//                     &v287,
			//                     bloomTexture,
			//                     0LL);
			//           if ( !v218 )
			//             sub_1802DC2C8(v220, v219);
			//           v218.fields.bloomTexture = v221;
			//           v222 = data;
			//           v225 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&sceneDepth,
			//                     &v287,
			//                     logLut,
			//                     0LL);
			//           if ( !v222 )
			//             sub_1802DC2C8(v224, v223);
			//           v222.fields.logLut = v225;
			//           v226 = data;
			//           v229 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                     (TextureHandle *)&sceneDepth,
			//                     &v287,
			//                     &input.target,
			//                     0LL);
			//           if ( !v226 )
			//             sub_1802DC2C8(v228, v227);
			//           v226.fields.destination = v229;
			//           target = input.target;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           sceneDepth = (Vector4)target;
			//           sceneDepth = (Vector4)*HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
			//                                    (TextureHandle *)inputa,
			//                                    renderGraph,
			//                                    v212,
			//                                    (TextureHandle *)&sceneDepth,
			//                                    0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)inputa,
			//             &v287,
			//             &input.target,
			//             0,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)inputa,
			//             &v287,
			//             (TextureHandle *)&sceneDepth,
			//             DepthAccess__Enum_ReadWrite,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_DontCare,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           sceneDepth = (Vector4)input.sceneDepth;
			//           HG::Rendering::Runtime::PostProcessPassConstructor::PrepareWorldUIData(
			//             this,
			//             data,
			//             v212,
			//             (TextureHandle *)&sceneDepth,
			//             0LL);
			//           cullingResults = input.cullingResults;
			//           v234 = v212.fields.camera;
			//           hgrp = input.hgrp;
			//           if ( !hgrp )
			//             sub_1802DC2C8(v232, v231);
			//           uiPassNames = hgrp.fields.uiPassNames;
			//           screenCullingRatio = input.screenCullingRatio;
			//           screenCullingRatioDistance = input.screenCullingRatioDistance;
			//           screenCullingLayerMask = input.screenCullingLayerMask;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//           *(_QWORD *)&v286.r = 0x138800000000LL;
			//           inputa[0] = (RendererListHandle)1LL;
			//           *(_DWORD *)&inputa[1].m_IsValid = 0;
			//           sub_1802F01E0(&desc, 0LL, 112LL);
			//           *(_DWORD *)&inputa[1].m_IsValid = 5000;
			//           sceneDepth = (Vector4)cullingResults;
			//           v240 = HG::Rendering::Runtime::HGRendererListUtils::CreateWorldUIRendererListDesc(
			//                    &v292,
			//                    (CullingResults *)&sceneDepth,
			//                    v234,
			//                    uiPassNames,
			//                    screenCullingRatio,
			//                    screenCullingRatioDistance,
			//                    screenCullingLayerMask,
			//                    PerObjectData__Enum_None,
			//                    (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)inputa,
			//                    (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
			//                    0LL,
			//                    0,
			//                    0LL);
			//           *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v240.sortingCriteria;
			//           desc.stateBlock = v240.stateBlock;
			//           v240 = (RendererListDesc *)((char *)v240 + 128);
			//           *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v240.sortingCriteria;
			//           *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v240.stateBlock.hasValue;
			//           *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v240.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v240.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v240.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v240.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           inputa[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//           v241 = data;
			//           v242 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v287, inputa, 0LL);
			//           if ( !v241 )
			//             sub_1802DC2C8(v244, v243);
			//           v241.fields.worldUIRenderList = v242;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//           cullingLayerMask = HG::Rendering::Runtime::HGCamera::AddWorldUILayer(0, 0LL);
			//           v248 = data;
			//           cullingViewHandle = v212.fields.cullingViewHandle;
			//           m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//           if ( !m_RenderGraphContext )
			//             sub_1802DC2C8(v246, v245);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(P3) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            cullingViewHandle,
			//                            HGRenderFlags__Enum_Transparent,
			//                            HGRenderFlags__Enum_Transparent,
			//                            HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
			//                            P3,
			//                            m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                            1,
			//                            1,
			//                            cullingLayerMask,
			//                            0,
			//                            0,
			//                            0LL);
			//           if ( !v248 )
			//             sub_1802DC2C8(v253, v252);
			//           v248.fields.worldUIECSRenderList = RendererList;
			//           v254 = data;
			//           v255 = v212.fields.camera;
			//           if ( !v255 )
			//             sub_1802DC2C8(0LL, v252);
			//           cullingMask = UnityEngine::Camera::get_cullingMask(v255, 0LL);
			//           v258 = (Object_1 *)v212.fields.camera;
			//           if ( !v258 )
			//             sub_1802DC2C8(0LL, v256);
			//           InstanceID = UnityEngine::Object::GetInstanceID(v258, 0LL);
			//           v262 = renderGraph.fields.m_RenderGraphContext;
			//           if ( !v262 )
			//             sub_1802DC2C8(v260, v259);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v263 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                    cullingLayerMask & cullingMask,
			//                    0x200u,
			//                    0x200u,
			//                    0x802060u,
			//                    0x8000,
			//                    0x7FFF,
			//                    InstanceID,
			//                    v262.fields.renderContext.m_Ptr,
			//                    1,
			//                    5000.0,
			//                    0LL);
			//           if ( !v254 )
			//             sub_1802DC2C8(v265, v264);
			//           v254.fields.hgUIRenderList = v263;
			//           if ( !data )
			//             sub_1802DC2C8(v265, v264);
			//           p_sceneDepthBuffer = &data.fields.sceneDepthBuffer;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(p_sceneDepthBuffer, 0LL) )
			//           {
			//             if ( !data )
			//               sub_1802DC2C8(v268, v267);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               (TextureHandle *)&sceneDepth,
			//               &v287,
			//               &data.fields.sceneDepthBuffer,
			//               0LL);
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v287, 0, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v287,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor.static_fields.s_uberRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
			//           if ( !data )
			//             sub_1802DC2C8(v270, v269);
			//           *source = data.fields.destination;
			//           goto LABEL_244;
			//         }
			//       }
			//       v131 = 0;
			//       goto LABEL_87;
			//     }
			//     catch ( Il2CppExceptionWrapper *v289 )
			//     {
			//       v288.m_RenderPass = (HGRenderGraphPass *)v289.ex;
			//       sub_180222690(&v288);
			//       v214 = source;
			//       goto LABEL_165;
			//     }
			// LABEL_244:
			//     sub_180222690(&v288);
			// LABEL_165:
			//     result = retstr;
			//     *retstr = *v214;
			//     return result;
			//   }
			//   v278 = IFix::WrappersManagerImpl::GetPatch(2464, 0LL);
			//   if ( !v278 )
			//     sub_180B536AC(v277, v276);
			//   *(TextureHandle *)&v288.m_RenderPass = *bloomTexture;
			//   sceneDepth = (Vector4)*logLut;
			//   *(TextureHandle *)&inputa[0].m_IsValid = *source;
			//   *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_904(
			//                &v285,
			//                v278,
			//                (Object *)v12,
			//                input,
			//                (Object *)settingParameters,
			//                (Object *)renderGraph,
			//                (Object *)camera,
			//                (TextureHandle *)inputa,
			//                (TextureHandle *)&sceneDepth,
			//                (TextureHandle *)&v288,
			//                0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		private void FinalPass(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle finalRT, TextureHandle source)
		{
			// // Void FinalPass(HGRenderGraph, HGCamera, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(
			//         PostProcessPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         TextureHandle *finalRT,
			//         TextureHandle *source,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // eax
			//   unsigned __int64 v14; // r9
			//   signed __int64 v15; // rtt
			//   Object *v16; // r9
			//   Object__Class *m_FinalPassMaterial; // rcx
			//   unsigned int v18; // r9d
			//   unsigned __int64 v19; // r8
			//   char v20; // r9
			//   signed __int64 v21; // rtt
			//   __m128i v22; // xmm0
			//   Object *v23; // rax
			//   float m_Height; // xmm2_4
			//   uint32_t v25; // xmm1_4
			//   Object *v26; // rbx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   TextureHandle v29; // xmm0
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rsi
			//   Object *v33; // [rsp+40h] [rbp-78h] BYREF
			//   TextureHandle v34; // [rsp+50h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v35; // [rsp+60h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+70h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v37; // [rsp+90h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9194F0 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4F3558);
			//     byte_18D9194F0 = 1;
			//   }
			//   v33 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2469, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2469, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v31, v30);
			//     *(TextureHandle *)&v36.m_RenderPass = *source;
			//     v34 = *finalRT;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_905(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       &v34,
			//       (TextureHandle *)&v36,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x9Eu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v36,
			//       renderGraph,
			//       (String *)"Final Pass",
			//       &v33,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
			//     v37 = v36;
			//     v36.m_RenderPass = 0LL;
			//     v36.m_Resources = (HGRenderGraphResourceRegistry *)&v37;
			//     try
			//     {
			//       this.fields.m_renderGraphBuilder = v37;
			//       v13 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v14 = (((unsigned __int64)&this.fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v14 + 36190]);
			//         do
			//           v15 = qword_18D6405E0[v14 + 36190];
			//         while ( v15 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v14 + 36190],
			//                          v15 | (1LL << (((unsigned __int64)&this.fields.m_renderGraphBuilder >> 12) & 0x3F)),
			//                          v15) );
			//         v13 = dword_18D8E43F8;
			//       }
			//       v16 = v33;
			//       m_FinalPassMaterial = (Object__Class *)this.fields.m_FinalPassMaterial;
			//       if ( !v33 )
			//         sub_1802DC2C8(m_FinalPassMaterial, qword_18D6405E0);
			//       v33[1].klass = m_FinalPassMaterial;
			//       if ( v13 )
			//       {
			//         v18 = ((unsigned __int64)&v16[1] >> 12) & 0x1FFFFF;
			//         v19 = (unsigned __int64)v18 >> 6;
			//         v20 = v18 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//         do
			//         {
			//           m_FinalPassMaterial = (Object__Class *)(qword_18D6405E0[v19 + 36190] | (1LL << v20));
			//           v21 = qword_18D6405E0[v19 + 36190];
			//         }
			//         while ( v21 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v19 + 36190],
			//                          (signed __int64)m_FinalPassMaterial,
			//                          v21) );
			//       }
			//       if ( !hgCamera )
			//         sub_1802DC2C8(m_FinalPassMaterial, qword_18D6405E0);
			//       v22 = _mm_loadu_si128((const __m128i *)&hgCamera.fields.finalViewport);
			//       if ( !v33 )
			//         sub_1802DC2C8(m_FinalPassMaterial, qword_18D6405E0);
			//       *(__m128i *)((char *)v33 + 24) = v22;
			//       v23 = v33;
			//       if ( !v33 )
			//         sub_1802DC2C8(m_FinalPassMaterial, qword_18D6405E0);
			//       HIDWORD(v33[1].monitor) = 0;
			//       LODWORD(v23[1].monitor) = 0;
			//       m_Height = hgCamera.fields.finalViewport.m_Height;
			//       *(float *)&v25 = 1.0 / hgCamera.fields.finalViewport.m_Width;
			//       v34.handle.m_Value = LODWORD(hgCamera.fields.finalViewport.m_Width);
			//       *(float *)&v34.handle._type_k__BackingField = m_Height;
			//       v34.fallBackResource.m_Value = v25;
			//       *(float *)&v34.fallBackResource._type_k__BackingField = 1.0 / m_Height;
			//       if ( !v33 )
			//         sub_1802DC2C8(m_FinalPassMaterial, qword_18D6405E0);
			//       *(TextureHandle *)&v33[2].monitor = v34;
			//       v26 = v33;
			//       v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v34, &v37, source, 0LL);
			//       if ( !v26 )
			//         sub_1802DC2C8(v28, v27);
			//       *(TextureHandle *)&v26[3].monitor = v29;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v34, &v37, finalRT, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&v34, &v37, finalRT, 0, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v37,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor.static_fields.s_finalRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v35 )
			//     {
			//       v36.m_RenderPass = (HGRenderGraphPass *)v35.ex;
			//     }
			//     sub_180222690(&v36);
			//   }
			// }
			// 
		}

		public Nullable<HGRenderGraphBuilder> <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph P0)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__iFixBaseProxy_GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         ScreenSpaceOverlayPassConstructor *this,
			//         HGRenderGraph *P0,
			//         MethodInfo *method)
			// {
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *RenderGraphBuilder; // rax
			//   __int128 v6; // xmm1
			//   __int64 v7; // xmm0_8
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *result; // rax
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v9; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   RenderGraphBuilder = HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
			//                          &v9,
			//                          (ComposablePass *)this,
			//                          P0,
			//                          0LL);
			//   v6 = *(_OWORD *)&RenderGraphBuilder.value.m_Resources;
			//   *(_OWORD *)&retstr.hasValue = *(_OWORD *)&RenderGraphBuilder.hasValue;
			//   v7 = *(_QWORD *)&RenderGraphBuilder.value.m_Disposed;
			//   result = retstr;
			//   *(_OWORD *)&retstr.value.m_Resources = v6;
			//   *(_QWORD *)&retstr.value.m_Disposed = v7;
			//   return result;
			// }
			// 
			return null;
		}

		private Material m_FinalPassMaterial;

		private Material m_UberPostMaterial;

		private Material m_FisheyeEffectMaterial;

		private Material m_FisheyeEffectDepthMaterial;

		private Material m_LutBuilder2DMaterial;

		private Material m_SharpenMaterial;

		private Material m_SMAAMaterial;

		private RTHandle[] m_sceneFrostedGlassRTs;

		private Vector2Int[] m_sceneFrostedGlassRTSizes;

		private UberPostPassUtils.FrostedGlassPSMaterials m_frostedGlassPSMaterials;

		private Vector4 m_BloomBicubicParams;

		internal UberPostPassUtils.BloomPSMaterials m_bloomPSMaterials;

		private RTHandle m_cachedColorLut;

		private UberPostPassUtils.CachedColorGradingData m_cachedColorGradingPassData;

		private int m_LutSize;

		private GraphicsFormat m_LutFormat;

		private Bloom m_Bloom;

		private Vignette m_Vignette;

		private HGVignette m_HGVignette;

		private HGDirtyLens m_HGDirtyLens;

		private HGSharpen m_Sharpen;

		private HGRadialBlur m_RadialBlur;

		private HGBWFlash m_BWFlash;

		private HGFisheyeEffect m_FisheyeEffect;

		private HGChromaticAbberation m_chromaticAbberation;

		private bool m_EnableAlpha;

		private bool m_KeepAlpha;

		private bool m_EnableAlphaForUI;

		private bool m_NonRenderGraphResourcesAvailable;

		internal const int k_RTGuardBandSize = 4;

		private HGRenderGraphBuilder m_renderGraphBuilder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<UberPostPassUtils.UberPostPassData> s_uberRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static UberPostPassUtils.UberPostPassData s_uberPostDataCPP;

		private const float kWorldUICullingDistance = 5000f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<PostProcessPassConstructor.FinalPassData> s_finalRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle target;

			internal CullingResults cullingResults;

			internal TAAUQuality taauQuality;

			internal DepthBits depthBits;

			internal GraphicsFormat depthFormat;

			internal HGRenderPathInternal renderPath;

			internal HGRenderPipeline hgrp;

			internal bool render3DUI;

			internal float renderingScale;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		internal struct PassOutput
		{
			internal TextureHandle output;

			internal TextureHandle frostedGlassRT;
		}

		private class FinalPassData
		{
			public FinalPassData()
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

			public Material finalPassMaterial;

			public Rect backBufferRect;

			public Vector4 viewPortSize;

			public TextureHandle source;
		}
	}
}
