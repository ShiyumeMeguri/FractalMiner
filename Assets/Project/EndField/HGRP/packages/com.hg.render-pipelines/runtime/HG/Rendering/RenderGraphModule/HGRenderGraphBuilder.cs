using System;
using System.Runtime.InteropServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGRenderGraphBuilder : IDisposable
	{
		internal HGRenderGraphBuilder(HGRenderGraphPass renderPass, HGRenderGraphResourceRegistry resources, HGRenderGraph renderGraph)
		{
		}

		[IDTag(0)]
		public TextureHandle SetColorAttachment(in TextureHandle input, int index, [MetadataOffset(Offset = "0x01F909EE")] uint depthSlice = 0U)
		{
			// // TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, UInt32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         int32_t index,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v12; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v14; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(220, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(220, 0LL);
			//     if ( Patch )
			//     {
			//       v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_107(&v14, Patch, this, input, index, depthSlice, 0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, Patch);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 1, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   v14 = *input;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//     (HGRenderGraphPass *)m_Resources,
			//     &v14,
			//     index,
			//     depthSlice,
			//     0LL);
			//   v12 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v12;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public TextureHandle SetColorAttachment(in TextureHandle input, int index, Color clearColor, [MetadataOffset(Offset = "0x01F909EF")] uint depthSlice = 0U)
		{
			// // TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, Color, UInt32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         int32_t index,
			//         Color *clearColor,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   Color v13; // xmm0
			//   TextureHandle v14; // xmm0
			//   TextureHandle *result; // rax
			//   Color v16; // [rsp+40h] [rbp-28h] BYREF
			//   TextureHandle v17; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(228, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(228, 0LL);
			//     if ( Patch )
			//     {
			//       v17 = (TextureHandle)*clearColor;
			//       v14 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_108(
			//                (TextureHandle *)&v16,
			//                Patch,
			//                this,
			//                input,
			//                index,
			//                (Color *)&v17,
			//                depthSlice,
			//                0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, Patch);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 1, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   v13 = *clearColor;
			//   v17 = *input;
			//   v16 = v13;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//     (HGRenderGraphPass *)m_Resources,
			//     &v17,
			//     index,
			//     &v16,
			//     depthSlice,
			//     0LL);
			//   v14 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v14;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public TextureHandle SetColorAttachment(in TextureHandle input, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Color clearColor, [MetadataOffset(Offset = "0x01F909F0")] uint depthSlice = 0U)
		{
			// // TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         int32_t index,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         Color *clearColor,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v15; // xmm1
			//   TextureHandle v16; // xmm0
			//   TextureHandle *result; // rax
			//   Color v18; // [rsp+50h] [rbp-28h] BYREF
			//   TextureHandle v19; // [rsp+60h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(229, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(229, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = (TextureHandle)*clearColor;
			//       v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_110(
			//                (TextureHandle *)&v18,
			//                Patch,
			//                this,
			//                input,
			//                index,
			//                loadAction,
			//                storeAction,
			//                (Color *)&v19,
			//                depthSlice,
			//                0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, Patch);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 1, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   v15 = *input;
			//   v18 = *clearColor;
			//   v19 = v15;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//     (HGRenderGraphPass *)m_Resources,
			//     &v19,
			//     index,
			//     loadAction,
			//     storeAction,
			//     &v18,
			//     depthSlice,
			//     0LL);
			//   v16 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v16;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public TextureHandle SetDepthAttachment(in TextureHandle input, DepthAccess flags, [MetadataOffset(Offset = "0x01F909F1")] uint depthSlice = 0U)
		{
			// // TextureHandle SetDepthAttachment(TextureHandle ByRef, DepthAccess, UInt32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         DepthAccess__Enum flags,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v12; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v14; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(231, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(231, 0LL);
			//     if ( Patch )
			//     {
			//       v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_112(&v14, Patch, this, input, flags, depthSlice, 0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, Patch);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 1, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   v14 = *input;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
			//     (HGRenderGraphPass *)m_Resources,
			//     &v14,
			//     flags,
			//     depthSlice,
			//     0LL);
			//   v12 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v12;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public TextureHandle SetDepthAttachment(in TextureHandle input, DepthAccess flags, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, [MetadataOffset(Offset = "0x01F909F2")] uint depthSlice = 0U)
		{
			// // TextureHandle SetDepthAttachment(TextureHandle ByRef, DepthAccess, RenderBufferLoadAction, RenderBufferStoreAction, Single, Byte, UInt32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         DepthAccess__Enum flags,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         float clearDepth,
			//         uint8_t clearStencil,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v16; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v18; // [rsp+60h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(234, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(234, 0LL);
			//     if ( Patch )
			//     {
			//       v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
			//                &v18,
			//                Patch,
			//                this,
			//                input,
			//                flags,
			//                loadAction,
			//                storeAction,
			//                clearDepth,
			//                clearStencil,
			//                depthSlice,
			//                0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, Patch);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 1, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   v18 = *input;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
			//     (HGRenderGraphPass *)m_Resources,
			//     &v18,
			//     flags,
			//     loadAction,
			//     storeAction,
			//     clearDepth,
			//     clearStencil,
			//     depthSlice,
			//     0LL);
			//   v16 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v16;
			//   return result;
			// }
			// 
			return null;
		}

		public TextureHandle ReadTexture(in TextureHandle input)
		{
			// // TextureHandle ReadTexture(TextureHandle ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *m_RenderGraph; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   MethodInfo *v9; // rdx
			//   TextureDesc *TextureResourceDesc; // rcx
			//   __m128i v11; // xmm7
			//   Quaternion *identity; // rax
			//   HGRenderGraphResourceRegistry *v13; // rcx
			//   TextureHandle v14; // xmm0
			//   TextureDimension__Enum dimension; // eax
			//   RTHandle__Array *v16; // rax
			//   RTHandle__Array *v17; // rax
			//   RTHandle__Array *m_CurrentBackbuffer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle *result; // rax
			//   Quaternion v21[7]; // [rsp+38h] [rbp-D0h] BYREF
			//   TextureDesc v22; // [rsp+A8h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D919353 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::TextureXR);
			//     byte_18D919353 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(236, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(236, 0LL);
			//     if ( Patch )
			//     {
			//       v14 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_118((TextureHandle *)v21, Patch, this, input, 0LL);
			//       goto LABEL_30;
			//     }
			//     goto LABEL_28;
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 0, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_28;
			//   if ( HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//          m_Resources,
			//          &input.handle,
			//          0LL) )
			//   {
			//     goto LABEL_14;
			//   }
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_28;
			//   if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsFallback(m_Resources, input, 0LL) )
			//     goto LABEL_14;
			//   m_RenderGraph = this.m_Resources;
			//   if ( !m_RenderGraph )
			//     goto LABEL_28;
			//   TextureResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
			//                           &v22,
			//                           m_RenderGraph,
			//                           &input.handle,
			//                           0LL);
			//   v11 = *(__m128i *)&TextureResourceDesc.colorFormat;
			//   if ( !(unsigned __int8)*(_DWORD *)&TextureResourceDesc.bindTextureMS )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::TextureXR);
			//     dimension = UnityEngine::Rendering::TextureXR::get_dimension(0LL);
			//     m_RenderGraph = (HGRenderGraphResourceRegistry *)this.m_RenderGraph;
			//     m_Resources = (HGRenderGraphResourceRegistry *)(unsigned int)_mm_cvtsi128_si32(_mm_srli_si128(v11, 12));
			//     if ( (_DWORD)m_Resources == dimension )
			//     {
			//       if ( m_RenderGraph )
			//       {
			//         m_CurrentBackbuffer = m_RenderGraph.fields.m_CurrentBackbuffer;
			//         if ( m_CurrentBackbuffer )
			//         {
			//           v14 = *(TextureHandle *)&m_CurrentBackbuffer.vector[18];
			//           goto LABEL_30;
			//         }
			//       }
			//     }
			//     else if ( _mm_srli_si128(v11, 8).m128i_i32[1] == 3 )
			//     {
			//       if ( m_RenderGraph )
			//       {
			//         v17 = m_RenderGraph.fields.m_CurrentBackbuffer;
			//         if ( v17 )
			//         {
			//           v14 = *(TextureHandle *)&v17.vector[24];
			//           goto LABEL_30;
			//         }
			//       }
			//     }
			//     else if ( m_RenderGraph )
			//     {
			//       v16 = m_RenderGraph.fields.m_CurrentBackbuffer;
			//       if ( v16 )
			//       {
			//         v14 = *(TextureHandle *)&v16.vector[6];
			//         goto LABEL_30;
			//       }
			//     }
			// LABEL_28:
			//     sub_180B536AC(m_Resources, m_RenderGraph);
			//   }
			//   if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&TextureResourceDesc.fastMemoryDesc.inFastMemory, 13)) )
			//   {
			//     identity = UnityEngine::Quaternion::get_identity(v21, v9);
			//     if ( !this.m_Resources )
			//       goto LABEL_28;
			//     v13 = this.m_Resources;
			//     v21[0] = *identity;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ForceTextureClear(
			//       v13,
			//       &input.handle,
			//       (Color *)v21,
			//       0LL);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture((TextureHandle *)v21, this, input, 0LL);
			// LABEL_14:
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_28;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
			//     (HGRenderGraphPass *)m_Resources,
			//     &input.handle,
			//     0LL);
			//   v14 = *input;
			// LABEL_30:
			//   result = retstr;
			//   *retstr = v14;
			//   return result;
			// }
			// 
			return null;
		}

		public TextureHandle WriteTexture(in TextureHandle input)
		{
			// // TextureHandle WriteTexture(TextureHandle ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v9; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle *result; // rax
			//   TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(244, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(244, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_118(&v12, Patch, this, input, 0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_Resources, v7);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 0, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_6;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
			//     (HGRenderGraphPass *)m_Resources,
			//     &input.handle,
			//     0LL);
			//   v9 = *input;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v9;
			//   return result;
			// }
			// 
			return null;
		}

		public TextureHandle ReadWriteTexture(in TextureHandle input)
		{
			// // TextureHandle ReadWriteTexture(TextureHandle ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   TextureHandle v9; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle *result; // rax
			//   TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(245, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(245, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_118(&v12, Patch, this, input, 0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_Resources, v7);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 0, 0LL);
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_7;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input.handle, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_7;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
			//     (HGRenderGraphPass *)m_Resources,
			//     &input.handle,
			//     0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_7;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
			//     (HGRenderGraphPass *)m_Resources,
			//     &input.handle,
			//     0LL);
			//   v9 = *input;
			// LABEL_9:
			//   result = retstr;
			//   *retstr = v9;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public TextureHandle CreateTransientTexture(ref TextureDesc desc)
		{
			// // TextureHandle CreateTransientTexture(TextureDesc ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureDesc *desc,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   TextureHandle *Texture; // rax
			//   TextureHandle v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle *result; // rax
			//   ResourceHandle res[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(246, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(246, 0LL);
			//     if ( Patch )
			//     {
			//       v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_119((TextureHandle *)res, Patch, this, desc, 0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_RenderPass, m_Resources);
			//   }
			//   m_Resources = this.m_Resources;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_7;
			//   if ( !m_Resources )
			//     goto LABEL_7;
			//   Texture = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
			//               (TextureHandle *)res,
			//               m_Resources,
			//               desc,
			//               this.m_RenderPass.fields._index_k__BackingField,
			//               0LL);
			//   m_RenderPass = this.m_RenderPass;
			//   *(TextureHandle *)&res[0].m_Value = *Texture;
			//   if ( !m_RenderPass )
			//     goto LABEL_7;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(m_RenderPass, res, 0LL);
			//   v10 = *(TextureHandle *)&res[0].m_Value;
			// LABEL_9:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public TextureHandle CreateTransientTexture(ref TextureHandle texture)
		{
			// // TextureHandle CreateTransientTexture(TextureHandle ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphBuilder *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v7; // rdx
			//   void *m_Resources; // rcx
			//   TextureDesc *TextureResourceDescRef; // rax
			//   TextureHandle *v10; // rax
			//   TextureHandle v11; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle *result; // rax
			//   ResourceHandle res[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(248, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(248, 0LL);
			//     if ( Patch )
			//     {
			//       v11 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_120((TextureHandle *)res, Patch, this, texture, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_Resources, v7);
			//   }
			//   m_Resources = this.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_8;
			//   TextureResourceDescRef = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
			//                              (HGRenderGraphResourceRegistry *)m_Resources,
			//                              &texture.handle,
			//                              0LL);
			//   m_Resources = this.m_RenderPass;
			//   v7 = this.m_Resources;
			//   if ( !this.m_RenderPass )
			//     goto LABEL_8;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
			//           (TextureHandle *)res,
			//           v7,
			//           TextureResourceDescRef,
			//           *((_DWORD *)m_Resources + 6),
			//           0LL);
			//   m_Resources = this.m_RenderPass;
			//   *(TextureHandle *)&res[0].m_Value = *v10;
			//   if ( !m_Resources )
			//     goto LABEL_8;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource((HGRenderGraphPass *)m_Resources, res, 0LL);
			//   v11 = *(TextureHandle *)&res[0].m_Value;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		public RendererListHandle UseRendererList(in RendererListHandle input)
		{
			// // RendererListHandle UseRendererList(RendererListHandle ByRef)
			// RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//         HGRenderGraphBuilder *this,
			//         RendererListHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(249, 0LL) )
			//   {
			//     if ( !HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(input, 0LL) )
			//       return *input;
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(m_RenderPass, *input, 0LL);
			//       return *input;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(249, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(Patch, this, input, 0LL);
			// }
			// 
			return null;
		}

		public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input)
		{
			// // ComputeBufferHandle ReadComputeBuffer(ComputeBufferHandle ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//         HGRenderGraphBuilder *this,
			//         ComputeBufferHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(251, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 0, 0LL);
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(m_RenderPass, &input.handle, 0LL);
			//       return *input;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(251, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_123(Patch, this, input, 0LL);
			// }
			// 
			return null;
		}

		public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input)
		{
			// // ComputeBufferHandle WriteComputeBuffer(ComputeBufferHandle ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//         HGRenderGraphBuilder *this,
			//         ComputeBufferHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(252, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input.handle, 0, 0LL);
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(m_RenderPass, &input.handle, 0LL);
			//       m_RenderPass = (HGRenderGraphPass *)this.m_Resources;
			//       if ( m_RenderPass )
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(
			//           (HGRenderGraphResourceRegistry *)m_RenderPass,
			//           &input.handle,
			//           0LL);
			//         return *input;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(252, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_123(Patch, this, input, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc)
		{
			// // ComputeBufferHandle CreateTransientComputeBuffer(ComputeBufferDesc ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(
			//         HGRenderGraphBuilder *this,
			//         ComputeBufferDesc *desc,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ComputeBufferHandle ComputeBuffer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle res; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(253, 0LL) )
			//   {
			//     m_Resources = this.m_Resources;
			//     if ( this.m_RenderPass )
			//     {
			//       if ( m_Resources )
			//       {
			//         ComputeBuffer = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
			//                           m_Resources,
			//                           desc,
			//                           this.m_RenderPass.fields._index_k__BackingField,
			//                           0LL);
			//         m_Resources = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//         res = ComputeBuffer.handle;
			//         if ( m_Resources )
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
			//             (HGRenderGraphPass *)m_Resources,
			//             &res,
			//             0LL);
			//           return (ComputeBufferHandle)res;
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(253, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_124(Patch, this, desc, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer)
		{
			// // ComputeBufferHandle CreateTransientComputeBuffer(ComputeBufferHandle ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(
			//         HGRenderGraphBuilder *this,
			//         ComputeBufferHandle *computebuffer,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v5; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   ComputeBufferDesc *ComputeBufferResourceDesc; // rax
			//   HGRenderGraphPass *m_RenderPass; // r8
			//   ComputeBufferHandle v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferDesc desc; // [rsp+20h] [rbp-38h] BYREF
			//   ComputeBufferDesc v13; // [rsp+38h] [rbp-20h] BYREF
			//   ResourceHandle res; // [rsp+78h] [rbp+20h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(254, 0LL) )
			//   {
			//     m_Resources = this.m_Resources;
			//     if ( m_Resources )
			//     {
			//       ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
			//                                     &v13,
			//                                     m_Resources,
			//                                     &computebuffer.handle,
			//                                     0LL);
			//       m_RenderPass = this.m_RenderPass;
			//       v5 = this.m_Resources;
			//       desc = *ComputeBufferResourceDesc;
			//       if ( m_RenderPass )
			//       {
			//         if ( v5 )
			//         {
			//           v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
			//                  v5,
			//                  &desc,
			//                  m_RenderPass.fields._index_k__BackingField,
			//                  0LL);
			//           v5 = (HGRenderGraphResourceRegistry *)this.m_RenderPass;
			//           res = v9.handle;
			//           if ( v5 )
			//           {
			//             HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
			//               (HGRenderGraphPass *)v5,
			//               &res,
			//               0LL);
			//             return (ComputeBufferHandle)res;
			//           }
			//         }
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, m_Resources);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(254, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_123(Patch, this, computebuffer, 0LL);
			// }
			// 
			return null;
		}

		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera = null, [MetadataOffset(Offset = "0x01F909F3")] int funcIndex = 0) where PassData : class, new()
		{
		}

		public unsafe void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera, void* customPayload, [MetadataOffset(Offset = "0x01F909F4")] int funcIndex = 0) where PassData : class, new()
		{
		}

		public void SetPreRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		public void SetPostRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass) where PassData : class, new()
		{
		}

		public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload) where PassData : class, new()
		{
		}

		public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera = null) where PassData : class, new()
		{
		}

		public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload) where PassData : class, new()
		{
		}

		public void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		public unsafe void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload) where PassData : class, new()
		{
		}

		public void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		public unsafe void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload) where PassData : class, new()
		{
		}

		public void AddChildPass(HGRenderGraphBuilder builder)
		{
			// // Void AddChildPass(HGRenderGraphBuilder)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AddChildPass(
			//         HGRenderGraphBuilder *this,
			//         HGRenderGraphBuilder *builder,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v8; // xmm1
			//   HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(255, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddChildPass(m_RenderPass, builder.m_RenderPass, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(255, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v8 = *(_OWORD *)&builder.m_RenderGraph;
			//   *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//   *(_OWORD *)&v9.m_RenderGraph = v8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_125(Patch, this, &v9, 0LL);
			// }
			// 
		}

		public void EnableAsyncCompute(bool value)
		{
			// // Void EnableAsyncCompute(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::EnableAsyncCompute(
			//         HGRenderGraphBuilder *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(257, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::EnableAsyncCompute(m_RenderPass, value, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(257, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, this, value, 0LL);
			// }
			// 
		}

		public void AllowPassCulling(bool value)
		{
			// // Void AllowPassCulling(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(
			//         HGRenderGraphBuilder *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(199, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowPassCulling(m_RenderPass, value, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(199, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, this, value, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(HGRenderGraphBuilder *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(205, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(205, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_97(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(this, 1, 0LL);
			//   }
			// }
			// 
		}

		public void AllowRendererListCulling(bool value)
		{
			// // Void AllowRendererListCulling(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(
			//         HGRenderGraphBuilder *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(260, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowRendererListCulling(m_RenderPass, value, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(260, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, this, value, 0LL);
			// }
			// 
		}

		public RendererListHandle DependsOn(in RendererListHandle input)
		{
			// // RendererListHandle DependsOn(RendererListHandle ByRef)
			// RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DependsOn(
			//         HGRenderGraphBuilder *this,
			//         RendererListHandle *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(263, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(m_RenderPass, *input, 0LL);
			//       return *input;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(263, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(Patch, this, input, 0LL);
			// }
			// 
			return null;
		}

		public bool DepthRequiredIfMRT()
		{
			// // Boolean DepthRequiredIfMRT()
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DepthRequiredIfMRT(
			//         HGRenderGraphBuilder *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   HGRenderGraphPass *m_RenderPass; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(264, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//       return sub_1800023D0(9LL, m_RenderPass);
			// LABEL_5:
			//     sub_180B536AC(v3, m_RenderPass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(264, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_126(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		private void Dispose(bool disposing)
		{
			// // Void Dispose(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(
			//         HGRenderGraphBuilder *this,
			//         bool disposing,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraph *m_RenderGraph; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(206, 0LL) )
			//   {
			//     if ( this.m_Disposed )
			//       return;
			//     m_RenderGraph = this.m_RenderGraph;
			//     if ( m_RenderGraph )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::OnPassAdded(m_RenderGraph, this.m_RenderPass, 0LL);
			//       this.m_Disposed = 1;
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_RenderGraph, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(206, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, this, disposing, 0LL);
			// }
			// 
		}

		private void CheckResource(in ResourceHandle res, [MetadataOffset(Offset = "0x01F909F5")] bool dontCheckTransientReadWrite = false)
		{
			// // Void CheckResource(ResourceHandle ByRef, Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(
			//         HGRenderGraphBuilder *this,
			//         ResourceHandle *res,
			//         bool dontCheckTransientReadWrite,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(221, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(221, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_103(Patch, this, res, dontCheckTransientReadWrite, 0LL);
			//   }
			// }
			// 
		}

		internal void GenerateDebugData(bool value)
		{
			// // Void GenerateDebugData(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(
			//         HGRenderGraphBuilder *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphPass *m_RenderPass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(202, 0LL) )
			//   {
			//     m_RenderPass = this.m_RenderPass;
			//     if ( this.m_RenderPass )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::GenerateDebugData(m_RenderPass, value, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderPass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(202, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, this, value, 0LL);
			// }
			// 
		}

		private HGRenderGraphPass m_RenderPass;

		private HGRenderGraphResourceRegistry m_Resources;

		private HGRenderGraph m_RenderGraph;

		private bool m_Disposed;
	}
}
