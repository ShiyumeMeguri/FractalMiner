using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct EntityRenderHelperECSContext
	{
		public int unitConfigAssetInstanceId;

		public Matrix4x4 matrix;

		public Entity rendererEntity;

		public IEntityRenderHelperECS renderHelperInstance;
	}
}
