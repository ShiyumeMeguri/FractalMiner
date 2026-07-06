using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[AddComponentMenu("HG/Effect/VFXAutoEmissiveRate(根据缩放增加例子数)")]
	[RequireComponent(typeof(ParticleSystem))]
	public class VFXAutoEmissiveRate : VFXPlayableMonoBase
	{
		public VFXAutoEmissiveRate()
		{
			// // VFXAutoEmissiveRate()
			// void HG::Rendering::Runtime::VFXAutoEmissiveRate::VFXAutoEmissiveRate(VFXAutoEmissiveRate *this, MethodInfo *method)
			// {
			//   this.fields.particleSystemScalingMode = 2;
			//   this.fields.axisBitMask = 7;
			//   this.fields._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::VFXAutoEmissiveRate::Awake(VFXAutoEmissiveRate *this, MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9A7 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::ParticleSystem>);
			//     byte_18D8ED9A7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2145, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2145, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_particleSystem = (ParticleSystem *)UnityEngine::Component::GetComponent<System::Object>(
			//                                                         (Component *)this,
			//                                                         MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::ParticleSystem>);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_particleSystem, v3, v4, v5, v9, v10);
			//   }
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::VFXAutoEmissiveRate::OnPlay(VFXAutoEmissiveRate *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2146, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2146, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnValidate()
		{
			// // Void OnValidate()
			// void HG::Rendering::Runtime::VFXAutoEmissiveRate::OnValidate(VFXAutoEmissiveRate *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2148, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2148, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(this, 0LL);
			//   }
			// }
			// 
		}

		public void AppyValue()
		{
			// // Void AppyValue()
			// void HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(VFXAutoEmissiveRate *this, MethodInfo *method)
			// {
			//   int v3; // ebx
			//   __int64 v4; // rdx
			//   Object_1 *m_particleSystem; // rsi
			//   PassConstructorID__Enum__Array *v6; // r8
			//   HGCamera *v7; // r9
			//   int32_t scaleMode; // eax
			//   float x; // xmm1_4
			//   float y; // xmm2_4
			//   float z; // xmm3_4
			//   unsigned __int64 axisBitMask; // rdx
			//   __int64 v13; // rcx
			//   Transform *transform; // rsi
			//   void (__fastcall *v15)(Transform *, Vector3 *); // rax
			//   float v16; // xmm6_4
			//   float v17; // xmm0_4
			//   void (__fastcall *v18)(__int64 *, __int128 *); // rax
			//   void (__fastcall *v19)(__int64 *, _OWORD *); // rax
			//   __m128 v20; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   __int64 v22; // rcx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   unsigned int particleSystemScalingMode; // ebx
			//   void (__fastcall *v26)(__int64 *, _QWORD); // rax
			//   __int64 (__fastcall *v27)(__int64 *); // rax
			//   __int64 v28; // rdx
			//   int v29; // edi
			//   unsigned int v30; // ebx
			//   void (__fastcall *v31)(__int64 *, _QWORD); // rax
			//   __int64 v32; // rax
			//   Transform *v33; // rax
			//   Vector3 *localScale; // rax
			//   __int64 v35; // rax
			//   SystemException *v36; // rbx
			//   String *v37; // rax
			//   __int64 v38; // rax
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   __int64 v42; // rax
			//   __int64 v43; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v45; // [rsp+20h] [rbp-39h] BYREF
			//   __int128 v46; // [rsp+30h] [rbp-29h] BYREF
			//   __m128 v47; // [rsp+40h] [rbp-19h]
			//   _OWORD v48[4]; // [rsp+50h] [rbp-9h] BYREF
			//   __int64 v49; // [rsp+D0h] [rbp+77h] BYREF
			//   __int64 v50; // [rsp+D8h] [rbp+7Fh] BYREF
			// 
			//   if ( !byte_18D8ED9A8 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED9A8 = 1;
			//   }
			//   v3 = 0;
			//   v50 = 0LL;
			//   v49 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2147, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2147, 0LL);
			//     if ( !Patch )
			//       goto LABEL_45;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//     return;
			//   }
			//   m_particleSystem = (Object_1 *)this.fields.m_particleSystem;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !UnityEngine::Object::op_Implicit(m_particleSystem, 0LL) )
			//     return;
			//   scaleMode = this.fields.scaleMode;
			//   x = 0.0;
			//   y = 0.0;
			//   z = 0.0;
			//   if ( !scaleMode )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( !transform )
			//       goto LABEL_45;
			//     *(_QWORD *)&v45.x = 0LL;
			//     v45.z = 0.0;
			//     v15 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F5380;
			//     if ( !qword_18D8F5380 )
			//     {
			//       v15 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//       if ( !v15 )
			//       {
			//         v32 = sub_1802DBBE8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v32, 0LL);
			//       }
			//       qword_18D8F5380 = (__int64)v15;
			//     }
			//     v15(transform, &v45);
			//     y = v45.y;
			//     z = v45.z;
			// LABEL_11:
			//     x = v45.x;
			//     goto LABEL_12;
			//   }
			//   if ( scaleMode == 1 )
			//   {
			//     v33 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( !v33 )
			//       goto LABEL_45;
			//     localScale = UnityEngine::Transform::get_localScale(&v45, v33, 0LL);
			//     z = localScale.z;
			//     LODWORD(y) = _mm_shuffle_ps(
			//                    (__m128)*(unsigned __int64 *)&localScale.x,
			//                    (__m128)*(unsigned __int64 *)&localScale.x,
			//                    85).m128_u32[0];
			//     *(_QWORD *)&v45.x = *(_QWORD *)&localScale.x;
			//     goto LABEL_11;
			//   }
			// LABEL_12:
			//   v16 = 1.0;
			//   axisBitMask = (unsigned int)this.fields.axisBitMask;
			//   do
			//   {
			//     v13 = v3 & 0x1F;
			//     if ( (((int)axisBitMask >> v13) & 1) != 0 )
			//     {
			//       v13 = (unsigned int)v3;
			//       if ( v3 )
			//       {
			//         v13 = (unsigned int)(v3 - 1);
			//         if ( v3 == 1 )
			//         {
			//           v17 = y;
			//         }
			//         else
			//         {
			//           if ( v3 != 2 )
			//           {
			//             v35 = sub_18003C530(&TypeInfo::System::IndexOutOfRangeException);
			//             v36 = (SystemException *)sub_180004920(v35);
			//             if ( v36 )
			//             {
			//               v37 = (String *)sub_18003C530(&off_18D5D2B98);
			//               System::SystemException::SystemException(v36, v37, 0LL);
			//               v36.fields._._HResult = -2146233080;
			//               v38 = sub_18003C530(MethodInfo::UnityEngine::Vector3::get_Item);
			//               sub_18000F7C0(v36, v38);
			//             }
			// LABEL_45:
			//             sub_180B536AC(v13, axisBitMask);
			//           }
			//           v17 = z;
			//         }
			//       }
			//       else
			//       {
			//         v17 = x;
			//       }
			//       v16 = v16 * v17;
			//     }
			//     ++v3;
			//   }
			//   while ( v3 < 3 );
			//   if ( v16 > 1000.0 )
			//     v16 = 1000.0;
			//   if ( !this.fields.m_particleSystem )
			//     goto LABEL_45;
			//   *(_QWORD *)&v45.x = this.fields.m_particleSystem;
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//     (HGRenderPathScene *)&v45,
			//     (HGRenderPathBase_HGRenderPathResources *)axisBitMask,
			//     v6,
			//     v7);
			//   v50 = *(_QWORD *)&v45.x;
			//   v18 = (void (__fastcall *)(__int64 *, __int128 *))qword_18D8F6080;
			//   v46 = 0LL;
			//   v47 = 0LL;
			//   if ( !qword_18D8F6080 )
			//   {
			//     v18 = (void (__fastcall *)(__int64 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Inje"
			//                                                         "cted(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.Part"
			//                                                         "icleSystem/MinMaxCurve&)");
			//     if ( !v18 )
			//     {
			//       v39 = sub_1802DBBE8(
			//               "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionMo"
			//               "dule&,UnityEngine.ParticleSystem/MinMaxCurve&)");
			//       sub_18000F750(v39, 0LL);
			//     }
			//     qword_18D8F6080 = (__int64)v18;
			//   }
			//   v18(&v50, &v46);
			//   v19 = (void (__fastcall *)(__int64 *, _OWORD *))qword_18D8F6088;
			//   v20 = _mm_shuffle_ps(v47, v47, 147);
			//   v20.m128_f32[0] = v16 * this.fields.rateOverTime;
			//   v48[1] = _mm_shuffle_ps(v20, v20, 57);
			//   v48[0] = v46;
			//   if ( !qword_18D8F6088 )
			//   {
			//     v19 = (void (__fastcall *)(__int64 *, _OWORD *))il2cpp_resolve_icall_0(
			//                                                       "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Inject"
			//                                                       "ed(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.Particle"
			//                                                       "System/MinMaxCurve&)");
			//     if ( !v19 )
			//     {
			//       v40 = sub_1802DBBE8(
			//               "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionMo"
			//               "dule&,UnityEngine.ParticleSystem/MinMaxCurve&)");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F6088 = (__int64)v19;
			//   }
			//   v19(&v50, v48);
			//   if ( !this.fields.m_particleSystem )
			//     sub_180B536AC(v22, v21);
			//   *(_QWORD *)&v45.x = this.fields.m_particleSystem;
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//     (HGRenderPathScene *)&v45,
			//     v21,
			//     v23,
			//     v24);
			//   particleSystemScalingMode = this.fields.particleSystemScalingMode;
			//   v49 = *(_QWORD *)&v45.x;
			//   v26 = (void (__fastcall *)(__int64 *, _QWORD))qword_18D8F6068;
			//   if ( !qword_18D8F6068 )
			//   {
			//     v26 = (void (__fastcall *)(__int64 *, _QWORD))il2cpp_resolve_icall_0(
			//                                                     "UnityEngine.ParticleSystem/MainModule::set_scalingMode_Injected(Unit"
			//                                                     "yEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystemScalingMode)");
			//     if ( !v26 )
			//     {
			//       v41 = sub_1802DBBE8(
			//               "UnityEngine.ParticleSystem/MainModule::set_scalingMode_Injected(UnityEngine.ParticleSystem/MainModule&,Uni"
			//               "tyEngine.ParticleSystemScalingMode)");
			//       sub_18000F750(v41, 0LL);
			//     }
			//     qword_18D8F6068 = (__int64)v26;
			//   }
			//   v26(&v49, particleSystemScalingMode);
			//   v27 = (__int64 (__fastcall *)(__int64 *))qword_18D8F6070;
			//   if ( !qword_18D8F6070 )
			//   {
			//     v27 = (__int64 (__fastcall *)(__int64 *))il2cpp_resolve_icall_0(
			//                                                "UnityEngine.ParticleSystem/MainModule::get_maxParticles_Injected(UnityEng"
			//                                                "ine.ParticleSystem/MainModule&)");
			//     if ( !v27 )
			//     {
			//       v42 = sub_1802DBBE8("UnityEngine.ParticleSystem/MainModule::get_maxParticles_Injected(UnityEngine.ParticleSystem/MainModule&)");
			//       sub_18000F750(v42, 0LL);
			//     }
			//     qword_18D8F6070 = (__int64)v27;
			//   }
			//   v29 = v27(&v49);
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v28);
			//   v30 = 1000;
			//   if ( v29 < 1000 )
			//     v30 = v29;
			//   v31 = (void (__fastcall *)(__int64 *, _QWORD))qword_18D8F6078;
			//   if ( !qword_18D8F6078 )
			//   {
			//     v31 = (void (__fastcall *)(__int64 *, _QWORD))il2cpp_resolve_icall_0(
			//                                                     "UnityEngine.ParticleSystem/MainModule::set_maxParticles_Injected(Uni"
			//                                                     "tyEngine.ParticleSystem/MainModule&,System.Int32)");
			//     if ( !v31 )
			//     {
			//       v43 = sub_1802DBBE8(
			//               "UnityEngine.ParticleSystem/MainModule::set_maxParticles_Injected(UnityEngine.ParticleSystem/MainModule&,System.Int32)");
			//       sub_18000F750(v43, 0LL);
			//     }
			//     qword_18D8F6078 = (__int64)v31;
			//   }
			//   v31(&v49, v30);
			// }
			// 
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

		[Header("缩放为1时的rate,最大只支持10x10x10")]
		public float rateOverTime;

		public VFXAutoEmissiveRate.ScaleMode scaleMode;

		public ParticleSystemScalingMode particleSystemScalingMode;

		public VFXAutoEmissiveRate.AxisBitMask axisBitMask;

		private ParticleSystem m_particleSystem;

		public enum ScaleMode
		{
			Global,
			Local
		}

		[Flags]
		public enum AxisBitMask
		{
			X = 1,
			Y = 2,
			Z = 4,
			All = 7
		}
	}
}
