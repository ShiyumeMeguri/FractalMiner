using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Snow
{
	public abstract class HGBaseSubSnowRenderer // TypeDefIndex: 38835
	{
		// Fields
		internal bool enabled; // 0x10
		internal int snowRenderQueue; // 0x14
		protected static readonly HideFlags RSC_HIDE_FLAGS; // 0x00
	
		// Constructors
		protected HGBaseSubSnowRenderer() {} // 0x0000000184DA1FC0-0x0000000184DA1FD0
		// HGBaseSubSnowRenderer()
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::HGBaseSubSnowRenderer(
		        HGBaseSubSnowRenderer *this,
		        MethodInfo *method)
		{
		  this->fields.enabled = 1;
		  this->fields.snowRenderQueue = 3000;
		}
		
		static HGBaseSubSnowRenderer() {} // 0x0000000184D84C60-0x0000000184D84C80
		// HGBaseSubSnowRenderer()
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer->static_fields->RSC_HIDE_FLAGS = 63;
		}
		
	
		// Methods
		internal abstract void PrepareResources(SnowCommonResources commonResources);
		internal abstract void UpdateData([IsReadOnly] in SnowCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime);
		internal virtual void PerFrameClear() {} // 0x00000001832DAE10-0x00000001832DAE60
		// Void PerFrameClear()
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::PerFrameClear(
		        HGBaseSubSnowRenderer *this,
		        MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 669 )
		    return;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  if ( LODWORD(v3->_0.namespaze) <= 0x29D )
		    sub_1800D2AB0(v3, method);
		  if ( v3[14]._0.klass )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(669, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		}
		
		internal virtual void SetMaterialData([IsReadOnly] in SnowCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189C77FD4-0x0000000189C7803C
		// Void SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::SetMaterialData(
		        HGBaseSubSnowRenderer *this,
		        SnowCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(824, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(824, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
		  }
		}
		
		internal virtual void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189C77F6C-0x0000000189C77FD4
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Render(
		        HGBaseSubSnowRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1671, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1671, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		}
		
		internal virtual bool IsDirty() => default; // 0x00000001832DD110-0x00000001832DD170
		// Boolean IsDirty()
		bool HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::IsDirty(HGBaseSubSnowRenderer *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 825 )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x339 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[17]._1.genericContainerHandle )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(825, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal virtual void ClearData() {} // 0x0000000189C77EE4-0x0000000189C77F28
		// Void ClearData()
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::ClearData(HGBaseSubSnowRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(826, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		internal virtual void Dispose() {} // 0x0000000189C77F28-0x0000000189C77F6C
		// Void Dispose()
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Dispose(HGBaseSubSnowRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(524, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(524, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		protected void DisposeMaterial(Material mat) {} // 0x0000000184CE4DC0-0x0000000184CE4E60
		// Void DisposeMaterial(Material)
		void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeMaterial(
		        HGBaseSubSnowRenderer *this,
		        Material *mat,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5473, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5473, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)mat,
		      0LL);
		  }
		  else
		  {
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( mat )
		    {
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v5);
		        v5 = TypeInfo::UnityEngine::Object;
		      }
		      if ( mat->fields._.m_CachedPtr )
		      {
		        if ( !v5->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v5);
		        UnityEngine::Object::Destroy((Object_1 *)mat, 0LL);
		      }
		    }
		  }
		}
		
	}
}
