using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 144)]
	public ref struct ClothGroupData
	{
		public ClothGroupMeta clothGroupMeta;

		public Span<byte> groupClothMetaBytes;

		public Span<byte> groupClothNodeBytes;

		public Span<byte> groupClothBatchMetaBytes;

		public Span<byte> groupClothBatchCacheBytes;
	}
}
