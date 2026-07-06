using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPRadialBlur(径向模糊)")]
	[ExecuteInEditMode]
	public class VFXPPRadialBlur : VFXPPComponent
	{
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<Beyond::Gameplay::Core::AbilitySystem::Modifier,System::Object>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_2_Beyond_Gameplay_Core_AbilitySystem_Modifier_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 2;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPRadialBlur()
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

		public override VFXPPData GetDefaultData()
		{
			// // VFXPPData GetDefaultData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::GetDefaultData(VFXPPRadialBlur *this, MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919429 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     byte_18D919429 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2107, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     if ( result )
			//     {
			//       LODWORD(result[1].klass) = 0;
			//       LODWORD(result[1].monitor) = 0;
			//       BYTE4(result[1].klass) = this.fields._useAsCenterPosition;
			//       BYTE5(result[1].klass) = this.fields._averageSteps;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2107, 0LL);
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
			// VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::_GetLerpData(
			//         VFXPPRadialBlur *this,
			//         float value,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   __int64 v5; // rdi
			//   __int64 v6; // rdx
			//   Beyond::JobMathf *v7; // rcx
			//   double v8; // xmm0_8
			//   __int64 v9; // rax
			//   Beyond::JobMathf *v10; // rcx
			//   double v11; // xmm0_8
			//   __int64 v12; // rax
			//   __int64 v13; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91942A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     byte_18D91942A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2108, 0LL) )
			//   {
			//     v4 = sub_18003F5A0(this.fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     v5 = sub_18003F5A0(this.fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     v7 = (Beyond::JobMathf *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     if ( v7 && v4 && v5 )
			//     {
			//       v8 = Beyond::JobMathf::ClampedLerp(v7, *(float *)(v5 + 24), value);
			//       *(_DWORD *)(v9 + 24) = LODWORD(v8);
			//       v11 = Beyond::JobMathf::ClampedLerp(v10, *(float *)(v5 + 32), value);
			//       *(_DWORD *)(v12 + 32) = LODWORD(v11);
			//       *(_BYTE *)(v13 + 28) = *(_BYTE *)(v4 + 28);
			//       *(_BYTE *)(v13 + 29) = *(_BYTE *)(v4 + 29);
			//       *(_DWORD *)(v13 + 16) = *(_DWORD *)(v4 + 16);
			//       return (VFXPPData *)v13;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2108, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_774(Patch, (Object *)this, value, 0LL);
			// }
			// 
			return null;
		}

		public override void SetData(VFXPPData data)
		{
			// // Void SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPRadialBlur::SetData(VFXPPRadialBlur *this, VFXPPData *data, MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91942B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     byte_18D91942B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2109, 0LL) )
			//   {
			//     v5 = sub_18003F5A0(data, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     if ( v5 )
			//     {
			//       this.fields._intensity = *(float *)(v5 + 24);
			//       this.fields._useAsCenterPosition = *(_BYTE *)(v5 + 28);
			//       this.fields._averageSteps = *(_BYTE *)(v5 + 29);
			//       this.fields._power = *(float *)(v5 + 32);
			//       this.fields._.m_priority = *(_DWORD *)(v5 + 16);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2109, 0LL);
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
			// VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::GetData(VFXPPRadialBlur *this, MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91942C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     byte_18D91942C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2110, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
			//     if ( result )
			//     {
			//       *(float *)&result[1].klass = this.fields._intensity;
			//       BYTE4(result[1].klass) = this.fields._useAsCenterPosition;
			//       BYTE5(result[1].klass) = this.fields._averageSteps;
			//       *(float *)&result[1].monitor = this.fields._power;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2110, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPRadialBlur::Apply(
			//         VFXPPRadialBlur *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   _BYTE *monitor; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   Object__Class *v9; // rax
			//   Object__Class *v10; // rax
			//   Object__Class *v11; // rax
			//   Object__Class *v12; // rbx
			//   Transform *v13; // rax
			//   Vector3 *position; // rax
			//   __int64 v15; // xmm0_8
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // [rsp+20h] [rbp-20h] BYREF
			//   float v19; // [rsp+28h] [rbp-18h]
			//   Vector3 v20; // [rsp+30h] [rbp-10h] BYREF
			//   Object *component; // [rsp+68h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D91942D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGRadialBlur>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGRadialBlur>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>);
			//     byte_18D91942D = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2111, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2111, 0LL);
			//     if ( !Patch )
			//       goto LABEL_48;
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
			//       goto LABEL_48;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGRadialBlur>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGRadialBlur>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>) )
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
			//               monitor = component[3].klass;
			//               if ( monitor )
			//               {
			//                 sub_1800463A0(11LL, monitor);
			//                 if ( component )
			//                 {
			//                   v8 = component[4].klass;
			//                   if ( v8 )
			//                   {
			//                     LOBYTE(v8._0.name) = 1;
			//                     if ( component )
			//                     {
			//                       monitor = component[4].klass;
			//                       if ( monitor )
			//                       {
			//                         sub_180042C50(11LL, monitor);
			//                         if ( component )
			//                         {
			//                           v9 = component[5].klass;
			//                           if ( v9 )
			//                           {
			//                             LOBYTE(v9._0.name) = 1;
			//                             if ( component )
			//                             {
			//                               monitor = component[5].klass;
			//                               if ( monitor )
			//                               {
			//                                 sub_1800463A0(11LL, monitor);
			//                                 if ( this.fields._useAsCenterPosition )
			//                                 {
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   klass = component[5].monitor;
			//                                   if ( !klass )
			//                                     goto LABEL_48;
			//                                   klass[16] = 1;
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   monitor = component[5].monitor;
			//                                   if ( !monitor )
			//                                     goto LABEL_48;
			//                                   sub_1800463A0(11LL, monitor);
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   v11 = component[6].klass;
			//                                   if ( !v11 )
			//                                     goto LABEL_48;
			//                                   LOBYTE(v11._0.name) = 1;
			//                                 }
			//                                 else
			//                                 {
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   klass = component[3].monitor;
			//                                   if ( !klass )
			//                                     goto LABEL_48;
			//                                   klass[16] = 0;
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   klass = component[5].monitor;
			//                                   if ( !klass )
			//                                     goto LABEL_48;
			//                                   klass[16] = 0;
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   monitor = component[5].monitor;
			//                                   if ( !monitor )
			//                                     goto LABEL_48;
			//                                   sub_1800463A0(11LL, monitor);
			//                                   if ( !component )
			//                                     goto LABEL_48;
			//                                   v10 = component[6].klass;
			//                                   if ( !v10 )
			//                                     goto LABEL_48;
			//                                   LOBYTE(v10._0.name) = 0;
			//                                 }
			//                                 if ( component )
			//                                 {
			//                                   v12 = component[6].klass;
			//                                   v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//                                   if ( v13 )
			//                                   {
			//                                     position = UnityEngine::Transform::get_position(&v20, v13, 0LL);
			//                                     if ( v12 )
			//                                     {
			//                                       v15 = *(_QWORD *)&position.x;
			//                                       z = position.z;
			//                                       v18 = v15;
			//                                       v19 = z;
			//                                       sub_18003E1C0(11LL, v12, &v18);
			//                                       if ( component )
			//                                       {
			//                                         monitor = component[4].monitor;
			//                                         if ( monitor )
			//                                         {
			//                                           monitor[16] = 1;
			//                                           if ( component )
			//                                           {
			//                                             monitor = component[4].monitor;
			//                                             if ( monitor )
			//                                             {
			//                                               sub_180042C50(11LL, monitor);
			//                                               return;
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
			// LABEL_48:
			//       sub_180B536AC(klass, monitor);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPRadialBlur::ResetByVolumeProfile(
			//         VFXPPRadialBlur *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *v6; // rdx
			//   Object__Class *klass; // rcx
			//   Object__Class *v8; // rax
			//   MonitorData *monitor; // rax
			//   Object__Class *v10; // rax
			//   Object__Class *v11; // rax
			//   MonitorData *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v14; // [rsp+20h] [rbp-28h] BYREF
			//   int v15; // [rsp+28h] [rbp-20h]
			//   Object *component; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED99B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>);
			//     byte_18D8ED99B = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2112, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2112, 0LL);
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
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>) )
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
			//               v6 = component[3].klass;
			//               if ( v6 )
			//               {
			//                 sub_1800463A0(11LL, v6);
			//                 if ( component )
			//                 {
			//                   v8 = component[4].klass;
			//                   if ( v8 )
			//                   {
			//                     LOBYTE(v8._0.name) = 0;
			//                     if ( component )
			//                     {
			//                       v6 = component[4].klass;
			//                       if ( v6 )
			//                       {
			//                         sub_180042C50(11LL, v6);
			//                         if ( component )
			//                         {
			//                           monitor = component[5].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 0;
			//                             if ( component )
			//                             {
			//                               v6 = component[5].monitor;
			//                               if ( v6 )
			//                               {
			//                                 sub_1800463A0(11LL, v6);
			//                                 if ( component )
			//                                 {
			//                                   v10 = component[6].klass;
			//                                   if ( v10 )
			//                                   {
			//                                     LOBYTE(v10._0.name) = 0;
			//                                     if ( component )
			//                                     {
			//                                       v6 = component[6].klass;
			//                                       if ( v6 )
			//                                       {
			//                                         v15 = 0;
			//                                         v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                         sub_18003E1C0(11LL, v6, &v14);
			//                                         if ( component )
			//                                         {
			//                                           v11 = component[5].klass;
			//                                           if ( v11 )
			//                                           {
			//                                             LOBYTE(v11._0.name) = 0;
			//                                             if ( component )
			//                                             {
			//                                               v6 = component[5].klass;
			//                                               if ( v6 )
			//                                               {
			//                                                 sub_1800463A0(11LL, v6);
			//                                                 if ( component )
			//                                                 {
			//                                                   v12 = component[4].monitor;
			//                                                   if ( v12 )
			//                                                   {
			//                                                     *((_BYTE *)v12 + 16) = 0;
			//                                                     if ( component )
			//                                                     {
			//                                                       v6 = component[4].monitor;
			//                                                       if ( v6 )
			//                                                       {
			//                                                         sub_180042C50(11LL, v6);
			//                                                         return;
			//                                                       }
			//                                                     }
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
			//     }
			// LABEL_10:
			//     sub_180B536AC(klass, v6);
			//   }
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPRadialBlur::IsActive(VFXPPRadialBlur *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2113, 0LL) )
			//     return this.fields._intensity != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2113, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
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

		[SerializeField]
		[Range(1f, 2f)]
		private float _power;
	}
}
