using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 104)]
	internal struct FrameSettingsHistory
	{
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool enabled
		{
			get
			{
				return default(bool);
			}
		}

		[IDTag(1)]
		public static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, HGRenderPipelineAsset hgrpAsset, HGRenderPipelineAsset defaultHgrpAsset)
		{
			// // Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, HGRenderPipelineAsset, HGRenderPipelineAsset)
			// void HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
			//         FrameSettings *aggregatedFrameSettings,
			//         Camera *camera,
			//         HGAdditionalCameraData *additionalData,
			//         HGRenderPipelineAsset *hgrpAsset,
			//         HGRenderPipelineAsset *defaultHgrpAsset,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineGlobalSettings *instance; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 defaultFrameSettings; // rdx
			//   FrameSettings *v13; // r14
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   RenderPipelineSettings supportedFeatures; // [rsp+40h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D919679 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
			//     byte_18D919679 = 1;
			//   }
			//   sub_1802F01E0(&supportedFeatures, 0LL, 112LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(643, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
			//     instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
			//     if ( additionalData )
			//       defaultFrameSettings = (unsigned int)additionalData.fields.defaultFrameSettings;
			//     else
			//       defaultFrameSettings = 0LL;
			//     if ( instance )
			//     {
			//       v13 = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings(
			//               instance,
			//               (FrameSettingsRenderType__Enum)defaultFrameSettings,
			//               0LL);
			//       if ( hgrpAsset )
			//       {
			//         v14 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
			//         *(_OWORD *)&supportedFeatures.colorBufferFormat = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.colorBufferFormat;
			//         v15 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
			//         *(_OWORD *)&supportedFeatures.dynamicResolutionSettings.DLSSSharpness = v14;
			//         v16 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
			//         *(_OWORD *)&supportedFeatures.dynamicResolutionSettings.forcedPercentage = v15;
			//         v17 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
			//         *(_OWORD *)&supportedFeatures.m_ObsoleteLightLayerName0 = v16;
			//         v18 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
			//         *(_OWORD *)&supportedFeatures.m_ObsoleteLightLayerName2 = v17;
			//         v19 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
			//         *(_OWORD *)&supportedFeatures.m_ObsoleteLightLayerName4 = v18;
			//         *(_OWORD *)&supportedFeatures.m_ObsoleteLightLayerName6 = v19;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//         HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
			//           aggregatedFrameSettings,
			//           camera,
			//           (IFrameSettingsHistoryContainer *)additionalData,
			//           v13,
			//           &supportedFeatures,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(Patch, defaultFrameSettings);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(643, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_245(
			//     Patch,
			//     aggregatedFrameSettings,
			//     (Object *)camera,
			//     (Object *)additionalData,
			//     (Object *)hgrpAsset,
			//     (Object *)defaultHgrpAsset,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		public static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, IFrameSettingsHistoryContainer historyContainer, ref FrameSettings defaultFrameSettings, in RenderPipelineSettings supportedFeatures)
		{
			// // Void AggregateFrameSettings(FrameSettings ByRef, Camera, IFrameSettingsHistoryContainer, FrameSettings ByRef, RenderPipelineSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
			//         FrameSettings *aggregatedFrameSettings,
			//         Camera *camera,
			//         IFrameSettingsHistoryContainer *historyContainer,
			//         FrameSettings *defaultFrameSettings,
			//         RenderPipelineSettings *supportedFeatures,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int v12; // edi
			//   __int64 v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // r8
			//   bool v16; // zf
			//   BitArray128 bitDatas; // xmm1
			//   __int64 v18; // xmm0_8
			//   bool v19; // r14
			//   char v20; // al
			//   IFrameSettingsHistoryContainer__Class *klass; // xmm6_8
			//   IFrameSettingsHistoryContainer v22; // xmm7
			//   BitArray128 v23; // xmm0
			//   BitArray128 v24; // xmm6
			//   BitArray128 v25; // xmm0
			//   BitArray128 v26; // xmm0
			//   __int64 v27; // xmm1_8
			//   bool v28; // al
			//   __int64 v29; // xmm1_8
			//   bool v30; // al
			//   __int64 v31; // xmm6_8
			//   BitArray128 v32; // xmm7
			//   __int128 v33; // xmm3
			//   __int128 v34; // xmm4
			//   BitArray128 v35; // xmm5
			//   __int128 v36; // xmm1
			//   __int64 v37; // xmm0_8
			//   BitArray128 v38; // xmm2
			//   __int128 v39; // xmm1
			//   FrameSettings v40; // [rsp+40h] [rbp-C0h] BYREF
			//   FrameSettings v41; // [rsp+60h] [rbp-A0h] BYREF
			//   __m256i v42; // [rsp+80h] [rbp-80h] BYREF
			//   BitArray128 v43; // [rsp+A0h] [rbp-60h]
			//   BitArray128 v44; // [rsp+B0h] [rbp-50h]
			//   _OWORD sanitizedFrameSettings[2]; // [rsp+C0h] [rbp-40h] BYREF
			//   __int64 v46; // [rsp+E0h] [rbp-20h]
			//   __m256i v47; // [rsp+F0h] [rbp-10h] BYREF
			//   BitArray128 v48; // [rsp+110h] [rbp+10h]
			//   BitArray128 v49; // [rsp+120h] [rbp+20h]
			//   __int128 v50; // [rsp+130h] [rbp+30h]
			//   __int128 v51; // [rsp+140h] [rbp+40h]
			//   __int64 v52; // [rsp+150h] [rbp+50h]
			// 
			//   sub_1802F01E0(&v42, 0LL, 104LL);
			//   v12 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(645, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(645, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_244(
			//         Patch,
			//         aggregatedFrameSettings,
			//         (Object *)camera,
			//         (Object *)historyContainer,
			//         defaultFrameSettings,
			//         supportedFeatures,
			//         0LL);
			//       return;
			//     }
			// LABEL_20:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   if ( !historyContainer )
			//     goto LABEL_20;
			//   v13 = sub_18865FF90(&v47, historyContainer);
			//   v16 = byte_18D919683 == 0;
			//   v42 = *(__m256i *)v13;
			//   v43 = *(BitArray128 *)(v13 + 32);
			//   v44 = *(BitArray128 *)(v13 + 48);
			//   sanitizedFrameSettings[0] = *(_OWORD *)(v13 + 64);
			//   sanitizedFrameSettings[1] = *(_OWORD *)(v13 + 80);
			//   bitDatas = defaultFrameSettings.bitDatas;
			//   v46 = *(_QWORD *)(v13 + 96);
			//   v18 = *(_QWORD *)&defaultFrameSettings.materialQuality;
			//   v19 = 0;
			//   aggregatedFrameSettings.bitDatas = bitDatas;
			//   *(_QWORD *)&aggregatedFrameSettings.materialQuality = v18;
			//   if ( v16 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IFrameSettingsHistoryContainer);
			//     byte_18D919683 = 1;
			//   }
			//   if ( *(_DWORD *)&historyContainer.klass._1.method_count == 3215 )
			//     v20 = BYTE2(historyContainer[8].klass);
			//   else
			//     v20 = sub_1800518F0(4LL, TypeInfo::HG::Rendering::Runtime::IFrameSettingsHistoryContainer);
			//   if ( v20 )
			//   {
			//     if ( !byte_18D919684 )
			//     {
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IFrameSettingsHistoryContainer);
			//       byte_18D919684 = 1;
			//     }
			//     if ( *(_DWORD *)&historyContainer.klass._1.method_count == 3215 )
			//     {
			//       v22 = historyContainer[11];
			//       klass = historyContainer[12].klass;
			//     }
			//     else
			//     {
			//       sub_180831748(&v40, v14, v15, historyContainer);
			//       klass = *(IFrameSettingsHistoryContainer__Class **)&v40.materialQuality;
			//       v22 = (IFrameSettingsHistoryContainer)v40.bitDatas;
			//     }
			//     v23 = *(BitArray128 *)sub_188660034(&v40, historyContainer);
			//     v40.bitDatas = (BitArray128)v22;
			//     v41.bitDatas = v23;
			//     *(_QWORD *)&v40.materialQuality = klass;
			//     HG::Rendering::Runtime::FrameSettings::Override(
			//       aggregatedFrameSettings,
			//       &v40,
			//       (FrameSettingsOverrideMask *)&v41,
			//       0LL);
			//     v24 = v43;
			//     v25 = *(BitArray128 *)sub_188660034(&v40, historyContainer);
			//     v40.bitDatas = v24;
			//     v41.bitDatas = v25;
			//     v19 = ClipperLib::IntPoint::op_Inequality((IntPoint *)&v40, (IntPoint *)&v41, 0LL);
			//     v43 = *(BitArray128 *)sub_188660034(&v40, historyContainer);
			//   }
			//   v26 = aggregatedFrameSettings.bitDatas;
			//   v42.m256i_i64[3] = *(_QWORD *)&aggregatedFrameSettings.materialQuality;
			//   *(BitArray128 *)&v42.m256i_u64[1] = v26;
			//   HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, supportedFeatures, 0LL);
			//   v27 = *(_QWORD *)&aggregatedFrameSettings.materialQuality;
			//   v40.bitDatas = aggregatedFrameSettings.bitDatas;
			//   *(_QWORD *)&v40.materialQuality = v27;
			//   v41 = *(FrameSettings *)((char *)sanitizedFrameSettings + 8);
			//   v28 = HG::Rendering::Runtime::FrameSettings::op_Inequality(&v41, &v40, 0LL);
			//   v29 = *(_QWORD *)&aggregatedFrameSettings.materialQuality;
			//   v40.bitDatas = aggregatedFrameSettings.bitDatas;
			//   *(_QWORD *)&v40.materialQuality = v29;
			//   v41.bitDatas = v44;
			//   LOBYTE(v46) = v28;
			//   *(_QWORD *)&v41.materialQuality = *(_QWORD *)&sanitizedFrameSettings[0];
			//   v30 = HG::Rendering::Runtime::FrameSettings::op_Inequality(&v41, &v40, 0LL);
			//   v31 = v46;
			//   v32 = aggregatedFrameSettings.bitDatas;
			//   v33 = *(_OWORD *)v42.m256i_i8;
			//   v34 = *(_OWORD *)&v42.m256i_u64[2];
			//   v35 = v43;
			//   v52 = v46;
			//   v49 = v44;
			//   v26.data1 = *(_QWORD *)&aggregatedFrameSettings.materialQuality;
			//   LOBYTE(v12) = (_BYTE)v46 == 0;
			//   v50 = sanitizedFrameSettings[0];
			//   v36 = sanitizedFrameSettings[1];
			//   v47 = v42;
			//   v48 = v43;
			//   v51 = sanitizedFrameSettings[1];
			//   v44 = v32;
			//   *(_QWORD *)&sanitizedFrameSettings[0] = v26.data1;
			//   if ( v12 | (v19 || v30) )
			//   {
			//     v37 = *(_QWORD *)&sanitizedFrameSettings[0];
			//     v38 = v32;
			//     *((_QWORD *)&sanitizedFrameSettings[1] + 1) = *(_QWORD *)&sanitizedFrameSettings[0];
			//     v47 = v42;
			//     v48 = v43;
			//     v51 = v36;
			//     v52 = v46;
			//     *(BitArray128 *)((char *)sanitizedFrameSettings + 8) = v32;
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::FrameSettings::Sanitize(
			//       (FrameSettings *)((char *)sanitizedFrameSettings + 8),
			//       camera,
			//       supportedFeatures,
			//       0LL);
			//     v37 = *((_QWORD *)&sanitizedFrameSettings[1] + 1);
			//     v38 = *(BitArray128 *)((char *)sanitizedFrameSettings + 8);
			//     v35 = v43;
			//     v34 = *(_OWORD *)&v42.m256i_u64[2];
			//     v33 = *(_OWORD *)v42.m256i_i8;
			//     v31 = v46;
			//     v32 = v44;
			//   }
			//   v39 = sanitizedFrameSettings[1];
			//   aggregatedFrameSettings.bitDatas = v38;
			//   *(_QWORD *)&aggregatedFrameSettings.materialQuality = v37;
			//   v50 = sanitizedFrameSettings[0];
			//   *(_OWORD *)v47.m256i_i8 = v33;
			//   *(_OWORD *)&v47.m256i_u64[2] = v34;
			//   v48 = v35;
			//   v49 = v32;
			//   v51 = v39;
			//   v52 = v31;
			//   sub_1886600F4(historyContainer, &v47);
			// }
			// 
		}

		private static DebugUI.HistoryBoolField GenerateHistoryBoolField(IFrameSettingsHistoryContainer frameSettingsContainer, FrameSettingsField field, FrameSettingsFieldAttribute attribute)
		{
			// // DebugUI+HistoryBoolField GenerateHistoryBoolField(IFrameSettingsHistoryContainer, FrameSettingsField, FrameSettingsFieldAttribute)
			// DebugUI_HistoryBoolField *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryBoolField(
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         FrameSettingsField__Enum field,
			//         FrameSettingsFieldAttribute *attribute,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   OneofDescriptorProto *v8; // rdx
			//   __int64 v9; // rcx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   __int64 v12; // rbx
			//   String *v13; // rbp
			//   int32_t v14; // edi
			//   DebugUI_BoolField *v15; // rax
			//   DebugUI_BoolField *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   String *tooltip; // r9
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   Func_1_Boolean_ *v23; // rax
			//   Func_1_Boolean_ *v24; // rsi
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   Action_1_Boolean_ *v28; // rax
			//   Action_1_Boolean_ *v29; // rsi
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   __int64 v33; // r8
			//   __int64 v34; // r9
			//   __int64 v35; // rsi
			//   Func_1_Boolean_ *v36; // rax
			//   Func_1_Boolean_ *v37; // rbp
			//   Func_1_Boolean_ *v38; // rax
			//   Func_1_Boolean_ *v39; // rbp
			//   Func_1_Boolean_ *v40; // rax
			//   Func_1_Boolean_ *v41; // rbp
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   MessageDescriptor *v44; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v47; // [rsp+20h] [rbp-18h]
			//   String__Array *v48; // [rsp+20h] [rbp-18h]
			//   String__Array *v49; // [rsp+20h] [rbp-18h]
			//   String__Array *v50; // [rsp+20h] [rbp-18h]
			//   String__Array *v51; // [rsp+20h] [rbp-18h]
			//   String__Array *v52; // [rsp+20h] [rbp-18h]
			//   String *v53; // [rsp+28h] [rbp-10h]
			//   String *v54; // [rsp+28h] [rbp-10h]
			//   String *v55; // [rsp+28h] [rbp-10h]
			//   String *v56; // [rsp+28h] [rbp-10h]
			//   String *v57; // [rsp+28h] [rbp-10h]
			//   String *v58; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v59; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v60; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v61; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v62; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v63; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v64; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D91967A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<bool>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<bool>::set_getter);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<bool>::set_setter);
			//     sub_18003C530(&TypeInfo::System::Func<bool>);
			//     sub_18003C530(&TypeInfo::System::Func<bool>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::HistoryBoolField);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__3);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__4);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0);
			//     sub_18003C530(&off_18CDBE620);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D91967A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3100, 0LL) )
			//   {
			//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0);
			//     v12 = v7;
			//     if ( v7 )
			//     {
			//       *(_QWORD *)(v7 + 16) = frameSettingsContainer;
			//       sub_1800054D0((OneofDescriptor *)(v7 + 16), v8, v10, v11, v47, v53, v59);
			//       *(_DWORD *)(v12 + 24) = field;
			//       v13 = (String *)"";
			//       v14 = 0;
			//       if ( attribute )
			//       {
			//         while ( v14 < attribute.fields.indentLevel )
			//         {
			//           v13 = System::String::Concat(v13, (String *)"  ", 0LL);
			//           ++v14;
			//         }
			//         v15 = (DebugUI_BoolField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::HistoryBoolField);
			//         v16 = v15;
			//         if ( v15 )
			//         {
			//           UnityEngine::Rendering::DebugUI::BoolField::BoolField(v15, 0LL);
			//           v16.fields._._._displayName_k__BackingField = System::String::Concat(
			//                                                            v13,
			//                                                            attribute.fields.displayedName,
			//                                                            0LL);
			//           sub_1800054D0((OneofDescriptor *)&v16.fields._._._displayName_k__BackingField, v17, v18, v19, v48, v54, v60);
			//           tooltip = attribute.fields.tooltip;
			//           v16.fields._._._tooltip_k__BackingField = tooltip;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v16.fields._._._tooltip_k__BackingField,
			//             v21,
			//             v22,
			//             (MessageDescriptor *)tooltip,
			//             v49,
			//             v55,
			//             v61);
			//           v23 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//           v24 = v23;
			//           if ( v23 )
			//           {
			//             System::Func<bool>::Func(
			//               v23,
			//               (Object *)v12,
			//               MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__0,
			//               0LL);
			//             v16.fields._._getter_k__BackingField = v24;
			//             sub_1800054D0((OneofDescriptor *)&v16.fields._._getter_k__BackingField, v25, v26, v27, v50, v56, v62);
			//             v28 = (Action_1_Boolean_ *)sub_180004920(TypeInfo::System::Action<bool>);
			//             v29 = v28;
			//             if ( v28 )
			//             {
			//               System::Action<bool>::Action(
			//                 v28,
			//                 (Object *)v12,
			//                 MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__1,
			//                 0LL);
			//               v16.fields._._setter_k__BackingField = v29;
			//               sub_1800054D0((OneofDescriptor *)&v16.fields._._setter_k__BackingField, v30, v31, v32, v51, v57, v63);
			//               v35 = il2cpp_array_new_specific_0(TypeInfo::System::Func<bool>, 3LL, v33, v34);
			//               v36 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//               v37 = v36;
			//               if ( v36 )
			//               {
			//                 System::Func<bool>::Func(
			//                   v36,
			//                   (Object *)v12,
			//                   MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__2,
			//                   0LL);
			//                 if ( v35 )
			//                 {
			//                   sub_180328478(v35, 0LL, v37);
			//                   v38 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//                   v39 = v38;
			//                   if ( v38 )
			//                   {
			//                     System::Func<bool>::Func(
			//                       v38,
			//                       (Object *)v12,
			//                       MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__3,
			//                       0LL);
			//                     sub_180328478(v35, 1LL, v39);
			//                     v40 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//                     v41 = v40;
			//                     if ( v40 )
			//                     {
			//                       System::Func<bool>::Func(
			//                         v40,
			//                         (Object *)v12,
			//                         MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__4,
			//                         0LL);
			//                       sub_180328478(v35, 2LL, v41);
			//                       v16[1].klass = (DebugUI_BoolField__Class *)v35;
			//                       sub_1800054D0((OneofDescriptor *)&v16[1], v42, v43, v44, v52, v58, v64);
			//                       return (DebugUI_HistoryBoolField *)v16;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3100, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1089(
			//            Patch,
			//            (Object *)frameSettingsContainer,
			//            field,
			//            (Object *)attribute,
			//            0LL);
			// }
			// 
			return null;
		}

		private static DebugUI.HistoryEnumField GenerateHistoryEnumField(IFrameSettingsHistoryContainer frameSettingsContainer, FrameSettingsField field, FrameSettingsFieldAttribute attribute, Type autoEnum)
		{
			// // DebugUI+HistoryEnumField GenerateHistoryEnumField(IFrameSettingsHistoryContainer, FrameSettingsField, FrameSettingsFieldAttribute, Type)
			// DebugUI_HistoryEnumField *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryEnumField(
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         FrameSettingsField__Enum field,
			//         FrameSettingsFieldAttribute *attribute,
			//         Type *autoEnum,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rax
			//   OneofDescriptorProto *v10; // rdx
			//   __int64 v11; // rcx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   __int64 v14; // rdi
			//   String *v15; // rbp
			//   int32_t v16; // ebx
			//   DebugUI_EnumField *v17; // rax
			//   DebugUI_EnumField *v18; // rbx
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   String *tooltip; // r9
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   Func_1_Int32_ *v25; // rax
			//   Func_1_Int32_ *v26; // rsi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   Action_1_Int32_ *v30; // rax
			//   Action_1_Int32_ *v31; // rsi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   Func_1_Int32_ *v35; // rax
			//   Func_1_Int32_ *v36; // rsi
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   OneofDescriptorProto *v40; // rdx
			//   FileDescriptor *v41; // r8
			//   MessageDescriptor *v42; // r9
			//   Action_1_Int32_ *_9__19_3; // rsi
			//   Object *v44; // rbp
			//   Action_1_Int32_ *v45; // rax
			//   OneofDescriptorProto *static_fields; // rdx
			//   FileDescriptor *v47; // r8
			//   MessageDescriptor *v48; // r9
			//   __int64 v49; // r8
			//   __int64 v50; // r9
			//   __int64 v51; // rsi
			//   Func_1_Int32_ *v52; // rax
			//   Func_1_Int32_ *v53; // rbp
			//   Func_1_Int32_ *v54; // rax
			//   Func_1_Int32_ *v55; // rbp
			//   Func_1_Int32_ *v56; // rax
			//   Func_1_Int32_ *v57; // rbp
			//   OneofDescriptorProto *v58; // rdx
			//   FileDescriptor *v59; // r8
			//   MessageDescriptor *v60; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *P3; // [rsp+20h] [rbp-18h]
			//   Object *P3a; // [rsp+20h] [rbp-18h]
			//   Object *P3g; // [rsp+20h] [rbp-18h]
			//   Object *P3b; // [rsp+20h] [rbp-18h]
			//   Object *P3c; // [rsp+20h] [rbp-18h]
			//   Object *P3d; // [rsp+20h] [rbp-18h]
			//   Object *P3e; // [rsp+20h] [rbp-18h]
			//   Object *P3f; // [rsp+20h] [rbp-18h]
			//   String *v71; // [rsp+28h] [rbp-10h]
			//   String *v72; // [rsp+28h] [rbp-10h]
			//   String *v73; // [rsp+28h] [rbp-10h]
			//   String *v74; // [rsp+28h] [rbp-10h]
			//   String *v75; // [rsp+28h] [rbp-10h]
			//   String *v76; // [rsp+28h] [rbp-10h]
			//   String *v77; // [rsp+28h] [rbp-10h]
			//   String *v78; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v79; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v80; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v81; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v82; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v83; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v84; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v85; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v86; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D91967B )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<int>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<int>::set_getter);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<int>::set_setter);
			//     sub_18003C530(&TypeInfo::System::Func<int>);
			//     sub_18003C530(&TypeInfo::System::Func<int>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::HistoryEnumField);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryEnumField_b__19_3);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__4);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__5);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__6);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//     sub_18003C530(&off_18CDBE620);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D91967B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3107, 0LL) )
			//   {
			//     v9 = sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0);
			//     v14 = v9;
			//     if ( v9 )
			//     {
			//       *(_QWORD *)(v9 + 16) = frameSettingsContainer;
			//       sub_1800054D0((OneofDescriptor *)(v9 + 16), v10, v12, v13, (String__Array *)P3, v71, v79);
			//       *(_DWORD *)(v14 + 24) = field;
			//       v15 = (String *)"";
			//       v16 = 0;
			//       if ( attribute )
			//       {
			//         while ( v16 < attribute.fields.indentLevel )
			//         {
			//           v15 = System::String::Concat(v15, (String *)"  ", 0LL);
			//           ++v16;
			//         }
			//         v17 = (DebugUI_EnumField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::HistoryEnumField);
			//         v18 = v17;
			//         if ( v17 )
			//         {
			//           UnityEngine::Rendering::DebugUI::EnumField::EnumField(v17, 0LL);
			//           v18.fields._._._displayName_k__BackingField = System::String::Concat(
			//                                                            v15,
			//                                                            attribute.fields.displayedName,
			//                                                            0LL);
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v18.fields._._._displayName_k__BackingField,
			//             v19,
			//             v20,
			//             v21,
			//             (String__Array *)P3a,
			//             v72,
			//             v80);
			//           tooltip = attribute.fields.tooltip;
			//           v18.fields._._._tooltip_k__BackingField = tooltip;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v18.fields._._._tooltip_k__BackingField,
			//             v23,
			//             v24,
			//             (MessageDescriptor *)tooltip,
			//             (String__Array *)P3g,
			//             v73,
			//             v81);
			//           v25 = (Func_1_Int32_ *)sub_180004920(TypeInfo::System::Func<int>);
			//           v26 = v25;
			//           if ( v25 )
			//           {
			//             System::Func<int>::Func(
			//               v25,
			//               (Object *)v14,
			//               MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__0,
			//               0LL);
			//             v18.fields._._getter_k__BackingField = v26;
			//             sub_1800054D0(
			//               (OneofDescriptor *)&v18.fields._._getter_k__BackingField,
			//               v27,
			//               v28,
			//               v29,
			//               (String__Array *)P3b,
			//               v74,
			//               v82);
			//             v30 = (Action_1_Int32_ *)sub_180004920(TypeInfo::System::Action<int>);
			//             v31 = v30;
			//             if ( v30 )
			//             {
			//               System::Action<int>::Action(
			//                 v30,
			//                 (Object *)v14,
			//                 MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__1,
			//                 0LL);
			//               v18.fields._._setter_k__BackingField = v31;
			//               sub_1800054D0(
			//                 (OneofDescriptor *)&v18.fields._._setter_k__BackingField,
			//                 v32,
			//                 v33,
			//                 v34,
			//                 (String__Array *)P3c,
			//                 v75,
			//                 v83);
			//               UnityEngine::Rendering::DebugUI::EnumField::set_autoEnum(v18, autoEnum, 0LL);
			//               v35 = (Func_1_Int32_ *)sub_180004920(TypeInfo::System::Func<int>);
			//               v36 = v35;
			//               if ( v35 )
			//               {
			//                 System::Func<int>::Func(
			//                   v35,
			//                   (Object *)v14,
			//                   MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__2,
			//                   0LL);
			//                 v18.fields._getIndex_k__BackingField = v36;
			//                 sub_1800054D0(
			//                   (OneofDescriptor *)&v18.fields._getIndex_k__BackingField,
			//                   v37,
			//                   v38,
			//                   v39,
			//                   (String__Array *)P3d,
			//                   v76,
			//                   v84);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//                 _9__19_3 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9__19_3;
			//                 if ( !_9__19_3 )
			//                 {
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//                   v44 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9;
			//                   v45 = (Action_1_Int32_ *)sub_180004920(TypeInfo::System::Action<int>);
			//                   _9__19_3 = v45;
			//                   if ( !v45 )
			//                     goto LABEL_21;
			//                   System::Action<int>::Action(
			//                     v45,
			//                     v44,
			//                     MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryEnumField_b__19_3,
			//                     0LL);
			//                   static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields;
			//                   static_fields.fields._unknownFields = (UnknownFieldSet *)_9__19_3;
			//                   sub_1800054D0(
			//                     (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9__19_3,
			//                     static_fields,
			//                     v47,
			//                     v48,
			//                     (String__Array *)P3e,
			//                     v77,
			//                     v85);
			//                 }
			//                 v18.fields._setIndex_k__BackingField = _9__19_3;
			//                 sub_1800054D0(
			//                   (OneofDescriptor *)&v18.fields._setIndex_k__BackingField,
			//                   v40,
			//                   v41,
			//                   v42,
			//                   (String__Array *)P3e,
			//                   v77,
			//                   v85);
			//                 v51 = il2cpp_array_new_specific_0(TypeInfo::System::Func<int>, 3LL, v49, v50);
			//                 v52 = (Func_1_Int32_ *)sub_180004920(TypeInfo::System::Func<int>);
			//                 v53 = v52;
			//                 if ( v52 )
			//                 {
			//                   System::Func<int>::Func(
			//                     v52,
			//                     (Object *)v14,
			//                     MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__4,
			//                     0LL);
			//                   if ( v51 )
			//                   {
			//                     sub_180328478(v51, 0LL, v53);
			//                     v54 = (Func_1_Int32_ *)sub_180004920(TypeInfo::System::Func<int>);
			//                     v55 = v54;
			//                     if ( v54 )
			//                     {
			//                       System::Func<int>::Func(
			//                         v54,
			//                         (Object *)v14,
			//                         MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__5,
			//                         0LL);
			//                       sub_180328478(v51, 1LL, v55);
			//                       v56 = (Func_1_Int32_ *)sub_180004920(TypeInfo::System::Func<int>);
			//                       v57 = v56;
			//                       if ( v56 )
			//                       {
			//                         System::Func<int>::Func(
			//                           v56,
			//                           (Object *)v14,
			//                           MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__6,
			//                           0LL);
			//                         sub_180328478(v51, 2LL, v57);
			//                         v18[1].klass = (DebugUI_EnumField__Class *)v51;
			//                         sub_1800054D0((OneofDescriptor *)&v18[1], v58, v59, v60, (String__Array *)P3f, v78, v86);
			//                         return (DebugUI_HistoryEnumField *)v18;
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
			// LABEL_21:
			//     sub_180B536AC(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3107, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1090(
			//            Patch,
			//            (Object *)frameSettingsContainer,
			//            field,
			//            (Object *)attribute,
			//            (Object *)autoEnum,
			//            0LL);
			// }
			// 
			return null;
		}

		private static ObservableList<DebugUI.Widget> GenerateHistoryArea(IFrameSettingsHistoryContainer frameSettingsContainer, int groupIndex)
		{
			// // ObservableList`1[DebugUI+Widget] GenerateHistoryArea(IFrameSettingsHistoryContainer, Int32)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// ObservableList_1_DebugUI_Widget_ *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea(
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         int32_t groupIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rdi
			//   __int64 v9; // rdx
			//   FrameSettingsHistory__StaticFields *static_fields; // rcx
			//   __int64 v11; // rdx
			//   FrameSettingsHistory__StaticFields *v12; // rcx
			//   __int64 v13; // rdx
			//   struct FrameSettingsHistory__Class *v14; // rcx
			//   FrameSettingsHistory__StaticFields *v15; // rax
			//   Dictionary_2_System_Int32_System_Object_ *attributesGroup; // r14
			//   int32_t v17; // r12d
			//   IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *attributes; // rsi
			//   Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *v22; // rbx
			//   IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *v23; // rsi
			//   Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__20_1; // rbx
			//   Object *v25; // r15
			//   Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *v26; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   OneofDescriptorProto *v29; // rdx
			//   FileDescriptor *v30; // r8
			//   MessageDescriptor *v31; // r9
			//   Object *v32; // rbx
			//   __int64 v33; // rdx
			//   FrameSettingsHistory__StaticFields *v34; // rcx
			//   ObservableList_1_System_Object_ *v35; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   ObservableList_1_DebugUI_Widget_ *v38; // rbx
			//   __int64 v39; // rdx
			//   FrameSettingsHistory__StaticFields *v40; // rcx
			//   int32_t v41; // edi
			//   Object *Item; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   __int64 v45; // rdx
			//   __int64 type; // rcx
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   __int64 v49; // rax
			//   __int64 v50; // rcx
			//   __m128i v51; // xmm6
			//   FrameSettingsFieldAttribute *v52; // rdi
			//   Type *EnumTypeByField; // rax
			//   Object *HistoryBoolField; // rax
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int64 v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   InvalidEnumArgumentException *v62; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   String *v67; // rax
			//   __int64 v68; // rax
			//   String__Array *v69; // [rsp+20h] [rbp-78h]
			//   String *v70; // [rsp+28h] [rbp-70h]
			//   MethodInfo *v71; // [rsp+30h] [rbp-68h]
			//   _QWORD v72[2]; // [rsp+40h] [rbp-58h] BYREF
			//   _BYTE v73[16]; // [rsp+50h] [rbp-48h] BYREF
			//   __int64 v74; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91967C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			//     sub_18003C530(&TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Value);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::ObservableList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryArea_b__20_1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0::_GenerateHistoryArea_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//     byte_18D91967C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3115, 0LL) )
			//   {
			//     v5 = sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0);
			//     v8 = v5;
			//     if ( !v5 )
			//       sub_180B536AC(v7, v6);
			//     *(_DWORD *)(v5 + 16) = groupIndex;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     if ( !static_fields.attributesGroup )
			//       sub_180B536AC(static_fields, v9);
			//     if ( !System::Collections::Generic::Dictionary<int,System::Object>::ContainsKey(
			//             (Dictionary_2_System_Int32_System_Object_ *)static_fields.attributesGroup,
			//             *(_DWORD *)(v8 + 16),
			//             MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::ContainsKey) )
			//       goto LABEL_9;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     v12 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     if ( !v12.attributesGroup )
			//       sub_180B536AC(v12, v11);
			//     if ( !System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//             (Dictionary_2_System_Int32_System_Object_ *)v12.attributesGroup,
			//             *(_DWORD *)(v8 + 16),
			//             MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::get_Item) )
			//     {
			// LABEL_9:
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//       v14 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
			//       v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//       attributesGroup = (Dictionary_2_System_Int32_System_Object_ *)v15.attributesGroup;
			//       v17 = *(_DWORD *)(v8 + 16);
			//       attributes = (IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *)v15.attributes;
			//       if ( !attributes )
			//         goto LABEL_16;
			//       v19 = (Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)sub_180004920(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
			//       v22 = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)v19;
			//       if ( !v19 )
			//         sub_180B536AC(v21, v20);
			//       System::Predicate<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile>::Predicate(
			//         v19,
			//         (Object *)v8,
			//         MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0::_GenerateHistoryArea_b__0,
			//         0LL);
			//       v23 = System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>(
			//               attributes,
			//               v22,
			//               MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
			//       if ( v23 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//         _9__20_1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9__20_1;
			//         if ( !_9__20_1 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
			//           v25 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9;
			//           v26 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *)sub_180004920(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			//           _9__20_1 = (Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v26;
			//           if ( !v26 )
			//             sub_180B536AC(v28, v27);
			//           System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Int32Enum>::Func(
			//             v26,
			//             v25,
			//             MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryArea_b__20_1,
			//             0LL);
			//           TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9__20_1 = _9__20_1;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c.static_fields.__9__20_1,
			//             v29,
			//             v30,
			//             v31,
			//             v69,
			//             v70,
			//             v71);
			//         }
			//         v32 = (Object *)System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<System::Int32Enum,System::Object>,int>(
			//                           (IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *)v23,
			//                           (Func_2_System_Collections_Generic_KeyValuePair_2_System_Int32Enum_System_Object_Int32_ *)_9__20_1,
			//                           MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			//       }
			//       else
			//       {
			// LABEL_16:
			//         v32 = 0LL;
			//       }
			//       if ( !attributesGroup )
			//         sub_180B536AC(v14, v13);
			//       System::Collections::Generic::Dictionary<int,System::Object>::set_Item(
			//         attributesGroup,
			//         v17,
			//         v32,
			//         MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::set_Item);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     v34 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     if ( !v34.attributesGroup )
			//       sub_180B536AC(v34, v33);
			//     if ( !System::Collections::Generic::Dictionary<int,System::Object>::ContainsKey(
			//             (Dictionary_2_System_Int32_System_Object_ *)v34.attributesGroup,
			//             *(_DWORD *)(v8 + 16),
			//             MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::ContainsKey) )
			//     {
			//       v59 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//       v62 = (InvalidEnumArgumentException *)sub_180004920(v59);
			//       if ( !v62 )
			//         sub_180B536AC(v61, v60);
			//       v67 = (String *)sub_18000F7E0(&off_18D50D020);
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v62, v67, 0LL);
			//       v68 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea);
			//       sub_18000F7C0(v62, v68);
			//     }
			//     v35 = (ObservableList_1_System_Object_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>);
			//     v38 = (ObservableList_1_DebugUI_Widget_ *)v35;
			//     if ( !v35 )
			//       sub_180B536AC(v37, v36);
			//     UnityEngine::Rendering::ObservableList<System::Object>::ObservableList(
			//       v35,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::ObservableList);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     v40 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     v41 = *(_DWORD *)(v8 + 16);
			//     if ( !v40.attributesGroup )
			//       sub_180B536AC(v40, v39);
			//     Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//              (Dictionary_2_System_Int32_System_Object_ *)v40.attributesGroup,
			//              v41,
			//              MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::get_Item);
			//     if ( !Item )
			//       sub_180B536AC(v44, v43);
			//     v74 = sub_1800513A0(
			//             0LL,
			//             TypeInfo::System::Collections::Generic::IEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>,
			//             Item);
			//     v72[0] = 0LL;
			//     v72[1] = &v74;
			//     while ( 1 )
			//     {
			//       while ( 1 )
			//       {
			//         if ( !v74 )
			//           sub_1802DC2C8(type, v45);
			//         if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//         {
			//           sub_1801E4D90(v72);
			//           return v38;
			//         }
			//         if ( !v74 )
			//           sub_1802DC2C8(v48, v47);
			//         v49 = sub_180831810(v73);
			//         v51 = *(__m128i *)v49;
			//         v52 = *(FrameSettingsFieldAttribute **)(v49 + 8);
			//         if ( !v52 )
			//           sub_1802DC2C8(v50, v45);
			//         type = (unsigned int)v52.fields.type;
			//         if ( (_DWORD)type )
			//           break;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//         HistoryBoolField = (Object *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryBoolField(
			//                                        frameSettingsContainer,
			//                                        (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
			//                                        v52,
			//                                        0LL);
			//         if ( !v38 )
			//           sub_1802DC2C8(v58, v57);
			// LABEL_34:
			//         UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//           (ObservableList_1_System_Object_ *)v38,
			//           HistoryBoolField,
			//           MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//       }
			//       if ( (_DWORD)type == 1 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//         EnumTypeByField = HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField(
			//                             (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
			//                             0LL);
			//         HistoryBoolField = (Object *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryEnumField(
			//                                        frameSettingsContainer,
			//                                        (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
			//                                        v52,
			//                                        EnumTypeByField,
			//                                        0LL);
			//         if ( !v38 )
			//           sub_1802DC2C8(v56, v55);
			//         goto LABEL_34;
			//       }
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3115, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v65, v64);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1092(Patch, (Object *)frameSettingsContainer, groupIndex, 0LL);
			// }
			// 
			return null;
		}

		private static DebugUI.Widget[] GenerateFrameSettingsPanelContent(IFrameSettingsHistoryContainer frameSettingsContainer)
		{
			// // DebugUI+Widget[] GenerateFrameSettingsPanelContent(IFrameSettingsHistoryContainer)
			// DebugUI_Widget__Array *HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanelContent(
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         MethodInfo *method)
			// {
			//   FrameSettingsHistory__StaticFields *v3; // rdx
			//   __int64 v4; // r8
			//   __int64 v5; // r9
			//   FrameSettingsHistory__StaticFields **static_fields; // rcx
			//   DebugUI_Widget__Array *v7; // rdi
			//   int32_t i; // ebx
			//   String *v9; // r14
			//   ObservableList_1_DebugUI_Widget_ *HistoryArea; // r15
			//   FrameSettingsHistory__StaticFields *v11; // rcx
			//   String__Array *columnNames; // r12
			//   String__Array *v13; // r13
			//   DebugUI_Foldout *v14; // rax
			//   DebugUI_Widget *v15; // rsi
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *columnTooltips; // [rsp+20h] [rbp-38h]
			//   String *v21; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v22; // [rsp+30h] [rbp-28h]
			// 
			//   if ( !byte_18D91967D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::Foldout);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::Widget);
			//     byte_18D91967D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3119, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3119, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1093(Patch, (Object *)frameSettingsContainer, 0LL);
			// LABEL_17:
			//     sub_180B536AC(static_fields, v3);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//   static_fields = (FrameSettingsHistory__StaticFields **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_17;
			//   v7 = (DebugUI_Widget__Array *)il2cpp_array_new_specific_0(
			//                                   TypeInfo::UnityEngine::Rendering::DebugUI::Widget,
			//                                   LODWORD((*static_fields).attributes),
			//                                   v4,
			//                                   v5);
			//   for ( i = 0; ; ++i )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     static_fields = (FrameSettingsHistory__StaticFields **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
			//     v3 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     if ( !v3.foldoutNames )
			//       goto LABEL_17;
			//     if ( i >= v3.foldoutNames.max_length.size )
			//       break;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     static_fields = (FrameSettingsHistory__StaticFields **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     v3 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_17;
			//     if ( (unsigned int)i >= LODWORD(v3.attributes) )
			// LABEL_14:
			//       sub_180070270(static_fields, v3);
			//     v9 = (String *)*((_QWORD *)&v3.attributesGroup + i);
			//     HistoryArea = HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea(frameSettingsContainer, i, 0LL);
			//     v11 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields;
			//     columnNames = v11.columnNames;
			//     v13 = v11.columnTooltips;
			//     v14 = (DebugUI_Foldout *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::Foldout);
			//     v15 = (DebugUI_Widget *)v14;
			//     if ( !v14 )
			//       goto LABEL_17;
			//     UnityEngine::Rendering::DebugUI::Foldout::Foldout(v14, v9, HistoryArea, columnNames, v13, 0LL);
			//     if ( !v7 )
			//       goto LABEL_17;
			//     sub_180036D40(v7, v15);
			//     if ( (unsigned int)i >= v7.max_length.size )
			//       goto LABEL_14;
			//     v7.vector[i] = v15;
			//     sub_1800054D0((OneofDescriptor *)&v7.vector[i], (OneofDescriptorProto *)v3, v16, v17, columnTooltips, v21, v22);
			//   }
			//   return v7;
			// }
			// 
			return null;
		}

		private static void GenerateFrameSettingsPanel(string menuName, IFrameSettingsHistoryContainer frameSettingsContainer)
		{
			// // Void GenerateFrameSettingsPanel(String, IFrameSettingsHistoryContainer)
			// void HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanel(
			//         String *menuName,
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_System_Object_ *v8; // rbx
			//   IEnumerable_1_System_Object_ *FrameSettingsPanelContent; // rax
			//   DebugManager *instance; // rax
			//   DebugUI_Panel *Panel; // rax
			//   ObservableList_1_System_Object_ *children_k__BackingField; // rdi
			//   Object__Array *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91967E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     byte_18D91967E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3120, 0LL) )
			//   {
			//     v5 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
			//     v8 = (List_1_System_Object_ *)v5;
			//     if ( v5 )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//         v5,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//       FrameSettingsPanelContent = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanelContent(
			//                                                                     frameSettingsContainer,
			//                                                                     0LL);
			//       System::Collections::Generic::List<System::Object>::AddRange(
			//         v8,
			//         FrameSettingsPanelContent,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::AddRange);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::DebugManager);
			//       instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
			//       if ( instance )
			//       {
			//         Panel = UnityEngine::Rendering::DebugManager::GetPanel(instance, menuName, 1, 2, 1, 0LL);
			//         if ( Panel )
			//         {
			//           children_k__BackingField = (ObservableList_1_System_Object_ *)Panel.fields._children_k__BackingField;
			//           v13 = System::Collections::Generic::List<System::Object>::ToArray(
			//                   v8,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
			//           if ( children_k__BackingField )
			//           {
			//             UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//               children_k__BackingField,
			//               v13,
			//               MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3120, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)menuName,
			//     (Object *)frameSettingsContainer,
			//     0LL);
			// }
			// 
		}

		private static Type RetrieveEnumTypeByField(FrameSettingsField field)
		{
			// // Type RetrieveEnumTypeByField(FrameSettingsField)
			// Type *HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField(
			//         FrameSettingsField__Enum field,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   InvalidEnumArgumentException *v6; // rbx
			//   String *v7; // rax
			//   __int64 v8; // rax
			//   struct Il2CppType *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91967F )
			//   {
			//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::LitShaderMode);
			//     sub_18003C530(&TypeInfo::System::Type);
			//     byte_18D91967F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3118, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3118, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1091(Patch, field, 0LL);
			//   }
			//   else
			//   {
			//     if ( field )
			//     {
			//       v3 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//       v6 = (InvalidEnumArgumentException *)sub_180004920(v3);
			//       if ( v6 )
			//       {
			//         v7 = (String *)sub_18000F7E0(&off_18D50D048);
			//         System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v6, v7, 0LL);
			//         v8 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField);
			//         sub_18000F7C0(v6, v8);
			//       }
			// LABEL_9:
			//       sub_180B536AC(v5, v4);
			//     }
			//     v9 = TypeRef::HG::Rendering::Runtime::LitShaderMode;
			//     sub_180002C70(TypeInfo::System::Type);
			//     return System::Type::GetTypeFromHandle((RuntimeTypeHandle)v9, 0LL);
			//   }
			// }
			// 
			return null;
		}

		public static IDebugData RegisterDebug(IFrameSettingsHistoryContainer frameSettingsContainer, [MetadataOffset(Offset = "0x01F91A0B")] bool sceneViewCamera = false)
		{
			// // IDebugData RegisterDebug(IFrameSettingsHistoryContainer, Boolean)
			// IDebugData *HG::Rendering::Runtime::FrameSettingsHistory::RegisterDebug(
			//         IFrameSettingsHistoryContainer *frameSettingsContainer,
			//         bool sceneViewCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
			//   String *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919680 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Add);
			//     byte_18D919680 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3121, 0LL) )
			//   {
			//     if ( frameSettingsContainer )
			//     {
			//       v7 = (String *)sub_188660098(frameSettingsContainer);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//       HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanel(v7, frameSettingsContainer, 0LL);
			//       containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields.containers;
			//       if ( containers )
			//       {
			//         System::Collections::Generic::HashSet<System::Object>::Add(
			//           (HashSet_1_System_Object_ *)containers,
			//           (Object *)frameSettingsContainer,
			//           MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Add);
			//         return (IDebugData *)frameSettingsContainer;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(containers, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3121, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1094(Patch, (Object *)frameSettingsContainer, sceneViewCamera, 0LL);
			// }
			// 
			return null;
		}

		public static void UnRegisterDebug(IFrameSettingsHistoryContainer container)
		{
			// // Void UnRegisterDebug(IFrameSettingsHistoryContainer)
			// void HG::Rendering::Runtime::FrameSettingsHistory::UnRegisterDebug(
			//         IFrameSettingsHistoryContainer *container,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
			//   DebugManager *instance; // rdi
			//   String *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919681 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Remove);
			//     byte_18D919681 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3122, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::DebugManager);
			//     instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
			//     if ( container )
			//     {
			//       v6 = (String *)sub_188660098(container);
			//       if ( instance )
			//       {
			//         UnityEngine::Rendering::DebugManager::RemovePanel(instance, v6, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//         containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields.containers;
			//         if ( containers )
			//         {
			//           System::Collections::Generic::HashSet<System::Object>::Remove(
			//             (HashSet_1_System_Object_ *)containers,
			//             (Object *)container,
			//             MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(containers, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3122, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)container, 0LL);
			// }
			// 
		}

		public static bool IsRegistered(IFrameSettingsHistoryContainer container, [MetadataOffset(Offset = "0x01F91A0C")] bool sceneViewCamera = false)
		{
			// // Boolean IsRegistered(IFrameSettingsHistoryContainer, Boolean)
			// bool HG::Rendering::Runtime::FrameSettingsHistory::IsRegistered(
			//         IFrameSettingsHistoryContainer *container,
			//         bool sceneViewCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919682 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Contains);
			//     byte_18D919682 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3123, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3123, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(
			//              (ILFixDynamicMethodWrapper_8 *)Patch,
			//              (Object *)container,
			//              sceneViewCamera,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !sceneViewCamera )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			//       containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields.containers;
			//       if ( containers )
			//         return System::Collections::Generic::HashSet<System::Object>::Contains(
			//                  (HashSet_1_System_Object_ *)containers,
			//                  (Object *)container,
			//                  MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Contains);
			// LABEL_9:
			//       sub_180B536AC(containers, v5);
			//     }
			//     return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		internal void TriggerReset()
		{
			// // Void TriggerReset()
			// void HG::Rendering::Runtime::FrameSettingsHistory::TriggerReset(FrameSettingsHistory *this, MethodInfo *method)
			// {
			//   BitArray128 bitDatas; // xmm0
			//   __int64 v4; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2294, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2294, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_828(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     bitDatas = this.sanitazed.bitDatas;
			//     this.hasDebug = 0;
			//     v4 = *(_QWORD *)&this.sanitazed.materialQuality;
			//     this.debug.bitDatas = bitDatas;
			//     *(_QWORD *)&this.debug.materialQuality = v4;
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly string[] foldoutNames;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly string[] columnNames;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly string[] columnTooltips;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly Dictionary<FrameSettingsField, FrameSettingsFieldAttribute> attributes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static Dictionary<int, IOrderedEnumerable<KeyValuePair<FrameSettingsField, FrameSettingsFieldAttribute>>> attributesGroup;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		internal static HashSet<IFrameSettingsHistoryContainer> containers;

		public FrameSettingsRenderType defaultType;

		public FrameSettings overridden;

		public FrameSettingsOverrideMask customMask;

		public FrameSettings sanitazed;

		public FrameSettings debug;

		private bool hasDebug;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static bool s_PossiblyInUse;
	}
}
