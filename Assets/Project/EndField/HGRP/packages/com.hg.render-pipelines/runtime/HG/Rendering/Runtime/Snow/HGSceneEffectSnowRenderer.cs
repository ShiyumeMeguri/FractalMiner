using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.Snow
{
	public class HGSceneEffectSnowRenderer : HGBaseSubSnowRenderer
	{
		public HGSceneEffectSnowRenderer()
		{
		}

		internal override void PrepareResources(SnowCommonResources commonResources)
		{
			// // Void PrepareResources(SnowCommonResources)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::PrepareResources(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonResources *commonResources,
			//         MethodInfo *method)
			// {
			//   Mesh *v5; // rdx
			//   Material *v6; // rcx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   Shader *snowShader; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Bounds *v11; // r8
			//   __int64 v12; // rdx
			//   Shader *m_snowShader; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   __int64 v17; // rdx
			//   Object_1 *m_snowMat; // rdi
			//   struct HGBaseSubSnowRenderer__Class *v19; // rax
			//   Object_1 *v20; // rdi
			//   HideFlags__Enum *static_fields; // rax
			//   Object_1 *m_snowMesh; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v24; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v25; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v26; // [rsp+20h] [rbp-38h]
			//   Bounds v27; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v29; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v30; // [rsp+28h] [rbp-30h]
			//   Bounds v31; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D8EDC22 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC22 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4776, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4776, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)commonResources,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_21;
			//   }
			//   if ( !commonResources )
			//     goto LABEL_21;
			//   this.fields.m_snowMesh = commonResources.fields.snowMesh;
			//   sub_1800054D0(
			//     (BSP *)&this.fields.m_snowMesh,
			//     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v5,
			//     v7,
			//     v8,
			//     v24,
			//     v28);
			//   snowShader = commonResources.fields.snowShader;
			//   this.fields.m_snowShader = snowShader;
			//   sub_1800054D0((BSP *)&this.fields.m_snowShader, v10, v11, (Object__Array *)snowShader, v25, v29);
			//   m_snowShader = this.fields.m_snowShader;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v12);
			//   this.fields.m_snowMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                              m_snowShader,
			//                              0,
			//                              0LL);
			//   sub_1800054D0((BSP *)&this.fields.m_snowMat, v14, v15, v16, v26, v30);
			//   m_snowMat = (Object_1 *)this.fields.m_snowMat;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_snowMat, 0LL) )
			//   {
			//     v19 = TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer;
			//     v20 = (Object_1 *)this.fields.m_snowMat;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer, v5);
			//       v19 = TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer;
			//     }
			//     static_fields = (HideFlags__Enum *)v19.static_fields;
			//     if ( !v20 )
			//       goto LABEL_21;
			//     UnityEngine::Object::set_hideFlags(v20, *static_fields, 0LL);
			//     v6 = this.fields.m_snowMat;
			//     if ( !v6 )
			//       goto LABEL_21;
			//     UnityEngine::Material::set_renderQueue(v6, this.fields._.snowRenderQueue, 0LL);
			//   }
			//   m_snowMesh = (Object_1 *)this.fields.m_snowMesh;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_snowMesh, 0LL) )
			//   {
			//     v5 = this.fields.m_snowMesh;
			//     if ( v5 )
			//     {
			//       v27 = *UnityEngine::Mesh::get_bounds(&v31, v5, 0LL);
			//       this.fields.m_snowMeshExtents = v27.m_Extents;
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(v6, v5);
			//   }
			// }
			// 
		}

		internal override void UpdateData(in SnowCommonRenderingParam snowCommonRenderingParam, HGCamera hgCamera, float deltaTime)
		{
			// // Void UpdateData(SnowCommonRenderingParam ByRef, HGCamera, Single)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::UpdateData(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonRenderingParam **snowCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   float v5; // xmm1_4
			//   float v6; // xmm2_4
			//   Texture2D *z_low; // rdx
			//   char *m_sceneEffectSnowAxisOffsetList; // rcx
			//   SnowCommonPreSettingParam *snowCommonPreSettingParam; // r14
			//   float v13; // xmm8_4
			//   float v14; // xmm13_4
			//   float v15; // xmm12_4
			//   __int64 v16; // rax
			//   float v17; // xmm8_4
			//   float v18; // xmm7_4
			//   Beyond::JobMathf *v19; // rcx
			//   float3 *v20; // rdx
			//   float3 *v21; // rcx
			//   float3 *v22; // r8
			//   float3 *v23; // r9
			//   float v24; // xmm0_4
			//   float v25; // xmm8_4
			//   int v26; // esi
			//   SnowCommonRenderingParam *v27; // rax
			//   __int64 v28; // xmm7_8
			//   float z; // r12d
			//   MethodInfo *v30; // rax
			//   Vector3 *v31; // rax
			//   __int64 v32; // r9
			//   __int64 v33; // xmm1_8
			//   Vector3 *v34; // rax
			//   float v35; // ecx
			//   __int64 v36; // r9
			//   float *v37; // rax
			//   float *v38; // rax
			//   float v39; // xmm0_4
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   float v42; // xmm0_4
			//   __int64 v43; // rax
			//   __int64 v44; // rax
			//   float v45; // xmm0_4
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rsi
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   Bounds *v49; // r8
			//   Object__Array *v50; // r9
			//   __m128 snowRange_low; // xmm0
			//   __m128 maxSnowHeight_low; // xmm1
			//   float v53; // xmm2_4
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v54; // rax
			//   __m128i v55; // xmm0
			//   SnowCommonRenderingParam *v56; // rax
			//   float m_rainLayerOffset; // xmm1_4
			//   float y; // xmm2_4
			//   unsigned int v59; // xmm0_4
			//   SnowCommonRenderingParam *v60; // rax
			//   SnowCommonPreSettingParam *v61; // rax
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v62; // r9
			//   SnowCommonPreSettingParam *v63; // rax
			//   __m128i v64; // xmm0
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v65; // rax
			//   int32_t snowLayerCount; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+28h] [rbp-B1h]
			//   MethodInfo *v69; // [rsp+30h] [rbp-A9h]
			//   Vector3 v70; // [rsp+38h] [rbp-A1h] BYREF
			//   Vector3 v71; // [rsp+48h] [rbp-91h] BYREF
			//   Vector3 v72; // [rsp+58h] [rbp-81h] BYREF
			//   Vector3 v73; // [rsp+68h] [rbp-71h] BYREF
			//   _OWORD v74[9]; // [rsp+78h] [rbp-61h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4777, 0LL) )
			//   {
			//     if ( !*snowCommonRenderingParam )
			//       goto LABEL_66;
			//     snowCommonPreSettingParam = (*snowCommonRenderingParam).fields.snowCommonPreSettingParam;
			//     if ( !snowCommonPreSettingParam )
			//       goto LABEL_66;
			//     v13 = (float)((float)((float)(0.5 / snowCommonPreSettingParam.fields.maxSnowHeight)
			//                         * (*snowCommonRenderingParam).fields.speed)
			//                 * 0.050000001)
			//         * snowCommonPreSettingParam.fields.snowMaxUVFlowSpeed;
			//     v14 = v13;
			//     v15 = v13;
			//     if ( !*snowCommonRenderingParam )
			//       goto LABEL_66;
			//     v16 = Beyond::JobMathf::Clamp01((Beyond::JobMathf *)m_sceneEffectSnowAxisOffsetList);
			//     if ( !v16 )
			//       goto LABEL_66;
			//     v17 = v13 * fabs(*(float *)(v16 + 48));
			//     v18 = (float)(v17 * deltaTime) + this.fields.m_rainLayerOffset;
			//     System::MathF::Floor((System::MathF *)m_sceneEffectSnowAxisOffsetList, v5);
			//     Beyond::JobMathf::Fmod(v19, 100.0, v6);
			//     this.fields.m_rainLayerOffset = v18 + (float)(v18 - v18);
			//     v24 = (float)((float)(sub_1802ECED0(v21, v20, v22, v23) * v15) * deltaTime) + this.fields.m_snowHorizontalOffset;
			//     this.fields.m_snowHorizontalOffset = v24;
			//     if ( v24 > 100.0 )
			//       this.fields.m_snowHorizontalOffset = v24 - 100.0;
			//     v25 = (float)(v17 * deltaTime) + this.fields.m_snowVerticalOffset;
			//     this.fields.m_snowVerticalOffset = v25;
			//     if ( v25 > 100.0 )
			//       this.fields.m_snowVerticalOffset = v25 - 100.0;
			//     v26 = 0;
			//     while ( 1 )
			//     {
			//       v27 = *snowCommonRenderingParam;
			//       if ( !*snowCommonRenderingParam )
			//         goto LABEL_66;
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       v28 = *(_QWORD *)&v27.fields.snowDirection.x;
			//       z = v27.fields.snowDirection.z;
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       v30 = (MethodInfo *)sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//       *(_QWORD *)&v70.x = v28;
			//       v70.z = z;
			//       v31 = UnityEngine::Vector3::op_Multiply(&v73, v14 * deltaTime, &v70, v30);
			//       *(_QWORD *)&v72.x = *(_QWORD *)v32;
			//       v33 = *(_QWORD *)&v31.x;
			//       v71.z = v31.z;
			//       v72.z = *(float *)(v32 + 8);
			//       *(_QWORD *)&v71.x = v33;
			//       v34 = UnityEngine::Vector3::op_Addition((Vector3 *)v74, &v72, &v71, (MethodInfo *)v32);
			//       v35 = v34.z;
			//       *(_QWORD *)v36 = *(_QWORD *)&v34.x;
			//       *(float *)(v36 + 8) = v35;
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       v37 = (float *)sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( *v37 > 100.0 )
			//         break;
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       if ( *(float *)sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26) < -100.0 )
			//       {
			//         m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         v38 = (float *)sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//         v39 = *v38 + 100.0;
			// LABEL_21:
			//         *v38 = v39;
			//       }
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       v40 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( *(float *)(v40 + 4) > 100.0 )
			//       {
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         v41 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//         v42 = *(float *)(v41 + 4) - 100.0;
			//         goto LABEL_30;
			//       }
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       if ( *(float *)(sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26) + 4) < -100.0 )
			//       {
			//         m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         v41 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//         v42 = *(float *)(v41 + 4) + 100.0;
			// LABEL_30:
			//         *(float *)(v41 + 4) = v42;
			//       }
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( !m_sceneEffectSnowAxisOffsetList )
			//         goto LABEL_66;
			//       v43 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//       if ( *(float *)(v43 + 8) > 100.0 )
			//       {
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         v44 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//         v45 = *(float *)(v44 + 8) - 100.0;
			//       }
			//       else
			//       {
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         if ( *(float *)(sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26) + 8) >= -100.0 )
			//           goto LABEL_40;
			//         m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_sceneEffectSnowAxisOffsetList;
			//         if ( !m_sceneEffectSnowAxisOffsetList )
			//           goto LABEL_66;
			//         v44 = sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//         v45 = *(float *)(v44 + 8) + 100.0;
			//       }
			//       *(float *)(v44 + 8) = v45;
			// LABEL_40:
			//       if ( ++v26 >= 6 )
			//       {
			//         m_snowRenderParams = this.fields.m_snowRenderParams;
			//         if ( hgCamera )
			//         {
			//           m_sceneEffectSnowAxisOffsetList = (char *)hgCamera.fields.camera;
			//           if ( m_sceneEffectSnowAxisOffsetList )
			//           {
			//             transform = UnityEngine::Component::get_transform((Component *)m_sceneEffectSnowAxisOffsetList, 0LL);
			//             if ( transform )
			//             {
			//               position = UnityEngine::Transform::get_position((Vector3 *)v74, transform, 0LL);
			//               m_sceneEffectSnowAxisOffsetList = (char *)LODWORD(position.z);
			//               if ( m_snowRenderParams )
			//               {
			//                 *(_QWORD *)&m_snowRenderParams.fields.pos.x = *(_QWORD *)&position.x;
			//                 LODWORD(m_snowRenderParams.fields.pos.z) = (_DWORD)m_sceneEffectSnowAxisOffsetList;
			//                 m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_snowRenderParams;
			//                 snowRange_low = (__m128)LODWORD(snowCommonPreSettingParam.fields.snowRange);
			//                 maxSnowHeight_low = (__m128)LODWORD(snowCommonPreSettingParam.fields.maxSnowHeight);
			//                 snowRange_low.m128_f32[0] = snowRange_low.m128_f32[0] / this.fields.m_snowMeshExtents.x;
			//                 maxSnowHeight_low.m128_f32[0] = maxSnowHeight_low.m128_f32[0] / this.fields.m_snowMeshExtents.y;
			//                 v53 = snowCommonPreSettingParam.fields.snowRange / this.fields.m_snowMeshExtents.z;
			//                 if ( m_sceneEffectSnowAxisOffsetList )
			//                 {
			//                   *(_QWORD *)(m_sceneEffectSnowAxisOffsetList + 28) = _mm_unpacklo_ps(snowRange_low, maxSnowHeight_low).m128_u64[0];
			//                   *((float *)m_sceneEffectSnowAxisOffsetList + 9) = v53;
			//                   m_sceneEffectSnowAxisOffsetList = (char *)*snowCommonRenderingParam;
			//                   v54 = this.fields.m_snowRenderParams;
			//                   if ( *snowCommonRenderingParam )
			//                   {
			//                     v55 = _mm_loadu_si128((const __m128i *)(m_sceneEffectSnowAxisOffsetList + 28));
			//                     if ( v54 )
			//                     {
			//                       v54.fields.color = (Color)v55;
			//                       v56 = *snowCommonRenderingParam;
			//                       m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_snowRenderParams;
			//                       m_rainLayerOffset = this.fields.m_rainLayerOffset;
			//                       if ( *snowCommonRenderingParam )
			//                       {
			//                         y = v56.fields.snowSizeRange.y;
			//                         DWORD1(v74[0]) = LODWORD(v56.fields.snowSizeRange.x);
			//                         *(float *)&v59 = v56.fields.intensity * 0.0099999998;
			//                         *(float *)v74 = m_rainLayerOffset;
			//                         *((_QWORD *)&v74[0] + 1) = __PAIR64__(v59, LODWORD(y));
			//                         if ( m_sceneEffectSnowAxisOffsetList )
			//                         {
			//                           *(_OWORD *)(m_sceneEffectSnowAxisOffsetList + 40) = v74[0];
			//                           v60 = *snowCommonRenderingParam;
			//                           m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_snowRenderParams;
			//                           if ( *snowCommonRenderingParam )
			//                           {
			//                             z_low = (Texture2D *)LODWORD(v60.fields.snowDirection.z);
			//                             if ( m_sceneEffectSnowAxisOffsetList )
			//                             {
			//                               *((_QWORD *)m_sceneEffectSnowAxisOffsetList + 7) = *(_QWORD *)&v60.fields.snowDirection.x;
			//                               *((_DWORD *)m_sceneEffectSnowAxisOffsetList + 16) = (_DWORD)z_low;
			//                               m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_snowRenderParams;
			//                               if ( *snowCommonRenderingParam )
			//                               {
			//                                 v61 = (*snowCommonRenderingParam).fields.snowCommonPreSettingParam;
			//                                 if ( v61 )
			//                                 {
			//                                   z_low = v61.fields.snowflakeTex;
			//                                   if ( m_sceneEffectSnowAxisOffsetList )
			//                                   {
			//                                     *((_QWORD *)m_sceneEffectSnowAxisOffsetList + 12) = z_low;
			//                                     sub_1800054D0(
			//                                       (BSP *)(m_sceneEffectSnowAxisOffsetList + 96),
			//                                       (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)z_low,
			//                                       v49,
			//                                       v50,
			//                                       P3,
			//                                       v69);
			//                                     v62 = this.fields.m_snowRenderParams;
			//                                     if ( *snowCommonRenderingParam )
			//                                     {
			//                                       v63 = (*snowCommonRenderingParam).fields.snowCommonPreSettingParam;
			//                                       if ( v63 )
			//                                       {
			//                                         v64 = _mm_loadu_si128((const __m128i *)&v63.fields.snowflakeTex_ST);
			//                                         if ( v62 )
			//                                         {
			//                                           v62.fields.snowflakeTextureTilingOffset = (Vector4)v64;
			//                                           m_sceneEffectSnowAxisOffsetList = (char *)*snowCommonRenderingParam;
			//                                           v65 = this.fields.m_snowRenderParams;
			//                                           if ( *snowCommonRenderingParam )
			//                                           {
			//                                             if ( v65 )
			//                                             {
			//                                               v65.fields.snowDirectionJitterLevel = *((float *)m_sceneEffectSnowAxisOffsetList
			//                                                                                      + 17);
			//                                               m_sceneEffectSnowAxisOffsetList = (char *)this.fields.m_snowRenderParams;
			//                                               if ( *snowCommonRenderingParam )
			//                                               {
			//                                                 snowLayerCount = (*snowCommonRenderingParam).fields.snowLayerCount;
			//                                                 if ( snowLayerCount > 6 )
			//                                                   snowLayerCount = 6;
			//                                                 if ( m_sceneEffectSnowAxisOffsetList )
			//                                                 {
			//                                                   *((_DWORD *)m_sceneEffectSnowAxisOffsetList + 22) = snowLayerCount;
			//                                                   return;
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
			// LABEL_66:
			//         sub_180B536AC(m_sceneEffectSnowAxisOffsetList, z_low);
			//       }
			//     }
			//     if ( !m_sceneEffectSnowAxisOffsetList )
			//       goto LABEL_66;
			//     v38 = (float *)sub_18003EB60(m_sceneEffectSnowAxisOffsetList, v26);
			//     v39 = *v38 - 100.0;
			//     goto LABEL_21;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4777, 0LL);
			//   if ( !Patch )
			//     goto LABEL_66;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1381(
			//     Patch,
			//     (Object *)this,
			//     snowCommonRenderingParam,
			//     (Object *)hgCamera,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		internal override void SetMaterialData(in SnowCommonRenderingParam snowCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::SetMaterialData(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonRenderingParam **snowCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   char *static_fields; // rdx
			//   String **p_EDITOR_KW; // rcx
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rax
			//   float x; // xmm8_4
			//   float y; // xmm9_4
			//   float z; // xmm7_4
			//   float snowDirectionJitterLevel; // xmm6_4
			//   __m128i v14; // xmm6
			//   Vector4 *v15; // rax
			//   Material *m_snowMat; // rsi
			//   __m128i v17; // xmm7
			//   Material *v18; // rsi
			//   Material *v19; // rsi
			//   SnowCommonRenderingParam *v20; // rax
			//   Material *v21; // rbx
			//   unsigned int v22; // ebx
			//   MaterialPropertyBlock__Array *m_sceneEffectSnowMaterialPropertyBlockList; // rsi
			//   __int64 v24; // r14
			//   Bounds *v25; // r8
			//   Object__Array *v26; // r9
			//   MaterialPropertyBlock *v27; // rsi
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v28; // r8
			//   MethodInfo *v29; // r8
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v30; // rax
			//   Color *v31; // rax
			//   MaterialPropertyBlock *v32; // r10
			//   MaterialPropertyBlock *v33; // rsi
			//   MethodInfo *v34; // r8
			//   Vector4 *v35; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v37; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v38; // [rsp+30h] [rbp-41h]
			//   Vector3 v39; // [rsp+38h] [rbp-39h] BYREF
			//   Vector3 v40; // [rsp+48h] [rbp-29h] BYREF
			//   __m128i color; // [rsp+58h] [rbp-19h] BYREF
			//   Color v42; // [rsp+68h] [rbp-9h] BYREF
			//   Vector4 v43; // [rsp+78h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919D43 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     sub_18003C530(&off_18D5DF520);
			//     byte_18D919D43 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4778, 0LL) )
			//   {
			//     m_snowRenderParams = this.fields.m_snowRenderParams;
			//     if ( m_snowRenderParams )
			//     {
			//       x = m_snowRenderParams.fields.snowDirection.x;
			//       y = m_snowRenderParams.fields.snowDirection.y;
			//       z = m_snowRenderParams.fields.snowDirection.z;
			//       snowDirectionJitterLevel = m_snowRenderParams.fields.snowDirectionJitterLevel;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v14 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                (Vector4 *)&color,
			//                                                x,
			//                                                y,
			//                                                z,
			//                                                snowDirectionJitterLevel,
			//                                                0LL));
			//       if ( *snowCommonRenderingParam )
			//       {
			//         v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                 (Vector4 *)&color,
			//                 (float)(*snowCommonRenderingParam).fields.cameraMask,
			//                 (*snowCommonRenderingParam).fields.snowLightingPercent,
			//                 (*snowCommonRenderingParam).fields.snowCollisionFadeTimeScale,
			//                 this.fields.m_snowHorizontalOffset,
			//                 0LL);
			//         m_snowMat = this.fields.m_snowMat;
			//         v17 = _mm_loadu_si128((const __m128i *)v15);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//         static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer.static_fields;
			//         if ( m_snowMat )
			//         {
			//           UnityEngine::Material::EnableKeyword(m_snowMat, *((String **)static_fields + 2), 0LL);
			//           if ( *snowCommonRenderingParam )
			//           {
			//             if ( (*snowCommonRenderingParam).fields.enableSnowLighting
			//               && (*snowCommonRenderingParam).fields.snowLightingPercent > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//             {
			//               v18 = this.fields.m_snowMat;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//               static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//               if ( !v18 )
			//                 goto LABEL_56;
			//               UnityEngine::Material::EnableKeyword(v18, *((String **)static_fields + 1), 0LL);
			//             }
			//             else
			//             {
			//               v19 = this.fields.m_snowMat;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//               static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//               if ( !v19 )
			//                 goto LABEL_56;
			//               UnityEngine::Material::DisableKeyword(v19, *((String **)static_fields + 1), 0LL);
			//             }
			//             v20 = *snowCommonRenderingParam;
			//             if ( *snowCommonRenderingParam )
			//             {
			//               v21 = this.fields.m_snowMat;
			//               if ( v20.fields.enableSnowCollision )
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//                 static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer.static_fields;
			//                 if ( !v21 )
			//                   goto LABEL_56;
			//                 UnityEngine::Material::EnableKeyword(v21, *((String **)static_fields + 3), 0LL);
			//               }
			//               else
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//                 p_EDITOR_KW = &TypeInfo::HG::Rendering::Runtime::HGSnowRenderer.static_fields.EDITOR_KW;
			//                 if ( !v21 )
			//                   goto LABEL_56;
			//                 UnityEngine::Material::DisableKeyword(v21, p_EDITOR_KW[3], 0LL);
			//               }
			//               v22 = 0;
			//               while ( 1 )
			//               {
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 if ( !p_EDITOR_KW[(int)v22 + 4] )
			//                 {
			//                   m_sceneEffectSnowMaterialPropertyBlockList = this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                   v24 = sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//                   if ( !v24 )
			//                     break;
			//                   *(_QWORD *)(v24 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//                   if ( v22 >= m_sceneEffectSnowMaterialPropertyBlockList.max_length.size )
			//                     goto LABEL_54;
			//                   m_sceneEffectSnowMaterialPropertyBlockList.vector[v22] = (MaterialPropertyBlock *)v24;
			//                   sub_1800054D0(
			//                     (BSP *)&m_sceneEffectSnowMaterialPropertyBlockList.vector[v22],
			//                     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)static_fields,
			//                     v25,
			//                     v26,
			//                     v37,
			//                     v38);
			//                 }
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			// LABEL_54:
			//                   sub_180070270(p_EDITOR_KW, static_fields);
			//                 v27 = (MaterialPropertyBlock *)p_EDITOR_KW[(int)v22 + 4];
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 v28 = this.fields.m_snowRenderParams;
			//                 if ( !v28 )
			//                   break;
			//                 HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//                   v27,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainTex0,
			//                   (Texture *)v28.fields.snowflakeTexture,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 static_fields = (char *)this.fields.m_snowRenderParams;
			//                 if ( !static_fields )
			//                   break;
			//                 p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 color = *(__m128i *)(static_fields + 104);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   (MaterialPropertyBlock *)p_EDITOR_KW,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainTex0_ST,
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 static_fields = (char *)this.fields.m_snowRenderParams;
			//                 if ( !static_fields )
			//                   break;
			//                 p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 color = *(__m128i *)(static_fields + 40);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   (MaterialPropertyBlock *)p_EDITOR_KW,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainParams,
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 color = v14;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   (MaterialPropertyBlock *)p_EDITOR_KW,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainDirectionParams,
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 v30 = this.fields.m_snowRenderParams;
			//                 if ( !v30 )
			//                   break;
			//                 color = (__m128i)v30.fields.color;
			//                 v31 = UnityEngine::Color::op_Implicit(&v42, (Vector4 *)&color, v29);
			//                 if ( !v32 )
			//                   break;
			//                 color = *(__m128i *)v31;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   v32,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainColor,
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 p_EDITOR_KW = (String **)p_EDITOR_KW[(int)v22 + 4];
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 color = v17;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   (MaterialPropertyBlock *)p_EDITOR_KW,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainMaskParams,
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 if ( v22 >= *((_DWORD *)p_EDITOR_KW + 6) )
			//                   goto LABEL_54;
			//                 v33 = (MaterialPropertyBlock *)p_EDITOR_KW[(int)v22 + 4];
			//                 p_EDITOR_KW = (String **)this.fields.m_sceneEffectSnowAxisOffsetList;
			//                 if ( !p_EDITOR_KW )
			//                   break;
			//                 sub_180040F70(p_EDITOR_KW, &v39, (int)v22);
			//                 v40 = v39;
			//                 v35 = UnityEngine::Vector4::op_Implicit(&v43, &v40, v34);
			//                 if ( !v33 )
			//                   break;
			//                 color = *(__m128i *)v35;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   v33,
			//                   (String *)"_RainOffsetParams",
			//                   (Vector4 *)&color,
			//                   0LL);
			//                 if ( (int)++v22 >= 6 )
			//                   return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_56:
			//     sub_180B536AC(p_EDITOR_KW, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4778, 0LL);
			//   if ( !Patch )
			//     goto LABEL_56;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(Patch, (Object *)this, snowCommonRenderingParam, context, 0LL);
			// }
			// 
		}

		internal override void UpdateRendererObjs(in SnowCommonRenderingParam snowCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(SnowCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::UpdateRendererObjs(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonRenderingParam **snowCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Renderer *v7; // rcx
			//   MeshRenderer__Array *v8; // rdx
			//   int v9; // ebx
			//   int32_t snowLayerCount; // r15d
			//   Transform__Array *m_sceneEffectRainTransList; // rax
			//   Transform *v12; // rdi
			//   Transform__Array *v13; // rax
			//   Transform *v14; // rdi
			//   __int64 (__fastcall *v15)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *); // rax
			//   __int64 v16; // rdi
			//   void (__fastcall *v17)(__int64, _QWORD); // rax
			//   String *v18; // rax
			//   String *v19; // rbp
			//   GameObject *v20; // rax
			//   Object_1 *v21; // rdi
			//   struct HGBaseSubSnowRenderer__Class *v22; // rdx
			//   Transform__Array *v23; // rbp
			//   Transform *transform; // rax
			//   Transform *v25; // r14
			//   MeshRenderer__Array *m_sceneEffectRainRdList; // rbp
			//   Object *v27; // rax
			//   Object *v28; // r14
			//   Object *v29; // rax
			//   MeshFilter *v30; // rbp
			//   Object_1 *camera; // rbp
			//   Transform *v32; // rax
			//   Transform *v33; // rbp
			//   Transform *v34; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Transform *v37; // rdi
			//   void (__fastcall *v38)(Transform *, unsigned __int64 *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *m_snowRenderParams; // rax
			//   GameObject *gameObject; // rax
			//   Transform__Array *v42; // rax
			//   Quaternion *identity; // rax
			//   MaterialPropertyBlock__Array *s_sceneEffectLayerScale; // rdx
			//   struct HGSceneEffectSnowRenderer__Class *v45; // rcx
			//   Transform *v46; // r9
			//   HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *v47; // rax
			//   __int64 v48; // xmm0_8
			//   float z; // eax
			//   struct HGSceneEffectSnowRenderer__Class **static_fields; // rax
			//   float v51; // xmm1_4
			//   Transform__Array *v52; // rax
			//   MeshRenderer__Array *v53; // rax
			//   __int64 v54; // rax
			//   __int64 v55; // rax
			//   Int32 v56; // [rsp+30h] [rbp-88h] BYREF
			//   __int64 v57; // [rsp+38h] [rbp-80h]
			//   float v58; // [rsp+40h] [rbp-78h]
			//   unsigned __int64 v59; // [rsp+50h] [rbp-68h] BYREF
			//   int v60; // [rsp+58h] [rbp-60h]
			//   Vector3 v61; // [rsp+60h] [rbp-58h] BYREF
			//   Quaternion value; // [rsp+70h] [rbp-48h] BYREF
			//   Quaternion v63; // [rsp+80h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDC23 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9B3CA8);
			//     byte_18D8EDC23 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, snowCommonRenderingParam);
			//     v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(MeshRenderer__Array **)v7[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_56;
			//   if ( v8.max_length.size <= 4779 )
			//     goto LABEL_9;
			//   if ( !LODWORD(v7[9].monitor) )
			//   {
			//     il2cpp_runtime_class_init_0(v7, v8);
			//     v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(MeshRenderer__Array **)v7[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_56;
			//   if ( v8.max_length.size <= 0x12ABu )
			// LABEL_60:
			//     sub_180070270(v7, v8);
			//   if ( !v8[132].vector[27] )
			//   {
			// LABEL_9:
			//     if ( !*snowCommonRenderingParam )
			//       goto LABEL_56;
			//     v9 = 0;
			//     if ( (*snowCommonRenderingParam).fields.enable )
			//     {
			//       m_snowRenderParams = this.fields.m_snowRenderParams;
			//       if ( !m_snowRenderParams )
			//         goto LABEL_56;
			//       snowLayerCount = m_snowRenderParams.fields.snowLayerCount;
			//     }
			//     else
			//     {
			//       snowLayerCount = 0;
			//     }
			//     v56.m_value = 0;
			//     while ( 1 )
			//     {
			//       m_sceneEffectRainTransList = this.fields.m_sceneEffectRainTransList;
			//       if ( !m_sceneEffectRainTransList )
			//         break;
			//       v7 = (Renderer *)v9;
			//       if ( (unsigned int)v9 >= m_sceneEffectRainTransList.max_length.size )
			//         goto LABEL_60;
			//       v12 = m_sceneEffectRainTransList.vector[v9];
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !v12 )
			//         goto LABEL_37;
			//       v7 = (Renderer *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !v12.fields._._.m_CachedPtr )
			//       {
			// LABEL_37:
			//         v18 = System::Int32::ToString(&v56, 0LL);
			//         v19 = System::String::Concat((String *)"!SCENE_EFFECT_SNOW_OBJ", v18, 0LL);
			//         v20 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//         v21 = (Object_1 *)v20;
			//         if ( !v20 )
			//           break;
			//         UnityEngine::GameObject::GameObject(v20, v19, 0LL);
			//         v22 = TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer;
			//         if ( !TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(
			//             TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer,
			//             TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer);
			//           v22 = TypeInfo::HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer;
			//         }
			//         UnityEngine::Object::set_hideFlags(v21, v22.static_fields.RSC_HIDE_FLAGS, 0LL);
			//         v23 = this.fields.m_sceneEffectRainTransList;
			//         transform = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//         v25 = transform;
			//         if ( !v23 )
			//           break;
			//         sub_180036D40(v23, transform);
			//         sub_18000FDA0(v23, v9, v25);
			//         m_sceneEffectRainRdList = this.fields.m_sceneEffectRainRdList;
			//         v27 = UnityEngine::GameObject::AddComponent<System::Object>(
			//                 (GameObject *)v21,
			//                 MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//         v28 = v27;
			//         if ( !m_sceneEffectRainRdList )
			//           break;
			//         sub_180036D40(m_sceneEffectRainRdList, v27);
			//         sub_18000FDA0(m_sceneEffectRainRdList, v9, v28);
			//         v29 = UnityEngine::GameObject::AddComponent<System::Object>(
			//                 (GameObject *)v21,
			//                 MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//         v8 = this.fields.m_sceneEffectRainRdList;
			//         v30 = (MeshFilter *)v29;
			//         if ( !v8 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v8.max_length.size )
			//           goto LABEL_60;
			//         v7 = (Renderer *)v8.vector[v9];
			//         if ( !v7 )
			//           break;
			//         UnityEngine::Renderer::SetMaterial(v7, this.fields.m_snowMat, 0LL);
			//         if ( !v30 )
			//           break;
			//         UnityEngine::MeshFilter::set_sharedMesh(v30, this.fields.m_snowMesh, 0LL);
			//         if ( hgCamera )
			//         {
			//           camera = (Object_1 *)hgCamera.fields.camera;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//           if ( UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//           {
			//             v32 = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//             v7 = (Renderer *)hgCamera.fields.camera;
			//             v33 = v32;
			//             if ( !v7 )
			//               break;
			//             v34 = UnityEngine::Component::get_transform((Component *)v7, 0LL);
			//             if ( !v33 )
			//               break;
			//             UnityEngine::Transform::SetParent(v33, v34, 1, 0LL);
			//             v37 = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//             if ( !v37 )
			//               sub_180B536AC(v36, v35);
			//             v38 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18D8F52F8;
			//             v59 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//             v60 = 0;
			//             if ( !qword_18D8F52F8 )
			//             {
			//               v38 = (void (__fastcall *)(Transform *, unsigned __int64 *))sub_180017470(
			//                                                                             "UnityEngine.Transform::set_localPosition_Inj"
			//                                                                             "ected(UnityEngine.Vector3&)");
			//               qword_18D8F52F8 = (__int64)v38;
			//             }
			//             v38(v37, &v59);
			//           }
			//         }
			//       }
			//       v13 = this.fields.m_sceneEffectRainTransList;
			//       if ( v9 < snowLayerCount )
			//       {
			//         if ( !v13 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v13.max_length.size )
			//           goto LABEL_60;
			//         v7 = (Renderer *)v13.vector[v9];
			//         if ( !v7 )
			//           break;
			//         gameObject = UnityEngine::Component::get_gameObject((Component *)v7, 0LL);
			//         if ( !gameObject )
			//           break;
			//         UnityEngine::GameObject::SetActive(gameObject, 1, 0LL);
			//         v42 = this.fields.m_sceneEffectRainTransList;
			//         if ( !v42 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v42.max_length.size )
			//           goto LABEL_60;
			//         identity = UnityEngine::Quaternion::get_identity(&v63, (MethodInfo *)v8);
			//         if ( !v46 )
			//           goto LABEL_96;
			//         value = *identity;
			//         UnityEngine::Transform::set_rotation_Injected(v46, &value, 0LL);
			//         v47 = this.fields.m_snowRenderParams;
			//         if ( !v47 )
			//           goto LABEL_96;
			//         v48 = *(_QWORD *)&v47.fields.scale.x;
			//         v45 = TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer;
			//         z = v47.fields.scale.z;
			//         v57 = v48;
			//         v58 = z;
			//         if ( !TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(
			//             TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer,
			//             s_sceneEffectLayerScale);
			//           v45 = TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer;
			//         }
			//         s_sceneEffectLayerScale = (MaterialPropertyBlock__Array *)v45.static_fields.s_sceneEffectLayerScale;
			//         if ( !s_sceneEffectLayerScale )
			//           goto LABEL_96;
			//         if ( (unsigned int)v9 >= s_sceneEffectLayerScale.max_length.size )
			//           goto LABEL_95;
			//         static_fields = (struct HGSceneEffectSnowRenderer__Class **)v45.static_fields;
			//         *(float *)&v57 = *(float *)&v57 * *((float *)s_sceneEffectLayerScale.vector + v9);
			//         v45 = *static_fields;
			//         if ( !*static_fields )
			//           goto LABEL_96;
			//         if ( (unsigned int)v9 >= LODWORD(v45._0.namespaze) )
			//           goto LABEL_95;
			//         v51 = v58 * *((float *)&v45._0.byval_arg.data.__klassIndex + v9);
			//         v52 = this.fields.m_sceneEffectRainTransList;
			//         if ( !v52 )
			//           goto LABEL_96;
			//         v45 = (struct HGSceneEffectSnowRenderer__Class *)v9;
			//         if ( (unsigned int)v9 >= v52.max_length.size )
			//           goto LABEL_95;
			//         v45 = (struct HGSceneEffectSnowRenderer__Class *)v52.vector[v9];
			//         if ( !v45 )
			//           goto LABEL_96;
			//         *(_QWORD *)&v61.x = v57;
			//         v61.z = v51;
			//         UnityEngine::Transform::set_localScale_Injected((Transform *)v45, &v61, 0LL);
			//         v53 = this.fields.m_sceneEffectRainRdList;
			//         if ( !v53 )
			//           goto LABEL_96;
			//         v45 = (struct HGSceneEffectSnowRenderer__Class *)v9;
			//         if ( (unsigned int)v9 >= v53.max_length.size )
			//           goto LABEL_95;
			//         s_sceneEffectLayerScale = this.fields.m_sceneEffectSnowMaterialPropertyBlockList;
			//         v45 = (struct HGSceneEffectSnowRenderer__Class *)v53.vector[v9];
			//         if ( !s_sceneEffectLayerScale )
			//           goto LABEL_96;
			//         if ( (unsigned int)v9 >= s_sceneEffectLayerScale.max_length.size )
			// LABEL_95:
			//           sub_180070270(v45, s_sceneEffectLayerScale);
			//         if ( !v45 )
			// LABEL_96:
			//           sub_180B536AC(v45, s_sceneEffectLayerScale);
			//         UnityEngine::Renderer::Internal_SetPropertyBlock((Renderer *)v45, s_sceneEffectLayerScale.vector[v9], 0LL);
			//       }
			//       else
			//       {
			//         if ( !v13 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v13.max_length.size )
			//           goto LABEL_60;
			//         v14 = v13.vector[v9];
			//         if ( !v14 )
			//           break;
			//         v15 = (__int64 (__fastcall *)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *))qword_18D8F4D48;
			//         if ( !qword_18D8F4D48 )
			//         {
			//           v15 = (__int64 (__fastcall *)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//           if ( !v15 )
			//           {
			//             v54 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//             sub_18000F750(v54, 0LL);
			//           }
			//           qword_18D8F4D48 = (__int64)v15;
			//         }
			//         v16 = v15(v14, v8, hgCamera, method);
			//         if ( !v16 )
			//           break;
			//         v17 = (void (__fastcall *)(__int64, _QWORD))qword_18D8F4DF8;
			//         if ( !qword_18D8F4DF8 )
			//         {
			//           v17 = (void (__fastcall *)(__int64, _QWORD))il2cpp_resolve_icall_0("UnityEngine.GameObject::SetActive(System.Boolean)");
			//           if ( !v17 )
			//           {
			//             v55 = sub_1802DBBE8("UnityEngine.GameObject::SetActive(System.Boolean)");
			//             sub_18000F750(v55, 0LL);
			//           }
			//           qword_18D8F4DF8 = (__int64)v17;
			//         }
			//         v17(v16, 0LL);
			//       }
			//       v56.m_value = ++v9;
			//       if ( v9 >= 6 )
			//         return;
			//     }
			// LABEL_56:
			//     sub_180B536AC(v7, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4779, 0LL);
			//   if ( !Patch )
			//     goto LABEL_56;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//     Patch,
			//     (Object *)this,
			//     snowCommonRenderingParam,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		internal override void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::Dispose(
			//         HGSceneEffectSnowRenderer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // ebx
			//   Transform__Array *m_sceneEffectRainTransList; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4780, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4780, 0LL);
			//     if ( !Patch )
			// LABEL_8:
			//       sub_180B536AC(v4, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_sceneEffectRainTransList = this.fields.m_sceneEffectRainTransList;
			//       if ( !m_sceneEffectRainTransList )
			//         goto LABEL_8;
			//       if ( i >= m_sceneEffectRainTransList.max_length.size )
			//         break;
			//       if ( (unsigned int)i >= m_sceneEffectRainTransList.max_length.size )
			//         sub_180070270(v4, v3);
			//       HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeRendererObj(
			//         (HGBaseSubSnowRenderer *)this,
			//         m_sceneEffectRainTransList.vector[i],
			//         0LL);
			//     }
			//     HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeMaterial(
			//       (HGBaseSubSnowRenderer *)this,
			//       this.fields.m_snowMat,
			//       0LL);
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_SetMaterialData(ref SnowCommonRenderingParam P0, ref ScriptableRenderContext P1)
		{
			// // Void <>iFixBaseProxy_SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_SetMaterialData(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonRenderingParam **P0,
			//         ScriptableRenderContext *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::SetMaterialData((HGBaseSubSnowRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_UpdateRendererObjs(ref SnowCommonRenderingParam P0, HGCamera P1)
		{
			// // Void <>iFixBaseProxy_UpdateRendererObjs(SnowCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_UpdateRendererObjs(
			//         HGSceneEffectSnowRenderer *this,
			//         SnowCommonRenderingParam **P0,
			//         HGCamera *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::UpdateRendererObjs((HGBaseSubSnowRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose()
		{
			// // Void <>iFixBaseProxy_Dispose()
			// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::__iFixBaseProxy_Dispose(
			//         HGSceneEffectSnowRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Dispose((HGBaseSubSnowRenderer *)this, 0LL);
			// }
			// 
		}

		private Mesh m_snowMesh;

		private Vector3 m_snowMeshExtents;

		private Shader m_snowShader;

		private Material m_snowMat;

		private MaterialPropertyBlock m_materialPropertyBlock;

		private HGSceneEffectSnowRenderer.SceneEffectSnowRenderParams m_snowRenderParams;

		private float m_rainLayerOffset;

		private float m_rainLayerNoise;

		private float m_snowVerticalOffset;

		private float m_snowHorizontalOffset;

		private const int s_maxSceneEffectLayerCount = 6;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly float[] s_sceneEffectLayerScale;

		private const string s_sceneEffectRainObjPrefix = "!SCENE_EFFECT_SNOW_OBJ";

		private const float s_snowHeight = 50f;

		private Transform[] m_sceneEffectRainTransList;

		private MeshRenderer[] m_sceneEffectRainRdList;

		private Vector3[] m_sceneEffectSnowAxisOffsetList;

		private MaterialPropertyBlock[] m_sceneEffectSnowMaterialPropertyBlockList;

		internal class SceneEffectSnowRenderParams
		{
			public SceneEffectSnowRenderParams()
			{
				// // HGSceneEffectSnowRenderer+SceneEffectSnowRenderParams()
				// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::SceneEffectSnowRenderParams::SceneEffectSnowRenderParams(
				//         HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *this,
				//         MethodInfo *method)
				// {
				//   Vector3Int *v2; // r8
				//   ITilemap *v3; // r9
				//   TileBase *v5; // rdx
				//   Vector3Int *v6; // r8
				//   ITilemap *v7; // r9
				//   Color v8; // xmm1
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v9; // rdx
				//   Bounds *v10; // r8
				//   Object__Array *v11; // r9
				//   TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   *(_QWORD *)&this.fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.pos.z = 0.0;
				//   *(_QWORD *)&this.fields.scale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
				//   this.fields.scale.z = 1.0;
				//   this.fields.snowParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v12,
				//                                         (TileBase *)method,
				//                                         v2,
				//                                         v3,
				//                                         (MethodInfo *)v12.m_AnimatedSprites);
				//   *(_QWORD *)&this.fields.snowDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.snowDirection.z = 0.0;
				//   v8 = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                  &v12,
				//                  v5,
				//                  v6,
				//                  v7,
				//                  (MethodInfo *)v12.m_AnimatedSprites);
				//   this.fields.snowLayerCount = 1;
				//   this.fields.color = v8;
				//   this.fields.snowflakeTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (BSP *)&this.fields.snowflakeTexture,
				//     v9,
				//     v10,
				//     v11,
				//     (MethodInfo *)v12.m_AnimatedSprites,
				//     *(MethodInfo **)&v12.m_AnimationSpeed);
				//   this.fields.snowflakeTextureTilingOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				// }
				// 
			}

			public Vector3 pos;

			public Vector3 scale;

			public Vector4 snowParams;

			public Vector3 snowDirection;

			public float snowDirectionJitterLevel;

			public Color color;

			public int snowLayerCount;

			public Texture2D snowflakeTexture;

			public Vector4 snowflakeTextureTilingOffset;
		}
	}
}
