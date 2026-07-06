using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class HLODGroup : MonoBehaviour
	{
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool needSyncHLODInfo
		{
			get
			{
				// // Boolean get_defaultValue()
				// bool UnityEngine::UIElements::TypedUxmlAttributeDescription<bool>::get_defaultValue(
				//         TypedUxmlAttributeDescription_1_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000025F0 File Offset: 0x000007F0
		public float hlodDistance
		{
			get
			{
				// // Single get_hlodDistance()
				// float HG::Rendering::Runtime::HLODGroup::get_hlodDistance(HLODGroup *this, MethodInfo *method)
				// {
				//   struct StreamingSettingParameters__Class *v3; // rcx
				//   Renderer *s_parameters; // rdx
				//   Renderer__Class *klass; // rsi
				//   MonitorData *monitor; // r14
				//   Object_1 *hlodRenderer; // rbx
				//   Bounds *bounds; // rax
				//   __int64 v9; // xmm1_8
				//   float v10; // xmm6_4
				//   SettingParameter_1_System_Single_ *v11; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Bounds v14; // [rsp+20h] [rbp-60h] BYREF
				//   _BYTE v15[24]; // [rsp+38h] [rbp-48h]
				//   Bounds v16; // [rsp+50h] [rbp-30h] BYREF
				// 
				//   if ( !byte_18D919DF8 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HLODGroup>::get_Count);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
				//     sub_18003C530(&TypeInfo::StreamingSettingParameters);
				//     byte_18D919DF8 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1486, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1486, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				//     goto LABEL_16;
				//   }
				//   sub_180002C70(TypeInfo::StreamingSettingParameters);
				//   v3 = TypeInfo::StreamingSettingParameters;
				//   s_parameters = (Renderer *)TypeInfo::StreamingSettingParameters.static_fields.s_parameters;
				//   if ( !s_parameters )
				//     goto LABEL_16;
				//   klass = s_parameters[1].klass;
				//   monitor = s_parameters[1].monitor;
				//   hlodRenderer = (Object_1 *)this.fields._hlodRenderer;
				//   sub_180002C70(TypeInfo::UnityEngine::Object);
				//   if ( UnityEngine::Object::op_Inequality(hlodRenderer, 0LL, 0LL) )
				//   {
				//     s_parameters = this.fields._hlodRenderer;
				//     if ( s_parameters )
				//     {
				//       bounds = UnityEngine::Renderer::get_bounds(&v14, s_parameters, 0LL);
				//       v9 = *(_QWORD *)&bounds.m_Extents.y;
				//       *(_OWORD *)v15 = *(_OWORD *)&bounds.m_Center.x;
				//       *(_QWORD *)&v15[16] = v9;
				//       *(_QWORD *)&v14.m_Center.x = *(_QWORD *)&v15[12];
				//       s_parameters = this.fields._hlodRenderer;
				//       if ( s_parameters )
				//       {
				//         *(_QWORD *)&v15[16] = *(_QWORD *)&UnityEngine::Renderer::get_bounds(&v16, s_parameters, 0LL).m_Extents.y;
				//         v10 = fmaxf(v14.m_Center.x, *(float *)&v15[20]);
				//         goto LABEL_10;
				//       }
				//     }
				// LABEL_16:
				//     sub_180B536AC(v3, s_parameters);
				//   }
				//   v10 = 0.0;
				// LABEL_10:
				//   if ( this.fields._childHLODGroupList && this.fields._childHLODGroupList.fields._size )
				//     v11 = (SettingParameter_1_System_Single_ *)monitor;
				//   else
				//     v11 = (SettingParameter_1_System_Single_ *)klass;
				//   return HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
				//            v11,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
				//        + v10;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000025D0 File Offset: 0x000007D0
		public int hlodCombinedTexSize
		{
			get
			{
				// // LayerMask get_value()
				// LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
				//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
				//         MethodInfo *method)
				// {
				//   return (LayerMask)this.fields.m_Value.m_Mask;
				// }
				// 
				return 0;
			}
			set
			{
				// // Void set_value(LayerMask)
				// void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
				//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
				//         LayerMask value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Value = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000025D0 File Offset: 0x000007D0
		public Renderer hlodRenderer
		{
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_getValueDelegate(Func`1[Single])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         Func_1_Single_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (OneofDescriptorProto *)value,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}
		}

		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000025D0 File Offset: 0x000007D0
		public HLODGroup parentHLODGroup
		{
			get
			{
				// // IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
				// IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
				//         aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_onAnimationCompleted(Action)
				// void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
				//         ValueAnimation_1_StyleValues_ *this,
				//         Action *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   this.fields._onAnimationCompleted_k__BackingField = value;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields._onAnimationCompleted_k__BackingField,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (PassConstructorID__Enum__Array *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}
		}

		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000025D2 File Offset: 0x000007D2
		public List<Renderer> rendererList
		{
			get
			{
				// // List`1[UnityEngine.Renderer] get_rendererList()
				// List_1_UnityEngine_Renderer_ *HG::Rendering::Runtime::HLODGroup::get_rendererList(HLODGroup *this, MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1487, 0LL) )
				//     return this.fields._rendererList;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1487, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_565(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000025D2 File Offset: 0x000007D2
		public List<HLODGroup> childHLODGroupList
		{
			get
			{
				// // List`1[HG.Rendering.Runtime.HLODGroup] get_childHLODGroupList()
				// List_1_HG_Rendering_Runtime_HLODGroup_ *HG::Rendering::Runtime::HLODGroup::get_childHLODGroupList(
				//         HLODGroup *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1488, 0LL) )
				//     return this.fields._childHLODGroupList;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1488, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_566(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060007DF RID: 2015 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool hasChildHLOD
		{
			get
			{
				// // Boolean get_hasChildHLOD()
				// bool HG::Rendering::Runtime::HLODGroup::get_hasChildHLOD(HLODGroup *this, MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_HLODGroup_ *childHLODGroupList; // rax
				// 
				//   if ( !byte_18D919DF9 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HLODGroup>::get_Count);
				//     byte_18D919DF9 = 1;
				//   }
				//   childHLODGroupList = this.fields._childHLODGroupList;
				//   if ( !childHLODGroupList )
				//     sub_180B536AC(this, method);
				//   return childHLODGroupList.fields._size > 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 referencePoint
		{
			get
			{
				// // Vector3 get_referencePoint()
				// Vector3 *HG::Rendering::Runtime::HLODGroup::get_referencePoint(
				//         Vector3 *__return_ptr retstr,
				//         HLODGroup *this,
				//         MethodInfo *method)
				// {
				//   Object_1 *hlodRenderer; // rbx
				//   __int64 v6; // rcx
				//   GameObject *gameObject; // rax
				//   Renderer *v8; // rdx
				//   Transform *transform; // rax
				//   Vector3 *position; // rax
				//   Bounds *bounds; // rax
				//   __m128i v12; // xmm2
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v14; // xmm0_8
				//   float z; // eax
				//   Bounds v17; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D919DFA )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919DFA = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1489, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1489, 0LL);
				//     if ( Patch )
				//     {
				//       position = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(&v17.m_Center, Patch, (Object *)this, 0LL);
				//       goto LABEL_13;
				//     }
				// LABEL_11:
				//     sub_180B536AC(v6, v8);
				//   }
				//   hlodRenderer = (Object_1 *)this.fields._hlodRenderer;
				//   sub_180002C70(TypeInfo::UnityEngine::Object);
				//   if ( UnityEngine::Object::op_Equality(hlodRenderer, 0LL, 0LL) )
				//   {
				//     gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
				//     if ( gameObject )
				//     {
				//       transform = UnityEngine::GameObject::get_transform(gameObject, 0LL);
				//       if ( transform )
				//       {
				//         position = UnityEngine::Transform::get_position(&v17.m_Center, transform, 0LL);
				// LABEL_13:
				//         v14 = *(_QWORD *)&position.x;
				//         z = position.z;
				//         *(_QWORD *)&retstr.x = v14;
				//         retstr.z = z;
				//         return retstr;
				//       }
				//     }
				//     goto LABEL_11;
				//   }
				//   v8 = this.fields._hlodRenderer;
				//   if ( !v8 )
				//     goto LABEL_11;
				//   bounds = UnityEngine::Renderer::get_bounds(&v17, v8, 0LL);
				//   v12 = *(__m128i *)&bounds.m_Center.x;
				//   *(_QWORD *)&retstr.x = *(_QWORD *)&bounds.m_Center.x;
				//   LODWORD(retstr.z) = _mm_cvtsi128_si32(_mm_srli_si128(v12, 8));
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public HLODGroup()
		{
		}

		protected void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HLODGroup::OnEnable(HLODGroup *this, MethodInfo *method)
			// {
			//   Object_1 *hlodRenderer; // rbx
			//   __int64 v4; // rdx
			//   Renderer *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DFB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1490, 0LL) )
			//   {
			//     hlodRenderer = (Object_1 *)this.fields._hlodRenderer;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(hlodRenderer, 0LL, 0LL) )
			//       return;
			//     v5 = this.fields._hlodRenderer;
			//     if ( v5 )
			//     {
			//       UnityEngine::Renderer::set_forceRenderingOff(v5, 1, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1490, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		[SerializeField]
		private int _hlodCombinedTexSize;

		[SerializeField]
		private Renderer _hlodRenderer;

		[SerializeField]
		private List<Renderer> _rendererList;

		[SerializeField]
		private HLODGroup _parentHLODGroup;

		[SerializeField]
		private List<HLODGroup> _childHLODGroupList;

		private bool m_needSyncHLODInfo;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static IEnumerable s_hlodTextureSizeList;
	}
}
