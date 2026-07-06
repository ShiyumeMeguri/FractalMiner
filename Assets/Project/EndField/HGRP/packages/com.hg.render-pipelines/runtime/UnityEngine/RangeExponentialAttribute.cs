using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class RangeExponentialAttribute : PropertyAttribute
	{
		public RangeExponentialAttribute(float min, float max, float sliderExponent)
		{
			// // UnclampedRangeExponentialAttribute(Single, Single, Single)
			// void UnityEngine::UnclampedRangeExponentialAttribute::UnclampedRangeExponentialAttribute(
			//         UnclampedRangeExponentialAttribute *this,
			//         float min,
			//         float max,
			//         float sliderExponent,
			//         MethodInfo *method)
			// {
			//   this.fields.min = min;
			//   this.fields.max = max;
			//   this.fields.sliderExponent = sliderExponent;
			// }
			// 
		}

		public readonly float min;

		public readonly float max;

		public readonly float sliderExponent;
	}
}
