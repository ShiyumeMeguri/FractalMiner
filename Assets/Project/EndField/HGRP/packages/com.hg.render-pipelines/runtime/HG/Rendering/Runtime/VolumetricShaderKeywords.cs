using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VolumetricShaderKeywords // TypeDefIndex: 38764
	{
		// Fields
		internal static readonly string s_EnableSH; // 0x00
		internal static readonly string s_EnableEmptySkip; // 0x08
		internal static readonly string s_EnableEmptySkipTwoLayers; // 0x10
		internal static readonly string s_EnableFullScreen; // 0x18
		internal static readonly string s_FarModePanoramic; // 0x20
		internal static readonly string s_FarModeOctahedron; // 0x28
		internal static readonly string s_FarModeSemicircular; // 0x30
		internal static readonly string s_EnableFarCompose; // 0x38
		internal static readonly string s_FarCloudFramingCheckerboard; // 0x40
		internal static readonly string s_FarCloudFramingQuarter; // 0x48
		internal static readonly string s_FarCloudFraming4x2; // 0x50
		internal static readonly string s_FarCloudFraming4x4; // 0x58
		internal static readonly string s_FarCloudSlicingReproject; // 0x60
		internal static readonly string s_FarCloudFramingComposeInPass; // 0x68
		internal static readonly string s_WindField; // 0x70
		internal static readonly string s_WindNearFar; // 0x78
		internal static readonly string s_FramingQuarter; // 0x80
		internal static readonly string s_FramingCheckerboard; // 0x88
		internal static readonly string s_DisableDepthWrite; // 0x90
		internal static readonly string s_EnableDepthForTest; // 0x98
		internal static readonly string s_MergeTAAPassNMVNDO; // 0xA0
		internal static readonly string s_MergeTAAPassEMVNDO; // 0xA8
		internal static readonly string s_MergeTAAPassEMVEDO; // 0xB0
		internal static readonly string s_MergeTAAPassNMVEDO; // 0xB8
		internal static readonly string s_EnableDownscale; // 0xC0
		internal static readonly string s_DownscaleTriple; // 0xC8
		internal static readonly string s_DownscaleQuarter; // 0xD0
		internal static readonly string s_UpscaleBilateral; // 0xD8
		internal static readonly string s_UpscaleNearest; // 0xE0
		internal static readonly string s_UpscaleNoisy; // 0xE8
		internal static readonly string s_EnableMinMaxDepth; // 0xF0
		internal static readonly string s_ReconstructEnableMotionVector; // 0xF8
		internal static readonly string s_ReconstructEnableDepthOpt; // 0x100
		internal static readonly string s_ReconstructEnableColorAABB; // 0x108
		internal static readonly string s_ReconstructEnableNeighborAvg; // 0x110
		internal static readonly string s_TAAEnableMotionVector; // 0x118
		internal static readonly string s_TAAEnableDepthOpt; // 0x120
		internal static readonly string s_TAAEnableColorAABB; // 0x128
		internal static readonly string s_TAAEnableNeighborAvg; // 0x130
		internal static readonly GlobalKeyword s_ComposeVolumetric; // 0x138
	
		// Constructors
		static VolumetricShaderKeywords() {} // 0x0000000189C6550C-0x0000000189C65D30
	}
}
