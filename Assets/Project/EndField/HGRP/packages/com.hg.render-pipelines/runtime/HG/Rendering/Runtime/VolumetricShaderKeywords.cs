using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class VolumetricShaderKeywords
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly string s_EnableSH;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly string s_EnableEmptySkip;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly string s_EnableEmptySkipTwoLayers;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		internal static readonly string s_EnableFullScreen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		internal static readonly string s_FarModePanoramic;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		internal static readonly string s_FarModeOctahedron;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		internal static readonly string s_FarModeSemicircular;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		internal static readonly string s_EnableFarCompose;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		internal static readonly string s_FarCloudFramingCheckerboard;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		internal static readonly string s_FarCloudFramingQuarter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		internal static readonly string s_FarCloudFraming4x2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		internal static readonly string s_FarCloudFraming4x4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		internal static readonly string s_FarCloudSlicingReproject;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		internal static readonly string s_FarCloudFramingComposeInPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		internal static readonly string s_WindField;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		internal static readonly string s_WindNearFar;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		internal static readonly string s_FramingQuarter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		internal static readonly string s_FramingCheckerboard;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		internal static readonly string s_DisableDepthWrite;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		internal static readonly string s_EnableDepthForTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		internal static readonly string s_MergeTAAPassNMVNDO;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		internal static readonly string s_MergeTAAPassEMVNDO;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		internal static readonly string s_MergeTAAPassEMVEDO;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		internal static readonly string s_MergeTAAPassNMVEDO;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		internal static readonly string s_EnableDownscale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		internal static readonly string s_DownscaleTriple;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		internal static readonly string s_DownscaleQuarter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		internal static readonly string s_UpscaleBilateral;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		internal static readonly string s_UpscaleNearest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		internal static readonly string s_UpscaleNoisy;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		internal static readonly string s_EnableMinMaxDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		internal static readonly string s_ReconstructEnableMotionVector;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		internal static readonly string s_ReconstructEnableDepthOpt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		internal static readonly string s_ReconstructEnableColorAABB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		internal static readonly string s_ReconstructEnableNeighborAvg;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		internal static readonly string s_TAAEnableMotionVector;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		internal static readonly string s_TAAEnableDepthOpt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		internal static readonly string s_TAAEnableColorAABB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		internal static readonly string s_TAAEnableNeighborAvg;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		internal static readonly GlobalKeyword s_ComposeVolumetric;
	}
}
