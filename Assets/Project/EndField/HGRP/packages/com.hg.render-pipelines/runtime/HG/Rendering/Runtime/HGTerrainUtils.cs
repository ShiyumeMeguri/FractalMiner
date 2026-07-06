using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGTerrainUtils
	{
		[IDTag(0)]
		public static string JoinPath(string path0, string path1)
		{
			// // String JoinPath(String, String)
			// String *HG::Rendering::Runtime::HGTerrainUtils::JoinPath(String *path0, String *path1, MethodInfo *method)
			// {
			//   ReadOnlySpan_1_Char_ v5; // xmm7
			//   ReadOnlySpan_1_Char_ v6; // xmm6
			//   String *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   String *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ReadOnlySpan_1_Char_ v13; // [rsp+20h] [rbp-48h] BYREF
			//   ReadOnlySpan_1_Char_ v14; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D91971D )
			//   {
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     byte_18D91971D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3405, 0LL) )
			//   {
			//     v5 = *(ReadOnlySpan_1_Char_ *)sub_182376EB0(&v14, path0);
			//     v6 = *(ReadOnlySpan_1_Char_ *)sub_182376EB0(&v14, path1);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     v13 = v6;
			//     v14 = v5;
			//     v7 = System::IO::Path::Join(&v14, &v13, 0LL);
			//     if ( v7 )
			//     {
			//       v10 = System::String::Replace(v7, 0x5Cu, 0x2Fu, 0LL);
			//       if ( v10 )
			//         return System::String::TrimEnd(v10, 0x2Fu, 0LL);
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3405, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)path0, (Object *)path1, 0LL);
			// }
			// 
			return null;
		}

		public static string GenSubTerrainName(int index)
		{
			// // String GenSubTerrainName(Int32)
			// String *HG::Rendering::Runtime::HGTerrainUtils::GenSubTerrainName(int32_t index, MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   Object *v4; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t v9; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D91971E )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&off_18D5156D8);
			//     byte_18D91971E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3406, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3406, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1213(Patch, index, 0LL);
			//   }
			//   else
			//   {
			//     v9 = index;
			//     v4 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v9, v3);
			//     return System::String::Format((String *)"Sub Terrain {0}", v4, 0LL);
			//   }
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static string JoinPath(string path0, string path1, string path2)
		{
			// // String JoinPath(String, String, String)
			// String *HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
			//         String *path0,
			//         String *path1,
			//         String *path2,
			//         MethodInfo *method)
			// {
			//   ReadOnlySpan_1_Char_ v7; // xmm8
			//   ReadOnlySpan_1_Char_ v8; // xmm7
			//   ReadOnlySpan_1_Char_ v9; // xmm6
			//   String *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   String *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ReadOnlySpan_1_Char_ v16; // [rsp+30h] [rbp-68h] BYREF
			//   ReadOnlySpan_1_Char_ v17; // [rsp+40h] [rbp-58h] BYREF
			//   ReadOnlySpan_1_Char_ v18[2]; // [rsp+50h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D91971F )
			//   {
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     byte_18D91971F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3407, 0LL) )
			//   {
			//     v7 = *(ReadOnlySpan_1_Char_ *)sub_182376EB0(v18, path0);
			//     v8 = *(ReadOnlySpan_1_Char_ *)sub_182376EB0(v18, path1);
			//     v9 = *(ReadOnlySpan_1_Char_ *)sub_182376EB0(v18, path2);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     v16 = v9;
			//     v17 = v8;
			//     v18[0] = v7;
			//     v10 = System::IO::Path::Join(v18, &v17, &v16, 0LL);
			//     if ( v10 )
			//     {
			//       v13 = System::String::Replace(v10, 0x5Cu, 0x2Fu, 0LL);
			//       if ( v13 )
			//         return System::String::TrimEnd(v13, 0x2Fu, 0LL);
			//     }
			// LABEL_8:
			//     sub_180B536AC(v12, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3407, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1214(Patch, (Object *)path0, (Object *)path1, (Object *)path2, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static string GetCurrentSceneResourcePath(Terrain terrain = null)
		{
			// // String GetCurrentSceneResourcePath(Terrain)
			// String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentSceneResourcePath(Terrain *terrain, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Scene v5; // eax
			//   GameObject *gameObject; // rax
			//   int32_t m_Handle; // ebx
			//   String *v8; // rdi
			//   String *PathInternal; // rax
			//   String *v10; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919720 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919720 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3408, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3408, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)terrain, 0LL);
			//     goto LABEL_13;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
			//   {
			//     if ( terrain )
			//     {
			//       gameObject = UnityEngine::Component::get_gameObject((Component *)terrain, 0LL);
			//       if ( gameObject )
			//       {
			//         v5.m_Handle = UnityEngine::GameObject::get_scene(gameObject, 0LL).m_Handle;
			//         goto LABEL_9;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v4, v3);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//   v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
			// LABEL_9:
			//   m_Handle = v5.m_Handle;
			//   v8 = (String *)"";
			//   PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
			//   if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
			//   {
			//     v10 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     return System::IO::Path::GetDirectoryName(v10, 0LL);
			//   }
			//   return v8;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static string GetCurrentSceneResourcePath(GameObject gameObject)
		{
			// // String GetCurrentSceneResourcePath(GameObject)
			// String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentSceneResourcePath(GameObject *gameObject, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Scene v5; // eax
			//   int32_t m_Handle; // ebx
			//   String *v7; // rdi
			//   String *PathInternal; // rax
			//   String *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919721 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919721 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3409, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3409, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)gameObject, 0LL);
			//     goto LABEL_12;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)gameObject, 0LL, 0LL) )
			//   {
			//     if ( gameObject )
			//     {
			//       v5.m_Handle = UnityEngine::GameObject::get_scene(gameObject, 0LL).m_Handle;
			//       goto LABEL_8;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v4, v3);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//   v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
			// LABEL_8:
			//   m_Handle = v5.m_Handle;
			//   v7 = (String *)"";
			//   PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
			//   if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
			//   {
			//     v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     return System::IO::Path::GetDirectoryName(v9, 0LL);
			//   }
			//   return v7;
			// }
			// 
			return null;
		}

		public static string GetCurrentTerrainResourcesPath(GameObject terrain = null)
		{
			// // String GetCurrentTerrainResourcesPath(GameObject)
			// String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentTerrainResourcesPath(GameObject *terrain, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Scene v5; // eax
			//   int32_t m_Handle; // ebx
			//   String *v7; // rdi
			//   String *PathInternal; // rax
			//   String *v9; // rbx
			//   String *DirectoryName; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919722 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     sub_18003C530(&off_18D5156E0);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919722 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3410, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3410, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)terrain, 0LL);
			//     goto LABEL_12;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
			//   {
			//     if ( terrain )
			//     {
			//       v5.m_Handle = UnityEngine::GameObject::get_scene(terrain, 0LL).m_Handle;
			//       goto LABEL_8;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v4, v3);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//   v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
			// LABEL_8:
			//   m_Handle = v5.m_Handle;
			//   v7 = (String *)"";
			//   PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
			//   if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
			//   {
			//     v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     DirectoryName = System::IO::Path::GetDirectoryName(v9, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
			//              DirectoryName,
			//              (String *)"Terrain/HGTerrainRuntimeResources.asset",
			//              0LL);
			//   }
			//   return v7;
			// }
			// 
			return null;
		}

		public static string GetCurrentTerrainConfigurationPath(GameObject terrain = null)
		{
			// // String GetCurrentTerrainConfigurationPath(GameObject)
			// String *HG::Rendering::Runtime::HGTerrainUtils::GetCurrentTerrainConfigurationPath(
			//         GameObject *terrain,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Scene v5; // eax
			//   int32_t m_Handle; // ebx
			//   String *v7; // rdi
			//   String *PathInternal; // rax
			//   String *v9; // rbx
			//   String *DirectoryName; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919723 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::IO::Path);
			//     sub_18003C530(&TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//     sub_18003C530(&off_18D515708);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919723 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3411, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3411, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)terrain, 0LL);
			//     goto LABEL_12;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)terrain, 0LL, 0LL) )
			//   {
			//     if ( terrain )
			//     {
			//       v5.m_Handle = UnityEngine::GameObject::get_scene(terrain, 0LL).m_Handle;
			//       goto LABEL_8;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v4, v3);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::SceneManagement::SceneManager);
			//   v5.m_Handle = UnityEngine::SceneManagement::SceneManager::GetActiveScene(0LL).m_Handle;
			// LABEL_8:
			//   m_Handle = v5.m_Handle;
			//   v7 = (String *)"";
			//   PathInternal = UnityEngine::SceneManagement::Scene::GetPathInternal(v5.m_Handle, 0LL);
			//   if ( System::String::op_Inequality(PathInternal, (String *)"", 0LL) )
			//   {
			//     v9 = UnityEngine::SceneManagement::Scene::GetPathInternal(m_Handle, 0LL);
			//     sub_180002C70(TypeInfo::System::IO::Path);
			//     DirectoryName = System::IO::Path::GetDirectoryName(v9, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(
			//              DirectoryName,
			//              (String *)"Terrain/HGTerrainConfiguration.asset",
			//              0LL);
			//   }
			//   return v7;
			// }
			// 
			return null;
		}

		public static string GetHGRenderPipelinePath()
		{
			// // String GetHGRenderPipelinePath()
			// String *HG::Rendering::Runtime::HGTerrainUtils::GetHGRenderPipelinePath(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !byte_18D919724 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919724 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3412, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3412, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v4, v3);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     return HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(0LL);
			//   }
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static int Pow(this int bas, int exp)
		{
			return 0;
		}

		[IDTag(1)]
		public static float Pow(this float bas, int exp)
		{
			// // Single Pow(Single, Int32)
			// float HG::Rendering::Runtime::HGTerrainUtils::Pow(float bas, int32_t exp, MethodInfo *method)
			// {
			//   IEnumerable_1_System_Single_ *v4; // rsi
			//   Func_3_Single_Single_Single_ *_9__32_0; // rbx
			//   Object *v6; // rdi
			//   Func_3_Single_Single_Single_ *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v15; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v16; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D919726 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Aggregate<float,float>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Repeat<float>);
			//     sub_18003C530(&TypeInfo::System::Func<float,float,float>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::__c::_Pow_b__32_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
			//     byte_18D919726 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3413, 0LL) )
			//   {
			//     v4 = System::Linq::Enumerable::Repeat<float>(bas, exp, MethodInfo::System::Linq::Enumerable::Repeat<float>);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
			//     _9__32_0 = TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c.static_fields.__9__32_0;
			//     if ( _9__32_0 )
			//       return System::Linq::Enumerable::Aggregate<float,float>(
			//                v4,
			//                1.0,
			//                _9__32_0,
			//                MethodInfo::System::Linq::Enumerable::Aggregate<float,float>);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c);
			//     v6 = (Object *)TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c.static_fields.__9;
			//     v7 = (Func_3_Single_Single_Single_ *)sub_180004920(TypeInfo::System::Func<float,float,float>);
			//     _9__32_0 = v7;
			//     if ( v7 )
			//     {
			//       System::Func<float,float,float>::Func(
			//         v7,
			//         v6,
			//         MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::__c::_Pow_b__32_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c.static_fields.__9__32_0 = _9__32_0;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils::__c.static_fields.__9__32_0,
			//         v10,
			//         v11,
			//         v12,
			//         v15,
			//         v16);
			//       return System::Linq::Enumerable::Aggregate<float,float>(
			//                v4,
			//                1.0,
			//                _9__32_0,
			//                MethodInfo::System::Linq::Enumerable::Aggregate<float,float>);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3413, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1215(Patch, bas, exp, 0LL);
			// }
			// 
			return 0f;
		}

		public static void MultidimensionalSpanFillBool(bool[,] array, bool value)
		{
			// // Void MultidimensionalSpanFillBool(Boolean[,], Boolean)
			// void HG::Rendering::Runtime::HGTerrainUtils::MultidimensionalSpanFillBool(
			//         Boolean__Array_1 *array,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int Length; // esi
			//   int v8; // eax
			//   __int64 v9; // rdx
			//   Il2CppArrayBounds *bounds; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Span_1_SByte_ v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919727 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Span<bool>::Fill);
			//     sub_18003C530(&MethodInfo::System::Span<bool>::Span);
			//     byte_18D919727 = 1;
			//   }
			//   v12 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3414, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3414, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)array, value, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !array )
			//     goto LABEL_10;
			//   Length = System::Array::GetLength((System::Array *)array, 0);
			//   v8 = System::Array::GetLength((System::Array *)array, 1);
			//   bounds = array.bounds;
			//   if ( !LODWORD(bounds.length) || !LODWORD(bounds[1].length) )
			//     sub_180070270(bounds, v9);
			//   ((void (__fastcall *)(Span_1_SByte_ *, bool *, _QWORD, struct MethodInfo *))sub_18867FF3C)(
			//     &v12,
			//     array.vector,
			//     (unsigned int)(Length * v8),
			//     MethodInfo::System::Span<bool>::Span);
			//   System::Span<signed char>::Fill(&v12, value, MethodInfo::System::Span<bool>::Fill);
			// }
			// 
		}

		public static float DegreeToRadian(float degree)
		{
			// // Single DegreeToRadian(Single)
			// float HG::Rendering::Runtime::HGTerrainUtils::DegreeToRadian(float degree, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3361, 0LL) )
			//     return (float)(degree / 180.0) * 3.1415927;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3361, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, degree, 0LL);
			// }
			// 
			return 0f;
		}

		public static int PackLinearColor(Color color)
		{
			// // Int32 PackLinearColor(Color)
			// int32_t HG::Rendering::Runtime::HGTerrainUtils::PackLinearColor(Color *color, MethodInfo *method)
			// {
			//   double v3; // xmm0_8
			//   float v4; // xmm9_4
			//   double v5; // xmm0_8
			//   float v6; // xmm8_4
			//   double v7; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Color v12; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3415, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3415, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = *color;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1216(Patch, &v12, 0LL);
			//   }
			//   else
			//   {
			//     v3 = ((double (*)(void))sub_180040FE0)();
			//     v4 = *(float *)&v3;
			//     v5 = ((double (*)(void))sub_180040FE0)();
			//     v6 = *(float *)&v5;
			//     v7 = ((double (*)(void))sub_180040FE0)();
			//     return (unsigned __int8)(int)v4 | (((unsigned __int8)(int)v6 | ((((int)sub_180040FE0() << 8) | (unsigned __int8)(int)*(float *)&v7) << 8)) << 8);
			//   }
			// }
			// 
			return 0;
		}

		public static Vector3 ScreenPointToRay(Transform transform, float fov, int x, int y, int screenX, int screenY)
		{
			// // Vector3 ScreenPointToRay(Transform, Single, Int32, Int32, Int32, Int32)
			// Vector3 *HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
			//         Vector3 *__return_ptr retstr,
			//         Transform *transform,
			//         float fov,
			//         int32_t x,
			//         int32_t y,
			//         int32_t screenX,
			//         int32_t screenY,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // r8
			//   __int64 v14; // r9
			//   float v15; // xmm0_4
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v18; // rcx
			//   Vector3 *v19; // rax
			//   __int64 v20; // xmm0_8
			//   float z; // eax
			//   Vector3 v23; // [rsp+50h] [rbp-30h] BYREF
			//   Vector3 v24; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919728 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     byte_18D919728 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3360, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3360, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1193(
			//               &v24,
			//               Patch,
			//               (Object *)transform,
			//               fov,
			//               x,
			//               y,
			//               screenX,
			//               screenY,
			//               0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v18, Patch);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//   HG::Rendering::Runtime::HGTerrainUtils::DegreeToRadian(fov, 0LL);
			//   v15 = sub_1802ED290(v12, v11, v13, v14);
			//   v23.z = 1.0;
			//   v23.x = (float)((float)((float)((float)x + (float)x) - (float)screenX) * v15) / (float)screenY;
			//   v23.y = (float)((float)((float)((float)y + (float)y) - (float)screenY) * (float)-v15) / (float)screenY;
			//   sub_182411EE0(&v23, v16);
			//   if ( !transform )
			//     goto LABEL_7;
			//   v24 = v23;
			//   v19 = UnityEngine::Transform::TransformVector(&v23, transform, &v24, 0LL);
			// LABEL_9:
			//   v20 = *(_QWORD *)&v19.x;
			//   z = v19.z;
			//   *(_QWORD *)&retstr.x = v20;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static string FromGuidToTextureFullPath(string rootPath, in Guid guid)
		{
			// // String FromGuidToTextureFullPath(String, Guid ByRef)
			// String *HG::Rendering::Runtime::HGTerrainUtils::FromGuidToTextureFullPath(
			//         String *rootPath,
			//         Guid *guid,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   Object *v6; // rax
			//   String *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Guid v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919729 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Guid);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&off_18D515648);
			//     byte_18D919729 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3416, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3416, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1217(Patch, (Object *)rootPath, guid, 0LL);
			//   }
			//   else
			//   {
			//     v12 = *guid;
			//     v6 = (Object *)il2cpp_value_box_0(TypeInfo::System::Guid, &v12, v5);
			//     v7 = System::String::Format((String *)"{0}.tga", v6, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     return HG::Rendering::Runtime::HGTerrainUtils::JoinPath(rootPath, v7, 0LL);
			//   }
			// }
			// 
			return null;
		}

		public static int GetTerrainDecalMaxLevel(int indirectMaxLevel)
		{
			// // Int32 GetTerrainDecalMaxLevel(Int32)
			// int32_t HG::Rendering::Runtime::HGTerrainUtils::GetTerrainDecalMaxLevel(int32_t indirectMaxLevel, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3417, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3417, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, indirectMaxLevel, 0LL);
			//   }
			//   else
			//   {
			//     if ( indirectMaxLevel >= 8 )
			//       return 8;
			//     return indirectMaxLevel;
			//   }
			// }
			// 
			return 0;
		}

		public static bool SupportBufferToImageCopy()
		{
			// // Boolean SupportBufferToImageCopy()
			// bool HG::Rendering::Runtime::HGTerrainUtils::SupportBufferToImageCopy(MethodInfo *method)
			// {
			//   GraphicsDeviceType__Enum GraphicsDeviceType; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3418, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3418, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
			//     return GraphicsDeviceType == GraphicsDeviceType__Enum_Vulkan || GraphicsDeviceType == GraphicsDeviceType__Enum_Metal;
			//   }
			// }
			// 
			return default(bool);
		}

		public static bool ForceUsingCompression()
		{
			// // Boolean ForceUsingCompression()
			// bool HG::Rendering::Runtime::HGTerrainUtils::ForceUsingCompression(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3419, 0LL) )
			//     return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Metal;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3419, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool SupportSSBOWriteInGraphicShader()
		{
			// // Boolean SupportSSBOWriteInGraphicShader()
			// bool HG::Rendering::Runtime::HGTerrainUtils::SupportSSBOWriteInGraphicShader(MethodInfo *method)
			// {
			//   GraphicsDeviceType__Enum GraphicsDeviceType; // eax
			//   int v2; // ecx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3420, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3420, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
			//     result = (unsigned int)GraphicsDeviceType <= GraphicsDeviceType__Enum_Vulkan
			//           && (v2 = 2424836, _bittest(&v2, GraphicsDeviceType))
			//           && UnityEngine::SystemInfo::SupportedRandomWriteTargetCount(0LL) > 0;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public static GraphicsFormat GetPlatformCompressionFormat()
		{
			// // GraphicsFormat GetPlatformCompressionFormat()
			// GraphicsFormat__Enum HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat(MethodInfo *method)
			// {
			//   RuntimePlatform__Enum platform; // eax
			//   __int64 v2; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   InvalidEnumArgumentException *v5; // rbx
			//   String *v6; // rax
			//   __int64 v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3355, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3355, 0LL);
			//     if ( !Patch )
			//       goto LABEL_16;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     platform = UnityEngine::Application::get_platform(0LL);
			//     if ( (unsigned int)platform >= RuntimePlatform__Enum_WindowsPlayer )
			//     {
			//       switch ( platform )
			//       {
			//         case RuntimePlatform__Enum_WindowsPlayer:
			//           return 101;
			//         case RuntimePlatform__Enum_OSXWebPlayer:
			//         case RuntimePlatform__Enum_OSXDashboardPlayer:
			//         case RuntimePlatform__Enum_WindowsWebPlayer:
			//         case RuntimePlatform__Enum_OSXDashboardPlayer|RuntimePlatform__Enum_WindowsPlayer:
			//           goto LABEL_11;
			//         case RuntimePlatform__Enum_WindowsEditor:
			//           return 101;
			//       }
			//       if ( platform != RuntimePlatform__Enum_IPhonePlayer && platform != RuntimePlatform__Enum_Android )
			//       {
			// LABEL_11:
			//         v2 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//         v5 = (InvalidEnumArgumentException *)sub_180004920(v2);
			//         if ( v5 )
			//         {
			//           v6 = (String *)sub_18000F7E0(&off_18D515678);
			//           System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v5, v6, 0LL);
			//           v7 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat);
			//           sub_18000F7C0(v5, v7);
			//         }
			// LABEL_16:
			//         sub_180B536AC(v4, v3);
			//       }
			//     }
			//     return 130;
			//   }
			// }
			// 
			return (GraphicsFormat)GraphicsFormat.None;
		}

		public static Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
		{
			// // Matrix4x4 PerspectiveOffCenter(Single, Single, Single, Single, Single, Single)
			// Matrix4x4 *HG::Rendering::Runtime::HGTerrainUtils::PerspectiveOffCenter(
			//         Matrix4x4 *__return_ptr retstr,
			//         float left,
			//         float right,
			//         float bottom,
			//         float top,
			//         float near_1,
			//         float far_1,
			//         MethodInfo *method)
			// {
			//   float v10; // xmm8_4
			//   float v11; // xmm6_4
			//   float v12; // xmm7_4
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Matrix4x4 *v19; // rax
			//   __int128 v20; // xmm1
			//   Matrix4x4 *result; // rax
			//   Matrix4x4 v22; // [rsp+58h] [rbp-79h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3393, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3393, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1204(&v22, Patch, left, right, bottom, top, near_1, far_1, 0LL);
			//     v20 = *(_OWORD *)&v19.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v19.m00;
			//     v14 = *(_OWORD *)&v19.m02;
			//     *(_OWORD *)&retstr.m01 = v20;
			//     v15 = *(_OWORD *)&v19.m03;
			//   }
			//   else
			//   {
			//     v10 = 1.0 / (float)(near_1 - far_1);
			//     v11 = 1.0 / (float)(right - left);
			//     v12 = 1.0 / (float)(top - bottom);
			//     sub_1802F01E0(&v22, 0LL, 64LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 0, (float)(near_1 + near_1) * v11, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 8, (float)(left + right) * v11, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 5, (float)(near_1 + near_1) * v12, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 9, (float)(bottom + top) * v12, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 10, (float)(near_1 + far_1) * v10, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 14, (float)((float)(near_1 + near_1) * far_1) * v10, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&v22, 11, -1.0, 0LL);
			//     v13 = *(_OWORD *)&v22.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v22.m00;
			//     v14 = *(_OWORD *)&v22.m02;
			//     *(_OWORD *)&retstr.m01 = v13;
			//     v15 = *(_OWORD *)&v22.m03;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v14;
			//   *(_OWORD *)&retstr.m03 = v15;
			//   return result;
			// }
			// 
			return null;
		}

		public static void RemoveComponentTerrainUtils<T>(this GameObject obj) where T : Component
		{
		}

		public static bool ShouldDisableContactShadow()
		{
			// // Boolean ShouldDisableContactShadow()
			// bool HG::Rendering::Runtime::HGTerrainUtils::ShouldDisableContactShadow(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 *v4; // rax
			//   __int128 *v5; // rcx
			//   __int64 v6; // rdx
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v17[272]; // [rsp+20h] [rbp-228h] BYREF
			//   _BYTE v18[280]; // [rsp+130h] [rbp-118h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v1);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v2.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray.max_length.size > 918 )
			//   {
			//     if ( !v2._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v2, wrapperArray);
			//       v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2.static_fields.wrapperArray;
			//     if ( v2 )
			//     {
			//       if ( LODWORD(v2._0.namespaze) <= 0x396 )
			//         sub_180070270(v2, wrapperArray);
			//       if ( !v2[19]._1.cctor_thread )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(918, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//     }
			// LABEL_10:
			//     sub_180B536AC(v2, wrapperArray);
			//   }
			// LABEL_7:
			//   v4 = (__int128 *)sub_182C50540(v18);
			//   v5 = (__int128 *)v17;
			//   v6 = 2LL;
			//   do
			//   {
			//     v5 += 8;
			//     v7 = *v4;
			//     v8 = v4[1];
			//     v4 += 8;
			//     *(v5 - 8) = v7;
			//     v9 = *(v4 - 6);
			//     *(v5 - 7) = v8;
			//     v10 = *(v4 - 5);
			//     *(v5 - 6) = v9;
			//     v11 = *(v4 - 4);
			//     *(v5 - 5) = v10;
			//     v12 = *(v4 - 3);
			//     *(v5 - 4) = v11;
			//     v13 = *(v4 - 2);
			//     *(v5 - 3) = v12;
			//     v14 = *(v4 - 1);
			//     *(v5 - 2) = v13;
			//     *(v5 - 1) = v14;
			//     --v6;
			//   }
			//   while ( v6 );
			//   *v5 = *v4;
			//   return v17[248];
			// }
			// 
			return default(bool);
		}

		public const int TERRAIN_LAYER_TEX_RESOLUTION = 1024;

		public const int TERRAIN_DECAL_TEXTURE_RESOLUTION = 512;

		public const int TERRAIN_DECAL_MAX_PER_PAGE = 256;

		public const int TERRAIN_DECAL_MAX_PER_BLOCK = 16;

		public const int TERRAIN_DECAL_ACQUISITION_OFFSET = 2;

		private const int TERRAIN_DECAL_MAX_ALLOWED_LEVEL = 8;

		public const int TERRAIN_WETNESS_THRESHOLD = 130;

		private const string TERRAIN_RUNTIME_RESOURCE_PATH = "Terrain/HGTerrainRuntimeResources.asset";

		private const string TERRAIN_CONFIGURATION_PATH = "Terrain/HGTerrainConfiguration.asset";

		public const string TERRAIN_HEIGHTMAP_RESOURCE_PATH = "Terrain/Heightmap.asset";

		public const string TERRAIN_LIT_MATERIAL_PATH = "Terrain/HGTerrainLitMaterial.mat";

		public const string TERRAIN_ROOT_FOLDER_NAME = "Terrain";

		public const string TERRAIN_INTERMEDIATE_SO_NAME = "[x]HGTerrainDataWithPosObject.asset";

		public const string TERRAIN_LAYER_NAME = "Terrain";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int TERRAIN_LAYER_INDEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static readonly int TERRAIN_LAYER_MASK;

		public const int TERRAIN_SPLAT_MAX_ALPHAMAP_COUNT = 16;

		public const int TERRAIN_SPLAT_MAX_LAYER_COUNT = 64;

		public const int TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_PC = 32;

		public const int TERRAIN_SPLAT_TEX_ARRAY_SLICE_COUNT_MOBILE = 24;

		public const int AVERAGE_COLOR_CALCULATION_ARRAY_LENGTH = 16;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct Vector2Short
		{
			public short x;

			public short y;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		public struct Vector2UInt
		{
			public Vector2UInt(uint x, uint y)
			{
				// // ValueTuple`2[UInt32,Int32](UInt32, Int32)
				// void System::ValueTuple<unsigned int,int>::ValueTuple(
				//         ValueTuple_2_UInt32_Int32_ *this,
				//         uint32_t item1,
				//         int32_t item2,
				//         MethodInfo *method)
				// {
				//   this.Item1 = item1;
				//   this.Item2 = item2;
				// }
				// 
			}

			public uint x;

			public uint y;
		}
	}
}
