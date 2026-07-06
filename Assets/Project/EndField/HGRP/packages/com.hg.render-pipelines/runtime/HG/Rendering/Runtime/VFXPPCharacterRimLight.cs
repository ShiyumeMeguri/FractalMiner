using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[AddComponentMenu("HG/Effect/VFXPPCharacterRimLight(角色全局边缘光)")]
	public class VFXPPCharacterRimLight : VFXPPComponent
	{
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 get_id()
				// int32_t UnityEngine::HyperGryph::ECS::RenderObjectK16Component::get_id(
				//         RenderObjectK16Component *this,
				//         MethodInfo *method)
				// {
				//   return 12;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPCharacterRimLight()
		{
			// // VFXPPCharacterRimLight()
			// void HG::Rendering::Runtime::VFXPPCharacterRimLight::VFXPPCharacterRimLight(
			//         VFXPPCharacterRimLight *this,
			//         MethodInfo *method)
			// {
			//   Vector4 v2; // xmm1
			//   __int64 v3; // r8
			//   MethodInfo *v4; // rdx
			//   Vector4 v5; // xmm1
			//   __int64 v6; // r8
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v2 = *UnityEngine::Vector4::get_one(&v7, method);
			//   *(_DWORD *)(v3 + 92) = 1065353216;
			//   *(_DWORD *)(v3 + 96) = 1053609165;
			//   *(Vector4 *)(v3 + 72) = v2;
			//   v5 = *UnityEngine::Vector4::get_one(&v7, v4);
			//   *(_DWORD *)(v6 + 124) = 1036831949;
			//   *(_DWORD *)(v6 + 128) = 1065353216;
			//   *(Vector4 *)(v6 + 108) = v5;
			//   *(_BYTE *)(v6 + 52) = 1;
			//   *(_BYTE *)(v6 + 24) = 1;
			//   UnityEngine::Component::Component((Component *)v6, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterRimLight::Apply(
			//         VFXPPCharacterRimLight *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Object__Class *klass; // rax
			//   MonitorData *monitor; // rax
			//   __m128i v10; // xmm0
			//   Object__Class *v11; // rax
			//   MonitorData *v12; // rax
			//   Object__Class *v13; // rax
			//   MonitorData *v14; // rax
			//   Object__Class *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   __m128i v18; // xmm0
			//   MonitorData *v19; // rax
			//   Object__Class *v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D919410 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<bool>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGCharacterVolume>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGCharacterVolume>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>);
			//     byte_18D919410 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2034, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2034, 0LL);
			//     if ( !Patch )
			//       goto LABEL_34;
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
			//       goto LABEL_34;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGCharacterVolume>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGCharacterVolume>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           klass = component[17].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 1;
			//             LOBYTE(klass._0.namespaze) = 1;
			//             if ( component )
			//             {
			//               monitor = component[17].monitor;
			//               if ( monitor )
			//               {
			//                 v10 = _mm_loadu_si128((const __m128i *)&this.fields.m_RimLightColor);
			//                 *((_BYTE *)monitor + 16) = 1;
			//                 *(__m128i *)((char *)monitor + 24) = v10;
			//                 if ( component )
			//                 {
			//                   v11 = component[18].klass;
			//                   if ( v11 )
			//                   {
			//                     *(float *)&v11._0.namespaze = this.fields.m_RimAngle;
			//                     LOBYTE(v11._0.name) = 1;
			//                     if ( component )
			//                     {
			//                       v12 = component[18].monitor;
			//                       if ( v12 )
			//                       {
			//                         *((_DWORD *)v12 + 6) = LODWORD(this.fields.m_RimIntensity);
			//                         *((_BYTE *)v12 + 16) = 1;
			//                         if ( component )
			//                         {
			//                           v13 = component[19].klass;
			//                           if ( v13 )
			//                           {
			//                             *(float *)&v13._0.namespaze = this.fields.m_RimWidth;
			//                             LOBYTE(v13._0.name) = 1;
			//                             if ( component )
			//                             {
			//                               v14 = component[19].monitor;
			//                               if ( v14 )
			//                               {
			//                                 *((_DWORD *)v14 + 6) = LODWORD(this.fields.m_RimAlbedo);
			//                                 *((_BYTE *)v14 + 16) = 1;
			//                                 if ( component )
			//                                 {
			//                                   v15 = component[20].klass;
			//                                   LOBYTE(v7) = this.fields.m_RimMode;
			//                                   if ( v15 )
			//                                   {
			//                                     LOBYTE(v15._0.name) = 1;
			//                                     LOBYTE(v15._0.namespaze) = v7;
			//                                     if ( component )
			//                                     {
			//                                       v16 = component[20].monitor;
			//                                       LOBYTE(v7) = this.fields.m_EnableFaceRim;
			//                                       if ( v16 )
			//                                       {
			//                                         *((_BYTE *)v16 + 16) = 1;
			//                                         *((_BYTE *)v16 + 24) = v7;
			//                                         if ( component )
			//                                         {
			//                                           v17 = component[21].klass;
			//                                           if ( v17 )
			//                                           {
			//                                             v18 = _mm_loadu_si128((const __m128i *)&this.fields.m_FaceRimLightColor);
			//                                             LOBYTE(v17._0.name) = 1;
			//                                             *(__m128i *)&v17._0.namespaze = v18;
			//                                             if ( component )
			//                                             {
			//                                               v19 = component[21].monitor;
			//                                               if ( v19 )
			//                                               {
			//                                                 *((_DWORD *)v19 + 6) = LODWORD(this.fields.m_FaceRimAngle);
			//                                                 *((_BYTE *)v19 + 16) = 1;
			//                                                 if ( component )
			//                                                 {
			//                                                   v20 = component[22].klass;
			//                                                   if ( v20 )
			//                                                   {
			//                                                     *(float *)&v20._0.namespaze = this.fields.m_FaceRimIntensity;
			//                                                     LOBYTE(v20._0.name) = 1;
			//                                                     return;
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_34:
			//       sub_180B536AC(v7, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterRimLight::ResetByVolumeProfile(
			//         VFXPPCharacterRimLight *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED987 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>);
			//     byte_18D8ED987 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2035, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2035, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)volumeProfile,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_10;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//   {
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>) )
			//         return;
			//       if ( component )
			//       {
			//         klass = component[17].klass;
			//         if ( klass )
			//         {
			//           klass[16] = 0;
			//           if ( component )
			//           {
			//             klass = component[17].monitor;
			//             if ( klass )
			//             {
			//               klass[16] = 0;
			//               if ( component )
			//               {
			//                 klass = component[18].klass;
			//                 if ( klass )
			//                 {
			//                   klass[16] = 0;
			//                   if ( component )
			//                   {
			//                     klass = component[18].monitor;
			//                     if ( klass )
			//                     {
			//                       klass[16] = 0;
			//                       if ( component )
			//                       {
			//                         klass = component[19].klass;
			//                         if ( klass )
			//                         {
			//                           klass[16] = 0;
			//                           if ( component )
			//                           {
			//                             klass = component[19].monitor;
			//                             if ( klass )
			//                             {
			//                               klass[16] = 0;
			//                               if ( component )
			//                               {
			//                                 klass = component[20].klass;
			//                                 if ( klass )
			//                                 {
			//                                   klass[16] = 0;
			//                                   if ( component )
			//                                   {
			//                                     klass = component[20].monitor;
			//                                     if ( klass )
			//                                     {
			//                                       klass[16] = 0;
			//                                       if ( component )
			//                                       {
			//                                         klass = component[21].klass;
			//                                         if ( klass )
			//                                         {
			//                                           klass[16] = 0;
			//                                           if ( component )
			//                                           {
			//                                             klass = component[21].monitor;
			//                                             if ( klass )
			//                                             {
			//                                               klass[16] = 0;
			//                                               if ( component )
			//                                               {
			//                                                 v8 = component[22].klass;
			//                                                 if ( v8 )
			//                                                 {
			//                                                   LOBYTE(v8._0.name) = 0;
			//                                                   return;
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
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
			// LABEL_10:
			//     sub_180B536AC(klass, v6);
			//   }
			// }
			// 
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::VFXPPCharacterRimLight::Reset(VFXPPCharacterRimLight *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2036, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2036, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_RimMode = 1;
			//   }
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

		[Header("全局边缘光")]
		[SerializeField]
		private Color m_RimLightColor;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_RimAngle;

		[SerializeField]
		[Range(0f, 10f)]
		private float m_RimIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_RimWidth;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_RimAlbedo;

		[SerializeField]
		private bool m_RimMode;

		[Header("脸部额外边缘光")]
		[SerializeField]
		private bool m_EnableFaceRim;

		[SerializeField]
		private Color m_FaceRimLightColor;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_FaceRimAngle;

		[SerializeField]
		[Range(0f, 10f)]
		private float m_FaceRimIntensity;
	}
}
