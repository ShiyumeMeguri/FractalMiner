using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPCharacterDirectionalLight(角色自定义方向光)")]
	[ExecuteInEditMode]
	public class VFXPPCharacterDirectionalLight : VFXPPComponent
	{
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 get_id()
				// int32_t UnityEngine::HyperGryph::ECS::RenderObjectK8Component::get_id(
				//         RenderObjectK8Component *this,
				//         MethodInfo *method)
				// {
				//   return 11;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPCharacterDirectionalLight()
		{
			// // VFXPPCharacterDirectionalLight()
			// void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::VFXPPCharacterDirectionalLight(
			//         VFXPPCharacterDirectionalLight *this,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v3; // rdx
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rdi
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   Vector4 v9; // xmm0
			//   MethodInfo *v10; // rdx
			//   MethodInfo *v11; // rdx
			//   Vector4 v12; // xmm1
			//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8ED986 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     byte_18D8ED986 = 1;
			//   }
			//   this.fields.m_LightColor = (Color)*UnityEngine::Vector4::get_one(&v13, method);
			//   v13 = *UnityEngine::Vector4::get_one(&v13, v3);
			//   v6 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v6 )
			//     sub_180B536AC(v5, v4);
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   v9 = v13;
			//   *(_WORD *)(v6 + 41) = 257;
			//   *(_BYTE *)(v6 + 16) = 0;
			//   *(Vector4 *)(v6 + 24) = v9;
			//   this.fields.m_SkinLightColorParameter = (ColorParameter *)v6;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_SkinLightColorParameter,
			//     v4,
			//     v7,
			//     v8,
			//     *(MethodInfo **)&v13.x,
			//     *(MethodInfo **)&v13.z);
			//   this.fields.m_Intensity = 1.0;
			//   this.fields.m_Contrast = 0.5;
			//   this.fields.m_SpecularIntensity = 1.0;
			//   this.fields.m_IgnoreSceneShadow = 1;
			//   this.fields.m_CustomShadowTintColor = (Color)*UnityEngine::Vector4::get_one(&v13, v10);
			//   v12 = *UnityEngine::Vector4::get_one(&v13, v11);
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   this.fields.m_CustomShadowSkinTintColor = (Color)v12;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::Apply(
			//         VFXPPCharacterDirectionalLight *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   __int64 v6; // rdx
			//   _BYTE *v7; // rcx
			//   Object__Class *klass; // rax
			//   ColorParameter *m_SkinLightColorParameter; // rax
			//   ColorParameter *v10; // r8
			//   Object__Class *v11; // rbx
			//   __int128 *v12; // rax
			//   MonitorData *monitor; // rax
			//   MonitorData *v14; // rax
			//   __m128i v15; // xmm0
			//   Object__Class *v16; // rax
			//   Object__Class *v17; // rax
			//   Object__Class *v18; // rax
			//   MonitorData *v19; // rax
			//   MonitorData *v20; // rbx
			//   Transform *v21; // rax
			//   Vector3 *eulerAngles; // rax
			//   __int64 v23; // xmm0_8
			//   MethodInfo *v24; // rdx
			//   float y; // xmm1_4
			//   __m128i v26; // xmm0
			//   __m128i v27; // xmm1
			//   MonitorData *v28; // rax
			//   Object__Class *v29; // rax
			//   MonitorData *v30; // rax
			//   Object__Class *v31; // rax
			//   MonitorData *v32; // rax
			//   MonitorData *v33; // rax
			//   Object__Class *v34; // rax
			//   MonitorData *v35; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v37; // [rsp+20h] [rbp-20h] BYREF
			//   __int128 v38; // [rsp+30h] [rbp-10h] BYREF
			//   Object *component; // [rsp+68h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D91940D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector2>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowMode>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintMode>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterLightMode>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<bool>::Override);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGCharacterVolume>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGCharacterVolume>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>);
			//     byte_18D91940D = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2028, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2028, 0LL);
			//     if ( !Patch )
			//       goto LABEL_58;
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
			//       goto LABEL_58;
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
			//           klass = component[12].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 1;
			//             LODWORD(klass._0.namespaze) = 2;
			//             if ( component )
			//             {
			//               v7 = component[14].klass;
			//               m_SkinLightColorParameter = this.fields.m_SkinLightColorParameter;
			//               if ( m_SkinLightColorParameter )
			//               {
			//                 LOBYTE(v6) = m_SkinLightColorParameter.fields._._.overrideState;
			//                 if ( v7 )
			//                 {
			//                   v7[16] = v6;
			//                   if ( component )
			//                   {
			//                     v10 = this.fields.m_SkinLightColorParameter;
			//                     v11 = component[14].klass;
			//                     if ( v10 )
			//                     {
			//                       v12 = (__int128 *)sub_180040AD0(&v38, 10LL, v10);
			//                       if ( v11 )
			//                       {
			//                         v38 = *v12;
			//                         sub_18004EA90(11LL, v11, &v38);
			//                         if ( component )
			//                         {
			//                           monitor = component[11].monitor;
			//                           LOBYTE(v7) = this.fields.m_IgnoreSceneShadow;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 1;
			//                             *((_BYTE *)monitor + 24) = (_BYTE)v7;
			//                             if ( component )
			//                             {
			//                               v14 = component[13].monitor;
			//                               if ( v14 )
			//                               {
			//                                 v15 = _mm_loadu_si128((const __m128i *)&this.fields.m_LightColor);
			//                                 *((_BYTE *)v14 + 16) = 1;
			//                                 *(__m128i *)((char *)v14 + 24) = v15;
			//                                 if ( component )
			//                                 {
			//                                   v16 = component[9].klass;
			//                                   if ( v16 )
			//                                   {
			//                                     *(float *)&v16._0.namespaze = this.fields.m_SpecularIntensity;
			//                                     LOBYTE(v16._0.name) = 1;
			//                                     if ( component )
			//                                     {
			//                                       v17 = component[11].klass;
			//                                       if ( v17 )
			//                                       {
			//                                         *(float *)&v17._0.namespaze = this.fields.m_RampBias;
			//                                         LOBYTE(v17._0.name) = 1;
			//                                         if ( component )
			//                                         {
			//                                           v18 = component[8].klass;
			//                                           if ( v18 )
			//                                           {
			//                                             *(float *)&v18._0.namespaze = this.fields.m_Contrast;
			//                                             LOBYTE(v18._0.name) = 1;
			//                                             if ( component )
			//                                             {
			//                                               v19 = component[7].monitor;
			//                                               if ( v19 )
			//                                               {
			//                                                 *((_DWORD *)v19 + 6) = LODWORD(this.fields.m_Intensity);
			//                                                 *((_BYTE *)v19 + 16) = 1;
			//                                                 if ( component )
			//                                                 {
			//                                                   v20 = component[12].monitor;
			//                                                   v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//                                                   if ( v21 )
			//                                                   {
			//                                                     eulerAngles = UnityEngine::Transform::get_eulerAngles(
			//                                                                     (Vector3 *)&v38,
			//                                                                     v21,
			//                                                                     0LL);
			//                                                     v23 = *(_QWORD *)&eulerAngles.x;
			//                                                     *(float *)&eulerAngles = eulerAngles.z;
			//                                                     *(_QWORD *)&v37.x = v23;
			//                                                     LODWORD(v37.z) = (_DWORD)eulerAngles;
			//                                                     *(Vector2 *)&v37.x = UnityEngine::Vector4::op_Implicit(&v37, v24);
			//                                                     if ( v20 )
			//                                                     {
			//                                                       y = v37.y;
			//                                                       *((_DWORD *)v20 + 6) = LODWORD(v37.x);
			//                                                       *((float *)v20 + 7) = y;
			//                                                       *((_BYTE *)v20 + 16) = 1;
			//                                                       v7 = component;
			//                                                       if ( component )
			//                                                       {
			//                                                         LOBYTE(v6) = this.fields.m_SelfShadowRealisticMode;
			//                                                         v7 = component[16].monitor;
			//                                                         if ( v7 )
			//                                                         {
			//                                                           v7[16] = 1;
			//                                                           *((_DWORD *)v7 + 6) = (_BYTE)v6 == 0;
			//                                                           LOBYTE(v6) = this.fields.m_IgnoreSceneShadow;
			//                                                           v7 = component;
			//                                                           if ( component )
			//                                                           {
			//                                                             v7 = component[15].klass;
			//                                                             if ( v7 )
			//                                                             {
			//                                                               v7[16] = 1;
			//                                                               *((_DWORD *)v7 + 6) = (_BYTE)v6 != 0;
			//                                                               if ( this.fields.m_CustomShadowTint )
			//                                                               {
			//                                                                 v26 = _mm_loadu_si128((const __m128i *)&this.fields.m_CustomShadowTintColor);
			//                                                                 v27 = _mm_loadu_si128((const __m128i *)&this.fields.m_CustomShadowSkinTintColor);
			//                                                               }
			//                                                               else
			//                                                               {
			//                                                                 v26 = _mm_loadu_si128((const __m128i *)&this.fields.m_LightColor);
			//                                                                 v27 = v26;
			//                                                               }
			//                                                               if ( component )
			//                                                               {
			//                                                                 v28 = component[15].monitor;
			//                                                                 if ( v28 )
			//                                                                 {
			//                                                                   *((_BYTE *)v28 + 16) = 1;
			//                                                                   *(__m128i *)((char *)v28 + 24) = v26;
			//                                                                   if ( component )
			//                                                                   {
			//                                                                     v29 = component[16].klass;
			//                                                                     if ( v29 )
			//                                                                     {
			//                                                                       LOBYTE(v29._0.name) = 1;
			//                                                                       *(__m128i *)&v29._0.namespaze = v27;
			//                                                                       if ( component )
			//                                                                       {
			//                                                                         v30 = component[25].monitor;
			//                                                                         LOBYTE(v7) = this.fields.m_IgnoreSceneAdditionalLights;
			//                                                                         if ( v30 )
			//                                                                         {
			//                                                                           *((_BYTE *)v30 + 16) = 1;
			//                                                                           *((_BYTE *)v30 + 24) = (_BYTE)v7;
			//                                                                           if ( component )
			//                                                                           {
			//                                                                             v31 = component[26].klass;
			//                                                                             LOBYTE(v7) = this.fields.m_IgnoreSceneEnv;
			//                                                                             if ( v31 )
			//                                                                             {
			//                                                                               LOBYTE(v31._0.name) = 1;
			//                                                                               LOBYTE(v31._0.namespaze) = (_BYTE)v7;
			//                                                                               if ( component )
			//                                                                               {
			//                                                                                 v32 = component[14].monitor;
			//                                                                                 if ( v32 )
			//                                                                                 {
			//                                                                                   *((_BYTE *)v32 + 16) = 1;
			//                                                                                   *((_BYTE *)v32 + 24) = 0;
			//                                                                                   if ( component )
			//                                                                                   {
			//                                                                                     v33 = component[9].monitor;
			//                                                                                     if ( v33 )
			//                                                                                     {
			//                                                                                       *((_DWORD *)v33 + 6) = LODWORD(this.fields.m_EyeBaselight);
			//                                                                                       *((_BYTE *)v33 + 16) = 1;
			//                                                                                       if ( component )
			//                                                                                       {
			//                                                                                         v34 = component[10].klass;
			//                                                                                         if ( v34 )
			//                                                                                         {
			//                                                                                           *(float *)&v34._0.namespaze = this.fields.m_EyeHightlight;
			//                                                                                           LOBYTE(v34._0.name) = 1;
			//                                                                                           if ( component )
			//                                                                                           {
			//                                                                                             v35 = component[10].monitor;
			//                                                                                             if ( v35 )
			//                                                                                             {
			//                                                                                               *((_DWORD *)v35 + 6) = LODWORD(this.fields.m_EyeScatterlight);
			//                                                                                               *((_BYTE *)v35 + 16) = 1;
			//                                                                                               return;
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
			// LABEL_58:
			//       sub_180B536AC(v7, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::ResetByVolumeProfile(
			//         VFXPPCharacterDirectionalLight *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   _BYTE *klass; // rcx
			//   MonitorData *monitor; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED985 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>);
			//     byte_18D8ED985 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2029, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2029, 0LL);
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
			//         klass = component[12].klass;
			//         if ( klass )
			//         {
			//           klass[16] = 0;
			//           if ( component )
			//           {
			//             klass = component[14].klass;
			//             if ( klass )
			//             {
			//               klass[16] = 0;
			//               if ( component )
			//               {
			//                 klass = component[11].monitor;
			//                 if ( klass )
			//                 {
			//                   klass[16] = 0;
			//                   if ( component )
			//                   {
			//                     klass = component[13].monitor;
			//                     if ( klass )
			//                     {
			//                       klass[16] = 0;
			//                       if ( component )
			//                       {
			//                         klass = component[11].klass;
			//                         if ( klass )
			//                         {
			//                           klass[16] = 0;
			//                           if ( component )
			//                           {
			//                             klass = component[7].monitor;
			//                             if ( klass )
			//                             {
			//                               klass[16] = 0;
			//                               if ( component )
			//                               {
			//                                 klass = component[8].klass;
			//                                 if ( klass )
			//                                 {
			//                                   klass[16] = 0;
			//                                   if ( component )
			//                                   {
			//                                     klass = component[9].klass;
			//                                     if ( klass )
			//                                     {
			//                                       klass[16] = 0;
			//                                       if ( component )
			//                                       {
			//                                         klass = component[12].monitor;
			//                                         if ( klass )
			//                                         {
			//                                           klass[16] = 0;
			//                                           if ( component )
			//                                           {
			//                                             klass = component[16].monitor;
			//                                             if ( klass )
			//                                             {
			//                                               klass[16] = 0;
			//                                               if ( component )
			//                                               {
			//                                                 klass = component[15].klass;
			//                                                 if ( klass )
			//                                                 {
			//                                                   klass[16] = 0;
			//                                                   if ( component )
			//                                                   {
			//                                                     klass = component[15].monitor;
			//                                                     if ( klass )
			//                                                     {
			//                                                       klass[16] = 0;
			//                                                       if ( component )
			//                                                       {
			//                                                         klass = component[16].klass;
			//                                                         if ( klass )
			//                                                         {
			//                                                           klass[16] = 0;
			//                                                           if ( component )
			//                                                           {
			//                                                             klass = component[25].monitor;
			//                                                             if ( klass )
			//                                                             {
			//                                                               klass[16] = 0;
			//                                                               if ( component )
			//                                                               {
			//                                                                 klass = component[26].klass;
			//                                                                 if ( klass )
			//                                                                 {
			//                                                                   klass[16] = 0;
			//                                                                   if ( component )
			//                                                                   {
			//                                                                     klass = component[14].monitor;
			//                                                                     if ( klass )
			//                                                                     {
			//                                                                       klass[16] = 0;
			//                                                                       if ( component )
			//                                                                       {
			//                                                                         klass = component[9].monitor;
			//                                                                         if ( klass )
			//                                                                         {
			//                                                                           klass[16] = 0;
			//                                                                           if ( component )
			//                                                                           {
			//                                                                             klass = component[10].klass;
			//                                                                             if ( klass )
			//                                                                             {
			//                                                                               klass[16] = 0;
			//                                                                               if ( component )
			//                                                                               {
			//                                                                                 monitor = component[10].monitor;
			//                                                                                 if ( monitor )
			//                                                                                 {
			//                                                                                   *((_BYTE *)monitor + 16) = 0;
			//                                                                                   return;
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
			// LABEL_10:
			//     sub_180B536AC(klass, v6);
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

		[SerializeField]
		private Color m_LightColor;

		[SerializeField]
		private ColorParameter m_SkinLightColorParameter;

		[Range(0f, 10f)]
		[SerializeField]
		[Space]
		private float m_Intensity;

		[SerializeField]
		[Range(0f, 2f)]
		private float m_Contrast;

		[SerializeField]
		[Range(0f, 2f)]
		private float m_SpecularIntensity;

		[SerializeField]
		[Range(-1f, 1f)]
		private float m_RampBias;

		[Header("投影控制")]
		[SerializeField]
		private bool m_SelfShadowRealisticMode;

		[SerializeField]
		private bool m_IgnoreSceneShadow;

		[SerializeField]
		[Header("阴影颜色")]
		private bool m_CustomShadowTint;

		[SerializeField]
		private Color m_CustomShadowTintColor;

		[SerializeField]
		private Color m_CustomShadowSkinTintColor;

		[SerializeField]
		[Header("眼睛光照")]
		[Range(0f, 3f)]
		private float m_EyeBaselight;

		[Range(0f, 3f)]
		[SerializeField]
		private float m_EyeHightlight;

		[SerializeField]
		[Range(0f, 3f)]
		private float m_EyeScatterlight;

		[SerializeField]
		[Header("多光源控制")]
		private bool m_IgnoreSceneAdditionalLights;

		[SerializeField]
		[Header("Env控制")]
		private bool m_IgnoreSceneEnv;
	}
}
