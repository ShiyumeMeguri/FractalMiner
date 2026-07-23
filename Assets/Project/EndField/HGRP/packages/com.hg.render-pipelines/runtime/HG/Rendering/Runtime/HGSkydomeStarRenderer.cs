using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSkydomeStarRenderer // TypeDefIndex: 37650
	{
		// Fields
		private HGSkydomeStarRenderingData[] starData; // 0x10
		private Mesh m_starMesh; // 0x18
		public const int TALOS_RT_RESOLUTION = 2048; // Metadata: 0x02303003
		public const int PLANET_ALPHA_RT_RESOLUTION = 1024; // Metadata: 0x02303005
		private const float PLANET_RADIUS_TO_ATMOSPHERE_SCALE = 2000f; // Metadata: 0x02303007
		private const float ATMOSPHERE_HEIGHT_INVERT_NUMBER = 30f; // Metadata: 0x0230300B
		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_PC = 10f; // Metadata: 0x0230300F
		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_PC = 5f; // Metadata: 0x02303013
		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_MOBILE = 5f; // Metadata: 0x02303017
		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_MOBILE = 2f; // Metadata: 0x0230301B
		private static readonly string RENDER_MODE_TEXTURE_KEYWORD_NAME; // 0x00
		private static readonly string DRAW_RING_KEYWORD_NAME; // 0x08
		private static readonly string DRAW_ATMOSPHERE_KEYWORD_NAME; // 0x10
		private static readonly string DRAW_ATMOSPHERE_BAKE_KEYWORD_NAME; // 0x18
		private static readonly int SKYDOME_STAR_PASS_INDEX; // 0x20
		private static readonly int FULL_SCREEN_DEBUG_PASS_INDEX; // 0x24
	
		// Nested types
		public class HGSkydomeStarRenderingData // TypeDefIndex: 37649
		{
			// Fields
			public Material drawMaterial; // 0x10
			public Matrix4x4 drawMatrix; // 0x18
	
			// Constructors
			public HGSkydomeStarRenderingData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		// Constructors
		public HGSkydomeStarRenderer() {} // 0x00000001831D31D0-0x00000001831D3290
		// HGSkydomeStarRenderer()
		void HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderer(
		        HGSkydomeStarRenderer *this,
		        MethodInfo *method)
		{
		  HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *v3; // rbx
		  __int64 v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdi
		  __int64 v8; // rax
		  __int64 v9; // rdi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v3 = (HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *)il2cpp_array_new_specific_1(
		                                                                    TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderingData,
		                                                                    2LL);
		  v4 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderingData);
		  v7 = v4;
		  if ( !v4
		    || !v3
		    || (sub_180031B10(v3, v4),
		        sub_1800020D0(v3, 0LL, v7),
		        v8 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderingData),
		        (v9 = v8) == 0) )
		  {
		    sub_1800D8260(v6, v5);
		  }
		  sub_180031B10(v3, v8);
		  sub_1800020D0(v3, 1LL, v9);
		  this->fields.starData = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v10, v11, v12, v16);
		  this->fields.m_starMesh = HG::Rendering::Runtime::HGEnvironmentUtils::GenerateStarMesh(0, 0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_starMesh, v13, v14, v15, v17);
		}
		
		static HGSkydomeStarRenderer() {} // 0x0000000184CCB9B0-0x0000000184CCBAA0
		// HGSkydomeStarRenderer()
		void HG::Rendering::Runtime::HGSkydomeStarRenderer::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->RENDER_MODE_TEXTURE_KEYWORD_NAME = (String *)"TEXTURE_STAR_DRAW_MODE";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields,
		    v1,
		    v2,
		    v3,
		    v13);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_RING_KEYWORD_NAME = (String *)"DRAW_RING";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_RING_KEYWORD_NAME,
		    v5,
		    v6,
		    v4,
		    v14);
		  v7 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_ATMOSPHERE_KEYWORD_NAME = (String *)"DRAW_ATMOSPHERE";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_ATMOSPHERE_KEYWORD_NAME,
		    v8,
		    v9,
		    v7,
		    v15);
		  v10 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_ATMOSPHERE_BAKE_KEYWORD_NAME = (String *)"DRAW_ATMOSPHERE_BAKE";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_ATMOSPHERE_BAKE_KEYWORD_NAME,
		    v11,
		    v12,
		    v10,
		    v16);
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->SKYDOME_STAR_PASS_INDEX = 0;
		  TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->FULL_SCREEN_DEBUG_PASS_INDEX = 1;
		}
		
	
		// Methods
		internal bool CheckRuntimeResources(int index) => default; // 0x0000000189CEA628-0x0000000189CEA748
		// Boolean CheckRuntimeResources(Int32)
		bool HG::Rendering::Runtime::HGSkydomeStarRenderer::CheckRuntimeResources(
		        HGSkydomeStarRenderer *this,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v3; // rdi
		  Object_1 *m_starMesh; // rbx
		  __int64 v6; // rdx
		  HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *starData; // rcx
		  HGSkydomeStarRenderer_HGSkydomeStarRenderingData *v8; // rbx
		  Object_1 *drawMaterial; // rbx
		  Shader *shader; // rax
		  bool isSupported; // bl
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = index;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1498, 0LL) )
		  {
		    m_starMesh = (Object_1 *)this->fields.m_starMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_starMesh, 0LL, 0LL) )
		    {
		      starData = this->fields.starData;
		      if ( !starData )
		        goto LABEL_19;
		      if ( (unsigned int)v3 >= starData->max_length.size )
		        goto LABEL_14;
		      v8 = starData->vector[v3];
		      if ( !v8 )
		        goto LABEL_19;
		      drawMaterial = (Object_1 *)v8->fields.drawMaterial;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(drawMaterial, 0LL, 0LL) )
		      {
		        starData = this->fields.starData;
		        if ( !starData )
		          goto LABEL_19;
		        if ( (unsigned int)v3 < starData->max_length.size )
		        {
		          starData = (HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *)starData->vector[v3];
		          if ( starData )
		          {
		            starData = (HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *)starData->bounds;
		            if ( starData )
		            {
		              shader = UnityEngine::Material::get_shader((Material *)starData, 0LL);
		              if ( shader )
		              {
		                isSupported = UnityEngine::Shader::get_isSupported(shader, 0LL);
		                if ( isSupported )
		                  return isSupported;
		                goto LABEL_16;
		              }
		            }
		          }
		LABEL_19:
		          sub_1800D8260(starData, v6);
		        }
		LABEL_14:
		        sub_1800D2AB0(starData, v6);
		      }
		    }
		    isSupported = 0;
		LABEL_16:
		    HG::Rendering::HGRPLogger::LogError((String *)"Skydome drawer resources is no valid. Pleas check.", 0LL);
		    return isSupported;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1498, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		           (ILFixDynamicMethodWrapper_13 *)Patch,
		           (Object *)this,
		           (NaviDirection__Enum)v3,
		           0LL);
		}
		
		private void _RenderStar(CommandBuffer cmd, HGCamera hgCamera, ref HGCelestialConfig.HGCelestialAtmosphereObjectConfig planet, int internalIndex, bool useFullScreenDebug) {} // 0x0000000189CEA844-0x0000000189CEB714
		// Void _RenderStar(CommandBuffer, HGCamera, HGCelestialConfig+HGCelestialAtmosphereObjectConfig ByRef, Int32, Boolean)
		void HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
		        HGSkydomeStarRenderer *this,
		        CommandBuffer *cmd,
		        HGCamera *hgCamera,
		        HGCelestialConfig_HGCelestialAtmosphereObjectConfig *planet,
		        int32_t internalIndex,
		        bool useFullScreenDebug,
		        MethodInfo *method)
		{
		  void *starData; // rdx
		  char *Patch; // rcx
		  Component *camera; // r15
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGEnvironmentPhase *InterpolatedPhase; // r12
		  HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *v17; // r9
		  HGSkydomeStarRenderer_HGSkydomeStarRenderingData *v18; // rbx
		  Object_1 *drawMaterial; // rbx
		  Shader *shader; // rbx
		  Shader *v21; // rax
		  Shader *v22; // rax
		  __m128i v23; // xmm11
		  MethodInfo *v24; // rdx
		  Vector3 *fwd; // rax
		  __int64 v26; // xmm3_8
		  Vector3 *v27; // rax
		  float z; // ebx
		  __int64 v29; // xmm14_8
		  MethodInfo *v30; // rax
		  Vector3 *v31; // rax
		  Quaternion *v32; // rdx
		  Quaternion v33; // xmm0
		  __int64 v34; // xmm3_8
		  Vector3 *v35; // rax
		  MethodInfo *v36; // r9
		  float ProceduralSkyMeshRadius; // xmm0_4
		  float v38; // xmm8_4
		  float outerRadius; // xmm7_4
		  Vector3 *v40; // rax
		  __int64 v41; // xmm9_8
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v44; // xmm6_8
		  float v45; // ebx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  float v48; // xmm0_4
		  float v49; // xmm15_4
		  MethodInfo *v50; // rdx
		  Vector3 *one; // rax
		  __int64 v52; // xmm1_8
		  MethodInfo *v53; // r9
		  Vector3 *v54; // rax
		  __int64 v55; // xmm3_8
		  MethodInfo *v56; // r9
		  Vector3 *v57; // rax
		  __int64 v58; // xmm3_8
		  MethodInfo *v59; // r9
		  Vector3 *v60; // rax
		  __int64 v61; // xmm3_8
		  Matrix4x4 *v62; // rax
		  __int128 v63; // xmm1
		  __int128 v64; // xmm2
		  __int128 v65; // xmm3
		  bool v66; // r8
		  float width; // xmm8_4
		  float v68; // xmm11_4
		  float radius; // xmm12_4
		  float v70; // xmm9_4
		  __m128i v71; // xmm10
		  Animator *v72; // rdx
		  int32_t v73; // r8d
		  MethodInfo *v74; // r9
		  Vector3 *Vector; // rax
		  __int64 v76; // xmm1_8
		  Animator *v77; // rdx
		  int32_t v78; // r8d
		  MethodInfo *v79; // r9
		  Vector3 *v80; // rax
		  __int64 v81; // xmm1_8
		  Animator *v82; // rdx
		  int32_t v83; // r8d
		  MethodInfo *v84; // r9
		  Vector3 *v85; // rax
		  __m128 selfTiltX_low; // xmm6
		  __m128 selfRotationY_low; // xmm7
		  __int64 v88; // xmm1_8
		  float selfTiltZ; // xmm8_4
		  Vector4 *v90; // rax
		  __m128i v91; // xmm6
		  Vector4 *v92; // rax
		  __m128i v93; // xmm7
		  Vector4 *v94; // rax
		  __m128i v95; // xmm8
		  Vector4 *v96; // rax
		  __m128i v97; // xmm9
		  Vector4 *v98; // rax
		  __m128i v99; // xmm11
		  Material *v100; // rbx
		  int32_t v101; // edx
		  int32_t v102; // edx
		  int32_t v103; // edx
		  int32_t v104; // edx
		  int32_t v105; // edx
		  int32_t v106; // edx
		  Texture *planetRingMap; // r15
		  Material *v108; // rbx
		  __m128i v109; // xmm6
		  Material *v110; // rbx
		  MethodInfo *v111; // r8
		  Color *v112; // rax
		  int32_t v113; // r10d
		  float numInscatteredSamplePoints; // xmm9_4
		  float numOpticalDepthSamplePoints; // xmm8_4
		  float atmosphereHeight; // xmm7_4
		  float coff_R; // xmm6_4
		  Vector4 *v118; // rax
		  float v119; // xmm2_4
		  __m128i v120; // xmm9
		  Vector4 *v121; // rax
		  bool enableAtmosphere; // bl
		  __m128i v123; // xmm8
		  float bakeFaceVisibility; // xmm7_4
		  float drawPlanetBelowHorizon; // xmm6_4
		  Vector4 *v126; // rax
		  __m128i v127; // xmm6
		  Material *v128; // rbx
		  int32_t v129; // edx
		  int32_t v130; // edx
		  int32_t v131; // edx
		  int32_t SKYDOME_STAR_PASS_INDEX; // r8d
		  Material *v133; // r9
		  Mesh *m_starMesh; // rdx
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  _QWORD v136[3]; // [rsp+40h] [rbp-C8h] BYREF
		  Color v137; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v138; // [rsp+68h] [rbp-A0h] BYREF
		  __m128i v139; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v140; // [rsp+88h] [rbp-80h] BYREF
		  float v141; // [rsp+98h] [rbp-70h]
		  float v142; // [rsp+9Ch] [rbp-6Ch]
		  float v143; // [rsp+A0h] [rbp-68h]
		  __int64 v144; // [rsp+A8h] [rbp-60h]
		  __int128 v145; // [rsp+B0h] [rbp-58h] BYREF
		  LocalKeyword keyword; // [rsp+C0h] [rbp-48h] BYREF
		  LocalKeyword v147; // [rsp+D8h] [rbp-30h] BYREF
		  LocalKeyword v148; // [rsp+F0h] [rbp-18h] BYREF
		  __int128 v149; // [rsp+108h] [rbp+0h]
		  __int128 v150; // [rsp+118h] [rbp+10h]
		  __int128 v151; // [rsp+128h] [rbp+20h]
		  Matrix4x4 v152[3]; // [rsp+138h] [rbp+30h] BYREF
		
		  memset(&keyword, 0, sizeof(keyword));
		  memset(&v147, 0, sizeof(v147));
		  memset(&v148, 0, sizeof(v148));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1499, 0LL) )
		  {
		    if ( !hgCamera )
		      goto LABEL_111;
		    camera = (Component *)hgCamera->fields.camera;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( !InterpolatedPhase )
		      goto LABEL_111;
		    starData = this->fields.starData;
		    if ( !starData )
		      goto LABEL_111;
		    if ( (unsigned int)internalIndex < *((_DWORD *)starData + 6) )
		    {
		      Patch = (char *)*((_QWORD *)starData + internalIndex + 4);
		      if ( !Patch )
		        goto LABEL_111;
		      *((_QWORD *)Patch + 2) = planet->skydomeDrawer.drawMaterial;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)(Patch + 16), (HGRuntimeGrassQuery_Node *)starData, v14, v15, P3);
		      v17 = this->fields.starData;
		      if ( !v17 )
		        goto LABEL_111;
		      if ( (unsigned int)internalIndex < v17->max_length.size )
		      {
		        v18 = v17->vector[internalIndex];
		        if ( !v18 )
		          goto LABEL_111;
		        drawMaterial = (Object_1 *)v18->fields.drawMaterial;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Equality(drawMaterial, 0LL, 0LL) )
		          return;
		        Patch = (char *)this->fields.starData;
		        if ( !Patch )
		          goto LABEL_111;
		        if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		        {
		          starData = *(void **)&Patch[8 * internalIndex + 32];
		          if ( !starData )
		            goto LABEL_111;
		          Patch = (char *)*((_QWORD *)starData + 2);
		          if ( !Patch )
		            goto LABEL_111;
		          shader = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &keyword,
		            shader,
		            TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->RENDER_MODE_TEXTURE_KEYWORD_NAME,
		            0LL);
		          Patch = (char *)this->fields.starData;
		          if ( !Patch )
		            goto LABEL_111;
		          if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		          {
		            starData = *(void **)&Patch[8 * internalIndex + 32];
		            if ( !starData )
		              goto LABEL_111;
		            Patch = (char *)*((_QWORD *)starData + 2);
		            if ( !Patch )
		              goto LABEL_111;
		            v21 = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		              &v147,
		              v21,
		              TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_RING_KEYWORD_NAME,
		              0LL);
		            Patch = (char *)this->fields.starData;
		            if ( !Patch )
		              goto LABEL_111;
		            if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		            {
		              starData = *(void **)&Patch[8 * internalIndex + 32];
		              if ( !starData )
		                goto LABEL_111;
		              Patch = (char *)*((_QWORD *)starData + 2);
		              if ( !Patch )
		                goto LABEL_111;
		              v22 = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                &v148,
		                v22,
		                TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->DRAW_ATMOSPHERE_KEYWORD_NAME,
		                0LL);
		              v23 = _mm_loadu_si128((const __m128i *)sub_182FA5990(&v145));
		              fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v137, v24);
		              v139 = v23;
		              v26 = *(_QWORD *)&fwd->x;
		              v138.z = fwd->z;
		              *(_QWORD *)&v138.x = v26;
		              v27 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v137, (Quaternion *)&v139, &v138, 0LL);
		              z = v27->z;
		              v29 = *(_QWORD *)&v27->x;
		              v142 = z;
		              v30 = (MethodInfo *)sub_182FA5990(&v145);
		              v31 = UnityEngine::Vector3::get_fwd((Vector3 *)&v137, v30);
		              v33 = *v32;
		              v34 = *(_QWORD *)&v31->x;
		              v138.z = v31->z;
		              *(_QWORD *)&v138.x = v34;
		              v139 = (__m128i)v33;
		              v35 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v137, (Quaternion *)&v139, &v138, 0LL);
		              *(_QWORD *)&v33.x = *(_QWORD *)&v35->x;
		              *(float *)&v35 = v35->z;
		              v144 = *(_QWORD *)&v33.x;
		              v143 = *(float *)&v35;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		              ProceduralSkyMeshRadius = HG::Rendering::Runtime::HGSkyRenderer::GetProceduralSkyMeshRadius(0LL);
		              v38 = ProceduralSkyMeshRadius;
		              if ( planet->enableRing )
		                outerRadius = planet->ring.outerRadius;
		              else
		                outerRadius = planet->objectProperty.radius;
		              if ( (float)((float)((float)((float)(InterpolatedPhase->fields.celestialConfig.moonConfig.orbitRadius
		                                                 / 5000.0)
		                                         * planet->atmosphere.atmosphereHeight)
		                                 * (float)((float)(planet->atmosphere.heightScale_R / 15.0) + 1.0))
		                         + planet->objectProperty.radius) > outerRadius )
		                outerRadius = (float)((float)((float)(InterpolatedPhase->fields.celestialConfig.moonConfig.orbitRadius
		                                                    / 5000.0)
		                                            * planet->atmosphere.atmosphereHeight)
		                                    * (float)((float)(planet->atmosphere.heightScale_R / 15.0) + 1.0))
		                            + planet->objectProperty.radius;
		              *(_QWORD *)&v138.x = v29;
		              v138.z = z;
		              v40 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v137, &v138, ProceduralSkyMeshRadius, v36);
		              v41 = *(_QWORD *)&v40->x;
		              v141 = v40->z;
		              if ( !camera )
		                goto LABEL_111;
		              transform = UnityEngine::Component::get_transform(camera, 0LL);
		              if ( !transform )
		                goto LABEL_111;
		              position = UnityEngine::Transform::get_position((Vector3 *)&v137, transform, 0LL);
		              v44 = *(_QWORD *)&position->x;
		              v45 = position->z;
		              HG::Rendering::Runtime::HGEnvironmentUtils::SkydomeStarHalfFovCos(
		                outerRadius,
		                InterpolatedPhase->fields.celestialConfig.moonConfig.orbitRadius
		              - InterpolatedPhase->fields.celestialConfig.moonConfig.radius,
		                0LL);
		              v48 = sub_1803386C0(v47, v46);
		              *(float *)&v139.m128i_i32[2] = v141;
		              v49 = v48;
		              v139.m128i_i64[0] = v41;
		              *(_QWORD *)&v140.x = v44;
		              v140.z = v45;
		              one = UnityEngine::Vector3::get_one((Vector3 *)&v137, v50);
		              v52 = *(_QWORD *)&one->x;
		              *(float *)&one = one->z;
		              *(_QWORD *)&v138.x = v52;
		              LODWORD(v138.z) = (_DWORD)one;
		              v54 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v137, &v138, v38, v53);
		              v55 = *(_QWORD *)&v54->x;
		              *(float *)&v54 = v54->z;
		              *(_QWORD *)&v138.x = v55;
		              LODWORD(v138.z) = (_DWORD)v54;
		              v57 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v137, &v138, v48, v56);
		              *(__m128i *)&v136[1] = v23;
		              v58 = *(_QWORD *)&v57->x;
		              *(float *)&v57 = v57->z;
		              *(_QWORD *)&v138.x = v58;
		              LODWORD(v138.z) = (_DWORD)v57;
		              v60 = UnityEngine::Vector3::op_Addition((Vector3 *)&v137, &v140, (Vector3 *)&v139, v59);
		              v61 = *(_QWORD *)&v60->x;
		              *(float *)&v60 = v60->z;
		              v139.m128i_i64[0] = v61;
		              v139.m128i_i32[2] = (int)v60;
		              v62 = UnityEngine::Matrix4x4::TRS(v152, (Vector3 *)&v139, (Quaternion *)&v136[1], &v138, 0LL);
		              Patch = (char *)this->fields.starData;
		              v149 = *(_OWORD *)&v62->m00;
		              v150 = *(_OWORD *)&v62->m01;
		              v151 = *(_OWORD *)&v62->m02;
		              v145 = *(_OWORD *)&v62->m03;
		              if ( !Patch )
		                goto LABEL_111;
		              if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		              {
		                Patch = *(char **)&Patch[8 * internalIndex + 32];
		                v63 = *(_OWORD *)&v62->m01;
		                v64 = *(_OWORD *)&v62->m02;
		                v65 = *(_OWORD *)&v62->m03;
		                if ( !Patch )
		                  goto LABEL_111;
		                *(_OWORD *)(Patch + 24) = *(_OWORD *)&v62->m00;
		                *(_OWORD *)(Patch + 40) = v63;
		                *(_OWORD *)(Patch + 56) = v64;
		                *(_OWORD *)(Patch + 72) = v65;
		                Patch = (char *)this->fields.starData;
		                if ( !Patch )
		                  goto LABEL_111;
		                if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                {
		                  starData = *(void **)&Patch[8 * internalIndex + 32];
		                  if ( !starData )
		                    goto LABEL_111;
		                  Patch = (char *)*((_QWORD *)starData + 2);
		                  if ( !Patch )
		                    goto LABEL_111;
		                  UnityEngine::Material::SetKeyword(
		                    (Material *)Patch,
		                    &keyword,
		                    planet->skydomeDrawer.drawMode == 0,
		                    0LL);
		                  Patch = (char *)this->fields.starData;
		                  if ( !Patch )
		                    goto LABEL_111;
		                  if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                  {
		                    starData = *(void **)&Patch[8 * internalIndex + 32];
		                    if ( !starData )
		                      goto LABEL_111;
		                    Patch = (char *)*((_QWORD *)starData + 2);
		                    if ( !Patch )
		                      goto LABEL_111;
		                    UnityEngine::Material::SetKeyword((Material *)Patch, &v147, planet->enableRing, 0LL);
		                    Patch = (char *)this->fields.starData;
		                    if ( !Patch )
		                      goto LABEL_111;
		                    if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                    {
		                      starData = *(void **)&Patch[8 * internalIndex + 32];
		                      if ( !starData )
		                        goto LABEL_111;
		                      Patch = (char *)*((_QWORD *)starData + 2);
		                      v66 = planet->enableAtmosphere && planet->skydomeDrawer.drawMode == 1;
		                      if ( !Patch )
		                        goto LABEL_111;
		                      UnityEngine::Material::SetKeyword((Material *)Patch, &v148, v66, 0LL);
		                      width = planet->ring.width;
		                      v68 = InterpolatedPhase->fields.celestialConfig.moonConfig.orbitRadius
		                          - InterpolatedPhase->fields.celestialConfig.moonConfig.radius;
		                      radius = planet->objectProperty.radius;
		                      v70 = planet->ring.outerRadius;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                      v71 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                               (Vector4 *)&v136[1],
		                                                               radius / v68,
		                                                               v68 / v70,
		                                                               v68 / width,
		                                                               (float)(width - v70) / width,
		                                                               0LL));
		                      Vector = UnityEngine::Animator::GetVector((Vector3 *)&v137, v72, v73, v74);
		                      v76 = *(_QWORD *)&Vector->x;
		                      *(float *)&Vector = Vector->z;
		                      *(_QWORD *)&v140.x = v76;
		                      LODWORD(v140.z) = (_DWORD)Vector;
		                      v80 = UnityEngine::Animator::GetVector((Vector3 *)&v137, v77, v78, v79);
		                      v81 = *(_QWORD *)&v80->x;
		                      *(float *)&v80 = v80->z;
		                      v139.m128i_i64[0] = v81;
		                      v139.m128i_i32[2] = (int)v80;
		                      v85 = UnityEngine::Animator::GetVector((Vector3 *)&v137, v82, v83, v84);
		                      selfTiltX_low = (__m128)LODWORD(planet->objectProperty.selfTiltX);
		                      selfRotationY_low = (__m128)LODWORD(planet->objectProperty.selfRotationY);
		                      v88 = *(_QWORD *)&v85->x;
		                      *(float *)&v85 = v85->z;
		                      selfTiltZ = planet->objectProperty.selfTiltZ;
		                      *(_QWORD *)&v138.x = v88;
		                      LODWORD(v138.z) = (_DWORD)v85;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		                      *(_QWORD *)&v137.r = _mm_unpacklo_ps(selfTiltX_low, selfRotationY_low).m128_u64[0];
		                      v137.b = selfTiltZ;
		                      HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
		                        (Vector3 *)&v137,
		                        &v140,
		                        (Vector3 *)&v139,
		                        &v138,
		                        0LL);
		                      v137.b = v142;
		                      *(_QWORD *)&v137.r = v29;
		                      v90 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                              (Vector4 *)&v136[1],
		                              (Vector3 *)&v137,
		                              0.0,
		                              0LL);
		                      *(_QWORD *)&v137.r = v144;
		                      v91 = _mm_loadu_si128((const __m128i *)v90);
		                      v137.b = v143;
		                      v92 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                              (Vector4 *)&v136[1],
		                              (Vector3 *)&v137,
		                              0.0,
		                              0LL);
		                      *(_QWORD *)&v137.r = *(_QWORD *)&v140.x;
		                      v93 = _mm_loadu_si128((const __m128i *)v92);
		                      v137.b = v140.z;
		                      v94 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                              (Vector4 *)&v136[1],
		                              (Vector3 *)&v137,
		                              0.0,
		                              0LL);
		                      *(_QWORD *)&v137.r = v139.m128i_i64[0];
		                      v95 = _mm_loadu_si128((const __m128i *)v94);
		                      LODWORD(v137.b) = v139.m128i_i32[2];
		                      v96 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                              (Vector4 *)&v136[1],
		                              (Vector3 *)&v137,
		                              0.0,
		                              0LL);
		                      *(_QWORD *)&v137.r = *(_QWORD *)&v138.x;
		                      v97 = _mm_loadu_si128((const __m128i *)v96);
		                      v137.b = v138.z;
		                      v98 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                              (Vector4 *)&v136[1],
		                              (Vector3 *)&v137,
		                              0.0,
		                              0LL);
		                      Patch = (char *)this->fields.starData;
		                      v99 = _mm_loadu_si128((const __m128i *)v98);
		                      if ( !Patch )
		                        goto LABEL_111;
		                      if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                      {
		                        Patch = *(char **)&Patch[8 * internalIndex + 32];
		                        if ( !Patch )
		                          goto LABEL_111;
		                        v100 = (Material *)*((_QWORD *)Patch + 2);
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                        starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                        if ( !v100 )
		                          goto LABEL_111;
		                        v101 = *((_DWORD *)starData + 323);
		                        *(__m128i *)&v136[1] = v91;
		                        UnityEngine::Material::SetVector(v100, v101, (Vector4 *)&v136[1], 0LL);
		                        Patch = (char *)this->fields.starData;
		                        if ( !Patch )
		                          goto LABEL_111;
		                        if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                        {
		                          starData = *(void **)&Patch[8 * internalIndex + 32];
		                          if ( !starData )
		                            goto LABEL_111;
		                          Patch = (char *)*((_QWORD *)starData + 2);
		                          starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                          if ( !Patch )
		                            goto LABEL_111;
		                          v102 = *((_DWORD *)starData + 324);
		                          *(__m128i *)&v136[1] = v93;
		                          UnityEngine::Material::SetVector((Material *)Patch, v102, (Vector4 *)&v136[1], 0LL);
		                          Patch = (char *)this->fields.starData;
		                          if ( !Patch )
		                            goto LABEL_111;
		                          if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                          {
		                            starData = *(void **)&Patch[8 * internalIndex + 32];
		                            if ( !starData )
		                              goto LABEL_111;
		                            Patch = (char *)*((_QWORD *)starData + 2);
		                            starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                            if ( !Patch )
		                              goto LABEL_111;
		                            v103 = *((_DWORD *)starData + 325);
		                            *(__m128i *)&v136[1] = v71;
		                            UnityEngine::Material::SetVector((Material *)Patch, v103, (Vector4 *)&v136[1], 0LL);
		                            Patch = (char *)this->fields.starData;
		                            if ( !Patch )
		                              goto LABEL_111;
		                            if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                            {
		                              starData = *(void **)&Patch[8 * internalIndex + 32];
		                              if ( !starData )
		                                goto LABEL_111;
		                              Patch = (char *)*((_QWORD *)starData + 2);
		                              starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                              if ( !Patch )
		                                goto LABEL_111;
		                              v104 = *((_DWORD *)starData + 332);
		                              *(__m128i *)&v136[1] = v95;
		                              UnityEngine::Material::SetVector((Material *)Patch, v104, (Vector4 *)&v136[1], 0LL);
		                              Patch = (char *)this->fields.starData;
		                              if ( !Patch )
		                                goto LABEL_111;
		                              if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                              {
		                                starData = *(void **)&Patch[8 * internalIndex + 32];
		                                if ( !starData )
		                                  goto LABEL_111;
		                                Patch = (char *)*((_QWORD *)starData + 2);
		                                starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                if ( !Patch )
		                                  goto LABEL_111;
		                                v105 = *((_DWORD *)starData + 333);
		                                *(__m128i *)&v136[1] = v97;
		                                UnityEngine::Material::SetVector((Material *)Patch, v105, (Vector4 *)&v136[1], 0LL);
		                                Patch = (char *)this->fields.starData;
		                                if ( !Patch )
		                                  goto LABEL_111;
		                                if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                {
		                                  starData = *(void **)&Patch[8 * internalIndex + 32];
		                                  if ( !starData )
		                                    goto LABEL_111;
		                                  Patch = (char *)*((_QWORD *)starData + 2);
		                                  starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                  if ( !Patch )
		                                    goto LABEL_111;
		                                  v106 = *((_DWORD *)starData + 334);
		                                  *(__m128i *)&v136[1] = v99;
		                                  UnityEngine::Material::SetVector((Material *)Patch, v106, (Vector4 *)&v136[1], 0LL);
		                                  planetRingMap = planet->ring.planetRingMap;
		                                  sub_1800036A0(TypeInfo::UnityEngine::Object);
		                                  if ( UnityEngine::Object::op_Inequality((Object_1 *)planetRingMap, 0LL, 0LL) )
		                                  {
		                                    Patch = (char *)this->fields.starData;
		                                    if ( !Patch )
		                                      goto LABEL_111;
		                                    if ( (unsigned int)internalIndex >= *((_DWORD *)Patch + 6) )
		                                      goto LABEL_109;
		                                    starData = *(void **)&Patch[8 * internalIndex + 32];
		                                    if ( !starData )
		                                      goto LABEL_111;
		                                    v108 = (Material *)*((_QWORD *)starData + 2);
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                    starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                    if ( !v108 )
		                                      goto LABEL_111;
		                                    UnityEngine::Material::SetTextureImpl(
		                                      v108,
		                                      *((_DWORD *)starData + 326),
		                                      planetRingMap,
		                                      0LL);
		                                  }
		                                  Patch = (char *)this->fields.starData;
		                                  v109 = _mm_loadu_si128((const __m128i *)&planet->ring.ringColor);
		                                  if ( !Patch )
		                                    goto LABEL_111;
		                                  if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                  {
		                                    starData = *(void **)&Patch[8 * internalIndex + 32];
		                                    if ( !starData )
		                                      goto LABEL_111;
		                                    v110 = (Material *)*((_QWORD *)starData + 2);
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                    *(__m128i *)&v136[1] = v109;
		                                    v112 = UnityEngine::Color::op_Implicit(&v137, (Vector4 *)&v136[1], v111);
		                                    if ( !v110 )
		                                      goto LABEL_111;
		                                    *(Color *)&v136[1] = *v112;
		                                    UnityEngine::Material::SetVector(v110, v113, (Vector4 *)&v136[1], 0LL);
		                                    numInscatteredSamplePoints = (float)planet->atmosphere.numInscatteredSamplePoints;
		                                    if ( numInscatteredSamplePoints < 0.0 )
		                                    {
		                                      numInscatteredSamplePoints = 0.0;
		                                    }
		                                    else if ( numInscatteredSamplePoints > 10.0 )
		                                    {
		                                      numInscatteredSamplePoints = 10.0;
		                                    }
		                                    numOpticalDepthSamplePoints = (float)planet->atmosphere.numOpticalDepthSamplePoints;
		                                    if ( numOpticalDepthSamplePoints < 0.0 )
		                                    {
		                                      numOpticalDepthSamplePoints = 0.0;
		                                    }
		                                    else if ( numOpticalDepthSamplePoints > 5.0 )
		                                    {
		                                      numOpticalDepthSamplePoints = 5.0;
		                                    }
		                                    atmosphereHeight = planet->atmosphere.atmosphereHeight;
		                                    coff_R = planet->atmosphere.coff_R;
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                                    v118 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                                             (Vector4 *)&v136[1],
		                                             atmosphereHeight,
		                                             numInscatteredSamplePoints,
		                                             coff_R,
		                                             *(float *)v71.m128i_i32 * 2000.0,
		                                             0LL);
		                                    v119 = 30.0 - planet->atmosphere.heightScale_R;
		                                    v120 = _mm_loadu_si128((const __m128i *)v118);
		                                    if ( v119 <= 0.000099999997 )
		                                      v119 = 0.000099999997;
		                                    v121 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                                             (Vector4 *)&v136[1],
		                                             numOpticalDepthSamplePoints,
		                                             v119,
		                                             planet->atmosphere.atmosphereBrightness,
		                                             planet->atmosphere.atmosphereHueshift,
		                                             0LL);
		                                    enableAtmosphere = planet->enableAtmosphere;
		                                    v123 = _mm_loadu_si128((const __m128i *)v121);
		                                    bakeFaceVisibility = planet->atmosphere.bakeFaceVisibility;
		                                    drawPlanetBelowHorizon = planet->drawPlanetBelowHorizon;
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                                    v126 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                                             (Vector4 *)&v136[1],
		                                             (float)enableAtmosphere,
		                                             bakeFaceVisibility,
		                                             v49,
		                                             drawPlanetBelowHorizon,
		                                             0LL);
		                                    Patch = (char *)this->fields.starData;
		                                    v127 = _mm_loadu_si128((const __m128i *)v126);
		                                    if ( !Patch )
		                                      goto LABEL_111;
		                                    if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                    {
		                                      starData = *(void **)&Patch[8 * internalIndex + 32];
		                                      if ( !starData )
		                                        goto LABEL_111;
		                                      v128 = (Material *)*((_QWORD *)starData + 2);
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                      starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                      if ( !v128 )
		                                        goto LABEL_111;
		                                      v129 = *((_DWORD *)starData + 328);
		                                      *(__m128i *)&v136[1] = v120;
		                                      UnityEngine::Material::SetVector(v128, v129, (Vector4 *)&v136[1], 0LL);
		                                      Patch = (char *)this->fields.starData;
		                                      if ( !Patch )
		                                        goto LABEL_111;
		                                      if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                      {
		                                        starData = *(void **)&Patch[8 * internalIndex + 32];
		                                        if ( !starData )
		                                          goto LABEL_111;
		                                        Patch = (char *)*((_QWORD *)starData + 2);
		                                        starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                        if ( !Patch )
		                                          goto LABEL_111;
		                                        v130 = *((_DWORD *)starData + 329);
		                                        *(__m128i *)&v136[1] = v123;
		                                        UnityEngine::Material::SetVector(
		                                          (Material *)Patch,
		                                          v130,
		                                          (Vector4 *)&v136[1],
		                                          0LL);
		                                        Patch = (char *)this->fields.starData;
		                                        if ( !Patch )
		                                          goto LABEL_111;
		                                        if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                        {
		                                          starData = *(void **)&Patch[8 * internalIndex + 32];
		                                          if ( !starData )
		                                            goto LABEL_111;
		                                          Patch = (char *)*((_QWORD *)starData + 2);
		                                          starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                          if ( !Patch )
		                                            goto LABEL_111;
		                                          v131 = *((_DWORD *)starData + 330);
		                                          *(__m128i *)&v136[1] = v127;
		                                          UnityEngine::Material::SetVector(
		                                            (Material *)Patch,
		                                            v131,
		                                            (Vector4 *)&v136[1],
		                                            0LL);
		                                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
		                                          SKYDOME_STAR_PASS_INDEX = TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer->static_fields->SKYDOME_STAR_PASS_INDEX;
		                                          Patch = (char *)this->fields.starData;
		                                          if ( !Patch )
		                                            goto LABEL_111;
		                                          if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
		                                          {
		                                            starData = *(void **)&Patch[8 * internalIndex + 32];
		                                            if ( starData && cmd )
		                                            {
		                                              v133 = (Material *)*((_QWORD *)starData + 2);
		                                              m_starMesh = this->fields.m_starMesh;
		                                              *(_OWORD *)&v152[0].m00 = v149;
		                                              *(_OWORD *)&v152[0].m01 = v150;
		                                              *(_OWORD *)&v152[0].m02 = v151;
		                                              *(_OWORD *)&v152[0].m03 = v145;
		                                              UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                                                cmd,
		                                                m_starMesh,
		                                                v152,
		                                                v133,
		                                                0,
		                                                SKYDOME_STAR_PASS_INDEX,
		                                                0LL);
		                                              return;
		                                            }
		LABEL_111:
		                                            sub_1800D8260(Patch, starData);
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_109:
		    sub_1800D2AB0(Patch, starData);
		  }
		  Patch = (char *)IFix::WrappersManagerImpl::GetPatch(1499, 0LL);
		  if ( !Patch )
		    goto LABEL_111;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_612(
		    (ILFixDynamicMethodWrapper_2 *)Patch,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)hgCamera,
		    planet,
		    internalIndex,
		    useFullScreenDebug,
		    0LL);
		}
		
		public void RenderStar(CommandBuffer cmd, HGCamera hgCamera, bool useFullScreenDebug) {} // 0x0000000189CEA748-0x0000000189CEA844
		// Void RenderStar(CommandBuffer, HGCamera, Boolean)
		void HG::Rendering::Runtime::HGSkydomeStarRenderer::RenderStar(
		        HGSkydomeStarRenderer *this,
		        CommandBuffer *cmd,
		        HGCamera *hgCamera,
		        bool useFullScreenDebug,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGCelestialConfig_HGCelestialAtmosphereObjectConfig *p_talosAlphaConfig; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1501, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1501, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
		        (ILFixDynamicMethodWrapper_13 *)Patch,
		        (Object *)this,
		        (Object *)cmd,
		        (Object *)hgCamera,
		        useFullScreenDebug,
		        0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v11, v10);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_8;
		  p_talosAlphaConfig = &InterpolatedPhase->fields.celestialConfig.talosAlphaConfig;
		  if ( InterpolatedPhase->fields.celestialConfig.planetConfig.drawPlanetInSkydome )
		    HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
		      this,
		      cmd,
		      hgCamera,
		      &InterpolatedPhase->fields.celestialConfig.planetConfig,
		      0,
		      useFullScreenDebug,
		      0LL);
		  if ( p_talosAlphaConfig->drawPlanetInSkydome )
		    HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
		      this,
		      cmd,
		      hgCamera,
		      p_talosAlphaConfig,
		      1,
		      useFullScreenDebug,
		      0LL);
		}
		
	}
}
