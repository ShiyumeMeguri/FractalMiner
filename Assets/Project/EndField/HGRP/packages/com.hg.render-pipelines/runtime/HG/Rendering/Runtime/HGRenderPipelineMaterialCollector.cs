using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineMaterialCollector
	{
		public HGRenderPipelineMaterialCollector()
		{
			// // HGRenderPipelineMaterialCollector()
			// void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::HGRenderPipelineMaterialCollector(
			//         HGRenderPipelineMaterialCollector *this,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   List_1_UnityEngine_Material_ *v6; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDA4E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Material>);
			//     byte_18D8EDA4E = 1;
			//   }
			//   v3 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Material>);
			//   v6 = (List_1_UnityEngine_Material_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v3,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::List);
			//   this.fields.m_Materials = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v7, v8, v9, v10, v11);
			// }
			// 
		}

		public Material CreateMaterial(Shader shader, [MetadataOffset(Offset = "0x01F9164E")] bool enableInstancing = false)
		{
			// // Material CreateMaterial(Shader, Boolean)
			// Material *HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//         HGRenderPipelineMaterialCollector *this,
			//         Shader *shader,
			//         bool enableInstancing,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Object *EngineMaterial; // rax
			//   __int64 v9; // rdx
			//   List_1_System_Object_ *m_Materials; // rcx
			//   Material *v11; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA4A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Add);
			//     byte_18D8EDA4A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2416, 0LL) )
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, v7);
			//     EngineMaterial = (Object *)UnityEngine::Rendering::CoreUtils::CreateEngineMaterial(shader, enableInstancing, 0LL);
			//     m_Materials = (List_1_System_Object_ *)this.fields.m_Materials;
			//     v11 = (Material *)EngineMaterial;
			//     if ( m_Materials )
			//     {
			//       sub_1822AD140(m_Materials, EngineMaterial);
			//       return v11;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_Materials, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2416, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_871(Patch, (Object *)this, (Object *)shader, enableInstancing, 0LL);
			// }
			// 
			return null;
		}

		public void ClearMaterials()
		{
			// // Void ClearMaterials()
			// void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearMaterials(
			//         HGRenderPipelineMaterialCollector *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_System_Object_ *v4; // rcx
			//   int32_t i; // ebx
			//   List_1_UnityEngine_Material_ *m_Materials; // rax
			//   List_1_System_Object_ *v7; // rcx
			//   __int64 v8; // rdx
			//   Object *Item; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA4B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
			//     byte_18D8EDA4B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(515, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(515, 0LL);
			//     if ( !Patch )
			// LABEL_12:
			//       sub_180B536AC(v4, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_Materials = this.fields.m_Materials;
			//       if ( !m_Materials )
			//         goto LABEL_12;
			//       v7 = (List_1_System_Object_ *)this.fields.m_Materials;
			//       if ( i >= m_Materials.fields._size )
			//         break;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                v7,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
			//       if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, v8);
			//       UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)Item, 0LL);
			//       v4 = (List_1_System_Object_ *)this.fields.m_Materials;
			//       if ( !v4 )
			//         goto LABEL_12;
			//       System::Collections::Generic::List<System::Object>::set_Item(
			//         v4,
			//         i,
			//         0LL,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
			//     }
			//     sub_1823B99D0(v7, MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
			//   }
			// }
			// 
		}

		public static Material CreateStaticMaterial(Shader shader, [MetadataOffset(Offset = "0x01F9164F")] bool enableInstancing = false)
		{
			// // Material CreateStaticMaterial(Shader, Boolean)
			// Material *HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//         Shader *shader,
			//         bool enableInstancing,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Material *EngineMaterial; // rax
			//   __int64 v7; // rdx
			//   struct HGRenderPipelineMaterialCollector__Class *v8; // rcx
			//   Object *v9; // rbx
			//   List_1_System_Object_ *s_StaticMaterials; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA4C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Add);
			//     byte_18D8EDA4C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(788, 0LL) )
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, v5);
			//     EngineMaterial = UnityEngine::Rendering::CoreUtils::CreateEngineMaterial(shader, enableInstancing, 0LL);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//     v9 = (Object *)EngineMaterial;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v7);
			//       v8 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//     }
			//     s_StaticMaterials = (List_1_System_Object_ *)v8.static_fields.s_StaticMaterials;
			//     if ( s_StaticMaterials )
			//     {
			//       sub_1822AD140(s_StaticMaterials, v9);
			//       return (Material *)v9;
			//     }
			// LABEL_10:
			//     sub_180B536AC(s_StaticMaterials, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(788, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_300(Patch, (Object *)shader, enableInstancing, 0LL);
			// }
			// 
			return null;
		}

		public static void ClearStaticMaterials()
		{
			// // Void ClearStaticMaterials()
			// void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearStaticMaterials(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   int32_t i; // ebx
			//   struct HGRenderPipelineMaterialCollector__Class *v3; // rax
			//   List_1_System_Object_ *static_fields; // rcx
			//   List_1_System_Object___Class *klass; // rdx
			//   __int64 v6; // rdx
			//   Object *Item; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA4D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
			//     byte_18D8EDA4D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(491, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v1);
			//         v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//       }
			//       static_fields = (List_1_System_Object_ *)v3.static_fields;
			//       klass = static_fields.klass;
			//       if ( !static_fields.klass )
			//         goto LABEL_20;
			//       if ( i >= SLODWORD(klass._0.namespaze) )
			//         break;
			//       if ( !v3._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v3, klass);
			//         v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//       }
			//       static_fields = (List_1_System_Object_ *)v3.static_fields.s_StaticMaterials;
			//       if ( !static_fields )
			//         goto LABEL_20;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                static_fields,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
			//       if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, v6);
			//       UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)Item, 0LL);
			//       static_fields = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector.static_fields.s_StaticMaterials;
			//       if ( !static_fields )
			//         goto LABEL_20;
			//       System::Collections::Generic::List<System::Object>::set_Item(
			//         static_fields,
			//         i,
			//         0LL,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
			//     }
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, klass);
			//       v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
			//     }
			//     static_fields = (List_1_System_Object_ *)v3.static_fields.s_StaticMaterials;
			//     if ( static_fields )
			//     {
			//       sub_1823B99D0(static_fields, MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
			//       return;
			//     }
			// LABEL_20:
			//     sub_180B536AC(static_fields, klass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(491, 0LL);
			//   if ( !Patch )
			//     goto LABEL_20;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			// }
			// 
		}

		private List<Material> m_Materials;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static List<Material> s_StaticMaterials;
	}
}
