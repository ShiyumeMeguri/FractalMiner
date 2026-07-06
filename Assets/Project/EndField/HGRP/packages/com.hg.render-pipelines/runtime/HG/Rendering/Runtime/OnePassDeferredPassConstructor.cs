using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class OnePassDeferredPassConstructor : IPassConstructor
	{
		internal OnePassDeferredPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private ValueTuple<int, int> SetupRenderTarget(ref OnePassDeferredPassConstructor.PassInput input, HGRenderGraphBuilder builder, [MetadataOffset(Offset = "0x01F9184F")] bool mvClearColor = false)
		{
			// // ValueTuple`2[Int32,Int32] SetupRenderTarget(OnePassDeferredPassConstructor+PassInput ByRef, HGRenderGraphBuilder, Boolean)
			// ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         HGRenderGraphBuilder *builder,
			//         bool mvClearColor,
			//         MethodInfo *method)
			// {
			//   unsigned int v5; // r12d
			//   int32_t v10; // r14d
			//   int v11; // r15d
			//   int32_t v12; // r8d
			//   TextureHandle *p_sceneMV; // r8
			//   int32_t v14; // esi
			//   GBufferOutput *p_gBufferOutput; // rdi
			//   int32_t v16; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int128 v21; // xmm1
			//   TextureHandle si128; // [rsp+40h] [rbp-40h] BYREF
			//   TextureHandle v23; // [rsp+50h] [rbp-30h] BYREF
			//   HGRenderGraphBuilder v24; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   v5 = 0;
			//   v10 = 1;
			//   if ( !byte_18D919594 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     byte_18D919594 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2733, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2733, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     v21 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v24.m_RenderGraph = v21;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1000(Patch, (Object *)this, input, &v24, mvClearColor, 0LL);
			//   }
			//   else
			//   {
			//     v11 = 1;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//       &si128,
			//       builder,
			//       &input.sceneColor,
			//       0,
			//       0,
			//       0LL);
			//     HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//       this,
			//       OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//       0,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//     {
			//       p_sceneMV = &input.sceneMV;
			//       if ( mvClearColor )
			//       {
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v23,
			//           builder,
			//           p_sceneMV,
			//           1,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//       }
			//       else
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &si128,
			//           builder,
			//           p_sceneMV,
			//           1,
			//           0,
			//           0LL);
			//       }
			//       v11 = 2;
			//       v10 = 2;
			//       v12 = 1;
			//     }
			//     else
			//     {
			//       v12 = -1;
			//     }
			//     HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//       this,
			//       OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//       v12,
			//       0LL);
			//     v14 = 0;
			//     p_gBufferOutput = &input.gBufferOutput;
			//     do
			//     {
			//       si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v23, p_gBufferOutput, v14, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v24,
			//           builder,
			//           &si128,
			//           v10,
			//           0,
			//           0LL);
			//         v16 = v10++;
			//         ++v5;
			//       }
			//       else
			//       {
			//         v16 = -1;
			//       }
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(this, (GBufferID__Enum)v14++, v16, 0LL);
			//     }
			//     while ( v14 < 4 );
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//       (TextureHandle *)&v24,
			//       builder,
			//       &input.sceneDepth,
			//       DepthAccess__Enum_ReadWrite,
			//       0,
			//       0LL);
			//     si128.handle = (ResourceHandle)__PAIR64__(v5, v11);
			//     return (ValueTuple_2_Int32_Int32_)__PAIR64__(v5, v11);
			//   }
			// }
			// 
			return null;
		}

		private void SetupSubpass(OnePassDeferredPassConstructor.OnePassDeferredSubpass subpass, int fixedAttachmentCount, int gBufferAttachmentCount, out NativeArray<int> outputIndices, out NativeArray<int> inputIndices, out bool depthAsInput, [MetadataOffset(Offset = "0x01F91850")] bool shouldSplitOnePass = false)
		{
			// // Void SetupSubpass(OnePassDeferredPassConstructor+OnePassDeferredSubpass, Int32, Int32, NativeArray`1[System.Int32] ByRef, NativeArray`1[System.Int32] ByRef, Boolean ByRef, Boolean)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum subpass,
			//         int32_t fixedAttachmentCount,
			//         int32_t gBufferAttachmentCount,
			//         NativeArray_1_System_Int32_ *outputIndices,
			//         NativeArray_1_System_Int32_ *inputIndices,
			//         bool *depthAsInput,
			//         bool shouldSplitOnePass,
			//         MethodInfo *method)
			// {
			//   GBufferID__Enum v9; // edi
			//   unsigned __int32 v14; // ebx
			//   unsigned __int32 v15; // ebx
			//   unsigned __int32 v16; // ebx
			//   unsigned __int32 v17; // ebx
			//   unsigned __int32 v18; // ebx
			//   int32_t v19; // eax
			//   __int64 v20; // rbx
			//   int32_t v21; // eax
			//   __int64 v22; // rdx
			//   int32_t v23; // eax
			//   __int64 v24; // rbx
			//   int32_t AttachmentIndex; // eax
			//   __int64 v26; // rdx
			//   int32_t v27; // r13d
			//   int32_t v28; // edx
			//   int32_t v29; // eax
			//   __int64 v30; // rbx
			//   int32_t v31; // eax
			//   __int64 v32; // rdx
			//   int32_t v33; // eax
			//   __int64 v34; // rbx
			//   int32_t v35; // eax
			//   __int64 v36; // rdx
			//   __int64 v37; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   NativeArray_1_System_Int32_ v39; // [rsp+50h] [rbp-10h] BYREF
			// 
			//   v9 = GBufferID__Enum_GBufferA;
			//   if ( !byte_18D919595 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     byte_18D919595 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2736, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2736, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v37);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1003(
			//       Patch,
			//       (Object *)this,
			//       subpass,
			//       fixedAttachmentCount,
			//       gBufferAttachmentCount,
			//       outputIndices,
			//       inputIndices,
			//       depthAsInput,
			//       shouldSplitOnePass,
			//       0LL);
			//   }
			//   else
			//   {
			//     *depthAsInput = 0;
			//     if ( subpass == OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_PreDepth )
			//     {
			//       v39 = 0LL;
			//       Unity::Collections::NativeArray<int>::NativeArray(
			//         &v39,
			//         0,
			//         Allocator__Enum_Temp,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//       goto LABEL_12;
			//     }
			//     v14 = subpass - 1;
			//     if ( v14 )
			//     {
			//       v15 = v14 - 1;
			//       if ( v15 && (v16 = v15 - 1) != 0 )
			//       {
			//         v17 = v16 - 1;
			//         v39 = 0LL;
			//         if ( !v17 )
			//         {
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             gBufferAttachmentCount,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *inputIndices = v39;
			//           v39 = 0LL;
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             1,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *outputIndices = v39;
			//           *(_DWORD *)outputIndices.m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                                                  this,
			//                                                  OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//                                                  0LL);
			//           if ( shouldSplitOnePass )
			//             return;
			//           v24 = 0LL;
			//           while ( 1 )
			//           {
			//             AttachmentIndex = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v9, 0LL);
			//             if ( AttachmentIndex == -1 )
			//             {
			//               if ( v9 == GBufferID__Enum_GBufferDepth )
			//               {
			// LABEL_30:
			//                 *depthAsInput = 1;
			//                 return;
			//               }
			//             }
			//             else
			//             {
			//               v26 = v24++;
			//               *(_DWORD *)&inputIndices.m_Buffer[4 * v26] = AttachmentIndex;
			//             }
			//             if ( (int)++v9 >= (int)GBufferID__Enum_Count )
			//               return;
			//           }
			//         }
			//         v18 = v17 - 1;
			//         if ( v18 )
			//         {
			//           if ( v18 != 1 )
			//           {
			//             Unity::Collections::NativeArray<int>::NativeArray(
			//               &v39,
			//               0,
			//               Allocator__Enum_Temp,
			//               NativeArrayOptions__Enum_ClearMemory,
			//               MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			// LABEL_12:
			//             *outputIndices = v39;
			//             v39 = 0LL;
			//             Unity::Collections::NativeArray<int>::NativeArray(
			//               &v39,
			//               0,
			//               Allocator__Enum_Temp,
			//               NativeArrayOptions__Enum_ClearMemory,
			//               MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//             *inputIndices = v39;
			//             return;
			//           }
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             fixedAttachmentCount,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *outputIndices = v39;
			//           v39 = 0LL;
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             gBufferAttachmentCount,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *inputIndices = v39;
			//           *(_DWORD *)outputIndices.m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                                                  this,
			//                                                  OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//                                                  0LL);
			//           v19 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                   this,
			//                   OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//                   0LL);
			//           if ( v19 != -1 )
			//             *(_DWORD *)&outputIndices.m_Buffer[4] = v19;
			//           v20 = 0LL;
			//           do
			//           {
			//             v21 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v9, 0LL);
			//             if ( v21 == -1 )
			//             {
			//               if ( v9 == GBufferID__Enum_GBufferDepth )
			//                 goto LABEL_30;
			//             }
			//             else
			//             {
			//               v22 = v20++;
			//               *(_DWORD *)&inputIndices.m_Buffer[4 * v22] = v21;
			//             }
			//             ++v9;
			//           }
			//           while ( (int)v9 < (int)GBufferID__Enum_Count );
			//         }
			//         else
			//         {
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             fixedAttachmentCount,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *outputIndices = v39;
			//           v39 = 0LL;
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             0,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *inputIndices = v39;
			//           *(_DWORD *)outputIndices.m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                                                  this,
			//                                                  OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//                                                  0LL);
			//           v23 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                   this,
			//                   OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//                   0LL);
			//           if ( v23 != -1 )
			//             *(_DWORD *)&outputIndices.m_Buffer[4] = v23;
			//         }
			//       }
			//       else
			//       {
			//         v27 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                 this,
			//                 GBufferID__Enum_GBufferDepth,
			//                 0LL);
			//         v28 = fixedAttachmentCount + gBufferAttachmentCount;
			//         if ( v27 != -1 )
			//           v28 = fixedAttachmentCount + gBufferAttachmentCount - 1;
			//         v39 = 0LL;
			//         Unity::Collections::NativeArray<int>::NativeArray(
			//           &v39,
			//           v28,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//         *outputIndices = v39;
			//         *(_DWORD *)outputIndices.m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                                                this,
			//                                                OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//                                                0LL);
			//         v29 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                 this,
			//                 OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//                 0LL);
			//         v30 = 1LL;
			//         if ( v29 != -1 )
			//         {
			//           v30 = 2LL;
			//           *(_DWORD *)&outputIndices.m_Buffer[4] = v29;
			//         }
			//         do
			//         {
			//           if ( v9 != GBufferID__Enum_GBufferDepth )
			//           {
			//             v31 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v9, 0LL);
			//             if ( v31 != -1 )
			//             {
			//               v32 = v30++;
			//               *(_DWORD *)&outputIndices.m_Buffer[4 * v32] = v31;
			//             }
			//           }
			//           ++v9;
			//         }
			//         while ( (int)v9 < (int)GBufferID__Enum_Count );
			//         v39 = 0LL;
			//         if ( v27 == -1 )
			//         {
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             0,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *inputIndices = v39;
			//           *depthAsInput = 1;
			//         }
			//         else
			//         {
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v39,
			//             1,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *inputIndices = v39;
			//           *(_DWORD *)inputIndices.m_Buffer = v27;
			//         }
			//       }
			//     }
			//     else
			//     {
			//       v39 = 0LL;
			//       Unity::Collections::NativeArray<int>::NativeArray(
			//         &v39,
			//         fixedAttachmentCount + gBufferAttachmentCount,
			//         Allocator__Enum_Temp,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//       *outputIndices = v39;
			//       v39 = 0LL;
			//       Unity::Collections::NativeArray<int>::NativeArray(
			//         &v39,
			//         0,
			//         Allocator__Enum_Temp,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//       *inputIndices = v39;
			//       *(_DWORD *)outputIndices.m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//                                              this,
			//                                              OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//                                              0LL);
			//       v33 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//               this,
			//               OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//               0LL);
			//       v34 = 1LL;
			//       if ( v33 != -1 )
			//       {
			//         v34 = 2LL;
			//         *(_DWORD *)&outputIndices.m_Buffer[4] = v33;
			//       }
			//       do
			//       {
			//         v35 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v9, 0LL);
			//         if ( v35 != -1 )
			//         {
			//           v36 = v34++;
			//           *(_DWORD *)&outputIndices.m_Buffer[4 * v36] = v35;
			//         }
			//         ++v9;
			//       }
			//       while ( (int)v9 < (int)GBufferID__Enum_Count );
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         OnePassDeferredPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2739, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2739, 0LL);
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
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         OnePassDeferredPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2740, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2740, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref OnePassDeferredPassConstructor.PassInput input, ref OnePassDeferredPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPass(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         OnePassDeferredPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *P3; // r12
			//   OnePassDeferredPassConstructor_PassInput *v8; // rsi
			//   Object *v9; // r15
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rbx
			//   bool v14; // r13
			//   ProfilingSampler *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int v18; // r8d
			//   ValueTuple_2_Int32_Int32_ v19; // rdx
			//   ValueTuple_2_Int32_Int32_ v20; // rcx
			//   ValueTuple_2_Int32_Int32_ v21; // rbx
			//   TextureHandle sceneDepth; // xmm8
			//   TextureHandle sceneDepthCopied; // xmm7
			//   ProfilingSampler *v24; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   OnePassDeferredPassConstructor_OnePassDeferredData *v29; // rbx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   TextureHandle v32; // xmm0
			//   int32_t i; // ebx
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   __int64 v36; // rdx
			//   TextureHandle *v37; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   int32_t v41; // [rsp+64h] [rbp-144h] BYREF
			//   unsigned int v42; // [rsp+68h] [rbp-140h]
			//   int v43; // [rsp+6Ch] [rbp-13Ch]
			//   int32_t v44; // [rsp+70h] [rbp-138h] BYREF
			//   OnePassDeferredPassConstructor_OnePassDeferredData *v45; // [rsp+78h] [rbp-130h] BYREF
			//   TextureHandle v46; // [rsp+80h] [rbp-128h] BYREF
			//   OnePassDeferredPassConstructor_OnePassDeferredData *v47; // [rsp+90h] [rbp-118h] BYREF
			//   TextureHandle v48; // [rsp+A0h] [rbp-108h] BYREF
			//   HGRenderGraphBuilder v49; // [rsp+B0h] [rbp-F8h] BYREF
			//   TextureHandle v50; // [rsp+D0h] [rbp-D8h] BYREF
			//   HGRenderGraphBuilder v51; // [rsp+E0h] [rbp-C8h] BYREF
			//   HGRenderGraphBuilder v52; // [rsp+100h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v53; // [rsp+120h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v54; // [rsp+128h] [rbp-80h] BYREF
			//   TextureHandle v55; // [rsp+130h] [rbp-78h] BYREF
			// 
			//   P3 = (Object *)renderGraph;
			//   v8 = input;
			//   v9 = (Object *)this;
			//   if ( !byte_18D919596 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     sub_18003C530(&off_18D500EF8);
			//     byte_18D919596 = 1;
			//   }
			//   memset(&v51, 0, sizeof(v51));
			//   v47 = 0LL;
			//   v41 = 0;
			//   v45 = 0LL;
			//   v44 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2741, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2741, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v40, v39);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1006(Patch, v9, v8, output, P3, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( !currentPipeline )
			//       sub_180B536AC(v12, v11);
			//     settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
			//     if ( !settingParameters_k__BackingField )
			//       sub_180B536AC(v12, v11);
			//     v14 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//             settingParameters_k__BackingField.fields._shouldSplitOnePass_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x17u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !P3 )
			//       sub_180B536AC(v17, v16);
			//     v51 = *(HGRenderGraphBuilder *)sub_180830B24((unsigned int)&v49, (_DWORD)P3, v18, (unsigned int)&v47, (__int64)v15);
			//     v48.handle = 0LL;
			//     v48.fallBackResource = (ResourceHandle)&v51;
			//     try
			//     {
			//       v49 = v51;
			//       v21 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(
			//               (OnePassDeferredPassConstructor *)v9,
			//               v8,
			//               &v49,
			//               1,
			//               0LL);
			//       if ( !v47 )
			//         sub_1802DC2C8(v20, v19);
			//       v47.fields.shouldSplitOnePass = v14;
			//       v49 = v51;
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
			//         (OnePassDeferredPassConstructor *)v9,
			//         &v49,
			//         v8,
			//         output,
			//         &v41,
			//         v47,
			//         (HGRenderGraph *)P3,
			//         camera,
			//         v21,
			//         0LL);
			//       if ( !v14 )
			//       {
			//         v49 = v51;
			//         HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
			//           (OnePassDeferredPassConstructor *)v9,
			//           &v49,
			//           v8,
			//           output,
			//           &v41,
			//           v47,
			//           (HGRenderGraph *)P3,
			//           camera,
			//           v21,
			//           0,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v53 )
			//     {
			//       v48.handle = (ResourceHandle)v53.ex;
			//       sub_180222690(&v48);
			//       P3 = (Object *)renderGraph;
			//       v8 = input;
			//       v9 = (Object *)this;
			//       goto LABEL_12;
			//     }
			//     sub_180222690(&v48);
			// LABEL_12:
			//     if ( v14 )
			//     {
			//       sceneDepth = v8.sceneDepth;
			//       sceneDepthCopied = v8.sceneDepthCopied;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//       v46 = 0LL;
			//       v50 = sceneDepthCopied;
			//       v48 = sceneDepth;
			//       HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//         (HGRenderGraph *)P3,
			//         &v48,
			//         &v50,
			//         0,
			//         -1,
			//         0,
			//         (Rect *)&v46,
			//         0,
			//         0LL);
			//       v24 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x17u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !P3 )
			//         sub_1802DC2C8(v26, v25);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v49,
			//         (HGRenderGraph *)P3,
			//         (String *)"One Pass Deferred",
			//         (Object **)&v45,
			//         v24,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//       v52 = v49;
			//       v50.handle = 0LL;
			//       v50.fallBackResource = (ResourceHandle)&v52;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v52, 0, 0LL);
			//         v42 = 1;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v46,
			//           &v52,
			//           &v8.sceneColor,
			//           0,
			//           0,
			//           0LL);
			//         HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//           (OnePassDeferredPassConstructor *)v9,
			//           OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8.sceneMV, 0LL) )
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v46,
			//             &v52,
			//             &v8.sceneMV,
			//             1,
			//             0,
			//             0LL);
			//           v42 = 2;
			//           HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//             (OnePassDeferredPassConstructor *)v9,
			//             OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//             1,
			//             0LL);
			//         }
			//         else
			//         {
			//           HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//             (OnePassDeferredPassConstructor *)v9,
			//             OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
			//             -1,
			//             0LL);
			//         }
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           &v46,
			//           &v52,
			//           &v8.sceneDepth,
			//           DepthAccess__Enum_ReadWrite,
			//           0,
			//           0LL);
			//         if ( !v45 )
			//           sub_1802DC2C8(v28, v27);
			//         v45.fields.shouldSplitOnePass = v14;
			//         v29 = v45;
			//         v32 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  &v46,
			//                  &v52,
			//                  &v8.sceneDepthCopied,
			//                  0LL);
			//         if ( !v29 )
			//           sub_1802DC2C8(v31, v30);
			//         v29.fields.sceneDepthCopied = v32;
			//         for ( i = 0; i < 4; ++i )
			//         {
			//           v46 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v55, &v8.gBufferOutput, i, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v46, 0LL) && i != 3 )
			//           {
			//             if ( !v45 )
			//               sub_1802DC2C8(v35, v34);
			//             v48.handle = (ResourceHandle)v45.fields.gbuffer;
			//             v37 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v49,
			//                     &v52,
			//                     &v46,
			//                     0LL);
			//             if ( !*(_QWORD *)&v48.handle )
			//               sub_1802DC2C8(v37, v36);
			//             v46 = *v37;
			//             sub_1803EF6F4(*(_QWORD *)&v48.handle, i, &v46);
			//           }
			//         }
			//         v44 = 0;
			//         v43 = 0;
			//         v49 = v52;
			//         HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
			//           (OnePassDeferredPassConstructor *)v9,
			//           &v49,
			//           v8,
			//           output,
			//           &v44,
			//           v45,
			//           (HGRenderGraph *)P3,
			//           camera,
			//           (ValueTuple_2_Int32_Int32_)v42,
			//           v14,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v54 )
			//       {
			//         v50.handle = (ResourceHandle)v54.ex;
			//         sub_180222690(&v50);
			//         return;
			//       }
			//       sub_180222690(&v50);
			//     }
			//   }
			// }
			// 
		}

		private void _ConstructPassPhase0(HGRenderGraphBuilder builder, ref OnePassDeferredPassConstructor.PassInput input, ref OnePassDeferredPassConstructor.PassOutput output, ref int subpassIndex, OnePassDeferredPassConstructor.OnePassDeferredData passData, HGRenderGraph renderGraph, HGCamera camera, ValueTuple<int, int> count)
		{
			// // Void _ConstructPassPhase0(HGRenderGraphBuilder, OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, Int32 ByRef, OnePassDeferredPassConstructor+OnePassDeferredData, HGRenderGraph, HGCamera, ValueTuple`2[Int32,Int32])
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
			//         OnePassDeferredPassConstructor *this,
			//         HGRenderGraphBuilder *builder,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         OnePassDeferredPassConstructor_PassOutput *output,
			//         int32_t *subpassIndex,
			//         OnePassDeferredPassConstructor_OnePassDeferredData *passData,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         ValueTuple_2_Int32_Int32_ count,
			//         MethodInfo *method)
			// {
			//   __int64 preZ; // rdx
			//   _BYTE *deferredErosion; // rcx
			//   HGRenderGraph *v16; // xmm1_8
			//   HGRenderGraph *v17; // xmm1_8
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   __int128 v20; // xmm6
			//   __int128 v21; // xmm7
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   char v23; // r8
			//   char v24; // si
			//   HGRenderPipeline *hgrp; // rax
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // ebx
			//   Camera *v29; // r8
			//   RendererListDesc *v30; // rax
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   RendererListHandle InvalidHandle; // rax
			//   CullingResults cullingResults; // xmm6
			//   Camera *v46; // rsi
			//   float v47; // xmm8_4
			//   float v48; // xmm7_4
			//   uint32_t v49; // edi
			//   HGShaderPassNames__StaticFields *v50; // rbx
			//   ShaderTagId v51; // r9d
			//   RendererListDesc *v52; // rax
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm0
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm0
			//   __int128 v65; // xmm1
			//   RendererListHandle v66; // rax
			//   PerObjectData__Enum PerObjectDataConfig; // eax
			//   CullingResults v68; // xmm6
			//   Camera *v69; // rsi
			//   float v70; // xmm8_4
			//   float v71; // xmm7_4
			//   uint32_t v72; // edi
			//   HGShaderPassNames__StaticFields *v73; // rbx
			//   ShaderTagId v74; // r9d
			//   RendererListDesc *v75; // rax
			//   __int128 v76; // xmm1
			//   __int128 v77; // xmm0
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm0
			//   __int128 v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int128 v82; // xmm1
			//   __int128 v83; // xmm0
			//   __int128 v84; // xmm1
			//   __int128 v85; // xmm0
			//   __int128 v86; // xmm1
			//   __int128 v87; // xmm0
			//   __int128 v88; // xmm1
			//   RendererListHandle v89; // rax
			//   RendererListHandle v90; // rax
			//   bool v91; // zf
			//   CullingResults v92; // xmm6
			//   Camera *v93; // rsi
			//   float v94; // xmm8_4
			//   float v95; // xmm7_4
			//   uint32_t v96; // edi
			//   HGShaderPassNames__StaticFields *v97; // rbx
			//   ShaderTagId v98; // r9d
			//   RendererListDesc *v99; // rax
			//   __int128 v100; // xmm1
			//   __int128 v101; // xmm0
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm0
			//   __int128 v104; // xmm1
			//   __int128 v105; // xmm0
			//   __int128 v106; // xmm1
			//   __int128 v107; // xmm0
			//   __int128 v108; // xmm1
			//   __int128 v109; // xmm0
			//   __int128 v110; // xmm1
			//   __int128 v111; // xmm0
			//   __int128 v112; // xmm1
			//   RendererListHandle v113; // rax
			//   NativeArray_1_System_Int32_ v114; // xmm7
			//   NativeArray_1_System_Int32_ v115; // xmm6
			//   char v116; // di
			//   int32_t v117; // esi
			//   int32_t v118; // edx
			//   OnePassDeferredPassConstructor__StaticFields *v119; // rax
			//   int32_t v120; // edx
			//   NativeArray_1_System_Int32_ v121; // xmm1
			//   __int128 v122; // xmm1
			//   MethodInfo *outputIndices; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *inputIndices; // [rsp+30h] [rbp-D8h]
			//   bool depthAsInput[8]; // [rsp+78h] [rbp-90h] BYREF
			//   RendererListHandle inputa; // [rsp+80h] [rbp-88h] BYREF
			//   NativeArray_1_System_Int32_ v127; // [rsp+88h] [rbp-80h] BYREF
			//   Void *v128; // [rsp+98h] [rbp-70h]
			//   HGRenderGraphBuilder v129; // [rsp+A8h] [rbp-60h] BYREF
			//   PerObjectData__Enum v130; // [rsp+C8h] [rbp-40h]
			//   NativeArray_1_System_Int32_ v131; // [rsp+D8h] [rbp-30h] BYREF
			//   NativeArray_1_System_Int32_ v132; // [rsp+E8h] [rbp-20h] BYREF
			//   NativeArray_1_System_Int32_ v133; // [rsp+F8h] [rbp-10h] BYREF
			//   NativeArray_1_System_Int32_ v134; // [rsp+108h] [rbp+0h] BYREF
			//   NativeArray_1_System_Int32_ v135; // [rsp+118h] [rbp+10h] BYREF
			//   NativeArray_1_System_Int32_ v136; // [rsp+128h] [rbp+20h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v137; // [rsp+138h] [rbp+30h] BYREF
			//   RendererListDesc desc; // [rsp+1A8h] [rbp+A0h] BYREF
			//   RendererListDesc v139; // [rsp+288h] [rbp+180h] BYREF
			// 
			//   if ( !byte_18D919597 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetupSubpass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//     byte_18D919597 = 1;
			//   }
			//   depthAsInput[0] = 0;
			//   depthAsInput[1] = 0;
			//   depthAsInput[2] = 0;
			//   v131 = 0LL;
			//   v132 = 0LL;
			//   v134 = 0LL;
			//   v133 = 0LL;
			//   v136 = 0LL;
			//   v135 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2743, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       v16 = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       *(BitArray128 *)&v129.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v129.m_RenderGraph = v16;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              (FrameSettings *)&v129,
			//              FrameSettingsField__Enum_ShadowMaps,
			//              0LL)
			//         || (v17 = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality,
			//             *(BitArray128 *)&v129.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas,
			//             v129.m_RenderGraph = v17,
			//             HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//               (FrameSettings *)&v129,
			//               FrameSettingsField__Enum_CharacterShadowMaps,
			//               0LL)) )
			//       {
			//         v20 = *(_OWORD *)&builder.m_RenderPass;
			//         v21 = *(_OWORD *)&builder.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v129.m_RenderPass = v20;
			//         *(_OWORD *)&v129.m_RenderGraph = v21;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//           (ShadowResult *)&v137,
			//           &input.shadowResult,
			//           &v129,
			//           0LL);
			//       }
			//       if ( passData )
			//       {
			//         passData.fields.camera = camera;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&passData.fields.camera,
			//           (HGRenderPathBase_HGRenderPathResources *)preZ,
			//           v18,
			//           v19,
			//           outputIndices,
			//           inputIndices);
			//         passData.fields.vtFeedbackId = camera.fields.vtFeedbackViewId;
			//         passData.fields.subdivisionHandle = camera.fields.subdivisionHandle;
			//         passData.fields.terrainCullViewHandle = camera.fields.terrainCullViewHandle;
			//         passData.fields.editorTerrainCullViewHandle = camera.fields.editorTerrainCullViewHandle;
			//         passData.fields.enableTerrainDecalDeform = input.enableTerrainDecalDeform;
			//         passData.fields.enableTerrainWetRipple = input.enableTerrainWetRipple;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         deferredErosion = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         preZ = (__int64)static_fields.preZ;
			//         if ( preZ )
			//         {
			//           v23 = *(_BYTE *)(preZ + 16);
			//           preZ = (__int64)static_fields.characterPrePass;
			//           if ( preZ )
			//           {
			//             v24 = *(_BYTE *)(preZ + 16);
			//             preZ = (__int64)static_fields.deferredOpaque;
			//             if ( preZ )
			//             {
			//               depthAsInput[3] = *(_BYTE *)(preZ + 16);
			//               deferredErosion = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredErosion;
			//               if ( deferredErosion )
			//               {
			//                 depthAsInput[4] = deferredErosion[16];
			//                 hgrp = input.hgrp;
			//                 if ( hgrp )
			//                 {
			//                   inputa = (RendererListHandle)hgrp.fields.depthOnlyPassNames;
			//                   if ( v23 )
			//                   {
			//                     screenCullingRatio = input.screenCullingRatio;
			//                     screenCullingRatioDistance = input.screenCullingRatioDistance;
			//                     screenCullingLayerMask = input.screenCullingLayerMask;
			//                     v128 = 0LL;
			//                     sub_1802F01E0(&v137, 0LL, 112LL);
			//                     v29 = camera.fields.camera;
			//                     v127.m_Length = 0;
			//                     v127.m_Buffer = 0LL;
			//                     *(CullingResults *)&v129.m_RenderPass = input.cullingResults;
			//                     v30 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                             &v139,
			//                             (CullingResults *)&v129,
			//                             v29,
			//                             *(ShaderTagId__Array **)&inputa,
			//                             screenCullingRatio,
			//                             screenCullingRatioDistance,
			//                             screenCullingLayerMask,
			//                             PerObjectData__Enum_None,
			//                             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v127,
			//                             &v137,
			//                             0LL,
			//                             0,
			//                             0LL);
			//                     v31 = *(_OWORD *)&v30.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v30.sortingCriteria;
			//                     v32 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.hasValue = v31;
			//                     v33 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v32;
			//                     v34 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v33;
			//                     v35 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v34;
			//                     v36 = *(_OWORD *)&v30.stateBlock.value.m_RasterState.m_OffsetFactor;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v35;
			//                     v37 = *(_OWORD *)&v30.stateBlock.value.m_StencilState.m_FailOperationFront;
			//                     v30 = (RendererListDesc *)((char *)v30 + 128);
			//                     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v36;
			//                     deferredErosion = &desc.overrideMaterial;
			//                     v38 = *(_OWORD *)&v30.sortingCriteria;
			//                     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v37;
			//                     v39 = *(_OWORD *)&v30.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.overrideMaterial = v38;
			//                     v40 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.overrideMaterialPassIndex = v39;
			//                     v41 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.sortingLayerMin = v40;
			//                     v42 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.drawableFeedbackPtr = v41;
			//                     v43 = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v42;
			//                     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v43;
			//                     if ( !renderGraph )
			//                       goto LABEL_33;
			//                     InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                       renderGraph,
			//                                       &desc,
			//                                       0LL);
			//                   }
			//                   else
			//                   {
			//                     InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//                   }
			//                   inputa = InvalidHandle;
			//                   passData.fields.preDepthRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                             builder,
			//                                                             &inputa,
			//                                                             0LL);
			//                   if ( v24 )
			//                   {
			//                     cullingResults = input.cullingResults;
			//                     v46 = camera.fields.camera;
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//                     v47 = input.screenCullingRatio;
			//                     v48 = input.screenCullingRatioDistance;
			//                     v49 = input.screenCullingLayerMask;
			//                     v50 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//                     v128 = 0LL;
			//                     sub_1802F01E0(&v137, 0LL, 112LL);
			//                     v51.m_Id = v50.s_DepthCharacterOnlyName.m_Id;
			//                     v127.m_Length = (int)v128;
			//                     v127.m_Buffer = v128;
			//                     *(CullingResults *)&v129.m_RenderPass = cullingResults;
			//                     v52 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                             &v139,
			//                             (CullingResults *)&v129,
			//                             v46,
			//                             v51,
			//                             v47,
			//                             v48,
			//                             v49,
			//                             PerObjectData__Enum_None,
			//                             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v127,
			//                             &v137,
			//                             0LL,
			//                             0,
			//                             0LL,
			//                             0LL);
			//                     v53 = *(_OWORD *)&v52.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v52.sortingCriteria;
			//                     v54 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.hasValue = v53;
			//                     v55 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v54;
			//                     v56 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v55;
			//                     v57 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v56;
			//                     v58 = *(_OWORD *)&v52.stateBlock.value.m_RasterState.m_OffsetFactor;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v57;
			//                     v59 = *(_OWORD *)&v52.stateBlock.value.m_StencilState.m_FailOperationFront;
			//                     v52 = (RendererListDesc *)((char *)v52 + 128);
			//                     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v58;
			//                     deferredErosion = &desc.overrideMaterial;
			//                     v60 = *(_OWORD *)&v52.sortingCriteria;
			//                     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v59;
			//                     v61 = *(_OWORD *)&v52.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.overrideMaterial = v60;
			//                     v62 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.overrideMaterialPassIndex = v61;
			//                     v63 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.sortingLayerMin = v62;
			//                     v64 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.drawableFeedbackPtr = v63;
			//                     v65 = *(_OWORD *)&v52.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v64;
			//                     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v65;
			//                     if ( !renderGraph )
			//                       goto LABEL_33;
			//                     v66 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//                   }
			//                   else
			//                   {
			//                     v66 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//                   }
			//                   inputa = v66;
			//                   passData.fields.characterPrePassRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                                     builder,
			//                                                                     &inputa,
			//                                                                     0LL);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//                   PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//                   deferredErosion = input.hgrp;
			//                   if ( deferredErosion )
			//                   {
			//                     v130 = *((_DWORD *)deferredErosion + 24) | PerObjectDataConfig;
			//                     if ( depthAsInput[3] )
			//                     {
			//                       v68 = input.cullingResults;
			//                       v69 = camera.fields.camera;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//                       v70 = input.screenCullingRatio;
			//                       v71 = input.screenCullingRatioDistance;
			//                       v72 = input.screenCullingLayerMask;
			//                       v73 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//                       v128 = 0LL;
			//                       sub_1802F01E0(&v137, 0LL, 112LL);
			//                       v74.m_Id = v73.s_GBufferName.m_Id;
			//                       v127.m_Length = (int)v128;
			//                       v127.m_Buffer = v128;
			//                       *(CullingResults *)&v129.m_RenderPass = v68;
			//                       v75 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                               &v139,
			//                               (CullingResults *)&v129,
			//                               v69,
			//                               v74,
			//                               v70,
			//                               v71,
			//                               v72,
			//                               v130,
			//                               (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v127,
			//                               &v137,
			//                               0LL,
			//                               0,
			//                               0LL,
			//                               0LL);
			//                       preZ = 128LL;
			//                       v76 = *(_OWORD *)&v75.stateBlock.hasValue;
			//                       *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v75.sortingCriteria;
			//                       v77 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.stateBlock.hasValue = v76;
			//                       v78 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v77;
			//                       v79 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v78;
			//                       v80 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v79;
			//                       v81 = *(_OWORD *)&v75.stateBlock.value.m_RasterState.m_OffsetFactor;
			//                       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v80;
			//                       v82 = *(_OWORD *)&v75.stateBlock.value.m_StencilState.m_FailOperationFront;
			//                       v75 = (RendererListDesc *)((char *)v75 + 128);
			//                       *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v81;
			//                       deferredErosion = &desc.overrideMaterial;
			//                       v83 = *(_OWORD *)&v75.sortingCriteria;
			//                       *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v82;
			//                       v84 = *(_OWORD *)&v75.stateBlock.hasValue;
			//                       *(_OWORD *)&desc.overrideMaterial = v83;
			//                       v85 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.overrideMaterialPassIndex = v84;
			//                       v86 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.sortingLayerMin = v85;
			//                       v87 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc.drawableFeedbackPtr = v86;
			//                       v88 = *(_OWORD *)&v75.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                       *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v87;
			//                       *(_OWORD *)&desc._passName_k__BackingField.m_Id = v88;
			//                       if ( !renderGraph )
			//                         goto LABEL_33;
			//                       v89 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//                     }
			//                     else
			//                     {
			//                       v89 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//                     }
			//                     inputa = v89;
			//                     v90 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(builder, &inputa, 0LL);
			//                     v91 = !depthAsInput[4];
			//                     passData.fields.gBufferRendererList = v90;
			//                     if ( v91 )
			//                     {
			//                       v113 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//                       goto LABEL_31;
			//                     }
			//                     v92 = input.cullingResults;
			//                     v93 = camera.fields.camera;
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//                     v94 = input.screenCullingRatio;
			//                     v95 = input.screenCullingRatioDistance;
			//                     v96 = input.screenCullingLayerMask;
			//                     v97 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//                     v128 = 0LL;
			//                     sub_1802F01E0(&v137, 0LL, 112LL);
			//                     v98.m_Id = v97.s_ErosionMobileName.m_Id;
			//                     v127.m_Buffer = v128;
			//                     v127.m_Length = 0;
			//                     *(CullingResults *)&v129.m_RenderPass = v92;
			//                     v99 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                             &v139,
			//                             (CullingResults *)&v129,
			//                             v93,
			//                             v98,
			//                             v94,
			//                             v95,
			//                             v96,
			//                             v130,
			//                             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v127,
			//                             &v137,
			//                             0LL,
			//                             0,
			//                             0LL,
			//                             0LL);
			//                     v100 = *(_OWORD *)&v99.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v99.sortingCriteria;
			//                     v101 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.hasValue = v100;
			//                     v102 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v101;
			//                     v103 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v102;
			//                     v104 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v103;
			//                     v105 = *(_OWORD *)&v99.stateBlock.value.m_RasterState.m_OffsetFactor;
			//                     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v104;
			//                     v106 = *(_OWORD *)&v99.stateBlock.value.m_StencilState.m_FailOperationFront;
			//                     v99 = (RendererListDesc *)((char *)v99 + 128);
			//                     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v105;
			//                     preZ = (__int64)&desc.overrideMaterial;
			//                     deferredErosion = renderGraph;
			//                     v107 = *(_OWORD *)&v99.sortingCriteria;
			//                     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v106;
			//                     v108 = *(_OWORD *)&v99.stateBlock.hasValue;
			//                     *(_OWORD *)&desc.overrideMaterial = v107;
			//                     v109 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.overrideMaterialPassIndex = v108;
			//                     v110 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.sortingLayerMin = v109;
			//                     v111 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc.drawableFeedbackPtr = v110;
			//                     v112 = *(_OWORD *)&v99.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v111;
			//                     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v112;
			//                     if ( renderGraph )
			//                     {
			//                       v113 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                renderGraph,
			//                                &desc,
			//                                0LL);
			// LABEL_31:
			//                       inputa = v113;
			//                       passData.fields.erosionMobileRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                                      builder,
			//                                                                      &inputa,
			//                                                                      0LL);
			//                       passData.fields.deferredOpaquePreZECSList = input.deferredOpaquePreZECSList;
			//                       passData.fields.forwardOpaquePreZECSList = input.forwardOpaquePreZECSList;
			//                       passData.fields.deferredGrassPreZECSList = input.deferredGrassPreZECSList;
			//                       passData.fields.deferredOpaqueECSList = input.deferredOpaqueECSList;
			//                       passData.fields.deferredOpaqueEqualECSList = input.deferredOpaqueEqualECSList;
			//                       passData.fields.deferredGrassECSList = input.deferredGrassECSList;
			//                       passData.fields.deferredDecalMobileECSList = input.deferredDecalMobileECSList;
			//                       passData.fields.deferredSludgeECSList = input.deferredSludgeECSList;
			//                       passData.fields.deferredErosionMobileECSList = input.deferredErosionMobileECSList;
			//                       passData.fields.characterPrePassECSList = input.characterPrePassECSList;
			//                       HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//                         this,
			//                         OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_PreDepth,
			//                         count.Item1,
			//                         count.Item2,
			//                         &v131,
			//                         &v132,
			//                         depthAsInput,
			//                         0,
			//                         0LL);
			//                       v114 = v131;
			//                       v115 = v132;
			//                       v116 = depthAsInput[0];
			//                       v117 = (*subpassIndex)++;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//                       *(NativeArray_1_System_Int32_ *)&v129.m_RenderPass = v115;
			//                       v127 = v114;
			//                       sub_180830AC4(
			//                         (_DWORD)builder,
			//                         v117,
			//                         (unsigned int)&v127,
			//                         (unsigned int)&v129,
			//                         v116,
			//                         (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_preDepthRenderFunc,
			//                         1);
			//                       HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//                         this,
			//                         OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_GBuffer,
			//                         count.Item1,
			//                         count.Item2,
			//                         &v134,
			//                         &v133,
			//                         &depthAsInput[1],
			//                         0,
			//                         0LL);
			//                       v118 = (*subpassIndex)++;
			//                       v119 = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields;
			//                       *(NativeArray_1_System_Int32_ *)&v129.m_RenderPass = v133;
			//                       v127 = v134;
			//                       sub_180830AC4(
			//                         (_DWORD)builder,
			//                         v118,
			//                         (unsigned int)&v127,
			//                         (unsigned int)&v129,
			//                         depthAsInput[1],
			//                         (__int64)v119.s_gBufferRenderFunc,
			//                         2);
			//                       HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//                         this,
			//                         OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_Decal,
			//                         count.Item1,
			//                         count.Item2,
			//                         &v136,
			//                         &v135,
			//                         &depthAsInput[2],
			//                         0,
			//                         0LL);
			//                       v120 = *subpassIndex;
			//                       v121 = v136;
			//                       *(NativeArray_1_System_Int32_ *)&v129.m_RenderPass = v135;
			//                       *subpassIndex = v120 + 1;
			//                       v127 = v121;
			//                       sub_180830AC4(
			//                         (_DWORD)builder,
			//                         v120,
			//                         (unsigned int)&v127,
			//                         (unsigned int)&v129,
			//                         depthAsInput[2],
			//                         (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_decalRenderFunc,
			//                         0);
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
			// LABEL_33:
			//     sub_180B536AC(deferredErosion, preZ);
			//   }
			//   deferredErosion = IFix::WrappersManagerImpl::GetPatch(2743, 0LL);
			//   if ( !deferredErosion )
			//     goto LABEL_33;
			//   v122 = *(_OWORD *)&builder.m_RenderGraph;
			//   *(_OWORD *)&v129.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//   *(_OWORD *)&v129.m_RenderGraph = v122;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1004(
			//     (ILFixDynamicMethodWrapper_2 *)deferredErosion,
			//     (Object *)this,
			//     &v129,
			//     input,
			//     output,
			//     subpassIndex,
			//     (Object *)passData,
			//     (Object *)renderGraph,
			//     (Object *)camera,
			//     count,
			//     0LL);
			// }
			// 
		}

		private void _ConstructPassPhase1(HGRenderGraphBuilder builder, ref OnePassDeferredPassConstructor.PassInput input, ref OnePassDeferredPassConstructor.PassOutput output, ref int subpassIndex, OnePassDeferredPassConstructor.OnePassDeferredData passData, HGRenderGraph renderGraph, HGCamera camera, ValueTuple<int, int> count, bool shouldSplitOnePass)
		{
			// // Void _ConstructPassPhase1(HGRenderGraphBuilder, OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, Int32 ByRef, OnePassDeferredPassConstructor+OnePassDeferredData, HGRenderGraph, HGCamera, ValueTuple`2[Int32,Int32], Boolean)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
			//         OnePassDeferredPassConstructor *this,
			//         HGRenderGraphBuilder *builder,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         OnePassDeferredPassConstructor_PassOutput *output,
			//         int32_t *subpassIndex,
			//         OnePassDeferredPassConstructor_OnePassDeferredData *passData,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         ValueTuple_2_Int32_Int32_ count,
			//         bool shouldSplitOnePass,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   Material *m_deferredLightingMaterial; // rcx
			//   __int64 v17; // xmm1_8
			//   __int64 v18; // xmm1_8
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   __int128 v21; // xmm6
			//   __int128 v22; // xmm7
			//   TextureHandle *Texture; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   HGRenderPipeline *hgrp; // rsi
			//   PerObjectData__Enum m_CurrentRendererConfigurationBakedLighting; // esi
			//   __int128 v28; // xmm1
			//   uint32_t forwardOpaqueECSList; // edi
			//   HGRenderPipeline *v30; // rcx
			//   __int128 v31; // xmm0
			//   DeferredLightingPass_DeferredLightingRenderParams *inited; // rax
			//   __int128 v33; // xmm2
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   bool HasTerrainSimpleSubsurface; // di
			//   Shader *shader; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   __int128 v45; // xmm0
			//   __int64 v46; // rax
			//   GraphicsBuffer *quadIndexBuffer; // xmm1_8
			//   __int64 v48; // rax
			//   __int64 v49; // rax
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights; // rax
			//   int32_t v51; // esi
			//   int32_t m_Length; // eax
			//   MethodInfo *v53; // rdx
			//   MethodInfo *v54; // rdx
			//   Vector3 *one; // rax
			//   __int64 v56; // xmm0_8
			//   MethodInfo *v57; // r9
			//   Vector3 *v58; // rax
			//   __int64 v59; // xmm3_8
			//   MethodInfo *v60; // r9
			//   Vector3 *v61; // rax
			//   __int64 v62; // xmm3_8
			//   MethodInfo *v63; // r9
			//   Vector3 *v64; // rax
			//   Quaternion *v65; // r8
			//   Quaternion v66; // xmm0
			//   __int64 v67; // xmm3_8
			//   Matrix4x4 *v68; // rax
			//   __int128 v69; // xmm6
			//   __int128 v70; // xmm7
			//   __int128 v71; // xmm8
			//   __int128 v72; // xmm9
			//   __int64 v73; // rax
			//   __int64 v74; // xmm6_8
			//   float z; // ebx
			//   Vector3 *Forward; // rax
			//   __int64 v77; // xmm0_8
			//   MethodInfo *v78; // r9
			//   Vector3 *v79; // rax
			//   __int64 v80; // xmm3_8
			//   MethodInfo *v81; // r9
			//   Vector3 *v82; // rax
			//   __int64 v83; // xmm8_8
			//   float v84; // edi
			//   Vector3 *v85; // rax
			//   __int64 v86; // xmm0_8
			//   MethodInfo *v87; // r8
			//   Vector3 *v88; // rbx
			//   __m128 m_SpotAngle_low; // xmm0
			//   __int64 v90; // rdx
			//   __int64 v91; // rcx
			//   __int64 v92; // r8
			//   __int64 v93; // r9
			//   float v94; // eax
			//   __m128 v95; // xmm7
			//   Quaternion *v96; // rax
			//   __m128i v97; // xmm6
			//   Quaternion *v98; // rax
			//   MethodInfo *v99; // r9
			//   __m128 v100; // xmm0
			//   MethodInfo *v101; // r9
			//   Vector3 *v102; // rax
			//   NativeArray_1_System_Int32_ *v103; // r8
			//   NativeArray_1_System_Int32_ v104; // xmm0
			//   __int64 v105; // xmm3_8
			//   Matrix4x4 *v106; // rax
			//   __int128 v107; // xmm6
			//   __int128 v108; // xmm7
			//   __int128 v109; // xmm8
			//   __int128 v110; // xmm9
			//   __int64 v111; // rax
			//   Shader *v112; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v113; // rdx
			//   PassConstructorID__Enum__Array *v114; // r8
			//   HGCamera *v115; // r9
			//   Mesh *m_sphereMesh; // r9
			//   HGRenderPathBase_HGRenderPathResources *v117; // rdx
			//   PassConstructorID__Enum__Array *v118; // r8
			//   Mesh *m_coneMesh; // r9
			//   HGRenderPathBase_HGRenderPathResources *v120; // rdx
			//   PassConstructorID__Enum__Array *v121; // r8
			//   HGRenderPathBase_HGRenderPathResources *v122; // rdx
			//   PassConstructorID__Enum__Array *v123; // r8
			//   HGCamera *v124; // r9
			//   NativeArray_1_System_Int32_ v125; // xmm7
			//   NativeArray_1_System_Int32_ v126; // xmm6
			//   char v127; // bl
			//   int32_t v128; // edi
			//   int32_t v129; // edx
			//   NativeArray_1_System_Int32_ v130; // xmm1
			//   __int128 v131; // xmm1
			//   MethodInfo *outputIndices; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicesc; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicesa; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicesb; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicesd; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicese; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *outputIndicesf; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *inputIndices; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicesc; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicesa; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicesb; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicesd; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicese; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *inputIndicesf; // [rsp+30h] [rbp-E8h]
			//   uint32_t shouldSplitOnePassa; // [rsp+40h] [rbp-D8h]
			//   uint32_t methoda; // [rsp+48h] [rbp-D0h]
			//   uint32_t characterOutlineOpaqueECSRendererList; // [rsp+50h] [rbp-C8h]
			//   uint32_t characterOutlineOpaqueEqualECSRendererList; // [rsp+58h] [rbp-C0h]
			//   bool characterOutlineEnabled; // [rsp+60h] [rbp-B8h]
			//   float screenCullingRatio; // [rsp+68h] [rbp-B0h]
			//   float screenCullingRatioDistance; // [rsp+70h] [rbp-A8h]
			//   uint32_t screenCullingLayerMask; // [rsp+78h] [rbp-A0h]
			//   ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+80h] [rbp-98h]
			//   bool depthAsInput; // [rsp+98h] [rbp-80h] BYREF
			//   bool v156; // [rsp+99h] [rbp-7Fh] BYREF
			//   bool value; // [rsp+9Ah] [rbp-7Eh]
			//   NativeArray_1_System_Int32_ v158; // [rsp+A8h] [rbp-70h] BYREF
			//   DeferredLightingPass_DeferredLightingRenderParams v159; // [rsp+B8h] [rbp-60h] BYREF
			//   NativeArray_1_System_Int32_ v160; // [rsp+E8h] [rbp-30h] BYREF
			//   HGRenderPathBase_HGRenderPathResources *v161; // [rsp+F8h] [rbp-20h]
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ cullingResults; // [rsp+108h] [rbp-10h] BYREF
			//   Vector3 v163; // [rsp+118h] [rbp+0h] BYREF
			//   Vector3 v164; // [rsp+128h] [rbp+10h] BYREF
			//   Vector3 v165; // [rsp+138h] [rbp+20h] BYREF
			//   Vector3 m_WorldPosition; // [rsp+148h] [rbp+30h] BYREF
			//   Vector3 v167; // [rsp+158h] [rbp+40h] BYREF
			//   Vector3 v168; // [rsp+168h] [rbp+50h] BYREF
			//   Vector3 v169; // [rsp+178h] [rbp+60h] BYREF
			//   Vector3 v170; // [rsp+188h] [rbp+70h] BYREF
			//   Vector3 v171; // [rsp+198h] [rbp+80h] BYREF
			//   unsigned __int64 v172; // [rsp+1A8h] [rbp+90h] BYREF
			//   int v173; // [rsp+1B0h] [rbp+98h]
			//   Vector3 v174; // [rsp+1B8h] [rbp+A0h] BYREF
			//   Vector3 v175; // [rsp+1C8h] [rbp+B0h] BYREF
			//   Vector3 v176; // [rsp+1D8h] [rbp+C0h] BYREF
			//   Vector3 v177; // [rsp+1E8h] [rbp+D0h] BYREF
			//   NativeArray_1_System_Int32_ v178; // [rsp+1F8h] [rbp+E0h] BYREF
			//   NativeArray_1_System_Int32_ v179; // [rsp+208h] [rbp+F0h] BYREF
			//   NativeArray_1_System_Int32_ v180; // [rsp+218h] [rbp+100h] BYREF
			//   NativeArray_1_System_Int32_ v181; // [rsp+228h] [rbp+110h] BYREF
			//   LocalKeyword keyword; // [rsp+238h] [rbp+120h] BYREF
			//   LocalKeyword v183; // [rsp+250h] [rbp+138h] BYREF
			//   VisibleLight v184; // [rsp+268h] [rbp+150h] BYREF
			//   Vector3 v185; // [rsp+308h] [rbp+1F0h] BYREF
			//   Vector3 v186; // [rsp+318h] [rbp+200h] BYREF
			//   Vector3 v187; // [rsp+328h] [rbp+210h] BYREF
			//   Vector3 v188; // [rsp+338h] [rbp+220h] BYREF
			//   Vector3 v189; // [rsp+348h] [rbp+230h] BYREF
			//   Vector3 v190; // [rsp+358h] [rbp+240h] BYREF
			//   Vector3 v191; // [rsp+368h] [rbp+250h] BYREF
			//   Vector3 v192; // [rsp+378h] [rbp+260h] BYREF
			//   Vector3 v193; // [rsp+388h] [rbp+270h] BYREF
			//   Vector3 v194; // [rsp+398h] [rbp+280h] BYREF
			//   Quaternion v195; // [rsp+3A8h] [rbp+290h] BYREF
			//   Quaternion v196; // [rsp+3B8h] [rbp+2A0h] BYREF
			//   char v197[16]; // [rsp+3C8h] [rbp+2B0h] BYREF
			//   Matrix4x4 v198; // [rsp+3D8h] [rbp+2C0h] BYREF
			//   VisibleLight v199; // [rsp+418h] [rbp+300h] BYREF
			// 
			//   if ( !byte_18D919598 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetupSubpass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919598 = 1;
			//   }
			//   memset(&keyword, 0, sizeof(keyword));
			//   memset(&v183, 0, sizeof(v183));
			//   sub_1802F01E0(&v184, 0LL, 148LL);
			//   depthAsInput = 0;
			//   v156 = 0;
			//   v178 = 0LL;
			//   v179 = 0LL;
			//   v181 = 0LL;
			//   v180 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2744, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       v17 = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       *(BitArray128 *)&v159.enableDeferredShadingDefaultLit = camera.fields._frameSettings_k__BackingField.bitDatas;
			//       *(_QWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v17;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              (FrameSettings *)&v159,
			//              FrameSettingsField__Enum_ShadowMaps,
			//              0LL)
			//         || (v18 = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality,
			//             *(BitArray128 *)&v159.enableDeferredShadingDefaultLit = camera.fields._frameSettings_k__BackingField.bitDatas,
			//             *(_QWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v18,
			//             HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//               (FrameSettings *)&v159,
			//               FrameSettingsField__Enum_CharacterShadowMaps,
			//               0LL)) )
			//       {
			//         v21 = *(_OWORD *)&builder.m_RenderPass;
			//         v22 = *(_OWORD *)&builder.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v159.enableDeferredShadingDefaultLit = v21;
			//         *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v22;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//           (ShadowResult *)&v198,
			//           &input.shadowResult,
			//           (HGRenderGraphBuilder *)&v159,
			//           0LL);
			//       }
			//       if ( passData )
			//       {
			//         passData.fields.camera = camera;
			//         sub_1800054D0((HGRenderPathScene *)&passData.fields.camera, v15, v19, v20, outputIndices, inputIndices);
			//         passData.fields.vtFeedbackId = camera.fields.vtFeedbackViewId;
			//         passData.fields.subdivisionHandle = camera.fields.subdivisionHandle;
			//         passData.fields.terrainCullViewHandle = camera.fields.terrainCullViewHandle;
			//         passData.fields.editorTerrainCullViewHandle = camera.fields.editorTerrainCullViewHandle;
			//         passData.fields.enableTerrainDecalDeform = input.enableTerrainDecalDeform;
			//         passData.fields.planarReflectionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                       (TextureHandle *)&v158,
			//                                                       builder,
			//                                                       &input.planarReflectionTexture,
			//                                                       0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.ssrLightingTexture, 0LL) )
			//         {
			//           Texture = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                       (TextureHandle *)&v158,
			//                       builder,
			//                       &input.ssrLightingTexture,
			//                       0LL);
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           Texture = (TextureHandle *)sub_182E7CCD0(&v158);
			//         }
			//         passData.fields.ssrLightingTexture = *Texture;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.fogBakeLutTexture, 0LL) )
			//           passData.fields.fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                   (TextureHandle *)&v158,
			//                                                   builder,
			//                                                   &input.fogBakeLutTexture,
			//                                                   0LL);
			//         hgrp = input.hgrp;
			//         if ( !hgrp )
			//           sub_180B536AC(v25, v24);
			//         m_CurrentRendererConfigurationBakedLighting = hgrp.fields.m_CurrentRendererConfigurationBakedLighting;
			//         v28 = *(_OWORD *)&builder.m_RenderPass;
			//         forwardOpaqueECSList = input.forwardOpaqueECSList;
			//         opaqueData = passData.fields.opaqueData;
			//         screenCullingLayerMask = input.screenCullingLayerMask;
			//         v30 = input.hgrp;
			//         screenCullingRatioDistance = input.screenCullingRatioDistance;
			//         screenCullingRatio = input.screenCullingRatio;
			//         characterOutlineEnabled = input.characterOutlineEnabled;
			//         characterOutlineOpaqueEqualECSRendererList = input.characterOutlineOpaqueEqualECSRendererList;
			//         characterOutlineOpaqueECSRendererList = input.characterOutlineOpaqueECSRendererList;
			//         methoda = input.characterOpaqueECSList;
			//         shouldSplitOnePassa = input.forwardOpaqueEqualECSList;
			//         cullingResults = (NativeArray_1_UnityEngine_Rendering_VisibleLight_)input.cullingResults;
			//         v31 = *(_OWORD *)&builder.m_RenderGraph;
			//         *(_OWORD *)&v159.enableDeferredShadingDefaultLit = v28;
			//         *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v31;
			//         HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
			//           v30,
			//           renderGraph,
			//           camera,
			//           (HGRenderGraphBuilder *)&v159,
			//           (CullingResults *)&cullingResults,
			//           m_CurrentRendererConfigurationBakedLighting,
			//           forwardOpaqueECSList,
			//           shouldSplitOnePassa,
			//           methoda,
			//           characterOutlineOpaqueECSRendererList,
			//           characterOutlineOpaqueEqualECSRendererList,
			//           characterOutlineEnabled,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           opaqueData,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//         inited = HG::Rendering::Runtime::DeferredLightingPass::InitDeferredLightingRenderParams(&v159, 1, 0LL);
			//         v33 = *(_OWORD *)&inited.drawTileArgs.handle._type_k__BackingField;
			//         *(_QWORD *)&v31 = inited.quadIndexBuffer;
			//         *(_OWORD *)&passData.fields.deferredLightingParams.enableDeferredShadingDefaultLit = *(_OWORD *)&inited.enableDeferredShadingDefaultLit;
			//         *(_OWORD *)&passData.fields.deferredLightingParams.drawTileArgs.handle._type_k__BackingField = v33;
			//         passData.fields.deferredLightingParams.quadIndexBuffer = (GraphicsBuffer *)v31;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&passData.fields.deferredLightingParams.quadIndexBuffer,
			//           v34,
			//           v35,
			//           v36,
			//           outputIndicesc,
			//           inputIndicesc);
			//         if ( passData.fields.deferredLightingParams.enableDeferredShadingTileDraw )
			//         {
			//           passData.fields.deferredLightingParams.drawTileArgs = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//                                                                    builder,
			//                                                                    &input.drawTileArgs,
			//                                                                    0LL);
			//           passData.fields.deferredLightingParams.tileInstanceIndices = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//                                                                           builder,
			//                                                                           &input.tileInstanceIndices,
			//                                                                           0LL);
			//           passData.fields.deferredLightingParams.quadIndexBuffer = input.quadIndexBuffer;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&passData.fields.deferredLightingParams.quadIndexBuffer,
			//             v37,
			//             v38,
			//             v39,
			//             outputIndicesa,
			//             inputIndicesa);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         if ( !HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&input.drawTileArgs, 0LL)
			//           || (sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle),
			//               !HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&input.tileInstanceIndices, 0LL)) )
			//         {
			//           passData.fields.deferredLightingParams.enableDeferredShadingTileDraw = 0;
			//         }
			//         passData.fields.characterOpaqueECSList = input.characterOpaqueECSList;
			//         passData.fields.characterOutlineOpaqueECSRendererList = input.characterOutlineOpaqueECSRendererList;
			//         passData.fields.characterOutlineOpaqueEqualECSRendererList = input.characterOutlineOpaqueEqualECSRendererList;
			//         HasTerrainSimpleSubsurface = HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(0LL);
			//         value = HasTerrainSimpleSubsurface;
			//         m_deferredLightingMaterial = this.fields.m_deferredLightingMaterial;
			//         if ( m_deferredLightingMaterial )
			//         {
			//           shader = UnityEngine::Material::get_shader(m_deferredLightingMaterial, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &keyword,
			//             shader,
			//             TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfileSimple,
			//             0LL);
			//           m_deferredLightingMaterial = this.fields.m_deferredLightingMaterial;
			//           if ( m_deferredLightingMaterial )
			//           {
			//             UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &keyword, HasTerrainSimpleSubsurface, 0LL);
			//             passData.fields.deferredLightingMaterial = this.fields.m_deferredLightingMaterial;
			//             sub_1800054D0(
			//               (HGRenderPathScene *)&passData.fields.deferredLightingMaterial,
			//               v42,
			//               v43,
			//               v44,
			//               outputIndicesa,
			//               inputIndicesa);
			//             v45 = *(_OWORD *)&passData.fields.deferredLightingParams.drawTileArgs.handle._type_k__BackingField;
			//             v46 = *(_QWORD *)&passData.fields.deferredLightingParams.enableDeferredShadingDefaultLit >> 24;
			//             quadIndexBuffer = passData.fields.deferredLightingParams.quadIndexBuffer;
			//             v159.quadIndexBuffer = quadIndexBuffer;
			//             *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v45;
			//             if ( !(_BYTE)v46 )
			//               goto LABEL_43;
			//             v48 = HIWORD(*(_QWORD *)&passData.fields.deferredLightingParams.enableDeferredShadingDefaultLit);
			//             v159.quadIndexBuffer = quadIndexBuffer;
			//             *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v45;
			//             if ( !(_BYTE)v48 )
			//               goto LABEL_43;
			//             v49 = HIDWORD(*(_QWORD *)&passData.fields.deferredLightingParams.enableDeferredShadingDefaultLit);
			//             v159.quadIndexBuffer = quadIndexBuffer;
			//             *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v45;
			//             if ( !(_BYTE)v49 )
			//               goto LABEL_43;
			//             passData.fields.punctualLightCount = input.punctualLightCount;
			//             visibleLights = UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//                               (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v158,
			//                               &input.lightCullResult,
			//                               0LL);
			//             v51 = 0;
			//             v15 = 0LL;
			//             cullingResults = *visibleLights;
			//             while ( 1 )
			//             {
			//               v161 = v15;
			//               m_Length = cullingResults.m_Length;
			//               if ( cullingResults.m_Length >= input.punctualLightCount )
			//                 m_Length = input.punctualLightCount;
			//               if ( v51 >= m_Length )
			//                 break;
			//               v184 = *(VisibleLight *)&cullingResults.m_Buffer[148
			//                                                              * *(int *)((char *)input.punctualLightIndices
			//                                                                       + (unsigned __int64)v15)];
			//               if ( UnityEngine::HGSharedLightData::get_type_Injected(&v184.hgSharedLightData, 0LL) )
			//               {
			//                 UnityEngine::Quaternion::get_identity(&v195, v53);
			//                 one = UnityEngine::Vector3::get_one(&v185, v54);
			//                 v56 = *(_QWORD *)&one.x;
			//                 v163.z = one.z;
			//                 *(_QWORD *)&v163.x = v56;
			//                 v58 = UnityEngine::Vector3::op_Multiply(&v193, &v163, v184.m_Range, v57);
			//                 v59 = *(_QWORD *)&v58.x;
			//                 *(float *)&v58 = v58.z;
			//                 *(_QWORD *)&v177.x = v59;
			//                 LODWORD(v177.z) = (_DWORD)v58;
			//                 v61 = UnityEngine::Vector3::op_Multiply(&v192, &v177, 2.0, v60);
			//                 v62 = *(_QWORD *)&v61.x;
			//                 *(float *)&v61 = v61.z;
			//                 *(_QWORD *)&v164.x = v62;
			//                 LODWORD(v164.z) = (_DWORD)v61;
			//                 v64 = UnityEngine::Vector3::op_Multiply(&v191, &v164, 1.0824, v63);
			//                 v66 = *v65;
			//                 v67 = *(_QWORD *)&v64.x;
			//                 v165.z = v64.z;
			//                 m_WorldPosition = v184.m_WorldPosition;
			//                 *(_QWORD *)&v165.x = v67;
			//                 v160 = (NativeArray_1_System_Int32_)v66;
			//                 v68 = UnityEngine::Matrix4x4::TRS(&v198, &m_WorldPosition, (Quaternion *)&v160, &v165, 0LL);
			//                 v69 = *(_OWORD *)&v68.m00;
			//                 v70 = *(_OWORD *)&v68.m01;
			//                 v71 = *(_OWORD *)&v68.m02;
			//                 v72 = *(_OWORD *)&v68.m03;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 *(_DWORD *)(sub_18046F890(m_deferredLightingMaterial, v51) + 68) = v51;
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 v73 = sub_18046F890(m_deferredLightingMaterial, v51);
			//                 *(_OWORD *)(v73 + 4) = v69;
			//                 *(_OWORD *)(v73 + 20) = v70;
			//                 *(_OWORD *)(v73 + 36) = v71;
			//                 *(_OWORD *)(v73 + 52) = v72;
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 *(_DWORD *)sub_18046F890(m_deferredLightingMaterial, v51) = 1;
			//               }
			//               else
			//               {
			//                 v74 = *(_QWORD *)&v184.m_WorldPosition.x;
			//                 z = v184.m_WorldPosition.z;
			//                 v199 = v184;
			//                 Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v194, &v199, 0LL);
			//                 v77 = *(_QWORD *)&Forward.x;
			//                 *(float *)&Forward = Forward.z;
			//                 *(_QWORD *)&v167.x = v77;
			//                 LODWORD(v167.z) = (_DWORD)Forward;
			//                 v79 = UnityEngine::Vector3::op_Multiply(&v186, &v167, v184.m_Range, v78);
			//                 *(_QWORD *)&v169.x = v74;
			//                 v169.z = z;
			//                 v80 = *(_QWORD *)&v79.x;
			//                 *(float *)&v79 = v79.z;
			//                 *(_QWORD *)&v168.x = v80;
			//                 LODWORD(v168.z) = (_DWORD)v79;
			//                 v82 = UnityEngine::Vector3::op_Addition(&v187, &v169, &v168, v81);
			//                 v83 = *(_QWORD *)&v82.x;
			//                 v84 = v82.z;
			//                 v199 = v184;
			//                 v85 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v188, &v199, 0LL);
			//                 v86 = *(_QWORD *)&v85.x;
			//                 *(float *)&v85 = v85.z;
			//                 *(_QWORD *)&v170.x = v86;
			//                 LODWORD(v170.z) = (_DWORD)v85;
			//                 v88 = UnityEngine::Vector3::op_UnaryNegation(&v189, &v170, v87);
			//                 m_SpotAngle_low = (__m128)LODWORD(v184.m_SpotAngle);
			//                 m_SpotAngle_low.m128_f32[0] = sub_1802ED290(v91, v90, v92, v93);
			//                 v94 = v88.z;
			//                 v95 = m_SpotAngle_low;
			//                 *(_QWORD *)&v171.x = *(_QWORD *)&v88.x;
			//                 v95.m128_f32[0] = m_SpotAngle_low.m128_f32[0] * v184.m_Range;
			//                 v171.z = v94;
			//                 v96 = UnityEngine::Quaternion::LookRotation(&v196, &v171, 0LL);
			//                 v172 = _mm_unpacklo_ps((__m128)0x42B40000u, (__m128)0LL).m128_u64[0];
			//                 v97 = _mm_loadu_si128((const __m128i *)v96);
			//                 v173 = 0;
			//                 v98 = (Quaternion *)sub_182504CA0(v197, &v172);
			//                 v158 = (NativeArray_1_System_Int32_)v97;
			//                 v160 = (NativeArray_1_System_Int32_)*v98;
			//                 UnityEngine::Quaternion::op_Multiply((Quaternion *)&v159, (Quaternion *)&v158, (Quaternion *)&v160, v99);
			//                 v100 = v95;
			//                 v100.m128_f32[0] = v95.m128_f32[0] + v95.m128_f32[0];
			//                 *(_QWORD *)&v174.x = _mm_unpacklo_ps(v100, (__m128)LODWORD(v184.m_Range)).m128_u64[0];
			//                 v174.z = v95.m128_f32[0] + v95.m128_f32[0];
			//                 v102 = UnityEngine::Vector3::op_Multiply(&v190, &v174, 1.0196, v101);
			//                 v104 = *v103;
			//                 *(_QWORD *)&v176.x = v83;
			//                 v105 = *(_QWORD *)&v102.x;
			//                 *(float *)&v102 = v102.z;
			//                 *(_QWORD *)&v175.x = v105;
			//                 LODWORD(v175.z) = (_DWORD)v102;
			//                 v158 = v104;
			//                 v176.z = v84;
			//                 v106 = UnityEngine::Matrix4x4::TRS(&v198, &v176, (Quaternion *)&v158, &v175, 0LL);
			//                 v107 = *(_OWORD *)&v106.m00;
			//                 v108 = *(_OWORD *)&v106.m01;
			//                 v109 = *(_OWORD *)&v106.m02;
			//                 v110 = *(_OWORD *)&v106.m03;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 *(_DWORD *)(sub_18046F890(m_deferredLightingMaterial, v51) + 68) = v51;
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 v111 = sub_18046F890(m_deferredLightingMaterial, v51);
			//                 *(_OWORD *)(v111 + 4) = v107;
			//                 *(_OWORD *)(v111 + 20) = v108;
			//                 *(_OWORD *)(v111 + 36) = v109;
			//                 *(_OWORD *)(v111 + 52) = v110;
			//                 m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 if ( !m_deferredLightingMaterial )
			//                   goto LABEL_45;
			//                 *(_DWORD *)sub_18046F890(m_deferredLightingMaterial, v51) = 0;
			//               }
			//               ++v51;
			//               v15 = (HGRenderPathBase_HGRenderPathResources *)((char *)&v161.defaultResources + 4);
			//             }
			//             m_deferredLightingMaterial = this.fields.m_deferredLightingPerLightMeshMaterial;
			//             if ( m_deferredLightingMaterial )
			//             {
			//               v112 = UnityEngine::Material::get_shader(m_deferredLightingMaterial, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                 &v183,
			//                 v112,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfileSimple,
			//                 0LL);
			//               m_deferredLightingMaterial = this.fields.m_deferredLightingPerLightMeshMaterial;
			//               if ( m_deferredLightingMaterial )
			//               {
			//                 UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &v183, value, 0LL);
			//                 passData.fields.deferredLightingPerLightMaterial = this.fields.m_deferredLightingPerLightMeshMaterial;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&passData.fields.deferredLightingPerLightMaterial,
			//                   v113,
			//                   v114,
			//                   v115,
			//                   outputIndicesb,
			//                   inputIndicesb);
			//                 m_sphereMesh = this.fields.m_sphereMesh;
			//                 passData.fields.sphereMesh = m_sphereMesh;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&passData.fields.sphereMesh,
			//                   v117,
			//                   v118,
			//                   (HGCamera *)m_sphereMesh,
			//                   outputIndicesd,
			//                   inputIndicesd);
			//                 m_coneMesh = this.fields.m_coneMesh;
			//                 passData.fields.coneMesh = m_coneMesh;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&passData.fields.coneMesh,
			//                   v120,
			//                   v121,
			//                   (HGCamera *)m_coneMesh,
			//                   outputIndicese,
			//                   inputIndicese);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//                 passData.fields.lightMeshDrawRequests = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_lightMeshDrawRequests;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&passData.fields.lightMeshDrawRequests,
			//                   v122,
			//                   v123,
			//                   v124,
			//                   outputIndicesf,
			//                   inputIndicesf);
			// LABEL_43:
			//                 HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//                   this,
			//                   OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_DeferredLighting,
			//                   count.Item1,
			//                   count.Item2,
			//                   &v178,
			//                   &v179,
			//                   &depthAsInput,
			//                   shouldSplitOnePass,
			//                   0LL);
			//                 v125 = v178;
			//                 v126 = v179;
			//                 v127 = depthAsInput;
			//                 v128 = (*subpassIndex)++;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//                 v158 = v126;
			//                 v160 = v125;
			//                 sub_180830AC4(
			//                   (_DWORD)builder,
			//                   v128,
			//                   (unsigned int)&v160,
			//                   (unsigned int)&v158,
			//                   v127,
			//                   (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_deferredLightingRenderFunc,
			//                   0);
			//                 HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
			//                   this,
			//                   OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_ForwardOpaque,
			//                   count.Item1,
			//                   count.Item2,
			//                   &v181,
			//                   &v180,
			//                   &v156,
			//                   shouldSplitOnePass,
			//                   0LL);
			//                 v129 = *subpassIndex;
			//                 v130 = v181;
			//                 v158 = v180;
			//                 *subpassIndex = v129 + 1;
			//                 v160 = v130;
			//                 sub_180830AC4(
			//                   (_DWORD)builder,
			//                   v129,
			//                   (unsigned int)&v160,
			//                   (unsigned int)&v158,
			//                   v156,
			//                   (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor.static_fields.s_optForwardOpaqueFunc,
			//                   4);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_45:
			//     sub_180B536AC(m_deferredLightingMaterial, v15);
			//   }
			//   m_deferredLightingMaterial = (Material *)IFix::WrappersManagerImpl::GetPatch(2744, 0LL);
			//   if ( !m_deferredLightingMaterial )
			//     goto LABEL_45;
			//   v131 = *(_OWORD *)&builder.m_RenderGraph;
			//   *(_OWORD *)&v159.enableDeferredShadingDefaultLit = *(_OWORD *)&builder.m_RenderPass;
			//   *(_OWORD *)&v159.drawTileArgs.handle._type_k__BackingField = v131;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1005(
			//     (ILFixDynamicMethodWrapper_2 *)m_deferredLightingMaterial,
			//     (Object *)this,
			//     (HGRenderGraphBuilder *)&v159,
			//     input,
			//     output,
			//     subpassIndex,
			//     (Object *)passData,
			//     (Object *)renderGraph,
			//     (Object *)camera,
			//     count,
			//     shouldSplitOnePass,
			//     0LL);
			// }
			// 
		}

		internal void ConstructPassPhase0(ref OnePassDeferredPassConstructor.PassInput input, ref OnePassDeferredPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPassPhase0(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase0(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         OnePassDeferredPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // r8d
			//   ValueTuple_2_Int32_Int32_ v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int32_t v18; // [rsp+50h] [rbp-78h] BYREF
			//   OnePassDeferredPassConstructor_OnePassDeferredData *v19; // [rsp+58h] [rbp-70h] BYREF
			//   Il2CppExceptionWrapper *v20; // [rsp+60h] [rbp-68h] BYREF
			//   _QWORD v21[2]; // [rsp+68h] [rbp-60h] BYREF
			//   HGRenderGraphBuilder v22; // [rsp+78h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v23; // [rsp+A0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919599 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500EF8);
			//     byte_18D919599 = 1;
			//   }
			//   memset(&v22, 0, sizeof(v22));
			//   v19 = 0LL;
			//   v18 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2745, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2745, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1006(
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
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x17u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     v22 = *(HGRenderGraphBuilder *)sub_180830B24(
			//                                      (unsigned int)&v23,
			//                                      (_DWORD)renderGraph,
			//                                      v13,
			//                                      (unsigned int)&v19,
			//                                      (__int64)v10);
			//     v21[0] = 0LL;
			//     v21[1] = &v22;
			//     try
			//     {
			//       v23 = v22;
			//       v14 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(this, input, &v23, 1, 0LL);
			//       v23 = v22;
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
			//         this,
			//         &v23,
			//         input,
			//         output,
			//         &v18,
			//         v19,
			//         renderGraph,
			//         camera,
			//         v14,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       v21[0] = v20.ex;
			//     }
			//     sub_180222690(v21);
			//   }
			// }
			// 
		}

		internal void ConstructPassPhase1(ref OnePassDeferredPassConstructor.PassInput input, ref OnePassDeferredPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPassPhase1(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase1(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_PassInput *input,
			//         OnePassDeferredPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // r8d
			//   ValueTuple_2_Int32_Int32_ v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int32_t v18; // [rsp+60h] [rbp-78h] BYREF
			//   OnePassDeferredPassConstructor_OnePassDeferredData *v19; // [rsp+68h] [rbp-70h] BYREF
			//   Il2CppExceptionWrapper *v20; // [rsp+70h] [rbp-68h] BYREF
			//   _QWORD v21[2]; // [rsp+78h] [rbp-60h] BYREF
			//   HGRenderGraphBuilder v22; // [rsp+88h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v23; // [rsp+B0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91959A )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500EF8);
			//     byte_18D91959A = 1;
			//   }
			//   memset(&v22, 0, sizeof(v22));
			//   v19 = 0LL;
			//   v18 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2746, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2746, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1006(
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
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x17u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     v22 = *(HGRenderGraphBuilder *)sub_180830B24(
			//                                      (unsigned int)&v23,
			//                                      (_DWORD)renderGraph,
			//                                      v13,
			//                                      (unsigned int)&v19,
			//                                      (__int64)v10);
			//     v21[0] = 0LL;
			//     v21[1] = &v22;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v22, 0, 0LL);
			//       v23 = v22;
			//       v14 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(this, input, &v23, 0, 0LL);
			//       v23 = v22;
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
			//         this,
			//         &v23,
			//         input,
			//         output,
			//         &v18,
			//         v19,
			//         renderGraph,
			//         camera,
			//         v14,
			//         1,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       v21[0] = v20.ex;
			//     }
			//     sub_180222690(v21);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         OnePassDeferredPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2747, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2747, 0LL);
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
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         OnePassDeferredPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2748, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2748, 0LL);
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

		[IDTag(0)]
		private int GetAttachmentIndex(OnePassDeferredPassConstructor.FixedAttachment fixedAttachment)
		{
			// // Int32 GetAttachmentIndex(OnePassDeferredPassConstructor+FixedAttachment)
			// int32_t HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_FixedAttachment__Enum fixedAttachment,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rbx
			//   __int64 v5; // rdx
			//   Int32__Array *m_attachmentMapping; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = (int)fixedAttachment;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2737, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2737, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//                (ILFixDynamicMethodWrapper_20 *)Patch,
			//                (Object *)this,
			//                v3,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(m_attachmentMapping, v5);
			//   }
			//   m_attachmentMapping = this.fields.m_attachmentMapping;
			//   if ( !m_attachmentMapping )
			//     goto LABEL_7;
			//   if ( (unsigned int)v3 >= m_attachmentMapping.max_length.size )
			//     sub_180070270(m_attachmentMapping, v5);
			//   return m_attachmentMapping.vector[v3];
			// }
			// 
			return 0;
		}

		[IDTag(0)]
		private void SetAttachmentIndex(OnePassDeferredPassConstructor.FixedAttachment fixedAttachment, int index)
		{
			// // Void SetAttachmentIndex(OnePassDeferredPassConstructor+FixedAttachment, Int32)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//         OnePassDeferredPassConstructor *this,
			//         OnePassDeferredPassConstructor_FixedAttachment__Enum fixedAttachment,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   __int64 v7; // rdx
			//   Int32__Array *m_attachmentMapping; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = (int)fixedAttachment;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2734, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2734, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//         (ILFixDynamicMethodWrapper_20 *)Patch,
			//         (Object *)this,
			//         v4,
			//         index,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_attachmentMapping, v7);
			//   }
			//   m_attachmentMapping = this.fields.m_attachmentMapping;
			//   if ( !m_attachmentMapping )
			//     goto LABEL_7;
			//   if ( (unsigned int)v4 >= m_attachmentMapping.max_length.size )
			//     sub_180070270(m_attachmentMapping, v7);
			//   m_attachmentMapping.vector[v4] = index;
			// }
			// 
		}

		[IDTag(1)]
		private int GetAttachmentIndex(GBufferID gBufferID)
		{
			// // Int32 GetAttachmentIndex(GBufferID)
			// int32_t HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
			//         OnePassDeferredPassConstructor *this,
			//         GBufferID__Enum gBufferID,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   __int64 v5; // rdx
			//   Int32__Array *m_attachmentMapping; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = (int)gBufferID;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2738, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2738, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//                (ILFixDynamicMethodWrapper_20 *)Patch,
			//                (Object *)this,
			//                v3,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(m_attachmentMapping, v5);
			//   }
			//   m_attachmentMapping = this.fields.m_attachmentMapping;
			//   if ( !m_attachmentMapping )
			//     goto LABEL_7;
			//   if ( (unsigned int)(v3 + 2) >= m_attachmentMapping.max_length.size )
			//     sub_180070270(m_attachmentMapping, v5);
			//   return m_attachmentMapping.vector[v3 + 2];
			// }
			// 
			return 0;
		}

		[IDTag(1)]
		private void SetAttachmentIndex(GBufferID gBufferID, int index)
		{
			// // Void SetAttachmentIndex(GBufferID, Int32)
			// void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
			//         OnePassDeferredPassConstructor *this,
			//         GBufferID__Enum gBufferID,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rsi
			//   __int64 v7; // rdx
			//   Int32__Array *m_attachmentMapping; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = (int)gBufferID;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2735, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2735, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//         (ILFixDynamicMethodWrapper_20 *)Patch,
			//         (Object *)this,
			//         v4,
			//         index,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_attachmentMapping, v7);
			//   }
			//   m_attachmentMapping = this.fields.m_attachmentMapping;
			//   if ( !m_attachmentMapping )
			//     goto LABEL_7;
			//   if ( (unsigned int)(v4 + 2) >= m_attachmentMapping.max_length.size )
			//     sub_180070270(m_attachmentMapping, v7);
			//   m_attachmentMapping.vector[v4 + 2] = index;
			// }
			// 
		}

		private const string HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED = "HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED";

		private int[] m_attachmentMapping;

		private Material m_deferredLightingMaterial;

		private Material m_deferredLightingPerLightMeshMaterial;

		private Mesh m_sphereMesh;

		private Mesh m_coneMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static DeferredLightingPass.LightMeshDrawRequest[] s_lightMeshDrawRequests;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<OnePassDeferredPassConstructor.OnePassDeferredData> s_preDepthRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<OnePassDeferredPassConstructor.OnePassDeferredData> s_gBufferRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<OnePassDeferredPassConstructor.OnePassDeferredData> s_decalRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<OnePassDeferredPassConstructor.OnePassDeferredData> s_deferredLightingRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly RenderFunc<OnePassDeferredPassConstructor.OnePassDeferredData> s_optForwardOpaqueFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle sceneMV;

			internal TextureHandle planarReflectionTexture;

			internal TextureHandle fogBakeLutTexture;

			internal TextureHandle ssrLightingTexture;

			internal CullingResults cullingResults;

			internal LightCullResult lightCullResult;

			internal ShadowResult shadowResult;

			internal HGRenderPipeline hgrp;

			internal GBufferOutput gBufferOutput;

			internal bool characterOutlineEnabled;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal uint deferredOpaquePreZECSList;

			internal uint forwardOpaquePreZECSList;

			internal uint deferredGrassPreZECSList;

			internal uint deferredOpaqueECSList;

			internal uint deferredOpaqueEqualECSList;

			internal uint deferredGrassECSList;

			internal uint deferredSludgeECSList;

			internal uint deferredDecalMobileECSList;

			internal uint deferredErosionMobileECSList;

			internal uint forwardOpaqueECSList;

			internal uint forwardOpaqueEqualECSList;

			internal uint characterOpaqueECSList;

			internal uint characterPrePassECSList;

			internal uint characterOutlineOpaqueECSRendererList;

			internal uint characterOutlineOpaqueEqualECSRendererList;

			internal ComputeBufferHandle drawTileArgs;

			internal ComputeBufferHandle tileInstanceIndices;

			internal GraphicsBuffer quadIndexBuffer;

			internal int punctualLightCount;

			internal unsafe int* punctualLightIndices;

			internal bool enableTerrainDecalDeform;

			internal bool enableTerrainWetRipple;
		}

		internal struct PassOutput
		{
		}

		private class OnePassDeferredData
		{
			public OnePassDeferredData()
			{
			}

			internal bool shouldSplitOnePass;

			internal HGCamera camera;

			public int vtFeedbackId;

			internal int subdivisionHandle;

			internal uint terrainCullViewHandle;

			internal uint editorTerrainCullViewHandle;

			internal bool enableTerrainDecalDeform;

			internal bool enableTerrainWetRipple;

			internal TextureHandle planarReflectionTexture;

			internal TextureHandle fogBakeLutTexture;

			internal TextureHandle ssrLightingTexture;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle[] gbuffer;

			internal RendererListHandle preDepthRendererList;

			internal RendererListHandle characterPrePassRendererList;

			internal RendererListHandle gBufferRendererList;

			internal RendererListHandle erosionMobileRendererList;

			internal uint deferredOpaquePreZECSList;

			internal uint forwardOpaquePreZECSList;

			internal uint deferredGrassPreZECSList;

			internal uint deferredOpaqueECSList;

			internal uint deferredOpaqueEqualECSList;

			internal uint deferredGrassECSList;

			internal uint deferredSludgeECSList;

			internal uint deferredDecalMobileECSList;

			internal uint deferredErosionMobileECSList;

			internal uint characterOpaqueECSList;

			internal uint characterPrePassECSList;

			internal uint characterOutlineOpaqueECSRendererList;

			internal uint characterOutlineOpaqueEqualECSRendererList;

			internal DeferredLightingPass.DeferredLightingRenderParams deferredLightingParams;

			internal Material deferredLightingMaterial;

			internal Material deferredLightingPerLightMaterial;

			internal Mesh sphereMesh;

			internal Mesh coneMesh;

			internal int punctualLightCount;

			internal DeferredLightingPass.LightMeshDrawRequest[] lightMeshDrawRequests;

			internal ForwardPassUtils.ForwardOpaquePassData opaqueData;
		}

		private enum OnePassDeferredSubpass
		{
			PreDepth,
			GBuffer,
			Decal,
			PostGBuffer,
			DeferredLighting,
			ForwardOpaque,
			ForwardTransparent,
			Count
		}

		private enum FixedAttachment
		{
			SceneColor,
			MotionVector,
			Count
		}
	}
}
