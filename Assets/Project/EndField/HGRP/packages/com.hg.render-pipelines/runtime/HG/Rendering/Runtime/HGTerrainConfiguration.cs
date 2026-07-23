using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGTerrainConfiguration", menuName = "\u2605 Beyond/HGTerrain/HGTerrainConfiguration", order = 0)]
	public class HGTerrainConfiguration : ScriptableObject // TypeDefIndex: 38623
	{
		// Fields
		public float chunkedLodGeometryError; // 0x18
		public float chunkedLodSkirtHeight; // 0x1C
		public float chunkedLodPixelError; // 0x20
		public int virtualTextureResolution; // 0x24
		public int vtMinChunkSize; // 0x28
		public float vtBaseMipBias; // 0x2C
		public int vtCacheSliceCount; // 0x30
		public int vtCacheSliceWidth; // 0x34
		public int vtCacheSliceHeight; // 0x38
		public int vtClipmapBaseOffset; // 0x3C
		public int vtClipmapMaxOffset; // 0x40
		public int vtFeedbackWidth; // 0x44
		public int vtFeedbackHeight; // 0x48
		public VTFeedbackMode vtFeedbackMode; // 0x4C
		public int vtSSBOBlockWidth; // 0x50
		public int vtSSBOBlockHeight; // 0x54
		public int vtMaxPagePerFrame; // 0x58
		public bool vtEnableCompression; // 0x5C
		public float decalBaseSize; // 0x60
		public bool enableDecal; // 0x64
	
		// Nested types
		[Serializable]
		public enum VTFeedbackMode // TypeDefIndex: 38622
		{
			CPUPhysicsFeedback = 0,
			GPUSSBOFeedback = 1
		}
	
		// Constructors
		public HGTerrainConfiguration() {} // 0x0000000189C21648-0x0000000189C216B8
		// HGTerrainConfiguration()
		void HG::Rendering::Runtime::HGTerrainConfiguration::HGTerrainConfiguration(
		        HGTerrainConfiguration *this,
		        MethodInfo *method)
		{
		  this->fields.chunkedLodGeometryError = 0.2;
		  this->fields.virtualTextureResolution = 256;
		  this->fields.vtCacheSliceWidth = 256;
		  this->fields.vtSSBOBlockWidth = 16;
		  this->fields.vtSSBOBlockHeight = 16;
		  this->fields.chunkedLodSkirtHeight = 1.0;
		  this->fields.chunkedLodPixelError = 4.0;
		  this->fields.vtMinChunkSize = 2;
		  this->fields.vtBaseMipBias = 15.0;
		  this->fields.vtCacheSliceCount = 128;
		  this->fields.vtCacheSliceHeight = 512;
		  this->fields.vtFeedbackWidth = 8;
		  this->fields.vtFeedbackHeight = 4;
		  this->fields.vtMaxPagePerFrame = 1;
		  this->fields.decalBaseSize = 64.0;
		  this->fields.enableDecal = 1;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
