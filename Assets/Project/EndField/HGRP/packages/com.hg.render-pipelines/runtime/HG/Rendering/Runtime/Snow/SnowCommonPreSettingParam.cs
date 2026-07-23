using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Snow
{
	[Serializable]
	public class SnowCommonPreSettingParam // TypeDefIndex: 38838
	{
		// Fields
		public Texture2D snowflakeTex; // 0x10
		public Vector4 snowflakeTex_ST; // 0x18
		[Range(1f, 300f)]
		public float maxSnowHeight; // 0x28
		[Range(0f, 200f)]
		public float snowMaxUVFlowSpeed; // 0x2C
		[Range(0f, 100f)]
		public float snowRange; // 0x30
		[Range(0f, 1f)]
		public float maxMoveDirectionLength; // 0x34
		[FormerlySerializedAs("snowTemporalTimeThreshould")]
		[Range(0f, 2f)]
		public float snowTemporalTimeThreshold; // 0x38
		public Texture2D characterSnowTexture; // 0x40
	
		// Constructors
		public SnowCommonPreSettingParam() {} // 0x0000000184DA1FF0-0x0000000184DA2020
		// SnowCommonPreSettingParam()
		void HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(
		        SnowCommonPreSettingParam *this,
		        MethodInfo *method)
		{
		  this->fields.snowflakeTex_ST = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
		  this->fields.maxSnowHeight = 100.0;
		  this->fields.snowMaxUVFlowSpeed = 160.0;
		  this->fields.snowRange = 30.0;
		  this->fields.maxMoveDirectionLength = 0.1;
		  this->fields.snowTemporalTimeThreshold = 1.0;
		}
		
	}
}
