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
	public class HGIrradianceVolumeManagerV2 // TypeDefIndex: 37764
	{
		// Fields
		private const string GACHA_IV_PATH = "IrradianceVolume/gacha/index.bytes"; // Metadata: 0x023030C9
		private long m_defaultIV; // 0x10
		private string m_lastDataPathV2; // 0x18
		private string m_irradianceDataPathV2; // 0x20
		private string m_exportpathV2; // 0x28
		private long m_gachaIV; // 0x30
		private bool m_startGachaIV; // 0x38
		private bool m_endGachaIV; // 0x39
		private string m_gachaDataPathV2; // 0x40
		private bool m_debugClipmap; // 0x48
		private bool m_debugClipmapLod0; // 0x49
		private Vector3 m_debugPos; // 0x4C
		private int m_debugFrameCount; // 0x58
	
		// Constructors
		public HGIrradianceVolumeManagerV2() {} // 0x0000000182ED8CC0-0x0000000182ED8D20
		// HGIrradianceVolumeManagerV2()
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::HGIrradianceVolumeManagerV2(
		        HGIrradianceVolumeManagerV2 *this,
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
		  __int64 v10; // r10
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_irradianceDataPathV2 = (String *)"";
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_irradianceDataPathV2, (Type *)method, v2, v3, v11);
		  *(_QWORD *)(v4 + 40) = "";
		  sub_18002D1B0((SingleFieldAccessor *)(v4 + 40), v5, v6, (Int32__Array **)"", v12);
		  *(_QWORD *)(v7 + 64) = "";
		  sub_18002D1B0((SingleFieldAccessor *)(v7 + 64), v8, v9, (Int32__Array **)"", v13);
		  *(_QWORD *)(v10 + 76) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v10 + 84) = 0;
		}
		
	
		// Methods
		public void PipelineUpdateV2(out HGIrradianceVolumePipelineUpdateResultV2 result, ScriptableRenderContext renderContext, Camera primaryCamera, Transform currentPlayerCenter, ComputeShader ivBakeV2CS, ComputeShader ivClipmapUpdateCS) {
			result = default;
		} // 0x0000000183336A30-0x0000000183337EF0
		// Void PipelineUpdateV2(HGIrradianceVolumePipelineUpdateResultV2 ByRef, ScriptableRenderContext, Camera, Transform, ComputeShader, ComputeShader)
		// Hidden C++ exception states: #wind=13
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::PipelineUpdateV2(
		        HGIrradianceVolumeManagerV2 *this,
		        HGIrradianceVolumePipelineUpdateResultV2 *result,
		        ScriptableRenderContext renderContext,
		        Camera *primaryCamera,
		        Transform *currentPlayerCenter,
		        ComputeShader *ivBakeV2CS,
		        ComputeShader *ivClipmapUpdateCS,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v14; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r14
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  Type *v39; // rdx
		  PropertyInfo_1 *v40; // r8
		  Int32__Array **v41; // r9
		  String *m_lastDataPathV2; // r8
		  String *m_irradianceDataPathV2; // rdx
		  int32_t stringLength; // eax
		  __int64 (__fastcall *v45)(_DWORD *); // rax
		  Transform *v46; // r15
		  struct Object_1__Class *v47; // rcx
		  Transform *v48; // rbx
		  Camera *main; // rbx
		  struct Object_1__Class *v50; // rcx
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  Camera *v53; // rbx
		  __int64 (__fastcall *v54)(Camera *); // rax
		  Transform *transform; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  unsigned __int64 v58; // xmm7_8
		  float z; // r13d
		  Camera *v60; // rbx
		  struct Object_1__Class *v61; // rcx
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  Camera *v64; // rbx
		  __int64 (__fastcall *v65)(Camera *); // rax
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  __int64 v68; // rbx
		  void (__fastcall *v69)(__int64, Quaternion *); // rax
		  Vector3 *forward; // rax
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  Transform *v73; // rax
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  int64_t m_defaultIV; // rsi
		  struct HGGraphicsFeatureManager__Class *v77; // rax
		  HGGraphicsFeatureSwitch *irradianceVolumeV2; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v79; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v80; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v81; // rbx
		  ILFixDynamicMethodWrapper_2 *v82; // rax
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  bool m_defaultValue; // al
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  void *v88; // rdx
		  struct ScriptableRenderContext__Class *v89; // rdi
		  void *m_Ptr; // rbx
		  __int64 v91; // rdx
		  int32_t InstanceID; // edi
		  int32_t v93; // eax
		  unsigned int v94; // eax
		  __int64 v95; // rax
		  const char *v96; // rax
		  __int64 v97; // rbx
		  __int64 v98; // r9
		  __int64 v99; // rax
		  Type *v100; // rdx
		  PropertyInfo_1 *v101; // r8
		  __int64 v102; // r9
		  uint32_t v103; // eax
		  bool v104; // cl
		  struct ScriptableRenderContext__Class *v105; // rdi
		  CommandBuffer *v106; // rdi
		  il2cpp_baselib *v107; // rcx
		  struct CommandBufferPool__Class *v108; // r15
		  __int64 CurrentThreadId; // rbx
		  __int64 v110; // rdx
		  __int64 v111; // rax
		  int v112; // r15d
		  const char *v113; // r8
		  __int64 v114; // rbx
		  _QWORD *v115; // r9
		  __int64 v116; // rax
		  Type *v117; // rdx
		  PropertyInfo_1 *v118; // r8
		  __int64 v119; // r9
		  uint32_t v120; // eax
		  bool v121; // cl
		  unsigned int v122; // eax
		  unsigned int v123; // ebx
		  __int64 v124; // rcx
		  __int64 v125; // r15
		  unsigned int v126; // eax
		  __int64 v127; // rdx
		  struct CommandBufferPool__Class *parent; // rbx
		  __int64 i; // r10
		  __int64 v130; // rcx
		  char v131; // al
		  const char *v132; // r8
		  __int64 v133; // rbx
		  _QWORD *v134; // r9
		  __int64 v135; // rax
		  Type *v136; // rdx
		  PropertyInfo_1 *v137; // r8
		  __int64 v138; // r9
		  uint32_t v139; // eax
		  bool v140; // cl
		  unsigned int v141; // eax
		  unsigned int v142; // ebx
		  __int64 v143; // rcx
		  __int64 v144; // rdi
		  unsigned int v145; // eax
		  __int64 v146; // rax
		  __int64 v147; // rax
		  __int64 v148; // rax
		  __int64 Target; // rax
		  __int64 v150; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3c; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3d; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3e; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3f; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3g; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-288h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-288h]
		  unsigned __int8 v159; // [rsp+50h] [rbp-258h] BYREF
		  Vector3 cameraForwardDir; // [rsp+60h] [rbp-248h] BYREF
		  unsigned int v161; // [rsp+70h] [rbp-238h]
		  Vector3 center; // [rsp+80h] [rbp-228h] BYREF
		  CommandBuffer *cmd[2]; // [rsp+90h] [rbp-218h] BYREF
		  Quaternion v164; // [rsp+A0h] [rbp-208h] BYREF
		  unsigned __int64 v165; // [rsp+B8h] [rbp-1F0h]
		  Vector3 id; // [rsp+C0h] [rbp-1E8h] BYREF
		  _QWORD v167[3]; // [rsp+D0h] [rbp-1D8h] BYREF
		  unsigned __int64 v168; // [rsp+E8h] [rbp-1C0h]
		  _DWORD v169[4]; // [rsp+F0h] [rbp-1B8h] BYREF
		  __m128i si128; // [rsp+100h] [rbp-1A8h]
		  __m128i v171; // [rsp+110h] [rbp-198h]
		  __m128i v172; // [rsp+120h] [rbp-188h]
		  int v173; // [rsp+130h] [rbp-178h]
		  int v174; // [rsp+134h] [rbp-174h]
		  int v175; // [rsp+138h] [rbp-170h]
		  int v176; // [rsp+13Ch] [rbp-16Ch]
		  int v177; // [rsp+140h] [rbp-168h]
		  int v178; // [rsp+144h] [rbp-164h]
		  int v179; // [rsp+148h] [rbp-160h]
		  int v180; // [rsp+14Ch] [rbp-15Ch]
		  int v181; // [rsp+150h] [rbp-158h]
		  int v182; // [rsp+154h] [rbp-154h]
		  int v183; // [rsp+158h] [rbp-150h]
		  int v184; // [rsp+15Ch] [rbp-14Ch]
		  __int64 v185; // [rsp+160h] [rbp-148h]
		  int v186; // [rsp+168h] [rbp-140h]
		  int v187; // [rsp+16Ch] [rbp-13Ch]
		  __m128i v188; // [rsp+170h] [rbp-138h]
		  __m128i v189; // [rsp+180h] [rbp-128h]
		  __int64 v190; // [rsp+190h] [rbp-118h]
		  int v191; // [rsp+198h] [rbp-110h]
		  int v192; // [rsp+19Ch] [rbp-10Ch]
		  int v193; // [rsp+1A0h] [rbp-108h]
		  __int64 v194; // [rsp+1A4h] [rbp-104h]
		  int v195; // [rsp+1ACh] [rbp-FCh]
		  int v196; // [rsp+1B0h] [rbp-F8h]
		  int v197; // [rsp+1B4h] [rbp-F4h]
		  int v198; // [rsp+1B8h] [rbp-F0h]
		  __int64 v199; // [rsp+1BCh] [rbp-ECh]
		  int v200; // [rsp+1C4h] [rbp-E4h]
		  int v201; // [rsp+1C8h] [rbp-E0h]
		  int v202; // [rsp+1CCh] [rbp-DCh]
		  int v203; // [rsp+1D0h] [rbp-D8h]
		  __int64 v204; // [rsp+1D4h] [rbp-D4h]
		  int v205; // [rsp+1DCh] [rbp-CCh]
		  int v206; // [rsp+1E0h] [rbp-C8h]
		  int v207; // [rsp+1E4h] [rbp-C4h]
		  int v208; // [rsp+1E8h] [rbp-C0h]
		  __int64 v209; // [rsp+1ECh] [rbp-BCh]
		  int v210; // [rsp+1F4h] [rbp-B4h]
		  int v211; // [rsp+1F8h] [rbp-B0h]
		  int v212; // [rsp+1FCh] [rbp-ACh]
		  int v213; // [rsp+200h] [rbp-A8h]
		  int v214; // [rsp+204h] [rbp-A4h]
		  int v215; // [rsp+208h] [rbp-A0h]
		  int v216; // [rsp+20Ch] [rbp-9Ch]
		  int v217; // [rsp+210h] [rbp-98h]
		  int v218; // [rsp+214h] [rbp-94h]
		  int v219; // [rsp+218h] [rbp-90h]
		  int v220; // [rsp+21Ch] [rbp-8Ch]
		  int v221; // [rsp+220h] [rbp-88h]
		  int v222; // [rsp+224h] [rbp-84h]
		  Il2CppExceptionWrapper *v223; // [rsp+230h] [rbp-78h] BYREF
		  _BYTE v224[72]; // [rsp+238h] [rbp-70h] BYREF
		  ScriptableRenderContext P2; // [rsp+2C0h] [rbp+18h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  v161 = 0;
		  sub_18033B9D0(v169, 0LL, 312LL);
		  v159 = 0;
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v12, v11);
		  if ( wrapperArray->max_length.size > 673 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v14 = v12->static_fields->wrapperArray;
		    if ( !v14 )
		      sub_1800D8260(v12, v11);
		    if ( v14->max_length.size <= 0x2A1u )
		      sub_1800D2AB0(v12, v11);
		    if ( v14[18].vector[25] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(673, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v16, v15);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_264(
		        Patch,
		        (Object *)this,
		        result,
		        P2,
		        (Object *)primaryCamera,
		        (Object *)currentPlayerCenter,
		        (Object *)ivBakeV2CS,
		        (Object *)ivClipmapUpdateCS,
		        0LL);
		      return;
		    }
		  }
		  result->param0 = 0LL;
		  result->param1 = 0LL;
		  result->param2 = 0LL;
		  result->param3 = 0LL;
		  result->clipmapTextureALod0 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureALod0, v18, v19, v20, P3);
		  result->clipmapTextureBLod0 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureBLod0, v21, v22, v23, P3c);
		  result->clipmapTextureALod1 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureALod1, v24, v25, v26, P3d);
		  result->clipmapTextureBLod1 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureBLod1, v27, v28, v29, P3e);
		  result->clipmapTextureALod3 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureALod3, v30, v31, v32, P3f);
		  result->clipmapTextureBLod3 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&result->clipmapTextureBLod3, v33, v34, v35, P3g);
		  if ( this->fields.m_defaultIV )
		  {
		    this->fields.m_irradianceDataPathV2 = (String *)"";
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_irradianceDataPathV2, v36, v37, v38, P3a);
		    if ( this->fields.m_exportpathV2 )
		    {
		      this->fields.m_irradianceDataPathV2 = this->fields.m_exportpathV2;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_irradianceDataPathV2, v39, v40, v41, P3a);
		    }
		    m_lastDataPathV2 = this->fields.m_lastDataPathV2;
		    m_irradianceDataPathV2 = this->fields.m_irradianceDataPathV2;
		    if ( m_lastDataPathV2 != m_irradianceDataPathV2 )
		    {
		      if ( !m_lastDataPathV2
		        || !m_irradianceDataPathV2
		        || (stringLength = m_lastDataPathV2->fields._stringLength,
		            stringLength != m_irradianceDataPathV2->fields._stringLength)
		        || !System::SpanHelpers::SequenceEqual(
		              (uint8_t *)&m_lastDataPathV2->fields._firstChar,
		              (uint8_t *)&m_irradianceDataPathV2->fields._firstChar,
		              2LL * stringLength,
		              0LL) )
		      {
		        this->fields.m_lastDataPathV2 = this->fields.m_irradianceDataPathV2;
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields.m_lastDataPathV2,
		          (Type *)m_irradianceDataPathV2,
		          (PropertyInfo_1 *)m_lastDataPathV2,
		          v41,
		          P3a);
		        UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetMap(
		          this->fields.m_defaultIV,
		          this->fields.m_irradianceDataPathV2,
		          0LL);
		      }
		    }
		  }
		  else
		  {
		    v169[0] = 0;
		    v169[1] = 128;
		    v169[2] = 64;
		    v169[3] = 128;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18DC811E0);
		    v171 = _mm_load_si128((const __m128i *)&xmmword_18DC811D0);
		    v172 = _mm_load_si128((const __m128i *)&xmmword_18DC811B0);
		    v173 = 6;
		    v174 = 27;
		    v178 = 8;
		    v179 = 64;
		    v180 = 128;
		    v175 = 8;
		    v176 = 128;
		    v177 = 128;
		    v181 = 5;
		    v182 = 13;
		    v183 = 2048;
		    v184 = 52;
		    v185 = 288LL;
		    v186 = 1;
		    v187 = 3;
		    v188 = _mm_load_si128((const __m128i *)&xmmword_18DC811A0);
		    v189 = _mm_load_si128((const __m128i *)&xmmword_18DC811C0);
		    v190 = 17LL;
		    v193 = 144;
		    v194 = 144LL;
		    v191 = 144;
		    v192 = 288;
		    v198 = 9216;
		    v199 = 9216LL;
		    v195 = 0;
		    v196 = 9216;
		    v197 = 18432;
		    v203 = 256;
		    v204 = 256LL;
		    v200 = 0;
		    v201 = 256;
		    v202 = 512;
		    v208 = 256;
		    v209 = 256LL;
		    v205 = 0;
		    v206 = 256;
		    v207 = 512;
		    v210 = 0x100000;
		    v211 = 0x100000;
		    v212 = 0x100000;
		    v213 = 4;
		    v214 = 4;
		    v215 = 8;
		    v216 = 8;
		    v217 = 80;
		    v218 = 40;
		    v219 = 80;
		    v220 = 1098907648;
		    v221 = 1115684864;
		    v222 = 1132462080;
		    v45 = (__int64 (__fastcall *)(_DWORD *))qword_18F370910;
		    if ( !qword_18F370910 )
		    {
		      v45 = (__int64 (__fastcall *)(_DWORD *))il2cpp_resolve_icall_1(
		                                                "UnityEngine.HyperGryph.HGIrradianceVolumeV2::Create(UnityEngine.HyperGry"
		                                                "ph.HGIrradianceVolumeConfigV2&)");
		      if ( !v45 )
		      {
		        v147 = sub_1802EE1B8(
		                 "UnityEngine.HyperGryph.HGIrradianceVolumeV2::Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2&)");
		        sub_18007E1B0(v147, 0LL);
		      }
		      qword_18F370910 = (__int64)v45;
		    }
		    this->fields.m_defaultIV = v45(v169);
		  }
		  v46 = 0LL;
		  if ( !this->fields.m_gachaIV )
		  {
		    v47 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v47 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v47 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    v48 = currentPlayerCenter;
		    if ( currentPlayerCenter )
		    {
		      if ( !v47->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v47);
		      if ( v48->fields._._.m_CachedPtr )
		      {
		        v46 = v48;
		        goto LABEL_52;
		      }
		    }
		  }
		  main = UnityEngine::Camera::get_main(0LL);
		  v50 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v50 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v50 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( main )
		  {
		    if ( !v50->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v50);
		      v50 = TypeInfo::UnityEngine::Object;
		    }
		    if ( main->fields._._._.m_CachedPtr )
		    {
		      v53 = UnityEngine::Camera::get_main(0LL);
		      if ( !v53 )
		        sub_1800D8260(v52, v51);
		      v54 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v54 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v54;
		      }
		      transform = (Transform *)v54(v53);
		LABEL_51:
		      v46 = transform;
		      goto LABEL_52;
		    }
		  }
		  if ( !v50->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v50);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  }
		  if ( !UnityEngine::Object::CompareBaseObjects((Object_1 *)primaryCamera, 0LL, 0LL) )
		  {
		    if ( !primaryCamera )
		      sub_1800D8260(v57, v56);
		    transform = UnityEngine::Component::get_transform((Component *)primaryCamera, 0LL);
		    goto LABEL_51;
		  }
		LABEL_52:
		  v58 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)0LL));
		  v60 = UnityEngine::Camera::get_main(0LL);
		  v61 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v61 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v61 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v60 )
		  {
		    if ( !v61->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v61);
		      v61 = TypeInfo::UnityEngine::Object;
		    }
		    if ( v60->fields._._._.m_CachedPtr )
		    {
		      v64 = UnityEngine::Camera::get_main(0LL);
		      if ( !v64 )
		        sub_1800D8260(v63, v62);
		      v65 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v65 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v65;
		      }
		      v68 = v65(v64);
		      if ( !v68 )
		        sub_1800D8260(v67, v66);
		      v164 = 0LL;
		      v69 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		      if ( !qword_18F370110 )
		      {
		        v69 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		        if ( !v69 )
		        {
		          v148 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		          sub_18007E1B0(v148, 0LL);
		        }
		        qword_18F370110 = (__int64)v69;
		      }
		      v69(v68, &v164);
		      *(_QWORD *)&center.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      center.z = 1.0;
		      forward = UnityEngine::Quaternion::op_Multiply(&id, &v164, &center, 0LL);
		LABEL_74:
		      z = forward->z;
		      v58 = *(_QWORD *)&forward->x;
		      goto LABEL_75;
		    }
		  }
		  if ( !v61->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v61);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  }
		  if ( !UnityEngine::Object::CompareBaseObjects((Object_1 *)primaryCamera, 0LL, 0LL) )
		  {
		    if ( !primaryCamera )
		      sub_1800D8260(v72, v71);
		    v73 = UnityEngine::Component::get_transform((Component *)primaryCamera, 0LL);
		    if ( !v73 )
		      sub_1800D8260(v75, v74);
		    forward = UnityEngine::Transform::get_forward(&center, v73, 0LL);
		    goto LABEL_74;
		  }
		LABEL_75:
		  m_defaultIV = this->fields.m_defaultIV;
		  *(_QWORD *)&id.x = m_defaultIV;
		  v77 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		    v77 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		  }
		  irradianceVolumeV2 = v77->static_fields->irradianceVolumeV2;
		  if ( !irradianceVolumeV2 )
		    sub_1800D8260(v72, v71);
		  v79 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v79 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v80 = v79->static_fields->wrapperArray;
		  if ( !v80 )
		    sub_1800D8260(v79, v71);
		  if ( v80->max_length.size <= 412 )
		    goto LABEL_89;
		  if ( !v79->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v79);
		    v79 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v81 = v79->static_fields->wrapperArray;
		  if ( !v81 )
		    sub_1800D8260(v79, v71);
		  if ( v81->max_length.size <= 0x19Cu )
		    sub_1800D2AB0(v79, v71);
		  if ( v81[11].vector[16] )
		  {
		    v82 = IFix::WrappersManagerImpl::GetPatch(412, 0LL);
		    if ( !v82 )
		      sub_1800D8260(v84, v83);
		    m_defaultValue = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                       (ILFixDynamicMethodWrapper_20 *)v82,
		                       (Object *)irradianceVolumeV2,
		                       0LL);
		  }
		  else
		  {
		LABEL_89:
		    m_defaultValue = irradianceVolumeV2->fields.m_defaultValue;
		  }
		  if ( m_defaultValue )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		    cmd[0] = UnityEngine::Rendering::CommandBufferPool::Get((String *)"", 0LL);
		    if ( m_defaultIV )
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality((Object_1 *)v46, 0LL, 0LL) )
		      {
		        if ( !v46 )
		          sub_1800D8260(v87, v86);
		        center = *UnityEngine::Transform::get_position(&cameraForwardDir, v46, 0LL);
		        UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetStreamingCenter_Injected(m_defaultIV, &center, 0LL);
		        *(_QWORD *)&cameraForwardDir.x = v58;
		        cameraForwardDir.z = z;
		        UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetCameraForwardDirection_Injected(
		          m_defaultIV,
		          &cameraForwardDir,
		          0LL);
		      }
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0xC5u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      *(_QWORD *)&v164.x = 0LL;
		      *(_QWORD *)&v164.z = &v159;
		      try
		      {
		        v89 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
		        if ( TypeInfo::UnityEngine::Rendering::ScriptableRenderContext->_1.cctor_finished_or_no_cctor )
		          goto LABEL_103;
		        sub_1802DEE10(&qword_18F371A70);
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v89->_1.cctor_finished_or_no_cctor, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		LABEL_103:
		          m_Ptr = P2.m_Ptr;
		          if ( !ivBakeV2CS )
		            sub_1800D8250(0LL, v88);
		          InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)ivBakeV2CS, 0LL);
		          if ( !ivClipmapUpdateCS )
		            sub_1800D8250(0LL, v91);
		          v93 = UnityEngine::Object::GetInstanceID((Object_1 *)ivClipmapUpdateCS, 0LL);
		          UnityEngine::HyperGryph::HGIrradianceVolumeV2::PipelineUpdate(
		            result,
		            *(int64_t *)&id.x,
		            m_Ptr,
		            cmd[0],
		            InstanceID,
		            v93,
		            0LL);
		          goto LABEL_238;
		        }
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v89->_1.cctor_started, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		          v94 = ((__int64 (*)(void))GetCurrentThreadId)();
		          if ( v94 == _InterlockedCompareExchange64((volatile signed __int64 *)&v89->_1.cctor_thread, v94, v94) )
		            goto LABEL_103;
		          while ( _InterlockedCompareExchange((volatile signed __int32 *)&v89->_1.cctor_finished_or_no_cctor, 1, 1) != 1
		               && !_InterlockedCompareExchange(
		                     (volatile signed __int32 *)&v89->_1.initializationExceptionGCHandle,
		                     0,
		                     0) )
		            sub_1800717D0(1LL, 0LL);
		        }
		        else
		        {
		          _InterlockedExchange64(
		            (volatile __int64 *)&v89->_1.cctor_thread,
		            (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
		          _InterlockedExchange((volatile __int32 *)&v89->_1.cctor_started, 1);
		          sub_1802DEE70(&qword_18F371A70);
		          *(_QWORD *)&cameraForwardDir.x = 0LL;
		          if ( (BYTE1(v89->vtable.Equals.methodPtr) & 4) != 0 )
		          {
		            v95 = sub_1800097A0((_DWORD)v89, (unsigned int)".cctor", -1, 2048, 0LL);
		            if ( v95 )
		              il2cpp_runtime_invoke_0(v95, 0LL, 0LL, &cameraForwardDir);
		          }
		          _InterlockedExchange64((volatile __int64 *)&v89->_1.cctor_thread, 0LL);
		          if ( *(_QWORD *)&cameraForwardDir.x )
		          {
		            sub_1800306E0(v167);
		            v161 = 1;
		            sub_18005B130(v167, &v89->_0.byval_arg, 0LL, 0LL);
		            v96 = (const char *)sub_18002A970(v167);
		            sub_18005AD90(v224, "The type initializer for '%s' threw an exception.", v96);
		            v161 = 0;
		            sub_18002A8F0(v167);
		            v97 = *(_QWORD *)&cameraForwardDir.x;
		            v98 = sub_18002A970(v224);
		            v99 = il2cpp_exception_from_name_msg_1(qword_18F35FF60, "System", "TypeInitializationException", v98);
		            v102 = v99;
		            if ( v97 )
		            {
		              *(_QWORD *)(v99 + 40) = v97;
		              sub_18002D1B0((SingleFieldAccessor *)(v99 + 40), v100, v101, (Int32__Array **)v99, P3a);
		            }
		            v103 = sub_18030A120(&qword_18E7B56A0, v102, 0LL);
		            v89->_1.initializationExceptionGCHandle = v103;
		            v104 = ((__int64)v89->vtable.Equals.methodPtr & 2) != 0 && !v103;
		            LOBYTE(v89->vtable.Equals.methodPtr) = v104 | (__int64)v89->vtable.Equals.methodPtr & 0xFE;
		            sub_18002A8F0(v224);
		          }
		          else
		          {
		            _InterlockedExchange((volatile __int32 *)&v89->_1.cctor_finished_or_no_cctor, 1);
		          }
		        }
		        if ( v89->_1.initializationExceptionGCHandle )
		        {
		          Target = System::Runtime::InteropServices::GCHandle::GetTarget(
		                     (System::Runtime::InteropServices::GCHandle *)v89->_1.initializationExceptionGCHandle,
		                     v88);
		          sub_18007E1B0(Target, 0LL);
		        }
		        goto LABEL_103;
		      }
		      catch ( Il2CppExceptionWrapper *v223 )
		      {
		        *(Il2CppExceptionWrapper *)&v164.x = (Il2CppExceptionWrapper)v223->ex;
		        if ( *(_QWORD *)&v164.x )
		          sub_18007E1E0(*(_QWORD *)&v164.x);
		      }
		LABEL_238:
		      v105 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
		      if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext->_1.cctor_finished_or_no_cctor )
		      {
		        sub_1802DEE10(&qword_18F371A70);
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v105->_1.cctor_finished_or_no_cctor, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		          goto LABEL_129;
		        }
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v105->_1.cctor_started, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		          v122 = ((__int64 (*)(void))GetCurrentThreadId)();
		          if ( v122 == _InterlockedCompareExchange64((volatile signed __int64 *)&v105->_1.cctor_thread, v122, v122) )
		            goto LABEL_129;
		          while ( _InterlockedCompareExchange((volatile signed __int32 *)&v105->_1.cctor_finished_or_no_cctor, 1, 1) != 1
		               && !_InterlockedCompareExchange(
		                     (volatile signed __int32 *)&v105->_1.initializationExceptionGCHandle,
		                     0,
		                     0) )
		          {
		            v123 = 1;
		            v124 = qword_18F371E50;
		            while ( 1 )
		            {
		              if ( !v124 )
		                QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18F371E50);
		              QueryPerformanceCounter((LARGE_INTEGER *)&id);
		              v125 = 1000LL * *(_QWORD *)&id.x / qword_18F371E50;
		              if ( (unsigned int)((__int64 (__fastcall *)(_QWORD, _QWORD))SleepEx)(v123, 0LL) != 192 )
		                break;
		              if ( !qword_18F371E50 )
		                QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18F371E50);
		              QueryPerformanceCounter((LARGE_INTEGER *)&center);
		              v124 = qword_18F371E50;
		              v110 = 1000LL * *(_QWORD *)&center.x % qword_18F371E50;
		              v126 = 1000LL * *(_QWORD *)&center.x / qword_18F371E50 - v125;
		              if ( v126 >= v123 )
		                break;
		              v123 -= v126;
		            }
		          }
		        }
		        else
		        {
		          _InterlockedExchange64(
		            (volatile __int64 *)&v105->_1.cctor_thread,
		            (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
		          _InterlockedExchange((volatile __int32 *)&v105->_1.cctor_started, 1);
		          sub_1802DEE70(&qword_18F371A70);
		          *(_QWORD *)&cameraForwardDir.x = 0LL;
		          if ( (BYTE1(v105->vtable.Equals.methodPtr) & 4) != 0 )
		          {
		            v111 = sub_1800097A0((_DWORD)v105, (unsigned int)".cctor", -1, 2048, 0LL);
		            if ( v111 )
		              il2cpp_runtime_invoke_0(v111, 0LL, 0LL, &cameraForwardDir);
		          }
		          _InterlockedExchange64((volatile __int64 *)&v105->_1.cctor_thread, 0LL);
		          if ( *(_QWORD *)&cameraForwardDir.x )
		          {
		            sub_18002B3C0(&v164, v159);
		            sub_180030700(&v164);
		            v112 = v161 | 2;
		            v161 |= 2u;
		            sub_18005B130(&v164, &v105->_0.byval_arg, 0LL, 0LL);
		            v113 = (const char *)&v164;
		            if ( v165 > 0xF )
		              v113 = *(const char **)&v164.x;
		            sub_18005AD90(v167, "The type initializer for '%s' threw an exception.", v113);
		            v161 = v112 & 0xFFFFFFFD;
		            sub_18002A8F0(&v164);
		            v114 = *(_QWORD *)&cameraForwardDir.x;
		            v115 = v167;
		            if ( v168 > 0xF )
		              v115 = (_QWORD *)v167[0];
		            v116 = il2cpp_exception_from_name_msg_1(qword_18F35FF60, "System", "TypeInitializationException", v115);
		            v119 = v116;
		            if ( v114 )
		            {
		              *(_QWORD *)(v116 + 40) = v114;
		              sub_18002D1B0((SingleFieldAccessor *)(v116 + 40), v117, v118, (Int32__Array **)v116, P3b);
		            }
		            v120 = sub_18030A120(&qword_18E7B56A0, v119, 0LL);
		            v105->_1.initializationExceptionGCHandle = v120;
		            v121 = ((__int64)v105->vtable.Equals.methodPtr & 2) != 0 && !v120;
		            LOBYTE(v105->vtable.Equals.methodPtr) = v121 | (__int64)v105->vtable.Equals.methodPtr & 0xFE;
		            sub_18002A8F0(v167);
		          }
		          else
		          {
		            _InterlockedExchange((volatile __int32 *)&v105->_1.cctor_finished_or_no_cctor, 1);
		          }
		        }
		        if ( v105->_1.initializationExceptionGCHandle )
		        {
		          v150 = System::Runtime::InteropServices::GCHandle::GetTarget(
		                   (System::Runtime::InteropServices::GCHandle *)v105->_1.initializationExceptionGCHandle,
		                   (void *)v110);
		          sub_18007E1B0(v150, 0LL);
		        }
		      }
		LABEL_129:
		      v106 = cmd[0];
		      UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P2, cmd[0], 0LL);
		      v108 = TypeInfo::UnityEngine::Rendering::CommandBufferPool;
		      if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool->_1.cctor_finished_or_no_cctor )
		      {
		        CurrentThreadId = il2cpp_baselib::Baselib_Thread_GetCurrentThreadId(v107);
		        if ( CurrentThreadId == qword_18F371AB8 )
		        {
		          ++dword_18F371AC0;
		        }
		        else
		        {
		          sub_1802DED90(&qword_18F371A70);
		          qword_18F371AB8 = CurrentThreadId;
		          dword_18F371AC0 = 1;
		        }
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v108->_1.cctor_finished_or_no_cctor, 1, 1) != 1 )
		        {
		          if ( _InterlockedCompareExchange((volatile signed __int32 *)&v108->_1.cctor_started, 1, 1) == 1 )
		          {
		            sub_1802DEE70(&qword_18F371A70);
		            v141 = ((__int64 (*)(void))GetCurrentThreadId)();
		            if ( v141 == _InterlockedCompareExchange64((volatile signed __int64 *)&v108->_1.cctor_thread, v141, v141) )
		              goto LABEL_165;
		            while ( _InterlockedCompareExchange((volatile signed __int32 *)&v108->_1.cctor_finished_or_no_cctor, 1, 1) != 1
		                 && !_InterlockedCompareExchange(
		                       (volatile signed __int32 *)&v108->_1.initializationExceptionGCHandle,
		                       0,
		                       0) )
		            {
		              v142 = 1;
		              v143 = qword_18F371E50;
		              while ( 1 )
		              {
		                if ( !v143 )
		                  QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18F371E50);
		                QueryPerformanceCounter((LARGE_INTEGER *)&center);
		                v144 = 1000LL * *(_QWORD *)&center.x / qword_18F371E50;
		                if ( (unsigned int)((__int64 (__fastcall *)(_QWORD, _QWORD))SleepEx)(v142, 0LL) != 192 )
		                  break;
		                if ( !qword_18F371E50 )
		                  QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18F371E50);
		                QueryPerformanceCounter((LARGE_INTEGER *)&id);
		                v143 = qword_18F371E50;
		                v127 = 1000LL * *(_QWORD *)&id.x % qword_18F371E50;
		                v145 = 1000LL * *(_QWORD *)&id.x / qword_18F371E50 - v144;
		                if ( v145 >= v142 )
		                  break;
		                v142 -= v145;
		              }
		            }
		            v106 = cmd[0];
		          }
		          else
		          {
		            _InterlockedExchange64(
		              (volatile __int64 *)&v108->_1.cctor_thread,
		              (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
		            _InterlockedExchange((volatile __int32 *)&v108->_1.cctor_started, 1);
		            if ( dword_18F371AC0 > 0 )
		            {
		              if ( dword_18F371AC0 == 1 )
		              {
		                qword_18F371AB8 = 0LL;
		                dword_18F371AC0 = 0;
		                sub_1802DEDB0(&qword_18F371A70, 1LL);
		              }
		              else
		              {
		                --dword_18F371AC0;
		              }
		            }
		            *(_QWORD *)&cameraForwardDir.x = 0LL;
		            if ( (BYTE1(v108->vtable.Equals.methodPtr) & 4) != 0 )
		            {
		              parent = v108;
		              if ( ((__int64)v108->vtable.Equals.methodPtr & 2) == 0 )
		              {
		                cmd[0] = (CommandBuffer *)&qword_18F360A90;
		                sub_1802DEE10(&qword_18F360A90);
		                sub_18004C730(v108, cmd);
		                sub_1802DEE70(cmd[0]);
		              }
		              do
		              {
		                cmd[0] = 0LL;
		                for ( i = mono_class_get_methods_0(parent, cmd); i; i = mono_class_get_methods_0(parent, cmd) )
		                {
		                  if ( **(_BYTE **)(i + 24) == 46 && (*(_WORD *)(i + 76) & 0x800) != 0 )
		                  {
		                    v130 = 0LL;
		                    v127 = *(_QWORD *)(i + 24);
		                    while ( 1 )
		                    {
		                      v131 = aCctor[v130++];
		                      if ( v131 != *(_BYTE *)(v127 + v130 - 1) )
		                        break;
		                      if ( v130 == 7 )
		                        goto LABEL_184;
		                    }
		                  }
		                }
		                parent = (struct CommandBufferPool__Class *)parent->_0.parent;
		              }
		              while ( parent );
		              i = 0LL;
		LABEL_184:
		              if ( i )
		                il2cpp_runtime_invoke_0(i, 0LL, 0LL, &cameraForwardDir);
		            }
		            _InterlockedExchange64((volatile __int64 *)&v108->_1.cctor_thread, 0LL);
		            if ( *(_QWORD *)&cameraForwardDir.x )
		            {
		              sub_18002B3C0(&v164, v127);
		              sub_180030700(&v164);
		              v161 |= 4u;
		              sub_18005B130(&v164, &v108->_0.byval_arg, 0LL, 0LL);
		              v132 = (const char *)&v164;
		              if ( v165 > 0xF )
		                v132 = *(const char **)&v164.x;
		              sub_18005AD90(v167, "The type initializer for '%s' threw an exception.", v132);
		              sub_18002A8F0(&v164);
		              v133 = *(_QWORD *)&cameraForwardDir.x;
		              v134 = v167;
		              if ( v168 > 0xF )
		                v134 = (_QWORD *)v167[0];
		              v135 = il2cpp_exception_from_name_msg_1(qword_18F35FF60, "System", "TypeInitializationException", v134);
		              v138 = v135;
		              if ( v133 )
		              {
		                *(_QWORD *)(v135 + 40) = v133;
		                sub_18002D1B0((SingleFieldAccessor *)(v135 + 40), v136, v137, (Int32__Array **)v135, P3b);
		              }
		              v139 = sub_18030A120(&qword_18E7B56A0, v138, 0LL);
		              v108->_1.initializationExceptionGCHandle = v139;
		              v140 = ((__int64)v108->vtable.Equals.methodPtr & 2) != 0 && !v139;
		              LOBYTE(v108->vtable.Equals.methodPtr) = v140 | (__int64)v108->vtable.Equals.methodPtr & 0xFE;
		              sub_18002A8F0(v167);
		            }
		            else
		            {
		              _InterlockedExchange((volatile __int32 *)&v108->_1.cctor_finished_or_no_cctor, 1);
		            }
		          }
		          if ( v108->_1.initializationExceptionGCHandle )
		          {
		            v146 = System::Runtime::InteropServices::GCHandle::GetTarget(
		                     (System::Runtime::InteropServices::GCHandle *)v108->_1.initializationExceptionGCHandle,
		                     (void *)v127);
		            sub_18007E1B0(v146, 0LL);
		          }
		          goto LABEL_165;
		        }
		        sub_1802DEE70(&qword_18F371A70);
		      }
		LABEL_165:
		      UnityEngine::Rendering::CommandBufferPool::Release(v106, 0LL);
		    }
		  }
		}
		
		public void ReloadIndexFileV2(string rootPath) {} // 0x0000000189D025A0-0x0000000189D0260C
		// Void ReloadIndexFileV2(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReloadIndexFileV2(
		        HGIrradianceVolumeManagerV2 *this,
		        String *rootPath,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1879, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1879, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)rootPath,
		      0LL);
		  }
		  else if ( this->fields.m_defaultIV )
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetMap(this->fields.m_defaultIV, rootPath, 0LL);
		  }
		}
		
		public void GetStateNameListV2(List<string> stateNameList) {} // 0x0000000183A86AC0-0x0000000183A86B30
		// Void GetStateNameListV2(List`1[System.String])
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::GetStateNameListV2(
		        HGIrradianceVolumeManagerV2 *this,
		        List_1_System_String_ *stateNameList,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  String__Array *ActiveSceneStateNames; // rdi
		  Object__Array *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1880, 0LL) )
		  {
		    ActiveSceneStateNames = UnityEngine::HyperGryph::HGIrradianceVolumeV2::GetActiveSceneStateNames(0LL);
		    if ( stateNameList )
		    {
		      v8 = System::Collections::Generic::List<System::Object>::ToArray(
		             (List_1_System_Object_ *)stateNameList,
		             MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
		      UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetSceneStateNames((String__Array *)v8, ActiveSceneStateNames, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1880, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)stateNameList,
		    0LL);
		}
		
		[IDTag(0)]
		public void UpdateSceneStateMaskV2(uint stateMask) {} // 0x00000001845FB580-0x00000001845FB5C0
		// Void UpdateSceneStateMaskV2(UInt32)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::UpdateSceneStateMaskV2(
		        HGIrradianceVolumeManagerV2 *this,
		        uint32_t stateMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1881, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1881, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (LoginSceneAnimCtrl_EState__Enum)stateMask,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetActiveSceneStateMask(stateMask, 0LL);
		  }
		}
		
		[IDTag(1)]
		public void UpdateSceneStateMaskV2(List<string> curSceneStateMask) {} // 0x0000000189D02858-0x0000000189D028CC
		// Void UpdateSceneStateMaskV2(List`1[System.String])
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::UpdateSceneStateMaskV2(
		        HGIrradianceVolumeManagerV2 *this,
		        List_1_System_String_ *curSceneStateMask,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object__Array *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1882, 0LL) )
		  {
		    if ( curSceneStateMask )
		    {
		      v7 = System::Collections::Generic::List<System::Object>::ToArray(
		             (List_1_System_Object_ *)curSceneStateMask,
		             MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
		      UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetActiveSceneStateNames((String__Array *)v7, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1882, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)curSceneStateMask,
		    0LL);
		}
		
		public void StreamingInCabin(long slotId, uint roomTypeId) {} // 0x0000000189D02674-0x0000000189D026F0
		// Void StreamingInCabin(Int64, UInt32)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingInCabin(
		        HGIrradianceVolumeManagerV2 *this,
		        int64_t slotId,
		        uint32_t roomTypeId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1883, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1883, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_21(
		      (ILFixDynamicMethodWrapper_17 *)Patch,
		      (Object *)this,
		      slotId,
		      roomTypeId,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolumeV2::StreamingInCabin(this->fields.m_defaultIV, slotId, roomTypeId, 0LL);
		  }
		}
		
		public void StreamingOutCabin(long slotId) {} // 0x0000000189D02744-0x0000000189D027A8
		// Void StreamingOutCabin(Int64)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingOutCabin(
		        HGIrradianceVolumeManagerV2 *this,
		        int64_t slotId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1884, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1884, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_6(
		      (ILFixDynamicMethodWrapper_16 *)Patch,
		      (Object *)this,
		      (void *)slotId,
		      0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolumeV2::StreamingOutCabin(this->fields.m_defaultIV, slotId, 0LL);
		  }
		}
		
		public void StreamingInCabinV3(string slotId, uint roomTypeId) {} // 0x0000000189D0260C-0x0000000189D02674
		// Void StreamingInCabinV3(String, UInt32)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingInCabinV3(
		        HGIrradianceVolumeManagerV2 *this,
		        String *slotId,
		        uint32_t roomTypeId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1885, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1885, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_68(
		      (ILFixDynamicMethodWrapper_19 *)Patch,
		      (Object *)this,
		      (Object *)slotId,
		      (LogType__Enum)roomTypeId,
		      0LL);
		  }
		}
		
		public void StreamingOutCabinV3(string slotId) {} // 0x0000000189D026F0-0x0000000189D02744
		// Void StreamingOutCabinV3(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingOutCabinV3(
		        HGIrradianceVolumeManagerV2 *this,
		        String *slotId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1886, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1886, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)slotId,
		      0LL);
		  }
		}
		
		public void StreamingInNewMapV2(string indexRootPath) {} // 0x0000000184843FB0-0x0000000184844000
		// Void StreamingInNewMapV2(String)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingInNewMapV2(
		        HGIrradianceVolumeManagerV2 *this,
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1887, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1887, 0LL);
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
		    this->fields.m_exportpathV2 = System::String::Concat(indexRootPath, (String *)"/aiTest/index.bytes", 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_exportpathV2, v5, v6, v7, v11);
		  }
		}
		
		public void ReleaseV2() {} // 0x0000000189D0252C-0x0000000189D025A0
		// Void ReleaseV2()
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReleaseV2(
		        HGIrradianceVolumeManagerV2 *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1888, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1888, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_defaultIV )
		  {
		    UnityEngine::HyperGryph::HGIrradianceVolumeV2::Destroy(this->fields.m_defaultIV, 0LL);
		    this->fields.m_defaultIV = 0LL;
		    this->fields.m_lastDataPathV2 = (String *)"";
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_lastDataPathV2, v3, v4, v5, v9);
		  }
		}
		
		public void ToggleDebugUpdateClipmap(bool debugClipmap) {} // 0x0000000189D02800-0x0000000189D02858
		// Void ToggleDebugUpdateClipmap(Boolean)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ToggleDebugUpdateClipmap(
		        HGIrradianceVolumeManagerV2 *this,
		        bool debugClipmap,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1889, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1889, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      debugClipmap,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_debugClipmap = debugClipmap;
		  }
		}
		
		public void ToggleDebugUpdateClipmapLod0(bool debugClipmapLod0) {} // 0x0000000189D027A8-0x0000000189D02800
		// Void ToggleDebugUpdateClipmapLod0(Boolean)
		void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ToggleDebugUpdateClipmapLod0(
		        HGIrradianceVolumeManagerV2 *this,
		        bool debugClipmapLod0,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1890, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1890, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      debugClipmapLod0,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_debugClipmapLod0 = debugClipmapLod0;
		  }
		}
		
	}
}
