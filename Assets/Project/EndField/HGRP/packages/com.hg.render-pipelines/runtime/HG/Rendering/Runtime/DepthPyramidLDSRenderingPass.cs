using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidLDSRenderingPass
	{
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x000025D2 File Offset: 0x000007D2
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

		public DepthPyramidLDSRenderingPass(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // DepthPyramidLDSRenderingPass(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::DepthPyramidLDSRenderingPass(
			//         DepthPyramidLDSRenderingPass *this,
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
			//   if ( !byte_18D8EDA6C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA6C = 1;
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

		public void Render(HGRenderGraph renderGraph, TextureHandle depthTexture, Vector2Int depthTextureSize)
		{
			// // Void Render(HGRenderGraph, TextureHandle, Vector2Int)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::Render(
			//         DepthPyramidLDSRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *depthTexture,
			//         Vector2Int depthTextureSize,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Object *v12; // rdi
			//   char v13; // dl
			//   __int64 v14; // rcx
			//   int v15; // r8d
			//   int v16; // eax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Object *v19; // rdi
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   TextureHandle v22; // xmm0
			//   __int64 v23; // rdx
			//   Object *v24; // rcx
			//   int32_t monitor_high; // edi
			//   int32_t klass; // ebx
			//   __int128 v27; // xmm2
			//   __int128 v28; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v30; // r8
			//   signed __int64 v31; // rtt
			//   Object *v32; // rbx
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   TextureHandle v35; // xmm0
			//   Object *v36; // rbx
			//   ComputeBufferHandle v37; // rax
			//   ComputeBufferHandle v38; // rdx
			//   ComputeBufferHandle v39; // rcx
			//   Object *v40; // rdx
			//   unsigned __int64 v41; // rdx
			//   unsigned __int64 v42; // r8
			//   char v43; // dl
			//   signed __int64 v44; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *_9__6_0; // rdi
			//   Object *v46; // r14
			//   struct RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData___Class *element_class; // rbx
			//   __int64 v48; // rdx
			//   __int64 instance_size; // rcx
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   unsigned __int64 v52; // r8
			//   char v53; // dl
			//   signed __int64 v54; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   Object *v58; // [rsp+40h] [rbp-1C8h] BYREF
			//   MonitorData *v59; // [rsp+48h] [rbp-1C0h] BYREF
			//   ComputeBufferDesc desc; // [rsp+50h] [rbp-1B8h] BYREF
			//   HGRenderGraphBuilder v61; // [rsp+70h] [rbp-198h] BYREF
			//   HGRenderGraphBuilder v62; // [rsp+90h] [rbp-178h] BYREF
			//   __int128 v63; // [rsp+B0h] [rbp-158h] BYREF
			//   __int128 v64; // [rsp+C0h] [rbp-148h]
			//   __int128 v65; // [rsp+D0h] [rbp-138h]
			//   __int128 v66; // [rsp+E0h] [rbp-128h] BYREF
			//   __int128 v67; // [rsp+F0h] [rbp-118h]
			//   Color v68; // [rsp+100h] [rbp-108h]
			//   Il2CppExceptionWrapper *v69; // [rsp+110h] [rbp-F8h] BYREF
			//   TextureDesc v70; // [rsp+120h] [rbp-E8h] BYREF
			//   TextureDesc v71; // [rsp+180h] [rbp-88h] BYREF
			//   int32_t m_Y; // [rsp+22Ch] [rbp+24h]
			// 
			//   m_Y = depthTextureSize.m_Y;
			//   if ( !byte_18D919533 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c::_Render_b__6_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c);
			//     sub_18003C530(&off_18D4FA050);
			//     sub_18003C530(&off_18D4FA068);
			//     byte_18D919533 = 1;
			//   }
			//   v58 = 0LL;
			//   sub_1802F01E0(&v71, 0LL, 96LL);
			//   sub_1802F01E0(&v63, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2575, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2575, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v57, v56);
			//     *(TextureHandle *)&v61.m_RenderPass = *depthTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_943(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (TextureHandle *)&v61,
			//       depthTextureSize,
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
			//       &v61,
			//       renderGraph,
			//       (String *)"Depth Pyramid",
			//       &v58,
			//       v9,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
			//     v62 = v61;
			//     v61.m_RenderPass = 0LL;
			//     v61.m_Resources = (HGRenderGraphResourceRegistry *)&v62;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v62, 0, 0LL);
			//       v12 = v58;
			//       sub_182376F20();
			//       v16 = sub_182592070(v14, v13, v15);
			//       if ( !v12 )
			//         sub_1802DC2C8(v18, v17);
			//       LODWORD(v12[1].klass) = v16;
			//       v19 = v58;
			//       v22 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&desc,
			//                &v62,
			//                depthTexture,
			//                0LL);
			//       if ( !v19 )
			//         sub_1802DC2C8(v21, v20);
			//       *(TextureHandle *)((char *)&v19[2] + 4) = v22;
			//       if ( !v58 )
			//         sub_1802DC2C8(v21, v20);
			//       *(Vector2Int *)((char *)&v58[1].klass + 4) = depthTextureSize;
			//       v23 = (unsigned int)((depthTextureSize.m_X + 1) >> 31);
			//       LODWORD(v59) = (depthTextureSize.m_X + 1) / 2 + (depthTextureSize.m_X + 3) / 4;
			//       HIDWORD(v59) = (m_Y + 1) / 2;
			//       v24 = v58;
			//       if ( !v58 )
			//         sub_1802DC2C8(0LL, v23);
			//       *(MonitorData **)((char *)&v58[1].monitor + 4) = v59;
			//       if ( !v58 )
			//         sub_1802DC2C8(v24, v23);
			//       monitor_high = HIDWORD(v58[1].monitor);
			//       klass = (int32_t)v58[2].klass;
			//       sub_1802F01E0(&v70, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v70, monitor_high, klass, 0LL);
			//       v27 = *(_OWORD *)&v70.width;
			//       v63 = *(_OWORD *)&v70.width;
			//       v64 = *(_OWORD *)&v70.colorFormat;
			//       v65 = *(_OWORD *)&v70.enableRandomWrite;
			//       *(_QWORD *)&v66 = *(_QWORD *)&v70.bindTextureMS;
			//       v28 = *(_OWORD *)&v70.fastMemoryDesc.inFastMemory;
			//       v67 = *(_OWORD *)&v70.fastMemoryDesc.inFastMemory;
			//       clearColor = v70.clearColor;
			//       v68 = v70.clearColor;
			//       *((_QWORD *)&v66 + 1) = "DepthPyramid";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v30 = ((((unsigned __int64)&v66 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v30 + 36190]);
			//         do
			//           v31 = qword_18D6405E0[v30 + 36190];
			//         while ( v31 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v30 + 36190],
			//                          v31 | (1LL << ((((unsigned __int64)&v66 + 8) >> 12) & 0x3F)),
			//                          v31) );
			//         clearColor = v68;
			//         v28 = v67;
			//         v27 = v63;
			//       }
			//       LODWORD(v64) = 21;
			//       LOWORD(v65) = 1;
			//       BYTE2(v65) = 0;
			//       *(_OWORD *)&v71.width = v27;
			//       *(_OWORD *)&v71.colorFormat = v64;
			//       *(_OWORD *)&v71.enableRandomWrite = v65;
			//       *(_OWORD *)&v71.bindTextureMS = v66;
			//       *(_OWORD *)&v71.fastMemoryDesc.inFastMemory = v28;
			//       v71.clearColor = clearColor;
			//       this.fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               (TextureHandle *)&desc,
			//                                               renderGraph,
			//                                               &v71,
			//                                               0LL);
			//       v32 = v58;
			//       v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//                (TextureHandle *)&desc,
			//                &v62,
			//                &this.fields.m_depthPyramidTexture,
			//                0LL);
			//       if ( !v32 )
			//         sub_1802DC2C8(v34, v33);
			//       *(TextureHandle *)((char *)&v32[3] + 4) = v35;
			//       *(_QWORD *)(&desc.type + 1) = 0LL;
			//       HIDWORD(desc.name) = 0;
			//       desc.count = 1;
			//       desc.stride = 4;
			//       desc.type = 1;
			//       v36 = v58;
			//       v37 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(&v62, &desc, 0LL);
			//       if ( !v36 )
			//         sub_1802DC2C8(v39, v38);
			//       *(ComputeBufferHandle *)((char *)&v36[4].klass + 4) = v37;
			//       v40 = v58;
			//       if ( !v58 )
			//         sub_1802DC2C8(v39, 0LL);
			//       v58[5].klass = (Object__Class *)this.fields.m_computeShader;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v41 = ((unsigned __int64)&v40[5] >> 12) & 0x1FFFFF;
			//         v42 = v41 >> 6;
			//         v43 = v41 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v42 + 36190]);
			//         do
			//           v44 = qword_18D6405E0[v42 + 36190];
			//         while ( v44 != _InterlockedCompareExchange64(&qword_18D6405E0[v42 + 36190], v44 | (1LL << v43), v44) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c);
			//       _9__6_0 = TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c.static_fields.__9__6_0;
			//       if ( !_9__6_0 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c);
			//         v46 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c.static_fields.__9;
			//         element_class = TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>;
			//         if ( ((__int64)TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>.vtable.Equals.methodPtr & 2) == 0 )
			//         {
			//           v59 = (MonitorData *)&qword_18CDB0B30;
			//           sub_1802924D0(&qword_18CDB0B30);
			//           sub_180060090(element_class, &v59);
			//           sub_180292530(v59);
			//         }
			//         if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//           element_class = (struct RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData___Class *)element_class._0.element_class;
			//         if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//         {
			//           instance_size = element_class._1.instance_size;
			//           if ( element_class._0.gc_desc )
			//           {
			//             _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *)sub_180005220(
			//                                                                                                     instance_size,
			//                                                                                                     element_class);
			//             _InterlockedIncrement64(&qword_18D8E51F8);
			//           }
			//           else
			//           {
			//             _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *)sub_180005D40(
			//                                                                                                     instance_size,
			//                                                                                                     element_class);
			//           }
			//         }
			//         else
			//         {
			//           _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *)sub_180005FB0(element_class);
			//         }
			//         if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//           sub_18002E8C0((_DWORD)_9__6_0, (unsigned int)sub_18007DC30, 0, (unsigned int)&desc, (__int64)&v59);
			//         if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//           sub_1802DAEC4(_9__6_0, element_class);
			//         il2cpp_runtime_class_init_0(element_class, v48);
			//         if ( !_9__6_0 )
			//           sub_1802DC2C8(v51, v50);
			//         HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//           (RenderFunc_1_System_Object_ *)_9__6_0,
			//           v46,
			//           MethodInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c::_Render_b__6_0,
			//           0LL);
			//         TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c.static_fields.__9__6_0 = _9__6_0;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v52 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c.static_fields.__9__6_0 >> 12) & 0x1FFFFF) >> 6;
			//           v53 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c.static_fields.__9__6_0 >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v52 + 36190]);
			//           do
			//             v54 = qword_18D6405E0[v52 + 36190];
			//           while ( v54 != _InterlockedCompareExchange64(&qword_18D6405E0[v52 + 36190], v54 | (1LL << v53), v54) );
			//         }
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v62,
			//         (RenderFunc_1_System_Object_ *)_9__6_0,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v69 )
			//     {
			//       v61.m_RenderPass = (HGRenderGraphPass *)v69.ex;
			//     }
			//     sub_180222690(&v61);
			//   }
			// }
			// 
		}

		private ComputeShader m_computeShader;

		private TextureHandle m_depthPyramidTexture;

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

			public int maxMip;

			public Vector2Int depthTextureSize;

			public Vector2Int depthPyramidTextureSize;

			public TextureHandle depthTexture;

			public TextureHandle depthPyramidTexture;

			public ComputeBufferHandle globalAtomicBuffer;

			public ComputeShader computeShader;
		}
	}
}
