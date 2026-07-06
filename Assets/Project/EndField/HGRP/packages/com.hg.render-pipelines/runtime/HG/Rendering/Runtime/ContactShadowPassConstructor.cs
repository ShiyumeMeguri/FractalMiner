using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class ContactShadowPassConstructor : IPassConstructor
	{
		internal ContactShadowPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void PrepareDataForContactShadow(ref ContactShadowPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void PrepareDataForContactShadow(ContactShadowPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareDataForContactShadow(
			//         ContactShadowPassConstructor *this,
			//         ContactShadowPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   int v9; // ebx
			//   _BOOL8 contactShadowEnableParam; // rdi
			//   int32_t v11; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			// 
			//   v9 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2516, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2516, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_923(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_contactShadowEnable = 0;
			//     contactShadowEnableParam = input.contactShadowEnableParam;
			//     this.fields.m_contactShadowEnable = contactShadowEnableParam;
			//     if ( UnityEngine::SystemInfo::SupportsComputeShaders(0LL)
			//       && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore
			//       && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES3 )
			//     {
			//       v9 = 2;
			//     }
			//     v11 = v9 | contactShadowEnableParam;
			//     this.fields.m_contactShadowEnable = v11;
			//     if ( v11 == 3 )
			//       HG::Rendering::Runtime::ContactShadowPassConstructor::_InitContactShadowParams(this, camera, 0LL);
			//   }
			// }
			// 
		}

		private void _InitContactShadowParams(HGCamera camera)
		{
			// // Void _InitContactShadowParams(HGCamera)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::_InitContactShadowParams(
			//         ContactShadowPassConstructor *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __m128 v8; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919507 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919507 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2517, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
			//     if ( InterpolatedPhase )
			//     {
			//       v8 = *(__m128 *)&InterpolatedPhase.fields.shadowConfig.contactShadowSurfaceThickness;
			//       this.fields.m_contactShadowIntensity = InterpolatedPhase.fields.shadowConfig.contactShadowIntensity;
			//       this.fields.m_contactShadowSurfaceThickness = v8.m128_f32[0] * 0.0099999998;
			//       this.fields.m_contactShadowBilinearThreshold = _mm_shuffle_ps(v8, v8, 85).m128_f32[0] * 0.0099999998;
			//       this.fields.m_contactShadowIgnoreEdgePixels = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v8, 12));
			//       this.fields.m_contactShadowContrast = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v8, 8));
			//       if ( camera )
			//       {
			//         this.fields.m_contactShadowFrameIndex = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(camera, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2517, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		internal void PrepareContactShadowPassDataV2(ref ContactShadowPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, ContactShadowPassConstructor.ContactShadowPassDataV2 passData)
		{
			// // Void PrepareContactShadowPassDataV2(ContactShadowPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, ContactShadowPassConstructor+ContactShadowPassDataV2)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareContactShadowPassDataV2(
			//         ContactShadowPassConstructor *this,
			//         ContactShadowPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         ContactShadowPassConstructor_ContactShadowPassDataV2 *passData,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int v12; // eax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int v15; // r14d
			//   int v16; // eax
			//   int v17; // r12d
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __m128 v20; // xmm2
			//   float v21; // xmm3_4
			//   float v22; // xmm4_4
			//   int v23; // xmm0_4
			//   float v24; // xmm0_4
			//   float v25; // xmm1_4
			//   float v26; // xmm2_4
			//   float v27; // xmm0_4
			//   float v28; // xmm1_4
			//   float *v29; // rax
			//   int v30; // ebx
			//   float v31; // xmm0_4
			//   ContactShadowPassConstructor_ContactShadowPassDataV2 *v32; // r12
			//   int i; // r13d
			//   int v34; // eax
			//   int v35; // ecx
			//   int v36; // r14d
			//   int v37; // ebx
			//   int v38; // edi
			//   int v39; // eax
			//   int v40; // ebx
			//   int v41; // eax
			//   int v42; // ebx
			//   int v43; // eax
			//   int v44; // edi
			//   int v45; // ebx
			//   int v46; // eax
			//   int v47; // eax
			//   unsigned __int64 v48; // rdx
			//   int v49; // ecx
			//   int v50; // edi
			//   int v51; // ebx
			//   int32_t dispatchCount; // eax
			//   _DWORD *v53; // rax
			//   int v54; // ecx
			//   _DWORD *v55; // r14
			//   int v56; // edx
			//   int v57; // ebx
			//   int v58; // eax
			//   int v59; // eax
			//   unsigned int v60; // edx
			//   int v61; // eax
			//   __int64 v62; // rt2
			//   int32_t v63; // edi
			//   __int64 v64; // rax
			//   __int64 v65; // rax
			//   MethodInfo *v66; // r8
			//   int v67; // ecx
			//   Vector3Int *v68; // r12
			//   int32_t v69; // ebx
			//   int v70; // ecx
			//   int32_t v71; // ebx
			//   int v72; // ecx
			//   int32_t v73; // ebx
			//   int32_t Item; // ebx
			//   MethodInfo *v75; // r8
			//   int32_t v76; // ebx
			//   MethodInfo *v77; // r8
			//   MethodInfo *v78; // r8
			//   int32_t v79; // ebx
			//   MethodInfo *v80; // r8
			//   MethodInfo *v81; // r8
			//   MethodInfo *v82; // r8
			//   MethodInfo *v83; // r8
			//   void *static_fields; // rcx
			//   ContactShadowPassConstructor_DispatchData__Array *m_contactShadowDispatchData; // r8
			//   char *v86; // rax
			//   __int64 v87; // rcx
			//   int32_t j; // ebx
			//   __int64 v89; // rax
			//   __int64 v90; // rax
			//   float m_contactShadowIntensity; // xmm6_4
			//   __int64 v92; // rax
			//   float m_contactShadowBilinearThreshold; // xmm1_4
			//   __m128i v94; // xmm0
			//   Vector4__Array *m_contactShadowParams; // rdi
			//   bool m_contactShadowIgnoreEdgePixels; // bl
			//   signed int v97; // eax
			//   HGRenderPipelineRuntimeResources *m_resources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   ComputeShader *contactShadowCS; // r14
			//   OneofDescriptorProto *v101; // rdx
			//   FileDescriptor *v102; // r8
			//   MessageDescriptor *v103; // r9
			//   String *s_DisableTerrainContactShadow; // rdi
			//   bool ShouldDisableContactShadow; // bl
			//   OneofDescriptorProto *v106; // rdx
			//   FileDescriptor *v107; // r8
			//   MessageDescriptor *v108; // r9
			//   MessageDescriptor *v109; // r9
			//   OneofDescriptorProto *v110; // rdx
			//   FileDescriptor *v111; // r8
			//   String__Array *v112; // [rsp+10h] [rbp-30h]
			//   String__Array *v113; // [rsp+10h] [rbp-30h]
			//   String__Array *v114; // [rsp+10h] [rbp-30h]
			//   String *v115; // [rsp+18h] [rbp-28h]
			//   String *v116; // [rsp+18h] [rbp-28h]
			//   String *v117; // [rsp+18h] [rbp-28h]
			//   MethodInfo *P3; // [rsp+20h] [rbp-20h]
			//   MethodInfo *P3a; // [rsp+20h] [rbp-20h]
			//   MethodInfo *P3b; // [rsp+20h] [rbp-20h]
			//   int v121; // [rsp+30h] [rbp-10h]
			//   int v122; // [rsp+34h] [rbp-Ch]
			//   int v123; // [rsp+38h] [rbp-8h]
			//   int v124; // [rsp+3Ch] [rbp-4h]
			//   Vector4 lightDir; // [rsp+40h] [rbp+0h] BYREF
			//   int v126; // [rsp+50h] [rbp+10h]
			//   int v127; // [rsp+54h] [rbp+14h]
			//   int v128; // [rsp+58h] [rbp+18h]
			//   BOOL v129; // [rsp+5Ch] [rbp+1Ch]
			//   int32_t v130; // [rsp+60h] [rbp+20h]
			//   int v131; // [rsp+64h] [rbp+24h]
			//   int v132; // [rsp+68h] [rbp+28h]
			//   TextureDesc v133; // [rsp+70h] [rbp+30h] BYREF
			//   Vector4 v134; // [rsp+D0h] [rbp+90h] BYREF
			//   TextureDesc v135; // [rsp+E0h] [rbp+A0h] BYREF
			//   Matrix4x4 v136; // [rsp+140h] [rbp+100h] BYREF
			// 
			//   if ( !byte_18D919508 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Convert);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&off_18D4F5D40);
			//     byte_18D919508 = 1;
			//   }
			//   sub_1802F01E0(&v135, 0LL, 96LL);
			//   sub_1802F01E0(&v133, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2518, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2518, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_924(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         (Object *)renderGraph,
			//         (Object *)camera,
			//         (Object *)passData,
			//         0LL);
			//       return;
			//     }
			// LABEL_111:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   if ( !camera )
			//     goto LABEL_111;
			//   v12 = sub_1825C6750(Patch, v10);
			//   v15 = 1;
			//   if ( v12 > 1 )
			//     v15 = v12;
			//   v131 = v15;
			//   v16 = sub_1825C6750(v14, v13);
			//   v17 = 1;
			//   if ( v16 > 1 )
			//     v17 = v16;
			//   v132 = v17;
			//   v18 = *(_OWORD *)&camera.fields.mainViewConstants.viewProjMatrix.m00;
			//   lightDir = input.lightDir;
			//   lightDir.w = 0.0;
			//   *(_OWORD *)&v136.m00 = v18;
			//   v19 = *(_OWORD *)&camera.fields.mainViewConstants.viewProjMatrix.m01;
			//   *(_OWORD *)&v136.m02 = *(_OWORD *)&camera.fields.mainViewConstants.viewProjMatrix.m02;
			//   *(_OWORD *)&v136.m01 = v19;
			//   *(_OWORD *)&v136.m03 = *(_OWORD *)&camera.fields.mainViewConstants.viewProjMatrix.m03;
			//   v20 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(&v134, &v136, &lightDir, 0LL));
			//   v21 = _mm_shuffle_ps(v20, v20, 255).m128_f32[0];
			//   v22 = v21;
			//   if ( v21 >= 0.0 && (*(float *)&v23 = 0.000128, v21 < 0.000128)
			//     || v21 < 0.0 && (*(float *)&v23 = -0.000128, v21 > -0.000128) )
			//   {
			//     v22 = *(float *)&v23;
			//   }
			//   v24 = _mm_shuffle_ps(v20, v20, 85).m128_f32[0] / v22;
			//   v25 = v20.m128_f32[0] / v22;
			//   v26 = v21 == 0.0 ? 0.0 : _mm_shuffle_ps(v20, v20, 170).m128_f32[0] / v21;
			//   v27 = (float)(v24 * -0.5) + 0.5;
			//   v28 = (float)(v25 * 0.5) + 0.5;
			//   v10 = v21 <= 0.0 ? 0xFFFFFFFFLL : 1LL;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_contactShadowParams;
			//   lightDir.z = v26;
			//   lightDir.y = v27 * (float)v17;
			//   lightDir.x = v28 * (float)v15;
			//   lightDir.w = (float)(int)v10;
			//   if ( !Patch )
			//     goto LABEL_111;
			//   sub_18004D910(Patch, 2LL, &lightDir);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_contactShadowParams;
			//   if ( !Patch )
			//     goto LABEL_111;
			//   v29 = (float *)sub_18003EB40(Patch, 2LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_contactShadowParams;
			//   if ( !Patch )
			//     goto LABEL_111;
			//   v30 = (int)(float)(*v29 + 0.5);
			//   v31 = *(float *)(sub_18003EB40(Patch, 2LL) + 4) + 0.5;
			//   v121 = -v30;
			//   v122 = v17 - (int)v31;
			//   v123 = v15 - v30;
			//   v32 = passData;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)(unsigned int)-(int)v31;
			//   v124 = -(int)v31;
			//   if ( !passData )
			//     goto LABEL_111;
			//   passData.fields.dispatchCount = 0;
			//   for ( i = 0; i < 4; ++i )
			//   {
			//     if ( !i )
			//     {
			//       v34 = 1;
			//       v35 = 0;
			// LABEL_27:
			//       v36 = v34;
			//       v37 = -v123;
			//       v38 = v35;
			//       goto LABEL_28;
			//     }
			//     if ( i == 3 )
			//     {
			//       v38 = 0;
			//       v36 = 1;
			//     }
			//     else
			//     {
			//       v34 = 0;
			//       v36 = 0;
			//       v38 = 1;
			//       v35 = 1;
			//       if ( (i & 1) == 0 )
			//         goto LABEL_27;
			//     }
			//     v37 = v121;
			// LABEL_28:
			//     sub_180002C70(TypeInfo::System::Math);
			//     v39 = 0;
			//     if ( v37 > 0 )
			//       v39 = v37;
			//     v126 = v39 / 64;
			//     if ( (i & 2) != 0 )
			//       v40 = -v122;
			//     else
			//       v40 = v124;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v41 = 0;
			//     if ( v40 > 0 )
			//       v41 = v40;
			//     v127 = v41 / 64;
			//     if ( (i & 1) != 0 )
			//       v42 = v123;
			//     else
			//       v42 = -v121;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v43 = 0;
			//     if ( v42 + (v38 << 6) + 63 > 0 )
			//       v43 = v42 + (v38 << 6) + 63;
			//     v128 = v43 / 64;
			//     v44 = v43 / 64;
			//     if ( (i & 2) != 0 )
			//       v45 = -v124;
			//     else
			//       v45 = v122;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v46 = 0;
			//     if ( (v36 << 6) + v45 + 63 > 0 )
			//       v46 = (v36 << 6) + v45 + 63;
			//     v48 = (unsigned int)(v46 >> 31);
			//     LODWORD(v48) = v46 % 64;
			//     v47 = v46 / 64;
			//     v49 = v44;
			//     v50 = v126;
			//     v51 = v47;
			//     if ( v49 - v126 > 0 && v47 - v127 > 0 )
			//     {
			//       v126 = (unsigned int)(i - 2) <= 1;
			//       v129 = ((i - 1) & 0xFFFFFFFD) == 0;
			//       dispatchCount = v32.fields.dispatchCount;
			//       Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_contactShadowDispatchData;
			//       v10 = dispatchCount;
			//       v130 = dispatchCount;
			//       v32.fields.dispatchCount = dispatchCount + 1;
			//       if ( !Patch )
			//         goto LABEL_111;
			//       v53 = (_DWORD *)sub_180412C9C(Patch, dispatchCount);
			//       v54 = v128;
			//       v55 = v53;
			//       v56 = v127;
			//       *v53 = 64;
			//       v53[1] = v54 - v50;
			//       v53[2] = v51 - v56;
			//       if ( (i & 1) == 0 )
			//         v50 = -v54;
			//       v53[3] = v50 + v126;
			//       v57 = (i & 2) != 0 ? -v51 : v56;
			//       v53[4] = v57 + v129;
			//       v58 = v122 + v121;
			//       switch ( i )
			//       {
			//         case 1:
			//           v58 = v123 - v122;
			//           break;
			//         case 2:
			//           v58 = v124 - v121;
			//           break;
			//         case 3:
			//           v58 = -(v123 + v124);
			//           break;
			//       }
			//       v60 = (v58 + 63) >> 31;
			//       v59 = v58 + 63;
			//       v48 = v60;
			//       v62 = __SPAIR64__(v60, v59) % 64;
			//       v61 = __SPAIR64__(v60, v59) / 64;
			//       LODWORD(v48) = v62;
			//       v63 = v61;
			//       if ( v61 > 0 )
			//       {
			//         v64 = v32.fields.dispatchCount;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_contactShadowDispatchData;
			//         v10 = (unsigned int)(v64 + 1);
			//         v32.fields.dispatchCount = v10;
			//         if ( !Patch )
			//           goto LABEL_111;
			//         v65 = sub_180412C9C(Patch, v64);
			//         v67 = v55[2];
			//         v68 = (Vector3Int *)v65;
			//         *(_QWORD *)v65 = *(_QWORD *)v55;
			//         *(_DWORD *)(v65 + 8) = v67;
			//         *(_QWORD *)(v65 + 12) = *(_QWORD *)(v55 + 3);
			//         if ( i )
			//         {
			//           switch ( i )
			//           {
			//             case 1:
			//               v71 = v55[1];
			//               sub_180002C70(TypeInfo::System::Math);
			//               if ( v71 <= v63 )
			//                 v63 = v71;
			//               v68.m_Y = v63;
			//               v72 = v55[1] - v63;
			//               v55[1] = v72;
			//               v68[1].m_X = v72 + v55[3];
			//               ++v68.m_Z;
			//               break;
			//             case 2:
			//               v73 = v55[1];
			//               sub_180002C70(TypeInfo::System::Math);
			//               if ( v73 <= v63 )
			//                 v63 = v73;
			//               v68.m_Y = v63;
			//               v55[1] -= v63;
			//               v55[3] += v68.m_Y;
			//               ++v68.m_Z;
			//               --v68[1].m_Y;
			//               break;
			//             case 3:
			//               Item = UnityEngine::Vector3Int::get_Item((Vector3Int *)v55, 2, v66);
			//               sub_180002C70(TypeInfo::System::Math);
			//               if ( Item <= v63 )
			//                 v63 = Item;
			//               v68.m_Z = v63;
			//               v76 = UnityEngine::Vector3Int::get_Item((Vector3Int *)v55, 2, v75);
			//               v55[2] = v76 - UnityEngine::Vector3Int::get_Item(v68, 2, v77);
			//               v79 = UnityEngine::Vector2Int::get_Item((Vector2Int *)(v55 + 3), 1, v78);
			//               v55[4] = v79 + UnityEngine::Vector3Int::get_Item(v68, 2, v80);
			//               v68.m_Y = UnityEngine::Vector3Int::get_Item(v68, 1, v81) + 1;
			//               break;
			//           }
			//         }
			//         else
			//         {
			//           v69 = v55[2];
			//           sub_180002C70(TypeInfo::System::Math);
			//           if ( v69 <= v63 )
			//             v63 = v69;
			//           v68.m_Z = v63;
			//           v70 = v55[2] - v63;
			//           v55[2] = v70;
			//           v68[1].m_Y = v70 + v55[4];
			//           --v68[1].m_X;
			//           ++v68.m_Y;
			//         }
			//         if ( UnityEngine::Vector3Int::get_Item(v68, 1, v66) > 0 && UnityEngine::Vector3Int::get_Item(v68, 2, v82) > 0 )
			//         {
			//           v32 = passData;
			//         }
			//         else
			//         {
			//           v32 = passData;
			//           --passData.fields.dispatchCount;
			//         }
			//         if ( UnityEngine::Vector3Int::get_Item((Vector3Int *)v55, 1, v82) <= 0
			//           || UnityEngine::Vector3Int::get_Item((Vector3Int *)v55, 2, v83) <= 0 )
			//         {
			//           static_fields = (void *)v32.fields.dispatchCount;
			//           m_contactShadowDispatchData = this.fields.m_contactShadowDispatchData;
			//           v32.fields.dispatchCount = (_DWORD)static_fields - 1;
			//           if ( !m_contactShadowDispatchData )
			//             goto LABEL_109;
			//           v86 = (char *)static_fields - 1;
			//           if ( (unsigned int)((_DWORD)static_fields - 1) >= m_contactShadowDispatchData.max_length.size
			//             || (unsigned int)v130 >= m_contactShadowDispatchData.max_length.size )
			//           {
			//             sub_180070270(static_fields, v48);
			//           }
			//           v87 = v130;
			//           *(_OWORD *)&m_contactShadowDispatchData.vector[v87].workgroupCount.m_X = *(_OWORD *)&m_contactShadowDispatchData.vector[(_QWORD)v86].workgroupCount.m_X;
			//           m_contactShadowDispatchData.vector[v87].workgroupOffset.m_Y = m_contactShadowDispatchData.vector[(_QWORD)v86].workgroupOffset.m_Y;
			//         }
			//       }
			//     }
			//   }
			//   for ( j = 0; j < v32.fields.dispatchCount; ++j )
			//   {
			//     static_fields = this.fields.m_contactShadowDispatchData;
			//     if ( !static_fields )
			//       goto LABEL_109;
			//     v89 = sub_180412C9C(static_fields, j);
			//     *(_DWORD *)(v89 + 12) <<= 6;
			//     static_fields = this.fields.m_contactShadowDispatchData;
			//     if ( !static_fields )
			//       goto LABEL_109;
			//     v90 = sub_180412C9C(static_fields, j);
			//     *(_DWORD *)(v90 + 16) <<= 6;
			//   }
			//   m_contactShadowIntensity = this.fields.m_contactShadowIntensity;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//   v92 = *((_QWORD *)static_fields + 5);
			//   if ( !v92 )
			//     goto LABEL_109;
			//   if ( !*(_BYTE *)(v92 + 16) )
			//     m_contactShadowIntensity = 0.0;
			//   static_fields = this.fields.m_contactShadowParams;
			//   m_contactShadowBilinearThreshold = this.fields.m_contactShadowBilinearThreshold;
			//   lightDir.x = this.fields.m_contactShadowSurfaceThickness;
			//   v94 = _mm_cvtsi32_si128(this.fields.m_contactShadowContrast);
			//   lightDir.y = m_contactShadowBilinearThreshold;
			//   lightDir.w = m_contactShadowIntensity;
			//   LODWORD(lightDir.z) = _mm_cvtepi32_ps(v94).m128_u32[0];
			//   if ( !static_fields )
			//     goto LABEL_109;
			//   sub_18004D910(static_fields, 0LL, &lightDir);
			//   m_contactShadowParams = this.fields.m_contactShadowParams;
			//   m_contactShadowIgnoreEdgePixels = this.fields.m_contactShadowIgnoreEdgePixels;
			//   sub_180002C70(TypeInfo::System::Convert);
			//   *(_QWORD *)&lightDir.x = 0LL;
			//   v97 = this.fields.m_contactShadowFrameIndex & 7;
			//   lightDir.z = (float)m_contactShadowIgnoreEdgePixels;
			//   lightDir.w = (float)v97;
			//   if ( !m_contactShadowParams )
			//     goto LABEL_109;
			//   sub_18004D910(m_contactShadowParams, 1LL, &lightDir);
			//   static_fields = this.fields.m_contactShadowParams;
			//   lightDir.x = (float)v131;
			//   lightDir.y = (float)v132;
			//   lightDir.z = 1.0 / (float)v131;
			//   lightDir.w = 1.0 / (float)v132;
			//   if ( !static_fields )
			//     goto LABEL_109;
			//   sub_18004D910(static_fields, 3LL, &lightDir);
			//   m_resources = this.fields.m_resources;
			//   if ( !m_resources )
			//     goto LABEL_109;
			//   shaders = m_resources.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_109;
			//   contactShadowCS = shaders.fields.contactShadowCS;
			//   if ( !contactShadowCS )
			//     goto LABEL_109;
			//   v32.fields.rayTracingKernel = UnityEngine::ComputeShader::FindKernel(
			//                                    shaders.fields.contactShadowCS,
			//                                    (String *)"RayTracingV2",
			//                                    0LL);
			//   v32.fields.shader = contactShadowCS;
			//   sub_1800054D0((OneofDescriptor *)&v32.fields.shader, v101, v102, v103, v112, v115, P3);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//   s_DisableTerrainContactShadow = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_DisableTerrainContactShadow;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//   ShouldDisableContactShadow = HG::Rendering::Runtime::HGTerrainUtils::ShouldDisableContactShadow(0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//   UnityEngine::Rendering::CoreUtils::SetKeyword(
			//     contactShadowCS,
			//     s_DisableTerrainContactShadow,
			//     ShouldDisableContactShadow,
			//     0LL);
			//   v32.fields.dataParams = this.fields.m_contactShadowParams;
			//   sub_1800054D0((OneofDescriptor *)&v32.fields.dataParams, v106, v107, v108, v113, v116, P3a);
			//   v109 = (MessageDescriptor *)this.fields.m_contactShadowDispatchData;
			//   v32.fields.dispatch = (ContactShadowPassConstructor_DispatchData__Array *)v109;
			//   sub_1800054D0((OneofDescriptor *)&v32.fields.dispatch, v110, v111, v109, v114, v117, P3b);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v133, camera.fields._sceneRTSize_k__BackingField, 0LL);
			//   v48 = (unsigned __int64)renderGraph;
			//   *(_WORD *)&v133.enableRandomWrite = 1;
			//   v133.colorFormat = 6;
			//   v133.wrapMode = 1;
			//   v133.filterMode = 1;
			//   v135 = v133;
			//   v32.fields.depthBufferHandle = input.sceneDepth;
			//   if ( !renderGraph )
			// LABEL_109:
			//     sub_180B536AC(static_fields, v48);
			//   v32.fields.contactShadowCurrHandle = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                            (TextureHandle *)&v134,
			//                                            renderGraph,
			//                                            &v135,
			//                                            0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ContactShadowPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2519, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2519, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ContactShadowPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2520, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2520, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ContactShadowPassConstructor.PassInput input, ref ContactShadowPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ContactShadowPassConstructor+PassInput ByRef, ContactShadowPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::ConstructPass(
			//         ContactShadowPassConstructor *this,
			//         ContactShadowPassConstructor_PassInput *input,
			//         ContactShadowPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   ContactShadowPassConstructor_ContactShadowPassDataV2 *passData; // [rsp+40h] [rbp-68h] BYREF
			//   _QWORD v19[2]; // [rsp+50h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v20; // [rsp+60h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v21; // [rsp+80h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919509 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4F5B48);
			//     byte_18D919509 = 1;
			//   }
			//   passData = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2521, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2521, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_925(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareDataForContactShadow(
			//       this,
			//       input,
			//       renderGraph,
			//       camera,
			//       0LL);
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x69u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v20,
			//       renderGraph,
			//       (String *)"Contact Shadow",
			//       (Object **)&passData,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
			//     v21 = v20;
			//     v19[0] = 0LL;
			//     v19[1] = &v21;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v21, 0, 0LL);
			//     if ( this.fields.m_contactShadowEnable == 3 )
			//     {
			//       HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareContactShadowPassDataV2(
			//         this,
			//         input,
			//         renderGraph,
			//         camera,
			//         passData,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&v20,
			//         &v21,
			//         &input.sceneDepth,
			//         0LL);
			//       if ( !passData )
			//         sub_1802DC2C8(v14, v13);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//         (TextureHandle *)&v20,
			//         &v21,
			//         &passData.fields.contactShadowCurrHandle,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v21,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor.static_fields.s_contactShadowRenderFuncV2,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
			//       sub_180222690(v19);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v21,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor.static_fields.s_contactShadowRenderFuncNoneV2,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
			//       sub_180222690(v19);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ContactShadowPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2522, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2522, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ContactShadowPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2523, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2523, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		private ContactShadowPassConstructor.ContactShadowEnable m_contactShadowEnable;

		private float m_contactShadowIntensity;

		private float m_contactShadowSurfaceThickness;

		private float m_contactShadowBilinearThreshold;

		private int m_contactShadowContrast;

		private bool m_contactShadowIgnoreEdgePixels;

		private uint m_contactShadowFrameIndex;

		private readonly Vector4[] m_contactShadowParams;

		private HGRenderPipelineRuntimeResources m_resources;

		private const string CONTACT_SHADOW_RAY_TRACING_KERNEL = "RayTracing";

		private const string CONTACT_SHADOW_RAY_TRACING_KERNEL_V2 = "RayTracingV2";

		private readonly ContactShadowPassConstructor.DispatchData[] m_contactShadowDispatchData;

		private const int THREAD_COUNT = 64;

		private const float FP_LIMIT = 0.000128f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly ContactShadowPassConstructor.ContactShadowPassDataV2 PASS_DATA_V2_CPP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<ContactShadowPassConstructor.ContactShadowPassDataV2> s_contactShadowRenderFuncV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<ContactShadowPassConstructor.ContactShadowPassDataV2> s_contactShadowRenderFuncNoneV2;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal Vector4 lightDir;

			internal float renderingScale;

			internal bool contactShadowEnableParam;
		}

		internal struct PassOutput
		{
		}

		[Flags]
		private enum ContactShadowEnable
		{
			PipelineEnable = 1,
			PlatformCapable = 2,
			AllEnable = 3
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
		public struct DispatchData
		{
			public Vector3Int workgroupCount;

			public Vector2Int workgroupOffset;
		}

		internal class ContactShadowPassDataV2
		{
			public ContactShadowPassDataV2()
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

			public int rayTracingKernel;

			public ComputeShader shader;

			public Vector4[] dataParams;

			public ContactShadowPassConstructor.DispatchData[] dispatch;

			public int dispatchCount;

			public TextureHandle depthBufferHandle;

			public TextureHandle contactShadowCurrHandle;
		}
	}
}
