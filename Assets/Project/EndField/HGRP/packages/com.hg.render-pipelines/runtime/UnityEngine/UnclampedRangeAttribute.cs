using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class UnclampedRangeAttribute : PropertyAttribute // TypeDefIndex: 37391
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public UnclampedRangeAttribute() {} // Dummy constructor
		public UnclampedRangeAttribute(float min, float max) {} // 0x0000000184D8D120-0x0000000184D8D130
		// MinMaxRangeAttribute(Single, Single)
		void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
		        MinMaxRangeAttribute *this,
		        float min,
		        float max,
		        MethodInfo *method)
		{
		  this->fields._minValue_k__BackingField = min;
		  this->fields._maxValue_k__BackingField = max;
		}
		
	}
}
