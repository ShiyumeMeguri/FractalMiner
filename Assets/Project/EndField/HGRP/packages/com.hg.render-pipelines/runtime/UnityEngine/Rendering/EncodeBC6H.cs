using System;

namespace UnityEngine.Rendering
{
	internal class EncodeBC6H
	{
		public EncodeBC6H(ComputeShader shader)
		{
		}

		public void EncodeFastCubemap(CommandBuffer cmb, RenderTargetIdentifier source, int sourceSize, RenderTargetIdentifier target, int fromMip, int toMip, [MetadataOffset(Offset = "0x01F909D4")] int targetArrayIndex = 0)
		{
			// // Void EncodeFastCubemap(CommandBuffer, RenderTargetIdentifier, Int32, RenderTargetIdentifier, Int32, Int32, Int32)
			// void UnityEngine::Rendering::EncodeBC6H::EncodeFastCubemap(
			//         EncodeBC6H *this,
			//         CommandBuffer *cmb,
			//         RenderTargetIdentifier *source,
			//         int32_t sourceSize,
			//         RenderTargetIdentifier *target,
			//         int32_t fromMip,
			//         int32_t toMip,
			//         int32_t targetArrayIndex,
			//         MethodInfo *method)
			// {
			//   float v13; // xmm6_4
			//   float v14; // xmm0_4
			//   int32_t v15; // ebx
			//   int32_t v16; // ecx
			//   int32_t v17; // edi
			//   __int128 v18; // xmm6
			//   ComputeShader *m_Shader; // r14
			//   __int128 v20; // xmm7
			//   __int64 v21; // rdx
			//   EncodeBC6H__StaticFields *static_fields; // rcx
			//   int32_t v23; // r9d
			//   __int128 v24; // xmm1
			//   int32_t v25; // esi
			//   __int64 v26; // rdx
			//   _QWORD *p_DefaultInstance; // rcx
			//   __int64 v28; // rax
			//   int32_t v29; // edx
			//   int32_t v30; // r14d
			//   RenderTargetIdentifier *v31; // rax
			//   __int128 v32; // xmm1
			//   __int64 v33; // xmm0_8
			//   int32_t v34; // esi
			//   int32_t v35; // r14d
			//   int32_t i; // r12d
			//   __int64 v37; // rax
			//   RenderTargetIdentifier *v38; // rax
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int64 v42; // rax
			//   RenderTextureDescriptor v43; // [rsp+48h] [rbp-C0h] BYREF
			//   RenderTargetIdentifier v44; // [rsp+88h] [rbp-80h] BYREF
			//   RenderTextureDescriptor v45; // [rsp+B8h] [rbp-50h] BYREF
			//   __int128 v46; // [rsp+F8h] [rbp-10h]
			//   ComputeShader *v47; // [rsp+188h] [rbp+80h]
			//   int32_t m_KEncodeFastCubemapMip; // [rsp+1B8h] [rbp+B0h]
			//   int32_t v49; // [rsp+1B8h] [rbp+B0h]
			// 
			//   if ( !byte_18D9192FE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//     byte_18D9192FE = 1;
			//   }
			//   v13 = COERCE_FLOAT(COERCE_UNSIGNED_INT64(((double (*)(void))sub_1802EAFE0)()));
			//   v14 = sub_1802EAFE0();
			//   v15 = fromMip;
			//   v16 = 0;
			//   if ( (int)(float)(v13 / v14) - 2 >= 0 )
			//     v16 = (int)(float)(v13 / v14) - 2;
			//   if ( fromMip >= 0 )
			//   {
			//     if ( fromMip > v16 )
			//       v15 = v16;
			//   }
			//   else
			//   {
			//     v15 = 0;
			//   }
			//   v17 = v15;
			//   if ( toMip > v15 )
			//     v17 = toMip;
			//   if ( v16 < v17 )
			//     v17 = v16;
			//   memset(&v43, 0, sizeof(v43));
			//   UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v43, 0, 0LL);
			//   UnityEngine::RenderTextureDescriptor::set_bindMS(&v43, 0, 0LL);
			//   UnityEngine::RenderTextureDescriptor::set_graphicsFormat(&v43, GraphicsFormat__Enum_R32G32B32A32_SInt, 0LL);
			//   UnityEngine::RenderTextureDescriptor::set_depthBufferBits(&v43, 0, 0LL);
			//   v43._dimension_k__BackingField = 5;
			//   UnityEngine::RenderTextureDescriptor::set_enableRandomWrite(&v43, 1, 0LL);
			//   v43._msaaSamples_k__BackingField = 1;
			//   v43._volumeDepth_k__BackingField = 6;
			//   UnityEngine::RenderTextureDescriptor::set_sRGB(&v43, 0, 0LL);
			//   UnityEngine::RenderTextureDescriptor::set_useMipMap(&v43, 0, 0LL);
			//   v18 = *(_OWORD *)&v43._mipCount_k__BackingField;
			//   m_Shader = this.fields.m_Shader;
			//   v20 = *(_OWORD *)&v43._dimension_k__BackingField;
			//   m_KEncodeFastCubemapMip = this.fields.m_KEncodeFastCubemapMip;
			//   v46 = *(_OWORD *)&v43._width_k__BackingField;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//   static_fields = TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields;
			//   v23 = static_fields._Source;
			//   if ( !cmb )
			//     sub_180B536AC(static_fields, v21);
			//   v24 = *(_OWORD *)&source.m_BufferPointer;
			//   *(_OWORD *)&v44.m_Type = *(_OWORD *)&source.m_Type;
			//   *(_QWORD *)&v44.m_DepthSlice = *(_QWORD *)&source.m_DepthSlice;
			//   *(_OWORD *)&v44.m_BufferPointer = v24;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmb, m_Shader, m_KEncodeFastCubemapMip, v23, &v44, 0LL);
			//   v25 = v15;
			//   if ( v15 <= v17 )
			//   {
			//     while ( 1 )
			//     {
			//       LODWORD(v46) = sourceSize >> (v25 & 0x1F) >> 2;
			//       DWORD1(v46) = v46;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//       p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields.DefaultInstance;
			//       v28 = p_DefaultInstance[3];
			//       if ( !v28 )
			//         break;
			//       if ( (unsigned int)v25 >= *(_DWORD *)(v28 + 24) )
			// LABEL_37:
			//         sub_180070270(p_DefaultInstance, v26);
			//       v45._memoryless_k__BackingField = v43._memoryless_k__BackingField;
			//       *(_OWORD *)&v45._width_k__BackingField = v46;
			//       *(_OWORD *)&v45._mipCount_k__BackingField = v18;
			//       v29 = *(_DWORD *)(v28 + 4LL * v25 + 32);
			//       *(_OWORD *)&v45._dimension_k__BackingField = v20;
			//       UnityEngine::Rendering::CommandBuffer::GetTemporaryRT(cmb, v29, &v45, 0LL);
			//       if ( ++v25 > v17 )
			//         goto LABEL_19;
			//     }
			// LABEL_38:
			//     sub_180B536AC(p_DefaultInstance, v26);
			//   }
			// LABEL_19:
			//   v30 = v15;
			//   if ( v15 <= v17 )
			//   {
			//     do
			//     {
			//       v47 = this.fields.m_Shader;
			//       v49 = this.fields.m_KEncodeFastCubemapMip;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//       p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields.__Tmp_RT.klass;
			//       if ( !p_DefaultInstance )
			//         goto LABEL_38;
			//       if ( (unsigned int)v30 >= *((_DWORD *)p_DefaultInstance + 6) )
			//         goto LABEL_37;
			//       v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//               (RenderTargetIdentifier *)&v45,
			//               *((_DWORD *)p_DefaultInstance + v30 + 8),
			//               0LL);
			//       v32 = *(_OWORD *)&v31.m_BufferPointer;
			//       *(_OWORD *)&v44.m_Type = *(_OWORD *)&v31.m_Type;
			//       v33 = *(_QWORD *)&v31.m_DepthSlice;
			//       *(_OWORD *)&v44.m_BufferPointer = v32;
			//       *(_QWORD *)&v44.m_DepthSlice = v33;
			//       UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//         cmb,
			//         v47,
			//         v49,
			//         TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields._Target,
			//         &v44,
			//         0LL);
			//       UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//         cmb,
			//         this.fields.m_Shader,
			//         TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields._MipIndex,
			//         v30,
			//         0LL);
			//       UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//         cmb,
			//         this.fields.m_Shader,
			//         this.fields.m_KEncodeFastCubemapMip,
			//         sourceSize >> (v30 & 0x1F) >> 2,
			//         sourceSize >> (v30 & 0x1F) >> 2,
			//         6,
			//         0LL);
			//     }
			//     while ( ++v30 <= v17 );
			//   }
			//   v34 = v15;
			//   if ( v15 <= v17 )
			//   {
			//     do
			//     {
			//       v35 = v34;
			//       if ( v34 < v15 )
			//         v35 = v15;
			//       for ( i = 0; i < 6; ++i )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//         p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields.DefaultInstance;
			//         v37 = p_DefaultInstance[3];
			//         if ( !v37 )
			//           goto LABEL_38;
			//         if ( (unsigned int)v35 >= *(_DWORD *)(v37 + 24) )
			//           goto LABEL_37;
			//         v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                 (RenderTargetIdentifier *)&v43,
			//                 *(_DWORD *)(v37 + 4LL * v35 + 32),
			//                 0LL);
			//         v39 = *(_OWORD *)&target.m_Type;
			//         *(_OWORD *)&v44.m_BufferPointer = *(_OWORD *)&target.m_BufferPointer;
			//         v40 = *(_OWORD *)&v38.m_Type;
			//         *(_OWORD *)&v44.m_Type = v39;
			//         *(_QWORD *)&v39 = *(_QWORD *)&target.m_DepthSlice;
			//         *(_OWORD *)&v45._width_k__BackingField = v40;
			//         *(_QWORD *)&v40 = *(_QWORD *)&v38.m_DepthSlice;
			//         *(_QWORD *)&v44.m_DepthSlice = v39;
			//         v41 = *(_OWORD *)&v38.m_BufferPointer;
			//         *(_QWORD *)&v45._dimension_k__BackingField = v40;
			//         *(_OWORD *)&v45._mipCount_k__BackingField = v41;
			//         UnityEngine::Rendering::CommandBuffer::CopyTexture(
			//           cmb,
			//           (RenderTargetIdentifier *)&v45,
			//           i,
			//           0,
			//           &v44,
			//           i + 6 * targetArrayIndex,
			//           v34,
			//           0LL);
			//       }
			//       ++v34;
			//     }
			//     while ( v34 <= v17 );
			//     while ( v15 <= v17 )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
			//       p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H.static_fields.DefaultInstance;
			//       v42 = p_DefaultInstance[3];
			//       if ( !v42 )
			//         goto LABEL_38;
			//       if ( (unsigned int)v15 >= *(_DWORD *)(v42 + 24) )
			//         goto LABEL_37;
			//       UnityEngine::Rendering::CommandBuffer::ReleaseTemporaryRT(cmb, *(_DWORD *)(v42 + 4LL * v15++ + 32), 0LL);
			//     }
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static EncodeBC6H DefaultInstance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly int _Source;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		private static readonly int _Target;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly int _MipIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly int[] __Tmp_RT;

		private readonly ComputeShader m_Shader;

		private readonly int m_KEncodeFastCubemapMip;
	}
}
