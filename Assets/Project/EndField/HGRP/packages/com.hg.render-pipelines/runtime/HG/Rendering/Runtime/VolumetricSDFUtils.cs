using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.SDF;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VolumetricSDFUtils // TypeDefIndex: 38761
	{
		// Fields
		public const float MAX_DEPTH = 10000f; // Metadata: 0x023040EE
		public const int DEPTH_BITS = 24; // Metadata: 0x023040F2
		public const float MIN_OPTICAL_DEPTH = 0.01f; // Metadata: 0x023040F3
		public const float MAX_OPTICAL_DEPTH = 100f; // Metadata: 0x023040F7
		public const string VOLUMETRIC_MAT_PATH_ROOT = "Assets/Beyond/Arts/Environment/VolumetricCloud/"; // Metadata: 0x023040FB
		public const string VOLUMETRIC_SDF_PATH_ROOT = "Assets/Beyond/Arts/Environment/VolumetricCloud/Sdf/"; // Metadata: 0x0230412B
		public static readonly int Layer_Default; // 0x00
		public static readonly int Layer_Invisible; // 0x04
		private static Mesh _cubeMesh; // 0x08
		private static Mesh _quadMesh; // 0x10
		private static Mesh _sphereMesh; // 0x18
		private static Mesh _blitMesh; // 0x20
		private static Mesh _blitMeshBackface; // 0x28
		private static RenderTargetIdentifier[] _RTs; // 0x30
		private static RenderBufferLoadAction[] _Loads; // 0x38
		private static RenderBufferStoreAction[] _Stores; // 0x40
		private static string[] s_MV_MODES; // 0x48
	
		// Properties
		public static Mesh CubeMesh { get; } // 0x00000001847F1C80-0x00000001847F1DD0 
		public static Mesh QuadMesh { get; } // 0x0000000189C61F6C-0x0000000189C62058 
		public static Mesh SphereMesh { get; } // 0x0000000189C62058-0x0000000189C62144 
		public static Mesh BlitMesh { get; } // 0x0000000189C61C34-0x0000000189C61F6C 
		// Mesh get_BlitMesh()
		Mesh *HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(MethodInfo *method)
		{
		  Object_1 *blitMesh; // rbx
		  Mesh *v2; // rax
		  __int64 v3; // rdx
		  Mesh *v4; // rcx
		  Object *v5; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  VolumetricRenderer_VolumetricBounds *v7; // r8
		  Int32__Array **v8; // r9
		  LowLevelList_1_System_Object_ *v9; // rax
		  List_1_UnityEngine_Vector3_ *v10; // rdi
		  __int64 v11; // r9
		  __int64 v12; // r9
		  __int64 v13; // r9
		  LowLevelList_1_System_Object_ *v14; // rax
		  List_1_UnityEngine_Vector2_ *v15; // rsi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v16; // rax
		  List_1_System_Int32_ *v17; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v20; // [rsp+20h] [rbp-48h] BYREF
		  int v21; // [rsp+28h] [rbp-40h]
		  int32_t v22; // [rsp+30h] [rbp-38h]
		  int32_t v23; // [rsp+38h] [rbp-30h]
		  float v24; // [rsp+40h] [rbp-28h]
		  int32_t v25; // [rsp+48h] [rbp-20h]
		  bool v26; // [rsp+50h] [rbp-18h]
		  bool v27; // [rsp+58h] [rbp-10h]
		  MethodInfo *v28; // [rsp+60h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5083, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    blitMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(blitMesh, 0LL) )
		    {
		LABEL_11:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh;
		    }
		    v2 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		    v5 = (Object *)v2;
		    if ( v2 )
		    {
		      UnityEngine::Mesh::Mesh(v2, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields;
		      static_fields->fields._._.m_target = v5;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh,
		        static_fields,
		        v7,
		        v8,
		        v20,
		        v21,
		        v22,
		        v23,
		        v24,
		        v25,
		        v26,
		        v27,
		        v28);
		      v9 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		      v10 = (List_1_UnityEngine_Vector3_ *)v9;
		      if ( v9 )
		      {
		        System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		          v9,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v11);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xC0400000).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v12);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x3F800000u).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v13);
		        v14 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
		        v15 = (List_1_UnityEngine_Vector2_ *)v14;
		        if ( v14 )
		        {
		          System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		            v14,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          v16 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		          v17 = (List_1_System_Int32_ *)v16;
		          if ( v16 )
		          {
		            System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		              v16,
		              MethodInfo::System::Collections::Generic::List<int>::List);
		            sub_183081250(v17, 0LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            sub_183081250(v17, 1LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            sub_183081250(v17, 2LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh;
		            if ( v4 )
		            {
		              UnityEngine::Mesh::SetVertices(v4, v10, 0LL);
		              v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh;
		              if ( v4 )
		              {
		                UnityEngine::Mesh::SetUVs(v4, 0, v15, 0LL);
		                v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMesh;
		                if ( v4 )
		                {
		                  UnityEngine::Mesh::SetTriangles(v4, v17, 0, 0LL);
		                  goto LABEL_11;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5083, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
		public static Mesh BlitMeshBackface { get; } // 0x0000000189C618FC-0x0000000189C61C34 
		// Mesh get_BlitMeshBackface()
		Mesh *HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(MethodInfo *method)
		{
		  Object_1 *blitMeshBackface; // rbx
		  Mesh *v2; // rax
		  __int64 v3; // rdx
		  Mesh *v4; // rcx
		  Mesh *v5; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  VolumetricRenderer_VolumetricBounds *v7; // r8
		  Int32__Array **v8; // r9
		  LowLevelList_1_System_Object_ *v9; // rax
		  List_1_UnityEngine_Vector3_ *v10; // rdi
		  __int64 v11; // r9
		  __int64 v12; // r9
		  __int64 v13; // r9
		  LowLevelList_1_System_Object_ *v14; // rax
		  List_1_UnityEngine_Vector2_ *v15; // rsi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v16; // rax
		  List_1_System_Int32_ *v17; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v20; // [rsp+20h] [rbp-48h] BYREF
		  int v21; // [rsp+28h] [rbp-40h]
		  int32_t v22; // [rsp+30h] [rbp-38h]
		  int32_t v23; // [rsp+38h] [rbp-30h]
		  float v24; // [rsp+40h] [rbp-28h]
		  int32_t v25; // [rsp+48h] [rbp-20h]
		  bool v26; // [rsp+50h] [rbp-18h]
		  bool v27; // [rsp+58h] [rbp-10h]
		  MethodInfo *v28; // [rsp+60h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5084, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    blitMeshBackface = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(blitMeshBackface, 0LL) )
		    {
		LABEL_11:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface;
		    }
		    v2 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		    v5 = v2;
		    if ( v2 )
		    {
		      UnityEngine::Mesh::Mesh(v2, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields;
		      static_fields->fields._._.method = v5;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface,
		        static_fields,
		        v7,
		        v8,
		        v20,
		        v21,
		        v22,
		        v23,
		        v24,
		        v25,
		        v26,
		        v27,
		        v28);
		      v9 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		      v10 = (List_1_UnityEngine_Vector3_ *)v9;
		      if ( v9 )
		      {
		        System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		          v9,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v11);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xC0400000).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v12);
		        v20 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x3F800000u).m128_u64[0];
		        v21 = 1056964608;
		        sub_18036459C(v10, &v20, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v13);
		        v14 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
		        v15 = (List_1_UnityEngine_Vector2_ *)v14;
		        if ( v14 )
		        {
		          System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		            v14,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          sub_183252070(
		            v15,
		            _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0],
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
		          v16 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		          v17 = (List_1_System_Int32_ *)v16;
		          if ( v16 )
		          {
		            System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		              v16,
		              MethodInfo::System::Collections::Generic::List<int>::List);
		            sub_183081250(v17, 0LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            sub_183081250(v17, 2LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            sub_183081250(v17, 1LL, MethodInfo::System::Collections::Generic::List<int>::Add);
		            v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface;
		            if ( v4 )
		            {
		              UnityEngine::Mesh::SetVertices(v4, v10, 0LL);
		              v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface;
		              if ( v4 )
		              {
		                UnityEngine::Mesh::SetUVs(v4, 0, v15, 0LL);
		                v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_blitMeshBackface;
		                if ( v4 )
		                {
		                  UnityEngine::Mesh::SetTriangles(v4, v17, 0, 0LL);
		                  goto LABEL_11;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5084, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
	
		// Constructors
		static VolumetricSDFUtils() {} // 0x000000018496DFD0-0x000000018496E260
	
		// Methods
		public static Vector3 GetTextureResolution(Texture texture) => default; // 0x0000000183C52C40-0x0000000183C52D20
		// Vector3 GetTextureResolution(Texture)
		Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution(
		        Vector3 *__return_ptr retstr,
		        Texture *texture,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  float v7; // xmm6_4
		  __m128 v8; // xmm7
		  __m128 v9; // xmm8
		  Texture *v10; // rsi
		  RenderTexture *v11; // rdi
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  int32_t depth; // eax
		  RuntimeTypeHandle v15; // rbx
		  __int64 v16; // rax
		  Object *TypeFromHandle; // rdi
		  RuntimeTypeHandle v18; // rax
		  Object *v19; // rbx
		  String *v20; // rax
		  String *v21; // rdi
		  __int64 v22; // rax
		  SystemException *v23; // rax
		  SystemException *v24; // rbx
		  __int64 v25; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v27; // rax
		  __int64 v28; // xmm0_8
		  Vector3 v29; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5046, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5046, 0LL);
		    if ( Patch )
		    {
		      v27 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(&v29, Patch, (Object *)texture, 0LL);
		      v28 = *(_QWORD *)&v27->x;
		      *(float *)&v27 = v27->z;
		      *(_QWORD *)&retstr->x = v28;
		      LODWORD(retstr->z) = (_DWORD)v27;
		      return retstr;
		    }
		    goto LABEL_35;
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( texture )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		    if ( texture->fields._.m_CachedPtr )
		    {
		      v7 = 1.0;
		      v8 = (__m128)0x3F800000u;
		      v9 = (__m128)0x3F800000u;
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v5);
		      if ( !UnityEngine::Object::op_Inequality((Object_1 *)texture, 0LL, 0LL)
		        || (unsigned int)sub_180002F70(9LL, texture) != 3 )
		      {
		        goto LABEL_32;
		      }
		      v10 = 0LL;
		      if ( (struct Texture3D__Class *)texture->klass == TypeInfo::UnityEngine::Texture3D )
		        v10 = texture;
		      v11 = (RenderTexture *)sub_180005050(texture, TypeInfo::UnityEngine::RenderTexture);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality((Object_1 *)v10, 0LL, 0LL) )
		      {
		        if ( v10 )
		        {
		          v8 = (__m128)0x3F800000u;
		          v8.m128_f32[0] = fmaxf(1.0, (float)(int)sub_180002F70(5LL, v10));
		          v9 = (__m128)0x3F800000u;
		          v9.m128_f32[0] = fmaxf(1.0, (float)(int)sub_180002F70(7LL, v10));
		          depth = UnityEngine::Texture3D::get_depth((Texture3D *)v10, 0LL);
		          goto LABEL_31;
		        }
		      }
		      else
		      {
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Equality((Object_1 *)v11, 0LL, 0LL) )
		        {
		          v15.value = (void *)sub_180035ED0(&TypeRef::UnityEngine::Texture3D);
		          v16 = sub_180035ED0(&TypeInfo::System::Type);
		          if ( !*(_DWORD *)(v16 + 224) )
		            il2cpp_runtime_class_init_1(v16);
		          TypeFromHandle = (Object *)System::Type::GetTypeFromHandle(v15, 0LL);
		          v18.value = (void *)sub_180035ED0(&TypeRef::UnityEngine::RenderTexture);
		          v19 = (Object *)System::Type::GetTypeFromHandle(v18, 0LL);
		          v20 = (String *)sub_180035ED0(&off_18E283598);
		          v21 = System::String::Format(v20, TypeFromHandle, v19, 0LL);
		          v22 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		          v23 = (SystemException *)sub_1800368D0(v22);
		          v24 = v23;
		          if ( v23 )
		          {
		            System::SystemException::SystemException(v23, v21, 0LL);
		            v24->fields._._HResult = -2147024809;
		            v25 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution);
		            sub_18007E190(v24, v25);
		          }
		        }
		        else if ( v11 )
		        {
		          v8 = (__m128)0x3F800000u;
		          v8.m128_f32[0] = fmaxf(1.0, (float)(int)sub_180002F70(5LL, v11));
		          v9 = (__m128)0x3F800000u;
		          v9.m128_f32[0] = fmaxf(1.0, (float)(int)sub_180002F70(7LL, v11));
		          depth = UnityEngine::RenderTexture::get_volumeDepth(v11, 0LL);
		LABEL_31:
		          v7 = fmaxf(1.0, (float)depth);
		LABEL_32:
		          *(_QWORD *)&retstr->x = _mm_unpacklo_ps(v8, v9).m128_u64[0];
		          retstr->z = v7;
		          return retstr;
		        }
		      }
		LABEL_35:
		      sub_1800D8260(v13, v12);
		    }
		  }
		  *(_QWORD *)&retstr->x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  retstr->z = 1.0;
		  return retstr;
		}
		
		public static Vector3 VoxelSize(Vector3 textureResolution, out float inverseResolution) {
			inverseResolution = default;
			return default;
		} // 0x0000000183C52D20-0x0000000183C52DB0
		// Vector3 VoxelSize(Vector3, Single ByRef)
		Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::VoxelSize(
		        Vector3 *__return_ptr retstr,
		        Vector3 *textureResolution,
		        float *inverseResolution,
		        MethodInfo *method)
		{
		  float v7; // xmm4_4
		  float v8; // xmm0_4
		  float v9; // xmm1_4
		  float v10; // xmm4_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v13; // rcx
		  float z; // eax
		  Vector3 *v15; // rax
		  __int64 v16; // xmm0_8
		  Vector3 v17; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v18[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5047, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5047, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, 0LL);
		    z = textureResolution->z;
		    *(_QWORD *)&v17.x = *(_QWORD *)&textureResolution->x;
		    v17.z = z;
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1472(v18, Patch, &v17, inverseResolution, 0LL);
		    v16 = *(_QWORD *)&v15->x;
		    *(float *)&v15 = v15->z;
		    *(_QWORD *)&retstr->x = v16;
		    LODWORD(retstr->z) = (_DWORD)v15;
		  }
		  else
		  {
		    v7 = 1.0 / fmaxf(textureResolution->x, fmaxf(textureResolution->y, textureResolution->z));
		    *inverseResolution = v7;
		    v8 = v7 * textureResolution->x;
		    v9 = v7 * textureResolution->y;
		    v10 = v7 * textureResolution->z;
		    retstr->x = v8;
		    retstr->y = v9;
		    retstr->z = v10;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static void CustomBlit(CommandBuffer cmd, Material mat, int pass, bool backface = false /* Metadata: 0x023040E9 */) {} // 0x0000000189C5ED1C-0x0000000189C5EE14
		// Void CustomBlit(CommandBuffer, Material, Int32, Boolean)
		void HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		        CommandBuffer *cmd,
		        Material *mat,
		        int32_t pass,
		        bool backface,
		        MethodInfo *method)
		{
		  Mesh *BlitMeshBackface; // rax
		  Mesh *v10; // rdx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 v16; // [rsp+40h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5194, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    if ( backface )
		      BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(0LL);
		    else
		      BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(0LL);
		    v10 = BlitMeshBackface;
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    if ( cmd )
		    {
		      v12 = *(_OWORD *)&static_fields->identityMatrix.m01;
		      *(_OWORD *)&v16.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		      v13 = *(_OWORD *)&static_fields->identityMatrix.m02;
		      *(_OWORD *)&v16.m01 = v12;
		      v14 = *(_OWORD *)&static_fields->identityMatrix.m03;
		      *(_OWORD *)&v16.m02 = v13;
		      *(_OWORD *)&v16.m03 = v14;
		      UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, BlitMeshBackface, &v16, mat, 0, pass, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(static_fields, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5194, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_87(
		    (ILFixDynamicMethodWrapper_8 *)Patch,
		    (Object *)cmd,
		    (Object *)mat,
		    pass,
		    backface,
		    0LL);
		}
		
		[IDTag(0)]
		public static void CustomBlit(CommandBuffer cmd, Material mat, MaterialPropertyBlock propertyBlock, int pass, bool backface = false /* Metadata: 0x023040EA */) {} // 0x0000000189C5EE14-0x0000000189C5EF24
		// Void CustomBlit(CommandBuffer, Material, MaterialPropertyBlock, Int32, Boolean)
		void HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		        CommandBuffer *cmd,
		        Material *mat,
		        MaterialPropertyBlock *propertyBlock,
		        int32_t pass,
		        bool backface,
		        MethodInfo *method)
		{
		  Mesh *BlitMeshBackface; // rax
		  Mesh *v11; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Matrix4x4 v16; // [rsp+40h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5082, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    if ( backface )
		      BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(0LL);
		    else
		      BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(0LL);
		    v11 = BlitMeshBackface;
		    static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    if ( cmd )
		    {
		      v13 = *(_OWORD *)&static_fields[2].klass;
		      *(_OWORD *)&v16.m00 = *(_OWORD *)&static_fields[1].fields.methodId;
		      v14 = *(_OWORD *)&static_fields[2].fields.virtualMachine;
		      *(_OWORD *)&v16.m01 = v13;
		      v15 = *(_OWORD *)&static_fields[2].fields.anonObj;
		      *(_OWORD *)&v16.m02 = v14;
		      *(_OWORD *)&v16.m03 = v15;
		      UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, BlitMeshBackface, &v16, mat, 0, pass, propertyBlock, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(static_fields, v11);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(5082, 0LL);
		  if ( !static_fields )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1481(
		    static_fields,
		    (Object *)cmd,
		    (Object *)mat,
		    (Object *)propertyBlock,
		    pass,
		    backface,
		    0LL);
		}
		
		public static void ClearRenderTarget(RenderTexture rt) {} // 0x0000000189C5E310-0x0000000189C5E3C8
		// Void ClearRenderTarget(RenderTexture)
		void HG::Rendering::Runtime::VolumetricSDFUtils::ClearRenderTarget(RenderTexture *rt, MethodInfo *method)
		{
		  RenderTexture *Active; // rbx
		  MethodInfo *v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Quaternion v8; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5094, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5094, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)rt, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)rt, 0LL) )
		    {
		      Active = UnityEngine::RenderTexture::GetActive(0LL);
		      UnityEngine::RenderTexture::SetActive(rt, 0LL);
		      v8 = *UnityEngine::Quaternion::get_identity(&v8, v4);
		      UnityEngine::GL::Clear(0, 1, (Color *)&v8, 1.0, 0LL);
		      UnityEngine::RenderTexture::SetActive(Active, 0LL);
		    }
		  }
		}
		
		public static void SetRenderTargets(CommandBuffer cmd, RenderTexture colorRT, RenderTexture depthRT, RenderBufferLoadAction loadAction = RenderBufferLoadAction.DontCare /* Metadata: 0x023040EB */, RenderBufferStoreAction storeAction = RenderBufferStoreAction.Store /* Metadata: 0x023040EC */) {} // 0x0000000189C5FC8C-0x0000000189C5FF38
		// Void SetRenderTargets(CommandBuffer, RenderTexture, RenderTexture, RenderBufferLoadAction, RenderBufferStoreAction)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		        CommandBuffer *cmd,
		        RenderTexture *colorRT,
		        RenderTexture *depthRT,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        MethodInfo *method)
		{
		  RenderTargetIdentifier__Array *RTs; // r14
		  RenderTargetIdentifier *v11; // rax
		  _DWORD *Loads; // rdx
		  ILFixDynamicMethodWrapper_4 *Patch; // rcx
		  __int128 v14; // xmm1
		  RenderTargetIdentifier__Array *v15; // rsi
		  RenderTargetIdentifier *v16; // rax
		  __int128 v17; // xmm1
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v18; // rdx
		  VolumetricRenderer_VolumetricBounds *v19; // r8
		  Int32__Array **v20; // r9
		  RenderTargetIdentifier *v21; // rax
		  __int128 v22; // xmm2
		  Action *v23; // xmm0_8
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  bool P4; // [rsp+30h] [rbp-D8h]
		  int32_t v26; // [rsp+38h] [rbp-D0h]
		  int32_t v27; // [rsp+40h] [rbp-C8h]
		  __int128 v28; // [rsp+48h] [rbp-C0h] BYREF
		  __int128 v29; // [rsp+58h] [rbp-B0h]
		  MethodInfo *v30; // [rsp+68h] [rbp-A0h]
		  ValueAnimation_1_StyleValues_ v31; // [rsp+70h] [rbp-98h] BYREF
		  __int128 v32; // [rsp+E8h] [rbp-20h]
		  __int128 v33; // [rsp+F8h] [rbp-10h]
		  __int128 v34; // [rsp+108h] [rbp+0h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5096, 0LL) )
		  {
		    if ( !cmd )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    RTs = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		    v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		            (Texture *)colorRT,
		            0LL);
		    if ( RTs )
		    {
		      v14 = *(_OWORD *)&v11->m_BufferPointer;
		      v28 = *(_OWORD *)&v11->m_Type;
		      v30 = *(MethodInfo **)&v11->m_DepthSlice;
		      v29 = v14;
		      sub_18048737C(RTs, 0LL, &v28);
		      v15 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		      v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		              (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		              (Texture *)depthRT,
		              0LL);
		      if ( v15 )
		      {
		        v17 = *(_OWORD *)&v16->m_BufferPointer;
		        v28 = *(_OWORD *)&v16->m_Type;
		        v30 = *(MethodInfo **)&v16->m_DepthSlice;
		        v29 = v17;
		        sub_18048737C(v15, 1LL, &v28);
		        Patch = (ILFixDynamicMethodWrapper_4 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		        Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Loads;
		        if ( Loads )
		        {
		          if ( Loads[6] <= 1u )
		            goto LABEL_12;
		          Loads[9] = loadAction;
		          if ( !Loads[6] )
		            goto LABEL_12;
		          Loads[8] = loadAction;
		          Patch = (ILFixDynamicMethodWrapper_4 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		          Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Stores;
		          if ( Loads )
		          {
		            if ( Loads[6] > 1u )
		            {
		              Loads[9] = storeAction;
		              if ( Loads[6] )
		              {
		                Loads[8] = storeAction;
		                sub_18033B9D0(&v31.monitor, 0LL, 80LL);
		                v31.monitor = (MonitorData *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		                sub_18002D1B0(
		                  (VolumetricRenderer_VolumetricRenderItem *)&v31.monitor,
		                  v18,
		                  v19,
		                  v20,
		                  P3,
		                  P4,
		                  v26,
		                  v27,
		                  *(float *)&v28,
		                  SDWORD2(v28),
		                  v29,
		                  SBYTE8(v29),
		                  v30);
		                v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                        (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		                        (Texture *)depthRT,
		                        0LL);
		                v22 = *(_OWORD *)&v21->m_BufferPointer;
		                v23 = *(Action **)&v21->m_DepthSlice;
		                *(_OWORD *)&v31.fields.m_StartTimeMs = *(_OWORD *)&v21->m_Type;
		                *(_OWORD *)&v31.fields._easingCurve_k__BackingField = v22;
		                v31.fields._onAnimationCompleted_k__BackingField = v23;
		                UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
		                  (ValueAnimation_1_StyleValues_ *)&v31.monitor,
		                  (Action *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Loads,
		                  0LL);
		                Unity::VisualScripting::UnitConnection<System::Object,System::Object>::set_destinationUnit(
		                  (UnitConnection_2_System_Object_System_Object_ *)&v31.monitor,
		                  (IUnit *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Stores,
		                  0LL);
		                *(_OWORD *)&v31.fields._interpolator_k__BackingField = *(_OWORD *)&v31.monitor;
		                v32 = *(_OWORD *)&v31.fields._isRunning_k__BackingField;
		                v31.fields._valueUpdated_k__BackingField = (Action_2_UnityEngine_UIElements_VisualElement_UnityEngine_UIElements_Experimental_StyleValues_ *)0x300000002LL;
		                *(_OWORD *)&v31.fields.fromValueSet = *(_OWORD *)&v31.fields.m_DurationMs;
		                v34 = *(_OWORD *)&v31.fields._valueUpdated_k__BackingField;
		                v33 = *(_OWORD *)&v31.fields._autoRecycle_k__BackingField;
		                UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		                  cmd,
		                  (RenderTargetBinding *)&v31.fields._interpolator_k__BackingField,
		                  0LL);
		                return;
		              }
		            }
		LABEL_12:
		            sub_1800D2AB0(Patch, Loads);
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(Patch, Loads);
		  }
		  Patch = (ILFixDynamicMethodWrapper_4 *)IFix::WrappersManagerImpl::GetPatch(5096, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_527(
		    Patch,
		    (Object *)cmd,
		    (Object *)colorRT,
		    (Object *)depthRT,
		    loadAction,
		    storeAction,
		    0LL);
		}
		
		public static void SetRenderTarget(CommandBuffer cmd, RenderTexture colorRT) {} // 0x0000000189C5F908-0x0000000189C5F9B4
		// Void SetRenderTarget(CommandBuffer, RenderTexture)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(
		        CommandBuffer *cmd,
		        RenderTexture *colorRT,
		        MethodInfo *method)
		{
		  RenderTargetIdentifier *v5; // rax
		  __int128 v6; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  RenderTargetIdentifier v10; // [rsp+30h] [rbp-68h] BYREF
		  RenderTargetIdentifier v11; // [rsp+60h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5081, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5081, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)cmd,
		      (Object *)colorRT,
		      0LL);
		  }
		  else if ( cmd )
		  {
		    v5 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v11, (Texture *)colorRT, 0LL);
		    v6 = *(_OWORD *)&v5->m_BufferPointer;
		    *(_OWORD *)&v10.m_Type = *(_OWORD *)&v5->m_Type;
		    *(_QWORD *)&v10.m_DepthSlice = *(_QWORD *)&v5->m_DepthSlice;
		    *(_OWORD *)&v10.m_BufferPointer = v6;
		    UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		      cmd,
		      &v10,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      0LL);
		  }
		}
		
		public static void SetRenderTargetsWithDepth(CommandBuffer cmd, RenderTexture colorRT, RenderTexture depthRT, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore) {} // 0x0000000189C5F9B4-0x0000000189C5FC8C
		// Void SetRenderTargetsWithDepth(CommandBuffer, RenderTexture, RenderTexture, RenderTargetIdentifier, RenderBufferLoadAction, RenderBufferStoreAction)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
		        CommandBuffer *cmd,
		        RenderTexture *colorRT,
		        RenderTexture *depthRT,
		        RenderTargetIdentifier *depth,
		        RenderBufferLoadAction__Enum depthLoad,
		        RenderBufferStoreAction__Enum depthStore,
		        MethodInfo *method)
		{
		  RenderTargetIdentifier__Array *RTs; // rbx
		  RenderTargetIdentifier *v12; // rax
		  _DWORD *Loads; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v15; // xmm1
		  RenderTargetIdentifier__Array *v16; // rbx
		  RenderTargetIdentifier *v17; // rax
		  __int128 v18; // xmm1
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
		  VolumetricRenderer_VolumetricBounds *v20; // r8
		  Int32__Array **v21; // r9
		  RenderTargetIdentifier *v22; // rax
		  __int128 v23; // xmm2
		  Action *v24; // xmm0_8
		  __int128 v25; // xmm1
		  MethodInfo *v26; // [rsp+28h] [rbp-E0h]
		  bool v27; // [rsp+30h] [rbp-D8h]
		  int32_t v28; // [rsp+38h] [rbp-D0h]
		  int32_t v29; // [rsp+40h] [rbp-C8h]
		  RenderTargetIdentifier v30; // [rsp+48h] [rbp-C0h] BYREF
		  ValueAnimation_1_StyleValues_ v31; // [rsp+70h] [rbp-98h] BYREF
		  __int128 v32; // [rsp+E8h] [rbp-20h]
		  __int128 v33; // [rsp+F8h] [rbp-10h]
		  __int128 v34; // [rsp+108h] [rbp+0h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5217, 0LL) )
		  {
		    if ( !cmd )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    RTs = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		    v12 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		            (Texture *)colorRT,
		            0LL);
		    if ( RTs )
		    {
		      v15 = *(_OWORD *)&v12->m_BufferPointer;
		      *(_OWORD *)&v30.m_Type = *(_OWORD *)&v12->m_Type;
		      *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&v12->m_DepthSlice;
		      *(_OWORD *)&v30.m_BufferPointer = v15;
		      sub_18048737C(RTs, 0LL, &v30);
		      v16 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		      v17 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		              (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		              (Texture *)depthRT,
		              0LL);
		      if ( v16 )
		      {
		        v18 = *(_OWORD *)&v17->m_BufferPointer;
		        *(_OWORD *)&v30.m_Type = *(_OWORD *)&v17->m_Type;
		        *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&v17->m_DepthSlice;
		        *(_OWORD *)&v30.m_BufferPointer = v18;
		        sub_18048737C(v16, 1LL, &v30);
		        Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		        Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Loads;
		        if ( Loads )
		        {
		          if ( Loads[6] <= 1u )
		            goto LABEL_12;
		          Loads[9] = 2;
		          if ( !Loads[6] )
		            goto LABEL_12;
		          Loads[8] = 2;
		          Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		          Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Stores;
		          if ( Loads )
		          {
		            if ( Loads[6] > 1u )
		            {
		              Loads[9] = 0;
		              if ( Loads[6] )
		              {
		                Loads[8] = 0;
		                sub_18033B9D0(&v31.monitor, 0LL, 80LL);
		                v31.monitor = (MonitorData *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_RTs;
		                sub_18002D1B0(
		                  (VolumetricRenderer_VolumetricRenderItem *)&v31.monitor,
		                  v19,
		                  v20,
		                  v21,
		                  v26,
		                  v27,
		                  v28,
		                  v29,
		                  *(float *)&v30.m_Type,
		                  v30.m_InstanceID,
		                  (bool)v30.m_BufferPointer,
		                  v30.m_MipLevel,
		                  *(MethodInfo **)&v30.m_DepthSlice);
		                v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                        (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
		                        (Texture *)depthRT,
		                        0LL);
		                v23 = *(_OWORD *)&v22->m_BufferPointer;
		                v24 = *(Action **)&v22->m_DepthSlice;
		                *(_OWORD *)&v31.fields.m_StartTimeMs = *(_OWORD *)&v22->m_Type;
		                *(_OWORD *)&v31.fields._easingCurve_k__BackingField = v23;
		                v31.fields._onAnimationCompleted_k__BackingField = v24;
		                UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
		                  (ValueAnimation_1_StyleValues_ *)&v31.monitor,
		                  (Action *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Loads,
		                  0LL);
		                Unity::VisualScripting::UnitConnection<System::Object,System::Object>::set_destinationUnit(
		                  (UnitConnection_2_System_Object_System_Object_ *)&v31.monitor,
		                  (IUnit *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->_Stores,
		                  0LL);
		                *(_OWORD *)&v31.fields._interpolator_k__BackingField = *(_OWORD *)&v31.monitor;
		                LODWORD(v31.fields._valueUpdated_k__BackingField) = depthLoad;
		                v32 = *(_OWORD *)&v31.fields._isRunning_k__BackingField;
		                HIDWORD(v31.fields._valueUpdated_k__BackingField) = depthStore;
		                *(_OWORD *)&v31.fields.fromValueSet = *(_OWORD *)&v31.fields.m_DurationMs;
		                v34 = *(_OWORD *)&v31.fields._valueUpdated_k__BackingField;
		                v33 = *(_OWORD *)&v31.fields._autoRecycle_k__BackingField;
		                UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		                  cmd,
		                  (RenderTargetBinding *)&v31.fields._interpolator_k__BackingField,
		                  0LL);
		                return;
		              }
		            }
		LABEL_12:
		            sub_1800D2AB0(Patch, Loads);
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(Patch, Loads);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5217, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  v25 = *(_OWORD *)&depth->m_BufferPointer;
		  *(_OWORD *)&v30.m_Type = *(_OWORD *)&depth->m_Type;
		  *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&depth->m_DepthSlice;
		  *(_OWORD *)&v30.m_BufferPointer = v25;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1511(
		    Patch,
		    (Object *)cmd,
		    (Object *)colorRT,
		    (Object *)depthRT,
		    &v30,
		    depthLoad,
		    depthStore,
		    0LL);
		}
		
		public static void SetRenderTargetWithDepth(CommandBuffer cmd, RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore) {} // 0x0000000189C5F7D4-0x0000000189C5F908
		// Void SetRenderTargetWithDepth(CommandBuffer, RenderTargetIdentifier, RenderTargetIdentifier, RenderBufferLoadAction, RenderBufferStoreAction)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetWithDepth(
		        CommandBuffer *cmd,
		        RenderTargetIdentifier *color,
		        RenderTargetIdentifier *depth,
		        RenderBufferLoadAction__Enum depthLoad,
		        RenderBufferStoreAction__Enum depthStore,
		        MethodInfo *method)
		{
		  __int128 v10; // xmm1
		  __int64 v11; // xmm0_8
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v16; // xmm1
		  __int64 v17; // xmm0_8
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  RenderTargetIdentifier v20; // [rsp+48h] [rbp-19h] BYREF
		  RenderTargetIdentifier v21; // [rsp+78h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5204, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5204, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    v16 = *(_OWORD *)&depth->m_BufferPointer;
		    *(_OWORD *)&v21.m_Type = *(_OWORD *)&depth->m_Type;
		    v17 = *(_QWORD *)&depth->m_DepthSlice;
		    *(_OWORD *)&v21.m_BufferPointer = v16;
		    v18 = *(_OWORD *)&color->m_Type;
		    *(_QWORD *)&v21.m_DepthSlice = v17;
		    v19 = *(_OWORD *)&color->m_BufferPointer;
		    *(_OWORD *)&v20.m_Type = v18;
		    *(_QWORD *)&v18 = *(_QWORD *)&color->m_DepthSlice;
		    *(_OWORD *)&v20.m_BufferPointer = v19;
		    *(_QWORD *)&v20.m_DepthSlice = v18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1506(Patch, (Object *)cmd, &v20, &v21, depthLoad, depthStore, 0LL);
		  }
		  else if ( cmd )
		  {
		    v10 = *(_OWORD *)&depth->m_BufferPointer;
		    *(_OWORD *)&v20.m_Type = *(_OWORD *)&depth->m_Type;
		    v11 = *(_QWORD *)&depth->m_DepthSlice;
		    *(_OWORD *)&v20.m_BufferPointer = v10;
		    v12 = *(_OWORD *)&color->m_Type;
		    *(_QWORD *)&v20.m_DepthSlice = v11;
		    v13 = *(_OWORD *)&color->m_BufferPointer;
		    *(_OWORD *)&v21.m_Type = v12;
		    *(_QWORD *)&v12 = *(_QWORD *)&color->m_DepthSlice;
		    *(_OWORD *)&v21.m_BufferPointer = v13;
		    *(_QWORD *)&v21.m_DepthSlice = v12;
		    UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		      cmd,
		      &v21,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      &v20,
		      depthLoad,
		      depthStore,
		      0LL);
		  }
		}
		
		private static void CollectCombineMesh(Transform trans, Matrix4x4 parent, MeshCombine combine, Func<GameObject, bool> filter = null) {} // 0x0000000189C5E3C8-0x0000000189C5E6EC
		// Void CollectCombineMesh(Transform, Matrix4x4, MeshCombine, Func`2[UnityEngine.GameObject,Boolean])
		void HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh(
		        Transform *trans,
		        Matrix4x4 *parent,
		        MeshCombine *combine,
		        Func_2_UnityEngine_GameObject_Boolean_ *filter,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t v11; // esi
		  Component *Child; // rax
		  Component *v13; // rdi
		  GameObject *gameObject; // rax
		  GameObject *v15; // rax
		  Vector3 *localPosition; // rax
		  __int64 v17; // xmm7_8
		  float z; // ebx
		  __m128i v19; // xmm6
		  Vector3 *localScale; // rax
		  __int64 v21; // xmm0_8
		  Matrix4x4 *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Matrix4x4 *v30; // rax
		  __int128 v31; // xmm6
		  __int128 v32; // xmm7
		  __int128 v33; // xmm8
		  __int128 v34; // xmm9
		  Object_1 *sharedMesh; // rbx
		  Mesh *v36; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v38; // xmm1
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  Object *exists; // [rsp+38h] [rbp-D0h]
		  Matrix4x4 v42; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v43; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v44; // [rsp+98h] [rbp-70h] BYREF
		  __m128i v45; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v46; // [rsp+B8h] [rbp-50h] BYREF
		  Vector3 v47; // [rsp+C8h] [rbp-40h] BYREF
		  Matrix4x4 v48; // [rsp+D8h] [rbp-30h] BYREF
		  Quaternion v49; // [rsp+118h] [rbp+10h] BYREF
		  Matrix4x4 v50[2]; // [rsp+128h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5248, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5248, 0LL);
		    if ( Patch )
		    {
		      v38 = *(_OWORD *)&parent->m01;
		      *(_OWORD *)&v42.m00 = *(_OWORD *)&parent->m00;
		      v39 = *(_OWORD *)&parent->m02;
		      *(_OWORD *)&v42.m01 = v38;
		      v40 = *(_OWORD *)&parent->m03;
		      *(_OWORD *)&v42.m02 = v39;
		      *(_OWORD *)&v42.m03 = v40;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1517(
		        Patch,
		        (Object *)trans,
		        &v42,
		        (Object *)combine,
		        (Object *)filter,
		        0LL);
		      return;
		    }
		LABEL_17:
		    sub_1800D8260(v10, v9);
		  }
		  v11 = 0;
		  if ( !trans )
		    goto LABEL_17;
		  while ( v11 < UnityEngine::Transform::get_childCount(trans, 0LL) )
		  {
		    Child = (Component *)UnityEngine::Transform::GetChild(trans, v11, 0LL);
		    v13 = Child;
		    if ( !Child )
		      goto LABEL_17;
		    gameObject = UnityEngine::Component::get_gameObject(Child, 0LL);
		    if ( !gameObject )
		      goto LABEL_17;
		    if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
		    {
		      if ( !filter
		        || (v15 = UnityEngine::Component::get_gameObject(v13, 0LL), (unsigned __int8)sub_182F2EFB0(filter, v15, 0LL)) )
		      {
		        exists = UnityEngine::Component::GetComponent<System::Object>(
		                   v13,
		                   MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
		        localPosition = UnityEngine::Transform::get_localPosition(&v46, (Transform *)v13, 0LL);
		        v17 = *(_QWORD *)&localPosition->x;
		        z = localPosition->z;
		        v19 = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_localRotation(&v49, (Transform *)v13, 0LL));
		        localScale = UnityEngine::Transform::get_localScale(&v47, (Transform *)v13, 0LL);
		        v45 = v19;
		        *(_QWORD *)&v44.x = v17;
		        v21 = *(_QWORD *)&localScale->x;
		        *(float *)&localScale = localScale->z;
		        *(_QWORD *)&v43.x = v21;
		        LODWORD(v43.z) = (_DWORD)localScale;
		        v44.z = z;
		        v22 = UnityEngine::Matrix4x4::TRS(&v42, &v44, (Quaternion *)&v45, &v43, 0LL);
		        v23 = *(_OWORD *)&v22->m01;
		        *(_OWORD *)&v48.m00 = *(_OWORD *)&v22->m00;
		        v24 = *(_OWORD *)&v22->m02;
		        *(_OWORD *)&v48.m01 = v23;
		        v25 = *(_OWORD *)&v22->m03;
		        *(_OWORD *)&v48.m02 = v24;
		        v26 = *(_OWORD *)&parent->m00;
		        *(_OWORD *)&v48.m03 = v25;
		        v27 = *(_OWORD *)&parent->m01;
		        *(_OWORD *)&v42.m00 = v26;
		        v28 = *(_OWORD *)&parent->m02;
		        *(_OWORD *)&v42.m01 = v27;
		        v29 = *(_OWORD *)&parent->m03;
		        *(_OWORD *)&v42.m02 = v28;
		        *(_OWORD *)&v42.m03 = v29;
		        v30 = UnityEngine::Matrix4x4::op_Multiply(v50, &v42, &v48, 0LL);
		        v31 = *(_OWORD *)&v30->m00;
		        v32 = *(_OWORD *)&v30->m01;
		        v33 = *(_OWORD *)&v30->m02;
		        v34 = *(_OWORD *)&v30->m03;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Implicit((Object_1 *)exists, 0LL) )
		        {
		          if ( !exists )
		            goto LABEL_17;
		          sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)exists, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(sharedMesh, 0LL) )
		          {
		            v36 = UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)exists, 0LL);
		            if ( !combine )
		              goto LABEL_17;
		            *(_OWORD *)&v42.m00 = v31;
		            *(_OWORD *)&v42.m01 = v32;
		            *(_OWORD *)&v42.m02 = v33;
		            *(_OWORD *)&v42.m03 = v34;
		            HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(combine, v36, &v42, 0LL);
		          }
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        *(_OWORD *)&v42.m00 = v31;
		        *(_OWORD *)&v42.m01 = v32;
		        *(_OWORD *)&v42.m02 = v33;
		        *(_OWORD *)&v42.m03 = v34;
		        HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh((Transform *)v13, &v42, combine, filter, 0LL);
		      }
		    }
		    ++v11;
		  }
		}
		
		private static void UnionChildMesh(Transform trans, MeshCombine combine, Func<GameObject, bool> filter = null) {} // 0x0000000189C6015C-0x0000000189C60364
		// Void UnionChildMesh(Transform, MeshCombine, Func`2[UnityEngine.GameObject,Boolean])
		void HG::Rendering::Runtime::VolumetricSDFUtils::UnionChildMesh(
		        Transform *trans,
		        MeshCombine *combine,
		        Func_2_UnityEngine_GameObject_Boolean_ *filter,
		        MethodInfo *method)
		{
		  Object *v6; // rsi
		  BSP *v7; // rax
		  __int64 v8; // rdx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  BSP *v10; // r15
		  Object__Array *v11; // r14
		  int32_t v12; // ebp
		  MeshFilter *v13; // rdi
		  Object_1 *sharedMesh; // rbx
		  GameObject *gameObject; // rax
		  Mesh *v16; // rsi
		  Transform *transform; // rdi
		  int32_t v18; // ebx
		  BSP *v19; // rax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t objID; // [rsp+30h] [rbp-78h]
		  Matrix4x4 v25; // [rsp+40h] [rbp-68h] BYREF
		
		  v6 = (Object *)filter;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5250, 0LL) )
		  {
		    v7 = (BSP *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    v10 = v7;
		    if ( v7 )
		    {
		      HG::Rendering::Runtime::CSG::BSP::BSP(v7, 0, 0LL);
		      if ( trans )
		      {
		        v11 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
		                (Component *)trans,
		                MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshFilter>);
		        objID = 0;
		        v12 = 0;
		        if ( v11 )
		        {
		          while ( v12 < v11->max_length.size )
		          {
		            if ( (unsigned int)v12 >= v11->max_length.size )
		              sub_1800D2AB0(static_fields, v8);
		            v13 = (MeshFilter *)v11->vector[v12];
		            if ( !v13 )
		              goto LABEL_17;
		            sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)v11->vector[v12], 0LL);
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Implicit(sharedMesh, 0LL) )
		            {
		              if ( !v6
		                || (gameObject = UnityEngine::Component::get_gameObject((Component *)v13, 0LL),
		                    (unsigned __int8)sub_182F2EFB0(v6, gameObject, 0LL)) )
		              {
		                v16 = UnityEngine::MeshFilter::get_sharedMesh(v13, 0LL);
		                transform = UnityEngine::Component::get_transform((Component *)v13, 0LL);
		                v18 = objID++;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		                v19 = HG::Rendering::Runtime::CSG::BSP::fromMesh(v16, transform, trans, v18, 0, 0LL);
		                HG::Rendering::Runtime::CSG::BSP::Union(v10, v19, 0LL);
		                v6 = (Object *)filter;
		              }
		            }
		            ++v12;
		          }
		          static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		          if ( combine )
		          {
		            v20 = *(_OWORD *)&static_fields->identityMatrix.m01;
		            *(_OWORD *)&v25.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		            v21 = *(_OWORD *)&static_fields->identityMatrix.m02;
		            *(_OWORD *)&v25.m01 = v20;
		            v22 = *(_OWORD *)&static_fields->identityMatrix.m03;
		            *(_OWORD *)&v25.m02 = v21;
		            *(_OWORD *)&v25.m03 = v22;
		            HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(combine, v10, &v25, 0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(static_fields, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5250, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)trans,
		    (Object *)combine,
		    v6,
		    0LL);
		}
		
		public static MeshCombine BuildMeshCombine(Transform trans, bool meshBoolean, Func<GameObject, bool> filter = null) => default; // 0x0000000189C5DB20-0x0000000189C5DD40
		// MeshCombine BuildMeshCombine(Transform, Boolean, Func`2[UnityEngine.GameObject,Boolean])
		MeshCombine *HG::Rendering::Runtime::VolumetricSDFUtils::BuildMeshCombine(
		        Transform *trans,
		        bool meshBoolean,
		        Func_2_UnityEngine_GameObject_Boolean_ *filter,
		        MethodInfo *method)
		{
		  MeshCombine *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MeshCombine *v10; // rdi
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v12; // xmm6
		  __int128 v13; // xmm7
		  __int128 v14; // xmm8
		  __int128 v15; // xmm9
		  Object *v16; // rbx
		  Bounds *Bounds; // rax
		  __m128i v18; // xmm3
		  Animator *v19; // rdx
		  int32_t v20; // r8d
		  MethodInfo *v21; // r9
		  Vector3 *Vector; // rax
		  __int64 v23; // xmm1_8
		  MethodInfo *v24; // rdx
		  Quaternion *identity; // rax
		  Quaternion v26; // xmm1
		  Matrix4x4 *v27; // rax
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v33; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v34; // [rsp+48h] [rbp-C0h] BYREF
		  Bounds v35; // [rsp+58h] [rbp-B0h] BYREF
		  Matrix4x4 v36; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v37[2]; // [rsp+B8h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5302, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5302, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1535(
		               Patch,
		               (Object *)trans,
		               meshBoolean,
		               (Object *)filter,
		               0LL);
		LABEL_8:
		    sub_1800D8260(v9, v8);
		  }
		  v7 = (MeshCombine *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine);
		  v10 = v7;
		  if ( !v7 )
		    goto LABEL_8;
		  HG::Rendering::Runtime::SDF::MeshCombine::MeshCombine(v7, 0LL);
		  if ( meshBoolean )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::UnionChildMesh(trans, v10, 0LL, 0LL);
		  }
		  else
		  {
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v12 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v13 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    v14 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v15 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    *(_OWORD *)&v36.m00 = v12;
		    *(_OWORD *)&v36.m01 = v13;
		    *(_OWORD *)&v36.m02 = v14;
		    *(_OWORD *)&v36.m03 = v15;
		    HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh(trans, &v36, v10, filter, 0LL);
		  }
		  HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(v10, 0LL);
		  v16 = UnityEngine::Resources::GetBuiltinResource<System::Object>(
		          (String *)"Sphere.fbx",
		          MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
		  Bounds = HG::Rendering::Runtime::SDF::MeshCombine::GetBounds(&v35, v10, 0LL);
		  v18 = *(__m128i *)&Bounds->m_Center.x;
		  *(_QWORD *)&v35.m_Extents.y = *(_QWORD *)&Bounds->m_Extents.y;
		  Vector = UnityEngine::Animator::GetVector(&v33, v19, v20, v21);
		  v23 = *(_QWORD *)&Vector->x;
		  *(float *)&Vector = Vector->z;
		  *(_QWORD *)&v34.x = v23;
		  LODWORD(v34.z) = (_DWORD)Vector;
		  identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v35, v24);
		  *(_QWORD *)&v33.x = v18.m128i_i64[0];
		  v26 = *identity;
		  LODWORD(v33.z) = _mm_cvtsi128_si32(_mm_srli_si128(v18, 8));
		  *(Quaternion *)&v35.m_Center.x = v26;
		  v27 = UnityEngine::Matrix4x4::TRS(v37, &v33, (Quaternion *)&v35, &v34, 0LL);
		  v28 = *(_OWORD *)&v27->m01;
		  *(_OWORD *)&v36.m00 = *(_OWORD *)&v27->m00;
		  v29 = *(_OWORD *)&v27->m02;
		  *(_OWORD *)&v36.m01 = v28;
		  v30 = *(_OWORD *)&v27->m03;
		  *(_OWORD *)&v36.m02 = v29;
		  *(_OWORD *)&v36.m03 = v30;
		  HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(v10, (Mesh *)v16, &v36, 0LL);
		  return v10;
		}
		
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) {} // 0x0000000189C61410-0x0000000189C618FC
		// Void ValidateRenderTextureDesc(RenderTextureDescriptor)
		void HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc(
		        RenderTextureDescriptor *desc,
		        MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  InvalidEnumArgumentException *v6; // rbx
		  String *v7; // rax
		  __int64 v8; // rax
		  String *v9; // rdi
		  String *v10; // rbx
		  String *v11; // rax
		  String *v12; // rdi
		  __int64 v13; // rax
		  ArgumentException *v14; // rbx
		  String *v15; // rax
		  __int64 v16; // rax
		  String *v17; // rdi
		  String *v18; // rbx
		  String *v19; // rax
		  String *v20; // rdi
		  __int64 v21; // rax
		  ArgumentException *v22; // rbx
		  String *v23; // rax
		  __int64 v24; // rax
		  __int64 v25; // rax
		  ArgumentException *v26; // rdi
		  String *v27; // rbx
		  String *v28; // rax
		  __int64 v29; // rax
		  __int64 v30; // rax
		  ArgumentException *v31; // rdi
		  String *v32; // rbx
		  String *v33; // rax
		  __int64 v34; // rax
		  __int64 v35; // rax
		  ArgumentException *v36; // rdi
		  String *v37; // rbx
		  String *v38; // rax
		  __int64 v39; // rax
		  __int64 v40; // rax
		  ArgumentException *v41; // rdi
		  String *v42; // rbx
		  String *v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  ArgumentException *v46; // rdi
		  String *v47; // rbx
		  String *v48; // rax
		  __int64 v49; // rax
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  Enum v53; // [rsp+20h] [rbp-60h] BYREF
		  int32_t graphicsFormat; // [rsp+30h] [rbp-50h]
		  RenderTextureDescriptor v55; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5075, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5075, 0LL);
		    if ( !Patch )
		      goto LABEL_35;
		    v50 = *(_OWORD *)&desc->_width_k__BackingField;
		    v51 = *(_OWORD *)&desc->_mipCount_k__BackingField;
		    v55._memoryless_k__BackingField = desc->_memoryless_k__BackingField;
		    *(_OWORD *)&v55._width_k__BackingField = v50;
		    v52 = *(_OWORD *)&desc->_dimension_k__BackingField;
		    *(_OWORD *)&v55._mipCount_k__BackingField = v51;
		    *(_OWORD *)&v55._dimension_k__BackingField = v52;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1476(Patch, &v55, 0LL);
		    return;
		  }
		  if ( desc->_graphicsFormat )
		    goto LABEL_39;
		  if ( !desc->_depthStencilFormat_k__BackingField )
		  {
		    v3 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v6 = (InvalidEnumArgumentException *)sub_18002C620(v3);
		    if ( v6 )
		    {
		      v7 = (String *)sub_18007E180(&off_18E283010);
		      System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v6, v7, 0LL);
		      v8 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v6, v8);
		    }
		    goto LABEL_35;
		  }
		  if ( desc->_graphicsFormat )
		  {
		LABEL_39:
		    if ( !UnityEngine::SystemInfo::IsFormatSupported(
		            (GraphicsFormat__Enum)desc->_graphicsFormat,
		            FormatUsage__Enum_Render,
		            0LL) )
		    {
		      v53.monitor = (MonitorData *)-1LL;
		      v53.klass = (Enum__Class *)sub_18007E180(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat);
		      graphicsFormat = desc->_graphicsFormat;
		      v9 = System::Enum::ToString(&v53, 0LL);
		      v10 = (String *)sub_18007E180(&off_18E283020);
		      v11 = (String *)sub_18007E180(&off_18E283030);
		      v12 = System::String::Concat(v11, v9, v10, 0LL);
		      v13 = sub_18007E180(&TypeInfo::System::ArgumentException);
		      v14 = (ArgumentException *)sub_18002C620(v13);
		      if ( v14 )
		      {
		        v15 = (String *)sub_18007E180(&off_18E282FF0);
		        System::ArgumentException::ArgumentException(v14, v12, v15, 0LL);
		        v16 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		        sub_18007E190(v14, v16);
		      }
		      goto LABEL_35;
		    }
		  }
		  if ( desc->_depthStencilFormat_k__BackingField )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormatUtility);
		    if ( !UnityEngine::Experimental::Rendering::GraphicsFormatUtility::IsDepthFormat(
		            (GraphicsFormat__Enum)desc->_depthStencilFormat_k__BackingField,
		            0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormatUtility);
		      if ( !UnityEngine::Experimental::Rendering::GraphicsFormatUtility::IsStencilFormat(
		              (GraphicsFormat__Enum)desc->_depthStencilFormat_k__BackingField,
		              0LL) )
		      {
		        v53.monitor = (MonitorData *)-1LL;
		        v53.klass = (Enum__Class *)sub_18007E180(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat);
		        graphicsFormat = desc->_depthStencilFormat_k__BackingField;
		        v17 = System::Enum::ToString(&v53, 0LL);
		        v18 = (String *)sub_18007E180(&off_18E283020);
		        v19 = (String *)sub_18007E180(&off_18E283000);
		        v20 = System::String::Concat(v19, v17, v18, 0LL);
		        v21 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v22 = (ArgumentException *)sub_18002C620(v21);
		        if ( v22 )
		        {
		          v23 = (String *)sub_18007E180(&off_18E282FC8);
		          System::ArgumentException::ArgumentException(v22, v20, v23, 0LL);
		          v24 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		          sub_18007E190(v22, v24);
		        }
		        goto LABEL_35;
		      }
		    }
		  }
		  if ( desc->_width_k__BackingField <= 0 )
		  {
		    v45 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v46 = (ArgumentException *)sub_18002C620(v45);
		    if ( v46 )
		    {
		      v47 = (String *)sub_18007E180(&off_18E282FD0);
		      v48 = (String *)sub_18007E180(&off_18E282FE0);
		      System::ArgumentException::ArgumentException(v46, v48, v47, 0LL);
		      v49 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v46, v49);
		    }
		LABEL_35:
		    sub_1800D8260(Patch, v4);
		  }
		  if ( desc->_height_k__BackingField <= 0 )
		  {
		    v40 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v41 = (ArgumentException *)sub_18002C620(v40);
		    if ( v41 )
		    {
		      v42 = (String *)sub_18007E180(&off_18E282FE8);
		      v43 = (String *)sub_18007E180(&off_18E282FA0);
		      System::ArgumentException::ArgumentException(v41, v43, v42, 0LL);
		      v44 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v41, v44);
		    }
		    goto LABEL_35;
		  }
		  if ( desc->_volumeDepth_k__BackingField <= 0 )
		  {
		    v35 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v36 = (ArgumentException *)sub_18002C620(v35);
		    if ( v36 )
		    {
		      v37 = (String *)sub_18007E180(&off_18E282FA8);
		      v38 = (String *)sub_18007E180(&off_18E282FB0);
		      System::ArgumentException::ArgumentException(v36, v38, v37, 0LL);
		      v39 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v36, v39);
		    }
		    goto LABEL_35;
		  }
		  if ( desc->_msaaSamples_k__BackingField != 1
		    && desc->_msaaSamples_k__BackingField != 2
		    && desc->_msaaSamples_k__BackingField != 4
		    && desc->_msaaSamples_k__BackingField != 8 )
		  {
		    v25 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v26 = (ArgumentException *)sub_18002C620(v25);
		    if ( v26 )
		    {
		      v27 = (String *)sub_18007E180(&off_18E282FC0);
		      v28 = (String *)sub_18007E180(&off_18E282F88);
		      System::ArgumentException::ArgumentException(v26, v28, v27, 0LL);
		      v29 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v26, v29);
		    }
		    goto LABEL_35;
		  }
		  if ( desc->_dimension_k__BackingField == 6
		    && desc->_volumeDepth_k__BackingField != 6 * (desc->_volumeDepth_k__BackingField / 6u) )
		  {
		    v30 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v31 = (ArgumentException *)sub_18002C620(v30);
		    if ( v31 )
		    {
		      v32 = (String *)sub_18007E180(&off_18E282FA8);
		      v33 = (String *)sub_18007E180(&off_18E282F90);
		      System::ArgumentException::ArgumentException(v31, v33, v32, 0LL);
		      v34 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
		      sub_18007E190(v31, v34);
		    }
		    goto LABEL_35;
		  }
		}
		
		public static void ReleaseRenderTexture(ref RenderTexture rt) {} // 0x0000000189C5F1B4-0x0000000189C5F258
		public static bool CreateRenderTextureIfNeeded(ref RenderTexture rt, RenderTextureDescriptor rtDesc) => default; // 0x0000000189C5EA4C-0x0000000189C5ED1C
		// Boolean CreateRenderTextureIfNeeded(RenderTexture ByRef, RenderTextureDescriptor)
		bool HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(
		        RenderTexture **rt,
		        RenderTextureDescriptor *rtDesc,
		        MethodInfo *method)
		{
		  struct VolumetricSDFUtils__Class *v5; // rcx
		  int32_t msaaSamples_k__BackingField; // eax
		  int32_t volumeDepth_k__BackingField; // r14d
		  bool v8; // cc
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  Object_1 *v12; // rbx
		  RenderTexture *Patch; // rcx
		  RenderTexture *v14; // rdx
		  RenderTextureFormat__Enum format; // ebx
		  bool sRGB; // bl
		  RenderTexture *v18; // rax
		  RenderTexture *v19; // rbx
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v23; // rdx
		  VolumetricRenderer_VolumetricBounds *v24; // r8
		  Int32__Array **v25; // r9
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  RenderTextureDescriptor v29; // [rsp+20h] [rbp-40h] BYREF
		  bool v30; // [rsp+58h] [rbp-8h]
		  MethodInfo *vars0; // [rsp+60h] [rbp+0h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5074, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::System::Math);
		    v5 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
		    msaaSamples_k__BackingField = 1;
		    volumeDepth_k__BackingField = 1;
		    if ( rtDesc->_volumeDepth_k__BackingField >= 1 )
		      volumeDepth_k__BackingField = rtDesc->_volumeDepth_k__BackingField;
		    v8 = rtDesc->_msaaSamples_k__BackingField < 1;
		    rtDesc->_volumeDepth_k__BackingField = volumeDepth_k__BackingField;
		    if ( !v8 )
		      msaaSamples_k__BackingField = rtDesc->_msaaSamples_k__BackingField;
		    rtDesc->_msaaSamples_k__BackingField = msaaSamples_k__BackingField;
		    sub_1800036A0(v5);
		    v9 = *(_OWORD *)&rtDesc->_width_k__BackingField;
		    v10 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		    v29._memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		    *(_OWORD *)&v29._width_k__BackingField = v9;
		    v11 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		    *(_OWORD *)&v29._mipCount_k__BackingField = v10;
		    *(_OWORD *)&v29._dimension_k__BackingField = v11;
		    HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc(&v29, 0LL);
		    v12 = (Object_1 *)*rt;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(v12, 0LL, 0LL) )
		    {
		      v14 = *rt;
		      if ( !*rt )
		        goto LABEL_32;
		      if ( (unsigned int)sub_180002F70(5LL, v14) == rtDesc->_width_k__BackingField )
		      {
		        v14 = *rt;
		        if ( !*rt )
		          goto LABEL_32;
		        if ( (unsigned int)sub_180002F70(7LL, v14) == rtDesc->_height_k__BackingField )
		        {
		          Patch = *rt;
		          if ( !*rt )
		            goto LABEL_32;
		          if ( UnityEngine::RenderTexture::get_depthStencilFormat(Patch, 0LL) == rtDesc->_depthStencilFormat_k__BackingField )
		          {
		            Patch = *rt;
		            if ( !*rt )
		              goto LABEL_32;
		            if ( UnityEngine::RenderTexture::get_volumeDepth(Patch, 0LL) == volumeDepth_k__BackingField )
		            {
		              Patch = *rt;
		              if ( !*rt )
		                goto LABEL_32;
		              format = UnityEngine::RenderTexture::get_format(Patch, 0LL);
		              if ( format == UnityEngine::RenderTextureDescriptor::get_colorFormat(rtDesc, 0LL) )
		              {
		                v14 = *rt;
		                if ( !*rt )
		                  goto LABEL_32;
		                if ( (unsigned int)sub_180002F70(9LL, v14) == rtDesc->_dimension_k__BackingField )
		                {
		                  Patch = *rt;
		                  if ( !*rt )
		                    goto LABEL_32;
		                  sRGB = UnityEngine::RenderTexture::get_sRGB(Patch, 0LL);
		                  if ( sRGB == UnityEngine::RenderTextureDescriptor::get_sRGB(rtDesc, 0LL) )
		                  {
		                    Patch = *rt;
		                    if ( !*rt )
		                      goto LABEL_32;
		                    if ( UnityEngine::RenderTexture::get_enableRandomWrite(Patch, 0LL) == ((rtDesc->_flags & 0x10) != 0) )
		                    {
		                      Patch = *rt;
		                      if ( !*rt )
		                        goto LABEL_32;
		                      if ( UnityEngine::RenderTexture::get_useMipMap(Patch, 0LL) == ((rtDesc->_flags & 1) != 0) )
		                      {
		                        Patch = *rt;
		                        if ( !*rt )
		                          goto LABEL_32;
		                        if ( UnityEngine::RenderTexture::get_autoGenerateMips(Patch, 0LL) == ((rtDesc->_flags & 2) != 0) )
		                          return 0;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(rt, 0LL);
		    v18 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		    v19 = v18;
		    if ( v18 )
		    {
		      v20 = *(_OWORD *)&rtDesc->_width_k__BackingField;
		      v21 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		      v29._memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		      *(_OWORD *)&v29._width_k__BackingField = v20;
		      v22 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		      *(_OWORD *)&v29._mipCount_k__BackingField = v21;
		      *(_OWORD *)&v29._dimension_k__BackingField = v22;
		      UnityEngine::RenderTexture::RenderTexture(v18, &v29, 0LL);
		      *rt = v19;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)rt,
		        v23,
		        v24,
		        v25,
		        *(MethodInfo **)&v29._width_k__BackingField,
		        v29._msaaSamples_k__BackingField,
		        v29._mipCount_k__BackingField,
		        v29._stencilFormat_k__BackingField,
		        *(float *)&v29._dimension_k__BackingField,
		        v29._vrUsage_k__BackingField,
		        v29._memoryless_k__BackingField,
		        v30,
		        vars0);
		      Patch = *rt;
		      if ( *rt )
		      {
		        UnityEngine::RenderTexture::Create(Patch, 0LL);
		        return 1;
		      }
		    }
		LABEL_32:
		    sub_1800D8260(Patch, v14);
		  }
		  Patch = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(5074, 0LL);
		  if ( !Patch )
		    goto LABEL_32;
		  memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		  v27 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		  *(_OWORD *)&v29._width_k__BackingField = *(_OWORD *)&rtDesc->_width_k__BackingField;
		  v28 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		  v29._memoryless_k__BackingField = memoryless_k__BackingField;
		  *(_OWORD *)&v29._mipCount_k__BackingField = v27;
		  *(_OWORD *)&v29._dimension_k__BackingField = v28;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1477((ILFixDynamicMethodWrapper_2 *)Patch, rt, &v29, 0LL);
		}
		
		public static void ReleaseEncodedRenderTexture(ref VolumetricEncodedTexture ert) {} // 0x0000000189C5F12C-0x0000000189C5F1B4
		public static bool CreateEncodedRenderTextureIfNeeded(ref VolumetricEncodedTexture ert, RenderTextureDescriptor rtDesc) => default; // 0x0000000189C5E788-0x0000000189C5E940
		// Boolean CreateEncodedRenderTextureIfNeeded(VolumetricEncodedTexture ByRef, RenderTextureDescriptor)
		bool HG::Rendering::Runtime::VolumetricSDFUtils::CreateEncodedRenderTextureIfNeeded(
		        VolumetricEncodedTexture **ert,
		        RenderTextureDescriptor *rtDesc,
		        MethodInfo *method)
		{
		  char v5; // r14
		  VolumetricEncodedTexture *v6; // rbx
		  Object_1 *Texture; // rbx
		  VolumetricEncodedTexture *v8; // rbx
		  Texture *v9; // rax
		  VolumetricEncodedTexture *v10; // rdx
		  VolumetricEncodedTexture *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  VolumetricEncodedTexture *v13; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
		  VolumetricRenderer_VolumetricBounds *v15; // r8
		  Int32__Array **v16; // r9
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  bool v20; // al
		  VolumetricRenderer_VolumetricBounds *v21; // r8
		  Int32__Array **v22; // r9
		  bool v23; // r9
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  RenderTextureDescriptor v28; // [rsp+20h] [rbp-40h] BYREF
		  bool v29; // [rsp+58h] [rbp-8h]
		  MethodInfo *vars0; // [rsp+60h] [rbp+0h]
		  Texture *v31; // [rsp+98h] [rbp+38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5306, 0LL) )
		  {
		    v5 = 0;
		    v6 = *ert;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    Texture = (Object_1 *)HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(v6, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(Texture, 0LL, 0LL)
		      || (v8 = *ert,
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils),
		          v9 = HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(v8, 0LL),
		          !sub_180005050(v9, TypeInfo::UnityEngine::RenderTexture)) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseEncodedRenderTexture(ert, 0LL);
		      v11 = (VolumetricEncodedTexture *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
		      v13 = v11;
		      if ( !v11 )
		        goto LABEL_10;
		      HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(v11, 0LL);
		      *ert = v13;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)ert,
		        v14,
		        v15,
		        v16,
		        *(MethodInfo **)&v28._width_k__BackingField,
		        v28._msaaSamples_k__BackingField,
		        v28._mipCount_k__BackingField,
		        v28._stencilFormat_k__BackingField,
		        *(float *)&v28._dimension_k__BackingField,
		        v28._vrUsage_k__BackingField,
		        v28._memoryless_k__BackingField,
		        v29,
		        vars0);
		      v5 = 1;
		    }
		    Patch = (ILFixDynamicMethodWrapper_2 *)*ert;
		    if ( *ert )
		    {
		      v31 = (Texture *)sub_180005050(Patch->fields.virtualMachine, TypeInfo::UnityEngine::RenderTexture);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v17 = *(_OWORD *)&rtDesc->_width_k__BackingField;
		      v18 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		      v28._memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		      *(_OWORD *)&v28._width_k__BackingField = v17;
		      v19 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		      *(_OWORD *)&v28._mipCount_k__BackingField = v18;
		      *(_OWORD *)&v28._dimension_k__BackingField = v19;
		      v20 = HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded((RenderTexture **)&v31, &v28, 0LL);
		      v10 = *ert;
		      if ( *ert )
		      {
		        v10->fields.Tex = v31;
		        LOBYTE(v22) = v5 | v20;
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)&v10->fields,
		          (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v10,
		          v21,
		          v22,
		          *(MethodInfo **)&v28._width_k__BackingField,
		          v28._msaaSamples_k__BackingField,
		          v28._mipCount_k__BackingField,
		          v28._stencilFormat_k__BackingField,
		          *(float *)&v28._dimension_k__BackingField,
		          v28._vrUsage_k__BackingField,
		          v28._memoryless_k__BackingField,
		          v29,
		          vars0);
		        return v23;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5306, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		  v26 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		  *(_OWORD *)&v28._width_k__BackingField = *(_OWORD *)&rtDesc->_width_k__BackingField;
		  v27 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		  v28._memoryless_k__BackingField = memoryless_k__BackingField;
		  *(_OWORD *)&v28._mipCount_k__BackingField = v26;
		  *(_OWORD *)&v28._dimension_k__BackingField = v27;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1537(Patch, ert, &v28, 0LL);
		}
		
		public static RenderTexture GetTemporaryTexture(RenderTextureDescriptor rtDesc) => default; // 0x0000000189C5F024-0x0000000189C5F0C4
		// RenderTexture GetTemporaryTexture(RenderTextureDescriptor)
		RenderTexture *HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(
		        RenderTextureDescriptor *rtDesc,
		        MethodInfo *method)
		{
		  int32_t depthBufferBits; // ebx
		  RenderTextureFormat__Enum colorFormat; // eax
		  __int64 v6; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  RenderTextureDescriptor v11; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5080, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5080, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v6);
		    v8 = *(_OWORD *)&rtDesc->_width_k__BackingField;
		    v9 = *(_OWORD *)&rtDesc->_mipCount_k__BackingField;
		    v11._memoryless_k__BackingField = rtDesc->_memoryless_k__BackingField;
		    *(_OWORD *)&v11._width_k__BackingField = v8;
		    v10 = *(_OWORD *)&rtDesc->_dimension_k__BackingField;
		    *(_OWORD *)&v11._mipCount_k__BackingField = v9;
		    *(_OWORD *)&v11._dimension_k__BackingField = v10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1480(Patch, &v11, 0LL);
		  }
		  else
		  {
		    depthBufferBits = UnityEngine::RenderTextureDescriptor::get_depthBufferBits(rtDesc, 0LL);
		    colorFormat = UnityEngine::RenderTextureDescriptor::get_colorFormat(rtDesc, 0LL);
		    return UnityEngine::RenderTexture::GetTemporary(
		             rtDesc->_width_k__BackingField,
		             rtDesc->_height_k__BackingField,
		             depthBufferBits,
		             colorFormat,
		             0LL);
		  }
		}
		
		public static void ReleaseTemporaryTexture(ref RenderTexture texture) {} // 0x0000000189C5F258-0x0000000189C5F2DC
		public static void CreateCommandBufferIfNeeded(ref CommandBuffer cmd, string name) {} // 0x0000000189C5E6EC-0x0000000189C5E788
		public static void ReleaseCommandBuffer(ref CommandBuffer cmd) {} // 0x0000000189C5F0C4-0x0000000189C5F12C
		// Void ReleaseCommandBuffer(CommandBuffer ByRef)
		void HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseCommandBuffer(CommandBuffer **cmd, MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  VolumetricRenderer_VolumetricBounds *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		  bool v10; // [rsp+58h] [rbp+30h]
		  int32_t v11; // [rsp+60h] [rbp+38h]
		  int32_t v12; // [rsp+68h] [rbp+40h]
		  float v13; // [rsp+70h] [rbp+48h]
		  int32_t v14; // [rsp+78h] [rbp+50h]
		  bool v15; // [rsp+80h] [rbp+58h]
		  bool v16; // [rsp+88h] [rbp+60h]
		  MethodInfo *v17; // [rsp+90h] [rbp+68h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5308, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5308, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1539(Patch, cmd, 0LL);
		  }
		  else if ( *cmd )
		  {
		    UnityEngine::Rendering::CommandBuffer::Dispose(*cmd, 0LL);
		    *cmd = 0LL;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)cmd,
		      v3,
		      v4,
		      v5,
		      v9,
		      v10,
		      v11,
		      v12,
		      v13,
		      v14,
		      v15,
		      v16,
		      v17);
		  }
		}
		
		public static void SetVolumetricMaterialMVMode(CommandBuffer cmd, Material mat, int mode) {} // 0x0000000189C5FF38-0x0000000189C6015C
		// Void SetVolumetricMaterialMVMode(CommandBuffer, Material, Int32)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(
		        CommandBuffer *cmd,
		        Material *mat,
		        int32_t mode,
		        MethodInfo *method)
		{
		  int i; // ebx
		  VolumetricSDFUtils__StaticFields *static_fields; // rdx
		  _QWORD *p_Layer_Default; // rcx
		  __int64 v10; // rax
		  Shader *v11; // r15
		  String__Array *v12; // r8
		  String *v13; // r8
		  Shader *shader; // r15
		  String__Array *s_MV_MODES; // r8
		  String *v16; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword keyword; // [rsp+30h] [rbp-30h] BYREF
		  LocalKeyword v19; // [rsp+48h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5126, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5126, 0LL);
		    if ( !Patch )
		      goto LABEL_23;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
		      (ILFixDynamicMethodWrapper_15 *)Patch,
		      (Object *)cmd,
		      (Object *)mat,
		      mode,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)mat, 0LL) )
		    {
		      for ( i = 1; ; ++i )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields->Layer_Default;
		        v10 = p_Layer_Default[9];
		        if ( !v10 )
		          break;
		        if ( i >= *(_DWORD *)(v10 + 24) )
		          return;
		        if ( mode == i )
		        {
		          if ( !mat )
		            goto LABEL_21;
		          shader = UnityEngine::Material::get_shader(mat, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		          p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_0.image;
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields;
		          s_MV_MODES = static_fields->s_MV_MODES;
		          if ( !s_MV_MODES )
		            goto LABEL_21;
		          if ( (unsigned int)i >= s_MV_MODES->max_length.size )
		            sub_1800D2AB0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, static_fields);
		          v16 = s_MV_MODES->vector[i];
		          memset(&v19, 0, sizeof(v19));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, v16, 0LL);
		          keyword = v19;
		          if ( !cmd )
		LABEL_21:
		            sub_1800D8260(p_Layer_Default, static_fields);
		          UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		        }
		        else
		        {
		          if ( !mat )
		            goto LABEL_19;
		          v11 = UnityEngine::Material::get_shader(mat, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		          p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_0.image;
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->static_fields;
		          v12 = static_fields->s_MV_MODES;
		          if ( !v12 )
		            goto LABEL_19;
		          if ( (unsigned int)i >= v12->max_length.size )
		            sub_1800D2AB0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, static_fields);
		          v13 = v12->vector[i];
		          memset(&v19, 0, sizeof(v19));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, v11, v13, 0LL);
		          keyword = v19;
		          if ( !cmd )
		LABEL_19:
		            sub_1800D8260(p_Layer_Default, static_fields);
		          UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		        }
		      }
		LABEL_23:
		      sub_1800D8260(p_Layer_Default, static_fields);
		    }
		  }
		}
		
		[IDTag(0)]
		public static Vector3 UpdateMainLightDirection(Material cloudMat, HGEnvironmentPhase phase) => default; // 0x0000000189C6085C-0x0000000189C60AF8
		// Vector3 UpdateMainLightDirection(Material, HGEnvironmentPhase)
		Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
		        Vector3 *__return_ptr retstr,
		        Material *cloudMat,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  float x; // xmm1_4
		  MethodInfo *v8; // rdx
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  float v10; // xmm8_4
		  float v11; // xmm7_4
		  MethodInfo *v12; // r8
		  float v13; // eax
		  float v14; // xmm0_4
		  __int64 v15; // rcx
		  double v16; // xmm0_8
		  VolumetricShaderIDs__StaticFields *v17; // rcx
		  int32_t MainLightDirection; // ebx
		  Beyond::DampingMath *v19; // rcx
		  Beyond::DampingMath *v20; // rcx
		  Beyond::DampingMath *v21; // rcx
		  Beyond::DampingMath *v22; // rcx
		  float v23; // xmm1_4
		  Beyond::DampingMath *v24; // rcx
		  Beyond::DampingMath *v25; // rcx
		  Beyond::DampingMath *v26; // rcx
		  Beyond::DampingMath *v27; // rcx
		  Vector3 *up; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // xmm0_8
		  float z; // eax
		  Vector3 v33; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v34; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5117, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5117, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_364(
		           (Vector3 *)&v34,
		           Patch,
		           (Object *)cloudMat,
		           (Object *)phase,
		           0LL);
		LABEL_13:
		    v30 = *(_QWORD *)&up->x;
		    z = up->z;
		    *(_QWORD *)&retstr->x = v30;
		    retstr->z = z;
		    return retstr;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL)
		    || (sub_1800036A0(TypeInfo::UnityEngine::Object), !UnityEngine::Object::op_Implicit((Object_1 *)phase, 0LL)) )
		  {
		    up = UnityEngine::Vector3::get_up((Vector3 *)&v34, v8);
		    goto LABEL_13;
		  }
		  if ( !phase
		    || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields,
		        !cloudMat) )
		  {
		LABEL_11:
		    sub_1800D8260(static_fields, v8);
		  }
		  v10 = UnityEngine::Material::GetFloatImpl(cloudMat, static_fields->_YawOffset, 0LL) * 0.017453292;
		  v11 = UnityEngine::Material::GetFloatImpl(
		          cloudMat,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PitchOffset,
		          0LL)
		      * 0.017453292;
		  if ( UnityEngine::Material::GetInt(
		         cloudMat,
		         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_UseSunDirection,
		         0LL) > 0 )
		  {
		    v13 = phase->fields.lightConfig.forwardDirect.z;
		    *(_QWORD *)&v33.x = *(_QWORD *)&phase->fields.lightConfig.forwardDirect.x;
		    v33.z = v13;
		    *(_QWORD *)&v33.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v34, &v33, v12)->x;
		    v14 = sub_180334170();
		    x = v33.x;
		    v11 = v11 + v14;
		    v16 = sub_1803345E0(v15);
		    v10 = v10 + *(float *)&v16;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v17 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  MainLightDirection = v17->_MainLightDirection;
		  Beyond::DampingMath::cosf((Beyond::DampingMath *)v17, x);
		  Beyond::DampingMath::cosf(v19, x);
		  v34.x = v11 * v10;
		  Beyond::DampingMath::sinf(v20, x);
		  v34.y = v11;
		  Beyond::DampingMath::cosf(v21, x);
		  Beyond::DampingMath::sinf(v22, x);
		  *(_QWORD *)&v34.z = COERCE_UNSIGNED_INT(v11 * v10);
		  v23 = v34.x;
		  UnityEngine::Material::SetVector(cloudMat, MainLightDirection, &v34, 0LL);
		  Beyond::DampingMath::cosf(v24, v23);
		  Beyond::DampingMath::cosf(v25, v23);
		  retstr->x = v10 * v11;
		  Beyond::DampingMath::sinf(v26, v23);
		  retstr->y = v11;
		  Beyond::DampingMath::sinf(v27, v23);
		  retstr->z = v10 * v11;
		  return retstr;
		}
		
		[IDTag(1)]
		public static void UpdateMainLightDirection(Material cloudMat, MaterialPropertyBlock propertyBlock, HGEnvironmentPhase phase) {} // 0x0000000189C60AF8-0x0000000189C60D44
		// Void UpdateMainLightDirection(Material, MaterialPropertyBlock, HGEnvironmentPhase)
		void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
		        Material *cloudMat,
		        MaterialPropertyBlock *propertyBlock,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  float x; // xmm1_4
		  __int64 v8; // rdx
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  float v10; // xmm8_4
		  float v11; // xmm7_4
		  MethodInfo *v12; // r8
		  float z; // eax
		  float v14; // xmm0_4
		  __int64 v15; // rcx
		  double v16; // xmm0_8
		  VolumetricShaderIDs__StaticFields *v17; // rcx
		  int32_t MainLightDirection; // ebx
		  Beyond::DampingMath *v19; // rcx
		  Beyond::DampingMath *v20; // rcx
		  Beyond::DampingMath *v21; // rcx
		  Beyond::DampingMath *v22; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v24; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v25; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5309, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5309, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)cloudMat,
		        (Object *)propertyBlock,
		        (Object *)phase,
		        0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL) )
		    return;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit((Object_1 *)phase, 0LL) || !propertyBlock )
		    return;
		  if ( !phase
		    || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields,
		        !cloudMat) )
		  {
		LABEL_11:
		    sub_1800D8260(static_fields, v8);
		  }
		  v10 = UnityEngine::Material::GetFloatImpl(cloudMat, static_fields->_YawOffset, 0LL) * 0.017453292;
		  v11 = UnityEngine::Material::GetFloatImpl(
		          cloudMat,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PitchOffset,
		          0LL)
		      * 0.017453292;
		  if ( UnityEngine::Material::GetInt(
		         cloudMat,
		         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_UseSunDirection,
		         0LL) > 0 )
		  {
		    z = phase->fields.lightConfig.forwardDirect.z;
		    *(_QWORD *)&v24.x = *(_QWORD *)&phase->fields.lightConfig.forwardDirect.x;
		    v24.z = z;
		    *(_QWORD *)&v24.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v25, &v24, v12)->x;
		    v14 = sub_180334170();
		    x = v24.x;
		    v11 = v11 + v14;
		    v16 = sub_1803345E0(v15);
		    v10 = v10 + *(float *)&v16;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v17 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  MainLightDirection = v17->_MainLightDirection;
		  Beyond::DampingMath::cosf((Beyond::DampingMath *)v17, x);
		  Beyond::DampingMath::cosf(v19, x);
		  v25.x = v11 * v10;
		  Beyond::DampingMath::sinf(v20, x);
		  v25.y = v11;
		  Beyond::DampingMath::cosf(v21, x);
		  Beyond::DampingMath::sinf(v22, x);
		  *(_QWORD *)&v25.z = COERCE_UNSIGNED_INT(v11 * v10);
		  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, MainLightDirection, &v25, 0LL);
		}
		
		public static unsafe void UpdateMainLightDirectionCPP(Material cloudMat, HGVolumetricCloudDataCB* dataCB, HGEnvironmentPhase phase) {} // 0x0000000189C606A0-0x0000000189C6085C
		// Void UpdateMainLightDirectionCPP(Material, HGVolumetricCloudDataCB*, HGEnvironmentPhase)
		void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirectionCPP(
		        Material *cloudMat,
		        HGVolumetricCloudDataCB *dataCB,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  float x; // xmm1_4
		  __int64 v8; // rdx
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  float v10; // xmm8_4
		  float v11; // xmm7_4
		  Beyond::DampingMath *v12; // rcx
		  MethodInfo *v13; // r8
		  float z; // eax
		  float v15; // xmm0_4
		  __int64 v16; // rcx
		  double v17; // xmm0_8
		  Beyond::DampingMath *v18; // rcx
		  Beyond::DampingMath *v19; // rcx
		  Beyond::DampingMath *v20; // rcx
		  Beyond::DampingMath *v21; // rcx
		  Vector3 v22; // [rsp+20h] [rbp-58h] BYREF
		  Vector4 v23; // [rsp+30h] [rbp-48h] BYREF
		
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL) )
		  {
		    if ( !phase )
		      goto LABEL_9;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( !cloudMat )
		      goto LABEL_9;
		    v10 = UnityEngine::Material::GetFloatImpl(cloudMat, static_fields->_YawOffset, 0LL) * 0.017453292;
		    v11 = UnityEngine::Material::GetFloatImpl(
		            cloudMat,
		            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PitchOffset,
		            0LL)
		        * 0.017453292;
		    if ( UnityEngine::Material::GetInt(
		           cloudMat,
		           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_UseSunDirection,
		           0LL) > 0 )
		    {
		      z = phase->fields.lightConfig.forwardDirect.z;
		      *(_QWORD *)&v22.x = *(_QWORD *)&phase->fields.lightConfig.forwardDirect.x;
		      v22.z = z;
		      *(_QWORD *)&v22.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v23, &v22, v13)->x;
		      v15 = sub_180334170();
		      x = v22.x;
		      v11 = v11 + v15;
		      v17 = sub_1803345E0(v16);
		      v10 = v10 + *(float *)&v17;
		    }
		    Beyond::DampingMath::cosf(v12, x);
		    Beyond::DampingMath::cosf(v18, x);
		    v23.x = v11 * v10;
		    Beyond::DampingMath::sinf(v19, x);
		    v23.y = v11;
		    Beyond::DampingMath::cosf(v20, x);
		    Beyond::DampingMath::sinf(v21, x);
		    *(_QWORD *)&v23.z = COERCE_UNSIGNED_INT(v11 * v10);
		    if ( !dataCB )
		LABEL_9:
		      sub_1800D8260(static_fields, v8);
		    dataCB->_MainLightDirection = v23;
		  }
		}
		
		public static Bounds CalculateBounds(Mesh mesh, Transform transform) => default; // 0x0000000189C5DD40-0x0000000189C5E310
		// Bounds CalculateBounds(Mesh, Transform)
		Bounds *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(
		        Bounds *__return_ptr retstr,
		        Mesh *mesh,
		        Transform *transform,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Bounds *bounds; // rax
		  __int64 v10; // xmm1_8
		  __int64 v11; // r14
		  Vector3 *min; // rax
		  __int64 v13; // xmm0_8
		  Vector3 *v14; // rax
		  __int64 v15; // xmm0_8
		  float z; // eax
		  Vector3 *v17; // rbx
		  __m128 y_low; // xmm6
		  Vector3 *max; // rax
		  unsigned __int64 v20; // xmm0_8
		  Vector3 *v21; // rax
		  __int64 v22; // xmm0_8
		  Vector3 *v23; // rbx
		  __m128 v24; // xmm6
		  Vector3 *v25; // rax
		  unsigned __int64 v26; // xmm0_8
		  Vector3 *v27; // rax
		  __int64 v28; // xmm0_8
		  Vector3 *v29; // rbx
		  __m128 v30; // xmm6
		  Vector3 *v31; // rax
		  unsigned __int64 v32; // xmm0_8
		  Vector3 *v33; // rax
		  __int64 v34; // xmm0_8
		  Vector3 *v35; // rax
		  __int64 v36; // xmm0_8
		  Vector3 *v37; // rax
		  __int64 v38; // xmm0_8
		  Vector3 *v39; // rbx
		  __m128 v40; // xmm6
		  Vector3 *v41; // rax
		  unsigned __int64 v42; // xmm0_8
		  Vector3 *v43; // rax
		  __int64 v44; // xmm0_8
		  Vector3 *v45; // rbx
		  __m128 v46; // xmm6
		  Vector3 *v47; // rax
		  unsigned __int64 v48; // xmm0_8
		  Vector3 *v49; // rax
		  __int64 v50; // xmm0_8
		  Vector3 *v51; // rbx
		  __m128 v52; // xmm6
		  Vector3 *v53; // rax
		  unsigned __int64 v54; // xmm0_8
		  Vector3 *v55; // rax
		  __int64 v56; // rsi
		  __int64 v57; // xmm0_8
		  __int64 v58; // xmm6_8
		  __int64 v59; // rbx
		  __int128 v60; // xmm7
		  Bounds *v61; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds *v63; // rax
		  __int64 v64; // xmm1_8
		  Bounds v66; // [rsp+38h] [rbp-39h] BYREF
		  Vector3 m_Center; // [rsp+58h] [rbp-19h] BYREF
		  Bounds v68; // [rsp+68h] [rbp-9h] BYREF
		  Bounds v69[2]; // [rsp+88h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5122, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5122, 0LL);
		    if ( Patch )
		    {
		      v63 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(v69, Patch, (Object *)mesh, (Object *)transform, 0LL);
		      v64 = *(_QWORD *)&v63->m_Extents.y;
		      *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&v63->m_Center.x;
		      *(_QWORD *)&retstr->m_Extents.y = v64;
		      return retstr;
		    }
		    goto LABEL_12;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality((Object_1 *)mesh, 0LL, 0LL)
		    || (sub_1800036A0(TypeInfo::UnityEngine::Object),
		        !UnityEngine::Object::op_Inequality((Object_1 *)transform, 0LL, 0LL)) )
		  {
		    *(_OWORD *)&retstr->m_Center.x = 0LL;
		    *(_QWORD *)&v69[0].m_Extents.y = 0LL;
		    *(_QWORD *)&retstr->m_Extents.y = 0LL;
		    return retstr;
		  }
		  if ( !mesh )
		    goto LABEL_12;
		  bounds = UnityEngine::Mesh::get_bounds(&v68, mesh, 0LL);
		  v10 = *(_QWORD *)&bounds->m_Extents.y;
		  *(_OWORD *)&v69[0].m_Center.x = *(_OWORD *)&bounds->m_Center.x;
		  *(_QWORD *)&v69[0].m_Extents.y = v10;
		  v11 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 8LL);
		  min = UnityEngine::Bounds::get_min(&v68.m_Center, v69, 0LL);
		  if ( !transform
		    || (v13 = *(_QWORD *)&min->x,
		        v66.m_Center.z = min->z,
		        *(_QWORD *)&v66.m_Center.x = v13,
		        v14 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &v66.m_Center, 0LL),
		        !v11) )
		  {
		LABEL_12:
		    sub_1800D8260(v8, v7);
		  }
		  v15 = *(_QWORD *)&v14->x;
		  z = v14->z;
		  *(_QWORD *)&m_Center.x = v15;
		  m_Center.z = z;
		  sub_180049BD0(v11, 0LL, &m_Center);
		  v17 = UnityEngine::Bounds::get_min(&v68.m_Center, v69, 0LL);
		  y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v69, 0LL)->y);
		  max = UnityEngine::Bounds::get_max(&m_Center, v69, 0LL);
		  v20 = _mm_unpacklo_ps((__m128)LODWORD(v17->x), y_low).m128_u64[0];
		  m_Center.z = max->z;
		  *(_QWORD *)&m_Center.x = v20;
		  v21 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v22 = *(_QWORD *)&v21->x;
		  *(float *)&v21 = v21->z;
		  *(_QWORD *)&v66.m_Center.x = v22;
		  LODWORD(v66.m_Center.z) = (_DWORD)v21;
		  sub_180049BD0(v11, 1LL, &v66);
		  v23 = UnityEngine::Bounds::get_min(&v68.m_Center, v69, 0LL);
		  v24 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&m_Center, v69, 0LL)->y);
		  v25 = UnityEngine::Bounds::get_min(&m_Center, v69, 0LL);
		  v26 = _mm_unpacklo_ps((__m128)LODWORD(v23->x), v24).m128_u64[0];
		  m_Center.z = v25->z;
		  *(_QWORD *)&m_Center.x = v26;
		  v27 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v28 = *(_QWORD *)&v27->x;
		  *(float *)&v27 = v27->z;
		  *(_QWORD *)&v66.m_Center.x = v28;
		  LODWORD(v66.m_Center.z) = (_DWORD)v27;
		  sub_180049BD0(v11, 2LL, &v66);
		  v29 = UnityEngine::Bounds::get_min(&v68.m_Center, v69, 0LL);
		  v30 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&m_Center, v69, 0LL)->y);
		  v31 = UnityEngine::Bounds::get_max(&m_Center, v69, 0LL);
		  v32 = _mm_unpacklo_ps((__m128)LODWORD(v29->x), v30).m128_u64[0];
		  m_Center.z = v31->z;
		  *(_QWORD *)&m_Center.x = v32;
		  v33 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v34 = *(_QWORD *)&v33->x;
		  *(float *)&v33 = v33->z;
		  *(_QWORD *)&v66.m_Center.x = v34;
		  LODWORD(v66.m_Center.z) = (_DWORD)v33;
		  sub_180049BD0(v11, 3LL, &v66);
		  v35 = UnityEngine::Bounds::get_max(&v68.m_Center, v69, 0LL);
		  v36 = *(_QWORD *)&v35->x;
		  *(float *)&v35 = v35->z;
		  *(_QWORD *)&m_Center.x = v36;
		  LODWORD(m_Center.z) = (_DWORD)v35;
		  v37 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v38 = *(_QWORD *)&v37->x;
		  *(float *)&v37 = v37->z;
		  *(_QWORD *)&v66.m_Center.x = v38;
		  LODWORD(v66.m_Center.z) = (_DWORD)v37;
		  sub_180049BD0(v11, 4LL, &v66);
		  v39 = UnityEngine::Bounds::get_max(&v68.m_Center, v69, 0LL);
		  v40 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v69, 0LL)->y);
		  v41 = UnityEngine::Bounds::get_max(&m_Center, v69, 0LL);
		  v42 = _mm_unpacklo_ps((__m128)LODWORD(v39->x), v40).m128_u64[0];
		  m_Center.z = v41->z;
		  *(_QWORD *)&m_Center.x = v42;
		  v43 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v44 = *(_QWORD *)&v43->x;
		  *(float *)&v43 = v43->z;
		  *(_QWORD *)&v66.m_Center.x = v44;
		  LODWORD(v66.m_Center.z) = (_DWORD)v43;
		  sub_180049BD0(v11, 5LL, &v66);
		  v45 = UnityEngine::Bounds::get_max(&v68.m_Center, v69, 0LL);
		  v46 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v69, 0LL)->y);
		  v47 = UnityEngine::Bounds::get_min(&m_Center, v69, 0LL);
		  v48 = _mm_unpacklo_ps((__m128)LODWORD(v45->x), v46).m128_u64[0];
		  m_Center.z = v47->z;
		  *(_QWORD *)&m_Center.x = v48;
		  v49 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v50 = *(_QWORD *)&v49->x;
		  *(float *)&v49 = v49->z;
		  *(_QWORD *)&v66.m_Center.x = v50;
		  LODWORD(v66.m_Center.z) = (_DWORD)v49;
		  sub_180049BD0(v11, 6LL, &v66);
		  v51 = UnityEngine::Bounds::get_max(&v68.m_Center, v69, 0LL);
		  v52 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v69, 0LL)->y);
		  v53 = UnityEngine::Bounds::get_min(&m_Center, v69, 0LL);
		  v54 = _mm_unpacklo_ps((__m128)LODWORD(v51->x), v52).m128_u64[0];
		  m_Center.z = v53->z;
		  *(_QWORD *)&m_Center.x = v54;
		  v55 = UnityEngine::Transform::TransformPoint(&v68.m_Center, transform, &m_Center, 0LL);
		  v56 = 7LL;
		  v57 = *(_QWORD *)&v55->x;
		  *(float *)&v55 = v55->z;
		  *(_QWORD *)&v66.m_Center.x = v57;
		  LODWORD(v66.m_Center.z) = (_DWORD)v55;
		  sub_180049BD0(v11, 7LL, &v66);
		  memset(v69, 0, 24);
		  sub_180049C60(v11, &v66, 0LL);
		  sub_180049C60(v11, &m_Center, 0LL);
		  v68.m_Center = m_Center;
		  m_Center = v66.m_Center;
		  UnityEngine::Bounds::SetMinMax(v69, &m_Center, &v68.m_Center, 0LL);
		  v58 = *(_QWORD *)&v69[0].m_Extents.y;
		  v59 = 1LL;
		  v60 = *(_OWORD *)&v69[0].m_Center.x;
		  do
		  {
		    sub_180049C60(v11, &v68, v59);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    m_Center = v68.m_Center;
		    *(_OWORD *)&v69[0].m_Center.x = v60;
		    *(_QWORD *)&v69[0].m_Extents.y = v58;
		    v61 = HG::Rendering::Runtime::CSG::Extensions::IncludePoint(&v66, v69, &m_Center, 0LL);
		    ++v59;
		    v58 = *(_QWORD *)&v61->m_Extents.y;
		    v60 = *(_OWORD *)&v61->m_Center.x;
		    --v56;
		  }
		  while ( v56 );
		  *(_OWORD *)&retstr->m_Center.x = v60;
		  *(_QWORD *)&retstr->m_Extents.y = v58;
		  return retstr;
		}
		
		public static void CreatePipelineRTIfNeeded(string name, ref VolumetricPipelineRT rt, int width, int height, RTLifeCycle lifeCycle, RenderTextureFormat format, bool enableMipmap = false /* Metadata: 0x023040ED */) {} // 0x0000000189C5E940-0x0000000189C5EA4C
		public static void ReleasePipelineRT(ref VolumetricPipelineRT rt, bool full) {} // 0x000000018451E730-0x000000018451E770
		public static void UpdateFramingKeywords(CommandBuffer cmd, Material mat, bool enable, EFramingQuality quality) {} // 0x0000000189C60364-0x0000000189C606A0
		// Void UpdateFramingKeywords(CommandBuffer, Material, Boolean, EFramingQuality)
		void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
		        CommandBuffer *cmd,
		        Material *mat,
		        bool enable,
		        EFramingQuality__Enum quality,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Shader *shader; // rbx
		  String *s_FramingQuarter; // r8
		  Shader *v13; // rax
		  String *s_FramingCheckerboard; // r8
		  __int128 v15; // xmm0
		  __int64 v16; // xmm1_8
		  Shader *v17; // rbx
		  String *v18; // r8
		  Shader *v19; // rax
		  String *v20; // r8
		  Shader *v21; // rbx
		  String *v22; // r8
		  Shader *v23; // rax
		  String *v24; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  LocalKeyword keyword; // [rsp+30h] [rbp-50h] BYREF
		  LocalKeyword v29; // [rsp+48h] [rbp-38h] BYREF
		  LocalKeyword v30; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5161, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5161, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71(
		      (ILFixDynamicMethodWrapper_8 *)Patch,
		      (Object *)cmd,
		      (Object *)mat,
		      enable,
		      quality,
		      0LL);
		  }
		  else
		  {
		    if ( !enable )
		    {
		      if ( !mat
		        || (shader = UnityEngine::Material::get_shader(mat, 0LL),
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		            s_FramingQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingQuarter,
		            memset(&v29, 0, sizeof(v29)),
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, shader, s_FramingQuarter, 0LL),
		            keyword = v29,
		            !cmd) )
		      {
		        sub_1800D8260(v10, v9);
		      }
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      v13 = UnityEngine::Material::get_shader(mat, 0LL);
		      s_FramingCheckerboard = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingCheckerboard;
		      memset(&v30, 0, sizeof(v30));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v13, s_FramingCheckerboard, 0LL);
		      v15 = *(_OWORD *)&v30.m_SpaceInfo.m_KeywordSpace;
		      v16 = *(_QWORD *)&v30.m_Index;
		LABEL_16:
		      *(_QWORD *)&keyword.m_Index = v16;
		      *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v15;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      return;
		    }
		    if ( quality )
		    {
		      if ( quality != EFramingQuality__Enum_Quarter )
		        return;
		      if ( !mat
		        || (v21 = UnityEngine::Material::get_shader(mat, 0LL),
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		            v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingQuarter,
		            memset(&v30, 0, sizeof(v30)),
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v21, v22, 0LL),
		            keyword = v30,
		            !cmd) )
		      {
		        sub_1800D8260(v10, v9);
		      }
		      UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		      v23 = UnityEngine::Material::get_shader(mat, 0LL);
		      v24 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingCheckerboard;
		      memset(&v29, 0, sizeof(v29));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, v23, v24, 0LL);
		      v15 = *(_OWORD *)&v29.m_SpaceInfo.m_KeywordSpace;
		      v16 = *(_QWORD *)&v29.m_Index;
		      goto LABEL_16;
		    }
		    if ( !mat
		      || (v17 = UnityEngine::Material::get_shader(mat, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		          v18 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingQuarter,
		          memset(&v30, 0, sizeof(v30)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v17, v18, 0LL),
		          keyword = v30,
		          !cmd) )
		    {
		      sub_1800D8260(v10, v9);
		    }
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v19 = UnityEngine::Material::get_shader(mat, 0LL);
		    v20 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FramingCheckerboard;
		    memset(&v29, 0, sizeof(v29));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, v19, v20, 0LL);
		    keyword = v29;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		  }
		}
		
		public static void UpdateTemporalKeywords(CommandBuffer cmd, Material mat, bool enableMV, bool enableDO) {} // 0x0000000189C60D44-0x0000000189C61410
		// Void UpdateTemporalKeywords(CommandBuffer, Material, Boolean, Boolean)
		void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateTemporalKeywords(
		        CommandBuffer *cmd,
		        Material *mat,
		        bool enableMV,
		        bool enableDO,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Shader *v11; // rbx
		  String *v12; // r8
		  Shader *v13; // rax
		  String *v14; // r8
		  Shader *v15; // rax
		  String *v16; // r8
		  Shader *v17; // rax
		  String *v18; // r8
		  __int128 v19; // xmm0
		  __int64 v20; // xmm1_8
		  Shader *v21; // rbx
		  String *v22; // r8
		  Shader *v23; // rax
		  String *v24; // r8
		  Shader *v25; // rax
		  String *v26; // r8
		  Shader *v27; // rax
		  String *v28; // r8
		  Shader *v29; // rbx
		  String *v30; // r8
		  Shader *v31; // rax
		  String *v32; // r8
		  Shader *v33; // rax
		  String *v34; // r8
		  Shader *shader; // rbx
		  String *s_MergeTAAPassNMVNDO; // r8
		  Shader *v37; // rax
		  String *s_MergeTAAPassEMVNDO; // r8
		  Shader *v39; // rax
		  String *s_MergeTAAPassEMVEDO; // r8
		  Shader *v41; // rax
		  String *s_MergeTAAPassNMVEDO; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  LocalKeyword keyword; // [rsp+38h] [rbp-31h] BYREF
		  LocalKeyword v47; // [rsp+50h] [rbp-19h] BYREF
		  LocalKeyword v48; // [rsp+68h] [rbp-1h] BYREF
		  LocalKeyword v49; // [rsp+80h] [rbp+17h] BYREF
		  LocalKeyword v50; // [rsp+98h] [rbp+2Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5219, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5219, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v45, v44);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1512(Patch, (Object *)cmd, (Object *)mat, enableMV, enableDO, 0LL);
		  }
		  else
		  {
		    if ( enableMV )
		    {
		      if ( enableDO )
		      {
		        if ( !mat
		          || (shader = UnityEngine::Material::get_shader(mat, 0LL),
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		              s_MergeTAAPassNMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVNDO,
		              memset(&v50, 0, sizeof(v50)),
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, shader, s_MergeTAAPassNMVNDO, 0LL),
		              keyword = v50,
		              !cmd) )
		        {
		          sub_1800D8260(v10, v9);
		        }
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		        v37 = UnityEngine::Material::get_shader(mat, 0LL);
		        s_MergeTAAPassEMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVNDO;
		        memset(&v49, 0, sizeof(v49));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v37, s_MergeTAAPassEMVNDO, 0LL);
		        keyword = v49;
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		        v39 = UnityEngine::Material::get_shader(mat, 0LL);
		        s_MergeTAAPassEMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVEDO;
		        memset(&v48, 0, sizeof(v48));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v39, s_MergeTAAPassEMVEDO, 0LL);
		        keyword = v48;
		        UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		      }
		      else
		      {
		        if ( !mat
		          || (v29 = UnityEngine::Material::get_shader(mat, 0LL),
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		              v30 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVNDO,
		              memset(&v50, 0, sizeof(v50)),
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v29, v30, 0LL),
		              keyword = v50,
		              !cmd) )
		        {
		          sub_1800D8260(v10, v9);
		        }
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		        v31 = UnityEngine::Material::get_shader(mat, 0LL);
		        v32 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVNDO;
		        memset(&v49, 0, sizeof(v49));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v31, v32, 0LL);
		        keyword = v49;
		        UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		        v33 = UnityEngine::Material::get_shader(mat, 0LL);
		        v34 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVEDO;
		        memset(&v48, 0, sizeof(v48));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v33, v34, 0LL);
		        keyword = v48;
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      }
		      v41 = UnityEngine::Material::get_shader(mat, 0LL);
		      s_MergeTAAPassNMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVEDO;
		      memset(&v47, 0, sizeof(v47));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v41, s_MergeTAAPassNMVEDO, 0LL);
		      v19 = *(_OWORD *)&v47.m_SpaceInfo.m_KeywordSpace;
		      v20 = *(_QWORD *)&v47.m_Index;
		      goto LABEL_21;
		    }
		    if ( !enableDO )
		    {
		      if ( !mat
		        || (v11 = UnityEngine::Material::get_shader(mat, 0LL),
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		            v12 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVNDO,
		            memset(&v47, 0, sizeof(v47)),
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v11, v12, 0LL),
		            keyword = v47,
		            !cmd) )
		      {
		        sub_1800D8260(v10, v9);
		      }
		      UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		      v13 = UnityEngine::Material::get_shader(mat, 0LL);
		      v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVNDO;
		      memset(&v48, 0, sizeof(v48));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v13, v14, 0LL);
		      keyword = v48;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      v15 = UnityEngine::Material::get_shader(mat, 0LL);
		      v16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVEDO;
		      memset(&v49, 0, sizeof(v49));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v15, v16, 0LL);
		      keyword = v49;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      v17 = UnityEngine::Material::get_shader(mat, 0LL);
		      v18 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVEDO;
		      memset(&v50, 0, sizeof(v50));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v17, v18, 0LL);
		      v19 = *(_OWORD *)&v50.m_SpaceInfo.m_KeywordSpace;
		      v20 = *(_QWORD *)&v50.m_Index;
		LABEL_21:
		      *(_QWORD *)&keyword.m_Index = v20;
		      *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v19;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		      return;
		    }
		    if ( !mat
		      || (v21 = UnityEngine::Material::get_shader(mat, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		          v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVNDO,
		          memset(&v50, 0, sizeof(v50)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v21, v22, 0LL),
		          keyword = v50,
		          !cmd) )
		    {
		      sub_1800D8260(v10, v9);
		    }
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v23 = UnityEngine::Material::get_shader(mat, 0LL);
		    v24 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVNDO;
		    memset(&v49, 0, sizeof(v49));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v23, v24, 0LL);
		    keyword = v49;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v25 = UnityEngine::Material::get_shader(mat, 0LL);
		    v26 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVEDO;
		    memset(&v48, 0, sizeof(v48));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v25, v26, 0LL);
		    keyword = v48;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v27 = UnityEngine::Material::get_shader(mat, 0LL);
		    v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVEDO;
		    memset(&v47, 0, sizeof(v47));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v27, v28, 0LL);
		    keyword = v47;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
		  }
		}
		
		public static void ResetTemporalKeywords(CommandBuffer cmd, Material mat) {} // 0x0000000189C5F2DC-0x0000000189C5F4F8
		// Void ResetTemporalKeywords(CommandBuffer, Material)
		void HG::Rendering::Runtime::VolumetricSDFUtils::ResetTemporalKeywords(
		        CommandBuffer *cmd,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Shader *shader; // rbx
		  String *s_MergeTAAPassNMVNDO; // r8
		  Shader *v9; // rax
		  String *s_MergeTAAPassEMVNDO; // r8
		  Shader *v11; // rax
		  String *s_MergeTAAPassEMVEDO; // r8
		  Shader *v13; // rax
		  String *s_MergeTAAPassNMVEDO; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  LocalKeyword keyword; // [rsp+28h] [rbp-29h] BYREF
		  LocalKeyword v19; // [rsp+40h] [rbp-11h] BYREF
		  LocalKeyword v20; // [rsp+58h] [rbp+7h] BYREF
		  LocalKeyword v21; // [rsp+70h] [rbp+1Fh] BYREF
		  LocalKeyword v22; // [rsp+88h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5162, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5162, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)cmd,
		      (Object *)mat,
		      0LL);
		  }
		  else
		  {
		    if ( !mat
		      || (shader = UnityEngine::Material::get_shader(mat, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		          s_MergeTAAPassNMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVNDO,
		          memset(&v19, 0, sizeof(v19)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, s_MergeTAAPassNMVNDO, 0LL),
		          keyword = v19,
		          !cmd) )
		    {
		      sub_1800D8260(v6, v5);
		    }
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v9 = UnityEngine::Material::get_shader(mat, 0LL);
		    s_MergeTAAPassEMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVNDO;
		    memset(&v20, 0, sizeof(v20));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v20, v9, s_MergeTAAPassEMVNDO, 0LL);
		    keyword = v20;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v11 = UnityEngine::Material::get_shader(mat, 0LL);
		    s_MergeTAAPassEMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassEMVEDO;
		    memset(&v21, 0, sizeof(v21));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v21, v11, s_MergeTAAPassEMVEDO, 0LL);
		    keyword = v21;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		    v13 = UnityEngine::Material::get_shader(mat, 0LL);
		    s_MergeTAAPassNMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_MergeTAAPassNMVEDO;
		    memset(&v22, 0, sizeof(v22));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v22, v13, s_MergeTAAPassNMVEDO, 0LL);
		    keyword = v22;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
		  }
		}
		
	
		// Extension methods
		public static T AddMissingComponent<T>(this GameObject go)
			where T : Component => default;
		[IDTag(1)]
		public static void SetEncodedTexture(this Material mat, string name, VolumetricEncodedTexture tex) {} // 0x0000000189C5F4F8-0x0000000189C5F634
		// Void SetEncodedTexture(Material, String, VolumetricEncodedTexture)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		        Material *mat,
		        String *name,
		        VolumetricEncodedTexture *tex,
		        MethodInfo *method)
		{
		  VolumetricEncodedTexture_PropertyIDPack *EncodedTexIDPack; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int32_t RangeScale; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t namea[4]; // [rsp+30h] [rbp-28h]
		  Vector4 v13; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5310, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5310, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)mat,
		      (Object *)name,
		      (Object *)tex,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
		    EncodedTexIDPack = HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
		                         (VolumetricEncodedTexture_PropertyIDPack *)&v13,
		                         name,
		                         0LL);
		    RangeScale = EncodedTexIDPack->_RangeScale;
		    *(_QWORD *)namea = *(_QWORD *)&EncodedTexIDPack->_Tex;
		    if ( !tex )
		    {
		      if ( mat )
		      {
		        UnityEngine::Material::SetTextureImpl(mat, namea[0], 0LL, 0LL);
		        return;
		      }
		LABEL_8:
		      sub_1800D8260(v9, v8);
		    }
		    if ( !mat )
		      goto LABEL_8;
		    UnityEngine::Material::SetTextureImpl(mat, namea[0], tex->fields.Tex, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    v13 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(&v13, tex, 0LL);
		    UnityEngine::Material::SetVector(mat, namea[1], &v13, 0LL);
		    v13 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(&v13, tex, 0LL);
		    UnityEngine::Material::SetVector(mat, RangeScale, &v13, 0LL);
		  }
		}
		
		[IDTag(0)]
		public static void SetEncodedTexture(this MaterialPropertyBlock block, string name, VolumetricEncodedTexture tex) {} // 0x0000000189C5F634-0x0000000189C5F7D4
		// Void SetEncodedTexture(MaterialPropertyBlock, String, VolumetricEncodedTexture)
		void HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		        MaterialPropertyBlock *block,
		        String *name,
		        VolumetricEncodedTexture *tex,
		        MethodInfo *method)
		{
		  VolumetricEncodedTexture_PropertyIDPack *EncodedTexIDPack; // rax
		  int32_t RangeScale; // r14d
		  Object_1 *v9; // rbx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Texture *blackTexture3D; // rax
		  TileBase *v13; // rdx
		  Vector3Int *v14; // r8
		  ITilemap *v15; // r9
		  MethodInfo *v16; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v18; // [rsp+20h] [rbp-30h]
		  int32_t namea[4]; // [rsp+30h] [rbp-20h]
		  Vector4 v20; // [rsp+40h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5113, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
		    EncodedTexIDPack = HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
		                         (VolumetricEncodedTexture_PropertyIDPack *)&v20,
		                         name,
		                         0LL);
		    RangeScale = EncodedTexIDPack->_RangeScale;
		    *(_QWORD *)namea = *(_QWORD *)&EncodedTexIDPack->_Tex;
		    if ( tex
		      && (v9 = (Object_1 *)tex->fields.Tex,
		          sub_1800036A0(TypeInfo::UnityEngine::Object),
		          UnityEngine::Object::op_Implicit(v9, 0LL)) )
		    {
		      if ( block )
		      {
		        UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(block, namea[0], tex->fields.Tex, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        v20 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(&v20, tex, 0LL);
		        UnityEngine::MaterialPropertyBlock::SetVector(block, namea[1], &v20, 0LL);
		        v20 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(&v20, tex, 0LL);
		LABEL_6:
		        UnityEngine::MaterialPropertyBlock::SetVector(block, RangeScale, &v20, 0LL);
		        return;
		      }
		    }
		    else
		    {
		      blackTexture3D = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		      if ( block )
		      {
		        UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(block, namea[0], blackTexture3D, 0LL);
		        v20 = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                          (TileAnimationData *)&v20,
		                          v13,
		                          v14,
		                          v15,
		                          v18);
		        UnityEngine::MaterialPropertyBlock::SetVector(block, namea[1], &v20, 0LL);
		        v20 = *UnityEngine::Vector4::get_one(&v20, v16);
		        goto LABEL_6;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v11, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5113, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)block,
		    (Object *)name,
		    (Object *)tex,
		    0LL);
		}
		
		public static Texture GetTexture(this VolumetricEncodedTexture et) => default; // 0x0000000183C52E20-0x0000000183C52E50
		// Texture GetTexture(VolumetricEncodedTexture)
		Texture *HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(VolumetricEncodedTexture *et, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5045, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5045, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(Patch, (Object *)et, 0LL);
		  }
		  else if ( et )
		  {
		    return et->fields.Tex;
		  }
		  else
		  {
		    return 0LL;
		  }
		}
		
		public static Vector4 GetRangeBase(this VolumetricEncodedTexture et) => default; // 0x0000000189C5EF24-0x0000000189C5EFA4
		// Vector4 GetRangeBase(VolumetricEncodedTexture)
		Vector4 *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
		        Vector4 *__return_ptr retstr,
		        VolumetricEncodedTexture *et,
		        MethodInfo *method)
		{
		  TileBase *v5; // rdx
		  Vector3Int *v6; // r8
		  ITilemap *v7; // r9
		  Vector4 RangeBase; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5115, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5115, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    RangeBase = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v13, Patch, (Object *)et, 0LL);
		    goto LABEL_8;
		  }
		  if ( et )
		  {
		    RangeBase = et->fields.RangeBase;
		LABEL_8:
		    *retstr = RangeBase;
		    return retstr;
		  }
		  *retstr = *(Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                          (TileAnimationData *)&v13,
		                          v5,
		                          v6,
		                          v7,
		                          *(MethodInfo **)&v13.x);
		  return retstr;
		}
		
		public static Vector4 GetRangeScale(this VolumetricEncodedTexture et) => default; // 0x0000000189C5EFA4-0x0000000189C5F024
		// Vector4 GetRangeScale(VolumetricEncodedTexture)
		Vector4 *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
		        Vector4 *__return_ptr retstr,
		        VolumetricEncodedTexture *et,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // rdx
		  Vector4 RangeScale; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5116, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5116, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    RangeScale = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v11, Patch, (Object *)et, 0LL);
		    goto LABEL_8;
		  }
		  if ( et )
		  {
		    RangeScale = et->fields.RangeScale;
		LABEL_8:
		    *retstr = RangeScale;
		    return retstr;
		  }
		  *retstr = *UnityEngine::Vector4::get_one(&v11, v5);
		  return retstr;
		}
		
	}
}
