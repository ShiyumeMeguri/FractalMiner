using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGInkSimulationConfig : IEnvConfig
	{
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_changed()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_override(Boolean)
				// void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_override(
				//         ScalableSettingValue_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Override = value;
				// }
				// 
			}
		}

		public HGInkSimulationConfig(bool active)
		{
			// // HGInkSimulationConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGInkSimulationConfig::HGInkSimulationConfig(
			//         HGInkSimulationConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   String__Array *v4; // [rsp+28h] [rbp+28h]
			//   String *v5; // [rsp+30h] [rbp+30h]
			//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
			// 
			//   this.m_active = 0;
			//   this.influence = 0.0;
			//   this.material = 0LL;
			//   this.disableWaterInk = 1;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.material,
			//     (OneofDescriptorProto *)active,
			//     (FileDescriptor *)method,
			//     v3,
			//     v4,
			//     v5,
			//     v6);
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("全局强度")]
		[Range(0f, 1f)]
		public float influence;

		[Header("禁止水体水墨功能")]
		public bool disableWaterInk;

		[Header("材质")]
		public Material material;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGInkSimulationConfig defaultConfig;
	}
}
