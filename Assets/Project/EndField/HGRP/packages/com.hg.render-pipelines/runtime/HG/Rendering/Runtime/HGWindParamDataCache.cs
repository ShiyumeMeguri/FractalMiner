using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGWindParamDataCache // TypeDefIndex: 37708
	{
		// Fields
		public Vector4 _WindGlobalParams0; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams0[0]; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams1[0]; // 0x50
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams2[0]; // 0x90
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams3[0]; // 0xD0
		public Vector4 _WindMotorCount; // 0x110
		public float _WindLeafFadeDistance; // 0x120
		public float _WindLeafFadeRange; // 0x124
		public byte _WindMainQuaility; // 0x128
		public byte _WindMotorQuaility; // 0x129
	}
}
