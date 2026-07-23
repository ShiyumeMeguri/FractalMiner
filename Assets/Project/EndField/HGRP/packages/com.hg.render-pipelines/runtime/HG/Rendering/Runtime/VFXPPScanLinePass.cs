using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VFXPPScanLinePass // TypeDefIndex: 37962
	{
		// Fields
		private static bool s_useScanLine; // 0x00
		private static bool s_useBlackBox; // 0x01
		private static bool s_scanLineUseMask; // 0x02
		private static bool s_shouldDrawScanlineHighlight; // 0x03
		private static VFXPPScanLinePassInput s_vfxPPScanLinePassInput; // 0x08
		private static ScanLineDataPack s_slDataPack; // 0x40
		private static Material s_scanlineMaterial; // 0x1D0
		private static Texture s_scanlineMaskTex; // 0x1D8
		private static Texture s_blackBoxContourTex; // 0x1E0
		private static HighlightDataPack s_highlightDataPack; // 0x1E8
		private static Mesh s_HighlightMesh; // 0x208
		private static Shader s_HighlightShader; // 0x210
		private static Material s_HighlightMat; // 0x218
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x220
	
		// Constructors
		public VFXPPScanLinePass() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static VFXPPScanLinePass() {} // 0x0000000184CB06F0-0x0000000184CB0800
		// VFXPPScanLinePass()
		void HG::Rendering::Runtime::VFXPPScanLinePass::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  Material *v5; // r10
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MaterialPropertyBlock *v10; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine = 0;
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useBlackBox = 0;
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanLineUseMask = 0;
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_shouldDrawScanlineHighlight = 0;
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial,
		    v1,
		    v2,
		    v3,
		    v14);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat = v5;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat,
		    v6,
		    v7,
		    v4,
		    v15);
		  v10 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v10 )
		    sub_1800D8260(v9, v8);
		  v10->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock = v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock,
		    v11,
		    v12,
		    v13,
		    v16);
		}
		
	
		// Methods
		public static void PrepareScanLineMaterial(Shader scanlinePS) {} // 0x0000000184814D30-0x0000000184814E70
		// Void PrepareScanLineMaterial(Shader)
		void HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(Shader *scanlinePS, MethodInfo *method)
		{
		  struct VFXPPScanLinePass__Class *v3; // rbx
		  struct Object_1__Class *v4; // rcx
		  Material *s_scanlineMaterial; // rbx
		  Material *StaticMaterial; // rax
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  struct VFXPPScanLinePass__Class *v10; // rcx
		  Material *v11; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2554, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2554, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)scanlinePS, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    }
		    v4 = TypeInfo::UnityEngine::Object;
		    s_scanlineMaterial = v3->static_fields->s_scanlineMaterial;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !s_scanlineMaterial )
		      goto LABEL_21;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v4);
		    if ( !s_scanlineMaterial->fields._.m_CachedPtr )
		    {
		LABEL_21:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		      StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                         scanlinePS,
		                         0,
		                         0LL);
		      v10 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      v11 = StaticMaterial;
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v10 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      }
		      v10->static_fields->s_scanlineMaterial = v11;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial,
		        v7,
		        v8,
		        v9,
		        v15);
		    }
		  }
		}
		
		public static Vector4 CalBoxVecNormalized(Vector4 boxPos, Vector4 center) => default; // 0x0000000189B62650-0x0000000189B6274C
		// Vector4 CalBoxVecNormalized(Vector4, Vector4)
		Vector4 *HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
		        Vector4 *__return_ptr retstr,
		        Vector4 *boxPos,
		        Vector4 *center,
		        MethodInfo *method)
		{
		  Vector2 v7; // r8
		  Vector2 v8; // r9
		  __m128 x_low; // xmm3
		  __m128 z_low; // xmm2
		  double v11; // xmm0_8
		  float x; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Vector4 v16; // xmm1
		  Vector4 v18; // [rsp+30h] [rbp-38h] BYREF
		  Vector4 v19; // [rsp+40h] [rbp-28h] BYREF
		  Vector4 v20; // [rsp+50h] [rbp-18h] BYREF
		  Vector2 v21; // [rsp+70h] [rbp+8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2555, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2555, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    v16 = *boxPos;
		    v18 = *center;
		    v19 = v16;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_960(&v20, Patch, &v19, &v18, 0LL);
		  }
		  else
		  {
		    x_low = (__m128)LODWORD(boxPos->x);
		    z_low = (__m128)LODWORD(boxPos->z);
		    x_low.m128_f32[0] = x_low.m128_f32[0] - center->x;
		    z_low.m128_f32[0] = z_low.m128_f32[0] - center->z;
		    v21 = sub_1853DF234(
		            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, z_low),
		            (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x358637BDu, (__m128)0x358637BDu),
		            v7,
		            v8);
		    *(_QWORD *)&v18.x = sub_182FA2990(&v21);
		    v11 = sub_182FA2AF0(&v21);
		    x = v18.x;
		    z_low.m128_i32[0] = LODWORD(v18.y);
		    retstr->y = 0.0;
		    retstr->x = x;
		    LODWORD(retstr->z) = z_low.m128_i32[0];
		    retstr->w = *(float *)&v11;
		  }
		  return retstr;
		}
		
		public static Mesh GetSurface() => default; // 0x00000001831D20B0-0x00000001831D2400
		// Mesh GetSurface()
		Mesh *HG::Rendering::Runtime::VFXPPScanLinePass::GetSurface(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Vector3__Array *v4; // rdi
		  __int64 v5; // rax
		  Vector2__Array *v6; // rbx
		  Array *v7; // rbp
		  Mesh *v8; // rax
		  Mesh *v9; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2556, 0LL) )
		  {
		    v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 10LL);
		    v4 = (Vector3__Array *)v1;
		    if ( !v1 )
		      goto LABEL_3;
		    if ( !*(_DWORD *)(v1 + 24) )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 32) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v1 + 40) = 1041865114;
		    if ( *(_DWORD *)(v1 + 24) <= 1u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 44) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3FC00000u).m128_u64[0];
		    *(_DWORD *)(v1 + 52) = 1041865114;
		    if ( *(_DWORD *)(v1 + 24) <= 2u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 56) = _mm_unpacklo_ps((__m128)0xBE800000, (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v1 + 64) = 1028443341;
		    if ( *(_DWORD *)(v1 + 24) <= 3u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 68) = _mm_unpacklo_ps((__m128)0xBE800000, (__m128)0x3FC00000u).m128_u64[0];
		    *(_DWORD *)(v1 + 76) = 1028443341;
		    if ( *(_DWORD *)(v1 + 24) <= 4u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 80) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v1 + 88) = 0;
		    if ( *(_DWORD *)(v1 + 24) <= 5u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 92) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3FC00000u).m128_u64[0];
		    *(_DWORD *)(v1 + 100) = 0;
		    if ( *(_DWORD *)(v1 + 24) <= 6u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 104) = _mm_unpacklo_ps((__m128)0x3E800000u, (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v1 + 112) = 1028443341;
		    if ( *(_DWORD *)(v1 + 24) <= 7u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 116) = _mm_unpacklo_ps((__m128)0x3E800000u, (__m128)0x3FC00000u).m128_u64[0];
		    *(_DWORD *)(v1 + 124) = 1028443341;
		    if ( *(_DWORD *)(v1 + 24) <= 8u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 128) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v1 + 136) = 1041865114;
		    if ( *(_DWORD *)(v1 + 24) <= 9u )
		      goto LABEL_27;
		    *(_QWORD *)(v1 + 140) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3FC00000u).m128_u64[0];
		    *(_DWORD *)(v1 + 148) = 1041865114;
		    v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 10LL);
		    v6 = (Vector2__Array *)v5;
		    if ( !v5 )
		      goto LABEL_3;
		    if ( !*(_DWORD *)(v5 + 24) )
		      goto LABEL_27;
		    *(_QWORD *)(v5 + 32) = 0LL;
		    if ( *(_DWORD *)(v5 + 24) <= 1u )
		      goto LABEL_27;
		    *(_DWORD *)(v5 + 40) = 0;
		    *(_DWORD *)(v5 + 44) = 1065353216;
		    if ( *(_DWORD *)(v5 + 24) <= 2u )
		      goto LABEL_27;
		    *(_QWORD *)(v5 + 48) = 1048576000LL;
		    if ( *(_DWORD *)(v5 + 24) <= 3u )
		      goto LABEL_27;
		    *(_DWORD *)(v5 + 56) = 1048576000;
		    *(_DWORD *)(v5 + 60) = 1065353216;
		    if ( *(_DWORD *)(v5 + 24) <= 4u
		      || (*(_QWORD *)(v5 + 64) = 1056964608LL, *(_DWORD *)(v5 + 24) <= 5u)
		      || (*(_DWORD *)(v5 + 72) = 1056964608, *(_DWORD *)(v5 + 76) = 1065353216, *(_DWORD *)(v5 + 24) <= 6u)
		      || (*(_QWORD *)(v5 + 80) = 1061158912LL, *(_DWORD *)(v5 + 24) <= 7u)
		      || (*(_DWORD *)(v5 + 88) = 1061158912, *(_DWORD *)(v5 + 92) = 1065353216, *(_DWORD *)(v5 + 24) <= 8u)
		      || (*(_QWORD *)(v5 + 96) = 1065353216LL, *(_DWORD *)(v5 + 24) <= 9u) )
		    {
		LABEL_27:
		      sub_1800D2AB0(v3, v2);
		    }
		    *(_DWORD *)(v5 + 104) = 1065353216;
		    *(_DWORD *)(v5 + 108) = 1065353216;
		    v7 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 24LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v7,
		      D5DB579018C9E7156FBDD363CF02BDF5FC7931FF78332B7F05DB244870481D85_Field,
		      0LL);
		    v8 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		    v9 = v8;
		    if ( v8 )
		    {
		      UnityEngine::Mesh::Mesh(v8, 0LL);
		      UnityEngine::Mesh::set_vertices(v9, v4, 0LL);
		      UnityEngine::Mesh::set_uv(v9, v6, 0LL);
		      UnityEngine::Mesh::set_triangles(v9, (Int32__Array *)v7, 0LL);
		      UnityEngine::Object::set_name((Object_1 *)v9, (String *)"HighlightSurface2", 0LL);
		      UnityEngine::Object::set_hideFlags((Object_1 *)v9, HideFlags__Enum_HideAndDontSave, 0LL);
		      UnityEngine::Mesh::UploadMeshData(v9, 1, 0LL);
		      return v9;
		    }
		LABEL_3:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2556, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
		internal static void PrepareResources(HGRenderPipelineRuntimeResources defaultResources) {} // 0x00000001831D1ED0-0x00000001831D20B0
		// Void PrepareResources(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::VFXPPScanLinePass::PrepareResources(
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  Mesh *Surface; // rax
		  VFXPPScanLinePass__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdx
		  Material *v8; // rcx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  struct Object_1__Class *v11; // rcx
		  Material *s_HighlightMat; // rbx
		  Shader *s_HighlightShader; // rbx
		  Material *StaticMaterial; // rax
		  VFXPPScanLinePass__StaticFields *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2557, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    Surface = HG::Rendering::Runtime::VFXPPScanLinePass::GetSurface(0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    static_fields->s_HighlightMesh = Surface;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMesh,
		      (HGRuntimeGrassQuery_Node *)static_fields,
		      v5,
		      v6,
		      v19);
		    if ( defaultResources )
		    {
		      shaders = defaultResources->fields.shaders;
		      if ( shaders )
		      {
		        TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightShader = shaders->fields.scanLineHighlightShader;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightShader,
		          (HGRuntimeGrassQuery_Node *)shaders,
		          v9,
		          v10,
		          v20);
		        v11 = TypeInfo::UnityEngine::Object;
		        s_HighlightMat = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v11 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v11 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( !s_HighlightMat )
		          goto LABEL_27;
		        if ( !v11->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v11);
		        if ( !s_HighlightMat->fields._.m_CachedPtr )
		        {
		LABEL_27:
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		          s_HighlightShader = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightShader;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		          StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                             s_HighlightShader,
		                             0,
		                             0LL);
		          v15 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		          v15->s_HighlightMat = StaticMaterial;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat,
		            (HGRuntimeGrassQuery_Node *)v15,
		            v16,
		            v17,
		            v21);
		        }
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v8 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat;
		        if ( v8 )
		        {
		          UnityEngine::Material::set_enableInstancing(v8, 1, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_5:
		    sub_1800D8260(v8, shaders);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2557, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)defaultResources, 0LL);
		}
		
		public static bool ShouldRequestVerticalOcclusionMap(HGCamera hgCamera) => default; // 0x0000000183736000-0x00000001837361B0
		// Boolean ShouldRequestVerticalOcclusionMap(HGCamera)
		bool HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  HGScanLine *m_hgScanLine; // rbx
		  Vector4Parameter *boxPosition1; // rdi
		  __m128 *v8; // rax
		  Vector4Parameter *boxPosition2; // rdi
		  __m128 v10; // xmm7
		  __m128 *v11; // rax
		  Vector4Parameter *boxPosition3; // rbx
		  __m128 v13; // xmm6
		  __int64 v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  _BYTE v18[16]; // [rsp+20h] [rbp-38h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 851 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_20;
		    if ( wrapperArray->max_length.size <= 0x353u )
		      goto LABEL_36;
		    if ( wrapperArray[23].vector[23] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(851, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)hgCamera,
		                 0LL);
		      goto LABEL_20;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_20;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 783 )
		  {
		LABEL_10:
		    m_volumeComponentsData = hgCamera->fields.m_volumeComponentsData;
		    goto LABEL_11;
		  }
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_20:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x30F )
		LABEL_36:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[16]._1.token )
		    goto LABEL_10;
		  v17 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		  if ( !v17 )
		    goto LABEL_20;
		  m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v17, (Object *)hgCamera, 0LL);
		LABEL_11:
		  if ( !m_volumeComponentsData )
		    goto LABEL_20;
		  m_hgScanLine = m_volumeComponentsData->fields.m_hgScanLine;
		  if ( !m_hgScanLine )
		    goto LABEL_20;
		  boxPosition1 = m_hgScanLine->fields.boxPosition1;
		  if ( !boxPosition1 )
		    goto LABEL_20;
		  sub_1800049A0(boxPosition1->klass);
		  v8 = (__m128 *)((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition1->klass->vtable.get_value.method)(
		                   v18,
		                   boxPosition1,
		                   boxPosition1->klass->vtable.set_value.methodPtr);
		  boxPosition2 = m_hgScanLine->fields.boxPosition2;
		  v10 = *v8;
		  if ( !boxPosition2 )
		    goto LABEL_20;
		  sub_1800049A0(boxPosition2->klass);
		  v11 = (__m128 *)((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition2->klass->vtable.get_value.method)(
		                    v18,
		                    boxPosition2,
		                    boxPosition2->klass->vtable.set_value.methodPtr);
		  boxPosition3 = m_hgScanLine->fields.boxPosition3;
		  v13 = *v11;
		  if ( !boxPosition3 )
		    goto LABEL_20;
		  sub_1800049A0(boxPosition3->klass);
		  v14 = ((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition3->klass->vtable.get_value.method)(
		          v18,
		          boxPosition3,
		          boxPosition3->klass->vtable.set_value.methodPtr);
		  return _mm_shuffle_ps(v10, v10, 255).m128_f32[0] == 1.0
		      || _mm_shuffle_ps(v13, v13, 255).m128_f32[0] == 1.0
		      || *(float *)(v14 + 12) == 1.0;
		}
		
		public static void RequestVerticalOcclusionMap(HGCamera hgCamera) {} // 0x0000000189B63AFC-0x0000000189B63B8C
		// Void RequestVerticalOcclusionMap(HGCamera)
		void HG::Rendering::Runtime::VFXPPScanLinePass::RequestVerticalOcclusionMap(HGCamera *hgCamera, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(850, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(850, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)hgCamera, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !hgCamera )
		    goto LABEL_8;
		  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
		  if ( verticalOcclusionMapManager )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    if ( HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(hgCamera, 0LL) )
		      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
		        verticalOcclusionMapManager,
		        HGVerticalOcclusionMapManager_RequestUsageType__Enum_ScanlineHighlight,
		        0LL);
		    else
		      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::UnregisterRequestUsage(
		        verticalOcclusionMapManager,
		        HGVerticalOcclusionMapManager_RequestUsageType__Enum_ScanlineHighlight,
		        0LL);
		  }
		}
		
		public static Vector4 CalAndChooseHeightValue(Vector4 scanLineCenterPos, Vector4 Box, Vector4 scanlineParams1, Vector4 detectDist, Vector3 beamHeight) => default; // 0x0000000189B62494-0x0000000189B62650
		// Vector4 CalAndChooseHeightValue(Vector4, Vector4, Vector4, Vector4, Vector3)
		Vector4 *HG::Rendering::Runtime::VFXPPScanLinePass::CalAndChooseHeightValue(
		        Vector4 *__return_ptr retstr,
		        Vector4 *scanLineCenterPos,
		        Vector4 *Box,
		        Vector4 *scanlineParams1,
		        Vector4 *detectDist,
		        Vector3 *beamHeight,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  float v13; // xmm6_4
		  unsigned int v14; // xmm0_4
		  System::MathF *v15; // rcx
		  float x; // xmm0_4
		  Vector4 v17; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v19; // rcx
		  Vector4 v20; // xmm1
		  __int64 v21; // xmm0_8
		  Vector4 v22; // xmm1
		  Vector4 v23; // xmm0
		  Vector4 *result; // rax
		  Vector4 v25; // [rsp+48h] [rbp-41h] BYREF
		  Vector4 v26; // [rsp+58h] [rbp-31h] BYREF
		  Vector4 v27; // [rsp+68h] [rbp-21h] BYREF
		  Vector4 v28; // [rsp+78h] [rbp-11h] BYREF
		  Vector4 v29; // [rsp+88h] [rbp-1h] BYREF
		  Vector4 v30; // [rsp+98h] [rbp+Fh] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2558, 0LL) )
		  {
		    sub_1803369A0();
		    sub_1803369A0();
		    v13 = sub_1803386C0(v12, v11);
		    *(float *)&v14 = fminf(v13, detectDist->w) / scanlineParams1->y;
		    System::MathF::Floor(v15, 2.0);
		    v25.w = 0.0;
		    *(_QWORD *)&v25.y = v14;
		    if ( v13 < 0.0 || detectDist->x < v13 )
		    {
		      if ( v13 <= detectDist->x || detectDist->y < v13 )
		      {
		        if ( v13 <= detectDist->y || detectDist->z < v13 )
		        {
		          v25.x = 0.0;
		          goto LABEL_13;
		        }
		        x = beamHeight->x;
		      }
		      else
		      {
		        x = beamHeight->y;
		      }
		    }
		    else
		    {
		      x = beamHeight->z;
		    }
		    v25.x = x;
		LABEL_13:
		    v17 = v25;
		    goto LABEL_17;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2558, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v19, 0LL);
		  v20 = *scanlineParams1;
		  v21 = *(_QWORD *)&beamHeight->x;
		  v25.z = beamHeight->z;
		  *(_QWORD *)&v25.x = v21;
		  v27 = v20;
		  v22 = *scanLineCenterPos;
		  v26 = *detectDist;
		  v23 = *Box;
		  v29 = v22;
		  v28 = v23;
		  v17 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_961(&v30, Patch, &v29, &v28, &v27, &v26, (Vector3 *)&v25, 0LL);
		LABEL_17:
		  result = retstr;
		  *retstr = v17;
		  return result;
		}
		
		public static void TransferDataAndDrawMesh(HGRenderGraphContext ctx, Vector4 result, Vector4 Box, float meshHeight) {} // 0x0000000189B63B8C-0x0000000189B63DB4
		// Void TransferDataAndDrawMesh(HGRenderGraphContext, Vector4, Vector4, Single)
		void HG::Rendering::Runtime::VFXPPScanLinePass::TransferDataAndDrawMesh(
		        HGRenderGraphContext *ctx,
		        Vector4 *result,
		        Vector4 *Box,
		        float meshHeight,
		        MethodInfo *method)
		{
		  float y; // xmm0_4
		  int32_t count; // ebp
		  MaterialPropertyBlock *s_materialPropertyBlock; // rsi
		  MaterialPropertyBlock *cmd; // rcx
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  int32_t BoxPosWS; // edx
		  VFXPPScanLinePass__StaticFields *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v16; // xmm1
		  Vector4 v17; // [rsp+40h] [rbp-38h] BYREF
		  Vector4 v18; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2559, 0LL) )
		  {
		    y = result->y;
		    if ( y < 1.0 )
		      return;
		    count = (int)y;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    s_materialPropertyBlock = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( s_materialPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		        s_materialPropertyBlock,
		        static_fields->_ScanLineHighlightHeight,
		        result->x,
		        0LL);
		      cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( cmd )
		      {
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(cmd, static_fields->_CountPerArray, (float)count, 0LL);
		        cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( cmd )
		        {
		          BoxPosWS = static_fields->_BoxPosWS;
		          v17 = *Box;
		          UnityEngine::MaterialPropertyBlock::SetVector(cmd, BoxPosWS, &v17, 0LL);
		          cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          if ( cmd )
		          {
		            UnityEngine::MaterialPropertyBlock::SetFloatImpl(cmd, static_fields->_MeshHeight, meshHeight, 0LL);
		            if ( ctx )
		            {
		              cmd = (MaterialPropertyBlock *)ctx->fields.cmd;
		              v14 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		              static_fields = (HGShaderIDs__StaticFields *)v14->s_HighlightMesh;
		              if ( cmd )
		              {
		                UnityEngine::Rendering::CommandBuffer::DrawMeshInstancedProcedural(
		                  (CommandBuffer *)cmd,
		                  (Mesh *)static_fields,
		                  0,
		                  v14->s_HighlightMat,
		                  0,
		                  count,
		                  v14->s_materialPropertyBlock,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(cmd, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2559, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  v16 = *result;
		  v17 = *Box;
		  v18 = v16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_962(Patch, (Object *)ctx, &v18, &v17, meshHeight, 0LL);
		}
		
		public static void Draw(Vector4 Box, Vector4 scanLineCenterPos, Vector4 scanlineParams1, HighlightDataPack highlightDataPack, HGRenderGraphContext ctx) {} // 0x0000000189B63960-0x0000000189B63AFC
		// Void Draw(Vector4, Vector4, Vector4, HighlightDataPack, HGRenderGraphContext)
		void HG::Rendering::Runtime::VFXPPScanLinePass::Draw(
		        Vector4 *Box,
		        Vector4 *scanLineCenterPos,
		        Vector4 *scanlineParams1,
		        HighlightDataPack *highlightDataPack,
		        HGRenderGraphContext *ctx,
		        MethodInfo *method)
		{
		  Vector4 detectDistance; // xmm7
		  Vector4 v11; // xmm1
		  Vector4 v12; // xmm0
		  __m128i v13; // xmm6
		  Vector4 *v14; // rax
		  Vector4 v15; // xmm0
		  float meshHeight; // xmm3_4
		  __int64 v17; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v19; // xmm1
		  Vector4 v20; // xmm0
		  Vector4 v21; // xmm1
		  Vector4 v22; // xmm0
		  Vector3 v23; // [rsp+48h] [rbp-59h] BYREF
		  Vector4 v24; // [rsp+58h] [rbp-49h] BYREF
		  Vector4 v25; // [rsp+68h] [rbp-39h] BYREF
		  Vector4 v26; // [rsp+78h] [rbp-29h] BYREF
		  Vector4 v27[2]; // [rsp+88h] [rbp-19h] BYREF
		  HighlightDataPack v28[2]; // [rsp+A8h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2560, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2560, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v17);
		    v19 = *(_OWORD *)&highlightDataPack->beamHeight.x;
		    v28[0].detectDistance = highlightDataPack->detectDistance;
		    v20 = *scanlineParams1;
		    *(_OWORD *)&v28[0].beamHeight.x = v19;
		    v21 = *scanLineCenterPos;
		    v27[0] = v20;
		    v22 = *Box;
		    v26 = v21;
		    v25 = v22;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_963(Patch, &v25, &v26, v27, v28, (Object *)ctx, 0LL);
		  }
		  else if ( Box->w == 1.0 )
		  {
		    detectDistance = highlightDataPack->detectDistance;
		    *(_OWORD *)&v28[0].beamHeight.x = *(_OWORD *)&highlightDataPack->beamHeight.x;
		    v28[0].detectDistance = detectDistance;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    v11 = *Box;
		    v25 = *scanlineParams1;
		    v12 = *scanLineCenterPos;
		    *(_QWORD *)&v23.x = *(_QWORD *)&v28[0].beamHeight.x;
		    v13 = _mm_loadl_epi64((const __m128i *)&highlightDataPack->beamHeight.z);
		    v27[0] = v12;
		    LODWORD(v23.z) = _mm_cvtsi128_si32(v13);
		    v24 = detectDistance;
		    v26 = v11;
		    v14 = HG::Rendering::Runtime::VFXPPScanLinePass::CalAndChooseHeightValue(
		            &v28[0].detectDistance,
		            v27,
		            &v26,
		            &v25,
		            &v24,
		            &v23,
		            0LL);
		    v15 = *Box;
		    meshHeight = highlightDataPack->meshHeight;
		    v26 = *v14;
		    v27[0] = v15;
		    HG::Rendering::Runtime::VFXPPScanLinePass::TransferDataAndDrawMesh(ctx, &v26, v27, meshHeight, 0LL);
		  }
		}
		
		public static unsafe VFXPPScanLinePassInput* GetCppPassInput(HGCamera hgCamera) => default; // 0x0000000183A15920-0x0000000183A15BA0
		// VFXPPScanLinePassInput* GetCppPassInput(HGCamera)
		VFXPPScanLinePassInput *HG::Rendering::Runtime::VFXPPScanLinePass::GetCppPassInput(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v3)(__int64); // rax
		  __int64 v4; // rdx
		  VFXPPScanLinePassInput *v5; // rbx
		  VFXPPScanLinePass__StaticFields *static_fields; // rcx
		  Texture *s_scanlineMaskTex; // rsi
		  struct Object_1__Class *v8; // rcx
		  void *v9; // rdi
		  void *m_CachedPtr; // rax
		  Texture *s_blackBoxContourTex; // rsi
		  struct Object_1__Class *v12; // rcx
		  struct VFXPPScanLinePass__Class *v13; // rax
		  Material *s_HighlightMat; // rax
		  Mesh *s_HighlightMesh; // rax
		  __int64 v17; // rax
		  Texture *v18; // rax
		  Texture *v19; // rdi
		
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(hgCamera, 0LL);
		  v3 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v3 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v3 )
		    {
		      v17 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v17, 0LL);
		    }
		    qword_18F370618 = (__int64)v3;
		  }
		  v5 = (VFXPPScanLinePassInput *)v3(56LL);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		  if ( !v5 )
		    goto LABEL_23;
		  v5->useScanLine = static_fields->s_useScanLine;
		  v5->useBlackBox = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useBlackBox;
		  v5->scanLineUseMask = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanLineUseMask;
		  v5->shouldDrawScanLineHighlight = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_shouldDrawScanlineHighlight;
		  v5->scanLineDataPack = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack;
		  s_scanlineMaskTex = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaskTex;
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v8 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v8 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  v9 = 0LL;
		  if ( !s_scanlineMaskTex )
		    goto LABEL_10;
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v8);
		  if ( s_scanlineMaskTex->fields._.m_CachedPtr )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    v18 = static_fields->s_scanlineMaskTex;
		    if ( !v18 )
		      goto LABEL_23;
		    m_CachedPtr = v18->fields._.m_CachedPtr;
		  }
		  else
		  {
		LABEL_10:
		    m_CachedPtr = 0LL;
		  }
		  v5->scanlineMaskTex = m_CachedPtr;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  s_blackBoxContourTex = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_blackBoxContourTex;
		  v12 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v12 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v12 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( s_blackBoxContourTex )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v12);
		    if ( s_blackBoxContourTex->fields._.m_CachedPtr )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      v19 = static_fields->s_blackBoxContourTex;
		      if ( v19 )
		      {
		        v9 = v19->fields._.m_CachedPtr;
		        goto LABEL_18;
		      }
		LABEL_23:
		      sub_1800D8260(static_fields, v4);
		    }
		  }
		LABEL_18:
		  v5->blackBoxContourTex = v9;
		  v13 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    v13 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  }
		  v5->highlightDataPack = &v13->static_fields->s_highlightDataPack;
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		  s_HighlightMat = static_fields->s_HighlightMat;
		  if ( !s_HighlightMat )
		    goto LABEL_23;
		  v5->highlightMaterial = s_HighlightMat->fields._.m_CachedPtr;
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		  s_HighlightMesh = static_fields->s_HighlightMesh;
		  if ( !s_HighlightMesh )
		    goto LABEL_23;
		  v5->highlightMesh = s_HighlightMesh->fields._.m_CachedPtr;
		  return v5;
		}
		
		public static void UpdateDataPack(HGCamera hgCamera) {} // 0x0000000183A15BA0-0x0000000183A160A0
		// Void UpdateDataPack(HGCamera)
		void HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(HGCamera *hgCamera, MethodInfo *method)
		{
		  void *v3; // rcx
		  VFXPPScanLinePass__StaticFields *codeGenModule; // rdx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  Object *m_hgScanLine; // r14
		  HGCamera_VolumeComponentsData *v7; // rax
		  Object *m_hgBlackBox; // rbp
		  struct Object_1__Class *v9; // rax
		  int v10; // esi
		  Object__Class *klass; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  unsigned __int8 HasInstantiation; // al
		  int v14; // ebx
		  struct VFXPPScanLinePass__Class *v15; // rax
		  struct Object_1__Class *v16; // rcx
		  Object__Class *v17; // rbx
		  bool (*v18)(RuntimeType *, MethodInfo *); // r8
		  unsigned __int8 v19; // al
		  struct VFXPPScanLinePass__Class *v20; // rax
		  const char *name; // rax
		  char v22; // al
		  const char *v23; // rax
		  char v24; // al
		  const char *v25; // rax
		  const char *v26; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v28; // rax
		  ILFixDynamicMethodWrapper_2 *v29; // rax
		  ILFixDynamicMethodWrapper_2 *v30; // rax
		  double v31; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v32; // rax
		  Material *v33; // rbx
		  struct HGShaderKeyWords__Class *v34; // rax
		  HGShaderKeyWords__StaticFields *static_fields; // rax
		  MonitorData *monitor; // r8
		  _OWORD *v37; // rax
		  char v38; // al
		  __int64 v39; // rax
		  HGRuntimeGrassQuery_Node *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  struct VFXPPScanLinePass__Class *v43; // rcx
		  Texture *v44; // rbx
		  VFXPPScanLinePass__StaticFields *v45; // rbx
		  VFXPPScanLinePass__StaticFields *v46; // rbx
		  VFXPPScanLinePass__StaticFields *v47; // rbx
		  VFXPPScanLinePass__StaticFields *v48; // rbx
		  MonitorData *v49; // r8
		  _OWORD *v50; // rax
		  VFXPPScanLinePass__StaticFields *v51; // rbx
		  double v52; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v53; // rbx
		  double v54; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v55; // rbx
		  double v56; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v57; // rbx
		  double v58; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v59; // rbx
		  double v60; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v61; // rbx
		  double v62; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v63; // rbx
		  double v64; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v65; // rbx
		  double v66; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v67; // rbx
		  double v68; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v69; // rbx
		  double v70; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v71; // rbx
		  double v72; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v73; // rbx
		  double v74; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v75; // rbx
		  double v76; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v77; // rbx
		  double v78; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v79; // rbx
		  double v80; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v81; // rbx
		  double v82; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v83; // rbx
		  double v84; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v85; // rbx
		  double v86; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v87; // rbx
		  double v88; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v89; // rbx
		  double v90; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v91; // rbx
		  double v92; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v93; // rbx
		  double v94; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v95; // rbx
		  double v96; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v97; // rbx
		  double v98; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v99; // rbx
		  double v100; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v101; // rbx
		  double v102; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v103; // rbx
		  double v104; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v105; // rbx
		  double v106; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v107; // rbx
		  double v108; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v109; // rbx
		  double v110; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v111; // rbx
		  double v112; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v113; // rbx
		  double v114; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v115; // rbx
		  double v116; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v117; // rbx
		  double v118; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v119; // rbx
		  double v120; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v121; // rbx
		  double v122; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v123; // rbx
		  double v124; // xmm0_8
		  Object__Class *v125; // r8
		  _OWORD *v126; // rax
		  MonitorData *v127; // r8
		  _OWORD *v128; // rax
		  Object__Class *v129; // r8
		  _OWORD *v130; // rax
		  Object__Class *v131; // r8
		  _OWORD *v132; // rax
		  MonitorData *v133; // r8
		  bool ShouldRequestVerticalOcclusionMap; // al
		  __int64 v135; // rbx
		  double v136; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v137; // rbx
		  double v138; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v139; // rbx
		  double v140; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v141; // rbx
		  double v142; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v143; // rbx
		  double v144; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v145; // rbx
		  double v146; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v147; // rbx
		  double v148; // xmm0_8
		  double v149; // xmm0_8
		  MonitorData *v150; // r8
		  _OWORD *v151; // rax
		  MonitorData *v152; // r8
		  _OWORD *v153; // rax
		  Object__Class *v154; // r8
		  _OWORD *v155; // rax
		  VFXPPScanLinePass__StaticFields *v156; // rbx
		  double v157; // xmm0_8
		  float v158; // xmm6_4
		  double v159; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v160; // rbx
		  double v161; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v162; // rbx
		  double v163; // xmm0_8
		  float v164; // xmm6_4
		  double v165; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v166; // rbx
		  double v167; // xmm0_8
		  VFXPPScanLinePass__StaticFields *v168; // rbx
		  VFXPPScanLinePass__StaticFields *v169; // rbx
		  VFXPPScanLinePass__StaticFields *v170; // rbx
		  VFXPPScanLinePass__StaticFields *v171; // rbx
		  VFXPPScanLinePass__StaticFields *v172; // rbx
		  VFXPPScanLinePass__StaticFields *v173; // rbx
		  VFXPPScanLinePass__StaticFields *v174; // rbx
		  VFXPPScanLinePass__StaticFields *v175; // rbx
		  VFXPPScanLinePass__StaticFields *v176; // rbx
		  VFXPPScanLinePass__StaticFields *v177; // rbx
		  VFXPPScanLinePass__StaticFields *v178; // rbx
		  VFXPPScanLinePass__StaticFields *v179; // rbx
		  __int64 v180; // rax
		  HGRuntimeGrassQuery_Node *v181; // rdx
		  HGRuntimeGrassQuery_Node *v182; // r8
		  Int32__Array **v183; // r9
		  VFXPPScanLinePass__StaticFields *v184; // rbx
		  struct VFXPPScanLinePass__Class *v185; // rax
		  VFXPPScanLinePass__StaticFields *v186; // rbx
		  struct VFXPPScanLinePass__Class *v187; // rax
		  VFXPPScanLinePass__StaticFields *v188; // rbx
		  struct VFXPPScanLinePass__Class *v189; // rax
		  VFXPPScanLinePass__StaticFields *v190; // rbx
		  VFXPPScanLinePass__StaticFields *v191; // rbx
		  MethodInfo *v192[2]; // [rsp+20h] [rbp-48h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		  if ( !codeGenModule )
		    goto LABEL_82;
		  if ( SLODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) > 2561 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		    if ( !codeGenModule )
		      goto LABEL_82;
		    if ( LODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 0xA01 )
		      goto LABEL_124;
		    if ( *(_QWORD *)&codeGenModule[37].s_slDataPack.blackBoxContourColor.r )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2561, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)hgCamera, 0LL);
		        return;
		      }
		      goto LABEL_82;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_82;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		  if ( !codeGenModule )
		    goto LABEL_82;
		  if ( SLODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 783 )
		    goto LABEL_10;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		  if ( !codeGenModule )
		    goto LABEL_82;
		  if ( LODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 0x30F )
		    goto LABEL_124;
		  if ( *(_QWORD *)&codeGenModule[11].s_slDataPack.scanlineParams2.x )
		  {
		    v28 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v28 )
		      goto LABEL_82;
		    m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v28, (Object *)hgCamera, 0LL);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    m_volumeComponentsData = hgCamera->fields.m_volumeComponentsData;
		  }
		  if ( !m_volumeComponentsData )
		    goto LABEL_82;
		  m_hgScanLine = (Object *)m_volumeComponentsData->fields.m_hgScanLine;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		  if ( !codeGenModule )
		    goto LABEL_82;
		  if ( SLODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 783 )
		    goto LABEL_16;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		  if ( !codeGenModule )
		    goto LABEL_82;
		  if ( LODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 0x30F )
		    goto LABEL_124;
		  if ( *(_QWORD *)&codeGenModule[11].s_slDataPack.scanlineParams2.x )
		  {
		    v29 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v29 )
		      goto LABEL_82;
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v29, (Object *)hgCamera, 0LL);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_16:
		    v7 = hgCamera->fields.m_volumeComponentsData;
		  }
		  if ( !v7 )
		    goto LABEL_82;
		  m_hgBlackBox = (Object *)v7->fields.m_hgBlackBox;
		  v9 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v9 = TypeInfo::UnityEngine::Object;
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  v10 = 0;
		  if ( m_hgScanLine )
		  {
		    if ( !v9->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( m_hgScanLine[1].klass )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		      if ( !codeGenModule )
		        goto LABEL_82;
		      if ( SLODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) > 2562 )
		      {
		        if ( !*((_DWORD *)v3 + 56) )
		        {
		          il2cpp_runtime_class_init_1(v3);
		          v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		        if ( !codeGenModule )
		          goto LABEL_82;
		        if ( LODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 0xA02 )
		          goto LABEL_124;
		        if ( *(_QWORD *)&codeGenModule[37].s_slDataPack.blackBoxContourColor.b )
		        {
		          v30 = IFix::WrappersManagerImpl::GetPatch(2562, 0LL);
		          if ( !v30 )
		            goto LABEL_82;
		          HasInstantiation = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                               (ILFixDynamicMethodWrapper_20 *)v30,
		                               m_hgScanLine,
		                               0LL);
		LABEL_33:
		          v14 = HasInstantiation;
		          goto LABEL_34;
		        }
		      }
		      klass = m_hgScanLine[3].klass;
		      if ( !klass )
		        goto LABEL_82;
		      sub_1800049A0(klass->_0.image);
		      nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))klass->_0.image[6].nameToClassHashTable;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)klass->_0.image[6].codeGenModule;
		      if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		      {
		        name = klass->_0.name;
		        if ( (*((_DWORD *)name + 2) & 0x20000000) != 0 )
		          goto LABEL_77;
		        v22 = name[10];
		        if ( v22 == 29 || v22 == 16 || v22 == 20 || v22 == 15 )
		          goto LABEL_77;
		      }
		      else
		      {
		        if ( nameToClassHashTable == System::RuntimeType::get_IsGenericType )
		        {
		          HasInstantiation = System::RuntimeTypeHandle::HasInstantiation(klass, codeGenModule);
		          goto LABEL_32;
		        }
		        if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		        {
		          HasInstantiation = ((__int64 (__fastcall *)(Object__Class *, VFXPPScanLinePass__StaticFields *))nameToClassHashTable)(
		                               klass,
		                               codeGenModule);
		          goto LABEL_32;
		        }
		        v25 = klass->_0.name;
		        if ( (*((_DWORD *)v25 + 2) & 0x20000000) == 0 && (v25[10] == 19 || v25[10] == 30) )
		        {
		LABEL_77:
		          HasInstantiation = 1;
		LABEL_32:
		          if ( HasInstantiation )
		          {
		            codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[7].monitor;
		            if ( !codeGenModule )
		              goto LABEL_82;
		            LOWORD(v3) = 10;
		            v31 = sub_1800057D0(v3, codeGenModule);
		            HasInstantiation = *(float *)&v31 > 0.0;
		          }
		          goto LABEL_33;
		        }
		      }
		      HasInstantiation = 0;
		      goto LABEL_32;
		    }
		  }
		  v14 = 0;
		LABEL_34:
		  v15 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    v15 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  }
		  v15->static_fields->s_useScanLine = v14 != 0;
		  v16 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v16 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v16 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_hgBlackBox )
		  {
		    if ( !v16->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v16);
		    if ( m_hgBlackBox[1].klass )
		    {
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)**((_QWORD **)v3 + 23);
		      if ( !codeGenModule )
		        goto LABEL_82;
		      if ( SLODWORD(codeGenModule->s_vfxPPScanLinePassInput.scanlineMaskTex) <= 2563 )
		        goto LABEL_45;
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v3 = (void *)**((_QWORD **)v3 + 23);
		      if ( !v3 )
		        goto LABEL_82;
		      if ( *((_DWORD *)v3 + 6) > 0xA03u )
		      {
		        if ( *((_QWORD *)v3 + 2567) )
		        {
		          v32 = IFix::WrappersManagerImpl::GetPatch(2563, 0LL);
		          if ( !v32 )
		            goto LABEL_82;
		          v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v32, m_hgBlackBox, 0LL);
		LABEL_51:
		          v10 = v19;
		          goto LABEL_52;
		        }
		LABEL_45:
		        v17 = m_hgBlackBox[3].klass;
		        if ( !v17 )
		          goto LABEL_82;
		        sub_1800049A0(v17->_0.image);
		        v18 = (bool (*)(RuntimeType *, MethodInfo *))v17->_0.image[6].nameToClassHashTable;
		        codeGenModule = (VFXPPScanLinePass__StaticFields *)v17->_0.image[6].codeGenModule;
		        if ( v18 == System::RuntimeType::HasElementTypeImpl )
		        {
		          v23 = v17->_0.name;
		          if ( (*((_DWORD *)v23 + 2) & 0x20000000) != 0 )
		            goto LABEL_81;
		          v24 = v23[10];
		          if ( v24 == 29 || v24 == 16 || v24 == 20 || v24 == 15 )
		            goto LABEL_81;
		        }
		        else
		        {
		          if ( v18 == System::RuntimeType::get_IsGenericType )
		          {
		            v19 = System::RuntimeTypeHandle::HasInstantiation(v17, codeGenModule);
		            goto LABEL_50;
		          }
		          if ( v18 != System::RuntimeType::get_IsGenericParameter )
		          {
		            v19 = ((__int64 (__fastcall *)(Object__Class *, VFXPPScanLinePass__StaticFields *))v18)(v17, codeGenModule);
		            goto LABEL_50;
		          }
		          v26 = v17->_0.name;
		          if ( (*((_DWORD *)v26 + 2) & 0x20000000) == 0 && (v26[10] == 19 || v26[10] == 30) )
		          {
		LABEL_81:
		            v19 = 1;
		LABEL_50:
		            if ( v19 )
		            {
		              codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[3].monitor;
		              if ( !codeGenModule )
		                goto LABEL_82;
		              v19 = sub_180006280(10LL, codeGenModule);
		            }
		            goto LABEL_51;
		          }
		        }
		        v19 = 0;
		        goto LABEL_50;
		      }
		LABEL_124:
		      sub_1800D2AB0(v3, codeGenModule);
		    }
		  }
		LABEL_52:
		  v20 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    v20 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  }
		  v20->static_fields->s_useBlackBox = v10 != 0;
		  v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    }
		    v33 = *(Material **)(*((_QWORD *)v3 + 23) + 464LL);
		    v34 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      v34 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords;
		    }
		    static_fields = v34->static_fields;
		    if ( !v33 )
		      goto LABEL_82;
		    UnityEngine::Material::EnableKeyword(v33, static_fields->s_UseScanLine, 0LL);
		    if ( !m_hgScanLine )
		      goto LABEL_82;
		    monitor = m_hgScanLine[4].monitor;
		    if ( !monitor )
		      goto LABEL_82;
		    v37 = (_OWORD *)sub_180032E40(v192, 10LL, monitor);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 18) = *v37;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[5].monitor;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v38 = sub_180006280(10LL, codeGenModule);
		    codeGenModule = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    codeGenModule->s_scanLineUseMask = v38;
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanLineUseMask )
		    {
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[6].klass;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v39 = sub_1800460A0(10LL, codeGenModule);
		      v43 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      v44 = (Texture *)v39;
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v43 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      }
		      v43->static_fields->s_scanlineMaskTex = v44;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaskTex,
		        v40,
		        v41,
		        v42,
		        v192[0]);
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[6].monitor;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v45 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      LODWORD(v45->s_slDataPack.scanlineParams5.x) = sub_180041350(10LL);
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[6].monitor;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v46 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      LODWORD(v46->s_slDataPack.scanlineParams5.y) = (unsigned __int64)sub_180041350(10LL) >> 32;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[7].klass;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v47 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      LODWORD(v47->s_slDataPack.scanlineParams5.z) = sub_180041350(10LL);
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[7].klass;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v48 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      LODWORD(v48->s_slDataPack.scanlineParams5.w) = (unsigned __int64)sub_180041350(10LL) >> 32;
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    }
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    v49 = m_hgScanLine[3].monitor;
		    if ( !v49 )
		      goto LABEL_82;
		    v50 = (_OWORD *)sub_180032E40(v192, 10LL, v49);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 12) = *v50;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[4].klass;
		    v51 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v52 = sub_1800057D0(10LL, codeGenModule);
		    v51->s_slDataPack.scanLineCenterPos.w = *(float *)&v52;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[8].klass;
		    v53 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v54 = sub_1800057D0(10LL, codeGenModule);
		    v53->s_slDataPack.scanlineParams1.x = *(float *)&v54;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[7].monitor;
		    v55 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v56 = sub_1800057D0(10LL, codeGenModule);
		    v55->s_slDataPack.scanlineParams1.y = *(float *)&v56;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[8].monitor;
		    v57 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v58 = sub_1800057D0(10LL, codeGenModule);
		    v57->s_slDataPack.scanlineParams1.z = *(float *)&v58;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[9].klass;
		    v59 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v60 = sub_1800057D0(10LL, codeGenModule);
		    v59->s_slDataPack.scanlineParams1.w = *(float *)&v60;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[14].klass;
		    v61 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v62 = sub_1800057D0(10LL, codeGenModule);
		    v61->s_slDataPack.scanlineParams2.x = *(float *)&v62;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[9].monitor;
		    v63 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v64 = sub_1800057D0(10LL, codeGenModule);
		    v63->s_slDataPack.scanlineParams2.y = *(float *)&v64;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[10].klass;
		    v65 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v66 = sub_1800057D0(10LL, codeGenModule);
		    v65->s_slDataPack.scanlineParams2.z = *(float *)&v66;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[5].klass;
		    v67 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v68 = sub_1800057D0(10LL, codeGenModule);
		    v67->s_slDataPack.scanlineParams2.w = *(float *)&v68;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[10].monitor;
		    v69 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v70 = sub_1800057D0(10LL, codeGenModule);
		    v69->s_slDataPack.scanlineParams3.x = *(float *)&v70;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[11].klass;
		    v71 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v72 = sub_1800057D0(10LL, codeGenModule);
		    v71->s_slDataPack.scanlineParams3.y = *(float *)&v72;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[11].monitor;
		    v73 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v74 = sub_1800057D0(10LL, codeGenModule);
		    v73->s_slDataPack.scanlineParams3.z = *(float *)&v74;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[12].monitor;
		    v75 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v76 = sub_1800057D0(10LL, codeGenModule);
		    v75->s_slDataPack.scanlineParams3.w = *(float *)&v76;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[13].klass;
		    v77 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v78 = sub_1800057D0(10LL, codeGenModule);
		    v77->s_slDataPack.scanlineParams4.x = *(float *)&v78;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[13].monitor;
		    v79 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v80 = sub_1800057D0(10LL, codeGenModule);
		    v79->s_slDataPack.scanlineParams4.y = *(float *)&v80;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[12].klass;
		    v81 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v82 = sub_1800057D0(10LL, codeGenModule);
		    v81->s_slDataPack.scanlineParams4.z = *(float *)&v82;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[14].monitor;
		    v83 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v84 = sub_1800057D0(10LL, codeGenModule);
		    v83->s_slDataPack.scanlineParams4.w = *(float *)&v84;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[15].klass;
		    v85 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v86 = sub_1800057D0(10LL, codeGenModule);
		    v85->s_slDataPack.scanlineParams6.x = *(float *)&v86;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[15].monitor;
		    v87 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v88 = sub_1800057D0(10LL, codeGenModule);
		    v87->s_slDataPack.scanlineParams6.y = *(float *)&v88;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[16].klass;
		    v89 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v90 = sub_1800057D0(10LL, codeGenModule);
		    v89->s_slDataPack.scanlineParams6.z = *(float *)&v90;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[16].monitor;
		    v91 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v92 = sub_1800057D0(10LL, codeGenModule);
		    v91->s_slDataPack.scanlineParams6.w = *(float *)&v92;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[17].klass;
		    v93 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v94 = sub_1800057D0(10LL, codeGenModule);
		    v93->s_slDataPack.scanlineParams7.x = *(float *)&v94;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[17].monitor;
		    v95 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v96 = sub_1800057D0(10LL, codeGenModule);
		    v95->s_slDataPack.scanlineParams7.y = *(float *)&v96;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[18].klass;
		    v97 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v98 = sub_1800057D0(10LL, codeGenModule);
		    v97->s_slDataPack.scanlineParams7.z = *(float *)&v98;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[23].monitor;
		    v99 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v100 = sub_1800057D0(10LL, codeGenModule);
		    v99->s_slDataPack.scanlineParams7.w = *(float *)&v100;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[18].monitor;
		    v101 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v102 = sub_1800057D0(10LL, codeGenModule);
		    v101->s_slDataPack.scanlineParams8.x = *(float *)&v102;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[19].klass;
		    v103 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v104 = sub_1800057D0(10LL, codeGenModule);
		    v103->s_slDataPack.scanlineParams8.y = *(float *)&v104;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[19].monitor;
		    v105 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v106 = sub_1800057D0(10LL, codeGenModule);
		    v105->s_slDataPack.scanlineParams8.z = *(float *)&v106;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[20].klass;
		    v107 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v108 = sub_1800057D0(10LL, codeGenModule);
		    v107->s_slDataPack.scanlineParams8.w = *(float *)&v108;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[20].monitor;
		    v109 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v110 = sub_1800057D0(10LL, codeGenModule);
		    v109->s_slDataPack.scanlineParams9.x = *(float *)&v110;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[21].klass;
		    v111 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v112 = sub_1800057D0(10LL, codeGenModule);
		    v111->s_slDataPack.scanlineParams9.y = *(float *)&v112;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[21].monitor;
		    v113 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v114 = sub_1800057D0(10LL, codeGenModule);
		    v113->s_slDataPack.scanlineParams9.z = *(float *)&v114;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[22].klass;
		    v115 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v116 = sub_1800057D0(10LL, codeGenModule);
		    v115->s_slDataPack.scanlineParams9.w = *(float *)&v116;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[22].monitor;
		    v117 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v118 = sub_1800057D0(10LL, codeGenModule);
		    v117->s_slDataPack.scanlineParams10.x = *(float *)&v118;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[23].klass;
		    v119 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v120 = sub_1800057D0(10LL, codeGenModule);
		    v119->s_slDataPack.scanlineParams10.y = *(float *)&v120;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[23].klass;
		    v121 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v122 = sub_1800057D0(10LL, codeGenModule);
		    v121->s_slDataPack.scanlineParams10.z = *(float *)&v122;
		    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[28].monitor;
		    v123 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    if ( !codeGenModule )
		      goto LABEL_82;
		    v124 = sub_1800057D0(10LL, codeGenModule);
		    v123->s_slDataPack.scanlineParams10.w = *(float *)&v124;
		    v125 = m_hgScanLine[27].klass;
		    if ( !v125 )
		      goto LABEL_82;
		    v126 = (_OWORD *)sub_180032E40(v192, 10LL, v125);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 26) = *v126;
		    v127 = m_hgScanLine[27].monitor;
		    if ( !v127 )
		      goto LABEL_82;
		    v128 = (_OWORD *)sub_180032E40(v192, 10LL, v127);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 27) = *v128;
		    v129 = m_hgScanLine[28].klass;
		    if ( !v129 )
		      goto LABEL_82;
		    v130 = (_OWORD *)sub_180032E40(v192, 10LL, v129);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 28) = *v130;
		    v131 = m_hgScanLine[26].klass;
		    if ( !v131 )
		      goto LABEL_82;
		    v132 = (_OWORD *)sub_180032E40(v192, 10LL, v131);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    *((_OWORD *)v3 + 24) = *v132;
		    v133 = m_hgScanLine[26].monitor;
		    if ( !v133 )
		      goto LABEL_82;
		    TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineHighlightBeamTint = *(Color *)sub_180032E40(v192, 10LL, v133);
		    ShouldRequestVerticalOcclusionMap = HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(
		                                          hgCamera,
		                                          0LL);
		    codeGenModule = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		    codeGenModule->s_shouldDrawScanlineHighlight = ShouldRequestVerticalOcclusionMap;
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_shouldDrawScanlineHighlight )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      }
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[17].klass;
		      v135 = *((_QWORD *)v3 + 23);
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v136 = sub_1800057D0(10LL, codeGenModule);
		      *(_DWORD *)(v135 + 488) = LODWORD(v136);
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[17].monitor;
		      v137 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v138 = sub_1800057D0(10LL, codeGenModule);
		      v137->s_highlightDataPack.detectDistance.y = *(float *)&v138;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[18].klass;
		      v139 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v140 = sub_1800057D0(10LL, codeGenModule);
		      v139->s_highlightDataPack.detectDistance.z = *(float *)&v140;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[23].monitor;
		      v141 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v142 = sub_1800057D0(10LL, codeGenModule);
		      v141->s_highlightDataPack.detectDistance.w = *(float *)&v142;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[24].klass;
		      v143 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v144 = sub_1800057D0(10LL, codeGenModule);
		      v143->s_highlightDataPack.beamHeight.x = *(float *)&v144;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[24].monitor;
		      v145 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v146 = sub_1800057D0(10LL, codeGenModule);
		      v145->s_highlightDataPack.beamHeight.y = *(float *)&v146;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[25].klass;
		      v147 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v148 = sub_1800057D0(10LL, codeGenModule);
		      v147->s_highlightDataPack.beamHeight.z = *(float *)&v148;
		      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgScanLine[25].monitor;
		      if ( !codeGenModule )
		        goto LABEL_82;
		      v149 = sub_1800057D0(10LL, codeGenModule);
		      TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_highlightDataPack.meshHeight = *(float *)&v149;
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    }
		  }
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  }
		  if ( *(_BYTE *)(*((_QWORD *)v3 + 23) + 1LL) )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( m_hgBlackBox )
		    {
		      v150 = m_hgBlackBox[4].monitor;
		      if ( v150 )
		      {
		        v151 = (_OWORD *)sub_180032E40(v192, 10LL, v150);
		        v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		        *((_OWORD *)v3 + 5) = *v151;
		        v152 = m_hgBlackBox[6].monitor;
		        if ( v152 )
		        {
		          v153 = (_OWORD *)sub_180032E40(v192, 10LL, v152);
		          v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		          *((_OWORD *)v3 + 6) = *v153;
		          v154 = m_hgBlackBox[4].klass;
		          if ( v154 )
		          {
		            v155 = (_OWORD *)sub_180032E40(v192, 10LL, v154);
		            v3 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		            *((_OWORD *)v3 + 4) = *v155;
		            codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[6].klass;
		            v156 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		            if ( codeGenModule )
		            {
		              v157 = sub_1800057D0(10LL, codeGenModule);
		              codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[5].monitor;
		              v158 = *(float *)&v157;
		              if ( codeGenModule )
		              {
		                v159 = sub_1800057D0(10LL, codeGenModule);
		                v156->s_slDataPack.blackBoxParams1.x = *(float *)&v159 * v158;
		                codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[5].klass;
		                v160 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                if ( codeGenModule )
		                {
		                  v161 = sub_1800057D0(10LL, codeGenModule);
		                  v160->s_slDataPack.blackBoxParams1.y = *(float *)&v161;
		                  codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[8].klass;
		                  v162 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                  if ( codeGenModule )
		                  {
		                    v163 = sub_1800057D0(10LL, codeGenModule);
		                    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[7].monitor;
		                    v164 = *(float *)&v163;
		                    if ( codeGenModule )
		                    {
		                      v165 = sub_1800057D0(10LL, codeGenModule);
		                      v162->s_slDataPack.blackBoxParams1.z = *(float *)&v165 * v164;
		                      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[7].klass;
		                      v166 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                      if ( codeGenModule )
		                      {
		                        v167 = sub_1800057D0(10LL, codeGenModule);
		                        v166->s_slDataPack.blackBoxParams1.w = *(float *)&v167;
		                        codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[9].klass;
		                        if ( codeGenModule )
		                        {
		                          v168 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                          LODWORD(v168->s_slDataPack.blackBoxParams2.x) = sub_180041350(10LL);
		                          codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[9].klass;
		                          if ( codeGenModule )
		                          {
		                            v169 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                            LODWORD(v169->s_slDataPack.blackBoxParams2.y) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                            codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[9].monitor;
		                            if ( codeGenModule )
		                            {
		                              v170 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                              LODWORD(v170->s_slDataPack.blackBoxParams2.z) = sub_180041350(10LL);
		                              codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[9].monitor;
		                              if ( codeGenModule )
		                              {
		                                v171 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                LODWORD(v171->s_slDataPack.blackBoxParams2.w) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                                codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[10].klass;
		                                if ( codeGenModule )
		                                {
		                                  v172 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                  LODWORD(v172->s_slDataPack.blackBoxParams3.x) = sub_180041350(10LL);
		                                  codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[10].klass;
		                                  if ( codeGenModule )
		                                  {
		                                    v173 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                    LODWORD(v173->s_slDataPack.blackBoxParams3.y) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                                    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[10].monitor;
		                                    if ( codeGenModule )
		                                    {
		                                      v174 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                      LODWORD(v174->s_slDataPack.blackBoxParams3.z) = sub_180041350(10LL);
		                                      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[10].monitor;
		                                      if ( codeGenModule )
		                                      {
		                                        v175 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                        LODWORD(v175->s_slDataPack.blackBoxParams3.w) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                                        codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[11].monitor;
		                                        if ( codeGenModule )
		                                        {
		                                          v176 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                          LODWORD(v176->s_slDataPack.blackBoxParams4.x) = sub_180041350(10LL);
		                                          codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[11].monitor;
		                                          if ( codeGenModule )
		                                          {
		                                            v177 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                            LODWORD(v177->s_slDataPack.blackBoxParams4.y) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                                            codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[12].klass;
		                                            if ( codeGenModule )
		                                            {
		                                              v178 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                              LODWORD(v178->s_slDataPack.blackBoxParams4.z) = sub_180041350(10LL);
		                                              codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[12].klass;
		                                              if ( codeGenModule )
		                                              {
		                                                v179 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                                LODWORD(v179->s_slDataPack.blackBoxParams4.w) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                                                codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[8].monitor;
		                                                if ( codeGenModule )
		                                                {
		                                                  v180 = sub_1800460A0(10LL, codeGenModule);
		                                                  v181 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                                  v181[6].fields.left = (HGRuntimeGrassQuery_Node *)v180;
		                                                  sub_18002D1B0(
		                                                    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_blackBoxContourTex,
		                                                    v181,
		                                                    v182,
		                                                    v183,
		                                                    v192[0]);
		                                                  codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[12].monitor;
		                                                  if ( codeGenModule )
		                                                  {
		                                                    v184 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                                    v184->s_slDataPack.blackBoxParams5.x = (float)(unsigned __int8)sub_180006280(10LL, codeGenModule);
		                                                    v185 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		                                                    {
		                                                      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		                                                      v185 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                    }
		                                                    codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[13].klass;
		                                                    if ( codeGenModule )
		                                                    {
		                                                      v186 = v185->static_fields;
		                                                      v186->s_slDataPack.blackBoxParams5.y = (float)(unsigned __int8)sub_180006280(10LL, codeGenModule);
		                                                      v187 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		                                                      {
		                                                        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		                                                        v187 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                      }
		                                                      codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[13].monitor;
		                                                      if ( codeGenModule )
		                                                      {
		                                                        v188 = v187->static_fields;
		                                                        v188->s_slDataPack.blackBoxCenterPos.w = (float)(unsigned __int8)sub_180006280(10LL, codeGenModule);
		                                                        v189 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                        if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		                                                        {
		                                                          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		                                                          v189 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		                                                        }
		                                                        codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[11].klass;
		                                                        if ( codeGenModule )
		                                                        {
		                                                          v190 = v189->static_fields;
		                                                          LODWORD(v190->s_slDataPack.blackBoxParams5.z) = sub_180041350(10LL);
		                                                          codeGenModule = (VFXPPScanLinePass__StaticFields *)m_hgBlackBox[11].klass;
		                                                          if ( codeGenModule )
		                                                          {
		                                                            v191 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                                                            LODWORD(v191->s_slDataPack.blackBoxParams5.w) = (unsigned __int64)sub_180041350(10LL) >> 32;
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
		LABEL_82:
		    sub_1800D8260(v3, codeGenModule);
		  }
		}
		
		public static void DrawScanLineMaterial(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189B627EC-0x0000000189B63580
		// Void DrawScanLineMaterial(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanLineMaterial(
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Material *v5; // rbx
		  _OWORD *p_s_useScanLine; // rcx
		  void *static_fields; // rdx
		  Material *s_scanlineMaterial; // rbx
		  Material *v9; // rbx
		  Material *v10; // rbx
		  Material *v11; // rbx
		  int32_t v12; // edx
		  int32_t v13; // edx
		  int32_t v14; // edx
		  int32_t v15; // edx
		  int32_t v16; // edx
		  int32_t v17; // edx
		  int32_t v18; // edx
		  int32_t v19; // edx
		  int32_t v20; // edx
		  int32_t v21; // edx
		  int32_t v22; // edx
		  int32_t v23; // edx
		  int32_t v24; // edx
		  int32_t v25; // edx
		  int32_t v26; // edx
		  int32_t v27; // edx
		  int32_t v28; // edx
		  VFXPPScanLinePass__StaticFields *v29; // rax
		  Vector4 boxPosition1; // xmm1
		  __m128i v31; // xmm7
		  VFXPPScanLinePass__StaticFields *v32; // rax
		  Vector4 boxPosition2; // xmm1
		  __m128i v34; // xmm8
		  VFXPPScanLinePass__StaticFields *v35; // rax
		  Vector4 boxPosition3; // xmm1
		  __m128i v37; // xmm6
		  int32_t v38; // edx
		  int32_t v39; // edx
		  int32_t v40; // edx
		  Material *v41; // rbx
		  Material *v42; // rbx
		  Material *v43; // rbx
		  int32_t v44; // edx
		  int32_t v45; // edx
		  int32_t v46; // edx
		  int32_t v47; // edx
		  int32_t v48; // edx
		  int32_t v49; // edx
		  int32_t v50; // edx
		  int32_t v51; // edx
		  CommandBuffer *cmd; // rdi
		  Material *v53; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 scanLineCenterPos; // [rsp+38h] [rbp-9h] BYREF
		  __m128i blackBoxContourColor; // [rsp+48h] [rbp+7h] BYREF
		  Vector4 v57; // [rsp+58h] [rbp+17h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2564, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(hgCamera, 0LL);
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      s_scanlineMaterial = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !s_scanlineMaterial )
		        goto LABEL_53;
		      UnityEngine::Material::EnableKeyword(s_scanlineMaterial, *((String **)static_fields + 38), 0LL);
		      if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanLineUseMask )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v10 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v10 )
		          goto LABEL_53;
		        UnityEngine::Material::EnableKeyword(v10, *((String **)static_fields + 40), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        v9 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v9 )
		          goto LABEL_53;
		        UnityEngine::Material::DisableKeyword(v9, *((String **)static_fields + 40), 0LL);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      p_s_useScanLine = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine;
		      if ( !v11 )
		        goto LABEL_53;
		      v12 = *((_DWORD *)static_fields + 492);
		      scanLineCenterPos = (Vector4)p_s_useScanLine[18];
		      UnityEngine::Material::SetColor(v11, v12, (Color *)&scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      UnityEngine::Material::SetTextureImpl(
		        (Material *)p_s_useScanLine,
		        *((_DWORD *)static_fields + 493),
		        TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaskTex,
		        0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v13 = *((_DWORD *)static_fields + 494);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanLineCenterPos;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v13, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v14 = *((_DWORD *)static_fields + 495);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams1;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v14, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v15 = *((_DWORD *)static_fields + 496);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams2;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v15, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v16 = *((_DWORD *)static_fields + 497);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams3;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v16, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v17 = *((_DWORD *)static_fields + 498);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams4;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v17, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v18 = *((_DWORD *)static_fields + 499);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams5;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v18, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v19 = *((_DWORD *)static_fields + 507);
		      scanLineCenterPos = (Vector4)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineHighlightTint;
		      UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v19, (Color *)&scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v20 = *((_DWORD *)static_fields + 508);
		      scanLineCenterPos = (Vector4)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineHighlightBeamTint;
		      UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v20, (Color *)&scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v21 = *((_DWORD *)static_fields + 500);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams6;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v21, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v22 = *((_DWORD *)static_fields + 501);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams7;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v22, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v23 = *((_DWORD *)static_fields + 502);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams8;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v23, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v24 = *((_DWORD *)static_fields + 503);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams9;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v24, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v25 = *((_DWORD *)static_fields + 504);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams10;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v25, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v26 = *((_DWORD *)static_fields + 509);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.boxPosition1;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v26, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v27 = *((_DWORD *)static_fields + 510);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.boxPosition2;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v27, &scanLineCenterPos, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v28 = *((_DWORD *)static_fields + 511);
		      scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.boxPosition3;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v28, &scanLineCenterPos, 0LL);
		      v29 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      boxPosition1 = v29->s_slDataPack.boxPosition1;
		      scanLineCenterPos = v29->s_slDataPack.scanLineCenterPos;
		      blackBoxContourColor = (__m128i)boxPosition1;
		      v31 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
		                                               &v57,
		                                               (Vector4 *)&blackBoxContourColor,
		                                               &scanLineCenterPos,
		                                               0LL));
		      v32 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      boxPosition2 = v32->s_slDataPack.boxPosition2;
		      blackBoxContourColor = (__m128i)v32->s_slDataPack.scanLineCenterPos;
		      scanLineCenterPos = boxPosition2;
		      v34 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
		                                               &v57,
		                                               &scanLineCenterPos,
		                                               (Vector4 *)&blackBoxContourColor,
		                                               0LL));
		      v35 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		      boxPosition3 = v35->s_slDataPack.boxPosition3;
		      blackBoxContourColor = (__m128i)v35->s_slDataPack.scanLineCenterPos;
		      scanLineCenterPos = boxPosition3;
		      v37 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
		                                               &v57,
		                                               &scanLineCenterPos,
		                                               (Vector4 *)&blackBoxContourColor,
		                                               0LL));
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v38 = *((_DWORD *)static_fields + 512);
		      blackBoxContourColor = v31;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v38, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v39 = *((_DWORD *)static_fields + 513);
		      blackBoxContourColor = v34;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v39, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v40 = *((_DWORD *)static_fields + 514);
		      blackBoxContourColor = v37;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v40, (Vector4 *)&blackBoxContourColor, 0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !v5 )
		        goto LABEL_53;
		      UnityEngine::Material::DisableKeyword(v5, *((String **)static_fields + 38), 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useBlackBox )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v42 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !v42 )
		        goto LABEL_53;
		      UnityEngine::Material::EnableKeyword(v42, *((String **)static_fields + 39), 0LL);
		      v43 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      p_s_useScanLine = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine;
		      if ( !v43 )
		        goto LABEL_53;
		      v44 = *((_DWORD *)static_fields + 517);
		      blackBoxContourColor = *((__m128i *)p_s_useScanLine + 5);
		      UnityEngine::Material::SetColor(v43, v44, (Color *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v45 = *((_DWORD *)static_fields + 518);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxContourColor;
		      UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v45, (Color *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v46 = *((_DWORD *)static_fields + 519);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxCenterPos;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v46, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v47 = *((_DWORD *)static_fields + 520);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxParams1;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v47, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v48 = *((_DWORD *)static_fields + 521);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxParams2;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v48, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v49 = *((_DWORD *)static_fields + 522);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxParams3;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v49, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v50 = *((_DWORD *)static_fields + 523);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxParams4;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v50, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      v51 = *((_DWORD *)static_fields + 524);
		      blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.blackBoxParams5;
		      UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v51, (Vector4 *)&blackBoxContourColor, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !p_s_useScanLine )
		        goto LABEL_53;
		      UnityEngine::Material::SetTextureImpl(
		        (Material *)p_s_useScanLine,
		        *((_DWORD *)static_fields + 525),
		        TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_blackBoxContourTex,
		        0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      v41 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !v41 )
		        goto LABEL_53;
		      UnityEngine::Material::DisableKeyword(v41, *((String **)static_fields + 39), 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useBlackBox )
		        goto LABEL_51;
		    }
		    if ( ctx )
		    {
		      cmd = ctx->fields.cmd;
		      sub_1800036A0(p_s_useScanLine);
		      v53 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_scanlineMaterial;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, v53, 0LL, 0, 0LL);
		      p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		LABEL_51:
		      sub_1800036A0(p_s_useScanLine);
		      HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanlineHighlight(ctx, 0LL);
		      return;
		    }
		LABEL_53:
		    sub_1800D8260(p_s_useScanLine, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2564, 0LL);
		  if ( !Patch )
		    goto LABEL_53;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)ctx,
		    (Object *)hgCamera,
		    0LL);
		}
		
		public static void DrawScanlineHighlight(HGRenderGraphContext ctx) {} // 0x0000000189B63580-0x0000000189B63960
		// Void DrawScanlineHighlight(HGRenderGraphContext)
		void HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanlineHighlight(HGRenderGraphContext *ctx, MethodInfo *method)
		{
		  MaterialPropertyBlock *s_materialPropertyBlock; // rbx
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  MaterialPropertyBlock *v5; // rcx
		  int32_t ScanLineHighlightBeamTint; // edx
		  int32_t ScanLineParams1; // edx
		  int32_t ScanLineParams8; // edx
		  int32_t ScanLineParams9; // edx
		  int32_t ScanLineParams10; // edx
		  int32_t ScanLineCenterPos; // edx
		  VFXPPScanLinePass__StaticFields *v12; // rax
		  __int128 v13; // xmm1
		  Vector4 v14; // xmm0
		  Vector4 v15; // xmm1
		  Vector4 boxPosition1; // xmm0
		  VFXPPScanLinePass__StaticFields *v17; // rax
		  __int128 v18; // xmm1
		  Vector4 v19; // xmm0
		  Vector4 v20; // xmm1
		  Vector4 boxPosition2; // xmm0
		  VFXPPScanLinePass__StaticFields *v22; // rax
		  __int128 v23; // xmm1
		  Vector4 v24; // xmm0
		  Vector4 v25; // xmm1
		  Vector4 boxPosition3; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v28; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v29; // [rsp+40h] [rbp-40h] BYREF
		  Vector4 v30; // [rsp+50h] [rbp-30h] BYREF
		  HighlightDataPack v31; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2565, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2565, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)ctx, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_useScanLine )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		      if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_shouldDrawScanlineHighlight )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        s_materialPropertyBlock = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        v5 = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		        if ( s_materialPropertyBlock )
		        {
		          ScanLineHighlightBeamTint = static_fields->_ScanLineHighlightBeamTint;
		          v28 = *(Vector4 *)&v5[16].fields.m_Ptr;
		          UnityEngine::MaterialPropertyBlock::SetColor(
		            s_materialPropertyBlock,
		            ScanLineHighlightBeamTint,
		            (Color *)&v28,
		            0LL);
		          v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          if ( v5 )
		          {
		            ScanLineParams1 = static_fields->_ScanLineParams1;
		            v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams1;
		            UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams1, &v28, 0LL);
		            v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( v5 )
		            {
		              ScanLineParams8 = static_fields->_ScanLineParams8;
		              v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams8;
		              UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams8, &v28, 0LL);
		              v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              if ( v5 )
		              {
		                ScanLineParams9 = static_fields->_ScanLineParams9;
		                v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams9;
		                UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams9, &v28, 0LL);
		                v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                if ( v5 )
		                {
		                  ScanLineParams10 = static_fields->_ScanLineParams10;
		                  v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanlineParams10;
		                  UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams10, &v28, 0LL);
		                  v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_materialPropertyBlock;
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  if ( v5 )
		                  {
		                    ScanLineCenterPos = static_fields->_ScanLineCenterPos;
		                    v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_slDataPack.scanLineCenterPos;
		                    UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineCenterPos, &v28, 0LL);
		                    v12 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                    v13 = *(_OWORD *)&v12->s_highlightDataPack.beamHeight.x;
		                    v31.detectDistance = v12->s_highlightDataPack.detectDistance;
		                    v14 = v12->s_slDataPack.scanlineParams1;
		                    *(_OWORD *)&v31.beamHeight.x = v13;
		                    v15 = v12->s_slDataPack.scanLineCenterPos;
		                    v28 = v14;
		                    boxPosition1 = v12->s_slDataPack.boxPosition1;
		                    v29 = v15;
		                    v30 = boxPosition1;
		                    HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v30, &v29, &v28, &v31, ctx, 0LL);
		                    v17 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                    v18 = *(_OWORD *)&v17->s_highlightDataPack.beamHeight.x;
		                    v31.detectDistance = v17->s_highlightDataPack.detectDistance;
		                    v19 = v17->s_slDataPack.scanlineParams1;
		                    *(_OWORD *)&v31.beamHeight.x = v18;
		                    v20 = v17->s_slDataPack.scanLineCenterPos;
		                    v30 = v19;
		                    boxPosition2 = v17->s_slDataPack.boxPosition2;
		                    v29 = v20;
		                    v28 = boxPosition2;
		                    HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v28, &v29, &v30, &v31, ctx, 0LL);
		                    v22 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields;
		                    v23 = *(_OWORD *)&v22->s_highlightDataPack.beamHeight.x;
		                    v31.detectDistance = v22->s_highlightDataPack.detectDistance;
		                    v24 = v22->s_slDataPack.scanlineParams1;
		                    *(_OWORD *)&v31.beamHeight.x = v23;
		                    v25 = v22->s_slDataPack.scanLineCenterPos;
		                    v30 = v24;
		                    boxPosition3 = v22->s_slDataPack.boxPosition3;
		                    v29 = v25;
		                    v28 = boxPosition3;
		                    HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v28, &v29, &v30, &v31, ctx, 0LL);
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_12:
		        sub_1800D8260(v5, static_fields);
		      }
		    }
		  }
		}
		
		public static bool CheckRuntimeResources() => default; // 0x0000000189B6274C-0x0000000189B627EC
		// Boolean CheckRuntimeResources()
		bool HG::Rendering::Runtime::VFXPPScanLinePass::CheckRuntimeResources(MethodInfo *method)
		{
		  Object_1 *s_HighlightMesh; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2566, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2566, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    s_HighlightMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    LOBYTE(s_HighlightMesh) = UnityEngine::Object::op_Inequality(0LL, s_HighlightMesh, 0LL);
		    return (unsigned __int8)s_HighlightMesh & UnityEngine::Object::op_Inequality(
		                                                0LL,
		                                                (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat,
		                                                0LL);
		  }
		}
		
		public static void Release() {} // 0x0000000184CE2320-0x0000000184CE2400
		// Void Release()
		void HG::Rendering::Runtime::VFXPPScanLinePass::Release(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct VFXPPScanLinePass__Class *v2; // rax
		  MaterialPropertyBlock *s_materialPropertyBlock; // rcx
		  Object_1 *s_HighlightMat; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(525, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(525, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(s_materialPropertyBlock, v1);
		  }
		  v2 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		    v2 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
		  }
		  s_materialPropertyBlock = v2->static_fields->s_materialPropertyBlock;
		  if ( !s_materialPropertyBlock )
		    goto LABEL_8;
		  UnityEngine::MaterialPropertyBlock::Clear(s_materialPropertyBlock, 1, 0LL);
		  s_HighlightMat = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat;
		  if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  UnityEngine::Rendering::CoreUtils::Destroy(s_HighlightMat, 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->static_fields->s_HighlightMat,
		    v5,
		    v6,
		    v7,
		    v9);
		}
		
	}
}
