using System;
using HG.Rendering.Runtime.Rain;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGScreenRainDropFXRenderer : HGBaseSubRainRenderer
	{
		public HGScreenRainDropFXRenderer()
		{
		}

		internal override void PrepareResources(RainCommonResources commonResources)
		{
			// // Void PrepareResources(RainCommonResources)
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::PrepareResources(
			//         HGScreenRainDropFXRenderer *this,
			//         RainCommonResources *commonResources,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   Material *v6; // rcx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   Shader *screenRainDropFXShader; // r9
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   __int64 v12; // rdx
			//   Shader *m_screenDropShader; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   __int64 v17; // rdx
			//   Object_1 *m_screenDropMat; // rdi
			//   struct HGBaseSubRainRenderer__Class *v19; // rax
			//   Object_1 *v20; // rdi
			//   HideFlags__Enum *static_fields; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-20h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v29; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC9C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC9C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1337, 0LL) )
			//   {
			//     if ( commonResources )
			//     {
			//       this.fields.m_screenDropMesh = commonResources.fields.screenDropFxMesh;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_screenDropMesh, v5, v7, v8, methoda, v26);
			//       screenRainDropFXShader = commonResources.fields.screenRainDropFXShader;
			//       this.fields.m_screenDropShader = screenRainDropFXShader;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&this.fields.m_screenDropShader,
			//         v10,
			//         v11,
			//         (HGCamera *)screenRainDropFXShader,
			//         methodc,
			//         v27);
			//       m_screenDropShader = this.fields.m_screenDropShader;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v12);
			//       this.fields.m_screenDropMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                                        m_screenDropShader,
			//                                        0,
			//                                        0LL);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_screenDropMat, v14, v15, v16, methodb, v28);
			//       m_screenDropMat = (Object_1 *)this.fields.m_screenDropMat;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//       if ( !UnityEngine::Object::op_Inequality(0LL, m_screenDropMat, 0LL) )
			//         goto LABEL_15;
			//       v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//       v20 = (Object_1 *)this.fields.m_screenDropMat;
			//       if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, v5);
			//         v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//       }
			//       static_fields = (HideFlags__Enum *)v19.static_fields;
			//       if ( v20 )
			//       {
			//         UnityEngine::Object::set_hideFlags(v20, *static_fields, 0LL);
			//         v6 = this.fields.m_screenDropMat;
			//         if ( v6 )
			//         {
			//           UnityEngine::Material::set_renderQueue(v6, 3003, 0LL);
			// LABEL_15:
			//           v29 = 0LL;
			//           Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//             &v29,
			//             30,
			//             Allocator__Enum_Persistent,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//           this.fields.m_dropRenderDatas = (NativeArray_1_UnityEngine_Vector4_)v29;
			//           HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(this, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1337, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)commonResources,
			//     0LL);
			// }
			// 
		}

		internal override void UpdateData(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::UpdateData(
			//         HGScreenRainDropFXRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *screenDropFXNoiseTex; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   char *m_screenRainDropFXRendererParams; // rcx
			//   __m128i v12; // xmm0
			//   RainCommonPreSettingParam *commonPresettingParam; // rax
			//   int v14; // r8d
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v15; // r9
			//   RainCommonPreSettingParam *v16; // rax
			//   __m128i v17; // xmm0
			//   RainCommonRenderingParam *v18; // rax
			//   float x; // xmm0_4
			//   float y; // xmm1_4
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v21; // rax
			//   unsigned int v22; // xmm2_4
			//   RainCommonRenderingParam *v23; // rax
			//   float v24; // xmm15_4
			//   float v25; // xmm12_4
			//   int v26; // eax
			//   int v27; // r15d
			//   __int64 v28; // xmm6_8
			//   int v29; // r14d
			//   Transform *transform; // rax
			//   Vector3 *right; // rax
			//   __int64 v32; // xmm0_8
			//   __int64 v33; // rax
			//   __int64 v34; // xmm6_8
			//   float v35; // r14d
			//   double v36; // xmm0_8
			//   float v37; // xmm7_4
			//   Transform *v38; // rax
			//   Vector3 *v39; // rax
			//   __int64 v40; // xmm0_8
			//   MethodInfo *v41; // r8
			//   MethodInfo *v42; // rdx
			//   unsigned int v43; // edi
			//   float v44; // xmm14_4
			//   Vector4__Array *m_DropRenderParam; // r14
			//   Vector4 *NewDropInfo; // rax
			//   Vector4__Array *m_dropUpdateData; // r14
			//   float screenDropFlowPercent; // xmm6_4
			//   __int64 v49; // rax
			//   Vector4__Array *v50; // r14
			//   float v51; // xmm6_4
			//   float v52; // xmm0_4
			//   float v53; // xmm7_4
			//   float s_jitterTime; // xmm6_4
			//   float screenDropJitterSpeedScale; // xmm8_4
			//   float v56; // xmm6_4
			//   double v57; // xmm0_8
			//   __int64 v58; // rax
			//   float *v59; // rax
			//   float v60; // xmm6_4
			//   __int64 v61; // rax
			//   float v62; // xmm6_4
			//   __int64 v63; // rax
			//   __int64 m_visibleCount; // r14
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v67; // [rsp+30h] [rbp-D8h]
			//   Vector2 v68; // [rsp+38h] [rbp-D0h]
			//   Vector2 screenDropMinMaxSize; // [rsp+40h] [rbp-C8h]
			//   Vector2 screenDropMinMaxLifeTime; // [rsp+48h] [rbp-C0h]
			//   Vector4 v71; // [rsp+58h] [rbp-B0h] BYREF
			//   __int128 v72; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector4 v73; // [rsp+78h] [rbp-90h] BYREF
			//   Vector4 v74; // [rsp+88h] [rbp-80h] BYREF
			// 
			//   if ( !byte_18D919DB5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D919DB5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1339, 0LL) )
			//   {
			//     m_screenRainDropFXRendererParams = (char *)this.fields.m_screenRainDropFXRendererParams;
			//     if ( *rainCommonRenderingParam )
			//     {
			//       v12 = _mm_loadu_si128((const __m128i *)&(*rainCommonRenderingParam).fields.screenDropColor);
			//       if ( m_screenRainDropFXRendererParams )
			//       {
			//         *((__m128i *)m_screenRainDropFXRendererParams + 1) = v12;
			//         m_screenRainDropFXRendererParams = (char *)this.fields.m_screenRainDropFXRendererParams;
			//         if ( *rainCommonRenderingParam )
			//         {
			//           commonPresettingParam = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//           if ( commonPresettingParam )
			//           {
			//             screenDropFXNoiseTex = (HGRenderPathBase_HGRenderPathResources *)commonPresettingParam.fields.screenDropFXNoiseTex;
			//             if ( m_screenRainDropFXRendererParams )
			//             {
			//               *((_QWORD *)m_screenRainDropFXRendererParams + 6) = screenDropFXNoiseTex;
			//               sub_1800054D0(
			//                 (HGRenderPathScene *)(m_screenRainDropFXRendererParams + 48),
			//                 screenDropFXNoiseTex,
			//                 v9,
			//                 v10,
			//                 P3,
			//                 v67);
			//               v15 = this.fields.m_screenRainDropFXRendererParams;
			//               if ( *rainCommonRenderingParam )
			//               {
			//                 v16 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//                 if ( v16 )
			//                 {
			//                   v17 = _mm_loadu_si128((const __m128i *)&v16.fields.screenDropFXNoiseTex_ST);
			//                   if ( v15 )
			//                   {
			//                     v15.fields.noiseTextureScaleOffset = (Vector4)v17;
			//                     v18 = *rainCommonRenderingParam;
			//                     if ( *rainCommonRenderingParam )
			//                     {
			//                       m_screenRainDropFXRendererParams = (char *)v18.fields.commonPresettingParam;
			//                       if ( m_screenRainDropFXRendererParams )
			//                       {
			//                         x = v18.fields.screenDropCentroidFadeParam.x;
			//                         y = v18.fields.screenDropCentroidFadeParam.y;
			//                         v21 = this.fields.m_screenRainDropFXRendererParams;
			//                         v22 = *((_DWORD *)m_screenRainDropFXRendererParams + 46);
			//                         v73.x = *((float *)m_screenRainDropFXRendererParams + 45);
			//                         *(_QWORD *)&v73.y = __PAIR64__(LODWORD(x), v22);
			//                         v73.w = y;
			//                         if ( v21 )
			//                         {
			//                           v21.fields.rainParams = v73;
			//                           v23 = *rainCommonRenderingParam;
			//                           if ( *rainCommonRenderingParam )
			//                           {
			//                             m_screenRainDropFXRendererParams = (char *)v23.fields.commonPresettingParam;
			//                             v24 = v23.fields.screenDropMinMaxSpeed.x;
			//                             v25 = v23.fields.screenDropMinMaxSpeed.y;
			//                             screenDropMinMaxLifeTime = v23.fields.screenDropMinMaxLifeTime;
			//                             screenDropMinMaxSize = v23.fields.screenDropMinMaxSize;
			//                             if ( m_screenRainDropFXRendererParams )
			//                             {
			//                               v68 = *(Vector2 *)(m_screenRainDropFXRendererParams + 172);
			//                               if ( v23 )
			//                               {
			//                                 v26 = sub_182592070(
			//                                         (unsigned int)v23.fields.screenDropMaxCountLim,
			//                                         (_BYTE)screenDropFXNoiseTex,
			//                                         v14);
			//                                 m_screenRainDropFXRendererParams = (char *)*rainCommonRenderingParam;
			//                                 v27 = v26;
			//                                 if ( *rainCommonRenderingParam )
			//                                 {
			//                                   v28 = *(_QWORD *)(m_screenRainDropFXRendererParams + 100);
			//                                   v29 = *((_DWORD *)m_screenRainDropFXRendererParams + 27);
			//                                   if ( hgCamera )
			//                                   {
			//                                     m_screenRainDropFXRendererParams = (char *)hgCamera.fields.camera;
			//                                     if ( m_screenRainDropFXRendererParams )
			//                                     {
			//                                       transform = UnityEngine::Component::get_transform(
			//                                                     (Component *)m_screenRainDropFXRendererParams,
			//                                                     0LL);
			//                                       if ( transform )
			//                                       {
			//                                         right = UnityEngine::Transform::get_right((Vector3 *)&v72, transform, 0LL);
			//                                         v32 = *(_QWORD *)&right.x;
			//                                         *(float *)&right = right.z;
			//                                         *(_QWORD *)&v71.x = v32;
			//                                         LODWORD(v71.z) = (_DWORD)right;
			//                                         *(_QWORD *)&v72 = v28;
			//                                         DWORD2(v72) = v29;
			//                                         v33 = sub_1827E4890(&v73, &v72, &v71);
			//                                         v34 = *(_QWORD *)v33;
			//                                         v35 = *(float *)(v33 + 8);
			//                                         *(_QWORD *)&v72 = *(_QWORD *)v33;
			//                                         *((float *)&v72 + 2) = v35;
			//                                         v36 = sub_18238EFA0(&v72);
			//                                         m_screenRainDropFXRendererParams = (char *)hgCamera.fields.camera;
			//                                         v37 = *(float *)&v36;
			//                                         if ( m_screenRainDropFXRendererParams )
			//                                         {
			//                                           v38 = UnityEngine::Component::get_transform(
			//                                                   (Component *)m_screenRainDropFXRendererParams,
			//                                                   0LL);
			//                                           if ( v38 )
			//                                           {
			//                                             v39 = UnityEngine::Transform::get_right((Vector3 *)&v73, v38, 0LL);
			//                                             *(_QWORD *)&v71.x = v34;
			//                                             v71.z = v35;
			//                                             v40 = *(_QWORD *)&v39.x;
			//                                             *(float *)&v39 = v39.z;
			//                                             *(_QWORD *)&v72 = v40;
			//                                             DWORD2(v72) = (_DWORD)v39;
			//                                             *(float *)&v40 = UnityEngine::Vector3::Dot(
			//                                                                (Vector3 *)&v71,
			//                                                                (Vector3 *)&v72,
			//                                                                v41);
			//                                             *(float *)&v40 = UnityEngine::Mathf::Sign(*(float *)&v40, v42);
			//                                             this.fields.m_visibleCount = 0;
			//                                             v43 = 0;
			//                                             v44 = *(float *)&v40 * v37;
			//                                             while ( 1 )
			//                                             {
			//                                               if ( (int)v43 < v27 )
			//                                               {
			//                                                 m_screenRainDropFXRendererParams = (char *)this.fields.m_dropActive;
			//                                                 if ( !m_screenRainDropFXRendererParams )
			//                                                   break;
			//                                                 if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
			//                                                   goto LABEL_71;
			//                                                 if ( !m_screenRainDropFXRendererParams[v43 + 32] )
			//                                                 {
			//                                                   m_DropRenderParam = this.fields.m_DropRenderParam;
			//                                                   NewDropInfo = HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropInfo(
			//                                                                   &v71,
			//                                                                   this,
			//                                                                   screenDropMinMaxLifeTime,
			//                                                                   screenDropMinMaxSize,
			//                                                                   v68,
			//                                                                   0LL);
			//                                                   if ( !m_DropRenderParam )
			//                                                     break;
			//                                                   v73 = *NewDropInfo;
			//                                                   sub_18004D910(m_DropRenderParam, (int)v43, &v73);
			//                                                   m_dropUpdateData = this.fields.m_dropUpdateData;
			//                                                   if ( !*rainCommonRenderingParam )
			//                                                     break;
			//                                                   screenDropFlowPercent = (*rainCommonRenderingParam).fields.screenDropFlowPercent;
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                   if ( !m_dropUpdateData )
			//                                                     break;
			//                                                   v49 = sub_18003EB40(m_screenRainDropFXRendererParams, (int)v43);
			//                                                   v73 = *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropUpdateData(
			//                                                            &v74,
			//                                                            this,
			//                                                            screenDropFlowPercent,
			//                                                            *(float *)(v49 + 8) > COERCE_FLOAT(1),
			//                                                            0LL);
			//                                                   sub_18004D910(m_dropUpdateData, (int)v43, &v73);
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropActive;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
			//                                                     goto LABEL_71;
			//                                                   m_screenRainDropFXRendererParams[v43 + 32] = 1;
			//                                                 }
			//                                               }
			//                                               m_screenRainDropFXRendererParams = (char *)this.fields.m_dropActive;
			//                                               if ( !m_screenRainDropFXRendererParams )
			//                                                 break;
			//                                               if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
			// LABEL_71:
			//                                                 sub_180070270(m_screenRainDropFXRendererParams, screenDropFXNoiseTex);
			//                                               if ( m_screenRainDropFXRendererParams[v43 + 32] )
			//                                               {
			//                                                 m_screenRainDropFXRendererParams = (char *)this.fields.m_DropRenderParam;
			//                                                 if ( !m_screenRainDropFXRendererParams )
			//                                                   break;
			//                                                 if ( *(float *)(sub_18003EB40(
			//                                                                   m_screenRainDropFXRendererParams,
			//                                                                   (int)v43)
			//                                                               + 8) > 0.0 )
			//                                                 {
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   if ( *(float *)(sub_18003EB40(
			//                                                                     m_screenRainDropFXRendererParams,
			//                                                                     (int)v43)
			//                                                                 + 4) > COERCE_FLOAT(1) )
			//                                                   {
			//                                                     m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                     if ( !m_screenRainDropFXRendererParams )
			//                                                       break;
			//                                                     if ( *(float *)sub_18003EB40(
			//                                                                      m_screenRainDropFXRendererParams,
			//                                                                      (int)v43) >= COERCE_FLOAT(1) )
			//                                                     {
			//                                                       v50 = this.fields.m_dropUpdateData;
			//                                                       if ( !v50 )
			//                                                         break;
			//                                                       v51 = *(float *)sub_18003EB40(
			//                                                                         this.fields.m_dropUpdateData,
			//                                                                         (int)v43)
			//                                                           - deltaTime;
			//                                                       if ( v51 < 0.0 )
			//                                                         v51 = 0.0;
			//                                                       goto LABEL_54;
			//                                                     }
			//                                                     v52 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//                                                     m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                     if ( !m_screenRainDropFXRendererParams )
			//                                                       break;
			//                                                     if ( v52 > *(float *)(sub_18003EB40(
			//                                                                             m_screenRainDropFXRendererParams,
			//                                                                             (int)v43)
			//                                                                         + 4) )
			//                                                     {
			//                                                       v50 = this.fields.m_dropUpdateData;
			//                                                       if ( !v50 )
			//                                                         break;
			//                                                       v51 = UnityEngine::Random::Range(v24, v25, 0LL);
			// LABEL_54:
			//                                                       *(float *)sub_18003EB40(v50, (int)v43) = v51;
			//                                                     }
			//                                                   }
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                   v53 = 0.0;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   s_jitterTime = this.fields.s_jitterTime;
			//                                                   if ( (float)(s_jitterTime
			//                                                              - *(float *)(sub_18003EB40(
			//                                                                             m_screenRainDropFXRendererParams,
			//                                                                             (int)v43)
			//                                                                         + 8)) > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//                                                   {
			//                                                     m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                     if ( !m_screenRainDropFXRendererParams )
			//                                                       break;
			//                                                     sub_18003EB40(m_screenRainDropFXRendererParams, (int)v43);
			//                                                     if ( !*rainCommonRenderingParam )
			//                                                       break;
			//                                                     m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                     screenDropJitterSpeedScale = (*rainCommonRenderingParam).fields.screenDropJitterSpeedScale;
			//                                                     if ( !m_screenRainDropFXRendererParams )
			//                                                       break;
			//                                                     v56 = *(float *)(sub_18003EB40(
			//                                                                        m_screenRainDropFXRendererParams,
			//                                                                        (int)v43)
			//                                                                    + 8);
			//                                                     v57 = Beyond::DampingMath::cosf();
			//                                                     m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                     v53 = (float)((float)(*(float *)&v57 * v25)
			//                                                                 * screenDropJitterSpeedScale)
			//                                                         * (float)(1.0 - (float)(v56 / this.fields.s_jitterTime));
			//                                                     if ( !m_screenRainDropFXRendererParams )
			//                                                       break;
			//                                                     v58 = sub_18003EB40(m_screenRainDropFXRendererParams, (int)v43);
			//                                                     *(float *)(v58 + 8) = deltaTime + *(float *)(v58 + 8);
			//                                                   }
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_DropRenderParam;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   v59 = (float *)sub_18003EB40(
			//                                                                    m_screenRainDropFXRendererParams,
			//                                                                    (int)v43);
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   v60 = *v59;
			//                                                   *v59 = (float)((float)(deltaTime
			//                                                                        * *(float *)sub_18003EB40(
			//                                                                                      m_screenRainDropFXRendererParams,
			//                                                                                      (int)v43))
			//                                                                * v44)
			//                                                        + v60;
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_DropRenderParam;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   v61 = sub_18003EB40(m_screenRainDropFXRendererParams, (int)v43);
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_dropUpdateData;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   v62 = *(float *)(v61 + 4);
			//                                                   *(float *)(v61 + 4) = (float)((float)(v53
			//                                                                                       + *(float *)sub_18003EB40(
			//                                                                                                     m_screenRainDropFXRendererParams,
			//                                                                                                     (int)v43))
			//                                                                               * deltaTime)
			//                                                                       + v62;
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_DropRenderParam;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   v63 = sub_18003EB40(m_screenRainDropFXRendererParams, (int)v43);
			//                                                   *(float *)(v63 + 8) = *(float *)(v63 + 8) - deltaTime;
			//                                                   m_screenRainDropFXRendererParams = (char *)this.fields.m_DropRenderParam;
			//                                                   m_visibleCount = this.fields.m_visibleCount;
			//                                                   if ( !m_screenRainDropFXRendererParams )
			//                                                     break;
			//                                                   sub_180037190(m_screenRainDropFXRendererParams, &v72, (int)v43);
			//                                                   *(_OWORD *)&this.fields.m_dropRenderDatas.m_Buffer[16 * m_visibleCount] = v72;
			//                                                   ++this.fields.m_visibleCount;
			//                                                   goto LABEL_69;
			//                                                 }
			//                                                 m_screenRainDropFXRendererParams = (char *)this.fields.m_dropActive;
			//                                                 if ( !m_screenRainDropFXRendererParams )
			//                                                   break;
			//                                                 if ( v43 >= *((_DWORD *)m_screenRainDropFXRendererParams + 6) )
			//                                                   goto LABEL_71;
			//                                                 m_screenRainDropFXRendererParams[v43 + 32] = 0;
			//                                               }
			// LABEL_69:
			//                                               if ( (int)++v43 >= 30 )
			//                                                 return;
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
			// LABEL_73:
			//     sub_180B536AC(m_screenRainDropFXRendererParams, screenDropFXNoiseTex);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1339, 0LL);
			//   if ( !Patch )
			//     goto LABEL_73;
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

		internal override void PerFrameClear()
		{
			// // Void PerFrameClear()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::PerFrameClear(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   _QWORD **v3; // rcx
			//   __int64 v4; // rdx
			//   void (__fastcall *v5)(MaterialPropertyBlock *, __int64); // rax
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rdi
			//   MeshRenderer *m_screenDropMr; // rdi
			//   MeshRenderer *v8; // rbx
			//   void (__fastcall *v9)(MeshRenderer *, _QWORD); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rax
			//   __int64 v12; // rax
			// 
			//   if ( !byte_18D8EDC9D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC9D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = *v3[23];
			//   if ( !v4 )
			//     goto LABEL_30;
			//   if ( *(int *)(v4 + 24) > 1343 )
			//   {
			//     if ( !*((_DWORD *)v3 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v4);
			//       v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (_QWORD **)*v3[23];
			//     if ( !v3 )
			//       goto LABEL_30;
			//     if ( *((_DWORD *)v3 + 6) <= 0x53Fu )
			//       sub_180070270(v3, v4);
			//     if ( v3[1347] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1343, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_30;
			//     }
			//   }
			//   if ( this.fields.m_materialPropertyBlock )
			//   {
			//     v5 = (void (__fastcall *)(MaterialPropertyBlock *, __int64))qword_18D8F4558;
			//     m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//     if ( !qword_18D8F4558 )
			//     {
			//       v5 = (void (__fastcall *)(MaterialPropertyBlock *, __int64))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)");
			//       if ( !v5 )
			//       {
			//         v11 = sub_1802DBBE8("UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)");
			//         sub_18000F750(v11, 0LL);
			//       }
			//       qword_18D8F4558 = (__int64)v5;
			//     }
			//     LOBYTE(v4) = 1;
			//     v5(m_materialPropertyBlock, v4);
			//   }
			//   m_screenDropMr = this.fields.m_screenDropMr;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_screenDropMr )
			//   {
			//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( m_screenDropMr.fields._._._.m_CachedPtr )
			//     {
			//       v8 = this.fields.m_screenDropMr;
			//       if ( v8 )
			//       {
			//         v9 = (void (__fastcall *)(MeshRenderer *, _QWORD))qword_18D8F45B0;
			//         if ( !qword_18D8F45B0 )
			//         {
			//           v9 = (void (__fastcall *)(MeshRenderer *, _QWORD))il2cpp_resolve_icall_0(
			//                                                               "UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngin"
			//                                                               "e.MaterialPropertyBlock)");
			//           if ( !v9 )
			//           {
			//             v12 = sub_1802DBBE8("UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)");
			//             sub_18000F750(v12, 0LL);
			//           }
			//           qword_18D8F45B0 = (__int64)v9;
			//         }
			//         v9(v8, 0LL);
			//         return;
			//       }
			// LABEL_30:
			//       sub_180B536AC(v3, v4);
			//     }
			//   }
			// }
			// 
		}

		internal override void SetMaterialData(in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::SetMaterialData(
			//         HGScreenRainDropFXRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rbx
			//   void *v8; // rcx
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *m_screenRainDropFXRendererParams; // rax
			//   int32_t RainParams; // edx
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v12; // rax
			//   int32_t RainColor; // edx
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v14; // r8
			//   HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *v15; // rax
			//   int32_t ScreenDropFXNoiseTex_ST; // edx
			//   RainCommonRenderingParam *v17; // rdi
			//   MaterialPropertyBlock *v18; // r14
			//   int32_t v19; // r12d
			//   int cameraMask; // edi
			//   int32_t m_visibleCount; // ebx
			//   Vector4 *v22; // rax
			//   CBHandle *v23; // rax
			//   __m128i v24; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CBHandle v26; // [rsp+30h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919DB6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919DB6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1344, 0LL) )
			//   {
			//     if ( this.fields.m_visibleCount <= 0 )
			//       return;
			//     m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     m_screenRainDropFXRendererParams = this.fields.m_screenRainDropFXRendererParams;
			//     if ( m_screenRainDropFXRendererParams )
			//     {
			//       if ( m_materialPropertyBlock )
			//       {
			//         RainParams = static_fields._RainParams;
			//         *(Vector4 *)&v26.bufferId = m_screenRainDropFXRendererParams.fields.rainParams;
			//         UnityEngine::MaterialPropertyBlock::SetVector(m_materialPropertyBlock, RainParams, (Vector4 *)&v26, 0LL);
			//         v8 = this.fields.m_materialPropertyBlock;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v12 = this.fields.m_screenRainDropFXRendererParams;
			//         if ( v12 )
			//         {
			//           if ( v8 )
			//           {
			//             RainColor = static_fields._RainColor;
			//             *(Color *)&v26.bufferId = v12.fields.color;
			//             UnityEngine::MaterialPropertyBlock::SetColor((MaterialPropertyBlock *)v8, RainColor, (Color *)&v26, 0LL);
			//             v14 = this.fields.m_screenRainDropFXRendererParams;
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( v14 )
			//             {
			//               HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//                 this.fields.m_materialPropertyBlock,
			//                 static_fields._ScreenDropFXNoiseTex,
			//                 (Texture *)v14.fields.noiseTexture,
			//                 0LL);
			//               v8 = this.fields.m_materialPropertyBlock;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               v15 = this.fields.m_screenRainDropFXRendererParams;
			//               if ( v15 )
			//               {
			//                 if ( v8 )
			//                 {
			//                   ScreenDropFXNoiseTex_ST = static_fields._ScreenDropFXNoiseTex_ST;
			//                   *(Vector4 *)&v26.bufferId = v15.fields.noiseTextureScaleOffset;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(
			//                     (MaterialPropertyBlock *)v8,
			//                     ScreenDropFXNoiseTex_ST,
			//                     (Vector4 *)&v26,
			//                     0LL);
			//                   v17 = *rainCommonRenderingParam;
			//                   v18 = this.fields.m_materialPropertyBlock;
			//                   v8 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   v19 = *((_DWORD *)v8 + 790);
			//                   if ( v17 )
			//                   {
			//                     cameraMask = v17.fields.cameraMask;
			//                     m_visibleCount = this.fields.m_visibleCount;
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                     v22 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                             (Vector4 *)&v26,
			//                             (float)cameraMask,
			//                             (float)m_visibleCount,
			//                             0LL);
			//                     if ( v18 )
			//                     {
			//                       *(Vector4 *)&v26.bufferId = *v22;
			//                       UnityEngine::MaterialPropertyBlock::SetVector(v18, v19, (Vector4 *)&v26, 0LL);
			//                       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                       v23 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                               &v26,
			//                               context,
			//                               480,
			//                               0LL);
			//                       v24 = *(__m128i *)&v23.bufferId;
			//                       v26.ptr = v23.ptr;
			//                       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//                         (Void *)v26.ptr,
			//                         this.fields.m_dropRenderDatas.m_Buffer,
			//                         480LL,
			//                         0LL);
			//                       v8 = this.fields.m_materialPropertyBlock;
			//                       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                       if ( v8 )
			//                       {
			//                         UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
			//                           (MaterialPropertyBlock *)v8,
			//                           static_fields._ScreenDropRenderDatas,
			//                           _mm_cvtsi128_si32(v24),
			//                           _mm_cvtsi128_si32(_mm_srli_si128(v24, 4)),
			//                           480,
			//                           0LL);
			//                         return;
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
			// LABEL_17:
			//     sub_180B536AC(v8, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1344, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			// }
			// 
		}

		internal override void UpdateRendererObjs(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::UpdateRendererObjs(
			//         HGScreenRainDropFXRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Renderer *m_screenDropMr; // rcx
			//   __int64 v8; // rdx
			//   char v9; // bl
			//   Transform *m_screenDropTrans; // rsi
			//   Transform *v11; // rsi
			//   __int64 (__fastcall *v12)(Transform *, __int64, HGCamera *, MethodInfo *); // rax
			//   __int64 v13; // rsi
			//   unsigned __int8 (__fastcall *v14)(__int64); // rax
			//   GameObject *v15; // rax
			//   Object_1 *v16; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   Object *v23; // rax
			//   MeshFilter *v24; // r14
			//   Object_1 *camera; // r14
			//   Transform *transform; // rax
			//   Transform *v27; // r14
			//   Transform *v28; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Transform *v31; // rsi
			//   void (__fastcall *v32)(Transform *, unsigned __int64 *); // rax
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v35; // rax
			//   __int64 v36; // rax
			//   Object_1 *v37; // rbx
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v40; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v41; // [rsp+28h] [rbp-20h]
			//   unsigned __int64 v42; // [rsp+30h] [rbp-18h] BYREF
			//   int v43; // [rsp+38h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDC9E )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9B5B40);
			//     byte_18D8EDC9E = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_screenDropMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, rainCommonRenderingParam);
			//     m_screenDropMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(_QWORD *)m_screenDropMr[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_43;
			//   if ( *(int *)(v8 + 24) > 1345 )
			//   {
			//     if ( !LODWORD(m_screenDropMr[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(m_screenDropMr, v8);
			//       m_screenDropMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_screenDropMr = *(Renderer **)m_screenDropMr[7].fields._._.m_CachedPtr;
			//     if ( !m_screenDropMr )
			//       goto LABEL_43;
			//     if ( LODWORD(m_screenDropMr[1].klass) <= 0x541 )
			//       sub_180070270(m_screenDropMr, v8);
			//     if ( m_screenDropMr[449].fields._._.m_CachedPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1345, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//           Patch,
			//           (Object *)this,
			//           (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//           (Object *)hgCamera,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_43;
			//     }
			//   }
			//   if ( this.fields.m_visibleCount <= 0 )
			//     goto LABEL_10;
			//   if ( !*rainCommonRenderingParam )
			//     goto LABEL_43;
			//   if ( (*rainCommonRenderingParam).fields.enable )
			//     v9 = 1;
			//   else
			// LABEL_10:
			//     v9 = 0;
			//   m_screenDropTrans = this.fields.m_screenDropTrans;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !m_screenDropTrans )
			//     goto LABEL_30;
			//   m_screenDropMr = (Renderer *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !m_screenDropTrans.fields._._.m_CachedPtr )
			//   {
			// LABEL_30:
			//     v15 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//     v16 = (Object_1 *)v15;
			//     if ( !v15 )
			//       goto LABEL_43;
			//     UnityEngine::GameObject::GameObject(v15, (String *)"!SCREENRAINDROPFX", 0LL);
			//     UnityEngine::Object::set_hideFlags(v16, HideFlags__Enum_HideAndDontSave|HideFlags__Enum_HideInInspector, 0LL);
			//     this.fields.m_screenDropTrans = UnityEngine::GameObject::get_transform((GameObject *)v16, 0LL);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_screenDropTrans, v17, v18, v19, methoda, v40);
			//     this.fields.m_screenDropMr = (MeshRenderer *)UnityEngine::GameObject::AddComponent<System::Object>(
			//                                                     (GameObject *)v16,
			//                                                     MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_screenDropMr, v20, v21, v22, methodb, v41);
			//     v23 = UnityEngine::GameObject::AddComponent<System::Object>(
			//             (GameObject *)v16,
			//             MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     m_screenDropMr = (Renderer *)this.fields.m_screenDropMr;
			//     v24 = (MeshFilter *)v23;
			//     if ( !m_screenDropMr )
			//       goto LABEL_43;
			//     UnityEngine::Renderer::SetMaterial(m_screenDropMr, this.fields.m_screenDropMat, 0LL);
			//     if ( !v24 )
			//       goto LABEL_43;
			//     UnityEngine::MeshFilter::set_sharedMesh(v24, this.fields.m_screenDropMesh, 0LL);
			//     if ( hgCamera )
			//     {
			//       camera = (Object_1 *)hgCamera.fields.camera;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//       {
			//         transform = UnityEngine::GameObject::get_transform((GameObject *)v16, 0LL);
			//         m_screenDropMr = (Renderer *)hgCamera.fields.camera;
			//         v27 = transform;
			//         if ( !m_screenDropMr )
			//           goto LABEL_43;
			//         v28 = UnityEngine::Component::get_transform((Component *)m_screenDropMr, 0LL);
			//         if ( !v27 )
			//           goto LABEL_43;
			//         UnityEngine::Transform::SetParent(v27, v28, 1, 0LL);
			//         v31 = UnityEngine::GameObject::get_transform((GameObject *)v16, 0LL);
			//         if ( !v31 )
			//           sub_180B536AC(v30, v29);
			//         v32 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18D8F52F8;
			//         v42 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v43 = 1065353216;
			//         if ( !qword_18D8F52F8 )
			//         {
			//           v32 = (void (__fastcall *)(Transform *, unsigned __int64 *))sub_180017470(
			//                                                                         "UnityEngine.Transform::set_localPosition_Injecte"
			//                                                                         "d(UnityEngine.Vector3&)");
			//           qword_18D8F52F8 = (__int64)v32;
			//         }
			//         v32(v31, &v42);
			//       }
			//     }
			//   }
			//   v11 = this.fields.m_screenDropTrans;
			//   if ( !v11 )
			//     goto LABEL_43;
			//   v12 = (__int64 (__fastcall *)(Transform *, __int64, HGCamera *, MethodInfo *))qword_18D8F4D48;
			//   if ( !qword_18D8F4D48 )
			//   {
			//     v12 = (__int64 (__fastcall *)(Transform *, __int64, HGCamera *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                     "UnityEngine.Component::get_gameObject()");
			//     if ( !v12 )
			//     {
			//       v35 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//       sub_18000F750(v35, 0LL);
			//     }
			//     qword_18D8F4D48 = (__int64)v12;
			//   }
			//   v13 = v12(v11, v8, hgCamera, method);
			//   if ( !v13 )
			// LABEL_43:
			//     sub_180B536AC(m_screenDropMr, v8);
			//   v14 = (unsigned __int8 (__fastcall *)(__int64))qword_18D8F4E00;
			//   if ( !qword_18D8F4E00 )
			//   {
			//     v14 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.GameObject::get_activeSelf()");
			//     if ( !v14 )
			//     {
			//       v36 = sub_1802DBBE8("UnityEngine.GameObject::get_activeSelf()");
			//       sub_18000F750(v36, 0LL);
			//     }
			//     qword_18D8F4E00 = (__int64)v14;
			//   }
			//   if ( v14(v13) != v9 )
			//   {
			//     m_screenDropMr = (Renderer *)this.fields.m_screenDropTrans;
			//     if ( !m_screenDropMr )
			//       goto LABEL_43;
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)m_screenDropMr, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_43;
			//     UnityEngine::GameObject::SetActive(gameObject, v9, 0LL);
			//   }
			//   if ( v9 )
			//   {
			//     v37 = (Object_1 *)this.fields.m_screenDropMr;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( UnityEngine::Object::op_Inequality(v37, 0LL, 0LL) )
			//     {
			//       m_screenDropMr = (Renderer *)this.fields.m_screenDropMr;
			//       if ( m_screenDropMr )
			//       {
			//         UnityEngine::Renderer::Internal_SetPropertyBlock(m_screenDropMr, this.fields.m_materialPropertyBlock, 0LL);
			//         return;
			//       }
			//       goto LABEL_43;
			//     }
			//   }
			// }
			// 
		}

		internal override bool IsDirty()
		{
			// // Boolean IsDirty()
			// bool HG::Rendering::Runtime::HGScreenRainDropFXRenderer::IsDirty(HGScreenRainDropFXRenderer *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1346 )
			//     return this.fields.m_visibleCount > 0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x542u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[37].vector[14] )
			//     return this.fields.m_visibleCount > 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1346, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal override void ClearData()
		{
			// // Void ClearData()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ClearData(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1347, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1347, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(this, 0LL);
			//   }
			// }
			// 
		}

		internal override void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::Dispose(HGScreenRainDropFXRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D8EDC9F )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     byte_18D8EDC9F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1348, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1348, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_dropRenderDatas,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_screenDropTrans,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_screenDropMat,
			//       0LL);
			//   }
			// }
			// 
		}

		private Vector4 _GetNewDropInfo(Vector2 minMaxLifeTime, Vector2 minMaxSize, Vector2 scatterParam)
		{
			// // Vector4 _GetNewDropInfo(Vector2, Vector2, Vector2)
			// Vector4 *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropInfo(
			//         Vector4 *__return_ptr retstr,
			//         HGScreenRainDropFXRenderer *this,
			//         Vector2 minMaxLifeTime,
			//         Vector2 minMaxSize,
			//         Vector2 scatterParam,
			//         MethodInfo *method)
			// {
			//   float GaussianDistributeRandom; // xmm8_4
			//   float v11; // xmm7_4
			//   float v12; // xmm6_4
			//   double v13; // xmm0_8
			//   double v14; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Vector4 v21; // [rsp+50h] [rbp-58h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1340, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1340, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_508(
			//                  &v21,
			//                  Patch,
			//                  (Object *)this,
			//                  minMaxLifeTime,
			//                  minMaxSize,
			//                  scatterParam,
			//                  0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//     GaussianDistributeRandom = HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetGaussianDistributeRandom(
			//                                  this,
			//                                  scatterParam.x,
			//                                  scatterParam.y,
			//                                  0LL);
			//     v11 = UnityEngine::Random::Range(minMaxLifeTime.x, minMaxLifeTime.y, 0LL);
			//     v12 = UnityEngine::Random::Range(minMaxSize.x, minMaxSize.y, 0LL);
			//     v13 = Beyond::DampingMath::cosf();
			//     retstr.x = *(float *)&v13 * GaussianDistributeRandom;
			//     v14 = Beyond::DampingMath::sinf();
			//     retstr.w = v12;
			//     retstr.y = *(float *)&v14 * GaussianDistributeRandom;
			//     retstr.z = v11 + 1.0;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private Vector4 _GetNewDropUpdateData(float flowPercent, [MetadataOffset(Offset = "0x01F90D09")] bool needJitter = false)
		{
			// // Vector4 _GetNewDropUpdateData(Single, Boolean)
			// Vector4 *HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetNewDropUpdateData(
			//         Vector4 *__return_ptr retstr,
			//         HGScreenRainDropFXRenderer *this,
			//         float flowPercent,
			//         bool needJitter,
			//         MethodInfo *method)
			// {
			//   float s_jitterTime; // xmm7_4
			//   float v9; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Vector4 v14; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1342, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1342, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_509(
			//                  &v14,
			//                  Patch,
			//                  (Object *)this,
			//                  flowPercent,
			//                  needJitter,
			//                  0LL);
			//   }
			//   else
			//   {
			//     s_jitterTime = 0.0;
			//     v9 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//     if ( !needJitter )
			//       s_jitterTime = this.fields.s_jitterTime;
			//     retstr.x = 0.0;
			//     retstr.w = 0.0;
			//     retstr.z = s_jitterTime;
			//     retstr.y = (float)(v9 > (float)(1.0 - flowPercent)) * v9;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void _ResetDrops()
		{
			// // Void _ResetDrops()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_ResetDrops(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   __m128i si128; // xmm1
			//   TileBase *v4; // rdx
			//   ITilemap *v5; // r9
			//   __m128i *m_dropActive; // rcx
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v8; // r8
			//   __int64 v9; // r9
			//   __int64 v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1338, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1338, 0LL);
			//     if ( !Patch )
			// LABEL_13:
			//       sub_180B536AC(m_dropActive, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3573C0);
			//     v4 = 0LL;
			//     v5 = 0LL;
			//     do
			//     {
			//       m_dropActive = (__m128i *)this.fields.m_dropActive;
			//       if ( !m_dropActive )
			//         goto LABEL_13;
			//       if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
			//         goto LABEL_14;
			//       m_dropActive[2].m128i_i8[(int)v4] = 0;
			//       TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                  &v12,
			//                                  v4,
			//                                  (Vector3Int *)this.fields.m_dropUpdateData,
			//                                  v5,
			//                                  (MethodInfo *)v12.m_AnimatedSprites);
			//       if ( !v8 )
			//         goto LABEL_13;
			//       if ( (unsigned int)v4 >= *(_DWORD *)(v8 + 24) )
			//         goto LABEL_14;
			//       *(TileAnimationData *)(v8 + 16 * ((int)v4 + 2LL)) = *TileAnimationDataNoRef;
			//       m_dropActive = (__m128i *)this.fields.m_DropRenderParam;
			//       if ( !m_dropActive )
			//         goto LABEL_13;
			//       if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
			//         goto LABEL_14;
			//       m_dropActive[(int)v4 + 2] = si128;
			//       m_dropActive = (__m128i *)this.fields.m_DropRenderParam;
			//       if ( !m_dropActive )
			//         goto LABEL_13;
			//       if ( (unsigned int)v4 >= m_dropActive[1].m128i_i32[2] )
			// LABEL_14:
			//         sub_180070270(m_dropActive, v4);
			//       v10 = (int)v4;
			//       v4 = (TileBase *)(unsigned int)((_DWORD)v4 + 1);
			//       *(__m128i *)&this.fields.m_dropRenderDatas.m_Buffer[v9] = m_dropActive[v10 + 2];
			//       v5 = (ITilemap *)(v9 + 16);
			//     }
			//     while ( (int)v4 < 30 );
			//     this.fields.m_visibleCount = 0;
			//   }
			// }
			// 
		}

		private float _GetGaussianDistributeRandom(float mean, float std)
		{
			// // Single _GetGaussianDistributeRandom(Single, Single)
			// float HG::Rendering::Runtime::HGScreenRainDropFXRenderer::_GetGaussianDistributeRandom(
			//         HGScreenRainDropFXRenderer *this,
			//         float mean,
			//         float std,
			//         MethodInfo *method)
			// {
			//   double v5; // xmm0_8
			//   float3 *v6; // rdx
			//   float3 *v7; // rcx
			//   float3 *v8; // r8
			//   float3 *v9; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1341, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1341, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_436(
			//              (ILFixDynamicMethodWrapper_3 *)Patch,
			//              (Object *)this,
			//              mean,
			//              std,
			//              0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//     UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//     v5 = Beyond::DampingMath::sinf();
			//     sub_1802EAFE0();
			//     return (float)(*(float *)&v5 * sub_1802ECED0(v7, v6, v8, v9)) * std + mean;
			//   }
			// }
			// 
			return 0f;
		}

		public void <>iFixBaseProxy_PerFrameClear()
		{
			// // Void <>iFixBaseProxy_PerFrameClear()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_PerFrameClear(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::PerFrameClear((HGBaseSubRainRenderer *)this, 0LL);
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

		public bool <>iFixBaseProxy_IsDirty()
		{
			// // Boolean <>iFixBaseProxy_IsDirty()
			// bool HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_IsDirty(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::IsDirty((HGBaseSubRainRenderer *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_ClearData()
		{
			// // Void <>iFixBaseProxy_ClearData()
			// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::__iFixBaseProxy_ClearData(
			//         HGScreenRainDropFXRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::ClearData((HGBaseSubRainRenderer *)this, 0LL);
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

		private const int MAXDROPCOUNT = 30;

		private const int DROPRENDERDATA_BUFFER_SIZE = 480;

		private Mesh m_screenDropMesh;

		private Shader m_screenDropShader;

		private Material m_screenDropMat;

		private Transform m_screenDropTrans;

		private MeshRenderer m_screenDropMr;

		private MaterialPropertyBlock m_materialPropertyBlock;

		private HGScreenRainDropFXRenderer.ScreenRainDropFXRendererParams m_screenRainDropFXRendererParams;

		private bool[] m_dropActive;

		private Vector4[] m_dropUpdateData;

		private Vector4[] m_DropRenderParam;

		private NativeArray<Vector4> m_dropRenderDatas;

		private int m_visibleCount;

		private float s_jitterTime;

		private float s_jitterFreq;

		internal class ScreenRainDropFXRendererParams
		{
			public ScreenRainDropFXRendererParams()
			{
				// // HGScreenRainDropFXRenderer+ScreenRainDropFXRendererParams()
				// void HG::Rendering::Runtime::HGScreenRainDropFXRenderer::ScreenRainDropFXRendererParams::ScreenRainDropFXRendererParams(
				//         HGScreenRainDropFXRenderer_ScreenRainDropFXRendererParams *this,
				//         MethodInfo *method)
				// {
				//   Vector3Int *v2; // r8
				//   ITilemap *v3; // r9
				//   TileBase *v5; // rdx
				//   Vector3Int *v6; // r8
				//   ITilemap *v7; // r9
				//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
				//   PassConstructorID__Enum__Array *v9; // r8
				//   HGCamera *v10; // r9
				//   TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   this.fields.color = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                  &v11,
				//                                  (TileBase *)method,
				//                                  v2,
				//                                  v3,
				//                                  (MethodInfo *)v11.m_AnimatedSprites);
				//   this.fields.rainParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v11,
				//                                         v5,
				//                                         v6,
				//                                         v7,
				//                                         (MethodInfo *)v11.m_AnimatedSprites);
				//   this.fields.noiseTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields.noiseTexture,
				//     v8,
				//     v9,
				//     v10,
				//     (MethodInfo *)v11.m_AnimatedSprites,
				//     *(MethodInfo **)&v11.m_AnimationSpeed);
				//   this.fields.noiseTextureScaleOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				//   *(_QWORD *)&this.fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.pos.z = 0.0;
				// }
				// 
			}

			public Color color;

			public Vector4 rainParams;

			public Texture2D noiseTexture;

			public Vector4 noiseTextureScaleOffset;

			public Vector3 pos;
		}
	}
}
