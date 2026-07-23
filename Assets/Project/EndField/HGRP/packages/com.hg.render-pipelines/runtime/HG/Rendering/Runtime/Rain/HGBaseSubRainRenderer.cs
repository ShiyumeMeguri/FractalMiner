using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public abstract class HGBaseSubRainRenderer // TypeDefIndex: 38856
	{
		// Fields
		internal HGRainRenderer.RainDropsType rainDropsType; // 0x10
		internal bool enabled; // 0x14
		internal int rainRenderQueue; // 0x18
		protected static readonly HideFlags RAIN_RSC_HIDE_FLAGS; // 0x00
	
		// Constructors
		protected HGBaseSubRainRenderer() {} // 0x0000000184DA2100-0x0000000184DA2110
		// HGBaseSubRainRenderer()
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::HGBaseSubRainRenderer(
		        HGBaseSubRainRenderer *this,
		        MethodInfo *method)
		{
		  this->fields.enabled = 1;
		  this->fields.rainRenderQueue = 3000;
		}
		
		static HGBaseSubRainRenderer() {} // 0x0000000184D84C80-0x0000000184D84CA0
		// HGBaseSubRainRenderer()
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->static_fields->RAIN_RSC_HIDE_FLAGS = 63;
		}
		
	
		// Methods
		internal abstract void PrepareResources(RainCommonResources commonResources);
		internal abstract void UpdateData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime);
		internal virtual void PerFrameClear() {} // 0x0000000183DBBA40-0x0000000183DBBA90
		// Void PerFrameClear()
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::PerFrameClear(
		        HGBaseSubRainRenderer *this,
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
		  if ( wrapperArray->max_length.size <= 661 )
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
		  if ( LODWORD(v3->_0.namespaze) <= 0x295 )
		    sub_1800D2AB0(v3, method);
		  if ( *((_QWORD *)&v3[14]._0.this_arg + 1) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(661, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		}
		
		internal virtual void SetMaterialData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189CD9B24-0x0000000189CD9B8C
		// Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData(
		        HGBaseSubRainRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(809, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(809, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
		      Patch,
		      (Object *)this,
		      (SnowCommonRenderingParam **)rainCommonRenderingParam,
		      context,
		      0LL);
		  }
		}
		
		internal virtual void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CD9ABC-0x0000000189CD9B24
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Render(
		        HGBaseSubRainRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1582, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1582, 0LL);
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
		
		internal virtual bool IsDirty() => default; // 0x0000000183D758A0-0x0000000183D75900
		// Boolean IsDirty()
		bool HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::IsDirty(HGBaseSubRainRenderer *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 810 )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x32A )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[17]._0.klass )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(810, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal virtual void ClearData() {} // 0x0000000189CD9A34-0x0000000189CD9A78
		// Void ClearData()
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::ClearData(HGBaseSubRainRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(811, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(811, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		internal virtual void Dispose() {} // 0x0000000189CD9A78-0x0000000189CD9ABC
		// Void Dispose()
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose(HGBaseSubRainRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(520, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(520, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		protected void DisposeMaterial(Material mat) {} // 0x00000001848614F0-0x00000001848615A0
		// Void DisposeMaterial(Material)
		void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		        HGBaseSubRainRenderer *this,
		        Material *mat,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1595, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1595, 0LL);
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
