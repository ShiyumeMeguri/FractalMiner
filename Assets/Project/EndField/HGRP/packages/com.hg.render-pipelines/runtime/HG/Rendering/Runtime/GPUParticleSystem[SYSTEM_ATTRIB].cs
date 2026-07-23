using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSystem<SYSTEM_ATTRIB> : GPUParticleSystemBase // TypeDefIndex: 37721
		where SYSTEM_ATTRIB : struct
	{
		// Fields
		private ComputeBuffer m_systemAttribsBuffer;
		private List<SYSTEM_ATTRIB> m_systemAttribsList;
	
		// Constructors
		private GPUParticleSystem() {}
		private GPUParticleSystem([IsReadOnly] in GPUParticleShaders shaders, [IsReadOnly] in GeneralSystemAttributes generalSystemAttributes, Material material, [IsReadOnly] in OptionalSystemFeatures? optionalSystemFeatures) {}
	
		// Methods
		public static GPUParticleSystem<SYSTEM_ATTRIB> Create([IsReadOnly] in GPUParticleShaders shaders, [IsReadOnly] in GeneralSystemAttributes generalSystemAttributes, Material material, [IsReadOnly] in OptionalSystemFeatures? optionalSystemFeatures) => default;
		internal override void Dispose() {}
		protected override void OnInstanceRemoved(int indexToRemove, int indexToMove) {}
		internal int CreateInstance([IsReadOnly] in ref SYSTEM_ATTRIB systemAttribDesc, [IsReadOnly] in PerInstanceData perInstanceData) => default;
		internal void Modify(int index, [IsReadOnly] in ref SYSTEM_ATTRIB systemAttribDesc) {}
		private void ModifyInternal(int gpuIndex, [IsReadOnly] in ref SYSTEM_ATTRIB systemAttribDesc) {}
		internal override GPUParticleSystemManager.SimulateContext AcquireSimulateContext() => default;
	}
}
