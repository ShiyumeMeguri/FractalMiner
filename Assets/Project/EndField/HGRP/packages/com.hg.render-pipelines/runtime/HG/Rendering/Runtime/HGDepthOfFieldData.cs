using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class HGDepthOfFieldData
	{
		public HGDepthOfFieldData()
		{
			// // HGDepthOfFieldData()
			// void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(HGDepthOfFieldData *this, MethodInfo *method)
			// {
			//   this.fields.temporalFactor = 0.5;
			// }
			// 
		}

		public HGDepthOfFieldData(HGDepthOfFieldType type, float nearFocusStart, float nearFocusEnd, float nearRadius, float farFocusStart, float farFocusEnd, float farRadius)
		{
			// // HGDepthOfFieldData(HGDepthOfFieldType, Single, Single, Single, Single, Single, Single)
			// void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
			//         HGDepthOfFieldData *this,
			//         HGDepthOfFieldType__Enum type,
			//         float nearFocusStart,
			//         float nearFocusEnd,
			//         float nearRadius,
			//         float farFocusStart,
			//         float farFocusEnd,
			//         float farRadius,
			//         MethodInfo *method)
			// {
			//   this.fields.nearRadius = nearRadius;
			//   this.fields.farFocusStart = farFocusStart;
			//   this.fields.farFocusEnd = farFocusEnd;
			//   this.fields.farRadius = farRadius;
			//   this.fields.nearFocusStart = nearFocusStart;
			//   this.fields.nearFocusEnd = nearFocusEnd;
			//   this.fields.temporalFactor = 0.5;
			//   this.fields.mode = 1;
			//   this.fields.type = type;
			//   this.fields.scale = 1;
			// }
			// 
		}

		public HGDepthOfFieldData(HGDepthOfFieldFocusMode mode, HGDepthOfFieldType type, HGDepthOfFieldScale scale, float nearFocusStart, float nearFocusEnd, float nearRadius, float farFocusStart, float farFocusEnd, float farRadius, float temporalFactor)
		{
			// // HGDepthOfFieldData(HGDepthOfFieldFocusMode, HGDepthOfFieldType, HGDepthOfFieldScale, Single, Single, Single, Single, Single, Single, Single)
			// void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
			//         HGDepthOfFieldData *this,
			//         HGDepthOfFieldFocusMode__Enum mode,
			//         HGDepthOfFieldType__Enum type,
			//         HGDepthOfFieldScale__Enum scale,
			//         float nearFocusStart,
			//         float nearFocusEnd,
			//         float nearRadius,
			//         float farFocusStart,
			//         float farFocusEnd,
			//         float farRadius,
			//         float temporalFactor,
			//         MethodInfo *method)
			// {
			//   this.fields.nearFocusStart = nearFocusStart;
			//   this.fields.nearRadius = nearRadius;
			//   this.fields.nearFocusEnd = nearFocusEnd;
			//   this.fields.farFocusEnd = farFocusEnd;
			//   this.fields.farFocusStart = farFocusStart;
			//   this.fields.temporalFactor = temporalFactor;
			//   this.fields.farRadius = farRadius;
			//   this.fields.mode = mode;
			//   this.fields.type = type;
			//   this.fields.scale = scale;
			// }
			// 
		}

		public HGDepthOfFieldFocusMode mode;

		public HGDepthOfFieldType type;

		public HGDepthOfFieldScale scale;

		public float nearFocusStart;

		public float nearFocusEnd;

		public float nearRadius;

		public float farFocusStart;

		public float farFocusEnd;

		public float farRadius;

		[Min(0.1f)]
		public float temporalFactor;
	}
}
