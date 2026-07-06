using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Tools
{
	public class HGDrawCallDetailDumper
	{
		public HGDrawCallDetailDumper()
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

		private static HGDrawCallDetailDumper.ParsedDrawCallTableContents ParseDrawCallContents(HGDrawCallDetailedStats[] stats, [MetadataOffset(Offset = "0x01F909D9")] bool sortByTriangleCount = false)
		{
			// // HGDrawCallDetailDumper+ParsedDrawCallTableContents ParseDrawCallContents(HGDrawCallDetailedStats[], Boolean)
			// HGDrawCallDetailDumper_ParsedDrawCallTableContents *HG::Rendering::Tools::HGDrawCallDetailDumper::ParseDrawCallContents(
			//         HGDrawCallDetailDumper_ParsedDrawCallTableContents *__return_ptr retstr,
			//         HGDrawCallDetailedStats__Array *stats,
			//         bool sortByTriangleCount,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   int32_t v11; // r12d
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v12; // rdx
			//   Bounds *v13; // r8
			//   Object__Array *v14; // r9
			//   HGDrawCallDetailDumper_DrawCallRowContent__Array *v15; // r15
			//   int32_t i; // r14d
			//   int v17; // ebx
			//   int32_t j; // ebx
			//   HGDrawCallDetailDumper_DrawCallRowContent *RowContent; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   Comparison_1_HG_Rendering_Tools_HGDrawCallDetailDumper_DrawCallRowContent_ *_9__4_0; // rbx
			//   Object *v25; // rdi
			//   Comparison_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v26; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v27; // rdx
			//   Bounds *v28; // r8
			//   Object__Array *v29; // r9
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents v30; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents *result; // rax
			//   MethodInfo *v33; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v34; // [rsp+30h] [rbp-D8h]
			//   BSP v35; // [rsp+38h] [rbp-D0h] BYREF
			//   _OWORD v36[5]; // [rsp+88h] [rbp-80h] BYREF
			//   HGDrawCallDetailDumper_DrawCallRowContent v37; // [rsp+D8h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919302 )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::CollectionExtensions::Sort<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_ParseDrawCallContents_b__4_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//     byte_18D919302 = 1;
			//   }
			//   *(_OWORD *)&v35.klass = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(7, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(7, 0LL);
			//     if ( Patch )
			//     {
			//       v30 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9(
			//                (HGDrawCallDetailDumper_ParsedDrawCallTableContents *)&v35.fields,
			//                Patch,
			//                (Object *)stats,
			//                sortByTriangleCount,
			//                0LL);
			//       goto LABEL_21;
			//     }
			//     goto LABEL_19;
			//   }
			//   if ( !stats )
			//     goto LABEL_19;
			//   v11 = 0;
			//   v15 = (HGDrawCallDetailDumper_DrawCallRowContent__Array *)il2cpp_array_new_specific_0(
			//                                                               TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent,
			//                                                               (unsigned int)stats.max_length.size,
			//                                                               v9,
			//                                                               v10);
			//   for ( i = 0; i < stats.max_length.size; ++i )
			//   {
			//     v17 = *(_DWORD *)(sub_18041CE18(stats, i) + 8);
			//     v11 += *(_DWORD *)(sub_18041CE18(stats, i) + 12) * v17;
			//   }
			//   for ( j = 0; j < stats.max_length.size; ++j )
			//   {
			//     sub_18041FE3C(stats, &v35.fields, j);
			//     sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//     *(_OWORD *)&v35.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v35.fields._createDescription;
			//     *(_OWORD *)&v35.fields._Bounds_k__BackingField.value.m_Extents.x = *(_OWORD *)&v35.fields.root;
			//     RowContent = HG::Rendering::Tools::HGDrawCallDetailDumper::GetRowContent(
			//                    &v37,
			//                    j,
			//                    v11,
			//                    (HGDrawCallDetailedStats *)&v35.fields._Bounds_k__BackingField,
			//                    0LL);
			//     if ( !v15 )
			//       goto LABEL_19;
			//     v20 = *(_OWORD *)&RowContent.triangleCount;
			//     v36[0] = *(_OWORD *)&RowContent.drawCallIndex;
			//     v21 = *(_OWORD *)&RowContent.shaderName;
			//     v36[1] = v20;
			//     v22 = *(_OWORD *)&RowContent.assetPath;
			//     v36[2] = v21;
			//     v23 = *(_OWORD *)&RowContent.vertKeywordNames;
			//     v36[3] = v22;
			//     v36[4] = v23;
			//     sub_180614D74(v15, j, v36);
			//   }
			//   if ( !sortByTriangleCount )
			//     goto LABEL_17;
			//   sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//   _9__4_0 = TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__4_0;
			//   if ( !_9__4_0 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//     v25 = (Object *)TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9;
			//     v26 = (Comparison_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
			//     _9__4_0 = (Comparison_1_HG_Rendering_Tools_HGDrawCallDetailDumper_DrawCallRowContent_ *)v26;
			//     if ( v26 )
			//     {
			//       System::Comparison<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::Comparison(
			//         v26,
			//         v25,
			//         MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_ParseDrawCallContents_b__4_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__4_0 = _9__4_0;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__4_0,
			//         v27,
			//         v28,
			//         v29,
			//         v33,
			//         v34);
			//       goto LABEL_16;
			//     }
			// LABEL_19:
			//     sub_180B536AC(v8, v7);
			//   }
			// LABEL_16:
			//   Beyond::CollectionExtensions::Sort<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>(
			//     v15,
			//     _9__4_0,
			//     MethodInfo::Beyond::CollectionExtensions::Sort<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
			// LABEL_17:
			//   v35.klass = (BSP__Class *)v15;
			//   sub_1800054D0(&v35, v12, v13, v14, v33, v34);
			//   LODWORD(v35.monitor) = v11;
			//   v30 = *(HGDrawCallDetailDumper_ParsedDrawCallTableContents *)&v35.klass;
			// LABEL_21:
			//   result = retstr;
			//   *retstr = v30;
			//   return result;
			// }
			// 
			return default(HGDrawCallDetailDumper.ParsedDrawCallTableContents);
		}

		private static HGDrawCallDetailDumper.DrawCallRowContent GetRowContent(int drawCallIndex, int totalTriCount, HGDrawCallDetailedStats stats)
		{
			// // HGDrawCallDetailDumper+DrawCallRowContent GetRowContent(Int32, Int32, HGDrawCallDetailedStats)
			// HGDrawCallDetailDumper_DrawCallRowContent *HG::Rendering::Tools::HGDrawCallDetailDumper::GetRowContent(
			//         HGDrawCallDetailDumper_DrawCallRowContent *__return_ptr retstr,
			//         int32_t drawCallIndex,
			//         int32_t totalTriCount,
			//         HGDrawCallDetailedStats *stats,
			//         MethodInfo *method)
			// {
			//   String *name; // r15
			//   String *v10; // r13
			//   __int64 v11; // rcx
			//   Object_1 *v12; // r14
			//   Object_1 *v13; // rcx
			//   Object_1 *v14; // rsi
			//   Object_1 *v15; // rcx
			//   Object_1 *v16; // r12
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v17; // rdx
			//   __int64 v18; // rcx
			//   Object_1 *v19; // rcx
			//   Bounds *v20; // r8
			//   Object__Array *v21; // r9
			//   __int64 v22; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v23; // rdx
			//   Bounds *v24; // r8
			//   Object__Array *v25; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v26; // rdx
			//   Bounds *v27; // r8
			//   Object__Array *v28; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v29; // rdx
			//   Bounds *v30; // r8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v31; // rdx
			//   Bounds *v32; // r8
			//   Object__Array *v33; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v34; // rdx
			//   Bounds *v35; // r8
			//   Object__Array *v36; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v37; // rdx
			//   Bounds *v38; // r8
			//   __int64 v39; // r9
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v45; // xmm1
			//   HGDrawCallDetailDumper_DrawCallRowContent *v46; // rax
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   HGDrawCallDetailDumper_DrawCallRowContent *result; // rax
			//   MethodInfo *v50; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v51; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v52; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v53; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v54; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v55; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v56; // [rsp+28h] [rbp-C1h]
			//   MethodInfo *v57; // [rsp+30h] [rbp-B9h]
			//   HGDrawCallDetailedStats v58; // [rsp+38h] [rbp-B1h] BYREF
			//   __int128 v59; // [rsp+58h] [rbp-91h] BYREF
			//   __int128 v60; // [rsp+68h] [rbp-81h]
			//   BSP v61[2]; // [rsp+78h] [rbp-71h] BYREF
			// 
			//   if ( !byte_18D919303 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Shader);
			//     sub_18003C530(&off_18C9262E0);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919303 = 1;
			//   }
			//   sub_1802F01E0(&v59, 0LL, 80LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(8, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(8, 0LL);
			//     if ( Patch )
			//     {
			//       v45 = *(_OWORD *)&stats.shaderInstanceID;
			//       *(_OWORD *)&v58.componentInstanceID = *(_OWORD *)&stats.componentInstanceID;
			//       *(_OWORD *)&v58.shaderInstanceID = v45;
			//       v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//               (HGDrawCallDetailDumper_DrawCallRowContent *)&v61[0].fields._Bounds_k__BackingField.value.m_Center.y,
			//               Patch,
			//               drawCallIndex,
			//               totalTriCount,
			//               &v58,
			//               0LL);
			//       v47 = *(_OWORD *)&v46.triangleCount;
			//       *(_OWORD *)&retstr.drawCallIndex = *(_OWORD *)&v46.drawCallIndex;
			//       v48 = *(_OWORD *)&v46.shaderName;
			//       *(_OWORD *)&retstr.triangleCount = v47;
			//       v42 = *(_OWORD *)&v46.assetPath;
			//       *(_OWORD *)&retstr.shaderName = v48;
			//       v43 = *(_OWORD *)&v46.vertKeywordNames;
			//       goto LABEL_30;
			//     }
			//     goto LABEL_28;
			//   }
			//   name = (String *)"Unknown";
			//   v10 = (String *)"Unknown";
			//   v11 = HIDWORD(*(_QWORD *)&stats.componentInstanceID);
			//   *(_QWORD *)&v61[0].fields._Bounds_k__BackingField.hasValue = "";
			//   v12 = 0LL;
			//   v13 = UnityEngine::Resources::InstanceIDToObject(v11, 0LL);
			//   if ( v13 && (struct Mesh__Class *)v13.klass == TypeInfo::UnityEngine::Mesh )
			//     v12 = v13;
			//   v14 = 0LL;
			//   v15 = UnityEngine::Resources::InstanceIDToObject(stats.shaderInstanceID, 0LL);
			//   if ( v15 && (struct Shader__Class *)v15.klass == TypeInfo::UnityEngine::Shader )
			//     v14 = v15;
			//   v16 = UnityEngine::Resources::InstanceIDToObject(stats.componentInstanceID, 0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Inequality(v12, 0LL, 0LL) )
			//   {
			//     if ( !v12 )
			//       goto LABEL_28;
			//     v19 = v12;
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(v16, 0LL, 0LL) )
			//       goto LABEL_17;
			//     if ( !v16 )
			//       goto LABEL_28;
			//     v19 = v16;
			//   }
			//   name = UnityEngine::Object::get_name(v19, 0LL);
			// LABEL_17:
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(v14, 0LL, 0LL) )
			//     goto LABEL_20;
			//   if ( !v14 )
			// LABEL_28:
			//     sub_180B536AC(v18, v17);
			//   v10 = UnityEngine::Object::get_name(v14, 0LL);
			// LABEL_20:
			//   LODWORD(v59) = drawCallIndex;
			//   *((_QWORD *)&v59 + 1) = name;
			//   sub_1800054D0((BSP *)((char *)&v59 + 8), v17, v20, v21, v50, v57);
			//   v22 = *(_QWORD *)&stats.triCount;
			//   *(_QWORD *)&v60 = __PAIR64__(HIDWORD(v22), _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&stats.triCount)));
			//   LODWORD(v22) = stats.triCount * HIDWORD(v22);
			//   v61[0].klass = (BSP__Class *)v10;
			//   DWORD2(v60) = v22;
			//   *((float *)&v60 + 3) = (float)(int)v22 / (float)totalTriCount;
			//   sub_1800054D0(v61, v23, v24, v25, v51, v57);
			//   v61[0].monitor = (MonitorData *)UnityEngine::HyperGryph::HGFastString::IndexToString(
			//                                     HIDWORD(*(_QWORD *)&stats.shaderInstanceID),
			//                                     0LL);
			//   sub_1800054D0((BSP *)&v61[0].monitor, v26, v27, v28, v52, v57);
			//   *(_QWORD *)&v61[0].fields._createDescription = "Unknown";
			//   sub_1800054D0((BSP *)&v61[0].fields, v29, v30, (Object__Array *)"Unknown", v53, v57);
			//   v61[0].fields.root = (Node_2 *)UnityEngine::HyperGryph::HGFastString::IndexToString(stats.passVertKeywordsID, 0LL);
			//   sub_1800054D0((BSP *)&v61[0].fields.root, v31, v32, v33, v54, v57);
			//   v61[0].fields.OnChange = (Action *)UnityEngine::HyperGryph::HGFastString::IndexToString(
			//                                        HIDWORD(*(_QWORD *)&stats.passVertKeywordsID),
			//                                        0LL);
			//   sub_1800054D0((BSP *)&v61[0].fields.OnChange, v34, v35, v36, v55, v57);
			//   v39 = 0xFFFFFFFFLL;
			//   if ( stats.passVertKeywordsID == -1 && HIDWORD(*(_QWORD *)&stats.passVertKeywordsID) != -1 )
			//   {
			//     v61[0].fields.root = (Node_2 *)v61[0].fields.OnChange;
			//     sub_1800054D0((BSP *)&v61[0].fields.root, v37, v38, (Object__Array *)0xFFFFFFFFLL, v56, v57);
			//   }
			//   if ( HIDWORD(*(_QWORD *)&stats.passVertKeywordsID) == (_DWORD)v39 && stats.passVertKeywordsID != -1 )
			//   {
			//     v61[0].fields.OnChange = (Action *)v61[0].fields.root;
			//     sub_1800054D0((BSP *)&v61[0].fields.OnChange, v37, v38, (Object__Array *)v39, v56, v57);
			//   }
			//   v61[0].fields.description = *(Object__Array **)&v61[0].fields._Bounds_k__BackingField.hasValue;
			//   sub_1800054D0((BSP *)&v61[0].fields.description, v37, v38, (Object__Array *)v39, v56, v57);
			//   v40 = v60;
			//   *(_OWORD *)&retstr.drawCallIndex = v59;
			//   v41 = *(_OWORD *)&v61[0].klass;
			//   *(_OWORD *)&retstr.triangleCount = v40;
			//   v42 = *(_OWORD *)&v61[0].fields._createDescription;
			//   *(_OWORD *)&retstr.shaderName = v41;
			//   v43 = *(_OWORD *)&v61[0].fields.root;
			// LABEL_30:
			//   result = retstr;
			//   *(_OWORD *)&retstr.assetPath = v42;
			//   *(_OWORD *)&retstr.vertKeywordNames = v43;
			//   return result;
			// }
			// 
			return default(HGDrawCallDetailDumper.DrawCallRowContent);
		}

		public static Task<HGDrawCallDetailedStats[]> FetchRawDrawCallDetails()
		{
			// // Task`1[UnityEngine.HyperGryph.HGDrawCallDetailedStats[]] FetchRawDrawCallDetails()
			// Task_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *HG::Rendering::Tools::HGDrawCallDetailDumper::FetchRawDrawCallDetails(
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v1; // rdx
			//   Bounds *v2; // r8
			//   Object__Array *v3; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   MethodInfo *v8; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v9; // [rsp+28h] [rbp-40h]
			//   HGDrawCallDetailDumper_FetchRawDrawCallDetails_d_6 stateMachine; // [rsp+38h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919304 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Create);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Start<HG::Rendering::Tools::HGDrawCallDetailDumper::_FetchRawDrawCallDetails_d__6>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::get_Task);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//     byte_18D919304 = 1;
			//   }
			//   *(_QWORD *)&stateMachine.__1__state = 0LL;
			//   stateMachine.__u__1.m_task = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(14, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(14, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//     memset(&stateMachine.__t__builder, 0, sizeof(stateMachine.__t__builder));
			//     sub_1800054D0((BSP *)&stateMachine.__t__builder, v1, v2, v3, v8, v9);
			//     stateMachine.__1__state = -1;
			//     System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::Start<HG::Rendering::Tools::HGDrawCallDetailDumper::_FetchRawDrawCallDetails_d__6>(
			//       (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
			//       &stateMachine,
			//       MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Start<HG::Rendering::Tools::HGDrawCallDetailDumper::_FetchRawDrawCallDetails_d__6>);
			//     return (Task_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *)System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::get_Task(
			//                                                                        (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
			//                                                                        MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::get_Task);
			//   }
			// }
			// 
			return null;
		}

		public static HGDrawCallDetailDumper.ParsedDrawCallTableContents FetchDrawCallContents(HGDrawCallDetailedStats[] rawStats, [MetadataOffset(Offset = "0x01F909DA")] bool ignoreTerrain = true, [MetadataOffset(Offset = "0x01F909DB")] bool gbufferOnly = true)
		{
			// // HGDrawCallDetailDumper+ParsedDrawCallTableContents FetchDrawCallContents(HGDrawCallDetailedStats[], Boolean, Boolean)
			// HGDrawCallDetailDumper_ParsedDrawCallTableContents *HG::Rendering::Tools::HGDrawCallDetailDumper::FetchDrawCallContents(
			//         HGDrawCallDetailDumper_ParsedDrawCallTableContents *__return_ptr retstr,
			//         HGDrawCallDetailedStats__Array *rawStats,
			//         bool ignoreTerrain,
			//         bool gbufferOnly,
			//         MethodInfo *method)
			// {
			//   Func_2_UnityEngine_HyperGryph_HGDrawCallDetailedStats_Boolean_ *_9__7_0; // rbx
			//   Object *v10; // r14
			//   Predicate_1_Beyond_Gameplay_RemoteFactory_MapVoxelPointInfo_ *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   IEnumerable_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *v17; // rax
			//   Func_2_UnityEngine_HyperGryph_HGDrawCallDetailedStats_Boolean_ *_9__7_1; // rbx
			//   Object *v19; // rbp
			//   Predicate_1_Beyond_Gameplay_RemoteFactory_MapVoxelPointInfo_ *v20; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v21; // rdx
			//   Bounds *v22; // r8
			//   Object__Array *v23; // r9
			//   IEnumerable_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *v24; // rax
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents *v25; // rax
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents v26; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents *result; // rax
			//   MethodInfo *v29; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v30; // [rsp+28h] [rbp-20h]
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents v31; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919305 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Where<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//     sub_18003C530(&TypeInfo::System::Func<UnityEngine::HyperGryph::HGDrawCallDetailedStats,bool>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_FetchDrawCallContents_b__7_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_FetchDrawCallContents_b__7_1);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//     byte_18D919305 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(17, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(17, 0LL);
			//     if ( Patch )
			//     {
			//       v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_12(
			//               &v31,
			//               Patch,
			//               (Object *)rawStats,
			//               ignoreTerrain,
			//               gbufferOnly,
			//               0LL);
			//       goto LABEL_20;
			//     }
			//     goto LABEL_18;
			//   }
			//   if ( rawStats )
			//   {
			//     if ( ignoreTerrain )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//       _9__7_0 = TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_0;
			//       if ( !_9__7_0 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//         v10 = (Object *)TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9;
			//         v11 = (Predicate_1_Beyond_Gameplay_RemoteFactory_MapVoxelPointInfo_ *)sub_180004920(TypeInfo::System::Func<UnityEngine::HyperGryph::HGDrawCallDetailedStats,bool>);
			//         _9__7_0 = (Func_2_UnityEngine_HyperGryph_HGDrawCallDetailedStats_Boolean_ *)v11;
			//         if ( !v11 )
			//           goto LABEL_18;
			//         System::Predicate<Beyond::Gameplay::RemoteFactory::MapVoxelPointInfo>::Predicate(
			//           v11,
			//           v10,
			//           MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_FetchDrawCallContents_b__7_0,
			//           0LL);
			//         TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_0 = _9__7_0;
			//         sub_1800054D0(
			//           (BSP *)&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_0,
			//           v14,
			//           v15,
			//           v16,
			//           v29,
			//           v30);
			//       }
			//       v17 = System::Linq::Enumerable::Where<UnityEngine::HyperGryph::HGDrawCallDetailedStats>(
			//               (IEnumerable_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *)rawStats,
			//               _9__7_0,
			//               MethodInfo::System::Linq::Enumerable::Where<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//       rawStats = System::Linq::Enumerable::ToArray<UnityEngine::HyperGryph::HGDrawCallDetailedStats>(
			//                    v17,
			//                    MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//     }
			//     if ( !gbufferOnly )
			//     {
			// LABEL_15:
			//       sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//       v25 = HG::Rendering::Tools::HGDrawCallDetailDumper::ParseDrawCallContents(&v31, rawStats, 0, 0LL);
			// LABEL_20:
			//       v26 = *v25;
			//       goto LABEL_21;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//     _9__7_1 = TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_1;
			//     if ( _9__7_1 )
			//     {
			// LABEL_14:
			//       v24 = System::Linq::Enumerable::Where<UnityEngine::HyperGryph::HGDrawCallDetailedStats>(
			//               (IEnumerable_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *)rawStats,
			//               _9__7_1,
			//               MethodInfo::System::Linq::Enumerable::Where<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//       rawStats = System::Linq::Enumerable::ToArray<UnityEngine::HyperGryph::HGDrawCallDetailedStats>(
			//                    v24,
			//                    MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::HyperGryph::HGDrawCallDetailedStats>);
			//       goto LABEL_15;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
			//     v19 = (Object *)TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9;
			//     v20 = (Predicate_1_Beyond_Gameplay_RemoteFactory_MapVoxelPointInfo_ *)sub_180004920(TypeInfo::System::Func<UnityEngine::HyperGryph::HGDrawCallDetailedStats,bool>);
			//     _9__7_1 = (Func_2_UnityEngine_HyperGryph_HGDrawCallDetailedStats_Boolean_ *)v20;
			//     if ( v20 )
			//     {
			//       System::Predicate<Beyond::Gameplay::RemoteFactory::MapVoxelPointInfo>::Predicate(
			//         v20,
			//         v19,
			//         MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_FetchDrawCallContents_b__7_1,
			//         0LL);
			//       TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_1 = _9__7_1;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c.static_fields.__9__7_1,
			//         v21,
			//         v22,
			//         v23,
			//         v29,
			//         v30);
			//       goto LABEL_14;
			//     }
			// LABEL_18:
			//     sub_180B536AC(v13, v12);
			//   }
			//   v26 = 0LL;
			// LABEL_21:
			//   result = retstr;
			//   *retstr = v26;
			//   return result;
			// }
			// 
			return default(HGDrawCallDetailDumper.ParsedDrawCallTableContents);
		}

		public static void DumpCurrentDrawCallStatsToCSV(HGDrawCallDetailedStats[] rawStats, string filePath)
		{
			// // Void DumpCurrentDrawCallStatsToCSV(HGDrawCallDetailedStats[], String)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Tools::HGDrawCallDetailDumper::DumpCurrentDrawCallStatsToCSV(
			//         HGDrawCallDetailedStats__Array *rawStats,
			//         String *filePath,
			//         MethodInfo *method)
			// {
			//   StreamWriter *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   StreamWriter *v8; // rbx
			//   String *v9; // rax
			//   __int64 v10; // rcx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   int32_t v14; // esi
			//   HGDrawCallDetailDumper_DrawCallRowContent__Array *rowContents; // r14
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   String__Array *v18; // rbx
			//   __int64 v19; // r8
			//   Object *v20; // rax
			//   String *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   float v24; // rdi^4
			//   __int64 v25; // r8
			//   Object *v26; // rax
			//   String *v27; // rax
			//   __int64 v28; // r8
			//   Object *v29; // rax
			//   String *v30; // rax
			//   __int64 v31; // r8
			//   Object *v32; // rax
			//   String *v33; // rax
			//   __int64 v34; // r8
			//   Object *v35; // rax
			//   String *v36; // rax
			//   String *v37; // rax
			//   __int64 v38; // rcx
			//   __int64 v39; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   StreamWriter *v43; // [rsp+20h] [rbp-98h] BYREF
			//   _QWORD v44[2]; // [rsp+28h] [rbp-90h] BYREF
			//   HGDrawCallDetailDumper_ParsedDrawCallTableContents v45; // [rsp+38h] [rbp-80h] BYREF
			//   float v46; // [rsp+50h] [rbp-68h] BYREF
			//   __int64 v47; // [rsp+58h] [rbp-60h]
			//   float v48; // [rsp+60h] [rbp-58h]
			//   float v49; // [rsp+64h] [rbp-54h]
			//   float v50; // [rsp+68h] [rbp-50h]
			//   float v51; // [rsp+6Ch] [rbp-4Ch]
			//   __int64 v52; // [rsp+70h] [rbp-48h]
			//   __int64 v53; // [rsp+78h] [rbp-40h]
			//   __int64 v54; // [rsp+80h] [rbp-38h]
			//   __int64 v55; // [rsp+90h] [rbp-28h]
			//   __int64 v56; // [rsp+98h] [rbp-20h]
			//   Il2CppExceptionWrapper *v57; // [rsp+A0h] [rbp-18h] BYREF
			//   float v58; // [rsp+D8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919306 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::System::Single);
			//     sub_18003C530(&TypeInfo::System::IO::StreamWriter);
			//     sub_18003C530(&TypeInfo::System::String);
			//     sub_18003C530(&off_18D584890);
			//     sub_18003C530(&off_18D5848A8);
			//     sub_18003C530(&off_18C8DE380);
			//     sub_18003C530(&off_18D5848A0);
			//     byte_18D919306 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(18, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(18, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v42, v41);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)rawStats,
			//       (Object *)filePath,
			//       0LL);
			//   }
			//   else if ( rawStats )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//     v45 = *HG::Rendering::Tools::HGDrawCallDetailDumper::ParseDrawCallContents(&v45, rawStats, 0, 0LL);
			//     v5 = (StreamWriter *)sub_180004920(TypeInfo::System::IO::StreamWriter);
			//     v8 = v5;
			//     if ( !v5 )
			//       sub_180B536AC(v7, v6);
			//     System::IO::StreamWriter::StreamWriter(v5, filePath, 0LL);
			//     v43 = v8;
			//     v44[0] = 0LL;
			//     v44[1] = &v43;
			//     try
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
			//       v9 = System::String::Join(
			//              0x2Cu,
			//              TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper.static_fields.s_drawCallRowTitles,
			//              0LL);
			//       if ( !v43 )
			//         sub_1802DC2C8(v10, 0LL);
			//       sub_18005E3A0(19LL, v43, v9);
			//       if ( !v43 )
			//         sub_1802DC2C8(v11, 0LL);
			//       sub_180040B30(10LL, v43);
			//       v14 = 0;
			//       rowContents = v45.rowContents;
			//       while ( 1 )
			//       {
			//         if ( !rowContents )
			//           sub_1802DC2C8(v13, v12);
			//         if ( v14 >= rowContents.max_length.size )
			//           break;
			//         sub_18053E2FC(rowContents, &v46, v14);
			//         v18 = (String__Array *)il2cpp_array_new_specific_0(TypeInfo::System::String, 16LL, v16, v17);
			//         v58 = v46;
			//         v20 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v58, v19);
			//         v21 = System::String::Format((String *)"{0},", v20, 0LL);
			//         if ( !v18 )
			//           sub_1802DC2C8(v23, v22);
			//         sub_1800046C0(v18, 0LL, v21);
			//         sub_1800046C0(v18, 1LL, v47);
			//         sub_1800046C0(v18, 2LL, ",");
			//         v24 = v49;
			//         v58 = v48;
			//         v26 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v58, v25);
			//         v27 = System::String::Format((String *)"{0},", v26, 0LL);
			//         sub_1800046C0(v18, 3LL, v27);
			//         v58 = v24;
			//         v29 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v58, v28);
			//         v30 = System::String::Format((String *)"{0},", v29, 0LL);
			//         sub_1800046C0(v18, 4LL, v30);
			//         v58 = v50;
			//         v32 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v58, v31);
			//         v33 = System::String::Format((String *)"{0},", v32, 0LL);
			//         sub_1800046C0(v18, 5LL, v33);
			//         v58 = v51 * 100.0;
			//         v35 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &v58, v34);
			//         v36 = System::String::Format((String *)"{0:F3}%,", v35, 0LL);
			//         sub_1800046C0(v18, 6LL, v36);
			//         sub_1800046C0(v18, 7LL, v52);
			//         sub_1800046C0(v18, 8LL, ",");
			//         sub_1800046C0(v18, 9LL, v53);
			//         sub_1800046C0(v18, 10LL, ",");
			//         sub_1800046C0(v18, 11LL, v54);
			//         sub_1800046C0(v18, 12LL, ",");
			//         sub_1800046C0(v18, 13LL, v55);
			//         sub_1800046C0(v18, 14LL, ",");
			//         sub_1800046C0(v18, 15LL, v56);
			//         v37 = System::String::Concat(v18, 0LL);
			//         if ( !v43 )
			//           sub_1802DC2C8(v38, 0LL);
			//         sub_18005E3A0(19LL, v43, v37);
			//         if ( !v43 )
			//           sub_1802DC2C8(v39, 0LL);
			//         sub_180040B30(10LL, v43);
			//         ++v14;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v57 )
			//     {
			//       v44[0] = v57.ex;
			//     }
			//     sub_1801E4D90(v44);
			//   }
			//   else
			//   {
			//     HG::Rendering::HGRPLogger::LogWarning((String *)"HGDrawCallDetailDumper: Failed to fetch stats!", 0LL);
			//   }
			// }
			// 
		}

		public static HGDrawCallDetailDumper.DrawCallCameraInfo CreateCameraInfo(Camera cam)
		{
			// // HGDrawCallDetailDumper+DrawCallCameraInfo CreateCameraInfo(Camera)
			// HGDrawCallDetailDumper_DrawCallCameraInfo *HG::Rendering::Tools::HGDrawCallDetailDumper::CreateCameraInfo(
			//         HGDrawCallDetailDumper_DrawCallCameraInfo *__return_ptr retstr,
			//         Camera *cam,
			//         MethodInfo *method)
			// {
			//   HGDrawCallDetailDumper_DrawCallCameraInfo *Default; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v8; // rdx
			//   Bounds *v9; // r8
			//   Object__Array *v10; // r9
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   MethodInfo *v15; // rdx
			//   Vector3 *up; // rax
			//   MethodInfo *v17; // xmm3_8
			//   MethodInfo *v18; // rdx
			//   Vector3 *fwd; // rax
			//   MethodInfo *v20; // xmm3_8
			//   MethodInfo *v21; // r8
			//   Vector3 *v22; // rax
			//   MethodInfo *v23; // xmm4_8
			//   Vector3 *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGDrawCallDetailDumper_DrawCallCameraInfo *v29; // rax
			//   __int128 v30; // xmm1
			//   HGDrawCallDetailDumper_DrawCallCameraInfo *result; // rax
			//   MethodInfo *v32; // [rsp+20h] [rbp-89h] BYREF
			//   MethodInfo *v33; // [rsp+28h] [rbp-81h]
			//   Vector3 v34; // [rsp+30h] [rbp-79h] BYREF
			//   BSP v35; // [rsp+40h] [rbp-69h] BYREF
			//   __int128 v36; // [rsp+90h] [rbp-19h]
			//   __int128 v37; // [rsp+A0h] [rbp-9h]
			//   __int128 v38; // [rsp+B0h] [rbp+7h]
			//   Matrix4x4 v39; // [rsp+C0h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919307 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919307 = 1;
			//   }
			//   sub_1802F01E0(&v35, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(19, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(19, 0LL);
			//     if ( Patch )
			//     {
			//       v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
			//               (HGDrawCallDetailDumper_DrawCallCameraInfo *)&v39,
			//               Patch,
			//               (Object *)cam,
			//               0LL);
			//       v30 = *(_OWORD *)&v29.position.z;
			//       *(_OWORD *)&retstr.cameraName = *(_OWORD *)&v29.cameraName;
			//       v26 = *(_OWORD *)&v29.up.x;
			//       *(_OWORD *)&retstr.position.z = v30;
			//       v27 = *(_OWORD *)&v29.farClipDistance;
			//       goto LABEL_11;
			//     }
			//     goto LABEL_9;
			//   }
			//   Default = HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallCameraInfo::CreateDefault(
			//               (HGDrawCallDetailDumper_DrawCallCameraInfo *)&v35.fields._Bounds_k__BackingField.value.m_Extents,
			//               0LL);
			//   *(_OWORD *)&v35.klass = *(_OWORD *)&Default.cameraName;
			//   *(_OWORD *)&v35.fields._createDescription = *(_OWORD *)&Default.position.z;
			//   *(_OWORD *)&v35.fields.root = *(_OWORD *)&Default.up.x;
			//   *(_OWORD *)&v35.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&Default.farClipDistance;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)cam, 0LL, 0LL) )
			//   {
			//     if ( cam )
			//     {
			//       v35.klass = (BSP__Class *)UnityEngine::Object::get_name((Object_1 *)cam, 0LL);
			//       sub_1800054D0(&v35, v8, v9, v10, v32, v33);
			//       HIDWORD(v35.fields.OnChange) = UnityEngine::Camera::get_nearClipPlane(cam, 0LL);
			//       *(_DWORD *)&v35.fields._Bounds_k__BackingField.hasValue = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
			//       v35.fields._Bounds_k__BackingField.value.m_Center.x = UnityEngine::Camera::get_aspect(cam, 0LL);
			//       v35.fields._Bounds_k__BackingField.value.m_Center.y = UnityEngine::Camera::get_fieldOfView(cam, 0LL);
			//       worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v39, cam, 0LL);
			//       v12 = *(_OWORD *)&worldToCameraMatrix.m01;
			//       *(_OWORD *)&v35.fields._Bounds_k__BackingField.value.m_Extents.x = *(_OWORD *)&worldToCameraMatrix.m00;
			//       v13 = *(_OWORD *)&worldToCameraMatrix.m02;
			//       v36 = v12;
			//       v14 = *(_OWORD *)&worldToCameraMatrix.m03;
			//       v37 = v13;
			//       v38 = v14;
			//       *(Vector3 *)&v35.monitor = *UnityEngine::Matrix4x4::GetPosition(
			//                                     (Vector3 *)&v32,
			//                                     (Matrix4x4 *)&v35.fields._Bounds_k__BackingField.value.m_Extents,
			//                                     0LL);
			//       up = UnityEngine::Vector3::get_up(&v34, v15);
			//       v17 = *(MethodInfo **)&up.x;
			//       *(float *)&up = up.z;
			//       v32 = v17;
			//       LODWORD(v33) = (_DWORD)up;
			//       *(Vector3 *)&v35.fields.root = *UnityEngine::Matrix4x4::MultiplyVector(
			//                                         &v34,
			//                                         (Matrix4x4 *)&v35.fields._Bounds_k__BackingField.value.m_Extents,
			//                                         (Vector3 *)&v32,
			//                                         0LL);
			//       fwd = UnityEngine::Vector3::get_fwd(&v34, v18);
			//       v20 = *(MethodInfo **)&fwd.x;
			//       *(float *)&fwd = fwd.z;
			//       v32 = v20;
			//       LODWORD(v33) = (_DWORD)fwd;
			//       v22 = UnityEngine::Vector3::op_UnaryNegation(&v34, (Vector3 *)&v32, v21);
			//       v23 = *(MethodInfo **)&v22.x;
			//       *(float *)&v22 = v22.z;
			//       v32 = v23;
			//       LODWORD(v33) = (_DWORD)v22;
			//       v24 = UnityEngine::Matrix4x4::MultiplyVector(
			//               &v34,
			//               (Matrix4x4 *)&v35.fields._Bounds_k__BackingField.value.m_Extents,
			//               (Vector3 *)&v32,
			//               0LL);
			//       *(_QWORD *)(&v35.fields._createDescription + 4) = *(_QWORD *)&v24.x;
			//       HIDWORD(v35.fields.description) = LODWORD(v24.z);
			//       goto LABEL_7;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			// LABEL_7:
			//   v25 = *(_OWORD *)&v35.fields._createDescription;
			//   *(_OWORD *)&retstr.cameraName = *(_OWORD *)&v35.klass;
			//   v26 = *(_OWORD *)&v35.fields.root;
			//   *(_OWORD *)&retstr.position.z = v25;
			//   v27 = *(_OWORD *)&v35.fields._Bounds_k__BackingField.hasValue;
			// LABEL_11:
			//   *(_OWORD *)&retstr.up.x = v26;
			//   result = retstr;
			//   *(_OWORD *)&retstr.farClipDistance = v27;
			//   return result;
			// }
			// 
			return default(HGDrawCallDetailDumper.DrawCallCameraInfo);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static string[] s_drawCallRowTitles;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct ParsedDrawCallTableContents
		{
			public HGDrawCallDetailDumper.DrawCallRowContent[] rowContents;

			public int totalTriCount;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
		public struct DrawCallRowContent
		{
			public int drawCallIndex;

			public string objectName;

			public int triangleCount;

			public int instanceCount;

			public int totalTriCount;

			public float triCountPercentage;

			public string shaderName;

			public string passName;

			public string assetPath;

			public string assetGuid;

			public string vertKeywordNames;

			public string fragKeywordNames;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		public struct DrawCallCameraInfo
		{
			public static HGDrawCallDetailDumper.DrawCallCameraInfo CreateDefault()
			{
				// // HGDrawCallDetailDumper+DrawCallCameraInfo CreateDefault()
				// HGDrawCallDetailDumper_DrawCallCameraInfo *HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallCameraInfo::CreateDefault(
				//         HGDrawCallDetailDumper_DrawCallCameraInfo *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v3; // rdx
				//   Bounds *v4; // r8
				//   Object__Array *v5; // r9
				//   Animator *v6; // rdx
				//   int32_t v7; // r8d
				//   MethodInfo *v8; // r9
				//   MethodInfo *v9; // rdx
				//   Vector3 *fwd; // rax
				//   MethodInfo *v11; // rdx
				//   Vector3 *up; // rax
				//   __int128 v13; // xmm1
				//   __int128 v14; // xmm0
				//   __int128 v15; // xmm1
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v17; // rdx
				//   __int64 v18; // rcx
				//   HGDrawCallDetailDumper_DrawCallCameraInfo *v19; // rax
				//   __int128 v20; // xmm1
				//   HGDrawCallDetailDumper_DrawCallCameraInfo *result; // rax
				//   BSP v22; // [rsp+20h] [rbp-39h] BYREF
				//   HGDrawCallDetailDumper_DrawCallCameraInfo v23; // [rsp+70h] [rbp+17h] BYREF
				// 
				//   if ( !byte_18D91930A )
				//   {
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D91930A = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(20, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(20, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v18, v17);
				//     v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(&v23, Patch, 0LL);
				//     v20 = *(_OWORD *)&v19.position.z;
				//     *(_OWORD *)&retstr.cameraName = *(_OWORD *)&v19.cameraName;
				//     v14 = *(_OWORD *)&v19.up.x;
				//     *(_OWORD *)&retstr.position.z = v20;
				//     v15 = *(_OWORD *)&v19.farClipDistance;
				//   }
				//   else
				//   {
				//     sub_1802F01E0(&v22, 0LL, 64LL);
				//     v22.klass = (BSP__Class *)"";
				//     ((void (__stdcall *)(BSP *, IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *, Bounds *, Object__Array *))sub_1800054D0)(
				//       &v22,
				//       v3,
				//       v4,
				//       v5);
				//     *(Vector3 *)&v22.monitor = *UnityEngine::Animator::GetVector(
				//                                   &v22.fields._Bounds_k__BackingField.value.m_Extents,
				//                                   v6,
				//                                   v7,
				//                                   v8);
				//     fwd = UnityEngine::Vector3::get_fwd(&v22.fields._Bounds_k__BackingField.value.m_Extents, v9);
				//     *(_QWORD *)(&v22.fields._createDescription + 4) = *(_QWORD *)&fwd.x;
				//     HIDWORD(v22.fields.description) = LODWORD(fwd.z);
				//     up = UnityEngine::Vector3::get_up(&v22.fields._Bounds_k__BackingField.value.m_Extents, v11);
				//     v13 = *(_OWORD *)&v22.fields._createDescription;
				//     *(_OWORD *)&retstr.cameraName = *(_OWORD *)&v22.klass;
				//     *(Vector3 *)&v22.fields.root = *up;
				//     HIDWORD(v22.fields.OnChange) = 1008981770;
				//     v14 = *(_OWORD *)&v22.fields.root;
				//     *(_QWORD *)&v22.fields._Bounds_k__BackingField.hasValue = 0x3FE38E39447A0000LL;
				//     v22.fields._Bounds_k__BackingField.value.m_Center.y = 60.0;
				//     *(_OWORD *)&retstr.position.z = v13;
				//     v15 = *(_OWORD *)&v22.fields._Bounds_k__BackingField.hasValue;
				//   }
				//   *(_OWORD *)&retstr.up.x = v14;
				//   result = retstr;
				//   *(_OWORD *)&retstr.farClipDistance = v15;
				//   return result;
				// }
				// 
				return default(HGDrawCallDetailDumper.DrawCallCameraInfo);
			}

			public string cameraName;

			public Vector3 position;

			public Vector3 direction;

			public Vector3 up;

			public float nearClipDistance;

			public float farClipDistance;

			public float aspect;

			public float verticalFoV;
		}
	}
}
