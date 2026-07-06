using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : HGRenderGraphResource<TextureDesc, RTHandle>
	{
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool needsClear
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isEnabling()
				// bool UnityEngine::Timeline::RuntimeClip::get_isEnabling(RuntimeClip *this, MethodInfo *method)
				// {
				//   return this.fields.m_enabled;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_isActive(Boolean)
				// void Slate::Cutscene::set_isActive(Cutscene *this, bool value, MethodInfo *method)
				// {
				//   this.fields._isActive_k__BackingField = value;
				// }
				// 
			}
		}

		public TextureResource()
		{
			// // TextureResource()
			// void HG::Rendering::RenderGraphModule::TextureResource::TextureResource(TextureResource *this, MethodInfo *method)
			// {
			//   if ( !byte_18D9193BF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,UnityEngine::Rendering::RTHandle>::HGRenderGraphResource);
			//     byte_18D9193BF = 1;
			//   }
			// }
			// 
		}

		public override string GetName()
		{
			// // String GetName()
			// String *HG::Rendering::RenderGraphModule::TextureResource::GetName(TextureResource *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193B6 )
			//   {
			//     sub_18003C530(&off_18D4DEE80);
			//     byte_18D9193B6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(320, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(320, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			//   }
			//   else if ( !this.fields._._.imported || this.fields._._.preserved )
			//   {
			//     return this.fields._.desc.name;
			//   }
			//   else if ( this.fields._.graphicsResource )
			//   {
			//     return this.fields._.graphicsResource.fields.m_Name;
			//   }
			//   else
			//   {
			//     return (String *)"null resource";
			//   }
			// }
			// 
			return null;
		}

		public void CopyFrom(TextureResource other)
		{
			// // Void CopyFrom(TextureResource)
			// void HG::Rendering::RenderGraphModule::TextureResource::CopyFrom(
			//         TextureResource *this,
			//         TextureResource *other,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193B7 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,UnityEngine::Rendering::RTHandle>::CopyFrom);
			//     byte_18D9193B7 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(159, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,System::Object>::CopyFrom(
			//       (HGRenderGraphResource_2_TextureDesc_System_Object_ *)this,
			//       (HGRenderGraphResource_2_TextureDesc_System_Object_ *)other,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,UnityEngine::Rendering::RTHandle>::CopyFrom);
			//     if ( other )
			//     {
			//       this.fields._needsClear_k__BackingField = other.fields._needsClear_k__BackingField;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(159, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)other,
			//     0LL);
			// }
			// 
		}

		public override void CreatePooledGraphicsResource([MetadataOffset(Offset = "0x01F90A26")] bool frameRegister = true, [MetadataOffset(Offset = "0x01F90A27")] string name = "")
		{
			// // Void CreatePooledGraphicsResource(Boolean, String)
			// void HG::Rendering::RenderGraphModule::TextureResource::CreatePooledGraphicsResource(
			//         TextureResource *this,
			//         bool frameRegister,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   int32_t HashCode; // esi
			//   RenderGraphResourcePool_1_System_Object_ *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   RenderGraphResourcePool_1_System_Object_ *v11; // rdi
			//   bool Resource; // al
			//   Object *v13; // rbx
			//   String *v14; // rax
			//   String *v15; // rdi
			//   __int64 v16; // rax
			//   ProtocolViolationException *v17; // rax
			//   ProtocolViolationException *v18; // rbx
			//   __int64 v19; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193B8 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::RegisterFrameAllocation);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::TryGetResource);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
			//     byte_18D9193B8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(321, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(321, 0LL);
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
			// LABEL_11:
			//     sub_180B536AC(v10, v9);
			//   }
			//   HashCode = HG::Rendering::RenderGraphModule::TextureDesc::GetHashCode(&this.fields._.desc, 0LL);
			//   if ( this.fields._.graphicsResource )
			//   {
			//     v13 = (Object *)sub_18003F3E0(5LL, this);
			//     v14 = (String *)sub_18000F7E0(&off_18D4DFB18);
			//     v15 = System::String::Format(v14, v13, 0LL);
			//     v16 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//     v17 = (ProtocolViolationException *)sub_180004920(v16);
			//     v18 = v17;
			//     if ( v17 )
			//     {
			//       System::Net::ProtocolViolationException::ProtocolViolationException(v17, v15, 0LL);
			//       v19 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::TextureResource::CreatePooledGraphicsResource);
			//       sub_18000F7C0(v18, v19);
			//     }
			//     goto LABEL_11;
			//   }
			//   v8 = (RenderGraphResourcePool_1_System_Object_ *)sub_18003F5A0(
			//                                                      this.fields._._.m_Pool,
			//                                                      TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
			//   v11 = v8;
			//   if ( !v8 )
			//     goto LABEL_11;
			//   Resource = UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::TryGetResource(
			//                v8,
			//                HashCode,
			//                (Object **)&this.fields._.graphicsResource,
			//                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::TryGetResource);
			//   sub_18005E3A0((unsigned __int16)(Resource + 10), this, name);
			//   this.fields._._.cachedHash = HashCode;
			//   if ( frameRegister )
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::RegisterFrameAllocation(
			//       v11,
			//       HashCode,
			//       (Object *)this.fields._.graphicsResource,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::RegisterFrameAllocation);
			// }
			// 
		}

		public override void ReleasePooledGraphicsResource(int frameIndex, [MetadataOffset(Offset = "0x01F90A28")] bool reset = true)
		{
			// // Void ReleasePooledGraphicsResource(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::TextureResource::ReleasePooledGraphicsResource(
			//         TextureResource *this,
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
			//   if ( !byte_18D9193B9 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::ReleaseResource);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::UnregisterFrameAllocation);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
			//     byte_18D9193B9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(322, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(322, 0LL);
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
			//       v19 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::TextureResource::ReleasePooledGraphicsResource);
			//       sub_18000F7C0(v18, v19);
			//     }
			//     goto LABEL_12;
			//   }
			//   v7 = (RenderGraphResourcePool_1_System_Object_ *)sub_18003F5A0(
			//                                                      this.fields._._.m_Pool,
			//                                                      TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
			//   v9 = v7;
			//   if ( v7 )
			//   {
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::ReleaseResource(
			//       v7,
			//       this.fields._._.cachedHash,
			//       (Object *)this.fields._.graphicsResource,
			//       frameIndex,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::ReleaseResource);
			//     UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::UnregisterFrameAllocation(
			//       v9,
			//       this.fields._._.cachedHash,
			//       (Object *)this.fields._.graphicsResource,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::UnregisterFrameAllocation);
			//   }
			//   if ( reset )
			//     sub_18000FAA0(v8, this, 0LL);
			// }
			// 
		}

		public override void Preserve(int currentExecutorID, int currentExecutorFrameIndex, int frameCount)
		{
			// // Void Preserve(Int32, Int32, Int32)
			// void HG::Rendering::RenderGraphModule::TextureResource::Preserve(
			//         TextureResource *this,
			//         int32_t currentExecutorID,
			//         int32_t currentExecutorFrameIndex,
			//         int32_t frameCount,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !byte_18D9193BA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
			//     byte_18D9193BA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(323, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(323, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141(
			//       (ILFixDynamicMethodWrapper_8 *)Patch,
			//       (Object *)this,
			//       currentExecutorID,
			//       currentExecutorFrameIndex,
			//       frameCount,
			//       0LL);
			//   }
			//   else if ( sub_18003F5A0(this.fields._._.m_Pool, TypeInfo::HG::Rendering::RenderGraphModule::TexturePool) )
			//   {
			//     this.fields._._.preserved = 1;
			//     this.fields._._.preservedExecutorID = currentExecutorID;
			//     this.fields._._.preservedExecutorFrameIndex = currentExecutorFrameIndex;
			//     this.fields._._.preservedResourceLifeSpan = frameCount;
			//   }
			// }
			// 
		}

		public override void CreateGraphicsResource([MetadataOffset(Offset = "0x01F90A29")] string name = "")
		{
			// // Void CreateGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::TextureResource::CreateGraphicsResource(
			//         TextureResource *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   bool enableRandomWrite; // r13
			//   bool useMipMap; // r12
			//   bool autoGenerateMips; // r15
			//   bool isShadowMap; // r14
			//   int32_t anisoLevel; // ebp
			//   float mipMapBias; // xmm6_4
			//   unsigned int msaaSamples; // esi
			//   bool bindTextureMS; // di
			//   int32_t v13; // eax
			//   unsigned int memoryless; // ebx
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   String__Array *colorFormat; // [rsp+20h] [rbp-E8h]
			//   String *filterMode; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *wrapMode; // [rsp+30h] [rbp-D8h]
			//   TextureWrapMode__Enum v24; // [rsp+A0h] [rbp-68h]
			//   FilterMode__Enum v25; // [rsp+A4h] [rbp-64h]
			//   GraphicsFormat__Enum v26; // [rsp+A8h] [rbp-60h]
			//   DepthBits__Enum depthBufferBits; // [rsp+ACh] [rbp-5Ch]
			//   int32_t slices; // [rsp+B0h] [rbp-58h]
			//   int32_t height; // [rsp+B4h] [rbp-54h]
			//   int32_t width; // [rsp+B8h] [rbp-50h]
			//   TextureDimension__Enum dimension; // [rsp+128h] [rbp+20h]
			// 
			//   if ( !byte_18D9193BB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     byte_18D9193BB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(324, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(324, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)name,
			//       0LL);
			//   }
			//   else
			//   {
			//     enableRandomWrite = this.fields._.desc.enableRandomWrite;
			//     useMipMap = this.fields._.desc.useMipMap;
			//     autoGenerateMips = this.fields._.desc.autoGenerateMips;
			//     isShadowMap = this.fields._.desc.isShadowMap;
			//     anisoLevel = this.fields._.desc.anisoLevel;
			//     mipMapBias = this.fields._.desc.mipMapBias;
			//     msaaSamples = this.fields._.desc.msaaSamples;
			//     bindTextureMS = this.fields._.desc.bindTextureMS;
			//     width = this.fields._.desc.width;
			//     height = this.fields._.desc.height;
			//     slices = this.fields._.desc.slices;
			//     depthBufferBits = this.fields._.desc.depthBufferBits;
			//     v26 = this.fields._.desc.colorFormat;
			//     v25 = this.fields._.desc.filterMode;
			//     v24 = this.fields._.desc.wrapMode;
			//     v13 = this.fields._.desc.dimension;
			//     memoryless = this.fields._.desc.memoryless;
			//     dimension = v13;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     this.fields._.graphicsResource = UnityEngine::Rendering::RTHandles::Alloc(
			//                                         width,
			//                                         height,
			//                                         slices,
			//                                         depthBufferBits,
			//                                         v26,
			//                                         v25,
			//                                         v24,
			//                                         dimension,
			//                                         enableRandomWrite,
			//                                         useMipMap,
			//                                         autoGenerateMips,
			//                                         isShadowMap,
			//                                         anisoLevel,
			//                                         mipMapBias,
			//                                         (MSAASamples__Enum)msaaSamples,
			//                                         bindTextureMS,
			//                                         (RenderTextureMemoryless__Enum)memoryless,
			//                                         name,
			//                                         0LL);
			//     sub_1800054D0((OneofDescriptor *)&this.fields._.graphicsResource, v15, v16, v17, colorFormat, filterMode, wrapMode);
			//   }
			// }
			// 
		}

		public override void RenameGraphicsResource([MetadataOffset(Offset = "0x01F90A2A")] string name = "")
		{
			// // Void RenameGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::TextureResource::RenameGraphicsResource(
			//         TextureResource *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(325, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(325, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)name,
			//       0LL);
			//   }
			// }
			// 
		}

		public override void ReleaseGraphicsResource()
		{
			// // Void ReleaseGraphicsResource()
			// void HG::Rendering::RenderGraphModule::TextureResource::ReleaseGraphicsResource(
			//         TextureResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D9193BC )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,UnityEngine::Rendering::RTHandle>::ReleaseGraphicsResource);
			//     byte_18D9193BC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(326, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(326, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields._.graphicsResource )
			//       UnityEngine::Rendering::RTHandle::Release(this.fields._.graphicsResource, 0LL);
			//     this.fields._.graphicsResource = 0LL;
			//   }
			// }
			// 
		}

		public override void LogCreation(HGRenderGraphLogger logger)
		{
			// // Void LogCreation(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::TextureResource::LogCreation(
			//         TextureResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   Object *name; // rbx
			//   Object *v7; // rax
			//   String *v8; // rbx
			//   Object__Array *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   bool clearBuffer; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9193BD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&TypeInfo::System::Boolean);
			//     sub_18003C530(&off_18D4DEFA0);
			//     byte_18D9193BD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(327, 0LL) )
			//   {
			//     name = (Object *)this.fields._.desc.name;
			//     clearBuffer = this.fields._.desc.clearBuffer;
			//     v7 = (Object *)il2cpp_value_box_0(TypeInfo::System::Boolean, &clearBuffer, v5);
			//     v8 = System::String::Format((String *)"Created Texture: {0} (Cleared: {1})", name, v7, 0LL);
			//     v9 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//     if ( logger )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v8, v9, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(327, 0LL);
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
			// void HG::Rendering::RenderGraphModule::TextureResource::LogRelease(
			//         TextureResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   String *v5; // rdi
			//   Object__Array *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193BE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&off_18D4DF270);
			//     byte_18D9193BE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(328, 0LL) )
			//   {
			//     v5 = System::String::Concat((String *)"Released Texture: ", this.fields._.desc.name, 0LL);
			//     v6 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//     if ( logger )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(328, 0LL);
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

		public void <>iFixBaseProxy_Preserve(int P0, int P1, int P2)
		{
			// // Void <>iFixBaseProxy_Preserve(Int32, Int32, Int32)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_Preserve(
			//         TextureResource *this,
			//         int32_t P0,
			//         int32_t P1,
			//         int32_t P2,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::Preserve((IHGRenderGraphResource *)this, P0, P1, P2, 0LL);
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

		public void <>iFixBaseProxy_RenameGraphicsResource(string P0)
		{
			// // Void <>iFixBaseProxy_RenameGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_RenameGraphicsResource(
			//         TextureResource *this,
			//         String *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::IHGRenderGraphResource::RenameGraphicsResource(
			//     (IHGRenderGraphResource *)this,
			//     P0,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ReleaseGraphicsResource()
		{
			// // Void <>iFixBaseProxy_ReleaseGraphicsResource()
			// void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_ReleaseGraphicsResource(
			//         TextureResource *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::TextureResource::ReleaseGraphicsResource(this, 0LL);
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

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int m_TextureCreationIndex;
	}
}
