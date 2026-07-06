using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 72)]
	public struct HGSnowConfig : IEnvConfig
	{
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_Preview()
				// bool PaintIn3D::P3dHitThrough::get_Preview(P3dHitThrough *this, MethodInfo *method)
				// {
				//   return this.fields.preview;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_Preview(Boolean)
				// void PaintIn3D::P3dHitThrough::set_Preview(P3dHitThrough *this, bool value, MethodInfo *method)
				// {
				//   this.fields.preview = value;
				// }
				// 
			}
		}

		public HGSnowConfig(bool active)
		{
			// // HGSnowConfig(Boolean)
			// void HG::Rendering::Runtime::HGSnowConfig::HGSnowConfig(HGSnowConfig *this, bool active, MethodInfo *method)
			// {
			//   ITilemap *v3; // r9
			//   TileAnimationData v4; // xmm1
			//   __int64 v5; // rdx
			//   __int64 v6; // r8
			//   TileAnimationData v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   *(_QWORD *)&this.intensity = 0LL;
			//   this.enable = 0;
			//   v4 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//           &v7,
			//           (TileBase *)this,
			//           0LL,
			//           v3,
			//           (MethodInfo *)v7.m_AnimatedSprites);
			//   *(_QWORD *)(v5 + 36) = v6;
			//   *(_QWORD *)(v5 + 44) = v6;
			//   *(TileAnimationData *)(v5 + 12) = v4;
			//   *(_DWORD *)(v5 + 28) = v6;
			//   *(_QWORD *)(v5 + 56) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   *(_DWORD *)(v5 + 64) = 0;
			//   *(_DWORD *)(v5 + 32) = 1036831949;
			//   *(_DWORD *)(v5 + 52) = 1065353216;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用下雪")]
		public bool enable;

		[Range(0f, 100f)]
		public float intensity;

		[Range(0f, 20f)]
		public float speed;

		public Color color;

		public Vector2 snowSizeRange;

		[Range(0f, 360f)]
		public float horizontalSnowAngle;

		[Range(0f, 1f)]
		public float horizontalSnowLevel;

		[Range(0f, 1f)]
		public float snowJitterLevel;

		[Range(0f, 1f)]
		public float snowLightingPercent;

		[Range(0.01f, 60f)]
		public float snowCollisionFadeTimeScale;

		[HideInInspector]
		public Vector3 snowDirection;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGSnowConfig defaultConfig;
	}
}
