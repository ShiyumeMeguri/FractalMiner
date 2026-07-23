using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGWindManager // TypeDefIndex: 37698
	{
		// Fields
		private HGWindSimpleManager m_simpleManager; // 0x10
		private WindQuality m_windQuality; // 0x18
	
		// Nested types
		public enum WindQuality // TypeDefIndex: 37697
		{
			Min = 0,
			Simple = 1,
			High = 2
		}
	
		// Constructors
		public HGWindManager() {} // 0x0000000182ED8B10-0x0000000182ED8B60
		// HGWindManager()
		void HG::Rendering::Runtime::HGWindManager::HGWindManager(HGWindManager *this, MethodInfo *method)
		{
		  HGWindSimpleManager *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGWindSimpleManager *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (HGWindSimpleManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::HGWindSimpleManager::HGWindSimpleManager(v3, 0LL);
		  this->fields.m_simpleManager = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v10);
		  this->fields.m_windQuality = 1;
		}
		
	
		// Methods
		public void SetWindFootMotor(int index, Vector3 position, float range) {} // 0x000000018323D710-0x000000018323D810
		// Void SetWindFootMotor(Int32, Vector3, Single)
		void HG::Rendering::Runtime::HGWindManager::SetWindFootMotor(
		        HGWindManager *this,
		        int32_t index,
		        Vector3 *position,
		        float range,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  __int64 v8; // rbx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 v10; // rax
		  __int64 v11; // rcx
		  float z; // eax
		  int32_t v13; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // xmm0_8
		  Vector3 v16; // [rsp+30h] [rbp-28h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v8 = index;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 1694 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_15;
		    if ( wrapperArray->max_length.size <= 0x69Eu )
		      goto LABEL_16;
		    if ( wrapperArray[47].vector[2] )
		    {
		      v13 = 1694;
		      goto LABEL_29;
		    }
		  }
		  this = (HGWindManager *)this->fields.m_simpleManager;
		  if ( !this )
		    goto LABEL_15;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 1695 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_15;
		    if ( wrapperArray->max_length.size > 0x69Fu )
		    {
		      if ( !wrapperArray[47].vector[3] )
		        goto LABEL_10;
		      v13 = 1695;
		LABEL_29:
		      Patch = IFix::WrappersManagerImpl::GetPatch(v13, 0LL);
		      if ( Patch )
		      {
		        v15 = *(_QWORD *)&position->x;
		        v16.z = position->z;
		        *(_QWORD *)&v16.x = v15;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_681(Patch, (Object *)this, v8, &v16, range, 0LL);
		        return;
		      }
		      goto LABEL_15;
		    }
		LABEL_16:
		    sub_1800D2AB0(v6, wrapperArray);
		  }
		LABEL_10:
		  if ( (unsigned int)v8 > 3 )
		    return;
		  v10 = *(_QWORD *)&this->fields.m_windQuality;
		  if ( !v10 )
		LABEL_15:
		    sub_1800D8260(v6, wrapperArray);
		  if ( (unsigned int)v8 >= *(_DWORD *)(v10 + 24) )
		    goto LABEL_16;
		  v11 = v10 + 16 * (v8 + 2);
		  z = position->z;
		  *(_QWORD *)(v11 + 4) = *(_QWORD *)&position->x;
		  *(float *)(v11 + 12) = z;
		  *(float *)v11 = range;
		}
		
		public void RemoveWindFootMotor(int index) {} // 0x0000000189CF6F94-0x0000000189CF7024
		// Void RemoveWindFootMotor(Int32)
		void HG::Rendering::Runtime::HGWindManager::RemoveWindFootMotor(HGWindManager *this, int32_t index, MethodInfo *method)
		{
		  Animator *v5; // rdx
		  int32_t v6; // r8d
		  MethodInfo *v7; // r9
		  Vector3 *Vector; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // xmm0_8
		  float z; // eax
		  HGWindSimpleManager *m_simpleManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v15; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v16[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1696, 0LL) )
		  {
		    Vector = UnityEngine::Animator::GetVector(v16, v5, v6, v7);
		    if ( this->fields.m_simpleManager )
		    {
		      v11 = *(_QWORD *)&Vector->x;
		      z = Vector->z;
		      m_simpleManager = this->fields.m_simpleManager;
		      *(_QWORD *)&v15.x = v11;
		      v15.z = z;
		      HG::Rendering::Runtime::HGWindSimpleManager::SetWindFootMotor(m_simpleManager, index, &v15, 0.0, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1696, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, index, 0LL);
		}
		
		public void RegisterWindMotor(HGWindMotor wind) {} // 0x0000000184774090-0x00000001847740E0
		// Void RegisterWindMotor(HGWindMotor)
		void HG::Rendering::Runtime::HGWindManager::RegisterWindMotor(
		        HGWindManager *this,
		        HGWindMotor *wind,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWindSimpleManager *m_simpleManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1697, 0LL) )
		  {
		    m_simpleManager = this->fields.m_simpleManager;
		    if ( m_simpleManager )
		    {
		      HG::Rendering::Runtime::HGWindSimpleManager::RegisterWindMotor(m_simpleManager, wind, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_simpleManager, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1697, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)wind,
		    0LL);
		}
		
		public void UnRegisterWindMotor(HGWindMotor wind) {} // 0x0000000184773F30-0x0000000184773F80
		// Void UnRegisterWindMotor(HGWindMotor)
		void HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(
		        HGWindManager *this,
		        HGWindMotor *wind,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWindSimpleManager *m_simpleManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1699, 0LL) )
		  {
		    m_simpleManager = this->fields.m_simpleManager;
		    if ( m_simpleManager )
		    {
		      HG::Rendering::Runtime::HGWindSimpleManager::UnRegisterWindMotor(m_simpleManager, wind, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_simpleManager, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1699, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)wind,
		    0LL);
		}
		
		public void GameplayUpdate(float deltaTime) {} // 0x00000001832E1160-0x00000001832E11D0
		// Void GameplayUpdate(Single)
		void HG::Rendering::Runtime::HGWindManager::GameplayUpdate(HGWindManager *this, float deltaTime, MethodInfo *method)
		{
		  HGWindSimpleManager *m_simpleManager; // rcx
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState___Class *klass; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = m_simpleManager[1].fields.m_windMotorState->klass;
		  if ( !klass )
		    goto LABEL_7;
		  if ( SLODWORD(klass->_0.namespaze) <= 1701 )
		    goto LABEL_5;
		  if ( !LODWORD(m_simpleManager[1].fields.m_windParamDataCache._WindMotorParams0.FixedElementField) )
		  {
		    il2cpp_runtime_class_init_1(m_simpleManager);
		    m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_simpleManager = (HGWindSimpleManager *)m_simpleManager[1].fields.m_windMotorState->klass;
		  if ( !m_simpleManager )
		    goto LABEL_7;
		  if ( LODWORD(m_simpleManager->fields.m_windFootMotors) <= 0x6A5 )
		    sub_1800D2AB0(m_simpleManager, klass);
		  if ( !m_simpleManager[100].fields.m_windMainState )
		  {
		LABEL_5:
		    m_simpleManager = this->fields.m_simpleManager;
		    if ( m_simpleManager )
		    {
		      HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(m_simpleManager, deltaTime, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_simpleManager, klass);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1701, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, deltaTime, 0LL);
		}
		
		public void SetupShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, int cameraGuid, Vector3 cameraPos, HGEnvironmentPhase phase) {} // 0x0000000183D08C30-0x0000000183D08F20
		// Void SetupShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, Int32, Vector3, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGWindManager::SetupShaderVariablesGlobalWind(
		        HGWindManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t cameraGuid,
		        Vector3 *cameraPos,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGWindManager__Class *klass; // rax
		  int32_t namespaze; // ebx
		  __int128 v14; // xmm0
		  float z; // eax
		  int32_t i; // ebx
		  HGWindManager__Class *v17; // rax
		  int v18; // ecx
		  __int64 namespaze_low; // rsi
		  float *v20; // rbx
		  int32_t v21; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  ILFixDynamicMethodWrapper_2 *v25; // rax
		  _OWORD v26[2]; // [rsp+40h] [rbp-28h] BYREF
		
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_35;
		  if ( wrapperArray->max_length.size > 915 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v8->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_35;
		    if ( wrapperArray->max_length.size <= 0x393u )
		      goto LABEL_64;
		    if ( wrapperArray[25].vector[15] )
		    {
		      v21 = 915;
		LABEL_48:
		      Patch = IFix::WrappersManagerImpl::GetPatch(v21, 0LL);
		      if ( !Patch )
		        goto LABEL_35;
		      v23 = *(_QWORD *)&cameraPos->x;
		      DWORD2(v26[0]) = LODWORD(cameraPos->z);
		      *(_QWORD *)&v26[0] = v23;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_374(
		        Patch,
		        (Object *)this,
		        cb,
		        cameraGuid,
		        (Vector3 *)v26,
		        (Object *)phase,
		        0LL);
		      return;
		    }
		  }
		  if ( this->fields.m_windQuality != 1 )
		    return;
		  this = (HGWindManager *)this->fields.m_simpleManager;
		  if ( !this )
		    goto LABEL_35;
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v8);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_35;
		  if ( wrapperArray->max_length.size > 916 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v8->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_35;
		    if ( wrapperArray->max_length.size <= 0x394u )
		      goto LABEL_64;
		    if ( wrapperArray[25].vector[16] )
		    {
		      v21 = 916;
		      goto LABEL_48;
		    }
		  }
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMain(
		    (HGWindSimpleManager *)this,
		    cb,
		    cameraGuid,
		    phase,
		    0LL);
		  klass = this[1].klass;
		  if ( !klass )
		    goto LABEL_35;
		  namespaze = 4;
		  if ( SLODWORD(klass->_0.namespaze) < 4 )
		    namespaze = (int32_t)klass->_0.namespaze;
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_35;
		  if ( wrapperArray->max_length.size <= 918 )
		    goto LABEL_18;
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v8);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_35;
		  if ( wrapperArray->max_length.size <= 0x396u )
		LABEL_64:
		    sub_1800D2AB0(v8, wrapperArray);
		  if ( wrapperArray[25].vector[18] )
		  {
		    v24 = IFix::WrappersManagerImpl::GetPatch(918, 0LL);
		    if ( !v24 )
		      goto LABEL_35;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(v24, (Object *)this, cb, namespaze, 0LL);
		    goto LABEL_19;
		  }
		LABEL_18:
		  v14 = LODWORD(v26[0]);
		  *(float *)&v14 = (float)namespaze;
		  v26[0] = v14;
		  *(_OWORD *)&cb->_FogBakeLutYawParams.w = v14;
		LABEL_19:
		  z = cameraPos->z;
		  *(_QWORD *)&v26[0] = *(_QWORD *)&cameraPos->x;
		  *((float *)v26 + 2) = z;
		  HG::Rendering::Runtime::HGWindSimpleManager::_SortWindMotorsForSingleCamera(
		    (HGWindSimpleManager *)this,
		    (Vector3 *)v26,
		    0LL);
		  for ( i = 0; ; ++i )
		  {
		    v17 = this[1].klass;
		    if ( !v17 )
		      goto LABEL_35;
		    v18 = 4;
		    if ( SLODWORD(v17->_0.namespaze) < 4 )
		      v18 = (int)v17->_0.namespaze;
		    if ( i >= v18 )
		      break;
		    HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMotor((HGWindSimpleManager *)this, cb, i, 0LL);
		  }
		  namespaze_low = SLODWORD(v17->_0.namespaze);
		  if ( (int)namespaze_low < 4 )
		  {
		    v20 = &cb->_ExponentialFogParams3.w + 4 * namespaze_low;
		    while ( 1 )
		    {
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = v8->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        break;
		      if ( wrapperArray->max_length.size <= 930 )
		        goto LABEL_30;
		      if ( !v8->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v8);
		        v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		      if ( !v8 )
		        break;
		      if ( LODWORD(v8->_0.namespaze) <= 0x3A2 )
		        goto LABEL_64;
		      if ( v8[19].vtable.Finalize.methodPtr )
		      {
		        v25 = IFix::WrappersManagerImpl::GetPatch(930, 0LL);
		        if ( !v25 )
		          break;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(v25, (Object *)this, cb, namespaze_low, 0LL);
		      }
		      else
		      {
		LABEL_30:
		        *((_QWORD *)v20 - 8) = 0LL;
		        *(_QWORD *)v20 = 0LL;
		        *((_QWORD *)v20 + 8) = 0LL;
		        *((_QWORD *)v20 + 16) = 0LL;
		        *((_QWORD *)v20 - 7) = 0LL;
		        *((_QWORD *)v20 + 1) = 0LL;
		        *((_QWORD *)v20 + 9) = 0LL;
		        *((_QWORD *)v20 + 17) = 0LL;
		        *((_QWORD *)v20 + 28) = 0LL;
		        *((_QWORD *)v20 + 36) = 0LL;
		        *((_QWORD *)v20 + 44) = 0LL;
		        *((_QWORD *)v20 + 29) = 0LL;
		        *((_QWORD *)v20 + 37) = 0LL;
		        *((_QWORD *)v20 + 45) = 0LL;
		      }
		      LODWORD(namespaze_low) = namespaze_low + 1;
		      v20 += 4;
		      if ( (int)namespaze_low >= 4 )
		        goto LABEL_32;
		    }
		LABEL_35:
		    sub_1800D8260(v8, wrapperArray);
		  }
		LABEL_32:
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindFoot(
		    (HGWindSimpleManager *)this,
		    cb,
		    phase,
		    0LL);
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupWindParamCache((HGWindSimpleManager *)this, cb, cameraGuid, 0LL);
		}
		
		public HGWindParamDataCache GetWindParamDataCache() => default; // 0x00000001832DE5E0-0x00000001832DE6E0
		// HGWindParamDataCache GetWindParamDataCache()
		HGWindParamDataCache *HG::Rendering::Runtime::HGWindManager::GetWindParamDataCache(
		        HGWindParamDataCache *__return_ptr retstr,
		        HGWindManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  HGWindSimpleManager *m_simpleManager; // rax
		  HGWindParamDataCache *v8; // rdx
		  HGWindParamDataCache *p_m_windParamDataCache; // rax
		  __int64 v10; // rcx
		  Vector4 WindGlobalParams0; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int64 v19; // rcx
		  __int128 v20; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWindParamDataCache *v23; // r8
		  HGWindParamDataCache *v24; // rdx
		  __int64 v25; // rcx
		  Vector4 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int64 v34; // rax
		  __int128 v35; // xmm1
		  HGWindParamDataCache v36[5]; // [rsp+20h] [rbp-138h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 1704 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_10;
		  if ( LODWORD(v5->_0.namespaze) <= 0x6A8 )
		    sub_1800D2AB0(v5, this);
		  if ( !v5[36]._0.fields )
		  {
		LABEL_5:
		    m_simpleManager = this->fields.m_simpleManager;
		    if ( m_simpleManager )
		    {
		      v8 = retstr;
		      p_m_windParamDataCache = &m_simpleManager->fields.m_windParamDataCache;
		      v10 = 2LL;
		      do
		      {
		        v8 = (HGWindParamDataCache *)((char *)v8 + 128);
		        WindGlobalParams0 = p_m_windParamDataCache->_WindGlobalParams0;
		        v12 = *(_OWORD *)&p_m_windParamDataCache->_WindMotorParams0.FixedElementField;
		        p_m_windParamDataCache = (HGWindParamDataCache *)((char *)p_m_windParamDataCache + 128);
		        *(Vector4 *)&v8[-3]._WindLeafFadeRange = WindGlobalParams0;
		        v13 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMotorParams2.FixedElementField;
		        *(_OWORD *)&v8[-2]._WindGlobalParams0.z = v12;
		        v14 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMotorCount.z;
		        *(_OWORD *)&v8[-2]._WindMotorParams2.FixedElementField = v13;
		        v15 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMainQuaility;
		        *(_OWORD *)&v8[-2]._WindMotorCount.z = v14;
		        v16 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindGlobalParams0.w;
		        *(_OWORD *)&v8[-2]._WindMainQuaility = v15;
		        v17 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindMotorParams3.FixedElementField;
		        *(_OWORD *)&v8[-1]._WindGlobalParams0.w = v16;
		        v18 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindMotorCount.w;
		        *(_OWORD *)&v8[-1]._WindMotorParams3.FixedElementField = v17;
		        *(_OWORD *)&v8[-1]._WindMotorCount.w = v18;
		        --v10;
		      }
		      while ( v10 );
		      v19 = *(_QWORD *)&p_m_windParamDataCache->_WindMotorCount.x;
		      v20 = *(_OWORD *)&p_m_windParamDataCache->_WindMotorParams0.FixedElementField;
		      v8->_WindGlobalParams0 = p_m_windParamDataCache->_WindGlobalParams0;
		      *(_OWORD *)&v8->_WindMotorParams0.FixedElementField = v20;
		      *(_QWORD *)&v8->_WindMotorCount.x = v19;
		      v8->_WindMotorCount.z = p_m_windParamDataCache->_WindMotorCount.z;
		      return retstr;
		    }
		LABEL_10:
		    sub_1800D8260(v5, this);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1704, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(v36, Patch, (Object *)this, 0LL);
		  v24 = retstr;
		  v25 = 2LL;
		  do
		  {
		    v24 = (HGWindParamDataCache *)((char *)v24 + 128);
		    v26 = v23->_WindGlobalParams0;
		    v27 = *(_OWORD *)&v23->_WindMotorParams0.FixedElementField;
		    v23 = (HGWindParamDataCache *)((char *)v23 + 128);
		    *(Vector4 *)&v24[-3]._WindLeafFadeRange = v26;
		    v28 = *(_OWORD *)&v23[-2]._WindMotorParams2.FixedElementField;
		    *(_OWORD *)&v24[-2]._WindGlobalParams0.z = v27;
		    v29 = *(_OWORD *)&v23[-2]._WindMotorCount.z;
		    *(_OWORD *)&v24[-2]._WindMotorParams2.FixedElementField = v28;
		    v30 = *(_OWORD *)&v23[-2]._WindMainQuaility;
		    *(_OWORD *)&v24[-2]._WindMotorCount.z = v29;
		    v31 = *(_OWORD *)&v23[-1]._WindGlobalParams0.w;
		    *(_OWORD *)&v24[-2]._WindMainQuaility = v30;
		    v32 = *(_OWORD *)&v23[-1]._WindMotorParams3.FixedElementField;
		    *(_OWORD *)&v24[-1]._WindGlobalParams0.w = v31;
		    v33 = *(_OWORD *)&v23[-1]._WindMotorCount.w;
		    *(_OWORD *)&v24[-1]._WindMotorParams3.FixedElementField = v32;
		    *(_OWORD *)&v24[-1]._WindMotorCount.w = v33;
		    --v25;
		  }
		  while ( v25 );
		  v34 = *(_QWORD *)&v23->_WindMotorCount.x;
		  v35 = *(_OWORD *)&v23->_WindMotorParams0.FixedElementField;
		  v24->_WindGlobalParams0 = v23->_WindGlobalParams0;
		  *(_OWORD *)&v24->_WindMotorParams0.FixedElementField = v35;
		  *(_QWORD *)&v24->_WindMotorCount.x = v34;
		  v24->_WindMotorCount.z = v23->_WindMotorCount.z;
		  return retstr;
		}
		
		public void Dispose() {} // 0x0000000189CF6F3C-0x0000000189CF6F94
		// Void Dispose()
		void HG::Rendering::Runtime::HGWindManager::Dispose(HGWindManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGWindSimpleManager *m_simpleManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1705, 0LL) )
		  {
		    m_simpleManager = this->fields.m_simpleManager;
		    if ( m_simpleManager )
		    {
		      HG::Rendering::Runtime::HGWindSimpleManager::Dispose(m_simpleManager, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_simpleManager, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1705, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
