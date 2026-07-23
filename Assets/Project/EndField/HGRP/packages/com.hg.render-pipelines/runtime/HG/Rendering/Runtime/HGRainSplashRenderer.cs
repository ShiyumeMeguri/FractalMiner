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
	public class HGRainSplashRenderer : HGBaseSubRainRenderer // TypeDefIndex: 37673
	{
		// Fields
		private Mesh m_rainSplashMesh; // 0x20
		private Shader m_rainSplashShader; // 0x28
		private Material m_rainSplashMat; // 0x30
		private MaterialPropertyBlock m_materialPropertyBlock; // 0x38
		private RainSplashRenderParams m_rainSplashRenderParams; // 0x40
		private float m_rainSplashTimeOffset; // 0x48
	
		// Nested types
		internal class RainSplashRenderParams // TypeDefIndex: 37672
		{
			// Fields
			public UnityEngine.Color color; // 0x10
			public Vector4 rainParams; // 0x20
			public Texture2D rainSplashTexture; // 0x30
			public Vector4 rainSplashTextureScaleOffset; // 0x38
			public Vector4 rainSplashExtraData; // 0x48
	
			// Constructors
			public RainSplashRenderParams() {} // 0x0000000182EDE540-0x0000000182EDE5A0
			// HGRainSplashRenderer+RainSplashRenderParams()
			void HG::Rendering::Runtime::HGRainSplashRenderer::RainSplashRenderParams::RainSplashRenderParams(
			        HGRainSplashRenderer_RainSplashRenderParams *this,
			        MethodInfo *method)
			{
			  Vector3Int *v2; // r8
			  ITilemap *v3; // r9
			  TileBase *v5; // rdx
			  Vector3Int *v6; // r8
			  ITilemap *v7; // r9
			  Type *v8; // rdx
			  PropertyInfo_1 *v9; // r8
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
			  this->fields.rainSplashTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->fields.rainSplashTexture,
			    v8,
			    v9,
			    v10,
			    (MethodInfo *)v11.m_AnimatedSprites);
			  this->fields.rainSplashTextureScaleOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
			  this->fields.rainSplashExtraData = 0LL;
			}
			
		}
	
		// Constructors
		public HGRainSplashRenderer() {} // 0x0000000182EDE950-0x0000000182EDE9F0
		// HGRainSplashRenderer()
		void HG::Rendering::Runtime::HGRainSplashRenderer::HGRainSplashRenderer(HGRainSplashRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  MaterialPropertyBlock *v5; // rdi
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  HGRainSplashRenderer_RainSplashRenderParams *v9; // rax
		  HGRainSplashRenderer_RainSplashRenderParams *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  v5 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v5
		    || (v5->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
		        this->fields.m_materialPropertyBlock = v5,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_materialPropertyBlock, v6, v7, v8, v14),
		        v9 = (HGRainSplashRenderer_RainSplashRenderParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainSplashRenderer::RainSplashRenderParams),
		        (v10 = v9) == 0LL) )
		  {
		    sub_1800D8260(v4, v3);
		  }
		  HG::Rendering::Runtime::HGRainSplashRenderer::RainSplashRenderParams::RainSplashRenderParams(v9, 0LL);
		  this->fields.m_rainSplashRenderParams = v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainSplashRenderParams, v11, v12, v13, v15);
		  if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		  this->fields._.enabled = 1;
		  this->fields._.rainRenderQueue = 3000;
		}
		
	
		// Methods
		internal override void PrepareResources(RainCommonResources commonResources) {} // 0x00000001849BAE50-0x00000001849BAF90
		// Void PrepareResources(RainCommonResources)
		void HG::Rendering::Runtime::HGRainSplashRenderer::PrepareResources(
		        HGRainSplashRenderer *this,
		        RainCommonResources *commonResources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  Material *v6; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Shader *rainSplashShader; // r9
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Shader *m_rainSplashShader; // rdi
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  Material *m_rainSplashMat; // rdi
		  struct HGBaseSubRainRenderer__Class *v17; // rax
		  Object_1 *v18; // rdi
		  HideFlags__Enum *static_fields; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1589, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1589, 0LL);
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
		    this->fields.m_rainSplashMesh = commonResources->fields.rainSplashMesh;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainSplashMesh, v5, v7, v8, v21);
		    rainSplashShader = commonResources->fields.rainSplashShader;
		    this->fields.m_rainSplashShader = rainSplashShader;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.m_rainSplashShader,
		      v10,
		      v11,
		      (Int32__Array **)rainSplashShader,
		      v22);
		    m_rainSplashShader = this->fields.m_rainSplashShader;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_rainSplashMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                     m_rainSplashShader,
		                                     0,
		                                     0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainSplashMat, v13, v14, v15, v23);
		    v6 = (Material *)TypeInfo::UnityEngine::Object;
		    m_rainSplashMat = this->fields.m_rainSplashMat;
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
		    if ( m_rainSplashMat )
		    {
		      if ( !LODWORD(v6[9].monitor) )
		        il2cpp_runtime_class_init_1(v6);
		      if ( m_rainSplashMat->fields._.m_CachedPtr )
		      {
		        v17 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		        v18 = (Object_1 *)this->fields.m_rainSplashMat;
		        if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
		          v17 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
		        }
		        static_fields = (HideFlags__Enum *)v17->static_fields;
		        if ( v18 )
		        {
		          UnityEngine::Object::set_hideFlags(v18, *static_fields, 0LL);
		          v6 = this->fields.m_rainSplashMat;
		          if ( v6 )
		          {
		            UnityEngine::Material::set_renderQueue(v6, this->fields._.rainRenderQueue, 0LL);
		            return;
		          }
		        }
		LABEL_3:
		        sub_1800D8260(v6, v5);
		      }
		    }
		  }
		}
		
		internal override void UpdateData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime) {} // 0x0000000189CF2668-0x0000000189CF2900
		// Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
		void HG::Rendering::Runtime::HGRainSplashRenderer::UpdateData(
		        HGRainSplashRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        HGCamera *hgCamera,
		        float deltaTime,
		        MethodInfo *method)
		{
		  Type *rainSplashTexture; // rdx
		  char *commonPresettingParam; // rcx
		  HGRainSplashRenderer_RainSplashRenderParams *m_rainSplashRenderParams; // rax
		  __m128i v11; // xmm0
		  RainCommonRenderingParam *v12; // rax
		  HGRainSplashRenderer_RainSplashRenderParams *v13; // rsi
		  float v14; // xmm9_4
		  float m_rainSplashTimeOffset; // xmm8_4
		  __m128 x_low; // xmm6
		  __m128 y_low; // xmm7
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __m128i v20; // xmm0
		  RainCommonPreSettingParam *v21; // rax
		  RainCommonPreSettingParam *v22; // rax
		  HGRainSplashRenderer_RainSplashRenderParams *v23; // rsi
		  __m128i v24; // xmm0
		  HGRainSplashRenderer_RainSplashRenderParams *v25; // rdi
		  __m128i v26; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-68h]
		  Vector4 v29[3]; // [rsp+30h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1590, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(this, 0LL) )
		      return;
		    if ( *rainCommonRenderingParam )
		    {
		      m_rainSplashRenderParams = this->fields.m_rainSplashRenderParams;
		      this->fields.m_rainSplashTimeOffset = (float)(deltaTime * (*rainCommonRenderingParam)->fields.rainSplashSpeed)
		                                          + this->fields.m_rainSplashTimeOffset;
		      commonPresettingParam = (char *)*rainCommonRenderingParam;
		      if ( *rainCommonRenderingParam )
		      {
		        v11 = _mm_loadu_si128((const __m128i *)commonPresettingParam + 2);
		        if ( m_rainSplashRenderParams )
		        {
		          m_rainSplashRenderParams->fields.color = (Color)v11;
		          commonPresettingParam = (char *)this->fields.m_rainSplashRenderParams;
		          if ( commonPresettingParam )
		          {
		            if ( *rainCommonRenderingParam )
		            {
		              *((_DWORD *)commonPresettingParam + 7) = LODWORD((*rainCommonRenderingParam)->fields.rainSplashAlpha);
		              v12 = *rainCommonRenderingParam;
		              v13 = this->fields.m_rainSplashRenderParams;
		              if ( *rainCommonRenderingParam )
		              {
		                commonPresettingParam = (char *)v12->fields.commonPresettingParam;
		                if ( commonPresettingParam )
		                {
		                  v14 = *((float *)commonPresettingParam + 69);
		                  m_rainSplashTimeOffset = this->fields.m_rainSplashTimeOffset;
		                  x_low = (__m128)LODWORD(v12->fields.rainSplashMinMaxSize.x);
		                  y_low = (__m128)LODWORD(v12->fields.rainSplashMinMaxSize.y);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                  v20 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                           v29,
		                                                           v14,
		                                                           m_rainSplashTimeOffset,
		                                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                                           0LL));
		                  if ( v13 )
		                  {
		                    v13->fields.rainParams = (Vector4)v20;
		                    commonPresettingParam = (char *)this->fields.m_rainSplashRenderParams;
		                    if ( *rainCommonRenderingParam )
		                    {
		                      v21 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		                      if ( v21 )
		                      {
		                        rainSplashTexture = (Type *)v21->fields.rainSplashTexture;
		                        if ( commonPresettingParam )
		                        {
		                          *((_QWORD *)commonPresettingParam + 6) = rainSplashTexture;
		                          sub_18002D1B0(
		                            (SingleFieldAccessor *)(commonPresettingParam + 48),
		                            rainSplashTexture,
		                            v18,
		                            v19,
		                            P3);
		                          if ( *rainCommonRenderingParam )
		                          {
		                            v22 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		                            if ( v22 )
		                            {
		                              v23 = this->fields.m_rainSplashRenderParams;
		                              v24 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                       v29,
		                                                                       (float)v22->fields.rainSplashTextureRowColumnCount,
		                                                                       1.0
		                                                                     / (float)v22->fields.rainSplashTextureRowColumnCount,
		                                                                       1.0
		                                                                     / (float)((float)v22->fields.rainSplashTextureRowColumnCount
		                                                                             * (float)v22->fields.rainSplashTextureRowColumnCount),
		                                                                       v22->fields.rainSplashYBias,
		                                                                       0LL));
		                              if ( v23 )
		                              {
		                                v23->fields.rainSplashTextureScaleOffset = (Vector4)v24;
		                                v25 = this->fields.m_rainSplashRenderParams;
		                                if ( *rainCommonRenderingParam )
		                                {
		                                  v26 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                           v29,
		                                                                           (float)(*rainCommonRenderingParam)->fields.rainSplashCount
		                                                                         * 0.0009765625,
		                                                                           (float)(*rainCommonRenderingParam)->fields.cameraMask,
		                                                                           (*rainCommonRenderingParam)->fields.rainSplashLightingPercent,
		                                                                           0LL));
		                                  if ( v25 )
		                                  {
		                                    v25->fields.rainSplashExtraData = (Vector4)v26;
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
		LABEL_21:
		    sub_1800D8260(commonPresettingParam, rainSplashTexture);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1590, 0LL);
		  if ( !Patch )
		    goto LABEL_21;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1590(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    (Object *)hgCamera,
		    deltaTime,
		    0LL);
		}
		
		internal override void SetMaterialData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189CF23AC-0x0000000189CF261C
		// Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGRainSplashRenderer::SetMaterialData(
		        HGRainSplashRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  void *static_fields; // rdx
		  MaterialPropertyBlock *v8; // rcx
		  Material *m_rainSplashMat; // rdi
		  Material *v10; // rdi
		  MaterialPropertyBlock *m_materialPropertyBlock; // rdi
		  MethodInfo *v12; // r8
		  HGRainSplashRenderer_RainSplashRenderParams *m_rainSplashRenderParams; // rax
		  Color *v14; // rax
		  int32_t v15; // r10d
		  HGRainSplashRenderer_RainSplashRenderParams *v16; // rax
		  int32_t v17; // edx
		  HGRainSplashRenderer_RainSplashRenderParams *v18; // r8
		  HGRainSplashRenderer_RainSplashRenderParams *v19; // rax
		  int32_t v20; // edx
		  HGRainSplashRenderer_RainSplashRenderParams *v21; // rax
		  int32_t v22; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 color; // [rsp+30h] [rbp-28h] BYREF
		  Color v25; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1592, 0LL) )
		  {
		    if ( !*rainCommonRenderingParam )
		      goto LABEL_20;
		    if ( (*rainCommonRenderingParam)->fields.enableRainLighting
		      && (*rainCommonRenderingParam)->fields.rainSplashLightingPercent > TypeInfo::UnityEngine::Mathf->static_fields->Epsilon )
		    {
		      m_rainSplashMat = this->fields.m_rainSplashMat;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		      if ( !m_rainSplashMat )
		        goto LABEL_20;
		      UnityEngine::Material::EnableKeyword(m_rainSplashMat, *((String **)static_fields + 1), 0LL);
		    }
		    else
		    {
		      v10 = this->fields.m_rainSplashMat;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		      if ( !v10 )
		        goto LABEL_20;
		      UnityEngine::Material::DisableKeyword(v10, *((String **)static_fields + 1), 0LL);
		    }
		    m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v8 = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    m_rainSplashRenderParams = this->fields.m_rainSplashRenderParams;
		    if ( m_rainSplashRenderParams )
		    {
		      color = (Vector4)m_rainSplashRenderParams->fields.color;
		      v14 = UnityEngine::Color::op_Implicit(&v25, &color, v12);
		      if ( m_materialPropertyBlock )
		      {
		        color = (Vector4)*v14;
		        UnityEngine::MaterialPropertyBlock::SetVector(m_materialPropertyBlock, v15, &color, 0LL);
		        v8 = this->fields.m_materialPropertyBlock;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        v16 = this->fields.m_rainSplashRenderParams;
		        if ( v16 )
		        {
		          if ( v8 )
		          {
		            v17 = *((_DWORD *)static_fields + 821);
		            color = v16->fields.rainParams;
		            UnityEngine::MaterialPropertyBlock::SetVector(v8, v17, &color, 0LL);
		            v18 = this->fields.m_rainSplashRenderParams;
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( v18 )
		            {
		              HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		                this->fields.m_materialPropertyBlock,
		                *((_DWORD *)static_fields + 817),
		                (Texture *)v18->fields.rainSplashTexture,
		                0LL);
		              v8 = this->fields.m_materialPropertyBlock;
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              v19 = this->fields.m_rainSplashRenderParams;
		              if ( v19 )
		              {
		                if ( v8 )
		                {
		                  v20 = *((_DWORD *)static_fields + 818);
		                  color = v19->fields.rainSplashTextureScaleOffset;
		                  UnityEngine::MaterialPropertyBlock::SetVector(v8, v20, &color, 0LL);
		                  v8 = this->fields.m_materialPropertyBlock;
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  v21 = this->fields.m_rainSplashRenderParams;
		                  if ( v21 )
		                  {
		                    if ( v8 )
		                    {
		                      v22 = *((_DWORD *)static_fields + 820);
		                      color = v21->fields.rainSplashExtraData;
		                      UnityEngine::MaterialPropertyBlock::SetVector(v8, v22, &color, 0LL);
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
		LABEL_20:
		    sub_1800D8260(v8, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1592, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    context,
		    0LL);
		}
		
		internal override void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CF21B8-0x0000000189CF23AC
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::HGRainSplashRenderer::Render(
		        HGRainSplashRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object_1 *m_rainSplashMesh; // rbx
		  Object_1 *m_rainSplashMat; // rbx
		  Object_1 *camera; // rbx
		  MaterialPropertyBlock *m_materialPropertyBlock; // rdx
		  Component *cmd; // rcx
		  Transform *transform; // rax
		  MethodInfo *position; // rax
		  Vector3 *one; // rax
		  __int64 v15; // xmm1_8
		  MethodInfo *v16; // rdx
		  Quaternion *identity; // rax
		  __int64 v18; // rdx
		  Quaternion v19; // xmm1
		  Matrix4x4 *v20; // rax
		  Material *v21; // r9
		  __int128 v22; // xmm1
		  Mesh *v23; // rdx
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MaterialPropertyBlock *v27; // [rsp+38h] [rbp-79h]
		  Vector3 v28; // [rsp+48h] [rbp-69h] BYREF
		  Vector3 v29; // [rsp+58h] [rbp-59h] BYREF
		  Quaternion v30; // [rsp+68h] [rbp-49h] BYREF
		  Vector3 v31; // [rsp+78h] [rbp-39h] BYREF
		  Matrix4x4 v32; // [rsp+88h] [rbp-29h] BYREF
		  Matrix4x4 v33; // [rsp+C8h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1593, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1593, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( this->fields._.enabled && HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(this, 0LL) )
		  {
		    m_rainSplashMesh = (Object_1 *)this->fields.m_rainSplashMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_rainSplashMesh, 0LL, 0LL) )
		    {
		      m_rainSplashMat = (Object_1 *)this->fields.m_rainSplashMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_rainSplashMat, 0LL, 0LL) )
		      {
		        if ( hgCamera )
		        {
		          camera = (Object_1 *)hgCamera->fields.camera;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Equality(camera, 0LL, 0LL) )
		          {
		            cmd = (Component *)hgCamera->fields.camera;
		            if ( cmd )
		            {
		              transform = UnityEngine::Component::get_transform(cmd, 0LL);
		              if ( transform )
		              {
		                position = (MethodInfo *)UnityEngine::Transform::get_position(&v31, transform, 0LL);
		                one = UnityEngine::Vector3::get_one(&v28, position);
		                v15 = *(_QWORD *)&one->x;
		                v29.z = one->z;
		                *(_QWORD *)&v29.x = v15;
		                identity = UnityEngine::Quaternion::get_identity(&v30, v16);
		                *(_QWORD *)&v28.x = *(_QWORD *)v18;
		                v19 = *identity;
		                v28.z = *(float *)(v18 + 8);
		                v30 = v19;
		                v20 = UnityEngine::Matrix4x4::TRS(&v33, &v28, &v30, &v29, 0LL);
		                if ( ctx )
		                {
		                  cmd = (Component *)ctx->fields.cmd;
		                  m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		                  if ( cmd )
		                  {
		                    v21 = this->fields.m_rainSplashMat;
		                    v22 = *(_OWORD *)&v20->m01;
		                    v27 = this->fields.m_materialPropertyBlock;
		                    v23 = this->fields.m_rainSplashMesh;
		                    *(_OWORD *)&v32.m00 = *(_OWORD *)&v20->m00;
		                    v24 = *(_OWORD *)&v20->m02;
		                    *(_OWORD *)&v32.m01 = v22;
		                    v25 = *(_OWORD *)&v20->m03;
		                    *(_OWORD *)&v32.m02 = v24;
		                    *(_OWORD *)&v32.m03 = v25;
		                    UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                      (CommandBuffer *)cmd,
		                      v23,
		                      &v32,
		                      v21,
		                      0,
		                      0,
		                      v27,
		                      0LL);
		                    return;
		                  }
		                }
		              }
		            }
		LABEL_14:
		            sub_1800D8260(cmd, m_materialPropertyBlock);
		          }
		        }
		      }
		    }
		  }
		}
		
		internal override void Dispose() {} // 0x00000001848613C0-0x0000000184861400
		// Void Dispose()
		void HG::Rendering::Runtime::HGRainSplashRenderer::Dispose(HGRainSplashRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1594, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1594, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_rainSplashMat,
		      0LL);
		  }
		}
		
		internal bool CheckRuntimeResources() => default; // 0x0000000189CF2128-0x0000000189CF21B8
		// Boolean CheckRuntimeResources()
		bool HG::Rendering::Runtime::HGRainSplashRenderer::CheckRuntimeResources(
		        HGRainSplashRenderer *this,
		        MethodInfo *method)
		{
		  Object_1 *m_rainSplashMesh; // rbx
		  bool result; // al
		  Object_1 *m_rainSplashMat; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1596, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1596, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_rainSplashMesh = (Object_1 *)this->fields.m_rainSplashMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Inequality(0LL, m_rainSplashMesh, 0LL);
		    if ( result )
		    {
		      m_rainSplashMat = (Object_1 *)this->fields.m_rainSplashMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      return UnityEngine::Object::op_Inequality(0LL, m_rainSplashMat, 0LL);
		    }
		  }
		  return result;
		}
		
		internal bool ShouldUpdateAndRender() => default; // 0x0000000189CF261C-0x0000000189CF2668
		// Boolean ShouldUpdateAndRender()
		bool HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(
		        HGRainSplashRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1591, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1591, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
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
