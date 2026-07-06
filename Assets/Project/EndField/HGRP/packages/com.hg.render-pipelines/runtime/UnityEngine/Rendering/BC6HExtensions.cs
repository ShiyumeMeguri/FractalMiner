using System;

namespace UnityEngine.Rendering
{
	internal static class BC6HExtensions
	{
		public static void BC6HEncodeFastCubemap(this CommandBuffer cmb, RenderTargetIdentifier source, int sourceSize, RenderTargetIdentifier target, int fromMip, int toMip, [MetadataOffset(Offset = "0x01F909D5")] int targetArrayIndex = 0)
		{
			// // Void BC6HEncodeFastCubemap(CommandBuffer, RenderTargetIdentifier, Int32, RenderTargetIdentifier, Int32, Int32, Int32)
			// void UnityEngine::Rendering::BC6HExtensions::BC6HEncodeFastCubemap(
			//         CommandBuffer *cmb,
			//         RenderTargetIdentifier *source,
			//         int32_t sourceSize,
			//         RenderTargetIdentifier *target,
			//         int32_t fromMip,
			//         int32_t toMip,
			//         int32_t targetArrayIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   EncodeBC6H *DefaultInstance; // rcx
			//   __int128 v14; // xmm1
			//   __int64 v15; // xmm0_8
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   RenderTargetIdentifier v18; // [rsp+50h] [rbp-68h] BYREF
			//   RenderTargetIdentifier v19; // [rsp+80h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919300 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//     byte_18D919300 = 1;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//   DefaultInstance = TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields.DefaultInstance;
			//   if ( !DefaultInstance )
			//     sub_180B536AC(0LL, v12);
			//   v14 = *(_OWORD *)&target.m_BufferPointer;
			//   *(_OWORD *)&v18.m_Type = *(_OWORD *)&target.m_Type;
			//   v15 = *(_QWORD *)&target.m_DepthSlice;
			//   *(_OWORD *)&v18.m_BufferPointer = v14;
			//   v16 = *(_OWORD *)&source.m_Type;
			//   *(_QWORD *)&v18.m_DepthSlice = v15;
			//   v17 = *(_OWORD *)&source.m_BufferPointer;
			//   *(_OWORD *)&v19.m_Type = v16;
			//   *(_QWORD *)&v16 = *(_QWORD *)&source.m_DepthSlice;
			//   *(_OWORD *)&v19.m_BufferPointer = v17;
			//   *(_QWORD *)&v19.m_DepthSlice = v16;
			//   UnityEngine::Rendering::EncodeBC6H::EncodeFastCubemap(
			//     DefaultInstance,
			//     cmb,
			//     &v19,
			//     sourceSize,
			//     &v18,
			//     fromMip,
			//     toMip,
			//     targetArrayIndex,
			//     0LL);
			// }
			// 
		}
	}
}
