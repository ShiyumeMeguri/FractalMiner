using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class BinningPass : IPassConstructor
	{
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00002B78 File Offset: 0x00000D78
		public BinningPass.BinningData lightBinningData
		{
			get
			{
				// // Keyframe get_value()
				// Keyframe *ParadoxNotion::EventData<UnityEngine::Keyframe>::get_value(
				//         Keyframe *__return_ptr retstr,
				//         EventData_1_UnityEngine_Keyframe_ *this,
				//         MethodInfo *method)
				// {
				//   float m_OutWeight; // eax
				//   __int64 v4; // xmm1_8
				// 
				//   m_OutWeight = this._value_k__BackingField.m_OutWeight;
				//   v4 = *(_QWORD *)&this._value_k__BackingField.m_WeightedMode;
				//   *(_OWORD *)&retstr.m_Time = *(_OWORD *)&this._value_k__BackingField.m_Time;
				//   *(_QWORD *)&retstr.m_WeightedMode = v4;
				//   retstr.m_OutWeight = m_OutWeight;
				//   return retstr;
				// }
				// 
				return default(BinningPass.BinningData);
			}
		}

		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00002B78 File Offset: 0x00000D78
		public BinningPass.BinningData reflectionProbeBinningData
		{
			get
			{
				// // BinningPass+BinningData get_reflectionProbeBinningData()
				// BinningPass_BinningData *HG::Rendering::Runtime::BinningPass::get_reflectionProbeBinningData(
				//         BinningPass_BinningData *__return_ptr retstr,
				//         BinningPass *this,
				//         MethodInfo *method)
				// {
				//   int32_t uintCount; // eax
				//   __int64 v4; // xmm1_8
				// 
				//   uintCount = this.fields.m_reflectionProbeBinningData.uintCount;
				//   v4 = *(_QWORD *)&this.fields.m_reflectionProbeBinningData.xyOffset;
				//   *(_OWORD *)&retstr.tileSize = *(_OWORD *)&this.fields.m_reflectionProbeBinningData.tileSize;
				//   *(_QWORD *)&retstr.xyOffset = v4;
				//   retstr.uintCount = uintCount;
				//   return retstr;
				// }
				// 
				return default(BinningPass.BinningData);
			}
		}

		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBufferHandle binningBuffer
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector2_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		public BinningPass()
		{
			// // BinningPass()
			// void HG::Rendering::Runtime::BinningPass::BinningPass(BinningPass *this, MethodInfo *method)
			// {
			//   struct ComputeBufferHandle__Class *v3; // rcx
			// 
			//   if ( !byte_18D8EDA55 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     byte_18D8EDA55 = 1;
			//   }
			//   v3 = TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle;
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle, method);
			//   this.fields.m_binningBuffer = (ComputeBufferHandle)sub_182E10C50(v3, method);
			// }
			// 
		}

		public void Prepare(HGRenderGraph renderGraph)
		{
			// // Void Prepare(HGRenderGraph)
			// void HG::Rendering::Runtime::BinningPass::Prepare(BinningPass *this, HGRenderGraph *renderGraph, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v8[20]; // [rsp+20h] [rbp-38h]
			//   ComputeBufferDesc desc; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2500, 0LL) )
			//   {
			//     *(_DWORD *)v8 = this.fields.m_lightBinningData.uintCount + this.fields.m_reflectionProbeBinningData.uintCount;
			//     *(_OWORD *)&v8[4] = 0x1000000004uLL;
			//     desc.name = 0LL;
			//     *(_OWORD *)&desc.count = *(_OWORD *)v8;
			//     if ( renderGraph )
			//     {
			//       this.fields.m_binningBuffer = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                        renderGraph,
			//                                        &desc,
			//                                        0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2500, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     0LL);
			// }
			// 
		}

		public void ConstructPass(HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::BinningPass::ConstructPass(
			//         BinningPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ComputeBufferHandle *v10; // rbx
			//   ComputeBufferHandle v11; // rax
			//   ComputeBufferHandle v12; // rdx
			//   ComputeBufferHandle v13; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ComputeBufferHandle *v17; // [rsp+40h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v18; // [rsp+48h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v19; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v20; // [rsp+70h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919500 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BinningPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BinningPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BinningPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4F5808);
			//     byte_18D919500 = 1;
			//   }
			//   v17 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2501, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2501, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x20u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v19,
			//       renderGraph,
			//       (String *)"Binning Pass",
			//       (Object **)&v17,
			//       v7,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BinningPass::PassData>);
			//     v20 = v19;
			//     v19.m_RenderPass = 0LL;
			//     v19.m_Resources = (HGRenderGraphResourceRegistry *)&v20;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v20, 0, 0LL);
			//       v10 = v17;
			//       v11 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//               &v20,
			//               &this.fields.m_binningBuffer,
			//               0LL);
			//       if ( !v10 )
			//         sub_1802DC2C8(v13, v12);
			//       v10[2] = v11;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::BinningPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v20,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BinningPass.static_fields.s_renderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BinningPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v18 )
			//     {
			//       v19.m_RenderPass = (HGRenderGraphPass *)v18.ex;
			//     }
			//     sub_180222690(&v19);
			//   }
			// }
			// 
		}

		private BinningPass.BinningData GenerateBinningData(Vector2Int rtSize, int tileSize, int sliceZ, int uintCountPerBin, ref int baseOffset)
		{
			// // BinningPass+BinningData GenerateBinningData(Vector2Int, Int32, Int32, Int32, Int32 ByRef)
			// BinningPass_BinningData *HG::Rendering::Runtime::BinningPass::GenerateBinningData(
			//         BinningPass_BinningData *__return_ptr retstr,
			//         BinningPass *this,
			//         Vector2Int rtSize,
			//         int32_t tileSize,
			//         int32_t sliceZ,
			//         int32_t uintCountPerBin,
			//         int32_t *baseOffset,
			//         MethodInfo *method)
			// {
			//   int32_t v10; // edi
			//   int v13; // eax
			//   int32_t v14; // r8d
			//   __int64 v15; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v17; // rcx
			//   BinningPass_BinningData *v18; // rax
			//   __int128 v19; // xmm0
			//   __int64 v20; // xmm1_8
			//   BinningPass_BinningData v22; // [rsp+50h] [rbp-20h] BYREF
			//   int32_t m_Y; // [rsp+A4h] [rbp+34h]
			// 
			//   m_Y = rtSize.m_Y;
			//   v10 = 0;
			//   v22.tileY = 0;
			//   v22.uintCount = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2502, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2502, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, 0LL);
			//     v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_919(
			//             &v22,
			//             Patch,
			//             (Object *)this,
			//             rtSize,
			//             tileSize,
			//             sliceZ,
			//             uintCountPerBin,
			//             baseOffset,
			//             0LL);
			//     v19 = *(_OWORD *)&v18.tileSize;
			//     v20 = *(_QWORD *)&v18.xyOffset;
			//     LODWORD(v18) = v18.uintCount;
			//     *(_OWORD *)&retstr.tileSize = v19;
			//     *(_QWORD *)&retstr.xyOffset = v20;
			//     retstr.uintCount = (int)v18;
			//   }
			//   else
			//   {
			//     v22.tileSize = tileSize;
			//     if ( tileSize <= 0 )
			//     {
			//       v22.tileX = 0;
			//     }
			//     else
			//     {
			//       v22.tileX = (rtSize.m_X + tileSize - 1) / tileSize;
			//       v10 = (tileSize + m_Y - 1) / tileSize;
			//     }
			//     v22.tileY = v10;
			//     v22.xyOffset = *baseOffset;
			//     v22.sliceZ = sliceZ;
			//     v13 = uintCountPerBin * v10 * v22.tileX;
			//     v14 = uintCountPerBin * (sliceZ + v10 * v22.tileX);
			//     *(_OWORD *)&retstr.tileSize = *(_OWORD *)&v22.tileSize;
			//     v22.zOffset = *baseOffset + v13;
			//     v15 = *(_QWORD *)&v22.xyOffset;
			//     *baseOffset += v14;
			//     *(_QWORD *)&retstr.xyOffset = v15;
			//     retstr.uintCount = v14;
			//   }
			//   return retstr;
			// }
			// 
			return default(BinningPass.BinningData);
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         BinningPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   int32_t x; // eax
			//   BinningPass_BinningData *v6; // rax
			//   int32_t uintCount; // ecx
			//   __int64 v8; // xmm0_8
			//   BinningPass_BinningData *v9; // rax
			//   __int64 v10; // xmm0_8
			//   int32_t v11; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Vector2Int v15; // [rsp+40h] [rbp-38h]
			//   __int128 v16; // [rsp+40h] [rbp-38h]
			//   BinningPass_BinningData v17; // [rsp+50h] [rbp-28h] BYREF
			//   int32_t v18; // [rsp+98h] [rbp+20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2503, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2503, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			//   else
			//   {
			//     x = (int)shaderVariablesGlobal._ScreenSize.x;
			//     v18 = 0;
			//     v15.m_X = x;
			//     v15.m_Y = (int)shaderVariablesGlobal._ScreenSize.y;
			//     v6 = HG::Rendering::Runtime::BinningPass::GenerateBinningData(&v17, this, v15, 32, 2048, 8, &v18, 0LL);
			//     uintCount = v6.uintCount;
			//     v8 = *(_QWORD *)&v6.xyOffset;
			//     *(_OWORD *)&this.fields.m_lightBinningData.tileSize = *(_OWORD *)&v6.tileSize;
			//     *(_QWORD *)&this.fields.m_lightBinningData.xyOffset = v8;
			//     this.fields.m_lightBinningData.uintCount = uintCount;
			//     v9 = HG::Rendering::Runtime::BinningPass::GenerateBinningData(&v17, this, v15, 32, 1024, 1, &v18, 0LL);
			//     v10 = *(_QWORD *)&v9.xyOffset;
			//     v11 = v9.uintCount;
			//     *(_OWORD *)&this.fields.m_reflectionProbeBinningData.tileSize = *(_OWORD *)&v9.tileSize;
			//     *(_QWORD *)&this.fields.m_reflectionProbeBinningData.xyOffset = v10;
			//     this.fields.m_reflectionProbeBinningData.uintCount = v11;
			//     *(_QWORD *)&v16 = *(_QWORD *)&this.fields.m_lightBinningData.xyOffset;
			//     *((_QWORD *)&v16 + 1) = *(_QWORD *)&this.fields.m_reflectionProbeBinningData.xyOffset;
			//     *(_OWORD *)&shaderVariablesGlobal._WindMotorParams2.FixedElementField = v16;
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         BinningPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2504, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2504, 0LL);
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
			// void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         BinningPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2505, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2505, 0LL);
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
			// void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         BinningPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2506, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2506, 0LL);
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

		private BinningPass.BinningData m_lightBinningData;

		private BinningPass.BinningData m_reflectionProbeBinningData;

		private ComputeBufferHandle m_binningBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static RenderFunc<BinningPass.PassData> s_renderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
		public struct BinningData
		{
			public int tileSize;

			public int tileX;

			public int tileY;

			public int sliceZ;

			public int xyOffset;

			public int zOffset;

			public int uintCount;
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

			public ComputeBufferHandle binningBuffer;
		}
	}
}
