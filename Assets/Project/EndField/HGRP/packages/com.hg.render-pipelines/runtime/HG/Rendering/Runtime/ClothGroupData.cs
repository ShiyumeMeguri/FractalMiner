using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct ClothGroupData // TypeDefIndex: 37573
	{
		// Fields
		public ClothGroupMeta clothGroupMeta; // 0x00
		public Span<byte> groupClothMetaBytes; // 0x50
		public Span<byte> groupClothNodeBytes; // 0x60
		public Span<byte> groupClothBatchMetaBytes; // 0x70
		public Span<byte> groupClothBatchCacheBytes; // 0x80
	}
}
