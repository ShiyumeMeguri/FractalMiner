using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGWaterManager
	{
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGWaterGlobalConfig globalConfig
		{
			get
			{
				// // HGWaterGlobalConfig get_globalConfig()
				// HGWaterGlobalConfig *HG::Rendering::Runtime::HGWaterManager::get_globalConfig(HGWaterManager *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rcx
				//   __int64 m_validGlobalConfigIndex; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBD5 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
				//     byte_18D8EDBD5 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = items.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_17;
				//   if ( wrapperArray.max_length.size <= 921 )
				//     goto LABEL_11;
				//   if ( !items._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(items, wrapperArray);
				//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = items.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_17;
				//   if ( wrapperArray.max_length.size <= 0x399u )
				//     goto LABEL_18;
				//   if ( !wrapperArray[25].vector[21] )
				//   {
				// LABEL_11:
				//     if ( !this.fields.m_globalConfigs
				//       || this.fields.m_validGlobalConfigIndex < 0
				//       || this.fields.m_validGlobalConfigIndex >= this.fields.m_globalConfigs.fields._size )
				//     {
				//       return 0LL;
				//     }
				//     m_globalConfigs = this.fields.m_globalConfigs;
				//     m_validGlobalConfigIndex = this.fields.m_validGlobalConfigIndex;
				//     if ( (unsigned int)m_validGlobalConfigIndex >= m_globalConfigs.fields._size )
				//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
				//     items = (struct ILFixDynamicMethodWrapper_2__Class *)m_globalConfigs.fields._items;
				//     if ( items )
				//     {
				//       if ( (unsigned int)m_validGlobalConfigIndex < LODWORD(items._0.namespaze) )
				//         return (HGWaterGlobalConfig *)*((_QWORD *)&items._0.byval_arg.data.dummy + m_validGlobalConfigIndex);
				// LABEL_18:
				//       sub_180070270(items, wrapperArray);
				//     }
				// LABEL_17:
				//     sub_180B536AC(items, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(921, 0LL);
				//   if ( !Patch )
				//     goto LABEL_17;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_348(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool shouldRender
		{
			get
			{
				// // Boolean get_shouldRender()
				// bool HG::Rendering::Runtime::HGWaterManager::get_shouldRender(HGWaterManager *this, MethodInfo *method)
				// {
				//   unsigned __int64 static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rdi
				//   HGWaterGlobalConfig__Array *items; // rdi
				//   HGWaterGlobalConfig *v7; // rdi
				//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *v8; // rcx
				//   __int64 m_validGlobalConfigIndex; // rax
				//   HGWaterGlobalConfig *v10; // rax
				//   __int64 v12; // rax
				//   ILFixDynamicMethodWrapper_2 *v13; // rax
				//   __int64 v14; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v16; // rax
				//   ILFixDynamicMethodWrapper_2 *v17; // rax
				// 
				//   if ( !byte_18D8EDBD6 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBD6 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_57;
				//   if ( wrapperArray[6] <= 920 )
				//     goto LABEL_9;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v12 = *(_QWORD *)wrapperArray;
				//   if ( !*(_QWORD *)wrapperArray )
				//     goto LABEL_57;
				//   if ( *(_DWORD *)(v12 + 24) <= 0x398u )
				//     goto LABEL_58;
				//   if ( !*(_QWORD *)(v12 + 7392) )
				//   {
				// LABEL_9:
				//     if ( !byte_18D8EDBD5 )
				//     {
				//       sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Count);
				//       sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
				//       byte_18D8EDBD5 = 1;
				//     }
				//     if ( !byte_18D8EDC37 )
				//     {
				//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//       byte_18D8EDC37 = 1;
				//     }
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//     if ( !wrapperArray )
				//       goto LABEL_57;
				//     if ( wrapperArray[6] <= 921 )
				//       goto LABEL_83;
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v14 = *(_QWORD *)static_fields;
				//     if ( !*(_QWORD *)static_fields )
				//       goto LABEL_57;
				//     if ( *(_DWORD *)(v14 + 24) <= 0x399u )
				//       goto LABEL_58;
				//     if ( *(_QWORD *)(v14 + 7400) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(921, 0LL);
				//       if ( !Patch )
				//         goto LABEL_57;
				//       v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_348(Patch, (Object *)this, 0LL);
				//     }
				//     else
				//     {
				// LABEL_83:
				//       if ( this.fields.m_globalConfigs
				//         && this.fields.m_validGlobalConfigIndex >= 0
				//         && (static_fields = (unsigned int)this.fields.m_validGlobalConfigIndex,
				//             (int)static_fields < this.fields.m_globalConfigs.fields._size) )
				//       {
				//         m_globalConfigs = this.fields.m_globalConfigs;
				//         if ( (unsigned int)static_fields >= m_globalConfigs.fields._size )
				//           goto LABEL_80;
				//         items = m_globalConfigs.fields._items;
				//         if ( !items )
				//           goto LABEL_57;
				//         if ( (unsigned int)static_fields >= items.max_length.size )
				//           goto LABEL_58;
				//         v7 = items.vector[(int)static_fields];
				//       }
				//       else
				//       {
				//         v7 = 0LL;
				//       }
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EFB )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFB = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( !v7 )
				//       return 0;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !v7.fields._._._._.m_CachedPtr )
				//       return 0;
				//     if ( !byte_18D8EDBD5 )
				//     {
				//       sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Count);
				//       sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
				//       byte_18D8EDBD5 = 1;
				//     }
				//     if ( !byte_18D8EDC37 )
				//     {
				//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//       byte_18D8EDC37 = 1;
				//     }
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//     if ( !wrapperArray )
				// LABEL_57:
				//       sub_180B536AC(static_fields, wrapperArray);
				//     if ( wrapperArray[6] > 921 )
				//     {
				//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//       wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//       v16 = *(_QWORD *)wrapperArray;
				//       if ( !*(_QWORD *)wrapperArray )
				//         goto LABEL_57;
				//       if ( *(_DWORD *)(v16 + 24) <= 0x399u )
				//         goto LABEL_58;
				//       if ( *(_QWORD *)(v16 + 7400) )
				//       {
				//         v17 = IFix::WrappersManagerImpl::GetPatch(921, 0LL);
				//         if ( !v17 )
				//           goto LABEL_57;
				//         v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_348(v17, (Object *)this, 0LL);
				//         goto LABEL_51;
				//       }
				//     }
				//     if ( !this.fields.m_globalConfigs )
				//       goto LABEL_57;
				//     if ( this.fields.m_validGlobalConfigIndex < 0 )
				//       goto LABEL_57;
				//     static_fields = (unsigned int)this.fields.m_validGlobalConfigIndex;
				//     if ( (int)static_fields >= this.fields.m_globalConfigs.fields._size )
				//       goto LABEL_57;
				//     v8 = this.fields.m_globalConfigs;
				//     m_validGlobalConfigIndex = this.fields.m_validGlobalConfigIndex;
				//     if ( (unsigned int)m_validGlobalConfigIndex < v8.fields._size )
				//     {
				//       static_fields = (unsigned __int64)v8.fields._items;
				//       if ( !static_fields )
				//         goto LABEL_57;
				//       if ( (unsigned int)m_validGlobalConfigIndex < *(_DWORD *)(static_fields + 24) )
				//       {
				//         v10 = *(HGWaterGlobalConfig **)(static_fields + 8 * m_validGlobalConfigIndex + 32);
				// LABEL_51:
				//         if ( v10 )
				//           return HG::Rendering::Runtime::HGWaterGlobalConfig::ShouldRenderWater(v10, 0LL)
				//               && !this.fields.forceHideWater;
				//         goto LABEL_57;
				//       }
				// LABEL_58:
				//       sub_180070270(static_fields, wrapperArray);
				//     }
				// LABEL_80:
				//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
				//   }
				//   v13 = IFix::WrappersManagerImpl::GetPatch(920, 0LL);
				//   if ( !v13 )
				//     goto LABEL_57;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v13, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool EnableOrthographicRender
		{
			get
			{
				// // Boolean get_IsExpanded()
				// bool SRDebugger::Services::Implementation::DockConsoleServiceImpl::get_IsExpanded(
				//         DockConsoleServiceImpl *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isExpanded;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_isManualUpdate(Boolean)
				// void UnityEngine::Timeline::TimeNotificationBehaviour::set_isManualUpdate(
				//         TimeNotificationBehaviour *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_IsManualUpdate = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool shouldStoreDepth
		{
			get
			{
				// // Boolean get_IsVisible()
				// bool SRDebugger::Services::Implementation::DockConsoleServiceImpl::get_IsVisible(
				//         DockConsoleServiceImpl *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isVisible;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void <RegisterDebug>b__10_3(Boolean)
				// void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDebugParams::_RegisterDebug_b__10_3(
				//         RenderGraphDebugParams *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.disablePassCulling = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x000025D2 File Offset: 0x000007D2
		public Mesh screenSpaceMesh
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsRippleInputEmpty
		{
			get
			{
				// // Boolean get_HasErrors()
				// bool Unity::Formats::USD::PrimMap::get_HasErrors(PrimMap *this, MethodInfo *method)
				// {
				//   return this.fields._HasErrors_k__BackingField;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool IsPlayerOnBoat
		{
			get
			{
				// // Boolean get_clientPaused()
				// bool Beyond::Gameplay::Core::BaseSubGame<System::Object>::get_clientPaused(
				//         BaseSubGame_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_clientPaused;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_androidUseLowLatencyVoicePool(Boolean)
				// void CriWare::CriAtomSourceBase::set_androidUseLowLatencyVoicePool(
				//         CriAtomSourceBase *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._androidUseLowLatencyVoicePool = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector2 CenterPosition
		{
			get
			{
				// // Vector2 get_value()
				// Vector2 Beyond::Gameplay::ParamVariable<UnityEngine::Vector2>::get_value(
				//         ParamVariable_1_UnityEngine_Vector2_ *this,
				//         MethodInfo *method)
				// {
				//   return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(this.fields.m_value.x), (__m128)LODWORD(this.fields.m_value.y)).m128_u64[0];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000025F0 File Offset: 0x000007F0
		public float TerrainRippleNormalStrength
		{
			get
			{
				// // Single get_cachedValue()
				// float FlowCanvas::Nodes::RelayValueInput<float>::get_cachedValue(
				//         RelayValueInput_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._cachedValue_k__BackingField;
				// }
				// 
				return 0f;
			}
		}

		public HGWaterManager()
		{
			// // HGWaterManager()
			// void HG::Rendering::Runtime::HGWaterManager::HGWaterManager(HGWaterManager *this, MethodInfo *method)
			// {
			//   List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *v6; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v10; // rax
			//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *v11; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   __int64 v15; // rsi
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   NativeArray_1_UnityEngine_Vector4_ v21; // xmm0
			//   RippleDataManager *v22; // rax
			//   RippleDataManager *v23; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   __m128i si128; // xmm2
			//   __int64 v28; // rbx
			//   __m128i v29; // xmm1
			//   __m128i v30; // xmm0
			//   __m128i v31; // xmm1
			//   __m128i v32; // xmm0
			//   __m128i v33; // xmm1
			//   __m128i v34; // xmm0
			//   __m128i v35; // xmm1
			//   __m128i v36; // xmm0
			//   __m128i v37; // xmm1
			//   __m128i v38; // xmm0
			//   __m128i v39; // xmm0
			//   __m128i v40; // xmm1
			//   NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm6
			//   struct MethodInfo *v42; // rcx
			//   Void *m_Buffer; // rbp
			//   NativeArray_1_UnityEngine_Vector4_ defaultWaterMaterialData; // xmm6
			//   Void *v45; // rbp
			//   MethodInfo *methoda; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v51; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v52; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v53; // [rsp+28h] [rbp-30h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v54; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDBD8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWaterConfig);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::RippleDataManager);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     byte_18D8EDBD8 = 1;
			//   }
			//   this.fields.m_validGlobalConfigIndex = -1;
			//   this.fields.m_shouldStoreDepth = 1;
			//   v3 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
			//   v6 = (List_1_HG_Rendering_Runtime_InputRippleData_ *)v3;
			//   if ( !v3 )
			//     goto LABEL_4;
			//   System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
			//     v3,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
			//   this.fields.m_rawRippleDataList = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_rawRippleDataList, v7, v8, v9, methoda, v50);
			//   this.fields.m_lerpStartTimeTime = -1.0;
			//   v10 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>);
			//   v11 = (List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *)v10;
			//   if ( !v10 )
			//     goto LABEL_4;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v10,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::List);
			//   this.fields.m_globalConfigs = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_globalConfigs, v12, v13, v14, methodb, v51);
			//   v15 = 64LL;
			//   this.fields.m_waterConfigs = (HGWaterConfig__Array *)il2cpp_array_new_specific_0(
			//                                                           TypeInfo::HG::Rendering::Runtime::HGWaterConfig,
			//                                                           64LL,
			//                                                           v16,
			//                                                           v17);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_waterConfigs, v18, v19, v20, methodd, v52);
			//   v54 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     &v54,
			//     20,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//   this.fields.waterRippleData = (NativeArray_1_UnityEngine_Vector4_)v54;
			//   v54 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     &v54,
			//     1298,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//   v21 = (NativeArray_1_UnityEngine_Vector4_)v54;
			//   *(_WORD *)&this.fields.m_isPlayerOnBoat = 0;
			//   this.fields.waterGPUData = v21;
			//   v22 = (RippleDataManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::RippleDataManager);
			//   v23 = v22;
			//   if ( !v22 )
			// LABEL_4:
			//     sub_180B536AC(v5, v4);
			//   HG::Rendering::Runtime::RippleDataManager::RippleDataManager(v22, 8, 0LL);
			//   this.fields.m_RippleDataManager = v23;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_RippleDataManager, v24, v25, v26, methodc, v53);
			//   v54 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     &v54,
			//     20,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   v28 = 288LL;
			//   v29 = _mm_load_si128((const __m128i *)&xmmword_18A3578C0);
			//   this.fields.defaultWaterMaterialData = (NativeArray_1_UnityEngine_Vector4_)v54;
			//   v30 = _mm_load_si128((const __m128i *)&xmmword_18A3578E0);
			//   *(__m128i *)this.fields.defaultWaterMaterialData.m_Buffer = v29;
			//   v31 = _mm_load_si128((const __m128i *)&xmmword_18A357970);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[16] = si128;
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[32] = si128;
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[48] = si128;
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[64] = v30;
			//   v32 = _mm_load_si128((const __m128i *)&xmmword_18A3578F0);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[80] = v31;
			//   v33 = _mm_load_si128((const __m128i *)&xmmword_18A357900);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[96] = v32;
			//   v34 = _mm_load_si128((const __m128i *)&xmmword_18A357910);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[112] = v33;
			//   v35 = _mm_load_si128((const __m128i *)&xmmword_18A357940);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[128] = v34;
			//   v36 = _mm_load_si128((const __m128i *)&xmmword_18A357920);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[144] = v35;
			//   v37 = _mm_load_si128((const __m128i *)&xmmword_18A357960);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[160] = v36;
			//   v38 = _mm_load_si128((const __m128i *)&xmmword_18A357950);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[176] = si128;
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[192] = v38;
			//   v39 = _mm_load_si128((const __m128i *)&xmmword_18A357930);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[208] = v37;
			//   v40 = _mm_load_si128((const __m128i *)&xmmword_18A3578D0);
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[224] = v39;
			//   *(__m128i *)&this.fields.defaultWaterMaterialData.m_Buffer[240] = v40;
			//   do
			//   {
			//     waterGPUData = this.fields.waterGPUData;
			//     v42 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//     {
			//       sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       v42 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     }
			//     m_Buffer = waterGPUData.m_Buffer;
			//     defaultWaterMaterialData = this.fields.defaultWaterMaterialData;
			//     v45 = &m_Buffer[v28];
			//     if ( !v42.rgctx_data )
			//       sub_180041F40(v42);
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v45, defaultWaterMaterialData.m_Buffer, 320LL, 0LL);
			//     v28 += 320LL;
			//     --v15;
			//   }
			//   while ( v15 );
			// }
			// 
		}

		internal void Initialize(HGRenderPipelineRuntimeResources resource)
		{
		}

		public void EarlyUpdate()
		{
			// // Void EarlyUpdate()
			// void HG::Rendering::Runtime::HGWaterManager::EarlyUpdate(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // rax
			//   int32_t v6; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
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
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size > 1934 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_17;
			//     if ( wrapperArray.max_length.size <= 0x78Eu )
			//       goto LABEL_32;
			//     if ( wrapperArray[53].vector[26] )
			//     {
			//       v6 = 1934;
			//       goto LABEL_24;
			//     }
			//   }
			//   if ( !byte_18D8EDBE3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Clear);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDBE3 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size <= 1935 )
			//     goto LABEL_15;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_17;
			//   if ( LODWORD(v3._0.namespaze) <= 0x78F )
			// LABEL_32:
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[41]._0.generic_class )
			//   {
			// LABEL_15:
			//     m_rawRippleDataList = this.fields.m_rawRippleDataList;
			//     if ( m_rawRippleDataList )
			//     {
			//       ++m_rawRippleDataList.fields._version;
			//       m_rawRippleDataList.fields._size = 0;
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   v6 = 1935;
			// LABEL_24:
			//   Patch = IFix::WrappersManagerImpl::GetPatch(v6, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// void HG::Rendering::Runtime::HGWaterManager::PipelineUpdate(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v5; // rdx
			//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rcx
			//   __int64 m_validGlobalConfigIndex; // rax
			//   HGWaterGlobalConfig *v8; // rdi
			//   HGWaterGlobalConfig *globalConfig; // rax
			//   String *scenePath; // rdi
			//   unsigned __int8 (__fastcall *v11)(String *); // rax
			//   HGWaterGlobalConfig *v12; // rax
			//   String *v13; // r12
			//   HGWaterGlobalConfig *v14; // rax
			//   int32_t sectorNum; // r15d
			//   HGWaterGlobalConfig *v16; // rax
			//   int32_t sectorSize; // r14d
			//   HGWaterGlobalConfig *v18; // rax
			//   int32_t sectorCoordsMin; // ebp
			//   HGWaterGlobalConfig *v20; // rax
			//   int32_t sectorCoordsMax; // esi
			//   HGWaterGlobalConfig *v22; // rax
			//   Int64__Array *sectorDataGUIDs; // rdi
			//   HGWaterGlobalConfig *v24; // rax
			//   Boolean__Array *sectorDataExists; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v27; // rax
			//   __int64 v28; // rax
			// 
			//   if ( !byte_18D8EDBD9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBD9 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_41;
			//   if ( wrapperArray.max_length.size > 1948 )
			//   {
			//     if ( !items._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(items, wrapperArray);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_41;
			//     if ( wrapperArray.max_length.size <= 0x79Cu )
			//       goto LABEL_52;
			//     if ( wrapperArray[54].vector[4] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1948, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_41;
			//     }
			//   }
			//   HG::Rendering::Runtime::HGWaterManager::UpdateWaterCPUAndGPUData(this, 0LL);
			//   HG::Rendering::Runtime::HGWaterManager::SetRippleDataToRenderPipeLine(this, 0LL);
			//   if ( !byte_18D8EDBD5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
			//     byte_18D8EDBD5 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v5);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_41;
			//   if ( wrapperArray.max_length.size <= 921 )
			//     goto LABEL_19;
			//   if ( !items._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(items, wrapperArray);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_41;
			//   if ( wrapperArray.max_length.size <= 0x399u )
			//     goto LABEL_52;
			//   if ( !wrapperArray[25].vector[21] )
			//   {
			// LABEL_19:
			//     if ( !this.fields.m_globalConfigs
			//       || this.fields.m_validGlobalConfigIndex < 0
			//       || this.fields.m_validGlobalConfigIndex >= this.fields.m_globalConfigs.fields._size )
			//     {
			//       v8 = 0LL;
			//       goto LABEL_24;
			//     }
			//     m_globalConfigs = this.fields.m_globalConfigs;
			//     m_validGlobalConfigIndex = this.fields.m_validGlobalConfigIndex;
			//     if ( (unsigned int)m_validGlobalConfigIndex >= m_globalConfigs.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     items = (struct ILFixDynamicMethodWrapper_2__Class *)m_globalConfigs.fields._items;
			//     if ( !items )
			//       goto LABEL_41;
			//     if ( (unsigned int)m_validGlobalConfigIndex < LODWORD(items._0.namespaze) )
			//     {
			//       v8 = (HGWaterGlobalConfig *)*((_QWORD *)&items._0.byval_arg.data.dummy + m_validGlobalConfigIndex);
			//       goto LABEL_24;
			//     }
			// LABEL_52:
			//     sub_180070270(items, wrapperArray);
			//   }
			//   v27 = IFix::WrappersManagerImpl::GetPatch(921, 0LL);
			//   if ( !v27 )
			//     goto LABEL_41;
			//   v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_348(v27, (Object *)this, 0LL);
			// LABEL_24:
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v8 )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( v8.fields._._._._.m_CachedPtr )
			//     {
			//       globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//       if ( globalConfig )
			//       {
			//         scenePath = HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(globalConfig, 0LL);
			//         v11 = (unsigned __int8 (__fastcall *)(String *))qword_18D8F5CC0;
			//         if ( !qword_18D8F5CC0 )
			//         {
			//           v11 = (unsigned __int8 (__fastcall *)(String *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.HyperGryph.HGWaterRender::CheckNewHGWaterGloablC"
			//                                                             "onfigCPP(System.String)");
			//           if ( !v11 )
			//           {
			//             v28 = sub_1802DBBE8("UnityEngine.HyperGryph.HGWaterRender::CheckNewHGWaterGloablConfigCPP(System.String)");
			//             sub_18000F750(v28, 0LL);
			//           }
			//           qword_18D8F5CC0 = (__int64)v11;
			//         }
			//         if ( !v11(scenePath) )
			//           return;
			//         v12 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//         if ( v12 )
			//         {
			//           v13 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(v12, 0LL);
			//           v14 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//           if ( v14 )
			//           {
			//             sectorNum = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(v14, 0LL);
			//             v16 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//             if ( v16 )
			//             {
			//               sectorSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(v16, 0LL);
			//               v18 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//               if ( v18 )
			//               {
			//                 sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v18, 0LL);
			//                 v20 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                 if ( v20 )
			//                 {
			//                   sectorCoordsMax = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(v20, 0LL);
			//                   v22 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                   if ( v22 )
			//                   {
			//                     sectorDataGUIDs = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataAssetHashes(v22, 0LL);
			//                     v24 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                     if ( v24 )
			//                     {
			//                       sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(v24, 0LL);
			//                       UnityEngine::HyperGryph::HGWaterRender::UpdateHGWaterGloablConfigCPP(
			//                         v13,
			//                         sectorNum,
			//                         sectorSize,
			//                         sectorCoordsMin,
			//                         sectorCoordsMax,
			//                         sectorDataGUIDs,
			//                         sectorDataExists,
			//                         0LL);
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_41:
			//       sub_180B536AC(items, wrapperArray);
			//     }
			//   }
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::HGWaterManager::Release(HGWaterManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919839 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::get_IsCreated);
			//     byte_18D919839 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1910, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1910, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.waterRippleData.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.waterRippleData,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.waterGPUData.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.waterGPUData,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.defaultWaterMaterialData.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.defaultWaterMaterialData,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//   }
			// }
			// 
		}

		private void UpdateWaterGlobalConfigValidIndex()
		{
			// // Void UpdateWaterGlobalConfigValidIndex()
			// void HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(
			//         HGWaterManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rax
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBDA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
			//     byte_18D8EDBDA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4664, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4664, 0LL);
			//     if ( !Patch )
			// LABEL_11:
			//       sub_180B536AC(v4, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_validGlobalConfigIndex = -1;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_globalConfigs = this.fields.m_globalConfigs;
			//       if ( !m_globalConfigs )
			//         goto LABEL_11;
			//       if ( i >= m_globalConfigs.fields._size )
			//         return;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                (List_1_System_Object_ *)this.fields.m_globalConfigs,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
			//       if ( !Item )
			//         goto LABEL_11;
			//       if ( HG::Rendering::Runtime::HGWaterGlobalConfig::ShouldRenderWater((HGWaterGlobalConfig *)Item, 0LL) )
			//         break;
			//     }
			//     this.fields.m_validGlobalConfigIndex = i;
			//   }
			// }
			// 
		}

		public void AddWaterGlobalConfig(HGWaterGlobalConfig globalConfig)
		{
			// // Void AddWaterGlobalConfig(HGWaterGlobalConfig)
			// void HG::Rendering::Runtime::HGWaterManager::AddWaterGlobalConfig(
			//         HGWaterManager *this,
			//         HGWaterGlobalConfig *globalConfig,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_globalConfigs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBDB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains);
			//     byte_18D8EDBDB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4663, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4663, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)globalConfig,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_9;
			//   }
			//   m_globalConfigs = (List_1_System_Object_ *)this.fields.m_globalConfigs;
			//   if ( !m_globalConfigs )
			//     goto LABEL_9;
			//   if ( System::Collections::Generic::List<System::Object>::Contains(
			//          m_globalConfigs,
			//          (Object *)globalConfig,
			//          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains) )
			//   {
			//     return;
			//   }
			//   m_globalConfigs = (List_1_System_Object_ *)this.fields.m_globalConfigs;
			//   if ( !m_globalConfigs )
			// LABEL_9:
			//     sub_180B536AC(m_globalConfigs, v5);
			//   sub_1822AD140(m_globalConfigs, (Object *)globalConfig);
			//   HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(this, 0LL);
			// }
			// 
		}

		public void RemoveWaterGlobalConfig(HGWaterGlobalConfig globalConfig)
		{
			// // Void RemoveWaterGlobalConfig(HGWaterGlobalConfig)
			// void HG::Rendering::Runtime::HGWaterManager::RemoveWaterGlobalConfig(
			//         HGWaterManager *this,
			//         HGWaterGlobalConfig *globalConfig,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_globalConfigs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91983A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Remove);
			//     byte_18D91983A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4668, 0LL) )
			//   {
			//     m_globalConfigs = (List_1_System_Object_ *)this.fields.m_globalConfigs;
			//     if ( m_globalConfigs )
			//     {
			//       if ( !System::Collections::Generic::List<System::Object>::Contains(
			//               m_globalConfigs,
			//               (Object *)globalConfig,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains) )
			//         return;
			//       m_globalConfigs = (List_1_System_Object_ *)this.fields.m_globalConfigs;
			//       if ( m_globalConfigs )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           m_globalConfigs,
			//           (Object *)globalConfig,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Remove);
			//         HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_globalConfigs, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4668, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)globalConfig,
			//     0LL);
			// }
			// 
		}

		public void UpdateWaterCPUAndGPUData()
		{
			// // Void UpdateWaterCPUAndGPUData()
			// void HG::Rendering::Runtime::HGWaterManager::UpdateWaterCPUAndGPUData(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   TileBase *v5; // rdx
			//   HGWaterGlobalConfig *globalConfig; // rdi
			//   Vector3Int *v7; // r8
			//   ITilemap *v8; // r9
			//   HGWaterGlobalConfig *v9; // rax
			//   __int64 v10; // rdx
			//   Texture2D *flowMap; // rdi
			//   int v12; // ebp
			//   HGWaterGlobalConfig *v13; // rax
			//   int v14; // r15d
			//   HGWaterGlobalConfig *v15; // rax
			//   __int64 v16; // rdx
			//   Texture2DArray *normalMapArray; // rdi
			//   HGWaterGlobalConfig *v18; // rax
			//   int v19; // r14d
			//   HGWaterGlobalConfig *v20; // rax
			//   __int64 v21; // rdx
			//   Texture2DArray *v22; // rdi
			//   HGWaterGlobalConfig *v23; // rax
			//   int v24; // esi
			//   HGWaterGlobalConfig *v25; // rax
			//   TileBase *v26; // rdx
			//   Texture2D *causticMap; // rdi
			//   Vector3Int *v28; // r8
			//   ITilemap *v29; // r9
			//   HGWaterGlobalConfig *v30; // rax
			//   Void *m_Buffer; // rax
			//   __m128 v32; // xmm3
			//   __m128 v33; // xmm3
			//   __m128 v34; // xmm3
			//   __m128 v35; // xmm3
			//   TileBase *v36; // rdx
			//   Vector3Int *v37; // r8
			//   ITilemap *v38; // r9
			//   Object *v39; // rdi
			//   Object__Class *klass; // rax
			//   int32_t castClass; // eax
			//   __m128i v42; // xmm0
			//   Void *v43; // rax
			//   __m128 v44; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v46; // rax
			//   __m128 v47; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDBDC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBDC = 1;
			//   }
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
			//     goto LABEL_102;
			//   if ( wrapperArray.max_length.size > 1949 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_102;
			//     if ( wrapperArray.max_length.size <= 0x79Du )
			//       goto LABEL_117;
			//     if ( wrapperArray[54].vector[5] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1949, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_102;
			//     }
			//   }
			//   if ( !HG::Rendering::Runtime::HGWaterManager::get_shouldRender(this, 0LL) )
			//     return;
			//   globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !globalConfig )
			//     goto LABEL_101;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( globalConfig.fields._._._._.m_CachedPtr )
			//   {
			//     v9 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//     if ( !v9 )
			//       goto LABEL_102;
			//     flowMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(v9, 0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v10);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v10);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     v12 = 2;
			//     if ( !flowMap )
			//       goto LABEL_98;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v10);
			//     if ( flowMap.fields._._.m_CachedPtr )
			//     {
			//       v13 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//       if ( !v13 || !HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(v13, 0LL) )
			//         goto LABEL_102;
			//       v14 = sub_18003ED00(7LL);
			//     }
			//     else
			//     {
			// LABEL_98:
			//       v14 = 2;
			//     }
			//     v15 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//     if ( !v15 )
			//       goto LABEL_102;
			//     normalMapArray = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v15, 0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !normalMapArray )
			//       goto LABEL_99;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//     if ( normalMapArray.fields._._.m_CachedPtr )
			//     {
			//       v18 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//       if ( !v18 || !HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v18, 0LL) )
			//         goto LABEL_102;
			//       v19 = sub_18003ED00(5LL);
			//     }
			//     else
			//     {
			// LABEL_99:
			//       v19 = 2;
			//     }
			//     v20 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//     if ( !v20 )
			//       goto LABEL_102;
			//     v22 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v20, 0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !v22 )
			//       goto LABEL_100;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     if ( v22.fields._._.m_CachedPtr )
			//     {
			//       v23 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//       if ( !v23 || !HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v23, 0LL) )
			//         goto LABEL_102;
			//       v24 = sub_18003ED00(7LL);
			//     }
			//     else
			//     {
			// LABEL_100:
			//       v24 = 2;
			//     }
			//     v25 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//     if ( !v25 )
			//       goto LABEL_102;
			//     causticMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(v25, 0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( causticMap )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//       if ( causticMap.fields._._.m_CachedPtr )
			//       {
			//         v30 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//         if ( !v30 || !HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(v30, 0LL) )
			//           goto LABEL_102;
			//         v12 = sub_18003ED00(5LL);
			//       }
			//     }
			//     m_Buffer = this.fields.waterGPUData.m_Buffer;
			//     v32 = 0LL;
			//     v32.m128_f32[0] = (float)v14;
			//     v33 = _mm_shuffle_ps(v32, v32, 225);
			//     v33.m128_f32[0] = (float)v19;
			//     v34 = _mm_shuffle_ps(v33, v33, 198);
			//     v34.m128_f32[0] = (float)v24;
			//     v35 = _mm_shuffle_ps(v34, v34, 39);
			//     v35.m128_f32[0] = (float)v12;
			//     v47 = _mm_shuffle_ps(v35, v35, 57);
			//     *(__m128 *)&m_Buffer[160] = v47;
			//   }
			//   else
			//   {
			// LABEL_101:
			//     *(TileAnimationData *)&this.fields.waterGPUData.m_Buffer[160] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                         (TileAnimationData *)&v47,
			//                                                                         v5,
			//                                                                         v7,
			//                                                                         v8,
			//                                                                         (MethodInfo *)v47.m128_u64[0]);
			//   }
			//   *(TileAnimationData *)&this.fields.waterGPUData.m_Buffer[176] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                       (TileAnimationData *)&v47,
			//                                                                       v26,
			//                                                                       v28,
			//                                                                       v29,
			//                                                                       (MethodInfo *)v47.m128_u64[0]);
			//   *(TileAnimationData *)&this.fields.waterGPUData.m_Buffer[192] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                       (TileAnimationData *)&v47,
			//                                                                       v36,
			//                                                                       v37,
			//                                                                       v38,
			//                                                                       (MethodInfo *)v47.m128_u64[0]);
			//   v39 = (Object *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//   if ( !v39 )
			//     goto LABEL_102;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_102;
			//   if ( wrapperArray.max_length.size <= 946 )
			//     goto LABEL_94;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_102:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x3B2 )
			// LABEL_117:
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[20]._0.declaringType )
			//   {
			// LABEL_94:
			//     klass = v39[3].klass;
			//     if ( klass )
			//       castClass = (int32_t)klass._0.castClass;
			//     else
			//       castClass = 2048;
			//     goto LABEL_96;
			//   }
			//   v46 = IFix::WrappersManagerImpl::GetPatch(946, 0LL);
			//   if ( !v46 )
			//     goto LABEL_102;
			//   castClass = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)v46, v39, 0LL);
			// LABEL_96:
			//   v42 = _mm_cvtsi32_si128(castClass);
			//   v43 = this.fields.waterGPUData.m_Buffer;
			//   v47.m128_u64[0] = 0LL;
			//   v47.m128_i32[2] = 1107296256;
			//   v44 = _mm_shuffle_ps(v47, v47, 147);
			//   v44.m128_f32[0] = _mm_cvtepi32_ps(v42).m128_f32[0];
			//   *(__m128 *)&v43[208] = _mm_shuffle_ps(v44, v44, 57);
			// }
			// 
		}

		public void UpdateStaticWater(string name, int materialIndex, ref NativeArray<Vector4> materialData)
		{
			// // Void UpdateStaticWater(String, Int32, NativeArray`1[UnityEngine.Vector4] ByRef)
			// void HG::Rendering::Runtime::HGWaterManager::UpdateStaticWater(
			//         HGWaterManager *this,
			//         String *name,
			//         int32_t materialIndex,
			//         NativeArray_1_UnityEngine_Vector4_ *materialData,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm0
			//   struct MethodInfo *v10; // rcx
			//   Void *m_Buffer; // rax
			//   NativeArray_1_UnityEngine_Vector4_ v12; // xmm0
			//   Void *v13; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   NativeArray_1_UnityEngine_Vector4_ v17; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDBDD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     sub_18003C530(&off_18C912848);
			//     byte_18D8EDBDD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4653, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4653, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1338(
			//       Patch,
			//       (Object *)this,
			//       (Object *)name,
			//       materialIndex,
			//       materialData,
			//       0LL);
			//   }
			//   else if ( (unsigned int)materialIndex > 0x1F )
			//   {
			//     HG::Rendering::HGRPLogger::LogError<System::Object,int>(
			//       (String *)"无法添静态材质水体，Asset({0})的材质索引({1})不合法，请修改",
			//       (Object *)name,
			//       materialIndex,
			//       MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
			//   }
			//   else
			//   {
			//     waterGPUData = this.fields.waterGPUData;
			//     v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//     {
			//       sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     }
			//     m_Buffer = waterGPUData.m_Buffer;
			//     v12 = *materialData;
			//     v13 = &m_Buffer[320 * materialIndex + 288];
			//     v17 = *materialData;
			//     if ( !v10.rgctx_data )
			//     {
			//       sub_180041F40(v10);
			//       v12.m_Buffer = v17.m_Buffer;
			//     }
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v13, v12.m_Buffer, 320LL, 0LL);
			//   }
			// }
			// 
		}

		public void UpdateDynamicWater(string name, int materialIndex, ref NativeArray<Vector4> materialData)
		{
			// // Void UpdateDynamicWater(String, Int32, NativeArray`1[UnityEngine.Vector4] ByRef)
			// void HG::Rendering::Runtime::HGWaterManager::UpdateDynamicWater(
			//         HGWaterManager *this,
			//         String *name,
			//         int32_t materialIndex,
			//         NativeArray_1_UnityEngine_Vector4_ *materialData,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm0
			//   struct MethodInfo *v10; // rcx
			//   Void *m_Buffer; // rax
			//   NativeArray_1_UnityEngine_Vector4_ v12; // xmm0
			//   Void *v13; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   NativeArray_1_UnityEngine_Vector4_ v17; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDBDE )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     sub_18003C530(&off_18C912840);
			//     byte_18D8EDBDE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4674, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4674, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1338(
			//       Patch,
			//       (Object *)this,
			//       (Object *)name,
			//       materialIndex,
			//       materialData,
			//       0LL);
			//   }
			//   else if ( (unsigned int)(materialIndex - 32) > 0x1F )
			//   {
			//     HG::Rendering::HGRPLogger::LogError<System::Object,int>(
			//       (String *)"无法添动态材质水体，WaterRenderer({0})的材质索引({1})不合法，请修改",
			//       (Object *)name,
			//       materialIndex,
			//       MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
			//   }
			//   else
			//   {
			//     waterGPUData = this.fields.waterGPUData;
			//     v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//     {
			//       sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
			//     }
			//     m_Buffer = waterGPUData.m_Buffer;
			//     v12 = *materialData;
			//     v13 = &m_Buffer[320 * materialIndex + 288];
			//     v17 = *materialData;
			//     if ( !v10.rgctx_data )
			//     {
			//       sub_180041F40(v10);
			//       v12.m_Buffer = v17.m_Buffer;
			//     }
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v13, v12.m_Buffer, 320LL, 0LL);
			//   }
			// }
			// 
		}

		public void SetWaterDataCB(HGCamera hgCamera, HGSettingParameters settingParameters, ref CBHandle cbHandle, ref Matrix4x4 orthoViewProj, ref Matrix4x4 orthoDeviceViewProj, ref Matrix4x4 orthoDeviceInvViewProj)
		{
			// // Void SetWaterDataCB(HGCamera, HGSettingParameters, CBHandle ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
			// void HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
			//         HGWaterManager *this,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         CBHandle *cbHandle,
			//         Matrix4x4 *orthoViewProj,
			//         Matrix4x4 *orthoDeviceViewProj,
			//         Matrix4x4 *orthoDeviceInvViewProj,
			//         MethodInfo *method)
			// {
			//   float v8; // xmm1_4
			//   __m128 v13; // xmm0
			//   __int64 v14; // rdx
			//   Object_1 *globalConfig; // rdi
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v19)(Camera *); // rax
			//   __int64 v20; // rdi
			//   void (__fastcall *v21)(__int64, Vector4 *); // rax
			//   Camera *v22; // rbx
			//   __int64 (__fastcall *v23)(Camera *); // rax
			//   Transform *v24; // rax
			//   SettingParameter_1_System_Single_ *waterDisplacementWeight_k__BackingField; // rcx
			//   __m128 v26; // xmm7
			//   HGWaterGlobalConfig *v27; // rax
			//   HGWaterGlobalConfig *v28; // rax
			//   __m128 x_low; // xmm11
			//   __int128 v30; // xmm0
			//   System::MathF *v31; // rcx
			//   float z; // xmm13_4
			//   __m128 v33; // xmm8
			//   System::MathF *v34; // rcx
			//   __m128 y_low; // xmm12
			//   float v36; // xmm10_4
			//   void (__fastcall *v37)(Matrix4x4 *, Matrix4x4 *); // rax
			//   HGWaterGlobalConfig *v38; // rax
			//   HGWaterGlobalConfig *v39; // rax
			//   int32_t heightMapY; // eax
			//   int v41; // edx
			//   int v42; // r8d
			//   int v43; // r9d
			//   __int64 v44; // rax
			//   float4 v45; // xmm1
			//   float4 v46; // xmm0
			//   float4 v47; // xmm1
			//   Matrix4x4 *v48; // rax
			//   Vector4 v49; // xmm6
			//   __int128 v50; // xmm14
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm15
			//   Vector4 v53; // xmm0
			//   __int128 v54; // xmm1
			//   Vector4 v55; // xmm0
			//   Vector4 v56; // xmm0
			//   Vector4 v57; // xmm0
			//   __int128 v58; // xmm0
			//   void (__fastcall *v59)(Vector4 *, Matrix4x4 *, __int128 *); // rax
			//   __int64 v60; // rdx
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   Vector4 v64; // xmm0
			//   void (__fastcall *v65)(Matrix4x4 *, __int64, Matrix4x4 *); // rax
			//   void (__fastcall *v66)(Matrix4x4 *, Vector4 *, __int128 *); // rax
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm1
			//   Matrix4x4 *inverse; // rax
			//   __int128 v71; // xmm1
			//   __int128 v72; // xmm2
			//   __int128 v73; // xmm3
			//   HGWaterGlobalConfig *v74; // rax
			//   int32_t RealMeshNumPerLOD; // ebx
			//   HGWaterGlobalConfig *v76; // rax
			//   __m128 v77; // xmm8
			//   __m128i v78; // xmm0
			//   Void *m_Buffer; // rax
			//   __m128 v80; // xmm8
			//   __m128 v81; // xmm8
			//   HGWaterGlobalConfig *v82; // rax
			//   HGWaterGlobalConfigData *data; // rax
			//   unsigned __int64 v84; // xmm6_8
			//   HGWaterGlobalConfig *v85; // rax
			//   HGWaterGlobalConfigData *v86; // rax
			//   float y; // xmm1_4
			//   Void *v88; // rax
			//   __m128 v89; // xmm7
			//   __m128 v90; // xmm7
			//   __m128 v91; // xmm7
			//   HGWaterGlobalConfig *v92; // rax
			//   ValueTuple_2_Int32_Int32_ SectorCoords; // rax
			//   int v94; // ebx
			//   int v95; // r14d
			//   HGWaterGlobalConfig *v96; // rax
			//   int v97; // edi
			//   HGWaterGlobalConfig *v98; // rax
			//   int32_t sectorCoordsMin; // eax
			//   __m128 v100; // xmm4
			//   __m128 v101; // xmm4
			//   __m128 v102; // xmm4
			//   float v103; // xmm2_4
			//   __m128 v104; // xmm4
			//   float v105; // xmm9_4
			//   __m128 v106; // xmm4
			//   Void *v107; // rax
			//   __m128 v108; // xmm0
			//   __m128 v109; // xmm0
			//   void *ptr; // rdi
			//   NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm6
			//   void (__fastcall *v112)(void *, Void *, _QWORD); // rax
			//   int v113; // ebx
			//   __int64 v114; // rax
			//   __int64 v115; // rax
			//   __int64 v116; // rax
			//   __int64 v117; // rax
			//   __int64 v118; // rax
			//   __int64 v119; // rax
			//   __int64 v120; // rax
			//   __m128 v121; // xmm0
			//   __int64 v122; // rax
			//   Vector4 v123; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector4 si128; // [rsp+60h] [rbp-A0h] BYREF
			//   __m128i v125; // [rsp+70h] [rbp-90h] BYREF
			//   float v126; // [rsp+80h] [rbp-80h]
			//   float v127; // [rsp+84h] [rbp-7Ch]
			//   Matrix4x4 v128; // [rsp+90h] [rbp-70h] BYREF
			//   Matrix4x4 v129; // [rsp+D0h] [rbp-30h] BYREF
			//   __int128 v130; // [rsp+110h] [rbp+10h] BYREF
			//   __int128 v131; // [rsp+120h] [rbp+20h]
			//   __int128 v132; // [rsp+130h] [rbp+30h]
			//   __int128 v133; // [rsp+140h] [rbp+40h]
			//   Vector4 v134; // [rsp+150h] [rbp+50h] BYREF
			//   Matrix4x4 v135; // [rsp+160h] [rbp+60h] BYREF
			//   Vector4 v136; // [rsp+1A0h] [rbp+A0h] BYREF
			//   __int128 v137; // [rsp+1B0h] [rbp+B0h]
			//   __int128 v138; // [rsp+1C0h] [rbp+C0h]
			//   __int128 v139; // [rsp+1D0h] [rbp+D0h]
			//   Matrix4x4 v140; // [rsp+1E0h] [rbp+E0h] BYREF
			// 
			//   if ( !byte_18D8EDBDF )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     byte_18D8EDBDF = 1;
			//   }
			//   v13 = 0LL;
			//   memset(&v128, 0, sizeof(v128));
			//   if ( IFix::WrappersManagerImpl::IsPatched(928, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(928, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_351(
			//         Patch,
			//         (Object *)this,
			//         (Object *)hgCamera,
			//         (Object *)settingParameters,
			//         cbHandle,
			//         orthoViewProj,
			//         orthoDeviceViewProj,
			//         orthoDeviceInvViewProj,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_40;
			//   }
			//   globalConfig = (Object_1 *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     *(double *)v13.m128_u64 = il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v14);
			//   if ( !UnityEngine::Object::op_Equality(globalConfig, 0LL, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v19 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v19 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//           if ( !v19 )
			//           {
			//             v114 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//             sub_18000F750(v114, 0LL);
			//           }
			//           qword_18D8F4D40 = (__int64)v19;
			//         }
			//         v20 = v19(camera);
			//         if ( v20 )
			//         {
			//           *(_QWORD *)&si128.x = 0LL;
			//           si128.z = 0.0;
			//           v21 = (void (__fastcall *)(__int64, Vector4 *))qword_18D8F52E0;
			//           if ( !qword_18D8F52E0 )
			//           {
			//             v21 = (void (__fastcall *)(__int64, Vector4 *))il2cpp_resolve_icall_0(
			//                                                              "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//             if ( !v21 )
			//             {
			//               v115 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//               sub_18000F750(v115, 0LL);
			//             }
			//             qword_18D8F52E0 = (__int64)v21;
			//           }
			//           v21(v20, &si128);
			//           v22 = hgCamera.fields.camera;
			//           if ( v22 )
			//           {
			//             v23 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//             if ( !qword_18D8F4D40 )
			//             {
			//               v23 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//               if ( !v23 )
			//               {
			//                 v116 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//                 sub_18000F750(v116, 0LL);
			//               }
			//               qword_18D8F4D40 = (__int64)v23;
			//             }
			//             v24 = (Transform *)v23(v22);
			//             if ( v24 )
			//             {
			//               UnityEngine::Transform::get_forward((Vector3 *)&v123, v24, 0LL);
			//               if ( settingParameters )
			//               {
			//                 v13.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                     settingParameters.fields._waterPrepassTextureSize_k__BackingField,
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                 waterDisplacementWeight_k__BackingField = settingParameters.fields._waterDisplacementWeight_k__BackingField;
			//                 v127 = v13.m128_f32[0];
			//                 v13.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                     waterDisplacementWeight_k__BackingField,
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                 v26 = v13;
			//                 v126 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                          settingParameters.fields._waterDisplacementDistance_k__BackingField,
			//                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                 v27 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                 if ( v27 )
			//                 {
			//                   HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealHeightMapXZ(v27, settingParameters, 0LL);
			//                   v28 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                   if ( v28 )
			//                   {
			//                     HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapOffset(v28, 0LL);
			//                     x_low = (__m128)LODWORD(si128.x);
			//                     v30 = LODWORD(si128.x);
			//                     System::MathF::Floor(v31, v8);
			//                     z = si128.z;
			//                     v33 = (__m128)v30;
			//                     *(float *)&v30 = si128.z;
			//                     System::MathF::Floor(v34, v8);
			//                     y_low = (__m128)LODWORD(si128.y);
			//                     si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//                     v36 = *(float *)&v30;
			//                     v125 = _mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//                     LODWORD(v123.x) = v33.m128_i32[0];
			//                     LODWORD(v123.y) = y_low.m128_i32[0];
			//                     LODWORD(v123.z) = v30;
			//                     v123.w = 1.0;
			//                     v134 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//                     UnityEngine::Matrix4x4::Matrix4x4(&v128, (Vector4 *)&v125, &v134, &si128, &v123, 0LL);
			//                     v37 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//                     v129 = v128;
			//                     memset(&v128, 0, sizeof(v128));
			//                     if ( !qword_18D8F4BD0 )
			//                     {
			//                       v37 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                              "UnityEngine.Matrix4x4::Inverse_Injected(Uni"
			//                                                                              "tyEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                       if ( !v37 )
			//                       {
			//                         v117 = sub_1802DBBE8(
			//                                  "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                         sub_18000F750(v117, 0LL);
			//                       }
			//                       qword_18D8F4BD0 = (__int64)v37;
			//                     }
			//                     v37(&v129, &v128);
			//                     v38 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                     if ( v38 )
			//                     {
			//                       HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v38, 0LL);
			//                       v39 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                       if ( v39 )
			//                       {
			//                         heightMapY = HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v39, 0LL);
			//                         v44 = sub_182A59E70((unsigned int)&v140, v41, v42, v43, (float)heightMapY * 0.5);
			//                         v45 = *(float4 *)(v44 + 16);
			//                         *(_OWORD *)&v129.m00 = *(_OWORD *)v44;
			//                         v46 = *(float4 *)(v44 + 32);
			//                         *(float4 *)&v129.m01 = v45;
			//                         v47 = *(float4 *)(v44 + 48);
			//                         *(float4 *)&v129.m02 = v46;
			//                         *(float4 *)&v129.m03 = v47;
			//                         v48 = Unity::Mathematics::float4x4::op_Implicit(&v140, (float4x4 *)&v129, 0LL);
			//                         v49 = *(Vector4 *)&v128.m00;
			//                         v50 = *(_OWORD *)&v128.m01;
			//                         v51 = *(_OWORD *)&v48.m01;
			//                         v52 = *(_OWORD *)&v128.m02;
			//                         v125 = *(__m128i *)&v48.m00;
			//                         v53 = *(Vector4 *)&v48.m01;
			//                         v137 = v51;
			//                         v54 = *(_OWORD *)&v48.m03;
			//                         v134 = v53;
			//                         v55 = *(Vector4 *)&v48.m02;
			//                         v139 = v54;
			//                         v123 = v55;
			//                         v56 = *(Vector4 *)&v48.m03;
			//                         *(_OWORD *)&v135.m00 = *(_OWORD *)&v128.m00;
			//                         si128 = v56;
			//                         v57 = *(Vector4 *)&v48.m00;
			//                         *(_OWORD *)&v135.m01 = *(_OWORD *)&v128.m01;
			//                         v136 = v57;
			//                         v58 = *(_OWORD *)&v48.m02;
			//                         v59 = (void (__fastcall *)(Vector4 *, Matrix4x4 *, __int128 *))qword_18D8F4BC0;
			//                         *(_OWORD *)&v135.m02 = *(_OWORD *)&v128.m02;
			//                         v138 = v58;
			//                         *(_OWORD *)&v135.m03 = *(_OWORD *)&v128.m03;
			//                         v130 = 0LL;
			//                         v131 = 0LL;
			//                         v132 = 0LL;
			//                         v133 = 0LL;
			//                         if ( !qword_18D8F4BC0 )
			//                         {
			//                           v59 = (void (__fastcall *)(Vector4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                            "UnityEngine.Matrix4x4::HGMult"
			//                                                                                            "iplyMatrix4x4Fast_Injected(Un"
			//                                                                                            "ityEngine.Matrix4x4&,UnityEng"
			//                                                                                            "ine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                           if ( !v59 )
			//                           {
			//                             v118 = sub_1802DBBE8(
			//                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,Unit"
			//                                      "yEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                             sub_18000F750(v118, 0LL);
			//                           }
			//                           qword_18D8F4BC0 = (__int64)v59;
			//                         }
			//                         v59(&v136, &v135, &v130);
			//                         v61 = v131;
			//                         *(_OWORD *)&orthoViewProj.m00 = v130;
			//                         v62 = v132;
			//                         *(_OWORD *)&orthoViewProj.m01 = v61;
			//                         v63 = v133;
			//                         *(_OWORD *)&orthoViewProj.m02 = v62;
			//                         v64 = (Vector4)v125;
			//                         *(_OWORD *)&orthoViewProj.m03 = v63;
			//                         v65 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))qword_18D8F44A8;
			//                         *(Vector4 *)&v140.m00 = v64;
			//                         *(Vector4 *)&v140.m01 = v134;
			//                         *(Vector4 *)&v140.m02 = v123;
			//                         memset(&v129, 0, sizeof(v129));
			//                         *(Vector4 *)&v140.m03 = si128;
			//                         if ( !qword_18D8F44A8 )
			//                         {
			//                           v65 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                           "UnityEngine.GL::GetGPUProjecti"
			//                                                                                           "onMatrix_Injected(UnityEngine."
			//                                                                                           "Matrix4x4&,System.Boolean,Unit"
			//                                                                                           "yEngine.Matrix4x4&)");
			//                           if ( !v65 )
			//                           {
			//                             v119 = sub_1802DBBE8(
			//                                      "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boole"
			//                                      "an,UnityEngine.Matrix4x4&)");
			//                             sub_18000F750(v119, 0LL);
			//                           }
			//                           qword_18D8F44A8 = (__int64)v65;
			//                         }
			//                         LOBYTE(v60) = 1;
			//                         v65(&v140, v60, &v129);
			//                         v66 = (void (__fastcall *)(Matrix4x4 *, Vector4 *, __int128 *))qword_18D8F4BC0;
			//                         v136 = v49;
			//                         v135 = v129;
			//                         v137 = v50;
			//                         v138 = v52;
			//                         v139 = *(_OWORD *)&v128.m03;
			//                         v130 = 0LL;
			//                         v131 = 0LL;
			//                         v132 = 0LL;
			//                         v133 = 0LL;
			//                         if ( !qword_18D8F4BC0 )
			//                         {
			//                           v66 = (void (__fastcall *)(Matrix4x4 *, Vector4 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                            "UnityEngine.Matrix4x4::HGMult"
			//                                                                                            "iplyMatrix4x4Fast_Injected(Un"
			//                                                                                            "ityEngine.Matrix4x4&,UnityEng"
			//                                                                                            "ine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                           if ( !v66 )
			//                           {
			//                             v120 = sub_1802DBBE8(
			//                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,Unit"
			//                                      "yEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                             sub_18000F750(v120, 0LL);
			//                           }
			//                           qword_18D8F4BC0 = (__int64)v66;
			//                         }
			//                         v66(&v135, &v136, &v130);
			//                         v67 = v131;
			//                         *(_OWORD *)&orthoDeviceViewProj.m00 = v130;
			//                         v68 = v132;
			//                         *(_OWORD *)&orthoDeviceViewProj.m01 = v67;
			//                         v69 = v133;
			//                         *(_OWORD *)&orthoDeviceViewProj.m02 = v68;
			//                         *(_OWORD *)&orthoDeviceViewProj.m03 = v69;
			//                         inverse = UnityEngine::Matrix4x4::get_inverse(&v140, orthoDeviceViewProj, 0LL);
			//                         v71 = *(_OWORD *)&inverse.m01;
			//                         v72 = *(_OWORD *)&inverse.m02;
			//                         v73 = *(_OWORD *)&inverse.m03;
			//                         *(_OWORD *)&orthoDeviceInvViewProj.m00 = *(_OWORD *)&inverse.m00;
			//                         *(_OWORD *)&orthoDeviceInvViewProj.m01 = v71;
			//                         *(_OWORD *)&orthoDeviceInvViewProj.m02 = v72;
			//                         *(_OWORD *)&orthoDeviceInvViewProj.m03 = v73;
			//                         *(Vector4 *)this.fields.waterGPUData.m_Buffer = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                             (Vector4 *)&v125,
			//                                                                             orthoDeviceViewProj,
			//                                                                             0,
			//                                                                             0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[16] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceViewProj,
			//                                                                                  1,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[32] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceViewProj,
			//                                                                                  2,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[48] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceViewProj,
			//                                                                                  3,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[64] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceInvViewProj,
			//                                                                                  0,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[80] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceInvViewProj,
			//                                                                                  1,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[96] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                  (Vector4 *)&v125,
			//                                                                                  orthoDeviceInvViewProj,
			//                                                                                  2,
			//                                                                                  0LL);
			//                         *(Vector4 *)&this.fields.waterGPUData.m_Buffer[112] = *UnityEngine::Matrix4x4::GetColumn(
			//                                                                                   (Vector4 *)&v125,
			//                                                                                   orthoDeviceInvViewProj,
			//                                                                                   3,
			//                                                                                   0LL);
			//                         v74 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                         if ( v74 )
			//                         {
			//                           RealMeshNumPerLOD = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
			//                                                 v74,
			//                                                 settingParameters,
			//                                                 0LL);
			//                           v76 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                           if ( v76 )
			//                           {
			//                             v77 = _mm_shuffle_ps(v33, v33, 225);
			//                             v77.m128_f32[0] = v36;
			//                             v78 = _mm_cvtsi32_si128(
			//                                     HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshSize(
			//                                       v76,
			//                                       settingParameters,
			//                                       0LL));
			//                             m_Buffer = this.fields.waterGPUData.m_Buffer;
			//                             v80 = _mm_shuffle_ps(v77, v77, 198);
			//                             v80.m128_f32[0] = (float)RealMeshNumPerLOD;
			//                             v81 = _mm_shuffle_ps(v80, v80, 39);
			//                             v81.m128_f32[0] = _mm_cvtepi32_ps(v78).m128_f32[0];
			//                             v123 = (Vector4)_mm_shuffle_ps(v81, v81, 57);
			//                             *(Vector4 *)&m_Buffer[128] = v123;
			//                             v82 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                             if ( v82 )
			//                             {
			//                               data = v82.fields.data;
			//                               if ( data )
			//                               {
			//                                 *(float *)&v84 = data.fields.sceneCenterOffset.x;
			//                               }
			//                               else
			//                               {
			//                                 v84 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                 *(_QWORD *)&si128.x = v84;
			//                               }
			//                               v85 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                               if ( v85 )
			//                               {
			//                                 v86 = v85.fields.data;
			//                                 if ( v86 )
			//                                 {
			//                                   y = v86.fields.sceneCenterOffset.y;
			//                                 }
			//                                 else
			//                                 {
			//                                   v121 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL);
			//                                   *(_QWORD *)&si128.x = v121.m128_u64[0];
			//                                   LODWORD(y) = _mm_shuffle_ps(v121, v121, 85).m128_u32[0];
			//                                 }
			//                                 v88 = this.fields.waterGPUData.m_Buffer;
			//                                 v89 = _mm_shuffle_ps(v26, v26, 225);
			//                                 v89.m128_f32[0] = v126;
			//                                 v90 = _mm_shuffle_ps(v89, v89, 198);
			//                                 v90.m128_f32[0] = *(float *)&v84;
			//                                 v91 = _mm_shuffle_ps(v90, v90, 39);
			//                                 v91.m128_f32[0] = y;
			//                                 v123 = (Vector4)_mm_shuffle_ps(v91, v91, 57);
			//                                 *(Vector4 *)&v88[144] = v123;
			//                                 v92 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                                 if ( v92 )
			//                                 {
			//                                   si128.z = z;
			//                                   *(_QWORD *)&si128.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//                                   SectorCoords = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
			//                                                    v92,
			//                                                    (Vector3 *)&si128,
			//                                                    0LL);
			//                                   v94 = SectorCoords.Item2 - 1;
			//                                   v95 = SectorCoords.Item1 - 1;
			//                                   v96 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                                   if ( v96 )
			//                                   {
			//                                     v97 = v95
			//                                         - HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v96, 0LL);
			//                                     v98 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
			//                                     if ( v98 )
			//                                     {
			//                                       sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(
			//                                                           v98,
			//                                                           0LL);
			//                                       v100 = (__m128)COERCE_UNSIGNED_INT((float)(v97 % 3));
			//                                       v100.m128_f32[0] = v100.m128_f32[0] / 3.0;
			//                                       v101 = _mm_shuffle_ps(v100, v100, 225);
			//                                       v101.m128_f32[0] = (float)((v94 - sectorCoordsMin) % 3) / 3.0;
			//                                       v102 = _mm_shuffle_ps(v101, v101, 198);
			//                                       v102.m128_f32[0] = (float)v95 * 128.0;
			//                                       v103 = v127;
			//                                       v104 = _mm_shuffle_ps(v102, v102, 39);
			//                                       v105 = 1.0 / v127;
			//                                       v104.m128_f32[0] = (float)v94 * 128.0;
			//                                       v106 = _mm_shuffle_ps(v104, v104, 57);
			//                                       *(__m128 *)&this.fields.waterGPUData.m_Buffer[176] = v106;
			//                                       v107 = this.fields.waterGPUData.m_Buffer;
			//                                       *(_QWORD *)&v123.x = v106.m128_u64[0];
			//                                       *(_QWORD *)&v123.z = 0x3D80000041800000LL;
			//                                       v108 = (__m128)v123;
			//                                       v108.m128_f32[0] = v103;
			//                                       v109 = _mm_shuffle_ps(v108, v108, 225);
			//                                       v109.m128_f32[0] = v105;
			//                                       *(__m128 *)&v107[192] = _mm_shuffle_ps(v109, v109, 225);
			//                                       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//                                         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//                                       ptr = cbHandle.ptr;
			//                                       waterGPUData = this.fields.waterGPUData;
			//                                       v112 = (void (__fastcall *)(void *, Void *, _QWORD))qword_18D8F3FE0;
			//                                       v113 = 16 * this.fields.waterGPUData.m_Length;
			//                                       if ( !qword_18D8F3FE0 )
			//                                       {
			//                                         v112 = (void (__fastcall *)(void *, Void *, _QWORD))il2cpp_resolve_icall_0(
			//                                                                                               "Unity.Collections.LowLevel"
			//                                                                                               ".Unsafe.UnsafeUtility::Mem"
			//                                                                                               "Cpy(System.Void*,System.Vo"
			//                                                                                               "id*,System.Int64)");
			//                                         if ( !v112 )
			//                                         {
			//                                           v122 = sub_1802DBBE8(
			//                                                    "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,"
			//                                                    "System.Void*,System.Int64)");
			//                                           sub_18000F750(v122, 0LL);
			//                                         }
			//                                         qword_18D8F3FE0 = (__int64)v112;
			//                                       }
			//                                       v112(ptr, waterGPUData.m_Buffer, v113);
			//                                       return;
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_40:
			//     sub_180B536AC(Patch, v16);
			//   }
			// }
			// 
		}

		public void SetWaterIntersectionCB(ref CBHandle cbHandle)
		{
			// // Void SetWaterIntersectionCB(CBHandle ByRef)
			// void HG::Rendering::Runtime::HGWaterManager::SetWaterIntersectionCB(
			//         HGWaterManager *this,
			//         CBHandle *cbHandle,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   NativeArray_1_UnityEngine_Vector4_ waterRippleData; // xmm0
			//   void *ptr; // rdi
			//   void (__fastcall *v10)(void *, Void *, _QWORD); // rax
			//   int v11; // ebx
			//   ILFixDynamicMethodWrapper_2__Array *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rax
			// 
			//   if ( !byte_18D8EDBE0 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     byte_18D8EDBE0 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cbHandle);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size > 926 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v12 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v12.max_length.size <= 0x39Eu )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v12[25].vector[26] )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(926, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_349(Patch, (Object *)this, cbHandle, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//     sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//   waterRippleData = this.fields.waterRippleData;
			//   ptr = cbHandle.ptr;
			//   v10 = (void (__fastcall *)(void *, Void *, _QWORD))qword_18D8F3FE0;
			//   v11 = 16 * this.fields.waterRippleData.m_Length;
			//   if ( !qword_18D8F3FE0 )
			//   {
			//     v10 = (void (__fastcall *)(void *, Void *, _QWORD))il2cpp_resolve_icall_0(
			//                                                          "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System."
			//                                                          "Void*,System.Void*,System.Int64)");
			//     if ( !v10 )
			//     {
			//       v14 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
			//       sub_18000F750(v14, 0LL);
			//     }
			//     qword_18D8F3FE0 = (__int64)v10;
			//   }
			//   v10(ptr, waterRippleData.m_Buffer, v11);
			// }
			// 
		}

		public float Frac(float value)
		{
			// // Single Frac(Single)
			// float HG::Rendering::Runtime::HGWaterManager::Frac(HGWaterManager *this, float value, MethodInfo *method)
			// {
			//   char v4; // dl
			//   __int64 v5; // rcx
			//   int v6; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1952, 0LL) )
			//     return value - (float)(int)sub_182592070(v5, v4, v6);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1952, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(
			//            (ILFixDynamicMethodWrapper_7 *)Patch,
			//            (Object *)this,
			//            value,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public float Step(float edge, float x)
		{
			// // Single Step(Single, Single)
			// float HG::Rendering::Runtime::HGWaterManager::Step(HGWaterManager *this, float edge, float x, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray.max_length.size > 4675 )
			//   {
			//     if ( !v6._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v6, wrapperArray);
			//       v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//     if ( v6 )
			//     {
			//       if ( LODWORD(v6._0.namespaze) <= 0x1243 )
			//         sub_180070270(v6, wrapperArray);
			//       if ( !v6[99]._1.unity_user_data )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4675, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_436(
			//                  (ILFixDynamicMethodWrapper_3 *)Patch,
			//                  (Object *)this,
			//                  edge,
			//                  x,
			//                  0LL);
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( edge > x )
			//     return 0.0;
			//   else
			//     return 1.0;
			// }
			// 
			return 0f;
		}

		public Vector4 ToVector4(Vector2 v, float z, float w)
		{
			// // Vector4 ToVector4(Vector2, Single, Single)
			// Vector4 *HG::Rendering::Runtime::HGWaterManager::ToVector4(
			//         Vector4 *__return_ptr retstr,
			//         HGWaterManager *this,
			//         Vector2 v,
			//         float z,
			//         float w,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v14; // [rsp+48h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1960 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//     if ( v9 )
			//     {
			//       if ( LODWORD(v9._0.namespaze) <= 0x7A8 )
			//         sub_180070270(v9, wrapperArray);
			//       if ( !*(_QWORD *)&v9[41]._1.interfaces_count )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1960, 0LL);
			//       if ( Patch )
			//       {
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_759(&v14, Patch, (Object *)this, v, z, w, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = v.x;
			//   retstr.w = w;
			//   retstr.y = v.y;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		private void SetRippleDataToRenderPipeLine()
		{
			// // Void SetRippleDataToRenderPipeLine()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGWaterManager::SetRippleDataToRenderPipeLine(HGWaterManager *this, MethodInfo *method)
			// {
			//   HGWaterManager *v2; // rdi
			//   signed __int64 v3; // rcx
			//   __int64 v4; // rsi
			//   __int64 v5; // rax
			//   __int64 v6; // r8
			//   signed __int64 v7; // r9
			//   unsigned __int64 v8; // rdx
			//   char v9; // r8
			//   signed __int64 v10; // rtt
			//   __int64 v11; // rax
			//   signed __int64 v12; // rcx
			//   __int64 v13; // rsi
			//   __int64 v14; // rax
			//   __int64 v15; // r8
			//   signed __int64 v16; // r9
			//   unsigned __int64 v17; // rdx
			//   char v18; // r8
			//   signed __int64 v19; // rtt
			//   __int64 v20; // rax
			//   signed __int64 v21; // rcx
			//   __int64 v22; // rsi
			//   __int64 v23; // rax
			//   __int64 v24; // r8
			//   signed __int64 v25; // r9
			//   unsigned __int64 v26; // rdx
			//   char v27; // r8
			//   signed __int64 v28; // rtt
			//   __int64 v29; // rax
			//   signed __int64 v30; // rcx
			//   __int64 v31; // rsi
			//   __int64 v32; // rax
			//   __int64 v33; // r8
			//   signed __int64 v34; // r9
			//   unsigned __int64 v35; // rdx
			//   char v36; // r8
			//   signed __int64 v37; // rtt
			//   __int64 v38; // rax
			//   signed __int64 v39; // rcx
			//   __int64 v40; // rsi
			//   __int64 v41; // rax
			//   __int64 v42; // r8
			//   signed __int64 v43; // r9
			//   unsigned __int64 v44; // rdx
			//   char v45; // r8
			//   signed __int64 v46; // rtt
			//   __int64 v47; // rax
			//   signed __int64 v48; // rcx
			//   __int64 v49; // rsi
			//   __int64 v50; // rax
			//   __int64 v51; // r8
			//   signed __int64 v52; // r9
			//   unsigned __int64 v53; // rdx
			//   char v54; // r8
			//   signed __int64 v55; // rtt
			//   __int64 v56; // rax
			//   signed __int64 v57; // rcx
			//   __int64 v58; // rsi
			//   __int64 v59; // rax
			//   signed __int64 v60; // r9
			//   unsigned __int64 v61; // rdx
			//   char v62; // r8
			//   signed __int64 v63; // rtt
			//   __int64 v64; // rax
			//   __int64 v65; // rdx
			//   Object_1 *m_hgWaterInteractiveSetting; // rsi
			//   unsigned __int64 v67; // rdx
			//   signed __int64 list; // rcx
			//   RippleDataManager *m_RippleDataManager; // r15
			//   signed __int64 v70; // rcx
			//   __int64 v71; // rsi
			//   __int64 v72; // rax
			//   __int64 v73; // r8
			//   signed __int64 v74; // r9
			//   unsigned __int64 v75; // rdx
			//   char v76; // r8
			//   signed __int64 v77; // rtt
			//   __int64 v78; // rax
			//   unsigned __int64 v79; // r8
			//   ILFixDynamicMethodWrapper_2 *v80; // rax
			//   float v81; // xmm7_4
			//   float v82; // xmm8_4
			//   float v83; // xmm6_4
			//   __int128 v84; // xmm0
			//   Value *m_rawRippleDataList; // rax
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *v86; // r9
			//   unsigned __int64 v87; // rdx
			//   signed __int64 v88; // rtt
			//   __int64 v89; // rcx
			//   __int64 v90; // r8
			//   Il2CppClass *klass; // rcx
			//   int v92; // r9d
			//   __int64 v93; // rdx
			//   double v94; // xmm0_8
			//   float v95; // xmm8_4
			//   double v96; // xmm0_8
			//   float v97; // xmm2_4
			//   float priority; // eax
			//   Value *v99; // r9
			//   signed __int64 v100; // rcx
			//   signed __int64 v101; // rtt
			//   __int64 v102; // rsi
			//   __int64 v103; // rcx
			//   __m128 v104; // xmm8
			//   int v105; // r15d
			//   float v106; // xmm6_4
			//   float x; // xmm9_4
			//   float y; // xmm10_4
			//   signed __int64 v109; // rcx
			//   __int64 v110; // rsi
			//   __int64 v111; // rax
			//   unsigned int v112; // r8d
			//   signed __int64 v113; // rtt
			//   __int64 v114; // rax
			//   float v115; // xmm6_4
			//   struct Math__Class *v116; // rcx
			//   __m128d v117; // xmm1
			//   double v118; // xmm0_8
			//   float v119; // xmm0_4
			//   RippleDataManager *v120; // rcx
			//   RippleDataManager *v121; // rax
			//   void (__fastcall __noreturn **v122)(); // rdx
			//   __int64 v123; // r8
			//   signed __int64 v124; // r9
			//   __m128 x_low; // xmm6
			//   __m128 y_low; // xmm7
			//   __int64 v127; // rsi
			//   __int64 v128; // rax
			//   unsigned int v129; // eax
			//   __int64 v130; // rax
			//   void (__fastcall __noreturn **v131)(); // rsi
			//   unsigned __int64 v132; // rdx
			//   signed __int64 v133; // rtt
			//   __int64 v134; // rsi
			//   __int64 v135; // rax
			//   __int64 v136; // rsi
			//   _QWORD **v137; // rcx
			//   __int64 v138; // r8
			//   __int64 v139; // rax
			//   __int64 v140; // rdx
			//   __int64 v141; // r15
			//   unsigned int v142; // eax
			//   __int64 v143; // rax
			//   unsigned __int64 v144; // rdx
			//   signed __int64 v145; // rtt
			//   __int64 v146; // r15
			//   __int64 v147; // rax
			//   __int64 v148; // r15
			//   _QWORD **v149; // rcx
			//   __int64 v150; // r8
			//   __int64 v151; // rax
			//   __int64 v152; // rdx
			//   unsigned __int64 v153; // r15
			//   unsigned int v154; // r8d
			//   __int64 v155; // r15
			//   void (__fastcall __noreturn **v156)(); // rdx
			//   unsigned int v157; // eax
			//   unsigned int v158; // r8d
			//   __int64 v159; // rax
			//   __int64 v160; // r8
			//   signed __int64 v161; // r9
			//   unsigned __int64 v162; // rdx
			//   unsigned __int64 v163; // r8
			//   signed __int64 v164; // rtt
			//   __int64 v165; // r15
			//   __int64 v166; // rax
			//   __int64 v167; // r15
			//   _QWORD **v168; // rcx
			//   __int64 v169; // r8
			//   __int64 v170; // rax
			//   __int64 v171; // rdx
			//   unsigned int v172; // ecx
			//   __int64 v173; // r15
			//   unsigned int v174; // eax
			//   unsigned int v175; // ecx
			//   __int64 v176; // rax
			//   __int64 v177; // r8
			//   Object *v178; // rax
			//   __int64 v179; // rdx
			//   __int64 v180; // rcx
			//   bool v181; // zf
			//   Value *v182; // rax
			//   VirtualMachine *rgctx_data; // rcx
			//   struct MethodInfo *v184; // rsi
			//   Object *Object; // rbx
			//   VirtualMachine__Class *v186; // rax
			//   __m128 v187; // xmm0
			//   __int64 v188; // r8
			//   signed __int64 v189; // r9
			//   unsigned __int64 v190; // rdx
			//   unsigned __int64 v191; // r8
			//   signed __int64 v192; // rtt
			//   __int64 v193; // rbx
			//   __int64 v194; // rax
			//   __int64 v195; // rbx
			//   _QWORD **v196; // rcx
			//   __int64 v197; // rcx
			//   __int64 v198; // rax
			//   __int64 v199; // rdx
			//   __m128 v200; // xmm0
			//   __m128 v201; // xmm0
			//   __m128 v202; // xmm1
			//   __m128 v203; // xmm2
			//   float v204; // xmm0_4
			//   float v205; // xmm1_4
			//   float v206; // xmm2_4
			//   Vector4 *m_Buffer; // rax
			//   __m128 v208; // xmm3
			//   __m128 v209; // xmm3
			//   __m128 v210; // xmm3
			//   HGWaterInteractiveSetting *v211; // r8
			//   Vector4 *v212; // rax
			//   __m128 v213; // xmm3
			//   __m128 v214; // xmm3
			//   __m128 v215; // xmm3
			//   int32_t v216; // ebx
			//   __int64 v217; // rsi
			//   HGWaterManager *v218; // r13
			//   RippleDataManager *v219; // rax
			//   __int64 v220; // xmm6_8
			//   RippleDataManager *v221; // rax
			//   Vector2 v222; // xmm6_8
			//   float v223; // xmm3_4
			//   RippleDataManager *v224; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v226; // [rsp+0h] [rbp-1A8h] BYREF
			//   __m128 v227; // [rsp+30h] [rbp-178h] BYREF
			//   Call call; // [rsp+40h] [rbp-168h] BYREF
			//   __int128 v229; // [rsp+68h] [rbp-140h] BYREF
			//   __m128 v230; // [rsp+78h] [rbp-130h]
			//   Value **topWriteBack; // [rsp+88h] [rbp-120h]
			//   float v232; // [rsp+90h] [rbp-118h]
			//   HGWaterManager *v233; // [rsp+98h] [rbp-110h]
			//   Call v234; // [rsp+A0h] [rbp-108h] BYREF
			//   int v235; // [rsp+D0h] [rbp-D8h] BYREF
			//   Il2CppExceptionWrapper *v236; // [rsp+E0h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v237; // [rsp+E8h] [rbp-C0h] BYREF
			//   unsigned __int64 v239; // [rsp+1C0h] [rbp+18h] BYREF
			//   float v240; // [rsp+1C8h] [rbp+20h]
			// 
			//   v2 = this;
			//   v233 = this;
			//   if ( !byte_18D8EDBE1 )
			//   {
			//     v3 = _InterlockedExchangeAdd64(
			//            (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::Dispose,
			//            0LL);
			//     if ( (v3 & 1) != 0 )
			//     {
			//       v4 = ((unsigned int)v3 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v3 >> 29 )
			//       {
			//         case 1u:
			//           v5 = sub_18003C670((unsigned int)v4);
			//           goto LABEL_16;
			//         case 2u:
			//           v5 = sub_18003C380((unsigned int)v4);
			//           goto LABEL_16;
			//         case 3u:
			//         case 6u:
			//           v5 = sub_1802DFAE0(v3);
			//           goto LABEL_16;
			//         case 4u:
			//           v5 = sub_1802DF920((unsigned int)v4);
			//           goto LABEL_16;
			//         case 5u:
			//           v6 = 8 * v4;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v4) )
			//           {
			//             v5 = *(_QWORD *)(v6 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v7 = il2cpp_string_new_len(
			//                    qword_18D8E5198
			//                  + *(int *)(v6 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                  + *(int *)(qword_18D8E51A0 + 16),
			//                    *(unsigned int *)(v6 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v5 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v4), v7, 0LL);
			//             if ( !v5 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v8 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v4) >> 12) & 0x1FFFFF) >> 6;
			//                 v9 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v4) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v8]);
			//                 do
			//                   v10 = qword_18D6870D0[v8];
			//                 while ( v10 != _InterlockedCompareExchange64(&qword_18D6870D0[v8], v10 | (1LL << v9), v10) );
			//               }
			//               v5 = v7;
			//             }
			//           }
			//           goto LABEL_16;
			//         case 7u:
			//           v11 = sub_1802DF920((unsigned int)v4);
			//           v5 = sub_18003D1A0(v11, &v239);
			// LABEL_16:
			//           if ( v5 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::Dispose,
			//               v5);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v12 = _InterlockedExchangeAdd64(
			//             (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext,
			//             0LL);
			//     if ( (v12 & 1) != 0 )
			//     {
			//       v13 = ((unsigned int)v12 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v12 >> 29 )
			//       {
			//         case 1u:
			//           v14 = sub_18003C670((unsigned int)v13);
			//           goto LABEL_32;
			//         case 2u:
			//           v14 = sub_18003C380((unsigned int)v13);
			//           goto LABEL_32;
			//         case 3u:
			//         case 6u:
			//           v14 = sub_1802DFAE0(v12);
			//           goto LABEL_32;
			//         case 4u:
			//           v14 = sub_1802DF920((unsigned int)v13);
			//           goto LABEL_32;
			//         case 5u:
			//           v15 = 8 * v13;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v13) )
			//           {
			//             v14 = *(_QWORD *)(v15 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v16 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v15 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v15 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v14 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v13), v16, 0LL);
			//             if ( !v14 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v17 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v13) >> 12) & 0x1FFFFF) >> 6;
			//                 v18 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v13) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v17]);
			//                 do
			//                   v19 = qword_18D6870D0[v17];
			//                 while ( v19 != _InterlockedCompareExchange64(&qword_18D6870D0[v17], v19 | (1LL << v18), v19) );
			//               }
			//               v14 = v16;
			//             }
			//           }
			//           goto LABEL_32;
			//         case 7u:
			//           v20 = sub_1802DF920((unsigned int)v13);
			//           v14 = sub_18003D1A0(v20, &v239);
			// LABEL_32:
			//           if ( v14 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext,
			//               v14);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v21 = _InterlockedExchangeAdd64(
			//             (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::get_Current,
			//             0LL);
			//     if ( (v21 & 1) != 0 )
			//     {
			//       v22 = ((unsigned int)v21 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v21 >> 29 )
			//       {
			//         case 1u:
			//           v23 = sub_18003C670((unsigned int)v22);
			//           goto LABEL_48;
			//         case 2u:
			//           v23 = sub_18003C380((unsigned int)v22);
			//           goto LABEL_48;
			//         case 3u:
			//         case 6u:
			//           v23 = sub_1802DFAE0(v21);
			//           goto LABEL_48;
			//         case 4u:
			//           v23 = sub_1802DF920((unsigned int)v22);
			//           goto LABEL_48;
			//         case 5u:
			//           v24 = 8 * v22;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v22) )
			//           {
			//             v23 = *(_QWORD *)(v24 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v25 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v24 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v24 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v23 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v22), v25, 0LL);
			//             if ( !v23 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v22) >> 12) & 0x1FFFFF) >> 6;
			//                 v27 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v22) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v26]);
			//                 do
			//                   v28 = qword_18D6870D0[v26];
			//                 while ( v28 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v28 | (1LL << v27), v28) );
			//               }
			//               v23 = v25;
			//             }
			//           }
			//           goto LABEL_48;
			//         case 7u:
			//           v29 = sub_1802DF920((unsigned int)v22);
			//           v23 = sub_18003D1A0(v29, &v239);
			// LABEL_48:
			//           if ( v23 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::get_Current,
			//               v23);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v30 = _InterlockedExchangeAdd64(
			//             (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::GetEnumerator,
			//             0LL);
			//     if ( (v30 & 1) != 0 )
			//     {
			//       v31 = ((unsigned int)v30 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v30 >> 29 )
			//       {
			//         case 1u:
			//           v32 = sub_18003C670((unsigned int)v31);
			//           goto LABEL_64;
			//         case 2u:
			//           v32 = sub_18003C380((unsigned int)v31);
			//           goto LABEL_64;
			//         case 3u:
			//         case 6u:
			//           v32 = sub_1802DFAE0(v30);
			//           goto LABEL_64;
			//         case 4u:
			//           v32 = sub_1802DF920((unsigned int)v31);
			//           goto LABEL_64;
			//         case 5u:
			//           v33 = 8 * v31;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v31) )
			//           {
			//             v32 = *(_QWORD *)(v33 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v34 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v33 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v33 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v32 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v31), v34, 0LL);
			//             if ( !v32 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v35 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v31) >> 12) & 0x1FFFFF) >> 6;
			//                 v36 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v31) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v35]);
			//                 do
			//                   v37 = qword_18D6870D0[v35];
			//                 while ( v37 != _InterlockedCompareExchange64(&qword_18D6870D0[v35], v37 | (1LL << v36), v37) );
			//               }
			//               v32 = v34;
			//             }
			//           }
			//           goto LABEL_64;
			//         case 7u:
			//           v38 = sub_1802DF920((unsigned int)v31);
			//           v32 = sub_18003D1A0(v38, &v239);
			// LABEL_64:
			//           if ( v32 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::GetEnumerator,
			//               v32);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v39 = _InterlockedExchangeAdd64(
			//             (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count,
			//             0LL);
			//     if ( (v39 & 1) != 0 )
			//     {
			//       v40 = ((unsigned int)v39 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v39 >> 29 )
			//       {
			//         case 1u:
			//           v41 = sub_18003C670((unsigned int)v40);
			//           goto LABEL_80;
			//         case 2u:
			//           v41 = sub_18003C380((unsigned int)v40);
			//           goto LABEL_80;
			//         case 3u:
			//         case 6u:
			//           v41 = sub_1802DFAE0(v39);
			//           goto LABEL_80;
			//         case 4u:
			//           v41 = sub_1802DF920((unsigned int)v40);
			//           goto LABEL_80;
			//         case 5u:
			//           v42 = 8 * v40;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v40) )
			//           {
			//             v41 = *(_QWORD *)(v42 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v43 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v42 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v42 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v41 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v40), v43, 0LL);
			//             if ( !v41 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v44 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v40) >> 12) & 0x1FFFFF) >> 6;
			//                 v45 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v40) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v44]);
			//                 do
			//                   v46 = qword_18D6870D0[v44];
			//                 while ( v46 != _InterlockedCompareExchange64(&qword_18D6870D0[v44], v46 | (1LL << v45), v46) );
			//               }
			//               v41 = v43;
			//             }
			//           }
			//           goto LABEL_80;
			//         case 7u:
			//           v47 = sub_1802DF920((unsigned int)v40);
			//           v41 = sub_18003D1A0(v47, &v239);
			// LABEL_80:
			//           if ( v41 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count,
			//               v41);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v48 = _InterlockedExchangeAdd64(
			//             (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item,
			//             0LL);
			//     if ( (v48 & 1) != 0 )
			//     {
			//       v49 = ((unsigned int)v48 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v48 >> 29 )
			//       {
			//         case 1u:
			//           v50 = sub_18003C670((unsigned int)v49);
			//           goto LABEL_96;
			//         case 2u:
			//           v50 = sub_18003C380((unsigned int)v49);
			//           goto LABEL_96;
			//         case 3u:
			//         case 6u:
			//           v50 = sub_1802DFAE0(v48);
			//           goto LABEL_96;
			//         case 4u:
			//           v50 = sub_1802DF920((unsigned int)v49);
			//           goto LABEL_96;
			//         case 5u:
			//           v51 = 8 * v49;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v49) )
			//           {
			//             v50 = *(_QWORD *)(v51 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v52 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v51 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v51 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v50 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v49), v52, 0LL);
			//             if ( !v50 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v53 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v49) >> 12) & 0x1FFFFF) >> 6;
			//                 v54 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v49) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v53]);
			//                 do
			//                   v55 = qword_18D6870D0[v53];
			//                 while ( v55 != _InterlockedCompareExchange64(&qword_18D6870D0[v53], v55 | (1LL << v54), v55) );
			//               }
			//               v50 = v52;
			//             }
			//           }
			//           goto LABEL_96;
			//         case 7u:
			//           v56 = sub_1802DF920((unsigned int)v49);
			//           v50 = sub_18003D1A0(v56, &v239);
			// LABEL_96:
			//           if ( v50 )
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item,
			//               v50);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     v57 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//     if ( (v57 & 1) != 0 )
			//     {
			//       v58 = ((unsigned int)v57 >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)v57 >> 29 )
			//       {
			//         case 1u:
			//           v59 = sub_18003C670((unsigned int)v58);
			//           goto LABEL_112;
			//         case 2u:
			//           v59 = sub_18003C380((unsigned int)v58);
			//           goto LABEL_112;
			//         case 3u:
			//         case 6u:
			//           v59 = sub_1802DFAE0(v57);
			//           goto LABEL_112;
			//         case 4u:
			//           v59 = sub_1802DF920((unsigned int)v58);
			//           goto LABEL_112;
			//         case 5u:
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v58) )
			//           {
			//             v59 = *(_QWORD *)(qword_18D8F6F98 + 8 * v58);
			//           }
			//           else
			//           {
			//             v60 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v58 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v58));
			//             v59 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v58), v60, 0LL);
			//             if ( !v59 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v61 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v58) >> 12) & 0x1FFFFF) >> 6;
			//                 v62 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v58) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v61]);
			//                 do
			//                   v63 = qword_18D6870D0[v61];
			//                 while ( v63 != _InterlockedCompareExchange64(&qword_18D6870D0[v61], v63 | (1LL << v62), v63) );
			//               }
			//               v59 = v60;
			//             }
			//           }
			//           goto LABEL_112;
			//         case 7u:
			//           v64 = sub_1802DF920((unsigned int)v58);
			//           v59 = sub_18003D1A0(v64, &v239);
			// LABEL_112:
			//           if ( v59 )
			//             _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v59);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     byte_18D8EDBE1 = 1;
			//   }
			//   v229 = 0LL;
			//   v230 = 0LL;
			//   topWriteBack = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1950, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1950, 0LL);
			//     if ( !Patch )
			//       goto LABEL_390;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     m_hgWaterInteractiveSetting = (Object_1 *)v2.fields.m_hgWaterInteractiveSetting;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v65);
			//     if ( !UnityEngine::Object::op_Equality(m_hgWaterInteractiveSetting, 0LL, 0LL) )
			//     {
			//       m_RippleDataManager = v2.fields.m_RippleDataManager;
			//       if ( !m_RippleDataManager )
			//         goto LABEL_390;
			//       if ( !byte_18D8EDBE6 )
			//       {
			//         v70 = _InterlockedExchangeAdd64(
			//                 (volatile signed __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Clear,
			//                 0LL);
			//         if ( (v70 & 1) != 0 )
			//         {
			//           v71 = ((unsigned int)v70 >> 1) & 0xFFFFFFF;
			//           switch ( (unsigned int)v70 >> 29 )
			//           {
			//             case 1u:
			//               v72 = sub_18003C670((unsigned int)v71);
			//               goto LABEL_135;
			//             case 2u:
			//               v72 = sub_18003C380((unsigned int)v71);
			//               goto LABEL_135;
			//             case 3u:
			//             case 6u:
			//               v72 = sub_1802DFAE0(v70);
			//               goto LABEL_135;
			//             case 4u:
			//               v72 = sub_1802DF920((unsigned int)v71);
			//               goto LABEL_135;
			//             case 5u:
			//               v73 = 8 * v71;
			//               if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v71) )
			//               {
			//                 v72 = *(_QWORD *)(v73 + qword_18D8F6F98);
			//               }
			//               else
			//               {
			//                 v74 = il2cpp_string_new_len(
			//                         qword_18D8E5198
			//                       + *(int *)(v73 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                       + *(int *)(qword_18D8E51A0 + 16),
			//                         *(unsigned int *)(v73 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                 v72 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v71), v74, 0LL);
			//                 if ( !v72 )
			//                 {
			//                   if ( dword_18D8E43F8 )
			//                   {
			//                     v75 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v71) >> 12) & 0x1FFFFF) >> 6;
			//                     v76 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v71) >> 12) & 0x3F;
			//                     _m_prefetchw(&qword_18D6870D0[v75]);
			//                     do
			//                       v77 = qword_18D6870D0[v75];
			//                     while ( v77 != _InterlockedCompareExchange64(&qword_18D6870D0[v75], v77 | (1LL << v76), v77) );
			//                   }
			//                   v72 = v74;
			//                 }
			//               }
			//               goto LABEL_135;
			//             case 7u:
			//               v78 = sub_1802DF920((unsigned int)v71);
			//               v72 = sub_18003D1A0(v78, &v239);
			// LABEL_135:
			//               if ( v72 )
			//                 _InterlockedExchange64(
			//                   (volatile __int64 *)&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Clear,
			//                   v72);
			//               break;
			//             default:
			//               break;
			//           }
			//         }
			//         byte_18D8EDBE6 = 1;
			//       }
			//       if ( IFix::WrappersManagerImpl::IsPatched(1951, 0LL) )
			//       {
			//         v80 = IFix::WrappersManagerImpl::GetPatch(1951, 0LL);
			//         if ( !v80 )
			//           goto LABEL_390;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//           (ILFixDynamicMethodWrapper_37 *)v80,
			//           (Object *)m_RippleDataManager,
			//           0LL);
			//       }
			//       else
			//       {
			//         list = (signed __int64)m_RippleDataManager.fields._list;
			//         if ( !list )
			//           goto LABEL_390;
			//         ++*(_DWORD *)(list + 28);
			//         *(_DWORD *)(list + 24) = 0;
			//         m_RippleDataManager.fields._minIndex = -1;
			//       }
			//       v81 = 0.0;
			//       v240 = 0.0;
			//       v82 = 0.0;
			//       v232 = 0.0;
			//       v83 = 0.0;
			//       LODWORD(v239) = 0;
			//       v84 = *(_OWORD *)&v2.fields.m_centerRippleData.positionXZ.x;
			//       *(_OWORD *)&v2.fields.m_lastCenterRippleData.positionXZ.x = v84;
			//       v2.fields.m_lastCenterRippleData.priority = v2.fields.m_centerRippleData.priority;
			//       v2.fields.m_isRippleInputEmpty = 0;
			//       m_rawRippleDataList = (Value *)v2.fields.m_rawRippleDataList;
			//       if ( !m_rawRippleDataList )
			//         goto LABEL_390;
			//       if ( m_rawRippleDataList[2].Type < 1 )
			//       {
			//         priority = v2.fields.m_centerRippleData.priority;
			//         *(_OWORD *)&v2.fields.m_centerRippleData.positionXZ.x = v84;
			//         v2.fields.m_centerRippleData.priority = priority;
			//       }
			//       else
			//       {
			//         v86 = v2.fields.m_rawRippleDataList;
			//         memset(&call.evaluationStackBase, 0, 32);
			//         call.argumentBase = m_rawRippleDataList;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v87 = (((unsigned __int64)&call >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6870D0[v87]);
			//           do
			//           {
			//             list = qword_18D6870D0[v87] | (1LL << (((unsigned __int64)&call >> 12) & 0x3F));
			//             v88 = qword_18D6870D0[v87];
			//           }
			//           while ( v88 != _InterlockedCompareExchange64(&qword_18D6870D0[v87], list, v88) );
			//         }
			//         LODWORD(call.evaluationStackBase) = 0;
			//         HIDWORD(call.evaluationStackBase) = v86.fields._version;
			//         memset(&call.managedStack, 0, 20);
			//         v229 = *(_OWORD *)&call.argumentBase;
			//         v230 = 0LL;
			//         topWriteBack = call.topWriteBack;
			//         v227.m128_u64[0] = 0LL;
			//         v227.m128_u64[1] = (unsigned __int64)&v229;
			//         try
			//         {
			//           v92 = HIDWORD(v229);
			//           v90 = DWORD2(v229);
			//           v93 = v229;
			//           while ( 1 )
			//           {
			//             if ( !(_QWORD)v229 )
			//               sub_1802DC2C8(list, 0LL);
			//             if ( HIDWORD(v229) != *(_DWORD *)(v229 + 28) || (unsigned int)v90 >= *(_DWORD *)(v229 + 24) )
			//               break;
			//             v89 = *(_QWORD *)(v229 + 16);
			//             if ( !v89 )
			//               sub_1802DC2C8(0LL, v229);
			//             if ( (unsigned int)v90 >= *(_DWORD *)(v89 + 24) )
			//               sub_180070260(v89, v229, v90, HIDWORD(v229));
			//             v230 = *(__m128 *)(v89 + 20LL * (int)v90 + 32);
			//             list = *(unsigned int *)(v89 + 20LL * (int)v90 + 48);
			//             LODWORD(topWriteBack) = list;
			//             v90 = (unsigned int)(v90 + 1);
			//             DWORD2(v229) = v90;
			//             v81 = (float)(*(float *)&list * v230.m128_f32[0]) + v81;
			//             v82 = (float)(*(float *)&list * _mm_shuffle_ps(v230, v230, 85).m128_f32[0]) + v82;
			//             v240 = v81;
			//             v232 = v82;
			//             v83 = v83 + *(float *)&list;
			//             *(float *)&v239 = v83;
			//           }
			//           klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//           {
			//             sub_18003C700(klass);
			//             v92 = HIDWORD(v229);
			//             v93 = v229;
			//           }
			//           if ( !v93 )
			//             sub_1802DC2C8(klass, 0LL);
			//           if ( v92 != *(_DWORD *)(v93 + 28) )
			//             System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//           DWORD2(v229) = *(_DWORD *)(v93 + 24) + 1;
			//           v230 = 0LL;
			//           LODWORD(topWriteBack) = 0;
			//         }
			//         catch ( Il2CppExceptionWrapper *v236 )
			//         {
			//           *(Il2CppExceptionWrapper *)v227.m128_f32 = (Il2CppExceptionWrapper)v236.ex;
			//           if ( v227.m128_u64[0] )
			//             sub_18000F780(v227.m128_u64[0]);
			//           v2 = this;
			//           v83 = *(float *)&v239;
			//           v81 = v240;
			//           v82 = v232;
			//         }
			//         v2.fields.m_centerRippleData.positionXZ.x = v81 / v83;
			//         v2.fields.m_centerRippleData.positionXZ.y = v82 / v83;
			//         UnityEngine::Time::get_frameCount(0LL);
			//         v94 = Beyond::DampingMath::sinf();
			//         v95 = HG::Rendering::Runtime::HGWaterManager::Frac(v2, *(float *)&v94 * 43758.547, 0LL) - 0.5;
			//         v96 = Beyond::DampingMath::sinf();
			//         v97 = v2.fields.m_centerRippleData.positionXZ.y
			//             + (float)((float)(HG::Rendering::Runtime::HGWaterManager::Frac(v2, *(float *)&v96 * 43758.547, 0LL) - 0.5)
			//                     * 0.029999999);
			//         v2.fields.m_centerRippleData.positionXZ.x = (float)(v95 * 0.029999999)
			//                                                    + v2.fields.m_centerRippleData.positionXZ.x;
			//         v2.fields.m_centerRippleData.positionXZ.y = v97;
			//         v233.fields.m_centerRippleData.size = 0.0;
			//       }
			//       v99 = (Value *)v2.fields.m_rawRippleDataList;
			//       if ( !v99 )
			//         goto LABEL_390;
			//       memset(&call.evaluationStackBase, 0, 32);
			//       call.argumentBase = v99;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v67 = (((unsigned __int64)&call >> 12) & 0x1FFFFF) >> 6;
			//         v79 = ((unsigned __int64)&call >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v67]);
			//         do
			//         {
			//           v100 = qword_18D6870D0[v67] | (1LL << v79);
			//           v101 = qword_18D6870D0[v67];
			//         }
			//         while ( v101 != _InterlockedCompareExchange64(&qword_18D6870D0[v67], v100, v101) );
			//       }
			//       LODWORD(call.evaluationStackBase) = 0;
			//       HIDWORD(call.evaluationStackBase) = v99[2].Value1;
			//       memset(&call.managedStack, 0, 20);
			//       v229 = *(_OWORD *)&call.argumentBase;
			//       v230 = 0LL;
			//       topWriteBack = call.topWriteBack;
			//       v227.m128_u64[0] = 0LL;
			//       v227.m128_u64[1] = (unsigned __int64)&v229;
			//       try
			//       {
			//         while ( 1 )
			//         {
			//           v102 = v229;
			//           do
			//           {
			//             if ( !v102 )
			//               sub_1802DC2C8(
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext,
			//                 v67);
			//             if ( HIDWORD(v229) != *(_DWORD *)(v102 + 28) || DWORD2(v229) >= *(_DWORD *)(v102 + 24) )
			//             {
			//               list = (signed __int64)MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext.klass;
			//               if ( (*(_BYTE *)(list + 312) & 1) == 0 )
			//               {
			//                 sub_18003C700(list);
			//                 v102 = v229;
			//               }
			//               if ( !v102 )
			//                 sub_1802DC2C8(list, v67);
			//               if ( HIDWORD(v229) != *(_DWORD *)(v102 + 28) )
			//                 System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//               DWORD2(v229) = *(_DWORD *)(v102 + 24) + 1;
			//               v230 = 0LL;
			//               LODWORD(topWriteBack) = 0;
			//               goto LABEL_415;
			//             }
			//             v103 = *(_QWORD *)(v102 + 16);
			//             if ( !v103 )
			//               sub_1802DC2C8(0LL, v67);
			//             if ( DWORD2(v229) >= *(_DWORD *)(v103 + 24) )
			//               sub_180070260(v103, v67, v79, v99);
			//             v104 = *(__m128 *)(v103 + 20LL * SDWORD2(v229) + 32);
			//             v230 = v104;
			//             v105 = *(_DWORD *)(v103 + 20LL * SDWORD2(v229) + 48);
			//             LODWORD(topWriteBack) = v105;
			//             ++DWORD2(v229);
			//             LODWORD(v106) = _mm_shuffle_ps(v104, v104, 85).m128_u32[0];
			//             x = v2.fields.m_centerRippleData.positionXZ.x;
			//             y = v2.fields.m_centerRippleData.positionXZ.y;
			//             if ( !byte_18D8E3AB3 )
			//             {
			//               v109 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::System::Math, 0LL);
			//               if ( (v109 & 1) != 0 )
			//               {
			//                 v110 = ((unsigned int)v109 >> 1) & 0xFFFFFFF;
			//                 switch ( (unsigned int)v109 >> 29 )
			//                 {
			//                   case 1u:
			//                     v111 = sub_18003C670((unsigned int)v110);
			//                     goto LABEL_190;
			//                   case 2u:
			//                     v111 = sub_18003C380((unsigned int)v110);
			//                     goto LABEL_190;
			//                   case 3u:
			//                   case 6u:
			//                     v111 = sub_1802DFAE0(v109);
			//                     goto LABEL_190;
			//                   case 4u:
			//                     v111 = sub_1802DF920((unsigned int)v110);
			//                     goto LABEL_190;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v110) )
			//                     {
			//                       v111 = *(_QWORD *)(qword_18D8F6F98 + 8 * v110);
			//                     }
			//                     else
			//                     {
			//                       v99 = (Value *)il2cpp_string_new_len(
			//                                        qword_18D8E5198
			//                                      + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v110 + 4)
			//                                      + *(int *)(qword_18D8E51A0 + 16),
			//                                        *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v110));
			//                       v111 = _InterlockedCompareExchange64(
			//                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v110),
			//                                (signed __int64)v99,
			//                                0LL);
			//                       if ( !v111 )
			//                       {
			//                         v79 = qword_18D8F6F98 + 8 * v110;
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v112 = (v79 >> 12) & 0x1FFFFF;
			//                           v67 = (unsigned __int64)v112 >> 6;
			//                           v79 = v112 & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v67]);
			//                           do
			//                             v113 = qword_18D6870D0[v67];
			//                           while ( v113 != _InterlockedCompareExchange64(
			//                                             &qword_18D6870D0[v67],
			//                                             v113 | (1LL << v79),
			//                                             v113) );
			//                         }
			//                         v111 = (__int64)v99;
			//                       }
			//                     }
			//                     goto LABEL_190;
			//                   case 7u:
			//                     v114 = sub_1802DF920((unsigned int)v110);
			//                     v111 = sub_18003D1A0(v114, &v239);
			// LABEL_190:
			//                     if ( v111 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::System::Math, v111);
			//                     break;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8E3AB3 = 1;
			//               v102 = v229;
			//             }
			//             v115 = v106 - y;
			//             v116 = TypeInfo::System::Math;
			//             if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::System::Math, v67);
			//               v102 = v229;
			//             }
			//             v117 = 0LL;
			//             v117.m128d_f64[0] = (float)((float)(v115 * v115)
			//                                       + (float)((float)(v104.m128_f32[0] - x) * (float)(v104.m128_f32[0] - x)));
			//             if ( v117.m128d_f64[0] < 0.0 )
			//               v118 = sub_1801C22C0(v116, v67, v79);
			//             else
			//               *(_QWORD *)&v118 = *(_OWORD *)&_mm_sqrt_pd(v117);
			//             v119 = v118;
			//           }
			//           while ( v119 > 32.0 );
			//           v120 = v2.fields.m_RippleDataManager;
			//           if ( !v120 )
			//             sub_1802DC2C8(0LL, v67);
			//           *(__m128 *)&v234.argumentBase = v104;
			//           LODWORD(v234.managedStack) = v105;
			//           HG::Rendering::Runtime::RippleDataManager::Add(v120, (InputRippleData *)&v234, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v237 )
			//       {
			//         v67 = (unsigned __int64)&v226;
			//         *(Il2CppExceptionWrapper *)v227.m128_f32 = (Il2CppExceptionWrapper)v237.ex;
			//         list = v227.m128_u64[0];
			//         if ( v227.m128_u64[0] )
			//           sub_18000F780(v227.m128_u64[0]);
			//         v2 = this;
			//       }
			// LABEL_415:
			//       v121 = v2.fields.m_RippleDataManager;
			//       if ( !v121 )
			//         goto LABEL_390;
			//       list = (signed __int64)v121.fields._list;
			//       if ( !list )
			//         goto LABEL_390;
			//       if ( *(int *)(list + 24) < 1 )
			//         v2.fields.m_isRippleInputEmpty = 1;
			//       HG::Rendering::Runtime::RippleDataManager::UpdateWaterState(v121, 0LL);
			//       v2.fields.m_centerRippleData.size = 0.0;
			//       x_low = (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.x);
			//       y_low = (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.y);
			//       if ( byte_18D8EDC37 )
			//       {
			//         v131 = off_18A2C5600;
			//       }
			//       else
			//       {
			//         v123 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//         if ( (v123 & 1) != 0 )
			//         {
			//           v127 = ((unsigned int)v123 >> 1) & 0xFFFFFFF;
			//           switch ( (unsigned int)v123 >> 29 )
			//           {
			//             case 1u:
			//               v128 = sub_18003C670((unsigned int)v127);
			//               goto LABEL_216;
			//             case 2u:
			//               v128 = sub_18003C380((unsigned int)v127);
			//               goto LABEL_216;
			//             case 3u:
			//             case 6u:
			//               v129 = ((unsigned int)v123 >> 1) & 0xFFFFFFF;
			//               v123 = (unsigned int)v123 >> 29;
			//               if ( (_DWORD)v123 )
			//               {
			//                 if ( (_DWORD)v123 == 3 )
			//                 {
			//                   v122 = (void (__fastcall __noreturn **)())sub_180039480(v129);
			//                   goto LABEL_227;
			//                 }
			//                 if ( (_DWORD)v123 == 6 )
			//                 {
			//                   v130 = sub_1802DF9C0(v129);
			//                   v122 = (void (__fastcall __noreturn **)())sub_18005F4B0(v130, 0LL);
			//                   goto LABEL_227;
			//                 }
			//               }
			//               else if ( v129 == 1 )
			//               {
			//                 v131 = off_18A2C5600;
			//                 v122 = off_18A2C5600;
			//                 goto LABEL_245;
			//               }
			//               v122 = 0LL;
			// LABEL_227:
			//               v131 = off_18A2C5600;
			// LABEL_245:
			//               if ( !v122 )
			//                 goto LABEL_248;
			//               v122 = (void (__fastcall __noreturn **)())_InterlockedExchange64(
			//                                                           (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                                                           (__int64)v122);
			//               byte_18D8EDC37 = 1;
			//               break;
			//             case 4u:
			//               v128 = sub_1802DF920((unsigned int)v127);
			// LABEL_216:
			//               v122 = (void (__fastcall __noreturn **)())v128;
			//               goto LABEL_244;
			//             case 5u:
			//               v123 = 8 * v127;
			//               if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v127) )
			//               {
			//                 v122 = *(void (__fastcall __noreturn ***)())(v123 + qword_18D8F6F98);
			//               }
			//               else
			//               {
			//                 v124 = il2cpp_string_new_len(
			//                          qword_18D8E5198
			//                        + *(int *)(v123 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                        + *(int *)(qword_18D8E51A0 + 16),
			//                          *(unsigned int *)(v123 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                 v122 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v127),
			//                                                             v124,
			//                                                             0LL);
			//                 if ( !v122 )
			//                 {
			//                   if ( dword_18D8E43F8 )
			//                   {
			//                     v132 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v127) >> 12) & 0x1FFFFF) >> 6;
			//                     v123 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v127) >> 12) & 0x3F;
			//                     _m_prefetchw(&qword_18D6870D0[v132]);
			//                     do
			//                       v133 = qword_18D6870D0[v132];
			//                     while ( v133 != _InterlockedCompareExchange64(&qword_18D6870D0[v132], v133 | (1LL << v123), v133) );
			//                   }
			//                   v122 = (void (__fastcall __noreturn **)())v124;
			//                 }
			//               }
			//               goto LABEL_244;
			//             case 7u:
			//               v134 = sub_1802DF920((unsigned int)v127);
			//               v135 = *(_QWORD *)(v134 + 16);
			//               v136 = (v134 - *(_QWORD *)(v135 + 128)) >> 5;
			//               if ( *(_BYTE *)(v135 + 42) == 21 )
			//               {
			//                 v137 = *(_QWORD ***)(v135 + 96);
			//                 if ( *v137 )
			//                 {
			//                   v138 = **v137 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                   v135 = sub_180039550(v138 / 92 + v138);
			//                 }
			//                 else
			//                 {
			//                   v135 = 0LL;
			//                 }
			//               }
			//               v235 = v136 + *(_DWORD *)(*(_QWORD *)(v135 + 104) + 32LL);
			//               v139 = sub_1801B8ECC(
			//                        (unsigned int)&v235,
			//                        (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                        *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                        12,
			//                        (__int64)sub_1802C7760);
			//               if ( !v139 || (v140 = *(unsigned int *)(v139 + 8), (_DWORD)v140 == -1) )
			//                 v122 = 0LL;
			//               else
			//                 v122 = (void (__fastcall __noreturn **)())(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v140);
			// LABEL_244:
			//               v131 = off_18A2C5600;
			//               goto LABEL_245;
			//             default:
			//               goto LABEL_247;
			//           }
			//         }
			//         else
			//         {
			// LABEL_247:
			//           v131 = off_18A2C5600;
			// LABEL_248:
			//           byte_18D8EDC37 = 1;
			//         }
			//       }
			//       list = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v122);
			//         list = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       v67 = **(_QWORD **)(list + 184);
			//       if ( !v67 )
			// LABEL_390:
			//         sub_1802DC2C8(list, v67);
			//       if ( *(int *)(v67 + 24) > 1960 )
			//       {
			//         if ( !*(_DWORD *)(list + 224) )
			//         {
			//           il2cpp_runtime_class_init_0(list, v67);
			//           list = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v67 = **(_QWORD **)(list + 184);
			//         if ( !v67 )
			//           goto LABEL_390;
			//         if ( *(_DWORD *)(v67 + 24) <= 0x7A8u )
			//           goto LABEL_407;
			//         if ( *(_QWORD *)(v67 + 15712) )
			//         {
			//           if ( !byte_18D919D50 )
			//           {
			//             v123 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v123 & 1) != 0 )
			//             {
			//               v141 = ((unsigned int)v123 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v123 >> 29 )
			//               {
			//                 case 1u:
			//                   v67 = sub_18003C670((unsigned int)v141);
			//                   goto LABEL_287;
			//                 case 2u:
			//                   v67 = sub_18003C380((unsigned int)v141);
			//                   goto LABEL_287;
			//                 case 3u:
			//                 case 6u:
			//                   v142 = ((unsigned int)v123 >> 1) & 0xFFFFFFF;
			//                   v123 = (unsigned int)v123 >> 29;
			//                   if ( (_DWORD)v123 )
			//                   {
			//                     if ( (_DWORD)v123 == 3 )
			//                     {
			//                       v67 = sub_180039480(v142);
			//                       goto LABEL_287;
			//                     }
			//                     if ( (_DWORD)v123 == 6 )
			//                     {
			//                       v143 = sub_1802DF9C0(v142);
			//                       v67 = sub_18005F4B0(v143, 0LL);
			//                       goto LABEL_287;
			//                     }
			//                   }
			//                   else if ( v142 == 1 )
			//                   {
			//                     v67 = (unsigned __int64)off_18A2C5600;
			//                     goto LABEL_287;
			//                   }
			// LABEL_286:
			//                   v67 = 0LL;
			// LABEL_287:
			//                   if ( v67 )
			//                     v67 = _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v67);
			//                   break;
			//                 case 4u:
			//                   v67 = sub_1802DF920((unsigned int)v141);
			//                   goto LABEL_287;
			//                 case 5u:
			//                   v123 = 8 * v141;
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v141) )
			//                   {
			//                     v67 = *(_QWORD *)(v123 + qword_18D8F6F98);
			//                   }
			//                   else
			//                   {
			//                     v124 = il2cpp_string_new_len(
			//                              qword_18D8E5198
			//                            + *(int *)(v123 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                            + *(int *)(qword_18D8E51A0 + 16),
			//                              *(unsigned int *)(v123 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                     v67 = _InterlockedCompareExchange64(
			//                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v141),
			//                             v124,
			//                             0LL);
			//                     if ( !v67 )
			//                     {
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v144 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v141) >> 12) & 0x1FFFFF) >> 6;
			//                         v123 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v141) >> 12) & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v144]);
			//                         do
			//                           v145 = qword_18D6870D0[v144];
			//                         while ( v145 != _InterlockedCompareExchange64(
			//                                           &qword_18D6870D0[v144],
			//                                           v145 | (1LL << v123),
			//                                           v145) );
			//                       }
			//                       v67 = v124;
			//                     }
			//                   }
			//                   goto LABEL_287;
			//                 case 7u:
			//                   v146 = sub_1802DF920((unsigned int)v141);
			//                   v147 = *(_QWORD *)(v146 + 16);
			//                   v148 = (v146 - *(_QWORD *)(v147 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v147 + 42) == 21 )
			//                   {
			//                     v149 = *(_QWORD ***)(v147 + 96);
			//                     if ( *v149 )
			//                     {
			//                       v150 = **v149 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                       v147 = sub_180039550(v150 / 92 + v150);
			//                     }
			//                     else
			//                     {
			//                       v147 = 0LL;
			//                     }
			//                   }
			//                   LODWORD(v234.argumentBase) = v148 + *(_DWORD *)(*(_QWORD *)(v147 + 104) + 32LL);
			//                   v151 = sub_1801B8ECC(
			//                            (unsigned int)&v234,
			//                            (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                            *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                            12,
			//                            (__int64)sub_1802C7760);
			//                   if ( !v151 )
			//                     goto LABEL_286;
			//                   v152 = *(unsigned int *)(v151 + 8);
			//                   if ( (_DWORD)v152 == -1 )
			//                     goto LABEL_286;
			//                   v67 = qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v152;
			//                   goto LABEL_287;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D919D50 = 1;
			//             list = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           if ( !*(_DWORD *)(list + 224) )
			//           {
			//             il2cpp_runtime_class_init_0(list, v67);
			//             list = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           list = **(_QWORD **)(list + 184);
			//           if ( !list )
			//             goto LABEL_390;
			//           if ( *(_DWORD *)(list + 24) > 0x7A8u )
			//           {
			//             v153 = *(_QWORD *)(list + 15712);
			//             v239 = v153;
			//             if ( !v153 )
			//               goto LABEL_390;
			//             if ( !byte_18D919ACF )
			//             {
			//               v154 = _InterlockedExchangeAdd64(
			//                        (volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>,
			//                        0LL);
			//               if ( (v154 & 1) != 0 )
			//               {
			//                 v155 = (v154 >> 1) & 0xFFFFFFF;
			//                 switch ( v154 >> 29 )
			//                 {
			//                   case 1u:
			//                     v156 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v155);
			//                     goto LABEL_323;
			//                   case 2u:
			//                     v156 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v155);
			//                     goto LABEL_323;
			//                   case 3u:
			//                   case 6u:
			//                     v157 = (v154 >> 1) & 0xFFFFFFF;
			//                     v158 = v154 >> 29;
			//                     if ( v158 )
			//                     {
			//                       if ( v158 == 3 )
			//                       {
			//                         v156 = (void (__fastcall __noreturn **)())sub_180039480(v157);
			//                         goto LABEL_323;
			//                       }
			//                       if ( v158 == 6 )
			//                       {
			//                         v159 = sub_1802DF9C0(v157);
			//                         v156 = (void (__fastcall __noreturn **)())sub_18005F4B0(v159, 0LL);
			//                         goto LABEL_323;
			//                       }
			//                     }
			//                     else if ( v157 == 1 )
			//                     {
			//                       v156 = off_18A2C5600;
			//                       goto LABEL_323;
			//                     }
			// LABEL_322:
			//                     v156 = 0LL;
			// LABEL_323:
			//                     if ( v156 )
			//                       _InterlockedExchange64(
			//                         (volatile __int64 *)&MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>,
			//                         (__int64)v156);
			//                     break;
			//                   case 4u:
			//                     v156 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v155);
			//                     goto LABEL_323;
			//                   case 5u:
			//                     v160 = 8 * v155;
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v155) )
			//                     {
			//                       v156 = *(void (__fastcall __noreturn ***)())(v160 + qword_18D8F6F98);
			//                     }
			//                     else
			//                     {
			//                       v161 = il2cpp_string_new_len(
			//                                qword_18D8E5198
			//                              + *(int *)(v160 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                              + *(int *)(qword_18D8E51A0 + 16),
			//                                *(unsigned int *)(v160 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                       v156 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                   (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v155),
			//                                                                   v161,
			//                                                                   0LL);
			//                       if ( !v156 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v162 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v155) >> 12) & 0x1FFFFF) >> 6;
			//                           v163 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v155) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v162]);
			//                           do
			//                             v164 = qword_18D6870D0[v162];
			//                           while ( v164 != _InterlockedCompareExchange64(
			//                                             &qword_18D6870D0[v162],
			//                                             v164 | (1LL << v163),
			//                                             v164) );
			//                         }
			//                         v156 = (void (__fastcall __noreturn **)())v161;
			//                       }
			//                     }
			//                     goto LABEL_323;
			//                   case 7u:
			//                     v165 = sub_1802DF920((unsigned int)v155);
			//                     v166 = *(_QWORD *)(v165 + 16);
			//                     v167 = (v165 - *(_QWORD *)(v166 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v166 + 42) == 21 )
			//                     {
			//                       v168 = *(_QWORD ***)(v166 + 96);
			//                       if ( *v168 )
			//                       {
			//                         v169 = **v168 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                         v166 = sub_180039550(v169 / 92 + v169);
			//                       }
			//                       else
			//                       {
			//                         v166 = 0LL;
			//                       }
			//                     }
			//                     v227.m128_i32[0] = v167 + *(_DWORD *)(*(_QWORD *)(v166 + 104) + 32LL);
			//                     v170 = sub_1801B8ECC(
			//                              (unsigned int)&v227,
			//                              (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                              *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                              12,
			//                              (__int64)sub_1802C7760);
			//                     if ( !v170 )
			//                       goto LABEL_322;
			//                     v171 = *(unsigned int *)(v170 + 8);
			//                     if ( (_DWORD)v171 == -1 )
			//                       goto LABEL_322;
			//                     v156 = (void (__fastcall __noreturn **)())(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v171);
			//                     goto LABEL_323;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               v172 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Vector2, 0LL);
			//               if ( (v172 & 1) != 0 )
			//               {
			//                 v173 = (v172 >> 1) & 0xFFFFFFF;
			//                 switch ( v172 >> 29 )
			//                 {
			//                   case 1u:
			//                     v131 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v173);
			//                     goto LABEL_336;
			//                   case 2u:
			//                     v131 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v173);
			//                     goto LABEL_336;
			//                   case 3u:
			//                   case 6u:
			//                     v174 = (v172 >> 1) & 0xFFFFFFF;
			//                     v175 = v172 >> 29;
			//                     if ( v175 )
			//                     {
			//                       if ( v175 == 3 )
			//                       {
			//                         v131 = (void (__fastcall __noreturn **)())sub_180039480(v174);
			//                         goto LABEL_336;
			//                       }
			//                       if ( v175 == 6 )
			//                       {
			//                         v176 = sub_1802DF9C0(v174);
			//                         v131 = (void (__fastcall __noreturn **)())sub_18005F4B0(v176, 0LL);
			//                         goto LABEL_336;
			//                       }
			//                     }
			//                     else if ( v174 == 1 )
			//                     {
			//                       goto LABEL_336;
			//                     }
			// LABEL_335:
			//                     v131 = 0LL;
			// LABEL_336:
			//                     if ( v131 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Vector2, (__int64)v131);
			//                     break;
			//                   case 4u:
			//                     v131 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v173);
			//                     goto LABEL_336;
			//                   case 5u:
			//                     v188 = 8 * v173;
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v173) )
			//                     {
			//                       v131 = *(void (__fastcall __noreturn ***)())(v188 + qword_18D8F6F98);
			//                     }
			//                     else
			//                     {
			//                       v189 = il2cpp_string_new_len(
			//                                qword_18D8E5198
			//                              + *(int *)(v188 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                              + *(int *)(qword_18D8E51A0 + 16),
			//                                *(unsigned int *)(v188 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                       v131 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                   (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v173),
			//                                                                   v189,
			//                                                                   0LL);
			//                       if ( !v131 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v190 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v173) >> 12) & 0x1FFFFF) >> 6;
			//                           v191 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v173) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v190]);
			//                           do
			//                             v192 = qword_18D6870D0[v190];
			//                           while ( v192 != _InterlockedCompareExchange64(
			//                                             &qword_18D6870D0[v190],
			//                                             v192 | (1LL << v191),
			//                                             v192) );
			//                         }
			//                         v131 = (void (__fastcall __noreturn **)())v189;
			//                       }
			//                     }
			//                     goto LABEL_336;
			//                   case 7u:
			//                     v193 = sub_1802DF920((unsigned int)v173);
			//                     v194 = *(_QWORD *)(v193 + 16);
			//                     v195 = (v193 - *(_QWORD *)(v194 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v194 + 42) == 21 )
			//                     {
			//                       v196 = *(_QWORD ***)(v194 + 96);
			//                       if ( *v196 )
			//                       {
			//                         v197 = **v196 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                         v194 = sub_180039550(v197 / 92 + v197);
			//                       }
			//                       else
			//                       {
			//                         v194 = 0LL;
			//                       }
			//                     }
			//                     v227.m128_i32[0] = v195 + *(_DWORD *)(*(_QWORD *)(v194 + 104) + 32LL);
			//                     v198 = sub_1801B8ECC(
			//                              (unsigned int)&v227,
			//                              (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                              *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                              12,
			//                              (__int64)sub_1802C7760);
			//                     if ( !v198 )
			//                       goto LABEL_335;
			//                     v199 = *(unsigned int *)(v198 + 8);
			//                     if ( (_DWORD)v199 == -1 )
			//                       goto LABEL_335;
			//                     v131 = (void (__fastcall __noreturn **)())(v199 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_336;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D919ACF = 1;
			//               v153 = v239;
			//             }
			//             memset(&call, 0, sizeof(call));
			//             call = *IFix::Core::Call::Begin(&v234, 0LL);
			//             if ( *(_QWORD *)(v153 + 32) )
			//               IFix::Core::Call::PushObject(&call, *(Object **)(v153 + 32), 0LL);
			//             IFix::Core::Call::PushObject(&call, (Object *)v2, 0LL);
			//             v239 = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//             v178 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Vector2, &v239, v177);
			//             IFix::Core::Call::PushValueType(&call, v178, 0LL);
			//             if ( !call.currentTop
			//               || (call.currentTop.Value1 = 0, !call.currentTop)
			//               || (call.currentTop.Type = 2,
			//                   v181 = call.currentTop == (Value *)-12LL,
			//                   v182 = call.currentTop + 1,
			//                   ++call.currentTop,
			//                   v181)
			//               || (v182.Value1 = 0, !call.currentTop) )
			//             {
			//               sub_1802DC2C8(v180, v179);
			//             }
			//             call.currentTop.Type = 2;
			//             ++call.currentTop;
			//             rgctx_data = *(VirtualMachine **)(v153 + 16);
			//             if ( !rgctx_data )
			//               goto LABEL_405;
			//             IFix::Core::VirtualMachine::Execute(
			//               rgctx_data,
			//               *(_DWORD *)(v153 + 24),
			//               &call,
			//               (*(_QWORD *)(v153 + 32) != 0LL) + 4,
			//               0,
			//               0LL);
			//             v184 = MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>;
			//             if ( !MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>.rgctx_data )
			//               sub_180041F40(MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>);
			//             Object = IFix::Core::Call::GetObject(&call, 0, 0LL);
			//             rgctx_data = (VirtualMachine *)v184.rgctx_data;
			//             v186 = rgctx_data.klass;
			//             if ( ((__int64)rgctx_data.klass.vtable.Equals.methodPtr & 1) == 0 )
			//               sub_18003C700(rgctx_data.klass);
			//             if ( !Object )
			// LABEL_405:
			//               sub_1802DC2C8(rgctx_data, v179);
			//             if ( Object.klass._0.element_class != v186._0.element_class )
			//               sub_1802DC21C(Object, v186);
			//             v187 = (__m128)Object[1];
			//             goto LABEL_369;
			//           }
			// LABEL_407:
			//           sub_180070260(list, v67, v123, v124);
			//         }
			//       }
			//       v200 = (__m128)v227.m128_u64[0];
			//       v200.m128_f32[0] = x_low.m128_f32[0];
			//       v201 = _mm_shuffle_ps(v200, v200, 225);
			//       v201.m128_f32[0] = y_low.m128_f32[0];
			//       v187 = _mm_shuffle_ps(v201, v201, 225);
			//       v227 = v187;
			// LABEL_369:
			//       *(__m128 *)v2.fields.waterRippleData.m_Buffer = v187;
			//       v202 = (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.x);
			//       v203 = (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.y);
			//       v202.m128_f32[0] = (float)((float)(v202.m128_f32[0] - v2.fields.m_lastCenterRippleData.positionXZ.x) * 0.03125)
			//                        * 0.5;
			//       v203.m128_f32[0] = (float)((float)(v203.m128_f32[0] - v2.fields.m_lastCenterRippleData.positionXZ.y) * 0.03125)
			//                        * 0.5;
			//       *(Vector4 *)&v2.fields.waterRippleData.m_Buffer[16] = *HG::Rendering::Runtime::HGWaterManager::ToVector4(
			//                                                                 (Vector4 *)&v227,
			//                                                                 v2,
			//                                                                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v202, v203),
			//                                                                 32.0,
			//                                                                 0.0,
			//                                                                 0LL);
			//       v67 = (unsigned __int64)v2.fields.m_hgWaterInteractiveSetting;
			//       if ( v67 )
			//       {
			//         v204 = *(float *)(v67 + 56);
			//         v205 = *(float *)(v67 + 60);
			//         v206 = *(float *)(v67 + 44);
			//         v227.m128_i32[3] = 0;
			//         m_Buffer = (Vector4 *)v2.fields.waterRippleData.m_Buffer;
			//         v208 = v227;
			//         v208.m128_f32[0] = v204;
			//         v209 = _mm_shuffle_ps(v208, v208, 225);
			//         v209.m128_f32[0] = v205;
			//         v210 = _mm_shuffle_ps(v209, v209, 198);
			//         v210.m128_f32[0] = v206;
			//         v227 = _mm_shuffle_ps(v210, v210, 201);
			//         m_Buffer[2] = (Vector4)v227;
			//         v211 = v2.fields.m_hgWaterInteractiveSetting;
			//         if ( v211 )
			//         {
			//           v212 = (Vector4 *)v2.fields.waterRippleData.m_Buffer;
			//           v213 = _mm_shuffle_ps(
			//                    (__m128)LODWORD(v211.fields.interactiveDamp),
			//                    (__m128)LODWORD(v211.fields.interactiveDamp),
			//                    225);
			//           v213.m128_f32[0] = v211.fields.interactiveAlpha;
			//           v214 = _mm_shuffle_ps(v213, v213, 198);
			//           v214.m128_f32[0] = v211.fields.interactiveBeta;
			//           v215 = _mm_shuffle_ps(v214, v214, 39);
			//           v215.m128_f32[0] = v211.fields.interactiveSpeed;
			//           v227 = _mm_shuffle_ps(v215, v215, 57);
			//           v212[3] = (Vector4)v227;
			//           v216 = 0;
			//           v217 = 64LL;
			//           v218 = v233;
			//           while ( 1 )
			//           {
			//             v219 = v2.fields.m_RippleDataManager;
			//             if ( !v219 )
			//               break;
			//             list = (signed __int64)v219.fields._list;
			//             if ( !list )
			//               break;
			//             if ( *(_DWORD *)(list + 24) > v216 )
			//             {
			//               v220 = sub_184D03A3C(
			//                        list,
			//                        _mm_unpacklo_ps(
			//                          (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.x),
			//                          (__m128)LODWORD(v2.fields.m_centerRippleData.positionXZ.y)).m128_u64[0]);
			//               v221 = v2.fields.m_RippleDataManager;
			//               if ( !v221 )
			//                 goto LABEL_390;
			//               v67 = (unsigned __int64)v221.fields._list;
			//               if ( !v67 )
			//                 goto LABEL_390;
			//               System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//                 (SpatialPortalManager_FQueuedPortalObstructedData *)&v234,
			//                 (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)v67,
			//                 v216,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//               v222 = (Vector2)sub_18473B264(
			//                                 v220,
			//                                 _mm_unpacklo_ps((__m128)LODWORD(v234.argumentBase), (__m128)HIDWORD(v234.argumentBase)).m128_u64[0]);
			//               v67 = (unsigned __int64)v2.fields.m_RippleDataManager;
			//               if ( !v67 )
			//                 goto LABEL_390;
			//               v67 = *(_QWORD *)(v67 + 16);
			//               if ( !v67 )
			//                 goto LABEL_390;
			//               System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//                 (SpatialPortalManager_FQueuedPortalObstructedData *)&v234,
			//                 (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)v67,
			//                 v216,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//               if ( *(float *)&v234.evaluationStackBase >= 0.001 )
			//               {
			//                 v224 = v2.fields.m_RippleDataManager;
			//                 if ( !v224 )
			//                   goto LABEL_390;
			//                 v67 = (unsigned __int64)v224.fields._list;
			//                 if ( !v67 )
			//                   goto LABEL_390;
			//                 System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//                   (SpatialPortalManager_FQueuedPortalObstructedData *)&v234,
			//                   (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)v67,
			//                   v216,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//                 v223 = 1.0 / *(float *)&v234.evaluationStackBase;
			//               }
			//               else
			//               {
			//                 v223 = 0.0;
			//               }
			//               *(Vector4 *)&v218.fields.waterRippleData.m_Buffer[v217] = *HG::Rendering::Runtime::HGWaterManager::ToVector4(
			//                                                                             (Vector4 *)&v227,
			//                                                                             v2,
			//                                                                             v222,
			//                                                                             v223,
			//                                                                             1.0,
			//                                                                             0LL);
			//             }
			//             else
			//             {
			//               *(_OWORD *)&v2.fields.waterRippleData.m_Buffer[v217] = 0LL;
			//             }
			//             ++v216;
			//             v217 += 16LL;
			//             if ( v216 >= 8 )
			//               return;
			//           }
			//         }
			//       }
			//       goto LABEL_390;
			//     }
			//   }
			// }
			// 
		}

		public void AddWaterRippleData(float rippleSize, Vector2 ripplePostion, [MetadataOffset(Offset = "0x01F9213D")] int priority = 0)
		{
			// // Void AddWaterRippleData(Single, Vector2, Int32)
			// void HG::Rendering::Runtime::HGWaterManager::AddWaterRippleData(
			//         HGWaterManager *this,
			//         float rippleSize,
			//         Vector2 ripplePostion,
			//         int32_t priority,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // r9
			//   __m128 v13; // xmm0
			//   ProbeBrickIndex_ReservedBrick v14; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDBE2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
			//     byte_18D8EDBE2 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v5);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 4676 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//     if ( !v9 )
			//       goto LABEL_11;
			//     if ( LODWORD(v9._0.namespaze) <= 0x1244 )
			//       sub_180070270(v9, wrapperArray);
			//     if ( *(_QWORD *)&v9[99]._1.initializationExceptionGCHandle )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4676, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1342(
			//           Patch,
			//           (Object *)this,
			//           rippleSize,
			//           ripplePostion,
			//           priority,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_11;
			//     }
			//   }
			//   if ( rippleSize > 0.0 )
			//   {
			//     m_rawRippleDataList = this.fields.m_rawRippleDataList;
			//     *(_QWORD *)&v14.brick.position.m_Z = LODWORD(rippleSize);
			//     v9 = 0LL;
			//     *(Vector2 *)&v14.brick.position.m_X = ripplePostion;
			//     if ( m_rawRippleDataList )
			//     {
			//       v14.brick.subdivisionLevel = 0;
			//       v13 = _mm_shuffle_ps((__m128)v14.brick, (__m128)v14.brick, 210);
			//       v13.m128_f32[0] = rippleSize;
			//       *(float *)&v14.flattenedIdx = (float)priority;
			//       v14.brick = (ProbeBrickIndex_Brick)_mm_shuffle_ps(v13, v13, 201);
			//       System::Collections::Generic::List<UnityEngine::Experimental::Rendering::ProbeBrickIndex::ReservedBrick>::Add(
			//         (List_1_UnityEngine_Experimental_Rendering_ProbeBrickIndex_ReservedBrick_ *)m_rawRippleDataList,
			//         &v14,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v9, wrapperArray);
			//   }
			// }
			// 
		}

		public void SetTerrainRippleOpacity(float terrainRippleOpacity)
		{
			// // Void SetTerrainRippleOpacity(Single)
			// void HG::Rendering::Runtime::HGWaterManager::SetTerrainRippleOpacity(
			//         HGWaterManager *this,
			//         float terrainRippleOpacity,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4677, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4677, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       terrainRippleOpacity,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_terrainRippleOpacity = terrainRippleOpacity;
			//   }
			// }
			// 
		}

		public float GetTerrainRippleOpacity()
		{
			// // Single GetTerrainRippleOpacity()
			// float HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
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
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 860 )
			//     return this.fields.m_terrainRippleOpacity;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x35C )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[18]._0.properties )
			//     return this.fields.m_terrainRippleOpacity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(860, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0f;
		}

		public void SetShouldRenderRippleState(bool shouldRenderRipple)
		{
			// // Void SetShouldRenderRippleState(Boolean)
			// void HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState(
			//         HGWaterManager *this,
			//         bool shouldRenderRipple,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1959, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1959, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       shouldRenderRipple,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_shouldRenderRipple = shouldRenderRipple;
			//   }
			// }
			// 
		}

		public void ResetWaterRipple()
		{
			// // Void ResetWaterRipple()
			// void HG::Rendering::Runtime::HGWaterManager::ResetWaterRipple(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBE3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Clear);
			//     byte_18D8EDBE3 = 1;
			//   }
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
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size <= 1935 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_11;
			//   if ( LODWORD(v3._0.namespaze) <= 0x78F )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[41]._0.generic_class )
			//   {
			// LABEL_9:
			//     m_rawRippleDataList = this.fields.m_rawRippleDataList;
			//     if ( m_rawRippleDataList )
			//     {
			//       ++m_rawRippleDataList.fields._version;
			//       m_rawRippleDataList.fields._size = 0;
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1935, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public bool GetShouldRenderRippleState()
		{
			// // Boolean GetShouldRenderRippleState()
			// bool HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(HGWaterManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 892 )
			//     return this.fields.m_shouldRenderRipple;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x37Cu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[24].vector[28] )
			//     return this.fields.m_shouldRenderRipple;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(892, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public bool CheckIfRippleDataIsEmpty()
		{
			// // Boolean CheckIfRippleDataIsEmpty()
			// bool HG::Rendering::Runtime::HGWaterManager::CheckIfRippleDataIsEmpty(HGWaterManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rcx
			//   RippleDataManager *m_RippleDataManager; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91983B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count);
			//     byte_18D91983B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4678, 0LL) )
			//   {
			//     m_RippleDataManager = this.fields.m_RippleDataManager;
			//     if ( m_RippleDataManager )
			//     {
			//       list = m_RippleDataManager.fields._list;
			//       if ( list )
			//         return list.fields._size > 0;
			//     }
			// LABEL_8:
			//     sub_180B536AC(list, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4678, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public float _CalculateCharacterRippleSize(float speed, float waterDepth, [MetadataOffset(Offset = "0x01F9213E")] bool isLanding = false, [MetadataOffset(Offset = "0x01F9213F")] bool isGrounded = false, [MetadataOffset(Offset = "0x01F92140")] bool hitTerrainWater = false, [MetadataOffset(Offset = "0x01F92141")] bool hitLiquidWater = false)
		{
			// // Single _CalculateCharacterRippleSize(Single, Single, Boolean, Boolean, Boolean, Boolean)
			// float HG::Rendering::Runtime::HGWaterManager::_CalculateCharacterRippleSize(
			//         HGWaterManager *this,
			//         float speed,
			//         float waterDepth,
			//         bool isLanding,
			//         bool isGrounded,
			//         bool hitTerrainWater,
			//         bool hitLiquidWater,
			//         MethodInfo *method)
			// {
			//   __int64 v8; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGWaterInteractiveSetting *m_hgWaterInteractiveSetting; // rax
			//   float v14; // xmm10_4
			//   float moveRippleFrequency; // xmm7_4
			//   float stillRippleFrequency; // xmm14_4
			//   float interactiveRippleSize; // xmm15_4
			//   float v18; // xmm6_4
			//   float v19; // xmm9_4
			//   __int64 v20; // rdx
			//   float v21; // xmm8_4
			//   float v22; // xmm7_4
			//   __int64 v23; // rdx
			//   float v24; // xmm11_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v27; // rax
			//   Beyond::JobMathf *v28; // rcx
			//   Beyond::JobMathf *v29; // rcx
			//   double v30; // xmm0_8
			//   float v31; // xmm8_4
			//   __int64 v32; // rdx
			//   float time; // xmm9_4
			//   float v34; // xmm6_4
			//   Beyond::JobMathf *v35; // rcx
			//   float v36; // xmm0_4
			//   float v37; // xmm6_4
			// 
			//   if ( !byte_18D8EDBE4 )
			//   {
			//     sub_18003C530(&TypeInfo::Beyond::RandomUtils);
			//     byte_18D8EDBE4 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v8);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_34;
			//   if ( wrapperArray.max_length.size > 4679 )
			//   {
			//     if ( !v11._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v11, wrapperArray);
			//       v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v11.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_34;
			//     if ( wrapperArray.max_length.size <= 0x1247u )
			//       goto LABEL_49;
			//     if ( wrapperArray[130].max_length.value )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4679, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1343(
			//                  Patch,
			//                  (Object *)this,
			//                  speed,
			//                  waterDepth,
			//                  isLanding,
			//                  isGrounded,
			//                  hitTerrainWater,
			//                  hitLiquidWater,
			//                  0LL);
			//       goto LABEL_34;
			//     }
			//   }
			//   m_hgWaterInteractiveSetting = this.fields.m_hgWaterInteractiveSetting;
			//   if ( !m_hgWaterInteractiveSetting )
			//     goto LABEL_34;
			//   v14 = 1.0;
			//   moveRippleFrequency = m_hgWaterInteractiveSetting.fields.moveRippleFrequency;
			//   stillRippleFrequency = m_hgWaterInteractiveSetting.fields.stillRippleFrequency;
			//   interactiveRippleSize = m_hgWaterInteractiveSetting.fields.interactiveRippleSize;
			//   v18 = 1.0 / speed;
			//   if ( (float)(1.0 / speed) > 1.0 )
			//     v18 = 1.0;
			//   v19 = 0.0;
			//   if ( v18 < 0.0 )
			//     v18 = 0.0;
			//   v21 = v18 * *(float *)(Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v11) + 64);
			//   if ( !TypeInfo::Beyond::RandomUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::Beyond::RandomUtils, v20);
			//   v22 = moveRippleFrequency - v21;
			//   v24 = Beyond::RandomUtils::Value(0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v23);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_34;
			//   if ( wrapperArray.max_length.size <= 4675 )
			//     goto LABEL_22;
			//   if ( !v11._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v11, wrapperArray);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11.static_fields.wrapperArray;
			//   if ( !v11 )
			// LABEL_34:
			//     sub_180B536AC(v11, wrapperArray);
			//   if ( LODWORD(v11._0.namespaze) <= 0x1243 )
			// LABEL_49:
			//     sub_180070270(v11, wrapperArray);
			//   if ( !v11[99]._1.unity_user_data )
			//   {
			// LABEL_22:
			//     if ( v24 > v22 )
			//       v14 = 0.0;
			//     goto LABEL_24;
			//   }
			//   v27 = IFix::WrappersManagerImpl::GetPatch(4675, 0LL);
			//   if ( !v27 )
			//     goto LABEL_34;
			//   v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_436(
			//           (ILFixDynamicMethodWrapper_3 *)v27,
			//           (Object *)this,
			//           v24,
			//           v22,
			//           0LL);
			// LABEL_24:
			//   if ( waterDepth > 0.5 )
			//     v14 = 0.0;
			//   if ( !TypeInfo::Beyond::RandomUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::Beyond::RandomUtils, wrapperArray);
			//   Beyond::RandomUtils::Value(0LL);
			//   if ( !this.fields.m_hgWaterInteractiveSetting )
			//     goto LABEL_34;
			//   if ( (hitTerrainWater || hitLiquidWater) && isGrounded )
			//   {
			//     Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v11);
			//     Beyond::JobMathf::Clamp01(v28);
			//     v30 = Beyond::JobMathf::ClampedLerp(v29, 0.0, v14);
			//     v31 = *(float *)&v30;
			//     time = UnityEngine::Time::get_time(0LL);
			//     if ( !TypeInfo::Beyond::RandomUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::Beyond::RandomUtils, v32);
			//     v34 = Beyond::RandomUtils::Value(0LL);
			//     Beyond::JobMathf::Fmod(v35, 1024.0, v14);
			//     v36 = HG::Rendering::Runtime::HGWaterManager::Frac(this, v34 + time, 0LL);
			//     v37 = HG::Rendering::Runtime::HGWaterManager::Step(this, v36, stillRippleFrequency, 0LL);
			//     v19 = (float)(HG::Rendering::Runtime::HGWaterManager::Step(this, speed, 0.050000001, 0LL)
			//                 * (float)(v37 * interactiveRippleSize))
			//         + v31;
			//   }
			//   if ( (hitLiquidWater || hitTerrainWater) && isLanding )
			//     return v19 + (float)(interactiveRippleSize + 0.2);
			//   return v19;
			// }
			// 
			return 0f;
		}

		public void UpdateTerrainRippleInfo(ColliderSurfaceType curColliderSurfaceType)
		{
			// // Void UpdateTerrainRippleInfo(ColliderSurfaceType)
			// void HG::Rendering::Runtime::HGWaterManager::UpdateTerrainRippleInfo(
			//         HGWaterManager *this,
			//         ColliderSurfaceType__Enum curColliderSurfaceType,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_Int32Enum_System_Single_ *entries; // rcx
			//   HGWaterInteractiveSetting *m_hgWaterInteractiveSetting; // rax
			//   Object_1 *v8; // rdi
			//   float rippleStrengthLerpTime; // xmm7_4
			//   HGWaterInteractiveSetting *v10; // rax
			//   Dictionary_2_System_Int32Enum_System_Single_ *terrainRippleStrengthConfig; // rsi
			//   struct MethodInfo *v12; // rdi
			//   int32_t Entry; // eax
			//   HGWaterInteractiveSetting *v14; // rax
			//   float v15; // xmm6_4
			//   float time; // xmm0_4
			//   float m_terrainRippleStrength; // xmm1_4
			//   float v18; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float value; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDBE5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBE5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4680, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4680, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//         (ILFixDynamicMethodWrapper_26 *)Patch,
			//         (Object *)this,
			//         curColliderSurfaceType,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_30;
			//   }
			//   m_hgWaterInteractiveSetting = this.fields.m_hgWaterInteractiveSetting;
			//   if ( !m_hgWaterInteractiveSetting )
			//     goto LABEL_30;
			//   v8 = (Object_1 *)this.fields.m_hgWaterInteractiveSetting;
			//   rippleStrengthLerpTime = m_hgWaterInteractiveSetting.fields.rippleStrengthLerpTime;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( !UnityEngine::Object::op_Equality(v8, 0LL, 0LL) )
			//   {
			//     v10 = this.fields.m_hgWaterInteractiveSetting;
			//     if ( v10 )
			//     {
			//       if ( !v10.fields.terrainRippleStrengthConfig )
			//         return;
			//       terrainRippleStrengthConfig = (Dictionary_2_System_Int32Enum_System_Single_ *)v10.fields.terrainRippleStrengthConfig;
			//       v12 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue;
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy)();
			//       Entry = System::Collections::Generic::Dictionary<System::Int32Enum,float>::FindEntry(
			//                 terrainRippleStrengthConfig,
			//                 (Int32Enum__Enum)curColliderSurfaceType,
			//                 (MethodInfo *)v12.klass.rgctx_data[22].rgctxDataDummy);
			//       if ( Entry >= 0 )
			//       {
			//         entries = (Dictionary_2_System_Int32Enum_System_Single_ *)terrainRippleStrengthConfig.fields._entries;
			//         if ( entries )
			//         {
			//           if ( (unsigned int)Entry >= LODWORD(entries.fields._entries) )
			//             sub_180070270(entries, v5);
			//           v15 = *((float *)&entries.fields._version + 4 * Entry);
			//           goto LABEL_16;
			//         }
			//       }
			//       else
			//       {
			//         value = 0.0;
			//         v14 = this.fields.m_hgWaterInteractiveSetting;
			//         if ( v14 )
			//         {
			//           entries = (Dictionary_2_System_Int32Enum_System_Single_ *)v14.fields.terrainRippleStrengthConfig;
			//           if ( entries )
			//           {
			//             System::Collections::Generic::Dictionary<System::Int32Enum,float>::TryGetValue(
			//               entries,
			//               (Int32Enum__Enum)0,
			//               &value,
			//               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue);
			//             v15 = value;
			// LABEL_16:
			//             if ( fabs(v15 - this.fields.m_terrainRippleStrength) > 0.001 )
			//             {
			//               this.fields.m_lerpStartTimeTime = UnityEngine::Time::get_time(0LL);
			//               this.fields.m_terrainRippleStrength = v15;
			//               this.fields.m_isOnLerpProcedural = 1;
			//             }
			//             if ( this.fields.m_isOnLerpProcedural )
			//             {
			//               time = UnityEngine::Time::get_time(0LL);
			//               m_terrainRippleStrength = this.fields.m_terrainRippleStrength;
			//               v18 = (float)(time - this.fields.m_lerpStartTimeTime) / rippleStrengthLerpTime;
			//               if ( v18 >= 1.0 )
			//               {
			//                 this.fields.m_terrainRippleNormalStrength = m_terrainRippleStrength;
			//                 this.fields.m_isOnLerpProcedural = 0;
			//               }
			//               else
			//               {
			//                 if ( v18 < 0.0 )
			//                 {
			//                   v18 = 0.0;
			//                 }
			//                 else if ( v18 > 1.0 )
			//                 {
			//                   v18 = 1.0;
			//                 }
			//                 this.fields.m_terrainRippleNormalStrength = (float)((float)(m_terrainRippleStrength
			//                                                                            - this.fields.m_terrainRippleNormalStrength)
			//                                                                    * v18)
			//                                                            + this.fields.m_terrainRippleNormalStrength;
			//               }
			//             }
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_30:
			//     sub_180B536AC(entries, v5);
			//   }
			// }
			// 
		}

		public void StopUpdateBoatPosition()
		{
			// // Void StopUpdateBoatPosition()
			// void HG::Rendering::Runtime::HGWaterManager::StopUpdateBoatPosition(HGWaterManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4681, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4681, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_isBoatStop = 1;
			//   }
			// }
			// 
		}

		public void StartUpdateBoatPosition()
		{
			// // Void StartUpdateBoatPosition()
			// void HG::Rendering::Runtime::HGWaterManager::StartUpdateBoatPosition(HGWaterManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4682, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4682, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_isBoatStop = 0;
			//   }
			// }
			// 
		}

		public void SetBoatPositionSpeed(List<Vector3> boatAnchors, float boatSpeed)
		{
			// // Void SetBoatPositionSpeed(List`1[UnityEngine.Vector3], Single)
			// void HG::Rendering::Runtime::HGWaterManager::SetBoatPositionSpeed(
			//         HGWaterManager *this,
			//         List_1_UnityEngine_Vector3_ *boatAnchors,
			//         float boatSpeed,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   int32_t size; // esi
			//   int32_t i; // ebp
			//   Beyond::JobMathf *v10; // rcx
			//   double v11; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry v13; // [rsp+30h] [rbp-38h] BYREF
			//   RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry v14; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91983C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     sub_18003C530(&TypeInfo::Beyond::RandomUtils);
			//     byte_18D91983C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4683, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4683, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//         (ILFixDynamicMethodWrapper_9 *)Patch,
			//         (Object *)this,
			//         (Object *)boatAnchors,
			//         boatSpeed,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_12;
			//   }
			//   if ( !this.fields.m_isPlayerOnBoat || this.fields.m_isBoatStop || boatSpeed < 0.01 )
			//     return;
			//   if ( !boatAnchors )
			// LABEL_12:
			//     sub_180B536AC(v7, v6);
			//   size = boatAnchors.fields._size;
			//   for ( i = 0; i < size; ++i )
			//   {
			//     UnityEngine::Time::get_time(0LL);
			//     sub_180002C70(TypeInfo::Beyond::RandomUtils);
			//     Beyond::RandomUtils::Value(0LL);
			//     Beyond::JobMathf::Fmod(v10, 1024.0, boatSpeed);
			//     v11 = Beyond::DampingMath::sinf();
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//       &v14,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)boatAnchors,
			//       i,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//       &v13,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)boatAnchors,
			//       i,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     boatSpeed = *(float *)&v13.chapterLimitedCount;
			//     HG::Rendering::Runtime::HGWaterManager::AddWaterRippleData(
			//       this,
			//       (float)(*(float *)&v11 * 0.02) + 0.40000001,
			//       (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                              (__m128)(unsigned int)v14.buildingType,
			//                              (__m128)(unsigned int)v13.chapterLimitedCount),
			//       2,
			//       0LL);
			//   }
			// }
			// 
		}

		public const int INVALID_MATERIAL_INDEX = -1;

		public const int MAX_STATIC_WATER_TYPES = 32;

		public const int MAX_DYNAMIC_WATER_TYPES = 32;

		public const int MAX_NUM_WATER_TYPES = 64;

		public const int WATER_DEFAULT_TEXTURE_SIZE = 2;

		public const int WATER_RIPPLE_DATA_VECTOR4_COUNT = 20;

		public const int WATER_GPU_DATA_PARAMS_START = 10;

		public const int WATER_GPU_DATA_MATERIAL_START = 18;

		public const int WATER_GPU_DATA_MATERIAL_VECTOR4_COUNT = 20;

		public const int WATER_GPU_DATA_VECTOR4_COUNT = 1298;

		private int m_validGlobalConfigIndex;

		private List<HGWaterGlobalConfig> m_globalConfigs;

		public bool forceHideWater;

		private bool enableOrthographicRender;

		private bool m_shouldStoreDepth;

		private HGWaterConfig[] m_waterConfigs;

		public NativeArray<Vector4> waterRippleData;

		public NativeArray<Vector4> waterGPUData;

		public NativeArray<Vector4> defaultWaterMaterialData;

		private Mesh m_screenSpaceMesh;

		public HGWaterInteractiveSetting m_hgWaterInteractiveSetting;

		public const float RIPPLE_SIMULATION_RANGE = 32f;

		private bool m_shouldRenderRipple;

		private bool m_isRippleInputEmpty;

		private RippleDataManager m_RippleDataManager;

		private float m_terrainRippleOpacity;

		private const float RIPPLE_SIZE_CHANGE_SPEED = 5000f;

		private bool m_isPlayerOnBoat;

		private bool m_isBoatStop;

		private bool m_isPlayerInWater;

		private List<InputRippleData> m_rawRippleDataList;

		private InputRippleData m_centerRippleData;

		private InputRippleData m_lastCenterRippleData;

		private const int RIPPLE_LIST_MAX_SIZE = 8;

		private const int RIPPLE_SIMULATION_SIZE = 12;

		private const float characterSpeedSizeInfluence = 0.04f;

		private const float sizeRandomInfluence = 0.04f;

		private float m_lerpStartTimeTime;

		private bool m_isOnLerpProcedural;

		private float m_terrainRippleStrength;

		private float m_terrainRippleNormalStrength;

		private const float boatRippleRandomSize = 0.02f;

		private const float boatRippleRandomSizeSpeed = 10f;
	}
}
