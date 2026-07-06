using System;
using System.Collections.Generic;

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility
	{
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity)
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static bool s_enableFastPathBuffer;
	}
}
