using System;

namespace HG.Rendering.Runtime
{
	internal static class TypeInfo
	{
		public static TEnum[] GetEnumValues<TEnum>() where TEnum : struct, IConvertible
		{
			return null;
		}

		public static int GetEnumLength<TEnum>() where TEnum : struct, IConvertible
		{
			return 0;
		}

		public static string[] GetEnumNames<TEnum>() where TEnum : struct, IConvertible
		{
			return null;
		}

		public static TEnum GetEnumLastValue<TEnum>() where TEnum : struct, IConvertible
		{
			return null;
		}

		private struct EnumInfoJITCache<TEnum> where TEnum : struct, IConvertible
		{
			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly TEnum[] values;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly string[] names;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly int length;
		}
	}
}
