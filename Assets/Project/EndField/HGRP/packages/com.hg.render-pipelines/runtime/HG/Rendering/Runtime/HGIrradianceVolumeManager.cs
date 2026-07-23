using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGIrradianceVolumeManager // TypeDefIndex: 37763
	{
		// Fields
		private const string GACHA_IV_PATH = "IrradianceVolume/gacha/index.bytes"; // Metadata: 0x023030A6
		private long m_defaultIV; // 0x10
		private string m_lastDataPathV3; // 0x18
		private string m_irradianceDataPathV3; // 0x20
		private string m_exportpathV3; // 0x28
		private long m_gachaIV; // 0x30
		private bool m_startGachaIV; // 0x38
		private bool m_endGachaIV; // 0x39
		private string m_gachaDataPathV3; // 0x40
		private bool m_overrideStreamingCenterByCamera; // 0x48
	
		// Constructors
		public HGIrradianceVolumeManager() {} // 0x0000000182ED8B60-0x0000000182ED8BB0
		// HGIrradianceVolumeManager()
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::HGIrradianceVolumeManager(
		        HGIrradianceVolumeManager *this,
		        MethodInfo *method)
		{
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  __int64 v4; // r10
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  __int64 v7; // r10
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_irradianceDataPathV3 = (String *)"";
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_irradianceDataPathV3, (Type *)method, v2, v3, v10);
		  *(_QWORD *)(v4 + 40) = "";
		  sub_18002D1B0((SingleFieldAccessor *)(v4 + 40), v5, v6, (Int32__Array **)"", v11);
		  *(_QWORD *)(v7 + 64) = "";
		  sub_18002D1B0((SingleFieldAccessor *)(v7 + 64), v8, v9, (Int32__Array **)"", v12);
		}
		
	
		// Methods
		public long GetActiveIV() => default; // 0x0000000183E6DAC0-0x0000000183E6DB20
		// Int64 GetActiveIV()
		int64_t HG::Rendering::Runtime::HGIrradianceVolumeManager::GetActiveIV(
		        HGIrradianceVolumeManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1091 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x443 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[23]._0.interopData )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1091, 0LL);
		      if ( Patch )
		        return (int64_t)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739(
		                          (ILFixDynamicMethodWrapper_3 *)Patch,
		                          (Object *)this,
		                          0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->fields.m_gachaIV )
		    return this->fields.m_gachaIV;
		  else
		    return this->fields.m_defaultIV;
		}
		
		public string GetCurrentIrradianceVolumePathV3() => default; // 0x0000000189D02AE8-0x0000000189D02B4C
		// String GetCurrentIrradianceVolumePathV3()
		String *HG::Rendering::Runtime::HGIrradianceVolumeManager::GetCurrentIrradianceVolumePathV3(
		        HGIrradianceVolumeManager *this,
		        MethodInfo *method)
		{
		  String *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1864, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1864, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    result = this->fields.m_lastDataPathV3;
		    if ( !result )
		      return TypeInfo::System::String->static_fields->Empty;
		  }
		  return result;
		}
		
		public void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResult result, ScriptableRenderContext renderContext, Camera primaryCamera, Transform currentPlayerCenter, ComputeShader ivBakeCS, ComputeShader ivIndirectCS) {
			result = default;
		} // 0x0000000183337F70-0x0000000183339460
		// Void PipelineUpdate(HGIrradianceVolumePipelineUpdateResult ByRef, ScriptableRenderContext, Camera, Transform, ComputeShader, ComputeShader)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::PipelineUpdate(
		        HGIrradianceVolumeManager *this,
		        HGIrradianceVolumePipelineUpdateResult *result,
		        ScriptableRenderContext renderContext,
		        Camera *primaryCamera,
		        Transform *currentPlayerCenter,
		        ComputeShader *ivBakeCS,
		        ComputeShader *ivIndirectCS,
		        MethodInfo *method)
		{
		  __int64 v11; // r8
		  signed __int64 v12; // rcx
		  __int128 v13; // rax
		  __int64 v14; // r15
		  void *m_Ptr; // rbx
		  __m128i v16; // xmm2
		  __m128i v17; // xmm6
		  _DWORD *v18; // xmm1_8
		  unsigned __int64 v19; // r12
		  _DWORD *v20; // rdi
		  _QWORD *v21; // r8
		  __int64 v22; // r12
		  __int64 v23; // r13
		  __int64 v24; // r15
		  __int64 v25; // r13
		  __int64 v26; // r12
		  HGIrradianceVolumeManager__Class *klass; // r13
		  __int64 v28; // r15
		  _DWORD *v29; // rdi
		  char *v30; // rdi
		  _QWORD *v31; // rsi
		  __int64 v32; // r15
		  __int64 v33; // r12
		  __int64 v34; // rbx
		  char *v35; // rdi
		  __int64 v36; // rsi
		  Camera *v37; // r12
		  Camera__Class *v38; // r15
		  __int64 v39; // rbx
		  char *v40; // rdi
		  __int64 v41; // rsi
		  Transform *v42; // r15
		  Transform__Class *v43; // r12
		  __int64 v44; // rbx
		  char *v45; // rdi
		  __int64 v46; // rsi
		  ComputeShader *v47; // r15
		  ComputeShader__Class *v48; // r12
		  __int64 v49; // rbx
		  char *v50; // rdi
		  __int64 v51; // rsi
		  ComputeShader *v52; // rdi
		  ComputeShader__Class *v53; // r15
		  __int64 v54; // rbx
		  Value_1 *v55; // rsi
		  void (__fastcall __noreturn **v56)(); // rdi
		  struct MethodInfo *v57; // r15
		  __int64 v58; // rsi
		  unsigned int v59; // eax
		  unsigned int v60; // eax
		  __int64 v61; // rax
		  signed __int64 v62; // rtt
		  __int64 v63; // rsi
		  __int64 v64; // rax
		  __int64 v65; // rsi
		  _QWORD **v66; // rcx
		  __int64 v67; // r8
		  __int64 v68; // rdi
		  bool v69; // zf
		  Vector4 v70; // xmm2
		  Vector4 v71; // xmm3
		  Vector4 v72; // xmm4
		  __int128 v73; // xmm5
		  Texture *v74; // xmm0_8
		  unsigned __int64 v75; // rdx
		  signed __int64 v76; // rtt
		  __int64 (*v77)(void); // rax
		  Texture *v78; // rax
		  unsigned __int64 v79; // rdx
		  signed __int64 v80; // rtt
		  __int64 (*v81)(void); // rax
		  Texture *v82; // rax
		  unsigned __int64 v83; // rdx
		  signed __int64 v84; // rtt
		  __int64 (*v85)(void); // rax
		  Texture *v86; // rax
		  unsigned __int64 v87; // rdx
		  signed __int64 v88; // rtt
		  Transform *transform; // rdi
		  unsigned __int64 v90; // rdx
		  signed __int64 v91; // rtt
		  unsigned __int64 v92; // rdx
		  signed __int64 v93; // rtt
		  String *m_lastDataPathV3; // rcx
		  String *m_irradianceDataPathV3; // rdx
		  unsigned __int64 v96; // rdx
		  signed __int64 v97; // rtt
		  __m128i v98; // xmm0
		  __int64 (__fastcall *v99)(_DWORD *); // rax
		  bool enabled; // al
		  Transform *v101; // rbx
		  Camera *main; // rbx
		  Component *v103; // rcx
		  int64_t m_gachaIV; // rbx
		  Vector3 *position; // rax
		  __int64 v106; // xmm0_8
		  void (__fastcall *v107)(int64_t, __int64 *); // rax
		  CommandBuffer *v108; // rdi
		  void *v109; // rsi
		  int v110; // r15d
		  int32_t InstanceID; // r14d
		  void (__fastcall *v112)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int32_t); // rax
		  __int64 v113; // rax
		  __int64 v114; // rax
		  __int64 v115; // rax
		  __int64 v116; // rax
		  __int64 v117; // rax
		  __int64 v118; // rax
		  __int64 v119; // rax
		  __int64 v120; // rax
		  __int64 v121; // rax
		  __int64 v122; // rax
		  __int64 v123; // rax
		  __int64 v124; // rax
		  __int64 v125; // rax
		  Value_1 *evaluationStackBase; // [rsp+50h] [rbp-B0h]
		  __int64 v127; // [rsp+60h] [rbp-A0h] BYREF
		  float z; // [rsp+68h] [rbp-98h]
		  Vector3 v129; // [rsp+70h] [rbp-90h] BYREF
		  _DWORD v130[5]; // [rsp+80h] [rbp-80h] BYREF
		  __int64 v131; // [rsp+94h] [rbp-6Ch]
		  int v132; // [rsp+9Ch] [rbp-64h]
		  __m128i si128; // [rsp+A0h] [rbp-60h]
		  int v134; // [rsp+B0h] [rbp-50h]
		  int v135; // [rsp+B4h] [rbp-4Ch]
		  int v136; // [rsp+B8h] [rbp-48h]
		  int v137; // [rsp+BCh] [rbp-44h]
		  int v138; // [rsp+C0h] [rbp-40h]
		  __int64 v139; // [rsp+C4h] [rbp-3Ch]
		  int v140; // [rsp+CCh] [rbp-34h]
		  int v141; // [rsp+D0h] [rbp-30h]
		  int v142; // [rsp+D4h] [rbp-2Ch]
		  int v143; // [rsp+D8h] [rbp-28h]
		  int v144; // [rsp+DCh] [rbp-24h]
		  __m128i v145; // [rsp+E0h] [rbp-20h]
		  int v146; // [rsp+F0h] [rbp-10h]
		  int v147; // [rsp+F4h] [rbp-Ch]
		  int v148; // [rsp+F8h] [rbp-8h]
		  int v149; // [rsp+FCh] [rbp-4h]
		  int v150; // [rsp+100h] [rbp+0h]
		  int v151; // [rsp+104h] [rbp+4h]
		  int v152; // [rsp+108h] [rbp+8h]
		  int v153; // [rsp+10Ch] [rbp+Ch]
		  int v154; // [rsp+110h] [rbp+10h]
		  int v155; // [rsp+114h] [rbp+14h]
		  int v156; // [rsp+118h] [rbp+18h]
		  int v157; // [rsp+11Ch] [rbp+1Ch]
		  int v158; // [rsp+120h] [rbp+20h]
		  int v159; // [rsp+124h] [rbp+24h]
		  int v160; // [rsp+128h] [rbp+28h]
		  int v161; // [rsp+12Ch] [rbp+2Ch]
		  int v162; // [rsp+130h] [rbp+30h]
		  int v163; // [rsp+134h] [rbp+34h]
		  int v164; // [rsp+138h] [rbp+38h]
		  int v165; // [rsp+13Ch] [rbp+3Ch]
		  Call topWriteBack; // [rsp+140h] [rbp+40h] BYREF
		  ScriptableRenderContext v168; // [rsp+1D0h] [rbp+D0h] BYREF
		  Camera *v169; // [rsp+1D8h] [rbp+D8h]
		
		  v169 = primaryCamera;
		  v168.m_Ptr = renderContext.m_Ptr;
		  sub_18033B9D0(v130, 0LL, 192LL);
		  v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  *((_QWORD *)&v13 + 1) = **(_QWORD **)(v12 + 184);
		  if ( !*((_QWORD *)&v13 + 1) )
		    goto LABEL_253;
		  if ( *(int *)(*((_QWORD *)&v13 + 1) + 24LL) > 671 )
		  {
		    if ( !*(_DWORD *)(v12 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    *((_QWORD *)&v13 + 1) = **(_QWORD **)(v12 + 184);
		    if ( !*((_QWORD *)&v13 + 1) )
		      goto LABEL_253;
		    if ( *(_DWORD *)(*((_QWORD *)&v13 + 1) + 24LL) <= 0x29Fu )
		      goto LABEL_262;
		    if ( *(_QWORD *)(*((_QWORD *)&v13 + 1) + 5400LL) )
		    {
		      if ( !*(_DWORD *)(v12 + 224) )
		      {
		        il2cpp_runtime_class_init_1(v12);
		        v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v12 = **(_QWORD **)(v12 + 184);
		      if ( !v12 )
		        goto LABEL_253;
		      if ( *(_DWORD *)(v12 + 24) <= 0x29Fu )
		        goto LABEL_262;
		      v14 = *(_QWORD *)(v12 + 5400);
		      m_Ptr = v168.m_Ptr;
		      v127 = v14;
		      if ( !v14 )
		        goto LABEL_253;
		      *(_QWORD *)&v13 = IFix::Core::Call::Begin(&topWriteBack, 0LL);
		      v16 = *(__m128i *)(v13 + 16);
		      v17 = *(__m128i *)v13;
		      topWriteBack.topWriteBack = *(Value_1 ***)(v13 + 32);
		      v18 = (_DWORD *)_mm_srli_si128(v16, 8).m128i_u64[0];
		      v19 = _mm_srli_si128(v17, 8).m128i_u64[0];
		      v12 = (signed __int64)v18 - v19;
		      evaluationStackBase = (Value_1 *)v19;
		      *((_QWORD *)&v13 + 1) = (__int64)((__int64)v18 - v19) / 12;
		      if ( !v18 )
		        goto LABEL_253;
		      *v18 = 9;
		      v18[1] = DWORD2(v13);
		      if ( !v16.m128i_i64[0] )
		        goto LABEL_253;
		      sub_180005370(v16.m128i_i64[0], SDWORD2(v13), 0LL);
		      v20 = v18 + 3;
		      if ( !*(_QWORD *)(v14 + 32) )
		        goto LABEL_33;
		      v21 = *(_QWORD **)(v14 + 32);
		      v12 = (signed __int64)v20 - v19;
		      *(_QWORD *)&v129.x = v21;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((__int64)((__int64)v20 - v19) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v22 = (__int64)((__int64)v20 - v19) / 12;
		      if ( v18 == (_DWORD *)-12LL )
		        goto LABEL_253;
		      *v20 = 8;
		      v18[4] = v22;
		      v23 = *v21;
		      v24 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		      if ( (unsigned __int8)il2cpp_class_is_assignable_from_1(v24, *v21) )
		      {
		        v25 = *(_QWORD *)&v129.x;
		      }
		      else
		      {
		        if ( (*(_BYTE *)(v23 + 313) & 0x10) == 0 )
		          goto LABEL_254;
		        if ( (*(_BYTE *)(v24 + 276) & 0x20) != 0 || *(_BYTE *)(v24 + 42) == 19 || *(_BYTE *)(v24 + 42) == 30 )
		        {
		          v25 = *(_QWORD *)&v129.x;
		          if ( *(_QWORD *)(v24 + 112) && *(_QWORD *)(*(_QWORD *)(v24 + 112) + 40LL) && sub_1802ED414(*(_QWORD *)&v129.x) )
		            goto LABEL_32;
		        }
		        else
		        {
		          v25 = *(_QWORD *)&v129.x;
		        }
		        if ( v24 != qword_18F35FF70 )
		        {
		LABEL_254:
		          v113 = sub_18031E23C();
		          sub_18007E190(v113, 0LL);
		        }
		      }
		LABEL_32:
		      sub_180005370(v16.m128i_i64[0], (int)v22, v25);
		      v19 = (unsigned __int64)evaluationStackBase;
		      v20 = v18 + 6;
		LABEL_33:
		      v12 = (signed __int64)v20 - v19;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((__int64)((__int64)v20 - v19) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v26 = (__int64)((__int64)v20 - v19) / 12;
		      if ( !v20 )
		        goto LABEL_253;
		      *v20 = 8;
		      v20[1] = v26;
		      if ( this )
		      {
		        klass = this->klass;
		        v28 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v28, this->klass)
		          && ((BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((*(_BYTE *)(v28 + 276) & 0x20) == 0 && *(_BYTE *)(v28 + 42) != 19 && *(_BYTE *)(v28 + 42) != 30
		            || !*(_QWORD *)(v28 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v28 + 112) + 40LL)
		            || !sub_1802ED414(this))
		           && v28 != qword_18F35FF70) )
		        {
		          v114 = sub_18031E23C();
		          sub_18007E190(v114, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v26, this);
		      v29 = v20 + 3;
		      if ( !v29 )
		        goto LABEL_253;
		      *(_QWORD *)&v129.x = m_Ptr;
		      *(_QWORD *)(v29 + 1) = v17.m128i_i64[0];
		      *v29 = 4;
		      v30 = (char *)(v29 + 3);
		      v31 = (_QWORD *)il2cpp_value_box_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, &v129);
		      v13 = (v30 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL;
		      v12 = *((_QWORD *)&v13 + 1) >> 63;
		      v32 = (v30 - (char *)evaluationStackBase) / 12;
		      if ( !v30 )
		        goto LABEL_253;
		      *(_DWORD *)v30 = 9;
		      *((_DWORD *)v30 + 1) = v32;
		      if ( v31 )
		      {
		        v33 = *v31;
		        v34 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v34, *v31)
		          && ((*(_BYTE *)(v33 + 313) & 0x10) == 0
		           || ((*(_BYTE *)(v34 + 276) & 0x20) == 0 && *(_BYTE *)(v34 + 42) != 19 && *(_BYTE *)(v34 + 42) != 30
		            || !*(_QWORD *)(v34 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v34 + 112) + 40LL)
		            || !sub_1802ED414(v31))
		           && v34 != qword_18F35FF70) )
		        {
		          v115 = sub_18031E23C();
		          sub_18007E190(v115, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v32, v31);
		      v35 = v30 + 12;
		      v12 = v35 - (char *)evaluationStackBase;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((v35 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v36 = (v35 - (char *)evaluationStackBase) / 12;
		      if ( !v35 )
		        goto LABEL_253;
		      v37 = v169;
		      *(_DWORD *)v35 = 8;
		      *((_DWORD *)v35 + 1) = v36;
		      if ( v37 )
		      {
		        v38 = v37->klass;
		        v39 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v39, v37->klass)
		          && ((BYTE1(v38->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((*(_BYTE *)(v39 + 276) & 0x20) == 0 && *(_BYTE *)(v39 + 42) != 19 && *(_BYTE *)(v39 + 42) != 30
		            || !*(_QWORD *)(v39 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v39 + 112) + 40LL)
		            || !sub_1802ED414(v37))
		           && v39 != qword_18F35FF70) )
		        {
		          v116 = sub_18031E23C();
		          sub_18007E190(v116, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v36, v37);
		      v40 = v35 + 12;
		      v12 = v40 - (char *)evaluationStackBase;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((v40 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v41 = (v40 - (char *)evaluationStackBase) / 12;
		      if ( !v40 )
		        goto LABEL_253;
		      v42 = currentPlayerCenter;
		      *(_DWORD *)v40 = 8;
		      *((_DWORD *)v40 + 1) = v41;
		      if ( v42 )
		      {
		        v43 = v42->klass;
		        v44 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v44, v42->klass)
		          && ((BYTE1(v43->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((*(_BYTE *)(v44 + 276) & 0x20) == 0 && *(_BYTE *)(v44 + 42) != 19 && *(_BYTE *)(v44 + 42) != 30
		            || !*(_QWORD *)(v44 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v44 + 112) + 40LL)
		            || !sub_1802ED414(v42))
		           && v44 != qword_18F35FF70) )
		        {
		          v117 = sub_18031E23C();
		          sub_18007E190(v117, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v41, v42);
		      v45 = v40 + 12;
		      v12 = v45 - (char *)evaluationStackBase;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((v45 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v46 = (v45 - (char *)evaluationStackBase) / 12;
		      if ( !v45 )
		        goto LABEL_253;
		      v47 = ivBakeCS;
		      *(_DWORD *)v45 = 8;
		      *((_DWORD *)v45 + 1) = v46;
		      if ( v47 )
		      {
		        v48 = v47->klass;
		        v49 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v49, v47->klass)
		          && ((BYTE1(v48->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((*(_BYTE *)(v49 + 276) & 0x20) == 0 && *(_BYTE *)(v49 + 42) != 19 && *(_BYTE *)(v49 + 42) != 30
		            || !*(_QWORD *)(v49 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v49 + 112) + 40LL)
		            || !sub_1802ED414(v47))
		           && v49 != qword_18F35FF70) )
		        {
		          v118 = sub_18031E23C();
		          sub_18007E190(v118, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v46, v47);
		      v50 = v45 + 12;
		      v12 = v50 - (char *)evaluationStackBase;
		      *((_QWORD *)&v13 + 1) = (unsigned __int128)((v50 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v51 = (v50 - (char *)evaluationStackBase) / 12;
		      if ( !v50 )
		        goto LABEL_253;
		      *(_DWORD *)v50 = 8;
		      *((_DWORD *)v50 + 1) = v51;
		      v52 = ivIndirectCS;
		      if ( ivIndirectCS )
		      {
		        v53 = ivIndirectCS->klass;
		        v54 = *(_QWORD *)(*(_QWORD *)v16.m128i_i64[0] + 64LL);
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v54, ivIndirectCS->klass)
		          && ((BYTE1(v53->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((*(_BYTE *)(v54 + 276) & 0x20) == 0 && *(_BYTE *)(v54 + 42) != 19 && *(_BYTE *)(v54 + 42) != 30
		            || !*(_QWORD *)(v54 + 112)
		            || !*(_QWORD *)(*(_QWORD *)(v54 + 112) + 40LL)
		            || !sub_1802ED414(v52))
		           && v54 != qword_18F35FF70) )
		        {
		          v119 = sub_18031E23C();
		          sub_18007E190(v119, 0LL);
		        }
		      }
		      sub_180005370(v16.m128i_i64[0], (int)v51, v52);
		      v12 = *(_QWORD *)(v127 + 16);
		      if ( !v12 )
		        goto LABEL_253;
		      v55 = evaluationStackBase;
		      v56 = 0LL;
		      IFix::Core::VirtualMachine::Execute(
		        (VirtualMachine *)v12,
		        *(Instruction **)(*(_QWORD *)(v12 + 24) + 8LL * *(int *)(v127 + 24)),
		        (Value_1 *)(v17.m128i_i64[0] + 12),
		        (Object__Array *)v16.m128i_i64[0],
		        evaluationStackBase,
		        (*(_QWORD *)(v127 + 32) != 0LL) + 7,
		        *(_DWORD *)(v127 + 24),
		        1,
		        topWriteBack.topWriteBack,
		        0LL);
		      v57 = MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::HyperGryph::HGIrradianceVolumePipelineUpdateResult>;
		      if ( !MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::HyperGryph::HGIrradianceVolumePipelineUpdateResult>->rgctx_data )
		        sub_1800430B0(MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::HyperGryph::HGIrradianceVolumePipelineUpdateResult>);
		      if ( !byte_18F3963A0 )
		      {
		        v11 = _InterlockedExchangeAdd64((volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetObject, 0LL);
		        if ( (v11 & 1) != 0 )
		        {
		          v58 = ((unsigned int)v11 >> 1) & 0xFFFFFFF;
		          switch ( (unsigned int)v11 >> 29 )
		          {
		            case 1u:
		              v56 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v58);
		              goto LABEL_130;
		            case 2u:
		              v56 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v58);
		              goto LABEL_130;
		            case 3u:
		            case 6u:
		              v59 = v11;
		              v11 = (unsigned int)v11 >> 29;
		              v60 = (v59 >> 1) & 0xFFFFFFF;
		              if ( (_DWORD)v11 )
		              {
		                if ( (_DWORD)v11 == 3 )
		                {
		                  v56 = (void (__fastcall __noreturn **)())sub_180009A40(v60);
		                }
		                else if ( (_DWORD)v11 == 6 )
		                {
		                  v61 = sub_1802F8800(v60);
		                  v56 = (void (__fastcall __noreturn **)())sub_180026660(v61, 0LL);
		                }
		              }
		              else if ( v60 == 1 )
		              {
		                v56 = off_18B8C2EC0;
		              }
		              goto LABEL_130;
		            case 4u:
		              v56 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v58);
		              goto LABEL_130;
		            case 5u:
		              v11 = 8 * v58;
		              if ( *(_QWORD *)(qword_18F371F68 + 8 * v58) )
		              {
		                v56 = *(void (__fastcall __noreturn ***)())(v11 + qword_18F371F68);
		              }
		              else
		              {
		                *(_QWORD *)&v13 = il2cpp_string_new_len(
		                                    qword_18F360DF8
		                                  + *(int *)(v11 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8 + 4)
		                                  + *(int *)(qword_18F360E00 + 16),
		                                    *(unsigned int *)(v11 + *(int *)(qword_18F360E00 + 8) + qword_18F360DF8));
		                v12 = qword_18F371F68;
		                v56 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                           (volatile signed __int64 *)(qword_18F371F68 + 8 * v58),
		                                                           v13,
		                                                           0LL);
		                if ( !v56 )
		                {
		                  if ( dword_18F35FD08 )
		                  {
		                    *((_QWORD *)&v13 + 1) = (((unsigned __int64)(qword_18F371F68 + 8 * v58) >> 12) & 0x1FFFFF) >> 6;
		                    v11 = ((unsigned __int64)(qword_18F371F68 + 8 * v58) >> 12) & 0x3F;
		                    _m_prefetchw(&qword_18F103690[*((_QWORD *)&v13 + 1)]);
		                    do
		                    {
		                      v12 = qword_18F103690[*((_QWORD *)&v13 + 1)] | (1LL << v11);
		                      v62 = qword_18F103690[*((_QWORD *)&v13 + 1)];
		                    }
		                    while ( v62 != _InterlockedCompareExchange64(&qword_18F103690[*((_QWORD *)&v13 + 1)], v12, v62) );
		                  }
		                  v56 = (void (__fastcall __noreturn **)())v13;
		                }
		              }
		              goto LABEL_130;
		            case 7u:
		              v63 = sub_1802F8760((unsigned int)v58);
		              v64 = *(_QWORD *)(v63 + 16);
		              v65 = (v63 - *(_QWORD *)(v64 + 128)) >> 5;
		              if ( *(_BYTE *)(v64 + 42) == 21 )
		              {
		                v66 = *(_QWORD ***)(v64 + 96);
		                if ( *v66 )
		                {
		                  v67 = **v66 - *(int *)(qword_18F360E00 + 160) - qword_18F360DF8;
		                  v64 = sub_180009B10(v67 / 92 + v67);
		                }
		                else
		                {
		                  v64 = 0LL;
		                }
		              }
		              LODWORD(v127) = v65 + *(_DWORD *)(*(_QWORD *)(v64 + 104) + 32LL);
		              *(_QWORD *)&v13 = sub_1801CD744(
		                                  (unsigned int)&v127,
		                                  (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                                  *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                                  12,
		                                  (__int64)sub_1802F7130);
		              if ( (_QWORD)v13 )
		              {
		                *((_QWORD *)&v13 + 1) = *(unsigned int *)(v13 + 8);
		                if ( DWORD2(v13) != -1 )
		                  v56 = (void (__fastcall __noreturn **)())(*((_QWORD *)&v13 + 1)
		                                                          + qword_18F360DF8
		                                                          + *(int *)(qword_18F360E00 + 72));
		              }
		LABEL_130:
		              v55 = evaluationStackBase;
		              if ( v56 )
		                _InterlockedExchange64((volatile __int64 *)&MethodInfo::IFix::Core::Call::GetObject, (__int64)v56);
		              break;
		            default:
		              v55 = evaluationStackBase;
		              break;
		          }
		        }
		        byte_18F3963A0 = 1;
		      }
		      if ( !v17.m128i_i64[0] )
		        goto LABEL_253;
		      v12 = *(int *)(v17.m128i_i64[0] + 4);
		      if ( (unsigned int)v12 < *(_DWORD *)(v16.m128i_i64[0] + 24) )
		      {
		        v68 = *(_QWORD *)(v16.m128i_i64[0] + 8 * v12 + 32);
		        sub_180005370(v16.m128i_i64[0], (v17.m128i_i64[0] - (__int64)v55) / 12, 0LL);
		        *(_QWORD *)&v13 = v57->rgctx_data->rgctxDataDummy;
		        if ( (*(_BYTE *)(v13 + 312) & 1) == 0 )
		          sub_1800360B0(v57->rgctx_data->rgctxDataDummy, *((_QWORD *)&v13 + 1));
		        if ( v68 )
		        {
		          if ( *(_QWORD *)(*(_QWORD *)v68 + 64LL) != *(_QWORD *)(v13 + 64) )
		            sub_18031E1F4(v68, v13);
		          v69 = dword_18F35FD08 == 0;
		          v70 = *(Vector4 *)(v68 + 32);
		          v71 = *(Vector4 *)(v68 + 48);
		          v72 = *(Vector4 *)(v68 + 64);
		          v73 = *(_OWORD *)(v68 + 80);
		          v74 = *(Texture **)(v68 + 96);
		          result->param0 = *(Vector4 *)(v68 + 16);
		          result->param1 = v70;
		          result->param2 = v71;
		          result->param3 = v72;
		          *(_OWORD *)&result->indirectionTexture = v73;
		          result->physicalTexture1 = v74;
		          if ( !v69 )
		          {
		            v75 = (((unsigned __int64)&result->indirectionTexture >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F103690[v75]);
		            do
		              v76 = qword_18F103690[v75];
		            while ( v76 != _InterlockedCompareExchange64(
		                             &qword_18F103690[v75],
		                             v76 | (1LL << (((unsigned __int64)&result->indirectionTexture >> 12) & 0x3F)),
		                             v76) );
		          }
		          return;
		        }
		LABEL_253:
		        sub_1800D8250(v12, *((_QWORD *)&v13 + 1));
		      }
		LABEL_262:
		      sub_1800D2AA0(v12, *((_QWORD *)&v13 + 1), v11);
		    }
		  }
		  v77 = (__int64 (*)(void))qword_18F36F920;
		  result->param0 = 0LL;
		  result->param1 = 0LL;
		  result->param2 = 0LL;
		  result->param3 = 0LL;
		  if ( !v77 )
		  {
		    v77 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Texture3D::get_blackTexture3D()");
		    if ( !v77 )
		    {
		      v120 = sub_1802EE1B8("UnityEngine.Texture3D::get_blackTexture3D()");
		      sub_18007E1B0(v120, 0LL);
		    }
		    qword_18F36F920 = (__int64)v77;
		  }
		  v78 = (Texture *)v77();
		  v69 = dword_18F35FD08 == 0;
		  result->indirectionTexture = v78;
		  if ( !v69 )
		  {
		    v79 = (((unsigned __int64)&result->indirectionTexture >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v79]);
		    do
		      v80 = qword_18F103690[v79];
		    while ( v80 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v79],
		                     v80 | (1LL << (((unsigned __int64)&result->indirectionTexture >> 12) & 0x3F)),
		                     v80) );
		  }
		  v81 = (__int64 (*)(void))qword_18F36F920;
		  if ( !qword_18F36F920 )
		  {
		    v81 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Texture3D::get_blackTexture3D()");
		    if ( !v81 )
		    {
		      v121 = sub_1802EE1B8("UnityEngine.Texture3D::get_blackTexture3D()");
		      sub_18007E1B0(v121, 0LL);
		    }
		    qword_18F36F920 = (__int64)v81;
		  }
		  v82 = (Texture *)v81();
		  v69 = dword_18F35FD08 == 0;
		  result->physicalTexture0 = v82;
		  if ( !v69 )
		  {
		    v83 = (((unsigned __int64)&result->physicalTexture0 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v83]);
		    do
		      v84 = qword_18F103690[v83];
		    while ( v84 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v83],
		                     v84 | (1LL << (((unsigned __int64)&result->physicalTexture0 >> 12) & 0x3F)),
		                     v84) );
		  }
		  v85 = (__int64 (*)(void))qword_18F36F920;
		  if ( !qword_18F36F920 )
		  {
		    v85 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Texture3D::get_blackTexture3D()");
		    if ( !v85 )
		    {
		      v122 = sub_1802EE1B8("UnityEngine.Texture3D::get_blackTexture3D()");
		      sub_18007E1B0(v122, 0LL);
		    }
		    qword_18F36F920 = (__int64)v85;
		  }
		  v86 = (Texture *)v85();
		  v69 = dword_18F35FD08 == 0;
		  result->physicalTexture1 = v86;
		  if ( !v69 )
		  {
		    v87 = (((unsigned __int64)&result->physicalTexture1 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v87]);
		    do
		      v88 = qword_18F103690[v87];
		    while ( v88 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v87],
		                     v88 | (1LL << (((unsigned __int64)&result->physicalTexture1 >> 12) & 0x3F)),
		                     v88) );
		  }
		  transform = 0LL;
		  if ( this->fields.m_defaultIV )
		  {
		    if ( this->fields.m_gachaIV )
		    {
		      if ( this->fields.m_startGachaIV )
		      {
		        UnityEngine::HyperGryph::HGIrradianceVolume::SetMapV3(
		          this->fields.m_gachaIV,
		          this->fields.m_gachaDataPathV3,
		          0LL);
		        this->fields.m_startGachaIV = 0;
		      }
		    }
		    else
		    {
		      v69 = dword_18F35FD08 == 0;
		      this->fields.m_irradianceDataPathV3 = (String *)"";
		      if ( !v69 )
		      {
		        v90 = (((unsigned __int64)&this->fields.m_irradianceDataPathV3 >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F103690[v90]);
		        do
		          v91 = qword_18F103690[v90];
		        while ( v91 != _InterlockedCompareExchange64(
		                         &qword_18F103690[v90],
		                         v91 | (1LL << (((unsigned __int64)&this->fields.m_irradianceDataPathV3 >> 12) & 0x3F)),
		                         v91) );
		      }
		      if ( this->fields.m_exportpathV3 )
		      {
		        v69 = dword_18F35FD08 == 0;
		        this->fields.m_irradianceDataPathV3 = this->fields.m_exportpathV3;
		        if ( !v69 )
		        {
		          v92 = (((unsigned __int64)&this->fields.m_irradianceDataPathV3 >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F103690[v92]);
		          do
		            v93 = qword_18F103690[v92];
		          while ( v93 != _InterlockedCompareExchange64(
		                           &qword_18F103690[v92],
		                           v93 | (1LL << (((unsigned __int64)&this->fields.m_irradianceDataPathV3 >> 12) & 0x3F)),
		                           v93) );
		        }
		      }
		      m_lastDataPathV3 = this->fields.m_lastDataPathV3;
		      m_irradianceDataPathV3 = this->fields.m_irradianceDataPathV3;
		      if ( m_lastDataPathV3 == m_irradianceDataPathV3
		        || m_lastDataPathV3
		        && m_irradianceDataPathV3
		        && m_lastDataPathV3->fields._stringLength == m_irradianceDataPathV3->fields._stringLength
		        && System::SpanHelpers::SequenceEqual(
		             (uint8_t *)&m_lastDataPathV3->fields._firstChar,
		             (uint8_t *)&m_irradianceDataPathV3->fields._firstChar,
		             2LL * m_lastDataPathV3->fields._stringLength,
		             0LL) )
		      {
		        this->fields.m_endGachaIV = 0;
		      }
		      else
		      {
		        v69 = dword_18F35FD08 == 0;
		        this->fields.m_lastDataPathV3 = this->fields.m_irradianceDataPathV3;
		        if ( !v69 )
		        {
		          v96 = (((unsigned __int64)&this->fields.m_lastDataPathV3 >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F103690[v96]);
		          do
		            v97 = qword_18F103690[v96];
		          while ( v97 != _InterlockedCompareExchange64(
		                           &qword_18F103690[v96],
		                           v97 | (1LL << (((unsigned __int64)&this->fields.m_lastDataPathV3 >> 12) & 0x3F)),
		                           v97) );
		        }
		        this->fields.m_endGachaIV = 0;
		        UnityEngine::HyperGryph::HGIrradianceVolume::SetMapV3(
		          this->fields.m_defaultIV,
		          this->fields.m_irradianceDataPathV3,
		          0LL);
		      }
		    }
		  }
		  else
		  {
		    v165 = 0;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18DA45A50);
		    v130[0] = 0;
		    v130[1] = 128;
		    v130[2] = 64;
		    v130[3] = 64;
		    v130[4] = 16;
		    v131 = 0x400000LL;
		    v132 = 1;
		    v137 = 0x200000;
		    v138 = 2097088;
		    v139 = 64LL;
		    v134 = 64;
		    v135 = 2097216;
		    v136 = 0x400000;
		    v142 = 0x8000;
		    v143 = 30720;
		    v144 = 2048;
		    v140 = 0x8000;
		    v141 = 63488;
		    *(_QWORD *)&v13 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( !(_QWORD)v13 )
		      goto LABEL_253;
		    if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(
		           (HGRenderPipelineSettingHub *)v13,
		           0LL) == HGDeviceType__Enum_Cinematic )
		    {
		      v98 = _mm_load_si128((const __m128i *)&xmmword_18DA45A60);
		      v146 = 1024;
		      v147 = 1024;
		      v148 = 0x4000000;
		      v149 = 512;
		    }
		    else
		    {
		      v98 = _mm_load_si128((const __m128i *)&xmmword_18DA45A20);
		      v146 = 4;
		      v147 = 8;
		      v148 = 0x100000;
		      v149 = 8;
		    }
		    v145 = v98;
		    v150 = 0x80000;
		    v151 = 60;
		    v152 = 128;
		    v153 = 64;
		    v154 = 128;
		    if ( v130[0] )
		    {
		      v155 = 6553600;
		      v156 = 12582912;
		      v157 = 3932160;
		    }
		    else
		    {
		      v155 = 14680064;
		      v156 = 0x2000000;
		      v157 = 14680064;
		    }
		    v99 = (__int64 (__fastcall *)(_DWORD *))qword_18F3708C0;
		    v158 = 1095761920;
		    v159 = 1112539136;
		    v160 = 1125122048;
		    v161 = 8;
		    v162 = 96;
		    v163 = 48;
		    v164 = 96;
		    if ( !qword_18F3708C0 )
		    {
		      v99 = (__int64 (__fastcall *)(_DWORD *))il2cpp_resolve_icall_1(
		                                                "UnityEngine.HyperGryph.HGIrradianceVolume::Create(UnityEngine.HyperGryph"
		                                                ".HGIrradianceVolumeConfig&)");
		      if ( !v99 )
		      {
		        v123 = sub_1802EE1B8("UnityEngine.HyperGryph.HGIrradianceVolume::Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfig&)");
		        sub_18007E1B0(v123, 0LL);
		      }
		      qword_18F3708C0 = (__int64)v99;
		    }
		    this->fields.m_defaultIV = v99(v130);
		    *(_QWORD *)&v13 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      *(_QWORD *)&v13 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		    }
		    v12 = *(_QWORD *)(*(_QWORD *)(v13 + 184) + 512LL);
		    if ( !v12 )
		      goto LABEL_253;
		    enabled = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled((HGGraphicsFeatureSwitch *)v12, 0LL);
		    UnityEngine::HyperGryph::HGIrradianceVolume::SetEnableV3(enabled, 0LL);
		  }
		  if ( !this->fields.m_gachaIV )
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v101 = currentPlayerCenter;
		    if ( currentPlayerCenter )
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( v101->fields._._.m_CachedPtr && !this->fields.m_overrideStreamingCenterByCamera )
		      {
		        transform = v101;
		        goto LABEL_228;
		      }
		    }
		  }
		  main = UnityEngine::Camera::get_main(0LL);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( main )
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( main->fields._._._.m_CachedPtr )
		    {
		      *(_QWORD *)&v13 = UnityEngine::Camera::get_main(0LL);
		      if ( !(_QWORD)v13 )
		        goto LABEL_253;
		      v103 = (Component *)v13;
		      goto LABEL_227;
		    }
		  }
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( primaryCamera )
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( primaryCamera->fields._._._.m_CachedPtr )
		    {
		      v103 = (Component *)primaryCamera;
		LABEL_227:
		      transform = UnityEngine::Component::get_transform(v103, 0LL);
		    }
		  }
		LABEL_228:
		  if ( this->fields.m_gachaIV )
		  {
		    m_gachaIV = this->fields.m_gachaIV;
		  }
		  else
		  {
		    m_gachaIV = this->fields.m_defaultIV;
		    if ( !m_gachaIV )
		      return;
		  }
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( transform )
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( transform->fields._._.m_CachedPtr )
		    {
		      position = UnityEngine::Transform::get_position(&v129, transform, 0LL);
		      v106 = *(_QWORD *)&position->x;
		      z = position->z;
		      v107 = (void (__fastcall *)(int64_t, __int64 *))qword_18F370908;
		      v127 = v106;
		      if ( !qword_18F370908 )
		      {
		        v107 = (void (__fastcall *)(int64_t, __int64 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.HyperGryph.HGIrradianceVolume::SetStreamingCenter_"
		                                                          "Injected(System.Int64,UnityEngine.Vector3&)");
		        if ( !v107 )
		        {
		          v124 = sub_1802EE1B8(
		                   "UnityEngine.HyperGryph.HGIrradianceVolume::SetStreamingCenter_Injected(System.Int64,UnityEngine.Vector3&)");
		          sub_18007E1B0(v124, 0LL);
		        }
		        qword_18F370908 = (__int64)v107;
		      }
		      v107(m_gachaIV, &v127);
		    }
		  }
		  if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		  v108 = UnityEngine::Rendering::CommandBufferPool::Get((String *)"", 0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  v12 = (signed __int64)ivBakeCS;
		  v109 = v168.m_Ptr;
		  if ( !ivBakeCS )
		    goto LABEL_253;
		  LODWORD(v13) = UnityEngine::Object::GetInstanceID((Object_1 *)ivBakeCS, 0LL);
		  v12 = (signed __int64)ivIndirectCS;
		  v110 = v13;
		  if ( !ivIndirectCS )
		    goto LABEL_253;
		  InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)ivIndirectCS, 0LL);
		  v112 = (void (__fastcall *)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int32_t))qword_18F370900;
		  if ( !qword_18F370900 )
		  {
		    v112 = (void (__fastcall *)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int32_t))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGIrradianceVolume::PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResult&,System.Int64,System.IntPtr,UnityEngine.Rendering.CommandBuffer,System.Int32,System.Int32)");
		    if ( !v112 )
		    {
		      v125 = sub_1802EE1B8(
		               "UnityEngine.HyperGryph.HGIrradianceVolume::PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipeli"
		               "neUpdateResult&,System.Int64,System.IntPtr,UnityEngine.Rendering.CommandBuffer,System.Int32,System.Int32)");
		      sub_18007E1B0(v125, 0LL);
		    }
		    qword_18F370900 = (__int64)v112;
		  }
		  v112(result, m_gachaIV, v109, v108, v110, InstanceID);
		  UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&v168, v108, 0LL);
		  UnityEngine::Rendering::CommandBufferPool::Release(v108, 0LL);
		}
		
		public void CreateGachaIV(string gachaDataPath) {} // 0x0000000189D028CC-0x0000000189D02A78
		// Void CreateGachaIV(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::CreateGachaIV(
		        HGIrradianceVolumeManager *this,
		        String *gachaDataPath,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  _BYTE config[112]; // [rsp+28h] [rbp-69h] BYREF
		  int v12; // [rsp+98h] [rbp+7h]
		  int v13; // [rsp+9Ch] [rbp+Bh]
		  int v14; // [rsp+A0h] [rbp+Fh]
		  int v15; // [rsp+A4h] [rbp+13h]
		  int v16; // [rsp+A8h] [rbp+17h]
		  int v17; // [rsp+ACh] [rbp+1Bh]
		  int v18; // [rsp+B0h] [rbp+1Fh]
		  int v19; // [rsp+B4h] [rbp+23h]
		  int v20; // [rsp+B8h] [rbp+27h]
		  int v21; // [rsp+BCh] [rbp+2Bh]
		  int v22; // [rsp+C0h] [rbp+2Fh]
		  int v23; // [rsp+C4h] [rbp+33h]
		  int v24; // [rsp+C8h] [rbp+37h]
		  int v25; // [rsp+CCh] [rbp+3Bh]
		  int v26; // [rsp+D0h] [rbp+3Fh]
		  int v27; // [rsp+D4h] [rbp+43h]
		  int v28; // [rsp+D8h] [rbp+47h]
		  int v29; // [rsp+DCh] [rbp+4Bh]
		  int v30; // [rsp+E0h] [rbp+4Fh]
		  int v31; // [rsp+E4h] [rbp+53h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1865, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1865, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)gachaDataPath,
		      0LL);
		  }
		  else
		  {
		    *(__m128i *)&config[32] = _mm_load_si128((const __m128i *)&xmmword_18DA45A50);
		    v31 = 0;
		    *(_QWORD *)config = 0x8000000000LL;
		    *(_DWORD *)&config[8] = 32;
		    *(_QWORD *)&config[20] = 0x40000LL;
		    *(_DWORD *)&config[56] = 0x40000;
		    *(_DWORD *)&config[84] = 0x2000;
		    *(_DWORD *)&config[76] = 0x2000;
		    *(_DWORD *)&config[12] = 32;
		    *(_DWORD *)&config[16] = 16;
		    *(_DWORD *)&config[28] = 1;
		    *(_DWORD *)&config[60] = 0x20000;
		    *(_DWORD *)&config[64] = 131008;
		    *(_QWORD *)&config[68] = 64LL;
		    *(_DWORD *)&config[48] = 64;
		    *(_DWORD *)&config[52] = 131136;
		    *(_DWORD *)&config[88] = 8184;
		    *(_DWORD *)&config[92] = 8;
		    *(_DWORD *)&config[80] = 16376;
		    *(__m128i *)&config[96] = _mm_load_si128((const __m128i *)&xmmword_18DA45A20);
		    v12 = 4;
		    v13 = 8;
		    v14 = 0x100000;
		    v15 = 8;
		    v16 = 0x80000;
		    v17 = 60;
		    v18 = 64;
		    v19 = 32;
		    v20 = 128;
		    v24 = 1084227584;
		    v21 = 196608;
		    v22 = 393216;
		    v23 = 24576;
		    v25 = 1101004800;
		    v26 = 1117782016;
		    v27 = 8;
		    v28 = 96;
		    v29 = 48;
		    v30 = 96;
		    this->fields.m_gachaIV = UnityEngine::HyperGryph::HGIrradianceVolume::Create(
		                               (HGIrradianceVolumeConfig *)config,
		                               0LL);
		    this->fields.m_startGachaIV = 1;
		    this->fields.m_gachaDataPathV3 = System::String::Concat(gachaDataPath, (String *)"/v3/index.bytes", 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_gachaDataPathV3, v5, v6, v7, *(MethodInfo **)config);
		  }
		}
		
		public void UpdateGachaIV(string gachaDataPath) {} // 0x0000000189D02E28-0x0000000189D02ECC
		// Void UpdateGachaIV(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::UpdateGachaIV(
		        HGIrradianceVolumeManager *this,
		        String *gachaDataPath,
		        MethodInfo *method)
		{
		  String *v5; // rax
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1866, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1866, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)gachaDataPath,
		      0LL);
		  }
		  else if ( this->fields.m_gachaIV )
		  {
		    v5 = System::String::Concat(gachaDataPath, (String *)"/v3/index.bytes", 0LL);
		    if ( !System::String::Equals(v5, this->fields.m_gachaDataPathV3, 0LL) )
		    {
		      this->fields.m_startGachaIV = 1;
		      this->fields.m_gachaDataPathV3 = System::String::Concat(gachaDataPath, (String *)"/v3/index.bytes", 0LL);
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_gachaDataPathV3, v6, v7, v8, v12);
		    }
		  }
		}
		
		public void DestroyGachaIV() {} // 0x0000000189D02A78-0x0000000189D02AE8
		// Void DestroyGachaIV()
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::DestroyGachaIV(
		        HGIrradianceVolumeManager *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1867, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1867, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolume::Destroy(this->fields.m_gachaIV, 0LL);
		    this->fields.m_gachaIV = 0LL;
		    this->fields.m_endGachaIV = 1;
		    this->fields.m_gachaDataPathV3 = (String *)"";
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_gachaDataPathV3, v3, v4, v5, v9);
		  }
		}
		
		public void ReloadCurrentSceneIrradianceVolume() {} // 0x0000000189D02BD8-0x0000000189D02C30
		// Void ReloadCurrentSceneIrradianceVolume()
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadCurrentSceneIrradianceVolume(
		        HGIrradianceVolumeManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1868, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1868, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV3(this, this->fields.m_irradianceDataPathV3, 0LL);
		  }
		}
		
		public void ReloadIndexFileV3(string rootPath) {} // 0x0000000189D02C30-0x0000000189D02D48
		// Void ReloadIndexFileV3(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV3(
		        HGIrradianceVolumeManager *this,
		        String *rootPath,
		        MethodInfo *method)
		{
		  bool v5; // zf
		  unsigned __int64 v6; // r8
		  signed __int64 v7; // rtt
		  unsigned int v8; // ebx
		  unsigned __int64 v9; // rdx
		  char v10; // bl
		  signed __int64 v11; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1869, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1869, 0LL);
		    if ( !Patch )
		      sub_1800D8250(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)rootPath,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_defaultIV )
		    {
		      UnityEngine::HyperGryph::HGIrradianceVolume::Destroy(this->fields.m_defaultIV, 0LL);
		      this->fields.m_defaultIV = 0LL;
		      v5 = dword_18F35FD08 == 0;
		      this->fields.m_lastDataPathV3 = (String *)"";
		      if ( !v5 )
		      {
		        v6 = (((unsigned __int64)&this->fields.m_lastDataPathV3 >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v6 + 36190]);
		        do
		          v7 = qword_18F0BCBA0[v6 + 36190];
		        while ( v7 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v6 + 36190],
		                        v7 | (1LL << (((unsigned __int64)&this->fields.m_lastDataPathV3 >> 12) & 0x3F)),
		                        v7) );
		      }
		    }
		    v5 = dword_18F35FD08 == 0;
		    this->fields.m_irradianceDataPathV3 = rootPath;
		    if ( !v5 )
		    {
		      v8 = ((unsigned __int64)&this->fields.m_irradianceDataPathV3 >> 12) & 0x1FFFFF;
		      v9 = (unsigned __int64)v8 >> 6;
		      v10 = v8 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v9 + 36190]);
		      do
		        v11 = qword_18F0BCBA0[v9 + 36190];
		      while ( v11 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v9 + 36190], v11 | (1LL << v10), v11) );
		    }
		  }
		}
		
		public void GetStateNameList(List<string> stateNameList) {} // 0x0000000183A86BC0-0x0000000183A86C30
		// Void GetStateNameList(List`1[System.String])
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::GetStateNameList(
		        HGIrradianceVolumeManager *this,
		        List_1_System_String_ *stateNameList,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  String__Array *ActiveSceneStateNames; // rdi
		  Object__Array *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1870, 0LL) )
		  {
		    ActiveSceneStateNames = UnityEngine::HyperGryph::HGIrradianceVolume::GetActiveSceneStateNames(0LL);
		    if ( stateNameList )
		    {
		      v8 = System::Collections::Generic::List<System::Object>::ToArray(
		             (List_1_System_Object_ *)stateNameList,
		             MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
		      UnityEngine::HyperGryph::HGIrradianceVolume::SetSceneStateNames((String__Array *)v8, ActiveSceneStateNames, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1870, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)stateNameList,
		    0LL);
		}
		
		[IDTag(0)]
		public void UpdateSceneStateMask(uint mask) {} // 0x00000001845FB500-0x00000001845FB540
		// Void UpdateSceneStateMask(UInt32)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::UpdateSceneStateMask(
		        HGIrradianceVolumeManager *this,
		        uint32_t mask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1871, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1871, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (LoginSceneAnimCtrl_EState__Enum)mask,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolume::SetActiveSceneStateMask(mask, 0LL);
		  }
		}
		
		[IDTag(1)]
		public void UpdateSceneStateMask(List<string> stateMask) {} // 0x0000000189D02ECC-0x0000000189D02F40
		// Void UpdateSceneStateMask(List`1[System.String])
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::UpdateSceneStateMask(
		        HGIrradianceVolumeManager *this,
		        List_1_System_String_ *stateMask,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object__Array *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1872, 0LL) )
		  {
		    if ( stateMask )
		    {
		      v7 = System::Collections::Generic::List<System::Object>::ToArray(
		             (List_1_System_Object_ *)stateMask,
		             MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
		      UnityEngine::HyperGryph::HGIrradianceVolume::SetActiveSceneStateNames((String__Array *)v7, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1872, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)stateMask,
		    0LL);
		}
		
		public void StreamingInNewMap(string indexRootPath) {} // 0x0000000184843F60-0x0000000184843FB0
		// Void StreamingInNewMap(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::StreamingInNewMap(
		        HGIrradianceVolumeManager *this,
		        String *indexRootPath,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1873, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1873, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)indexRootPath,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_exportpathV3 = System::String::Concat(indexRootPath, (String *)"/v3/index.bytes", 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_exportpathV3, v5, v6, v7, v11);
		  }
		}
		
		public void StreamingInCabin(string slotId, uint roomTypeId) {} // 0x0000000189D02D48-0x0000000189D02DC4
		// Void StreamingInCabin(String, UInt32)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::StreamingInCabin(
		        HGIrradianceVolumeManager *this,
		        String *slotId,
		        uint32_t roomTypeId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1874, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1874, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_68(
		      (ILFixDynamicMethodWrapper_19 *)Patch,
		      (Object *)this,
		      (Object *)slotId,
		      (LogType__Enum)roomTypeId,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolume::StreamingInCabin(this->fields.m_defaultIV, slotId, roomTypeId, 0LL);
		  }
		}
		
		public void StreamingOutCabin(string slotId) {} // 0x0000000189D02DC4-0x0000000189D02E28
		// Void StreamingOutCabin(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::StreamingOutCabin(
		        HGIrradianceVolumeManager *this,
		        String *slotId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1875, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1875, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)slotId,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolume::StreamingOutCabin(this->fields.m_defaultIV, slotId, 0LL);
		  }
		}
		
		public void SetBurstMode(bool isBurstMode) {} // 0x0000000182D312A0-0x0000000182D31430
		// Void SetBurstMode(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::SetBurstMode(
		        HGIrradianceVolumeManager *this,
		        bool isBurstMode,
		        MethodInfo *method)
		{
		  bool v4; // bl
		  struct ILFixDynamicMethodWrapper_2__Class *image; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  void (*v7)(void); // rax
		  void (*v8)(void); // rax
		  __int64 v9; // rax
		  __int64 v10; // rax
		
		  v4 = isBurstMode;
		  image = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    image = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = image->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_24;
		  if ( wrapperArray->max_length.size > 1876 )
		  {
		    if ( !image->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(image);
		      image = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    *(_QWORD *)&isBurstMode = image->static_fields->wrapperArray;
		    if ( !isBurstMode )
		      goto LABEL_24;
		    if ( *(_DWORD *)(isBurstMode + 24LL) <= 0x754u )
		      goto LABEL_25;
		    if ( *(_QWORD *)(isBurstMode + 15040LL) )
		    {
		      if ( !image->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(image);
		        image = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      image = (struct ILFixDynamicMethodWrapper_2__Class *)image->static_fields->wrapperArray;
		      if ( !image )
		        goto LABEL_24;
		      if ( LODWORD(image->_0.namespaze) > 0x754 )
		      {
		        image = (struct ILFixDynamicMethodWrapper_2__Class *)image[40]._0.image;
		        if ( image )
		        {
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)image, (Object *)this, v4, 0LL);
		          return;
		        }
		LABEL_24:
		        sub_1800D8250(image, isBurstMode);
		      }
		LABEL_25:
		      sub_1800D2AA0(image, isBurstMode, wrapperArray);
		    }
		  }
		  if ( !v4 )
		  {
		    v7 = (void (*)(void))qword_18F3708D8;
		    if ( !qword_18F3708D8 )
		    {
		      v7 = (void (*)(void))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGIrradianceVolume::DisableBurstMode()");
		      if ( !v7 )
		      {
		        v9 = sub_1802EE1B8("UnityEngine.HyperGryph.HGIrradianceVolume::DisableBurstMode()");
		        sub_18007E1B0(v9, 0LL);
		      }
		      qword_18F3708D8 = (__int64)v7;
		    }
		    goto LABEL_20;
		  }
		  v7 = (void (*)(void))qword_18F3708D0;
		  if ( qword_18F3708D0 )
		  {
		LABEL_20:
		    v7();
		    return;
		  }
		  v8 = (void (*)(void))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGIrradianceVolume::EnableBurstMode()");
		  if ( !v8 )
		  {
		    v10 = sub_1802EE1B8("UnityEngine.HyperGryph.HGIrradianceVolume::EnableBurstMode()");
		    sub_18007E1B0(v10, 0LL);
		  }
		  qword_18F3708D0 = (__int64)v8;
		  v8();
		}
		
		public void SetOverrideStreamingCenterByCamera(bool overrideStreamingCenter) {} // 0x0000000182D31430-0x0000000182D315F0
		// Void SetOverrideStreamingCenterByCamera(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::SetOverrideStreamingCenterByCamera(
		        HGIrradianceVolumeManager *this,
		        bool overrideStreamingCenter,
		        MethodInfo *method)
		{
		  bool v4; // bl
		  struct ILFixDynamicMethodWrapper_2__Class *gc_desc; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		
		  v4 = overrideStreamingCenter;
		  gc_desc = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    gc_desc = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = gc_desc->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_17;
		  if ( wrapperArray->max_length.size > 1877 )
		  {
		    if ( !gc_desc->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(gc_desc);
		      gc_desc = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    *(_QWORD *)&overrideStreamingCenter = gc_desc->static_fields->wrapperArray;
		    if ( !overrideStreamingCenter )
		      goto LABEL_17;
		    if ( *(_DWORD *)(overrideStreamingCenter + 24LL) <= 0x755u )
		      goto LABEL_18;
		    if ( *(_QWORD *)(overrideStreamingCenter + 15048LL) )
		    {
		      if ( !gc_desc->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(gc_desc);
		        gc_desc = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      gc_desc = (struct ILFixDynamicMethodWrapper_2__Class *)gc_desc->static_fields->wrapperArray;
		      if ( !gc_desc )
		        goto LABEL_17;
		      if ( LODWORD(gc_desc->_0.namespaze) > 0x755 )
		      {
		        gc_desc = (struct ILFixDynamicMethodWrapper_2__Class *)gc_desc[40]._0.gc_desc;
		        if ( gc_desc )
		        {
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		            (ILFixDynamicMethodWrapper_18 *)gc_desc,
		            (Object *)this,
		            v4,
		            0LL);
		          return;
		        }
		LABEL_17:
		        sub_1800D8250(gc_desc, overrideStreamingCenter);
		      }
		LABEL_18:
		      sub_1800D2AA0(gc_desc, overrideStreamingCenter, wrapperArray);
		    }
		  }
		  this->fields.m_overrideStreamingCenterByCamera = v4;
		}
		
		public void Release() {} // 0x0000000189D02B4C-0x0000000189D02BD8
		// Void Release()
		void HG::Rendering::Runtime::HGIrradianceVolumeManager::Release(HGIrradianceVolumeManager *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1878, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1878, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields.m_defaultIV )
		    {
		      UnityEngine::HyperGryph::HGIrradianceVolume::Destroy(this->fields.m_defaultIV, 0LL);
		      this->fields.m_defaultIV = 0LL;
		      this->fields.m_lastDataPathV3 = (String *)"";
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_lastDataPathV3, v3, v4, v5, v9);
		    }
		    if ( this->fields.m_gachaIV )
		    {
		      UnityEngine::HyperGryph::HGIrradianceVolume::Destroy(this->fields.m_gachaIV, 0LL);
		      this->fields.m_gachaIV = 0LL;
		    }
		  }
		}
		
	}
}
