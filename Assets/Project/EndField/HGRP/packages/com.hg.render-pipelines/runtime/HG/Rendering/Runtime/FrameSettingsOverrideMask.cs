using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[DebuggerDisplay("{mask.humanizedData}")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct FrameSettingsOverrideMask
	{
		[SerializeField]
		public BitArray128 mask;
	}
}
