using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPVignette(特效暗角)")]
	[ExecuteInEditMode]
	public class VFXPPVignette : VFXPPComponent
	{
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<System::Object>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_1_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 1;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPVignette()
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

		public override void SetData(VFXPPData data)
		{
			// // Void SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPVignette::SetData(VFXPPVignette *this, VFXPPData *data, MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91943A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     byte_18D91943A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2138, 0LL) )
			//   {
			//     v5 = sub_18003F5A0(data, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     if ( v5 )
			//     {
			//       this.fields._intensity = *(float *)(v5 + 40);
			//       this.fields._color = (Color)_mm_loadu_si128((const __m128i *)(v5 + 24));
			//       this.fields._smoothness = *(float *)(v5 + 44);
			//       this.fields._rounded = *(_BYTE *)(v5 + 48);
			//       this.fields._blink = *(_BYTE *)(v5 + 49);
			//       this.fields._.m_priority = *(_DWORD *)(v5 + 16);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2138, 0LL);
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
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::GetData(VFXPPVignette *this, MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91943B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     byte_18D91943B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2139, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     if ( result )
			//     {
			//       result[1].fields.priority = LODWORD(this.fields._intensity);
			//       *(__m128i *)&result[1].klass = _mm_loadu_si128((const __m128i *)&this.fields._color);
			//       *(&result[1].fields.priority + 1) = LODWORD(this.fields._smoothness);
			//       LOBYTE(result[2].klass) = this.fields._rounded;
			//       BYTE1(result[2].klass) = this.fields._blink;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2139, 0LL);
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
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::GetDefaultData(VFXPPVignette *this, MethodInfo *method)
			// {
			//   VFXPPData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91943C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     byte_18D91943C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2140, 0LL) )
			//   {
			//     result = (VFXPPData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     if ( result )
			//     {
			//       result[1].fields.priority = 0;
			//       *(__m128i *)&result[1].klass = _mm_loadu_si128((const __m128i *)&this.fields._color);
			//       *(&result[1].fields.priority + 1) = LODWORD(this.fields._smoothness);
			//       LOBYTE(result[2].klass) = this.fields._rounded;
			//       BYTE1(result[2].klass) = this.fields._blink;
			//       result.fields.priority = this.fields._.m_priority;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2140, 0LL);
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
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::_GetLerpData(VFXPPVignette *this, float value, MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   __int64 v5; // rbx
			//   __int64 v6; // rdx
			//   Beyond::JobMathf *v7; // rcx
			//   double v8; // xmm0_8
			//   __int64 v9; // rax
			//   __int128 v10; // xmm0
			//   const __m128i *v11; // rax
			//   __int64 v12; // r9
			//   Beyond::JobMathf *v13; // rcx
			//   __int64 v14; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v17; // [rsp+30h] [rbp-48h] BYREF
			//   __int128 v18; // [rsp+40h] [rbp-38h] BYREF
			//   _BYTE v19[16]; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91943D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     byte_18D91943D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2141, 0LL) )
			//   {
			//     v4 = sub_18003F5A0(this.fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     v5 = sub_18003F5A0(this.fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
			//     if ( sub_180004920(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData) && v4 && v5 )
			//     {
			//       v8 = Beyond::JobMathf::ClampedLerp(v7, *(float *)(v5 + 40), value);
			//       *(_DWORD *)(v9 + 40) = LODWORD(v8);
			//       v10 = *(_OWORD *)(v4 + 24);
			//       v17 = *(_OWORD *)(v5 + 24);
			//       v18 = v10;
			//       v11 = (const __m128i *)sub_18317A160(v19, &v18, &v17);
			//       *(__m128i *)(v12 + 24) = _mm_loadu_si128(v11);
			//       *(double *)&v10 = Beyond::JobMathf::ClampedLerp(v13, *(float *)(v5 + 44), value);
			//       *(_DWORD *)(v14 + 44) = v10;
			//       *(_BYTE *)(v14 + 48) = *(_BYTE *)(v5 + 48);
			//       *(_BYTE *)(v14 + 49) = *(_BYTE *)(v5 + 49);
			//       *(_DWORD *)(v14 + 16) = *(_DWORD *)(v5 + 16);
			//       return (VFXPPData *)v14;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2141, 0LL);
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
			// void HG::Rendering::Runtime::VFXPPVignette::Apply(
			//         VFXPPVignette *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   _QWORD **monitor; // rcx
			//   int *v6; // rdx
			//   __int64 (__fastcall *v7)(VFXPPVignette *, int *, MethodInfo *); // rax
			//   __int64 v8; // rbx
			//   __int64 v9; // rdx
			//   struct MethodInfo *v10; // rsi
			//   RuntimeTypeHandle v11; // rbx
			//   Type *TypeFromHandle; // rbx
			//   Il2CppRGCTXData v13; // rdx
			//   Object__Class *klass; // rax
			//   Object__Class *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rax
			//   Color color; // [rsp+20h] [rbp-18h] BYREF
			//   Object *component; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED9A5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGVignette>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGVignette>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>);
			//     byte_18D8ED9A5 = 1;
			//   }
			//   component = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, volumeProfile);
			//     monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (int *)*monitor[23];
			//   if ( !v6 )
			//     goto LABEL_54;
			//   if ( v6[6] > 2142 )
			//   {
			//     if ( !*((_DWORD *)monitor + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(monitor, v6);
			//       monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     monitor = (_QWORD **)*monitor[23];
			//     if ( !monitor )
			//       goto LABEL_54;
			//     if ( *((_DWORD *)monitor + 6) <= 0x85Eu )
			//       sub_180070270(monitor, v6);
			//     if ( monitor[2146] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(2142, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//           (ILFixDynamicMethodWrapper_37 *)Patch,
			//           (Object *)this,
			//           (Object *)volumeProfile,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_54;
			//     }
			//   }
			//   v7 = (__int64 (__fastcall *)(VFXPPVignette *, int *, MethodInfo *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v7 = (__int64 (__fastcall *)(VFXPPVignette *, int *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v7 )
			//     {
			//       v19 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v19, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v7;
			//   }
			//   v8 = v7(this, v6, method);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v8 )
			//   {
			//     monitor = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//     if ( *(_QWORD *)(v8 + 16) )
			//     {
			//       if ( !volumeProfile )
			//         goto LABEL_54;
			//       if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//               volumeProfile,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGVignette>) )
			//         UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//           volumeProfile,
			//           0,
			//           MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGVignette>);
			//       v10 = MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>;
			//       if ( !MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>.rgctx_data )
			//       {
			//         sub_18003C530(&TypeInfo::System::Type);
			//         if ( !v10.rgctx_data )
			//           sub_180041F40(v10);
			//       }
			//       v11.value = v10.rgctx_data.rgctxDataDummy;
			//       if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::System::Type, v9);
			//       TypeFromHandle = System::Type::GetTypeFromHandle(v11, 0LL);
			//       v13.rgctxDataDummy = v10.rgctx_data[1].rgctxDataDummy;
			//       if ( !*((_QWORD *)v13.rgctxDataDummy + 4) )
			//         (*(void (**)(void))v13.rgctxDataDummy)();
			//       if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//              volumeProfile,
			//              TypeFromHandle,
			//              &component,
			//              (MethodInfo *)v10.rgctx_data[1].rgctxDataDummy) )
			//       {
			//         if ( component )
			//         {
			//           LOBYTE(component[1].monitor) = 1;
			//           if ( component )
			//           {
			//             monitor = (_QWORD **)component[3].monitor;
			//             if ( monitor )
			//             {
			//               *((_BYTE *)monitor + 16) = 1;
			//               if ( component )
			//               {
			//                 v6 = (int *)component[3].monitor;
			//                 if ( v6 )
			//                 {
			//                   sub_180042C50(11LL, v6);
			//                   if ( component )
			//                   {
			//                     klass = component[3].klass;
			//                     if ( klass )
			//                     {
			//                       LOBYTE(klass._0.name) = 1;
			//                       if ( component )
			//                       {
			//                         v6 = (int *)component[3].klass;
			//                         if ( v6 )
			//                         {
			//                           color = this.fields._color;
			//                           sub_18004EA90(11LL, v6, &color);
			//                           if ( component )
			//                           {
			//                             v15 = component[4].klass;
			//                             if ( v15 )
			//                             {
			//                               LOBYTE(v15._0.name) = 1;
			//                               if ( component )
			//                               {
			//                                 v6 = (int *)component[4].klass;
			//                                 if ( v6 )
			//                                 {
			//                                   sub_180042C50(11LL, v6);
			//                                   if ( component )
			//                                   {
			//                                     v16 = component[4].monitor;
			//                                     if ( v16 )
			//                                     {
			//                                       *((_BYTE *)v16 + 16) = 1;
			//                                       if ( component )
			//                                       {
			//                                         v6 = (int *)component[4].monitor;
			//                                         if ( v6 )
			//                                         {
			//                                           sub_1800463A0(11LL, v6);
			//                                           if ( component )
			//                                           {
			//                                             v17 = component[5].klass;
			//                                             if ( v17 )
			//                                             {
			//                                               LOBYTE(v17._0.name) = 1;
			//                                               if ( component )
			//                                               {
			//                                                 v6 = (int *)component[5].klass;
			//                                                 if ( v6 )
			//                                                 {
			//                                                   sub_1800463A0(11LL, v6);
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
			// LABEL_54:
			//         sub_180B536AC(monitor, v6);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::ResetByVolumeProfile(
			//         VFXPPVignette *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *v6; // rdx
			//   MonitorData *monitor; // rcx
			//   Object__Class *klass; // rax
			//   Quaternion *identity; // rax
			//   Object__Class *v10; // rax
			//   MonitorData *v11; // rax
			//   Object__Class *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Quaternion v14; // [rsp+20h] [rbp-18h] BYREF
			//   Object *component; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED9A6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>);
			//     byte_18D8ED9A6 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2143, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2143, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)volumeProfile,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_32;
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
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>) )
			//         return;
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 0;
			//         if ( component )
			//         {
			//           monitor = component[3].monitor;
			//           if ( monitor )
			//           {
			//             *((_BYTE *)monitor + 16) = 0;
			//             if ( component )
			//             {
			//               v6 = component[3].monitor;
			//               if ( v6 )
			//               {
			//                 sub_180042C50(11LL, v6);
			//                 if ( component )
			//                 {
			//                   klass = component[3].klass;
			//                   if ( klass )
			//                   {
			//                     LOBYTE(klass._0.name) = 0;
			//                     if ( component )
			//                     {
			//                       identity = UnityEngine::Quaternion::get_identity(&v14, (MethodInfo *)component[3].klass);
			//                       if ( v6 )
			//                       {
			//                         v14 = *identity;
			//                         sub_18004EA90(11LL, v6, &v14);
			//                         if ( component )
			//                         {
			//                           v10 = component[4].klass;
			//                           if ( v10 )
			//                           {
			//                             LOBYTE(v10._0.name) = 0;
			//                             if ( component )
			//                             {
			//                               v6 = component[4].klass;
			//                               if ( v6 )
			//                               {
			//                                 sub_180042C50(11LL, v6);
			//                                 if ( component )
			//                                 {
			//                                   v11 = component[4].monitor;
			//                                   if ( v11 )
			//                                   {
			//                                     *((_BYTE *)v11 + 16) = 0;
			//                                     if ( component )
			//                                     {
			//                                       v6 = component[4].monitor;
			//                                       if ( v6 )
			//                                       {
			//                                         sub_1800463A0(11LL, v6);
			//                                         if ( component )
			//                                         {
			//                                           v12 = component[5].klass;
			//                                           if ( v12 )
			//                                           {
			//                                             LOBYTE(v12._0.name) = 0;
			//                                             if ( component )
			//                                             {
			//                                               v6 = component[5].klass;
			//                                               if ( v6 )
			//                                               {
			//                                                 sub_1800463A0(11LL, v6);
			//                                                 return;
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
			// LABEL_32:
			//     sub_180B536AC(monitor, v6);
			//   }
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPVignette::IsActive(VFXPPVignette *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 2144 )
			//     return this.fields._intensity != 0.0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x860 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[45]._1.static_fields_size )
			//     return this.fields._intensity != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2144, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
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
		private Color _color;

		[SerializeField]
		[Range(0f, 1f)]
		private float _intensity;

		[Range(0f, 1f)]
		[SerializeField]
		private float _smoothness;

		[SerializeField]
		private bool _rounded;

		[SerializeField]
		private bool _blink;
	}
}
