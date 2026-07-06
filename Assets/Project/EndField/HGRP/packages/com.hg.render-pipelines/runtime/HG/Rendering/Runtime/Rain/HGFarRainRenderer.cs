using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.Rain
{
	public class HGFarRainRenderer : HGBaseSubRainRenderer
	{
		public HGFarRainRenderer()
		{
			// // HGFarRainRenderer()
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::HGFarRainRenderer(HGFarRainRenderer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   MaterialPropertyBlock *v5; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v6; // rdx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   MaterialPropertyBlock *v9; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Bounds *v11; // r8
			//   Object__Array *v12; // r9
			//   MaterialPropertyBlock *v13; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   HGFarRainRenderer_FarRainRenderParams *v17; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v18; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v19; // rdx
			//   Bounds *v20; // r8
			//   Object__Array *v21; // r9
			//   TileBase *v22; // rdx
			//   Vector3Int *v23; // r8
			//   ITilemap *v24; // r9
			//   __int64 v25; // rdx
			//   TileAnimationData v26; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC34 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer::FarRainRenderParams);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     byte_18D8EDC34 = 1;
			//   }
			//   *(_QWORD *)&this.fields.m_farRainSpindleMeshExtents.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.fields.m_farRainSpindleMeshExtents.z = 0.0;
			//   v5 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v5 )
			//     goto LABEL_10;
			//   v5.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_farRainmaterialPropertyBlock = v5;
			//   sub_1800054D0(
			//     (BSP *)&this.fields.m_farRainmaterialPropertyBlock,
			//     v6,
			//     v7,
			//     v8,
			//     (MethodInfo *)v26.m_AnimatedSprites,
			//     *(MethodInfo **)&v26.m_AnimationSpeed);
			//   v9 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v9 )
			//     goto LABEL_10;
			//   v9.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_middleRainmaterialPropertyBlock = v9;
			//   sub_1800054D0(
			//     (BSP *)&this.fields.m_middleRainmaterialPropertyBlock,
			//     v10,
			//     v11,
			//     v12,
			//     (MethodInfo *)v26.m_AnimatedSprites,
			//     *(MethodInfo **)&v26.m_AnimationSpeed);
			//   v13 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v13
			//     || (v13.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
			//         this.fields.m_rainWaveMaterialPropertyBlock = v13,
			//         sub_1800054D0(
			//           (BSP *)&this.fields.m_rainWaveMaterialPropertyBlock,
			//           v14,
			//           v15,
			//           v16,
			//           (MethodInfo *)v26.m_AnimatedSprites,
			//           *(MethodInfo **)&v26.m_AnimationSpeed),
			//         v17 = (HGFarRainRenderer_FarRainRenderParams *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer::FarRainRenderParams),
			//         (v18 = v17) == 0LL) )
			//   {
			// LABEL_10:
			//     sub_180B536AC(v4, v3);
			//   }
			//   HG::Rendering::Runtime::Rain::HGFarRainRenderer::FarRainRenderParams::FarRainRenderParams(v17, 0LL);
			//   this.fields.m_farRainRenderParams = v18;
			//   sub_1800054D0(
			//     (BSP *)&this.fields.m_farRainRenderParams,
			//     v19,
			//     v20,
			//     v21,
			//     (MethodInfo *)v26.m_AnimatedSprites,
			//     *(MethodInfo **)&v26.m_AnimationSpeed);
			//   this.fields.m_rainWaveLayerOffset = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                    &v26,
			//                                                    v22,
			//                                                    v23,
			//                                                    v24,
			//                                                    (MethodInfo *)v26.m_AnimatedSprites);
			//   if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, v25);
			//   this.fields._.enabled = 1;
			//   this.fields._.rainRenderQueue = 3000;
			// }
			// 
		}

		internal override void PrepareResources(RainCommonResources commonResources)
		{
			// // Void PrepareResources(RainCommonResources)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::PrepareResources(
			//         HGFarRainRenderer *this,
			//         RainCommonResources *commonResources,
			//         MethodInfo *method)
			// {
			//   Mesh *rainRenderQueue; // rdx
			//   Material *v6; // rcx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   Shader *farRainShader; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Bounds *v11; // r8
			//   __int64 v12; // rdx
			//   Shader *m_farRainShader; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   __int64 v17; // rdx
			//   Object_1 *m_middleRainMat; // rdi
			//   struct HGBaseSubRainRenderer__Class *v19; // rax
			//   Object_1 *v20; // rdi
			//   HideFlags__Enum *static_fields; // rax
			//   Shader *v22; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v23; // rdx
			//   Bounds *v24; // r8
			//   Object__Array *v25; // r9
			//   __int64 v26; // rdx
			//   Object_1 *m_farRainMat; // rdi
			//   struct HGBaseSubRainRenderer__Class *v28; // rax
			//   Object_1 *v29; // rdi
			//   HideFlags__Enum *v30; // rax
			//   Shader *v31; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v32; // rdx
			//   Bounds *v33; // r8
			//   Object__Array *v34; // r9
			//   __int64 v35; // rdx
			//   Object_1 *m_rainWaveMat; // rdi
			//   struct HGBaseSubRainRenderer__Class *v37; // rax
			//   Object_1 *v38; // rdi
			//   HideFlags__Enum *v39; // rax
			//   Object_1 *m_farRainSpindleMesh; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v42; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v43; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v44; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v45; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v46; // [rsp+20h] [rbp-38h]
			//   Bounds v47; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v49; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v51; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v52; // [rsp+28h] [rbp-30h]
			//   Bounds v53; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D8EDC31 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9B38D0);
			//     byte_18D8EDC31 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4792, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4792, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)commonResources,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_44;
			//   }
			//   if ( !commonResources )
			//     goto LABEL_44;
			//   this.fields.m_farRainSpindleMesh = commonResources.fields.farRainSpindleMesh;
			//   sub_1800054D0(
			//     (BSP *)&this.fields.m_farRainSpindleMesh,
			//     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)rainRenderQueue,
			//     v7,
			//     v8,
			//     v42,
			//     v48);
			//   farRainShader = commonResources.fields.farRainShader;
			//   this.fields.m_farRainShader = farRainShader;
			//   sub_1800054D0((BSP *)&this.fields.m_farRainShader, v10, v11, (Object__Array *)farRainShader, v43, v49);
			//   m_farRainShader = this.fields.m_farRainShader;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v12);
			//   this.fields.m_middleRainMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                                    m_farRainShader,
			//                                    0,
			//                                    0LL);
			//   sub_1800054D0((BSP *)&this.fields.m_middleRainMat, v14, v15, v16, v44, v50);
			//   m_middleRainMat = (Object_1 *)this.fields.m_middleRainMat;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_middleRainMat, 0LL) )
			//   {
			//     v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     v20 = (Object_1 *)this.fields.m_middleRainMat;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, rainRenderQueue);
			//       v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     static_fields = (HideFlags__Enum *)v19.static_fields;
			//     if ( !v20 )
			//       goto LABEL_44;
			//     UnityEngine::Object::set_hideFlags(v20, *static_fields, 0LL);
			//     v6 = this.fields.m_middleRainMat;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::DisableKeyword(v6, (String *)"RAIN_WAVE", 0LL);
			//     v6 = this.fields.m_middleRainMat;
			//     rainRenderQueue = (Mesh *)(unsigned int)this.fields._.rainRenderQueue;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::set_renderQueue(v6, (_DWORD)rainRenderQueue + 2, 0LL);
			//   }
			//   v22 = this.fields.m_farRainShader;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, rainRenderQueue);
			//   this.fields.m_farRainMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                                 v22,
			//                                 0,
			//                                 0LL);
			//   sub_1800054D0((BSP *)&this.fields.m_farRainMat, v23, v24, v25, v45, v51);
			//   m_farRainMat = (Object_1 *)this.fields.m_farRainMat;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_farRainMat, 0LL) )
			//   {
			//     v28 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     v29 = (Object_1 *)this.fields.m_farRainMat;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, rainRenderQueue);
			//       v28 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     v30 = (HideFlags__Enum *)v28.static_fields;
			//     if ( !v29 )
			//       goto LABEL_44;
			//     UnityEngine::Object::set_hideFlags(v29, *v30, 0LL);
			//     v6 = this.fields.m_farRainMat;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::DisableKeyword(v6, (String *)"RAIN_WAVE", 0LL);
			//     v6 = this.fields.m_farRainMat;
			//     rainRenderQueue = (Mesh *)(unsigned int)this.fields._.rainRenderQueue;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::set_renderQueue(v6, (_DWORD)rainRenderQueue + 1, 0LL);
			//   }
			//   v31 = this.fields.m_farRainShader;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, rainRenderQueue);
			//   this.fields.m_rainWaveMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                                  v31,
			//                                  0,
			//                                  0LL);
			//   sub_1800054D0((BSP *)&this.fields.m_rainWaveMat, v32, v33, v34, v46, v52);
			//   m_rainWaveMat = (Object_1 *)this.fields.m_rainWaveMat;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v35);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_rainWaveMat, 0LL) )
			//   {
			//     v37 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     v38 = (Object_1 *)this.fields.m_rainWaveMat;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, rainRenderQueue);
			//       v37 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     v39 = (HideFlags__Enum *)v37.static_fields;
			//     if ( !v38 )
			//       goto LABEL_44;
			//     UnityEngine::Object::set_hideFlags(v38, *v39, 0LL);
			//     v6 = this.fields.m_rainWaveMat;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::EnableKeyword(v6, (String *)"RAIN_WAVE", 0LL);
			//     v6 = this.fields.m_rainWaveMat;
			//     if ( !v6 )
			//       goto LABEL_44;
			//     UnityEngine::Material::set_renderQueue(v6, this.fields._.rainRenderQueue, 0LL);
			//   }
			//   m_farRainSpindleMesh = (Object_1 *)this.fields.m_farRainSpindleMesh;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, rainRenderQueue);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_farRainSpindleMesh, 0LL) )
			//   {
			//     rainRenderQueue = this.fields.m_farRainSpindleMesh;
			//     if ( rainRenderQueue )
			//     {
			//       v47 = *UnityEngine::Mesh::get_bounds(&v53, rainRenderQueue, 0LL);
			//       this.fields.m_farRainSpindleMeshExtents = v47.m_Extents;
			//       return;
			//     }
			// LABEL_44:
			//     sub_180B536AC(v6, rainRenderQueue);
			//   }
			// }
			// 
		}

		internal override void UpdateData(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateData(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *z_low; // rdx
			//   char *m_farRainRenderParams; // rcx
			//   RainCommonPreSettingParam *commonPresettingParam; // rsi
			//   float v11; // xmm6_4
			//   RainCommonPreSettingParam *v12; // rax
			//   float rainWaveNoiseFlowSpeedMultiplier; // xmm8_4
			//   __m128 farRainDistance_low; // xmm1
			//   __m128 maxRainHeight_low; // xmm2
			//   float v16; // xmm3_4
			//   __m128 middleRainDistance_low; // xmm0
			//   __m128 v18; // xmm1
			//   float v19; // xmm2_4
			//   __m128 rainWaveDistance_low; // xmm0
			//   __m128 v21; // xmm1
			//   float v22; // xmm2_4
			//   HGFarRainRenderer_FarRainRenderParams *v23; // rbp
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   Bounds *v26; // r8
			//   Object__Array *v27; // r9
			//   HGFarRainRenderer_FarRainRenderParams *v28; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v29; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v30; // rax
			//   __m128i v31; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v32; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v33; // rax
			//   __m128i v34; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v35; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v36; // rax
			//   __m128i v37; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v38; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v39; // rax
			//   RainCommonRenderingParam *v40; // rax
			//   RainCommonRenderingParam *v41; // rax
			//   Bounds *v42; // r8
			//   Object__Array *v43; // r9
			//   Bounds *v44; // r8
			//   HGFarRainRenderer_FarRainRenderParams *v45; // r9
			//   __m128i v46; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v47; // rax
			//   __m128i v48; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v49; // r9
			//   __m128i v50; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v51; // rax
			//   __m128i v52; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v53; // rax
			//   int v54; // xmm0_4
			//   HGFarRainRenderer_FarRainRenderParams *v55; // rax
			//   HGFarRainRenderer_FarRainRenderParams *v56; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-58h]
			//   MethodInfo *P3a; // [rsp+20h] [rbp-58h]
			//   MethodInfo *P3b; // [rsp+20h] [rbp-58h]
			//   MethodInfo *v61; // [rsp+28h] [rbp-50h]
			//   MethodInfo *v62; // [rsp+28h] [rbp-50h]
			//   MethodInfo *v63; // [rsp+28h] [rbp-50h]
			//   Vector3 v64[2]; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4793, 0LL) )
			//   {
			//     if ( *rainCommonRenderingParam )
			//     {
			//       commonPresettingParam = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//       if ( commonPresettingParam )
			//       {
			//         v11 = (float)((float)((float)(0.5 / commonPresettingParam.fields.maxRainHeight)
			//                             * (*rainCommonRenderingParam).fields.speed)
			//                     * 0.050000001)
			//             * commonPresettingParam.fields.farRainMaxUVFlowSpeed;
			//         if ( *rainCommonRenderingParam )
			//         {
			//           this.fields.m_middleRainLayerOffset = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                    this,
			//                                                    this.fields.m_middleRainLayerOffset,
			//                                                    v11
			//                                                  * (*rainCommonRenderingParam).fields.middleRainLayerSpeedDiffMultiplier,
			//                                                    deltaTime,
			//                                                    0LL);
			//           if ( *rainCommonRenderingParam )
			//           {
			//             this.fields.m_farRainLayerOffset = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                   this,
			//                                                   this.fields.m_farRainLayerOffset,
			//                                                   v11
			//                                                 * (*rainCommonRenderingParam).fields.farRainLayerSpeedDiffMultiplier,
			//                                                   deltaTime,
			//                                                   0LL);
			//             if ( *rainCommonRenderingParam )
			//             {
			//               v12 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//               if ( v12 )
			//               {
			//                 rainWaveNoiseFlowSpeedMultiplier = v12.fields.rainWaveNoiseFlowSpeedMultiplier;
			//                 this.fields.m_rainWaveLayerOffset.x = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                          this,
			//                                                          this.fields.m_rainWaveLayerOffset.x,
			//                                                          v11
			//                                                        * (*rainCommonRenderingParam).fields.rainWaveHorizontalSpeed,
			//                                                          deltaTime,
			//                                                          0LL);
			//                 if ( *rainCommonRenderingParam )
			//                 {
			//                   this.fields.m_rainWaveLayerOffset.y = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                            this,
			//                                                            this.fields.m_rainWaveLayerOffset.y,
			//                                                            v11
			//                                                          * (*rainCommonRenderingParam).fields.rainWaveVerticalSpeed,
			//                                                            deltaTime,
			//                                                            0LL);
			//                   if ( *rainCommonRenderingParam )
			//                   {
			//                     this.fields.m_rainWaveLayerOffset.z = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                              this,
			//                                                              this.fields.m_rainWaveLayerOffset.z,
			//                                                              (float)(v11
			//                                                                    * (*rainCommonRenderingParam).fields.rainWaveHorizontalSpeed)
			//                                                            * rainWaveNoiseFlowSpeedMultiplier,
			//                                                              deltaTime,
			//                                                              0LL);
			//                     if ( *rainCommonRenderingParam )
			//                     {
			//                       this.fields.m_rainWaveLayerOffset.w = HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//                                                                this,
			//                                                                this.fields.m_rainWaveLayerOffset.w,
			//                                                                (float)(v11
			//                                                                      * (*rainCommonRenderingParam).fields.rainWaveVerticalSpeed)
			//                                                              * rainWaveNoiseFlowSpeedMultiplier,
			//                                                                deltaTime,
			//                                                                0LL);
			//                       m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                       farRainDistance_low = (__m128)LODWORD(commonPresettingParam.fields.farRainDistance);
			//                       maxRainHeight_low = (__m128)LODWORD(commonPresettingParam.fields.maxRainHeight);
			//                       farRainDistance_low.m128_f32[0] = farRainDistance_low.m128_f32[0]
			//                                                       / this.fields.m_farRainSpindleMeshExtents.x;
			//                       maxRainHeight_low.m128_f32[0] = maxRainHeight_low.m128_f32[0]
			//                                                     / this.fields.m_farRainSpindleMeshExtents.y;
			//                       v16 = commonPresettingParam.fields.farRainDistance / this.fields.m_farRainSpindleMeshExtents.z;
			//                       if ( m_farRainRenderParams )
			//                       {
			//                         *(_QWORD *)(m_farRainRenderParams + 28) = _mm_unpacklo_ps(
			//                                                                     farRainDistance_low,
			//                                                                     maxRainHeight_low).m128_u64[0];
			//                         *((float *)m_farRainRenderParams + 9) = v16;
			//                         m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                         middleRainDistance_low = (__m128)LODWORD(commonPresettingParam.fields.middleRainDistance);
			//                         v18 = (__m128)LODWORD(commonPresettingParam.fields.maxRainHeight);
			//                         middleRainDistance_low.m128_f32[0] = middleRainDistance_low.m128_f32[0]
			//                                                            / this.fields.m_farRainSpindleMeshExtents.x;
			//                         v18.m128_f32[0] = v18.m128_f32[0] / this.fields.m_farRainSpindleMeshExtents.y;
			//                         v19 = commonPresettingParam.fields.middleRainDistance
			//                             / this.fields.m_farRainSpindleMeshExtents.z;
			//                         if ( m_farRainRenderParams )
			//                         {
			//                           *((_QWORD *)m_farRainRenderParams + 5) = _mm_unpacklo_ps(middleRainDistance_low, v18).m128_u64[0];
			//                           *((float *)m_farRainRenderParams + 12) = v19;
			//                           m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                           rainWaveDistance_low = (__m128)LODWORD(commonPresettingParam.fields.rainWaveDistance);
			//                           v21 = (__m128)LODWORD(commonPresettingParam.fields.maxRainHeight);
			//                           rainWaveDistance_low.m128_f32[0] = rainWaveDistance_low.m128_f32[0]
			//                                                            / this.fields.m_farRainSpindleMeshExtents.x;
			//                           v21.m128_f32[0] = v21.m128_f32[0] / this.fields.m_farRainSpindleMeshExtents.y;
			//                           v22 = commonPresettingParam.fields.rainWaveDistance
			//                               / this.fields.m_farRainSpindleMeshExtents.z;
			//                           if ( m_farRainRenderParams )
			//                           {
			//                             *(_QWORD *)(m_farRainRenderParams + 52) = _mm_unpacklo_ps(rainWaveDistance_low, v21).m128_u64[0];
			//                             *((float *)m_farRainRenderParams + 15) = v22;
			//                             v23 = this.fields.m_farRainRenderParams;
			//                             if ( hgCamera )
			//                             {
			//                               m_farRainRenderParams = (char *)hgCamera.fields.camera;
			//                               if ( m_farRainRenderParams )
			//                               {
			//                                 transform = UnityEngine::Component::get_transform(
			//                                               (Component *)m_farRainRenderParams,
			//                                               0LL);
			//                                 if ( transform )
			//                                 {
			//                                   position = UnityEngine::Transform::get_position(v64, transform, 0LL);
			//                                   m_farRainRenderParams = (char *)LODWORD(position.z);
			//                                   if ( v23 )
			//                                   {
			//                                     *(_QWORD *)&v23.fields.pos.x = *(_QWORD *)&position.x;
			//                                     LODWORD(v23.fields.pos.z) = (_DWORD)m_farRainRenderParams;
			//                                     m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                     v28 = this.fields.m_farRainRenderParams;
			//                                     if ( *rainCommonRenderingParam )
			//                                     {
			//                                       if ( v28 )
			//                                       {
			//                                         v28.fields.intensity = *((float *)m_farRainRenderParams + 6) * 0.0099999998;
			//                                         m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                         v29 = this.fields.m_farRainRenderParams;
			//                                         if ( *rainCommonRenderingParam )
			//                                         {
			//                                           if ( v29 )
			//                                           {
			//                                             v29.fields.streakLength = *((float *)m_farRainRenderParams + 12);
			//                                             m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                             v30 = this.fields.m_farRainRenderParams;
			//                                             if ( *rainCommonRenderingParam )
			//                                             {
			//                                               v31 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
			//                                               if ( v30 )
			//                                               {
			//                                                 v30.fields.middleRainColor = (Color)v31;
			//                                                 v32 = this.fields.m_farRainRenderParams;
			//                                                 if ( v32 )
			//                                                 {
			//                                                   m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                   if ( *rainCommonRenderingParam )
			//                                                   {
			//                                                     v32.fields.middleRainColor.a = v32.fields.middleRainColor.a
			//                                                                                   * *((float *)m_farRainRenderParams + 17);
			//                                                     m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                     v33 = this.fields.m_farRainRenderParams;
			//                                                     if ( *rainCommonRenderingParam )
			//                                                     {
			//                                                       v34 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
			//                                                       if ( v33 )
			//                                                       {
			//                                                         v33.fields.farRainColor = (Color)v34;
			//                                                         v35 = this.fields.m_farRainRenderParams;
			//                                                         if ( v35 )
			//                                                         {
			//                                                           m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                           if ( *rainCommonRenderingParam )
			//                                                           {
			//                                                             v35.fields.farRainColor.a = v35.fields.farRainColor.a
			//                                                                                        * *((float *)m_farRainRenderParams
			//                                                                                          + 18);
			//                                                             m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                             v36 = this.fields.m_farRainRenderParams;
			//                                                             if ( *rainCommonRenderingParam )
			//                                                             {
			//                                                               v37 = _mm_loadu_si128((const __m128i *)m_farRainRenderParams + 2);
			//                                                               if ( v36 )
			//                                                               {
			//                                                                 v36.fields.rainWaveColor = (Color)v37;
			//                                                                 m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                 if ( m_farRainRenderParams )
			//                                                                 {
			//                                                                   if ( *rainCommonRenderingParam )
			//                                                                   {
			//                                                                     *((_DWORD *)m_farRainRenderParams + 33) = LODWORD((*rainCommonRenderingParam).fields.rainWaveAlpha);
			//                                                                     m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                                     v38 = this.fields.m_farRainRenderParams;
			//                                                                     if ( *rainCommonRenderingParam )
			//                                                                     {
			//                                                                       if ( v38 )
			//                                                                       {
			//                                                                         v38.fields.rainWaveHorizontalSpeed = *((float *)m_farRainRenderParams + 23);
			//                                                                         m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                                         v39 = this.fields.m_farRainRenderParams;
			//                                                                         if ( *rainCommonRenderingParam )
			//                                                                         {
			//                                                                           if ( v39 )
			//                                                                           {
			//                                                                             v39.fields.rainWaveBottomFadeFactor = *((float *)m_farRainRenderParams + 24);
			//                                                                             v40 = *rainCommonRenderingParam;
			//                                                                             m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                             if ( *rainCommonRenderingParam )
			//                                                                             {
			//                                                                               z_low = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)LODWORD(v40.fields.middleRainDirection.z);
			//                                                                               if ( m_farRainRenderParams )
			//                                                                               {
			//                                                                                 *((_QWORD *)m_farRainRenderParams + 8) = *(_QWORD *)&v40.fields.middleRainDirection.x;
			//                                                                                 *((_DWORD *)m_farRainRenderParams + 18) = (_DWORD)z_low;
			//                                                                                 v41 = *rainCommonRenderingParam;
			//                                                                                 m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                                 if ( *rainCommonRenderingParam )
			//                                                                                 {
			//                                                                                   z_low = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)LODWORD(v41.fields.farRainDirection.z);
			//                                                                                   if ( m_farRainRenderParams )
			//                                                                                   {
			//                                                                                     *(_QWORD *)(m_farRainRenderParams
			//                                                                                               + 76) = *(_QWORD *)&v41.fields.farRainDirection.x;
			//                                                                                     *((_DWORD *)m_farRainRenderParams
			//                                                                                     + 21) = (_DWORD)z_low;
			//                                                                                     m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                                     if ( m_farRainRenderParams )
			//                                                                                     {
			//                                                                                       *((_QWORD *)m_farRainRenderParams
			//                                                                                       + 17) = commonPresettingParam.fields.farRainTex0;
			//                                                                                       sub_1800054D0(
			//                                                                                         (BSP *)(m_farRainRenderParams
			//                                                                                               + 136),
			//                                                                                         z_low,
			//                                                                                         v26,
			//                                                                                         v27,
			//                                                                                         P3,
			//                                                                                         v61);
			//                                                                                       m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                                       if ( m_farRainRenderParams )
			//                                                                                       {
			//                                                                                         *((_QWORD *)m_farRainRenderParams
			//                                                                                         + 18) = commonPresettingParam.fields.farRainTex1;
			//                                                                                         sub_1800054D0(
			//                                                                                           (BSP *)(m_farRainRenderParams
			//                                                                                                 + 144),
			//                                                                                           z_low,
			//                                                                                           v42,
			//                                                                                           v43,
			//                                                                                           P3a,
			//                                                                                           v62);
			//                                                                                         v45 = this.fields.m_farRainRenderParams;
			//                                                                                         v46 = _mm_loadu_si128((const __m128i *)&commonPresettingParam.fields.farRainTex0_ST);
			//                                                                                         if ( v45 )
			//                                                                                         {
			//                                                                                           v45.fields.rainStreakTextureScaleOffset0 = (Vector4)v46;
			//                                                                                           v47 = this.fields.m_farRainRenderParams;
			//                                                                                           v48 = _mm_loadu_si128((const __m128i *)&commonPresettingParam.fields.farRainTex1_ST);
			//                                                                                           if ( v47 )
			//                                                                                           {
			//                                                                                             v47.fields.rainStreakTextureScaleOffset1 = (Vector4)v48;
			//                                                                                             m_farRainRenderParams = (char *)this.fields.m_farRainRenderParams;
			//                                                                                             if ( m_farRainRenderParams )
			//                                                                                             {
			//                                                                                               *((_QWORD *)m_farRainRenderParams
			//                                                                                               + 23) = commonPresettingParam.fields.rainWaveTex;
			//                                                                                               sub_1800054D0(
			//                                                                                                 (BSP *)(m_farRainRenderParams + 184),
			//                                                                                                 z_low,
			//                                                                                                 v44,
			//                                                                                                 (Object__Array *)v45,
			//                                                                                                 P3b,
			//                                                                                                 v63);
			//                                                                                               v49 = this.fields.m_farRainRenderParams;
			//                                                                                               v50 = _mm_loadu_si128((const __m128i *)&commonPresettingParam.fields.rainWaveTex_ST);
			//                                                                                               if ( v49 )
			//                                                                                               {
			//                                                                                                 v49.fields.rainWaveTextureScaleOffset = (Vector4)v50;
			//                                                                                                 v51 = this.fields.m_farRainRenderParams;
			//                                                                                                 v52 = _mm_loadu_si128((const __m128i *)&commonPresettingParam.fields.rainWaveNoise_ST);
			//                                                                                                 if ( v51 )
			//                                                                                                 {
			//                                                                                                   v51.fields.rainWaveNoiseScaleOffset = (Vector4)v52;
			//                                                                                                   v53 = this.fields.m_farRainRenderParams;
			//                                                                                                   v54 = (hgCamera.fields.m_antialiasingMode & 2) != 0 ? 1045220557 : 0;
			//                                                                                                   if ( v53 )
			//                                                                                                   {
			//                                                                                                     LODWORD(v53.fields.taauFixFactor) = v54;
			//                                                                                                     m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                                                                     v55 = this.fields.m_farRainRenderParams;
			//                                                                                                     if ( *rainCommonRenderingParam )
			//                                                                                                     {
			//                                                                                                       LOBYTE(z_low) = m_farRainRenderParams[56];
			//                                                                                                       if ( v55 )
			//                                                                                                       {
			//                                                                                                         v55.fields.enableMiddleRain = (char)z_low;
			//                                                                                                         m_farRainRenderParams = (char *)*rainCommonRenderingParam;
			//                                                                                                         v56 = this.fields.m_farRainRenderParams;
			//                                                                                                         if ( *rainCommonRenderingParam )
			//                                                                                                         {
			//                                                                                                           LOBYTE(z_low) = m_farRainRenderParams[80];
			//                                                                                                           if ( v56 )
			//                                                                                                           {
			//                                                                                                             v56.fields.enableRainWave = (char)z_low;
			//                                                                                                             return;
			//                                                                                                           }
			//                                                                                                         }
			//                                                                                                       }
			//                                                                                                     }
			//                                                                                                   }
			//                                                                                                 }
			//                                                                                               }
			//                                                                                             }
			//                                                                                           }
			//                                                                                         }
			//                                                                                       }
			//                                                                                     }
			//                                                                                   }
			//                                                                                 }
			//                                                                               }
			//                                                                             }
			//                                                                           }
			//                                                                         }
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_59:
			//     sub_180B536AC(m_farRainRenderParams, z_low);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4793, 0LL);
			//   if ( !Patch )
			//     goto LABEL_59;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1381(
			//     Patch,
			//     (Object *)this,
			//     (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//     (Object *)hgCamera,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		internal override void SetMaterialData(in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::SetMaterialData(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   void *static_fields; // rdx
			//   char *v8; // rcx
			//   HGFarRainRenderer_FarRainRenderParams *m_farRainRenderParams; // rax
			//   float m_middleRainLayerOffset; // xmm8_4
			//   float streakLength; // xmm7_4
			//   float intensity; // xmm6_4
			//   Vector4 *v13; // rax
			//   __m128i v14; // xmm10
			//   Vector4 *v15; // rax
			//   __m128i v16; // xmm12
			//   __m128i v17; // xmm11
			//   RainCommonRenderingParam *v18; // rax
			//   int cameraMask; // esi
			//   float middleRainLightingPercent; // xmm8_4
			//   _BOOL8 v21; // rax
			//   Material *m_middleRainMat; // rdi
			//   HGFarRainRenderer_FarRainRenderParams *v23; // rax
			//   float x; // xmm7_4
			//   float taauFixFactor; // xmm6_4
			//   Vector4 *v26; // rax
			//   __m128i v27; // xmm8
			//   Vector4 *v28; // rax
			//   __m128i v29; // xmm9
			//   Vector4 *v30; // rax
			//   MaterialPropertyBlock *m_middleRainmaterialPropertyBlock; // rsi
			//   __m128i v32; // xmm7
			//   HGFarRainRenderer_FarRainRenderParams *v33; // rax
			//   Texture2D *rainStreakTexture0; // rdi
			//   __m128i v35; // xmm6
			//   HGFarRainRenderer_FarRainRenderParams *v36; // rax
			//   Vector4 middleRainColor; // xmm0
			//   Vector4 v38; // xmm1
			//   HGFarRainRenderer_FarRainRenderParams *v39; // rax
			//   Texture2D *rainStreakTexture1; // r8
			//   Vector4 v41; // xmm1
			//   MaterialPropertyBlock *m_farRainmaterialPropertyBlock; // rdx
			//   Vector4 v43; // xmm0
			//   HGFarRainRenderer_FarRainRenderParams *v44; // rax
			//   Texture2D *rainWaveTexture; // r8
			//   Vector4 rainWaveNoiseScaleOffset; // xmm1
			//   MaterialPropertyBlock *m_rainWaveMaterialPropertyBlock; // rdx
			//   Vector4 rainWaveTextureScaleOffset; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v50; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector4 v51; // [rsp+68h] [rbp-A0h] BYREF
			//   __m128i v52; // [rsp+78h] [rbp-90h] BYREF
			//   Color rainWaveColor; // [rsp+88h] [rbp-80h] BYREF
			//   Vector4 v54[8]; // [rsp+98h] [rbp-70h] BYREF
			// 
			//   if ( !byte_18D919D48 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919D48 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4795, 0LL) )
			//   {
			//     m_farRainRenderParams = this.fields.m_farRainRenderParams;
			//     m_middleRainLayerOffset = this.fields.m_middleRainLayerOffset;
			//     if ( m_farRainRenderParams )
			//     {
			//       streakLength = m_farRainRenderParams.fields.streakLength;
			//       intensity = m_farRainRenderParams.fields.intensity;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v13 = HG::Rendering::Runtime::HGUtils::PackVector4(v54, m_middleRainLayerOffset, streakLength, intensity, 0LL);
			//       v8 = (char *)this.fields.m_farRainRenderParams;
			//       v14 = _mm_loadu_si128((const __m128i *)v13);
			//       if ( v8 )
			//       {
			//         v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                 v54,
			//                 this.fields.m_farRainLayerOffset,
			//                 *((float *)v8 + 56),
			//                 *((float *)v8 + 57),
			//                 0LL);
			//         v16 = _mm_loadu_si128((const __m128i *)&this.fields.m_rainWaveLayerOffset);
			//         v17 = _mm_loadu_si128((const __m128i *)v15);
			//         v18 = *rainCommonRenderingParam;
			//         if ( *rainCommonRenderingParam )
			//         {
			//           cameraMask = v18.fields.cameraMask;
			//           middleRainLightingPercent = v18.fields.middleRainLightingPercent;
			//           if ( v18.fields.enableRainLighting )
			//             v21 = middleRainLightingPercent > COERCE_FLOAT(1);
			//           else
			//             LODWORD(v21) = 0;
			//           m_middleRainMat = this.fields.m_middleRainMat;
			//           if ( v21 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//             if ( !m_middleRainMat )
			//               goto LABEL_25;
			//             UnityEngine::Material::EnableKeyword(m_middleRainMat, *((String **)static_fields + 1), 0LL);
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//             v8 = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//             if ( !m_middleRainMat )
			//               goto LABEL_25;
			//             UnityEngine::Material::DisableKeyword(m_middleRainMat, *((String **)v8 + 1), 0LL);
			//           }
			//           v23 = this.fields.m_farRainRenderParams;
			//           if ( v23 )
			//           {
			//             x = v23.fields.middleRainScale.x;
			//             taauFixFactor = v23.fields.taauFixFactor;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//             v26 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     v54,
			//                     (float)cameraMask,
			//                     middleRainLightingPercent,
			//                     x,
			//                     taauFixFactor,
			//                     0LL);
			//             v8 = (char *)this.fields.m_farRainRenderParams;
			//             v27 = _mm_loadu_si128((const __m128i *)v26);
			//             if ( v8 )
			//             {
			//               v28 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                       v54,
			//                       (float)cameraMask,
			//                       0.0,
			//                       *((float *)v8 + 7),
			//                       *((float *)v8 + 60),
			//                       0LL);
			//               static_fields = this.fields.m_farRainRenderParams;
			//               v29 = _mm_loadu_si128((const __m128i *)v28);
			//               if ( static_fields )
			//               {
			//                 v30 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                         v54,
			//                         (float)cameraMask,
			//                         *((float *)static_fields + 59),
			//                         *((float *)static_fields + 10),
			//                         *((float *)static_fields + 60),
			//                         0LL);
			//                 m_middleRainmaterialPropertyBlock = this.fields.m_middleRainmaterialPropertyBlock;
			//                 v32 = _mm_loadu_si128((const __m128i *)v30);
			//                 v33 = this.fields.m_farRainRenderParams;
			//                 if ( v33 )
			//                 {
			//                   rainStreakTexture0 = v33.fields.rainStreakTexture0;
			//                   v35 = _mm_loadu_si128((const __m128i *)&v33.fields.rainStreakTextureScaleOffset0);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
			//                   v8 = (char *)TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer.static_fields;
			//                   v36 = this.fields.m_farRainRenderParams;
			//                   if ( v36 )
			//                   {
			//                     middleRainColor = (Vector4)v36.fields.middleRainColor;
			//                     v38 = *(Vector4 *)v8;
			//                     v50 = v27;
			//                     v52 = v14;
			//                     v54[0] = (Vector4)v35;
			//                     v51 = middleRainColor;
			//                     rainWaveColor = (Color)v38;
			//                     HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
			//                       this,
			//                       m_middleRainmaterialPropertyBlock,
			//                       rainStreakTexture0,
			//                       v54,
			//                       (Vector4 *)&rainWaveColor,
			//                       (Vector4 *)&v52,
			//                       (Color *)&v51,
			//                       (Vector4 *)&v50,
			//                       0LL);
			//                     v39 = this.fields.m_farRainRenderParams;
			//                     if ( v39 )
			//                     {
			//                       rainStreakTexture1 = v39.fields.rainStreakTexture1;
			//                       v8 = (char *)this.fields.m_farRainRenderParams;
			//                       static_fields = TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer.static_fields;
			//                       if ( v8 )
			//                       {
			//                         v41 = *(Vector4 *)static_fields;
			//                         m_farRainmaterialPropertyBlock = this.fields.m_farRainmaterialPropertyBlock;
			//                         rainWaveColor = *(Color *)(v8 + 104);
			//                         v43 = *(Vector4 *)(v8 + 168);
			//                         v54[0] = (Vector4)v29;
			//                         v52 = v17;
			//                         v51 = v41;
			//                         v50 = (__m128i)v43;
			//                         HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
			//                           this,
			//                           m_farRainmaterialPropertyBlock,
			//                           rainStreakTexture1,
			//                           (Vector4 *)&v50,
			//                           &v51,
			//                           (Vector4 *)&v52,
			//                           &rainWaveColor,
			//                           v54,
			//                           0LL);
			//                         v44 = this.fields.m_farRainRenderParams;
			//                         if ( v44 )
			//                         {
			//                           rainWaveTexture = v44.fields.rainWaveTexture;
			//                           rainWaveNoiseScaleOffset = v44.fields.rainWaveNoiseScaleOffset;
			//                           m_rainWaveMaterialPropertyBlock = this.fields.m_rainWaveMaterialPropertyBlock;
			//                           rainWaveColor = v44.fields.rainWaveColor;
			//                           rainWaveTextureScaleOffset = v44.fields.rainWaveTextureScaleOffset;
			//                           v54[0] = (Vector4)v32;
			//                           v52 = v16;
			//                           v51 = rainWaveNoiseScaleOffset;
			//                           v50 = (__m128i)rainWaveTextureScaleOffset;
			//                           HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
			//                             this,
			//                             m_rainWaveMaterialPropertyBlock,
			//                             rainWaveTexture,
			//                             (Vector4 *)&v50,
			//                             &v51,
			//                             (Vector4 *)&v52,
			//                             &rainWaveColor,
			//                             v54,
			//                             0LL);
			//                           return;
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(v8, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4795, 0LL);
			//   if ( !Patch )
			//     goto LABEL_25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			// }
			// 
		}

		internal override void UpdateRendererObjs(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateRendererObjs(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   char *v7; // rcx
			//   __int64 v8; // rdx
			//   HGFarRainRenderer_FarRainRenderParams *m_farRainRenderParams; // rax
			//   bool v10; // r13
			//   bool v11; // r12
			//   bool v12; // r15
			//   HGFarRainRenderer_FarRainRenderParams *v13; // rax
			//   __int64 v14; // xmm0_8
			//   float z; // eax
			//   Vector3 *v16; // rax
			//   __int64 v17; // xmm4_8
			//   void (__fastcall *v18)(Vector3 *, Vector3 *, Quaternion *); // rax
			//   MethodInfo *v19; // r8
			//   HGFarRainRenderer_FarRainRenderParams *v20; // rax
			//   __int64 v21; // xmm0_8
			//   float v22; // eax
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm4_8
			//   void (__fastcall *v25)(Vector3 *, Vector3 *, Quaternion *); // rax
			//   MethodInfo *v26; // rdx
			//   Quaternion *identity; // rax
			//   Quaternion v28; // xmm9
			//   __int64 v29; // xmm0_8
			//   __int64 v30; // xmm6_8
			//   float v31; // ebx
			//   __int64 v32; // xmm7_8
			//   float v33; // edi
			//   float v34; // esi
			//   __int64 v35; // xmm8_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v37; // rax
			//   __int64 v38; // rax
			//   Material *m_middleRainMat; // [rsp+38h] [rbp-81h]
			//   Material *m_farRainMat; // [rsp+38h] [rbp-81h]
			//   Material *m_rainWaveMat; // [rsp+38h] [rbp-81h]
			//   MaterialPropertyBlock *m_middleRainmaterialPropertyBlock; // [rsp+40h] [rbp-79h]
			//   MaterialPropertyBlock *m_farRainmaterialPropertyBlock; // [rsp+40h] [rbp-79h]
			//   MaterialPropertyBlock *m_rainWaveMaterialPropertyBlock; // [rsp+40h] [rbp-79h]
			//   Vector3 v45; // [rsp+60h] [rbp-59h] BYREF
			//   Vector3 v46; // [rsp+70h] [rbp-49h] BYREF
			//   Quaternion v47; // [rsp+80h] [rbp-39h] BYREF
			//   Quaternion v48; // [rsp+90h] [rbp-29h] BYREF
			//   Quaternion v49; // [rsp+A0h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D8EDC32 )
			//   {
			//     sub_18003C530(&off_18C9B38E8);
			//     sub_18003C530(&off_18C9B38E0);
			//     sub_18003C530(&off_18C9B3910);
			//     byte_18D8EDC32 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, rainCommonRenderingParam);
			//     v7 = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = **((_QWORD **)v7 + 23);
			//   if ( !v8 )
			//     goto LABEL_22;
			//   if ( *(int *)(v8 + 24) <= 4797 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)v7 + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(v7, v8);
			//     v7 = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (char *)**((_QWORD **)v7 + 23);
			//   if ( !v7 )
			//     goto LABEL_22;
			//   if ( *((_DWORD *)v7 + 6) <= 0x12BDu )
			//     sub_180070270(v7, v8);
			//   if ( !*((_QWORD *)v7 + 4801) )
			//   {
			// LABEL_9:
			//     m_farRainRenderParams = this.fields.m_farRainRenderParams;
			//     if ( !m_farRainRenderParams )
			//       goto LABEL_22;
			//     if ( !m_farRainRenderParams.fields.enableMiddleRain
			//       || m_farRainRenderParams.fields.middleRainColor.a <= COERCE_FLOAT(1) )
			//     {
			//       goto LABEL_11;
			//     }
			//     if ( !*rainCommonRenderingParam )
			//       goto LABEL_22;
			//     if ( (*rainCommonRenderingParam).fields.enable )
			//       v10 = 1;
			//     else
			// LABEL_11:
			//       v10 = 0;
			//     if ( this.fields.m_farRainRenderParams.fields.farRainColor.a <= COERCE_FLOAT(1) )
			//       goto LABEL_13;
			//     if ( !*rainCommonRenderingParam )
			//       goto LABEL_22;
			//     if ( (*rainCommonRenderingParam).fields.enable )
			//       v11 = 1;
			//     else
			// LABEL_13:
			//       v11 = 0;
			//     if ( !this.fields.m_farRainRenderParams.fields.enableRainWave
			//       || this.fields.m_farRainRenderParams.fields.rainWaveColor.a <= COERCE_FLOAT(1) )
			//     {
			//       goto LABEL_15;
			//     }
			//     if ( !*rainCommonRenderingParam )
			//       goto LABEL_22;
			//     if ( (*rainCommonRenderingParam).fields.enable )
			//       v12 = 1;
			//     else
			// LABEL_15:
			//       v12 = 0;
			//     v13 = this.fields.m_farRainRenderParams;
			//     if ( v13 )
			//     {
			//       v14 = *(_QWORD *)&v13.fields.middleRainDirection.x;
			//       z = v13.fields.middleRainDirection.z;
			//       *(_QWORD *)&v45.x = v14;
			//       v45.z = z;
			//       v16 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v47, &v45, (MethodInfo *)hgCamera);
			//       v46.z = 0.0;
			//       *(_QWORD *)&v46.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//       v17 = *(_QWORD *)&v16.x;
			//       v45.z = v16.z;
			//       v18 = (void (__fastcall *)(Vector3 *, Vector3 *, Quaternion *))qword_18D8F4C18;
			//       *(_QWORD *)&v45.x = v17;
			//       v48 = 0LL;
			//       if ( !qword_18D8F4C18 )
			//       {
			//         v18 = (void (__fastcall *)(Vector3 *, Vector3 *, Quaternion *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Quaternion::FromToRotation_Injected"
			//                                                                          "(UnityEngine.Vector3&,UnityEngine.Vector3&,Unit"
			//                                                                          "yEngine.Quaternion&)");
			//         if ( !v18 )
			//         {
			//           v37 = sub_1802DBBE8(
			//                   "UnityEngine.Quaternion::FromToRotation_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//           sub_18000F750(v37, 0LL);
			//         }
			//         qword_18D8F4C18 = (__int64)v18;
			//       }
			//       v18(&v46, &v45, &v48);
			//       v20 = this.fields.m_farRainRenderParams;
			//       if ( v20 )
			//       {
			//         v21 = *(_QWORD *)&v20.fields.farRainDirection.x;
			//         v22 = v20.fields.farRainDirection.z;
			//         *(_QWORD *)&v46.x = v21;
			//         v46.z = v22;
			//         v23 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v47, &v46, v19);
			//         v45.z = 0.0;
			//         *(_QWORD *)&v45.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//         v24 = *(_QWORD *)&v23.x;
			//         v46.z = v23.z;
			//         v25 = (void (__fastcall *)(Vector3 *, Vector3 *, Quaternion *))qword_18D8F4C18;
			//         *(_QWORD *)&v46.x = v24;
			//         v49 = 0LL;
			//         if ( !qword_18D8F4C18 )
			//         {
			//           v25 = (void (__fastcall *)(Vector3 *, Vector3 *, Quaternion *))il2cpp_resolve_icall_0(
			//                                                                            "UnityEngine.Quaternion::FromToRotation_Inject"
			//                                                                            "ed(UnityEngine.Vector3&,UnityEngine.Vector3&,"
			//                                                                            "UnityEngine.Quaternion&)");
			//           if ( !v25 )
			//           {
			//             v38 = sub_1802DBBE8(
			//                     "UnityEngine.Quaternion::FromToRotation_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//             sub_18000F750(v38, 0LL);
			//           }
			//           qword_18D8F4C18 = (__int64)v25;
			//         }
			//         v25(&v45, &v46, &v49);
			//         identity = UnityEngine::Quaternion::get_identity(&v47, v26);
			//         v7 = (char *)this.fields.m_farRainRenderParams;
			//         v28 = *identity;
			//         if ( v7 )
			//         {
			//           v29 = *((_QWORD *)v7 + 5);
			//           v30 = *(_QWORD *)(v7 + 28);
			//           v31 = *((float *)v7 + 9);
			//           v32 = *(_QWORD *)(v7 + 52);
			//           v33 = *((float *)v7 + 15);
			//           v46.z = *((float *)v7 + 12);
			//           m_middleRainmaterialPropertyBlock = this.fields.m_middleRainmaterialPropertyBlock;
			//           m_middleRainMat = this.fields.m_middleRainMat;
			//           *(_QWORD *)&v46.x = v29;
			//           v34 = *((float *)v7 + 6);
			//           *(_QWORD *)&v45.x = *((_QWORD *)v7 + 2);
			//           v35 = *(_QWORD *)&v45.x;
			//           v45.z = v34;
			//           HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateRainObj(
			//             this,
			//             v10,
			//             &this.fields.m_middleRainTrans,
			//             &this.fields.m_middleRainMr,
			//             &v45,
			//             &v48,
			//             &v46,
			//             m_middleRainMat,
			//             m_middleRainmaterialPropertyBlock,
			//             (String *)"!MIDDLERAINOBJ",
			//             hgCamera,
			//             0LL);
			//           v46.z = v31;
			//           m_farRainmaterialPropertyBlock = this.fields.m_farRainmaterialPropertyBlock;
			//           m_farRainMat = this.fields.m_farRainMat;
			//           *(_QWORD *)&v46.x = v30;
			//           *(_QWORD *)&v45.x = v35;
			//           v45.z = v34;
			//           HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateRainObj(
			//             this,
			//             v11,
			//             &this.fields.m_farRainTrans,
			//             &this.fields.m_farRainMr,
			//             &v45,
			//             &v49,
			//             &v46,
			//             m_farRainMat,
			//             m_farRainmaterialPropertyBlock,
			//             (String *)"!FARRAINOBJ",
			//             hgCamera,
			//             0LL);
			//           m_rainWaveMaterialPropertyBlock = this.fields.m_rainWaveMaterialPropertyBlock;
			//           m_rainWaveMat = this.fields.m_rainWaveMat;
			//           *(_QWORD *)&v46.x = v32;
			//           v46.z = v33;
			//           v49 = v28;
			//           *(_QWORD *)&v45.x = v35;
			//           v45.z = v34;
			//           HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateRainObj(
			//             this,
			//             v12,
			//             &this.fields.m_rainWaveTrans,
			//             &this.fields.m_rainWaveMr,
			//             &v45,
			//             &v49,
			//             &v46,
			//             m_rainWaveMat,
			//             m_rainWaveMaterialPropertyBlock,
			//             (String *)"!RAINWAVEOBJ",
			//             hgCamera,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(v7, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4797, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//     Patch,
			//     (Object *)this,
			//     (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		internal override void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::Dispose(HGFarRainRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4799, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4799, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_farRainTrans,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_middleRainTrans,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_rainWaveTrans,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_farRainMat,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_middleRainMat,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_rainWaveMat,
			//       0LL);
			//   }
			// }
			// 
		}

		private float _GetFractedOffset(float currentOffset, float speed, float deltaTime)
		{
			// // Single _GetFractedOffset(Single, Single, Single)
			// float HG::Rendering::Runtime::Rain::HGFarRainRenderer::_GetFractedOffset(
			//         HGFarRainRenderer *this,
			//         float currentOffset,
			//         float speed,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   float v6; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4794, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4794, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1382(Patch, (Object *)this, currentOffset, speed, deltaTime, 0LL);
			//   }
			//   else
			//   {
			//     v6 = (float)(speed * deltaTime) + currentOffset;
			//     if ( (float)(v6 - 100.0) >= COERCE_FLOAT(1) )
			//       return v6 + -100.0;
			//     return v6;
			//   }
			// }
			// 
			return 0f;
		}

		private void _SetFarRainParamsToMPB(MaterialPropertyBlock materialPropertyBlock, Texture2D rainTex, Vector4 rainTexScaleOffset0, Vector4 rainTexScaleOffset1, Vector4 rainParams, Color rainColor, Vector4 rainMaskParams)
		{
			// // Void _SetFarRainParamsToMPB(MaterialPropertyBlock, Texture2D, Vector4, Vector4, Vector4, Color, Vector4)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::_SetFarRainParamsToMPB(
			//         HGFarRainRenderer *this,
			//         MaterialPropertyBlock *materialPropertyBlock,
			//         Texture2D *rainTex,
			//         Vector4 *rainTexScaleOffset0,
			//         Vector4 *rainTexScaleOffset1,
			//         Vector4 *rainParams,
			//         Color *rainColor,
			//         Vector4 *rainMaskParams,
			//         MethodInfo *method)
			// {
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *static_fields; // rcx
			//   int32_t klass; // edx
			//   int32_t RainTex1_ST; // edx
			//   int32_t v17; // edx
			//   MethodInfo *v18; // r8
			//   int32_t v19; // r10d
			//   int32_t v20; // edx
			//   Vector4 v21; // xmm0
			//   Vector4 v22; // [rsp+58h] [rbp-21h] BYREF
			//   Color v23; // [rsp+68h] [rbp-11h] BYREF
			//   Vector4 v24; // [rsp+78h] [rbp-1h] BYREF
			//   Vector4 v25; // [rsp+88h] [rbp+Fh] BYREF
			//   Vector4 v26; // [rsp+98h] [rbp+1Fh] BYREF
			// 
			//   if ( !byte_18D919D49 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919D49 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4796, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//       materialPropertyBlock,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainTex0,
			//       (Texture *)rainTex,
			//       0LL);
			//     static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     if ( materialPropertyBlock )
			//     {
			//       klass = (int32_t)static_fields[79].klass;
			//       v22 = *rainTexScaleOffset0;
			//       UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, klass, &v22, 0LL);
			//       RainTex1_ST = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainTex1_ST;
			//       v22 = *rainTexScaleOffset1;
			//       UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, RainTex1_ST, &v22, 0LL);
			//       v17 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainParams;
			//       v22 = *rainParams;
			//       UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v17, &v22, 0LL);
			//       v22 = (Vector4)*rainColor;
			//       v22 = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v26, &v22, v18);
			//       UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v19, &v22, 0LL);
			//       v20 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainMaskParams;
			//       v22 = *rainMaskParams;
			//       UnityEngine::MaterialPropertyBlock::SetVector(materialPropertyBlock, v20, &v22, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(static_fields, v13);
			//   }
			//   static_fields = IFix::WrappersManagerImpl::GetPatch(4796, 0LL);
			//   if ( !static_fields )
			//     goto LABEL_7;
			//   v22 = *rainMaskParams;
			//   v23 = *rainColor;
			//   v24 = *rainParams;
			//   v21 = *rainTexScaleOffset0;
			//   v25 = *rainTexScaleOffset1;
			//   v26 = v21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1383(
			//     static_fields,
			//     (Object *)this,
			//     (Object *)materialPropertyBlock,
			//     (Object *)rainTex,
			//     &v26,
			//     &v25,
			//     &v24,
			//     &v23,
			//     &v22,
			//     0LL);
			// }
			// 
		}

		private void UpdateRainObj(bool active, ref Transform trans, ref MeshRenderer mr, Vector3 pos, Quaternion rot, Vector3 scale, Material mat, MaterialPropertyBlock mpb, string objName, HGCamera hgCamera)
		{
			// // Void UpdateRainObj(Boolean, Transform ByRef, MeshRenderer ByRef, Vector3, Quaternion, Vector3, Material, MaterialPropertyBlock, String, HGCamera)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::UpdateRainObj(
			//         HGFarRainRenderer *this,
			//         bool active,
			//         Transform **trans,
			//         MeshRenderer **mr,
			//         Vector3 *pos,
			//         Quaternion *rot,
			//         Vector3 *scale,
			//         Material *mat,
			//         MaterialPropertyBlock *mpb,
			//         String *objName,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Renderer *v16; // rcx
			//   __int64 v17; // rdx
			//   Transform *v18; // rdi
			//   Transform *v19; // rdi
			//   __int64 (__fastcall *v20)(Transform *); // rax
			//   __int64 v21; // rdi
			//   unsigned __int8 (__fastcall *v22)(__int64); // rax
			//   __int64 v23; // rcx
			//   Transform *v24; // rdi
			//   void (__fastcall *v25)(Transform *, Quaternion *); // rax
			//   Transform *v26; // rbx
			//   __int64 v27; // xmm0_8
			//   void (__fastcall *v28)(Transform *, Vector3 *); // rax
			//   MeshRenderer *v29; // rbx
			//   MeshRenderer *v30; // rbx
			//   void (__fastcall *v31)(MeshRenderer *, MaterialPropertyBlock *); // rax
			//   GameObject *v32; // rax
			//   Object_1 *v33; // rdi
			//   __int64 v34; // rdx
			//   struct HGBaseSubRainRenderer__Class *v35; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v36; // rdx
			//   Bounds *v37; // r8
			//   Object__Array *v38; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v39; // rdx
			//   Bounds *v40; // r8
			//   Object__Array *v41; // r9
			//   Object *v42; // rax
			//   Object_1 *camera; // r15
			//   Transform *transform; // rax
			//   Transform *v45; // r15
			//   Transform *v46; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   Transform *v49; // rdi
			//   void (__fastcall *v50)(Transform *, Vector3 *); // rax
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // r10
			//   __int64 v53; // xmm1_8
			//   __int64 v54; // xmm0_8
			//   float z; // ecx
			//   Quaternion v56; // xmm0
			//   __int64 v57; // rax
			//   __int64 v58; // rax
			//   __int64 v59; // rax
			//   __int64 v60; // rax
			//   __int64 v61; // rax
			//   MethodInfo *v62; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v63; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v64; // [rsp+28h] [rbp-90h]
			//   MethodInfo *v65; // [rsp+28h] [rbp-90h]
			//   Vector3 v66; // [rsp+70h] [rbp-48h] BYREF
			//   Vector3 v67; // [rsp+80h] [rbp-38h] BYREF
			//   Quaternion v68[2]; // [rsp+90h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC33 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC33 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v16 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, active);
			//     v16 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v17 = *(_QWORD *)v16[7].fields._._.m_CachedPtr;
			//   if ( !v17 )
			//     goto LABEL_64;
			//   if ( *(int *)(v17 + 24) > 4798 )
			//   {
			//     if ( !LODWORD(v16[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(v16, v17);
			//       v16 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v16 = *(Renderer **)v16[7].fields._._.m_CachedPtr;
			//     if ( !v16 )
			//       goto LABEL_64;
			//     if ( LODWORD(v16[1].klass) <= 0x12BE )
			//       sub_180070270(v16, v17);
			//     if ( v16[1600].fields._._.m_CachedPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4798, 0LL);
			//       if ( Patch )
			//       {
			//         v53 = *(_QWORD *)&pos.x;
			//         v54 = *(_QWORD *)&scale.x;
			//         z = scale.z;
			//         v67.z = pos.z;
			//         v66.z = z;
			//         *(_QWORD *)&v66.x = v54;
			//         v56 = *rot;
			//         *(_QWORD *)&v67.x = v53;
			//         v68[0] = v56;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1384(
			//           Patch,
			//           (Object *)this,
			//           active,
			//           trans,
			//           mr,
			//           &v67,
			//           v68,
			//           &v66,
			//           (Object *)mat,
			//           (Object *)mpb,
			//           (Object *)objName,
			//           (Object *)hgCamera,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_64;
			//     }
			//   }
			//   v18 = *trans;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v18 )
			//     goto LABEL_46;
			//   v16 = (Renderer *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !v18.fields._._.m_CachedPtr )
			//   {
			// LABEL_46:
			//     v32 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//     v33 = (Object_1 *)v32;
			//     if ( !v32 )
			//       goto LABEL_64;
			//     UnityEngine::GameObject::GameObject(v32, objName, 0LL);
			//     v35 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, v34);
			//       v35 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     UnityEngine::Object::set_hideFlags(v33, v35.static_fields.RAIN_RSC_HIDE_FLAGS, 0LL);
			//     *trans = UnityEngine::GameObject::get_transform((GameObject *)v33, 0LL);
			//     sub_1800054D0((BSP *)trans, v36, v37, v38, v62, v64);
			//     *mr = (MeshRenderer *)UnityEngine::GameObject::AddComponent<System::Object>(
			//                             (GameObject *)v33,
			//                             MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_1800054D0((BSP *)mr, v39, v40, v41, v63, v65);
			//     v42 = UnityEngine::GameObject::AddComponent<System::Object>(
			//             (GameObject *)v33,
			//             MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     if ( !v42 )
			//       goto LABEL_64;
			//     UnityEngine::MeshFilter::set_sharedMesh((MeshFilter *)v42, this.fields.m_farRainSpindleMesh, 0LL);
			//     v16 = (Renderer *)*mr;
			//     if ( !*mr )
			//       goto LABEL_64;
			//     UnityEngine::Renderer::SetMaterial(v16, mat, 0LL);
			//     if ( hgCamera )
			//     {
			//       camera = (Object_1 *)hgCamera.fields.camera;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//       if ( UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//       {
			//         transform = UnityEngine::GameObject::get_transform((GameObject *)v33, 0LL);
			//         v16 = (Renderer *)hgCamera.fields.camera;
			//         v45 = transform;
			//         if ( !v16 )
			//           goto LABEL_64;
			//         v46 = UnityEngine::Component::get_transform((Component *)v16, 0LL);
			//         if ( !v45 )
			//           goto LABEL_64;
			//         UnityEngine::Transform::SetParent(v45, v46, 1, 0LL);
			//         v49 = UnityEngine::GameObject::get_transform((GameObject *)v33, 0LL);
			//         if ( !v49 )
			//           sub_180B536AC(v48, v47);
			//         v50 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52F8;
			//         *(_QWORD *)&v67.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v67.z = 0.0;
			//         if ( !qword_18D8F52F8 )
			//         {
			//           v50 = (void (__fastcall *)(Transform *, Vector3 *))sub_180017470(
			//                                                                "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)");
			//           qword_18D8F52F8 = (__int64)v50;
			//         }
			//         v50(v49, &v67);
			//       }
			//     }
			//   }
			//   v19 = *trans;
			//   if ( !*trans )
			//     goto LABEL_64;
			//   v20 = (__int64 (__fastcall *)(Transform *))qword_18D8F4D48;
			//   if ( !qword_18D8F4D48 )
			//   {
			//     v20 = (__int64 (__fastcall *)(Transform *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//     if ( !v20 )
			//     {
			//       v57 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//       sub_18000F750(v57, 0LL);
			//     }
			//     qword_18D8F4D48 = (__int64)v20;
			//   }
			//   v21 = v20(v19);
			//   if ( !v21 )
			//     goto LABEL_64;
			//   v22 = (unsigned __int8 (__fastcall *)(__int64))qword_18D8F4E00;
			//   if ( !qword_18D8F4E00 )
			//   {
			//     v22 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.GameObject::get_activeSelf()");
			//     if ( !v22 )
			//     {
			//       v58 = sub_1802DBBE8("UnityEngine.GameObject::get_activeSelf()");
			//       sub_18000F750(v58, 0LL);
			//     }
			//     qword_18D8F4E00 = (__int64)v22;
			//   }
			//   if ( v22(v21) != active )
			//   {
			//     v16 = (Renderer *)*trans;
			//     if ( !*trans )
			//       goto LABEL_64;
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)v16, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_64;
			//     UnityEngine::GameObject::SetActive(gameObject, active, 0LL);
			//   }
			//   v24 = *trans;
			//   if ( !*trans )
			//     goto LABEL_65;
			//   v25 = (void (__fastcall *)(Transform *, Quaternion *))qword_18D8F5308;
			//   v68[0] = *rot;
			//   if ( !qword_18D8F5308 )
			//   {
			//     v25 = (void (__fastcall *)(Transform *, Quaternion *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)");
			//     if ( !v25 )
			//     {
			//       v59 = sub_1802DBBE8("UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)");
			//       sub_18000F750(v59, 0LL);
			//     }
			//     qword_18D8F5308 = (__int64)v25;
			//   }
			//   v25(v24, v68);
			//   v26 = *trans;
			//   if ( !v26 )
			// LABEL_65:
			//     sub_180B536AC(v23, v17);
			//   v27 = *(_QWORD *)&scale.x;
			//   v67.z = scale.z;
			//   v28 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F5328;
			//   *(_QWORD *)&v67.x = v27;
			//   if ( !qword_18D8F5328 )
			//   {
			//     v28 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
			//     if ( !v28 )
			//     {
			//       v60 = sub_1802DBBE8("UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v60, 0LL);
			//     }
			//     qword_18D8F5328 = (__int64)v28;
			//   }
			//   v28(v26, &v67);
			//   v29 = *mr;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v29 )
			//   {
			//     v16 = (Renderer *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//     if ( v29.fields._._._.m_CachedPtr )
			//     {
			//       v30 = *mr;
			//       if ( *mr )
			//       {
			//         v31 = (void (__fastcall *)(MeshRenderer *, MaterialPropertyBlock *))qword_18D8F45B0;
			//         if ( !qword_18D8F45B0 )
			//         {
			//           v31 = (void (__fastcall *)(MeshRenderer *, MaterialPropertyBlock *))il2cpp_resolve_icall_0(
			//                                                                                 "UnityEngine.Renderer::Internal_SetProper"
			//                                                                                 "tyBlock(UnityEngine.MaterialPropertyBlock)");
			//           if ( !v31 )
			//           {
			//             v61 = sub_1802DBBE8("UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)");
			//             sub_18000F750(v61, 0LL);
			//           }
			//           qword_18D8F45B0 = (__int64)v31;
			//         }
			//         v31(v30, mpb);
			//         return;
			//       }
			// LABEL_64:
			//       sub_180B536AC(v16, v17);
			//     }
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_SetMaterialData(ref RainCommonRenderingParam P0, ref ScriptableRenderContext P1)
		{
			// // Void <>iFixBaseProxy_SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_SetMaterialData(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         ScriptableRenderContext *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_UpdateRendererObjs(ref RainCommonRenderingParam P0, HGCamera P1)
		{
			// // Void <>iFixBaseProxy_UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_UpdateRendererObjs(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         HGCamera *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::UpdateRendererObjs((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose()
		{
			// // Void <>iFixBaseProxy_Dispose()
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Dispose(
			//         HGFarRainRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose((HGBaseSubRainRenderer *)this, 0LL);
			// }
			// 
		}

		private Mesh m_farRainSpindleMesh;

		private Vector3 m_farRainSpindleMeshExtents;

		private Shader m_farRainShader;

		private Material m_middleRainMat;

		private Material m_farRainMat;

		private Material m_rainWaveMat;

		private MaterialPropertyBlock m_farRainmaterialPropertyBlock;

		private MaterialPropertyBlock m_middleRainmaterialPropertyBlock;

		private MaterialPropertyBlock m_rainWaveMaterialPropertyBlock;

		private HGFarRainRenderer.FarRainRenderParams m_farRainRenderParams;

		private Transform m_middleRainTrans;

		private Transform m_farRainTrans;

		private Transform m_rainWaveTrans;

		private MeshRenderer m_middleRainMr;

		private MeshRenderer m_farRainMr;

		private MeshRenderer m_rainWaveMr;

		private float m_middleRainLayerOffset;

		private float m_farRainLayerOffset;

		private Vector4 m_rainWaveLayerOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Vector4 s_defaultScaleOffset;

		private const string s_farRainObjName = "!FARRAINOBJ";

		private const string s_middleRainObjName = "!MIDDLERAINOBJ";

		private const string s_rainWaveObjName = "!RAINWAVEOBJ";

		private const string s_rainWaveKw = "RAIN_WAVE";

		private class FarRainRenderParams
		{
			public FarRainRenderParams()
			{
				// // HGFarRainRenderer+FarRainRenderParams()
				// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::FarRainRenderParams::FarRainRenderParams(
				//         HGFarRainRenderer_FarRainRenderParams *this,
				//         MethodInfo *method)
				// {
				//   Vector3Int *v2; // r8
				//   ITilemap *v3; // r9
				//   TileBase *v5; // rdx
				//   Vector3Int *v6; // r8
				//   ITilemap *v7; // r9
				//   TileBase *v8; // rdx
				//   Vector3Int *v9; // r8
				//   ITilemap *v10; // r9
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v11; // rdx
				//   Bounds *v12; // r8
				//   Object__Array *v13; // r9
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
				//   Bounds *v15; // r8
				//   Object__Array *v16; // r9
				//   Vector4 si128; // xmm0
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v18; // rdx
				//   Bounds *v19; // r8
				//   Object__Array *v20; // r9
				//   Vector4 v21; // xmm0
				//   TileAnimationData v22; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   *(_QWORD *)&this.fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.pos.z = 0.0;
				//   *(_QWORD *)&this.fields.farRainscale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
				//   this.fields.farRainscale.z = 1.0;
				//   *(_QWORD *)&this.fields.middleRainScale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
				//   this.fields.middleRainScale.z = 1.0;
				//   *(_QWORD *)&this.fields.rainWaveScale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
				//   this.fields.rainWaveScale.z = 1.0;
				//   *(_QWORD *)&this.fields.middleRainDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
				//   this.fields.middleRainDirection.z = 0.0;
				//   *(_QWORD *)&this.fields.farRainDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
				//   this.fields.farRainDirection.z = 0.0;
				//   this.fields.middleRainColor = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                            &v22,
				//                                            (TileBase *)method,
				//                                            v2,
				//                                            v3,
				//                                            (MethodInfo *)v22.m_AnimatedSprites);
				//   this.fields.farRainColor = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v22,
				//                                         v5,
				//                                         v6,
				//                                         v7,
				//                                         (MethodInfo *)v22.m_AnimatedSprites);
				//   this.fields.rainWaveColor = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                          &v22,
				//                                          v8,
				//                                          v9,
				//                                          v10,
				//                                          (MethodInfo *)v22.m_AnimatedSprites);
				//   this.fields.rainStreakTexture0 = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (BSP *)&this.fields.rainStreakTexture0,
				//     v11,
				//     v12,
				//     v13,
				//     (MethodInfo *)v22.m_AnimatedSprites,
				//     *(MethodInfo **)&v22.m_AnimationSpeed);
				//   this.fields.rainStreakTexture1 = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (BSP *)&this.fields.rainStreakTexture1,
				//     v14,
				//     v15,
				//     v16,
				//     (MethodInfo *)v22.m_AnimatedSprites,
				//     *(MethodInfo **)&v22.m_AnimationSpeed);
				//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				//   this.fields.rainStreakTextureScaleOffset0 = si128;
				//   this.fields.rainStreakTextureScaleOffset1 = si128;
				//   this.fields.rainWaveTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (BSP *)&this.fields.rainWaveTexture,
				//     v18,
				//     v19,
				//     v20,
				//     (MethodInfo *)v22.m_AnimatedSprites,
				//     *(MethodInfo **)&v22.m_AnimationSpeed);
				//   v21 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				//   this.fields.rainWaveTextureScaleOffset = v21;
				//   this.fields.rainWaveNoiseScaleOffset = v21;
				// }
				// 
			}

			public Vector3 pos;

			public Vector3 farRainscale;

			public Vector3 middleRainScale;

			public Vector3 rainWaveScale;

			public Vector3 middleRainDirection;

			public Vector3 farRainDirection;

			public Color middleRainColor;

			public Color farRainColor;

			public Color rainWaveColor;

			public Texture2D rainStreakTexture0;

			public Texture2D rainStreakTexture1;

			public Vector4 rainStreakTextureScaleOffset0;

			public Vector4 rainStreakTextureScaleOffset1;

			public Texture2D rainWaveTexture;

			public Vector4 rainWaveTextureScaleOffset;

			public Vector4 rainWaveNoiseScaleOffset;

			public float streakLength;

			public float intensity;

			public float rainWaveHorizontalSpeed;

			public float rainWaveBottomFadeFactor;

			public float taauFixFactor;

			public bool enableMiddleRain;

			public bool enableRainWave;
		}
	}
}
