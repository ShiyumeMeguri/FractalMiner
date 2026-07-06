using System;

namespace HG.Rendering.Runtime
{
	public class HGRPTimeManager
	{
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float time
		{
			get
			{
				// // Single get_time()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_time(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRPTimeManager__Class *v2; // rax
				//   HGRPTimeManager *instance; // rcx
				// 
				//   if ( !byte_18D8ED964 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     byte_18D8ED964 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   }
				//   instance = v2.static_fields.instance;
				//   if ( !instance )
				//     sub_180B536AC(0LL, v1);
				//   return instance.fields.m_time;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float lastTime
		{
			get
			{
				// // Single get_lastTime()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_lastTime(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRPTimeManager__Class *v2; // rax
				//   HGRPTimeManager *instance; // rcx
				// 
				//   if ( !byte_18D8ED965 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     byte_18D8ED965 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   }
				//   instance = v2.static_fields.instance;
				//   if ( !instance )
				//     sub_180B536AC(0LL, v1);
				//   return instance.fields.m_lastTime;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float gameplayTime
		{
			get
			{
				// // Single get_gameplayTime()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRPTimeManager__Class *v2; // rax
				//   HGRPTimeManager *instance; // rcx
				// 
				//   if ( !byte_18D8ED966 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     byte_18D8ED966 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   }
				//   instance = v2.static_fields.instance;
				//   if ( !instance )
				//     sub_180B536AC(0LL, v1);
				//   return instance.fields.m_gameplayTime;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float lastGameplayTime
		{
			get
			{
				// // Single get_lastGameplayTime()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRPTimeManager__Class *v2; // rax
				//   HGRPTimeManager *instance; // rcx
				// 
				//   if ( !byte_18D8ED967 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     byte_18D8ED967 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   }
				//   instance = v2.static_fields.instance;
				//   if ( !instance )
				//     sub_180B536AC(0LL, v1);
				//   return instance.fields.m_lastGameplayTime;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float deltaTime
		{
			get
			{
				// // Single get_deltaTime()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_deltaTime(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRPTimeManager__Class *v2; // rax
				//   HGRPTimeManager *instance; // rcx
				// 
				//   if ( !byte_18D8ED968 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     byte_18D8ED968 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
				//   }
				//   instance = v2.static_fields.instance;
				//   if ( !instance )
				//     sub_180B536AC(0LL, v1);
				//   return instance.fields.m_time - instance.fields.m_lastTime;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x000025F0 File Offset: 0x000007F0
		private float m_deltaTime
		{
			get
			{
				// // Single get_m_deltaTime()
				// float HG::Rendering::Runtime::HGRPTimeManager::get_m_deltaTime(HGRPTimeManager *this, MethodInfo *method)
				// {
				//   return this.fields.m_time - this.fields.m_lastTime;
				// }
				// 
				return 0f;
			}
		}

		public HGRPTimeManager()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static void SetGameplayTime(double gameplayTime)
		{
			// // Void SetGameplayTime(Double)
			// void HG::Rendering::Runtime::HGRPTimeManager::SetGameplayTime(double gameplayTime, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGRPTimeManager__Class *v4; // rax
			//   HGRPTimeManager *instance; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED969 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D8ED969 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1978, 0LL) )
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//     }
			//     instance = v4.static_fields.instance;
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGRPTimeManager::_SetGameplayTime(instance, gameplayTime, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(instance, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1978, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_12((ILFixDynamicMethodWrapper_28 *)Patch, gameplayTime, 0LL);
			// }
			// 
		}

		public static void SetLastGameplayTime(double lastGameplayTime)
		{
			// // Void SetLastGameplayTime(Double)
			// void HG::Rendering::Runtime::HGRPTimeManager::SetLastGameplayTime(double lastGameplayTime, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGRPTimeManager__Class *v4; // rax
			//   HGRPTimeManager *instance; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED96A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D8ED96A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1980, 0LL) )
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//     }
			//     instance = v4.static_fields.instance;
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGRPTimeManager::_SetLastGameplayTime(instance, lastGameplayTime, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(instance, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1980, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_12((ILFixDynamicMethodWrapper_28 *)Patch, lastGameplayTime, 0LL);
			// }
			// 
		}

		public static void Update()
		{
			// // Void Update()
			// void HG::Rendering::Runtime::HGRPTimeManager::Update(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct HGRPTimeManager__Class *v4; // rax
			//   HGRPTimeManager *instance; // rbx
			//   float time; // xmm6_4
			//   float deltaTime; // xmm0_4
			//   void (*v8)(void); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v10; // rax
			//   __int64 v11; // rax
			// 
			//   if ( !byte_18D8ED96B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D8ED96B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v1);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v2.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size > 1939 )
			//   {
			//     if ( !v2._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v2, wrapperArray);
			//       v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v2.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 0x793u )
			//       goto LABEL_39;
			//     if ( wrapperArray[53].vector[31] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1939, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//         return;
			//       }
			//       goto LABEL_22;
			//     }
			//   }
			//   v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, wrapperArray);
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   instance = v4.static_fields.instance;
			//   if ( !instance )
			//     goto LABEL_22;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v2._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v2, wrapperArray);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v2.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size > 1940 )
			//   {
			//     if ( !v2._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v2, wrapperArray);
			//       v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2.static_fields.wrapperArray;
			//     if ( !v2 )
			//       goto LABEL_22;
			//     if ( LODWORD(v2._0.namespaze) > 0x794 )
			//     {
			//       if ( !v2[41]._0.events )
			//         goto LABEL_18;
			//       v10 = IFix::WrappersManagerImpl::GetPatch(1940, 0LL);
			//       if ( v10 )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)v10, (Object *)instance, 0LL);
			//         return;
			//       }
			// LABEL_22:
			//       sub_180B536AC(v2, wrapperArray);
			//     }
			// LABEL_39:
			//     sub_180070270(v2, wrapperArray);
			//   }
			// LABEL_18:
			//   time = UnityEngine::Time::get_time(0LL);
			//   deltaTime = UnityEngine::Time::get_deltaTime(0LL);
			//   v8 = (void (*)(void))qword_18D8F5AB8;
			//   instance.fields.m_time = time;
			//   instance.fields.m_lastTime = time - deltaTime;
			//   if ( !v8 )
			//   {
			//     v8 = (void (*)(void))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
			//     if ( !v8 )
			//     {
			//       v11 = sub_1802DBBE8("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F5AB8 = (__int64)v8;
			//   }
			//   v8();
			//   if ( !UnityEngine::Application::get_isPlaying(0LL) )
			//     HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(instance, 0LL);
			// }
			// 
		}

		private void _SetGameplayTime(double gameplayTime)
		{
			// // Void _SetGameplayTime(Double)
			// void HG::Rendering::Runtime::HGRPTimeManager::_SetGameplayTime(
			//         HGRPTimeManager *this,
			//         double gameplayTime,
			//         MethodInfo *method)
			// {
			//   double v3; // xmm2_8
			//   Unity::Mathematics::math *v5; // rcx
			//   float v6; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1979, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1979, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_808(
			//       (ILFixDynamicMethodWrapper_3 *)Patch,
			//       (Object *)this,
			//       gameplayTime,
			//       0LL);
			//   }
			//   else
			//   {
			//     Unity::Mathematics::math::fmod(v5, 1000.0, v3);
			//     v6 = gameplayTime;
			//     this.fields.m_gameplayTime = v6;
			//   }
			// }
			// 
		}

		private void _SetLastGameplayTime(double lastGameplayTime)
		{
			// // Void _SetLastGameplayTime(Double)
			// void HG::Rendering::Runtime::HGRPTimeManager::_SetLastGameplayTime(
			//         HGRPTimeManager *this,
			//         double lastGameplayTime,
			//         MethodInfo *method)
			// {
			//   double v3; // xmm2_8
			//   Unity::Mathematics::math *v5; // rcx
			//   float v6; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1981, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1981, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_808(
			//       (ILFixDynamicMethodWrapper_3 *)Patch,
			//       (Object *)this,
			//       lastGameplayTime,
			//       0LL);
			//   }
			//   else
			//   {
			//     Unity::Mathematics::math::fmod(v5, 1000.0, v3);
			//     v6 = lastGameplayTime;
			//     this.fields.m_lastGameplayTime = v6;
			//   }
			// }
			// 
		}

		private void UpdateOverrideTime()
		{
			// // Void UpdateOverrideTime()
			// void HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(HGRPTimeManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1941, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1941, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void _Update()
		{
			// // Void _Update()
			// void HG::Rendering::Runtime::HGRPTimeManager::_Update(HGRPTimeManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float time; // xmm6_4
			//   float deltaTime; // xmm0_4
			//   void (*v7)(void); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size > 1940 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x794 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[41]._0.events )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1940, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   time = UnityEngine::Time::get_time(0LL);
			//   deltaTime = UnityEngine::Time::get_deltaTime(0LL);
			//   v7 = (void (*)(void))qword_18D8F5AB8;
			//   this.fields.m_time = time;
			//   this.fields.m_lastTime = time - deltaTime;
			//   if ( !v7 )
			//   {
			//     v7 = (void (*)(void))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
			//     if ( !v7 )
			//     {
			//       v9 = sub_1802DBBE8("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
			//       sub_18000F750(v9, 0LL);
			//     }
			//     qword_18D8F5AB8 = (__int64)v7;
			//   }
			//   v7();
			//   if ( !UnityEngine::Application::get_isPlaying(0LL) )
			//     HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(this, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGRPTimeManager> s_Instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly HGRPTimeManager instance;

		private float m_time;

		private float m_lastTime;

		private float m_gameplayTime;

		private float m_lastGameplayTime;
	}
}
