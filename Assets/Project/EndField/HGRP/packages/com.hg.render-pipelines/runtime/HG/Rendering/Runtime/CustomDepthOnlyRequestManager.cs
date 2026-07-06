using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class CustomDepthOnlyRequestManager
	{
		public CustomDepthOnlyRequestManager()
		{
			// // CustomDepthOnlyRequestManager()
			// void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CustomDepthOnlyRequestManager(
			//         CustomDepthOnlyRequestManager *this,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v6; // rbx
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   String__Array *v10; // [rsp+50h] [rbp+28h]
			//   String *v11; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDD22 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::DynamicArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>);
			//     byte_18D8EDD22 = 1;
			//   }
			//   v3 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>);
			//   v6 = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v3,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::DynamicArray);
			//   this.fields.m_systems = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v7, v8, v9, v10, v11, v12);
			// }
			// 
		}

		private Nullable<CustomDepthOnlyRequestManager.SystemData> CreateSystem(ref CustomDepthOnlyRequestManager.Request request)
		{
			// // Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+SystemData] CreateSystem(CustomDepthOnlyRequestManager+Request ByRef)
			// Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateSystem(
			//         Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *__return_ptr retstr,
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Request *request,
			//         MethodInfo *method)
			// {
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v6; // r14
			//   LowLevelList_1_System_Object_ *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v10; // rdi
			//   __int64 v11; // r13
			//   int v12; // r15d
			//   int v13; // ebx
			//   int v14; // r12d
			//   List_1_Beyond_GameSetting_ScreenResolution_ *v15; // r14
			//   int i; // edi
			//   double v17; // xmm1_8
			//   GenericDelegateCallerGen_FStructSize8FStructSize8_intDelegate_3_Beyond_Gameplay_Factory_Core_Vector2IntData_Beyond_Gameplay_Factory_Core_Vector2IntData_System_Int32_ *v18; // rax
			//   Comparison_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v19; // rbx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v20; // rax
			//   System::Math *v21; // rcx
			//   float v22; // xmm7_4
			//   float v23; // xmm1_4
			//   System::Math *v24; // rcx
			//   float v25; // xmm0_4
			//   int v26; // r8d
			//   __int64 v27; // r13
			//   int32_t v28; // ecx
			//   int v29; // ebx
			//   __int64 v30; // rdi
			//   int v31; // eax
			//   int v32; // edx
			//   unsigned int v33; // r8d
			//   OneofDescriptor__Class *v34; // r13
			//   __int64 v35; // rbx
			//   int32_t v36; // r14d
			//   __int64 v37; // r8
			//   __int64 v38; // r9
			//   __int64 v39; // rax
			//   __int64 v40; // rcx
			//   __int64 v41; // rdx
			//   RTHandle *v42; // rbx
			//   OneofDescriptor *v43; // rax
			//   OneofDescriptorProto *v44; // rdx
			//   FileDescriptor *v45; // r8
			//   MessageDescriptor *v46; // r9
			//   RTHandle *v47; // rbx
			//   OneofDescriptor *v48; // rax
			//   OneofDescriptorProto *v49; // rdx
			//   FileDescriptor *v50; // r8
			//   MessageDescriptor *v51; // r9
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   float x; // xmm2_4
			//   OneofDescriptorProto *v56; // rdx
			//   FileDescriptor *v57; // r8
			//   MessageDescriptor *v58; // r9
			//   OneofDescriptorProto *v59; // rdx
			//   FileDescriptor *v60; // r8
			//   MessageDescriptor *v61; // r9
			//   Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v62; // rax
			//   Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v63; // rsi
			//   OneofDescriptorProto *v64; // rdx
			//   FileDescriptor *v65; // r8
			//   MessageDescriptor *v66; // r9
			//   OneofDescriptorProto *v67; // rdx
			//   FileDescriptor *v68; // r8
			//   MessageDescriptor *v69; // r9
			//   _OWORD *v70; // rcx
			//   __int64 v71; // rdx
			//   _OWORD *v72; // rax
			//   __int128 v73; // xmm1
			//   __int128 v74; // xmm0
			//   __int128 v75; // xmm1
			//   __int128 v76; // xmm0
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   struct MethodInfo *v80; // r8
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v81; // rax
			//   OneofDescriptor__Fields *p_fields; // rcx
			//   __int128 v83; // xmm1
			//   __int128 v84; // xmm0
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm0
			//   __int128 v87; // xmm1
			//   __int128 v88; // xmm0
			//   __int128 v89; // xmm1
			//   __int64 v90; // rdi
			//   __int128 v91; // xmm1
			//   __int128 v92; // xmm0
			//   __int128 v93; // xmm1
			//   __int128 v94; // xmm0
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   __int128 v97; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v99; // rax
			//   __int64 v100; // rdi
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v101; // rcx
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm0
			//   __int128 v104; // xmm1
			//   __int128 v105; // xmm0
			//   __int128 v106; // xmm1
			//   __int128 v107; // xmm0
			//   __int128 v108; // xmm1
			//   String__Array *colorFormata; // [rsp+28h] [rbp-100h]
			//   String__Array *colorFormatb; // [rsp+28h] [rbp-100h]
			//   String__Array *colorFormatc; // [rsp+28h] [rbp-100h]
			//   String__Array *colorFormatd; // [rsp+28h] [rbp-100h]
			//   String__Array *colorFormat; // [rsp+28h] [rbp-100h]
			//   String__Array *colorFormate; // [rsp+28h] [rbp-100h]
			//   String *filterModea; // [rsp+30h] [rbp-F8h]
			//   String *filterModeb; // [rsp+30h] [rbp-F8h]
			//   String *filterModec; // [rsp+30h] [rbp-F8h]
			//   String *filterModed; // [rsp+30h] [rbp-F8h]
			//   String *filterMode; // [rsp+30h] [rbp-F8h]
			//   String *filterModee; // [rsp+30h] [rbp-F8h]
			//   MethodInfo *wrapModea; // [rsp+38h] [rbp-F0h]
			//   MethodInfo *wrapModeb; // [rsp+38h] [rbp-F0h]
			//   MethodInfo *wrapModec; // [rsp+38h] [rbp-F0h]
			//   MethodInfo *wrapModed; // [rsp+38h] [rbp-F0h]
			//   MethodInfo *wrapMode; // [rsp+38h] [rbp-F0h]
			//   MethodInfo *wrapModee; // [rsp+38h] [rbp-F0h]
			//   List_1_System_Int32_ *item; // [rsp+B0h] [rbp-78h]
			//   __int64 v129; // [rsp+B8h] [rbp-70h]
			//   MonitorData *v130; // [rsp+C0h] [rbp-68h]
			//   _QWORD v131[2]; // [rsp+C8h] [rbp-60h] BYREF
			//   _OWORD v132[3]; // [rsp+D8h] [rbp-50h] BYREF
			//   __int64 v133; // [rsp+108h] [rbp-20h]
			//   int v134; // [rsp+110h] [rbp-18h]
			//   char v135; // [rsp+12Ch] [rbp+4h]
			//   __int64 v136; // [rsp+130h] [rbp+8h]
			//   float v137; // [rsp+138h] [rbp+10h]
			//   float v138; // [rsp+13Ch] [rbp+14h]
			//   OneofDescriptor v139; // [rsp+148h] [rbp+20h] BYREF
			//   OneofDescriptor v140[3]; // [rsp+1D8h] [rbp+B0h] BYREF
			//   _BYTE v141[304]; // [rsp+2F8h] [rbp+1D0h] BYREF
			//   OneofDescriptor__Class *v143; // [rsp+468h] [rbp+340h]
			// 
			//   v6 = retstr;
			//   if ( !byte_18D919ECD )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<UnityEngine::Vector2Int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::Sort);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Nullable);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PageInfo);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PerFrameData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Queue);
			//     sub_18003C530(TypeInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0::_CreateSystem_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919ECD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(778, 0LL) )
			//   {
			//     if ( request.rtSize.m_X % request.pageSize.m_X || request.rtSize.m_Y % request.pageSize.m_Y )
			//     {
			//       sub_1802F01E0(&v140[0].fields, 0LL, 272LL);
			//       v90 = 2LL;
			//       p_fields = &v140[0].fields;
			//       v81 = v6;
			//       do
			//       {
			//         v91 = *(_OWORD *)&p_fields._._File_k__BackingField;
			//         *(_OWORD *)&v81.hasValue = *(_OWORD *)&p_fields._._Index_k__BackingField;
			//         v92 = *(_OWORD *)&p_fields.fields;
			//         *(_OWORD *)&v81.value.request.rootPosition.z = v91;
			//         v93 = *(_OWORD *)&p_fields._Proto_k__BackingField;
			//         *(_OWORD *)&v81.value.request.rtSize.m_X = v92;
			//         v94 = *(_OWORD *)&p_fields[1]._._Index_k__BackingField;
			//         *(_OWORD *)&v81.value.request.depthBits = v93;
			//         v95 = *(_OWORD *)&p_fields[1]._._File_k__BackingField;
			//         *(_OWORD *)&v81.value.request.includeDynamicObjects = v94;
			//         v96 = *(_OWORD *)&p_fields[1].fields;
			//         *(_OWORD *)&v81.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v95;
			//         v97 = *(_OWORD *)&p_fields[1]._Proto_k__BackingField;
			//         p_fields += 2;
			//         *(_OWORD *)&v81.value.pageCount.m_X = v96;
			//         v81 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v81 + 128);
			//         *(_OWORD *)&v81[-1].value.currRTIndex = v97;
			//         --v90;
			//       }
			//       while ( v90 );
			// LABEL_36:
			//       *(_OWORD *)&v81.hasValue = *(_OWORD *)&p_fields._._Index_k__BackingField;
			//       return v6;
			//     }
			//     v7 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>);
			//     v130 = (MonitorData *)v7;
			//     v10 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v7;
			//     if ( v7 )
			//     {
			//       System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//         v7,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::List);
			//       v11 = sub_180004920(TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0);
			//       if ( v11 )
			//       {
			//         v12 = request.rtSize.m_X / request.pageSize.m_X;
			//         LODWORD(v129) = v12;
			//         v13 = 0;
			//         v14 = request.rtSize.m_Y / request.pageSize.m_Y;
			//         HIDWORD(v129) = v14;
			//         if ( v14 > 0 )
			//         {
			//           v15 = (List_1_Beyond_GameSetting_ScreenResolution_ *)v10;
			//           do
			//           {
			//             for ( i = 0; i < v12; ++i )
			//               sub_182E50950(v15, (GameSetting_ScreenResolution)__PAIR64__(v13, i));
			//             ++v13;
			//           }
			//           while ( v13 < v14 );
			//           v6 = retstr;
			//           v10 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v130;
			//         }
			//         *(_QWORD *)&v17 = COERCE_UNSIGNED_INT((float)v12);
			//         *(float *)&v17 = (float)(*(float *)&v17 * 0.5) - 0.5;
			//         *(_DWORD *)(v11 + 16) = LODWORD(v17);
			//         *(float *)(v11 + 20) = (float)((float)v14 * 0.5) - 0.5;
			//         v18 = (GenericDelegateCallerGen_FStructSize8FStructSize8_intDelegate_3_Beyond_Gameplay_Factory_Core_Vector2IntData_Beyond_Gameplay_Factory_Core_Vector2IntData_System_Int32_ *)sub_180004920(TypeInfo::System::Comparison<UnityEngine::Vector2Int>);
			//         v19 = (Comparison_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v18;
			//         if ( v18 )
			//         {
			//           Beyond::Reflection::GenericDelegateCallerGen::FStructSize8FStructSize8_intDelegate<Beyond::Gameplay::Factory::Core::Vector2IntData,Beyond::Gameplay::Factory::Core::Vector2IntData,int>::FStructSize8FStructSize8_intDelegate(
			//             v18,
			//             (Object *)v11,
			//             MethodInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0::_CreateSystem_b__0,
			//             0LL);
			//           System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Sort(
			//             v10,
			//             v19,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::Sort);
			//           v20 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//           item = (List_1_System_Int32_ *)v20;
			//           if ( v20 )
			//           {
			//             System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//               v20,
			//               MethodInfo::System::Collections::Generic::List<int>::List);
			//             sub_180002C70(TypeInfo::System::Math);
			//             System::Math::Ceiling(v21, v17);
			//             v22 = (float)v12 * 0.5;
			//             v23 = (float)v14 * 0.5;
			//             System::Math::Ceiling(v24, COERCE_DOUBLE((unsigned __int64)LODWORD(v23)));
			//             if ( v22 <= v23 )
			//               v25 = v23;
			//             else
			//               v25 = (float)v12 * 0.5;
			//             v26 = (int)v25;
			//             if ( v23 <= v22 )
			//               v22 = (float)v14 * 0.5;
			//             LODWORD(v27) = (int)v22;
			//             v28 = 0;
			//             v29 = ((v26 & 1) == 0) + 1;
			//             v30 = 2LL;
			//             if ( (int)v22 > 0 )
			//             {
			//               v131[0] = (unsigned int)v27;
			//               v27 = (unsigned int)v27;
			//               do
			//               {
			//                 sub_18231EF50(item, v28);
			//                 v28 = v29 * v29;
			//                 v29 += 2;
			//                 --v27;
			//               }
			//               while ( v27 );
			//               v6 = retstr;
			//               v26 = (int)v25;
			//               LODWORD(v27) = (int)v22;
			//             }
			//             if ( (int)v27 >= v26 )
			//             {
			//               v34 = (OneofDescriptor__Class *)item;
			//             }
			//             else
			//             {
			//               v32 = (int)v27 % 2;
			//               v31 = (int)v27 / 2;
			//               v33 = v26 - v27;
			//               v34 = (OneofDescriptor__Class *)item;
			//               v35 = v33;
			//               v36 = v32 + 4 * v31;
			//               do
			//               {
			//                 sub_18231EF50(item, v28);
			//                 v28 = v36;
			//                 --v35;
			//               }
			//               while ( v35 );
			//               v6 = retstr;
			//             }
			//             v131[0] = 32 * v12;
			//             v131[1] = 32 * v14;
			//             il2cpp_array_new_full_0(
			//               TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PageInfo,
			//               v131,
			//               0LL);
			//             ++this.fields.m_systemCount;
			//             v39 = il2cpp_array_new_specific_0(
			//                     TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PerFrameData,
			//                     2LL,
			//                     v37,
			//                     v38);
			//             v41 = 0LL;
			//             v143 = (OneofDescriptor__Class *)v39;
			//             if ( !v39 )
			//               goto LABEL_37;
			//             v42 = UnityEngine::Rendering::RTHandleSystem::Alloc(
			//                     request.rtSize.m_X,
			//                     request.rtSize.m_Y,
			//                     1,
			//                     (DepthBits__Enum)request.depthBits,
			//                     (GraphicsFormat__Enum)request.format,
			//                     FilterMode__Enum_Point,
			//                     TextureWrapMode__Enum_Repeat,
			//                     TextureDimension__Enum_Tex2D,
			//                     0,
			//                     0,
			//                     1,
			//                     0,
			//                     1,
			//                     0.0,
			//                     MSAASamples__Enum_None,
			//                     0,
			//                     RenderTextureMemoryless__Enum_None,
			//                     (String *)"",
			//                     0LL);
			//             *(_QWORD *)sub_18037A2E0(v143, 0LL) = v42;
			//             v43 = (OneofDescriptor *)sub_18037A2E0(v143, 0LL);
			//             sub_1800054D0(v43, v44, v45, v46, colorFormata, filterModea, wrapModea);
			//             v47 = UnityEngine::Rendering::RTHandleSystem::Alloc(
			//                     request.rtSize.m_X,
			//                     request.rtSize.m_Y,
			//                     1,
			//                     (DepthBits__Enum)request.depthBits,
			//                     (GraphicsFormat__Enum)request.format,
			//                     FilterMode__Enum_Point,
			//                     TextureWrapMode__Enum_Repeat,
			//                     TextureDimension__Enum_Tex2D,
			//                     0,
			//                     0,
			//                     1,
			//                     0,
			//                     1,
			//                     0.0,
			//                     MSAASamples__Enum_None,
			//                     0,
			//                     RenderTextureMemoryless__Enum_None,
			//                     (String *)"",
			//                     0LL);
			//             *(_QWORD *)sub_18037A2E0(v143, 1LL) = v47;
			//             v48 = (OneofDescriptor *)sub_18037A2E0(v143, 1LL);
			//             sub_1800054D0(v48, v49, v50, v51, colorFormatb, filterModeb, wrapModeb);
			//             sub_1802F01E0(v132, 0LL, 264LL);
			//             v52 = *(_OWORD *)&request.rootPosition.x;
			//             v53 = *(_OWORD *)&request.frustumSize.y;
			//             v134 = *(_DWORD *)&request.includeDynamicObjects;
			//             v132[0] = v52;
			//             v54 = *(_OWORD *)&request.pageSize.m_X;
			//             v135 = 1;
			//             v132[1] = v53;
			//             *(_QWORD *)&v53 = *(_QWORD *)&request.depthRTShaderID;
			//             v132[2] = v54;
			//             v133 = v53;
			//             v136 = v129;
			//             x = request.frustumSize.x;
			//             v139.klass = v34;
			//             *(float *)&v54 = request.frustumSize.y;
			//             v137 = x / (float)v12;
			//             v138 = *(float *)&v54 / (float)v14;
			//             sub_1800054D0(&v139, v56, v57, v58, colorFormatc, filterModec, wrapModec);
			//             v139.monitor = v130;
			//             sub_1800054D0((OneofDescriptor *)&v139.monitor, v59, v60, v61, colorFormatd, filterModed, wrapModed);
			//             v62 = (Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *)sub_180004920(TypeInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>[0]);
			//             v63 = v62;
			//             if ( !v62 )
			// LABEL_37:
			//               sub_180B536AC(v40, v41);
			//             System::Collections::Generic::Stack<System::Dynamic::BindingRestrictions_TestBuilder::AndNode>::Stack(
			//               v62,
			//               MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Queue);
			//             *(_QWORD *)&v139.fields._._Index_k__BackingField = v63;
			//             sub_1800054D0((OneofDescriptor *)&v139.fields, v64, v65, v66, colorFormat, filterMode, wrapMode);
			//             v140[0].klass = v143;
			//             sub_1800054D0(v140, v67, v68, v69, colorFormate, filterModee, wrapModee);
			//             sub_1802F01E0(&v140[0].fields, 0LL, 272LL);
			//             v70 = v141;
			//             v71 = 2LL;
			//             v72 = v132;
			//             do
			//             {
			//               v73 = v72[1];
			//               *v70 = *v72;
			//               v74 = v72[2];
			//               v70[1] = v73;
			//               v75 = v72[3];
			//               v70[2] = v74;
			//               v76 = v72[4];
			//               v70[3] = v75;
			//               v77 = v72[5];
			//               v70[4] = v76;
			//               v78 = v72[6];
			//               v70[5] = v77;
			//               v79 = v72[7];
			//               v72 += 8;
			//               v70[6] = v78;
			//               v70 += 8;
			//               *(v70 - 1) = v79;
			//               --v71;
			//             }
			//             while ( v71 );
			//             v80 = MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Nullable;
			//             *(_QWORD *)v70 = *(_QWORD *)v72;
			//             sub_18064821C(&v140[0].fields, v141, v80);
			//             v81 = v6;
			//             p_fields = &v140[0].fields;
			//             do
			//             {
			//               v83 = *(_OWORD *)&p_fields._._File_k__BackingField;
			//               *(_OWORD *)&v81.hasValue = *(_OWORD *)&p_fields._._Index_k__BackingField;
			//               v84 = *(_OWORD *)&p_fields.fields;
			//               *(_OWORD *)&v81.value.request.rootPosition.z = v83;
			//               v85 = *(_OWORD *)&p_fields._Proto_k__BackingField;
			//               *(_OWORD *)&v81.value.request.rtSize.m_X = v84;
			//               v86 = *(_OWORD *)&p_fields[1]._._Index_k__BackingField;
			//               *(_OWORD *)&v81.value.request.depthBits = v85;
			//               v87 = *(_OWORD *)&p_fields[1]._._File_k__BackingField;
			//               *(_OWORD *)&v81.value.request.includeDynamicObjects = v86;
			//               v88 = *(_OWORD *)&p_fields[1].fields;
			//               *(_OWORD *)&v81.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v87;
			//               v89 = *(_OWORD *)&p_fields[1]._Proto_k__BackingField;
			//               p_fields += 2;
			//               *(_OWORD *)&v81.value.pageCount.m_X = v88;
			//               v81 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v81 + 128);
			//               *(_OWORD *)&v81[-1].value.currRTIndex = v89;
			//               --v30;
			//             }
			//             while ( v30 );
			//             goto LABEL_36;
			//           }
			//         }
			//       }
			//     }
			// LABEL_42:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(778, 0LL);
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v99 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_293(
			//           (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)&v140[0].fields,
			//           Patch,
			//           (Object *)this,
			//           request,
			//           0LL);
			//   v100 = 2LL;
			//   v101 = v6;
			//   do
			//   {
			//     v102 = *(_OWORD *)&v99.value.request.rootPosition.z;
			//     *(_OWORD *)&v101.hasValue = *(_OWORD *)&v99.hasValue;
			//     v103 = *(_OWORD *)&v99.value.request.rtSize.m_X;
			//     *(_OWORD *)&v101.value.request.rootPosition.z = v102;
			//     v104 = *(_OWORD *)&v99.value.request.depthBits;
			//     *(_OWORD *)&v101.value.request.rtSize.m_X = v103;
			//     v105 = *(_OWORD *)&v99.value.request.includeDynamicObjects;
			//     *(_OWORD *)&v101.value.request.depthBits = v104;
			//     v106 = *(_OWORD *)&v99.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
			//     *(_OWORD *)&v101.value.request.includeDynamicObjects = v105;
			//     v107 = *(_OWORD *)&v99.value.pageCount.m_X;
			//     *(_OWORD *)&v101.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v106;
			//     v108 = *(_OWORD *)&v99.value.anchorPosition.x;
			//     v99 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v99 + 128);
			//     *(_OWORD *)&v101.value.pageCount.m_X = v107;
			//     v101 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v101 + 128);
			//     *(_OWORD *)&v101[-1].value.currRTIndex = v108;
			//     --v100;
			//   }
			//   while ( v100 );
			//   *(_OWORD *)&v101.hasValue = *(_OWORD *)&v99.hasValue;
			//   return v6;
			// }
			// 
			return null;
		}

		private CustomDepthOnlyRequestManager.RenderData CreateRenderData(int index, HGRenderGraph renderGraph)
		{
			// // CustomDepthOnlyRequestManager+RenderData CreateRenderData(Int32, HGRenderGraph)
			// CustomDepthOnlyRequestManager_RenderData *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateRenderData(
			//         CustomDepthOnlyRequestManager_RenderData *__return_ptr retstr,
			//         CustomDepthOnlyRequestManager *this,
			//         int32_t index,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   unsigned __int64 v9; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
			//   CustomDepthOnlyRequestManager_SystemData *Item; // r13
			//   __int64 v12; // r12
			//   int v13; // ebx
			//   int v14; // edi
			//   Queue_1_UnityEngine_Vector2_ *invalidPages; // rax
			//   unsigned __int32 v16; // xmm6_4
			//   float x; // xmm2_4
			//   float y; // xmm9_4
			//   WorldSetting_MissionImportanceAndType v19; // rax
			//   __int64 v20; // rax
			//   __int64 v21; // rcx
			//   Vector2Int v22; // rax
			//   MethodInfo *v23; // rdx
			//   Vector2 v24; // rax
			//   Vector2 v25; // r8
			//   Vector2 v26; // r9
			//   Vector2 v27; // rax
			//   float v28; // xmm10_4
			//   float v29; // xmm11_4
			//   float v30; // xmm6_4
			//   MethodInfo *v31; // rdx
			//   float v32; // xmm8_4
			//   Beyond::JobMathf *v33; // rcx
			//   Beyond::JobMathf *v34; // rcx
			//   MethodInfo *v35; // rdx
			//   int v36; // r14d
			//   MethodInfo *v37; // rdx
			//   int v38; // r15d
			//   MethodInfo *v39; // rdx
			//   int v40; // edi
			//   MethodInfo *v41; // rdx
			//   int v42; // esi
			//   int32_t v43; // eax
			//   int32_t m_X; // ebx
			//   int32_t v45; // eax
			//   int32_t m_Y; // edx
			//   int v47; // r11d
			//   int v48; // r8d
			//   int v49; // r9d
			//   int v50; // ecx
			//   int v51; // edx
			//   int v52; // edx
			//   int v53; // r11d
			//   int v54; // eax
			//   float v55; // xmm0_4
			//   int v56; // eax
			//   float v57; // xmm0_4
			//   float v58; // xmm15_4
			//   Matrix4x4 *inverse; // rax
			//   __int128 v60; // xmm10
			//   __int128 v61; // xmm11
			//   __int128 v62; // xmm12
			//   __int128 v63; // xmm13
			//   int v64; // edx
			//   int v65; // r8d
			//   int v66; // r9d
			//   _OWORD *v67; // rax
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   Matrix4x4 *v71; // rax
			//   __int128 v72; // xmm6
			//   __int128 v73; // xmm7
			//   __int128 v74; // xmm8
			//   __int128 v75; // xmm9
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   Matrix4x4 *v80; // rax
			//   __int64 currRTIndex; // rdi
			//   __int128 v82; // xmm12
			//   __int128 v83; // xmm13
			//   __int64 v84; // r14
			//   __int64 v85; // rax
			//   __int64 v86; // rax
			//   HGRenderGraphContext *m_RenderGraphContext; // rsi
			//   CBHandle *v88; // rax
			//   Void *ptr; // xmm10_8
			//   __int128 v90; // xmm11
			//   float v91; // xmm1_4
			//   Matrix4x4 *v92; // rax
			//   __int128 v93; // xmm6
			//   __int128 v94; // xmm7
			//   __int128 v95; // xmm8
			//   __int128 v96; // xmm9
			//   int v97; // edx
			//   int v98; // r8d
			//   int v99; // r9d
			//   _OWORD *v100; // rax
			//   __int128 v101; // xmm1
			//   __int128 v102; // xmm0
			//   __int128 v103; // xmm1
			//   Matrix4x4 *v104; // rax
			//   __int128 v105; // xmm1
			//   __int128 v106; // xmm0
			//   __int128 v107; // xmm1
			//   Matrix4x4 *v108; // rax
			//   __int128 v109; // xmm1
			//   __int128 v110; // xmm0
			//   __int128 v111; // xmm1
			//   Matrix4x4 *v112; // rax
			//   __int128 v113; // xmm1
			//   __int128 v114; // xmm2
			//   __int128 v115; // xmm3
			//   MethodInfo *v116; // rdx
			//   Beyond::JobMathf *v117; // rcx
			//   MethodInfo *v118; // rdx
			//   Beyond::JobMathf *v119; // rcx
			//   __int128 v120; // xmm1
			//   __int128 v121; // xmm1
			//   CBHandle *v122; // rax
			//   Void *v123; // xmm6_8
			//   __int128 v124; // xmm7
			//   RTHandle **v125; // rax
			//   TextureHandle *v126; // rax
			//   RTHandle **v127; // rax
			//   TextureHandle *v128; // rax
			//   TextureHandle v129; // xmm0
			//   float v130; // xmm1_4
			//   float v131; // xmm2_4
			//   __m128i v132; // xmm0
			//   CustomDepthOnlyRequestManager_RenderData *v133; // rcx
			//   __m128i v134; // xmm1
			//   CustomDepthOnlyRequestManager_RenderData *v135; // rax
			//   __int128 v136; // xmm1
			//   __int128 v137; // xmm0
			//   __int128 v138; // xmm1
			//   __int128 v139; // xmm0
			//   __int128 v140; // xmm1
			//   __int128 v141; // xmm0
			//   __int128 v142; // xmm1
			//   __int128 v143; // xmm1
			//   __int128 v144; // xmm0
			//   __int128 v145; // xmm1
			//   CustomDepthOnlyRequestManager_RenderData *v146; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CustomDepthOnlyRequestManager_RenderData *v148; // rax
			//   CustomDepthOnlyRequestManager_RenderData *v149; // rcx
			//   __int64 v150; // r12
			//   __int128 v151; // xmm1
			//   __int128 v152; // xmm0
			//   __int128 v153; // xmm1
			//   __int128 v154; // xmm0
			//   __int128 v155; // xmm1
			//   __int128 v156; // xmm0
			//   __int128 v157; // xmm1
			//   __int128 v158; // xmm1
			//   __int128 v159; // xmm0
			//   __int128 v160; // xmm1
			//   int v161; // [rsp+38h] [rbp-D0h]
			//   float v162; // [rsp+38h] [rbp-D0h]
			//   Vector2 result; // [rsp+40h] [rbp-C8h] BYREF
			//   float v164; // [rsp+48h] [rbp-C0h]
			//   Vector4 v165; // [rsp+58h] [rbp-B0h] BYREF
			//   float v166; // [rsp+68h] [rbp-A0h]
			//   float v167; // [rsp+6Ch] [rbp-9Ch]
			//   float v168; // [rsp+70h] [rbp-98h]
			//   float v169; // [rsp+74h] [rbp-94h]
			//   float v170; // [rsp+78h] [rbp-90h]
			//   float v171; // [rsp+7Ch] [rbp-8Ch]
			//   float v172; // [rsp+80h] [rbp-88h]
			//   Vector2 v173; // [rsp+88h] [rbp-80h]
			//   Matrix4x4 source; // [rsp+98h] [rbp-70h] BYREF
			//   CBHandle v175; // [rsp+D8h] [rbp-30h] BYREF
			//   __int64 v176; // [rsp+F8h] [rbp-10h]
			//   Matrix4x4 v177; // [rsp+108h] [rbp+0h] BYREF
			//   __m128i si128; // [rsp+148h] [rbp+40h] BYREF
			//   TextureHandle v179; // [rsp+158h] [rbp+50h] BYREF
			//   Matrix4x4 v180; // [rsp+168h] [rbp+60h] BYREF
			//   Matrix4x4 v181; // [rsp+1A8h] [rbp+A0h] BYREF
			//   Vector4 uvScrollOffset; // [rsp+1E8h] [rbp+E0h]
			//   CustomDepthOnlyRequestManager_RenderData v183; // [rsp+1F8h] [rbp+F0h] BYREF
			//   Matrix4x4 v184; // [rsp+338h] [rbp+230h]
			//   __int128 v185; // [rsp+378h] [rbp+270h]
			//   Matrix4x4 v186[3]; // [rsp+388h] [rbp+280h] BYREF
			// 
			//   if ( !byte_18D919ECE )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::TryDequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919ECE = 1;
			//   }
			//   sub_1802F01E0(&v177, 0LL, 64LL);
			//   sub_1802F01E0(v186, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1905, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1905, 0LL);
			//     if ( !Patch )
			//       goto LABEL_44;
			//     v148 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_748(
			//              &v183,
			//              Patch,
			//              (Object *)this,
			//              index,
			//              (Object *)renderGraph,
			//              0LL);
			//     v149 = retstr;
			//     v150 = 2LL;
			//     do
			//     {
			//       v151 = *(_OWORD *)&v148.cullingViewProj.m01;
			//       *(_OWORD *)&v149.cullingViewProj.m00 = *(_OWORD *)&v148.cullingViewProj.m00;
			//       v152 = *(_OWORD *)&v148.cullingViewProj.m02;
			//       *(_OWORD *)&v149.cullingViewProj.m01 = v151;
			//       v153 = *(_OWORD *)&v148.cullingViewProj.m03;
			//       *(_OWORD *)&v149.cullingViewProj.m02 = v152;
			//       v154 = *(_OWORD *)&v148.deviceViewProj.m00;
			//       *(_OWORD *)&v149.cullingViewProj.m03 = v153;
			//       v155 = *(_OWORD *)&v148.deviceViewProj.m01;
			//       *(_OWORD *)&v149.deviceViewProj.m00 = v154;
			//       v156 = *(_OWORD *)&v148.deviceViewProj.m02;
			//       *(_OWORD *)&v149.deviceViewProj.m01 = v155;
			//       v157 = *(_OWORD *)&v148.deviceViewProj.m03;
			//       v148 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v148 + 128);
			//       *(_OWORD *)&v149.deviceViewProj.m02 = v156;
			//       v149 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v149 + 128);
			//       *(_OWORD *)&v149[-1].depthRTShaderID = v157;
			//       --v150;
			//     }
			//     while ( v150 );
			//     v158 = *(_OWORD *)&v148.cullingViewProj.m01;
			//     *(_OWORD *)&v149.cullingViewProj.m00 = *(_OWORD *)&v148.cullingViewProj.m00;
			//     v159 = *(_OWORD *)&v148.cullingViewProj.m02;
			//     *(_OWORD *)&v149.cullingViewProj.m01 = v158;
			//     v160 = *(_OWORD *)&v148.cullingViewProj.m03;
			//     v146 = retstr;
			//     *(_OWORD *)&v149.cullingViewProj.m02 = v159;
			//     *(_OWORD *)&v149.cullingViewProj.m03 = v160;
			//   }
			//   else
			//   {
			//     m_systems = this.fields.m_systems;
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//              m_systems,
			//              index,
			//              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     v176 = *(_QWORD *)&Item.currPosition.x;
			//     v12 = 2LL;
			//     v13 = Item.pageCount.m_X / 2;
			//     v164 = *(float *)&v13;
			//     v9 = (unsigned int)(Item.pageCount.m_Y >> 31);
			//     LODWORD(v9) = Item.pageCount.m_Y % 2;
			//     v14 = Item.pageCount.m_Y / 2;
			//     v161 = v14;
			//     result = 0LL;
			//     invalidPages = Item.invalidPages;
			//     if ( !invalidPages )
			//       goto LABEL_44;
			//     if ( invalidPages.fields._size > 0 )
			//     {
			//       v16 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_u32[0];
			//       while ( 1 )
			//       {
			//         m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.invalidPages;
			//         if ( !m_systems )
			//           goto LABEL_44;
			//         if ( !System::Collections::Generic::Queue<UnityEngine::Vector2>::TryDequeue(
			//                 (Queue_1_UnityEngine_Vector2_ *)m_systems,
			//                 &result,
			//                 MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::TryDequeue) )
			//           break;
			//         x = result.x;
			//         if ( (float)v13 > COERCE_FLOAT(COERCE_UNSIGNED_INT((float)Item.rectRootOffset.m_X - result.x) & v16) )
			//         {
			//           y = result.y;
			//           if ( (float)v14 > COERCE_FLOAT(COERCE_UNSIGNED_INT((float)Item.rectRootOffset.m_Y - result.y) & v16) )
			//             goto LABEL_16;
			//         }
			//       }
			//     }
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.pageOrder;
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     v19 = System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::get_Item(
			//             (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)m_systems,
			//             Item.currPage,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::get_Item);
			//     v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_184CE95D4)(*(_QWORD *)&Item.rectRootOffset, v19);
			//     v21 = HIDWORD(*(_QWORD *)&Item.pageCount);
			//     LODWORD(result.x) = (int)*(_QWORD *)&Item.pageCount / 2;
			//     LODWORD(result.y) = (int)v21 / 2;
			//     v173 = result;
			//     v22 = (Vector2Int)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_184CE9634)(v20, result);
			//     v24 = UnityEngine::Vector2Int::op_Implicit(v22, v23);
			//     v27 = sub_1842BE4B8(v24, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u), v25, v26);
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.pageOrder;
			//     result = v27;
			//     x = v27.x;
			//     y = v27.y;
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     v9 = (unsigned int)((Item.currPage + 1) >> 31);
			//     LODWORD(v9) = (Item.currPage + 1) % m_systems.fields._size_k__BackingField;
			//     Item.currPage = v9;
			// LABEL_16:
			//     v28 = (float)(x * Item.frustumPageSize.x) + Item.request.rootPosition.x;
			//     v29 = (float)(y * Item.frustumPageSize.y) + Item.request.rootPosition.z;
			//     v30 = UnityEngine::Mathf::Sign(x, (MethodInfo *)v9);
			//     v32 = UnityEngine::Mathf::Sign(y, v31);
			//     Beyond::JobMathf::Fmod(v33, (float)Item.pageCount.m_X, x);
			//     Beyond::JobMathf::Fmod(v34, (float)Item.pageCount.m_Y, x);
			//     LODWORD(v173.x) = (int)(float)((float)((float)((float)((float)((float)v13 * v30) + x) - (float)((float)v13 * v30))
			//                                          - 0.5)
			//                                  + (float)v13);
			//     v167 = 0.0;
			//     v168 = 0.0;
			//     v171 = 0.0;
			//     v172 = 0.0;
			//     LODWORD(result.x) = (int)(float)((float)((float)((float)((float)((float)v14 * v32) + y) - (float)((float)v14 * v32))
			//                                            - 0.5)
			//                                    + (float)v14);
			//     v36 = (int)UnityEngine::Mathf::Sign((float)Item.rectCurrOffset.m_X, v35);
			//     v38 = (int)UnityEngine::Mathf::Sign((float)Item.rectCurrOffset.m_Y, v37);
			//     v40 = (int)UnityEngine::Mathf::Sign((float)Item.rectRootOffset.m_X, v39);
			//     v42 = (int)UnityEngine::Mathf::Sign((float)Item.rectRootOffset.m_Y, v41);
			//     v43 = sub_1824AD5C0((unsigned int)Item.rectCurrOffset.m_X);
			//     m_X = Item.pageCount.m_X;
			//     if ( v43 < m_X )
			//       m_X = v43;
			//     v45 = sub_1824AD5C0((unsigned int)Item.rectCurrOffset.m_Y);
			//     m_Y = Item.pageCount.m_Y;
			//     if ( v45 < m_Y )
			//       m_Y = v45;
			//     v47 = (Item.rectRootOffset.m_X + v36 * LODWORD(v164) - v36 * m_X + LODWORD(v164) * v40) % Item.pageCount.m_X
			//         - LODWORD(v164) * v40;
			//     v48 = (Item.rectRootOffset.m_X + v36 * LODWORD(v164) + LODWORD(v164) * v40) % Item.pageCount.m_X
			//         - LODWORD(v164) * v40;
			//     v49 = v161 + (Item.rectRootOffset.m_Y + v38 * v161 - v38 * m_Y + v161 * v42) % Item.pageCount.m_Y - v161 * v42;
			//     v50 = v161 + (Item.rectRootOffset.m_Y + v38 * v161 + v161 * v42) % Item.pageCount.m_Y - v161 * v42;
			//     v51 = v48;
			//     if ( v36 >= 0 )
			//       v51 = (Item.rectRootOffset.m_X + v36 * LODWORD(v164) - v36 * m_X + LODWORD(v164) * v40) % Item.pageCount.m_X
			//           - LODWORD(v164) * v40;
			//     v52 = LODWORD(v164) + v51;
			//     if ( v36 >= 0 )
			//       v47 = v48;
			//     v53 = LODWORD(v164) + v47;
			//     if ( v38 < 0 )
			//     {
			//       v54 = v49;
			//       v49 = v161 + (Item.rectRootOffset.m_Y + v38 * v161 + v161 * v42) % Item.pageCount.m_Y - v161 * v42;
			//       v50 = v54;
			//     }
			//     v55 = (float)(Item.request.pageSize.m_X * v52);
			//     v164 = v55;
			//     if ( v52 > v53 )
			//     {
			//       v164 = v55;
			//       v162 = (float)(Item.request.pageSize.m_X * (Item.pageCount.m_X - v52));
			//       v166 = (float)Item.request.rtSize.m_Y;
			//       v167 = (float)(Item.request.pageSize.m_X * v53);
			//       v168 = (float)Item.request.rtSize.m_Y;
			//     }
			//     else
			//     {
			//       v162 = (float)(Item.request.pageSize.m_X * (v53 - v52));
			//       v166 = (float)Item.request.rtSize.m_Y;
			//     }
			//     v56 = Item.request.pageSize.m_Y * v49;
			//     v57 = (float)Item.request.rtSize.m_X;
			//     v169 = v57;
			//     v58 = (float)v56;
			//     if ( v49 > v50 )
			//     {
			//       v169 = v57;
			//       v170 = (float)(Item.request.pageSize.m_Y * (Item.pageCount.m_Y - v49));
			//       v171 = (float)Item.request.rtSize.m_X;
			//       v172 = (float)(Item.request.pageSize.m_Y * v50);
			//     }
			//     else
			//     {
			//       v170 = (float)(Item.request.pageSize.m_Y * (v50 - v49));
			//     }
			//     v165.y = *((float *)&v176 + 1);
			//     v165.x = v28;
			//     v165.z = v29;
			//     v165.w = 1.0;
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//     *(__m128i *)&source.m00 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//     *(__m128i *)&v175.bufferId = _mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//     UnityEngine::Matrix4x4::Matrix4x4(&v177, (Vector4 *)&v175, (Vector4 *)&source, (Vector4 *)&si128, &v165, 0LL);
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v180, &v177, 0LL);
			//     v60 = *(_OWORD *)&inverse.m00;
			//     v61 = *(_OWORD *)&inverse.m01;
			//     v62 = *(_OWORD *)&inverse.m02;
			//     v63 = *(_OWORD *)&inverse.m03;
			//     v67 = (_OWORD *)sub_182A59E70((unsigned int)&v177, v64, v65, v66, Item.request.frustumSize.z * 0.5);
			//     v68 = v67[1];
			//     *(_OWORD *)&source.m00 = *v67;
			//     v69 = v67[2];
			//     *(_OWORD *)&source.m01 = v68;
			//     v70 = v67[3];
			//     *(_OWORD *)&source.m02 = v69;
			//     *(_OWORD *)&source.m03 = v70;
			//     v71 = Unity::Mathematics::float4x4::op_Implicit(&v177, (float4x4 *)&source, 0LL);
			//     *(_OWORD *)&source.m00 = v60;
			//     *(_OWORD *)&source.m01 = v61;
			//     *(_OWORD *)&source.m02 = v62;
			//     v72 = *(_OWORD *)&v71.m00;
			//     v73 = *(_OWORD *)&v71.m01;
			//     v74 = *(_OWORD *)&v71.m02;
			//     v75 = *(_OWORD *)&v71.m03;
			//     *(_OWORD *)&source.m03 = v63;
			//     *(_OWORD *)&v180.m00 = v72;
			//     *(_OWORD *)&v180.m01 = v73;
			//     *(_OWORD *)&v180.m02 = v74;
			//     *(_OWORD *)&v180.m03 = v75;
			//     v184 = *UnityEngine::Matrix4x4::op_Multiply(&v177, &v180, &source, 0LL);
			//     *(_OWORD *)&v180.m00 = v72;
			//     *(_OWORD *)&v180.m01 = v73;
			//     *(_OWORD *)&v180.m02 = v74;
			//     *(_OWORD *)&v180.m03 = v75;
			//     GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v181, &v180, 1, 0LL);
			//     *(_OWORD *)&source.m00 = v60;
			//     *(_OWORD *)&source.m01 = v61;
			//     *(_OWORD *)&source.m02 = v62;
			//     v77 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//     *(_OWORD *)&v177.m00 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//     v78 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//     *(_OWORD *)&v177.m01 = v77;
			//     v79 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//     *(_OWORD *)&v177.m02 = v78;
			//     *(_OWORD *)&v177.m03 = v79;
			//     *(_OWORD *)&source.m03 = v63;
			//     v80 = UnityEngine::Matrix4x4::op_Multiply(&v181, &v177, &source, 0LL);
			//     currRTIndex = Item.currRTIndex;
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.perFrameData;
			//     v82 = *(_OWORD *)&v80.m00;
			//     v83 = *(_OWORD *)&v80.m01;
			//     v185 = *(_OWORD *)&v80.m02;
			//     v9 = (unsigned int)(((int)currRTIndex + 1) >> 31);
			//     LODWORD(v9) = ((int)currRTIndex + 1) % 2;
			//     v179 = *(TextureHandle *)&v80.m03;
			//     v84 = (int)v9;
			//     Item.currRTIndex = v9;
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     v85 = sub_18037A2E0(m_systems, currRTIndex);
			//     source.m30 = 0.0;
			//     *(_QWORD *)&source.m21 = 0LL;
			//     *(_DWORD *)(v85 + 8) = HIDWORD(v176);
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.perFrameData;
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     v86 = sub_18037A2E0(m_systems, currRTIndex);
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.perFrameData;
			//     source.m00 = *(float *)(v86 + 8);
			//     if ( !m_systems )
			//       goto LABEL_44;
			//     source.m10 = *(float *)(sub_18037A2E0(m_systems, v84) + 8);
			//     source.m20 = 1.0 / Item.request.frustumSize.z;
			//     source.m01 = (float)(Item.rectCurrOffset.m_X / Item.request.pageSize.m_X);
			//     v9 = (unsigned int)(Item.rectCurrOffset.m_Y >> 31);
			//     LODWORD(v9) = Item.rectCurrOffset.m_Y % Item.request.pageSize.m_Y;
			//     source.m11 = (float)-(Item.rectCurrOffset.m_Y / Item.request.pageSize.m_Y);
			//     if ( !renderGraph )
			//       goto LABEL_44;
			//     m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       goto LABEL_44;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     v88 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//             &v175,
			//             &m_RenderGraphContext.fields.renderContext,
			//             32,
			//             0LL);
			//     ptr = (Void *)v88.ptr;
			//     v90 = *(_OWORD *)&v88.bufferId;
			//     v175.ptr = ptr;
			//     System::Buffer::MemoryCopy((Void *)&source, ptr, 32LL, 32LL, 0LL);
			//     v91 = Item.currPosition.y;
			//     v165.x = Item.currPosition.x;
			//     v165.z = Item.currPosition.z;
			//     v165.y = v91;
			//     v165.w = 1.0;
			//     *(__m128i *)&source.m00 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//     *(Vector4 *)&v175.bufferId = v165;
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//     v165 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//     UnityEngine::Matrix4x4::Matrix4x4(v186, &v165, (Vector4 *)&si128, (Vector4 *)&source, (Vector4 *)&v175, 0LL);
			//     v92 = UnityEngine::Matrix4x4::get_inverse(&v181, v186, 0LL);
			//     v93 = *(_OWORD *)&v92.m00;
			//     v94 = *(_OWORD *)&v92.m01;
			//     v95 = *(_OWORD *)&v92.m02;
			//     v96 = *(_OWORD *)&v92.m03;
			//     v100 = (_OWORD *)sub_182A59E70((unsigned int)&v181, v97, v98, v99, Item.request.frustumSize.z * 0.5);
			//     v101 = v100[1];
			//     *(_OWORD *)&v177.m00 = *v100;
			//     v102 = v100[2];
			//     *(_OWORD *)&v177.m01 = v101;
			//     v103 = v100[3];
			//     *(_OWORD *)&v177.m02 = v102;
			//     *(_OWORD *)&v177.m03 = v103;
			//     v104 = Unity::Mathematics::float4x4::op_Implicit(&v181, (float4x4 *)&v177, 0LL);
			//     v105 = *(_OWORD *)&v104.m01;
			//     *(_OWORD *)&v177.m00 = *(_OWORD *)&v104.m00;
			//     v106 = *(_OWORD *)&v104.m02;
			//     *(_OWORD *)&v177.m01 = v105;
			//     v107 = *(_OWORD *)&v104.m03;
			//     *(_OWORD *)&v177.m02 = v106;
			//     *(_OWORD *)&v177.m03 = v107;
			//     v108 = UnityEngine::GL::GetGPUProjectionMatrix(&v181, &v177, 1, 0LL);
			//     *(_OWORD *)&v180.m00 = v93;
			//     *(_OWORD *)&v180.m01 = v94;
			//     *(_OWORD *)&v180.m02 = v95;
			//     v109 = *(_OWORD *)&v108.m01;
			//     *(_OWORD *)&source.m00 = *(_OWORD *)&v108.m00;
			//     v110 = *(_OWORD *)&v108.m02;
			//     *(_OWORD *)&source.m01 = v109;
			//     v111 = *(_OWORD *)&v108.m03;
			//     *(_OWORD *)&source.m02 = v110;
			//     *(_OWORD *)&source.m03 = v111;
			//     *(_OWORD *)&v180.m03 = v96;
			//     v112 = UnityEngine::Matrix4x4::op_Multiply(&v181, &source, &v180, 0LL);
			//     v113 = *(_OWORD *)&v112.m01;
			//     v114 = *(_OWORD *)&v112.m02;
			//     v115 = *(_OWORD *)&v112.m03;
			//     *(_OWORD *)&Item.transforms.transform.m00 = *(_OWORD *)&v112.m00;
			//     *(_OWORD *)&Item.transforms.transform.m01 = v113;
			//     *(_OWORD *)&Item.transforms.transform.m02 = v114;
			//     *(_OWORD *)&Item.transforms.transform.m03 = v115;
			//     *(float *)&v115 = (float)Item.rectRootOffset.m_X;
			//     *(float *)&v114 = (float)Item.pageCount.m_X;
			//     *(float *)&v93 = (float)(UnityEngine::Mathf::Sign(*(float *)&v115, v116) * *(float *)&v114) * 0.5;
			//     Beyond::JobMathf::Fmod(v117, *(float *)&v114, *(float *)&v114);
			//     Item.transforms.uvScrollOffset.x = (float)(*(float *)&v93 + *(float *)&v115) - *(float *)&v93;
			//     *(float *)&v115 = (float)Item.rectRootOffset.m_Y;
			//     *(float *)&v114 = (float)Item.pageCount.m_Y;
			//     *(float *)&v93 = (float)(UnityEngine::Mathf::Sign(*(float *)&v115, v118) * *(float *)&v114) * 0.5;
			//     Beyond::JobMathf::Fmod(v119, *(float *)&v114, *(float *)&v114);
			//     Item.transforms.uvScrollOffset.y = (float)(*(float *)&v93 + *(float *)&v115) - *(float *)&v93;
			//     Item.transforms.uvScrollOffset.x = Item.transforms.uvScrollOffset.x / (float)Item.pageCount.m_X;
			//     Item.transforms.uvScrollOffset.y = Item.transforms.uvScrollOffset.y / (float)Item.pageCount.m_Y;
			//     v9 = (unsigned __int64)renderGraph.fields.m_RenderGraphContext;
			//     v120 = *(_OWORD *)&Item.transforms.transform.m01;
			//     *(_OWORD *)&v181.m00 = *(_OWORD *)&Item.transforms.transform.m00;
			//     *(_OWORD *)&v181.m01 = v120;
			//     v121 = *(_OWORD *)&Item.transforms.transform.m03;
			//     *(_OWORD *)&v181.m02 = *(_OWORD *)&Item.transforms.transform.m02;
			//     *(_OWORD *)&v181.m03 = v121;
			//     uvScrollOffset = Item.transforms.uvScrollOffset;
			//     if ( !v9 )
			//       goto LABEL_44;
			//     v122 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//              &v175,
			//              (ScriptableRenderContext *)(v9 + 16),
			//              80,
			//              0LL);
			//     v123 = (Void *)v122.ptr;
			//     v124 = *(_OWORD *)&v122.bufferId;
			//     v175.ptr = v123;
			//     System::Buffer::MemoryCopy((Void *)&v181, v123, 80LL, 80LL, 0LL);
			//     sub_1802F01E0(&v183, 0LL, 320LL);
			//     m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.perFrameData;
			//     *(_OWORD *)&v183.deviceViewProj.m00 = v82;
			//     v183.cullingViewProj = v184;
			//     *(_OWORD *)&v183.deviceViewProj.m01 = v83;
			//     *(_OWORD *)&v183.deviceViewProj.m02 = v185;
			//     *(TextureHandle *)&v183.deviceViewProj.m03 = v179;
			//     if ( !m_systems
			//       || (v125 = (RTHandle **)sub_18037A2E0(m_systems, currRTIndex),
			//           v126 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(&v179, renderGraph, *v125, 0LL),
			//           m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item.perFrameData,
			//           v183.prevDepthOnlyRT = *v126,
			//           !m_systems) )
			//     {
			// LABEL_44:
			//       sub_180B536AC(m_systems, v9);
			//     }
			//     v127 = (RTHandle **)sub_18037A2E0(m_systems, v84);
			//     v128 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(&v179, renderGraph, *v127, 0LL);
			//     v183.clearViewport0.m_YMin = 0.0;
			//     v183.clearViewport1.m_XMin = 0.0;
			//     v129 = *v128;
			//     LODWORD(v128) = Item.request.depthRTShaderID;
			//     v183.clearViewport1.m_YMin = 0.0;
			//     v183.clearViewport2.m_XMin = 0.0;
			//     v183.clearViewport3.m_XMin = 0.0;
			//     v183.clearViewport3.m_YMin = 0.0;
			//     v183.currDepthOnlyRT = v129;
			//     v183.depthRTShaderID = (int)v128;
			//     LODWORD(v128) = Item.request.transformCBShaderID;
			//     v183.clearViewport0.m_XMin = v164;
			//     v183.clearViewport0.m_Height = v166;
			//     v183.clearViewport0.m_Width = v162;
			//     v183.clearViewport1.m_Width = v167;
			//     v183.clearViewport1.m_Height = v168;
			//     v183.clearViewport2.m_Width = v169;
			//     v183.clearViewport2.m_Height = v170;
			//     v183.transformCBShaderID = (int)v128;
			//     LOBYTE(v128) = Item.request.includeDynamicObjects;
			//     v183.clearViewport3.m_Width = v171;
			//     v183.clearViewport2.m_YMin = v58;
			//     v183.clearViewport3.m_Height = v172;
			//     v183.includeDynamicObjects = (char)v128;
			//     v183.isOrthographic = 1;
			//     *(_OWORD *)&v183.transformCB.bufferId = v124;
			//     v183.transformCB.ptr = v123;
			//     *(_OWORD *)&v183.cameraHeightRefreshDataCB.bufferId = v90;
			//     v183.cameraHeightRefreshDataCB.ptr = ptr;
			//     v130 = (float)Item.request.pageSize.m_X;
			//     v131 = (float)Item.request.pageSize.m_Y;
			//     *(float *)&v129.handle.m_Value = (float)(Item.request.pageSize.m_Y * LODWORD(result.x));
			//     v183.pageViewport.m_XMin = (float)(Item.request.pageSize.m_X * LODWORD(v173.x));
			//     LODWORD(v183.pageViewport.m_YMin) = v129.handle.m_Value;
			//     v183.pageViewport.m_Width = v130;
			//     v183.pageViewport.m_Height = v131;
			//     v132 = _mm_cvtsi32_si128(Item.request.rtSize.m_X);
			//     v133 = &v183;
			//     v134 = _mm_cvtsi32_si128(Item.request.rtSize.m_Y);
			//     v183.wholeViewport.m_XMin = 0.0;
			//     v183.wholeViewport.m_YMin = 0.0;
			//     v135 = retstr;
			//     LODWORD(v183.wholeViewport.m_Width) = _mm_cvtepi32_ps(v132).m128_u32[0];
			//     LODWORD(v183.wholeViewport.m_Height) = _mm_cvtepi32_ps(v134).m128_u32[0];
			//     do
			//     {
			//       v136 = *(_OWORD *)&v133.cullingViewProj.m01;
			//       *(_OWORD *)&v135.cullingViewProj.m00 = *(_OWORD *)&v133.cullingViewProj.m00;
			//       v137 = *(_OWORD *)&v133.cullingViewProj.m02;
			//       *(_OWORD *)&v135.cullingViewProj.m01 = v136;
			//       v138 = *(_OWORD *)&v133.cullingViewProj.m03;
			//       *(_OWORD *)&v135.cullingViewProj.m02 = v137;
			//       v139 = *(_OWORD *)&v133.deviceViewProj.m00;
			//       *(_OWORD *)&v135.cullingViewProj.m03 = v138;
			//       v140 = *(_OWORD *)&v133.deviceViewProj.m01;
			//       *(_OWORD *)&v135.deviceViewProj.m00 = v139;
			//       v141 = *(_OWORD *)&v133.deviceViewProj.m02;
			//       *(_OWORD *)&v135.deviceViewProj.m01 = v140;
			//       v142 = *(_OWORD *)&v133.deviceViewProj.m03;
			//       v133 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v133 + 128);
			//       *(_OWORD *)&v135.deviceViewProj.m02 = v141;
			//       v135 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v135 + 128);
			//       *(_OWORD *)&v135[-1].depthRTShaderID = v142;
			//       --v12;
			//     }
			//     while ( v12 );
			//     v143 = *(_OWORD *)&v133.cullingViewProj.m01;
			//     *(_OWORD *)&v135.cullingViewProj.m00 = *(_OWORD *)&v133.cullingViewProj.m00;
			//     v144 = *(_OWORD *)&v133.cullingViewProj.m02;
			//     *(_OWORD *)&v135.cullingViewProj.m01 = v143;
			//     v145 = *(_OWORD *)&v133.cullingViewProj.m03;
			//     *(_OWORD *)&v135.cullingViewProj.m02 = v144;
			//     *(_OWORD *)&v135.cullingViewProj.m03 = v145;
			//     return retstr;
			//   }
			//   return v146;
			// }
			// 
			return default(CustomDepthOnlyRequestManager.RenderData);
		}

		public Nullable<CustomDepthOnlyRequestManager.Handle> RequestCustomDepthOnlyPassV1(ref CustomDepthOnlyRequestManager.Request request)
		{
			// // Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+Handle] RequestCustomDepthOnlyPassV1(CustomDepthOnlyRequestManager+Request ByRef)
			// Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_Handle_ HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RequestCustomDepthOnlyPassV1(
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Request *request,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *p_value; // rcx
			//   int32_t size_k__BackingField; // ebp
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v10; // rax
			//   __int64 v11; // r14
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v19; // rax
			//   CustomDepthOnlyRequestManager_SystemData *Item; // rdi
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   MessageDescriptor *v23; // r9
			//   _OWORD *p_x; // rcx
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v25; // rax
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v33; // rdi
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v34; // rax
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ value; // [rsp+20h] [rbp-238h] BYREF
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ v45; // [rsp+130h] [rbp-128h] BYREF
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_Handle_ v46; // [rsp+278h] [rbp+20h]
			// 
			//   if ( !byte_18D919ECF )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_size);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Handle>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value);
			//     byte_18D919ECF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(777, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(777, 0LL);
			//     if ( !Patch )
			//       goto LABEL_26;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_294(Patch, (Object *)this, request, 0LL);
			//   }
			//   else
			//   {
			//     size_k__BackingField = -1;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_systems = this.fields.m_systems;
			//       if ( !m_systems )
			//         goto LABEL_26;
			//       if ( i >= m_systems.fields._size_k__BackingField )
			//         goto LABEL_10;
			//       if ( !UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//               this.fields.m_systems,
			//               i,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).isValid )
			//         break;
			//     }
			//     size_k__BackingField = i;
			// LABEL_10:
			//     v10 = HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateSystem(&v45, this, request, 0LL);
			//     v11 = 2LL;
			//     p_value = &value;
			//     v5 = 2LL;
			//     do
			//     {
			//       v12 = *(_OWORD *)&v10.value.request.rootPosition.z;
			//       *(_OWORD *)&p_value.hasValue = *(_OWORD *)&v10.hasValue;
			//       v13 = *(_OWORD *)&v10.value.request.rtSize.m_X;
			//       *(_OWORD *)&p_value.value.request.rootPosition.z = v12;
			//       v14 = *(_OWORD *)&v10.value.request.depthBits;
			//       *(_OWORD *)&p_value.value.request.rtSize.m_X = v13;
			//       v15 = *(_OWORD *)&v10.value.request.includeDynamicObjects;
			//       *(_OWORD *)&p_value.value.request.depthBits = v14;
			//       v16 = *(_OWORD *)&v10.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
			//       *(_OWORD *)&p_value.value.request.includeDynamicObjects = v15;
			//       v17 = *(_OWORD *)&v10.value.pageCount.m_X;
			//       *(_OWORD *)&p_value.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v16;
			//       v18 = *(_OWORD *)&v10.value.anchorPosition.x;
			//       v10 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v10 + 128);
			//       *(_OWORD *)&p_value.value.pageCount.m_X = v17;
			//       p_value = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)p_value + 128);
			//       *(_OWORD *)&p_value[-1].value.currRTIndex = v18;
			//       --v5;
			//     }
			//     while ( v5 );
			//     *(_OWORD *)&p_value.hasValue = *(_OWORD *)&v10.hasValue;
			//     if ( value.hasValue )
			//     {
			//       v19 = this.fields.m_systems;
			//       if ( size_k__BackingField == -1 )
			//       {
			//         if ( v19 )
			//         {
			//           size_k__BackingField = v19.fields._size_k__BackingField;
			//           v33 = this.fields.m_systems;
			//           System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value(
			//             (CustomDepthOnlyRequestManager_SystemData *)&v45,
			//             &value,
			//             MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value);
			//           v5 = (__int64)&value;
			//           v34 = &v45;
			//           do
			//           {
			//             v35 = *(_OWORD *)&v34.value.request.rootPosition.z;
			//             *(_OWORD *)v5 = *(_OWORD *)&v34.hasValue;
			//             v36 = *(_OWORD *)&v34.value.request.rtSize.m_X;
			//             *(_OWORD *)(v5 + 16) = v35;
			//             v37 = *(_OWORD *)&v34.value.request.depthBits;
			//             *(_OWORD *)(v5 + 32) = v36;
			//             v38 = *(_OWORD *)&v34.value.request.includeDynamicObjects;
			//             *(_OWORD *)(v5 + 48) = v37;
			//             v39 = *(_OWORD *)&v34.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
			//             *(_OWORD *)(v5 + 64) = v38;
			//             v40 = *(_OWORD *)&v34.value.pageCount.m_X;
			//             *(_OWORD *)(v5 + 80) = v39;
			//             v41 = *(_OWORD *)&v34.value.anchorPosition.x;
			//             v34 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v34 + 128);
			//             *(_OWORD *)(v5 + 96) = v40;
			//             v5 += 128LL;
			//             *(_OWORD *)(v5 - 16) = v41;
			//             --v11;
			//           }
			//           while ( v11 );
			//           *(_QWORD *)v5 = *(_QWORD *)&v34.hasValue;
			//           if ( v33 )
			//           {
			//             UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Add(
			//               v33,
			//               (CustomDepthOnlyRequestManager_SystemData *)&value,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Add);
			// LABEL_23:
			//             *(_DWORD *)&v46.hasValue = 1;
			//             v46.value.index = size_k__BackingField;
			//             return v46;
			//           }
			//         }
			//       }
			//       else if ( v19 )
			//       {
			//         Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//                  this.fields.m_systems,
			//                  size_k__BackingField,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//         System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value(
			//           (CustomDepthOnlyRequestManager_SystemData *)&v45,
			//           &value,
			//           MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value);
			//         p_x = (_OWORD *)&Item.request.rootPosition.x;
			//         v25 = &v45;
			//         do
			//         {
			//           v26 = *(_OWORD *)&v25.value.request.rootPosition.z;
			//           *p_x = *(_OWORD *)&v25.hasValue;
			//           v27 = *(_OWORD *)&v25.value.request.rtSize.m_X;
			//           p_x[1] = v26;
			//           v28 = *(_OWORD *)&v25.value.request.depthBits;
			//           p_x[2] = v27;
			//           v29 = *(_OWORD *)&v25.value.request.includeDynamicObjects;
			//           p_x[3] = v28;
			//           v30 = *(_OWORD *)&v25.value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
			//           p_x[4] = v29;
			//           v31 = *(_OWORD *)&v25.value.pageCount.m_X;
			//           p_x[5] = v30;
			//           v32 = *(_OWORD *)&v25.value.anchorPosition.x;
			//           v25 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v25 + 128);
			//           p_x[6] = v31;
			//           p_x += 8;
			//           *(p_x - 1) = v32;
			//           --v11;
			//         }
			//         while ( v11 );
			//         *(_QWORD *)p_x = *(_QWORD *)&v25.hasValue;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&Item.ringIndices,
			//           v21,
			//           v22,
			//           v23,
			//           *(String__Array **)&value.hasValue,
			//           *(String **)&value.value.request.rootPosition.x,
			//           *(MethodInfo **)&value.value.request.rootPosition.z);
			//         goto LABEL_23;
			//       }
			// LABEL_26:
			//       sub_180B536AC(p_value, v5);
			//     }
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public void RemoveSystem(CustomDepthOnlyRequestManager.Handle handle)
		{
			// // Void RemoveSystem(CustomDepthOnlyRequestManager+Handle)
			// void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Handle handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
			//   CustomDepthOnlyRequestManager_SystemData *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDD1F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     byte_18D8EDD1F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(509, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
			//       return;
			//     --this.fields.m_systemCount;
			//     m_systems = this.fields.m_systems;
			//     if ( m_systems )
			//     {
			//       m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//                                                                                                      m_systems,
			//                                                                                                      handle.index,
			//                                                                                                      MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).perFrameData;
			//       if ( m_systems )
			//       {
			//         m_systems = *(DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ **)sub_18037A2E0(m_systems, 0LL);
			//         if ( m_systems )
			//         {
			//           UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_systems, 0LL);
			//           m_systems = this.fields.m_systems;
			//           if ( m_systems )
			//           {
			//             m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(m_systems, handle.index, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).perFrameData;
			//             if ( m_systems )
			//             {
			//               m_systems = *(DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ **)sub_18037A2E0(m_systems, 1LL);
			//               if ( m_systems )
			//               {
			//                 UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_systems, 0LL);
			//                 m_systems = this.fields.m_systems;
			//                 if ( m_systems )
			//                 {
			//                   Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//                            m_systems,
			//                            handle.index,
			//                            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//                   sub_1802F01E0(Item, 0LL, 264LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(m_systems, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(509, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(Patch, (Object *)this, handle, 0LL);
			// }
			// 
		}

		public bool IsValid(CustomDepthOnlyRequestManager.Handle handle)
		{
			// // Boolean IsValid(CustomDepthOnlyRequestManager+Handle)
			// bool HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Handle handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDD20 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_size);
			//     byte_18D8EDD20 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(510, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(510, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(Patch, (Object *)this, handle, 0LL);
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_systems = this.fields.m_systems;
			//   if ( !m_systems )
			//     goto LABEL_7;
			//   return handle.index < m_systems.fields._size_k__BackingField
			//       && UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//            this.fields.m_systems,
			//            handle.index,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).isValid;
			// }
			// 
			return default(bool);
		}

		public void UpdateSystem(CustomDepthOnlyRequestManager.Handle handle, Vector3 position)
		{
			// // Void UpdateSystem(CustomDepthOnlyRequestManager+Handle, Vector3)
			// void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::UpdateSystem(
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Handle handle,
			//         Vector3 *position,
			//         MethodInfo *method)
			// {
			//   unsigned __int64 ringIndices; // rdx
			//   unsigned __int64 m_systems; // rcx
			//   CustomDepthOnlyRequestManager_SystemData *Item; // rsi
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   int v16; // r12d
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   MethodInfo *v19; // rdx
			//   int v20; // r14d
			//   MethodInfo *v21; // rdx
			//   int v22; // ebp
			//   int v23; // r13d
			//   int v24; // eax
			//   int v25; // r8d
			//   Queue_1_UnityEngine_Vector2_ *invalidPages; // rax
			//   __m128 v27; // xmm7
			//   __m128 v28; // xmm6
			//   float v29; // xmm9_4
			//   int v30; // ebx
			//   int v31; // edi
			//   float v32; // xmm0_4
			//   int v33; // eax
			//   int v34; // ebp
			//   float v35; // xmm10_4
			//   __m128 v36; // xmm8
			//   int m_Y; // r14d
			//   int v38; // r13d
			//   int v39; // r12d
			//   __m128 v40; // xmm1
			//   __m128 v41; // xmm8
			//   int m_X; // r14d
			//   int v43; // r13d
			//   int v44; // r12d
			//   __m128 v45; // xmm0
			//   int32_t v46; // edx
			//   float y; // eax
			//   float z; // eax
			//   int v49; // [rsp+30h] [rbp-B8h]
			//   int v50; // [rsp+34h] [rbp-B4h]
			//   int v51; // [rsp+38h] [rbp-B0h]
			//   int v52; // [rsp+3Ch] [rbp-ACh]
			//   unsigned int v53; // [rsp+40h] [rbp-A8h]
			//   Vector2Int v54; // [rsp+48h] [rbp-A0h]
			//   Vector3 v55; // [rsp+50h] [rbp-98h] BYREF
			//   int v56; // [rsp+60h] [rbp-88h]
			// 
			//   if ( !byte_18D919ED0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::get_Count);
			//     byte_18D919ED0 = 1;
			//   }
			//   *(_QWORD *)&v55.x = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(784, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
			//       return;
			//     m_systems = (unsigned __int64)this.fields.m_systems;
			//     if ( m_systems )
			//     {
			//       if ( UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//              (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)m_systems,
			//              handle.index,
			//              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).paused )
			//         return;
			//       m_systems = (unsigned __int64)this.fields.m_systems;
			//       if ( m_systems )
			//       {
			//         Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//                  (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)m_systems,
			//                  handle.index,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//         LODWORD(v55.x) = sub_1825C6750(v11, v10);
			//         LODWORD(v55.y) = sub_1825C6750(v13, v12);
			//         v16 = sub_1825C6750(v15, v14);
			//         v56 = v16;
			//         v54.m_X = v16;
			//         v54.m_Y = sub_1825C6750(v18, v17);
			//         v20 = (int)UnityEngine::Mathf::Sign((float)SLODWORD(v55.x), v19);
			//         v49 = v20;
			//         v22 = (int)UnityEngine::Mathf::Sign((float)SLODWORD(v55.y), v21);
			//         v50 = v22;
			//         v51 = sub_1824AD5C0(LODWORD(v55.x));
			//         v23 = v51;
			//         v24 = sub_1824AD5C0(LODWORD(v55.y));
			//         ringIndices = (unsigned int)v24;
			//         v53 = v24;
			//         v25 = v24;
			//         if ( v51 > v24 )
			//           v25 = v51;
			//         v52 = v25;
			//         if ( v25 <= 0 )
			//           goto LABEL_44;
			//         m_systems = (unsigned int)Item.pageCount.m_X;
			//         if ( (int)m_systems >= Item.pageCount.m_Y )
			//           m_systems = (unsigned int)Item.pageCount.m_Y;
			//         if ( v25 > (int)(float)((float)(int)m_systems * 0.5) )
			//         {
			//           ringIndices = (unsigned __int64)Item.ringIndices;
			//           if ( ringIndices )
			//           {
			//             v46 = *(_DWORD *)(ringIndices + 24) - v25;
			//             if ( v46 <= 0 )
			//               v46 = 0;
			//             Item.currPage = (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                                         (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)Item.ringIndices,
			//                                         v46,
			//                                         MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//             goto LABEL_44;
			//           }
			//         }
			//         else
			//         {
			//           invalidPages = Item.invalidPages;
			//           if ( invalidPages )
			//           {
			//             if ( (double)invalidPages.fields._size <= (double)(Item.pageCount.m_X * Item.pageCount.m_Y) * 0.7 )
			//             {
			//               v27 = 0LL;
			//               v27.m128_f32[0] = (float)((float)((float)((float)Item.pageCount.m_X * 0.5) - 0.5) * (float)v20)
			//                               + (float)v16;
			//               v28 = 0LL;
			//               v28.m128_f32[0] = (float)((float)((float)((float)Item.pageCount.m_X * 0.5) - 0.5) * (float)v22)
			//                               + (float)v54.m_Y;
			//               v29 = (float)v16 - (float)((float)((float)((float)Item.pageCount.m_X * 0.5) - 0.5) * (float)v20);
			//               v30 = 0;
			//               v31 = v22 * (ringIndices - 1);
			//               v32 = (float)v22;
			//               v33 = v22;
			//               v34 = v20 * (v51 - 1);
			//               v35 = (float)v54.m_Y - (float)((float)((float)((float)Item.pageCount.m_X * 0.5) - 0.5) * v32);
			//               do
			//               {
			//                 if ( v30 < v23 )
			//                 {
			//                   v36 = v27;
			//                   m_Y = v30 + Item.pageCount.m_Y - ringIndices + 1;
			//                   v38 = 0;
			//                   if ( m_Y >= Item.pageCount.m_Y )
			//                     m_Y = Item.pageCount.m_Y;
			//                   if ( m_Y <= 0 )
			//                   {
			//                     v33 = v50;
			//                   }
			//                   else
			//                   {
			//                     v39 = 0;
			//                     do
			//                     {
			//                       m_systems = (unsigned __int64)Item.invalidPages;
			//                       v40 = (__m128)COERCE_UNSIGNED_INT((float)v39);
			//                       v40.m128_f32[0] = v40.m128_f32[0] + v35;
			//                       if ( !m_systems )
			//                         goto LABEL_46;
			//                       v36.m128_f32[0] = v27.m128_f32[0] - (float)v34;
			//                       System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue(
			//                         (Queue_1_UnityEngine_Vector2_ *)m_systems,
			//                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v36, v40),
			//                         MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue);
			//                       v33 = v50;
			//                       ++v38;
			//                       v39 += v50;
			//                     }
			//                     while ( v38 < m_Y );
			//                     v25 = v52;
			//                     ringIndices = v53;
			//                   }
			//                   v23 = v51;
			//                   v20 = v49;
			//                 }
			//                 if ( v30 < (int)ringIndices )
			//                 {
			//                   v41 = v28;
			//                   m_X = v30 + Item.pageCount.m_X - v23 + 1;
			//                   v43 = 0;
			//                   if ( m_X >= Item.pageCount.m_X )
			//                     m_X = Item.pageCount.m_X;
			//                   if ( m_X > 0 )
			//                   {
			//                     v44 = 0;
			//                     do
			//                     {
			//                       m_systems = (unsigned __int64)Item.invalidPages;
			//                       v45 = (__m128)COERCE_UNSIGNED_INT((float)v44);
			//                       v45.m128_f32[0] = v45.m128_f32[0] + v29;
			//                       if ( !m_systems )
			//                         goto LABEL_46;
			//                       v41.m128_f32[0] = v28.m128_f32[0] - (float)v31;
			//                       System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue(
			//                         (Queue_1_UnityEngine_Vector2_ *)m_systems,
			//                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v45, v41),
			//                         MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue);
			//                       v44 += v49;
			//                       ++v43;
			//                     }
			//                     while ( v43 < m_X );
			//                     v25 = v52;
			//                     ringIndices = v53;
			//                   }
			//                   v33 = v50;
			//                   v20 = v49;
			//                 }
			//                 v23 = v51;
			//                 ++v30;
			//                 v34 -= v20;
			//                 v31 -= v33;
			//               }
			//               while ( v30 < v25 );
			//               v16 = v56;
			//               Item.currPage = 0;
			//               goto LABEL_44;
			//             }
			//             m_systems = (unsigned __int64)Item.invalidPages;
			//             Item.currPage = 0;
			//             if ( m_systems )
			//             {
			//               System::Collections::Generic::Queue<Rewired::Platforms::XboxOne::XboxOneInputSource::LnyDTHuLkKGdjkrEtCSrpMBFdXrlA>::Clear(
			//                 (Queue_1_Rewired_Platforms_XboxOne_XboxOneInputSource_LnyDTHuLkKGdjkrEtCSrpMBFdXrlA_ *)m_systems,
			//                 MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Clear);
			// LABEL_44:
			//               Item.currPosition.x = (float)((float)v16 * Item.frustumPageSize.x) + Item.request.rootPosition.x;
			//               y = position.y;
			//               Item.currPosition.z = (float)((float)v54.m_Y * Item.frustumPageSize.y) + Item.request.rootPosition.z;
			//               Item.currPosition.y = y;
			//               Item.rectCurrOffset = *(Vector2Int *)&v55.x;
			//               Item.rectRootOffset = v54;
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_46:
			//     sub_180B536AC(m_systems, ringIndices);
			//   }
			//   m_systems = (unsigned __int64)IFix::WrappersManagerImpl::GetPatch(784, 0LL);
			//   if ( !m_systems )
			//     goto LABEL_46;
			//   z = position.z;
			//   *(_QWORD *)&v55.x = *(_QWORD *)&position.x;
			//   v55.z = z;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_297(
			//     (ILFixDynamicMethodWrapper_2 *)m_systems,
			//     (Object *)this,
			//     handle,
			//     &v55,
			//     0LL);
			// }
			// 
		}

		public void TogglePass(CustomDepthOnlyRequestManager.Handle handle, bool enable)
		{
			// // Void TogglePass(CustomDepthOnlyRequestManager+Handle, Boolean)
			// void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(
			//         CustomDepthOnlyRequestManager *this,
			//         CustomDepthOnlyRequestManager_Handle handle,
			//         bool enable,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919ED1 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     byte_18D919ED1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(783, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
			//       return;
			//     m_systems = this.fields.m_systems;
			//     if ( m_systems )
			//     {
			//       UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//         m_systems,
			//         handle.index,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item).paused = !enable;
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_systems, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_296(Patch, (Object *)this, handle, enable, 0LL);
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Dispose(
			//         CustomDepthOnlyRequestManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   CustomDepthOnlyRequestManager_Handle v5; // ebx
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDD21 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_size);
			//     byte_18D8EDD21 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(536, 0LL) )
			//   {
			//     for ( v5.index = 0; ; ++v5.index )
			//     {
			//       m_systems = this.fields.m_systems;
			//       if ( !m_systems )
			//         break;
			//       if ( v5.index >= m_systems.fields._size_k__BackingField )
			//         return;
			//       HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(this, v5, 0LL);
			//     }
			// LABEL_8:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(536, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal NativeArray<CustomDepthOnlyRequestManager.RenderData> RetrieveAllSystemRenderData(HGRenderGraph renderGraph)
		{
			// // NativeArray`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+RenderData] RetrieveAllSystemRenderData(HGRenderGraph)
			// NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RetrieveAllSystemRenderData(
			//         NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *__return_ptr retstr,
			//         CustomDepthOnlyRequestManager *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Void *v8; // rcx
			//   Void *m_Buffer; // r13
			//   int32_t v10; // ebp
			//   int32_t v11; // edi
			//   __int64 v12; // r12
			//   DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
			//   CustomDepthOnlyRequestManager_SystemData *Item; // rax
			//   __int64 v15; // r14
			//   CustomDepthOnlyRequestManager_RenderData *v16; // rax
			//   _OWORD *v17; // rcx
			//   __int64 v18; // rdx
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   _OWORD *v29; // rax
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v40; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *result; // rax
			//   NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v43; // [rsp+30h] [rbp-2C8h] BYREF
			//   NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v44; // [rsp+40h] [rbp-2B8h] BYREF
			//   _BYTE v45[320]; // [rsp+50h] [rbp-2A8h] BYREF
			//   CustomDepthOnlyRequestManager_RenderData v46; // [rsp+190h] [rbp-168h] BYREF
			// 
			//   if ( !byte_18D919ED2 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_size);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::GetSubArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::NativeArray);
			//     byte_18D919ED2 = 1;
			//   }
			//   v43 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1906, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1906, 0LL);
			//     if ( !Patch )
			// LABEL_17:
			//       sub_180B536AC(v8, v7);
			//     v40 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_749(&v44, Patch, (Object *)this, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::NativeArray(
			//       &v43,
			//       this.fields.m_systemCount,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::NativeArray);
			//     m_Buffer = v43.m_Buffer;
			//     v10 = 0;
			//     v11 = 0;
			//     v12 = 0LL;
			//     while ( 1 )
			//     {
			//       m_systems = this.fields.m_systems;
			//       if ( !m_systems )
			//         goto LABEL_17;
			//       if ( v11 >= m_systems.fields._size_k__BackingField )
			//         break;
			//       Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
			//                this.fields.m_systems,
			//                v11,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
			//       if ( Item.isValid && !Item.paused )
			//       {
			//         v15 = v12;
			//         ++v10;
			//         ++v12;
			//         v16 = HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateRenderData(&v46, this, v11, renderGraph, 0LL);
			//         v17 = v45;
			//         v18 = 2LL;
			//         do
			//         {
			//           v19 = *(_OWORD *)&v16.cullingViewProj.m01;
			//           *v17 = *(_OWORD *)&v16.cullingViewProj.m00;
			//           v20 = *(_OWORD *)&v16.cullingViewProj.m02;
			//           v17[1] = v19;
			//           v21 = *(_OWORD *)&v16.cullingViewProj.m03;
			//           v17[2] = v20;
			//           v22 = *(_OWORD *)&v16.deviceViewProj.m00;
			//           v17[3] = v21;
			//           v23 = *(_OWORD *)&v16.deviceViewProj.m01;
			//           v17[4] = v22;
			//           v24 = *(_OWORD *)&v16.deviceViewProj.m02;
			//           v17[5] = v23;
			//           v25 = *(_OWORD *)&v16.deviceViewProj.m03;
			//           v16 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v16 + 128);
			//           v17[6] = v24;
			//           v17 += 8;
			//           *(v17 - 1) = v25;
			//           --v18;
			//         }
			//         while ( v18 );
			//         v7 = 2LL;
			//         v26 = *(_OWORD *)&v16.cullingViewProj.m01;
			//         *v17 = *(_OWORD *)&v16.cullingViewProj.m00;
			//         v27 = *(_OWORD *)&v16.cullingViewProj.m02;
			//         v17[1] = v26;
			//         v28 = *(_OWORD *)&v16.cullingViewProj.m03;
			//         v29 = v45;
			//         v17[2] = v27;
			//         v17[3] = v28;
			//         v8 = &m_Buffer[320 * v15];
			//         do
			//         {
			//           v30 = v29[1];
			//           *(_OWORD *)v8 = *v29;
			//           v31 = v29[2];
			//           *(_OWORD *)&v8[16] = v30;
			//           v32 = v29[3];
			//           *(_OWORD *)&v8[32] = v31;
			//           v33 = v29[4];
			//           *(_OWORD *)&v8[48] = v32;
			//           v34 = v29[5];
			//           *(_OWORD *)&v8[64] = v33;
			//           v35 = v29[6];
			//           *(_OWORD *)&v8[80] = v34;
			//           v36 = v29[7];
			//           v29 += 8;
			//           *(_OWORD *)&v8[96] = v35;
			//           v8 += 128;
			//           *(_OWORD *)&v8[-16] = v36;
			//           --v7;
			//         }
			//         while ( v7 );
			//         v37 = v29[1];
			//         *(_OWORD *)v8 = *v29;
			//         v38 = v29[2];
			//         *(_OWORD *)&v8[16] = v37;
			//         v39 = v29[3];
			//         *(_OWORD *)&v8[32] = v38;
			//         *(_OWORD *)&v8[48] = v39;
			//       }
			//       ++v11;
			//     }
			//     Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::GetSubArray(
			//       &v44,
			//       &v43,
			//       0,
			//       v10,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::GetSubArray);
			//     v40 = v44;
			//   }
			//   result = retstr;
			//   *retstr = v40;
			//   return result;
			// }
			// 
			return null;
		}

		private DynamicArray<CustomDepthOnlyRequestManager.SystemData> m_systems;

		private int m_systemCount;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct VSMSupport
		{
			public int shaderID;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct OptionalFeatures
		{
			public Nullable<CustomDepthOnlyRequestManager.VSMSupport> vsmSupport;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
		public struct Request
		{
			internal Vector3 rootPosition;

			public Vector3 frustumSize;

			public Vector2Int rtSize;

			public Vector2Int pageSize;

			public DepthBits depthBits;

			public GraphicsFormat format;

			public int depthRTShaderID;

			public int transformCBShaderID;

			public bool includeDynamicObjects;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
		internal struct VSMData
		{
			public TextureHandle vsmRT;

			public int shaderID;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct OptionalData
		{
			public Nullable<CustomDepthOnlyRequestManager.VSMData> vsmData;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct PageInfo
		{
			public Vector2Int pageIndex;

			public bool pageRoundIndex;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		private struct DepthRefreshParams
		{
			public Vector4 params0;

			public Vector4 params1;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
		internal struct Transforms
		{
			public Matrix4x4 transform;

			public Vector4 uvScrollOffset;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PerFrameData
		{
			public RTHandle depthOnlyRT;

			public float cameraHeight;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SystemData
		{
			public CustomDepthOnlyRequestManager.Request request;

			public CustomDepthOnlyRequestManager.OptionalData optionalData;

			public bool isValid;

			public bool paused;

			public Vector2Int pageCount;

			public Vector2 frustumPageSize;

			public Vector2 anchorPosition;

			public List<int> ringIndices;

			public List<Vector2Int> pageOrder;

			public Queue<Vector2> invalidPages;

			public int currPage;

			public Vector3 currPosition;

			public Vector2Int rectCurrOffset;

			public Vector2Int rectRootOffset;

			public CustomDepthOnlyRequestManager.Transforms transforms;

			public int currRTIndex;

			public CustomDepthOnlyRequestManager.PerFrameData[] perFrameData;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 320)]
		internal struct RenderData
		{
			public Matrix4x4 cullingViewProj;

			public Matrix4x4 deviceViewProj;

			public TextureHandle prevDepthOnlyRT;

			public TextureHandle currDepthOnlyRT;

			public CBHandle cameraHeightRefreshDataCB;

			public CBHandle transformCB;

			public Rect clearViewport0;

			public Rect clearViewport1;

			public Rect clearViewport2;

			public Rect clearViewport3;

			public Rect pageViewport;

			public Rect wholeViewport;

			public int depthRTShaderID;

			public int transformCBShaderID;

			public bool includeDynamicObjects;

			public bool isOrthographic;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct Handle
		{
			internal int index;
		}
	}
}
