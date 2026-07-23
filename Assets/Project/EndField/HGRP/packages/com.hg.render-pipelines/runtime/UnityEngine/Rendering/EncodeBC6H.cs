using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace UnityEngine.Rendering
{
	internal class EncodeBC6H // TypeDefIndex: 37394
	{
		// Fields
		public static EncodeBC6H DefaultInstance; // 0x00
		private static readonly int _Source; // 0x08
		private static readonly int _Target; // 0x0C
		private static readonly int _MipIndex; // 0x10
		private static readonly int[] __Tmp_RT; // 0x18
		private readonly ComputeShader m_Shader; // 0x10
		private readonly int m_KEncodeFastCubemapMip; // 0x18
	
		// Constructors
		public EncodeBC6H() {} // Dummy constructor
		public EncodeBC6H(ComputeShader shader) {} // 0x0000000189B2769C-0x0000000189B276DC
		static EncodeBC6H() {} // 0x0000000189B2747C-0x0000000189B2769C
		// EncodeBC6H()
		void UnityEngine::Rendering::EncodeBC6H::cctor(MethodInfo *method)
		{
		  Int32__Array *v1; // rbx
		  int32_t v2; // eax
		  UberPostPassUtils_ColorGradingData **v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // eax
		  int32_t v6; // eax
		  int32_t v7; // eax
		  int32_t v8; // eax
		  int32_t v9; // eax
		  int32_t v10; // eax
		  int32_t v11; // eax
		  int32_t v12; // eax
		  int32_t v13; // eax
		  int32_t v14; // eax
		  int32_t v15; // eax
		  int32_t v16; // eax
		  int32_t v17; // eax
		  VolumetricPipelineRT **v18; // r8
		  VolumetricPipelineRT **v19; // r9
		  VolumetricPipelineRT **v20; // [rsp+50h] [rbp+28h]
		  MethodInfo *v21; // [rsp+58h] [rbp+30h]
		
		  TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->_Source = UnityEngine::Shader::PropertyToID(
		                                                                           (String *)"_Source",
		                                                                           0LL);
		  TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->_Target = UnityEngine::Shader::PropertyToID(
		                                                                           (String *)"_Target",
		                                                                           0LL);
		  TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->_MipIndex = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_MipIndex",
		                                                                             0LL);
		  v1 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 14LL);
		  v2 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT0", 0LL);
		  if ( !v1 )
		    sub_1800D8260(v4, v3);
		  if ( !v1->max_length.size )
		    goto LABEL_18;
		  v1->vector[0] = v2;
		  v5 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT1", 0LL);
		  if ( v1->max_length.size <= 1u )
		    goto LABEL_18;
		  v1->vector[1] = v5;
		  v6 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT2", 0LL);
		  if ( v1->max_length.size <= 2u )
		    goto LABEL_18;
		  v1->vector[2] = v6;
		  v7 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT3", 0LL);
		  if ( v1->max_length.size <= 3u )
		    goto LABEL_18;
		  v1->vector[3] = v7;
		  v8 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT4", 0LL);
		  if ( v1->max_length.size <= 4u )
		    goto LABEL_18;
		  v1->vector[4] = v8;
		  v9 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT5", 0LL);
		  if ( v1->max_length.size <= 5u )
		    goto LABEL_18;
		  v1->vector[5] = v9;
		  v10 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT6", 0LL);
		  if ( v1->max_length.size <= 6u )
		    goto LABEL_18;
		  v1->vector[6] = v10;
		  v11 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT7", 0LL);
		  if ( v1->max_length.size <= 7u )
		    goto LABEL_18;
		  v1->vector[7] = v11;
		  v12 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT8", 0LL);
		  if ( v1->max_length.size <= 8u )
		    goto LABEL_18;
		  v1->vector[8] = v12;
		  v13 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT9", 0LL);
		  if ( v1->max_length.size <= 9u )
		    goto LABEL_18;
		  v1->vector[9] = v13;
		  v14 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT10", 0LL);
		  if ( v1->max_length.size <= 0xAu
		    || (v1->vector[10] = v14,
		        v15 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT11", 0LL),
		        v1->max_length.size <= 0xBu)
		    || (v1->vector[11] = v15,
		        v16 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT12", 0LL),
		        v1->max_length.size <= 0xCu)
		    || (v1->vector[12] = v16,
		        v17 = UnityEngine::Shader::PropertyToID((String *)"__Tmp_RT13", 0LL),
		        v1->max_length.size <= 0xDu) )
		  {
		LABEL_18:
		    sub_1800D2AB0(v4, v3);
		  }
		  v1->vector[13] = v17;
		  TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->__Tmp_RT = v1;
		  sub_18002D1B0(
		    (ParsingException *)&TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->__Tmp_RT,
		    v3,
		    v18,
		    v19,
		    v20,
		    v21);
		}
		
	
		// Methods
		public void EncodeFastCubemap(CommandBuffer cmb, RenderTargetIdentifier source, int sourceSize, RenderTargetIdentifier target, int fromMip, int toMip, int targetArrayIndex = 0 /* Metadata: 0x02302D44 */) {} // 0x0000000189B26FDC-0x0000000189B2747C
		// Void EncodeFastCubemap(CommandBuffer, RenderTargetIdentifier, Int32, RenderTargetIdentifier, Int32, Int32, Int32)
		void UnityEngine::Rendering::EncodeBC6H::EncodeFastCubemap(
		        EncodeBC6H *this,
		        CommandBuffer *cmb,
		        RenderTargetIdentifier *source,
		        int32_t sourceSize,
		        RenderTargetIdentifier *target,
		        int32_t fromMip,
		        int32_t toMip,
		        int32_t targetArrayIndex,
		        MethodInfo *method)
		{
		  float v13; // xmm6_4
		  float v14; // xmm0_4
		  int32_t v15; // ebx
		  int32_t v16; // ecx
		  int32_t v17; // edi
		  __int128 v18; // xmm6
		  ComputeShader *m_Shader; // r14
		  __int128 v20; // xmm7
		  __int64 v21; // rdx
		  EncodeBC6H__StaticFields *static_fields; // rcx
		  int32_t v23; // r9d
		  __int128 v24; // xmm1
		  int32_t v25; // esi
		  __int64 v26; // rdx
		  _QWORD *p_DefaultInstance; // rcx
		  __int64 v28; // rax
		  int32_t v29; // edx
		  int32_t v30; // r14d
		  RenderTargetIdentifier *v31; // rax
		  __int128 v32; // xmm1
		  __int64 v33; // xmm0_8
		  int32_t v34; // esi
		  int32_t v35; // r14d
		  int32_t i; // r12d
		  __int64 v37; // rax
		  RenderTargetIdentifier *v38; // rax
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int64 v42; // rax
		  RenderTextureDescriptor v43; // [rsp+48h] [rbp-C0h] BYREF
		  RenderTargetIdentifier v44; // [rsp+88h] [rbp-80h] BYREF
		  RenderTextureDescriptor v45; // [rsp+B8h] [rbp-50h] BYREF
		  __int128 v46; // [rsp+F8h] [rbp-10h]
		  ComputeShader *v47; // [rsp+188h] [rbp+80h]
		  int32_t m_KEncodeFastCubemapMip; // [rsp+1B8h] [rbp+B0h]
		  int32_t v49; // [rsp+1B8h] [rbp+B0h]
		
		  v13 = COERCE_FLOAT(COERCE_UNSIGNED_INT64(((double (*)(void))sub_1803367D0)()));
		  v14 = sub_1803367D0();
		  v15 = fromMip;
		  v16 = 0;
		  if ( (int)(float)(v13 / v14) - 2 >= 0 )
		    v16 = (int)(float)(v13 / v14) - 2;
		  if ( fromMip >= 0 )
		  {
		    if ( fromMip > v16 )
		      v15 = v16;
		  }
		  else
		  {
		    v15 = 0;
		  }
		  v17 = v15;
		  if ( toMip > v15 )
		    v17 = toMip;
		  if ( v16 < v17 )
		    v17 = v16;
		  memset(&v43, 0, sizeof(v43));
		  UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v43, 0, 0LL);
		  UnityEngine::RenderTextureDescriptor::set_bindMS(&v43, 0, 0LL);
		  UnityEngine::RenderTextureDescriptor::set_graphicsFormat(&v43, GraphicsFormat__Enum_R32G32B32A32_SInt, 0LL);
		  UnityEngine::RenderTextureDescriptor::set_depthBufferBits(&v43, 0, 0LL);
		  v43._dimension_k__BackingField = 5;
		  UnityEngine::RenderTextureDescriptor::set_enableRandomWrite(&v43, 1, 0LL);
		  v43._msaaSamples_k__BackingField = 1;
		  v43._volumeDepth_k__BackingField = 6;
		  UnityEngine::RenderTextureDescriptor::set_sRGB(&v43, 0, 0LL);
		  UnityEngine::RenderTextureDescriptor::set_useMipMap(&v43, 0, 0LL);
		  v18 = *(_OWORD *)&v43._mipCount_k__BackingField;
		  m_Shader = this->fields.m_Shader;
		  v20 = *(_OWORD *)&v43._dimension_k__BackingField;
		  m_KEncodeFastCubemapMip = this->fields.m_KEncodeFastCubemapMip;
		  v46 = *(_OWORD *)&v43._width_k__BackingField;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
		  static_fields = TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields;
		  v23 = static_fields->_Source;
		  if ( !cmb )
		    sub_1800D8260(static_fields, v21);
		  v24 = *(_OWORD *)&source->m_BufferPointer;
		  *(_OWORD *)&v44.m_Type = *(_OWORD *)&source->m_Type;
		  *(_QWORD *)&v44.m_DepthSlice = *(_QWORD *)&source->m_DepthSlice;
		  *(_OWORD *)&v44.m_BufferPointer = v24;
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmb, m_Shader, m_KEncodeFastCubemapMip, v23, &v44, 0LL);
		  v25 = v15;
		  if ( v15 <= v17 )
		  {
		    while ( 1 )
		    {
		      LODWORD(v46) = sourceSize >> (v25 & 0x1F) >> 2;
		      DWORD1(v46) = v46;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
		      p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->DefaultInstance;
		      v28 = p_DefaultInstance[3];
		      if ( !v28 )
		        break;
		      if ( (unsigned int)v25 >= *(_DWORD *)(v28 + 24) )
		LABEL_35:
		        sub_1800D2AB0(p_DefaultInstance, v26);
		      v45._memoryless_k__BackingField = v43._memoryless_k__BackingField;
		      *(_OWORD *)&v45._width_k__BackingField = v46;
		      *(_OWORD *)&v45._mipCount_k__BackingField = v18;
		      v29 = *(_DWORD *)(v28 + 4LL * v25 + 32);
		      *(_OWORD *)&v45._dimension_k__BackingField = v20;
		      UnityEngine::Rendering::CommandBuffer::GetTemporaryRT(cmb, v29, &v45, 0LL);
		      if ( ++v25 > v17 )
		        goto LABEL_17;
		    }
		LABEL_36:
		    sub_1800D8260(p_DefaultInstance, v26);
		  }
		LABEL_17:
		  v30 = v15;
		  if ( v15 <= v17 )
		  {
		    do
		    {
		      v47 = this->fields.m_Shader;
		      v49 = this->fields.m_KEncodeFastCubemapMip;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
		      p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->__Tmp_RT->klass;
		      if ( !p_DefaultInstance )
		        goto LABEL_36;
		      if ( (unsigned int)v30 >= *((_DWORD *)p_DefaultInstance + 6) )
		        goto LABEL_35;
		      v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		              (RenderTargetIdentifier *)&v45,
		              *((_DWORD *)p_DefaultInstance + v30 + 8),
		              0LL);
		      v32 = *(_OWORD *)&v31->m_BufferPointer;
		      *(_OWORD *)&v44.m_Type = *(_OWORD *)&v31->m_Type;
		      v33 = *(_QWORD *)&v31->m_DepthSlice;
		      *(_OWORD *)&v44.m_BufferPointer = v32;
		      *(_QWORD *)&v44.m_DepthSlice = v33;
		      UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		        cmb,
		        v47,
		        v49,
		        TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->_Target,
		        &v44,
		        0LL);
		      UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		        cmb,
		        this->fields.m_Shader,
		        TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->_MipIndex,
		        v30,
		        0LL);
		      UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		        cmb,
		        this->fields.m_Shader,
		        this->fields.m_KEncodeFastCubemapMip,
		        sourceSize >> (v30 & 0x1F) >> 2,
		        sourceSize >> (v30 & 0x1F) >> 2,
		        6,
		        0LL);
		    }
		    while ( ++v30 <= v17 );
		  }
		  v34 = v15;
		  if ( v15 <= v17 )
		  {
		    do
		    {
		      v35 = v34;
		      if ( v34 < v15 )
		        v35 = v15;
		      for ( i = 0; i < 6; ++i )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
		        p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->DefaultInstance;
		        v37 = p_DefaultInstance[3];
		        if ( !v37 )
		          goto LABEL_36;
		        if ( (unsigned int)v35 >= *(_DWORD *)(v37 + 24) )
		          goto LABEL_35;
		        v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                (RenderTargetIdentifier *)&v43,
		                *(_DWORD *)(v37 + 4LL * v35 + 32),
		                0LL);
		        v39 = *(_OWORD *)&target->m_Type;
		        *(_OWORD *)&v44.m_BufferPointer = *(_OWORD *)&target->m_BufferPointer;
		        v40 = *(_OWORD *)&v38->m_Type;
		        *(_OWORD *)&v44.m_Type = v39;
		        *(_QWORD *)&v39 = *(_QWORD *)&target->m_DepthSlice;
		        *(_OWORD *)&v45._width_k__BackingField = v40;
		        *(_QWORD *)&v40 = *(_QWORD *)&v38->m_DepthSlice;
		        *(_QWORD *)&v44.m_DepthSlice = v39;
		        v41 = *(_OWORD *)&v38->m_BufferPointer;
		        *(_QWORD *)&v45._dimension_k__BackingField = v40;
		        *(_OWORD *)&v45._mipCount_k__BackingField = v41;
		        UnityEngine::Rendering::CommandBuffer::CopyTexture(
		          cmb,
		          (RenderTargetIdentifier *)&v45,
		          i,
		          0,
		          &v44,
		          i + 6 * targetArrayIndex,
		          v34,
		          0LL);
		      }
		      ++v34;
		    }
		    while ( v34 <= v17 );
		    while ( v15 <= v17 )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::EncodeBC6H);
		      p_DefaultInstance = &TypeInfo::UnityEngine::Rendering::EncodeBC6H->static_fields->DefaultInstance;
		      v42 = p_DefaultInstance[3];
		      if ( !v42 )
		        goto LABEL_36;
		      if ( (unsigned int)v15 >= *(_DWORD *)(v42 + 24) )
		        goto LABEL_35;
		      UnityEngine::Rendering::CommandBuffer::ReleaseTemporaryRT(cmb, *(_DWORD *)(v42 + 4LL * v15++ + 32), 0LL);
		    }
		  }
		}
		
	}
}
