using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
	public struct HGWindConfig : IEnvConfig
	{
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_value()
				// bool UnityEngine::Rendering::VolumeParameter<bool>::get_value(
				//         VolumeParameter_1_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_Value;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_value(Boolean)
				// void UnityEngine::Rendering::VolumeParameter<bool>::set_value(
				//         VolumeParameter_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Value = value;
				// }
				// 
			}
		}

		public HGWindConfig(bool active)
		{
			// // HGWindConfig(Boolean)
			// void HG::Rendering::Runtime::HGWindConfig::HGWindConfig(HGWindConfig *this, bool active, MethodInfo *method)
			// {
			//   this.verticalDirectionAngle = 0.0;
			//   this.m_active = 0;
			//   *(_QWORD *)&this.speed = 1065353216LL;
			//   *(_QWORD *)&this.direction.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.direction.z = 1.0;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Tooltip("当前 Env 的全局风速 (米/秒)")]
		[Range(0f, 30f)]
		public float speed;

		[Range(0f, 360f)]
		[Space(10f)]
		[Tooltip("水平面内的风向，0 为正北（z 轴正方向），90 为正东（x 轴正方向）")]
		public float horizontalDirectionAngle;

		[Tooltip("垂直方向风向，调整范围 -90 到 90")]
		[Range(-90f, 90f)]
		public float verticalDirectionAngle;

		[HideInInspector]
		public Vector3 direction;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGWindConfig defaultConfig;
	}
}
