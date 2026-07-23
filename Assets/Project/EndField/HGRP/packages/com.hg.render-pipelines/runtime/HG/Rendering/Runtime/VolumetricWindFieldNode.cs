using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricWindFieldNode : IVolumetricWindField // TypeDefIndex: 38770
	{
		// Fields
		public Vector3 position; // 0x10
		public Vector3 up; // 0x1C
		public EWindFieldType Type; // 0x28
		public int Priority; // 0x2C
		public float Radius; // 0x30
		public Vector3 Velocity; // 0x34
		public float RotateSpeed; // 0x40
		public int vortexRingCount; // 0x44
		public float[] vortexRingSpeeds; // 0x48
		public float vortexRingBlend; // 0x50
		public float vortexRingSkew; // 0x54
		private Vector3 m_DirectionalWindPhase; // 0x58
		private Vector3 m_DirectionalWindOffset; // 0x64
		private float m_CircularWindPhase; // 0x70
		private float m_CircularWindOffset; // 0x74
		private float[] m_VortexRingPhase; // 0x78
		private float[] m_VortexRingOffset; // 0x80
	
		// Constructors
		public VolumetricWindFieldNode() {} // 0x000000018412BB40-0x000000018412BC30
	
		// Methods
		public void Update() {} // 0x0000000189C66380-0x0000000189C665E0
		// Void Update()
		void HG::Rendering::Runtime::VolumetricWindFieldNode::Update(VolumetricWindFieldNode *this, MethodInfo *method)
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5036, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5036, 0LL);
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
		
		public FWindFieldData GetWindFieldData() => default; // 0x0000000189C66008-0x0000000189C66380
		// FWindFieldData GetWindFieldData()
		FWindFieldData *HG::Rendering::Runtime::VolumetricWindFieldNode::GetWindFieldData(
		        FWindFieldData *__return_ptr retstr,
		        VolumetricWindFieldNode *this,
		        MethodInfo *method)
		{
		  __int64 v5; // xmm6_8
		  float z; // ebx
		  float Radius; // xmm7_4
		  Vector4 *v8; // rax
		  float Priority; // xmm2_4
		  Vector4 v10; // xmm7
		  Vector4 v11; // xmm6
		  Vector4 *v12; // rax
		  TileBase *v13; // rdx
		  Vector3Int *v14; // r8
		  ITilemap *v15; // r9
		  Vector4 v16; // xmm2
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __m128i Param4; // xmm0
		  Vector4 Param3; // xmm1
		  Vector4 *v20; // rax
		  float v21; // xmm2_4
		  Vector4 v22; // xmm7
		  Vector4 v23; // xmm8
		  Vector4 *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Single__Array *m_VortexRingPhase; // r8
		  Vector4 v28; // xmm9
		  Vector4 v29; // xmm6
		  Single__Array *m_VortexRingOffset; // rax
		  Vector4 *v31; // rax
		  Vector4 *v32; // rax
		  float v33; // xmm2_4
		  Vector4 *v34; // rax
		  float Type; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FWindFieldData *v37; // rax
		  Vector4 Param1; // xmm1
		  Vector4 Param2; // xmm0
		  FWindFieldData *result; // rax
		  MethodInfo *v41; // [rsp+28h] [rbp-69h]
		  Vector3 v42; // [rsp+38h] [rbp-59h] BYREF
		  Vector4 v43; // [rsp+48h] [rbp-49h] BYREF
		  FWindFieldData v44; // [rsp+58h] [rbp-39h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5318, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5318, 0LL);
		    if ( Patch )
		    {
		      v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1543(&v44, Patch, (Object *)this, 0LL);
		      Param1 = v37->Param1;
		      retstr->Param0 = v37->Param0;
		      Param2 = v37->Param2;
		      retstr->Param1 = Param1;
		      Param3 = v37->Param3;
		      retstr->Param2 = Param2;
		      Param4 = (__m128i)v37->Param4;
		      goto LABEL_16;
		    }
		    goto LABEL_14;
		  }
		  sub_18033B9D0(&v44, 0LL, 80LL);
		  v5 = *(_QWORD *)&this->fields.position.x;
		  z = this->fields.position.z;
		  Radius = this->fields.Radius;
		  if ( this->fields.Type == 1 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_QWORD *)&v42.x = v5;
		    v42.z = z;
		    v8 = HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, Radius, 0LL);
		    Priority = (float)this->fields.Priority;
		    v10 = (Vector4)_mm_loadu_si128((const __m128i *)v8);
		    *(float *)&v8 = this->fields.up.z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&this->fields.up.x;
		    LODWORD(v42.z) = (_DWORD)v8;
		    v11 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                      &v43,
		                                                      &v42,
		                                                      Priority,
		                                                      0LL));
		    v12 = HG::Rendering::Runtime::HGUtils::PackVector4(
		            &v43,
		            this->fields.m_CircularWindPhase,
		            this->fields.m_CircularWindOffset,
		            0.0,
		            (float)this->fields.Type,
		            0LL);
		LABEL_4:
		    v16 = (Vector4)_mm_loadu_si128((const __m128i *)v12);
		    TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                               (TileAnimationData *)&v43,
		                               v13,
		                               v14,
		                               v15,
		                               v41);
		    Param4 = (__m128i)v44.Param4;
		    retstr->Param0 = v10;
		    Param3 = (Vector4)_mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
		    retstr->Param1 = v11;
		    retstr->Param2 = v16;
		LABEL_16:
		    retstr->Param3 = Param3;
		    goto LABEL_17;
		  }
		  if ( this->fields.Type != 2 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_QWORD *)&v42.x = v5;
		    v42.z = z;
		    v32 = HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, Radius, 0LL);
		    v33 = (float)this->fields.Priority;
		    v10 = (Vector4)_mm_loadu_si128((const __m128i *)v32);
		    *(float *)&v32 = this->fields.m_DirectionalWindPhase.z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&this->fields.m_DirectionalWindPhase.x;
		    LODWORD(v42.z) = (_DWORD)v32;
		    v34 = HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, v33, 0LL);
		    Type = (float)this->fields.Type;
		    v11 = (Vector4)_mm_loadu_si128((const __m128i *)v34);
		    *(float *)&v34 = this->fields.m_DirectionalWindOffset.z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&this->fields.m_DirectionalWindOffset.x;
		    LODWORD(v42.z) = (_DWORD)v34;
		    v12 = HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, Type, 0LL);
		    goto LABEL_4;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_QWORD *)&v42.x = v5;
		  v42.z = z;
		  v20 = HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, Radius, 0LL);
		  v21 = (float)this->fields.Priority;
		  v22 = (Vector4)_mm_loadu_si128((const __m128i *)v20);
		  *(float *)&v20 = this->fields.up.z;
		  *(_QWORD *)&v42.x = *(_QWORD *)&this->fields.up.x;
		  LODWORD(v42.z) = (_DWORD)v20;
		  v23 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(&v43, &v42, v21, 0LL));
		  v24 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          &v43,
		          (float)this->fields.vortexRingCount,
		          this->fields.vortexRingBlend,
		          this->fields.vortexRingSkew,
		          (float)this->fields.Type,
		          0LL);
		  m_VortexRingPhase = this->fields.m_VortexRingPhase;
		  v28 = (Vector4)_mm_loadu_si128((const __m128i *)v24);
		  if ( !m_VortexRingPhase )
		    goto LABEL_14;
		  if ( m_VortexRingPhase->max_length.size < 4u )
		    goto LABEL_11;
		  v29 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                    &v43,
		                                                    m_VortexRingPhase->vector[0],
		                                                    m_VortexRingPhase->vector[1],
		                                                    m_VortexRingPhase->vector[2],
		                                                    m_VortexRingPhase->vector[3],
		                                                    0LL));
		  m_VortexRingOffset = this->fields.m_VortexRingOffset;
		  if ( !m_VortexRingOffset )
		LABEL_14:
		    sub_1800D8260(v26, v25);
		  if ( m_VortexRingOffset->max_length.size < 4u )
		LABEL_11:
		    sub_1800D2AB0(v26, v25);
		  v31 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          &v43,
		          m_VortexRingOffset->vector[0],
		          m_VortexRingOffset->vector[1],
		          m_VortexRingOffset->vector[2],
		          m_VortexRingOffset->vector[3],
		          0LL);
		  retstr->Param0 = v22;
		  retstr->Param1 = v23;
		  Param4 = _mm_loadu_si128((const __m128i *)v31);
		  retstr->Param2 = v28;
		  retstr->Param3 = v29;
		LABEL_17:
		  result = retstr;
		  retstr->Param4 = (Vector4)Param4;
		  return result;
		}
		
	}
}
