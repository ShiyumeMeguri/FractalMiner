using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VolumetricLocalLight : MonoBehaviour
	{
		public VolumetricLocalLight()
		{
			// // VolumetricLocalLight()
			// void HG::Rendering::Runtime::VolumetricLocalLight::VolumetricLocalLight(VolumetricLocalLight *this, MethodInfo *method)
			// {
			//   __m128i v2; // xmm1
			//   __int64 v3; // r8
			//   Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v2 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v4, method));
			//   *(_DWORD *)(v3 + 48) = 1092616192;
			//   *(_DWORD *)(v3 + 44) = 1065353216;
			//   *(_DWORD *)(v3 + 68) = 1065353216;
			//   *(_DWORD *)(v3 + 72) = 1056964608;
			//   *(_DWORD *)(v3 + 76) = 1056964608;
			//   *(__m128i *)(v3 + 28) = v2;
			//   *(_DWORD *)(v3 + 56) = 1110441984;
			//   *(_DWORD *)(v3 + 64) = 0x40000000;
			//   UnityEngine::Component::Component((Component *)v3, 0LL);
			// }
			// 
		}

		public FLocalLightData GetLocalLightData()
		{
			// // FLocalLightData GetLocalLightData()
			// FLocalLightData *HG::Rendering::Runtime::VolumetricLocalLight::GetLocalLightData(
			//         FLocalLightData *__return_ptr retstr,
			//         VolumetricLocalLight *this,
			//         MethodInfo *method)
			// {
			//   int32_t v5; // esi
			//   double v6; // xmm0_8
			//   float LightIntensity; // xmm2_4
			//   float v8; // xmm8_4
			//   MethodInfo *v9; // r9
			//   __m128 v10; // xmm7
			//   Transform *transform; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Vector3 *position; // rax
			//   __int64 v15; // xmm0_8
			//   Transform *v16; // rax
			//   Vector3 *forward; // rax
			//   __int64 v18; // xmm1_8
			//   MethodInfo *v19; // r8
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm4_8
			//   double v22; // xmm0_8
			//   bool v23; // zf
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   FLocalLightData *v29; // rax
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   FLocalLightData *result; // rax
			//   Vector4 v33; // [rsp+28h] [rbp-49h] BYREF
			//   Color LightColor; // [rsp+38h] [rbp-39h] BYREF
			//   FLocalLightData v35; // [rsp+48h] [rbp-29h] BYREF
			// 
			//   v5 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4464, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4464, 0LL);
			//     if ( Patch )
			//     {
			//       v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1282(&v35, Patch, (Object *)this, 0LL);
			//       v30 = *(_OWORD *)&v29.Color.x;
			//       *(_OWORD *)&retstr.Position.x = *(_OWORD *)&v29.Position.x;
			//       v31 = *(_OWORD *)&v29.Direction.x;
			//       *(_OWORD *)&retstr.Color.x = v30;
			//       v26 = *(_OWORD *)&v29.SpotAngles.x;
			//       *(_OWORD *)&retstr.Direction.x = v31;
			//       v27 = *(_OWORD *)&v29.ShadowIntensity;
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v13, v12);
			//   }
			//   v6 = Beyond::DampingMath::cosf();
			//   LightIntensity = this.fields.LightIntensity;
			//   v8 = *(float *)&v6;
			//   LightColor = this.fields.LightColor;
			//   v10 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
			//                                                    &v33,
			//                                                    (Vector4 *)&LightColor,
			//                                                    LightIntensity,
			//                                                    v9));
			//   sub_1802F01E0(&v35, 0LL, 80LL);
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !transform )
			//     goto LABEL_6;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&v33, transform, 0LL);
			//   LODWORD(v35.Color.x) = v10.m128_i32[0];
			//   v15 = *(_QWORD *)&position.x;
			//   *(float *)&position = position.z;
			//   *(_QWORD *)&v35.Position.x = v15;
			//   LODWORD(v35.Color.z) = _mm_shuffle_ps(v10, v10, 170).m128_u32[0];
			//   LODWORD(v35.Color.y) = _mm_shuffle_ps(v10, v10, 85).m128_u32[0];
			//   *(float *)&v15 = this.fields.Radius;
			//   LODWORD(v35.Position.z) = (_DWORD)position;
			//   LODWORD(v35.Radius) = v15;
			//   v35.InvRadius = 1.0 / *(float *)&v15;
			//   v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !v16 )
			//     goto LABEL_6;
			//   forward = UnityEngine::Transform::get_forward((Vector3 *)&LightColor, v16, 0LL);
			//   v18 = *(_QWORD *)&forward.x;
			//   *(float *)&forward = forward.z;
			//   *(_QWORD *)&v33.x = v18;
			//   LODWORD(v33.z) = (_DWORD)forward;
			//   v20 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&LightColor, (Vector3 *)&v33, v19);
			//   v21 = *(_QWORD *)&v20.x;
			//   *(float *)&v20 = v20.z;
			//   *(_QWORD *)&v35.Direction.x = v21;
			//   LODWORD(v35.Direction.z) = (_DWORD)v20;
			//   v22 = Beyond::DampingMath::cosf();
			//   v35.SpotAngles.x = v8;
			//   v35.SpotAngles.y = 1.0 / (float)(*(float *)&v22 - v8);
			//   v35.bSpotLight = this.fields.LightType == 1;
			//   v23 = !this.fields.bInverseSquared;
			//   v24 = *(_OWORD *)&v35.Color.x;
			//   *(_OWORD *)&v35.FalloffExponent = *(_OWORD *)&this.fields.FalloffExponent;
			//   LOBYTE(v5) = !v23;
			//   *(_OWORD *)&retstr.Position.x = *(_OWORD *)&v35.Position.x;
			//   v35.bInverseSquared = v5;
			//   v25 = *(_OWORD *)&v35.Direction.x;
			//   *(_OWORD *)&retstr.Color.x = v24;
			//   v26 = *(_OWORD *)&v35.SpotAngles.x;
			//   *(_OWORD *)&retstr.Direction.x = v25;
			//   v27 = *(_OWORD *)&v35.ShadowIntensity;
			// LABEL_8:
			//   result = retstr;
			//   *(_OWORD *)&retstr.SpotAngles.x = v26;
			//   *(_OWORD *)&retstr.ShadowIntensity = v27;
			//   return result;
			// }
			// 
			return null;
		}

		[SerializeField]
		private ELocalLightType LightType;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private float Radius;

		[SerializeField]
		private float InnerConeAngle;

		[SerializeField]
		private float OuterConeAngle;

		[SerializeField]
		private bool bSpotLight;

		[SerializeField]
		private bool bInverseSquared;

		[SerializeField]
		private float FalloffExponent;

		[SerializeField]
		private float ShadowIntensity;

		[SerializeField]
		private float MsScatteringFactor;

		[SerializeField]
		private float MsExtinctionFactor;
	}
}
