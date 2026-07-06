using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGStarConfig : IEnvConfig
	{
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean HasRenderFunc()
				// bool HG::Rendering::RenderGraphModule::HGRenderGraphPass<System::Object>::HasRenderFunc(
				//         HGRenderGraphPass_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.hasRenderFunc;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_applyTargetAlpha(Boolean)
				// void CriWare::CriMana::Player::set_applyTargetAlpha(Player *this, bool value, MethodInfo *method)
				// {
				//   this.fields._applyTargetAlpha_k__BackingField = value;
				// }
				// 
			}
		}

		public HGStarConfig(bool active)
		{
			// // HGStarConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGStarConfig::HGStarConfig(HGStarConfig *this, bool active, MethodInfo *method)
			// {
			//   __int64 v3; // r9
			//   __int64 v4; // r10
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   PassConstructorID__Enum__Array *v6; // r8
			//   __int64 v7; // r9
			//   int v8; // r10d
			//   MethodInfo *v9; // rdx
			//   Vector4 *one; // rax
			//   Vector4 *v11; // r9
			//   MethodInfo *v12; // rdx
			//   Vector4 *v13; // rax
			//   Vector4 *v14; // r9
			//   MethodInfo *v15; // rdx
			//   Vector4 v16; // xmm1
			//   __int64 v17; // r9
			//   __int64 v18; // r10
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   __int64 v21; // r9
			//   char v22; // r10
			//   MethodInfo *v23; // rdx
			//   Vector4 v24; // xmm1
			//   __int64 v25; // r9
			//   int v26; // r10d
			//   Vector4 v27; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.enableStars = 0;
			//   this.skyboxStarNoiseMap = 0LL;
			//   this.starType = 1;
			//   this.starsSize = 1.0;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.skyboxStarNoiseMap,
			//     (HGRenderPathBase_HGRenderPathResources *)active,
			//     (PassConstructorID__Enum__Array *)method,
			//     (HGCamera *)this,
			//     *(MethodInfo **)&v27.x,
			//     *(MethodInfo **)&v27.z);
			//   *(_QWORD *)(v3 + 128) = v4;
			//   sub_1800054D0((HGRenderPathScene *)(v3 + 128), v5, v6, (HGCamera *)v3, *(MethodInfo **)&v27.x, *(MethodInfo **)&v27.z);
			//   *(_DWORD *)(v7 + 12) = v8;
			//   one = UnityEngine::Vector4::get_one(&v27, v9);
			//   v11[1] = *one;
			//   v13 = UnityEngine::Vector4::get_one(&v27, v12);
			//   v14[3] = *v13;
			//   v16 = *UnityEngine::Vector4::get_one(&v27, v15);
			//   *(_QWORD *)(v17 + 40) = v18;
			//   *(_QWORD *)(v17 + 72) = v18;
			//   *(Vector4 *)(v17 + 80) = v16;
			//   *(_QWORD *)(v17 + 104) = v18;
			//   *(_DWORD *)(v17 + 36) = 1065353216;
			//   *(_DWORD *)(v17 + 68) = 1065353216;
			//   *(_DWORD *)(v17 + 100) = 1065353216;
			//   *(_QWORD *)(v17 + 136) = v18;
			//   *(_DWORD *)(v17 + 112) = v18;
			//   *(_QWORD *)(v17 + 152) = v18;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)(v17 + 152),
			//     v19,
			//     v20,
			//     (HGCamera *)v17,
			//     *(MethodInfo **)&v27.x,
			//     *(MethodInfo **)&v27.z);
			//   *(_BYTE *)(v21 + 144) = v22;
			//   v24 = *UnityEngine::Vector4::get_one(&v27, v23);
			//   *(_DWORD *)(v25 + 180) = 1036831949;
			//   *(_DWORD *)(v25 + 176) = v26;
			//   *(Vector4 *)(v25 + 160) = v24;
			//   *(_DWORD *)(v25 + 32) = v26;
			//   *(_DWORD *)(v25 + 64) = v26;
			//   *(_DWORD *)(v25 + 96) = v26;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("绘制群星")]
		public bool enableStars;

		[Header("星星密度来源")]
		public HGStarConfig.StarType starType;

		[Header("星星总密度Tilling")]
		[UnclampedRange(0.5f, 2f)]
		public float starsSize;

		[UnclampedRange(0.001f, 0.1f)]
		[Header("星星闪烁速度")]
		public float starsFlickerSpeed;

		[Header("星星颜色0")]
		public Color starsTint;

		[Header("星星位置随机Seed0")]
		public float starsOffset0;

		[Header("星星密度R")]
		[UnclampedRange(0.1f, 3f)]
		public float starsDensityR;

		[Header("星星大小1")]
		[UnclampedRange(0.001f, 1f)]
		public float starsDensity;

		[Header("星星曝光度1")]
		[UnclampedRange(0f, 1000f)]
		public float starsExposure;

		[Header("星星颜色1")]
		public Color starsTint1;

		[Header("星星位置随机Seed1")]
		public float starsOffset1;

		[Header("星星密度G")]
		[UnclampedRange(0.1f, 2f)]
		public float starsDensityG;

		[Header("星星大小2")]
		[UnclampedRange(0.001f, 1f)]
		public float starsDensity1;

		[UnclampedRange(0f, 1000f)]
		[Header("星星曝光度2")]
		public float starsExposure1;

		[Header("星星颜色2")]
		public Color starsTint2;

		[Header("星星位置随机Seed1")]
		public float starsOffset2;

		[Header("星星密度B")]
		[UnclampedRange(0.1f, 2f)]
		public float starsDensityB;

		[Header("星星大小3")]
		[UnclampedRange(0.001f, 1f)]
		public float starsDensity2;

		[Header("星星曝光度3")]
		[UnclampedRange(0f, 1000f)]
		public float starsExposure2;

		[Header("星星分层显示")]
		public HGStarConfig.StarLayerViewMode starLayerViewMode;

		[Header("星群噪声图 Map")]
		public Texture skyboxStarNoiseMap;

		[Header("星群Mask图")]
		public Texture skyBoxStarRangeMap;

		[Header("星群Mask图旋转")]
		[UnclampedRange(0f, 360f)]
		public float skyBoxStarDensityMapRotation;

		[Header("星群Mask图DebugMode")]
		public HGStarConfig.DebugMode debugMode;

		[Header("绘制星云")]
		public bool enableNebula;

		[Header("星云贴图")]
		public Texture nebulaMap;

		[Header("星云贴图颜色")]
		public Color nebulaTint;

		[Header("星云贴图旋转")]
		[UnclampedRange(0f, 360f)]
		public float nebulaMapRotation;

		[Header("星云对星星的遮蔽性")]
		[UnclampedRange(-5f, 10f)]
		public float nebulaStarConverage;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGStarConfig defaultConfig;

		public enum StarType
		{
			RealTimeNoise,
			BakedMap
		}

		public enum DebugMode
		{
			Material,
			RChannel,
			GChannel,
			BChannel,
			RGBChannel
		}

		public enum StarLayerViewMode
		{
			FullLayer,
			RLayer,
			GLayer,
			BLayer
		}
	}
}
