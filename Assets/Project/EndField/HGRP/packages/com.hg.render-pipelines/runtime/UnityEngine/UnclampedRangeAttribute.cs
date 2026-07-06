using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class UnclampedRangeAttribute : PropertyAttribute
	{
		public UnclampedRangeAttribute(float min, float max)
		{
			// // MinMaxRangeAttribute(Single, Single)
			// void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
			//         MinMaxRangeAttribute *this,
			//         float min,
			//         float max,
			//         MethodInfo *method)
			// {
			//   this.fields._minValue_k__BackingField = min;
			//   this.fields._maxValue_k__BackingField = max;
			// }
			// 
		}

		public readonly float min;

		public readonly float max;
	}
}
