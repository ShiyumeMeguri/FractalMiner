using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class BSP : ICsgProvider // TypeDefIndex: 38801
	{
		// Fields
		public bool _createDescription; // 0x10
		public object[] description; // 0x18
		public static object locker; // 0x00
		public static List<CSGPolygon> polygons; // 0x08
		public static Matrix4x4 matrix; // 0x10
		public static Matrix4x4 matrix2; // 0x50
		public static Vector3[] vertices; // 0x90
		public static Vector3[] normals; // 0x98
		public static Vector2[] uv; // 0xA0
		public Node root; // 0x20
	
		// Properties
		public IEnumerable<object> Description { get => default; } // 0x0000000189C74EE8-0x0000000189C74F38 
		// IEnumerable`1[System.Object] get_Description()
		IEnumerable_1_System_Object_ *HG::Rendering::Runtime::CSG::BSP::get_Description(BSP *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5408, 0LL) )
		    return (IEnumerable_1_System_Object_ *)this->fields.description;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5408, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1559(Patch, (Object *)this, 0LL);
		}
		
		public Bounds? Bounds { get; private set; } // 0x0000000184DA1F40-0x0000000184DA1F60 0x0000000184DA1F60-0x0000000184DA1F80
		// Nullable`1[UnityEngine.Bounds] get_Bounds()
		Nullable_1_UnityEngine_Bounds_ *HG::Rendering::Runtime::CSG::BSP::get_Bounds(
		        Nullable_1_UnityEngine_Bounds_ *__return_ptr retstr,
		        BSP *this,
		        MethodInfo *method)
		{
		  float z; // eax
		  __int64 v4; // xmm1_8
		
		  z = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		  v4 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		  *(_OWORD *)&retstr->hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		  *(_QWORD *)&retstr->value.m_Extents.x = v4;
		  retstr->value.m_Extents.z = z;
		  return retstr;
		}
		

		// Void set_Bounds(Nullable`1[UnityEngine.Bounds])
		void HG::Rendering::Runtime::CSG::BSP::set_Bounds(BSP *this, Nullable_1_UnityEngine_Bounds_ *value, MethodInfo *method)
		{
		  float z; // eax
		  __int64 v4; // xmm1_8
		
		  z = value->value.m_Extents.z;
		  v4 = *(_QWORD *)&value->value.m_Extents.x;
		  *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&value->hasValue;
		  *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = v4;
		  this->fields._Bounds_k__BackingField.value.m_Extents.z = z;
		}
		
		public IEnumerable<CSGPolygon> Polygons { get => default; } // 0x0000000189C74F38-0x0000000189C74F90 
		// IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon] get_Polygons()
		IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *HG::Rendering::Runtime::CSG::BSP::get_Polygons(
		        BSP *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Node_2 *root; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5409, 0LL) )
		  {
		    root = this->fields.root;
		    if ( root )
		      return HG::Rendering::Runtime::CSG::Node::get_AllPolygons(root, 0LL);
		LABEL_5:
		    sub_1800D8260(root, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5409, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1530(Patch, (Object *)this, 0LL);
		}
		
	
		// Events
		public event Action OnChange;
	
		// Constructors
		public BSP() {} // Dummy constructor
		public BSP(bool createDescription) {} // 0x0000000189C73ED0-0x0000000189C73F80
		// BSP(Boolean)
		void HG::Rendering::Runtime::CSG::BSP::BSP(BSP *this, bool createDescription, MethodInfo *method)
		{
		  Node_2 *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Node_2 *v8; // rbx
		  __int128 v9; // xmm0
		  Object__Array *v10; // rax
		  Nullable_1_UnityEngine_Bounds_ v11; // [rsp+30h] [rbp-48h] BYREF
		  __int64 v12; // [rsp+60h] [rbp-18h]
		
		  v5 = (Node_2 *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::Node);
		  v8 = v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  HG::Rendering::Runtime::CSG::Node::Node(v5, 0LL);
		  v9 = 0LL;
		  v12 = 0LL;
		  if ( createDescription )
		  {
		    v10 = (Object__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Object, 0LL);
		    v9 = 0LL;
		  }
		  else
		  {
		    v10 = 0LL;
		  }
		  *(_OWORD *)&v11.hasValue = v9;
		  *(_QWORD *)&v11.value.m_Extents.x = v12;
		  v11.value.m_Extents.z = 0.0;
		  HG::Rendering::Runtime::CSG::BSP::BSP(this, v8, &v11, v10, 1, 0LL);
		  this->fields._createDescription = createDescription;
		}
		
		protected BSP(IEnumerable<CSGPolygon> polygons, Bounds bounds, object[] description, bool createDescription) {} // 0x0000000189C73F80-0x0000000189C74030
		// BSP(IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon], Bounds, Object[], Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::CSG::BSP::BSP(
		        BSP *this,
		        IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
		        Bounds *bounds,
		        Object__Array *description,
		        bool createDescription,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  Node_2 *root; // rcx
		  __int64 v12; // xmm1_8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v13; // rdx
		  VolumetricRenderer_VolumetricBounds *v14; // r8
		  Int32__Array **v15; // r9
		  _BYTE v16[24]; // [rsp+20h] [rbp-28h]
		  int32_t v17; // [rsp+80h] [rbp+38h]
		  int32_t v18; // [rsp+88h] [rbp+40h]
		  float v19; // [rsp+90h] [rbp+48h]
		  int32_t v20; // [rsp+98h] [rbp+50h]
		  bool v21; // [rsp+A0h] [rbp+58h]
		  bool v22; // [rsp+A8h] [rbp+60h]
		  MethodInfo *v23; // [rsp+B0h] [rbp+68h]
		
		  HG::Rendering::Runtime::CSG::BSP::BSP(this, 1, 0LL);
		  root = this->fields.root;
		  this->fields._createDescription = createDescription;
		  if ( !root )
		    sub_1800D8260(0LL, v10);
		  HG::Rendering::Runtime::CSG::Node::Build(root, polygons, 0LL);
		  v12 = *(_QWORD *)&bounds->m_Extents.y;
		  this->fields.description = description;
		  *(_DWORD *)v16 = 1;
		  *(_DWORD *)&v16[20] = v12;
		  *(_OWORD *)&v16[4] = *(_OWORD *)&bounds->m_Center.x;
		  *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = *(_OWORD *)v16;
		  *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = *(_QWORD *)&v16[16];
		  this->fields._Bounds_k__BackingField.value.m_Extents.z = *((float *)&v12 + 1);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.description,
		    v13,
		    v14,
		    v15,
		    (MethodInfo *)createDescription,
		    method,
		    v17,
		    v18,
		    v19,
		    v20,
		    v21,
		    v22,
		    v23);
		}
		
		private BSP(Node root, Bounds? bounds, object[] description, bool createDescription) {} // 0x0000000189C73E80-0x0000000189C73ED0
		static BSP() {} // 0x0000000189C73E38-0x0000000189C73E80
		// BSP()
		void HG::Rendering::Runtime::CSG::BSP::cctor(MethodInfo *method)
		{
		  Object *v1; // rdx
		  __int64 v2; // rcx
		  VolumetricRenderer_VolumetricBounds *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		  MethodInfo *v6; // [rsp+58h] [rbp+30h]
		  int32_t v7; // [rsp+60h] [rbp+38h]
		  int32_t v8; // [rsp+68h] [rbp+40h]
		  float v9; // [rsp+70h] [rbp+48h]
		  int32_t v10; // [rsp+78h] [rbp+50h]
		  bool v11; // [rsp+80h] [rbp+58h]
		  bool v12; // [rsp+88h] [rbp+60h]
		  MethodInfo *v13; // [rsp+90h] [rbp+68h]
		
		  v1 = (Object *)sub_18002C620(TypeInfo::System::Object);
		  if ( !v1 )
		    sub_1800D8260(v2, 0LL);
		  TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->locker = v1;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields,
		    (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v1,
		    v3,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13);
		}
		
	
		// Methods
		public BSP Clone() => default; // 0x0000000189C71978-0x0000000189C71A68
		// BSP Clone()
		BSP *HG::Rendering::Runtime::CSG::BSP::Clone(BSP *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Node_2 *root; // rcx
		  Node_2 *v5; // rdi
		  float z; // esi
		  Object__Array *description; // rbp
		  bool createDescription; // r14
		  BSP *v9; // rax
		  BSP *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Nullable_1_UnityEngine_Bounds_ v13; // [rsp+30h] [rbp-38h] BYREF
		  __int64 v14; // [rsp+80h] [rbp+18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5410, 0LL) )
		  {
		    root = this->fields.root;
		    if ( root )
		    {
		      v5 = HG::Rendering::Runtime::CSG::Node::Clone(root, 0LL);
		      z = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		      description = this->fields.description;
		      createDescription = this->fields._createDescription;
		      *(_OWORD *)&v13.hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		      v14 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		      v9 = (BSP *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		      v10 = v9;
		      if ( v9 )
		      {
		        *(_QWORD *)&v13.value.m_Extents.x = v14;
		        v13.value.m_Extents.z = z;
		        HG::Rendering::Runtime::CSG::BSP::BSP(v9, v5, &v13, description, createDescription, 0LL);
		        return v10;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(root, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5410, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1560(Patch, (Object *)this, 0LL);
		}
		
		private object[] CreateDescription(string operation, object[] existing, params object[] args) => default; // 0x0000000189C71A68-0x0000000189C71B68
		// Object[] CreateDescription(String, Object[], Object[])
		Object__Array *HG::Rendering::Runtime::CSG::BSP::CreateDescription(
		        BSP *this,
		        String *operation,
		        Object__Array *existing,
		        Object__Array *args,
		        MethodInfo *method)
		{
		  Object__Array *v9; // rbx
		  __int64 v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  IEnumerable_1_System_Object_ *v13; // rdi
		  IEnumerable_1_System_Object_ *v14; // rax
		  IEnumerable_1_System_Object_ *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v9 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5293, 0LL) )
		  {
		    if ( !this->fields._createDescription )
		      return v9;
		    v10 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		    v13 = (IEnumerable_1_System_Object_ *)v10;
		    if ( v10 )
		    {
		      sub_180031B10(v10, operation);
		      sub_180005370(v13, 0LL, operation);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		      v14 = HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>(
		              v13,
		              existing,
		              MethodInfo::HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>);
		      v15 = HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>(
		              v14,
		              args,
		              MethodInfo::HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>);
		      return System::Linq::Enumerable::ToArray<System::Object>(
		               v15,
		               MethodInfo::System::Linq::Enumerable::ToArray<System::Object>);
		    }
		LABEL_7:
		    sub_1800D8260(v12, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5293, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1531(
		           Patch,
		           (Object *)this,
		           (Object *)operation,
		           (Object *)existing,
		           (Object *)args,
		           0LL);
		}
		
		private Bounds? MeasureBounds(BSP bsp) => default; // 0x0000000189C72AA8-0x0000000189C72F44
		// Nullable`1[UnityEngine.Bounds] MeasureBounds(BSP)
		// Hidden C++ exception states: #wind=1
		Nullable_1_UnityEngine_Bounds_ *HG::Rendering::Runtime::CSG::BSP::MeasureBounds(
		        Nullable_1_UnityEngine_Bounds_ *__return_ptr retstr,
		        BSP *this,
		        BSP *bsp,
		        MethodInfo *method)
		{
		  Nullable_1_UnityEngine_Bounds_ *v6; // rbx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float z; // esi
		  IEnumerable_1_System_Object_ *Polygons; // r15
		  Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_System_Collections_Generic_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *_9__26_0; // rdi
		  Object *v12; // r14
		  Func_2_Object_Object_ *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v16; // rdx
		  VolumetricRenderer_VolumetricBounds *v17; // r8
		  Int32__Array **v18; // r9
		  IEnumerable_1_System_Object_ *v19; // r15
		  Func_2_HG_Rendering_Runtime_CSG_CSGVertex_UnityEngine_Vector3_ *_9__26_1; // rdi
		  Object *v21; // r14
		  Func_2_Object_UnityEngine_Vector3_ *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v25; // rdx
		  VolumetricRenderer_VolumetricBounds *v26; // r8
		  Int32__Array **v27; // r9
		  IEnumerable_1_UnityEngine_Vector3_ *v28; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rax
		  float v36; // r14d
		  char v37; // di
		  __int128 v38; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  MethodInfo *v43; // [rsp+20h] [rbp-108h]
		  MethodInfo *v44; // [rsp+28h] [rbp-100h]
		  __int64 v45; // [rsp+30h] [rbp-F8h] BYREF
		  int32_t v46; // [rsp+38h] [rbp-F0h]
		  _BYTE v47[28]; // [rsp+40h] [rbp-E8h] BYREF
		  Nullable_1_UnityEngine_Bounds_ v48; // [rsp+60h] [rbp-C8h] BYREF
		  Bounds v49; // [rsp+80h] [rbp-A8h] BYREF
		  _QWORD v50[2]; // [rsp+98h] [rbp-90h] BYREF
		  __int64 v51; // [rsp+A8h] [rbp-80h]
		  Vector3 v52; // [rsp+B0h] [rbp-78h] BYREF
		  Vector3 v53; // [rsp+C0h] [rbp-68h] BYREF
		  Vector3 v54; // [rsp+D0h] [rbp-58h] BYREF
		  Bounds v55; // [rsp+E0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v56; // [rsp+F8h] [rbp-30h] BYREF
		  _BYTE v57[16]; // [rsp+100h] [rbp-28h] BYREF
		
		  v6 = retstr;
		  if ( IFix::WrappersManagerImpl::IsPatched(5411, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5411, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v41, v40);
		    *v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1562(&v48, Patch, (Object *)this, (Object *)bsp, 0LL);
		  }
		  else
		  {
		    *(_OWORD *)&v49.m_Center.x = 0LL;
		    z = 0.0;
		    memset(&v48, 0, sizeof(v48));
		    if ( !bsp )
		      sub_1800D8260(v8, v7);
		    Polygons = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::BSP::get_Polygons(bsp, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
		    _9__26_0 = TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_0;
		    if ( !_9__26_0 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
		      v12 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9;
		      v13 = (Func_2_Object_Object_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGVertex>>);
		      _9__26_0 = (Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_System_Collections_Generic_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v13;
		      if ( !v13 )
		        sub_1800D8260(v15, v14);
		      System::Func<System::Object,System::Object>::Func(
		        v13,
		        v12,
		        MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_0 = _9__26_0;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_0,
		        v16,
		        v17,
		        v18,
		        v43,
		        v44,
		        v45,
		        v46,
		        *(float *)v47,
		        *(int32_t *)&v47[8],
		        v47[16],
		        v47[24],
		        *(MethodInfo **)&v48.hasValue);
		    }
		    v19 = System::Linq::Enumerable::SelectMany<System::Object,System::Object>(
		            Polygons,
		            (Func_2_Object_System_Collections_Generic_IEnumerable_1_System_Object_ *)_9__26_0,
		            MethodInfo::System::Linq::Enumerable::SelectMany<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGVertex>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
		    _9__26_1 = TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_1;
		    if ( !_9__26_1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
		      v21 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9;
		      v22 = (Func_2_Object_UnityEngine_Vector3_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
		      _9__26_1 = (Func_2_HG_Rendering_Runtime_CSG_CSGVertex_UnityEngine_Vector3_ *)v22;
		      if ( !v22 )
		        sub_1800D8260(v24, v23);
		      System::Func<System::Object,UnityEngine::Vector3>::Func(
		        v22,
		        v21,
		        MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_1,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_1 = _9__26_1;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c->static_fields->__9__26_1,
		        v25,
		        v26,
		        v27,
		        v43,
		        v44,
		        v45,
		        v46,
		        *(float *)v47,
		        *(int32_t *)&v47[8],
		        v47[16],
		        v47[24],
		        *(MethodInfo **)&v48.hasValue);
		    }
		    v28 = System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>(
		            (IEnumerable_1_UnityEngine_Vector3_ *)v19,
		            (Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *)_9__26_1,
		            MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
		    if ( !v28 )
		      sub_1800D8260(v30, v29);
		    v45 = sub_1800428A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>, v28);
		    v50[0] = 0LL;
		    v50[1] = &v45;
		    try
		    {
		      v37 = _mm_cvtsi128_si32((__m128i)0LL);
		      while ( 1 )
		      {
		        if ( !v45 )
		          sub_1800D8250(v32, v31);
		        if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		          break;
		        if ( !v45 )
		          sub_1800D8250(v34, v33);
		        v35 = sub_1802089F8(v57, 0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>, v45);
		        v51 = *(_QWORD *)v35;
		        v36 = *(float *)(v35 + 8);
		        if ( v37 )
		        {
		          System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		            (SyncSubPort *)&v55,
		            (Nullable_1_Beyond_Gameplay_RemoteFactory_SyncSubPort_ *)&v48,
		            MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		          *(_QWORD *)&v54.x = v51;
		          v54.z = v36;
		          *(Bounds *)v47 = v55;
		          HG::Rendering::Runtime::CSG::Extensions::IncludePoint(&v55, (Bounds *)v47, &v54, 0LL);
		        }
		        else
		        {
		          memset(&v49, 0, sizeof(v49));
		          *(_QWORD *)&v52.x = *(_QWORD *)v35;
		          v52.z = v36;
		          *(_QWORD *)&v53.x = *(_QWORD *)&v52.x;
		          v53.z = v36;
		          UnityEngine::Bounds::Bounds(&v49, &v53, &v52, 0LL);
		          *(_WORD *)&v47[1] = 0;
		          v47[3] = 0;
		          *(Bounds *)&v47[4] = v49;
		          v47[0] = 1;
		          *(_OWORD *)&v49.m_Center.x = *(_OWORD *)v47;
		          *(_OWORD *)&v48.hasValue = *(_OWORD *)v47;
		          *(_QWORD *)&v48.value.m_Extents.x = *(_QWORD *)&v47[16];
		          z = v49.m_Extents.z;
		          v48.value.m_Extents.z = v49.m_Extents.z;
		          v37 = _mm_cvtsi128_si32(*(__m128i *)v47);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v56 )
		    {
		      v50[0] = v56->ex;
		      sub_1801F6A10(v50);
		      v6 = retstr;
		      z = v48.value.m_Extents.z;
		      v38 = *(_OWORD *)&v48.hasValue;
		      goto LABEL_18;
		    }
		    sub_1801F6A10(v50);
		    v38 = *(_OWORD *)&v49.m_Center.x;
		LABEL_18:
		    *(_OWORD *)&v6->hasValue = v38;
		    *(_QWORD *)&v6->value.m_Extents.x = *(_QWORD *)&v48.value.m_Extents.x;
		    v6->value.m_Extents.z = z;
		  }
		  return v6;
		}
		
		public virtual BSP Transform(Matrix4x4 transformation, Vector3[] verts, Vector3[] normals) => default; // 0x0000000189C73160-0x0000000189C7379C
		// BSP Transform(Matrix4x4, Vector3[], Vector3[])
		BSP *HG::Rendering::Runtime::CSG::BSP::Transform(
		        BSP *this,
		        Matrix4x4 *transformation,
		        Vector3__Array *verts,
		        Vector3__Array *normals,
		        MethodInfo *method)
		{
		  __int64 v9; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v10; // rdx
		  Node_2 *root; // rcx
		  VolumetricRenderer_VolumetricBounds *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rdi
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
		  VolumetricRenderer_VolumetricBounds *v20; // r8
		  Int32__Array **v21; // r9
		  IEnumerable_1_System_Object_ *AllPolygons; // r14
		  Func_2_Object_Object_ *v23; // rax
		  Func_2_Object_Object_ *v24; // rbx
		  IEnumerable_1_System_Object_ *v25; // rax
		  __int128 v26; // xmm0
		  IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v27; // r15
		  __int64 v28; // xmm1_8
		  __int128 v29; // xmm6
		  __int128 v30; // xmm7
		  __int128 v31; // xmm8
		  __int128 v32; // xmm9
		  Bounds *v33; // rax
		  Object__Array *description; // r12
		  __int128 v35; // xmm6
		  __int64 v36; // xmm7_8
		  Object__Array *v37; // r14
		  __int64 v38; // rax
		  __int64 v39; // rbx
		  __int64 v40; // rbx
		  __int64 v41; // rbx
		  __int64 v42; // rbx
		  __int64 v43; // rbx
		  __int64 v44; // rbx
		  __int64 v45; // rbx
		  __int64 v46; // rbx
		  __int64 v47; // rbx
		  __int64 v48; // rbx
		  __int64 v49; // rbx
		  __int64 v50; // rbx
		  __int64 v51; // rbx
		  __int64 v52; // rbx
		  __int64 v53; // rbx
		  __int64 v54; // rbx
		  Object__Array *v55; // rdi
		  BSP *v56; // rax
		  BSP *v57; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  __int128 v62; // xmm1
		  MethodInfo *v63; // [rsp+28h] [rbp-A1h]
		  MethodInfo *v64; // [rsp+28h] [rbp-A1h]
		  MethodInfo *v65; // [rsp+30h] [rbp-99h]
		  MethodInfo *v66; // [rsp+30h] [rbp-99h]
		  int32_t v67; // [rsp+38h] [rbp-91h] BYREF
		  int32_t v68; // [rsp+40h] [rbp-89h]
		  Nullable_1_Beyond_Gameplay_RemoteFactory_SyncSubPort_ v69; // [rsp+48h] [rbp-81h] BYREF
		  Bounds v70; // [rsp+68h] [rbp-61h] BYREF
		  Matrix4x4 v71[2]; // [rsp+88h] [rbp-41h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5416, 0LL) )
		  {
		    v9 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0);
		    v14 = v9;
		    if ( v9 )
		    {
		      *(_QWORD *)(v9 + 16) = verts;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)(v9 + 16),
		        v10,
		        v12,
		        v13,
		        v63,
		        v65,
		        v67,
		        v68,
		        *(float *)&v69.hasValue,
		        v69.value.position.m_Y,
		        v69.value.direction.m_X,
		        v69.value.direction.m_Z,
		        *(MethodInfo **)&v70.m_Center.x);
		      v15 = *(_OWORD *)&transformation->m00;
		      *(_QWORD *)(v14 + 88) = normals;
		      v16 = *(_OWORD *)&transformation->m01;
		      *(_OWORD *)(v14 + 24) = v15;
		      v17 = *(_OWORD *)&transformation->m02;
		      *(_OWORD *)(v14 + 40) = v16;
		      v18 = *(_OWORD *)&transformation->m03;
		      *(_OWORD *)(v14 + 56) = v17;
		      *(_OWORD *)(v14 + 72) = v18;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)(v14 + 88),
		        v19,
		        v20,
		        v21,
		        v64,
		        v66,
		        v67,
		        v68,
		        *(float *)&v69.hasValue,
		        v69.value.position.m_Y,
		        v69.value.direction.m_X,
		        v69.value.direction.m_Z,
		        *(MethodInfo **)&v70.m_Center.x);
		      root = this->fields.root;
		      if ( root )
		      {
		        AllPolygons = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::Node::get_AllPolygons(root, 0LL);
		        v23 = (Func_2_Object_Object_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
		        v24 = v23;
		        if ( v23 )
		        {
		          System::Func<System::Object,System::Object>::Func(
		            v23,
		            (Object *)v14,
		            MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0::_Transform_b__0,
		            0LL);
		          v25 = System::Linq::Enumerable::Select<System::Object,System::Object>(
		                  AllPolygons,
		                  v24,
		                  MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
		          v26 = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		          v27 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v25;
		          v28 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		          v69.value.direction.m_Z = LODWORD(this->fields._Bounds_k__BackingField.value.m_Extents.z);
		          *(_OWORD *)&v69.hasValue = v26;
		          *(_QWORD *)&v69.value.direction.m_X = v28;
		          System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		            (SyncSubPort *)&v70,
		            &v69,
		            MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		          v29 = *(_OWORD *)(v14 + 24);
		          v30 = *(_OWORD *)(v14 + 40);
		          v31 = *(_OWORD *)(v14 + 56);
		          v32 = *(_OWORD *)(v14 + 72);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		          *(_OWORD *)&v69.hasValue = *(_OWORD *)&v70.m_Center.x;
		          *(_OWORD *)&v71[0].m00 = v29;
		          *(_OWORD *)&v71[0].m01 = v30;
		          *(_OWORD *)&v71[0].m02 = v31;
		          *(_OWORD *)&v71[0].m03 = v32;
		          *(_QWORD *)&v69.value.direction.m_X = *(_QWORD *)&v70.m_Extents.y;
		          v33 = HG::Rendering::Runtime::CSG::Extensions::Transform(&v70, (Bounds *)&v69, v71, 0LL);
		          description = this->fields.description;
		          v35 = *(_OWORD *)&v33->m_Center.x;
		          v36 = *(_QWORD *)&v33->m_Extents.y;
		          v37 = (Object__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Object, 16LL);
		          v67 = *(_DWORD *)(v14 + 24);
		          v38 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		          v39 = v38;
		          if ( v37 )
		          {
		            sub_180031B10(v37, v38);
		            sub_180005370(v37, 0LL, v39);
		            v67 = *(_DWORD *)(v14 + 40);
		            v40 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v40);
		            sub_180005370(v37, 1LL, v40);
		            v67 = *(_DWORD *)(v14 + 56);
		            v41 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v41);
		            sub_180005370(v37, 2LL, v41);
		            v67 = *(_DWORD *)(v14 + 72);
		            v42 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v42);
		            sub_180005370(v37, 3LL, v42);
		            v67 = *(_DWORD *)(v14 + 28);
		            v43 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v43);
		            sub_180005370(v37, 4LL, v43);
		            v67 = *(_DWORD *)(v14 + 44);
		            v44 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v44);
		            sub_180005370(v37, 5LL, v44);
		            v67 = *(_DWORD *)(v14 + 60);
		            v45 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v45);
		            sub_180005370(v37, 6LL, v45);
		            v67 = *(_DWORD *)(v14 + 76);
		            v46 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v46);
		            sub_180005370(v37, 7LL, v46);
		            v67 = *(_DWORD *)(v14 + 32);
		            v47 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v47);
		            sub_180005370(v37, 8LL, v47);
		            v67 = *(_DWORD *)(v14 + 48);
		            v48 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v48);
		            sub_180005370(v37, 9LL, v48);
		            v67 = *(_DWORD *)(v14 + 64);
		            v49 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v49);
		            sub_180005370(v37, 10LL, v49);
		            v67 = *(_DWORD *)(v14 + 80);
		            v50 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v50);
		            sub_180005370(v37, 11LL, v50);
		            v67 = *(_DWORD *)(v14 + 36);
		            v51 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v51);
		            sub_180005370(v37, 12LL, v51);
		            v67 = *(_DWORD *)(v14 + 52);
		            v52 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v52);
		            sub_180005370(v37, 13LL, v52);
		            v67 = *(_DWORD *)(v14 + 68);
		            v53 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v53);
		            sub_180005370(v37, 14LL, v53);
		            v67 = *(_DWORD *)(v14 + 84);
		            v54 = il2cpp_value_box_0(TypeInfo::System::Single, &v67);
		            sub_180031B10(v37, v54);
		            sub_180005370(v37, 15LL, v54);
		            v55 = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
		                    this,
		                    (String *)"transform",
		                    description,
		                    v37,
		                    0LL);
		            v56 = (BSP *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		            v57 = v56;
		            if ( v56 )
		            {
		              *(_OWORD *)&v69.hasValue = v35;
		              *(_QWORD *)&v69.value.direction.m_X = v36;
		              HG::Rendering::Runtime::CSG::BSP::BSP(v56, v27, (Bounds *)&v69, v55, 1, 0LL);
		              HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
		              return v57;
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(root, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5416, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  v60 = *(_OWORD *)&transformation->m01;
		  *(_OWORD *)&v71[0].m00 = *(_OWORD *)&transformation->m00;
		  v61 = *(_OWORD *)&transformation->m02;
		  *(_OWORD *)&v71[0].m01 = v60;
		  v62 = *(_OWORD *)&transformation->m03;
		  *(_OWORD *)&v71[0].m02 = v61;
		  *(_OWORD *)&v71[0].m03 = v62;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1566(
		           Patch,
		           (Object *)this,
		           v71,
		           (Object *)verts,
		           (Object *)normals,
		           0LL);
		}
		
		public CSGVertex transformVertex(CSGVertex v, Matrix4x4 transformation, Vector3[] verts, Vector3[] normals) => default; // 0x0000000189C75008-0x0000000189C75164
		// CSGVertex transformVertex(CSGVertex, Matrix4x4, Vector3[], Vector3[])
		CSGVertex *HG::Rendering::Runtime::CSG::BSP::transformVertex(
		        BSP *this,
		        CSGVertex *v,
		        Matrix4x4 *transformation,
		        Vector3__Array *verts,
		        Vector3__Array *normals,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector3 *v12; // rax
		  float z; // ecx
		  Vector3 *v14; // rax
		  __int64 v15; // xmm0_8
		  float v16; // ecx
		  CSGVertex *result; // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Vector3 v21; // [rsp+48h] [rbp-19h] BYREF
		  Vector3 v22; // [rsp+58h] [rbp-9h] BYREF
		  Matrix4x4 v23; // [rsp+68h] [rbp+7h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5426, 0LL) )
		  {
		    if ( v )
		    {
		      if ( verts )
		      {
		        sub_180049C60(verts, &v21, v->fields.id);
		        v22 = v21;
		        v12 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v21, transformation, &v22, 0LL);
		        z = v12->z;
		        *(_QWORD *)&v->fields.Position.x = *(_QWORD *)&v12->x;
		        v->fields.Position.z = z;
		        Patch = (ILFixDynamicMethodWrapper_2 *)normals;
		        if ( normals )
		        {
		          sub_180049C60(normals, &v22, v->fields.id);
		          v21 = v22;
		          v14 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v22, transformation, &v21, 0LL);
		          v15 = *(_QWORD *)&v14->x;
		          v16 = v14->z;
		          result = v;
		          *(_QWORD *)&v->fields.Normal.x = v15;
		          v->fields.Normal.z = v16;
		          return result;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5426, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  v18 = *(_OWORD *)&transformation->m01;
		  *(_OWORD *)&v23.m00 = *(_OWORD *)&transformation->m00;
		  v19 = *(_OWORD *)&transformation->m02;
		  *(_OWORD *)&v23.m01 = v18;
		  v20 = *(_OWORD *)&transformation->m03;
		  *(_OWORD *)&v23.m02 = v19;
		  *(_OWORD *)&v23.m03 = v20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1567(
		           Patch,
		           (Object *)this,
		           (Object *)v,
		           &v23,
		           (Object *)verts,
		           (Object *)normals,
		           0LL);
		}
		
		private void InvokeChange() {} // 0x0000000189C72A4C-0x0000000189C72AA8
		// Void InvokeChange()
		void HG::Rendering::Runtime::CSG::BSP::InvokeChange(BSP *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5294, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5294, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.OnChange )
		  {
		    sub_182EE41F0(this->fields.OnChange);
		  }
		}
		
		public virtual void Union(BSP bInput) {} // 0x0000000189C7379C-0x0000000189C73E38
		// Void Union(BSP)
		void HG::Rendering::Runtime::CSG::BSP::Union(BSP *this, BSP *bInput, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Node_2 *v6; // rcx
		  Node_2 *root; // r14
		  Node_2 *v8; // rax
		  Node_2 *v9; // rsi
		  IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *AllPolygons; // rax
		  float z; // eax
		  __int64 v12; // xmm0_8
		  float v13; // eax
		  __int128 v14; // xmm1
		  __int64 v15; // xmm1_8
		  Vector3 *min; // rax
		  __int128 v17; // xmm0
		  __int64 v18; // xmm1_8
		  __m128 x_low; // xmm8
		  float x; // xmm7_4
		  float v21; // eax
		  __int64 v22; // xmm1_8
		  Vector3 *v23; // rax
		  __int128 v24; // xmm0
		  __int64 v25; // xmm1_8
		  __m128 y_low; // xmm6
		  Vector3 *v27; // rax
		  __m128 v28; // xmm0
		  __m128 v29; // xmm11
		  float v30; // eax
		  __int64 v31; // xmm1_8
		  Vector3 *v32; // rax
		  __int128 v33; // xmm0
		  __int64 v34; // xmm2_8
		  __m128 v35; // xmm0
		  __m128 v36; // xmm10
		  Vector3 *v37; // rax
		  float v38; // eax
		  __int64 v39; // xmm2_8
		  float v40; // xmm9_4
		  Vector3 *max; // rax
		  __int128 v42; // xmm0
		  __int64 v43; // xmm1_8
		  __m128 v44; // xmm6
		  Vector3 *v45; // rax
		  __m128 v46; // xmm0
		  float v47; // eax
		  __int64 v48; // xmm2_8
		  __m128 v49; // xmm8
		  Vector3 *v50; // rax
		  __int128 v51; // xmm0
		  __int64 v52; // xmm1_8
		  __m128 v53; // xmm6
		  Vector3 *v54; // rax
		  __m128 v55; // xmm0
		  float v56; // eax
		  __int64 v57; // xmm2_8
		  __m128 v58; // xmm7
		  Vector3 *v59; // rax
		  __int128 v60; // xmm0
		  __int64 v61; // xmm1_8
		  Vector3 *v62; // rax
		  __int64 v63; // xmm1_8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v64; // rdx
		  VolumetricRenderer_VolumetricBounds *v65; // r8
		  Int32__Array **v66; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+28h] [rbp-99h]
		  MethodInfo *v69; // [rsp+30h] [rbp-91h]
		  SyncSubPort v70; // [rsp+38h] [rbp-89h] BYREF
		  int32_t v71; // [rsp+50h] [rbp-71h]
		  Vector3 v72; // [rsp+58h] [rbp-69h] BYREF
		  SyncSubPort v73; // [rsp+68h] [rbp-59h] BYREF
		  Nullable_1_Beyond_Gameplay_RemoteFactory_SyncSubPort_ v74[4]; // [rsp+80h] [rbp-41h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5253, 0LL) )
		  {
		    root = this->fields.root;
		    if ( bInput )
		    {
		      v6 = bInput->fields.root;
		      if ( v6 )
		      {
		        v8 = HG::Rendering::Runtime::CSG::Node::Clone(v6, 0LL);
		        v9 = v8;
		        if ( root )
		        {
		          HG::Rendering::Runtime::CSG::Node::ClipTo(root, v8, 0LL);
		          if ( v9 )
		          {
		            HG::Rendering::Runtime::CSG::Node::ClipTo(v9, root, 0LL);
		            HG::Rendering::Runtime::CSG::Node::Invert(v9, 0LL);
		            HG::Rendering::Runtime::CSG::Node::ClipTo(v9, root, 0LL);
		            HG::Rendering::Runtime::CSG::Node::Invert(v9, 0LL);
		            AllPolygons = HG::Rendering::Runtime::CSG::Node::get_AllPolygons(v9, 0LL);
		            HG::Rendering::Runtime::CSG::Node::Build(root, AllPolygons, 0LL);
		            z = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		            *(_QWORD *)&v74[0].value.direction.m_X = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		            v12 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		            *(float *)&v74[0].value.direction.m_Z = z;
		            v13 = bInput->fields._Bounds_k__BackingField.value.m_Extents.z;
		            if ( this->fields._Bounds_k__BackingField.hasValue )
		            {
		              v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		              v13 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		              *(_QWORD *)&v74[0].value.direction.m_X = v12;
		              if ( bInput->fields._Bounds_k__BackingField.hasValue )
		              {
		                v15 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v13;
		                *(_QWORD *)&v74[0].value.direction.m_X = v15;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                min = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL);
		                v17 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v18 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                x_low = (__m128)LODWORD(min->x);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v17;
		                *(_QWORD *)&v74[0].value.direction.m_X = v18;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                x = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL)->x;
		                sub_1800036A0(TypeInfo::System::Math);
		                v21 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		                v22 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v21;
		                *(_QWORD *)&v74[0].value.direction.m_X = v22;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v23 = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL);
		                v24 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v25 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                y_low = (__m128)LODWORD(v23->y);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v24;
		                *(_QWORD *)&v74[0].value.direction.m_X = v25;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v27 = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL);
		                v28 = y_low;
		                v28.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], v27->y, 0LL);
		                v29 = v28;
		                v30 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		                v31 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v30;
		                *(_QWORD *)&v74[0].value.direction.m_X = v31;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v32 = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL);
		                v33 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v34 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                y_low.m128_i32[0] = LODWORD(v32->z);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v33;
		                *(_QWORD *)&v74[0].value.direction.m_X = v34;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v35 = x_low;
		                v70 = v73;
		                v35.m128_f32[0] = System::Math::Min(x_low.m128_f32[0], x, 0LL);
		                v36 = v35;
		                v37 = UnityEngine::Bounds::get_min(&v72, (Bounds *)&v70, 0LL);
		                v35.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], v37->z, 0LL);
		                v38 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		                v39 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v40 = v35.m128_f32[0];
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v38;
		                *(_QWORD *)&v74[0].value.direction.m_X = v39;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                max = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v42 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v43 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v44 = (__m128)LODWORD(max->x);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v42;
		                *(_QWORD *)&v74[0].value.direction.m_X = v43;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v45 = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v46 = v44;
		                v46.m128_f32[0] = System::Math::Max(v44.m128_f32[0], v45->x, 0LL);
		                v47 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		                v48 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v49 = v46;
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v47;
		                *(_QWORD *)&v74[0].value.direction.m_X = v48;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v50 = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v51 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v52 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v53 = (__m128)LODWORD(v50->y);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v51;
		                *(_QWORD *)&v74[0].value.direction.m_X = v52;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v54 = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v55 = v53;
		                v55.m128_f32[0] = System::Math::Max(v53.m128_f32[0], v54->y, 0LL);
		                v56 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		                v57 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v58 = v55;
		                *(_OWORD *)&v74[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		                *(float *)&v74[0].value.direction.m_Z = v56;
		                *(_QWORD *)&v74[0].value.direction.m_X = v57;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v59 = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v60 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		                v61 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		                v53.m128_i32[0] = LODWORD(v59->z);
		                v74[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		                *(_OWORD *)&v74[0].hasValue = v60;
		                *(_QWORD *)&v74[0].value.direction.m_X = v61;
		                System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		                  &v73,
		                  v74,
		                  MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		                v70 = v73;
		                v62 = UnityEngine::Bounds::get_max(&v72, (Bounds *)&v70, 0LL);
		                v70.position.m_Z = System::Math::Max(v53.m128_f32[0], v62->z, 0LL);
		                v72.z = v40;
		                *(_QWORD *)&v70.position.m_X = _mm_unpacklo_ps(v49, v58).m128_u64[0];
		                memset(&v73, 0, sizeof(v73));
		                *(_QWORD *)&v72.x = _mm_unpacklo_ps(v36, v29).m128_u64[0];
		                UnityEngine::Bounds::Bounds((Bounds *)&v73, &v72, (Vector3 *)&v70, 0LL);
		                *(_WORD *)(&v74[0].hasValue + 1) = 0;
		                v74[0].value = v73;
		                *(&v74[0].hasValue + 3) = 0;
		                v63 = *(_QWORD *)&v73.direction.m_X;
		                v13 = *(float *)&v73.direction.m_Z;
		                v74[0].hasValue = 1;
		                *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v74[0].hasValue;
		                *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = v63;
		                goto LABEL_12;
		              }
		              v14 = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		              v12 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		            }
		            else
		            {
		              v14 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		            }
		            *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = v14;
		            *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = v12;
		LABEL_12:
		            this->fields._Bounds_k__BackingField.value.m_Extents.z = v13;
		            this->fields.description = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
		                                         this,
		                                         (String *)"union",
		                                         this->fields.description,
		                                         bInput->fields.description,
		                                         0LL);
		            sub_18002D1B0(
		              (VolumetricRenderer_VolumetricRenderItem *)&this->fields.description,
		              v64,
		              v65,
		              v66,
		              methoda,
		              v69,
		              v70.position.m_X,
		              v70.position.m_Z,
		              *(float *)&v70.direction.m_Y,
		              v71,
		              SLOBYTE(v72.x),
		              SLOBYTE(v72.z),
		              *(MethodInfo **)&v73.position.m_X);
		            HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5253, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)bInput,
		    0LL);
		}
		
		[IDTag(1)]
		public static BSP fromMesh(Mesh m, int objID) => default; // 0x0000000189C740A8-0x0000000189C746F4
		// BSP fromMesh(Mesh, Int32)
		BSP *HG::Rendering::Runtime::CSG::BSP::fromMesh(Mesh *m, int32_t objID, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v5; // rax
		  MethodInfo *v6; // rdx
		  __int64 v7; // rcx
		  List_1_System_Object_ *v8; // r13
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v9; // rax
		  List_1_System_Object_ *v10; // r15
		  int32_t v11; // ebx
		  Int32__Array *Triangles; // r14
		  List_1_System_Int32_ *v13; // rax
		  Object *v14; // rsi
		  int32_t i; // r14d
		  List_1_System_Int32_ *v16; // rsi
		  int32_t v17; // ebx
		  Vector3__Array *vertices; // r12
		  int32_t v19; // eax
		  Vector3__Array *normals; // r12
		  int32_t v21; // eax
		  Vector2__Array *uv; // r12
		  int32_t v23; // eax
		  int32_t v24; // r12d
		  Object *v25; // rax
		  Vector3__Array *v26; // r12
		  int32_t v27; // eax
		  Vector3__Array *v28; // r12
		  int32_t v29; // eax
		  Vector2__Array *v30; // r12
		  int32_t v31; // eax
		  int32_t v32; // r12d
		  Object *v33; // rax
		  Vector3__Array *v34; // r12
		  int32_t v35; // eax
		  Vector3__Array *v36; // r12
		  int32_t v37; // eax
		  Vector2__Array *v38; // r12
		  int32_t v39; // eax
		  int32_t v40; // r12d
		  Object *v41; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v42; // rax
		  List_1_System_Object_ *v43; // r12
		  Object *v44; // rax
		  Vector3 *one; // rax
		  __int64 v46; // xmm1_8
		  Animator *v47; // rdx
		  int32_t v48; // r8d
		  MethodInfo *v49; // r9
		  Vector3 *Vector; // rax
		  __int64 v51; // xmm1_8
		  __int64 v52; // rax
		  Object__Array *v53; // rdi
		  BSP *v54; // rax
		  BSP *v55; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 m_Center; // [rsp+30h] [rbp-D0h] BYREF
		  Object *v59; // [rsp+40h] [rbp-C0h]
		  Bounds v60; // [rsp+50h] [rbp-B0h] BYREF
		  Bounds v61; // [rsp+70h] [rbp-90h] BYREF
		  Vector3 v62; // [rsp+88h] [rbp-78h] BYREF
		  Vector2 v63; // [rsp+98h] [rbp-68h] BYREF
		  Vector2 v64; // [rsp+A0h] [rbp-60h] BYREF
		  Object *item; // [rsp+A8h] [rbp-58h]
		  Object *v66; // [rsp+B0h] [rbp-50h]
		  Vector3 v67; // [rsp+B8h] [rbp-48h] BYREF
		  Vector3 v68; // [rsp+C8h] [rbp-38h] BYREF
		  Vector3 v69; // [rsp+E0h] [rbp-20h] BYREF
		  Vector3 v70; // [rsp+F0h] [rbp-10h] BYREF
		  Vector3 v71; // [rsp+100h] [rbp+0h] BYREF
		  Vector3 v72; // [rsp+110h] [rbp+10h] BYREF
		  Vector3 v73; // [rsp+120h] [rbp+20h] BYREF
		  Vector3 v74; // [rsp+130h] [rbp+30h] BYREF
		  Vector2 v76; // [rsp+198h] [rbp+98h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5427, 0LL) )
		  {
		    v5 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v8 = (List_1_System_Object_ *)v5;
		    if ( v5 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v5,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		      v9 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
		      v10 = (List_1_System_Object_ *)v9;
		      if ( v9 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v9,
		          MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
		        v11 = 0;
		        if ( m )
		        {
		          while ( v11 < UnityEngine::Mesh::get_subMeshCount(m, 0LL) )
		          {
		            Triangles = UnityEngine::Mesh::GetTriangles(m, v11, 0LL);
		            v13 = (List_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		            v14 = (Object *)v13;
		            if ( !v13 )
		              goto LABEL_32;
		            System::Collections::Generic::List<int>::List(
		              v13,
		              (IEnumerable_1_System_Int32_ *)Triangles,
		              MethodInfo::System::Collections::Generic::List<int>::List);
		            sub_182F01190(v10, v14);
		            ++v11;
		          }
		          for ( i = 0; i < v10->fields._size; ++i )
		          {
		            v16 = (List_1_System_Int32_ *)System::Collections::Generic::List<System::Object>::get_Item(
		                                            v10,
		                                            i,
		                                            MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
		            v17 = 2;
		            if ( !v16 )
		              goto LABEL_32;
		            while ( v17 - 2 < v16->fields._size )
		            {
		              vertices = UnityEngine::Mesh::get_vertices(m, 0LL);
		              v19 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 2,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !vertices )
		                goto LABEL_32;
		              sub_180049C60(vertices, &v68, v19);
		              normals = UnityEngine::Mesh::get_normals(m, 0LL);
		              v21 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 2,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !normals )
		                goto LABEL_32;
		              sub_180049C60(normals, &v67, v21);
		              uv = UnityEngine::Mesh::get_uv(m, 0LL);
		              v23 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 2,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !uv )
		                goto LABEL_32;
		              sub_1800473A0(uv, &v76, v23);
		              v24 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 2,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              v25 = (Object *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		              item = v25;
		              if ( !v25 )
		                goto LABEL_32;
		              v69 = v67;
		              v70 = v68;
		              HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex((CSGVertex *)v25, &v70, &v69, v76, v24, 0LL);
		              v26 = UnityEngine::Mesh::get_vertices(m, 0LL);
		              v27 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 1,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v26 )
		                goto LABEL_32;
		              sub_180049C60(v26, &v72, v27);
		              v28 = UnityEngine::Mesh::get_normals(m, 0LL);
		              v29 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 1,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v28 )
		                goto LABEL_32;
		              sub_180049C60(v28, &v71, v29);
		              v30 = UnityEngine::Mesh::get_uv(m, 0LL);
		              v31 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 1,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v30 )
		                goto LABEL_32;
		              sub_1800473A0(v30, &v63, v31);
		              v32 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17 - 1,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              v33 = (Object *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		              v66 = v33;
		              if ( !v33 )
		                goto LABEL_32;
		              v73 = v71;
		              v74 = v72;
		              HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex((CSGVertex *)v33, &v74, &v73, v63, v32, 0LL);
		              v34 = UnityEngine::Mesh::get_vertices(m, 0LL);
		              v35 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v34 )
		                goto LABEL_32;
		              sub_180049C60(v34, &v62, v35);
		              v36 = UnityEngine::Mesh::get_normals(m, 0LL);
		              v37 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v36 )
		                goto LABEL_32;
		              sub_180049C60(v36, &v61, v37);
		              v38 = UnityEngine::Mesh::get_uv(m, 0LL);
		              v39 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              if ( !v38 )
		                goto LABEL_32;
		              sub_1800473A0(v38, &v64, v39);
		              v40 = System::Collections::Generic::List<int>::get_Item(
		                      v16,
		                      v17,
		                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
		              v41 = (Object *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		              v59 = v41;
		              if ( !v41 )
		                goto LABEL_32;
		              m_Center = v61.m_Center;
		              v60.m_Center = v62;
		              HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
		                (CSGVertex *)v41,
		                &v60.m_Center,
		                &m_Center,
		                v64,
		                v40,
		                0LL);
		              v42 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
		              v43 = (List_1_System_Object_ *)v42;
		              if ( !v42 )
		                goto LABEL_32;
		              System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		                v42,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
		              sub_182F01190(v43, item);
		              sub_182F01190(v43, v66);
		              sub_182F01190(v43, v59);
		              v44 = (Object *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
		              v59 = v44;
		              if ( !v44 )
		                goto LABEL_32;
		              HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		                (CSGPolygon *)v44,
		                (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v43,
		                objID,
		                i,
		                0LL);
		              sub_182F01190(v8, v59);
		              v17 += 3;
		            }
		          }
		          memset(&v61, 0, sizeof(v61));
		          one = UnityEngine::Vector3::get_one(&m_Center, v6);
		          v46 = *(_QWORD *)&one->x;
		          *(float *)&one = one->z;
		          *(_QWORD *)&v60.m_Center.x = v46;
		          LODWORD(v60.m_Center.z) = (_DWORD)one;
		          Vector = UnityEngine::Animator::GetVector(&v62, v47, v48, v49);
		          v51 = *(_QWORD *)&Vector->x;
		          *(float *)&Vector = Vector->z;
		          *(_QWORD *)&m_Center.x = v51;
		          LODWORD(m_Center.z) = (_DWORD)Vector;
		          UnityEngine::Bounds::Bounds(&v61, &m_Center, &v60.m_Center, 0LL);
		          v52 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		          v53 = (Object__Array *)v52;
		          if ( v52 )
		          {
		            sub_180031B10(v52, "Mesh");
		            sub_180005370(v53, 0LL, "Mesh");
		            v54 = (BSP *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		            v55 = v54;
		            if ( v54 )
		            {
		              v60 = v61;
		              HG::Rendering::Runtime::CSG::BSP::BSP(
		                v54,
		                (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
		                &v60,
		                v53,
		                1,
		                0LL);
		              return v55;
		            }
		          }
		        }
		      }
		    }
		LABEL_32:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5427, 0LL);
		  if ( !Patch )
		    goto LABEL_32;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1568(Patch, (Object *)m, objID, 0LL);
		}
		
		[IDTag(0)]
		public static BSP fromMesh(Mesh m, Transform transform, Transform transform2, int objID, int previous = 0 /* Metadata: 0x023044D1 */) => default; // 0x0000000189C746F4-0x0000000189C74EE8
		// BSP fromMesh(Mesh, Transform, Transform, Int32, Int32)
		BSP *HG::Rendering::Runtime::CSG::BSP::fromMesh(
		        Mesh *m,
		        Transform *transform,
		        Transform *transform2,
		        int32_t objID,
		        int32_t previous,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Int32__Array *triangles; // r15
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v13; // rax
		  MonitorData *v14; // r14
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  VolumetricRenderer_VolumetricBounds *v16; // r8
		  Int32__Array **v17; // r9
		  int32_t subMeshCount; // r14d
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v19; // rax
		  List_1_System_Object_ *v20; // r15
		  Matrix4x4__StaticFields *v21; // rcx
		  __int128 v22; // xmm1
		  BSP__StaticFields *v23; // rcx
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v27; // xmm1
		  Matrix4x4__StaticFields *v28; // rcx
		  __int128 v29; // xmm0
		  Matrix4x4 *worldToLocalMatrix; // rax
		  __int128 v31; // xmm1
		  BSP__StaticFields *v32; // rcx
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  Vector3__Array *normals; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v36; // rdx
		  VolumetricRenderer_VolumetricBounds *v37; // r8
		  Int32__Array **v38; // r9
		  Vector2__Array *uv; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v40; // rdx
		  VolumetricRenderer_VolumetricBounds *v41; // r8
		  Int32__Array **v42; // r9
		  Vector3__Array *vertices; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v44; // rdx
		  VolumetricRenderer_VolumetricBounds *v45; // r8
		  Int32__Array **v46; // r9
		  int32_t i; // ebx
		  Int32__Array *v48; // r14
		  List_1_System_Int32_ *v49; // rax
		  Object *v50; // rsi
		  int32_t j; // r14d
		  Object *Item; // r15
		  int32_t ProcessorCount; // eax
		  int monitor; // ebx
		  int v55; // r13d
		  __int64 v56; // rdi
		  int v57; // esi
		  int v58; // r12d
		  __int64 v59; // rax
		  VolumetricRenderer_VolumetricBounds *v60; // r8
		  Int32__Array **v61; // r9
		  __int64 v62; // rbx
		  ParameterizedThreadStart *v63; // rax
		  ParameterizedThreadStart *v64; // r13
		  Thread *v65; // rax
		  __int64 v66; // rcx
		  int v67; // r12d
		  __int64 v68; // rax
		  VolumetricRenderer_VolumetricBounds *v69; // r8
		  Int32__Array **v70; // r9
		  __int64 v71; // rbx
		  ParameterizedThreadStart *v72; // rax
		  ParameterizedThreadStart *v73; // r12
		  Thread *v74; // rax
		  Thread *v75; // r15
		  unsigned int k; // ebx
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons; // rsi
		  MethodInfo *v78; // rdx
		  Vector3 *one; // rax
		  __int64 v80; // xmm1_8
		  Animator *v81; // rdx
		  int32_t v82; // r8d
		  MethodInfo *v83; // r9
		  Vector3 *Vector; // rax
		  __int64 v85; // xmm1_8
		  __int64 v86; // rax
		  Object__Array *v87; // rbx
		  BSP *v88; // rax
		  BSP *v89; // rdi
		  MethodInfo *P3; // [rsp+28h] [rbp-A9h]
		  MethodInfo *P3a; // [rsp+28h] [rbp-A9h]
		  MethodInfo *P3c; // [rsp+28h] [rbp-A9h]
		  MethodInfo *P3d; // [rsp+28h] [rbp-A9h]
		  MethodInfo *P3b; // [rsp+28h] [rbp-A9h]
		  MethodInfo *P4; // [rsp+30h] [rbp-A1h]
		  MethodInfo *P4a; // [rsp+30h] [rbp-A1h]
		  MethodInfo *P4c; // [rsp+30h] [rbp-A1h]
		  MethodInfo *P4d; // [rsp+30h] [rbp-A1h]
		  MethodInfo *P4b; // [rsp+30h] [rbp-A1h]
		  int32_t v101; // [rsp+38h] [rbp-99h]
		  int32_t v102; // [rsp+38h] [rbp-99h]
		  int32_t v103; // [rsp+38h] [rbp-99h]
		  int32_t v104; // [rsp+38h] [rbp-99h]
		  int32_t v105; // [rsp+38h] [rbp-99h]
		  int32_t v106; // [rsp+40h] [rbp-91h]
		  __int128 v107; // [rsp+48h] [rbp-89h] BYREF
		  __int128 v108; // [rsp+58h] [rbp-79h] BYREF
		  Bounds v109; // [rsp+68h] [rbp-69h] BYREF
		  int v110; // [rsp+80h] [rbp-51h]
		  int v111; // [rsp+84h] [rbp-4Dh]
		  Bounds v112; // [rsp+88h] [rbp-49h] BYREF
		  Vector3 v113; // [rsp+A8h] [rbp-29h] BYREF
		  Matrix4x4 v114; // [rsp+B8h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5251, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5251, 0LL);
		    if ( !Patch )
		      goto LABEL_55;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1518(
		             Patch,
		             (Object *)m,
		             (Object *)transform,
		             (Object *)transform2,
		             objID,
		             previous,
		             0LL);
		  }
		  else
		  {
		    if ( !m )
		      goto LABEL_55;
		    triangles = UnityEngine::Mesh::get_triangles(m, 0LL);
		    if ( !triangles )
		      goto LABEL_55;
		    v13 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v14 = (MonitorData *)v13;
		    if ( !v13 )
		      goto LABEL_55;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v13,
		      triangles->max_length.size,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		    static_fields->monitor = v14;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->polygons,
		      static_fields,
		      v16,
		      v17,
		      P3,
		      P4,
		      v101,
		      v106,
		      *(float *)&v107,
		      SDWORD2(v107),
		      v108,
		      SBYTE8(v108),
		      *(MethodInfo **)&v109.m_Center.x);
		    subMeshCount = UnityEngine::Mesh::get_subMeshCount(m, 0LL);
		    v19 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
		    *(_QWORD *)&v113.x = v19;
		    v20 = (List_1_System_Object_ *)v19;
		    if ( !v19 )
		      goto LABEL_55;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v19,
		      subMeshCount,
		      MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)transform, 0LL, 0LL) )
		    {
		      if ( !transform )
		        goto LABEL_55;
		      localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v114, transform, 0LL);
		      *(_OWORD *)&v109.m_Center.x = *(_OWORD *)&localToWorldMatrix->m00;
		      *(_OWORD *)&v112.m_Center.x = *(_OWORD *)&localToWorldMatrix->m01;
		      v108 = *(_OWORD *)&localToWorldMatrix->m02;
		      v107 = *(_OWORD *)&localToWorldMatrix->m03;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		      v27 = *(_OWORD *)&v112.m_Center.x;
		      v23 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      *(_OWORD *)&v23->matrix.m00 = *(_OWORD *)&v109.m_Center.x;
		      v24 = v108;
		      *(_OWORD *)&v23->matrix.m01 = v27;
		      v25 = v107;
		    }
		    else
		    {
		      v21 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v108 = *(_OWORD *)&v21->identityMatrix.m00;
		      v107 = *(_OWORD *)&v21->identityMatrix.m01;
		      *(_OWORD *)&v112.m_Center.x = *(_OWORD *)&v21->identityMatrix.m02;
		      *(_OWORD *)&v109.m_Center.x = *(_OWORD *)&v21->identityMatrix.m03;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		      v22 = v107;
		      v23 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      *(_OWORD *)&v23->matrix.m00 = v108;
		      v24 = *(_OWORD *)&v112.m_Center.x;
		      *(_OWORD *)&v23->matrix.m01 = v22;
		      v25 = *(_OWORD *)&v109.m_Center.x;
		    }
		    *(_OWORD *)&v23->matrix.m02 = v24;
		    *(_OWORD *)&v23->matrix.m03 = v25;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)transform2, 0LL, 0LL) )
		    {
		      if ( !transform2 )
		        goto LABEL_55;
		      worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(&v114, transform2, 0LL);
		      *(_OWORD *)&v109.m_Center.x = *(_OWORD *)&worldToLocalMatrix->m00;
		      *(_OWORD *)&v112.m_Center.x = *(_OWORD *)&worldToLocalMatrix->m01;
		      v108 = *(_OWORD *)&worldToLocalMatrix->m02;
		      v29 = *(_OWORD *)&worldToLocalMatrix->m03;
		    }
		    else
		    {
		      v28 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      *(_OWORD *)&v109.m_Center.x = *(_OWORD *)&v28->identityMatrix.m00;
		      *(_OWORD *)&v112.m_Center.x = *(_OWORD *)&v28->identityMatrix.m01;
		      v108 = *(_OWORD *)&v28->identityMatrix.m02;
		      v29 = *(_OWORD *)&v28->identityMatrix.m03;
		    }
		    v107 = v29;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    v31 = *(_OWORD *)&v112.m_Center.x;
		    v32 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		    *(_OWORD *)&v32->matrix2.m00 = *(_OWORD *)&v109.m_Center.x;
		    v33 = v108;
		    *(_OWORD *)&v32->matrix2.m01 = v31;
		    v34 = v107;
		    *(_OWORD *)&v32->matrix2.m02 = v33;
		    *(_OWORD *)&v32->matrix2.m03 = v34;
		    normals = UnityEngine::Mesh::get_normals(m, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    v36 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		    v36[1].fields._._.invoke_impl = normals;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->normals,
		      v36,
		      v37,
		      v38,
		      P3a,
		      P4a,
		      v102,
		      v106,
		      *(float *)&v107,
		      SDWORD2(v107),
		      v108,
		      SBYTE8(v108),
		      *(MethodInfo **)&v109.m_Center.x);
		    uv = UnityEngine::Mesh::get_uv(m, 0LL);
		    v40 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		    v40[1].fields._._.m_target = (Object *)uv;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->uv,
		      v40,
		      v41,
		      v42,
		      P3c,
		      P4c,
		      v103,
		      v106,
		      *(float *)&v107,
		      SDWORD2(v107),
		      v108,
		      SBYTE8(v108),
		      *(MethodInfo **)&v109.m_Center.x);
		    vertices = UnityEngine::Mesh::get_vertices(m, 0LL);
		    v44 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		    v44[1].fields._._.method_ptr = vertices;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->vertices,
		      v44,
		      v45,
		      v46,
		      P3d,
		      P4d,
		      v104,
		      v106,
		      *(float *)&v107,
		      SDWORD2(v107),
		      v108,
		      SBYTE8(v108),
		      *(MethodInfo **)&v109.m_Center.x);
		    for ( i = 0; i < UnityEngine::Mesh::get_subMeshCount(m, 0LL); ++i )
		    {
		      v48 = UnityEngine::Mesh::GetTriangles(m, i, 0LL);
		      v49 = (List_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		      v50 = (Object *)v49;
		      if ( !v49 )
		        goto LABEL_55;
		      System::Collections::Generic::List<int>::List(
		        v49,
		        (IEnumerable_1_System_Int32_ *)v48,
		        MethodInfo::System::Collections::Generic::List<int>::List);
		      sub_182F01190(v20, v50);
		    }
		    for ( j = 0; j < v20->fields._size; ++j )
		    {
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               v20,
		               j,
		               MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
		      ProcessorCount = UnityEngine::SystemInfo::GetProcessorCount(0LL);
		      if ( !Item )
		        goto LABEL_55;
		      monitor = (int)Item[1].monitor;
		      if ( ProcessorCount < monitor )
		        monitor = ProcessorCount;
		      if ( monitor <= 0 )
		        monitor = 1;
		      v55 = SLODWORD(Item[1].monitor) / monitor - SLODWORD(Item[1].monitor) / monitor % 3;
		      v110 = v55;
		      v56 = il2cpp_array_new_specific_1(TypeInfo::System::Threading::Thread, (unsigned int)monitor);
		      v57 = 0;
		      v111 = monitor - 1;
		      if ( monitor - 1 > 0 )
		      {
		        v58 = 0;
		        while ( 1 )
		        {
		          v59 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
		          v62 = v59;
		          if ( !v59 )
		            break;
		          *(_DWORD *)(v59 + 16) = v58;
		          *(_DWORD *)(v59 + 20) = v58 + v55;
		          *(_DWORD *)(v59 + 120) = objID;
		          *(_DWORD *)(v59 + 124) = previous;
		          *(_QWORD *)(v59 + 112) = Item;
		          sub_18002D1B0(
		            (VolumetricRenderer_VolumetricRenderItem *)(v59 + 112),
		            v10,
		            v60,
		            v61,
		            P3b,
		            P4b,
		            v105,
		            v106,
		            *(float *)&v107,
		            SDWORD2(v107),
		            v108,
		            SBYTE8(v108),
		            *(MethodInfo **)&v109.m_Center.x);
		          *(_DWORD *)(v62 + 128) = j;
		          v63 = (ParameterizedThreadStart *)sub_18002C620(TypeInfo::System::Threading::ParameterizedThreadStart);
		          v64 = v63;
		          if ( !v63 )
		            break;
		          System::Threading::ParameterizedThreadStart::ParameterizedThreadStart(
		            v63,
		            0LL,
		            MethodInfo::HG::Rendering::Runtime::CSG::BSP::CreatePolygons,
		            0LL);
		          v65 = (Thread *)sub_18002C620(TypeInfo::System::Threading::Thread);
		          *(_QWORD *)&v107 = v65;
		          if ( !v65 )
		            break;
		          System::Threading::Thread::Thread(v65, v64, 0LL);
		          if ( !v56 )
		            break;
		          sub_1800020D0(v56, v57, v107);
		          if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
		            goto LABEL_50;
		          Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
		          if ( !Patch )
		            break;
		          System::Threading::Thread::set_Priority(Patch, 4LL);
		          if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
		            goto LABEL_50;
		          Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
		          if ( !Patch )
		            break;
		          System::Threading::Thread::Start((Thread *)Patch, (Object *)v62, 0LL);
		          v55 = v110;
		          ++v57;
		          v58 += v110;
		          if ( v57 >= v111 )
		            goto LABEL_36;
		        }
		LABEL_55:
		        sub_1800D8260(Patch, v10);
		      }
		LABEL_36:
		      v67 = (int)Item[1].monitor;
		      v68 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
		      v71 = v68;
		      if ( !v68 )
		        goto LABEL_55;
		      *(_DWORD *)(v68 + 20) = v67;
		      *(_DWORD *)(v68 + 16) = v55 * v57;
		      *(_DWORD *)(v68 + 120) = objID;
		      *(_DWORD *)(v68 + 124) = previous;
		      *(_QWORD *)(v68 + 112) = Item;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)(v68 + 112),
		        v10,
		        v69,
		        v70,
		        P3b,
		        P4b,
		        v105,
		        v106,
		        *(float *)&v107,
		        SDWORD2(v107),
		        v108,
		        SBYTE8(v108),
		        *(MethodInfo **)&v109.m_Center.x);
		      *(_DWORD *)(v71 + 128) = j;
		      v72 = (ParameterizedThreadStart *)sub_18002C620(TypeInfo::System::Threading::ParameterizedThreadStart);
		      v73 = v72;
		      if ( !v72 )
		        goto LABEL_55;
		      System::Threading::ParameterizedThreadStart::ParameterizedThreadStart(
		        v72,
		        0LL,
		        MethodInfo::HG::Rendering::Runtime::CSG::BSP::CreatePolygons,
		        0LL);
		      v74 = (Thread *)sub_18002C620(TypeInfo::System::Threading::Thread);
		      v75 = v74;
		      if ( !v74 )
		        goto LABEL_55;
		      System::Threading::Thread::Thread(v74, v73, 0LL);
		      if ( !v56 )
		        goto LABEL_55;
		      sub_1800020D0(v56, v57, v75);
		      if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
		        goto LABEL_50;
		      Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
		      if ( !Patch )
		        goto LABEL_55;
		      System::Threading::Thread::set_Priority(Patch, 4LL);
		      if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
		LABEL_50:
		        sub_1800D2AB0(v66, v10);
		      Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
		      if ( !Patch )
		        goto LABEL_55;
		      System::Threading::Thread::Start((Thread *)Patch, (Object *)v71, 0LL);
		      for ( k = 0; (signed int)k < *(_DWORD *)(v56 + 24); ++k )
		      {
		        if ( k >= *(_DWORD *)(v56 + 24) )
		          goto LABEL_50;
		        Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * (int)k + 32);
		        if ( !Patch )
		          goto LABEL_55;
		        System::Threading::Thread::JoinInternal((System::Threading::Thread *)Patch, -1);
		      }
		      v20 = *(List_1_System_Object_ **)&v113.x;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    memset(&v109, 0, sizeof(v109));
		    polygons = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->polygons;
		    one = UnityEngine::Vector3::get_one((Vector3 *)&v107, v78);
		    v80 = *(_QWORD *)&one->x;
		    *(float *)&one = one->z;
		    *(_QWORD *)&v113.x = v80;
		    LODWORD(v113.z) = (_DWORD)one;
		    Vector = UnityEngine::Animator::GetVector((Vector3 *)&v108, v81, v82, v83);
		    v85 = *(_QWORD *)&Vector->x;
		    *(float *)&Vector = Vector->z;
		    *(_QWORD *)&v107 = v85;
		    DWORD2(v107) = (_DWORD)Vector;
		    UnityEngine::Bounds::Bounds(&v109, (Vector3 *)&v107, &v113, 0LL);
		    v86 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		    v87 = (Object__Array *)v86;
		    if ( !v86 )
		      goto LABEL_55;
		    sub_180031B10(v86, "Mesh");
		    sub_180005370(v87, 0LL, "Mesh");
		    v88 = (BSP *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		    v89 = v88;
		    if ( !v88 )
		      goto LABEL_55;
		    v112 = v109;
		    HG::Rendering::Runtime::CSG::BSP::BSP(
		      v88,
		      (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)polygons,
		      &v112,
		      v87,
		      1,
		      0LL);
		    return v89;
		  }
		}
		
		public static void CreatePolygons(object obj) {} // 0x0000000189C71B68-0x0000000189C723A4
		// Void CreatePolygons(Object)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CSG::BSP::CreatePolygons(Object *obj, MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // rsi
		  int32_t v7; // r14d
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // r15
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // r13
		  BSP__StaticFields *static_fields; // rdx
		  Vector3__Array *vertices; // rbx
		  struct BSP__Class *v16; // rbx
		  Matrix4x4 *p_matrix; // rdx
		  Vector3 *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // xmm6_8
		  float z; // r12d
		  BSP__StaticFields *v23; // rax
		  __int64 v24; // rdx
		  BSP__StaticFields *v25; // rcx
		  CSGVertex *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int64 v29; // rdx
		  BSP__StaticFields *v30; // rcx
		  struct BSP__Class *v31; // rbx
		  Matrix4x4 *v32; // rdx
		  Vector3 *v33; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int64 v36; // xmm6_8
		  float v37; // r15d
		  BSP__StaticFields *v38; // rax
		  __int64 v39; // rdx
		  BSP__StaticFields *v40; // rcx
		  CSGVertex *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  Object *v44; // r12
		  __int64 v45; // rdx
		  BSP__StaticFields *v46; // rcx
		  __int64 v47; // r13
		  struct BSP__Class *v48; // rbx
		  Matrix4x4 *v49; // rdx
		  Vector3 *v50; // rax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  __int64 v53; // xmm6_8
		  BSP__StaticFields *v54; // rax
		  __int64 v55; // rdx
		  BSP__StaticFields *v56; // rcx
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  CSGVertex *v59; // r15
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v60; // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  List_1_System_Object_ *v63; // rbx
		  List_1_System_Object_ *polygons; // r12
		  int32_t v65; // r13d
		  CSGPolygon *v66; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  Object *v69; // r15
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  int32_t v75; // [rsp+30h] [rbp-228h]
		  float v76; // [rsp+30h] [rbp-228h]
		  int v77; // [rsp+30h] [rbp-228h]
		  Object *item; // [rsp+38h] [rbp-220h]
		  int itema; // [rsp+38h] [rbp-220h]
		  Object *obja; // [rsp+40h] [rbp-218h] BYREF
		  Vector2 v81; // [rsp+48h] [rbp-210h] BYREF
		  Vector2 v82; // [rsp+50h] [rbp-208h] BYREF
		  Vector2 v83; // [rsp+58h] [rbp-200h] BYREF
		  __int64 v84; // [rsp+60h] [rbp-1F8h]
		  Vector3 v85; // [rsp+70h] [rbp-1E8h] BYREF
		  Vector3 v86; // [rsp+80h] [rbp-1D8h] BYREF
		  Vector3 v87; // [rsp+90h] [rbp-1C8h] BYREF
		  Vector3 v88; // [rsp+A0h] [rbp-1B8h] BYREF
		  Vector3 v89; // [rsp+B0h] [rbp-1A8h] BYREF
		  Vector3 v90; // [rsp+C0h] [rbp-198h] BYREF
		  Vector3 v91; // [rsp+D0h] [rbp-188h] BYREF
		  Vector3 v92; // [rsp+E0h] [rbp-178h] BYREF
		  Vector3 v93; // [rsp+F0h] [rbp-168h] BYREF
		  Vector3 v94; // [rsp+100h] [rbp-158h] BYREF
		  Vector3 v95; // [rsp+110h] [rbp-148h] BYREF
		  Vector3 v96; // [rsp+120h] [rbp-138h] BYREF
		  Vector3 v97; // [rsp+130h] [rbp-128h] BYREF
		  Vector3 v98; // [rsp+140h] [rbp-118h] BYREF
		  Vector3 v99; // [rsp+150h] [rbp-108h] BYREF
		  Vector3 v100; // [rsp+160h] [rbp-F8h] BYREF
		  Vector3 v101; // [rsp+170h] [rbp-E8h] BYREF
		  Vector3 v102; // [rsp+180h] [rbp-D8h] BYREF
		  Il2CppException *ex; // [rsp+190h] [rbp-C8h] BYREF
		  __int128 v104; // [rsp+198h] [rbp-C0h]
		  __int128 v105; // [rsp+1A8h] [rbp-B0h]
		  Il2CppExceptionWrapper *v106; // [rsp+1B8h] [rbp-A0h] BYREF
		  Vector3 v107; // [rsp+1C0h] [rbp-98h] BYREF
		  Vector3 v108; // [rsp+1D0h] [rbp-88h] BYREF
		  Vector3 v109; // [rsp+1E0h] [rbp-78h] BYREF
		  Vector3 v110; // [rsp+1F0h] [rbp-68h] BYREF
		  Vector3 v111; // [rsp+200h] [rbp-58h] BYREF
		  Vector3 v112[2]; // [rsp+210h] [rbp-48h] BYREF
		  bool lockTaken; // [rsp+270h] [rbp+18h] BYREF
		  int32_t v114; // [rsp+278h] [rbp+20h]
		
		  obja = 0LL;
		  lockTaken = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5252, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5252, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v74, v73);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, obj, 0LL);
		  }
		  else
		  {
		    v3 = sub_180005050(obj, TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
		    v6 = v3;
		    v84 = v3;
		    if ( !v3 )
		      sub_1800D8260(v5, v4);
		    v7 = *(_DWORD *)(v3 + 16);
		    v114 = v7;
		    while ( v7 < *(_DWORD *)(v6 + 20) )
		    {
		      if ( !*(_QWORD *)(v6 + 112) )
		        sub_1800D8260(v5, v4);
		      v10 = System::Collections::Generic::List<int>::get_Item(
		              *(List_1_System_Int32_ **)(v6 + 112),
		              v7,
		              MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      if ( !*(_QWORD *)(v6 + 112) )
		        sub_1800D8260(v9, v8);
		      v13 = System::Collections::Generic::List<int>::get_Item(
		              *(List_1_System_Int32_ **)(v6 + 112),
		              v7 + 1,
		              MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      if ( !*(_QWORD *)(v6 + 112) )
		        sub_1800D8260(v12, v11);
		      v75 = System::Collections::Generic::List<int>::get_Item(
		              *(List_1_System_Int32_ **)(v6 + 112),
		              v7 + 2,
		              MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		      static_fields = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      vertices = static_fields->vertices;
		      if ( !vertices )
		        sub_1800D8260(TypeInfo::HG::Rendering::Runtime::CSG::BSP, static_fields);
		      sub_180049C60(vertices, &v86, v10);
		      v16 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
		      p_matrix = &TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->matrix;
		      v87 = v86;
		      v88 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v107, p_matrix, &v87, 0LL);
		      v18 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v108, &v16->static_fields->matrix2, &v88, 0LL);
		      v21 = *(_QWORD *)&v18->x;
		      z = v18->z;
		      v23 = v16->static_fields;
		      if ( !v23->normals )
		        sub_1800D8260(v20, v19);
		      sub_180049C60(v23->normals, &v89, v10);
		      v25 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      if ( !v25->uv )
		        sub_1800D8260(v25, v24);
		      sub_1800473A0(v25->uv, &v81, v10);
		      v26 = (CSGVertex *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		      item = (Object *)v26;
		      if ( !v26 )
		        sub_1800D8260(v28, v27);
		      v90 = v89;
		      *(_QWORD *)&v91.x = v21;
		      v91.z = z;
		      HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v26, &v91, &v90, v81, v10, 0LL);
		      v30 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      if ( !v30->vertices )
		        sub_1800D8260(v30, v29);
		      sub_180049C60(v30->vertices, &v92, v13);
		      v31 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
		      v32 = &TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->matrix;
		      v93 = v92;
		      v94 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v109, v32, &v93, 0LL);
		      v33 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v110, &v31->static_fields->matrix2, &v94, 0LL);
		      v36 = *(_QWORD *)&v33->x;
		      v37 = v33->z;
		      v38 = v31->static_fields;
		      if ( !v38->normals )
		        sub_1800D8260(v35, v34);
		      sub_180049C60(v38->normals, &v95, v13);
		      v40 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      if ( !v40->uv )
		        sub_1800D8260(v40, v39);
		      sub_1800473A0(v40->uv, &v82, v13);
		      v41 = (CSGVertex *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		      v44 = (Object *)v41;
		      if ( !v41 )
		        sub_1800D8260(v43, v42);
		      v96 = v95;
		      *(_QWORD *)&v97.x = v36;
		      v97.z = v37;
		      HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v41, &v97, &v96, v82, v13, 0LL);
		      v46 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      if ( !v46->vertices )
		        sub_1800D8260(v46, v45);
		      v47 = v75;
		      sub_180049C60(v46->vertices, &v98, v75);
		      v48 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
		      v49 = &TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->matrix;
		      v99 = v98;
		      v100 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v111, v49, &v99, 0LL);
		      v50 = UnityEngine::Matrix4x4::MultiplyPoint3x4(v112, &v48->static_fields->matrix2, &v100, 0LL);
		      v53 = *(_QWORD *)&v50->x;
		      v76 = v50->z;
		      v54 = v48->static_fields;
		      if ( !v54->normals )
		        sub_1800D8260(v52, v51);
		      sub_180049C60(v54->normals, &v101, v47);
		      v56 = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields;
		      if ( !v56->uv )
		        sub_1800D8260(v56, v55);
		      sub_1800473A0(v56->uv, &v83, v47);
		      v59 = (CSGVertex *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		      if ( !v59 )
		        sub_1800D8260(v58, v57);
		      v102 = v101;
		      *(_QWORD *)&v85.x = v53;
		      v85.z = v76;
		      HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v59, &v85, &v102, v83, v47, 0LL);
		      v60 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
		      v63 = (List_1_System_Object_ *)v60;
		      if ( !v60 )
		        sub_1800D8260(v62, v61);
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v60,
		        3,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
		      sub_182F01190(v63, item);
		      sub_182F01190(v63, v44);
		      sub_182F01190(v63, (Object *)v59);
		      obja = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->locker;
		      lockTaken = 0;
		      *(_QWORD *)&v105 = &lockTaken;
		      *((_QWORD *)&v105 + 1) = &obja;
		      ex = 0LL;
		      v104 = v105;
		      try
		      {
		        System::Threading::Monitor::Enter(obja, &lockTaken, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		        polygons = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->polygons;
		        v65 = *(_DWORD *)(v6 + 120);
		        v77 = *(_DWORD *)(v6 + 124);
		        itema = *(_DWORD *)(v6 + 128);
		        v66 = (CSGPolygon *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
		        v69 = (Object *)v66;
		        if ( !v66 )
		          sub_1800D8250(v68, v67);
		        HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		          v66,
		          (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v63,
		          v65,
		          v77 + itema,
		          0LL);
		        if ( !polygons )
		          sub_1800D8250(v71, v70);
		        sub_182F01190(polygons, v69);
		      }
		      catch ( Il2CppExceptionWrapper *v106 )
		      {
		        ex = v106->ex;
		        sub_1801F4710(&ex);
		        v6 = v84;
		        v7 = v114;
		        goto LABEL_26;
		      }
		      sub_1801F4710(&ex);
		LABEL_26:
		      v7 += 3;
		      v114 = v7;
		    }
		  }
		}
		
		public virtual void Subtract(BSP bInput) {} // 0x0000000189C72FF4-0x0000000189C73160
		public virtual void Intersect(BSP bInput) {} // 0x0000000189C723A4-0x0000000189C72A4C
		// Void Intersect(BSP)
		void HG::Rendering::Runtime::CSG::BSP::Intersect(BSP *this, BSP *bInput, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Node_2 *v6; // rcx
		  Node_2 *root; // rsi
		  Node_2 *v8; // r14
		  IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *AllPolygons; // rax
		  float z; // eax
		  float v11; // eax
		  float v12; // eax
		  float v13; // eax
		  __int64 v14; // xmm1_8
		  Vector3 *min; // rax
		  __int128 v16; // xmm0
		  __int64 v17; // xmm1_8
		  __m128 x_low; // xmm8
		  float x; // xmm7_4
		  float v20; // eax
		  __int64 v21; // xmm1_8
		  Vector3 *v22; // rax
		  __int128 v23; // xmm0
		  __int64 v24; // xmm1_8
		  __m128 y_low; // xmm6
		  Vector3 *v26; // rax
		  __m128 v27; // xmm0
		  __int64 v28; // xmm1_8
		  __m128 v29; // xmm11
		  __int128 v30; // xmm0
		  Vector3 *v31; // rax
		  __int128 v32; // xmm0
		  __int64 v33; // xmm2_8
		  __m128 v34; // xmm0
		  __m128 v35; // xmm10
		  Vector3 *v36; // rax
		  float v37; // eax
		  __int64 v38; // xmm2_8
		  float v39; // xmm9_4
		  Vector3 *max; // rax
		  __int128 v41; // xmm0
		  __int64 v42; // xmm1_8
		  __m128 v43; // xmm6
		  Vector3 *v44; // rax
		  __m128 v45; // xmm0
		  float v46; // eax
		  __int64 v47; // xmm2_8
		  __m128 v48; // xmm8
		  Vector3 *v49; // rax
		  __int128 v50; // xmm0
		  __int64 v51; // xmm1_8
		  __m128 v52; // xmm6
		  Vector3 *v53; // rax
		  __m128 v54; // xmm0
		  float v55; // eax
		  __int64 v56; // xmm2_8
		  __m128 v57; // xmm7
		  Vector3 *v58; // rax
		  __int128 v59; // xmm0
		  __int64 v60; // xmm1_8
		  Vector3 *v61; // rax
		  __int64 v62; // xmm1_8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v63; // rdx
		  VolumetricRenderer_VolumetricBounds *v64; // r8
		  Int32__Array **v65; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+28h] [rbp-99h]
		  MethodInfo *v68; // [rsp+30h] [rbp-91h]
		  SyncSubPort v69; // [rsp+38h] [rbp-89h] BYREF
		  int32_t v70; // [rsp+50h] [rbp-71h]
		  Vector3 v71; // [rsp+58h] [rbp-69h] BYREF
		  SyncSubPort v72; // [rsp+68h] [rbp-59h] BYREF
		  Nullable_1_Beyond_Gameplay_RemoteFactory_SyncSubPort_ v73[4]; // [rsp+80h] [rbp-41h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5429, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5429, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)bInput,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  root = this->fields.root;
		  if ( !bInput )
		    goto LABEL_12;
		  v6 = bInput->fields.root;
		  if ( !v6 )
		    goto LABEL_12;
		  v8 = HG::Rendering::Runtime::CSG::Node::Clone(v6, 0LL);
		  if ( !root )
		    goto LABEL_12;
		  HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
		  if ( !v8 )
		    goto LABEL_12;
		  HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
		  HG::Rendering::Runtime::CSG::Node::Invert(v8, 0LL);
		  HG::Rendering::Runtime::CSG::Node::ClipTo(root, v8, 0LL);
		  HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
		  AllPolygons = HG::Rendering::Runtime::CSG::Node::get_AllPolygons(v8, 0LL);
		  HG::Rendering::Runtime::CSG::Node::Build(root, AllPolygons, 0LL);
		  HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
		  z = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		  *(_QWORD *)&v73[0].value.direction.m_X = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		  *(float *)&v73[0].value.direction.m_Z = z;
		  if ( this->fields._Bounds_k__BackingField.hasValue
		    && (v12 = bInput->fields._Bounds_k__BackingField.value.m_Extents.z,
		        *(_QWORD *)&v73[0].value.direction.m_X = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x,
		        *(float *)&v73[0].value.direction.m_Z = v12,
		        bInput->fields._Bounds_k__BackingField.hasValue) )
		  {
		    v13 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    v14 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    *(float *)&v73[0].value.direction.m_Z = v13;
		    *(_QWORD *)&v73[0].value.direction.m_X = v14;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    min = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL);
		    v16 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v17 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    x_low = (__m128)LODWORD(min->x);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v16;
		    *(_QWORD *)&v73[0].value.direction.m_X = v17;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    x = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL)->x;
		    sub_1800036A0(TypeInfo::System::Math);
		    v20 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    v21 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    *(float *)&v73[0].value.direction.m_Z = v20;
		    *(_QWORD *)&v73[0].value.direction.m_X = v21;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v22 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL);
		    v23 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v24 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    y_low = (__m128)LODWORD(v22->y);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v23;
		    *(_QWORD *)&v73[0].value.direction.m_X = v24;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v26 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL);
		    v27 = y_low;
		    v27.m128_f32[0] = System::Math::Max(y_low.m128_f32[0], v26->y, 0LL);
		    v28 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v29 = v27;
		    v30 = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    v73[0].value.direction.m_Z = LODWORD(this->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_QWORD *)&v73[0].value.direction.m_X = v28;
		    *(_OWORD *)&v73[0].hasValue = v30;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v31 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL);
		    v32 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v33 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    y_low.m128_i32[0] = LODWORD(v31->z);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v32;
		    *(_QWORD *)&v73[0].value.direction.m_X = v33;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v34 = x_low;
		    v69 = v72;
		    v34.m128_f32[0] = System::Math::Max(x_low.m128_f32[0], x, 0LL);
		    v35 = v34;
		    v36 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v69, 0LL);
		    v34.m128_f32[0] = System::Math::Max(y_low.m128_f32[0], v36->z, 0LL);
		    v37 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    v38 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v39 = v34.m128_f32[0];
		    *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    *(float *)&v73[0].value.direction.m_Z = v37;
		    *(_QWORD *)&v73[0].value.direction.m_X = v38;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    max = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v41 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v42 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v43 = (__m128)LODWORD(max->x);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v41;
		    *(_QWORD *)&v73[0].value.direction.m_X = v42;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v44 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v45 = v43;
		    v45.m128_f32[0] = System::Math::Min(v43.m128_f32[0], v44->x, 0LL);
		    v46 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    v47 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v48 = v45;
		    *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    *(float *)&v73[0].value.direction.m_Z = v46;
		    *(_QWORD *)&v73[0].value.direction.m_X = v47;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v49 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v50 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v51 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v52 = (__m128)LODWORD(v49->y);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v50;
		    *(_QWORD *)&v73[0].value.direction.m_X = v51;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v53 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v54 = v52;
		    v54.m128_f32[0] = System::Math::Min(v52.m128_f32[0], v53->y, 0LL);
		    v55 = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    v56 = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v57 = v54;
		    *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue;
		    *(float *)&v73[0].value.direction.m_Z = v55;
		    *(_QWORD *)&v73[0].value.direction.m_X = v56;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v58 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v59 = *(_OWORD *)&bInput->fields._Bounds_k__BackingField.hasValue;
		    v60 = *(_QWORD *)&bInput->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v52.m128_i32[0] = LODWORD(v58->z);
		    v73[0].value.direction.m_Z = LODWORD(bInput->fields._Bounds_k__BackingField.value.m_Extents.z);
		    *(_OWORD *)&v73[0].hasValue = v59;
		    *(_QWORD *)&v73[0].value.direction.m_X = v60;
		    System::Nullable<Beyond::Gameplay::RemoteFactory::SyncSubPort>::get_Value(
		      &v72,
		      v73,
		      MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
		    v69 = v72;
		    v61 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v69, 0LL);
		    v69.position.m_Z = System::Math::Min(v52.m128_f32[0], v61->z, 0LL);
		    v71.z = v39;
		    *(_QWORD *)&v69.position.m_X = _mm_unpacklo_ps(v48, v57).m128_u64[0];
		    memset(&v72, 0, sizeof(v72));
		    *(_QWORD *)&v71.x = _mm_unpacklo_ps(v35, v29).m128_u64[0];
		    UnityEngine::Bounds::Bounds((Bounds *)&v72, &v71, (Vector3 *)&v69, 0LL);
		    *(_WORD *)(&v73[0].hasValue + 1) = 0;
		    v73[0].value = v72;
		    *(&v73[0].hasValue + 3) = 0;
		    v62 = *(_QWORD *)&v72.direction.m_X;
		    v11 = *(float *)&v72.direction.m_Z;
		    v73[0].hasValue = 1;
		    *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v73[0].hasValue;
		    *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = v62;
		  }
		  else
		  {
		    v11 = 0.0;
		    *(_OWORD *)&this->fields._Bounds_k__BackingField.hasValue = 0LL;
		    *(_QWORD *)&v73[0].value.direction.m_X = 0LL;
		    *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x = 0LL;
		  }
		  this->fields._Bounds_k__BackingField.value.m_Extents.z = v11;
		  this->fields.description = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
		                               this,
		                               (String *)"intersect",
		                               this->fields.description,
		                               bInput->fields.description,
		                               0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.description,
		    v63,
		    v64,
		    v65,
		    methoda,
		    v68,
		    v69.position.m_X,
		    v69.position.m_Z,
		    *(float *)&v69.direction.m_Y,
		    v70,
		    SLOBYTE(v71.x),
		    SLOBYTE(v71.z),
		    *(MethodInfo **)&v72.position.m_X);
		  HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
		}
		
		public virtual void Clear() {} // 0x0000000189C718BC-0x0000000189C71978
		public virtual float? RayCast(Ray ray) => default; // 0x0000000189C72F44-0x0000000189C72FF4
		// Nullable`1[Single] RayCast(Ray)
		Nullable_1_Single_ HG::Rendering::Runtime::CSG::BSP::RayCast(BSP *this, Ray *ray, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  bool v6; // zf
		  float z; // eax
		  Node_2 *root; // rcx
		  __int64 v10; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // xmm1_8
		  Ray v13; // [rsp+20h] [rbp-28h] BYREF
		  float v14; // [rsp+38h] [rbp-10h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5431, 0LL) )
		  {
		    v6 = !this->fields._Bounds_k__BackingField.hasValue;
		    z = this->fields._Bounds_k__BackingField.value.m_Extents.z;
		    *(_QWORD *)&v13.m_Direction.y = *(_QWORD *)&this->fields._Bounds_k__BackingField.value.m_Extents.x;
		    v14 = z;
		    if ( v6 )
		      return 0LL;
		    root = this->fields.root;
		    if ( root )
		    {
		      v10 = *(_QWORD *)&ray->m_Direction.y;
		      *(_OWORD *)&v13.m_Origin.x = *(_OWORD *)&ray->m_Origin.x;
		      *(_QWORD *)&v13.m_Direction.y = v10;
		      return HG::Rendering::Runtime::CSG::Node::RayCast(root, &v13, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(root, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5431, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  v12 = *(_QWORD *)&ray->m_Direction.y;
		  *(_OWORD *)&v13.m_Origin.x = *(_OWORD *)&ray->m_Origin.x;
		  *(_QWORD *)&v13.m_Direction.y = v12;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1571(Patch, (Object *)this, &v13, 0LL);
		}
		
	}
}
