using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class UIImageBlurManager // TypeDefIndex: 38706
	{
		// Fields
		private static readonly Lazy<UIImageBlurManager> s_Instance; // 0x00
		public static readonly UIImageBlurManager instance; // 0x08
		private bool m_shouldRenderUIBlurFlag; // 0x10
		private Texture m_source; // 0x18
		private RenderTexture m_target; // 0x20
		private float m_scale; // 0x28
		private int m_uiImageBlurTexID; // 0x2C
		private Rect m_rect; // 0x30
	
		// Constructors
		public UIImageBlurManager() {} // 0x0000000184D50EB0-0x0000000184D50EF0
		// UIImageBlurManager()
		void HG::Rendering::Runtime::UIImageBlurManager::UIImageBlurManager(UIImageBlurManager *this, MethodInfo *method)
		{
		  struct HGShaderIDs__Class *v2; // rax
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  }
		  this->fields.m_uiImageBlurTexID = v2->static_fields->_UIImageBlurTex;
		}
		
		static UIImageBlurManager() {} // 0x0000000184CA91B0-0x0000000184CA92C0
		// UIImageBlurManager()
		void HG::Rendering::Runtime::UIImageBlurManager::cctor(MethodInfo *method)
		{
		  struct UIImageBlurManager_c__Class *v1; // rax
		  Object *v2; // rdi
		  Func_1_Object_ *v3; // rax
		  __int64 v4; // rdx
		  Lazy_1_HG_Rendering_Runtime_UIImageBlurManager_ *s_Instance; // rcx
		  Func_1_Object_ *v6; // rbx
		  Lazy_1_Object_ *v7; // rax
		  HGRuntimeGrassQuery_Node__Class *v8; // rdi
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  Object *Value; // rax
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::UIImageBlurManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (Func_1_Object_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::UIImageBlurManager>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_4;
		  System::Func<System::Object>::Func(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::UIImageBlurManager::__c::__cctor_b__18_0,
		    0LL);
		  v7 = (Lazy_1_Object_ *)sub_1800368D0(TypeInfo::System::Lazy<HG::Rendering::Runtime::UIImageBlurManager>);
		  v8 = (HGRuntimeGrassQuery_Node__Class *)v7;
		  if ( !v7
		    || (System::Lazy<System::Object>::Lazy(
		          v7,
		          v6,
		          MethodInfo::System::Lazy<HG::Rendering::Runtime::UIImageBlurManager>::Lazy),
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields,
		        static_fields->klass = v8,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields,
		          static_fields,
		          v10,
		          v11,
		          v16),
		        (s_Instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->s_Instance) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(s_Instance, v4);
		  }
		  Value = System::Lazy<System::Object>::get_Value(
		            (Lazy_1_Object_ *)s_Instance,
		            MethodInfo::System::Lazy<HG::Rendering::Runtime::UIImageBlurManager>::get_Value);
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields;
		  v13->monitor = (MonitorData *)Value;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		public bool ShouldRenderUIImageBlur() => default; // 0x0000000183E6DA00-0x0000000183E6DA60
		// Boolean ShouldRenderUIImageBlur()
		bool HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(UIImageBlurManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object_1 *m_source; // rdi
		  Object_1 *m_target; // rbx
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1071 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x42F )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[22].vtable.Finalize.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1071, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  if ( !this->fields.m_shouldRenderUIBlurFlag )
		    return 0;
		  m_source = (Object_1 *)this->fields.m_source;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_source, 0LL, 0LL) )
		    return 0;
		  m_target = (Object_1 *)this->fields.m_target;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  return UnityEngine::Object::op_Inequality(m_target, 0LL, 0LL);
		}
		
		public void CloseUIBlurPass() {} // 0x0000000189C47234-0x0000000189C47280
		// Void CloseUIBlurPass()
		void HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(UIImageBlurManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1076, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1076, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_shouldRenderUIBlurFlag = 0;
		  }
		}
		
		public bool OpenUIBlurPass(Texture src, RenderTexture dest, float scale, Rect rect) => default; // 0x0000000189C473D8-0x0000000189C474F4
		// Boolean OpenUIBlurPass(Texture, RenderTexture, Single, Rect)
		bool HG::Rendering::Runtime::UIImageBlurManager::OpenUIBlurPass(
		        UIImageBlurManager *this,
		        Texture *src,
		        RenderTexture *dest,
		        float scale,
		        Rect *rect,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  bool result; // al
		  __int64 v16; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MethodInfo *v18; // [rsp+20h] [rbp-48h]
		  MethodInfo *v19; // [rsp+20h] [rbp-48h]
		  Rect v20; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4188, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4188, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v16);
		    v20 = *rect;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1467(
		             Patch,
		             (Object *)this,
		             (Object *)src,
		             (Object *)dest,
		             scale,
		             &v20,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)src, 0LL, 0LL)
		      || (sub_1800036A0(TypeInfo::UnityEngine::Object), UnityEngine::Object::op_Equality((Object_1 *)dest, 0LL, 0LL)) )
		    {
		      HG::Rendering::HGRPLogger::LogWarning((String *)"Src or Dest Texture is null. ", 0LL);
		      return 0;
		    }
		    else
		    {
		      this->fields.m_shouldRenderUIBlurFlag = 1;
		      this->fields.m_source = src;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_source, v9, v10, v11, v18);
		      this->fields.m_target = dest;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_target, v12, v13, v14, v19);
		      result = 1;
		      this->fields.m_scale = scale;
		      this->fields.m_rect = *rect;
		    }
		  }
		  return result;
		}
		
		public Texture GetSource() => default; // 0x0000000189C47338-0x0000000189C47388
		// Texture GetSource()
		Texture *HG::Rendering::Runtime::UIImageBlurManager::GetSource(UIImageBlurManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1072, 0LL) )
		    return this->fields.m_source;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1072, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(Patch, (Object *)this, 0LL);
		}
		
		public RenderTexture GetTarget() => default; // 0x0000000189C47388-0x0000000189C473D8
		// RenderTexture GetTarget()
		RenderTexture *HG::Rendering::Runtime::UIImageBlurManager::GetTarget(UIImageBlurManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1073, 0LL) )
		    return this->fields.m_target;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1073, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_413(Patch, (Object *)this, 0LL);
		}
		
		public float GetScale() => default; // 0x0000000189C472E8-0x0000000189C47338
		// Single GetScale()
		float HG::Rendering::Runtime::UIImageBlurManager::GetScale(UIImageBlurManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1075, 0LL) )
		    return this->fields.m_scale;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1075, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		public Rect GetRect() => default; // 0x0000000189C47280-0x0000000189C472E8
		// Rect GetRect()
		Rect *HG::Rendering::Runtime::UIImageBlurManager::GetRect(
		        Rect *__return_ptr retstr,
		        UIImageBlurManager *this,
		        MethodInfo *method)
		{
		  Rect m_rect; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Rect *result; // rax
		  Rect v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1074, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1074, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_rect = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_294(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_rect = this->fields.m_rect;
		  }
		  result = retstr;
		  *retstr = m_rect;
		  return result;
		}
		
		public int GetUIImageBlurTexID() => default; // 0x00000001837E35D0-0x00000001837E3600
		// Int32 GetUIImageBlurTexID()
		int32_t HG::Rendering::Runtime::UIImageBlurManager::GetUIImageBlurTexID(UIImageBlurManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4189, 0LL) )
		    return this->fields.m_uiImageBlurTexID;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4189, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public GraphicsFormat GetUIImageBlurTexFormat() => default; // 0x00000001837E24D0-0x00000001837E2500
		// GraphicsFormat GetUIImageBlurTexFormat()
		GraphicsFormat__Enum HG::Rendering::Runtime::UIImageBlurManager::GetUIImageBlurTexFormat(
		        UIImageBlurManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4190, 0LL) )
		    return 8;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4190, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
