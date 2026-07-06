using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class FoliageOccluderPassConstructor : IPassConstructor
	{
		internal FoliageOccluderPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void InitializeRenderTexture()
		{
			// // Void InitializeRenderTexture()
			// void HG::Rendering::Runtime::FoliageOccluderPassConstructor::InitializeRenderTexture(
			//         FoliageOccluderPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   FileDescriptor *v4; // r8
			//   MessageDescriptor *v5; // r9
			//   OneofDescriptorProto *v6; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   String__Array *colorFormat; // [rsp+20h] [rbp-98h]
			//   String__Array *colorFormata; // [rsp+20h] [rbp-98h]
			//   String__Array *colorFormatb; // [rsp+20h] [rbp-98h]
			//   String *filterMode; // [rsp+28h] [rbp-90h]
			//   String *filterModea; // [rsp+28h] [rbp-90h]
			//   String *filterModeb; // [rsp+28h] [rbp-90h]
			//   MethodInfo *wrapMode; // [rsp+30h] [rbp-88h]
			//   MethodInfo *wrapModea; // [rsp+30h] [rbp-88h]
			//   MethodInfo *wrapModeb; // [rsp+30h] [rbp-88h]
			// 
			//   if ( !byte_18D91954A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18D4FDB08);
			//     sub_18003C530(&off_18D4FDB20);
			//     sub_18003C530(&off_18D4FDB30);
			//     byte_18D91954A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2611, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2611, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     this.fields.m_foliageOccluderRenderTexture = UnityEngine::Rendering::RTHandles::Alloc(
			//                                                     512,
			//                                                     512,
			//                                                     1,
			//                                                     DepthBits__Enum_None,
			//                                                     GraphicsFormat__Enum_R8_UNorm,
			//                                                     FilterMode__Enum_Point,
			//                                                     TextureWrapMode__Enum_Clamp,
			//                                                     TextureDimension__Enum_Tex2D,
			//                                                     0,
			//                                                     0,
			//                                                     0,
			//                                                     0,
			//                                                     1,
			//                                                     0.0,
			//                                                     MSAASamples__Enum_None,
			//                                                     0,
			//                                                     RenderTextureMemoryless__Enum_None,
			//                                                     (String *)"occluderRenderTexture",
			//                                                     0LL);
			//     sub_1800054D0((OneofDescriptor *)&this.fields, v3, v4, v5, colorFormat, filterMode, wrapMode);
			//     this.fields.m_foliageOccluderMaskA = UnityEngine::Rendering::RTHandles::Alloc(
			//                                             512,
			//                                             512,
			//                                             1,
			//                                             DepthBits__Enum_None,
			//                                             GraphicsFormat__Enum_R8G8_UNorm,
			//                                             FilterMode__Enum_Point,
			//                                             TextureWrapMode__Enum_Clamp,
			//                                             TextureDimension__Enum_Tex2D,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0.0,
			//                                             MSAASamples__Enum_None,
			//                                             0,
			//                                             RenderTextureMemoryless__Enum_None,
			//                                             (String *)"FoliageOccluderFinalMaskA",
			//                                             0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_foliageOccluderMaskA,
			//       v6,
			//       v7,
			//       v8,
			//       colorFormata,
			//       filterModea,
			//       wrapModea);
			//     this.fields.m_foliageOccluderMaskB = UnityEngine::Rendering::RTHandles::Alloc(
			//                                             512,
			//                                             512,
			//                                             1,
			//                                             DepthBits__Enum_None,
			//                                             GraphicsFormat__Enum_R8G8_UNorm,
			//                                             FilterMode__Enum_Point,
			//                                             TextureWrapMode__Enum_Clamp,
			//                                             TextureDimension__Enum_Tex2D,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0,
			//                                             0.0,
			//                                             MSAASamples__Enum_None,
			//                                             0,
			//                                             RenderTextureMemoryless__Enum_None,
			//                                             (String *)"FoliageOccluderFinalMaskB",
			//                                             0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_foliageOccluderMaskB,
			//       v9,
			//       v10,
			//       v11,
			//       colorFormatb,
			//       filterModeb,
			//       wrapModeb);
			//     this.fields.m_renderTextureInitialized = 1;
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         FoliageOccluderPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2612, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2612, 0LL);
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
			// void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         FoliageOccluderPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2613, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2613, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref FoliageOccluderPassConstructor.PassInput input, ref FoliageOccluderPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(FoliageOccluderPassConstructor+PassInput ByRef, FoliageOccluderPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
			//         FoliageOccluderPassConstructor *this,
			//         FoliageOccluderPassConstructor_PassInput *input,
			//         FoliageOccluderPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v6; // rsi
			//   FoliageOccluderPassConstructor *v9; // r14
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   HGFoliageOccluderRenderParams *Params; // r12
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   TextureHandle v18; // xmm12
			//   TextureHandle blackTexture_k__BackingField; // xmm11
			//   RTHandle *m_foliageOccluderMaskA; // rbx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   TextureHandle v23; // xmm10
			//   HGRenderGraphDefaultResources *m_DefaultResources; // rbx
			//   __int64 v25; // rbx
			//   __int128 v26; // xmm6
			//   __int128 v27; // xmm7
			//   __int128 v28; // xmm8
			//   __int128 v29; // xmm9
			//   FoliageOccluderPassConstructor__StaticFields *static_fields; // rcx
			//   Void *m_Buffer; // r15
			//   __int64 v32; // r12
			//   __int64 v33; // rdx
			//   FoliageOccluderPassConstructor__StaticFields *v34; // rcx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   __int64 v37; // r12
			//   Camera *camera; // rbx
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   uint64_t SceneCullingMaskFromCamera; // r13
			//   int32_t cullingMask; // ebx
			//   uint32_t COMPOUND_CHARACTER_LAYER_MASK; // r9d
			//   Object_1 *m_occluderMaterial; // rbx
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   int32_t InstanceID; // eax
			//   uint32_t MaterialHandle; // r13d
			//   Object_1 *m_occluderMesh; // rbx
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   int32_t v52; // eax
			//   uint32_t GeometryHandle; // r15d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbx
			//   uint32_t RendererList; // ebx
			//   ProfilingSampler *v56; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   ProfilingSampler *v61; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   __int64 v64; // rcx
			//   Object *v65; // rdx
			//   unsigned int v66; // edx
			//   unsigned __int64 v67; // r8
			//   char v68; // dl
			//   signed __int64 v69; // rtt
			//   Object *v70; // r15
			//   __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   TextureHandle v73; // xmm0
			//   Object *v74; // rdx
			//   unsigned int v75; // edx
			//   unsigned __int64 v76; // r8
			//   char v77; // dl
			//   signed __int64 v78; // rtt
			//   __int64 v79; // rdx
			//   __int64 v80; // rcx
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   __int64 v83; // rdx
			//   __int64 v84; // rcx
			//   ProfilingSampler *v85; // rax
			//   __int64 v86; // rdx
			//   __int64 v87; // rcx
			//   __int64 v88; // rdx
			//   __int64 v89; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   Object *v93; // [rsp+50h] [rbp-1B8h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v94; // [rsp+60h] [rbp-1A8h] BYREF
			//   uint32_t viewHandle[2]; // [rsp+70h] [rbp-198h] BYREF
			//   HGRenderGraphBuilder *v96; // [rsp+78h] [rbp-190h]
			//   TextureHandle *v97; // [rsp+80h] [rbp-188h] BYREF
			//   Object *v98; // [rsp+88h] [rbp-180h] BYREF
			//   Matrix4x4 v99; // [rsp+90h] [rbp-178h] BYREF
			//   HGRenderGraphBuilder v100; // [rsp+D0h] [rbp-138h] BYREF
			//   TextureHandle v101; // [rsp+F0h] [rbp-118h]
			//   TextureHandle v102; // [rsp+100h] [rbp-108h]
			//   HGRenderGraphBuilder v103; // [rsp+110h] [rbp-F8h] BYREF
			//   HGRenderGraphBuilder v104; // [rsp+130h] [rbp-D8h] BYREF
			//   Il2CppExceptionWrapper *v105; // [rsp+150h] [rbp-B8h] BYREF
			//   Il2CppExceptionWrapper *v106; // [rsp+158h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v107; // [rsp+160h] [rbp-A8h] BYREF
			// 
			//   v6 = renderGraph;
			//   v9 = this;
			//   if ( !byte_18D91954B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D4FD9F8);
			//     sub_18003C530(&off_18D4FDA08);
			//     sub_18003C530(&off_18D4FDA18);
			//     byte_18D91954B = 1;
			//   }
			//   v94 = 0LL;
			//   memset(&v103, 0, sizeof(v103));
			//   v97 = 0LL;
			//   memset(&v100, 0, sizeof(v100));
			//   v93 = 0LL;
			//   memset(&v104, 0, sizeof(v104));
			//   v98 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2614, 0LL) )
			//   {
			//     if ( !v9.fields.m_renderTextureInitialized )
			//       HG::Rendering::Runtime::FoliageOccluderPassConstructor::InitializeRenderTexture(v9, 0LL);
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext )
			//       sub_180B536AC(v12, v11);
			//     if ( !currentManagerContext.fields._foliageOccluderManager_k__BackingField )
			//       sub_180B536AC(v12, v11);
			//     Params = HG::Rendering::Runtime::HGFoliageOccluderManager::GetParams(
			//                currentManagerContext.fields._foliageOccluderManager_k__BackingField,
			//                0LL);
			//     *(_QWORD *)viewHandle = Params;
			//     if ( !v6 )
			//       sub_180B536AC(v14, v13);
			//     v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//              (TextureHandle *)&v99,
			//              v6,
			//              v9.fields.m_foliageOccluderRenderTexture,
			//              0LL);
			//     if ( !Params )
			//       sub_180B536AC(v17, v16);
			//     if ( Params.fields.curMaskIsA )
			//     {
			//       blackTexture_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                         (TextureHandle *)&v99,
			//                                         v6,
			//                                         v9.fields.m_foliageOccluderMaskB,
			//                                         0LL);
			//       v101 = blackTexture_k__BackingField;
			//       m_foliageOccluderMaskA = v9.fields.m_foliageOccluderMaskA;
			//     }
			//     else
			//     {
			//       blackTexture_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                         (TextureHandle *)&v99,
			//                                         v6,
			//                                         v9.fields.m_foliageOccluderMaskA,
			//                                         0LL);
			//       v101 = blackTexture_k__BackingField;
			//       m_foliageOccluderMaskA = v9.fields.m_foliageOccluderMaskB;
			//     }
			//     v23 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//              (TextureHandle *)&v99,
			//              v6,
			//              m_foliageOccluderMaskA,
			//              0LL);
			//     v102 = v23;
			//     if ( v9.fields.m_renderFirstFrame )
			//     {
			//       m_DefaultResources = v6.fields.m_DefaultResources;
			//       if ( !m_DefaultResources )
			//         sub_180B536AC(v22, v21);
			//       blackTexture_k__BackingField = m_DefaultResources.fields._blackTexture_k__BackingField;
			//       v101 = blackTexture_k__BackingField;
			//     }
			//     v25 = 0LL;
			//     if ( !Params.fields.shouldRender )
			//       goto LABEL_55;
			//     v26 = *(_OWORD *)&Params.fields.cullingMatrix.m00;
			//     v27 = *(_OWORD *)&Params.fields.cullingMatrix.m01;
			//     v28 = *(_OWORD *)&Params.fields.cullingMatrix.m02;
			//     v29 = *(_OWORD *)&Params.fields.cullingMatrix.m03;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor.static_fields;
			//     *(_OWORD *)&v99.m00 = v26;
			//     *(_OWORD *)&v99.m01 = v27;
			//     *(_OWORD *)&v99.m02 = v28;
			//     *(_OWORD *)&v99.m03 = v29;
			//     UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v99, static_fields.s_tempPlanes, 0LL);
			//     Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//       &v94,
			//       6,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     m_Buffer = v94.m_Buffer;
			//     v32 = 6LL;
			//     do
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//       v34 = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor.static_fields;
			//       if ( !v34.s_tempPlanes )
			//         sub_180B536AC(v34, v33);
			//       sub_180037190(v34.s_tempPlanes, &v99, v25);
			//       *(_OWORD *)m_Buffer = *(_OWORD *)&v99.m00;
			//       ++v25;
			//       m_Buffer += 16;
			//       --v32;
			//     }
			//     while ( v32 );
			//     v37 = *(_QWORD *)viewHandle;
			//     if ( !hgCamera )
			//       sub_180B536AC(v36, v35);
			//     camera = hgCamera.fields.camera;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
			//     if ( !hgCamera.fields.camera )
			//       sub_180B536AC(v40, v39);
			//     cullingMask = UnityEngine::Camera::get_cullingMask(hgCamera.fields.camera, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     COMPOUND_CHARACTER_LAYER_MASK = TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			//     *(NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&v99.m00 = v94;
			//     viewHandle[0] = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                       (NativeArray_1_UnityEngine_Plane_ *)&v99,
			//                       0,
			//                       SceneCullingMaskFromCamera,
			//                       cullingMask & ~COMPOUND_CHARACTER_LAYER_MASK,
			//                       0x80000u,
			//                       0x80000u,
			//                       &hgCamera.fields.lodCrossFadeConfig,
			//                       0.0,
			//                       CameraType__Enum_Shadow,
			//                       0LL);
			//     UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//     m_occluderMaterial = (Object_1 *)v9.fields.m_occluderMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(m_occluderMaterial, 0LL, 0LL) )
			//     {
			//       if ( !v9.fields.m_occluderMaterial )
			//         sub_180B536AC(v46, v45);
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v9.fields.m_occluderMaterial, 0LL);
			//       MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(InstanceID, 0LL);
			//     }
			//     else
			//     {
			//       MaterialHandle = 0;
			//     }
			//     m_occluderMesh = (Object_1 *)v9.fields.m_occluderMesh;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(m_occluderMesh, 0LL, 0LL) )
			//     {
			//       if ( !v9.fields.m_occluderMesh )
			//         sub_180B536AC(v51, v50);
			//       v52 = UnityEngine::Object::GetInstanceID((Object_1 *)v9.fields.m_occluderMesh, 0LL);
			//       GeometryHandle = UnityEngine::HyperGryph::HGGeometrySystem::GetGeometryHandle(v52, 0LL);
			//     }
			//     else
			//     {
			//       GeometryHandle = 0;
			//     }
			//     m_RenderGraphContext = v6.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       sub_180B536AC(v51, v50);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     RendererList = UnityEngine::HyperGryph::HGFoliageOccluderRender::CreateRendererList(
			//                      viewHandle[0],
			//                      MaterialHandle,
			//                      GeometryHandle,
			//                      HGShaderLightMode__Enum_Forward,
			//                      m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                      0LL);
			//     if ( !*(_BYTE *)(v37 + 16) )
			//       goto LABEL_55;
			//     v56 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x73u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     v103 = *(HGRenderGraphBuilder *)sub_180830778(
			//                                       (unsigned int)&v99,
			//                                       (_DWORD)v6,
			//                                       (unsigned int)"Foliage Occluder Render",
			//                                       (unsigned int)&v97,
			//                                       (__int64)v56);
			//     *(_QWORD *)viewHandle = 0LL;
			//     v96 = &v103;
			//     try
			//     {
			//       if ( !v97 )
			//         sub_1802DC2C8(v58, v57);
			//       v97[4] = v18;
			//       if ( !v97 )
			//         sub_1802DC2C8(v58, v57);
			//       v97[5].handle.m_Value = RendererList;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v103, 0, 0LL);
			//       if ( !v97 )
			//         sub_1802DC2C8(v60, v59);
			//       *(__m128i *)&v99.m00 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v94,
			//         &v103,
			//         v97 + 4,
			//         0,
			//         (Color *)&v99,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v103,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor.static_fields.s_foliageOccluderRenderPass,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v105 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v105.ex;
			//       sub_180222690(viewHandle);
			//       v6 = renderGraph;
			//       v9 = this;
			//       blackTexture_k__BackingField = v101;
			//       v23 = v102;
			//       goto LABEL_38;
			//     }
			//     sub_180222690(viewHandle);
			// LABEL_38:
			//     v61 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x74u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       goto LABEL_90;
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       (HGRenderGraphBuilder *)&v99,
			//       v6,
			//       (String *)"Foliage Occluder Blit",
			//       &v93,
			//       v61,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//     *(_OWORD *)&v100.m_RenderPass = *(_OWORD *)&v99.m00;
			//     *(_OWORD *)&v100.m_RenderGraph = *(_OWORD *)&v99.m01;
			//     v94.m_Buffer = 0LL;
			//     *(_QWORD *)&v94.m_Length = &v100;
			//     try
			//     {
			//       v65 = v93;
			//       if ( !v93 )
			//         sub_1802DC2C8(v64, 0LL);
			//       v93[1].klass = (Object__Class *)v9.fields.m_blitMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v66 = ((unsigned __int64)&v65[1] >> 12) & 0x1FFFFF;
			//         v67 = (unsigned __int64)v66 >> 6;
			//         v68 = v66 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v67 + 36190]);
			//         do
			//           v69 = qword_18D6405E0[v67 + 36190];
			//         while ( v69 != _InterlockedCompareExchange64(&qword_18D6405E0[v67 + 36190], v69 | (1LL << v68), v69) );
			//       }
			//       v70 = v93;
			//       v73 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                (TextureHandle *)&v99,
			//                v6,
			//                v9.fields.m_foliageOccluderRenderTexture,
			//                0LL);
			//       if ( !v70 )
			//         sub_1802DC2C8(v72, v71);
			//       v70[4] = (Object)v73;
			//       if ( !v93 )
			//         sub_1802DC2C8(v72, v71);
			//       v93[2] = (Object)blackTexture_k__BackingField;
			//       if ( !v93 )
			//         sub_1802DC2C8(v72, v71);
			//       v93[3] = (Object)v23;
			//       v74 = v93;
			//       if ( !v93 )
			//         sub_1802DC2C8(v72, 0LL);
			//       v93[1].monitor = (MonitorData *)v9.fields.m_blitFoliageOccluderPropertyBlock;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v75 = ((unsigned __int64)&v74[1].monitor >> 12) & 0x1FFFFF;
			//         v76 = (unsigned __int64)v75 >> 6;
			//         v77 = v75 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v76 + 36190]);
			//         do
			//           v78 = qword_18D6405E0[v76 + 36190];
			//         while ( v78 != _InterlockedCompareExchange64(&qword_18D6405E0[v76 + 36190], v78 | (1LL << v77), v78) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v100, 0, 0LL);
			//       if ( !v93 )
			//         sub_1802DC2C8(v80, v79);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&v99,
			//         &v100,
			//         (TextureHandle *)&v93[4],
			//         0LL);
			//       if ( !v93 )
			//         sub_1802DC2C8(v82, v81);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&v99,
			//         &v100,
			//         (TextureHandle *)&v93[2],
			//         0LL);
			//       if ( !v93 )
			//         sub_1802DC2C8(v84, v83);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v99,
			//         &v100,
			//         (TextureHandle *)&v93[3],
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v100,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor.static_fields.s_foliageOccluderBlitPass,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v106 )
			//     {
			//       v94.m_Buffer = (Void *)v106.ex;
			//       sub_180222690(&v94);
			//       v6 = renderGraph;
			//       v9 = this;
			//       v23 = v102;
			// LABEL_55:
			//       v85 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x73u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			// LABEL_90:
			//         sub_1802DC2C8(v63, v62);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&v99,
			//         v6,
			//         (String *)"Foliage Occluder Set Final Mask",
			//         &v98,
			//         v85,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//       *(_OWORD *)&v104.m_RenderPass = *(_OWORD *)&v99.m00;
			//       *(_OWORD *)&v104.m_RenderGraph = *(_OWORD *)&v99.m01;
			//       v94.m_Buffer = 0LL;
			//       *(_QWORD *)&v94.m_Length = &v104;
			//       try
			//       {
			//         if ( !v98 )
			//           sub_1802DC2C8(v87, v86);
			//         v98[3] = (Object)v23;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v104, 0, 0LL);
			//         if ( !v98 )
			//           sub_1802DC2C8(v89, v88);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//           (TextureHandle *)&v99,
			//           &v104,
			//           (TextureHandle *)&v98[3],
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v104,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor.static_fields.s_setFinalMaskPass,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v107 )
			//       {
			//         v94.m_Buffer = (Void *)v107.ex;
			//         sub_180222690(&v94);
			//         v9 = this;
			//         goto LABEL_61;
			//       }
			//     }
			//     sub_180222690(&v94);
			// LABEL_61:
			//     if ( v9.fields.m_renderFirstFrame )
			//       v9.fields.m_renderFirstFrame = 0;
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2614, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v92, v91);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_955(
			//     Patch,
			//     (Object *)v9,
			//     input,
			//     output,
			//     (Object *)v6,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         FoliageOccluderPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2615, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2615, 0LL);
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

		private RTHandle m_foliageOccluderRenderTexture;

		private RTHandle m_foliageOccluderMaskA;

		private RTHandle m_foliageOccluderMaskB;

		private MaterialPropertyBlock m_blitFoliageOccluderPropertyBlock;

		private Material m_occluderMaterial;

		private Mesh m_occluderMesh;

		private Material m_blitMaterial;

		private bool m_renderFirstFrame;

		private bool m_renderTextureInitialized;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<FoliageOccluderPassConstructor.FoliageOccluderPassData> s_foliageOccluderRenderPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<FoliageOccluderPassConstructor.FoliageOccluderPassData> s_foliageOccluderBlitPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<FoliageOccluderPassConstructor.FoliageOccluderPassData> s_setFinalMaskPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static Plane[] s_tempPlanes;

		internal struct PassInput
		{
		}

		internal struct PassOutput
		{
		}

		internal class FoliageOccluderPassData
		{
			public FoliageOccluderPassData()
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

			internal Material blitMat;

			internal MaterialPropertyBlock blitMaterialPropertyBlock;

			internal TextureHandle prevFinalTexture;

			internal TextureHandle curFinalTexture;

			internal TextureHandle occluderRenderTexture;

			internal uint ecsRendererList;
		}
	}
}
