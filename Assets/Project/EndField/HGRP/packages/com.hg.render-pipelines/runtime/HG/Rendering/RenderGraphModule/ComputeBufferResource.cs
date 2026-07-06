using System;
using System.Diagnostics;
using UnityEngine;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : HGRenderGraphResource<ComputeBufferDesc, ComputeBuffer>
	{
		public ComputeBufferResource()
		{
			// // ComputeBufferResource()
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::ComputeBufferResource(
			//         ComputeBufferResource *this,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D919374 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferDesc,UnityEngine::ComputeBuffer>::HGRenderGraphResource);
			//     byte_18D919374 = 1;
			//   }
			// }
			// 
		}

		public override string GetName()
		{
			// // String GetName()
			// String *HG::Rendering::RenderGraphModule::ComputeBufferResource::GetName(
			//         ComputeBufferResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91936D )
			//   {
			//     sub_18003C530(&off_18D4DFA30);
			//     byte_18D91936D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(284, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(284, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields._._.imported )
			//   {
			//     return (String *)"ImportedComputeBuffer";
			//   }
			//   else
			//   {
			//     return this.fields._.desc.name;
			//   }
			// }
			// 
			return null;
		}

		public override void CreatePooledGraphicsResource([MetadataOffset(Offset = "0x01F90A01")] bool frameRegister = true, [MetadataOffset(Offset = "0x01F90A02")] string name = "")
		{
			// // Void CreatePooledGraphicsResource(Boolean, String)
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::CreatePooledGraphicsResource(
			//         ComputeBufferResource *this,
			//         bool frameRegister,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   int32_t HashCode; // edi
			//   RenderGraphResourcePool_1_System_Object_ *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   RenderGraphResourcePool_1_System_Object_ *v11; // rsi
			//   Object *v12; // rbx
			//   String *v13; // rax
			//   String *v14; // rdi
			//   __int64 v15; // rax
			//   ProtocolViolationException *v16; // rax
			//   ProtocolViolationException *v17; // rbx
			//   __int64 v18; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91936E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::RegisterFrameAllocation);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::TryGetResource);
			//     byte_18D91936E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(285, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(285, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(
			//         (ILFixDynamicMethodWrapper_8 *)Patch,
			//         (Object *)this,
			//         frameRegister,
			//         (Object *)name,
			//         0LL);
			//       return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v10, v9);
			//   }
			//   HashCode = HG::Rendering::RenderGraphModule::ComputeBufferDesc::GetHashCode(&this.fields._.desc, 0LL);
			//   if ( this.fields._.graphicsResource )
			//   {
			//     v12 = (Object *)sub_18003F3E0(5LL, this);
			//     v13 = (String *)sub_18000F7E0(&off_18D4DFB18);
			//     v14 = System::String::Format(v13, v12, 0LL);
			//     v15 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//     v16 = (ProtocolViolationException *)sub_180004920(v15);
			//     v17 = v16;
			//     if ( v16 )
			//     {
			//       System::Net::ProtocolViolationException::ProtocolViolationException(v16, v14, 0LL);
			//       v18 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource::CreatePooledGraphicsResource);
			//       sub_18000F7C0(v17, v18);
			//     }
			//     goto LABEL_13;
			//   }
			//   v8 = (RenderGraphResourcePool_1_System_Object_ *)sub_18003F5A0(
			//                                                      this.fields._._.m_Pool,
			//                                                      TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
			//   v11 = v8;
			//   if ( !v8 )
			//     goto LABEL_13;
			//   if ( !UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::TryGetResource(
			//           v8,
			//           HashCode,
			//           (Object **)&this.fields._.graphicsResource,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::TryGetResource) )
			//     sub_18005E3A0(10LL, this, name);
			//   this.fields._._.cachedHash = HashCode;
			//   if ( frameRegister )
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::RegisterFrameAllocation(
			//       v11,
			//       HashCode,
			//       (Object *)this.fields._.graphicsResource,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::RegisterFrameAllocation);
			// }
			// 
		}

		public override void ReleasePooledGraphicsResource(int frameIndex, [MetadataOffset(Offset = "0x01F90A03")] bool reset = true)
		{
			// // Void ReleasePooledGraphicsResource(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleasePooledGraphicsResource(
			//         ComputeBufferResource *this,
			//         int32_t frameIndex,
			//         bool reset,
			//         MethodInfo *method)
			// {
			//   RenderGraphResourcePool_1_System_Object_ *v7; // rax
			//   __int64 v8; // rcx
			//   RenderGraphResourcePool_1_System_Object_ *v9; // rdi
			//   String *v10; // rdi
			//   String *v11; // rbx
			//   String *v12; // rax
			//   String *v13; // rdi
			//   __int64 v14; // rax
			//   ProtocolViolationException *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   ProtocolViolationException *v18; // rbx
			//   __int64 v19; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91936F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::ReleaseResource);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::UnregisterFrameAllocation);
			//     byte_18D91936F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(287, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(287, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//         (ILFixDynamicMethodWrapper_8 *)Patch,
			//         (Object *)this,
			//         (EnergyShardType__Enum)frameIndex,
			//         reset,
			//         0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v17, v16);
			//   }
			//   if ( !this.fields._.graphicsResource )
			//   {
			//     v10 = (String *)sub_18003F3E0(5LL, this);
			//     v11 = (String *)sub_18000F7E0(&off_18D4DFB90);
			//     v12 = (String *)sub_18000F7E0(&off_18D4DFB98);
			//     v13 = System::String::Concat(v12, v10, v11, 0LL);
			//     v14 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//     v15 = (ProtocolViolationException *)sub_180004920(v14);
			//     v18 = v15;
			//     if ( v15 )
			//     {
			//       System::Net::ProtocolViolationException::ProtocolViolationException(v15, v13, 0LL);
			//       v19 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleasePooledGraphicsResource);
			//       sub_18000F7C0(v18, v19);
			//     }
			//     goto LABEL_12;
			//   }
			//   v7 = (RenderGraphResourcePool_1_System_Object_ *)sub_18003F5A0(
			//                                                      this.fields._._.m_Pool,
			//                                                      TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
			//   v9 = v7;
			//   if ( v7 )
			//   {
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::ReleaseResource(
			//       v7,
			//       this.fields._._.cachedHash,
			//       (Object *)this.fields._.graphicsResource,
			//       frameIndex,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::ReleaseResource);
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::UnregisterFrameAllocation(
			//       v9,
			//       this.fields._._.cachedHash,
			//       (Object *)this.fields._.graphicsResource,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::UnregisterFrameAllocation);
			//   }
			//   if ( reset )
			//     sub_18000FAA0(v8, this, 0LL);
			// }
			// 
		}

		public override void CreateGraphicsResource([MetadataOffset(Offset = "0x01F90A04")] string name = "")
		{
			// // Void CreateGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::CreateGraphicsResource(
			//         ComputeBufferResource *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   int32_t count; // esi
			//   int32_t stride; // r14d
			//   unsigned int type; // r15d
			//   ComputeBuffer *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ComputeBuffer *v11; // rbx
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   ComputeBuffer *graphicsResource; // r14
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   __int64 v18; // rax
			//   Object__Array *v19; // rsi
			//   __int64 v20; // r8
			//   __int64 v21; // rbx
			//   __int64 v22; // r8
			//   __int64 v23; // rbx
			//   __int64 v24; // r8
			//   __int64 v25; // rbx
			//   String *v26; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v28; // [rsp+20h] [rbp-28h]
			//   String *v29; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v30; // [rsp+30h] [rbp-18h]
			//   int32_t v31; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919370 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBufferType);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18D4DF918);
			//     byte_18D919370 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(289, 0LL) )
			//   {
			//     count = this.fields._.desc.count;
			//     stride = this.fields._.desc.stride;
			//     type = this.fields._.desc.type;
			//     v8 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//     v11 = v8;
			//     if ( v8 )
			//     {
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v8, count, stride, (ComputeBufferType__Enum)type, 0LL);
			//       this.fields._.graphicsResource = v11;
			//       sub_1800054D0((OneofDescriptor *)&this.fields._.graphicsResource, v12, v13, v14, v28, v29, v30);
			//       graphicsResource = this.fields._.graphicsResource;
			//       v18 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 4LL, v16, v17);
			//       v19 = (Object__Array *)v18;
			//       if ( v18 )
			//       {
			//         sub_180036D40(v18, name);
			//         sub_1800046C0(v19, 0LL, name);
			//         v31 = this.fields._.desc.count;
			//         v21 = il2cpp_value_box_0(TypeInfo::System::Int32, &v31, v20);
			//         sub_180036D40(v19, v21);
			//         sub_1800046C0(v19, 1LL, v21);
			//         v31 = this.fields._.desc.stride;
			//         v23 = il2cpp_value_box_0(TypeInfo::System::Int32, &v31, v22);
			//         sub_180036D40(v19, v23);
			//         sub_1800046C0(v19, 2LL, v23);
			//         v31 = this.fields._.desc.type;
			//         v25 = il2cpp_value_box_0(TypeInfo::UnityEngine::ComputeBufferType, &v31, v24);
			//         sub_180036D40(v19, v25);
			//         sub_1800046C0(v19, 3LL, v25);
			//         v26 = System::String::Format((String *)"{0}-RenderGraphComputeBuffer_{1}_{2}_{3}", v19, 0LL);
			//         if ( graphicsResource )
			//         {
			//           UnityEngine::ComputeBuffer::SetName(graphicsResource, v26, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(289, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)name,
			//     0LL);
			// }
			// 
		}

		public override void ReleaseGraphicsResource()
		{
			// // Void ReleaseGraphicsResource()
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleaseGraphicsResource(
			//         ComputeBufferResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919371 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferDesc,UnityEngine::ComputeBuffer>::ReleaseGraphicsResource);
			//     byte_18D919371 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(290, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(290, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields._.graphicsResource )
			//       UnityEngine::ComputeBuffer::Dispose(this.fields._.graphicsResource, 0LL);
			//     this.fields._.graphicsResource = 0LL;
			//   }
			// }
			// 
		}

		public override void LogCreation(HGRenderGraphLogger logger)
		{
			// // Void LogCreation(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::LogCreation(
			//         ComputeBufferResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   String *v5; // rdi
			//   Object__Array *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919372 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&off_18D4DF910);
			//     byte_18D919372 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(291, 0LL) )
			//   {
			//     v5 = System::String::Concat((String *)"Created ComputeBuffer: ", this.fields._.desc.name, 0LL);
			//     v6 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//     if ( logger )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(291, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)logger,
			//     0LL);
			// }
			// 
		}

		public override void LogRelease(HGRenderGraphLogger logger)
		{
			// // Void LogRelease(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::LogRelease(
			//         ComputeBufferResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   String *v5; // rdi
			//   Object__Array *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919373 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&off_18D4DF968);
			//     byte_18D919373 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(292, 0LL) )
			//   {
			//     v5 = System::String::Concat((String *)"Released ComputeBuffer: ", this.fields._.desc.name, 0LL);
			//     v6 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//     if ( logger )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(292, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)logger,
			//     0LL);
			// }
			// 
		}

		public string <>iFixBaseProxy_GetName()
		{
			// // String <>iFixBaseProxy_GetName()
			// String *HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_GetName(
			//         TextureResource *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetName((IHGRenderGraphResource *)this, 0LL);
			// }
			// 
			return null;
		}

		public void <>iFixBaseProxy_CreatePooledGraphicsResource(bool P0, string P1)
		{
			// // Void <>iFixBaseProxy_CreatePooledGraphicsResource(Boolean, String)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreatePooledGraphicsResource(
			//         TextureResource *this,
			//         bool P0,
			//         String *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreatePooledGraphicsResource(
			//     (IHGRenderGraphResource *)this,
			//     P0,
			//     P1,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ReleasePooledGraphicsResource(int P0, bool P1)
		{
			// // Void <>iFixBaseProxy_ReleasePooledGraphicsResource(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_ReleasePooledGraphicsResource(
			//         TextureResource *this,
			//         int32_t P0,
			//         bool P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleasePooledGraphicsResource(
			//     (IHGRenderGraphResource *)this,
			//     P0,
			//     P1,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_CreateGraphicsResource(string P0)
		{
			// // Void <>iFixBaseProxy_CreateGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreateGraphicsResource(
			//         TextureResource *this,
			//         String *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreateGraphicsResource(
			//     (IHGRenderGraphResource *)this,
			//     P0,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ReleaseGraphicsResource()
		{
			// // Void <>iFixBaseProxy_ReleaseGraphicsResource()
			// void HG::Rendering::RenderGraphModule::ComputeBufferResource::__iFixBaseProxy_ReleaseGraphicsResource(
			//         ComputeBufferResource *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleaseGraphicsResource(this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_LogCreation(HGRenderGraphLogger P0)
		{
			// // Void <>iFixBaseProxy_LogCreation(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogCreation(
			//         TextureResource *this,
			//         HGRenderGraphLogger *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogCreation((IHGRenderGraphResource *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_LogRelease(HGRenderGraphLogger P0)
		{
			// // Void <>iFixBaseProxy_LogRelease(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogRelease(
			//         TextureResource *this,
			//         HGRenderGraphLogger *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogRelease((IHGRenderGraphResource *)this, P0, 0LL);
			// }
			// 
		}
	}
}
