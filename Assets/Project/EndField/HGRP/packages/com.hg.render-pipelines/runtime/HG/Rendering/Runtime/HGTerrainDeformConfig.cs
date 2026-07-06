using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct HGTerrainDeformConfig : IEnvConfig
	{
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_Value()
				// bool System::Collections::Generic::KeyValuePair<unsigned long,bool>::get_Value(
				//         KeyValuePair_2_System_UInt64_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.value;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_isWorking(Boolean)
				// void Beyond::Login::LoginWorkFlow::FWork::set_isWorking(LoginWorkFlow_FWork *this, bool value, MethodInfo *method)
				// {
				//   this._isWorking_k__BackingField = value;
				// }
				// 
			}
		}

		public HGTerrainDeformConfig(bool active)
		{
			// // HGTerrainDeformConfig(Boolean)
			// void HG::Rendering::Runtime::HGTerrainDeformConfig::HGTerrainDeformConfig(
			//         HGTerrainDeformConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   this.m_active = 0;
			//   *(_QWORD *)&this.deformGlobalStrength = 0LL;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Range(0f, 1f)]
		[Header("全局地形形变强度")]
		public float deformGlobalStrength;

		[Range(0f, 1f)]
		[Header("生效延迟")]
		public float latency;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGTerrainDeformConfig defaultConfig;
	}
}
