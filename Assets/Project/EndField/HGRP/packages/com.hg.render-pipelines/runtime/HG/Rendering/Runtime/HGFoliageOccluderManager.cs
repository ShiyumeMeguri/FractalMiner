using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluderManager // TypeDefIndex: 37983
	{
		// Fields
		public const float OCCLUDER_FADE_TRANSITION_TIME = 0.5f; // Metadata: 0x02303812
		public const float OCCLUDER_COVERAGE_SIZE = 64f; // Metadata: 0x02303816
		public const float OCCLUDER_COVERAGE_HALF_SIZE = 32f; // Metadata: 0x0230381A
		public const int OCCLUDER_MASK_RESOLUTION = 512; // Metadata: 0x0230381E
		private float m_lodFadeValue; // 0x10
		private bool m_currentFrameTriggerTransition; // 0x14
		private Vector2 m_lastUpdateCameraPos; // 0x18
		private Vector2 m_currentCameraPos; // 0x20
		private Vector4 m_cameraParam; // 0x28
		private double m_prevTimeStamp; // 0x38
		private double m_currentTimeStamp; // 0x40
		private bool m_curMaskIsA; // 0x48
		private bool m_shouldRender; // 0x49
		private HGFoliageOccluderRenderParams m_params; // 0x50
	
		// Properties
		private Vector4 occluderScaleParam { get => default; } // 0x0000000189B6B310-0x0000000189B6B388 
		// Vector4 get_occluderScaleParam()
		Vector4 *HG::Rendering::Runtime::HGFoliageOccluderManager::get_occluderScaleParam(
		        Vector4 *__return_ptr retstr,
		        HGFoliageOccluderManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2620, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2620, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v9, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    *(_QWORD *)&retstr->z = LODWORD(this->fields.m_lodFadeValue);
		    retstr->x = 32.0;
		    retstr->y = 512.0;
		  }
		  return retstr;
		}
		
	
		// Constructors
		public HGFoliageOccluderManager() {} // 0x0000000182ED8BB0-0x0000000182ED8C00
		// HGFoliageOccluderManager()
		void HG::Rendering::Runtime::HGFoliageOccluderManager::HGFoliageOccluderManager(
		        HGFoliageOccluderManager *this,
		        MethodInfo *method)
		{
		  Vector2__StaticFields *static_fields; // rdx
		  float y; // xmm1_4
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  static_fields = TypeInfo::UnityEngine::Vector2->static_fields;
		  y = static_fields->negativeInfinityVector.y;
		  this->fields.m_lastUpdateCameraPos.x = static_fields->negativeInfinityVector.x;
		  this->fields.m_lastUpdateCameraPos.y = y;
		  this->fields.m_curMaskIsA = 1;
		  this->fields.m_currentCameraPos = 0LL;
		  this->fields.m_params = HG::Rendering::Runtime::HGFoliageOccluderRenderParams::get_defaultParams(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_params, v5, v6, v7, v8);
		}
		
	
		// Methods
		public HGFoliageOccluderRenderParams GetParams() => default; // 0x0000000189B6B240-0x0000000189B6B290
		// HGFoliageOccluderRenderParams GetParams()
		HGFoliageOccluderRenderParams *HG::Rendering::Runtime::HGFoliageOccluderManager::GetParams(
		        HGFoliageOccluderManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2621, 0LL) )
		    return this->fields.m_params;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2621, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_966(Patch, (Object *)this, 0LL);
		}
		
		public void PipelineUpdate() {} // 0x00000001838B4190-0x00000001838B4A70
		// Void PipelineUpdate()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGFoliageOccluderManager::PipelineUpdate(
		        HGFoliageOccluderManager *this,
		        MethodInfo *method)
		{
		  HGFoliageOccluderManager *v2; // rdi
		  HGFoliageOccluderManager *v3; // r12
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  double v10; // xmm6_8
		  bool IsCurrFrameTriggerTransition; // al
		  __int64 v12; // rdx
		  double m_currentTimeStamp; // xmm1_8
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  float z; // xmm8_4
		  char v17; // r15
		  struct HGCamera__Class *v18; // rax
		  HGCamera__StaticFields *static_fields; // rax
		  Dictionary_2_TKey_TValue_ValueCollection_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *Values; // rax
		  Type *v21; // rdx
		  __int64 v22; // rcx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *dictionary; // rbx
		  __int64 v26; // rdx
		  struct Object_1__Class *v27; // rcx
		  Int32__Array **v28; // r9
		  unsigned int v29; // eax
		  __int64 v30; // r8
		  __int64 v31; // rcx
		  __int64 v32; // rcx
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  SingleFieldAccessor__Class *klass; // rbx
		  Il2CppGenericClass *generic_class; // rsi
		  Il2CppGenericClass *v37; // rsi
		  unsigned int (__fastcall *v38)(Il2CppGenericClass *); // rax
		  __int64 v39; // rdx
		  Il2CppGenericClass *v40; // rsi
		  unsigned int (__fastcall *v41)(Il2CppGenericClass *); // rax
		  Il2CppGenericClass *v42; // rbx
		  __int64 (__fastcall *v43)(Il2CppGenericClass *); // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  __int64 v46; // rbx
		  void (__fastcall *v47)(__int64, Vector3 *); // rax
		  int z_low; // r14d
		  __int64 (*v49)(void); // rax
		  __int64 v50; // rbx
		  struct Object_1__Class *v51; // rcx
		  __int64 (*v52)(void); // rax
		  HGFoliageOccluderRenderParams *v53; // rcx
		  __int64 v54; // rbx
		  __int64 (__fastcall *v55)(__int64); // rax
		  __int64 v56; // rbx
		  void (__fastcall *v57)(__int64, Vector3 *); // rax
		  System::MathF *v58; // rcx
		  float y; // xmm0_4
		  HGFoliageOccluderRenderParams *m_params; // rbx
		  Matrix4x4 *CullingMatrix; // rax
		  __int128 v62; // xmm1
		  __int128 v63; // xmm2
		  __int128 v64; // xmm3
		  double (*v65)(void); // rax
		  float v66; // xmm2_4
		  __int64 v67; // rax
		  __int64 v68; // rax
		  __int64 v69; // rax
		  __int64 v70; // rax
		  __int64 v71; // rax
		  __int64 v72; // rax
		  __int64 v73; // rax
		  __int64 v74; // rax
		  __int64 v75; // rax
		  Vector3 v76; // [rsp+20h] [rbp-118h] BYREF
		  Vector3 v77; // [rsp+30h] [rbp-108h] BYREF
		  __int128 v78; // [rsp+40h] [rbp-F8h] BYREF
		  SingleFieldAccessor v79; // [rsp+50h] [rbp-E8h] BYREF
		  Matrix4x4 v80[2]; // [rsp+88h] [rbp-B0h] BYREF
		  char v82; // [rsp+150h] [rbp+18h]
		
		  v2 = this;
		  v3 = this;
		  v78 = 0LL;
		  v79.klass = 0LL;
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v4, method);
		  if ( wrapperArray->max_length.size <= 2326 )
		    goto LABEL_12;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = v4->static_fields->wrapperArray;
		  if ( !v6 )
		    sub_1800D8260(v4, method);
		  if ( v6->max_length.size <= 0x916u )
		    sub_1800D2AB0(v4, method);
		  if ( !v6[64].vector[22] )
		  {
		LABEL_12:
		    v2->fields.m_shouldRender = 0;
		    v10 = UnityEngine::Time::get_timeAsDouble(0LL) - v2->fields.m_currentTimeStamp;
		    IsCurrFrameTriggerTransition = UnityEngine::HyperGryph::HGLODStateSystem::IsCurrFrameTriggerTransition(0LL);
		    if ( IsCurrFrameTriggerTransition )
		      IsCurrFrameTriggerTransition = v10 > 1.401298464324817e-45;
		    v2->fields.m_currentFrameTriggerTransition = IsCurrFrameTriggerTransition;
		    if ( v10 >= 0.0 && !IsCurrFrameTriggerTransition )
		    {
		      v2->fields.m_currentFrameTriggerTransition = 0;
		      goto LABEL_87;
		    }
		    v2->fields.m_currentFrameTriggerTransition = 1;
		    m_currentTimeStamp = v2->fields.m_currentTimeStamp;
		    v2->fields.m_currentTimeStamp = v2->fields.m_prevTimeStamp;
		    v2->fields.m_prevTimeStamp = m_currentTimeStamp;
		    v2->fields.m_currentTimeStamp = UnityEngine::Time::get_timeAsDouble(0LL);
		    *(_QWORD *)&v76.x = 0LL;
		    z = 0.0;
		    v76.z = 0.0;
		    v17 = 0;
		    v82 = 0;
		    v18 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v18 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    static_fields = v18->static_fields;
		    if ( !static_fields->s_Cameras )
		      sub_1800D8260(v15, v14);
		    Values = System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,Beyond::ObjectPtr<System::Object>>::get_Values(
		               (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)static_fields->s_Cameras,
		               MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
		    if ( !Values )
		      sub_1800D8260(v22, v21);
		    dictionary = Values->fields._dictionary;
		    *(_OWORD *)&v79.fields.setValueDelegate = 0LL;
		    v79.fields._.descriptor = (FieldDescriptor *)dictionary;
		    sub_18002D1B0((SingleFieldAccessor *)&v79.fields._.descriptor, v21, v23, v24, *(MethodInfo **)&v76.x);
		    if ( !dictionary )
		      sub_1800D8260(v27, v26);
		    HIDWORD(v79.fields.setValueDelegate) = dictionary->fields._version;
		    LODWORD(v79.fields.setValueDelegate) = 0;
		    v79.fields.clearDelegate = 0LL;
		    v78 = *(_OWORD *)&v79.fields._.descriptor;
		    v79.klass = 0LL;
		    v79.monitor = 0LL;
		    v79.fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)&v78;
		    try
		    {
		      z_low = _mm_cvtsi128_si32((__m128i)0LL);
		LABEL_21:
		      if ( !(_QWORD)v78 )
		        sub_1800D8250(v27, 0LL);
		      if ( HIDWORD(v78) != *(_DWORD *)(v78 + 44) )
		        System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		      v29 = DWORD2(v78);
		      while ( v29 < *(_DWORD *)(v78 + 32) )
		      {
		        v30 = *(_QWORD *)(v78 + 24);
		        v31 = (int)v29++;
		        DWORD2(v78) = v29;
		        if ( !v30 )
		          sub_1800D8250(v31, v78);
		        if ( (unsigned int)v31 >= *(_DWORD *)(v30 + 24) )
		          sub_1800D2AA0(v31, v78, v30);
		        v32 = 32 * (v31 + 1);
		        if ( *(int *)(v32 + v30) >= 0 )
		        {
		          v79.klass = *(SingleFieldAccessor__Class **)(v32 + v30 + 24);
		          sub_18002D1B0(&v79, (Type *)v78, (PropertyInfo_1 *)v30, v28, *(MethodInfo **)&v76.x);
		          klass = v79.klass;
		          if ( !v79.klass )
		            sub_1800D8250(v34, v33);
		          generic_class = v79.klass->_0.generic_class;
		          v27 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v27 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v27 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( generic_class )
		          {
		            if ( !v27->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v27);
		            if ( generic_class->context.method_inst )
		            {
		              if ( !klass )
		                sub_1800D8250(v27, v33);
		              v37 = klass->_0.generic_class;
		              if ( !v37 )
		                sub_1800D8250(v27, v33);
		              v38 = (unsigned int (__fastcall *)(Il2CppGenericClass *))qword_18F36F138;
		              if ( !qword_18F36F138 )
		              {
		                v38 = (unsigned int (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		                if ( !v38 )
		                {
		                  v67 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		                  sub_18007E1B0(v67, 0LL);
		                }
		                qword_18F36F138 = (__int64)v38;
		              }
		              if ( v38(v37) == 2 )
		                goto LABEL_47;
		              v40 = klass->_0.generic_class;
		              if ( !v40 )
		                sub_1800D8250(v27, v39);
		              v41 = (unsigned int (__fastcall *)(Il2CppGenericClass *))qword_18F36F138;
		              if ( !qword_18F36F138 )
		              {
		                v41 = (unsigned int (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		                if ( !v41 )
		                {
		                  v68 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		                  sub_18007E1B0(v68, 0LL);
		                }
		                qword_18F36F138 = (__int64)v41;
		              }
		              if ( v41(v40) == 1 )
		              {
		LABEL_47:
		                v42 = klass->_0.generic_class;
		                if ( !v42 )
		                  sub_1800D8250(v27, v39);
		                v43 = (__int64 (__fastcall *)(Il2CppGenericClass *))qword_18F36FBC0;
		                if ( !qword_18F36FBC0 )
		                {
		                  v43 = (__int64 (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		                  if ( !v43 )
		                  {
		                    v69 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		                    sub_18007E1B0(v69, 0LL);
		                  }
		                  qword_18F36FBC0 = (__int64)v43;
		                }
		                v46 = v43(v42);
		                if ( !v46 )
		                  sub_1800D8250(v45, v44);
		                *(_QWORD *)&v77.x = 0LL;
		                v77.z = 0.0;
		                v47 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		                if ( !qword_18F3700F0 )
		                {
		                  v47 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                  if ( !v47 )
		                  {
		                    v70 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                    sub_18007E1B0(v70, 0LL);
		                  }
		                  qword_18F3700F0 = (__int64)v47;
		                }
		                v47(v46, &v77);
		                v76 = v77;
		                z_low = LODWORD(v77.z);
		                v17 = 1;
		                v82 = 1;
		                z = v77.z;
		              }
		            }
		          }
		          goto LABEL_21;
		        }
		      }
		      DWORD2(v78) = *(_DWORD *)(v78 + 32) + 1;
		      v79.klass = 0LL;
		    }
		    catch ( Il2CppExceptionWrapper *&v79.fields.hasDelegate )
		    {
		      v79.monitor = (MonitorData *)v79.fields.hasDelegate->klass;
		      if ( v79.monitor )
		        sub_18007E1E0(v79.monitor);
		      v2 = this;
		      z = v76.z;
		      z_low = _mm_cvtsi128_si32((__m128i)LODWORD(v76.z));
		      v17 = v82;
		      v3 = this;
		    }
		    v49 = (__int64 (*)(void))qword_18F36F1B0;
		    if ( !qword_18F36F1B0 )
		    {
		      v49 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Camera::get_main()");
		      if ( !v49 )
		      {
		        v71 = sub_1802EE1B8("UnityEngine.Camera::get_main()");
		        sub_18007E1B0(v71, 0LL);
		      }
		      qword_18F36F1B0 = (__int64)v49;
		    }
		    v50 = v49();
		    v51 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v51 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v51 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !v50 )
		      goto LABEL_81;
		    if ( !v51->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v51);
		    if ( *(_QWORD *)(v50 + 16) )
		    {
		      v52 = (__int64 (*)(void))qword_18F36F1B0;
		      if ( !qword_18F36F1B0 )
		      {
		        v52 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Camera::get_main()");
		        if ( !v52 )
		        {
		          v72 = sub_1802EE1B8("UnityEngine.Camera::get_main()");
		          sub_18007E1B0(v72, 0LL);
		        }
		        qword_18F36F1B0 = (__int64)v52;
		      }
		      v54 = v52();
		      if ( !v54 )
		        goto LABEL_100;
		      v55 = (__int64 (__fastcall *)(__int64))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v55 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		        if ( !v55 )
		        {
		          v73 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		          sub_18007E1B0(v73, 0LL);
		        }
		        qword_18F36FBC0 = (__int64)v55;
		      }
		      v56 = v55(v54);
		      if ( !v56 )
		        goto LABEL_100;
		      memset(&v77, 0, sizeof(v77));
		      v57 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v57 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v57 )
		        {
		          v74 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v74, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v57;
		      }
		      v57(v56, &v77);
		      *(_QWORD *)&v76.x = *(_QWORD *)&v77.x;
		      z_low = LODWORD(v77.z);
		      v17 = 1;
		      z = v77.z;
		    }
		    else
		    {
		LABEL_81:
		      if ( !v17 )
		        goto LABEL_83;
		    }
		    System::MathF::Floor((System::MathF *)v51, 0.0);
		    v2->fields.m_currentCameraPos.x = (float)(v76.x * 8.0) * 0.125;
		    System::MathF::Floor(v58, 0.0);
		    v2->fields.m_currentCameraPos.y = (float)(z * 8.0) * 0.125;
		LABEL_83:
		    *(_OWORD *)&v79.monitor = *(_OWORD *)&v2->fields.m_lastUpdateCameraPos.x;
		    v2->fields.m_cameraParam = *(Vector4 *)&v79.monitor;
		    y = v2->fields.m_currentCameraPos.y;
		    v2->fields.m_lastUpdateCameraPos.x = v2->fields.m_currentCameraPos.x;
		    v2->fields.m_lastUpdateCameraPos.y = y;
		    v2->fields.m_curMaskIsA = !v2->fields.m_curMaskIsA;
		    v2->fields.m_shouldRender = 1;
		    if ( v17 )
		    {
		      m_params = v2->fields.m_params;
		      LODWORD(v76.z) = z_low;
		      CullingMatrix = HG::Rendering::Runtime::HGFoliageOccluderManager::_GetCullingMatrix(v80, v2, &v76, 0LL);
		      v62 = *(_OWORD *)&CullingMatrix->m01;
		      v63 = *(_OWORD *)&CullingMatrix->m02;
		      v64 = *(_OWORD *)&CullingMatrix->m03;
		      if ( !m_params )
		        goto LABEL_100;
		      *(_OWORD *)&m_params->fields.cullingMatrix.m00 = *(_OWORD *)&CullingMatrix->m00;
		      *(_OWORD *)&m_params->fields.cullingMatrix.m01 = v62;
		      *(_OWORD *)&m_params->fields.cullingMatrix.m02 = v63;
		      *(_OWORD *)&m_params->fields.cullingMatrix.m03 = v64;
		    }
		LABEL_87:
		    v53 = v2->fields.m_params;
		    if ( !v53 )
		      goto LABEL_100;
		    v53->fields.shouldRender = v2->fields.m_shouldRender;
		    v53 = v2->fields.m_params;
		    if ( !v53 )
		      goto LABEL_100;
		    v53->fields.curMaskIsA = v2->fields.m_curMaskIsA;
		    if ( v2->fields.m_currentTimeStamp - v2->fields.m_prevTimeStamp < 1.401298464324817e-45 )
		    {
		      v2->fields.m_shouldRender = 0;
		    }
		    else
		    {
		      v65 = (double (*)(void))qword_18F36FFA8;
		      if ( !qword_18F36FFA8 )
		      {
		        v65 = (double (*)(void))il2cpp_resolve_icall_1("UnityEngine.Time::get_timeAsDouble()");
		        if ( !v65 )
		        {
		          v75 = sub_1802EE1B8("UnityEngine.Time::get_timeAsDouble()");
		          sub_18007E1B0(v75, 0LL);
		        }
		        qword_18F36FFA8 = (__int64)v65;
		      }
		      v66 = (v65() - 0.5 - v2->fields.m_prevTimeStamp) / (v2->fields.m_currentTimeStamp - v2->fields.m_prevTimeStamp);
		      if ( v66 >= 0.0 )
		      {
		        if ( v66 > 1.0 )
		          v66 = 1.0;
		LABEL_98:
		        v3->fields.m_lodFadeValue = v66;
		        v53 = v2->fields.m_params;
		        if ( v53 )
		        {
		          v53->fields.lodFadeValue = v2->fields.m_lodFadeValue;
		          return;
		        }
		LABEL_100:
		        sub_1800D8250(v53, v12);
		      }
		    }
		    v66 = 0.0;
		    goto LABEL_98;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2326, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v9, v8);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		}
		
		public void SetShaderVariablesGlobalFoliageOccluder(ref ShaderVariablesGlobal cb) {} // 0x0000000189B6B290-0x0000000189B6B310
		// Void SetShaderVariablesGlobalFoliageOccluder(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGFoliageOccluderManager::SetShaderVariablesGlobalFoliageOccluder(
		        HGFoliageOccluderManager *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2622, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2622, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		  }
		  else
		  {
		    *(__m128i *)&cb[1]._LastWindMotorParams3.FixedElementField = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGFoliageOccluderManager::get_occluderScaleParam(
		                                                                                                    &v8,
		                                                                                                    this,
		                                                                                                    0LL));
		    *(__m128i *)&cb[1]._FoliageInteractiveParams0.w = _mm_loadu_si128((const __m128i *)&this->fields.m_cameraParam);
		  }
		}
		
		private Matrix4x4 _GetCullingMatrix(Vector3 camPos) => default; // 0x00000001838B4AF0-0x00000001838B4DD0
		// Matrix4x4 _GetCullingMatrix(Vector3)
		Matrix4x4 *HG::Rendering::Runtime::HGFoliageOccluderManager::_GetCullingMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGFoliageOccluderManager *this,
		        Vector3 *camPos,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  void (__fastcall *v9)(Matrix4x4 *, ILFixDynamicMethodWrapper_2__Array *, Vector3 *, MethodInfo *, int, int, Matrix4x4 *); // rax
		  float z; // eax
		  MethodInfo *v11; // r9
		  Vector3 *v12; // rax
		  __int64 v13; // xmm0_8
		  __int64 v14; // xmm0_8
		  void (__fastcall *v15)(__int64 *, Vector3 *, Vector3 *, __int128 *); // rax
		  void (__fastcall *v16)(_OWORD *, __int128 *); // rax
		  void (__fastcall *v17)(Matrix4x4 *, __int128 *, Matrix4x4 *); // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Matrix4x4 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // xmm0_8
		  Matrix4x4 *v24; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int64 v27; // rax
		  __int64 v28; // rax
		  __int64 v29; // rax
		  __int64 v30; // rax
		  Vector3 v31; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 v32; // [rsp+50h] [rbp-B0h] BYREF
		  Matrix4x4 v33; // [rsp+60h] [rbp-A0h] BYREF
		  __int64 v34; // [rsp+A0h] [rbp-60h] BYREF
		  float v35; // [rsp+A8h] [rbp-58h]
		  __int128 v36; // [rsp+B0h] [rbp-50h] BYREF
		  __int128 v37; // [rsp+C0h] [rbp-40h]
		  __int128 v38; // [rsp+D0h] [rbp-30h]
		  __int128 v39; // [rsp+E0h] [rbp-20h]
		  __int128 v40; // [rsp+F0h] [rbp-10h] BYREF
		  __int128 v41; // [rsp+100h] [rbp+0h]
		  __int128 v42; // [rsp+110h] [rbp+10h]
		  __int128 v43; // [rsp+120h] [rbp+20h]
		  Matrix4x4 v44; // [rsp+130h] [rbp+30h] BYREF
		  Vector3 v45; // [rsp+170h] [rbp+70h] BYREF
		  _OWORD v46[4]; // [rsp+180h] [rbp+80h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 2327 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x917 )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !*(_QWORD *)&v6[49]._1.cctor_finished_or_no_cctor )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2327, 0LL);
		      if ( Patch )
		      {
		        v23 = *(_QWORD *)&camPos->x;
		        v31.z = camPos->z;
		        *(_QWORD *)&v31.x = v23;
		        v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_921(&v44, Patch, (Object *)this, &v31, 0LL);
		        v25 = *(_OWORD *)&v24->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v24->m00;
		        v26 = *(_OWORD *)&v24->m02;
		        *(_OWORD *)&retstr->m01 = v25;
		        v20 = *(_OWORD *)&v24->m03;
		        *(_OWORD *)&retstr->m02 = v26;
		        goto LABEL_10;
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  v9 = (void (__fastcall *)(Matrix4x4 *, ILFixDynamicMethodWrapper_2__Array *, Vector3 *, MethodInfo *, int, int, Matrix4x4 *))qword_18F36FA70;
		  memset(&v33, 0, sizeof(v33));
		  if ( !qword_18F36FA70 )
		  {
		    v9 = (void (__fastcall *)(Matrix4x4 *, ILFixDynamicMethodWrapper_2__Array *, Vector3 *, MethodInfo *, int, int, Matrix4x4 *))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::Ortho_Injected(System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,UnityEngine.Matrix4x4&)");
		    if ( !v9 )
		    {
		      v27 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::Ortho_Injected(System.Single,System.Single,System.Single,System.Single,System.Singl"
		              "e,System.Single,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v27, 0LL);
		    }
		    qword_18F36FA70 = (__int64)v9;
		  }
		  v9(&v33, wrapperArray, camPos, method, -1010827264, 1136656384, &v33);
		  z = camPos->z;
		  v31.z = 0.0;
		  *(_QWORD *)&v31.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  *(_QWORD *)&v32.x = *(_QWORD *)&camPos->x;
		  v32.z = z;
		  v12 = UnityEngine::Vector3::op_Addition(&v45, &v32, &v31, v11);
		  *(_QWORD *)&v32.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v13 = *(_QWORD *)&v12->x;
		  *(float *)&v12 = v12->z;
		  *(_QWORD *)&v31.x = v13;
		  v14 = *(_QWORD *)&camPos->x;
		  LODWORD(v31.z) = (_DWORD)v12;
		  v35 = camPos->z;
		  v15 = (void (__fastcall *)(__int64 *, Vector3 *, Vector3 *, __int128 *))qword_18F36FA80;
		  v34 = v14;
		  v32.z = 1.0;
		  v36 = 0LL;
		  v37 = 0LL;
		  v38 = 0LL;
		  v39 = 0LL;
		  if ( !qword_18F36FA80 )
		  {
		    v15 = (void (__fastcall *)(__int64 *, Vector3 *, Vector3 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                              "UnityEngine.Matrix4x4::LookAt_Injected(Uni"
		                                                                              "tyEngine.Vector3&,UnityEngine.Vector3&,Uni"
		                                                                              "tyEngine.Vector3&,UnityEngine.Matrix4x4&)");
		    if ( !v15 )
		    {
		      v28 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::LookAt_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v28, 0LL);
		    }
		    qword_18F36FA80 = (__int64)v15;
		  }
		  v15(&v34, &v31, &v32, &v36);
		  v16 = (void (__fastcall *)(_OWORD *, __int128 *))qword_18F36FA60;
		  v46[0] = v36;
		  v46[1] = v37;
		  v46[2] = v38;
		  v46[3] = v39;
		  v40 = 0LL;
		  v41 = 0LL;
		  v42 = 0LL;
		  v43 = 0LL;
		  if ( !qword_18F36FA60 )
		  {
		    v16 = (void (__fastcall *)(_OWORD *, __int128 *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,Un"
		                                                       "ityEngine.Matrix4x4&)");
		    if ( !v16 )
		    {
		      v29 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v29, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v16;
		  }
		  v16(v46, &v40);
		  v17 = (void (__fastcall *)(Matrix4x4 *, __int128 *, Matrix4x4 *))qword_18F36FA50;
		  v44 = v33;
		  v36 = v40;
		  v37 = v41;
		  v38 = v42;
		  v39 = v43;
		  memset(&v33, 0, sizeof(v33));
		  if ( !qword_18F36FA50 )
		  {
		    v17 = (void (__fastcall *)(Matrix4x4 *, __int128 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                       "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
		                                                                       "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
		                                                                       "x4&,UnityEngine.Matrix4x4&)");
		    if ( !v17 )
		    {
		      v30 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v30, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v17;
		  }
		  v17(&v44, &v36, &v33);
		  v18 = *(_OWORD *)&v33.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v33.m00;
		  v19 = *(_OWORD *)&v33.m02;
		  *(_OWORD *)&retstr->m01 = v18;
		  v20 = *(_OWORD *)&v33.m03;
		  *(_OWORD *)&retstr->m02 = v19;
		LABEL_10:
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v20;
		  return result;
		}
		
	}
}
