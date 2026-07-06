using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGSkydomeStarRenderer
	{
		public HGSkydomeStarRenderer()
		{
		}

		internal bool CheckRuntimeResources(int index)
		{
			// // Boolean CheckRuntimeResources(Int32)
			// bool HG::Rendering::Runtime::HGSkydomeStarRenderer::CheckRuntimeResources(
			//         HGSkydomeStarRenderer *this,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   Object_1 *m_starMesh; // rbx
			//   __int64 v6; // rdx
			//   HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *starData; // rcx
			//   HGSkydomeStarRenderer_HGSkydomeStarRenderingData *v8; // rbx
			//   Object_1 *drawMaterial; // rbx
			//   Shader *shader; // rax
			//   bool isSupported; // bl
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = index;
			//   if ( !byte_18D919D7C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D5E49A0);
			//     byte_18D919D7C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1248, 0LL) )
			//   {
			//     m_starMesh = (Object_1 *)this.fields.m_starMesh;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(m_starMesh, 0LL, 0LL) )
			//     {
			//       starData = this.fields.starData;
			//       if ( !starData )
			//         goto LABEL_21;
			//       if ( (unsigned int)v4 >= starData.max_length.size )
			//         goto LABEL_16;
			//       v8 = starData.vector[v4];
			//       if ( !v8 )
			//         goto LABEL_21;
			//       drawMaterial = (Object_1 *)v8.fields.drawMaterial;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(drawMaterial, 0LL, 0LL) )
			//       {
			//         starData = this.fields.starData;
			//         if ( !starData )
			//           goto LABEL_21;
			//         if ( (unsigned int)v4 < starData.max_length.size )
			//         {
			//           starData = (HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *)starData.vector[v4];
			//           if ( starData )
			//           {
			//             starData = (HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *)starData.bounds;
			//             if ( starData )
			//             {
			//               shader = UnityEngine::Material::get_shader((Material *)starData, 0LL);
			//               if ( shader )
			//               {
			//                 isSupported = UnityEngine::Shader::get_isSupported(shader, 0LL);
			//                 if ( isSupported )
			//                   return isSupported;
			//                 goto LABEL_18;
			//               }
			//             }
			//           }
			// LABEL_21:
			//           sub_180B536AC(starData, v6);
			//         }
			// LABEL_16:
			//         sub_180070270(starData, v6);
			//       }
			//     }
			//     isSupported = 0;
			// LABEL_18:
			//     HG::Rendering::HGRPLogger::LogError((String *)"Skydome drawer resources is no valid. Pleas check.", 0LL);
			//     return isSupported;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1248, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			//            (ILFixDynamicMethodWrapper_13 *)Patch,
			//            (Object *)this,
			//            (NaviDirection__Enum)v4,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private void _RenderStar(CommandBuffer cmd, HGCamera hgCamera, ref HGCelestialConfig.HGCelestialAtmosphereObjectConfig planet, int internalIndex, bool useFullScreenDebug)
		{
			// // Void _RenderStar(CommandBuffer, HGCamera, HGCelestialConfig+HGCelestialAtmosphereObjectConfig ByRef, Int32, Boolean)
			// void HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
			//         HGSkydomeStarRenderer *this,
			//         CommandBuffer *cmd,
			//         HGCamera *hgCamera,
			//         HGCelestialConfig_HGCelestialAtmosphereObjectConfig *planet,
			//         int32_t internalIndex,
			//         bool useFullScreenDebug,
			//         MethodInfo *method)
			// {
			//   void *starData; // rdx
			//   char *Patch; // rcx
			//   Component *camera; // r15
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   HGEnvironmentPhase *InterpolatedPhase; // r12
			//   HGSkydomeStarRenderer_HGSkydomeStarRenderingData__Array *v17; // r9
			//   HGSkydomeStarRenderer_HGSkydomeStarRenderingData *v18; // rbx
			//   Object_1 *drawMaterial; // rbx
			//   Shader *shader; // rbx
			//   Shader *v21; // rax
			//   Shader *v22; // rax
			//   __m128i v23; // xmm11
			//   MethodInfo *v24; // rdx
			//   Vector3 *fwd; // rax
			//   __int64 v26; // xmm3_8
			//   Vector3 *v27; // rax
			//   float z; // ebx
			//   __int64 v29; // xmm14_8
			//   MethodInfo *v30; // rax
			//   Vector3 *v31; // rax
			//   Quaternion *v32; // rdx
			//   Quaternion v33; // xmm0
			//   __int64 v34; // xmm3_8
			//   Vector3 *v35; // rax
			//   MethodInfo *v36; // r9
			//   float ProceduralSkyMeshRadius; // xmm0_4
			//   float v38; // xmm8_4
			//   float outerRadius; // xmm7_4
			//   Vector3 *v40; // rax
			//   __int64 v41; // xmm9_8
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v44; // xmm6_8
			//   float v45; // ebx
			//   float3 *v46; // rdx
			//   float3 *v47; // rcx
			//   float3 *v48; // r8
			//   float3 *v49; // r9
			//   float v50; // xmm0_4
			//   float v51; // xmm15_4
			//   MethodInfo *v52; // rdx
			//   Vector3 *one; // rax
			//   __int64 v54; // xmm1_8
			//   MethodInfo *v55; // r9
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm3_8
			//   MethodInfo *v58; // r9
			//   Vector3 *v59; // rax
			//   __int64 v60; // xmm3_8
			//   MethodInfo *v61; // r9
			//   Vector3 *v62; // rax
			//   __int64 v63; // xmm3_8
			//   Matrix4x4 *v64; // rax
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm2
			//   __int128 v67; // xmm3
			//   bool v68; // r8
			//   float width; // xmm8_4
			//   float v70; // xmm11_4
			//   float radius; // xmm12_4
			//   float v72; // xmm9_4
			//   __m128i v73; // xmm10
			//   Animator *v74; // rdx
			//   int32_t v75; // r8d
			//   MethodInfo *v76; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v78; // xmm1_8
			//   Animator *v79; // rdx
			//   int32_t v80; // r8d
			//   MethodInfo *v81; // r9
			//   Vector3 *v82; // rax
			//   __int64 v83; // xmm1_8
			//   Animator *v84; // rdx
			//   int32_t v85; // r8d
			//   MethodInfo *v86; // r9
			//   Vector3 *v87; // rax
			//   __m128 selfTiltX_low; // xmm6
			//   __m128 selfRotationY_low; // xmm7
			//   __int64 v90; // xmm1_8
			//   float selfTiltZ; // xmm8_4
			//   Vector4 *v92; // rax
			//   __m128i v93; // xmm6
			//   Vector4 *v94; // rax
			//   __m128i v95; // xmm7
			//   Vector4 *v96; // rax
			//   __m128i v97; // xmm8
			//   Vector4 *v98; // rax
			//   __m128i v99; // xmm9
			//   Vector4 *v100; // rax
			//   __m128i v101; // xmm11
			//   Material *v102; // rbx
			//   int32_t v103; // edx
			//   int32_t v104; // edx
			//   int32_t v105; // edx
			//   int32_t v106; // edx
			//   int32_t v107; // edx
			//   int32_t v108; // edx
			//   Texture *planetRingMap; // r15
			//   Material *v110; // rbx
			//   __m128i v111; // xmm6
			//   Material *v112; // rbx
			//   MethodInfo *v113; // r8
			//   Color *v114; // rax
			//   int32_t v115; // r10d
			//   float numInscatteredSamplePoints; // xmm9_4
			//   float numOpticalDepthSamplePoints; // xmm8_4
			//   float atmosphereHeight; // xmm7_4
			//   float coff_R; // xmm6_4
			//   Vector4 *v120; // rax
			//   float v121; // xmm2_4
			//   __m128i v122; // xmm9
			//   Vector4 *v123; // rax
			//   bool enableAtmosphere; // bl
			//   __m128i v125; // xmm8
			//   float bakeFaceVisibility; // xmm7_4
			//   float drawPlanetBelowHorizon; // xmm6_4
			//   Vector4 *v128; // rax
			//   __m128i v129; // xmm6
			//   Material *v130; // rbx
			//   int32_t v131; // edx
			//   int32_t v132; // edx
			//   int32_t v133; // edx
			//   int32_t SKYDOME_STAR_PASS_INDEX; // r8d
			//   Material *v135; // r9
			//   Mesh *m_starMesh; // rdx
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-D8h]
			//   _QWORD v139[3]; // [rsp+40h] [rbp-C8h] BYREF
			//   Color v140; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v141; // [rsp+68h] [rbp-A0h] BYREF
			//   __m128i v142; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v143; // [rsp+88h] [rbp-80h] BYREF
			//   float v144; // [rsp+98h] [rbp-70h]
			//   float v145; // [rsp+9Ch] [rbp-6Ch]
			//   float v146; // [rsp+A0h] [rbp-68h]
			//   __int64 v147; // [rsp+A8h] [rbp-60h]
			//   __int128 v148; // [rsp+B0h] [rbp-58h] BYREF
			//   LocalKeyword keyword; // [rsp+C0h] [rbp-48h] BYREF
			//   LocalKeyword v150; // [rsp+D8h] [rbp-30h] BYREF
			//   LocalKeyword v151; // [rsp+F0h] [rbp-18h] BYREF
			//   __int128 v152; // [rsp+108h] [rbp+0h]
			//   __int128 v153; // [rsp+118h] [rbp+10h]
			//   __int128 v154; // [rsp+128h] [rbp+20h]
			//   Matrix4x4 v155[3]; // [rsp+138h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D919D7D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D7D = 1;
			//   }
			//   memset(&keyword, 0, sizeof(keyword));
			//   memset(&v150, 0, sizeof(v150));
			//   memset(&v151, 0, sizeof(v151));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1249, 0LL) )
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_113;
			//     camera = (Component *)hgCamera.fields.camera;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//     if ( !InterpolatedPhase )
			//       goto LABEL_113;
			//     starData = this.fields.starData;
			//     if ( !starData )
			//       goto LABEL_113;
			//     if ( (unsigned int)internalIndex < *((_DWORD *)starData + 6) )
			//     {
			//       Patch = (char *)*((_QWORD *)starData + internalIndex + 4);
			//       if ( !Patch )
			//         goto LABEL_113;
			//       *((_QWORD *)Patch + 2) = planet.skydomeDrawer.drawMaterial;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)(Patch + 16),
			//         (HGRenderPathBase_HGRenderPathResources *)starData,
			//         v14,
			//         v15,
			//         P3,
			//         P4);
			//       v17 = this.fields.starData;
			//       if ( !v17 )
			//         goto LABEL_113;
			//       if ( (unsigned int)internalIndex < v17.max_length.size )
			//       {
			//         v18 = v17.vector[internalIndex];
			//         if ( !v18 )
			//           goto LABEL_113;
			//         drawMaterial = (Object_1 *)v18.fields.drawMaterial;
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Equality(drawMaterial, 0LL, 0LL) )
			//           return;
			//         Patch = (char *)this.fields.starData;
			//         if ( !Patch )
			//           goto LABEL_113;
			//         if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//         {
			//           starData = *(void **)&Patch[8 * internalIndex + 32];
			//           if ( !starData )
			//             goto LABEL_113;
			//           Patch = (char *)*((_QWORD *)starData + 2);
			//           if ( !Patch )
			//             goto LABEL_113;
			//           shader = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &keyword,
			//             shader,
			//             TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer.static_fields.RENDER_MODE_TEXTURE_KEYWORD_NAME,
			//             0LL);
			//           Patch = (char *)this.fields.starData;
			//           if ( !Patch )
			//             goto LABEL_113;
			//           if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//           {
			//             starData = *(void **)&Patch[8 * internalIndex + 32];
			//             if ( !starData )
			//               goto LABEL_113;
			//             Patch = (char *)*((_QWORD *)starData + 2);
			//             if ( !Patch )
			//               goto LABEL_113;
			//             v21 = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//               &v150,
			//               v21,
			//               TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer.static_fields.DRAW_RING_KEYWORD_NAME,
			//               0LL);
			//             Patch = (char *)this.fields.starData;
			//             if ( !Patch )
			//               goto LABEL_113;
			//             if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//             {
			//               starData = *(void **)&Patch[8 * internalIndex + 32];
			//               if ( !starData )
			//                 goto LABEL_113;
			//               Patch = (char *)*((_QWORD *)starData + 2);
			//               if ( !Patch )
			//                 goto LABEL_113;
			//               v22 = UnityEngine::Material::get_shader((Material *)Patch, 0LL);
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                 &v151,
			//                 v22,
			//                 TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer.static_fields.DRAW_ATMOSPHERE_KEYWORD_NAME,
			//                 0LL);
			//               v23 = _mm_loadu_si128((const __m128i *)sub_182504D40(&v148));
			//               fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v140, v24);
			//               v142 = v23;
			//               v26 = *(_QWORD *)&fwd.x;
			//               v141.z = fwd.z;
			//               *(_QWORD *)&v141.x = v26;
			//               v27 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v140, (Quaternion *)&v142, &v141, 0LL);
			//               z = v27.z;
			//               v29 = *(_QWORD *)&v27.x;
			//               v145 = z;
			//               v30 = (MethodInfo *)sub_182504D40(&v148);
			//               v31 = UnityEngine::Vector3::get_fwd((Vector3 *)&v140, v30);
			//               v33 = *v32;
			//               v34 = *(_QWORD *)&v31.x;
			//               v141.z = v31.z;
			//               *(_QWORD *)&v141.x = v34;
			//               v142 = (__m128i)v33;
			//               v35 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v140, (Quaternion *)&v142, &v141, 0LL);
			//               *(_QWORD *)&v33.x = *(_QWORD *)&v35.x;
			//               *(float *)&v35 = v35.z;
			//               v147 = *(_QWORD *)&v33.x;
			//               v146 = *(float *)&v35;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
			//               ProceduralSkyMeshRadius = HG::Rendering::Runtime::HGSkyRenderer::GetProceduralSkyMeshRadius(0LL);
			//               v38 = ProceduralSkyMeshRadius;
			//               if ( planet.enableRing )
			//                 outerRadius = planet.ring.outerRadius;
			//               else
			//                 outerRadius = planet.objectProperty.radius;
			//               if ( (float)((float)((float)((float)(InterpolatedPhase.fields.celestialConfig.moonConfig.orbitRadius
			//                                                  / 5000.0)
			//                                          * planet.atmosphere.atmosphereHeight)
			//                                  * (float)((float)(planet.atmosphere.heightScale_R / 15.0) + 1.0))
			//                          + planet.objectProperty.radius) > outerRadius )
			//                 outerRadius = (float)((float)((float)(InterpolatedPhase.fields.celestialConfig.moonConfig.orbitRadius
			//                                                     / 5000.0)
			//                                             * planet.atmosphere.atmosphereHeight)
			//                                     * (float)((float)(planet.atmosphere.heightScale_R / 15.0) + 1.0))
			//                             + planet.objectProperty.radius;
			//               *(_QWORD *)&v141.x = v29;
			//               v141.z = z;
			//               v40 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v140, &v141, ProceduralSkyMeshRadius, v36);
			//               v41 = *(_QWORD *)&v40.x;
			//               v144 = v40.z;
			//               if ( !camera )
			//                 goto LABEL_113;
			//               transform = UnityEngine::Component::get_transform(camera, 0LL);
			//               if ( !transform )
			//                 goto LABEL_113;
			//               position = UnityEngine::Transform::get_position((Vector3 *)&v140, transform, 0LL);
			//               v44 = *(_QWORD *)&position.x;
			//               v45 = position.z;
			//               HG::Rendering::Runtime::HGEnvironmentUtils::SkydomeStarHalfFovCos(
			//                 outerRadius,
			//                 InterpolatedPhase.fields.celestialConfig.moonConfig.orbitRadius
			//               - InterpolatedPhase.fields.celestialConfig.moonConfig.radius,
			//                 0LL);
			//               v50 = sub_1802ECED0(v47, v46, v48, v49);
			//               *(float *)&v142.m128i_i32[2] = v144;
			//               v51 = v50;
			//               v142.m128i_i64[0] = v41;
			//               *(_QWORD *)&v143.x = v44;
			//               v143.z = v45;
			//               one = UnityEngine::Vector3::get_one((Vector3 *)&v140, v52);
			//               v54 = *(_QWORD *)&one.x;
			//               *(float *)&one = one.z;
			//               *(_QWORD *)&v141.x = v54;
			//               LODWORD(v141.z) = (_DWORD)one;
			//               v56 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v140, &v141, v38, v55);
			//               v57 = *(_QWORD *)&v56.x;
			//               *(float *)&v56 = v56.z;
			//               *(_QWORD *)&v141.x = v57;
			//               LODWORD(v141.z) = (_DWORD)v56;
			//               v59 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v140, &v141, v50, v58);
			//               *(__m128i *)&v139[1] = v23;
			//               v60 = *(_QWORD *)&v59.x;
			//               *(float *)&v59 = v59.z;
			//               *(_QWORD *)&v141.x = v60;
			//               LODWORD(v141.z) = (_DWORD)v59;
			//               v62 = UnityEngine::Vector3::op_Addition((Vector3 *)&v140, &v143, (Vector3 *)&v142, v61);
			//               v63 = *(_QWORD *)&v62.x;
			//               *(float *)&v62 = v62.z;
			//               v142.m128i_i64[0] = v63;
			//               v142.m128i_i32[2] = (int)v62;
			//               v64 = UnityEngine::Matrix4x4::TRS(v155, (Vector3 *)&v142, (Quaternion *)&v139[1], &v141, 0LL);
			//               Patch = (char *)this.fields.starData;
			//               v152 = *(_OWORD *)&v64.m00;
			//               v153 = *(_OWORD *)&v64.m01;
			//               v154 = *(_OWORD *)&v64.m02;
			//               v148 = *(_OWORD *)&v64.m03;
			//               if ( !Patch )
			//                 goto LABEL_113;
			//               if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//               {
			//                 Patch = *(char **)&Patch[8 * internalIndex + 32];
			//                 v65 = *(_OWORD *)&v64.m01;
			//                 v66 = *(_OWORD *)&v64.m02;
			//                 v67 = *(_OWORD *)&v64.m03;
			//                 if ( !Patch )
			//                   goto LABEL_113;
			//                 *(_OWORD *)(Patch + 24) = *(_OWORD *)&v64.m00;
			//                 *(_OWORD *)(Patch + 40) = v65;
			//                 *(_OWORD *)(Patch + 56) = v66;
			//                 *(_OWORD *)(Patch + 72) = v67;
			//                 Patch = (char *)this.fields.starData;
			//                 if ( !Patch )
			//                   goto LABEL_113;
			//                 if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                 {
			//                   starData = *(void **)&Patch[8 * internalIndex + 32];
			//                   if ( !starData )
			//                     goto LABEL_113;
			//                   Patch = (char *)*((_QWORD *)starData + 2);
			//                   if ( !Patch )
			//                     goto LABEL_113;
			//                   UnityEngine::Material::SetKeyword(
			//                     (Material *)Patch,
			//                     &keyword,
			//                     planet.skydomeDrawer.drawMode == 0,
			//                     0LL);
			//                   Patch = (char *)this.fields.starData;
			//                   if ( !Patch )
			//                     goto LABEL_113;
			//                   if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                   {
			//                     starData = *(void **)&Patch[8 * internalIndex + 32];
			//                     if ( !starData )
			//                       goto LABEL_113;
			//                     Patch = (char *)*((_QWORD *)starData + 2);
			//                     if ( !Patch )
			//                       goto LABEL_113;
			//                     UnityEngine::Material::SetKeyword((Material *)Patch, &v150, planet.enableRing, 0LL);
			//                     Patch = (char *)this.fields.starData;
			//                     if ( !Patch )
			//                       goto LABEL_113;
			//                     if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                     {
			//                       starData = *(void **)&Patch[8 * internalIndex + 32];
			//                       if ( !starData )
			//                         goto LABEL_113;
			//                       Patch = (char *)*((_QWORD *)starData + 2);
			//                       v68 = planet.enableAtmosphere && planet.skydomeDrawer.drawMode == 1;
			//                       if ( !Patch )
			//                         goto LABEL_113;
			//                       UnityEngine::Material::SetKeyword((Material *)Patch, &v151, v68, 0LL);
			//                       width = planet.ring.width;
			//                       v70 = InterpolatedPhase.fields.celestialConfig.moonConfig.orbitRadius
			//                           - InterpolatedPhase.fields.celestialConfig.moonConfig.radius;
			//                       radius = planet.objectProperty.radius;
			//                       v72 = planet.ring.outerRadius;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                       v73 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                (Vector4 *)&v139[1],
			//                                                                radius / v70,
			//                                                                v70 / v72,
			//                                                                v70 / width,
			//                                                                (float)(width - v72) / width,
			//                                                                0LL));
			//                       Vector = UnityEngine::Animator::GetVector((Vector3 *)&v140, v74, v75, v76);
			//                       v78 = *(_QWORD *)&Vector.x;
			//                       *(float *)&Vector = Vector.z;
			//                       *(_QWORD *)&v143.x = v78;
			//                       LODWORD(v143.z) = (_DWORD)Vector;
			//                       v82 = UnityEngine::Animator::GetVector((Vector3 *)&v140, v79, v80, v81);
			//                       v83 = *(_QWORD *)&v82.x;
			//                       *(float *)&v82 = v82.z;
			//                       v142.m128i_i64[0] = v83;
			//                       v142.m128i_i32[2] = (int)v82;
			//                       v87 = UnityEngine::Animator::GetVector((Vector3 *)&v140, v84, v85, v86);
			//                       selfTiltX_low = (__m128)LODWORD(planet.objectProperty.selfTiltX);
			//                       selfRotationY_low = (__m128)LODWORD(planet.objectProperty.selfRotationY);
			//                       v90 = *(_QWORD *)&v87.x;
			//                       *(float *)&v87 = v87.z;
			//                       selfTiltZ = planet.objectProperty.selfTiltZ;
			//                       *(_QWORD *)&v141.x = v90;
			//                       LODWORD(v141.z) = (_DWORD)v87;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//                       *(_QWORD *)&v140.r = _mm_unpacklo_ps(selfTiltX_low, selfRotationY_low).m128_u64[0];
			//                       v140.b = selfTiltZ;
			//                       HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
			//                         (Vector3 *)&v140,
			//                         &v143,
			//                         (Vector3 *)&v142,
			//                         &v141,
			//                         0LL);
			//                       v140.b = v145;
			//                       *(_QWORD *)&v140.r = v29;
			//                       v92 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                               (Vector4 *)&v139[1],
			//                               (Vector3 *)&v140,
			//                               0.0,
			//                               0LL);
			//                       *(_QWORD *)&v140.r = v147;
			//                       v93 = _mm_loadu_si128((const __m128i *)v92);
			//                       v140.b = v146;
			//                       v94 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                               (Vector4 *)&v139[1],
			//                               (Vector3 *)&v140,
			//                               0.0,
			//                               0LL);
			//                       *(_QWORD *)&v140.r = *(_QWORD *)&v143.x;
			//                       v95 = _mm_loadu_si128((const __m128i *)v94);
			//                       v140.b = v143.z;
			//                       v96 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                               (Vector4 *)&v139[1],
			//                               (Vector3 *)&v140,
			//                               0.0,
			//                               0LL);
			//                       *(_QWORD *)&v140.r = v142.m128i_i64[0];
			//                       v97 = _mm_loadu_si128((const __m128i *)v96);
			//                       LODWORD(v140.b) = v142.m128i_i32[2];
			//                       v98 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                               (Vector4 *)&v139[1],
			//                               (Vector3 *)&v140,
			//                               0.0,
			//                               0LL);
			//                       *(_QWORD *)&v140.r = *(_QWORD *)&v141.x;
			//                       v99 = _mm_loadu_si128((const __m128i *)v98);
			//                       v140.b = v141.z;
			//                       v100 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                (Vector4 *)&v139[1],
			//                                (Vector3 *)&v140,
			//                                0.0,
			//                                0LL);
			//                       Patch = (char *)this.fields.starData;
			//                       v101 = _mm_loadu_si128((const __m128i *)v100);
			//                       if ( !Patch )
			//                         goto LABEL_113;
			//                       if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                       {
			//                         Patch = *(char **)&Patch[8 * internalIndex + 32];
			//                         if ( !Patch )
			//                           goto LABEL_113;
			//                         v102 = (Material *)*((_QWORD *)Patch + 2);
			//                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                         starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                         if ( !v102 )
			//                           goto LABEL_113;
			//                         v103 = *((_DWORD *)starData + 318);
			//                         *(__m128i *)&v139[1] = v93;
			//                         UnityEngine::Material::SetVector(v102, v103, (Vector4 *)&v139[1], 0LL);
			//                         Patch = (char *)this.fields.starData;
			//                         if ( !Patch )
			//                           goto LABEL_113;
			//                         if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                         {
			//                           starData = *(void **)&Patch[8 * internalIndex + 32];
			//                           if ( !starData )
			//                             goto LABEL_113;
			//                           Patch = (char *)*((_QWORD *)starData + 2);
			//                           starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                           if ( !Patch )
			//                             goto LABEL_113;
			//                           v104 = *((_DWORD *)starData + 319);
			//                           *(__m128i *)&v139[1] = v95;
			//                           UnityEngine::Material::SetVector((Material *)Patch, v104, (Vector4 *)&v139[1], 0LL);
			//                           Patch = (char *)this.fields.starData;
			//                           if ( !Patch )
			//                             goto LABEL_113;
			//                           if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                           {
			//                             starData = *(void **)&Patch[8 * internalIndex + 32];
			//                             if ( !starData )
			//                               goto LABEL_113;
			//                             Patch = (char *)*((_QWORD *)starData + 2);
			//                             starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                             if ( !Patch )
			//                               goto LABEL_113;
			//                             v105 = *((_DWORD *)starData + 320);
			//                             *(__m128i *)&v139[1] = v73;
			//                             UnityEngine::Material::SetVector((Material *)Patch, v105, (Vector4 *)&v139[1], 0LL);
			//                             Patch = (char *)this.fields.starData;
			//                             if ( !Patch )
			//                               goto LABEL_113;
			//                             if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                             {
			//                               starData = *(void **)&Patch[8 * internalIndex + 32];
			//                               if ( !starData )
			//                                 goto LABEL_113;
			//                               Patch = (char *)*((_QWORD *)starData + 2);
			//                               starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                               if ( !Patch )
			//                                 goto LABEL_113;
			//                               v106 = *((_DWORD *)starData + 327);
			//                               *(__m128i *)&v139[1] = v97;
			//                               UnityEngine::Material::SetVector((Material *)Patch, v106, (Vector4 *)&v139[1], 0LL);
			//                               Patch = (char *)this.fields.starData;
			//                               if ( !Patch )
			//                                 goto LABEL_113;
			//                               if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                               {
			//                                 starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                 if ( !starData )
			//                                   goto LABEL_113;
			//                                 Patch = (char *)*((_QWORD *)starData + 2);
			//                                 starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                 if ( !Patch )
			//                                   goto LABEL_113;
			//                                 v107 = *((_DWORD *)starData + 328);
			//                                 *(__m128i *)&v139[1] = v99;
			//                                 UnityEngine::Material::SetVector((Material *)Patch, v107, (Vector4 *)&v139[1], 0LL);
			//                                 Patch = (char *)this.fields.starData;
			//                                 if ( !Patch )
			//                                   goto LABEL_113;
			//                                 if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                 {
			//                                   starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                   if ( !starData )
			//                                     goto LABEL_113;
			//                                   Patch = (char *)*((_QWORD *)starData + 2);
			//                                   starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                   if ( !Patch )
			//                                     goto LABEL_113;
			//                                   v108 = *((_DWORD *)starData + 329);
			//                                   *(__m128i *)&v139[1] = v101;
			//                                   UnityEngine::Material::SetVector((Material *)Patch, v108, (Vector4 *)&v139[1], 0LL);
			//                                   planetRingMap = planet.ring.planetRingMap;
			//                                   sub_180002C70(TypeInfo::UnityEngine::Object);
			//                                   if ( UnityEngine::Object::op_Inequality((Object_1 *)planetRingMap, 0LL, 0LL) )
			//                                   {
			//                                     Patch = (char *)this.fields.starData;
			//                                     if ( !Patch )
			//                                       goto LABEL_113;
			//                                     if ( (unsigned int)internalIndex >= *((_DWORD *)Patch + 6) )
			//                                       goto LABEL_111;
			//                                     starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                     if ( !starData )
			//                                       goto LABEL_113;
			//                                     v110 = (Material *)*((_QWORD *)starData + 2);
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                     starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                     if ( !v110 )
			//                                       goto LABEL_113;
			//                                     UnityEngine::Material::SetTextureImpl(
			//                                       v110,
			//                                       *((_DWORD *)starData + 321),
			//                                       planetRingMap,
			//                                       0LL);
			//                                   }
			//                                   Patch = (char *)this.fields.starData;
			//                                   v111 = _mm_loadu_si128((const __m128i *)&planet.ring.ringColor);
			//                                   if ( !Patch )
			//                                     goto LABEL_113;
			//                                   if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                   {
			//                                     starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                     if ( !starData )
			//                                       goto LABEL_113;
			//                                     v112 = (Material *)*((_QWORD *)starData + 2);
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                     *(__m128i *)&v139[1] = v111;
			//                                     v114 = UnityEngine::Color::op_Implicit(&v140, (Vector4 *)&v139[1], v113);
			//                                     if ( !v112 )
			//                                       goto LABEL_113;
			//                                     *(Color *)&v139[1] = *v114;
			//                                     UnityEngine::Material::SetVector(v112, v115, (Vector4 *)&v139[1], 0LL);
			//                                     numInscatteredSamplePoints = (float)planet.atmosphere.numInscatteredSamplePoints;
			//                                     if ( numInscatteredSamplePoints < 0.0 )
			//                                     {
			//                                       numInscatteredSamplePoints = 0.0;
			//                                     }
			//                                     else if ( numInscatteredSamplePoints > 10.0 )
			//                                     {
			//                                       numInscatteredSamplePoints = 10.0;
			//                                     }
			//                                     numOpticalDepthSamplePoints = (float)planet.atmosphere.numOpticalDepthSamplePoints;
			//                                     if ( numOpticalDepthSamplePoints < 0.0 )
			//                                     {
			//                                       numOpticalDepthSamplePoints = 0.0;
			//                                     }
			//                                     else if ( numOpticalDepthSamplePoints > 5.0 )
			//                                     {
			//                                       numOpticalDepthSamplePoints = 5.0;
			//                                     }
			//                                     atmosphereHeight = planet.atmosphere.atmosphereHeight;
			//                                     coff_R = planet.atmosphere.coff_R;
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                                     v120 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                              (Vector4 *)&v139[1],
			//                                              atmosphereHeight,
			//                                              numInscatteredSamplePoints,
			//                                              coff_R,
			//                                              *(float *)v73.m128i_i32 * 2000.0,
			//                                              0LL);
			//                                     v121 = 30.0 - planet.atmosphere.heightScale_R;
			//                                     v122 = _mm_loadu_si128((const __m128i *)v120);
			//                                     if ( v121 <= 0.000099999997 )
			//                                       v121 = 0.000099999997;
			//                                     v123 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                              (Vector4 *)&v139[1],
			//                                              numOpticalDepthSamplePoints,
			//                                              v121,
			//                                              planet.atmosphere.atmosphereBrightness,
			//                                              planet.atmosphere.atmosphereHueshift,
			//                                              0LL);
			//                                     enableAtmosphere = planet.enableAtmosphere;
			//                                     v125 = _mm_loadu_si128((const __m128i *)v123);
			//                                     bakeFaceVisibility = planet.atmosphere.bakeFaceVisibility;
			//                                     drawPlanetBelowHorizon = planet.drawPlanetBelowHorizon;
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                                     v128 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                              (Vector4 *)&v139[1],
			//                                              (float)enableAtmosphere,
			//                                              bakeFaceVisibility,
			//                                              v51,
			//                                              drawPlanetBelowHorizon,
			//                                              0LL);
			//                                     Patch = (char *)this.fields.starData;
			//                                     v129 = _mm_loadu_si128((const __m128i *)v128);
			//                                     if ( !Patch )
			//                                       goto LABEL_113;
			//                                     if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                     {
			//                                       starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                       if ( !starData )
			//                                         goto LABEL_113;
			//                                       v130 = (Material *)*((_QWORD *)starData + 2);
			//                                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                       starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                       if ( !v130 )
			//                                         goto LABEL_113;
			//                                       v131 = *((_DWORD *)starData + 323);
			//                                       *(__m128i *)&v139[1] = v122;
			//                                       UnityEngine::Material::SetVector(v130, v131, (Vector4 *)&v139[1], 0LL);
			//                                       Patch = (char *)this.fields.starData;
			//                                       if ( !Patch )
			//                                         goto LABEL_113;
			//                                       if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                       {
			//                                         starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                         if ( !starData )
			//                                           goto LABEL_113;
			//                                         Patch = (char *)*((_QWORD *)starData + 2);
			//                                         starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                         if ( !Patch )
			//                                           goto LABEL_113;
			//                                         v132 = *((_DWORD *)starData + 324);
			//                                         *(__m128i *)&v139[1] = v125;
			//                                         UnityEngine::Material::SetVector(
			//                                           (Material *)Patch,
			//                                           v132,
			//                                           (Vector4 *)&v139[1],
			//                                           0LL);
			//                                         Patch = (char *)this.fields.starData;
			//                                         if ( !Patch )
			//                                           goto LABEL_113;
			//                                         if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                         {
			//                                           starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                           if ( !starData )
			//                                             goto LABEL_113;
			//                                           Patch = (char *)*((_QWORD *)starData + 2);
			//                                           starData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                           if ( !Patch )
			//                                             goto LABEL_113;
			//                                           v133 = *((_DWORD *)starData + 325);
			//                                           *(__m128i *)&v139[1] = v129;
			//                                           UnityEngine::Material::SetVector(
			//                                             (Material *)Patch,
			//                                             v133,
			//                                             (Vector4 *)&v139[1],
			//                                             0LL);
			//                                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
			//                                           SKYDOME_STAR_PASS_INDEX = TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer.static_fields.SKYDOME_STAR_PASS_INDEX;
			//                                           Patch = (char *)this.fields.starData;
			//                                           if ( !Patch )
			//                                             goto LABEL_113;
			//                                           if ( (unsigned int)internalIndex < *((_DWORD *)Patch + 6) )
			//                                           {
			//                                             starData = *(void **)&Patch[8 * internalIndex + 32];
			//                                             if ( starData && cmd )
			//                                             {
			//                                               v135 = (Material *)*((_QWORD *)starData + 2);
			//                                               m_starMesh = this.fields.m_starMesh;
			//                                               *(_OWORD *)&v155[0].m00 = v152;
			//                                               *(_OWORD *)&v155[0].m01 = v153;
			//                                               *(_OWORD *)&v155[0].m02 = v154;
			//                                               *(_OWORD *)&v155[0].m03 = v148;
			//                                               UnityEngine::Rendering::CommandBuffer::DrawMesh(
			//                                                 cmd,
			//                                                 m_starMesh,
			//                                                 v155,
			//                                                 v135,
			//                                                 0,
			//                                                 SKYDOME_STAR_PASS_INDEX,
			//                                                 0LL);
			//                                               return;
			//                                             }
			// LABEL_113:
			//                                             sub_180B536AC(Patch, starData);
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
			// LABEL_111:
			//     sub_180070270(Patch, starData);
			//   }
			//   Patch = (char *)IFix::WrappersManagerImpl::GetPatch(1249, 0LL);
			//   if ( !Patch )
			//     goto LABEL_113;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_472(
			//     (ILFixDynamicMethodWrapper_2 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     (Object *)hgCamera,
			//     planet,
			//     internalIndex,
			//     useFullScreenDebug,
			//     0LL);
			// }
			// 
		}

		public void RenderStar(CommandBuffer cmd, HGCamera hgCamera, bool useFullScreenDebug)
		{
			// // Void RenderStar(CommandBuffer, HGCamera, Boolean)
			// void HG::Rendering::Runtime::HGSkydomeStarRenderer::RenderStar(
			//         HGSkydomeStarRenderer *this,
			//         CommandBuffer *cmd,
			//         HGCamera *hgCamera,
			//         bool useFullScreenDebug,
			//         MethodInfo *method)
			// {
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   HGCelestialConfig_HGCelestialAtmosphereObjectConfig *p_talosAlphaConfig; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D7E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919D7E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1251, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1251, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(
			//         (ILFixDynamicMethodWrapper_13 *)Patch,
			//         (Object *)this,
			//         (Object *)cmd,
			//         (Object *)hgCamera,
			//         useFullScreenDebug,
			//         0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v11, v10);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//   if ( !InterpolatedPhase )
			//     goto LABEL_10;
			//   p_talosAlphaConfig = &InterpolatedPhase.fields.celestialConfig.talosAlphaConfig;
			//   if ( InterpolatedPhase.fields.celestialConfig.planetConfig.drawPlanetInSkydome )
			//     HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
			//       this,
			//       cmd,
			//       hgCamera,
			//       &InterpolatedPhase.fields.celestialConfig.planetConfig,
			//       0,
			//       useFullScreenDebug,
			//       0LL);
			//   if ( p_talosAlphaConfig.drawPlanetInSkydome )
			//     HG::Rendering::Runtime::HGSkydomeStarRenderer::_RenderStar(
			//       this,
			//       cmd,
			//       hgCamera,
			//       p_talosAlphaConfig,
			//       1,
			//       useFullScreenDebug,
			//       0LL);
			// }
			// 
		}

		private HGSkydomeStarRenderer.HGSkydomeStarRenderingData[] starData;

		private Mesh m_starMesh;

		public const int TALOS_RT_RESOLUTION = 2048;

		public const int PLANET_ALPHA_RT_RESOLUTION = 1024;

		private const float PLANET_RADIUS_TO_ATMOSPHERE_SCALE = 2000f;

		private const float ATMOSPHERE_HEIGHT_INVERT_NUMBER = 30f;

		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_PC = 10f;

		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_PC = 5f;

		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_MOBILE = 5f;

		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_MOBILE = 2f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly string RENDER_MODE_TEXTURE_KEYWORD_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly string DRAW_RING_KEYWORD_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly string DRAW_ATMOSPHERE_KEYWORD_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly string DRAW_ATMOSPHERE_BAKE_KEYWORD_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly int SKYDOME_STAR_PASS_INDEX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		private static readonly int FULL_SCREEN_DEBUG_PASS_INDEX;

		public class HGSkydomeStarRenderingData
		{
			public HGSkydomeStarRenderingData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public Material drawMaterial;

			public Matrix4x4 drawMatrix;
		}
	}
}
