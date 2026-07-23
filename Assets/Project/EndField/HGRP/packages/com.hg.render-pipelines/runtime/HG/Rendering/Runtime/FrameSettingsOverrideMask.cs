using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[DebuggerDisplay("{mask.humanizedData}")]
	public struct FrameSettingsOverrideMask // TypeDefIndex: 38532
	{
		// Fields
		[SerializeField]
		public BitArray128 mask; // 0x00
	}
}
