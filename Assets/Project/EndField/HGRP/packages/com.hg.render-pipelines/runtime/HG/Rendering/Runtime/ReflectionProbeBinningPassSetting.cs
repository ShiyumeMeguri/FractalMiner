using System;

namespace HG.Rendering.Runtime
{
	public static class ReflectionProbeBinningPassSetting
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static int QUALITY_VISIBLE_COUNT;

		public const int MAX_VISIBLE_COUNT = 32;
	}
}
