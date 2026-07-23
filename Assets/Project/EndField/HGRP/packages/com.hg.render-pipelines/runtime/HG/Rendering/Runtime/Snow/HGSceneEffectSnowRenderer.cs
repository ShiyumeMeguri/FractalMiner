using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Snow
{
	public class HGSceneEffectSnowRenderer : HGBaseSubSnowRenderer // TypeDefIndex: 38840
	{
		// Fields
		private Mesh m_snowMesh; // 0x18
		private Vector3 m_snowMeshExtents; // 0x20
		private Shader m_snowShader; // 0x30
		private Material m_snowMat; // 0x38
		private SceneEffectSnowRenderParams m_snowRenderParams; // 0x40
		private const int s_maxSceneEffectLayerCount = 6; // Metadata: 0x023044EA
		private static readonly float[] s_sceneEffectLayerScale; // 0x00
		private Vector3[] m_sceneEffectSnowAxisOffsetList; // 0x48
		private Vector3[] m_sceneEffectSnowDirections; // 0x50
		private float[] m_sceneEffectSnowDirectionJitterNoiseOffsetList; // 0x58
		private MaterialPropertyBlock[] m_sceneEffectSnowMaterialPropertyBlockList; // 0x60
	
		// Nested types
		internal class SceneEffectSnowRenderParams // TypeDefIndex: 38839
		{
			// Fields
			public Vector3 pos; // 0x10
			public Vector3 scale; // 0x1C
			public Vector4 snowParams; // 0x28
			public float snowDirectionJitterLevel; // 0x38
			public float snowTrailLength; // 0x3C
			public UnityEngine.Color color; // 0x40
			public int snowLayerCount; // 0x50
			public Texture2D snowflakeTexture; // 0x58
			public Vector4 snowflakeTextureTilingOffset; // 0x60
	
			// Constructors
			public SceneEffectSnowRenderParams() {} // 0x0000000182EDE5A0-0x0000000182EDE630
		}
	
		// Constructors
		public HGSceneEffectSnowRenderer() {} // 0x0000000182EDEAF0-0x0000000182EDEBF0
		static HGSceneEffectSnowRenderer() {} // 0x0000000184D56710-0x0000000184D56770
		// HGSceneEffectSnowRenderer()
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::cctor(MethodInfo *method)
		{
		  Array *v1; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  VolumetricRenderer_VolumetricBounds *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		  MethodInfo *v6; // [rsp+58h] [rbp+30h]
		  int32_t v7; // [rsp+60h] [rbp+38h]
		  int32_t v8; // [rsp+68h] [rbp+40h]
		  float v9; // [rsp+70h] [rbp+48h]
		  int32_t v10; // [rsp+78h] [rbp+50h]
		  bool v11; // [rsp+80h] [rbp+58h]
		  bool v12; // [rsp+88h] [rbp+60h]
		  MethodInfo *v13; // [rsp+90h] [rbp+68h]
		
		  v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 6LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v1,
		    91D795506672CFB70508742A9F3DF163038B9889D3A791F1996E4D736FEA4153_Field,
		    0LL);
		  static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer->static_fields;
		  static_fields->klass = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext___Class *)v1;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13);
		}
		
	
		// Methods
		internal override void PrepareResources(SnowCommonResources commonResources) {} // 0x000000018474F2C0-0x000000018474F480
		internal override void UpdateData([IsReadOnly] in SnowCommonRenderingParam snowCommonRenderingParam, HGCamera hgCamera, float deltaTime) {} // 0x0000000189C78BB8-0x0000000189C7934C
		// Void UpdateData(SnowCommonRenderingParam ByRef, HGCamera, Single)
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::UpdateData(
		        HGSceneEffectSnowRenderer *this,
		        SnowCommonRenderingParam **snowCommonRenderingParam,
		        HGCamera *hgCamera,
		        float deltaTime,
		        MethodInfo *method)
		{
		  float v8; // xmm11_4
		  MethodInfo *snowflakeTex; // rdx
		  char *static_fields; // rcx
		  SnowCommonPreSettingParam *snowCommonPreSettingParam; // r15
		  int i; // esi
		  SnowCommonRenderingParam *v13; // r8
		  float v14; // xmm10_4
		  float x; // xmm0_4
		  float snowRange; // xmm6_4
		  float v17; // xmm8_4
		  __int64 v18; // r8
		  Single__Array *m_sceneEffectSnowDirectionJitterNoiseOffsetList; // r9
		  float v20; // xmm12_4
		  float v21; // xmm6_4
		  float v22; // xmm13_4
		  float v23; // xmm14_4
		  float v24; // xmm15_4
		  float *v25; // rax
		  __int64 v26; // r8
		  Single__Array *v27; // rbx
		  Vector3 *down; // rax
		  MethodInfo *v29; // rbx
		  __int64 v30; // xmm0_8
		  float z; // eax
		  Beyond::DampingMath *v32; // rcx
		  Beyond::DampingMath *v33; // rcx
		  Beyond::DampingMath *v34; // rcx
		  Beyond::DampingMath *v35; // rcx
		  Vector3 *v36; // rax
		  __int64 v37; // xmm0_8
		  __int64 v38; // rax
		  float v39; // xmm10_4
		  __m128 v40; // xmm14
		  __m128 v41; // xmm7
		  float v42; // xmm10_4
		  MethodInfo *v43; // rax
		  Vector3 *v44; // rax
		  __int64 v45; // r9
		  __int64 v46; // xmm1_8
		  Vector3 *v47; // rax
		  __int64 v48; // r9
		  Vector3__Array *m_sceneEffectSnowAxisOffsetList; // rbx
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  __int64 v52; // r8
		  float v53; // xmm6_4
		  Vector3__Array *v54; // rbx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // r8
		  float v58; // xmm6_4
		  Vector3__Array *v59; // rbx
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  __int64 v62; // r8
		  float v63; // xmm6_4
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rbx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  VolumetricRenderer_VolumetricBounds *v67; // r8
		  Int32__Array **v68; // r9
		  __m128 snowRange_low; // xmm0
		  __m128 maxSnowHeight_low; // xmm1
		  float v71; // xmm2_4
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v72; // rax
		  __m128i v73; // xmm0
		  SnowCommonRenderingParam *v74; // rax
		  float y; // xmm1_4
		  unsigned int v76; // xmm0_4
		  SnowCommonPreSettingParam *v77; // rax
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v78; // r9
		  SnowCommonPreSettingParam *v79; // rax
		  __m128i v80; // xmm0
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v81; // rax
		  int32_t snowLayerCount; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v85; // [rsp+30h] [rbp-D8h]
		  float snowMaxUVFlowSpeed; // [rsp+38h] [rbp-D0h]
		  __int128 v87; // [rsp+40h] [rbp-C8h] BYREF
		  int32_t v88; // [rsp+50h] [rbp-B8h]
		  unsigned __int64 v89; // [rsp+58h] [rbp-B0h] BYREF
		  _BOOL8 v90; // [rsp+60h] [rbp-A8h]
		  Vector3 v91; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v92; // [rsp+78h] [rbp-90h] BYREF
		  __int64 v93; // [rsp+88h] [rbp-80h] BYREF
		  int v94; // [rsp+90h] [rbp-78h]
		  float v95[4]; // [rsp+98h] [rbp-70h]
		  Vector3 v96; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v97; // [rsp+B8h] [rbp-50h] BYREF
		  Vector3 v98; // [rsp+C8h] [rbp-40h] BYREF
		  Vector3 v99; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v100; // [rsp+E8h] [rbp-20h] BYREF
		  _BYTE v101[16]; // [rsp+F8h] [rbp-10h] BYREF
		  Vector3 v102[13]; // [rsp+108h] [rbp+0h] BYREF
		
		  LODWORD(v89) = 0;
		  LODWORD(v90) = 0;
		  v8 = deltaTime;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5475, 0LL) )
		  {
		    if ( *snowCommonRenderingParam )
		    {
		      snowCommonPreSettingParam = (*snowCommonRenderingParam)->fields.snowCommonPreSettingParam;
		      for ( i = 0; i < 6; ++i )
		      {
		        v13 = *snowCommonRenderingParam;
		        if ( !*snowCommonRenderingParam )
		          goto LABEL_47;
		        snowflakeTex = (MethodInfo *)(unsigned int)(i >> 31);
		        LODWORD(snowflakeTex) = i % v13->fields.snowLayerCount;
		        v14 = (float)(int)snowflakeTex / (float)v13->fields.snowLayerCount;
		        if ( !snowCommonPreSettingParam )
		          goto LABEL_47;
		        snowMaxUVFlowSpeed = snowCommonPreSettingParam->fields.snowMaxUVFlowSpeed;
		        x = v13->fields.speed.x;
		        Beyond::JobMathf::ClampedLerp((Beyond::JobMathf *)static_fields, v13->fields.speed.y, v14, deltaTime);
		        snowRange = snowCommonPreSettingParam->fields.snowRange;
		        v17 = (float)(x * (float)(0.5 / snowCommonPreSettingParam->fields.maxSnowHeight)) * 0.050000001;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
		        static_fields = (char *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer->static_fields;
		        snowflakeTex = *(MethodInfo **)static_fields;
		        if ( !*(_QWORD *)static_fields )
		          goto LABEL_47;
		        if ( (unsigned int)i >= LODWORD(snowflakeTex->name) )
		          goto LABEL_45;
		        m_sceneEffectSnowDirectionJitterNoiseOffsetList = this->fields.m_sceneEffectSnowDirectionJitterNoiseOffsetList;
		        v20 = 1.0
		            / (float)((float)(snowRange * *((float *)&snowflakeTex->klass + i))
		                    / snowCommonPreSettingParam->fields.maxSnowHeight);
		        if ( !m_sceneEffectSnowDirectionJitterNoiseOffsetList )
		          goto LABEL_47;
		        if ( (unsigned int)i >= m_sceneEffectSnowDirectionJitterNoiseOffsetList->max_length.size )
		          goto LABEL_45;
		        v21 = m_sceneEffectSnowDirectionJitterNoiseOffsetList->vector[i] * 0.2;
		        v22 = m_sceneEffectSnowDirectionJitterNoiseOffsetList->vector[i] * 0.1;
		        v23 = m_sceneEffectSnowDirectionJitterNoiseOffsetList->vector[i] * 0.40000001;
		        v24 = m_sceneEffectSnowDirectionJitterNoiseOffsetList->vector[i] * 0.5;
		        v25 = (float *)sub_180002EB0(
		                         this->fields.m_sceneEffectSnowDirectionJitterNoiseOffsetList,
		                         i,
		                         v18,
		                         m_sceneEffectSnowDirectionJitterNoiseOffsetList);
		        static_fields = (char *)*snowCommonRenderingParam;
		        if ( !*snowCommonRenderingParam )
		          goto LABEL_47;
		        *v25 = (float)((float)(*((float *)static_fields + 20) * 2.5) * v8) + *v25;
		        static_fields = (char *)this->fields.m_sceneEffectSnowDirectionJitterNoiseOffsetList;
		        if ( !static_fields )
		          goto LABEL_47;
		        if ( (unsigned int)i >= *((_DWORD *)static_fields + 6) )
		LABEL_45:
		          sub_1800D2AB0(static_fields, snowflakeTex);
		        v27 = this->fields.m_sceneEffectSnowDirectionJitterNoiseOffsetList;
		        v27->vector[i] = sub_182FACD30(static_fields, snowflakeTex, v26);
		        snowflakeTex = (MethodInfo *)*snowCommonRenderingParam;
		        if ( !*snowCommonRenderingParam )
		          goto LABEL_47;
		        down = UnityEngine::Vector3::get_down(&v99, snowflakeTex);
		        v29 = snowflakeTex;
		        if ( !snowflakeTex )
		          goto LABEL_47;
		        v30 = *(_QWORD *)&down->x;
		        z = down->z;
		        *(_QWORD *)&v91.x = v30;
		        *(_QWORD *)&v92.x = snowflakeTex->parameters;
		        *(float *)&v30 = *(float *)&snowflakeTex->slot * 10.0;
		        v91.z = z;
		        v92.z = *(float *)&snowflakeTex->rgctx_data;
		        Beyond::JobMathf::Clamp01((Beyond::JobMathf *)static_fields, 100.0);
		        Beyond::DampingMath::cosf(v32, v14 * 3.1415927);
		        Beyond::DampingMath::sinf(v33, v14 * 3.1415927);
		        Beyond::DampingMath::sinf(v34, v14 * 3.1415927);
		        Beyond::DampingMath::cosf(v35, v14 * 3.1415927);
		        deltaTime = *(float *)&v30
		                  * (float)((float)((float)((float)((float)((float)((float)((float)((float)((float)(v21 + v21)
		                                                                                          * 3.1415927)
		                                                                                  + (float)(v14 * 3.1415927))
		                                                                          * 0.30000001)
		                                                                  + (float)((float)((float)((float)(v22 + v22)
		                                                                                          * 3.1415927)
		                                                                                  + (float)(v14 * 3.1415927))
		                                                                          * 0.40000001))
		                                                          + (float)((float)((float)((float)(v23 + v23) * 3.1415927)
		                                                                          + (float)(v14 * 3.1415927))
		                                                                  * 0.2))
		                                                  + (float)((float)((float)((float)(v24 + v24) * 3.1415927)
		                                                                  + (float)(v14 * 3.1415927))
		                                                          * 0.1))
		                                          + 1.0)
		                                  * 0.625)
		                          * *(float *)&v29->flags);
		        v36 = UnityEngine::Vector3::Slerp(&v100, &v92, &v91, deltaTime, 0LL);
		        v37 = *(_QWORD *)&v36->x;
		        *(float *)&v36 = v36->z;
		        v93 = v37;
		        v94 = (int)v36;
		        v38 = sub_182FAE2B0(v101, &v93);
		        static_fields = (char *)this->fields.m_sceneEffectSnowAxisOffsetList;
		        v39 = *(float *)(v38 + 8);
		        *(_QWORD *)v95 = *(_QWORD *)v38;
		        v41 = (__m128)LODWORD(v95[0]);
		        v40 = (__m128)LODWORD(v95[1]);
		        v41.m128_f32[0] = v95[0] * v20;
		        v42 = v39 * v20;
		        if ( !static_fields )
		          goto LABEL_47;
		        v43 = (MethodInfo *)sub_180002E90(static_fields, i);
		        v96.z = v42;
		        *(_QWORD *)&v96.x = _mm_unpacklo_ps(v41, v40).m128_u64[0];
		        v44 = UnityEngine::Vector3::op_Multiply(v102, (float)(v17 * snowMaxUVFlowSpeed) * v8, &v96, v43);
		        *(_QWORD *)&v98.x = *(_QWORD *)v45;
		        v46 = *(_QWORD *)&v44->x;
		        v97.z = v44->z;
		        v98.z = *(float *)(v45 + 8);
		        *(_QWORD *)&v97.x = v46;
		        v47 = UnityEngine::Vector3::op_Addition((Vector3 *)&v87, &v98, &v97, (MethodInfo *)v45);
		        static_fields = (char *)LODWORD(v47->z);
		        *(_QWORD *)v48 = *(_QWORD *)&v47->x;
		        *(_DWORD *)(v48 + 8) = (_DWORD)static_fields;
		        m_sceneEffectSnowAxisOffsetList = this->fields.m_sceneEffectSnowAxisOffsetList;
		        if ( !m_sceneEffectSnowAxisOffsetList )
		          goto LABEL_47;
		        sub_180002E90(this->fields.m_sceneEffectSnowAxisOffsetList, i);
		        v53 = sub_182FACD30(v51, v50, v52);
		        *(float *)sub_180002E90(m_sceneEffectSnowAxisOffsetList, i) = v53;
		        v54 = this->fields.m_sceneEffectSnowAxisOffsetList;
		        if ( !v54 )
		          goto LABEL_47;
		        sub_180002E90(this->fields.m_sceneEffectSnowAxisOffsetList, i);
		        v58 = sub_182FACD30(v56, v55, v57);
		        *(float *)(sub_180002E90(v54, i) + 4) = v58;
		        v59 = this->fields.m_sceneEffectSnowAxisOffsetList;
		        if ( !v59 )
		          goto LABEL_47;
		        sub_180002E90(this->fields.m_sceneEffectSnowAxisOffsetList, i);
		        v63 = sub_182FACD30(v61, v60, v62);
		        *(float *)(sub_180002E90(v59, i) + 8) = v63;
		        static_fields = (char *)this->fields.m_sceneEffectSnowDirections;
		        if ( !static_fields )
		          goto LABEL_47;
		        v89 = _mm_unpacklo_ps(v41, v40).m128_u64[0];
		        *(float *)&v90 = v42;
		        sub_180049BD0(static_fields, i, &v89);
		      }
		      m_snowRenderParams = this->fields.m_snowRenderParams;
		      if ( hgCamera )
		      {
		        static_fields = (char *)hgCamera->fields.camera;
		        if ( static_fields )
		        {
		          transform = UnityEngine::Component::get_transform((Component *)static_fields, 0LL);
		          if ( transform )
		          {
		            position = UnityEngine::Transform::get_position((Vector3 *)&v87, transform, 0LL);
		            static_fields = (char *)LODWORD(position->z);
		            if ( m_snowRenderParams )
		            {
		              *(_QWORD *)&m_snowRenderParams->fields.pos.x = *(_QWORD *)&position->x;
		              LODWORD(m_snowRenderParams->fields.pos.z) = (_DWORD)static_fields;
		              static_fields = (char *)this->fields.m_snowRenderParams;
		              snowRange_low = (__m128)LODWORD(snowCommonPreSettingParam->fields.snowRange);
		              maxSnowHeight_low = (__m128)LODWORD(snowCommonPreSettingParam->fields.maxSnowHeight);
		              snowRange_low.m128_f32[0] = snowRange_low.m128_f32[0] / this->fields.m_snowMeshExtents.x;
		              maxSnowHeight_low.m128_f32[0] = maxSnowHeight_low.m128_f32[0] / this->fields.m_snowMeshExtents.y;
		              v71 = snowCommonPreSettingParam->fields.snowRange / this->fields.m_snowMeshExtents.z;
		              if ( static_fields )
		              {
		                *(_QWORD *)(static_fields + 28) = _mm_unpacklo_ps(snowRange_low, maxSnowHeight_low).m128_u64[0];
		                *((float *)static_fields + 9) = v71;
		                static_fields = (char *)*snowCommonRenderingParam;
		                v72 = this->fields.m_snowRenderParams;
		                if ( *snowCommonRenderingParam )
		                {
		                  v73 = _mm_loadu_si128((const __m128i *)static_fields + 2);
		                  if ( v72 )
		                  {
		                    v72->fields.color = (Color)v73;
		                    v74 = *snowCommonRenderingParam;
		                    static_fields = (char *)this->fields.m_snowRenderParams;
		                    if ( *snowCommonRenderingParam )
		                    {
		                      y = v74->fields.snowSizeRange.y;
		                      DWORD1(v87) = LODWORD(v74->fields.snowSizeRange.x);
		                      *(float *)&v76 = v74->fields.intensity * 0.0099999998;
		                      LODWORD(v87) = 1065353216;
		                      *((_QWORD *)&v87 + 1) = __PAIR64__(v76, LODWORD(y));
		                      if ( static_fields )
		                      {
		                        *(_OWORD *)(static_fields + 40) = v87;
		                        static_fields = (char *)this->fields.m_snowRenderParams;
		                        if ( *snowCommonRenderingParam )
		                        {
		                          v77 = (*snowCommonRenderingParam)->fields.snowCommonPreSettingParam;
		                          if ( v77 )
		                          {
		                            snowflakeTex = (MethodInfo *)v77->fields.snowflakeTex;
		                            if ( static_fields )
		                            {
		                              *((_QWORD *)static_fields + 11) = snowflakeTex;
		                              sub_18002D1B0(
		                                (VolumetricRenderer_VolumetricRenderItem *)static_fields + 1,
		                                (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)snowflakeTex,
		                                v67,
		                                v68,
		                                P3,
		                                v85,
		                                SLODWORD(snowMaxUVFlowSpeed),
		                                v87,
		                                *((float *)&v87 + 2),
		                                v88,
		                                v89,
		                                v90,
		                                *(MethodInfo **)&v91.x);
		                              v78 = this->fields.m_snowRenderParams;
		                              if ( *snowCommonRenderingParam )
		                              {
		                                v79 = (*snowCommonRenderingParam)->fields.snowCommonPreSettingParam;
		                                if ( v79 )
		                                {
		                                  v80 = _mm_loadu_si128((const __m128i *)&v79->fields.snowflakeTex_ST);
		                                  if ( v78 )
		                                  {
		                                    v78->fields.snowflakeTextureTilingOffset = (Vector4)v80;
		                                    static_fields = (char *)*snowCommonRenderingParam;
		                                    v81 = this->fields.m_snowRenderParams;
		                                    if ( *snowCommonRenderingParam )
		                                    {
		                                      if ( v81 )
		                                      {
		                                        v81->fields.snowDirectionJitterLevel = *((float *)static_fields + 18);
		                                        static_fields = (char *)this->fields.m_snowRenderParams;
		                                        if ( *snowCommonRenderingParam )
		                                        {
		                                          if ( static_fields )
		                                          {
		                                            *((float *)static_fields + 15) = (*snowCommonRenderingParam)->fields.snowTrailLength
		                                                                           * 0.2;
		                                            static_fields = (char *)this->fields.m_snowRenderParams;
		                                            if ( *snowCommonRenderingParam )
		                                            {
		                                              snowLayerCount = (*snowCommonRenderingParam)->fields.snowLayerCount;
		                                              if ( snowLayerCount > 6 )
		                                                snowLayerCount = 6;
		                                              if ( static_fields )
		                                              {
		                                                *((_DWORD *)static_fields + 20) = snowLayerCount;
		                                                return;
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
		      }
		    }
		LABEL_47:
		    sub_1800D8260(static_fields, snowflakeTex);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5475, 0LL);
		  if ( !Patch )
		    goto LABEL_47;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1590(
		    Patch,
		    (Object *)this,
		    snowCommonRenderingParam,
		    (Object *)hgCamera,
		    deltaTime,
		    0LL);
		}
		
		internal override void SetMaterialData([IsReadOnly] in SnowCommonRenderingParam snowCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189C78594-0x0000000189C78BA0
		// Void SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::SetMaterialData(
		        HGSceneEffectSnowRenderer *this,
		        SnowCommonRenderingParam **snowCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  char *static_fields; // rdx
		  String **p_EDITOR_KW; // rcx
		  SnowCommonRenderingParam *v9; // rax
		  int cameraMask; // esi
		  float snowLightingPercent; // xmm8_4
		  float snowCollisionFadeTimeScale; // xmm7_4
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rax
		  float snowTrailLength; // xmm6_4
		  Vector4 *v15; // rax
		  Material *m_snowMat; // rsi
		  __m128i v17; // xmm10
		  Material *v18; // rsi
		  Material *v19; // rsi
		  SnowCommonRenderingParam *v20; // rax
		  Material *v21; // rbx
		  unsigned int v22; // ebx
		  MaterialPropertyBlock__Array *m_sceneEffectSnowMaterialPropertyBlockList; // rsi
		  __int64 v24; // r14
		  VolumetricRenderer_VolumetricBounds *v25; // r8
		  Int32__Array **v26; // r9
		  float *v27; // rax
		  float v28; // xmm9_4
		  __int64 v29; // rax
		  float v30; // xmm8_4
		  float v31; // xmm7_4
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v32; // rax
		  float snowDirectionJitterLevel; // xmm6_4
		  Vector4 *v34; // rax
		  __m128i v35; // xmm6
		  MaterialPropertyBlock *v36; // rsi
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v37; // r8
		  MethodInfo *v38; // r8
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v39; // rax
		  Color *v40; // rax
		  MaterialPropertyBlock *v41; // r10
		  MaterialPropertyBlock *v42; // rsi
		  int32_t RainOffsetParams; // r14d
		  MethodInfo *v44; // r8
		  Vector4 *v45; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v47; // [rsp+28h] [rbp-69h]
		  MethodInfo *v48; // [rsp+30h] [rbp-61h]
		  Vector3 v49; // [rsp+38h] [rbp-59h] BYREF
		  Vector3 v50; // [rsp+48h] [rbp-49h] BYREF
		  __m128i color; // [rsp+58h] [rbp-39h] BYREF
		  Vector4 v52; // [rsp+68h] [rbp-29h] BYREF
		  Color v53; // [rsp+78h] [rbp-19h] BYREF
		  Vector4 v54; // [rsp+88h] [rbp-9h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5476, 0LL) )
		  {
		    v9 = *snowCommonRenderingParam;
		    if ( *snowCommonRenderingParam )
		    {
		      cameraMask = v9->fields.cameraMask;
		      snowLightingPercent = v9->fields.snowLightingPercent;
		      snowCollisionFadeTimeScale = v9->fields.snowCollisionFadeTimeScale;
		      m_snowRenderParams = this->fields.m_snowRenderParams;
		      if ( m_snowRenderParams )
		      {
		        snowTrailLength = m_snowRenderParams->fields.snowTrailLength;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                (Vector4 *)&color,
		                (float)cameraMask,
		                snowLightingPercent,
		                snowCollisionFadeTimeScale,
		                snowTrailLength,
		                0LL);
		        m_snowMat = this->fields.m_snowMat;
		        v17 = _mm_loadu_si128((const __m128i *)v15);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
		        static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields;
		        if ( m_snowMat )
		        {
		          UnityEngine::Material::EnableKeyword(m_snowMat, *((String **)static_fields + 2), 0LL);
		          if ( *snowCommonRenderingParam )
		          {
		            if ( (*snowCommonRenderingParam)->fields.enableSnowLighting
		              && (*snowCommonRenderingParam)->fields.snowLightingPercent > TypeInfo::UnityEngine::Mathf->static_fields->Epsilon )
		            {
		              v18 = this->fields.m_snowMat;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		              static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		              if ( !v18 )
		                goto LABEL_58;
		              UnityEngine::Material::EnableKeyword(v18, *((String **)static_fields + 1), 0LL);
		            }
		            else
		            {
		              v19 = this->fields.m_snowMat;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		              static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		              if ( !v19 )
		                goto LABEL_58;
		              UnityEngine::Material::DisableKeyword(v19, *((String **)static_fields + 1), 0LL);
		            }
		            v20 = *snowCommonRenderingParam;
		            if ( *snowCommonRenderingParam )
		            {
		              v21 = this->fields.m_snowMat;
		              if ( v20->fields.enableSnowCollision )
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
		                static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields;
		                if ( !v21 )
		                  goto LABEL_58;
		                UnityEngine::Material::EnableKeyword(v21, *((String **)static_fields + 3), 0LL);
		              }
		              else
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
		                p_EDITOR_KW = &TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->EDITOR_KW;
		                if ( !v21 )
		                  goto LABEL_58;
		                UnityEngine::Material::DisableKeyword(v21, p_EDITOR_KW[3], 0LL);
		              }
		              v22 = 0;
		              while ( 1 )
		              {
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                if ( !p_EDITOR_KW[(int)v22 + 4] )
		                {
		                  m_sceneEffectSnowMaterialPropertyBlockList = this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                  v24 = sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		                  if ( !v24 )
		                    break;
		                  *(_QWORD *)(v24 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		                  if ( v22 >= m_sceneEffectSnowMaterialPropertyBlockList->max_length.size )
		LABEL_56:
		                    sub_1800D2AB0(p_EDITOR_KW, static_fields);
		                  m_sceneEffectSnowMaterialPropertyBlockList->vector[v22] = (MaterialPropertyBlock *)v24;
		                  sub_18002D1B0(
		                    (VolumetricRenderer_VolumetricRenderItem *)&m_sceneEffectSnowMaterialPropertyBlockList->vector[v22],
		                    (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)static_fields,
		                    v25,
		                    v26,
		                    v47,
		                    v48,
		                    SLODWORD(v49.x),
		                    SLODWORD(v49.z),
		                    v50.x,
		                    SLODWORD(v50.z),
		                    color.m128i_i8[0],
		                    color.m128i_i8[8],
		                    *(MethodInfo **)&v52.x);
		                }
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowDirections;
		                if ( !p_EDITOR_KW )
		                  break;
		                v27 = (float *)sub_180002E90(p_EDITOR_KW, (int)v22);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowDirections;
		                v28 = *v27;
		                if ( !p_EDITOR_KW )
		                  break;
		                v29 = sub_180002E90(p_EDITOR_KW, (int)v22);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowDirections;
		                v30 = *(float *)(v29 + 4);
		                if ( !p_EDITOR_KW )
		                  break;
		                v31 = *(float *)(sub_180002E90(p_EDITOR_KW, (int)v22) + 8);
		                v32 = this->fields.m_snowRenderParams;
		                if ( !v32 )
		                  break;
		                snowDirectionJitterLevel = v32->fields.snowDirectionJitterLevel;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                v34 = HG::Rendering::Runtime::HGUtils::PackVector4(&v52, v28, v30, v31, snowDirectionJitterLevel, 0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                v35 = _mm_loadu_si128((const __m128i *)v34);
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                v36 = (MaterialPropertyBlock *)p_EDITOR_KW[(int)v22 + 4];
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                v37 = this->fields.m_snowRenderParams;
		                if ( !v37 )
		                  break;
		                HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		                  v36,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex0,
		                  (Texture *)v37->fields.snowflakeTexture,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                static_fields = (char *)this->fields.m_snowRenderParams;
		                if ( !static_fields )
		                  break;
		                p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
		                if ( !p_EDITOR_KW )
		                  break;
		                color = *((__m128i *)static_fields + 6);
		                UnityEngine::MaterialPropertyBlock::SetVector(
		                  (MaterialPropertyBlock *)p_EDITOR_KW,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex0_ST,
		                  (Vector4 *)&color,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                static_fields = (char *)this->fields.m_snowRenderParams;
		                if ( !static_fields )
		                  break;
		                p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
		                if ( !p_EDITOR_KW )
		                  break;
		                color = *(__m128i *)(static_fields + 40);
		                UnityEngine::MaterialPropertyBlock::SetVector(
		                  (MaterialPropertyBlock *)p_EDITOR_KW,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainParams,
		                  (Vector4 *)&color,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
		                if ( !p_EDITOR_KW )
		                  break;
		                color = v35;
		                UnityEngine::MaterialPropertyBlock::SetVector(
		                  (MaterialPropertyBlock *)p_EDITOR_KW,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainDirectionParams,
		                  (Vector4 *)&color,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                v39 = this->fields.m_snowRenderParams;
		                if ( !v39 )
		                  break;
		                color = (__m128i)v39->fields.color;
		                v40 = UnityEngine::Color::op_Implicit(&v53, (Vector4 *)&color, v38);
		                if ( !v41 )
		                  break;
		                color = *(__m128i *)v40;
		                UnityEngine::MaterialPropertyBlock::SetVector(
		                  v41,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainColor,
		                  (Vector4 *)&color,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
		                if ( !p_EDITOR_KW )
		                  break;
		                color = v17;
		                UnityEngine::MaterialPropertyBlock::SetVector(
		                  (MaterialPropertyBlock *)p_EDITOR_KW,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainMaskParams,
		                  (Vector4 *)&color,
		                  0LL);
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		                if ( !p_EDITOR_KW )
		                  break;
		                if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
		                  goto LABEL_56;
		                v42 = (MaterialPropertyBlock *)p_EDITOR_KW[(int)v22 + 4];
		                RainOffsetParams = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainOffsetParams;
		                p_EDITOR_KW = (String **)this->fields.m_sceneEffectSnowAxisOffsetList;
		                if ( !p_EDITOR_KW )
		                  break;
		                sub_180049C60(p_EDITOR_KW, &v49, (int)v22);
		                v50 = v49;
		                v45 = UnityEngine::Vector4::op_Implicit(&v54, &v50, v44);
		                if ( !v42 )
		                  break;
		                color = *(__m128i *)v45;
		                UnityEngine::MaterialPropertyBlock::SetVector(v42, RainOffsetParams, (Vector4 *)&color, 0LL);
		                if ( (int)++v22 >= 6 )
		                  return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_58:
		    sub_1800D8260(p_EDITOR_KW, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5476, 0LL);
		  if ( !Patch )
		    goto LABEL_58;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(Patch, (Object *)this, snowCommonRenderingParam, context, 0LL);
		}
		
		internal override void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189C7832C-0x0000000189C78594
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::Render(
		        HGSceneEffectSnowRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object_1 *m_snowMesh; // rbx
		  Object_1 *m_snowMat; // rbx
		  _DWORD *m_sceneEffectSnowMaterialPropertyBlockList; // rdx
		  CommandBuffer *s_sceneEffectLayerScale; // rcx
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rax
		  int snowLayerCount; // r14d
		  unsigned int v13; // ebx
		  __int64 v14; // xmm6_8
		  float z; // r15d
		  HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v16; // rax
		  Quaternion *identity; // rax
		  Matrix4x4 *v18; // rax
		  __int128 v19; // xmm1
		  Material *v20; // r9
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v24; // [rsp+48h] [rbp-C0h]
		  float v25; // [rsp+50h] [rbp-B8h]
		  Vector3 v26; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v27; // [rsp+68h] [rbp-A0h] BYREF
		  Quaternion v28; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v29; // [rsp+88h] [rbp-80h] BYREF
		  Quaternion v30; // [rsp+C8h] [rbp-40h] BYREF
		  Matrix4x4 v31; // [rsp+D8h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5477, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5477, 0LL);
		    if ( !Patch )
		      goto LABEL_20;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( this->fields._.enabled )
		  {
		    m_snowMesh = (Object_1 *)this->fields.m_snowMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_snowMesh, 0LL, 0LL) )
		    {
		      m_snowMat = (Object_1 *)this->fields.m_snowMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_snowMat, 0LL, 0LL) )
		      {
		        m_snowRenderParams = this->fields.m_snowRenderParams;
		        if ( !m_snowRenderParams )
		          goto LABEL_20;
		        snowLayerCount = m_snowRenderParams->fields.snowLayerCount;
		        v13 = 0;
		        v14 = *(_QWORD *)&m_snowRenderParams->fields.pos.x;
		        z = m_snowRenderParams->fields.pos.z;
		        if ( snowLayerCount > 0 )
		        {
		          while ( 1 )
		          {
		            v16 = this->fields.m_snowRenderParams;
		            if ( !v16 )
		              break;
		            v24 = *(_QWORD *)&v16->fields.scale.x;
		            v25 = v16->fields.scale.z;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
		            m_sceneEffectSnowMaterialPropertyBlockList = TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer;
		            s_sceneEffectLayerScale = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer->static_fields->s_sceneEffectLayerScale;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            if ( v13 >= LODWORD(s_sceneEffectLayerScale[1].klass) )
		              goto LABEL_18;
		            *(float *)&v24 = *(float *)&v24 * *((float *)&s_sceneEffectLayerScale[1].monitor + (int)v13);
		            s_sceneEffectLayerScale = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer->static_fields->s_sceneEffectLayerScale;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            if ( v13 >= LODWORD(s_sceneEffectLayerScale[1].klass) )
		              goto LABEL_18;
		            *(_QWORD *)&v26.x = v24;
		            v26.z = v25 * *((float *)&s_sceneEffectLayerScale[1].monitor + (int)v13);
		            identity = UnityEngine::Quaternion::get_identity(
		                         &v30,
		                         (MethodInfo *)TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
		            *(_QWORD *)&v27.x = v14;
		            v27.z = z;
		            v28 = *identity;
		            v18 = UnityEngine::Matrix4x4::TRS(&v31, &v27, &v28, &v26, 0LL);
		            if ( !ctx )
		              break;
		            m_sceneEffectSnowMaterialPropertyBlockList = this->fields.m_sceneEffectSnowMaterialPropertyBlockList;
		            if ( !m_sceneEffectSnowMaterialPropertyBlockList )
		              break;
		            if ( v13 >= m_sceneEffectSnowMaterialPropertyBlockList[6] )
		LABEL_18:
		              sub_1800D2AB0(s_sceneEffectLayerScale, m_sceneEffectSnowMaterialPropertyBlockList);
		            s_sceneEffectLayerScale = ctx->fields.cmd;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            v19 = *(_OWORD *)&v18->m01;
		            v20 = this->fields.m_snowMat;
		            *(_OWORD *)&v29.m00 = *(_OWORD *)&v18->m00;
		            v21 = *(_OWORD *)&v18->m02;
		            *(_OWORD *)&v29.m01 = v19;
		            v22 = *(_OWORD *)&v18->m03;
		            *(_OWORD *)&v29.m02 = v21;
		            *(_OWORD *)&v29.m03 = v22;
		            UnityEngine::Rendering::CommandBuffer::DrawMesh(
		              s_sceneEffectLayerScale,
		              this->fields.m_snowMesh,
		              &v29,
		              v20,
		              0,
		              0,
		              *(MaterialPropertyBlock **)&m_sceneEffectSnowMaterialPropertyBlockList[2 * v13++ + 8],
		              0LL);
		            if ( (int)v13 >= snowLayerCount )
		              return;
		          }
		LABEL_20:
		          sub_1800D8260(s_sceneEffectLayerScale, m_sceneEffectSnowMaterialPropertyBlockList);
		        }
		      }
		    }
		  }
		}
		
		internal override void Dispose() {} // 0x0000000184CE4D80-0x0000000184CE4DC0
		// Void Dispose()
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::Dispose(
		        HGSceneEffectSnowRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5478, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5478, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeMaterial(
		      (HGBaseSubSnowRenderer *)this,
		      this->fields.m_snowMat,
		      0LL);
		  }
		}
		
		public void __iFixBaseProxy_SetMaterialData(ref SnowCommonRenderingParam P0, ref ScriptableRenderContext P1) {} // 0x0000000189C78BB0-0x0000000189C78BB8
		// Void <>iFixBaseProxy_SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_SetMaterialData(
		        HGSceneEffectSnowRenderer *this,
		        SnowCommonRenderingParam **P0,
		        ScriptableRenderContext *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::SetMaterialData((HGBaseSubSnowRenderer *)this, P0, P1, 0LL);
		}
		
		public void __iFixBaseProxy_Render(HGRenderGraphContext P0, HGCamera P1) {} // 0x0000000189C78BA8-0x0000000189C78BB0
		// Void <>iFixBaseProxy_Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_Render(
		        HGSceneEffectSnowRenderer *this,
		        HGRenderGraphContext *P0,
		        HGCamera *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Render((HGBaseSubSnowRenderer *)this, P0, P1, 0LL);
		}
		
		public void __iFixBaseProxy_Dispose() {} // 0x0000000189C78BA0-0x0000000189C78BA8
		// Void <>iFixBaseProxy_Dispose()
		void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_Dispose(
		        HGSceneEffectSnowRenderer *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Dispose((HGBaseSubSnowRenderer *)this, 0LL);
		}
		
	}
}
