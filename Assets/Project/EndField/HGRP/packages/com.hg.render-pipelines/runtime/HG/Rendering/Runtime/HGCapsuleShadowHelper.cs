using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGCapsuleShadowHelper : MonoBehaviour, IHGInteractionObject // TypeDefIndex: 38681
	{
		// Fields
		public List<HGCapsuleShadowContainer> m_capsuleShadowContainers; // 0x18
		[Range(0f, 5f)]
		public float m_intensity; // 0x20
		[HideInInspector]
		public int m_editCapsuleIndex; // 0x24
		public float m_ditherAlpha; // 0x28
		[Min(0.05f)]
		public float m_feetSize; // 0x2C
		[Range(-0.1f, 0.1f)]
		public float m_feetBaseTransformOffset; // 0x30
		[Range(-0.1f, 0.1f)]
		public float m_feetTargetTransformOffset; // 0x34
		public bool m_interactionOnly; // 0x38
		public bool m_enableCCD; // 0x39
		public float m_radiusScale; // 0x3C
		public float m_heightScale; // 0x40
		public Vector3 m_centerOffset; // 0x44
		private List<Matrix4x4> m_cachedCapsuleTransforms; // 0x50
		public string m_skeletonName_Hip_R; // 0x58
		public string m_skeletonName_Hip_L; // 0x60
		public string m_skeletonName_Knee_R; // 0x68
		public string m_skeletonName_Knee_L; // 0x70
		public string m_skeletonName_Ankle_R; // 0x78
		public string m_skeletonName_Ankle_L; // 0x80
		public string m_skeletonName_ToesEnd_R; // 0x88
		public string m_skeletonName_ToesEnd_L; // 0x90
		public string m_skeletonName_Shoulder_R; // 0x98
		public string m_skeletonName_Shoulder_L; // 0xA0
		public string m_skeletonName_Wrist_R; // 0xA8
		public string m_skeletonName_Wrist_L; // 0xB0
		public string m_skeletonName_Trunk; // 0xB8
		public string m_skeletonName_Head; // 0xC0
	
		// Constructors
		public HGCapsuleShadowHelper() {} // 0x00000001843D5FD0-0x00000001843D6220
		// HGCapsuleShadowHelper()
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::HGCapsuleShadowHelper(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  LowLevelList_1_System_Object_ *v10; // rax
		  List_1_UnityEngine_Matrix4x4_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Type *v35; // rdx
		  PropertyInfo_1 *v36; // r8
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Type *v39; // rdx
		  PropertyInfo_1 *v40; // r8
		  Type *v41; // rdx
		  PropertyInfo_1 *v42; // r8
		  MethodInfo *v43; // [rsp+20h] [rbp-8h]
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+20h] [rbp-8h]
		  MethodInfo *v48; // [rsp+20h] [rbp-8h]
		  MethodInfo *v49; // [rsp+20h] [rbp-8h]
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+20h] [rbp-8h]
		  MethodInfo *v55; // [rsp+20h] [rbp-8h]
		  MethodInfo *v56; // [rsp+20h] [rbp-8h]
		  MethodInfo *v57; // [rsp+20h] [rbp-8h]
		  MethodInfo *v58; // [rsp+20h] [rbp-8h]
		
		  v3 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>);
		  v6 = (List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *)v3;
		  if ( !v3 )
		    goto LABEL_5;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::List);
		  this->fields.m_capsuleShadowContainers = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_capsuleShadowContainers, v7, v8, v9, v43);
		  this->fields.m_intensity = 2.0;
		  this->fields.m_editCapsuleIndex = -1;
		  this->fields.m_ditherAlpha = 1.0;
		  this->fields.m_feetSize = 0.050000001;
		  this->fields.m_feetBaseTransformOffset = -0.090000004;
		  this->fields.m_feetTargetTransformOffset = 0.085000001;
		  this->fields.m_enableCCD = 1;
		  this->fields.m_radiusScale = 1.0;
		  this->fields.m_heightScale = 1.0;
		  *(_QWORD *)&this->fields.m_centerOffset.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_centerOffset.z = 0.0;
		  v10 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>);
		  v11 = (List_1_UnityEngine_Matrix4x4_ *)v10;
		  if ( !v10 )
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v10,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::List);
		  this->fields.m_cachedCapsuleTransforms = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_cachedCapsuleTransforms, v12, v13, v14, v44);
		  this->fields.m_skeletonName_Hip_R = (String *)"Bip001_R_Thigh";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Hip_R,
		    v15,
		    v16,
		    (Int32__Array **)"Bip001_R_Thigh",
		    v45);
		  this->fields.m_skeletonName_Hip_L = (String *)"Bip001_L_Thigh";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Hip_L,
		    v17,
		    v18,
		    (Int32__Array **)"Bip001_L_Thigh",
		    v46);
		  this->fields.m_skeletonName_Knee_R = (String *)"Bip001_R_Calf";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Knee_R,
		    v19,
		    v20,
		    (Int32__Array **)"Bip001_R_Calf",
		    v47);
		  this->fields.m_skeletonName_Knee_L = (String *)"Bip001_L_Calf";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Knee_L,
		    v21,
		    v22,
		    (Int32__Array **)"Bip001_L_Calf",
		    v48);
		  this->fields.m_skeletonName_Ankle_R = (String *)"Bip001_R_Foot";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Ankle_R,
		    v23,
		    v24,
		    (Int32__Array **)"Bip001_R_Foot",
		    v49);
		  this->fields.m_skeletonName_Ankle_L = (String *)"Bip001_L_Foot";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Ankle_L,
		    v25,
		    v26,
		    (Int32__Array **)"Bip001_L_Foot",
		    v50);
		  this->fields.m_skeletonName_ToesEnd_R = (String *)"Bip001_R_Toe0";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_ToesEnd_R,
		    v27,
		    v28,
		    (Int32__Array **)"Bip001_R_Toe0",
		    v51);
		  this->fields.m_skeletonName_ToesEnd_L = (String *)"Bip001_L_Toe0";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_ToesEnd_L,
		    v29,
		    v30,
		    (Int32__Array **)"Bip001_L_Toe0",
		    v52);
		  this->fields.m_skeletonName_Shoulder_R = (String *)"Bip001_R_UpperArm";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Shoulder_R,
		    v31,
		    v32,
		    (Int32__Array **)"Bip001_R_UpperArm",
		    v53);
		  this->fields.m_skeletonName_Shoulder_L = (String *)"Bip001_L_UpperArm";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Shoulder_L,
		    v33,
		    v34,
		    (Int32__Array **)"Bip001_L_UpperArm",
		    v54);
		  this->fields.m_skeletonName_Wrist_R = (String *)"Bip001_R_Hand";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Wrist_R,
		    v35,
		    v36,
		    (Int32__Array **)"Bip001_R_Hand",
		    v55);
		  this->fields.m_skeletonName_Wrist_L = (String *)"Bip001_L_Hand";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Wrist_L,
		    v37,
		    v38,
		    (Int32__Array **)"Bip001_L_Hand",
		    v56);
		  this->fields.m_skeletonName_Trunk = (String *)"Bip001_Spine1";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_skeletonName_Trunk,
		    v39,
		    v40,
		    (Int32__Array **)"Bip001_Spine1",
		    v57);
		  this->fields.m_skeletonName_Head = (String *)"Bip001_Head";
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_skeletonName_Head, v41, v42, (Int32__Array **)"Bip001_Head", v58);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private Matrix4x4 GetLocalMatrix(HGCapsuleShadowContainer container) => default; // 0x0000000182FA4D70-0x0000000182FA4F30
		// Matrix4x4 GetLocalMatrix(HGCapsuleShadowContainer)
		Matrix4x4 *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetLocalMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __m128i v9; // xmm6
		  Vector3 *v10; // rax
		  __int64 v11; // xmm3_8
		  void (__fastcall *v12)(Vector3 *, __int128 *); // rax
		  void (__fastcall *v13)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *); // rax
		  Matrix4x4 *result; // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  Matrix4x4 *v21; // rax
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int64 v25; // rax
		  __int64 v26; // rax
		  Vector3 v27; // [rsp+30h] [rbp-D0h] BYREF
		  Vector3 v28; // [rsp+40h] [rbp-C0h] BYREF
		  HGCapsuleShadowContainer v29; // [rsp+50h] [rbp-B0h] BYREF
		  __int128 v30; // [rsp+80h] [rbp-80h]
		  unsigned __int64 v31; // [rsp+90h] [rbp-70h] BYREF
		  int v32; // [rsp+98h] [rbp-68h]
		  __int128 v33; // [rsp+A0h] [rbp-60h] BYREF
		  __int128 v34; // [rsp+B0h] [rbp-50h] BYREF
		  Matrix4x4 v35; // [rsp+C0h] [rbp-40h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 2090 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x82A )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !v6[44]._1.unity_user_data )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2090, 0LL);
		      if ( Patch )
		      {
		        v19 = *(_OWORD *)&container->localOffset.x;
		        *(_OWORD *)&v29.rootTransform = *(_OWORD *)&container->rootTransform;
		        v20 = *(_OWORD *)&container->localRotation.y;
		        *(_OWORD *)&v29.localOffset.x = v19;
		        *(_OWORD *)&v29.localRotation.y = v20;
		        v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(&v35, Patch, (Object *)this, &v29, 0LL);
		        v22 = *(_OWORD *)&v21->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v21->m00;
		        v23 = *(_OWORD *)&v21->m02;
		        *(_OWORD *)&retstr->m01 = v22;
		        v24 = *(_OWORD *)&v21->m03;
		        result = retstr;
		        *(_OWORD *)&retstr->m02 = v23;
		        *(_OWORD *)&retstr->m03 = v24;
		        return result;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  v9 = *(__m128i *)&container->localOffset.x;
		  *(_OWORD *)&v29.rootTransform = *(_OWORD *)&container->rootTransform;
		  *(_OWORD *)&v29.localRotation.y = *(_OWORD *)&container->localRotation.y;
		  *(__m128i *)&v29.localOffset.x = v9;
		  *(_QWORD *)&v27.x = *(_QWORD *)&v29.localRotation.x;
		  LODWORD(v27.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v29.localRotation.y, 4));
		  v10 = UnityEngine::Vector3::op_Multiply(&v28, &v27, 0.017453292, method);
		  v33 = 0LL;
		  v11 = *(_QWORD *)&v10->x;
		  v27.z = v10->z;
		  v12 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18F36FAC8;
		  *(_QWORD *)&v27.x = v11;
		  if ( !qword_18F36FAC8 )
		  {
		    v12 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngi"
		                                                        "ne.Vector3&,UnityEngine.Quaternion&)");
		    if ( !v12 )
		    {
		      v25 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		      sub_18007E1B0(v25, 0LL);
		    }
		    qword_18F36FAC8 = (__int64)v12;
		  }
		  v12(&v27, &v33);
		  v13 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))qword_18F36FA58;
		  v31 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  *(_QWORD *)&v28.x = v9.m128i_i64[0];
		  v32 = 1065353216;
		  LODWORD(v28.z) = _mm_cvtsi128_si32(_mm_srli_si128(v9, 8));
		  v34 = v33;
		  memset(&v29, 0, sizeof(v29));
		  v30 = 0LL;
		  if ( !qword_18F36FA58 )
		  {
		    v13 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
		    if ( !v13 )
		    {
		      v26 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v26, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v13;
		  }
		  v13(&v28, &v34, &v31, &v29);
		  result = retstr;
		  v15 = *(_OWORD *)&v29.localOffset.x;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v29.rootTransform;
		  v16 = *(_OWORD *)&v29.localRotation.y;
		  *(_OWORD *)&retstr->m01 = v15;
		  v17 = v30;
		  *(_OWORD *)&retstr->m02 = v16;
		  *(_OWORD *)&retstr->m03 = v17;
		  return result;
		}
		
		public Transform GetCapsuleTransform(HGCapsuleShadowContainer container) => default; // 0x0000000189C2121C-0x0000000189C212C4
		// Transform GetCapsuleTransform(HGCapsuleShadowContainer)
		Transform *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleTransform(
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  Transform *transform; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  HGCapsuleShadowContainer v12; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4104, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4104, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = *(_OWORD *)&container->localOffset.x;
		    *(_OWORD *)&v12.rootTransform = *(_OWORD *)&container->rootTransform;
		    v11 = *(_OWORD *)&container->localRotation.y;
		    *(_OWORD *)&v12.localOffset.x = v10;
		    *(_OWORD *)&v12.localRotation.y = v11;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1451(Patch, (Object *)this, &v12, 0LL);
		  }
		  else
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)container->rootTransform, 0LL, 0LL) )
		      return container->rootTransform;
		    return transform;
		  }
		}
		
		public Matrix4x4 GetCapsuleLocalToWorldMatrix(HGCapsuleShadowContainer container) => default; // 0x0000000182FA4F30-0x0000000182FA52B0
		// Matrix4x4 GetCapsuleLocalToWorldMatrix(HGCapsuleShadowContainer)
		Matrix4x4 *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleLocalToWorldMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  _QWORD **v6; // rcx
		  __int64 v8; // rdx
		  __int64 (__fastcall *v9)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *); // rax
		  __int64 v10; // rax
		  Transform *rootTransform; // rsi
		  __int128 v12; // xmm1
		  bool v13; // zf
		  __int128 v14; // xmm6
		  __int128 v15; // xmm1
		  void (__fastcall *v16)(Transform *, Matrix4x4 *); // rax
		  MethodInfo *v17; // r9
		  __int128 v18; // xmm1
		  __m128i v19; // xmm6
		  Vector3 *v20; // rax
		  __int64 v21; // xmm3_8
		  void (__fastcall *v22)(Vector3 *, __int128 *); // rax
		  void (__fastcall *v23)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *); // rax
		  __int128 v24; // xmm2
		  __int128 v25; // xmm3
		  __int128 v26; // xmm4
		  __int128 v27; // xmm5
		  void (__fastcall *v28)(Matrix4x4 *, _OWORD *, Matrix4x4 *); // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  Matrix4x4 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  Matrix4x4 *v36; // rax
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int64 v39; // rax
		  __int64 v40; // rax
		  ILFixDynamicMethodWrapper_2 *v41; // rax
		  __int128 v42; // xmm0
		  Matrix4x4 *v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  __int64 v46; // rax
		  Vector3 v47; // [rsp+30h] [rbp-D0h] BYREF
		  HGCapsuleShadowContainer v48; // [rsp+40h] [rbp-C0h] BYREF
		  __int128 v49; // [rsp+70h] [rbp-90h]
		  Vector3 v50; // [rsp+80h] [rbp-80h] BYREF
		  Matrix4x4 v51; // [rsp+90h] [rbp-70h] BYREF
		  unsigned __int64 v52; // [rsp+D0h] [rbp-30h] BYREF
		  int v53; // [rsp+D8h] [rbp-28h]
		  __int128 v54; // [rsp+E0h] [rbp-20h] BYREF
		  __int128 v55; // [rsp+F0h] [rbp-10h] BYREF
		  Matrix4x4 v56; // [rsp+100h] [rbp+0h] BYREF
		  _OWORD v57[4]; // [rsp+140h] [rbp+40h] BYREF
		  Matrix4x4 v58; // [rsp+180h] [rbp+80h] BYREF
		
		  v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = *v6[23];
		  if ( !v8 )
		    goto LABEL_24;
		  if ( *(int *)(v8 + 24) > 2089 )
		  {
		    if ( !*((_DWORD *)v6 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v8 = *v6[23];
		    if ( !v8 )
		      goto LABEL_24;
		    if ( *(_DWORD *)(v8 + 24) <= 0x829u )
		      goto LABEL_47;
		    if ( *(_QWORD *)(v8 + 16744) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2089, 0LL);
		      if ( Patch )
		      {
		        v34 = *(_OWORD *)&container->localOffset.x;
		        *(_OWORD *)&v48.rootTransform = *(_OWORD *)&container->rootTransform;
		        v35 = *(_OWORD *)&container->localRotation.y;
		        *(_OWORD *)&v48.localOffset.x = v34;
		        *(_OWORD *)&v48.localRotation.y = v35;
		        v36 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(&v56, Patch, (Object *)this, &v48, 0LL);
		        v37 = *(_OWORD *)&v36->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v36->m00;
		        v38 = *(_OWORD *)&v36->m02;
		        *(_OWORD *)&retstr->m01 = v37;
		        v31 = *(_OWORD *)&v36->m03;
		        *(_OWORD *)&retstr->m02 = v38;
		        goto LABEL_23;
		      }
		      goto LABEL_24;
		    }
		  }
		  v9 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v9 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v9 )
		    {
		      v39 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v39, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v9;
		  }
		  v10 = v9(this, v8, container, method);
		  v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  rootTransform = (Transform *)v10;
		  v12 = *(_OWORD *)&container->localRotation.y;
		  v13 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		  v14 = *(_OWORD *)&container->rootTransform;
		  *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v48.localRotation.y = v12;
		  if ( v13 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( (_QWORD)v14 )
		  {
		    if ( !*((_DWORD *)v6 + 56) )
		      il2cpp_runtime_class_init_1(v6);
		    if ( *(_QWORD *)(v14 + 16) )
		    {
		      rootTransform = container->rootTransform;
		      v15 = *(_OWORD *)&container->localRotation.y;
		      *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container->localOffset.x;
		      *(_OWORD *)&v48.localRotation.y = v15;
		    }
		  }
		  if ( !rootTransform )
		    goto LABEL_24;
		  v16 = (void (__fastcall *)(Transform *, Matrix4x4 *))qword_18F370148;
		  memset(&v51, 0, sizeof(v51));
		  if ( !qword_18F370148 )
		  {
		    v16 = (void (__fastcall *)(Transform *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityE"
		                                                           "ngine.Matrix4x4&)");
		    if ( !v16 )
		    {
		      v40 = sub_1802EE1B8("UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v40, 0LL);
		    }
		    qword_18F370148 = (__int64)v16;
		  }
		  v16(rootTransform, &v51);
		  v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = *v6[23];
		  if ( !v8 )
		    goto LABEL_24;
		  if ( *(int *)(v8 + 24) <= 2090 )
		  {
		LABEL_18:
		    v18 = *(_OWORD *)&container->rootTransform;
		    *(_OWORD *)&v48.localRotation.y = *(_OWORD *)&container->localRotation.y;
		    *(_OWORD *)&v48.rootTransform = v14;
		    v19 = *(__m128i *)&container->localOffset.x;
		    *(_OWORD *)&v48.rootTransform = v18;
		    *(__m128i *)&v48.localOffset.x = v19;
		    LODWORD(v47.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v48.localRotation.y, 4));
		    *(_QWORD *)&v47.x = *(_QWORD *)&v48.localRotation.x;
		    v20 = UnityEngine::Vector3::op_Multiply(&v50, &v47, 0.017453292, v17);
		    v54 = 0LL;
		    v21 = *(_QWORD *)&v20->x;
		    v47.z = v20->z;
		    v22 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18F36FAC8;
		    *(_QWORD *)&v47.x = v21;
		    if ( !qword_18F36FAC8 )
		    {
		      v22 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEn"
		                                                          "gine.Vector3&,UnityEngine.Quaternion&)");
		      if ( !v22 )
		      {
		        v44 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		        sub_18007E1B0(v44, 0LL);
		      }
		      qword_18F36FAC8 = (__int64)v22;
		    }
		    v22(&v47, &v54);
		    v23 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))qword_18F36FA58;
		    v52 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    *(_QWORD *)&v50.x = v19.m128i_i64[0];
		    v53 = 1065353216;
		    LODWORD(v50.z) = _mm_cvtsi128_si32(_mm_srli_si128(v19, 8));
		    v55 = v54;
		    memset(&v48, 0, sizeof(v48));
		    v49 = 0LL;
		    if ( !qword_18F36FA58 )
		    {
		      v23 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
		      if ( !v23 )
		      {
		        v45 = sub_1802EE1B8(
		                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
		                "ityEngine.Matrix4x4&)");
		        sub_18007E1B0(v45, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v23;
		    }
		    v23(&v50, &v55, &v52, &v48);
		    v24 = *(_OWORD *)&v48.rootTransform;
		    v25 = *(_OWORD *)&v48.localOffset.x;
		    v26 = *(_OWORD *)&v48.localRotation.y;
		    v27 = v49;
		    goto LABEL_21;
		  }
		  if ( !*((_DWORD *)v6 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (_QWORD **)*v6[23];
		  if ( !v6 )
		LABEL_24:
		    sub_1800D8260(v6, v8);
		  if ( *((_DWORD *)v6 + 6) <= 0x82Au )
		LABEL_47:
		    sub_1800D2AB0(v6, v8);
		  if ( !v6[2094] )
		    goto LABEL_18;
		  v41 = IFix::WrappersManagerImpl::GetPatch(2090, 0LL);
		  if ( !v41 )
		    goto LABEL_24;
		  v42 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v48.localRotation.y = v42;
		  *(_OWORD *)&v48.rootTransform = v14;
		  v43 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(&v58, v41, (Object *)this, &v48, 0LL);
		  v24 = *(_OWORD *)&v43->m00;
		  v25 = *(_OWORD *)&v43->m01;
		  v26 = *(_OWORD *)&v43->m02;
		  v27 = *(_OWORD *)&v43->m03;
		LABEL_21:
		  v28 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))qword_18F36FA50;
		  v57[0] = v24;
		  v56 = v51;
		  v57[1] = v25;
		  v57[2] = v26;
		  v57[3] = v27;
		  memset(&v51, 0, sizeof(v51));
		  if ( !qword_18F36FA50 )
		  {
		    v28 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v28 )
		    {
		      v46 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v46, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v28;
		  }
		  v28(&v56, v57, &v51);
		  v29 = *(_OWORD *)&v51.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v51.m00;
		  v30 = *(_OWORD *)&v51.m02;
		  *(_OWORD *)&retstr->m01 = v29;
		  v31 = *(_OWORD *)&v51.m03;
		  *(_OWORD *)&retstr->m02 = v30;
		LABEL_23:
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v31;
		  return result;
		}
		
		private Transform FindRecursive(Transform root, string name) => default; // 0x0000000189C20BE0-0x0000000189C20D1C
		// Transform FindRecursive(Transform, String)
		Transform *HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(
		        HGCapsuleShadowHelper *this,
		        Transform *root,
		        String *name,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Object_1 *gameObject; // rax
		  String *v10; // rax
		  int32_t i; // edi
		  Transform *Child; // rax
		  Transform *Recursive; // rbp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4105, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)root, 0LL, 0LL) )
		      return 0LL;
		    if ( root )
		    {
		      gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)root, 0LL);
		      if ( gameObject )
		      {
		        v10 = UnityEngine::Object::get_name(gameObject, 0LL);
		        if ( v10 )
		        {
		          if ( System::String::Equals(v10, name, 0LL) )
		            return root;
		          for ( i = 0; i < UnityEngine::Transform::get_childCount(root, 0LL); ++i )
		          {
		            Child = UnityEngine::Transform::GetChild(root, i, 0LL);
		            Recursive = HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(this, Child, name, 0LL);
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Implicit((Object_1 *)Recursive, 0LL) )
		              return Recursive;
		          }
		          return 0LL;
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4105, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1452(Patch, (Object *)this, (Object *)root, (Object *)name, 0LL);
		}
		
		private bool GetSkeletonTransformByName(out Transform t, Transform rootTransform, string name) {
			t = default;
			return default;
		} // 0x0000000189C212C4-0x0000000189C213A4
		// Boolean GetSkeletonTransformByName(Transform ByRef, Transform, String)
		bool HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		        HGCapsuleShadowHelper *this,
		        Transform **t,
		        Transform *rootTransform,
		        String *name,
		        MethodInfo *method)
		{
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Object_1 *v12; // rbx
		  String *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  MethodInfo *P3; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4106, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4106, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1453(
		             Patch,
		             (Object *)this,
		             t,
		             (Object *)rootTransform,
		             (Object *)name,
		             0LL);
		  }
		  else
		  {
		    *t = HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(this, rootTransform, name, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)t, v9, v10, v11, P3);
		    v12 = (Object_1 *)*t;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(v12, 0LL, 0LL) )
		    {
		      v14 = System::String::Concat(
		              (String *)"Capsule骨骼生成失败！该角色没有绑定名为",
		              name,
		              (String *)"的骨骼节点",
		              0LL);
		      HG::Rendering::HGRPLogger::LogWarning(v14, 0LL);
		      return 0;
		    }
		    else
		    {
		      return 1;
		    }
		  }
		}
		
		private HGCapsuleShadowContainer GenerateCapsuleShadowContainer(Transform baseTransform, Transform targetTransform, float radius, float baseTransformOffset = 0f /* Metadata: 0x02304089 */, float targetTransformOffset = 0f /* Metadata: 0x0230408D */, bool isToes = false /* Metadata: 0x02304091 */) => default; // 0x0000000189C20D1C-0x0000000189C2121C
		// HGCapsuleShadowContainer GenerateCapsuleShadowContainer(Transform, Transform, Single, Single, Single, Boolean)
		HGCapsuleShadowContainer *HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		        HGCapsuleShadowContainer *__return_ptr retstr,
		        HGCapsuleShadowHelper *this,
		        Transform *baseTransform,
		        Transform *targetTransform,
		        float radius,
		        float baseTransformOffset,
		        float targetTransformOffset,
		        bool isToes,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  Object_1 *v14; // rcx
		  Vector3 *position; // rax
		  __int64 v16; // xmm6_8
		  float z; // edi
		  Vector3 *v18; // rax
		  __int64 v19; // xmm7_8
		  float v20; // ebx
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  __int64 v23; // xmm3_8
		  __int64 v24; // rax
		  MethodInfo *v25; // r9
		  __int64 v26; // xmm4_8
		  float v27; // r10d
		  Vector3 *v28; // rax
		  __int64 v29; // xmm3_8
		  __int64 v30; // rax
		  Vector3 *v31; // rax
		  __int64 v32; // xmm1_8
		  MethodInfo *v33; // r9
		  Vector3 *v34; // rax
		  __int64 v35; // xmm4_8
		  float v36; // r10d
		  __int64 v37; // xmm9_8
		  float v38; // esi
		  MethodInfo *v39; // r9
		  Vector3 *v40; // rax
		  __int64 v41; // xmm1_8
		  MethodInfo *v42; // r9
		  Vector3 *v43; // rax
		  __int64 v44; // xmm6_8
		  float v45; // ebx
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm4_8
		  float v52; // r10d
		  __int64 v53; // xmm8_8
		  float v54; // edi
		  Vector3 *AnyPerpendicular_32_0; // rax
		  __int64 v56; // xmm0_8
		  bool v57; // r12
		  __m128i v58; // xmm7
		  MethodInfo *v59; // r9
		  Vector3 *v60; // rax
		  __int64 v61; // xmm3_8
		  Type *v62; // rdx
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  Matrix4x4 *worldToLocalMatrix; // rax
		  __int128 v66; // xmm1
		  __int128 v67; // xmm0
		  __int128 v68; // xmm1
		  Quaternion *rotation; // rax
		  MethodInfo *v70; // r9
		  __int64 v71; // rax
		  __int128 v72; // xmm1
		  __int128 v73; // xmm0
		  HGCapsuleShadowContainer *v74; // rax
		  HGCapsuleShadowContainer *result; // rax
		  MethodInfo *v76; // [rsp+28h] [rbp-E0h]
		  Quaternion v77; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v78; // [rsp+68h] [rbp-A0h] BYREF
		  Quaternion v79; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v80; // [rsp+88h] [rbp-80h] BYREF
		  __m128i v81; // [rsp+98h] [rbp-70h] BYREF
		  Object_1 *v82[2]; // [rsp+A8h] [rbp-60h] BYREF
		  _OWORD v83[2]; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v84; // [rsp+D8h] [rbp-30h] BYREF
		  Matrix4x4 v85[2]; // [rsp+118h] [rbp+10h] BYREF
		
		  *(_OWORD *)v82 = 0LL;
		  memset(v83, 0, sizeof(v83));
		  if ( IFix::WrappersManagerImpl::IsPatched(4107, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4107, 0LL);
		    if ( Patch )
		    {
		      v74 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1454(
		              (HGCapsuleShadowContainer *)&v84,
		              Patch,
		              (Object *)this,
		              (Object *)baseTransform,
		              (Object *)targetTransform,
		              radius,
		              baseTransformOffset,
		              targetTransformOffset,
		              isToes,
		              0LL);
		      v72 = *(_OWORD *)&v74->localOffset.x;
		      *(_OWORD *)&retstr->rootTransform = *(_OWORD *)&v74->rootTransform;
		      v73 = *(_OWORD *)&v74->localRotation.y;
		      goto LABEL_14;
		    }
		    goto LABEL_12;
		  }
		  if ( !baseTransform )
		    goto LABEL_12;
		  position = UnityEngine::Transform::get_position((Vector3 *)&v81, baseTransform, 0LL);
		  v16 = *(_QWORD *)&position->x;
		  z = position->z;
		  *(_QWORD *)&v77.x = *(_QWORD *)&position->x;
		  if ( !targetTransform )
		    goto LABEL_12;
		  v18 = UnityEngine::Transform::get_position((Vector3 *)&v79, targetTransform, 0LL);
		  *(_QWORD *)&v80.x = v16;
		  v80.z = z;
		  v19 = *(_QWORD *)&v18->x;
		  v20 = v18->z;
		  v81.m128i_i64[0] = v19;
		  *(_QWORD *)&v78.x = v19;
		  v78.z = v20;
		  v22 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v79, &v78, &v80, v21);
		  v23 = *(_QWORD *)&v22->x;
		  *(float *)&v22 = v22->z;
		  *(_QWORD *)&v80.x = v23;
		  LODWORD(v80.z) = (_DWORD)v22;
		  v24 = sub_182FAE2B0(&v79, &v80);
		  v26 = *(_QWORD *)v24;
		  v27 = *(float *)(v24 + 8);
		  if ( isToes )
		  {
		    LODWORD(v77.y) = v81.m128i_i32[1];
		    v16 = *(_QWORD *)&v77.x;
		    v77.z = z;
		    *(_QWORD *)&v78.x = v19;
		    v78.z = v20;
		    v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v79, &v78, (Vector3 *)&v77, v25);
		    v29 = *(_QWORD *)&v28->x;
		    *(float *)&v28 = v28->z;
		    *(_QWORD *)&v80.x = v29;
		    LODWORD(v80.z) = (_DWORD)v28;
		    v30 = sub_182FAE2B0(&v79, &v80);
		    v26 = *(_QWORD *)v30;
		    v27 = *(float *)(v30 + 8);
		  }
		  *(_QWORD *)&v77.x = v26;
		  v77.z = v27;
		  v31 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v79, baseTransformOffset, (Vector3 *)&v77, v25);
		  *(_QWORD *)&v78.x = v16;
		  v78.z = z;
		  v32 = *(_QWORD *)&v31->x;
		  *(float *)&v31 = v31->z;
		  *(_QWORD *)&v77.x = v32;
		  LODWORD(v77.z) = (_DWORD)v31;
		  v34 = UnityEngine::Vector3::op_Addition((Vector3 *)&v79, &v78, (Vector3 *)&v77, v33);
		  *(_QWORD *)&v77.x = v35;
		  v77.z = v36;
		  v37 = *(_QWORD *)&v34->x;
		  v38 = v34->z;
		  v40 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v81, targetTransformOffset, (Vector3 *)&v77, v39);
		  *(_QWORD *)&v78.x = v19;
		  v78.z = v20;
		  v41 = *(_QWORD *)&v40->x;
		  *(float *)&v40 = v40->z;
		  *(_QWORD *)&v77.x = v41;
		  LODWORD(v77.z) = (_DWORD)v40;
		  v43 = UnityEngine::Vector3::op_Addition((Vector3 *)&v81, &v78, (Vector3 *)&v77, v42);
		  *(_QWORD *)&v78.x = v37;
		  v78.z = v38;
		  v45 = v43->z;
		  *(_QWORD *)&v77.x = *(_QWORD *)&v43->x;
		  v44 = *(_QWORD *)&v77.x;
		  v77.z = v45;
		  v47 = UnityEngine::Vector3::op_Addition((Vector3 *)&v79, &v78, (Vector3 *)&v77, v46);
		  v48 = *(_QWORD *)&v47->x;
		  *(float *)&v47 = v47->z;
		  *(_QWORD *)&v77.x = v48;
		  LODWORD(v77.z) = (_DWORD)v47;
		  v50 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v79, 0.5, (Vector3 *)&v77, v49);
		  *(_QWORD *)&v77.x = v51;
		  v77.z = v52;
		  *(_QWORD *)&v78.x = v51;
		  v53 = *(_QWORD *)&v50->x;
		  v54 = v50->z;
		  v78.z = v52;
		  AnyPerpendicular_32_0 = HG::Rendering::Runtime::HGCapsuleShadowHelper::_GenerateCapsuleShadowContainer_g__GetAnyPerpendicular_32_0(
		                            (Vector3 *)&v79,
		                            (Vector3 *)&v77,
		                            0LL);
		  v56 = *(_QWORD *)&AnyPerpendicular_32_0->x;
		  *(float *)&AnyPerpendicular_32_0 = AnyPerpendicular_32_0->z;
		  *(_QWORD *)&v77.x = v56;
		  LODWORD(v77.z) = (_DWORD)AnyPerpendicular_32_0;
		  v57 = 1;
		  v58 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::LookRotation(&v79, (Vector3 *)&v77, &v78, 0LL));
		  BYTE12(v83[1]) = 1;
		  *(_QWORD *)&v77.x = v37;
		  v77.z = v38;
		  *(_QWORD *)&v78.x = v44;
		  v78.z = v45;
		  v60 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v79, &v78, (Vector3 *)&v77, v59);
		  v61 = *(_QWORD *)&v60->x;
		  *(float *)&v60 = v60->z;
		  *(_QWORD *)&v80.x = v61;
		  LODWORD(v80.z) = (_DWORD)v60;
		  v82[1] = (Object_1 *)__PAIR64__(COERCE_UNSIGNED_INT(sub_182F9FF00(&v80)), LODWORD(radius));
		  v82[0] = (Object_1 *)baseTransform;
		  sub_18002D1B0((SingleFieldAccessor *)v82, v62, v63, v64, v76);
		  worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(v85, baseTransform, 0LL);
		  *(_QWORD *)&v77.x = v53;
		  v77.z = v54;
		  v66 = *(_OWORD *)&worldToLocalMatrix->m01;
		  *(_OWORD *)&v84.m00 = *(_OWORD *)&worldToLocalMatrix->m00;
		  v67 = *(_OWORD *)&worldToLocalMatrix->m02;
		  *(_OWORD *)&v84.m01 = v66;
		  v68 = *(_OWORD *)&worldToLocalMatrix->m03;
		  *(_OWORD *)&v84.m02 = v67;
		  *(_OWORD *)&v84.m03 = v68;
		  *(Vector3 *)v83 = *UnityEngine::Matrix4x4::MultiplyPoint((Vector3 *)&v79, &v84, (Vector3 *)&v77, 0LL);
		  rotation = UnityEngine::Transform::get_rotation(&v79, baseTransform, 0LL);
		  v81 = v58;
		  v79 = *rotation;
		  v79 = *UnityEngine::Quaternion::Inverse(&v77, &v79, 0LL);
		  v81 = *(__m128i *)UnityEngine::Quaternion::op_Multiply(&v77, &v79, (Quaternion *)&v81, v70);
		  v71 = sub_182F3F6C0(&v79, &v81);
		  v14 = v82[0];
		  *(_QWORD *)((char *)v83 + 12) = *(_QWORD *)v71;
		  DWORD1(v83[1]) = *(_DWORD *)(v71 + 8);
		  DWORD2(v83[1]) = 1065353216;
		  if ( !v82[0] )
		    goto LABEL_12;
		  if ( !UnityEngine::Object::CompareName(v82[0], this->fields.m_skeletonName_Ankle_L, 0LL) )
		  {
		    v14 = v82[0];
		    if ( v82[0] )
		    {
		      v57 = UnityEngine::Object::CompareName(v82[0], this->fields.m_skeletonName_Ankle_R, 0LL);
		      goto LABEL_10;
		    }
		LABEL_12:
		    sub_1800D8260(v14, Patch);
		  }
		LABEL_10:
		  BYTE13(v83[1]) = v57;
		  v72 = v83[0];
		  *(_OWORD *)&retstr->rootTransform = *(_OWORD *)v82;
		  v73 = v83[1];
		LABEL_14:
		  result = retstr;
		  *(_OWORD *)&retstr->localOffset.x = v72;
		  *(_OWORD *)&retstr->localRotation.y = v73;
		  return result;
		}
		
		public bool AutomateGenerateCapsuleSkeletons() => default; // 0x0000000189C201BC-0x0000000189C20BE0
		// Boolean AutomateGenerateCapsuleSkeletons()
		bool HG::Rendering::Runtime::HGCapsuleShadowHelper::AutomateGenerateCapsuleSkeletons(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  Transform *v4; // rax
		  Transform *v5; // rax
		  Transform *v6; // rax
		  Transform *v7; // rax
		  Transform *v8; // rax
		  Transform *v9; // rax
		  bool v10; // r13
		  Transform *v11; // rax
		  bool v12; // r12
		  Transform *v13; // rax
		  bool v14; // r15
		  Transform *v15; // rax
		  bool v16; // r14
		  Transform *v17; // rax
		  bool v18; // si
		  Transform *v19; // rax
		  bool v20; // di
		  Transform *v21; // rax
		  bool v22; // bl
		  Transform *v23; // rax
		  HGCapsuleShadowContainer *v24; // rax
		  __int128 v25; // xmm10
		  __int128 v26; // xmm11
		  __int128 v27; // xmm12
		  HGCapsuleShadowContainer *v28; // rax
		  __int128 v29; // xmm13
		  __int128 v30; // xmm14
		  __int128 v31; // xmm15
		  HGCapsuleShadowContainer *v32; // rax
		  HGCapsuleShadowContainer *v33; // rax
		  HGCapsuleShadowContainer *v34; // rax
		  float m_feetSize; // xmm2_4
		  HGCapsuleShadowContainer *v36; // rax
		  float v37; // xmm2_4
		  __int128 v38; // xmm7
		  __int128 v39; // xmm8
		  HGCapsuleShadowContainer *v40; // rax
		  __int128 v41; // xmm6
		  __int128 v42; // xmm9
		  Type *v43; // rdx
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  Animator *v46; // rdx
		  int32_t v47; // r8d
		  MethodInfo *v48; // r9
		  Type *v49; // rdx
		  PropertyInfo_1 *v50; // r8
		  Int32__Array **v51; // r9
		  Animator *v52; // rdx
		  int32_t v53; // r8d
		  MethodInfo *v54; // r9
		  Animator *v55; // rdx
		  int32_t v56; // r8d
		  MethodInfo *v57; // r9
		  Vector3 *Vector; // rax
		  __int64 v59; // rdx
		  __int64 v60; // xmm0_8
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v63; // rax
		  float v64; // xmm1_4
		  float v65; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+28h] [rbp-E0h]
		  MethodInfo *methodb; // [rsp+28h] [rbp-E0h]
		  bool v70; // [rsp+58h] [rbp-B0h]
		  bool v71; // [rsp+59h] [rbp-AFh]
		  bool v72; // [rsp+5Ah] [rbp-AEh]
		  bool SkeletonTransformByName; // [rsp+5Bh] [rbp-ADh]
		  EntityRenderHelperMaterialController_AddedMaterialInfo v74; // [rsp+68h] [rbp-A0h] BYREF
		  Transform *v75; // [rsp+98h] [rbp-70h] BYREF
		  Transform *v76; // [rsp+A0h] [rbp-68h] BYREF
		  Transform *v77; // [rsp+A8h] [rbp-60h] BYREF
		  Transform *v78; // [rsp+B0h] [rbp-58h] BYREF
		  Transform *t; // [rsp+B8h] [rbp-50h] BYREF
		  Transform *v80; // [rsp+C0h] [rbp-48h] BYREF
		  Transform *v81; // [rsp+C8h] [rbp-40h] BYREF
		  Transform *v82; // [rsp+D0h] [rbp-38h] BYREF
		  Transform *v83; // [rsp+D8h] [rbp-30h] BYREF
		  Transform *v84; // [rsp+E0h] [rbp-28h] BYREF
		  Transform *v85; // [rsp+E8h] [rbp-20h] BYREF
		  Transform *v86; // [rsp+F0h] [rbp-18h] BYREF
		  Transform *v87; // [rsp+F8h] [rbp-10h] BYREF
		  Transform *v88; // [rsp+100h] [rbp-8h] BYREF
		  EntityRenderHelperMaterialController_AddedMaterialInfo v89; // [rsp+108h] [rbp+0h] BYREF
		  EntityRenderHelperMaterialController_AddedMaterialInfo v90; // [rsp+138h] [rbp+30h] BYREF
		  HGCapsuleShadowContainer v91; // [rsp+168h] [rbp+60h] BYREF
		  Vector3 v92; // [rsp+198h] [rbp+90h] BYREF
		  __int128 v93; // [rsp+1A8h] [rbp+A0h]
		  EntityRenderHelperMaterialController_AddedMaterialInfo v94; // [rsp+1B8h] [rbp+B0h]
		  EntityRenderHelperMaterialController_AddedMaterialInfo v95; // [rsp+1E8h] [rbp+E0h]
		  __int128 v96; // [rsp+218h] [rbp+110h]
		  __int128 v97; // [rsp+228h] [rbp+120h]
		  __int128 v98; // [rsp+238h] [rbp+130h]
		  __int128 v99; // [rsp+268h] [rbp+160h]
		  __int128 v100; // [rsp+298h] [rbp+190h]
		  __int128 v101; // [rsp+2C8h] [rbp+1C0h]
		  bool v103; // [rsp+3C8h] [rbp+2C0h]
		  bool v104; // [rsp+3D0h] [rbp+2C8h]
		
		  t = 0LL;
		  v80 = 0LL;
		  v75 = 0LL;
		  v76 = 0LL;
		  v77 = 0LL;
		  v78 = 0LL;
		  v82 = 0LL;
		  v84 = 0LL;
		  v81 = 0LL;
		  v83 = 0LL;
		  v87 = 0LL;
		  v88 = 0LL;
		  v86 = 0LL;
		  v85 = 0LL;
		  memset(&v90, 0, sizeof(v90));
		  memset(&v89, 0, sizeof(v89));
		  if ( IFix::WrappersManagerImpl::IsPatched(4109, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4109, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		LABEL_28:
		    sub_1800D8260(m_capsuleShadowContainers, v59);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  SkeletonTransformByName = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		                              this,
		                              &t,
		                              transform,
		                              this->fields.m_skeletonName_Hip_R,
		                              0LL);
		  v4 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v72 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v80,
		          v4,
		          this->fields.m_skeletonName_Hip_L,
		          0LL);
		  v5 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v71 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v75,
		          v5,
		          this->fields.m_skeletonName_Knee_R,
		          0LL);
		  v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v70 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v76,
		          v6,
		          this->fields.m_skeletonName_Knee_L,
		          0LL);
		  v7 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v104 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		           this,
		           &v77,
		           v7,
		           this->fields.m_skeletonName_Ankle_R,
		           0LL);
		  v8 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v103 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		           this,
		           &v78,
		           v8,
		           this->fields.m_skeletonName_Ankle_L,
		           0LL);
		  v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v10 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v87,
		          v9,
		          this->fields.m_skeletonName_Trunk,
		          0LL);
		  v11 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v12 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v82,
		          v11,
		          this->fields.m_skeletonName_Shoulder_R,
		          0LL);
		  v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v14 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v84,
		          v13,
		          this->fields.m_skeletonName_Shoulder_L,
		          0LL);
		  v15 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v16 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v81,
		          v15,
		          this->fields.m_skeletonName_Wrist_R,
		          0LL);
		  v17 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v18 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v83,
		          v17,
		          this->fields.m_skeletonName_Wrist_L,
		          0LL);
		  v19 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v20 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v86,
		          v19,
		          this->fields.m_skeletonName_ToesEnd_L,
		          0LL);
		  v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  v22 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		          this,
		          &v85,
		          v21,
		          this->fields.m_skeletonName_ToesEnd_R,
		          0LL);
		  v23 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( (v72 & v71 & v70 & v104 & v103 & v10 & v12 & v14 & v16 & v18 & v20 & v22 & HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
		                                                                                    this,
		                                                                                    &v88,
		                                                                                    v23,
		                                                                                    this->fields.m_skeletonName_Head,
		                                                                                    0LL) & SkeletonTransformByName) == 0 )
		    return 0;
		  v24 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          t,
		          v75,
		          0.07,
		          0.0,
		          0.0,
		          0,
		          0LL);
		  v25 = *(_OWORD *)&v24->rootTransform;
		  v26 = *(_OWORD *)&v24->localOffset.x;
		  v27 = *(_OWORD *)&v24->localRotation.y;
		  v28 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v80,
		          v76,
		          0.07,
		          0.0,
		          0.0,
		          0,
		          0LL);
		  v29 = *(_OWORD *)&v28->rootTransform;
		  v30 = *(_OWORD *)&v28->localOffset.x;
		  v31 = *(_OWORD *)&v28->localRotation.y;
		  v32 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v75,
		          v77,
		          0.07,
		          0.0,
		          0.07,
		          0,
		          0LL);
		  v96 = *(_OWORD *)&v32->rootTransform;
		  v97 = *(_OWORD *)&v32->localOffset.x;
		  v99 = *(_OWORD *)&v32->localRotation.y;
		  v33 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v76,
		          v78,
		          0.07,
		          0.0,
		          0.07,
		          0,
		          0LL);
		  v98 = *(_OWORD *)&v33->rootTransform;
		  v93 = *(_OWORD *)&v33->localOffset.x;
		  v100 = *(_OWORD *)&v33->localRotation.y;
		  v94 = *(EntityRenderHelperMaterialController_AddedMaterialInfo *)HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		                                                                     &v91,
		                                                                     this,
		                                                                     v82,
		                                                                     v81,
		                                                                     0.07,
		                                                                     0.0,
		                                                                     0.0,
		                                                                     0,
		                                                                     0LL);
		  v34 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v84,
		          v83,
		          0.07,
		          0.0,
		          0.0,
		          0,
		          0LL);
		  m_feetSize = this->fields.m_feetSize;
		  v95 = *(EntityRenderHelperMaterialController_AddedMaterialInfo *)v34;
		  if ( m_feetSize <= 0.050000001 )
		    m_feetSize = 0.050000001;
		  v36 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v77,
		          v85,
		          m_feetSize,
		          this->fields.m_feetBaseTransformOffset,
		          this->fields.m_feetTargetTransformOffset,
		          1,
		          0LL);
		  v37 = this->fields.m_feetSize;
		  v38 = *(_OWORD *)&v36->rootTransform;
		  v39 = *(_OWORD *)&v36->localOffset.x;
		  v101 = *(_OWORD *)&v36->localRotation.y;
		  if ( v37 <= 0.050000001 )
		    v37 = 0.050000001;
		  v40 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
		          &v91,
		          this,
		          v78,
		          v86,
		          v37,
		          this->fields.m_feetBaseTransformOffset,
		          this->fields.m_feetTargetTransformOffset,
		          1,
		          0LL);
		  v41 = *(_OWORD *)&v40->rootTransform;
		  v42 = *(_OWORD *)&v40->localOffset.x;
		  *(_OWORD *)&v91.localRotation.y = *(_OWORD *)&v40->localRotation.y;
		  BYTE4(v90.customizeMaterialDict) = 1;
		  v90.material = (Material *)0x3F0CCCCD3E19999ALL;
		  *(_QWORD *)&v90.handle = v87;
		  sub_18002D1B0((SingleFieldAccessor *)&v90, v43, v44, v45, methoda);
		  *(Vector3 *)&v90.mask = *UnityEngine::Animator::GetVector(&v92, v46, v47, v48);
		  *(_QWORD *)&v89.handle = v88;
		  *(__m128i *)((char *)&v90.config + 4) = _mm_load_si128((const __m128i *)&xmmword_18DC814F0);
		  BYTE5(v90.customizeMaterialDict) = 0;
		  BYTE4(v89.customizeMaterialDict) = 1;
		  v89.material = (Material *)0x3E99999A3E19999ALL;
		  sub_18002D1B0((SingleFieldAccessor *)&v89, v49, v50, v51, methodb);
		  *(Vector3 *)&v89.mask = *UnityEngine::Animator::GetVector(&v92, v52, v53, v54);
		  Vector = UnityEngine::Animator::GetVector(&v92, v55, v56, v57);
		  DWORD2(v100) = 1061158912;
		  DWORD2(v99) = 1061158912;
		  v91.intensityScale = 0.75;
		  v60 = *(_QWORD *)&Vector->x;
		  HIDWORD(v89.config.colorTextureName) = LODWORD(Vector->z);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  *(_QWORD *)(&v89.config.useColorTexture + 4) = v60;
		  LODWORD(v89.customizeMaterialDict) = 1065353216;
		  BYTE5(v89.customizeMaterialDict) = 0;
		  DWORD2(v101) = 1061158912;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		    (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)m_capsuleShadowContainers,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v25;
		  *(_OWORD *)&v74.mask = v26;
		  *(_OWORD *)&v74.config.colorTextureName = v27;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v29;
		  *(_OWORD *)&v74.mask = v30;
		  *(_OWORD *)&v74.config.colorTextureName = v31;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v96;
		  *(_OWORD *)&v74.mask = v97;
		  *(_OWORD *)&v74.config.colorTextureName = v99;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v98;
		  *(_OWORD *)&v74.mask = v93;
		  *(_OWORD *)&v74.config.colorTextureName = v100;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  v74 = v94;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  v74 = v95;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v38;
		  *(_OWORD *)&v74.config.colorTextureName = v101;
		  *(_OWORD *)&v74.mask = v39;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  *(_OWORD *)&v74.handle = v41;
		  *(_OWORD *)&v74.config.colorTextureName = *(_OWORD *)&v91.localRotation.y;
		  *(_OWORD *)&v74.mask = v42;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  v74 = v90;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		  if ( !m_capsuleShadowContainers )
		    goto LABEL_28;
		  v74 = v89;
		  sub_180476EDC(
		    m_capsuleShadowContainers,
		    &v74,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		  for ( i = 0; ; ++i )
		  {
		    v63 = this->fields.m_capsuleShadowContainers;
		    if ( !v63 )
		      goto LABEL_28;
		    if ( i >= v63->fields._size )
		      break;
		    System::Collections::Generic::List<Beyond::Rendering::EntityRenderHelperMaterialController::AddedMaterialInfo>::get_Item(
		      &v74,
		      (List_1_Beyond_Rendering_EntityRenderHelperMaterialController_AddedMaterialInfo_ *)this->fields.m_capsuleShadowContainers,
		      i,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Item);
		    *(_OWORD *)&v91.rootTransform = *(_OWORD *)&v74.handle;
		    v64 = (float)(_mm_shuffle_ps(*(__m128 *)&v74.handle, *(__m128 *)&v74.handle, 255).m128_f32[0] * 0.5) * 0.25;
		    v65 = _mm_shuffle_ps(*(__m128 *)&v91.rootTransform, *(__m128 *)&v91.rootTransform, 170).m128_f32[0];
		    if ( v65 <= v64 )
		      v65 = v64;
		    m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		    v91.capsuleRadius = v65;
		    if ( !m_capsuleShadowContainers )
		      goto LABEL_28;
		    *(_OWORD *)&v74.handle = *(_OWORD *)&v91.rootTransform;
		    sub_18067F7EC(
		      m_capsuleShadowContainers,
		      (unsigned int)i,
		      &v74,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::set_Item);
		  }
		  HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(this, 0LL);
		  return 1;
		}
		
		public void AutomateGenerateCapsuleSkeletonsNonHuman() {} // 0x0000000189C1FEF0-0x0000000189C201BC
		// Void AutomateGenerateCapsuleSkeletonsNonHuman()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::AutomateGenerateCapsuleSkeletonsNonHuman(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  HGCapsuleShadowHelper *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  GameObject *gameObject; // rax
		  List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *CapsuleSkeletonsNonHuman; // rax
		  unsigned __int64 v7; // rdx
		  signed __int64 v8; // rcx
		  __m128 v9; // xmm1
		  __m128i v10; // xmm2
		  List_1_Beyond_Gameplay_Audio_AudioMapData_AudioLevelGlobalEvents_FEvents_ *m_capsuleShadowContainers; // r9
		  unsigned __int64 v12; // r8
		  signed __int64 v13; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int128 key; // [rsp+20h] [rbp-F8h] BYREF
		  _OWORD v18[2]; // [rsp+30h] [rbp-E8h] BYREF
		  Il2CppException *ex; // [rsp+50h] [rbp-C8h]
		  List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ *v20; // [rsp+58h] [rbp-C0h]
		  List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ v21; // [rsp+60h] [rbp-B8h] BYREF
		  List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ v22; // [rsp+A0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v23; // [rsp+E0h] [rbp-38h] BYREF
		  _BYTE v24[24]; // [rsp+F8h] [rbp-20h]
		
		  v2 = this;
		  memset(&v21, 0, sizeof(v21));
		  key = 0LL;
		  memset(v18, 0, sizeof(v18));
		  if ( IFix::WrappersManagerImpl::IsPatched(4112, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4112, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.m_capsuleShadowContainers )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		      (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2->fields.m_capsuleShadowContainers,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
		    gameObject = UnityEngine::Component::get_gameObject((Component *)v2, 0LL);
		    CapsuleSkeletonsNonHuman = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)HG::Rendering::Runtime::HGBoneCapsuleUtilities::AutomateGenerateCapsuleSkeletonsNonHuman(
		                                                                                          gameObject,
		                                                                                          0LL);
		    if ( CapsuleSkeletonsNonHuman )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::GetEnumerator(
		        (List_1_T_Enumerator_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)&v22,
		        CapsuleSkeletonsNonHuman,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::GetEnumerator);
		      v21 = v22;
		      ex = 0LL;
		      v20 = &v21;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::StyledBlackboard::StyledDataPair>::MoveNext(
		                  &v21,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGBoneCapsuleData>::MoveNext) )
		        {
		          v9 = *(__m128 *)&v21._current.dataPair.key;
		          v10 = *(__m128i *)&v21._current.dataPair.valueStr;
		          *(_OWORD *)v24 = *(_OWORD *)&v21._current.dataPair.valueStr;
		          *(_QWORD *)&v24[16] = v21._current.styleStr;
		          m_capsuleShadowContainers = (List_1_Beyond_Gameplay_Audio_AudioMapData_AudioLevelGlobalEvents_FEvents_ *)v2->fields.m_capsuleShadowContainers;
		          memset(v18, 0, sizeof(v18));
		          key = (unsigned __int64)v21._current.dataPair.key;
		          if ( dword_18F35FD08 )
		          {
		            v12 = (((unsigned __int64)&key >> 12) & 0x1FFFFF) >> 6;
		            v7 = ((unsigned __int64)&key >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F103690[v12]);
		            do
		            {
		              v8 = qword_18F103690[v12] | (1LL << v7);
		              v13 = qword_18F103690[v12];
		            }
		            while ( v13 != _InterlockedCompareExchange64(&qword_18F103690[v12], v8, v13) );
		          }
		          DWORD2(key) = _mm_shuffle_ps(v9, v9, 170).m128_u32[0];
		          HIDWORD(key) = _mm_shuffle_ps(v9, v9, 255).m128_u32[0];
		          *(_QWORD *)&v18[0] = v10.m128i_i64[0];
		          DWORD2(v18[0]) = _mm_cvtsi128_si32(_mm_srli_si128(v10, 8));
		          *(_QWORD *)((char *)v18 + 12) = *(_QWORD *)&v24[12];
		          *(_QWORD *)((char *)&v18[1] + 4) = *(unsigned int *)&v24[20] | 0x3F80000000000000LL;
		          BYTE12(v18[1]) = 1;
		          if ( !m_capsuleShadowContainers )
		            sub_1800D8250(v8, v7);
		          *(_OWORD *)&v22._list = key;
		          *(_OWORD *)&v22._current.dataPair.key = v18[0];
		          *(_OWORD *)&v22._current.dataPair.valueStr = v18[1];
		          System::Collections::Generic::List<Beyond::Gameplay::Audio::AudioMapData_AudioLevelGlobalEvents::FEvents>::Add(
		            m_capsuleShadowContainers,
		            (AudioMapData_AudioLevelGlobalEvents_FEvents *)&v22,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v23 )
		      {
		        ex = v23->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v2 = this;
		      }
		    }
		    HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(v2, 0LL);
		  }
		}
		
		private void OnEnable() {} // 0x000000018435D900-0x000000018435D9A0
		// Void OnEnable()
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::OnEnable(HGCapsuleShadowHelper *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGInterationManager *interactionManager_k__BackingField; // rcx
		  List_1_UnityEngine_Matrix4x4_ *m_cachedCapsuleTransforms; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4113, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    HG::Rendering::Runtime::HGCapsuleShadows::EnqueueCapsuleShadowHelper(this, 0LL);
		    if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		    {
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !currentManagerContext )
		        goto LABEL_10;
		      interactionManager_k__BackingField = currentManagerContext->fields._interactionManager_k__BackingField;
		      if ( !interactionManager_k__BackingField )
		        goto LABEL_10;
		      HG::Rendering::Runtime::HGInterationManager::Register(
		        interactionManager_k__BackingField,
		        (IHGInteractionObject *)this,
		        0LL);
		    }
		    HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(this, 0LL);
		    m_cachedCapsuleTransforms = this->fields.m_cachedCapsuleTransforms;
		    if ( m_cachedCapsuleTransforms )
		    {
		      ++m_cachedCapsuleTransforms->fields._version;
		      m_cachedCapsuleTransforms->fields._size = 0;
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(interactionManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4113, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x000000018435D6A0-0x000000018435D730
		// Void OnDisable()
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::OnDisable(HGCapsuleShadowHelper *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGInterationManager *interactionManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4115, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    HG::Rendering::Runtime::HGCapsuleShadows::DequeueCapsuleShadowHelper(this, 0LL);
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      goto LABEL_8;
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
		LABEL_8:
		        HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleListBinding(this, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(interactionManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4115, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void CollectInteractionNodes(List<HGInteractionNode> nodes) {} // 0x0000000182FA6540-0x0000000182FA7580
		// Void CollectInteractionNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::CollectInteractionNodes(
		        HGCapsuleShadowHelper *this,
		        List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
		        MethodInfo *method)
		{
		  Object_1 *size; // rcx
		  __int64 static_fields; // rdx
		  __int64 (__fastcall *v7)(HGCapsuleShadowHelper *, __int64, MethodInfo *); // rax
		  float v8; // xmm9_4
		  __int64 v9; // rbx
		  void (__fastcall *v10)(__int64, unsigned __int64 *); // rax
		  MethodInfo *v11; // r9
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  MethodInfo *v14; // r9
		  Vector3 *v15; // rax
		  unsigned __int64 v16; // xmm12_8
		  float z; // r14d
		  PhysicsScene v18; // eax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // r8
		  struct Math__Class *v22; // rsi
		  int32_t m_Handle; // ebx
		  double v24; // xmm0_8
		  float v25; // xmm0_4
		  float v26; // xmm6_4
		  __m128 v27; // xmm7
		  __m128 v28; // xmm8
		  __m128 v29; // xmm2
		  __m128d v30; // xmm3
		  double v31; // xmm0_8
		  float v32; // xmm0_4
		  float v33; // xmm6_4
		  unsigned __int8 (__fastcall *v34)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD); // rax
		  __m128 v35; // xmm0
		  __int64 (__fastcall *v36)(HGCapsuleShadowHelper *); // rax
		  __int64 v37; // rbx
		  void (__fastcall *v38)(__int64, unsigned __int64 *); // rax
		  List_1_UnityEngine_Matrix4x4_ *m_cachedCapsuleTransforms; // rax
		  float _groundHeight; // xmm11_4
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rax
		  Object *instance; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v43; // r8
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  bool v46; // r12
		  unsigned int j; // ebx
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v48; // rax
		  __m128i v49; // xmm8
		  __m128i v50; // xmm6
		  __m128 v51; // xmm7
		  unsigned __int64 v52; // rsi
		  __int64 (__fastcall *v53)(HGCapsuleShadowHelper *); // rax
		  __int64 v54; // rax
		  __int64 v55; // r14
		  void (__fastcall *v56)(__int64, Matrix4x4 *); // rax
		  MethodInfo *v57; // r9
		  Vector3 *v58; // rax
		  __int64 v59; // xmm3_8
		  void (__fastcall *v60)(Vector3 *, __int128 *); // rax
		  void (__fastcall *v61)(__int64 *, __int128 *, unsigned __int64 *, __int128 *); // rax
		  __int128 v62; // xmm2
		  __int128 v63; // xmm3
		  __int128 v64; // xmm4
		  __int128 v65; // xmm5
		  void (__fastcall *v66)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v67; // xmm6
		  __int128 v68; // xmm8
		  __int128 v69; // xmm9
		  __int128 v70; // xmm10
		  float v71; // eax
		  Matrix4x4 *v72; // rax
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  void (__fastcall *v76)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  List_1_UnityEngine_Matrix4x4_ *v77; // rax
		  Matrix4x4__Array *items; // r8
		  __int64 v79; // rdx
		  Matrix4x4__StaticFields *v80; // rcx
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int128 v84; // xmm0
		  __int128 v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  Vector4 v88; // xmm6
		  __m128 *Column; // rax
		  float x; // xmm3_4
		  float v91; // xmm4_4
		  __m128 v92; // xmm2
		  float v93; // xmm4_4
		  Vector4 v94; // xmm6
		  __m128 *v95; // rax
		  float v96; // xmm3_4
		  float v97; // xmm4_4
		  float v98; // xmm1_4
		  __m128 v99; // xmm2
		  float v100; // xmm4_4
		  float v101; // xmm0_4
		  Vector4 v102; // xmm6
		  __m128 *v103; // rax
		  float v104; // xmm3_4
		  float v105; // xmm4_4
		  float v106; // xmm1_4
		  __m128 v107; // xmm2
		  float v108; // xmm4_4
		  float v109; // xmm0_4
		  Vector4 v110; // xmm6
		  __m128 *v111; // rax
		  float v112; // xmm3_4
		  float v113; // xmm4_4
		  float v114; // xmm1_4
		  __m128 v115; // xmm2
		  float v116; // xmm4_4
		  float v117; // xmm0_4
		  __int128 v118; // xmm2
		  __int64 v119; // rax
		  float v120; // xmm6_4
		  float v121; // xmm7_4
		  struct Object_1__Class *v122; // rcx
		  __int64 v123; // rsi
		  int32_t v124; // r14d
		  bool _ccd; // si
		  struct ILFixDynamicMethodWrapper_2__Class *v126; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGInteractionNode *v128; // rax
		  __int128 v129; // xmm1
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  __int128 v133; // xmm1
		  __int128 v134; // xmm0
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  __int128 v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v141; // rax
		  __int128 v142; // xmm1
		  __int128 v143; // xmm0
		  __int128 v144; // xmm1
		  ILFixDynamicMethodWrapper_2 *v145; // rax
		  __int64 v146; // rax
		  __int64 v147; // rax
		  __int64 v148; // rax
		  __int64 v149; // rax
		  __int64 v150; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v152; // rax
		  Matrix4x4 *v153; // rax
		  ILFixDynamicMethodWrapper_2 *v154; // rax
		  Matrix4x4 *v155; // rax
		  ILFixDynamicMethodWrapper_2 *v156; // rax
		  __int128 v157; // xmm1
		  __int128 v158; // xmm0
		  __int128 v159; // xmm1
		  __int64 v160; // rax
		  __int64 v161; // rax
		  __int64 v162; // rax
		  __int64 v163; // rax
		  __int64 v164; // rax
		  __int64 v165; // rax
		  unsigned __int64 v166; // [rsp+50h] [rbp-B0h] BYREF
		  float v167; // [rsp+58h] [rbp-A8h]
		  Vector3 v168; // [rsp+60h] [rbp-A0h] BYREF
		  Matrix4x4 v169; // [rsp+70h] [rbp-90h] BYREF
		  Vector3 v170; // [rsp+B0h] [rbp-50h] BYREF
		  Matrix4x4 v171; // [rsp+C0h] [rbp-40h] BYREF
		  Vector3 v172; // [rsp+100h] [rbp+0h] BYREF
		  Matrix4x4 _transform; // [rsp+110h] [rbp+10h] BYREF
		  __int64 v174; // [rsp+150h] [rbp+50h] BYREF
		  int v175; // [rsp+158h] [rbp+58h]
		  Matrix4x4 v176; // [rsp+160h] [rbp+60h] BYREF
		  Matrix4x4 _prevTransform; // [rsp+1A0h] [rbp+A0h] BYREF
		  __m128 v178; // [rsp+1E0h] [rbp+E0h] BYREF
		  __int128 v179; // [rsp+1F8h] [rbp+F8h] BYREF
		  __m128 v180; // [rsp+210h] [rbp+110h] BYREF
		  unsigned __int64 v181; // [rsp+220h] [rbp+120h]
		  __int128 v182; // [rsp+230h] [rbp+130h] BYREF
		  __int128 v183; // [rsp+240h] [rbp+140h]
		  __int128 v184; // [rsp+250h] [rbp+150h]
		  __int128 v185; // [rsp+260h] [rbp+160h]
		  __int128 v186; // [rsp+270h] [rbp+170h] BYREF
		  __int128 v187; // [rsp+280h] [rbp+180h] BYREF
		  __int128 v188; // [rsp+290h] [rbp+190h]
		  __int128 v189; // [rsp+2A0h] [rbp+1A0h]
		  __int128 v190; // [rsp+2B0h] [rbp+1B0h]
		  Vector3 v191; // [rsp+2C0h] [rbp+1C0h] BYREF
		  Vector4 v192; // [rsp+2D0h] [rbp+1D0h] BYREF
		  Vector4 v193; // [rsp+2E0h] [rbp+1E0h] BYREF
		  Vector4 v194; // [rsp+2F0h] [rbp+1F0h] BYREF
		  Vector4 v195; // [rsp+300h] [rbp+200h] BYREF
		  Vector4 v196; // [rsp+310h] [rbp+210h] BYREF
		  Vector4 v197; // [rsp+320h] [rbp+220h] BYREF
		  __m256i v198; // [rsp+340h] [rbp+240h]
		  HGInteractionNode v199; // [rsp+360h] [rbp+260h] BYREF
		  Matrix4x4 v200; // [rsp+420h] [rbp+320h] BYREF
		  Matrix4x4 v201; // [rsp+460h] [rbp+360h] BYREF
		  HGInteractionNode v202; // [rsp+4A0h] [rbp+3A0h] BYREF
		  HGInteractionNode v203; // [rsp+560h] [rbp+460h] BYREF
		  int32_t v204; // [rsp+6F8h] [rbp+5F8h] BYREF
		
		  size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  memset(&_transform, 0, sizeof(_transform));
		  memset(&_prevTransform, 0, sizeof(_prevTransform));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = *(_QWORD *)size[7].fields.m_CachedPtr;
		  if ( !static_fields )
		    goto LABEL_98;
		  if ( *(int *)(static_fields + 24) <= 4120 )
		    goto LABEL_5;
		  if ( !LODWORD(size[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(size);
		    size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = *(_QWORD *)size[7].fields.m_CachedPtr;
		  if ( !static_fields )
		    goto LABEL_98;
		  if ( *(_DWORD *)(static_fields + 24) <= 0x1018u )
		    goto LABEL_111;
		  if ( !*(_QWORD *)(static_fields + 32992) )
		  {
		LABEL_5:
		    v7 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, MethodInfo *))qword_18F36FBC0;
		    v8 = 32.5;
		    if ( !qword_18F36FBC0 )
		    {
		      v7 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                     "UnityEngine.Component::get_transform()");
		      if ( !v7 )
		      {
		        v146 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v146, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v7;
		    }
		    v9 = v7(this, static_fields, method);
		    if ( !v9 )
		      goto LABEL_98;
		    v166 = 0LL;
		    v167 = 0.0;
		    v10 = (void (__fastcall *)(__int64, unsigned __int64 *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v10 = (void (__fastcall *)(__int64, unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v10 )
		      {
		        v147 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v147, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v10;
		    }
		    v10(v9, &v166);
		    v168.z = 0.0;
		    *(_QWORD *)&v168.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v12 = UnityEngine::Vector3::op_Multiply(&v172, &v168, 0.5, v11);
		    *(_QWORD *)&v170.x = v166;
		    v13 = *(_QWORD *)&v12->x;
		    v168.z = v12->z;
		    v170.z = v167;
		    *(_QWORD *)&v168.x = v13;
		    v15 = UnityEngine::Vector3::op_Addition(&v172, &v170, &v168, v14);
		    v16 = *(_QWORD *)&v15->x;
		    z = v15->z;
		    v18.m_Handle = UnityEngine::Physics::get_defaultPhysicsScene(0LL).m_Handle;
		    v22 = TypeInfo::System::Math;
		    v187 = 0LL;
		    m_Handle = v18.m_Handle;
		    v188 = 0LL;
		    v189 = 0LL;
		    v190 = 0LL;
		    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		      v22 = TypeInfo::System::Math;
		    }
		    if ( 1.0 < 0.0 )
		      v24 = sub_1801D32D0(v20, v19, v21);
		    else
		      *(_QWORD *)&v24 = *(_OWORD *)&_mm_sqrt_pd((__m128d)0x3FF0000000000000uLL);
		    v25 = v24;
		    if ( v25 > COERCE_FLOAT(1) )
		    {
		      v27 = (__m128)0xBF800000;
		      v28 = 0LL;
		      v26 = 0.0 / v25;
		      v27.m128_f32[0] = -1.0 / v25;
		      v28.m128_f32[0] = 0.0 / v25;
		      v178.m128_u64[0] = v16;
		      v178.m128_f32[2] = z;
		      if ( !v22->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v22);
		      v29 = v27;
		      v29.m128_f32[0] = (float)((float)(v27.m128_f32[0] * v27.m128_f32[0]) + (float)(v26 * v26))
		                      + (float)(v28.m128_f32[0] * v28.m128_f32[0]);
		      v30 = _mm_cvtps_pd(v29);
		      if ( v30.m128d_f64[0] < 0.0 )
		        v31 = sub_1801D32D0(v20, v19, v21);
		      else
		        *(_QWORD *)&v31 = *(_OWORD *)&_mm_sqrt_pd(v30);
		      v32 = v31;
		      if ( v32 <= 0.0000099999997 )
		      {
		        v33 = 0.0;
		        v27 = 0LL;
		        v28 = 0LL;
		      }
		      else
		      {
		        v33 = v26 / v32;
		        v27.m128_f32[0] = v27.m128_f32[0] / v32;
		        v28.m128_f32[0] = v28.m128_f32[0] / v32;
		      }
		      v34 = (unsigned __int8 (__fastcall *)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD))qword_18F371040;
		      v35 = _mm_shuffle_ps(v178, v178, 147);
		      v181 = _mm_unpacklo_ps(v27, v28).m128_u64[0];
		      v35.m128_f32[0] = v33;
		      v180 = _mm_shuffle_ps(v35, v35, 57);
		      v204 = m_Handle;
		      v178 = v180;
		      if ( !qword_18F371040 )
		      {
		        v34 = (unsigned __int8 (__fastcall *)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD))il2cpp_resolve_icall_1("UnityEngine.PhysicsScene::Internal_Raycast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)");
		        if ( !v34 )
		        {
		          v148 = sub_1802EE1B8(
		                   "UnityEngine.PhysicsScene::Internal_Raycast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,System"
		                   ".Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)");
		          sub_18007E1B0(v148, 0LL);
		        }
		        qword_18F371040 = (__int64)v34;
		      }
		      if ( v34(&v204, &v180, v21, &v187, -5, 0) )
		        v8 = *((float *)&v188 + 3) - 0.5;
		    }
		    v36 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v36 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v36 )
		      {
		        v149 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v149, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v36;
		    }
		    v37 = v36(this);
		    if ( !v37 )
		      goto LABEL_98;
		    v166 = 0LL;
		    v167 = 0.0;
		    v38 = (void (__fastcall *)(__int64, unsigned __int64 *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v38 = (void (__fastcall *)(__int64, unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v38 )
		      {
		        v150 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v150, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v38;
		    }
		    v38(v37, &v166);
		    m_cachedCapsuleTransforms = this->fields.m_cachedCapsuleTransforms;
		    _groundHeight = *((float *)&v166 + 1) - v8;
		    if ( !m_cachedCapsuleTransforms )
		      goto LABEL_98;
		    size = (Object_1 *)(unsigned int)m_cachedCapsuleTransforms->fields._size;
		    m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		    if ( !m_capsuleShadowContainers )
		      goto LABEL_98;
		    if ( (_DWORD)size != m_capsuleShadowContainers->fields._size )
		    {
		      size = (Object_1 *)this->fields.m_cachedCapsuleTransforms;
		      ++HIDWORD(size[1].klass);
		      LODWORD(size[1].klass) = 0;
		      for ( i = 0; ; ++i )
		      {
		        v141 = this->fields.m_capsuleShadowContainers;
		        if ( !v141 )
		          break;
		        if ( i >= v141->fields._size )
		          goto LABEL_28;
		        size = (Object_1 *)this->fields.m_cachedCapsuleTransforms;
		        static_fields = (__int64)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		        if ( !size )
		          break;
		        v142 = *(_OWORD *)(static_fields + 80);
		        *(_OWORD *)&v169.m00 = *(_OWORD *)(static_fields + 64);
		        v143 = *(_OWORD *)(static_fields + 96);
		        *(_OWORD *)&v169.m01 = v142;
		        v144 = *(_OWORD *)(static_fields + 112);
		        *(_OWORD *)&v169.m02 = v143;
		        *(_OWORD *)&v169.m03 = v144;
		        sub_1839043E0(size, &v169, MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::Add);
		      }
		      goto LABEL_98;
		    }
		LABEL_28:
		    instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( !instance )
		      goto LABEL_98;
		    v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    size = (Object_1 *)v43->static_fields;
		    if ( !size->klass )
		      goto LABEL_98;
		    if ( SLODWORD(size->klass->_0.namespaze) <= 672 )
		      goto LABEL_33;
		    if ( !v43->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v43);
		      v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (__int64)v43->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_98;
		    if ( *(_DWORD *)(static_fields + 24) > 0x2A0u )
		    {
		      if ( *(_QWORD *)(static_fields + 5408) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		        if ( Patch )
		        {
		          namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                        (ILFixDynamicMethodWrapper_31 *)Patch,
		                        instance,
		                        0LL);
		          v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          goto LABEL_35;
		        }
		LABEL_98:
		        sub_1800D8260(size, static_fields);
		      }
		LABEL_33:
		      klass = instance[1].klass;
		      if ( klass )
		      {
		        namespaze = (int32_t)klass->_0.namespaze;
		LABEL_35:
		        v46 = namespaze == 1;
		        for ( j = 0; ; ++j )
		        {
		          v48 = this->fields.m_capsuleShadowContainers;
		          if ( !v48 )
		            goto LABEL_98;
		          if ( (signed int)j >= v48->fields._size )
		            return;
		          if ( j >= v48->fields._size )
		LABEL_190:
		            System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		          size = (Object_1 *)v48->fields._items;
		          if ( !size )
		            goto LABEL_98;
		          if ( j >= LODWORD(size[1].klass) )
		            goto LABEL_111;
		          static_fields = 6LL * (int)j;
		          v49 = *(__m128i *)&size[2 * (int)j + 2].fields.m_CachedPtr;
		          v50 = *(__m128i *)&size[2 * (int)j + 2].klass;
		          v51 = *(__m128 *)&size[2 * (int)j + 1].monitor;
		          *(__m128i *)v198.m256i_i8 = v50;
		          *(__m128i *)&v198.m256i_u64[2] = v49;
		          *(__m128 *)&v171.m00 = v51;
		          *(__m128i *)&v171.m01 = v50;
		          if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v49, 12)) )
		          {
		            v52 = v51.m128_u64[0];
		            if ( v46 )
		            {
		              size = (Object_1 *)size[2 * (int)j + 1].monitor;
		              *(__m128i *)&v171.m01 = v50;
		              *(__m128i *)&v171.m02 = v49;
		              if ( !size )
		                goto LABEL_98;
		              if ( !UnityEngine::Object::CompareName(size, this->fields.m_skeletonName_Ankle_L, 0LL) )
		              {
		                if ( !v51.m128_u64[0] )
		                  goto LABEL_98;
		                if ( !UnityEngine::Object::CompareName(
		                        (Object_1 *)v51.m128_u64[0],
		                        this->fields.m_skeletonName_Ankle_R,
		                        0LL) )
		                  goto LABEL_94;
		              }
		              v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            if ( !v43->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v43);
		              v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            static_fields = (__int64)v43->static_fields->wrapperArray;
		            if ( !static_fields )
		              goto LABEL_98;
		            if ( *(int *)(static_fields + 24) <= 2089 )
		              goto LABEL_47;
		            if ( !v43->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v43);
		              v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            size = (Object_1 *)v43->static_fields->wrapperArray;
		            if ( !size )
		              goto LABEL_98;
		            if ( LODWORD(size[1].klass) <= 0x829 )
		              goto LABEL_111;
		            if ( size[697].fields.m_CachedPtr )
		            {
		              v152 = IFix::WrappersManagerImpl::GetPatch(2089, 0LL);
		              if ( !v152 )
		                goto LABEL_98;
		              *(__m128 *)&v171.m00 = v51;
		              *(__m128i *)&v171.m01 = v50;
		              *(__m128i *)&v171.m02 = v49;
		              v153 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(
		                       &v176,
		                       v152,
		                       (Object *)this,
		                       (HGCapsuleShadowContainer *)&v171,
		                       0LL);
		              v67 = *(_OWORD *)&v153->m00;
		              v68 = *(_OWORD *)&v153->m01;
		              v69 = *(_OWORD *)&v153->m02;
		              v70 = *(_OWORD *)&v153->m03;
		            }
		            else
		            {
		LABEL_47:
		              v53 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))qword_18F36FBC0;
		              if ( !qword_18F36FBC0 )
		              {
		                v53 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		                if ( !v53 )
		                {
		                  v160 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		                  sub_18007E1B0(v160, 0LL);
		                }
		                qword_18F36FBC0 = (__int64)v53;
		              }
		              v54 = v53(this);
		              size = (Object_1 *)TypeInfo::UnityEngine::Object;
		              v55 = v54;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                size = (Object_1 *)TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  size = (Object_1 *)TypeInfo::UnityEngine::Object;
		                }
		              }
		              if ( v51.m128_u64[0] )
		              {
		                if ( !LODWORD(size[9].monitor) )
		                  il2cpp_runtime_class_init_1(size);
		                if ( *(_QWORD *)(v51.m128_u64[0] + 16) )
		                  v55 = v51.m128_u64[0];
		              }
		              if ( !v55 )
		                goto LABEL_98;
		              v56 = (void (__fastcall *)(__int64, Matrix4x4 *))qword_18F370148;
		              memset(&v169, 0, sizeof(v169));
		              if ( !qword_18F370148 )
		              {
		                v56 = (void (__fastcall *)(__int64, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.Transform::get_localToWorldMatrix_Injecte"
		                                                                   "d(UnityEngine.Matrix4x4&)");
		                if ( !v56 )
		                {
		                  v161 = sub_1802EE1B8("UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
		                  sub_18007E1B0(v161, 0LL);
		                }
		                qword_18F370148 = (__int64)v56;
		              }
		              v56(v55, &v169);
		              size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		                size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              static_fields = *(_QWORD *)size[7].fields.m_CachedPtr;
		              if ( !static_fields )
		                goto LABEL_98;
		              if ( *(int *)(static_fields + 24) <= 2090 )
		                goto LABEL_60;
		              if ( !LODWORD(size[9].monitor) )
		              {
		                il2cpp_runtime_class_init_1(size);
		                size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              size = *(Object_1 **)size[7].fields.m_CachedPtr;
		              if ( !size )
		                goto LABEL_98;
		              if ( LODWORD(size[1].klass) <= 0x82A )
		                goto LABEL_111;
		              if ( size[698].klass )
		              {
		                v154 = IFix::WrappersManagerImpl::GetPatch(2090, 0LL);
		                if ( !v154 )
		                  goto LABEL_98;
		                *(__m128 *)&v171.m00 = v51;
		                *(__m128i *)&v171.m01 = v50;
		                *(__m128i *)&v171.m02 = v49;
		                v155 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(
		                         &v200,
		                         v154,
		                         (Object *)this,
		                         (HGCapsuleShadowContainer *)&v171,
		                         0LL);
		                v62 = *(_OWORD *)&v155->m00;
		                v63 = *(_OWORD *)&v155->m01;
		                v64 = *(_OWORD *)&v155->m02;
		                v65 = *(_OWORD *)&v155->m03;
		              }
		              else
		              {
		LABEL_60:
		                *(_QWORD *)&v170.x = *(__int64 *)((char *)&v198.m256i_i64[1] + 4);
		                LODWORD(v170.z) = _mm_cvtsi128_si32(_mm_srli_si128(v49, 4));
		                v58 = UnityEngine::Vector3::op_Multiply(&v191, &v170, 0.017453292, v57);
		                v179 = 0LL;
		                v59 = *(_QWORD *)&v58->x;
		                v168.z = v58->z;
		                v60 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18F36FAC8;
		                *(_QWORD *)&v168.x = v59;
		                if ( !qword_18F36FAC8 )
		                {
		                  v60 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                      "UnityEngine.Quaternion::Internal_FromEulerRad_Inje"
		                                                                      "cted(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		                  if ( !v60 )
		                  {
		                    v162 = sub_1802EE1B8(
		                             "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		                    sub_18007E1B0(v162, 0LL);
		                  }
		                  qword_18F36FAC8 = (__int64)v60;
		                }
		                v60(&v168, &v179);
		                v61 = (void (__fastcall *)(__int64 *, __int128 *, unsigned __int64 *, __int128 *))qword_18F36FA58;
		                v166 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		                v174 = v50.m128i_i64[0];
		                v167 = 1.0;
		                v175 = _mm_cvtsi128_si32(_mm_srli_si128(v50, 8));
		                v186 = v179;
		                v182 = 0LL;
		                v183 = 0LL;
		                v184 = 0LL;
		                v185 = 0LL;
		                if ( !qword_18F36FA58 )
		                {
		                  v61 = (void (__fastcall *)(__int64 *, __int128 *, unsigned __int64 *, __int128 *))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
		                  if ( !v61 )
		                  {
		                    v163 = sub_1802EE1B8(
		                             "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngin"
		                             "e.Vector3&,UnityEngine.Matrix4x4&)");
		                    sub_18007E1B0(v163, 0LL);
		                  }
		                  qword_18F36FA58 = (__int64)v61;
		                }
		                v61(&v174, &v186, &v166, &v182);
		                v62 = v182;
		                v63 = v183;
		                v64 = v184;
		                v65 = v185;
		              }
		              v66 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		              *(_OWORD *)&v171.m00 = v62;
		              v176 = v169;
		              *(_OWORD *)&v171.m01 = v63;
		              *(_OWORD *)&v171.m02 = v64;
		              *(_OWORD *)&v171.m03 = v65;
		              memset(&v169, 0, sizeof(v169));
		              if ( !qword_18F36FA50 )
		              {
		                v66 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                    "UnityEngine.Matrix4x4::HGMultiplyMat"
		                                                                                    "rix4x4Fast_Injected(UnityEngine.Matr"
		                                                                                    "ix4x4&,UnityEngine.Matrix4x4&,UnityE"
		                                                                                    "ngine.Matrix4x4&)");
		                if ( !v66 )
		                {
		                  v164 = sub_1802EE1B8(
		                           "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Ma"
		                           "trix4x4&,UnityEngine.Matrix4x4&)");
		                  sub_18007E1B0(v164, 0LL);
		                }
		                qword_18F36FA50 = (__int64)v66;
		              }
		              v66(&v176, &v171, &v169);
		              v67 = *(_OWORD *)&v169.m00;
		              v68 = *(_OWORD *)&v169.m01;
		              v69 = *(_OWORD *)&v169.m02;
		              v70 = *(_OWORD *)&v169.m03;
		            }
		            v71 = this->fields.m_centerOffset.z;
		            *(_QWORD *)&v172.x = *(_QWORD *)&this->fields.m_centerOffset.x;
		            *(_OWORD *)&_transform.m00 = v67;
		            *(_OWORD *)&_transform.m01 = v68;
		            *(_OWORD *)&_transform.m02 = v69;
		            *(_OWORD *)&_transform.m03 = v70;
		            v172.z = v71;
		            v72 = UnityEngine::Matrix4x4::Translate(&v201, &v172, 0LL);
		            *(_OWORD *)&v176.m00 = v67;
		            *(_OWORD *)&v176.m01 = v68;
		            *(_OWORD *)&v176.m02 = v69;
		            v73 = *(_OWORD *)&v72->m01;
		            *(_OWORD *)&v171.m00 = *(_OWORD *)&v72->m00;
		            v74 = *(_OWORD *)&v72->m02;
		            *(_OWORD *)&v171.m01 = v73;
		            v75 = *(_OWORD *)&v72->m03;
		            v76 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		            *(_OWORD *)&v171.m02 = v74;
		            *(_OWORD *)&v171.m03 = v75;
		            *(_OWORD *)&v176.m03 = v70;
		            memset(&v169, 0, sizeof(v169));
		            if ( !qword_18F36FA50 )
		            {
		              v76 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                  "UnityEngine.Matrix4x4::HGMultiplyMatri"
		                                                                                  "x4x4Fast_Injected(UnityEngine.Matrix4x"
		                                                                                  "4&,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		              if ( !v76 )
		              {
		                v165 = sub_1802EE1B8(
		                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matr"
		                         "ix4x4&,UnityEngine.Matrix4x4&)");
		                sub_18007E1B0(v165, 0LL);
		              }
		              qword_18F36FA50 = (__int64)v76;
		            }
		            v76(&v171, &v176, &v169);
		            v77 = this->fields.m_cachedCapsuleTransforms;
		            _transform = v169;
		            if ( !v77 )
		              goto LABEL_98;
		            if ( j >= v77->fields._size )
		              goto LABEL_190;
		            items = v77->fields._items;
		            if ( !items )
		              goto LABEL_98;
		            if ( j >= items->max_length.size )
		              goto LABEL_111;
		            v79 = (__int64)(int)j << 6;
		            _prevTransform = *(Matrix4x4 *)((char *)items->vector + v79);
		            v80 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		            v81 = *(_OWORD *)&v80->identityMatrix.m01;
		            *(_OWORD *)&v171.m00 = *(_OWORD *)&v80->identityMatrix.m00;
		            v82 = *(_OWORD *)&v80->identityMatrix.m02;
		            *(_OWORD *)&v171.m01 = v81;
		            v83 = *(_OWORD *)&v80->identityMatrix.m03;
		            *(_OWORD *)&v171.m02 = v82;
		            v84 = *(_OWORD *)((char *)&items->vector[0].m00 + v79);
		            *(_OWORD *)&v171.m03 = v83;
		            v85 = *(_OWORD *)((char *)&items->vector[0].m01 + v79);
		            *(_OWORD *)&v169.m00 = v84;
		            v86 = *(_OWORD *)((char *)&items->vector[0].m02 + v79);
		            *(_OWORD *)&v169.m01 = v85;
		            v87 = *(_OWORD *)((char *)&items->vector[0].m03 + v79);
		            *(_OWORD *)&v169.m02 = v86;
		            *(_OWORD *)&v169.m03 = v87;
		            v88 = *UnityEngine::Matrix4x4::GetColumn(&v192, &v169, 0, 0LL);
		            Column = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v193, &v171, 0, 0LL);
		            x = v88.x;
		            v91 = _mm_shuffle_ps((__m128)v88, (__m128)v88, 85).m128_f32[0];
		            *(float *)&v87 = _mm_shuffle_ps((__m128)v88, (__m128)v88, 170).m128_f32[0];
		            v92 = *Column;
		            v88.x = _mm_shuffle_ps((__m128)v88, (__m128)v88, 255).m128_f32[0];
		            v93 = v91 - _mm_shuffle_ps(v92, v92, 85).m128_f32[0];
		            *(float *)&v86 = _mm_shuffle_ps(*Column, *Column, 170).m128_f32[0];
		            v92.m128_f32[0] = _mm_shuffle_ps(v92, v92, 255).m128_f32[0];
		            if ( (float)((float)((float)((float)(v93 * v93)
		                                       + (float)((float)(x - COERCE_FLOAT(*Column)) * (float)(x - COERCE_FLOAT(*Column))))
		                               + (float)((float)(*(float *)&v87 - *(float *)&v86)
		                                       * (float)(*(float *)&v87 - *(float *)&v86)))
		                       + (float)((float)(v88.x - v92.m128_f32[0]) * (float)(v88.x - v92.m128_f32[0]))) >= 9.9999994e-11 )
		              goto LABEL_74;
		            v94 = *UnityEngine::Matrix4x4::GetColumn(&v194, &v169, 1, 0LL);
		            v95 = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v195, &v171, 1, 0LL);
		            v96 = v94.x;
		            v97 = _mm_shuffle_ps((__m128)v94, (__m128)v94, 85).m128_f32[0];
		            v98 = _mm_shuffle_ps((__m128)v94, (__m128)v94, 170).m128_f32[0];
		            v99 = *v95;
		            v94.x = _mm_shuffle_ps((__m128)v94, (__m128)v94, 255).m128_f32[0];
		            v100 = v97 - _mm_shuffle_ps(v99, v99, 85).m128_f32[0];
		            v101 = _mm_shuffle_ps(*v95, *v95, 170).m128_f32[0];
		            v99.m128_f32[0] = _mm_shuffle_ps(v99, v99, 255).m128_f32[0];
		            if ( (float)((float)((float)((float)(v100 * v100)
		                                       + (float)((float)(v96 - COERCE_FLOAT(*v95)) * (float)(v96 - COERCE_FLOAT(*v95))))
		                               + (float)((float)(v98 - v101) * (float)(v98 - v101)))
		                       + (float)((float)(v94.x - v99.m128_f32[0]) * (float)(v94.x - v99.m128_f32[0]))) >= 9.9999994e-11 )
		              goto LABEL_74;
		            v102 = *UnityEngine::Matrix4x4::GetColumn(&v196, &v169, 2, 0LL);
		            v103 = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v197, &v171, 2, 0LL);
		            v104 = v102.x;
		            v105 = _mm_shuffle_ps((__m128)v102, (__m128)v102, 85).m128_f32[0];
		            v106 = _mm_shuffle_ps((__m128)v102, (__m128)v102, 170).m128_f32[0];
		            v107 = *v103;
		            v102.x = _mm_shuffle_ps((__m128)v102, (__m128)v102, 255).m128_f32[0];
		            v108 = v105 - _mm_shuffle_ps(v107, v107, 85).m128_f32[0];
		            v109 = _mm_shuffle_ps(*v103, *v103, 170).m128_f32[0];
		            v107.m128_f32[0] = _mm_shuffle_ps(v107, v107, 255).m128_f32[0];
		            if ( (float)((float)((float)((float)(v108 * v108)
		                                       + (float)((float)(v104 - COERCE_FLOAT(*v103))
		                                               * (float)(v104 - COERCE_FLOAT(*v103))))
		                               + (float)((float)(v106 - v109) * (float)(v106 - v109)))
		                       + (float)((float)(v102.x - v107.m128_f32[0]) * (float)(v102.x - v107.m128_f32[0]))) >= 9.9999994e-11 )
		              goto LABEL_74;
		            v110 = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v180, &v169, 3, 0LL);
		            v111 = (__m128 *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v178, &v171, 3, 0LL);
		            v112 = v110.x;
		            v113 = _mm_shuffle_ps((__m128)v110, (__m128)v110, 85).m128_f32[0];
		            v114 = _mm_shuffle_ps((__m128)v110, (__m128)v110, 170).m128_f32[0];
		            v115 = *v111;
		            v110.x = _mm_shuffle_ps((__m128)v110, (__m128)v110, 255).m128_f32[0];
		            v116 = v113 - _mm_shuffle_ps(v115, v115, 85).m128_f32[0];
		            v117 = _mm_shuffle_ps(*v111, *v111, 170).m128_f32[0];
		            v115.m128_f32[0] = _mm_shuffle_ps(v115, v115, 255).m128_f32[0];
		            if ( (float)((float)((float)((float)(v116 * v116)
		                                       + (float)((float)(v112 - COERCE_FLOAT(*v111))
		                                               * (float)(v112 - COERCE_FLOAT(*v111))))
		                               + (float)((float)(v114 - v117) * (float)(v114 - v117)))
		                       + (float)((float)(v110.x - v115.m128_f32[0]) * (float)(v110.x - v115.m128_f32[0]))) < 9.9999994e-11 )
		            {
		              v118 = *(_OWORD *)&_transform.m00;
		              _prevTransform = _transform;
		            }
		            else
		            {
		LABEL_74:
		              v118 = *(_OWORD *)&_transform.m00;
		            }
		            static_fields = (__int64)this->fields.m_cachedCapsuleTransforms;
		            if ( !static_fields )
		              goto LABEL_98;
		            if ( j >= *(_DWORD *)(static_fields + 24) )
		              goto LABEL_190;
		            size = *(Object_1 **)(static_fields + 16);
		            if ( !size )
		              goto LABEL_98;
		            if ( j >= LODWORD(size[1].klass) )
		              goto LABEL_111;
		            v119 = (__int64)(int)j << 6;
		            *(_OWORD *)((char *)&size[1].monitor + v119) = v118;
		            *(_OWORD *)((char *)&size[2].klass + v119) = *(_OWORD *)&_transform.m01;
		            *(_OWORD *)((char *)&size[2].fields.m_CachedPtr + v119) = *(_OWORD *)&_transform.m02;
		            *(_OWORD *)((char *)&size[3].monitor + v119) = *(_OWORD *)&_transform.m03;
		            ++*(_DWORD *)(static_fields + 28);
		            v120 = _mm_shuffle_ps(v51, v51, 170).m128_f32[0] * this->fields.m_radiusScale;
		            v121 = _mm_shuffle_ps(v51, v51, 255).m128_f32[0] * this->fields.m_heightScale;
		            if ( !v52 )
		              goto LABEL_98;
		            if ( *(_QWORD *)(v52 + 16) )
		            {
		              v122 = TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v122 = TypeInfo::UnityEngine::Object;
		              }
		              if ( v122->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		              {
		                if ( !v122->_1.cctor_finished_or_no_cctor )
		                  il2cpp_runtime_class_init_1(v122);
		                TypeInfo::UnityEngine::Object->static_fields->OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		                v122 = TypeInfo::UnityEngine::Object;
		              }
		              v123 = *(_QWORD *)(v52 + 16);
		              if ( !v122->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v122);
		                v122 = TypeInfo::UnityEngine::Object;
		              }
		              v124 = *(_DWORD *)(v122->static_fields->OffsetOfInstanceIDInCPlusPlusObject + v123);
		            }
		            else
		            {
		              v124 = 0;
		            }
		            _ccd = this->fields.m_enableCCD;
		            sub_18033B9D0(&v199, 0LL, 192LL);
		            v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		              v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = v126->static_fields->wrapperArray;
		            if ( !wrapperArray )
		LABEL_110:
		              sub_1800D8260(v126, wrapperArray);
		            if ( wrapperArray->max_length.size <= 1802 )
		              goto LABEL_91;
		            if ( !v126->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v126);
		              v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v126 = (struct ILFixDynamicMethodWrapper_2__Class *)v126->static_fields->wrapperArray;
		            if ( !v126 )
		              goto LABEL_110;
		            if ( LODWORD(v126->_0.namespaze) <= 0x70A )
		              sub_1800D2AB0(v126, wrapperArray);
		            if ( v126[38]._0.nestedTypes )
		            {
		              v156 = IFix::WrappersManagerImpl::GetPatch(1802, 0LL);
		              if ( !v156 )
		                goto LABEL_110;
		              v128 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_724(
		                       &v203,
		                       v156,
		                       v124,
		                       v121,
		                       v120,
		                       &_transform,
		                       &_prevTransform,
		                       _groundHeight,
		                       _ccd,
		                       0LL);
		            }
		            else
		            {
		LABEL_91:
		              sub_18033B9D0(&v199, 0LL, 192LL);
		              HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
		                &v199,
		                v124,
		                v121,
		                v120,
		                &_transform,
		                &_prevTransform,
		                _groundHeight,
		                _ccd,
		                0LL);
		              v128 = &v199;
		            }
		            size = (Object_1 *)&v202;
		            v129 = *(_OWORD *)&v128->localToWorldMatrix.m20;
		            *(_OWORD *)&v202.NodeKey = *(_OWORD *)&v128->NodeKey;
		            v130 = *(_OWORD *)&v128->localToWorldMatrix.m21;
		            *(_OWORD *)&v202.localToWorldMatrix.m20 = v129;
		            v131 = *(_OWORD *)&v128->localToWorldMatrix.m22;
		            *(_OWORD *)&v202.localToWorldMatrix.m21 = v130;
		            v132 = *(_OWORD *)&v128->localToWorldMatrix.m23;
		            *(_OWORD *)&v202.localToWorldMatrix.m22 = v131;
		            v133 = *(_OWORD *)&v128->prevLocalToWorldMatrix.m20;
		            *(_OWORD *)&v202.localToWorldMatrix.m23 = v132;
		            v134 = *(_OWORD *)&v128->prevLocalToWorldMatrix.m21;
		            *(_OWORD *)&v202.prevLocalToWorldMatrix.m20 = v133;
		            v135 = *(_OWORD *)&v128->prevLocalToWorldMatrix.m22;
		            *(_OWORD *)&v202.prevLocalToWorldMatrix.m21 = v134;
		            v136 = *(_OWORD *)&v128->prevLocalToWorldMatrix.m23;
		            *(_OWORD *)&v202.prevLocalToWorldMatrix.m22 = v135;
		            v137 = *(_OWORD *)&v128->length;
		            *(_OWORD *)&v202.prevLocalToWorldMatrix.m23 = v136;
		            v138 = *(_OWORD *)&v128->texture;
		            *(_OWORD *)&v202.length = v137;
		            v139 = *(_OWORD *)&v128->heightScale;
		            *(_OWORD *)&v202.texture = v138;
		            *(_OWORD *)&v202.heightScale = v139;
		            if ( !nodes )
		              goto LABEL_98;
		            v199 = v202;
		            sub_1837F8DB0(
		              nodes,
		              &v199,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
		          }
		          else
		          {
		            size = (Object_1 *)this->fields.m_cachedCapsuleTransforms;
		            static_fields = (__int64)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		            if ( !size )
		              goto LABEL_98;
		            v157 = *(_OWORD *)(static_fields + 80);
		            *(_OWORD *)&v176.m00 = *(_OWORD *)(static_fields + 64);
		            v158 = *(_OWORD *)(static_fields + 96);
		            *(_OWORD *)&v176.m01 = v157;
		            v159 = *(_OWORD *)(static_fields + 112);
		            *(_OWORD *)&v176.m02 = v158;
		            *(_OWORD *)&v176.m03 = v159;
		            sub_180363014(
		              size,
		              j,
		              &v176,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::set_Item);
		          }
		LABEL_94:
		          v43 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		      }
		      goto LABEL_98;
		    }
		LABEL_111:
		    sub_1800D2AB0(size, static_fields);
		  }
		  v145 = IFix::WrappersManagerImpl::GetPatch(4120, 0LL);
		  if ( !v145 )
		    goto LABEL_98;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)v145,
		    (Object *)this,
		    (Object *)nodes,
		    0LL);
		}
		
		private void AddCapsuleBinding(HGCapsuleShadowContainer container) {} // 0x000000018351FAF0-0x000000018351FDE0
		// Void AddCapsuleBinding(HGCapsuleShadowContainer)
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleBinding(
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  struct Object_1__Class *v6; // rcx
		  bool v7; // r14
		  __int128 v8; // xmm1
		  bool v9; // zf
		  __int128 v10; // xmm6
		  Component *rootTransform; // rcx
		  __int128 v12; // xmm1
		  GameObject *v13; // rax
		  Object *v14; // rax
		  Object *v15; // rdi
		  __int128 v16; // xmm1
		  __int64 v17; // rcx
		  __int128 v18; // xmm1
		  __int128 v19; // xmm2
		  float capsuleRadius; // xmm1_4
		  __int128 v21; // xmm2
		  float capsuleHeight; // xmm1_4
		  void (__fastcall *v23)(Object *, __int64 *); // rax
		  __int128 v24; // xmm0
		  void (__fastcall *v25)(Object *, __int64 *); // rax
		  __int128 v26; // xmm1
		  GameObject *gameObject; // rax
		  __int64 v28; // rax
		  __int64 v29; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int64 v33; // [rsp+20h] [rbp-60h] BYREF
		  int v34; // [rsp+28h] [rbp-58h]
		  __int64 v35; // [rsp+30h] [rbp-50h] BYREF
		  int v36; // [rsp+38h] [rbp-48h]
		  HGCapsuleShadowContainer v37; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4111, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4111, 0LL);
		    if ( Patch )
		    {
		      v31 = *(_OWORD *)&container->localOffset.x;
		      *(_OWORD *)&v37.rootTransform = *(_OWORD *)&container->rootTransform;
		      v32 = *(_OWORD *)&container->localRotation.y;
		      *(_OWORD *)&v37.localOffset.x = v31;
		      *(_OWORD *)&v37.localRotation.y = v32;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1455(Patch, (Object *)this, &v37, 0LL);
		      return;
		    }
		    goto LABEL_18;
		  }
		  v6 = TypeInfo::UnityEngine::Object;
		  v7 = 0;
		  v8 = *(_OWORD *)&container->localRotation.y;
		  v9 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		  v10 = *(_OWORD *)&container->rootTransform;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v8;
		  if ( v9 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !(_QWORD)v10 )
		    goto LABEL_16;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v6);
		  if ( !*(_QWORD *)(v10 + 16) )
		  {
		LABEL_16:
		    gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    v15 = Beyond::UnityExtensions::GetOrAddComponent<System::Object>(
		            gameObject,
		            MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<UnityEngine::HGCapsuleBindingComponent>);
		    goto LABEL_12;
		  }
		  rootTransform = (Component *)container->rootTransform;
		  v12 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v12;
		  if ( !rootTransform )
		    goto LABEL_18;
		  v13 = UnityEngine::Component::get_gameObject(rootTransform, 0LL);
		  v14 = Beyond::UnityExtensions::GetOrAddComponent<System::Object>(
		          v13,
		          MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<UnityEngine::HGCapsuleBindingComponent>);
		  rootTransform = (Component *)container->rootTransform;
		  v15 = v14;
		  v16 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v16;
		  if ( !rootTransform )
		    goto LABEL_18;
		  if ( UnityEngine::Object::CompareName((Object_1 *)rootTransform, this->fields.m_skeletonName_Ankle_L, 0LL) )
		  {
		    v7 = 1;
		    goto LABEL_12;
		  }
		  rootTransform = (Component *)container->rootTransform;
		  v18 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v18;
		  if ( !rootTransform )
		LABEL_18:
		    sub_1800D8260(rootTransform, v5);
		  v7 = UnityEngine::Object::CompareName((Object_1 *)rootTransform, this->fields.m_skeletonName_Ankle_R, 0LL);
		LABEL_12:
		  if ( !v15 )
		    sub_1800D8260(v17, v5);
		  UnityEngine::Object::set_hideFlags((Object_1 *)v15, HideFlags__Enum_DontSave, 0LL);
		  UnityEngine::HGCapsuleBindingComponent::set_enabled((HGCapsuleBindingComponent *)v15, 1, 0LL);
		  v19 = *(_OWORD *)&container->localRotation.y;
		  capsuleRadius = container->capsuleRadius;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v19;
		  UnityEngine::HGCapsuleBindingComponent::set_capsuleRadius((HGCapsuleBindingComponent *)v15, capsuleRadius, 0LL);
		  v21 = *(_OWORD *)&container->localRotation.y;
		  capsuleHeight = container->capsuleHeight;
		  *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = v21;
		  UnityEngine::HGCapsuleBindingComponent::set_capsuleHeight((HGCapsuleBindingComponent *)v15, capsuleHeight, 0LL);
		  v23 = (void (__fastcall *)(Object *, __int64 *))qword_18F3706B8;
		  v24 = *(_OWORD *)&container->localRotation.y;
		  v33 = *(_QWORD *)&container->localOffset.x;
		  v34 = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&container->localOffset.z));
		  *(_OWORD *)&v37.localRotation.y = v24;
		  if ( !qword_18F3706B8 )
		  {
		    v23 = (void (__fastcall *)(Object *, __int64 *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.HGCapsuleBindingComponent::set_localOffset_Injected(Un"
		                                                      "ityEngine.Vector3&)");
		    if ( !v23 )
		    {
		      v28 = sub_1802EE1B8("UnityEngine.HGCapsuleBindingComponent::set_localOffset_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v28, 0LL);
		    }
		    qword_18F3706B8 = (__int64)v23;
		  }
		  v23(v15, &v33);
		  v25 = (void (__fastcall *)(Object *, __int64 *))qword_18F3706C0;
		  v26 = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v37.localRotation.y = *(_OWORD *)&container->localRotation.y;
		  v36 = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v37.localRotation.y, 4));
		  *(_OWORD *)&v37.localOffset.x = v26;
		  v35 = *(_QWORD *)&v37.localRotation.x;
		  if ( !qword_18F3706C0 )
		  {
		    v25 = (void (__fastcall *)(Object *, __int64 *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.HGCapsuleBindingComponent::set_localRotation_Injected("
		                                                      "UnityEngine.Vector3&)");
		    if ( !v25 )
		    {
		      v29 = sub_1802EE1B8("UnityEngine.HGCapsuleBindingComponent::set_localRotation_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v29, 0LL);
		    }
		    qword_18F3706C0 = (__int64)v25;
		  }
		  v25(v15, &v35);
		  UnityEngine::HGCapsuleBindingComponent::set_intensityScale(
		    (HGCapsuleBindingComponent *)v15,
		    container->intensityScale,
		    0LL);
		  UnityEngine::HGCapsuleBindingComponent::set_forceRender((HGCapsuleBindingComponent *)v15, v7, 0LL);
		}
		
		private void RemoveCapsuleBinding(HGCapsuleShadowContainer container) {} // 0x0000000189C213A4-0x0000000189C21460
		// Void RemoveCapsuleBinding(HGCapsuleShadowContainer)
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleBinding(
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Component *rootTransform; // rcx
		  GameObject *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  HGCapsuleShadowContainer v11; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4121, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)container->rootTransform, 0LL, 0LL) )
		    {
		      rootTransform = (Component *)this;
		LABEL_6:
		      gameObject = UnityEngine::Component::get_gameObject(rootTransform, 0LL);
		      HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveComponent<System::Object>(
		        gameObject,
		        MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveComponent<UnityEngine::HGCapsuleBindingComponent>);
		      return;
		    }
		    rootTransform = (Component *)container->rootTransform;
		    if ( container->rootTransform )
		      goto LABEL_6;
		LABEL_8:
		    sub_1800D8260(rootTransform, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4121, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  v9 = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v11.rootTransform = *(_OWORD *)&container->rootTransform;
		  v10 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v11.localOffset.x = v9;
		  *(_OWORD *)&v11.localRotation.y = v10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1455(Patch, (Object *)this, &v11, 0LL);
		}
		
		private void DisableCapsuleBinding(HGCapsuleShadowContainer container) {} // 0x00000001835207F0-0x00000001835208B0
		// Void DisableCapsuleBinding(HGCapsuleShadowContainer)
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleBinding(
		        HGCapsuleShadowHelper *this,
		        HGCapsuleShadowContainer *container,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  struct Object_1__Class *v6; // rcx
		  Transform *rootTransform; // rdi
		  Component *v8; // rcx
		  GameObject *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  HGCapsuleShadowContainer v13; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4118, 0LL) )
		  {
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    rootTransform = container->rootTransform;
		    if ( !container->rootTransform )
		      goto LABEL_9;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v6);
		    if ( !rootTransform->fields._._.m_CachedPtr )
		    {
		LABEL_9:
		      v8 = (Component *)this;
		      goto LABEL_8;
		    }
		    v8 = (Component *)rootTransform;
		    if ( rootTransform )
		    {
		LABEL_8:
		      gameObject = UnityEngine::Component::get_gameObject(v8, 0LL);
		      HG::Rendering::Runtime::HGCapsuleShadowHelper::_DisableCapsuleBinding_g__DisableComponent_40_0(gameObject, 0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v8, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4118, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  v11 = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v13.rootTransform = *(_OWORD *)&container->rootTransform;
		  v12 = *(_OWORD *)&container->localRotation.y;
		  *(_OWORD *)&v13.localOffset.x = v11;
		  *(_OWORD *)&v13.localRotation.y = v12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1455(Patch, (Object *)this, &v13, 0LL);
		}
		
		private void AddCapsuleListBinding() {} // 0x000000018351FF70-0x0000000183520200
		// Void AddCapsuleListBinding()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  __int64 v4; // rcx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rax
		  __int64 v11; // rdx
		  int v12; // ecx
		  __int64 v13; // rdx
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  __int64 *v17; // rdx
		  __int64 v18; // rtt
		  Il2CppClass *klass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int128 v23; // [rsp+20h] [rbp-A8h] BYREF
		  __int128 v24; // [rsp+30h] [rbp-98h] BYREF
		  __int128 v25; // [rsp+40h] [rbp-88h]
		  __int128 v26; // [rsp+50h] [rbp-78h]
		  Il2CppException *ex; // [rsp+60h] [rbp-68h]
		  __int128 *v28; // [rsp+68h] [rbp-60h]
		  _BYTE v29[64]; // [rsp+70h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v30; // [rsp+B0h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4110, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4110, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields.m_interactionOnly )
		  {
		    m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		    if ( !m_capsuleShadowContainers )
		      sub_1800D8260(v4, v3);
		    memset(&v29[8], 0, 56);
		    *(_QWORD *)v29 = m_capsuleShadowContainers;
		    sub_18002D1B0((SingleFieldAccessor *)v29, v3, v5, v6, (MethodInfo *)v23);
		    *(_DWORD *)&v29[8] = 0;
		    *(_DWORD *)&v29[12] = m_capsuleShadowContainers->fields._version;
		    memset(&v29[16], 0, 48);
		    v23 = *(_OWORD *)v29;
		    v24 = 0LL;
		    v25 = 0LL;
		    v26 = 0LL;
		    ex = 0LL;
		    v28 = &v23;
		    try
		    {
		      while ( 1 )
		      {
		        v10 = v23;
		        if ( !(_QWORD)v23 )
		          sub_1800D8250(v9, v8);
		        v11 = HIDWORD(v23);
		        if ( HIDWORD(v23) != *(_DWORD *)(v23 + 28) )
		          break;
		        v12 = DWORD2(v23);
		        if ( DWORD2(v23) >= *(_DWORD *)(v23 + 24) )
		          break;
		        v13 = *(_QWORD *)(v23 + 16);
		        if ( !v13 )
		          sub_1800D8250(SDWORD2(v23), 0LL);
		        if ( DWORD2(v23) >= *(_DWORD *)(v13 + 24) )
		          sub_1800D2AA0(
		            SDWORD2(v23),
		            v13,
		            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
		        v14 = *(_OWORD *)(v13 + 48LL * SDWORD2(v23) + 32);
		        v24 = v14;
		        v15 = *(_OWORD *)(v13 + 48LL * SDWORD2(v23) + 48);
		        v25 = v15;
		        v16 = *(_OWORD *)(v13 + 48LL * SDWORD2(v23) + 64);
		        v26 = v16;
		        if ( dword_18F35FD08 )
		        {
		          v17 = &qword_18F103690[(((unsigned __int64)&v24 >> 12) & 0x1FFFFF) >> 6];
		          _m_prefetchw(v17);
		          do
		            v18 = *v17;
		          while ( v18 != _InterlockedCompareExchange64(
		                           v17,
		                           *v17 | (1LL << (((unsigned __int64)&v24 >> 12) & 0x3F)),
		                           *v17) );
		          v16 = v26;
		          v15 = v25;
		          v14 = v24;
		          v12 = DWORD2(v23);
		        }
		        DWORD2(v23) = v12 + 1;
		        *(_OWORD *)v29 = v14;
		        *(_OWORD *)&v29[16] = v15;
		        *(_OWORD *)&v29[32] = v16;
		        HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleBinding(this, (HGCapsuleShadowContainer *)v29, 0LL);
		      }
		      klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext->klass;
		      if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		      {
		        sub_1800360B0(klass, HIDWORD(v23));
		        v11 = HIDWORD(v23);
		        v10 = v23;
		      }
		      if ( !v10 )
		        sub_1800D8250(klass, v11);
		      if ( (_DWORD)v11 != *(_DWORD *)(v10 + 28) )
		        System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		      DWORD2(v23) = *(_DWORD *)(v10 + 24) + 1;
		      v24 = 0LL;
		      v25 = 0LL;
		      v26 = 0LL;
		    }
		    catch ( Il2CppExceptionWrapper *v30 )
		    {
		      ex = v30->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void RemoveCapsuleListBinding() {} // 0x0000000189C21460-0x0000000189C215C4
		// Void RemoveCapsuleListBinding()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleListBinding(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Il2CppException *ex; // [rsp+20h] [rbp-A8h]
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ v9; // [rsp+30h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v10; // [rsp+70h] [rbp-58h] BYREF
		  HGCapsuleShadowContainer current; // [rsp+80h] [rbp-48h] BYREF
		
		  sub_18033B9D0(&v9, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(4122, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4122, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields.m_interactionOnly )
		  {
		    if ( !this->fields.m_capsuleShadowContainers )
		      sub_1800D8260(v4, v3);
		    v9 = *(List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *)sub_1808B0EE4(
		                                                                                  &current,
		                                                                                  this->fields.m_capsuleShadowContainers);
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext(
		                &v9,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext) )
		      {
		        current = v9._current;
		        HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleBinding(this, &current, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v10 )
		    {
		      ex = v10->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void DisableCapsuleListBinding() {} // 0x0000000183520200-0x00000001835207A0
		// Void DisableCapsuleListBinding()
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleListBinding(
		        HGCapsuleShadowHelper *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  __int64 v4; // rcx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  unsigned __int64 v10; // r8
		  __int64 v11; // rax
		  __int64 v12; // rdx
		  int v13; // ecx
		  __int64 v14; // rdx
		  __int128 v15; // xmm6
		  __int128 v16; // xmm7
		  __int128 v17; // xmm8
		  __int64 *v18; // rdx
		  __int64 v19; // rtt
		  struct ILFixDynamicMethodWrapper_2__Class *v20; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v22; // rcx
		  ILFixDynamicMethodWrapper_2 *v23; // rcx
		  struct Object_1__Class *v24; // rcx
		  __int64 (__fastcall *v25)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64); // rax
		  GameObject *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  Object *v29; // rbx
		  void (__fastcall *v30)(Object *, _QWORD); // rax
		  __int64 (__fastcall *v31)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64); // rax
		  GameObject *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  Il2CppClass *klass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rax
		  __int64 v40; // rax
		  __int64 v41; // rax
		  __int64 v42; // rax
		  __int128 v43; // [rsp+20h] [rbp-118h] BYREF
		  __int128 v44; // [rsp+30h] [rbp-108h] BYREF
		  __int128 v45; // [rsp+40h] [rbp-F8h]
		  __int128 v46; // [rsp+50h] [rbp-E8h]
		  __int64 v47; // [rsp+60h] [rbp-D8h]
		  __int128 *v48; // [rsp+68h] [rbp-D0h]
		  _BYTE v49[64]; // [rsp+70h] [rbp-C8h] BYREF
		  HGCapsuleShadowContainer v50; // [rsp+C0h] [rbp-78h] BYREF
		  Object *component; // [rsp+150h] [rbp+18h] BYREF
		  Object *v52; // [rsp+158h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4117, 0LL) )
		  {
		    if ( this->fields.m_interactionOnly )
		      return;
		    m_capsuleShadowContainers = this->fields.m_capsuleShadowContainers;
		    if ( !m_capsuleShadowContainers )
		      sub_1800D8260(v4, v3);
		    memset(&v49[8], 0, 56);
		    *(_QWORD *)v49 = m_capsuleShadowContainers;
		    sub_18002D1B0((SingleFieldAccessor *)v49, v3, v5, v6, (MethodInfo *)v43);
		    *(_DWORD *)&v49[8] = 0;
		    *(_DWORD *)&v49[12] = m_capsuleShadowContainers->fields._version;
		    memset(&v49[16], 0, 48);
		    v43 = *(_OWORD *)v49;
		    v44 = 0LL;
		    v45 = 0LL;
		    v46 = 0LL;
		    v47 = 0LL;
		    v48 = &v43;
		    while ( 1 )
		    {
		      while ( 1 )
		      {
		        while ( 1 )
		        {
		          v10 = (unsigned __int64)MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext;
		          v11 = v43;
		          if ( !(_QWORD)v43 )
		            sub_1800D8250(v9, v8);
		          v12 = HIDWORD(v43);
		          if ( HIDWORD(v43) != *(_DWORD *)(v43 + 28) || (v13 = DWORD2(v43), DWORD2(v43) >= *(_DWORD *)(v43 + 24)) )
		          {
		            klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext->klass;
		            if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		            {
		              sub_1800360B0(klass, HIDWORD(v43));
		              v12 = HIDWORD(v43);
		              v11 = v43;
		            }
		            if ( !v11 )
		              sub_1800D8250(klass, v12);
		            if ( (_DWORD)v12 != *(_DWORD *)(v11 + 28) )
		              System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		            DWORD2(v43) = *(_DWORD *)(v11 + 24) + 1;
		            v44 = 0LL;
		            v45 = 0LL;
		            v46 = 0LL;
		            return;
		          }
		          v14 = *(_QWORD *)(v43 + 16);
		          if ( !v14 )
		            sub_1800D8250(SDWORD2(v43), 0LL);
		          if ( DWORD2(v43) >= *(_DWORD *)(v14 + 24) )
		            sub_1800D2AA0(
		              SDWORD2(v43),
		              v14,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
		          v15 = *(_OWORD *)(v14 + 48LL * SDWORD2(v43) + 32);
		          v44 = v15;
		          v16 = *(_OWORD *)(v14 + 48LL * SDWORD2(v43) + 48);
		          v45 = v16;
		          v17 = *(_OWORD *)(v14 + 48LL * SDWORD2(v43) + 64);
		          v46 = v17;
		          if ( dword_18F35FD08 )
		          {
		            v18 = &qword_18F103690[(((unsigned __int64)&v44 >> 12) & 0x1FFFFF) >> 6];
		            v10 = ((unsigned __int64)&v44 >> 12) & 0x3F;
		            _m_prefetchw(v18);
		            do
		              v19 = *v18;
		            while ( v19 != _InterlockedCompareExchange64(v18, *v18 | (1LL << v10), *v18) );
		            v17 = v46;
		            v16 = v45;
		            v15 = v44;
		            v13 = DWORD2(v43);
		          }
		          DWORD2(v43) = v13 + 1;
		          v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v20->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            sub_1800D8250(v20, 0LL);
		          if ( wrapperArray->max_length.size <= 4118 )
		            break;
		          if ( !v20->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v20);
		            v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v20->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            sub_1800D8250(v20, 0LL);
		          if ( wrapperArray->max_length.size <= 0x1016u )
		            sub_1800D2AA0(v20, wrapperArray, v10);
		          if ( !wrapperArray[114].vector[14] )
		            break;
		          if ( !v20->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v20);
		            v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v22 = v20->static_fields->wrapperArray;
		          if ( !v22 )
		            sub_1800D8250(0LL, wrapperArray);
		          if ( v22->max_length.size <= 0x1016u )
		            sub_1800D2AA0(v22, wrapperArray, v10);
		          v23 = v22[114].vector[14];
		          if ( !v23 )
		            sub_1800D8250(0LL, wrapperArray);
		          *(_OWORD *)&v50.rootTransform = v15;
		          *(_OWORD *)&v50.localOffset.x = v16;
		          *(_OWORD *)&v50.localRotation.y = v17;
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1455(v23, (Object *)this, &v50, 0LL);
		        }
		        v24 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v24 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v24 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( !(_QWORD)v15 )
		          break;
		        if ( !v24->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v24);
		        if ( !*(_QWORD *)(v15 + 16) )
		          break;
		        v25 = (__int64 (__fastcall *)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))qword_18F36FBC8;
		        if ( !qword_18F36FBC8 )
		        {
		          v25 = (__int64 (__fastcall *)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		          if ( !v25 )
		          {
		            v39 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		            sub_18007E1B0(v39, 0LL);
		          }
		          qword_18F36FBC8 = (__int64)v25;
		        }
		        v26 = (GameObject *)v25(v15, wrapperArray, v10);
		        component = 0LL;
		        if ( !v26 )
		          sub_1800D8250(v28, v27);
		        if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
		               v26,
		               &component,
		               MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>) )
		        {
		          v29 = component;
		          if ( !component )
		            sub_1800D8250(v9, v8);
		          v30 = (void (__fastcall *)(Object *, _QWORD))qword_18F370690;
		          if ( !qword_18F370690 )
		          {
		            v30 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
		            if ( !v30 )
		            {
		              v40 = sub_1802EE1B8("UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
		              sub_18007E1B0(v40, 0LL);
		            }
		LABEL_44:
		            qword_18F370690 = (__int64)v30;
		            goto LABEL_45;
		          }
		          goto LABEL_45;
		        }
		      }
		      v31 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))qword_18F36FBC8;
		      if ( !qword_18F36FBC8 )
		      {
		        v31 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		        if ( !v31 )
		        {
		          v41 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		          sub_18007E1B0(v41, 0LL);
		        }
		        qword_18F36FBC8 = (__int64)v31;
		      }
		      v32 = (GameObject *)v31(this, wrapperArray, v10);
		      v52 = 0LL;
		      if ( !v32 )
		        sub_1800D8250(v34, v33);
		      if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
		             v32,
		             &v52,
		             MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>) )
		      {
		        v29 = v52;
		        if ( !v52 )
		          sub_1800D8250(v9, v8);
		        v30 = (void (__fastcall *)(Object *, _QWORD))qword_18F370690;
		        if ( !qword_18F370690 )
		        {
		          v30 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
		          if ( !v30 )
		          {
		            v42 = sub_1802EE1B8("UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
		            sub_18007E1B0(v42, 0LL);
		          }
		          goto LABEL_44;
		        }
		LABEL_45:
		        v30(v29, 0LL);
		      }
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4117, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v38, v37);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public static T GetOrAddComponent<T>(GameObject go)
			where T : Component => default;
		public static void RemoveComponent<T>(GameObject go)
			where T : Component {}
	}
}
