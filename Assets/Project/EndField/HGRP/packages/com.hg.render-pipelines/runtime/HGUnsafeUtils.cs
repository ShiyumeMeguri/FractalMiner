using System;
using Unity.Collections;

public static class HGUnsafeUtils
{
	public static float UIntToFloatBitwise(uint value)
	{
		// // Single asfloat(UInt32)
		// float Unity::Mathematics::math::asfloat(uint32_t x, MethodInfo *method)
		// {
		//   return *(float *)&x;
		// }
		// 
		return 0f;
	}

	public unsafe static Span<T> ToSpan<T>(T* ptr, int length) where T : struct
	{
		return null;
	}

	public static NativeArray<T> ToNativeArray<T>(this Span<T> span) where T : struct
	{
		return null;
	}

	public static NativeArray<T2> ToNativeArray<T1, T2>(this Span<T1> span) where T1 : struct where T2 : struct
	{
		return null;
	}

	public static NativeArray<T2> ToNativeArray<T1, T2>(this ReadOnlySpan<T1> span) where T1 : struct where T2 : struct
	{
		return null;
	}

	public static NativeArray<T> ToNativeArray<T>(this ReadOnlySpan<T> span) where T : struct
	{
		return null;
	}

	public static ReadOnlySpan<U> Reinterpret<T, U>(this ReadOnlySpan<T> span) where T : struct where U : struct
	{
		return null;
	}

	public static Span<U> Reinterpret<T, U>(this Span<T> span) where T : struct where U : struct
	{
		return null;
	}
}
