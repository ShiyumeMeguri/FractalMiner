using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Rain;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSceneEffectRainRenderer : HGBaseSubRainRenderer // TypeDefIndex: 37675
	{
		// Fields
		private Mesh m_sceneEffectRainMesh; // 0x20
		private Vector3 m_sceneEffectMeshExtents; // 0x28
		private Shader m_sceneEffectRainShader; // 0x38
		private Material m_sceneEffectRainMat; // 0x40
		private MaterialPropertyBlock m_materialPropertyBlock; // 0x48
		private SceneEffectRainRenderParams m_sceneEffectRainRenderParams; // 0x50
		private float m_rainLayerOffset; // 0x58
		private const int s_maxSceneEffectLayerCount = 4; // Metadata: 0x02303059
		private static readonly float[] s_sceneEffectLayerScale; // 0x00
	
		// Nested types
		internal class SceneEffectRainRenderParams // TypeDefIndex: 37674
		{
			// Fields
			public Vector3 pos; // 0x10
			public Vector3 scale; // 0x1C
			public Vector4 rainParams; // 0x28
			public Vector3 rainDirectionTargetPos; // 0x38
			public float rainDirectionJitterLevel; // 0x44
			public UnityEngine.Color color; // 0x48
			public int sceneEffectRainLayerCount; // 0x58
			public float rainWidthTaauFixFactor; // 0x5C
			public Texture2D rainStreakTexture; // 0x60
			public Vector4 rainStreakTextureScaleOffset; // 0x68
	
			// Constructors
			public SceneEffectRainRenderParams() {} // 0x0000000182EDE4A0-0x0000000182EDE540
			// HGSceneEffectRainRenderer+SceneEffectRainRenderParams()
			void HG::Rendering::Runtime::HGSceneEffectRainRenderer::SceneEffectRainRenderParams::SceneEffectRainRenderParams(
			        HGSceneEffectRainRenderer_SceneEffectRainRenderParams *this,
			        MethodInfo *method)
			{
			  Vector3Int *v2; // r8
			  ITilemap *v3; // r9
			  TileBase *v5; // rdx
			  Vector3Int *v6; // r8
			  ITilemap *v7; // r9
			  Color v8; // xmm1
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
			
			  *(_QWORD *)&this->fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			  this->fields.pos.z = 0.0;
			  *(_QWORD *)&this->fields.scale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			  this->fields.scale.z = 1.0;
			  this->fields.rainParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			                                        &v12,
			                                        (TileBase *)method,
			                                        v2,
			                                        v3,
			                                        (MethodInfo *)v12.m_AnimatedSprites);
			  *(_QWORD *)&this->fields.rainDirectionTargetPos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			  this->fields.rainDirectionTargetPos.z = 0.0;
			  v8 = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			                 &v12,
			                 v5,
			                 v6,
			                 v7,
			                 (MethodInfo *)v12.m_AnimatedSprites);
			  this->fields.sceneEffectRainLayerCount = 1;
			  this->fields.color = v8;
			  this->fields.rainStreakTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)&this->fields.rainStreakTexture,
			    v9,
			    v10,
			    v11,
			    (MethodInfo *)v12.m_AnimatedSprites);
			  this->fields.rainStreakTextureScaleOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
			}
			
		}
	
		// Constructors
		public HGSceneEffectRainRenderer() {} // 0x0000000182EDEBF0-0x0000000182EDECA0
		// HGSceneEffectRainRenderer()
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::HGSceneEffectRainRenderer(
		        HGSceneEffectRainRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  MaterialPropertyBlock *v5; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v9; // rax
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v10; // rdi
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  *(_QWORD *)&this->fields.m_sceneEffectMeshExtents.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_sceneEffectMeshExtents.z = 0.0;
		  v5 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v5
		    || (v5->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
		        this->fields.m_materialPropertyBlock = v5,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_materialPropertyBlock, v6, v7, v8, v14),
		        v9 = (HGSceneEffectRainRenderer_SceneEffectRainRenderParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer::SceneEffectRainRenderParams),
		        (v10 = v9) == 0LL) )
		  {
		    sub_1800D8260(v4, v3);
		  }
		  HG::Rendering::Runtime::HGSceneEffectRainRenderer::SceneEffectRainRenderParams::SceneEffectRainRenderParams(v9, 0LL);
		  this->fields.m_sceneEffectRainRenderParams = v10;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sceneEffectRainRenderParams, v11, v12, v13, v15);
		  if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		  this->fields._.enabled = 1;
		  this->fields._.rainRenderQueue = 3000;
		}
		
		static HGSceneEffectRainRenderer() {} // 0x0000000184D56770-0x0000000184D567D0
		// HGSceneEffectRainRenderer()
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::cctor(MethodInfo *method)
		{
		  Array *v1; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		
		  v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v1,
		    ABD6BC76F99AE56CEBDFE563E9DB9B8EFDDCF2A438EC056D8A6AC26ADC9EA638_Field,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		internal override void PrepareResources(RainCommonResources commonResources) {} // 0x0000000184528160-0x0000000184528320
		// Void PrepareResources(RainCommonResources)
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::PrepareResources(
		        HGSceneEffectRainRenderer *this,
		        RainCommonResources *commonResources,
		        MethodInfo *method)
		{
		  Mesh *v5; // rdx
		  Material *v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  Shader *sceneEffectRainShader; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Shader *m_sceneEffectRainShader; // rdi
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Material *m_sceneEffectRainMat; // rdi
		  Mesh *m_sceneEffectRainMesh; // rdi
		  struct HGBaseSubRainRenderer__Class *v18; // rax
		  Object_1 *v19; // rdi
		  HideFlags__Enum *static_fields; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v22; // [rsp+20h] [rbp-38h]
		  MethodInfo *v23; // [rsp+20h] [rbp-38h]
		  MethodInfo *v24; // [rsp+20h] [rbp-38h]
		  Bounds v25; // [rsp+20h] [rbp-38h]
		  Bounds v26; // [rsp+38h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1597, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1597, 0LL);
		    if ( !Patch )
		      goto LABEL_3;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)commonResources,
		      0LL);
		  }
		  else
		  {
		    if ( !commonResources )
		      goto LABEL_3;
		    this->fields.m_sceneEffectRainMesh = commonResources->fields.sceneEffectRainMesh;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&this->fields.m_sceneEffectRainMesh,
		      (HGRuntimeGrassQuery_Node *)v5,
		      v7,
		      v8,
		      v22);
		    sceneEffectRainShader = commonResources->fields.sceneEffectRainShader;
		    this->fields.m_sceneEffectRainShader = sceneEffectRainShader;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&this->fields.m_sceneEffectRainShader,
		      v10,
		      v11,
		      (Int32__Array **)sceneEffectRainShader,
		      v23);
		    m_sceneEffectRainShader = this->fields.m_sceneEffectRainShader;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_sceneEffectRainMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                          m_sceneEffectRainShader,
		                                          0,
		                                          0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sceneEffectRainMat, v13, v14, v15, v24);
		    m_sceneEffectRainMat = this->fields.m_sceneEffectRainMat;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( m_sceneEffectRainMat )
		    {
		      v6 = (Material *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( m_sceneEffectRainMat->fields._.m_CachedPtr )
		      {
		        v18 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		        v19 = (Object_1 *)this->fields.m_sceneEffectRainMat;
		        if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		          v18 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		        }
		        static_fields = (HideFlags__Enum *)v18->static_fields;
		        if ( !v19 )
		          goto LABEL_3;
		        UnityEngine::Object::set_hideFlags(v19, *static_fields, 0LL);
		        v6 = this->fields.m_sceneEffectRainMat;
		        if ( !v6 )
		          goto LABEL_3;
		        UnityEngine::Material::set_renderQueue(v6, this->fields._.rainRenderQueue, 0LL);
		      }
		    }
		    m_sceneEffectRainMesh = this->fields.m_sceneEffectRainMesh;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( m_sceneEffectRainMesh )
		    {
		      v6 = (Material *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( m_sceneEffectRainMesh->fields._.m_CachedPtr )
		      {
		        v5 = this->fields.m_sceneEffectRainMesh;
		        if ( v5 )
		        {
		          v25 = *UnityEngine::Mesh::get_bounds(&v26, v5, 0LL);
		          this->fields.m_sceneEffectMeshExtents = v25.m_Extents;
		          return;
		        }
		LABEL_3:
		        sub_1800D8260(v6, v5);
		      }
		    }
		  }
		}
		
		internal override void UpdateData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime) {} // 0x0000000189CF2EB0-0x0000000189CF3224
		// Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::UpdateData(
		        HGSceneEffectRainRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        HGCamera *hgCamera,
		        float deltaTime,
		        MethodInfo *method)
		{
		  float v5; // xmm1_4
		  float v6; // xmm2_4
		  __int64 sceneEffectRainTex; // rdx
		  char *camera; // rcx
		  RainCommonPreSettingParam *commonPresettingParam; // rsi
		  float v13; // xmm7_4
		  Beyond::JobMathf *v14; // rcx
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // r15
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __m128 sceneEffectRainRange_low; // xmm0
		  __m128 maxRainHeight_low; // xmm1
		  float v20; // xmm2_4
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v21; // rax
		  __m128i v22; // xmm0
		  RainCommonRenderingParam *v23; // rax
		  float m_rainLayerOffset; // xmm1_4
		  float streakLength; // xmm2_4
		  unsigned int v26; // xmm0_4
		  MethodInfo *v27; // r9
		  float v28; // eax
		  float v29; // xmm2_4
		  Vector3 *v30; // rax
		  __int64 v31; // r9
		  __int64 v32; // xmm0_8
		  __int64 v33; // xmm3_8
		  Vector3 *v34; // rax
		  HGRuntimeGrassQuery_Node *v35; // r8
		  __int64 v36; // r9
		  float z; // ecx
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v38; // rax
		  RainCommonPreSettingParam *v39; // rax
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v40; // r9
		  RainCommonPreSettingParam *v41; // rax
		  __m128i v42; // xmm0
		  int32_t sceneEffectRainLayerCount; // eax
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v44; // rbx
		  int v45; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-60h]
		  Vector3 v48; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v49; // [rsp+40h] [rbp-40h] BYREF
		  __int128 v50; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1598, 0LL) )
		  {
		    if ( *rainCommonRenderingParam )
		    {
		      commonPresettingParam = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		      if ( commonPresettingParam )
		      {
		        v13 = (float)((float)((float)((float)((float)(0.5 / commonPresettingParam->fields.maxRainHeight)
		                                            * (*rainCommonRenderingParam)->fields.speed)
		                                    * 0.050000001)
		                            * commonPresettingParam->fields.sceneEffectRainMaxUVFlowSpeed)
		                    * deltaTime)
		            + this->fields.m_rainLayerOffset;
		        System::MathF::Floor((System::MathF *)camera, v5);
		        Beyond::JobMathf::Fmod(v14, 10.0, v6);
		        m_sceneEffectRainRenderParams = this->fields.m_sceneEffectRainRenderParams;
		        this->fields.m_rainLayerOffset = v13 + (float)(v13 - v13);
		        if ( hgCamera )
		        {
		          camera = (char *)hgCamera->fields.camera;
		          if ( camera )
		          {
		            transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		            if ( transform )
		            {
		              position = UnityEngine::Transform::get_position(&v49, transform, 0LL);
		              camera = (char *)LODWORD(position->z);
		              if ( m_sceneEffectRainRenderParams )
		              {
		                *(_QWORD *)&m_sceneEffectRainRenderParams->fields.pos.x = *(_QWORD *)&position->x;
		                LODWORD(m_sceneEffectRainRenderParams->fields.pos.z) = (_DWORD)camera;
		                camera = (char *)this->fields.m_sceneEffectRainRenderParams;
		                sceneEffectRainRange_low = (__m128)LODWORD(commonPresettingParam->fields.sceneEffectRainRange);
		                maxRainHeight_low = (__m128)LODWORD(commonPresettingParam->fields.maxRainHeight);
		                sceneEffectRainRange_low.m128_f32[0] = sceneEffectRainRange_low.m128_f32[0]
		                                                     / this->fields.m_sceneEffectMeshExtents.x;
		                maxRainHeight_low.m128_f32[0] = maxRainHeight_low.m128_f32[0] / this->fields.m_sceneEffectMeshExtents.y;
		                v20 = commonPresettingParam->fields.sceneEffectRainRange / this->fields.m_sceneEffectMeshExtents.z;
		                if ( camera )
		                {
		                  *(_QWORD *)(camera + 28) = _mm_unpacklo_ps(sceneEffectRainRange_low, maxRainHeight_low).m128_u64[0];
		                  *((float *)camera + 9) = v20;
		                  camera = (char *)*rainCommonRenderingParam;
		                  v21 = this->fields.m_sceneEffectRainRenderParams;
		                  if ( *rainCommonRenderingParam )
		                  {
		                    v22 = _mm_loadu_si128((const __m128i *)camera + 2);
		                    if ( v21 )
		                    {
		                      v21->fields.color = (Color)v22;
		                      v23 = *rainCommonRenderingParam;
		                      camera = (char *)this->fields.m_sceneEffectRainRenderParams;
		                      m_rainLayerOffset = this->fields.m_rainLayerOffset;
		                      if ( *rainCommonRenderingParam )
		                      {
		                        streakLength = v23->fields.streakLength;
		                        DWORD1(v50) = LODWORD(v23->fields.sceneEffectRainWidthScale);
		                        *(float *)&v26 = v23->fields.intensity * 0.0099999998;
		                        *(float *)&v50 = m_rainLayerOffset;
		                        *((_QWORD *)&v50 + 1) = __PAIR64__(v26, LODWORD(streakLength));
		                        if ( camera )
		                        {
		                          *(_OWORD *)(camera + 40) = v50;
		                          v27 = (MethodInfo *)this->fields.m_sceneEffectRainRenderParams;
		                          if ( v27 )
		                          {
		                            camera = (char *)*rainCommonRenderingParam;
		                            if ( *rainCommonRenderingParam )
		                            {
		                              sceneEffectRainTex = *((_QWORD *)camera + 42);
		                              if ( sceneEffectRainTex )
		                              {
		                                v28 = *((float *)camera + 27);
		                                v29 = *(float *)(sceneEffectRainTex + 28);
		                                *(_QWORD *)&v48.x = *(_QWORD *)(camera + 100);
		                                v48.z = v28;
		                                v30 = UnityEngine::Vector3::op_Multiply(&v49, &v48, v29, v27);
		                                v32 = *(_QWORD *)(v31 + 16);
		                                v33 = *(_QWORD *)&v30->x;
		                                v48.z = v30->z;
		                                v49.z = *(float *)(v31 + 24);
		                                *(_QWORD *)&v48.x = v33;
		                                *(_QWORD *)&v49.x = v32;
		                                v34 = UnityEngine::Vector3::op_Subtraction(
		                                        (Vector3 *)&v50,
		                                        &v49,
		                                        &v48,
		                                        (MethodInfo *)v31);
		                                z = v34->z;
		                                *(_QWORD *)(v36 + 56) = *(_QWORD *)&v34->x;
		                                *(float *)(v36 + 64) = z;
		                                camera = (char *)*rainCommonRenderingParam;
		                                v38 = this->fields.m_sceneEffectRainRenderParams;
		                                if ( *rainCommonRenderingParam )
		                                {
		                                  if ( v38 )
		                                  {
		                                    v38->fields.rainDirectionJitterLevel = *((float *)camera + 37);
		                                    camera = (char *)this->fields.m_sceneEffectRainRenderParams;
		                                    if ( *rainCommonRenderingParam )
		                                    {
		                                      v39 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		                                      if ( v39 )
		                                      {
		                                        sceneEffectRainTex = (__int64)v39->fields.sceneEffectRainTex;
		                                        if ( camera )
		                                        {
		                                          *((_QWORD *)camera + 12) = sceneEffectRainTex;
		                                          sub_18002D1B0(
		                                            (HGRuntimeGrassQuery_Node *)(camera + 96),
		                                            (HGRuntimeGrassQuery_Node *)sceneEffectRainTex,
		                                            v35,
		                                            (Int32__Array **)v36,
		                                            P3);
		                                          v40 = this->fields.m_sceneEffectRainRenderParams;
		                                          if ( *rainCommonRenderingParam )
		                                          {
		                                            v41 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		                                            if ( v41 )
		                                            {
		                                              v42 = _mm_loadu_si128((const __m128i *)&v41->fields.sceneEffectRainTex_ST);
		                                              if ( v40 )
		                                              {
		                                                v40->fields.rainStreakTextureScaleOffset = (Vector4)v42;
		                                                camera = (char *)this->fields.m_sceneEffectRainRenderParams;
		                                                if ( *rainCommonRenderingParam )
		                                                {
		                                                  sceneEffectRainLayerCount = (*rainCommonRenderingParam)->fields.sceneEffectRainLayerCount;
		                                                  sceneEffectRainTex = 4LL;
		                                                  if ( sceneEffectRainLayerCount > 4 )
		                                                    sceneEffectRainLayerCount = 4;
		                                                  if ( camera )
		                                                  {
		                                                    *((_DWORD *)camera + 22) = sceneEffectRainLayerCount;
		                                                    v44 = this->fields.m_sceneEffectRainRenderParams;
		                                                    v45 = HG::Rendering::Runtime::HGCamera::get_enableTAAU(
		                                                            hgCamera,
		                                                            0LL)
		                                                        ? 0x40000000
		                                                        : 0;
		                                                    if ( v44 )
		                                                    {
		                                                      LODWORD(v44->fields.rainWidthTaauFixFactor) = v45;
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
		        }
		      }
		    }
		LABEL_34:
		    sub_1800D8260(camera, sceneEffectRainTex);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1598, 0LL);
		  if ( !Patch )
		    goto LABEL_34;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1590(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    (Object *)hgCamera,
		    deltaTime,
		    0LL);
		}
		
		internal override void SetMaterialData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189CF2B50-0x0000000189CF2EB0
		// Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::SetMaterialData(
		        HGSceneEffectRainRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  unsigned __int64 cameraMask; // rdx
		  float *p_CB0; // rcx
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // rax
		  float x; // xmm8_4
		  float y; // xmm9_4
		  float z; // xmm7_4
		  float rainDirectionJitterLevel; // xmm6_4
		  __m128i v14; // xmm7
		  RainCommonRenderingParam *v15; // rax
		  __m128i v16; // xmm6
		  Material *m_sceneEffectRainMat; // rdi
		  Material *v18; // rdi
		  MaterialPropertyBlock *m_materialPropertyBlock; // rdi
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v20; // r8
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v21; // rax
		  int32_t v22; // edx
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v23; // rax
		  int32_t v24; // edx
		  int32_t v25; // edx
		  MethodInfo *v26; // r8
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v27; // rax
		  Color *v28; // rax
		  int32_t v29; // r10d
		  MaterialPropertyBlock *v30; // rcx
		  int32_t v31; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i rainStreakTextureScaleOffset; // [rsp+38h] [rbp-9h] BYREF
		  Color v34; // [rsp+48h] [rbp+7h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1599, 0LL) )
		  {
		    m_sceneEffectRainRenderParams = this->fields.m_sceneEffectRainRenderParams;
		    if ( m_sceneEffectRainRenderParams )
		    {
		      x = m_sceneEffectRainRenderParams->fields.rainDirectionTargetPos.x;
		      y = m_sceneEffectRainRenderParams->fields.rainDirectionTargetPos.y;
		      z = m_sceneEffectRainRenderParams->fields.rainDirectionTargetPos.z;
		      rainDirectionJitterLevel = m_sceneEffectRainRenderParams->fields.rainDirectionJitterLevel;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v14 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               (Vector4 *)&rainStreakTextureScaleOffset,
		                                               x,
		                                               y,
		                                               z,
		                                               rainDirectionJitterLevel,
		                                               0LL));
		      v15 = *rainCommonRenderingParam;
		      if ( *rainCommonRenderingParam )
		      {
		        p_CB0 = (float *)this->fields.m_sceneEffectRainRenderParams;
		        cameraMask = (unsigned int)v15->fields.cameraMask;
		        if ( p_CB0 )
		        {
		          v16 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                   (Vector4 *)&rainStreakTextureScaleOffset,
		                                                   (float)(int)cameraMask,
		                                                   v15->fields.sceneEffectRainLightingPercent,
		                                                   p_CB0[23],
		                                                   0LL));
		          if ( *rainCommonRenderingParam )
		          {
		            if ( (*rainCommonRenderingParam)->fields.enableRainLighting
		              && (*rainCommonRenderingParam)->fields.sceneEffectRainLightingPercent > TypeInfo::UnityEngine::Mathf->static_fields->Epsilon )
		            {
		              m_sceneEffectRainMat = this->fields.m_sceneEffectRainMat;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		              cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		              if ( !m_sceneEffectRainMat )
		                goto LABEL_23;
		              UnityEngine::Material::EnableKeyword(m_sceneEffectRainMat, *(String **)(cameraMask + 8), 0LL);
		            }
		            else
		            {
		              v18 = this->fields.m_sceneEffectRainMat;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		              cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		              if ( !v18 )
		                goto LABEL_23;
		              UnityEngine::Material::DisableKeyword(v18, *(String **)(cameraMask + 8), 0LL);
		            }
		            m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            v20 = this->fields.m_sceneEffectRainRenderParams;
		            cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( v20 )
		            {
		              HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		                m_materialPropertyBlock,
		                *(_DWORD *)(cameraMask + 3268),
		                (Texture *)v20->fields.rainStreakTexture,
		                0LL);
		              p_CB0 = (float *)this->fields.m_materialPropertyBlock;
		              cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              v21 = this->fields.m_sceneEffectRainRenderParams;
		              if ( v21 )
		              {
		                if ( p_CB0 )
		                {
		                  v22 = *(_DWORD *)(cameraMask + 3272);
		                  rainStreakTextureScaleOffset = (__m128i)v21->fields.rainStreakTextureScaleOffset;
		                  UnityEngine::MaterialPropertyBlock::SetVector(
		                    (MaterialPropertyBlock *)p_CB0,
		                    v22,
		                    (Vector4 *)&rainStreakTextureScaleOffset,
		                    0LL);
		                  p_CB0 = (float *)this->fields.m_materialPropertyBlock;
		                  cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  v23 = this->fields.m_sceneEffectRainRenderParams;
		                  if ( v23 )
		                  {
		                    if ( p_CB0 )
		                    {
		                      v24 = *(_DWORD *)(cameraMask + 3284);
		                      rainStreakTextureScaleOffset = (__m128i)v23->fields.rainParams;
		                      UnityEngine::MaterialPropertyBlock::SetVector(
		                        (MaterialPropertyBlock *)p_CB0,
		                        v24,
		                        (Vector4 *)&rainStreakTextureScaleOffset,
		                        0LL);
		                      p_CB0 = (float *)this->fields.m_materialPropertyBlock;
		                      cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                      if ( p_CB0 )
		                      {
		                        v25 = *(_DWORD *)(cameraMask + 3296);
		                        rainStreakTextureScaleOffset = v14;
		                        UnityEngine::MaterialPropertyBlock::SetVector(
		                          (MaterialPropertyBlock *)p_CB0,
		                          v25,
		                          (Vector4 *)&rainStreakTextureScaleOffset,
		                          0LL);
		                        p_CB0 = (float *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		                        v27 = this->fields.m_sceneEffectRainRenderParams;
		                        if ( v27 )
		                        {
		                          rainStreakTextureScaleOffset = (__m128i)v27->fields.color;
		                          v28 = UnityEngine::Color::op_Implicit(&v34, (Vector4 *)&rainStreakTextureScaleOffset, v26);
		                          if ( this->fields.m_materialPropertyBlock )
		                          {
		                            v30 = this->fields.m_materialPropertyBlock;
		                            rainStreakTextureScaleOffset = *(__m128i *)v28;
		                            UnityEngine::MaterialPropertyBlock::SetVector(
		                              v30,
		                              v29,
		                              (Vector4 *)&rainStreakTextureScaleOffset,
		                              0LL);
		                            p_CB0 = (float *)this->fields.m_materialPropertyBlock;
		                            cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                            if ( p_CB0 )
		                            {
		                              v31 = *(_DWORD *)(cameraMask + 3288);
		                              rainStreakTextureScaleOffset = v16;
		                              UnityEngine::MaterialPropertyBlock::SetVector(
		                                (MaterialPropertyBlock *)p_CB0,
		                                v31,
		                                (Vector4 *)&rainStreakTextureScaleOffset,
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
		        }
		      }
		    }
		LABEL_23:
		    sub_1800D8260(p_CB0, cameraMask);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1599, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    context,
		    0LL);
		}
		
		internal override void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CF2900-0x0000000189CF2B50
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::Render(
		        HGSceneEffectRainRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object_1 *m_sceneEffectRainMesh; // rbx
		  Object_1 *m_sceneEffectRainMat; // rbx
		  struct HGSceneEffectRainRenderer__Class *v9; // rdx
		  CommandBuffer *s_sceneEffectLayerScale; // rcx
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // rax
		  int sceneEffectRainLayerCount; // r14d
		  unsigned int v13; // ebx
		  __int64 v14; // xmm6_8
		  float z; // r15d
		  HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v16; // rax
		  Quaternion *identity; // rax
		  Matrix4x4 *v18; // rax
		  __int128 v19; // xmm1
		  Material *v20; // r9
		  Mesh *v21; // rdx
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MaterialPropertyBlock *m_materialPropertyBlock; // [rsp+38h] [rbp-D0h]
		  __int64 v26; // [rsp+48h] [rbp-C0h]
		  float v27; // [rsp+50h] [rbp-B8h]
		  Vector3 v28; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v29; // [rsp+68h] [rbp-A0h] BYREF
		  Quaternion v30; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v31; // [rsp+88h] [rbp-80h] BYREF
		  Quaternion v32; // [rsp+C8h] [rbp-40h] BYREF
		  Matrix4x4 v33; // [rsp+D8h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1600, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1600, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( this->fields._.enabled )
		  {
		    m_sceneEffectRainMesh = (Object_1 *)this->fields.m_sceneEffectRainMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_sceneEffectRainMesh, 0LL, 0LL) )
		    {
		      m_sceneEffectRainMat = (Object_1 *)this->fields.m_sceneEffectRainMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_sceneEffectRainMat, 0LL, 0LL) )
		      {
		        m_sceneEffectRainRenderParams = this->fields.m_sceneEffectRainRenderParams;
		        if ( !m_sceneEffectRainRenderParams )
		          goto LABEL_18;
		        sceneEffectRainLayerCount = m_sceneEffectRainRenderParams->fields.sceneEffectRainLayerCount;
		        v13 = 0;
		        v14 = *(_QWORD *)&m_sceneEffectRainRenderParams->fields.pos.x;
		        z = m_sceneEffectRainRenderParams->fields.pos.z;
		        if ( sceneEffectRainLayerCount > 0 )
		        {
		          while ( 1 )
		          {
		            v16 = this->fields.m_sceneEffectRainRenderParams;
		            if ( !v16 )
		              break;
		            v26 = *(_QWORD *)&v16->fields.scale.x;
		            v27 = v16->fields.scale.z;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
		            v9 = TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer;
		            s_sceneEffectLayerScale = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer->static_fields->s_sceneEffectLayerScale;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            if ( v13 >= LODWORD(s_sceneEffectLayerScale[1].klass) )
		              goto LABEL_16;
		            *(float *)&v26 = *(float *)&v26 * *((float *)&s_sceneEffectLayerScale[1].monitor + (int)v13);
		            s_sceneEffectLayerScale = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer->static_fields->s_sceneEffectLayerScale;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            if ( v13 >= LODWORD(s_sceneEffectLayerScale[1].klass) )
		LABEL_16:
		              sub_1800D2AB0(s_sceneEffectLayerScale, TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
		            *(_QWORD *)&v28.x = v26;
		            v28.z = v27 * *((float *)&s_sceneEffectLayerScale[1].monitor + (int)v13);
		            identity = UnityEngine::Quaternion::get_identity(
		                         &v32,
		                         (MethodInfo *)TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
		            *(_QWORD *)&v29.x = v14;
		            v29.z = z;
		            v30 = *identity;
		            v18 = UnityEngine::Matrix4x4::TRS(&v33, &v29, &v30, &v28, 0LL);
		            if ( !ctx )
		              break;
		            s_sceneEffectLayerScale = ctx->fields.cmd;
		            if ( !s_sceneEffectLayerScale )
		              break;
		            v19 = *(_OWORD *)&v18->m01;
		            v20 = this->fields.m_sceneEffectRainMat;
		            v21 = this->fields.m_sceneEffectRainMesh;
		            *(_OWORD *)&v31.m00 = *(_OWORD *)&v18->m00;
		            v22 = *(_OWORD *)&v18->m02;
		            *(_OWORD *)&v31.m01 = v19;
		            v23 = *(_OWORD *)&v18->m03;
		            m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		            *(_OWORD *)&v31.m02 = v22;
		            *(_OWORD *)&v31.m03 = v23;
		            UnityEngine::Rendering::CommandBuffer::DrawMesh(
		              s_sceneEffectLayerScale,
		              v21,
		              &v31,
		              v20,
		              0,
		              0,
		              m_materialPropertyBlock,
		              0LL);
		            if ( (int)++v13 >= sceneEffectRainLayerCount )
		              return;
		          }
		LABEL_18:
		          sub_1800D8260(s_sceneEffectLayerScale, v9);
		        }
		      }
		    }
		  }
		}
		
		internal override void Dispose() {} // 0x0000000184861400-0x0000000184861440
		// Void Dispose()
		void HG::Rendering::Runtime::HGSceneEffectRainRenderer::Dispose(HGSceneEffectRainRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1601, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1601, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_sceneEffectRainMat,
		      0LL);
		  }
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
