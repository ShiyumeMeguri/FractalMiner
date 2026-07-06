using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[AddComponentMenu("HG/Effect/VFXPPColorAdjustments(后处理调色)")]
	public class VFXPPColorAdjustments : VFXPPComponent
	{
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<UnityEngine::Vector4,UnityEngine::Vector4,UnityEngine::Vector4>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return 3;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000025D8 File Offset: 0x000007D8
		public override bool ImplementedInVolume
		{
			get
			{
				// // Boolean get_ring()
				// bool Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_ring(
				//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
				//         MethodInfo *method)
				// {
				//   return 0;
				// }
				// 
				return default(bool);
			}
		}

		public VFXPPColorAdjustments()
		{
			// // VFXPPColorAdjustments()
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::VFXPPColorAdjustments(
			//         VFXPPColorAdjustments *this,
			//         MethodInfo *method)
			// {
			//   Vector4 v2; // xmm1
			//   __int64 v3; // r8
			//   Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v2 = *UnityEngine::Vector4::get_one(&v4, method);
			//   *(_BYTE *)(v3 + 52) = 1;
			//   *(_BYTE *)(v3 + 24) = 1;
			//   *(Vector4 *)(v3 + 76) = v2;
			//   UnityEngine::Component::Component((Component *)v3, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::Apply(
			//         VFXPPColorAdjustments *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   Object__Class *v6; // rdx
			//   Object__Class *klass; // rcx
			//   Object__Class *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color color; // [rsp+20h] [rbp-18h] BYREF
			//   Object *component; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919416 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::ColorAdjustments>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::ColorAdjustments>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>);
			//     byte_18D919416 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2044, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2044, 0LL);
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
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::ColorAdjustments>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::ColorAdjustments>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           klass = component[5].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 1;
			//             if ( component )
			//             {
			//               v6 = component[5].klass;
			//               if ( v6 )
			//               {
			//                 sub_180042C50(11LL, v6);
			//                 if ( component )
			//                 {
			//                   v8 = component[4].klass;
			//                   if ( v8 )
			//                   {
			//                     LOBYTE(v8._0.name) = 1;
			//                     if ( component )
			//                     {
			//                       v6 = component[4].klass;
			//                       if ( v6 )
			//                       {
			//                         color = this.fields._color;
			//                         sub_18004EA90(11LL, v6, &color);
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
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::ResetByVolumeProfile(
			//         VFXPPColorAdjustments *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object__Class *v5; // rdx
			//   Object__Class *klass; // rcx
			//   Object__Class *v7; // rax
			//   Vector4 *one; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
			//   Object *component; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919417 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>);
			//     byte_18D919417 = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2045, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>) )
			//         return;
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 0;
			//         if ( component )
			//         {
			//           klass = component[5].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 0;
			//             if ( component )
			//             {
			//               v5 = component[5].klass;
			//               if ( v5 )
			//               {
			//                 sub_180042C50(11LL, v5);
			//                 if ( component )
			//                 {
			//                   v7 = component[4].klass;
			//                   if ( v7 )
			//                   {
			//                     LOBYTE(v7._0.name) = 0;
			//                     if ( component )
			//                     {
			//                       one = UnityEngine::Vector4::get_one(&v10, (MethodInfo *)component[4].klass);
			//                       if ( v5 )
			//                       {
			//                         v10 = *one;
			//                         sub_18004EA90(11LL, v5, &v10);
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
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2045, 0LL);
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

		public override void ApplyEnvPhase(HGEnvironmentPhase envPhase)
		{
			// // Void ApplyEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::ApplyEnvPhase(
			//         VFXPPColorAdjustments *this,
			//         HGEnvironmentPhase *envPhase,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919418 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919418 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2046, 0LL) )
			//   {
			//     transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
			//       return;
			//     if ( envPhase )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//       envPhase.fields.colorGradingConfig.m_active = 1;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsEnabled = 1;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsSaturation = this.fields._saturation;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsColorFilter = (Color)_mm_loadu_si128((const __m128i *)&this.fields._color);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2046, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)envPhase,
			//     0LL);
			// }
			// 
		}

		public override void ResetEnvPhase(HGEnvironmentPhase envPhase)
		{
			// // Void ResetEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::ResetEnvPhase(
			//         VFXPPColorAdjustments *this,
			//         HGEnvironmentPhase *envPhase,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   MethodInfo *v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919419 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     byte_18D919419 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2047, 0LL) )
			//   {
			//     if ( envPhase )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//       envPhase.fields.colorGradingConfig.m_active = 0;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsEnabled = 0;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsSaturation = 0.0;
			//       envPhase.fields.colorGradingConfig.colorAdjustmentsColorFilter = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v9, v7));
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2047, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)envPhase,
			//     0LL);
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPColorAdjustments::IsActive(VFXPPColorAdjustments *this, MethodInfo *method)
			// {
			//   MethodInfo *v3; // rdx
			//   Vector4 v4; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color color; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2048, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2048, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields._saturation == 0.0 )
			//   {
			//     v4 = *UnityEngine::Vector4::get_one((Vector4 *)&color, v3);
			//     color = this.fields._color;
			//     v9 = v4;
			//     return sub_182F6C030(&color, &v9);
			//   }
			//   else
			//   {
			//     return 1;
			//   }
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

		public void <>iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase P0)
		{
			// // Void <>iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::__iFixBaseProxy_ApplyEnvPhase(
			//         VFXPPColorAdjustments *this,
			//         HGEnvironmentPhase *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ApplyEnvPhase((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase P0)
		{
			// // Void <>iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VFXPPColorAdjustments::__iFixBaseProxy_ResetEnvPhase(
			//         VFXPPColorAdjustments *this,
			//         HGEnvironmentPhase *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ResetEnvPhase((VFXPPComponent *)this, P0, 0LL);
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
		[Range(-100f, 100f)]
		private float _saturation;

		[SerializeField]
		private Color _color;
	}
}
