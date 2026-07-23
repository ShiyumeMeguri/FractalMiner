using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VolumetricLocalLight : MonoBehaviour // TypeDefIndex: 38723
	{
		// Fields
		[SerializeField]
		private ELocalLightType LightType; // 0x18
		[SerializeField]
		private UnityEngine.Color LightColor; // 0x1C
		[SerializeField]
		private float LightIntensity; // 0x2C
		[SerializeField]
		private float Radius; // 0x30
		[SerializeField]
		private float InnerConeAngle; // 0x34
		[SerializeField]
		private float OuterConeAngle; // 0x38
		[SerializeField]
		private bool bSpotLight; // 0x3C
		[SerializeField]
		private bool bInverseSquared; // 0x3D
		[SerializeField]
		private float FalloffExponent; // 0x40
		[SerializeField]
		private float ShadowIntensity; // 0x44
		[SerializeField]
		private float MsScatteringFactor; // 0x48
		[SerializeField]
		private float MsExtinctionFactor; // 0x4C
	
		// Constructors
		public VolumetricLocalLight() {} // 0x0000000189C53BEC-0x0000000189C53C48
		// VolumetricLocalLight()
		void HG::Rendering::Runtime::VolumetricLocalLight::VolumetricLocalLight(VolumetricLocalLight *this, MethodInfo *method)
		{
		  __m128i v2; // xmm1
		  __int64 v3; // r8
		  Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
		
		  v2 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v4, method));
		  *(_DWORD *)(v3 + 48) = 1092616192;
		  *(_DWORD *)(v3 + 44) = 1065353216;
		  *(_DWORD *)(v3 + 68) = 1065353216;
		  *(_DWORD *)(v3 + 72) = 1056964608;
		  *(_DWORD *)(v3 + 76) = 1056964608;
		  *(__m128i *)(v3 + 28) = v2;
		  *(_DWORD *)(v3 + 56) = 1110441984;
		  *(_DWORD *)(v3 + 64) = 0x40000000;
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)v3, 0LL);
		}
		
	
		// Methods
		public FLocalLightData GetLocalLightData() => default; // 0x0000000189C53974-0x0000000189C53BEC
		// FLocalLightData GetLocalLightData()
		FLocalLightData *HG::Rendering::Runtime::VolumetricLocalLight::GetLocalLightData(
		        FLocalLightData *__return_ptr retstr,
		        VolumetricLocalLight *this,
		        MethodInfo *method)
		{
		  float v3; // xmm1_4
		  Beyond::DampingMath *v6; // rcx
		  int32_t v7; // esi
		  float InnerConeAngle; // xmm6_4
		  float v9; // xmm6_4
		  float v10; // xmm2_4
		  float v11; // xmm0_4
		  float LightIntensity; // xmm2_4
		  float v13; // xmm8_4
		  MethodInfo *v14; // r9
		  __m128 v15; // xmm7
		  Transform *transform; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Vector3 *position; // rax
		  __int64 v20; // xmm0_8
		  Transform *v21; // rax
		  Vector3 *forward; // rax
		  __int64 v23; // xmm1_8
		  MethodInfo *v24; // r8
		  Vector3 *v25; // rax
		  __int64 v26; // xmm4_8
		  Beyond::DampingMath *v27; // rcx
		  bool v28; // zf
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FLocalLightData *v34; // rax
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  FLocalLightData *result; // rax
		  Vector4 v38; // [rsp+28h] [rbp-49h] BYREF
		  Color LightColor; // [rsp+38h] [rbp-39h] BYREF
		  FLocalLightData v40; // [rsp+48h] [rbp-29h] BYREF
		
		  v7 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5128, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5128, 0LL);
		    if ( Patch )
		    {
		      v34 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1493(&v40, Patch, (Object *)this, 0LL);
		      v35 = *(_OWORD *)&v34->Color.x;
		      *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v34->Position.x;
		      v36 = *(_OWORD *)&v34->Direction.x;
		      *(_OWORD *)&retstr->Color.x = v35;
		      v31 = *(_OWORD *)&v34->SpotAngles.x;
		      *(_OWORD *)&retstr->Direction.x = v36;
		      v32 = *(_OWORD *)&v34->ShadowIntensity;
		      goto LABEL_16;
		    }
		LABEL_14:
		    sub_1800D8260(v18, v17);
		  }
		  InnerConeAngle = this->fields.InnerConeAngle;
		  if ( InnerConeAngle < 0.0 )
		  {
		    InnerConeAngle = 0.0;
		  }
		  else if ( InnerConeAngle > 89.0 )
		  {
		    InnerConeAngle = 89.0;
		  }
		  v9 = (float)(InnerConeAngle * 3.1415927) / 180.0;
		  v10 = (float)(this->fields.OuterConeAngle * 3.1415927) / 180.0;
		  if ( (float)(v9 + 0.001) > v10 )
		  {
		    v10 = v9 + 0.001;
		  }
		  else if ( v10 > 1.5543431 )
		  {
		    v10 = 1.5543431;
		  }
		  v11 = v10;
		  Beyond::DampingMath::cosf(v6, v3);
		  LightIntensity = this->fields.LightIntensity;
		  v13 = v11;
		  LightColor = this->fields.LightColor;
		  v15 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
		                                                   &v38,
		                                                   (Vector4 *)&LightColor,
		                                                   LightIntensity,
		                                                   v14));
		  sub_18033B9D0(&v40, 0LL, 80LL);
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_14;
		  position = UnityEngine::Transform::get_position((Vector3 *)&v38, transform, 0LL);
		  LODWORD(v40.Color.x) = v15.m128_i32[0];
		  v20 = *(_QWORD *)&position->x;
		  *(float *)&position = position->z;
		  *(_QWORD *)&v40.Position.x = v20;
		  LODWORD(v40.Color.z) = _mm_shuffle_ps(v15, v15, 170).m128_u32[0];
		  LODWORD(v40.Color.y) = _mm_shuffle_ps(v15, v15, 85).m128_u32[0];
		  *(float *)&v20 = this->fields.Radius;
		  LODWORD(v40.Position.z) = (_DWORD)position;
		  LODWORD(v40.Radius) = v20;
		  v40.InvRadius = 1.0 / *(float *)&v20;
		  v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v21 )
		    goto LABEL_14;
		  forward = UnityEngine::Transform::get_forward((Vector3 *)&LightColor, v21, 0LL);
		  v23 = *(_QWORD *)&forward->x;
		  *(float *)&forward = forward->z;
		  *(_QWORD *)&v38.x = v23;
		  LODWORD(v38.z) = (_DWORD)forward;
		  v25 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&LightColor, (Vector3 *)&v38, v24);
		  v26 = *(_QWORD *)&v25->x;
		  *(float *)&v25 = v25->z;
		  *(_QWORD *)&v40.Direction.x = v26;
		  LODWORD(v40.Direction.z) = (_DWORD)v25;
		  Beyond::DampingMath::cosf(v27, *(float *)&v23);
		  v40.SpotAngles.x = v13;
		  v40.SpotAngles.y = 1.0 / (float)(v9 - v13);
		  v40.bSpotLight = this->fields.LightType == 1;
		  v28 = !this->fields.bInverseSquared;
		  v29 = *(_OWORD *)&v40.Color.x;
		  *(_OWORD *)&v40.FalloffExponent = *(_OWORD *)&this->fields.FalloffExponent;
		  LOBYTE(v7) = !v28;
		  *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v40.Position.x;
		  v40.bInverseSquared = v7;
		  v30 = *(_OWORD *)&v40.Direction.x;
		  *(_OWORD *)&retstr->Color.x = v29;
		  v31 = *(_OWORD *)&v40.SpotAngles.x;
		  *(_OWORD *)&retstr->Direction.x = v30;
		  v32 = *(_OWORD *)&v40.ShadowIntensity;
		LABEL_16:
		  result = retstr;
		  *(_OWORD *)&retstr->SpotAngles.x = v31;
		  *(_OWORD *)&retstr->ShadowIntensity = v32;
		  return result;
		}
		
	}
}
