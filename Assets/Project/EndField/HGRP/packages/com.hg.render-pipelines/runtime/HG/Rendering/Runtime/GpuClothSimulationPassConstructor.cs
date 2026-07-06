using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class GpuClothSimulationPassConstructor : IPassConstructor
	{
		internal GpuClothSimulationPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         GpuClothSimulationPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   int v5; // xmm6_4
			//   int v6; // xmm0_4
			//   int v7; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int128 v11; // [rsp+20h] [rbp-28h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2662, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2662, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			//   else
			//   {
			//     v5 = 1065353216;
			//     if ( UnityEngine::HyperGryph::HGGpuClothManagerV2::IsClothSkeletonValid(0LL) )
			//       v6 = 1065353216;
			//     else
			//       v6 = 0;
			//     LODWORD(v11) = v6;
			//     if ( UnityEngine::HyperGryph::HGGpuClothManagerV2::IsClothSkeletonFlipped(0LL) )
			//       v7 = 1065353216;
			//     else
			//       v7 = 0;
			//     DWORD1(v11) = v7;
			//     if ( !UnityEngine::HyperGryph::HGGpuClothManagerV2::ShouldStep(0LL) )
			//       v5 = 0;
			//     *((_QWORD *)&v11 + 1) = __PAIR64__(COERCE_UNSIGNED_INT(UnityEngine::Time::get_time(0LL)), v5);
			//     *(_OWORD *)&shaderVariablesGlobal[1]._WiderFoVViewProjMatrix.m02 = v11;
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         GpuClothSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2663, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2663, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref GpuClothSimulationPassConstructor.PassInput input, ref GpuClothSimulationPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(GpuClothSimulationPassConstructor+PassInput ByRef, GpuClothSimulationPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
			//         GpuClothSimulationPassConstructor *this,
			//         GpuClothSimulationPassConstructor_PassInput *input,
			//         GpuClothSimulationPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v6; // rdi
			//   GpuClothSimulationPassConstructor *v9; // rsi
			//   GpuClothClearBufferDataCPP *ClearBufferData_CSharpWrapper; // rax
			//   int32_t w; // r12d
			//   GpuClothGroupUploadDataCPP *UploadData_CSharpWrapper; // rax
			//   GpuClothRenderDataCPP *RenderData_CSharpWrapper; // rax
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __m128i v17; // xmm0
			//   ProfilingSampler *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   ProfilingSampler *v21; // rax
			//   uint32_t SkeletonBufferID; // esi
			//   ProfilingSampler *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __m128i v29; // [rsp+40h] [rbp-3F8h] BYREF
			//   HGRenderGraphBuilder v30; // [rsp+50h] [rbp-3E8h] BYREF
			//   Object *v31; // [rsp+70h] [rbp-3C8h] BYREF
			//   Object *v32; // [rsp+78h] [rbp-3C0h] BYREF
			//   Object *v33; // [rsp+80h] [rbp-3B8h] BYREF
			//   Object *v34; // [rsp+88h] [rbp-3B0h] BYREF
			//   HGRenderGraphBuilder v35; // [rsp+90h] [rbp-3A8h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+B0h] [rbp-388h] BYREF
			//   GpuClothGroupUploadDataCPP v37; // [rsp+D0h] [rbp-368h] BYREF
			//   __int128 v38; // [rsp+120h] [rbp-318h]
			//   __int128 v39; // [rsp+130h] [rbp-308h]
			//   __int128 v40; // [rsp+140h] [rbp-2F8h]
			//   HGRenderGraphBuilder v41; // [rsp+150h] [rbp-2E8h] BYREF
			//   HGRenderGraphBuilder v42; // [rsp+170h] [rbp-2C8h] BYREF
			//   HGRenderGraphBuilder v43; // [rsp+190h] [rbp-2A8h] BYREF
			//   HGRenderGraphBuilder v44; // [rsp+1B0h] [rbp-288h] BYREF
			//   Il2CppExceptionWrapper *v45; // [rsp+1D0h] [rbp-268h] BYREF
			//   Il2CppExceptionWrapper *v46; // [rsp+1D8h] [rbp-260h] BYREF
			//   Il2CppExceptionWrapper *v47; // [rsp+1E0h] [rbp-258h] BYREF
			//   Il2CppExceptionWrapper *v48; // [rsp+1E8h] [rbp-250h] BYREF
			//   GpuClothGroupUploadDataCPP v49; // [rsp+1F0h] [rbp-248h] BYREF
			//   __int128 v50; // [rsp+240h] [rbp-1F8h]
			//   __int128 v51; // [rsp+250h] [rbp-1E8h]
			//   __int128 v52; // [rsp+260h] [rbp-1D8h]
			//   __int128 v53; // [rsp+270h] [rbp-1C8h]
			//   __int128 v54; // [rsp+280h] [rbp-1B8h]
			//   __int128 v55; // [rsp+290h] [rbp-1A8h]
			//   Vector4 packedDeltaT; // [rsp+2A0h] [rbp-198h]
			//   Vector4 clothParam1; // [rsp+2B0h] [rbp-188h]
			//   __int128 v58; // [rsp+2C0h] [rbp-178h]
			//   __int128 v59; // [rsp+2D0h] [rbp-168h]
			//   __int128 v60; // [rsp+2E0h] [rbp-158h]
			//   __int128 v61; // [rsp+2F0h] [rbp-148h]
			//   __int128 v62; // [rsp+300h] [rbp-138h]
			//   __int128 v63; // [rsp+310h] [rbp-128h]
			//   __int64 v64; // [rsp+320h] [rbp-118h]
			//   _OWORD v65[14]; // [rsp+330h] [rbp-108h] BYREF
			//   __int64 v66; // [rsp+410h] [rbp-28h]
			// 
			//   v6 = renderGraph;
			//   v9 = this;
			//   if ( !byte_18D919565 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4FD518);
			//     sub_18003C530(&off_18D4FD520);
			//     sub_18003C530(&off_18D4FD530);
			//     sub_18003C530(&off_18D4FD540);
			//     byte_18D919565 = 1;
			//   }
			//   memset(&v41, 0, sizeof(v41));
			//   v31 = 0LL;
			//   memset(&v42, 0, sizeof(v42));
			//   v32 = 0LL;
			//   memset(&v43, 0, sizeof(v43));
			//   v33 = 0LL;
			//   v34 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2664, 0LL) )
			//   {
			//     ClearBufferData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClearBufferData_CSharpWrapper(
			//                                       (GpuClothClearBufferDataCPP *)&v35,
			//                                       0LL);
			//     *(_OWORD *)&v36.m_RenderPass = *(_OWORD *)&ClearBufferData_CSharpWrapper.shouldClear;
			//     w = ClearBufferData_CSharpWrapper.eleNum.w;
			//     UploadData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetUploadData_CSharpWrapper(&v49, 0LL);
			//     v29 = *(__m128i *)&UploadData_CSharpWrapper.isValid;
			//     *(__m128i *)&v37.isValid = v29;
			//     v38 = *(_OWORD *)&UploadData_CSharpWrapper.clothMetaUploadDataNum;
			//     *(_OWORD *)&v37.clothMetaUploadDataNum = v38;
			//     v39 = *(_OWORD *)&UploadData_CSharpWrapper.clothNodeUploadDataNum;
			//     *(_OWORD *)&v37.clothNodeUploadDataNum = v39;
			//     v40 = *(_OWORD *)&UploadData_CSharpWrapper.clothBatchMetaUploadDataNum;
			//     *(_OWORD *)&v37.clothBatchMetaUploadDataNum = v40;
			//     *(_OWORD *)&v35.m_RenderPass = *(_OWORD *)&UploadData_CSharpWrapper.clothBatchCacheMapUploadDataNum;
			//     *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum = *(_OWORD *)&v35.m_RenderPass;
			//     RenderData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetRenderData_CSharpWrapper(
			//                                  (GpuClothRenderDataCPP *)v65,
			//                                  0LL);
			//     v50 = *(_OWORD *)&RenderData_CSharpWrapper.isValid;
			//     v51 = *(_OWORD *)&RenderData_CSharpWrapper.clothConstData.packedDeltaT.z;
			//     v52 = *(_OWORD *)&RenderData_CSharpWrapper.clothConstData.clothParam1.z;
			//     v53 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothNum;
			//     v54 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.packedDeltaT.w;
			//     v55 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.clothParam1.w;
			//     packedDeltaT = RenderData_CSharpWrapper[2].clothConstData.packedDeltaT;
			//     clothParam1 = RenderData_CSharpWrapper[2].clothConstData.clothParam1;
			//     RenderData_CSharpWrapper = (GpuClothRenderDataCPP *)((char *)RenderData_CSharpWrapper + 128);
			//     v58 = *(_OWORD *)&RenderData_CSharpWrapper.isValid;
			//     v59 = *(_OWORD *)&RenderData_CSharpWrapper.clothConstData.packedDeltaT.z;
			//     v60 = *(_OWORD *)&RenderData_CSharpWrapper.clothConstData.clothParam1.z;
			//     v61 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothNum;
			//     v62 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.packedDeltaT.w;
			//     v63 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.clothParam1.w;
			//     v64 = *(_QWORD *)&RenderData_CSharpWrapper[2].clothConstData.packedDeltaT.x;
			//     if ( LOBYTE(v36.m_RenderPass) )
			//     {
			//       v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xB3u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         sub_180B536AC(v16, v15);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v30,
			//         v6,
			//         (String *)"GpuClothDataClear",
			//         &v31,
			//         v14,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
			//       v41 = v30;
			//       v30.m_RenderPass = 0LL;
			//       v30.m_Resources = (HGRenderGraphResourceRegistry *)&v41;
			//       try
			//       {
			//         LODWORD(v36.m_RenderGraph) = w;
			//         HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothClearPassData(
			//           v9,
			//           (GpuClothClearBufferDataCPP *)&v36,
			//           (GpuClothSimulationPassConstructor_ClearPassData **)&v31,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v41,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor.static_fields.s_clearFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v45 )
			//       {
			//         v30.m_RenderPass = (HGRenderGraphPass *)v45.ex;
			//         sub_180222690(&v30);
			//         v6 = renderGraph;
			//         v9 = this;
			//         *(_OWORD *)&v35.m_RenderPass = *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum;
			//         v40 = *(_OWORD *)&v37.clothBatchMetaUploadDataNum;
			//         v39 = *(_OWORD *)&v37.clothNodeUploadDataNum;
			//         v38 = *(_OWORD *)&v37.clothMetaUploadDataNum;
			//         v17 = *(__m128i *)&v37.isValid;
			//         v29 = *(__m128i *)&v37.isValid;
			//         goto LABEL_9;
			//       }
			//       sub_180222690(&v30);
			//       v17 = v29;
			//     }
			//     else
			//     {
			//       v17 = v29;
			//     }
			// LABEL_9:
			//     if ( (unsigned __int8)_mm_cvtsi128_si32(v17) )
			//     {
			//       v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xB4u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         goto LABEL_27;
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v36,
			//         v6,
			//         (String *)"GpuClothDataUpload",
			//         &v32,
			//         v18,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
			//       v42 = v36;
			//       v30.m_RenderPass = 0LL;
			//       v30.m_Resources = (HGRenderGraphResourceRegistry *)&v42;
			//       try
			//       {
			//         *(__m128i *)&v37.isValid = v29;
			//         *(_OWORD *)&v37.clothMetaUploadDataNum = v38;
			//         *(_OWORD *)&v37.clothNodeUploadDataNum = v39;
			//         *(_OWORD *)&v37.clothBatchMetaUploadDataNum = v40;
			//         *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum = *(_OWORD *)&v35.m_RenderPass;
			//         HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothUploadPassData(
			//           v9,
			//           &v37,
			//           (GpuClothSimulationPassConstructor_UploadPassData **)&v32,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v42,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor.static_fields.s_uploadFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v46 )
			//       {
			//         v30.m_RenderPass = (HGRenderGraphPass *)v46.ex;
			//         sub_180222690(&v30);
			//         v6 = renderGraph;
			//         v9 = this;
			//         goto LABEL_13;
			//       }
			//       sub_180222690(&v30);
			//     }
			// LABEL_13:
			//     if ( !(_BYTE)v50 )
			//       goto LABEL_17;
			//     v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0xB5u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       goto LABEL_27;
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v35,
			//       v6,
			//       (String *)"GpuClothSim",
			//       &v33,
			//       v21,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//     v43 = v35;
			//     v29.m128i_i64[0] = 0LL;
			//     v29.m128i_i64[1] = (__int64)&v43;
			//     try
			//     {
			//       v65[0] = v50;
			//       v65[1] = v51;
			//       v65[2] = v52;
			//       v65[3] = v53;
			//       v65[4] = v54;
			//       v65[5] = v55;
			//       v65[6] = packedDeltaT;
			//       v65[7] = clothParam1;
			//       v65[8] = v58;
			//       v65[9] = v59;
			//       v65[10] = v60;
			//       v65[11] = v61;
			//       v65[12] = v62;
			//       v65[13] = v63;
			//       v66 = v64;
			//       HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothSimPassData(
			//         v9,
			//         (GpuClothRenderDataCPP *)v65,
			//         (GpuClothSimulationPassConstructor_PassData **)&v33,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v43,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor.static_fields.s_dispatchFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v47 )
			//     {
			//       *(Il2CppExceptionWrapper *)v29.m128i_i8 = (Il2CppExceptionWrapper)v47.ex;
			//       sub_180222690(&v29);
			//       v6 = renderGraph;
			// LABEL_17:
			//       SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
			//       if ( !SkeletonBufferID )
			//         return;
			//       v23 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xB5u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			// LABEL_27:
			//         sub_1802DC2C8(v20, v19);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v35,
			//         v6,
			//         (String *)"GpuClothSetDefault",
			//         &v34,
			//         v23,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//       v44 = v35;
			//       v29.m128i_i64[0] = 0LL;
			//       v29.m128i_i64[1] = (__int64)&v44;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v44, 0, 0LL);
			//         if ( !v34 )
			//           sub_1802DC2C8(v25, v24);
			//         LODWORD(v34[17].klass) = SkeletonBufferID;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v44,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor.static_fields.s_setDefaultFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v48 )
			//       {
			//         *(Il2CppExceptionWrapper *)v29.m128i_i8 = (Il2CppExceptionWrapper)v48.ex;
			//         sub_180222690(&v29);
			//         return;
			//       }
			//     }
			//     sub_180222690(&v29);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2664, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v28, v27);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_978(
			//     Patch,
			//     (Object *)v9,
			//     input,
			//     output,
			//     (Object *)v6,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         GpuClothSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   GpuClothManager *gpuClothManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2668, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       gpuClothManager_k__BackingField = currentManagerContext.fields._gpuClothManager_k__BackingField;
			//       if ( gpuClothManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::GpuClothManager::FlipSkeletonFlag(gpuClothManager_k__BackingField, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(gpuClothManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2668, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         GpuClothSimulationPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2669, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2669, 0LL);
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

		private void _PrepareClothClearPassData(GpuClothClearBufferDataCPP clearData, ref GpuClothSimulationPassConstructor.ClearPassData passData)
		{
			// // Void _PrepareClothClearPassData(GpuClothClearBufferDataCPP, GpuClothSimulationPassConstructor+ClearPassData ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothClearPassData(
			//         GpuClothSimulationPassConstructor *this,
			//         GpuClothClearBufferDataCPP *clearData,
			//         GpuClothSimulationPassConstructor_ClearPassData **passData,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   unsigned __int64 m_clothDataClearHandle; // rcx
			//   __int128 v11; // xmm0
			//   GpuClothSimulationPassConstructor_ClearPassData *v12; // r9
			//   GpuClothSimulationPassConstructor_ClearPassData *v13; // rdi
			//   uint32_t ClothNodeBufferID; // eax
			//   GpuClothSimulationPassConstructor_ClearPassData *v15; // rdi
			//   uint32_t ClothBatchMetaDataBufferID; // eax
			//   GpuClothSimulationPassConstructor_ClearPassData *v17; // rbx
			//   uint32_t ClothBatchCacheMapBufferID; // eax
			//   int32_t w; // eax
			//   String__Array *v20; // [rsp+20h] [rbp-38h]
			//   String *v21; // [rsp+28h] [rbp-30h]
			//   GpuClothClearBufferDataCPP v22; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2665, 0LL) )
			//   {
			//     m_clothDataClearHandle = (unsigned int)this.fields.m_clothDataClearHandle;
			//     if ( *passData )
			//     {
			//       (*passData).fields.clothClearCSHandle = m_clothDataClearHandle;
			//       m_clothDataClearHandle = (unsigned __int64)*passData;
			//       if ( *passData )
			//       {
			//         *(_QWORD *)(m_clothDataClearHandle + 24) = this.fields.m_clothDataUploadCS;
			//         sub_1800054D0(
			//           (OneofDescriptor *)(m_clothDataClearHandle + 24),
			//           v7,
			//           v8,
			//           v9,
			//           v20,
			//           v21,
			//           *(MethodInfo **)&v22.shouldClear);
			//         v11 = *(_OWORD *)&clearData.shouldClear;
			//         v12 = *passData;
			//         v22.eleNum.w = clearData.eleNum.w;
			//         *(_OWORD *)&v22.shouldClear = v11;
			//         if ( v12 )
			//         {
			//           v12.fields.eleNum = v22.eleNum;
			//           v13 = *passData;
			//           ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
			//           if ( v13 )
			//           {
			//             v13.fields.clothNodeDataBufferID = ClothNodeBufferID;
			//             v15 = *passData;
			//             ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
			//             if ( v15 )
			//             {
			//               v15.fields.clothBatchMetaDataBufferID = ClothBatchMetaDataBufferID;
			//               v17 = *passData;
			//               ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
			//               if ( v17 )
			//               {
			//                 v17.fields.clothBatchCacheMapBufferID = ClothBatchCacheMapBufferID;
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_clothDataClearHandle, v7);
			//   }
			//   m_clothDataClearHandle = (unsigned __int64)IFix::WrappersManagerImpl::GetPatch(2665, 0LL);
			//   if ( !m_clothDataClearHandle )
			//     goto LABEL_10;
			//   w = clearData.eleNum.w;
			//   *(_OWORD *)&v22.shouldClear = *(_OWORD *)&clearData.shouldClear;
			//   v22.eleNum.w = w;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_975(
			//     (ILFixDynamicMethodWrapper_2 *)m_clothDataClearHandle,
			//     (Object *)this,
			//     &v22,
			//     passData,
			//     0LL);
			// }
			// 
		}

		private void _PrepareClothUploadPassData(GpuClothGroupUploadDataCPP uploadData, ref GpuClothSimulationPassConstructor.UploadPassData passData)
		{
			// // Void _PrepareClothUploadPassData(GpuClothGroupUploadDataCPP, GpuClothSimulationPassConstructor+UploadPassData ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothUploadPassData(
			//         GpuClothSimulationPassConstructor *this,
			//         GpuClothGroupUploadDataCPP *uploadData,
			//         GpuClothSimulationPassConstructor_UploadPassData **passData,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   __int64 m_clothDataUploadHandle; // rcx
			//   __m128i v11; // xmm2
			//   GpuClothSimulationPassConstructor_UploadPassData *v12; // r9
			//   __int64 v13; // rax
			//   __m128i v14; // xmm2
			//   __m128i v15; // xmm2
			//   __m128i v16; // xmm1
			//   __m128i v17; // xmm0
			//   GpuClothSimulationPassConstructor_UploadPassData *v18; // rbx
			//   uint32_t ClothMetaDataBufferID; // eax
			//   GpuClothSimulationPassConstructor_UploadPassData *v20; // rbx
			//   uint32_t ClothNodeBufferID; // eax
			//   GpuClothSimulationPassConstructor_UploadPassData *v22; // rbx
			//   uint32_t ClothBatchMetaDataBufferID; // eax
			//   GpuClothSimulationPassConstructor_UploadPassData *v24; // rbx
			//   uint32_t ClothBatchCacheMapBufferID; // eax
			//   GpuClothSimulationPassConstructor_UploadPassData *v26; // rbx
			//   uint32_t SkeletonBufferID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   String__Array *v33; // [rsp+28h] [rbp-19h]
			//   String *v34; // [rsp+30h] [rbp-11h]
			//   MethodInfo *v35; // [rsp+38h] [rbp-9h]
			//   IVec4 v36; // [rsp+38h] [rbp-9h]
			//   GpuClothGroupUploadDataCPP v37; // [rsp+48h] [rbp+7h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2666, 0LL) )
			//   {
			//     m_clothDataUploadHandle = (unsigned int)this.fields.m_clothDataUploadHandle;
			//     if ( *passData )
			//     {
			//       (*passData).fields.clothUploadCSHandle = m_clothDataUploadHandle;
			//       m_clothDataUploadHandle = (__int64)*passData;
			//       if ( *passData )
			//       {
			//         *(_QWORD *)(m_clothDataUploadHandle + 24) = this.fields.m_clothDataUploadCS;
			//         sub_1800054D0((OneofDescriptor *)(m_clothDataUploadHandle + 24), v7, v8, v9, v33, v34, v35);
			//         m_clothDataUploadHandle = 1LL;
			//         v11 = *(__m128i *)&uploadData.clothMetaUploadDataNum;
			//         v12 = *passData;
			//         v13 = HIDWORD(*(_QWORD *)&uploadData.isValid);
			//         v36.x = _mm_cvtsi128_si32(v11);
			//         if ( (int)v13 > 1 )
			//           m_clothDataUploadHandle = (unsigned int)v13;
			//         v36.y = m_clothDataUploadHandle;
			//         if ( v12 )
			//         {
			//           *(_QWORD *)&v36.z = (unsigned int)HIDWORD(*(_QWORD *)&uploadData.isValid);
			//           v12.fields.uploadConstData = v36;
			//           m_clothDataUploadHandle = (__int64)*passData;
			//           if ( *passData )
			//           {
			//             *(_DWORD *)(m_clothDataUploadHandle + 48) = _mm_cvtsi128_si32(v11);
			//             m_clothDataUploadHandle = (__int64)*passData;
			//             if ( *passData )
			//             {
			//               v14 = *(__m128i *)&uploadData.isValid;
			//               *(_QWORD *)(m_clothDataUploadHandle + 56) = uploadData.clothMetaUploadData;
			//               m_clothDataUploadHandle = (__int64)*passData;
			//               if ( *passData )
			//               {
			//                 *(_DWORD *)(m_clothDataUploadHandle + 64) = _mm_cvtsi128_si32(_mm_srli_si128(v14, 4));
			//                 m_clothDataUploadHandle = (__int64)*passData;
			//                 if ( *passData )
			//                 {
			//                   *(_QWORD *)(m_clothDataUploadHandle + 72) = _mm_srli_si128(*(__m128i *)&uploadData.isValid, 8).m128i_u64[0];
			//                   m_clothDataUploadHandle = (__int64)*passData;
			//                   v15 = *(__m128i *)&uploadData.clothNodeUploadDataNum;
			//                   if ( *passData )
			//                   {
			//                     *(_DWORD *)(m_clothDataUploadHandle + 80) = _mm_cvtsi128_si32(v15);
			//                     m_clothDataUploadHandle = (__int64)*passData;
			//                     if ( *passData )
			//                     {
			//                       v16 = *(__m128i *)&uploadData.clothBatchMetaUploadDataNum;
			//                       *(_QWORD *)(m_clothDataUploadHandle + 88) = _mm_srli_si128(v15, 8).m128i_u64[0];
			//                       m_clothDataUploadHandle = (__int64)*passData;
			//                       if ( *passData )
			//                       {
			//                         *(_DWORD *)(m_clothDataUploadHandle + 96) = _mm_cvtsi128_si32(v16);
			//                         m_clothDataUploadHandle = (__int64)*passData;
			//                         if ( *passData )
			//                         {
			//                           v17 = *(__m128i *)&uploadData.clothBatchCacheMapUploadDataNum;
			//                           *(_QWORD *)(m_clothDataUploadHandle + 104) = _mm_srli_si128(v16, 8).m128i_u64[0];
			//                           m_clothDataUploadHandle = (__int64)*passData;
			//                           if ( *passData )
			//                           {
			//                             *(_DWORD *)(m_clothDataUploadHandle + 112) = _mm_cvtsi128_si32(v17);
			//                             m_clothDataUploadHandle = (__int64)*passData;
			//                             if ( *passData )
			//                             {
			//                               *(_QWORD *)(m_clothDataUploadHandle + 120) = _mm_srli_si128(v17, 8).m128i_u64[0];
			//                               v18 = *passData;
			//                               ClothMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothMetaDataBufferID(0LL);
			//                               if ( v18 )
			//                               {
			//                                 v18.fields.clothMetaDataBufferID = ClothMetaDataBufferID;
			//                                 v20 = *passData;
			//                                 ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
			//                                 if ( v20 )
			//                                 {
			//                                   v20.fields.clothNodeDataBufferID = ClothNodeBufferID;
			//                                   v22 = *passData;
			//                                   ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
			//                                   if ( v22 )
			//                                   {
			//                                     v22.fields.clothBatchMetaDataBufferID = ClothBatchMetaDataBufferID;
			//                                     v24 = *passData;
			//                                     ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
			//                                     if ( v24 )
			//                                     {
			//                                       v24.fields.clothBatchCacheMapBufferID = ClothBatchCacheMapBufferID;
			//                                       v26 = *passData;
			//                                       SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
			//                                       if ( v26 )
			//                                       {
			//                                         v26.fields.clothSkeletonDataBufferID = SkeletonBufferID;
			//                                         return;
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(m_clothDataUploadHandle, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2666, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   v29 = *(_OWORD *)&uploadData.clothMetaUploadDataNum;
			//   *(_OWORD *)&v37.isValid = *(_OWORD *)&uploadData.isValid;
			//   v30 = *(_OWORD *)&uploadData.clothNodeUploadDataNum;
			//   *(_OWORD *)&v37.clothMetaUploadDataNum = v29;
			//   v31 = *(_OWORD *)&uploadData.clothBatchMetaUploadDataNum;
			//   *(_OWORD *)&v37.clothNodeUploadDataNum = v30;
			//   v32 = *(_OWORD *)&uploadData.clothBatchCacheMapUploadDataNum;
			//   *(_OWORD *)&v37.clothBatchMetaUploadDataNum = v31;
			//   *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum = v32;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_976(Patch, (Object *)this, &v37, passData, 0LL);
			// }
			// 
		}

		private void _PrepareClothSimPassData(GpuClothRenderDataCPP renderData, ref GpuClothSimulationPassConstructor.PassData data)
		{
			// // Void _PrepareClothSimPassData(GpuClothRenderDataCPP, GpuClothSimulationPassConstructor+PassData ByRef)
			// void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothSimPassData(
			//         GpuClothSimulationPassConstructor *this,
			//         GpuClothRenderDataCPP *renderData,
			//         GpuClothSimulationPassConstructor_PassData **data,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v7; // r9
			//   GpuClothSimulationPassConstructor_PassData *v8; // rcx
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   Vector4 packedDeltaT; // xmm0
			//   __int128 v15; // xmm1
			//   GpuClothSimulationPassConstructor_PassData *v16; // rdx
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int64 v22; // rax
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   Vector4 v29; // xmm0
			//   Vector4 clothParam1; // xmm1
			//   ClothConstDataCPP_colliderInfos_e_FixedBuffer *p_colliderInfos; // rbx
			//   __int64 v32; // rax
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   Vector4 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   Vector4 v44; // xmm0
			//   Vector4 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   Vector4 v50; // xmm0
			//   Vector4 v51; // xmm1
			//   GpuClothSimulationPassConstructor_PassData *v52; // rbx
			//   uint32_t ClothNodeBufferID; // eax
			//   GpuClothSimulationPassConstructor_PassData *v54; // rbx
			//   uint32_t ClothMetaDataBufferID; // eax
			//   GpuClothSimulationPassConstructor_PassData *v56; // rbx
			//   uint32_t ClothBatchMetaDataBufferID; // eax
			//   GpuClothSimulationPassConstructor_PassData *v58; // rbx
			//   uint32_t ClothBatchCacheMapBufferID; // eax
			//   GpuClothSimulationPassConstructor_PassData *v60; // rbx
			//   uint32_t SkeletonBufferID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // r10
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm0
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   __int128 v67; // xmm1
			//   Vector4 v68; // xmm0
			//   Vector4 v69; // xmm0
			//   ClothConstDataCPP_colliderInfos_e_FixedBuffer *v70; // rbx
			//   __int64 v71; // rax
			//   __int128 v72; // xmm0
			//   __int128 v73; // xmm1
			//   __int128 v74; // xmm0
			//   __int128 v75; // xmm1
			//   __int128 v76; // xmm0
			//   String__Array *v77; // [rsp+20h] [rbp-108h]
			//   String *v78; // [rsp+28h] [rbp-100h]
			//   _BYTE v79[232]; // [rsp+30h] [rbp-F8h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2667, 0LL) )
			//   {
			//     v8 = *data;
			//     v9 = *(_OWORD *)&renderData.clothConstData.packedDeltaT.z;
			//     *(_OWORD *)v79 = *(_OWORD *)&renderData.isValid;
			//     v10 = *(_OWORD *)&renderData.clothConstData.clothParam1.z;
			//     *(_OWORD *)&v79[16] = v9;
			//     v11 = *(_OWORD *)&renderData[1].clothNum;
			//     *(_OWORD *)&v79[32] = v10;
			//     v12 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
			//     *(_OWORD *)&v79[48] = v11;
			//     v13 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
			//     *(_OWORD *)&v79[64] = v12;
			//     packedDeltaT = renderData[2].clothConstData.packedDeltaT;
			//     *(_OWORD *)&v79[80] = v13;
			//     v15 = *(_OWORD *)&renderData[2].clothConstData.colliderInfos.FixedElementField;
			//     *(Vector4 *)&v79[96] = packedDeltaT;
			//     v16 = (GpuClothSimulationPassConstructor_PassData *)&v79[128];
			//     *(Vector4 *)&v79[112] = renderData[2].clothConstData.clothParam1;
			//     v17 = *(_OWORD *)&renderData[3].clothConstData.packedDeltaT.y;
			//     *(_OWORD *)&v79[128] = v15;
			//     v18 = *(_OWORD *)&renderData[3].clothConstData.clothParam1.y;
			//     *(_OWORD *)&v79[144] = v17;
			//     v19 = *(_OWORD *)&renderData[4].isValid;
			//     *(_OWORD *)&v79[160] = v18;
			//     v20 = *(_OWORD *)&renderData[4].clothConstData.packedDeltaT.z;
			//     *(_OWORD *)&v79[176] = v19;
			//     v21 = *(_OWORD *)&renderData[4].clothConstData.clothParam1.z;
			//     v22 = *(_QWORD *)&renderData[5].clothNum;
			//     *(_OWORD *)&v79[192] = v20;
			//     *(_OWORD *)&v79[208] = v21;
			//     *(_QWORD *)&v79[224] = v22;
			//     if ( v8 )
			//     {
			//       v23 = *(_OWORD *)&renderData.isValid;
			//       v8.fields.clothNum = *(_DWORD *)&v79[4];
			//       v24 = *(_OWORD *)&renderData.clothConstData.packedDeltaT.z;
			//       v16 = *data;
			//       *(_OWORD *)v79 = v23;
			//       v25 = *(_OWORD *)&renderData.clothConstData.clothParam1.z;
			//       *(_OWORD *)&v79[16] = v24;
			//       v26 = *(_OWORD *)&renderData[1].clothNum;
			//       *(_OWORD *)&v79[32] = v25;
			//       v27 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
			//       *(_OWORD *)&v79[48] = v26;
			//       v28 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
			//       *(_OWORD *)&v79[64] = v27;
			//       v29 = renderData[2].clothConstData.packedDeltaT;
			//       *(_OWORD *)&v79[80] = v28;
			//       clothParam1 = renderData[2].clothConstData.clothParam1;
			//       p_colliderInfos = &renderData[2].clothConstData.colliderInfos;
			//       *(Vector4 *)&v79[96] = v29;
			//       v8 = (GpuClothSimulationPassConstructor_PassData *)&v79[128];
			//       v32 = *(_QWORD *)&p_colliderInfos[24].FixedElementField;
			//       v33 = *(_OWORD *)&p_colliderInfos.FixedElementField;
			//       *(Vector4 *)&v79[112] = clothParam1;
			//       v34 = *(_OWORD *)&p_colliderInfos[4].FixedElementField;
			//       *(_OWORD *)&v79[128] = v33;
			//       v35 = *(_OWORD *)&p_colliderInfos[8].FixedElementField;
			//       *(_OWORD *)&v79[144] = v34;
			//       v36 = *(_OWORD *)&p_colliderInfos[12].FixedElementField;
			//       *(_OWORD *)&v79[160] = v35;
			//       v37 = *(_OWORD *)&p_colliderInfos[16].FixedElementField;
			//       *(_OWORD *)&v79[176] = v36;
			//       v38 = *(_OWORD *)&p_colliderInfos[20].FixedElementField;
			//       *(_OWORD *)&v79[192] = v37;
			//       *(_OWORD *)&v79[208] = v38;
			//       *(_QWORD *)&v79[224] = v32;
			//       if ( v16 )
			//       {
			//         v39 = *(Vector4 *)&v79[24];
			//         v16.fields.clothConstData.packedDeltaT = *(Vector4 *)&v79[8];
			//         v40 = *(_OWORD *)&v79[40];
			//         v16.fields.clothConstData.clothParam1 = v39;
			//         v41 = *(_OWORD *)&v79[56];
			//         *(_OWORD *)&v16.fields.clothConstData.colliderInfos.FixedElementField = v40;
			//         v42 = *(_OWORD *)&v79[72];
			//         *(_OWORD *)((char *)&v16.fields.clothSingleDispatchCS + 4) = v41;
			//         v43 = *(_OWORD *)&v79[88];
			//         *(_OWORD *)&v16.fields.clothBatchCacheMapBufferID = v42;
			//         v44 = *(Vector4 *)&v79[104];
			//         *(_OWORD *)((char *)&v16[1].klass + 4) = v43;
			//         v45 = *(Vector4 *)&v79[120];
			//         v16[1].fields.clothConstData.packedDeltaT = v44;
			//         v46 = *(_OWORD *)&v79[136];
			//         v16[1].fields.clothConstData.clothParam1 = v45;
			//         v47 = *(_OWORD *)&v79[152];
			//         *(_OWORD *)&v16[1].fields.clothConstData.colliderInfos.FixedElementField = v46;
			//         v48 = *(_OWORD *)&v79[168];
			//         *(_OWORD *)((char *)&v16[1].fields.clothSingleDispatchCS + 4) = v47;
			//         v49 = *(_OWORD *)&v79[184];
			//         *(_OWORD *)&v16[1].fields.clothBatchCacheMapBufferID = v48;
			//         v50 = *(Vector4 *)&v79[200];
			//         *(_OWORD *)((char *)&v16[2].klass + 4) = v49;
			//         v51 = *(Vector4 *)&v79[216];
			//         v16[2].fields.clothConstData.packedDeltaT = v50;
			//         v16[2].fields.clothConstData.clothParam1 = v51;
			//         v8 = *data;
			//         if ( *data )
			//         {
			//           *(_QWORD *)&v8[2].fields.clothSingleDispatchCSHandle = this.fields.m_clothSingleDispatchCS;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v8[2].fields.clothSingleDispatchCSHandle,
			//             (OneofDescriptorProto *)v16,
			//             (FileDescriptor *)0x80,
			//             v7,
			//             v77,
			//             v78,
			//             *(MethodInfo **)v79);
			//           if ( *data )
			//           {
			//             LODWORD((*data)[2].fields.clothConstData.colliderInfos.FixedElementField) = this.fields.m_clothSingleDispatchHandle;
			//             v52 = *data;
			//             ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
			//             if ( v52 )
			//             {
			//               LODWORD(v52[2].fields.clothSingleDispatchCS) = ClothNodeBufferID;
			//               v54 = *data;
			//               ClothMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothMetaDataBufferID(0LL);
			//               if ( v54 )
			//               {
			//                 HIDWORD(v54[2].fields.clothSingleDispatchCS) = ClothMetaDataBufferID;
			//                 v56 = *data;
			//                 ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
			//                 if ( v56 )
			//                 {
			//                   v56[2].fields.clothNodeDataBufferID = ClothBatchMetaDataBufferID;
			//                   v58 = *data;
			//                   ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
			//                   if ( v58 )
			//                   {
			//                     v58[2].fields.clothMetaDataBufferID = ClothBatchCacheMapBufferID;
			//                     v60 = *data;
			//                     SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
			//                     if ( v60 )
			//                     {
			//                       v60[2].fields.clothBatchMetaDataBufferID = SkeletonBufferID;
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v8, v16);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2667, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   v63 = *(_OWORD *)&renderData.clothConstData.packedDeltaT.z;
			//   *(_OWORD *)v79 = *(_OWORD *)&renderData.isValid;
			//   v64 = *(_OWORD *)&renderData.clothConstData.clothParam1.z;
			//   *(_OWORD *)&v79[16] = v63;
			//   v65 = *(_OWORD *)&renderData[1].clothNum;
			//   *(_OWORD *)&v79[32] = v64;
			//   v66 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
			//   *(_OWORD *)&v79[48] = v65;
			//   v67 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
			//   *(_OWORD *)&v79[64] = v66;
			//   v68 = renderData[2].clothConstData.packedDeltaT;
			//   *(_OWORD *)&v79[80] = v67;
			//   *(Vector4 *)&v79[96] = v68;
			//   v69 = renderData[2].clothConstData.clothParam1;
			//   v70 = &renderData[2].clothConstData.colliderInfos;
			//   *(Vector4 *)&v79[112] = v69;
			//   v71 = *(_QWORD *)&v70[24].FixedElementField;
			//   v72 = *(_OWORD *)&v70[4].FixedElementField;
			//   *(_OWORD *)&v79[128] = *(_OWORD *)&v70.FixedElementField;
			//   v73 = *(_OWORD *)&v70[8].FixedElementField;
			//   *(_OWORD *)&v79[144] = v72;
			//   v74 = *(_OWORD *)&v70[12].FixedElementField;
			//   *(_OWORD *)&v79[160] = v73;
			//   v75 = *(_OWORD *)&v70[16].FixedElementField;
			//   *(_OWORD *)&v79[176] = v74;
			//   v76 = *(_OWORD *)&v70[20].FixedElementField;
			//   *(_OWORD *)&v79[192] = v75;
			//   *(_OWORD *)&v79[208] = v76;
			//   *(_QWORD *)&v79[224] = v71;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_977(Patch, (Object *)this, (GpuClothRenderDataCPP *)v79, data, 0LL);
			// }
			// 
		}

		private unsafe static CBHandle _AllocateConstBuffer<T>(HGRenderGraphContext context, T* ptr, int count, int capacity) where T : struct
		{
			return null;
		}

		private unsafe static ValueTuple<CBHandle, CBHandle> _AllocateClothNodeConstBuffer(HGRenderGraphContext context, ClothNodeDataCPP* ptr, int count)
		{
			// // ValueTuple`2[UnityEngine.Rendering.CBHandle,UnityEngine.Rendering.CBHandle] _AllocateClothNodeConstBuffer(HGRenderGraphContext, ClothNodeDataCPP*, Int32)
			// ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_AllocateClothNodeConstBuffer(
			//         ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *__return_ptr retstr,
			//         HGRenderGraphContext *context,
			//         ClothNodeDataCPP *ptr,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   CBHandle *v9; // rax
			//   __int128 v10; // xmm7
			//   CBHandle *v11; // rax
			//   __int128 v12; // xmm6
			//   int32_t v13; // eax
			//   void *v14; // rsi
			//   ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *result; // rax
			//   Void *destination; // [rsp+30h] [rbp-68h]
			//   CBHandle v17; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919566 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Rendering::CBHandle,UnityEngine::Rendering::CBHandle>::ValueTuple);
			//     byte_18D919566 = 1;
			//   }
			//   if ( !context )
			//     sub_180B536AC(retstr, context);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   v9 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//          &v17,
			//          &context.fields.renderContext,
			//          65280,
			//          0LL);
			//   v10 = *(_OWORD *)&v9.bufferId;
			//   destination = (Void *)v9.ptr;
			//   v11 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//           &v17,
			//           &context.fields.renderContext,
			//           65280,
			//           0LL);
			//   v12 = *(_OWORD *)&v11.bufferId;
			//   v17.ptr = v11.ptr;
			//   if ( count > 0 )
			//   {
			//     v13 = count;
			//     if ( count >= 340 )
			//       v13 = 340;
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, (Void *)ptr, 192 * v13, 0LL);
			//   }
			//   v14 = v17.ptr;
			//   if ( count > 340 )
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//       (Void *)v17.ptr,
			//       (Void *)&ptr[480],
			//       192 * (count - 340),
			//       0LL);
			//   result = retstr;
			//   *(_OWORD *)&retstr.Item1.bufferId = v10;
			//   *(_OWORD *)&retstr.Item2.bufferId = v12;
			//   retstr.Item1.ptr = destination;
			//   retstr.Item2.ptr = v14;
			//   return result;
			// }
			// 
			return null;
		}

		private int m_clothSingleDispatchHandle;

		private int m_clothDataUploadHandle;

		private int m_clothDataClearHandle;

		private ComputeShader m_clothSingleDispatchCS;

		private ComputeShader m_clothDataUploadCS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int CLOTH_CONST_BUFFER_SIZE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static int CLOTH_UPLOAD_CONST_BUFFER_SIZE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<GpuClothSimulationPassConstructor.ClearPassData> s_clearFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<GpuClothSimulationPassConstructor.UploadPassData> s_uploadFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<GpuClothSimulationPassConstructor.PassData> s_dispatchFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<GpuClothSimulationPassConstructor.PassData> s_setDefaultFunc;

		internal struct PassInput
		{
		}

		internal struct PassOutput
		{
		}

		private class ClearPassData
		{
			public ClearPassData()
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

			public int clothClearCSHandle;

			public ComputeShader clearCS;

			public IVec4 eleNum;

			public uint clothNodeDataBufferID;

			public uint clothBatchMetaDataBufferID;

			public uint clothBatchCacheMapBufferID;
		}

		private class UploadPassData
		{
			public UploadPassData()
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

			public int clothUploadCSHandle;

			public ComputeShader clothUploadCS;

			public IVec4 uploadConstData;

			public int clothMetaUploadDataNum;

			public unsafe ClothMetaDataCPP* clothMetaUploadData;

			public int uploadDataMapNum;

			public unsafe ClothGroupUploadDataMapCPP* uploadDataMap;

			public int clothNodeUploadDataNum;

			public unsafe ClothNodeDataCPP* clothNodeUploadData;

			public int clothBatchMetaUploadDataNum;

			public unsafe IVec4* clothBatchMetaUploadData;

			public int clothBatchCacheMapUploadDataNum;

			public unsafe IVec4* clothBatchCacheMapUploadData;

			public uint clothMetaDataBufferID;

			public uint clothNodeDataBufferID;

			public uint clothBatchMetaDataBufferID;

			public uint clothBatchCacheMapBufferID;

			public uint clothSkeletonDataBufferID;
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

			public int clothNum;

			public ClothConstDataCPP clothConstData;

			public int clothSingleDispatchCSHandle;

			public ComputeShader clothSingleDispatchCS;

			public uint clothNodeDataBufferID;

			public uint clothMetaDataBufferID;

			public uint clothBatchMetaDataBufferID;

			public uint clothBatchCacheMapBufferID;

			public uint clothSkeletonDataBufferID;
		}
	}
}
