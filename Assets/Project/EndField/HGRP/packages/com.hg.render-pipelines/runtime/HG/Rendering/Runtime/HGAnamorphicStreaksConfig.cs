using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	public struct HGAnamorphicStreaksConfig : IEnvConfig
	{
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_Rotate()
				// bool CW::Common::CwFollow::get_Rotate(CwFollow *this, MethodInfo *method)
				// {
				//   return this.fields.rotate;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_Rotate(Boolean)
				// void CW::Common::CwFollow::set_Rotate(CwFollow *this, bool value, MethodInfo *method)
				// {
				//   this.fields.rotate = value;
				// }
				// 
			}
		}

		public HGAnamorphicStreaksConfig(bool active)
		{
			// // HGAnamorphicStreaksConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGAnamorphicStreaksConfig::HGAnamorphicStreaksConfig(
			//         HGAnamorphicStreaksConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   __int64 v4; // r8
			//   Vector4 v5; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = active;
			//   this.enable = 0;
			//   this.bloomScale = 1.0;
			//   this.bloomThreshold = 4.0;
			//   this.bloomMaxBrightness = 100.0;
			//   v3 = *UnityEngine::Vector4::get_one(&v5, (MethodInfo *)active);
			//   *(_QWORD *)(v4 + 32) = 1060320051LL;
			//   *(_DWORD *)(v4 + 40) = 0;
			//   *(Vector4 *)(v4 + 16) = v3;
			// }
			// 
		}

		public Vector2 GetBlurDir()
		{
			// // Vector2 GetBlurDir()
			// Vector2 HG::Rendering::Runtime::HGAnamorphicStreaksConfig::GetBlurDir(
			//         HGAnamorphicStreaksConfig *this,
			//         MethodInfo *method)
			// {
			//   __int128 blurDirAngle_low; // xmm7
			//   __m128 v4; // xmm6
			//   __m128 v5; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1179, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1179, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_439(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     blurDirAngle_low = LODWORD(this.blurDirAngle);
			//     v4 = (__m128)COERCE_UNSIGNED_INT64(Beyond::DampingMath::cosf());
			//     v5.m128_u64[1] = *((_QWORD *)&blurDirAngle_low + 1);
			//     *(double *)v5.m128_u64 = Beyond::DampingMath::sinf();
			//     return (Vector2)_mm_unpacklo_ps(v4, v5).m128_u64[0];
			//   }
			// }
			// 
			return null;
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用条状泛光")]
		public bool enable;

		[Range(0f, 10f)]
		[Header("泛光强度")]
		public float bloomScale;

		[Min(0f)]
		[Header("泛光阈值")]
		public float bloomThreshold;

		[Range(0f, 100f)]
		[Header("泛光最高亮度")]
		public float bloomMaxBrightness;

		[Header("泛光色调")]
		[ColorUsage(false, true)]
		public Color bloomTint;

		[Range(0f, 1f)]
		[Header("泛光扩散程度")]
		public float blurIntensity;

		[Range(0f, 180f)]
		[Header("泛光方向")]
		public float blurDirAngle;

		[Header("过滤像素大小")]
		public AnamorphicStreaksFilterSize filterSize;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGAnamorphicStreaksConfig defaultConfig;
	}
}
