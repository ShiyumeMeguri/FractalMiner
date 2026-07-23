using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public class HGFarRainRenderer : HGBaseSubRainRenderer // TypeDefIndex: 38858
	{
		// Fields
		private Mesh m_farRainSpindleMesh; // 0x20
		private Vector3 m_farRainSpindleMeshExtents; // 0x28
		private Shader m_farRainShader; // 0x38
		private Material m_middleRainMat; // 0x40
		private Material m_farRainMat; // 0x48
		private Material m_rainWaveMat; // 0x50
		private MaterialPropertyBlock m_farRainmaterialPropertyBlock; // 0x58
		private MaterialPropertyBlock m_middleRainmaterialPropertyBlock; // 0x60
		private MaterialPropertyBlock m_rainWaveMaterialPropertyBlock; // 0x68
		private FarRainRenderParams m_farRainRenderParams; // 0x70
		private float m_middleRainLayerOffset; // 0x78
		private float m_farRainLayerOffset; // 0x7C
		private Vector4 m_rainWaveLayerOffset; // 0x80
		private static readonly Vector4 s_defaultScaleOffset; // 0x00
		private const string s_rainWaveKw = "RAIN_WAVE"; // Metadata: 0x023044EB
	
		// Nested types
		private class FarRainRenderParams // TypeDefIndex: 38857
		{
			// Fields
			public Vector3 pos; // 0x10
			public Vector3 farRainscale; // 0x1C
			public Vector3 middleRainScale; // 0x28
			public Vector3 rainWaveScale; // 0x34
			public Vector3 middleRainDirection; // 0x40
			public Vector3 farRainDirection; // 0x4C
			public UnityEngine.Color middleRainColor; // 0x58
			public UnityEngine.Color farRainColor; // 0x68
			public UnityEngine.Color rainWaveColor; // 0x78
			public Texture2D rainStreakTexture0; // 0x88
			public Texture2D rainStreakTexture1; // 0x90
			public Vector4 rainStreakTextureScaleOffset0; // 0x98
			public Vector4 rainStreakTextureScaleOffset1; // 0xA8
			public Texture2D rainWaveTexture; // 0xB8
			public Vector4 rainWaveTextureScaleOffset; // 0xC0
			public Vector4 rainWaveNoiseScaleOffset; // 0xD0
			public float streakLength; // 0xE0
			public float intensity; // 0xE4
			public float rainWaveHorizontalSpeed; // 0xE8
			public float rainWaveBottomFadeFactor; // 0xEC
			public float taauFixFactor; // 0xF0
			public bool enableMiddleRain; // 0xF4
			public bool enableRainWave; // 0xF5
	
			// Constructors
			public FarRainRenderParams() {} // 0x0000000182EDD200-0x0000000182EDD330
		}
	
		// Constructors
		public HGFarRainRenderer() {} // 0x0000000182EDA6A0-0x0000000182EDA7C0
		static HGFarRainRenderer() {} // 0x0000000184D849A0-0x0000000184D849C0
		// HGFarRainRenderer()
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::cctor(MethodInfo *method)
		{
		  *(__m128i *)TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer->static_fields = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		}
		
	
		// Methods
		internal override void PrepareResources(RainCommonResources commonResources) {} // 0x0000000184528320-0x0000000184528700
		internal override void UpdateData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime) {} // 0x0000000189CDA5FC-0x0000000189CDAC3C
		// Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateData(
		        HGFarRainRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        HGCamera *hgCamera,
		        float deltaTime,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *z_low; // rdx
		  char *m_farRainRenderParams; // rcx
		  RainCommonPreSettingParam *commonPresettingParam; // rsi
		  float v11; // xmm6_4
		  RainCommonPreSettingParam *v12; // rax
		  float rainWaveNoiseFlowSpeedMultiplier; // xmm8_4
		  __m128 farRainDistance_low; // xmm1
		  __m128 maxRainHeight_low; // xmm2
		  float v16; // xmm3_4
		  __m128 middleRainDistance_low; // xmm0
		  __m128 v18; // xmm1
		  float v19; // xmm2_4
		  __m128 rainWaveDistance_low; // xmm0
		  __m128 v21; // xmm1
		  float v22; // xmm2_4
		  HGFarRainRenderer_FarRainRenderParams *v23; // rbp
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  VolumetricRenderer_VolumetricBounds *v26; // r8
		  Int32__Array **v27; // r9
		  HGFarRainRenderer_FarRainRenderParams *v28; // rax
		  HGFarRainRenderer_FarRainRenderParams *v29; // rax
		  HGFarRainRenderer_FarRainRenderParams *v30; // rax
		  __m128i v31; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v32; // rax
		  HGFarRainRenderer_FarRainRenderParams *v33; // rax
		  __m128i v34; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v35; // rax
		  HGFarRainRenderer_FarRainRenderParams *v36; // rax
		  __m128i v37; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v38; // rax
		  HGFarRainRenderer_FarRainRenderParams *v39; // rax
		  RainCommonRenderingParam *v40; // rax
		  RainCommonRenderingParam *v41; // rax
		  VolumetricRenderer_VolumetricBounds *v42; // r8
		  Int32__Array **v43; // r9
		  VolumetricRenderer_VolumetricBounds *v44; // r8
		  HGFarRainRenderer_FarRainRenderParams *v45; // r9
		  __m128i v46; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v47; // rax
		  __m128i v48; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v49; // r9
		  __m128i v50; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v51; // rax
		  __m128i v52; // xmm1
		  HGFarRainRenderer_FarRainRenderParams *v53; // rsi
		  int v54; // xmm0_4
		  HGFarRainRenderer_FarRainRenderParams *v55; // rax
		  HGFarRainRenderer_FarRainRenderParams *v56; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-58h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-58h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-58h]
		  MethodInfo *v61; // [rsp+28h] [rbp-50h]
		  MethodInfo *v62; // [rsp+28h] [rbp-50h]
		  MethodInfo *v63; // [rsp+28h] [rbp-50h]
		  Vector3 v64; // [rsp+30h] [rbp-48h] BYREF
		  float v65; // [rsp+40h] [rbp-38h]
		  int32_t v66; // [rsp+48h] [rbp-30h]
		  bool v67; // [rsp+50h] [rbp-28h]
		  bool v68; // [rsp+58h] [rbp-20h]
		  __int128 v69; // [rsp+60h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5490, 0LL) )
		  {
		    if ( *rainCommonRenderingParam )
		    {
		      commonPresettingParam = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		      if ( commonPresettingParam )
		      {
		        v11 = (float)((float)((float)(0.5 / commonPresettingParam->fields.maxRainHeight)
		                            * (*rainCommonRenderingParam)->fields.speed)
		                    * 0.050000001)
		            * commonPresettingParam->fields.farRainMaxUVFlowSpeed;
		        if ( *rainCommonRenderingParam )
		        {
		          this->fields.m_middleRainLayerOffset = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                   this,
		                                                   this->fields.m_middleRainLayerOffset,
		                                                   v11
		                                                 * (*rainCommonRenderingParam)->fields.middleRainLayerSpeedDiffMultiplier,
		                                                   deltaTime,
		                                                   0LL);
		          if ( *rainCommonRenderingParam )
		          {
		            this->fields.m_farRainLayerOffset = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                  this,
		                                                  this->fields.m_farRainLayerOffset,
		                                                  v11
		                                                * (*rainCommonRenderingParam)->fields.farRainLayerSpeedDiffMultiplier,
		                                                  deltaTime,
		                                                  0LL);
		            if ( *rainCommonRenderingParam )
		            {
		              v12 = (*rainCommonRenderingParam)->fields.commonPresettingParam;
		              if ( v12 )
		              {
		                rainWaveNoiseFlowSpeedMultiplier = v12->fields.rainWaveNoiseFlowSpeedMultiplier;
		                this->fields.m_rainWaveLayerOffset.x = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                         this,
		                                                         this->fields.m_rainWaveLayerOffset.x,
		                                                         v11
		                                                       * (*rainCommonRenderingParam)->fields.rainWaveHorizontalSpeed,
		                                                         deltaTime,
		                                                         0LL);
		                if ( *rainCommonRenderingParam )
		                {
		                  this->fields.m_rainWaveLayerOffset.y = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                           this,
		                                                           this->fields.m_rainWaveLayerOffset.y,
		                                                           v11
		                                                         * (*rainCommonRenderingParam)->fields.rainWaveVerticalSpeed,
		                                                           deltaTime,
		                                                           0LL);
		                  if ( *rainCommonRenderingParam )
		                  {
		                    this->fields.m_rainWaveLayerOffset.z = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                             this,
		                                                             this->fields.m_rainWaveLayerOffset.z,
		                                                             (float)(v11
		                                                                   * (*rainCommonRenderingParam)->fields.rainWaveHorizontalSpeed)
		                                                           * rainWaveNoiseFlowSpeedMultiplier,
		                                                             deltaTime,
		                                                             0LL);
		                    if ( *rainCommonRenderingParam )
		                    {
		                      this->fields.m_rainWaveLayerOffset.w = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		                                                               this,
		                                                               this->fields.m_rainWaveLayerOffset.w,
		                                                               (float)(v11
		                                                                     * (*rainCommonRenderingParam)->fields.rainWaveVerticalSpeed)
		                                                             * rainWaveNoiseFlowSpeedMultiplier,
		                                                               deltaTime,
		                                                               0LL);
		                      m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                      farRainDistance_low = (__m128)LODWORD(commonPresettingParam->fields.farRainDistance);
		                      maxRainHeight_low = (__m128)LODWORD(commonPresettingParam->fields.maxRainHeight);
		                      farRainDistance_low.m128_f32[0] = farRainDistance_low.m128_f32[0]
		                                                      / this->fields.m_farRainSpindleMeshExtents.x;
		                      maxRainHeight_low.m128_f32[0] = maxRainHeight_low.m128_f32[0]
		                                                    / this->fields.m_farRainSpindleMeshExtents.y;
		                      v16 = commonPresettingParam->fields.farRainDistance / this->fields.m_farRainSpindleMeshExtents.z;
		                      if ( m_farRainRenderParams )
		                      {
		                        *(_QWORD *)(m_farRainRenderParams + 28) = _mm_unpacklo_ps(
		                                                                    farRainDistance_low,
		                                                                    maxRainHeight_low).m128_u64[0];
		                        *((float *)m_farRainRenderParams + 9) = v16;
		                        m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                        middleRainDistance_low = (__m128)LODWORD(commonPresettingParam->fields.middleRainDistance);
		                        v18 = (__m128)LODWORD(commonPresettingParam->fields.maxRainHeight);
		                        middleRainDistance_low.m128_f32[0] = middleRainDistance_low.m128_f32[0]
		                                                           / this->fields.m_farRainSpindleMeshExtents.x;
		                        v18.m128_f32[0] = v18.m128_f32[0] / this->fields.m_farRainSpindleMeshExtents.y;
		                        v19 = commonPresettingParam->fields.middleRainDistance
		                            / this->fields.m_farRainSpindleMeshExtents.z;
		                        if ( m_farRainRenderParams )
		                        {
		                          *((_QWORD *)m_farRainRenderParams + 5) = _mm_unpacklo_ps(middleRainDistance_low, v18).m128_u64[0];
		                          *((float *)m_farRainRenderParams + 12) = v19;
		                          m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                          rainWaveDistance_low = (__m128)LODWORD(commonPresettingParam->fields.rainWaveDistance);
		                          v21 = (__m128)LODWORD(commonPresettingParam->fields.maxRainHeight);
		                          rainWaveDistance_low.m128_f32[0] = rainWaveDistance_low.m128_f32[0]
		                                                           / this->fields.m_farRainSpindleMeshExtents.x;
		                          v21.m128_f32[0] = v21.m128_f32[0] / this->fields.m_farRainSpindleMeshExtents.y;
		                          v22 = commonPresettingParam->fields.rainWaveDistance
		                              / this->fields.m_farRainSpindleMeshExtents.z;
		                          if ( m_farRainRenderParams )
		                          {
		                            *(_QWORD *)(m_farRainRenderParams + 52) = _mm_unpacklo_ps(rainWaveDistance_low, v21).m128_u64[0];
		                            *((float *)m_farRainRenderParams + 15) = v22;
		                            v23 = this->fields.m_farRainRenderParams;
		                            if ( hgCamera )
		                            {
		                              m_farRainRenderParams = (char *)hgCamera->fields.camera;
		                              if ( m_farRainRenderParams )
		                              {
		                                transform = UnityEngine::Component::get_transform(
		                                              (Component *)m_farRainRenderParams,
		                                              0LL);
		                                if ( transform )
		                                {
		                                  position = UnityEngine::Transform::get_position(&v64, transform, 0LL);
		                                  m_farRainRenderParams = (char *)LODWORD(position->z);
		                                  if ( v23 )
		                                  {
		                                    *(_QWORD *)&v23->fields.pos.x = *(_QWORD *)&position->x;
		                                    LODWORD(v23->fields.pos.z) = (_DWORD)m_farRainRenderParams;
		                                    m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                    v28 = this->fields.m_farRainRenderParams;
		                                    if ( *rainCommonRenderingParam )
		                                    {
		                                      if ( v28 )
		                                      {
		                                        v28->fields.intensity = *((float *)m_farRainRenderParams + 6) * 0.0099999998;
		                                        m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                        v29 = this->fields.m_farRainRenderParams;
		                                        if ( *rainCommonRenderingParam )
		                                        {
		                                          if ( v29 )
		                                          {
		                                            v29->fields.streakLength = *((float *)m_farRainRenderParams + 12);
		                                            m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                            v30 = this->fields.m_farRainRenderParams;
		                                            if ( *rainCommonRenderingParam )
		                                            {
		                                              v31 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
		                                              if ( v30 )
		                                              {
		                                                v30->fields.middleRainColor = (Color)v31;
		                                                v32 = this->fields.m_farRainRenderParams;
		                                                if ( v32 )
		                                                {
		                                                  m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                  if ( *rainCommonRenderingParam )
		                                                  {
		                                                    v32->fields.middleRainColor.a = v32->fields.middleRainColor.a
		                                                                                  * *((float *)m_farRainRenderParams + 17);
		                                                    m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                    v33 = this->fields.m_farRainRenderParams;
		                                                    if ( *rainCommonRenderingParam )
		                                                    {
		                                                      v34 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
		                                                      if ( v33 )
		                                                      {
		                                                        v33->fields.farRainColor = (Color)v34;
		                                                        v35 = this->fields.m_farRainRenderParams;
		                                                        if ( v35 )
		                                                        {
		                                                          m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                          if ( *rainCommonRenderingParam )
		                                                          {
		                                                            v35->fields.farRainColor.a = v35->fields.farRainColor.a
		                                                                                       * *((float *)m_farRainRenderParams
		                                                                                         + 18);
		                                                            m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                            v36 = this->fields.m_farRainRenderParams;
		                                                            if ( *rainCommonRenderingParam )
		                                                            {
		                                                              v37 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
		                                                              if ( v36 )
		                                                              {
		                                                                v36->fields.rainWaveColor = (Color)v37;
		                                                                m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                if ( m_farRainRenderParams )
		                                                                {
		                                                                  if ( *rainCommonRenderingParam )
		                                                                  {
		                                                                    *((_DWORD *)m_farRainRenderParams + 33) = LODWORD((*rainCommonRenderingParam)->fields.rainWaveAlpha);
		                                                                    m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                                    v38 = this->fields.m_farRainRenderParams;
		                                                                    if ( *rainCommonRenderingParam )
		                                                                    {
		                                                                      if ( v38 )
		                                                                      {
		                                                                        v38->fields.rainWaveHorizontalSpeed = *((float *)m_farRainRenderParams + 23);
		                                                                        m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                                        v39 = this->fields.m_farRainRenderParams;
		                                                                        if ( *rainCommonRenderingParam )
		                                                                        {
		                                                                          if ( v39 )
		                                                                          {
		                                                                            v39->fields.rainWaveBottomFadeFactor = *((float *)m_farRainRenderParams + 24);
		                                                                            v40 = *rainCommonRenderingParam;
		                                                                            m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                            if ( *rainCommonRenderingParam )
		                                                                            {
		                                                                              z_low = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)LODWORD(v40->fields.middleRainDirection.z);
		                                                                              if ( m_farRainRenderParams )
		                                                                              {
		                                                                                *((_QWORD *)m_farRainRenderParams + 8) = *(_QWORD *)&v40->fields.middleRainDirection.x;
		                                                                                *((_DWORD *)m_farRainRenderParams + 18) = (_DWORD)z_low;
		                                                                                v41 = *rainCommonRenderingParam;
		                                                                                m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                                if ( *rainCommonRenderingParam )
		                                                                                {
		                                                                                  z_low = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)LODWORD(v41->fields.farRainDirection.z);
		                                                                                  if ( m_farRainRenderParams )
		                                                                                  {
		                                                                                    *(_QWORD *)(m_farRainRenderParams
		                                                                                              + 76) = *(_QWORD *)&v41->fields.farRainDirection.x;
		                                                                                    *((_DWORD *)m_farRainRenderParams
		                                                                                    + 21) = (_DWORD)z_low;
		                                                                                    m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                                    if ( m_farRainRenderParams )
		                                                                                    {
		                                                                                      *((_QWORD *)m_farRainRenderParams
		                                                                                      + 17) = commonPresettingParam->fields.farRainTex0;
		                                                                                      sub_18002D1B0(
		                                                                                        (VolumetricRenderer_VolumetricRenderItem *)(m_farRainRenderParams + 136),
		                                                                                        z_low,
		                                                                                        v26,
		                                                                                        v27,
		                                                                                        P3,
		                                                                                        v61,
		                                                                                        SLODWORD(v64.x),
		                                                                                        SLODWORD(v64.z),
		                                                                                        v65,
		                                                                                        v66,
		                                                                                        v67,
		                                                                                        v68,
		                                                                                        (MethodInfo *)v69);
		                                                                                      m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                                      if ( m_farRainRenderParams )
		                                                                                      {
		                                                                                        *((_QWORD *)m_farRainRenderParams
		                                                                                        + 18) = commonPresettingParam->fields.farRainTex1;
		                                                                                        sub_18002D1B0(
		                                                                                          (VolumetricRenderer_VolumetricRenderItem *)(m_farRainRenderParams + 144),
		                                                                                          z_low,
		                                                                                          v42,
		                                                                                          v43,
		                                                                                          P3a,
		                                                                                          v62,
		                                                                                          SLODWORD(v64.x),
		                                                                                          SLODWORD(v64.z),
		                                                                                          v65,
		                                                                                          v66,
		                                                                                          v67,
		                                                                                          v68,
		                                                                                          (MethodInfo *)v69);
		                                                                                        v45 = this->fields.m_farRainRenderParams;
		                                                                                        v46 = _mm_loadu_si128((const __m128i *)&commonPresettingParam->fields.farRainTex0_ST);
		                                                                                        if ( v45 )
		                                                                                        {
		                                                                                          v45->fields.rainStreakTextureScaleOffset0 = (Vector4)v46;
		                                                                                          v47 = this->fields.m_farRainRenderParams;
		                                                                                          v48 = _mm_loadu_si128((const __m128i *)&commonPresettingParam->fields.farRainTex1_ST);
		                                                                                          if ( v47 )
		                                                                                          {
		                                                                                            v47->fields.rainStreakTextureScaleOffset1 = (Vector4)v48;
		                                                                                            m_farRainRenderParams = (char *)this->fields.m_farRainRenderParams;
		                                                                                            if ( m_farRainRenderParams )
		                                                                                            {
		                                                                                              *((_QWORD *)m_farRainRenderParams
		                                                                                              + 23) = commonPresettingParam->fields.rainWaveTex;
		                                                                                              sub_18002D1B0(
		                                                                                                (VolumetricRenderer_VolumetricRenderItem *)(m_farRainRenderParams + 184),
		                                                                                                z_low,
		                                                                                                v44,
		                                                                                                (Int32__Array **)v45,
		                                                                                                P3b,
		                                                                                                v63,
		                                                                                                SLODWORD(v64.x),
		                                                                                                SLODWORD(v64.z),
		                                                                                                v65,
		                                                                                                v66,
		                                                                                                v67,
		                                                                                                v68,
		                                                                                                (MethodInfo *)v69);
		                                                                                              v49 = this->fields.m_farRainRenderParams;
		                                                                                              v50 = _mm_loadu_si128((const __m128i *)&commonPresettingParam->fields.rainWaveTex_ST);
		                                                                                              if ( v49 )
		                                                                                              {
		                                                                                                v49->fields.rainWaveTextureScaleOffset = (Vector4)v50;
		                                                                                                v51 = this->fields.m_farRainRenderParams;
		                                                                                                v52 = _mm_loadu_si128((const __m128i *)&commonPresettingParam->fields.rainWaveNoise_ST);
		                                                                                                if ( v51 )
		                                                                                                {
		                                                                                                  v51->fields.rainWaveNoiseScaleOffset = (Vector4)v52;
		                                                                                                  v53 = this->fields.m_farRainRenderParams;
		                                                                                                  v54 = HG::Rendering::Runtime::HGCamera::get_enableTAAU(hgCamera, 0LL) ? 1045220557 : 0;
		                                                                                                  if ( v53 )
		                                                                                                  {
		                                                                                                    LODWORD(v53->fields.taauFixFactor) = v54;
		                                                                                                    m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                                                                    v55 = this->fields.m_farRainRenderParams;
		                                                                                                    if ( *rainCommonRenderingParam )
		                                                                                                    {
		                                                                                                      LOBYTE(z_low) = m_farRainRenderParams[56];
		                                                                                                      if ( v55 )
		                                                                                                      {
		                                                                                                        v55->fields.enableMiddleRain = (char)z_low;
		                                                                                                        m_farRainRenderParams = (char *)*rainCommonRenderingParam;
		                                                                                                        v56 = this->fields.m_farRainRenderParams;
		                                                                                                        if ( *rainCommonRenderingParam )
		                                                                                                        {
		                                                                                                          LOBYTE(z_low) = m_farRainRenderParams[80];
		                                                                                                          if ( v56 )
		                                                                                                          {
		                                                                                                            v56->fields.enableRainWave = (char)z_low;
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
		      }
		    }
		LABEL_59:
		    sub_1800D8260(m_farRainRenderParams, z_low);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5490, 0LL);
		  if ( !Patch )
		    goto LABEL_59;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1590(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    (Object *)hgCamera,
		    deltaTime,
		    0LL);
		}
		
		internal override void SetMaterialData([IsReadOnly] in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context) {} // 0x0000000189CDA168-0x0000000189CDA5E4
		// Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::SetMaterialData(
		        HGFarRainRenderer *this,
		        RainCommonRenderingParam **rainCommonRenderingParam,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  void *static_fields; // rdx
		  char *v8; // rcx
		  HGFarRainRenderer_FarRainRenderParams *m_farRainRenderParams; // rax
		  float m_middleRainLayerOffset; // xmm8_4
		  float streakLength; // xmm7_4
		  float intensity; // xmm6_4
		  Vector4 *v13; // rax
		  __m128i v14; // xmm10
		  Vector4 *v15; // rax
		  __m128i v16; // xmm12
		  __m128i v17; // xmm11
		  RainCommonRenderingParam *v18; // rax
		  int cameraMask; // esi
		  float middleRainLightingPercent; // xmm8_4
		  _BOOL8 v21; // rax
		  Material *m_middleRainMat; // rdi
		  HGFarRainRenderer_FarRainRenderParams *v23; // rax
		  float x; // xmm7_4
		  float taauFixFactor; // xmm6_4
		  Vector4 *v26; // rax
		  __m128i v27; // xmm8
		  Vector4 *v28; // rax
		  __m128i v29; // xmm9
		  Vector4 *v30; // rax
		  MaterialPropertyBlock *m_middleRainmaterialPropertyBlock; // rsi
		  __m128i v32; // xmm7
		  HGFarRainRenderer_FarRainRenderParams *v33; // rax
		  Texture2D *rainStreakTexture0; // rdi
		  __m128i v35; // xmm6
		  HGFarRainRenderer_FarRainRenderParams *v36; // rax
		  Vector4 middleRainColor; // xmm0
		  Vector4 v38; // xmm1
		  HGFarRainRenderer_FarRainRenderParams *v39; // rax
		  Texture2D *rainStreakTexture1; // r8
		  Vector4 v41; // xmm1
		  MaterialPropertyBlock *m_farRainmaterialPropertyBlock; // rdx
		  Vector4 v43; // xmm0
		  HGFarRainRenderer_FarRainRenderParams *v44; // rax
		  Texture2D *rainWaveTexture; // r8
		  Vector4 rainWaveNoiseScaleOffset; // xmm1
		  MaterialPropertyBlock *m_rainWaveMaterialPropertyBlock; // rdx
		  Vector4 rainWaveTextureScaleOffset; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v50; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v51; // [rsp+68h] [rbp-A0h] BYREF
		  __m128i v52; // [rsp+78h] [rbp-90h] BYREF
		  Color rainWaveColor; // [rsp+88h] [rbp-80h] BYREF
		  Vector4 v54[8]; // [rsp+98h] [rbp-70h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5492, 0LL) )
		  {
		    m_farRainRenderParams = this->fields.m_farRainRenderParams;
		    m_middleRainLayerOffset = this->fields.m_middleRainLayerOffset;
		    if ( m_farRainRenderParams )
		    {
		      streakLength = m_farRainRenderParams->fields.streakLength;
		      intensity = m_farRainRenderParams->fields.intensity;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v13 = HG::Rendering::Runtime::HGUtils::PackVector4(v54, m_middleRainLayerOffset, streakLength, intensity, 0LL);
		      v8 = (char *)this->fields.m_farRainRenderParams;
		      v14 = _mm_loadu_si128((const __m128i *)v13);
		      if ( v8 )
		      {
		        v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                v54,
		                this->fields.m_farRainLayerOffset,
		                *((float *)v8 + 56),
		                *((float *)v8 + 57),
		                0LL);
		        v16 = _mm_loadu_si128((const __m128i *)&this->fields.m_rainWaveLayerOffset);
		        v17 = _mm_loadu_si128((const __m128i *)v15);
		        v18 = *rainCommonRenderingParam;
		        if ( *rainCommonRenderingParam )
		        {
		          cameraMask = v18->fields.cameraMask;
		          middleRainLightingPercent = v18->fields.middleRainLightingPercent;
		          if ( v18->fields.enableRainLighting )
		            v21 = middleRainLightingPercent > COERCE_FLOAT(1);
		          else
		            LODWORD(v21) = 0;
		          m_middleRainMat = this->fields.m_middleRainMat;
		          if ( v21 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		            if ( !m_middleRainMat )
		              goto LABEL_23;
		            UnityEngine::Material::EnableKeyword(m_middleRainMat, *((String **)static_fields + 1), 0LL);
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		            v8 = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		            if ( !m_middleRainMat )
		              goto LABEL_23;
		            UnityEngine::Material::DisableKeyword(m_middleRainMat, *((String **)v8 + 1), 0LL);
		          }
		          v23 = this->fields.m_farRainRenderParams;
		          if ( v23 )
		          {
		            x = v23->fields.middleRainScale.x;
		            taauFixFactor = v23->fields.taauFixFactor;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            v26 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    v54,
		                    (float)cameraMask,
		                    middleRainLightingPercent,
		                    x,
		                    taauFixFactor,
		                    0LL);
		            v8 = (char *)this->fields.m_farRainRenderParams;
		            v27 = _mm_loadu_si128((const __m128i *)v26);
		            if ( v8 )
		            {
		              v28 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                      v54,
		                      (float)cameraMask,
		                      0.0,
		                      *((float *)v8 + 7),
		                      *((float *)v8 + 60),
		                      0LL);
		              static_fields = this->fields.m_farRainRenderParams;
		              v29 = _mm_loadu_si128((const __m128i *)v28);
		              if ( static_fields )
		              {
		                v30 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                        v54,
		                        (float)cameraMask,
		                        *((float *)static_fields + 59),
		                        *((float *)static_fields + 10),
		                        *((float *)static_fields + 60),
		                        0LL);
		                m_middleRainmaterialPropertyBlock = this->fields.m_middleRainmaterialPropertyBlock;
		                v32 = _mm_loadu_si128((const __m128i *)v30);
		                v33 = this->fields.m_farRainRenderParams;
		                if ( v33 )
		                {
		                  rainStreakTexture0 = v33->fields.rainStreakTexture0;
		                  v35 = _mm_loadu_si128((const __m128i *)&v33->fields.rainStreakTextureScaleOffset0);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
		                  v8 = (char *)TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer->static_fields;
		                  v36 = this->fields.m_farRainRenderParams;
		                  if ( v36 )
		                  {
		                    middleRainColor = (Vector4)v36->fields.middleRainColor;
		                    v38 = *(Vector4 *)v8;
		                    v50 = v27;
		                    v52 = v14;
		                    v54[0] = (Vector4)v35;
		                    v51 = middleRainColor;
		                    rainWaveColor = (Color)v38;
		                    HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
		                      this,
		                      m_middleRainmaterialPropertyBlock,
		                      rainStreakTexture0,
		                      v54,
		                      (Vector4 *)&rainWaveColor,
		                      (Vector4 *)&v52,
		                      (Color *)&v51,
		                      (Vector4 *)&v50,
		                      0LL);
		                    v39 = this->fields.m_farRainRenderParams;
		                    if ( v39 )
		                    {
		                      rainStreakTexture1 = v39->fields.rainStreakTexture1;
		                      v8 = (char *)this->fields.m_farRainRenderParams;
		                      static_fields = TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer->static_fields;
		                      if ( v8 )
		                      {
		                        v41 = *(Vector4 *)static_fields;
		                        m_farRainmaterialPropertyBlock = this->fields.m_farRainmaterialPropertyBlock;
		                        rainWaveColor = *(Color *)(v8 + 104);
		                        v43 = *(Vector4 *)(v8 + 168);
		                        v54[0] = (Vector4)v29;
		                        v52 = v17;
		                        v51 = v41;
		                        v50 = (__m128i)v43;
		                        HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
		                          this,
		                          m_farRainmaterialPropertyBlock,
		                          rainStreakTexture1,
		                          (Vector4 *)&v50,
		                          &v51,
		                          (Vector4 *)&v52,
		                          &rainWaveColor,
		                          v54,
		                          0LL);
		                        v44 = this->fields.m_farRainRenderParams;
		                        if ( v44 )
		                        {
		                          rainWaveTexture = v44->fields.rainWaveTexture;
		                          rainWaveNoiseScaleOffset = v44->fields.rainWaveNoiseScaleOffset;
		                          m_rainWaveMaterialPropertyBlock = this->fields.m_rainWaveMaterialPropertyBlock;
		                          rainWaveColor = v44->fields.rainWaveColor;
		                          rainWaveTextureScaleOffset = v44->fields.rainWaveTextureScaleOffset;
		                          v54[0] = (Vector4)v32;
		                          v52 = v16;
		                          v51 = rainWaveNoiseScaleOffset;
		                          v50 = (__m128i)rainWaveTextureScaleOffset;
		                          HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
		                            this,
		                            m_rainWaveMaterialPropertyBlock,
		                            rainWaveTexture,
		                            (Vector4 *)&v50,
		                            &v51,
		                            (Vector4 *)&v52,
		                            &rainWaveColor,
		                            v54,
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
		LABEL_23:
		    sub_1800D8260(v8, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5492, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
		    Patch,
		    (Object *)this,
		    (SnowCommonRenderingParam **)rainCommonRenderingParam,
		    context,
		    0LL);
		}
		
		internal override void Dispose() {} // 0x0000000184861490-0x00000001848614F0
		// Void Dispose()
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::Dispose(HGFarRainRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5494, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5494, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_farRainMat,
		      0LL);
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_middleRainMat,
		      0LL);
		    HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
		      (HGBaseSubRainRenderer *)this,
		      this->fields.m_rainWaveMat,
		      0LL);
		  }
		}
		
		private float _GetFractedOffset(float currentOffset, float speed, float deltaTime) => default; // 0x0000000189CDAC3C-0x0000000189CDACE4
		// Single _GetFractedOffset(Single, Single, Single)
		float HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
		        HGFarRainRenderer *this,
		        float currentOffset,
		        float speed,
		        float deltaTime,
		        MethodInfo *method)
		{
		  float v6; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5491, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5491, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1591(Patch, (Object *)this, currentOffset, speed, deltaTime, 0LL);
		  }
		  else
		  {
		    v6 = (float)(speed * deltaTime) + currentOffset;
		    if ( (float)(v6 - 100.0) >= COERCE_FLOAT(1) )
		      return v6 + -100.0;
		    return v6;
		  }
		}
		
		private void _SetFarRainParamsToMPB(MaterialPropertyBlock materialPropertyBlock, Texture2D rainTex, Vector4 rainTexScaleOffset0, Vector4 rainTexScaleOffset1, Vector4 rainParams, UnityEngine.Color rainColor, Vector4 rainMaskParams) {} // 0x0000000189CDACE4-0x0000000189CDAF10
		// Void _SetFarRainParamsToMPB(MaterialPropertyBlock, Texture2D, Vector4, Vector4, Vector4, Color, Vector4)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
		        HGFarRainRenderer *this,
		        MaterialPropertyBlock *materialPropertyBlock,
		        Texture2D *rainTex,
		        Vector4 *rainTexScaleOffset0,
		        Vector4 *rainTexScaleOffset1,
		        Vector4 *rainParams,
		        Color *rainColor,
		        Vector4 *rainMaskParams,
		        MethodInfo *method)
		{
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  int32_t anonObj; // edx
		  int32_t RainTex1_ST; // edx
		  int32_t v17; // edx
		  MethodInfo *v18; // r8
		  int32_t v19; // r10d
		  int32_t v20; // edx
		  Vector4 v21; // xmm0
		  Vector4 v22; // [rsp+58h] [rbp-21h] BYREF
		  Color v23; // [rsp+68h] [rbp-11h] BYREF
		  Vector4 v24; // [rsp+78h] [rbp-1h] BYREF
		  Vector4 v25; // [rsp+88h] [rbp+Fh] BYREF
		  Vector4 v26; // [rsp+98h] [rbp+1Fh] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5493, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		      materialPropertyBlock,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex0,
		      (Texture *)rainTex,
		      0LL);
		    static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( materialPropertyBlock )
		    {
		      anonObj = (int32_t)static_fields[81].fields.anonObj;
		      v22 = *rainTexScaleOffset0;
		      UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, anonObj, &v22, 0LL);
		      RainTex1_ST = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex1_ST;
		      v22 = *rainTexScaleOffset1;
		      UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, RainTex1_ST, &v22, 0LL);
		      v17 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainParams;
		      v22 = *rainParams;
		      UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v17, &v22, 0LL);
		      v22 = (Vector4)*rainColor;
		      v22 = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v26, &v22, v18);
		      UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v19, &v22, 0LL);
		      v20 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainMaskParams;
		      v22 = *rainMaskParams;
		      UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v20, &v22, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(static_fields, v13);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(5493, 0LL);
		  if ( !static_fields )
		    goto LABEL_5;
		  v22 = *rainMaskParams;
		  v23 = *rainColor;
		  v24 = *rainParams;
		  v21 = *rainTexScaleOffset0;
		  v25 = *rainTexScaleOffset1;
		  v26 = v21;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1592(
		    static_fields,
		    (Object *)this,
		    (Object *)materialPropertyBlock,
		    (Object *)rainTex,
		    &v26,
		    &v25,
		    &v24,
		    &v23,
		    &v22,
		    0LL);
		}
		
		internal override void Render(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CD9C9C-0x0000000189CDA168
		// Void Render(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::Render(
		        HGFarRainRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object_1 *m_farRainSpindleMesh; // rbx
		  MaterialPropertyBlock *m_rainWaveMaterialPropertyBlock; // rdx
		  char *cmd; // rcx
		  HGFarRainRenderer_FarRainRenderParams *m_farRainRenderParams; // rax
		  int v11; // r15d
		  int v12; // ecx
		  int v13; // r14d
		  __int64 v14; // xmm6_8
		  float z; // r12d
		  Object_1 *m_rainWaveMat; // rbx
		  MethodInfo *v17; // rdx
		  Quaternion *identity; // rax
		  __int64 v19; // xmm0_8
		  float v20; // ecx
		  Quaternion v21; // xmm0
		  Matrix4x4 *v22; // rax
		  Material *v23; // r9
		  __int128 v24; // xmm1
		  Mesh *v25; // rdx
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  Object_1 *m_farRainMat; // rbx
		  MethodInfo *v29; // rdx
		  MethodInfo *up; // rax
		  __int64 v31; // xmm0_8
		  Vector3 *v32; // rax
		  __int64 *v33; // r8
		  __int64 v34; // xmm0_8
		  __int64 v35; // xmm4_8
		  Quaternion *v36; // rax
		  __int64 v37; // xmm0_8
		  float v38; // ecx
		  Quaternion v39; // xmm0
		  Matrix4x4 *v40; // rax
		  Material *v41; // r9
		  __int128 v42; // xmm1
		  Mesh *v43; // rdx
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  Object_1 *m_middleRainMat; // rbx
		  MethodInfo *v47; // rdx
		  MethodInfo *v48; // rax
		  __int64 v49; // xmm0_8
		  Vector3 *v50; // rax
		  __int64 *v51; // r8
		  __int64 v52; // xmm0_8
		  __int64 v53; // xmm4_8
		  Quaternion *v54; // rax
		  __int64 v55; // xmm0_8
		  float v56; // ecx
		  Quaternion v57; // xmm0
		  Matrix4x4 *v58; // rax
		  Material *v59; // r9
		  __int128 v60; // xmm1
		  Mesh *v61; // rdx
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MaterialPropertyBlock *v65; // [rsp+38h] [rbp-D0h]
		  MaterialPropertyBlock *m_farRainmaterialPropertyBlock; // [rsp+38h] [rbp-D0h]
		  MaterialPropertyBlock *m_middleRainmaterialPropertyBlock; // [rsp+38h] [rbp-D0h]
		  Quaternion v68; // [rsp+48h] [rbp-C0h] BYREF
		  Quaternion v69; // [rsp+58h] [rbp-B0h] BYREF
		  Quaternion v70; // [rsp+68h] [rbp-A0h] BYREF
		  Matrix4x4 v71; // [rsp+78h] [rbp-90h] BYREF
		  Quaternion v72; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v73; // [rsp+C8h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5495, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5495, 0LL);
		    if ( !Patch )
		      goto LABEL_30;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( this->fields._.enabled )
		  {
		    m_farRainSpindleMesh = (Object_1 *)this->fields.m_farRainSpindleMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(m_farRainSpindleMesh, 0LL, 0LL) )
		    {
		      m_farRainRenderParams = this->fields.m_farRainRenderParams;
		      if ( !m_farRainRenderParams )
		        goto LABEL_30;
		      v11 = 0;
		      if ( m_farRainRenderParams->fields.enableMiddleRain )
		        LOBYTE(v11) = m_farRainRenderParams->fields.middleRainColor.a > COERCE_FLOAT(1);
		      v13 = 0;
		      v12 = 0;
		      LOBYTE(v13) = m_farRainRenderParams->fields.farRainColor.a > COERCE_FLOAT(1);
		      if ( m_farRainRenderParams->fields.enableRainWave )
		        LOBYTE(v12) = m_farRainRenderParams->fields.rainWaveColor.a > COERCE_FLOAT(1);
		      v14 = *(_QWORD *)&m_farRainRenderParams->fields.pos.x;
		      z = m_farRainRenderParams->fields.pos.z;
		      if ( v12 )
		      {
		        m_rainWaveMat = (Object_1 *)this->fields.m_rainWaveMat;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(m_rainWaveMat, 0LL, 0LL) )
		        {
		          identity = UnityEngine::Quaternion::get_identity(&v69, v17);
		          cmd = (char *)this->fields.m_farRainRenderParams;
		          if ( !cmd )
		            goto LABEL_30;
		          v19 = *(_QWORD *)(cmd + 52);
		          v20 = *((float *)cmd + 15);
		          *(_QWORD *)&v70.x = v19;
		          v21 = *identity;
		          v70.z = v20;
		          *(_QWORD *)&v68.x = v14;
		          v69 = v21;
		          v68.z = z;
		          v22 = UnityEngine::Matrix4x4::TRS(&v73, (Vector3 *)&v68, &v69, (Vector3 *)&v70, 0LL);
		          if ( !ctx )
		            goto LABEL_30;
		          cmd = (char *)ctx->fields.cmd;
		          m_rainWaveMaterialPropertyBlock = this->fields.m_rainWaveMaterialPropertyBlock;
		          if ( !cmd )
		            goto LABEL_30;
		          v23 = this->fields.m_rainWaveMat;
		          v24 = *(_OWORD *)&v22->m01;
		          v65 = this->fields.m_rainWaveMaterialPropertyBlock;
		          v25 = this->fields.m_farRainSpindleMesh;
		          *(_OWORD *)&v71.m00 = *(_OWORD *)&v22->m00;
		          v26 = *(_OWORD *)&v22->m02;
		          *(_OWORD *)&v71.m01 = v24;
		          v27 = *(_OWORD *)&v22->m03;
		          *(_OWORD *)&v71.m02 = v26;
		          *(_OWORD *)&v71.m03 = v27;
		          UnityEngine::Rendering::CommandBuffer::DrawMesh((CommandBuffer *)cmd, v25, &v71, v23, 0, 0, v65, 0LL);
		        }
		      }
		      if ( v13 )
		      {
		        m_farRainMat = (Object_1 *)this->fields.m_farRainMat;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(m_farRainMat, 0LL, 0LL) )
		        {
		          up = (MethodInfo *)UnityEngine::Vector3::get_up((Vector3 *)&v69, v29);
		          cmd = (char *)this->fields.m_farRainRenderParams;
		          if ( !cmd )
		            goto LABEL_30;
		          v31 = *(_QWORD *)(cmd + 76);
		          v68.z = *((float *)cmd + 21);
		          *(_QWORD *)&v68.x = v31;
		          v32 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v70, (Vector3 *)&v68, up);
		          v34 = *v33;
		          v35 = *(_QWORD *)&v32->x;
		          v68.z = v32->z;
		          LODWORD(v32) = *((_DWORD *)v33 + 2);
		          *(_QWORD *)&v68.x = v35;
		          *(_QWORD *)&v70.x = v34;
		          LODWORD(v70.z) = (_DWORD)v32;
		          v36 = UnityEngine::Quaternion::FromToRotation(&v72, (Vector3 *)&v70, (Vector3 *)&v68, 0LL);
		          cmd = (char *)this->fields.m_farRainRenderParams;
		          if ( !cmd )
		            goto LABEL_30;
		          v37 = *(_QWORD *)(cmd + 28);
		          v38 = *((float *)cmd + 9);
		          *(_QWORD *)&v69.x = v37;
		          v39 = *v36;
		          v69.z = v38;
		          *(_QWORD *)&v68.x = v14;
		          v70 = v39;
		          v68.z = z;
		          v40 = UnityEngine::Matrix4x4::TRS(&v73, (Vector3 *)&v68, &v70, (Vector3 *)&v69, 0LL);
		          if ( !ctx )
		            goto LABEL_30;
		          cmd = (char *)ctx->fields.cmd;
		          m_rainWaveMaterialPropertyBlock = this->fields.m_farRainmaterialPropertyBlock;
		          if ( !cmd )
		            goto LABEL_30;
		          v41 = this->fields.m_farRainMat;
		          v42 = *(_OWORD *)&v40->m01;
		          m_farRainmaterialPropertyBlock = this->fields.m_farRainmaterialPropertyBlock;
		          v43 = this->fields.m_farRainSpindleMesh;
		          *(_OWORD *)&v71.m00 = *(_OWORD *)&v40->m00;
		          v44 = *(_OWORD *)&v40->m02;
		          *(_OWORD *)&v71.m01 = v42;
		          v45 = *(_OWORD *)&v40->m03;
		          *(_OWORD *)&v71.m02 = v44;
		          *(_OWORD *)&v71.m03 = v45;
		          UnityEngine::Rendering::CommandBuffer::DrawMesh(
		            (CommandBuffer *)cmd,
		            v43,
		            &v71,
		            v41,
		            0,
		            0,
		            m_farRainmaterialPropertyBlock,
		            0LL);
		        }
		      }
		      if ( v11 )
		      {
		        m_middleRainMat = (Object_1 *)this->fields.m_middleRainMat;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(m_middleRainMat, 0LL, 0LL) )
		        {
		          v48 = (MethodInfo *)UnityEngine::Vector3::get_up((Vector3 *)&v70, v47);
		          cmd = (char *)this->fields.m_farRainRenderParams;
		          if ( cmd )
		          {
		            v49 = *((_QWORD *)cmd + 8);
		            v69.z = *((float *)cmd + 18);
		            *(_QWORD *)&v69.x = v49;
		            v50 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v68, (Vector3 *)&v69, v48);
		            v52 = *v51;
		            v53 = *(_QWORD *)&v50->x;
		            v69.z = v50->z;
		            LODWORD(v50) = *((_DWORD *)v51 + 2);
		            *(_QWORD *)&v69.x = v53;
		            *(_QWORD *)&v68.x = v52;
		            LODWORD(v68.z) = (_DWORD)v50;
		            v54 = UnityEngine::Quaternion::FromToRotation(&v72, (Vector3 *)&v68, (Vector3 *)&v69, 0LL);
		            cmd = (char *)this->fields.m_farRainRenderParams;
		            if ( cmd )
		            {
		              v55 = *((_QWORD *)cmd + 5);
		              v56 = *((float *)cmd + 12);
		              *(_QWORD *)&v70.x = v55;
		              v57 = *v54;
		              v70.z = v56;
		              *(_QWORD *)&v69.x = v14;
		              v68 = v57;
		              v69.z = z;
		              v58 = UnityEngine::Matrix4x4::TRS(&v73, (Vector3 *)&v69, &v68, (Vector3 *)&v70, 0LL);
		              if ( ctx )
		              {
		                cmd = (char *)ctx->fields.cmd;
		                m_rainWaveMaterialPropertyBlock = this->fields.m_middleRainmaterialPropertyBlock;
		                if ( cmd )
		                {
		                  v59 = this->fields.m_middleRainMat;
		                  v60 = *(_OWORD *)&v58->m01;
		                  m_middleRainmaterialPropertyBlock = this->fields.m_middleRainmaterialPropertyBlock;
		                  v61 = this->fields.m_farRainSpindleMesh;
		                  *(_OWORD *)&v71.m00 = *(_OWORD *)&v58->m00;
		                  v62 = *(_OWORD *)&v58->m02;
		                  *(_OWORD *)&v71.m01 = v60;
		                  v63 = *(_OWORD *)&v58->m03;
		                  *(_OWORD *)&v71.m02 = v62;
		                  *(_OWORD *)&v71.m03 = v63;
		                  UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                    (CommandBuffer *)cmd,
		                    v61,
		                    &v71,
		                    v59,
		                    0,
		                    0,
		                    m_middleRainmaterialPropertyBlock,
		                    0LL);
		                  return;
		                }
		              }
		            }
		          }
		LABEL_30:
		          sub_1800D8260(cmd, m_rainWaveMaterialPropertyBlock);
		        }
		      }
		    }
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
		
		public void __iFixBaseProxy_Dispose() {} // 0x0000000189CDA5E4-0x0000000189CDA5EC
		// Void <>iFixBaseProxy_Dispose()
		void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Dispose(
		        HGFarRainRenderer *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose((HGBaseSubRainRenderer *)this, 0LL);
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
		
	}
}
