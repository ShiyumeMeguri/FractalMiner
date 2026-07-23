using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

public static class HGUnsafeUtils // TypeDefIndex: 37362
{
	// Methods
	public static float UIntToFloatBitwise(uint value) => default; // 0x0000000184D94BC0-0x0000000184D94BD0
	// Single IntToEnumValue[Single](Int32)
	float Beyond::GameSetting::IntToEnumValue<float>(int32_t intValue, MethodInfo *method)
	{
	  return *(float *)&intValue;
	}
	
	public static unsafe Span<T> ToSpan<T>(T* ptr, int length)
		where T : struct => default;

	// Extension methods
	public static NativeArray<T> ToNativeArray<T>(this Span<T> span)
		where T : struct => default;
	public static NativeArray<T2> ToNativeArray<T1, T2>(this Span<T1> span)
		where T1 : struct
		where T2 : struct => default;
	public static NativeArray<T2> ToNativeArray<T1, T2>(this ReadOnlySpan<T1> span)
		where T1 : struct
		where T2 : struct => default;
	public static NativeArray<T> ToNativeArray<T>(this ReadOnlySpan<T> span)
		where T : struct => default;
	public static ReadOnlySpan<U> Reinterpret<T, U>(this ReadOnlySpan<T> span)
		where T : struct
		where U : struct => default;
	public static Span<U> Reinterpret<T, U>(this Span<T> span)
		where T : struct
		where U : struct => default;
}

