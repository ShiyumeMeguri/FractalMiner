using System;
using IFix.Core;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGInitGraphicsAPIUtils
	{
		public static bool LoadOptionsFromFile(out HGInitGraphicsAPIOptions options)
		{
			// // Boolean LoadOptionsFromFile(HGInitGraphicsAPIOptions ByRef)
			// bool HG::Rendering::Runtime::HGInitGraphicsAPIUtils::LoadOptionsFromFile(
			//         HGInitGraphicsAPIOptions **options,
			//         MethodInfo *method)
			// {
			//   HGInitGraphicsAPIOptions *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   HGInitGraphicsAPIOptions *v5; // rcx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   String *persistentDataPath; // rax
			//   String *v10; // rdi
			//   String *v11; // rax
			//   String *v12; // rbx
			//   String *AllText; // rax
			//   String *v14; // rdi
			//   bool v15; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v17; // [rsp+20h] [rbp-18h]
			//   String *v18; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v19; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDBA0 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     sub_18003C530(&off_18C9106C0);
			//     sub_18003C530(&off_18C9106D0);
			//     sub_18003C530(&off_18C9106E0);
			//     sub_18003C530(&off_18C9106F0);
			//     sub_18003C530(&off_18C910710);
			//     sub_18003C530(&off_18C920FB8);
			//     sub_18003C530(&off_18C910718);
			//     sub_18003C530(&off_18C9086F8);
			//     byte_18D8EDBA0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3512, 0LL) )
			//   {
			//     v3 = (HGInitGraphicsAPIOptions *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     if ( v3 )
			//     {
			//       v3.fields.m_preferredDeviceType = 4;
			//       v3.fields.m_renderPath = 3;
			//       *options = v3;
			//       sub_1800054D0((OneofDescriptor *)options, v4, v6, v7, v17, v18, v19);
			//       if ( UnityEngine::Application::get_platform(0LL) != RuntimePlatform__Enum_Android )
			//         return 0;
			//       persistentDataPath = UnityEngine::Application::get_persistentDataPath(0LL);
			//       v10 = System::String::Concat(persistentDataPath, (String *)"/Graphics/GraphicsApiSettings.txt", 0LL);
			//       if ( !System::IO::File::Exists(v10, 0LL) )
			//       {
			//         v11 = UnityEngine::Application::get_persistentDataPath(0LL);
			//         v12 = System::String::Concat(v11, (String *)"/Graphics", 0LL);
			//         if ( !System::IO::Directory::Exists(v12, 0LL) )
			//           System::IO::Directory::CreateDirectory(v12, 0LL);
			//         System::IO::File::Create(v10, 4096, 0LL);
			//         System::IO::File::WriteAllText(v10, (String *)"Auto", 0LL);
			//         return 0;
			//       }
			//       AllText = System::IO::File::ReadAllText(v10, 0LL);
			//       v14 = AllText;
			//       if ( AllText )
			//       {
			//         if ( System::String::Contains(AllText, (String *)"Auto", 0LL) )
			//         {
			//           if ( !*options )
			//             goto LABEL_7;
			//           (*options).fields.m_preferredDeviceType = 4;
			//         }
			//         else if ( System::String::Contains(v14, (String *)"Vulkan", 0LL) )
			//         {
			//           if ( !*options )
			//             goto LABEL_7;
			//           (*options).fields.m_preferredDeviceType = 21;
			//         }
			//         else
			//         {
			//           if ( !System::String::Contains(v14, (String *)"GLES3", 0LL) )
			//           {
			//             HG::Rendering::HGRPLogger::LogWarning((String *)"Missing graphics type data in GraphicsApiSettings.", 0LL);
			//             return 0;
			//           }
			//           if ( !*options )
			//             goto LABEL_7;
			//           (*options).fields.m_preferredDeviceType = 11;
			//         }
			//         if ( System::String::Contains(v14, (String *)"DefaultDeferred", 0LL) )
			//         {
			//           if ( *options )
			//           {
			//             (*options).fields.m_forceRenderPath = 1;
			//             if ( *options )
			//             {
			//               (*options).fields.m_renderPath = 3;
			//               return 1;
			//             }
			//           }
			//         }
			//         else
			//         {
			//           v15 = System::String::Contains(v14, (String *)"OnePassDeferred", 0LL);
			//           v5 = *options;
			//           if ( v15 )
			//           {
			//             if ( v5 )
			//             {
			//               v5.fields.m_forceRenderPath = 1;
			//               if ( *options )
			//               {
			//                 (*options).fields.m_renderPath = 4;
			//                 return 1;
			//               }
			//             }
			//           }
			//           else if ( v5 )
			//           {
			//             v5.fields.m_forceRenderPath = 0;
			//             return 1;
			//           }
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3512, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1249(Patch, options, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		public static bool SaveOptionsToFile(HGInitGraphicsAPIOptions options)
		{
			// // Boolean SaveOptionsToFile(HGInitGraphicsAPIOptions)
			// bool HG::Rendering::Runtime::HGInitGraphicsAPIUtils::SaveOptionsToFile(
			//         HGInitGraphicsAPIOptions *options,
			//         MethodInfo *method)
			// {
			//   String *persistentDataPath; // rbx
			//   String *v4; // r14
			//   String *v5; // rsi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Exception **v8; // rcx
			//   String *v9; // rax
			//   char *v11; // rdx
			//   String *v12; // rax
			//   char *v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Il2CppExceptionWrapper *v15; // rdi
			//   Il2CppClass *klass; // rbx
			//   __int64 v17; // rax
			//   Il2CppExceptionWrapper *v18; // rdi
			//   Il2CppClass *v19; // rbx
			//   __int64 v20; // rax
			//   Il2CppExceptionWrapper *v21; // rdi
			//   Il2CppClass *v22; // rbx
			//   __int64 v23; // rax
			//   Il2CppExceptionWrapper *v24; // [rsp+20h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper v25; // [rsp+28h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+30h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper v27; // [rsp+38h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v28; // [rsp+40h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v29; // [rsp+48h] [rbp-30h]
			//   Il2CppExceptionWrapper v30; // [rsp+50h] [rbp-28h] BYREF
			//   Il2CppExceptionWrapper *v31; // [rsp+90h] [rbp+18h]
			//   Il2CppExceptionWrapper *v32; // [rsp+98h] [rbp+20h]
			// 
			//   v31 = v24;
			//   v29 = v28;
			//   v32 = v26;
			//   if ( !byte_18D919766 )
			//   {
			//     sub_18003C530(&off_18C9106D0);
			//     sub_18003C530(&off_18D5209D8);
			//     sub_18003C530(&off_18C9106E0);
			//     sub_18003C530(&off_18C9106F0);
			//     sub_18003C530(&off_18C920FB8);
			//     sub_18003C530(&off_18C910718);
			//     sub_18003C530(&off_18D5209E0);
			//     sub_18003C530(&off_18C9B4D38);
			//     sub_18003C530(&off_18D5209E8);
			//     byte_18D919766 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3513, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3513, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                (ILFixDynamicMethodWrapper_27 *)Patch,
			//                (Object *)options,
			//                0LL);
			// LABEL_29:
			//     sub_180B536AC(v7, v6);
			//   }
			//   if ( UnityEngine::Application::get_platform(0LL) != RuntimePlatform__Enum_Android )
			//     return 0;
			//   persistentDataPath = UnityEngine::Application::get_persistentDataPath(0LL);
			//   v4 = System::String::Concat(persistentDataPath, (String *)"/Graphics", 0LL);
			//   v5 = System::String::Concat(persistentDataPath, (String *)"/Graphics/GraphicsApiSettings.txt", 0LL);
			//   if ( !System::IO::File::Exists(v5, 0LL) )
			//   {
			//     try
			//     {
			//       if ( !System::IO::Directory::Exists(v4, 0LL) )
			//         System::IO::Directory::CreateDirectory(v4, 0LL);
			//       System::IO::File::Create(v5, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v24 )
			//     {
			//       v15 = v24;
			//       klass = v24.ex.object.klass;
			//       v17 = sub_18000F7E0(&TypeInfo::System::Exception);
			//       if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v17, klass) )
			//       {
			//         v25.ex = v15.ex;
			//         throw &v25;
			//       }
			//       v8 = (Exception **)v31;
			//       goto LABEL_27;
			//     }
			//   }
			//   if ( !options )
			//     goto LABEL_29;
			//   switch ( options.fields.m_preferredDeviceType )
			//   {
			//     case 4:
			//       v11 = "Auto";
			//       break;
			//     case 0x15:
			//       v11 = "Vulkan";
			//       break;
			//     case 0xB:
			//       v11 = "GLES3";
			//       break;
			//     default:
			//       HG::Rendering::HGRPLogger::LogError((String *)"Unsupported graphics device type", 0LL);
			//       v9 = System::String::Concat((String *)"", (String *)"Auto", 0LL);
			//       try
			//       {
			//         System::IO::File::WriteAllText(v5, v9, 0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v26 )
			//       {
			//         v18 = v26;
			//         v19 = v26.ex.object.klass;
			//         v20 = sub_18000F7E0(&TypeInfo::System::Exception);
			//         if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v20, v19) )
			//         {
			//           v27.ex = v18.ex;
			//           throw &v27;
			//         }
			//         v8 = (Exception **)v32;
			//         goto LABEL_27;
			//       }
			//       return 0;
			//   }
			//   v12 = System::String::Concat((String *)"", (String *)v11, 0LL);
			//   if ( options.fields.m_preferredDeviceType == 4 || !options.fields.m_forceRenderPath )
			//     goto LABEL_50;
			//   if ( options.fields.m_renderPath == 3 )
			//   {
			//     v13 = "_DefaultDeferred";
			//     goto LABEL_25;
			//   }
			//   if ( options.fields.m_renderPath == 4 )
			//   {
			//     v13 = "_OnePassDeferred";
			// LABEL_25:
			//     v12 = System::String::Concat(v12, (String *)v13, 0LL);
			//   }
			// LABEL_50:
			//   try
			//   {
			//     System::IO::File::WriteAllText(v5, v12, 0LL);
			//   }
			//   catch ( Il2CppExceptionWrapper *v28 )
			//   {
			//     v21 = v28;
			//     v22 = v28.ex.object.klass;
			//     v23 = sub_18000F7E0(&TypeInfo::System::Exception);
			//     if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v23, v22) )
			//     {
			//       v30.ex = v21.ex;
			//       throw &v30;
			//     }
			//     v8 = (Exception **)v29;
			// LABEL_27:
			//     HG::Rendering::HGRPLogger::LogException(*v8, 0LL);
			//     return 0;
			//   }
			//   return 1;
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		internal static bool SaveOptionsToFile(GraphicsDeviceType deviceType, bool forceRenderPath, HGRenderPathInternal renderPath)
		{
			// // Boolean SaveOptionsToFile(GraphicsDeviceType, Boolean, HGRenderPathInternal)
			// bool HG::Rendering::Runtime::HGInitGraphicsAPIUtils::SaveOptionsToFile(
			//         GraphicsDeviceType__Enum deviceType,
			//         bool forceRenderPath,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   HGInitGraphicsAPIOptions *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919767 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     byte_18D919767 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3514, 0LL) )
			//   {
			//     v7 = (HGInitGraphicsAPIOptions *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     if ( v7 )
			//     {
			//       v7.fields.m_preferredDeviceType = deviceType;
			//       v7.fields.m_forceRenderPath = forceRenderPath;
			//       v7.fields.m_renderPath = renderPath;
			//       return HG::Rendering::Runtime::HGInitGraphicsAPIUtils::SaveOptionsToFile(v7, 0LL);
			//     }
			// LABEL_7:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3514, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1250(Patch, deviceType, forceRenderPath, renderPath, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(2)]
		internal static bool SaveOptionsToFile(GraphicsDeviceType deviceType)
		{
			// // Boolean SaveOptionsToFile(GraphicsDeviceType)
			// bool HG::Rendering::Runtime::HGInitGraphicsAPIUtils::SaveOptionsToFile(
			//         GraphicsDeviceType__Enum deviceType,
			//         MethodInfo *method)
			// {
			//   HGInitGraphicsAPIOptions *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919768 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     byte_18D919768 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3515, 0LL) )
			//   {
			//     v3 = (HGInitGraphicsAPIOptions *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGInitGraphicsAPIOptions);
			//     if ( v3 )
			//     {
			//       v3.fields.m_preferredDeviceType = deviceType;
			//       v3.fields.m_forceRenderPath = 0;
			//       v3.fields.m_renderPath = 3;
			//       return HG::Rendering::Runtime::HGInitGraphicsAPIUtils::SaveOptionsToFile(v3, 0LL);
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3515, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)deviceType,
			//            0LL);
			// }
			// 
			return default(bool);
		}
	}
}
