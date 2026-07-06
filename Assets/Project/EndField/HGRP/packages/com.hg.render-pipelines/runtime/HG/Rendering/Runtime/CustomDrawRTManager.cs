using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class CustomDrawRTManager
	{
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000025D2 File Offset: 0x000007D2
		public static CustomDrawRTManager Instance
		{
			get
			{
				// // CustomDrawRTManager get_Instance()
				// CustomDrawRTManager *HG::Rendering::Runtime::CustomDrawRTManager::get_Instance(MethodInfo *method)
				// {
				//   if ( !byte_18D8EDD17 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager);
				//     byte_18D8EDD17 = 1;
				//   }
				//   return TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager.static_fields.s_instance;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000025D0 File Offset: 0x000007D0
		public static bool EnableCppCustomDraw
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_EnableCppCustomDraw()
				// bool HG::Rendering::Runtime::CustomDrawRTManager::get_EnableCppCustomDraw(MethodInfo *method)
				// {
				//   if ( !byte_18D919ECB )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager);
				//     byte_18D919ECB = 1;
				//   }
				//   return TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager.static_fields._EnableCppCustomDraw_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_EnableCppCustomDraw(Boolean)
				// void HG::Rendering::Runtime::CustomDrawRTManager::set_EnableCppCustomDraw(bool value, MethodInfo *method)
				// {
				//   if ( !byte_18D919ECC )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager);
				//     byte_18D919ECC = 1;
				//   }
				//   TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager.static_fields._EnableCppCustomDraw_k__BackingField = value;
				// }
				// 
			}
		}

		private CustomDrawRTManager(long cppImpl)
		{
		}

		public static void Init(long customDrawRTManager)
		{
		}

		public static void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::CustomDrawRTManager::Reset(MethodInfo *method)
			// {
			//   OneofDescriptorProto *v1; // rdx
			//   FileDescriptor *v2; // r8
			//   MessageDescriptor *v3; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   String__Array *v7; // [rsp+50h] [rbp+28h]
			//   String *v8; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v9; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDD19 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager);
			//     byte_18D8EDD19 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(499, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(499, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager.static_fields.s_instance = 0LL;
			//     sub_1800054D0(
			//       (OneofDescriptor *)TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager.static_fields,
			//       v1,
			//       v2,
			//       v3,
			//       v7,
			//       v8,
			//       v9);
			//   }
			// }
			// 
		}

		public RenderTexture AllocateRenderTexture(int width, int height, [MetadataOffset(Offset = "0x01F90E80")] int mipCount = 1, [MetadataOffset(Offset = "0x01F90E81")] GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, [MetadataOffset(Offset = "0x01F90E82")] GraphicsFormat depthStencilFormat = GraphicsFormat.None)
		{
			// // RenderTexture AllocateRenderTexture(Int32, Int32, Int32, GraphicsFormat, GraphicsFormat)
			// RenderTexture *HG::Rendering::Runtime::CustomDrawRTManager::AllocateRenderTexture(
			//         CustomDrawRTManager *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t mipCount,
			//         GraphicsFormat__Enum colorFormat,
			//         GraphicsFormat__Enum depthStencilFormat,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D8EDD1B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D8EDD1B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1897, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1897, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_744(
			//              Patch,
			//              (Object *)this,
			//              width,
			//              height,
			//              mipCount,
			//              colorFormat,
			//              depthStencilFormat,
			//              0LL);
			//   }
			//   else if ( (unsigned __int8)sub_183114F20() )
			//   {
			//     return UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_AllocateRenderTexture(
			//              this.fields.m_CppImpl,
			//              width,
			//              height,
			//              1,
			//              mipCount,
			//              colorFormat,
			//              depthStencilFormat,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager, v11);
			//     return HG::Rendering::Runtime::RenderTextureManager::GetRenderTexture(
			//              (String *)"",
			//              width,
			//              height,
			//              0,
			//              1,
			//              1,
			//              1,
			//              0,
			//              0,
			//              1,
			//              GraphicsFormat__Enum_None,
			//              0LL);
			//   }
			// }
			// 
			return null;
		}

		public void ReleaseRenderTexture(RenderTexture rt)
		{
			// // Void ReleaseRenderTexture(RenderTexture)
			// void HG::Rendering::Runtime::CustomDrawRTManager::ReleaseRenderTexture(
			//         CustomDrawRTManager *this,
			//         RenderTexture *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8EDD1C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     byte_18D8EDD1C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1900, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1900, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)rt,
			//       0LL);
			//   }
			//   else if ( (unsigned __int8)sub_183114F20() )
			//   {
			//     UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_ReleaseRenderTexture(
			//       this.fields.m_CppImpl,
			//       rt,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager, v5);
			//     HG::Rendering::Runtime::RenderTextureManager::ReleaseRenderTexture(rt, 0LL);
			//   }
			// }
			// 
		}

		public void ClearTexture(RenderTexture rt, Color color)
		{
			// // Void ClearTexture(RenderTexture, Color)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CustomDrawRTManager::ClearTexture(
			//         CustomDrawRTManager *this,
			//         RenderTexture *rt,
			//         Color *color,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int64_t m_CppImpl; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   CustomDrawRTManager_AutoRestRT v14; // [rsp+30h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+38h] [rbp-40h] BYREF
			//   _QWORD v16[2]; // [rsp+40h] [rbp-38h] BYREF
			//   Color backgroundColor; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDD1D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDD1D = 1;
			//   }
			//   v14.rt = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1902, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1902, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     backgroundColor = *color;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_746(Patch, (Object *)this, (Object *)rt, &backgroundColor, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)rt, 0LL, 0LL) )
			//     {
			//       if ( (unsigned __int8)sub_183114F20() )
			//       {
			//         m_CppImpl = this.fields.m_CppImpl;
			//         if ( !rt )
			//           sub_180B536AC(v9, v8);
			//         UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_ClearTextureImpl(
			//           m_CppImpl,
			//           rt.fields._._.m_CachedPtr,
			//           color,
			//           0LL);
			//       }
			//       else
			//       {
			//         HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::AutoRestRT(&v14, rt, 0LL);
			//         v16[0] = 0LL;
			//         v16[1] = &v14;
			//         try
			//         {
			//           backgroundColor = *color;
			//           UnityEngine::GL::GLClear_Injected(1, 1, &backgroundColor, 1.0, 0LL);
			//         }
			//         catch ( Il2CppExceptionWrapper *v15 )
			//         {
			//           v16[0] = v15.ex;
			//         }
			//         sub_1802270B0(v16);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void DrawTexture(RenderTexture rt, in Rect rect, Texture texture, Material mat)
		{
			// // Void DrawTexture(RenderTexture, Rect ByRef, Texture, Material)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CustomDrawRTManager::DrawTexture(
			//         CustomDrawRTManager *this,
			//         RenderTexture *rt,
			//         Rect *rect,
			//         Texture *texture,
			//         Material *mat,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   CommandBuffer *m_CommandBuffer; // r15
			//   Rect v14; // xmm6
			//   int v15; // eax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   float m_Width; // xmm4_4
			//   float v19; // xmm3_4
			//   void (__fastcall *v20)(CommandBuffer *, _DWORD *); // rax
			//   __int64 v21; // rdx
			//   MaterialPropertyBlock *m_Props; // rcx
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   MaterialPropertyBlock *v25; // rdi
			//   __m128i si128; // xmm6
			//   unsigned int v27; // esi
			//   void (__fastcall *v28)(MaterialPropertyBlock *, _QWORD, __m128i *); // rax
			//   CommandBuffer *v29; // rdi
			//   Matrix4x4 *v30; // rax
			//   __int64 v31; // rdx
			//   MaterialPropertyBlock *v32; // rcx
			//   __int64 v33; // rdx
			//   CommandBuffer *v34; // rdi
			//   __int64 v35; // rdx
			//   CommandBuffer *v36; // rcx
			//   __int64 v37; // rdx
			//   MaterialPropertyBlock *v38; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rax
			//   __int64 v43; // rax
			//   CustomDrawRTManager_AutoRestRT v44; // [rsp+50h] [rbp-F8h] BYREF
			//   _DWORD v45[4]; // [rsp+60h] [rbp-E8h] BYREF
			//   _QWORD v46[2]; // [rsp+70h] [rbp-D8h] BYREF
			//   Il2CppExceptionWrapper *v47; // [rsp+80h] [rbp-C8h] BYREF
			//   __m128i v48; // [rsp+90h] [rbp-B8h] BYREF
			//   Matrix4x4 v49; // [rsp+A0h] [rbp-A8h] BYREF
			//   _BYTE v50[80]; // [rsp+E0h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D8EDD1E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9A3448);
			//     sub_18003C530(&off_18C9CB878);
			//     byte_18D8EDD1E = 1;
			//   }
			//   v44.rt = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1904, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1904, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v41, v40);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_747(
			//       Patch,
			//       (Object *)this,
			//       (Object *)rt,
			//       rect,
			//       (Object *)texture,
			//       (Object *)mat,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v10);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)rt, 0LL, 0LL) )
			//     {
			//       if ( (unsigned __int8)sub_183114F20() )
			//       {
			//         UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_DrawTexture(
			//           this.fields.m_CppImpl,
			//           rt,
			//           rect,
			//           texture,
			//           mat,
			//           0,
			//           0LL);
			//       }
			//       else
			//       {
			//         HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::AutoRestRT(&v44, rt, 0LL);
			//         v46[0] = 0LL;
			//         v46[1] = &v44;
			//         try
			//         {
			//           m_CommandBuffer = this.fields.m_CommandBuffer;
			//           v14 = *rect;
			//           if ( !rt )
			//             sub_1802DC2C8(v12, v11);
			//           v15 = sub_18003ED00(7LL);
			//           m_Width = rect.m_Width;
			//           v19 = (float)((float)v15 - rect.m_YMin) - rect.m_Height;
			//           if ( !m_CommandBuffer )
			//             sub_1802DC2C8(v17, v16);
			//           v45[0] = LODWORD(v14.m_XMin);
			//           *(float *)&v45[1] = v19;
			//           *(float *)&v45[2] = m_Width;
			//           v45[3] = LODWORD(rect.m_Height);
			//           v20 = (void (__fastcall *)(CommandBuffer *, _DWORD *))qword_18D92FCA8;
			//           if ( !qword_18D92FCA8 )
			//           {
			//             v20 = (void (__fastcall *)(CommandBuffer *, _DWORD *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Rendering.CommandBuffer::SetViewport_Inj"
			//                                                                     "ected(UnityEngine.Rect&)");
			//             if ( !v20 )
			//             {
			//               v42 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetViewport_Injected(UnityEngine.Rect&)");
			//               sub_18000F750(v42, 0LL);
			//             }
			//             qword_18D92FCA8 = (__int64)v20;
			//           }
			//           v20(m_CommandBuffer, v45);
			//           m_Props = this.fields.m_Props;
			//           if ( !m_Props )
			//             sub_1802DC2C8(0LL, v21);
			//           UnityEngine::MaterialPropertyBlock::HGSetTexture(m_Props, (String *)"_MainTex", texture, 0LL);
			//           v25 = this.fields.m_Props;
			//           if ( !v25 )
			//             sub_1802DC2C8(v24, v23);
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//           v27 = UnityEngine::Shader::PropertyToID((String *)"_MainTex_ST", 0LL);
			//           v48 = si128;
			//           v28 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD, __m128i *))qword_18D8F4568;
			//           if ( !qword_18D8F4568 )
			//           {
			//             v28 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD, __m128i *))il2cpp_resolve_icall_0(
			//                                                                                      "UnityEngine.MaterialPropertyBlock::"
			//                                                                                      "SetVectorImpl_Injected(System.Int32"
			//                                                                                      ",UnityEngine.Vector4&)");
			//             if ( !v28 )
			//             {
			//               v43 = sub_1802DBBE8("UnityEngine.MaterialPropertyBlock::SetVectorImpl_Injected(System.Int32,UnityEngine.Vector4&)");
			//               sub_18000F750(v43, 0LL);
			//             }
			//             qword_18D8F4568 = (__int64)v28;
			//           }
			//           v28(v25, v27, &v48);
			//           v29 = this.fields.m_CommandBuffer;
			//           v30 = (Matrix4x4 *)sub_182805160(v50);
			//           v32 = this.fields.m_Props;
			//           if ( !v29 )
			//             sub_1802DC2C8(v32, v31);
			//           v49 = *v30;
			//           UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//             v29,
			//             &v49,
			//             mat,
			//             0,
			//             MeshTopology__Enum_Triangles,
			//             3,
			//             1,
			//             v32,
			//             0LL);
			//           v34 = this.fields.m_CommandBuffer;
			//           if ( !TypeInfo::UnityEngine::Graphics._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Graphics, v33);
			//           UnityEngine::Graphics::ExecuteCommandBuffer(v34, 0LL);
			//           v36 = this.fields.m_CommandBuffer;
			//           if ( !v36 )
			//             sub_1802DC2C8(0LL, v35);
			//           UnityEngine::Rendering::CommandBuffer::Clear(v36, 0LL);
			//           v38 = this.fields.m_Props;
			//           if ( !v38 )
			//             sub_1802DC2C8(0LL, v37);
			//           UnityEngine::MaterialPropertyBlock::Clear(v38, 1, 0LL);
			//         }
			//         catch ( Il2CppExceptionWrapper *v47 )
			//         {
			//           v46[0] = v47.ex;
			//         }
			//         sub_1802270B0(v46);
			//       }
			//     }
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static CustomDrawRTManager s_instance;

		private CommandBuffer m_CommandBuffer;

		private MaterialPropertyBlock m_Props;

		private long m_CppImpl;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct AutoRestRT : IDisposable
		{
			public AutoRestRT(RenderTexture _rt)
			{
			}

			public void Dispose()
			{
				// // Void Dispose()
				// void HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::Dispose(
				//         CustomDrawRTManager_AutoRestRT *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1903, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1903, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_745(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     UnityEngine::RenderTexture::SetActive(this.rt, 0LL);
				//   }
				// }
				// 
			}

			private RenderTexture rt;
		}
	}
}
