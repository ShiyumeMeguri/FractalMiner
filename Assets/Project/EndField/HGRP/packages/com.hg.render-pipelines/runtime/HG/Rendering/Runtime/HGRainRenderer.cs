using System;
using System.Collections.Generic;
using HG.Rendering.Runtime.Rain;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGRainRenderer
	{
		public HGRainRenderer()
		{
		}

		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources, HGSettingParameters settingParameters)
		{
			// // Void PrepareResources(HGRenderPipelineRuntimeResources, HGSettingParameters)
			// void HG::Rendering::Runtime::HGRainRenderer::PrepareResources(
			//         HGRainRenderer *this,
			//         HGRenderPipelineRuntimeResources *defaultResources,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *farRainSpindleMesh; // rdx
			//   RainCommonResources *m_rainCommonResources; // rcx
			//   HGRenderPipelineRuntimeResources_AssetResources *assets; // rsi
			//   HGRainPresettingAsset *rainPresettingAsset; // rsi
			//   __int64 v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   HGRenderPipelineRuntimeResources_AssetResources *v14; // rax
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   HGRenderPipelineRuntimeResources_AssetResources *v17; // rax
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   HGRenderPipelineRuntimeResources_AssetResources *v20; // rax
			//   RainCommonResources *v21; // rsi
			//   Mesh *ScreenDropQuadSeq; // rax
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v30; // rax
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v33; // rax
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v36; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodf; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodg; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodh; // [rsp+20h] [rbp-18h]
			//   String *v46; // [rsp+28h] [rbp-10h]
			//   String *v47; // [rsp+28h] [rbp-10h]
			//   String *v48; // [rsp+28h] [rbp-10h]
			//   String *v49; // [rsp+28h] [rbp-10h]
			//   String *v50; // [rsp+28h] [rbp-10h]
			//   String *v51; // [rsp+28h] [rbp-10h]
			//   String *v52; // [rsp+28h] [rbp-10h]
			//   String *v53; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v54; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v55; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v56; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v57; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v58; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v59; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v60; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v61; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDC7F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC7F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1316, 0LL) )
			//   {
			//     if ( defaultResources )
			//     {
			//       assets = defaultResources.fields.assets;
			//       if ( assets )
			//       {
			//         rainPresettingAsset = assets.fields.rainPresettingAsset;
			//         HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//         if ( UnityEngine::Object::op_Inequality(0LL, (Object_1 *)rainPresettingAsset, 0LL) )
			//         {
			//           if ( !rainPresettingAsset )
			//             goto LABEL_27;
			//           this.fields.m_rainCommonPreSettingParam = rainPresettingAsset.fields.rainCommonPreSettingParam;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&this.fields.m_rainCommonPreSettingParam,
			//             farRainSpindleMesh,
			//             v12,
			//             v13,
			//             (String__Array *)methoda,
			//             v46,
			//             v54);
			//         }
			//         v14 = defaultResources.fields.assets;
			//         m_rainCommonResources = this.fields.m_rainCommonResources;
			//         if ( v14 )
			//         {
			//           farRainSpindleMesh = (OneofDescriptorProto *)v14.fields.farRainSpindleMesh;
			//           if ( m_rainCommonResources )
			//           {
			//             m_rainCommonResources.fields.farRainSpindleMesh = (Mesh *)farRainSpindleMesh;
			//             sub_1800054D0(
			//               (OneofDescriptor *)&m_rainCommonResources.fields,
			//               farRainSpindleMesh,
			//               v12,
			//               v13,
			//               (String__Array *)methoda,
			//               v46,
			//               v54);
			//             v17 = defaultResources.fields.assets;
			//             m_rainCommonResources = this.fields.m_rainCommonResources;
			//             if ( v17 )
			//             {
			//               farRainSpindleMesh = (OneofDescriptorProto *)v17.fields.sceneEffectRainMesh;
			//               if ( m_rainCommonResources )
			//               {
			//                 m_rainCommonResources.fields.sceneEffectRainMesh = (Mesh *)farRainSpindleMesh;
			//                 sub_1800054D0(
			//                   (OneofDescriptor *)&m_rainCommonResources.fields.sceneEffectRainMesh,
			//                   farRainSpindleMesh,
			//                   v15,
			//                   v16,
			//                   (String__Array *)methodb,
			//                   v47,
			//                   v55);
			//                 v20 = defaultResources.fields.assets;
			//                 m_rainCommonResources = this.fields.m_rainCommonResources;
			//                 if ( v20 )
			//                 {
			//                   farRainSpindleMesh = (OneofDescriptorProto *)v20.fields.rainSplashMesh;
			//                   if ( m_rainCommonResources )
			//                   {
			//                     m_rainCommonResources.fields.rainSplashMesh = (Mesh *)farRainSpindleMesh;
			//                     sub_1800054D0(
			//                       (OneofDescriptor *)&m_rainCommonResources.fields.rainSplashMesh,
			//                       farRainSpindleMesh,
			//                       v18,
			//                       v19,
			//                       (String__Array *)methodc,
			//                       v48,
			//                       v56);
			//                     v21 = this.fields.m_rainCommonResources;
			//                     ScreenDropQuadSeq = HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropQuadSeq(0LL);
			//                     if ( v21 )
			//                     {
			//                       v21.fields.screenDropFxMesh = ScreenDropQuadSeq;
			//                       sub_1800054D0(
			//                         (OneofDescriptor *)&v21.fields.screenDropFxMesh,
			//                         farRainSpindleMesh,
			//                         v23,
			//                         v24,
			//                         (String__Array *)methodd,
			//                         v49,
			//                         v57);
			//                       shaders = defaultResources.fields.shaders;
			//                       m_rainCommonResources = this.fields.m_rainCommonResources;
			//                       if ( shaders )
			//                       {
			//                         farRainSpindleMesh = (OneofDescriptorProto *)shaders.fields.farRainPS;
			//                         if ( m_rainCommonResources )
			//                         {
			//                           m_rainCommonResources.fields.farRainShader = (Shader *)farRainSpindleMesh;
			//                           sub_1800054D0(
			//                             (OneofDescriptor *)&m_rainCommonResources.fields.farRainShader,
			//                             farRainSpindleMesh,
			//                             v25,
			//                             v26,
			//                             (String__Array *)methode,
			//                             v50,
			//                             v58);
			//                           v30 = defaultResources.fields.shaders;
			//                           m_rainCommonResources = this.fields.m_rainCommonResources;
			//                           if ( v30 )
			//                           {
			//                             farRainSpindleMesh = (OneofDescriptorProto *)v30.fields.sceneEffectRainPS;
			//                             if ( m_rainCommonResources )
			//                             {
			//                               m_rainCommonResources.fields.sceneEffectRainShader = (Shader *)farRainSpindleMesh;
			//                               sub_1800054D0(
			//                                 (OneofDescriptor *)&m_rainCommonResources.fields.sceneEffectRainShader,
			//                                 farRainSpindleMesh,
			//                                 v28,
			//                                 v29,
			//                                 (String__Array *)methodf,
			//                                 v51,
			//                                 v59);
			//                               v33 = defaultResources.fields.shaders;
			//                               m_rainCommonResources = this.fields.m_rainCommonResources;
			//                               if ( v33 )
			//                               {
			//                                 farRainSpindleMesh = (OneofDescriptorProto *)v33.fields.rainSplashShader;
			//                                 if ( m_rainCommonResources )
			//                                 {
			//                                   m_rainCommonResources.fields.rainSplashShader = (Shader *)farRainSpindleMesh;
			//                                   sub_1800054D0(
			//                                     (OneofDescriptor *)&m_rainCommonResources.fields.rainSplashShader,
			//                                     farRainSpindleMesh,
			//                                     v31,
			//                                     v32,
			//                                     (String__Array *)methodg,
			//                                     v52,
			//                                     v60);
			//                                   v36 = defaultResources.fields.shaders;
			//                                   m_rainCommonResources = this.fields.m_rainCommonResources;
			//                                   if ( v36 )
			//                                   {
			//                                     farRainSpindleMesh = (OneofDescriptorProto *)v36.fields.screenRainDropFXShader;
			//                                     if ( m_rainCommonResources )
			//                                     {
			//                                       m_rainCommonResources.fields.screenRainDropFXShader = (Shader *)farRainSpindleMesh;
			//                                       sub_1800054D0(
			//                                         (OneofDescriptor *)&m_rainCommonResources.fields.screenRainDropFXShader,
			//                                         farRainSpindleMesh,
			//                                         v34,
			//                                         v35,
			//                                         (String__Array *)methodh,
			//                                         v53,
			//                                         v61);
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
			// LABEL_27:
			//     sub_180B536AC(m_rainCommonResources, farRainSpindleMesh);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1316, 0LL);
			//   if ( !Patch )
			//     goto LABEL_27;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)defaultResources,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		internal void RainAndWetnessPipelineUpdate(HGSettingParameters settingParameters)
		{
			// // Void RainAndWetnessPipelineUpdate(HGSettingParameters)
			// void HG::Rendering::Runtime::HGRainRenderer::RainAndWetnessPipelineUpdate(
			//         HGRainRenderer *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *items; // rcx
			//   __int64 v6; // rdx
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *m_rainWetnessRenderSeqs; // rbx
			//   int32_t v8; // ebx
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v9; // rax
			//   Camera *camera; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *Item; // rax
			// 
			//   if ( !byte_18D8EDC80 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC80 = 1;
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
			//   if ( *(int *)(v6 + 24) <= 611 )
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
			//   if ( *(_DWORD *)(v6 + 24) <= 0x263u )
			// LABEL_37:
			//     sub_180070270(items, v6);
			//   if ( *(_QWORD *)(v6 + 4920) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(611, 0LL);
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
			//   HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
			//   m_rainWetnessRenderSeqs = this.fields.m_rainWetnessRenderSeqs;
			//   if ( !m_rainWetnessRenderSeqs )
			//     goto LABEL_36;
			//   v8 = m_rainWetnessRenderSeqs.fields._size - 1;
			//   if ( v8 >= 0 )
			//   {
			//     while ( 1 )
			//     {
			//       v9 = this.fields.m_rainWetnessRenderSeqs;
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
			//       HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PerFrameClear(
			//         this.fields.m_rainWetnessRenderSeqs.fields._items.vector[v8],
			//         0LL);
			//       items = (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs;
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
			//       camera = this.fields.m_rainWetnessRenderSeqs.fields._items.vector[v8].fields.hgCamera.fields.camera;
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
			//         items = (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs;
			//         if ( !items )
			//           goto LABEL_36;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  items,
			//                  v8,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Item);
			//         if ( !Item )
			//           goto LABEL_36;
			//         HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
			//           (HGRainRenderer_RainWetnessRenderSeq *)Item,
			//           0LL);
			//         items = (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs;
			//         if ( !items )
			//           goto LABEL_36;
			//         goto LABEL_50;
			//       }
			// LABEL_34:
			//       if ( --v8 < 0 )
			//         return;
			//     }
			//     items = (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs;
			// LABEL_50:
			//     System::Collections::Generic::List<System::Object>::RemoveAt(
			//       items,
			//       v8,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::RemoveAt);
			//     goto LABEL_34;
			//   }
			// }
			// 
		}

		private void _UpdateQualitySettings(HGSettingParameters settingParameters)
		{
			// // Void _UpdateQualitySettings(HGSettingParameters)
			// void HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(
			//         HGRainRenderer *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGRainAndWetnessSettingParameters *rainAndWetness_k__BackingField; // rbx
			//   HGVerticalOcclusionMapSettingParameters *verticalOcclusionMap_k__BackingField; // r15
			//   HGRainRenderer_RainWetnessQualityParams *m_qualityParams; // rbp
			//   SettingParameter_1_System_Boolean_ *EnableRainWetnessHighQuality_k__BackingField; // rdi
			//   struct MethodInfo *v11; // r14
			//   Il2CppClass *klass; // rax
			//   SettingParameter_1_System_Int32_ *RainSplashMaxCount_k__BackingField; // r14
			//   HGRainRenderer_RainWetnessQualityParams *v14; // rdi
			//   struct MethodInfo *v15; // rbp
			//   Il2CppClass *v16; // rax
			//   HGRainRenderer_RainWetnessQualityParams *v17; // r14
			//   SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rdi
			//   struct MethodInfo *v19; // rbp
			//   Il2CppClass *v20; // rax
			//   int v21; // eax
			//   SettingParameter_1_System_Boolean_ *EnableMiddleDistRain_k__BackingField; // r14
			//   HGRainRenderer_RainWetnessQualityParams *v23; // rdi
			//   struct MethodInfo *v24; // rbp
			//   Il2CppClass *v25; // rax
			//   SettingParameter_1_System_Boolean_ *EnableRainWave_k__BackingField; // rbp
			//   HGRainRenderer_RainWetnessQualityParams *v27; // rdi
			//   struct MethodInfo *v28; // r14
			//   Il2CppClass *v29; // rax
			//   SettingParameter_1_System_Boolean_ *EnableRainLighting_k__BackingField; // rbp
			//   HGRainRenderer_RainWetnessQualityParams *v31; // rdi
			//   struct MethodInfo *v32; // r14
			//   Il2CppClass *v33; // rax
			//   SettingParameter_1_System_Single_ *ScreenRainDropPercent_k__BackingField; // rbp
			//   HGRainRenderer_RainWetnessQualityParams *v35; // rdi
			//   struct MethodInfo *v36; // r14
			//   Il2CppClass *v37; // rax
			//   SettingParameter_1_System_Int32_ *SceneEffectRainLayerCount_k__BackingField; // rbx
			//   HGRainRenderer_RainWetnessQualityParams *v39; // rdi
			//   struct MethodInfo *v40; // rsi
			//   Il2CppClass *v41; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rax
			//   __int64 v46; // rax
			//   __int64 v47; // rax
			//   __int64 v48; // rax
			//   __int64 v49; // rax
			//   __int64 v50; // rax
			// 
			//   if ( !byte_18D8EDC81 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8EDC81 = 1;
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
			//     goto LABEL_79;
			//   if ( wrapperArray.max_length.size <= 612 )
			//     goto LABEL_77;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_79;
			//   if ( LODWORD(v5._0.namespaze) <= 0x264 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !*((_QWORD *)&v5[13]._0.byval_arg + 1) )
			//   {
			// LABEL_77:
			//     if ( settingParameters )
			//     {
			//       rainAndWetness_k__BackingField = settingParameters.fields._rainAndWetness_k__BackingField;
			//       verticalOcclusionMap_k__BackingField = settingParameters.fields._verticalOcclusionMap_k__BackingField;
			//       m_qualityParams = this.fields.m_qualityParams;
			//       if ( rainAndWetness_k__BackingField )
			//       {
			//         EnableRainWetnessHighQuality_k__BackingField = rainAndWetness_k__BackingField.fields._EnableRainWetnessHighQuality_k__BackingField;
			//         v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//         if ( EnableRainWetnessHighQuality_k__BackingField )
			//         {
			//           klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//           if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//           {
			//             v43 = sub_18010B520(v11.klass);
			//             (**(void (***)(void))(*(_QWORD *)(v43 + 192) + 48LL))();
			//           }
			//           v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v11.klass;
			//           if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//             sub_18003C700(v5);
			//           if ( m_qualityParams )
			//           {
			//             m_qualityParams.fields.enableRainWetnessHighQuality = EnableRainWetnessHighQuality_k__BackingField.fields._paramValue_k__BackingField;
			//             RainSplashMaxCount_k__BackingField = rainAndWetness_k__BackingField.fields._RainSplashMaxCount_k__BackingField;
			//             v14 = this.fields.m_qualityParams;
			//             v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//             if ( RainSplashMaxCount_k__BackingField )
			//             {
			//               v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//               if ( ((__int64)v16.vtable[0].methodPtr & 1) == 0 )
			//                 sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//               if ( !*((_QWORD *)v16.rgctx_data[6].rgctxDataDummy + 4) )
			//               {
			//                 v44 = sub_18010B520(v15.klass);
			//                 (**(void (***)(void))(*(_QWORD *)(v44 + 192) + 48LL))();
			//               }
			//               v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v15.klass;
			//               if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                 sub_18003C700(v5);
			//               if ( v14 )
			//               {
			//                 v14.fields.rainSplashMaxCount = RainSplashMaxCount_k__BackingField.fields._paramValue_k__BackingField;
			//                 v17 = this.fields.m_qualityParams;
			//                 if ( verticalOcclusionMap_k__BackingField )
			//                 {
			//                   DepthOcclusionMapRange_k__BackingField = verticalOcclusionMap_k__BackingField.fields._DepthOcclusionMapRange_k__BackingField;
			//                   v19 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//                   if ( DepthOcclusionMapRange_k__BackingField )
			//                   {
			//                     v20 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//                     if ( ((__int64)v20.vtable[0].methodPtr & 1) == 0 )
			//                       sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//                     if ( !*((_QWORD *)v20.rgctx_data[6].rgctxDataDummy + 4) )
			//                     {
			//                       v45 = sub_18010B520(v19.klass);
			//                       (**(void (***)(void))(*(_QWORD *)(v45 + 192) + 48LL))();
			//                     }
			//                     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v19.klass;
			//                     if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                       sub_18003C700(v5);
			//                     v21 = (float)DepthOcclusionMapRange_k__BackingField.fields._paramValue_k__BackingField <= 63.0
			//                         ? 2
			//                         : 1;
			//                     if ( v17 )
			//                     {
			//                       v17.fields.acneFixNormalBiasScale = (float)v21;
			//                       EnableMiddleDistRain_k__BackingField = rainAndWetness_k__BackingField.fields._EnableMiddleDistRain_k__BackingField;
			//                       v23 = this.fields.m_qualityParams;
			//                       v24 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//                       if ( EnableMiddleDistRain_k__BackingField )
			//                       {
			//                         v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//                         if ( ((__int64)v25.vtable[0].methodPtr & 1) == 0 )
			//                           sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//                         if ( !*((_QWORD *)v25.rgctx_data[6].rgctxDataDummy + 4) )
			//                         {
			//                           v46 = sub_18010B520(v24.klass);
			//                           (**(void (***)(void))(*(_QWORD *)(v46 + 192) + 48LL))();
			//                         }
			//                         v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v24.klass;
			//                         if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                           sub_18003C700(v5);
			//                         if ( v23 )
			//                         {
			//                           v23.fields.enableMiddleRain = EnableMiddleDistRain_k__BackingField.fields._paramValue_k__BackingField;
			//                           EnableRainWave_k__BackingField = rainAndWetness_k__BackingField.fields._EnableRainWave_k__BackingField;
			//                           v27 = this.fields.m_qualityParams;
			//                           v28 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//                           if ( EnableRainWave_k__BackingField )
			//                           {
			//                             v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//                             if ( ((__int64)v29.vtable[0].methodPtr & 1) == 0 )
			//                               sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//                             if ( !*((_QWORD *)v29.rgctx_data[6].rgctxDataDummy + 4) )
			//                             {
			//                               v47 = sub_18010B520(v28.klass);
			//                               (**(void (***)(void))(*(_QWORD *)(v47 + 192) + 48LL))();
			//                             }
			//                             v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v28.klass;
			//                             if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                               sub_18003C700(v5);
			//                             if ( v27 )
			//                             {
			//                               v27.fields.enableRainWave = EnableRainWave_k__BackingField.fields._paramValue_k__BackingField;
			//                               EnableRainLighting_k__BackingField = rainAndWetness_k__BackingField.fields._EnableRainLighting_k__BackingField;
			//                               v31 = this.fields.m_qualityParams;
			//                               v32 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//                               if ( EnableRainLighting_k__BackingField )
			//                               {
			//                                 v33 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//                                 if ( ((__int64)v33.vtable[0].methodPtr & 1) == 0 )
			//                                   sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//                                 if ( !*((_QWORD *)v33.rgctx_data[6].rgctxDataDummy + 4) )
			//                                 {
			//                                   v48 = sub_18010B520(v32.klass);
			//                                   (**(void (***)(void))(*(_QWORD *)(v48 + 192) + 48LL))();
			//                                 }
			//                                 v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v32.klass;
			//                                 if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                                   sub_18003C700(v5);
			//                                 if ( v31 )
			//                                 {
			//                                   v31.fields.enableRainLighting = EnableRainLighting_k__BackingField.fields._paramValue_k__BackingField;
			//                                   ScreenRainDropPercent_k__BackingField = rainAndWetness_k__BackingField.fields._ScreenRainDropPercent_k__BackingField;
			//                                   v35 = this.fields.m_qualityParams;
			//                                   v36 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//                                   if ( ScreenRainDropPercent_k__BackingField )
			//                                   {
			//                                     v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//                                     if ( ((__int64)v37.vtable[0].methodPtr & 1) == 0 )
			//                                       sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//                                     if ( !*((_QWORD *)v37.rgctx_data[6].rgctxDataDummy + 4) )
			//                                     {
			//                                       v49 = sub_18010B520(v36.klass);
			//                                       (**(void (***)(void))(*(_QWORD *)(v49 + 192) + 48LL))();
			//                                     }
			//                                     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v36.klass;
			//                                     if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                                       sub_18003C700(v5);
			//                                     if ( v35 )
			//                                     {
			//                                       v35.fields.screenRainDropPercent = ScreenRainDropPercent_k__BackingField.fields._paramValue_k__BackingField;
			//                                       SceneEffectRainLayerCount_k__BackingField = rainAndWetness_k__BackingField.fields._SceneEffectRainLayerCount_k__BackingField;
			//                                       v39 = this.fields.m_qualityParams;
			//                                       v40 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//                                       if ( SceneEffectRainLayerCount_k__BackingField )
			//                                       {
			//                                         v41 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//                                         if ( ((__int64)v41.vtable[0].methodPtr & 1) == 0 )
			//                                           sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//                                         if ( !*((_QWORD *)v41.rgctx_data[6].rgctxDataDummy + 4) )
			//                                         {
			//                                           v50 = sub_18010B520(v40.klass);
			//                                           (**(void (***)(void))(*(_QWORD *)(v50 + 192) + 48LL))();
			//                                         }
			//                                         v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v40.klass;
			//                                         if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//                                           sub_18003C700(v5);
			//                                         if ( v39 )
			//                                         {
			//                                           v39.fields.sceneEffectRainLayerCount = SceneEffectRainLayerCount_k__BackingField.fields._paramValue_k__BackingField;
			//                                           return;
			//                                         }
			//                                       }
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
			// LABEL_79:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(612, 0LL);
			//   if ( !Patch )
			//     goto LABEL_79;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		internal void UpdateRainAndWetnessData(HGCamera camera, ref ScriptableRenderContext renderContext)
		{
			// // Void UpdateRainAndWetnessData(HGCamera, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(
			//         HGRainRenderer *this,
			//         HGCamera *camera,
			//         ScriptableRenderContext *renderContext,
			//         MethodInfo *method)
			// {
			//   unsigned __int64 m_rainWetnessRenderSeqs; // rcx
			//   HGRainRenderer_RainWetnessRenderSeq__Array *items; // rdx
			//   bool SeqByCamera; // al
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v10; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *v11; // r8
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v12; // rax
			//   HGRainRenderer_RainWetnessRenderSeq__Array *v13; // rbx
			//   HGRainRenderer_RainWetnessQualityParams *m_qualityParams; // rdi
			//   HGRainRenderer_RainWetnessRenderSeq *v15; // rbx
			//   __int64 v16; // rax
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   __int64 v19; // rsi
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v20; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v21; // rbx
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v25; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v26; // rbx
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   RainCommonRenderingParam *v30; // rax
			//   RainCommonRenderingParam *v31; // rbx
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   OneofDescriptorProto *v35; // rdx
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   RainWetnessGlobalProps *v38; // rax
			//   RainWetnessGlobalProps *v39; // rbx
			//   OneofDescriptorProto *v40; // rdx
			//   FileDescriptor *v41; // r8
			//   MessageDescriptor *v42; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v44; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodf; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-28h]
			//   String *v51; // [rsp+28h] [rbp-20h]
			//   String *v52; // [rsp+28h] [rbp-20h]
			//   String *v53; // [rsp+28h] [rbp-20h]
			//   String *v54; // [rsp+28h] [rbp-20h]
			//   String *v55; // [rsp+28h] [rbp-20h]
			//   String *v56; // [rsp+28h] [rbp-20h]
			//   MethodInfo *index; // [rsp+30h] [rbp-18h] BYREF
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+38h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D8EDC82 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::RainCommonRenderingParam);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::RainWetnessGlobalProps);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq);
			//     byte_18D8EDC82 = 1;
			//   }
			//   seq = 0LL;
			//   LODWORD(index) = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   items = **(HGRainRenderer_RainWetnessRenderSeq__Array ***)(m_rainWetnessRenderSeqs + 184);
			//   if ( !items )
			//     goto LABEL_30;
			//   if ( items.max_length.size > 728 )
			//   {
			//     if ( !*(_DWORD *)(m_rainWetnessRenderSeqs + 224) )
			//     {
			//       il2cpp_runtime_class_init_0(m_rainWetnessRenderSeqs, items);
			//       m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     items = **(HGRainRenderer_RainWetnessRenderSeq__Array ***)(m_rainWetnessRenderSeqs + 184);
			//     if ( !items )
			//       goto LABEL_30;
			//     if ( items.max_length.size <= 0x2D8u )
			//       goto LABEL_40;
			//     if ( items[20].vector[8] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(728, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(Patch, (Object *)this, (Object *)camera, renderContext, 0LL);
			//         return;
			//       }
			//       goto LABEL_30;
			//     }
			//   }
			//   SeqByCamera = HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, camera, &seq, (int32_t *)&index, 0LL);
			//   m_rainWetnessRenderSeqs = (unsigned int)index;
			//   if ( !SeqByCamera && (int)index < 0 )
			//   {
			//     v16 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq);
			//     v19 = v16;
			//     if ( !v16 )
			//       goto LABEL_30;
			//     *(_DWORD *)(v16 + 24) = -1;
			//     *(_QWORD *)(v16 + 16) = camera;
			//     sub_1800054D0(
			//       (OneofDescriptor *)(v16 + 16),
			//       (OneofDescriptorProto *)items,
			//       v17,
			//       v18,
			//       (String__Array *)methoda,
			//       v51,
			//       index);
			//     v20 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>);
			//     v21 = v20;
			//     if ( !v20 )
			//       goto LABEL_30;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v20,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::List);
			//     *(_QWORD *)(v19 + 32) = v21;
			//     sub_1800054D0((OneofDescriptor *)(v19 + 32), v22, v23, v24, (String__Array *)methodb, v52, index);
			//     v25 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>);
			//     v26 = v25;
			//     if ( !v25 )
			//       goto LABEL_30;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v25,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::List);
			//     *(_QWORD *)(v19 + 40) = v26;
			//     sub_1800054D0((OneofDescriptor *)(v19 + 40), v27, v28, v29, (String__Array *)methodc, v53, index);
			//     v30 = (RainCommonRenderingParam *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonRenderingParam);
			//     v31 = v30;
			//     if ( !v30 )
			//       goto LABEL_30;
			//     HG::Rendering::Runtime::Rain::RainCommonRenderingParam::RainCommonRenderingParam(v30, 0LL);
			//     v31.fields.commonPresettingParam = this.fields.m_rainCommonPreSettingParam;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v31.fields.commonPresettingParam,
			//       v32,
			//       v33,
			//       v34,
			//       (String__Array *)methodd,
			//       v54,
			//       index);
			//     *(_QWORD *)(v19 + 48) = v31;
			//     sub_1800054D0((OneofDescriptor *)(v19 + 48), v35, v36, v37, (String__Array *)methodf, v55, index);
			//     v38 = (RainWetnessGlobalProps *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::RainWetnessGlobalProps);
			//     v39 = v38;
			//     if ( !v38 )
			//       goto LABEL_30;
			//     HG::Rendering::Runtime::Rain::RainWetnessGlobalProps::RainWetnessGlobalProps(v38, 0LL);
			//     *(_QWORD *)(v19 + 56) = v39;
			//     sub_1800054D0((OneofDescriptor *)(v19 + 56), v40, v41, v42, (String__Array *)methode, v56, index);
			//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::CreateDefaultFeatures(
			//       (HGRainRenderer_RainWetnessRenderSeq *)v19,
			//       0LL);
			//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PrepareResources(
			//       (HGRainRenderer_RainWetnessRenderSeq *)v19,
			//       this.fields.m_rainCommonResources,
			//       0LL);
			//     m_rainWetnessRenderSeqs = (unsigned __int64)this.fields.m_rainWetnessRenderSeqs;
			//     if ( !m_rainWetnessRenderSeqs )
			//       goto LABEL_30;
			//     sub_1822AD140((List_1_System_Object_ *)m_rainWetnessRenderSeqs, (Object *)v19);
			//     m_rainWetnessRenderSeqs = (unsigned __int64)this.fields.m_rainWetnessRenderSeqs;
			//     if ( !m_rainWetnessRenderSeqs )
			//       goto LABEL_30;
			//     m_rainWetnessRenderSeqs = (unsigned int)(*(_DWORD *)(m_rainWetnessRenderSeqs + 24) - 1);
			//   }
			//   if ( (int)m_rainWetnessRenderSeqs <= -1 )
			//     return;
			//   v10 = this.fields.m_rainWetnessRenderSeqs;
			//   if ( !v10 )
			// LABEL_30:
			//     sub_180B536AC(m_rainWetnessRenderSeqs, items);
			//   if ( (unsigned int)m_rainWetnessRenderSeqs >= v10.fields._size )
			//     goto LABEL_55;
			//   items = v10.fields._items;
			//   if ( !items )
			//     goto LABEL_30;
			//   if ( (unsigned int)m_rainWetnessRenderSeqs >= items.max_length.size )
			//     goto LABEL_40;
			//   v11 = items.vector[(int)m_rainWetnessRenderSeqs];
			//   if ( !v11 )
			//     goto LABEL_30;
			//   v11.fields.cameraMask = m_rainWetnessRenderSeqs;
			//   v12 = this.fields.m_rainWetnessRenderSeqs;
			//   if ( !v12 )
			//     goto LABEL_30;
			//   if ( (unsigned int)m_rainWetnessRenderSeqs >= v12.fields._size )
			// LABEL_55:
			//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//   v13 = v12.fields._items;
			//   if ( !v13 )
			//     goto LABEL_30;
			//   if ( (unsigned int)m_rainWetnessRenderSeqs >= v13.max_length.size )
			// LABEL_40:
			//     sub_180070270(m_rainWetnessRenderSeqs, items);
			//   m_qualityParams = this.fields.m_qualityParams;
			//   v15 = v13.vector[(int)m_rainWetnessRenderSeqs];
			//   if ( !v15 )
			//     goto LABEL_30;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, items);
			//     m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   items = **(HGRainRenderer_RainWetnessRenderSeq__Array ***)(m_rainWetnessRenderSeqs + 184);
			//   if ( !items )
			//     goto LABEL_30;
			//   if ( items.max_length.size <= 732 )
			//     goto LABEL_27;
			//   if ( !*(_DWORD *)(m_rainWetnessRenderSeqs + 224) )
			//   {
			//     il2cpp_runtime_class_init_0(m_rainWetnessRenderSeqs, items);
			//     m_rainWetnessRenderSeqs = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   items = **(HGRainRenderer_RainWetnessRenderSeq__Array ***)(m_rainWetnessRenderSeqs + 184);
			//   if ( !items )
			//     goto LABEL_30;
			//   if ( items.max_length.size <= 0x2DCu )
			//     goto LABEL_40;
			//   if ( items[20].vector[12] )
			//   {
			//     v44 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
			//     if ( v44 )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(v44, (Object *)v15, (Object *)m_qualityParams, renderContext, 0LL);
			//       return;
			//     }
			//     goto LABEL_30;
			//   }
			// LABEL_27:
			//   HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateDeltaTime(v15, 0LL);
			//   if ( !m_qualityParams )
			//     goto LABEL_30;
			//   HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareWetnessRenderData(
			//     v15,
			//     v15.fields.m_deltaTime,
			//     m_qualityParams.fields.enableRainWetnessHighQuality,
			//     0LL);
			//   HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareRainRenderData(
			//     v15,
			//     v15.fields.m_deltaTime,
			//     m_qualityParams,
			//     renderContext,
			//     0LL);
			//   HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_RequestOcclusionMap(v15, 0LL);
			// }
			// 
		}

		internal void UpdateRainAndWetnessShaderVariables(HGCamera hgCamera, ref ScriptableRenderContext context, HGVerticalOcclusionMapManager verticalOcclusionMapManager, out RainWetnessGlobalProps outProps, out bool success)
		{
			// // Void UpdateRainAndWetnessShaderVariables(HGCamera, ScriptableRenderContext ByRef, HGVerticalOcclusionMapManager, RainWetnessGlobalProps ByRef, Boolean ByRef)
			// void HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessShaderVariables(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         ScriptableRenderContext *context,
			//         HGVerticalOcclusionMapManager *verticalOcclusionMapManager,
			//         RainWetnessGlobalProps **outProps,
			//         bool *success,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGRainRenderer_RainWetnessRenderSeq *v13; // rbx
			//   HGRainRenderer_RainWetnessQualityParams *m_qualityParams; // rsi
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v18; // rax
			//   MethodInfo *v19; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v20; // [rsp+20h] [rbp-48h]
			//   RainWetnessGlobalProps **P4; // [rsp+28h] [rbp-40h]
			//   RainWetnessGlobalProps **P4a; // [rsp+28h] [rbp-40h]
			//   bool *P5; // [rsp+30h] [rbp-38h]
			//   bool *P5a; // [rsp+30h] [rbp-38h]
			//   int32_t index; // [rsp+40h] [rbp-28h] BYREF
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+48h] [rbp-20h] BYREF
			// 
			//   seq = 0LL;
			//   index = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_19;
			//   if ( wrapperArray.max_length.size > 861 )
			//   {
			//     if ( !v11._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v11, wrapperArray);
			//       v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v11.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_19;
			//     if ( wrapperArray.max_length.size <= 0x35Du )
			//       goto LABEL_34;
			//     if ( wrapperArray[24].monitor )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(861, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_338(
			//           Patch,
			//           (Object *)this,
			//           (Object *)hgCamera,
			//           context,
			//           (Object *)verticalOcclusionMapManager,
			//           outProps,
			//           success,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_19;
			//     }
			//   }
			//   *outProps = 0LL;
			//   sub_1800054D0(
			//     (OneofDescriptor *)outProps,
			//     (OneofDescriptorProto *)wrapperArray,
			//     (FileDescriptor *)context,
			//     (MessageDescriptor *)verticalOcclusionMapManager,
			//     (String__Array *)v19,
			//     (String *)P4,
			//     (MethodInfo *)P5);
			//   *success = 0;
			//   if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//     return;
			//   v13 = seq;
			//   m_qualityParams = this.fields.m_qualityParams;
			//   if ( !seq )
			//     goto LABEL_19;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_19;
			//   if ( wrapperArray.max_length.size <= 862 )
			//   {
			// LABEL_15:
			//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessShaderVariables(
			//       v13,
			//       v13.fields.rainWetnessGlobalProps,
			//       0LL);
			//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainOcclusionMapShaderVariables(
			//       v13,
			//       m_qualityParams,
			//       v13.fields.rainWetnessGlobalProps,
			//       0LL);
			//     goto LABEL_16;
			//   }
			//   if ( !v11._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v11, wrapperArray);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11.static_fields.wrapperArray;
			//   if ( !v11 )
			// LABEL_19:
			//     sub_180B536AC(v11, wrapperArray);
			//   if ( LODWORD(v11._0.namespaze) <= 0x35E )
			// LABEL_34:
			//     sub_180070270(v11, wrapperArray);
			//   if ( !v11[18]._0.nestedTypes )
			//     goto LABEL_15;
			//   v18 = IFix::WrappersManagerImpl::GetPatch(862, 0LL);
			//   if ( !v18 )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_337(v18, (Object *)v13, context, (Object *)m_qualityParams, 0LL);
			// LABEL_16:
			//   if ( !seq )
			//     goto LABEL_19;
			//   *outProps = seq.fields.rainWetnessGlobalProps;
			//   sub_1800054D0(
			//     (OneofDescriptor *)outProps,
			//     (OneofDescriptorProto *)wrapperArray,
			//     v15,
			//     v16,
			//     (String__Array *)v20,
			//     (String *)P4a,
			//     (MethodInfo *)P5a);
			//   *success = 1;
			// }
			// 
		}

		internal bool IsRainRenderingEnabled(HGCamera hgCamera)
		{
			// // Boolean IsRainRenderingEnabled(HGCamera)
			// bool HG::Rendering::Runtime::HGRainRenderer::IsRainRenderingEnabled(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   bool v5; // bl
			//   __int64 v6; // rdx
			//   RainCommonRenderingParam *rainCommonRenderingParam; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   v5 = 0;
			//   seq = 0LL;
			//   index = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1318, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//       return v5;
			//     if ( seq )
			//     {
			//       rainCommonRenderingParam = seq.fields.rainCommonRenderingParam;
			//       if ( rainCommonRenderingParam )
			//         return rainCommonRenderingParam.fields.enable;
			//     }
			// LABEL_8:
			//     sub_180B536AC(rainCommonRenderingParam, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1318, 0LL);
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
			// void HG::Rendering::Runtime::HGRainRenderer::Dispose(HGRainRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   List_1_T_Enumerator_System_Object_ v6; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v7; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC83 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Count);
			//     byte_18D8EDC83 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(492, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(492, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_rainWetnessRenderSeqs && this.fields.m_rainWetnessRenderSeqs.fields._size > 0 )
			//   {
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v6,
			//       (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::GetEnumerator);
			//     v7 = v6;
			//     v6._list = 0LL;
			//     *(_QWORD *)&v6._index = &v7;
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v7,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::MoveNext) )
			//     {
			//       if ( v7._current )
			//         HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
			//           (HGRainRenderer_RainWetnessRenderSeq *)v7._current,
			//           0LL);
			//     }
			//   }
			// }
			// 
		}

		private static int _GetRainOcclusionMaskSampleMode()
		{
			// // Int32 _GetRainOcclusionMaskSampleMode()
			// int32_t HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
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
			//   static_fields = v2.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 747 )
			//     return 1;
			//   if ( !v2._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v2, wrapperArray);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v2.static_fields;
			//   v6 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v6.max_length.size <= 0x2EBu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v6[20].vector[27] )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(747, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return 0;
		}

		private static int _GetRainOcclusionMaskSamplePosJitterMode()
		{
			// // Int32 _GetRainOcclusionMaskSamplePosJitterMode()
			// int32_t HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSamplePosJitterMode(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
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
			//   static_fields = v2.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 868 )
			//     return 1;
			//   if ( !v2._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v2, wrapperArray);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v2.static_fields;
			//   v6 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v6.max_length.size <= 0x364u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v6[24].vector[4] )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(868, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return 0;
		}

		internal void DisposeSeq(HGCamera hgCamera)
		{
			// // Void DisposeSeq(HGCamera)
			// void HG::Rendering::Runtime::HGRainRenderer::DisposeSeq(HGRainRenderer *this, HGCamera *hgCamera, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_rainWetnessRenderSeqs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDC84 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::Remove);
			//     byte_18D8EDC84 = 1;
			//   }
			//   seq = 0LL;
			//   index = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(518, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(518, 0LL);
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
			//     sub_180B536AC(m_rainWetnessRenderSeqs, v5);
			//   }
			//   if ( hgCamera && HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//   {
			//     m_rainWetnessRenderSeqs = (List_1_System_Object_ *)seq;
			//     if ( seq )
			//     {
			//       HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(seq, 0LL);
			//       m_rainWetnessRenderSeqs = (List_1_System_Object_ *)this.fields.m_rainWetnessRenderSeqs;
			//       if ( m_rainWetnessRenderSeqs )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           m_rainWetnessRenderSeqs,
			//           (Object *)seq,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::Remove);
			//         return;
			//       }
			//     }
			//     goto LABEL_9;
			//   }
			// }
			// 
		}

		private bool _TryGetSeqByCamera(HGCamera hgCamera, out HGRainRenderer.RainWetnessRenderSeq seq, out int index)
		{
			// // Boolean _TryGetSeqByCamera(HGCamera, HGRainRenderer+RainWetnessRenderSeq ByRef, Int32 ByRef)
			// bool HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         HGRainRenderer_RainWetnessRenderSeq **seq,
			//         int32_t *index,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v11; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int v16; // r10d
			//   __int64 v17; // rdx
			//   __int64 *v18; // r8
			//   signed __int64 v19; // rtt
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *m_rainWetnessRenderSeqs; // rax
			//   __int64 size; // r9
			//   List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v22; // r8
			//   HGRainRenderer_RainWetnessRenderSeq__Array *items; // rcx
			//   unsigned int v24; // ebx
			//   unsigned __int64 v25; // rax
			//   char v26; // bl
			//   __int64 *v27; // r8
			//   signed __int64 v28; // rtt
			// 
			//   if ( !byte_18D8EDC85 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Item);
			//     byte_18D8EDC85 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v9, hgCamera);
			//   if ( wrapperArray.max_length.size <= 519 )
			//     goto LABEL_16;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, hgCamera);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = v9.static_fields.wrapperArray;
			//   if ( !v11 )
			//     sub_180B536AC(v9, hgCamera);
			//   if ( v11.max_length.size <= 0x207u )
			//     sub_180070270(v9, hgCamera);
			//   if ( v11[14].vector[15] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(519, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_211(Patch, (Object *)this, (Object *)hgCamera, seq, index, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     v16 = dword_18D8E43F8;
			//     v17 = 0LL;
			//     *seq = 0LL;
			//     if ( v16 )
			//     {
			//       v18 = &qword_18D6405E0[(((unsigned __int64)seq >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v18 + 36190);
			//       do
			//         v19 = v18[36190];
			//       while ( v19 != _InterlockedCompareExchange64(
			//                        v18 + 36190,
			//                        v19 | (1LL << (((unsigned __int64)seq >> 12) & 0x3F)),
			//                        v19) );
			//       v16 = dword_18D8E43F8;
			//     }
			//     *index = -1;
			//     if ( hgCamera )
			//     {
			//       if ( this.fields.m_rainWetnessRenderSeqs )
			//       {
			//         m_rainWetnessRenderSeqs = this.fields.m_rainWetnessRenderSeqs;
			//         if ( m_rainWetnessRenderSeqs.fields._size > 0 )
			//         {
			//           size = (unsigned int)m_rainWetnessRenderSeqs.fields._size;
			//           v22 = this.fields.m_rainWetnessRenderSeqs;
			//           while ( (int)v17 < (int)size )
			//           {
			//             if ( (unsigned int)v17 >= v22.fields._size )
			//               System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//             items = v22.fields._items;
			//             if ( !items )
			//               sub_1802DC2C8(0LL, v17);
			//             if ( (unsigned int)v17 >= items.max_length.size )
			//               goto LABEL_42;
			//             if ( items.vector[(int)v17] && items.vector[(int)v17].fields.hgCamera == hgCamera )
			//             {
			//               if ( (int)v17 <= -1 )
			//                 return 0;
			//               items = v22.fields._items;
			//               if ( (unsigned int)v17 >= items.max_length.size )
			// LABEL_42:
			//                 sub_180070260(items, v17, v22, size);
			//               *seq = items.vector[(int)v17];
			//               if ( v16 )
			//               {
			//                 v24 = ((unsigned __int64)seq >> 12) & 0x1FFFFF;
			//                 v25 = (unsigned __int64)v24 >> 6;
			//                 v26 = v24 & 0x3F;
			//                 v27 = &qword_18D6405E0[v25];
			//                 _m_prefetchw(v27 + 36190);
			//                 do
			//                   v28 = v27[36190];
			//                 while ( v28 != _InterlockedCompareExchange64(v27 + 36190, v28 | (1LL << v26), v28) );
			//               }
			//               *index = v17;
			//               return 1;
			//             }
			//             v17 = (unsigned int)(v17 + 1);
			//           }
			//         }
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public Vector3 GetRainDirection(HGCamera hgCamera)
		{
			// // Vector3 GetRainDirection(HGCamera)
			// Vector3 *HG::Rendering::Runtime::HGRainRenderer::GetRainDirection(
			//         Vector3 *__return_ptr retstr,
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *up; // rax
			//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
			//   __int64 v11; // xmm0_8
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3 v16[2]; // [rsp+38h] [rbp-20h] BYREF
			//   int32_t index; // [rsp+60h] [rbp+8h] BYREF
			// 
			//   seq = 0LL;
			//   index = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1319, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1319, 0LL);
			//     if ( Patch )
			//     {
			//       up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_324(v16, Patch, (Object *)this, (Object *)hgCamera, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//   {
			//     up = UnityEngine::Vector3::get_up(v16, v7);
			// LABEL_10:
			//     v11 = *(_QWORD *)&up.x;
			//     z = up.z;
			//     goto LABEL_11;
			//   }
			//   if ( !seq )
			//     goto LABEL_8;
			//   rainCommonRenderingParam = seq.fields.rainCommonRenderingParam;
			//   if ( !rainCommonRenderingParam )
			//     goto LABEL_8;
			//   v11 = *(_QWORD *)&rainCommonRenderingParam.fields.rainDirection.x;
			//   z = rainCommonRenderingParam.fields.rainDirection.z;
			// LABEL_11:
			//   *(_QWORD *)&retstr.x = v11;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public float GetCurrentRainIntensity(Camera inMainCamera, [MetadataOffset(Offset = "0x01F90CE6")] bool noOrthoClamp = false)
		{
			// // Single GetCurrentRainIntensity(Camera, Boolean)
			// float HG::Rendering::Runtime::HGRainRenderer::GetCurrentRainIntensity(
			//         HGRainRenderer *this,
			//         Camera *inMainCamera,
			//         bool noOrthoClamp,
			//         MethodInfo *method)
			// {
			//   void *rainCommonRenderingParam; // rcx
			//   __int64 v8; // rdx
			//   HGCamera *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t index; // [rsp+30h] [rbp-18h] BYREF
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+38h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D8EDC86 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC86 = 1;
			//   }
			//   seq = 0LL;
			//   index = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   rainCommonRenderingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, inMainCamera);
			//     rainCommonRenderingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = **((_QWORD **)rainCommonRenderingParam + 23);
			//   if ( !v8 )
			//     goto LABEL_28;
			//   if ( *(int *)(v8 + 24) > 1320 )
			//   {
			//     if ( !*((_DWORD *)rainCommonRenderingParam + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(rainCommonRenderingParam, v8);
			//       rainCommonRenderingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     rainCommonRenderingParam = (void *)**((_QWORD **)rainCommonRenderingParam + 23);
			//     if ( !rainCommonRenderingParam )
			//       goto LABEL_28;
			//     if ( *((_DWORD *)rainCommonRenderingParam + 6) <= 0x528u )
			//       sub_180070270(rainCommonRenderingParam, v8);
			//     if ( *((_QWORD *)rainCommonRenderingParam + 1324) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1320, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_179(
			//                  (ILFixDynamicMethodWrapper_7 *)Patch,
			//                  (Object *)this,
			//                  (Object *)inMainCamera,
			//                  noOrthoClamp,
			//                  0LL);
			// LABEL_28:
			//       sub_180B536AC(rainCommonRenderingParam, v8);
			//     }
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !inMainCamera )
			//     return 0.0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !inMainCamera.fields._._._.m_CachedPtr )
			//     return 0.0;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v8);
			//   v9 = HG::Rendering::Runtime::HGCamera::GetOrCreate(inMainCamera, 0, 0LL);
			//   if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, v9, &seq, &index, 0LL) )
			//     return 0.0;
			//   if ( !seq )
			//     goto LABEL_28;
			//   rainCommonRenderingParam = seq.fields.rainCommonRenderingParam;
			//   if ( !rainCommonRenderingParam )
			//     goto LABEL_28;
			//   if ( !*((_BYTE *)rainCommonRenderingParam + 16) )
			//     return 0.0;
			//   if ( noOrthoClamp )
			//     return *((float *)rainCommonRenderingParam + 5);
			//   else
			//     return *((float *)rainCommonRenderingParam + 6);
			// }
			// 
			return 0f;
		}

		public bool GetShouldRequestOcclusionMap(HGCamera hgCamera)
		{
			// // Boolean GetShouldRequestOcclusionMap(HGCamera)
			// bool HG::Rendering::Runtime::HGRainRenderer::GetShouldRequestOcclusionMap(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   bool result; // al
			//   __int64 v6; // rdx
			//   HGRainRenderer_RainWetnessRenderSeq *v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   seq = 0LL;
			//   index = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1321, 0LL) )
			//   {
			//     result = HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL);
			//     if ( !result )
			//       return result;
			//     v7 = seq;
			//     if ( seq )
			//       return HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::ShouldRequestRainOcclusionMap(seq, 0LL);
			// LABEL_6:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1321, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)hgCamera,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public bool GetWetnessEnabled(HGCamera hgCamera)
		{
			// // Boolean GetWetnessEnabled(HGCamera)
			// bool HG::Rendering::Runtime::HGRainRenderer::GetWetnessEnabled(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *static_fields; // rcx
			//   HGRainRenderer_RainWetnessRenderSeq__Class *klass; // rdx
			//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
			//   HGRainRenderer_RainWetnessRenderSeq__Class *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   seq = 0LL;
			//   index = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGRainRenderer_RainWetnessRenderSeq *)v5.static_fields;
			//   klass = static_fields.klass;
			//   if ( !static_fields.klass )
			//     goto LABEL_12;
			//   if ( SLODWORD(klass._0.namespaze) > 769 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, klass);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGRainRenderer_RainWetnessRenderSeq *)v5.static_fields;
			//     v10 = static_fields.klass;
			//     if ( !static_fields.klass )
			//       goto LABEL_12;
			//     if ( LODWORD(v10._0.namespaze) <= 0x301 )
			//       sub_180070270(static_fields, klass);
			//     if ( v10[16]._0.implementedInterfaces )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(769, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//                  (ILFixDynamicMethodWrapper_36 *)Patch,
			//                  (Object *)this,
			//                  (Object *)hgCamera,
			//                  0LL);
			// LABEL_12:
			//       sub_180B536AC(static_fields, klass);
			//     }
			//   }
			//   if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//     return 0;
			//   static_fields = seq;
			//   if ( !seq )
			//     goto LABEL_12;
			//   if ( !seq.fields.rainCommonRenderingParam )
			//     return 0;
			//   rainCommonRenderingParam = seq.fields.rainCommonRenderingParam;
			//   if ( !rainCommonRenderingParam.fields.enableWetness )
			//     return 0;
			//   return rainCommonRenderingParam.fields.enableWetnessAffectSSR;
			// }
			// 
			return default(bool);
		}

		public bool GetWetnessHighQualityEnabled(HGCamera hgCamera)
		{
			// // Boolean GetWetnessHighQualityEnabled(HGCamera)
			// bool HG::Rendering::Runtime::HGRainRenderer::GetWetnessHighQualityEnabled(
			//         HGRainRenderer *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
			//   int32_t index; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   seq = 0LL;
			//   index = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size <= 770 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   v9 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_12;
			//   if ( v9.max_length.size <= 0x302u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v9[21].vector[14] )
			//   {
			// LABEL_7:
			//     if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
			//       return 0;
			//     if ( seq )
			//     {
			//       if ( seq.fields.rainCommonRenderingParam )
			//         return seq.fields.rainCommonRenderingParam.fields.wetnessHighQualityKwEnabled;
			//       return 0;
			//     }
			// LABEL_12:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(770, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)hgCamera,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal RainCommonPreSettingParam GetCurrentPresettingParams()
		{
			// // RainCommonPreSettingParam GetCurrentPresettingParams()
			// RainCommonPreSettingParam *HG::Rendering::Runtime::HGRainRenderer::GetCurrentPresettingParams(
			//         HGRainRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1322, 0LL) )
			//     return this.fields.m_rainCommonPreSettingParam;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1322, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_505(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string EDITOR_KW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly string LIGHTING_KW;

		private List<HGRainRenderer.RainWetnessRenderSeq> m_rainWetnessRenderSeqs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly HGRainRenderer.RainDropsType SCENE_DROP_MASK;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		private static readonly HGRainRenderer.RainDropsType SCREEN_FX_DROP_MASK;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly HGRainRenderer.WetnessFeaturesType HIGH_QUALITY_WETNESS_MASK;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		private static readonly HGRainRenderer.WetnessFeaturesType LOW_QUALITY_WETNESS_MASK;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly float UPDATE_DELTA_TIME_THRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		private static readonly float FOV_FADE_HIGHERTHRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly float FOV_FADE_LOWERTHRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		private static readonly int FAR_RAIN_RENDERQUEUE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static readonly int SCENEEFFECT_RAIN_RENDERQUEUE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		private static readonly int RAIN_SPLASH_RENDERQUEUE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static readonly int SCREEN_RAIN_DROP_RENDERQUEUE;

		private RainCommonPreSettingParam m_rainCommonPreSettingParam;

		private RainCommonResources m_rainCommonResources;

		private HGRainRenderer.RainWetnessQualityParams m_qualityParams;

		private HGRainParams[][] m_rainParamsArray;

		[Flags]
		public enum RainDropsType
		{
			None = 0,
			FarRain = 1,
			SceneEffectRain = 2,
			GPUParticleRain = 4,
			ScreenRainDrops = 8,
			RainSplashes = 16
		}

		[Flags]
		public enum WetnessFeaturesType
		{
			None = 0,
			Wetness = 1,
			VerticalFlow = 2,
			Ripple = 4
		}

		private class RainWetnessRenderSeq
		{
			public RainWetnessRenderSeq()
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
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::CreateDefaultFeatures(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   __int64 FAR_RAIN_RENDERQUEUE; // rdx
				//   void *subRainRenderers; // rcx
				//   List_1_System_Object_ *v5; // rsi
				//   HGFarRainRenderer *v6; // rax
				//   HGFarRainRenderer *v7; // rdi
				//   __int64 v8; // rdx
				//   struct HGRainRenderer__Class *v9; // rax
				//   List_1_System_Object_ *v10; // rsi
				//   HGSceneEffectRainRenderer *v11; // rax
				//   HGSceneEffectRainRenderer *v12; // rdi
				//   List_1_System_Object_ *v13; // rsi
				//   HGRainSplashRenderer *v14; // rax
				//   HGRainSplashRenderer *v15; // rdi
				//   List_1_System_Object_ *v16; // rsi
				//   HGScreenRainDropFXRenderer *v17; // rax
				//   HGScreenRainDropFXRenderer *v18; // rdi
				//   List_1_System_Object_ *wetnessFeatures; // rsi
				//   HGGlobalWetness *v20; // rax
				//   HGGlobalWetness *v21; // rdi
				//   List_1_System_Object_ *v22; // rsi
				//   HGWetnessVerticalFlow *v23; // rax
				//   HGWetnessVerticalFlow *v24; // rdi
				//   List_1_System_Object_ *v25; // rdi
				//   HGWetnessRipple *v26; // rax
				//   HGWetnessRipple *v27; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC89 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainSplashRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGScreenRainDropFXRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
				//     byte_18D8EDC89 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(729, 0LL) )
				//   {
				//     subRainRenderers = this.fields.subRainRenderers;
				//     if ( subRainRenderers )
				//     {
				//       sub_1823B99D0(
				//         subRainRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
				//       subRainRenderers = this.fields.wetnessFeatures;
				//       if ( subRainRenderers )
				//       {
				//         sub_1823B99D0(
				//           subRainRenderers,
				//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
				//         v5 = (List_1_System_Object_ *)this.fields.subRainRenderers;
				//         v6 = (HGFarRainRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
				//         v7 = v6;
				//         if ( v6 )
				//         {
				//           HG::Rendering::Runtime::Rain::HGFarRainRenderer::HGFarRainRenderer(v6, 0LL);
				//           v7.fields._.rainDropsType = 1;
				//           v9 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//           if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//           {
				//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, v8);
				//             v9 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//           }
				//           FAR_RAIN_RENDERQUEUE = (unsigned int)v9.static_fields.FAR_RAIN_RENDERQUEUE;
				//           v7.fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
				//           if ( v5 )
				//           {
				//             sub_1822AD140(v5, (Object *)v7);
				//             v10 = (List_1_System_Object_ *)this.fields.subRainRenderers;
				//             v11 = (HGSceneEffectRainRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
				//             v12 = v11;
				//             if ( v11 )
				//             {
				//               HG::Rendering::Runtime::HGSceneEffectRainRenderer::HGSceneEffectRainRenderer(v11, 0LL);
				//               v12.fields._.rainDropsType = 2;
				//               FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields.SCENEEFFECT_RAIN_RENDERQUEUE;
				//               v12.fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
				//               if ( v10 )
				//               {
				//                 sub_1822AD140(v10, (Object *)v12);
				//                 v13 = (List_1_System_Object_ *)this.fields.subRainRenderers;
				//                 v14 = (HGRainSplashRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRainSplashRenderer);
				//                 v15 = v14;
				//                 if ( v14 )
				//                 {
				//                   HG::Rendering::Runtime::HGRainSplashRenderer::HGRainSplashRenderer(v14, 0LL);
				//                   v15.fields._.rainDropsType = 16;
				//                   FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields.RAIN_SPLASH_RENDERQUEUE;
				//                   v15.fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
				//                   if ( v13 )
				//                   {
				//                     sub_1822AD140(v13, (Object *)v15);
				//                     v16 = (List_1_System_Object_ *)this.fields.subRainRenderers;
				//                     v17 = (HGScreenRainDropFXRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGScreenRainDropFXRenderer);
				//                     v18 = v17;
				//                     if ( v17 )
				//                     {
				//                       HG::Rendering::Runtime::HGScreenRainDropFXRenderer::HGScreenRainDropFXRenderer(v17, 0LL);
				//                       v18.fields._.rainDropsType = 8;
				//                       FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields.SCREEN_RAIN_DROP_RENDERQUEUE;
				//                       v18.fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
				//                       if ( v16 )
				//                       {
				//                         sub_1822AD140(v16, (Object *)v18);
				//                         wetnessFeatures = (List_1_System_Object_ *)this.fields.wetnessFeatures;
				//                         v20 = (HGGlobalWetness *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness);
				//                         v21 = v20;
				//                         if ( v20 )
				//                         {
				//                           HG::Rendering::Runtime::Rain::HGGlobalWetness::HGGlobalWetness(v20, 0LL);
				//                           v21.fields._.wetnessType = 1;
				//                           if ( wetnessFeatures )
				//                           {
				//                             sub_1822AD140(wetnessFeatures, (Object *)v21);
				//                             v22 = (List_1_System_Object_ *)this.fields.wetnessFeatures;
				//                             v23 = (HGWetnessVerticalFlow *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow);
				//                             v24 = v23;
				//                             if ( v23 )
				//                             {
				//                               HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::HGWetnessVerticalFlow(v23, 0LL);
				//                               v24.fields._.wetnessType = 2;
				//                               if ( v22 )
				//                               {
				//                                 sub_1822AD140(v22, (Object *)v24);
				//                                 v25 = (List_1_System_Object_ *)this.fields.wetnessFeatures;
				//                                 v26 = (HGWetnessRipple *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple);
				//                                 v27 = v26;
				//                                 if ( v26 )
				//                                 {
				//                                   HG::Rendering::Runtime::Rain::HGWetnessRipple::HGWetnessRipple(v26, 0LL);
				//                                   v27.fields._.wetnessType = 4;
				//                                   if ( v25 )
				//                                   {
				//                                     sub_1822AD140(v25, (Object *)v27);
				//                                     return;
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
				// LABEL_23:
				//     sub_180B536AC(subRainRenderers, FAR_RAIN_RENDERQUEUE);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(729, 0LL);
				//   if ( !Patch )
				//     goto LABEL_23;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			public void PrepareResources(RainCommonResources commonResources)
			{
				// // Void PrepareResources(RainCommonResources)
				// // Hidden C++ exception states: #wind=2
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PrepareResources(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         RainCommonResources *commonResources,
				//         MethodInfo *method)
				// {
				//   Object *v3; // rsi
				//   HGRainRenderer_RainWetnessRenderSeq *v4; // rdi
				//   Object *current; // rbx
				//   List_1_System_Object_ *wetnessFeatures; // rax
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseWetnessFeature_ *v7; // r9
				//   __int64 *v8; // rdx
				//   __int64 v9; // rtt
				//   __int64 v10; // rdx
				//   __int64 v11; // r8
				//   __int64 v12; // r9
				//   Object *v13; // rbx
				//   signed __int64 v14; // rcx
				//   __int64 v15; // rax
				//   __int64 v16; // rax
				//   struct ILFixDynamicMethodWrapper_2__Class *v17; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2__Array *v19; // rdx
				//   signed __int64 v20; // rcx
				//   __int64 v21; // rax
				//   __int64 v22; // rax
				//   ILFixDynamicMethodWrapper_2__Array *v23; // rcx
				//   ILFixDynamicMethodWrapper_37 *v24; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v26; // rdx
				//   __int64 v27; // rcx
				//   Il2CppExceptionWrapper *v28; // [rsp+20h] [rbp-78h] BYREF
				//   Il2CppExceptionWrapper *v29; // [rsp+28h] [rbp-70h] BYREF
				//   List_1_T_Enumerator_System_Object_ v30; // [rsp+30h] [rbp-68h] BYREF
				//   List_1_T_Enumerator_System_Object_ v31; // [rsp+48h] [rbp-50h] BYREF
				//   List_1_T_Enumerator_System_Object_ v32; // [rsp+60h] [rbp-38h] BYREF
				// 
				//   v3 = (Object *)commonResources;
				//   v4 = this;
				//   if ( !byte_18D8EDC8A )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::get_Count);
				//     byte_18D8EDC8A = 1;
				//   }
				//   memset(&v31, 0, sizeof(v31));
				//   memset(&v32, 0, sizeof(v32));
				//   if ( IFix::WrappersManagerImpl::IsPatched(730, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(730, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v27, v26);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v4, v3, 0LL);
				//   }
				//   else
				//   {
				//     if ( v4.fields.subRainRenderers && v4.fields.subRainRenderers.fields._size > 0 )
				//     {
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         &v30,
				//         (List_1_System_Object_ *)v4.fields.subRainRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//       v31 = v30;
				//       v30._list = 0LL;
				//       *(_QWORD *)&v30._index = &v31;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v31,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
				//         {
				//           current = v31._current;
				//           if ( v31._current )
				//           {
				//             sub_180003EE0(v31._current.klass);
				//             ((void (__fastcall *)(Object *, Object *, const char *))current.klass[1]._0.gc_desc)(
				//               current,
				//               v3,
				//               current.klass[1]._0.name);
				//           }
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v28 )
				//       {
				//         v30._list = (List_1_System_Object_ *)v28.ex;
				//         if ( v30._list )
				//           sub_18000F780(v30._list);
				//         v3 = (Object *)commonResources;
				//         v4 = this;
				//       }
				//     }
				//     if ( v4.fields.wetnessFeatures )
				//     {
				//       wetnessFeatures = (List_1_System_Object_ *)v4.fields.wetnessFeatures;
				//       if ( wetnessFeatures.fields._size > 0 )
				//       {
				//         v7 = v4.fields.wetnessFeatures;
				//         *(_OWORD *)&v30._index = 0LL;
				//         v30._list = wetnessFeatures;
				//         if ( dword_18D8E43F8 )
				//         {
				//           v8 = &qword_18D6870D0[(((unsigned __int64)&v30 >> 12) & 0x1FFFFF) >> 6];
				//           _m_prefetchw(v8);
				//           do
				//             v9 = *v8;
				//           while ( v9 != _InterlockedCompareExchange64(v8, *v8 | (1LL << (((unsigned __int64)&v30 >> 12) & 0x3F)), *v8) );
				//         }
				//         v30._index = 0;
				//         v30._version = v7.fields._version;
				//         v30._current = 0LL;
				//         *(_OWORD *)&v32._list = *(_OWORD *)&v30._list;
				//         v32._current = 0LL;
				//         v30._list = 0LL;
				//         *(_QWORD *)&v30._index = &v32;
				//         try
				//         {
				//           while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                     &v32,
				//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
				//           {
				//             v13 = v32._current;
				//             if ( v32._current )
				//             {
				//               if ( !byte_18D8EDC37 )
				//               {
				//                 v14 = _InterlockedExchangeAdd64(
				//                         (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                         0LL);
				//                 if ( (v14 & 1) != 0 )
				//                 {
				//                   v11 = ((unsigned int)v14 >> 1) & 0xFFFFFFF;
				//                   switch ( (unsigned int)v14 >> 29 )
				//                   {
				//                     case 1u:
				//                       v15 = sub_18003C670((unsigned int)v11);
				//                       goto LABEL_30;
				//                     case 2u:
				//                       v15 = sub_18003C380((unsigned int)v11);
				//                       goto LABEL_30;
				//                     case 3u:
				//                     case 6u:
				//                       v15 = sub_1802DFAE0(v14);
				//                       goto LABEL_30;
				//                     case 4u:
				//                       v15 = sub_1802DF920((unsigned int)v11);
				//                       goto LABEL_30;
				//                     case 5u:
				//                       v15 = sub_1802DFBB0((unsigned int)v11);
				//                       goto LABEL_30;
				//                     case 7u:
				//                       v16 = sub_1802DF920((unsigned int)v11);
				//                       v15 = sub_1802DF850(v16);
				//                       if ( v15 )
				//                         v15 = sub_1802DF970(*(unsigned int *)(v15 + 8));
				// LABEL_30:
				//                       if ( v15 )
				//                         _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v15);
				//                       break;
				//                     default:
				//                       break;
				//                   }
				//                 }
				//                 byte_18D8EDC37 = 1;
				//               }
				//               v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//               {
				//                 il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v10);
				//                 v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               }
				//               wrapperArray = v17.static_fields.wrapperArray;
				//               if ( !wrapperArray )
				//                 sub_1802DC2C8(v17, 0LL);
				//               if ( wrapperArray.max_length.size > 731 )
				//               {
				//                 if ( !v17._1.cctor_finished_or_no_cctor )
				//                 {
				//                   il2cpp_runtime_class_init_0(v17, wrapperArray);
				//                   v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                 }
				//                 v19 = v17.static_fields.wrapperArray;
				//                 if ( !v19 )
				//                   sub_1802DC2C8(v17, 0LL);
				//                 if ( v19.max_length.size <= 0x2DBu )
				//                   sub_180070260(v17, v19, v11, v12);
				//                 if ( v19[20].vector[11] )
				//                 {
				//                   if ( !byte_18D919D50 )
				//                   {
				//                     v20 = _InterlockedExchangeAdd64(
				//                             (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                             0LL);
				//                     if ( (v20 & 1) != 0 )
				//                     {
				//                       v11 = ((unsigned int)v20 >> 1) & 0xFFFFFFF;
				//                       switch ( (unsigned int)v20 >> 29 )
				//                       {
				//                         case 1u:
				//                           v21 = sub_18003C670((unsigned int)v11);
				//                           goto LABEL_52;
				//                         case 2u:
				//                           v21 = sub_18003C380((unsigned int)v11);
				//                           goto LABEL_52;
				//                         case 3u:
				//                         case 6u:
				//                           v21 = sub_1802DFAE0(v20);
				//                           goto LABEL_52;
				//                         case 4u:
				//                           v21 = sub_1802DF920((unsigned int)v11);
				//                           goto LABEL_52;
				//                         case 5u:
				//                           v21 = sub_1802DFBB0((unsigned int)v11);
				//                           goto LABEL_52;
				//                         case 7u:
				//                           v22 = sub_1802DF920((unsigned int)v11);
				//                           v21 = sub_1802DF850(v22);
				//                           if ( v21 )
				//                             v21 = sub_1802DF970(*(unsigned int *)(v21 + 8));
				// LABEL_52:
				//                           if ( v21 )
				//                             _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v21);
				//                           break;
				//                         default:
				//                           break;
				//                       }
				//                     }
				//                     byte_18D919D50 = 1;
				//                     v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   }
				//                   if ( !v17._1.cctor_finished_or_no_cctor )
				//                   {
				//                     il2cpp_runtime_class_init_0(v17, v19);
				//                     v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   }
				//                   v23 = v17.static_fields.wrapperArray;
				//                   if ( !v23 )
				//                     sub_1802DC2C8(0LL, v19);
				//                   if ( v23.max_length.size <= 0x2DBu )
				//                     sub_180070260(v23, v19, v11, v12);
				//                   v24 = (ILFixDynamicMethodWrapper_37 *)v23[20].vector[11];
				//                   if ( !v24 )
				//                     sub_1802DC2C8(0LL, v19);
				//                   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(v24, v13, v3, 0LL);
				//                 }
				//               }
				//             }
				//           }
				//         }
				//         catch ( Il2CppExceptionWrapper *v29 )
				//         {
				//           v30._list = (List_1_System_Object_ *)v29.ex;
				//           if ( v30._list )
				//             sub_18000F780(v30._list);
				//         }
				//       }
				//     }
				//   }
				// }
				// 
			}

			public void PerFrameClear()
			{
				// // Void PerFrameClear()
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PerFrameClear(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   FileDescriptor *v2; // r8
				//   MessageDescriptor *v3; // r9
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
				//   ILFixDynamicMethodWrapper_2__Array *v7; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rax
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *v12; // rbx
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   String__Array *v15; // [rsp+20h] [rbp-48h] BYREF
				//   _BYTE v16[64]; // [rsp+28h] [rbp-40h] BYREF
				// 
				//   if ( !byte_18D8EDC8B )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Count);
				//     byte_18D8EDC8B = 1;
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
				//   if ( wrapperArray.max_length.size <= 623 )
				//     goto LABEL_39;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v7 = v5.static_fields.wrapperArray;
				//   if ( !v7 )
				//     sub_180B536AC(v5, method);
				//   if ( v7.max_length.size <= 0x26Fu )
				//     sub_180070270(v5, method);
				//   if ( v7[17].vector[11] )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(623, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				// LABEL_39:
				//     if ( this.fields.subRainRenderers )
				//     {
				//       subRainRenderers = this.fields.subRainRenderers;
				//       if ( subRainRenderers.fields._size > 0 )
				//       {
				//         v12 = this.fields.subRainRenderers;
				//         *(_OWORD *)&v16[8] = 0LL;
				//         *(_QWORD *)v16 = subRainRenderers;
				//         ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
				//           (OneofDescriptor *)v16,
				//           (OneofDescriptorProto *)method,
				//           v2,
				//           v3,
				//           v15);
				//         *(_DWORD *)&v16[8] = 0;
				//         if ( !v12 )
				//           sub_180B536AC(v14, v13);
				//         *(_DWORD *)&v16[12] = v12.fields._version;
				//         *(_QWORD *)&v16[16] = 0LL;
				//         *(_OWORD *)&v16[24] = *(_OWORD *)v16;
				//         *(_QWORD *)&v16[40] = 0LL;
				//         *(_QWORD *)v16 = 0LL;
				//         *(_QWORD *)&v16[8] = &v16[24];
				//         try
				//         {
				//           while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                     (List_1_T_Enumerator_System_Object_ *)&v16[24],
				//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
				//           {
				//             if ( *(_QWORD *)&v16[40] )
				//               sub_180040B30(6LL, *(_QWORD *)&v16[40]);
				//           }
				//         }
				//         catch ( Il2CppExceptionWrapper *v15 )
				//         {
				//           *(_QWORD *)v16 = v15.klass;
				//           if ( *(_QWORD *)v16 )
				//             sub_18000F780(*(_QWORD *)v16);
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
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   HGRainRenderer_RainWetnessRenderSeq *v2; // rdi
				//   Object *current; // rbx
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rcx
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseWetnessFeature_ *wetnessFeatures; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   Il2CppExceptionWrapper *v9; // [rsp+20h] [rbp-48h] BYREF
				//   List_1_T_Enumerator_System_Object_ v10; // [rsp+28h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v11; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   v2 = this;
				//   if ( !byte_18D8EDC8C )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Count);
				//     byte_18D8EDC8C = 1;
				//   }
				//   memset(&v11, 0, sizeof(v11));
				//   if ( IFix::WrappersManagerImpl::IsPatched(493, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(493, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
				//   }
				//   else
				//   {
				//     if ( v2.fields.subRainRenderers && v2.fields.subRainRenderers.fields._size > 0 )
				//     {
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         &v10,
				//         (List_1_System_Object_ *)v2.fields.subRainRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//       v11 = v10;
				//       v10._list = 0LL;
				//       *(_QWORD *)&v10._index = &v11;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v11,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
				//         {
				//           current = v11._current;
				//           if ( v11._current )
				//           {
				//             sub_180003EE0(v11._current.klass);
				//             ((void (__fastcall *)(Object *, const PropertyInfo *))current.klass[1]._0.events)(
				//               current,
				//               current.klass[1]._0.properties);
				//           }
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v9 )
				//       {
				//         v10._list = (List_1_System_Object_ *)v9.ex;
				//         if ( v10._list )
				//           sub_18000F780(v10._list);
				//         v2 = this;
				//       }
				//     }
				//     subRainRenderers = v2.fields.subRainRenderers;
				//     if ( subRainRenderers )
				//       sub_1823B99D0(
				//         subRainRenderers,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
				//     wetnessFeatures = v2.fields.wetnessFeatures;
				//     if ( wetnessFeatures )
				//       sub_1823B99D0(
				//         wetnessFeatures,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
				//   }
				// }
				// 
			}

			private void _UpdateDeltaTime()
			{
				// // Void _UpdateDeltaTime()
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateDeltaTime(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   __int64 v5; // rdx
				//   float time; // xmm0_4
				//   struct HGRainRenderer__Class *v7; // rcx
				//   float v8; // xmm6_4
				//   float m_lastTime; // xmm7_4
				//   HGRainRenderer__StaticFields *static_fields; // rax
				//   float UPDATE_DELTA_TIME_THRESHOLD; // xmm0_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC8D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     byte_18D8EDC8D = 1;
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
				//   if ( wrapperArray.max_length.size > 733 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x2DD )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !*(_QWORD *)&v3[15]._1.element_size )
				//         goto LABEL_9;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(733, 0LL);
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
				//   v7 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//   v8 = time;
				//   m_lastTime = this.fields.m_lastTime;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, v5);
				//     v7 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
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

			public void UpdateRainAndWetnessDataSeq(HGRainRenderer.RainWetnessQualityParams qualityParams, ref ScriptableRenderContext renderContext)
			{
				// // Void UpdateRainAndWetnessDataSeq(HGRainRenderer+RainWetnessQualityParams, ScriptableRenderContext ByRef)
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateRainAndWetnessDataSeq(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         HGRainRenderer_RainWetnessQualityParams *qualityParams,
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
				//     goto LABEL_9;
				//   if ( wrapperArray.max_length.size <= 732 )
				//     goto LABEL_7;
				//   if ( !v7._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v7, wrapperArray);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
				//   if ( !v7 )
				//     goto LABEL_9;
				//   if ( LODWORD(v7._0.namespaze) <= 0x2DC )
				//     sub_180070270(v7, wrapperArray);
				//   if ( !*(_QWORD *)&v7[15]._1.instance_size )
				//   {
				// LABEL_7:
				//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateDeltaTime(this, 0LL);
				//     if ( qualityParams )
				//     {
				//       HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareWetnessRenderData(
				//         this,
				//         this.fields.m_deltaTime,
				//         qualityParams.fields.enableRainWetnessHighQuality,
				//         0LL);
				//       HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareRainRenderData(
				//         this,
				//         this.fields.m_deltaTime,
				//         qualityParams,
				//         renderContext,
				//         0LL);
				//       HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_RequestOcclusionMap(this, 0LL);
				//       return;
				//     }
				// LABEL_9:
				//     sub_180B536AC(v7, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
				//   if ( !Patch )
				//     goto LABEL_9;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(Patch, (Object *)this, (Object *)qualityParams, renderContext, 0LL);
				// }
				// 
			}

			private void _PrepareWetnessRenderData(float deltaTime, bool enableHighQualityWetness)
			{
				// // Void _PrepareWetnessRenderData(Single, Boolean)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareWetnessRenderData(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         float deltaTime,
				//         bool enableHighQualityWetness,
				//         MethodInfo *method)
				// {
				//   __int64 v4; // rdx
				//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
				//   ILFixDynamicMethodWrapper_2__Array *v9; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v11; // rdx
				//   __int64 v12; // rcx
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rdi
				//   struct HGRainRenderer__Class *v16; // rax
				//   int32_t HIGH_QUALITY_WETNESS_MASK; // edi
				//   __int64 v18; // rcx
				//   List_1_T_Enumerator_System_Object_ v19; // [rsp+30h] [rbp-58h] BYREF
				//   Il2CppExceptionWrapper *v20; // [rsp+48h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v21; // [rsp+50h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D8EDC8E )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::get_Current);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
				//     byte_18D8EDC8E = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v7.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     sub_180B536AC(v7, v4);
				//   if ( wrapperArray.max_length.size <= 734 )
				//     goto LABEL_17;
				//   if ( !v7._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v7, v4);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v9 = v7.static_fields.wrapperArray;
				//   if ( !v9 )
				//     sub_180B536AC(v7, v4);
				//   if ( v9.max_length.size <= 0x2DEu )
				//     sub_180070270(v7, v4);
				//   if ( v9[20].vector[14] )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v12, v11);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
				//       (ILFixDynamicMethodWrapper_8 *)Patch,
				//       (Object *)this,
				//       deltaTime,
				//       enableHighQualityWetness,
				//       0LL);
				//   }
				//   else
				//   {
				// LABEL_17:
				//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessCommonParams(
				//       this,
				//       enableHighQualityWetness,
				//       0LL);
				//     rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//     if ( !rainCommonRenderingParam )
				//       sub_180B536AC(v14, v13);
				//     if ( rainCommonRenderingParam.fields.enableWetness )
				//     {
				//       v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//       if ( rainCommonRenderingParam.fields.wetnessHighQualityKwEnabled )
				//       {
				//         if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//         {
				//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, v13);
				//           v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//         }
				//         HIGH_QUALITY_WETNESS_MASK = v16.static_fields.HIGH_QUALITY_WETNESS_MASK;
				//       }
				//       else
				//       {
				//         if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//         {
				//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, v13);
				//           v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//         }
				//         HIGH_QUALITY_WETNESS_MASK = v16.static_fields.LOW_QUALITY_WETNESS_MASK;
				//       }
				//       if ( !this.fields.wetnessFeatures )
				//         sub_180B536AC(v14, v13);
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         &v19,
				//         (List_1_System_Object_ *)this.fields.wetnessFeatures,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
				//       v21 = v19;
				//       v19._list = 0LL;
				//       *(_QWORD *)&v19._index = &v21;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v21,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
				//         {
				//           if ( !v21._current )
				//             sub_1802DC2C8(v18, 0LL);
				//           if ( (HIGH_QUALITY_WETNESS_MASK & (__int64)v21._current[1].klass) > 0 )
				//             sub_180835B2C(v18, v21._current, this.fields.rainCommonRenderingParam);
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v20 )
				//       {
				//         v19._list = (List_1_System_Object_ *)v20.ex;
				//         if ( v19._list )
				//           sub_18000F780(v19._list);
				//       }
				//     }
				//   }
				// }
				// 
			}

			private void _UpdateWetnessCommonParams(bool enableHighQualityWetness)
			{
				// // Void _UpdateWetnessCommonParams(Boolean)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessCommonParams(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         bool enableHighQualityWetness,
				//         MethodInfo *method)
				// {
				//   _BYTE *v5; // rcx
				//   HGRainConfig *p_rainConfig; // rdx
				//   Object *hgCamera; // rdi
				//   Object__Class *klass; // rax
				//   HGEnvironmentPhase *name; // rax
				//   __int64 v10; // r8
				//   HGRainConfig *v11; // rax
				//   char *v12; // rcx
				//   __int64 v13; // r9
				//   __int128 v14; // xmm0
				//   __int128 v15; // xmm1
				//   __int128 v16; // xmm0
				//   __int128 v17; // xmm1
				//   __int128 v18; // xmm0
				//   __int128 v19; // xmm1
				//   __int128 v20; // xmm0
				//   __int128 v21; // xmm1
				//   __int64 v22; // r9
				//   __int128 v23; // xmm1
				//   __int128 v24; // xmm0
				//   HGRainConfig *v25; // rax
				//   __int128 v26; // xmm0
				//   __int128 v27; // xmm1
				//   __int128 v28; // xmm0
				//   __int128 v29; // xmm1
				//   __int128 v30; // xmm0
				//   __int128 v31; // xmm1
				//   __int128 v32; // xmm0
				//   __int128 v33; // xmm1
				//   __int128 v34; // xmm1
				//   __int128 v35; // xmm0
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   float v37; // xmm1_4
				//   float v38; // xmm0_4
				//   RainCommonRenderingParam *v39; // rax
				//   float v40; // xmm0_4
				//   RainCommonRenderingParam *v41; // rax
				//   float v42; // xmm0_4
				//   RainCommonRenderingParam *v43; // rax
				//   float v44; // xmm0_4
				//   RainCommonRenderingParam *v45; // rax
				//   float v46; // xmm0_4
				//   RainCommonRenderingParam *v47; // rax
				//   RainCommonRenderingParam *v48; // rax
				//   RainCommonRenderingParam *v49; // rax
				//   RainCommonRenderingParam *v50; // rax
				//   RainCommonRenderingParam *v51; // rax
				//   RainCommonRenderingParam *v52; // rax
				//   RainCommonRenderingParam *v53; // rax
				//   RainCommonRenderingParam *v54; // rax
				//   RainCommonRenderingParam *v55; // rax
				//   RainCommonRenderingParam *v56; // rax
				//   RainCommonRenderingParam *v57; // rax
				//   RainCommonRenderingParam *v58; // rax
				//   RainCommonRenderingParam *v59; // rax
				//   RainCommonRenderingParam *v60; // rax
				//   RainCommonRenderingParam *v61; // rax
				//   ILFixDynamicMethodWrapper_2 *v62; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   _OWORD *v64; // rax
				//   __int128 v65; // xmm0
				//   __int128 v66; // xmm1
				//   __int128 v67; // xmm0
				//   __int128 v68; // xmm1
				//   __int128 v69; // xmm0
				//   __int128 v70; // xmm1
				//   __int128 v71; // xmm0
				//   __int128 v72; // xmm1
				//   __int128 v73; // xmm1
				//   __int128 v74; // xmm0
				//   HGCamera *v75; // rax
				//   Camera *camera; // rdi
				//   char v77; // [rsp+20h] [rbp-E0h] BYREF
				//   float v78; // [rsp+54h] [rbp-ACh]
				//   char v79; // [rsp+E1h] [rbp-1Fh]
				//   float v80; // [rsp+E4h] [rbp-1Ch]
				//   float v81; // [rsp+E8h] [rbp-18h]
				//   float v82; // [rsp+ECh] [rbp-14h]
				//   float v83; // [rsp+F0h] [rbp-10h]
				//   int v84; // [rsp+F4h] [rbp-Ch]
				//   float v85; // [rsp+F8h] [rbp-8h]
				//   float v86; // [rsp+FCh] [rbp-4h]
				//   float v87; // [rsp+100h] [rbp+0h]
				//   float v88; // [rsp+104h] [rbp+4h]
				//   float v89; // [rsp+108h] [rbp+8h]
				//   float v90; // [rsp+10Ch] [rbp+Ch]
				//   float v91; // [rsp+110h] [rbp+10h]
				//   float v92; // [rsp+114h] [rbp+14h]
				//   float v93; // [rsp+118h] [rbp+18h]
				//   float v94; // [rsp+11Ch] [rbp+1Ch]
				//   float v95; // [rsp+120h] [rbp+20h]
				//   float v96; // [rsp+124h] [rbp+24h]
				//   _BYTE v97[196]; // [rsp+150h] [rbp+50h] BYREF
				//   float v98; // [rsp+214h] [rbp+114h]
				// 
				//   if ( !byte_18D8EDC8F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D8EDC8F = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, enableHighQualityWetness);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   p_rainConfig = (HGRainConfig *)**((_QWORD **)v5 + 23);
				//   if ( !p_rainConfig )
				//     goto LABEL_64;
				//   if ( SLODWORD(p_rainConfig.color.a) <= 735 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v5 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v5, p_rainConfig);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   p_rainConfig = (HGRainConfig *)**((_QWORD **)v5 + 23);
				//   if ( !p_rainConfig )
				//     goto LABEL_64;
				//   if ( LODWORD(p_rainConfig.color.a) <= 0x2DF )
				//     goto LABEL_79;
				//   if ( !*(_QWORD *)&p_rainConfig[19].screenDropMinMaxSize )
				//   {
				// LABEL_9:
				//     hgCamera = (Object *)this.fields.hgCamera;
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, p_rainConfig);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     if ( !byte_18D8EDC5D )
				//     {
				//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//       byte_18D8EDC5D = 1;
				//     }
				//     if ( !byte_18D8EDC37 )
				//     {
				//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//       byte_18D8EDC37 = 1;
				//     }
				//     if ( !*((_DWORD *)v5 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v5, p_rainConfig);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     p_rainConfig = (HGRainConfig *)**((_QWORD **)v5 + 23);
				//     if ( !p_rainConfig )
				//       goto LABEL_64;
				//     if ( SLODWORD(p_rainConfig.color.a) <= 439 )
				//       goto LABEL_19;
				//     if ( !*((_DWORD *)v5 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v5, p_rainConfig);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v5 = (_BYTE *)**((_QWORD **)v5 + 23);
				//     if ( !v5 )
				//       goto LABEL_64;
				//     if ( *((_DWORD *)v5 + 6) > 0x1B7u )
				//     {
				//       if ( *((_QWORD *)v5 + 443) )
				//       {
				//         Patch = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
				//         if ( !Patch )
				//           goto LABEL_64;
				//         name = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(Patch, hgCamera, 0LL);
				// LABEL_23:
				//         if ( !name )
				//           goto LABEL_64;
				//         p_rainConfig = &name.fields.rainConfig;
				//         v10 = 2LL;
				//         v11 = &name.fields.rainConfig;
				//         v12 = &v77;
				//         v13 = 2LL;
				//         do
				//         {
				//           v12 += 128;
				//           v14 = *(_OWORD *)&v11.enable;
				//           v15 = *(_OWORD *)&v11.color.g;
				//           v11 = (HGRainConfig *)((char *)v11 + 128);
				//           *((_OWORD *)v12 - 8) = v14;
				//           v16 = *(_OWORD *)&v11[-1].baseWetnessLevel;
				//           *((_OWORD *)v12 - 7) = v15;
				//           v17 = *(_OWORD *)&v11[-1].verticalFlowSurfaceThreshold;
				//           *((_OWORD *)v12 - 6) = v16;
				//           v18 = *(_OWORD *)&v11[-1].rippleWaveSpeed;
				//           *((_OWORD *)v12 - 5) = v17;
				//           v19 = *(_OWORD *)&v11[-1].farSceneWetnessValue;
				//           *((_OWORD *)v12 - 4) = v18;
				//           v20 = *(_OWORD *)&v11[-1].rainDirection.z;
				//           *((_OWORD *)v12 - 3) = v19;
				//           v21 = *(_OWORD *)&v11[-1].farRainDirection.x;
				//           *((_OWORD *)v12 - 2) = v20;
				//           *((_OWORD *)v12 - 1) = v21;
				//           --v13;
				//         }
				//         while ( v13 );
				//         v22 = 2LL;
				//         v23 = *(_OWORD *)&v11.color.g;
				//         *(_OWORD *)v12 = *(_OWORD *)&v11.enable;
				//         v24 = *(_OWORD *)&v11.horizontalRainAngle;
				//         v25 = p_rainConfig;
				//         *((_OWORD *)v12 + 1) = v23;
				//         *((_OWORD *)v12 + 2) = v24;
				//         v5 = v97;
				//         do
				//         {
				//           v5 += 128;
				//           v26 = *(_OWORD *)&v25.enable;
				//           v27 = *(_OWORD *)&v25.color.g;
				//           v25 = (HGRainConfig *)((char *)v25 + 128);
				//           *((_OWORD *)v5 - 8) = v26;
				//           v28 = *(_OWORD *)&v25[-1].baseWetnessLevel;
				//           *((_OWORD *)v5 - 7) = v27;
				//           v29 = *(_OWORD *)&v25[-1].verticalFlowSurfaceThreshold;
				//           *((_OWORD *)v5 - 6) = v28;
				//           v30 = *(_OWORD *)&v25[-1].rippleWaveSpeed;
				//           *((_OWORD *)v5 - 5) = v29;
				//           v31 = *(_OWORD *)&v25[-1].farSceneWetnessValue;
				//           *((_OWORD *)v5 - 4) = v30;
				//           v32 = *(_OWORD *)&v25[-1].rainDirection.z;
				//           *((_OWORD *)v5 - 3) = v31;
				//           v33 = *(_OWORD *)&v25[-1].farRainDirection.x;
				//           *((_OWORD *)v5 - 2) = v32;
				//           *((_OWORD *)v5 - 1) = v33;
				//           --v22;
				//         }
				//         while ( v22 );
				//         v34 = *(_OWORD *)&v25.color.g;
				//         *(_OWORD *)v5 = *(_OWORD *)&v25.enable;
				//         v35 = *(_OWORD *)&v25.horizontalRainAngle;
				//         *((_OWORD *)v5 + 1) = v34;
				//         *((_OWORD *)v5 + 2) = v35;
				//         if ( !v97[192] )
				//           goto LABEL_29;
				//         v64 = v97;
				//         do
				//         {
				//           v64 += 8;
				//           v65 = *(_OWORD *)&p_rainConfig.enable;
				//           v66 = *(_OWORD *)&p_rainConfig.color.g;
				//           p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
				//           *(v64 - 8) = v65;
				//           v67 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
				//           *(v64 - 7) = v66;
				//           v68 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
				//           *(v64 - 6) = v67;
				//           v69 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
				//           *(v64 - 5) = v68;
				//           v70 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
				//           *(v64 - 4) = v69;
				//           v71 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
				//           *(v64 - 3) = v70;
				//           v72 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
				//           *(v64 - 2) = v71;
				//           *(v64 - 1) = v72;
				//           --v10;
				//         }
				//         while ( v10 );
				//         v73 = *(_OWORD *)&p_rainConfig.color.g;
				//         *v64 = *(_OWORD *)&p_rainConfig.enable;
				//         v74 = *(_OWORD *)&p_rainConfig.horizontalRainAngle;
				//         v64[1] = v73;
				//         v64[2] = v74;
				//         if ( v98 <= COERCE_FLOAT(1) )
				//           goto LABEL_29;
				//         v75 = this.fields.hgCamera;
				//         if ( !v75 )
				//           goto LABEL_64;
				//         camera = v75.fields.camera;
				//         if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
				//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, p_rainConfig);
				//         if ( HG::Rendering::Runtime::HGUtils::IsInIsolatedDisplayMode(camera, 0LL) )
				// LABEL_29:
				//           LOBYTE(p_rainConfig) = 0;
				//         else
				//           LOBYTE(p_rainConfig) = 1;
				//         rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//         if ( rainCommonRenderingParam )
				//         {
				//           rainCommonRenderingParam.fields.enableWetness = (char)p_rainConfig;
				//           v5 = this.fields.rainCommonRenderingParam;
				//           if ( v5 )
				//           {
				//             v37 = 0.0;
				//             v5[254] = v79;
				//             v38 = (_BYTE)p_rainConfig ? v80 : 0.0;
				//             v39 = this.fields.rainCommonRenderingParam;
				//             if ( v39 )
				//             {
				//               v39.fields.wetness = v38;
				//               v40 = (_BYTE)p_rainConfig ? v81 : 0.0;
				//               v41 = this.fields.rainCommonRenderingParam;
				//               if ( v41 )
				//               {
				//                 v41.fields.wetnessBasePorosity = v40;
				//                 v42 = (_BYTE)p_rainConfig ? v82 : 0.0;
				//                 v43 = this.fields.rainCommonRenderingParam;
				//                 if ( v43 )
				//                 {
				//                   v43.fields.wetnessPorosityFactor = v42;
				//                   v44 = (_BYTE)p_rainConfig ? v83 : 0.0;
				//                   v45 = this.fields.rainCommonRenderingParam;
				//                   if ( v45 )
				//                   {
				//                     v45.fields.baseWetnessLevel = v44;
				//                     v46 = (_BYTE)p_rainConfig ? *(float *)&v84 : 1.0;
				//                     v47 = this.fields.rainCommonRenderingParam;
				//                     if ( v47 )
				//                     {
				//                       v47.fields.verticalWetnessScalar = v46;
				//                       v48 = this.fields.rainCommonRenderingParam;
				//                       if ( v48 )
				//                       {
				//                         v48.fields.verticalFlowNormalStrength = v86;
				//                         v49 = this.fields.rainCommonRenderingParam;
				//                         if ( v49 )
				//                         {
				//                           v49.fields.verticalFlowSpeed = v85;
				//                           v50 = this.fields.rainCommonRenderingParam;
				//                           if ( v50 )
				//                           {
				//                             v50.fields.verticalFlowSurfaceThreshold = v87;
				//                             v51 = this.fields.rainCommonRenderingParam;
				//                             if ( v51 )
				//                             {
				//                               v51.fields.verticalFlowPorosityBias = v88;
				//                               v52 = this.fields.rainCommonRenderingParam;
				//                               if ( v52 )
				//                               {
				//                                 v52.fields.rippleNormalStrength = v90;
				//                                 v53 = this.fields.rainCommonRenderingParam;
				//                                 if ( v53 )
				//                                 {
				//                                   v53.fields.rippleWaveNormalStrength = v92;
				//                                   v54 = this.fields.rainCommonRenderingParam;
				//                                   if ( v54 )
				//                                   {
				//                                     v54.fields.rippleRoughnessMaskThreshold = v93;
				//                                     v55 = this.fields.rainCommonRenderingParam;
				//                                     if ( v55 )
				//                                     {
				//                                       v55.fields.rippleFrequency = v89;
				//                                       v56 = this.fields.rainCommonRenderingParam;
				//                                       if ( v56 )
				//                                       {
				//                                         v56.fields.rippleWaveSpeed = v91;
				//                                         v57 = this.fields.rainCommonRenderingParam;
				//                                         if ( v57 )
				//                                         {
				//                                           v57.fields.farSceneWetnessDistanceFactor = v94;
				//                                           v58 = this.fields.rainCommonRenderingParam;
				//                                           if ( v58 )
				//                                           {
				//                                             v58.fields.farSceneWetnessValue = v95;
				//                                             v59 = this.fields.rainCommonRenderingParam;
				//                                             if ( v59 )
				//                                             {
				//                                               v59.fields.rainCenterBias = v78;
				//                                               v60 = this.fields.rainCommonRenderingParam;
				//                                               if ( v60 )
				//                                               {
				//                                                 v5 = this.fields.rainCommonRenderingParam;
				//                                                 v60.fields.wetnessHighQualityKwEnabled = enableHighQualityWetness
				//                                                                                        && v60.fields.enableWetness;
				//                                                 if ( (_BYTE)p_rainConfig )
				//                                                   v37 = v96;
				//                                                 v61 = this.fields.rainCommonRenderingParam;
				//                                                 if ( v61 )
				//                                                 {
				//                                                   v61.fields.wetnessProceduralForWater = v37;
				//                                                   return;
				//                                                 }
				//                                               }
				//                                             }
				//                                           }
				//                                         }
				//                                       }
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
				// LABEL_64:
				//         sub_180B536AC(v5, p_rainConfig);
				//       }
				// LABEL_19:
				//       if ( !hgCamera )
				//         goto LABEL_64;
				//       klass = hgCamera[157].klass;
				//       if ( !klass )
				//         goto LABEL_64;
				//       if ( BYTE4(klass._0.byval_arg.data.type) )
				//       {
				//         name = (HGEnvironmentPhase *)klass._0.name;
				//       }
				//       else
				//       {
				//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, p_rainConfig);
				//         name = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
				//       }
				//       goto LABEL_23;
				//     }
				// LABEL_79:
				//     sub_180070270(v5, p_rainConfig);
				//   }
				//   v62 = IFix::WrappersManagerImpl::GetPatch(735, 0LL);
				//   if ( !v62 )
				//     goto LABEL_64;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
				//     (ILFixDynamicMethodWrapper_28 *)v62,
				//     (Object *)this,
				//     enableHighQualityWetness,
				//     0LL);
				// }
				// 
			}

			private void _PrepareRainRenderData(float deltaTime, HGRainRenderer.RainWetnessQualityParams qualityParams, ref ScriptableRenderContext renderContext)
			{
				// // Void _PrepareRainRenderData(Single, HGRainRenderer+RainWetnessQualityParams, ScriptableRenderContext ByRef)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareRainRenderData(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         float deltaTime,
				//         HGRainRenderer_RainWetnessQualityParams *qualityParams,
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
				//   OneofDescriptorProto *v15; // rdx
				//   __int64 v16; // rcx
				//   FileDescriptor *v17; // r8
				//   MessageDescriptor *v18; // r9
				//   List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rsi
				//   __int64 v20; // rdx
				//   __int64 v21; // rcx
				//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *fields; // rbx
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   __int64 v24; // rdx
				//   __int64 v25; // rcx
				//   RainCommonRenderingParam **p_rainCommonRenderingParam; // rsi
				//   HGCamera *hgCamera; // r14
				//   __int64 v28; // rdx
				//   __int64 v29; // rcx
				//   String__Array *P3; // [rsp+20h] [rbp-68h]
				//   ScriptableRenderContext *P3a; // [rsp+20h] [rbp-68h]
				//   MethodInfo *v32; // [rsp+28h] [rbp-60h]
				//   OneofDescriptor v33; // [rsp+30h] [rbp-58h] BYREF
				// 
				//   if ( !byte_18D8EDC90 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
				//     byte_18D8EDC90 = 1;
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
				//   if ( wrapperArray.max_length.size > 738 )
				//   {
				//     if ( !v9._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v9, v5);
				//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v11 = v9.static_fields.wrapperArray;
				//     if ( !v11 )
				//       sub_180B536AC(v9, v5);
				//     if ( v11.max_length.size <= 0x2E2u )
				//       sub_180070270(v9, v5);
				//     if ( v11[20].vector[18] )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(738, 0LL);
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
				//   HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainCommonParams(
				//     this,
				//     deltaTime,
				//     qualityParams,
				//     0LL);
				//   subRainRenderers = this.fields.subRainRenderers;
				//   if ( !subRainRenderers )
				//     sub_180B536AC(v16, v15);
				//   *(_OWORD *)&v33.monitor = 0LL;
				//   v33.klass = (OneofDescriptor__Class *)subRainRenderers;
				//   ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
				//     &v33,
				//     v15,
				//     v17,
				//     v18,
				//     P3,
				//     (String *)v32);
				//   LODWORD(v33.monitor) = 0;
				//   HIDWORD(v33.monitor) = subRainRenderers.fields._version;
				//   *(_QWORD *)&v33.fields._._Index_k__BackingField = 0LL;
				//   *(_OWORD *)&v33.fields._._File_k__BackingField = *(_OWORD *)&v33.klass;
				//   v33.fields.fields = 0LL;
				//   v33.klass = 0LL;
				//   v33.monitor = (MonitorData *)&v33.fields._._File_k__BackingField;
				//   try
				//   {
				//     while ( 1 )
				//     {
				//       if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//               (List_1_T_Enumerator_System_Object_ *)&v33.fields._._File_k__BackingField,
				//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
				//         return;
				//       fields = v33.fields.fields;
				//       rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//       if ( !rainCommonRenderingParam )
				//         sub_1802DC2C8(v21, v20);
				//       if ( rainCommonRenderingParam.fields.enable )
				//       {
				//         if ( !v33.fields.fields )
				//           sub_1802DC2C8(v21, v20);
				//         *(float *)&P3a = deltaTime;
				//         sub_180835B78(v21, v33.fields.fields, (_DWORD)this + 48, this.fields.hgCamera, (__int64)P3a);
				//         if ( !fields )
				//           sub_1802DC2C8(v29, v28);
				//         sub_18052EA20(v29, fields, &this.fields.rainCommonRenderingParam, renderContext);
				//       }
				//       else
				//       {
				//         if ( !v33.fields.fields )
				//           sub_1802DC2C8(v21, v20);
				//         if ( (unsigned __int8)sub_1800023D0(10LL, v33.fields.fields) )
				//         {
				//           if ( !fields )
				//             sub_1802DC2C8(v25, v24);
				//           sub_180040B30(11LL, fields);
				//           p_rainCommonRenderingParam = &this.fields.rainCommonRenderingParam;
				//           hgCamera = this.fields.hgCamera;
				//           goto LABEL_30;
				//         }
				//       }
				//       p_rainCommonRenderingParam = &this.fields.rainCommonRenderingParam;
				//       hgCamera = this.fields.hgCamera;
				//       if ( !fields )
				//         sub_1802DC2C8(v25, v24);
				// LABEL_30:
				//       sub_180003EE0(fields.klass);
				//       (*((void (__fastcall **)(IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *, RainCommonRenderingParam **, HGCamera *, Il2CppClass *))&fields.klass[1]._0.this_arg
				//        + 1))(
				//         fields,
				//         p_rainCommonRenderingParam,
				//         hgCamera,
				//         fields.klass[1]._0.element_class);
				//     }
				//   }
				//   catch ( Il2CppExceptionWrapper *&v33.fields._._FullName_k__BackingField )
				//   {
				//     v33.klass = (OneofDescriptor__Class *)v33.fields._._FullName_k__BackingField.klass;
				//     if ( v33.klass )
				//       sub_18000F780(v33.klass);
				//   }
				// }
				// 
			}

			private void _UpdateRainCommonParams(float deltaTime, HGRainRenderer.RainWetnessQualityParams qualityParams)
			{
				// // Void _UpdateRainCommonParams(Single, HGRainRenderer+RainWetnessQualityParams)
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainCommonParams(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         float deltaTime,
				//         HGRainRenderer_RainWetnessQualityParams *qualityParams,
				//         MethodInfo *method)
				// {
				//   __int64 v4; // rdx
				//   unsigned __int64 static_fields; // rcx
				//   __int64 wrapperArray; // rdx
				//   Object *hgCamera; // rsi
				//   Object__Class *klass; // rax
				//   HGEnvironmentPhase *name; // rax
				//   HGRainConfig *p_rainConfig; // rax
				//   __int128 v14; // xmm0
				//   __int128 v15; // xmm1
				//   __int128 v16; // xmm0
				//   __int128 v17; // xmm1
				//   __int128 v18; // xmm0
				//   __int128 v19; // xmm1
				//   __int128 v20; // xmm0
				//   __int128 v21; // xmm1
				//   __int128 v22; // xmm1
				//   __int128 v23; // xmm0
				//   HGCamera *v24; // rax
				//   Object *camera; // rsi
				//   HGCamera *v26; // rax
				//   Camera *v27; // rsi
				//   unsigned __int8 (__fastcall *v28)(Camera *, __int64, HGRainRenderer_RainWetnessQualityParams *, MethodInfo *); // rax
				//   HGCamera *v29; // rax
				//   Camera *v30; // rsi
				//   double (__fastcall *v31)(Camera *); // rax
				//   __int64 v32; // rdx
				//   double v33; // xmm0_8
				//   struct HGRainRenderer__Class *v34; // rcx
				//   float v35; // xmm6_4
				//   float v36; // xmm6_4
				//   HGCamera *v37; // rsi
				//   Camera *v38; // rsi
				//   __int64 (__fastcall *v39)(Camera *); // rax
				//   __int64 v40; // rsi
				//   void (__fastcall *v41)(__int64, Quaternion *); // rax
				//   __m128 v42; // xmm7
				//   Vector3 *v43; // rax
				//   __int64 v44; // xmm0_8
				//   MethodInfo *v45; // r8
				//   Beyond::JobMathf *v46; // rcx
				//   float v47; // xmm6_4
				//   RainCommonRenderingParam *v48; // rax
				//   float v49; // xmm0_4
				//   RainCommonRenderingParam *v50; // rax
				//   RainCommonRenderingParam *v51; // rax
				//   RainCommonRenderingParam *v52; // rax
				//   RainCommonRenderingParam *v53; // rax
				//   RainCommonRenderingParam *v54; // rax
				//   RainCommonRenderingParam *v55; // rax
				//   RainCommonRenderingParam *v56; // rax
				//   RainCommonRenderingParam *v57; // rax
				//   RainCommonRenderingParam *v58; // rax
				//   RainCommonRenderingParam *v59; // rax
				//   RainCommonRenderingParam *v60; // rax
				//   RainCommonRenderingParam *v61; // rax
				//   RainCommonRenderingParam *v62; // rax
				//   RainCommonRenderingParam *v63; // rax
				//   RainCommonRenderingParam *v64; // rax
				//   RainCommonRenderingParam *v65; // rax
				//   RainCommonRenderingParam *v66; // rax
				//   RainCommonRenderingParam *v67; // rax
				//   RainCommonRenderingParam *v68; // rax
				//   RainCommonRenderingParam *v69; // rax
				//   RainCommonRenderingParam *v70; // rax
				//   RainCommonRenderingParam *v71; // rax
				//   RainCommonRenderingParam *v72; // rsi
				//   int32_t v73; // eax
				//   RainCommonRenderingParam *v74; // rax
				//   RainCommonRenderingParam *v75; // rax
				//   RainCommonRenderingParam *v76; // rax
				//   float v77; // xmm1_4
				//   RainCommonRenderingParam *v78; // rax
				//   float v79; // xmm1_4
				//   RainCommonRenderingParam *v80; // rax
				//   float v81; // xmm1_4
				//   RainCommonRenderingParam *v82; // rax
				//   float v83; // xmm1_4
				//   int32_t rainSplashMaxCount; // eax
				//   RainCommonRenderingParam *v85; // rax
				//   RainCommonRenderingParam *v86; // rax
				//   RainCommonRenderingParam *v87; // rax
				//   float v88; // xmm1_4
				//   RainCommonRenderingParam *v89; // rax
				//   RainCommonRenderingParam *v90; // rax
				//   RainCommonRenderingParam *v91; // rax
				//   __int64 v92; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v94; // rax
				//   ILFixDynamicMethodWrapper_2 *v95; // rax
				//   __int64 v96; // rax
				//   ILFixDynamicMethodWrapper_2 *v97; // rax
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   __int64 v99; // rax
				//   __int64 v100; // rax
				//   __int64 v101; // rax
				//   __int64 v102; // rax
				//   HGCamera *v103; // rax
				//   Transform *transform; // rax
				//   Vector3 *position; // rax
				//   MethodInfo *v106; // r9
				//   __int64 v107; // xmm10_8
				//   float z; // esi
				//   __int64 v109; // xmm0_8
				//   Vector3 *v110; // rax
				//   __m128 v111; // xmm3
				//   float v112; // xmm1_4
				//   RainCommonRenderingParam *v113; // rax
				//   __int64 v114; // rax
				//   __int64 v115; // xmm6_8
				//   float v116; // ebx
				//   MethodInfo *v117; // r9
				//   Vector3 *v118; // rax
				//   __int64 v119; // xmm3_8
				//   __int64 v120; // rax
				//   __int64 v121; // xmm11_8
				//   float v122; // r14d
				//   MethodInfo *v123; // r9
				//   Vector3 *v124; // rax
				//   __int64 v125; // xmm3_8
				//   __int64 v126; // rax
				//   __int64 v127; // xmm12_8
				//   float v128; // r15d
				//   MethodInfo *v129; // r9
				//   Vector3 *v130; // rax
				//   __int64 v131; // xmm3_8
				//   __int64 v132; // rax
				//   __int64 v133; // xmm13_8
				//   float v134; // r12d
				//   RainCommonRenderingParam *v135; // rax
				//   RainCommonRenderingParam *v136; // rax
				//   RainCommonPreSettingParam *commonPresettingParam; // rax
				//   MethodInfo *v138; // r9
				//   float v139; // xmm0_4
				//   RainCommonRenderingParam *v140; // rbx
				//   float v141; // eax
				//   Vector3 *v142; // rax
				//   __int64 v143; // xmm3_8
				//   MethodInfo *v144; // r9
				//   Vector3 *v145; // rax
				//   __int64 v146; // xmm3_8
				//   MethodInfo *v147; // r9
				//   Vector3 *v148; // rax
				//   __int64 v149; // xmm3_8
				//   __int64 v150; // rax
				//   MethodInfo *v151; // r9
				//   RainCommonRenderingParam *v152; // rbx
				//   float v153; // eax
				//   Vector3 *v154; // rax
				//   __int64 v155; // xmm3_8
				//   MethodInfo *v156; // r9
				//   Vector3 *v157; // rax
				//   __int64 v158; // xmm3_8
				//   MethodInfo *v159; // r9
				//   Vector3 *v160; // rax
				//   __int64 v161; // xmm3_8
				//   __int64 v162; // rax
				//   MethodInfo *v163; // r9
				//   RainCommonRenderingParam *v164; // rbx
				//   float v165; // eax
				//   Vector3 *v166; // rax
				//   __int64 v167; // xmm3_8
				//   MethodInfo *v168; // r9
				//   Vector3 *v169; // rax
				//   __int64 v170; // xmm3_8
				//   MethodInfo *v171; // r9
				//   Vector3 *v172; // rax
				//   __int64 v173; // xmm3_8
				//   __int64 v174; // rax
				//   MethodInfo *v175; // r8
				//   RainCommonRenderingParam *v176; // rax
				//   __int64 v177; // xmm0_8
				//   float v178; // eax
				//   float v179; // xmm1_4
				//   RainCommonRenderingParam *v180; // rax
				//   Vector3 v181; // [rsp+30h] [rbp-D0h] BYREF
				//   Vector3 v182; // [rsp+40h] [rbp-C0h] BYREF
				//   Vector3 v183; // [rsp+50h] [rbp-B0h] BYREF
				//   Quaternion v184; // [rsp+60h] [rbp-A0h] BYREF
				//   char v185; // [rsp+70h] [rbp-90h] BYREF
				//   float v186; // [rsp+74h] [rbp-8Ch]
				//   float v187; // [rsp+78h] [rbp-88h]
				//   Color v188; // [rsp+7Ch] [rbp-84h]
				//   float v189; // [rsp+8Ch] [rbp-74h]
				//   float v190; // [rsp+98h] [rbp-68h]
				//   float v191; // [rsp+9Ch] [rbp-64h]
				//   float v192; // [rsp+A0h] [rbp-60h]
				//   float v193; // [rsp+A8h] [rbp-58h]
				//   float v194; // [rsp+ACh] [rbp-54h]
				//   float v195; // [rsp+B8h] [rbp-48h]
				//   float v196; // [rsp+BCh] [rbp-44h]
				//   float v197; // [rsp+C0h] [rbp-40h]
				//   float v198; // [rsp+CCh] [rbp-34h]
				//   float v199; // [rsp+D0h] [rbp-30h]
				//   float v200; // [rsp+D4h] [rbp-2Ch]
				//   float v201; // [rsp+D8h] [rbp-28h]
				//   Color v202; // [rsp+DCh] [rbp-24h]
				//   float v203; // [rsp+F0h] [rbp-10h]
				//   float v204; // [rsp+F4h] [rbp-Ch]
				//   float v205; // [rsp+F8h] [rbp-8h]
				//   float v206; // [rsp+FCh] [rbp-4h]
				//   float v207; // [rsp+100h] [rbp+0h]
				//   float v208; // [rsp+104h] [rbp+4h]
				//   float v209; // [rsp+108h] [rbp+8h]
				//   float v210; // [rsp+10Ch] [rbp+Ch]
				//   float v211; // [rsp+110h] [rbp+10h]
				//   float v212; // [rsp+114h] [rbp+14h]
				//   int v213; // [rsp+118h] [rbp+18h]
				//   float v214; // [rsp+11Ch] [rbp+1Ch]
				//   float v215; // [rsp+120h] [rbp+20h]
				//   float v216; // [rsp+124h] [rbp+24h]
				//   float v217; // [rsp+128h] [rbp+28h]
				//   float v218; // [rsp+12Ch] [rbp+2Ch]
				//   __int64 v219; // [rsp+178h] [rbp+78h]
				//   float v220; // [rsp+180h] [rbp+80h]
				//   Vector3 v221; // [rsp+184h] [rbp+84h]
				//   Vector3 v222; // [rsp+190h] [rbp+90h]
				// 
				//   if ( !byte_18D8EDC91 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D8EDC91 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_93;
				//   if ( *(int *)(wrapperArray + 24) > 739 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     wrapperArray = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v92 = *(_QWORD *)wrapperArray;
				//     if ( !*(_QWORD *)wrapperArray )
				//       goto LABEL_93;
				//     if ( *(_DWORD *)(v92 + 24) <= 0x2E3u )
				//       goto LABEL_120;
				//     if ( *(_QWORD *)(v92 + 5944) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(739, 0LL);
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
				//       goto LABEL_93;
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
				//   wrapperArray = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_93;
				//   if ( *(int *)(wrapperArray + 24) <= 439 )
				//     goto LABEL_155;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   wrapperArray = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v94 = *(_QWORD *)wrapperArray;
				//   if ( !*(_QWORD *)wrapperArray )
				//     goto LABEL_93;
				//   if ( *(_DWORD *)(v94 + 24) <= 0x1B7u )
				//     goto LABEL_120;
				//   if ( *(_QWORD *)(v94 + 3544) )
				//   {
				//     v95 = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
				//     if ( !v95 )
				//       goto LABEL_93;
				//     name = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(v95, hgCamera, 0LL);
				//   }
				//   else
				//   {
				// LABEL_155:
				//     if ( !hgCamera )
				//       goto LABEL_93;
				//     klass = hgCamera[157].klass;
				//     if ( !klass )
				//       goto LABEL_93;
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
				//     goto LABEL_93;
				//   p_rainConfig = &name.fields.rainConfig;
				//   static_fields = (unsigned __int64)&v185;
				//   wrapperArray = 2LL;
				//   do
				//   {
				//     static_fields += 128LL;
				//     v14 = *(_OWORD *)&p_rainConfig.enable;
				//     v15 = *(_OWORD *)&p_rainConfig.color.g;
				//     p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
				//     *(_OWORD *)(static_fields - 128) = v14;
				//     v16 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
				//     *(_OWORD *)(static_fields - 112) = v15;
				//     v17 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
				//     *(_OWORD *)(static_fields - 96) = v16;
				//     v18 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
				//     *(_OWORD *)(static_fields - 80) = v17;
				//     v19 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
				//     *(_OWORD *)(static_fields - 64) = v18;
				//     v20 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
				//     *(_OWORD *)(static_fields - 48) = v19;
				//     v21 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
				//     *(_OWORD *)(static_fields - 32) = v20;
				//     *(_OWORD *)(static_fields - 16) = v21;
				//     --wrapperArray;
				//   }
				//   while ( wrapperArray );
				//   v22 = *(_OWORD *)&p_rainConfig.color.g;
				//   *(_OWORD *)static_fields = *(_OWORD *)&p_rainConfig.enable;
				//   v23 = *(_OWORD *)&p_rainConfig.horizontalRainAngle;
				//   v24 = this.fields.hgCamera;
				//   *(_OWORD *)(static_fields + 16) = v22;
				//   *(_OWORD *)(static_fields + 32) = v23;
				//   if ( !v24 )
				//     goto LABEL_93;
				//   camera = (Object *)v24.fields.camera;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, 0LL);
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_93;
				//   if ( *(int *)(wrapperArray + 24) <= 736 )
				//     goto LABEL_35;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v96 = *(_QWORD *)static_fields;
				//   if ( !*(_QWORD *)static_fields )
				//     goto LABEL_93;
				//   if ( *(_DWORD *)(v96 + 24) <= 0x2E0u )
				// LABEL_120:
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( *(_QWORD *)(v96 + 5920) )
				//   {
				//     v97 = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
				//     if ( !v97 )
				//       goto LABEL_93;
				//     if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v97, camera, 0LL) )
				//     {
				//       rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//       if ( rainCommonRenderingParam )
				//       {
				//         rainCommonRenderingParam.fields.enable = 0;
				//         return;
				//       }
				//       goto LABEL_93;
				//     }
				//   }
				// LABEL_35:
				//   v26 = this.fields.hgCamera;
				//   if ( !v26 )
				//     goto LABEL_93;
				//   v27 = v26.fields.camera;
				//   if ( !v27 )
				//     goto LABEL_93;
				//   v28 = (unsigned __int8 (__fastcall *)(Camera *, __int64, HGRainRenderer_RainWetnessQualityParams *, MethodInfo *))qword_18D8F41C8;
				//   if ( !qword_18D8F41C8 )
				//   {
				//     v28 = (unsigned __int8 (__fastcall *)(Camera *, __int64, HGRainRenderer_RainWetnessQualityParams *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
				//     if ( !v28 )
				//     {
				//       v99 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
				//       sub_18000F750(v99, 0LL);
				//     }
				//     qword_18D8F41C8 = (__int64)v28;
				//   }
				//   if ( v28(v27, wrapperArray, qualityParams, method) )
				//   {
				//     v42 = 0LL;
				//     v47 = 0.0;
				//   }
				//   else
				//   {
				//     v29 = this.fields.hgCamera;
				//     if ( !v29 )
				//       goto LABEL_93;
				//     v30 = v29.fields.camera;
				//     if ( !v30 )
				//       goto LABEL_93;
				//     v31 = (double (__fastcall *)(Camera *))qword_18D8F4198;
				//     if ( !qword_18D8F4198 )
				//     {
				//       v31 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_fieldOfView()");
				//       if ( !v31 )
				//       {
				//         v100 = sub_1802DBBE8("UnityEngine.Camera::get_fieldOfView()");
				//         sub_18000F750(v100, 0LL);
				//       }
				//       qword_18D8F4198 = (__int64)v31;
				//     }
				//     v33 = v31(v30);
				//     v34 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//     v35 = *(float *)&v33;
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, v32);
				//       v34 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//     }
				//     v36 = (float)(v35 - v34.static_fields.FOV_FADE_LOWERTHRESHOLD)
				//         / (float)(v34.static_fields.FOV_FADE_HIGHERTHRESHOLD - v34.static_fields.FOV_FADE_LOWERTHRESHOLD);
				//     Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v34);
				//     v37 = this.fields.hgCamera;
				//     if ( !v37 )
				//       goto LABEL_93;
				//     v38 = v37.fields.camera;
				//     if ( !v38 )
				//       goto LABEL_93;
				//     v39 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
				//     if ( !qword_18D8F4D40 )
				//     {
				//       v39 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
				//       if ( !v39 )
				//       {
				//         v101 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
				//         sub_18000F750(v101, 0LL);
				//       }
				//       qword_18D8F4D40 = (__int64)v39;
				//     }
				//     v40 = v39(v38);
				//     if ( !v40 )
				//       goto LABEL_93;
				//     v41 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
				//     v184 = 0LL;
				//     if ( !qword_18D8F5300 )
				//     {
				//       v41 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
				//                                                           "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
				//       if ( !v41 )
				//       {
				//         v102 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
				//         sub_18000F750(v102, 0LL);
				//       }
				//       qword_18D8F5300 = (__int64)v41;
				//     }
				//     v41(v40, &v184);
				//     v42 = 0LL;
				//     v183.z = 1.0;
				//     *(_QWORD *)&v183.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//     v43 = UnityEngine::Quaternion::op_Multiply(&v182, &v184, &v183, 0LL);
				//     v183.z = 0.0;
				//     *(_QWORD *)&v183.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
				//     v44 = *(_QWORD *)&v43.x;
				//     *(float *)&v43 = v43.z;
				//     *(_QWORD *)&v181.x = v44;
				//     LODWORD(v181.z) = (_DWORD)v43;
				//     *(float *)&v44 = (float)(UnityEngine::Vector3::Dot(&v181, &v183, v45) - 0.89999998) * 10.0;
				//     Beyond::JobMathf::Clamp01(v46);
				//     v47 = fmaxf(v36, 1.0 - *(float *)&v44);
				//   }
				//   static_fields = (unsigned __int64)this.fields.rainCommonRenderingParam;
				//   if ( !static_fields )
				//     goto LABEL_93;
				//   *(_BYTE *)(static_fields + 16) = v185;
				//   v48 = this.fields.rainCommonRenderingParam;
				//   if ( !v48 )
				//     goto LABEL_93;
				//   v49 = v186;
				//   v48.fields.rawIntensity = v186;
				//   v50 = this.fields.rainCommonRenderingParam;
				//   if ( !v50 )
				//     goto LABEL_93;
				//   v50.fields.intensity = v49 * v47;
				//   v51 = this.fields.rainCommonRenderingParam;
				//   if ( !v51 )
				//     goto LABEL_93;
				//   v51.fields.speed = v187;
				//   v52 = this.fields.rainCommonRenderingParam;
				//   if ( !v52 )
				//     goto LABEL_93;
				//   v52.fields.color = v188;
				//   v53 = this.fields.rainCommonRenderingParam;
				//   if ( !v53 )
				//     goto LABEL_93;
				//   v53.fields.color.a = v47 * v53.fields.color.a;
				//   v54 = this.fields.rainCommonRenderingParam;
				//   if ( !v54 )
				//     goto LABEL_93;
				//   v54.fields.streakLength = v189;
				//   v55 = this.fields.rainCommonRenderingParam;
				//   if ( !v55 )
				//     goto LABEL_93;
				//   v55.fields.sceneEffectRainLightingPercent = v192;
				//   v56 = this.fields.rainCommonRenderingParam;
				//   if ( !qualityParams )
				//     goto LABEL_93;
				//   static_fields = qualityParams.fields.enableMiddleRain;
				//   if ( !v56 )
				//     goto LABEL_93;
				//   v56.fields.enableMiddleRain = static_fields;
				//   v57 = this.fields.rainCommonRenderingParam;
				//   static_fields = qualityParams.fields.enableRainLighting;
				//   if ( !v57 )
				//     goto LABEL_93;
				//   v57.fields.enableRainLighting = static_fields;
				//   v58 = this.fields.rainCommonRenderingParam;
				//   if ( !v58 )
				//     goto LABEL_93;
				//   v58.fields.middleRainLayerSpeedDiffMultiplier = v193;
				//   v59 = this.fields.rainCommonRenderingParam;
				//   if ( !v59 )
				//     goto LABEL_93;
				//   v59.fields.middleRainAlphaMultiplier = v194;
				//   v60 = this.fields.rainCommonRenderingParam;
				//   if ( !v60 )
				//     goto LABEL_93;
				//   v60.fields.middleRainLightingPercent = v195;
				//   v61 = this.fields.rainCommonRenderingParam;
				//   if ( !v61 )
				//     goto LABEL_93;
				//   v61.fields.farRainLayerSpeedDiffMultiplier = v196;
				//   v62 = this.fields.rainCommonRenderingParam;
				//   if ( !v62 )
				//     goto LABEL_93;
				//   v62.fields.farRainAlphaMultiplier = v197;
				//   v63 = this.fields.rainCommonRenderingParam;
				//   if ( !v63 )
				//     goto LABEL_93;
				//   v63.fields.sceneEffectRainJitterLevel = v190;
				//   v64 = this.fields.rainCommonRenderingParam;
				//   if ( !v64 )
				//     goto LABEL_93;
				//   v64.fields.sceneEffectRainWidthScale = v191;
				//   v65 = this.fields.rainCommonRenderingParam;
				//   static_fields = (unsigned int)qualityParams.fields.sceneEffectRainLayerCount;
				//   if ( !v65 )
				//     goto LABEL_93;
				//   v65.fields.sceneEffectRainLayerCount = static_fields;
				//   v66 = this.fields.rainCommonRenderingParam;
				//   static_fields = qualityParams.fields.enableRainWave;
				//   if ( !v66 )
				//     goto LABEL_93;
				//   v66.fields.enableRainWave = static_fields;
				//   v67 = this.fields.rainCommonRenderingParam;
				//   if ( !v67 )
				//     goto LABEL_93;
				//   v67.fields.rainWaveAlpha = v200;
				//   v68 = this.fields.rainCommonRenderingParam;
				//   if ( !v68 )
				//     goto LABEL_93;
				//   v68.fields.rainWaveVerticalSpeed = v198;
				//   v69 = this.fields.rainCommonRenderingParam;
				//   if ( !v69 )
				//     goto LABEL_93;
				//   v69.fields.rainWaveHorizontalSpeed = v199;
				//   v70 = this.fields.rainCommonRenderingParam;
				//   if ( !v70 )
				//     goto LABEL_93;
				//   v70.fields.rainWaveBottomFadeFactor = v201;
				//   v71 = this.fields.rainCommonRenderingParam;
				//   if ( !v71 )
				//     goto LABEL_93;
				//   v71.fields.screenDropColor = v202;
				//   v72 = this.fields.rainCommonRenderingParam;
				//   v73 = sub_1826E82D0();
				//   if ( !v72 )
				//     goto LABEL_93;
				//   v72.fields.screenDropMaxCountLim = v73;
				//   v74 = this.fields.rainCommonRenderingParam;
				//   if ( !v74 )
				//     goto LABEL_93;
				//   v74.fields.screenDropFlowPercent = v209;
				//   v75 = this.fields.rainCommonRenderingParam;
				//   if ( !v75 )
				//     goto LABEL_93;
				//   v75.fields.screenDropJitterSpeedScale = v212;
				//   v76 = this.fields.rainCommonRenderingParam;
				//   if ( !v76 )
				//     goto LABEL_93;
				//   v77 = v204;
				//   v76.fields.screenDropMinMaxLifeTime.x = v203;
				//   v76.fields.screenDropMinMaxLifeTime.y = v77;
				//   v78 = this.fields.rainCommonRenderingParam;
				//   if ( !v78 )
				//     goto LABEL_93;
				//   v79 = v206;
				//   v78.fields.screenDropMinMaxSize.x = v205;
				//   v78.fields.screenDropMinMaxSize.y = v79;
				//   v80 = this.fields.rainCommonRenderingParam;
				//   if ( !v80 )
				//     goto LABEL_93;
				//   v81 = v211;
				//   v80.fields.screenDropMinMaxSpeed.x = v210;
				//   v80.fields.screenDropMinMaxSpeed.y = v81;
				//   v82 = this.fields.rainCommonRenderingParam;
				//   if ( !v82 )
				//     goto LABEL_93;
				//   v83 = v208;
				//   v82.fields.screenDropCentroidFadeParam.x = v207;
				//   v82.fields.screenDropCentroidFadeParam.y = v83;
				//   wrapperArray = (__int64)this.fields.rainCommonRenderingParam;
				//   static_fields = (unsigned int)qualityParams.fields.rainSplashMaxCount;
				//   if ( !wrapperArray )
				//     goto LABEL_93;
				//   rainSplashMaxCount = v213;
				//   if ( v213 >= (int)static_fields )
				//     rainSplashMaxCount = qualityParams.fields.rainSplashMaxCount;
				//   *(_DWORD *)(wrapperArray + 228) = rainSplashMaxCount;
				//   v85 = this.fields.rainCommonRenderingParam;
				//   if ( !v85 )
				//     goto LABEL_93;
				//   v85.fields.rainSplashSpeed = v214;
				//   v86 = this.fields.rainCommonRenderingParam;
				//   if ( !v86 )
				//     goto LABEL_93;
				//   v86.fields.rainSplashAlpha = v215;
				//   v87 = this.fields.rainCommonRenderingParam;
				//   if ( !v87 )
				//     goto LABEL_93;
				//   v88 = v217;
				//   v87.fields.rainSplashMinMaxSize.x = v216;
				//   v87.fields.rainSplashMinMaxSize.y = v88;
				//   v89 = this.fields.rainCommonRenderingParam;
				//   if ( !v89 )
				//     goto LABEL_93;
				//   v89.fields.rainSplashLightingPercent = v218;
				//   v90 = this.fields.rainCommonRenderingParam;
				//   static_fields = (unsigned int)this.fields.cameraMask;
				//   if ( !v90 )
				//     goto LABEL_93;
				//   v90.fields.cameraMask = static_fields;
				//   v91 = this.fields.rainCommonRenderingParam;
				//   if ( !v91 )
				//     goto LABEL_93;
				//   if ( v91.fields.enable )
				//   {
				//     v103 = this.fields.hgCamera;
				//     if ( v103 )
				//     {
				//       static_fields = (unsigned __int64)v103.fields.camera;
				//       if ( static_fields )
				//       {
				//         transform = UnityEngine::Component::get_transform((Component *)static_fields, 0LL);
				//         if ( transform )
				//         {
				//           position = UnityEngine::Transform::get_position(&v182, transform, 0LL);
				//           static_fields = (unsigned __int64)this.fields.rainCommonRenderingParam;
				//           v107 = *(_QWORD *)&position.x;
				//           z = position.z;
				//           if ( static_fields )
				//           {
				//             v109 = *(_QWORD *)(static_fields + 136);
				//             v181.z = *(float *)(static_fields + 144);
				//             *(_QWORD *)&v181.x = v109;
				//             *(_QWORD *)&v183.x = v107;
				//             v183.z = z;
				//             v110 = UnityEngine::Vector3::op_Subtraction(&v182, &v183, &v181, v106);
				//             v111 = (__m128)*(unsigned __int64 *)&v110.x;
				//             v112 = v110.z;
				//             v113 = this.fields.rainCommonRenderingParam;
				//             *(_QWORD *)&v181.x = v111.m128_u64[0];
				//             if ( v113 )
				//             {
				//               static_fields = (unsigned __int64)v113.fields.commonPresettingParam;
				//               if ( static_fields )
				//               {
				//                 v181.z = v112;
				//                 *(_QWORD *)&v181.x = _mm_unpacklo_ps(v111, v42).m128_u64[0];
				//                 v114 = sub_182AA2B90(&v182, &v181);
				//                 *(_QWORD *)&v183.x = v219;
				//                 v116 = *(float *)(v114 + 8);
				//                 *(_QWORD *)&v181.x = *(_QWORD *)v114;
				//                 v115 = *(_QWORD *)&v181.x;
				//                 v183.z = v220;
				//                 v181.z = v116;
				//                 v118 = UnityEngine::Vector3::op_Subtraction(&v182, &v183, &v181, v117);
				//                 v119 = *(_QWORD *)&v118.x;
				//                 *(float *)&v118 = v118.z;
				//                 *(_QWORD *)&v183.x = v119;
				//                 LODWORD(v183.z) = (_DWORD)v118;
				//                 v120 = sub_182413270(&v182, &v183);
				//                 *(_QWORD *)&v181.x = v115;
				//                 v181.z = v116;
				//                 v121 = *(_QWORD *)v120;
				//                 v122 = *(float *)(v120 + 8);
				//                 v182 = v221;
				//                 v124 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v184, &v182, &v181, v123);
				//                 v125 = *(_QWORD *)&v124.x;
				//                 *(float *)&v124 = v124.z;
				//                 *(_QWORD *)&v183.x = v125;
				//                 LODWORD(v183.z) = (_DWORD)v124;
				//                 v126 = sub_182413270(&v184, &v183);
				//                 *(_QWORD *)&v182.x = v115;
				//                 v182.z = v116;
				//                 v127 = *(_QWORD *)v126;
				//                 v128 = *(float *)(v126 + 8);
				//                 v181 = v222;
				//                 v130 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v184, &v181, &v182, v129);
				//                 v131 = *(_QWORD *)&v130.x;
				//                 *(float *)&v130 = v130.z;
				//                 *(_QWORD *)&v183.x = v131;
				//                 LODWORD(v183.z) = (_DWORD)v130;
				//                 v132 = sub_182413270(&v184, &v183);
				//                 v133 = *(_QWORD *)v132;
				//                 v134 = *(float *)(v132 + 8);
				//                 v135 = this.fields.rainCommonRenderingParam;
				//                 if ( v135 )
				//                 {
				//                   *(_QWORD *)&v135.fields.lastCamPos.x = v107;
				//                   v135.fields.lastCamPos.z = z;
				//                   v136 = this.fields.rainCommonRenderingParam;
				//                   if ( v136 )
				//                   {
				//                     commonPresettingParam = v136.fields.commonPresettingParam;
				//                     if ( commonPresettingParam )
				//                     {
				//                       v139 = HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
				//                                commonPresettingParam.fields.rainTemporalTimeThreshould,
				//                                deltaTime,
				//                                0LL);
				//                       v140 = this.fields.rainCommonRenderingParam;
				//                       if ( v140 )
				//                       {
				//                         v141 = v140.fields.rainDirection.z;
				//                         *(_QWORD *)&v181.x = *(_QWORD *)&v140.fields.rainDirection.x;
				//                         v181.z = v141;
				//                         *(_QWORD *)&v182.x = v121;
				//                         v182.z = v122;
				//                         v142 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v182, 1.0 - v139, v138);
				//                         v143 = *(_QWORD *)&v142.x;
				//                         *(float *)&v142 = v142.z;
				//                         *(_QWORD *)&v182.x = v143;
				//                         LODWORD(v182.z) = (_DWORD)v142;
				//                         v145 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v181, v139, v144);
				//                         v146 = *(_QWORD *)&v145.x;
				//                         *(float *)&v145 = v145.z;
				//                         *(_QWORD *)&v181.x = v146;
				//                         LODWORD(v181.z) = (_DWORD)v145;
				//                         v148 = UnityEngine::Vector3::op_Addition((Vector3 *)&v184, &v181, &v182, v147);
				//                         v149 = *(_QWORD *)&v148.x;
				//                         *(float *)&v148 = v148.z;
				//                         *(_QWORD *)&v183.x = v149;
				//                         LODWORD(v183.z) = (_DWORD)v148;
				//                         v150 = sub_182413270(&v184, &v183);
				//                         static_fields = *(unsigned int *)(v150 + 8);
				//                         *(_QWORD *)&v140.fields.rainDirection.x = *(_QWORD *)v150;
				//                         LODWORD(v140.fields.rainDirection.z) = static_fields;
				//                         v152 = this.fields.rainCommonRenderingParam;
				//                         if ( v152 )
				//                         {
				//                           v153 = v152.fields.middleRainDirection.z;
				//                           *(_QWORD *)&v181.x = *(_QWORD *)&v152.fields.middleRainDirection.x;
				//                           v181.z = v153;
				//                           *(_QWORD *)&v182.x = v127;
				//                           v182.z = v128;
				//                           v154 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v182, 1.0 - v139, v151);
				//                           v155 = *(_QWORD *)&v154.x;
				//                           *(float *)&v154 = v154.z;
				//                           *(_QWORD *)&v182.x = v155;
				//                           LODWORD(v182.z) = (_DWORD)v154;
				//                           v157 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v181, v139, v156);
				//                           v158 = *(_QWORD *)&v157.x;
				//                           *(float *)&v157 = v157.z;
				//                           *(_QWORD *)&v181.x = v158;
				//                           LODWORD(v181.z) = (_DWORD)v157;
				//                           v160 = UnityEngine::Vector3::op_Addition((Vector3 *)&v184, &v181, &v182, v159);
				//                           v161 = *(_QWORD *)&v160.x;
				//                           *(float *)&v160 = v160.z;
				//                           *(_QWORD *)&v183.x = v161;
				//                           LODWORD(v183.z) = (_DWORD)v160;
				//                           v162 = sub_182413270(&v184, &v183);
				//                           static_fields = *(unsigned int *)(v162 + 8);
				//                           *(_QWORD *)&v152.fields.middleRainDirection.x = *(_QWORD *)v162;
				//                           LODWORD(v152.fields.middleRainDirection.z) = static_fields;
				//                           v164 = this.fields.rainCommonRenderingParam;
				//                           if ( v164 )
				//                           {
				//                             v165 = v164.fields.farRainDirection.z;
				//                             *(_QWORD *)&v181.x = *(_QWORD *)&v164.fields.farRainDirection.x;
				//                             v181.z = v165;
				//                             *(_QWORD *)&v182.x = v133;
				//                             v182.z = v134;
				//                             v166 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v182, 1.0 - v139, v163);
				//                             v167 = *(_QWORD *)&v166.x;
				//                             *(float *)&v166 = v166.z;
				//                             *(_QWORD *)&v182.x = v167;
				//                             LODWORD(v182.z) = (_DWORD)v166;
				//                             v169 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v184, &v181, v139, v168);
				//                             v170 = *(_QWORD *)&v169.x;
				//                             *(float *)&v169 = v169.z;
				//                             *(_QWORD *)&v181.x = v170;
				//                             LODWORD(v181.z) = (_DWORD)v169;
				//                             v172 = UnityEngine::Vector3::op_Addition((Vector3 *)&v184, &v181, &v182, v171);
				//                             v173 = *(_QWORD *)&v172.x;
				//                             *(float *)&v172 = v172.z;
				//                             *(_QWORD *)&v183.x = v173;
				//                             LODWORD(v183.z) = (_DWORD)v172;
				//                             v174 = sub_182413270(&v184, &v183);
				//                             static_fields = *(unsigned int *)(v174 + 8);
				//                             *(_QWORD *)&v164.fields.farRainDirection.x = *(_QWORD *)v174;
				//                             LODWORD(v164.fields.farRainDirection.z) = static_fields;
				//                             v176 = this.fields.rainCommonRenderingParam;
				//                             if ( v176 )
				//                             {
				//                               LODWORD(v182.z) = v42.m128_i32[0];
				//                               *(_QWORD *)&v182.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
				//                               v177 = *(_QWORD *)&v176.fields.rainDirection.x;
				//                               v178 = v176.fields.rainDirection.z;
				//                               *(_QWORD *)&v181.x = v177;
				//                               v181.z = v178;
				//                               v179 = 1.0 / fmaxf(fabs(UnityEngine::Vector3::Dot(&v181, &v182, v175)), 0.0099999998);
				//                               if ( v179 < 1.0 )
				//                               {
				//                                 v179 = 1.0;
				//                               }
				//                               else if ( v179 > 2.0 )
				//                               {
				//                                 v179 = 2.0;
				//                               }
				//                               v180 = this.fields.rainCommonRenderingParam;
				//                               if ( v180 )
				//                               {
				//                                 v180.fields.speed = v179 * v180.fields.speed;
				//                                 return;
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
				// LABEL_93:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   }
				// }
				// 
			}

			private void _RequestOcclusionMap()
			{
				// // Void _RequestOcclusionMap()
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_RequestOcclusionMap(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
				//   struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rcx
				//   int *image; // rdx
				//   HGCamera *hgCamera; // rbx
				//   HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rbx
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   bool enableWetness; // al
				//   __int64 v10; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rax
				//   ILFixDynamicMethodWrapper_2 *v13; // rax
				//   ILFixDynamicMethodWrapper_2 *v14; // rax
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
				//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields;
				//   image = (int *)static_fields._0.image;
				//   if ( !static_fields._0.image )
				//     goto LABEL_31;
				//   if ( image[6] > 745 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, image);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     image = (int *)v3.static_fields;
				//     v10 = *(_QWORD *)image;
				//     if ( !*(_QWORD *)image )
				//       goto LABEL_31;
				//     if ( *(_DWORD *)(v10 + 24) <= 0x2E9u )
				//       goto LABEL_55;
				//     if ( *(_QWORD *)(v10 + 5992) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(745, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//         return;
				//       }
				//       goto LABEL_31;
				//     }
				//   }
				//   hgCamera = this.fields.hgCamera;
				//   if ( !hgCamera )
				//     goto LABEL_31;
				//   verticalOcclusionMapManager = hgCamera.fields.verticalOcclusionMapManager;
				//   if ( !byte_18D8EDC94 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     byte_18D8EDC94 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, image);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields;
				//   image = (int *)static_fields._0.image;
				//   if ( !static_fields._0.image )
				//     goto LABEL_31;
				//   if ( image[6] <= 746 )
				//     goto LABEL_16;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, image);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   image = (int *)v3.static_fields;
				//   v12 = *(_QWORD *)image;
				//   if ( !*(_QWORD *)image )
				//     goto LABEL_31;
				//   if ( *(_DWORD *)(v12 + 24) <= 0x2EAu )
				// LABEL_55:
				//     sub_180070270(static_fields, image);
				//   if ( *(_QWORD *)(v12 + 6000) )
				//   {
				//     v13 = IFix::WrappersManagerImpl::GetPatch(746, 0LL);
				//     if ( !v13 )
				//       goto LABEL_31;
				//     enableWetness = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
				//                       (ILFixDynamicMethodWrapper_27 *)v13,
				//                       (Object *)this,
				//                       0LL);
				//     goto LABEL_22;
				//   }
				// LABEL_16:
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, image);
				//   if ( HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL) <= 0 )
				//     goto LABEL_23;
				//   rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//   if ( !rainCommonRenderingParam )
				//     goto LABEL_31;
				//   if ( rainCommonRenderingParam.fields.enable )
				//     goto LABEL_46;
				//   enableWetness = rainCommonRenderingParam.fields.enableWetness;
				// LABEL_22:
				//   if ( enableWetness )
				//   {
				// LABEL_46:
				//     if ( verticalOcclusionMapManager )
				//     {
				//       HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
				//         verticalOcclusionMapManager,
				//         HGVerticalOcclusionMapManager_RequestUsageType__Enum_RainWetnessOcclusion,
				//         0LL);
				//       return;
				//     }
				// LABEL_31:
				//     sub_180B536AC(static_fields, image);
				//   }
				// LABEL_23:
				//   if ( !verticalOcclusionMapManager )
				//     goto LABEL_31;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, image);
				//     static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   image = (int *)static_fields.static_fields.wrapperArray;
				//   if ( !image )
				//     goto LABEL_31;
				//   if ( image[6] <= 749 )
				//   {
				// LABEL_30:
				//     verticalOcclusionMapManager.fields.m_requestType &= ~1u;
				//     return;
				//   }
				//   if ( !static_fields._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(static_fields, image);
				//     static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields.static_fields.wrapperArray;
				//   if ( !static_fields )
				//     goto LABEL_31;
				//   if ( LODWORD(static_fields._0.namespaze) <= 0x2ED )
				//     goto LABEL_55;
				//   if ( !static_fields[16]._0.gc_desc )
				//     goto LABEL_30;
				//   v14 = IFix::WrappersManagerImpl::GetPatch(749, 0LL);
				//   if ( !v14 )
				//     goto LABEL_31;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
				//     (ILFixDynamicMethodWrapper_28 *)v14,
				//     (Object *)verticalOcclusionMapManager,
				//     1,
				//     0LL);
				// }
				// 
			}

			public void UpdateShaderVariables(ref ScriptableRenderContext context, HGRainRenderer.RainWetnessQualityParams qualityParams)
			{
				// // Void UpdateShaderVariables(ScriptableRenderContext ByRef, HGRainRenderer+RainWetnessQualityParams)
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateShaderVariables(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         ScriptableRenderContext *context,
				//         HGRainRenderer_RainWetnessQualityParams *qualityParams,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rax
				//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2__Array *v10; // rax
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
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v7.static_fields;
				//   wrapperArray = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( wrapperArray.max_length.size <= 862 )
				//   {
				// LABEL_7:
				//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessShaderVariables(
				//       this,
				//       this.fields.rainWetnessGlobalProps,
				//       0LL);
				//     HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainOcclusionMapShaderVariables(
				//       this,
				//       qualityParams,
				//       this.fields.rainWetnessGlobalProps,
				//       0LL);
				//     return;
				//   }
				//   if ( !v7._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v7, wrapperArray);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v7.static_fields;
				//   v10 = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( v10.max_length.size <= 0x35Eu )
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !v10[24].bounds )
				//     goto LABEL_7;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(862, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_337(Patch, (Object *)this, context, (Object *)qualityParams, 0LL);
				// }
				// 
			}

			private void _UpdateWetnessShaderVariables(RainWetnessGlobalProps globalProps)
			{
				// // Void _UpdateWetnessShaderVariables(RainWetnessGlobalProps)
				// // Hidden C++ exception states: #wind=2
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessShaderVariables(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         RainWetnessGlobalProps *globalProps,
				//         MethodInfo *method)
				// {
				//   RainWetnessGlobalProps *v3; // rbx
				//   Object *v4; // rdi
				//   _QWORD **list; // rcx
				//   __int64 v6; // rsi
				//   __int64 v7; // rsi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   Object__Class *klass; // rsi
				//   char v12; // si
				//   Object__Class *v13; // rsi
				//   Object__Class *v14; // rsi
				//   struct HGRainRenderer__Class *v15; // rax
				//   int32_t HIGH_QUALITY_WETNESS_MASK; // esi
				//   List_1_System_Object_ *monitor; // rdi
				//   __int64 v18; // rcx
				//   List_1_System_Object_ *v19; // r9
				//   __int64 *v20; // rdx
				//   __int64 v21; // rtt
				//   __int64 v22; // rcx
				//   __int64 v23; // [rsp+0h] [rbp-78h] BYREF
				//   Il2CppExceptionWrapper *v24; // [rsp+20h] [rbp-58h] BYREF
				//   Il2CppExceptionWrapper *v25; // [rsp+28h] [rbp-50h] BYREF
				//   List_1_T_Enumerator_System_Object_ v26; // [rsp+30h] [rbp-48h] BYREF
				//   List_1_T_Enumerator_System_Object_ v27; // [rsp+48h] [rbp-30h] BYREF
				//   RainWetnessGlobalProps *v29; // [rsp+88h] [rbp+10h]
				// 
				//   v29 = globalProps;
				//   v3 = globalProps;
				//   v4 = (Object *)this;
				//   if ( !byte_18D8EDC92 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::get_Current);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
				//     byte_18D8EDC92 = 1;
				//   }
				//   memset(&v27, 0, sizeof(v27));
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   list = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, globalProps);
				//     list = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v6 = *list[23];
				//   if ( !v6 )
				//     sub_180B536AC(list, globalProps);
				//   if ( *(int *)(v6 + 24) > 863 )
				//   {
				//     if ( !*((_DWORD *)list + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(list, globalProps);
				//       list = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v7 = *list[23];
				//     if ( !v7 )
				//       sub_180B536AC(list, globalProps);
				//     if ( *(_DWORD *)(v7 + 24) <= 0x35Fu )
				//       sub_180070270(list, globalProps);
				//     if ( *(_QWORD *)(v7 + 6936) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(863, 0LL);
				//       if ( !Patch )
				//         sub_180B536AC(v10, v9);
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, v4, (Object *)v3, 0LL);
				//       return;
				//     }
				//   }
				//   klass = v4[3].klass;
				//   if ( !klass )
				//     sub_180B536AC(list, globalProps);
				//   v12 = BYTE1(klass._1.actualSize);
				//   if ( !v3 )
				//     sub_180B536AC(list, globalProps);
				//   v3.fields.enableWetness = v12;
				//   v13 = v4[3].klass;
				//   if ( !v13 )
				//     sub_180B536AC(list, globalProps);
				//   v3.fields.enableWetnessHighQuality = BYTE4(v13.vtable.Equals.method);
				//   v14 = v4[3].klass;
				//   if ( !v14 )
				//     sub_180B536AC(list, globalProps);
				//   if ( !BYTE1(v14._1.actualSize) )
				//     goto LABEL_37;
				//   v15 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//   if ( BYTE4(v14.vtable.Equals.method) )
				//   {
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, globalProps);
				//       v15 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//     }
				//     HIGH_QUALITY_WETNESS_MASK = v15.static_fields.HIGH_QUALITY_WETNESS_MASK;
				//   }
				//   else
				//   {
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, globalProps);
				//       v15 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
				//     }
				//     HIGH_QUALITY_WETNESS_MASK = v15.static_fields.LOW_QUALITY_WETNESS_MASK;
				//   }
				//   monitor = (List_1_System_Object_ *)v4[2].monitor;
				//   if ( !monitor )
				//     sub_180B536AC(list, globalProps);
				//   System::Collections::Generic::List<System::Object>::GetEnumerator(
				//     &v26,
				//     monitor,
				//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
				//   v27 = v26;
				//   v26._list = 0LL;
				//   *(_QWORD *)&v26._index = &v27;
				//   try
				//   {
				//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//               &v27,
				//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
				//     {
				//       if ( !v27._current )
				//         sub_1802DC2C8(v18, 0LL);
				//       if ( (HIGH_QUALITY_WETNESS_MASK & (__int64)v27._current[1].klass) > 0 )
				//         sub_18004E2C0(6LL, v27._current, v3);
				//       else
				//         sub_18004E2C0(7LL, v27._current, v3);
				//     }
				//   }
				//   catch ( Il2CppExceptionWrapper *v24 )
				//   {
				//     globalProps = (RainWetnessGlobalProps *)&v23;
				//     v26._list = (List_1_System_Object_ *)v24.ex;
				//     list = (_QWORD **)v26._list;
				//     if ( v26._list )
				//       sub_18000F780(v26._list);
				//     v3 = v29;
				//     v4 = (Object *)this;
				// LABEL_37:
				//     v19 = (List_1_System_Object_ *)v4[2].monitor;
				//     if ( !v19 )
				//       sub_1802DC2C8(list, globalProps);
				//     *(_OWORD *)&v26._index = 0LL;
				//     v26._list = v19;
				//     if ( dword_18D8E43F8 )
				//     {
				//       v20 = &qword_18D6870D0[(((unsigned __int64)&v26 >> 12) & 0x1FFFFF) >> 6];
				//       _m_prefetchw(v20);
				//       do
				//         v21 = *v20;
				//       while ( v21 != _InterlockedCompareExchange64(v20, *v20 | (1LL << (((unsigned __int64)&v26 >> 12) & 0x3F)), *v20) );
				//     }
				//     v26._index = 0;
				//     v26._version = v19.fields._version;
				//     v26._current = 0LL;
				//     *(_OWORD *)&v27._list = *(_OWORD *)&v26._list;
				//     v27._current = 0LL;
				//     v26._list = 0LL;
				//     *(_QWORD *)&v26._index = &v27;
				//     try
				//     {
				//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v27,
				//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
				//       {
				//         if ( !v27._current )
				//           sub_1802DC2C8(v22, 0LL);
				//         sub_18004E2C0(7LL, v27._current, v3);
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v25 )
				//     {
				//       v26._list = (List_1_System_Object_ *)v25.ex;
				//       if ( v26._list )
				//         sub_18000F780(v26._list);
				//     }
				//   }
				// }
				// 
			}

			private void _UpdateRainOcclusionMapShaderVariables(HGRainRenderer.RainWetnessQualityParams qualityParams, RainWetnessGlobalProps globalProps)
			{
				// // Void _UpdateRainOcclusionMapShaderVariables(HGRainRenderer+RainWetnessQualityParams, RainWetnessGlobalProps)
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainOcclusionMapShaderVariables(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         HGRainRenderer_RainWetnessQualityParams *qualityParams,
				//         RainWetnessGlobalProps *globalProps,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *commonPresettingParam; // rdx
				//   void *wrapperArray; // rcx
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   Vector4__Array *rainWetnessGlobalParams; // rbx
				//   float v11; // xmm7_4
				//   float v12; // xmm8_4
				//   float acneFixNormalBiasScale; // xmm6_4
				//   float v14; // xmm6_4
				//   __m128 v15; // xmm0
				//   __m128 v16; // xmm0
				//   Vector4 v17; // xmm0
				//   Vector4__Array *v18; // rbx
				//   int32_t RainOcclusionMaskSamplePosJitterMode; // ebp
				//   int32_t RainOcclusionMaskSampleMode; // eax
				//   float v21; // xmm6_4
				//   float v22; // xmm7_4
				//   float v23; // xmm8_4
				//   __m128 v24; // xmm0
				//   __m128 v25; // xmm0
				//   __m128 v26; // xmm0
				//   Vector4 v27; // xmm0
				//   RainCommonRenderingParam *v28; // rax
				//   Vector4__Array *v29; // rbx
				//   __m128 methodPtr_low; // xmm6
				//   float v31; // xmm7_4
				//   float v32; // xmm8_4
				//   float cameraMask; // xmm9_4
				//   __m128 v34; // xmm6
				//   __m128 v35; // xmm6
				//   __m128 v36; // xmm6
				//   Vector4 v37; // xmm6
				//   ILFixDynamicMethodWrapper_2__Array *v38; // r8
				//   ILFixDynamicMethodWrapper_2 *v39; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   ILFixDynamicMethodWrapper_2 *v41; // rax
				//   ILFixDynamicMethodWrapper_2 *v42; // rax
				//   Vector4 v43; // [rsp+40h] [rbp-58h] BYREF
				// 
				//   if ( !byte_18D8EDC93 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D8EDC93 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = commonPresettingParam.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_48;
				//   if ( *((int *)wrapperArray + 6) <= 866 )
				//     goto LABEL_80;
				//   if ( !commonPresettingParam._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(commonPresettingParam, commonPresettingParam);
				//     commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v38 = commonPresettingParam.static_fields.wrapperArray;
				//   if ( !v38 )
				//     goto LABEL_48;
				//   if ( v38.max_length.size <= 0x362u )
				//     goto LABEL_49;
				//   if ( !v38[24].vector[2] )
				//   {
				// LABEL_80:
				//     if ( globalProps )
				//     {
				//       rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//       rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
				//       if ( rainCommonRenderingParam )
				//       {
				//         wrapperArray = rainCommonRenderingParam.fields.commonPresettingParam;
				//         if ( wrapperArray )
				//         {
				//           v11 = *((float *)wrapperArray + 73);
				//           if ( qualityParams )
				//           {
				//             v12 = *((float *)wrapperArray + 74);
				//             acneFixNormalBiasScale = qualityParams.fields.acneFixNormalBiasScale;
				//             if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
				//             {
				//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, commonPresettingParam);
				//               commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//             }
				//             v14 = acneFixNormalBiasScale * v11;
				//             if ( !byte_18D8EDC37 )
				//             {
				//               sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//               commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               byte_18D8EDC37 = 1;
				//             }
				//             if ( !commonPresettingParam._1.cctor_finished_or_no_cctor )
				//             {
				//               il2cpp_runtime_class_init_0(commonPresettingParam, commonPresettingParam);
				//               commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//             }
				//             wrapperArray = commonPresettingParam.static_fields.wrapperArray;
				//             if ( wrapperArray )
				//             {
				//               if ( *((int *)wrapperArray + 6) <= 867 )
				//                 goto LABEL_21;
				//               if ( !commonPresettingParam._1.cctor_finished_or_no_cctor )
				//               {
				//                 il2cpp_runtime_class_init_0(commonPresettingParam, commonPresettingParam);
				//                 commonPresettingParam = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//               }
				//               commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)commonPresettingParam.static_fields.wrapperArray;
				//               if ( !commonPresettingParam )
				//                 goto LABEL_48;
				//               if ( LODWORD(commonPresettingParam._0.namespaze) <= 0x363 )
				//                 goto LABEL_49;
				//               if ( commonPresettingParam[18]._1.typeHierarchy )
				//               {
				//                 Patch = IFix::WrappersManagerImpl::GetPatch(867, 0LL);
				//                 if ( !Patch )
				//                   goto LABEL_48;
				//                 v17 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_335(&v43, Patch, v14, v12, 0LL);
				//               }
				//               else
				//               {
				// LABEL_21:
				//                 v15 = (__m128)*(unsigned __int64 *)&v43.x;
				//                 v15.m128_f32[0] = v14;
				//                 v16 = _mm_shuffle_ps(v15, v15, 225);
				//                 v16.m128_f32[0] = v12;
				//                 v17 = (Vector4)_mm_shuffle_ps(v16, v16, 225);
				//                 v43 = v17;
				//               }
				//               if ( rainWetnessGlobalParams )
				//               {
				//                 if ( rainWetnessGlobalParams.max_length.size <= 3u )
				//                   goto LABEL_49;
				//                 rainWetnessGlobalParams.vector[3] = v17;
				//                 v18 = globalProps.fields.rainWetnessGlobalParams;
				//                 if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//                   il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, commonPresettingParam);
				//                 RainOcclusionMaskSamplePosJitterMode = HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSamplePosJitterMode(0LL);
				//                 RainOcclusionMaskSampleMode = HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL);
				//                 wrapperArray = this.fields.rainCommonRenderingParam;
				//                 if ( wrapperArray )
				//                 {
				//                   v21 = *((float *)wrapperArray + 13);
				//                   v22 = (float)RainOcclusionMaskSampleMode;
				//                   v23 = (float)RainOcclusionMaskSamplePosJitterMode;
				//                   if ( !byte_18D8EDC37 )
				//                   {
				//                     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//                     byte_18D8EDC37 = 1;
				//                   }
				//                   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//                   {
				//                     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, commonPresettingParam);
				//                     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                   }
				//                   commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)**((_QWORD **)wrapperArray + 23);
				//                   if ( commonPresettingParam )
				//                   {
				//                     if ( SLODWORD(commonPresettingParam._0.namespaze) <= 869 )
				//                       goto LABEL_33;
				//                     if ( !*((_DWORD *)wrapperArray + 56) )
				//                     {
				//                       il2cpp_runtime_class_init_0(wrapperArray, commonPresettingParam);
				//                       wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                     }
				//                     commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)**((_QWORD **)wrapperArray + 23);
				//                     if ( !commonPresettingParam )
				//                       goto LABEL_48;
				//                     if ( LODWORD(commonPresettingParam._0.namespaze) <= 0x365 )
				//                       goto LABEL_49;
				//                     if ( *(_QWORD *)&commonPresettingParam[18]._1.initializationExceptionGCHandle )
				//                     {
				//                       v41 = IFix::WrappersManagerImpl::GetPatch(869, 0LL);
				//                       if ( !v41 )
				//                         goto LABEL_48;
				//                       v27 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_336(&v43, v41, v23, v22, v21, 0LL);
				//                     }
				//                     else
				//                     {
				// LABEL_33:
				//                       v43.w = 0.0;
				//                       v24 = (__m128)v43;
				//                       v24.m128_f32[0] = v23;
				//                       v25 = _mm_shuffle_ps(v24, v24, 225);
				//                       v25.m128_f32[0] = v22;
				//                       v26 = _mm_shuffle_ps(v25, v25, 198);
				//                       v26.m128_f32[0] = v21;
				//                       v27 = (Vector4)_mm_shuffle_ps(v26, v26, 201);
				//                       v43 = v27;
				//                     }
				//                     if ( v18 )
				//                     {
				//                       if ( v18.max_length.size <= 4u )
				//                         goto LABEL_49;
				//                       v18.vector[4] = v27;
				//                       v28 = this.fields.rainCommonRenderingParam;
				//                       v29 = globalProps.fields.rainWetnessGlobalParams;
				//                       if ( v28 )
				//                       {
				//                         commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)v28.fields.commonPresettingParam;
				//                         if ( commonPresettingParam )
				//                         {
				//                           methodPtr_low = (__m128)LODWORD(commonPresettingParam.vtable.Equals.methodPtr);
				//                           v31 = *((float *)&commonPresettingParam.vtable.Equals.methodPtr + 1);
				//                           v32 = *(float *)&commonPresettingParam.vtable.Equals.method;
				//                           cameraMask = (float)this.fields.cameraMask;
				//                           if ( !byte_18D8EDC37 )
				//                           {
				//                             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//                             byte_18D8EDC37 = 1;
				//                           }
				//                           wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//                           {
				//                             il2cpp_runtime_class_init_0(
				//                               TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//                               commonPresettingParam);
				//                             wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                           }
				//                           commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)**((_QWORD **)wrapperArray
				//                                                                                                 + 23);
				//                           if ( commonPresettingParam )
				//                           {
				//                             if ( SLODWORD(commonPresettingParam._0.namespaze) <= 826 )
				//                               goto LABEL_44;
				//                             if ( !*((_DWORD *)wrapperArray + 56) )
				//                             {
				//                               il2cpp_runtime_class_init_0(wrapperArray, commonPresettingParam);
				//                               wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//                             }
				//                             commonPresettingParam = (struct ILFixDynamicMethodWrapper_2__Class *)**((_QWORD **)wrapperArray
				//                                                                                                   + 23);
				//                             if ( !commonPresettingParam )
				//                               goto LABEL_48;
				//                             if ( LODWORD(commonPresettingParam._0.namespaze) <= 0x33A )
				//                               goto LABEL_49;
				//                             if ( *(_QWORD *)&commonPresettingParam[17]._1.instance_size )
				//                             {
				//                               v42 = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
				//                               if ( !v42 )
				//                                 goto LABEL_48;
				//                               v37 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_318(
				//                                        &v43,
				//                                        v42,
				//                                        methodPtr_low.m128_f32[0],
				//                                        v31,
				//                                        v32,
				//                                        cameraMask,
				//                                        0LL);
				//                             }
				//                             else
				//                             {
				// LABEL_44:
				//                               v34 = _mm_shuffle_ps(methodPtr_low, methodPtr_low, 225);
				//                               v34.m128_f32[0] = v31;
				//                               v35 = _mm_shuffle_ps(v34, v34, 198);
				//                               v35.m128_f32[0] = v32;
				//                               v36 = _mm_shuffle_ps(v35, v35, 39);
				//                               v36.m128_f32[0] = cameraMask;
				//                               v37 = (Vector4)_mm_shuffle_ps(v36, v36, 57);
				//                             }
				//                             if ( v29 )
				//                             {
				//                               if ( v29.max_length.size > 7u )
				//                               {
				//                                 v29.vector[7] = v37;
				//                                 return;
				//                               }
				// LABEL_49:
				//                               sub_180070270(wrapperArray, commonPresettingParam);
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
				// LABEL_48:
				//     sub_180B536AC(wrapperArray, commonPresettingParam);
				//   }
				//   v39 = IFix::WrappersManagerImpl::GetPatch(866, 0LL);
				//   if ( !v39 )
				//     goto LABEL_48;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
				//     (ILFixDynamicMethodWrapper_28 *)v39,
				//     (Object *)this,
				//     (Object *)qualityParams,
				//     (Object *)globalProps,
				//     0LL);
				// }
				// 
			}

			public bool ShouldRequestRainOcclusionMap()
			{
				// // Boolean ShouldRequestRainOcclusionMap()
				// bool HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::ShouldRequestRainOcclusionMap(
				//         HGRainRenderer_RainWetnessRenderSeq *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   RainCommonRenderingParam *rainCommonRenderingParam; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC94 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
				//     byte_18D8EDC94 = 1;
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
				//     goto LABEL_15;
				//   if ( wrapperArray.max_length.size > 746 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( !v3 )
				//       goto LABEL_15;
				//     if ( LODWORD(v3._0.namespaze) <= 0x2EA )
				//       sub_180070270(v3, wrapperArray);
				//     if ( v3[15].vtable.ToString.methodPtr )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(746, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// LABEL_15:
				//       sub_180B536AC(v3, wrapperArray);
				//     }
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer, wrapperArray);
				//   if ( HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL) <= 0 )
				//     return 0;
				//   rainCommonRenderingParam = this.fields.rainCommonRenderingParam;
				//   if ( !rainCommonRenderingParam )
				//     goto LABEL_15;
				//   return rainCommonRenderingParam.fields.enable || rainCommonRenderingParam.fields.enableWetness;
				// }
				// 
				return default(bool);
			}

			public HGCamera hgCamera;

			public int cameraMask;

			public List<HGBaseSubRainRenderer> subRainRenderers;

			public List<HGBaseWetnessFeature> wetnessFeatures;

			public RainCommonRenderingParam rainCommonRenderingParam;

			public RainWetnessGlobalProps rainWetnessGlobalProps;

			private float m_deltaTime;

			private float m_lastTime;
		}

		private class RainWetnessQualityParams
		{
			public RainWetnessQualityParams()
			{
				// // HGRainRenderer+RainWetnessQualityParams()
				// void HG::Rendering::Runtime::HGRainRenderer::RainWetnessQualityParams::RainWetnessQualityParams(
				//         HGRainRenderer_RainWetnessQualityParams *this,
				//         MethodInfo *method)
				// {
				//   this.fields.screenRainDropPercent = 1.0;
				//   this.fields.rainSplashMaxCount = 1000;
				//   this.fields.acneFixNormalBiasScale = 1.0;
				//   this.fields.sceneEffectRainLayerCount = 1;
				// }
				// 
			}

			public bool enableRainWetnessHighQuality;

			public bool enableMiddleRain;

			public bool enableRainWave;

			public bool enableRainLighting;

			public float screenRainDropPercent;

			public int rainSplashMaxCount;

			public float acneFixNormalBiasScale;

			public int sceneEffectRainLayerCount;
		}
	}
}
