using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class TerrainDepthPrepassConstructor : IPassConstructor
	{
		internal TerrainDepthPrepassConstructor(HGRenderPathBase.HGRenderPathResources resources)
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

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TerrainDepthPrepassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2844, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2844, 0LL);
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
			// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TerrainDepthPrepassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2845, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2845, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref TerrainDepthPrepassConstructor.PassInput input, ref TerrainDepthPrepassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(TerrainDepthPrepassConstructor+PassInput ByRef, TerrainDepthPrepassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
			//         TerrainDepthPrepassConstructor *this,
			//         TerrainDepthPrepassConstructor_PassInput *input,
			//         TerrainDepthPrepassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r15
			//   TerrainDepthPrepassConstructor_PassOutput *v7; // r13
			//   TerrainDepthPrepassConstructor_PassInput *v8; // rsi
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   HGCamera *v15; // r14
			//   __int64 subdivisionHandle; // rcx
			//   __int64 terrainCullViewHandle; // rcx
			//   __int64 editorTerrainCullViewHandle; // rcx
			//   __int64 terrainSubdMode; // rcx
			//   __int64 terrainSubdModeV2; // rcx
			//   __int64 terrainGpuSubd; // rcx
			//   __int64 terrainPrimitivePixelLengthTargetLog2; // rcx
			//   Object *v23; // rbx
			//   TextureHandle *v24; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   ProfilingSampler *v27; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   Object *v32; // r12
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   TextureHandle v36; // xmm0
			//   TextureHandle *v37; // r8
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rcx
			//   __int64 v41; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   Object *v45; // [rsp+50h] [rbp-C8h] BYREF
			//   Object *v46; // [rsp+58h] [rbp-C0h] BYREF
			//   Il2CppException *ex; // [rsp+60h] [rbp-B8h] BYREF
			//   HGRenderGraphBuilder *v48; // [rsp+68h] [rbp-B0h]
			//   __m128i si128; // [rsp+70h] [rbp-A8h] BYREF
			//   HGRenderGraphBuilder v50; // [rsp+80h] [rbp-98h] BYREF
			//   HGRenderGraphBuilder v51; // [rsp+A0h] [rbp-78h] BYREF
			//   HGRenderGraphBuilder v52; // [rsp+C0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v53; // [rsp+E0h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v54; // [rsp+E8h] [rbp-30h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v7 = output;
			//   v8 = input;
			//   if ( !byte_18D9195D7 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503650);
			//     sub_18003C530(&off_18D5035E0);
			//     byte_18D9195D7 = 1;
			//   }
			//   v45 = 0LL;
			//   v46 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2846, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2846, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v44, v43);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1036(Patch, (Object *)this, v8, v7, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x12u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v50,
			//       (HGRenderGraph *)v6,
			//       (String *)"TerrainSubdivision",
			//       &v45,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_PreDepth,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
			//     v52 = v50;
			//     ex = 0LL;
			//     v48 = &v52;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v52, 0, 0LL);
			//       v15 = camera;
			//       if ( !camera )
			//         sub_1802DC2C8(v14, v13);
			//       subdivisionHandle = (unsigned int)camera.fields.subdivisionHandle;
			//       if ( !v45 )
			//         sub_1802DC2C8(subdivisionHandle, v13);
			//       LODWORD(v45[1].klass) = subdivisionHandle;
			//       terrainCullViewHandle = camera.fields.terrainCullViewHandle;
			//       if ( !v45 )
			//         sub_1802DC2C8(terrainCullViewHandle, v13);
			//       HIDWORD(v45[1].klass) = terrainCullViewHandle;
			//       editorTerrainCullViewHandle = camera.fields.editorTerrainCullViewHandle;
			//       if ( !v45 )
			//         sub_1802DC2C8(editorTerrainCullViewHandle, v13);
			//       LODWORD(v45[1].monitor) = editorTerrainCullViewHandle;
			//       LOBYTE(editorTerrainCullViewHandle) = v8.enableTerrainTessellation;
			//       if ( !v45 )
			//         sub_1802DC2C8(editorTerrainCullViewHandle, v13);
			//       BYTE4(v45[1].monitor) = editorTerrainCullViewHandle;
			//       LOBYTE(editorTerrainCullViewHandle) = v8.enableTerrainSubdivision;
			//       if ( !v45 )
			//         sub_1802DC2C8(editorTerrainCullViewHandle, v13);
			//       BYTE5(v45[1].monitor) = editorTerrainCullViewHandle;
			//       LOBYTE(editorTerrainCullViewHandle) = v8.enableTerrainSubdivisionV2;
			//       if ( !v45 )
			//         sub_1802DC2C8(editorTerrainCullViewHandle, v13);
			//       BYTE6(v45[1].monitor) = editorTerrainCullViewHandle;
			//       terrainSubdMode = (unsigned int)v8.terrainSubdMode;
			//       if ( !v45 )
			//         sub_1802DC2C8(terrainSubdMode, v13);
			//       LODWORD(v45[2].klass) = terrainSubdMode;
			//       terrainSubdModeV2 = (unsigned int)v8.terrainSubdModeV2;
			//       if ( !v45 )
			//         sub_1802DC2C8(terrainSubdModeV2, v13);
			//       HIDWORD(v45[2].klass) = terrainSubdModeV2;
			//       terrainGpuSubd = (unsigned int)v8.terrainGpuSubd;
			//       if ( !v45 )
			//         sub_1802DC2C8(terrainGpuSubd, v13);
			//       LODWORD(v45[2].monitor) = terrainGpuSubd;
			//       terrainPrimitivePixelLengthTargetLog2 = (unsigned int)v8.terrainPrimitivePixelLengthTargetLog2;
			//       if ( !v45 )
			//         sub_1802DC2C8(terrainPrimitivePixelLengthTargetLog2, v13);
			//       HIDWORD(v45[2].monitor) = terrainPrimitivePixelLengthTargetLog2;
			//       v23 = v45;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8.HZBTexture, 0LL) )
			//       {
			//         v24 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                 (TextureHandle *)&si128,
			//                 &v52,
			//                 &v8.HZBTexture,
			//                 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v24 = (TextureHandle *)sub_182E7CCD0(&si128);
			//       }
			//       if ( !v23 )
			//         sub_1802DC2C8(v26, v25);
			//       v23[3] = *(Object *)v24;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v52,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor.static_fields.s_terrainSubdivisionFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v53 )
			//     {
			//       ex = v53.ex;
			//       sub_180222690(&ex);
			//       v15 = camera;
			//       v6 = (Object *)renderGraph;
			//       v7 = output;
			//       v8 = input;
			//       goto LABEL_23;
			//     }
			//     sub_180222690(&ex);
			// LABEL_23:
			//     v27 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x13u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       sub_1802DC2C8(v29, v28);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v50,
			//       (HGRenderGraph *)v6,
			//       (String *)"TerrainDepthPrepass",
			//       &v46,
			//       v27,
			//       1,
			//       ProfilingHGPass__Enum_PreDepth,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
			//     v51 = v50;
			//     ex = 0LL;
			//     v48 = &v51;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v51, 0, 0LL);
			//       v32 = v46;
			//       if ( !v15 )
			//         sub_1802DC2C8(v31, v30);
			//       sceneRTSize_k__BackingField = v15.fields._sceneRTSize_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v36 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
			//                (TextureHandle *)&si128,
			//                (HGRenderGraph *)v6,
			//                sceneRTSize_k__BackingField,
			//                0LL);
			//       if ( !v32 )
			//         sub_1802DC2C8(v35, v34);
			//       v32[2] = (Object)v36;
			//       v37 = (TextureHandle *)v46;
			//       if ( !v46 )
			//         sub_1802DC2C8(v35, v34);
			//       *v7 = (TerrainDepthPrepassConstructor_PassOutput)v46[2];
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v50,
			//         &v51,
			//         v37 + 2,
			//         0,
			//         RenderBufferLoadAction__Enum_Clear,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v50,
			//         &v51,
			//         &v8.sceneDepth,
			//         DepthAccess__Enum_Write,
			//         0,
			//         0LL);
			//       v39 = (unsigned int)v15.fields.subdivisionHandle;
			//       if ( !v46 )
			//         sub_1802DC2C8(v39, v38);
			//       LODWORD(v46[1].klass) = v39;
			//       v40 = v15.fields.terrainCullViewHandle;
			//       if ( !v46 )
			//         sub_1802DC2C8(v40, v38);
			//       HIDWORD(v46[1].klass) = v40;
			//       v41 = v15.fields.editorTerrainCullViewHandle;
			//       if ( !v46 )
			//         sub_1802DC2C8(v41, v38);
			//       LODWORD(v46[1].monitor) = v41;
			//       LOBYTE(v41) = v8.enableTerrainTessellation;
			//       if ( !v46 )
			//         sub_1802DC2C8(v41, v38);
			//       BYTE4(v46[1].monitor) = v41;
			//       LOBYTE(v41) = v8.enableTerrainSubdivision;
			//       if ( !v46 )
			//         sub_1802DC2C8(v41, v38);
			//       BYTE5(v46[1].monitor) = v41;
			//       LOBYTE(v41) = v8.enableTerrainSubdivisionV2;
			//       if ( !v46 )
			//         sub_1802DC2C8(v41, v38);
			//       BYTE6(v46[1].monitor) = v41;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v51,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor.static_fields.s_terrainDepthPrepassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v54 )
			//     {
			//       ex = v54.ex;
			//       sub_180222690(&ex);
			//       return;
			//     }
			//     sub_180222690(&ex);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TerrainDepthPrepassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2847, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2847, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TerrainDepthPrepassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2848, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2848, 0LL);
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

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<TerrainDepthPrepassConstructor.TerrainSubdivisionData> s_terrainSubdivisionFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<TerrainDepthPrepassConstructor.TerrainDepthPrepassData> s_terrainDepthPrepassRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightingConfig;

			internal bool enableTerrainTessellation;

			internal bool enableTerrainSubdivision;

			internal bool enableTerrainSubdivisionV2;

			internal int terrainSubdMode;

			internal int terrainSubdModeV2;

			internal int terrainGpuSubd;

			internal int terrainPrimitivePixelLengthTargetLog2;

			internal TextureHandle HZBTexture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			public TextureHandle terrainDepthBuffer;
		}

		public class TerrainSubdivisionData
		{
			public TerrainSubdivisionData()
			{
				// // TerrainDepthPrepassConstructor+TerrainSubdivisionData()
				// void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData::TerrainSubdivisionData(
				//         TerrainDepthPrepassConstructor_TerrainSubdivisionData *this,
				//         MethodInfo *method)
				// {
				//   _BYTE v3[24]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D9195D8 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     byte_18D9195D8 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, method);
				//   this.fields.HZBTexture = *(TextureHandle *)sub_182E7CCD0(v3);
				// }
				// 
			}

			public int subdivisionHandle;

			public uint terrainCullViewHandle;

			public uint editorTerrainCullViewHandle;

			public bool enableTerrainTessellation;

			public bool enableTerrainSubdivision;

			public bool enableTerrainSubdivisionV2;

			public int terrainSubdMode;

			public int terrainSubdModeV2;

			public int terrainGpuSubd;

			public int terrainPrimitivePixelLengthTargetLog2;

			public TextureHandle HZBTexture;
		}

		public class TerrainDepthPrepassData
		{
			public TerrainDepthPrepassData()
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

			public int subdivisionHandle;

			public uint terrainCullViewHandle;

			public uint editorTerrainCullViewHandle;

			public bool enableTerrainTessellation;

			public bool enableTerrainSubdivision;

			public bool enableTerrainSubdivisionV2;

			public TextureHandle terrainDepthBuffer;
		}
	}
}
