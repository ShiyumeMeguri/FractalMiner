using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPScreenMaterial(\u5168\u5C4F\u7279\u6548\u6750\u8D28)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshRenderer))]
	public class VFXPPScreenMaterial : VFXPPComponent // TypeDefIndex: 37964
	{
		// Fields
		public const int GRID_CELL_COUNT = 36; // Metadata: 0x023037A7
		public const int GRID_DIVISIONS = 6; // Metadata: 0x023037A8
		private Renderer m_renderer; // 0x48
		private const string SHADER_VFX_BASE = "HGRP/Effect/VFXBaseV2"; // Metadata: 0x023037A9
		private Material m_baseMaterial; // 0x50
		private bool m_hasValidVFXShader; // 0x58
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x00
		[HideInInspector]
		[SerializeField]
		private FullScreenMeshMode m_meshMode; // 0x5C
		[HideInInspector]
		[SerializeField]
		private bool[] m_gridMask; // 0x60
		[NonSerialized]
		private bool[] m_gridMaskEditCache; // 0x68
		public static Material fullScreenMaterial; // 0x08
		public static FullScreenMeshMode fullScreenMeshMode; // 0x10
		private static bool[] s_fullScreenGridMask; // 0x18
		private static FullScreenVFXData s_fullScreenVFXData; // 0x20
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184891C10-0x0000000184891C40 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPScreenMaterial::get_m_VFXPPType(
		        VFXPPScreenMaterial *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2567, 0LL) )
		    return 7;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2567, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public static bool fullScreenMaterialValid { get => default; } // 0x0000000183D23D70-0x0000000183D23E30 
		// Boolean get_fullScreenMaterialValid()
		bool HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialValid(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Material *fullScreenMaterial; // rbx
		  struct Object_1__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size > 1120 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2->static_fields->wrapperArray;
		    if ( v2 )
		    {
		      if ( LODWORD(v2->_0.namespaze) <= 0x460 )
		        sub_1800D2AB0(v2, v1);
		      if ( !v2[23].vtable.GetHashCode.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1120, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		    }
		LABEL_13:
		    sub_1800D8260(v2, v1);
		  }
		LABEL_5:
		  fullScreenMaterial = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial;
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
		  if ( !fullScreenMaterial )
		    return 0;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v5);
		  return fullScreenMaterial->fields._.m_CachedPtr != 0LL;
		}
		
		public static bool fullScreenMeshRenderable { get => default; } // 0x0000000183D23CF0-0x0000000183D23D70 
		// Boolean get_fullScreenMeshRenderable()
		bool HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMeshRenderable(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2__Array *v1; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Boolean__Array *fullScreenGridMask; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 1119 )
		    goto LABEL_25;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v1 = v2->static_fields->wrapperArray;
		  if ( !v1 )
		    goto LABEL_9;
		  if ( v1->max_length.size <= 0x45Fu )
		    goto LABEL_22;
		  if ( !v1[31].vector[3] )
		  {
		LABEL_25:
		    if ( !HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialValid(0LL) )
		      return 0;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMeshMode )
		      return 1;
		    fullScreenGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenGridMask(0LL);
		    v1 = 0LL;
		    if ( fullScreenGridMask )
		    {
		      while ( (unsigned int)v1 < fullScreenGridMask->max_length.size )
		      {
		        v2 = (struct ILFixDynamicMethodWrapper_2__Class *)(int)v1;
		        if ( fullScreenGridMask->vector[(int)v1] )
		          return 1;
		        v1 = (ILFixDynamicMethodWrapper_2__Array *)(unsigned int)((_DWORD)v1 + 1);
		        if ( (int)v1 >= 36 )
		          return 0;
		      }
		LABEL_22:
		      sub_1800D2AB0(v2, v1);
		    }
		LABEL_9:
		    sub_1800D8260(v2, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1119, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
		public static MaterialPropertyBlock fullScreenMaterialPropertyBlock { get => default; } // 0x0000000183089FA0-0x000000018308A030 
		// MaterialPropertyBlock get_fullScreenMaterialPropertyBlock()
		MaterialPropertyBlock *HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(
		        MethodInfo *method)
		{
		  struct VFXPPScreenMaterial__Class *v1; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1134, 0LL) )
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->s_materialPropertyBlock )
		      return v1->static_fields->s_materialPropertyBlock;
		    v5 = sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		    if ( v5 )
		    {
		      *(_QWORD *)(v5 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		      static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields;
		      static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v5;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields,
		        static_fields,
		        v7,
		        v8,
		        v10);
		      v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		      return v1->static_fields->s_materialPropertyBlock;
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1134, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_429(Patch, 0LL);
		}
		
		public static bool[] fullScreenGridMask { get => default; } // 0x000000018308A0D0-0x000000018308A150 
		// Boolean[] get_fullScreenGridMask()
		Boolean__Array *HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenGridMask(MethodInfo *method)
		{
		  struct VFXPPScreenMaterial__Class *v1; // rax
		  Boolean__Array *DefaultGridMask; // rax
		  VFXPPScreenMaterial__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1121, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1121, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_425(Patch, 0LL);
		  }
		  else
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->s_fullScreenGridMask )
		    {
		      DefaultGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::CreateDefaultGridMask(0LL);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields;
		      static_fields->s_fullScreenGridMask = DefaultGridMask;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->s_fullScreenGridMask,
		        (HGRuntimeGrassQuery_Node *)static_fields,
		        v5,
		        v6,
		        v10);
		      v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		    }
		    return v1->static_fields->s_fullScreenGridMask;
		  }
		}
		
		internal static FullScreenVFXData fullScreenVFXData { get => default; } // 0x00000001843BAEC0-0x00000001843BAF60 
		// FullScreenVFXData get_fullScreenVFXData()
		FullScreenVFXData *HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenVFXData(MethodInfo *method)
		{
		  struct VFXPPScreenMaterial__Class *v1; // rax
		  FullScreenVFXData *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  FullScreenVFXData *v6; // rbx
		  VFXPPScreenMaterial__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1123, 0LL) )
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->s_fullScreenVFXData )
		      return v1->static_fields->s_fullScreenVFXData;
		    v3 = (FullScreenVFXData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::FullScreenVFXData);
		    v6 = v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::FullScreenVFXData::FullScreenVFXData(v3, 0LL);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields;
		      static_fields->s_fullScreenVFXData = v6;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->s_fullScreenVFXData,
		        (HGRuntimeGrassQuery_Node *)static_fields,
		        v8,
		        v9,
		        v11);
		      v1 = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial;
		      return v1->static_fields->s_fullScreenVFXData;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1123, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_426(Patch, 0LL);
		}
		
	
		// Constructors
		public VFXPPScreenMaterial() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		private void Awake() {} // 0x0000000184619220-0x00000001846193C0
		// Void Awake()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::Awake(VFXPPScreenMaterial *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  __int64 v6; // rdx
		  struct Object_1__Class *v7; // rcx
		  Renderer *m_renderer; // rdi
		  Renderer *v9; // rcx
		  Material *SharedMaterial; // rax
		  struct Object_1__Class *v11; // rcx
		  Material *v12; // rdi
		  Material *v13; // rax
		  Object_1 *shader; // rax
		  String *name; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2568, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2568, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_20;
		  }
		  this->fields.m_renderer = (Renderer *)UnityEngine::Component::GetComponent<System::Object>(
		                                          (Component *)this,
		                                          MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Renderer>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderer, v3, v4, v5, v17);
		  this->fields.m_hasValidVFXShader = 0;
		  HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskInitialized(this, 0LL);
		  v7 = TypeInfo::UnityEngine::Object;
		  m_renderer = this->fields.m_renderer;
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
		  if ( m_renderer )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v7);
		    if ( m_renderer->fields._._.m_CachedPtr )
		    {
		      v9 = this->fields.m_renderer;
		      if ( !v9 )
		        goto LABEL_20;
		      SharedMaterial = UnityEngine::Renderer::GetSharedMaterial(v9, 0LL);
		      v11 = TypeInfo::UnityEngine::Object;
		      v12 = SharedMaterial;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v11 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v11 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( v12 )
		      {
		        if ( !v11->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v11);
		        if ( v12->fields._.m_CachedPtr )
		        {
		          v9 = this->fields.m_renderer;
		          if ( v9 )
		          {
		            v13 = UnityEngine::Renderer::GetSharedMaterial(v9, 0LL);
		            if ( v13 )
		            {
		              shader = (Object_1 *)UnityEngine::Material::get_shader(v13, 0LL);
		              if ( shader )
		              {
		                name = UnityEngine::Object::get_name(shader, 0LL);
		                if ( name )
		                {
		                  if ( System::String::Equals(name, (String *)"HGRP/Effect/VFXBaseV2", 0LL) )
		                    this->fields.m_hasValidVFXShader = 1;
		                  return;
		                }
		              }
		            }
		          }
		LABEL_20:
		          sub_1800D8260(v9, v6);
		        }
		      }
		    }
		  }
		}
		
		private void Reset() {} // 0x0000000189B66414-0x0000000189B66464
		// Void Reset()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::Reset(VFXPPScreenMaterial *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2571, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2571, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPScreenMaterial::ResetGridMaskToAllVisible(this, 0LL);
		  }
		}
		
		private void ResetGridMaskToAllVisible() {} // 0x0000000189B663A8-0x0000000189B66414
		// Void ResetGridMaskToAllVisible()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::ResetGridMaskToAllVisible(
		        VFXPPScreenMaterial *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2570, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2570, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_gridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::CreateDefaultGridMask(0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gridMask, v3, v4, v5, v12);
		    this->fields.m_gridMaskEditCache = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gridMaskEditCache, v6, v7, v8, v13);
		  }
		}
		
		private void OnValidate() {} // 0x0000000189B66358-0x0000000189B663A8
		// Void OnValidate()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::OnValidate(VFXPPScreenMaterial *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2572, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2572, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskInitialized(this, 0LL);
		  }
		}
		
		private static bool[] CreateDefaultGridMask() => default; // 0x0000000184367940-0x00000001843679A0
		// Boolean[] CreateDefaultGridMask()
		Boolean__Array *HG::Rendering::Runtime::VFXPPScreenMaterial::CreateDefaultGridMask(MethodInfo *method)
		{
		  Boolean__Array *result; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1122, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1122, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_425(Patch, 0LL);
		LABEL_6:
		    sub_1800D8260(v3, v2);
		  }
		  result = (Boolean__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Boolean, 36LL);
		  v3 = 0LL;
		  if ( !result )
		    goto LABEL_6;
		  do
		  {
		    if ( (unsigned int)v3 >= result->max_length.size )
		      sub_1800D2AB0(v3, v2);
		    v2 = (int)v3;
		    v3 = (unsigned int)(v3 + 1);
		    result->vector[v2] = 1;
		  }
		  while ( (int)v3 < 36 );
		  return result;
		}
		
		private void EnsureGridMaskInitialized() {} // 0x000000018308A150-0x000000018308A190
		// Void EnsureGridMaskInitialized()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskInitialized(
		        VFXPPScreenMaterial *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2569, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2569, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields.m_gridMask || this->fields.m_gridMask->max_length.size != 36 )
		  {
		    HG::Rendering::Runtime::VFXPPScreenMaterial::ResetGridMaskToAllVisible(this, 0LL);
		  }
		}
		
		private void EnsureGridMaskEditCacheInitialized() {} // 0x0000000189B662C8-0x0000000189B66358
		// Void EnsureGridMaskEditCacheInitialized()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskEditCacheInitialized(
		        VFXPPScreenMaterial *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2573, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2573, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskInitialized(this, 0LL);
		    if ( !this->fields.m_gridMaskEditCache || this->fields.m_gridMaskEditCache->max_length.size != 36 )
		    {
		      this->fields.m_gridMaskEditCache = (Boolean__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Boolean, 36LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_gridMaskEditCache, v3, v4, v5, v9);
		      HG::Rendering::Runtime::VFXPPScreenMaterial::CopyGridMask(
		        this->fields.m_gridMask,
		        this->fields.m_gridMaskEditCache,
		        0LL);
		    }
		  }
		}
		
		private bool[] GetActiveGridMask() => default; // 0x000000018308A090-0x000000018308A0D0
		// Boolean[] GetActiveGridMask()
		Boolean__Array *HG::Rendering::Runtime::VFXPPScreenMaterial::GetActiveGridMask(
		        VFXPPScreenMaterial *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2575, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2575, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_920(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPScreenMaterial::EnsureGridMaskInitialized(this, 0LL);
		    return this->fields.m_gridMask;
		  }
		}
		
		private static void CopyGridMask(bool[] source, bool[] destination) {} // 0x000000018308A210-0x000000018308A290
		// Void CopyGridMask(Boolean[], Boolean[])
		void HG::Rendering::Runtime::VFXPPScreenMaterial::CopyGridMask(
		        Boolean__Array *source,
		        Boolean__Array *destination,
		        MethodInfo *method)
		{
		  Array *DefaultGridMask; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2574, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2574, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)source,
		      (Object *)destination,
		      0LL);
		  }
		  else if ( source && source->max_length.size == 36 )
		  {
		    System::Array::Copy((Array *)source, (Array *)destination, 36, 0LL);
		  }
		  else
		  {
		    DefaultGridMask = (Array *)HG::Rendering::Runtime::VFXPPScreenMaterial::CreateDefaultGridMask(0LL);
		    System::Array::Copy(DefaultGridMask, (Array *)destination, 36, 0LL);
		  }
		}
		
		private void PushMeshConfigToStatic() {} // 0x000000018308A030-0x000000018308A090
		// Void PushMeshConfigToStatic()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::PushMeshConfigToStatic(VFXPPScreenMaterial *this, MethodInfo *method)
		{
		  Boolean__Array *ActiveGridMask; // rbx
		  Boolean__Array *fullScreenGridMask; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2576, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2576, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMeshMode = this->fields.m_meshMode;
		    ActiveGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::GetActiveGridMask(this, 0LL);
		    fullScreenGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenGridMask(0LL);
		    HG::Rendering::Runtime::VFXPPScreenMaterial::CopyGridMask(ActiveGridMask, fullScreenGridMask, 0LL);
		  }
		}
		
		private static void ResetMeshConfigStatic() {} // 0x00000001846B49B0-0x00000001846B4A00
		// Void ResetMeshConfigStatic()
		void HG::Rendering::Runtime::VFXPPScreenMaterial::ResetMeshConfigStatic(MethodInfo *method)
		{
		  Boolean__Array *fullScreenGridMask; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2577, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2577, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMeshMode = 0;
		    fullScreenGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenGridMask(0LL);
		    HG::Rendering::Runtime::VFXPPScreenMaterial::CopyGridMask(0LL, fullScreenGridMask, 0LL);
		  }
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000183089E50-0x0000000183089FA0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPScreenMaterial::Apply(
		        VFXPPScreenMaterial *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  struct Object_1__Class *v7; // rcx
		  Transform *v8; // rdi
		  Renderer *m_renderer; // rcx
		  Material *SharedMaterial; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  Renderer *v14; // rdi
		  MaterialPropertyBlock *v15; // rax
		  MaterialPropertyBlock *v16; // rax
		  MaterialPropertyBlock *fullScreenMaterialPropertyBlock; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i si128; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2578, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2578, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_13;
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v7 = TypeInfo::UnityEngine::Object;
		  v8 = transform;
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
		  if ( v8 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v7);
		    if ( v8->fields._._.m_CachedPtr )
		    {
		      if ( this->fields.m_hasValidVFXShader == (v8->fields._._.m_CachedPtr == 0LL) )
		      {
		        fullScreenMaterialPropertyBlock = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
		        if ( fullScreenMaterialPropertyBlock )
		        {
		          UnityEngine::MaterialPropertyBlock::Clear(fullScreenMaterialPropertyBlock, 1, 0LL);
		          TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial = 0LL;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial,
		            v18,
		            v19,
		            v20,
		            (MethodInfo *)si128.m128i_i64[0]);
		          HG::Rendering::Runtime::VFXPPScreenMaterial::ResetMeshConfigStatic(0LL);
		          return;
		        }
		      }
		      else
		      {
		        m_renderer = this->fields.m_renderer;
		        if ( m_renderer )
		        {
		          SharedMaterial = UnityEngine::Renderer::GetSharedMaterial(m_renderer, 0LL);
		          static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields;
		          static_fields->monitor = (MonitorData *)SharedMaterial;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial,
		            static_fields,
		            v12,
		            v13,
		            (MethodInfo *)si128.m128i_i64[0]);
		          v14 = this->fields.m_renderer;
		          v15 = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
		          if ( v14 )
		          {
		            UnityEngine::Renderer::Internal_GetPropertyBlock(v14, v15, 0LL);
		            v16 = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
		            if ( v16 )
		            {
		              si128 = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		              UnityEngine::MaterialPropertyBlock::SetVector(v16, (String *)"unity_LODFade", (Vector4 *)&si128, 0LL);
		              HG::Rendering::Runtime::VFXPPScreenMaterial::PushMeshConfigToStatic(this, 0LL);
		              return;
		            }
		          }
		        }
		      }
		LABEL_13:
		      sub_1800D8260(m_renderer, v6);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x00000001846B4920-0x00000001846B49B0
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPScreenMaterial::ResetByVolumeProfile(
		        VFXPPScreenMaterial *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  MaterialPropertyBlock *fullScreenMaterialPropertyBlock; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2579, 0LL) )
		  {
		    fullScreenMaterialPropertyBlock = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
		    if ( fullScreenMaterialPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(fullScreenMaterialPropertyBlock, 1, 0LL);
		      TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial = 0LL;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMaterial,
		        v8,
		        v9,
		        v10,
		        v12);
		      HG::Rendering::Runtime::VFXPPScreenMaterial::ResetMeshConfigStatic(0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2579, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		public VFXPPType __iFixBaseProxy_get_m_VFXPPType() => default; // 0x0000000189B5D900-0x0000000189B5D908
		// VFXPPType <>iFixBaseProxy_get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_get_m_VFXPPType(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType((VFXPPComponent *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Apply(VolumeProfile P0) {} // 0x0000000189B5D8E8-0x0000000189B5D8F0
		// Void <>iFixBaseProxy_Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0) {} // 0x0000000189B5D8F8-0x0000000189B5D900
		// Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
		}
		
	}
}
