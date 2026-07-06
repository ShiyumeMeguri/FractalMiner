using System;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGWindManager
	{
		public HGWindManager()
		{
		}

		public void SetWindFootMotor(int index, Vector3 position, float range)
		{
			// // Void SetWindFootMotor(Int32, Vector3, Single)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGWindManager::SetWindFootMotor(
			//         HGWindManager *this,
			//         int32_t index,
			//         Vector3 *position,
			//         float range,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v10; // rax
			//   __int64 v11; // rcx
			//   float z; // eax
			//   int32_t v13; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // xmm0_8
			//   Vector3 v16; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   v7 = index;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&index);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v8.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_19;
			//   if ( wrapperArray.max_length.size > 1427 )
			//   {
			//     if ( !v8._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v8, wrapperArray);
			//       v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v8.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_19;
			//     if ( wrapperArray.max_length.size <= 0x593u )
			//       goto LABEL_20;
			//     if ( wrapperArray[39].vector[23] )
			//     {
			//       v13 = 1427;
			//       goto LABEL_33;
			//     }
			//   }
			//   this = (HGWindManager *)this.fields.m_simpleManager;
			//   if ( !this )
			//     goto LABEL_19;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v8._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v8, wrapperArray);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v8.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_19;
			//   if ( wrapperArray.max_length.size > 1428 )
			//   {
			//     if ( !v8._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v8, wrapperArray);
			//       v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v8.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_19;
			//     if ( wrapperArray.max_length.size > 0x594u )
			//     {
			//       if ( !wrapperArray[39].vector[24] )
			//         goto LABEL_14;
			//       v13 = 1428;
			// LABEL_33:
			//       Patch = IFix::WrappersManagerImpl::GetPatch(v13, 0LL);
			//       if ( Patch )
			//       {
			//         v15 = *(_QWORD *)&position.x;
			//         v16.z = position.z;
			//         *(_QWORD *)&v16.x = v15;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_539(Patch, (Object *)this, v7, &v16, range, 0LL);
			//         return;
			//       }
			//       goto LABEL_19;
			//     }
			// LABEL_20:
			//     sub_180070270(v8, wrapperArray);
			//   }
			// LABEL_14:
			//   if ( (unsigned int)v7 > 3 )
			//     return;
			//   v10 = *(_QWORD *)&this.fields.m_windQuality;
			//   if ( !v10 )
			// LABEL_19:
			//     sub_180B536AC(v8, wrapperArray);
			//   if ( (unsigned int)v7 >= *(_DWORD *)(v10 + 24) )
			//     goto LABEL_20;
			//   v11 = v10 + 16 * (v7 + 2);
			//   z = position.z;
			//   *(_QWORD *)(v11 + 4) = *(_QWORD *)&position.x;
			//   *(float *)(v11 + 12) = z;
			//   *(float *)v11 = range;
			// }
			// 
		}

		public void RemoveWindFootMotor(int index)
		{
			// // Void RemoveWindFootMotor(Int32)
			// void HG::Rendering::Runtime::HGWindManager::RemoveWindFootMotor(HGWindManager *this, int32_t index, MethodInfo *method)
			// {
			//   Animator *v5; // rdx
			//   int32_t v6; // r8d
			//   MethodInfo *v7; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // xmm0_8
			//   float z; // eax
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v15; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3 v16[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1429, 0LL) )
			//   {
			//     Vector = UnityEngine::Animator::GetVector(v16, v5, v6, v7);
			//     if ( this.fields.m_simpleManager )
			//     {
			//       v11 = *(_QWORD *)&Vector.x;
			//       z = Vector.z;
			//       m_simpleManager = this.fields.m_simpleManager;
			//       *(_QWORD *)&v15.x = v11;
			//       v15.z = z;
			//       HG::Rendering::Runtime::HGWindSimpleManager::SetWindFootMotor(m_simpleManager, index, &v15, 0.0, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1429, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, index, 0LL);
			// }
			// 
		}

		public void RegisterWindMotor(HGWindMotor wind)
		{
			// // Void RegisterWindMotor(HGWindMotor)
			// void HG::Rendering::Runtime::HGWindManager::RegisterWindMotor(
			//         HGWindManager *this,
			//         HGWindMotor *wind,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1430, 0LL) )
			//   {
			//     m_simpleManager = this.fields.m_simpleManager;
			//     if ( m_simpleManager )
			//     {
			//       HG::Rendering::Runtime::HGWindSimpleManager::RegisterWindMotor(m_simpleManager, wind, 0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(m_simpleManager, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1430, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)wind,
			//     0LL);
			// }
			// 
		}

		public void UnRegisterWindMotor(HGWindMotor wind)
		{
			// // Void UnRegisterWindMotor(HGWindMotor)
			// void HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(
			//         HGWindManager *this,
			//         HGWindMotor *wind,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1432, 0LL) )
			//   {
			//     m_simpleManager = this.fields.m_simpleManager;
			//     if ( m_simpleManager )
			//     {
			//       HG::Rendering::Runtime::HGWindSimpleManager::UnRegisterWindMotor(m_simpleManager, wind, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_simpleManager, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1432, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)wind,
			//     0LL);
			// }
			// 
		}

		public void GameplayUpdate(float deltaTime)
		{
			// // Void GameplayUpdate(Single)
			// void HG::Rendering::Runtime::HGWindManager::GameplayUpdate(HGWindManager *this, float deltaTime, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState___Class *klass; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = m_simpleManager[1].fields.m_windMotorState.klass;
			//   if ( !klass )
			//     goto LABEL_9;
			//   if ( SLODWORD(klass._0.namespaze) <= 1434 )
			//     goto LABEL_7;
			//   if ( !LODWORD(m_simpleManager[1].fields.m_windParamDataCache._WindMotorParams0.FixedElementField) )
			//   {
			//     il2cpp_runtime_class_init_0(m_simpleManager, klass);
			//     m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_simpleManager = (HGWindSimpleManager *)m_simpleManager[1].fields.m_windMotorState.klass;
			//   if ( !m_simpleManager )
			//     goto LABEL_9;
			//   if ( LODWORD(m_simpleManager.fields.m_windFootMotors) <= 0x59A )
			//     sub_180070270(m_simpleManager, klass);
			//   if ( !*(_QWORD *)&m_simpleManager[84].fields.m_windParamDataCache._WindGlobalParams0.z )
			//   {
			// LABEL_7:
			//     m_simpleManager = this.fields.m_simpleManager;
			//     if ( m_simpleManager )
			//     {
			//       HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(m_simpleManager, deltaTime, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_simpleManager, klass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1434, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, deltaTime, 0LL);
			// }
			// 
		}

		public void SetupShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, int cameraGuid, Vector3 cameraPos, HGEnvironmentPhase phase)
		{
			// // Void SetupShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, Int32, Vector3, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::HGWindManager::SetupShaderVariablesGlobalWind(
			//         HGWindManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t cameraGuid,
			//         Vector3 *cameraPos,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState___Class *klass; // rdx
			//   __int64 v12; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // xmm0_8
			//   Vector3 v15[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = m_simpleManager[1].fields.m_windMotorState.klass;
			//   if ( !klass )
			//     goto LABEL_11;
			//   if ( SLODWORD(klass._0.namespaze) > 840 )
			//   {
			//     if ( !LODWORD(m_simpleManager[1].fields.m_windParamDataCache._WindMotorParams0.FixedElementField) )
			//     {
			//       il2cpp_runtime_class_init_0(m_simpleManager, klass);
			//       m_simpleManager = (HGWindSimpleManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_simpleManager = (HGWindSimpleManager *)m_simpleManager[1].fields.m_windMotorState.klass;
			//     if ( !m_simpleManager )
			//       goto LABEL_11;
			//     if ( LODWORD(m_simpleManager.fields.m_windFootMotors) <= 0x348 )
			//       sub_180070270(m_simpleManager, klass);
			//     if ( *(_QWORD *)&m_simpleManager[49].fields.m_windParamDataCache._WindMotorParams0.FixedElementField )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(840, 0LL);
			//       if ( Patch )
			//       {
			//         v14 = *(_QWORD *)&cameraPos.x;
			//         v15[0].z = cameraPos.z;
			//         *(_QWORD *)&v15[0].x = v14;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_334(
			//           Patch,
			//           (Object *)this,
			//           cb,
			//           cameraGuid,
			//           v15,
			//           (Object *)phase,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_11;
			//     }
			//   }
			//   if ( this.fields.m_windQuality != 1 )
			//     return;
			//   m_simpleManager = this.fields.m_simpleManager;
			//   if ( !m_simpleManager )
			// LABEL_11:
			//     sub_180B536AC(m_simpleManager, klass);
			//   v12 = *(_QWORD *)&cameraPos.x;
			//   v15[0].z = cameraPos.z;
			//   *(_QWORD *)&v15[0].x = v12;
			//   HG::Rendering::Runtime::HGWindSimpleManager::SetupShaderVariablesGlobalWind(
			//     m_simpleManager,
			//     cb,
			//     cameraGuid,
			//     v15,
			//     phase,
			//     0LL);
			// }
			// 
		}

		public HGWindParamDataCache GetWindParamDataCache()
		{
			// // HGWindParamDataCache GetWindParamDataCache()
			// HGWindParamDataCache *HG::Rendering::Runtime::HGWindManager::GetWindParamDataCache(
			//         HGWindParamDataCache *__return_ptr retstr,
			//         HGWindManager *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGWindSimpleManager *m_simpleManager; // rax
			//   HGWindParamDataCache *v8; // rdx
			//   HGWindParamDataCache *p_m_windParamDataCache; // rax
			//   __int64 v10; // rcx
			//   Vector4 WindGlobalParams0; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int64 v19; // rcx
			//   __int128 v20; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGWindParamDataCache *v23; // r8
			//   HGWindParamDataCache *v24; // rdx
			//   __int64 v25; // rcx
			//   Vector4 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int64 v34; // rax
			//   __int128 v35; // xmm1
			//   HGWindParamDataCache v36[5]; // [rsp+20h] [rbp-138h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size <= 1437 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_12;
			//   if ( LODWORD(v5._0.namespaze) <= 0x59D )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !*(_QWORD *)&v5[30]._1.instance_size )
			//   {
			// LABEL_7:
			//     m_simpleManager = this.fields.m_simpleManager;
			//     if ( m_simpleManager )
			//     {
			//       v8 = retstr;
			//       p_m_windParamDataCache = &m_simpleManager.fields.m_windParamDataCache;
			//       v10 = 2LL;
			//       do
			//       {
			//         v8 = (HGWindParamDataCache *)((char *)v8 + 128);
			//         WindGlobalParams0 = p_m_windParamDataCache._WindGlobalParams0;
			//         v12 = *(_OWORD *)&p_m_windParamDataCache._WindMotorParams0.FixedElementField;
			//         p_m_windParamDataCache = (HGWindParamDataCache *)((char *)p_m_windParamDataCache + 128);
			//         *(Vector4 *)&v8[-3]._WindLeafFadeRange = WindGlobalParams0;
			//         v13 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMotorParams2.FixedElementField;
			//         *(_OWORD *)&v8[-2]._WindGlobalParams0.z = v12;
			//         v14 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMotorCount.z;
			//         *(_OWORD *)&v8[-2]._WindMotorParams2.FixedElementField = v13;
			//         v15 = *(_OWORD *)&p_m_windParamDataCache[-2]._WindMainQuaility;
			//         *(_OWORD *)&v8[-2]._WindMotorCount.z = v14;
			//         v16 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindGlobalParams0.w;
			//         *(_OWORD *)&v8[-2]._WindMainQuaility = v15;
			//         v17 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindMotorParams3.FixedElementField;
			//         *(_OWORD *)&v8[-1]._WindGlobalParams0.w = v16;
			//         v18 = *(_OWORD *)&p_m_windParamDataCache[-1]._WindMotorCount.w;
			//         *(_OWORD *)&v8[-1]._WindMotorParams3.FixedElementField = v17;
			//         *(_OWORD *)&v8[-1]._WindMotorCount.w = v18;
			//         --v10;
			//       }
			//       while ( v10 );
			//       v19 = *(_QWORD *)&p_m_windParamDataCache._WindMotorCount.x;
			//       v20 = *(_OWORD *)&p_m_windParamDataCache._WindMotorParams0.FixedElementField;
			//       v8._WindGlobalParams0 = p_m_windParamDataCache._WindGlobalParams0;
			//       *(_OWORD *)&v8._WindMotorParams0.FixedElementField = v20;
			//       *(_QWORD *)&v8._WindMotorCount.x = v19;
			//       v8._WindMotorCount.z = p_m_windParamDataCache._WindMotorCount.z;
			//       return retstr;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1437, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(v36, Patch, (Object *)this, 0LL);
			//   v24 = retstr;
			//   v25 = 2LL;
			//   do
			//   {
			//     v24 = (HGWindParamDataCache *)((char *)v24 + 128);
			//     v26 = v23._WindGlobalParams0;
			//     v27 = *(_OWORD *)&v23._WindMotorParams0.FixedElementField;
			//     v23 = (HGWindParamDataCache *)((char *)v23 + 128);
			//     *(Vector4 *)&v24[-3]._WindLeafFadeRange = v26;
			//     v28 = *(_OWORD *)&v23[-2]._WindMotorParams2.FixedElementField;
			//     *(_OWORD *)&v24[-2]._WindGlobalParams0.z = v27;
			//     v29 = *(_OWORD *)&v23[-2]._WindMotorCount.z;
			//     *(_OWORD *)&v24[-2]._WindMotorParams2.FixedElementField = v28;
			//     v30 = *(_OWORD *)&v23[-2]._WindMainQuaility;
			//     *(_OWORD *)&v24[-2]._WindMotorCount.z = v29;
			//     v31 = *(_OWORD *)&v23[-1]._WindGlobalParams0.w;
			//     *(_OWORD *)&v24[-2]._WindMainQuaility = v30;
			//     v32 = *(_OWORD *)&v23[-1]._WindMotorParams3.FixedElementField;
			//     *(_OWORD *)&v24[-1]._WindGlobalParams0.w = v31;
			//     v33 = *(_OWORD *)&v23[-1]._WindMotorCount.w;
			//     *(_OWORD *)&v24[-1]._WindMotorParams3.FixedElementField = v32;
			//     *(_OWORD *)&v24[-1]._WindMotorCount.w = v33;
			//     --v25;
			//   }
			//   while ( v25 );
			//   v34 = *(_QWORD *)&v23._WindMotorCount.x;
			//   v35 = *(_OWORD *)&v23._WindMotorParams0.FixedElementField;
			//   v24._WindGlobalParams0 = v23._WindGlobalParams0;
			//   *(_OWORD *)&v24._WindMotorParams0.FixedElementField = v35;
			//   *(_QWORD *)&v24._WindMotorCount.x = v34;
			//   v24._WindMotorCount.z = v23._WindMotorCount.z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGWindManager::Dispose(HGWindManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGWindSimpleManager *m_simpleManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1438, 0LL) )
			//   {
			//     m_simpleManager = this.fields.m_simpleManager;
			//     if ( m_simpleManager )
			//     {
			//       HG::Rendering::Runtime::HGWindSimpleManager::Dispose(m_simpleManager, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_simpleManager, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1438, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private HGWindSimpleManager m_simpleManager;

		private HGWindManager.WindQuality m_windQuality;

		public enum WindQuality
		{
			Min,
			Simple,
			High
		}
	}
}
