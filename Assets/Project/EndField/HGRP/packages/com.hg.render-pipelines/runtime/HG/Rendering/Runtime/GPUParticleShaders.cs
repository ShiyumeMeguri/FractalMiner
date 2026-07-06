using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GPUParticleShaders
	{
		internal ComputeShader emitShader;

		internal ComputeShader simulateShader;
	}
}
