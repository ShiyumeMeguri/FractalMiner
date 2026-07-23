using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGCullingManager // TypeDefIndex: 37533
	{
		// Constructors
		public HGCullingManager() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static void PrepareCullingParameters(HGCamera hgCamera) {} // 0x00000001830C86A0-0x00000001830C8ED0
		// Void PrepareCullingParameters(HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCullingManager::PrepareCullingParameters(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  void (__fastcall *v9)(_BYTE *, MethodInfo *); // rax
		  __int64 v10; // rdx
		  struct MethodInfo *v11; // rbx
		  __int64 v12; // rdi
		  _BYTE *v13; // rsi
		  _BYTE *rgctxDataDummy; // rax
		  __int64 v15; // rdx
		  int32_t v16; // r15d
		  _BYTE *v17; // rdi
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  Il2CppRGCTXData v19; // rax
		  unsigned int v20; // eax
		  __int128 v21; // xmm6
		  __int64 v22; // rbx
		  __int64 (__fastcall *v23)(int32_t *); // rax
		  int v24; // eax
		  EntityManagerRange_Enumerator *Enumerator; // rax
		  unsigned __int32 v26; // xmm7_4
		  int v27; // edi
		  __int64 v28; // rbx
		  __int64 v29; // rdx
		  __int64 v30; // rbx
		  struct MethodInfo *v31; // rcx
		  unsigned __int64 v32; // rdx
		  __int64 v33; // r15
		  unsigned __int64 v34; // rdx
		  __int64 v35; // r12
		  int i; // esi
		  __int64 v37; // rcx
		  void (__fastcall *v38)(__int64 *, EntityManager *, __int64 *, __int128 *, __int64); // rax
		  void (__fastcall *v39)(_OWORD *, __int128 *); // rax
		  float z; // xmm5_4
		  float v41; // xmm4_4
		  float v42; // xmm3_4
		  float v43; // xmm6_4
		  float v44; // xmm5_4
		  __int64 v45; // rax
		  __int64 v46; // rax
		  __int64 v47; // rax
		  __int64 v48; // rax
		  __int64 v49; // [rsp+20h] [rbp-248h]
		  _BYTE v50[48]; // [rsp+30h] [rbp-238h] BYREF
		  __int128 v51; // [rsp+60h] [rbp-208h] BYREF
		  ComponentMask other[2]; // [rsp+70h] [rbp-1F8h] BYREF
		  __int128 v53; // [rsp+80h] [rbp-1E8h]
		  __int64 v54; // [rsp+90h] [rbp-1D8h]
		  int32_t id0[4]; // [rsp+A0h] [rbp-1C8h] BYREF
		  __int128 v56; // [rsp+B0h] [rbp-1B8h] BYREF
		  __int128 v57; // [rsp+C0h] [rbp-1A8h]
		  __int128 v58; // [rsp+D0h] [rbp-198h]
		  __int128 v59; // [rsp+E0h] [rbp-188h]
		  __int64 v60; // [rsp+F0h] [rbp-178h] BYREF
		  int v61; // [rsp+F8h] [rbp-170h]
		  __int64 v62; // [rsp+100h] [rbp-168h] BYREF
		  int v63; // [rsp+108h] [rbp-160h]
		  EntityManagerRange v64; // [rsp+110h] [rbp-158h] BYREF
		  __int128 v65; // [rsp+130h] [rbp-138h]
		  EntityManager v66; // [rsp+140h] [rbp-128h] BYREF
		  __int128 v67; // [rsp+150h] [rbp-118h] BYREF
		  __int128 v68; // [rsp+160h] [rbp-108h]
		  __int128 v69; // [rsp+170h] [rbp-F8h]
		  __int128 v70; // [rsp+180h] [rbp-E8h]
		  Il2CppExceptionWrapper *v71; // [rsp+190h] [rbp-D8h] BYREF
		  _OWORD v72[4]; // [rsp+1A0h] [rbp-C8h] BYREF
		  EntityManagerRange_Enumerator v73[2]; // [rsp+1E0h] [rbp-88h] BYREF
		
		  v51 = 0LL;
		  *(_OWORD *)&other[0].componentMaskWords.FixedElementField = 0LL;
		  v53 = 0LL;
		  v54 = 0LL;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size <= 414 )
		    goto LABEL_13;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = v3->static_fields->wrapperArray;
		  if ( !v5 )
		    sub_1800D8260(v3, method);
		  if ( v5->max_length.size <= 0x19Eu )
		    sub_1800D2AB0(v3, method);
		  if ( v5[11].vector[18] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(414, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)hgCamera, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    if ( !hgCamera )
		      sub_1800D8260(v3, method);
		    hgCamera->fields.enableShadowCulling = 0;
		    *(_OWORD *)v50 = 0LL;
		    v9 = (void (__fastcall *)(_BYTE *, MethodInfo *))qword_18F370C08;
		    if ( !qword_18F370C08 )
		    {
		      v9 = (void (__fastcall *)(_BYTE *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityMana"
		                                                         "ger_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		      if ( !v9 )
		      {
		        v45 = sub_1802EE1B8(
		                "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		        sub_18007E1B0(v45, 0LL);
		      }
		      qword_18F370C08 = (__int64)v9;
		    }
		    v9(v50, method);
		    *(_OWORD *)id0 = *(_OWORD *)v50;
		    v11 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>;
		    if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>->rgctx_data )
		      sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent,UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
		    v12 = **(_QWORD **)&id0[2];
		    v13 = *(_BYTE **)(**(_QWORD **)&id0[2] + 608LL);
		    rgctxDataDummy = v11->rgctx_data->rgctxDataDummy;
		    if ( (rgctxDataDummy[312] & 1) == 0 )
		      sub_1800360B0(v11->rgctx_data->rgctxDataDummy, v10);
		    *(_QWORD *)v50 = rgctxDataDummy;
		    *(_QWORD *)&v50[8] = -1LL;
		    v50[16] = *v13;
		    v16 = sub_1830C71E0(v50, 0LL);
		    *v13 = v50[16];
		    v17 = *(_BYTE **)(v12 + 608);
		    rgctx_data = v11->rgctx_data;
		    v19.rgctxDataDummy = rgctx_data[2].rgctxDataDummy;
		    if ( (*((_BYTE *)v19.rgctxDataDummy + 312) & 1) == 0 )
		      sub_1800360B0((const Il2CppRGCTXData)rgctx_data[2].rgctxDataDummy, v15);
		    v64.m_entityTypes = (EntityTypeInstanceData *)v19.rgctxDataDummy;
		    v64.m_componentMask.componentMaskWords.FixedElementField = -1LL;
		    LOBYTE(v64.m_excludeComponentMask.componentMaskWords.FixedElementField) = *v17;
		    v20 = sub_1830C71E0(&v64, 0LL);
		    *v17 = v64.m_excludeComponentMask.componentMaskWords.FixedElementField;
		    v49 = 0LL;
		    v21 = *(_OWORD *)UnityEngine::HyperGryph::ECS::EntityManager::ComposeComponentMaskAll(
		                       &v66,
		                       (int32_t)id0,
		                       v16,
		                       (MethodInfo *)v20).componentMaskWords.FixedElementField;
		    v22 = **(_QWORD **)&id0[2];
		    v23 = (__int64 (__fastcall *)(int32_t *))qword_18F370C48;
		    if ( !qword_18F370C48 )
		    {
		      v23 = (__int64 (__fastcall *)(int32_t *))il2cpp_resolve_icall_1(
		                                                 "UnityEngine.HyperGryph.ECS.EntityManager::GetEntityTypeCount_Injected(U"
		                                                 "nityEngine.HyperGryph.ECS.EntityManager&)");
		      if ( !v23 )
		      {
		        v46 = sub_1802EE1B8(
		                "UnityEngine.HyperGryph.ECS.EntityManager::GetEntityTypeCount_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		        sub_18007E1B0(v46, 0LL);
		      }
		      qword_18F370C48 = (__int64)v23;
		    }
		    v24 = v23(id0);
		    *(_DWORD *)&v50[44] = 0;
		    *(_QWORD *)v50 = v22;
		    *(_DWORD *)&v50[40] = v24;
		    *(_OWORD *)&v50[8] = v21;
		    *(_OWORD *)&v50[24] = 0LL;
		    v64 = *(EntityManagerRange *)v50;
		    v65 = *(_OWORD *)&v50[32];
		    Enumerator = UnityEngine::HyperGryph::ECS::EntityManagerRange::GetEnumerator(v73, &v64, 0LL);
		    v51 = *(_OWORD *)&Enumerator->m_entityTypes;
		    *(_OWORD *)&other[0].componentMaskWords.FixedElementField = *(_OWORD *)&Enumerator->m_includeComponentMask.componentMaskWords.FixedElementField;
		    v53 = *(_OWORD *)&Enumerator->m_index;
		    v54 = *(_QWORD *)&Enumerator[1].m_count;
		    *(_QWORD *)v50 = 0LL;
		    *(_QWORD *)&v50[8] = &v51;
		    try
		    {
		      v27 = v54;
		      v26 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_u32[0];
		      while ( 1 )
		      {
		        LODWORD(v54) = ++v27;
		        if ( v27 >= SDWORD2(v51) )
		          break;
		        v28 = v51 + 576LL * v27;
		        if ( *(_QWORD *)(v28 + 32)
		          && UnityEngine::HyperGryph::ECS::ComponentMask::ContainsComponentMask((ComponentMask *)(v28 + 16), other, 0LL)
		          && (*(_OWORD *)(v28 + 16) & v53) == 0
		          && *(_DWORD *)(v28 + 44) )
		        {
		          if ( v27 >= SDWORD2(v51) )
		            goto LABEL_73;
		          v30 = v51 + 576LL * v27;
		          v31 = MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>;
		          if ( !MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>->rgctx_data )
		          {
		            sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>);
		            v27 = v54;
		          }
		          if ( !v30 )
		            sub_1800D8250(v31, v29);
		          if ( (*(_QWORD *)(v30 + 16) & 0x2000000000000000LL) != 0 )
		          {
		            v32 = ((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFLL)
		                 - (((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) & 0x3333333333333333LL;
		            v33 = *(_QWORD *)(v30 + 32)
		                + (int)(*(_DWORD *)(v30 + 48)
		                      * HIDWORD(*(_QWORD *)(v30
		                                          + 8
		                                          * ((0x101010101010101LL
		                                            * ((v32
		                                              + ((((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFLL)
		                                                 - (((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) >> 2) & 0x3333333333333333LL)
		                                              + ((v32
		                                                + ((((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFLL)
		                                                   - (((*(_QWORD *)(v30 + 16) & 0x1FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) >> 2) & 0x3333333333333333LL)) >> 4)) & 0xF0F0F0F0F0F0F0FLL)) >> 56)
		                                          + 64)));
		          }
		          else
		          {
		            v33 = 0LL;
		          }
		          if ( !MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>->rgctx_data )
		          {
		            sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
		            v27 = v54;
		          }
		          if ( (*(_QWORD *)(v30 + 16) & 0x4000000000000000LL) != 0 )
		          {
		            v34 = ((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFLL)
		                 - (((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) & 0x3333333333333333LL;
		            v35 = *(_QWORD *)(v30 + 32)
		                + (int)(*(_DWORD *)(v30 + 48)
		                      * HIDWORD(*(_QWORD *)(v30
		                                          + 8
		                                          * ((0x101010101010101LL
		                                            * ((v34
		                                              + ((((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFLL)
		                                                 - (((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) >> 2) & 0x3333333333333333LL)
		                                              + ((v34
		                                                + ((((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFLL)
		                                                   - (((*(_QWORD *)(v30 + 16) & 0x3FFFFFFFFFFFFFFFuLL) >> 1) & 0x5555555555555555LL)) >> 2) & 0x3333333333333333LL)) >> 4)) & 0xF0F0F0F0F0F0F0FLL)) >> 56)
		                                          + 64)));
		          }
		          else
		          {
		            v35 = 0LL;
		          }
		          for ( i = 0; i < *(_DWORD *)(v30 + 44); ++i )
		          {
		            v37 = v33 + 44LL * i;
		            if ( *(_BYTE *)v37 )
		            {
		              v60 = *(_QWORD *)(v37 + 16);
		              v61 = *(_DWORD *)(v37 + 24);
		              v66 = *(EntityManager *)(v37 + 28);
		              v62 = *(_QWORD *)(v37 + 4);
		              v63 = *(_DWORD *)(v37 + 12);
		              v67 = 0LL;
		              v68 = 0LL;
		              v69 = 0LL;
		              v70 = 0LL;
		              v38 = (void (__fastcall *)(__int64 *, EntityManager *, __int64 *, __int128 *, __int64))qword_18F36FA58;
		              if ( !qword_18F36FA58 )
		              {
		                v38 = (void (__fastcall *)(__int64 *, EntityManager *, __int64 *, __int128 *, __int64))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
		                if ( !v38 )
		                {
		                  v47 = sub_1802EE1B8(
		                          "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.V"
		                          "ector3&,UnityEngine.Matrix4x4&)");
		                  sub_18007E1B0(v47, 0LL);
		                }
		                qword_18F36FA58 = (__int64)v38;
		              }
		              v38(&v62, &v66, &v60, &v67, v49);
		              v72[0] = v67;
		              v72[1] = v68;
		              v72[2] = v69;
		              v72[3] = v70;
		              v56 = 0LL;
		              v57 = 0LL;
		              v58 = 0LL;
		              v59 = 0LL;
		              v39 = (void (__fastcall *)(_OWORD *, __int128 *))qword_18F36FA60;
		              if ( !qword_18F36FA60 )
		              {
		                v39 = (void (__fastcall *)(_OWORD *, __int128 *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.M"
		                                                                   "atrix4x4&,UnityEngine.Matrix4x4&)");
		                if ( !v39 )
		                {
		                  v48 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		                  sub_18007E1B0(v48, 0LL);
		                }
		                qword_18F36FA60 = (__int64)v39;
		              }
		              v39(v72, &v56);
		              z = hgCamera->fields.mainViewConstants.worldSpaceCameraPos.z;
		              v41 = z;
		              v42 = _mm_shuffle_ps(
		                      (__m128)*(unsigned __int64 *)&hgCamera->fields.mainViewConstants.worldSpaceCameraPos.x,
		                      (__m128)*(unsigned __int64 *)&hgCamera->fields.mainViewConstants.worldSpaceCameraPos.x,
		                      85).m128_f32[0];
		              v64.m_entityTypes = *(EntityTypeInstanceData **)&hgCamera->fields.mainViewConstants.worldSpaceCameraPos.x;
		              v43 = (float)((float)(z * *((float *)&v58 + 1))
		                          + (float)((float)(v42 * *((float *)&v57 + 1))
		                                  + (float)(*((float *)&v56 + 1) * *(float *)&v64.m_entityTypes)))
		                  + *((float *)&v59 + 1);
		              v44 = (float)((float)(z * *((float *)&v58 + 2))
		                          + (float)((float)(v42 * *((float *)&v57 + 2))
		                                  + (float)(*((float *)&v56 + 2) * *(float *)&v64.m_entityTypes)))
		                  + *((float *)&v59 + 2);
		              if ( COERCE_FLOAT(COERCE_UNSIGNED_INT(
		                                  (float)((float)(v41 * *(float *)&v58)
		                                        + (float)((float)(v42 * *(float *)&v57)
		                                                + (float)(*(float *)&v56 * *(float *)&v64.m_entityTypes)))
		                                + *(float *)&v59) & v26) < 0.5
		                && COERCE_FLOAT(LODWORD(v43) & v26) < 0.5
		                && COERCE_FLOAT(LODWORD(v44) & v26) < 0.5 )
		              {
		                hgCamera->fields.enableShadowCulling = (hgCamera->fields.enableShadowCulling | *(_BYTE *)(i + v35)) != 0;
		              }
		              v27 = v54;
		            }
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v71 )
		    {
		      *(Il2CppExceptionWrapper *)v50 = (Il2CppExceptionWrapper)v71->ex;
		      if ( *(_QWORD *)v50 )
		        sub_18007E1E0(*(_QWORD *)v50);
		    }
		LABEL_73:
		    ;
		  }
		}
		
	}
}
