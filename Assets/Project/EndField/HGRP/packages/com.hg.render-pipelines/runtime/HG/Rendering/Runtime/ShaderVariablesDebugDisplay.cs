using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 112)]
	public struct ShaderVariablesDebugDisplay
	{
		public int debugRenderMode;

		public int debugFullScreenBufferWidth;

		public int debugFullScreenBufferHeight;

		public float ppCompareScale;

		public int isOnePassDeferred;

		public float albedoMinDetectLuminance;

		public float albedoMaxDetectLuminance;

		public float checkerSize;

		public int triangleCountMin;

		public int triangleCountMax;

		public int displayAutoExposureHistogram;

		public float leafBackFaceRead;

		public int enableAOVOutput;

		public int enableAOVRenderMatte;

		public float displayPPResult;

		public float baseColorAlpha;

		public float renderingScale;

		public int mousePosX;

		public int mousePosY;

		public int disableNormalMap;

		public int displayIVVoxelSize;

		public int debugSkyAO;

		public float debugDisplayEV;

		public float debugXRayDistance;

		public Vector4 overrideBaseColor;
	}
}
