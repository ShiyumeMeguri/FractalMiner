using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public abstract class VolumetricRenderObject : MonoBehaviour, IVolumetricRenderObject // TypeDefIndex: 38752
	{
		// Fields
		protected Action<VolumetricRenderer.VolumetricCallbackContext> _CollectVolumetricRenderCallback; // 0x18
		protected Action<VolumetricRenderer.VolumetricCallbackContext> _TemporalComposeCallBack; // 0x20
		protected Action<VolumetricRenderer.VolumetricCallbackContext> _FramingRendererCallback; // 0x28
		protected int m_order; // 0x30
	
		// Properties
		protected bool NeedCommandBuffer { get; } // 0x0000000183399480-0x00000001833995A0 
		// Boolean get_NeedCommandBuffer()
		bool HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(
		        VolumetricRenderObject *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  const MethodInfo *v5; // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  _BYTE *m_CachedPtr; // rax
		  char v9; // al
		  _DWORD *v10; // rcx
		  __int64 v11; // rax
		  _DWORD *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( wrapperArray->max_length.size <= 5042 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_23;
		  if ( LODWORD(v3->_0.namespaze) <= 0x13B2 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[107]._0.events )
		  {
		LABEL_5:
		    sub_1800049A0(this->klass);
		    v5 = this->klass->vtable.get_HasVolumetricRenderItem.method;
		    methodPtr = this->klass->vtable.PrepareVolumetricRenderingImpl.methodPtr;
		    if ( v5 == (const MethodInfo *)System::RuntimeType::HasElementTypeImpl )
		    {
		      m_CachedPtr = this->fields._._._._.m_CachedPtr;
		      if ( (*((_DWORD *)m_CachedPtr + 2) & 0x20000000) == 0 )
		      {
		        v9 = m_CachedPtr[10];
		        if ( v9 != 29 && v9 != 16 && v9 != 20 && v9 != 15 )
		          return 0;
		      }
		    }
		    else
		    {
		      if ( v5 != (const MethodInfo *)System::RuntimeType::get_IsGenericType )
		      {
		        if ( v5 != (const MethodInfo *)System::RuntimeType::get_IsGenericParameter )
		          return ((__int64 (__fastcall *)(VolumetricRenderObject *, Il2CppMethodPointer))v5)(this, methodPtr);
		        v12 = this->fields._._._._.m_CachedPtr;
		        return (v12[2] & 0x20000000) == 0 && (*((_BYTE *)v12 + 10) == 19 || *((_BYTE *)v12 + 10) == 30);
		      }
		      v10 = this->fields._._._._.m_CachedPtr;
		      if ( (v10[2] & 0x20000000) != 0 )
		        return 0;
		      LOBYTE(methodPtr) = 1;
		      v11 = sub_180028750(v10, methodPtr);
		      if ( (*(_BYTE *)(v11 + 312) & 0x10) == 0 && !*(_QWORD *)(v11 + 96) )
		        return 0;
		    }
		    return 1;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5042, 0LL);
		  if ( !Patch )
		LABEL_23:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected virtual bool HasVolumetricRenderItem { get; } // 0x0000000189C55A24-0x0000000189C55A70 
		// Boolean get_HasVolumetricRenderItem()
		bool HG::Rendering::Runtime::VolumetricRenderObject::get_HasVolumetricRenderItem(
		        VolumetricRenderObject *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5043, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5043, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected int RenderObjectLayer { get; } // 0x0000000183C52740-0x0000000183C527A0 
		// Int32 get_RenderObjectLayer()
		int32_t HG::Rendering::Runtime::VolumetricRenderObject::get_RenderObjectLayer(
		        VolumetricRenderObject *this,
		        MethodInfo *method)
		{
		  bool v3; // zf
		  struct VolumetricSDFUtils__Class *v4; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5041, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5041, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = !HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(this, 0LL);
		    v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		    if ( v3 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		      }
		      return v4->static_fields->Layer_Default;
		    }
		    else
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		      }
		      return v4->static_fields->Layer_Invisible;
		    }
		  }
		}
		
		public int order { get; } // 0x0000000183AB68D0-0x0000000183AB6930 
		// Int32 get_order()
		int32_t HG::Rendering::Runtime::VolumetricRenderObject::get_order(VolumetricRenderObject *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 5234 )
		    return this->fields.m_order;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1472 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[111]._0.implementedInterfaces )
		    return this->fields.m_order;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5234, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		protected VolumetricRenderObject() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		protected void OnEnable() {} // 0x000000018454BE00-0x000000018454BE60
		// Void OnEnable()
		void HG::Rendering::Runtime::VolumetricRenderObject::OnEnable(VolumetricRenderObject *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  VolumetricManager *volumetricManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5023, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5023, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      volumetricManager_k__BackingField = currentManagerContext->fields._volumetricManager_k__BackingField;
		      if ( volumetricManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::VolumetricManager::RegisterVolumetricRenderObject(
		          volumetricManager_k__BackingField,
		          (IVolumetricRenderObject *)this,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(volumetricManager_k__BackingField, v4);
		  }
		}
		
		protected void OnDisable() {} // 0x0000000189C55698-0x0000000189C55710
		// Void OnDisable()
		void HG::Rendering::Runtime::VolumetricRenderObject::OnDisable(VolumetricRenderObject *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  VolumetricManager *volumetricManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5056, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      return;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      volumetricManager_k__BackingField = currentManagerContext->fields._volumetricManager_k__BackingField;
		      if ( volumetricManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::VolumetricManager::UnregisterVolumetricRenderObject(
		          volumetricManager_k__BackingField,
		          (IVolumetricRenderObject *)this,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(volumetricManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5056, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected virtual void PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5595C-0x0000000189C559B0
		// Void PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRenderingImpl(
		        VolumetricRenderObject *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5223, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5223, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		  }
		}
		
		public void PrepareVolumetricRendering(ref VolumetricRenderInputs inputs) {} // 0x0000000189C559B0-0x0000000189C55A24
		// Void PrepareVolumetricRendering(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRendering(
		        VolumetricRenderObject *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5224, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5224, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		  }
		  else
		  {
		    sub_1800049A0(this->klass);
		    ((void (__fastcall *)(VolumetricRenderObject *, VolumetricRenderInputs *, Il2CppMethodPointer))this->klass->vtable.PrepareVolumetricRenderingImpl.method)(
		      this,
		      inputs,
		      this->klass->vtable.PreVolumetricRendering_1.methodPtr);
		  }
		}
		
		public virtual void PreVolumetricRendering(ref VolumetricRenderInputs inputs) {} // 0x0000000189C55908-0x0000000189C5595C
		// Void PreVolumetricRendering(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderObject::PreVolumetricRendering(
		        VolumetricRenderObject *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5225, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5225, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		  }
		}
		
		public virtual void PostVolumetricRendering(ref VolumetricRenderInputs inputs) {} // 0x0000000189C558B4-0x0000000189C55908
		// Void PostVolumetricRendering(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderObject::PostVolumetricRendering(
		        VolumetricRenderObject *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5226, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5226, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		  }
		}
		
		public virtual bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item) {
			item = default;
			return default;
		} // 0x0000000189C55794-0x0000000189C55824
		// Boolean OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricRenderObject::OverrideFramingCompose(
		        VolumetricRenderObject *this,
		        VolumetricRenderer_VolumetricComposeContext *context,
		        VolumetricRenderer_VolumetricRenderItem *item,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  VolumetricRenderer_VolumetricComposeContext v12; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5227, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5227, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    volumetricSettings = context->volumetricSettings;
		    *(_OWORD *)&v12.bEnableFraming = *(_OWORD *)&context->bEnableFraming;
		    v12.volumetricSettings = volumetricSettings;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1489(Patch, (Object *)this, &v12, item, 0LL);
		  }
		  else
		  {
		    sub_18033B9D0(item, 0LL, 88LL);
		    return 0;
		  }
		}
		
		public virtual bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext context, out VolumetricRenderer.VolumetricRenderItem item) {
			item = default;
			return default;
		} // 0x0000000189C55824-0x0000000189C558B4
		// Boolean OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricRenderObject::OverrideTemporalCompose(
		        VolumetricRenderObject *this,
		        VolumetricRenderer_VolumetricComposeContext *context,
		        VolumetricRenderer_VolumetricRenderItem *item,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  VolumetricRenderer_VolumetricComposeContext v12; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5228, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5228, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    volumetricSettings = context->volumetricSettings;
		    *(_OWORD *)&v12.bEnableFraming = *(_OWORD *)&context->bEnableFraming;
		    v12.volumetricSettings = volumetricSettings;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1489(Patch, (Object *)this, &v12, item, 0LL);
		  }
		  else
		  {
		    sub_18033B9D0(item, 0LL, 88LL);
		    return 0;
		  }
		}
		
		protected virtual void CollectVolumetricRenderItemsImpl(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items) {} // 0x0000000189C55550-0x0000000189C555D4
		// Void CollectVolumetricRenderItemsImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsImpl(
		        VolumetricRenderObject *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5229, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5229, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      renderContext,
		      (Object *)volumetricParameters,
		      (Object *)items,
		      0LL);
		  }
		}
		
		public void CollectVolumetricRenderItems(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items) {} // 0x0000000189C555D4-0x0000000189C55698
		// Void CollectVolumetricRenderItems(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItems(
		        VolumetricRenderObject *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5230, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      renderContext,
		      (Object *)volumetricParameters,
		      (Object *)items,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::VolumetricRenderObject::get_NeedCommandBuffer(this, 0LL) )
		  {
		    sub_1800049A0(this->klass);
		    ((void (__fastcall *)(VolumetricRenderObject *, HGCamera *, void *, HGVolumetricCloudSettingParameters *, List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *, Il2CppMethodPointer))this->klass->vtable.CollectVolumetricRenderItemsImpl.method)(
		      this,
		      hgCamera,
		      renderContext.m_Ptr,
		      volumetricParameters,
		      items,
		      this->klass->vtable.CollectVolumetricRenderItemsCPPImpl.methodPtr);
		  }
		}
		
		protected virtual void CollectVolumetricRenderItemsCPPImpl(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems) {} // 0x0000000189C554CC-0x0000000189C55550
		// Void CollectVolumetricRenderItemsCPPImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPPImpl(
		        VolumetricRenderObject *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5231, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5231, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      renderContext,
		      (Object *)volumetricParameters,
		      (Object *)renderItems,
		      0LL);
		  }
		}
		
		public void CollectVolumetricRenderItemsCPP(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems) {} // 0x00000001833992C0-0x0000000183399480
		// Void CollectVolumetricRenderItemsCPP(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPP(
		        VolumetricRenderObject *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rax
		  Object *v9; // rbp
		  int *wrapperArray; // rcx
		  bool (*v12)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  char v14; // al
		  _DWORD *m_CachedPtr; // rax
		  char v16; // al
		  _DWORD *v17; // rcx
		  __int64 v18; // rax
		  _DWORD *v19; // rax
		  HGCamera__Class *klass; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCamera *v22; // rax
		  ILFixDynamicMethodWrapper_2 *v23; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = (Object *)hgCamera;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_30;
		  if ( wrapperArray[6] > 5232 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    hgCamera = (HGCamera *)v6->static_fields;
		    klass = hgCamera->klass;
		    if ( !hgCamera->klass )
		      goto LABEL_30;
		    if ( LODWORD(klass->_0.namespaze) <= 0x1470 )
		      goto LABEL_46;
		    if ( klass[111]._0.methods )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5232, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		          Patch,
		          (Object *)this,
		          v9,
		          renderContext,
		          (Object *)volumetricParameters,
		          (Object *)renderItems,
		          0LL);
		        return;
		      }
		      goto LABEL_30;
		    }
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v6->static_fields;
		  hgCamera = *(HGCamera **)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_30;
		  if ( hgCamera->fields._taauRTSize_k__BackingField.m_X > 5042 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (int *)v6->static_fields;
		    v22 = *(HGCamera **)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_30;
		    if ( v22->fields._taauRTSize_k__BackingField.m_X > 0x13B2u )
		    {
		      if ( !*(_QWORD *)&v22[14].fields.mainViewConstants.prevInvViewProjMatrix.m21 )
		        goto LABEL_9;
		      v23 = IFix::WrappersManagerImpl::GetPatch(5042, 0LL);
		      if ( v23 )
		      {
		        v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v23, (Object *)this, 0LL);
		        goto LABEL_13;
		      }
		LABEL_30:
		      sub_1800D8260(wrapperArray, hgCamera);
		    }
		LABEL_46:
		    sub_1800D2AB0(wrapperArray, hgCamera);
		  }
		LABEL_9:
		  sub_1800049A0(this->klass);
		  v12 = (bool (*)(RuntimeType *, MethodInfo *))this->klass->vtable.get_HasVolumetricRenderItem.method;
		  methodPtr = this->klass->vtable.PrepareVolumetricRenderingImpl.methodPtr;
		  if ( v12 == System::RuntimeType::HasElementTypeImpl )
		  {
		    m_CachedPtr = this->fields._._._._.m_CachedPtr;
		    if ( (m_CachedPtr[2] & 0x20000000) != 0
		      || (v16 = *((_BYTE *)m_CachedPtr + 10), v16 == 29)
		      || v16 == 16
		      || v16 == 20
		      || v16 == 15 )
		    {
		LABEL_29:
		      v14 = 1;
		      goto LABEL_13;
		    }
		LABEL_21:
		    v14 = 0;
		    goto LABEL_13;
		  }
		  if ( v12 != System::RuntimeType::get_IsGenericType )
		  {
		    if ( v12 != System::RuntimeType::get_IsGenericParameter )
		    {
		      v14 = ((__int64 (__fastcall *)(VolumetricRenderObject *, Il2CppMethodPointer))v12)(this, methodPtr);
		      goto LABEL_13;
		    }
		    v19 = this->fields._._._._.m_CachedPtr;
		    if ( (v19[2] & 0x20000000) == 0 && (*((_BYTE *)v19 + 10) == 19 || *((_BYTE *)v19 + 10) == 30) )
		      goto LABEL_29;
		    goto LABEL_21;
		  }
		  v17 = this->fields._._._._.m_CachedPtr;
		  if ( (v17[2] & 0x20000000) == 0 )
		  {
		    LOBYTE(methodPtr) = 1;
		    v18 = sub_180028750(v17, methodPtr);
		    if ( (*(_BYTE *)(v18 + 312) & 0x10) == 0 && !*(_QWORD *)(v18 + 96) )
		    {
		      v14 = 0;
		      goto LABEL_13;
		    }
		    goto LABEL_29;
		  }
		  v14 = 0;
		LABEL_13:
		  if ( v14 )
		  {
		    sub_1800049A0(this->klass);
		    ((void (__fastcall *)(VolumetricRenderObject *, Object *, void *, HGVolumetricCloudSettingParameters *, List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *, Il2CppMethodPointer))this->klass->vtable.CollectVolumetricRenderItemsCPPImpl.method)(
		      this,
		      v9,
		      renderContext.m_Ptr,
		      volumetricParameters,
		      renderItems,
		      this->klass->vtable.OnUpdateVolumetricMaterial_1.methodPtr);
		  }
		}
		
		public virtual void OnUpdateVolumetricMaterial(CommandBuffer cmd, ScriptableRenderContext renderContext, Material material, MaterialPropertyBlock propertyBlock) {} // 0x0000000189C55710-0x0000000189C55794
		// Void OnUpdateVolumetricMaterial(CommandBuffer, ScriptableRenderContext, Material, MaterialPropertyBlock)
		void HG::Rendering::Runtime::VolumetricRenderObject::OnUpdateVolumetricMaterial(
		        VolumetricRenderObject *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        Material *material,
		        MaterialPropertyBlock *propertyBlock,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5233, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5233, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      Patch,
		      (Object *)this,
		      (Object *)cmd,
		      renderContext,
		      (Object *)material,
		      (Object *)propertyBlock,
		      0LL);
		  }
		}
		
	}
}
