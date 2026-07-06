using System;

namespace HG.Rendering.Runtime
{
	public class HGCullingManager
	{
		public HGCullingManager()
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

		public static void PrepareCullingParameters(HGCamera hgCamera)
		{
			// // Void PrepareCullingParameters(HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCullingManager::PrepareCullingParameters(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   void (__fastcall *v9)(EntityManager_1 *, MethodInfo *); // rax
			//   EntityManagerRange_Enumerator *Enumerator; // rax
			//   unsigned __int32 v11; // xmm8_4
			//   int v12; // edi
			//   __int64 v13; // r12
			//   __int64 v14; // r13
			//   int v15; // esi
			//   __int64 v16; // r15
			//   __int64 v17; // rbx
			//   EntityTypeInstanceData *v18; // rbx
			//   HGECSRegionComponent *v19; // r15
			//   __int64 v20; // rdx
			//   HGECSRegionComponent *v21; // rcx
			//   HGCullingParameterComponent *v22; // r12
			//   int32_t i; // edi
			//   void (__fastcall *v24)(__int64 *, Quaternion *, __int64 *, EntityManagerRange *, void *, void *); // rax
			//   Matrix4x4 *inverse; // rax
			//   __m128 v26; // xmm10
			//   __m128 v27; // xmm11
			//   __m128 v28; // xmm12
			//   __m128 v29; // xmm13
			//   float v30; // xmm6_4
			//   float v31; // xmm1_4
			//   float v32; // xmm4_4
			//   float v33; // xmm7_4
			//   float v34; // xmm6_4
			//   __int64 v35; // rax
			//   __int64 v36; // rax
			//   EntityManager_1 v37; // [rsp+20h] [rbp-218h] BYREF
			//   __int128 v38; // [rsp+30h] [rbp-208h] BYREF
			//   ComponentMask other[2]; // [rsp+40h] [rbp-1F8h] BYREF
			//   __int128 v40; // [rsp+50h] [rbp-1E8h]
			//   __int64 v41; // [rsp+60h] [rbp-1D8h]
			//   __int64 v42; // [rsp+70h] [rbp-1C8h] BYREF
			//   float z; // [rsp+78h] [rbp-1C0h]
			//   __int64 v44; // [rsp+80h] [rbp-1B8h] BYREF
			//   float v45; // [rsp+88h] [rbp-1B0h]
			//   EntityManagerRange v46; // [rsp+90h] [rbp-1A8h] BYREF
			//   __int128 v47; // [rsp+B0h] [rbp-188h]
			//   __int128 v48; // [rsp+C0h] [rbp-178h]
			//   __int64 v49; // [rsp+D0h] [rbp-168h]
			//   Matrix4x4 v50; // [rsp+E0h] [rbp-158h] BYREF
			//   Il2CppExceptionWrapper *v51; // [rsp+120h] [rbp-118h] BYREF
			//   EntityManager_1 v52; // [rsp+130h] [rbp-108h] BYREF
			//   Quaternion rotation; // [rsp+140h] [rbp-F8h] BYREF
			//   Matrix4x4 v54[3]; // [rsp+150h] [rbp-E8h] BYREF
			//   GroupType v55; // [rsp+250h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDBF3 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGECSRegionComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
			//     byte_18D8EDBF3 = 1;
			//   }
			//   v38 = 0LL;
			//   *(_OWORD *)&other[0].componentMaskWords.FixedElementField = 0LL;
			//   v40 = 0LL;
			//   v41 = 0LL;
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
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size <= 402 )
			//     goto LABEL_17;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = v3.static_fields.wrapperArray;
			//   if ( !v5 )
			//     sub_180B536AC(v3, method);
			//   if ( v5.max_length.size <= 0x192u )
			//     sub_180070270(v3, method);
			//   if ( v5[11].vector[6] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(402, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)hgCamera, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     if ( !hgCamera )
			//       sub_180B536AC(v3, method);
			//     hgCamera.fields.enableShadowCulling = 0;
			//     v37 = 0LL;
			//     v9 = (void (__fastcall *)(EntityManager_1 *, MethodInfo *))qword_18D8F5E78;
			//     if ( !qword_18D8F5E78 )
			//     {
			//       v9 = (void (__fastcall *)(EntityManager_1 *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                    "UnityEngine.HyperGryph.ECS.EntityManager::GetRenderer"
			//                                                                    "EntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//       if ( !v9 )
			//       {
			//         v35 = sub_1802DBBE8(
			//                 "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//         sub_18000F750(v35, 0LL);
			//       }
			//       qword_18D8F5E78 = (__int64)v9;
			//     }
			//     v9(&v37, method);
			//     v52 = v37;
			//     UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGECSRegionComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
			//       (EntityManagerRange *)&v50,
			//       &v52,
			//       MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGECSRegionComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//     *(_OWORD *)&v46.m_entityTypes = *(_OWORD *)&v50.m00;
			//     *(_OWORD *)&v46.m_excludeComponentMask.componentMaskWords.FixedElementField = *(_OWORD *)&v50.m01;
			//     v47 = *(_OWORD *)&v50.m02;
			//     Enumerator = UnityEngine::HyperGryph::ECS::EntityManagerRange::GetEnumerator(
			//                    (EntityManagerRange_Enumerator *)&v50,
			//                    &v46,
			//                    0LL);
			//     v38 = *(_OWORD *)&Enumerator.m_entityTypes;
			//     *(_OWORD *)&other[0].componentMaskWords.FixedElementField = *(_OWORD *)&Enumerator.m_includeComponentMask.componentMaskWords.FixedElementField;
			//     v40 = *(_OWORD *)&Enumerator.m_index;
			//     v41 = *(_QWORD *)&Enumerator[1].m_count;
			//     v37.m_entitiesPPtr = 0LL;
			//     v37.m_entityTypesPPtr = &v38;
			//     try
			//     {
			//       v11 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_u32[0];
			// LABEL_22:
			//       v12 = v41;
			//       v13 = *((_QWORD *)&v40 + 1);
			//       v14 = v40;
			//       v15 = DWORD2(v38);
			//       v16 = v38;
			//       while ( 1 )
			//       {
			//         LODWORD(v41) = ++v12;
			//         if ( v12 >= v15 )
			//           break;
			//         v17 = v16 + 576LL * v12;
			//         if ( *(_QWORD *)(v17 + 32)
			//           && UnityEngine::HyperGryph::ECS::ComponentMask::ContainsComponentMask((ComponentMask *)(v17 + 16), other, 0LL)
			//           && (v14 & *(_QWORD *)(v17 + 16)) == 0
			//           && (v13 & *(_QWORD *)(v17 + 24)) == 0
			//           && *(_DWORD *)(v17 + 44) )
			//         {
			//           if ( v12 >= v15 )
			//             goto LABEL_54;
			//           v18 = (EntityTypeInstanceData *)(v16 + 576LL * v12);
			//           v55.m_entityTypes = v18;
			//           v19 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>(
			//                   &v55,
			//                   MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
			//           v22 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
			//                   &v55,
			//                   MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//           for ( i = 0; ; ++i )
			//           {
			//             if ( !v18 )
			//               sub_1802DC2C8(v21, v20);
			//             if ( i >= v18.count )
			//               break;
			//             v21 = &v19[i];
			//             if ( v21.isEnable )
			//             {
			//               v42 = *(_QWORD *)&v21.size.x;
			//               z = v21.size.z;
			//               rotation = v21.rotation;
			//               v44 = *(_QWORD *)&v21.center.x;
			//               v45 = v21.center.z;
			//               memset(&v46, 0, sizeof(v46));
			//               v47 = 0LL;
			//               v48 = 0LL;
			//               v24 = (void (__fastcall *)(__int64 *, Quaternion *, __int64 *, EntityManagerRange *, void *, void *))qword_18D8F4BC8;
			//               if ( !qword_18D8F4BC8 )
			//               {
			//                 v24 = (void (__fastcall *)(__int64 *, Quaternion *, __int64 *, EntityManagerRange *, void *, void *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//                 if ( !v24 )
			//                 {
			//                   v36 = sub_1802DBBE8(
			//                           "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.V"
			//                           "ector3&,UnityEngine.Matrix4x4&)");
			//                   sub_18000F750(v36, 0LL);
			//                 }
			//                 qword_18D8F4BC8 = (__int64)v24;
			//               }
			//               v24(&v44, &rotation, &v42, &v46, v37.m_entitiesPPtr, v37.m_entityTypesPPtr);
			//               *(_OWORD *)&v50.m00 = *(_OWORD *)&v46.m_entityTypes;
			//               *(_OWORD *)&v50.m01 = *(_OWORD *)&v46.m_excludeComponentMask.componentMaskWords.FixedElementField;
			//               *(_OWORD *)&v50.m02 = v47;
			//               *(_OWORD *)&v50.m03 = v48;
			//               inverse = UnityEngine::Matrix4x4::get_inverse(v54, &v50, 0LL);
			//               v26 = *(__m128 *)&inverse.m00;
			//               v27 = *(__m128 *)&inverse.m01;
			//               v28 = *(__m128 *)&inverse.m02;
			//               v29 = *(__m128 *)&inverse.m03;
			//               v30 = hgCamera.fields.mainViewConstants.worldSpaceCameraPos.z;
			//               v31 = v30 * v28.m128_f32[0];
			//               v32 = _mm_shuffle_ps(
			//                       (__m128)*(unsigned __int64 *)&hgCamera.fields.mainViewConstants.worldSpaceCameraPos.x,
			//                       (__m128)*(unsigned __int64 *)&hgCamera.fields.mainViewConstants.worldSpaceCameraPos.x,
			//                       85).m128_f32[0];
			//               v49 = *(_QWORD *)&hgCamera.fields.mainViewConstants.worldSpaceCameraPos.x;
			//               v33 = (float)((float)(v30 * _mm_shuffle_ps(v28, v28, 85).m128_f32[0])
			//                           + (float)((float)(v32 * _mm_shuffle_ps(v27, v27, 85).m128_f32[0])
			//                                   + (float)(*(float *)&v49 * _mm_shuffle_ps(v26, v26, 85).m128_f32[0])))
			//                   + _mm_shuffle_ps(v29, v29, 85).m128_f32[0];
			//               v34 = (float)((float)(v30 * _mm_shuffle_ps(v28, v28, 170).m128_f32[0])
			//                           + (float)((float)(v32 * _mm_shuffle_ps(v27, v27, 170).m128_f32[0])
			//                                   + (float)(*(float *)&v49 * _mm_shuffle_ps(v26, v26, 170).m128_f32[0])))
			//                   + _mm_shuffle_ps(v29, v29, 170).m128_f32[0];
			//               if ( COERCE_FLOAT(COERCE_UNSIGNED_INT(
			//                                   (float)((float)((float)(v32 * v27.m128_f32[0])
			//                                                 + (float)(*(float *)&v49 * v26.m128_f32[0]))
			//                                         + v31)
			//                                 + v29.m128_f32[0]) & v11) < 0.5
			//                 && COERCE_FLOAT(LODWORD(v33) & v11) < 0.5
			//                 && COERCE_FLOAT(LODWORD(v34) & v11) < 0.5 )
			//               {
			//                 hgCamera.fields.enableShadowCulling = hgCamera.fields.enableShadowCulling
			//                                                     || v22[i].enableShadowCulling;
			//               }
			//             }
			//           }
			//           goto LABEL_22;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v51 )
			//     {
			//       v37.m_entitiesPPtr = v51.ex;
			//       if ( v37.m_entitiesPPtr )
			//         sub_18000F780(v37.m_entitiesPPtr);
			//     }
			// LABEL_54:
			//     ;
			//   }
			// }
			// 
		}
	}
}
