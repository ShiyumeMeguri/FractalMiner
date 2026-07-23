using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class RangeExponentialAttribute : PropertyAttribute // TypeDefIndex: 37392
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
		public readonly float sliderExponent; // 0x18
	
		// Constructors
		public RangeExponentialAttribute() {} // Dummy constructor
		public RangeExponentialAttribute(float min, float max, float sliderExponent) {} // 0x0000000184DA1170-0x0000000184DA1180
		// UnclampedRangeExponentialAttribute(Single, Single, Single)
		void UnityEngine::UnclampedRangeExponentialAttribute::UnclampedRangeExponentialAttribute(
		        UnclampedRangeExponentialAttribute *this,
		        float min,
		        float max,
		        float sliderExponent,
		        MethodInfo *method)
		{
		  this->fields.min = min;
		  this->fields.max = max;
		  this->fields.sliderExponent = sliderExponent;
		}
		
	}
}
