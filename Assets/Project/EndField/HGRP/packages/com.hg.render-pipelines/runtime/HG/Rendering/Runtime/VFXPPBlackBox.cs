using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPBlackBox(黑盒特效)")]
	[ExecuteInEditMode]
	public class VFXPPBlackBox : VFXPPComponent
	{
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // LoginWorkFlow+ENode get_type()
				// LoginWorkFlow_ENode__Enum Beyond::Login::FinishNode::get_type(FinishNode_1 *this, MethodInfo *method)
				// {
				//   return 13;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPBlackBox()
		{
			// // VFXPPBlackBox()
			// void HG::Rendering::Runtime::VFXPPBlackBox::VFXPPBlackBox(VFXPPBlackBox *this, MethodInfo *method)
			// {
			//   this.fields._useDisturb = 1;
			//   this.fields._contourTexTiling.x = 20.0;
			//   this.fields._blendRadius = 500.0;
			//   this.fields._contourRangeRadius = 500.0;
			//   *(_QWORD *)&this.fields._contourTexTiling.y = 1101004800LL;
			//   this.fields._disturbTexTiling.x = 20.0;
			//   *(_QWORD *)&this.fields._disturbTexTiling.y = 1101004800LL;
			//   this.fields._maskTexTiling.x = 20.0;
			//   *(_QWORD *)&this.fields._maskTexTiling.y = 1101004800LL;
			//   this.fields._contourTexUVSpeed.y = 0.0;
			//   this.fields._disturbIntensity = 0LL;
			//   this.fields._disturbTexUVSpeed.y = 0.0;
			//   this.fields._maskTexUVSpeed.y = 0.0;
			//   *(_WORD *)&this.fields._useMask = 257;
			//   HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette((VFXPPVignette *)this, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPBlackBox::Apply(
			//         VFXPPBlackBox *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   void *v6; // rdx
			//   Object__Class *klass; // rcx
			//   MonitorData *monitor; // rax
			//   Object__Class *v9; // rax
			//   Object__Class *v10; // rbx
			//   Transform *v11; // rax
			//   Vector3 *position; // rax
			//   __int64 v13; // xmm0_8
			//   MethodInfo *v14; // r8
			//   Vector4 *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   MonitorData *v18; // rax
			//   Object__Class *v19; // rax
			//   MonitorData *v20; // rax
			//   Object__Class *v21; // rax
			//   MonitorData *v22; // rax
			//   Object__Class *v23; // rax
			//   MonitorData *v24; // rax
			//   Object__Class *v25; // rax
			//   MonitorData *v26; // rax
			//   Object__Class *v27; // rax
			//   Object__Class *v28; // rax
			//   MonitorData *v29; // rax
			//   MonitorData *v30; // rax
			//   Object__Class *v31; // rax
			//   MonitorData *v32; // rax
			//   Object__Class *v33; // rax
			//   MonitorData *v34; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v36; // [rsp+20h] [rbp-20h] BYREF
			//   Color blendColor; // [rsp+30h] [rbp-10h] BYREF
			//   Object *component; // [rsp+68h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D919407 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBlackBox>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBlackBox>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>);
			//     byte_18D919407 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2019, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2019, 0LL);
			//     if ( !Patch )
			//       goto LABEL_101;
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
			//       goto LABEL_101;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBlackBox>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBlackBox>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>) )
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
			//                         sub_1800463A0(11LL, v6);
			//                         if ( component )
			//                         {
			//                           v9 = component[4].klass;
			//                           if ( v9 )
			//                           {
			//                             LOBYTE(v9._0.name) = 1;
			//                             if ( component )
			//                             {
			//                               v10 = component[4].klass;
			//                               v11 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//                               if ( v11 )
			//                               {
			//                                 position = UnityEngine::Transform::get_position((Vector3 *)&blendColor, v11, 0LL);
			//                                 v13 = *(_QWORD *)&position.x;
			//                                 *(float *)&position = position.z;
			//                                 *(_QWORD *)&v36.x = v13;
			//                                 LODWORD(v36.z) = (_DWORD)position;
			//                                 v15 = UnityEngine::Vector4::op_Implicit((Vector4 *)&blendColor, &v36, v14);
			//                                 if ( v10 )
			//                                 {
			//                                   blendColor = (Color)*v15;
			//                                   sub_18048EDCC(11LL, v10, &blendColor);
			//                                   if ( component )
			//                                   {
			//                                     v16 = component[4].monitor;
			//                                     if ( v16 )
			//                                     {
			//                                       *((_BYTE *)v16 + 16) = 1;
			//                                       if ( component )
			//                                       {
			//                                         v6 = component[4].monitor;
			//                                         if ( v6 )
			//                                         {
			//                                           blendColor = this.fields._blendColor;
			//                                           sub_18004EA90(11LL, v6, &blendColor);
			//                                           if ( component )
			//                                           {
			//                                             v17 = component[5].klass;
			//                                             if ( v17 )
			//                                             {
			//                                               LOBYTE(v17._0.name) = 1;
			//                                               if ( component )
			//                                               {
			//                                                 v6 = component[5].klass;
			//                                                 if ( v6 )
			//                                                 {
			//                                                   sub_180042C50(11LL, v6);
			//                                                   if ( component )
			//                                                   {
			//                                                     v18 = component[5].monitor;
			//                                                     if ( v18 )
			//                                                     {
			//                                                       *((_BYTE *)v18 + 16) = 1;
			//                                                       if ( component )
			//                                                       {
			//                                                         v6 = component[5].monitor;
			//                                                         if ( v6 )
			//                                                         {
			//                                                           sub_180042C50(11LL, v6);
			//                                                           if ( component )
			//                                                           {
			//                                                             v19 = component[6].klass;
			//                                                             if ( v19 )
			//                                                             {
			//                                                               LOBYTE(v19._0.name) = 1;
			//                                                               if ( component )
			//                                                               {
			//                                                                 v6 = component[6].klass;
			//                                                                 if ( v6 )
			//                                                                 {
			//                                                                   sub_180042C50(11LL, v6);
			//                                                                   if ( component )
			//                                                                   {
			//                                                                     v20 = component[6].monitor;
			//                                                                     if ( v20 )
			//                                                                     {
			//                                                                       *((_BYTE *)v20 + 16) = 1;
			//                                                                       if ( component )
			//                                                                       {
			//                                                                         v6 = component[6].monitor;
			//                                                                         if ( v6 )
			//                                                                         {
			//                                                                           blendColor = this.fields._contourColor;
			//                                                                           sub_18004EA90(11LL, v6, &blendColor);
			//                                                                           if ( component )
			//                                                                           {
			//                                                                             v21 = component[7].klass;
			//                                                                             if ( v21 )
			//                                                                             {
			//                                                                               LOBYTE(v21._0.name) = 1;
			//                                                                               if ( component )
			//                                                                               {
			//                                                                                 v6 = component[7].klass;
			//                                                                                 if ( v6 )
			//                                                                                 {
			//                                                                                   sub_180042C50(11LL, v6);
			//                                                                                   if ( component )
			//                                                                                   {
			//                                                                                     v22 = component[7].monitor;
			//                                                                                     if ( v22 )
			//                                                                                     {
			//                                                                                       *((_BYTE *)v22 + 16) = 1;
			//                                                                                       if ( component )
			//                                                                                       {
			//                                                                                         v6 = component[7].monitor;
			//                                                                                         if ( v6 )
			//                                                                                         {
			//                                                                                           sub_180042C50(11LL, v6);
			//                                                                                           if ( component )
			//                                                                                           {
			//                                                                                             v23 = component[8].klass;
			//                                                                                             if ( v23 )
			//                                                                                             {
			//                                                                                               LOBYTE(v23._0.name) = 1;
			//                                                                                               if ( component )
			//                                                                                               {
			//                                                                                                 v6 = component[8].klass;
			//                                                                                                 if ( v6 )
			//                                                                                                 {
			//                                                                                                   sub_180042C50(
			//                                                                                                     11LL,
			//                                                                                                     v6);
			//                                                                                                   if ( component )
			//                                                                                                   {
			//                                                                                                     v24 = component[8].monitor;
			//                                                                                                     if ( v24 )
			//                                                                                                     {
			//                                                                                                       *((_BYTE *)v24 + 16) = 1;
			//                                                                                                       if ( component )
			//                                                                                                       {
			//                                                                                                         v6 = component[8].monitor;
			//                                                                                                         if ( v6 )
			//                                                                                                         {
			//                                                                                                           sub_180086B00(klass, v6, this.fields._contourTexture);
			//                                                                                                           if ( component )
			//                                                                                                           {
			//                                                                                                             v25 = component[9].klass;
			//                                                                                                             if ( v25 )
			//                                                                                                             {
			//                                                                                                               LOBYTE(v25._0.name) = 1;
			//                                                                                                               if ( component )
			//                                                                                                               {
			//                                                                                                                 v6 = component[9].klass;
			//                                                                                                                 if ( v6 )
			//                                                                                                                 {
			//                                                                                                                   sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._contourTexTiling.x), (__m128)LODWORD(this.fields._contourTexTiling.y)).m128_u64[0]);
			//                                                                                                                   if ( component )
			//                                                                                                                   {
			//                                                                                                                     v26 = component[9].monitor;
			//                                                                                                                     if ( v26 )
			//                                                                                                                     {
			//                                                                                                                       *((_BYTE *)v26 + 16) = 1;
			//                                                                                                                       if ( component )
			//                                                                                                                       {
			//                                                                                                                         v6 = component[9].monitor;
			//                                                                                                                         if ( v6 )
			//                                                                                                                         {
			//                                                                                                                           sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._contourTexUVSpeed.x), (__m128)LODWORD(this.fields._contourTexUVSpeed.y)).m128_u64[0]);
			//                                                                                                                           if ( component )
			//                                                                                                                           {
			//                                                                                                                             v27 = component[11].klass;
			//                                                                                                                             if ( v27 )
			//                                                                                                                             {
			//                                                                                                                               LOBYTE(v27._0.name) = 1;
			//                                                                                                                               if ( component )
			//                                                                                                                               {
			//                                                                                                                                 v6 = component[11].klass;
			//                                                                                                                                 if ( v6 )
			//                                                                                                                                 {
			//                                                                                                                                   sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._disturbIntensity.x), (__m128)LODWORD(this.fields._disturbIntensity.y)).m128_u64[0]);
			//                                                                                                                                   if ( component )
			//                                                                                                                                   {
			//                                                                                                                                     v28 = component[10].klass;
			//                                                                                                                                     if ( v28 )
			//                                                                                                                                     {
			//                                                                                                                                       LOBYTE(v28._0.name) = 1;
			//                                                                                                                                       if ( component )
			//                                                                                                                                       {
			//                                                                                                                                         v6 = component[10].klass;
			//                                                                                                                                         if ( v6 )
			//                                                                                                                                         {
			//                                                                                                                                           sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._disturbTexTiling.x), (__m128)LODWORD(this.fields._disturbTexTiling.y)).m128_u64[0]);
			//                                                                                                                                           if ( component )
			//                                                                                                                                           {
			//                                                                                                                                             v29 = component[10].monitor;
			//                                                                                                                                             if ( v29 )
			//                                                                                                                                             {
			//                                                                                                                                               *((_BYTE *)v29 + 16) = 1;
			//                                                                                                                                               if ( component )
			//                                                                                                                                               {
			//                                                                                                                                                 v6 = component[10].monitor;
			//                                                                                                                                                 if ( v6 )
			//                                                                                                                                                 {
			//                                                                                                                                                   sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._disturbTexUVSpeed.x), (__m128)LODWORD(this.fields._disturbTexUVSpeed.y)).m128_u64[0]);
			//                                                                                                                                                   if ( component )
			//                                                                                                                                                   {
			//                                                                                                                                                     v30 = component[11].monitor;
			//                                                                                                                                                     if ( v30 )
			//                                                                                                                                                     {
			//                                                                                                                                                       *((_BYTE *)v30 + 16) = 1;
			//                                                                                                                                                       if ( component )
			//                                                                                                                                                       {
			//                                                                                                                                                         v6 = component[11].monitor;
			//                                                                                                                                                         if ( v6 )
			//                                                                                                                                                         {
			//                                                                                                                                                           sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._maskTexTiling.x), (__m128)LODWORD(this.fields._maskTexTiling.y)).m128_u64[0]);
			//                                                                                                                                                           if ( component )
			//                                                                                                                                                           {
			//                                                                                                                                                             v31 = component[12].klass;
			//                                                                                                                                                             if ( v31 )
			//                                                                                                                                                             {
			//                                                                                                                                                               LOBYTE(v31._0.name) = 1;
			//                                                                                                                                                               if ( component )
			//                                                                                                                                                               {
			//                                                                                                                                                                 v6 = component[12].klass;
			//                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                 {
			//                                                                                                                                                                   sub_18005D940(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this.fields._maskTexUVSpeed.x), (__m128)LODWORD(this.fields._maskTexUVSpeed.y)).m128_u64[0]);
			//                                                                                                                                                                   if ( component )
			//                                                                                                                                                                   {
			//                                                                                                                                                                     v32 = component[12].monitor;
			//                                                                                                                                                                     if ( v32 )
			//                                                                                                                                                                     {
			//                                                                                                                                                                       *((_BYTE *)v32 + 16) = 1;
			//                                                                                                                                                                       if ( component )
			//                                                                                                                                                                       {
			//                                                                                                                                                                         v6 = component[12].monitor;
			//                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                         {
			//                                                                                                                                                                           sub_1800463A0(11LL, v6);
			//                                                                                                                                                                           if ( component )
			//                                                                                                                                                                           {
			//                                                                                                                                                                             v33 = component[13].klass;
			//                                                                                                                                                                             if ( v33 )
			//                                                                                                                                                                             {
			//                                                                                                                                                                               LOBYTE(v33._0.name) = 1;
			//                                                                                                                                                                               if ( component )
			//                                                                                                                                                                               {
			//                                                                                                                                                                                 v6 = component[13].klass;
			//                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                 {
			//                                                                                                                                                                                   sub_1800463A0(11LL, v6);
			//                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                   {
			//                                                                                                                                                                                     v34 = component[13].monitor;
			//                                                                                                                                                                                     if ( v34 )
			//                                                                                                                                                                                     {
			//                                                                                                                                                                                       *((_BYTE *)v34 + 16) = 1;
			//                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                       {
			//                                                                                                                                                                                         v6 = component[13].monitor;
			//                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                         {
			//                                                                                                                                                                                           sub_1800463A0(11LL, v6);
			//                                                                                                                                                                                           return;
			//                                                                                                                                                                                         }
			//                                                                                                                                                                                       }
			//                                                                                                                                                                                     }
			//                                                                                                                                                                                   }
			//                                                                                                                                                                                 }
			//                                                                                                                                                                               }
			//                                                                                                                                                                             }
			//                                                                                                                                                                           }
			//                                                                                                                                                                         }
			//                                                                                                                                                                       }
			//                                                                                                                                                                     }
			//                                                                                                                                                                   }
			//                                                                                                                                                                 }
			//                                                                                                                                                               }
			//                                                                                                                                                             }
			//                                                                                                                                                           }
			//                                                                                                                                                         }
			//                                                                                                                                                       }
			//                                                                                                                                                     }
			//                                                                                                                                                   }
			//                                                                                                                                                 }
			//                                                                                                                                               }
			//                                                                                                                                             }
			//                                                                                                                                           }
			//                                                                                                                                         }
			//                                                                                                                                       }
			//                                                                                                                                     }
			//                                                                                                                                   }
			//                                                                                                                                 }
			//                                                                                                                               }
			//                                                                                                                             }
			//                                                                                                                           }
			//                                                                                                                         }
			//                                                                                                                       }
			//                                                                                                                     }
			//                                                                                                                   }
			//                                                                                                                 }
			//                                                                                                               }
			//                                                                                                             }
			//                                                                                                           }
			//                                                                                                         }
			//                                                                                                       }
			//                                                                                                     }
			//                                                                                                   }
			//                                                                                                 }
			//                                                                                               }
			//                                                                                             }
			//                                                                                           }
			//                                                                                         }
			//                                                                                       }
			//                                                                                     }
			//                                                                                   }
			//                                                                                 }
			//                                                                               }
			//                                                                             }
			//                                                                           }
			//                                                                         }
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
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
			// LABEL_101:
			//       sub_180B536AC(klass, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPBlackBox::ResetByVolumeProfile(
			//         VFXPPBlackBox *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   void *v5; // rdx
			//   Object__Class *klass; // rcx
			//   MonitorData *monitor; // rax
			//   Vector3Int *v8; // r8
			//   ITilemap *v9; // r9
			//   Object__Class *v10; // rax
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   MonitorData *v12; // rax
			//   Quaternion *identity; // rax
			//   Object__Class *v14; // rax
			//   MonitorData *v15; // rax
			//   Object__Class *v16; // rax
			//   MonitorData *v17; // rax
			//   Quaternion *v18; // rax
			//   Object__Class *v19; // rax
			//   MonitorData *v20; // rax
			//   Object__Class *v21; // rax
			//   MonitorData *v22; // rax
			//   Object__Class *v23; // rax
			//   MonitorData *v24; // rax
			//   Object__Class *v25; // rax
			//   Object__Class *v26; // rax
			//   MonitorData *v27; // rax
			//   MonitorData *v28; // rax
			//   Object__Class *v29; // rax
			//   MonitorData *v30; // rax
			//   Object__Class *v31; // rax
			//   MonitorData *v32; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Quaternion v34; // [rsp+20h] [rbp-30h] BYREF
			//   Object *component; // [rsp+78h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D919408 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>);
			//     byte_18D919408 = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2020, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>) )
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
			//                         sub_1800463A0(11LL, v5);
			//                         if ( component )
			//                         {
			//                           v10 = component[4].klass;
			//                           if ( v10 )
			//                           {
			//                             LOBYTE(v10._0.name) = 0;
			//                             if ( component )
			//                             {
			//                               TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                          (TileAnimationData *)&v34,
			//                                                          (TileBase *)component[4].klass,
			//                                                          v8,
			//                                                          v9,
			//                                                          *(MethodInfo **)&v34.x);
			//                               if ( v5 )
			//                               {
			//                                 v34 = (Quaternion)*TileAnimationDataNoRef;
			//                                 sub_18048EDCC(11LL, v5, &v34);
			//                                 if ( component )
			//                                 {
			//                                   v12 = component[4].monitor;
			//                                   if ( v12 )
			//                                   {
			//                                     *((_BYTE *)v12 + 16) = 0;
			//                                     if ( component )
			//                                     {
			//                                       identity = UnityEngine::Quaternion::get_identity(
			//                                                    &v34,
			//                                                    (MethodInfo *)component[4].monitor);
			//                                       if ( v5 )
			//                                       {
			//                                         v34 = *identity;
			//                                         sub_18004EA90(11LL, v5, &v34);
			//                                         if ( component )
			//                                         {
			//                                           v14 = component[5].klass;
			//                                           if ( v14 )
			//                                           {
			//                                             LOBYTE(v14._0.name) = 0;
			//                                             if ( component )
			//                                             {
			//                                               v5 = component[5].klass;
			//                                               if ( v5 )
			//                                               {
			//                                                 sub_180042C50(11LL, v5);
			//                                                 if ( component )
			//                                                 {
			//                                                   v15 = component[5].monitor;
			//                                                   if ( v15 )
			//                                                   {
			//                                                     *((_BYTE *)v15 + 16) = 0;
			//                                                     if ( component )
			//                                                     {
			//                                                       v5 = component[5].monitor;
			//                                                       if ( v5 )
			//                                                       {
			//                                                         sub_180042C50(11LL, v5);
			//                                                         if ( component )
			//                                                         {
			//                                                           v16 = component[6].klass;
			//                                                           if ( v16 )
			//                                                           {
			//                                                             LOBYTE(v16._0.name) = 0;
			//                                                             if ( component )
			//                                                             {
			//                                                               v5 = component[6].klass;
			//                                                               if ( v5 )
			//                                                               {
			//                                                                 sub_180042C50(11LL, v5);
			//                                                                 if ( component )
			//                                                                 {
			//                                                                   v17 = component[6].monitor;
			//                                                                   if ( v17 )
			//                                                                   {
			//                                                                     *((_BYTE *)v17 + 16) = 0;
			//                                                                     if ( component )
			//                                                                     {
			//                                                                       v18 = UnityEngine::Quaternion::get_identity(
			//                                                                               &v34,
			//                                                                               (MethodInfo *)component[6].monitor);
			//                                                                       if ( v5 )
			//                                                                       {
			//                                                                         v34 = *v18;
			//                                                                         sub_18004EA90(11LL, v5, &v34);
			//                                                                         if ( component )
			//                                                                         {
			//                                                                           v19 = component[7].klass;
			//                                                                           if ( v19 )
			//                                                                           {
			//                                                                             LOBYTE(v19._0.name) = 0;
			//                                                                             if ( component )
			//                                                                             {
			//                                                                               v5 = component[7].klass;
			//                                                                               if ( v5 )
			//                                                                               {
			//                                                                                 sub_180042C50(11LL, v5);
			//                                                                                 if ( component )
			//                                                                                 {
			//                                                                                   v20 = component[7].monitor;
			//                                                                                   if ( v20 )
			//                                                                                   {
			//                                                                                     *((_BYTE *)v20 + 16) = 0;
			//                                                                                     if ( component )
			//                                                                                     {
			//                                                                                       v5 = component[7].monitor;
			//                                                                                       if ( v5 )
			//                                                                                       {
			//                                                                                         sub_180042C50(11LL, v5);
			//                                                                                         if ( component )
			//                                                                                         {
			//                                                                                           v21 = component[8].klass;
			//                                                                                           if ( v21 )
			//                                                                                           {
			//                                                                                             LOBYTE(v21._0.name) = 0;
			//                                                                                             if ( component )
			//                                                                                             {
			//                                                                                               v5 = component[8].klass;
			//                                                                                               if ( v5 )
			//                                                                                               {
			//                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                 if ( component )
			//                                                                                                 {
			//                                                                                                   v22 = component[8].monitor;
			//                                                                                                   if ( v22 )
			//                                                                                                   {
			//                                                                                                     *((_BYTE *)v22 + 16) = 0;
			//                                                                                                     if ( component )
			//                                                                                                     {
			//                                                                                                       v5 = component[8].monitor;
			//                                                                                                       if ( v5 )
			//                                                                                                       {
			//                                                                                                         sub_180086B00(klass, v5, 0LL);
			//                                                                                                         if ( component )
			//                                                                                                         {
			//                                                                                                           v23 = component[9].klass;
			//                                                                                                           if ( v23 )
			//                                                                                                           {
			//                                                                                                             LOBYTE(v23._0.name) = 0;
			//                                                                                                             if ( component )
			//                                                                                                             {
			//                                                                                                               v5 = component[9].klass;
			//                                                                                                               if ( v5 )
			//                                                                                                               {
			//                                                                                                                 sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
			//                                                                                                                 if ( component )
			//                                                                                                                 {
			//                                                                                                                   v24 = component[9].monitor;
			//                                                                                                                   if ( v24 )
			//                                                                                                                   {
			//                                                                                                                     *((_BYTE *)v24 + 16) = 0;
			//                                                                                                                     if ( component )
			//                                                                                                                     {
			//                                                                                                                       v5 = component[9].monitor;
			//                                                                                                                       if ( v5 )
			//                                                                                                                       {
			//                                                                                                                         sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                                                                                         if ( component )
			//                                                                                                                         {
			//                                                                                                                           v25 = component[11].klass;
			//                                                                                                                           if ( v25 )
			//                                                                                                                           {
			//                                                                                                                             LOBYTE(v25._0.name) = 0;
			//                                                                                                                             if ( component )
			//                                                                                                                             {
			//                                                                                                                               v5 = component[11].klass;
			//                                                                                                                               if ( v5 )
			//                                                                                                                               {
			//                                                                                                                                 sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                                                                                                 if ( component )
			//                                                                                                                                 {
			//                                                                                                                                   v26 = component[10].klass;
			//                                                                                                                                   if ( v26 )
			//                                                                                                                                   {
			//                                                                                                                                     LOBYTE(v26._0.name) = 0;
			//                                                                                                                                     if ( component )
			//                                                                                                                                     {
			//                                                                                                                                       v5 = component[10].klass;
			//                                                                                                                                       if ( v5 )
			//                                                                                                                                       {
			//                                                                                                                                         sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
			//                                                                                                                                         if ( component )
			//                                                                                                                                         {
			//                                                                                                                                           v27 = component[10].monitor;
			//                                                                                                                                           if ( v27 )
			//                                                                                                                                           {
			//                                                                                                                                             *((_BYTE *)v27 + 16) = 0;
			//                                                                                                                                             if ( component )
			//                                                                                                                                             {
			//                                                                                                                                               v5 = component[10].monitor;
			//                                                                                                                                               if ( v5 )
			//                                                                                                                                               {
			//                                                                                                                                                 sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                                                                                                                 if ( component )
			//                                                                                                                                                 {
			//                                                                                                                                                   v28 = component[11].monitor;
			//                                                                                                                                                   if ( v28 )
			//                                                                                                                                                   {
			//                                                                                                                                                     *((_BYTE *)v28 + 16) = 0;
			//                                                                                                                                                     if ( component )
			//                                                                                                                                                     {
			//                                                                                                                                                       v5 = component[11].monitor;
			//                                                                                                                                                       if ( v5 )
			//                                                                                                                                                       {
			//                                                                                                                                                         sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
			//                                                                                                                                                         if ( component )
			//                                                                                                                                                         {
			//                                                                                                                                                           v29 = component[12].klass;
			//                                                                                                                                                           if ( v29 )
			//                                                                                                                                                           {
			//                                                                                                                                                             LOBYTE(v29._0.name) = 0;
			//                                                                                                                                                             if ( component )
			//                                                                                                                                                             {
			//                                                                                                                                                               v5 = component[12].klass;
			//                                                                                                                                                               if ( v5 )
			//                                                                                                                                                               {
			//                                                                                                                                                                 sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                                                                                                                                 if ( component )
			//                                                                                                                                                                 {
			//                                                                                                                                                                   v30 = component[12].monitor;
			//                                                                                                                                                                   if ( v30 )
			//                                                                                                                                                                   {
			//                                                                                                                                                                     *((_BYTE *)v30 + 16) = 0;
			//                                                                                                                                                                     if ( component )
			//                                                                                                                                                                     {
			//                                                                                                                                                                       v5 = component[12].monitor;
			//                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                       {
			//                                                                                                                                                                         sub_1800463A0(11LL, v5);
			//                                                                                                                                                                         if ( component )
			//                                                                                                                                                                         {
			//                                                                                                                                                                           v31 = component[13].klass;
			//                                                                                                                                                                           if ( v31 )
			//                                                                                                                                                                           {
			//                                                                                                                                                                             LOBYTE(v31._0.name) = 0;
			//                                                                                                                                                                             if ( component )
			//                                                                                                                                                                             {
			//                                                                                                                                                                               v5 = component[13].klass;
			//                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                               {
			//                                                                                                                                                                                 sub_1800463A0(11LL, v5);
			//                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                 {
			//                                                                                                                                                                                   v32 = component[13].monitor;
			//                                                                                                                                                                                   if ( v32 )
			//                                                                                                                                                                                   {
			//                                                                                                                                                                                     *((_BYTE *)v32 + 16) = 0;
			//                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                     {
			//                                                                                                                                                                                       v5 = component[13].monitor;
			//                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                       {
			//                                                                                                                                                                                         sub_1800463A0(11LL, v5);
			//                                                                                                                                                                                         return;
			//                                                                                                                                                                                       }
			//                                                                                                                                                                                     }
			//                                                                                                                                                                                   }
			//                                                                                                                                                                                 }
			//                                                                                                                                                                               }
			//                                                                                                                                                                             }
			//                                                                                                                                                                           }
			//                                                                                                                                                                         }
			//                                                                                                                                                                       }
			//                                                                                                                                                                     }
			//                                                                                                                                                                   }
			//                                                                                                                                                                 }
			//                                                                                                                                                               }
			//                                                                                                                                                             }
			//                                                                                                                                                           }
			//                                                                                                                                                         }
			//                                                                                                                                                       }
			//                                                                                                                                                     }
			//                                                                                                                                                   }
			//                                                                                                                                                 }
			//                                                                                                                                               }
			//                                                                                                                                             }
			//                                                                                                                                           }
			//                                                                                                                                         }
			//                                                                                                                                       }
			//                                                                                                                                     }
			//                                                                                                                                   }
			//                                                                                                                                 }
			//                                                                                                                               }
			//                                                                                                                             }
			//                                                                                                                           }
			//                                                                                                                         }
			//                                                                                                                       }
			//                                                                                                                     }
			//                                                                                                                   }
			//                                                                                                                 }
			//                                                                                                               }
			//                                                                                                             }
			//                                                                                                           }
			//                                                                                                         }
			//                                                                                                       }
			//                                                                                                     }
			//                                                                                                   }
			//                                                                                                 }
			//                                                                                               }
			//                                                                                             }
			//                                                                                           }
			//                                                                                         }
			//                                                                                       }
			//                                                                                     }
			//                                                                                   }
			//                                                                                 }
			//                                                                               }
			//                                                                             }
			//                                                                           }
			//                                                                         }
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
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
			// LABEL_98:
			//     sub_180B536AC(klass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2020, 0LL);
			//   if ( !Patch )
			//     goto LABEL_98;
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
			// bool HG::Rendering::Runtime::VFXPPBlackBox::IsActive(VFXPPBlackBox *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2021, 0LL) )
			//     return this.fields._useBlackBox;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2021, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void SetBlackBoxRadius(float blendRadius, float contourRadius)
		{
			// // Void SetBlackBoxRadius(Single, Single)
			// void HG::Rendering::Runtime::VFXPPBlackBox::SetBlackBoxRadius(
			//         VFXPPBlackBox *this,
			//         float blendRadius,
			//         float contourRadius,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2022, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2022, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(Patch, (Object *)this, blendRadius, contourRadius, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._blendRadius = blendRadius;
			//     this.fields._contourRangeRadius = contourRadius;
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
		[Space(10f)]
		private bool _useBlackBox;

		[Space(5f)]
		[ColorUsage(true, true)]
		[SerializeField]
		private Color _blendColor;

		[SerializeField]
		[Range(0f, 100f)]
		private float _blendWidth;

		private float _blendRadius;

		[SerializeField]
		[Range(0f, 1f)]
		private float _blendProgress;

		[Space(5f)]
		[SerializeField]
		[Range(0f, 100f)]
		private float _contourRangeWidth;

		private float _contourRangeRadius;

		[SerializeField]
		[Range(0f, 1f)]
		private float _contourRangeProgress;

		[SerializeField]
		[ColorUsage(true, true)]
		private Color _contourColor;

		[SerializeField]
		[Space(5f)]
		private Texture2D _contourTexture;

		[Header("等高线")]
		[SerializeField]
		private Vector2 _contourTexTiling;

		[SerializeField]
		private Vector2 _contourTexUVSpeed;

		[Header("扰动")]
		[SerializeField]
		private bool _useDisturb;

		[SerializeField]
		private Vector2 _disturbIntensity;

		[SerializeField]
		private Vector2 _disturbTexTiling;

		[SerializeField]
		private Vector2 _disturbTexUVSpeed;

		[SerializeField]
		[Header("遮罩")]
		private bool _useMask;

		[SerializeField]
		private bool _useMaskAsAlpha;

		[SerializeField]
		private Vector2 _maskTexTiling;

		[SerializeField]
		private Vector2 _maskTexUVSpeed;
	}
}
