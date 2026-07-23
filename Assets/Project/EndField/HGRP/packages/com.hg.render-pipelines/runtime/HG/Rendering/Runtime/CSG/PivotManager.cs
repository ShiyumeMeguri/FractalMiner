using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	public class PivotManager // TypeDefIndex: 38820
	{
		// Fields
		private static GameObject selectedObject; // 0x00
		private static Mesh selectedObjectMesh; // 0x08
		private static Vector3 selectedObjectPivot; // 0x10
	
		// Constructors
		public PivotManager() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static void CenterPivot() {} // 0x0000000189C7D06C-0x0000000189C7D0C4
		// Void CenterPivot()
		void HG::Rendering::Runtime::CSG::PivotManager::CenterPivot(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5446, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5446, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v3, v2);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::CSG::PivotManager::RecognizeSelectedObject(0LL);
		    if ( HG::Rendering::Runtime::CSG::PivotManager::CheckSelectedObject(0LL) )
		      HG::Rendering::Runtime::CSG::PivotManager::CenterObjectPivot(0LL);
		  }
		}
		
		private static void CreateChildPivot() {} // 0x0000000189C7D160-0x0000000189C7D1B8
		// Void CreateChildPivot()
		void HG::Rendering::Runtime::CSG::PivotManager::CreateChildPivot(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5452, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5452, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v3, v2);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::CSG::PivotManager::RecognizeSelectedObject(0LL);
		    if ( HG::Rendering::Runtime::CSG::PivotManager::CheckSelectedObject(0LL) )
		      HG::Rendering::Runtime::CSG::PivotManager::CreateObjectPivot(0LL);
		  }
		}
		
		private static void OnSelectionChange() {} // 0x0000000189C7D68C-0x0000000189C7D6D0
		// Void OnSelectionChange()
		void HG::Rendering::Runtime::CSG::PivotManager::OnSelectionChange(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5454, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5454, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v3, v2);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::CSG::PivotManager::RecognizeSelectedObject(0LL);
		  }
		}
		
		private static bool CheckSelectedObject() => default; // 0x0000000189C7D0C4-0x0000000189C7D160
		// Boolean CheckSelectedObject()
		bool HG::Rendering::Runtime::CSG::PivotManager::CheckSelectedObject(MethodInfo *method)
		{
		  Object_1 *selectedObject; // rbx
		  bool result; // al
		  Object_1 *selectedObjectMesh; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5449, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5449, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  else
		  {
		    selectedObject = (Object_1 *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObject;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Implicit(selectedObject, 0LL);
		    if ( result )
		    {
		      selectedObjectMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      return UnityEngine::Object::op_Implicit(selectedObjectMesh, 0LL);
		    }
		  }
		  return result;
		}
		
		private static void RecognizeSelectedObject() {} // 0x0000000189C7D6D0-0x0000000189C7D754
		private static void FixColliders(Vector3 scaleDiff) {} // 0x0000000189C7D400-0x0000000189C7D68C
		// Void FixColliders(Vector3)
		void HG::Rendering::Runtime::CSG::PivotManager::FixColliders(Vector3 *scaleDiff, MethodInfo *method)
		{
		  PivotManager__StaticFields *static_fields; // rdx
		  GameObject *selectedObject; // rcx
		  Object *v5; // rbx
		  Animator *v6; // rdx
		  int32_t v7; // r8d
		  MethodInfo *v8; // r9
		  SphereCollider *v9; // rax
		  SphereCollider *v10; // rbx
		  __int64 v11; // xmm0_8
		  Vector3 *v12; // rax
		  __int64 v13; // xmm0_8
		  MethodInfo *v14; // r9
		  Vector3 *v15; // rax
		  __int64 v16; // xmm3_8
		  CapsuleCollider *v17; // rax
		  CapsuleCollider *v18; // rbx
		  __int64 v19; // xmm0_8
		  Vector3 *v20; // rax
		  __int64 v21; // xmm0_8
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  __int64 v24; // xmm3_8
		  BoxCollider *v25; // rax
		  BoxCollider *v26; // rbx
		  __int64 v27; // xmm0_8
		  Vector3 *center; // rax
		  __int64 v29; // xmm0_8
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // xmm3_8
		  Vector3 *Vector; // rax
		  float z; // r8d
		  PivotManager__StaticFields *v35; // rdx
		  float v36; // eax
		  Vector3 v37; // [rsp+20h] [rbp-30h] BYREF
		  Vector3 v38; // [rsp+30h] [rbp-20h] BYREF
		  Vector3 v39; // [rsp+40h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5455, 0LL) )
		  {
		    static_fields = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		    selectedObject = static_fields->selectedObject;
		    if ( !static_fields->selectedObject )
		      goto LABEL_15;
		    v5 = UnityEngine::GameObject::GetComponent<System::Object>(
		           selectedObject,
		           MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Collider>);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)v5, 0LL) )
		    {
		      if ( sub_180005050(v5, TypeInfo::UnityEngine::BoxCollider) )
		      {
		        v25 = (BoxCollider *)sub_180005130(v5, TypeInfo::UnityEngine::BoxCollider);
		        v26 = v25;
		        if ( v25 )
		        {
		          v27 = *(_QWORD *)&scaleDiff->x;
		          v38.z = scaleDiff->z;
		          *(_QWORD *)&v38.x = v27;
		          center = UnityEngine::BoxCollider::get_center(&v39, v25, 0LL);
		          v29 = *(_QWORD *)&center->x;
		          *(float *)&center = center->z;
		          *(_QWORD *)&v37.x = v29;
		          LODWORD(v37.z) = (_DWORD)center;
		          v31 = UnityEngine::Vector3::op_Addition(&v39, &v37, &v38, v30);
		          v32 = *(_QWORD *)&v31->x;
		          *(float *)&v31 = v31->z;
		          *(_QWORD *)&v38.x = v32;
		          LODWORD(v38.z) = (_DWORD)v31;
		          UnityEngine::BoxCollider::set_center(v26, &v38, 0LL);
		          goto LABEL_13;
		        }
		        goto LABEL_15;
		      }
		      if ( sub_180005050(v5, TypeInfo::UnityEngine::CapsuleCollider) )
		      {
		        v17 = (CapsuleCollider *)sub_180005130(v5, TypeInfo::UnityEngine::CapsuleCollider);
		        v18 = v17;
		        if ( v17 )
		        {
		          v19 = *(_QWORD *)&scaleDiff->x;
		          v38.z = scaleDiff->z;
		          *(_QWORD *)&v38.x = v19;
		          v20 = UnityEngine::CapsuleCollider::get_center(&v39, v17, 0LL);
		          v21 = *(_QWORD *)&v20->x;
		          *(float *)&v20 = v20->z;
		          *(_QWORD *)&v37.x = v21;
		          LODWORD(v37.z) = (_DWORD)v20;
		          v23 = UnityEngine::Vector3::op_Addition(&v39, &v37, &v38, v22);
		          v24 = *(_QWORD *)&v23->x;
		          *(float *)&v23 = v23->z;
		          *(_QWORD *)&v38.x = v24;
		          LODWORD(v38.z) = (_DWORD)v23;
		          UnityEngine::CapsuleCollider::set_center(v18, &v38, 0LL);
		          goto LABEL_13;
		        }
		        goto LABEL_15;
		      }
		      if ( sub_180005050(v5, TypeInfo::UnityEngine::SphereCollider) )
		      {
		        v9 = (SphereCollider *)sub_180005130(v5, TypeInfo::UnityEngine::SphereCollider);
		        v10 = v9;
		        if ( v9 )
		        {
		          v11 = *(_QWORD *)&scaleDiff->x;
		          v37.z = scaleDiff->z;
		          *(_QWORD *)&v37.x = v11;
		          v12 = UnityEngine::SphereCollider::get_center(&v39, v9, 0LL);
		          v13 = *(_QWORD *)&v12->x;
		          *(float *)&v12 = v12->z;
		          *(_QWORD *)&v38.x = v13;
		          LODWORD(v38.z) = (_DWORD)v12;
		          v15 = UnityEngine::Vector3::op_Addition(&v39, &v38, &v37, v14);
		          v16 = *(_QWORD *)&v15->x;
		          *(float *)&v15 = v15->z;
		          *(_QWORD *)&v38.x = v16;
		          LODWORD(v38.z) = (_DWORD)v15;
		          UnityEngine::SphereCollider::set_center(v10, &v38, 0LL);
		          goto LABEL_13;
		        }
		LABEL_15:
		        sub_1800D8260(selectedObject, static_fields);
		      }
		    }
		LABEL_13:
		    Vector = UnityEngine::Animator::GetVector(&v39, v6, v7, v8);
		    z = Vector->z;
		    v35 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		    *(_QWORD *)&v35->selectedObjectPivot.x = *(_QWORD *)&Vector->x;
		    v35->selectedObjectPivot.z = z;
		    return;
		  }
		  selectedObject = (GameObject *)IFix::WrappersManagerImpl::GetPatch(5455, 0LL);
		  if ( !selectedObject )
		    goto LABEL_15;
		  v36 = scaleDiff->z;
		  *(_QWORD *)&v38.x = *(_QWORD *)&scaleDiff->x;
		  v38.z = v36;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_940((ILFixDynamicMethodWrapper_2 *)selectedObject, &v38, 0LL);
		}
		
		[IDTag(1)]
		private static void CenterObjectPivot() {} // 0x0000000189C7D028-0x0000000189C7D06C
		// Void CenterObjectPivot()
		void HG::Rendering::Runtime::CSG::PivotManager::CenterObjectPivot(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5450, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5450, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v3, v2);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::CSG::PivotManager::CenterObjectPivot(0LL, 0LL);
		  }
		}
		
		[IDTag(0)]
		public static void CenterObjectPivot(GameObject obj) {} // 0x0000000189C7CCCC-0x0000000189C7D028
		// Void CenterObjectPivot(GameObject)
		void HG::Rendering::Runtime::CSG::PivotManager::CenterObjectPivot(GameObject *obj, MethodInfo *method)
		{
		  VolumetricRenderer_VolumetricBounds *v3; // r8
		  Int32__Array **v4; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  Mesh *monitor; // rdx
		  Mesh *v7; // rcx
		  Object *v8; // rbx
		  Mesh *sharedMesh; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v10; // rdx
		  VolumetricRenderer_VolumetricBounds *v11; // r8
		  Int32__Array **v12; // r9
		  Object_1 *selectedObjectMesh; // rbx
		  Bounds *bounds; // rax
		  __int64 v15; // xmm1_8
		  Vector3 *ObjectPivot; // rax
		  float z; // r8d
		  PivotManager__StaticFields *v18; // rdx
		  Transform *transform; // rax
		  Transform *v20; // rbx
		  Vector3 *position; // rax
		  MethodInfo *v22; // xmm0_8
		  float v23; // esi
		  PivotManager__StaticFields *v24; // rax
		  float v25; // r14d
		  Transform *v26; // rax
		  Vector3 *localScale; // rax
		  MethodInfo *v28; // xmm0_8
		  MethodInfo *v29; // r9
		  Vector3 *v30; // rax
		  __int64 v31; // xmm3_8
		  MethodInfo *v32; // r9
		  Vector3 *v33; // rax
		  __int64 v34; // xmm3_8
		  __int64 v35; // rdx
		  Mesh *v36; // rcx
		  Vector3__Array *vertices; // rbx
		  int32_t v38; // edi
		  __int64 v39; // rax
		  PivotManager__StaticFields *v40; // rcx
		  MethodInfo *v41; // xmm0_8
		  __int64 v42; // xmm0_8
		  Vector3 *v43; // rax
		  float v44; // ecx
		  __int64 v45; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v47; // [rsp+20h] [rbp-60h] BYREF
		  MethodInfo *v48; // [rsp+28h] [rbp-58h]
		  Vector3 v49; // [rsp+30h] [rbp-50h] BYREF
		  Bounds v50; // [rsp+40h] [rbp-40h] BYREF
		  bool v51; // [rsp+58h] [rbp-28h]
		  Bounds v52; // [rsp+60h] [rbp-20h] BYREF
		  __int64 v53; // [rsp+B0h] [rbp+30h]
		  MethodInfo *v54; // [rsp+B8h] [rbp+38h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5451, 0LL) )
		  {
		    static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		    static_fields->klass = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext___Class *)obj;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields,
		      static_fields,
		      v3,
		      v4,
		      v47,
		      v48,
		      SLODWORD(v49.x),
		      SLODWORD(v49.z),
		      v50.m_Center.x,
		      SLODWORD(v50.m_Center.z),
		      SLOBYTE(v50.m_Extents.y),
		      v51,
		      *(MethodInfo **)&v52.m_Center.x);
		    if ( obj )
		    {
		      v8 = UnityEngine::GameObject::GetComponent<System::Object>(
		             obj,
		             MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::MeshFilter>);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Implicit((Object_1 *)v8, 0LL) )
		        return;
		      if ( v8 )
		      {
		        sharedMesh = UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)v8, 0LL);
		        v10 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		        v10->monitor = (MonitorData *)sharedMesh;
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh,
		          v10,
		          v11,
		          v12,
		          v47,
		          v48,
		          SLODWORD(v49.x),
		          SLODWORD(v49.z),
		          v50.m_Center.x,
		          SLODWORD(v50.m_Center.z),
		          SLOBYTE(v50.m_Extents.y),
		          v51,
		          *(MethodInfo **)&v52.m_Center.x);
		        selectedObjectMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Implicit(selectedObjectMesh, 0LL) )
		        {
		          v7 = (Mesh *)TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		          monitor = (Mesh *)v7->monitor;
		          if ( !monitor )
		            goto LABEL_19;
		          bounds = UnityEngine::Mesh::get_bounds(&v50, monitor, 0LL);
		          v15 = *(_QWORD *)&bounds->m_Extents.y;
		          *(_OWORD *)&v52.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
		          *(_QWORD *)&v52.m_Extents.y = v15;
		          ObjectPivot = HG::Rendering::Runtime::CSG::PivotManager::FindObjectPivot(&v50.m_Center, &v52, 0LL);
		          z = ObjectPivot->z;
		          v18 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		          *(_QWORD *)&v18->selectedObjectPivot.x = *(_QWORD *)&ObjectPivot->x;
		          v18->selectedObjectPivot.z = z;
		        }
		        transform = UnityEngine::GameObject::get_transform(obj, 0LL);
		        v20 = transform;
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position(&v50.m_Center, transform, 0LL);
		          v22 = *(MethodInfo **)&position->x;
		          v23 = position->z;
		          v24 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		          v54 = v22;
		          v25 = v24->selectedObjectPivot.z;
		          v53 = *(_QWORD *)&v24->selectedObjectPivot.x;
		          v26 = UnityEngine::GameObject::get_transform(obj, 0LL);
		          if ( v26 )
		          {
		            localScale = UnityEngine::Transform::get_localScale(&v50.m_Center, v26, 0LL);
		            v49.z = v25;
		            v28 = *(MethodInfo **)&localScale->x;
		            *(float *)&localScale = localScale->z;
		            v47 = v28;
		            *(_QWORD *)&v49.x = v53;
		            LODWORD(v48) = (_DWORD)localScale;
		            v30 = UnityEngine::Vector3::Scale(&v50.m_Center, &v49, (Vector3 *)&v47, v29);
		            v47 = v54;
		            *(float *)&v48 = v23;
		            v31 = *(_QWORD *)&v30->x;
		            *(float *)&v30 = v30->z;
		            *(_QWORD *)&v49.x = v31;
		            LODWORD(v49.z) = (_DWORD)v30;
		            v33 = UnityEngine::Vector3::op_Subtraction(&v50.m_Center, (Vector3 *)&v47, &v49, v32);
		            v34 = *(_QWORD *)&v33->x;
		            *(float *)&v33 = v33->z;
		            *(_QWORD *)&v49.x = v34;
		            LODWORD(v49.z) = (_DWORD)v33;
		            UnityEngine::Transform::set_position(v20, &v49, 0LL);
		            v36 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh;
		            if ( !v36 )
		              sub_1800D8260(0LL, v35);
		            vertices = UnityEngine::Mesh::get_vertices(v36, 0LL);
		            v38 = 0;
		            if ( vertices )
		            {
		              while ( v38 < vertices->max_length.size )
		              {
		                v39 = sub_180002E90(vertices, v38);
		                v40 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		                v41 = *(MethodInfo **)&v40->selectedObjectPivot.x;
		                *(float *)&v48 = v40->selectedObjectPivot.z;
		                LODWORD(v40) = *(_DWORD *)(v39 + 8);
		                v47 = v41;
		                v42 = *(_QWORD *)v39;
		                LODWORD(v50.m_Center.z) = (_DWORD)v40;
		                *(_QWORD *)&v50.m_Center.x = v42;
		                v43 = UnityEngine::Vector3::op_Addition(
		                        &v52.m_Center,
		                        &v50.m_Center,
		                        (Vector3 *)&v47,
		                        (MethodInfo *)v39);
		                ++v38;
		                v44 = v43->z;
		                *(_QWORD *)v45 = *(_QWORD *)&v43->x;
		                *(float *)(v45 + 8) = v44;
		              }
		              v7 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh;
		              if ( v7 )
		              {
		                UnityEngine::Mesh::set_vertices(v7, vertices, 0LL);
		                v7 = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields->selectedObjectMesh;
		                if ( v7 )
		                {
		                  UnityEngine::Mesh::RecalculateBounds(v7, MeshUpdateFlags__Enum_Default, 0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_19:
		    sub_1800D8260(v7, monitor);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5451, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)obj, 0LL);
		}
		
		private static void CreateObjectPivot() {} // 0x0000000189C7D1B8-0x0000000189C7D2E4
		// Void CreateObjectPivot()
		void HG::Rendering::Runtime::CSG::PivotManager::CreateObjectPivot(MethodInfo *method)
		{
		  GameObject *v1; // rax
		  PivotManager__StaticFields *static_fields; // rdx
		  Object_1 *selectedObject; // rcx
		  Object_1 *v4; // rbx
		  String *name; // rax
		  String *v6; // rax
		  Transform *transform; // rax
		  __int64 v8; // xmm0_8
		  Transform *v9; // rbx
		  Transform *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Vector3 v14; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5453, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5453, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v1 = (GameObject *)sub_18002C620(TypeInfo::UnityEngine::GameObject);
		    v4 = (Object_1 *)v1;
		    if ( !v1 )
		      goto LABEL_8;
		    UnityEngine::GameObject::GameObject(v1, 0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		    selectedObject = (Object_1 *)static_fields->selectedObject;
		    if ( !static_fields->selectedObject )
		      goto LABEL_8;
		    name = UnityEngine::Object::get_name(selectedObject, 0LL);
		    v6 = System::String::Concat(name, (String *)".PivotReference", 0LL);
		    UnityEngine::Object::set_name(v4, v6, 0LL);
		    transform = UnityEngine::GameObject::get_transform((GameObject *)v4, 0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields;
		    v8 = *(_QWORD *)&static_fields->selectedObjectPivot.x;
		    selectedObject = (Object_1 *)LODWORD(static_fields->selectedObjectPivot.z);
		    if ( !transform
		      || (v14.z = static_fields->selectedObjectPivot.z,
		          *(_QWORD *)&v14.x = v8,
		          UnityEngine::Transform::set_position(transform, &v14, 0LL),
		          v9 = UnityEngine::GameObject::get_transform((GameObject *)v4, 0LL),
		          static_fields = TypeInfo::HG::Rendering::Runtime::CSG::PivotManager->static_fields,
		          (selectedObject = (Object_1 *)static_fields->selectedObject) == 0LL)
		      || (v10 = UnityEngine::GameObject::get_transform((GameObject *)selectedObject, 0LL), !v9) )
		    {
		LABEL_8:
		      sub_1800D8260(selectedObject, static_fields);
		    }
		    UnityEngine::Transform::set_parent(v9, v10, 0LL);
		  }
		}
		
		public static Vector3 FindObjectPivot(Bounds bounds) => default; // 0x0000000189C7D2E4-0x0000000189C7D400
		// Vector3 FindObjectPivot(Bounds)
		Vector3 *HG::Rendering::Runtime::CSG::PivotManager::FindObjectPivot(
		        Vector3 *__return_ptr retstr,
		        Bounds *bounds,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r9
		  float z; // eax
		  Vector3 *v7; // rax
		  __int64 v8; // xmm1_8
		  float v9; // ecx
		  __m128 v10; // xmm3
		  __m128 v11; // xmm1
		  float v12; // xmm2_4
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // xmm1_8
		  __int64 v19; // xmm0_8
		  float v20; // eax
		  Vector3 v22; // [rsp+20h] [rbp-50h] BYREF
		  Vector3 v23; // [rsp+30h] [rbp-40h] BYREF
		  Bounds v24; // [rsp+40h] [rbp-30h] BYREF
		  Vector3 v25; // [rsp+60h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5448, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5448, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    v18 = *(_QWORD *)&bounds->m_Extents.y;
		    *(_OWORD *)&v24.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
		    *(_QWORD *)&v24.m_Extents.y = v18;
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1578(&v25, Patch, &v24, 0LL);
		  }
		  else
		  {
		    z = bounds->m_Center.z;
		    *(_QWORD *)&v22.x = *(_QWORD *)&bounds->m_Center.x;
		    v22.z = z;
		    v7 = UnityEngine::Vector3::op_Multiply(&v24.m_Center, -1.0, &v22, v5);
		    *(_QWORD *)&v22.x = *(_QWORD *)&bounds->m_Extents.x;
		    v8 = *(_QWORD *)&v7->x;
		    v9 = v7->z;
		    *(float *)&v7 = bounds->m_Extents.z;
		    *(_QWORD *)&v23.x = v8;
		    *(_QWORD *)&v24.m_Center.x = *(_QWORD *)&v22.x;
		    LODWORD(v24.m_Center.z) = (_DWORD)v7;
		    *(_QWORD *)&v25.x = *(_QWORD *)&v22.x;
		    v10 = (__m128)(unsigned int)v8;
		    v11 = (__m128)HIDWORD(v8);
		    v10.m128_f32[0] = v10.m128_f32[0] / v22.x;
		    v11.m128_f32[0] = v11.m128_f32[0] / v22.y;
		    v12 = v9 / bounds->m_Extents.z;
		    *(_QWORD *)&v24.m_Center.x = _mm_unpacklo_ps(v10, v11).m128_u64[0];
		    v24.m_Center.z = v12;
		    *(_QWORD *)&v23.x = *(_QWORD *)&v22.x;
		    LODWORD(v23.z) = (_DWORD)v7;
		    v14 = UnityEngine::Vector3::Scale(&v25, &v23, &v24.m_Center, v13);
		  }
		  v19 = *(_QWORD *)&v14->x;
		  v20 = v14->z;
		  *(_QWORD *)&retstr->x = v19;
		  retstr->z = v20;
		  return retstr;
		}
		
	}
}
