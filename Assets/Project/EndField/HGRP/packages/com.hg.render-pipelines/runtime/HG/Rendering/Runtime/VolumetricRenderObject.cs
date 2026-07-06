using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public abstract class VolumetricRenderObject : MonoBehaviour, IVolumetricRenderObject
	{
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000025D8 File Offset: 0x000007D8
		protected bool NeedCommandBuffer
		{
			get
			{
				// // Boolean get_NeedCommandBuffer()
				// bool HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(
				//         VolumetricRenderObject *this,
				//         MethodInfo *method)
				// {
				//   return sub_1800023D0(13LL, this);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x000025D8 File Offset: 0x000007D8
		protected virtual bool HasVolumetricRenderItem
		{
			get
			{
				// // Boolean get_alwaysRebindOnRefresh()
				// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
				//         VerticalVirtualizationController_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00002608 File Offset: 0x00000808
		protected int RenderObjectLayer
		{
			get
			{
				// // Int32 get_RenderObjectLayer()
				// int32_t HG::Rendering::Runtime::VolumetricRenderObject::get_RenderObjectLayer(
				//         VolumetricRenderObject *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D9197E7 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     byte_18D9197E7 = 1;
				//   }
				//   if ( HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(this, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields.Layer_Invisible;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields.Layer_Default;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00002608 File Offset: 0x00000808
		public int order
		{
			get
			{
				// // Int32 get_maxCapacity()
				// int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_maxCapacity(
				//         ObjectPool_1_System_Object__3 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_maxCapacity;
				// }
				// 
				return 0;
			}
		}

		protected VolumetricRenderObject()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		protected void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VolumetricRenderObject::OnEnable(VolumetricRenderObject *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   VolumetricManager *volumetricManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4373, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       volumetricManager_k__BackingField = currentManagerContext.fields._volumetricManager_k__BackingField;
			//       if ( volumetricManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::VolumetricManager::RegisterVolumetricRenderObject(
			//           volumetricManager_k__BackingField,
			//           (IVolumetricRenderObject *)this,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(volumetricManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4373, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::VolumetricRenderObject::OnDisable(VolumetricRenderObject *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   VolumetricManager *volumetricManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4402, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       volumetricManager_k__BackingField = currentManagerContext.fields._volumetricManager_k__BackingField;
			//       if ( volumetricManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::VolumetricManager::UnregisterVolumetricRenderObject(
			//           volumetricManager_k__BackingField,
			//           (IVolumetricRenderObject *)this,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(volumetricManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4402, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected virtual void PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs inputs)
		{
			// // Void PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRenderingImpl(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4551, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4551, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//   }
			// }
			// 
		}

		public void PrepareVolumetricRendering(ref VolumetricRenderInputs inputs)
		{
			// // Void PrepareVolumetricRendering(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRendering(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4552, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4552, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//   }
			//   else
			//   {
			//     sub_180003EE0(this.klass);
			//     ((void (__fastcall *)(VolumetricRenderObject *, VolumetricRenderInputs *, Il2CppMethodPointer))this.klass.vtable.PrepareVolumetricRenderingImpl.method)(
			//       this,
			//       inputs,
			//       this.klass.vtable.PreVolumetricRendering_1.methodPtr);
			//   }
			// }
			// 
		}

		public virtual void PreVolumetricRendering(ref VolumetricRenderInputs inputs)
		{
			// // Void PreVolumetricRendering(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderObject::PreVolumetricRendering(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4553, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4553, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//   }
			// }
			// 
		}

		public virtual void PostVolumetricRendering(ref VolumetricRenderInputs inputs)
		{
			// // Void PostVolumetricRendering(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderObject::PostVolumetricRendering(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4554, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4554, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//   }
			// }
			// 
		}

		public virtual bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item)
		{
			// // Boolean OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricRenderObject::OverrideFramingCompose(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderer_VolumetricComposeContext *context,
			//         VolumetricRenderer_VolumetricRenderItem *item,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   VolumetricRenderer_VolumetricComposeContext v12; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4555, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4555, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     volumetricSettings = context.volumetricSettings;
			//     *(_OWORD *)&v12.bEnableFraming = *(_OWORD *)&context.bEnableFraming;
			//     v12.volumetricSettings = volumetricSettings;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1278(Patch, (Object *)this, &v12, item, 0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(item, 0LL, 88LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public virtual bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item)
		{
			// // Boolean OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricRenderObject::OverrideTemporalCompose(
			//         VolumetricRenderObject *this,
			//         VolumetricRenderer_VolumetricComposeContext *context,
			//         VolumetricRenderer_VolumetricRenderItem *item,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   VolumetricRenderer_VolumetricComposeContext v12; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4556, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4556, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     volumetricSettings = context.volumetricSettings;
			//     *(_OWORD *)&v12.bEnableFraming = *(_OWORD *)&context.bEnableFraming;
			//     v12.volumetricSettings = volumetricSettings;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1278(Patch, (Object *)this, &v12, item, 0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(item, 0LL, 88LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		protected virtual void CollectVolumetricRenderItemsImpl(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items)
		{
			// // Void CollectVolumetricRenderItemsImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsImpl(
			//         VolumetricRenderObject *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4557, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4557, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)items,
			//       0LL);
			//   }
			// }
			// 
		}

		public void CollectVolumetricRenderItems(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items)
		{
			// // Void CollectVolumetricRenderItems(HGCamera, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItems(
			//         VolumetricRenderObject *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4558, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4558, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)items,
			//       0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(this, 0LL) )
			//   {
			//     sub_180003EE0(this.klass);
			//     ((void (__fastcall *)(VolumetricRenderObject *, HGCamera *, HGVolumetricCloudSettingParameters *, List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *, Il2CppMethodPointer))this.klass.vtable.CollectVolumetricRenderItemsImpl.method)(
			//       this,
			//       hgCamera,
			//       volumetricParameters,
			//       items,
			//       this.klass.vtable.CollectVolumetricRenderItemsCPPImpl.methodPtr);
			//   }
			// }
			// 
		}

		protected virtual void CollectVolumetricRenderItemsCPPImpl(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems)
		{
			// // Void CollectVolumetricRenderItemsCPPImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPPImpl(
			//         VolumetricRenderObject *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4559, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4559, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)renderItems,
			//       0LL);
			//   }
			// }
			// 
		}

		public void CollectVolumetricRenderItemsCPP(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems)
		{
			// // Void CollectVolumetricRenderItemsCPP(HGCamera, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPP(
			//         VolumetricRenderObject *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4560, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4560, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)renderItems,
			//       0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(this, 0LL) )
			//   {
			//     sub_180003EE0(this.klass);
			//     ((void (__fastcall *)(VolumetricRenderObject *, HGCamera *, HGVolumetricCloudSettingParameters *, List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *, Il2CppMethodPointer))this.klass.vtable.CollectVolumetricRenderItemsCPPImpl.method)(
			//       this,
			//       hgCamera,
			//       volumetricParameters,
			//       renderItems,
			//       this.klass.vtable.OnUpdateVolumetricMaterial_1.methodPtr);
			//   }
			// }
			// 
		}

		public virtual void OnUpdateVolumetricMaterial(CommandBuffer cmd, Material material, MaterialPropertyBlock propertyBlock)
		{
			// // Void OnUpdateVolumetricMaterial(CommandBuffer, Material, MaterialPropertyBlock)
			// void HG::Rendering::Runtime::VolumetricRenderObject::OnUpdateVolumetricMaterial(
			//         VolumetricRenderObject *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MaterialPropertyBlock *propertyBlock,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4561, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4561, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       (Object *)material,
			//       (Object *)propertyBlock,
			//       0LL);
			//   }
			// }
			// 
		}

		protected Action<VolumetricRenderer.VolumetricCallbackContext> _CollectVolumetricRenderCallback;

		protected Action<VolumetricRenderer.VolumetricCallbackContext> _TemporalComposeCallBack;

		protected Action<VolumetricRenderer.VolumetricCallbackContext> _FramingRendererCallback;

		protected int m_order;
	}
}
