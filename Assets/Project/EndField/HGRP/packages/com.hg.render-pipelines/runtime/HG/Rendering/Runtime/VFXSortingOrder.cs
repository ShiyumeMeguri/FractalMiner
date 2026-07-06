using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(Renderer))]
	[ExecuteAlways]
	[AddComponentMenu("HG/Effect/VFXSortingOrder(修改渲染顺序)")]
	public class VFXSortingOrder : MonoBehaviour
	{
		public VFXSortingOrder()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::VFXSortingOrder::Awake(VFXSortingOrder *this, MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9B0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Renderer>);
			//     byte_18D8ED9B0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2161, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2161, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_renderer = (Renderer *)UnityEngine::Component::GetComponent<System::Object>(
			//                                             (Component *)this,
			//                                             MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Renderer>);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_renderer, v3, v4, v5, v9, v10);
			//   }
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VFXSortingOrder::OnEnable(VFXSortingOrder *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *m_renderer; // rdi
			//   __int64 v5; // rdx
			//   Renderer *v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9B1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED9B1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2162, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2162, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_renderer = (Object_1 *)this.fields.m_renderer;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( UnityEngine::Object::op_Implicit(m_renderer, 0LL) )
			//     {
			//       v6 = this.fields.m_renderer;
			//       if ( v6 )
			//       {
			//         UnityEngine::Renderer::set_sortingOrder(v6, this.fields.sortingOrder, 0LL);
			//         return;
			//       }
			// LABEL_10:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		private void OnValidate()
		{
		}

		public int sortingOrder;

		private Renderer m_renderer;
	}
}
