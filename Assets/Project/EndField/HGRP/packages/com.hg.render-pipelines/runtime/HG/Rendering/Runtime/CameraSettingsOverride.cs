using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	public struct CameraSettingsOverride
	{
		public CameraSettingsFields camera;
	}
}
