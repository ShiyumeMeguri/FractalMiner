using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidNoLDSRenderingPass
	{
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000025D2 File Offset: 0x000007D2
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

		public DepthPyramidNoLDSRenderingPass(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // DepthPyramidNoLDSRenderingPass(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::DepthPyramidNoLDSRenderingPass(
			//         DepthPyramidNoLDSRenderingPass *this,
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
			//   if ( !byte_18D8EDA6B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA6B = 1;
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
			// void HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::Render(
			//         DepthPyramidNoLDSRenderingPass *this,
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
			//   Object *v36; // rdx
			//   unsigned __int64 v37; // rdx
			//   unsigned __int64 v38; // r8
			//   char v39; // dl
			//   signed __int64 v40; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *_9__6_0; // rdi
			//   Object *v42; // r14
			//   struct RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData___Class *element_class; // rbx
			//   __int64 v44; // rdx
			//   __int64 instance_size; // rcx
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   unsigned __int64 v48; // r8
			//   char v49; // dl
			//   signed __int64 v50; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   Object *v54; // [rsp+40h] [rbp-1B8h] BYREF
			//   MonitorData *v55; // [rsp+48h] [rbp-1B0h] BYREF
			//   TextureHandle v56; // [rsp+50h] [rbp-1A8h] BYREF
			//   HGRenderGraphBuilder v57; // [rsp+60h] [rbp-198h] BYREF
			//   HGRenderGraphBuilder v58; // [rsp+80h] [rbp-178h] BYREF
			//   __int128 v59; // [rsp+A0h] [rbp-158h] BYREF
			//   __int128 v60; // [rsp+B0h] [rbp-148h]
			//   __int128 v61; // [rsp+C0h] [rbp-138h]
			//   __int128 v62; // [rsp+D0h] [rbp-128h] BYREF
			//   __int128 v63; // [rsp+E0h] [rbp-118h]
			//   Color v64; // [rsp+F0h] [rbp-108h]
			//   Il2CppExceptionWrapper *v65; // [rsp+100h] [rbp-F8h] BYREF
			//   TextureDesc v66; // [rsp+110h] [rbp-E8h] BYREF
			//   TextureDesc v67; // [rsp+170h] [rbp-88h] BYREF
			//   int32_t m_Y; // [rsp+21Ch] [rbp+24h]
			// 
			//   m_Y = depthTextureSize.m_Y;
			//   if ( !byte_18D919530 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c::_Render_b__6_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c);
			//     sub_18003C530(&off_18D4FA050);
			//     sub_18003C530(&off_18D4FA068);
			//     byte_18D919530 = 1;
			//   }
			//   v54 = 0LL;
			//   sub_1802F01E0(&v67, 0LL, 96LL);
			//   sub_1802F01E0(&v59, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2571, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2571, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v53, v52);
			//     *(TextureHandle *)&v57.m_RenderPass = *depthTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_943(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (TextureHandle *)&v57,
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
			//       &v57,
			//       renderGraph,
			//       (String *)"Depth Pyramid",
			//       &v54,
			//       v9,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
			//     v58 = v57;
			//     v57.m_RenderPass = 0LL;
			//     v57.m_Resources = (HGRenderGraphResourceRegistry *)&v58;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v58, 0, 0LL);
			//       v12 = v54;
			//       sub_182376F20();
			//       v16 = sub_182592070(v14, v13, v15);
			//       if ( !v12 )
			//         sub_1802DC2C8(v18, v17);
			//       LODWORD(v12[1].klass) = v16;
			//       v19 = v54;
			//       v22 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v56, &v58, depthTexture, 0LL);
			//       if ( !v19 )
			//         sub_1802DC2C8(v21, v20);
			//       *(TextureHandle *)((char *)&v19[2] + 4) = v22;
			//       if ( !v54 )
			//         sub_1802DC2C8(v21, v20);
			//       *(Vector2Int *)((char *)&v54[1].klass + 4) = depthTextureSize;
			//       v23 = (unsigned int)((depthTextureSize.m_X + 1) >> 31);
			//       LODWORD(v55) = (depthTextureSize.m_X + 1) / 2 + (depthTextureSize.m_X + 3) / 4;
			//       HIDWORD(v55) = (m_Y + 1) / 2;
			//       v24 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, v23);
			//       *(MonitorData **)((char *)&v54[1].monitor + 4) = v55;
			//       if ( !v54 )
			//         sub_1802DC2C8(v24, v23);
			//       monitor_high = HIDWORD(v54[1].monitor);
			//       klass = (int32_t)v54[2].klass;
			//       sub_1802F01E0(&v66, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v66, monitor_high, klass, 0LL);
			//       v27 = *(_OWORD *)&v66.width;
			//       v59 = *(_OWORD *)&v66.width;
			//       v60 = *(_OWORD *)&v66.colorFormat;
			//       v61 = *(_OWORD *)&v66.enableRandomWrite;
			//       *(_QWORD *)&v62 = *(_QWORD *)&v66.bindTextureMS;
			//       v28 = *(_OWORD *)&v66.fastMemoryDesc.inFastMemory;
			//       v63 = *(_OWORD *)&v66.fastMemoryDesc.inFastMemory;
			//       clearColor = v66.clearColor;
			//       v64 = v66.clearColor;
			//       *((_QWORD *)&v62 + 1) = "DepthPyramid";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v30 = ((((unsigned __int64)&v62 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v30 + 36190]);
			//         do
			//           v31 = qword_18D6405E0[v30 + 36190];
			//         while ( v31 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v30 + 36190],
			//                          v31 | (1LL << ((((unsigned __int64)&v62 + 8) >> 12) & 0x3F)),
			//                          v31) );
			//         clearColor = v64;
			//         v28 = v63;
			//         v27 = v59;
			//       }
			//       LODWORD(v60) = 21;
			//       LOWORD(v61) = 1;
			//       BYTE2(v61) = 0;
			//       *(_OWORD *)&v67.width = v27;
			//       *(_OWORD *)&v67.colorFormat = v60;
			//       *(_OWORD *)&v67.enableRandomWrite = v61;
			//       *(_OWORD *)&v67.bindTextureMS = v62;
			//       *(_OWORD *)&v67.fastMemoryDesc.inFastMemory = v28;
			//       v67.clearColor = clearColor;
			//       this.fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v56,
			//                                               renderGraph,
			//                                               &v67,
			//                                               0LL);
			//       v32 = v54;
			//       v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//                &v56,
			//                &v58,
			//                &this.fields.m_depthPyramidTexture,
			//                0LL);
			//       if ( !v32 )
			//         sub_1802DC2C8(v34, v33);
			//       *(TextureHandle *)((char *)&v32[3] + 4) = v35;
			//       v36 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(v34, 0LL);
			//       v54[4].monitor = (MonitorData *)this.fields.m_computeShader;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v37 = ((unsigned __int64)&v36[4].monitor >> 12) & 0x1FFFFF;
			//         v38 = v37 >> 6;
			//         v39 = v37 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v38 + 36190]);
			//         do
			//           v40 = qword_18D6405E0[v38 + 36190];
			//         while ( v40 != _InterlockedCompareExchange64(&qword_18D6405E0[v38 + 36190], v40 | (1LL << v39), v40) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c);
			//       _9__6_0 = TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c.static_fields.__9__6_0;
			//       if ( !_9__6_0 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c);
			//         v42 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c.static_fields.__9;
			//         element_class = TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>;
			//         if ( ((__int64)TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>.vtable.Equals.methodPtr & 2) == 0 )
			//         {
			//           v55 = (MonitorData *)&qword_18CDB0B30;
			//           sub_1802924D0(&qword_18CDB0B30);
			//           sub_180060090(element_class, &v55);
			//           sub_180292530(v55);
			//         }
			//         if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//           element_class = (struct RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData___Class *)element_class._0.element_class;
			//         if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//         {
			//           instance_size = element_class._1.instance_size;
			//           if ( element_class._0.gc_desc )
			//           {
			//             _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *)sub_180005220(instance_size, element_class);
			//             _InterlockedIncrement64(&qword_18D8E51F8);
			//           }
			//           else
			//           {
			//             _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *)sub_180005D40(instance_size, element_class);
			//           }
			//         }
			//         else
			//         {
			//           _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *)sub_180005FB0(element_class);
			//         }
			//         if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//           sub_18002E8C0((_DWORD)_9__6_0, (unsigned int)sub_18007DC30, 0, (unsigned int)&v56, (__int64)&v55);
			//         if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//           sub_1802DAEC4(_9__6_0, element_class);
			//         il2cpp_runtime_class_init_0(element_class, v44);
			//         if ( !_9__6_0 )
			//           sub_1802DC2C8(v47, v46);
			//         HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//           (RenderFunc_1_System_Object_ *)_9__6_0,
			//           v42,
			//           MethodInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c::_Render_b__6_0,
			//           0LL);
			//         TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c.static_fields.__9__6_0 = _9__6_0;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v48 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c.static_fields.__9__6_0 >> 12) & 0x1FFFFF) >> 6;
			//           v49 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c.static_fields.__9__6_0 >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//           do
			//             v50 = qword_18D6405E0[v48 + 36190];
			//           while ( v50 != _InterlockedCompareExchange64(&qword_18D6405E0[v48 + 36190], v50 | (1LL << v49), v50) );
			//         }
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v58,
			//         (RenderFunc_1_System_Object_ *)_9__6_0,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v65 )
			//     {
			//       v57.m_RenderPass = (HGRenderGraphPass *)v65.ex;
			//     }
			//     sub_180222690(&v57);
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

			public ComputeShader computeShader;
		}
	}
}
