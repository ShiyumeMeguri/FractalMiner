using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class TypeInfo // TypeDefIndex: 38704
	{
		// Nested types
		private struct EnumInfoJITCache<TEnum> // TypeDefIndex: 38703
			where TEnum : struct, IConvertible
		{
			// Fields
			public static readonly TEnum[] values;
			public static readonly string[] names;
			public static readonly int length;
	
			// Constructors
			static EnumInfoJITCache() {
				values = default;
				names = default;
				length = default;
			}
		}
	
		// Methods
		public static TEnum[] GetEnumValues<TEnum>()
			where TEnum : struct, IConvertible => default;
		public static int GetEnumLength<TEnum>()
			where TEnum : struct, IConvertible => default;
		public static string[] GetEnumNames<TEnum>()
			where TEnum : struct, IConvertible => default;
		public static TEnum GetEnumLastValue<TEnum>()
			where TEnum : struct, IConvertible => default;
	}
}
