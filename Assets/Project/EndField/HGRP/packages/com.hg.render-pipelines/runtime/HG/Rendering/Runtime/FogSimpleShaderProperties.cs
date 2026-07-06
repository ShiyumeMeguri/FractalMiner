using System;

namespace HG.Rendering.Runtime
{
	internal static class FogSimpleShaderProperties
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly int CULL_MODE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static readonly int BLEND_MODE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly int BASE_COLOR;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		internal static readonly int BASE_ALPHA_INTENSITY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly int MAIN_TEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		internal static readonly int FOG_NOISE_INTENSITY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		internal static readonly int USE_WIND;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		internal static readonly int NOISE_TEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		internal static readonly int WIND_NOISE_INTENSITY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		internal static readonly int WIND_NOISE_CONTRAST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		internal static readonly int WIND_DIR_X;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		internal static readonly int WIND_DIR_Y;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		internal static readonly int WIND_SPEED;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		internal static readonly int WIND_SCALE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		internal static readonly int USE_SEPARATE_SCALE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
		internal static readonly int WIND_SCALE_X;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		internal static readonly int WIND_SCALE_Y;

		internal const string USE_SOFT_LIGHTING = "_USE_LIGHTING";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		internal static readonly int USE_LIGHTING;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		internal static readonly int USE_NORMAL_TEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		internal static readonly int NORMAL_TEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		internal static readonly int NORMAL_SCALE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
		internal static readonly int TWO_SIDED_NORMAL;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		internal static readonly int INDIRECT_COLOR;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C")]
		internal static readonly int LIGHT_FACTOR;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		internal static readonly int USE_FRESNEL;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64")]
		internal static readonly int FLIP_FRESNEL;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		internal static readonly int FRESNEL_INTENSITY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C")]
		internal static readonly int FRESNEL_CONTRACT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		internal static readonly int DISTANCE_FADE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x74")]
		internal static readonly int DISTANCE_FADE_START;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		internal static readonly int DISTANCE_FADE_END;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C")]
		internal static readonly int NEAR_CAMERA_FADE_DISTANCE_START;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		internal static readonly int NEAR_CAMERA_FADE_DISTANCE_END;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x84")]
		internal static readonly int TOP_FADE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		internal static readonly int TOP_FADE_CONTRACT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C")]
		internal static readonly int TOP_FADE_OFFSET;

		internal const string USE_SOFT_BLEND_KEYWORD = "_USE_SOFTBLEND";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		internal static readonly int USE_SOFT_BLEND;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x94")]
		internal static readonly int SOFT_DISTANCE;

		internal const string USE_FOG_KEYWORD = "_USE_FOG";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		internal static readonly int USE_FOG;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C")]
		internal static readonly int FOG_INTENSITY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		internal static readonly int FOG_INTENSITY_FADE_OUT_DISTANCE;
	}
}
