using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSystem<SYSTEM_ATTRIB> : GPUParticleSystemBase where SYSTEM_ATTRIB : struct
	{
		private GPUParticleSystem()
		{
		}

		private GPUParticleSystem(in GPUParticleShaders shaders, in GeneralSystemAttributes generalSystemAttributes, Material material, in Nullable<OptionalSystemFeatures> optionalSystemFeatures)
		{
		}

		public static GPUParticleSystem<SYSTEM_ATTRIB> Create(in GPUParticleShaders shaders, in GeneralSystemAttributes generalSystemAttributes, Material material, in Nullable<OptionalSystemFeatures> optionalSystemFeatures)
		{
			return null;
		}

		internal override void Dispose()
		{
		}

		protected override void OnInstanceRemoved(int indexToRemove, int indexToMove)
		{
		}

		internal int CreateInstance(in SYSTEM_ATTRIB systemAttribDesc, in PerInstanceData perInstanceData)
		{
			return 0;
		}

		internal void Modify(int index, in SYSTEM_ATTRIB systemAttribDesc)
		{
		}

		private void ModifyInternal(int gpuIndex, in SYSTEM_ATTRIB systemAttribDesc)
		{
		}

		internal override GPUParticleSystemManager.SimulateContext AcquireSimulateContext()
		{
			return default(GPUParticleSystemManager.SimulateContext);
		}

		private ComputeBuffer m_systemAttribsBuffer;

		private List<SYSTEM_ATTRIB> m_systemAttribsList;
	}
}
