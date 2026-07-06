using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 52)]
	public struct HGLightShaftConfig : IEnvConfig
	{
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool lightShaftOcclusionActive
		{
			get
			{
				// // Boolean get_lightShaftOcclusionActive()
				// bool HG::Rendering::Runtime::HGLightShaftConfig::get_lightShaftOcclusionActive(
				//         HGLightShaftConfig *this,
				//         MethodInfo *method)
				// {
				//   return this.enable && this.enableOcclusion;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // NodeColor get_Color()
				// NodeColor__Enum System::Collections::Generic::SortedSet_1_T_::Node<System::ValueTuple<float,System::Object>>::get_Color(
				//         SortedSet_1_T_Node_System_ValueTuple_2_Single_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Color_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_Color(NodeColor)
				// void System::Collections::Generic::SortedSet_1_T_::Node<System::ValueTuple<float,System::Object>>::set_Color(
				//         SortedSet_1_T_Node_System_ValueTuple_2_Single_Object_ *this,
				//         NodeColor__Enum value,
				//         MethodInfo *method)
				// {
				//   this.fields._Color_k__BackingField = value;
				// }
				// 
			}
		}

		public HGLightShaftConfig(bool active)
		{
			// // HGLightShaftConfig(Boolean)
			// void HG::Rendering::Runtime::HGLightShaftConfig::HGLightShaftConfig(
			//         HGLightShaftConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   __int64 v4; // rdx
			//   Vector4 v5; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.enable = 0;
			//   *(_QWORD *)&this.bloomScale = 1045220557LL;
			//   this.bloomMaxBrightness = 100.0;
			//   v3 = *UnityEngine::Vector4::get_one(&v5, (MethodInfo *)this);
			//   *(_DWORD *)(v4 + 32) = 1061997773;
			//   *(_DWORD *)(v4 + 36) = 1148846080;
			//   *(Vector4 *)(v4 + 16) = v3;
			//   *(_BYTE *)(v4 + 40) = 0;
			//   *(_DWORD *)(v4 + 44) = 1028443341;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用光束泛光")]
		public bool enable;

		[Range(0f, 10f)]
		[Header("泛光强度")]
		public float bloomScale;

		[Header("泛光阈值")]
		[Range(0f, 4f)]
		public float bloomThreshold;

		[RangeExponential(0f, 100f, 5f)]
		[Header("泛光最高亮度")]
		public float bloomMaxBrightness;

		[Header("泛光色调")]
		public Color bloomTint;

		[Range(0f, 1f)]
		[Header("泛光扩散程度")]
		public float blurIntensity;

		[Range(0f, 5000f)]
		[Header("泛光遮挡深度范围")]
		public float occlusionDepthRange;

		[Header("启用光束遮蔽")]
		public bool enableOcclusion;

		[Header("遮蔽遮罩暗度")]
		[Range(0f, 1f)]
		public float occlusionMaskDarkness;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGLightShaftConfig defaultConfig;
	}
}
