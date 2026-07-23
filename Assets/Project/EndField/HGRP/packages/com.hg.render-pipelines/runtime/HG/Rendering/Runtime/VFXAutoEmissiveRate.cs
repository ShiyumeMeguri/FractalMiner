using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXAutoEmissiveRate(\u6839\u636E\u7F29\u653E\u589E\u52A0\u4F8B\u5B50\u6570)")]
	[ExecuteAlways]
	[RequireComponent(typeof(ParticleSystem))]
	public class VFXAutoEmissiveRate : VFXPlayableMonoBase // TypeDefIndex: 37970
	{
		// Fields
		[Header("\u7F29\u653E\u4E3A1\u65F6\u7684rate,\u6700\u5927\u53EA\u652F\u630110x10x10")]
		public float rateOverTime; // 0x20
		public ScaleMode scaleMode; // 0x24
		public ParticleSystemScalingMode particleSystemScalingMode; // 0x28
		public AxisBitMask axisBitMask; // 0x2C
		private ParticleSystem m_particleSystem; // 0x30
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 37968
		{
			Global = 0,
			Local = 1
		}
	
		[Flags]
		public enum AxisBitMask // TypeDefIndex: 37969
		{
			X = 1,
			Y = 2,
			Z = 4,
			All = 7
		}
	
		// Constructors
		public VFXAutoEmissiveRate() {} // 0x00000001842EE050-0x00000001842EE090
		// VFXAutoEmissiveRate()
		void HG::Rendering::Runtime::VFXAutoEmissiveRate::VFXAutoEmissiveRate(VFXAutoEmissiveRate *this, MethodInfo *method)
		{
		  this->fields.particleSystemScalingMode = 2;
		  this->fields.axisBitMask = 7;
		  this->fields._.m_isPlaying = 1;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void Awake() {} // 0x0000000183820C20-0x0000000183820C70
		// Void Awake()
		void HG::Rendering::Runtime::VFXAutoEmissiveRate::Awake(VFXAutoEmissiveRate *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2588, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2588, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_particleSystem = (ParticleSystem *)UnityEngine::Component::GetComponent<System::Object>(
		                                                        (Component *)this,
		                                                        MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::ParticleSystem>);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_particleSystem, v3, v4, v5, v9);
		  }
		}
		
		protected override void OnPlay() {} // 0x0000000183E03E20-0x0000000183E03E60
		// Void OnPlay()
		void HG::Rendering::Runtime::VFXAutoEmissiveRate::OnPlay(VFXAutoEmissiveRate *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2589, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2589, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(this, 0LL);
		  }
		}
		
		private void OnValidate() {} // 0x0000000189B5F53C-0x0000000189B5F58C
		// Void OnValidate()
		void HG::Rendering::Runtime::VFXAutoEmissiveRate::OnValidate(VFXAutoEmissiveRate *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2591, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2591, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(this, 0LL);
		  }
		}
		
		public void AppyValue() {} // 0x0000000183E03E60-0x0000000183E04160
		// Void AppyValue()
		void HG::Rendering::Runtime::VFXAutoEmissiveRate::AppyValue(VFXAutoEmissiveRate *this, MethodInfo *method)
		{
		  int v3; // ebx
		  Object_1 *m_particleSystem; // rsi
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  int32_t scaleMode; // eax
		  float x; // xmm1_4
		  float y; // xmm2_4
		  float z; // xmm3_4
		  unsigned __int64 axisBitMask; // rdx
		  __int64 v12; // rcx
		  Transform *transform; // rsi
		  void (__fastcall *v14)(Transform *, Vector3 *); // rax
		  float v15; // xmm6_4
		  float v16; // xmm0_4
		  void (__fastcall *v17)(__int64 *, __int128 *); // rax
		  void (__fastcall *v18)(__int64 *, _OWORD *); // rax
		  __m128 v19; // xmm1
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  __int64 v21; // rcx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  unsigned int particleSystemScalingMode; // ebx
		  void (__fastcall *v25)(__int64 *, _QWORD); // rax
		  __int64 (__fastcall *v26)(__int64 *); // rax
		  int v27; // edi
		  unsigned int v28; // ebx
		  void (__fastcall *v29)(__int64 *, _QWORD); // rax
		  __int64 v30; // rax
		  Transform *v31; // rax
		  Vector3 *localScale; // rax
		  __int64 v33; // rax
		  SystemException *v34; // rbx
		  String *v35; // rax
		  __int64 v36; // rax
		  __int64 v37; // rax
		  __int64 v38; // rax
		  __int64 v39; // rax
		  __int64 v40; // rax
		  __int64 v41; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v43; // [rsp+20h] [rbp-39h] BYREF
		  __int128 v44; // [rsp+30h] [rbp-29h] BYREF
		  __m128 v45; // [rsp+40h] [rbp-19h]
		  _OWORD v46[4]; // [rsp+50h] [rbp-9h] BYREF
		  __int64 v47; // [rsp+D0h] [rbp+77h] BYREF
		  __int64 v48; // [rsp+D8h] [rbp+7Fh] BYREF
		
		  v3 = 0;
		  v48 = 0LL;
		  v47 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2590, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2590, 0LL);
		    if ( !Patch )
		      goto LABEL_35;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		    return;
		  }
		  m_particleSystem = (Object_1 *)this->fields.m_particleSystem;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit(m_particleSystem, 0LL) )
		    return;
		  scaleMode = this->fields.scaleMode;
		  x = 0.0;
		  y = 0.0;
		  z = 0.0;
		  if ( !scaleMode )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( !transform )
		      goto LABEL_35;
		    *(_QWORD *)&v43.x = 0LL;
		    v43.z = 0.0;
		    v14 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F370198;
		    if ( !qword_18F370198 )
		    {
		      v14 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		      if ( !v14 )
		      {
		        v30 = sub_1802EE1B8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v30, 0LL);
		      }
		      qword_18F370198 = (__int64)v14;
		    }
		    v14(transform, &v43);
		    y = v43.y;
		    z = v43.z;
		LABEL_9:
		    x = v43.x;
		    goto LABEL_10;
		  }
		  if ( scaleMode == 1 )
		  {
		    v31 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( !v31 )
		      goto LABEL_35;
		    localScale = UnityEngine::Transform::get_localScale(&v43, v31, 0LL);
		    z = localScale->z;
		    LODWORD(y) = _mm_shuffle_ps(
		                   (__m128)*(unsigned __int64 *)&localScale->x,
		                   (__m128)*(unsigned __int64 *)&localScale->x,
		                   85).m128_u32[0];
		    *(_QWORD *)&v43.x = *(_QWORD *)&localScale->x;
		    goto LABEL_9;
		  }
		LABEL_10:
		  v15 = 1.0;
		  axisBitMask = (unsigned int)this->fields.axisBitMask;
		  do
		  {
		    v12 = v3 & 0x1F;
		    if ( (((int)axisBitMask >> v12) & 1) != 0 )
		    {
		      v12 = (unsigned int)v3;
		      if ( v3 )
		      {
		        v12 = (unsigned int)(v3 - 1);
		        if ( v3 == 1 )
		        {
		          v16 = y;
		        }
		        else
		        {
		          if ( v3 != 2 )
		          {
		            v33 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		            v34 = (SystemException *)sub_1800368D0(v33);
		            if ( v34 )
		            {
		              v35 = (String *)sub_180035ED0(&off_18E34DB98);
		              System::SystemException::SystemException(v34, v35, 0LL);
		              v34->fields._._HResult = -2146233080;
		              v36 = sub_180035ED0(&MethodInfo::UnityEngine::Vector3::get_Item);
		              sub_18007E190(v34, v36);
		            }
		LABEL_35:
		            sub_1800D8260(v12, axisBitMask);
		          }
		          v16 = z;
		        }
		      }
		      else
		      {
		        v16 = x;
		      }
		      v15 = v15 * v16;
		    }
		    ++v3;
		  }
		  while ( v3 < 3 );
		  if ( v15 > 1000.0 )
		    v15 = 1000.0;
		  if ( !this->fields.m_particleSystem )
		    goto LABEL_35;
		  *(_QWORD *)&v43.x = this->fields.m_particleSystem;
		  ((void (__stdcall *)(HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, Int32__Array **))sub_18002D1B0)(
		    (HGRuntimeGrassQuery_Node *)&v43,
		    (HGRuntimeGrassQuery_Node *)axisBitMask,
		    v5,
		    v6);
		  v48 = *(_QWORD *)&v43.x;
		  v17 = (void (__fastcall *)(__int64 *, __int128 *))qword_18F370DF0;
		  v44 = 0LL;
		  v45 = 0LL;
		  if ( !qword_18F370DF0 )
		  {
		    v17 = (void (__fastcall *)(__int64 *, __int128 *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Inje"
		                                                        "cted(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.Part"
		                                                        "icleSystem/MinMaxCurve&)");
		    if ( !v17 )
		    {
		      v37 = sub_1802EE1B8(
		              "UnityEngine.ParticleSystem/EmissionModule::get_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionMo"
		              "dule&,UnityEngine.ParticleSystem/MinMaxCurve&)");
		      sub_18007E1B0(v37, 0LL);
		    }
		    qword_18F370DF0 = (__int64)v17;
		  }
		  v17(&v48, &v44);
		  v18 = (void (__fastcall *)(__int64 *, _OWORD *))qword_18F370DF8;
		  v19 = _mm_shuffle_ps(v45, v45, 147);
		  v19.m128_f32[0] = v15 * this->fields.rateOverTime;
		  v46[1] = _mm_shuffle_ps(v19, v19, 57);
		  v46[0] = v44;
		  if ( !qword_18F370DF8 )
		  {
		    v18 = (void (__fastcall *)(__int64 *, _OWORD *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Inject"
		                                                      "ed(UnityEngine.ParticleSystem/EmissionModule&,UnityEngine.Particle"
		                                                      "System/MinMaxCurve&)");
		    if ( !v18 )
		    {
		      v38 = sub_1802EE1B8(
		              "UnityEngine.ParticleSystem/EmissionModule::set_rateOverTime_Injected(UnityEngine.ParticleSystem/EmissionMo"
		              "dule&,UnityEngine.ParticleSystem/MinMaxCurve&)");
		      sub_18007E1B0(v38, 0LL);
		    }
		    qword_18F370DF8 = (__int64)v18;
		  }
		  v18(&v48, v46);
		  if ( !this->fields.m_particleSystem )
		    sub_1800D8260(v21, v20);
		  *(_QWORD *)&v43.x = this->fields.m_particleSystem;
		  ((void (__stdcall *)(HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, Int32__Array **))sub_18002D1B0)(
		    (HGRuntimeGrassQuery_Node *)&v43,
		    v20,
		    v22,
		    v23);
		  particleSystemScalingMode = this->fields.particleSystemScalingMode;
		  v47 = *(_QWORD *)&v43.x;
		  v25 = (void (__fastcall *)(__int64 *, _QWORD))qword_18F370DD8;
		  if ( !qword_18F370DD8 )
		  {
		    v25 = (void (__fastcall *)(__int64 *, _QWORD))il2cpp_resolve_icall_1(
		                                                    "UnityEngine.ParticleSystem/MainModule::set_scalingMode_Injected(Unit"
		                                                    "yEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystemScalingMode)");
		    if ( !v25 )
		    {
		      v39 = sub_1802EE1B8(
		              "UnityEngine.ParticleSystem/MainModule::set_scalingMode_Injected(UnityEngine.ParticleSystem/MainModule&,Uni"
		              "tyEngine.ParticleSystemScalingMode)");
		      sub_18007E1B0(v39, 0LL);
		    }
		    qword_18F370DD8 = (__int64)v25;
		  }
		  v25(&v47, particleSystemScalingMode);
		  v26 = (__int64 (__fastcall *)(__int64 *))qword_18F370DE0;
		  if ( !qword_18F370DE0 )
		  {
		    v26 = (__int64 (__fastcall *)(__int64 *))il2cpp_resolve_icall_1(
		                                               "UnityEngine.ParticleSystem/MainModule::get_maxParticles_Injected(UnityEng"
		                                               "ine.ParticleSystem/MainModule&)");
		    if ( !v26 )
		    {
		      v40 = sub_1802EE1B8("UnityEngine.ParticleSystem/MainModule::get_maxParticles_Injected(UnityEngine.ParticleSystem/MainModule&)");
		      sub_18007E1B0(v40, 0LL);
		    }
		    qword_18F370DE0 = (__int64)v26;
		  }
		  v27 = v26(&v47);
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v28 = 1000;
		  if ( v27 < 1000 )
		    v28 = v27;
		  v29 = (void (__fastcall *)(__int64 *, _QWORD))qword_18F370DE8;
		  if ( !qword_18F370DE8 )
		  {
		    v29 = (void (__fastcall *)(__int64 *, _QWORD))il2cpp_resolve_icall_1(
		                                                    "UnityEngine.ParticleSystem/MainModule::set_maxParticles_Injected(Uni"
		                                                    "tyEngine.ParticleSystem/MainModule&,System.Int32)");
		    if ( !v29 )
		    {
		      v41 = sub_1802EE1B8(
		              "UnityEngine.ParticleSystem/MainModule::set_maxParticles_Injected(UnityEngine.ParticleSystem/MainModule&,System.Int32)");
		      sub_18007E1B0(v41, 0LL);
		    }
		    qword_18F370DE8 = (__int64)v29;
		  }
		  v29(&v47, v28);
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
