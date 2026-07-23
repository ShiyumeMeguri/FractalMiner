using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXSortingOrder(\u4FEE\u6539\u6E32\u67D3\u987A\u5E8F)")]
	[ExecuteAlways]
	[RequireComponent(typeof(Renderer))]
	public class VFXSortingOrder : MonoBehaviour // TypeDefIndex: 37979
	{
		// Fields
		public int sortingOrder; // 0x18
		private Renderer m_renderer; // 0x20
	
		// Constructors
		public VFXSortingOrder() {} // 0x0000000183695570-0x0000000183695590
		// LuaUIWidget()
		void Beyond::Lua::LuaUIWidget::LuaUIWidget(LuaUIWidget *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void Awake() {} // 0x0000000183484B60-0x0000000183484BB0
		// Void Awake()
		void HG::Rendering::Runtime::VFXSortingOrder::Awake(VFXSortingOrder *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2610, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2610, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_renderer = (Renderer *)UnityEngine::Component::GetComponent<System::Object>(
		                                            (Component *)this,
		                                            MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Renderer>);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderer, v3, v4, v5, v9);
		  }
		}
		
		private void OnEnable() {} // 0x00000001837D5040-0x00000001837D50C0
		// Void OnEnable()
		void HG::Rendering::Runtime::VFXSortingOrder::OnEnable(VFXSortingOrder *this, MethodInfo *method)
		{
		  Object_1 *m_renderer; // rdi
		  __int64 v4; // rdx
		  Renderer *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2611, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2611, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_renderer = (Object_1 *)this->fields.m_renderer;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_renderer, 0LL) )
		    {
		      v5 = this->fields.m_renderer;
		      if ( v5 )
		      {
		        UnityEngine::Renderer::set_sortingOrder(v5, this->fields.sortingOrder, 0LL);
		        return;
		      }
		LABEL_8:
		      sub_1800D8260(v5, v4);
		    }
		  }
		}
		
		private void OnValidate() {} // 0x0000000189B6E170-0x0000000189B6E230
		// Void OnValidate()
		void HG::Rendering::Runtime::VFXSortingOrder::OnValidate(VFXSortingOrder *this, MethodInfo *method)
		{
		  Object_1 *m_renderer; // rbx
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  Object_1 *v7; // rbx
		  __int64 v8; // rdx
		  Renderer *v9; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2612, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2612, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_renderer = (Object_1 *)this->fields.m_renderer;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(m_renderer, 0LL, 0LL) )
		    {
		      this->fields.m_renderer = (Renderer *)UnityEngine::Component::GetComponent<System::Object>(
		                                              (Component *)this,
		                                              MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Renderer>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderer, v4, v5, v6, v11);
		    }
		    v7 = (Object_1 *)this->fields.m_renderer;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(v7, 0LL) )
		    {
		      v9 = this->fields.m_renderer;
		      if ( v9 )
		      {
		        UnityEngine::Renderer::set_sortingOrder(v9, this->fields.sortingOrder, 0LL);
		        return;
		      }
		LABEL_8:
		      sub_1800D8260(v9, v8);
		    }
		  }
		}
		
	}
}
