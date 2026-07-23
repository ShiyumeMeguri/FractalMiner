using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGInteractionComponent : MonoBehaviour, IHGInteractionObject // TypeDefIndex: 37748
	{
		// Fields
		public EInteractionProxyType ProxyType; // 0x18
		public bool bUseCCD; // 0x1C
		public float Radius; // 0x20
		public float Height; // 0x24
		public Vector2 Extent; // 0x28
		public Texture MaskTexture; // 0x30
		public Mesh ProxyMesh; // 0x38
		private Matrix4x4 lastTransform; // 0x40
	
		// Constructors
		public HGInteractionComponent() {} // 0x0000000189CFE7C4-0x0000000189CFE810
		// HGInteractionComponent()
		void HG::Rendering::Runtime::HGInteractionComponent::HGInteractionComponent(
		        HGInteractionComponent *this,
		        MethodInfo *method)
		{
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v3; // xmm1
		  __int128 v4; // xmm2
		  __int128 v5; // xmm3
		
		  this->fields.Radius = 0.5;
		  this->fields.Height = 1.0;
		  this->fields.Extent.x = 1.0;
		  this->fields.Extent.y = 1.0;
		  static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v3 = *(_OWORD *)&static_fields->identityMatrix.m01;
		  v4 = *(_OWORD *)&static_fields->identityMatrix.m02;
		  v5 = *(_OWORD *)&static_fields->identityMatrix.m03;
		  *(_OWORD *)&this->fields.lastTransform.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		  *(_OWORD *)&this->fields.lastTransform.m01 = v3;
		  *(_OWORD *)&this->fields.lastTransform.m02 = v4;
		  *(_OWORD *)&this->fields.lastTransform.m03 = v5;
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000189CFE74C-0x0000000189CFE7C4
		// Void OnEnable()
		void HG::Rendering::Runtime::HGInteractionComponent::OnEnable(HGInteractionComponent *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGInterationManager *interactionManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1793, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      return;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      interactionManager_k__BackingField = currentManagerContext->fields._interactionManager_k__BackingField;
		      if ( interactionManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGInterationManager::Register(
		          interactionManager_k__BackingField,
		          (IHGInteractionObject *)this,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(interactionManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1793, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000189CFE6D4-0x0000000189CFE74C
		// Void OnDisable()
		void HG::Rendering::Runtime::HGInteractionComponent::OnDisable(HGInteractionComponent *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGInterationManager *interactionManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1796, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      return;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      interactionManager_k__BackingField = currentManagerContext->fields._interactionManager_k__BackingField;
		      if ( interactionManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGInterationManager::Unregister(
		          interactionManager_k__BackingField,
		          (IHGInteractionObject *)this,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(interactionManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1796, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void CollectInteractionNodes(List<HGInteractionNode> nodes) {} // 0x0000000189CFE248-0x0000000189CFE6D4
		// Void CollectInteractionNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
		void HG::Rendering::Runtime::HGInteractionComponent::CollectInteractionNodes(
		        HGInteractionComponent *this,
		        List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  bool v16; // al
		  __int128 v17; // xmm4
		  __int128 v18; // xmm5
		  __int128 v19; // xmm6
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm2
		  __int128 v23; // xmm3
		  float v24; // xmm7_4
		  Transform *v25; // rax
		  MethodInfo *v26; // rdx
		  Vector3 *up; // rax
		  __int64 v28; // xmm3_8
		  MethodInfo *v29; // r9
		  Vector3 *v30; // rax
		  float *v31; // r8
		  __int64 v32; // xmm0_8
		  __int64 v33; // xmm3_8
		  MethodInfo *v34; // rdx
		  Vector3 *down; // rax
		  __int64 v36; // xmm3_8
		  MethodInfo *v37; // r9
		  Vector3 *v38; // rax
		  __int64 v39; // xmm3_8
		  Transform *v40; // rax
		  float v41; // xmm6_4
		  Object_1 *v42; // rax
		  int32_t InstanceID; // eax
		  uint32_t ProxyType; // edx
		  uint32_t v45; // edx
		  uint32_t v46; // edx
		  HGInteractionNode *v47; // rax
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm0
		  _OWORD *p_m23; // rax
		  __int128 v56; // xmm0
		  __int128 v57; // xmm1
		  __int128 v58; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v60; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v61; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v62; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v63; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v64; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 v65; // [rsp+D8h] [rbp-30h] BYREF
		  Matrix4x4 v66; // [rsp+118h] [rbp+10h] BYREF
		  Matrix4x4 v67; // [rsp+158h] [rbp+50h] BYREF
		  RaycastHit v68; // [rsp+198h] [rbp+90h] BYREF
		  _OWORD v69[12]; // [rsp+1D8h] [rbp+D0h] BYREF
		  HGInteractionNode v70; // [rsp+298h] [rbp+190h] BYREF
		
		  sub_18033B9D0(&v64, 0LL, 64LL);
		  sub_18033B9D0(&v68, 0LL, 64LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(1798, 0LL) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      v64 = *UnityEngine::Transform::get_localToWorldMatrix(&v66, transform, 0LL);
		      static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v9 = *(_OWORD *)&static_fields->identityMatrix.m01;
		      *(_OWORD *)&v67.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		      v10 = *(_OWORD *)&static_fields->identityMatrix.m02;
		      *(_OWORD *)&v67.m01 = v9;
		      v11 = *(_OWORD *)&static_fields->identityMatrix.m03;
		      *(_OWORD *)&v67.m02 = v10;
		      v12 = *(_OWORD *)&this->fields.lastTransform.m00;
		      *(_OWORD *)&v67.m03 = v11;
		      v13 = *(_OWORD *)&this->fields.lastTransform.m01;
		      *(_OWORD *)&v66.m00 = v12;
		      v14 = *(_OWORD *)&this->fields.lastTransform.m02;
		      *(_OWORD *)&v66.m01 = v13;
		      v15 = *(_OWORD *)&this->fields.lastTransform.m03;
		      *(_OWORD *)&v66.m02 = v14;
		      *(_OWORD *)&v66.m03 = v15;
		      v16 = UnityEngine::Matrix4x4::op_Equality(&v66, &v67, 0LL);
		      v17 = *(_OWORD *)&v64.m03;
		      v18 = *(_OWORD *)&v64.m02;
		      v19 = *(_OWORD *)&v64.m01;
		      if ( v16 )
		      {
		        v20 = *(_OWORD *)&v64.m00;
		        v21 = *(_OWORD *)&v64.m01;
		        v22 = *(_OWORD *)&v64.m02;
		        v23 = *(_OWORD *)&v64.m03;
		      }
		      else
		      {
		        v20 = *(_OWORD *)&this->fields.lastTransform.m00;
		        v21 = *(_OWORD *)&this->fields.lastTransform.m01;
		        v22 = *(_OWORD *)&this->fields.lastTransform.m02;
		        v23 = *(_OWORD *)&this->fields.lastTransform.m03;
		      }
		      *(_OWORD *)&this->fields.lastTransform.m00 = *(_OWORD *)&v64.m00;
		      v24 = 32.5;
		      *(_OWORD *)&this->fields.lastTransform.m01 = v19;
		      *(_OWORD *)&this->fields.lastTransform.m02 = v18;
		      *(_OWORD *)&this->fields.lastTransform.m03 = v17;
		      *(_OWORD *)&v65.m00 = v20;
		      *(_OWORD *)&v65.m01 = v21;
		      *(_OWORD *)&v65.m02 = v22;
		      *(_OWORD *)&v65.m03 = v23;
		      v25 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v25 )
		      {
		        UnityEngine::Transform::get_position(&v62, v25, 0LL);
		        up = UnityEngine::Vector3::get_up(&v60, v26);
		        v28 = *(_QWORD *)&up->x;
		        v61.z = up->z;
		        *(_QWORD *)&v61.x = v28;
		        v30 = UnityEngine::Vector3::op_Multiply(&v60, &v61, 0.5, v29);
		        v32 = *(_QWORD *)v31;
		        v33 = *(_QWORD *)&v30->x;
		        v61.z = v30->z;
		        v60.z = v31[2];
		        *(_QWORD *)&v61.x = v33;
		        *(_QWORD *)&v60.x = v32;
		        down = UnityEngine::Vector3::get_down(&v63, v34);
		        v36 = *(_QWORD *)&down->x;
		        *(float *)&down = down->z;
		        *(_QWORD *)&v62.x = v36;
		        LODWORD(v62.z) = (_DWORD)down;
		        v38 = UnityEngine::Vector3::op_Addition(&v63, &v60, &v61, v37);
		        v39 = *(_QWORD *)&v38->x;
		        *(float *)&v38 = v38->z;
		        *(_QWORD *)&v60.x = v39;
		        LODWORD(v60.z) = (_DWORD)v38;
		        if ( UnityEngine::Physics::Raycast(&v60, &v62, &v68, 32.5, 0LL) )
		          v24 = v68.m_Distance - 0.5;
		        v40 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( v40 )
		        {
		          v41 = UnityEngine::Transform::get_position(&v63, v40, 0LL)->y - v24;
		          v42 = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		          if ( v42 )
		          {
		            InstanceID = UnityEngine::Object::GetInstanceID(v42, 0LL);
		            ProxyType = this->fields.ProxyType;
		            if ( ProxyType )
		            {
		              v45 = ProxyType - 1;
		              if ( v45 )
		              {
		                v46 = v45 - 1;
		                if ( v46 )
		                {
		                  if ( v46 != 1 )
		                    return;
		                  v47 = HG::Rendering::Runtime::HGInteractionNode::CreateMeshNode(
		                          &v70,
		                          InstanceID,
		                          this->fields.ProxyMesh,
		                          &v64,
		                          &v65,
		                          v41,
		                          this->fields.bUseCCD,
		                          0LL);
		                }
		                else
		                {
		                  v47 = HG::Rendering::Runtime::HGInteractionNode::CreateTextureNode(
		                          &v70,
		                          InstanceID,
		                          this->fields.MaskTexture,
		                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                 (__m128)LODWORD(this->fields.Extent.x),
		                                                 (__m128)LODWORD(this->fields.Extent.y)),
		                          this->fields.Height,
		                          &v64,
		                          &v65,
		                          v41,
		                          this->fields.bUseCCD,
		                          0LL);
		                }
		              }
		              else
		              {
		                v47 = HG::Rendering::Runtime::HGInteractionNode::CreateCapsuleNode(
		                        &v70,
		                        InstanceID,
		                        this->fields.Height,
		                        this->fields.Radius,
		                        &v64,
		                        &v65,
		                        v41,
		                        this->fields.bUseCCD,
		                        0LL);
		              }
		            }
		            else
		            {
		              v47 = HG::Rendering::Runtime::HGInteractionNode::CreateSphereNode(
		                      &v70,
		                      InstanceID,
		                      this->fields.Radius,
		                      &v64,
		                      &v65,
		                      v41,
		                      this->fields.bUseCCD,
		                      0LL);
		            }
		            if ( nodes )
		            {
		              v48 = *(_OWORD *)&v47->localToWorldMatrix.m20;
		              v69[0] = *(_OWORD *)&v47->NodeKey;
		              v49 = *(_OWORD *)&v47->localToWorldMatrix.m21;
		              v69[1] = v48;
		              v50 = *(_OWORD *)&v47->localToWorldMatrix.m22;
		              v69[2] = v49;
		              v51 = *(_OWORD *)&v47->localToWorldMatrix.m23;
		              v69[3] = v50;
		              v52 = *(_OWORD *)&v47->prevLocalToWorldMatrix.m20;
		              v69[4] = v51;
		              v53 = *(_OWORD *)&v47->prevLocalToWorldMatrix.m21;
		              v69[5] = v52;
		              v69[6] = v53;
		              v54 = *(_OWORD *)&v47->prevLocalToWorldMatrix.m22;
		              p_m23 = (_OWORD *)&v47->prevLocalToWorldMatrix.m23;
		              v69[7] = v54;
		              v56 = p_m23[1];
		              v69[8] = *p_m23;
		              v57 = p_m23[2];
		              v69[9] = v56;
		              v58 = p_m23[3];
		              v69[10] = v57;
		              v69[11] = v58;
		              sub_180362F8C(
		                nodes,
		                v69,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_22:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1798, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)nodes,
		    0LL);
		}
		
	}
}
