using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	public class HGAdditionalLightGroupController : MonoBehaviour
	{
		public HGAdditionalLightGroupController()
		{
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::OnEnable(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3453, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3453, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::CollectLights(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::OnDisable(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3460, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3460, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( UnityEngine::Application::get_isPlaying(0LL) )
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(this, 0LL);
			//   }
			// }
			// 
		}

		public void SetLightGroupAlpha(float lightAlpha)
		{
			// // Void SetLightGroupAlpha(Single)
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightGroupAlpha(
			//         HGAdditionalLightGroupController *this,
			//         float lightAlpha,
			//         MethodInfo *method)
			// {
			//   Beyond::JobMathf *v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3461, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3461, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       lightAlpha,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
			//     Beyond::JobMathf::Clamp01(v4);
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, lightAlpha, 0LL);
			//   }
			// }
			// 
		}

		public void TweenLightGroupAlpha(float fromLightAlpha, float toLightAlpha, [MetadataOffset(Offset = "0x01F91D2E")] float tweenDuration = 0.5f)
		{
			// // Void TweenLightGroupAlpha(Single, Single, Single)
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::TweenLightGroupAlpha(
			//         HGAdditionalLightGroupController *this,
			//         float fromLightAlpha,
			//         float toLightAlpha,
			//         float tweenDuration,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rax
			//   OneofDescriptorProto *v7; // rdx
			//   __int64 v8; // rcx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   __int64 v11; // rbx
			//   Beyond::JobMathf *v12; // rcx
			//   DOGetter_1_System_Single_ *v13; // rax
			//   DOGetter_1_System_Single_ *v14; // rbp
			//   UnityAction_1_System_Single_ *v15; // rax
			//   DOSetter_1_System_Single_ *v16; // rsi
			//   float v17; // xmm6_4
			//   Object *v18; // rbp
			//   TweenCallback *v19; // rax
			//   TweenCallback *v20; // rsi
			//   Object *v21; // rbp
			//   TweenCallback *v22; // rax
			//   TweenCallback *v23; // rsi
			//   OneofDescriptorProto *v24; // rdx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *P3; // [rsp+20h] [rbp-48h]
			//   String__Array *P3a; // [rsp+20h] [rbp-48h]
			//   String *v30; // [rsp+28h] [rbp-40h]
			//   String *v31; // [rsp+28h] [rbp-40h]
			//   MethodInfo *v32; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v33; // [rsp+30h] [rbp-38h]
			// 
			//   if ( !byte_18D91974E )
			//   {
			//     sub_18003C530(&TypeInfo::DG::Tweening::Core::DOGetter<float>);
			//     sub_18003C530(&TypeInfo::DG::Tweening::Core::DOSetter<float>);
			//     sub_18003C530(&TypeInfo::DG::Tweening::DOTween);
			//     sub_18003C530(&TypeInfo::DG::Tweening::TweenCallback);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenExtensions::Play<DG::Tweening::Tween>);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::OnComplete<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::OnUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__3);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0);
			//     byte_18D91974E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3462, 0LL) )
			//   {
			//     v6 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0);
			//     v11 = v6;
			//     if ( v6 )
			//     {
			//       *(_QWORD *)(v6 + 16) = this;
			//       sub_1800054D0((OneofDescriptor *)(v6 + 16), v7, v9, v10, P3, v30, v32);
			//       *(float *)(v11 + 24) = toLightAlpha;
			//       Beyond::JobMathf::Clamp01(v12);
			//       HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, fromLightAlpha, 0LL);
			//       this.fields.m_curLightGroupAlpha = fromLightAlpha;
			//       HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
			//       v13 = (DOGetter_1_System_Single_ *)sub_180004920(TypeInfo::DG::Tweening::Core::DOGetter<float>);
			//       v14 = v13;
			//       if ( v13 )
			//       {
			//         DG::Tweening::Core::DOGetter<float>::DOGetter(
			//           v13,
			//           (Object *)v11,
			//           MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__0,
			//           0LL);
			//         v15 = (UnityAction_1_System_Single_ *)sub_180004920(TypeInfo::DG::Tweening::Core::DOSetter<float>);
			//         v16 = (DOSetter_1_System_Single_ *)v15;
			//         if ( v15 )
			//         {
			//           UnityEngine::Events::UnityAction<float>::UnityAction(
			//             v15,
			//             (Object *)v11,
			//             MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__1,
			//             0LL);
			//           v17 = *(float *)(v11 + 24);
			//           sub_180002C70(TypeInfo::DG::Tweening::DOTween);
			//           v18 = (Object *)DG::Tweening::DOTween::To(v14, v16, v17, tweenDuration, 0LL);
			//           v19 = (TweenCallback *)sub_180004920(TypeInfo::DG::Tweening::TweenCallback);
			//           v20 = v19;
			//           if ( v19 )
			//           {
			//             DG::Tweening::TweenCallback::TweenCallback(
			//               v19,
			//               (Object *)v11,
			//               MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__2,
			//               0LL);
			//             v21 = DG::Tweening::TweenSettingsExtensions::OnUpdate<System::Object>(
			//                     v18,
			//                     v20,
			//                     MethodInfo::DG::Tweening::TweenSettingsExtensions::OnUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//             v22 = (TweenCallback *)sub_180004920(TypeInfo::DG::Tweening::TweenCallback);
			//             v23 = v22;
			//             if ( v22 )
			//             {
			//               DG::Tweening::TweenCallback::TweenCallback(
			//                 v22,
			//                 (Object *)v11,
			//                 MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__3,
			//                 0LL);
			//               this.fields.m_alphaTween = (Tween *)DG::Tweening::TweenSettingsExtensions::OnComplete<System::Object>(
			//                                                      v21,
			//                                                      v23,
			//                                                      MethodInfo::DG::Tweening::TweenSettingsExtensions::OnComplete<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//               sub_1800054D0((OneofDescriptor *)&this.fields.m_alphaTween, v24, v25, v26, P3a, v31, v33);
			//               DG::Tweening::TweenExtensions::Play<System::Object>(
			//                 (Object *)this.fields.m_alphaTween,
			//                 MethodInfo::DG::Tweening::TweenExtensions::Play<DG::Tweening::Tween>);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3462, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(
			//     (ILFixDynamicMethodWrapper_7 *)Patch,
			//     (Object *)this,
			//     fromLightAlpha,
			//     toLightAlpha,
			//     tweenDuration,
			//     0LL);
			// }
			// 
		}

		public void CollectLights()
		{
			// // Void CollectLights()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::CollectLights(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_System_Object_ *m_LightList; // rcx
			//   Object__Array *v5; // rbp
			//   int32_t v6; // esi
			//   Object *v7; // rbx
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   Object_1 *v11; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object_1 *x[2]; // [rsp+20h] [rbp-28h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91974F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Light>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Add);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91974F = 1;
			//   }
			//   *(_OWORD *)x = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3454, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3454, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(m_LightList, v3);
			//   }
			//   if ( HG::Rendering::Runtime::HGAdditionalLightGroupController::LerpState(this, 0LL) )
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(this, 0LL);
			//   HG::Rendering::Runtime::HGAdditionalLightGroupController::ClearLightInfo(this, 0LL);
			//   v5 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//          (Component *)this,
			//          MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Light>);
			//   v6 = 0;
			//   if ( !v5 )
			//     goto LABEL_21;
			//   while ( v6 < v5.max_length.size )
			//   {
			//     if ( (unsigned int)v6 >= v5.max_length.size )
			//       sub_180070270(m_LightList, v3);
			//     v7 = v5.vector[v6];
			//     if ( !v7 )
			//       goto LABEL_21;
			//     if ( UnityEngine::Light::get_type((Light *)v5.vector[v6], 0LL) == LightType__Enum_Point
			//       || UnityEngine::Light::get_type((Light *)v7, 0LL) == LightType__Enum_Spot )
			//     {
			//       m_LightList = (List_1_System_Object_ *)this.fields.m_LightList;
			//       if ( !m_LightList )
			//         goto LABEL_21;
			//       sub_1822AD140(m_LightList, v7);
			//       x[0] = (Object_1 *)COERCE_UNSIGNED_INT(UnityEngine::Light::get_intensity((Light *)v7, 0LL));
			//       x[1] = (Object_1 *)UnityEngine::Component::GetComponent<System::Object>(
			//                            (Component *)v7,
			//                            MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//       ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//         (OneofDescriptor *)&x[1],
			//         v8,
			//         v9,
			//         v10,
			//         (String__Array *)x[0]);
			//       v11 = x[1];
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(v11, 0LL, 0LL) )
			//       {
			//         if ( !x[1] )
			//           goto LABEL_21;
			//         HIDWORD(x[0]) = x[1][4].fields.m_CachedPtr;
			//       }
			//       m_LightList = (List_1_System_Object_ *)this.fields.m_LightInfoList;
			//       if ( !m_LightList )
			//         goto LABEL_21;
			//       v14 = *(prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA *)x;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::PUUjROsMtnhbqLEaBbcdiryfdlYVA>::Add(
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA_ *)m_LightList,
			//         &v14,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Add);
			//     }
			//     ++v6;
			//   }
			// }
			// 
		}

		public bool LerpState()
		{
			// // Boolean LerpState()
			// bool HG::Rendering::Runtime::HGAdditionalLightGroupController::LerpState(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   float v2; // xmm2_4
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3455, 0LL) )
			//     return UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v4, 1.0, v2) ^ 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3455, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private void SetLightProps(float lightAlpha)
		{
			// // Void SetLightProps(Single)
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(
			//         HGAdditionalLightGroupController *this,
			//         float lightAlpha,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_Runtime_HGAdditionalLightGroupController_LightInfo_ *v4; // rdx
			//   List_1_System_Object_ *size; // rcx
			//   List_1_UnityEngine_Light_ *m_LightList; // rax
			//   List_1_HG_Rendering_Runtime_HGAdditionalLightGroupController_LightInfo_ *m_LightInfoList; // rax
			//   int32_t i; // esi
			//   List_1_UnityEngine_Light_ *v9; // rax
			//   Object *Item; // rbx
			//   __m128i v11; // xmm6
			//   Object *v12; // rax
			//   Light *v13; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v15; // [rsp+20h] [rbp-68h] BYREF
			//   ObjectReflector_ReflectType_FieldInfo v16; // [rsp+30h] [rbp-58h] BYREF
			//   ObjectReflector_ReflectType_FieldInfo v17; // [rsp+40h] [rbp-48h] BYREF
			//   ObjectReflector_ReflectType_FieldInfo v18; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919750 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D518740);
			//     byte_18D919750 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3458, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3458, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       lightAlpha,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_LightList = this.fields.m_LightList;
			//     if ( !m_LightList )
			//       goto LABEL_23;
			//     size = (List_1_System_Object_ *)(unsigned int)m_LightList.fields._size;
			//     m_LightInfoList = this.fields.m_LightInfoList;
			//     if ( !m_LightInfoList )
			//       goto LABEL_23;
			//     if ( (_DWORD)size == m_LightInfoList.fields._size )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         v9 = this.fields.m_LightList;
			//         if ( !v9 )
			//           break;
			//         if ( i >= v9.fields._size )
			//           return;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)this.fields.m_LightList,
			//                  i,
			//                  MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Item);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
			//         {
			//           v4 = this.fields.m_LightInfoList;
			//           if ( !v4 )
			//             break;
			//           System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//             (ObjectReflector_ReflectType_FieldInfo *)&v15,
			//             (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v4,
			//             i,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
			//           v11 = v15;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Inequality((Object_1 *)_mm_srli_si128(v11, 8).m128i_i64[0], 0LL, 0LL) )
			//           {
			//             v4 = this.fields.m_LightInfoList;
			//             if ( !v4 )
			//               break;
			//             System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//               &v17,
			//               (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v4,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
			//             v4 = this.fields.m_LightInfoList;
			//             if ( !v4 )
			//               break;
			//             System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//               &v16,
			//               (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v4,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
			//             size = (List_1_System_Object_ *)v17.type;
			//             if ( !v17.type )
			//               break;
			//             HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRFogAlpha(
			//               (HGAdditionalLightData *)v17.type,
			//               *((float *)&v16.name + 1) * lightAlpha,
			//               0LL);
			//             size = (List_1_System_Object_ *)this.fields.m_LightList;
			//             if ( !size )
			//               break;
			//             v12 = System::Collections::Generic::List<System::Object>::get_Item(
			//                     size,
			//                     i,
			//                     MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Item);
			//             v4 = this.fields.m_LightInfoList;
			//             v13 = (Light *)v12;
			//             if ( !v4 )
			//               break;
			//             System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//               &v18,
			//               (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v4,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
			//             if ( !v13 )
			//               break;
			//             UnityEngine::Light::set_intensity(v13, *(float *)&v18.name * lightAlpha, 0LL);
			//           }
			//         }
			//       }
			// LABEL_23:
			//       sub_180B536AC(size, v4);
			//     }
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     UnityEngine::Debug::LogError((Object *)"Counts of Light list and light info list are different!", 0LL);
			//   }
			// }
			// 
		}

		private void _ClearTween()
		{
			// // Void _ClearTween()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   FileDescriptor *v4; // r8
			//   MessageDescriptor *v5; // r9
			//   Tween *m_alphaTween; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   String__Array *v10; // [rsp+50h] [rbp+28h]
			//   String *v11; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3457, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3457, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_alphaTween = this.fields.m_alphaTween;
			//     if ( m_alphaTween )
			//       DG::Tweening::TweenExtensions::Kill(m_alphaTween, 0, 0LL);
			//     this.fields.m_alphaTween = 0LL;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_alphaTween, v3, v4, v5, v10, v11, v12);
			//   }
			// }
			// 
		}

		private void ResetLights()
		{
			// // Void ResetLights()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3456, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3456, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, 1.0, 0LL);
			//   }
			// }
			// 
		}

		private void ClearLightInfo()
		{
			// // Void ClearLightInfo()
			// void HG::Rendering::Runtime::HGAdditionalLightGroupController::ClearLightInfo(
			//         HGAdditionalLightGroupController *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_LightList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919751 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Clear);
			//     byte_18D919751 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3459, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
			//     m_LightList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_LightList;
			//     if ( m_LightList )
			//     {
			//       sub_1823B99D0(m_LightList, MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Clear);
			//       m_LightList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_LightInfoList;
			//       if ( m_LightList )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//           m_LightList,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Clear);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_LightList, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3459, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		[SerializeField]
		[HideInInspector]
		private List<Light> m_LightList;

		[SerializeField]
		[HideInInspector]
		private List<HGAdditionalLightGroupController.LightInfo> m_LightInfoList;

		private float m_curLightGroupAlpha;

		protected Tween m_alphaTween;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct LightInfo
		{
			public float intensity;

			public float fogAlpha;

			public HGAdditionalLightData lightData;
		}
	}
}
