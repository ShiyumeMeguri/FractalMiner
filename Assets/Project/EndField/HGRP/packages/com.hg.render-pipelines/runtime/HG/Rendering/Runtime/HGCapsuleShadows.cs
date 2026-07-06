using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public class HGCapsuleShadows
	{
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00002608 File Offset: 0x00000808
		public static int count
		{
			get
			{
				// // Int32 get_count()
				// int32_t HG::Rendering::Runtime::HGCapsuleShadows::get_count(MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *capsuleShadowHelpers; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				// 
				//   if ( !byte_18D919760 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Count);
				//     byte_18D919760 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
				//   capsuleShadowHelpers = HG::Rendering::Runtime::HGCapsuleShadows::get_capsuleShadowHelpers(0LL);
				//   if ( !capsuleShadowHelpers )
				//     sub_180B536AC(v3, v2);
				//   return capsuleShadowHelpers.fields._size;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000025D2 File Offset: 0x000007D2
		public static List<HGCapsuleShadowHelper> capsuleShadowHelpers
		{
			get
			{
				return null;
			}
		}

		public HGCapsuleShadows()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static void EnqueueCapsuleShadowHelper(HGCapsuleShadowHelper capsuleShadowHelper)
		{
		}

		public static void DequeueCapsuleShadowHelper(HGCapsuleShadowHelper capsuleShadowHelper)
		{
			// // Void DequeueCapsuleShadowHelper(HGCapsuleShadowHelper)
			// void HG::Rendering::Runtime::HGCapsuleShadows::DequeueCapsuleShadowHelper(
			//         HGCapsuleShadowHelper *capsuleShadowHelper,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGCapsuleShadows__Class *v4; // rax
			//   __int64 v5; // rdx
			//   struct HGCapsuleShadows__Class *v6; // rax
			//   List_1_System_Object_ *m_capsuleShadowHelpers; // rcx
			//   struct HGCapsuleShadows__Class *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB89 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Remove);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB89 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3486, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3486, 0LL);
			//     if ( !Patch )
			//       goto LABEL_19;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)capsuleShadowHelper,
			//       0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//     }
			//     if ( v4.static_fields.m_capsuleShadowHelpers )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//       if ( !UnityEngine::Object::op_Equality((Object_1 *)capsuleShadowHelper, 0LL, 0LL) )
			//       {
			//         v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows, v5);
			//           v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//         }
			//         m_capsuleShadowHelpers = (List_1_System_Object_ *)v6.static_fields.m_capsuleShadowHelpers;
			//         if ( !m_capsuleShadowHelpers )
			//           goto LABEL_19;
			//         if ( System::Collections::Generic::List<System::Object>::Contains(
			//                m_capsuleShadowHelpers,
			//                (Object *)capsuleShadowHelper,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Contains) )
			//         {
			//           v8 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows, v5);
			//             v8 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
			//           }
			//           m_capsuleShadowHelpers = (List_1_System_Object_ *)v8.static_fields.m_capsuleShadowHelpers;
			//           if ( m_capsuleShadowHelpers )
			//           {
			//             System::Collections::Generic::List<System::Object>::Remove(
			//               m_capsuleShadowHelpers,
			//               (Object *)capsuleShadowHelper,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Remove);
			//             return;
			//           }
			// LABEL_19:
			//           sub_180B536AC(m_capsuleShadowHelpers, v5);
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGCapsuleShadows> s_Instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly HGCapsuleShadows instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static List<HGCapsuleShadowHelper> m_capsuleShadowHelpers;
	}
}
