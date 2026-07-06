using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPCharacterBloom(角色柔光)")]
	[ExecuteInEditMode]
	public class VFXPPCharacterBloom : VFXPPComponent
	{
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 get_id()
				// int32_t Beyond::Gameplay::Factory::ConveyorFragment::get_id(ConveyorFragment *this, MethodInfo *method)
				// {
				//   return 14;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPCharacterBloom()
		{
			// // VFXPPCharacterBloom()
			// void HG::Rendering::Runtime::VFXPPCharacterBloom::VFXPPCharacterBloom(VFXPPCharacterBloom *this, MethodInfo *method)
			// {
			//   this.fields.m_CharacterBloomEnabled = 1;
			//   this.fields.m_CharacterBloomThreshold = 0.75;
			//   this.fields.m_CharacterBloomIntensity = 1.0;
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterBloom::Apply(
			//         VFXPPCharacterBloom *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   MonitorData *monitor; // rax
			//   Object__Class *klass; // rax
			//   Object__Class *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91940B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<bool>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::Bloom>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::Bloom>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>);
			//     byte_18D91940B = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2026, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2026, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !volumeProfile )
			//       goto LABEL_17;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::Bloom>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::Bloom>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           monitor = component[10].monitor;
			//           LOBYTE(v6) = this.fields.m_CharacterBloomEnabled;
			//           if ( monitor )
			//           {
			//             *((_BYTE *)monitor + 16) = 1;
			//             *((_BYTE *)monitor + 24) = v6;
			//             if ( component )
			//             {
			//               klass = component[11].klass;
			//               if ( klass )
			//               {
			//                 *(float *)&klass._0.namespaze = this.fields.m_CharacterBloomThreshold;
			//                 LOBYTE(klass._0.name) = 1;
			//                 if ( component )
			//                 {
			//                   v9 = component[12].klass;
			//                   if ( v9 )
			//                   {
			//                     *(float *)&v9._0.namespaze = this.fields.m_CharacterBloomIntensity;
			//                     LOBYTE(v9._0.name) = 1;
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_17:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterBloom::ResetByVolumeProfile(
			//         VFXPPCharacterBloom *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   _BYTE *monitor; // rcx
			//   Object__Class *klass; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91940C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>);
			//     byte_18D91940C = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2027, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>) )
			//         return;
			//       if ( component )
			//       {
			//         monitor = component[10].monitor;
			//         if ( monitor )
			//         {
			//           monitor[16] = 0;
			//           if ( component )
			//           {
			//             monitor = component[11].klass;
			//             if ( monitor )
			//             {
			//               monitor[16] = 0;
			//               if ( component )
			//               {
			//                 klass = component[12].klass;
			//                 if ( klass )
			//                 {
			//                   LOBYTE(klass._0.name) = 0;
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(monitor, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2027, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)volumeProfile,
			//     0LL);
			// }
			// 
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

		[SerializeField]
		private bool m_CharacterBloomEnabled;

		[SerializeField]
		private float m_CharacterBloomThreshold;

		[SerializeField]
		[Range(0f, 10f)]
		private float m_CharacterBloomIntensity;
	}
}
