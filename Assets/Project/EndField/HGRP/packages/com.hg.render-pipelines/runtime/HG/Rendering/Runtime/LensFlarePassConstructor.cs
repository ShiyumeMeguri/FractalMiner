using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class LensFlarePassConstructor : IPassConstructor
	{
		internal LensFlarePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void Release()
		{
		}

		private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
		{
			// // Single GetLensFlareLightAttenuation(Light, Camera, Vector3)
			// float HG::Rendering::Runtime::LensFlarePassConstructor::GetLensFlareLightAttenuation(
			//         Light *light,
			//         Camera *cam,
			//         Vector3 *wo,
			//         MethodInfo *method)
			// {
			//   HGCamera *v7; // rax
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGCamera *v10; // rbx
			//   Transform *transform; // rax
			//   Vector3 *forward; // rax
			//   __int64 v13; // xmm6_8
			//   float v14; // ebx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   LightType__Enum type; // eax
			//   unsigned __int32 v18; // eax
			//   float v20; // eax
			//   MethodInfo *v21; // r8
			//   Transform *v22; // rax
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm7_8
			//   float v25; // ebx
			//   float spotAngle; // xmm8_4
			//   float innerSpotAngle; // xmm6_4
			//   float z; // eax
			//   Vector3 v29; // [rsp+30h] [rbp-50h] BYREF
			//   Vector3 v30[2]; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D91957D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91957D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2699, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2699, 0LL);
			//     if ( Patch )
			//     {
			//       z = wo.z;
			//       *(_QWORD *)&v30[0].x = *(_QWORD *)&wo.x;
			//       v30[0].z = z;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_986(Patch, (Object *)light, (Object *)cam, v30, 0LL);
			//     }
			// LABEL_23:
			//     sub_180B536AC(Patch, v8);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality((Object_1 *)light, 0LL, 0LL) )
			//     return 1.0;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   v7 = HG::Rendering::Runtime::HGCamera::GetOrCreate(cam, 0, 0LL);
			//   v10 = v7;
			//   if ( !v7 )
			//     goto LABEL_23;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)v7.fields.m_envVolumeCameraComponent;
			//   if ( !Patch )
			//     goto LABEL_23;
			//   if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//          (HGEnvironmentVolumeCameraComponent *)Patch,
			//          light,
			//          0LL) )
			//   {
			//     m_envVolumeCameraComponent = v10.fields.m_envVolumeCameraComponent;
			//     if ( !m_envVolumeCameraComponent )
			//       goto LABEL_23;
			//     m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//     if ( !m_interpolatedPhase )
			//       goto LABEL_23;
			//     v13 = *(_QWORD *)&m_interpolatedPhase.fields.lightConfig.forwardDirect.x;
			//     v14 = m_interpolatedPhase.fields.lightConfig.forwardDirect.z;
			//     if ( !light )
			//       goto LABEL_23;
			//   }
			//   else
			//   {
			//     if ( !light )
			//       goto LABEL_23;
			//     transform = UnityEngine::Component::get_transform((Component *)light, 0LL);
			//     if ( !transform )
			//       goto LABEL_23;
			//     forward = UnityEngine::Transform::get_forward(v30, transform, 0LL);
			//     v13 = *(_QWORD *)&forward.x;
			//     v14 = forward.z;
			//   }
			//   type = UnityEngine::Light::get_type(light, 0LL);
			//   if ( type == LightType__Enum_Spot )
			//   {
			//     v22 = UnityEngine::Component::get_transform((Component *)light, 0LL);
			//     if ( v22 )
			//     {
			//       v23 = UnityEngine::Transform::get_forward(v30, v22, 0LL);
			//       v24 = *(_QWORD *)&v23.x;
			//       v25 = v23.z;
			//       spotAngle = UnityEngine::Light::get_spotAngle(light, 0LL);
			//       innerSpotAngle = UnityEngine::Light::get_innerSpotAngle(light, 0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//       v30[0].z = wo.z;
			//       v29.z = v25;
			//       *(_QWORD *)&v30[0].x = *(_QWORD *)&wo.x;
			//       *(_QWORD *)&v29.x = v24;
			//       return UnityEngine::Rendering::LensFlareCommonSRP::ShapeAttenuationSpotConeLight(
			//                &v29,
			//                v30,
			//                spotAngle,
			//                innerSpotAngle / 180.0,
			//                0LL);
			//     }
			//     goto LABEL_23;
			//   }
			//   v18 = type - 1;
			//   if ( v18 )
			//   {
			//     if ( v18 == 1 )
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     return 1.0;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//   v20 = wo.z;
			//   *(_QWORD *)&v29.x = *(_QWORD *)&wo.x;
			//   v29.z = v20;
			//   *(_QWORD *)&v30[0].x = v13;
			//   v30[0].z = v14;
			//   return fmaxf(UnityEngine::Vector3::Dot(v30, &v29, v21), 0.0);
			// }
			// 
			return 0f;
		}

		public static int GetHGLensFlareCount()
		{
			// // Int32 GetHGLensFlareCount()
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::LensFlarePassConstructor::GetHGLensFlareCount(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v4; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v9; // rdx
			//   UnityEngine::Rendering::LensFlareCommonSRP *v10; // rcx
			//   int32_t v11; // ebx
			//   __int64 Data; // rax
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   __int64 v14; // rcx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   __int64 v17; // rdi
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // r8
			//   __int64 v21; // r9
			//   MonitorData *monitor; // rcx
			//   __int64 v23; // rcx
			//   unsigned int v24; // eax
			//   __int64 v25; // rdx
			//   MethodInfo *v26; // [rsp+20h] [rbp-48h] BYREF
			//   _BYTE v27[24]; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v28; // [rsp+40h] [rbp-28h] BYREF
			//   int32_t v29; // [rsp+78h] [rbp+10h]
			// 
			//   if ( !byte_18D8EDA98 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::get_Current);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::LensFlareComponentSRP>::GetEnumerator);
			//     byte_18D8EDA98 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v1);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v2.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v2, v1);
			//   if ( wrapperArray.max_length.size <= 1005 )
			//     goto LABEL_51;
			//   if ( !v2._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v2, v1);
			//     v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = v2.static_fields.wrapperArray;
			//   if ( !v4 )
			//     sub_180B536AC(v2, v1);
			//   if ( v4.max_length.size <= 0x3EDu )
			//     sub_180070270(v2, v1);
			//   if ( v4[28].monitor )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1005, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			// LABEL_51:
			//     if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v1);
			//     v11 = 0;
			//     v29 = 0;
			//     if ( !UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL) )
			//       sub_180B536AC(v10, v9);
			//     Data = UnityEngine::Rendering::LensFlareCommonSRP::GetData(v10);
			//     v17 = Data;
			//     if ( !Data )
			//       sub_180B536AC(v14, v13);
			//     *(_OWORD *)&v27[8] = 0LL;
			//     *(_QWORD *)v27 = Data;
			//     ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *, MethodInfo *))sub_1800054D0)(
			//       (HGRenderPathScene *)v27,
			//       v13,
			//       v15,
			//       v16,
			//       v26);
			//     *(_DWORD *)&v27[8] = 0;
			//     *(_DWORD *)&v27[12] = *(_DWORD *)(v17 + 28);
			//     *(_QWORD *)&v27[16] = 0LL;
			//     *(_OWORD *)&v28._list = *(_OWORD *)v27;
			//     v28._current = 0LL;
			//     *(_QWORD *)v27 = 0LL;
			//     *(_QWORD *)&v27[8] = &v28;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v28,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext) )
			//       {
			//         if ( !v28._current )
			//           sub_1802DC2C8(v19, v18);
			//         monitor = v28._current[1].monitor;
			//         if ( !monitor )
			//           sub_1802DC2C8(0LL, v18);
			//         v23 = *((_QWORD *)monitor + 3);
			//         v24 = 0;
			//         if ( !v23 )
			//           sub_1802DC2C8(0LL, v18);
			//         while ( (signed int)v24 < *(_DWORD *)(v23 + 24) )
			//         {
			//           if ( v24 >= *(_DWORD *)(v23 + 24) )
			//             sub_180070260(v23, (int)v24, v20, v21);
			//           v25 = *(_QWORD *)(v23 + 8LL * (int)v24 + 32);
			//           if ( !v25 )
			//             sub_1802DC2C8(v23, 0LL);
			//           v11 += *(_DWORD *)(v25 + 72);
			//           v29 = v11;
			//           ++v24;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v26 )
			//     {
			//       *(_QWORD *)v27 = v26.methodPointer;
			//       if ( *(_QWORD *)v27 )
			//         sub_18000F780(*(_QWORD *)v27);
			//       return v29;
			//     }
			//     return v11;
			//   }
			// }
			// 
			return 0;
		}

		public unsafe static void PrepareHGLensFlareDrawNode(Camera cam, Vector2Int renderSize, Vector3 cameraPositionWS, ref LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo, HGLensFlareDrawData* drawDataList, out int drawDataCount, HGSettingParameters settingParameters)
		{
			// // Void PrepareHGLensFlareDrawNode(Camera, Vector2Int, Vector3, LensFlareCommonSRP+SunSourceDirLightOverrideInfo ByRef, HGLensFlareDrawData*, Int32 ByRef, HGSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::LensFlarePassConstructor::PrepareHGLensFlareDrawNode(
			//         Camera *cam,
			//         Vector2Int renderSize,
			//         Vector3 *cameraPositionWS,
			//         LensFlareCommonSRP_SunSourceDirLightOverrideInfo *dirLightOverrideInfo,
			//         HGLensFlareDrawData *drawDataList,
			//         int32_t *drawDataCount,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   int32_t m_X; // ebx
			//   int32_t *v11; // r12
			//   __int64 v12; // rdx
			//   UnityEngine::Rendering::LensFlareCommonSRP *v13; // rcx
			//   __int64 Data; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v21; // xmm6
			//   __int128 v22; // xmm7
			//   __int128 v23; // xmm8
			//   __int128 v24; // xmm9
			//   Matrix4x4 *v25; // rax
			//   __int64 v26; // rdx
			//   Vector4 v27; // xmm15
			//   __int128 v28; // xmm7
			//   __int128 v29; // xmm8
			//   __int128 v30; // xmm10
			//   Object_1 *dirLightGameObject; // rbx
			//   __int64 v32; // rdx
			//   UnityEngine::Rendering::LensFlareCommonSRP *z_low; // rcx
			//   __int64 v34; // rdx
			//   Object *v35; // rbx
			//   __int64 v36; // rdx
			//   Vector3 *v37; // rax
			//   List_1_System_Object_ *v38; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   __int64 v41; // rdx
			//   Object *current; // r15
			//   MonitorData *monitor; // r13
			//   GameObject *gameObject; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   GameObject *v47; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // rdx
			//   __int64 v51; // rdx
			//   Object_1 *v52; // rbx
			//   char v53; // r14
			//   __int64 v54; // rdx
			//   Light *SunSourceLight; // rbx
			//   int32_t InstanceID; // ebx
			//   Object_1 *v57; // rax
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   __int64 v60; // rdx
			//   struct Object_1__Class *v61; // rcx
			//   MonitorData *v62; // xmm0_8
			//   float z; // eax
			//   GameObject *v64; // rbx
			//   GameObject *v65; // r14
			//   bool v66; // zf
			//   Transform *transform; // rax
			//   __int64 v68; // rdx
			//   __int64 v69; // rcx
			//   Vector3 *forward; // rax
			//   __m128 v71; // xmm6
			//   __m128 v72; // xmm7
			//   __m128i v73; // xmm8
			//   __int64 v74; // rdx
			//   float farClipPlane; // xmm0_4
			//   float v76; // ebx
			//   Transform *v77; // rax
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   Vector3 *v80; // rax
			//   Vector3 *v81; // rax
			//   __int64 v82; // rdx
			//   __int64 v83; // rcx
			//   float v84; // xmm10_4
			//   float v85; // xmm8_4
			//   float v86; // xmm11_4
			//   __m128 v87; // xmm7
			//   float v88; // xmm12_4
			//   __m128 v89; // xmm6
			//   Transform *v90; // rax
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   Vector3 *v93; // rax
			//   float v94; // xmm2_4
			//   float v95; // xmm0_4
			//   float v96; // xmm2_4
			//   __int64 v97; // rdx
			//   double v98; // xmm0_8
			//   float v99; // xmm6_4
			//   float v100; // xmm7_4
			//   AnimationCurve *klass; // rcx
			//   AnimationCurve *v102; // rcx
			//   float v103; // xmm6_4
			//   AnimationCurve *v104; // rcx
			//   AnimationCurve *v105; // rcx
			//   float LensFlareLightAttenuation; // xmm7_4
			//   float v107; // xmm8_4
			//   float v108; // xmm9_4
			//   float v109; // xmm15_4
			//   Object_1 *v110; // rbx
			//   float *v111; // rax
			//   __int64 v112; // rdx
			//   __m128 v113; // xmm8
			//   __m128 v114; // xmm7
			//   __m128 v115; // xmm7
			//   float v116; // xmm9_4
			//   Transform *v117; // rax
			//   __int64 v118; // rdx
			//   __int64 v119; // rcx
			//   Vector3 *position; // rax
			//   float v121; // ebx
			//   Transform *v122; // rax
			//   __int64 v123; // rdx
			//   __int64 v124; // rcx
			//   Vector3 *v125; // rax
			//   float v126; // xmm4_4
			//   __m128 v127; // xmm2
			//   __m128 v128; // xmm1
			//   float *v129; // rax
			//   __int64 v130; // rdx
			//   float v131; // xmm0_4
			//   float v132; // xmm8_4
			//   float v133; // xmm8_4
			//   __m128 v134; // xmm6
			//   __m128 v135; // xmm7
			//   Vector4 v136; // xmm15
			//   Vector3 *v137; // rax
			//   float v138; // r15d
			//   LensFlareComponentSRP *v139; // rbx
			//   float occlusionRadius; // xmm9_4
			//   Transform *v141; // rax
			//   __int64 v142; // rdx
			//   __int64 v143; // rcx
			//   Vector3 *up; // rax
			//   __int64 v145; // rdx
			//   float v146; // xmm8_4
			//   float v147; // xmm8_4
			//   __m128 v148; // xmm6
			//   __m128 v149; // xmm7
			//   __m128 v150; // xmm0
			//   __m128 v151; // xmm1
			//   __int64 v152; // rdx
			//   __int64 v153; // rcx
			//   __int32 v154; // xmm6_4
			//   __int64 sampleCount; // r14
			//   __int64 v156; // rdx
			//   __int64 v157; // rbx
			//   PassConstructorID__Enum__Array *v158; // r8
			//   HGCamera *element; // r9
			//   __int64 v160; // rax
			//   __int64 v161; // rbx
			//   LensFlareComponentSRP *v162; // r14
			//   struct LensFlareCommonSRP__Class *v163; // rdx
			//   RTHandle *occlusionRT; // rcx
			//   RenderTexture *m_RT; // rax
			//   unsigned __int64 v166; // rdx
			//   __int64 v167; // rcx
			//   __int64 v168; // rdx
			//   Object_1 *lensFlareTexture; // rbx
			//   __int64 v170; // rdx
			//   __int64 v171; // rcx
			//   Color v172; // xmm8
			//   Color v173; // xmm15
			//   __m128 v174; // xmm11
			//   __m128 v175; // xmm10
			//   __m128 v176; // xmm12
			//   __m128 v177; // xmm9
			//   __m128 v178; // xmm14
			//   __m128 v179; // xmm7
			//   Object_1 *v180; // r15
			//   __int64 v181; // rdx
			//   __int64 v182; // rcx
			//   __int64 v183; // rdx
			//   Object_1 *v184; // r14
			//   Object_1 *v185; // rbx
			//   __m128 v186; // xmm11
			//   __m128 x_low; // xmm12
			//   float v188; // xmm6_4
			//   float v189; // xmm0_4
			//   AnimationCurve *radialScreenAttenuationCurve; // rcx
			//   __int64 v191; // rdx
			//   __int64 v192; // rcx
			//   AnimationCurve *v193; // rcx
			//   float v194; // xmm0_4
			//   Color v195; // xmm6
			//   float colorTemperature; // xmm0_4
			//   __m128 v197; // xmm2
			//   __m128 v198; // xmm1
			//   __m128 v199; // xmm0
			//   Color color; // xmm4
			//   __m128 v201; // xmm5
			//   __m128 v202; // xmm3
			//   __m128 v203; // xmm2
			//   Color v204; // xmm1
			//   LensFlareDataElementSRP *v205; // rax
			//   float v206; // xmm6_4
			//   int v207; // r14d
			//   float v208; // xmm1_4
			//   float v209; // xmm0_4
			//   float y; // xmm2_4
			//   __m128 tint; // xmm1
			//   bool GraphicsUVStartsAtTop; // al
			//   __int64 v213; // rdx
			//   __int64 v214; // rcx
			//   LensFlareDataElementSRP *v215; // rbx
			//   __m128 angularOffset_low; // xmm6
			//   __m128 v217; // xmm7
			//   __m128 v218; // xmm0
			//   __m128 v219; // xmm13
			//   __m128 v220; // xmm0
			//   __int64 v221; // rdx
			//   __m128 v222; // xmm10
			//   float v223; // xmm9_4
			//   Object_1 *v224; // rbx
			//   bool v225; // al
			//   __int64 v226; // rdx
			//   Beyond::JobMathf *v227; // rcx
			//   LensFlareDataElementSRP *v228; // rbx
			//   Texture *v229; // rax
			//   __int64 v230; // rdx
			//   Beyond::JobMathf *v231; // rcx
			//   float m_SdfRoundness; // xmm8_4
			//   int v233; // xmm7_4
			//   float v234; // xmm0_4
			//   Beyond::JobMathf *v235; // rcx
			//   unsigned int v236; // xmm6_4
			//   unsigned int v237; // xmm5_4
			//   __int64 v238; // rdx
			//   __int64 v239; // rcx
			//   float v240; // xmm7_4
			//   double v241; // xmm0_8
			//   float v242; // xmm6_4
			//   __int64 v243; // rdx
			//   __int64 v244; // rcx
			//   __int64 v245; // r8
			//   __int64 v246; // r9
			//   float v247; // xmm1_4
			//   bool allowMultipleElement; // r13
			//   int32_t m_Count; // r15d
			//   int v250; // r15d
			//   __int128 v251; // xmm15
			//   float v252; // xmm7_4
			//   Gradient *colorGradient; // rcx
			//   __int64 v254; // rdx
			//   __int64 v255; // rcx
			//   AnimationCurve *positionCurve; // rcx
			//   __int64 v257; // rdx
			//   __int64 v258; // rcx
			//   AnimationCurve *v259; // rcx
			//   float v260; // xmm0_4
			//   LensFlareDataElementSRP *v261; // rbx
			//   float v262; // xmm11_4
			//   struct LensFlareCommonSRP__Class *v263; // r14
			//   __m128 v264; // xmm8
			//   Vector2 v265; // rdx
			//   Vector2 v266; // rcx
			//   Vector2 v267; // xmm14_8
			//   __m128 v268; // xmm13
			//   __m128 v269; // xmm12
			//   Vector2 v270; // rdx
			//   Vector2 v271; // rcx
			//   Vector2 v272; // xmm6_8
			//   AnimationCurve *v273; // rbx
			//   AnimationCurve *scaleCurve; // rcx
			//   __int64 v275; // rdx
			//   __int64 v276; // rcx
			//   AnimationCurve *v277; // rcx
			//   float v278; // xmm0_4
			//   float v279; // xmm12_4
			//   float v280; // xmm13_4
			//   AnimationCurve *uniformAngleCurve; // rcx
			//   __int64 v282; // rdx
			//   __int64 v283; // rcx
			//   float v284; // xmm0_4
			//   float v285; // xmm6_4
			//   __m128 v286; // xmm7
			//   __m128 v287; // xmm8
			//   __m128 v288; // xmm9
			//   __m128 v289; // xmm10
			//   bool v290; // bl
			//   __m128 v291; // xmm6
			//   float v292; // xmm11_4
			//   __int64 v293; // rdx
			//   Vector4 v294; // xmm4
			//   __int64 v295; // rcx
			//   __int64 v296; // rcx
			//   __int64 v297; // rcx
			//   _BOOL8 v298; // rdx
			//   __int64 v299; // rcx
			//   __int64 v300; // rcx
			//   __int64 v301; // rdx
			//   __int64 v302; // rcx
			//   __int64 v303; // rdx
			//   __int64 v304; // rcx
			//   __int64 v305; // rcx
			//   _OWORD *v306; // rcx
			//   __int64 v307; // rcx
			//   void (__fastcall *v308)(Random_State *); // rax
			//   __int64 v309; // rdx
			//   __int64 v310; // rcx
			//   __int64 v311; // rdx
			//   __int64 v312; // rcx
			//   LensFlareDataElementSRP *v313; // rax
			//   float v314; // xmm0_4
			//   __m128 v315; // xmm15
			//   __m128 v316; // xmm14
			//   int32_t v317; // r15d
			//   __int64 v318; // rdx
			//   __int64 v319; // rcx
			//   float v320; // xmm0_4
			//   LensFlareDataElementSRP *v321; // rbx
			//   float v322; // xmm10_4
			//   struct LensFlareCommonSRP__Class *v323; // r14
			//   float globalSin0; // xmm6_4
			//   Vector2 v325; // rdx
			//   Vector2 v326; // rcx
			//   Vector2 v327; // xmm13_8
			//   __m128 v328; // xmm7
			//   __m128 v329; // xmm8
			//   Vector2 v330; // rdx
			//   Vector2 v331; // rcx
			//   Vector2 v332; // xmm6_8
			//   AnimationCurve *v333; // rbx
			//   float scaleVariation; // xmm6_4
			//   float v335; // xmm6_4
			//   __m128 v336; // xmm1
			//   __m128 v337; // xmm0
			//   Vector2 v338; // r8
			//   Vector2 v339; // r9
			//   Vector2 v340; // rdx
			//   Vector2 v341; // rcx
			//   float r; // xmm11_4
			//   float g; // xmm12_4
			//   Gradient *v344; // rbx
			//   __int64 v345; // rdx
			//   __int64 v346; // rcx
			//   float v347; // xmm0_4
			//   __int64 v348; // rdx
			//   __int64 v349; // rcx
			//   __m128 v350; // xmm6
			//   __m128 v351; // xmm7
			//   float v352; // xmm0_4
			//   __m128 v353; // xmm2
			//   __m128 v354; // xmm1
			//   Vector2 v355; // r8
			//   Vector2 v356; // r9
			//   Vector2 v357; // xmm9_8
			//   __int64 v358; // rdx
			//   __int64 v359; // rcx
			//   float v360; // xmm0_4
			//   float v361; // xmm6_4
			//   __m128 v362; // xmm7
			//   __m128 v363; // xmm8
			//   bool v364; // bl
			//   float v365; // xmm9_4
			//   Vector2 v366; // r8
			//   float v367; // xmm6_4
			//   float v368; // xmm7_4
			//   __int64 v369; // rdx
			//   Vector4 v370; // xmm4
			//   __int64 v371; // rcx
			//   __int64 v372; // rcx
			//   __int64 v373; // rcx
			//   _BOOL8 v374; // rdx
			//   __int64 v375; // rcx
			//   __int64 v376; // rcx
			//   __int64 v377; // rdx
			//   __int64 v378; // rcx
			//   __int64 v379; // rdx
			//   __int64 v380; // rcx
			//   __int64 v381; // rcx
			//   _OWORD *v382; // rcx
			//   __int64 v383; // rcx
			//   __int64 v384; // rcx
			//   float v385; // xmm6_4
			//   float v386; // xmm9_4
			//   float v387; // xmm0_4
			//   float v388; // xmm13_4
			//   int v389; // r15d
			//   __int128 v390; // xmm14
			//   __int128 v391; // xmm15
			//   __m128 v392; // xmm7
			//   __m128 v393; // xmm10
			//   __m128 v394; // xmm11
			//   struct LensFlareCommonSRP__Class *v395; // r14
			//   float v396; // xmm8_4
			//   float v397; // xmm6_4
			//   Vector2 v398; // rdx
			//   Vector2 v399; // rcx
			//   Vector2 v400; // xmm12_8
			//   Vector2 v401; // rdx
			//   Vector2 v402; // rcx
			//   Vector2 v403; // xmm6_8
			//   AnimationCurve *v404; // rbx
			//   float v405; // xmm1_4
			//   Gradient *v406; // rcx
			//   __int64 v407; // rdx
			//   __int64 v408; // rcx
			//   __m128 v409; // xmm6
			//   __m128 v410; // xmm7
			//   __m128 v411; // xmm8
			//   __m128 v412; // xmm9
			//   bool v413; // bl
			//   float v414; // xmm9_4
			//   Vector2 v415; // r9
			//   Vector2 v416; // r8
			//   __int64 v417; // rdx
			//   Vector4 v418; // xmm4
			//   __int64 v419; // rcx
			//   __int64 v420; // rcx
			//   __int64 v421; // rcx
			//   _BOOL8 v422; // rdx
			//   __int64 v423; // rcx
			//   __int64 v424; // rcx
			//   __int64 v425; // rdx
			//   __int64 v426; // rcx
			//   __int64 v427; // rdx
			//   __int64 v428; // rcx
			//   __int64 v429; // rcx
			//   _OWORD *v430; // rcx
			//   __int64 v431; // rcx
			//   struct LensFlareCommonSRP__Class *v432; // r14
			//   Vector2 v433; // rdx
			//   Vector2 v434; // rcx
			//   Vector2 LensFlareRayOffset; // xmm10_8
			//   Vector2 v436; // rdx
			//   Vector2 v437; // rcx
			//   Vector2 v438; // xmm6_8
			//   AnimationCurve *distortionCurve; // rbx
			//   float v440; // xmm11_4
			//   __m128 y_low; // xmm13
			//   __m128 v442; // xmm6
			//   __m128 v443; // xmm7
			//   __m128 v444; // xmm8
			//   __m128 v445; // xmm9
			//   bool autoRotate; // bl
			//   __int64 v447; // rdx
			//   Vector4 v448; // xmm0
			//   __int64 v449; // rcx
			//   __int64 v450; // rcx
			//   __int64 v451; // rcx
			//   _BOOL8 inverseSDF; // rdx
			//   __int64 v453; // rcx
			//   __int64 v454; // rcx
			//   __int64 blendMode; // rdx
			//   __int64 v456; // rcx
			//   __int64 distribution; // rdx
			//   __int64 v458; // rcx
			//   __int64 flareType; // rdx
			//   __int64 v460; // rcx
			//   _OWORD *ptr; // rcx
			//   __int64 v462; // rcx
			//   __int64 v463; // rcx
			//   __m128 v464; // xmm9
			//   MethodInfo *methoda; // [rsp+20h] [rbp-5D8h]
			//   MethodInfo *param_00046aed; // [rsp+28h] [rbp-5D0h]
			//   float param_00046aeda; // [rsp+28h] [rbp-5D0h]
			//   float param_00046aedb; // [rsp+28h] [rbp-5D0h]
			//   float v469; // [rsp+30h] [rbp-5C8h]
			//   Vector2 v470; // [rsp+40h] [rbp-5B8h]
			//   Vector2 v471; // [rsp+40h] [rbp-5B8h]
			//   LensFlarePassConstructor_c_DisplayClass9_0 param_00046aec; // [rsp+60h] [rbp-598h] BYREF
			//   float v473; // [rsp+68h] [rbp-590h]
			//   float v474; // [rsp+6Ch] [rbp-58Ch]
			//   float v475; // [rsp+70h] [rbp-588h]
			//   Color ret; // [rsp+78h] [rbp-580h] BYREF
			//   __int64 v477; // [rsp+88h] [rbp-570h]
			//   float v478; // [rsp+90h] [rbp-568h]
			//   LensFlareComponentSRP *v479; // [rsp+98h] [rbp-560h]
			//   LensFlarePassConstructor_c_DisplayClass9_1 globalCos0; // [rsp+A0h] [rbp-558h] BYREF
			//   __int128 v481; // [rsp+C0h] [rbp-538h]
			//   float rotation; // [rsp+D0h] [rbp-528h]
			//   float v483; // [rsp+D4h] [rbp-524h]
			//   Vector2 v484; // [rsp+D8h] [rbp-520h]
			//   int32_t v485; // [rsp+E0h] [rbp-518h]
			//   unsigned __int64 v486; // [rsp+F0h] [rbp-508h]
			//   __int64 v487; // [rsp+100h] [rbp-4F8h]
			//   __int128 v488; // [rsp+108h] [rbp-4F0h]
			//   int v489; // [rsp+118h] [rbp-4E0h]
			//   float v490; // [rsp+11Ch] [rbp-4DCh]
			//   int v491; // [rsp+120h] [rbp-4D8h]
			//   void *v492; // [rsp+128h] [rbp-4D0h]
			//   void *m_CachedPtr; // [rsp+130h] [rbp-4C8h]
			//   float v494; // [rsp+138h] [rbp-4C0h]
			//   Object_1 *x; // [rsp+140h] [rbp-4B8h]
			//   __int64 v496; // [rsp+148h] [rbp-4B0h]
			//   Vector3 v497; // [rsp+160h] [rbp-498h] BYREF
			//   __int128 v498; // [rsp+170h] [rbp-488h]
			//   __int128 v499; // [rsp+180h] [rbp-478h]
			//   __int128 v500; // [rsp+190h] [rbp-468h]
			//   float v501; // [rsp+1A0h] [rbp-458h]
			//   float v502; // [rsp+1A4h] [rbp-454h]
			//   float v503; // [rsp+1A8h] [rbp-450h]
			//   float v504; // [rsp+1ACh] [rbp-44Ch]
			//   float v505; // [rsp+1B0h] [rbp-448h]
			//   float v506; // [rsp+1B4h] [rbp-444h]
			//   Random_State value; // [rsp+1C0h] [rbp-438h] BYREF
			//   Matrix4x4 v508; // [rsp+1D0h] [rbp-428h] BYREF
			//   MonitorData *v509; // [rsp+210h] [rbp-3E8h]
			//   __int128 v510; // [rsp+220h] [rbp-3D8h]
			//   __int128 v511; // [rsp+230h] [rbp-3C8h]
			//   unsigned __int64 v512; // [rsp+240h] [rbp-3B8h]
			//   Vector3 v513; // [rsp+250h] [rbp-3A8h] BYREF
			//   __int128 v514; // [rsp+260h] [rbp-398h]
			//   Vector4 si128; // [rsp+270h] [rbp-388h] BYREF
			//   Il2CppException *ex; // [rsp+280h] [rbp-378h]
			//   List_1_T_Enumerator_System_Object_ *v517; // [rsp+288h] [rbp-370h]
			//   __int128 v518; // [rsp+290h] [rbp-368h]
			//   __int128 v519; // [rsp+2A0h] [rbp-358h]
			//   __m128 v520; // [rsp+2B0h] [rbp-348h]
			//   __m128 v521; // [rsp+2C0h] [rbp-338h]
			//   __m128 v522; // [rsp+2D0h] [rbp-328h]
			//   __int128 v523; // [rsp+2E0h] [rbp-318h]
			//   __int128 v524; // [rsp+2F0h] [rbp-308h]
			//   __int64 v525; // [rsp+300h] [rbp-2F8h]
			//   Color v526; // [rsp+310h] [rbp-2E8h]
			//   Vector3 v527; // [rsp+320h] [rbp-2D8h] BYREF
			//   unsigned __int64 v528; // [rsp+330h] [rbp-2C8h] BYREF
			//   float v529; // [rsp+338h] [rbp-2C0h]
			//   Vector3 v530; // [rsp+340h] [rbp-2B8h] BYREF
			//   Vector3 v531; // [rsp+350h] [rbp-2A8h] BYREF
			//   Matrix4x4 v532; // [rsp+360h] [rbp-298h] BYREF
			//   List_1_T_Enumerator_System_Object_ v533; // [rsp+3A0h] [rbp-258h] BYREF
			//   List_1_T_Enumerator_System_Object_ v534; // [rsp+3B8h] [rbp-240h] BYREF
			//   Il2CppExceptionWrapper *v535; // [rsp+3D0h] [rbp-228h] BYREF
			//   Vector3 v536; // [rsp+3D8h] [rbp-220h] BYREF
			//   Vector3 v537; // [rsp+3E8h] [rbp-210h] BYREF
			//   char v538[16]; // [rsp+3F8h] [rbp-200h] BYREF
			//   Vector3 v539; // [rsp+408h] [rbp-1F0h] BYREF
			//   Vector3 v540; // [rsp+418h] [rbp-1E0h] BYREF
			//   char v541[16]; // [rsp+428h] [rbp-1D0h] BYREF
			//   Vector3 v542; // [rsp+438h] [rbp-1C0h] BYREF
			//   Vector3 v543; // [rsp+448h] [rbp-1B0h] BYREF
			//   Vector3 v544; // [rsp+458h] [rbp-1A0h] BYREF
			//   Vector3 v545; // [rsp+468h] [rbp-190h] BYREF
			//   Vector3 v546; // [rsp+478h] [rbp-180h] BYREF
			//   Color v547; // [rsp+488h] [rbp-170h] BYREF
			//   Color v548; // [rsp+498h] [rbp-160h] BYREF
			//   Vector4 v549; // [rsp+4A8h] [rbp-150h] BYREF
			//   Vector4 v550; // [rsp+4B8h] [rbp-140h] BYREF
			//   Vector4 v551; // [rsp+4C8h] [rbp-130h] BYREF
			//   Matrix4x4 v552[3]; // [rsp+4D8h] [rbp-120h] BYREF
			//   int32_t m_Y; // [rsp+60Ch] [rbp+14h]
			// 
			//   m_Y = renderSize.m_Y;
			//   m_X = renderSize.m_X;
			//   if ( !byte_18D8EDA99 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::get_Current);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::LensFlareComponentSRP>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDA99 = 1;
			//   }
			//   v498 = 0LL;
			//   v500 = 0LL;
			//   param_00046aec.element = 0LL;
			//   memset(&globalCos0, 0, sizeof(globalCos0));
			//   v499 = 0LL;
			//   v481 = 0LL;
			//   v488 = 0LL;
			//   *(_QWORD *)&ret.r = 0LL;
			//   v484 = 0LL;
			//   v487 = 0LL;
			//   v11 = drawDataCount;
			//   *drawDataCount = 0;
			//   if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//     ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//       TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP,
			//       renderSize);
			//   if ( !UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL) )
			//     sub_180B536AC(v13, v12);
			//   if ( !byte_18D8F361C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::LensFlareComponentSRP>::get_Count);
			//     byte_18D8F361C = 1;
			//   }
			//   Data = UnityEngine::Rendering::LensFlareCommonSRP::GetData(v13);
			//   if ( !Data )
			//     sub_180B536AC(v17, v16);
			//   if ( *(_DWORD *)(Data + 24) )
			//   {
			//     sub_182805160(&v508);
			//     if ( !cam )
			//       sub_180B536AC(v19, v18);
			//     v532 = *UnityEngine::Camera::get_worldToCameraMatrix(&v508, cam, 0LL);
			//     v508 = *UnityEngine::Camera::get_projectionMatrix(v552, cam, 0LL);
			//     GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v552, &v508, 1, 0LL);
			//     v21 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//     v22 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//     v23 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//     v24 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//     si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//     UnityEngine::Matrix4x4::SetColumn(&v532, 3, &si128, 0LL);
			//     v508 = v532;
			//     *(_OWORD *)&v532.m00 = v21;
			//     *(_OWORD *)&v532.m01 = v22;
			//     *(_OWORD *)&v532.m02 = v23;
			//     *(_OWORD *)&v532.m03 = v24;
			//     v25 = UnityEngine::Matrix4x4::op_Multiply(v552, &v532, &v508, 0LL);
			//     v27 = *(Vector4 *)&v25.m00;
			//     si128 = *(Vector4 *)&v25.m00;
			//     v28 = *(_OWORD *)&v25.m01;
			//     v510 = v28;
			//     v29 = *(_OWORD *)&v25.m02;
			//     v511 = v29;
			//     v30 = *(_OWORD *)&v25.m03;
			//     v518 = v30;
			//     v504 = (float)m_X;
			//     v505 = (float)m_Y;
			//     v483 = (float)m_X / (float)m_Y;
			//     dirLightGameObject = (Object_1 *)dirLightOverrideInfo.dirLightGameObject;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//     if ( UnityEngine::Object::op_Implicit(dirLightGameObject, 0LL) )
			//     {
			//       if ( !dirLightOverrideInfo.dirLightGameObject )
			//         sub_180B536AC(z_low, v32);
			//       v35 = UnityEngine::GameObject::GetComponent<System::Object>(
			//               dirLightOverrideInfo.dirLightGameObject,
			//               MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//       if ( UnityEngine::Object::op_Inequality((Object_1 *)v35, 0LL, 0LL) && dirLightOverrideInfo.flareData.enable )
			//       {
			//         if ( !v35 )
			//           sub_180B536AC(z_low, v36);
			//         UnityEngine::Rendering::LensFlareComponentSRP::set_lensFlareData(
			//           (LensFlareComponentSRP *)v35,
			//           dirLightOverrideInfo.flareData.lensFlareData,
			//           0LL);
			//         *(float *)&v35[2].klass = dirLightOverrideInfo.flareData.intensity;
			//         *(float *)&v35[6].klass = dirLightOverrideInfo.flareData.scale;
			//         LOBYTE(v35[5].klass) = dirLightOverrideInfo.flareData.useOcclusion;
			//         HIDWORD(v35[5].klass) = LODWORD(dirLightOverrideInfo.flareData.occlusionRadius);
			//         LODWORD(v35[5].monitor) = dirLightOverrideInfo.flareData.sampleCount;
			//         HIDWORD(v35[5].monitor) = LODWORD(dirLightOverrideInfo.flareData.occlusionOffset);
			//         BYTE4(v35[6].klass) = dirLightOverrideInfo.flareData.allowOffScreen;
			//         HIDWORD(v35[5].monitor) = LODWORD(dirLightOverrideInfo.flareData.occlusionOffset);
			//         BYTE5(v35[6].klass) = 1;
			//         *(_QWORD *)&v497.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v497.z = 1.0;
			//         value = (Random_State)dirLightOverrideInfo.lightData.rotationLensFlare;
			//         v37 = UnityEngine::Quaternion::op_Multiply(&v513, (Quaternion *)&value, &v497, 0LL);
			//         z_low = (UnityEngine::Rendering::LensFlareCommonSRP *)LODWORD(v37.z);
			//         v35[6].monitor = *(MonitorData **)&v37.x;
			//         LODWORD(v35[7].klass) = (_DWORD)z_low;
			//       }
			//     }
			//     v489 = 0;
			//     v38 = (List_1_System_Object_ *)UnityEngine::Rendering::LensFlareCommonSRP::GetData(z_low);
			//     if ( !v38 )
			//       sub_180B536AC(v40, v39);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v534,
			//       v38,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::LensFlareComponentSRP>::GetEnumerator);
			//     v533 = v534;
			//     ex = 0LL;
			//     v517 = &v533;
			//     try
			//     {
			//       v464 = (__m128)0x80000000;
			//       while ( 1 )
			//       {
			//         while ( 1 )
			//         {
			//           if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v533,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext) )
			//             goto LABEL_555;
			//           current = v533._current;
			//           v479 = (LensFlareComponentSRP *)v533._current;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//           if ( !byte_18D8F4EFA )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EFA = 1;
			//           }
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//           if ( !byte_18D8F4EAF )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EAF = 1;
			//           }
			//           if ( current )
			//           {
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//             if ( current[1].klass )
			//             {
			//               monitor = current[1].monitor;
			//               if ( UnityEngine::Behaviour::get_enabled((Behaviour *)current, 0LL) )
			//               {
			//                 gameObject = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
			//                 if ( !gameObject )
			//                   sub_1802DC2C8(v46, v45);
			//                 if ( UnityEngine::GameObject::get_activeSelf(gameObject, 0LL) )
			//                 {
			//                   v47 = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
			//                   if ( !v47 )
			//                     sub_1802DC2C8(v49, v48);
			//                   if ( UnityEngine::GameObject::get_activeInHierarchy(v47, 0LL) )
			//                   {
			//                     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//                     if ( !byte_18D8F4EFA )
			//                     {
			//                       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                       byte_18D8F4EFA = 1;
			//                     }
			//                     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//                     if ( !byte_18D8F4EAF )
			//                     {
			//                       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                       byte_18D8F4EAF = 1;
			//                     }
			//                     if ( monitor )
			//                     {
			//                       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//                       if ( *((_QWORD *)monitor + 2)
			//                         && *((_QWORD *)monitor + 3)
			//                         && *(_QWORD *)(*((_QWORD *)monitor + 3) + 24LL)
			//                         && *(float *)&current[2].klass > 0.0 )
			//                       {
			//                         break;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//         v52 = (Object_1 *)UnityEngine::Component::GetComponent<System::Object>(
			//                             (Component *)current,
			//                             MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
			//         x = v52;
			//         v53 = 0;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//         if ( !byte_18D8F4EFB )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EFB = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( !v52 )
			//           break;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//         if ( !v52.fields.m_CachedPtr || UnityEngine::Light::get_type((Light *)v52, 0LL) != LightType__Enum_Directional )
			//           break;
			//         SunSourceLight = UnityEngine::Light::GetSunSourceLight(0LL);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v54);
			//         if ( !byte_18D8F4EFA )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EFA = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v54);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( SunSourceLight )
			//         {
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v54);
			//           if ( SunSourceLight.fields._._._.m_CachedPtr )
			//           {
			//             InstanceID = UnityEngine::Object::GetInstanceID(x, 0LL);
			//             v57 = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
			//             if ( !v57 )
			//               sub_1802DC2C8(v59, v58);
			//             if ( InstanceID == UnityEngine::Object::GetInstanceID(v57, 0LL) )
			//             {
			//               if ( BYTE5(current[6].klass) )
			//               {
			//                 v62 = current[6].monitor;
			//                 z = *(float *)&current[7].klass;
			//               }
			//               else
			//               {
			//                 v64 = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
			//                 v65 = dirLightOverrideInfo.dirLightGameObject;
			//                 if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                   il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//                 if ( !byte_18D8F4EFA )
			//                 {
			//                   sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                   byte_18D8F4EFA = 1;
			//                 }
			//                 v61 = TypeInfo::UnityEngine::Object;
			//                 if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                   il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//                 if ( !byte_18D8F4EAF )
			//                 {
			//                   sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                   byte_18D8F4EAF = 1;
			//                 }
			//                 LOBYTE(v61) = v65 == 0LL;
			//                 if ( v65 == 0LL && v64 == 0LL )
			//                   goto LABEL_108;
			//                 if ( v65 )
			//                 {
			//                   if ( v64 )
			//                   {
			//                     v66 = v64 == v65;
			//                   }
			//                   else
			//                   {
			//                     v61 = TypeInfo::UnityEngine::Object;
			//                     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//                     v66 = v65.fields._.m_CachedPtr == 0LL;
			//                   }
			//                 }
			//                 else
			//                 {
			//                   v61 = TypeInfo::UnityEngine::Object;
			//                   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//                   if ( !v64 )
			//                     sub_1802DC2C8(v61, v60);
			//                   v66 = v64.fields._.m_CachedPtr == 0LL;
			//                 }
			//                 if ( v66 )
			//                 {
			// LABEL_108:
			//                   v62 = *(MonitorData **)&dirLightOverrideInfo.lightData.dirLightFoward.x;
			//                   z = dirLightOverrideInfo.lightData.dirLightFoward.z;
			//                 }
			//                 else
			//                 {
			//                   transform = UnityEngine::Component::get_transform((Component *)x, 0LL);
			//                   if ( !transform )
			//                     sub_1802DC2C8(v69, v68);
			//                   forward = UnityEngine::Transform::get_forward(&v544, transform, 0LL);
			//                   v62 = *(MonitorData **)&forward.x;
			//                   z = forward.z;
			//                 }
			//               }
			//               v509 = v62;
			//               v71 = _mm_xor_ps((__m128)(unsigned int)v62, v464);
			//               v72 = _mm_xor_ps((__m128)HIDWORD(v62), v464);
			//               v73 = (__m128i)_mm_xor_ps((__m128)_mm_cvtsi32_si128(LODWORD(z)), v464);
			//               if ( !cam )
			//                 sub_1802DC2C8(v61, v60);
			//               farClipPlane = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
			//               *(float *)v73.m128i_i32 = *(float *)v73.m128i_i32 * farClipPlane;
			//               v72.m128_f32[0] = v72.m128_f32[0] * farClipPlane;
			//               v71.m128_f32[0] = v71.m128_f32[0] * farClipPlane;
			//               v71.m128_u64[0] = _mm_unpacklo_ps(v71, v72).m128_u64[0];
			//               v512 = v71.m128_u64[0];
			//               v76 = COERCE_FLOAT(_mm_cvtsi128_si32(v73));
			//               v53 = 1;
			//               v28 = v510;
			//               v29 = v511;
			// LABEL_113:
			//               if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v74);
			//               *(_QWORD *)&v531.x = v71.m128_u64[0];
			//               v531.z = v76;
			//               *(Vector4 *)&v508.m00 = v27;
			//               *(_OWORD *)&v508.m01 = v28;
			//               *(_OWORD *)&v508.m02 = v29;
			//               *(_OWORD *)&v508.m03 = v30;
			//               v81 = UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
			//                       &v543,
			//                       cam,
			//                       v53 != 1,
			//                       1,
			//                       &v508,
			//                       &v531,
			//                       0LL);
			//               v496 = *(_QWORD *)&v81.x;
			//               if ( v81.z >= 0.0
			//                 && (BYTE4(current[6].klass)
			//                  || *(float *)&v496 >= 0.0
			//                  && *(float *)&v496 <= 1.0
			//                  && *((float *)&v496 + 1) >= 0.0
			//                  && *((float *)&v496 + 1) <= 1.0) )
			//               {
			//                 v84 = v76;
			//                 v85 = v76 - cameraPositionWS.z;
			//                 v86 = *((float *)&v512 + 1);
			//                 v87 = (__m128)HIDWORD(v512);
			//                 v87.m128_f32[0] = *((float *)&v512 + 1)
			//                                 - _mm_shuffle_ps(
			//                                     (__m128)*(unsigned __int64 *)&cameraPositionWS.x,
			//                                     (__m128)*(unsigned __int64 *)&cameraPositionWS.x,
			//                                     85).m128_f32[0];
			//                 v88 = *(float *)&v512;
			//                 v89 = (__m128)(unsigned int)v512;
			//                 v486 = *(_QWORD *)&cameraPositionWS.x;
			//                 v89.m128_f32[0] = *(float *)&v512 - *(float *)&v486;
			//                 *(_QWORD *)&v497.x = _mm_unpacklo_ps(v89, v87).m128_u64[0];
			//                 v497.z = v85;
			//                 if ( !cam )
			//                   sub_1802DC2C8(v83, v82);
			//                 v90 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
			//                 if ( !v90 )
			//                   sub_1802DC2C8(v92, v91);
			//                 v93 = UnityEngine::Transform::get_forward(&v542, v90, 0LL);
			//                 v94 = v93.z;
			//                 v95 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v93.x, (__m128)*(unsigned __int64 *)&v93.x, 85).m128_f32[0];
			//                 v486 = *(_QWORD *)&v93.x;
			//                 v96 = (float)(v94 * v85)
			//                     + (float)((float)(v95 * v87.m128_f32[0]) + (float)(*(float *)&v486 * v89.m128_f32[0]));
			//                 v28 = v510;
			//                 v29 = v511;
			//                 if ( v96 >= 0.0 )
			//                 {
			//                   v98 = sub_18238EFA0(&v497);
			//                   v99 = *(float *)&v98 / *((float *)&current[2].klass + 1);
			//                   v100 = *(float *)&v98 / *(float *)&current[2].monitor;
			//                   if ( v53 )
			//                     goto LABEL_129;
			//                   klass = (AnimationCurve *)current[3].klass;
			//                   if ( !klass )
			//                     sub_1802DC2C8(0LL, v97);
			//                   if ( UnityEngine::AnimationCurve::get_length(klass, 0LL) <= 0 )
			//                   {
			// LABEL_129:
			//                     v103 = 1.0;
			//                     v494 = 1.0;
			//                     if ( !v53 )
			//                       goto LABEL_130;
			//                   }
			//                   else
			//                   {
			//                     v102 = (AnimationCurve *)current[3].klass;
			//                     if ( !v102 )
			//                       sub_1802DC2C8(0LL, v97);
			//                     v103 = UnityEngine::AnimationCurve::Evaluate(v102, v99, 0LL);
			//                     v494 = v103;
			// LABEL_130:
			//                     v104 = (AnimationCurve *)current[3].monitor;
			//                     if ( !v104 )
			//                       sub_1802DC2C8(0LL, v97);
			//                     if ( UnityEngine::AnimationCurve::get_length(v104, 0LL) >= 1 )
			//                     {
			//                       v105 = (AnimationCurve *)current[3].monitor;
			//                       if ( !v105 )
			//                         sub_1802DC2C8(0LL, v97);
			//                       v490 = UnityEngine::AnimationCurve::Evaluate(v105, v100, 0LL);
			// LABEL_135:
			//                       LensFlareLightAttenuation = 1.0;
			//                       v107 = 1.0;
			//                       v108 = 1.0;
			//                       v109 = 1.0;
			//                       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v97);
			//                       v110 = x;
			//                       if ( UnityEngine::Object::op_Inequality(x, 0LL, 0LL) && LOBYTE(current[4].klass) )
			//                       {
			//                         v111 = (float *)sub_182413270(v541, &v497);
			//                         v113 = _mm_xor_ps((__m128)*(unsigned __int64 *)v111, (__m128)0x80000000);
			//                         v114 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)v111, (__m128)*(unsigned __int64 *)v111, 85);
			//                         v486 = *(_QWORD *)v111;
			//                         v115 = _mm_xor_ps(v114, (__m128)0x80000000);
			//                         v116 = -v111[2];
			//                         if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor, v112);
			//                         *(_QWORD *)&v530.x = _mm_unpacklo_ps(v113, v115).m128_u64[0];
			//                         v530.z = v116;
			//                         LensFlareLightAttenuation = HG::Rendering::Runtime::LensFlarePassConstructor::GetLensFlareLightAttenuation(
			//                                                       (Light *)v110,
			//                                                       cam,
			//                                                       &v530,
			//                                                       0LL);
			//                         v109 = LensFlareLightAttenuation;
			//                         v108 = LensFlareLightAttenuation;
			//                         v107 = LensFlareLightAttenuation;
			//                       }
			//                       v506 = v109 * v103;
			//                       v501 = v108 * v103;
			//                       v502 = v107 * v103;
			//                       v503 = LensFlareLightAttenuation * v103;
			//                       v117 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
			//                       if ( !v117 )
			//                         sub_1802DC2C8(v119, v118);
			//                       position = UnityEngine::Transform::get_position(&v540, v117, 0LL);
			//                       v525 = *(_QWORD *)&position.x;
			//                       v121 = position.z;
			//                       v122 = UnityEngine::Component::get_transform((Component *)current, 0LL);
			//                       if ( !v122 )
			//                         sub_1802DC2C8(v124, v123);
			//                       v125 = UnityEngine::Transform::get_position(&v539, v122, 0LL);
			//                       v126 = v121 - v125.z;
			//                       v127 = (__m128)HIDWORD(v525);
			//                       v127.m128_f32[0] = *((float *)&v525 + 1)
			//                                        - _mm_shuffle_ps(
			//                                            (__m128)*(unsigned __int64 *)&v125.x,
			//                                            (__m128)*(unsigned __int64 *)&v125.x,
			//                                            85).m128_f32[0];
			//                       v128 = (__m128)(unsigned int)v525;
			//                       v486 = *(_QWORD *)&v125.x;
			//                       v128.m128_f32[0] = *(float *)&v525 - *(float *)&v486;
			//                       v528 = _mm_unpacklo_ps(v128, v127).m128_u64[0];
			//                       v529 = v126;
			//                       v129 = (float *)sub_182413270(v538, &v528);
			//                       v131 = *((float *)&current[5].monitor + 1);
			//                       v135 = (__m128)*(unsigned __int64 *)v129;
			//                       v132 = v129[2];
			//                       v134 = _mm_shuffle_ps(v135, v135, 85);
			//                       v486 = v135.m128_u64[0];
			//                       v133 = (float)(v132 * v131) + v84;
			//                       v134.m128_f32[0] = (float)(v134.m128_f32[0] * v131) + v86;
			//                       v135.m128_f32[0] = (float)(v135.m128_f32[0] * v131) + v88;
			//                       if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v130);
			//                       *(_QWORD *)&v527.x = _mm_unpacklo_ps(v135, v134).m128_u64[0];
			//                       v527.z = v133;
			//                       v136 = si128;
			//                       *(Vector4 *)&v508.m00 = si128;
			//                       *(_OWORD *)&v508.m01 = v510;
			//                       *(_OWORD *)&v508.m02 = v511;
			//                       *(_OWORD *)&v508.m03 = v518;
			//                       v137 = UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
			//                                &v537,
			//                                cam,
			//                                v53 != 1,
			//                                1,
			//                                &v508,
			//                                &v527,
			//                                0LL);
			//                       v486 = *(_QWORD *)&v137.x;
			//                       v138 = v137.z;
			//                       v139 = v479;
			//                       if ( v53 )
			//                         occlusionRadius = UnityEngine::Rendering::LensFlareComponentSRP::celestialProjectedOcclusionRadius(
			//                                             v479,
			//                                             cam,
			//                                             0LL);
			//                       else
			//                         occlusionRadius = v479.fields.occlusionRadius;
			//                       v141 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
			//                       if ( !v141 )
			//                         sub_1802DC2C8(v143, v142);
			//                       up = UnityEngine::Transform::get_up(&v536, v141, 0LL);
			//                       v149 = (__m128)*(unsigned __int64 *)&up.x;
			//                       v146 = up.z;
			//                       v148 = _mm_shuffle_ps(v149, v149, 85);
			//                       v486 = v149.m128_u64[0];
			//                       v147 = (float)(v146 * occlusionRadius) + v84;
			//                       v148.m128_f32[0] = (float)(v148.m128_f32[0] * occlusionRadius) + v86;
			//                       v149.m128_f32[0] = (float)(v149.m128_f32[0] * occlusionRadius) + v88;
			//                       if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v145);
			//                       *(_QWORD *)&v513.x = _mm_unpacklo_ps(v149, v148).m128_u64[0];
			//                       v513.z = v147;
			//                       *(Vector4 *)&v508.m00 = v136;
			//                       *(_OWORD *)&v508.m01 = v510;
			//                       *(_OWORD *)&v508.m02 = v511;
			//                       *(_OWORD *)&v508.m03 = v518;
			//                       v150 = (__m128)*(unsigned __int64 *)&UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
			//                                                              &v546,
			//                                                              cam,
			//                                                              v53 != 1,
			//                                                              1,
			//                                                              &v508,
			//                                                              &v513,
			//                                                              0LL).x;
			//                       v151 = _mm_shuffle_ps(v150, v150, 85);
			//                       v151.m128_f32[0] = v151.m128_f32[0] - *((float *)&v496 + 1);
			//                       v486 = v150.m128_u64[0];
			//                       v150.m128_f32[0] = v150.m128_f32[0] - *(float *)&v496;
			//                       drawDataCount = (int32_t *)_mm_unpacklo_ps(v150, v151).m128_u64[0];
			//                       *(double *)v150.m128_u64 = sub_182413570(&drawDataCount);
			//                       v154 = v150.m128_i32[0];
			//                       sampleCount = v139.fields.sampleCount;
			//                       if ( !settingParameters )
			//                         sub_1802DC2C8(v153, v152);
			//                       v157 = (int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                     (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._lensFlareOccSampleCount_k__BackingField,
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                       if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::System::Math, v156);
			//                       v160 = v157;
			//                       v161 = sampleCount;
			//                       if ( sampleCount > v160 )
			//                         v161 = v160;
			//                       LODWORD(v498) = v154;
			//                       *((float *)&v498 + 1) = (float)(int)v161;
			//                       *((float *)&v498 + 2) = v138;
			//                       *((float *)&v498 + 3) = v505 / v504;
			//                       v162 = v479;
			//                       LOBYTE(drawDataCount) = v479.fields.useOcclusion;
			//                       m_CachedPtr = 0LL;
			//                       v163 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                       if ( TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP.static_fields.occlusionRT )
			//                       {
			//                         if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                         {
			//                           il2cpp_runtime_class_init_0(
			//                             TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP,
			//                             TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//                           v163 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                         }
			//                         occlusionRT = v163.static_fields.occlusionRT;
			//                         if ( !occlusionRT )
			//                           sub_1802DC2C8(0LL, v163);
			//                         m_RT = occlusionRT.fields.m_RT;
			//                         if ( !m_RT )
			//                           sub_1802DC2C8(occlusionRT, v163);
			//                         m_CachedPtr = m_RT.fields._._.m_CachedPtr;
			//                       }
			//                       if ( !v163._1.cctor_finished_or_no_cctor )
			//                       {
			//                         il2cpp_runtime_class_init_0(v163, v163);
			//                         v163 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                       }
			//                       *(float *)&v500 = (float)((float)v489 / (float)v163.static_fields.maxLensFlareWithOcclusion)
			//                                       + (float)(0.5 / (float)v163.static_fields.maxLensFlareWithOcclusion);
			//                       *(_QWORD *)((char *)&v500 + 4) = 1056964608LL;
			//                       HIDWORD(v500) = 0;
			//                       if ( v162.fields.useOcclusion && v161 > 0 )
			//                         ++v489;
			//                       v166 = *((_QWORD *)monitor + 3);
			//                       v486 = v166;
			//                       v167 = 0LL;
			//                       v491 = 0;
			//                       if ( !v166 )
			//                         sub_1802DC2C8(0LL, 0LL);
			//                       while ( 1 )
			//                       {
			// LABEL_169:
			//                         if ( (int)v167 >= *(_DWORD *)(v166 + 24) )
			//                         {
			//                           v464 = (__m128)0x80000000;
			//                           v27 = si128;
			//                           v28 = v510;
			//                           v29 = v511;
			//                           goto LABEL_23;
			//                         }
			//                         if ( (unsigned int)v167 >= *(_DWORD *)(v166 + 24) )
			//                           sub_180070260(v167, v166, v158, element);
			//                         param_00046aec.element = *(LensFlareDataElementSRP **)(v166 + 8LL * (int)v167 + 32);
			//                         sub_1800054D0(
			//                           (HGRenderPathScene *)&param_00046aec,
			//                           (HGRenderPathBase_HGRenderPathResources *)v166,
			//                           v158,
			//                           element,
			//                           methoda,
			//                           param_00046aed);
			//                         element = (HGCamera *)param_00046aec.element;
			//                         if ( !param_00046aec.element || !param_00046aec.element.fields.visible )
			//                           goto LABEL_345;
			//                         lensFlareTexture = (Object_1 *)param_00046aec.element.fields.lensFlareTexture;
			//                         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v168);
			//                         if ( UnityEngine::Object::op_Equality(lensFlareTexture, 0LL, 0LL) )
			//                         {
			//                           if ( !param_00046aec.element )
			//                             sub_1802DC2C8(v171, v170);
			//                           if ( !param_00046aec.element.fields.flareType )
			//                             goto LABEL_345;
			//                         }
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v171, v170);
			//                         if ( param_00046aec.element.fields.m_LocalIntensity <= 0.0
			//                           || param_00046aec.element.fields.m_Count <= 0
			//                           || param_00046aec.element.fields.m_LocalIntensity <= 0.0 )
			//                         {
			//                           goto LABEL_345;
			//                         }
			//                         v172 = (Color)LODWORD(v503);
			//                         v173 = (Color)LODWORD(v503);
			//                         v174 = (__m128)LODWORD(v502);
			//                         v175 = (__m128)LODWORD(v502);
			//                         v176 = (__m128)LODWORD(v501);
			//                         v177 = (__m128)LODWORD(v501);
			//                         v178 = (__m128)LODWORD(v506);
			//                         v179 = (__m128)LODWORD(v506);
			//                         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v170);
			//                         v180 = x;
			//                         if ( UnityEngine::Object::op_Inequality(x, 0LL, 0LL) )
			//                         {
			//                           if ( !param_00046aec.element )
			//                             sub_1802DC2C8(v182, v181);
			//                           if ( param_00046aec.element.fields.modulateByLightColor )
			//                           {
			//                             if ( !v180 )
			//                               sub_1802DC2C8(v182, v181);
			//                             v184 = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)v180, 0LL);
			//                             v185 = (Object_1 *)dirLightOverrideInfo.dirLightGameObject;
			//                             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v183);
			//                             if ( UnityEngine::Object::op_Equality(v184, v185, 0LL) )
			//                             {
			//                               color = dirLightOverrideInfo.lightData.color;
			//                               v201 = v178;
			//                               v201.m128_f32[0] = v178.m128_f32[0]
			//                                                * _mm_shuffle_ps((__m128)color, (__m128)color, 255).m128_f32[0];
			//                               v202 = v176;
			//                               v202.m128_f32[0] = v176.m128_f32[0]
			//                                                * _mm_shuffle_ps((__m128)color, (__m128)color, 170).m128_f32[0];
			//                               v203 = v174;
			//                               v203.m128_f32[0] = v174.m128_f32[0]
			//                                                * _mm_shuffle_ps((__m128)color, (__m128)color, 85).m128_f32[0];
			//                               v204 = v172;
			//                               v204.r = v172.r * color.r;
			//                               v173 = v204;
			//                               v175 = v203;
			//                               v177 = v202;
			//                               v179 = v201;
			//                             }
			//                             else if ( UnityEngine::Light::get_useColorTemperature((Light *)v180, 0LL) )
			//                             {
			//                               v195 = *UnityEngine::Light::get_color(&v548, (Light *)v180, 0LL);
			//                               colorTemperature = UnityEngine::Light::get_colorTemperature((Light *)v180, 0LL);
			//                               ret = 0LL;
			//                               UnityEngine::Mathf::CorrelatedColorTemperatureToRGB_Injected(colorTemperature, &ret, 0LL);
			//                               v197 = v178;
			//                               v197.m128_f32[0] = v178.m128_f32[0]
			//                                                * (float)(_mm_shuffle_ps((__m128)v195, (__m128)v195, 255).m128_f32[0]
			//                                                        * ret.a);
			//                               v198 = v176;
			//                               v198.m128_f32[0] = v176.m128_f32[0]
			//                                                * (float)(_mm_shuffle_ps((__m128)v195, (__m128)v195, 170).m128_f32[0]
			//                                                        * ret.b);
			//                               v199 = v174;
			//                               v199.m128_f32[0] = v174.m128_f32[0]
			//                                                * (float)(_mm_shuffle_ps((__m128)v195, (__m128)v195, 85).m128_f32[0]
			//                                                        * ret.g);
			//                               v195.r = (float)(v195.r * ret.r) * v172.r;
			//                               v173 = v195;
			//                               v175 = v199;
			//                               v177 = v198;
			//                               v179 = v197;
			//                             }
			//                             else
			//                             {
			//                               v173 = *UnityEngine::Light::get_color(&v547, (Light *)v180, 0LL);
			//                               v179 = _mm_shuffle_ps((__m128)v173, (__m128)v173, 255);
			//                               v179.m128_f32[0] = v179.m128_f32[0] * v178.m128_f32[0];
			//                               v177 = _mm_shuffle_ps((__m128)v173, (__m128)v173, 170);
			//                               v177.m128_f32[0] = v177.m128_f32[0] * v176.m128_f32[0];
			//                               v175 = _mm_shuffle_ps((__m128)v173, (__m128)v173, 85);
			//                               v175.m128_f32[0] = v175.m128_f32[0] * v174.m128_f32[0];
			//                               v173.r = v173.r * v172.r;
			//                             }
			//                             v162 = v479;
			//                           }
			//                         }
			//                         v186 = (__m128)0x3F800000u;
			//                         v186.m128_f32[0] = 1.0 - (float)(*((float *)&v496 + 1) * 2.0);
			//                         v474 = v186.m128_f32[0];
			//                         x_low = (__m128)(unsigned int)v496;
			//                         x_low.m128_f32[0] = (float)(*(float *)&v496 * 2.0) - 1.0;
			//                         v475 = x_low.m128_f32[0];
			//                         globalCos0.screenPos.x = x_low.m128_f32[0];
			//                         globalCos0.screenPos.y = v186.m128_f32[0];
			//                         v188 = fabs(x_low.m128_f32[0]);
			//                         v189 = fabs(v186.m128_f32[0]);
			//                         if ( v188 <= v189 )
			//                           v188 = v189;
			//                         radialScreenAttenuationCurve = v162.fields.radialScreenAttenuationCurve;
			//                         if ( !radialScreenAttenuationCurve )
			//                           sub_1802DC2C8(0LL, v181);
			//                         if ( UnityEngine::AnimationCurve::get_length(radialScreenAttenuationCurve, 0LL) <= 0 )
			//                         {
			//                           v194 = 1.0;
			//                         }
			//                         else
			//                         {
			//                           v193 = v162.fields.radialScreenAttenuationCurve;
			//                           if ( !v193 )
			//                             sub_1802DC2C8(0LL, v191);
			//                           v194 = UnityEngine::AnimationCurve::Evaluate(v193, v188, 0LL);
			//                         }
			//                         v205 = param_00046aec.element;
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v192, v191);
			//                         v206 = (float)((float)(param_00046aec.element.fields.m_LocalIntensity * v162.fields.intensity)
			//                                      * v194)
			//                              * v494;
			//                         if ( v206 > 0.0 )
			//                           break;
			//                         v167 = (unsigned int)++v491;
			//                         v166 = v486;
			//                       }
			//                       if ( param_00046aec.element.fields.flareType
			//                         || !param_00046aec.element.fields.preserveAspectRatio )
			//                       {
			//                         v208 = 1.0;
			//                       }
			//                       else
			//                       {
			//                         if ( !param_00046aec.element.fields.lensFlareTexture )
			//                           sub_1802DC2C8(v192, v191);
			//                         v207 = sub_18003ED00(7LL);
			//                         v208 = (float)v207 / (float)(int)sub_18003ED00(5LL);
			//                         v205 = param_00046aec.element;
			//                         v162 = v479;
			//                       }
			//                       globalCos0.usedAspectRatio = v208;
			//                       if ( !v205 )
			//                         sub_1802DC2C8(v192, v191);
			//                       rotation = v205.fields.rotation;
			//                       v209 = v205.fields.sizeXY.x;
			//                       if ( v205.fields.preserveAspectRatio )
			//                       {
			//                         if ( v208 < 1.0 )
			//                         {
			//                           y = v205.fields.sizeXY.y * v208;
			//                           goto LABEL_216;
			//                         }
			//                         v209 = v209 / v208;
			//                       }
			//                       y = v205.fields.sizeXY.y;
			// LABEL_216:
			//                       globalCos0.combinedScale = (float)((float)(v490 * 0.1) * v205.fields.uniformScale)
			//                                                * v162.fields.scale;
			//                       *((float *)&v477 + 1) = globalCos0.combinedScale * y;
			//                       *(float *)&v477 = globalCos0.combinedScale * v209;
			//                       tint = (__m128)v205.fields.tint;
			//                       v179.m128_f32[0] = (float)(v179.m128_f32[0] * _mm_shuffle_ps(tint, tint, 255).m128_f32[0]) * v206;
			//                       v520 = v179;
			//                       v177.m128_f32[0] = (float)(v177.m128_f32[0] * _mm_shuffle_ps(tint, tint, 170).m128_f32[0]) * v206;
			//                       v521 = v177;
			//                       v175.m128_f32[0] = (float)(v175.m128_f32[0] * _mm_shuffle_ps(tint, tint, 85).m128_f32[0]) * v206;
			//                       v522 = v175;
			//                       v173.r = (float)(v173.r * tint.m128_f32[0]) * v206;
			//                       v526 = v173;
			//                       GraphicsUVStartsAtTop = UnityEngine::SystemInfo::GetGraphicsUVStartsAtTop(0LL);
			//                       v215 = param_00046aec.element;
			//                       if ( GraphicsUVStartsAtTop )
			//                       {
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v214, v213);
			//                         angularOffset_low = (__m128)LODWORD(param_00046aec.element.fields.angularOffset);
			//                         v217 = (__m128)0x80000000;
			//                       }
			//                       else
			//                       {
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v214, v213);
			//                         v217 = (__m128)0x80000000;
			//                         angularOffset_low = _mm_xor_ps(
			//                                               (__m128)LODWORD(param_00046aec.element.fields.angularOffset),
			//                                               (__m128)0x80000000);
			//                       }
			//                       v478 = angularOffset_low.m128_f32[0];
			//                       v218 = _mm_xor_ps(angularOffset_low, v217);
			//                       *(double *)v218.m128_u64 = Beyond::DampingMath::cosf();
			//                       v219 = v218;
			//                       LODWORD(globalCos0.globalCos0) = v218.m128_i32[0];
			//                       v220 = _mm_xor_ps(angularOffset_low, v217);
			//                       *(double *)v220.m128_u64 = Beyond::DampingMath::sinf();
			//                       v222 = v220;
			//                       LODWORD(globalCos0.globalSin0) = v220.m128_i32[0];
			//                       v223 = v215.fields.position + v215.fields.position;
			//                       v473 = v223;
			//                       globalCos0.position = v223;
			//                       v492 = 0LL;
			//                       v224 = (Object_1 *)v215.fields.lensFlareTexture;
			//                       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v221);
			//                       v225 = UnityEngine::Object::op_Inequality(v224, 0LL, 0LL);
			//                       v228 = param_00046aec.element;
			//                       if ( v225 )
			//                       {
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v227, v226);
			//                         v229 = param_00046aec.element.fields.lensFlareTexture;
			//                         if ( !v229 )
			//                           sub_1802DC2C8(v227, v226);
			//                         v492 = v229.fields._.m_CachedPtr;
			//                       }
			//                       if ( !param_00046aec.element )
			//                         sub_1802DC2C8(v227, v226);
			//                       Beyond::JobMathf::Clamp01(v227);
			//                       if ( v228.fields.flareType == 2 )
			//                         sub_1802EB1B0((_DWORD)v231, v230);
			//                       m_SdfRoundness = v228.fields.m_SdfRoundness;
			//                       if ( v162.fields.allowOffScreen )
			//                         v233 = 1065353216;
			//                       else
			//                         v233 = -1082130432;
			//                       v234 = 1.0 - v228.fields.m_FallOff;
			//                       Beyond::JobMathf::Clamp01(v231);
			//                       Beyond::JobMathf::ClampedLerp(v235, 4.0, v234);
			//                       *(float *)&v236 = 1.0 / (float)v228.fields.m_SideCount;
			//                       *(_QWORD *)&v499 = __PAIR64__(v237, v233);
			//                       *((_QWORD *)&v499 + 1) = __PAIR64__(v236, COERCE_UNSIGNED_INT(sub_1802EA170()));
			//                       if ( v228.fields.flareType == 2 )
			//                       {
			//                         v240 = 1.0 / (float)v228.fields.m_SideCount;
			//                         v241 = Beyond::DampingMath::cosf();
			//                         v242 = *(float *)&v241 - (float)(m_SdfRoundness * *(float *)&v241);
			//                         v247 = v242 * sub_1802ED290(v244, v243, v245, v246);
			//                         *((float *)&v488 + 1) = v242;
			//                         *((float *)&v488 + 2) = v240 * 6.2831855;
			//                         *((float *)&v488 + 3) = v247;
			//                       }
			//                       else
			//                       {
			//                         *(_QWORD *)((char *)&v488 + 4) = 0LL;
			//                         HIDWORD(v488) = 0;
			//                       }
			//                       *(float *)&v488 = m_SdfRoundness;
			//                       allowMultipleElement = v228.fields.allowMultipleElement;
			//                       m_Count = v228.fields.m_Count;
			//                       v485 = m_Count;
			//                       if ( !allowMultipleElement || m_Count == 1 )
			//                       {
			//                         v432 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                         if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                         {
			//                           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v238);
			//                           v432 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                           v228 = param_00046aec.element;
			//                         }
			//                         LensFlareRayOffset = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v186),
			//                                                v223,
			//                                                v219.m128_f32[0],
			//                                                v222.m128_f32[0],
			//                                                0LL);
			//                         if ( !v228 )
			//                           sub_1802DC2C8(v434, v433);
			//                         if ( v228.fields.enableRadialDistortion )
			//                         {
			//                           if ( !v432._1.cctor_finished_or_no_cctor )
			//                           {
			//                             ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(v432, v433);
			//                             v228 = param_00046aec.element;
			//                           }
			//                           v438 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v186),
			//                                    0.0,
			//                                    v219.m128_f32[0],
			//                                    globalCos0.globalSin0,
			//                                    0LL);
			//                           if ( !v228 )
			//                             sub_1802DC2C8(v437, v436);
			//                           distortionCurve = v228.fields.distortionCurve;
			//                           if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                             ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//                               TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                               v436);
			//                           *(Vector2 *)&ret.r = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
			//                                                  LensFlareRayOffset,
			//                                                  v438,
			//                                                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                                                         (__m128)(unsigned int)v477,
			//                                                                         (__m128)HIDWORD(v477)),
			//                                                  distortionCurve,
			//                                                  &param_00046aec,
			//                                                  &globalCos0,
			//                                                  0LL);
			//                           v477 = *(_QWORD *)&ret.r;
			//                           v432 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                           v228 = param_00046aec.element;
			//                           v440 = globalCos0.position;
			//                           y_low = (__m128)LODWORD(globalCos0.screenPos.y);
			//                           x_low = (__m128)LODWORD(globalCos0.screenPos.x);
			//                         }
			//                         else
			//                         {
			//                           v440 = v473;
			//                           y_low = (__m128)LODWORD(v474);
			//                         }
			//                         if ( !v228 )
			//                           sub_1802DC2C8(v434, v433);
			//                         v442 = (__m128)LODWORD(v228.fields.translationScale.x);
			//                         v443 = (__m128)LODWORD(v228.fields.translationScale.y);
			//                         v444 = (__m128)LODWORD(v228.fields.positionOffset.x);
			//                         v445 = (__m128)LODWORD(v228.fields.positionOffset.y);
			//                         autoRotate = v228.fields.autoRotate;
			//                         if ( !v432._1.cctor_finished_or_no_cctor )
			//                           ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(v432, v433);
			//                         v448 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
			//                                   (Vector4 *)&v534,
			//                                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
			//                                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v442, v443),
			//                                   LensFlareRayOffset,
			//                                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v483), (__m128)0x3F800000u),
			//                                   rotation,
			//                                   v440,
			//                                   v478,
			//                                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v444, v445),
			//                                   autoRotate,
			//                                   0LL);
			//                         *(_QWORD *)&v481 = __PAIR64__(y_low.m128_u32[0], x_low.m128_u32[0]);
			//                         *((_QWORD *)&v481 + 1) = v477;
			//                         *(_QWORD *)&v519 = __PAIR64__(v522.m128_u32[0], LODWORD(v173.r));
			//                         *((_QWORD *)&v519 + 1) = __PAIR64__(v520.m128_u32[0], v521.m128_u32[0]);
			//                         v449 = *v11;
			//                         if ( !&drawDataList[v449] )
			//                           sub_1802DC2C8(v449, v447);
			//                         drawDataList[v449].useOcclusion = (char)drawDataCount;
			//                         v450 = *v11;
			//                         if ( !&drawDataList[v450] )
			//                           sub_1802DC2C8(v450, v447);
			//                         drawDataList[v450].allowMultipleElement = allowMultipleElement;
			//                         v451 = *v11;
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v451, v447);
			//                         inverseSDF = param_00046aec.element.fields.inverseSDF;
			//                         if ( !&drawDataList[v451] )
			//                           sub_1802DC2C8(v451, inverseSDF);
			//                         drawDataList[v451].inverseSDF = inverseSDF;
			//                         v453 = *v11;
			//                         if ( !&drawDataList[v453] )
			//                           sub_1802DC2C8(v453, inverseSDF);
			//                         drawDataList[v453].elementCount = m_Count;
			//                         v454 = *v11;
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v454, inverseSDF);
			//                         blendMode = (unsigned int)param_00046aec.element.fields.blendMode;
			//                         if ( !&drawDataList[v454] )
			//                           sub_1802DC2C8(v454, blendMode);
			//                         drawDataList[v454].blendMode = blendMode;
			//                         v456 = *v11;
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v456, blendMode);
			//                         distribution = (unsigned int)param_00046aec.element.fields.distribution;
			//                         if ( !&drawDataList[v456] )
			//                           sub_1802DC2C8(v456, distribution);
			//                         drawDataList[v456].distribution = distribution;
			//                         v458 = *v11;
			//                         if ( !param_00046aec.element )
			//                           sub_1802DC2C8(v458, distribution);
			//                         flareType = (unsigned int)param_00046aec.element.fields.flareType;
			//                         if ( !&drawDataList[v458] )
			//                           sub_1802DC2C8(v458, flareType);
			//                         drawDataList[v458].flareType = flareType;
			//                         v460 = *v11;
			//                         if ( !&drawDataList[v460] )
			//                           sub_1802DC2C8(v460, flareType);
			//                         ptr = drawDataList[v460].lensFlareCBHandle.ptr;
			//                         *ptr = v448;
			//                         ptr[1] = v498;
			//                         ptr[2] = v481;
			//                         ptr[3] = v499;
			//                         ptr[4] = v488;
			//                         ptr[5] = v500;
			//                         ptr[6] = v519;
			//                         v462 = *v11;
			//                         if ( !&drawDataList[v462] )
			//                           sub_1802DC2C8(v462, flareType);
			//                         drawDataList[v462].flareOcclusionTexture = m_CachedPtr;
			//                         v463 = *v11;
			//                         if ( !&drawDataList[v463] )
			//                           sub_1802DC2C8(v463, flareType);
			//                         drawDataList[v463].flareTexture = v492;
			//                         ++*v11;
			//                       }
			//                       else
			//                       {
			//                         *(float *)&v487 = (float)(v228.fields.lengthSpread + v228.fields.lengthSpread)
			//                                         / (float)(m_Count - 1);
			//                         if ( v228.fields.distribution )
			//                         {
			//                           if ( v228.fields.distribution != 2 )
			//                           {
			//                             if ( v228.fields.distribution == 1 )
			//                             {
			//                               v250 = 0;
			//                               v251 = v499;
			//                               while ( 1 )
			//                               {
			//                                 if ( !v228 )
			//                                   sub_1802DC2C8(v239, v238);
			//                                 if ( v250 >= v228.fields.m_Count )
			//                                   break;
			//                                 if ( v228.fields.m_Count < 2 )
			//                                   v252 = 0.5;
			//                                 else
			//                                   v252 = (float)v250 / (float)(v228.fields.m_Count - 1);
			//                                 colorGradient = v228.fields.colorGradient;
			//                                 if ( !colorGradient )
			//                                   sub_1802DC2C8(0LL, v238);
			//                                 ret = 0LL;
			//                                 UnityEngine::Gradient::Evaluate_Injected(colorGradient, v252, &ret, 0LL);
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v255, v254);
			//                                 positionCurve = param_00046aec.element.fields.positionCurve;
			//                                 if ( !positionCurve )
			//                                   sub_1802DC2C8(0LL, v254);
			//                                 if ( UnityEngine::AnimationCurve::get_length(positionCurve, 0LL) <= 0 )
			//                                 {
			//                                   v260 = 1.0;
			//                                 }
			//                                 else
			//                                 {
			//                                   if ( !param_00046aec.element )
			//                                     sub_1802DC2C8(v258, v257);
			//                                   v259 = param_00046aec.element.fields.positionCurve;
			//                                   if ( !v259 )
			//                                     sub_1802DC2C8(0LL, v257);
			//                                   v260 = UnityEngine::AnimationCurve::Evaluate(v259, v252, 0LL);
			//                                 }
			//                                 v261 = param_00046aec.element;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v258, v257);
			//                                 v262 = (float)((float)(param_00046aec.element.fields.lengthSpread
			//                                                      + param_00046aec.element.fields.lengthSpread)
			//                                              * v260)
			//                                      + v223;
			//                                 v263 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                                 if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                                 {
			//                                   il2cpp_runtime_class_init_0(
			//                                     TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP,
			//                                     v257);
			//                                   v263 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                                   v261 = param_00046aec.element;
			//                                 }
			//                                 v264 = (__m128)LODWORD(v474);
			//                                 v267 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, (__m128)LODWORD(v474)),
			//                                          v262,
			//                                          v219.m128_f32[0],
			//                                          v222.m128_f32[0],
			//                                          0LL);
			//                                 v268 = (__m128)(unsigned int)v477;
			//                                 v269 = (__m128)HIDWORD(v477);
			//                                 if ( !v261 )
			//                                   sub_1802DC2C8(v266, v265);
			//                                 if ( v261.fields.enableRadialDistortion )
			//                                 {
			//                                   if ( !v263._1.cctor_finished_or_no_cctor )
			//                                   {
			//                                     ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(v263, v265);
			//                                     v261 = param_00046aec.element;
			//                                   }
			//                                   v272 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                            (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v475), v264),
			//                                            0.0,
			//                                            globalCos0.globalCos0,
			//                                            v222.m128_f32[0],
			//                                            0LL);
			//                                   if ( !v261 )
			//                                     sub_1802DC2C8(v271, v270);
			//                                   v273 = v261.fields.distortionCurve;
			//                                   if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                                     ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//                                       TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                       v270);
			//                                   v484 = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
			//                                            v267,
			//                                            v272,
			//                                            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v268, v269),
			//                                            v273,
			//                                            &param_00046aec,
			//                                            &globalCos0,
			//                                            0LL);
			//                                   v268.m128_i32[0] = LODWORD(v484.x);
			//                                   v269.m128_i32[0] = LODWORD(v484.y);
			//                                   v261 = param_00046aec.element;
			//                                   v473 = globalCos0.position;
			//                                   v474 = globalCos0.screenPos.y;
			//                                   v475 = globalCos0.screenPos.x;
			//                                 }
			//                                 if ( !v261 )
			//                                   sub_1802DC2C8(v266, v265);
			//                                 scaleCurve = v261.fields.scaleCurve;
			//                                 if ( !scaleCurve )
			//                                   sub_1802DC2C8(0LL, v265);
			//                                 if ( UnityEngine::AnimationCurve::get_length(scaleCurve, 0LL) <= 0 )
			//                                 {
			//                                   v278 = 1.0;
			//                                 }
			//                                 else
			//                                 {
			//                                   if ( !param_00046aec.element )
			//                                     sub_1802DC2C8(v276, v275);
			//                                   v277 = param_00046aec.element.fields.scaleCurve;
			//                                   if ( !v277 )
			//                                     sub_1802DC2C8(0LL, v275);
			//                                   v278 = UnityEngine::AnimationCurve::Evaluate(v277, v252, 0LL);
			//                                 }
			//                                 v279 = v269.m128_f32[0] * v278;
			//                                 v280 = v268.m128_f32[0] * v278;
			//                                 *(float *)&v487 = v280;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v276, v275);
			//                                 uniformAngleCurve = param_00046aec.element.fields.uniformAngleCurve;
			//                                 if ( !uniformAngleCurve )
			//                                   sub_1802DC2C8(0LL, v275);
			//                                 v284 = UnityEngine::AnimationCurve::Evaluate(uniformAngleCurve, v252, 0LL);
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v283, v282);
			//                                 v285 = (float)(180.0 - (float)(180.0 / (float)param_00046aec.element.fields.m_Count))
			//                                      * v284;
			//                                 v286 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.x);
			//                                 v287 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.y);
			//                                 v288 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.x);
			//                                 v289 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.y);
			//                                 v290 = param_00046aec.element.fields.autoRotate;
			//                                 if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                                   il2cpp_runtime_class_init_0(
			//                                     TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP,
			//                                     v282);
			//                                 v469 = v262;
			//                                 param_00046aeda = v285 + rotation;
			//                                 v291 = (__m128)LODWORD(v475);
			//                                 v292 = v474;
			//                                 v294 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
			//                                           &v549,
			//                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                                                  (__m128)LODWORD(v475),
			//                                                                  (__m128)LODWORD(v474)),
			//                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v286, v287),
			//                                           v267,
			//                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                                                  (__m128)LODWORD(v483),
			//                                                                  (__m128)0x3F800000u),
			//                                           param_00046aeda,
			//                                           v469,
			//                                           v478,
			//                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v288, v289),
			//                                           v290,
			//                                           0LL);
			//                                 *(_QWORD *)&v481 = __PAIR64__(LODWORD(v292), v291.m128_u32[0]);
			//                                 *((_QWORD *)&v481 + 1) = __PAIR64__(LODWORD(v279), LODWORD(v280));
			//                                 *(float *)&v523 = v526.r * ret.r;
			//                                 *((float *)&v523 + 1) = v522.m128_f32[0] * ret.g;
			//                                 *((float *)&v523 + 2) = v521.m128_f32[0] * ret.b;
			//                                 *((float *)&v523 + 3) = v520.m128_f32[0] * ret.a;
			//                                 v295 = *v11;
			//                                 if ( !&drawDataList[v295] )
			//                                   sub_1802DC2C8(v295, v293);
			//                                 drawDataList[v295].useOcclusion = (char)drawDataCount;
			//                                 v296 = *v11;
			//                                 if ( !&drawDataList[v296] )
			//                                   sub_1802DC2C8(v296, v293);
			//                                 drawDataList[v296].allowMultipleElement = allowMultipleElement;
			//                                 v297 = *v11;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v297, v293);
			//                                 v298 = param_00046aec.element.fields.inverseSDF;
			//                                 if ( !&drawDataList[v297] )
			//                                   sub_1802DC2C8(v297, v298);
			//                                 drawDataList[v297].inverseSDF = v298;
			//                                 v299 = *v11;
			//                                 if ( !&drawDataList[v299] )
			//                                   sub_1802DC2C8(v299, v298);
			//                                 drawDataList[v299].elementCount = v485;
			//                                 v300 = *v11;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v300, v298);
			//                                 v301 = (unsigned int)param_00046aec.element.fields.blendMode;
			//                                 if ( !&drawDataList[v300] )
			//                                   sub_1802DC2C8(v300, v301);
			//                                 drawDataList[v300].blendMode = v301;
			//                                 v302 = *v11;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v302, v301);
			//                                 v303 = (unsigned int)param_00046aec.element.fields.distribution;
			//                                 if ( !&drawDataList[v302] )
			//                                   sub_1802DC2C8(v302, v303);
			//                                 drawDataList[v302].distribution = v303;
			//                                 v304 = *v11;
			//                                 if ( !param_00046aec.element )
			//                                   sub_1802DC2C8(v304, v303);
			//                                 v238 = (unsigned int)param_00046aec.element.fields.flareType;
			//                                 if ( !&drawDataList[v304] )
			//                                   sub_1802DC2C8(v304, v238);
			//                                 drawDataList[v304].flareType = v238;
			//                                 v305 = *v11;
			//                                 if ( !&drawDataList[v305] )
			//                                   sub_1802DC2C8(v305, v238);
			//                                 v306 = drawDataList[v305].lensFlareCBHandle.ptr;
			//                                 *v306 = v294;
			//                                 v306[1] = v498;
			//                                 v306[2] = v481;
			//                                 v306[3] = v251;
			//                                 v306[4] = v488;
			//                                 v306[5] = v500;
			//                                 v306[6] = v523;
			//                                 v307 = *v11;
			//                                 if ( !&drawDataList[v307] )
			//                                   sub_1802DC2C8(v307, v238);
			//                                 drawDataList[v307].flareOcclusionTexture = m_CachedPtr;
			//                                 v239 = *v11;
			//                                 if ( !&drawDataList[v239] )
			//                                   sub_1802DC2C8(v239, v238);
			//                                 drawDataList[v239].flareTexture = v492;
			//                                 ++*v11;
			//                                 ++v250;
			//                                 v228 = param_00046aec.element;
			//                                 v223 = v473;
			//                                 x_low = v291;
			//                                 v219.m128_i32[0] = LODWORD(globalCos0.globalCos0);
			//                                 v222.m128_i32[0] = LODWORD(globalCos0.globalSin0);
			//                               }
			//                               goto LABEL_344;
			//                             }
			// LABEL_345:
			//                             v167 = (unsigned int)++v491;
			//                             v166 = v486;
			//                             goto LABEL_169;
			//                           }
			//                           value = 0LL;
			//                           v308 = (void (__fastcall *)(Random_State *))qword_18D92F0B0;
			//                           if ( !qword_18D92F0B0 )
			//                           {
			//                             v308 = (void (__fastcall *)(Random_State *))sub_180017470(
			//                                                                           "UnityEngine.Random::get_state_Injected(UnityEn"
			//                                                                           "gine.Random/State&)");
			//                             qword_18D92F0B0 = (__int64)v308;
			//                           }
			//                           v308(&value);
			//                           if ( !param_00046aec.element )
			//                             sub_1802DC2C8(v310, v309);
			//                           UnityEngine::Random::InitState(param_00046aec.element.fields.seed, 0LL);
			//                           v313 = param_00046aec.element;
			//                           if ( !param_00046aec.element )
			//                             sub_1802DC2C8(v312, v311);
			//                           v314 = param_00046aec.element.fields.positionVariation.y;
			//                           v315 = v219;
			//                           v315.m128_f32[0] = v219.m128_f32[0] * v314;
			//                           v316 = v222;
			//                           v316.m128_f32[0] = v222.m128_f32[0] * v314;
			//                           v317 = 0;
			//                           while ( 1 )
			//                           {
			//                             if ( !v313 )
			//                               sub_1802DC2C8(v312, v311);
			//                             if ( v317 >= v313.fields.m_Count )
			//                               break;
			//                             if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(
			//                                 TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                 v311);
			//                             v320 = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
			//                             v321 = param_00046aec.element;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v319, v318);
			//                             v322 = (float)(param_00046aec.element.fields.m_IntensityVariation * v320) + 1.0;
			//                             v323 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                             if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                             {
			//                               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v318);
			//                               v323 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                               v321 = param_00046aec.element;
			//                             }
			//                             globalSin0 = globalCos0.globalSin0;
			//                             v327 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v186),
			//                                      v223,
			//                                      v219.m128_f32[0],
			//                                      globalCos0.globalSin0,
			//                                      0LL);
			//                             v328 = (__m128)(unsigned int)v477;
			//                             v329 = (__m128)HIDWORD(v477);
			//                             if ( !v321 )
			//                               sub_1802DC2C8(v326, v325);
			//                             if ( v321.fields.enableRadialDistortion )
			//                             {
			//                               if ( !v323._1.cctor_finished_or_no_cctor )
			//                               {
			//                                 ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(v323, v325);
			//                                 v321 = param_00046aec.element;
			//                               }
			//                               v332 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v186),
			//                                        0.0,
			//                                        globalCos0.globalCos0,
			//                                        globalSin0,
			//                                        0LL);
			//                               if ( !v321 )
			//                                 sub_1802DC2C8(v331, v330);
			//                               v333 = v321.fields.distortionCurve;
			//                               if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                                 ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//                                   TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                   v330);
			//                               v484 = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
			//                                        v327,
			//                                        v332,
			//                                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v328, v329),
			//                                        v333,
			//                                        &param_00046aec,
			//                                        &globalCos0,
			//                                        0LL);
			//                               v328 = (__m128)LODWORD(v484.x);
			//                               v329 = (__m128)LODWORD(v484.y);
			//                               v321 = param_00046aec.element;
			//                               v473 = globalCos0.position;
			//                               v474 = globalCos0.screenPos.y;
			//                               v475 = globalCos0.screenPos.x;
			//                             }
			//                             if ( !v321 )
			//                               sub_1802DC2C8(v326, v325);
			//                             scaleVariation = v321.fields.scaleVariation;
			//                             if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                               ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//                                 TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                 v325);
			//                             v335 = scaleVariation * UnityEngine::Random::Range(-1.0, 1.0, 0LL);
			//                             v336 = v329;
			//                             v336.m128_f32[0] = v329.m128_f32[0] * v335;
			//                             v337 = v328;
			//                             v337.m128_f32[0] = v328.m128_f32[0] * v335;
			//                             *(Vector2 *)&ret.r = sub_1842BE4B8(
			//                                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v328, v329),
			//                                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v337, v336),
			//                                                    v338,
			//                                                    v339);
			//                             r = ret.r;
			//                             v484 = *(Vector2 *)&ret.r;
			//                             g = ret.g;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v341, v340);
			//                             v344 = param_00046aec.element.fields.colorGradient;
			//                             v347 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
			//                             if ( !v344 )
			//                               sub_1802DC2C8(v346, v345);
			//                             ret = 0LL;
			//                             UnityEngine::Gradient::Evaluate_Injected(v344, v347, &ret, 0LL);
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v349, v348);
			//                             v350 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.x);
			//                             v351 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.y);
			//                             v352 = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
			//                             v353 = v315;
			//                             v353.m128_f32[0] = v315.m128_f32[0] * v352;
			//                             v354 = v316;
			//                             v354.m128_f32[0] = v316.m128_f32[0] * v352;
			//                             v357 = sub_1842BE4B8(
			//                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v350, v351),
			//                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v354, v353),
			//                                      v355,
			//                                      v356);
			//                             v360 = UnityEngine::Random::Range(-3.1415927, 3.1415927, 0LL);
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v359, v358);
			//                             v361 = (float)(param_00046aec.element.fields.rotationVariation * v360) + rotation;
			//                             if ( v322 <= 0.0 )
			//                             {
			//                               v365 = v473;
			//                             }
			//                             else
			//                             {
			//                               v362 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.x);
			//                               v363 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.y);
			//                               v364 = param_00046aec.element.fields.autoRotate;
			//                               if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v358);
			//                               v470 = v357;
			//                               v365 = v473;
			//                               param_00046aedb = v361;
			//                               v366 = (Vector2)_mm_unpacklo_ps(v362, v363).m128_u64[0];
			//                               v367 = v475;
			//                               v368 = v474;
			//                               v370 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
			//                                         &v550,
			//                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                                                (__m128)LODWORD(v475),
			//                                                                (__m128)LODWORD(v474)),
			//                                         v366,
			//                                         v327,
			//                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v483), (__m128)0x3F800000u),
			//                                         param_00046aedb,
			//                                         v473,
			//                                         v478,
			//                                         v470,
			//                                         v364,
			//                                         0LL);
			//                               *(_QWORD *)&v481 = __PAIR64__(LODWORD(v368), LODWORD(v367));
			//                               *((_QWORD *)&v481 + 1) = __PAIR64__(LODWORD(g), LODWORD(r));
			//                               *(float *)&v524 = (float)(v526.r * ret.r) * v322;
			//                               *((float *)&v524 + 1) = (float)(v522.m128_f32[0] * ret.g) * v322;
			//                               *((float *)&v524 + 2) = (float)(v521.m128_f32[0] * ret.b) * v322;
			//                               *((float *)&v524 + 3) = (float)(v520.m128_f32[0] * ret.a) * v322;
			//                               v371 = *v11;
			//                               if ( !&drawDataList[v371] )
			//                                 sub_1802DC2C8(v371, v369);
			//                               drawDataList[v371].useOcclusion = (char)drawDataCount;
			//                               v372 = *v11;
			//                               if ( !&drawDataList[v372] )
			//                                 sub_1802DC2C8(v372, v369);
			//                               drawDataList[v372].allowMultipleElement = allowMultipleElement;
			//                               v373 = *v11;
			//                               if ( !param_00046aec.element )
			//                                 sub_1802DC2C8(v373, v369);
			//                               v374 = param_00046aec.element.fields.inverseSDF;
			//                               if ( !&drawDataList[v373] )
			//                                 sub_1802DC2C8(v373, v374);
			//                               drawDataList[v373].inverseSDF = v374;
			//                               v375 = *v11;
			//                               if ( !&drawDataList[v375] )
			//                                 sub_1802DC2C8(v375, v374);
			//                               drawDataList[v375].elementCount = v485;
			//                               v376 = *v11;
			//                               if ( !param_00046aec.element )
			//                                 sub_1802DC2C8(v376, v374);
			//                               v377 = (unsigned int)param_00046aec.element.fields.blendMode;
			//                               if ( !&drawDataList[v376] )
			//                                 sub_1802DC2C8(v376, v377);
			//                               drawDataList[v376].blendMode = v377;
			//                               v378 = *v11;
			//                               if ( !param_00046aec.element )
			//                                 sub_1802DC2C8(v378, v377);
			//                               v379 = (unsigned int)param_00046aec.element.fields.distribution;
			//                               if ( !&drawDataList[v378] )
			//                                 sub_1802DC2C8(v378, v379);
			//                               drawDataList[v378].distribution = v379;
			//                               v380 = *v11;
			//                               if ( !param_00046aec.element )
			//                                 sub_1802DC2C8(v380, v379);
			//                               v358 = (unsigned int)param_00046aec.element.fields.flareType;
			//                               if ( !&drawDataList[v380] )
			//                                 sub_1802DC2C8(v380, v358);
			//                               drawDataList[v380].flareType = v358;
			//                               v381 = *v11;
			//                               if ( !&drawDataList[v381] )
			//                                 sub_1802DC2C8(v381, v358);
			//                               v382 = drawDataList[v381].lensFlareCBHandle.ptr;
			//                               *v382 = v370;
			//                               v382[1] = v498;
			//                               v382[2] = v481;
			//                               v382[3] = v499;
			//                               v382[4] = v488;
			//                               v382[5] = v500;
			//                               v382[6] = v524;
			//                               v383 = *v11;
			//                               if ( !&drawDataList[v383] )
			//                                 sub_1802DC2C8(v383, v358);
			//                               drawDataList[v383].flareOcclusionTexture = m_CachedPtr;
			//                               v384 = *v11;
			//                               if ( !&drawDataList[v384] )
			//                                 sub_1802DC2C8(v384, v358);
			//                               drawDataList[v384].flareTexture = v492;
			//                               ++*v11;
			//                             }
			//                             v385 = *(float *)&v487;
			//                             v386 = v365 + *(float *)&v487;
			//                             if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(
			//                                 TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                 v358);
			//                             v387 = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
			//                             v313 = param_00046aec.element;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v312, v311);
			//                             v223 = v386
			//                                  + (float)((float)((float)(v385 * 0.5) * v387)
			//                                          * param_00046aec.element.fields.positionVariation.x);
			//                             v473 = v223;
			//                             globalCos0.position = v223;
			//                             ++v317;
			//                             x_low = (__m128)LODWORD(v475);
			//                             v186 = (__m128)LODWORD(v474);
			//                             v219.m128_i32[0] = LODWORD(globalCos0.globalCos0);
			//                           }
			//                           UnityEngine::Random::set_state_Injected(&value, 0LL);
			//                         }
			//                         else
			//                         {
			//                           v388 = 0.0;
			//                           v389 = 0;
			//                           v390 = v499;
			//                           v391 = v488;
			//                           v392 = (__m128)LODWORD(v474);
			//                           while ( 1 )
			//                           {
			//                             if ( !v228 )
			//                               sub_1802DC2C8(v239, v238);
			//                             if ( v389 >= v228.fields.m_Count )
			//                               break;
			//                             v393 = (__m128)(unsigned int)v477;
			//                             v394 = (__m128)HIDWORD(v477);
			//                             v395 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                             if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                             {
			//                               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v238);
			//                               v395 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
			//                               v228 = param_00046aec.element;
			//                             }
			//                             v396 = globalCos0.globalSin0;
			//                             v397 = globalCos0.globalCos0;
			//                             v400 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v392),
			//                                      v223,
			//                                      globalCos0.globalCos0,
			//                                      globalCos0.globalSin0,
			//                                      0LL);
			//                             if ( !v228 )
			//                               sub_1802DC2C8(v399, v398);
			//                             if ( v228.fields.enableRadialDistortion )
			//                             {
			//                               if ( !v395._1.cctor_finished_or_no_cctor )
			//                               {
			//                                 ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(v395, v398);
			//                                 v228 = param_00046aec.element;
			//                               }
			//                               v403 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
			//                                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v475), v392),
			//                                        0.0,
			//                                        v397,
			//                                        v396,
			//                                        0LL);
			//                               if ( !v228 )
			//                                 sub_1802DC2C8(v402, v401);
			//                               v404 = v228.fields.distortionCurve;
			//                               if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor._1.cctor_finished_or_no_cctor )
			//                                 ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
			//                                   TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor,
			//                                   v401);
			//                               *(Vector2 *)&ret.r = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
			//                                                      v400,
			//                                                      v403,
			//                                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v393, v394),
			//                                                      v404,
			//                                                      &param_00046aec,
			//                                                      &globalCos0,
			//                                                      0LL);
			//                               v393.m128_i32[0] = LODWORD(ret.r);
			//                               v394.m128_i32[0] = LODWORD(ret.g);
			//                               v228 = param_00046aec.element;
			//                               v473 = globalCos0.position;
			//                               v474 = globalCos0.screenPos.y;
			//                               v475 = globalCos0.screenPos.x;
			//                             }
			//                             if ( !v228 )
			//                               sub_1802DC2C8(v399, v398);
			//                             if ( v228.fields.m_Count < 2 )
			//                               v405 = 0.5;
			//                             else
			//                               v405 = (float)v389 / (float)(v228.fields.m_Count - 1);
			//                             v406 = v228.fields.colorGradient;
			//                             if ( !v406 )
			//                               sub_1802DC2C8(0LL, v398);
			//                             ret = 0LL;
			//                             UnityEngine::Gradient::Evaluate_Injected(v406, v405, &ret, 0LL);
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v408, v407);
			//                             v409 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.x);
			//                             v410 = (__m128)LODWORD(param_00046aec.element.fields.translationScale.y);
			//                             v411 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.x);
			//                             v412 = (__m128)LODWORD(param_00046aec.element.fields.positionOffset.y);
			//                             v413 = param_00046aec.element.fields.autoRotate;
			//                             if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP, v407);
			//                             v471 = (Vector2)_mm_unpacklo_ps(v411, v412).m128_u64[0];
			//                             v414 = v473;
			//                             v415 = v400;
			//                             v416 = (Vector2)_mm_unpacklo_ps(v409, v410).m128_u64[0];
			//                             x_low = (__m128)LODWORD(v475);
			//                             v392 = (__m128)LODWORD(v474);
			//                             v418 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
			//                                       &v551,
			//                                       (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v475), (__m128)LODWORD(v474)),
			//                                       v416,
			//                                       v415,
			//                                       (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v483), (__m128)0x3F800000u),
			//                                       v388 + rotation,
			//                                       v473,
			//                                       v478,
			//                                       v471,
			//                                       v413,
			//                                       0LL);
			//                             *(_QWORD *)&v481 = __PAIR64__(v392.m128_u32[0], x_low.m128_u32[0]);
			//                             *((_QWORD *)&v481 + 1) = __PAIR64__(v394.m128_u32[0], v393.m128_u32[0]);
			//                             *(float *)&v514 = v526.r * ret.r;
			//                             *((float *)&v514 + 1) = v522.m128_f32[0] * ret.g;
			//                             *((float *)&v514 + 2) = v521.m128_f32[0] * ret.b;
			//                             *((float *)&v514 + 3) = v520.m128_f32[0] * ret.a;
			//                             v419 = *v11;
			//                             if ( !&drawDataList[v419] )
			//                               sub_1802DC2C8(v419, v417);
			//                             drawDataList[v419].useOcclusion = (char)drawDataCount;
			//                             v420 = *v11;
			//                             if ( !&drawDataList[v420] )
			//                               sub_1802DC2C8(v420, v417);
			//                             drawDataList[v420].allowMultipleElement = allowMultipleElement;
			//                             v421 = *v11;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v421, v417);
			//                             v422 = param_00046aec.element.fields.inverseSDF;
			//                             if ( !&drawDataList[v421] )
			//                               sub_1802DC2C8(v421, v422);
			//                             drawDataList[v421].inverseSDF = v422;
			//                             v423 = *v11;
			//                             if ( !&drawDataList[v423] )
			//                               sub_1802DC2C8(v423, v422);
			//                             drawDataList[v423].elementCount = v485;
			//                             v424 = *v11;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v424, v422);
			//                             v425 = (unsigned int)param_00046aec.element.fields.blendMode;
			//                             if ( !&drawDataList[v424] )
			//                               sub_1802DC2C8(v424, v425);
			//                             drawDataList[v424].blendMode = v425;
			//                             v426 = *v11;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v426, v425);
			//                             v427 = (unsigned int)param_00046aec.element.fields.distribution;
			//                             if ( !&drawDataList[v426] )
			//                               sub_1802DC2C8(v426, v427);
			//                             drawDataList[v426].distribution = v427;
			//                             v428 = *v11;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v428, v427);
			//                             v238 = (unsigned int)param_00046aec.element.fields.flareType;
			//                             if ( !&drawDataList[v428] )
			//                               sub_1802DC2C8(v428, v238);
			//                             drawDataList[v428].flareType = v238;
			//                             v429 = *v11;
			//                             if ( !&drawDataList[v429] )
			//                               sub_1802DC2C8(v429, v238);
			//                             v430 = drawDataList[v429].lensFlareCBHandle.ptr;
			//                             *v430 = v418;
			//                             v430[1] = v498;
			//                             v430[2] = v481;
			//                             v430[3] = v390;
			//                             v430[4] = v391;
			//                             v430[5] = v500;
			//                             v430[6] = v514;
			//                             v431 = *v11;
			//                             if ( !&drawDataList[v431] )
			//                               sub_1802DC2C8(v431, v238);
			//                             drawDataList[v431].flareOcclusionTexture = m_CachedPtr;
			//                             v239 = *v11;
			//                             if ( !&drawDataList[v239] )
			//                               sub_1802DC2C8(v239, v238);
			//                             drawDataList[v239].flareTexture = v492;
			//                             ++*v11;
			//                             v223 = v414 + *(float *)&v487;
			//                             v473 = v223;
			//                             globalCos0.position = v223;
			//                             v228 = param_00046aec.element;
			//                             if ( !param_00046aec.element )
			//                               sub_1802DC2C8(v239, v238);
			//                             v388 = v388 + param_00046aec.element.fields.uniformAngle;
			//                             ++v389;
			//                           }
			//                         }
			//                       }
			// LABEL_344:
			//                       v162 = v479;
			//                       goto LABEL_345;
			//                     }
			//                   }
			//                   v490 = 1.0;
			//                   goto LABEL_135;
			//                 }
			// LABEL_23:
			//                 v30 = v518;
			//               }
			//             }
			//           }
			//         }
			//       }
			//       v77 = UnityEngine::Component::get_transform((Component *)current, 0LL);
			//       if ( !v77 )
			//         sub_1802DC2C8(v79, v78);
			//       v80 = UnityEngine::Transform::get_position(&v545, v77, 0LL);
			//       v71.m128_u64[0] = *(_QWORD *)&v80.x;
			//       v512 = *(_QWORD *)&v80.x;
			//       v76 = v80.z;
			//       goto LABEL_113;
			//     }
			//     catch ( Il2CppExceptionWrapper *v535 )
			//     {
			//       ex = v535.ex;
			//       mono_thread_suspend_all_other_threads(
			//         v517,
			//         MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return;
			//     }
			// LABEL_555:
			//     mono_thread_suspend_all_other_threads(
			//       &v533,
			//       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
			//   }
			// }
			// 
		}

		private void Prepare(LensFlarePassConstructor.LensFlareDataDrivenData passData, HGRenderGraphBuilder builder, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void Prepare(LensFlarePassConstructor+LensFlareDataDrivenData, HGRenderGraphBuilder, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::LensFlarePassConstructor::Prepare(
			//         LensFlarePassConstructor *this,
			//         LensFlarePassConstructor_LensFlareDataDrivenData *passData,
			//         HGRenderGraphBuilder *builder,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *static_fields; // rcx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   Camera *camera; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   __m128i v21; // xmm0
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // ecx
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   Matrix4x4 *projectionMatrix; // rax
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v34; // xmm6
			//   __int128 v35; // xmm7
			//   __int128 v36; // xmm8
			//   __int128 v37; // xmm9
			//   Matrix4x4 *v38; // rax
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm2
			//   __int128 v41; // xmm3
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rsi
			//   HGLensFlareConfig *m_interpolatedPhase; // rsi
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *v44; // rax
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm2
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   PassConstructorID__Enum__Array *v50; // r8
			//   HGEnvironmentVolumeCameraComponent *v51; // r9
			//   Component *SunSourceLight; // rax
			//   GameObject *gameObject; // rax
			//   HGEnvironmentVolumeCameraComponent *v54; // r9
			//   HGEnvironmentPhase *v55; // rdi
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLightData *v56; // rax
			//   float a; // ecx
			//   __int128 v58; // xmm2
			//   __int64 v59; // xmm0_8
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   __int128 v62; // xmm1
			//   MethodInfo *v63; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v64; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v65; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v66; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v67; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v68; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v69; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v70; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v71; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v72; // [rsp+30h] [rbp-D8h]
			//   Matrix4x4 v73; // [rsp+48h] [rbp-C0h] BYREF
			//   Matrix4x4 v74; // [rsp+88h] [rbp-80h] BYREF
			//   Matrix4x4 v75[2]; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D91957E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     byte_18D91957E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2700, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( passData )
			//       {
			//         passData.fields.lensFlareDataDrivenMaterial = this.fields.m_lensFlareDataDrivenMaterial;
			//         sub_1800054D0((HGRenderPathScene *)&passData.fields, v10, v12, v13, v63, v68);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//         passData.fields.lensFlares = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
			//         sub_1800054D0((HGRenderPathScene *)&passData.fields.lensFlares, v15, v16, v17, v64, v69);
			//         passData.fields.camera = camera;
			//         sub_1800054D0((HGRenderPathScene *)&passData.fields.camera, v18, v19, v20, v65, v70);
			//         passData.fields.actualWidth = (float)hgCamera.fields._sceneRTSize_k__BackingField.m_X;
			//         *(Vector2Int *)&v73.m00 = hgCamera.fields._sceneRTSize_k__BackingField;
			//         v21 = _mm_cvtsi32_si128(LODWORD(v73.m10));
			//         passData.fields.usePanini = 0;
			//         passData.fields.paniniDistance = 1.0;
			//         passData.fields.paniniCropToFit = 1.0;
			//         LODWORD(passData.fields.actualHeight) = _mm_cvtepi32_ps(v21).m128_u32[0];
			//         if ( camera )
			//         {
			//           transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//           if ( transform )
			//           {
			//             position = UnityEngine::Transform::get_position((Vector3 *)&v73, transform, 0LL);
			//             z = position.z;
			//             *(_QWORD *)&passData.fields.cameraPositionWS.x = *(_QWORD *)&position.x;
			//             passData.fields.cameraPositionWS.z = z;
			//             worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v73, camera, 0LL);
			//             v26 = *(_OWORD *)&worldToCameraMatrix.m01;
			//             *(_OWORD *)&v74.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
			//             v27 = *(_OWORD *)&worldToCameraMatrix.m02;
			//             *(_OWORD *)&v74.m01 = v26;
			//             v28 = *(_OWORD *)&worldToCameraMatrix.m03;
			//             *(_OWORD *)&v74.m02 = v27;
			//             *(_OWORD *)&v74.m03 = v28;
			//             projectionMatrix = UnityEngine::Camera::get_projectionMatrix(v75, camera, 0LL);
			//             v30 = *(_OWORD *)&projectionMatrix.m01;
			//             *(_OWORD *)&v73.m00 = *(_OWORD *)&projectionMatrix.m00;
			//             v31 = *(_OWORD *)&projectionMatrix.m02;
			//             *(_OWORD *)&v73.m01 = v30;
			//             v32 = *(_OWORD *)&projectionMatrix.m03;
			//             *(_OWORD *)&v73.m02 = v31;
			//             *(_OWORD *)&v73.m03 = v32;
			//             GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v75, &v73, 1, 0LL);
			//             v34 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//             v35 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//             v36 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//             v37 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//             *(__m128i *)&v73.m00 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//             UnityEngine::Matrix4x4::SetColumn(&v74, 3, (Vector4 *)&v73, 0LL);
			//             v73 = v74;
			//             *(_OWORD *)&v74.m00 = v34;
			//             *(_OWORD *)&v74.m01 = v35;
			//             *(_OWORD *)&v74.m02 = v36;
			//             *(_OWORD *)&v74.m03 = v37;
			//             v38 = UnityEngine::Matrix4x4::op_Multiply(v75, &v74, &v73, 0LL);
			//             v39 = *(_OWORD *)&v38.m01;
			//             v40 = *(_OWORD *)&v38.m02;
			//             v41 = *(_OWORD *)&v38.m03;
			//             *(_OWORD *)&passData.fields.gpuVP.m00 = *(_OWORD *)&v38.m00;
			//             *(_OWORD *)&passData.fields.gpuVP.m01 = v39;
			//             *(_OWORD *)&passData.fields.gpuVP.m02 = v40;
			//             *(_OWORD *)&passData.fields.gpuVP.m03 = v41;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             passData.fields.flareOcclusionTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareOcclusionTex;
			//             passData.fields.flareOcclusionIndex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareOcclusionIndex;
			//             passData.fields.flareTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareTex;
			//             passData.fields.flareColorValue = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareColorValue;
			//             passData.fields.flareData0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareData0;
			//             passData.fields.flareData1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareData1;
			//             passData.fields.flareData2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareData2;
			//             passData.fields.flareData3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FlareData3;
			//             static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             passData.fields.flareData4 = (int32_t)static_fields[62].monitor;
			//             m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//             if ( m_envVolumeCameraComponent )
			//             {
			//               m_interpolatedPhase = (HGLensFlareConfig *)m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//               if ( m_interpolatedPhase )
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//                 v44 = HG::Rendering::Runtime::HGLensFlareConfig::ToDirLightOverrideData(
			//                         (LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *)&v73,
			//                         m_interpolatedPhase + 55,
			//                         0LL);
			//                 v45 = *(_OWORD *)&v44.intensity;
			//                 v46 = *(_OWORD *)&v44.sampleCount;
			//                 *(_OWORD *)&passData.fields.dirLightOverrideInfo.flareData.enable = *(_OWORD *)&v44.enable;
			//                 *(_OWORD *)&passData.fields.dirLightOverrideInfo.flareData.intensity = v45;
			//                 *(_OWORD *)&passData.fields.dirLightOverrideInfo.flareData.sampleCount = v46;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&passData.fields.dirLightOverrideInfo.flareData.lensFlareData,
			//                   v47,
			//                   v48,
			//                   v49,
			//                   v66,
			//                   v71);
			//                 v51 = hgCamera.fields.m_envVolumeCameraComponent;
			//                 if ( v51 )
			//                 {
			//                   if ( v51.fields.m_useEnvVolumeInterpolatedPhase
			//                     && (SunSourceLight = (Component *)UnityEngine::Light::GetSunSourceLight(0LL)) != 0LL )
			//                   {
			//                     gameObject = UnityEngine::Component::get_gameObject(SunSourceLight, 0LL);
			//                   }
			//                   else
			//                   {
			//                     gameObject = 0LL;
			//                   }
			//                   passData.fields.dirLightOverrideInfo.dirLightGameObject = gameObject;
			//                   sub_1800054D0(
			//                     (HGRenderPathScene *)&passData.fields.dirLightOverrideInfo,
			//                     v10,
			//                     v50,
			//                     (HGCamera *)v51,
			//                     v67,
			//                     v72);
			//                   v54 = hgCamera.fields.m_envVolumeCameraComponent;
			//                   if ( v54 )
			//                   {
			//                     v55 = v54.fields.m_interpolatedPhase;
			//                     if ( v55 )
			//                     {
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//                       v56 = HG::Rendering::Runtime::HGLightConfig::ToDirLightOverrideData(
			//                               (LensFlareCommonSRP_SunSourceDirLightOverrideLightData *)&v73,
			//                               &v55.fields.lightConfig,
			//                               0LL);
			//                       a = v56.color.a;
			//                       v58 = *(_OWORD *)&v56.dirLightFoward.x;
			//                       v59 = *(_QWORD *)&v56.color.g;
			//                       passData.fields.dirLightOverrideInfo.lightData.rotationLensFlare = v56.rotationLensFlare;
			//                       *(_OWORD *)&passData.fields.dirLightOverrideInfo.lightData.dirLightFoward.x = v58;
			//                       *(_QWORD *)&passData.fields.dirLightOverrideInfo.lightData.color.g = v59;
			//                       passData.fields.dirLightOverrideInfo.lightData.color.a = a;
			//                       passData.fields.debugFullscreen = 0;
			//                       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//                       passData.fields.debugFullscreenBuffer = (ComputeBufferHandle)sub_182E10C50(v61, v60);
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(static_fields, v10);
			//   }
			//   static_fields = IFix::WrappersManagerImpl::GetPatch(2700, 0LL);
			//   if ( !static_fields )
			//     goto LABEL_19;
			//   v62 = *(_OWORD *)&builder.m_RenderGraph;
			//   *(_OWORD *)&v73.m00 = *(_OWORD *)&builder.m_RenderPass;
			//   *(_OWORD *)&v73.m01 = v62;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_987(
			//     static_fields,
			//     (Object *)this,
			//     (Object *)passData,
			//     (HGRenderGraphBuilder *)&v73,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         LensFlarePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2701, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2701, 0LL);
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
			// void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         LensFlarePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2702, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2702, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref LensFlarePassConstructor.PassInput input, ref LensFlarePassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(LensFlarePassConstructor+PassInput ByRef, LensFlarePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::LensFlarePassConstructor::ConstructPass(
			//         LensFlarePassConstructor *this,
			//         LensFlarePassConstructor_PassInput *input,
			//         LensFlarePassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   LensFlareCommonSRP *Instance; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ProfilingSampler *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   LensFlarePassConstructor_LensFlareDataDrivenData *v23; // [rsp+50h] [rbp-88h] BYREF
			//   _QWORD v24[3]; // [rsp+58h] [rbp-80h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+70h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v26; // [rsp+90h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v27; // [rsp+B0h] [rbp-28h] BYREF
			//   __m128i si128; // [rsp+C0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91957F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500F10);
			//     byte_18D91957F = 1;
			//   }
			//   v23 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2703, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2703, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, v21);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_988(
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
			//     if ( !camera )
			//       sub_180B536AC(v11, v10);
			//     *(BitArray128 *)&v25.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     v25.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v25,
			//            FrameSettingsField__Enum_Postprocess,
			//            0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       if ( !camera.fields.camera )
			//         sub_180B536AC(v13, v12);
			//       if ( UnityEngine::Camera::get_cameraType(camera.fields.camera, 0LL) != CameraType__Enum_Preview )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//         Instance = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
			//         if ( !Instance )
			//           sub_180B536AC(v16, v15);
			//         if ( !UnityEngine::Rendering::LensFlareCommonSRP::IsEmpty(Instance, 0LL) )
			//         {
			//           v17 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                   (Int32Enum__Enum)0x93u,
			//                   MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           if ( !renderGraph )
			//             sub_180B536AC(v19, v18);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &v25,
			//             renderGraph,
			//             (String *)"LensFlareDataDriven",
			//             (Object **)&v23,
			//             v17,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
			//           v26 = v25;
			//           v24[0] = 0LL;
			//           v24[1] = &v26;
			//           try
			//           {
			//             v25 = v26;
			//             HG::Rendering::Runtime::LensFlarePassConstructor::Prepare(this, v23, &v25, renderGraph, camera, 0LL);
			//             si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               (TextureHandle *)&v25,
			//               &v26,
			//               &input.sceneColor,
			//               0,
			//               RenderBufferLoadAction__Enum_Load,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&si128,
			//               0,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//               &v26,
			//               (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor.static_fields.s_lensFlareDataDrivenRenderFunc,
			//               0LL,
			//               0,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
			//           }
			//           catch ( Il2CppExceptionWrapper *v27 )
			//           {
			//             v24[0] = v27.ex;
			//           }
			//           sub_180222690(v24);
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         LensFlarePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2704, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2704, 0LL);
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
			// void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         LensFlarePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2705, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2705, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::LensFlarePassConstructor::Release(this, 0LL);
			//   }
			// }
			// 
		}

		[CompilerGenerated]
		internal static Vector2 <PrepareHGLensFlareDrawNode>g__ComputeLocalSize|9_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref LensFlarePassConstructor.<>c__DisplayClass9_0 param_00046aec, ref LensFlarePassConstructor.<>c__DisplayClass9_1 param_00046aed)
		{
			// // Vector2 <PrepareHGLensFlareDrawNode>g__ComputeLocalSize|9_0(Vector2, Vector2, Vector2, AnimationCurve, LensFlarePassConstructor+<>c__DisplayClass9_0 ByRef, LensFlarePassConstructor+<>c__DisplayClass9_1 ByRef)
			// Vector2 HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
			//         Vector2 rayOff,
			//         Vector2 rayOff0,
			//         Vector2 curSize,
			//         AnimationCurve *distortionCurve,
			//         LensFlarePassConstructor_c_DisplayClass9_0 *param_00046aec,
			//         LensFlarePassConstructor_c_DisplayClass9_1 *param_00046aed,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   Beyond::JobMathf *v11; // rcx
			//   Vector2 v12; // r8
			//   Vector2 v13; // r9
			//   LensFlareDataElementSRP *element; // rax
			//   LensFlarePassConstructor_c_DisplayClass9_1 *v15; // rsi
			//   Vector2 v16; // xmm2_8
			//   Vector2 v17; // rax
			//   Vector2 v18; // r8
			//   Vector2 v19; // r9
			//   Beyond::JobMathf *v20; // rcx
			//   double v21; // xmm0_8
			//   __int64 v22; // rax
			//   __int64 v23; // rax
			//   float v24; // xmm0_4
			//   Beyond::JobMathf *v25; // rcx
			//   __int64 v26; // rax
			//   __m128 v27; // xmm0
			//   Beyond::JobMathf *v28; // rcx
			//   float v29; // xmm5_4
			//   __m128 v30; // xmm4
			//   float y; // [rsp+24h] [rbp-34h]
			// 
			//   y = curSize.y;
			//   if ( !byte_18D919580 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//     byte_18D919580 = 1;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
			//   element = param_00046aec.element;
			//   if ( !param_00046aec.element )
			//     goto LABEL_12;
			//   v15 = param_00046aed;
			//   if ( !element.fields.distortionRelativeToCenter )
			//   {
			//     v22 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(rayOff, rayOff0);
			//     v23 = sub_182C9F010(v22);
			//     *(float *)&v21 = fmaxf(fabs(*(float *)&v23), fabs(*((float *)&v23 + 1)));
			//     goto LABEL_9;
			//   }
			//   if ( !element
			//     || (v16 = sub_1842BE4B8(
			//                 rayOff,
			//                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                        (__m128)LODWORD(element.fields.positionOffset.x),
			//                                        _mm_xor_ps(
			//                                          (__m128)LODWORD(element.fields.positionOffset.y),
			//                                          (__m128)xmmword_18A3571B0)),
			//                 v12,
			//                 v13),
			//         !param_00046aec.element) )
			//   {
			// LABEL_12:
			//     sub_180B536AC(v11, v10);
			//   }
			//   v17 = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_184D038DC)(
			//                    v16,
			//                    _mm_unpacklo_ps(
			//                      (__m128)LODWORD(param_00046aec.element.fields.translationScale.x),
			//                      (__m128)LODWORD(param_00046aec.element.fields.translationScale.y)).m128_u64[0]);
			//   param_00046aed = (LensFlarePassConstructor_c_DisplayClass9_1 *)sub_1842BE4B8(v15.screenPos, v17, v18, v19);
			//   v21 = sub_182413570(&param_00046aed);
			// LABEL_9:
			//   Beyond::JobMathf::Clamp01(v20);
			//   if ( !distortionCurve )
			//     goto LABEL_12;
			//   v24 = UnityEngine::AnimationCurve::Evaluate(distortionCurve, *(float *)&v21, 0LL);
			//   Beyond::JobMathf::Clamp01(v25);
			//   if ( !param_00046aec.element )
			//     goto LABEL_12;
			//   Beyond::JobMathf::ClampedLerp(
			//     v11,
			//     (float)(param_00046aec.element.fields.targetSizeDistortion.x * v15.combinedScale) / v15.usedAspectRatio,
			//     v24);
			//   v27 = (__m128)LODWORD(y);
			//   *(double *)v27.m128_u64 = Beyond::JobMathf::ClampedLerp(v28, *(float *)(v26 + 188) * v15.combinedScale, v29);
			//   return (Vector2)_mm_unpacklo_ps(v30, v27).m128_u64[0];
			// }
			// 
			return null;
		}

		[CompilerGenerated]
		internal static float <PrepareHGLensFlareDrawNode>g__RandomRange|9_1(float min, float max)
		{
			// // Single <DoLensFlareDataDrivenCommon>g__RandomRange|35_1(Single, Single)
			// float UnityEngine::Rendering::LensFlareCommonSRP::_DoLensFlareDataDrivenCommon_g__RandomRange_35_1(
			//         float min,
			//         float max,
			//         MethodInfo *method)
			// {
			//   return UnityEngine::Random::Range(min, max, 0LL);
			// }
			// 
			return 0f;
		}

		private Material m_lensFlareDataDrivenMaterial;

		public const int LENS_FLARE_CB_VECTOR4_COUNT = 7;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<LensFlarePassConstructor.LensFlareDataDrivenData> s_lensFlareDataDrivenRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal ComputeBufferHandle debugFullscreenBuffer;
		}

		internal struct PassOutput
		{
		}

		private class LensFlareDataDrivenData
		{
			public LensFlareDataDrivenData()
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

			public Material lensFlareDataDrivenMaterial;

			public LensFlareCommonSRP lensFlares;

			public Camera camera;

			public bool debugFullscreen;

			public ComputeBufferHandle debugFullscreenBuffer;

			public float actualWidth;

			public float actualHeight;

			public bool usePanini;

			public float paniniDistance;

			public float paniniCropToFit;

			public Vector3 cameraPositionWS;

			public Matrix4x4 gpuVP;

			public int flareOcclusionTex;

			public int flareOcclusionIndex;

			public int flareTex;

			public int flareColorValue;

			public int flareData0;

			public int flareData1;

			public int flareData2;

			public int flareData3;

			public int flareData4;

			public TextureHandle source;

			public LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo;
		}
	}
}
