using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	internal struct ClothGroupUploadDataMap
	{
		public int4 clothNodeDataMap;

		public int4 clothBatchMetaDataMap;

		public int4 clothBatchCacheDataMap;
	}
}
