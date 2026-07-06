using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPFisheyeEffect(鱼眼后效)")]
	[ExecuteInEditMode]
	public class VFXPPFisheyeEffect : VFXPPComponent
	{
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // ClipCaps get_clipCaps()
				// ClipCaps__Enum Unity::Formats::USD::UsdPlayableAsset::get_clipCaps(UsdPlayableAsset *this, MethodInfo *method)
				// {
				//   return 15;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPFisheyeEffect()
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

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPFisheyeEffect::Apply(
			//         VFXPPFisheyeEffect *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   void *v6; // rdx
			//   Object__Class *klass; // rcx
			//   MonitorData *monitor; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919424 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGFisheyeEffect>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGFisheyeEffect>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>);
			//     byte_18D919424 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2093, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2093, 0LL);
			//     if ( !Patch )
			//       goto LABEL_20;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			//   else
			//   {
			//     transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
			//       return;
			//     if ( !volumeProfile )
			//       goto LABEL_20;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGFisheyeEffect>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGFisheyeEffect>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           klass = component[3].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 1;
			//             if ( component )
			//             {
			//               v6 = component[3].klass;
			//               if ( v6 )
			//               {
			//                 sub_1800463A0(11LL, v6);
			//                 if ( component )
			//                 {
			//                   monitor = component[3].monitor;
			//                   if ( monitor )
			//                   {
			//                     *((_BYTE *)monitor + 16) = 1;
			//                     if ( component )
			//                     {
			//                       v6 = component[3].monitor;
			//                       if ( v6 )
			//                       {
			//                         sub_180042C50(11LL, v6);
			//                         return;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_20:
			//       sub_180B536AC(klass, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPFisheyeEffect::ResetByVolumeProfile(
			//         VFXPPFisheyeEffect *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   void *v5; // rdx
			//   Object__Class *klass; // rcx
			//   MonitorData *monitor; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919425 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>);
			//     byte_18D919425 = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2094, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>) )
			//         return;
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 0;
			//         if ( component )
			//         {
			//           klass = component[3].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 0;
			//             if ( component )
			//             {
			//               v5 = component[3].klass;
			//               if ( v5 )
			//               {
			//                 sub_1800463A0(11LL, v5);
			//                 if ( component )
			//                 {
			//                   monitor = component[3].monitor;
			//                   if ( monitor )
			//                   {
			//                     *((_BYTE *)monitor + 16) = 0;
			//                     if ( component )
			//                     {
			//                       v5 = component[3].monitor;
			//                       if ( v5 )
			//                       {
			//                         sub_180042C50(11LL, v5);
			//                         return;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(klass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2094, 0LL);
			//   if ( !Patch )
			//     goto LABEL_18;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)volumeProfile,
			//     0LL);
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPFisheyeEffect::IsActive(VFXPPFisheyeEffect *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2095, 0LL) )
			//     return this.fields._distortion != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2095, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_Apply(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public bool <>iFixBaseProxy_IsActive()
		{
			// // Boolean <>iFixBaseProxy_IsActive()
			// bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[SerializeField]
		[Range(0f, 0.5f)]
		private float _distortion;
	}
}
