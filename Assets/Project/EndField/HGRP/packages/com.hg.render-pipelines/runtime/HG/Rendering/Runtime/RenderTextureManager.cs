using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace HG.Rendering.Runtime
{
	public static class RenderTextureManager
	{
		public static RenderTexture GetRenderTexture(string name, int width, int height, [MetadataOffset(Offset = "0x01F9124F")] int depthBufferBits = 0, [MetadataOffset(Offset = "0x01F91250")] bool withAlpha = true, [MetadataOffset(Offset = "0x01F91251")] bool isRawSize = false, [MetadataOffset(Offset = "0x01F91252")] bool isCache = true, [MetadataOffset(Offset = "0x01F91253")] bool hdr = false, [MetadataOffset(Offset = "0x01F91254")] bool sRGB = false, [MetadataOffset(Offset = "0x01F91255")] int msaaSamples = 1, [MetadataOffset(Offset = "0x01F91256")] GraphicsFormat format = GraphicsFormat.None)
		{
			// // RenderTexture GetRenderTexture(String, Int32, Int32, Int32, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, GraphicsFormat)
			// RenderTexture *HG::Rendering::Runtime::RenderTextureManager::GetRenderTexture(
			//         String *name,
			//         int32_t width,
			//         int32_t height,
			//         int32_t depthBufferBits,
			//         bool withAlpha,
			//         bool isRawSize,
			//         bool isCache,
			//         bool hdr,
			//         bool sRGB,
			//         int32_t msaaSamples,
			//         GraphicsFormat__Enum format,
			//         MethodInfo *method)
			// {
			//   int32_t v13; // edi
			//   int32_t v14; // esi
			//   __int64 v16; // rdx
			//   struct HGRenderPipeline__Class *v17; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v18; // rax
			//   __int64 v19; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   FilterMode__Enum v21; // ebx
			//   RenderTextureFormat__Enum v22; // edx
			//   char v23; // si
			//   int32_t v24; // r14d
			//   RenderTexture *v25; // rax
			//   Object_1 *v26; // rdi
			//   struct RenderTextureManager__Class *v27; // rax
			//   RenderTextureDescriptor v29; // [rsp+70h] [rbp-79h] BYREF
			//   RenderTextureDescriptor v30; // [rsp+B0h] [rbp-39h] BYREF
			//   int32_t widtha; // [rsp+128h] [rbp+3Fh] BYREF
			//   int32_t heighta; // [rsp+130h] [rbp+47h] BYREF
			// 
			//   heighta = height;
			//   widtha = width;
			//   v13 = height;
			//   v14 = width;
			//   if ( !byte_18D8ED973 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     byte_18D8ED973 = 1;
			//   }
			//   memset(&v29, 0, sizeof(v29));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1899, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1899, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_743(
			//                Patch,
			//                (Object *)name,
			//                v14,
			//                v13,
			//                depthBufferBits,
			//                withAlpha,
			//                isRawSize,
			//                isCache,
			//                hdr,
			//                sRGB,
			//                msaaSamples,
			//                format,
			//                0LL);
			//     goto LABEL_26;
			//   }
			//   if ( !isRawSize )
			//   {
			//     v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipeline;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v16);
			//     v18 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v17, v16);
			//     if ( !v18 )
			//       goto LABEL_26;
			//     HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::ClampRenderTargetSize(v18, &widtha, &heighta, 0LL);
			//     v13 = heighta;
			//     v14 = widtha;
			//   }
			//   v21 = FilterMode__Enum_Point;
			//   UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
			//     &v29,
			//     v14,
			//     v13,
			//     RenderTextureFormat__Enum_Default,
			//     0,
			//     0LL);
			//   if ( sRGB )
			//     UnityEngine::RenderTextureDescriptor::set_sRGB(&v29, 1, 0LL);
			//   v29._depthStencilFormat_k__BackingField = UnityEngine::RenderTexture::GetDepthStencilFormatLegacy(
			//                                               depthBufferBits,
			//                                               (GraphicsFormat__Enum)v29._graphicsFormat,
			//                                               0LL);
			//   if ( format )
			//     UnityEngine::RenderTextureDescriptor::set_graphicsFormat(&v29, format, 0LL);
			//   if ( hdr )
			//   {
			//     v22 = RenderTextureFormat__Enum_RGB111110Float;
			//     if ( withAlpha )
			//       v22 = RenderTextureFormat__Enum_ARGBHalf;
			//   }
			//   else
			//   {
			//     v22 = RenderTextureFormat__Enum_ARGB32;
			//   }
			//   UnityEngine::RenderTextureDescriptor::set_colorFormat(&v29, v22, 0LL);
			//   v29._depthStencilFormat_k__BackingField = 0;
			//   v29._flags &= 0xFFFFFFFC;
			//   v29._msaaSamples_k__BackingField = msaaSamples;
			//   if ( msaaSamples > 1 )
			//   {
			//     v23 = 1;
			//     v24 = 4;
			//   }
			//   else
			//   {
			//     v23 = 0;
			//     v24 = 0;
			//   }
			//   v25 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//   v26 = (Object_1 *)v25;
			//   if ( !v25 )
			//     goto LABEL_26;
			//   v30._memoryless_k__BackingField = v24;
			//   *(_OWORD *)&v30._width_k__BackingField = *(_OWORD *)&v29._width_k__BackingField;
			//   *(_OWORD *)&v30._mipCount_k__BackingField = *(_OWORD *)&v29._mipCount_k__BackingField;
			//   *(_OWORD *)&v30._dimension_k__BackingField = *(_OWORD *)&v29._dimension_k__BackingField;
			//   UnityEngine::RenderTexture::RenderTexture(v25, &v30, 0LL);
			//   UnityEngine::Object::set_name(v26, name, 0LL);
			//   UnityEngine::RenderTexture::Create((RenderTexture *)v26, 0LL);
			//   if ( isCache )
			//   {
			//     v27 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager, v19);
			//       v27 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//     }
			//     Patch = (ILFixDynamicMethodWrapper_2 *)v27.static_fields.s_renderTextureCache;
			//     if ( Patch )
			//     {
			//       sub_1822AD140((List_1_System_Object_ *)Patch, (Object *)v26);
			//       goto LABEL_23;
			//     }
			// LABEL_26:
			//     sub_180B536AC(Patch, v19);
			//   }
			// LABEL_23:
			//   if ( !v23 )
			//     v21 = FilterMode__Enum_Bilinear;
			//   UnityEngine::Texture::set_filterMode((Texture *)v26, v21, 0LL);
			//   return (RenderTexture *)v26;
			// }
			// 
			return null;
		}

		public static void ReleaseRenderTexture(RenderTexture renderTexture)
		{
			// // Void ReleaseRenderTexture(RenderTexture)
			// void HG::Rendering::Runtime::RenderTextureManager::ReleaseRenderTexture(
			//         RenderTexture *renderTexture,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct RenderTextureManager__Class *v4; // rax
			//   List_1_System_Object_ *s_renderTextureCache; // rcx
			//   struct RenderTextureManager__Class *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED974 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Remove);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     byte_18D8ED974 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1901, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1901, 0LL);
			//     if ( !Patch )
			//       goto LABEL_7;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)renderTexture, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//     }
			//     s_renderTextureCache = (List_1_System_Object_ *)v4.static_fields.s_renderTextureCache;
			//     if ( !s_renderTextureCache )
			// LABEL_7:
			//       sub_180B536AC(s_renderTextureCache, v3);
			//     if ( System::Collections::Generic::List<System::Object>::Contains(
			//            s_renderTextureCache,
			//            (Object *)renderTexture,
			//            MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Contains) )
			//     {
			//       v6 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//       if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager, v3);
			//         v6 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
			//       }
			//       s_renderTextureCache = (List_1_System_Object_ *)v6.static_fields.s_renderTextureCache;
			//       if ( !s_renderTextureCache )
			//         goto LABEL_7;
			//       System::Collections::Generic::List<System::Object>::Remove(
			//         s_renderTextureCache,
			//         (Object *)renderTexture,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Remove);
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)renderTexture, 0LL, 0LL) )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//       if ( UnityEngine::Object::op_Implicit((Object_1 *)renderTexture, 0LL) )
			//       {
			//         if ( !renderTexture )
			//           goto LABEL_7;
			//         UnityEngine::RenderTexture::Release(renderTexture, 0LL);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//         UnityEngine::Object::DestroyImmediate((Object_1 *)renderTexture, 1, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public static void ClearRenderTexture()
		{
			// // Void ClearRenderTexture()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::RenderTextureManager::ClearRenderTexture(MethodInfo *method)
			// {
			//   __int64 j; // rdi
			//   __int64 v2; // rdx
			//   RenderTextureManager__StaticFields *static_fields; // rcx
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   GameObject__Array *RootGameObjects; // rsi
			//   int32_t i; // ebx
			//   Object__Array *v8; // r14
			//   Camera *v9; // r15
			//   __int64 v10; // rdx
			//   List_1_System_Object_ **v11; // rcx
			//   Object *current; // rbx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // rdx
			//   List_1_UnityEngine_RenderTexture_ *s_renderTextureCache; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // kr10_8
			//   Il2CppExceptionWrapper *v21; // rbx
			//   Il2CppClass *klass; // rdi
			//   __int64 v23; // rax
			//   Il2CppExceptionWrapper v24; // [rsp+20h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v25; // [rsp+28h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+30h] [rbp-58h] BYREF
			//   List_1_T_Enumerator_System_Object_ v27; // [rsp+38h] [rbp-50h] BYREF
			//   List_1_T_Enumerator_System_Object_ v28; // [rsp+50h] [rbp-38h] BYREF
			//   Scene v29; // [rsp+98h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D9193ED )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RenderTexture>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RenderTexture>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RenderTexture>::get_Current);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Camera>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     byte_18D9193ED = 1;
			//   }
			//   memset(&v28, 0, sizeof(v28));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1982, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1982, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v19, v18);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::RenderTextureManager.static_fields;
			//     if ( !static_fields.s_renderTextureCache )
			//       sub_180B536AC(static_fields, v2);
			//     if ( static_fields.s_renderTextureCache.fields._size )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//       v29.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
			//       RootGameObjects = UnityEngine::SceneManagement::Scene::GetRootGameObjects(&v29, 0LL);
			//       for ( i = 0; ; ++i )
			//       {
			//         if ( !RootGameObjects )
			//           sub_180B536AC(v5, v4);
			//         if ( i >= RootGameObjects.max_length.size )
			//           break;
			//         if ( (unsigned int)i >= RootGameObjects.max_length.size )
			//           sub_180070270(v5, v4);
			//         if ( !RootGameObjects.vector[i] )
			//           sub_180B536AC(v5, v4);
			//         v8 = UnityEngine::GameObject::GetComponentsInChildren<System::Object>(
			//                RootGameObjects.vector[i],
			//                1,
			//                MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Camera>);
			//         for ( j = 0LL; ; j = (unsigned int)(j + 1) )
			//         {
			//           if ( !v8 )
			//             sub_180B536AC(v5, v4);
			//           if ( (int)j >= v8.max_length.size )
			//             break;
			//           if ( (unsigned int)j >= v8.max_length.size )
			//             sub_180070270(v5, v4);
			//           v9 = (Camera *)v8.vector[(int)j];
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Implicit((Object_1 *)v9, 0LL) )
			//           {
			//             if ( !v9 )
			//               sub_180B536AC(v5, v4);
			//             UnityEngine::Camera::set_targetTexture(v9, 0LL, 0LL);
			//           }
			//         }
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//       v11 = (List_1_System_Object_ **)TypeInfo::HG::Rendering::Runtime::RenderTextureManager.static_fields;
			//       if ( !*v11 )
			//         sub_180B536AC(v11, v10);
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         &v27,
			//         *v11,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::GetEnumerator);
			//       v28 = v27;
			//       v27._list = 0LL;
			//       *(_QWORD *)&v27._index = &v28;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v28,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RenderTexture>::MoveNext) )
			//         {
			//           current = v28._current;
			//           try
			//           {
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Inequality((Object_1 *)current, 0LL, 0LL) )
			//             {
			//               sub_180002C70(TypeInfo::UnityEngine::Object);
			//               if ( UnityEngine::Object::op_Implicit((Object_1 *)current, 0LL) )
			//               {
			//                 if ( !current )
			//                   sub_1802DC2C8(v14, v13);
			//                 UnityEngine::RenderTexture::Release((RenderTexture *)current, 0LL);
			//                 sub_180002C70(TypeInfo::UnityEngine::Object);
			//                 UnityEngine::Object::DestroyImmediate((Object_1 *)current, 1, 0LL);
			//               }
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v25 )
			//           {
			//             v20 = j;
			//             v21 = v25;
			//             klass = v25.ex.object.klass;
			//             v23 = sub_18003C530(&TypeInfo::System::Object);
			//             if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v23, klass) )
			//             {
			//               v24.ex = v21.ex;
			//               throw &v24;
			//             }
			//             j = v20;
			//             continue;
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v26 )
			//       {
			//         v27._list = (List_1_System_Object_ *)v26.ex;
			//         if ( v27._list )
			//           sub_18000F780(v27._list);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
			//       s_renderTextureCache = TypeInfo::HG::Rendering::Runtime::RenderTextureManager.static_fields.s_renderTextureCache;
			//       if ( !s_renderTextureCache )
			//         sub_1802DC2C8(0LL, v15);
			//       sub_1823B99D0(
			//         s_renderTextureCache,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Clear);
			//     }
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static List<RenderTexture> s_renderTextureCache;
	}
}
