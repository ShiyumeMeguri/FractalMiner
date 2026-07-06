using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGCloudShadowConfig : IEnvConfig
	{
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_alwaysRebindOnRefresh()
				// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
				//         VerticalVirtualizationController_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 1;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}
		}

		public HGCloudShadowConfig(bool active)
		{
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("云影贴图")]
		public Texture2D cloudShadowTexture;

		[Header("场景中心点")]
		public Vector3 cloudShadowEnvCenter;

		[Range(0.1f, 10f)]
		[Header("云影贴图覆盖范围（km）")]
		public float cloudShadowCoverage;

		[RangeExponential(0f, 1000f, 2f)]
		[Header("云影移动速度（m/s）")]
		public float cloudShadowFlowSpeed;

		[Header("云影移动方向")]
		public Vector2 cloudShadowFlowDirection;

		[Range(0f, 1f)]
		[Header("云影整体不透明度")]
		public float cloudShadowAlpha;

		[Header("云影距离UV缩放")]
		public float cloudShadowDistanceScale;

		[Range(1f, 4096f)]
		[Header("云影距离UV缩放起始距离")]
		public float cloudShadowScaleStartDistance;

		[UnclampedRange(1f, 10000f)]
		[Header("云影距离UV缩放结束范围")]
		public float cloudShadowScaleEndDistance;
	}
}
