using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class HGDepthOfFieldData // TypeDefIndex: 38040
	{
		// Fields
		public HGDepthOfFieldFocusMode mode; // 0x10
		public HGDepthOfFieldType type; // 0x14
		public HGDepthOfFieldScale scale; // 0x18
		public float nearFocusStart; // 0x1C
		public float nearFocusEnd; // 0x20
		public float nearRadius; // 0x24
		public float farFocusStart; // 0x28
		public float farFocusEnd; // 0x2C
		public float farRadius; // 0x30
		[Min(0.1f)]
		public float temporalFactor; // 0x34
	
		// Constructors
		public HGDepthOfFieldData() {} // 0x0000000184DA15A0-0x0000000184DA15B0
		// HGDepthOfFieldData()
		void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(HGDepthOfFieldData *this, MethodInfo *method)
		{
		  this->fields.temporalFactor = 0.5;
		}
		
		public HGDepthOfFieldData(HGDepthOfFieldType type, float nearFocusStart, float nearFocusEnd, float nearRadius, float farFocusStart, float farFocusEnd, float farRadius) {} // 0x0000000184DA14F0-0x0000000184DA1540
		// HGDepthOfFieldData(HGDepthOfFieldType, Single, Single, Single, Single, Single, Single)
		void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
		        HGDepthOfFieldData *this,
		        HGDepthOfFieldType__Enum type,
		        float nearFocusStart,
		        float nearFocusEnd,
		        float nearRadius,
		        float farFocusStart,
		        float farFocusEnd,
		        float farRadius,
		        MethodInfo *method)
		{
		  this->fields.nearRadius = nearRadius;
		  this->fields.farFocusStart = farFocusStart;
		  this->fields.farFocusEnd = farFocusEnd;
		  this->fields.farRadius = farRadius;
		  this->fields.nearFocusStart = nearFocusStart;
		  this->fields.nearFocusEnd = nearFocusEnd;
		  this->fields.temporalFactor = 0.5;
		  this->fields.mode = 1;
		  this->fields.type = type;
		  this->fields.scale = 1;
		}
		
		public HGDepthOfFieldData(HGDepthOfFieldFocusMode mode, HGDepthOfFieldType type, HGDepthOfFieldScale scale, float nearFocusStart, float nearFocusEnd, float nearRadius, float farFocusStart, float farFocusEnd, float farRadius, float temporalFactor) {} // 0x0000000184DA1540-0x0000000184DA15A0
		// HGDepthOfFieldData(HGDepthOfFieldFocusMode, HGDepthOfFieldType, HGDepthOfFieldScale, Single, Single, Single, Single, Single, Single, Single)
		void HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
		        HGDepthOfFieldData *this,
		        HGDepthOfFieldFocusMode__Enum mode,
		        HGDepthOfFieldType__Enum type,
		        HGDepthOfFieldScale__Enum scale,
		        float nearFocusStart,
		        float nearFocusEnd,
		        float nearRadius,
		        float farFocusStart,
		        float farFocusEnd,
		        float farRadius,
		        float temporalFactor,
		        MethodInfo *method)
		{
		  this->fields.nearFocusStart = nearFocusStart;
		  this->fields.nearRadius = nearRadius;
		  this->fields.nearFocusEnd = nearFocusEnd;
		  this->fields.farFocusEnd = farFocusEnd;
		  this->fields.farFocusStart = farFocusStart;
		  this->fields.temporalFactor = temporalFactor;
		  this->fields.farRadius = farRadius;
		  this->fields.mode = mode;
		  this->fields.type = type;
		  this->fields.scale = scale;
		}
		
	}
}
