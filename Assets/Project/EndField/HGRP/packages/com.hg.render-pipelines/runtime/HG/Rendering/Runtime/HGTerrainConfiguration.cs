using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGTerrainConfiguration", menuName = "HGTerrain/HGTerrainConfiguration", order = 0)]
	public class HGTerrainConfiguration : ScriptableObject
	{
		public HGTerrainConfiguration()
		{
			// // HGTerrainConfiguration()
			// void HG::Rendering::Runtime::HGTerrainConfiguration::HGTerrainConfiguration(
			//         HGTerrainConfiguration *this,
			//         MethodInfo *method)
			// {
			//   this.fields.chunkedLodGeometryError = 0.2;
			//   this.fields.virtualTextureResolution = 256;
			//   this.fields.vtCacheSliceWidth = 256;
			//   this.fields.vtSSBOBlockWidth = 16;
			//   this.fields.vtSSBOBlockHeight = 16;
			//   this.fields.chunkedLodSkirtHeight = 1.0;
			//   this.fields.chunkedLodPixelError = 4.0;
			//   this.fields.vtMinChunkSize = 2;
			//   this.fields.vtBaseMipBias = 15.0;
			//   this.fields.vtCacheSliceCount = 128;
			//   this.fields.vtCacheSliceHeight = 512;
			//   this.fields.vtFeedbackWidth = 8;
			//   this.fields.vtFeedbackHeight = 4;
			//   this.fields.vtMaxPagePerFrame = 1;
			//   this.fields.decalBaseSize = 64.0;
			//   this.fields.enableDecal = 1;
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public float chunkedLodGeometryError;

		public float chunkedLodSkirtHeight;

		public float chunkedLodPixelError;

		public int virtualTextureResolution;

		public int vtMinChunkSize;

		public float vtBaseMipBias;

		public int vtCacheSliceCount;

		public int vtCacheSliceWidth;

		public int vtCacheSliceHeight;

		public int vtClipmapBaseOffset;

		public int vtClipmapMaxOffset;

		public int vtFeedbackWidth;

		public int vtFeedbackHeight;

		public HGTerrainConfiguration.VTFeedbackMode vtFeedbackMode;

		public int vtSSBOBlockWidth;

		public int vtSSBOBlockHeight;

		public int vtMaxPagePerFrame;

		public bool vtEnableCompression;

		public float decalBaseSize;

		public bool enableDecal;

		[Serializable]
		public enum VTFeedbackMode
		{
			CPUPhysicsFeedback,
			GPUSSBOFeedback
		}
	}
}
