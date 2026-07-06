using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 84)]
	public struct HGFogConfig : IEnvConfig
	{
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_exists()
				// bool FlowCanvas::Nodes::TryGetValue<UnityEngine::Keyframe>::get_exists(
				//         TryGetValue_1_UnityEngine_Keyframe_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._exists_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_exists(Boolean)
				// void FlowCanvas::Nodes::TryGetValue<UnityEngine::Keyframe>::set_exists(
				//         TryGetValue_1_UnityEngine_Keyframe_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._exists_k__BackingField = value;
				// }
				// 
			}
		}

		public HGFogConfig(bool active)
		{
			// // HGFogConfig(Boolean)
			// void HG::Rendering::Runtime::HGFogConfig::HGFogConfig(HGFogConfig *this, bool active, MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   __int64 v4; // rdx
			//   Vector4 v5; // xmm1
			//   __int64 v6; // rdx
			//   Quaternion *identity; // rax
			//   Quaternion *v8; // rdx
			//   Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.enable = 0;
			//   *(_QWORD *)&this.startDistance = 1112014848LL;
			//   this.fallOffHeight = 50.0;
			//   this.fallOffDistance = 1.0;
			//   v3 = *UnityEngine::Vector4::get_one(&v9, (MethodInfo *)this);
			//   *(_DWORD *)(v4 + 36) = 1065353216;
			//   *(_DWORD *)(v4 + 40) = 1058642330;
			//   *(Vector4 *)(v4 + 20) = v3;
			//   v5 = *UnityEngine::Vector4::get_one(&v9, (MethodInfo *)v4);
			//   *(_DWORD *)(v6 + 60) = -1082130432;
			//   *(Vector4 *)(v6 + 44) = v5;
			//   identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v9, (MethodInfo *)v6);
			//   v8[4] = *identity;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用大气雾")]
		public bool enable;

		[UnclampedRangeExponential(0f, 2000f, 3f)]
		[Header("起始距离")]
		public float startDistance;

		[Header("起始高度")]
		[UnclampedRange(-100f, 100f)]
		public float startHeight;

		[Header("衰减")]
		[UnclampedRangeExponential(1f, 2000f, 5f)]
		public float fallOffHeight;

		[Header("距离衰减")]
		[UnclampedRangeExponential(0.01f, 1f, 5f)]
		public float fallOffDistance;

		[Header("散射")]
		public Color mieScattering;

		[RangeExponential(0f, 20f, 4f)]
		public float mieScatteringScale;

		[Range(0f, 0.6f)]
		public float mieAnisotropy;

		public Color rayleighScattering;

		[RangeExponential(0f, 2f, 4f)]
		public float rayleighScatteringScale;

		public Color inscatterAmbientColor;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGFogConfig defaultConfig;
	}
}
