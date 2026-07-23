using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VolumetricWindField : MonoBehaviour, IVolumetricWindField // TypeDefIndex: 38771
	{
		// Fields
		public const int MAX_RING_NUM = 4; // Metadata: 0x02304166
		[SerializeField]
		public EWindFieldType Type; // 0x18
		[SerializeField]
		public int Priority; // 0x1C
		[SerializeField]
		public float Radius; // 0x20
		[SerializeField]
		public Vector3 Velocity; // 0x24
		[SerializeField]
		public float RotateSpeed; // 0x30
		[Range(1f, 4f)]
		[SerializeField]
		public int vortexRingCount; // 0x34
		[SerializeField]
		public float[] vortexRingSpeeds; // 0x38
		[Range(0f, 1f)]
		[SerializeField]
		public float vortexRingBlend; // 0x40
		[Range(-0.25f, 0.25f)]
		[SerializeField]
		public float vortexRingSkew; // 0x44
		private Vector3 m_DirectionalWindPhase; // 0x48
		private Vector3 m_DirectionalWindOffset; // 0x54
		private float m_CircularWindPhase; // 0x60
		private float m_CircularWindOffset; // 0x64
		private float[] m_VortexRingPhase; // 0x68
		private float[] m_VortexRingOffset; // 0x70
	
		// Properties
		private bool directionalWind { get => default; } // 0x0000000189C66EB4-0x0000000189C66F04 
		// Boolean get_directionalWind()
		bool HG::Rendering::Runtime::VolumetricWindField::get_directionalWind(VolumetricWindField *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5319, 0LL) )
		    return this->fields.Type == 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5319, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private bool circularWind { get => default; } // 0x0000000189C66E64-0x0000000189C66EB4 
		// Boolean get_circularWind()
		bool HG::Rendering::Runtime::VolumetricWindField::get_circularWind(VolumetricWindField *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5320, 0LL) )
		    return this->fields.Type == 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5320, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private bool vortexWind { get => default; } // 0x0000000189C66F04-0x0000000189C66F54 
		// Boolean get_vortexWind()
		bool HG::Rendering::Runtime::VolumetricWindField::get_vortexWind(VolumetricWindField *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5321, 0LL) )
		    return this->fields.Type == 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5321, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VolumetricWindField() {} // 0x0000000189C66D8C-0x0000000189C66E64
	
		// Methods
		private void OnEnable() {} // 0x0000000189C66AA0-0x0000000189C66B30
		// Void OnEnable()
		void HG::Rendering::Runtime::VolumetricWindField::OnEnable(VolumetricWindField *this, MethodInfo *method)
		{
		  Object *v3; // rdi
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5322, 0LL) )
		  {
		    v3 = UnityEngine::Component::GetComponentInParent<System::Object>(
		           (Component *)this,
		           1,
		           MethodInfo::UnityEngine::Component::GetComponentInParent<HG::Rendering::Runtime::VolumetricCloudSDF>);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit((Object_1 *)v3, 0LL) )
		      return;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::VolumetricCloudSDF::AddWindField((VolumetricCloudSDF *)v3, this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5322, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000189C66A10-0x0000000189C66AA0
		// Void OnDisable()
		void HG::Rendering::Runtime::VolumetricWindField::OnDisable(VolumetricWindField *this, MethodInfo *method)
		{
		  Object *v3; // rdi
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5323, 0LL) )
		  {
		    v3 = UnityEngine::Component::GetComponentInParent<System::Object>(
		           (Component *)this,
		           1,
		           MethodInfo::UnityEngine::Component::GetComponentInParent<HG::Rendering::Runtime::VolumetricCloudSDF>);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit((Object_1 *)v3, 0LL) )
		      return;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::VolumetricCloudSDF::RemoveWindField((VolumetricCloudSDF *)v3, this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5323, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void Update() {} // 0x0000000189C66B30-0x0000000189C66D8C
		// Void Update()
		void HG::Rendering::Runtime::VolumetricWindField::Update(VolumetricWindField *this, MethodInfo *method)
		{
		  __int64 v3; // xmm6_8
		  float z; // ebx
		  float deltaTime; // xmm0_4
		  MethodInfo *v6; // r9
		  Vector3 *v7; // rax
		  __int64 v8; // xmm3_8
		  MethodInfo *v9; // r9
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  float v12; // ecx
		  __int64 v13; // xmm1_8
		  MethodInfo *v14; // r9
		  Vector3 *v15; // rax
		  Beyond::JobMathf *z_low; // rcx
		  Beyond::JobMathf *v17; // rcx
		  Beyond::JobMathf *v18; // rcx
		  Beyond::JobMathf *v19; // rcx
		  Single__Array *v20; // rdx
		  Single__Array *m_VortexRingPhase; // rcx
		  Single__Array *vortexRingSpeeds; // rax
		  int32_t vortexRingCount; // r14d
		  int32_t v24; // edi
		  Single__Array *m_VortexRingOffset; // rbx
		  float v26; // xmm6_4
		  __int64 v27; // r8
		  __int64 v28; // r9
		  float v29; // xmm0_4
		  float *v30; // rax
		  __int64 v31; // r8
		  __int64 v32; // r9
		  int *v33; // rbx
		  int v34; // xmm0_4
		  Beyond::JobMathf *v35; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v37; // [rsp+20h] [rbp-50h] BYREF
		  Vector3 v38; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v39; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5324, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5324, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = *(_QWORD *)&this->fields.Velocity.x;
		    z = this->fields.Velocity.z;
		    deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		    *(_QWORD *)&v37.x = v3;
		    v37.z = z;
		    v7 = UnityEngine::Vector3::op_Multiply(&v38, &v37, deltaTime, v6);
		    v8 = *(_QWORD *)&v7->x;
		    *(float *)&v7 = v7->z;
		    *(_QWORD *)&v37.x = v8;
		    LODWORD(v37.z) = (_DWORD)v7;
		    v10 = UnityEngine::Vector3::op_Multiply(&v38, &v37, 0.050000001, v9);
		    v11 = *(_QWORD *)&this->fields.m_DirectionalWindPhase.x;
		    v12 = v10->z;
		    v13 = *(_QWORD *)&v10->x;
		    *(float *)&v10 = this->fields.m_DirectionalWindPhase.z;
		    *(_QWORD *)&this->fields.m_DirectionalWindOffset.x = v13;
		    this->fields.m_DirectionalWindOffset.z = v12;
		    v37.z = v12;
		    *(_QWORD *)&v37.x = v13;
		    *(_QWORD *)&v38.x = v11;
		    LODWORD(v38.z) = (_DWORD)v10;
		    v15 = UnityEngine::Vector3::op_Addition(&v39, &v38, &v37, v14);
		    z_low = (Beyond::JobMathf *)LODWORD(v15->z);
		    *(_QWORD *)&this->fields.m_DirectionalWindPhase.x = *(_QWORD *)&v15->x;
		    LODWORD(this->fields.m_DirectionalWindPhase.z) = (_DWORD)z_low;
		    *(float *)&v11 = this->fields.m_DirectionalWindPhase.x;
		    Beyond::JobMathf::Fmod(z_low, 1.0, 0.050000001);
		    LODWORD(this->fields.m_DirectionalWindPhase.x) = v11;
		    *(float *)&v11 = this->fields.m_DirectionalWindPhase.y;
		    Beyond::JobMathf::Fmod(v17, 1.0, 0.050000001);
		    LODWORD(this->fields.m_DirectionalWindPhase.y) = v11;
		    *(float *)&v11 = this->fields.m_DirectionalWindPhase.z;
		    Beyond::JobMathf::Fmod(v18, 1.0, 0.050000001);
		    LODWORD(this->fields.m_DirectionalWindPhase.z) = v11;
		    *(float *)&v3 = this->fields.RotateSpeed;
		    *(float *)&v11 = (float)(UnityEngine::Time::get_deltaTime(0LL) * *(float *)&v3) * 0.050000001;
		    LODWORD(this->fields.m_CircularWindOffset) = v11;
		    *(float *)&v11 = *(float *)&v11 + this->fields.m_CircularWindPhase;
		    Beyond::JobMathf::Fmod(v19, 1.0, 0.050000001);
		    vortexRingSpeeds = this->fields.vortexRingSpeeds;
		    vortexRingCount = this->fields.vortexRingCount;
		    LODWORD(this->fields.m_CircularWindPhase) = v11;
		    if ( !vortexRingSpeeds )
		      goto LABEL_18;
		    if ( vortexRingCount >= vortexRingSpeeds->max_length.size )
		      vortexRingCount = vortexRingSpeeds->max_length.size;
		    v24 = 0;
		    if ( vortexRingCount > 0 )
		    {
		      while ( 1 )
		      {
		        m_VortexRingPhase = this->fields.vortexRingSpeeds;
		        m_VortexRingOffset = this->fields.m_VortexRingOffset;
		        if ( !m_VortexRingPhase )
		          break;
		        if ( (unsigned int)v24 >= m_VortexRingPhase->max_length.size )
		          goto LABEL_16;
		        v26 = m_VortexRingPhase->vector[v24];
		        v29 = UnityEngine::Time::get_deltaTime(0LL);
		        if ( !m_VortexRingOffset )
		          break;
		        if ( (unsigned int)v24 >= m_VortexRingOffset->max_length.size )
		          goto LABEL_16;
		        m_VortexRingOffset->vector[v24] = (float)(v29 * v26) * 0.050000001;
		        m_VortexRingPhase = this->fields.m_VortexRingPhase;
		        if ( !m_VortexRingPhase )
		          break;
		        v30 = (float *)sub_180002EB0(m_VortexRingPhase, v24, v27, v28);
		        v20 = this->fields.m_VortexRingOffset;
		        if ( !v20 )
		          break;
		        if ( (unsigned int)v24 >= v20->max_length.size )
		LABEL_16:
		          sub_1800D2AB0(m_VortexRingPhase, v20);
		        *v30 = v20->vector[v24] + *v30;
		        m_VortexRingPhase = this->fields.m_VortexRingPhase;
		        if ( !m_VortexRingPhase )
		          break;
		        v33 = (int *)sub_180002EB0(m_VortexRingPhase, v24, v31, v32);
		        v34 = *v33;
		        Beyond::JobMathf::Fmod(v35, 1.0, 0.050000001);
		        ++v24;
		        *v33 = v34;
		        if ( v24 >= vortexRingCount )
		          return;
		      }
		LABEL_18:
		      sub_1800D8260(m_VortexRingPhase, v20);
		    }
		  }
		}
		
		public FWindFieldData GetWindFieldData() => default; // 0x0000000189C665E0-0x0000000189C66A10
		// FWindFieldData GetWindFieldData()
		FWindFieldData *HG::Rendering::Runtime::VolumetricWindField::GetWindFieldData(
		        FWindFieldData *__return_ptr retstr,
		        VolumetricWindField *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *position; // rax
		  float Radius; // xmm7_4
		  __int64 v10; // xmm6_8
		  float z; // ebx
		  Vector4 v12; // xmm7
		  Transform *v13; // rax
		  Vector3 *up; // rax
		  float Priority; // xmm2_4
		  __int64 v16; // xmm0_8
		  Vector4 v17; // xmm6
		  Vector4 *v18; // rax
		  TileBase *v19; // rdx
		  Vector3Int *v20; // r8
		  ITilemap *v21; // r9
		  Vector4 v22; // xmm2
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __m128i Param4; // xmm0
		  Vector4 Param3; // xmm1
		  Transform *v26; // rax
		  Vector3 *v27; // rax
		  float v28; // xmm7_4
		  __int64 v29; // xmm6_8
		  float v30; // ebx
		  Vector4 v31; // xmm7
		  Transform *v32; // rax
		  Vector3 *v33; // rax
		  float v34; // xmm2_4
		  __int64 v35; // xmm0_8
		  Vector4 v36; // xmm8
		  Vector4 v37; // xmm9
		  Single__Array *m_VortexRingPhase; // rax
		  Vector4 v39; // xmm6
		  Single__Array *m_VortexRingOffset; // rax
		  Vector4 *v41; // rax
		  Transform *v42; // rax
		  Vector3 *v43; // rax
		  float v44; // xmm7_4
		  __int64 v45; // xmm6_8
		  float v46; // ebx
		  Vector4 *v47; // rax
		  float v48; // xmm2_4
		  Vector4 *v49; // rax
		  float Type; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FWindFieldData *v52; // rax
		  Vector4 Param1; // xmm1
		  Vector4 Param2; // xmm0
		  FWindFieldData *result; // rax
		  MethodInfo *v56; // [rsp+28h] [rbp-69h]
		  Vector3 v57; // [rsp+38h] [rbp-59h] BYREF
		  Vector4 v58; // [rsp+48h] [rbp-49h] BYREF
		  FWindFieldData v59; // [rsp+58h] [rbp-39h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5325, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5325, 0LL);
		    if ( Patch )
		    {
		      v52 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1543(&v59, Patch, (Object *)this, 0LL);
		      Param1 = v52->Param1;
		      retstr->Param0 = v52->Param0;
		      Param2 = v52->Param2;
		      retstr->Param1 = Param1;
		      Param3 = v52->Param3;
		      retstr->Param2 = Param2;
		      Param4 = (__m128i)v52->Param4;
		      goto LABEL_21;
		    }
		    goto LABEL_19;
		  }
		  sub_18033B9D0(&v59, 0LL, 80LL);
		  if ( this->fields.Type == 1 )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      position = UnityEngine::Transform::get_position(&v57, transform, 0LL);
		      Radius = this->fields.Radius;
		      v10 = *(_QWORD *)&position->x;
		      z = position->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v57.x = v10;
		      v57.z = z;
		      v12 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                        &v58,
		                                                        &v57,
		                                                        Radius,
		                                                        0LL));
		      v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v13 )
		      {
		        up = UnityEngine::Transform::get_up((Vector3 *)&v58, v13, 0LL);
		        Priority = (float)this->fields.Priority;
		        v16 = *(_QWORD *)&up->x;
		        *(float *)&up = up->z;
		        *(_QWORD *)&v57.x = v16;
		        LODWORD(v57.z) = (_DWORD)up;
		        v17 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                          &v58,
		                                                          &v57,
		                                                          Priority,
		                                                          0LL));
		        v18 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                &v58,
		                this->fields.m_CircularWindPhase,
		                this->fields.m_CircularWindOffset,
		                0.0,
		                (float)this->fields.Type,
		                0LL);
		LABEL_6:
		        v22 = (Vector4)_mm_loadu_si128((const __m128i *)v18);
		        TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                   (TileAnimationData *)&v58,
		                                   v19,
		                                   v20,
		                                   v21,
		                                   v56);
		        Param4 = (__m128i)v59.Param4;
		        retstr->Param0 = v12;
		        Param3 = (Vector4)_mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
		        retstr->Param1 = v17;
		        retstr->Param2 = v22;
		LABEL_21:
		        retstr->Param3 = Param3;
		        goto LABEL_22;
		      }
		    }
		    goto LABEL_19;
		  }
		  if ( this->fields.Type != 2 )
		  {
		    v42 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( v42 )
		    {
		      v43 = UnityEngine::Transform::get_position((Vector3 *)&v58, v42, 0LL);
		      v44 = this->fields.Radius;
		      v45 = *(_QWORD *)&v43->x;
		      v46 = v43->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v57.x = v45;
		      v57.z = v46;
		      v47 = HG::Rendering::Runtime::HGUtils::PackVector4(&v58, &v57, v44, 0LL);
		      v48 = (float)this->fields.Priority;
		      v12 = (Vector4)_mm_loadu_si128((const __m128i *)v47);
		      *(float *)&v47 = this->fields.m_DirectionalWindPhase.z;
		      *(_QWORD *)&v57.x = *(_QWORD *)&this->fields.m_DirectionalWindPhase.x;
		      LODWORD(v57.z) = (_DWORD)v47;
		      v49 = HG::Rendering::Runtime::HGUtils::PackVector4(&v58, &v57, v48, 0LL);
		      Type = (float)this->fields.Type;
		      v17 = (Vector4)_mm_loadu_si128((const __m128i *)v49);
		      *(float *)&v49 = this->fields.m_DirectionalWindOffset.z;
		      *(_QWORD *)&v57.x = *(_QWORD *)&this->fields.m_DirectionalWindOffset.x;
		      LODWORD(v57.z) = (_DWORD)v49;
		      v18 = HG::Rendering::Runtime::HGUtils::PackVector4(&v58, &v57, Type, 0LL);
		      goto LABEL_6;
		    }
		LABEL_19:
		    sub_1800D8260(v7, v6);
		  }
		  v26 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v26 )
		    goto LABEL_19;
		  v27 = UnityEngine::Transform::get_position((Vector3 *)&v58, v26, 0LL);
		  v28 = this->fields.Radius;
		  v29 = *(_QWORD *)&v27->x;
		  v30 = v27->z;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_QWORD *)&v57.x = v29;
		  v57.z = v30;
		  v31 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(&v58, &v57, v28, 0LL));
		  v32 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v32 )
		    goto LABEL_19;
		  v33 = UnityEngine::Transform::get_up((Vector3 *)&v58, v32, 0LL);
		  v34 = (float)this->fields.Priority;
		  v35 = *(_QWORD *)&v33->x;
		  *(float *)&v33 = v33->z;
		  *(_QWORD *)&v57.x = v35;
		  LODWORD(v57.z) = (_DWORD)v33;
		  v36 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(&v58, &v57, v34, 0LL));
		  v37 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                    &v58,
		                                                    (float)this->fields.vortexRingCount,
		                                                    this->fields.vortexRingBlend,
		                                                    this->fields.vortexRingSkew,
		                                                    (float)this->fields.Type,
		                                                    0LL));
		  m_VortexRingPhase = this->fields.m_VortexRingPhase;
		  if ( !m_VortexRingPhase )
		    goto LABEL_19;
		  if ( m_VortexRingPhase->max_length.size < 4u )
		    goto LABEL_15;
		  v39 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                    &v58,
		                                                    m_VortexRingPhase->vector[0],
		                                                    m_VortexRingPhase->vector[1],
		                                                    m_VortexRingPhase->vector[2],
		                                                    m_VortexRingPhase->vector[3],
		                                                    0LL));
		  m_VortexRingOffset = this->fields.m_VortexRingOffset;
		  if ( !m_VortexRingOffset )
		    goto LABEL_19;
		  if ( m_VortexRingOffset->max_length.size < 4u )
		LABEL_15:
		    sub_1800D2AB0(v7, v6);
		  v41 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          &v58,
		          m_VortexRingOffset->vector[0],
		          m_VortexRingOffset->vector[1],
		          m_VortexRingOffset->vector[2],
		          m_VortexRingOffset->vector[3],
		          0LL);
		  retstr->Param0 = v31;
		  retstr->Param1 = v36;
		  Param4 = _mm_loadu_si128((const __m128i *)v41);
		  retstr->Param2 = v37;
		  retstr->Param3 = v39;
		LABEL_22:
		  result = retstr;
		  retstr->Param4 = (Vector4)Param4;
		  return result;
		}
		
	}
}
