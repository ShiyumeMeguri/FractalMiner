using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class RenderTextureManager // TypeDefIndex: 37921
	{
		// Fields
		private static List<RenderTexture> s_renderTextureCache; // 0x00
	
		// Constructors
		static RenderTextureManager() {} // 0x0000000184D56350-0x0000000184D563B0
		// RenderTextureManager()
		void HG::Rendering::Runtime::RenderTextureManager::cctor(MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  List_1_UnityEngine_RenderTexture_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  v1 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>);
		  v4 = (List_1_UnityEngine_RenderTexture_ *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v1,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::List);
		  TypeInfo::HG::Rendering::Runtime::RenderTextureManager->static_fields->s_renderTextureCache = v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::RenderTextureManager->static_fields,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
	
		// Methods
		public static RenderTexture GetRenderTexture(string name, int width, int height, int depthBufferBits = 0 /* Metadata: 0x023035C9 */, bool withAlpha = true /* Metadata: 0x023035CA */, bool isRawSize = false /* Metadata: 0x023035CB */, bool isCache = true /* Metadata: 0x023035CC */, bool hdr = false /* Metadata: 0x023035CD */, bool sRGB = false /* Metadata: 0x023035CE */, int msaaSamples = 1 /* Metadata: 0x023035CF */, GraphicsFormat format = GraphicsFormat.None /* Metadata: 0x023035D0 */) => default; // 0x00000001837E22D0-0x00000001837E24D0
		// RenderTexture GetRenderTexture(String, Int32, Int32, Int32, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, GraphicsFormat)
		RenderTexture *HG::Rendering::Runtime::RenderTextureManager::GetRenderTexture(
		        String *name,
		        int32_t width,
		        int32_t height,
		        int32_t depthBufferBits,
		        bool withAlpha,
		        bool isRawSize,
		        bool isCache,
		        bool hdr,
		        bool sRGB,
		        int32_t msaaSamples,
		        GraphicsFormat__Enum format,
		        MethodInfo *method)
		{
		  int32_t v12; // esi
		  int32_t v15; // edi
		  HGRenderPipeline_HGResolutionSettings *resolutionSettings; // rax
		  __int64 v17; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  FilterMode__Enum v19; // ebx
		  RenderTextureFormat__Enum v20; // edx
		  char v21; // si
		  int32_t v22; // r14d
		  RenderTexture *v23; // rax
		  Object_1 *v24; // rdi
		  struct RenderTextureManager__Class *v25; // rax
		  RenderTextureDescriptor v27; // [rsp+70h] [rbp-79h] BYREF
		  RenderTextureDescriptor v28; // [rsp+B0h] [rbp-39h] BYREF
		  int32_t widtha; // [rsp+128h] [rbp+3Fh] BYREF
		  int32_t heighta; // [rsp+130h] [rbp+47h] BYREF
		
		  heighta = height;
		  widtha = width;
		  v12 = width;
		  memset(&v27, 0, sizeof(v27));
		  v15 = height;
		  if ( IFix::WrappersManagerImpl::IsPatched(2252, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2252, 0LL);
		    if ( !Patch )
		      goto LABEL_6;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_908(
		             Patch,
		             (Object *)name,
		             v12,
		             v15,
		             depthBufferBits,
		             withAlpha,
		             isRawSize,
		             isCache,
		             hdr,
		             sRGB,
		             msaaSamples,
		             format,
		             0LL);
		  }
		  else
		  {
		    if ( !isRawSize )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      resolutionSettings = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		      if ( !resolutionSettings )
		LABEL_6:
		        sub_1800D8260(Patch, v17);
		      HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::ClampRenderTargetSize(
		        resolutionSettings,
		        &widtha,
		        &heighta,
		        0LL);
		      v15 = heighta;
		      v12 = widtha;
		    }
		    v19 = FilterMode__Enum_Point;
		    UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
		      &v27,
		      v12,
		      v15,
		      RenderTextureFormat__Enum_Default,
		      0,
		      0LL);
		    if ( sRGB )
		      UnityEngine::RenderTextureDescriptor::set_sRGB(&v27, 1, 0LL);
		    v27._depthStencilFormat_k__BackingField = UnityEngine::RenderTexture::GetDepthStencilFormatLegacy(
		                                                depthBufferBits,
		                                                (GraphicsFormat__Enum)v27._graphicsFormat,
		                                                0LL);
		    if ( format )
		      UnityEngine::RenderTextureDescriptor::set_graphicsFormat(&v27, format, 0LL);
		    if ( hdr )
		    {
		      v20 = RenderTextureFormat__Enum_RGB111110Float;
		      if ( withAlpha )
		        v20 = RenderTextureFormat__Enum_ARGBHalf;
		    }
		    else
		    {
		      v20 = RenderTextureFormat__Enum_ARGB32;
		    }
		    UnityEngine::RenderTextureDescriptor::set_colorFormat(&v27, v20, 0LL);
		    v27._depthStencilFormat_k__BackingField = 0;
		    v27._flags &= 0xFFFFFFFC;
		    v27._msaaSamples_k__BackingField = msaaSamples;
		    if ( msaaSamples > 1 )
		    {
		      v21 = 1;
		      v22 = 4;
		    }
		    else
		    {
		      v21 = 0;
		      v22 = 0;
		    }
		    v23 = (RenderTexture *)sub_1800368D0(TypeInfo::UnityEngine::RenderTexture);
		    v24 = (Object_1 *)v23;
		    if ( !v23 )
		      goto LABEL_6;
		    v28._memoryless_k__BackingField = v22;
		    *(_OWORD *)&v28._width_k__BackingField = *(_OWORD *)&v27._width_k__BackingField;
		    *(_OWORD *)&v28._mipCount_k__BackingField = *(_OWORD *)&v27._mipCount_k__BackingField;
		    *(_OWORD *)&v28._dimension_k__BackingField = *(_OWORD *)&v27._dimension_k__BackingField;
		    UnityEngine::RenderTexture::RenderTexture(v23, &v28, 0LL);
		    UnityEngine::Object::set_name(v24, name, 0LL);
		    UnityEngine::RenderTexture::Create((RenderTexture *)v24, 0LL);
		    if ( isCache )
		    {
		      v25 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		      if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		        v25 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		      }
		      Patch = (ILFixDynamicMethodWrapper_2 *)v25->static_fields->s_renderTextureCache;
		      if ( !Patch )
		        goto LABEL_6;
		      sub_182F01190((List_1_System_Object_ *)Patch, (Object *)v24);
		    }
		    if ( !v21 )
		      v19 = FilterMode__Enum_Bilinear;
		    UnityEngine::Texture::set_filterMode((Texture *)v24, v19, 0LL);
		    return (RenderTexture *)v24;
		  }
		}
		
		public static void ReleaseRenderTexture(RenderTexture renderTexture) {} // 0x000000018484FEE0-0x0000000184850030
		// Void ReleaseRenderTexture(RenderTexture)
		void HG::Rendering::Runtime::RenderTextureManager::ReleaseRenderTexture(
		        RenderTexture *renderTexture,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct RenderTextureManager__Class *v4; // rax
		  List_1_System_Object_ *s_renderTextureCache; // rcx
		  struct RenderTextureManager__Class *v6; // rax
		  struct Object_1__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2254, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2254, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)renderTexture, 0LL);
		  }
		  else
		  {
		    v4 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		      v4 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		    }
		    s_renderTextureCache = (List_1_System_Object_ *)v4->static_fields->s_renderTextureCache;
		    if ( !s_renderTextureCache )
		LABEL_9:
		      sub_1800D8260(s_renderTextureCache, v3);
		    if ( System::Collections::Generic::List<System::Object>::Contains(
		           s_renderTextureCache,
		           (Object *)renderTexture,
		           MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Contains) )
		    {
		      v6 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		      if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		        v6 = TypeInfo::HG::Rendering::Runtime::RenderTextureManager;
		      }
		      s_renderTextureCache = (List_1_System_Object_ *)v6->static_fields->s_renderTextureCache;
		      if ( !s_renderTextureCache )
		        goto LABEL_9;
		      System::Collections::Generic::List<System::Object>::Remove(
		        s_renderTextureCache,
		        (Object *)renderTexture,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Remove);
		    }
		    v7 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v7 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( renderTexture )
		    {
		      if ( !v7->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v7);
		        v7 = TypeInfo::UnityEngine::Object;
		      }
		      if ( renderTexture->fields._._.m_CachedPtr )
		      {
		        if ( !v7->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v7);
		        if ( UnityEngine::Object::op_Implicit((Object_1 *)renderTexture, 0LL) )
		        {
		          UnityEngine::RenderTexture::Release(renderTexture, 0LL);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          UnityEngine::Object::DestroyImmediate((Object_1 *)renderTexture, 1, 0LL);
		        }
		      }
		    }
		  }
		}
		
		public static void ClearRenderTexture() {} // 0x0000000189B5B77C-0x0000000189B5BAE4
		// Void ClearRenderTexture()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::RenderTextureManager::ClearRenderTexture(MethodInfo *method)
		{
		  __int64 j; // rdi
		  __int64 v2; // rdx
		  RenderTextureManager__StaticFields *static_fields; // rcx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  GameObject__Array *RootGameObjects; // rsi
		  int32_t i; // ebx
		  Object__Array *v8; // r14
		  Camera *v9; // r15
		  __int64 v10; // rdx
		  List_1_System_UInt64_ **v11; // rcx
		  Object *current; // rbx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // rdx
		  List_1_UnityEngine_RenderTexture_ *s_renderTextureCache; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // kr10_8
		  Il2CppExceptionWrapper *v21; // rbx
		  Il2CppClass *klass; // rdi
		  __int64 v23; // rax
		  Il2CppExceptionWrapper v24; // [rsp+20h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+28h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v26; // [rsp+30h] [rbp-58h] BYREF
		  List_1_T_Enumerator_System_Object_ v27; // [rsp+38h] [rbp-50h] BYREF
		  List_1_T_Enumerator_System_Object_ v28; // [rsp+50h] [rbp-38h] BYREF
		  Scene v29; // [rsp+98h] [rbp+10h] BYREF
		
		  memset(&v28, 0, sizeof(v28));
		  if ( IFix::WrappersManagerImpl::IsPatched(2352, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2352, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::RenderTextureManager->static_fields;
		    if ( !static_fields->s_renderTextureCache )
		      sub_1800D8260(static_fields, v2);
		    if ( static_fields->s_renderTextureCache->fields._size )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::SceneManagement::SceneManager);
		      v29.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
		      RootGameObjects = UnityEngine::SceneManagement::Scene::GetRootGameObjects(&v29, 0LL);
		      for ( i = 0; ; ++i )
		      {
		        if ( !RootGameObjects )
		          sub_1800D8260(v5, v4);
		        if ( i >= RootGameObjects->max_length.size )
		          break;
		        if ( (unsigned int)i >= RootGameObjects->max_length.size )
		          sub_1800D2AB0(v5, v4);
		        if ( !RootGameObjects->vector[i] )
		          sub_1800D8260(v5, v4);
		        v8 = UnityEngine::GameObject::GetComponentsInChildren<System::Object>(
		               RootGameObjects->vector[i],
		               1,
		               MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Camera>);
		        for ( j = 0LL; ; j = (unsigned int)(j + 1) )
		        {
		          if ( !v8 )
		            sub_1800D8260(v5, v4);
		          if ( (int)j >= v8->max_length.size )
		            break;
		          if ( (unsigned int)j >= v8->max_length.size )
		            sub_1800D2AB0(v5, v4);
		          v9 = (Camera *)v8->vector[(int)j];
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit((Object_1 *)v9, 0LL) )
		          {
		            if ( !v9 )
		              sub_1800D8260(v5, v4);
		            UnityEngine::Camera::set_targetTexture(v9, 0LL, 0LL);
		          }
		        }
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		      v11 = (List_1_System_UInt64_ **)TypeInfo::HG::Rendering::Runtime::RenderTextureManager->static_fields;
		      if ( !*v11 )
		        sub_1800D8260(v11, v10);
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v27,
		        *v11,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::GetEnumerator);
		      v28 = v27;
		      v27._list = 0LL;
		      *(_QWORD *)&v27._index = &v28;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v28,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RenderTexture>::MoveNext) )
		        {
		          current = v28._current;
		          try
		          {
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Inequality((Object_1 *)current, 0LL, 0LL) )
		            {
		              sub_1800036A0(TypeInfo::UnityEngine::Object);
		              if ( UnityEngine::Object::op_Implicit((Object_1 *)current, 0LL) )
		              {
		                if ( !current )
		                  sub_1800D8250(v14, v13);
		                UnityEngine::RenderTexture::Release((RenderTexture *)current, 0LL);
		                sub_1800036A0(TypeInfo::UnityEngine::Object);
		                UnityEngine::Object::DestroyImmediate((Object_1 *)current, 1, 0LL);
		              }
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v25 )
		          {
		            v20 = j;
		            v21 = v25;
		            klass = v25->ex->object.klass;
		            v23 = sub_180035ED0(&TypeInfo::System::Object);
		            if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v23, klass) )
		            {
		              v24.ex = v21->ex;
		              throw &v24;
		            }
		            j = v20;
		            continue;
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v26 )
		      {
		        v27._list = (List_1_System_Object_ *)v26->ex;
		        if ( v27._list )
		          sub_18007E1E0(v27._list);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		      s_renderTextureCache = TypeInfo::HG::Rendering::Runtime::RenderTextureManager->static_fields->s_renderTextureCache;
		      if ( !s_renderTextureCache )
		        sub_1800D8250(0LL, v15);
		      sub_183127A90(
		        s_renderTextureCache,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RenderTexture>::Clear);
		    }
		  }
		}
		
	}
}
