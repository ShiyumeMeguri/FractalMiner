using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VFXPPComponent : VFXPlayableMonoBase
	{
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00002998 File Offset: 0x00000B98
		protected virtual VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 GetAndroidAPILevel()
				// int32_t Rewired::Utils::ExternalTools::GetAndroidAPILevel(ExternalTools *this, MethodInfo *method)
				// {
				//   return -1;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000025D8 File Offset: 0x000007D8
		public virtual bool ImplementedInVolume
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

		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x000029B0 File Offset: 0x00000BB0
		public VFXPPPriority priority
		{
			get
			{
				// // Int32 get_count()
				// int32_t Beyond::UnorderedList<System::Object>::get_count(UnorderedList_1_System_Object_ *this, MethodInfo *method)
				// {
				//   return this.fields._count_k__BackingField;
				// }
				// 
				return (VFXPPPriority)VFXPPPriority.Normal;
			}
		}

		public VFXPPComponent()
		{
			// // VFXPPVignette()
			// void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
			// {
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::VFXPPComponent::OnPlay(VFXPPComponent *this, MethodInfo *method)
			// {
			//   VFXPPManager_1 *instance; // rdi
			//   VFXPPType__Enum v4; // eax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2049, 0LL) )
			//   {
			//     instance = HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
			//     v4 = (unsigned int)sub_18003ED00(8LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::VFXPPManager::AddActiveComponent(instance, v4, this, 0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2049, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::VFXPPComponent::OnStop(VFXPPComponent *this, MethodInfo *method)
			// {
			//   VFXPPManager_1 *instance; // rdi
			//   VFXPPType__Enum v4; // eax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2053, 0LL) )
			//   {
			//     instance = HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
			//     v4 = (unsigned int)sub_18003ED00(8LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::VFXPPManager::RemoveActiveComponent(instance, v4, this, 0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2053, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDestroy()
		{
			// // Void OnDestroy()
			// void HG::Rendering::Runtime::VFXPPComponent::OnDestroy(VFXPPComponent *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2057, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2057, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
			//   }
			// }
			// 
		}

		public virtual void SetData(VFXPPData data)
		{
			// // Void SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPComponent::SetData(VFXPPComponent *this, VFXPPData *data, MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   NotImplementedException *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   NotImplementedException *v9; // rbx
			//   __int64 v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2059, 0LL) )
			//   {
			//     v5 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//     v6 = (NotImplementedException *)sub_180004920(v5);
			//     v9 = v6;
			//     if ( v6 )
			//     {
			//       System::NotImplementedException::NotImplementedException(v6, 0LL);
			//       v10 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::SetData);
			//       sub_18000F7C0(v9, v10);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2059, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)data,
			//     0LL);
			// }
			// 
		}

		public virtual VFXPPData GetData()
		{
			// // VFXPPData GetData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPComponent::GetData(VFXPPComponent *this, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   NotImplementedException *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   NotImplementedException *v7; // rbx
			//   __int64 v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2060, 0LL) )
			//   {
			//     v3 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//     v4 = (NotImplementedException *)sub_180004920(v3);
			//     v7 = v4;
			//     if ( v4 )
			//     {
			//       System::NotImplementedException::NotImplementedException(v4, 0LL);
			//       v8 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::GetData);
			//       sub_18000F7C0(v7, v8);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2060, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public virtual VFXPPData GetDefaultData()
		{
			// // VFXPPData GetDefaultData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPComponent::GetDefaultData(VFXPPComponent *this, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   NotImplementedException *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   NotImplementedException *v7; // rbx
			//   __int64 v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2061, 0LL) )
			//   {
			//     v3 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//     v4 = (NotImplementedException *)sub_180004920(v3);
			//     v7 = v4;
			//     if ( v4 )
			//     {
			//       System::NotImplementedException::NotImplementedException(v4, 0LL);
			//       v8 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::GetDefaultData);
			//       sub_18000F7C0(v7, v8);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2061, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		private void _ClearTween()
		{
		}

		public void EnableVFXPP(VFXPPData vfxPPData, [MetadataOffset(Offset = "0x01F91375")] float tweenTime = -1f, AnimationCurve curve = null)
		{
			// // Void EnableVFXPP(VFXPPData, Single, AnimationCurve)
			// void HG::Rendering::Runtime::VFXPPComponent::EnableVFXPP(
			//         VFXPPComponent *this,
			//         VFXPPData *vfxPPData,
			//         float tweenTime,
			//         AnimationCurve *curve,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-28h]
			//   MethodInfo *P3a; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v20; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2062, 0LL) )
			//   {
			//     if ( this.fields.m_tween )
			//       HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
			//     this.fields.m_targetEnable = 1;
			//     UnityEngine::Behaviour::set_enabled((Behaviour *)this, 1, 0LL);
			//     this.fields.m_targetData = vfxPPData;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_targetData, v8, v9, v10, P3, v19);
			//     if ( vfxPPData )
			//     {
			//       this.fields.m_priority = vfxPPData.fields.priority;
			//       this.fields.m_snapShotData = (VFXPPData *)sub_18004A410(11LL, this);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_snapShotData, v13, v14, v15, P3a, v20);
			//       HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(this, tweenTime, curve, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v12, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2062, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_778(
			//     Patch,
			//     (Object *)this,
			//     (Object *)vfxPPData,
			//     tweenTime,
			//     (Object *)curve,
			//     0LL);
			// }
			// 
		}

		public void DisableVFXPP([MetadataOffset(Offset = "0x01F91379")] float tweenTime = -1f, AnimationCurve curve = null)
		{
			// // Void DisableVFXPP(Single, AnimationCurve)
			// void HG::Rendering::Runtime::VFXPPComponent::DisableVFXPP(
			//         VFXPPComponent *this,
			//         float tweenTime,
			//         AnimationCurve *curve,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   MethodInfo *v15; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v16; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v17; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-20h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2067, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2067, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
			//       (ILFixDynamicMethodWrapper_4 *)Patch,
			//       (Object *)this,
			//       tweenTime,
			//       (Object *)curve,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.m_tween )
			//       HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
			//     if ( UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
			//     {
			//       if ( tweenTime <= 0.0 )
			//       {
			//         UnityEngine::Behaviour::set_enabled((Behaviour *)this, 0, 0LL);
			//       }
			//       else
			//       {
			//         this.fields.m_targetData = (VFXPPData *)sub_18004A410(12LL, this);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_targetData, v6, v7, v8, v15, v17);
			//         this.fields.m_snapShotData = (VFXPPData *)sub_18004A410(11LL, this);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_snapShotData, v9, v10, v11, v16, v18);
			//         HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(this, tweenTime, curve, 0LL);
			//         this.fields.m_targetEnable = 0;
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void _TryGenTween(float tweenTime, AnimationCurve curve = null)
		{
			// // Void _TryGenTween(Single, AnimationCurve)
			// void HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(
			//         VFXPPComponent *this,
			//         float tweenTime,
			//         AnimationCurve *curve,
			//         MethodInfo *method)
			// {
			//   DOGetter_1_System_Single_ *v6; // rax
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   __int64 v8; // rcx
			//   DOGetter_1_System_Single_ *v9; // rsi
			//   UnityAction_1_System_Single_ *v10; // rax
			//   DOSetter_1_System_Single_ *v11; // rbp
			//   Object *v12; // rax
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   Object *m_tween; // rcx
			//   Tween *v17; // rdi
			//   TweenCallback *v18; // rax
			//   TweenCallback *v19; // rsi
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v23; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v24; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v25; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D91941A )
			//   {
			//     sub_18003C530(&TypeInfo::DG::Tweening::Core::DOGetter<float>);
			//     sub_18003C530(&TypeInfo::DG::Tweening::Core::DOSetter<float>);
			//     sub_18003C530(&TypeInfo::DG::Tweening::DOTween);
			//     sub_18003C530(&TypeInfo::DG::Tweening::TweenCallback);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::SetAutoKill<DG::Tweening::Tween>);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
			//     sub_18003C530(&MethodInfo::DG::Tweening::TweenSettingsExtensions::SetUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_ClearTween);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_GetValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_SetValue);
			//     byte_18D91941A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2063, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
			//     v6 = (DOGetter_1_System_Single_ *)sub_180004920(TypeInfo::DG::Tweening::Core::DOGetter<float>);
			//     v9 = v6;
			//     if ( v6 )
			//     {
			//       DG::Tweening::Core::DOGetter<float>::DOGetter(
			//         v6,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_GetValue,
			//         0LL);
			//       v10 = (UnityAction_1_System_Single_ *)sub_180004920(TypeInfo::DG::Tweening::Core::DOSetter<float>);
			//       v11 = (DOSetter_1_System_Single_ *)v10;
			//       if ( v10 )
			//       {
			//         UnityEngine::Events::UnityAction<float>::UnityAction(
			//           v10,
			//           (Object *)this,
			//           MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_SetValue,
			//           0LL);
			//         sub_180002C70(TypeInfo::DG::Tweening::DOTween);
			//         v12 = (Object *)DG::Tweening::DOTween::To(v9, v11, 1.0, tweenTime, 0LL);
			//         this.fields.m_tween = (Tween *)DG::Tweening::TweenSettingsExtensions::SetUpdate<System::Object>(
			//                                           v12,
			//                                           UpdateType__Enum_Late,
			//                                           MethodInfo::DG::Tweening::TweenSettingsExtensions::SetUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_tween, v13, v14, v15, v23, v25);
			//         m_tween = (Object *)this.fields.m_tween;
			//         if ( curve )
			//           DG::Tweening::TweenSettingsExtensions::SetEase<System::Object>(
			//             m_tween,
			//             curve,
			//             MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
			//         else
			//           DG::Tweening::TweenSettingsExtensions::SetEase<System::Object>(
			//             m_tween,
			//             Ease__Enum_InOutSine,
			//             MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
			//         v17 = this.fields.m_tween;
			//         v18 = (TweenCallback *)sub_180004920(TypeInfo::DG::Tweening::TweenCallback);
			//         v19 = v18;
			//         if ( v18 )
			//         {
			//           DG::Tweening::TweenCallback::TweenCallback(
			//             v18,
			//             (Object *)this,
			//             MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_ClearTween,
			//             0LL);
			//           if ( v17 )
			//           {
			//             v17.fields.onComplete = v19;
			//             sub_1800054D0((HGRenderPathScene *)&v17.fields.onComplete, v7, v20, v21, v24, v26);
			//             DG::Tweening::TweenSettingsExtensions::SetAutoKill<System::Object>(
			//               (Object *)this.fields.m_tween,
			//               MethodInfo::DG::Tweening::TweenSettingsExtensions::SetAutoKill<DG::Tweening::Tween>);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2063, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
			//     (ILFixDynamicMethodWrapper_4 *)Patch,
			//     (Object *)this,
			//     tweenTime,
			//     (Object *)curve,
			//     0LL);
			// }
			// 
		}

		protected float _GetValue()
		{
			// // Single _GetValue()
			// float HG::Rendering::Runtime::VFXPPComponent::_GetValue(VFXPPComponent *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2064, 0LL) )
			//     return this.fields.m_tweenNum;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2064, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0f;
		}

		protected virtual VFXPPData _GetLerpData(float value)
		{
			// // VFXPPData _GetLerpData(Single)
			// VFXPPData *HG::Rendering::Runtime::VFXPPComponent::_GetLerpData(VFXPPComponent *this, float value, MethodInfo *method)
			// {
			//   __int64 v4; // rax
			//   NotImplementedException *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   NotImplementedException *v8; // rbx
			//   __int64 v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2066, 0LL) )
			//   {
			//     v4 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//     v5 = (NotImplementedException *)sub_180004920(v4);
			//     v8 = v5;
			//     if ( v5 )
			//     {
			//       System::NotImplementedException::NotImplementedException(v5, 0LL);
			//       v9 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_GetLerpData);
			//       sub_18000F7C0(v8, v9);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2066, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_774(Patch, (Object *)this, value, 0LL);
			// }
			// 
			return null;
		}

		protected void _SetValue(float value)
		{
			// // Void _SetValue(Single)
			// void HG::Rendering::Runtime::VFXPPComponent::_SetValue(VFXPPComponent *this, float value, MethodInfo *method)
			// {
			//   VFXPPComponent__Class *klass; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rax
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2065, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2065, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     klass = this.klass;
			//     this.fields.m_tweenNum = value;
			//     sub_180003EE0(klass);
			//     v6 = ((__int64 (__fastcall *)(VFXPPComponent *, __int64, Il2CppMethodPointer))this.klass.vtable._GetLerpData.method)(
			//            this,
			//            v5,
			//            this.klass.vtable.Apply.methodPtr);
			//     sub_180080C00(v7, this, v6);
			//   }
			// }
			// 
		}

		public void SetAsDefault()
		{
			// // Void SetAsDefault()
			// void HG::Rendering::Runtime::VFXPPComponent::SetAsDefault(VFXPPComponent *this, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2068, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2068, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v3 = sub_18004A410(12LL, this);
			//     sub_180080C00(v4, this, v3);
			//   }
			// }
			// 
		}

		public virtual void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPComponent::Apply(
			//         VFXPPComponent *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2069, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2069, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile(
			//         VFXPPComponent *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2055, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2055, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void ApplyEnvPhase(HGEnvironmentPhase envPhase)
		{
			// // Void ApplyEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPComponent::ApplyEnvPhase(
			//         VFXPPComponent *this,
			//         HGEnvironmentPhase *envPhase,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2070, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2070, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)envPhase,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void ResetEnvPhase(HGEnvironmentPhase envPhase)
		{
			// // Void ResetEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPComponent::ResetEnvPhase(
			//         VFXPPComponent *this,
			//         HGEnvironmentPhase *envPhase,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2056, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2056, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)envPhase,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPComponent::IsActive(VFXPPComponent *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2071, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2071, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_OnPlay()
		{
			// // Void <>iFixBaseProxy_OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		[SerializeField]
		protected VFXPPPriority m_priority;

		private Tween m_tween;

		protected float m_tweenNum;

		private bool m_targetEnable;

		protected VFXPPData m_targetData;

		protected VFXPPData m_snapShotData;
	}
}
