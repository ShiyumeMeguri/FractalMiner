using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct ShaderVariablesDebugDisplay // TypeDefIndex: 38109
	{
		// Fields
		public int debugRenderMode; // 0x00
		public int debugFullScreenBufferWidth; // 0x04
		public int debugFullScreenBufferHeight; // 0x08
		public float ppCompareScale; // 0x0C
		public int isOnePassDeferred; // 0x10
		public float albedoMinDetectLuminance; // 0x14
		public float albedoMaxDetectLuminance; // 0x18
		public float checkerSize; // 0x1C
		public int triangleCountMin; // 0x20
		public int triangleCountMax; // 0x24
		public int displayAutoExposureHistogram; // 0x28
		public float leafBackFaceRead; // 0x2C
		public int enableAOVOutput; // 0x30
		public int enableAOVRenderMatte; // 0x34
		public float displayPPResult; // 0x38
		public float baseColorAlpha; // 0x3C
		public float renderingScale; // 0x40
		public int mousePosX; // 0x44
		public int mousePosY; // 0x48
		public int disableNormalMap; // 0x4C
		public int displayIVVoxelSize; // 0x50
		public int debugSkyAO; // 0x54
		public float debugDisplayEV; // 0x58
		public float debugXRayDistance; // 0x5C
		public Vector4 overrideBaseColor; // 0x60
		public int compositionFlags; // 0x70
		public int compositionOverlayType; // 0x74
		public float compositionDesaturateStrength; // 0x78
		public float compositionLineWidthPixels; // 0x7C
		public Vector4 compositionLineColor; // 0x80
		public Vector4 compositionFrameLineColor; // 0x90
		public float compositionLetterboxAspect; // 0xA0
		public float compositionLetterboxOpacity; // 0xA4
		public float compositionFrameAspect; // 0xA8
		public float compositionFrameScale; // 0xAC
		public float compositionFrameOpacity; // 0xB0
		public float compositionCrosshairSizePixels; // 0xB4
		public float compositionPadding1; // 0xB8
		public float compositionPadding2; // 0xBC
	}
}
