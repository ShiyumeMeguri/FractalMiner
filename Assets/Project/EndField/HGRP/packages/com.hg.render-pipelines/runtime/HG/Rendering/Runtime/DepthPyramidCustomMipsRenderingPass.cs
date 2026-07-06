using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidCustomMipsRenderingPass
	{
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle depthPyramidTexture
		{
			get
			{
				// // Vector4 get_value()
				// Vector4 *UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::get_value(
				//         Vector4 *__return_ptr retstr,
				//         VolumeParameter_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_Value;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public DepthPyramidCustomMipsRenderingPass(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // DepthPyramidCustomMipsRenderingPass(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(
			//         DepthPyramidCustomMipsRenderingPass *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   __int64 v6; // rcx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   TextureHandle v9; // xmm0
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   _BYTE v12[24]; // [rsp+20h] [rbp-18h] BYREF
			//   String__Array *v13; // [rsp+60h] [rbp+28h]
			//   String *v14; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v15; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA6D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA6D = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, resources);
			//   v9 = *(TextureHandle *)sub_182E7CCD0(v12);
			//   defaultResources = resources.defaultResources;
			//   this.fields.m_depthPyramidTexture = v9;
			//   if ( !defaultResources || (shaders = defaultResources.fields.shaders) == 0LL )
			//     sub_180B536AC(v6, v5);
			//   this.fields.m_computeShader = shaders.fields.depthPyramidCS;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v5, v7, v8, v13, v14, v15);
			// }
			// 
		}

		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthTexture)
		{
			// // Void Render(HGRenderGraph, HGCamera, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::Render(
			//         DepthPyramidCustomMipsRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         TextureHandle *depthTexture,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Object *v12; // rdi
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   TextureHandle v15; // xmm0
			//   Object *v16; // rcx
			//   int v17; // kr08_4
			//   signed __int64 v18; // rcx
			//   Object *v19; // rdx
			//   unsigned int v20; // edx
			//   unsigned __int64 v21; // r8
			//   signed __int64 v22; // rtt
			//   int32_t monitor; // edi
			//   int32_t monitor_high; // ebx
			//   __int128 v25; // xmm2
			//   __int128 v26; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v28; // r8
			//   signed __int64 v29; // rtt
			//   Object *v30; // rbx
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   TextureHandle v33; // xmm0
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
			//   Object *v37; // [rsp+40h] [rbp-1A8h] BYREF
			//   TextureHandle v38; // [rsp+48h] [rbp-1A0h] BYREF
			//   HGRenderGraphBuilder v39; // [rsp+60h] [rbp-188h] BYREF
			//   HGRenderGraphBuilder v40; // [rsp+80h] [rbp-168h] BYREF
			//   __int128 v41; // [rsp+A0h] [rbp-148h] BYREF
			//   __int128 v42; // [rsp+B0h] [rbp-138h]
			//   __int128 v43; // [rsp+C0h] [rbp-128h]
			//   __int128 v44; // [rsp+D0h] [rbp-118h] BYREF
			//   __int128 v45; // [rsp+E0h] [rbp-108h]
			//   Color v46; // [rsp+F0h] [rbp-F8h]
			//   Il2CppExceptionWrapper *v47; // [rsp+100h] [rbp-E8h] BYREF
			//   TextureDesc v48; // [rsp+110h] [rbp-D8h] BYREF
			//   TextureDesc v49; // [rsp+170h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D919536 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4FA050);
			//     sub_18003C530(&off_18D4FA068);
			//     byte_18D919536 = 1;
			//   }
			//   v37 = 0LL;
			//   sub_1802F01E0(&v49, 0LL, 96LL);
			//   sub_1802F01E0(&v41, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2579, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2579, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v35, v34);
			//     *(TextureHandle *)&v39.m_RenderPass = *depthTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_902(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       (TextureHandle *)&v39,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x26u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v11, v10);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v39,
			//       renderGraph,
			//       (String *)"Depth Pyramid",
			//       &v37,
			//       v9,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
			//     v40 = v39;
			//     v39.m_RenderPass = 0LL;
			//     v39.m_Resources = (HGRenderGraphResourceRegistry *)&v40;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v40, 0, 0LL);
			//       v12 = v37;
			//       v15 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v38, &v40, depthTexture, 0LL);
			//       if ( !v12 )
			//         sub_1802DC2C8(v14, v13);
			//       v12[2] = (Object)v15;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v14, v13);
			//       v16 = v37;
			//       if ( !v37 )
			//         sub_1802DC2C8(0LL, v13);
			//       v37[1].klass = (Object__Class *)hgCamera.fields._sceneRTSize_k__BackingField;
			//       if ( !v37 )
			//         sub_1802DC2C8(v16, v13);
			//       v17 = HIDWORD(v37[1].klass) + 1;
			//       v18 = (unsigned int)(v17 / 2);
			//       v38.handle.m_Value = (LODWORD(v37[1].klass) + 1) / 2;
			//       v38.handle._type_k__BackingField = v17 / 2;
			//       v37[1].monitor = (MonitorData *)v38.handle;
			//       v19 = v37;
			//       if ( !v37 )
			//         sub_1802DC2C8(v18, 0LL);
			//       v37[4].klass = (Object__Class *)this.fields.m_computeShader;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v20 = ((unsigned __int64)&v19[4] >> 12) & 0x1FFFFF;
			//         v21 = (unsigned __int64)v20 >> 6;
			//         v19 = (Object *)(v20 & 0x3F);
			//         _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//         do
			//         {
			//           v18 = qword_18D6405E0[v21 + 36190] | (1LL << (char)v19);
			//           v22 = qword_18D6405E0[v21 + 36190];
			//         }
			//         while ( v22 != _InterlockedCompareExchange64(&qword_18D6405E0[v21 + 36190], v18, v22) );
			//       }
			//       if ( !v37 )
			//         sub_1802DC2C8(v18, v19);
			//       monitor = (int32_t)v37[1].monitor;
			//       monitor_high = HIDWORD(v37[1].monitor);
			//       sub_1802F01E0(&v48, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v48, monitor, monitor_high, 0LL);
			//       v25 = *(_OWORD *)&v48.width;
			//       v41 = *(_OWORD *)&v48.width;
			//       v42 = *(_OWORD *)&v48.colorFormat;
			//       v43 = *(_OWORD *)&v48.enableRandomWrite;
			//       *(_QWORD *)&v44 = *(_QWORD *)&v48.bindTextureMS;
			//       v26 = *(_OWORD *)&v48.fastMemoryDesc.inFastMemory;
			//       v45 = *(_OWORD *)&v48.fastMemoryDesc.inFastMemory;
			//       clearColor = v48.clearColor;
			//       v46 = v48.clearColor;
			//       *((_QWORD *)&v44 + 1) = "DepthPyramid";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v28 = ((((unsigned __int64)&v44 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v28 + 36190]);
			//         do
			//           v29 = qword_18D6405E0[v28 + 36190];
			//         while ( v29 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v28 + 36190],
			//                          v29 | (1LL << ((((unsigned __int64)&v44 + 8) >> 12) & 0x3F)),
			//                          v29) );
			//         clearColor = v46;
			//         v26 = v45;
			//         v25 = v41;
			//       }
			//       LODWORD(v42) = 49;
			//       LOWORD(v43) = 257;
			//       BYTE2(v43) = 0;
			//       *(_OWORD *)&v49.width = v25;
			//       *(_OWORD *)&v49.colorFormat = v42;
			//       *(_OWORD *)&v49.enableRandomWrite = v43;
			//       *(_OWORD *)&v49.bindTextureMS = v44;
			//       *(_OWORD *)&v49.fastMemoryDesc.inFastMemory = v26;
			//       v49.clearColor = clearColor;
			//       this.fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v38,
			//                                               renderGraph,
			//                                               &v49,
			//                                               0LL);
			//       v30 = v37;
			//       v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//                &v38,
			//                &v40,
			//                &this.fields.m_depthPyramidTexture,
			//                0LL);
			//       if ( !v30 )
			//         sub_1802DC2C8(v32, v31);
			//       v30[3] = (Object)v33;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v40,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass.static_fields.s_RenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v47 )
			//     {
			//       v39.m_RenderPass = (HGRenderGraphPass *)v47.ex;
			//     }
			//     sub_180222690(&v39);
			//   }
			// }
			// 
		}

		private const int MAX_MIP_COUNT = 7;

		private ComputeShader m_computeShader;

		private TextureHandle m_depthPyramidTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<DepthPyramidCustomMipsRenderingPass.PassData> s_RenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		public struct CBufferData
		{
			public Vector4 prevTextureSize;

			public Vector4 currTextureSize;

			public Vector4 param0;
		}

		private class PassData
		{
			public PassData()
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

			public Vector2Int depthTextureSize;

			public Vector2Int depthPyramidTextureSize;

			public TextureHandle depthTexture;

			public TextureHandle depthPyramidTexture;

			public ComputeShader computeShader;
		}
	}
}
