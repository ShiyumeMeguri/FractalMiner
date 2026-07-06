using System;

namespace HG.Rendering.Runtime
{
	public static class VFXShaderIDs
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static int s_MainTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static int s_ProcedureAlpha;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static int s_DisableVertColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		public static int s_DisableParticleInstanceColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static int s_TintColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		public static int s_TintColorIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static int s_ExpThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		public static int s_ExpIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static int s_TintColorAlpha;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		public static int s_UseBright;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		public static int s_BrightColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		public static int s_ScanFillColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static int s_BrightCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		public static int s_UseBlend;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		public static int s_BlendTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
		public static int s_UseFresnel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static int s_FresnelColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		public static int s_UseEdgeColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		public static int s_EdgeColorMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		public static int s_EdgeColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static int s_UseDissolve;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
		public static int s_DissolveScheduleOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		public static int s_DissolveTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C")]
		public static int s_DissolveTex_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static int s_DissolveEdgeSharp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64")]
		public static int s_DissolveEmissiveColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		public static int s_DissolveEmissiveEdge;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C")]
		public static int s_DissolveUseViewUV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static int s_DissolveUVSet;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x74")]
		public static int s_UseCutOff;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		public static int s_CutOffPosY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C")]
		public static int s_CutOffDirection;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		public static int s_ScanScheduleOffset;
	}
}
