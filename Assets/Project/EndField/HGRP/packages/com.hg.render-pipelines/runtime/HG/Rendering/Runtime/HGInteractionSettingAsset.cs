using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGInteractionSettingAsset", menuName = "HGInteraction/HGInteractionSettingAsset")]
	public class HGInteractionSettingAsset : ScriptableObject
	{
		public HGInteractionSettingAsset()
		{
			// // HGInteractionSettingAsset()
			// void HG::Rendering::Runtime::HGInteractionSettingAsset::HGInteractionSettingAsset(
			//         HGInteractionSettingAsset *this,
			//         MethodInfo *method)
			// {
			//   this.fields.decalNodeWidth = 0.15000001;
			//   this.fields.decalNodeLength = 0.25;
			//   this.fields.decalNodeHeadLength = 0.25;
			//   this.fields.decalNodeOffset = 0.15000001;
			//   this.fields.nodeDistanceThreshold = 0.2;
			//   this.fields.edgeFadeDistance = 0.2;
			//   this.fields.heightFadeDistanceMin = 0.1;
			//   this.fields.heightFadeDistanceMax = 0.15000001;
			//   this.fields.rotationThreshold = 0.89999998;
			//   this.fields.timeFadeSpeed = 0.15000001;
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public Material decalInteractionMaterial;

		public float decalNodeWidth;

		public float decalNodeLength;

		public float decalNodeHeadLength;

		[Range(-1f, 1f)]
		public float decalNodeOffset;

		[Range(0f, 0.5f)]
		public float nodeDistanceThreshold;

		[Range(0f, 1f)]
		public float edgeFadeDistance;

		[Range(0f, 1f)]
		public float heightFadeDistanceMin;

		[Range(0f, 1f)]
		public float heightFadeDistanceMax;

		[Range(-1f, 1f)]
		public float rotationThreshold;

		[Range(-1f, 1f)]
		public float backwardDistanceThreshold;

		[Range(0f, 1f)]
		public float timeFadeSpeed;
	}
}
