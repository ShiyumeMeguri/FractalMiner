using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
	public struct HGPhysicalCamera
	{
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000025D0 File Offset: 0x000007D0
		public float focusDistance
		{
			get
			{
				// // Single get_Value()
				// float System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::get_Value(
				//         KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.value;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_focusDistance(Single)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_focusDistance(
				//         HGPhysicalCamera *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.m_FocusDistance = fmaxf(value, 0.1);
				// }
				// 
			}
		}

		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x000025D0 File Offset: 0x000007D0
		public int iso
		{
			get
			{
				// // UInt32 ReadUnaligned[UInt32](Byte ByRef)
				// uint32_t System::Runtime::CompilerServices::Unsafe::ReadUnaligned<unsigned int>(uint8_t *source, MethodInfo *method)
				// {
				//   return *(_DWORD *)source;
				// }
				// 
				return 0;
			}
			set
			{
				// // Void set_iso(Int32)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_iso(HGPhysicalCamera *this, int32_t value, MethodInfo *method)
				// {
				//   if ( value <= 1 )
				//     value = 1;
				//   this.m_Iso = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x000025D0 File Offset: 0x000007D0
		public float shutterSpeed
		{
			get
			{
				// // Single GetValueOrDefault()
				// float System::Nullable<float>::GetValueOrDefault(Nullable_1_Single_ *this, MethodInfo *method)
				// {
				//   return this.value;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_shutterSpeed(Single)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_shutterSpeed(
				//         HGPhysicalCamera *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.m_ShutterSpeed = fmaxf(value, 0.0);
				// }
				// 
			}
		}

		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x000025D0 File Offset: 0x000007D0
		public float aperture
		{
			get
			{
				// // Single get_Value()
				// float System::Collections::Generic::KeyValuePair<unsigned long,float>::get_Value(
				//         KeyValuePair_2_System_UInt64_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.value;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_aperture(Single)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_aperture(HGPhysicalCamera *this, float value, MethodInfo *method)
				// {
				//   float v3; // xmm0_4
				// 
				//   v3 = 0.69999999;
				//   if ( value < 0.69999999 || (v3 = 32.0, value > 32.0) )
				//     this.m_Aperture = v3;
				//   else
				//     this.m_Aperture = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x000025D0 File Offset: 0x000007D0
		public int bladeCount
		{
			get
			{
				// // MjfRFftkTcBeBOoxrCKsCyjeiVkX get_Current()
				// MjfRFftkTcBeBOoxrCKsCyjeiVkX Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<MjfRFftkTcBeBOoxrCKsCyjeiVkX>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_MjfRFftkTcBeBOoxrCKsCyjeiVkX_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return 0;
			}
			set
			{
				// // Void set_bladeCount(Int32)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_bladeCount(
				//         HGPhysicalCamera *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   if ( value < 3 )
				//   {
				//     this.m_BladeCount = 3;
				//   }
				//   else if ( value <= 11 )
				//   {
				//     this.m_BladeCount = value;
				//   }
				//   else
				//   {
				//     this.m_BladeCount = 11;
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector2 curvature
		{
			get
			{
				// // float2 get_Current()
				// float2 Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Unity::Mathematics::float2>::get_Current(
				//         NativeArray_1_T_ReadOnly_T_Enumerator_Unity_Mathematics_float2_ *this,
				//         MethodInfo *method)
				// {
				//   return (float2)_mm_unpacklo_ps((__m128)LODWORD(this.value.x), (__m128)LODWORD(this.value.y)).m128_u64[0];
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_curvature(Vector2)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_curvature(HGPhysicalCamera *this, Vector2 value, MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(674, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(674, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, this, value, 0LL);
				//   }
				//   else
				//   {
				//     this.m_Curvature.x = fmaxf(value.x, 0.69999999);
				//     this.m_Curvature.y = fminf(value.y, 32.0);
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x000025D0 File Offset: 0x000007D0
		public float barrelClipping
		{
			get
			{
				// // Single GetMin()
				// float Beyond::Gameplay::OnlineProfilerData<float>::GetMin(
				//         OnlineProfilerData_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_minValue;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_tipRotationWeight(Single)
				// void UnityEngine::Animations::Rigging::ChainIKConstraintData::set_tipRotationWeight(
				//         ChainIKConstraintData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				// 
				//   Beyond::JobMathf::Clamp01((Beyond::JobMathf *)this);
				//   *(float *)(v3 + 28) = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x000025D0 File Offset: 0x000007D0
		public float anamorphism
		{
			get
			{
				// // Single get_idleThreshold()
				// float Beyond::Resource::SmartLRUCache<System::Object,System::Object>::get_idleThreshold(
				//         SmartLRUCache_2_System_Object_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_idleThreshold;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_anamorphism(Single)
				// void HG::Rendering::Runtime::HGPhysicalCamera::set_anamorphism(HGPhysicalCamera *this, float value, MethodInfo *method)
				// {
				//   float v3; // xmm0_4
				// 
				//   v3 = -1.0;
				//   if ( value < -1.0 || (v3 = 1.0, value > 1.0) )
				//     this.m_Anamorphism = v3;
				//   else
				//     this.m_Anamorphism = value;
				// }
				// 
			}
		}

		[Obsolete("The CopyTo method is obsolete and does not work anymore. Use the assignement operator instead to get a copy of the HGPhysicalCamera parameters.", true)]
		public void CopyTo(HGPhysicalCamera c)
		{
			// // Void CopyTo(HGPhysicalCamera)
			// void HG::Rendering::Runtime::HGPhysicalCamera::CopyTo(HGPhysicalCamera *this, HGPhysicalCamera *c, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float m_Anamorphism; // eax
			//   __int128 v8; // xmm1
			//   HGPhysicalCamera v9; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2291, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2291, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v5);
			//     m_Anamorphism = c.m_Anamorphism;
			//     v8 = *(_OWORD *)&c.m_BladeCount;
			//     *(_OWORD *)&v9.m_Iso = *(_OWORD *)&c.m_Iso;
			//     *(_OWORD *)&v9.m_BladeCount = v8;
			//     v9.m_Anamorphism = m_Anamorphism;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_827(Patch, this, &v9, 0LL);
			//   }
			// }
			// 
		}

		public static HGPhysicalCamera GetDefaults()
		{
			// // HGPhysicalCamera GetDefaults()
			// HGPhysicalCamera *HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(
			//         HGPhysicalCamera *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   Beyond::JobMathf *v3; // rcx
			//   __m128 v4; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   HGPhysicalCamera *v9; // rax
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   HGPhysicalCamera v12; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(673, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(673, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(&v12, Patch, 0LL);
			//     v10 = *(_OWORD *)&v9.m_Iso;
			//     v11 = *(_OWORD *)&v9.m_BladeCount;
			//     *(float *)&v9 = v9.m_Anamorphism;
			//     *(_OWORD *)&retstr.m_Iso = v10;
			//     *(_OWORD *)&retstr.m_BladeCount = v11;
			//     LODWORD(retstr.m_Anamorphism) = (_DWORD)v9;
			//   }
			//   else
			//   {
			//     *(_OWORD *)&v12.m_Curvature.x = 0LL;
			//     v12.m_Iso = 200;
			//     v12.m_ShutterSpeed = 0.0049999999;
			//     v12.m_Aperture = 16.0;
			//     v12.m_FocusDistance = 10.0;
			//     v12.m_BladeCount = 5;
			//     HG::Rendering::Runtime::HGPhysicalCamera::set_curvature(
			//       &v12,
			//       (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x41300000u),
			//       0LL);
			//     Beyond::JobMathf::Clamp01(v3);
			//     v4 = _mm_shuffle_ps(*(__m128 *)&v12.m_BladeCount, *(__m128 *)&v12.m_BladeCount, 147);
			//     *(_OWORD *)&retstr.m_Iso = *(_OWORD *)&v12.m_Iso;
			//     v4.m128_f32[0] = 0.25;
			//     *(__m128 *)&retstr.m_BladeCount = _mm_shuffle_ps(v4, v4, 57);
			//     retstr.m_Anamorphism = 0.0;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public const float kMinAperture = 0.7f;

		public const float kMaxAperture = 32f;

		public const int kMinBladeCount = 3;

		public const int kMaxBladeCount = 11;

		[SerializeField]
		[Min(1f)]
		private int m_Iso;

		[SerializeField]
		[Min(0f)]
		private float m_ShutterSpeed;

		[Range(0.7f, 32f)]
		[SerializeField]
		private float m_Aperture;

		[Min(0.1f)]
		[SerializeField]
		private float m_FocusDistance;

		[Range(3f, 11f)]
		[SerializeField]
		private int m_BladeCount;

		[SerializeField]
		private Vector2 m_Curvature;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_BarrelClipping;

		[SerializeField]
		[Range(-1f, 1f)]
		private float m_Anamorphism;
	}
}
