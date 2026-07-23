using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	public class HGWindMotor : VFXPlayableMonoBase // TypeDefIndex: 37703
	{
		// Fields
		public HGWindMotorData data; // 0x20
	
		// Constructors
		public HGWindMotor() {} // 0x00000001842EDE70-0x00000001842EDF00
		// HGWindMotor()
		void HG::Rendering::Runtime::HGWindMotor::HGWindMotor(HGWindMotor *this, MethodInfo *method)
		{
		  __int128 v2; // [rsp+20h] [rbp-48h]
		  __int128 v3; // [rsp+30h] [rbp-38h]
		
		  *(_QWORD *)((char *)&v2 + 4) = 0LL;
		  LODWORD(v2) = 0;
		  *(_WORD *)((char *)&v3 + 9) = 0;
		  BYTE11(v3) = 0;
		  BYTE8(v3) = 0;
		  HIDWORD(v2) = 1065353216;
		  HIDWORD(v3) = 1065353216;
		  *(_OWORD *)&this->fields.data.windPriority = v2;
		  *(_QWORD *)&v3 = 0x3F8000003F800000LL;
		  *(_OWORD *)&this->fields.data.width = v3;
		  *(_OWORD *)&this->fields.data.angle = 0x41A0000043B40000uLL;
		  this->fields.data.distanceToCamera = INFINITY;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		protected override void OnPlay() {} // 0x0000000184774020-0x0000000184774090
		// Void OnPlay()
		void HG::Rendering::Runtime::HGWindMotor::OnPlay(HGWindMotor *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGWindManager *windManager_k__BackingField; // rcx
		  HGManagerContext *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1709, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1709, 0LL);
		    if ( !Patch )
		      goto LABEL_3;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext )
		      goto LABEL_3;
		    if ( currentManagerContext->fields._windManager_k__BackingField )
		    {
		      v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( v6 )
		      {
		        windManager_k__BackingField = v6->fields._windManager_k__BackingField;
		        if ( windManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::HGWindManager::RegisterWindMotor(windManager_k__BackingField, this, 0LL);
		          return;
		        }
		      }
		LABEL_3:
		      sub_1800D8260(windManager_k__BackingField, v4);
		    }
		  }
		}
		
		protected override void OnStop() {} // 0x0000000184773EB0-0x0000000184773F30
		// Void OnStop()
		void HG::Rendering::Runtime::HGWindMotor::OnStop(HGWindMotor *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGWindManager *windManager_k__BackingField; // rcx
		  HGManagerContext *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1710, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1710, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext )
		      goto LABEL_4;
		    if ( currentManagerContext->fields._windManager_k__BackingField )
		    {
		      this->fields.data.motorInfo = -1;
		      v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( v6 )
		      {
		        windManager_k__BackingField = v6->fields._windManager_k__BackingField;
		        if ( windManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(windManager_k__BackingField, this, 0LL);
		          return;
		        }
		      }
		LABEL_4:
		      sub_1800D8260(windManager_k__BackingField, v4);
		    }
		  }
		}
		
		private void OnDestroy() {} // 0x0000000189CF7450-0x0000000189CF74CC
		// Void OnDestroy()
		void HG::Rendering::Runtime::HGWindMotor::OnDestroy(HGWindMotor *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGWindManager *windManager_k__BackingField; // rcx
		  HGManagerContext *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1711, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      if ( !currentManagerContext->fields._windManager_k__BackingField )
		        return;
		      v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( v6 )
		      {
		        windManager_k__BackingField = v6->fields._windManager_k__BackingField;
		        if ( windManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(windManager_k__BackingField, this, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(windManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1711, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public Vector3 GetDirection() => default; // 0x0000000183440A30-0x0000000183440CB0
		// Vector3 GetDirection()
		Vector3 *HG::Rendering::Runtime::HGWindMotor::GetDirection(
		        Vector3 *__return_ptr retstr,
		        HGWindMotor *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  __m128 v6; // xmm6
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (__fastcall *v8)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  __int64 v9; // rdi
		  void (__fastcall *v10)(__int64, Quaternion *); // rax
		  Vector3 *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // r8
		  __m128 v14; // xmm8
		  float z; // xmm7_4
		  struct Math__Class *v16; // rcx
		  __m128d v17; // xmm2
		  double v18; // xmm0_8
		  float v19; // xmm0_4
		  __m128 v20; // xmm1
		  Vector3 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v23; // rax
		  __int64 v24; // xmm0_8
		  __int64 v25; // rax
		  __int64 v26; // rax
		  Vector3 v27; // [rsp+20h] [rbp-68h] BYREF
		  Quaternion v28; // [rsp+30h] [rbp-58h] BYREF
		  Quaternion v29; // [rsp+40h] [rbp-48h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v6 = 0LL;
		  *(_QWORD *)&v27.x = 0LL;
		  v27.z = 0.0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_19;
		  if ( wrapperArray->max_length.size <= 926 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		  if ( !v4 )
		LABEL_19:
		    sub_1800D8260(v4, wrapperArray);
		  if ( LODWORD(v4->_0.namespaze) <= 0x39E )
		    sub_1800D2AB0(v4, wrapperArray);
		  if ( *(_QWORD *)&v4[19]._1.interfaces_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(926, 0LL);
		    if ( Patch )
		    {
		      v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(&v27, Patch, (Object *)this, 0LL);
		      v24 = *(_QWORD *)&v23->x;
		      *(float *)&v23 = v23->z;
		      *(_QWORD *)&retstr->x = v24;
		      LODWORD(retstr->z) = (_DWORD)v23;
		      return retstr;
		    }
		    goto LABEL_19;
		  }
		LABEL_5:
		  v8 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v8 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v8 )
		    {
		      v25 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v25, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v8;
		  }
		  v9 = v8(this, wrapperArray, method);
		  if ( !v9 )
		    goto LABEL_19;
		  v10 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		  v28 = 0LL;
		  if ( !qword_18F370110 )
		  {
		    v10 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		    if ( !v10 )
		    {
		      v26 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		      sub_18007E1B0(v26, 0LL);
		    }
		    qword_18F370110 = (__int64)v10;
		  }
		  v10(v9, &v28);
		  v27.z = 1.0;
		  *(_QWORD *)&v27.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v29 = v28;
		  v11 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v28, &v29, &v27, 0LL);
		  v14 = (__m128)*(unsigned __int64 *)&v11->x;
		  z = v11->z;
		  if ( v14.m128_f32[0] != 0.0 || z != 0.0 )
		  {
		    v16 = TypeInfo::System::Math;
		    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		    v17 = 0LL;
		    v17.m128d_f64[0] = (float)((float)((float)(v14.m128_f32[0] * v14.m128_f32[0]) + 0.0) + (float)(z * z));
		    if ( v17.m128d_f64[0] < 0.0 )
		      v18 = sub_1801D32D0(v16, v12, v13);
		    else
		      *(_QWORD *)&v18 = *(_OWORD *)&_mm_sqrt_pd(v17);
		    v19 = v18;
		    v20 = 0LL;
		    if ( v19 <= 0.0000099999997 )
		    {
		      z = 0.0;
		    }
		    else
		    {
		      v14.m128_f32[0] = v14.m128_f32[0] / v19;
		      v20.m128_f32[0] = 0.0 / v19;
		      z = z / v19;
		      v6 = v14;
		    }
		    v14 = v6;
		    v6 = v20;
		  }
		  result = retstr;
		  *(_QWORD *)&retstr->x = _mm_unpacklo_ps(v14, v6).m128_u64[0];
		  retstr->z = z;
		  return result;
		}
		
		public Vector3 GetPosition() => default; // 0x000000018344CA00-0x000000018344CAC0
		// Vector3 GetPosition()
		Vector3 *HG::Rendering::Runtime::HGWindMotor::GetPosition(
		        Vector3 *__return_ptr retstr,
		        HGWindMotor *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __int64 (__fastcall *v7)(HGWindMotor *); // rax
		  __int64 v8; // rdi
		  void (__fastcall *v9)(__int64, Vector3 *); // rax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  __int64 v15; // rax
		  __int64 v16; // rax
		  Vector3 v17[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 920 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_10:
		    sub_1800D8260(v5, this);
		  if ( LODWORD(v5->_0.namespaze) <= 0x398 )
		    sub_1800D2AB0(v5, this);
		  if ( *(_QWORD *)&v5[19]._1.instance_size )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(920, 0LL);
		    if ( Patch )
		    {
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v17, Patch, (Object *)this, 0LL);
		      v14 = *(_QWORD *)&v13->x;
		      z = v13->z;
		      *(_QWORD *)&retstr->x = v14;
		      goto LABEL_9;
		    }
		    goto LABEL_10;
		  }
		LABEL_5:
		  v7 = (__int64 (__fastcall *)(HGWindMotor *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v7 = (__int64 (__fastcall *)(HGWindMotor *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v7 )
		    {
		      v15 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v15, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v7;
		  }
		  v8 = v7(this);
		  if ( !v8 )
		    goto LABEL_10;
		  *(_QWORD *)&v17[0].x = 0LL;
		  v17[0].z = 0.0;
		  v9 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v9 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v9 )
		    {
		      v16 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v16, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v9;
		  }
		  v9(v8, v17);
		  z = v17[0].z;
		  *(_QWORD *)&retstr->x = *(_QWORD *)&v17[0].x;
		LABEL_9:
		  retstr->z = z;
		  return retstr;
		}
		
		public Bounds GetBounds() => default; // 0x0000000189CF70C4-0x0000000189CF7450
		// Bounds GetBounds()
		Bounds *HG::Rendering::Runtime::HGWindMotor::GetBounds(
		        Bounds *__return_ptr retstr,
		        HGWindMotor *this,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // rdx
		  Vector3 *v6; // rax
		  __int64 v7; // xmm1_8
		  MethodInfo *v8; // r9
		  Vector3 *v9; // rax
		  __int64 v10; // xmm1_8
		  Animator *v11; // rdx
		  int32_t v12; // r8d
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  __int64 v15; // xmm1_8
		  Transform *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v20; // xmm6
		  __int128 v21; // xmm7
		  __int128 v22; // xmm8
		  __int128 v23; // xmm9
		  Bounds *v24; // rax
		  Transform *transform; // rax
		  Vector3 *localScale; // rax
		  __int64 v27; // xmm6_8
		  float z; // ebx
		  Vector3 *v29; // rax
		  __int64 v30; // xmm0_8
		  Vector3 *v31; // rax
		  __int64 v32; // xmm7_8
		  float v33; // r14d
		  Transform *v34; // rax
		  Vector3 *position; // rax
		  __int64 v36; // xmm6_8
		  float v37; // ebx
		  Transform *v38; // rax
		  Quaternion *rotation; // rax
		  Matrix4x4 *v40; // rbx
		  MethodInfo *v41; // rdx
		  Vector3 *one; // rax
		  float v43; // ecx
		  MethodInfo *v44; // r9
		  Vector3 *v45; // rax
		  __int64 v46; // xmm1_8
		  Animator *v47; // rdx
		  int32_t v48; // r8d
		  MethodInfo *v49; // r9
		  Vector3 *Vector; // rax
		  __int64 v51; // xmm1_8
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int128 v55; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v57; // xmm0
		  __int64 v58; // xmm1_8
		  Bounds *result; // rax
		  Vector3 v60; // [rsp+30h] [rbp-D0h] BYREF
		  Vector3 v61; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 v62; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 v63; // [rsp+60h] [rbp-A0h] BYREF
		  Bounds v64; // [rsp+70h] [rbp-90h] BYREF
		  Bounds v65; // [rsp+90h] [rbp-70h] BYREF
		  Bounds v66; // [rsp+A8h] [rbp-58h] BYREF
		  Matrix4x4 v67; // [rsp+C0h] [rbp-40h] BYREF
		  Matrix4x4 v68[2]; // [rsp+100h] [rbp+0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1712, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1712, 0LL);
		    if ( Patch )
		    {
		      v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v65, Patch, (Object *)this, 0LL);
		      goto LABEL_13;
		    }
		    goto LABEL_11;
		  }
		  if ( !this->fields.data.shape )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      localScale = UnityEngine::Transform::get_localScale(&v61, transform, 0LL);
		      v27 = *(_QWORD *)&localScale->x;
		      z = localScale->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v60.x = v27;
		      v60.z = z;
		      v29 = HG::Rendering::Runtime::HGUtils::Abs(&v61, &v60, 0LL);
		      v30 = *(_QWORD *)&v29->x;
		      *(float *)&v29 = v29->z;
		      *(_QWORD *)&v60.x = v30;
		      LODWORD(v60.z) = (_DWORD)v29;
		      *(float *)&v30 = HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(&v60, 0LL);
		      v31 = HG::Rendering::Runtime::VectorSwizzleUtils::xxx(&v61, *(float *)&v30, 0LL);
		      v32 = *(_QWORD *)&v31->x;
		      v33 = v31->z;
		      v34 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v34 )
		      {
		        position = UnityEngine::Transform::get_position(&v61, v34, 0LL);
		        v36 = *(_QWORD *)&position->x;
		        v37 = position->z;
		        v38 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( v38 )
		        {
		          *(_QWORD *)&v60.x = v32;
		          v60.z = v33;
		          rotation = UnityEngine::Transform::get_rotation((Quaternion *)&v64, v38, 0LL);
		          *(_QWORD *)&v62.x = v36;
		          v62.z = v37;
		          *(Quaternion *)&v64.m_Center.x = *rotation;
		          v40 = UnityEngine::Matrix4x4::TRS(v68, &v62, (Quaternion *)&v64, &v60, 0LL);
		          one = UnityEngine::Vector3::get_one(&v61, v41);
		          memset(&v65, 0, sizeof(v65));
		          v43 = one->z;
		          *(_QWORD *)&v63.x = *(_QWORD *)&one->x;
		          v63.z = v43;
		          v45 = UnityEngine::Vector3::op_Multiply(&v61, 2.0, &v63, v44);
		          v46 = *(_QWORD *)&v45->x;
		          *(float *)&v45 = v45->z;
		          *(_QWORD *)&v63.x = v46;
		          LODWORD(v63.z) = (_DWORD)v45;
		          Vector = UnityEngine::Animator::GetVector(&v66.m_Center, v47, v48, v49);
		          v51 = *(_QWORD *)&Vector->x;
		          *(float *)&Vector = Vector->z;
		          *(_QWORD *)&v61.x = v51;
		          LODWORD(v61.z) = (_DWORD)Vector;
		          UnityEngine::Bounds::Bounds(&v65, &v61, &v63, 0LL);
		          *(_OWORD *)&v66.m_Center.x = *(_OWORD *)&v65.m_Center.x;
		          v52 = *(_OWORD *)&v40->m00;
		          *(_QWORD *)&v66.m_Extents.y = *(_QWORD *)&v65.m_Extents.y;
		          v53 = *(_OWORD *)&v40->m01;
		          *(_OWORD *)&v67.m00 = v52;
		          v54 = *(_OWORD *)&v40->m02;
		          *(_OWORD *)&v67.m01 = v53;
		          v55 = *(_OWORD *)&v40->m03;
		          *(_OWORD *)&v67.m02 = v54;
		          *(_OWORD *)&v67.m03 = v55;
		          goto LABEL_5;
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v18, v17);
		  }
		  v6 = UnityEngine::Vector3::get_one(&v61, v5);
		  memset(&v64, 0, sizeof(v64));
		  v7 = *(_QWORD *)&v6->x;
		  v62.z = v6->z;
		  *(_QWORD *)&v62.x = v7;
		  v9 = UnityEngine::Vector3::op_Multiply(&v61, 2.0, &v62, v8);
		  v10 = *(_QWORD *)&v9->x;
		  *(float *)&v9 = v9->z;
		  *(_QWORD *)&v62.x = v10;
		  LODWORD(v62.z) = (_DWORD)v9;
		  v14 = UnityEngine::Animator::GetVector(&v61, v11, v12, v13);
		  v15 = *(_QWORD *)&v14->x;
		  *(float *)&v14 = v14->z;
		  *(_QWORD *)&v60.x = v15;
		  LODWORD(v60.z) = (_DWORD)v14;
		  UnityEngine::Bounds::Bounds(&v64, &v60, &v62, 0LL);
		  v66 = v64;
		  v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v16 )
		    goto LABEL_11;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v67, v16, 0LL);
		  v20 = *(_OWORD *)&localToWorldMatrix->m00;
		  v21 = *(_OWORD *)&localToWorldMatrix->m01;
		  v22 = *(_OWORD *)&localToWorldMatrix->m02;
		  v23 = *(_OWORD *)&localToWorldMatrix->m03;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_OWORD *)&v67.m00 = v20;
		  *(_OWORD *)&v67.m01 = v21;
		  *(_OWORD *)&v67.m02 = v22;
		  *(_OWORD *)&v67.m03 = v23;
		LABEL_5:
		  v24 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v65, &v66, &v67, 0LL);
		LABEL_13:
		  v57 = *(_OWORD *)&v24->m_Center.x;
		  v58 = *(_QWORD *)&v24->m_Extents.y;
		  result = retstr;
		  *(_OWORD *)&retstr->m_Center.x = v57;
		  *(_QWORD *)&retstr->m_Extents.y = v58;
		  return result;
		}
		
		private void OnDrawGizmos() {} // 0x0000000189CF74CC-0x0000000189CF812C
		// Void OnDrawGizmos()
		void HG::Rendering::Runtime::HGWindMotor::OnDrawGizmos(HGWindMotor *this, MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Vector3 *position; // rax
		  float radius; // xmm1_4
		  __int64 v8; // xmm0_8
		  Transform *v9; // rax
		  Vector3 *v10; // rax
		  float rangeIn; // xmm1_4
		  __int64 v12; // xmm0_8
		  MethodInfo *v13; // rdx
		  Transform *v14; // rax
		  Vector3 *v15; // rax
		  float v16; // xmm1_4
		  __int64 v17; // xmm0_8
		  Transform *v18; // rax
		  Vector3 *v19; // rax
		  float v20; // xmm1_4
		  __int64 v21; // xmm0_8
		  Transform *v22; // rax
		  Vector3 *v23; // rax
		  float z; // r14d
		  __int64 v25; // xmm10_8
		  float v26; // xmm7_4
		  float v27; // xmm8_4
		  int v28; // esi
		  Transform *v29; // rax
		  Vector3 *forward; // rax
		  float v31; // ebx
		  __int64 v32; // xmm6_8
		  Matrix4x4 *v33; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  Vector3 *v37; // rax
		  MethodInfo *v38; // r9
		  __int64 v39; // xmm0_8
		  Vector3 *v40; // rax
		  float *v41; // r8
		  __int64 v42; // xmm0_8
		  __int64 v43; // xmm3_8
		  MethodInfo *v44; // r9
		  Vector3 *v45; // rax
		  __int64 v46; // xmm3_8
		  MethodInfo *v47; // r9
		  Vector3 *v48; // rax
		  __int64 v49; // xmm3_8
		  MethodInfo *v50; // r9
		  Vector3 *v51; // rax
		  Vector3 *v52; // r8
		  Vector3 *v53; // rdx
		  __int64 v54; // xmm3_8
		  Vector3 *v55; // rax
		  float *v56; // r8
		  __int64 v57; // xmm0_8
		  __int64 v58; // xmm3_8
		  MethodInfo *v59; // r9
		  Vector3 *v60; // rax
		  __int64 v61; // xmm3_8
		  MethodInfo *v62; // r9
		  Vector3 *v63; // rax
		  __int64 v64; // xmm3_8
		  MethodInfo *v65; // r9
		  Vector3 *v66; // rax
		  __int64 v67; // xmm3_8
		  Transform *v68; // rax
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v70; // xmm1
		  __int128 v71; // xmm0
		  __int128 v72; // xmm1
		  MethodInfo *v73; // rdx
		  float v74; // xmm1_4
		  Animator *v75; // rdx
		  int32_t v76; // r8d
		  MethodInfo *v77; // r9
		  Vector3 *Vector; // rax
		  __int64 v79; // xmm1_8
		  MethodInfo *v80; // rdx
		  Animator *v81; // rdx
		  int32_t v82; // r8d
		  MethodInfo *v83; // r9
		  Vector3 *v84; // rax
		  __int64 v85; // xmm1_8
		  Animator *v86; // rdx
		  int32_t v87; // r8d
		  MethodInfo *v88; // r9
		  Vector3 *v89; // rax
		  __int64 v90; // xmm1_8
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v92; // xmm1
		  __int128 v93; // xmm0
		  __int128 v94; // xmm1
		  Transform *v95; // rax
		  Vector3 *v96; // rax
		  __int64 v97; // xmm11_8
		  float v98; // r12d
		  Vector3 *Direction; // rax
		  __int64 v100; // xmm6_8
		  float v101; // ebx
		  Transform *v102; // rax
		  float v103; // xmm8_4
		  float v104; // xmm13_4
		  Transform *v105; // rax
		  float v106; // xmm7_4
		  Transform *v107; // rax
		  Vector3 *localScale; // rax
		  MethodInfo *v109; // r9
		  int v110; // esi
		  int v111; // r14d
		  unsigned __int64 v112; // xmm10_8
		  float v113; // xmm9_4
		  Vector3 *v114; // rax
		  __int64 v115; // xmm3_8
		  MethodInfo *v116; // r9
		  Vector3 *v117; // rax
		  __int64 v118; // xmm3_8
		  MethodInfo *v119; // r9
		  Vector3 *v120; // rax
		  __int64 v121; // xmm3_8
		  MethodInfo *v122; // r9
		  Vector3 *v123; // rax
		  __int64 v124; // xmm3_8
		  MethodInfo *v125; // r9
		  MethodInfo *v126; // r9
		  Vector3 *v127; // rax
		  __int64 v128; // r9
		  __int64 v129; // xmm3_8
		  Vector3 *v130; // rax
		  Vector3 *v131; // r8
		  Vector3 *v132; // rdx
		  __int64 v133; // xmm3_8
		  Vector3 *v134; // rax
		  __int64 v135; // r9
		  __int64 v136; // xmm3_8
		  Vector3 *v137; // rax
		  __int64 v138; // r9
		  __int64 v139; // xmm3_8
		  Vector3 *v140; // rax
		  __int64 v141; // xmm3_8
		  MethodInfo *v142; // r9
		  Vector3 *v143; // rax
		  __int64 v144; // xmm3_8
		  MethodInfo *v145; // r9
		  Vector3 *v146; // rax
		  __int64 v147; // xmm3_8
		  MethodInfo *v148; // r9
		  Vector3 *v149; // rax
		  __int64 v150; // xmm3_8
		  MethodInfo *v151; // r9
		  MethodInfo *v152; // r9
		  Vector3 *v153; // rax
		  __int64 v154; // r9
		  __int64 v155; // xmm3_8
		  Vector3 *v156; // rax
		  Vector3 *v157; // r8
		  Vector3 *v158; // rdx
		  __int64 v159; // xmm3_8
		  Vector3 *v160; // rax
		  __int64 v161; // r9
		  __int64 v162; // xmm3_8
		  Vector3 *v163; // rax
		  __int64 v164; // r9
		  __int64 v165; // xmm3_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v167; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v168; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v169; // [rsp+58h] [rbp-B0h] BYREF
		  Color si128; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v171; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v172; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v173; // [rsp+98h] [rbp-70h] BYREF
		  Vector3 v174; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v175; // [rsp+B8h] [rbp-50h] BYREF
		  Vector3 v176; // [rsp+C8h] [rbp-40h] BYREF
		  Vector3 v177; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v178; // [rsp+E8h] [rbp-20h] BYREF
		  Vector3 v179; // [rsp+F8h] [rbp-10h] BYREF
		  Vector3 v180; // [rsp+108h] [rbp+0h] BYREF
		  Vector3 v181; // [rsp+118h] [rbp+10h] BYREF
		  Vector3 v182; // [rsp+128h] [rbp+20h] BYREF
		  Vector3 v183; // [rsp+138h] [rbp+30h] BYREF
		  Vector3 v184; // [rsp+148h] [rbp+40h] BYREF
		  Color v185; // [rsp+158h] [rbp+50h] BYREF
		  Vector3 v186; // [rsp+168h] [rbp+60h] BYREF
		  Vector3 v187; // [rsp+178h] [rbp+70h] BYREF
		  Vector3 v188; // [rsp+188h] [rbp+80h] BYREF
		  Vector3 v189; // [rsp+198h] [rbp+90h] BYREF
		  Vector3 v190; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector3 v191; // [rsp+1B8h] [rbp+B0h] BYREF
		  Vector3 v192; // [rsp+1C8h] [rbp+C0h] BYREF
		  Vector3 v193; // [rsp+1D8h] [rbp+D0h] BYREF
		  Matrix4x4 v194; // [rsp+1E8h] [rbp+E0h] BYREF
		  Color v195; // [rsp+228h] [rbp+120h] BYREF
		  Vector3 v196; // [rsp+238h] [rbp+130h] BYREF
		  Matrix4x4 v197[3]; // [rsp+248h] [rbp+140h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1715, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1715, 0LL);
		    if ( !Patch )
		      goto LABEL_37;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.data.shape )
		    {
		      si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18DC81280);
		      UnityEngine::Gizmos::set_color(&si128, 0LL);
		      transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( transform )
		      {
		        position = UnityEngine::Transform::get_position(&v167, transform, 0LL);
		        radius = this->fields.data.radius;
		        v8 = *(_QWORD *)&position->x;
		        *(float *)&position = position->z;
		        *(_QWORD *)&v169.x = v8;
		        LODWORD(v169.z) = (_DWORD)position;
		        UnityEngine::Gizmos::DrawSphere(&v169, radius, 0LL);
		        v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( v9 )
		        {
		          v10 = UnityEngine::Transform::get_position(&v167, v9, 0LL);
		          rangeIn = this->fields.data.rangeIn;
		          v12 = *(_QWORD *)&v10->x;
		          *(float *)&v10 = v10->z;
		          *(_QWORD *)&v169.x = v12;
		          LODWORD(v169.z) = (_DWORD)v10;
		          UnityEngine::Gizmos::DrawSphere(&v169, rangeIn, 0LL);
		          si128 = *UnityEngine::Color::get_cyan(&v185, v13);
		          UnityEngine::Gizmos::set_color(&si128, 0LL);
		          v14 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		          if ( v14 )
		          {
		            v15 = UnityEngine::Transform::get_position(&v167, v14, 0LL);
		            v16 = this->fields.data.radius;
		            v17 = *(_QWORD *)&v15->x;
		            *(float *)&v15 = v15->z;
		            *(_QWORD *)&v169.x = v17;
		            LODWORD(v169.z) = (_DWORD)v15;
		            UnityEngine::Gizmos::DrawWireSphere(&v169, v16, 0LL);
		            v18 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		            if ( v18 )
		            {
		              v19 = UnityEngine::Transform::get_position(&v167, v18, 0LL);
		              v20 = this->fields.data.rangeIn;
		              v21 = *(_QWORD *)&v19->x;
		              *(float *)&v19 = v19->z;
		              *(_QWORD *)&v169.x = v21;
		              LODWORD(v169.z) = (_DWORD)v19;
		              UnityEngine::Gizmos::DrawWireSphere(&v169, v20, 0LL);
		              v22 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		              if ( v22 )
		              {
		                v23 = UnityEngine::Transform::get_position(&v167, v22, 0LL);
		                z = v23->z;
		                v25 = *(_QWORD *)&v23->x;
		                v26 = this->fields.data.radius * 0.80000001;
		                v27 = this->fields.data.radius * 0.2;
		                v28 = 0;
		                while ( 1 )
		                {
		                  v29 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                  if ( !v29 )
		                    break;
		                  forward = UnityEngine::Transform::get_forward(&v196, v29, 0LL);
		                  v31 = forward->z;
		                  v32 = *(_QWORD *)&forward->x;
		                  v185 = *(Color *)sub_182FA5990(&v195);
		                  v33 = UnityEngine::Matrix4x4::Rotate(v197, (Quaternion *)&v185, 0LL);
		                  *(_QWORD *)&v169.x = v32;
		                  v169.z = v31;
		                  v34 = *(_OWORD *)&v33->m01;
		                  *(_OWORD *)&v194.m00 = *(_OWORD *)&v33->m00;
		                  v35 = *(_OWORD *)&v33->m02;
		                  *(_OWORD *)&v194.m01 = v34;
		                  v36 = *(_OWORD *)&v33->m03;
		                  *(_OWORD *)&v194.m02 = v35;
		                  *(_OWORD *)&v194.m03 = v36;
		                  v37 = UnityEngine::Matrix4x4::MultiplyVector(&v186, &v194, &v169, 0LL);
		                  v39 = *(_QWORD *)&v37->x;
		                  if ( this->fields.data.focus )
		                  {
		                    v171.z = v37->z;
		                    *(_QWORD *)&v171.x = v39;
		                    v40 = UnityEngine::Vector3::op_Multiply(&v187, &v171, v26, v38);
		                    v42 = *(_QWORD *)v41;
		                    *(_QWORD *)&v176.x = v25;
		                    v176.z = z;
		                    v43 = *(_QWORD *)&v40->x;
		                    v175.z = v40->z;
		                    v172.z = v41[2];
		                    *(_QWORD *)&v175.x = v43;
		                    *(_QWORD *)&v172.x = v42;
		                    v45 = UnityEngine::Vector3::op_Multiply(&v188, &v172, v27, v44);
		                    *(_QWORD *)&v174.x = v25;
		                    v174.z = z;
		                    v46 = *(_QWORD *)&v45->x;
		                    *(float *)&v45 = v45->z;
		                    *(_QWORD *)&v173.x = v46;
		                    LODWORD(v173.z) = (_DWORD)v45;
		                    v48 = UnityEngine::Vector3::op_Addition(&v189, &v174, &v173, v47);
		                    v49 = *(_QWORD *)&v48->x;
		                    *(float *)&v48 = v48->z;
		                    *(_QWORD *)&v177.x = v49;
		                    LODWORD(v177.z) = (_DWORD)v48;
		                    v51 = UnityEngine::Vector3::op_Addition(&v190, &v176, &v175, v50);
		                    v52 = &v177;
		                    v53 = &v178;
		                    v54 = *(_QWORD *)&v51->x;
		                    *(float *)&v51 = v51->z;
		                    *(_QWORD *)&v178.x = v54;
		                    LODWORD(v178.z) = (_DWORD)v51;
		                  }
		                  else
		                  {
		                    v179.z = v37->z;
		                    *(_QWORD *)&v179.x = v39;
		                    v55 = UnityEngine::Vector3::op_Multiply(&v191, &v179, v27, v38);
		                    v57 = *(_QWORD *)v56;
		                    *(_QWORD *)&v184.x = v25;
		                    v184.z = z;
		                    v58 = *(_QWORD *)&v55->x;
		                    v183.z = v55->z;
		                    v180.z = v56[2];
		                    *(_QWORD *)&v183.x = v58;
		                    *(_QWORD *)&v180.x = v57;
		                    v60 = UnityEngine::Vector3::op_Multiply(&v192, &v180, v26, v59);
		                    *(_QWORD *)&v182.x = v25;
		                    v182.z = z;
		                    v61 = *(_QWORD *)&v60->x;
		                    *(float *)&v60 = v60->z;
		                    *(_QWORD *)&v181.x = v61;
		                    LODWORD(v181.z) = (_DWORD)v60;
		                    v63 = UnityEngine::Vector3::op_Addition(&v193, &v182, &v181, v62);
		                    v64 = *(_QWORD *)&v63->x;
		                    *(float *)&v63 = v63->z;
		                    *(_QWORD *)&v168.x = v64;
		                    LODWORD(v168.z) = (_DWORD)v63;
		                    v66 = UnityEngine::Vector3::op_Addition((Vector3 *)&si128, &v184, &v183, v65);
		                    v52 = &v168;
		                    v53 = &v167;
		                    v67 = *(_QWORD *)&v66->x;
		                    *(float *)&v66 = v66->z;
		                    *(_QWORD *)&v167.x = v67;
		                    LODWORD(v167.z) = (_DWORD)v66;
		                  }
		                  HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v53, v52, 0LL);
		                  if ( ++v28 >= 6 )
		                    return;
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_37:
		      sub_1800D8260(v5, v4);
		    }
		    if ( this->fields.data.shape == 1 )
		    {
		      v68 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v68 )
		        goto LABEL_37;
		      localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v197, v68, 0LL);
		      v70 = *(_OWORD *)&localToWorldMatrix->m01;
		      *(_OWORD *)&v194.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		      v71 = *(_OWORD *)&localToWorldMatrix->m02;
		      *(_OWORD *)&v194.m01 = v70;
		      v72 = *(_OWORD *)&localToWorldMatrix->m03;
		      *(_OWORD *)&v194.m02 = v71;
		      *(_OWORD *)&v194.m03 = v72;
		      UnityEngine::Gizmos::set_matrix(&v194, 0LL);
		      v185 = (Color)_mm_load_si128((const __m128i *)&xmmword_18DC81280);
		      if ( this->fields.data.rectBackward )
		      {
		        UnityEngine::Gizmos::set_color(&v185, 0LL);
		        v167.z = 2.0;
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        Vector = UnityEngine::Animator::GetVector((Vector3 *)&si128, v75, v76, v77);
		        v79 = *(_QWORD *)&Vector->x;
		        *(float *)&Vector = Vector->z;
		        *(_QWORD *)&v168.x = v79;
		        LODWORD(v168.z) = (_DWORD)Vector;
		        UnityEngine::Gizmos::DrawCube(&v168, &v167, 0LL);
		        v185 = *UnityEngine::Color::get_cyan(&v195, v80);
		        UnityEngine::Gizmos::set_color(&v185, 0LL);
		        v167.z = 2.0;
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        v84 = UnityEngine::Animator::GetVector((Vector3 *)&si128, v81, v82, v83);
		        v85 = *(_QWORD *)&v84->x;
		        *(float *)&v84 = v84->z;
		        *(_QWORD *)&v168.x = v85;
		        LODWORD(v168.z) = (_DWORD)v84;
		        UnityEngine::Gizmos::DrawWireCube(&v168, &v167, 0LL);
		        *(float *)&v85 = this->fields.data.rangeIn + this->fields.data.rangeIn;
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        LODWORD(v167.z) = v85;
		        v89 = UnityEngine::Animator::GetVector((Vector3 *)&si128, v86, v87, v88);
		        v90 = *(_QWORD *)&v89->x;
		        *(float *)&v89 = v89->z;
		        *(_QWORD *)&v168.x = v90;
		        LODWORD(v168.z) = (_DWORD)v89;
		      }
		      else
		      {
		        UnityEngine::Gizmos::set_color(&v185, 0LL);
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        *(_QWORD *)&v168.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        v167.z = 1.0;
		        v168.z = 0.5;
		        UnityEngine::Gizmos::DrawCube(&v168, &v167, 0LL);
		        v185 = *UnityEngine::Color::get_cyan(&v195, v73);
		        UnityEngine::Gizmos::set_color(&v185, 0LL);
		        v167.z = 1.0;
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        v168.z = 0.5;
		        *(_QWORD *)&v168.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        UnityEngine::Gizmos::DrawWireCube(&v168, &v167, 0LL);
		        v74 = this->fields.data.rangeIn;
		        *(_QWORD *)&v167.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
		        *(_QWORD *)&v168.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        v168.z = v74 * 0.5;
		        v167.z = v74;
		      }
		      UnityEngine::Gizmos::DrawWireCube(&v168, &v167, 0LL);
		      static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v92 = *(_OWORD *)&static_fields->identityMatrix.m01;
		      *(_OWORD *)&v194.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		      v93 = *(_OWORD *)&static_fields->identityMatrix.m02;
		      *(_OWORD *)&v194.m01 = v92;
		      v94 = *(_OWORD *)&static_fields->identityMatrix.m03;
		      *(_OWORD *)&v194.m02 = v93;
		      *(_OWORD *)&v194.m03 = v94;
		      UnityEngine::Gizmos::set_matrix(&v194, 0LL);
		      v95 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v95 )
		        goto LABEL_37;
		      v96 = UnityEngine::Transform::get_position((Vector3 *)&si128, v95, 0LL);
		      v97 = *(_QWORD *)&v96->x;
		      v98 = v96->z;
		      Direction = HG::Rendering::Runtime::HGWindMotor::GetDirection((Vector3 *)&si128, this, 0LL);
		      v100 = *(_QWORD *)&Direction->x;
		      v101 = Direction->z;
		      *(_QWORD *)&v167.x = *(_QWORD *)&Direction->x;
		      v102 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v102 )
		        goto LABEL_37;
		      UnityEngine::Transform::get_forward((Vector3 *)&si128, v102, 0LL);
		      v103 = -v167.x;
		      v104 = this->fields.data.rangeIn;
		      v105 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v105 )
		        goto LABEL_37;
		      v106 = UnityEngine::Transform::get_localScale((Vector3 *)&si128, v105, 0LL)->z - this->fields.data.rangeIn;
		      v107 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v107 )
		        goto LABEL_37;
		      localScale = UnityEngine::Transform::get_localScale((Vector3 *)&si128, v107, 0LL);
		      v110 = -1;
		      v111 = -1;
		      v167.z = v103;
		      v112 = _mm_unpacklo_ps((__m128)_mm_cvtsi32_si128(LODWORD(v101)), (__m128)0LL).m128_u64[0];
		      v113 = localScale->x * 0.40000001;
		      v182.z = v98;
		      *(_QWORD *)&v167.x = v112;
		      *(_QWORD *)&v182.x = v97;
		      *(_QWORD *)&v184.x = v100;
		      v184.z = v101;
		      do
		      {
		        v114 = UnityEngine::Vector3::op_Multiply((Vector3 *)&si128, &v167, (float)v111, v109);
		        v115 = *(_QWORD *)&v114->x;
		        *(float *)&v114 = v114->z;
		        *(_QWORD *)&v168.x = v115;
		        LODWORD(v168.z) = (_DWORD)v114;
		        v117 = UnityEngine::Vector3::op_Multiply(&v193, &v168, v113, v116);
		        v118 = *(_QWORD *)&v117->x;
		        *(float *)&v117 = v117->z;
		        *(_QWORD *)&v183.x = v118;
		        LODWORD(v183.z) = (_DWORD)v117;
		        v120 = UnityEngine::Vector3::op_Multiply(&v192, &v184, v104, v119);
		        v121 = *(_QWORD *)&v120->x;
		        *(float *)&v120 = v120->z;
		        *(_QWORD *)&v181.x = v121;
		        LODWORD(v181.z) = (_DWORD)v120;
		        v123 = UnityEngine::Vector3::op_Addition(&v191, &v182, &v183, v122);
		        v124 = *(_QWORD *)&v123->x;
		        *(float *)&v123 = v123->z;
		        *(_QWORD *)&v180.x = v124;
		        LODWORD(v180.z) = (_DWORD)v123;
		        v126 = (MethodInfo *)UnityEngine::Vector3::op_Addition(&v190, &v180, &v181, v125);
		        if ( this->fields.data.focus )
		        {
		          *(_QWORD *)&v179.x = v100;
		          v179.z = v101;
		          v127 = UnityEngine::Vector3::op_Multiply(&v189, &v179, v106, v126);
		          *(_QWORD *)&v177.x = *(_QWORD *)v128;
		          *(_QWORD *)&v176.x = *(_QWORD *)&v177.x;
		          v129 = *(_QWORD *)&v127->x;
		          v178.z = v127->z;
		          v177.z = *(float *)(v128 + 8);
		          v176.z = v177.z;
		          *(_QWORD *)&v178.x = v129;
		          v130 = UnityEngine::Vector3::op_Addition(&v188, &v177, &v178, (MethodInfo *)v128);
		          v131 = &v176;
		          v132 = &v175;
		          v133 = *(_QWORD *)&v130->x;
		          *(float *)&v130 = v130->z;
		          *(_QWORD *)&v175.x = v133;
		          LODWORD(v175.z) = (_DWORD)v130;
		        }
		        else
		        {
		          *(_QWORD *)&v174.x = v100;
		          v174.z = v101;
		          v134 = UnityEngine::Vector3::op_Multiply(&v187, &v174, v106, v126);
		          *(_QWORD *)&v172.x = *(_QWORD *)v135;
		          v136 = *(_QWORD *)&v134->x;
		          v173.z = v134->z;
		          v172.z = *(float *)(v135 + 8);
		          *(_QWORD *)&v173.x = v136;
		          v137 = UnityEngine::Vector3::op_Addition(&v186, &v172, &v173, (MethodInfo *)v135);
		          v131 = &v171;
		          *(_QWORD *)&v169.x = *(_QWORD *)v138;
		          v132 = &v169;
		          v139 = *(_QWORD *)&v137->x;
		          v171.z = v137->z;
		          v169.z = *(float *)(v138 + 8);
		          *(_QWORD *)&v171.x = v139;
		        }
		        HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v132, v131, 0LL);
		        ++v111;
		      }
		      while ( v111 <= 1 );
		      if ( this->fields.data.rectBackward )
		      {
		        v167.z = v103;
		        *(_QWORD *)&v167.x = v112;
		        *(_QWORD *)&v182.x = v97;
		        v182.z = v98;
		        *(_QWORD *)&v184.x = v100;
		        v184.z = v101;
		        do
		        {
		          v140 = UnityEngine::Vector3::op_Multiply((Vector3 *)&si128, &v167, (float)v110, v109);
		          v141 = *(_QWORD *)&v140->x;
		          *(float *)&v140 = v140->z;
		          *(_QWORD *)&v168.x = v141;
		          LODWORD(v168.z) = (_DWORD)v140;
		          v143 = UnityEngine::Vector3::op_Multiply(&v193, &v168, v113, v142);
		          v144 = *(_QWORD *)&v143->x;
		          *(float *)&v143 = v143->z;
		          *(_QWORD *)&v183.x = v144;
		          LODWORD(v183.z) = (_DWORD)v143;
		          v146 = UnityEngine::Vector3::op_Multiply(&v192, &v184, v104, v145);
		          v147 = *(_QWORD *)&v146->x;
		          *(float *)&v146 = v146->z;
		          *(_QWORD *)&v181.x = v147;
		          LODWORD(v181.z) = (_DWORD)v146;
		          v149 = UnityEngine::Vector3::op_Addition(&v191, &v182, &v183, v148);
		          v150 = *(_QWORD *)&v149->x;
		          *(float *)&v149 = v149->z;
		          *(_QWORD *)&v180.x = v150;
		          LODWORD(v180.z) = (_DWORD)v149;
		          v152 = (MethodInfo *)UnityEngine::Vector3::op_Subtraction(&v190, &v180, &v181, v151);
		          if ( this->fields.data.focus )
		          {
		            *(_QWORD *)&v179.x = v100;
		            v179.z = v101;
		            v153 = UnityEngine::Vector3::op_Multiply(&v189, &v179, v106, v152);
		            *(_QWORD *)&v177.x = *(_QWORD *)v154;
		            *(_QWORD *)&v176.x = *(_QWORD *)&v177.x;
		            v155 = *(_QWORD *)&v153->x;
		            v178.z = v153->z;
		            v177.z = *(float *)(v154 + 8);
		            v176.z = v177.z;
		            *(_QWORD *)&v178.x = v155;
		            v156 = UnityEngine::Vector3::op_Subtraction(&v188, &v177, &v178, (MethodInfo *)v154);
		            v157 = &v176;
		            v158 = &v175;
		            v159 = *(_QWORD *)&v156->x;
		            *(float *)&v156 = v156->z;
		            *(_QWORD *)&v175.x = v159;
		            LODWORD(v175.z) = (_DWORD)v156;
		          }
		          else
		          {
		            *(_QWORD *)&v174.x = v100;
		            v174.z = v101;
		            v160 = UnityEngine::Vector3::op_Multiply(&v187, &v174, v106, v152);
		            *(_QWORD *)&v172.x = *(_QWORD *)v161;
		            v162 = *(_QWORD *)&v160->x;
		            v173.z = v160->z;
		            v172.z = *(float *)(v161 + 8);
		            *(_QWORD *)&v173.x = v162;
		            v163 = UnityEngine::Vector3::op_Subtraction(&v186, &v172, &v173, (MethodInfo *)v161);
		            v157 = &v171;
		            *(_QWORD *)&v169.x = *(_QWORD *)v164;
		            v158 = &v169;
		            v165 = *(_QWORD *)&v163->x;
		            v171.z = v163->z;
		            v169.z = *(float *)(v164 + 8);
		            *(_QWORD *)&v171.x = v165;
		          }
		          HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v158, v157, 0LL);
		          ++v110;
		        }
		        while ( v110 <= 1 );
		      }
		    }
		  }
		}
		
		private void _DrawArrow(Vector3 from, Vector3 to) {} // 0x0000000189CF812C-0x0000000189CF8414
		// Void _DrawArrow(Vector3, Vector3)
		void HG::Rendering::Runtime::HGWindMotor::_DrawArrow(HGWindMotor *this, Vector3 *from, Vector3 *to, MethodInfo *method)
		{
		  float v7; // eax
		  __int64 v8; // xmm0_8
		  float v9; // eax
		  float v10; // eax
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  __int64 v15; // xmm9_8
		  float v16; // edi
		  MethodInfo *v17; // r9
		  Vector3 *v18; // rax
		  __int64 v19; // xmm8_8
		  float v20; // ebx
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  __int64 v23; // xmm0_8
		  __int64 v24; // xmm3_8
		  MethodInfo *v25; // r9
		  Vector3 *v26; // rax
		  __int64 v27; // xmm3_8
		  MethodInfo *v28; // r9
		  Vector3 *v29; // rax
		  __int64 v30; // xmm3_8
		  MethodInfo *v31; // r9
		  Vector3 *v32; // rax
		  __int64 v33; // xmm0_8
		  __int64 v34; // xmm3_8
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  __int64 v37; // xmm3_8
		  MethodInfo *v38; // r9
		  Vector3 *v39; // rax
		  __int64 v40; // xmm3_8
		  MethodInfo *v41; // r9
		  Vector3 *v42; // rax
		  __int64 v43; // xmm3_8
		  MethodInfo *v44; // r9
		  Vector3 *v45; // rax
		  __int64 v46; // xmm3_8
		  __int64 v47; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  __int64 v50; // xmm0_8
		  float v51; // eax
		  Vector3 v52; // [rsp+38h] [rbp-9h] BYREF
		  Vector3 v53; // [rsp+48h] [rbp+7h] BYREF
		  Vector3 v54; // [rsp+58h] [rbp+17h] BYREF
		  Vector3 v55[4]; // [rsp+68h] [rbp+27h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1716, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1716, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v47);
		    z = to->z;
		    *(_QWORD *)&v54.x = *(_QWORD *)&to->x;
		    v50 = *(_QWORD *)&from->x;
		    v54.z = z;
		    v51 = from->z;
		    *(_QWORD *)&v53.x = v50;
		    v53.z = v51;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_687(Patch, (Object *)this, &v53, &v54, 0LL);
		  }
		  else
		  {
		    v7 = to->z;
		    *(_QWORD *)&v52.x = *(_QWORD *)&to->x;
		    v8 = *(_QWORD *)&from->x;
		    v52.z = v7;
		    v9 = from->z;
		    *(_QWORD *)&v53.x = v8;
		    v53.z = v9;
		    UnityEngine::Gizmos::DrawLine(&v53, &v52, 0LL);
		    v10 = from->z;
		    *(_QWORD *)&v53.x = *(_QWORD *)&from->x;
		    v11 = *(_QWORD *)&to->x;
		    v53.z = v10;
		    v12 = to->z;
		    *(_QWORD *)&v52.x = v11;
		    v52.z = v12;
		    v14 = UnityEngine::Vector3::op_Subtraction(&v54, &v52, &v53, v13);
		    v16 = v14->z;
		    *(_QWORD *)&v52.x = *(_QWORD *)&v14->x;
		    v15 = *(_QWORD *)&v52.x;
		    v53.z = 0.0;
		    *(_QWORD *)&v53.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v52.z = v16;
		    v18 = UnityEngine::Vector3::Cross(v55, &v52, &v53, v17);
		    *(_QWORD *)&v53.x = v15;
		    v53.z = v16;
		    v19 = *(_QWORD *)&v18->x;
		    v20 = v18->z;
		    v22 = UnityEngine::Vector3::op_Multiply(&v54, &v53, 0.2, v21);
		    v23 = *(_QWORD *)&to->x;
		    *(_QWORD *)&v53.x = v19;
		    v24 = *(_QWORD *)&v22->x;
		    v52.z = v22->z;
		    v54.z = to->z;
		    *(_QWORD *)&v52.x = v24;
		    *(_QWORD *)&v54.x = v23;
		    v53.z = v20;
		    v26 = UnityEngine::Vector3::op_Multiply(v55, &v53, 0.15000001, v25);
		    v27 = *(_QWORD *)&v26->x;
		    *(float *)&v26 = v26->z;
		    *(_QWORD *)&v53.x = v27;
		    LODWORD(v53.z) = (_DWORD)v26;
		    v29 = UnityEngine::Vector3::op_Subtraction(v55, &v54, &v52, v28);
		    v30 = *(_QWORD *)&v29->x;
		    *(float *)&v29 = v29->z;
		    *(_QWORD *)&v54.x = v30;
		    LODWORD(v54.z) = (_DWORD)v29;
		    v32 = UnityEngine::Vector3::op_Addition(v55, &v54, &v53, v31);
		    v33 = *(_QWORD *)&to->x;
		    v34 = *(_QWORD *)&v32->x;
		    *(float *)&v32 = v32->z;
		    *(_QWORD *)&v54.x = v34;
		    LODWORD(v54.z) = (_DWORD)v32;
		    v53.z = to->z;
		    *(_QWORD *)&v53.x = v33;
		    UnityEngine::Gizmos::DrawLine(&v53, &v54, 0LL);
		    *(_QWORD *)&v54.x = v15;
		    v54.z = v16;
		    v36 = UnityEngine::Vector3::op_Multiply(v55, &v54, 0.2, v35);
		    *(_QWORD *)&v52.x = *(_QWORD *)&to->x;
		    v37 = *(_QWORD *)&v36->x;
		    v53.z = v36->z;
		    v52.z = to->z;
		    *(_QWORD *)&v53.x = v37;
		    *(_QWORD *)&v54.x = v19;
		    v54.z = v20;
		    v39 = UnityEngine::Vector3::op_Multiply(v55, &v54, 0.15000001, v38);
		    v40 = *(_QWORD *)&v39->x;
		    *(float *)&v39 = v39->z;
		    *(_QWORD *)&v54.x = v40;
		    LODWORD(v54.z) = (_DWORD)v39;
		    v42 = UnityEngine::Vector3::op_Subtraction(v55, &v52, &v53, v41);
		    v43 = *(_QWORD *)&v42->x;
		    *(float *)&v42 = v42->z;
		    *(_QWORD *)&v53.x = v43;
		    LODWORD(v53.z) = (_DWORD)v42;
		    v45 = UnityEngine::Vector3::op_Subtraction(v55, &v53, &v54, v44);
		    *(_QWORD *)&v53.x = *(_QWORD *)&to->x;
		    v46 = *(_QWORD *)&v45->x;
		    v54.z = v45->z;
		    v53.z = to->z;
		    *(_QWORD *)&v54.x = v46;
		    UnityEngine::Gizmos::DrawLine(&v53, &v54, 0LL);
		  }
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000186FE0B3C-0x0000000186FE0B44
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
