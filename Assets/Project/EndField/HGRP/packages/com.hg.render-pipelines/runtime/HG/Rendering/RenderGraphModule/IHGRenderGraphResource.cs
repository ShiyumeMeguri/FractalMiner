using System;

namespace HG.Rendering.RenderGraphModule
{
	internal class IHGRenderGraphResource
	{
		public IHGRenderGraphResource()
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

		public virtual void Reset(IHGRenderGraphResourcePool pool)
		{
		}

		public virtual string GetName()
		{
			// // String GetName()
			// String *HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetName(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193AD )
			//   {
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D9193AD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(96, 0LL) )
			//     return (String *)"";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(96, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public virtual bool IsCreated()
		{
			// // Boolean IsCreated()
			// bool HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IsCreated(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(211, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(211, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public virtual void IncrementWriteCount()
		{
			// // Void IncrementWriteCount()
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IncrementWriteCount(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(223, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(223, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     ++this.fields.writeCount;
			//   }
			// }
			// 
		}

		public virtual bool NeedsFallBack()
		{
			// // Boolean NeedsFallBack()
			// bool HG::Rendering::RenderGraphModule::IHGRenderGraphResource::NeedsFallBack(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(239, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(239, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.requestFallBack )
			//   {
			//     return this.fields.writeCount == 0;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public void CopyFrom(IHGRenderGraphResource other)
		{
		}

		public virtual void CreatePooledGraphicsResource([MetadataOffset(Offset = "0x01F90A1D")] bool frameRegister = true, [MetadataOffset(Offset = "0x01F90A1E")] string name = "")
		{
			// // Void CreatePooledGraphicsResource(Boolean, String)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreatePooledGraphicsResource(
			//         IHGRenderGraphResource *this,
			//         bool frameRegister,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(82, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(82, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(
			//       (ILFixDynamicMethodWrapper_8 *)Patch,
			//       (Object *)this,
			//       frameRegister,
			//       (Object *)name,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void CreateGraphicsResource([MetadataOffset(Offset = "0x01F90A1F")] string name = "")
		{
			// // Void CreateGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreateGraphicsResource(
			//         IHGRenderGraphResource *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(286, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(286, 0LL);
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

		public virtual void RenameGraphicsResource([MetadataOffset(Offset = "0x01F90A20")] string name = "")
		{
			// // Void RenameGraphicsResource(String)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::RenameGraphicsResource(
			//         IHGRenderGraphResource *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(310, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(310, 0LL);
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

		public virtual void ReleasePooledGraphicsResource(int frameIndex, [MetadataOffset(Offset = "0x01F90A21")] bool reset = true)
		{
			// // Void ReleasePooledGraphicsResource(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleasePooledGraphicsResource(
			//         IHGRenderGraphResource *this,
			//         int32_t frameIndex,
			//         bool reset,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(89, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(89, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(
			//       (ILFixDynamicMethodWrapper_8 *)Patch,
			//       (Object *)this,
			//       (EnergyShardType__Enum)frameIndex,
			//       reset,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void ReleaseGraphicsResource()
		{
			// // Void ReleaseGraphicsResource()
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleaseGraphicsResource(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(311, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(311, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public virtual void Preserve(int currentExecutorID, int currentExecutorFrameIndex, int frameCount)
		{
			// // Void Preserve(Int32, Int32, Int32)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::Preserve(
			//         IHGRenderGraphResource *this,
			//         int32_t currentExecutorID,
			//         int32_t currentExecutorFrameIndex,
			//         int32_t frameCount,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(157, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(157, 0LL);
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
			// }
			// 
		}

		public virtual void LogCreation(HGRenderGraphLogger logger)
		{
			// // Void LogCreation(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogCreation(
			//         IHGRenderGraphResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(83, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(83, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)logger,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void LogRelease(HGRenderGraphLogger logger)
		{
			// // Void LogRelease(HGRenderGraphLogger)
			// void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogRelease(
			//         IHGRenderGraphResource *this,
			//         HGRenderGraphLogger *logger,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(88, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(88, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)logger,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual int GetSortIndex()
		{
			// // Int32 GetSortIndex()
			// int32_t HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetSortIndex(
			//         IHGRenderGraphResource *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(312, 0LL) )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(312, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public bool imported;

		public bool preserved;

		public bool requestFallBack;

		public uint writeCount;

		public int cachedHash;

		public int transientPassIndex;

		public int preservedExecutorID;

		public int preservedExecutorFrameIndex;

		public int preservedResourceLifeSpan;

		protected IHGRenderGraphResourcePool m_Pool;
	}
}
