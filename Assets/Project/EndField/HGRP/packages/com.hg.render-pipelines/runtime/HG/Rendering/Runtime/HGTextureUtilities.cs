using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class HGTextureUtilities // TypeDefIndex: 38696
	{
		// Methods
		public static void WriteTextureFileToDisk(Texture target, string filePath) {} // 0x0000000189C45D64-0x0000000189C460B8
		// Void WriteTextureFileToDisk(Texture, String)
		void HG::Rendering::Runtime::HGTextureUtilities::WriteTextureFileToDisk(
		        Texture *target,
		        String *filePath,
		        MethodInfo *method)
		{
		  Object_1 *v5; // rsi
		  RenderTexture *v6; // rdi
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rax
		  ArgumentException *v10; // rax
		  ArgumentException *v11; // rbx
		  __int64 v12; // rax
		  int v13; // ebx
		  int32_t v14; // edi
		  Texture2D *v15; // rax
		  Texture *v16; // r14
		  CommandBuffer *v17; // rbp
		  int32_t i; // r12d
		  RenderTargetIdentifier *v19; // rax
		  int32_t v20; // edi
		  int32_t v21; // ebx
		  RenderTargetIdentifier *v22; // rax
		  int v23; // eax
		  Texture2D *v24; // rcx
		  Byte__Array *v25; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // [rsp+70h] [rbp-D8h]
		  RenderTargetIdentifier v28; // [rsp+80h] [rbp-C8h] BYREF
		  __int128 v29; // [rsp+B0h] [rbp-98h]
		  __int128 v30; // [rsp+C0h] [rbp-88h]
		  __int128 v31; // [rsp+D0h] [rbp-78h]
		  __int128 v32; // [rsp+E0h] [rbp-68h]
		  RenderTargetIdentifier v33; // [rsp+F0h] [rbp-58h] BYREF
		  __int64 v34; // [rsp+168h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4179, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4179, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)target,
		      (Object *)filePath,
		      0LL);
		  }
		  else
		  {
		    v5 = 0LL;
		    v6 = (RenderTexture *)sub_180005050(target, TypeInfo::UnityEngine::RenderTexture);
		    if ( target && (struct Cubemap__Class *)target->klass == TypeInfo::UnityEngine::Cubemap )
		      v5 = (Object_1 *)target;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)v6, 0LL, 0LL) )
		    {
		      v24 = HG::Rendering::Runtime::HGTextureUtilities::CopyRenderTextureToTexture2D(v6, 0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(v5, 0LL, 0LL) )
		      {
		        v9 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v10 = (ArgumentException *)sub_18002C620(v9);
		        v11 = v10;
		        if ( v10 )
		        {
		          System::ArgumentException::ArgumentException(v10, 0LL);
		          v12 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGTextureUtilities::WriteTextureFileToDisk);
		          sub_18007E190(v11, v12);
		        }
		        goto LABEL_18;
		      }
		      if ( !v5
		        || (v13 = sub_180002F70(5LL, v5),
		            v14 = sub_180002F70(7LL, v5),
		            v15 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D),
		            (v16 = (Texture *)v15) == 0LL)
		        || (UnityEngine::Texture2D::Texture2D(
		              v15,
		              6 * v13,
		              v14,
		              GraphicsFormat__Enum_R16G16B16A16_SFloat,
		              TextureCreationFlags__Enum_None,
		              0LL),
		            (v17 = (CommandBuffer *)sub_18002C620(TypeInfo::UnityEngine::Rendering::CommandBuffer)) == 0LL) )
		      {
		LABEL_18:
		        sub_1800D8260(v8, v7);
		      }
		      v17->fields.m_Ptr = UnityEngine::Rendering::CommandBuffer::InitBuffer(0LL);
		      UnityEngine::Rendering::CommandBuffer::set_name(v17, (String *)"CopyCubemapToTexture2D", 0LL);
		      for ( i = 0; i < 6; ++i )
		      {
		        v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, (Texture *)v5, 0LL);
		        v31 = *(_OWORD *)&v19->m_Type;
		        v32 = *(_OWORD *)&v19->m_BufferPointer;
		        v27 = *(_QWORD *)&v19->m_DepthSlice;
		        v20 = sub_180002F70(5LL, v5);
		        v21 = sub_180002F70(7LL, v5);
		        v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, v16, 0LL);
		        v29 = *(_OWORD *)&v22->m_Type;
		        v30 = *(_OWORD *)&v22->m_BufferPointer;
		        v34 = *(_QWORD *)&v22->m_DepthSlice;
		        v23 = sub_180002F70(5LL, v5);
		        *(_OWORD *)&v33.m_Type = v29;
		        *(_QWORD *)&v33.m_DepthSlice = v34;
		        *(_OWORD *)&v33.m_BufferPointer = v30;
		        *(_OWORD *)&v28.m_Type = v31;
		        *(_QWORD *)&v28.m_DepthSlice = v27;
		        *(_OWORD *)&v28.m_BufferPointer = v32;
		        UnityEngine::Rendering::CommandBuffer::CopyTexture(v17, &v28, i, 0, 0, 0, v20, v21, &v33, 0, 0, i * v23, 0, 0LL);
		      }
		      sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		      UnityEngine::Graphics::ExecuteCommandBuffer(v17, 0LL);
		      v24 = (Texture2D *)v16;
		    }
		    v25 = UnityEngine::ImageConversion::EncodeToEXR(v24, Texture2D_EXRFlags__Enum_CompressZIP, 0LL);
		    System::IO::File::WriteAllBytes(filePath, v25, 0LL);
		  }
		}
		
		public static Texture2D CopyRenderTextureToTexture2D(RenderTexture source) => default; // 0x0000000189C459D0-0x0000000189C45D64
		// Texture2D CopyRenderTextureToTexture2D(RenderTexture)
		Texture2D *HG::Rendering::Runtime::HGTextureUtilities::CopyRenderTextureToTexture2D(
		        RenderTexture *source,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // r13d
		  GraphicsFormat__Enum graphicsFormat; // r14d
		  int v7; // eax
		  int32_t v8; // esi
		  Texture2D *v9; // rax
		  Texture2D *v10; // rdi
		  __int64 v12; // rax
		  ArgumentException *v13; // rax
		  ArgumentException *v14; // rbx
		  __int64 v15; // rax
		  int32_t v16; // edi
		  RenderTextureFormat__Enum format; // eax
		  Texture *Temporary; // r12
		  CommandBuffer *v19; // rsi
		  int32_t v20; // r15d
		  RenderTargetIdentifier *v21; // rax
		  __int128 v22; // xmm7
		  __int128 v23; // xmm8
		  __int64 v24; // xmm6_8
		  RenderTargetIdentifier *v25; // rax
		  __int128 v26; // xmm1
		  __int64 v27; // xmm0_8
		  Texture2D *v28; // rax
		  Texture2D *v29; // rsi
		  RenderTexture *Active; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Rect v32; // [rsp+70h] [rbp-98h] BYREF
		  float v33; // [rsp+80h] [rbp-88h]
		  float v34; // [rsp+84h] [rbp-84h]
		  RenderTargetIdentifier v35; // [rsp+88h] [rbp-80h] BYREF
		  RenderTargetIdentifier v36[2]; // [rsp+B8h] [rbp-50h] BYREF
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(4180, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4180, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)source, 0LL);
		  }
		  else
		  {
		    if ( !source )
		      goto LABEL_15;
		    graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat(source, 0LL);
		    v7 = sub_180002F70(9LL, source);
		    if ( v7 == 2 )
		    {
		      v8 = sub_180002F70(5LL, source);
		      v9 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		      v10 = v9;
		      if ( v9 )
		      {
		        UnityEngine::Texture2D::Texture2D(v9, v8, v8, graphicsFormat, TextureCreationFlags__Enum_None, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		        UnityEngine::Graphics::SetRenderTarget(source, 0, 0LL);
		        *(_QWORD *)&v32.m_Width = 0LL;
		        v33 = (float)v8;
		        v34 = (float)v8;
		        UnityEngine::Texture2D::ReadPixels(v10, (Rect *)&v32.m_Width, 0, 0, 0LL);
		        UnityEngine::Texture2D::Apply(v10, 0LL);
		        UnityEngine::Graphics::SetRenderTarget(0LL, 0LL);
		        return v10;
		      }
		      goto LABEL_15;
		    }
		    if ( v7 != 4 )
		    {
		      v12 = sub_18007E180(&TypeInfo::System::ArgumentException);
		      v13 = (ArgumentException *)sub_18002C620(v12);
		      v14 = v13;
		      if ( v13 )
		      {
		        System::ArgumentException::ArgumentException(v13, 0LL);
		        v15 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGTextureUtilities::CopyRenderTextureToTexture2D);
		        sub_18007E190(v14, v15);
		      }
		      goto LABEL_15;
		    }
		    v16 = sub_180002F70(5LL, source);
		    format = UnityEngine::RenderTexture::get_format(source, 0LL);
		    Temporary = (Texture *)UnityEngine::RenderTexture::GetTemporary(6 * v16, v16, 0, format, 0LL);
		    v19 = (CommandBuffer *)sub_18002C620(TypeInfo::UnityEngine::Rendering::CommandBuffer);
		    if ( !v19 )
		      goto LABEL_15;
		    v19->fields.m_Ptr = UnityEngine::Rendering::CommandBuffer::InitBuffer(0LL);
		    v20 = 0;
		    do
		    {
		      v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v36, (Texture *)source, 0LL);
		      v22 = *(_OWORD *)&v21->m_Type;
		      v23 = *(_OWORD *)&v21->m_BufferPointer;
		      v24 = *(_QWORD *)&v21->m_DepthSlice;
		      v25 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v36, Temporary, 0LL);
		      v26 = *(_OWORD *)&v25->m_BufferPointer;
		      *(_OWORD *)&v35.m_Type = *(_OWORD *)&v25->m_Type;
		      v27 = *(_QWORD *)&v25->m_DepthSlice;
		      *(_OWORD *)&v35.m_BufferPointer = v26;
		      *(_QWORD *)&v35.m_DepthSlice = v27;
		      *(_OWORD *)&v36[0].m_Type = v22;
		      *(_OWORD *)&v36[0].m_BufferPointer = v23;
		      *(_QWORD *)&v36[0].m_DepthSlice = v24;
		      UnityEngine::Rendering::CommandBuffer::CopyTexture(v19, v36, v20++, 0, 0, 0, v16, v16, &v35, 0, 0, v5, 0, 0LL);
		      v5 += v16;
		    }
		    while ( v20 < 6 );
		    sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		    UnityEngine::Graphics::ExecuteCommandBuffer(v19, 0LL);
		    v28 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		    v29 = v28;
		    if ( !v28 )
		LABEL_15:
		      sub_1800D8260(v4, v3);
		    UnityEngine::Texture2D::Texture2D(v28, 6 * v16, v16, graphicsFormat, TextureCreationFlags__Enum_None, 0LL);
		    Active = UnityEngine::RenderTexture::GetActive(0LL);
		    UnityEngine::RenderTexture::SetActive((RenderTexture *)Temporary, 0LL);
		    *(_QWORD *)&v32.m_Width = 0LL;
		    v34 = (float)v16;
		    v33 = (float)(6 * v16);
		    UnityEngine::Texture2D::ReadPixels(v29, (Rect *)&v32.m_Width, 0, 0, 0, 0LL);
		    UnityEngine::RenderTexture::SetActive(Active, 0LL);
		    UnityEngine::RenderTexture::ReleaseTemporary((RenderTexture *)Temporary, 0LL);
		    return v29;
		  }
		}
		
	}
}
