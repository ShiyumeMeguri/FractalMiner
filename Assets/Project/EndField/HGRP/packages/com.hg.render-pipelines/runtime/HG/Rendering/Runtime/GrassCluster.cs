using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class GrassCluster
	{
		public GrassCluster()
		{
		}

		public Bounds bounds;

		public float rendererHalfSize;

		public HGObjectFlags objectFlags;

		public List<GrassRenderer> renderers;

		public List<GrassPerInstanceData> perInstanceDatas;
	}
}
