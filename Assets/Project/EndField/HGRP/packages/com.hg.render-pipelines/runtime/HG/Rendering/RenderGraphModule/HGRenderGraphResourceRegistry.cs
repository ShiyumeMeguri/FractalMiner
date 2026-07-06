using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphResourceRegistry
	{
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static HGRenderGraphResourceRegistry current
		{
			get
			{
				// // HGRenderGraphResourceRegistry get_current()
				// HGRenderGraphResourceRegistry *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D919377 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry);
				//     byte_18D919377 = 1;
				//   }
				//   return TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry.static_fields.m_CurrentRegistry;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_current(HGRenderGraphResourceRegistry)
				// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::set_current(
				//         HGRenderGraphResourceRegistry *value,
				//         MethodInfo *method)
				// {
				//   FileDescriptor *v2; // r8
				//   MessageDescriptor *v3; // r9
				//   OneofDescriptorProto *static_fields; // rdx
				//   String__Array *v6; // [rsp+50h] [rbp+28h]
				//   String *v7; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v8; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D919378 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry);
				//     byte_18D919378 = 1;
				//   }
				//   static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry.static_fields;
				//   static_fields.klass = (OneofDescriptorProto__Class *)value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry.static_fields,
				//     static_fields,
				//     v2,
				//     v3,
				//     v6,
				//     v7,
				//     v8);
				// }
				// 
			}
		}

		private HGRenderGraphResourceRegistry()
		{
		}

		internal HGRenderGraphResourceRegistry(HGRenderGraphDebugParams renderGraphDebug, HGRenderGraphLogger frameInformationLogger)
		{
		}

		internal RTHandle GetTexture(in TextureHandle handle)
		{
			// // RTHandle GetTexture(TextureHandle ByRef)
			// RTHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(
			//         HGRenderGraphResourceRegistry *this,
			//         TextureHandle *handle,
			//         MethodInfo *method)
			// {
			//   TextureResource *TextureResource; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   RTHandle *graphicsResource; // rsi
			//   ResourceHandle fallBackResource; // rbx
			//   ResourceHandle *v10; // rax
			//   TextureResource *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v14[24]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919379 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919379 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(299, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(299, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(Patch, (Object *)this, handle, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(handle, 0LL) )
			//     {
			//       TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//                           this,
			//                           &handle.handle,
			//                           0LL);
			//       if ( !TextureResource )
			//         goto LABEL_13;
			//       graphicsResource = TextureResource.fields._.graphicsResource;
			//       if ( !graphicsResource )
			//       {
			//         fallBackResource = handle.fallBackResource;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         fallBackResource.m_Value = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(fallBackResource, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v10 = (ResourceHandle *)sub_182E7CCD0(v14);
			//         if ( fallBackResource.m_Value != HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(*v10, 0LL) )
			//         {
			//           v11 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//                   this,
			//                   &handle.fallBackResource,
			//                   0LL);
			//           if ( v11 )
			//             return v11.fields._.graphicsResource;
			// LABEL_13:
			//           sub_180B536AC(v7, v6);
			//         }
			//       }
			//       return graphicsResource;
			//     }
			//     else
			//     {
			//       return 0LL;
			//     }
			//   }
			// }
			// 
			return null;
		}

		internal bool TextureNeedsFallback(in TextureHandle handle)
		{
			// // Boolean TextureNeedsFallback(TextureHandle ByRef)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsFallback(
			//         HGRenderGraphResourceRegistry *this,
			//         TextureHandle *handle,
			//         MethodInfo *method)
			// {
			//   IHGRenderGraphResource *TextureResource; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91937A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91937A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(237, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(237, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_116(Patch, (Object *)this, handle, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(handle, 0LL) )
			//     {
			//       TextureResource = (IHGRenderGraphResource *)HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//                                                     this,
			//                                                     &handle.handle,
			//                                                     0LL);
			//       if ( TextureResource )
			//         return HG::Rendering::RenderGraphModule::IHGRenderGraphResource::NeedsFallBack(TextureResource, 0LL);
			// LABEL_9:
			//       sub_180B536AC(v7, v6);
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal RendererList GetRendererList(in RendererListHandle handle)
		{
			// // RendererList GetRendererList(RendererListHandle ByRef)
			// RendererList *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(
			//         RendererList *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         RendererListHandle *handle,
			//         MethodInfo *method)
			// {
			//   int32_t v7; // eax
			//   __int64 v8; // rdx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *v10; // rbx
			//   int32_t v11; // eax
			//   RendererList nullRendererList; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RendererList *result; // rax
			//   RendererList v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91937B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_size);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     byte_18D91937B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(65, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(65, 0LL);
			//     if ( Patch )
			//     {
			//       nullRendererList = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(&v15, Patch, (Object *)this, handle, 0LL);
			//       goto LABEL_12;
			//     }
			//     goto LABEL_10;
			//   }
			//   if ( !HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(handle, 0LL) )
			//   {
			// LABEL_8:
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields.nullRendererList;
			//     goto LABEL_12;
			//   }
			//   v7 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*handle, 0LL);
			//   m_RendererListResources = this.fields.m_RendererListResources;
			//   if ( !m_RendererListResources )
			// LABEL_10:
			//     sub_180B536AC(m_RendererListResources, v8);
			//   if ( v7 >= m_RendererListResources.fields._size_k__BackingField )
			//     goto LABEL_8;
			//   v10 = this.fields.m_RendererListResources;
			//   v11 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*handle, 0LL);
			//   nullRendererList = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
			//                        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)v10,
			//                        v11,
			//                        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item).rendererList;
			// LABEL_12:
			//   result = retstr;
			//   *retstr = nullRendererList;
			//   return result;
			// }
			// 
			return null;
		}

		internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle)
		{
			// // ComputeBuffer GetComputeBuffer(ComputeBufferHandle ByRef)
			// ComputeBuffer *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBuffer(
			//         HGRenderGraphResourceRegistry *this,
			//         ComputeBufferHandle *handle,
			//         MethodInfo *method)
			// {
			//   ComputeBufferResource *ComputeBufferResource; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferHandle v10; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91937C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     byte_18D91937C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(281, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(281, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_133(Patch, (Object *)this, handle, 0LL);
			//   }
			//   else
			//   {
			//     v10 = *handle;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&v10, 0LL) )
			//     {
			//       ComputeBufferResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResource(
			//                                 this,
			//                                 &handle.handle,
			//                                 0LL);
			//       if ( ComputeBufferResource )
			//         return ComputeBufferResource.fields._.graphicsResource;
			// LABEL_9:
			//       sub_180B536AC(v7, v6);
			//     }
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		internal void BeginRenderGraph(int executionCount, int currentExecutorID, int currentExecutorFrameIndex)
		{
			// // Void BeginRenderGraph(Int32, Int32, Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginRenderGraph(
			//         HGRenderGraphResourceRegistry *this,
			//         int32_t executionCount,
			//         int32_t currentExecutorID,
			//         int32_t currentExecutorFrameIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rsi
			//   int32_t v12; // edi
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91937E )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&off_18D4DFC58);
			//     byte_18D91937E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(181, 0LL) )
			//   {
			//     this.fields.m_ExecutionCount = executionCount;
			//     this.fields.m_currentExecutorID = currentExecutorID;
			//     this.fields.m_currentExecutorFrameIndex = currentExecutorFrameIndex;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     HG::Rendering::RenderGraphModule::ResourceHandle::NewFrame(executionCount, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v12 = 0;
			//     if ( m_RenderGraphResources )
			//     {
			//       while ( v12 < m_RenderGraphResources.max_length.size )
			//       {
			//         if ( (unsigned int)v12 >= m_RenderGraphResources.max_length.size )
			//           sub_180070270(m_Array, v9);
			//         m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[v12];
			//         if ( !m_Array )
			//           goto LABEL_16;
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( !m_Array )
			//           goto LABEL_16;
			//         UnityEngine::Rendering::DynamicArray<System::Object>::Resize(
			//           m_Array,
			//           64,
			//           0,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
			//         ++v12;
			//       }
			//       m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//       if ( m_RenderGraphDebug )
			//       {
			//         if ( !m_RenderGraphDebug.fields.enableLogging )
			//           return;
			//         m_Array = (DynamicArray_1_System_Object_ *)this.fields.m_ResourceLogger;
			//         if ( m_Array )
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphLogger::Initialize(
			//             (HGRenderGraphLogger *)m_Array,
			//             (String *)"RenderGraph Resources",
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(m_Array, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(181, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)this,
			//     executionCount,
			//     currentExecutorID,
			//     currentExecutorFrameIndex,
			//     0LL);
			// }
			// 
		}

		internal void BeginExecute(int currentFrameIndex)
		{
			// // Void BeginExecute(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
			//         HGRenderGraphResourceRegistry *this,
			//         int32_t currentFrameIndex,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(75, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(75, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       currentFrameIndex,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_CurrentFrameIndex = currentFrameIndex;
			//     sub_1885A7D34(this);
			//   }
			// }
			// 
		}

		internal void EndExecute()
		{
			// // Void EndExecute()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::EndExecute(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(107, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(107, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_1885A7D34(0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		private void CheckHandleValidity(in ResourceHandle res)
		{
			// // Void CheckHandleValidity(ResourceHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D91937F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91937F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(46, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(46, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_26(Patch, (Object *)this, res, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
			//       this,
			//       (HGRenderGraphResourceType__Enum)res._type_k__BackingField,
			//       LOWORD(res.m_Value),
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		private void CheckHandleValidity(HGRenderGraphResourceType type, int index)
		{
			// // Void CheckHandleValidity(HGRenderGraphResourceType, Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphResourceType__Enum type,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v9; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
			//   __int64 v11; // rax
			//   __int64 v12; // r8
			//   __int64 v13; // rax
			//   Object *v14; // rdi
			//   __int64 v15; // rax
			//   __int64 v16; // r8
			//   Object *v17; // rbx
			//   String *v18; // rax
			//   String *v19; // rdi
			//   __int64 v20; // rax
			//   InvalidEnumArgumentException *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   InvalidEnumArgumentException *v24; // rbx
			//   __int64 v25; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int v27; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t v28; // [rsp+34h] [rbp-14h] BYREF
			// 
			//   v5 = (int)type;
			//   if ( !byte_18D919380 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_size);
			//     byte_18D919380 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(48, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(48, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//         (ILFixDynamicMethodWrapper_20 *)Patch,
			//         (Object *)this,
			//         v5,
			//         index,
			//         0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_RenderGraphResources, v7);
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_14;
			//   if ( (unsigned int)v5 >= m_RenderGraphResources.max_length.size )
			//     sub_180070270(m_RenderGraphResources, v7);
			//   v9 = m_RenderGraphResources.vector[v5];
			//   if ( !v9 )
			//     goto LABEL_14;
			//   resourceArray = v9.fields.resourceArray;
			//   if ( !resourceArray )
			//     goto LABEL_14;
			//   if ( index >= resourceArray.fields._size_k__BackingField )
			//   {
			//     v27 = v5;
			//     v11 = sub_18000F7E0(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceType);
			//     v13 = il2cpp_value_box(v11, &v27, v12);
			//     v28 = index;
			//     v14 = (Object *)v13;
			//     v15 = sub_18000F7E0(&TypeInfo::System::Int32);
			//     v17 = (Object *)il2cpp_value_box(v15, &v28, v16);
			//     v18 = (String *)sub_18000F7E0(&off_18D4DFCA8);
			//     v19 = System::String::Format(v18, v14, v17, 0LL);
			//     v20 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v21 = (InvalidEnumArgumentException *)sub_180004920(v20);
			//     v24 = v21;
			//     if ( !v21 )
			//       sub_180B536AC(v23, v22);
			//     System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v21, v19, 0LL);
			//     v25 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity);
			//     sub_18000F7C0(v24, v25);
			//   }
			// }
			// 
		}

		internal void IncrementWriteCount(in ResourceHandle res)
		{
			// // Void IncrementWriteCount(ResourceHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919381 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919381 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(222, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v10 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)iType >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_Array, v7);
			//       m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[iType];
			//       if ( m_Array )
			//       {
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( m_Array )
			//         {
			//           m_Array = (DynamicArray_1_System_Object_ *)*UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                                                         m_Array,
			//                                                         LOWORD(res.m_Value),
			//                                                         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( m_Array )
			//           {
			//             HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IncrementWriteCount(
			//               (IHGRenderGraphResource *)m_Array,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_Array, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(222, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_26(Patch, (Object *)this, res, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		internal string GetRenderGraphResourceName(in ResourceHandle res)
		{
			// // String GetRenderGraphResourceName(ResourceHandle ByRef)
			// String *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   int32_t iType; // eax
			//   Object *v7; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v11; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919382 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919382 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(300, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v11 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v11, 0LL);
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)iType >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_Array, v7);
			//       m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[iType];
			//       if ( m_Array )
			//       {
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( m_Array )
			//         {
			//           v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_Array,
			//                   LOWORD(res.m_Value),
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v7 )
			//             return (String *)sub_18003F3E0(5LL, v7);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_Array, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(300, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_139(Patch, (Object *)this, res, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal string GetRenderGraphResourceName(HGRenderGraphResourceType type, int index)
		{
			// // String GetRenderGraphResourceName(HGRenderGraphResourceType, Int32)
			// String *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphResourceType__Enum type,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   Object *v7; // rdx
			//   DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = (int)type;
			//   if ( !byte_18D919383 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D919383 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(95, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
			//       this,
			//       (HGRenderGraphResourceType__Enum)v5,
			//       index,
			//       0LL);
			//     m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)v5 >= m_RenderGraphResources.fields._size_k__BackingField )
			//         sub_180070270(m_RenderGraphResources, v7);
			//       v7 = (Object *)*((_QWORD *)&m_RenderGraphResources[1].klass + v5);
			//       if ( v7 )
			//       {
			//         m_RenderGraphResources = (DynamicArray_1_System_Object_ *)v7[1].klass;
			//         if ( m_RenderGraphResources )
			//         {
			//           v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_RenderGraphResources,
			//                   index,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v7 )
			//             return (String *)sub_18003F3E0(5LL, v7);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_RenderGraphResources, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(95, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_49(
			//            Patch,
			//            (Object *)this,
			//            (HGRenderGraphResourceType__Enum)v5,
			//            index,
			//            0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal bool IsRenderGraphResourceImported(in ResourceHandle res)
		{
			// // Boolean IsRenderGraphResourceImported(ResourceHandle ByRef)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   Object *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v12; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919384 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919384 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(45, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v12 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v12, 0LL);
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)iType >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_Array, v7);
			//       m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[iType];
			//       if ( m_Array )
			//       {
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( m_Array )
			//         {
			//           v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_Array,
			//                   LOWORD(res.m_Value),
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v9 )
			//             return (bool)v9[1].klass;
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_Array, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(45, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(Patch, (Object *)this, res, 0LL);
			// }
			// 
			return default(bool);
		}

		internal bool IsRenderGraphResourcePreserved(HGRenderGraphResourceType type, int index)
		{
			// // Boolean IsRenderGraphResourcePreserved(HGRenderGraphResourceType, Int32)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourcePreserved(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphResourceType__Enum type,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(301, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(301, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//              (ILFixDynamicMethodWrapper_12 *)Patch,
			//              (Object *)this,
			//              type,
			//              index,
			//              0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, type, index, 0LL);
			//     return index < 64;
			//   }
			// }
			// 
			return default(bool);
		}

		internal bool IsGraphicsResourceCreated(in ResourceHandle res)
		{
			// // Boolean IsGraphicsResourceCreated(ResourceHandle ByRef)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsGraphicsResourceCreated(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   int32_t iType; // eax
			//   Object *v7; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v11; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919385 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919385 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(210, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v11 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v11, 0LL);
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)iType >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_Array, v7);
			//       m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[iType];
			//       if ( m_Array )
			//       {
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( m_Array )
			//         {
			//           v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_Array,
			//                   LOWORD(res.m_Value),
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v7 )
			//             return sub_1800023D0(6LL, v7);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_Array, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(210, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(Patch, (Object *)this, res, 0LL);
			// }
			// 
			return default(bool);
		}

		internal bool IsRendererListCreated(in RendererListHandle res)
		{
			// // Boolean IsRendererListCreated(RendererListHandle ByRef)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRendererListCreated(
			//         HGRenderGraphResourceRegistry *this,
			//         RendererListHandle *res,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rdi
			//   int32_t v6; // eax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   RendererListResource_1 *Item; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919386 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     byte_18D919386 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(212, 0LL) )
			//   {
			//     m_RendererListResources = this.fields.m_RendererListResources;
			//     v6 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*res, 0LL);
			//     if ( m_RendererListResources )
			//     {
			//       Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
			//                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)m_RendererListResources,
			//                v6,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//       return UnityEngine::Rendering::RendererUtils::RendererList::get_isValid(&Item.rendererList, 0LL);
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(212, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(Patch, (Object *)this, res, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		internal bool IsRenderGraphResourceImported(HGRenderGraphResourceType type, int index)
		{
			// // Boolean IsRenderGraphResourceImported(HGRenderGraphResourceType, Int32)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphResourceType__Enum type,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   __int64 v7; // rdx
			//   DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
			//   Object *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = (int)type;
			//   if ( !byte_18D919387 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D919387 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(97, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
			//       this,
			//       (HGRenderGraphResourceType__Enum)v5,
			//       index,
			//       0LL);
			//     m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)v5 >= m_RenderGraphResources.fields._size_k__BackingField )
			//         sub_180070270(m_RenderGraphResources, v7);
			//       v7 = *((_QWORD *)&m_RenderGraphResources[1].klass + v5);
			//       if ( v7 )
			//       {
			//         m_RenderGraphResources = *(DynamicArray_1_System_Object_ **)(v7 + 16);
			//         if ( m_RenderGraphResources )
			//         {
			//           v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_RenderGraphResources,
			//                   index,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v9 )
			//             return (bool)v9[1].klass;
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_RenderGraphResources, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(97, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//            (ILFixDynamicMethodWrapper_12 *)Patch,
			//            (Object *)this,
			//            v5,
			//            index,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res)
		{
			// // Int32 GetRenderGraphResourceTransientIndex(ResourceHandle ByRef)
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceTransientIndex(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   DynamicArray_1_System_Object_ *m_Array; // rcx
			//   Object *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v12; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919388 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919388 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(302, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     v12 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v12, 0LL);
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( (unsigned int)iType >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_Array, v7);
			//       m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources.vector[iType];
			//       if ( m_Array )
			//       {
			//         m_Array = (DynamicArray_1_System_Object_ *)m_Array.fields.m_Array;
			//         if ( m_Array )
			//         {
			//           v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                   m_Array,
			//                   LOWORD(res.m_Value),
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           if ( v9 )
			//             return HIDWORD(v9[1].monitor);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_Array, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(302, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_140(Patch, (Object *)this, res, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(0)]
		internal TextureHandle ImportTexture(RTHandle rt)
		{
			// // TextureHandle ImportTexture(RTHandle)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   int32_t v10; // eax
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   int32_t v13; // r15d
			//   Object_1 *m_RT; // rbx
			//   Object *v15; // r14
			//   DepthBits__Enum v16; // ebx
			//   GraphicsFormat__Enum depthStencilFormat; // eax
			//   GraphicsFormat__Enum SupportedFormatForDepth; // eax
			//   GraphicsFormat__Enum v19; // ebx
			//   Object *v20; // r14
			//   Object *v21; // r14
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v24; // [rsp+20h] [rbp-30h]
			//   String *v25; // [rsp+28h] [rbp-28h]
			//   Object *outRes; // [rsp+30h] [rbp-20h] BYREF
			//   TextureHandle v27; // [rsp+38h] [rbp-18h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+70h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919389 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919389 = 1;
			//   }
			//   outRes = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(135, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(135, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_61(&v27, Patch, (Object *)this, (Object *)rt, 0LL);
			//       return retstr;
			//     }
			//     goto LABEL_27;
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_27;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v8, v7);
			//   v8 = m_RenderGraphResources.vector[0];
			//   if ( !v8 )
			//     goto LABEL_27;
			//   v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//           v8,
			//           &outRes,
			//           1,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//   v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   v13 = v10;
			//   if ( !outRes )
			//     goto LABEL_27;
			//   outRes[9].monitor = (MonitorData *)rt;
			//   sub_1800054D0((OneofDescriptor *)&v8[3].monitor, v7, v11, v12, v24, v25, (MethodInfo *)outRes);
			//   if ( !outRes )
			//     goto LABEL_27;
			//   LOBYTE(outRes[1].klass) = 1;
			//   if ( !rt )
			//     goto LABEL_25;
			//   m_RT = (Object_1 *)rt.fields.m_RT;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
			//     goto LABEL_25;
			//   v15 = outRes;
			//   v16 = DepthBits__Enum_None;
			//   depthBits = DepthBits__Enum_None;
			//   if ( !outRes )
			//     goto LABEL_27;
			//   v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt.fields.m_RT;
			//   if ( !v8 )
			//     goto LABEL_27;
			//   depthStencilFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL);
			//   v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt.fields.m_RT;
			//   if ( depthStencilFormat )
			//   {
			//     if ( !v8 )
			//       goto LABEL_27;
			//     v19 = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v19, &depthBits, 0LL);
			//     v16 = depthBits;
			//   }
			//   else
			//   {
			//     if ( !v8 )
			//       goto LABEL_27;
			//     SupportedFormatForDepth = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v8, 0LL);
			//   }
			//   LODWORD(v15[4].monitor) = SupportedFormatForDepth;
			//   v20 = outRes;
			//   if ( !outRes
			//     || (v7 = (OneofDescriptorProto *)rt.fields.m_RT) == 0LL
			//     || (LODWORD(v20[3].monitor) = sub_18003ED00(5LL), (v21 = outRes) == 0LL)
			//     || (v7 = (OneofDescriptorProto *)rt.fields.m_RT) == 0LL
			//     || (HIDWORD(v21[3].monitor) = sub_18003ED00(7LL), !outRes) )
			//   {
			// LABEL_27:
			//     sub_180B536AC(v8, v7);
			//   }
			//   HIDWORD(outRes[4].klass) = v16;
			// LABEL_25:
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v13, 0, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		internal TextureHandle ImportTexture(RTHandle rt, int width, int height)
		{
			// // TextureHandle ImportTexture(RTHandle, Int32, Int32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         RTHandle *rt,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v11; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   int32_t v13; // eax
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   int32_t v16; // r12d
			//   Object_1 *m_RT; // rbx
			//   Object *v18; // r14
			//   DepthBits__Enum v19; // ebx
			//   GraphicsFormat__Enum depthStencilFormat; // eax
			//   GraphicsFormat__Enum SupportedFormatForDepth; // eax
			//   GraphicsFormat__Enum v22; // ebx
			//   String__Array *v24; // [rsp+20h] [rbp-40h]
			//   String *v25; // [rsp+28h] [rbp-38h]
			//   MethodInfo *v26; // [rsp+30h] [rbp-30h]
			//   Object *outRes; // [rsp+40h] [rbp-20h] BYREF
			//   TextureHandle v28; // [rsp+48h] [rbp-18h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+90h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D91938A )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91938A = 1;
			//   }
			//   outRes = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(138, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(138, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(
			//                    &v28,
			//                    Patch,
			//                    (Object *)this,
			//                    (Object *)rt,
			//                    width,
			//                    height,
			//                    0LL);
			//       return retstr;
			//     }
			//     goto LABEL_25;
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_25;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v11, Patch);
			//   v11 = m_RenderGraphResources.vector[0];
			//   if ( !v11 )
			//     goto LABEL_25;
			//   v13 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//           v11,
			//           &outRes,
			//           1,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//   v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   v16 = v13;
			//   if ( !outRes )
			//     goto LABEL_25;
			//   outRes[9].monitor = (MonitorData *)rt;
			//   sub_1800054D0((OneofDescriptor *)&v11[3].monitor, (OneofDescriptorProto *)Patch, v14, v15, v24, v25, v26);
			//   if ( !outRes )
			//     goto LABEL_25;
			//   LOBYTE(outRes[1].klass) = 1;
			//   if ( !rt )
			//     goto LABEL_23;
			//   m_RT = (Object_1 *)rt.fields.m_RT;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
			//     goto LABEL_23;
			//   v18 = outRes;
			//   v19 = DepthBits__Enum_None;
			//   depthBits = DepthBits__Enum_None;
			//   if ( !outRes )
			//     goto LABEL_25;
			//   v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt.fields.m_RT;
			//   if ( !v11 )
			//     goto LABEL_25;
			//   depthStencilFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v11, 0LL);
			//   v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt.fields.m_RT;
			//   if ( depthStencilFormat )
			//   {
			//     if ( !v11 )
			//       goto LABEL_25;
			//     v22 = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v11, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v22, &depthBits, 0LL);
			//     v19 = depthBits;
			//   }
			//   else
			//   {
			//     if ( !v11 )
			//       goto LABEL_25;
			//     SupportedFormatForDepth = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v11, 0LL);
			//   }
			//   LODWORD(v18[4].monitor) = SupportedFormatForDepth;
			//   if ( !outRes
			//     || (LODWORD(outRes[3].monitor) = width,
			//         (v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes) == 0LL)
			//     || (HIDWORD(outRes[3].monitor) = height, !outRes) )
			//   {
			// LABEL_25:
			//     sub_180B536AC(v11, Patch);
			//   }
			//   HIDWORD(outRes[4].klass) = v19;
			// LABEL_23:
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v16, 0, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal TextureHandle ImportDepthbuffer(RTHandle rt)
		{
			// // TextureHandle ImportDepthbuffer(RTHandle)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportDepthbuffer(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   int32_t v10; // eax
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   int32_t v13; // ebp
			//   Object_1 *m_RT; // rbx
			//   Object *v15; // rbx
			//   Object *v16; // rbx
			//   Object *v17; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v20; // [rsp+20h] [rbp-28h]
			//   String *v21; // [rsp+28h] [rbp-20h]
			//   TextureHandle v22; // [rsp+30h] [rbp-18h] BYREF
			//   Object *outRes; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D91938B )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91938B = 1;
			//   }
			//   outRes = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(140, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(140, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_61(&v22, Patch, (Object *)this, (Object *)rt, 0LL);
			//       return retstr;
			//     }
			//     goto LABEL_22;
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_22;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v8, v7);
			//   v8 = m_RenderGraphResources.vector[0];
			//   if ( !v8 )
			//     goto LABEL_22;
			//   v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//           v8,
			//           &outRes,
			//           1,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//   v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   v13 = v10;
			//   if ( !outRes )
			//     goto LABEL_22;
			//   outRes[9].monitor = (MonitorData *)rt;
			//   sub_1800054D0((OneofDescriptor *)&v8[3].monitor, v7, v11, v12, v20, v21, *(MethodInfo **)&v22.handle);
			//   if ( !outRes )
			//     goto LABEL_22;
			//   LOBYTE(outRes[1].klass) = 1;
			//   v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   if ( !outRes )
			//     goto LABEL_22;
			//   HIDWORD(outRes[4].klass) = 32;
			//   if ( !rt )
			//     goto LABEL_20;
			//   m_RT = (Object_1 *)rt.fields.m_RT;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
			//     goto LABEL_20;
			//   v15 = outRes;
			//   if ( !outRes
			//     || (v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt.fields.m_RT) == 0LL
			//     || (LODWORD(v15[4].monitor) = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL),
			//         (v16 = outRes) == 0LL)
			//     || (v7 = (OneofDescriptorProto *)rt.fields.m_RT) == 0LL
			//     || (LODWORD(v16[3].monitor) = sub_18003ED00(5LL), (v17 = outRes) == 0LL)
			//     || (v7 = (OneofDescriptorProto *)rt.fields.m_RT) == 0LL )
			//   {
			// LABEL_22:
			//     sub_180B536AC(v8, v7);
			//   }
			//   HIDWORD(v17[3].monitor) = sub_18003ED00(7LL);
			// LABEL_20:
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v13, 0, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal TextureHandle PreserveTexture(ref TextureHandle texture, int frameCount, HGRenderGraphContext context, string info)
		{
			// // TextureHandle PreserveTexture(TextureHandle ByRef, Int32, HGRenderGraphContext, String)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PreserveTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         TextureHandle *texture,
			//         int32_t frameCount,
			//         HGRenderGraphContext *context,
			//         String *info,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   DynamicArray_1_System_Object_ *v12; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v14; // rbx
			//   DynamicArray_1_System_Object_ *resourceArray; // rbp
			//   Object **Item; // rax
			//   int32_t m_currentExecutorID; // r12d
			//   int32_t m_currentExecutorFrameIndex; // edi
			//   Object *v19; // rbp
			//   int v20; // eax
			//   int32_t v21; // ebp
			//   int32_t v22; // edi
			//   Object *v23; // rcx
			//   OneofDescriptor *v24; // r15
			//   TextureResource *v25; // rax
			//   TextureResource *v26; // rdi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   DynamicArray_1_System_Object_ *v30; // rdi
			//   Object **v31; // rax
			//   __int64 v32; // rax
			//   TextureResource *v33; // r14
			//   Object *v34; // rdi
			//   HGRenderGraphResourceRegistry_ResourceCallback *createResourceCallback; // rbx
			//   TextureResource *v36; // rdi
			//   TextureHandle v37; // xmm0
			//   String__Array *v39; // [rsp+20h] [rbp-48h]
			//   String *v40; // [rsp+28h] [rbp-40h]
			//   MethodInfo *v41; // [rsp+30h] [rbp-38h]
			//   TextureHandle v42; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91938C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D91938C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(156, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(156, 0LL);
			//     if ( !Patch )
			//       goto LABEL_32;
			//     v37 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_78(
			//              &v42,
			//              Patch,
			//              (Object *)this,
			//              texture,
			//              frameCount,
			//              (Object *)context,
			//              (Object *)info,
			//              0LL);
			// LABEL_34:
			//     *retstr = v37;
			//     return retstr;
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_32;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v12, Patch);
			//   v14 = m_RenderGraphResources.vector[0];
			//   if ( !v14 )
			//     goto LABEL_32;
			//   resourceArray = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   if ( !resourceArray )
			//     goto LABEL_32;
			//   Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            resourceArray,
			//            LOWORD(texture.handle.m_Value),
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   m_currentExecutorID = this.fields.m_currentExecutorID;
			//   m_currentExecutorFrameIndex = this.fields.m_currentExecutorFrameIndex;
			//   v19 = *Item;
			//   if ( !sub_18003F550(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
			//     goto LABEL_32;
			//   v20 = sub_18003F550(v19, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//   sub_1804D96DC(14, v20, m_currentExecutorID, m_currentExecutorFrameIndex, frameCount);
			//   if ( HG::Rendering::RenderGraphModule::ResourceHandle::IsPreserved(&texture.handle, 0LL) )
			//   {
			//     v37 = *texture;
			//     goto LABEL_34;
			//   }
			//   v21 = -1;
			//   v22 = 0;
			//   while ( 1 )
			//   {
			//     v12 = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//     if ( !v12 )
			//       goto LABEL_32;
			//     v23 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//              v12,
			//              v22,
			//              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     if ( !v23 || !BYTE1(v23[1].klass) )
			//       break;
			//     if ( ++v22 >= 64 )
			//       goto LABEL_18;
			//   }
			//   v21 = v22;
			// LABEL_18:
			//   v12 = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//   if ( !v12 )
			//     goto LABEL_32;
			//   if ( !*UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            v12,
			//            v21,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item) )
			//   {
			//     v12 = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//     if ( !v12 )
			//       goto LABEL_32;
			//     v24 = (OneofDescriptor *)UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                                v12,
			//                                v21,
			//                                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     v25 = (TextureResource *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     v26 = v25;
			//     if ( !v25 )
			//       goto LABEL_32;
			//     HG::Rendering::RenderGraphModule::TextureResource::TextureResource(v25, 0LL);
			//     v24.klass = (OneofDescriptor__Class *)v26;
			//     sub_1800054D0(v24, v27, v28, v29, v39, v40, v41);
			//   }
			//   v30 = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   if ( !v30 )
			//     goto LABEL_32;
			//   v31 = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//           v30,
			//           LOWORD(texture.handle.m_Value),
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   v32 = sub_18003F550(*v31, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//   v12 = (DynamicArray_1_System_Object_ *)v14.fields.resourceArray;
			//   v33 = (TextureResource *)v32;
			//   if ( !v12 )
			//     goto LABEL_32;
			//   v34 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            v12,
			//            v21,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   if ( !v33 )
			//     goto LABEL_32;
			//   sub_18082F3A8(v12, v33, 0LL, info);
			//   createResourceCallback = v14.fields.createResourceCallback;
			//   v36 = (TextureResource *)sub_18003F550(v34, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//   if ( createResourceCallback )
			//     ((void (__fastcall *)(void *, HGRenderGraphContext *, TextureResource *, void *))createResourceCallback.fields._._.invoke_impl)(
			//       createResourceCallback.fields._._.method_code,
			//       context,
			//       v33,
			//       createResourceCallback.fields._._.method);
			//   if ( !v36 )
			// LABEL_32:
			//     sub_180B536AC(v12, Patch);
			//   HG::Rendering::RenderGraphModule::TextureResource::CopyFrom(v36, v33, 0LL);
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v21, 1, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal void ReleasePreservedTexture(TextureHandle texture)
		{
			// // Void ReleasePreservedTexture(TextureHandle)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePreservedTexture(
			//         HGRenderGraphResourceRegistry *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   TextureResource *TextureResource; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // r9
			//   TextureResource *v9; // rbx
			//   __int64 v10; // rax
			//   ProtocolViolationException *v11; // rbx
			//   String *v12; // rax
			//   __int64 v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v15; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91938D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91938D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(303, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(303, 0LL);
			//     if ( Patch )
			//     {
			//       v15 = *texture;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141(Patch, (Object *)this, &v15, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v7, v6);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   if ( HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(texture.handle, 0LL) >= 64 )
			//   {
			//     v10 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//     v11 = (ProtocolViolationException *)sub_180004920(v10);
			//     if ( v11 )
			//     {
			//       v12 = (String *)sub_18000F7E0(&off_18D4DF658);
			//       System::Net::ProtocolViolationException::ProtocolViolationException(v11, v12, 0LL);
			//       v13 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePreservedTexture);
			//       sub_18000F7C0(v11, v13);
			//     }
			//     goto LABEL_12;
			//   }
			//   TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//                       this,
			//                       &texture.handle,
			//                       0LL);
			//   v9 = TextureResource;
			//   if ( !TextureResource )
			//     goto LABEL_12;
			//   if ( TextureResource.fields._.graphicsResource )
			//   {
			//     LOBYTE(v8) = 1;
			//     sub_18000F800(12LL, TextureResource, (unsigned int)this.fields.m_CurrentFrameIndex, v8);
			//   }
			//   sub_18000FAA0(v7, v9, 0LL);
			// }
			// 
		}

		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, ref TextureDesc desc, HGRenderGraphResourceRegistry.BackBufferType type)
		{
			// // TextureHandle ImportBackbuffer(RenderTargetIdentifier, TextureDesc ByRef, HGRenderGraphResourceRegistry+BackBufferType)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         RenderTargetIdentifier *rt,
			//         TextureDesc *desc,
			//         HGRenderGraphResourceRegistry_BackBufferType__Enum type,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *m_CurrentBackbuffer; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Class **v12; // rsi
			//   String *v13; // rax
			//   String *v14; // rbx
			//   __int128 v15; // xmm1
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   __int128 v19; // xmm1
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   FileDescriptor *v23; // r8
			//   Object *v24; // r9
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm2
			//   __int128 v27; // xmm3
			//   __int128 v28; // xmm4
			//   Color clearColor; // xmm5
			//   int32_t v30; // r10d
			//   __int128 v31; // xmm1
			//   String__Array *v33; // [rsp+20h] [rbp-59h]
			//   String__Array *v34; // [rsp+20h] [rbp-59h]
			//   String *v35; // [rsp+28h] [rbp-51h]
			//   String *v36; // [rsp+28h] [rbp-51h]
			//   MethodInfo *v37; // [rsp+30h] [rbp-49h]
			//   MethodInfo *v38; // [rsp+30h] [rbp-49h]
			//   RenderTargetIdentifier v39; // [rsp+40h] [rbp-39h] BYREF
			//   RenderTargetIdentifier v40; // [rsp+70h] [rbp-9h] BYREF
			//   Object *outRes; // [rsp+D0h] [rbp+57h] BYREF
			// 
			//   if ( !byte_18D91938E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BackBufferType);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18D4DF3D0);
			//     byte_18D91938E = 1;
			//   }
			//   outRes = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(142, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(142, 0LL);
			//     if ( Patch )
			//     {
			//       v31 = *(_OWORD *)&rt.m_BufferPointer;
			//       *(_OWORD *)&v40.m_Type = *(_OWORD *)&rt.m_Type;
			//       *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&rt.m_DepthSlice;
			//       *(_OWORD *)&v40.m_BufferPointer = v31;
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_63(
			//                    (TextureHandle *)&v39,
			//                    Patch,
			//                    (Object *)this,
			//                    &v40,
			//                    desc,
			//                    type,
			//                    0LL);
			//       return retstr;
			//     }
			//     goto LABEL_19;
			//   }
			//   m_CurrentBackbuffer = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this.fields.m_CurrentBackbuffer;
			//   if ( !m_CurrentBackbuffer )
			//     goto LABEL_19;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)(int)type;
			//   if ( type >= LODWORD(m_CurrentBackbuffer.fields.pool) )
			// LABEL_17:
			//     sub_180070270(m_CurrentBackbuffer, Patch);
			//   v12 = &m_CurrentBackbuffer.klass + (int)type;
			//   if ( v12[4] )
			//   {
			//     m_CurrentBackbuffer = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v12[4];
			//     if ( !m_CurrentBackbuffer )
			//       goto LABEL_19;
			//     v19 = *(_OWORD *)&rt.m_BufferPointer;
			//     *(_OWORD *)&v39.m_Type = *(_OWORD *)&rt.m_Type;
			//     *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&rt.m_DepthSlice;
			//     *(_OWORD *)&v39.m_BufferPointer = v19;
			//     UnityEngine::Rendering::RTHandle::SetTexture((RTHandle *)m_CurrentBackbuffer, &v39, 0LL);
			//   }
			//   else
			//   {
			//     *(_QWORD *)&v39.m_InstanceID = -1LL;
			//     LODWORD(v39.m_BufferPointer) = type;
			//     *(_QWORD *)&v39.m_Type = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BackBufferType;
			//     v13 = System::Enum::ToString((Enum *)&v39, 0LL);
			//     v14 = System::String::Concat((String *)"Backbuffer", v13, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     v15 = *(_OWORD *)&rt.m_BufferPointer;
			//     *(_OWORD *)&v39.m_Type = *(_OWORD *)&rt.m_Type;
			//     *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&rt.m_DepthSlice;
			//     *(_OWORD *)&v39.m_BufferPointer = v15;
			//     v12[4] = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Class *)UnityEngine::Rendering::RTHandles::Alloc(
			//                                                                                   &v39,
			//                                                                                   v14,
			//                                                                                   0LL);
			//     sub_1800054D0((OneofDescriptor *)(v12 + 4), v16, v17, v18, v33, v35, v37);
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			// LABEL_19:
			//     sub_180B536AC(m_CurrentBackbuffer, Patch);
			//   if ( !m_RenderGraphResources.max_length.size )
			//     goto LABEL_17;
			//   m_CurrentBackbuffer = m_RenderGraphResources.vector[0];
			//   if ( !m_CurrentBackbuffer )
			//     goto LABEL_19;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//     m_CurrentBackbuffer,
			//     &outRes,
			//     1,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//   m_CurrentBackbuffer = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)v12[4];
			//   if ( !outRes )
			//     goto LABEL_19;
			//   outRes[9].monitor = (MonitorData *)Patch;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&m_CurrentBackbuffer[3].monitor,
			//     (OneofDescriptorProto *)Patch,
			//     v21,
			//     v22,
			//     v33,
			//     v35,
			//     v37);
			//   v24 = outRes;
			//   if ( !outRes )
			//     goto LABEL_19;
			//   LOBYTE(outRes[1].klass) = 1;
			//   m_CurrentBackbuffer = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
			//   v25 = *(_OWORD *)&desc.colorFormat;
			//   v26 = *(_OWORD *)&desc.enableRandomWrite;
			//   v27 = *(_OWORD *)&desc.bindTextureMS;
			//   v28 = *(_OWORD *)&desc.fastMemoryDesc.inFastMemory;
			//   clearColor = desc.clearColor;
			//   if ( !outRes )
			//     goto LABEL_19;
			//   *(Object *)((char *)outRes + 56) = *(Object *)&desc.width;
			//   *(_OWORD *)&m_CurrentBackbuffer[1].fields.pool = v25;
			//   *(_OWORD *)&m_CurrentBackbuffer[1].fields.releaseResourceCallback = v26;
			//   *(_OWORD *)&m_CurrentBackbuffer[2].monitor = v27;
			//   *(_OWORD *)&m_CurrentBackbuffer[2].fields.pool = v28;
			//   *(Color *)&m_CurrentBackbuffer[2].fields.releaseResourceCallback = clearColor;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&m_CurrentBackbuffer[2].fields,
			//     (OneofDescriptorProto *)Patch,
			//     v23,
			//     (MessageDescriptor *)v24,
			//     v34,
			//     v36,
			//     v38);
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v30, 0, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal TextureHandle CreateTexture(ref TextureDesc desc, [MetadataOffset(Offset = "0x01F90A06")] int transientPassIndex = -1)
		{
			// // TextureHandle CreateTexture(TextureDesc ByRef, Int32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         TextureDesc *desc,
			//         int32_t transientPassIndex,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v9; // rdx
			//   Object *v10; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm2
			//   __int128 v16; // xmm3
			//   __int128 v17; // xmm4
			//   Color clearColor; // xmm5
			//   int32_t v19; // r10d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v22; // [rsp+20h] [rbp-28h]
			//   String *v23; // [rsp+28h] [rbp-20h]
			//   TextureHandle v24; // [rsp+30h] [rbp-18h] BYREF
			//   Object *outRes; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D91938F )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//     byte_18D91938F = 1;
			//   }
			//   outRes = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(145, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(145, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_67(
			//                    &v24,
			//                    Patch,
			//                    (Object *)this,
			//                    desc,
			//                    transientPassIndex,
			//                    0LL);
			//       return retstr;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v10, v9);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateTextureDesc(this, desc, 0LL);
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_13;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v10, v9);
			//   v10 = (Object *)m_RenderGraphResources.vector[0];
			//   if ( !v10 )
			//     goto LABEL_13;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//     (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v10,
			//     &outRes,
			//     1,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
			//   v10 = outRes;
			//   v14 = *(_OWORD *)&desc.colorFormat;
			//   v15 = *(_OWORD *)&desc.enableRandomWrite;
			//   v16 = *(_OWORD *)&desc.bindTextureMS;
			//   v17 = *(_OWORD *)&desc.fastMemoryDesc.inFastMemory;
			//   clearColor = desc.clearColor;
			//   if ( !outRes )
			//     goto LABEL_13;
			//   *(Object *)((char *)outRes + 56) = *(Object *)&desc.width;
			//   *(_OWORD *)&v10[4].monitor = v14;
			//   *(_OWORD *)&v10[5].monitor = v15;
			//   *(_OWORD *)&v10[6].monitor = v16;
			//   *(_OWORD *)&v10[7].monitor = v17;
			//   *(Color *)&v10[8].monitor = clearColor;
			//   sub_1800054D0((OneofDescriptor *)&v10[7], v9, v12, v13, v22, v23, *(MethodInfo **)&v24.handle);
			//   if ( !outRes )
			//     goto LABEL_13;
			//   HIDWORD(outRes[1].monitor) = transientPassIndex;
			//   LOBYTE(v10) = desc.fallBackToBlackTexture;
			//   if ( !outRes )
			//     goto LABEL_13;
			//   BYTE2(outRes[1].klass) = (_BYTE)v10;
			//   *retstr = 0LL;
			//   HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v19, 0, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal int GetTextureResourceCount()
		{
			// // Int32 GetTextureResourceCount()
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceCount(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919390 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_size);
			//     byte_18D919390 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(37, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( !m_RenderGraphResources.max_length.size )
			//         sub_180070270(v4, v3);
			//       v6 = m_RenderGraphResources.vector[0];
			//       if ( v6 )
			//       {
			//         resourceArray = v6.fields.resourceArray;
			//         if ( resourceArray )
			//           return resourceArray.fields._size_k__BackingField;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(37, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		private TextureResource GetTextureResource(in ResourceHandle handle)
		{
			// // TextureResource GetTextureResource(ResourceHandle ByRef)
			// TextureResource *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v9; // rbx
			//   int32_t v10; // eax
			//   Object **Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919391 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D919391 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(238, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( !m_RenderGraphResources.max_length.size )
			//         sub_180070270(v6, v5);
			//       v6 = m_RenderGraphResources.vector[0];
			//       if ( v6 )
			//       {
			//         resourceArray = (DynamicArray_1_System_Object_ *)v6.fields.resourceArray;
			//         v9 = *handle;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
			//         if ( resourceArray )
			//         {
			//           Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                    resourceArray,
			//                    v10,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           return (TextureResource *)sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(238, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_115(Patch, (Object *)this, handle, 0LL);
			// }
			// 
			return null;
		}

		internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle)
		{
			// // TextureDesc GetTextureResourceDesc(ResourceHandle ByRef)
			// TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
			//         TextureDesc *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v11; // rbx
			//   int32_t v12; // eax
			//   Object **Item; // rax
			//   Object *v14; // rbx
			//   __int64 v15; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   Color clearColor; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureDesc *v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   TextureDesc *result; // rax
			//   TextureDesc v27; // [rsp+30h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D919392 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D919392 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(153, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(153, 0LL);
			//     if ( Patch )
			//     {
			//       v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_74(&v27, Patch, (Object *)this, handle, 0LL);
			//       v23 = *(_OWORD *)&v22.colorFormat;
			//       *(_OWORD *)&retstr.width = *(_OWORD *)&v22.width;
			//       v24 = *(_OWORD *)&v22.enableRandomWrite;
			//       *(_OWORD *)&retstr.colorFormat = v23;
			//       v25 = *(_OWORD *)&v22.bindTextureMS;
			//       *(_OWORD *)&retstr.enableRandomWrite = v24;
			//       v19 = *(_OWORD *)&v22.fastMemoryDesc.inFastMemory;
			//       *(_OWORD *)&retstr.bindTextureMS = v25;
			//       clearColor = v22.clearColor;
			//       goto LABEL_14;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, v7);
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_12;
			//   if ( !m_RenderGraphResources.max_length.size )
			//     sub_180070270(v8, v7);
			//   v8 = m_RenderGraphResources.vector[0];
			//   if ( !v8 )
			//     goto LABEL_12;
			//   resourceArray = (DynamicArray_1_System_Object_ *)v8.fields.resourceArray;
			//   v11 = *handle;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
			//   if ( !resourceArray )
			//     goto LABEL_12;
			//   Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            resourceArray,
			//            v12,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   v14 = *Item;
			//   if ( !sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
			//     goto LABEL_12;
			//   v15 = sub_18003F5A0(v14, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//   v16 = *(_OWORD *)(v15 + 72);
			//   *(_OWORD *)&retstr.width = *(_OWORD *)(v15 + 56);
			//   v17 = *(_OWORD *)(v15 + 88);
			//   *(_OWORD *)&retstr.colorFormat = v16;
			//   v18 = *(_OWORD *)(v15 + 104);
			//   *(_OWORD *)&retstr.enableRandomWrite = v17;
			//   v19 = *(_OWORD *)(v15 + 120);
			//   *(_OWORD *)&retstr.bindTextureMS = v18;
			//   clearColor = *(Color *)(v15 + 136);
			// LABEL_14:
			//   result = retstr;
			//   *(_OWORD *)&retstr.fastMemoryDesc.inFastMemory = v19;
			//   retstr.clearColor = clearColor;
			//   return result;
			// }
			// 
			return null;
		}

		internal ref TextureDesc GetTextureResourceDescRef(ref ResourceHandle handle)
		{
			// // TextureDesc& GetTextureResourceDescRef(ResourceHandle ByRef)
			// TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v9; // rbx
			//   int32_t v10; // eax
			//   Object **Item; // rax
			//   Object *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919393 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D919393 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(148, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( !m_RenderGraphResources.max_length.size )
			//         sub_180070270(v6, v5);
			//       v6 = m_RenderGraphResources.vector[0];
			//       if ( v6 )
			//       {
			//         resourceArray = (DynamicArray_1_System_Object_ *)v6.fields.resourceArray;
			//         v9 = *handle;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
			//         if ( resourceArray )
			//         {
			//           Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                    resourceArray,
			//                    v10,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           v12 = *Item;
			//           if ( sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
			//             return (TextureDesc *)(sub_18003F5A0(v12, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 56);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(148, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(Patch, (Object *)this, handle, 0LL);
			// }
			// 
			return null;
		}

		internal bool TextureNeedsClear(in ResourceHandle handle)
		{
			// // Boolean TextureNeedsClear(ResourceHandle ByRef)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsClear(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v9; // rbx
			//   int32_t v10; // eax
			//   Object **Item; // rax
			//   Object *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919394 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D919394 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(165, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( !m_RenderGraphResources.max_length.size )
			//         sub_180070270(v6, v5);
			//       v6 = m_RenderGraphResources.vector[0];
			//       if ( v6 )
			//       {
			//         resourceArray = (DynamicArray_1_System_Object_ *)v6.fields.resourceArray;
			//         v9 = *handle;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
			//         if ( resourceArray )
			//         {
			//           Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                    resourceArray,
			//                    v10,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           v12 = *Item;
			//           if ( sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
			//             return *(_BYTE *)(sub_18003F5A0(v12, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 160);
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(165, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(Patch, (Object *)this, handle, 0LL);
			// }
			// 
			return default(bool);
		}

		internal void MarkTextureNeedsClearFlag(in ResourceHandle handle, bool flag)
		{
			// // Void MarkTextureNeedsClearFlag(ResourceHandle ByRef, Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::MarkTextureNeedsClearFlag(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         bool flag,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rbp
			//   ResourceHandle v11; // rbx
			//   int32_t v12; // eax
			//   Object **Item; // rax
			//   Object *v14; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919395 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D919395 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(167, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( !m_RenderGraphResources.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = m_RenderGraphResources.vector[0];
			//       if ( v8 )
			//       {
			//         resourceArray = (DynamicArray_1_System_Object_ *)v8.fields.resourceArray;
			//         v11 = *handle;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
			//         if ( resourceArray )
			//         {
			//           Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                    resourceArray,
			//                    v12,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           v14 = *Item;
			//           if ( sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
			//           {
			//             *(_BYTE *)(sub_18003F5A0(v14, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 160) = flag;
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(167, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_80(Patch, (Object *)this, handle, flag, 0LL);
			// }
			// 
		}

		internal void ForceTextureClear(in ResourceHandle handle, Color clearColor)
		{
			// // Void ForceTextureClear(ResourceHandle ByRef, Color)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ForceTextureClear(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         Color *clearColor,
			//         MethodInfo *method)
			// {
			//   TextureResource *TextureResource; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   TextureResource *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(243, 0LL) )
			//   {
			//     TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
			//                         this,
			//                         handle,
			//                         0LL);
			//     if ( TextureResource )
			//     {
			//       TextureResource.fields._.desc.clearBuffer = 1;
			//       v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(this, handle, 0LL);
			//       if ( v10 )
			//       {
			//         v10.fields._.desc.clearColor = *clearColor;
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(243, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   v12 = *clearColor;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(Patch, (Object *)this, handle, &v12, 0LL);
			// }
			// 
		}

		internal RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			// // RendererListHandle CreateRendererList(RendererListDesc ByRef)
			// RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererList(
			//         HGRenderGraphResourceRegistry *this,
			//         RendererListDesc *desc,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   RendererListResource_1 v10; // [rsp+20h] [rbp-1E8h] BYREF
			//   RendererListResource_1 value; // [rsp+110h] [rbp-F8h] BYREF
			//   RendererListHandle v12; // [rsp+228h] [rbp+20h]
			// 
			//   if ( !byte_18D919396 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Add);
			//     byte_18D919396 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(169, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(169, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_83(Patch, (Object *)this, desc, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateRendererListDesc(this, desc, 0LL);
			//     m_RendererListResources = this.fields.m_RendererListResources;
			//     sub_1802F01E0(&v10, 0LL, 240LL);
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource::RendererListResource(&v10, desc, 0LL);
			//     value = v10;
			//     if ( !m_RendererListResources )
			//       sub_180B536AC(&value.desc.overrideMaterial, 128LL);
			//     *(_DWORD *)&v12.m_IsValid = 1;
			//     v12._handle_k__BackingField = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::Add(
			//                                     (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)m_RendererListResources,
			//                                     &value,
			//                                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Add);
			//     return v12;
			//   }
			// }
			// 
			return null;
		}

		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			// // ComputeBufferHandle ImportComputeBuffer(ComputeBuffer)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportComputeBuffer(
			//         HGRenderGraphResourceRegistry *this,
			//         ComputeBuffer *computeBuffer,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   Object *v6; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   int32_t v10; // r10d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferHandle v13; // [rsp+20h] [rbp-18h] BYREF
			//   String *v14; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v15; // [rsp+30h] [rbp-8h]
			//   Object *outRes; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919397 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
			//     byte_18D919397 = 1;
			//   }
			//   outRes = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(172, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( m_RenderGraphResources.max_length.size <= 1u )
			//         sub_180070270(v6, v5);
			//       v6 = (Object *)m_RenderGraphResources.vector[1];
			//       if ( v6 )
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//           (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v6,
			//           &outRes,
			//           1,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
			//         v6 = outRes;
			//         if ( outRes )
			//         {
			//           outRes[5].klass = (Object__Class *)computeBuffer;
			//           sub_1800054D0((OneofDescriptor *)&v6[5], v5, v8, v9, *(String__Array **)&v13, v14, v15);
			//           if ( outRes )
			//           {
			//             v13 = 0LL;
			//             LOBYTE(outRes[1].klass) = 1;
			//             HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(&v13, v10, 0, 0LL);
			//             return v13;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(172, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(Patch, (Object *)this, (Object *)computeBuffer, 0LL);
			// }
			// 
			return null;
		}

		internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, [MetadataOffset(Offset = "0x01F90A07")] int transientPassIndex = -1)
		{
			// // ComputeBufferHandle CreateComputeBuffer(ComputeBufferDesc ByRef, Int32)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
			//         HGRenderGraphResourceRegistry *this,
			//         ComputeBufferDesc *desc,
			//         int32_t transientPassIndex,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   Object *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   String *name; // xmm1_8
			//   int32_t v13; // r10d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v16; // [rsp+20h] [rbp-28h]
			//   String *v17; // [rsp+28h] [rbp-20h]
			//   Object *outRes; // [rsp+30h] [rbp-18h] BYREF
			//   ComputeBufferHandle v19; // [rsp+38h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919398 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
			//     byte_18D919398 = 1;
			//   }
			//   outRes = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(174, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateComputeBufferDesc(this, desc, 0LL);
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( m_RenderGraphResources.max_length.size <= 1u )
			//         sub_180070270(v8, v7);
			//       v8 = (Object *)m_RenderGraphResources.vector[1];
			//       if ( v8 )
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
			//           (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v8,
			//           &outRes,
			//           1,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
			//         v8 = outRes;
			//         name = desc.name;
			//         if ( outRes )
			//         {
			//           *(Object *)((char *)outRes + 56) = *(Object *)&desc.count;
			//           v8[4].monitor = (MonitorData *)name;
			//           sub_1800054D0((OneofDescriptor *)&v8[4].monitor, v7, v10, v11, v16, v17, (MethodInfo *)outRes);
			//           if ( outRes )
			//           {
			//             v19 = 0LL;
			//             HIDWORD(outRes[1].monitor) = transientPassIndex;
			//             HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(&v19, v13, 0, 0LL);
			//             return v19;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(174, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(Patch, (Object *)this, desc, transientPassIndex, 0LL);
			// }
			// 
			return null;
		}

		internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle)
		{
			// // ComputeBufferDesc GetComputeBufferResourceDesc(ResourceHandle ByRef)
			// ComputeBufferDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
			//         ComputeBufferDesc *__return_ptr retstr,
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v11; // rbx
			//   int32_t v12; // eax
			//   Object **Item; // rax
			//   Object *v14; // rbx
			//   __int64 v15; // rax
			//   __int128 v16; // xmm0
			//   String *name; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferDesc *v19; // rax
			//   ComputeBufferDesc *result; // rax
			//   ComputeBufferDesc v21; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919399 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919399 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(177, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(177, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_88(&v21, Patch, (Object *)this, handle, 0LL);
			//       v16 = *(_OWORD *)&v19.count;
			//       name = v19.name;
			//       goto LABEL_14;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, v7);
			//   }
			//   m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_12;
			//   if ( m_RenderGraphResources.max_length.size <= 1u )
			//     sub_180070270(v8, v7);
			//   v8 = m_RenderGraphResources.vector[1];
			//   if ( !v8 )
			//     goto LABEL_12;
			//   resourceArray = (DynamicArray_1_System_Object_ *)v8.fields.resourceArray;
			//   v11 = *handle;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
			//   if ( !resourceArray )
			//     goto LABEL_12;
			//   Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            resourceArray,
			//            v12,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   v14 = *Item;
			//   if ( !sub_18003F5A0(*Item, TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource) )
			//     goto LABEL_12;
			//   v15 = sub_18003F5A0(v14, TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
			//   v16 = *(_OWORD *)(v15 + 56);
			//   name = *(String **)(v15 + 72);
			// LABEL_14:
			//   result = retstr;
			//   *(_OWORD *)&retstr.count = v16;
			//   retstr.name = name;
			//   return result;
			// }
			// 
			return null;
		}

		internal int GetComputeBufferResourceCount()
		{
			// // Int32 GetComputeBufferResourceCount()
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceCount(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91939A )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_size);
			//     byte_18D91939A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(40, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( m_RenderGraphResources.max_length.size <= 1u )
			//         sub_180070270(v4, v3);
			//       v6 = m_RenderGraphResources.vector[1];
			//       if ( v6 )
			//       {
			//         resourceArray = v6.fields.resourceArray;
			//         if ( resourceArray )
			//           return resourceArray.fields._size_k__BackingField;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(40, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle)
		{
			// // ComputeBufferResource GetComputeBufferResource(ResourceHandle ByRef)
			// ComputeBufferResource *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResource(
			//         HGRenderGraphResourceRegistry *this,
			//         ResourceHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
			//   DynamicArray_1_System_Object_ *resourceArray; // rsi
			//   ResourceHandle v9; // rbx
			//   int32_t v10; // eax
			//   Object **Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91939B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91939B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(282, 0LL) )
			//   {
			//     m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       if ( m_RenderGraphResources.max_length.size <= 1u )
			//         sub_180070270(v6, v5);
			//       v6 = m_RenderGraphResources.vector[1];
			//       if ( v6 )
			//       {
			//         resourceArray = (DynamicArray_1_System_Object_ *)v6.fields.resourceArray;
			//         v9 = *handle;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
			//         if ( resourceArray )
			//         {
			//           Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                    resourceArray,
			//                    v10,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//           return (ComputeBufferResource *)sub_18003F5A0(
			//                                             *Item,
			//                                             TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(282, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_132(Patch, (Object *)this, handle, 0LL);
			// }
			// 
			return null;
		}

		internal void ReleaseUnusedPreservedResources()
		{
			// // Void ReleaseUnusedPreservedResources()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseUnusedPreservedResources(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   Object *v3; // rdx
			//   unsigned int v4; // ebx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
			//   DynamicArray_1_System_Object_ *klass; // rbp
			//   int32_t v7; // esi
			//   __int64 v8; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91939C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D91939C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(90, 0LL) )
			//   {
			//     v4 = 0;
			//     while ( 1 )
			//     {
			//       m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//       if ( !m_RenderGraphResources )
			//         break;
			//       if ( v4 >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(m_RenderGraphResources, v3);
			//       v3 = (Object *)m_RenderGraphResources.vector[v4];
			//       if ( !v3 )
			//         break;
			//       klass = (DynamicArray_1_System_Object_ *)v3[1].klass;
			//       v7 = 0;
			//       if ( !klass )
			//         break;
			//       do
			//       {
			//         v3 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                 klass,
			//                 v7,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//         if ( v3
			//           && BYTE1(v3[1].klass)
			//           && LODWORD(v3[2].klass) == this.fields.m_currentExecutorID
			//           && HIDWORD(v3[2].klass) + LODWORD(v3[2].monitor) - 1 < this.fields.m_currentExecutorFrameIndex )
			//         {
			//           LOBYTE(v8) = 1;
			//           sub_18000F800(12LL, v3, (unsigned int)this.fields.m_CurrentFrameIndex, v8);
			//         }
			//         ++v7;
			//       }
			//       while ( v7 < 64 );
			//       if ( (int)++v4 >= 2 )
			//         return;
			//     }
			// LABEL_19:
			//     sub_180B536AC(m_RenderGraphResources, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(90, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void ReleaseAllPreservedResources(int executorID)
		{
			// // Void ReleaseAllPreservedResources(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseAllPreservedResources(
			//         HGRenderGraphResourceRegistry *this,
			//         int32_t executorID,
			//         MethodInfo *method)
			// {
			//   Object *v5; // rdx
			//   __int64 v6; // rcx
			//   unsigned int v7; // esi
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v9; // rdi
			//   DynamicArray_1_System_Object_ *resourceArray; // rdi
			//   int32_t v11; // ebx
			//   __int64 v12; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED953 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D8ED953 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(163, 0LL) )
			//   {
			//     v7 = 0;
			//     while ( 1 )
			//     {
			//       m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//       if ( !m_RenderGraphResources )
			//         break;
			//       if ( v7 >= m_RenderGraphResources.max_length.size )
			//         sub_180070270(v6, v5);
			//       v9 = m_RenderGraphResources.vector[v7];
			//       if ( !v9 )
			//         break;
			//       resourceArray = (DynamicArray_1_System_Object_ *)v9.fields.resourceArray;
			//       v11 = 0;
			//       if ( !resourceArray )
			//         break;
			//       do
			//       {
			//         v5 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                 resourceArray,
			//                 v11,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//         if ( v5 && BYTE1(v5[1].klass) && LODWORD(v5[2].klass) == executorID )
			//         {
			//           LOBYTE(v12) = 1;
			//           sub_18000F800(12LL, v5, (unsigned int)this.fields.m_CurrentFrameIndex, v12);
			//         }
			//         ++v11;
			//       }
			//       while ( v11 < 64 );
			//       if ( (int)++v7 >= 2 )
			//         return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(163, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, executorID, 0LL);
			// }
			// 
		}

		internal void CreatePooledResource(HGRenderGraphContext rgContext, int type, int index, string name)
		{
			// // Void CreatePooledResource(HGRenderGraphContext, Int32, Int32, String)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreatePooledResource(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphContext *rgContext,
			//         int32_t type,
			//         int32_t index,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdi
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Object **Item; // rax
			//   __int64 v13; // r8
			//   Object *v14; // rbx
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
			//   __int64 v16; // rax
			//   __int64 v17; // rax
			// 
			//   v7 = type;
			//   if ( !byte_18D91939D )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D91939D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(81, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(81, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_42(
			//         Patch,
			//         (Object *)this,
			//         (Object *)rgContext,
			//         v7,
			//         index,
			//         (Object *)name,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_21;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_RenderGraphResources;
			//   if ( !Patch )
			//     goto LABEL_21;
			//   if ( (unsigned int)v7 >= Patch.fields.methodId )
			// LABEL_19:
			//     sub_180070270(Patch, v10);
			//   v10 = *((_QWORD *)&Patch.fields.anonObj + v7);
			//   if ( !v10 )
			//     goto LABEL_21;
			//   Patch = *(ILFixDynamicMethodWrapper_2 **)(v10 + 16);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            (DynamicArray_1_System_Object_ *)Patch,
			//            index,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   v14 = *Item;
			//   if ( !*Item )
			//     goto LABEL_21;
			//   if ( !LOBYTE(v14[1].klass) && !BYTE1(v14[1].klass) )
			//   {
			//     LOBYTE(v13) = 1;
			//     sub_18082F3A8(Patch, *Item, v13, name);
			//     m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//     if ( !m_RenderGraphDebug )
			//       goto LABEL_21;
			//     if ( m_RenderGraphDebug.fields.enableLogging )
			//       sub_18005B3A0(15LL, v14, this.fields.m_FrameInformationLogger);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_RenderGraphResources;
			//     if ( !Patch )
			//       goto LABEL_21;
			//     if ( (unsigned int)v7 < Patch.fields.methodId )
			//     {
			//       v16 = *((_QWORD *)&Patch.fields.anonObj + v7);
			//       if ( v16 )
			//       {
			//         v17 = *(_QWORD *)(v16 + 32);
			//         if ( v17 )
			//           (*(void (__fastcall **)(_QWORD, HGRenderGraphContext *, Object *, _QWORD))(v17 + 24))(
			//             *(_QWORD *)(v17 + 64),
			//             rgContext,
			//             v14,
			//             *(_QWORD *)(v17 + 40));
			//         return;
			//       }
			// LABEL_21:
			//       sub_180B536AC(Patch, v10);
			//     }
			//     goto LABEL_19;
			//   }
			// }
			// 
		}

		private void CreateTextureCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res)
		{
			// // Void CreateTextureCallback(HGRenderGraphContext, IHGRenderGraphResource)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTextureCallback(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphContext *rgContext,
			//         IHGRenderGraphResource *res,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rdi
			//   RTHandle *v11; // rsi
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rsi
			//   bool v13; // r14
			//   int v14; // esi
			//   __m128 si128; // xmm2
			//   CommandBuffer *cmd; // r14
			//   RTHandle *v17; // r15
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   char v21; // [rsp+40h] [rbp-58h] BYREF
			//   __int64 v22; // [rsp+48h] [rbp-50h]
			//   Il2CppExceptionWrapper *v23; // [rsp+50h] [rbp-48h] BYREF
			//   FastMemoryFlags__Enum flags[4]; // [rsp+60h] [rbp-38h] BYREF
			//   Il2CppException *ex; // [rsp+70h] [rbp-28h]
			//   char *v26; // [rsp+78h] [rbp-20h]
			// 
			//   if ( !byte_18D91939E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D91939E = 1;
			//   }
			//   v21 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(304, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(304, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)rgContext,
			//       (Object *)res,
			//       0LL);
			//   }
			//   else
			//   {
			//     v7 = sub_18003F5A0(res, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     v10 = v7;
			//     v22 = v7;
			//     if ( !v7 )
			//       sub_180B536AC(v9, v8);
			//     *(_QWORD *)flags = *(_QWORD *)(v7 + 120);
			//     if ( LOBYTE(flags[0]) )
			//     {
			//       v11 = *(RTHandle **)(v7 + 152);
			//       if ( !rgContext )
			//         sub_180B536AC(v9, v8);
			//       if ( !v11 )
			//         sub_180B536AC(v9, v8);
			//       UnityEngine::Rendering::RTHandle::SwitchToFastMemory(
			//         v11,
			//         rgContext.fields.cmd,
			//         *(float *)(v7 + 128),
			//         flags[1],
			//         0,
			//         0LL);
			//     }
			//     if ( !v10 )
			//       sub_180B536AC(v9, v8);
			//     *(_BYTE *)(v10 + 160) = *(_BYTE *)(v10 + 133);
			//     m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//     if ( !m_RenderGraphDebug )
			//       sub_180B536AC(v9, v8);
			//     if ( m_RenderGraphDebug.fields.clearRenderTargetsAtCreation )
			//     {
			//       v13 = *(_BYTE *)(v10 + 133) == 0;
			//       if ( !rgContext )
			//         sub_180B536AC(v9, v8);
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)(v13 + 2),
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//       ex = 0LL;
			//       v26 = &v21;
			//       try
			//       {
			//         v14 = *(_DWORD *)(v10 + 68) != 0 ? 5 : 0;
			//         if ( v13 )
			//           si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18C1756D0);
			//         else
			//           si128 = (__m128)_mm_loadu_si128((const __m128i *)(v10 + 136));
			//         cmd = rgContext.fields.cmd;
			//         v17 = *(RTHandle **)(v10 + 152);
			//         flags[0] = (FastMemoryFlags__Enum)si128.m128_i32[0];
			//         flags[1] = _mm_shuffle_ps(si128, si128, 85).m128_u32[0];
			//         flags[2] = _mm_shuffle_ps(si128, si128, 170).m128_u32[0];
			//         flags[3] = _mm_shuffle_ps(si128, si128, 255).m128_u32[0];
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//           cmd,
			//           v17,
			//           (ClearFlag__Enum)(v14 + 1),
			//           (Color *)flags,
			//           0,
			//           CubemapFace__Enum_Unknown,
			//           -1,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v23 )
			//       {
			//         ex = v23.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v10 = v22;
			//       }
			//       *(_BYTE *)(v10 + 160) = 0;
			//     }
			//   }
			// }
			// 
		}

		internal void ReleasePooledResource(HGRenderGraphContext rgContext, int type, int index)
		{
			// // Void ReleasePooledResource(HGRenderGraphContext, Int32, Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphContext *rgContext,
			//         int32_t type,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rsi
			//   __int64 v9; // rdx
			//   DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
			//   Object *v11; // rdi
			//   __int64 v12; // r9
			//   __int64 v13; // rax
			//   __int64 v14; // rax
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v6 = type;
			//   if ( !byte_18D91939F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//     byte_18D91939F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(87, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(87, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_55(
			//         (ILFixDynamicMethodWrapper_8 *)Patch,
			//         (Object *)this,
			//         (Object *)rgContext,
			//         v6,
			//         index,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_22;
			//   }
			//   m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_22;
			//   if ( (unsigned int)v6 >= m_RenderGraphResources.fields._size_k__BackingField )
			// LABEL_20:
			//     sub_180070270(m_RenderGraphResources, v9);
			//   v9 = *((_QWORD *)&m_RenderGraphResources[1].klass + v6);
			//   if ( !v9 )
			//     goto LABEL_22;
			//   m_RenderGraphResources = *(DynamicArray_1_System_Object_ **)(v9 + 16);
			//   if ( !m_RenderGraphResources )
			//     goto LABEL_22;
			//   v11 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            m_RenderGraphResources,
			//            index,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
			//   if ( !v11 )
			//     goto LABEL_22;
			//   if ( LOBYTE(v11[1].klass) || BYTE1(v11[1].klass) )
			//     return;
			//   m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this.fields.m_RenderGraphResources;
			//   if ( !m_RenderGraphResources )
			// LABEL_22:
			//     sub_180B536AC(m_RenderGraphResources, v9);
			//   if ( (unsigned int)v6 >= m_RenderGraphResources.fields._size_k__BackingField )
			//     goto LABEL_20;
			//   v13 = *((_QWORD *)&m_RenderGraphResources[1].klass + v6);
			//   if ( !v13 )
			//     goto LABEL_22;
			//   v14 = *(_QWORD *)(v13 + 40);
			//   if ( v14 )
			//     (*(void (__fastcall **)(_QWORD, HGRenderGraphContext *, Object *, _QWORD))(v14 + 24))(
			//       *(_QWORD *)(v14 + 64),
			//       rgContext,
			//       v11,
			//       *(_QWORD *)(v14 + 40));
			//   m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//   if ( !m_RenderGraphDebug )
			//     goto LABEL_22;
			//   if ( m_RenderGraphDebug.fields.enableLogging )
			//     sub_18005B3A0(16LL, v11, this.fields.m_FrameInformationLogger);
			//   LOBYTE(v12) = 1;
			//   sub_18000F800(12LL, v11, (unsigned int)this.fields.m_CurrentFrameIndex, v12);
			// }
			// 
		}

		private void ReleaseTextureCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res)
		{
			// // Void ReleaseTextureCallback(HGRenderGraphContext, IHGRenderGraphResource)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseTextureCallback(
			//         HGRenderGraphResourceRegistry *this,
			//         HGRenderGraphContext *rgContext,
			//         IHGRenderGraphResource *res,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // r14
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rdi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // edi
			//   CommandBuffer *cmd; // rsi
			//   RTHandle *v15; // r14
			//   __m128i si128; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   char v20; // [rsp+40h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v21; // [rsp+48h] [rbp-40h] BYREF
			//   Il2CppException *ex; // [rsp+50h] [rbp-38h]
			//   char *v23; // [rsp+58h] [rbp-30h]
			//   __m128i v24; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9193A0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     byte_18D9193A0 = 1;
			//   }
			//   v20 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(305, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(305, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v19, v18);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)rgContext,
			//       (Object *)res,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = sub_18003F5A0(res, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
			//     m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//     if ( !m_RenderGraphDebug )
			//       sub_180B536AC(v8, v7);
			//     if ( m_RenderGraphDebug.fields.clearRenderTargetsAtRelease )
			//     {
			//       if ( !rgContext )
			//         sub_180B536AC(v8, v7);
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)3u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//       ex = 0LL;
			//       v23 = &v20;
			//       try
			//       {
			//         if ( !v9 )
			//           sub_1802DC2C8(v12, v11);
			//         v13 = *(_DWORD *)(v9 + 68) != 0 ? 5 : 0;
			//         cmd = rgContext.fields.cmd;
			//         v15 = *(RTHandle **)(v9 + 152);
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18C1756D0);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         v24 = si128;
			//         UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//           cmd,
			//           v15,
			//           (ClearFlag__Enum)(v13 + 1),
			//           (Color *)&v24,
			//           0,
			//           CubemapFace__Enum_Unknown,
			//           -1,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v21 )
			//       {
			//         ex = v21.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void ValidateTextureDesc(ref TextureDesc desc)
		{
			// // Void ValidateTextureDesc(TextureDesc ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateTextureDesc(
			//         HGRenderGraphResourceRegistry *this,
			//         TextureDesc *desc,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(146, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(146, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(Patch, (Object *)this, desc, 0LL);
			//   }
			// }
			// 
		}

		private void ValidateRendererListDesc(in RendererListDesc desc)
		{
			// // Void ValidateRendererListDesc(RendererListDesc ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateRendererListDesc(
			//         HGRenderGraphResourceRegistry *this,
			//         RendererListDesc *desc,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(170, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(170, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_82(Patch, (Object *)this, desc, 0LL);
			//   }
			// }
			// 
		}

		private void ValidateComputeBufferDesc(in ComputeBufferDesc desc)
		{
			// // Void ValidateComputeBufferDesc(ComputeBufferDesc ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateComputeBufferDesc(
			//         HGRenderGraphResourceRegistry *this,
			//         ComputeBufferDesc *desc,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(175, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(175, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_85(Patch, (Object *)this, desc, 0LL);
			//   }
			// }
			// 
		}

		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, [MetadataOffset(Offset = "0x01F90A08")] bool manualDispatch = false)
		{
			// // Void CreateRendererLists(List`1[HG.Rendering.RenderGraphModule.RendererListHandle], ScriptableRenderContext, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
			//         HGRenderGraphResourceRegistry *this,
			//         List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *rendererLists,
			//         ScriptableRenderContext context,
			//         bool manualDispatch,
			//         MethodInfo *method)
			// {
			//   bool P3; // si
			//   Object *v7; // rdi
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object__Class *klass; // rbx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *monitor; // rbx
			//   int32_t v12; // eax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   RendererListResource_1 *Item; // rbx
			//   RendererList *v16; // rax
			//   __int64 v17; // rdx
			//   SpawnerManager_SpawnDataDetail v18; // xmm0
			//   List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *v19; // rcx
			//   List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *v20; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   Il2CppException *ex; // [rsp+30h] [rbp-248h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v25; // [rsp+40h] [rbp-238h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v26; // [rsp+58h] [rbp-220h] BYREF
			//   Il2CppExceptionWrapper *v27; // [rsp+70h] [rbp-208h] BYREF
			//   SpawnerManager_SpawnDataDetail v28; // [rsp+80h] [rbp-1F8h] BYREF
			//   RendererListDesc desc; // [rsp+90h] [rbp-1E8h]
			//   RendererListDesc v30; // [rsp+170h] [rbp-108h] BYREF
			//   ScriptableRenderContext P2; // [rsp+290h] [rbp+18h] BYREF
			//   bool v33; // [rsp+298h] [rbp+20h]
			// 
			//   v33 = manualDispatch;
			//   P2.m_Ptr = context.m_Ptr;
			//   P3 = manualDispatch;
			//   v7 = (Object *)this;
			//   if ( !byte_18D9193A1 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D9193A1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(57, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(57, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v23, v22);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_32(Patch, v7, (Object *)rendererLists, P2, P3, 0LL);
			//   }
			//   else
			//   {
			//     klass = v7[5].klass;
			//     if ( !klass )
			//       sub_180B536AC(v9, v8);
			//     ++HIDWORD(klass._0.namespaze);
			//     LODWORD(klass._0.namespaze) = 0;
			//     if ( !rendererLists )
			//       sub_180B536AC(v9, v8);
			//     System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v26,
			//       (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)rendererLists,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     v25 = v26;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                 &v25,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
			//       {
			//         monitor = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)v7[1].monitor;
			//         v12 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit((RendererListHandle)v25._current, 0LL);
			//         if ( !monitor )
			//           sub_1802DC2C8(v14, v13);
			//         Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
			//                  monitor,
			//                  v12,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
			//         desc = Item.desc;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         v30 = desc;
			//         v16 = UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList((RendererList *)&v26, &P2, &v30, 0LL);
			//         v18 = (SpawnerManager_SpawnDataDetail)*v16;
			//         Item.rendererList = *v16;
			//         v19 = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)v7[5].klass;
			//         if ( !v19 )
			//           sub_1802DC2C8(0LL, v17);
			//         v28 = v18;
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
			//           v19,
			//           &v28,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::Add);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v27 )
			//     {
			//       ex = v27.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       P3 = v33;
			//       v7 = (Object *)this;
			//     }
			//     if ( P3 )
			//     {
			//       v20 = (List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *)v7[5].klass;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       UnityEngine::Rendering::ScriptableRenderContext::PrepareRendererListsAsync(&P2, v20, 0LL);
			//     }
			//   }
			// }
			// 
		}

		internal void Clear(bool onException)
		{
			// // Void Clear(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Clear(
			//         HGRenderGraphResourceRegistry *this,
			//         bool onException,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   int i; // edi
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *m_RenderGraphResources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193A2 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::Clear);
			//     byte_18D9193A2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(104, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::LogResources(this, 0LL);
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this.fields.m_RenderGraphResources;
			//       if ( !m_RenderGraphResources )
			//         goto LABEL_14;
			//       if ( (unsigned int)i >= LODWORD(m_RenderGraphResources.fields.pool) )
			//         sub_180070270(m_RenderGraphResources, v5);
			//       m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)*((_QWORD *)&m_RenderGraphResources.fields.createResourceCallback
			//                                                                                            + i);
			//       if ( !m_RenderGraphResources )
			//         goto LABEL_14;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Clear(
			//         m_RenderGraphResources,
			//         onException,
			//         this.fields.m_CurrentFrameIndex,
			//         0LL);
			//     }
			//     m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this.fields.m_RendererListResources;
			//     if ( m_RenderGraphResources )
			//     {
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_RenderGraphResources,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Clear);
			//       m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this.fields.m_ActiveRendererLists;
			//       if ( m_RenderGraphResources )
			//       {
			//         ++HIDWORD(m_RenderGraphResources.fields.pool);
			//         LODWORD(m_RenderGraphResources.fields.pool) = 0;
			//         return;
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_RenderGraphResources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(104, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     onException,
			//     0LL);
			// }
			// 
		}

		internal void PurgeUnusedGraphicsResources()
		{
			// // Void PurgeUnusedGraphicsResources()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PurgeUnusedGraphicsResources(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // r8
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *wrapperArray; // rcx
			//   unsigned int v5; // ebx
			//   unsigned int m_CurrentFrameIndex; // ebp
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v7; // rdi
			//   ILFixDynamicMethodWrapper_2 *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size <= 131 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   method = (MethodInfo *)v3.static_fields.wrapperArray;
			//   if ( !method )
			//     goto LABEL_22;
			//   if ( LODWORD(method.name) <= 0x83 )
			// LABEL_23:
			//     sub_180070270(wrapperArray, method);
			//   if ( !method[12].name )
			//   {
			// LABEL_7:
			//     v5 = 0;
			//     while ( 1 )
			//     {
			//       wrapperArray = this.fields.m_RenderGraphResources;
			//       if ( !wrapperArray )
			//         break;
			//       if ( v5 >= wrapperArray.max_length.size )
			//         goto LABEL_23;
			//       m_CurrentFrameIndex = this.fields.m_CurrentFrameIndex;
			//       v7 = wrapperArray.vector[v5];
			//       if ( !v7 )
			//         break;
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         byte_18D8EDC37 = 1;
			//       }
			//       if ( !v3._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v3, method);
			//         v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       method = (MethodInfo *)v3.static_fields.wrapperArray;
			//       if ( !method )
			//         break;
			//       if ( SLODWORD(method.name) <= 132 )
			//         goto LABEL_17;
			//       if ( !v3._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v3, method);
			//         v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       wrapperArray = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)v3.static_fields.wrapperArray;
			//       if ( !wrapperArray )
			//         break;
			//       if ( wrapperArray.max_length.size <= 0x84u )
			//         goto LABEL_23;
			//       if ( wrapperArray[3].vector[24] )
			//       {
			//         Patch = IFix::WrappersManagerImpl::GetPatch(132, 0LL);
			//         if ( !Patch )
			//           break;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//           (ILFixDynamicMethodWrapper_26 *)Patch,
			//           (Object *)v7,
			//           m_CurrentFrameIndex,
			//           0LL);
			//       }
			//       else
			//       {
			// LABEL_17:
			//         method = (MethodInfo *)v7.fields.pool;
			//         if ( !method )
			//           break;
			//         sub_1800491C0(4LL, method, m_CurrentFrameIndex);
			//       }
			//       if ( (int)++v5 >= 2 )
			//         return;
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			// LABEL_22:
			//     sub_180B536AC(wrapperArray, method);
			//   }
			//   v8 = IFix::WrappersManagerImpl::GetPatch(131, 0LL);
			//   if ( !v8 )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)v8, (Object *)this, 0LL);
			// }
			// 
		}

		internal void Cleanup()
		{
			// // Void Cleanup()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Cleanup(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   int32_t v4; // ebx
			//   int i; // edi
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
			//   RTHandle__Array *m_CurrentBackbuffer; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(122, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(122, 0LL);
			//     if ( !Patch )
			// LABEL_14:
			//       sub_180B536AC(m_RenderGraphResources, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v4 = 0;
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//       if ( !m_RenderGraphResources )
			//         goto LABEL_14;
			//       if ( (unsigned int)i >= m_RenderGraphResources.max_length.size )
			// LABEL_16:
			//         sub_180070270(m_RenderGraphResources, v3);
			//       m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)m_RenderGraphResources.vector[i];
			//       if ( !m_RenderGraphResources )
			//         goto LABEL_14;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Cleanup(
			//         (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)m_RenderGraphResources,
			//         0LL);
			//     }
			//     if ( this.fields.m_CurrentBackbuffer )
			//     {
			//       m_CurrentBackbuffer = this.fields.m_CurrentBackbuffer;
			//       while ( v4 < m_CurrentBackbuffer.max_length.size )
			//       {
			//         if ( (unsigned int)v4 >= m_CurrentBackbuffer.max_length.size )
			//           goto LABEL_16;
			//         m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)m_CurrentBackbuffer.vector[v4];
			//         if ( m_RenderGraphResources )
			//           UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_RenderGraphResources, 0LL);
			//         ++v4;
			//       }
			//     }
			//   }
			// }
			// 
		}

		internal void FlushLogs()
		{
			// // Void FlushLogs()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::FlushLogs(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(133, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(133, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void LogResources()
		{
			// // Void LogResources()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::LogResources(
			//         HGRenderGraphResourceRegistry *this,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *pool; // rdx
			//   HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
			//   HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
			//   HGRenderGraphLogger *m_ResourceLogger; // rdi
			//   Object__Array *v7; // rax
			//   unsigned int v8; // edi
			//   HGRenderGraphLogger *v9; // rsi
			//   Object__Array *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193A3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&off_18D4DF778);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D9193A3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(105, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(105, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_RenderGraphDebug = this.fields.m_RenderGraphDebug;
			//     if ( !m_RenderGraphDebug )
			//       goto LABEL_17;
			//     if ( m_RenderGraphDebug.fields.enableLogging )
			//     {
			//       m_ResourceLogger = this.fields.m_ResourceLogger;
			//       v7 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//       if ( m_ResourceLogger )
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//           m_ResourceLogger,
			//           (String *)"==== Allocated Resources ====\n",
			//           v7,
			//           0LL);
			//         v8 = 0;
			//         while ( 1 )
			//         {
			//           m_RenderGraphResources = this.fields.m_RenderGraphResources;
			//           if ( !m_RenderGraphResources )
			//             break;
			//           if ( v8 >= m_RenderGraphResources.max_length.size )
			//             sub_180070270(m_RenderGraphResources, pool);
			//           pool = m_RenderGraphResources.vector[v8];
			//           if ( !pool )
			//             break;
			//           pool = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)pool.fields.pool;
			//           if ( !pool )
			//             break;
			//           sub_18005B3A0(7LL, pool, this.fields.m_ResourceLogger);
			//           v9 = this.fields.m_ResourceLogger;
			//           v10 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//           if ( !v9 )
			//             break;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v9, (String *)"", v10, 0LL);
			//           if ( (int)++v8 >= 2 )
			//             return;
			//         }
			//       }
			// LABEL_17:
			//       sub_180B536AC(m_RenderGraphResources, pool);
			//     }
			//   }
			// }
			// 
		}

		private const int MAXIMUM_PRESERVED_RESOURCE_COUNT = 64;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static HGRenderGraphResourceRegistry m_CurrentRegistry;

		private HGRenderGraphResourceRegistry.HGRenderGraphResourcesData[] m_RenderGraphResources;

		private DynamicArray<RendererListResource> m_RendererListResources;

		private HGRenderGraphDebugParams m_RenderGraphDebug;

		private HGRenderGraphLogger m_ResourceLogger;

		private HGRenderGraphLogger m_FrameInformationLogger;

		private int m_CurrentFrameIndex;

		private int m_ExecutionCount;

		private int m_currentExecutorID;

		private int m_currentExecutorFrameIndex;

		private RTHandle[] m_CurrentBackbuffer;

		private const int kInitialRendererListCount = 256;

		private List<RendererList> m_ActiveRendererLists;

		internal enum BackBufferType
		{
			Color,
			Depth,
			Count
		}

		// (Invoke) Token: 0x060002DB RID: 731
		private delegate void ResourceCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res);

		private class HGRenderGraphResourcesData
		{
			public HGRenderGraphResourcesData()
			{
			}

			public void Clear(bool onException, int frameIndex)
			{
				// // Void Clear(Boolean, Int32)
				// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Clear(
				//         HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
				//         bool onException,
				//         int32_t frameIndex,
				//         MethodInfo *method)
				// {
				//   IHGRenderGraphResourcePool *pool; // rdx
				//   DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rcx
				//   __int64 v9; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9193A4 )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
				//     byte_18D9193A4 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(106, 0LL) )
				//   {
				//     resourceArray = this.fields.resourceArray;
				//     if ( resourceArray )
				//     {
				//       UnityEngine::Rendering::DynamicArray<System::Object>::Resize(
				//         (DynamicArray_1_System_Object_ *)resourceArray,
				//         64,
				//         0,
				//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
				//       pool = this.fields.pool;
				//       if ( pool )
				//       {
				//         LOBYTE(v9) = onException;
				//         sub_18042C160(6LL, pool, v9);
				//         return;
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(resourceArray, pool);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(106, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_100(
				//     (ILFixDynamicMethodWrapper_8 *)Patch,
				//     (Object *)this,
				//     onException,
				//     frameIndex,
				//     0LL);
				// }
				// 
			}

			public void Cleanup()
			{
				// // Void Cleanup()
				// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Cleanup(
				//         HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   IHGRenderGraphResourcePool *pool; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(123, 0LL) )
				//   {
				//     pool = this.fields.pool;
				//     if ( pool )
				//     {
				//       sub_180040B30(5LL, pool);
				//       return;
				//     }
				// LABEL_4:
				//     sub_180B536AC(v3, pool);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(123, 0LL);
				//   if ( !Patch )
				//     goto LABEL_4;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			public void PurgeUnusedGraphicsResources(int frameIndex)
			{
				// // Void PurgeUnusedGraphicsResources(Int32)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::PurgeUnusedGraphicsResources(
				//         HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
				//         int32_t frameIndex,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   IHGRenderGraphResourcePool *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&frameIndex);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = (IHGRenderGraphResourcePool *)v5.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_9;
				//   if ( SLODWORD(wrapperArray[1].monitor) <= 132 )
				//     goto LABEL_7;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, wrapperArray);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
				//   if ( !v5 )
				//     goto LABEL_9;
				//   if ( LODWORD(v5._0.namespaze) <= 0x84 )
				//     sub_180070270(v5, wrapperArray);
				//   if ( !v5[2].vtable.Finalize.method )
				//   {
				// LABEL_7:
				//     wrapperArray = this.fields.pool;
				//     if ( wrapperArray )
				//     {
				//       sub_1800491C0(4LL, wrapperArray, (unsigned int)frameIndex);
				//       return;
				//     }
				// LABEL_9:
				//     sub_180B536AC(v5, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(132, 0LL);
				//   if ( !Patch )
				//     goto LABEL_9;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, frameIndex, 0LL);
				// }
				// 
			}

			public int AddNewRenderGraphResource<ResType>(out ResType outRes, [MetadataOffset(Offset = "0x01F90A10")] bool pooledResource = true) where ResType : IHGRenderGraphResource, new()
			{
				return 0;
			}

			public DynamicArray<IHGRenderGraphResource> resourceArray;

			public IHGRenderGraphResourcePool pool;

			public HGRenderGraphResourceRegistry.ResourceCallback createResourceCallback;

			public HGRenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;
		}
	}
}
