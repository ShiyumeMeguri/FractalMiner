using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGInteractionNode
	{
		private void ConstructNodeBase(int _nodeKey, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // Void ConstructNodeBase(Int32, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
			//         HGInteractionNode *this,
			//         int32_t _nodeKey,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm2
			//   __int128 v15; // xmm3
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm2
			//   __int128 v18; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&_nodeKey);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1514 )
			//   {
			// LABEL_7:
			//     this.bUseCCD = _ccd;
			//     this.NodeKey = _nodeKey;
			//     v13 = *(_OWORD *)&_transform.m01;
			//     v14 = *(_OWORD *)&_transform.m02;
			//     v15 = *(_OWORD *)&_transform.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&_transform.m00;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v13;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v14;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v15;
			//     v16 = *(_OWORD *)&_prevTransform.m01;
			//     v17 = *(_OWORD *)&_prevTransform.m02;
			//     v18 = *(_OWORD *)&_prevTransform.m03;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m00 = *(_OWORD *)&_prevTransform.m00;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m01 = v16;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m02 = v17;
			//     this.GroundHeight = _groundHeight;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m03 = v18;
			//     return;
			//   }
			//   if ( !v11._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v11, wrapperArray);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11.static_fields.wrapperArray;
			//   if ( !v11 )
			//     goto LABEL_8;
			//   if ( LODWORD(v11._0.namespaze) <= 0x5EA )
			//     sub_180070270(v11, wrapperArray);
			//   if ( !v11[32]._0.interopData )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1514, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v11, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_573(
			//     Patch,
			//     this,
			//     _nodeKey,
			//     _transform,
			//     _prevTransform,
			//     _groundHeight,
			//     _ccd,
			//     0LL);
			// }
			// 
		}

		private void ConstructSphereNode(int _nodeKey, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // Void ConstructSphereNode(Int32, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGInteractionNode::ConstructSphereNode(
			//         HGInteractionNode *this,
			//         int32_t _nodeKey,
			//         float _radius,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v11; // rdx
			//   bool v12; // zf
			//   __m128 v13; // xmm0
			//   Vector3 *Position; // rax
			//   Vector3 *v15; // rax
			//   __int64 v16; // xmm0_8
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm0_8
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm3_8
			//   double v22; // xmm0_8
			//   float v23; // xmm9_4
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v24; // rcx
			//   MethodInfo *v25; // rdx
			//   Vector3 *v26; // rax
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v27; // rcx
			//   Vector3 *fwd; // rax
			//   __int64 v29; // xmm3_8
			//   MethodInfo *v30; // r8
			//   Vector4 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   MethodInfo *v34; // r8
			//   char IsSame; // al
			//   __int64 v36; // rdx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v37; // rcx
			//   __m128 z_low; // xmm6
			//   double v39; // xmm0_8
			//   Vector3 *v40; // rax
			//   __int64 v41; // xmm6_8
			//   float z; // ebx
			//   Quaternion *v43; // rax
			//   __m128 radius_low; // xmm0
			//   float radius; // xmm2_4
			//   float v46; // xmm2_4
			//   Matrix4x4 *v47; // rax
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm2
			//   __int128 v50; // xmm3
			//   __int64 v51; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector3 v53; // [rsp+58h] [rbp-79h] BYREF
			//   Vector3 v54; // [rsp+68h] [rbp-69h] BYREF
			//   Vector4 v55; // [rsp+78h] [rbp-59h] BYREF
			//   Vector4 v56; // [rsp+88h] [rbp-49h] BYREF
			//   Matrix4x4 v57; // [rsp+98h] [rbp-39h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1513, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1513, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v51);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_574(
			//       Patch,
			//       this,
			//       _nodeKey,
			//       _radius,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.ProxyType = 0;
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
			//       this,
			//       _nodeKey,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     v12 = !this.bUseCCD;
			//     this.radius = _radius;
			//     if ( v12 )
			//     {
			//       v13 = *(__m128 *)&_radius;
			//       v13.m128_f32[0] = _radius + _radius;
			//       *(_QWORD *)&v53.x = _mm_unpacklo_ps(v13, (__m128)0x3F800000u).m128_u64[0];
			//       v53.z = _radius + _radius;
			//       v55 = (Vector4)*UnityEngine::Quaternion::get_identity((Quaternion *)&v55, v11);
			//       Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v56, _transform, 0LL);
			//       v13.m128_u64[0] = *(_QWORD *)&Position.x;
			//       *(float *)&Position = Position.z;
			//       *(_QWORD *)&v54.x = v13.m128_u64[0];
			//       LODWORD(v54.z) = (_DWORD)Position;
			//     }
			//     else
			//     {
			//       v15 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v56, _prevTransform, 0LL);
			//       v16 = *(_QWORD *)&v15.x;
			//       *(float *)&v15 = v15.z;
			//       *(_QWORD *)&v53.x = v16;
			//       LODWORD(v53.z) = (_DWORD)v15;
			//       v17 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v56, _transform, 0LL);
			//       v18 = *(_QWORD *)&v17.x;
			//       *(float *)&v17 = v17.z;
			//       *(_QWORD *)&v54.x = v18;
			//       LODWORD(v54.z) = (_DWORD)v17;
			//       v20 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v56, &v54, &v53, v19);
			//       v21 = *(_QWORD *)&v20.x;
			//       *(float *)&v20 = v20.z;
			//       *(_QWORD *)&v53.x = v21;
			//       LODWORD(v53.z) = (_DWORD)v20;
			//       v22 = sub_18238EFA0(&v53);
			//       this.radius = _radius;
			//       v23 = *(float *)&v22;
			//       if ( (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                               v24,
			//                               0.0,
			//                               _radius) )
			//       {
			//         fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v56, v25);
			//         v29 = *(_QWORD *)&fwd.x;
			//         *(float *)&fwd = fwd.z;
			//         *(_QWORD *)&v53.x = v29;
			//         LODWORD(v53.z) = (_DWORD)fwd;
			//         v31 = *UnityEngine::Vector4::op_Implicit(&v55, &v53, v30);
			//         *(_OWORD *)&v57.m00 = *(_OWORD *)&_transform.m00;
			//         v32 = *(_OWORD *)&_transform.m02;
			//         v55 = v31;
			//         v33 = *(_OWORD *)&_transform.m01;
			//         *(_OWORD *)&v57.m02 = v32;
			//         *(_OWORD *)&v57.m01 = v33;
			//         *(_OWORD *)&v57.m03 = *(_OWORD *)&_transform.m03;
			//         v55 = *UnityEngine::Matrix4x4::op_Multiply(&v56, &v57, &v55, 0LL);
			//         v26 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v56, &v55, v34);
			//       }
			//       else
			//       {
			//         v26 = (Vector3 *)sub_182413270(&v56, &v53);
			//       }
			//       v53 = *v26;
			//       IsSame = UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v27, 0.0, _radius);
			//       z_low = (__m128)LODWORD(v53.z);
			//       if ( !IsSame
			//         || !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                                v37,
			//                                0.0,
			//                                _radius) )
			//       {
			//         sub_1802E8DF0(v37, v36);
			//       }
			//       *(_QWORD *)&v54.x = _mm_unpacklo_ps((__m128)LODWORD(v53.x), z_low).m128_u64[0];
			//       v39 = sub_182413570(&v54);
			//       this.interactHeight = v53.y * v23;
			//       this.interactLength = *(float *)&v39 * v23;
			//       v40 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v56, _transform, 0LL);
			//       v41 = *(_QWORD *)&v40.x;
			//       z = v40.z;
			//       v43 = (Quaternion *)sub_182504D40(&v55);
			//       radius_low = (__m128)LODWORD(this.radius);
			//       radius = this.radius;
			//       radius_low.m128_f32[0] = radius_low.m128_f32[0] + radius_low.m128_f32[0];
			//       *(_QWORD *)&v54.x = v41;
			//       v54.z = z;
			//       v46 = (float)(radius + radius) + this.interactLength;
			//       *(_QWORD *)&v53.x = _mm_unpacklo_ps(radius_low, (__m128)0x3F800000u).m128_u64[0];
			//       v55 = (Vector4)*v43;
			//       v53.z = v46;
			//     }
			//     v47 = UnityEngine::Matrix4x4::TRS(&v57, &v54, (Quaternion *)&v55, &v53, 0LL);
			//     v48 = *(_OWORD *)&v47.m01;
			//     v49 = *(_OWORD *)&v47.m02;
			//     v50 = *(_OWORD *)&v47.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&v47.m00;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v48;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v49;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v50;
			//   }
			// }
			// 
		}

		private void DrawSphereNode(CommandBuffer cmd, Material material)
		{
			// // Void DrawSphereNode(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionNode::DrawSphereNode(
			//         HGInteractionNode *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Shader *shader; // rbx
			//   String *s_InteractionUseCCD; // r8
			//   Mesh *QuadMesh; // rax
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int32_t v18; // [rsp+30h] [rbp-31h]
			//   LocalKeyword v19; // [rsp+48h] [rbp-19h] BYREF
			//   LocalKeyword keyword; // [rsp+60h] [rbp-1h] BYREF
			//   Matrix4x4 v21; // [rsp+78h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919E0E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919E0E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1524, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1524, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, this, (Object *)cmd, (Object *)material, 0LL);
			//   }
			//   else
			//   {
			//     if ( !material
			//       || (shader = UnityEngine::Material::get_shader(material, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
			//           s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_InteractionUseCCD,
			//           memset(&v19, 0, sizeof(v19)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, s_InteractionUseCCD, 0LL),
			//           keyword = v19,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v8, v7);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, material, &keyword, 0, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GroundHeight,
			//       this.GroundHeight,
			//       0LL);
			//     if ( this.bUseCCD )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//         cmd,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractRadius,
			//         this.radius,
			//         0LL);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//         cmd,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractLength,
			//         this.interactLength,
			//         0LL);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//         cmd,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractHeight,
			//         this.interactHeight,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//       v18 = 1;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//         cmd,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractRadius,
			//         this.radius,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//       v18 = 0;
			//     }
			//     v12 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     *(_OWORD *)&v21.m01 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     v13 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v21.m00 = v12;
			//     v14 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v21.m03 = v13;
			//     *(_OWORD *)&v21.m02 = v14;
			//     UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, QuadMesh, &v21, material, 0, v18, 0LL);
			//   }
			// }
			// 
		}

		private HGInteractionNodeRenderData BuildSphereRenderData()
		{
			// // HGInteractionNodeRenderData BuildSphereRenderData()
			// HGInteractionNodeRenderData *HG::Rendering::Runtime::HGInteractionNode::BuildSphereRenderData(
			//         HGInteractionNodeRenderData *__return_ptr retstr,
			//         HGInteractionNode *this,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm1
			//   __int128 v6; // xmm0
			//   __int128 v7; // xmm1
			//   Matrix4x4 *inverse; // rax
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   HGInteractionNodeRenderData *v35; // rax
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   HGInteractionNodeRenderData v50; // [rsp+28h] [rbp-E0h] BYREF
			//   __int128 v51; // [rsp+118h] [rbp+10h]
			//   __int128 v52; // [rsp+128h] [rbp+20h]
			//   __int128 v53; // [rsp+138h] [rbp+30h]
			//   __int128 v54; // [rsp+148h] [rbp+40h]
			//   Matrix4x4 worldToLocal; // [rsp+158h] [rbp+50h]
			//   Matrix4x4 prevLocalToWorld; // [rsp+198h] [rbp+90h]
			//   __int128 v57; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v58; // [rsp+1E8h] [rbp+E0h]
			//   OneofDescriptor v59; // [rsp+1F8h] [rbp+F0h] BYREF
			// 
			//   if ( !byte_18D919E0F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     byte_18D919E0F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1525, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1525, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v34, v33);
			//     v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(&v50, Patch, this, 0LL);
			//     v36 = *(_OWORD *)&v35.instanceData.localToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m00 = *(_OWORD *)&v35.instanceData.localToWorld.m00;
			//     v37 = *(_OWORD *)&v35.instanceData.localToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m01 = v36;
			//     v38 = *(_OWORD *)&v35.instanceData.localToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m02 = v37;
			//     v39 = *(_OWORD *)&v35.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m03 = v38;
			//     v40 = *(_OWORD *)&v35.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m00 = v39;
			//     v41 = *(_OWORD *)&v35.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m01 = v40;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m02 = v41;
			//     v42 = *(_OWORD *)&v35.instanceData.worldToLocal.m03;
			//     v35 = (HGInteractionNodeRenderData *)((char *)v35 + 128);
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m03 = v42;
			//     v43 = *(_OWORD *)&v35.instanceData.localToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&v35.instanceData.localToWorld.m00;
			//     v44 = *(_OWORD *)&v35.instanceData.localToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m01 = v43;
			//     v45 = *(_OWORD *)&v35.instanceData.localToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m02 = v44;
			//     v46 = *(_OWORD *)&v35.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m03 = v45;
			//     v47 = *(_OWORD *)&v35.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.radius = v46;
			//     v48 = *(_OWORD *)&v35.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.groundHeight = v47;
			//     *(_OWORD *)&retstr.mesh = v48;
			//   }
			//   else
			//   {
			//     v59.monitor = 0LL;
			//     sub_1802F01E0(&v50, 0LL, 224LL);
			//     v5 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     *(_OWORD *)&v50.instanceData.localToWorld.m00 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     v6 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v50.instanceData.localToWorld.m01 = v5;
			//     v7 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v50.instanceData.localToWorld.m02 = v6;
			//     *(_OWORD *)&v50.instanceData.localToWorld.m03 = v7;
			//     inverse = UnityEngine::Matrix4x4::get_inverse((Matrix4x4 *)&v59.fields, &this.localToWorldMatrix, 0LL);
			//     v50.instanceData.capsuleLocalHeight = 0.0;
			//     v50.instanceData.heightScale = 1.0;
			//     v9 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&v50.instanceData.worldToLocal.m00 = *(_OWORD *)&inverse.m00;
			//     v10 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&v50.instanceData.worldToLocal.m01 = v9;
			//     v11 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&v50.instanceData.worldToLocal.m02 = v10;
			//     v12 = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//     *(_OWORD *)&v50.instanceData.worldToLocal.m03 = v11;
			//     v13 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//     *(_OWORD *)&v50.instanceData.prevLocalToWorld.m00 = v12;
			//     v14 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//     *(_OWORD *)&v50.instanceData.prevLocalToWorld.m01 = v13;
			//     v15 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//     *(_OWORD *)&v50.instanceData.prevLocalToWorld.m02 = v14;
			//     *(float *)&v14 = this.radius;
			//     *(_OWORD *)&v50.instanceData.prevLocalToWorld.m03 = v15;
			//     *(float *)&v15 = this.interactLength;
			//     LODWORD(v50.instanceData.radius) = v14;
			//     *(float *)&v14 = this.interactHeight;
			//     LODWORD(v50.instanceData.length) = v15;
			//     *(float *)&v15 = this.GroundHeight;
			//     LODWORD(v50.instanceData.height) = v14;
			//     LODWORD(v50.instanceData.groundHeight) = v15;
			//     v51 = *(_OWORD *)&v50.instanceData.localToWorld.m00;
			//     v52 = *(_OWORD *)&v50.instanceData.localToWorld.m01;
			//     v53 = *(_OWORD *)&v50.instanceData.localToWorld.m02;
			//     v54 = *(_OWORD *)&v50.instanceData.localToWorld.m03;
			//     worldToLocal = v50.instanceData.worldToLocal;
			//     prevLocalToWorld = v50.instanceData.prevLocalToWorld;
			//     v57 = *(_OWORD *)&v50.instanceData.radius;
			//     v58 = *(_OWORD *)&v50.instanceData.groundHeight;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     v59.klass = (OneofDescriptor__Class *)HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//     sub_1800054D0(
			//       &v59,
			//       v16,
			//       v17,
			//       v18,
			//       *(String__Array **)&v50.instanceData.localToWorld.m00,
			//       *(String **)&v50.instanceData.localToWorld.m20,
			//       *(MethodInfo **)&v50.instanceData.localToWorld.m01);
			//     BYTE4(v59.monitor) = 0;
			//     LODWORD(v59.monitor) = this.bUseCCD;
			//     v19 = v52;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m00 = v51;
			//     v20 = v53;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m01 = v19;
			//     v21 = v54;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m02 = v20;
			//     v22 = *(_OWORD *)&worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m03 = v21;
			//     v23 = *(_OWORD *)&worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m00 = v22;
			//     v24 = *(_OWORD *)&worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m01 = v23;
			//     v25 = *(_OWORD *)&worldToLocal.m03;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m02 = v24;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m03 = v25;
			//     v26 = *(_OWORD *)&prevLocalToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&prevLocalToWorld.m00;
			//     v27 = *(_OWORD *)&prevLocalToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m01 = v26;
			//     v28 = *(_OWORD *)&prevLocalToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m02 = v27;
			//     v29 = v57;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m03 = v28;
			//     v30 = v58;
			//     *(_OWORD *)&retstr.instanceData.radius = v29;
			//     v31 = *(_OWORD *)&v59.klass;
			//     *(_OWORD *)&retstr.instanceData.groundHeight = v30;
			//     *(_OWORD *)&retstr.mesh = v31;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void ConstructCapsuleNode(int _nodeKey, float _length, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // Void ConstructCapsuleNode(Int32, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
			//         HGInteractionNode *this,
			//         int32_t _nodeKey,
			//         float _length,
			//         float _radius,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v9; // r8
			//   struct ILFixDynamicMethodWrapper_2__Class *v14; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool v16; // zf
			//   Matrix4x4 *v17; // rdi
			//   Matrix4x4 *v18; // rsi
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm2
			//   __int128 v21; // xmm3
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm2
			//   __int128 v24; // xmm3
			//   Vector4 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int64 v28; // rdx
			//   Vector4 v29; // xmm6
			//   __int32 v30; // xmm1_4
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *static_fields; // rcx
			//   float v32; // xmm7_4
			//   float v33; // xmm2_4
			//   Vector4 v34; // xmm0
			//   __int64 v35; // r8
			//   MethodInfo *v36; // r9
			//   __m128 v37; // xmm9
			//   float length; // xmm11_4
			//   struct Math__Class *v39; // rcx
			//   __m128d v40; // xmm1
			//   double v41; // xmm0_8
			//   float v42; // xmm0_4
			//   __m128 m03_low; // xmm6
			//   __m128 m13_low; // xmm7
			//   float m23; // xmm11_4
			//   Vector3 *v46; // rax
			//   __int64 v47; // xmm3_8
			//   void (__fastcall *v48)(Vector3 *, Quaternion *); // rax
			//   __m128 radius_low; // xmm0
			//   float radius; // xmm1_4
			//   void (__fastcall *v51)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *); // rax
			//   float v52; // xmm1_4
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v57; // rax
			//   __int64 v58; // rax
			//   __int64 v59; // rax
			//   float v60; // xmm9_4
			//   __m128 v61; // xmm6
			//   __m128 v62; // xmm7
			//   float v63; // xmm8_4
			//   Quaternion *rotation; // rax
			//   __m128 z_low; // xmm2
			//   Matrix4x4 *v66; // rax
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm2
			//   __int128 v69; // xmm3
			//   __m128 v70; // xmm6
			//   __m128 v71; // xmm7
			//   float v72; // xmm8_4
			//   Quaternion *v73; // rax
			//   __m128 v74; // xmm2
			//   Matrix4x4 *v75; // rax
			//   __int128 v76; // xmm1
			//   __int128 v77; // xmm2
			//   __int128 v78; // xmm3
			//   Vector3 v79; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v80; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v81; // [rsp+78h] [rbp-90h] BYREF
			//   Quaternion v82; // [rsp+88h] [rbp-80h] BYREF
			//   Quaternion v83; // [rsp+98h] [rbp-70h] BYREF
			//   Matrix4x4 v84; // [rsp+A8h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&_nodeKey);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_28;
			//   if ( wrapperArray.max_length.size > 1516 )
			//   {
			//     if ( !v14._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v14, wrapperArray);
			//       v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v14.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_28;
			//     if ( wrapperArray.max_length.size <= 0x5ECu )
			//       goto LABEL_46;
			//     if ( wrapperArray[42].vector[4] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1516, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_576(
			//           Patch,
			//           this,
			//           _nodeKey,
			//           _length,
			//           _radius,
			//           _transform,
			//           _prevTransform,
			//           _groundHeight,
			//           _ccd,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_28;
			//     }
			//   }
			//   v16 = byte_18D8EDC37 == 0;
			//   this.ProxyType = 1;
			//   if ( v16 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_28;
			//   if ( wrapperArray.max_length.size <= 1514 )
			//   {
			// LABEL_13:
			//     v17 = _transform;
			//     v18 = _prevTransform;
			//     this.NodeKey = _nodeKey;
			//     this.bUseCCD = _ccd;
			//     v19 = *(_OWORD *)&_transform.m01;
			//     v20 = *(_OWORD *)&_transform.m02;
			//     v21 = *(_OWORD *)&_transform.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&_transform.m00;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v19;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v20;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v21;
			//     v22 = *(_OWORD *)&_prevTransform.m01;
			//     v23 = *(_OWORD *)&_prevTransform.m02;
			//     v24 = *(_OWORD *)&_prevTransform.m03;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m00 = *(_OWORD *)&_prevTransform.m00;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m01 = v22;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m02 = v23;
			//     this.GroundHeight = _groundHeight;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m03 = v24;
			//     goto LABEL_14;
			//   }
			//   if ( !v14._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v14, wrapperArray);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v14 = (struct ILFixDynamicMethodWrapper_2__Class *)v14.static_fields.wrapperArray;
			//   if ( !v14 )
			// LABEL_28:
			//     sub_180B536AC(v14, wrapperArray);
			//   if ( LODWORD(v14._0.namespaze) <= 0x5EA )
			// LABEL_46:
			//     sub_180070270(v14, wrapperArray);
			//   if ( !v14[32]._0.interopData )
			//     goto LABEL_13;
			//   v57 = IFix::WrappersManagerImpl::GetPatch(1514, 0LL);
			//   if ( !v57 )
			//     goto LABEL_28;
			//   v17 = _transform;
			//   v18 = _prevTransform;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_573(
			//     v57,
			//     this,
			//     _nodeKey,
			//     _transform,
			//     _prevTransform,
			//     _groundHeight,
			//     _ccd,
			//     0LL);
			// LABEL_14:
			//   v16 = !this.bUseCCD;
			//   this.length = _length;
			//   this.radius = _radius;
			//   if ( v16 )
			//   {
			//     v80.z = 0.0;
			//     *(_QWORD *)&v80.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//     v25 = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v82, &v80, v9);
			//     *(_OWORD *)&v84.m00 = *(_OWORD *)&v17.m00;
			//     v26 = *(_OWORD *)&v17.m02;
			//     v83 = (Quaternion)v25;
			//     v27 = *(_OWORD *)&v17.m01;
			//     *(_OWORD *)&v84.m02 = v26;
			//     *(_OWORD *)&v84.m01 = v27;
			//     *(_OWORD *)&v84.m03 = *(_OWORD *)&v17.m03;
			//     v29 = *UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v82, &v84, (Vector4 *)&v83, 0LL);
			//     if ( !byte_18D8E3A94 )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//       byte_18D8E3A94 = 1;
			//     }
			//     COERCE_FLOAT(v30 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//     static_fields = (UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *)TypeInfo::UnityEngine::Mathf.static_fields;
			//     LODWORD(v32) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 170).m128_u32[0];
			//     v33 = fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v29.x) & v30), 0.0) * 0.000001, *(float *)static_fields * 8.0);
			//     if ( v33 > COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v29.x) & v30)
			//       && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                             static_fields,
			//                             0.0,
			//                             v33) )
			//     {
			//       v37 = 0LL;
			//     }
			//     else
			//     {
			//       v34 = v29;
			//       v34.x = sub_1802E8DF0(static_fields, v28);
			//       v37 = (__m128)v34;
			//       v37.m128_f32[0] = v34.x * 57.29578;
			//     }
			//     length = this.length;
			//     if ( !byte_18D8E3A72 )
			//     {
			//       sub_18003C530(&TypeInfo::System::Math);
			//       byte_18D8E3A72 = 1;
			//     }
			//     v39 = TypeInfo::System::Math;
			//     if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v28);
			//     v40 = 0LL;
			//     v40.m128d_f64[0] = (float)((float)(v32 * v32) + (float)(v29.x * v29.x));
			//     if ( v40.m128d_f64[0] < 0.0 )
			//       v41 = sub_1801C22C0(v39, v28, v35);
			//     else
			//       *(_QWORD *)&v41 = *(_OWORD *)&_mm_sqrt_pd(v40);
			//     v42 = v41;
			//     this.interactHeight = _mm_shuffle_ps((__m128)v29, (__m128)v29, 85).m128_f32[0] * this.length;
			//     this.interactLength = v42 * length;
			//     m03_low = (__m128)LODWORD(v17.m03);
			//     m13_low = (__m128)LODWORD(v17.m13);
			//     m23 = v17.m23;
			//     v80.z = 0.0;
			//     *(_QWORD *)&v80.x = _mm_unpacklo_ps((__m128)0LL, v37).m128_u64[0];
			//     v46 = UnityEngine::Vector3::op_Multiply(&v79, &v80, 0.017453292, v36);
			//     v83 = 0LL;
			//     v47 = *(_QWORD *)&v46.x;
			//     v80.z = v46.z;
			//     v48 = (void (__fastcall *)(Vector3 *, Quaternion *))qword_18D8F4C40;
			//     *(_QWORD *)&v80.x = v47;
			//     if ( !qword_18D8F4C40 )
			//     {
			//       v48 = (void (__fastcall *)(Vector3 *, Quaternion *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(Unity"
			//                                                             "Engine.Vector3&,UnityEngine.Quaternion&)");
			//       if ( !v48 )
			//       {
			//         v58 = sub_1802DBBE8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//         sub_18000F750(v58, 0LL);
			//       }
			//       qword_18D8F4C40 = (__int64)v48;
			//     }
			//     v48(&v80, &v83);
			//     radius_low = (__m128)LODWORD(this.radius);
			//     radius = this.radius;
			//     radius_low.m128_f32[0] = radius_low.m128_f32[0] + radius_low.m128_f32[0];
			//     v51 = (void (__fastcall *)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *))qword_18D8F4BC8;
			//     v79.z = m23;
			//     *(_QWORD *)&v79.x = _mm_unpacklo_ps(m03_low, m13_low).m128_u64[0];
			//     *(_QWORD *)&v81.x = _mm_unpacklo_ps(radius_low, (__m128)0x3F800000u).m128_u64[0];
			//     v52 = (float)(radius + radius) + this.interactLength;
			//     v82 = v83;
			//     memset(&v84, 0, sizeof(v84));
			//     v81.z = v52;
			//     if ( !qword_18D8F4BC8 )
			//     {
			//       v51 = (void (__fastcall *)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                     "UnityEngine.Matrix4x4::TRS_Injected("
			//                                                                                     "UnityEngine.Vector3&,UnityEngine.Qua"
			//                                                                                     "ternion&,UnityEngine.Vector3&,UnityE"
			//                                                                                     "ngine.Matrix4x4&)");
			//       if ( !v51 )
			//       {
			//         v59 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
			//                 "ityEngine.Matrix4x4&)");
			//         sub_18000F750(v59, 0LL);
			//       }
			//       qword_18D8F4BC8 = (__int64)v51;
			//     }
			//     v51(&v79, &v82, &v81, &v84);
			//     v53 = *(_OWORD *)&v84.m01;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&v84.m00;
			//     v54 = *(_OWORD *)&v84.m02;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v53;
			//     v55 = *(_OWORD *)&v84.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v54;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v55;
			//   }
			//   else
			//   {
			//     if ( _radius <= 0.0099999998 )
			//       v60 = 4.0;
			//     else
			//       v60 = (float)(_length / _radius) + 2.0;
			//     v61 = (__m128)LODWORD(v17.m03);
			//     v62 = (__m128)LODWORD(v17.m13);
			//     v63 = v17.m23;
			//     rotation = UnityEngine::Matrix4x4::get_rotation(&v82, v17, 0LL);
			//     v79.z = this.radius;
			//     z_low = (__m128)LODWORD(v79.z);
			//     v81.z = v63;
			//     *(_QWORD *)&v81.x = _mm_unpacklo_ps(v61, v62).m128_u64[0];
			//     z_low.m128_f32[0] = (float)((float)(z_low.m128_f32[0] + z_low.m128_f32[0]) + this.length) / v60;
			//     *(_QWORD *)&v79.x = _mm_unpacklo_ps((__m128)LODWORD(v79.z), z_low).m128_u64[0];
			//     v82 = *rotation;
			//     v66 = UnityEngine::Matrix4x4::TRS(&v84, &v81, &v82, &v79, 0LL);
			//     v67 = *(_OWORD *)&v66.m01;
			//     v68 = *(_OWORD *)&v66.m02;
			//     v69 = *(_OWORD *)&v66.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&v66.m00;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v67;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v68;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v69;
			//     v70 = (__m128)LODWORD(v18.m03);
			//     v71 = (__m128)LODWORD(v18.m13);
			//     v72 = v18.m23;
			//     v73 = UnityEngine::Matrix4x4::get_rotation(&v82, v18, 0LL);
			//     v79.z = this.radius;
			//     v74 = (__m128)LODWORD(v79.z);
			//     v81.z = v72;
			//     *(_QWORD *)&v81.x = _mm_unpacklo_ps(v70, v71).m128_u64[0];
			//     v74.m128_f32[0] = (float)((float)(v74.m128_f32[0] + v74.m128_f32[0]) + this.length) / v60;
			//     *(_QWORD *)&v79.x = _mm_unpacklo_ps((__m128)LODWORD(v79.z), v74).m128_u64[0];
			//     v82 = *v73;
			//     v75 = UnityEngine::Matrix4x4::TRS(&v84, &v81, &v82, &v79, 0LL);
			//     v76 = *(_OWORD *)&v75.m01;
			//     v77 = *(_OWORD *)&v75.m02;
			//     v78 = *(_OWORD *)&v75.m03;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m00 = *(_OWORD *)&v75.m00;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m01 = v76;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m02 = v77;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m03 = v78;
			//   }
			// }
			// 
		}

		private void DrawCapsuleNode(CommandBuffer cmd, Material material)
		{
			// // Void DrawCapsuleNode(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionNode::DrawCapsuleNode(
			//         HGInteractionNode *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Shader *shader; // rbx
			//   String *s_InteractionUseCCD; // r8
			//   int32_t InteractWorldToLocal; // ebx
			//   Matrix4x4 *inverse; // rax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm1
			//   int32_t PrevInteractLocalToWorld; // edx
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   Mesh *Capsule; // rdx
			//   float radius; // xmm0_4
			//   float v22; // xmm2_4
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   int32_t v29; // [rsp+30h] [rbp-71h]
			//   Matrix4x4 v30; // [rsp+48h] [rbp-59h] BYREF
			//   LocalKeyword v31; // [rsp+88h] [rbp-19h] BYREF
			//   LocalKeyword keyword; // [rsp+A0h] [rbp-1h] BYREF
			//   Matrix4x4 value; // [rsp+B8h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919E10 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919E10 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1526, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1526, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v28, v27);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, this, (Object *)cmd, (Object *)material, 0LL);
			//   }
			//   else
			//   {
			//     if ( !material
			//       || (shader = UnityEngine::Material::get_shader(material, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
			//           s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_InteractionUseCCD,
			//           memset(&v31, 0, sizeof(v31)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v31, shader, s_InteractionUseCCD, 0LL),
			//           keyword = v31,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v8, v7);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, material, &keyword, this.bUseCCD, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GroundHeight,
			//       this.GroundHeight,
			//       0LL);
			//     InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractWorldToLocal;
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v30, &this.localToWorldMatrix, 0LL);
			//     v13 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&value.m00 = *(_OWORD *)&inverse.m00;
			//     v14 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&value.m01 = v13;
			//     v15 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&value.m02 = v14;
			//     *(_OWORD *)&value.m03 = v15;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
			//     v16 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//     PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PrevInteractLocalToWorld;
			//     *(_OWORD *)&v30.m00 = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//     v18 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//     *(_OWORD *)&v30.m01 = v16;
			//     v19 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//     *(_OWORD *)&v30.m02 = v18;
			//     *(_OWORD *)&v30.m03 = v19;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, PrevInteractLocalToWorld, &v30, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractRadius,
			//       this.radius,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractLength,
			//       this.interactLength,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractHeight,
			//       this.interactHeight,
			//       0LL);
			//     if ( this.bUseCCD )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       radius = this.radius;
			//       if ( radius <= 0.0099999998 )
			//         v22 = 1.0;
			//       else
			//         v22 = (float)(this.length * 0.5) / radius;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//         cmd,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CapsuleLocalHeight,
			//         v22,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       v29 = 4;
			//       Capsule = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields.Capsule;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       Capsule = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//       v29 = 1;
			//     }
			//     v23 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     *(_OWORD *)&v30.m01 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     v24 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v30.m00 = v23;
			//     v25 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v30.m03 = v24;
			//     *(_OWORD *)&v30.m02 = v25;
			//     UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, Capsule, &v30, material, 0, v29, 0LL);
			//   }
			// }
			// 
		}

		private HGInteractionNodeRenderData BuildCapsuleRenderData()
		{
			// // HGInteractionNodeRenderData BuildCapsuleRenderData()
			// HGInteractionNodeRenderData *HG::Rendering::Runtime::HGInteractionNode::BuildCapsuleRenderData(
			//         HGInteractionNodeRenderData *__return_ptr retstr,
			//         HGInteractionNode *this,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm1
			//   __int128 v6; // xmm0
			//   __int128 v7; // xmm1
			//   Matrix4x4 *inverse; // rax
			//   float v9; // xmm2_4
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   float radius; // xmm1_4
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   Mesh *Capsule; // rax
			//   bool bUseCCD; // cf
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   HGInteractionNodeRenderData *v39; // rax
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   __int128 v52; // xmm1
			//   HGInteractionNodeRenderData v54; // [rsp+28h] [rbp-E0h] BYREF
			//   __int128 v55; // [rsp+118h] [rbp+10h]
			//   __int128 v56; // [rsp+128h] [rbp+20h]
			//   __int128 v57; // [rsp+138h] [rbp+30h]
			//   __int128 v58; // [rsp+148h] [rbp+40h]
			//   Matrix4x4 worldToLocal; // [rsp+158h] [rbp+50h]
			//   Matrix4x4 prevLocalToWorld; // [rsp+198h] [rbp+90h]
			//   __int128 v61; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v62; // [rsp+1E8h] [rbp+E0h]
			//   OneofDescriptor v63; // [rsp+1F8h] [rbp+F0h] BYREF
			// 
			//   if ( !byte_18D919E11 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     byte_18D919E11 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1527, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1527, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v38, v37);
			//     v39 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(&v54, Patch, this, 0LL);
			//     v40 = *(_OWORD *)&v39.instanceData.localToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m00 = *(_OWORD *)&v39.instanceData.localToWorld.m00;
			//     v41 = *(_OWORD *)&v39.instanceData.localToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m01 = v40;
			//     v42 = *(_OWORD *)&v39.instanceData.localToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m02 = v41;
			//     v43 = *(_OWORD *)&v39.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m03 = v42;
			//     v44 = *(_OWORD *)&v39.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m00 = v43;
			//     v45 = *(_OWORD *)&v39.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m01 = v44;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m02 = v45;
			//     v46 = *(_OWORD *)&v39.instanceData.worldToLocal.m03;
			//     v39 = (HGInteractionNodeRenderData *)((char *)v39 + 128);
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m03 = v46;
			//     v47 = *(_OWORD *)&v39.instanceData.localToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&v39.instanceData.localToWorld.m00;
			//     v48 = *(_OWORD *)&v39.instanceData.localToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m01 = v47;
			//     v49 = *(_OWORD *)&v39.instanceData.localToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m02 = v48;
			//     v50 = *(_OWORD *)&v39.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m03 = v49;
			//     v51 = *(_OWORD *)&v39.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.radius = v50;
			//     v52 = *(_OWORD *)&v39.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.groundHeight = v51;
			//     *(_OWORD *)&retstr.mesh = v52;
			//   }
			//   else
			//   {
			//     v63.monitor = 0LL;
			//     sub_1802F01E0(&v54, 0LL, 224LL);
			//     v5 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     *(_OWORD *)&v54.instanceData.localToWorld.m00 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     v6 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v54.instanceData.localToWorld.m01 = v5;
			//     v7 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v54.instanceData.localToWorld.m02 = v6;
			//     *(_OWORD *)&v54.instanceData.localToWorld.m03 = v7;
			//     inverse = UnityEngine::Matrix4x4::get_inverse((Matrix4x4 *)&v63.fields, &this.localToWorldMatrix, 0LL);
			//     v9 = 1.0;
			//     v54.instanceData.heightScale = 1.0;
			//     v10 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&v54.instanceData.worldToLocal.m00 = *(_OWORD *)&inverse.m00;
			//     v11 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&v54.instanceData.worldToLocal.m01 = v10;
			//     v12 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&v54.instanceData.worldToLocal.m02 = v11;
			//     v13 = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//     *(_OWORD *)&v54.instanceData.worldToLocal.m03 = v12;
			//     v14 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//     *(_OWORD *)&v54.instanceData.prevLocalToWorld.m00 = v13;
			//     v15 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//     *(_OWORD *)&v54.instanceData.prevLocalToWorld.m01 = v14;
			//     v16 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//     *(_OWORD *)&v54.instanceData.prevLocalToWorld.m02 = v15;
			//     *(float *)&v15 = this.radius;
			//     *(_OWORD *)&v54.instanceData.prevLocalToWorld.m03 = v16;
			//     *(float *)&v16 = this.interactLength;
			//     LODWORD(v54.instanceData.radius) = v15;
			//     *(float *)&v15 = this.interactHeight;
			//     LODWORD(v54.instanceData.length) = v16;
			//     radius = this.radius;
			//     LODWORD(v54.instanceData.height) = v15;
			//     v54.instanceData.groundHeight = this.GroundHeight;
			//     if ( radius > 0.0099999998 )
			//       v9 = (float)(this.length * 0.5) / radius;
			//     v54.instanceData.capsuleLocalHeight = v9;
			//     v55 = *(_OWORD *)&v54.instanceData.localToWorld.m00;
			//     v56 = *(_OWORD *)&v54.instanceData.localToWorld.m01;
			//     v57 = *(_OWORD *)&v54.instanceData.localToWorld.m02;
			//     v58 = *(_OWORD *)&v54.instanceData.localToWorld.m03;
			//     worldToLocal = v54.instanceData.worldToLocal;
			//     prevLocalToWorld = v54.instanceData.prevLocalToWorld;
			//     v61 = *(_OWORD *)&v54.instanceData.radius;
			//     v62 = *(_OWORD *)&v54.instanceData.groundHeight;
			//     if ( this.bUseCCD )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       Capsule = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields.Capsule;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       Capsule = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//     }
			//     v63.klass = (OneofDescriptor__Class *)Capsule;
			//     sub_1800054D0(
			//       &v63,
			//       v18,
			//       v19,
			//       v20,
			//       *(String__Array **)&v54.instanceData.localToWorld.m00,
			//       *(String **)&v54.instanceData.localToWorld.m20,
			//       *(MethodInfo **)&v54.instanceData.localToWorld.m01);
			//     bUseCCD = this.bUseCCD;
			//     BYTE4(v63.monitor) = this.bUseCCD;
			//     LODWORD(v63.monitor) = bUseCCD ? 4 : 1;
			//     v23 = v56;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m00 = v55;
			//     v24 = v57;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m01 = v23;
			//     v25 = v58;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m02 = v24;
			//     v26 = *(_OWORD *)&worldToLocal.m00;
			//     *(_OWORD *)&retstr.instanceData.localToWorld.m03 = v25;
			//     v27 = *(_OWORD *)&worldToLocal.m01;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m00 = v26;
			//     v28 = *(_OWORD *)&worldToLocal.m02;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m01 = v27;
			//     v29 = *(_OWORD *)&worldToLocal.m03;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m02 = v28;
			//     *(_OWORD *)&retstr.instanceData.worldToLocal.m03 = v29;
			//     v30 = *(_OWORD *)&prevLocalToWorld.m01;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&prevLocalToWorld.m00;
			//     v31 = *(_OWORD *)&prevLocalToWorld.m02;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m01 = v30;
			//     v32 = *(_OWORD *)&prevLocalToWorld.m03;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m02 = v31;
			//     v33 = v61;
			//     *(_OWORD *)&retstr.instanceData.prevLocalToWorld.m03 = v32;
			//     v34 = v62;
			//     *(_OWORD *)&retstr.instanceData.radius = v33;
			//     v35 = *(_OWORD *)&v63.klass;
			//     *(_OWORD *)&retstr.instanceData.groundHeight = v34;
			//     *(_OWORD *)&retstr.mesh = v35;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void ConstructTextureNode(int _nodeKey, Texture _texture, Vector2 _extent, float _heightScale, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // Void ConstructTextureNode(Int32, Texture, Vector2, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// void HG::Rendering::Runtime::HGInteractionNode::ConstructTextureNode(
			//         HGInteractionNode *this,
			//         int32_t _nodeKey,
			//         Texture *_texture,
			//         Vector2 _extent,
			//         float _heightScale,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   float v10; // xmm2_4
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   MethodInfo *v18; // rdx
			//   Vector3 *fwd; // rax
			//   __int64 v20; // xmm3_8
			//   MethodInfo *v21; // r8
			//   Vector4 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   MethodInfo *v25; // r8
			//   Vector3 *v26; // rax
			//   unsigned int z_low; // ebx
			//   __m128 x_low; // xmm12
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v29; // rcx
			//   __int64 v30; // rdx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v31; // rcx
			//   __m128 v32; // xmm10
			//   Vector3 *Position; // rax
			//   __int64 v34; // xmm9_8
			//   float z; // ebx
			//   const __m128i *v36; // rax
			//   float y; // xmm7_4
			//   __m128 v38; // xmm6
			//   __m128i v39; // xmm8
			//   double v40; // xmm0_8
			//   Matrix4x4 *v41; // rax
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm2
			//   __int128 v44; // xmm3
			//   MethodInfo *v45; // rdx
			//   Vector3 *v46; // rax
			//   MethodInfo *v47; // r8
			//   Vector4 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   MethodInfo *v51; // r8
			//   Vector3 *v52; // rax
			//   unsigned int v53; // ebx
			//   __m128 v54; // xmm12
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v55; // rcx
			//   __int64 v56; // rdx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v57; // rcx
			//   __m128 v58; // xmm10
			//   Vector3 *v59; // rax
			//   __int64 v60; // xmm9_8
			//   float v61; // ebx
			//   const __m128i *v62; // rax
			//   float v63; // xmm7_4
			//   __m128 v64; // xmm6
			//   __m128i v65; // xmm8
			//   double v66; // xmm0_8
			//   Matrix4x4 *v67; // rax
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm2
			//   __int128 v70; // xmm3
			//   __int64 v71; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   String__Array *P3; // [rsp+28h] [rbp-E0h]
			//   String *P4; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *P5; // [rsp+38h] [rbp-D0h]
			//   Vector3 v76; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector4 v77; // [rsp+78h] [rbp-90h] BYREF
			//   Vector4 v78; // [rsp+88h] [rbp-80h] BYREF
			//   Matrix4x4 v79[2]; // [rsp+98h] [rbp-70h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1518, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1518, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v71);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_578(
			//       Patch,
			//       this,
			//       _nodeKey,
			//       (Object *)_texture,
			//       _extent,
			//       _heightScale,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.ProxyType = 1;
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
			//       this,
			//       _nodeKey,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     this.texture = _texture;
			//     sub_1800054D0((OneofDescriptor *)&this.texture, v15, v16, v17, P3, P4, P5);
			//     this.heightScale = _heightScale;
			//     this.extent = _extent;
			//     fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v77, v18);
			//     v20 = *(_QWORD *)&fwd.x;
			//     *(float *)&fwd = fwd.z;
			//     *(_QWORD *)&v76.x = v20;
			//     LODWORD(v76.z) = (_DWORD)fwd;
			//     v22 = *UnityEngine::Vector4::op_Implicit(&v78, &v76, v21);
			//     *(_OWORD *)&v79[0].m00 = *(_OWORD *)&_transform.m00;
			//     v23 = *(_OWORD *)&_transform.m02;
			//     v77 = v22;
			//     v24 = *(_OWORD *)&_transform.m01;
			//     *(_OWORD *)&v79[0].m02 = v23;
			//     *(_OWORD *)&v79[0].m01 = v24;
			//     *(_OWORD *)&v79[0].m03 = *(_OWORD *)&_transform.m03;
			//     v77 = *UnityEngine::Matrix4x4::op_Multiply(&v78, v79, &v77, 0LL);
			//     v26 = UnityEngine::Vector4::op_Implicit(&v76, &v77, v25);
			//     z_low = LODWORD(v26.z);
			//     *(_QWORD *)&v77.x = *(_QWORD *)&v26.x;
			//     x_low = (__m128)LODWORD(v77.x);
			//     v32 = (__m128)_mm_cvtsi32_si128(z_low);
			//     if ( !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v29, 0.0, v10)
			//       || !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v31, 0.0, v10) )
			//     {
			//       sub_1802E8DF0(v31, v30);
			//     }
			//     Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v77, _transform, 0LL);
			//     v34 = *(_QWORD *)&Position.x;
			//     z = Position.z;
			//     v36 = (const __m128i *)sub_182504D40(&v78);
			//     y = this.extent.y;
			//     v38 = (__m128)LODWORD(this.extent.x);
			//     v39 = _mm_loadu_si128(v36);
			//     *(_QWORD *)&v76.x = _mm_unpacklo_ps(v32, x_low).m128_u64[0];
			//     v40 = sub_182413570(&v76);
			//     v77.z = z;
			//     *(_QWORD *)&v76.x = _mm_unpacklo_ps(v38, (__m128)0x3F800000u).m128_u64[0];
			//     v76.z = *(float *)&v40 * y;
			//     v78 = (Vector4)v39;
			//     *(_QWORD *)&v77.x = v34;
			//     v41 = UnityEngine::Matrix4x4::TRS(v79, (Vector3 *)&v77, (Quaternion *)&v78, &v76, 0LL);
			//     v42 = *(_OWORD *)&v41.m01;
			//     v43 = *(_OWORD *)&v41.m02;
			//     v44 = *(_OWORD *)&v41.m03;
			//     *(_OWORD *)&this.localToWorldMatrix.m00 = *(_OWORD *)&v41.m00;
			//     *(_OWORD *)&this.localToWorldMatrix.m01 = v42;
			//     *(_OWORD *)&this.localToWorldMatrix.m02 = v43;
			//     *(_OWORD *)&this.localToWorldMatrix.m03 = v44;
			//     v46 = UnityEngine::Vector3::get_fwd(&v76, v45);
			//     *(_QWORD *)&v44 = *(_QWORD *)&v46.x;
			//     *(float *)&v46 = v46.z;
			//     *(_QWORD *)&v77.x = v44;
			//     LODWORD(v77.z) = (_DWORD)v46;
			//     v48 = *UnityEngine::Vector4::op_Implicit(&v78, (Vector3 *)&v77, v47);
			//     *(_OWORD *)&v79[0].m00 = *(_OWORD *)&_prevTransform.m00;
			//     v49 = *(_OWORD *)&_prevTransform.m02;
			//     v78 = v48;
			//     v50 = *(_OWORD *)&_prevTransform.m01;
			//     *(_OWORD *)&v79[0].m02 = v49;
			//     *(_OWORD *)&v79[0].m01 = v50;
			//     *(_OWORD *)&v79[0].m03 = *(_OWORD *)&_prevTransform.m03;
			//     v78 = *UnityEngine::Matrix4x4::op_Multiply(&v77, v79, &v78, 0LL);
			//     v52 = UnityEngine::Vector4::op_Implicit(&v76, &v78, v51);
			//     v53 = LODWORD(v52.z);
			//     *(_QWORD *)&v77.x = *(_QWORD *)&v52.x;
			//     v54 = (__m128)LODWORD(v77.x);
			//     v58 = (__m128)_mm_cvtsi32_si128(v53);
			//     if ( !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                              v55,
			//                              0.0,
			//                              *(float *)&v43)
			//       || !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                              v57,
			//                              0.0,
			//                              *(float *)&v43) )
			//     {
			//       sub_1802E8DF0(v57, v56);
			//     }
			//     v59 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v77, _prevTransform, 0LL);
			//     v60 = *(_QWORD *)&v59.x;
			//     v61 = v59.z;
			//     v62 = (const __m128i *)sub_182504D40(&v78);
			//     v63 = this.extent.y;
			//     v64 = (__m128)LODWORD(this.extent.x);
			//     v65 = _mm_loadu_si128(v62);
			//     *(_QWORD *)&v76.x = _mm_unpacklo_ps(v58, v54).m128_u64[0];
			//     v66 = sub_182413570(&v76);
			//     v76.z = v61;
			//     *(_QWORD *)&v77.x = _mm_unpacklo_ps(v64, (__m128)0x3F800000u).m128_u64[0];
			//     v77.z = *(float *)&v66 * v63;
			//     v78 = (Vector4)v65;
			//     *(_QWORD *)&v76.x = v60;
			//     v67 = UnityEngine::Matrix4x4::TRS(v79, &v76, (Quaternion *)&v78, (Vector3 *)&v77, 0LL);
			//     v68 = *(_OWORD *)&v67.m01;
			//     v69 = *(_OWORD *)&v67.m02;
			//     v70 = *(_OWORD *)&v67.m03;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m00 = *(_OWORD *)&v67.m00;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m01 = v68;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m02 = v69;
			//     *(_OWORD *)&this.prevLocalToWorldMatrix.m03 = v70;
			//   }
			// }
			// 
		}

		private void DrawTextureNode(CommandBuffer cmd, Material material)
		{
			// // Void DrawTextureNode(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionNode::DrawTextureNode(
			//         HGInteractionNode *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Shader *shader; // rbx
			//   String *s_InteractionUseCCD; // r8
			//   int32_t InteractMaskTexture; // ebx
			//   RenderTargetIdentifier *v12; // rax
			//   __int128 v13; // xmm1
			//   int32_t InteractWorldToLocal; // ebx
			//   Matrix4x4 *inverse; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm1
			//   int32_t PrevInteractLocalToWorld; // edx
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   Mesh *QuadMesh; // rax
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   LocalKeyword v29; // [rsp+40h] [rbp-C8h] BYREF
			//   __int64 v30; // [rsp+58h] [rbp-B0h]
			//   LocalKeyword keyword; // [rsp+60h] [rbp-A8h] BYREF
			//   __int128 v32; // [rsp+78h] [rbp-90h]
			//   __int128 v33; // [rsp+88h] [rbp-80h]
			//   __int128 v34; // [rsp+98h] [rbp-70h]
			//   Matrix4x4 value; // [rsp+A8h] [rbp-60h] BYREF
			//   Matrix4x4 v36; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919E12 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919E12 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1528, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1528, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v28, v27);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, this, (Object *)cmd, (Object *)material, 0LL);
			//   }
			//   else
			//   {
			//     if ( !material )
			//       goto LABEL_7;
			//     shader = UnityEngine::Material::get_shader(material, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_InteractionUseCCD;
			//     *(_OWORD *)&v29.m_Name = 0LL;
			//     v30 = 0LL;
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v29.m_Name, shader, s_InteractionUseCCD, 0LL);
			//     *(_QWORD *)&v32 = v30;
			//     *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v29.m_Name;
			//     if ( !cmd )
			// LABEL_7:
			//       sub_180B536AC(v8, v7);
			//     UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//       cmd,
			//       material,
			//       (LocalKeyword *)&keyword.m_Name,
			//       this.bUseCCD,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GroundHeight,
			//       this.GroundHeight,
			//       0LL);
			//     InteractMaskTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractMaskTexture;
			//     v12 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             (RenderTargetIdentifier *)&value,
			//             this.texture,
			//             0LL);
			//     v13 = *(_OWORD *)&v12.m_BufferPointer;
			//     *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v12.m_Type;
			//     *(_QWORD *)&v33 = *(_QWORD *)&v12.m_DepthSlice;
			//     v32 = v13;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//       cmd,
			//       InteractMaskTexture,
			//       (RenderTargetIdentifier *)&keyword.m_Name,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractHeightScale,
			//       this.heightScale,
			//       0LL);
			//     InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractWorldToLocal;
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v36, &this.localToWorldMatrix, 0LL);
			//     v16 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&value.m00 = *(_OWORD *)&inverse.m00;
			//     v17 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&value.m01 = v16;
			//     v18 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&value.m02 = v17;
			//     *(_OWORD *)&value.m03 = v18;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
			//     v19 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//     PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PrevInteractLocalToWorld;
			//     *(_OWORD *)&keyword.m_Name = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//     v21 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//     v32 = v19;
			//     v22 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//     v33 = v21;
			//     v34 = v22;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(
			//       cmd,
			//       PrevInteractLocalToWorld,
			//       (Matrix4x4 *)&keyword.m_Name,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
			//     *(_OWORD *)&v36.m00 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     v24 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v36.m01 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     v25 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v36.m02 = v24;
			//     *(_OWORD *)&v36.m03 = v25;
			//     UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, QuadMesh, &v36, material, 0, 2, 0LL);
			//   }
			// }
			// 
		}

		private void ConstructMeshNode(int _nodeKey, Mesh _mesh, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // Void ConstructMeshNode(Int32, Mesh, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// void HG::Rendering::Runtime::HGInteractionNode::ConstructMeshNode(
			//         HGInteractionNode *this,
			//         int32_t _nodeKey,
			//         Mesh *_mesh,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   __int64 v15; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   String__Array *P3; // [rsp+20h] [rbp-38h]
			//   String *P4; // [rsp+28h] [rbp-30h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-28h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1520, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1520, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_580(
			//       Patch,
			//       this,
			//       _nodeKey,
			//       (Object *)_mesh,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.ProxyType = 1;
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
			//       this,
			//       _nodeKey,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     this.mesh = _mesh;
			//     sub_1800054D0((OneofDescriptor *)&this.mesh, v12, v13, v14, P3, P4, P5);
			//   }
			// }
			// 
		}

		private void DrawMeshNode(CommandBuffer cmd, Material material)
		{
			// // Void DrawMeshNode(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionNode::DrawMeshNode(
			//         HGInteractionNode *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Shader *shader; // rbx
			//   String *s_InteractionUseCCD; // r8
			//   int32_t InteractWorldToLocal; // ebx
			//   Matrix4x4 *inverse; // rax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm1
			//   int32_t PrevInteractLocalToWorld; // edx
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm1
			//   Mesh *mesh; // rdx
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   LocalKeyword v27; // [rsp+40h] [rbp-C8h] BYREF
			//   LocalKeyword keyword; // [rsp+58h] [rbp-B0h] BYREF
			//   void *m_KeywordSpace; // [rsp+70h] [rbp-98h]
			//   Matrix4x4 v30; // [rsp+78h] [rbp-90h] BYREF
			//   Matrix4x4 value; // [rsp+B8h] [rbp-50h] BYREF
			//   Matrix4x4 v32; // [rsp+F8h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919E13 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919E13 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1529, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1529, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v26, v25);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, this, (Object *)cmd, (Object *)material, 0LL);
			//   }
			//   else
			//   {
			//     if ( !material )
			//       goto LABEL_7;
			//     shader = UnityEngine::Material::get_shader(material, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_InteractionUseCCD;
			//     *(_OWORD *)&v27.m_Name = 0LL;
			//     keyword.m_SpaceInfo.m_KeywordSpace = 0LL;
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v27.m_Name, shader, s_InteractionUseCCD, 0LL);
			//     m_KeywordSpace = keyword.m_SpaceInfo.m_KeywordSpace;
			//     *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v27.m_Name;
			//     if ( !cmd )
			// LABEL_7:
			//       sub_180B536AC(v8, v7);
			//     UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//       cmd,
			//       material,
			//       (LocalKeyword *)&keyword.m_Name,
			//       this.bUseCCD,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GroundHeight,
			//       this.GroundHeight,
			//       0LL);
			//     InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractWorldToLocal;
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v30, &this.localToWorldMatrix, 0LL);
			//     v13 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&value.m00 = *(_OWORD *)&inverse.m00;
			//     v14 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&value.m01 = v13;
			//     v15 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&value.m02 = v14;
			//     *(_OWORD *)&value.m03 = v15;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
			//     v16 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//     PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PrevInteractLocalToWorld;
			//     *(_OWORD *)&v32.m00 = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//     v18 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//     *(_OWORD *)&v32.m01 = v16;
			//     v19 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//     *(_OWORD *)&v32.m02 = v18;
			//     *(_OWORD *)&v32.m03 = v19;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, PrevInteractLocalToWorld, &v32, 0LL);
			//     v20 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     mesh = this.mesh;
			//     *(_OWORD *)&v30.m00 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     v22 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v30.m01 = v20;
			//     v23 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     *(_OWORD *)&v30.m02 = v22;
			//     *(_OWORD *)&v30.m03 = v23;
			//     UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, mesh, &v30, material, 0, 3, 0LL);
			//   }
			// }
			// 
		}

		public static HGInteractionNode CreateSphereNode(int _nodeKey, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // HGInteractionNode CreateSphereNode(Int32, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateSphereNode(
			//         HGInteractionNode *__return_ptr retstr,
			//         int32_t _nodeKey,
			//         float _radius,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   HGInteractionNode *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm0
			//   _OWORD *p_m23; // rax
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   HGInteractionNode *result; // rax
			//   HGInteractionNode v26; // [rsp+50h] [rbp-198h] BYREF
			//   HGInteractionNode v27; // [rsp+110h] [rbp-D8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1512, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1512, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, 0LL);
			//     v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_575(
			//             &v27,
			//             Patch,
			//             _nodeKey,
			//             _radius,
			//             _transform,
			//             _prevTransform,
			//             _groundHeight,
			//             _ccd,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v26, 0LL, 192LL);
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructSphereNode(
			//       &v26,
			//       _nodeKey,
			//       _radius,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     v11 = &v26;
			//   }
			//   v14 = *(_OWORD *)&v11.localToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.NodeKey = *(_OWORD *)&v11.NodeKey;
			//   v15 = *(_OWORD *)&v11.localToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m20 = v14;
			//   v16 = *(_OWORD *)&v11.localToWorldMatrix.m22;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m21 = v15;
			//   v17 = *(_OWORD *)&v11.localToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m22 = v16;
			//   v18 = *(_OWORD *)&v11.prevLocalToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m23 = v17;
			//   v19 = *(_OWORD *)&v11.prevLocalToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m20 = v18;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m21 = v19;
			//   v20 = *(_OWORD *)&v11.prevLocalToWorldMatrix.m22;
			//   p_m23 = (_OWORD *)&v11.prevLocalToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m22 = v20;
			//   v22 = p_m23[1];
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m23 = *p_m23;
			//   v23 = p_m23[2];
			//   *(_OWORD *)&retstr.length = v22;
			//   v24 = p_m23[3];
			//   result = retstr;
			//   *(_OWORD *)&retstr.texture = v23;
			//   *(_OWORD *)&retstr.heightScale = v24;
			//   return result;
			// }
			// 
			return null;
		}

		public static HGInteractionNode CreateCapsuleNode(int _nodeKey, float _length, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // HGInteractionNode CreateCapsuleNode(Int32, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateCapsuleNode(
			//         HGInteractionNode *__return_ptr retstr,
			//         int32_t _nodeKey,
			//         float _length,
			//         float _radius,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGInteractionNode *v13; // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   HGInteractionNode *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGInteractionNode v26; // [rsp+50h] [rbp-1A8h] BYREF
			//   HGInteractionNode v27; // [rsp+110h] [rbp-E8h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&_nodeKey);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1515 )
			//   {
			//     if ( !v11._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v11, wrapperArray);
			//       v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11.static_fields.wrapperArray;
			//     if ( v11 )
			//     {
			//       if ( LODWORD(v11._0.namespaze) <= 0x5EB )
			//         sub_180070270(v11, wrapperArray);
			//       if ( !v11[32]._0.klass )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1515, 0LL);
			//       if ( Patch )
			//       {
			//         v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_577(
			//                 &v27,
			//                 Patch,
			//                 _nodeKey,
			//                 _length,
			//                 _radius,
			//                 _transform,
			//                 _prevTransform,
			//                 _groundHeight,
			//                 _ccd,
			//                 0LL);
			//         goto LABEL_8;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v11, wrapperArray);
			//   }
			// LABEL_7:
			//   sub_1802F01E0(&v26, 0LL, 192LL);
			//   HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
			//     &v26,
			//     _nodeKey,
			//     _length,
			//     _radius,
			//     _transform,
			//     _prevTransform,
			//     _groundHeight,
			//     _ccd,
			//     0LL);
			//   v13 = &v26;
			// LABEL_8:
			//   v14 = *(_OWORD *)&v13.localToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.NodeKey = *(_OWORD *)&v13.NodeKey;
			//   v15 = *(_OWORD *)&v13.localToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m20 = v14;
			//   v16 = *(_OWORD *)&v13.localToWorldMatrix.m22;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m21 = v15;
			//   v17 = *(_OWORD *)&v13.localToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m22 = v16;
			//   v18 = *(_OWORD *)&v13.prevLocalToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m23 = v17;
			//   v19 = *(_OWORD *)&v13.prevLocalToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m20 = v18;
			//   v20 = *(_OWORD *)&v13.prevLocalToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m21 = v19;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m22 = *(_OWORD *)&v13.prevLocalToWorldMatrix.m22;
			//   v21 = *(_OWORD *)&v13.length;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m23 = v20;
			//   v22 = *(_OWORD *)&v13.texture;
			//   *(_OWORD *)&retstr.length = v21;
			//   v23 = *(_OWORD *)&v13.heightScale;
			//   result = retstr;
			//   *(_OWORD *)&retstr.texture = v22;
			//   *(_OWORD *)&retstr.heightScale = v23;
			//   return result;
			// }
			// 
			return null;
		}

		public static HGInteractionNode CreateTextureNode(int _nodeKey, Texture _texture, Vector2 _extent, float _heightScale, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // HGInteractionNode CreateTextureNode(Int32, Texture, Vector2, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateTextureNode(
			//         HGInteractionNode *__return_ptr retstr,
			//         int32_t _nodeKey,
			//         Texture *_texture,
			//         Vector2 _extent,
			//         float _heightScale,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   HGInteractionNode *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v16; // rcx
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm0
			//   _OWORD *p_m23; // rax
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   HGInteractionNode *result; // rax
			//   HGInteractionNode v29; // [rsp+60h] [rbp-198h] BYREF
			//   HGInteractionNode v30; // [rsp+120h] [rbp-D8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1517, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1517, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, 0LL);
			//     v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_579(
			//             &v30,
			//             Patch,
			//             _nodeKey,
			//             (Object *)_texture,
			//             _extent,
			//             _heightScale,
			//             _transform,
			//             _prevTransform,
			//             _groundHeight,
			//             _ccd,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v29, 0LL, 192LL);
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructTextureNode(
			//       &v29,
			//       _nodeKey,
			//       _texture,
			//       _extent,
			//       _heightScale,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     v14 = &v29;
			//   }
			//   v17 = *(_OWORD *)&v14.localToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.NodeKey = *(_OWORD *)&v14.NodeKey;
			//   v18 = *(_OWORD *)&v14.localToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m20 = v17;
			//   v19 = *(_OWORD *)&v14.localToWorldMatrix.m22;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m21 = v18;
			//   v20 = *(_OWORD *)&v14.localToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m22 = v19;
			//   v21 = *(_OWORD *)&v14.prevLocalToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m23 = v20;
			//   v22 = *(_OWORD *)&v14.prevLocalToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m20 = v21;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m21 = v22;
			//   v23 = *(_OWORD *)&v14.prevLocalToWorldMatrix.m22;
			//   p_m23 = (_OWORD *)&v14.prevLocalToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m22 = v23;
			//   v25 = p_m23[1];
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m23 = *p_m23;
			//   v26 = p_m23[2];
			//   *(_OWORD *)&retstr.length = v25;
			//   v27 = p_m23[3];
			//   result = retstr;
			//   *(_OWORD *)&retstr.texture = v26;
			//   *(_OWORD *)&retstr.heightScale = v27;
			//   return result;
			// }
			// 
			return null;
		}

		public static HGInteractionNode CreateMeshNode(int _nodeKey, Mesh _mesh, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd)
		{
			// // HGInteractionNode CreateMeshNode(Int32, Mesh, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
			// HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateMeshNode(
			//         HGInteractionNode *__return_ptr retstr,
			//         int32_t _nodeKey,
			//         Mesh *_mesh,
			//         Matrix4x4 *_transform,
			//         Matrix4x4 *_prevTransform,
			//         float _groundHeight,
			//         bool _ccd,
			//         MethodInfo *method)
			// {
			//   HGInteractionNode *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm0
			//   _OWORD *p_m23; // rax
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   HGInteractionNode *result; // rax
			//   HGInteractionNode v27; // [rsp+50h] [rbp-188h] BYREF
			//   HGInteractionNode v28; // [rsp+110h] [rbp-C8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1519, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1519, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, 0LL);
			//     v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_581(
			//             &v28,
			//             Patch,
			//             _nodeKey,
			//             (Object *)_mesh,
			//             _transform,
			//             _prevTransform,
			//             _groundHeight,
			//             _ccd,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v27, 0LL, 192LL);
			//     HG::Rendering::Runtime::HGInteractionNode::ConstructMeshNode(
			//       &v27,
			//       _nodeKey,
			//       _mesh,
			//       _transform,
			//       _prevTransform,
			//       _groundHeight,
			//       _ccd,
			//       0LL);
			//     v12 = &v27;
			//   }
			//   v15 = *(_OWORD *)&v12.localToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.NodeKey = *(_OWORD *)&v12.NodeKey;
			//   v16 = *(_OWORD *)&v12.localToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m20 = v15;
			//   v17 = *(_OWORD *)&v12.localToWorldMatrix.m22;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m21 = v16;
			//   v18 = *(_OWORD *)&v12.localToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m22 = v17;
			//   v19 = *(_OWORD *)&v12.prevLocalToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.localToWorldMatrix.m23 = v18;
			//   v20 = *(_OWORD *)&v12.prevLocalToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m20 = v19;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m21 = v20;
			//   v21 = *(_OWORD *)&v12.prevLocalToWorldMatrix.m22;
			//   p_m23 = (_OWORD *)&v12.prevLocalToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m22 = v21;
			//   v23 = p_m23[1];
			//   *(_OWORD *)&retstr.prevLocalToWorldMatrix.m23 = *p_m23;
			//   v24 = p_m23[2];
			//   *(_OWORD *)&retstr.length = v23;
			//   v25 = p_m23[3];
			//   result = retstr;
			//   *(_OWORD *)&retstr.texture = v24;
			//   *(_OWORD *)&retstr.heightScale = v25;
			//   return result;
			// }
			// 
			return null;
		}

		public void DrawNode(CommandBuffer cmd, Material material)
		{
			// // Void DrawNode(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionNode::DrawNode(
			//         HGInteractionNode *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   uint32_t ProxyType; // r8d
			//   uint32_t v8; // r8d
			//   uint32_t v9; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1530, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1530, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, this, (Object *)cmd, (Object *)material, 0LL);
			//   }
			//   else
			//   {
			//     ProxyType = this.ProxyType;
			//     if ( ProxyType )
			//     {
			//       v8 = ProxyType - 1;
			//       if ( v8 )
			//       {
			//         v9 = v8 - 1;
			//         if ( v9 )
			//         {
			//           if ( v9 == 1 )
			//             HG::Rendering::Runtime::HGInteractionNode::DrawMeshNode(this, cmd, material, 0LL);
			//         }
			//         else
			//         {
			//           HG::Rendering::Runtime::HGInteractionNode::DrawTextureNode(this, cmd, material, 0LL);
			//         }
			//       }
			//       else
			//       {
			//         HG::Rendering::Runtime::HGInteractionNode::DrawCapsuleNode(this, cmd, material, 0LL);
			//       }
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::HGInteractionNode::DrawSphereNode(this, cmd, material, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public bool BuildRenderData(out HGInteractionNodeRenderData renderData)
		{
			// // Boolean BuildRenderData(HGInteractionNodeRenderData ByRef)
			// bool HG::Rendering::Runtime::HGInteractionNode::BuildRenderData(
			//         HGInteractionNode *this,
			//         HGInteractionNodeRenderData *renderData,
			//         MethodInfo *method)
			// {
			//   HGInteractionNodeRenderData *v5; // rax
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   __int128 v8; // xmm0
			//   __int128 *p_prevLocalToWorld; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // [rsp+20h] [rbp-1E8h]
			//   __int128 v15; // [rsp+30h] [rbp-1D8h]
			//   __int128 v16; // [rsp+40h] [rbp-1C8h]
			//   __int128 v17; // [rsp+50h] [rbp-1B8h]
			//   __int128 v18; // [rsp+60h] [rbp-1A8h]
			//   __int128 v19; // [rsp+70h] [rbp-198h]
			//   __int128 v20; // [rsp+80h] [rbp-188h]
			//   __int128 v21; // [rsp+A0h] [rbp-168h]
			//   __int128 v22; // [rsp+B0h] [rbp-158h]
			//   __int128 v23; // [rsp+C0h] [rbp-148h]
			//   __int128 v24; // [rsp+D0h] [rbp-138h]
			//   __int128 v25; // [rsp+E0h] [rbp-128h]
			//   __int128 v26; // [rsp+F0h] [rbp-118h]
			//   __int128 v27; // [rsp+100h] [rbp-108h]
			//   HGInteractionNodeRenderData v28; // [rsp+110h] [rbp-F8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1531, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1531, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_586(Patch, this, renderData, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.ProxyType )
			//     {
			//       v5 = HG::Rendering::Runtime::HGInteractionNode::BuildSphereRenderData(&v28, this, 0LL);
			// LABEL_4:
			//       v14 = *(_OWORD *)&v5.instanceData.localToWorld.m00;
			//       v15 = *(_OWORD *)&v5.instanceData.localToWorld.m01;
			//       v16 = *(_OWORD *)&v5.instanceData.localToWorld.m02;
			//       v17 = *(_OWORD *)&v5.instanceData.localToWorld.m03;
			//       v18 = *(_OWORD *)&v5.instanceData.worldToLocal.m00;
			//       v19 = *(_OWORD *)&v5.instanceData.worldToLocal.m01;
			//       v20 = *(_OWORD *)&v5.instanceData.worldToLocal.m02;
			//       v8 = *(_OWORD *)&v5.instanceData.worldToLocal.m03;
			//       p_prevLocalToWorld = (__int128 *)&v5.instanceData.prevLocalToWorld;
			//       v21 = *p_prevLocalToWorld;
			//       v22 = p_prevLocalToWorld[1];
			//       v23 = p_prevLocalToWorld[2];
			//       v24 = p_prevLocalToWorld[3];
			//       v25 = p_prevLocalToWorld[4];
			//       v26 = p_prevLocalToWorld[5];
			//       v27 = p_prevLocalToWorld[6];
			//       *(_OWORD *)&renderData.instanceData.localToWorld.m00 = v14;
			//       *(_OWORD *)&renderData.instanceData.localToWorld.m01 = v15;
			//       *(_OWORD *)&renderData.instanceData.localToWorld.m02 = v16;
			//       *(_OWORD *)&renderData.instanceData.localToWorld.m03 = v17;
			//       *(_OWORD *)&renderData.instanceData.worldToLocal.m00 = v18;
			//       *(_OWORD *)&renderData.instanceData.worldToLocal.m01 = v19;
			//       *(_OWORD *)&renderData.instanceData.worldToLocal.m02 = v20;
			//       *(_OWORD *)&renderData.instanceData.worldToLocal.m03 = v8;
			//       *(_OWORD *)&renderData.instanceData.prevLocalToWorld.m00 = v21;
			//       *(_OWORD *)&renderData.instanceData.prevLocalToWorld.m01 = v22;
			//       *(_OWORD *)&renderData.instanceData.prevLocalToWorld.m02 = v23;
			//       *(_OWORD *)&renderData.instanceData.prevLocalToWorld.m03 = v24;
			//       *(_OWORD *)&renderData.instanceData.radius = v25;
			//       *(_OWORD *)&renderData.instanceData.groundHeight = v26;
			//       *(_OWORD *)&renderData.mesh = v27;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&renderData.mesh,
			//         (OneofDescriptorProto *)0x80,
			//         v6,
			//         v7,
			//         (String__Array *)v14,
			//         *((String **)&v14 + 1),
			//         (MethodInfo *)v15);
			//       return 1;
			//     }
			//     if ( this.ProxyType == 1 )
			//     {
			//       v5 = HG::Rendering::Runtime::HGInteractionNode::BuildCapsuleRenderData(&v28, this, 0LL);
			//       goto LABEL_4;
			//     }
			//     sub_1802F01E0(renderData, 0LL, 240LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private Bounds GetLocalBounds()
		{
			// // Bounds GetLocalBounds()
			// Bounds *HG::Rendering::Runtime::HGInteractionNode::GetLocalBounds(
			//         Bounds *__return_ptr retstr,
			//         HGInteractionNode *this,
			//         MethodInfo *method)
			// {
			//   Animator *v5; // rdx
			//   int32_t v6; // r8d
			//   MethodInfo *v7; // r9
			//   uint32_t ProxyType; // ecx
			//   uint32_t v9; // ecx
			//   HGInteractionResources__StaticFields *static_fields; // rcx
			//   Vector3 *v11; // rax
			//   __int64 v12; // xmm3_8
			//   Vector3 *v13; // rax
			//   Bounds *v14; // r8
			//   __int64 v15; // xmm1_8
			//   float v16; // ecx
			//   float v17; // edx
			//   Bounds *v18; // rdx
			//   Mesh *Capsule; // rdx
			//   Bounds *bounds; // rax
			//   Vector3 *Vector; // rax
			//   __int64 v22; // xmm3_8
			//   Vector3 *one; // rax
			//   float v24; // edx
			//   float z; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v28; // [rsp+20h] [rbp-30h] BYREF
			//   float v29; // [rsp+28h] [rbp-28h]
			//   Bounds v30; // [rsp+30h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919E14 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     byte_18D919E14 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1532, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1532, 0LL);
			//     if ( Patch )
			//     {
			//       bounds = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_587(&v30, Patch, this, 0LL);
			//       goto LABEL_19;
			//     }
			// LABEL_17:
			//     sub_180B536AC(static_fields, Capsule);
			//   }
			//   ProxyType = this.ProxyType;
			//   if ( !ProxyType )
			//     goto LABEL_13;
			//   v9 = ProxyType - 1;
			//   if ( !v9 )
			//   {
			//     if ( this.bUseCCD )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields;
			//       Capsule = static_fields.Capsule;
			// LABEL_11:
			//       if ( Capsule )
			//       {
			//         bounds = UnityEngine::Mesh::get_bounds(&v30, Capsule, 0LL);
			// LABEL_19:
			//         *(_OWORD *)&retstr.m_Center.x = *(_OWORD *)&bounds.m_Center.x;
			//         *(_QWORD *)&retstr.m_Extents.y = *(_QWORD *)&bounds.m_Extents.y;
			//         return retstr;
			//       }
			//       goto LABEL_17;
			//     }
			// LABEL_13:
			//     Vector = UnityEngine::Animator::GetVector(&v30.m_Center, v5, v6, v7);
			//     v22 = *(_QWORD *)&Vector.x;
			//     one = UnityEngine::Vector3::get_one(&v30.m_Center, (MethodInfo *)LODWORD(Vector.z));
			//     v29 = v24;
			//     v14 = &v30;
			//     v28 = v22;
			//     v18 = (Bounds *)&v28;
			//     z = one.z;
			//     *(_QWORD *)&v30.m_Center.x = *(_QWORD *)&one.x;
			//     v30.m_Center.z = z;
			//     goto LABEL_9;
			//   }
			//   static_fields = (HGInteractionResources__StaticFields *)(v9 - 1);
			//   if ( !(_DWORD)static_fields )
			//     goto LABEL_13;
			//   if ( (_DWORD)static_fields == 1 )
			//   {
			//     Capsule = this.mesh;
			//     goto LABEL_11;
			//   }
			//   v11 = UnityEngine::Animator::GetVector(&v30.m_Center, v5, v6, v7);
			//   v12 = *(_QWORD *)&v11.x;
			//   v13 = UnityEngine::Vector3::get_one(&v30.m_Center, (MethodInfo *)LODWORD(v11.z));
			//   v14 = (Bounds *)&v28;
			//   v15 = *(_QWORD *)&v13.x;
			//   v16 = v13.z;
			//   v30.m_Center.z = v17;
			//   v18 = &v30;
			//   v28 = v15;
			//   v29 = v16;
			//   *(_QWORD *)&v30.m_Center.x = v12;
			// LABEL_9:
			//   *(_OWORD *)&retstr.m_Center.x = 0LL;
			//   *(_QWORD *)&retstr.m_Extents.y = 0LL;
			//   UnityEngine::Bounds::Bounds(retstr, &v18.m_Center, &v14.m_Center, 0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		public Bounds GetBounds()
		{
			// // Bounds GetBounds()
			// Bounds *HG::Rendering::Runtime::HGInteractionNode::GetBounds(
			//         Bounds *__return_ptr retstr,
			//         HGInteractionNode *this,
			//         MethodInfo *method)
			// {
			//   Bounds *LocalBounds; // rax
			//   __int64 v6; // xmm1_8
			//   __int128 v7; // xmm0
			//   Bounds *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int128 v12; // xmm0
			//   __int64 v13; // xmm1_8
			//   Bounds *result; // rax
			//   Bounds v15; // [rsp+20h] [rbp-A8h] BYREF
			//   Bounds v16; // [rsp+38h] [rbp-90h] BYREF
			//   __int128 v17; // [rsp+50h] [rbp-78h]
			//   __int128 v18; // [rsp+60h] [rbp-68h]
			//   __int128 v19; // [rsp+70h] [rbp-58h]
			//   Matrix4x4 v20; // [rsp+80h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919E15 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919E15 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1533, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1533, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_587(&v16, Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     LocalBounds = HG::Rendering::Runtime::HGInteractionNode::GetLocalBounds(&v15, this, 0LL);
			//     v6 = *(_QWORD *)&LocalBounds.m_Extents.y;
			//     *(_OWORD *)&v16.m_Center.x = *(_OWORD *)&LocalBounds.m_Center.x;
			//     v7 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//     *(_QWORD *)&v16.m_Extents.y = v6;
			//     v17 = v7;
			//     v18 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//     v19 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//     *(_OWORD *)&v15.m_Center.x = *(_OWORD *)&this.localToWorldMatrix.m03;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     *(_OWORD *)&v20.m00 = v17;
			//     *(_OWORD *)&v20.m01 = v18;
			//     *(_OWORD *)&v20.m02 = v19;
			//     *(_OWORD *)&v20.m03 = *(_OWORD *)&v15.m_Center.x;
			//     v8 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v15, &v16, &v20, 0LL);
			//   }
			//   v12 = *(_OWORD *)&v8.m_Center.x;
			//   v13 = *(_QWORD *)&v8.m_Extents.y;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m_Center.x = v12;
			//   *(_QWORD *)&retstr.m_Extents.y = v13;
			//   return result;
			// }
			// 
			return null;
		}

		public HGInteractionNodeV2 BuildNativeNode()
		{
			// // HGInteractionNodeV2 BuildNativeNode()
			// HGInteractionNodeV2 *HG::Rendering::Runtime::HGInteractionNode::BuildNativeNode(
			//         HGInteractionNodeV2 *__return_ptr retstr,
			//         HGInteractionNode *this,
			//         MethodInfo *method)
			// {
			//   Object_1 *v5; // rcx
			//   __int64 v6; // rdx
			//   __int128 v7; // xmm1
			//   Texture *texture; // rsi
			//   bool v9; // zf
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   int32_t NodeKey; // eax
			//   __int128 v13; // xmm0
			//   uint32_t ProxyType; // eax
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   int32_t v19; // edi
			//   int32_t InstanceID; // eax
			//   float y; // xmm1_4
			//   Mesh *mesh; // rsi
			//   float heightScale; // xmm0_4
			//   HGInteractionNodeV2 *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   int32_t m_mesh; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGInteractionNodeV2 v37; // [rsp+20h] [rbp-69h] BYREF
			// 
			//   if ( !byte_18D8EDCD0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCD0 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *(_QWORD *)v5[7].fields.m_CachedPtr;
			//   if ( !v6 )
			//     goto LABEL_36;
			//   if ( *(int *)(v6 + 24) > 1534 )
			//   {
			//     if ( !LODWORD(v5[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(v5, v6);
			//       v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = *(Object_1 **)v5[7].fields.m_CachedPtr;
			//     if ( !v5 )
			//       goto LABEL_36;
			//     if ( LODWORD(v5[1].klass) <= 0x5FE )
			//       sub_180070270(v5, v6);
			//     if ( v5[512].fields.m_CachedPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1534, 0LL);
			//       if ( Patch )
			//       {
			//         v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_588(&v37, Patch, this, 0LL);
			//         goto LABEL_35;
			//       }
			//       goto LABEL_36;
			//     }
			//   }
			//   v7 = *(_OWORD *)&this.localToWorldMatrix.m01;
			//   texture = this.texture;
			//   *(_OWORD *)&v37.m_localToWorldMatrix.m00 = *(_OWORD *)&this.localToWorldMatrix.m00;
			//   v9 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//   v10 = *(_OWORD *)&this.localToWorldMatrix.m02;
			//   *(_WORD *)(&v37.m_bUseCCD + 1) = 0;
			//   *(_OWORD *)&v37.m_localToWorldMatrix.m01 = v7;
			//   *(&v37.m_bUseCCD + 3) = 0;
			//   v11 = *(_OWORD *)&this.localToWorldMatrix.m03;
			//   NodeKey = this.NodeKey;
			//   *(_OWORD *)&v37.m_localToWorldMatrix.m02 = v10;
			//   v37.m_nodeKey = NodeKey;
			//   v13 = *(_OWORD *)&this.prevLocalToWorldMatrix.m00;
			//   ProxyType = this.ProxyType;
			//   *(_OWORD *)&v37.m_localToWorldMatrix.m03 = v11;
			//   v37.m_proxyType = ProxyType;
			//   v15 = *(_OWORD *)&this.prevLocalToWorldMatrix.m01;
			//   LOBYTE(ProxyType) = this.bUseCCD;
			//   *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m00 = v13;
			//   v37.m_bUseCCD = ProxyType;
			//   v16 = *(_OWORD *)&this.prevLocalToWorldMatrix.m02;
			//   *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m01 = v15;
			//   v17 = *(_OWORD *)&this.prevLocalToWorldMatrix.m03;
			//   *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m02 = v16;
			//   v37.m_groundHeight = this.GroundHeight;
			//   v18 = *(_OWORD *)&this.length;
			//   *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m03 = v17;
			//   *(_OWORD *)&v37.m_length = v18;
			//   if ( v9 )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   v19 = 0;
			//   if ( !texture )
			//     goto LABEL_21;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( texture.fields._.m_CachedPtr )
			//   {
			//     v5 = (Object_1 *)this.texture;
			//     if ( !v5 )
			//       goto LABEL_36;
			//     InstanceID = UnityEngine::Object::GetInstanceID(v5, 0LL);
			//   }
			//   else
			//   {
			// LABEL_21:
			//     InstanceID = 0;
			//   }
			//   y = this.extent.y;
			//   mesh = this.mesh;
			//   v37.m_extent.x = this.extent.x;
			//   heightScale = this.heightScale;
			//   v37.m_extent.y = y;
			//   v37.m_heightScale = heightScale;
			//   v37.m_texture = InstanceID;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !mesh )
			//     goto LABEL_34;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !mesh.fields._.m_CachedPtr )
			//     goto LABEL_34;
			//   v5 = (Object_1 *)this.mesh;
			//   if ( !v5 )
			// LABEL_36:
			//     sub_180B536AC(v5, v6);
			//   v19 = UnityEngine::Object::GetInstanceID(v5, 0LL);
			// LABEL_34:
			//   v37.m_mesh = v19;
			//   v24 = &v37;
			// LABEL_35:
			//   v25 = *(_OWORD *)&v24.m_localToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.m_nodeKey = *(_OWORD *)&v24.m_nodeKey;
			//   v26 = *(_OWORD *)&v24.m_localToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.m_localToWorldMatrix.m20 = v25;
			//   v27 = *(_OWORD *)&v24.m_localToWorldMatrix.m22;
			//   *(_OWORD *)&retstr.m_localToWorldMatrix.m21 = v26;
			//   v28 = *(_OWORD *)&v24.m_localToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.m_localToWorldMatrix.m22 = v27;
			//   v29 = *(_OWORD *)&v24.m_prevLocalToWorldMatrix.m20;
			//   *(_OWORD *)&retstr.m_localToWorldMatrix.m23 = v28;
			//   v30 = *(_OWORD *)&v24.m_prevLocalToWorldMatrix.m21;
			//   *(_OWORD *)&retstr.m_prevLocalToWorldMatrix.m20 = v29;
			//   v31 = *(_OWORD *)&v24.m_prevLocalToWorldMatrix.m23;
			//   *(_OWORD *)&retstr.m_prevLocalToWorldMatrix.m21 = v30;
			//   *(_OWORD *)&retstr.m_prevLocalToWorldMatrix.m22 = *(_OWORD *)&v24.m_prevLocalToWorldMatrix.m22;
			//   v32 = *(_OWORD *)&v24.m_length;
			//   *(_OWORD *)&retstr.m_prevLocalToWorldMatrix.m23 = v31;
			//   v33 = *(_OWORD *)&v24.m_texture;
			//   m_mesh = v24.m_mesh;
			//   *(_OWORD *)&retstr.m_length = v32;
			//   *(_OWORD *)&retstr.m_texture = v33;
			//   retstr.m_mesh = m_mesh;
			//   return retstr;
			// }
			// 
			return null;
		}

		public const float MAX_DISTANCE = 32f;

		public const float CAST_OFFSET = 0.5f;

		public int NodeKey;

		public EInteractionProxyType ProxyType;

		public Matrix4x4 localToWorldMatrix;

		public Matrix4x4 prevLocalToWorldMatrix;

		public float GroundHeight;

		public bool bUseCCD;

		private float length;

		private float radius;

		private float interactLength;

		private float interactHeight;

		private Texture texture;

		private Vector2 extent;

		private float heightScale;

		private Mesh mesh;
	}
}
