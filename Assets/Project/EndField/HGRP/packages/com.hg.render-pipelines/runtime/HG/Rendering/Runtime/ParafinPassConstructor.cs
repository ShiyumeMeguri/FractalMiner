using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class ParafinPassConstructor : IPassConstructor
	{
		internal ParafinPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void ParafinPass(ref ParafinPassConstructor.PassInput input, ref ParafinPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthRT, TextureHandle targetRT)
		{
			// // Void ParafinPass(ParafinPassConstructor+PassInput ByRef, ParafinPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ParafinPassConstructor::ParafinPass(
			//         ParafinPassConstructor *this,
			//         ParafinPassConstructor_PassInput *input,
			//         ParafinPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         TextureHandle *depthRT,
			//         TextureHandle *targetRT,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v8; // r14
			//   ParafinPassConstructor_PassInput *v10; // r15
			//   int32_t effectListCount; // ebx
			//   __int64 v13; // rdi
			//   int32_t v14; // esi
			//   __int64 v15; // r13
			//   Material__Array *s_parafinMaterials; // r12
			//   __int64 v17; // rdx
			//   VFXPPCutsceneEffect__StaticFields *v18; // rcx
			//   Material__Array *runtimeMaterial; // r14
			//   __int64 v20; // r15
			//   MonitorData *BlitMaterial; // rsi
			//   ProfilingSampler *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // rdx
			//   Object *v26; // rcx
			//   Object__Class *parafinMesh; // rdx
			//   int v28; // eax
			//   unsigned __int64 v29; // r8
			//   unsigned __int64 v30; // rdx
			//   signed __int64 v31; // rtt
			//   Object *v32; // rdx
			//   unsigned __int64 v33; // rdx
			//   unsigned __int64 v34; // r8
			//   char v35; // dl
			//   signed __int64 v36; // rtt
			//   Object *v37; // rsi
			//   unsigned __int64 v38; // rdx
			//   Object__Class **static_fields; // rcx
			//   unsigned __int64 v40; // r8
			//   signed __int64 v41; // rtt
			//   Object *v42; // rbx
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   TextureHandle v45; // xmm0
			//   Object *v46; // rbx
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   TextureHandle v49; // xmm0
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v53; // [rsp+50h] [rbp-A8h] BYREF
			//   TextureHandle si128; // [rsp+60h] [rbp-98h] BYREF
			//   TextureHandle v55; // [rsp+70h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v56; // [rsp+80h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v57; // [rsp+A0h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v58; // [rsp+A8h] [rbp-50h] BYREF
			// 
			//   v8 = renderGraph;
			//   v10 = input;
			//   if ( !byte_18D9195AF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     sub_18003C530(&off_18D500C70);
			//     byte_18D9195AF = 1;
			//   }
			//   v53 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2770, 0LL) )
			//   {
			//     *output = (ParafinPassConstructor_PassOutput)v10.sceneColor;
			//     if ( !v10.enableParafin )
			//       return;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     effectListCount = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount;
			//     v13 = 32LL;
			//     v14 = 0;
			//     if ( effectListCount >= 32 )
			//     {
			//       effectListCount = 32;
			//     }
			//     else if ( effectListCount <= 0 )
			//     {
			// LABEL_15:
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       BlitMaterial = (MonitorData *)HG::Rendering::Runtime::HGUtils::GetBlitMaterial(
			//                                       0,
			//                                       TextureDimension__Enum_Tex2D,
			//                                       0,
			//                                       0LL);
			//       v22 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x99u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v8 )
			//         sub_180B536AC(v24, v23);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v58,
			//         v8,
			//         (String *)"Parafin",
			//         &v53,
			//         v22,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
			//       v56 = v58;
			//       v55.handle = 0LL;
			//       v55.fallBackResource = (ResourceHandle)&v56;
			//       try
			//       {
			//         v26 = v53;
			//         if ( !hgCamera )
			//           sub_1802DC2C8(v53, v25);
			//         parafinMesh = (Object__Class *)hgCamera.fields.parafinMesh;
			//         if ( !v53 )
			//           sub_1802DC2C8(0LL, parafinMesh);
			//         v53[3].klass = parafinMesh;
			//         v28 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v29 = (((unsigned __int64)&v26[3] >> 12) & 0x1FFFFF) >> 6;
			//           v30 = ((unsigned __int64)&v26[3] >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v29 + 36190]);
			//           do
			//           {
			//             v26 = (Object *)(qword_18D6405E0[v29 + 36190] | (1LL << v30));
			//             v31 = qword_18D6405E0[v29 + 36190];
			//           }
			//           while ( v31 != _InterlockedCompareExchange64(&qword_18D6405E0[v29 + 36190], (signed __int64)v26, v31) );
			//           v28 = dword_18D8E43F8;
			//         }
			//         v32 = v53;
			//         if ( !v53 )
			//           sub_1802DC2C8(v26, 0LL);
			//         v53[3].monitor = BlitMaterial;
			//         if ( v28 )
			//         {
			//           v33 = ((unsigned __int64)&v32[3].monitor >> 12) & 0x1FFFFF;
			//           v34 = v33 >> 6;
			//           v35 = v33 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//           do
			//             v36 = qword_18D6405E0[v34 + 36190];
			//           while ( v36 != _InterlockedCompareExchange64(&qword_18D6405E0[v34 + 36190], v36 | (1LL << v35), v36) );
			//         }
			//         v37 = v53;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//         static_fields = (Object__Class **)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor.static_fields;
			//         if ( !v37 )
			//           sub_1802DC2C8(static_fields, v38);
			//         v37[4].klass = *static_fields;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v40 = (((unsigned __int64)&v37[4] >> 12) & 0x1FFFFF) >> 6;
			//           v38 = ((unsigned __int64)&v37[4] >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//           do
			//           {
			//             static_fields = (Object__Class **)(qword_18D6405E0[v40 + 36190] | (1LL << v38));
			//             v41 = qword_18D6405E0[v40 + 36190];
			//           }
			//           while ( v41 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v40 + 36190],
			//                            (signed __int64)static_fields,
			//                            v41) );
			//         }
			//         if ( !v53 )
			//           sub_1802DC2C8(static_fields, v38);
			//         LODWORD(v53[4].monitor) = effectListCount;
			//         v42 = v53;
			//         v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v56, targetRT, 0LL);
			//         if ( !v42 )
			//           sub_1802DC2C8(v44, v43);
			//         v42[1] = (Object)v45;
			//         v46 = v53;
			//         v49 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v56, depthRT, 0LL);
			//         if ( !v46 )
			//           sub_1802DC2C8(v48, v47);
			//         v46[2] = (Object)v49;
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v58,
			//           &v56,
			//           &v10.sceneColor,
			//           0,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v56,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor.static_fields.m_parafinFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v57 )
			//       {
			//         v55.handle = (ResourceHandle)v57.ex;
			//       }
			//       sub_180222690(&v55);
			//       return;
			//     }
			//     v15 = 0LL;
			//     do
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//       s_parafinMaterials = TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor.static_fields.s_parafinMaterials;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//       v18 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields;
			//       runtimeMaterial = v18.runtimeMaterial;
			//       if ( !runtimeMaterial )
			//         sub_180B536AC(v18, v17);
			//       if ( (unsigned int)v14 >= runtimeMaterial.max_length.size )
			//         sub_180070270(v18, v17);
			//       v20 = *(__int64 *)((char *)&runtimeMaterial.klass + v13);
			//       if ( !s_parafinMaterials )
			//         sub_180B536AC(v18, v17);
			//       sub_180036D40(s_parafinMaterials, *(Material__Array__Class **)((char *)&runtimeMaterial.klass + v13));
			//       sub_18000FDA0(s_parafinMaterials, v15, v20);
			//       ++v14;
			//       ++v15;
			//       v13 += 8LL;
			//     }
			//     while ( v14 < effectListCount );
			//     v8 = renderGraph;
			//     v10 = input;
			//     goto LABEL_15;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2770, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v51, v50);
			//   v55 = *targetRT;
			//   si128 = *depthRT;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1014(
			//     Patch,
			//     (Object *)this,
			//     v10,
			//     output,
			//     (Object *)v8,
			//     (Object *)hgCamera,
			//     &si128,
			//     &v55,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ParafinPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2771, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2771, 0LL);
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
			// void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ParafinPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2772, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2772, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ParafinPassConstructor.PassInput input, ref ParafinPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ParafinPassConstructor+PassInput ByRef, ParafinPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::ParafinPassConstructor::ConstructPass(
			//         ParafinPassConstructor *this,
			//         ParafinPassConstructor_PassInput *input,
			//         ParafinPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   TextureHandle sceneDepth; // xmm1
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   TextureHandle sceneColor; // [rsp+40h] [rbp-28h] BYREF
			//   TextureHandle v14; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2773, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2773, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1015(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     sceneDepth = input.sceneDepth;
			//     sceneColor = input.sceneColor;
			//     v14 = sceneDepth;
			//     HG::Rendering::Runtime::ParafinPassConstructor::ParafinPass(
			//       this,
			//       input,
			//       output,
			//       renderGraph,
			//       camera,
			//       &v14,
			//       &sceneColor,
			//       0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ParafinPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2774, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2774, 0LL);
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

		private Material m_parafinMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Material[] s_parafinMaterials;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<ParafinPassConstructor.ParafinData> m_parafinFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal bool enableParafin;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle sceneColor;
		}

		private class ParafinData
		{
			public ParafinData()
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

			public TextureHandle sceneColor;

			public TextureHandle depthRT;

			public Mesh parafinDataMesh;

			public Material blitMaterial;

			public Material[] parafinMaterials;

			public int parafinMaterialCount;
		}
	}
}
