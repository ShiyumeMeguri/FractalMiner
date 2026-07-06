using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGInteractionComponent : MonoBehaviour, IHGInteractionObject
	{
		public HGInteractionComponent()
		{
			// // HGInteractionComponent()
			// void HG::Rendering::Runtime::HGInteractionComponent::HGInteractionComponent(
			//         HGInteractionComponent *this,
			//         MethodInfo *method)
			// {
			//   _OWORD *v3; // rax
			//   __int128 v4; // xmm1
			//   __int128 v5; // xmm2
			//   __int128 v6; // xmm3
			//   _BYTE v7[72]; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   this.fields.Radius = 0.5;
			//   this.fields.Height = 1.0;
			//   this.fields.Extent.x = 1.0;
			//   this.fields.Extent.y = 1.0;
			//   v3 = (_OWORD *)sub_182805160(v7);
			//   v4 = v3[1];
			//   v5 = v3[2];
			//   v6 = v3[3];
			//   *(_OWORD *)&this.fields.lastTransform.m00 = *v3;
			//   *(_OWORD *)&this.fields.lastTransform.m01 = v4;
			//   *(_OWORD *)&this.fields.lastTransform.m02 = v5;
			//   *(_OWORD *)&this.fields.lastTransform.m03 = v6;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGInteractionComponent::OnEnable(HGInteractionComponent *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGInterationManager *interactionManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1506, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       interactionManager_k__BackingField = currentManagerContext.fields._interactionManager_k__BackingField;
			//       if ( interactionManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGInterationManager::Register(
			//           interactionManager_k__BackingField,
			//           (IHGInteractionObject *)this,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(interactionManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1506, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGInteractionComponent::OnDisable(HGInteractionComponent *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGInterationManager *interactionManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1509, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       interactionManager_k__BackingField = currentManagerContext.fields._interactionManager_k__BackingField;
			//       if ( interactionManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGInterationManager::Unregister(
			//           interactionManager_k__BackingField,
			//           (IHGInteractionObject *)this,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(interactionManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1509, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void CollectInteractionNodes(List<HGInteractionNode> nodes)
		{
			// // Void CollectInteractionNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
			// void HG::Rendering::Runtime::HGInteractionComponent::CollectInteractionNodes(
			//         HGInteractionComponent *this,
			//         List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
			//         MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v9; // xmm6
			//   __int128 v10; // xmm7
			//   __int128 v11; // xmm8
			//   __int128 v12; // xmm9
			//   _OWORD *v13; // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   bool v17; // al
			//   __int128 v18; // xmm4
			//   __int128 v19; // xmm5
			//   __int128 v20; // xmm6
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm2
			//   __int128 v24; // xmm3
			//   float v25; // xmm7_4
			//   Transform *v26; // rax
			//   MethodInfo *v27; // rdx
			//   Vector3 *up; // rax
			//   __int64 v29; // xmm3_8
			//   MethodInfo *v30; // r9
			//   Vector3 *v31; // rax
			//   float *v32; // r8
			//   __int64 v33; // xmm0_8
			//   __int64 v34; // xmm3_8
			//   MethodInfo *v35; // rdx
			//   Vector3 *down; // rax
			//   __int64 v37; // xmm3_8
			//   MethodInfo *v38; // r9
			//   Vector3 *v39; // rax
			//   __int64 v40; // xmm3_8
			//   Transform *v41; // rax
			//   float v42; // xmm6_4
			//   Object_1 *v43; // rax
			//   int32_t InstanceID; // eax
			//   uint32_t ProxyType; // edx
			//   uint32_t v46; // edx
			//   uint32_t v47; // edx
			//   HGInteractionNode *v48; // rax
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm0
			//   _OWORD *p_m23; // rax
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v61; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v62; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v63; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v64; // [rsp+88h] [rbp-80h] BYREF
			//   Matrix4x4 v65; // [rsp+98h] [rbp-70h] BYREF
			//   Matrix4x4 v66; // [rsp+D8h] [rbp-30h] BYREF
			//   Matrix4x4 v67; // [rsp+118h] [rbp+10h] BYREF
			//   Matrix4x4 v68; // [rsp+158h] [rbp+50h] BYREF
			//   RaycastHit v69; // [rsp+198h] [rbp+90h] BYREF
			//   _OWORD v70[12]; // [rsp+1D8h] [rbp+D0h] BYREF
			//   HGInteractionNode v71; // [rsp+298h] [rbp+190h] BYREF
			// 
			//   if ( !byte_18D919E09 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
			//     byte_18D919E09 = 1;
			//   }
			//   sub_1802F01E0(&v65, 0LL, 64LL);
			//   sub_1802F01E0(&v69, 0LL, 64LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1511, 0LL) )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v67, transform, 0LL);
			//       v9 = *(_OWORD *)&this.fields.lastTransform.m00;
			//       v10 = *(_OWORD *)&this.fields.lastTransform.m01;
			//       v11 = *(_OWORD *)&this.fields.lastTransform.m02;
			//       v12 = *(_OWORD *)&this.fields.lastTransform.m03;
			//       v65 = *localToWorldMatrix;
			//       v13 = (_OWORD *)sub_182805160(&v67);
			//       v14 = v13[1];
			//       *(_OWORD *)&v68.m00 = *v13;
			//       v15 = v13[2];
			//       *(_OWORD *)&v68.m01 = v14;
			//       v16 = v13[3];
			//       *(_OWORD *)&v68.m02 = v15;
			//       *(_OWORD *)&v68.m03 = v16;
			//       *(_OWORD *)&v67.m00 = v9;
			//       *(_OWORD *)&v67.m01 = v10;
			//       *(_OWORD *)&v67.m02 = v11;
			//       *(_OWORD *)&v67.m03 = v12;
			//       v17 = UnityEngine::Matrix4x4::op_Equality(&v67, &v68, 0LL);
			//       v18 = *(_OWORD *)&v65.m03;
			//       v19 = *(_OWORD *)&v65.m02;
			//       v20 = *(_OWORD *)&v65.m01;
			//       if ( v17 )
			//       {
			//         v21 = *(_OWORD *)&v65.m00;
			//         v22 = *(_OWORD *)&v65.m01;
			//         v23 = *(_OWORD *)&v65.m02;
			//         v24 = *(_OWORD *)&v65.m03;
			//       }
			//       else
			//       {
			//         v21 = *(_OWORD *)&this.fields.lastTransform.m00;
			//         v22 = *(_OWORD *)&this.fields.lastTransform.m01;
			//         v23 = *(_OWORD *)&this.fields.lastTransform.m02;
			//         v24 = *(_OWORD *)&this.fields.lastTransform.m03;
			//       }
			//       *(_OWORD *)&this.fields.lastTransform.m00 = *(_OWORD *)&v65.m00;
			//       v25 = 32.5;
			//       *(_OWORD *)&this.fields.lastTransform.m01 = v20;
			//       *(_OWORD *)&this.fields.lastTransform.m02 = v19;
			//       *(_OWORD *)&this.fields.lastTransform.m03 = v18;
			//       *(_OWORD *)&v66.m00 = v21;
			//       *(_OWORD *)&v66.m01 = v22;
			//       *(_OWORD *)&v66.m02 = v23;
			//       *(_OWORD *)&v66.m03 = v24;
			//       v26 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( v26 )
			//       {
			//         UnityEngine::Transform::get_position(&v63, v26, 0LL);
			//         up = UnityEngine::Vector3::get_up(&v61, v27);
			//         v29 = *(_QWORD *)&up.x;
			//         v62.z = up.z;
			//         *(_QWORD *)&v62.x = v29;
			//         v31 = UnityEngine::Vector3::op_Multiply(&v61, &v62, 0.5, v30);
			//         v33 = *(_QWORD *)v32;
			//         v34 = *(_QWORD *)&v31.x;
			//         v62.z = v31.z;
			//         v61.z = v32[2];
			//         *(_QWORD *)&v62.x = v34;
			//         *(_QWORD *)&v61.x = v33;
			//         down = UnityEngine::Vector3::get_down(&v64, v35);
			//         v37 = *(_QWORD *)&down.x;
			//         *(float *)&down = down.z;
			//         *(_QWORD *)&v63.x = v37;
			//         LODWORD(v63.z) = (_DWORD)down;
			//         v39 = UnityEngine::Vector3::op_Addition(&v64, &v61, &v62, v38);
			//         v40 = *(_QWORD *)&v39.x;
			//         *(float *)&v39 = v39.z;
			//         *(_QWORD *)&v61.x = v40;
			//         LODWORD(v61.z) = (_DWORD)v39;
			//         if ( UnityEngine::Physics::Raycast(&v61, &v63, &v69, 32.5, 0LL) )
			//           v25 = v69.m_Distance - 0.5;
			//         v41 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( v41 )
			//         {
			//           v42 = UnityEngine::Transform::get_position(&v64, v41, 0LL).y - v25;
			//           v43 = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//           if ( v43 )
			//           {
			//             InstanceID = UnityEngine::Object::GetInstanceID(v43, 0LL);
			//             ProxyType = this.fields.ProxyType;
			//             if ( ProxyType )
			//             {
			//               v46 = ProxyType - 1;
			//               if ( v46 )
			//               {
			//                 v47 = v46 - 1;
			//                 if ( v47 )
			//                 {
			//                   if ( v47 != 1 )
			//                     return;
			//                   v48 = HG::Rendering::Runtime::HGInteractionNode::CreateMeshNode(
			//                           &v71,
			//                           InstanceID,
			//                           this.fields.ProxyMesh,
			//                           &v65,
			//                           &v66,
			//                           v42,
			//                           this.fields.bUseCCD,
			//                           0LL);
			//                 }
			//                 else
			//                 {
			//                   v48 = HG::Rendering::Runtime::HGInteractionNode::CreateTextureNode(
			//                           &v71,
			//                           InstanceID,
			//                           this.fields.MaskTexture,
			//                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                                  (__m128)LODWORD(this.fields.Extent.x),
			//                                                  (__m128)LODWORD(this.fields.Extent.y)),
			//                           this.fields.Height,
			//                           &v65,
			//                           &v66,
			//                           v42,
			//                           this.fields.bUseCCD,
			//                           0LL);
			//                 }
			//               }
			//               else
			//               {
			//                 v48 = HG::Rendering::Runtime::HGInteractionNode::CreateCapsuleNode(
			//                         &v71,
			//                         InstanceID,
			//                         this.fields.Height,
			//                         this.fields.Radius,
			//                         &v65,
			//                         &v66,
			//                         v42,
			//                         this.fields.bUseCCD,
			//                         0LL);
			//               }
			//             }
			//             else
			//             {
			//               v48 = HG::Rendering::Runtime::HGInteractionNode::CreateSphereNode(
			//                       &v71,
			//                       InstanceID,
			//                       this.fields.Radius,
			//                       &v65,
			//                       &v66,
			//                       v42,
			//                       this.fields.bUseCCD,
			//                       0LL);
			//             }
			//             if ( nodes )
			//             {
			//               v49 = *(_OWORD *)&v48.localToWorldMatrix.m20;
			//               v70[0] = *(_OWORD *)&v48.NodeKey;
			//               v50 = *(_OWORD *)&v48.localToWorldMatrix.m21;
			//               v70[1] = v49;
			//               v51 = *(_OWORD *)&v48.localToWorldMatrix.m22;
			//               v70[2] = v50;
			//               v52 = *(_OWORD *)&v48.localToWorldMatrix.m23;
			//               v70[3] = v51;
			//               v53 = *(_OWORD *)&v48.prevLocalToWorldMatrix.m20;
			//               v70[4] = v52;
			//               v54 = *(_OWORD *)&v48.prevLocalToWorldMatrix.m21;
			//               v70[5] = v53;
			//               v70[6] = v54;
			//               v55 = *(_OWORD *)&v48.prevLocalToWorldMatrix.m22;
			//               p_m23 = (_OWORD *)&v48.prevLocalToWorldMatrix.m23;
			//               v70[7] = v55;
			//               v57 = p_m23[1];
			//               v70[8] = *p_m23;
			//               v58 = p_m23[2];
			//               v70[9] = v57;
			//               v59 = p_m23[3];
			//               v70[10] = v58;
			//               v70[11] = v59;
			//               sub_1806072B4(
			//                 nodes,
			//                 v70,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1511, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)nodes,
			//     0LL);
			// }
			// 
		}

		public EInteractionProxyType ProxyType;

		public bool bUseCCD;

		public float Radius;

		public float Height;

		public Vector2 Extent;

		public Texture MaskTexture;

		public Mesh ProxyMesh;

		private Matrix4x4 lastTransform;
	}
}
