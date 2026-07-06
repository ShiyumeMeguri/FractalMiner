using System;
using Beyond;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterConfig", menuName = "HGWater/HGWaterInteractiveSetting")]
	public class HGWaterInteractiveSetting : ScriptableObject
	{
		public HGWaterInteractiveSetting()
		{
			// // HGWaterInteractiveSetting()
			// void HG::Rendering::Runtime::HGWaterInteractiveSetting::HGWaterInteractiveSetting(
			//         HGWaterInteractiveSetting *this,
			//         MethodInfo *method)
			// {
			//   this.fields.rippleNormalStrengthMultiplierPC = 1.0;
			//   this.fields.rippleNormalStrengthMultiplierMobile = 1.0;
			//   this.fields.characterSpeedRippleFrequencyInfluence = 0.1;
			//   this.fields.characterSpeedRippleSizeInfluence = 0.1;
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		[Header("水体扩散收敛速度")]
		[Range(0.95f, 1f)]
		public float interactiveDamp;

		[Range(0f, 1f)]
		[Header("水体扩散Alpha")]
		public float interactiveAlpha;

		[Header("水体扩散Beta")]
		[Range(0f, 1f)]
		public float interactiveBeta;

		[Header("水体扩散速度")]
		[Range(0f, 1f)]
		public float interactiveSpeed;

		[Range(0f, 1f)]
		[Header("角色周围Ripple模拟大小")]
		public float interactiveRippleSize;

		[Header("角色周围Ripple向前偏移距离")]
		[Range(0f, 1f)]
		public float interactiveRippleForwardOffset;

		[Header("静止涟漪产生频率")]
		[Range(0f, 0.2f)]
		public float stillRippleFrequency;

		[Header("运动涟漪产生频率")]
		[Range(0f, 1f)]
		public float moveRippleFrequency;

		[Header("PC交互水波法线强度(包括ps5平台)")]
		[Range(0f, 5f)]
		public float rippleNormalStrengthMultiplierPC;

		[Header("Mobile交互水波法线强度")]
		[Range(0f, 5f)]
		public float rippleNormalStrengthMultiplierMobile;

		[Range(0f, 1f)]
		[Header("角色速度对Ripple频率影响")]
		public float characterSpeedRippleFrequencyInfluence;

		[Range(0f, 1f)]
		[Header("角色速度对Ripple大小影响")]
		public float characterSpeedRippleSizeInfluence;

		[Header("地形水波强度配置")]
		public float rippleStrengthLerpTime;

		public SerializeFieldDictionary<ColliderSurfaceType, float> terrainRippleStrengthConfig;
	}
}
