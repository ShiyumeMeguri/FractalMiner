using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGGrassData", menuName = "HG Grass Data")]
	public class HGGrassData : ScriptableObject
	{
		public HGGrassData()
		{
		}

		public int version;

		public Bounds bounds;

		public List<GrassCluster> clusters;
	}
}
