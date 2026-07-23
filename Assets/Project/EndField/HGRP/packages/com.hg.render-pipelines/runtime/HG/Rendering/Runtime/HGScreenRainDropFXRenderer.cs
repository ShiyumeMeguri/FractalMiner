using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Rain;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGScreenRainDropFXRenderer : HGBaseSubRainRenderer // TypeDefIndex: 37677
	{
		// Fields
		private const int MAXDROPCOUNT = 30; // Metadata: 0x0230305B
		private const int DROPRENDERDATA_BUFFER_SIZE = 480; // Metadata: 0x0230305C
		private Mesh m_screenDropMesh; // 0x20
		private Shader m_screenDropShader; // 0x28
		private Material m_screenDropMat; // 0x30
		private MaterialPropertyBlock m_materialPropertyBlock; // 0x38
		private ScreenRainDropFXRendererParams m_screenRainDropFXRendererParams; // 0x40
		private bool[] m_dropActive; // 0x48
		private Vector4[] m_dropUpdateData; // 0x50
		private Vector4[] m_DropRenderParam; // 0x58
		private NativeArray<Vector4> m_dropRenderDatas; // 0x60
		private int m_visibleCount; // 0x70
		private float s_jitterTime; // 0x74
		private float s_jitterFreq; // 0x78
	
		// Nested types
		internal class ScreenRainDropFXRendererParams // TypeDefIndex: 37676
		{
			// Fields
			public UnityEngine.Color color; // 0x10
			public Vector4 rainParams; // 0x20
			public Texture2D noiseTexture; // 0x30
			public Vector4 noiseTextureScaleOffset; // 0x38
			public Vector3 pos; // 0x48
	
			// Constructors
			public ScreenRainDropFXRendererParams() {} // 0x0000000182EDE430-0x0000000182EDE4A0
			// HGScreenRainDropFXRenderer+ScreenRainDropFXRendererParams()
			void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ScreenRainDropFXRendererParams::ScreenRainDropFXRendererParams(
			        HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *this,
			        MethodInfo *method)
			{
			  Vector3Int *v2; // r8
			  ITilemap *v3; // r9
			  TileBase *v5; // rdx
			  Vector3Int *v6; // r8
			  ITilemap *v7; // r9
			  HGRuntimeGrassQuery_Node *v8; // rdx
			  HGRuntimeGrassQuery_Node *v9; // r8
			  Int32__Array **v10; // r9
			  TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
			
			  this->fields.color = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			                                 &v11,
			                                 (TileBase *)method,
			                                 v2,
			                                 v3,
			                                 (MethodInfo *)v11.m_AnimatedSprites);
			  this->fields.rainParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			                                        &v11,
			                                        v5,
			                                        v6,
			                                        v7,
			                                        (MethodInfo *)v11.m_AnimatedSprites);
			  this->fields.noiseTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)&this->fields.noiseTexture,
			    v8,
			    v9,
			    v10,
			    (MethodInfo *)v11.m_AnimatedSprites);
			  this->fields.noiseTextureScaleOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
			  *(_QWORD *)&this->fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			  this->fields.pos.z = 0.0;
			}
			
		}
	
		// Constructors
		public HGScreenRainDropFXRenderer() {} // 0x0000000182EDE9F0-0x0000000182EDEAF0
		// HGScreenRainDropFXRenderer()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::HGScreenRainDropFXRenderer(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  MaterialPropertyBlock *v5; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v9; // rax
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v10; // rdi
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		
		  v5 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v5
		    || (v5->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
		        this->fields.m_materialPropertyBlock = v5,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_materialPropertyBlock, v6, v7, v8, v23),
		        v9 = (HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ScreenRainDropFXRendererParams),
		        (v10 = v9) == 0LL) )
		  {
		    sub_1800D8260(v4, v3);
		  }
		  HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ScreenRainDropFXRendererParams::ScreenRainDropFXRendererParams(
		    v9,
		    0LL);
		  this->fields.m_screenRainDropFXRendererParams = v10;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_screenRainDropFXRendererParams, v11, v12, v13, v24);
		  this->fields.m_dropActive = (Boolean__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Boolean, 30LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_dropActive, v14, v15, v16, v25);
		  this->fields.m_dropUpdateData = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 30LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_dropUpdateData, v17, v18, v19, v26);
		  this->fields.m_DropRenderParam = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 30LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_DropRenderParam, v20, v21, v22, v27);
		  this->fields.s_jitterTime = 0.2;
		  this->fields.s_jitterFreq = 2.0;
		  if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		  this->fields._.enabled = 1;
		  this->fields._.rainRenderQueue = 3000;
		}
		
	
		// Methods
		internal override void PrepareResources(RainCommonResources commonResources) {} // 0x00000001843DDE80-0x00000001843DE000
		// Void PrepareResources(RainCommonResources)
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::PrepareResources(
		        HGScreenRainDropFXRenderer *this,
		        RainCommonResources *commonResources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  Material *v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  Shader *screenRainDropFXShader; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Shader *m_screenDropShader; // rdi
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Material *m_screenDropMat; // rdi
		  struct HGBaseSubRainRenderer__Class *v17; // rax
		  Object_1 *v18; // rdi
		  HideFlags__Enum *static_fields; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-28h]
		  NativeArray_1_UnityEngine_Vector4_ v24; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1602, 0LL) )
		  {
		    if ( !commonResources )
		      goto LABEL_3;
		    this->fields.m_screenDropMesh = commonResources->fields.screenDropFxMesh;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_screenDropMesh, v5, v7, v8, methoda);
		    screenRainDropFXShader = commonResources->fields.screenRainDropFXShader;
		    this->fields.m_screenDropShader = screenRainDropFXShader;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&this->fields.m_screenDropShader,
		      v10,
		      v11,
		      (Int32__Array **)screenRainDropFXShader,
		      methodc);
		    m_screenDropShader = this->fields.m_screenDropShader;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_screenDropMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                     m_screenDropShader,
		                                     0,
		                                     0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_screenDropMat, v13, v14, v15, methodb);
		    v6 = (Material *)TypeInfo::UnityEngine::Object;
		    m_screenDropMat = this->fields.m_screenDropMat;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = (Material *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = (Material *)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !m_screenDropMat )
		      goto LABEL_10;
		    if ( !LODWORD(v6[9].monitor) )
		      il2cpp_runtime_class_init_1(v6);
		    if ( !m_screenDropMat->fields._.m_CachedPtr )
		      goto LABEL_10;
		    v17 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		    v18 = (Object_1 *)this->fields.m_screenDropMat;
		    if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		      v17 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		    }
		    static_fields = (HideFlags__Enum *)v17->static_fields;
		    if ( v18 )
		    {
		      UnityEngine::Object::set_hideFlags(v18, *static_fields, 0LL);
		      v6 = this->fields.m_screenDropMat;
		      if ( v6 )
		      {
		        UnityEngine::Material::set_renderQueue(v6, 3003, 0LL);
		LABEL_10:
		        v24 = 0LL;
		        Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		          &v24,
		          30,
		          Allocator__Enum_Persistent,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		        this->fields.m_dropRenderDatas = v24;
		        HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(this, 0LL);
		        return;
		      }
		    }
		LABEL_3:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1602, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)commonResources,
		    0LL);
		}
		
		internal override void UpdateData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime) {} // 0x0000000189CF366C-0x0000000189CF3E44
		// Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::UpdateData(
		        HGScreenRainDropFXRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        HGCamera *hgCamera,
		        float deltaTime,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *screenDropFXNoiseTex; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  char *m_screenRainDropFXRendererParams; // rcx
		  __m128i v12; // xmm0
		  RainCommonPreSettingParam *commonPresettingParam; // rax
		  int v14; // r8d
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v15; // r9
		  RainCommonPreSettingParam *v16; // rax
		  __m128i v17; // xmm0
		  RainCommonRenderingParam *v18; // rax
		  float x; // xmm0_4
		  float y; // xmm1_4
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v21; // rax
		  unsigned int v22; // xmm2_4
		  RainCommonRenderingParam *v23; // rax
		  float v24; // xmm15_4
		  float v25; // xmm12_4
		  float v26; // xmm1_4
		  int v27; // eax
		  int v28; // r15d
		  __int64 v29; // xmm6_8
		  int v30; // r14d
		  Transform *transform; // rax
		  Vector3 *right; // rax
		  __int64 v33; // xmm0_8
		  __int64 v34; // rax
		  __int64 v35; // xmm6_8
		  float v36; // r14d
		  float v37; // xmm7_4
		  Transform *v38; // rax
		  Vector3 *v39; // rax
		  __int64 v40; // xmm0_8
		  MethodInfo *v41; // r8
		  MethodInfo *v42; // rdx
		  unsigned int v43; // edi
		  float v44; // xmm14_4
		  Vector4__Array *m_DropRenderParam; // r14
		  Vector4 *NewDropInfo; // rax
		  Vector4__Array *m_dropUpdateData; // r14
		  float screenDropFlowPercent; // xmm6_4
		  __int64 v49; // rax
		  Vector4__Array *v50; // r14
		  float v51; // xmm6_4
		  float v52; // xmm0_4
		  float v53; // xmm7_4
		  float s_jitterTime; // xmm6_4
		  float v55; // xmm7_4
		  float screenDropJitterSpeedScale; // xmm8_4
		  float v57; // xmm6_4
		  Beyond::DampingMath *v58; // rcx
		  __int64 v59; // rax
		  float *v60; // rax
		  float v61; // xmm6_4
		  __int64 v62; // rax
		  float v63; // xmm6_4
		  __int64 v64; // rax
		  __int64 v65; // r9
		  __int64 m_visibleCount; // r14
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  Vector2 v69; // [rsp+38h] [rbp-D0h]
		  Vector2 screenDropMinMaxSize; // [rsp+40h] [rbp-C8h]
		  Vector2 screenDropMinMaxLifeTime; // [rsp+48h] [rbp-C0h]
		  Vector4 v72; // [rsp+58h] [rbp-B0h] BYREF
		  __int128 v73; // [rsp+68h] [rbp-A0h] BYREF
		  Vector4 v74; // [rsp+78h] [rbp-90h] BYREF
		  Vector4 v75; // [rsp+88h] [rbp-80h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1604, 0LL) )
		  {
		    m_screenRainDropFXRendererParams = (char *)this->fields.m_screenRainDropFXRendererParams;
		    if ( *rainCommonRenderingParam )
		    {
		      v12 = _mm_loadu_si128((const __m128i *)&(*rainCommonRenderingParam)->fields.screenDropColor);
		      if ( m_screenRainDropFXRendererParams )
		      {
		        *((__m128i *)m_screenRainDropFXRendererParams + 1) = v12;
		        m_screenRainDropFXRendererParams = (char *)this->fields.m_screenRainDropFXRendererParams;
		        if ( *rainCommonRenderingParam )
		        {
		          commonPresettingParam = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		          if ( commonPresettingParam )
		          {
		            screenDropFXNoiseTex = (HGRuntimeGrassQuery_Node *)commonPresettingParam->fields.screenDropFXNoiseTex;
		            if ( m_screenRainDropFXRendererParams )
		            {
		              *((_QWORD *)m_screenRainDropFXRendererParams + 6) = screenDropFXNoiseTex;
		              sub_18002D1B0(
		                (HGRuntimeGrassQuery_Node *)(m_screenRainDropFXRendererParams + 48),
		                screenDropFXNoiseTex,
		                v9,
		                v10,
		                P3);
		              v15 = this->fields.m_screenRainDropFXRendererParams;
		              if ( *rainCommonRenderingParam )
		              {
		                v16 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		                if ( v16 )
		                {
		                  v17 = _mm_loadu_si128((const __m128i *)&v16->fields.screenDropFXNoiseTex_ST);
		                  if ( v15 )
		                  {
		                    v15->fields.noiseTextureScaleOffset = (Vector4)v17;
		                    v18 = *rainCommonRenderingParam;
		                    if ( *rainCommonRenderingParam )
		                    {
		                      m_screenRainDropFXRendererParams = (char *)v18->fields.commonPresettingParam;
		                      if ( m_screenRainDropFXRendererParams )
		                      {
		                        x = v18->fields.screenDropCentroidFadeParam.x;
		                        y = v18->fields.screenDropCentroidFadeParam.y;
		                        v21 = this->fields.m_screenRainDropFXRendererParams;
		                        v22 = *((_DWORD *)m_screenRainDropFXRendererParams + 46);
		                        v74.x = *((float *)m_screenRainDropFXRendererParams + 45);
		                        *(_QWORD *)&v74.y = __PAIR64__(LODWORD(x), v22);
		                        v74.w = y;
		                        if ( v21 )
		                        {
		                          v21->fields.rainParams = v74;
		                          v23 = *rainCommonRenderingParam;
		                          if ( *rainCommonRenderingParam )
		                          {
		                            m_screenRainDropFXRendererParams = (char *)v23->fields.commonPresettingParam;
		                            v24 = v23->fields.screenDropMinMaxSpeed.x;
		                            v25 = v23->fields.screenDropMinMaxSpeed.y;
		                            screenDropMinMaxLifeTime = v23->fields.screenDropMinMaxLifeTime;
		                            screenDropMinMaxSize = v23->fields.screenDropMinMaxSize;
		                            if ( m_screenRainDropFXRendererParams )
		                            {
		                              v69 = *(Vector2 *)(m_screenRainDropFXRendererParams + 172);
		                              if ( v23 )
		                              {
		                                v26 = this->fields._.enabled ? v23->fields.intensity : 0.0;
		                                v27 = sub_1834464B0(
		                                        (unsigned int)v23->fields.screenDropMaxCountLim,
		                                        (_BYTE)screenDropFXNoiseTex,
		                                        v14);
		                                m_screenRainDropFXRendererParams = (char *)*rainCommonRenderingParam;
		                                v28 = v27;
		                                if ( *rainCommonRenderingParam )
		                                {
		                                  v29 = *(_QWORD *)(m_screenRainDropFXRendererParams + 100);
		                                  v30 = *((_DWORD *)m_screenRainDropFXRendererParams + 27);
		                                  if ( hgCamera )
		                                  {
		                                    m_screenRainDropFXRendererParams = (char *)hgCamera->fields.camera;
		                                    if ( m_screenRainDropFXRendererParams )
		                                    {
		                                      transform = UnityEngine::Component::get_transform(
		                                                    (Component *)m_screenRainDropFXRendererParams,
		                                                    0LL);
		                                      if ( transform )
		                                      {
		                                        right = UnityEngine::Transform::get_right((Vector3 *)&v73, transform, 0LL);
		                                        v33 = *(_QWORD *)&right->x;
		                                        *(float *)&right = right->z;
		                                        *(_QWORD *)&v72.x = v33;
		                                        LODWORD(v72.z) = (_DWORD)right;
		                                        *(_QWORD *)&v73 = v29;
		                                        DWORD2(v73) = v30;
		                                        v34 = sub_18391D570(&v74, &v73, &v72);
		                                        v35 = *(_QWORD *)v34;
		                                        v36 = *(float *)(v34 + 8);
		                                        *(_QWORD *)&v73 = *(_QWORD *)v34;
		                                        *((float *)&v73 + 2) = v36;
		                                        *(float *)&v33 = sub_182F9FF00(&v73);
		                                        m_screenRainDropFXRendererParams = (char *)hgCamera->fields.camera;
		                                        v37 = *(float *)&v33;
		                                        if ( m_screenRainDropFXRendererParams )
		                                        {
		                                          v38 = UnityEngine::Component::get_transform(
		                                                  (Component *)m_screenRainDropFXRendererParams,
		                                                  0LL);
		                                          if ( v38 )
		                                          {
		                                            v39 = UnityEngine::Transform::get_right((Vector3 *)&v74, v38, 0LL);
		                                            *(_QWORD *)&v72.x = v35;
		                                            v72.z = v36;
		                                            v40 = *(_QWORD *)&v39->x;
		                                            *(float *)&v39 = v39->z;
		                                            *(_QWORD *)&v73 = v40;
		                                            DWORD2(v73) = (_DWORD)v39;
		                                            *(float *)&v40 = UnityEngine::Vector3::Dot(
		                                                               (Vector3 *)&v72,
		                                                               (Vector3 *)&v73,
		                                                               v41);
		                                            *(float *)&v40 = UnityEngine::Mathf::Sign(*(float *)&v40, v42);
		                                            this->fields.m_visibleCount = 0;
		                                            v43 = 0;
		                                            v44 = *(float *)&v40 * v37;
		                                            while ( 1 )
		                                            {
		                                              if ( (int)v43 < v28 )
		                                              {
		                                                m_screenRainDropFXRendererParams = (char *)this->fields.m_dropActive;
		                                                if ( !m_screenRainDropFXRendererParams )
		                                                  break;
		                                                if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
		                                                  goto LABEL_72;
		                                                if ( !m_screenRainDropFXRendererParams[v43 + 32] )
		                                                {
		                                                  m_DropRenderParam = this->fields.m_DropRenderParam;
		                                                  NewDropInfo = HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropInfo(
		                                                                  &v72,
		                                                                  this,
		                                                                  screenDropMinMaxLifeTime,
		                                                                  screenDropMinMaxSize,
		                                                                  v69,
		                                                                  0LL);
		                                                  if ( !m_DropRenderParam )
		                                                    break;
		                                                  v74 = *NewDropInfo;
		                                                  sub_18003FEF0(m_DropRenderParam, (int)v43, &v74);
		                                                  m_dropUpdateData = this->fields.m_dropUpdateData;
		                                                  if ( !*rainCommonRenderingParam )
		                                                    break;
		                                                  screenDropFlowPercent = (*rainCommonRenderingParam)->fields.screenDropFlowPercent;
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                  if ( !m_dropUpdateData )
		                                                    break;
		                                                  v49 = sub_180002100(m_screenRainDropFXRendererParams, (int)v43);
		                                                  v74 = *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropUpdateData(
		                                                           &v75,
		                                                           this,
		                                                           screenDropFlowPercent,
		                                                           *(float *)(v49 + 8) > COERCE_FLOAT(1),
		                                                           0LL);
		                                                  sub_18003FEF0(m_dropUpdateData, (int)v43, &v74);
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropActive;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
		                                                    goto LABEL_72;
		                                                  m_screenRainDropFXRendererParams[v43 + 32] = 1;
		                                                }
		                                              }
		                                              m_screenRainDropFXRendererParams = (char *)this->fields.m_dropActive;
		                                              if ( !m_screenRainDropFXRendererParams )
		                                                break;
		                                              if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
		LABEL_72:
		                                                sub_1800D2AB0(m_screenRainDropFXRendererParams, screenDropFXNoiseTex);
		                                              if ( m_screenRainDropFXRendererParams[v43 + 32] )
		                                              {
		                                                m_screenRainDropFXRendererParams = (char *)this->fields.m_DropRenderParam;
		                                                if ( !m_screenRainDropFXRendererParams )
		                                                  break;
		                                                if ( *(float *)(sub_180002100(
		                                                                  m_screenRainDropFXRendererParams,
		                                                                  (int)v43)
		                                                              + 8) > 0.0 )
		                                                {
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  if ( *(float *)(sub_180002100(
		                                                                    m_screenRainDropFXRendererParams,
		                                                                    (int)v43)
		                                                                + 4) > COERCE_FLOAT(1) )
		                                                  {
		                                                    m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                    if ( !m_screenRainDropFXRendererParams )
		                                                      break;
		                                                    if ( *(float *)sub_180002100(
		                                                                     m_screenRainDropFXRendererParams,
		                                                                     (int)v43) >= COERCE_FLOAT(1) )
		                                                    {
		                                                      v50 = this->fields.m_dropUpdateData;
		                                                      if ( !v50 )
		                                                        break;
		                                                      v51 = *(float *)sub_180002100(
		                                                                        this->fields.m_dropUpdateData,
		                                                                        (int)v43)
		                                                          - deltaTime;
		                                                      if ( v51 < 0.0 )
		                                                        v51 = 0.0;
		                                                      goto LABEL_55;
		                                                    }
		                                                    v26 = 1.0;
		                                                    v52 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
		                                                    m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                    if ( !m_screenRainDropFXRendererParams )
		                                                      break;
		                                                    if ( v52 > *(float *)(sub_180002100(
		                                                                            m_screenRainDropFXRendererParams,
		                                                                            (int)v43)
		                                                                        + 4) )
		                                                    {
		                                                      v50 = this->fields.m_dropUpdateData;
		                                                      if ( !v50 )
		                                                        break;
		                                                      v26 = v25;
		                                                      v51 = UnityEngine::Random::Range(v24, v25, 0LL);
		LABEL_55:
		                                                      *(float *)sub_180002100(v50, (int)v43) = v51;
		                                                    }
		                                                  }
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                  v53 = 0.0;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  s_jitterTime = this->fields.s_jitterTime;
		                                                  if ( (float)(s_jitterTime
		                                                             - *(float *)(sub_180002100(
		                                                                            m_screenRainDropFXRendererParams,
		                                                                            (int)v43)
		                                                                        + 8)) > TypeInfo::UnityEngine::Mathf->static_fields->Epsilon )
		                                                  {
		                                                    m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                    if ( !m_screenRainDropFXRendererParams )
		                                                      break;
		                                                    v55 = (float)(*(float *)(sub_180002100(
		                                                                               m_screenRainDropFXRendererParams,
		                                                                               (int)v43)
		                                                                           + 8)
		                                                                * 10.0)
		                                                        * 3.1415927;
		                                                    if ( !*rainCommonRenderingParam )
		                                                      break;
		                                                    m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                    screenDropJitterSpeedScale = (*rainCommonRenderingParam)->fields.screenDropJitterSpeedScale;
		                                                    if ( !m_screenRainDropFXRendererParams )
		                                                      break;
		                                                    v57 = *(float *)(sub_180002100(
		                                                                       m_screenRainDropFXRendererParams,
		                                                                       (int)v43)
		                                                                   + 8);
		                                                    Beyond::DampingMath::cosf(v58, v26);
		                                                    m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                    v26 = 1.0 - (float)(v57 / this->fields.s_jitterTime);
		                                                    v53 = (float)((float)((float)(v55 + v55) * v25)
		                                                                * screenDropJitterSpeedScale)
		                                                        * v26;
		                                                    if ( !m_screenRainDropFXRendererParams )
		                                                      break;
		                                                    v59 = sub_180002100(m_screenRainDropFXRendererParams, (int)v43);
		                                                    *(float *)(v59 + 8) = deltaTime + *(float *)(v59 + 8);
		                                                  }
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_DropRenderParam;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  v60 = (float *)sub_180002100(
		                                                                   m_screenRainDropFXRendererParams,
		                                                                   (int)v43);
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  v61 = *v60;
		                                                  *v60 = (float)((float)(deltaTime
		                                                                       * *(float *)sub_180002100(
		                                                                                     m_screenRainDropFXRendererParams,
		                                                                                     (int)v43))
		                                                               * v44)
		                                                       + v61;
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_DropRenderParam;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  v62 = sub_180002100(m_screenRainDropFXRendererParams, (int)v43);
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_dropUpdateData;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  v63 = *(float *)(v62 + 4);
		                                                  *(float *)(v62 + 4) = (float)((float)(v53
		                                                                                      + *(float *)sub_180002100(
		                                                                                                    m_screenRainDropFXRendererParams,
		                                                                                                    (int)v43))
		                                                                              * deltaTime)
		                                                                      + v63;
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_DropRenderParam;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  v64 = sub_180002100(m_screenRainDropFXRendererParams, (int)v43);
		                                                  *(float *)(v64 + 8) = *(float *)(v64 + 8) - deltaTime;
		                                                  m_screenRainDropFXRendererParams = (char *)this->fields.m_DropRenderParam;
		                                                  m_visibleCount = this->fields.m_visibleCount;
		                                                  if ( !m_screenRainDropFXRendererParams )
		                                                    break;
		                                                  sub_180002990(m_screenRainDropFXRendererParams, &v73, (int)v43, v65);
		                                                  *(_OWORD *)&this->fields.m_dropRenderDatas.m_Buffer[16 * m_visibleCount] = v73;
		                                                  ++this->fields.m_visibleCount;
		                                                  goto LABEL_70;
		                                                }
		                                                m_screenRainDropFXRendererParams = (char *)this->fields.m_dropActive;
		                                                if ( !m_screenRainDropFXRendererParams )
		                                                  break;
		                                                if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
		                                                  goto LABEL_72;
		                                                m_screenRainDropFXRendererParams[v43 + 32] = 0;
		                                              }
		LABEL_70:
		                                              if ( (int)++v43 >= 30 )
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
		LABEL_74:
		    sub_1800D8260(m_screenRainDropFXRendererParams, screenDropFXNoiseTex);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1604, 0LL);
		  if ( !Patch )
		    goto LABEL_74;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1590(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    (Object *)hgCamera,
		    deltaTime,
		    0LL);
		}
		
		internal override void PerFrameClear() {} // 0x000000018339A8E0-0x000000018339A960
		// Void PerFrameClear()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::PerFrameClear(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  void (__fastcall *v5)(MaterialPropertyBlock *, ILFixDynamicMethodWrapper_2__Array *); // rax
		  MaterialPropertyBlock *m_materialPropertyBlock; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 1608 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x648 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[34]._0.interopData )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1608, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->fields.m_materialPropertyBlock )
		  {
		    v5 = (void (__fastcall *)(MaterialPropertyBlock *, ILFixDynamicMethodWrapper_2__Array *))qword_18F36F468;
		    m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		    if ( !qword_18F36F468 )
		    {
		      v5 = (void (__fastcall *)(MaterialPropertyBlock *, ILFixDynamicMethodWrapper_2__Array *))il2cpp_resolve_icall_1(
		                                                                                                 "UnityEngine.MaterialPro"
		                                                                                                 "pertyBlock::Clear(System.Boolean)");
		      if ( !v5 )
		      {
		        v8 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)");
		        sub_18007E1B0(v8, 0LL);
		      }
		      qword_18F36F468 = (__int64)v5;
		    }
		    LOBYTE(wrapperArray) = 1;
		    v5(m_materialPropertyBlock, wrapperArray);
		  }
		}
		
		internal override void SetMaterialData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189CF33B4-0x0000000189CF3654
		// Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::SetMaterialData(
		        HGScreenRainDropFXRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  MaterialPropertyBlock *m_materialPropertyBlock; // rbx
		  void *v8; // rcx
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *m_screenRainDropFXRendererParams; // rax
		  int32_t RainParams; // edx
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v12; // rax
		  int32_t RainColor; // edx
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v14; // r8
		  HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v15; // rax
		  int32_t ScreenDropFXNoiseTex_ST; // edx
		  RainCommonRenderingParam *v17; // rdi
		  MaterialPropertyBlock *v18; // r14
		  int32_t v19; // r12d
		  int cameraMask; // edi
		  int32_t m_visibleCount; // ebx
		  Vector4 *v22; // rax
		  CBHandle *v23; // rax
		  __m128i v24; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CBHandle v26; // [rsp+30h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1609, 0LL) )
		  {
		    if ( this->fields.m_visibleCount <= 0 )
		      return;
		    m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    m_screenRainDropFXRendererParams = this->fields.m_screenRainDropFXRendererParams;
		    if ( m_screenRainDropFXRendererParams )
		    {
		      if ( m_materialPropertyBlock )
		      {
		        RainParams = static_fields->_RainParams;
		        *(Vector4 *)&v26.bufferId = m_screenRainDropFXRendererParams->fields.rainParams;
		        UnityEngine::MaterialPropertyBlock::SetVector(m_materialPropertyBlock, RainParams, (Vector4 *)&v26, 0LL);
		        v8 = this->fields.m_materialPropertyBlock;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        v12 = this->fields.m_screenRainDropFXRendererParams;
		        if ( v12 )
		        {
		          if ( v8 )
		          {
		            RainColor = static_fields->_RainColor;
		            *(Color *)&v26.bufferId = v12->fields.color;
		            UnityEngine::MaterialPropertyBlock::SetColor((MaterialPropertyBlock *)v8, RainColor, (Color *)&v26, 0LL);
		            v14 = this->fields.m_screenRainDropFXRendererParams;
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( v14 )
		            {
		              HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		                this->fields.m_materialPropertyBlock,
		                static_fields->_ScreenDropFXNoiseTex,
		                (Texture *)v14->fields.noiseTexture,
		                0LL);
		              v8 = this->fields.m_materialPropertyBlock;
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              v15 = this->fields.m_screenRainDropFXRendererParams;
		              if ( v15 )
		              {
		                if ( v8 )
		                {
		                  ScreenDropFXNoiseTex_ST = static_fields->_ScreenDropFXNoiseTex_ST;
		                  *(Vector4 *)&v26.bufferId = v15->fields.noiseTextureScaleOffset;
		                  UnityEngine::MaterialPropertyBlock::SetVector(
		                    (MaterialPropertyBlock *)v8,
		                    ScreenDropFXNoiseTex_ST,
		                    (Vector4 *)&v26,
		                    0LL);
		                  v17 = *rainCommonRenderingParam;
		                  v18 = this->fields.m_materialPropertyBlock;
		                  v8 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  v19 = *((_DWORD *)v8 + 818);
		                  if ( v17 )
		                  {
		                    cameraMask = v17->fields.cameraMask;
		                    m_visibleCount = this->fields.m_visibleCount;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                    v22 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                            (Vector4 *)&v26,
		                            (float)cameraMask,
		                            (float)m_visibleCount,
		                            0LL);
		                    if ( v18 )
		                    {
		                      *(Vector4 *)&v26.bufferId = *v22;
		                      UnityEngine::MaterialPropertyBlock::SetVector(v18, v19, (Vector4 *)&v26, 0LL);
		                      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                      v23 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                              &v26,
		                              context,
		                              480,
		                              0LL);
		                      v24 = *(__m128i *)&v23->bufferId;
		                      v26.ptr = v23->ptr;
		                      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		                        (Void *)v26.ptr,
		                        this->fields.m_dropRenderDatas.m_Buffer,
		                        480LL,
		                        0LL);
		                      v8 = this->fields.m_materialPropertyBlock;
		                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                      if ( v8 )
		                      {
		                        UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
		                          (MaterialPropertyBlock *)v8,
		                          static_fields->_ScreenDropRenderDatas,
		                          _mm_cvtsi128_si32(v24),
		                          _mm_cvtsi128_si32(_mm_srli_si128(v24, 4)),
		                          480,
		                          0LL);
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
		LABEL_15:
		    sub_1800D8260(v8, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1609, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    context,
		    0LL);
		}
		
		internal override bool IsDirty() => default; // 0x0000000183E6E040-0x0000000183E6E0A0
		// Boolean IsDirty()
		bool HG::Rendering::Runtime::HGScreenRainDropFXRenderer::IsDirty(HGScreenRainDropFXRenderer *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1610 )
		    return this->fields.m_visibleCount > 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x64A )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[34]._0.fields )
		    return this->fields.m_visibleCount > 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1610, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal override void ClearData() {} // 0x0000000189CF3224-0x0000000189CF3274
		// Void ClearData()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ClearData(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1611, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1611, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(this, 0LL);
		  }
		}
		
		internal override void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CF3274-0x0000000189CF33B4
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::Render(
		        HGScreenRainDropFXRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object_1 *m_screenDropMesh; // rbx
		  Object_1 *m_screenDropMat; // rbx
		  __int64 v9; // rdx
		  CommandBuffer *cmd; // rcx
		  Matrix4x4__StaticFields *static_fields; // r8
		  MaterialPropertyBlock *m_materialPropertyBlock; // rax
		  __int128 v13; // xmm1
		  Material *v14; // r9
		  Mesh *v15; // rdx
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 v19; // [rsp+40h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1612, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1612, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( this->fields._.enabled && this->fields.m_visibleCount > 0 )
		  {
		    m_screenDropMesh = (Object_1 *)this->fields.m_screenDropMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_screenDropMesh, 0LL, 0LL) )
		    {
		      m_screenDropMat = (Object_1 *)this->fields.m_screenDropMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_screenDropMat, 0LL, 0LL) )
		      {
		        if ( ctx )
		        {
		          cmd = ctx->fields.cmd;
		          static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		          m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		          if ( cmd )
		          {
		            v13 = *(_OWORD *)&static_fields->identityMatrix.m01;
		            v14 = this->fields.m_screenDropMat;
		            v15 = this->fields.m_screenDropMesh;
		            *(_OWORD *)&v19.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		            v16 = *(_OWORD *)&static_fields->identityMatrix.m02;
		            *(_OWORD *)&v19.m01 = v13;
		            v17 = *(_OWORD *)&static_fields->identityMatrix.m03;
		            *(_OWORD *)&v19.m02 = v16;
		            *(_OWORD *)&v19.m03 = v17;
		            UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, v15, &v19, v14, 0, 0, m_materialPropertyBlock, 0LL);
		            return;
		          }
		        }
		LABEL_10:
		        sub_1800D8260(cmd, v9);
		      }
		    }
		  }
		}
		
		internal override void Dispose() {} // 0x0000000184861440-0x0000000184861490
		// Void Dispose()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::Dispose(HGScreenRainDropFXRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1613, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1613, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      &this->fields.m_dropRenderDatas,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_screenDropMat,
		      0LL);
		  }
		}
		
		private Vector4 _GetNewDropInfo(Vector2 minMaxLifeTime, Vector2 minMaxSize, Vector2 scatterParam) => default; // 0x0000000189CF3F78-0x0000000189CF40EC
		// Vector4 _GetNewDropInfo(Vector2, Vector2, Vector2)
		Vector4 *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropInfo(
		        Vector4 *__return_ptr retstr,
		        HGScreenRainDropFXRenderer *this,
		        Vector2 minMaxLifeTime,
		        Vector2 minMaxSize,
		        Vector2 scatterParam,
		        MethodInfo *method)
		{
		  float v10; // xmm0_4
		  float v11; // xmm9_4
		  float GaussianDistributeRandom; // xmm8_4
		  float v13; // xmm7_4
		  float v14; // xmm6_4
		  Beyond::DampingMath *v15; // rcx
		  Beyond::DampingMath *v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Vector4 v23; // [rsp+50h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1605, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1605, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_650(
		                 &v23,
		                 Patch,
		                 (Object *)this,
		                 minMaxLifeTime,
		                 minMaxSize,
		                 scatterParam,
		                 0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
		    v11 = (float)(v10 + v10) * 3.1415927;
		    GaussianDistributeRandom = HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetGaussianDistributeRandom(
		                                 this,
		                                 scatterParam.x,
		                                 scatterParam.y,
		                                 0LL);
		    v13 = UnityEngine::Random::Range(minMaxLifeTime.x, minMaxLifeTime.y, 0LL);
		    v14 = UnityEngine::Random::Range(minMaxSize.x, minMaxSize.y, 0LL);
		    Beyond::DampingMath::cosf(v15, minMaxSize.y);
		    retstr->x = v11 * GaussianDistributeRandom;
		    Beyond::DampingMath::sinf(v16, minMaxSize.y);
		    retstr->w = v14;
		    retstr->y = v11 * GaussianDistributeRandom;
		    retstr->z = v13 + 1.0;
		  }
		  return retstr;
		}
		
		private Vector4 _GetNewDropUpdateData(float flowPercent, bool needJitter = false /* Metadata: 0x0230305A */) => default; // 0x0000000189CF40EC-0x0000000189CF41D8
		// Vector4 _GetNewDropUpdateData(Single, Boolean)
		Vector4 *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropUpdateData(
		        Vector4 *__return_ptr retstr,
		        HGScreenRainDropFXRenderer *this,
		        float flowPercent,
		        bool needJitter,
		        MethodInfo *method)
		{
		  float s_jitterTime; // xmm7_4
		  float v9; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Vector4 v14; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1607, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1607, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_651(
		                 &v14,
		                 Patch,
		                 (Object *)this,
		                 flowPercent,
		                 needJitter,
		                 0LL);
		  }
		  else
		  {
		    s_jitterTime = 0.0;
		    v9 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
		    if ( !needJitter )
		      s_jitterTime = this->fields.s_jitterTime;
		    retstr->x = 0.0;
		    retstr->w = 0.0;
		    retstr->z = s_jitterTime;
		    retstr->y = (float)(v9 > (float)(1.0 - flowPercent)) * v9;
		  }
		  return retstr;
		}
		
		private void _ResetDrops() {} // 0x00000001843DE000-0x00000001843DE1C0
		// Void _ResetDrops()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  __m128i si128; // xmm1
		  TileBase *v4; // rdx
		  ITilemap *v5; // r9
		  __m128i *m_dropActive; // rcx
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v8; // r8
		  __int64 v9; // r9
		  __int64 v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1603, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1603, 0LL);
		    if ( !Patch )
		LABEL_13:
		      sub_1800D8260(m_dropActive, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959AB0);
		    v4 = 0LL;
		    v5 = 0LL;
		    do
		    {
		      m_dropActive = (__m128i *)this->fields.m_dropActive;
		      if ( !m_dropActive )
		        goto LABEL_13;
		      if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
		        goto LABEL_14;
		      m_dropActive[2].m128i_i8[(int)v4] = 0;
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 &v12,
		                                 v4,
		                                 (Vector3Int *)this->fields.m_dropUpdateData,
		                                 v5,
		                                 (MethodInfo *)v12.m_AnimatedSprites);
		      if ( !v8 )
		        goto LABEL_13;
		      if ( (unsigned int)v4 >= *(_DWORD *)(v8 + 24) )
		        goto LABEL_14;
		      *(TileAnimationData *)(v8 + 16 * ((int)v4 + 2LL)) = *TileAnimationDataNoRef;
		      m_dropActive = (__m128i *)this->fields.m_DropRenderParam;
		      if ( !m_dropActive )
		        goto LABEL_13;
		      if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
		        goto LABEL_14;
		      m_dropActive[(int)v4 + 2] = si128;
		      m_dropActive = (__m128i *)this->fields.m_DropRenderParam;
		      if ( !m_dropActive )
		        goto LABEL_13;
		      if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
		LABEL_14:
		        sub_1800D2AB0(m_dropActive, v4);
		      v10 = (int)v4;
		      v4 = (TileBase *)(unsigned int)((_DWORD)v4 + 1);
		      *(__m128i *)&this->fields.m_dropRenderDatas.m_Buffer[v9] = m_dropActive[v10 + 2];
		      v5 = (ITilemap *)(v9 + 16);
		    }
		    while ( (int)v4 < 30 );
		    this->fields.m_visibleCount = 0;
		  }
		}
		
		private float _GetGaussianDistributeRandom(float mean, float std) => default; // 0x0000000189CF3E44-0x0000000189CF3F78
		// Single _GetGaussianDistributeRandom(Single, Single)
		float HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetGaussianDistributeRandom(
		        HGScreenRainDropFXRenderer *this,
		        float mean,
		        float std,
		        MethodInfo *method)
		{
		  double v6; // xmm1_8
		  float v7; // xmm0_4
		  Beyond::DampingMath *v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1606, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1606, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_107(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             mean,
		             std,
		             0LL);
		  }
		  else
		  {
		    UnityEngine::Random::Range(0.0, 1.0, 0LL);
		    v6 = 1.0 - UnityEngine::Random::Range(0.0, 1.0, 0LL);
		    v7 = v6;
		    Beyond::DampingMath::sinf(v8, *(float *)&v6);
		    sub_1803367D0();
		    return (float)((float)(v7 * 6.2831855) * sub_1803386C0(v10, v9)) * std + mean;
		  }
		}
		
		public void __iFixBaseProxy_PerFrameClear() {} // 0x0000000189CF3664-0x0000000189CF366C
		// Void <>iFixBaseProxy_PerFrameClear()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_PerFrameClear(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::PerFrameClear((HGBaseSubRainRenderer *)this, 0LL);
		}
		
		public void __iFixBaseProxy_SetMaterialData(ref RainCommonRenderingParam P0, ref ScriptableRenderContext P1) {} // 0x0000000189CDA5F4-0x0000000189CDA5FC
		// Void <>iFixBaseProxy_SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_SetMaterialData(
		        HGFarRainRenderer *this,
		        RainCommonRenderingParam **P0,
		        ScriptableRenderContext *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
		}
		
		public bool __iFixBaseProxy_IsDirty() => default; // 0x0000000189CF365C-0x0000000189CF3664
		// Boolean <>iFixBaseProxy_IsDirty()
		bool HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_IsDirty(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::IsDirty((HGBaseSubRainRenderer *)this, 0LL);
		}
		
		public void __iFixBaseProxy_ClearData() {} // 0x0000000189CF3654-0x0000000189CF365C
		// Void <>iFixBaseProxy_ClearData()
		void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_ClearData(
		        HGScreenRainDropFXRenderer *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::ClearData((HGBaseSubRainRenderer *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Render(HGRenderGraphContext P0, HGCamera P1) {} // 0x0000000189CDA5EC-0x0000000189CDA5F4
		// Void <>iFixBaseProxy_Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Render(
		        HGFarRainRenderer *this,
		        HGRenderGraphContext *P0,
		        HGCamera *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Render((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
		}
		
		public void __iFixBaseProxy_Dispose() {} // 0x0000000189CDA5E4-0x0000000189CDA5EC
		// Void <>iFixBaseProxy_Dispose()
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Dispose(
		        HGFarRainRenderer *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose((HGBaseSubRainRenderer *)this, 0LL);
		}
		
	}
}
