using System;
using System.Collections.Generic;
using HG.Rendering.Runtime.Snow;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGSnowRenderer
	{
		public HGSnowRenderer()
		{
		}

		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources, HGSettingParameters settingParameters)
		{
			// // Void PrepareResources(HGRenderPipelineRuntimeResources, HGSettingParameters)
			// void HG::Rendering::Runtime::HGSnowRenderer::PrepareResources(
			//         HGSnowRenderer *this,
			//         HGRenderPipelineRuntimeResources *defaultResources,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *sceneEffectRainMesh; // rdx
			//   SnowCommonResources *m_snowCommonResources; // rcx
			//   HGRenderPipelineRuntimeResources_AssetResources *assets; // rsi
			//   HGSnowPresettingAsset *snowPresettingAsset; // rsi
			//   __int64 v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   HGRenderPipelineRuntimeResources_AssetResources *v14; // rax
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v21; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v22; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDCA6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCA6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1404, 0LL) )
			//   {
			//     if ( defaultResources )
			//     {
			//       assets = defaultResources.fields.assets;
			//       if ( assets )
			//       {
			//         snowPresettingAsset = assets.fields.snowPresettingAsset;
			//         HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//         if ( UnityEngine::Object::op_Inequality(0LL, (Object_1 *)snowPresettingAsset, 0LL) )
			//         {
			//           if ( !snowPresettingAsset )
			//             goto LABEL_16;
			//           this.fields.m_snowCommonPreSettingParam = snowPresettingAsset.fields.snowCommonPreSettingParam;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&this.fields.m_snowCommonPreSettingParam,
			//             sceneEffectRainMesh,
			//             v12,
			//             v13,
			//             methoda,
			//             v21);
			//         }
			//         v14 = defaultResources.fields.assets;
			//         m_snowCommonResources = this.fields.m_snowCommonResources;
			//         if ( v14 )
			//         {
			//           sceneEffectRainMesh = (HGRenderPathBase_HGRenderPathResources *)v14.fields.sceneEffectRainMesh;
			//           if ( m_snowCommonResources )
			//           {
			//             m_snowCommonResources.fields.snowMesh = (Mesh *)sceneEffectRainMesh;
			//             sub_1800054D0(
			//               (HGRenderPathScene *)&m_snowCommonResources.fields,
			//               sceneEffectRainMesh,
			//               v12,
			//               v13,
			//               methoda,
			//               v21);
			//             shaders = defaultResources.fields.shaders;
			//             m_snowCommonResources = this.fields.m_snowCommonResources;
			//             if ( shaders )
			//             {
			//               sceneEffectRainMesh = (HGRenderPathBase_HGRenderPathResources *)shaders.fields.sceneEffectRainPS;
			//               if ( m_snowCommonResources )
			//               {
			//                 m_snowCommonResources.fields.snowShader = (Shader *)sceneEffectRainMesh;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&m_snowCommonResources.fields.snowShader,
			//                   sceneEffectRainMesh,
			//                   v15,
			//                   v16,
			//                   methodb,
			//                   v22);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(m_snowCommonResources, sceneEffectRainMesh);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1404, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)defaultResources,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		internal void SnowPipelineUpdate(HGSettingParameters settingParameters)
		{
			// // Void SnowPipelineUpdate(HGSettingParameters)
			// void HG::Rendering::Runtime::HGSnowRenderer::SnowPipelineUpdate(
			//         HGSnowRenderer *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *items; // rcx
			//   __int64 v6; // rdx
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *m_snowRenderSeqs; // rbx
			//   int32_t v8; // ebx
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v9; // rax
			//   Camera *camera; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *Item; // rax
			// 
			//   if ( !byte_18D8EDCA7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCA7 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = **(_QWORD **)&items[4].fields._size;
			//   if ( !v6 )
			//     goto LABEL_36;
			//   if ( *(int *)(v6 + 24) <= 625 )
			//     goto LABEL_9;
			//   if ( !items[5].fields._size )
			//   {
			//     il2cpp_runtime_class_init_0(items, v6);
			//     items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = **(_QWORD **)&items[4].fields._size;
			//   if ( !v6 )
			// LABEL_36:
			//     sub_180B536AC(items, v6);
			//   if ( *(_DWORD *)(v6 + 24) <= 0x271u )
			// LABEL_37:
			//     sub_180070270(items, v6);
			//   if ( *(_QWORD *)(v6 + 5032) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(625, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)settingParameters,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_36;
			//   }
			// LABEL_9:
			//   HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
			//   m_snowRenderSeqs = this.fields.m_snowRenderSeqs;
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_36;
			//   v8 = m_snowRenderSeqs.fields._size - 1;
			//   if ( v8 >= 0 )
			//   {
			//     while ( 1 )
			//     {
			//       v9 = this.fields.m_snowRenderSeqs;
			//       if ( !v9 )
			//         goto LABEL_36;
			//       if ( (unsigned int)v8 >= v9.fields._size )
			//         goto LABEL_51;
			//       items = (List_1_System_Object_ *)v9.fields._items;
			//       if ( !items )
			//         goto LABEL_36;
			//       if ( (unsigned int)v8 >= items.fields._size )
			//         goto LABEL_37;
			//       if ( !*((_QWORD *)&items.fields._syncRoot + v8) )
			//         break;
			//       HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PerFrameClear(
			//         this.fields.m_snowRenderSeqs.fields._items.vector[v8],
			//         0LL);
			//       items = (List_1_System_Object_ *)this.fields.m_snowRenderSeqs;
			//       if ( !items )
			//         goto LABEL_36;
			//       if ( (unsigned int)v8 >= items.fields._size )
			// LABEL_51:
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       items = (List_1_System_Object_ *)items.fields._items;
			//       if ( !items )
			//         goto LABEL_36;
			//       if ( (unsigned int)v8 >= items.fields._size )
			//         goto LABEL_37;
			//       v6 = *((_QWORD *)&items.fields._syncRoot + v8);
			//       if ( !v6 )
			//         goto LABEL_36;
			//       if ( !*(_QWORD *)(v6 + 16) )
			//         goto LABEL_45;
			//       camera = this.fields.m_snowRenderSeqs.fields._items.vector[v8].fields.hgCamera.fields.camera;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !camera )
			//         goto LABEL_45;
			//       items = (List_1_System_Object_ *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//       if ( !camera.fields._._._.m_CachedPtr )
			//       {
			// LABEL_45:
			//         items = (List_1_System_Object_ *)this.fields.m_snowRenderSeqs;
			//         if ( !items )
			//           goto LABEL_36;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  items,
			//                  v8,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
			//         if ( !Item )
			//           goto LABEL_36;
			//         HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose((HGSnowRenderer_SnowRenderSeq *)Item, 0LL);
			//         items = (List_1_System_Object_ *)this.fields.m_snowRenderSeqs;
			//         if ( !items )
			//           goto LABEL_36;
			//         goto LABEL_50;
			//       }
			// LABEL_34:
			//       if ( --v8 < 0 )
			//         return;
			//     }
			//     items = (List_1_System_Object_ *)this.fields.m_snowRenderSeqs;
			// LABEL_50:
			//     System::Collections::Generic::List<System::Object>::RemoveAt(
			//       items,
			//       v8,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::RemoveAt);
			//     goto LABEL_34;
			//   }
			// }
			// 
		}

		private void _UpdateQualitySettings(HGSettingParameters settingParameters)
		{
			// // Void _UpdateQualitySettings(HGSettingParameters)
			// void HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(
			//         HGSnowRenderer *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGSnowSettingParameters *snow_k__BackingField; // rbx
			//   HGSnowRenderer_SnowQualityParams *m_qualityParams; // rsi
			//   SettingParameter_1_System_Boolean_ *EnableSnowLighting_k__BackingField; // rdi
			//   struct MethodInfo *v10; // r14
			//   Il2CppClass *klass; // rax
			//   SettingParameter_1_System_Boolean_ *EnableSnowCollision_k__BackingField; // rsi
			//   HGSnowRenderer_SnowQualityParams *v13; // rdi
			//   struct MethodInfo *v14; // r14
			//   Il2CppClass *v15; // rax
			//   SettingParameter_1_System_Int32_ *SnowLayerCount_k__BackingField; // rbx
			//   HGSnowRenderer_SnowQualityParams *v17; // rdi
			//   struct MethodInfo *v18; // rsi
			//   Il2CppClass *v19; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rax
			//   __int64 v22; // rax
			//   __int64 v23; // rax
			// 
			//   if ( !byte_18D8EDCA8 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDCA8 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_36;
			//   if ( wrapperArray.max_length.size <= 626 )
			//     goto LABEL_34;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_36;
			//   if ( LODWORD(v5._0.namespaze) <= 0x272 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !v5[13]._0.methods )
			//   {
			// LABEL_34:
			//     if ( settingParameters )
			//     {
			//       snow_k__BackingField = settingParameters.fields._snow_k__BackingField;
			//       m_qualityParams = this.fields.m_qualityParams;
			//       if ( snow_k__BackingField )
			//       {
			//         EnableSnowLighting_k__BackingField = snow_k__BackingField.fields._EnableSnowLighting_k__BackingField;
			//         v10 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//         if ( EnableSnowLighting_k__BackingField )
			//         {
			//           klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//           if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//           {
			//             v21 = sub_18010B520(v10.klass);
			//             (**(void (***)(void))(*(_QWORD *)(v21 + 192) + 48LL))();
			//           }
			//           v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.klass;
			//           if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//             sub_18003C700(v5);
			//           if ( m_qualityParams )
			//           {
			//             m_qualityParams.fields.enableSnowLighting = EnableSnowLighting_k__BackingField.fields._paramValue_k__BackingField;
			//             EnableSnowCollision_k__BackingField = snow_k__BackingField.fields._EnableSnowCollision_k__BackingField;
			//             v13 = this.fields.m_qualityParams;
			//             v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//             if ( EnableSnowCollision_k__BackingField )
			//             {
			//               v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//               if ( ((__int64)v15.vtable[0].methodPtr & 1) == 0 )
			//                 sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//               if ( !*((_QWORD *)v15.rgctx_data[6].rgctxDataDummy + 4) )
			//               {
			//                 v22 = sub_18010B520(v14.klass);
			//                 (**(void (***)(void))(*(_QWORD *)(v22 + 192) + 48LL))();
			//               }
			//               v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v14.klass;
			//               if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                 sub_18003C700(v5);
			//               if ( v13 )
			//               {
			//                 v13.fields.enableSnowCollision = EnableSnowCollision_k__BackingField.fields._paramValue_k__BackingField;
			//                 SnowLayerCount_k__BackingField = snow_k__BackingField.fields._SnowLayerCount_k__BackingField;
			//                 v17 = this.fields.m_qualityParams;
			//                 v18 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//                 if ( SnowLayerCount_k__BackingField )
			//                 {
			//                   v19 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//                   if ( ((__int64)v19.vtable[0].methodPtr & 1) == 0 )
			//                     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//                   if ( !*((_QWORD *)v19.rgctx_data[6].rgctxDataDummy + 4) )
			//                   {
			//                     v23 = sub_18010B520(v18.klass);
			//                     (**(void (***)(void))(*(_QWORD *)(v23 + 192) + 48LL))();
			//                   }
			//                   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v18.klass;
			//                   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                     sub_18003C700(v5);
			//                   if ( v17 )
			//                   {
			//                     v17.fields.snowLayerCount = SnowLayerCount_k__BackingField.fields._paramValue_k__BackingField;
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_36:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(626, 0LL);
			//   if ( !Patch )
			//     goto LABEL_36;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		internal void UpdateSnowData(HGCamera camera, ref ScriptableRenderContext renderContext)
		{
			// // Void UpdateSnowData(HGCamera, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(
			//         HGSnowRenderer *this,
			//         HGCamera *camera,
			//         ScriptableRenderContext *renderContext,
			//         MethodInfo *method)
			// {
			//   void *items; // rcx
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *m_snowRenderSeqs; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *i; // r9
			//   int32_t v11; // r9d
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v12; // rax
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v13; // rax
			//   HGSnowRenderer_SnowRenderSeq__Array *v14; // rdi
			//   Object *m_qualityParams; // rbx
			//   HGSnowRenderer_SnowRenderSeq *v16; // rdi
			//   __int64 v17; // rax
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   __int64 v20; // rsi
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v21; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v22; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   PassConstructorID__Enum__Array *v24; // r8
			//   HGCamera *v25; // r9
			//   SnowCommonRenderingParam *v26; // rax
			//   SnowCommonRenderingParam *v27; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v28; // rdx
			//   PassConstructorID__Enum__Array *v29; // r8
			//   HGCamera *v30; // r9
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v34; // r9
			//   bool v35; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v37; // rax
			//   ILFixDynamicMethodWrapper_2 *v38; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v44; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v45; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v46; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v47; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-20h]
			//   int32_t P3; // [rsp+30h] [rbp-18h] BYREF
			//   HGSnowRenderer_SnowRenderSeq *P2[2]; // [rsp+38h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D8EDCA9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonRenderingParam);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq);
			//     byte_18D8EDCA9 = 1;
			//   }
			//   P2[0] = 0LL;
			//   P3 = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_49;
			//   if ( m_snowRenderSeqs.fields._size > 750 )
			//   {
			//     if ( !*((_DWORD *)items + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(items, m_snowRenderSeqs);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//     if ( !m_snowRenderSeqs )
			//       goto LABEL_49;
			//     if ( m_snowRenderSeqs.fields._size <= 0x2EEu )
			//       goto LABEL_58;
			//     if ( m_snowRenderSeqs[150].fields._syncRoot )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(750, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(Patch, (Object *)this, (Object *)camera, renderContext, 0LL);
			//         return;
			//       }
			//       goto LABEL_49;
			//     }
			//   }
			//   if ( !byte_18D8EDCAC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDCAC = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !*((_DWORD *)items + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(items, m_snowRenderSeqs);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_49;
			//   if ( m_snowRenderSeqs.fields._size <= 521 )
			//     goto LABEL_17;
			//   if ( !*((_DWORD *)items + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(items, m_snowRenderSeqs);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_49;
			//   if ( m_snowRenderSeqs.fields._size <= 0x209u )
			//     goto LABEL_58;
			//   if ( m_snowRenderSeqs[105].klass )
			//   {
			//     v37 = IFix::WrappersManagerImpl::GetPatch(521, 0LL);
			//     if ( !v37 )
			//       goto LABEL_49;
			//     v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_212(v37, (Object *)this, (Object *)camera, P2, &P3, 0LL);
			//     v11 = P3;
			//     if ( !v35 && P3 < 0 )
			//       goto LABEL_50;
			//   }
			//   else
			//   {
			// LABEL_17:
			//     P2[0] = 0LL;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)P2,
			//       (HGRenderPathBase_HGRenderPathResources *)m_snowRenderSeqs,
			//       (PassConstructorID__Enum__Array *)renderContext,
			//       (HGCamera *)method,
			//       methoda,
			//       v44);
			//     if ( !camera || !this.fields.m_snowRenderSeqs || this.fields.m_snowRenderSeqs.fields._size <= 0 )
			//       goto LABEL_50;
			//     m_snowRenderSeqs = this.fields.m_snowRenderSeqs;
			//     for ( i = 0LL; ; i = (HGCamera *)(unsigned int)((_DWORD)i + 1) )
			//     {
			//       if ( (int)i >= m_snowRenderSeqs.fields._size )
			//         goto LABEL_50;
			//       if ( (unsigned int)i >= m_snowRenderSeqs.fields._size )
			//         goto LABEL_83;
			//       items = m_snowRenderSeqs.fields._items;
			//       if ( !items )
			//         goto LABEL_49;
			//       if ( (unsigned int)i >= *((_DWORD *)items + 6) )
			//         goto LABEL_58;
			//       if ( *((_QWORD *)items + (int)i + 4) )
			//       {
			//         items = (void *)*((_QWORD *)items + (int)i + 4);
			//         if ( *((HGCamera **)items + 2) == camera )
			//           break;
			//       }
			//     }
			//     if ( (int)i <= -1 )
			//     {
			// LABEL_50:
			//       v17 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq);
			//       v20 = v17;
			//       if ( !v17 )
			//         goto LABEL_49;
			//       *(_DWORD *)(v17 + 24) = -1;
			//       *(_QWORD *)(v17 + 16) = camera;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)(v17 + 16),
			//         (HGRenderPathBase_HGRenderPathResources *)m_snowRenderSeqs,
			//         v18,
			//         v19,
			//         methodb,
			//         v45);
			//       v21 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>);
			//       v22 = v21;
			//       if ( !v21 )
			//         goto LABEL_49;
			//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//         v21,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::List);
			//       *(_QWORD *)(v20 + 32) = v22;
			//       sub_1800054D0((HGRenderPathScene *)(v20 + 32), v23, v24, v25, methodc, v46);
			//       v26 = (SnowCommonRenderingParam *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonRenderingParam);
			//       v27 = v26;
			//       if ( !v26 )
			//         goto LABEL_49;
			//       HG::Rendering::Runtime::Snow::SnowCommonRenderingParam::SnowCommonRenderingParam(v26, 0LL);
			//       v27.fields.snowCommonPreSettingParam = this.fields.m_snowCommonPreSettingParam;
			//       sub_1800054D0((HGRenderPathScene *)&v27.fields.snowCommonPreSettingParam, v28, v29, v30, methodd, v47);
			//       *(_QWORD *)(v20 + 40) = v27;
			//       sub_1800054D0((HGRenderPathScene *)(v20 + 40), v31, v32, v33, methode, v48);
			//       HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::CreateDefaultFeatures(
			//         (HGSnowRenderer_SnowRenderSeq *)v20,
			//         0LL);
			//       HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PrepareResources(
			//         (HGSnowRenderer_SnowRenderSeq *)v20,
			//         this.fields.m_snowCommonResources,
			//         0LL);
			//       items = this.fields.m_snowRenderSeqs;
			//       if ( !items )
			//         goto LABEL_49;
			//       sub_1822AD140((List_1_System_Object_ *)items, (Object *)v20);
			//       v34 = this.fields.m_snowRenderSeqs;
			//       if ( !v34 )
			//         goto LABEL_49;
			//       v11 = v34.fields._size - 1;
			//       goto LABEL_30;
			//     }
			//     if ( !m_snowRenderSeqs )
			//       goto LABEL_49;
			//     P2[0] = m_snowRenderSeqs.fields._items.vector[(int)i];
			//     sub_1800054D0(
			//       (HGRenderPathScene *)P2,
			//       (HGRenderPathBase_HGRenderPathResources *)m_snowRenderSeqs,
			//       v9,
			//       i,
			//       methodb,
			//       v45);
			//   }
			// LABEL_30:
			//   if ( v11 <= -1 )
			//     return;
			//   v12 = this.fields.m_snowRenderSeqs;
			//   if ( !v12 )
			//     goto LABEL_49;
			//   if ( (unsigned int)v11 >= v12.fields._size )
			//     goto LABEL_83;
			//   items = v12.fields._items;
			//   if ( !items )
			//     goto LABEL_49;
			//   if ( (unsigned int)v11 >= *((_DWORD *)items + 6) )
			//     goto LABEL_58;
			//   m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)*((_QWORD *)items + v11 + 4);
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_49;
			//   m_snowRenderSeqs.fields._size = v11;
			//   v13 = this.fields.m_snowRenderSeqs;
			//   if ( !v13 )
			//     goto LABEL_49;
			//   if ( (unsigned int)v11 >= v13.fields._size )
			// LABEL_83:
			//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//   v14 = v13.fields._items;
			//   if ( !v14 )
			//     goto LABEL_49;
			//   if ( (unsigned int)v11 >= v14.max_length.size )
			// LABEL_58:
			//     sub_180070270(items, m_snowRenderSeqs);
			//   m_qualityParams = (Object *)this.fields.m_qualityParams;
			//   v16 = v14.vector[v11];
			//   if ( !v16 )
			//     goto LABEL_49;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, m_snowRenderSeqs);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//   if ( !m_snowRenderSeqs )
			//     goto LABEL_49;
			//   if ( m_snowRenderSeqs.fields._size > 753 )
			//   {
			//     if ( !*((_DWORD *)items + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(items, m_snowRenderSeqs);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
			//     if ( !m_snowRenderSeqs )
			//       goto LABEL_49;
			//     if ( m_snowRenderSeqs.fields._size > 0x2F1u )
			//     {
			//       if ( !m_snowRenderSeqs[151].fields._items )
			//         goto LABEL_47;
			//       v38 = IFix::WrappersManagerImpl::GetPatch(753, 0LL);
			//       if ( v38 )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(v38, (Object *)v16, m_qualityParams, renderContext, 0LL);
			//         return;
			//       }
			// LABEL_49:
			//       sub_180B536AC(items, m_snowRenderSeqs);
			//     }
			//     goto LABEL_58;
			//   }
			// LABEL_47:
			//   HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateDeltaTime(v16, 0LL);
			//   HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
			//     v16,
			//     v16.fields.m_deltaTime,
			//     (HGSnowRenderer_SnowQualityParams *)m_qualityParams,
			//     renderContext,
			//     0LL);
			//   HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_RequestOcclusionMap(v16, 0LL);
			// }
			// 
		}

		internal bool IsSnowRenderingEnabled(HGCamera hgCamera)
		{
			// // Boolean IsSnowRenderingEnabled(HGCamera)
			// bool HG::Rendering::Runtime::HGSnowRenderer::IsSnowRenderingEnabled(
			//         HGSnowRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   bool v5; // bl
			//   __int64 v6; // rdx
			//   SnowCommonRenderingParam *snowCommonRenderingParam; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSnowRenderer_SnowRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   v5 = 0;
			//   seq = 0LL;
			//   index = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1405, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//       return v5;
			//     if ( seq )
			//     {
			//       snowCommonRenderingParam = seq.fields.snowCommonRenderingParam;
			//       if ( snowCommonRenderingParam )
			//         return snowCommonRenderingParam.fields.enable;
			//     }
			// LABEL_8:
			//     sub_180B536AC(snowCommonRenderingParam, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1405, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)hgCamera,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal void Dispose()
		{
			// // Void Dispose()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGSnowRenderer::Dispose(HGSnowRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Il2CppExceptionWrapper *v6; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v7; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v8; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDCAA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Count);
			//     byte_18D8EDCAA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(495, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(495, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_snowRenderSeqs && this.fields.m_snowRenderSeqs.fields._size > 0 )
			//   {
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v7,
			//       (List_1_System_Object_ *)this.fields.m_snowRenderSeqs,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::GetEnumerator);
			//     v8 = v7;
			//     v7._list = 0LL;
			//     *(_QWORD *)&v7._index = &v8;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v8,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::MoveNext) )
			//       {
			//         if ( v8._current )
			//           HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(
			//             (HGSnowRenderer_SnowRenderSeq *)v8._current,
			//             0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v6 )
			//     {
			//       v7._list = (List_1_System_Object_ *)v6.ex;
			//       if ( v7._list )
			//         sub_18000F780(v7._list);
			//     }
			//   }
			// }
			// 
		}

		internal void DisposeSeq(HGCamera hgCamera)
		{
			// // Void DisposeSeq(HGCamera)
			// void HG::Rendering::Runtime::HGSnowRenderer::DisposeSeq(HGSnowRenderer *this, HGCamera *hgCamera, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_snowRenderSeqs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSnowRenderer_SnowRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDCAB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::Remove);
			//     byte_18D8EDCAB = 1;
			//   }
			//   seq = 0LL;
			//   index = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(520, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(520, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)hgCamera,
			//         0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_snowRenderSeqs, v5);
			//   }
			//   if ( hgCamera && HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//   {
			//     m_snowRenderSeqs = (List_1_System_Object_ *)seq;
			//     if ( seq )
			//     {
			//       HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(seq, 0LL);
			//       m_snowRenderSeqs = (List_1_System_Object_ *)this.fields.m_snowRenderSeqs;
			//       if ( m_snowRenderSeqs )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           m_snowRenderSeqs,
			//           (Object *)seq,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::Remove);
			//         return;
			//       }
			//     }
			//     goto LABEL_9;
			//   }
			// }
			// 
		}

		private bool _TryGetSeqByCamera(HGCamera hgCamera, out HGSnowRenderer.SnowRenderSeq seq, out int index)
		{
			// // Boolean _TryGetSeqByCamera(HGCamera, HGSnowRenderer+SnowRenderSeq ByRef, Int32 ByRef)
			// bool HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(
			//         HGSnowRenderer *this,
			//         HGCamera *hgCamera,
			//         HGSnowRenderer_SnowRenderSeq **seq,
			//         int32_t *index,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
			//   List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *wrapperArray; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   bool result; // al
			//   int32_t v14; // r9d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t *P3; // [rsp+20h] [rbp-18h]
			//   int32_t *P3a; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDCAC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
			//     byte_18D8EDCAC = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.fields._size <= 521 )
			//     goto LABEL_9;
			//   if ( !items._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(items, wrapperArray);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.fields._size <= 0x209u )
			// LABEL_24:
			//     sub_180070270(items, wrapperArray);
			//   if ( !wrapperArray[105].klass )
			//   {
			// LABEL_9:
			//     *seq = 0LL;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)seq,
			//       (HGRenderPathBase_HGRenderPathResources *)wrapperArray,
			//       (PassConstructorID__Enum__Array *)seq,
			//       0LL,
			//       (MethodInfo *)P3,
			//       v18);
			//     *index = -1;
			//     if ( !hgCamera
			//       || (HGCamera *)this.fields.m_snowRenderSeqs == v12
			//       || this.fields.m_snowRenderSeqs.fields._size <= (int)v12 )
			//     {
			//       return 0;
			//     }
			//     wrapperArray = this.fields.m_snowRenderSeqs;
			//     while ( 1 )
			//     {
			//       if ( (int)v12 >= wrapperArray.fields._size )
			//         return 0;
			//       if ( (unsigned int)v12 >= wrapperArray.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       items = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray.fields._items;
			//       if ( !items )
			//         goto LABEL_23;
			//       if ( (unsigned int)v12 >= LODWORD(items._0.namespaze) )
			//         goto LABEL_24;
			//       if ( *((_QWORD *)&items._0.byval_arg.data.dummy + (int)v12) )
			//       {
			//         items = (struct ILFixDynamicMethodWrapper_2__Class *)*((_QWORD *)&items._0.byval_arg.data.dummy + (int)v12);
			//         if ( (HGCamera *)items._0.name == hgCamera )
			//           break;
			//       }
			//       v12 = (HGCamera *)(unsigned int)((_DWORD)v12 + 1);
			//     }
			//     if ( (int)v12 <= -1 )
			//       return 0;
			//     if ( wrapperArray )
			//     {
			//       *seq = wrapperArray.fields._items.vector[(int)v12];
			//       sub_1800054D0(
			//         (HGRenderPathScene *)seq,
			//         (HGRenderPathBase_HGRenderPathResources *)wrapperArray,
			//         v11,
			//         v12,
			//         (MethodInfo *)P3a,
			//         v19);
			//       result = 1;
			//       *index = v14;
			//       return result;
			//     }
			// LABEL_23:
			//     sub_180B536AC(items, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(521, 0LL);
			//   if ( !Patch )
			//     goto LABEL_23;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_212(Patch, (Object *)this, (Object *)hgCamera, seq, index, 0LL);
			// }
			// 
			return default(bool);
		}

		public float GetCurrentSnowIntensity(Camera inMainCamera)
		{
			// // Single GetCurrentSnowIntensity(Camera)
			// float HG::Rendering::Runtime::HGSnowRenderer::GetCurrentSnowIntensity(
			//         HGSnowRenderer *this,
			//         Camera *inMainCamera,
			//         MethodInfo *method)
			// {
			//   HGCamera *v5; // rax
			//   __int64 v6; // rdx
			//   SnowCommonRenderingParam *snowCommonRenderingParam; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSnowRenderer_SnowRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919DCC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DCC = 1;
			//   }
			//   seq = 0LL;
			//   index = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1406, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality((Object_1 *)inMainCamera, 0LL, 0LL) )
			//       return 0.0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     v5 = HG::Rendering::Runtime::HGCamera::GetOrCreate(inMainCamera, 0, 0LL);
			//     if ( !HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, v5, &seq, &index, 0LL) )
			//       return 0.0;
			//     if ( seq )
			//     {
			//       snowCommonRenderingParam = seq.fields.snowCommonRenderingParam;
			//       if ( snowCommonRenderingParam )
			//       {
			//         if ( snowCommonRenderingParam.fields.enable )
			//           return snowCommonRenderingParam.fields.intensity;
			//         return 0.0;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(snowCommonRenderingParam, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1406, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
			//            (ILFixDynamicMethodWrapper_20 *)Patch,
			//            (Object *)this,
			//            (Object *)inMainCamera,
			//            0LL);
			// }
			// 
			return 0f;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string EDITOR_KW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly string LIGHTING_KW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly string SNOWFLAKE_KW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly string SNOW_COLLISION_KW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly float UPDATE_DELTA_TIME_THRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		private static readonly float FOV_FADE_HIGHERTHRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly float FOV_FADE_LOWERTHRESHOLD;

		private List<HGSnowRenderer.SnowRenderSeq> m_snowRenderSeqs;

		private SnowCommonPreSettingParam m_snowCommonPreSettingParam;

		private SnowCommonResources m_snowCommonResources;

		private HGSnowRenderer.SnowQualityParams m_qualityParams;

		private class SnowRenderSeq
		{
			public SnowRenderSeq()
			{
				// // Void Reset()
				// void USD::NET::SampleEnumerator<System::Object>::Reset(SampleEnumerator_1_System_Object_ *this, MethodInfo *method)
				// {
				//   this.fields.m_i = -1;
				// }
				// 
			}

			public void CreateDefaultFeatures()
			{
				// // Void CreateDefaultFeatures()
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::CreateDefaultFeatures(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rcx
				//   List_1_System_Object_ *v5; // rdi
				//   HGSceneEffectSnowRenderer *v6; // rax
				//   HGSceneEffectSnowRenderer *v7; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDCAF )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
				//     byte_18D8EDCAF = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(751, 0LL) )
				//   {
				//     subSnowRenderers = this.fields.subSnowRenderers;
				//     if ( subSnowRenderers )
				//     {
				//       sub_1823B99D0(
				//         subSnowRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
				//       v5 = (List_1_System_Object_ *)this.fields.subSnowRenderers;
				//       v6 = (HGSceneEffectSnowRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
				//       v7 = v6;
				//       if ( v6 )
				//       {
				//         HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::HGSceneEffectSnowRenderer(v6, 0LL);
				//         v7.fields._.snowRenderQueue = 3000;
				//         if ( v5 )
				//         {
				//           sub_1822AD140(v5, (Object *)v7);
				//           return;
				//         }
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(subSnowRenderers, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(751, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			public void PrepareResources(SnowCommonResources commonResources)
			{
				// // Void PrepareResources(SnowCommonResources)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PrepareResources(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         SnowCommonResources *commonResources,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   List_1_System_Object_ *subSnowRenderers; // rbx
				//   Object *current; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-48h] BYREF
				//   List_1_T_Enumerator_System_Object_ v13; // [rsp+28h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v14; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D8EDCB0 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//     byte_18D8EDCB0 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(752, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(752, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//       (ILFixDynamicMethodWrapper_37 *)Patch,
				//       (Object *)this,
				//       (Object *)commonResources,
				//       0LL);
				//   }
				//   else
				//   {
				//     subSnowRenderers = (List_1_System_Object_ *)this.fields.subSnowRenderers;
				//     if ( !subSnowRenderers )
				//       sub_180B536AC(v6, v5);
				//     System::Collections::Generic::List<System::Object>::GetEnumerator(
				//       &v13,
				//       subSnowRenderers,
				//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//     v14 = v13;
				//     v13._list = 0LL;
				//     *(_QWORD *)&v13._index = &v14;
				//     try
				//     {
				//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v14,
				//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
				//       {
				//         current = v14._current;
				//         if ( v14._current )
				//         {
				//           sub_180003EE0(v14._current.klass);
				//           ((void (__fastcall *)(Object *, SnowCommonResources *, const char *))current.klass[1]._0.gc_desc)(
				//             current,
				//             commonResources,
				//             current.klass[1]._0.name);
				//         }
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v12 )
				//     {
				//       v13._list = (List_1_System_Object_ *)v12.ex;
				//       if ( v13._list )
				//         sub_18000F780(v13._list);
				//     }
				//   }
				// }
				// 
			}

			public void PerFrameClear()
			{
				// // Void PerFrameClear()
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PerFrameClear(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   PassConstructorID__Enum__Array *v2; // r8
				//   HGCamera *v3; // r9
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
				//   ILFixDynamicMethodWrapper_2__Array *v7; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rax
				//   List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *v12; // rbx
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   __int64 *v15; // rdx
				//   unsigned __int64 v16; // r8
				//   signed __int64 v17; // r9
				//   Object *current; // rdi
				//   __int64 v19; // rbx
				//   void (__fastcall __noreturn **v20)(); // rax
				//   unsigned int v21; // eax
				//   __int64 v22; // rax
				//   unsigned int *v23; // rdx
				//   unsigned int v24; // r8d
				//   __int64 v25; // rtt
				//   __int64 v26; // rbx
				//   __int64 v27; // rax
				//   __int64 v28; // rbx
				//   _QWORD **v29; // rcx
				//   __int64 v30; // r8
				//   __int64 v31; // rax
				//   struct ILFixDynamicMethodWrapper_2__Class *v32; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *v33; // rdx
				//   ILFixDynamicMethodWrapper_2__Array *v34; // rdx
				//   __int64 v35; // rbx
				//   void (__fastcall __noreturn **v36)(); // rax
				//   unsigned int v37; // eax
				//   __int64 v38; // rax
				//   unsigned int *v39; // rdx
				//   unsigned int v40; // r8d
				//   ILFixDynamicMethodWrapper_2__Array__Class *klass; // rtt
				//   __int64 v42; // rbx
				//   __int64 v43; // rax
				//   __int64 v44; // rbx
				//   _QWORD **v45; // rcx
				//   __int64 v46; // r8
				//   __int64 v47; // rax
				//   ILFixDynamicMethodWrapper_2__Array *v48; // rcx
				//   ILFixDynamicMethodWrapper_37 *v49; // rcx
				//   MethodInfo *v50; // [rsp+20h] [rbp-88h]
				//   MethodInfo *v51; // [rsp+28h] [rbp-80h]
				//   Il2CppExceptionWrapper *v52; // [rsp+30h] [rbp-78h] BYREF
				//   int v53; // [rsp+38h] [rbp-70h] BYREF
				//   int v54; // [rsp+48h] [rbp-60h] BYREF
				//   _BYTE v55[24]; // [rsp+58h] [rbp-50h] BYREF
				//   List_1_T_Enumerator_System_Object_ v56; // [rsp+70h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D8EDCB1 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Count);
				//     byte_18D8EDCB1 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v5.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     sub_180B536AC(v5, method);
				//   if ( wrapperArray.max_length.size <= 631 )
				//     goto LABEL_120;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v7 = v5.static_fields.wrapperArray;
				//   if ( !v7 )
				//     sub_180B536AC(v5, method);
				//   if ( v7.max_length.size <= 0x277u )
				//     sub_180070270(v5, method);
				//   if ( v7[17].vector[19] )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(631, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				// LABEL_120:
				//     if ( this.fields.subSnowRenderers )
				//     {
				//       subSnowRenderers = this.fields.subSnowRenderers;
				//       if ( subSnowRenderers.fields._size > 0 )
				//       {
				//         v12 = this.fields.subSnowRenderers;
				//         *(_OWORD *)&v55[8] = 0LL;
				//         *(_QWORD *)v55 = subSnowRenderers;
				//         sub_1800054D0((HGRenderPathScene *)v55, (HGRenderPathBase_HGRenderPathResources *)method, v2, v3, v50, v51);
				//         *(_DWORD *)&v55[8] = 0;
				//         if ( !v12 )
				//           sub_180B536AC(v14, v13);
				//         *(_DWORD *)&v55[12] = v12.fields._version;
				//         *(_QWORD *)&v55[16] = 0LL;
				//         *(_OWORD *)&v56._list = *(_OWORD *)v55;
				//         v56._current = 0LL;
				//         *(_QWORD *)v55 = 0LL;
				//         *(_QWORD *)&v55[8] = &v56;
				//         try
				//         {
				//           while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                     &v56,
				//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
				//           {
				//             current = v56._current;
				//             if ( v56._current )
				//             {
				//               if ( !byte_18D8EDC37 )
				//               {
				//                 v16 = _InterlockedExchangeAdd64(
				//                         (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                         0LL);
				//                 if ( (v16 & 1) != 0 )
				//                 {
				//                   v19 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
				//                   switch ( (unsigned int)v16 >> 29 )
				//                   {
				//                     case 1u:
				//                       v20 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v19);
				//                       goto LABEL_51;
				//                     case 2u:
				//                       v20 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v19);
				//                       goto LABEL_51;
				//                     case 3u:
				//                     case 6u:
				//                       v21 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
				//                       v16 = (unsigned int)v16 >> 29;
				//                       if ( (_DWORD)v16 )
				//                       {
				//                         if ( (_DWORD)v16 == 3 )
				//                         {
				//                           v20 = (void (__fastcall __noreturn **)())sub_180039480(v21);
				//                           goto LABEL_51;
				//                         }
				//                         if ( (_DWORD)v16 == 6 )
				//                         {
				//                           v22 = sub_1802DF9C0(v21);
				//                           v20 = (void (__fastcall __noreturn **)())sub_18005F4B0(v22, 0LL);
				//                           goto LABEL_51;
				//                         }
				//                       }
				//                       else if ( v21 == 1 )
				//                       {
				//                         v20 = off_18A2C5600;
				//                         goto LABEL_51;
				//                       }
				// LABEL_50:
				//                       v20 = 0LL;
				// LABEL_51:
				//                       if ( v20 )
				//                         _InterlockedExchange64(
				//                           (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                           (__int64)v20);
				//                       break;
				//                     case 4u:
				//                       v20 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v19);
				//                       goto LABEL_51;
				//                     case 5u:
				//                       if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v19) )
				//                       {
				//                         v20 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v19);
				//                       }
				//                       else
				//                       {
				//                         v23 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v19);
				//                         v17 = il2cpp_string_new_len(
				//                                 qword_18D8E5198 + (int)v23[1] + *(int *)(qword_18D8E51A0 + 16),
				//                                 *v23);
				//                         v20 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                                    (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v19),
				//                                                                    v17,
				//                                                                    0LL);
				//                         if ( !v20 )
				//                         {
				//                           v16 = qword_18D8F6F98 + 8 * v19;
				//                           if ( dword_18D8E43F8 )
				//                           {
				//                             v24 = (v16 >> 12) & 0x1FFFFF;
				//                             v15 = &qword_18D6870D0[(unsigned __int64)v24 >> 6];
				//                             v16 = v24 & 0x3F;
				//                             _m_prefetchw(v15);
				//                             do
				//                               v25 = *v15;
				//                             while ( v25 != _InterlockedCompareExchange64(v15, *v15 | (1LL << v16), *v15) );
				//                           }
				//                           v20 = (void (__fastcall __noreturn **)())v17;
				//                         }
				//                       }
				//                       goto LABEL_51;
				//                     case 7u:
				//                       v26 = sub_1802DF920((unsigned int)v19);
				//                       v27 = *(_QWORD *)(v26 + 16);
				//                       v28 = (v26 - *(_QWORD *)(v27 + 128)) >> 5;
				//                       if ( *(_BYTE *)(v27 + 42) == 21 )
				//                       {
				//                         v29 = *(_QWORD ***)(v27 + 96);
				//                         if ( *v29 )
				//                         {
				//                           v30 = **v29 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                           v27 = sub_180039550(v30 / 92 + v30);
				//                         }
				//                         else
				//                         {
				//                           v27 = 0LL;
				//                         }
				//                       }
				//                       v53 = v28 + *(_DWORD *)(*(_QWORD *)(v27 + 104) + 32LL);
				//                       v31 = sub_1801B8ECC(
				//                               (unsigned int)&v53,
				//                               (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                               *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                               12,
				//                               (__int64)sub_1802C7760);
				//                       if ( !v31 )
				//                         goto LABEL_50;
				//                       v15 = (__int64 *)*(unsigned int *)(v31 + 8);
				//                       if ( (_DWORD)v15 == -1 )
				//                         goto LABEL_50;
				//                       v20 = (void (__fastcall __noreturn **)())((char *)v15
				//                                                               + qword_18D8E5198
				//                                                               + *(int *)(qword_18D8E51A0 + 72));
				//                       goto LABEL_51;
				//                     default:
				//                       break;
				//                   }
				//                 }
				//                 byte_18D8EDC37 = 1;
				//               }
				//               v32 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//               {
				//                 il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v15);
				//                 v32 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               }
				//               v33 = v32.static_fields.wrapperArray;
				//               if ( !v33 )
				//                 sub_1802DC2C8(v32, 0LL);
				//               if ( v33.max_length.size > 632 )
				//               {
				//                 if ( !v32._1.cctor_finished_or_no_cctor )
				//                 {
				//                   il2cpp_runtime_class_init_0(v32, v33);
				//                   v32 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                 }
				//                 v34 = v32.static_fields.wrapperArray;
				//                 if ( !v34 )
				//                   sub_1802DC2C8(v32, 0LL);
				//                 if ( v34.max_length.size <= 0x278u )
				//                   sub_180070260(v32, v34, v16, v17);
				//                 if ( v34[17].vector[20] )
				//                 {
				//                   if ( !byte_18D919D50 )
				//                   {
				//                     v16 = _InterlockedExchangeAdd64(
				//                             (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                             0LL);
				//                     if ( (v16 & 1) != 0 )
				//                     {
				//                       v35 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
				//                       switch ( (unsigned int)v16 >> 29 )
				//                       {
				//                         case 1u:
				//                           v36 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v35);
				//                           goto LABEL_91;
				//                         case 2u:
				//                           v36 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v35);
				//                           goto LABEL_91;
				//                         case 3u:
				//                         case 6u:
				//                           v37 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
				//                           v16 = (unsigned int)v16 >> 29;
				//                           if ( (_DWORD)v16 )
				//                           {
				//                             if ( (_DWORD)v16 == 3 )
				//                             {
				//                               v36 = (void (__fastcall __noreturn **)())sub_180039480(v37);
				//                               goto LABEL_91;
				//                             }
				//                             if ( (_DWORD)v16 == 6 )
				//                             {
				//                               v38 = sub_1802DF9C0(v37);
				//                               v36 = (void (__fastcall __noreturn **)())sub_18005F4B0(v38, 0LL);
				//                               goto LABEL_91;
				//                             }
				//                           }
				//                           else if ( v37 == 1 )
				//                           {
				//                             v36 = off_18A2C5600;
				//                             goto LABEL_91;
				//                           }
				// LABEL_90:
				//                           v36 = 0LL;
				// LABEL_91:
				//                           if ( v36 )
				//                             _InterlockedExchange64(
				//                               (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                               (__int64)v36);
				//                           break;
				//                         case 4u:
				//                           v36 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v35);
				//                           goto LABEL_91;
				//                         case 5u:
				//                           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v35) )
				//                           {
				//                             v36 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v35);
				//                           }
				//                           else
				//                           {
				//                             v39 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v35);
				//                             v17 = il2cpp_string_new_len(
				//                                     qword_18D8E5198 + (int)v39[1] + *(int *)(qword_18D8E51A0 + 16),
				//                                     *v39);
				//                             v36 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                                        (volatile signed __int64 *)(qword_18D8F6F98
				//                                                                                                  + 8 * v35),
				//                                                                        v17,
				//                                                                        0LL);
				//                             if ( !v36 )
				//                             {
				//                               v16 = qword_18D8F6F98 + 8 * v35;
				//                               if ( dword_18D8E43F8 )
				//                               {
				//                                 v40 = (v16 >> 12) & 0x1FFFFF;
				//                                 v34 = (ILFixDynamicMethodWrapper_2__Array *)&qword_18D6870D0[(unsigned __int64)v40 >> 6];
				//                                 v16 = v40 & 0x3F;
				//                                 _m_prefetchw(v34);
				//                                 do
				//                                   klass = v34.klass;
				//                                 while ( klass != (ILFixDynamicMethodWrapper_2__Array__Class *)_InterlockedCompareExchange64(
				//                                                                                                 (volatile signed __int64 *)v34,
				//                                                                                                 (__int64)v34.klass | (1LL << v16),
				//                                                                                                 (signed __int64)v34.klass) );
				//                               }
				//                               v36 = (void (__fastcall __noreturn **)())v17;
				//                             }
				//                           }
				//                           goto LABEL_91;
				//                         case 7u:
				//                           v42 = sub_1802DF920((unsigned int)v35);
				//                           v43 = *(_QWORD *)(v42 + 16);
				//                           v44 = (v42 - *(_QWORD *)(v43 + 128)) >> 5;
				//                           if ( *(_BYTE *)(v43 + 42) == 21 )
				//                           {
				//                             v45 = *(_QWORD ***)(v43 + 96);
				//                             if ( *v45 )
				//                             {
				//                               v46 = **v45 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                               v43 = sub_180039550(v46 / 92 + v46);
				//                             }
				//                             else
				//                             {
				//                               v43 = 0LL;
				//                             }
				//                           }
				//                           v54 = v44 + *(_DWORD *)(*(_QWORD *)(v43 + 104) + 32LL);
				//                           v47 = sub_1801B8ECC(
				//                                   (unsigned int)&v54,
				//                                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                                   12,
				//                                   (__int64)sub_1802C7760);
				//                           if ( !v47 )
				//                             goto LABEL_90;
				//                           v34 = (ILFixDynamicMethodWrapper_2__Array *)*(unsigned int *)(v47 + 8);
				//                           if ( (_DWORD)v34 == -1 )
				//                             goto LABEL_90;
				//                           v36 = (void (__fastcall __noreturn **)())((char *)v34
				//                                                                   + qword_18D8E5198
				//                                                                   + *(int *)(qword_18D8E51A0 + 72));
				//                           goto LABEL_91;
				//                         default:
				//                           break;
				//                       }
				//                     }
				//                     byte_18D919D50 = 1;
				//                     v32 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   }
				//                   if ( !v32._1.cctor_finished_or_no_cctor )
				//                   {
				//                     il2cpp_runtime_class_init_0(v32, v34);
				//                     v32 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   }
				//                   v48 = v32.static_fields.wrapperArray;
				//                   if ( !v48 )
				//                     sub_1802DC2C8(0LL, v34);
				//                   if ( v48.max_length.size <= 0x278u )
				//                     sub_180070260(v48, v34, v16, v17);
				//                   v49 = (ILFixDynamicMethodWrapper_37 *)v48[17].vector[20];
				//                   if ( !v49 )
				//                     sub_1802DC2C8(0LL, v34);
				//                   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(v49, current, 0LL);
				//                 }
				//               }
				//             }
				//           }
				//         }
				//         catch ( Il2CppExceptionWrapper *v52 )
				//         {
				//           *(Il2CppExceptionWrapper *)v55 = (Il2CppExceptionWrapper)v52.ex;
				//           if ( *(_QWORD *)v55 )
				//             sub_18000F780(*(_QWORD *)v55);
				//         }
				//       }
				//     }
				//   }
				// }
				// 
			}

			public void Dispose()
			{
				// // Void Dispose()
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   HGSnowRenderer_SnowRenderSeq *v2; // rdi
				//   Object *current; // rbx
				//   List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   Il2CppExceptionWrapper *v8; // [rsp+20h] [rbp-48h] BYREF
				//   List_1_T_Enumerator_System_Object_ v9; // [rsp+28h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v10; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   v2 = this;
				//   if ( !byte_18D8EDCB2 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Count);
				//     byte_18D8EDCB2 = 1;
				//   }
				//   memset(&v10, 0, sizeof(v10));
				//   if ( IFix::WrappersManagerImpl::IsPatched(496, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(496, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
				//   }
				//   else
				//   {
				//     if ( v2.fields.subSnowRenderers && v2.fields.subSnowRenderers.fields._size > 0 )
				//     {
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         &v9,
				//         (List_1_System_Object_ *)v2.fields.subSnowRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//       v10 = v9;
				//       v9._list = 0LL;
				//       *(_QWORD *)&v9._index = &v10;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v10,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
				//         {
				//           current = v10._current;
				//           if ( v10._current )
				//           {
				//             sub_180003EE0(v10._current.klass);
				//             ((void (__fastcall *)(Object *, const PropertyInfo *))current.klass[1]._0.events)(
				//               current,
				//               current.klass[1]._0.properties);
				//           }
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v8 )
				//       {
				//         v9._list = (List_1_System_Object_ *)v8.ex;
				//         if ( v9._list )
				//           sub_18000F780(v9._list);
				//         v2 = this;
				//       }
				//     }
				//     subSnowRenderers = v2.fields.subSnowRenderers;
				//     if ( subSnowRenderers )
				//       sub_1823B99D0(
				//         subSnowRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
				//   }
				// }
				// 
			}

			private void _UpdateDeltaTime()
			{
				// // Void _UpdateDeltaTime()
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateDeltaTime(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   __int64 v5; // rdx
				//   float time; // xmm0_4
				//   struct HGSnowRenderer__Class *v7; // rcx
				//   float v8; // xmm6_4
				//   float m_lastTime; // xmm7_4
				//   HGSnowRenderer__StaticFields *static_fields; // rax
				//   float UPDATE_DELTA_TIME_THRESHOLD; // xmm0_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDCB3 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
				//     byte_18D8EDCB3 = 1;
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
				//     goto LABEL_18;
				//   if ( wrapperArray.max_length.size > 754 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x2F2 )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !v3[16]._0.this_arg.data.dummy )
				//         goto LABEL_9;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(754, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//         return;
				//       }
				//     }
				// LABEL_18:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				// LABEL_9:
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, wrapperArray);
				//   time = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
				//   v7 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
				//   v8 = time;
				//   m_lastTime = this.fields.m_lastTime;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer, v5);
				//     v7 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
				//   }
				//   static_fields = v7.static_fields;
				//   UPDATE_DELTA_TIME_THRESHOLD = v8 - m_lastTime;
				//   if ( (float)-static_fields.UPDATE_DELTA_TIME_THRESHOLD > (float)(v8 - m_lastTime) )
				//   {
				//     UPDATE_DELTA_TIME_THRESHOLD = -static_fields.UPDATE_DELTA_TIME_THRESHOLD;
				//   }
				//   else if ( UPDATE_DELTA_TIME_THRESHOLD > static_fields.UPDATE_DELTA_TIME_THRESHOLD )
				//   {
				//     UPDATE_DELTA_TIME_THRESHOLD = static_fields.UPDATE_DELTA_TIME_THRESHOLD;
				//   }
				//   this.fields.m_lastTime = v8;
				//   this.fields.m_deltaTime = UPDATE_DELTA_TIME_THRESHOLD;
				// }
				// 
			}

			public void UpdateSnowDataSeq(HGSnowRenderer.SnowQualityParams qualityParams, ref ScriptableRenderContext renderContext)
			{
				// // Void UpdateSnowDataSeq(HGSnowRenderer+SnowQualityParams, ScriptableRenderContext ByRef)
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::UpdateSnowDataSeq(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         HGSnowRenderer_SnowQualityParams *qualityParams,
				//         ScriptableRenderContext *renderContext,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, qualityParams);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v7.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_8;
				//   if ( wrapperArray.max_length.size <= 753 )
				//   {
				// LABEL_7:
				//     HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateDeltaTime(this, 0LL);
				//     HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
				//       this,
				//       this.fields.m_deltaTime,
				//       qualityParams,
				//       renderContext,
				//       0LL);
				//     HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_RequestOcclusionMap(this, 0LL);
				//     return;
				//   }
				//   if ( !v7._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v7, wrapperArray);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
				//   if ( !v7 )
				//     goto LABEL_8;
				//   if ( LODWORD(v7._0.namespaze) <= 0x2F1 )
				//     sub_180070270(v7, wrapperArray);
				//   if ( !*((_QWORD *)&v7[16]._0.byval_arg + 1) )
				//     goto LABEL_7;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(753, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(v7, wrapperArray);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(Patch, (Object *)this, (Object *)qualityParams, renderContext, 0LL);
				// }
				// 
			}

			private void _PrepareSnowRenderData(float deltaTime, HGSnowRenderer.SnowQualityParams qualityParams, ref ScriptableRenderContext renderContext)
			{
				// // Void _PrepareSnowRenderData(Single, HGSnowRenderer+SnowQualityParams, ScriptableRenderContext ByRef)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         float deltaTime,
				//         HGSnowRenderer_SnowQualityParams *qualityParams,
				//         ScriptableRenderContext *renderContext,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
				//   ILFixDynamicMethodWrapper_2__Array *v11; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
				//   __int64 v16; // rcx
				//   PassConstructorID__Enum__Array *v17; // r8
				//   HGCamera *v18; // r9
				//   List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rbx
				//   unsigned __int64 v20; // rdx
				//   __int64 v21; // rcx
				//   unsigned __int64 v22; // r8
				//   signed __int64 v23; // r9
				//   Object *current; // rdi
				//   SnowCommonRenderingParam *snowCommonRenderingParam; // rax
				//   __int64 v26; // rbx
				//   void (__fastcall __noreturn **v27)(); // rax
				//   unsigned int v28; // eax
				//   __int64 v29; // rax
				//   unsigned int v30; // r8d
				//   signed __int64 v31; // rtt
				//   __int64 v32; // rbx
				//   __int64 v33; // rax
				//   __int64 v34; // rbx
				//   _QWORD **v35; // rcx
				//   __int64 v36; // r8
				//   __int64 v37; // rax
				//   struct ILFixDynamicMethodWrapper_2__Class *v38; // rcx
				//   unsigned __int64 v39; // rdx
				//   __int64 v40; // rbx
				//   void (__fastcall __noreturn **v41)(); // rax
				//   unsigned int v42; // eax
				//   __int64 v43; // rax
				//   unsigned int v44; // r8d
				//   signed __int64 v45; // rtt
				//   __int64 v46; // rbx
				//   __int64 v47; // rax
				//   __int64 v48; // rbx
				//   _QWORD **v49; // rcx
				//   __int64 v50; // r8
				//   __int64 v51; // rax
				//   ILFixDynamicMethodWrapper_2__Array *v52; // rcx
				//   ILFixDynamicMethodWrapper_27 *v53; // rcx
				//   SnowCommonRenderingParam **p_snowCommonRenderingParam; // rbx
				//   HGCamera *hgCamera; // rsi
				//   __int64 v56; // rdx
				//   __int64 v57; // rcx
				//   MethodInfo *P3; // [rsp+20h] [rbp-98h]
				//   ScriptableRenderContext *P3a; // [rsp+20h] [rbp-98h]
				//   MethodInfo *v60; // [rsp+28h] [rbp-90h]
				//   Il2CppExceptionWrapper *v61; // [rsp+38h] [rbp-80h] BYREF
				//   int v62; // [rsp+40h] [rbp-78h] BYREF
				//   int v63; // [rsp+50h] [rbp-68h] BYREF
				//   _BYTE v64[24]; // [rsp+60h] [rbp-58h] BYREF
				//   List_1_T_Enumerator_System_Object_ v65; // [rsp+78h] [rbp-40h] BYREF
				// 
				//   if ( !byte_18D8EDCB4 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
				//     byte_18D8EDCB4 = 1;
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
				//     sub_180B536AC(v9, v5);
				//   if ( wrapperArray.max_length.size > 755 )
				//   {
				//     if ( !v9._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v9, v5);
				//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v11 = v9.static_fields.wrapperArray;
				//     if ( !v11 )
				//       sub_180B536AC(v9, v5);
				//     if ( v11.max_length.size <= 0x2F3u )
				//       sub_180070270(v9, v5);
				//     if ( v11[21].max_length.value )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(755, 0LL);
				//       if ( !Patch )
				//         sub_180B536AC(v14, v13);
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_283(
				//         Patch,
				//         (Object *)this,
				//         deltaTime,
				//         (Object *)qualityParams,
				//         renderContext,
				//         0LL);
				//       return;
				//     }
				//   }
				//   HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateSnowCommonParams(this, deltaTime, qualityParams, 0LL);
				//   subSnowRenderers = this.fields.subSnowRenderers;
				//   if ( !subSnowRenderers )
				//     sub_180B536AC(v16, v15);
				//   *(_OWORD *)&v64[8] = 0LL;
				//   *(_QWORD *)v64 = subSnowRenderers;
				//   sub_1800054D0((HGRenderPathScene *)v64, v15, v17, v18, P3, v60);
				//   *(_DWORD *)&v64[8] = 0;
				//   *(_DWORD *)&v64[12] = subSnowRenderers.fields._version;
				//   *(_QWORD *)&v64[16] = 0LL;
				//   *(_OWORD *)&v65._list = *(_OWORD *)v64;
				//   v65._current = 0LL;
				//   *(_QWORD *)v64 = 0LL;
				//   *(_QWORD *)&v64[8] = &v65;
				//   try
				//   {
				//     while ( 1 )
				//     {
				//       if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//               &v65,
				//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
				//         return;
				//       current = v65._current;
				//       snowCommonRenderingParam = this.fields.snowCommonRenderingParam;
				//       if ( !snowCommonRenderingParam )
				//         sub_1802DC2C8(v21, v20);
				//       if ( snowCommonRenderingParam.fields.enable )
				//       {
				//         if ( !v65._current )
				//           sub_1802DC2C8(v21, v20);
				//         *(float *)&P3a = deltaTime;
				//         sub_180835B78(v21, v65._current, (_DWORD)this + 40, this.fields.hgCamera, (__int64)P3a);
				//         if ( !current )
				//           sub_1802DC2C8(v57, v56);
				//         sub_18052EA20(v57, current, &this.fields.snowCommonRenderingParam, renderContext);
				//       }
				//       else
				//       {
				//         if ( !v65._current )
				//           sub_1802DC2C8(v21, v20);
				//         if ( !byte_18D8EDC37 )
				//         {
				//           v22 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
				//           if ( (v22 & 1) != 0 )
				//           {
				//             v26 = ((unsigned int)v22 >> 1) & 0xFFFFFFF;
				//             switch ( (unsigned int)v22 >> 29 )
				//             {
				//               case 1u:
				//                 v27 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v26);
				//                 goto LABEL_51;
				//               case 2u:
				//                 v27 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v26);
				//                 goto LABEL_51;
				//               case 3u:
				//               case 6u:
				//                 v28 = ((unsigned int)v22 >> 1) & 0xFFFFFFF;
				//                 v22 = (unsigned int)v22 >> 29;
				//                 if ( (_DWORD)v22 )
				//                 {
				//                   if ( (_DWORD)v22 == 3 )
				//                   {
				//                     v27 = (void (__fastcall __noreturn **)())sub_180039480(v28);
				//                     goto LABEL_51;
				//                   }
				//                   if ( (_DWORD)v22 == 6 )
				//                   {
				//                     v29 = sub_1802DF9C0(v28);
				//                     v27 = (void (__fastcall __noreturn **)())sub_18005F4B0(v29, 0LL);
				//                     goto LABEL_51;
				//                   }
				//                 }
				//                 else if ( v28 == 1 )
				//                 {
				//                   v27 = off_18A2C5600;
				//                   goto LABEL_51;
				//                 }
				// LABEL_50:
				//                 v27 = 0LL;
				// LABEL_51:
				//                 if ( v27 )
				//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, (__int64)v27);
				//                 break;
				//               case 4u:
				//                 v27 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v26);
				//                 goto LABEL_51;
				//               case 5u:
				//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v26) )
				//                 {
				//                   v27 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v26);
				//                 }
				//                 else
				//                 {
				//                   v23 = il2cpp_string_new_len(
				//                           qword_18D8E5198
				//                         + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v26 + 4)
				//                         + *(int *)(qword_18D8E51A0 + 16),
				//                           *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v26));
				//                   v27 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v26),
				//                                                              v23,
				//                                                              0LL);
				//                   if ( !v27 )
				//                   {
				//                     v22 = qword_18D8F6F98 + 8 * v26;
				//                     if ( dword_18D8E43F8 )
				//                     {
				//                       v30 = (v22 >> 12) & 0x1FFFFF;
				//                       v20 = (unsigned __int64)v30 >> 6;
				//                       v22 = v30 & 0x3F;
				//                       _m_prefetchw(&qword_18D6870D0[v20]);
				//                       do
				//                         v31 = qword_18D6870D0[v20];
				//                       while ( v31 != _InterlockedCompareExchange64(&qword_18D6870D0[v20], v31 | (1LL << v22), v31) );
				//                     }
				//                     v27 = (void (__fastcall __noreturn **)())v23;
				//                   }
				//                 }
				//                 goto LABEL_51;
				//               case 7u:
				//                 v32 = sub_1802DF920((unsigned int)v26);
				//                 v33 = *(_QWORD *)(v32 + 16);
				//                 v34 = (v32 - *(_QWORD *)(v33 + 128)) >> 5;
				//                 if ( *(_BYTE *)(v33 + 42) == 21 )
				//                 {
				//                   v35 = *(_QWORD ***)(v33 + 96);
				//                   if ( *v35 )
				//                   {
				//                     v36 = **v35 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                     v33 = sub_180039550(v36 / 92 + v36);
				//                   }
				//                   else
				//                   {
				//                     v33 = 0LL;
				//                   }
				//                 }
				//                 v62 = v34 + *(_DWORD *)(*(_QWORD *)(v33 + 104) + 32LL);
				//                 v37 = sub_1801B8ECC(
				//                         (unsigned int)&v62,
				//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                         12,
				//                         (__int64)sub_1802C7760);
				//                 if ( !v37 )
				//                   goto LABEL_50;
				//                 v20 = *(unsigned int *)(v37 + 8);
				//                 if ( (_DWORD)v20 == -1 )
				//                   goto LABEL_50;
				//                 v27 = (void (__fastcall __noreturn **)())(v20 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                 goto LABEL_51;
				//               default:
				//                 break;
				//             }
				//           }
				//           byte_18D8EDC37 = 1;
				//         }
				//         v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//         {
				//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v20);
				//           v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//         }
				//         v39 = (unsigned __int64)v38.static_fields.wrapperArray;
				//         if ( !v39 )
				//           sub_1802DC2C8(v38, 0LL);
				//         if ( *(int *)(v39 + 24) > 758 )
				//         {
				//           if ( !v38._1.cctor_finished_or_no_cctor )
				//           {
				//             il2cpp_runtime_class_init_0(v38, v39);
				//             v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//           }
				//           v39 = (unsigned __int64)v38.static_fields.wrapperArray;
				//           if ( !v39 )
				//             sub_1802DC2C8(v38, 0LL);
				//           if ( *(_DWORD *)(v39 + 24) <= 0x2F6u )
				//             sub_180070260(v38, v39, v22, v23);
				//           if ( *(_QWORD *)(v39 + 6096) )
				//           {
				//             if ( !byte_18D919D50 )
				//             {
				//               v22 = _InterlockedExchangeAdd64(
				//                       (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                       0LL);
				//               if ( (v22 & 1) != 0 )
				//               {
				//                 v40 = ((unsigned int)v22 >> 1) & 0xFFFFFFF;
				//                 switch ( (unsigned int)v22 >> 29 )
				//                 {
				//                   case 1u:
				//                     v41 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v40);
				//                     goto LABEL_91;
				//                   case 2u:
				//                     v41 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v40);
				//                     goto LABEL_91;
				//                   case 3u:
				//                   case 6u:
				//                     v42 = ((unsigned int)v22 >> 1) & 0xFFFFFFF;
				//                     v22 = (unsigned int)v22 >> 29;
				//                     if ( (_DWORD)v22 )
				//                     {
				//                       if ( (_DWORD)v22 == 3 )
				//                       {
				//                         v41 = (void (__fastcall __noreturn **)())sub_180039480(v42);
				//                         goto LABEL_91;
				//                       }
				//                       if ( (_DWORD)v22 == 6 )
				//                       {
				//                         v43 = sub_1802DF9C0(v42);
				//                         v41 = (void (__fastcall __noreturn **)())sub_18005F4B0(v43, 0LL);
				//                         goto LABEL_91;
				//                       }
				//                     }
				//                     else if ( v42 == 1 )
				//                     {
				//                       v41 = off_18A2C5600;
				//                       goto LABEL_91;
				//                     }
				// LABEL_90:
				//                     v41 = 0LL;
				// LABEL_91:
				//                     if ( v41 )
				//                       _InterlockedExchange64(
				//                         (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                         (__int64)v41);
				//                     break;
				//                   case 4u:
				//                     v41 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v40);
				//                     goto LABEL_91;
				//                   case 5u:
				//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v40) )
				//                     {
				//                       v41 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v40);
				//                     }
				//                     else
				//                     {
				//                       v23 = il2cpp_string_new_len(
				//                               qword_18D8E5198
				//                             + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v40 + 4)
				//                             + *(int *)(qword_18D8E51A0 + 16),
				//                               *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v40));
				//                       v41 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v40),
				//                                                                  v23,
				//                                                                  0LL);
				//                       if ( !v41 )
				//                       {
				//                         v22 = qword_18D8F6F98 + 8 * v40;
				//                         if ( dword_18D8E43F8 )
				//                         {
				//                           v44 = (v22 >> 12) & 0x1FFFFF;
				//                           v39 = (unsigned __int64)v44 >> 6;
				//                           v22 = v44 & 0x3F;
				//                           _m_prefetchw(&qword_18D6870D0[v39]);
				//                           do
				//                             v45 = qword_18D6870D0[v39];
				//                           while ( v45 != _InterlockedCompareExchange64(&qword_18D6870D0[v39], v45 | (1LL << v22), v45) );
				//                         }
				//                         v41 = (void (__fastcall __noreturn **)())v23;
				//                       }
				//                     }
				//                     goto LABEL_91;
				//                   case 7u:
				//                     v46 = sub_1802DF920((unsigned int)v40);
				//                     v47 = *(_QWORD *)(v46 + 16);
				//                     v48 = (v46 - *(_QWORD *)(v47 + 128)) >> 5;
				//                     if ( *(_BYTE *)(v47 + 42) == 21 )
				//                     {
				//                       v49 = *(_QWORD ***)(v47 + 96);
				//                       if ( *v49 )
				//                       {
				//                         v50 = **v49 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                         v47 = sub_180039550(v50 / 92 + v50);
				//                       }
				//                       else
				//                       {
				//                         v47 = 0LL;
				//                       }
				//                     }
				//                     v63 = v48 + *(_DWORD *)(*(_QWORD *)(v47 + 104) + 32LL);
				//                     v51 = sub_1801B8ECC(
				//                             (unsigned int)&v63,
				//                             (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                             *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                             12,
				//                             (__int64)sub_1802C7760);
				//                     if ( !v51 )
				//                       goto LABEL_90;
				//                     v39 = *(unsigned int *)(v51 + 8);
				//                     if ( (_DWORD)v39 == -1 )
				//                       goto LABEL_90;
				//                     v41 = (void (__fastcall __noreturn **)())(v39 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                     goto LABEL_91;
				//                   default:
				//                     break;
				//                 }
				//               }
				//               byte_18D919D50 = 1;
				//               v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//             }
				//             if ( !v38._1.cctor_finished_or_no_cctor )
				//             {
				//               il2cpp_runtime_class_init_0(v38, v39);
				//               v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//             }
				//             v52 = v38.static_fields.wrapperArray;
				//             if ( !v52 )
				//               sub_1802DC2C8(0LL, v39);
				//             if ( v52.max_length.size <= 0x2F6u )
				//               sub_180070260(v52, v39, v22, v23);
				//             v53 = (ILFixDynamicMethodWrapper_27 *)v52[21].vector[2];
				//             if ( !v53 )
				//               sub_1802DC2C8(0LL, v39);
				//             if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(v53, current, 0LL) )
				//             {
				//               if ( !current )
				//                 sub_1802DC2C8(v38, v39);
				//               HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::ClearData((HGBaseSubSnowRenderer *)current, 0LL);
				//               p_snowCommonRenderingParam = &this.fields.snowCommonRenderingParam;
				//               hgCamera = this.fields.hgCamera;
				//               goto LABEL_106;
				//             }
				//           }
				//         }
				//       }
				//       p_snowCommonRenderingParam = &this.fields.snowCommonRenderingParam;
				//       hgCamera = this.fields.hgCamera;
				//       if ( !current )
				//         sub_1802DC2C8(v38, v39);
				// LABEL_106:
				//       sub_180003EE0(current.klass);
				//       ((void (__fastcall *)(Object *, SnowCommonRenderingParam **, HGCamera *, Il2CppClass *))current.klass[1]._0.castClass)(
				//         current,
				//         p_snowCommonRenderingParam,
				//         hgCamera,
				//         current.klass[1]._0.declaringType);
				//     }
				//   }
				//   catch ( Il2CppExceptionWrapper *v61 )
				//   {
				//     *(Il2CppExceptionWrapper *)v64 = (Il2CppExceptionWrapper)v61.ex;
				//     if ( *(_QWORD *)v64 )
				//       sub_18000F780(*(_QWORD *)v64);
				//   }
				// }
				// 
			}

			private void _UpdateSnowCommonParams(float deltaTime, HGSnowRenderer.SnowQualityParams qualityParams)
			{
				// // Void _UpdateSnowCommonParams(Single, HGSnowRenderer+SnowQualityParams)
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateSnowCommonParams(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         float deltaTime,
				//         HGSnowRenderer_SnowQualityParams *qualityParams,
				//         MethodInfo *method)
				// {
				//   __int64 v4; // rdx
				//   unsigned __int64 static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   Object *hgCamera; // rdi
				//   Object__Class *klass; // rax
				//   HGEnvironmentPhase *name; // rax
				//   __m128 v13; // xmm6
				//   __m128 v14; // xmm9
				//   __int64 v15; // xmm0_8
				//   __m128 v16; // xmm7
				//   __m128 v17; // xmm10
				//   HGCamera *v18; // rax
				//   Object *camera; // rdi
				//   HGCamera *v20; // rax
				//   Camera *v21; // rdi
				//   unsigned __int8 (__fastcall *v22)(Camera *, int *, HGSnowRenderer_SnowQualityParams *, MethodInfo *); // rax
				//   HGCamera *v23; // rax
				//   Camera *v24; // rdi
				//   double (__fastcall *v25)(Camera *); // rax
				//   __int64 v26; // rdx
				//   double v27; // xmm0_8
				//   struct HGSnowRenderer__Class *v28; // rcx
				//   float v29; // xmm8_4
				//   float v30; // xmm8_4
				//   float v31; // xmm2_4
				//   SnowCommonRenderingParam *v32; // rax
				//   SnowCommonRenderingParam *v33; // rax
				//   SnowCommonRenderingParam *v34; // rax
				//   SnowCommonRenderingParam *v35; // rax
				//   SnowCommonRenderingParam *v36; // rax
				//   SnowCommonRenderingParam *v37; // rax
				//   SnowCommonRenderingParam *v38; // rax
				//   SnowCommonRenderingParam *v39; // rax
				//   SnowCommonRenderingParam *v40; // rax
				//   SnowCommonRenderingParam *v41; // rax
				//   SnowCommonRenderingParam *v42; // rax
				//   SnowCommonRenderingParam *v43; // rax
				//   SnowCommonRenderingParam *v44; // rax
				//   __int64 v45; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v47; // rax
				//   ILFixDynamicMethodWrapper_2 *v48; // rax
				//   __int64 v49; // rax
				//   ILFixDynamicMethodWrapper_2 *v50; // rax
				//   SnowCommonRenderingParam *snowCommonRenderingParam; // rax
				//   __int64 v52; // rax
				//   __int64 v53; // rax
				//   HGCamera *v54; // rax
				//   Transform *transform; // rax
				//   Vector3 *position; // rax
				//   MethodInfo *v57; // r9
				//   __int64 v58; // xmm6_8
				//   float z; // edi
				//   __int64 v60; // xmm0_8
				//   Vector3 *v61; // rax
				//   __m128 v62; // xmm3
				//   float v63; // xmm1_4
				//   SnowCommonRenderingParam *v64; // rax
				//   __int64 v65; // rax
				//   __int64 v66; // xmm0_8
				//   MethodInfo *v67; // r9
				//   Vector3 *v68; // rax
				//   __int64 v69; // xmm3_8
				//   __int64 v70; // rax
				//   __int64 v71; // xmm7_8
				//   float v72; // esi
				//   SnowCommonRenderingParam *v73; // rax
				//   SnowCommonRenderingParam *v74; // rax
				//   SnowCommonPreSettingParam *snowCommonPreSettingParam; // rax
				//   MethodInfo *v76; // r9
				//   float v77; // xmm0_4
				//   SnowCommonRenderingParam *v78; // rdi
				//   float v79; // eax
				//   Vector3 *v80; // rax
				//   __int64 v81; // xmm3_8
				//   MethodInfo *v82; // r9
				//   float v83; // xmm4_4
				//   Vector3 *v84; // rax
				//   __int64 v85; // xmm3_8
				//   MethodInfo *v86; // r9
				//   Vector3 *v87; // rax
				//   __int64 v88; // xmm3_8
				//   __int64 v89; // rax
				//   SnowCommonRenderingParam *v90; // rax
				//   SnowCommonRenderingParam *v91; // rax
				//   SnowCommonRenderingParam *v92; // rdi
				//   __int64 v93; // rax
				//   MethodInfo *v94; // r8
				//   SnowCommonRenderingParam *v95; // rax
				//   __int64 v96; // xmm0_8
				//   float v97; // eax
				//   float v98; // xmm1_4
				//   SnowCommonRenderingParam *v99; // rax
				//   Vector3 v100; // [rsp+38h] [rbp-D0h] BYREF
				//   Vector3 v101; // [rsp+48h] [rbp-C0h] BYREF
				//   Vector3 v102; // [rsp+58h] [rbp-B0h] BYREF
				//   Vector3 v103; // [rsp+68h] [rbp-A0h] BYREF
				//   __m256i v104; // [rsp+78h] [rbp-90h]
				//   __int64 v105; // [rsp+B8h] [rbp-50h]
				// 
				//   if ( !byte_18D8EDCB5 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D8EDCB5 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_60;
				//   if ( wrapperArray[6] > 756 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v45 = *(_QWORD *)wrapperArray;
				//     if ( !*(_QWORD *)wrapperArray )
				//       goto LABEL_60;
				//     if ( *(_DWORD *)(v45 + 24) <= 0x2F4u )
				//       goto LABEL_87;
				//     if ( *(_QWORD *)(v45 + 6080) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(756, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
				//           (ILFixDynamicMethodWrapper_4 *)Patch,
				//           (Object *)this,
				//           deltaTime,
				//           (Object *)qualityParams,
				//           0LL);
				//         return;
				//       }
				//       goto LABEL_60;
				//     }
				//   }
				//   hgCamera = (Object *)this.fields.hgCamera;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
				//   if ( !byte_18D8EDC5D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC5D = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_60;
				//   if ( wrapperArray[6] <= 439 )
				//     goto LABEL_117;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v47 = *(_QWORD *)wrapperArray;
				//   if ( !*(_QWORD *)wrapperArray )
				//     goto LABEL_60;
				//   if ( *(_DWORD *)(v47 + 24) <= 0x1B7u )
				//     goto LABEL_87;
				//   if ( *(_QWORD *)(v47 + 3544) )
				//   {
				//     v48 = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
				//     if ( !v48 )
				//       goto LABEL_60;
				//     name = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(v48, hgCamera, 0LL);
				//   }
				//   else
				//   {
				// LABEL_117:
				//     if ( !hgCamera )
				//       goto LABEL_60;
				//     klass = hgCamera[157].klass;
				//     if ( !klass )
				//       goto LABEL_60;
				//     if ( BYTE4(klass._0.byval_arg.data.type) )
				//     {
				//       name = (HGEnvironmentPhase *)klass._0.name;
				//     }
				//     else
				//     {
				//       if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
				//       name = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
				//     }
				//   }
				//   if ( !name )
				//     goto LABEL_60;
				//   v13 = *(__m128 *)&name.fields.snowConfig.enable;
				//   v14 = *(__m128 *)&name.fields.snowConfig.color.g;
				//   v15 = *(_QWORD *)&name.fields.snowConfig.snowDirection.z;
				//   v16 = *(__m128 *)&name.fields.snowConfig.snowSizeRange.y;
				//   v17 = *(__m128 *)&name.fields.snowConfig.snowLightingPercent;
				//   v18 = this.fields.hgCamera;
				//   *(__m128 *)v104.m256i_i8 = v13;
				//   *(__m128 *)&v104.m256i_u64[2] = v14;
				//   v105 = v15;
				//   if ( !v18 )
				//     goto LABEL_60;
				//   camera = (Object *)v18.fields.camera;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_60;
				//   if ( wrapperArray[6] <= 736 )
				//     goto LABEL_33;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v49 = *(_QWORD *)static_fields;
				//   if ( !*(_QWORD *)static_fields )
				//     goto LABEL_60;
				//   if ( *(_DWORD *)(v49 + 24) <= 0x2E0u )
				// LABEL_87:
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( *(_QWORD *)(v49 + 5920) )
				//   {
				//     v50 = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
				//     if ( !v50 )
				//       goto LABEL_60;
				//     if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v50, camera, 0LL) )
				//     {
				//       snowCommonRenderingParam = this.fields.snowCommonRenderingParam;
				//       if ( snowCommonRenderingParam )
				//       {
				//         snowCommonRenderingParam.fields.enable = 0;
				//         return;
				//       }
				//       goto LABEL_60;
				//     }
				//   }
				// LABEL_33:
				//   v20 = this.fields.hgCamera;
				//   if ( !v20 )
				//     goto LABEL_60;
				//   v21 = v20.fields.camera;
				//   if ( !v21 )
				//     goto LABEL_60;
				//   v22 = (unsigned __int8 (__fastcall *)(Camera *, int *, HGSnowRenderer_SnowQualityParams *, MethodInfo *))qword_18D8F41C8;
				//   if ( !qword_18D8F41C8 )
				//   {
				//     v22 = (unsigned __int8 (__fastcall *)(Camera *, int *, HGSnowRenderer_SnowQualityParams *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
				//     if ( !v22 )
				//     {
				//       v52 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
				//       sub_18000F750(v52, 0LL);
				//     }
				//     qword_18D8F41C8 = (__int64)v22;
				//   }
				//   if ( v22(v21, wrapperArray, qualityParams, method) )
				//   {
				//     v31 = 0.0;
				//   }
				//   else
				//   {
				//     v23 = this.fields.hgCamera;
				//     if ( !v23 )
				//       goto LABEL_60;
				//     v24 = v23.fields.camera;
				//     if ( !v24 )
				//       goto LABEL_60;
				//     v25 = (double (__fastcall *)(Camera *))qword_18D8F4198;
				//     if ( !qword_18D8F4198 )
				//     {
				//       v25 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_fieldOfView()");
				//       if ( !v25 )
				//       {
				//         v53 = sub_1802DBBE8("UnityEngine.Camera::get_fieldOfView()");
				//         sub_18000F750(v53, 0LL);
				//       }
				//       qword_18D8F4198 = (__int64)v25;
				//     }
				//     v27 = v25(v24);
				//     v28 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
				//     v29 = *(float *)&v27;
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer, v26);
				//       v28 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
				//     }
				//     v30 = (float)(v29 - v28.static_fields.FOV_FADE_LOWERTHRESHOLD)
				//         / (float)(v28.static_fields.FOV_FADE_HIGHERTHRESHOLD - v28.static_fields.FOV_FADE_LOWERTHRESHOLD);
				//     Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v28);
				//     v31 = v30;
				//   }
				//   static_fields = (unsigned __int64)this.fields.snowCommonRenderingParam;
				//   if ( !static_fields )
				//     goto LABEL_60;
				//   *(_BYTE *)(static_fields + 16) = _mm_cvtsi128_si32((__m128i)v13);
				//   v32 = this.fields.snowCommonRenderingParam;
				//   if ( !v32 )
				//     goto LABEL_60;
				//   v32.fields.intensity = _mm_shuffle_ps(v13, v13, 85).m128_f32[0] * v31;
				//   v33 = this.fields.snowCommonRenderingParam;
				//   if ( !v33 )
				//     goto LABEL_60;
				//   LODWORD(v33.fields.speed) = _mm_shuffle_ps(v13, v13, 170).m128_u32[0];
				//   v34 = this.fields.snowCommonRenderingParam;
				//   if ( !v34 )
				//     goto LABEL_60;
				//   v34.fields.color = *(Color *)((char *)&v104.m256i_u64[1] + 4);
				//   v35 = this.fields.snowCommonRenderingParam;
				//   if ( !v35 )
				//     goto LABEL_60;
				//   v35.fields.color.a = v31 * v35.fields.color.a;
				//   v36 = this.fields.snowCommonRenderingParam;
				//   if ( !v36 )
				//     goto LABEL_60;
				//   LODWORD(v36.fields.snowLightingPercent) = v17.m128_i32[0];
				//   v37 = this.fields.snowCommonRenderingParam;
				//   if ( !v37 )
				//     goto LABEL_60;
				//   LODWORD(v37.fields.snowCollisionFadeTimeScale) = _mm_shuffle_ps(v17, v17, 85).m128_u32[0];
				//   v38 = this.fields.snowCommonRenderingParam;
				//   if ( !v38 )
				//     goto LABEL_60;
				//   LODWORD(v38.fields.snowSizeRange.x) = _mm_shuffle_ps(v14, v14, 255).m128_u32[0];
				//   LODWORD(v38.fields.snowSizeRange.y) = v16.m128_i32[0];
				//   v39 = this.fields.snowCommonRenderingParam;
				//   if ( !qualityParams )
				//     goto LABEL_60;
				//   static_fields = qualityParams.fields.enableSnowLighting;
				//   if ( !v39 )
				//     goto LABEL_60;
				//   v39.fields.enableSnowLighting = static_fields;
				//   v40 = this.fields.snowCommonRenderingParam;
				//   static_fields = qualityParams.fields.enableSnowCollision;
				//   if ( !v40 )
				//     goto LABEL_60;
				//   v40.fields.enableSnowCollision = static_fields;
				//   v41 = this.fields.snowCommonRenderingParam;
				//   if ( !v41 )
				//     goto LABEL_60;
				//   LODWORD(v41.fields.snowJitterLevel) = _mm_shuffle_ps(v16, v16, 255).m128_u32[0];
				//   v42 = this.fields.snowCommonRenderingParam;
				//   static_fields = (unsigned int)qualityParams.fields.snowLayerCount;
				//   if ( !v42 )
				//     goto LABEL_60;
				//   v42.fields.snowLayerCount = static_fields;
				//   v43 = this.fields.snowCommonRenderingParam;
				//   static_fields = (unsigned int)this.fields.cameraMask;
				//   if ( !v43 )
				//     goto LABEL_60;
				//   v43.fields.cameraMask = static_fields;
				//   v44 = this.fields.snowCommonRenderingParam;
				//   if ( !v44 )
				//     goto LABEL_60;
				//   if ( v44.fields.enable )
				//   {
				//     v54 = this.fields.hgCamera;
				//     if ( v54 )
				//     {
				//       static_fields = (unsigned __int64)v54.fields.camera;
				//       if ( static_fields )
				//       {
				//         transform = UnityEngine::Component::get_transform((Component *)static_fields, 0LL);
				//         if ( transform )
				//         {
				//           position = UnityEngine::Transform::get_position(&v101, transform, 0LL);
				//           static_fields = (unsigned __int64)this.fields.snowCommonRenderingParam;
				//           v58 = *(_QWORD *)&position.x;
				//           z = position.z;
				//           if ( static_fields )
				//           {
				//             v60 = *(_QWORD *)(static_fields + 56);
				//             v102.z = *(float *)(static_fields + 64);
				//             *(_QWORD *)&v102.x = v60;
				//             *(_QWORD *)&v100.x = v58;
				//             v100.z = z;
				//             v61 = UnityEngine::Vector3::op_Subtraction(&v101, &v100, &v102, v57);
				//             v62 = (__m128)*(unsigned __int64 *)&v61.x;
				//             v63 = v61.z;
				//             v64 = this.fields.snowCommonRenderingParam;
				//             *(_QWORD *)&v100.x = v62.m128_u64[0];
				//             if ( v64 )
				//             {
				//               static_fields = (unsigned __int64)v64.fields.snowCommonPreSettingParam;
				//               if ( static_fields )
				//               {
				//                 v100.z = v63;
				//                 *(_QWORD *)&v100.x = _mm_unpacklo_ps(v62, (__m128)0LL).m128_u64[0];
				//                 v65 = sub_182AA2B90(&v101, &v100);
				//                 *(_QWORD *)&v102.x = *(_OWORD *)&_mm_unpackhi_pd((__m128d)v17, (__m128d)v17);
				//                 v66 = *(_QWORD *)v65;
				//                 v100.z = *(float *)(v65 + 8);
				//                 LODWORD(v102.z) = v105;
				//                 *(_QWORD *)&v100.x = v66;
				//                 v68 = UnityEngine::Vector3::op_Subtraction(&v101, &v102, &v100, v67);
				//                 v69 = *(_QWORD *)&v68.x;
				//                 *(float *)&v68 = v68.z;
				//                 *(_QWORD *)&v102.x = v69;
				//                 LODWORD(v102.z) = (_DWORD)v68;
				//                 v70 = sub_182413270(&v101, &v102);
				//                 v71 = *(_QWORD *)v70;
				//                 v72 = *(float *)(v70 + 8);
				//                 v73 = this.fields.snowCommonRenderingParam;
				//                 if ( v73 )
				//                 {
				//                   *(_QWORD *)&v73.fields.lastCamPos.x = v58;
				//                   v73.fields.lastCamPos.z = z;
				//                   v74 = this.fields.snowCommonRenderingParam;
				//                   if ( v74 )
				//                   {
				//                     snowCommonPreSettingParam = v74.fields.snowCommonPreSettingParam;
				//                     if ( snowCommonPreSettingParam )
				//                     {
				//                       v77 = HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
				//                               snowCommonPreSettingParam.fields.snowTemporalTimeThreshould,
				//                               deltaTime,
				//                               0LL);
				//                       v78 = this.fields.snowCommonRenderingParam;
				//                       if ( v78 )
				//                       {
				//                         v79 = v78.fields.snowDirection.z;
				//                         *(_QWORD *)&v101.x = *(_QWORD *)&v78.fields.snowDirection.x;
				//                         v101.z = v79;
				//                         *(_QWORD *)&v100.x = v71;
				//                         v100.z = v72;
				//                         v80 = UnityEngine::Vector3::op_Multiply(&v103, &v100, 1.0 - v77, v76);
				//                         v81 = *(_QWORD *)&v80.x;
				//                         *(float *)&v80 = v80.z;
				//                         *(_QWORD *)&v100.x = v81;
				//                         LODWORD(v100.z) = (_DWORD)v80;
				//                         v84 = UnityEngine::Vector3::op_Multiply(&v103, &v101, v83, v82);
				//                         v85 = *(_QWORD *)&v84.x;
				//                         *(float *)&v84 = v84.z;
				//                         *(_QWORD *)&v101.x = v85;
				//                         LODWORD(v101.z) = (_DWORD)v84;
				//                         v87 = UnityEngine::Vector3::op_Addition(&v103, &v101, &v100, v86);
				//                         v88 = *(_QWORD *)&v87.x;
				//                         *(float *)&v87 = v87.z;
				//                         *(_QWORD *)&v102.x = v88;
				//                         LODWORD(v102.z) = (_DWORD)v87;
				//                         v89 = sub_182413270(&v103, &v102);
				//                         static_fields = *(unsigned int *)(v89 + 8);
				//                         *(_QWORD *)&v78.fields.snowDirection.x = *(_QWORD *)v89;
				//                         LODWORD(v78.fields.snowDirection.z) = static_fields;
				//                         v90 = this.fields.snowCommonRenderingParam;
				//                         if ( v90 )
				//                         {
				//                           v90.fields.snowDirection.x = v90.fields.snowDirection.x * 4.0;
				//                           v91 = this.fields.snowCommonRenderingParam;
				//                           if ( v91 )
				//                           {
				//                             v91.fields.snowDirection.z = v91.fields.snowDirection.z * 4.0;
				//                             v92 = this.fields.snowCommonRenderingParam;
				//                             wrapperArray = (int *)v92;
				//                             if ( v92 )
				//                             {
				//                               v93 = sub_182413270(&v103, &v92.fields.snowDirection);
				//                               static_fields = *(unsigned int *)(v93 + 8);
				//                               *(_QWORD *)&v92.fields.snowDirection.x = *(_QWORD *)v93;
				//                               LODWORD(v92.fields.snowDirection.z) = static_fields;
				//                               v95 = this.fields.snowCommonRenderingParam;
				//                               if ( v95 )
				//                               {
				//                                 v101.z = 0.0;
				//                                 *(_QWORD *)&v101.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
				//                                 v96 = *(_QWORD *)&v95.fields.snowDirection.x;
				//                                 v97 = v95.fields.snowDirection.z;
				//                                 *(_QWORD *)&v100.x = v96;
				//                                 v100.z = v97;
				//                                 v98 = 1.0 / fmaxf(fabs(UnityEngine::Vector3::Dot(&v100, &v101, v94)), 0.0099999998);
				//                                 if ( v98 < 1.0 )
				//                                 {
				//                                   v98 = 1.0;
				//                                 }
				//                                 else if ( v98 > 2.0 )
				//                                 {
				//                                   v98 = 2.0;
				//                                 }
				//                                 v99 = this.fields.snowCommonRenderingParam;
				//                                 if ( v99 )
				//                                 {
				//                                   v99.fields.speed = v98 * v99.fields.speed;
				//                                   return;
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
				// LABEL_60:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   }
				// }
				// 
			}

			private void _RequestOcclusionMap()
			{
				// // Void _RequestOcclusionMap()
				// void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_RequestOcclusionMap(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
				//   SnowCommonRenderingParam **static_fields; // rcx
				//   SnowCommonRenderingParam *snowCommonRenderingParam; // rdx
				//   HGCamera *hgCamera; // rbx
				//   HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rbx
				//   SnowCommonRenderingParam__Class *klass; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   SnowCommonRenderingParam__Class *v10; // r8
				//   ILFixDynamicMethodWrapper_2 *v11; // rax
				//   SnowCommonRenderingParam *v12; // rax
				//   ILFixDynamicMethodWrapper_2 *v13; // rax
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
				//   static_fields = (SnowCommonRenderingParam **)v3.static_fields;
				//   snowCommonRenderingParam = *static_fields;
				//   if ( !*static_fields )
				//     goto LABEL_25;
				//   if ( SLODWORD(snowCommonRenderingParam.fields.speed) > 761 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, snowCommonRenderingParam);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     snowCommonRenderingParam = (SnowCommonRenderingParam *)v3.static_fields;
				//     klass = snowCommonRenderingParam.klass;
				//     if ( !snowCommonRenderingParam.klass )
				//       goto LABEL_25;
				//     if ( LODWORD(klass._0.namespaze) <= 0x2F9 )
				//       goto LABEL_47;
				//     if ( klass[16]._0.typeMetadataHandle )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(761, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//         return;
				//       }
				//       goto LABEL_25;
				//     }
				//   }
				//   hgCamera = this.fields.hgCamera;
				//   if ( !hgCamera )
				//     goto LABEL_25;
				//   verticalOcclusionMapManager = hgCamera.fields.verticalOcclusionMapManager;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, snowCommonRenderingParam);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = (SnowCommonRenderingParam **)v3.static_fields;
				//   snowCommonRenderingParam = *static_fields;
				//   if ( !*static_fields )
				//     goto LABEL_25;
				//   if ( SLODWORD(snowCommonRenderingParam.fields.speed) <= 762 )
				//     goto LABEL_14;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, snowCommonRenderingParam);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   snowCommonRenderingParam = (SnowCommonRenderingParam *)v3.static_fields;
				//   v10 = snowCommonRenderingParam.klass;
				//   if ( !snowCommonRenderingParam.klass )
				//     goto LABEL_25;
				//   if ( LODWORD(v10._0.namespaze) <= 0x2FA )
				//     goto LABEL_47;
				//   if ( v10[16]._0.interopData )
				//   {
				//     v11 = IFix::WrappersManagerImpl::GetPatch(762, 0LL);
				//     if ( !v11 )
				//       goto LABEL_25;
				//     static_fields = (SnowCommonRenderingParam **)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
				//                                                    (ILFixDynamicMethodWrapper_27 *)v11,
				//                                                    (Object *)this,
				//                                                    0LL);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   else
				//   {
				// LABEL_14:
				//     snowCommonRenderingParam = this.fields.snowCommonRenderingParam;
				//     if ( !snowCommonRenderingParam )
				//       goto LABEL_25;
				//     static_fields = (SnowCommonRenderingParam **)snowCommonRenderingParam.fields.enable;
				//   }
				//   if ( !verticalOcclusionMapManager )
				//     goto LABEL_25;
				//   if ( !(_BYTE)static_fields )
				//   {
				//     if ( !byte_18D8EDC37 )
				//     {
				//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//       byte_18D8EDC37 = 1;
				//     }
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, snowCommonRenderingParam);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     static_fields = (SnowCommonRenderingParam **)v3.static_fields;
				//     snowCommonRenderingParam = *static_fields;
				//     if ( !*static_fields )
				//       goto LABEL_25;
				//     if ( SLODWORD(snowCommonRenderingParam.fields.speed) <= 749 )
				//     {
				// LABEL_24:
				//       verticalOcclusionMapManager.fields.m_requestType &= ~4u;
				//       return;
				//     }
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, snowCommonRenderingParam);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     static_fields = (SnowCommonRenderingParam **)v3.static_fields;
				//     v12 = *static_fields;
				//     if ( !*static_fields )
				//       goto LABEL_25;
				//     if ( LODWORD(v12.fields.speed) > 0x2ED )
				//     {
				//       if ( !*(_QWORD *)&v12[53].fields.enableSnowLighting )
				//         goto LABEL_24;
				//       v13 = IFix::WrappersManagerImpl::GetPatch(749, 0LL);
				//       if ( v13 )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
				//           (ILFixDynamicMethodWrapper_28 *)v13,
				//           (Object *)verticalOcclusionMapManager,
				//           4,
				//           0LL);
				//         return;
				//       }
				// LABEL_25:
				//       sub_180B536AC(static_fields, snowCommonRenderingParam);
				//     }
				// LABEL_47:
				//     sub_180070270(static_fields, snowCommonRenderingParam);
				//   }
				//   HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
				//     verticalOcclusionMapManager,
				//     HGVerticalOcclusionMapManager_RequestUsageType__Enum_SnowOcclusion,
				//     0LL);
				// }
				// 
			}

			public bool ShouldRequestSnowOcclusionMap()
			{
				// // Boolean ShouldRequestSnowOcclusionMap()
				// bool HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::ShouldRequestSnowOcclusionMap(
				//         HGSnowRenderer_SnowRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   SnowCommonRenderingParam *snowCommonRenderingParam; // rax
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
				//     goto LABEL_9;
				//   if ( wrapperArray.max_length.size <= 762 )
				//     goto LABEL_7;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, wrapperArray);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//   if ( !v3 )
				//     goto LABEL_9;
				//   if ( LODWORD(v3._0.namespaze) <= 0x2FA )
				//     sub_180070270(v3, wrapperArray);
				//   if ( !v3[16]._0.interopData )
				//   {
				// LABEL_7:
				//     snowCommonRenderingParam = this.fields.snowCommonRenderingParam;
				//     if ( snowCommonRenderingParam )
				//       return snowCommonRenderingParam.fields.enable;
				// LABEL_9:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(762, 0LL);
				//   if ( !Patch )
				//     goto LABEL_9;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}

			public HGCamera hgCamera;

			public int cameraMask;

			public List<HGBaseSubSnowRenderer> subSnowRenderers;

			public SnowCommonRenderingParam snowCommonRenderingParam;

			private float m_deltaTime;

			private float m_lastTime;
		}

		private class SnowQualityParams
		{
			public SnowQualityParams()
			{
				// // Primvar`1[System.Object]()
				// void USD::NET::Primvar<System::Object>::Primvar(Primvar_1_System_Object_ *this, MethodInfo *method)
				// {
				//   this.fields._.elementSize = 1;
				// }
				// 
			}

			public bool enableSnowLighting;

			public bool enableSnowCollision;

			public int snowLayerCount;
		}
	}
}
