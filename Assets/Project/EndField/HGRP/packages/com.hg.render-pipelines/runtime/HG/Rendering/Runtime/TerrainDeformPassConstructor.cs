using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class TerrainDeformPassConstructor : IPassConstructor
	{
		internal TerrainDeformPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // TerrainDeformPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::TerrainDeformPassConstructor(
			//         TerrainDeformPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   __int64 v9; // rdx
			//   Texture2D *whiteTexture; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   RTHandle *m_defaultFillRateRT; // r9
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   Texture2D *blackTexture; // rax
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   RTHandle *m_defaultResultRT; // r9
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   __int64 v25; // rcx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   Color clearColor; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   Color v42; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v43; // rdx
			//   PassConstructorID__Enum__Array *v44; // r8
			//   HGCamera *v45; // r9
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   Color v48; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v49; // rdx
			//   PassConstructorID__Enum__Array *v50; // r8
			//   HGCamera *v51; // r9
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   Color v56; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v57; // rdx
			//   PassConstructorID__Enum__Array *v58; // r8
			//   HGCamera *v59; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v61; // rax
			//   ILFixDynamicMethodWrapper_2 *v62; // rax
			//   ILFixDynamicMethodWrapper_2 *v63; // rax
			//   TextureDesc P0; // [rsp+20h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D8EDAC6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Plane);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18C8FCC60);
			//     byte_18D8EDAC6 = 1;
			//   }
			//   this.fields.m_cullingPlanes = (Plane__Array *)il2cpp_array_new_specific_0(
			//                                                    TypeInfo::UnityEngine::Plane,
			//                                                    6LL,
			//                                                    resources,
			//                                                    method);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_cullingPlanes,
			//     v6,
			//     v7,
			//     v8,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   whiteTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RTHandles._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RTHandles, v9);
			//   this.fields.m_defaultFillRateRT = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)whiteTexture, 0LL);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields,
			//     v11,
			//     v12,
			//     v13,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   m_defaultFillRateRT = this.fields.m_defaultFillRateRT;
			//   this.fields.m_defaultDensityRT = m_defaultFillRateRT;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_defaultDensityRT,
			//     v15,
			//     v16,
			//     (HGCamera *)m_defaultFillRateRT,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   this.fields.m_defaultResultRT = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)blackTexture, 0LL);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_defaultResultRT,
			//     v18,
			//     v19,
			//     v20,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   m_defaultResultRT = this.fields.m_defaultResultRT;
			//   this.fields.m_defaultGroundLayerRT = m_defaultResultRT;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_defaultGroundLayerRT,
			//     v22,
			//     v23,
			//     (HGCamera *)m_defaultResultRT,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   if ( !resources.defaultResources )
			//     goto LABEL_16;
			//   shaders = resources.defaultResources.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_16;
			//   this.fields.m_generateCS = shaders.fields.terrainDeformGenerateV2CS;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_generateCS,
			//     v24,
			//     v26,
			//     v27,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   memset(&P0.slices, 0, 88);
			//   P0.width = 1024;
			//   P0.height = 1024;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !Patch )
			//       goto LABEL_16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(Patch, &P0, 0LL);
			//   }
			//   else
			//   {
			//     P0.slices = 1;
			//     P0.dimension = 2;
			//   }
			//   *(_QWORD *)&P0.colorFormat = 5LL;
			//   P0.wrapMode = 1;
			//   v32 = *(_OWORD *)&P0.colorFormat;
			//   P0.depthBufferBits = 0;
			//   *(_OWORD *)&this.fields.m_fillRateRTDesc.width = *(_OWORD *)&P0.width;
			//   P0.enableRandomWrite = 1;
			//   v33 = *(_OWORD *)&P0.enableRandomWrite;
			//   *(_OWORD *)&this.fields.m_fillRateRTDesc.colorFormat = v32;
			//   v34 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_fillRateRTDesc.enableRandomWrite = v33;
			//   v35 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_fillRateRTDesc.bindTextureMS = v34;
			//   clearColor = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_fillRateRTDesc.fastMemoryDesc.inFastMemory = v35;
			//   this.fields.m_fillRateRTDesc.clearColor = clearColor;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_fillRateRTDesc.name,
			//     v29,
			//     v30,
			//     v31,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   memset(&P0.slices, 0, 88);
			//   P0.width = 1024;
			//   P0.height = 1024;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     v61 = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !v61 )
			//       goto LABEL_16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(v61, &P0, 0LL);
			//   }
			//   else
			//   {
			//     P0.slices = 1;
			//     P0.dimension = 2;
			//   }
			//   P0.depthBufferBits = 0;
			//   *(_OWORD *)&this.fields.m_resultRTDesc.width = *(_OWORD *)&P0.width;
			//   P0.colorFormat = 48;
			//   P0.filterMode = 1;
			//   P0.wrapMode = 1;
			//   *(_OWORD *)&this.fields.m_resultRTDesc.colorFormat = *(_OWORD *)&P0.colorFormat;
			//   P0.enableRandomWrite = 1;
			//   v40 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_resultRTDesc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
			//   v41 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_resultRTDesc.bindTextureMS = v40;
			//   v42 = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_resultRTDesc.fastMemoryDesc.inFastMemory = v41;
			//   this.fields.m_resultRTDesc.clearColor = v42;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_resultRTDesc.name,
			//     v37,
			//     v38,
			//     v39,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   memset(&P0.slices, 0, 88);
			//   P0.width = 64;
			//   P0.height = 64;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     v62 = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !v62 )
			//       goto LABEL_16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(v62, &P0, 0LL);
			//   }
			//   else
			//   {
			//     P0.slices = 1;
			//     P0.dimension = 2;
			//   }
			//   P0.depthBufferBits = 0;
			//   *(_OWORD *)&this.fields.m_densityMip4RTDesc.width = *(_OWORD *)&P0.width;
			//   P0.colorFormat = 5;
			//   P0.filterMode = 1;
			//   P0.wrapMode = 1;
			//   *(_OWORD *)&this.fields.m_densityMip4RTDesc.colorFormat = *(_OWORD *)&P0.colorFormat;
			//   P0.enableRandomWrite = 1;
			//   v46 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_densityMip4RTDesc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
			//   v47 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_densityMip4RTDesc.bindTextureMS = v46;
			//   v48 = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_densityMip4RTDesc.fastMemoryDesc.inFastMemory = v47;
			//   this.fields.m_densityMip4RTDesc.clearColor = v48;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_densityMip4RTDesc.name,
			//     v43,
			//     v44,
			//     v45,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			//   memset(&P0.slices, 0, 88);
			//   P0.width = 1024;
			//   P0.height = 1024;
			//   P0.msaaSamples = 1;
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     v63 = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( v63 )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(v63, &P0, 0LL);
			//       goto LABEL_15;
			//     }
			// LABEL_16:
			//     sub_180B536AC(v25, v24);
			//   }
			//   P0.slices = 1;
			//   P0.dimension = 2;
			// LABEL_15:
			//   P0.name = (String *)"TerrainDeformDistance";
			//   P0.colorFormat = 21;
			//   P0.filterMode = 1;
			//   P0.wrapMode = 1;
			//   P0.isShadowMap = 0;
			//   P0.clearBuffer = 1;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&P0.name,
			//     v49,
			//     v50,
			//     v51,
			//     *(MethodInfo **)&P0.width,
			//     (MethodInfo *)(unsigned int)P0.slices);
			//   v52 = *(_OWORD *)&P0.colorFormat;
			//   *(_OWORD *)&this.fields.m_distanceRTDesc.width = *(_OWORD *)&P0.width;
			//   v53 = *(_OWORD *)&P0.enableRandomWrite;
			//   *(_OWORD *)&this.fields.m_distanceRTDesc.colorFormat = v52;
			//   v54 = *(_OWORD *)&P0.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_distanceRTDesc.enableRandomWrite = v53;
			//   v55 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_distanceRTDesc.bindTextureMS = v54;
			//   v56 = P0.clearColor;
			//   *(_OWORD *)&this.fields.m_distanceRTDesc.fastMemoryDesc.inFastMemory = v55;
			//   this.fields.m_distanceRTDesc.clearColor = v56;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_distanceRTDesc.name,
			//     v57,
			//     v58,
			//     v59,
			//     *(MethodInfo **)&P0.width,
			//     *(MethodInfo **)&P0.slices);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal cb)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TerrainDeformPassConstructor *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGTerrainDeformManager *terrainDeformManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2829, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       terrainDeformManager_k__BackingField = currentManagerContext.fields._terrainDeformManager_k__BackingField;
			//       if ( terrainDeformManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGTerrainDeformManager::GetTerrainDeformParams(
			//           terrainDeformManager_k__BackingField,
			//           cb,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(terrainDeformManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2829, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TerrainDeformPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2833, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2833, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TerrainDeformPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   TextureHandle *v6; // rax
			//   HGRenderGraph *renderGraph; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195D1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503708);
			//     byte_18D9195D1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2834, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//       sub_1802F01E0(&this.fields.rtHandles, 0LL, 64LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.rtHandles.curFillRateRT, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v6 = (TextureHandle *)sub_182E7CCD0(&v9);
			// LABEL_10:
			//       this.fields.m_historyFillRateRT = *v6;
			//       return;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v6 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//              &v9,
			//              renderGraph,
			//              &this.fields.rtHandles.curFillRateRT,
			//              1,
			//              (String *)"TerrainDeformPass",
			//              0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, renderGraph);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2834, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TerrainDeformPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2835, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2835, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref TerrainDeformPassConstructor.PassInput input, ref TerrainDeformPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(TerrainDeformPassConstructor+PassInput ByRef, TerrainDeformPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
			//         TerrainDeformPassConstructor *this,
			//         TerrainDeformPassConstructor_PassInput *input,
			//         TerrainDeformPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // rsi
			//   TerrainDeformPassConstructor *v9; // rdi
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGTerrainDeformManager *terrainDeformManager_k__BackingField; // r15
			//   TerrainDeformRenderData *RenderData; // rax
			//   Vector4 param0; // xmm6
			//   Vector4 param1; // xmm7
			//   Vector4 param2; // xmm8
			//   __int64 v18; // xmm9_8
			//   float z; // r12d
			//   ProfilingSampler *v20; // rax
			//   __int64 v21; // rcx
			//   Object *v22; // rdx
			//   unsigned int v23; // edx
			//   unsigned __int64 v24; // r8
			//   char v25; // dl
			//   signed __int64 v26; // rtt
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   Object *v29; // rax
			//   Matrix4x4 *inverse; // r12
			//   __int128 v31; // xmm13
			//   __int128 v32; // xmm14
			//   __int128 v33; // xmm15
			//   Matrix4x4 *v34; // rax
			//   __int128 v35; // xmm9
			//   __int128 v36; // xmm10
			//   __int128 v37; // xmm11
			//   __int128 v38; // xmm12
			//   Object *v39; // r12
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   Matrix4x4 *v41; // rax
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm2
			//   __int128 v46; // xmm3
			//   ProfilingSampler *v47; // rax
			//   signed __int64 v48; // rcx
			//   Object *v49; // rdx
			//   unsigned int v50; // edx
			//   unsigned __int64 v51; // r8
			//   signed __int64 v52; // rtt
			//   Object *v53; // rax
			//   Object *v54; // r14
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   TextureHandle v57; // xmm0
			//   Object *v58; // r14
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   TextureHandle v61; // xmm0
			//   Object *v62; // r14
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   TextureHandle v65; // xmm0
			//   Object *v66; // r14
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   TextureHandle v69; // xmm0
			//   Object *v70; // r14
			//   __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   TextureHandle v73; // xmm0
			//   Object *v74; // r14
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   TextureHandle v77; // xmm0
			//   Object *v78; // r14
			//   __int64 v79; // rdx
			//   __int64 v80; // rcx
			//   TextureHandle v81; // xmm0
			//   HGCamera *v82; // rdi
			//   __int64 vtFeedbackViewId; // rcx
			//   __int64 terrainCullViewHandle; // rcx
			//   __int64 editorTerrainCullViewHandle; // rcx
			//   ProfilingSampler *v86; // rax
			//   __int64 v87; // rdx
			//   __int64 v88; // rcx
			//   Object *v89; // r14
			//   __int64 v90; // rdx
			//   __int64 v91; // rcx
			//   TextureHandle v92; // xmm0
			//   Object *v93; // r14
			//   __int64 v94; // rdx
			//   __int64 v95; // rcx
			//   TextureHandle v96; // xmm0
			//   Object *v97; // r14
			//   __int64 v98; // rdx
			//   __int64 v99; // rcx
			//   TextureHandle v100; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v102; // rdx
			//   __int64 v103; // rcx
			//   Object *v104; // [rsp+50h] [rbp-378h] BYREF
			//   Il2CppException *ex; // [rsp+58h] [rbp-370h] BYREF
			//   HGRenderGraphBuilder *v106; // [rsp+60h] [rbp-368h]
			//   __m128i v107; // [rsp+70h] [rbp-358h] BYREF
			//   Object *v108; // [rsp+80h] [rbp-348h] BYREF
			//   Object *v109; // [rsp+88h] [rbp-340h] BYREF
			//   __m128i si128; // [rsp+90h] [rbp-338h] BYREF
			//   TerrainDeformRenderData v111; // [rsp+A0h] [rbp-328h] BYREF
			//   HGTerrainDeformManager *v112; // [rsp+E0h] [rbp-2E8h]
			//   HGRenderGraphBuilder v113; // [rsp+E8h] [rbp-2E0h] BYREF
			//   Matrix4x4 v114; // [rsp+110h] [rbp-2B8h] BYREF
			//   __m128i v115; // [rsp+150h] [rbp-278h] BYREF
			//   __m128i v116; // [rsp+160h] [rbp-268h] BYREF
			//   TextureHandle v117; // [rsp+170h] [rbp-258h] BYREF
			//   HGRenderGraphBuilder v118; // [rsp+180h] [rbp-248h] BYREF
			//   Matrix4x4 v119; // [rsp+1A0h] [rbp-228h] BYREF
			//   Matrix4x4 v120; // [rsp+1E0h] [rbp-1E8h] BYREF
			//   Vector4 v121; // [rsp+220h] [rbp-1A8h]
			//   Vector4 v122; // [rsp+230h] [rbp-198h]
			//   Vector4 v123; // [rsp+240h] [rbp-188h]
			//   __int64 v124; // [rsp+250h] [rbp-178h]
			//   Il2CppExceptionWrapper *v125; // [rsp+260h] [rbp-168h] BYREF
			//   Il2CppExceptionWrapper *v126; // [rsp+268h] [rbp-160h] BYREF
			//   Il2CppExceptionWrapper *v127; // [rsp+270h] [rbp-158h] BYREF
			//   __int128 v128; // [rsp+278h] [rbp-150h]
			//   __int128 v129; // [rsp+288h] [rbp-140h]
			//   HGRenderGraphBuilder v130; // [rsp+298h] [rbp-130h] BYREF
			//   Matrix4x4 v131[3]; // [rsp+2B8h] [rbp-110h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v9 = this;
			//   if ( !byte_18D9195D2 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::CharacterDepthPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::DispatchPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::SetDefaultPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::CharacterDepthPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::DispatchPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::SetDefaultPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503728);
			//     sub_18003C530(&off_18D503740);
			//     sub_18003C530(&off_18D503758);
			//     byte_18D9195D2 = 1;
			//   }
			//   v109 = 0LL;
			//   v108 = 0LL;
			//   sub_1802F01E0(&v114, 0LL, 64LL);
			//   sub_1802F01E0(&v119, 0LL, 64LL);
			//   memset(&v113, 0, sizeof(v113));
			//   v104 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2836, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2836, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v103, v102);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1035(Patch, (Object *)v9, input, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v9.fields.rtHandles, 0LL, 64LL);
			//     if ( input.enableTerrainTessellation )
			//     {
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         goto LABEL_64;
			//       terrainDeformManager_k__BackingField = currentManagerContext.fields._terrainDeformManager_k__BackingField;
			//       v112 = terrainDeformManager_k__BackingField;
			//       if ( !terrainDeformManager_k__BackingField )
			//         goto LABEL_64;
			//       RenderData = HG::Rendering::Runtime::HGTerrainDeformManager::GetRenderData(
			//                      &v111,
			//                      terrainDeformManager_k__BackingField,
			//                      0LL);
			//       param0 = RenderData.constData.param0;
			//       v121 = RenderData.constData.param0;
			//       param1 = RenderData.constData.param1;
			//       v122 = param1;
			//       param2 = RenderData.constData.param2;
			//       v123 = param2;
			//       v18 = *(_QWORD *)&RenderData.curCenter.x;
			//       v124 = v18;
			//       z = RenderData.curCenter.z;
			//       sub_1802F01E0(&v9.fields.rtHandles, 0LL, 64LL);
			//       HG::Rendering::Runtime::TerrainDeformPassConstructor::_PrepareTextureHandle(
			//         v9,
			//         (HGRenderGraph *)v6,
			//         &v9.fields.rtHandles,
			//         0LL);
			//       v20 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xEu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			// LABEL_64:
			//         sub_1802DC2C8(v12, v11);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&v111,
			//         (HGRenderGraph *)v6,
			//         (String *)"TerrainDeformDepth",
			//         &v108,
			//         v20,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::CharacterDepthPassData>);
			//       *(Vector4 *)&v118.m_RenderPass = v111.constData.param0;
			//       *(Vector4 *)&v118.m_RenderGraph = v111.constData.param1;
			//       ex = 0LL;
			//       v106 = &v118;
			//       try
			//       {
			//         v22 = v108;
			//         if ( !v108 )
			//           sub_1802DC2C8(v21, 0LL);
			//         v108[1].klass = (Object__Class *)input.drawInteractionNodeMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v23 = ((unsigned __int64)&v22[1] >> 12) & 0x1FFFFF;
			//           v24 = (unsigned __int64)v23 >> 6;
			//           v25 = v23 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//           do
			//             v26 = qword_18D6405E0[v24 + 36190];
			//           while ( v26 != _InterlockedCompareExchange64(&qword_18D6405E0[v24 + 36190], v26 | (1LL << v25), v26) );
			//         }
			//         memset(&v111, 0, 24);
			//         si128.m128i_i64[0] = _mm_unpacklo_ps((__m128)0x42000000u, (__m128)0x42000000u).m128_u64[0];
			//         si128.m128i_i32[2] = 1107296256;
			//         v107.m128i_i64[0] = v18;
			//         *(float *)&v107.m128i_i32[2] = z;
			//         UnityEngine::Bounds::Bounds((Bounds *)&v111, (Vector3 *)&v107, (Vector3 *)&si128, 0LL);
			//         v29 = v108;
			//         if ( !v108 )
			//           sub_1802DC2C8(v28, v27);
			//         *(Vector4 *)((char *)v108 + 88) = v111.constData.param0;
			//         v29[6].monitor = *(MonitorData **)&v111.constData.param1.x;
			//         v107.m128i_i64[0] = v124;
			//         *(float *)&v107.m128i_i32[2] = z;
			//         v107.m128i_i32[3] = 1065353216;
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//         v115 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//         v116 = _mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//         UnityEngine::Matrix4x4::Matrix4x4(
			//           &v114,
			//           (Vector4 *)&v116,
			//           (Vector4 *)&v115,
			//           (Vector4 *)&si128,
			//           (Vector4 *)&v107,
			//           0LL);
			//         inverse = UnityEngine::Matrix4x4::get_inverse(v131, &v114, 0LL);
			//         v128 = *(_OWORD *)&inverse.m00;
			//         v129 = *(_OWORD *)&inverse.m01;
			//         v117 = *(TextureHandle *)&inverse.m02;
			//         v111.constData.param0 = *(Vector4 *)&inverse.m03;
			//         v116 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         v115 = _mm_load_si128((const __m128i *)&xmmword_18C370DE0);
			//         v107 = _mm_load_si128((const __m128i *)&xmmword_18C370C00);
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18C370B60);
			//         UnityEngine::Matrix4x4::Matrix4x4(
			//           &v119,
			//           (Vector4 *)&si128,
			//           (Vector4 *)&v107,
			//           (Vector4 *)&v115,
			//           (Vector4 *)&v116,
			//           0LL);
			//         v120 = *inverse;
			//         v31 = *(_OWORD *)&v119.m00;
			//         v114 = v119;
			//         v32 = *(_OWORD *)&v119.m01;
			//         v33 = *(_OWORD *)&v119.m02;
			//         v34 = UnityEngine::Matrix4x4::op_Multiply(v131, &v114, &v120, 0LL);
			//         v35 = *(_OWORD *)&v34.m00;
			//         v36 = *(_OWORD *)&v34.m01;
			//         v37 = *(_OWORD *)&v34.m02;
			//         v38 = *(_OWORD *)&v34.m03;
			//         v39 = v108;
			//         *(_OWORD *)&v114.m00 = v31;
			//         *(_OWORD *)&v114.m01 = v32;
			//         *(_OWORD *)&v114.m02 = v33;
			//         *(_OWORD *)&v114.m03 = *(_OWORD *)&v119.m03;
			//         GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v131, &v114, 1, 0LL);
			//         *(_OWORD *)&v120.m00 = v128;
			//         *(_OWORD *)&v120.m01 = v129;
			//         *(TextureHandle *)&v120.m02 = v117;
			//         *(Vector4 *)&v120.m03 = v111.constData.param0;
			//         v119 = *GPUProjectionMatrix;
			//         v41 = UnityEngine::Matrix4x4::op_Multiply(v131, &v119, &v120, 0LL);
			//         v44 = *(_OWORD *)&v41.m01;
			//         v45 = *(_OWORD *)&v41.m02;
			//         v46 = *(_OWORD *)&v41.m03;
			//         if ( !v39 )
			//           sub_1802DC2C8(v43, v42);
			//         *(Object *)((char *)v39 + 24) = *(Object *)&v41.m00;
			//         *(_OWORD *)&v39[2].monitor = v44;
			//         *(_OWORD *)&v39[3].monitor = v45;
			//         *(_OWORD *)&v39[4].monitor = v46;
			//         *(_OWORD *)&v114.m00 = v35;
			//         *(_OWORD *)&v114.m01 = v36;
			//         *(_OWORD *)&v114.m02 = v37;
			//         *(_OWORD *)&v114.m03 = v38;
			//         UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v114, v9.fields.m_cullingPlanes, 0LL);
			//         v111.constData.param0 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357460);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v117,
			//           &v118,
			//           &v9.fields.rtHandles.distanceRT,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v111,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v118, 0, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v118,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor.static_fields.s_depthDrawFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::CharacterDepthPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v125 )
			//       {
			//         ex = v125.ex;
			//         sub_180222690(&ex);
			//         v6 = (Object *)renderGraph;
			//         v9 = this;
			//         terrainDeformManager_k__BackingField = v112;
			//         param2 = v123;
			//         param1 = v122;
			//         param0 = v121;
			//         goto LABEL_17;
			//       }
			//       sub_180222690(&ex);
			// LABEL_17:
			//       v47 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xFu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&v111,
			//         (HGRenderGraph *)v6,
			//         (String *)"TerrainDeformGenerate",
			//         &v104,
			//         v47,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::DispatchPassData>);
			//       *(Vector4 *)&v113.m_RenderPass = v111.constData.param0;
			//       *(Vector4 *)&v113.m_RenderGraph = v111.constData.param1;
			//       ex = 0LL;
			//       v106 = &v113;
			//       try
			//       {
			//         v49 = v104;
			//         if ( !v104 )
			//           sub_1802DC2C8(v48, 0LL);
			//         v104[1].klass = (Object__Class *)v9.fields.m_generateCS;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v50 = ((unsigned __int64)&v49[1] >> 12) & 0x1FFFFF;
			//           v51 = (unsigned __int64)v50 >> 6;
			//           v49 = (Object *)(v50 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v51 + 36190]);
			//           do
			//           {
			//             v48 = qword_18D6405E0[v51 + 36190] | (1LL << (char)v49);
			//             v52 = qword_18D6405E0[v51 + 36190];
			//           }
			//           while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v51 + 36190], v48, v52) );
			//         }
			//         v53 = v104;
			//         if ( !v104 )
			//           sub_1802DC2C8(v48, v49);
			//         *(Vector4 *)&v104[1].monitor = param0;
			//         *(Vector4 *)&v53[2].monitor = param1;
			//         *(Vector4 *)&v53[3].monitor = param2;
			//         v54 = v104;
			//         v57 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v111,
			//                  &v113,
			//                  &v9.fields.rtHandles.distanceRT,
			//                  0LL);
			//         if ( !v54 )
			//           sub_1802DC2C8(v56, v55);
			//         *(TextureHandle *)&v54[4].monitor = v57;
			//         v58 = v104;
			//         v61 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v111,
			//                  &v113,
			//                  &v9.fields.m_historyFillRateRT,
			//                  0LL);
			//         if ( !v58 )
			//           sub_1802DC2C8(v60, v59);
			//         *(TextureHandle *)&v58[5].monitor = v61;
			//         v62 = v104;
			//         v65 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&v111,
			//                  &v113,
			//                  &v9.fields.rtHandles.curFillRateRT,
			//                  0LL);
			//         if ( !v62 )
			//           sub_1802DC2C8(v64, v63);
			//         *(TextureHandle *)&v62[6].monitor = v65;
			//         v66 = v104;
			//         v69 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&v111,
			//                  &v113,
			//                  &v9.fields.rtHandles.resultRT,
			//                  0LL);
			//         if ( !v66 )
			//           sub_1802DC2C8(v68, v67);
			//         *(TextureHandle *)&v66[7].monitor = v69;
			//         v70 = v104;
			//         v73 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&v111,
			//                  &v113,
			//                  &v9.fields.rtHandles.densityMip4RT,
			//                  0LL);
			//         if ( !v70 )
			//           sub_1802DC2C8(v72, v71);
			//         *(TextureHandle *)&v70[8].monitor = v73;
			//         v74 = v104;
			//         v77 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v111,
			//                  (HGRenderGraph *)v6,
			//                  v9.fields.m_defaultDensityRT,
			//                  0LL);
			//         if ( !v74 )
			//           sub_1802DC2C8(v76, v75);
			//         *(TextureHandle *)&v74[10].monitor = v77;
			//         v78 = v104;
			//         v81 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v111,
			//                  (HGRenderGraph *)v6,
			//                  v9.fields.m_defaultResultRT,
			//                  0LL);
			//         if ( !v78 )
			//           sub_1802DC2C8(v80, v79);
			//         *(TextureHandle *)&v78[9].monitor = v81;
			//         v82 = camera;
			//         if ( !camera )
			//           sub_1802DC2C8(v80, v79);
			//         vtFeedbackViewId = (unsigned int)camera.fields.vtFeedbackViewId;
			//         if ( !v104 )
			//           sub_1802DC2C8(vtFeedbackViewId, v79);
			//         LODWORD(v104[11].monitor) = vtFeedbackViewId;
			//         terrainCullViewHandle = camera.fields.terrainCullViewHandle;
			//         if ( !v104 )
			//           sub_1802DC2C8(terrainCullViewHandle, v79);
			//         HIDWORD(v104[11].monitor) = terrainCullViewHandle;
			//         editorTerrainCullViewHandle = camera.fields.editorTerrainCullViewHandle;
			//         if ( !v104 )
			//           sub_1802DC2C8(editorTerrainCullViewHandle, v79);
			//         LODWORD(v104[12].klass) = editorTerrainCullViewHandle;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v113, 0, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v113,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor.static_fields.s_dispatchFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::DispatchPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v126 )
			//       {
			//         ex = v126.ex;
			//         sub_180222690(&ex);
			//         v82 = camera;
			//         v6 = (Object *)renderGraph;
			//         terrainDeformManager_k__BackingField = v112;
			//         goto LABEL_36;
			//       }
			//       sub_180222690(&ex);
			// LABEL_36:
			//       HG::Rendering::Runtime::HGTerrainDeformManager::RenderGroundLayer(
			//         terrainDeformManager_k__BackingField,
			//         (HGRenderGraph *)v6,
			//         v82,
			//         0LL);
			//     }
			//     else if ( !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
			//                  BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
			//                  0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v9.fields.m_historyFillRateRT = *(TextureHandle *)sub_182E7CCD0(&v111);
			//       v86 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xDu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         sub_180B536AC(v88, v87);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&v111,
			//         (HGRenderGraph *)v6,
			//         (String *)"TerrainDeformSetDefault",
			//         &v109,
			//         v86,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDeformPassConstructor::SetDefaultPassData>);
			//       *(Vector4 *)&v130.m_RenderPass = v111.constData.param0;
			//       *(Vector4 *)&v130.m_RenderGraph = v111.constData.param1;
			//       ex = 0LL;
			//       v106 = &v130;
			//       try
			//       {
			//         v89 = v109;
			//         v92 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v111,
			//                  (HGRenderGraph *)v6,
			//                  v9.fields.m_defaultDensityRT,
			//                  0LL);
			//         if ( !v89 )
			//           sub_1802DC2C8(v91, v90);
			//         v89[1] = (Object)v92;
			//         v93 = v109;
			//         v96 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v111,
			//                  (HGRenderGraph *)v6,
			//                  v9.fields.m_defaultResultRT,
			//                  0LL);
			//         if ( !v93 )
			//           sub_1802DC2C8(v95, v94);
			//         v93[2] = (Object)v96;
			//         v97 = v109;
			//         v100 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                   (TextureHandle *)&v111,
			//                   (HGRenderGraph *)v6,
			//                   v9.fields.m_defaultGroundLayerRT,
			//                   0LL);
			//         if ( !v97 )
			//           sub_1802DC2C8(v99, v98);
			//         v97[3] = (Object)v100;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v130,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor.static_fields.s_setDefaultFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDeformPassConstructor::SetDefaultPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v127 )
			//       {
			//         ex = v127.ex;
			//         sub_180222690(&ex);
			//         return;
			//       }
			//       sub_180222690(&ex);
			//     }
			//   }
			// }
			// 
		}

		private void _PrepareTextureHandle(HGRenderGraph renderGraph, ref TerrainDeformPassConstructor.FrameRTHandles rtHandles)
		{
			// // Void _PrepareTextureHandle(HGRenderGraph, TerrainDeformPassConstructor+FrameRTHandles ByRef)
			// void HG::Rendering::Runtime::TerrainDeformPassConstructor::_PrepareTextureHandle(
			//         TerrainDeformPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         TerrainDeformPassConstructor_FrameRTHandles *rtHandles,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195D3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9195D3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2839, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyFillRateRT, 0LL) )
			//     {
			//       if ( renderGraph )
			//         goto LABEL_8;
			//     }
			//     else if ( renderGraph )
			//     {
			//       this.fields.m_historyFillRateRT = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                             &v10,
			//                                             renderGraph,
			//                                             this.fields.m_defaultFillRateRT,
			//                                             0LL);
			// LABEL_8:
			//       rtHandles.curFillRateRT = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                     &v10,
			//                                     renderGraph,
			//                                     &this.fields.m_fillRateRTDesc,
			//                                     0LL);
			//       rtHandles.resultRT = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                &v10,
			//                                renderGraph,
			//                                &this.fields.m_resultRTDesc,
			//                                0LL);
			//       rtHandles.densityMip4RT = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                     &v10,
			//                                     renderGraph,
			//                                     &this.fields.m_densityMip4RTDesc,
			//                                     0LL);
			//       rtHandles.distanceRT = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                  &v10,
			//                                  renderGraph,
			//                                  &this.fields.m_distanceRTDesc,
			//                                  0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2839, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1033(Patch, (Object *)this, (Object *)renderGraph, rtHandles, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int TERRAIN_DEFORM_CB_SIZE;

		private RTHandle m_defaultFillRateRT;

		private RTHandle m_defaultDensityRT;

		private RTHandle m_defaultResultRT;

		private RTHandle m_defaultGroundLayerRT;

		private ComputeShader m_generateCS;

		private TextureDesc m_fillRateRTDesc;

		private TextureDesc m_resultRTDesc;

		private TextureDesc m_densityMip4RTDesc;

		private TextureDesc m_distanceRTDesc;

		private TextureHandle m_historyFillRateRT;

		private Plane[] m_cullingPlanes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<TerrainDeformPassConstructor.CharacterDepthPassData> s_depthDrawFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<TerrainDeformPassConstructor.DispatchPassData> s_dispatchFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<TerrainDeformPassConstructor.SetDefaultPassData> s_setDefaultFunc;

		private TerrainDeformPassConstructor.FrameRTHandles rtHandles;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal CullingResults cullingResults;

			internal ScriptableRenderContext renderContext;

			internal bool enableTerrainTessellation;

			internal Material drawInteractionNodeMaterial;
		}

		internal struct PassOutput
		{
		}

		private class CharacterDepthPassData
		{
			public CharacterDepthPassData()
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

			public Material drawInteractionNodeMaterial;

			public Matrix4x4 projView;

			public Bounds bounds;
		}

		private class DispatchPassData
		{
			public DispatchPassData()
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

			public ComputeShader generateCS;

			public TerrainDeformConstData constData;

			public TextureHandle groundDistanceRT;

			public TextureHandle historyFillRateRT;

			public TextureHandle curFillRateRT;

			public TextureHandle resultRT;

			public TextureHandle densityMip4RT;

			public TextureHandle defaultResultRT;

			public TextureHandle defaultDensityRT;

			public int vtFeedbackId;

			public uint terrainCullViewHandle;

			public uint editorTerrainCullViewHandle;
		}

		private class SetDefaultPassData
		{
			public SetDefaultPassData()
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

			public TextureHandle defaultDensityRT;

			public TextureHandle defaultResultRT;

			public TextureHandle defaultGroundLayerRT;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		private struct FrameRTHandles
		{
			public TextureHandle curFillRateRT;

			public TextureHandle resultRT;

			public TextureHandle densityMip4RT;

			public TextureHandle distanceRT;
		}
	}
}
