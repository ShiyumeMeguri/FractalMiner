using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGAtmosphereRenderer // TypeDefIndex: 37634
	{
		// Fields
		private const string FOG_LAYER_NAME = "Fog"; // Metadata: 0x02302FB3
		private const string HEIGHT_FOG_FLOW_NOISE = "_HEIGHT_FOG_FLOW_NOISE"; // Metadata: 0x02302FB7
		public const float MOBILE_DIR_INSCATTER_EXPONENT_SCALE = 0.2f; // Metadata: 0x02302FCE
		public static readonly int FOG_LAYER; // 0x00
		public static bool forceRenderAtmosphereLutEveryFrame; // 0x04
		private static Texture2D s_defaultFogBakeLUT; // 0x08
		private const int DEFAULT_FOG_BAKE_LUT_WIDTH = 4; // Metadata: 0x02302FD2
		private const string FOG_BAKE_LUT_NAME = "_FogBakeLut"; // Metadata: 0x02302FD3
	
		// Properties
		public static bool useOctahedronSkyViewLut { get => default; } // 0x0000000189CE15E4-0x0000000189CE1624 
		// Boolean get_useOctahedronSkyViewLut()
		bool HG::Rendering::Runtime::HGAtmosphereRenderer::get_useOctahedronSkyViewLut(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1419, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1419, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
	
		// Nested types
		public struct AtmosphereLutConstants // TypeDefIndex: 37633
		{
			// Fields
			public Vector4 _AtmosphereLutParams0; // 0x00
			public Vector4 _AtmosphereLutParams1; // 0x10
			public Vector4 _AtmosphereLutParams2; // 0x20
			public Vector4 _AtmosphereLutParams3; // 0x30
			public Vector4 _AtmosphereLutParams4; // 0x40
			public Vector4 _AtmosphereLutParams5; // 0x50
			public Vector4 _AtmosphereLutParams6; // 0x60
			public Vector4 _AtmosphereLutParams7; // 0x70
			public Vector4 _AtmosphereLutParams8; // 0x80
			public Vector4 _AtmosphereLutParams9; // 0x90
			public Vector4 _AtmosphereLutParams10; // 0xA0
			public Vector4 _AtmosphereLutParams11; // 0xB0
		}
	
		// Constructors
		public HGAtmosphereRenderer() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGAtmosphereRenderer() {} // 0x0000000184D4FA50-0x0000000184D4FAC0
		// HGAtmosphereRenderer()
		void HG::Rendering::Runtime::HGAtmosphereRenderer::cctor(MethodInfo *method)
		{
		  int32_t v1; // eax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		
		  v1 = UnityEngine::LayerMask::NameToLayer((String *)"Fog", 0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields;
		  LODWORD(static_fields->klass) = v1;
		  TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->forceRenderAtmosphereLutEveryFrame = 0;
		  TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT = 0LL;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT,
		    static_fields,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		private static int GetSkyViewLutWidth(HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CDE628-0x0000000189CDE6A8
		// Int32 GetSkyViewLutWidth(HGAtmosphereSettingParameters)
		int32_t HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutWidth(
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Int32Enum__Enum v5; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1418, 0LL) )
		  {
		    if ( atmosphereParams )
		    {
		      v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		             (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.skyViewLutWidth,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      return v5 * (!HG::Rendering::Runtime::HGAtmosphereRenderer::get_useOctahedronSkyViewLut(0LL) + 1);
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1418, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		           (ILFixDynamicMethodWrapper_31 *)Patch,
		           (Object *)atmosphereParams,
		           0LL);
		}
		
		private static int GetSkyViewLutHeight(HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CDE5C8-0x0000000189CDE628
		// Int32 GetSkyViewLutHeight(HGAtmosphereSettingParameters)
		int32_t HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutHeight(
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1420, 0LL) )
		  {
		    if ( atmosphereParams )
		      return HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		               (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.skyViewLutHeight,
		               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1420, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		           (ILFixDynamicMethodWrapper_31 *)Patch,
		           (Object *)atmosphereParams,
		           0LL);
		}
		
		public static bool ShouldRenderAtmosphereLutUsingCompute(HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CE0B40-0x0000000189CE0BAC
		// Boolean ShouldRenderAtmosphereLutUsingCompute(HGAtmosphereSettingParameters)
		bool HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1421, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1421, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		             (ILFixDynamicMethodWrapper_20 *)Patch,
		             (Object *)atmosphereParams,
		             0LL);
		  }
		  else
		  {
		    result = UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
		    if ( result )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      return HG::Rendering::Runtime::HGAtmosphereRenderer::get_useOctahedronSkyViewLut(0LL);
		    }
		  }
		  return result;
		}
		
		public void SetupShaderVariablesGlobalAtmosphereFog(ref ShaderVariablesGlobal cb, HGCamera hgCamera, HGEnvironmentPhase phase) {} // 0x0000000189CDFA98-0x0000000189CE00A4
		// Void SetupShaderVariablesGlobalAtmosphereFog(ShaderVariablesGlobal ByRef, HGCamera, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalAtmosphereFog(
		        HGAtmosphereRenderer *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Component *camera; // rcx
		  MethodInfo *v11; // r9
		  float directIntensity; // xmm2_4
		  Vector4 *v13; // rax
		  float v14; // xmm2_4
		  __m128i v15; // xmm7
		  MethodInfo *v16; // r9
		  float mieScatteringScale; // xmm2_4
		  MethodInfo *v18; // r9
		  Vector4 *v19; // r14
		  float mieAbsorptionScale; // xmm2_4
		  MethodInfo *v21; // r9
		  MethodInfo *v22; // r9
		  float v23; // xmm2_4
		  MethodInfo *v24; // rax
		  Vector4 *v25; // r8
		  Vector4 v26; // xmm1
		  Quaternion v27; // xmm4
		  MethodInfo *v28; // r9
		  Vector4 *v29; // rax
		  __m128 v30; // xmm12
		  Vector4 v31; // xmm0
		  MethodInfo *v32; // r9
		  Quaternion v33; // xmm1
		  Vector4 v34; // xmm4
		  Vector4 *v35; // r10
		  MethodInfo *v36; // r9
		  MethodInfo *v37; // r9
		  MethodInfo *v38; // r9
		  __m128 v39; // xmm4
		  Vector4 v40; // xmm1
		  Vector4 v41; // xmm5
		  MethodInfo *v42; // r9
		  MethodInfo *v43; // r9
		  __m128 v44; // xmm11
		  Vector4 *v45; // r10
		  Quaternion v46; // xmm5
		  MethodInfo *v47; // r9
		  __m128 v48; // xmm4
		  float startDistance; // xmm6_4
		  MethodInfo *v50; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationAtmosphere; // xmm0
		  __int64 v53; // xmm3_8
		  Vector3 *v54; // rax
		  MethodInfo *v55; // r8
		  Vector3 *v56; // rax
		  float v57; // xmm2_4
		  __int64 v58; // xmm4_8
		  Vector4 *v59; // rax
		  __m128i v60; // xmm0
		  Vector4 *v61; // rax
		  Transform *transform; // rax
		  float v63; // xmm2_4
		  float v64; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion directColor; // [rsp+38h] [rbp-D0h] BYREF
		  __m128i v67; // [rsp+48h] [rbp-C0h] BYREF
		  Quaternion v68; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v69; // [rsp+68h] [rbp-A0h] BYREF
		  __m128 v70; // [rsp+78h] [rbp-90h] BYREF
		  Vector4 v71; // [rsp+88h] [rbp-80h] BYREF
		  Vector4 v72; // [rsp+98h] [rbp-70h] BYREF
		  Vector4 v73; // [rsp+A8h] [rbp-60h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1422, 0LL) )
		  {
		    if ( phase )
		    {
		      directIntensity = phase->fields.lightConfig.directIntensity;
		      directColor = (Quaternion)phase->fields.lightConfig.directColor;
		      v13 = UnityEngine::Vector4::op_Multiply((Vector4 *)&v70, (Vector4 *)&directColor, directIntensity, v11);
		      v14 = phase->fields.lightConfig.directIntensity;
		      v15 = _mm_loadu_si128((const __m128i *)v13);
		      directColor = (Quaternion)phase->fields.fogConfig.inscatterAmbientColor;
		      UnityEngine::Vector4::op_Multiply(&v69, (Vector4 *)&directColor, v14, v16);
		      mieScatteringScale = phase->fields.fogConfig.mieScatteringScale;
		      directColor = (Quaternion)phase->fields.fogConfig.mieScattering;
		      v19 = UnityEngine::Vector4::op_Multiply(&v73, (Vector4 *)&directColor, mieScatteringScale, v18);
		      mieAbsorptionScale = phase->fields.atmosphereConfig.mieAbsorptionScale;
		      directColor = (Quaternion)phase->fields.atmosphereConfig.mieAbsorption;
		      UnityEngine::Vector4::op_Multiply((Vector4 *)&v67, (Vector4 *)&directColor, mieAbsorptionScale, v21);
		      v23 = phase->fields.fogConfig.rayleighScatteringScale >= 0.0
		          ? phase->fields.fogConfig.rayleighScatteringScale
		          : phase->fields.atmosphereConfig.rayleighScatteringScale;
		      directColor = (Quaternion)phase->fields.fogConfig.rayleighScattering;
		      v24 = (MethodInfo *)UnityEngine::Vector4::op_Multiply(&v72, (Vector4 *)&directColor, v23, v22);
		      v26 = *v25;
		      v27 = *(Quaternion *)&v24->methodPointer;
		      v68 = (Quaternion)*v19;
		      directColor = v27;
		      v67 = (__m128i)v26;
		      directColor = (Quaternion)*UnityEngine::Vector4::op_Addition(&v71, (Vector4 *)&v68, (Vector4 *)&directColor, v24);
		      v29 = UnityEngine::Vector4::op_Addition(&v71, (Vector4 *)&directColor, (Vector4 *)&v67, v28);
		      v67.m128i_i32[3] = 1065353216;
		      v30 = (__m128)_mm_loadu_si128((const __m128i *)v29);
		      *(float *)v67.m128i_i32 = 1.0 / v30.m128_f32[0];
		      v31 = *v19;
		      *(float *)&v67.m128i_i32[1] = 1.0 / _mm_shuffle_ps(v30, v30, 85).m128_f32[0];
		      v33 = *(Quaternion *)&v32->methodPointer;
		      *(float *)&v67.m128i_i32[2] = 1.0 / _mm_shuffle_ps(v30, v30, 170).m128_f32[0];
		      v68 = v33;
		      directColor = (Quaternion)v31;
		      v34 = *UnityEngine::Vector4::op_Addition(&v71, (Vector4 *)&v68, (Vector4 *)&directColor, v32);
		      v68 = (Quaternion)*v35;
		      directColor = (Quaternion)v34;
		      UnityEngine::Vector4::Scale(&v71, (Vector4 *)&v68, (Vector4 *)&directColor, v36);
		      v68 = *(Quaternion *)&v37->methodPointer;
		      directColor = (Quaternion)v15;
		      directColor = (Quaternion)*UnityEngine::Vector4::Scale(&v72, (Vector4 *)&v68, (Vector4 *)&directColor, v37);
		      v39 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::Scale(
		                                                       &v72,
		                                                       (Vector4 *)&directColor,
		                                                       (Vector4 *)&v67,
		                                                       v38));
		      v68.y = _mm_shuffle_ps(v39, v39, 85).m128_f32[0] / 255.0;
		      v40 = *v19;
		      v68.x = v39.m128_f32[0] / 255.0;
		      v67 = (__m128i)v40;
		      v68.z = _mm_shuffle_ps(v39, v39, 170).m128_f32[0] / 255.0;
		      v68.w = _mm_shuffle_ps(v39, v39, 255).m128_f32[0] / 255.0;
		      directColor = (Quaternion)v15;
		      v69 = v41;
		      directColor = (Quaternion)*UnityEngine::Vector4::Scale(&v72, (Vector4 *)&v67, (Vector4 *)&directColor, v42);
		      v44 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::Scale(
		                                                       &v72,
		                                                       (Vector4 *)&directColor,
		                                                       &v69,
		                                                       v43));
		      v67 = *(__m128i *)v45;
		      directColor = v46;
		      v48 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::Scale(
		                                                       &v71,
		                                                       (Vector4 *)&v67,
		                                                       (Vector4 *)&directColor,
		                                                       v47));
		      startDistance = phase->fields.fogConfig.startDistance;
		      directColor.x = v48.m128_f32[0] / 255.0;
		      directColor.y = _mm_shuffle_ps(v48, v48, 85).m128_f32[0] / 255.0;
		      directColor.z = _mm_shuffle_ps(v48, v48, 170).m128_f32[0] / 255.0;
		      directColor.w = _mm_shuffle_ps(v48, v48, 255).m128_f32[0] / 255.0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v67 = v15;
		      *(__m128i *)&cb->_CharacterParams1.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                &v71,
		                                                                                (Color *)&v67,
		                                                                                startDistance * 0.001,
		                                                                                0LL));
		      fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v67, v50);
		      rotationAtmosphere = phase->fields.lightConfig.rotationAtmosphere;
		      v53 = *(_QWORD *)&fwd->x;
		      *(float *)&fwd = fwd->z;
		      *(_QWORD *)&v69.x = v53;
		      LODWORD(v69.z) = (_DWORD)fwd;
		      v70 = (__m128)rotationAtmosphere;
		      v54 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v67, (Quaternion *)&v70, (Vector3 *)&v69, 0LL);
		      *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v54->x;
		      *(float *)&v54 = v54->z;
		      *(_QWORD *)&v69.x = *(_QWORD *)&rotationAtmosphere.x;
		      LODWORD(v69.z) = (_DWORD)v54;
		      v56 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v67, (Vector3 *)&v69, v55);
		      v57 = phase->fields.fogConfig.fallOffDistance * 0.001;
		      v58 = *(_QWORD *)&v56->x;
		      *(float *)&v56 = v56->z;
		      *(_QWORD *)&v69.x = v58;
		      LODWORD(v69.z) = (_DWORD)v56;
		      v59 = HG::Rendering::Runtime::HGUtils::PackVector4(&v71, (Vector3 *)&v69, v57, 0LL);
		      v70 = v30;
		      *(__m128i *)&cb->_CharacterParams2.w = _mm_loadu_si128((const __m128i *)v59);
		      v60 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               &v71,
		                                               (Color *)&v70,
		                                               phase->fields.fogConfig.mieAnisotropy,
		                                               0LL));
		      v70 = (__m128)v68;
		      *(__m128i *)&cb->_CharacterParams3.w = v60;
		      v61 = HG::Rendering::Runtime::HGUtils::PackVector4(
		              &v71,
		              (Color *)&v70,
		              -1.0 / phase->fields.fogConfig.fallOffHeight,
		              0LL);
		      v68.x = v44.m128_f32[0] / 255.0;
		      v68.y = _mm_shuffle_ps(v44, v44, 85).m128_f32[0] / 255.0;
		      v68.z = _mm_shuffle_ps(v44, v44, 170).m128_f32[0] / 255.0;
		      v68.w = _mm_shuffle_ps(v44, v44, 255).m128_f32[0] / 255.0;
		      *(__m128i *)&cb->_CharacterParams4.w = _mm_loadu_si128((const __m128i *)v61);
		      if ( hgCamera )
		      {
		        camera = (Component *)hgCamera->fields.camera;
		        if ( camera )
		        {
		          transform = UnityEngine::Component::get_transform(camera, 0LL);
		          if ( transform )
		          {
		            v63 = UnityEngine::Transform::get_position((Vector3 *)&v67, transform, 0LL)->y
		                / phase->fields.fogConfig.fallOffHeight;
		            v70 = (__m128)v68;
		            *(__m128i *)&cb->_CharacterParams5.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                      &v71,
		                                                                                      (Color *)&v70,
		                                                                                      v63,
		                                                                                      0LL));
		            v64 = phase->fields.fogConfig.startHeight / phase->fields.fogConfig.fallOffHeight;
		            v70 = (__m128)directColor;
		            *(__m128i *)&cb->_CharacterParams6.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                      &v71,
		                                                                                      (Color *)&v70,
		                                                                                      v64,
		                                                                                      0LL));
		            return;
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(camera, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1422, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(Patch, (Object *)this, cb, (Object *)hgCamera, (Object *)phase, 0LL);
		}
		
		public static void ResetShaderVariablesGlobalAtmosphereFog(ref ShaderVariablesGlobal cb) {} // 0x0000000189CDF408-0x0000000189CDF5A8
		// Void ResetShaderVariablesGlobalAtmosphereFog(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalAtmosphereFog(
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  TileBase *v3; // rdx
		  Vector3Int *v4; // r8
		  ITilemap *v5; // r9
		  MethodInfo *v6; // rdx
		  Vector3 *fwd; // rax
		  __int64 v8; // xmm6_8
		  float z; // ebx
		  MethodInfo *v10; // rdx
		  Vector3 *one; // rax
		  __int64 v12; // xmm1_8
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  __int64 v15; // xmm3_8
		  MethodInfo *v16; // rdx
		  TileBase *v17; // rdx
		  Vector3Int *v18; // r8
		  ITilemap *v19; // r9
		  MethodInfo *v20; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  Vector4 v24; // [rsp+20h] [rbp-30h] BYREF
		  Quaternion v25; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1424, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1424, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, v22);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(Patch, cb, 0LL);
		  }
		  else
		  {
		    *(__m128i *)&cb->_CharacterParams1.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                              (TileAnimationData *)&v25,
		                                                                              v3,
		                                                                              v4,
		                                                                              v5,
		                                                                              *(MethodInfo **)&v24.x));
		    fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v24, v6);
		    v8 = *(_QWORD *)&fwd->x;
		    z = fwd->z;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_QWORD *)&v24.x = v8;
		    v24.z = z;
		    *(__m128i *)&cb->_CharacterParams2.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)&v25,
		                                                                              (Vector3 *)&v24,
		                                                                              0.001,
		                                                                              0LL));
		    one = UnityEngine::Vector3::get_one((Vector3 *)&v25, v10);
		    v12 = *(_QWORD *)&one->x;
		    *(float *)&one = one->z;
		    *(_QWORD *)&v24.x = v12;
		    LODWORD(v24.z) = (_DWORD)one;
		    v14 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v25, (Vector3 *)&v24, 0.0000099999997, v13);
		    v15 = *(_QWORD *)&v14->x;
		    *(float *)&v14 = v14->z;
		    *(_QWORD *)&v24.x = v15;
		    LODWORD(v24.z) = (_DWORD)v14;
		    *(__m128i *)&cb->_CharacterParams3.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)&v25,
		                                                                              (Vector3 *)&v24,
		                                                                              0.0,
		                                                                              0LL));
		    v25 = *UnityEngine::Quaternion::get_identity(&v25, v16);
		    *(__m128i *)&cb->_CharacterParams4.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              &v24,
		                                                                              (Color *)&v25,
		                                                                              -1.0,
		                                                                              0LL));
		    *(__m128i *)&cb->_CharacterParams5.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                              (TileAnimationData *)&v25,
		                                                                              v17,
		                                                                              v18,
		                                                                              v19,
		                                                                              *(MethodInfo **)&v24.x));
		    v25 = *UnityEngine::Quaternion::get_identity(&v25, v20);
		    *(__m128i *)&cb->_CharacterParams6.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              &v24,
		                                                                              (Color *)&v25,
		                                                                              -65535.0,
		                                                                              0LL));
		  }
		}
		
		public void SetupShaderVariablesGlobalHeightFog(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189CE051C-0x0000000189CE0B40
		// Void SetupShaderVariablesGlobalHeightFog(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalHeightFog(
		        HGAtmosphereRenderer *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v8; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  HGEnvironmentPhase *v10; // rbx
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rdi
		  BOOL v12; // r14d
		  HGRenderPipelineSettingHub *instance; // rax
		  bool v14; // r15
		  float v15; // xmm8_4
		  float v16; // xmm7_4
		  float v17; // xmm6_4
		  float v18; // xmm2_4
		  MethodInfo *v19; // rdx
		  Vector3 *v20; // rax
		  Quaternion v21; // xmm0
		  __int64 v22; // xmm3_8
		  Vector3 *v23; // rax
		  float v24; // xmm2_4
		  __m128i v25; // xmm7
		  float v26; // xmm6_4
		  float v27; // eax
		  float v28; // xmm2_4
		  MethodInfo *v29; // r9
		  Vector3 *v30; // rax
		  __int64 v31; // xmm3_8
		  float v32; // xmm8_4
		  float flowNoiseTilling; // xmm2_4
		  float flowNoiseIntensity; // xmm1_4
		  float heightFogStartHeight; // xmm8_4
		  float heightFogDensity; // xmm7_4
		  float heightFogFalloff; // xmm6_4
		  float v38; // xmm2_4
		  MethodInfo *v39; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationHeightFogDirectionalInscattering; // xmm0
		  __int64 v42; // xmm3_8
		  Vector3 *v43; // rax
		  float heightFogDirectionalInscatteringStartDistance; // xmm2_4
		  __m128i v45; // xmm7
		  float heightFogDirectionalInscatteringExponent; // xmm6_4
		  float z; // eax
		  float flowNoiseSpeed; // xmm2_4
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm3_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v53; // [rsp+38h] [rbp-29h] BYREF
		  Color heightFogInscatter; // [rsp+48h] [rbp-19h] BYREF
		  Quaternion v55[5]; // [rsp+58h] [rbp-9h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1425, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1425, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		      return;
		    }
		    goto LABEL_22;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  v10 = InterpolatedPhase;
		  if ( !InterpolatedPhase )
		    goto LABEL_22;
		  p_volumetricFogConfig = &InterpolatedPhase->fields.volumetricFogConfig;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		  if ( HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(p_volumetricFogConfig, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		    if ( !s_settingParameters )
		      goto LABEL_22;
		    v12 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            s_settingParameters->fields.enableVolumetricFog,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  }
		  else
		  {
		    v12 = 0;
		  }
		  instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		LABEL_22:
		    sub_1800D8260(s_settingParameters, v8);
		  v14 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Handheld
		     && UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE, 0LL);
		  if ( v12 )
		  {
		    heightFogStartHeight = p_volumetricFogConfig->heightFogStartHeight;
		    heightFogDensity = p_volumetricFogConfig->heightFogDensity;
		    heightFogFalloff = p_volumetricFogConfig->heightFogFalloff;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(__m128i *)&cb->_CharacterParams7.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)v55,
		                                                                              heightFogStartHeight,
		                                                                              heightFogDensity * 0.1,
		                                                                              heightFogFalloff * 0.1,
		                                                                              0LL));
		    *(__m128i *)&cb->_CharacterParams8.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)v55,
		                                                                              p_volumetricFogConfig->heightFogStartTransition
		                                                                            * p_volumetricFogConfig->heightFogStartDistance,
		                                                                              -p_volumetricFogConfig->heightFogStartTransition,
		                                                                              (float)-p_volumetricFogConfig->heightFogCutoffDistance
		                                                                            * p_volumetricFogConfig->heightFogCutoffTransition,
		                                                                              p_volumetricFogConfig->heightFogCutoffTransition,
		                                                                              0LL));
		    v38 = 1.0 - p_volumetricFogConfig->heightFogMaxOpacity;
		    v55[0] = (Quaternion)p_volumetricFogConfig->heightFogInscatter;
		    *(__m128i *)&cb->_CharacterParams9.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)&heightFogInscatter,
		                                                                              (Color *)v55,
		                                                                              v38,
		                                                                              0LL));
		    *(__m128i *)&cb->_CharacterParams10.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)v55,
		                                                                               p_volumetricFogConfig->heightFogFalloffSecond
		                                                                             * 0.1,
		                                                                               p_volumetricFogConfig->heightFogDensitySecond
		                                                                             * 0.1,
		                                                                               p_volumetricFogConfig->heightFogStartHeightSecond,
		                                                                               0LL));
		    fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&heightFogInscatter, v39);
		    rotationHeightFogDirectionalInscattering = v10->fields.lightConfig.rotationHeightFogDirectionalInscattering;
		    v42 = *(_QWORD *)&fwd->x;
		    *(float *)&fwd = fwd->z;
		    *(_QWORD *)&v53.x = v42;
		    LODWORD(v53.z) = (_DWORD)fwd;
		    v55[0] = rotationHeightFogDirectionalInscattering;
		    v43 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&heightFogInscatter, v55, &v53, 0LL);
		    heightFogDirectionalInscatteringStartDistance = p_volumetricFogConfig->heightFogDirectionalInscatteringStartDistance;
		    *(_QWORD *)&rotationHeightFogDirectionalInscattering.x = *(_QWORD *)&v43->x;
		    *(float *)&v43 = v43->z;
		    *(_QWORD *)&v53.x = *(_QWORD *)&rotationHeightFogDirectionalInscattering.x;
		    LODWORD(v53.z) = (_DWORD)v43;
		    *(__m128i *)&cb->_CharacterParams11.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)v55,
		                                                                               &v53,
		                                                                               heightFogDirectionalInscatteringStartDistance,
		                                                                               0LL));
		    if ( v14 )
		    {
		      v45 = _mm_loadu_si128((const __m128i *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile);
		      heightFogDirectionalInscatteringExponent = p_volumetricFogConfig->heightFogDirectionalInscatteringExponentMobile
		                                               * 0.2;
		    }
		    else
		    {
		      v45 = _mm_loadu_si128((const __m128i *)&p_volumetricFogConfig->heightFogDirectionalInscattering);
		      heightFogDirectionalInscatteringExponent = p_volumetricFogConfig->heightFogDirectionalInscatteringExponent;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v55[0] = (Quaternion)v45;
		    *(__m128i *)&cb->_CharacterParams12.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)&heightFogInscatter,
		                                                                               (Color *)v55,
		                                                                               heightFogDirectionalInscatteringExponent,
		                                                                               0LL));
		    z = p_volumetricFogConfig->flowNoiseDir.z;
		    flowNoiseSpeed = p_volumetricFogConfig->flowNoiseSpeed;
		    *(_QWORD *)&v53.x = *(_QWORD *)&p_volumetricFogConfig->flowNoiseDir.x;
		    v53.z = z;
		    v50 = UnityEngine::Vector3::op_Multiply((Vector3 *)&heightFogInscatter, &v53, flowNoiseSpeed, v49);
		    v51 = *(_QWORD *)&v50->x;
		    *(float *)&v50 = v50->z;
		    *(_QWORD *)&v53.x = v51;
		    LODWORD(v53.z) = (_DWORD)v50;
		    *(__m128i *)&cb->_TerrainDeformParams0.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                  (Vector4 *)v55,
		                                                                                  &v53,
		                                                                                  0LL));
		    v32 = 1.0 / p_volumetricFogConfig->flowNoiseDistance;
		    flowNoiseTilling = p_volumetricFogConfig->flowNoiseTilling;
		    flowNoiseIntensity = p_volumetricFogConfig->flowNoiseIntensity;
		  }
		  else
		  {
		    v15 = v10->fields.heightFogConfig.heightFogStartHeight;
		    v16 = v10->fields.heightFogConfig.heightFogDensity;
		    v17 = v10->fields.heightFogConfig.heightFogFalloff;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(__m128i *)&cb->_CharacterParams7.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)v55,
		                                                                              v15,
		                                                                              v16 * 0.1,
		                                                                              v17 * 0.1,
		                                                                              0LL));
		    *(__m128i *)&cb->_CharacterParams8.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)v55,
		                                                                              v10->fields.heightFogConfig.heightFogStartTransition
		                                                                            * v10->fields.heightFogConfig.heightFogStartDistance,
		                                                                              -v10->fields.heightFogConfig.heightFogStartTransition,
		                                                                              (float)-v10->fields.heightFogConfig.heightFogCutoffDistance
		                                                                            * v10->fields.heightFogConfig.heightFogCutoffTransition,
		                                                                              v10->fields.heightFogConfig.heightFogCutoffTransition,
		                                                                              0LL));
		    v18 = 1.0 - v10->fields.heightFogConfig.heightFogMaxOpacity;
		    heightFogInscatter = v10->fields.heightFogConfig.heightFogInscatter;
		    *(__m128i *)&cb->_CharacterParams9.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              (Vector4 *)v55,
		                                                                              &heightFogInscatter,
		                                                                              v18,
		                                                                              0LL));
		    *(__m128i *)&cb->_CharacterParams10.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)v55,
		                                                                               v10->fields.heightFogConfig.heightFogFalloffSecond
		                                                                             * 0.1,
		                                                                               v10->fields.heightFogConfig.heightFogDensitySecond
		                                                                             * 0.1,
		                                                                               v10->fields.heightFogConfig.heightFogStartHeightSecond,
		                                                                               0LL));
		    v20 = UnityEngine::Vector3::get_fwd((Vector3 *)&heightFogInscatter, v19);
		    v21 = v10->fields.lightConfig.rotationHeightFogDirectionalInscattering;
		    v22 = *(_QWORD *)&v20->x;
		    *(float *)&v20 = v20->z;
		    *(_QWORD *)&v53.x = v22;
		    LODWORD(v53.z) = (_DWORD)v20;
		    v55[0] = v21;
		    v23 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&heightFogInscatter, v55, &v53, 0LL);
		    v24 = v10->fields.heightFogConfig.heightFogDirectionalInscatteringStartDistance;
		    *(_QWORD *)&v21.x = *(_QWORD *)&v23->x;
		    *(float *)&v23 = v23->z;
		    *(_QWORD *)&v53.x = *(_QWORD *)&v21.x;
		    LODWORD(v53.z) = (_DWORD)v23;
		    *(__m128i *)&cb->_CharacterParams11.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)v55,
		                                                                               &v53,
		                                                                               v24,
		                                                                               0LL));
		    if ( v14 )
		    {
		      v25 = _mm_loadu_si128((const __m128i *)&v10->fields.heightFogConfig.heightFogDirectionalInscatteringMobile);
		      v26 = v10->fields.heightFogConfig.heightFogDirectionalInscatteringExponentMobile * 0.2;
		    }
		    else
		    {
		      v25 = _mm_loadu_si128((const __m128i *)&v10->fields.heightFogConfig.heightFogDirectionalInscattering);
		      v26 = v10->fields.heightFogConfig.heightFogDirectionalInscatteringExponent;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v55[0] = (Quaternion)v25;
		    *(__m128i *)&cb->_CharacterParams12.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                               (Vector4 *)&heightFogInscatter,
		                                                                               (Color *)v55,
		                                                                               v26,
		                                                                               0LL));
		    v27 = v10->fields.heightFogConfig.flowNoiseDir.z;
		    v28 = v10->fields.heightFogConfig.flowNoiseSpeed;
		    *(_QWORD *)&v53.x = *(_QWORD *)&v10->fields.heightFogConfig.flowNoiseDir.x;
		    v53.z = v27;
		    v30 = UnityEngine::Vector3::op_Multiply((Vector3 *)&heightFogInscatter, &v53, v28, v29);
		    v31 = *(_QWORD *)&v30->x;
		    *(float *)&v30 = v30->z;
		    *(_QWORD *)&v53.x = v31;
		    LODWORD(v53.z) = (_DWORD)v30;
		    *(__m128i *)&cb->_TerrainDeformParams0.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                  (Vector4 *)v55,
		                                                                                  &v53,
		                                                                                  0LL));
		    v32 = 1.0 / v10->fields.heightFogConfig.flowNoiseDistance;
		    flowNoiseTilling = v10->fields.heightFogConfig.flowNoiseTilling;
		    flowNoiseIntensity = v10->fields.heightFogConfig.flowNoiseIntensity;
		  }
		  *(__m128i *)&cb->_TerrainDeformParams1.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                (Vector4 *)v55,
		                                                                                flowNoiseIntensity,
		                                                                                flowNoiseTilling,
		                                                                                v32,
		                                                                                0LL));
		}
		
		public static void ResetShaderVariablesGlobalHeightFog(ref ShaderVariablesGlobal cb) {} // 0x0000000189CDF664-0x0000000189CDF78C
		// Void ResetShaderVariablesGlobalHeightFog(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalHeightFog(
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  TileBase *v3; // rdx
		  Vector3Int *v4; // r8
		  ITilemap *v5; // r9
		  TileBase *v6; // rdx
		  Vector3Int *v7; // r8
		  ITilemap *v8; // r9
		  MethodInfo *v9; // rdx
		  __m128i v10; // xmm6
		  TileBase *v11; // rdx
		  Vector3Int *v12; // r8
		  ITilemap *v13; // r9
		  __m128i v14; // xmm1
		  TileBase *v15; // rdx
		  Vector3Int *v16; // r8
		  ITilemap *v17; // r9
		  TileBase *v18; // rdx
		  Vector3Int *v19; // r8
		  ITilemap *v20; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __m128i v24; // [rsp+20h] [rbp-38h] BYREF
		  Vector4 v25; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1427, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1427, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, v22);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(Patch, cb, 0LL);
		  }
		  else
		  {
		    *(__m128i *)&cb->_CharacterParams7.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                              (TileAnimationData *)&v24,
		                                                                              v3,
		                                                                              v4,
		                                                                              v5,
		                                                                              (MethodInfo *)v24.m128i_i64[0]));
		    *(__m128i *)&cb->_CharacterParams8.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                              (TileAnimationData *)&v24,
		                                                                              v6,
		                                                                              v7,
		                                                                              v8,
		                                                                              (MethodInfo *)v24.m128i_i64[0]));
		    v10 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&v24, v9));
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v24 = v10;
		    *(__m128i *)&cb->_CharacterParams9.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                              &v25,
		                                                                              (Color *)&v24,
		                                                                              1.0,
		                                                                              0LL));
		    v14 = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                             (TileAnimationData *)&v25,
		                                             v11,
		                                             v12,
		                                             v13,
		                                             (MethodInfo *)v24.m128i_i64[0]));
		    *(__m128i *)&cb->_CharacterParams11.w = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		    *(__m128i *)&cb->_CharacterParams10.w = v14;
		    *(__m128i *)&cb->_CharacterParams12.w = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		    *(__m128i *)&cb->_TerrainDeformParams0.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                                  (TileAnimationData *)&v25,
		                                                                                  v15,
		                                                                                  v16,
		                                                                                  v17,
		                                                                                  (MethodInfo *)v24.m128i_i64[0]));
		    *(__m128i *)&cb->_TerrainDeformParams1.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                                  (TileAnimationData *)&v25,
		                                                                                  v18,
		                                                                                  v19,
		                                                                                  v20,
		                                                                                  (MethodInfo *)v24.m128i_i64[0]));
		  }
		}
		
		public static void SetupRenderHeightFogFlowNoiseParam(HGEnvironmentPhase phase, Material mat) {} // 0x0000000189CDF91C-0x0000000189CDFA98
		// Void SetupRenderHeightFogFlowNoiseParam(HGEnvironmentPhase, Material)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::SetupRenderHeightFogFlowNoiseParam(
		        HGEnvironmentPhase *phase,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  bool flowNoiseEnabled; // al
		  int32_t HeightFogNoise3DTex; // ebx
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_TextureResources *textures; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1428, 0LL) )
		  {
		    if ( !phase )
		      goto LABEL_16;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(
		            &phase->fields.volumetricFogConfig,
		            0LL) )
		      goto LABEL_7;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		    if ( !s_settingParameters )
		      goto LABEL_16;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           s_settingParameters->fields.enableVolumetricFog,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		      flowNoiseEnabled = HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowNoiseEnabled(
		                           &phase->fields.volumetricFogConfig,
		                           0LL);
		    }
		    else
		    {
		LABEL_7:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
		      flowNoiseEnabled = HG::Rendering::Runtime::HGHeightFogConfig::get_flowNoiseEnabled(
		                           &phase->fields.heightFogConfig,
		                           0LL);
		    }
		    if ( mat )
		    {
		      if ( !flowNoiseEnabled )
		      {
		        UnityEngine::Material::DisableKeyword(mat, (String *)"_HEIGHT_FOG_FLOW_NOISE", 0LL);
		        return;
		      }
		      UnityEngine::Material::EnableKeyword(mat, (String *)"_HEIGHT_FOG_FLOW_NOISE", 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      HeightFogNoise3DTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HeightFogNoise3DTex;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( currentPipeline )
		      {
		        defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		        if ( defaultResources )
		        {
		          textures = defaultResources->fields.textures;
		          if ( textures )
		          {
		            UnityEngine::Material::SetTextureImpl(
		              mat,
		              HeightFogNoise3DTex,
		              (Texture *)textures->fields.HeightFogNoise3DTex,
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(s_settingParameters, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1428, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)phase,
		    (Object *)mat,
		    0LL);
		}
		
		private bool ShouldRenderAtmosphereLut(HGCamera hgCamera, ref AtmosphereLutConstants atmosphereLutConstants, HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CE0BAC-0x0000000189CE0D14
		// Boolean ShouldRenderAtmosphereLut(HGCamera, HGAtmosphereRenderer+AtmosphereLutConstants ByRef, HGAtmosphereSettingParameters)
		bool HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLut(
		        HGAtmosphereRenderer *this,
		        HGCamera *hgCamera,
		        HGAtmosphereRenderer_AtmosphereLutConstants *atmosphereLutConstants,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  RenderTexture *atmosphereSkyViewLutTexture; // rdx
		  RenderTexture *static_fields; // rcx
		  RenderTextureFormat__Enum format; // ebx
		  int v12; // ebx
		  int v13; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1429, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    static_fields = (RenderTexture *)TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields;
		    if ( BYTE4(static_fields->klass) )
		      return 1;
		    if ( !hgCamera )
		      goto LABEL_14;
		    if ( Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCmp(
		           (Void *)atmosphereLutConstants,
		           (Void *)&hgCamera->fields.atmosphereLutConstants,
		           192LL,
		           0LL) )
		    {
		      return 1;
		    }
		    static_fields = hgCamera->fields.atmosphereSkyViewLutTexture;
		    if ( !static_fields )
		      goto LABEL_14;
		    format = UnityEngine::RenderTexture::get_format(static_fields, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    if ( format != HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureFormat(
		                     atmosphereParams,
		                     0LL) )
		      return 1;
		    atmosphereSkyViewLutTexture = hgCamera->fields.atmosphereSkyViewLutTexture;
		    if ( !atmosphereSkyViewLutTexture )
		      goto LABEL_14;
		    v12 = sub_180002F70(5LL, atmosphereSkyViewLutTexture);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    if ( v12 != HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutWidth(atmosphereParams, 0LL) )
		      return 1;
		    atmosphereSkyViewLutTexture = hgCamera->fields.atmosphereSkyViewLutTexture;
		    if ( atmosphereSkyViewLutTexture )
		    {
		      v13 = sub_180002F70(7LL, atmosphereSkyViewLutTexture);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      return v13 != HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutHeight(atmosphereParams, 0LL);
		    }
		LABEL_14:
		    sub_1800D8260(static_fields, atmosphereSkyViewLutTexture);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1429, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_587(
		           Patch,
		           (Object *)this,
		           (Object *)hgCamera,
		           atmosphereLutConstants,
		           (Object *)atmosphereParams,
		           0LL);
		}
		
		public void RenderAtmosphereLut(CommandBuffer cmd, ScriptableRenderContext renderContext, HGCamera hgCamera, HGEnvironmentPhase phase, Material mat, ComputeShader cs, HGRenderGraph renderGraph, long impl, HGAtmosphereSettingParameters atmosphereParams) {} // 0x0000000189CDE6A8-0x0000000189CDF35C
		// Void RenderAtmosphereLut(CommandBuffer, ScriptableRenderContext, HGCamera, HGEnvironmentPhase, Material, ComputeShader, HGRenderGraph, Int64, HGAtmosphereSettingParameters)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::RenderAtmosphereLut(
		        HGAtmosphereRenderer *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        HGCamera *hgCamera,
		        HGEnvironmentPhase *phase,
		        Material *mat,
		        ComputeShader *cs,
		        HGRenderGraph *renderGraph,
		        int64_t impl,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  SingleFieldAccessor__Class *klass; // rdx
		  void *Patch; // rcx
		  HGEnvironmentPhase *v16; // rbx
		  float groundRadius; // xmm11_4
		  float v18; // xmm7_4
		  HGAtmosphereSettingParameters *v19; // r14
		  float v20; // xmm8_4
		  float v21; // xmm9_4
		  Transform *transform; // rax
		  float y; // xmm6_4
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  float v26; // xmm0_4
		  Vector4 v27; // xmm0
		  Vector3 *v28; // rax
		  float directIntensity; // xmm2_4
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  float multiScatteringFactor; // xmm2_4
		  __int64 v33; // xmm3_8
		  Vector4 v34; // xmm0
		  Vector3 *v35; // rax
		  float rayleighScatteringScale; // xmm2_4
		  MethodInfo *v37; // r9
		  Vector3 *v38; // rax
		  float v39; // xmm2_4
		  __int64 v40; // xmm3_8
		  Vector4 v41; // xmm0
		  Vector3 *v42; // rax
		  float mieScatteringScale; // xmm2_4
		  MethodInfo *v44; // r9
		  Vector3 *v45; // rax
		  float mieAnisotropy; // xmm2_4
		  __int64 v47; // xmm3_8
		  Vector4 v48; // xmm0
		  Vector3 *v49; // rax
		  float mieAbsorptionScale; // xmm2_4
		  MethodInfo *v51; // r9
		  Vector3 *v52; // rax
		  float v53; // xmm6_4
		  __int64 v54; // xmm3_8
		  Vector4 v55; // xmm0
		  Vector3 *v56; // rax
		  float ozoneAbsorptionScale; // xmm2_4
		  MethodInfo *v58; // r9
		  Vector3 *v59; // rax
		  __int64 v60; // xmm3_8
		  Vector3 *v61; // rax
		  float proceduralSkyLuxFactor; // xmm2_4
		  MethodInfo *v63; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationAtmosphere; // xmm0
		  __int64 v66; // xmm3_8
		  Vector3 *v67; // rax
		  MethodInfo *v68; // r8
		  Vector3 *v69; // rax
		  __int64 v70; // xmm6_8
		  float z; // ebx
		  Vector4 *v72; // rax
		  SettingParameter_1_System_Int32Enum_ *transmittanceLutWidth; // rcx
		  Int32Enum__Enum v74; // esi
		  Int32Enum__Enum v75; // edi
		  Int32Enum__Enum v76; // ebx
		  Int32Enum__Enum v77; // eax
		  Vector4 *v78; // rax
		  SettingParameter_1_System_Int32Enum_ *skyViewLutWidth; // rcx
		  Int32Enum__Enum v80; // ebx
		  Int32Enum__Enum v81; // eax
		  Vector4 AtmosphereLutParams1; // xmm1
		  Vector4 AtmosphereLutParams2; // xmm0
		  Vector4 AtmosphereLutParams3; // xmm1
		  Vector4 AtmosphereLutParams4; // xmm0
		  Vector4 AtmosphereLutParams5; // xmm1
		  Vector4 AtmosphereLutParams6; // xmm0
		  Vector4 AtmosphereLutParams7; // xmm1
		  Vector4 AtmosphereLutParams8; // xmm0
		  Vector4 AtmosphereLutParams9; // xmm1
		  Vector4 AtmosphereLutParams10; // xmm0
		  Vector4 AtmosphereLutParams11; // xmm1
		  CBHandle *v93; // rax
		  __m128i v94; // xmm6
		  bool ShouldRenderAtmosphereLutUsingCompute; // al
		  Material *v96; // rbx
		  int32_t v97; // edi
		  int32_t SkyViewLutHeight; // eax
		  SingleFieldAccessor *p_atmosphereSkyViewLutTexture; // rsi
		  Object_1 *atmosphereSkyViewLutTexture; // rbx
		  int32_t v101; // r13d
		  RenderTextureFormat__Enum format; // ebx
		  RenderTextureDescriptor *AtmosphereLutRenderTextureDesc; // rax
		  __int128 v104; // xmm1
		  __int128 v105; // xmm0
		  Type *v106; // rdx
		  PropertyInfo_1 *v107; // r8
		  Int32__Array **v108; // r9
		  Int32Enum__Enum v109; // edi
		  Int32Enum__Enum v110; // ebx
		  RenderTextureDescriptor *v111; // rax
		  __int128 v112; // xmm1
		  __int128 v113; // xmm0
		  RenderTexture *Temporary; // rax
		  Int32Enum__Enum v115; // ebx
		  Int32Enum__Enum v116; // eax
		  RenderTextureDescriptor *v117; // rax
		  __int128 v118; // xmm1
		  __int128 v119; // xmm0
		  RenderTexture *v120; // rax
		  bool v121; // al
		  RenderTexture *v122; // r9
		  MethodInfo *linTerm0; // [rsp+28h] [rbp-E0h]
		  Color outerSunIrradianceColor; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v125; // [rsp+78h] [rbp-90h] BYREF
		  float layerWidth; // [rsp+88h] [rbp-80h] BYREF
		  float constTerm1; // [rsp+8Ch] [rbp-7Ch] BYREF
		  float constTerm0; // [rsp+90h] [rbp-78h] BYREF
		  float linTerm1; // [rsp+94h] [rbp-74h] BYREF
		  float v130[4]; // [rsp+98h] [rbp-70h] BYREF
		  CBHandle v131; // [rsp+A8h] [rbp-60h] BYREF
		  RenderTexture *transmittanceLut; // [rsp+C8h] [rbp-40h] BYREF
		  RenderTexture *multiScatteredLuminanceLut; // [rsp+D0h] [rbp-38h] BYREF
		  RenderTextureDescriptor v134; // [rsp+D8h] [rbp-30h] BYREF
		  RenderTextureDescriptor v135; // [rsp+118h] [rbp+10h] BYREF
		  HGAtmosphereRenderer_AtmosphereLutConstants v136; // [rsp+158h] [rbp+50h] BYREF
		  HGAtmosphereRenderer_AtmosphereLutConstants atmosphereLutConstants; // [rsp+218h] [rbp+110h] BYREF
		  ScriptableRenderContext P2; // [rsp+388h] [rbp+280h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  layerWidth = 0.0;
		  v130[0] = 0.0;
		  linTerm1 = 0.0;
		  constTerm0 = 0.0;
		  constTerm1 = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1431, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1431, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_592(
		        (ILFixDynamicMethodWrapper_2 *)Patch,
		        (Object *)this,
		        (Object *)cmd,
		        P2,
		        (Object *)hgCamera,
		        (Object *)phase,
		        (Object *)mat,
		        (Object *)cs,
		        (Object *)renderGraph,
		        impl,
		        (Object *)atmosphereParams,
		        0LL);
		      return;
		    }
		    goto LABEL_33;
		  }
		  v16 = phase;
		  if ( !phase )
		    goto LABEL_33;
		  groundRadius = phase->fields.atmosphereConfig.groundRadius;
		  v18 = fmaxf(0.1, phase->fields.atmosphereConfig.atmosphereHeight) + groundRadius;
		  HG::Rendering::Runtime::HGEnvironmentUtils::TentToCoefficients(
		    phase->fields.atmosphereConfig.tentTipAltitude,
		    phase->fields.atmosphereConfig.tentTipValue,
		    phase->fields.atmosphereConfig.tentWidth,
		    &layerWidth,
		    v130,
		    &linTerm1,
		    &constTerm0,
		    &constTerm1,
		    0LL);
		  v19 = atmosphereParams;
		  if ( !atmosphereParams )
		    goto LABEL_33;
		  v20 = fmaxf(
		          HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		            atmosphereParams->fields.skyViewLutSampleCountMin,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit),
		          1.0);
		  v21 = fmaxf(
		          HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		            v19->fields.skyViewLutSampleCountMax,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit),
		          v20);
		  sub_18033B9D0(&v136, 0LL, 192LL);
		  if ( !hgCamera )
		    goto LABEL_33;
		  Patch = hgCamera->fields.camera;
		  if ( !Patch )
		    goto LABEL_33;
		  transform = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		  if ( !transform )
		    goto LABEL_33;
		  y = UnityEngine::Transform::get_position((Vector3 *)&outerSunIrradianceColor, transform, 0LL)->y;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v26 = sub_1803386C0(v25, v24);
		  v27 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		           (Vector4 *)&v131,
		           v18,
		           groundRadius,
		           v26,
		           (float)(y * 0.001) + groundRadius,
		           0LL);
		  outerSunIrradianceColor = v16->fields.atmosphereConfig.outerSunIrradianceColor;
		  v136._AtmosphereLutParams0 = v27;
		  v28 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  directIntensity = v16->fields.lightConfig.directIntensity;
		  *(_QWORD *)&v27.x = *(_QWORD *)&v28->x;
		  *(float *)&v28 = v28->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v27.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v28;
		  v31 = UnityEngine::Vector3::op_Multiply(&v125, (Vector3 *)&outerSunIrradianceColor, directIntensity, v30);
		  multiScatteringFactor = v16->fields.atmosphereConfig.multiScatteringFactor;
		  v33 = *(_QWORD *)&v31->x;
		  *(float *)&v31 = v31->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v33;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v31;
		  v34 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		           (Vector4 *)&v131,
		           (Vector3 *)&outerSunIrradianceColor,
		           multiScatteringFactor,
		           0LL);
		  outerSunIrradianceColor = v16->fields.atmosphereConfig.rayleighScattering;
		  v136._AtmosphereLutParams1 = v34;
		  v35 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  rayleighScatteringScale = v16->fields.atmosphereConfig.rayleighScatteringScale;
		  *(_QWORD *)&v34.x = *(_QWORD *)&v35->x;
		  *(float *)&v35 = v35->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v34.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v35;
		  v38 = UnityEngine::Vector3::op_Multiply(&v125, (Vector3 *)&outerSunIrradianceColor, rayleighScatteringScale, v37);
		  v39 = -1.0 / v16->fields.atmosphereConfig.rayleighExponentialDistribution;
		  v40 = *(_QWORD *)&v38->x;
		  *(float *)&v38 = v38->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v40;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v38;
		  v41 = *HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&v131, (Vector3 *)&outerSunIrradianceColor, v39, 0LL);
		  outerSunIrradianceColor = v16->fields.atmosphereConfig.mieScattering;
		  v136._AtmosphereLutParams2 = v41;
		  v42 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  mieScatteringScale = v16->fields.atmosphereConfig.mieScatteringScale;
		  *(_QWORD *)&v41.x = *(_QWORD *)&v42->x;
		  *(float *)&v42 = v42->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v41.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v42;
		  v45 = UnityEngine::Vector3::op_Multiply(&v125, (Vector3 *)&outerSunIrradianceColor, mieScatteringScale, v44);
		  mieAnisotropy = v16->fields.atmosphereConfig.mieAnisotropy;
		  v47 = *(_QWORD *)&v45->x;
		  *(float *)&v45 = v45->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v47;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v45;
		  v48 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		           (Vector4 *)&v131,
		           (Vector3 *)&outerSunIrradianceColor,
		           mieAnisotropy,
		           0LL);
		  outerSunIrradianceColor = v16->fields.atmosphereConfig.mieAbsorption;
		  v136._AtmosphereLutParams3 = v48;
		  v49 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  mieAbsorptionScale = v16->fields.atmosphereConfig.mieAbsorptionScale;
		  *(_QWORD *)&v48.x = *(_QWORD *)&v49->x;
		  *(float *)&v49 = v49->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v48.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v49;
		  v52 = UnityEngine::Vector3::op_Multiply(&v125, (Vector3 *)&outerSunIrradianceColor, mieAbsorptionScale, v51);
		  v53 = -1.0 / v16->fields.atmosphereConfig.mieExponentialDistribution;
		  v54 = *(_QWORD *)&v52->x;
		  *(float *)&v52 = v52->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v54;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v52;
		  v55 = *HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&v131, (Vector3 *)&outerSunIrradianceColor, v53, 0LL);
		  outerSunIrradianceColor = v16->fields.atmosphereConfig.ozoneAbsorption;
		  v136._AtmosphereLutParams4 = v55;
		  v56 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  ozoneAbsorptionScale = v16->fields.atmosphereConfig.ozoneAbsorptionScale;
		  *(_QWORD *)&v55.x = *(_QWORD *)&v56->x;
		  *(float *)&v56 = v56->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v55.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v56;
		  v59 = UnityEngine::Vector3::op_Multiply(&v125, (Vector3 *)&outerSunIrradianceColor, ozoneAbsorptionScale, v58);
		  v60 = *(_QWORD *)&v59->x;
		  *(float *)&v59 = v59->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v60;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v59;
		  v136._AtmosphereLutParams5 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)&v131,
		                                  (Vector3 *)&outerSunIrradianceColor,
		                                  layerWidth,
		                                  0LL);
		  v136._AtmosphereLutParams6 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)&v131,
		                                  v130[0],
		                                  linTerm1,
		                                  constTerm0,
		                                  constTerm1,
		                                  0LL);
		  outerSunIrradianceColor = *(Color *)sub_183C6CBA0(&v131, &v16->fields.atmosphereConfig.groundAlbedo);
		  v61 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v125, &outerSunIrradianceColor, 0LL);
		  proceduralSkyLuxFactor = v16->fields.skyConfig.proceduralSkyLuxFactor;
		  *(_QWORD *)&v55.x = *(_QWORD *)&v61->x;
		  *(float *)&v61 = v61->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&v55.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v61;
		  v136._AtmosphereLutParams7 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)&v131,
		                                  (Vector3 *)&outerSunIrradianceColor,
		                                  proceduralSkyLuxFactor,
		                                  0LL);
		  fwd = UnityEngine::Vector3::get_fwd(&v125, v63);
		  rotationAtmosphere = v16->fields.lightConfig.rotationAtmosphere;
		  v66 = *(_QWORD *)&fwd->x;
		  *(float *)&fwd = fwd->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = v66;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)fwd;
		  *(Quaternion *)&v131.bufferId = rotationAtmosphere;
		  v67 = UnityEngine::Quaternion::op_Multiply(&v125, (Quaternion *)&v131, (Vector3 *)&outerSunIrradianceColor, 0LL);
		  *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v67->x;
		  *(float *)&v67 = v67->z;
		  *(_QWORD *)&outerSunIrradianceColor.r = *(_QWORD *)&rotationAtmosphere.x;
		  LODWORD(outerSunIrradianceColor.b) = (_DWORD)v67;
		  v69 = UnityEngine::Vector3::op_UnaryNegation(&v125, (Vector3 *)&outerSunIrradianceColor, v68);
		  v70 = *(_QWORD *)&v69->x;
		  z = v69->z;
		  rotationAtmosphere.x = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                           v19->fields.transmittanceLutSampleCount,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  *(_QWORD *)&outerSunIrradianceColor.r = v70;
		  outerSunIrradianceColor.b = z;
		  v136._AtmosphereLutParams8 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)&v131,
		                                  (Vector3 *)&outerSunIrradianceColor,
		                                  fmaxf(rotationAtmosphere.x, 1.0),
		                                  0LL);
		  *(float *)&v70 = fmaxf(
		                     HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                       v19->fields.multiScatteredLuminanceLutSampleCount,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit),
		                     1.0);
		  rotationAtmosphere.x = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                           v19->fields.skyViewLutDistanceToSampleCountMax,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v72 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          (Vector4 *)&v131,
		          *(float *)&v70,
		          v20,
		          v21,
		          fmaxf(rotationAtmosphere.x, 1.0),
		          0LL);
		  transmittanceLutWidth = (SettingParameter_1_System_Int32Enum_ *)v19->fields.transmittanceLutWidth;
		  v136._AtmosphereLutParams9 = *v72;
		  v74 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          transmittanceLutWidth,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v75 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)v19->fields.transmittanceLutHeight,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v76 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)v19->fields.multiScatteredLuminanceLutWidth,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v77 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)v19->fields.multiScatteredLuminanceLutHeight,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v78 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          (Vector4 *)&v131,
		          1.0 / (float)(int)v74,
		          1.0 / (float)(int)v75,
		          1.0 / (float)(int)v76,
		          1.0 / (float)(int)v77,
		          0LL);
		  skyViewLutWidth = (SettingParameter_1_System_Int32Enum_ *)v19->fields.skyViewLutWidth;
		  v136._AtmosphereLutParams10 = *v78;
		  v80 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          skyViewLutWidth,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v81 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)v19->fields.skyViewLutHeight,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v136._AtmosphereLutParams11 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                                   (Vector4 *)&v131,
		                                   1.0 / (float)(int)v80,
		                                   1.0 / (float)(int)v81,
		                                   0LL);
		  atmosphereLutConstants = v136;
		  if ( !HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLut(
		          this,
		          hgCamera,
		          &atmosphereLutConstants,
		          v19,
		          0LL) )
		    return;
		  AtmosphereLutParams1 = atmosphereLutConstants._AtmosphereLutParams1;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams0 = atmosphereLutConstants._AtmosphereLutParams0;
		  AtmosphereLutParams2 = atmosphereLutConstants._AtmosphereLutParams2;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams1 = AtmosphereLutParams1;
		  AtmosphereLutParams3 = atmosphereLutConstants._AtmosphereLutParams3;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams2 = AtmosphereLutParams2;
		  AtmosphereLutParams4 = atmosphereLutConstants._AtmosphereLutParams4;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams3 = AtmosphereLutParams3;
		  AtmosphereLutParams5 = atmosphereLutConstants._AtmosphereLutParams5;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams4 = AtmosphereLutParams4;
		  AtmosphereLutParams6 = atmosphereLutConstants._AtmosphereLutParams6;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams5 = AtmosphereLutParams5;
		  AtmosphereLutParams7 = atmosphereLutConstants._AtmosphereLutParams7;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams6 = AtmosphereLutParams6;
		  AtmosphereLutParams8 = atmosphereLutConstants._AtmosphereLutParams8;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams7 = AtmosphereLutParams7;
		  AtmosphereLutParams9 = atmosphereLutConstants._AtmosphereLutParams9;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams8 = AtmosphereLutParams8;
		  AtmosphereLutParams10 = atmosphereLutConstants._AtmosphereLutParams10;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams9 = AtmosphereLutParams9;
		  AtmosphereLutParams11 = atmosphereLutConstants._AtmosphereLutParams11;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams10 = AtmosphereLutParams10;
		  hgCamera->fields.atmosphereLutConstants._AtmosphereLutParams11 = AtmosphereLutParams11;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  v93 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v131, &P2, 192, 0LL);
		  v94 = *(__m128i *)&v93->bufferId;
		  v131.ptr = v93->ptr;
		  Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		    (Void *)v131.ptr,
		    (Void *)&atmosphereLutConstants,
		    192LL,
		    0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		  ShouldRenderAtmosphereLutUsingCompute = HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(
		                                            v19,
		                                            0LL);
		  v96 = mat;
		  if ( ShouldRenderAtmosphereLutUsingCompute )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( !cmd )
		      goto LABEL_33;
		    UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
		      cmd,
		      cs,
		      *((_DWORD *)Patch + 260),
		      _mm_cvtsi128_si32(v94),
		      _mm_cvtsi128_si32(_mm_srli_si128(v94, 4)),
		      _mm_cvtsi128_si32(_mm_srli_si128(v94, 8)),
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( !v96 )
		      goto LABEL_33;
		    UnityEngine::Material::SetConstantBufferImpl0(
		      v96,
		      *((_DWORD *)Patch + 260),
		      _mm_cvtsi128_si32(v94),
		      _mm_cvtsi128_si32(_mm_srli_si128(v94, 4)),
		      _mm_cvtsi128_si32(_mm_srli_si128(v94, 8)),
		      0LL);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		  v97 = HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutWidth(v19, 0LL);
		  SkyViewLutHeight = HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutHeight(v19, 0LL);
		  p_atmosphereSkyViewLutTexture = (SingleFieldAccessor *)&hgCamera->fields.atmosphereSkyViewLutTexture;
		  atmosphereSkyViewLutTexture = (Object_1 *)hgCamera->fields.atmosphereSkyViewLutTexture;
		  v101 = SkyViewLutHeight;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(atmosphereSkyViewLutTexture, 0LL, 0LL) )
		  {
		LABEL_21:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    AtmosphereLutRenderTextureDesc = HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureDesc(
		                                       &v135,
		                                       v19,
		                                       v97,
		                                       v101,
		                                       0LL);
		    v104 = *(_OWORD *)&AtmosphereLutRenderTextureDesc->_mipCount_k__BackingField;
		    *(_OWORD *)&v134._width_k__BackingField = *(_OWORD *)&AtmosphereLutRenderTextureDesc->_width_k__BackingField;
		    v105 = *(_OWORD *)&AtmosphereLutRenderTextureDesc->_dimension_k__BackingField;
		    LODWORD(AtmosphereLutRenderTextureDesc) = AtmosphereLutRenderTextureDesc->_memoryless_k__BackingField;
		    *(_OWORD *)&v134._mipCount_k__BackingField = v104;
		    *(_OWORD *)&v134._dimension_k__BackingField = v105;
		    v134._memoryless_k__BackingField = (int)AtmosphereLutRenderTextureDesc;
		    p_atmosphereSkyViewLutTexture->klass = (SingleFieldAccessor__Class *)UnityEngine::RenderTexture::GetTemporary(
		                                                                           &v134,
		                                                                           0LL);
		    sub_18002D1B0(p_atmosphereSkyViewLutTexture, v106, v107, v108, linTerm0);
		    Patch = p_atmosphereSkyViewLutTexture->klass;
		    if ( p_atmosphereSkyViewLutTexture->klass )
		    {
		      UnityEngine::Object::set_name((Object_1 *)Patch, (String *)"HGAtmosphere.skyViewLut", 0LL);
		      Patch = p_atmosphereSkyViewLutTexture->klass;
		      if ( p_atmosphereSkyViewLutTexture->klass )
		      {
		        UnityEngine::RenderTexture::Create((RenderTexture *)Patch, 0LL);
		        goto LABEL_24;
		      }
		    }
		LABEL_33:
		    sub_1800D8260(Patch, klass);
		  }
		  Patch = p_atmosphereSkyViewLutTexture->klass;
		  if ( !p_atmosphereSkyViewLutTexture->klass )
		    goto LABEL_33;
		  format = UnityEngine::RenderTexture::get_format((RenderTexture *)Patch, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		  if ( format != HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureFormat(v19, 0LL) )
		    goto LABEL_20;
		  klass = p_atmosphereSkyViewLutTexture->klass;
		  if ( !p_atmosphereSkyViewLutTexture->klass )
		    goto LABEL_33;
		  if ( (unsigned int)sub_180002F70(5LL, klass) != v97 )
		    goto LABEL_20;
		  klass = p_atmosphereSkyViewLutTexture->klass;
		  if ( !p_atmosphereSkyViewLutTexture->klass )
		    goto LABEL_33;
		  if ( (unsigned int)sub_180002F70(7LL, klass) != v101 )
		  {
		LABEL_20:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture((RenderTexture **)p_atmosphereSkyViewLutTexture, 0LL);
		    goto LABEL_21;
		  }
		LABEL_24:
		  v109 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)v19->fields.transmittanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v110 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)v19->fields.transmittanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		  v111 = HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureDesc(&v135, v19, v109, v110, 0LL);
		  v112 = *(_OWORD *)&v111->_mipCount_k__BackingField;
		  *(_OWORD *)&v134._width_k__BackingField = *(_OWORD *)&v111->_width_k__BackingField;
		  v113 = *(_OWORD *)&v111->_dimension_k__BackingField;
		  LODWORD(v111) = v111->_memoryless_k__BackingField;
		  *(_OWORD *)&v134._mipCount_k__BackingField = v112;
		  *(_OWORD *)&v134._dimension_k__BackingField = v113;
		  v134._memoryless_k__BackingField = (int)v111;
		  Temporary = UnityEngine::RenderTexture::GetTemporary(&v134, 0LL);
		  transmittanceLut = Temporary;
		  if ( !Temporary )
		    goto LABEL_33;
		  UnityEngine::Object::set_name((Object_1 *)Temporary, (String *)"HGAtmosphere.transmittanceLut", 0LL);
		  Patch = transmittanceLut;
		  if ( !transmittanceLut )
		    goto LABEL_33;
		  UnityEngine::RenderTexture::Create(transmittanceLut, 0LL);
		  v115 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)v19->fields.multiScatteredLuminanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v116 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)v19->fields.multiScatteredLuminanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v117 = HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureDesc(&v135, v19, v115, v116, 0LL);
		  v118 = *(_OWORD *)&v117->_mipCount_k__BackingField;
		  *(_OWORD *)&v134._width_k__BackingField = *(_OWORD *)&v117->_width_k__BackingField;
		  v119 = *(_OWORD *)&v117->_dimension_k__BackingField;
		  LODWORD(v117) = v117->_memoryless_k__BackingField;
		  *(_OWORD *)&v134._mipCount_k__BackingField = v118;
		  *(_OWORD *)&v134._dimension_k__BackingField = v119;
		  v134._memoryless_k__BackingField = (int)v117;
		  v120 = UnityEngine::RenderTexture::GetTemporary(&v134, 0LL);
		  multiScatteredLuminanceLut = v120;
		  if ( !v120 )
		    goto LABEL_33;
		  UnityEngine::Object::set_name((Object_1 *)v120, (String *)"HGAtmosphere.multiScatteredLuminanceLut", 0LL);
		  Patch = multiScatteredLuminanceLut;
		  if ( !multiScatteredLuminanceLut )
		    goto LABEL_33;
		  UnityEngine::RenderTexture::Create(multiScatteredLuminanceLut, 0LL);
		  v121 = HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(v19, 0LL);
		  v122 = (RenderTexture *)p_atmosphereSkyViewLutTexture->klass;
		  if ( v121 )
		    HG::Rendering::Runtime::HGAtmosphereRenderer::_DispatchAtmosphereLutCS(
		      this,
		      cmd,
		      cs,
		      v122,
		      transmittanceLut,
		      multiScatteredLuminanceLut,
		      v19,
		      0LL);
		  else
		    HG::Rendering::Runtime::HGAtmosphereRenderer::_RenderAtmosphereLutPS(
		      this,
		      cmd,
		      mat,
		      v122,
		      transmittanceLut,
		      multiScatteredLuminanceLut,
		      v19,
		      0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&transmittanceLut, 0LL);
		  HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&multiScatteredLuminanceLut, 0LL);
		}
		
		public void ResetAtmosphereLut(HGCamera hgCamera) {} // 0x0000000189CDF35C-0x0000000189CDF408
		// Void ResetAtmosphereLut(HGCamera)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::ResetAtmosphereLut(
		        HGAtmosphereRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object_1 *atmosphereSkyViewLutTexture; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1437, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1437, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)hgCamera,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !hgCamera )
		    goto LABEL_6;
		  atmosphereSkyViewLutTexture = (Object_1 *)hgCamera->fields.atmosphereSkyViewLutTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(atmosphereSkyViewLutTexture, 0LL, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&hgCamera->fields.atmosphereSkyViewLutTexture, 0LL);
		    sub_18033B9D0(&hgCamera->fields.atmosphereLutConstants, 0LL, 192LL);
		  }
		}
		
		private void _RenderAtmosphereLutPS(CommandBuffer cmd, Material mat, RenderTexture skyViewLut, RenderTexture transmittanceLut, RenderTexture multiScatteredLuminanceLut, HGAtmosphereSettingParameters atmosphereParams) {} // 0x0000000189CE1320-0x0000000189CE15E4
		// Void _RenderAtmosphereLutPS(CommandBuffer, Material, RenderTexture, RenderTexture, RenderTexture, HGAtmosphereSettingParameters)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::_RenderAtmosphereLutPS(
		        HGAtmosphereRenderer *this,
		        CommandBuffer *cmd,
		        Material *mat,
		        RenderTexture *skyViewLut,
		        RenderTexture *transmittanceLut,
		        RenderTexture *multiScatteredLuminanceLut,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  RenderTargetIdentifier *v12; // rax
		  __int64 v13; // rdx
		  _DWORD *p_CB0; // rcx
		  __int128 v15; // xmm1
		  Shader *shader; // rbx
		  String *s_HighQualityMultiScatteringApproxEnabled; // r8
		  bool v18; // al
		  RenderTargetIdentifier *v19; // rax
		  __int128 v20; // xmm1
		  RenderTargetIdentifier *v21; // rax
		  __int128 v22; // xmm1
		  __int64 v23; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  RenderTargetIdentifier keyword; // [rsp+58h] [rbp-39h] BYREF
		  LocalKeyword v26; // [rsp+88h] [rbp-9h] BYREF
		  RenderTargetIdentifier v27; // [rsp+A0h] [rbp+Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1436, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1436, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v23);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(
		      (ILFixDynamicMethodWrapper_3 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      (Object *)mat,
		      (Object *)skyViewLut,
		      (Object *)transmittanceLut,
		      (Object *)multiScatteredLuminanceLut,
		      (Object *)atmosphereParams,
		      0LL);
		  }
		  else
		  {
		    v12 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v27, (Texture *)transmittanceLut, 0LL);
		    if ( !cmd )
		      goto LABEL_6;
		    v15 = *(_OWORD *)&v12->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v12->m_Type;
		    *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v12->m_DepthSlice;
		    *(_OWORD *)&keyword.m_BufferPointer = v15;
		    UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		      cmd,
		      &keyword,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, mat, 0LL, 0, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		    if ( !mat )
		      goto LABEL_6;
		    UnityEngine::Material::SetTextureImpl(mat, p_CB0[261], (Texture *)transmittanceLut, 0LL);
		    shader = UnityEngine::Material::get_shader(mat, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    s_HighQualityMultiScatteringApproxEnabled = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQualityMultiScatteringApproxEnabled;
		    memset(&v26, 0, sizeof(v26));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v26, shader, s_HighQualityMultiScatteringApproxEnabled, 0LL);
		    p_CB0 = atmosphereParams;
		    keyword.m_BufferPointer = *(void **)&v26.m_Index;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v26.m_SpaceInfo.m_KeywordSpace;
		    if ( !atmosphereParams )
		LABEL_6:
		      sub_1800D8260(p_CB0, v13);
		    v18 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            atmosphereParams->fields.multiScatteredLuminanceLutHighQuality,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, mat, (LocalKeyword *)&keyword, v18, 0LL);
		    v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v27, (Texture *)multiScatteredLuminanceLut, 0LL);
		    v20 = *(_OWORD *)&v19->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v19->m_Type;
		    *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v19->m_DepthSlice;
		    *(_OWORD *)&keyword.m_BufferPointer = v20;
		    UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		      cmd,
		      &keyword,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      0LL);
		    UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, mat, 0LL, 1, 0LL);
		    UnityEngine::Material::SetTextureImpl(
		      mat,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiScatteredLuminanceLut,
		      (Texture *)multiScatteredLuminanceLut,
		      0LL);
		    v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v27, (Texture *)skyViewLut, 0LL);
		    v22 = *(_OWORD *)&v21->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v21->m_Type;
		    *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v21->m_DepthSlice;
		    *(_OWORD *)&keyword.m_BufferPointer = v22;
		    UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		      cmd,
		      &keyword,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      0LL);
		    UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, mat, 0LL, 2, 0LL);
		  }
		}
		
		private void _DispatchAtmosphereLutCS(CommandBuffer cmd, ComputeShader cs, RenderTexture skyViewLut, RenderTexture transmittanceLut, RenderTexture multiScatteredLuminanceLut, HGAtmosphereSettingParameters atmosphereParams) {} // 0x0000000189CE0D14-0x0000000189CE1194
		// Void _DispatchAtmosphereLutCS(CommandBuffer, ComputeShader, RenderTexture, RenderTexture, RenderTexture, HGAtmosphereSettingParameters)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::_DispatchAtmosphereLutCS(
		        HGAtmosphereRenderer *this,
		        CommandBuffer *cmd,
		        ComputeShader *cs,
		        RenderTexture *skyViewLut,
		        RenderTexture *transmittanceLut,
		        RenderTexture *multiScatteredLuminanceLut,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  int32_t TransmittanceLutUAV; // ebx
		  RenderTargetIdentifier *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int128 v16; // xmm1
		  __int64 v17; // xmm0_8
		  Int32Enum__Enum v18; // ebx
		  Int32Enum__Enum v19; // eax
		  int32_t v20; // ebx
		  RenderTargetIdentifier *v21; // rax
		  __int128 v22; // xmm1
		  __int64 v23; // xmm0_8
		  int32_t MultiScatteredLuminanceLutUAV; // ebx
		  RenderTargetIdentifier *v25; // rax
		  __int128 v26; // xmm1
		  Il2CppClass *v27; // xmm0_8
		  String *s_HighQualityMultiScatteringApproxEnabled; // r8
		  SettingParameter_1_System_Boolean_ *multiScatteredLuminanceLutHighQuality; // rcx
		  bool v30; // al
		  Int32Enum__Enum v31; // ebx
		  Int32Enum__Enum v32; // eax
		  int32_t v33; // ebx
		  RenderTargetIdentifier *v34; // rax
		  __int128 v35; // xmm1
		  Il2CppClass *v36; // xmm0_8
		  int32_t v37; // ebx
		  RenderTargetIdentifier *v38; // rax
		  __int128 v39; // xmm1
		  Il2CppClass *v40; // xmm0_8
		  int32_t SkyViewLutUAV; // ebx
		  RenderTargetIdentifier *v42; // rax
		  __int128 v43; // xmm1
		  Il2CppClass *v44; // xmm0_8
		  int32_t SkyViewLutWidth; // ebx
		  int32_t SkyViewLutHeight; // eax
		  __int64 v47; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MethodInfo v49; // [rsp+58h] [rbp-59h] BYREF
		  LocalKeyword v50; // [rsp+B8h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1435, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1435, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v47);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(
		      (ILFixDynamicMethodWrapper_3 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      (Object *)cs,
		      (Object *)skyViewLut,
		      (Object *)transmittanceLut,
		      (Object *)multiScatteredLuminanceLut,
		      (Object *)atmosphereParams,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    TransmittanceLutUAV = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLutUAV;
		    v13 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49,
		            (Texture *)transmittanceLut,
		            0LL);
		    if ( !cmd
		      || (v16 = *(_OWORD *)&v13->m_BufferPointer,
		          *(_OWORD *)&v49.parameters = *(_OWORD *)&v13->m_Type,
		          v17 = *(_QWORD *)&v13->m_DepthSlice,
		          *(_OWORD *)&v49.genericMethod = v16,
		          *(_QWORD *)&v49.slot = v17,
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            cmd,
		            cs,
		            0,
		            TransmittanceLutUAV,
		            (RenderTargetIdentifier *)&v49.parameters,
		            0LL),
		          !atmosphereParams) )
		    {
		      sub_1800D8260(v15, v14);
		    }
		    v18 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.transmittanceLutWidth,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v19 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.transmittanceLutHeight,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, cs, 0, (int)v18 / 8, (int)v19 / 8, 1, 0LL);
		    v20 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLut;
		    v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49,
		            (Texture *)transmittanceLut,
		            0LL);
		    v22 = *(_OWORD *)&v21->m_BufferPointer;
		    *(_OWORD *)&v49.parameters = *(_OWORD *)&v21->m_Type;
		    v23 = *(_QWORD *)&v21->m_DepthSlice;
		    *(_OWORD *)&v49.genericMethod = v22;
		    *(_QWORD *)&v49.slot = v23;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      cmd,
		      cs,
		      1,
		      v20,
		      (RenderTargetIdentifier *)&v49.parameters,
		      0LL);
		    MultiScatteredLuminanceLutUAV = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiScatteredLuminanceLutUAV;
		    v25 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49.parameters,
		            (Texture *)multiScatteredLuminanceLut,
		            0LL);
		    v26 = *(_OWORD *)&v25->m_BufferPointer;
		    *(_OWORD *)&v49.methodPointer = *(_OWORD *)&v25->m_Type;
		    v27 = *(Il2CppClass **)&v25->m_DepthSlice;
		    *(_OWORD *)&v49.invoker_method = v26;
		    v49.klass = v27;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      cmd,
		      cs,
		      1,
		      MultiScatteredLuminanceLutUAV,
		      (RenderTargetIdentifier *)&v49,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    s_HighQualityMultiScatteringApproxEnabled = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQualityMultiScatteringApproxEnabled;
		    memset(&v50, 0, sizeof(v50));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, cs, s_HighQualityMultiScatteringApproxEnabled, 0LL);
		    *(_OWORD *)&v49.parameters = *(_OWORD *)&v50.m_SpaceInfo.m_KeywordSpace;
		    multiScatteredLuminanceLutHighQuality = atmosphereParams->fields.multiScatteredLuminanceLutHighQuality;
		    v49.genericMethod = *(const Il2CppGenericMethod **)&v50.m_Index;
		    v30 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            multiScatteredLuminanceLutHighQuality,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, cs, (LocalKeyword *)&v49.parameters, v30, 0LL);
		    v31 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.multiScatteredLuminanceLutWidth,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v32 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.multiScatteredLuminanceLutHeight,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, cs, 1, (int)v31 / 8, (int)v32 / 8, 1, 0LL);
		    v33 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLut;
		    v34 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49.parameters,
		            (Texture *)transmittanceLut,
		            0LL);
		    v35 = *(_OWORD *)&v34->m_BufferPointer;
		    *(_OWORD *)&v49.methodPointer = *(_OWORD *)&v34->m_Type;
		    v36 = *(Il2CppClass **)&v34->m_DepthSlice;
		    *(_OWORD *)&v49.invoker_method = v35;
		    v49.klass = v36;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, cs, 2, v33, (RenderTargetIdentifier *)&v49, 0LL);
		    v37 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiScatteredLuminanceLut;
		    v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49.parameters,
		            (Texture *)multiScatteredLuminanceLut,
		            0LL);
		    v39 = *(_OWORD *)&v38->m_BufferPointer;
		    *(_OWORD *)&v49.methodPointer = *(_OWORD *)&v38->m_Type;
		    v40 = *(Il2CppClass **)&v38->m_DepthSlice;
		    *(_OWORD *)&v49.invoker_method = v39;
		    v49.klass = v40;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, cs, 2, v37, (RenderTargetIdentifier *)&v49, 0LL);
		    SkyViewLutUAV = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyViewLutUAV;
		    v42 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            (RenderTargetIdentifier *)&v49.parameters,
		            (Texture *)skyViewLut,
		            0LL);
		    v43 = *(_OWORD *)&v42->m_BufferPointer;
		    *(_OWORD *)&v49.methodPointer = *(_OWORD *)&v42->m_Type;
		    v44 = *(Il2CppClass **)&v42->m_DepthSlice;
		    *(_OWORD *)&v49.invoker_method = v43;
		    v49.klass = v44;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      cmd,
		      cs,
		      2,
		      SkyViewLutUAV,
		      (RenderTargetIdentifier *)&v49,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    SkyViewLutWidth = HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutWidth(atmosphereParams, 0LL);
		    SkyViewLutHeight = HG::Rendering::Runtime::HGAtmosphereRenderer::GetSkyViewLutHeight(atmosphereParams, 0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		      cmd,
		      cs,
		      2,
		      SkyViewLutWidth / 8,
		      SkyViewLutHeight / 8,
		      1,
		      0LL);
		  }
		}
		
		private static RenderTextureFormat _GetAtmosphereLutRenderTextureFormat(HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CE12D0-0x0000000189CE1320
		// RenderTextureFormat _GetAtmosphereLutRenderTextureFormat(HGAtmosphereSettingParameters)
		RenderTextureFormat__Enum HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureFormat(
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1430, 0LL) )
		    return 22;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1430, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81(
		           (ILFixDynamicMethodWrapper_20 *)Patch,
		           (Object *)atmosphereParams,
		           0LL);
		}
		
		private static RenderTextureDescriptor _GetAtmosphereLutRenderTextureDesc(HGAtmosphereSettingParameters atmosphereParams, int width, int height) => default; // 0x0000000189CE1194-0x0000000189CE12D0
		// RenderTextureDescriptor _GetAtmosphereLutRenderTextureDesc(HGAtmosphereSettingParameters, Int32, Int32)
		RenderTextureDescriptor *HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureDesc(
		        RenderTextureDescriptor *__return_ptr retstr,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RenderTextureFormat__Enum AtmosphereLutRenderTextureFormat; // eax
		  bool ShouldRenderAtmosphereLutUsingCompute; // al
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  RenderTextureDescriptor *v17; // rax
		  RenderTextureDescriptor v19; // [rsp+40h] [rbp-40h] BYREF
		
		  memset(&v19, 0, sizeof(v19));
		  if ( IFix::WrappersManagerImpl::IsPatched(1434, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1434, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_590(&v19, Patch, (Object *)atmosphereParams, width, height, 0LL);
		    v12 = *(_OWORD *)&v17->_mipCount_k__BackingField;
		    *(_OWORD *)&retstr->_width_k__BackingField = *(_OWORD *)&v17->_width_k__BackingField;
		    v13 = *(_OWORD *)&v17->_dimension_k__BackingField;
		    memoryless_k__BackingField = v17->_memoryless_k__BackingField;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    AtmosphereLutRenderTextureFormat = HG::Rendering::Runtime::HGAtmosphereRenderer::_GetAtmosphereLutRenderTextureFormat(
		                                         atmosphereParams,
		                                         0LL);
		    UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
		      &v19,
		      width,
		      height,
		      AtmosphereLutRenderTextureFormat,
		      0,
		      1,
		      0LL);
		    v19._dimension_k__BackingField = 2;
		    UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v19, 0, 0LL);
		    ShouldRenderAtmosphereLutUsingCompute = HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(
		                                              atmosphereParams,
		                                              0LL);
		    UnityEngine::RenderTextureDescriptor::set_enableRandomWrite(&v19, ShouldRenderAtmosphereLutUsingCompute, 0LL);
		    memoryless_k__BackingField = v19._memoryless_k__BackingField;
		    v12 = *(_OWORD *)&v19._mipCount_k__BackingField;
		    *(_OWORD *)&retstr->_width_k__BackingField = *(_OWORD *)&v19._width_k__BackingField;
		    v13 = *(_OWORD *)&v19._dimension_k__BackingField;
		  }
		  *(_OWORD *)&retstr->_mipCount_k__BackingField = v12;
		  *(_OWORD *)&retstr->_dimension_k__BackingField = v13;
		  retstr->_memoryless_k__BackingField = memoryless_k__BackingField;
		  return retstr;
		}
		
		private static Texture2D GetDefaultFogBakeLUT() => default; // 0x0000000189CDE3E4-0x0000000189CDE5C8
		// Texture2D GetDefaultFogBakeLUT()
		Texture2D *HG::Rendering::Runtime::HGAtmosphereRenderer::GetDefaultFogBakeLUT(MethodInfo *method)
		{
		  Object_1 *s_defaultFogBakeLUT; // rbx
		  Texture2D *v2; // rax
		  __int64 v3; // rdx
		  Texture2D *v4; // rcx
		  Texture2D *v5; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  __int64 v9; // rax
		  Color__Array *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *mipChain; // [rsp+20h] [rbp-58h]
		  __int128 v14; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1438, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    s_defaultFogBakeLUT = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(s_defaultFogBakeLUT, 0LL, 0LL) )
		    {
		LABEL_8:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      return TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT;
		    }
		    v2 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		    v5 = v2;
		    if ( v2 )
		    {
		      UnityEngine::Texture2D::Texture2D(v2, 4, 1, TextureFormat__Enum_RGBA32, 0, 1, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT = v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT,
		        v6,
		        v7,
		        v8,
		        mipChain);
		      v9 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Color, 4LL);
		      v10 = (Color__Array *)v9;
		      if ( v9 )
		      {
		        v14 = 0LL;
		        sub_18003FEF0(v9, 0LL, &v14);
		        v14 = 0LL;
		        sub_18003FEF0(v10, 1LL, &v14);
		        v14 = 0LL;
		        sub_18003FEF0(v10, 2LL, &v14);
		        v14 = 0LL;
		        sub_18003FEF0(v10, 3LL, &v14);
		        v4 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT;
		        if ( v4 )
		        {
		          UnityEngine::Texture2D::SetPixels(v4, v10, 0LL);
		          v4 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->s_defaultFogBakeLUT;
		          if ( v4 )
		          {
		            UnityEngine::Texture2D::Apply(v4, 0LL);
		            goto LABEL_8;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1438, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_593(Patch, 0LL);
		}
		
		public void SetupShaderVariablesGlobalBakeFogLut(ref ShaderVariablesGlobal cb, HGCamera hgCamera, HGAtmosphereSettingParameters atmosphereParams) {} // 0x0000000189CE00A4-0x0000000189CE051C
		// Void SetupShaderVariablesGlobalBakeFogLut(ShaderVariablesGlobal ByRef, HGCamera, HGAtmosphereSettingParameters)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalBakeFogLut(
		        HGAtmosphereRenderer *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Camera *camera; // rcx
		  Int32Enum__Enum v11; // eax
		  float farClipPlane; // xmm6_4
		  float v13; // xmm6_4
		  float v14; // xmm2_4
		  int v15; // xmm0_4
		  float v16; // xmm2_4
		  float v17; // xmm1_4
		  Transform *transform; // rax
		  Vector3 *forward; // rax
		  __int64 v20; // xmm10_8
		  float z; // r14d
		  Transform *v22; // rax
		  Vector3 *up; // rax
		  __int64 v24; // xmm9_8
		  float v25; // esi
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // r8
		  __int64 v29; // r9
		  float v30; // xmm6_4
		  MethodInfo *v31; // r9
		  Vector3 *v32; // rax
		  __int64 v33; // xmm3_8
		  MethodInfo *v34; // r9
		  Vector3 *v35; // rax
		  __int64 v36; // xmm3_8
		  __int64 v37; // rax
		  float v38; // ebx
		  MethodInfo *v39; // r9
		  Vector3 *v40; // rax
		  __int64 v41; // xmm3_8
		  MethodInfo *v42; // r9
		  Vector3 *v43; // rax
		  __int64 v44; // xmm3_8
		  __int64 v45; // rax
		  float v46; // xmm3_4
		  float v47; // xmm4_4
		  int v48; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v50; // [rsp+38h] [rbp-51h] BYREF
		  Vector3 v51; // [rsp+48h] [rbp-41h] BYREF
		  Vector3 v52; // [rsp+58h] [rbp-31h] BYREF
		  Vector3 v53; // [rsp+68h] [rbp-21h] BYREF
		  Vector3 v54; // [rsp+78h] [rbp-11h] BYREF
		  _OWORD v55[5]; // [rsp+88h] [rbp-1h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1439, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(
		        Patch,
		        (Object *)this,
		        cb,
		        (Object *)hgCamera,
		        (Object *)atmosphereParams,
		        0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(camera, v9);
		  }
		  if ( !atmosphereParams )
		    goto LABEL_19;
		  v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.fogLutWidth,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  *(float *)v55 = 1.0 - (float)(2.0 / (float)(int)v11);
		  *((float *)v55 + 1) = 1.5 / (float)(int)v11;
		  *((float *)v55 + 2) = 1.0 / *(float *)v55;
		  *((float *)v55 + 3) = (float)-*((float *)v55 + 1) / *(float *)v55;
		  *(_OWORD *)&cb->_G_EnableFeatureB = v55[0];
		  if ( !hgCamera )
		    goto LABEL_19;
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_19;
		  farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		  v13 = fmaxf(
		          fminf(farClipPlane + farClipPlane, HG::Rendering::Runtime::HGSkyRenderer::GetSkyDistance(hgCamera, 0LL) * 1.5),
		          100.0);
		  v14 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          atmosphereParams->fields.fogLutEncodeDistanceRatio,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  *(float *)&v15 = 10.0;
		  v16 = fminf(v14, 0.30000001) * v13;
		  if ( v16 < 10.0 || (*(float *)&v15 = 150.0, v16 > 150.0) )
		    v16 = *(float *)&v15;
		  *((float *)v55 + 3) = v16;
		  v17 = (float)-(float)((float)((float)(v16 + v13) * v16) / v13) * cb->_G_EnableFeatureB;
		  *(float *)v55 = (float)((float)((float)(v16 + v13) / v13) * cb->_G_EnableFeatureB) + cb->_G_EnableFeatureC;
		  *((float *)v55 + 1) = v17;
		  *((float *)v55 + 2) = v13 / (float)(v16 + v13);
		  *(_OWORD *)&cb->_IVParam0.y = v55[0];
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_19;
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !transform )
		    goto LABEL_19;
		  forward = UnityEngine::Transform::get_forward(&v54, transform, 0LL);
		  camera = hgCamera->fields.camera;
		  v20 = *(_QWORD *)&forward->x;
		  z = forward->z;
		  if ( !camera )
		    goto LABEL_19;
		  v22 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v22 )
		    goto LABEL_19;
		  up = UnityEngine::Transform::get_up(&v53, v22, 0LL);
		  camera = hgCamera->fields.camera;
		  v24 = *(_QWORD *)&up->x;
		  v25 = up->z;
		  *(_QWORD *)&v54.x = *(_QWORD *)&up->x;
		  if ( !camera )
		    goto LABEL_19;
		  UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		  *(_QWORD *)&v51.x = v24;
		  v51.z = v25;
		  v30 = sub_180338A80(v27, v26, v28, v29);
		  v32 = UnityEngine::Vector3::op_Multiply(&v53, &v51, v30, v31);
		  *(_QWORD *)&v50.x = v20;
		  v50.z = z;
		  v33 = *(_QWORD *)&v32->x;
		  *(float *)&v32 = v32->z;
		  *(_QWORD *)&v51.x = v33;
		  LODWORD(v51.z) = (_DWORD)v32;
		  v35 = UnityEngine::Vector3::op_Addition(&v53, &v50, &v51, v34);
		  v36 = *(_QWORD *)&v35->x;
		  *(float *)&v35 = v35->z;
		  *(_QWORD *)&v50.x = v36;
		  LODWORD(v50.z) = (_DWORD)v35;
		  v37 = sub_182FAE2B0(&v53, &v50);
		  *(_QWORD *)&v52.x = v24;
		  v52.z = v25;
		  v38 = *(float *)(v37 + 8);
		  *(_QWORD *)&v51.x = *(_QWORD *)v37;
		  v40 = UnityEngine::Vector3::op_Multiply(&v53, &v52, v30, v39);
		  v41 = *(_QWORD *)&v40->x;
		  *(float *)&v40 = v40->z;
		  *(_QWORD *)&v52.x = v41;
		  LODWORD(v52.z) = (_DWORD)v40;
		  *(_QWORD *)&v53.x = v20;
		  v53.z = z;
		  v43 = UnityEngine::Vector3::op_Subtraction((Vector3 *)v55, &v53, &v52, v42);
		  v44 = *(_QWORD *)&v43->x;
		  *(float *)&v43 = v43->z;
		  *(_QWORD *)&v50.x = v44;
		  LODWORD(v50.z) = (_DWORD)v43;
		  v45 = sub_182FAE2B0(v55, &v50);
		  *(_QWORD *)&v50.x = *(_QWORD *)v45;
		  v46 = fminf(fminf(1.0, v51.y), v50.y);
		  v47 = fmaxf(fmaxf(-1.0, v51.y), v50.y);
		  if ( (float)((float)(*(float *)(v45 + 8) * v38) + (float)(v50.x * v51.x)) <= 0.0 )
		  {
		    v48 = -1;
		    if ( v54.y > 0.0 )
		      v48 = 1;
		    v46 = fminf(v46, (float)v48);
		    v47 = fmaxf(v47, (float)v48);
		  }
		  *((float *)v55 + 1) = v46;
		  *(float *)v55 = v47 - v46;
		  *((float *)v55 + 3) = (float)-v46 / (float)(v47 - v46);
		  *((float *)v55 + 2) = 1.0 / (float)(v47 - v46);
		  *(_OWORD *)&cb->_IVParam1.y = v55[0];
		}
		
		public static void ResetShaderVariablesGlobalBakeFogLut(ref ShaderVariablesGlobal cb) {} // 0x0000000189CDF5A8-0x0000000189CDF664
		// Void ResetShaderVariablesGlobalBakeFogLut(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalBakeFogLut(
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  __m128i si128; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int128 v7; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1441, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1441, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(Patch, cb, 0LL);
		  }
		  else
		  {
		    *(__m128i *)&cb->_G_EnableFeatureB = _mm_load_si128((const __m128i *)&xmmword_18DC81680);
		    *((_QWORD *)&v7 + 1) = 0x42C800003F7D7721LL;
		    *((float *)&v7 + 1) = cb->_G_EnableFeatureB * -101.0;
		    *(float *)&v7 = (float)(cb->_G_EnableFeatureB * 1.01) + cb->_G_EnableFeatureC;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18DC812C0);
		    *(_OWORD *)&cb->_IVParam0.y = v7;
		    *(__m128i *)&cb->_IVParam1.y = si128;
		  }
		}
		
		public static void SetupFogBakeLutParam(HGCamera hgCamera, TextureHandle lutTex, CommandBuffer cmd) {} // 0x0000000189CDF78C-0x0000000189CDF91C
		// Void SetupFogBakeLutParam(HGCamera, TextureHandle, CommandBuffer)
		void HG::Rendering::Runtime::HGAtmosphereRenderer::SetupFogBakeLutParam(
		        HGCamera *hgCamera,
		        TextureHandle *lutTex,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  int32_t FogBakeLutTex; // esi
		  RenderTargetIdentifier *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t v11; // edx
		  __int128 v12; // xmm1
		  int32_t v13; // edi
		  Texture *DefaultFogBakeLUT; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  TextureHandle v20; // [rsp+38h] [rbp-19h] BYREF
		  RenderTargetIdentifier v21; // [rsp+48h] [rbp-9h] BYREF
		  RenderTargetIdentifier v22; // [rsp+78h] [rbp+27h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1442, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1442, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    v20 = *lutTex;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_472(Patch, (Object *)hgCamera, &v20, (Object *)cmd, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(hgCamera, 0LL)
		      && (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
		          HG::Rendering::RenderGraphModule::TextureHandle::IsValid(lutTex, 0LL)) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      FogBakeLutTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FogBakeLutTex;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v20 = *lutTex;
		      v8 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v22, &v20, 0LL);
		      if ( !cmd )
		        sub_1800D8260(v10, v9);
		      v11 = FogBakeLutTex;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      v13 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FogBakeLutTex;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      DefaultFogBakeLUT = (Texture *)HG::Rendering::Runtime::HGAtmosphereRenderer::GetDefaultFogBakeLUT(0LL);
		      v8 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v22, DefaultFogBakeLUT, 0LL);
		      if ( !cmd )
		        sub_1800D8260(v16, v15);
		      v11 = v13;
		    }
		    v12 = *(_OWORD *)&v8->m_BufferPointer;
		    *(_OWORD *)&v21.m_Type = *(_OWORD *)&v8->m_Type;
		    *(_QWORD *)&v21.m_DepthSlice = *(_QWORD *)&v8->m_DepthSlice;
		    *(_OWORD *)&v21.m_BufferPointer = v12;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v11, &v21, 0LL);
		  }
		}
		
		public static TextureDesc CreateBakeFogLutDesc(HGAtmosphereSettingParameters atmosphereParams) => default; // 0x0000000189CDE29C-0x0000000189CDE3E4
		// TextureDesc CreateBakeFogLutDesc(HGAtmosphereSettingParameters)
		TextureDesc *HG::Rendering::Runtime::HGAtmosphereRenderer::CreateBakeFogLutDesc(
		        TextureDesc *__return_ptr retstr,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Int32Enum__Enum v7; // ebx
		  Int32Enum__Enum v8; // eax
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  Color clearColor; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureDesc *v18; // rax
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  TextureDesc *result; // rax
		  TextureDesc v23; // [rsp+28h] [rbp-69h] BYREF
		  TextureDesc v24; // [rsp+88h] [rbp-9h] BYREF
		
		  sub_18033B9D0(&v23, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1443, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1443, 0LL);
		    if ( Patch )
		    {
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_594(&v24, Patch, (Object *)atmosphereParams, 0LL);
		      v19 = *(_OWORD *)&v18->colorFormat;
		      *(_OWORD *)&retstr->width = *(_OWORD *)&v18->width;
		      v20 = *(_OWORD *)&v18->enableRandomWrite;
		      *(_OWORD *)&retstr->colorFormat = v19;
		      v21 = *(_OWORD *)&v18->bindTextureMS;
		      *(_OWORD *)&retstr->enableRandomWrite = v20;
		      v15 = *(_OWORD *)&v18->fastMemoryDesc.inFastMemory;
		      *(_OWORD *)&retstr->bindTextureMS = v21;
		      clearColor = v18->clearColor;
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !atmosphereParams )
		    goto LABEL_5;
		  v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.fogLutWidth,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)atmosphereParams->fields.fogLutHeight,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v23, v7, v8, 0LL);
		  v23.depthBufferBits = 0;
		  v23.name = (String *)"_FogBakeLut";
		  v23.colorFormat = 48;
		  v23.autoGenerateMips = 0;
		  v23.dimension = 2;
		  sub_18002D1B0((SingleFieldAccessor *)&v23.name, v9, v10, v11, *(MethodInfo **)&v23.width);
		  v12 = *(_OWORD *)&v23.colorFormat;
		  *(_OWORD *)&retstr->width = *(_OWORD *)&v23.width;
		  v13 = *(_OWORD *)&v23.enableRandomWrite;
		  *(_OWORD *)&retstr->colorFormat = v12;
		  v14 = *(_OWORD *)&v23.bindTextureMS;
		  *(_OWORD *)&retstr->enableRandomWrite = v13;
		  v15 = *(_OWORD *)&v23.fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&retstr->bindTextureMS = v14;
		  clearColor = v23.clearColor;
		LABEL_7:
		  result = retstr;
		  *(_OWORD *)&retstr->fastMemoryDesc.inFastMemory = v15;
		  retstr->clearColor = clearColor;
		  return result;
		}
		
	}
}
