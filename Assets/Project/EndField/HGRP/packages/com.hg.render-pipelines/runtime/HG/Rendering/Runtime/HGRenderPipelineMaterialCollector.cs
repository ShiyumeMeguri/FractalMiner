using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineMaterialCollector // TypeDefIndex: 38153
	{
		// Fields
		private List<Material> m_Materials; // 0x10
		private static List<Material> s_StaticMaterials; // 0x00
	
		// Constructors
		public HGRenderPipelineMaterialCollector() {} // 0x0000000183B95BC0-0x0000000183B95C10
		// HGRenderPipelineMaterialCollector()
		void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::HGRenderPipelineMaterialCollector(
		        HGRenderPipelineMaterialCollector *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_UnityEngine_Material_ *v6; // rbx
		  HGRenderPathBase_HGRenderPathResources *v7; // rdx
		  PassConstructorID__Enum__Array *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Material>);
		  v6 = (List_1_UnityEngine_Material_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::List);
		  this->fields.m_Materials = v6;
		  sub_18002D1B0((HGRenderPathScene *)&this->fields, v7, v8, v9, v10, v11);
		}
		
		static HGRenderPipelineMaterialCollector() {} // 0x0000000184D567D0-0x0000000184D56830
		// HGRenderPipelineMaterialCollector()
		void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::cctor(MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  List_1_UnityEngine_Material_ *v4; // rbx
		  HGRenderPathBase_HGRenderPathResources *v5; // rdx
		  PassConstructorID__Enum__Array *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		  MethodInfo *v9; // [rsp+58h] [rbp+30h]
		
		  v1 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Material>);
		  v4 = (List_1_UnityEngine_Material_ *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v1,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::List);
		  TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->static_fields->s_StaticMaterials = v4;
		  sub_18002D1B0(
		    (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->static_fields,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9);
		}
		
	
		// Methods
		public Material CreateMaterial(Shader shader, bool enableInstancing = false /* Metadata: 0x02303A82 */) => default; // 0x000000018351FA60-0x000000018351FAF0
		// Material CreateMaterial(Shader, Boolean)
		Material *HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		        HGRenderPipelineMaterialCollector *this,
		        Shader *shader,
		        bool enableInstancing,
		        MethodInfo *method)
		{
		  Object *EngineMaterial; // rax
		  __int64 v8; // rdx
		  List_1_System_Object_ *m_Materials; // rcx
		  Material *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2898, 0LL) )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    EngineMaterial = (Object *)UnityEngine::Rendering::CoreUtils::CreateEngineMaterial(shader, enableInstancing, 0LL);
		    m_Materials = (List_1_System_Object_ *)this->fields.m_Materials;
		    v10 = (Material *)EngineMaterial;
		    if ( m_Materials )
		    {
		      sub_182F01190(m_Materials, EngineMaterial);
		      return v10;
		    }
		LABEL_6:
		    sub_1800D8260(m_Materials, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2898, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1059(
		           Patch,
		           (Object *)this,
		           (Object *)shader,
		           enableInstancing,
		           0LL);
		}
		
		public void ClearMaterials() {} // 0x00000001837DCFD0-0x00000001837DD090
		// Void ClearMaterials()
		void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearMaterials(
		        HGRenderPipelineMaterialCollector *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_System_Object_ *v4; // rcx
		  int32_t i; // ebx
		  List_1_UnityEngine_Material_ *m_Materials; // rax
		  List_1_System_Object_ *v7; // rcx
		  Object *Item; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(540, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(540, 0LL);
		    if ( !Patch )
		LABEL_10:
		      sub_1800D8260(v4, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_Materials = this->fields.m_Materials;
		      if ( !m_Materials )
		        goto LABEL_10;
		      v7 = (List_1_System_Object_ *)this->fields.m_Materials;
		      if ( i >= m_Materials->fields._size )
		        break;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               v7,
		               i,
		               MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
		      if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)Item, 0LL);
		      v4 = (List_1_System_Object_ *)this->fields.m_Materials;
		      if ( !v4 )
		        goto LABEL_10;
		      System::Collections::Generic::List<System::Object>::set_Item(
		        v4,
		        i,
		        0LL,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
		    }
		    sub_183127A90(v7, MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
		  }
		}
		
		public static Material CreateStaticMaterial(Shader shader, bool enableInstancing = false /* Metadata: 0x02303A83 */) => default; // 0x0000000183520C20-0x0000000183520CC0
		// Material CreateStaticMaterial(Shader, Boolean)
		Material *HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		        Shader *shader,
		        bool enableInstancing,
		        MethodInfo *method)
		{
		  Material *EngineMaterial; // rax
		  __int64 v6; // rdx
		  struct HGRenderPipelineMaterialCollector__Class *v7; // rcx
		  Object *v8; // rbx
		  List_1_System_Object_ *s_StaticMaterials; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(853, 0LL) )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    EngineMaterial = UnityEngine::Rendering::CoreUtils::CreateEngineMaterial(shader, enableInstancing, 0LL);
		    v7 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		    v8 = (Object *)EngineMaterial;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		      v7 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		    }
		    s_StaticMaterials = (List_1_System_Object_ *)v7->static_fields->s_StaticMaterials;
		    if ( s_StaticMaterials )
		    {
		      sub_182F01190(s_StaticMaterials, v8);
		      return (Material *)v8;
		    }
		LABEL_8:
		    sub_1800D8260(s_StaticMaterials, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(853, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_337(Patch, (Object *)shader, enableInstancing, 0LL);
		}
		
		public static void ClearStaticMaterials() {} // 0x00000001837DC920-0x00000001837DCA60
		// Void ClearStaticMaterials()
		void HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearStaticMaterials(MethodInfo *method)
		{
		  int32_t i; // ebx
		  struct HGRenderPipelineMaterialCollector__Class *v2; // rax
		  List_1_System_Object_ *static_fields; // rcx
		  List_1_System_Object___Class *klass; // rdx
		  Object *Item; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(516, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		        v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		      }
		      static_fields = (List_1_System_Object_ *)v2->static_fields;
		      klass = static_fields->klass;
		      if ( !static_fields->klass )
		        goto LABEL_14;
		      if ( i >= SLODWORD(klass->_0.namespaze) )
		        break;
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		      }
		      static_fields = (List_1_System_Object_ *)v2->static_fields->s_StaticMaterials;
		      if ( !static_fields )
		        goto LABEL_14;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               static_fields,
		               i,
		               MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::get_Item);
		      if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)Item, 0LL);
		      static_fields = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->static_fields->s_StaticMaterials;
		      if ( !static_fields )
		        goto LABEL_14;
		      System::Collections::Generic::List<System::Object>::set_Item(
		        static_fields,
		        i,
		        0LL,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::set_Item);
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector;
		    }
		    static_fields = (List_1_System_Object_ *)v2->static_fields->s_StaticMaterials;
		    if ( static_fields )
		    {
		      sub_183127A90(static_fields, MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(static_fields, klass);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(516, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
	}
}
