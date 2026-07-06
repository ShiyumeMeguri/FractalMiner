using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPChromaticAberration(色散)")]
	[ExecuteInEditMode]
	public class VFXPPChromaticAberration : VFXPPComponent
	{
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Object GetBuiltinExtraResource[Object](String)
				// Object *HoudiniEngineUnity::HEU_AssetDatabase::GetBuiltinExtraResource<System::Object>(
				//         String *resourceName,
				//         MethodInfo *method)
				// {
				//   return 0LL;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPChromaticAberration()
		{
			// // VFXPPChromaticAberration()
			// void HG::Rendering::Runtime::VFXPPChromaticAberration::VFXPPChromaticAberration(
			//         VFXPPChromaticAberration *this,
			//         MethodInfo *method)
			// {
			//   this.fields._intensity = 0.1;
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public override void SetData(VFXPPData data)
		{
			// // Void SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPChromaticAberration::SetData(
			//         VFXPPChromaticAberration *this,
			//         VFXPPData *data,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919411 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     byte_18D919411 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2037, 0LL) )
			//   {
			//     v5 = sub_18003F5A0(data, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     if ( v5 )
			//     {
			//       this.fields._intensity = *(float *)(v5 + 24);
			//       this.fields._useAsCenterPosition = *(_BYTE *)(v5 + 28);
			//       this.fields._averageSteps = *(_BYTE *)(v5 + 29);
			//       this.fields._.m_priority = *(_DWORD *)(v5 + 16);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2037, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)data,
			//     0LL);
			// }
			// 
		}

		public override VFXPPData GetData()
		{
			// // VFXPPData GetData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::GetData(
			//         VFXPPChromaticAberration *this,
			//         MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919412 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     byte_18D919412 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2038, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     if ( result )
			//     {
			//       LODWORD(result[1].klass) = 1036831949;
			//       *(float *)&result[1].klass = this.fields._intensity;
			//       BYTE4(result[1].klass) = this.fields._useAsCenterPosition;
			//       BYTE5(result[1].klass) = this.fields._averageSteps;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2038, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public override VFXPPData GetDefaultData()
		{
			// // VFXPPData GetDefaultData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::GetDefaultData(
			//         VFXPPChromaticAberration *this,
			//         MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919413 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     byte_18D919413 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2039, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     if ( result )
			//     {
			//       LODWORD(result[1].klass) = 0;
			//       BYTE4(result[1].klass) = this.fields._useAsCenterPosition;
			//       BYTE5(result[1].klass) = this.fields._averageSteps;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2039, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		protected override VFXPPData _GetLerpData(float value)
		{
			// // VFXPPData _GetLerpData(Single)
			// VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::_GetLerpData(
			//         VFXPPChromaticAberration *this,
			//         float value,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   __int64 v5; // rdi
			//   Beyond::JobMathf *v6; // rax
			//   __int64 v7; // rdx
			//   Beyond::JobMathf *v8; // rcx
			//   double v9; // xmm0_8
			//   __int64 v10; // rax
			//   __int64 v11; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919414 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     byte_18D919414 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2040, 0LL) )
			//   {
			//     v4 = sub_18003F5A0(this.fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     v5 = sub_18003F5A0(this.fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     v6 = (Beyond::JobMathf *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
			//     v8 = v6;
			//     if ( v6 )
			//     {
			//       *((_DWORD *)v6 + 6) = 1036831949;
			//       if ( v4 )
			//       {
			//         if ( v5 )
			//         {
			//           v9 = Beyond::JobMathf::ClampedLerp(v6, *(float *)(v5 + 24), value);
			//           *(_DWORD *)(v10 + 24) = LODWORD(v9);
			//           *(_BYTE *)(v11 + 28) = *(_BYTE *)(v4 + 28);
			//           *(_BYTE *)(v11 + 29) = *(_BYTE *)(v4 + 29);
			//           *(_DWORD *)(v11 + 16) = *(_DWORD *)(v4 + 16);
			//           return (VFXPPData *)v11;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2040, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_774(Patch, (Object *)this, value, 0LL);
			// }
			// 
			return null;
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPChromaticAberration::Apply(
			//         VFXPPChromaticAberration *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   void *v6; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   MonitorData *monitor; // rax
			//   MonitorData *v10; // rax
			//   MonitorData *v11; // rbx
			//   Transform *v12; // rax
			//   Vector3 *position; // rax
			//   __int64 v14; // xmm0_8
			//   float z; // eax
			//   MonitorData *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // [rsp+20h] [rbp-20h] BYREF
			//   float v19; // [rsp+28h] [rbp-18h]
			//   Vector3 v20; // [rsp+30h] [rbp-10h] BYREF
			//   Object *component; // [rsp+68h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D919415 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGChromaticAbberation>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGChromaticAbberation>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>);
			//     byte_18D919415 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2041, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2041, 0LL);
			//     if ( !Patch )
			//       goto LABEL_46;
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
			//       goto LABEL_46;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGChromaticAbberation>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGChromaticAbberation>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           klass = component[3].klass;
			//           if ( klass )
			//           {
			//             klass[16] = 1;
			//             if ( component )
			//             {
			//               v6 = component[3].klass;
			//               if ( v6 )
			//               {
			//                 sub_1800463A0(11LL, v6);
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
			//                         sub_180042C50(11LL, v6);
			//                         if ( component )
			//                         {
			//                           monitor = component[4].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 1;
			//                             if ( component )
			//                             {
			//                               v6 = component[4].monitor;
			//                               if ( v6 )
			//                               {
			//                                 sub_1800463A0(11LL, v6);
			//                                 if ( this.fields._useAsCenterPosition )
			//                                 {
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   klass = component[5].klass;
			//                                   if ( !klass )
			//                                     goto LABEL_46;
			//                                   klass[16] = 1;
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   v6 = component[5].klass;
			//                                   if ( !v6 )
			//                                     goto LABEL_46;
			//                                   sub_1800463A0(11LL, v6);
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   v16 = component[5].monitor;
			//                                   if ( !v16 )
			//                                     goto LABEL_46;
			//                                   *((_BYTE *)v16 + 16) = 1;
			//                                 }
			//                                 else
			//                                 {
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   klass = component[3].monitor;
			//                                   if ( !klass )
			//                                     goto LABEL_46;
			//                                   klass[16] = 0;
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   klass = component[3].monitor;
			//                                   if ( !klass )
			//                                     goto LABEL_46;
			//                                   klass[16] = 0;
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   klass = component[5].klass;
			//                                   if ( !klass )
			//                                     goto LABEL_46;
			//                                   klass[16] = 0;
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   v6 = component[5].klass;
			//                                   if ( !v6 )
			//                                     goto LABEL_46;
			//                                   sub_1800463A0(11LL, v6);
			//                                   if ( !component )
			//                                     goto LABEL_46;
			//                                   v10 = component[5].monitor;
			//                                   if ( !v10 )
			//                                     goto LABEL_46;
			//                                   *((_BYTE *)v10 + 16) = 0;
			//                                 }
			//                                 if ( component )
			//                                 {
			//                                   v11 = component[5].monitor;
			//                                   v12 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//                                   if ( v12 )
			//                                   {
			//                                     position = UnityEngine::Transform::get_position(&v20, v12, 0LL);
			//                                     if ( v11 )
			//                                     {
			//                                       v14 = *(_QWORD *)&position.x;
			//                                       z = position.z;
			//                                       v18 = v14;
			//                                       v19 = z;
			//                                       sub_18003E1C0(11LL, v11, &v18);
			//                                       return;
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
			// LABEL_46:
			//       sub_180B536AC(klass, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPChromaticAberration::ResetByVolumeProfile(
			//         VFXPPChromaticAberration *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *monitor; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   MonitorData *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v11; // [rsp+20h] [rbp-28h] BYREF
			//   int v12; // [rsp+28h] [rbp-20h]
			//   Object *component; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED988 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>);
			//     byte_18D8ED988 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2042, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2042, 0LL);
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
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>) )
			//         return;
			//       if ( component )
			//       {
			//         klass = component[3].klass;
			//         if ( klass )
			//         {
			//           klass[16] = 0;
			//           if ( component )
			//           {
			//             monitor = component[3].klass;
			//             if ( monitor )
			//             {
			//               sub_1800463A0(11LL, monitor);
			//               monitor = component;
			//               if ( component )
			//               {
			//                 monitor = component[4].klass;
			//                 if ( monitor )
			//                 {
			//                   sub_180042C50(11LL, monitor);
			//                   if ( component )
			//                   {
			//                     LOBYTE(component[1].monitor) = 0;
			//                     if ( component )
			//                     {
			//                       klass = component[4].monitor;
			//                       if ( klass )
			//                       {
			//                         klass[16] = 0;
			//                         if ( component )
			//                         {
			//                           monitor = component[4].monitor;
			//                           if ( monitor )
			//                           {
			//                             sub_1800463A0(11LL, monitor);
			//                             if ( component )
			//                             {
			//                               v8 = component[5].klass;
			//                               if ( v8 )
			//                               {
			//                                 LOBYTE(v8._0.name) = 0;
			//                                 if ( component )
			//                                 {
			//                                   monitor = component[5].klass;
			//                                   if ( monitor )
			//                                   {
			//                                     sub_1800463A0(11LL, monitor);
			//                                     if ( component )
			//                                     {
			//                                       v9 = component[5].monitor;
			//                                       if ( v9 )
			//                                       {
			//                                         *((_BYTE *)v9 + 16) = 0;
			//                                         if ( component )
			//                                         {
			//                                           monitor = component[5].monitor;
			//                                           if ( monitor )
			//                                           {
			//                                             v12 = 0;
			//                                             v11 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                             sub_18003E1C0(11LL, monitor, &v11);
			//                                             return;
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
			//     sub_180B536AC(klass, monitor);
			//   }
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPChromaticAberration::IsActive(VFXPPChromaticAberration *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2043, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2043, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_SetData(VFXPPData P0)
		{
			// // Void <>iFixBaseProxy_SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_SetData(
			//         VFXPPVignette *this,
			//         VFXPPData *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::SetData((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public VFXPPData <>iFixBaseProxy_GetData()
		{
			// // VFXPPData <>iFixBaseProxy_GetData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetData(VFXPPVignette *this, MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::GetData((VFXPPComponent *)this, 0LL);
			// }
			// 
			return null;
		}

		public VFXPPData <>iFixBaseProxy_GetDefaultData()
		{
			// // VFXPPData <>iFixBaseProxy_GetDefaultData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetDefaultData(
			//         VFXPPVignette *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::GetDefaultData((VFXPPComponent *)this, 0LL);
			// }
			// 
			return null;
		}

		public VFXPPData <>iFixBaseProxy__GetLerpData(float P0)
		{
			// // VFXPPData <>iFixBaseProxy__GetLerpData(Single)
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy__GetLerpData(
			//         VFXPPVignette *this,
			//         float P0,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::_GetLerpData((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
			return null;
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
		[Range(0f, 0.3f)]
		private float _intensity;

		[SerializeField]
		private bool _useAsCenterPosition;

		[SerializeField]
		private bool _averageSteps;
	}
}
