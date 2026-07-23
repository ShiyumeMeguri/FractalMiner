using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGInteractionNode // TypeDefIndex: 37752
	{
		// Fields
		public const float MAX_DISTANCE = 32f; // Metadata: 0x0230308C
		public const float CAST_OFFSET = 0.5f; // Metadata: 0x02303090
		public int NodeKey; // 0x00
		public EInteractionProxyType ProxyType; // 0x04
		public Matrix4x4 localToWorldMatrix; // 0x08
		public Matrix4x4 prevLocalToWorldMatrix; // 0x48
		public float GroundHeight; // 0x88
		public bool bUseCCD; // 0x8C
		private float length; // 0x90
		private float radius; // 0x94
		private float interactLength; // 0x98
		private float interactHeight; // 0x9C
		private Texture texture; // 0xA0
		private Vector2 extent; // 0xA8
		private float heightScale; // 0xB0
		private Mesh mesh; // 0xB8
	
		// Methods
		private void ConstructNodeBase(int _nodeKey, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) {} // 0x00000001831055D0-0x00000001831056B0
		// Void ConstructNodeBase(Int32, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
		        HGInteractionNode *this,
		        int32_t _nodeKey,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __int128 v13; // xmm1
		  __int128 v14; // xmm2
		  __int128 v15; // xmm3
		  __int128 v16; // xmm1
		  __int128 v17; // xmm2
		  __int128 v18; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v9->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1801 )
		  {
		LABEL_5:
		    this->bUseCCD = _ccd;
		    this->NodeKey = _nodeKey;
		    v13 = *(_OWORD *)&_transform->m01;
		    v14 = *(_OWORD *)&_transform->m02;
		    v15 = *(_OWORD *)&_transform->m03;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&_transform->m00;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v13;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v14;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v15;
		    v16 = *(_OWORD *)&_prevTransform->m01;
		    v17 = *(_OWORD *)&_prevTransform->m02;
		    v18 = *(_OWORD *)&_prevTransform->m03;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m00 = *(_OWORD *)&_prevTransform->m00;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m01 = v16;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m02 = v17;
		    this->GroundHeight = _groundHeight;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m03 = v18;
		    return;
		  }
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9->static_fields->wrapperArray;
		  if ( !v9 )
		    goto LABEL_6;
		  if ( LODWORD(v9->_0.namespaze) <= 0x709 )
		    sub_1800D2AB0(v9, *(_QWORD *)&_nodeKey);
		  if ( !v9[38]._0.methods )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1801, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v9, *(_QWORD *)&_nodeKey);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_720(
		    Patch,
		    this,
		    _nodeKey,
		    _transform,
		    _prevTransform,
		    _groundHeight,
		    _ccd,
		    0LL);
		}
		
		private void ConstructSphereNode(int _nodeKey, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) {} // 0x0000000189CFF8D4-0x0000000189CFFD38
		// Void ConstructSphereNode(Int32, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGInteractionNode::ConstructSphereNode(
		        HGInteractionNode *this,
		        int32_t _nodeKey,
		        float _radius,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  MethodInfo *v11; // rdx
		  bool v12; // zf
		  __m128 v13; // xmm0
		  Vector3 *Position; // rax
		  Vector3 *v15; // rax
		  __int64 v16; // xmm0_8
		  Vector3 *v17; // rax
		  __int64 v18; // xmm0_8
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  __int64 v21; // xmm3_8
		  MethodInfo *v22; // rdx
		  float v23; // xmm11_4
		  __int32 v24; // xmm6_4
		  struct Mathf__Class *v25; // rsi
		  Vector3 *v26; // rax
		  __int64 v27; // rcx
		  Vector3 *fwd; // rax
		  __int64 v29; // xmm3_8
		  MethodInfo *v30; // r8
		  Vector4 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  MethodInfo *v34; // r8
		  float *p_Epsilon; // rax
		  __m128 z_low; // xmm8
		  double v37; // xmm0_8
		  Vector3 *v38; // rax
		  __int64 v39; // xmm6_8
		  float z; // ebx
		  Quaternion *v41; // rax
		  __m128 radius_low; // xmm0
		  float radius; // xmm2_4
		  float v44; // xmm2_4
		  Matrix4x4 *v45; // rax
		  __int128 v46; // xmm1
		  __int128 v47; // xmm2
		  __int128 v48; // xmm3
		  __int64 v49; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector3 v51; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v52; // [rsp+68h] [rbp-A0h] BYREF
		  Vector4 v53; // [rsp+78h] [rbp-90h] BYREF
		  Vector4 v54; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v55[2]; // [rsp+98h] [rbp-70h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1800, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1800, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v49);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_721(
		      Patch,
		      this,
		      _nodeKey,
		      _radius,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		  }
		  else
		  {
		    this->ProxyType = 0;
		    HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
		      this,
		      _nodeKey,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    v12 = !this->bUseCCD;
		    this->radius = _radius;
		    if ( v12 )
		    {
		      v13 = *(__m128 *)&_radius;
		      v13.m128_f32[0] = _radius + _radius;
		      *(_QWORD *)&v51.x = _mm_unpacklo_ps(v13, (__m128)0x3F800000u).m128_u64[0];
		      v51.z = _radius + _radius;
		      v53 = (Vector4)*UnityEngine::Quaternion::get_identity((Quaternion *)&v53, v11);
		      Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v54, _transform, 0LL);
		      v13.m128_u64[0] = *(_QWORD *)&Position->x;
		      *(float *)&Position = Position->z;
		      *(_QWORD *)&v52.x = v13.m128_u64[0];
		      LODWORD(v52.z) = (_DWORD)Position;
		    }
		    else
		    {
		      v15 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v54, _prevTransform, 0LL);
		      v16 = *(_QWORD *)&v15->x;
		      *(float *)&v15 = v15->z;
		      *(_QWORD *)&v51.x = v16;
		      LODWORD(v51.z) = (_DWORD)v15;
		      v17 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v54, _transform, 0LL);
		      v18 = *(_QWORD *)&v17->x;
		      *(float *)&v17 = v17->z;
		      *(_QWORD *)&v52.x = v18;
		      LODWORD(v52.z) = (_DWORD)v17;
		      v20 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v54, &v52, &v51, v19);
		      v21 = *(_QWORD *)&v20->x;
		      *(float *)&v20 = v20->z;
		      *(_QWORD *)&v51.x = v21;
		      LODWORD(v51.z) = (_DWORD)v20;
		      v23 = sub_182F9FF00(&v51);
		      this->radius = _radius;
		      COERCE_FLOAT(v24 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		      v25 = TypeInfo::UnityEngine::Mathf;
		      if ( fmaxf(
		             fmaxf(COERCE_FLOAT(LODWORD(v23) & v24), 0.0) * 0.000001,
		             TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v23) & v24) )
		      {
		        fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v54, v22);
		        v29 = *(_QWORD *)&fwd->x;
		        *(float *)&fwd = fwd->z;
		        *(_QWORD *)&v51.x = v29;
		        LODWORD(v51.z) = (_DWORD)fwd;
		        v31 = *UnityEngine::Vector4::op_Implicit(&v53, &v51, v30);
		        *(_OWORD *)&v55[0].m00 = *(_OWORD *)&_transform->m00;
		        v32 = *(_OWORD *)&_transform->m02;
		        v53 = v31;
		        v33 = *(_OWORD *)&_transform->m01;
		        *(_OWORD *)&v55[0].m02 = v32;
		        *(_OWORD *)&v55[0].m01 = v33;
		        *(_OWORD *)&v55[0].m03 = *(_OWORD *)&_transform->m03;
		        v53 = *UnityEngine::Matrix4x4::op_Multiply(&v54, v55, &v53, 0LL);
		        v26 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v54, &v53, v34);
		      }
		      else
		      {
		        v26 = (Vector3 *)sub_182FAE2B0(&v54, &v51);
		        v25 = TypeInfo::UnityEngine::Mathf;
		      }
		      v51 = *v26;
		      p_Epsilon = &v25->static_fields->Epsilon;
		      z_low = (__m128)LODWORD(v51.z);
		      if ( fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v51.x) & v24), 0.0) * 0.000001, *p_Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v51.x) & v24)
		        || fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v51.z) & v24), 0.0) * 0.000001, *p_Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v51.z) & v24) )
		      {
		        sub_1803345E0(v27);
		      }
		      *(_QWORD *)&v52.x = _mm_unpacklo_ps((__m128)LODWORD(v51.x), z_low).m128_u64[0];
		      v37 = sub_182FA2AF0(&v52);
		      this->interactHeight = v51.y * v23;
		      this->interactLength = *(float *)&v37 * v23;
		      v38 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v54, _transform, 0LL);
		      v39 = *(_QWORD *)&v38->x;
		      z = v38->z;
		      v41 = (Quaternion *)sub_182FA5990(&v53);
		      radius_low = (__m128)LODWORD(this->radius);
		      radius = this->radius;
		      radius_low.m128_f32[0] = radius_low.m128_f32[0] + radius_low.m128_f32[0];
		      *(_QWORD *)&v52.x = v39;
		      v52.z = z;
		      v44 = (float)(radius + radius) + this->interactLength;
		      *(_QWORD *)&v51.x = _mm_unpacklo_ps(radius_low, (__m128)0x3F800000u).m128_u64[0];
		      v53 = (Vector4)*v41;
		      v51.z = v44;
		    }
		    v45 = UnityEngine::Matrix4x4::TRS(v55, &v52, (Quaternion *)&v53, &v51, 0LL);
		    v46 = *(_OWORD *)&v45->m01;
		    v47 = *(_OWORD *)&v45->m02;
		    v48 = *(_OWORD *)&v45->m03;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&v45->m00;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v46;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v47;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v48;
		  }
		}
		
		private void DrawSphereNode(CommandBuffer cmd, Material material) {} // 0x0000000189D00D94-0x0000000189D0100C
		// Void DrawSphereNode(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionNode::DrawSphereNode(
		        HGInteractionNode *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Shader *shader; // rbx
		  String *s_InteractionUseCCD; // r8
		  Mesh *QuadMesh; // rax
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t v18; // [rsp+30h] [rbp-31h]
		  LocalKeyword v19; // [rsp+48h] [rbp-19h] BYREF
		  LocalKeyword keyword; // [rsp+60h] [rbp-1h] BYREF
		  Matrix4x4 v21; // [rsp+78h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1811, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1811, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_731(Patch, this, (Object *)cmd, (Object *)material, 0LL);
		  }
		  else
		  {
		    if ( !material
		      || (shader = UnityEngine::Material::get_shader(material, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
		          s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD,
		          memset(&v19, 0, sizeof(v19)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, s_InteractionUseCCD, 0LL),
		          keyword = v19,
		          !cmd) )
		    {
		      sub_1800D8260(v8, v7);
		    }
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, material, &keyword, 0, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundHeight,
		      this->GroundHeight,
		      0LL);
		    if ( this->bUseCCD )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractRadius,
		        this->radius,
		        0LL);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractLength,
		        this->interactLength,
		        0LL);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractHeight,
		        this->interactHeight,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		      v18 = 1;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractRadius,
		        this->radius,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		      v18 = 0;
		    }
		    v12 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    *(_OWORD *)&v21.m01 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    v13 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v21.m00 = v12;
		    v14 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v21.m03 = v13;
		    *(_OWORD *)&v21.m02 = v14;
		    UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, QuadMesh, &v21, material, 0, v18, 0LL);
		  }
		}
		
		private HGInteractionNodeRenderData BuildSphereRenderData() => default; // 0x0000000189CFF4D0-0x0000000189CFF7E4
		// HGInteractionNodeRenderData BuildSphereRenderData()
		HGInteractionNodeRenderData *HG::Rendering::Runtime::HGInteractionNode::BuildSphereRenderData(
		        HGInteractionNodeRenderData *__return_ptr retstr,
		        HGInteractionNode *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  Matrix4x4 *inverse; // rax
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  HGInteractionNodeRenderData *v35; // rax
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm0
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  HGInteractionNodeRenderData v50; // [rsp+28h] [rbp-E0h] BYREF
		  __int128 v51; // [rsp+118h] [rbp+10h]
		  __int128 v52; // [rsp+128h] [rbp+20h]
		  __int128 v53; // [rsp+138h] [rbp+30h]
		  __int128 v54; // [rsp+148h] [rbp+40h]
		  Matrix4x4 worldToLocal; // [rsp+158h] [rbp+50h]
		  Matrix4x4 prevLocalToWorld; // [rsp+198h] [rbp+90h]
		  __int128 v57; // [rsp+1D8h] [rbp+D0h]
		  __int128 v58; // [rsp+1E8h] [rbp+E0h]
		  SingleFieldAccessor v59; // [rsp+1F8h] [rbp+F0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1812, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1812, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v34, v33);
		    v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_732(&v50, Patch, this, 0LL);
		    v36 = *(_OWORD *)&v35->instanceData.localToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m00 = *(_OWORD *)&v35->instanceData.localToWorld.m00;
		    v37 = *(_OWORD *)&v35->instanceData.localToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m01 = v36;
		    v38 = *(_OWORD *)&v35->instanceData.localToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m02 = v37;
		    v39 = *(_OWORD *)&v35->instanceData.worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m03 = v38;
		    v40 = *(_OWORD *)&v35->instanceData.worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m00 = v39;
		    v41 = *(_OWORD *)&v35->instanceData.worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m01 = v40;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m02 = v41;
		    v42 = *(_OWORD *)&v35->instanceData.worldToLocal.m03;
		    v35 = (HGInteractionNodeRenderData *)((char *)v35 + 128);
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m03 = v42;
		    v43 = *(_OWORD *)&v35->instanceData.localToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m00 = *(_OWORD *)&v35->instanceData.localToWorld.m00;
		    v44 = *(_OWORD *)&v35->instanceData.localToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m01 = v43;
		    v45 = *(_OWORD *)&v35->instanceData.localToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m02 = v44;
		    v46 = *(_OWORD *)&v35->instanceData.worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m03 = v45;
		    v47 = *(_OWORD *)&v35->instanceData.worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.radius = v46;
		    v48 = *(_OWORD *)&v35->instanceData.worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.groundHeight = v47;
		    *(_OWORD *)&retstr->mesh = v48;
		  }
		  else
		  {
		    v59.monitor = 0LL;
		    sub_18033B9D0(&v50, 0LL, 224LL);
		    v5 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    *(_OWORD *)&v50.instanceData.localToWorld.m00 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    v6 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v50.instanceData.localToWorld.m01 = v5;
		    v7 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v50.instanceData.localToWorld.m02 = v6;
		    *(_OWORD *)&v50.instanceData.localToWorld.m03 = v7;
		    inverse = UnityEngine::Matrix4x4::get_inverse((Matrix4x4 *)&v59.fields, &this->localToWorldMatrix, 0LL);
		    v50.instanceData.capsuleLocalHeight = 0.0;
		    v50.instanceData.heightScale = 1.0;
		    v9 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&v50.instanceData.worldToLocal.m00 = *(_OWORD *)&inverse->m00;
		    v10 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&v50.instanceData.worldToLocal.m01 = v9;
		    v11 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&v50.instanceData.worldToLocal.m02 = v10;
		    v12 = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		    *(_OWORD *)&v50.instanceData.worldToLocal.m03 = v11;
		    v13 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		    *(_OWORD *)&v50.instanceData.prevLocalToWorld.m00 = v12;
		    v14 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		    *(_OWORD *)&v50.instanceData.prevLocalToWorld.m01 = v13;
		    v15 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		    *(_OWORD *)&v50.instanceData.prevLocalToWorld.m02 = v14;
		    *(float *)&v14 = this->radius;
		    *(_OWORD *)&v50.instanceData.prevLocalToWorld.m03 = v15;
		    *(float *)&v15 = this->interactLength;
		    LODWORD(v50.instanceData.radius) = v14;
		    *(float *)&v14 = this->interactHeight;
		    LODWORD(v50.instanceData.length) = v15;
		    *(float *)&v15 = this->GroundHeight;
		    LODWORD(v50.instanceData.height) = v14;
		    LODWORD(v50.instanceData.groundHeight) = v15;
		    v51 = *(_OWORD *)&v50.instanceData.localToWorld.m00;
		    v52 = *(_OWORD *)&v50.instanceData.localToWorld.m01;
		    v53 = *(_OWORD *)&v50.instanceData.localToWorld.m02;
		    v54 = *(_OWORD *)&v50.instanceData.localToWorld.m03;
		    worldToLocal = v50.instanceData.worldToLocal;
		    prevLocalToWorld = v50.instanceData.prevLocalToWorld;
		    v57 = *(_OWORD *)&v50.instanceData.radius;
		    v58 = *(_OWORD *)&v50.instanceData.groundHeight;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		    v59.klass = (SingleFieldAccessor__Class *)HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		    sub_18002D1B0(&v59, v16, v17, v18, *(MethodInfo **)&v50.instanceData.localToWorld.m00);
		    BYTE4(v59.monitor) = 0;
		    LODWORD(v59.monitor) = this->bUseCCD;
		    v19 = v52;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m00 = v51;
		    v20 = v53;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m01 = v19;
		    v21 = v54;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m02 = v20;
		    v22 = *(_OWORD *)&worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m03 = v21;
		    v23 = *(_OWORD *)&worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m00 = v22;
		    v24 = *(_OWORD *)&worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m01 = v23;
		    v25 = *(_OWORD *)&worldToLocal.m03;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m02 = v24;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m03 = v25;
		    v26 = *(_OWORD *)&prevLocalToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m00 = *(_OWORD *)&prevLocalToWorld.m00;
		    v27 = *(_OWORD *)&prevLocalToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m01 = v26;
		    v28 = *(_OWORD *)&prevLocalToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m02 = v27;
		    v29 = v57;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m03 = v28;
		    v30 = v58;
		    *(_OWORD *)&retstr->instanceData.radius = v29;
		    v31 = *(_OWORD *)&v59.klass;
		    *(_OWORD *)&retstr->instanceData.groundHeight = v30;
		    *(_OWORD *)&retstr->mesh = v31;
		  }
		  return retstr;
		}
		
		private void ConstructCapsuleNode(int _nodeKey, float _length, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) {} // 0x0000000182FADC90-0x0000000182FAE500
		// Void ConstructCapsuleNode(Int32, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		void HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
		        HGInteractionNode *this,
		        int32_t _nodeKey,
		        float _length,
		        float _radius,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  MethodInfo *v9; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Matrix4x4 *v16; // rdi
		  Matrix4x4 *v17; // rsi
		  __int128 v18; // xmm1
		  __int128 v19; // xmm2
		  __int128 v20; // xmm3
		  __int128 v21; // xmm1
		  __int128 v22; // xmm2
		  __int128 v23; // xmm3
		  bool v24; // zf
		  Vector4 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int64 v28; // rdx
		  __int64 v29; // r8
		  MethodInfo *v30; // r9
		  Vector4 v31; // xmm7
		  __int32 v32; // xmm3_4
		  Mathf__StaticFields *static_fields; // rax
		  float v34; // xmm6_4
		  __m128 v35; // xmm0
		  __m128 v36; // xmm8
		  struct Math__Class *v37; // rcx
		  __m128d v38; // xmm1
		  double v39; // xmm0_8
		  float v40; // xmm0_4
		  __m128 m03_low; // xmm6
		  __m128 m13_low; // xmm7
		  float m23; // xmm9_4
		  Vector3 *v44; // rax
		  __int64 v45; // xmm3_8
		  void (__fastcall *v46)(Vector3 *, Vector4 *); // rax
		  __m128 radius_low; // xmm0
		  float radius; // xmm1_4
		  void (__fastcall *v49)(Vector3 *, Vector4 *, unsigned __int64 *, Matrix4x4 *); // rax
		  float v50; // xmm1_4
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  float v54; // xmm9_4
		  __m128 v55; // xmm6
		  __m128 v56; // xmm7
		  float v57; // xmm8_4
		  Quaternion *rotation; // rax
		  __m128 z_low; // xmm2
		  Vector4 v60; // xmm0
		  void (__fastcall *v61)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *); // rax
		  __int128 v62; // xmm1
		  __int128 v63; // xmm0
		  __int128 v64; // xmm1
		  __m128 v65; // xmm6
		  __m128 v66; // xmm7
		  float v67; // xmm8_4
		  Quaternion *v68; // rax
		  __m128 v69; // xmm2
		  Vector4 v70; // xmm0
		  void (__fastcall *v71)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *); // rax
		  __int128 v72; // xmm1
		  __int128 v73; // xmm0
		  __int128 v74; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v76; // rax
		  __int64 v77; // rax
		  __int64 v78; // rax
		  __int64 v79; // rax
		  __int64 v80; // rax
		  Vector3 v81; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v82; // [rsp+68h] [rbp-A0h] BYREF
		  unsigned __int64 v83; // [rsp+78h] [rbp-90h] BYREF
		  float v84; // [rsp+80h] [rbp-88h]
		  Vector4 v85; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v86; // [rsp+98h] [rbp-70h] BYREF
		  Vector4 v87; // [rsp+D8h] [rbp-30h] BYREF
		
		  v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v11->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_25;
		  if ( wrapperArray->max_length.size > 1803 )
		  {
		    if ( !v11->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v11);
		      v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v11->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_25;
		    if ( wrapperArray->max_length.size <= 0x70Bu )
		      goto LABEL_45;
		    if ( wrapperArray[50].vector[3] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1803, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_723(
		          Patch,
		          this,
		          _nodeKey,
		          _length,
		          _radius,
		          _transform,
		          _prevTransform,
		          _groundHeight,
		          _ccd,
		          0LL);
		        return;
		      }
		      goto LABEL_25;
		    }
		  }
		  this->ProxyType = 1;
		  v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v11->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_25;
		  if ( wrapperArray->max_length.size <= 1801 )
		  {
		LABEL_9:
		    v16 = _transform;
		    v17 = _prevTransform;
		    this->NodeKey = _nodeKey;
		    this->bUseCCD = _ccd;
		    v18 = *(_OWORD *)&_transform->m01;
		    v19 = *(_OWORD *)&_transform->m02;
		    v20 = *(_OWORD *)&_transform->m03;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&_transform->m00;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v18;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v19;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v20;
		    v21 = *(_OWORD *)&_prevTransform->m01;
		    v22 = *(_OWORD *)&_prevTransform->m02;
		    v23 = *(_OWORD *)&_prevTransform->m03;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m00 = *(_OWORD *)&_prevTransform->m00;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m01 = v21;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m02 = v22;
		    this->GroundHeight = _groundHeight;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m03 = v23;
		    goto LABEL_10;
		  }
		  if ( !v11->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v11);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11->static_fields->wrapperArray;
		  if ( !v11 )
		LABEL_25:
		    sub_1800D8260(v11, wrapperArray);
		  if ( LODWORD(v11->_0.namespaze) <= 0x709 )
		LABEL_45:
		    sub_1800D2AB0(v11, wrapperArray);
		  if ( !v11[38]._0.methods )
		    goto LABEL_9;
		  v76 = IFix::WrappersManagerImpl::GetPatch(1801, 0LL);
		  if ( !v76 )
		    goto LABEL_25;
		  v16 = _transform;
		  v17 = _prevTransform;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_720(
		    v76,
		    this,
		    _nodeKey,
		    _transform,
		    _prevTransform,
		    _groundHeight,
		    _ccd,
		    0LL);
		LABEL_10:
		  v24 = !this->bUseCCD;
		  this->length = _length;
		  this->radius = _radius;
		  if ( v24 )
		  {
		    v82.z = 0.0;
		    *(_QWORD *)&v82.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v25 = *UnityEngine::Vector4::op_Implicit(&v85, &v82, v9);
		    *(_OWORD *)&v86.m00 = *(_OWORD *)&v16->m00;
		    v26 = *(_OWORD *)&v16->m02;
		    v87 = v25;
		    v27 = *(_OWORD *)&v16->m01;
		    *(_OWORD *)&v86.m02 = v26;
		    *(_OWORD *)&v86.m01 = v27;
		    *(_OWORD *)&v86.m03 = *(_OWORD *)&v16->m03;
		    v31 = *UnityEngine::Matrix4x4::op_Multiply(&v85, &v86, &v87, 0LL);
		    COERCE_FLOAT(v32 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		    static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
		    LODWORD(v34) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 170).m128_u32[0];
		    if ( fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v31.x) & v32), 0.0) * 0.000001, static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v31.x) & v32)
		      || fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v34) & v32), 0.0) * 0.000001, static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v34) & v32) )
		    {
		      v35.m128_u64[1] = *(_QWORD *)&v31.z;
		      *(double *)v35.m128_u64 = sub_1803345E0(TypeInfo::UnityEngine::Mathf);
		      v36 = v35;
		      v36.m128_f32[0] = v35.m128_f32[0] * 57.29578;
		    }
		    else
		    {
		      v36 = 0LL;
		    }
		    v37 = TypeInfo::System::Math;
		    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		    v38 = 0LL;
		    v38.m128d_f64[0] = (float)((float)(v34 * v34) + (float)(v31.x * v31.x));
		    if ( v38.m128d_f64[0] < 0.0 )
		      v39 = sub_1801D32D0(v37, v28, v29);
		    else
		      *(_QWORD *)&v39 = *(_OWORD *)&_mm_sqrt_pd(v38);
		    v40 = v39;
		    this->interactHeight = _mm_shuffle_ps((__m128)v31, (__m128)v31, 85).m128_f32[0] * this->length;
		    this->interactLength = v40 * _length;
		    m03_low = (__m128)LODWORD(v16->m03);
		    m13_low = (__m128)LODWORD(v16->m13);
		    m23 = v16->m23;
		    v82.z = 0.0;
		    *(_QWORD *)&v82.x = _mm_unpacklo_ps((__m128)0LL, v36).m128_u64[0];
		    v44 = UnityEngine::Vector3::op_Multiply(&v81, &v82, 0.017453292, v30);
		    v87 = 0LL;
		    v45 = *(_QWORD *)&v44->x;
		    v82.z = v44->z;
		    v46 = (void (__fastcall *)(Vector3 *, Vector4 *))qword_18F36FAC8;
		    *(_QWORD *)&v82.x = v45;
		    if ( !qword_18F36FAC8 )
		    {
		      v46 = (void (__fastcall *)(Vector3 *, Vector4 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEng"
		                                                         "ine.Vector3&,UnityEngine.Quaternion&)");
		      if ( !v46 )
		      {
		        v77 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		        sub_18007E1B0(v77, 0LL);
		      }
		      qword_18F36FAC8 = (__int64)v46;
		    }
		    v46(&v82, &v87);
		    radius_low = (__m128)LODWORD(this->radius);
		    radius = this->radius;
		    radius_low.m128_f32[0] = radius_low.m128_f32[0] + radius_low.m128_f32[0];
		    v49 = (void (__fastcall *)(Vector3 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))qword_18F36FA58;
		    v81.z = m23;
		    *(_QWORD *)&v81.x = _mm_unpacklo_ps(m03_low, m13_low).m128_u64[0];
		    v83 = _mm_unpacklo_ps(radius_low, (__m128)0x3F800000u).m128_u64[0];
		    v50 = (float)(radius + radius) + this->interactLength;
		    v85 = v87;
		    memset(&v86, 0, sizeof(v86));
		    v84 = v50;
		    if ( !qword_18F36FA58 )
		    {
		      v49 = (void (__fastcall *)(Vector3 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                          "UnityEngine.Matrix4x4::TRS_Inj"
		                                                                                          "ected(UnityEngine.Vector3&,Uni"
		                                                                                          "tyEngine.Quaternion&,UnityEngi"
		                                                                                          "ne.Vector3&,UnityEngine.Matrix4x4&)");
		      if ( !v49 )
		      {
		        v78 = sub_1802EE1B8(
		                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
		                "ityEngine.Matrix4x4&)");
		        sub_18007E1B0(v78, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v49;
		    }
		    v49(&v81, &v85, &v83, &v86);
		    v51 = *(_OWORD *)&v86.m01;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&v86.m00;
		    v52 = *(_OWORD *)&v86.m02;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v51;
		    v53 = *(_OWORD *)&v86.m03;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v52;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v53;
		  }
		  else
		  {
		    if ( _radius <= 0.0099999998 )
		      v54 = 4.0;
		    else
		      v54 = (float)(_length / _radius) + 2.0;
		    v55 = (__m128)LODWORD(v16->m03);
		    v56 = (__m128)LODWORD(v16->m13);
		    v57 = v16->m23;
		    rotation = UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v87, v16, 0LL);
		    v81.z = this->radius;
		    z_low = (__m128)LODWORD(v81.z);
		    v84 = v57;
		    v83 = _mm_unpacklo_ps(v55, v56).m128_u64[0];
		    z_low.m128_f32[0] = (float)((float)(z_low.m128_f32[0] + z_low.m128_f32[0]) + this->length) / v54;
		    *(_QWORD *)&v81.x = _mm_unpacklo_ps((__m128)LODWORD(v81.z), z_low).m128_u64[0];
		    v60 = (Vector4)*rotation;
		    v61 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *))qword_18F36FA58;
		    v85 = v60;
		    memset(&v86, 0, sizeof(v86));
		    if ( !qword_18F36FA58 )
		    {
		      v61 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                          "UnityEngine.Matrix4x4::TRS_Inj"
		                                                                                          "ected(UnityEngine.Vector3&,Uni"
		                                                                                          "tyEngine.Quaternion&,UnityEngi"
		                                                                                          "ne.Vector3&,UnityEngine.Matrix4x4&)");
		      if ( !v61 )
		      {
		        v79 = sub_1802EE1B8(
		                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
		                "ityEngine.Matrix4x4&)");
		        sub_18007E1B0(v79, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v61;
		    }
		    v61(&v83, &v85, &v81, &v86);
		    v62 = *(_OWORD *)&v86.m01;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&v86.m00;
		    v63 = *(_OWORD *)&v86.m02;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v62;
		    v64 = *(_OWORD *)&v86.m03;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v63;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v64;
		    v65 = (__m128)LODWORD(v17->m03);
		    v66 = (__m128)LODWORD(v17->m13);
		    v67 = v17->m23;
		    v68 = UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v87, v17, 0LL);
		    v81.z = this->radius;
		    v69 = (__m128)LODWORD(v81.z);
		    v84 = v67;
		    v83 = _mm_unpacklo_ps(v65, v66).m128_u64[0];
		    v69.m128_f32[0] = (float)((float)(v69.m128_f32[0] + v69.m128_f32[0]) + this->length) / v54;
		    *(_QWORD *)&v81.x = _mm_unpacklo_ps((__m128)LODWORD(v81.z), v69).m128_u64[0];
		    v70 = (Vector4)*v68;
		    v71 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *))qword_18F36FA58;
		    v85 = v70;
		    memset(&v86, 0, sizeof(v86));
		    if ( !qword_18F36FA58 )
		    {
		      v71 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, Vector3 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                          "UnityEngine.Matrix4x4::TRS_Inj"
		                                                                                          "ected(UnityEngine.Vector3&,Uni"
		                                                                                          "tyEngine.Quaternion&,UnityEngi"
		                                                                                          "ne.Vector3&,UnityEngine.Matrix4x4&)");
		      if ( !v71 )
		      {
		        v80 = sub_1802EE1B8(
		                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
		                "ityEngine.Matrix4x4&)");
		        sub_18007E1B0(v80, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v71;
		    }
		    v71(&v83, &v85, &v81, &v86);
		    v72 = *(_OWORD *)&v86.m01;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m00 = *(_OWORD *)&v86.m00;
		    v73 = *(_OWORD *)&v86.m02;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m01 = v72;
		    v74 = *(_OWORD *)&v86.m03;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m02 = v73;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m03 = v74;
		  }
		}
		
		private void DrawCapsuleNode(CommandBuffer cmd, Material material) {} // 0x0000000189D00748-0x0000000189D00A8C
		// Void DrawCapsuleNode(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionNode::DrawCapsuleNode(
		        HGInteractionNode *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Shader *shader; // rbx
		  String *s_InteractionUseCCD; // r8
		  int32_t InteractWorldToLocal; // ebx
		  Matrix4x4 *inverse; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm1
		  int32_t PrevInteractLocalToWorld; // edx
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  Mesh *Capsule; // rdx
		  float radius; // xmm0_4
		  float v22; // xmm2_4
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  int32_t v29; // [rsp+30h] [rbp-71h]
		  Matrix4x4 v30; // [rsp+48h] [rbp-59h] BYREF
		  LocalKeyword v31; // [rsp+88h] [rbp-19h] BYREF
		  LocalKeyword keyword; // [rsp+A0h] [rbp-1h] BYREF
		  Matrix4x4 value; // [rsp+B8h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1813, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1813, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v28, v27);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_731(Patch, this, (Object *)cmd, (Object *)material, 0LL);
		  }
		  else
		  {
		    if ( !material
		      || (shader = UnityEngine::Material::get_shader(material, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
		          s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD,
		          memset(&v31, 0, sizeof(v31)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v31, shader, s_InteractionUseCCD, 0LL),
		          keyword = v31,
		          !cmd) )
		    {
		      sub_1800D8260(v8, v7);
		    }
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, material, &keyword, this->bUseCCD, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundHeight,
		      this->GroundHeight,
		      0LL);
		    InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractWorldToLocal;
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v30, &this->localToWorldMatrix, 0LL);
		    v13 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&value.m00 = *(_OWORD *)&inverse->m00;
		    v14 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&value.m01 = v13;
		    v15 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&value.m02 = v14;
		    *(_OWORD *)&value.m03 = v15;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
		    v16 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		    PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevInteractLocalToWorld;
		    *(_OWORD *)&v30.m00 = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		    v18 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		    *(_OWORD *)&v30.m01 = v16;
		    v19 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		    *(_OWORD *)&v30.m02 = v18;
		    *(_OWORD *)&v30.m03 = v19;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, PrevInteractLocalToWorld, &v30, 0LL);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractRadius,
		      this->radius,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractLength,
		      this->interactLength,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractHeight,
		      this->interactHeight,
		      0LL);
		    if ( this->bUseCCD )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      radius = this->radius;
		      if ( radius <= 0.0099999998 )
		        v22 = 1.0;
		      else
		        v22 = (float)(this->length * 0.5) / radius;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleLocalHeight,
		        v22,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      v29 = 4;
		      Capsule = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->Capsule;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      Capsule = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		      v29 = 1;
		    }
		    v23 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    *(_OWORD *)&v30.m01 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    v24 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v30.m00 = v23;
		    v25 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v30.m03 = v24;
		    *(_OWORD *)&v30.m02 = v25;
		    UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, Capsule, &v30, material, 0, v29, 0LL);
		  }
		}
		
		private HGInteractionNodeRenderData BuildCapsuleRenderData() => default; // 0x0000000189CFEFA0-0x0000000189CFF30C
		// HGInteractionNodeRenderData BuildCapsuleRenderData()
		HGInteractionNodeRenderData *HG::Rendering::Runtime::HGInteractionNode::BuildCapsuleRenderData(
		        HGInteractionNodeRenderData *__return_ptr retstr,
		        HGInteractionNode *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  Matrix4x4 *inverse; // rax
		  float v9; // xmm2_4
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  float radius; // xmm1_4
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Mesh *Capsule; // rax
		  bool bUseCCD; // cf
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  HGInteractionNodeRenderData *v39; // rax
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm0
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  HGInteractionNodeRenderData v54; // [rsp+28h] [rbp-E0h] BYREF
		  __int128 v55; // [rsp+118h] [rbp+10h]
		  __int128 v56; // [rsp+128h] [rbp+20h]
		  __int128 v57; // [rsp+138h] [rbp+30h]
		  __int128 v58; // [rsp+148h] [rbp+40h]
		  Matrix4x4 worldToLocal; // [rsp+158h] [rbp+50h]
		  Matrix4x4 prevLocalToWorld; // [rsp+198h] [rbp+90h]
		  __int128 v61; // [rsp+1D8h] [rbp+D0h]
		  __int128 v62; // [rsp+1E8h] [rbp+E0h]
		  SingleFieldAccessor v63; // [rsp+1F8h] [rbp+F0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1814, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1814, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v38, v37);
		    v39 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_732(&v54, Patch, this, 0LL);
		    v40 = *(_OWORD *)&v39->instanceData.localToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m00 = *(_OWORD *)&v39->instanceData.localToWorld.m00;
		    v41 = *(_OWORD *)&v39->instanceData.localToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m01 = v40;
		    v42 = *(_OWORD *)&v39->instanceData.localToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m02 = v41;
		    v43 = *(_OWORD *)&v39->instanceData.worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m03 = v42;
		    v44 = *(_OWORD *)&v39->instanceData.worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m00 = v43;
		    v45 = *(_OWORD *)&v39->instanceData.worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m01 = v44;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m02 = v45;
		    v46 = *(_OWORD *)&v39->instanceData.worldToLocal.m03;
		    v39 = (HGInteractionNodeRenderData *)((char *)v39 + 128);
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m03 = v46;
		    v47 = *(_OWORD *)&v39->instanceData.localToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m00 = *(_OWORD *)&v39->instanceData.localToWorld.m00;
		    v48 = *(_OWORD *)&v39->instanceData.localToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m01 = v47;
		    v49 = *(_OWORD *)&v39->instanceData.localToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m02 = v48;
		    v50 = *(_OWORD *)&v39->instanceData.worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m03 = v49;
		    v51 = *(_OWORD *)&v39->instanceData.worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.radius = v50;
		    v52 = *(_OWORD *)&v39->instanceData.worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.groundHeight = v51;
		    *(_OWORD *)&retstr->mesh = v52;
		  }
		  else
		  {
		    v63.monitor = 0LL;
		    sub_18033B9D0(&v54, 0LL, 224LL);
		    v5 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    *(_OWORD *)&v54.instanceData.localToWorld.m00 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    v6 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v54.instanceData.localToWorld.m01 = v5;
		    v7 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v54.instanceData.localToWorld.m02 = v6;
		    *(_OWORD *)&v54.instanceData.localToWorld.m03 = v7;
		    inverse = UnityEngine::Matrix4x4::get_inverse((Matrix4x4 *)&v63.fields, &this->localToWorldMatrix, 0LL);
		    v9 = 1.0;
		    v54.instanceData.heightScale = 1.0;
		    v10 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&v54.instanceData.worldToLocal.m00 = *(_OWORD *)&inverse->m00;
		    v11 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&v54.instanceData.worldToLocal.m01 = v10;
		    v12 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&v54.instanceData.worldToLocal.m02 = v11;
		    v13 = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		    *(_OWORD *)&v54.instanceData.worldToLocal.m03 = v12;
		    v14 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		    *(_OWORD *)&v54.instanceData.prevLocalToWorld.m00 = v13;
		    v15 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		    *(_OWORD *)&v54.instanceData.prevLocalToWorld.m01 = v14;
		    v16 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		    *(_OWORD *)&v54.instanceData.prevLocalToWorld.m02 = v15;
		    *(float *)&v15 = this->radius;
		    *(_OWORD *)&v54.instanceData.prevLocalToWorld.m03 = v16;
		    *(float *)&v16 = this->interactLength;
		    LODWORD(v54.instanceData.radius) = v15;
		    *(float *)&v15 = this->interactHeight;
		    LODWORD(v54.instanceData.length) = v16;
		    radius = this->radius;
		    LODWORD(v54.instanceData.height) = v15;
		    v54.instanceData.groundHeight = this->GroundHeight;
		    if ( radius > 0.0099999998 )
		      v9 = (float)(this->length * 0.5) / radius;
		    v54.instanceData.capsuleLocalHeight = v9;
		    v55 = *(_OWORD *)&v54.instanceData.localToWorld.m00;
		    v56 = *(_OWORD *)&v54.instanceData.localToWorld.m01;
		    v57 = *(_OWORD *)&v54.instanceData.localToWorld.m02;
		    v58 = *(_OWORD *)&v54.instanceData.localToWorld.m03;
		    worldToLocal = v54.instanceData.worldToLocal;
		    prevLocalToWorld = v54.instanceData.prevLocalToWorld;
		    v61 = *(_OWORD *)&v54.instanceData.radius;
		    v62 = *(_OWORD *)&v54.instanceData.groundHeight;
		    if ( this->bUseCCD )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      Capsule = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->Capsule;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      Capsule = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		    }
		    v63.klass = (SingleFieldAccessor__Class *)Capsule;
		    sub_18002D1B0(&v63, v18, v19, v20, *(MethodInfo **)&v54.instanceData.localToWorld.m00);
		    bUseCCD = this->bUseCCD;
		    BYTE4(v63.monitor) = this->bUseCCD;
		    LODWORD(v63.monitor) = bUseCCD ? 4 : 1;
		    v23 = v56;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m00 = v55;
		    v24 = v57;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m01 = v23;
		    v25 = v58;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m02 = v24;
		    v26 = *(_OWORD *)&worldToLocal.m00;
		    *(_OWORD *)&retstr->instanceData.localToWorld.m03 = v25;
		    v27 = *(_OWORD *)&worldToLocal.m01;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m00 = v26;
		    v28 = *(_OWORD *)&worldToLocal.m02;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m01 = v27;
		    v29 = *(_OWORD *)&worldToLocal.m03;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m02 = v28;
		    *(_OWORD *)&retstr->instanceData.worldToLocal.m03 = v29;
		    v30 = *(_OWORD *)&prevLocalToWorld.m01;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m00 = *(_OWORD *)&prevLocalToWorld.m00;
		    v31 = *(_OWORD *)&prevLocalToWorld.m02;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m01 = v30;
		    v32 = *(_OWORD *)&prevLocalToWorld.m03;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m02 = v31;
		    v33 = v61;
		    *(_OWORD *)&retstr->instanceData.prevLocalToWorld.m03 = v32;
		    v34 = v62;
		    *(_OWORD *)&retstr->instanceData.radius = v33;
		    v35 = *(_OWORD *)&v63.klass;
		    *(_OWORD *)&retstr->instanceData.groundHeight = v34;
		    *(_OWORD *)&retstr->mesh = v35;
		  }
		  return retstr;
		}
		
		private void ConstructTextureNode(int _nodeKey, Texture _texture, Vector2 _extent, float _heightScale, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) {} // 0x0000000189CFFD38-0x0000000189D002BC
		// Void ConstructTextureNode(Int32, Texture, Vector2, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		void HG::Rendering::Runtime::HGInteractionNode::ConstructTextureNode(
		        HGInteractionNode *this,
		        int32_t _nodeKey,
		        Texture *_texture,
		        Vector2 _extent,
		        float _heightScale,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  MethodInfo *v17; // rdx
		  Vector3 *fwd; // rax
		  __int64 v19; // xmm3_8
		  MethodInfo *v20; // r8
		  Vector4 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  MethodInfo *v24; // r8
		  Vector3 *v25; // rax
		  __int64 z_low; // rcx
		  __int32 v27; // xmm10_4
		  __m128 x_low; // xmm14
		  __m128 v29; // xmm11
		  Mathf__StaticFields *static_fields; // rax
		  Vector3 *Position; // rax
		  __int64 v32; // xmm9_8
		  float z; // ebx
		  const __m128i *v34; // rax
		  float y; // xmm7_4
		  __m128 v36; // xmm6
		  __m128i v37; // xmm8
		  double v38; // xmm0_8
		  Matrix4x4 *v39; // rax
		  __int128 v40; // xmm1
		  __int128 v41; // xmm2
		  __int128 v42; // xmm3
		  MethodInfo *v43; // rdx
		  Vector3 *v44; // rax
		  MethodInfo *v45; // r8
		  Vector4 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  MethodInfo *v49; // r8
		  Vector3 *v50; // rax
		  __int64 v51; // rcx
		  __m128 v52; // xmm14
		  __m128 v53; // xmm11
		  Mathf__StaticFields *v54; // rax
		  Vector3 *v55; // rax
		  __int64 v56; // xmm9_8
		  float v57; // ebx
		  const __m128i *v58; // rax
		  float v59; // xmm7_4
		  __m128 v60; // xmm6
		  __m128i v61; // xmm8
		  double v62; // xmm0_8
		  Matrix4x4 *v63; // rax
		  __int128 v64; // xmm1
		  __int128 v65; // xmm2
		  __int128 v66; // xmm3
		  __int64 v67; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  Vector3 v70; // [rsp+68h] [rbp-A0h] BYREF
		  Vector4 v71; // [rsp+78h] [rbp-90h] BYREF
		  Vector4 v72; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v73[2]; // [rsp+98h] [rbp-70h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1805, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1805, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v67);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_725(
		      Patch,
		      this,
		      _nodeKey,
		      (Object *)_texture,
		      _extent,
		      _heightScale,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		  }
		  else
		  {
		    this->ProxyType = 1;
		    HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
		      this,
		      _nodeKey,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    this->texture = _texture;
		    sub_18002D1B0((SingleFieldAccessor *)&this->texture, v14, v15, v16, P3);
		    this->heightScale = _heightScale;
		    this->extent = _extent;
		    fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v71, v17);
		    v19 = *(_QWORD *)&fwd->x;
		    *(float *)&fwd = fwd->z;
		    *(_QWORD *)&v70.x = v19;
		    LODWORD(v70.z) = (_DWORD)fwd;
		    v21 = *UnityEngine::Vector4::op_Implicit(&v72, &v70, v20);
		    *(_OWORD *)&v73[0].m00 = *(_OWORD *)&_transform->m00;
		    v22 = *(_OWORD *)&_transform->m02;
		    v71 = v21;
		    v23 = *(_OWORD *)&_transform->m01;
		    *(_OWORD *)&v73[0].m02 = v22;
		    *(_OWORD *)&v73[0].m01 = v23;
		    *(_OWORD *)&v73[0].m03 = *(_OWORD *)&_transform->m03;
		    v71 = *UnityEngine::Matrix4x4::op_Multiply(&v72, v73, &v71, 0LL);
		    v25 = UnityEngine::Vector4::op_Implicit(&v70, &v71, v24);
		    z_low = LODWORD(v25->z);
		    *(_QWORD *)&v71.x = *(_QWORD *)&v25->x;
		    COERCE_FLOAT(v27 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		    x_low = (__m128)LODWORD(v71.x);
		    v29 = (__m128)_mm_cvtsi32_si128(z_low);
		    static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
		    if ( fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v71.x) & v27), 0.0) * 0.000001, static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v71.x) & v27)
		      || fmaxf(fmaxf(COERCE_FLOAT(v29.m128_i32[0] & v27), 0.0) * 0.000001, static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v29.m128_f32[0]) & v27) )
		    {
		      sub_1803345E0(z_low);
		    }
		    Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v71, _transform, 0LL);
		    v32 = *(_QWORD *)&Position->x;
		    z = Position->z;
		    v34 = (const __m128i *)sub_182FA5990(&v72);
		    y = this->extent.y;
		    v36 = (__m128)LODWORD(this->extent.x);
		    v37 = _mm_loadu_si128(v34);
		    *(_QWORD *)&v70.x = _mm_unpacklo_ps(v29, x_low).m128_u64[0];
		    v38 = sub_182FA2AF0(&v70);
		    v71.z = z;
		    *(_QWORD *)&v70.x = _mm_unpacklo_ps(v36, (__m128)0x3F800000u).m128_u64[0];
		    v70.z = *(float *)&v38 * y;
		    v72 = (Vector4)v37;
		    *(_QWORD *)&v71.x = v32;
		    v39 = UnityEngine::Matrix4x4::TRS(v73, (Vector3 *)&v71, (Quaternion *)&v72, &v70, 0LL);
		    v40 = *(_OWORD *)&v39->m01;
		    v41 = *(_OWORD *)&v39->m02;
		    v42 = *(_OWORD *)&v39->m03;
		    *(_OWORD *)&this->localToWorldMatrix.m00 = *(_OWORD *)&v39->m00;
		    *(_OWORD *)&this->localToWorldMatrix.m01 = v40;
		    *(_OWORD *)&this->localToWorldMatrix.m02 = v41;
		    *(_OWORD *)&this->localToWorldMatrix.m03 = v42;
		    v44 = UnityEngine::Vector3::get_fwd(&v70, v43);
		    *(_QWORD *)&v42 = *(_QWORD *)&v44->x;
		    *(float *)&v44 = v44->z;
		    *(_QWORD *)&v71.x = v42;
		    LODWORD(v71.z) = (_DWORD)v44;
		    v46 = *UnityEngine::Vector4::op_Implicit(&v72, (Vector3 *)&v71, v45);
		    *(_OWORD *)&v73[0].m00 = *(_OWORD *)&_prevTransform->m00;
		    v47 = *(_OWORD *)&_prevTransform->m02;
		    v72 = v46;
		    v48 = *(_OWORD *)&_prevTransform->m01;
		    *(_OWORD *)&v73[0].m02 = v47;
		    *(_OWORD *)&v73[0].m01 = v48;
		    *(_OWORD *)&v73[0].m03 = *(_OWORD *)&_prevTransform->m03;
		    v72 = *UnityEngine::Matrix4x4::op_Multiply(&v71, v73, &v72, 0LL);
		    v50 = UnityEngine::Vector4::op_Implicit(&v70, &v72, v49);
		    v51 = LODWORD(v50->z);
		    *(_QWORD *)&v71.x = *(_QWORD *)&v50->x;
		    v52 = (__m128)LODWORD(v71.x);
		    v53 = (__m128)_mm_cvtsi32_si128(v51);
		    v54 = TypeInfo::UnityEngine::Mathf->static_fields;
		    if ( fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v71.x) & v27), 0.0) * 0.000001, v54->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v71.x) & v27)
		      || fmaxf(fmaxf(COERCE_FLOAT(v53.m128_i32[0] & v27), 0.0) * 0.000001, v54->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - v53.m128_f32[0]) & v27) )
		    {
		      sub_1803345E0(v51);
		    }
		    v55 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v71, _prevTransform, 0LL);
		    v56 = *(_QWORD *)&v55->x;
		    v57 = v55->z;
		    v58 = (const __m128i *)sub_182FA5990(&v72);
		    v59 = this->extent.y;
		    v60 = (__m128)LODWORD(this->extent.x);
		    v61 = _mm_loadu_si128(v58);
		    *(_QWORD *)&v70.x = _mm_unpacklo_ps(v53, v52).m128_u64[0];
		    v62 = sub_182FA2AF0(&v70);
		    v70.z = v57;
		    *(_QWORD *)&v71.x = _mm_unpacklo_ps(v60, (__m128)0x3F800000u).m128_u64[0];
		    v71.z = *(float *)&v62 * v59;
		    v72 = (Vector4)v61;
		    *(_QWORD *)&v70.x = v56;
		    v63 = UnityEngine::Matrix4x4::TRS(v73, &v70, (Quaternion *)&v72, (Vector3 *)&v71, 0LL);
		    v64 = *(_OWORD *)&v63->m01;
		    v65 = *(_OWORD *)&v63->m02;
		    v66 = *(_OWORD *)&v63->m03;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m00 = *(_OWORD *)&v63->m00;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m01 = v64;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m02 = v65;
		    *(_OWORD *)&this->prevLocalToWorldMatrix.m03 = v66;
		  }
		}
		
		private void DrawTextureNode(CommandBuffer cmd, Material material) {} // 0x0000000189D0100C-0x0000000189D012CC
		// Void DrawTextureNode(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionNode::DrawTextureNode(
		        HGInteractionNode *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Shader *shader; // rbx
		  String *s_InteractionUseCCD; // r8
		  int32_t InteractMaskTexture; // ebx
		  RenderTargetIdentifier *v12; // rax
		  __int128 v13; // xmm1
		  int32_t InteractWorldToLocal; // ebx
		  Matrix4x4 *inverse; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm1
		  int32_t PrevInteractLocalToWorld; // edx
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  Mesh *QuadMesh; // rax
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  LocalKeyword v29; // [rsp+40h] [rbp-C8h] BYREF
		  __int64 v30; // [rsp+58h] [rbp-B0h]
		  LocalKeyword keyword; // [rsp+60h] [rbp-A8h] BYREF
		  __int128 v32; // [rsp+78h] [rbp-90h]
		  __int128 v33; // [rsp+88h] [rbp-80h]
		  __int128 v34; // [rsp+98h] [rbp-70h]
		  Matrix4x4 value; // [rsp+A8h] [rbp-60h] BYREF
		  Matrix4x4 v36; // [rsp+E8h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1815, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1815, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v28, v27);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_731(Patch, this, (Object *)cmd, (Object *)material, 0LL);
		  }
		  else
		  {
		    if ( !material )
		      goto LABEL_5;
		    shader = UnityEngine::Material::get_shader(material, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD;
		    *(_OWORD *)&v29.m_Name = 0LL;
		    v30 = 0LL;
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v29.m_Name, shader, s_InteractionUseCCD, 0LL);
		    *(_QWORD *)&v32 = v30;
		    *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v29.m_Name;
		    if ( !cmd )
		LABEL_5:
		      sub_1800D8260(v8, v7);
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(
		      cmd,
		      material,
		      (LocalKeyword *)&keyword.m_Name,
		      this->bUseCCD,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundHeight,
		      this->GroundHeight,
		      0LL);
		    InteractMaskTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractMaskTexture;
		    v12 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&value,
		            this->texture,
		            0LL);
		    v13 = *(_OWORD *)&v12->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v12->m_Type;
		    *(_QWORD *)&v33 = *(_QWORD *)&v12->m_DepthSlice;
		    v32 = v13;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		      cmd,
		      InteractMaskTexture,
		      (RenderTargetIdentifier *)&keyword.m_Name,
		      0LL);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractHeightScale,
		      this->heightScale,
		      0LL);
		    InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractWorldToLocal;
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v36, &this->localToWorldMatrix, 0LL);
		    v16 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&value.m00 = *(_OWORD *)&inverse->m00;
		    v17 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&value.m01 = v16;
		    v18 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&value.m02 = v17;
		    *(_OWORD *)&value.m03 = v18;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
		    v19 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		    PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevInteractLocalToWorld;
		    *(_OWORD *)&keyword.m_Name = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		    v21 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		    v32 = v19;
		    v22 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		    v33 = v21;
		    v34 = v22;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(
		      cmd,
		      PrevInteractLocalToWorld,
		      (Matrix4x4 *)&keyword.m_Name,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		    QuadMesh = HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(0LL);
		    *(_OWORD *)&v36.m00 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    v24 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v36.m01 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    v25 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v36.m02 = v24;
		    *(_OWORD *)&v36.m03 = v25;
		    UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, QuadMesh, &v36, material, 0, 2, 0LL);
		  }
		}
		
		private void ConstructMeshNode(int _nodeKey, Mesh _mesh, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) {} // 0x0000000189CFF7E4-0x0000000189CFF8D4
		// Void ConstructMeshNode(Int32, Mesh, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		void HG::Rendering::Runtime::HGInteractionNode::ConstructMeshNode(
		        HGInteractionNode *this,
		        int32_t _nodeKey,
		        Mesh *_mesh,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MethodInfo *P3; // [rsp+20h] [rbp-38h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1807, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1807, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_727(
		      Patch,
		      this,
		      _nodeKey,
		      (Object *)_mesh,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		  }
		  else
		  {
		    this->ProxyType = 1;
		    HG::Rendering::Runtime::HGInteractionNode::ConstructNodeBase(
		      this,
		      _nodeKey,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    this->mesh = _mesh;
		    sub_18002D1B0((SingleFieldAccessor *)&this->mesh, v12, v13, v14, P3);
		  }
		}
		
		private void DrawMeshNode(CommandBuffer cmd, Material material) {} // 0x0000000189D00A8C-0x0000000189D00CC4
		// Void DrawMeshNode(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionNode::DrawMeshNode(
		        HGInteractionNode *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Shader *shader; // rbx
		  String *s_InteractionUseCCD; // r8
		  int32_t InteractWorldToLocal; // ebx
		  Matrix4x4 *inverse; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm1
		  int32_t PrevInteractLocalToWorld; // edx
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm1
		  Mesh *mesh; // rdx
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  LocalKeyword v27; // [rsp+40h] [rbp-C8h] BYREF
		  LocalKeyword keyword; // [rsp+58h] [rbp-B0h] BYREF
		  void *m_KeywordSpace; // [rsp+70h] [rbp-98h]
		  Matrix4x4 v30; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 value; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v32; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1816, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1816, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v26, v25);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_731(Patch, this, (Object *)cmd, (Object *)material, 0LL);
		  }
		  else
		  {
		    if ( !material )
		      goto LABEL_5;
		    shader = UnityEngine::Material::get_shader(material, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD;
		    *(_OWORD *)&v27.m_Name = 0LL;
		    keyword.m_SpaceInfo.m_KeywordSpace = 0LL;
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v27.m_Name, shader, s_InteractionUseCCD, 0LL);
		    m_KeywordSpace = keyword.m_SpaceInfo.m_KeywordSpace;
		    *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v27.m_Name;
		    if ( !cmd )
		LABEL_5:
		      sub_1800D8260(v8, v7);
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(
		      cmd,
		      material,
		      (LocalKeyword *)&keyword.m_Name,
		      this->bUseCCD,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		      cmd,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundHeight,
		      this->GroundHeight,
		      0LL);
		    InteractWorldToLocal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractWorldToLocal;
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v30, &this->localToWorldMatrix, 0LL);
		    v13 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&value.m00 = *(_OWORD *)&inverse->m00;
		    v14 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&value.m01 = v13;
		    v15 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&value.m02 = v14;
		    *(_OWORD *)&value.m03 = v15;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InteractWorldToLocal, &value, 0LL);
		    v16 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		    PrevInteractLocalToWorld = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevInteractLocalToWorld;
		    *(_OWORD *)&v32.m00 = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		    v18 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		    *(_OWORD *)&v32.m01 = v16;
		    v19 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		    *(_OWORD *)&v32.m02 = v18;
		    *(_OWORD *)&v32.m03 = v19;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, PrevInteractLocalToWorld, &v32, 0LL);
		    v20 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    mesh = this->mesh;
		    *(_OWORD *)&v30.m00 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    v22 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v30.m01 = v20;
		    v23 = *(_OWORD *)&this->localToWorldMatrix.m03;
		    *(_OWORD *)&v30.m02 = v22;
		    *(_OWORD *)&v30.m03 = v23;
		    UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, mesh, &v30, material, 0, 3, 0LL);
		  }
		}
		
		public static HGInteractionNode CreateSphereNode(int _nodeKey, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) => default; // 0x0000000189D0042C-0x0000000189D0059C
		// HGInteractionNode CreateSphereNode(Int32, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateSphereNode(
		        HGInteractionNode *__return_ptr retstr,
		        int32_t _nodeKey,
		        float _radius,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  HGInteractionNode *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v13; // rcx
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm0
		  _OWORD *p_m23; // rax
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  HGInteractionNode *result; // rax
		  HGInteractionNode v26; // [rsp+50h] [rbp-198h] BYREF
		  HGInteractionNode v27; // [rsp+110h] [rbp-D8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1799, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1799, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, 0LL);
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_722(
		            &v27,
		            Patch,
		            _nodeKey,
		            _radius,
		            _transform,
		            _prevTransform,
		            _groundHeight,
		            _ccd,
		            0LL);
		  }
		  else
		  {
		    sub_18033B9D0(&v26, 0LL, 192LL);
		    HG::Rendering::Runtime::HGInteractionNode::ConstructSphereNode(
		      &v26,
		      _nodeKey,
		      _radius,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    v11 = &v26;
		  }
		  v14 = *(_OWORD *)&v11->localToWorldMatrix.m20;
		  *(_OWORD *)&retstr->NodeKey = *(_OWORD *)&v11->NodeKey;
		  v15 = *(_OWORD *)&v11->localToWorldMatrix.m21;
		  *(_OWORD *)&retstr->localToWorldMatrix.m20 = v14;
		  v16 = *(_OWORD *)&v11->localToWorldMatrix.m22;
		  *(_OWORD *)&retstr->localToWorldMatrix.m21 = v15;
		  v17 = *(_OWORD *)&v11->localToWorldMatrix.m23;
		  *(_OWORD *)&retstr->localToWorldMatrix.m22 = v16;
		  v18 = *(_OWORD *)&v11->prevLocalToWorldMatrix.m20;
		  *(_OWORD *)&retstr->localToWorldMatrix.m23 = v17;
		  v19 = *(_OWORD *)&v11->prevLocalToWorldMatrix.m21;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m20 = v18;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m21 = v19;
		  v20 = *(_OWORD *)&v11->prevLocalToWorldMatrix.m22;
		  p_m23 = (_OWORD *)&v11->prevLocalToWorldMatrix.m23;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m22 = v20;
		  v22 = p_m23[1];
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m23 = *p_m23;
		  v23 = p_m23[2];
		  *(_OWORD *)&retstr->length = v22;
		  v24 = p_m23[3];
		  result = retstr;
		  *(_OWORD *)&retstr->texture = v23;
		  *(_OWORD *)&retstr->heightScale = v24;
		  return result;
		}
		
		public static HGInteractionNode CreateCapsuleNode(int _nodeKey, float _length, float _radius, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) => default; // 0x0000000182FA5AE0-0x0000000182FA5C50
		// HGInteractionNode CreateCapsuleNode(Int32, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		// local variable allocation has failed, the output may be wrong!
		HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateCapsuleNode(
		        HGInteractionNode *__return_ptr retstr,
		        int32_t _nodeKey,
		        float _length,
		        float _radius,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v10; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  HGInteractionNode *v13; // rax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  HGInteractionNode *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGInteractionNode v26; // [rsp+50h] [rbp-1A8h] BYREF
		  HGInteractionNode v27; // [rsp+110h] [rbp-E8h] BYREF
		
		  v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v10->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1802 )
		  {
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v10);
		      v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v10 = (struct ILFixDynamicMethodWrapper_2__Class *)v10->static_fields->wrapperArray;
		    if ( v10 )
		    {
		      if ( LODWORD(v10->_0.namespaze) <= 0x70A )
		        sub_1800D2AB0(v10, *(_QWORD *)&_nodeKey);
		      if ( !v10[38]._0.nestedTypes )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1802, 0LL);
		      if ( Patch )
		      {
		        v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_724(
		                &v27,
		                Patch,
		                _nodeKey,
		                _length,
		                _radius,
		                _transform,
		                _prevTransform,
		                _groundHeight,
		                _ccd,
		                0LL);
		        goto LABEL_6;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v10, *(_QWORD *)&_nodeKey);
		  }
		LABEL_5:
		  sub_18033B9D0(&v26, 0LL, 192LL);
		  HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
		    &v26,
		    _nodeKey,
		    _length,
		    _radius,
		    _transform,
		    _prevTransform,
		    _groundHeight,
		    _ccd,
		    0LL);
		  v13 = &v26;
		LABEL_6:
		  v14 = *(_OWORD *)&v13->localToWorldMatrix.m20;
		  *(_OWORD *)&retstr->NodeKey = *(_OWORD *)&v13->NodeKey;
		  v15 = *(_OWORD *)&v13->localToWorldMatrix.m21;
		  *(_OWORD *)&retstr->localToWorldMatrix.m20 = v14;
		  v16 = *(_OWORD *)&v13->localToWorldMatrix.m22;
		  *(_OWORD *)&retstr->localToWorldMatrix.m21 = v15;
		  v17 = *(_OWORD *)&v13->localToWorldMatrix.m23;
		  *(_OWORD *)&retstr->localToWorldMatrix.m22 = v16;
		  v18 = *(_OWORD *)&v13->prevLocalToWorldMatrix.m20;
		  *(_OWORD *)&retstr->localToWorldMatrix.m23 = v17;
		  v19 = *(_OWORD *)&v13->prevLocalToWorldMatrix.m21;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m20 = v18;
		  v20 = *(_OWORD *)&v13->prevLocalToWorldMatrix.m23;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m21 = v19;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m22 = *(_OWORD *)&v13->prevLocalToWorldMatrix.m22;
		  v21 = *(_OWORD *)&v13->length;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m23 = v20;
		  v22 = *(_OWORD *)&v13->texture;
		  *(_OWORD *)&retstr->length = v21;
		  v23 = *(_OWORD *)&v13->heightScale;
		  result = retstr;
		  *(_OWORD *)&retstr->texture = v22;
		  *(_OWORD *)&retstr->heightScale = v23;
		  return result;
		}
		
		public static HGInteractionNode CreateTextureNode(int _nodeKey, Texture _texture, Vector2 _extent, float _heightScale, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) => default; // 0x0000000189D0059C-0x0000000189D00748
		// HGInteractionNode CreateTextureNode(Int32, Texture, Vector2, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateTextureNode(
		        HGInteractionNode *__return_ptr retstr,
		        int32_t _nodeKey,
		        Texture *_texture,
		        Vector2 _extent,
		        float _heightScale,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  HGInteractionNode *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v16; // rcx
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm0
		  _OWORD *p_m23; // rax
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  HGInteractionNode *result; // rax
		  HGInteractionNode v29; // [rsp+60h] [rbp-198h] BYREF
		  HGInteractionNode v30; // [rsp+120h] [rbp-D8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1804, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1804, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, 0LL);
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_726(
		            &v30,
		            Patch,
		            _nodeKey,
		            (Object *)_texture,
		            _extent,
		            _heightScale,
		            _transform,
		            _prevTransform,
		            _groundHeight,
		            _ccd,
		            0LL);
		  }
		  else
		  {
		    sub_18033B9D0(&v29, 0LL, 192LL);
		    HG::Rendering::Runtime::HGInteractionNode::ConstructTextureNode(
		      &v29,
		      _nodeKey,
		      _texture,
		      _extent,
		      _heightScale,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    v14 = &v29;
		  }
		  v17 = *(_OWORD *)&v14->localToWorldMatrix.m20;
		  *(_OWORD *)&retstr->NodeKey = *(_OWORD *)&v14->NodeKey;
		  v18 = *(_OWORD *)&v14->localToWorldMatrix.m21;
		  *(_OWORD *)&retstr->localToWorldMatrix.m20 = v17;
		  v19 = *(_OWORD *)&v14->localToWorldMatrix.m22;
		  *(_OWORD *)&retstr->localToWorldMatrix.m21 = v18;
		  v20 = *(_OWORD *)&v14->localToWorldMatrix.m23;
		  *(_OWORD *)&retstr->localToWorldMatrix.m22 = v19;
		  v21 = *(_OWORD *)&v14->prevLocalToWorldMatrix.m20;
		  *(_OWORD *)&retstr->localToWorldMatrix.m23 = v20;
		  v22 = *(_OWORD *)&v14->prevLocalToWorldMatrix.m21;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m20 = v21;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m21 = v22;
		  v23 = *(_OWORD *)&v14->prevLocalToWorldMatrix.m22;
		  p_m23 = (_OWORD *)&v14->prevLocalToWorldMatrix.m23;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m22 = v23;
		  v25 = p_m23[1];
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m23 = *p_m23;
		  v26 = p_m23[2];
		  *(_OWORD *)&retstr->length = v25;
		  v27 = p_m23[3];
		  result = retstr;
		  *(_OWORD *)&retstr->texture = v26;
		  *(_OWORD *)&retstr->heightScale = v27;
		  return result;
		}
		
		public static HGInteractionNode CreateMeshNode(int _nodeKey, Mesh _mesh, ref Matrix4x4 _transform, ref Matrix4x4 _prevTransform, float _groundHeight, bool _ccd) => default; // 0x0000000189D002BC-0x0000000189D0042C
		// HGInteractionNode CreateMeshNode(Int32, Mesh, Matrix4x4 ByRef, Matrix4x4 ByRef, Single, Boolean)
		HGInteractionNode *HG::Rendering::Runtime::HGInteractionNode::CreateMeshNode(
		        HGInteractionNode *__return_ptr retstr,
		        int32_t _nodeKey,
		        Mesh *_mesh,
		        Matrix4x4 *_transform,
		        Matrix4x4 *_prevTransform,
		        float _groundHeight,
		        bool _ccd,
		        MethodInfo *method)
		{
		  HGInteractionNode *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm0
		  _OWORD *p_m23; // rax
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  HGInteractionNode *result; // rax
		  HGInteractionNode v27; // [rsp+50h] [rbp-188h] BYREF
		  HGInteractionNode v28; // [rsp+110h] [rbp-C8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1806, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1806, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, 0LL);
		    v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_728(
		            &v28,
		            Patch,
		            _nodeKey,
		            (Object *)_mesh,
		            _transform,
		            _prevTransform,
		            _groundHeight,
		            _ccd,
		            0LL);
		  }
		  else
		  {
		    sub_18033B9D0(&v27, 0LL, 192LL);
		    HG::Rendering::Runtime::HGInteractionNode::ConstructMeshNode(
		      &v27,
		      _nodeKey,
		      _mesh,
		      _transform,
		      _prevTransform,
		      _groundHeight,
		      _ccd,
		      0LL);
		    v12 = &v27;
		  }
		  v15 = *(_OWORD *)&v12->localToWorldMatrix.m20;
		  *(_OWORD *)&retstr->NodeKey = *(_OWORD *)&v12->NodeKey;
		  v16 = *(_OWORD *)&v12->localToWorldMatrix.m21;
		  *(_OWORD *)&retstr->localToWorldMatrix.m20 = v15;
		  v17 = *(_OWORD *)&v12->localToWorldMatrix.m22;
		  *(_OWORD *)&retstr->localToWorldMatrix.m21 = v16;
		  v18 = *(_OWORD *)&v12->localToWorldMatrix.m23;
		  *(_OWORD *)&retstr->localToWorldMatrix.m22 = v17;
		  v19 = *(_OWORD *)&v12->prevLocalToWorldMatrix.m20;
		  *(_OWORD *)&retstr->localToWorldMatrix.m23 = v18;
		  v20 = *(_OWORD *)&v12->prevLocalToWorldMatrix.m21;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m20 = v19;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m21 = v20;
		  v21 = *(_OWORD *)&v12->prevLocalToWorldMatrix.m22;
		  p_m23 = (_OWORD *)&v12->prevLocalToWorldMatrix.m23;
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m22 = v21;
		  v23 = p_m23[1];
		  *(_OWORD *)&retstr->prevLocalToWorldMatrix.m23 = *p_m23;
		  v24 = p_m23[2];
		  *(_OWORD *)&retstr->length = v23;
		  v25 = p_m23[3];
		  result = retstr;
		  *(_OWORD *)&retstr->texture = v24;
		  *(_OWORD *)&retstr->heightScale = v25;
		  return result;
		}
		
		public void DrawNode(CommandBuffer cmd, Material material) {} // 0x0000000189D00CC4-0x0000000189D00D94
		// Void DrawNode(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionNode::DrawNode(
		        HGInteractionNode *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  uint32_t ProxyType; // r8d
		  uint32_t v8; // r8d
		  uint32_t v9; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1817, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1817, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_731(Patch, this, (Object *)cmd, (Object *)material, 0LL);
		  }
		  else
		  {
		    ProxyType = this->ProxyType;
		    if ( ProxyType )
		    {
		      v8 = ProxyType - 1;
		      if ( v8 )
		      {
		        v9 = v8 - 1;
		        if ( v9 )
		        {
		          if ( v9 == 1 )
		            HG::Rendering::Runtime::HGInteractionNode::DrawMeshNode(this, cmd, material, 0LL);
		        }
		        else
		        {
		          HG::Rendering::Runtime::HGInteractionNode::DrawTextureNode(this, cmd, material, 0LL);
		        }
		      }
		      else
		      {
		        HG::Rendering::Runtime::HGInteractionNode::DrawCapsuleNode(this, cmd, material, 0LL);
		      }
		    }
		    else
		    {
		      HG::Rendering::Runtime::HGInteractionNode::DrawSphereNode(this, cmd, material, 0LL);
		    }
		  }
		}
		
		public bool BuildRenderData(out HGInteractionNodeRenderData renderData) {
			renderData = default;
			return default;
		} // 0x0000000189CFF30C-0x0000000189CFF4D0
		// Boolean BuildRenderData(HGInteractionNodeRenderData ByRef)
		bool HG::Rendering::Runtime::HGInteractionNode::BuildRenderData(
		        HGInteractionNode *this,
		        HGInteractionNodeRenderData *renderData,
		        MethodInfo *method)
		{
		  HGInteractionNodeRenderData *v5; // rax
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int128 v8; // xmm0
		  __int128 *p_prevLocalToWorld; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int128 v14; // [rsp+20h] [rbp-1E8h]
		  __int128 v15; // [rsp+30h] [rbp-1D8h]
		  __int128 v16; // [rsp+40h] [rbp-1C8h]
		  __int128 v17; // [rsp+50h] [rbp-1B8h]
		  __int128 v18; // [rsp+60h] [rbp-1A8h]
		  __int128 v19; // [rsp+70h] [rbp-198h]
		  __int128 v20; // [rsp+80h] [rbp-188h]
		  __int128 v21; // [rsp+A0h] [rbp-168h]
		  __int128 v22; // [rsp+B0h] [rbp-158h]
		  __int128 v23; // [rsp+C0h] [rbp-148h]
		  __int128 v24; // [rsp+D0h] [rbp-138h]
		  __int128 v25; // [rsp+E0h] [rbp-128h]
		  __int128 v26; // [rsp+F0h] [rbp-118h]
		  __int128 v27; // [rsp+100h] [rbp-108h]
		  HGInteractionNodeRenderData v28; // [rsp+110h] [rbp-F8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1818, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1818, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_733(Patch, this, renderData, 0LL);
		  }
		  else
		  {
		    if ( !this->ProxyType )
		    {
		      v5 = HG::Rendering::Runtime::HGInteractionNode::BuildSphereRenderData(&v28, this, 0LL);
		LABEL_4:
		      v14 = *(_OWORD *)&v5->instanceData.localToWorld.m00;
		      v15 = *(_OWORD *)&v5->instanceData.localToWorld.m01;
		      v16 = *(_OWORD *)&v5->instanceData.localToWorld.m02;
		      v17 = *(_OWORD *)&v5->instanceData.localToWorld.m03;
		      v18 = *(_OWORD *)&v5->instanceData.worldToLocal.m00;
		      v19 = *(_OWORD *)&v5->instanceData.worldToLocal.m01;
		      v20 = *(_OWORD *)&v5->instanceData.worldToLocal.m02;
		      v8 = *(_OWORD *)&v5->instanceData.worldToLocal.m03;
		      p_prevLocalToWorld = (__int128 *)&v5->instanceData.prevLocalToWorld;
		      v21 = *p_prevLocalToWorld;
		      v22 = p_prevLocalToWorld[1];
		      v23 = p_prevLocalToWorld[2];
		      v24 = p_prevLocalToWorld[3];
		      v25 = p_prevLocalToWorld[4];
		      v26 = p_prevLocalToWorld[5];
		      v27 = p_prevLocalToWorld[6];
		      *(_OWORD *)&renderData->instanceData.localToWorld.m00 = v14;
		      *(_OWORD *)&renderData->instanceData.localToWorld.m01 = v15;
		      *(_OWORD *)&renderData->instanceData.localToWorld.m02 = v16;
		      *(_OWORD *)&renderData->instanceData.localToWorld.m03 = v17;
		      *(_OWORD *)&renderData->instanceData.worldToLocal.m00 = v18;
		      *(_OWORD *)&renderData->instanceData.worldToLocal.m01 = v19;
		      *(_OWORD *)&renderData->instanceData.worldToLocal.m02 = v20;
		      *(_OWORD *)&renderData->instanceData.worldToLocal.m03 = v8;
		      *(_OWORD *)&renderData->instanceData.prevLocalToWorld.m00 = v21;
		      *(_OWORD *)&renderData->instanceData.prevLocalToWorld.m01 = v22;
		      *(_OWORD *)&renderData->instanceData.prevLocalToWorld.m02 = v23;
		      *(_OWORD *)&renderData->instanceData.prevLocalToWorld.m03 = v24;
		      *(_OWORD *)&renderData->instanceData.radius = v25;
		      *(_OWORD *)&renderData->instanceData.groundHeight = v26;
		      *(_OWORD *)&renderData->mesh = v27;
		      sub_18002D1B0((SingleFieldAccessor *)&renderData->mesh, (Type *)0x80, v6, v7, (MethodInfo *)v14);
		      return 1;
		    }
		    if ( this->ProxyType == 1 )
		    {
		      v5 = HG::Rendering::Runtime::HGInteractionNode::BuildCapsuleRenderData(&v28, this, 0LL);
		      goto LABEL_4;
		    }
		    sub_18033B9D0(renderData, 0LL, 240LL);
		    return 0;
		  }
		}
		
		private Bounds GetLocalBounds() => default; // 0x0000000189D013E4-0x0000000189D01554
		// Bounds GetLocalBounds()
		Bounds *HG::Rendering::Runtime::HGInteractionNode::GetLocalBounds(
		        Bounds *__return_ptr retstr,
		        HGInteractionNode *this,
		        MethodInfo *method)
		{
		  Animator *v5; // rdx
		  int32_t v6; // r8d
		  MethodInfo *v7; // r9
		  uint32_t ProxyType; // ecx
		  uint32_t v9; // ecx
		  HGInteractionResources__StaticFields *static_fields; // rcx
		  Vector3 *v11; // rax
		  __int64 v12; // xmm3_8
		  Vector3 *v13; // rax
		  Bounds *v14; // r8
		  __int64 v15; // xmm1_8
		  float v16; // ecx
		  float v17; // edx
		  Bounds *v18; // rdx
		  Mesh *Capsule; // rdx
		  Bounds *bounds; // rax
		  Vector3 *Vector; // rax
		  __int64 v22; // xmm3_8
		  Vector3 *one; // rax
		  float v24; // edx
		  float z; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // [rsp+20h] [rbp-30h] BYREF
		  float v29; // [rsp+28h] [rbp-28h]
		  Bounds v30; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1819, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1819, 0LL);
		    if ( Patch )
		    {
		      bounds = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_734(&v30, Patch, this, 0LL);
		      goto LABEL_17;
		    }
		LABEL_15:
		    sub_1800D8260(static_fields, Capsule);
		  }
		  ProxyType = this->ProxyType;
		  if ( !ProxyType )
		    goto LABEL_11;
		  v9 = ProxyType - 1;
		  if ( !v9 )
		  {
		    if ( this->bUseCCD )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		      Capsule = static_fields->Capsule;
		LABEL_9:
		      if ( Capsule )
		      {
		        bounds = UnityEngine::Mesh::get_bounds(&v30, Capsule, 0LL);
		LABEL_17:
		        *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&bounds->m_Center.x;
		        *(_QWORD *)&retstr->m_Extents.y = *(_QWORD *)&bounds->m_Extents.y;
		        return retstr;
		      }
		      goto LABEL_15;
		    }
		LABEL_11:
		    Vector = UnityEngine::Animator::GetVector(&v30.m_Center, v5, v6, v7);
		    v22 = *(_QWORD *)&Vector->x;
		    one = UnityEngine::Vector3::get_one(&v30.m_Center, (MethodInfo *)LODWORD(Vector->z));
		    v29 = v24;
		    v14 = &v30;
		    v28 = v22;
		    v18 = (Bounds *)&v28;
		    z = one->z;
		    *(_QWORD *)&v30.m_Center.x = *(_QWORD *)&one->x;
		    v30.m_Center.z = z;
		    goto LABEL_7;
		  }
		  static_fields = (HGInteractionResources__StaticFields *)(v9 - 1);
		  if ( !(_DWORD)static_fields )
		    goto LABEL_11;
		  if ( (_DWORD)static_fields == 1 )
		  {
		    Capsule = this->mesh;
		    goto LABEL_9;
		  }
		  v11 = UnityEngine::Animator::GetVector(&v30.m_Center, v5, v6, v7);
		  v12 = *(_QWORD *)&v11->x;
		  v13 = UnityEngine::Vector3::get_one(&v30.m_Center, (MethodInfo *)LODWORD(v11->z));
		  v14 = (Bounds *)&v28;
		  v15 = *(_QWORD *)&v13->x;
		  v16 = v13->z;
		  v30.m_Center.z = v17;
		  v18 = &v30;
		  v28 = v15;
		  v29 = v16;
		  *(_QWORD *)&v30.m_Center.x = v12;
		LABEL_7:
		  *(_OWORD *)&retstr->m_Center.x = 0LL;
		  *(_QWORD *)&retstr->m_Extents.y = 0LL;
		  UnityEngine::Bounds::Bounds(retstr, &v18->m_Center, &v14->m_Center, 0LL);
		  return retstr;
		}
		
		public Bounds GetBounds() => default; // 0x0000000189D012CC-0x0000000189D013E4
		// Bounds GetBounds()
		Bounds *HG::Rendering::Runtime::HGInteractionNode::GetBounds(
		        Bounds *__return_ptr retstr,
		        HGInteractionNode *this,
		        MethodInfo *method)
		{
		  Bounds *LocalBounds; // rax
		  __int64 v6; // xmm1_8
		  __int128 v7; // xmm0
		  Bounds *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm0
		  __int64 v13; // xmm1_8
		  Bounds *result; // rax
		  Bounds v15; // [rsp+20h] [rbp-A8h] BYREF
		  Bounds v16; // [rsp+38h] [rbp-90h] BYREF
		  __int128 v17; // [rsp+50h] [rbp-78h]
		  __int128 v18; // [rsp+60h] [rbp-68h]
		  __int128 v19; // [rsp+70h] [rbp-58h]
		  Matrix4x4 v20; // [rsp+80h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1820, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1820, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_734(&v16, Patch, this, 0LL);
		  }
		  else
		  {
		    LocalBounds = HG::Rendering::Runtime::HGInteractionNode::GetLocalBounds(&v15, this, 0LL);
		    v6 = *(_QWORD *)&LocalBounds->m_Extents.y;
		    *(_OWORD *)&v16.m_Center.x = *(_OWORD *)&LocalBounds->m_Center.x;
		    v7 = *(_OWORD *)&this->localToWorldMatrix.m00;
		    *(_QWORD *)&v16.m_Extents.y = v6;
		    v17 = v7;
		    v18 = *(_OWORD *)&this->localToWorldMatrix.m01;
		    v19 = *(_OWORD *)&this->localToWorldMatrix.m02;
		    *(_OWORD *)&v15.m_Center.x = *(_OWORD *)&this->localToWorldMatrix.m03;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_OWORD *)&v20.m00 = v17;
		    *(_OWORD *)&v20.m01 = v18;
		    *(_OWORD *)&v20.m02 = v19;
		    *(_OWORD *)&v20.m03 = *(_OWORD *)&v15.m_Center.x;
		    v8 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v15, &v16, &v20, 0LL);
		  }
		  v12 = *(_OWORD *)&v8->m_Center.x;
		  v13 = *(_QWORD *)&v8->m_Extents.y;
		  result = retstr;
		  *(_OWORD *)&retstr->m_Center.x = v12;
		  *(_QWORD *)&retstr->m_Extents.y = v13;
		  return result;
		}
		
		public HGInteractionNodeV2 BuildNativeNode() => default; // 0x0000000183105DB0-0x0000000183106070
		// HGInteractionNodeV2 BuildNativeNode()
		HGInteractionNodeV2 *HG::Rendering::Runtime::HGInteractionNode::BuildNativeNode(
		        HGInteractionNodeV2 *__return_ptr retstr,
		        HGInteractionNode *this,
		        MethodInfo *method)
		{
		  Object_1 *v5; // rcx
		  __int64 v6; // rdx
		  __int128 v7; // xmm1
		  Texture *texture; // rsi
		  bool v9; // zf
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  int32_t NodeKey; // eax
		  __int128 v13; // xmm0
		  uint32_t ProxyType; // eax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  int32_t v19; // edi
		  int32_t InstanceID; // eax
		  float y; // xmm1_4
		  Mesh *mesh; // rsi
		  float heightScale; // xmm0_4
		  HGInteractionNodeV2 *v24; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  int32_t m_mesh; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGInteractionNodeV2 v37; // [rsp+20h] [rbp-69h] BYREF
		
		  v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *(_QWORD *)v5[7].fields.m_CachedPtr;
		  if ( !v6 )
		    goto LABEL_24;
		  if ( *(int *)(v6 + 24) > 1821 )
		  {
		    if ( !LODWORD(v5[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = *(Object_1 **)v5[7].fields.m_CachedPtr;
		    if ( !v5 )
		      goto LABEL_24;
		    if ( LODWORD(v5[1].klass) <= 0x71D )
		      sub_1800D2AB0(v5, v6);
		    if ( v5[608].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1821, 0LL);
		      if ( Patch )
		      {
		        v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_735(&v37, Patch, this, 0LL);
		        goto LABEL_23;
		      }
		      goto LABEL_24;
		    }
		  }
		  v7 = *(_OWORD *)&this->localToWorldMatrix.m01;
		  texture = this->texture;
		  *(_OWORD *)&v37.m_localToWorldMatrix.m00 = *(_OWORD *)&this->localToWorldMatrix.m00;
		  v9 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		  v10 = *(_OWORD *)&this->localToWorldMatrix.m02;
		  *(_WORD *)(&v37.m_bUseCCD + 1) = 0;
		  *(_OWORD *)&v37.m_localToWorldMatrix.m01 = v7;
		  *(&v37.m_bUseCCD + 3) = 0;
		  v11 = *(_OWORD *)&this->localToWorldMatrix.m03;
		  NodeKey = this->NodeKey;
		  *(_OWORD *)&v37.m_localToWorldMatrix.m02 = v10;
		  v37.m_nodeKey = NodeKey;
		  v13 = *(_OWORD *)&this->prevLocalToWorldMatrix.m00;
		  ProxyType = this->ProxyType;
		  *(_OWORD *)&v37.m_localToWorldMatrix.m03 = v11;
		  v37.m_proxyType = ProxyType;
		  v15 = *(_OWORD *)&this->prevLocalToWorldMatrix.m01;
		  LOBYTE(ProxyType) = this->bUseCCD;
		  *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m00 = v13;
		  v37.m_bUseCCD = ProxyType;
		  v16 = *(_OWORD *)&this->prevLocalToWorldMatrix.m02;
		  *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m01 = v15;
		  v17 = *(_OWORD *)&this->prevLocalToWorldMatrix.m03;
		  *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m02 = v16;
		  v37.m_groundHeight = this->GroundHeight;
		  v18 = *(_OWORD *)&this->length;
		  *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m03 = v17;
		  *(_OWORD *)&v37.m_length = v18;
		  if ( v9 )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v19 = 0;
		  if ( !texture )
		    goto LABEL_13;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( texture->fields._.m_CachedPtr )
		  {
		    v5 = (Object_1 *)this->texture;
		    if ( !v5 )
		      goto LABEL_24;
		    InstanceID = UnityEngine::Object::GetInstanceID(v5, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    InstanceID = 0;
		  }
		  y = this->extent.y;
		  mesh = this->mesh;
		  v37.m_extent.x = this->extent.x;
		  heightScale = this->heightScale;
		  v37.m_extent.y = y;
		  v37.m_heightScale = heightScale;
		  v37.m_texture = InstanceID;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !mesh )
		    goto LABEL_22;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !mesh->fields._.m_CachedPtr )
		    goto LABEL_22;
		  v5 = (Object_1 *)this->mesh;
		  if ( !v5 )
		LABEL_24:
		    sub_1800D8260(v5, v6);
		  v19 = UnityEngine::Object::GetInstanceID(v5, 0LL);
		LABEL_22:
		  v37.m_mesh = v19;
		  v24 = &v37;
		LABEL_23:
		  v25 = *(_OWORD *)&v24->m_localToWorldMatrix.m20;
		  *(_OWORD *)&retstr->m_nodeKey = *(_OWORD *)&v24->m_nodeKey;
		  v26 = *(_OWORD *)&v24->m_localToWorldMatrix.m21;
		  *(_OWORD *)&retstr->m_localToWorldMatrix.m20 = v25;
		  v27 = *(_OWORD *)&v24->m_localToWorldMatrix.m22;
		  *(_OWORD *)&retstr->m_localToWorldMatrix.m21 = v26;
		  v28 = *(_OWORD *)&v24->m_localToWorldMatrix.m23;
		  *(_OWORD *)&retstr->m_localToWorldMatrix.m22 = v27;
		  v29 = *(_OWORD *)&v24->m_prevLocalToWorldMatrix.m20;
		  *(_OWORD *)&retstr->m_localToWorldMatrix.m23 = v28;
		  v30 = *(_OWORD *)&v24->m_prevLocalToWorldMatrix.m21;
		  *(_OWORD *)&retstr->m_prevLocalToWorldMatrix.m20 = v29;
		  v31 = *(_OWORD *)&v24->m_prevLocalToWorldMatrix.m23;
		  *(_OWORD *)&retstr->m_prevLocalToWorldMatrix.m21 = v30;
		  *(_OWORD *)&retstr->m_prevLocalToWorldMatrix.m22 = *(_OWORD *)&v24->m_prevLocalToWorldMatrix.m22;
		  v32 = *(_OWORD *)&v24->m_length;
		  *(_OWORD *)&retstr->m_prevLocalToWorldMatrix.m23 = v31;
		  v33 = *(_OWORD *)&v24->m_texture;
		  m_mesh = v24->m_mesh;
		  *(_OWORD *)&retstr->m_length = v32;
		  *(_OWORD *)&retstr->m_texture = v33;
		  retstr->m_mesh = m_mesh;
		  return retstr;
		}
		
	}
}
