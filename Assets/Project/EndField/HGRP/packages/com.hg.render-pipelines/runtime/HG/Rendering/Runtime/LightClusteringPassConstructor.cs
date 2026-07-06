using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class LightClusteringPassConstructor : IDisposable, IPassConstructor
	{
		public LightClusteringPassConstructor()
		{
			// // LightClusteringPassConstructor()
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::LightClusteringPassConstructor(
			//         LightClusteringPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ v3; // xmm0
			//   NativeArray_1_System_Single_ v4; // xmm0
			//   LightCullingGPU *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   LightCulling *v8; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ v12; // [rsp+30h] [rbp-18h] BYREF
			//   MethodInfo *v13; // [rsp+70h] [rbp+28h]
			//   MethodInfo *v14; // [rsp+78h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDCED )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCullingGPU);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     byte_18D8EDCED = 1;
			//   }
			//   v12 = 0LL;
			//   Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::NativeArray(
			//     &v12,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::NativeArray);
			//   v3 = v12;
			//   this.fields.m_directionalLightIndex = -1;
			//   this.fields.m_punctualLightSortArray = v3;
			//   v12 = 0LL;
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     (NativeArray_1_System_Int32_ *)&v12,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   this.fields.m_punctualLightIndices = (NativeArray_1_System_Int32_)v12;
			//   v12 = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v12,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   v4 = (NativeArray_1_System_Single_)v12;
			//   this.fields.m_punctualLightCount = 0;
			//   this.fields.m_punctualLightDistances = v4;
			//   v5 = (LightCullingGPU *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LightCullingGPU);
			//   v8 = (LightCulling *)v5;
			//   if ( !v5 )
			//     sub_180B536AC(v7, v6);
			//   HG::Rendering::Runtime::LightCullingGPU::LightCullingGPU(v5, 0LL);
			//   this.fields.m_lightCulling = v8;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_lightCulling, v9, v10, v11, v13, v14);
			// }
			// 
		}

		public void SetupState(CullingResults cullingResults, LightCullResult lightCullResult, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void SetupState(CullingResults, LightCullResult, HGCamera, HGSettingParameters)
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::SetupState(
			//         LightClusteringPassConstructor *this,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   HGCamera *v6; // r14
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v10; // xmm6
			//   int32_t v11; // r9d
			//   int v12; // r12d
			//   __int64 v13; // rdx
			//   Component *shadowManager; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   MethodInfo *v17; // r9
			//   __int64 v18; // xmm6_8
			//   int32_t v19; // r15d
			//   __int64 v20; // rsi
			//   Void *m_Buffer; // rdi
			//   __int64 v22; // r13
			//   float z; // r14d
			//   LightClusteringPassConstructor_PunctualLightSortStruct__StaticFields *static_fields; // rcx
			//   Void *v25; // rax
			//   int32_t priority; // edx
			//   float v27; // eax
			//   Vector3 *v28; // rax
			//   uint64_t v29; // xmm3_8
			//   MethodInfo *v30; // rdx
			//   float sqrMagnitude; // xmm0_4
			//   Void *v32; // rax
			//   int v33; // ecx
			//   __int64 m_Length; // rsi
			//   __int64 v35; // rdi
			//   LightClusteringPassConstructor_PunctualLightSortStruct__StaticFields *v36; // rcx
			//   Void *v37; // rax
			//   int32_t v38; // edx
			//   Void *v39; // r9
			//   __int64 v40; // r8
			//   int v41; // eax
			//   Int32Enum__Enum v42; // eax
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ m_visibleLights; // xmm1
			//   CullingResults v44; // xmm1
			//   Vector3 v45; // [rsp+58h] [rbp-49h] BYREF
			//   Vector3 v46; // [rsp+68h] [rbp-39h] BYREF
			//   JobHandle v47; // [rsp+78h] [rbp-29h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v48; // [rsp+88h] [rbp-19h] BYREF
			//   LightCullResult m_punctualLightSortArray; // [rsp+98h] [rbp-9h] BYREF
			//   JobHandle v50; // [rsp+A8h] [rbp+7h] BYREF
			// 
			//   v6 = camera;
			//   if ( !byte_18D919E30 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Rendering::VisibleLight>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::VisibleLight>::GetSubArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule);
			//     byte_18D919E30 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1627, 0LL) )
			//   {
			//     v10 = *UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//              (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&m_punctualLightSortArray,
			//              lightCullResult,
			//              0LL);
			//     m_punctualLightSortArray = (LightCullResult)v10;
			//     v11 = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v10, 8));
			//     if ( v11 > 256 )
			//       v11 = 256;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::GetSubArray(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v48,
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&m_punctualLightSortArray,
			//       0,
			//       v11,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::VisibleLight>::GetSubArray);
			//     this.fields.m_visibleLights = v48;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     m_punctualLightSortArray = (LightCullResult)v10;
			//     v12 = 0;
			//     this.fields.m_directionalLightIndex = HG::Rendering::Runtime::LightClusteringPassConstructor::GetDirectionalLightIndex(
			//                                              (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&m_punctualLightSortArray,
			//                                              0LL);
			//     if ( v6 )
			//     {
			//       shadowManager = (Component *)v6.fields.camera;
			//       if ( shadowManager )
			//       {
			//         transform = UnityEngine::Component::get_transform(shadowManager, 0LL);
			//         if ( transform )
			//         {
			//           position = UnityEngine::Transform::get_position((Vector3 *)&v48, transform, 0LL);
			//           v18 = *(_QWORD *)&position.x;
			//           v19 = 0;
			//           if ( this.fields.m_visibleLights.m_Length > 0 )
			//           {
			//             v20 = 0LL;
			//             m_Buffer = this.fields.m_visibleLights.m_Buffer;
			//             v22 = 0LL;
			//             z = position.z;
			//             do
			//             {
			//               if ( *(_DWORD *)m_Buffer == 2 || !*(_DWORD *)m_Buffer )
			//               {
			//                 ++v12;
			//                 *(_DWORD *)&this.fields.m_punctualLightIndices.m_Buffer[v22] = v19;
			//                 v22 += 4LL;
			//                 v27 = *(float *)&m_Buffer[124];
			//                 *(_QWORD *)&v46.x = *(_QWORD *)&m_Buffer[116];
			//                 *(_QWORD *)&v45.x = v18;
			//                 v45.z = z;
			//                 v46.z = v27;
			//                 v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&m_punctualLightSortArray, &v46, &v45, v17);
			//                 v29 = *(_QWORD *)&v28.x;
			//                 *(float *)&v28 = v28.z;
			//                 v47.jobGroup = v29;
			//                 v47.jobType = (int)v28;
			//                 LODWORD(v48.m_Buffer) = v19;
			//                 sqrMagnitude = UnityEngine::Vector3::get_sqrMagnitude((Vector3 *)&v47, v30);
			//                 v32 = this.fields.m_punctualLightSortArray.m_Buffer;
			//                 v33 = *(_DWORD *)&m_Buffer[112];
			//                 *((float *)&v48.m_Buffer + 1) = sqrMagnitude;
			//                 *(_QWORD *)&v32[v20] = v48.m_Buffer;
			//                 *(_DWORD *)&v32[v20 + 8] = v33;
			//               }
			//               else
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct);
			//                 static_fields = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct.static_fields;
			//                 v25 = this.fields.m_punctualLightSortArray.m_Buffer;
			//                 priority = static_fields.INVALID_LIGHT.priority;
			//                 *(_QWORD *)&v25[v20] = *(_QWORD *)&static_fields.INVALID_LIGHT.index;
			//                 *(_DWORD *)&v25[v20 + 8] = priority;
			//               }
			//               ++v19;
			//               m_Buffer += 148;
			//               v20 += 12LL;
			//             }
			//             while ( v19 < this.fields.m_visibleLights.m_Length );
			//             v6 = camera;
			//           }
			//           m_Length = this.fields.m_visibleLights.m_Length;
			//           if ( (int)m_Length < this.fields.m_punctualLightSortArray.m_Length )
			//           {
			//             v35 = 12 * m_Length;
			//             do
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct);
			//               LODWORD(m_Length) = m_Length + 1;
			//               v36 = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct.static_fields;
			//               v37 = this.fields.m_punctualLightSortArray.m_Buffer;
			//               v38 = v36.INVALID_LIGHT.priority;
			//               *(_QWORD *)&v37[v35] = *(_QWORD *)&v36.INVALID_LIGHT.index;
			//               *(_DWORD *)&v37[v35 + 8] = v38;
			//               v35 += 12LL;
			//             }
			//             while ( (int)m_Length < this.fields.m_punctualLightSortArray.m_Length );
			//           }
			//           m_punctualLightSortArray = (LightCullResult)this.fields.m_punctualLightSortArray;
			//           Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>(
			//             (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v48,
			//             (NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&m_punctualLightSortArray,
			//             MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>);
			//           v50 = 0LL;
			//           m_punctualLightSortArray = 0LL;
			//           Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule(
			//             &v47,
			//             (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v48,
			//             (JobHandle *)&m_punctualLightSortArray,
			//             MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule);
			//           v50 = v47;
			//           Unity::Jobs::JobHandle::Complete(&v50, 0LL);
			//           if ( v12 > 0 )
			//           {
			//             v39 = this.fields.m_punctualLightSortArray.m_Buffer;
			//             v13 = 0LL;
			//             v40 = 0LL;
			//             do
			//             {
			//               v41 = *(_DWORD *)&v39[v40];
			//               v40 += 12LL;
			//               *(_DWORD *)&this.fields.m_punctualLightIndices.m_Buffer[4 * v13] = v41;
			//               v39 = this.fields.m_punctualLightSortArray.m_Buffer;
			//               shadowManager = (Component *)this.fields.m_punctualLightDistances.m_Buffer;
			//               *((_DWORD *)&shadowManager.klass + v13++) = *(_DWORD *)&v39[v40 - 8];
			//             }
			//             while ( v13 < v12 );
			//           }
			//           if ( settingParameters )
			//           {
			//             v42 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                     (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._punctualLightMaxCount_k__BackingField,
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//             if ( v12 < (int)v42 )
			//               v42 = v12;
			//             this.fields.m_punctualLightCount = v42;
			//             shadowManager = (Component *)v6.fields.shadowManager;
			//             if ( shadowManager )
			//             {
			//               shadowManager = (Component *)shadowManager[15].klass;
			//               if ( shadowManager )
			//               {
			//                 m_visibleLights = this.fields.m_visibleLights;
			//                 m_punctualLightSortArray = (LightCullResult)this.fields.m_punctualLightIndices;
			//                 v48 = m_visibleLights;
			//                 HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PreparePunctualLightShadowCasters(
			//                   (HGPunctualLightShadowManagerV2 *)shadowManager,
			//                   &v48,
			//                   v6,
			//                   settingParameters,
			//                   (NativeArray_1_System_Int32_ *)&m_punctualLightSortArray,
			//                   v42,
			//                   0LL);
			//                 shadowManager = (Component *)this.fields.m_lightCulling;
			//                 if ( shadowManager )
			//                 {
			//                   HG::Rendering::Runtime::LightCulling::FrameSetup((LightCulling *)shadowManager, v6, 0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_31:
			//     sub_180B536AC(shadowManager, v13);
			//   }
			//   shadowManager = (Component *)IFix::WrappersManagerImpl::GetPatch(1627, 0LL);
			//   if ( !shadowManager )
			//     goto LABEL_31;
			//   v44 = *cullingResults;
			//   m_punctualLightSortArray = *lightCullResult;
			//   v48 = (NativeArray_1_UnityEngine_Rendering_VisibleLight_)v44;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_632(
			//     (ILFixDynamicMethodWrapper_2 *)shadowManager,
			//     (Object *)this,
			//     (CullingResults *)&v48,
			//     &m_punctualLightSortArray,
			//     (Object *)v6,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		private static int GetDirectionalLightIndex(NativeArray<VisibleLight> visibleLights)
		{
			// // Int32 GetDirectionalLightIndex(NativeArray`1[UnityEngine.Rendering.VisibleLight])
			// int32_t HG::Rendering::Runtime::LightClusteringPassConstructor::GetDirectionalLightIndex(
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         MethodInfo *method)
			// {
			//   int32_t v3; // esi
			//   int32_t v4; // edi
			//   Object_1 *SunSourceLight; // rbp
			//   float intensity_Injected; // xmm6_4
			//   int32_t m_Length; // r15d
			//   Void *i; // rbx
			//   int v9; // eax
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v18; // xmm1
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v19; // xmm0
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v20; // xmm1
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v21; // xmm0
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v22; // xmm1
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v23; // xmm0
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v24; // xmm1
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v25; // xmm0
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   int32_t instanceID_Injected; // r14d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v31[10]; // [rsp+20h] [rbp-188h] BYREF
			//   int v32; // [rsp+C0h] [rbp-E8h]
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v33; // [rsp+D0h] [rbp-D8h]
			//   __int128 v34; // [rsp+E0h] [rbp-C8h]
			//   __int128 v35; // [rsp+F0h] [rbp-B8h]
			//   __int128 v36; // [rsp+100h] [rbp-A8h]
			//   __int128 v37; // [rsp+110h] [rbp-98h]
			//   __int128 v38; // [rsp+120h] [rbp-88h]
			//   __int128 v39; // [rsp+130h] [rbp-78h]
			//   __int128 v40; // [rsp+140h] [rbp-68h]
			//   __int128 v41; // [rsp+150h] [rbp-58h]
			//   int v42; // [rsp+160h] [rbp-48h]
			//   HGSharedLightData _unity_self; // [rsp+1C0h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919E31 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E31 = 1;
			//   }
			//   _unity_self = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1628, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1628, 0LL);
			//     if ( !Patch )
			// LABEL_18:
			//       sub_180B536AC(v27, v26);
			//     v31[0] = *visibleLights;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_627(Patch, v31, 0LL);
			//   }
			//   else
			//   {
			//     if ( visibleLights.m_Length )
			//     {
			//       v3 = -1;
			//       v4 = 0;
			//       SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
			//       intensity_Injected = 0.0;
			//       if ( visibleLights.m_Length <= 0 )
			//         return v3;
			//       m_Length = visibleLights.m_Length;
			//       for ( i = visibleLights.m_Buffer; ; i += 148 )
			//       {
			//         v9 = *(_DWORD *)&i[144];
			//         v10 = *(_OWORD *)&i[16];
			//         v33 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)i;
			//         v11 = *(_OWORD *)&i[32];
			//         v34 = v10;
			//         v12 = *(_OWORD *)&i[48];
			//         v35 = v11;
			//         v13 = *(_OWORD *)&i[64];
			//         v36 = v12;
			//         v14 = *(_OWORD *)&i[80];
			//         v37 = v13;
			//         v15 = *(_OWORD *)&i[96];
			//         v38 = v14;
			//         v16 = *(_OWORD *)&i[112];
			//         v39 = v15;
			//         v17 = *(_OWORD *)&i[128];
			//         v40 = v16;
			//         v18 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[16];
			//         v41 = v17;
			//         v42 = v9;
			//         v31[1] = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)i;
			//         v19 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[32];
			//         v31[2] = v18;
			//         v20 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[48];
			//         v31[3] = v19;
			//         v21 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[64];
			//         v31[4] = v20;
			//         v22 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[80];
			//         v31[5] = v21;
			//         v23 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[96];
			//         v31[6] = v22;
			//         v24 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[112];
			//         v31[7] = v23;
			//         v25 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[128];
			//         v31[8] = v24;
			//         v31[9] = v25;
			//         v32 = v9;
			//         _unity_self = *(HGSharedLightData *)&v25.m_Length;
			//         if ( LODWORD(v33.m_Buffer) == 1 )
			//         {
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Inequality(SunSourceLight, 0LL, 0LL) )
			//           {
			//             instanceID_Injected = UnityEngine::HGSharedLightData::get_instanceID_Injected(&_unity_self, 0LL);
			//             if ( !SunSourceLight )
			//               goto LABEL_18;
			//             if ( instanceID_Injected == UnityEngine::Object::GetInstanceID(SunSourceLight, 0LL) )
			//               return v4;
			//           }
			//           if ( UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL) > intensity_Injected )
			//           {
			//             intensity_Injected = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
			//             v3 = v4;
			//           }
			//         }
			//         if ( ++v4 >= m_Length )
			//           return v3;
			//       }
			//     }
			//     return -1;
			//   }
			// }
			// 
			return 0;
		}

		internal void TryGetDirectionalLightDir(ref Vector4 lightDir, HGCamera camera)
		{
			// // Void TryGetDirectionalLightDir(Vector4 ByRef, HGCamera)
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::TryGetDirectionalLightDir(
			//         LightClusteringPassConstructor *this,
			//         Vector4 *lightDir,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbp
			//   Void *v10; // rax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   Light *light; // rax
			//   HGEnvironmentVolumeCameraComponent *v20; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   __int64 v22; // xmm0_8
			//   float z; // ecx
			//   Void *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   Vector3 *Forward; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v35; // [rsp+40h] [rbp-B8h] BYREF
			//   VisibleLight v36; // [rsp+50h] [rbp-A8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1647, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1647, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_633(Patch, (Object *)this, lightDir, (Object *)camera, 0LL);
			//   }
			//   else if ( this.fields.m_directionalLightIndex >= 0
			//          && this.fields.m_directionalLightIndex < this.fields.m_visibleLights.m_Length )
			//   {
			//     if ( camera )
			//     {
			//       m_envVolumeCameraComponent = camera.fields.m_envVolumeCameraComponent;
			//       v10 = &this.fields.m_visibleLights.m_Buffer[148 * this.fields.m_directionalLightIndex];
			//       v11 = *(_OWORD *)&v10[16];
			//       *(_OWORD *)&v36.m_LightType = *(_OWORD *)v10;
			//       v12 = *(_OWORD *)&v10[32];
			//       *(_OWORD *)&v36.m_FinalColor.a = v11;
			//       v13 = *(_OWORD *)&v10[48];
			//       *(_OWORD *)&v36.m_ScreenRect.m_Height = v12;
			//       v14 = *(_OWORD *)&v10[64];
			//       *(_OWORD *)&v36.m_LocalToWorldMatrix.m30 = v13;
			//       v15 = *(_OWORD *)&v10[80];
			//       *(_OWORD *)&v36.m_LocalToWorldMatrix.m31 = v14;
			//       v16 = *(_OWORD *)&v10[96];
			//       *(_OWORD *)&v36.m_LocalToWorldMatrix.m32 = v15;
			//       v17 = *(_OWORD *)&v10[128];
			//       *(_OWORD *)&v36.m_LocalToWorldMatrix.m33 = v16;
			//       v18 = *(_OWORD *)&v10[112];
			//       LODWORD(v10) = *(_DWORD *)&v10[144];
			//       *(_OWORD *)&v36.m_LightPriority = v18;
			//       *(_OWORD *)&v36.m_InstanceId = v17;
			//       LODWORD(v36.m_ScreenSpaceArea) = (_DWORD)v10;
			//       light = UnityEngine::Rendering::VisibleLight::get_light(&v36, 0LL);
			//       if ( m_envVolumeCameraComponent )
			//       {
			//         if ( !HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//                 m_envVolumeCameraComponent,
			//                 light,
			//                 0LL) )
			//         {
			//           v24 = &this.fields.m_visibleLights.m_Buffer[148 * this.fields.m_directionalLightIndex];
			//           v25 = *(_OWORD *)&v24[16];
			//           *(_OWORD *)&v36.m_LightType = *(_OWORD *)v24;
			//           v26 = *(_OWORD *)&v24[32];
			//           *(_OWORD *)&v36.m_FinalColor.a = v25;
			//           v27 = *(_OWORD *)&v24[48];
			//           *(_OWORD *)&v36.m_ScreenRect.m_Height = v26;
			//           v28 = *(_OWORD *)&v24[64];
			//           *(_OWORD *)&v36.m_LocalToWorldMatrix.m30 = v27;
			//           v29 = *(_OWORD *)&v24[80];
			//           *(_OWORD *)&v36.m_LocalToWorldMatrix.m31 = v28;
			//           v30 = *(_OWORD *)&v24[96];
			//           *(_OWORD *)&v36.m_LocalToWorldMatrix.m32 = v29;
			//           v31 = *(_OWORD *)&v24[112];
			//           *(_OWORD *)&v36.m_LocalToWorldMatrix.m33 = v30;
			//           v32 = *(_OWORD *)&v24[128];
			//           LODWORD(v24) = *(_DWORD *)&v24[144];
			//           *(_OWORD *)&v36.m_LightPriority = v31;
			//           *(_OWORD *)&v36.m_InstanceId = v32;
			//           LODWORD(v36.m_ScreenSpaceArea) = (_DWORD)v24;
			//           Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v35, &v36, 0LL);
			//           v22 = *(_QWORD *)&Forward.x;
			//           z = Forward.z;
			//           goto LABEL_11;
			//         }
			//         v20 = camera.fields.m_envVolumeCameraComponent;
			//         if ( v20 )
			//         {
			//           m_interpolatedPhase = v20.fields.m_interpolatedPhase;
			//           if ( m_interpolatedPhase )
			//           {
			//             v22 = *(_QWORD *)&m_interpolatedPhase.fields.lightConfig.forwardDirect.x;
			//             z = m_interpolatedPhase.fields.lightConfig.forwardDirect.z;
			// LABEL_11:
			//             lightDir.x = -*(float *)&v22;
			//             lightDir.z = -z;
			//             lightDir.y = -*((float *)&v22 + 1);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v8, v7);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         LightClusteringPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1648, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1648, 0LL);
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
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         LightClusteringPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1649, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1649, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref LightClusteringPassConstructor.PassInput input, ref LightClusteringPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(LightClusteringPassConstructor+PassInput ByRef, LightClusteringPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
			//         LightClusteringPassConstructor *this,
			//         LightClusteringPassConstructor_PassInput *input,
			//         LightClusteringPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   LightClusteringPassConstructor_PassOutput *v7; // r14
			//   LightClusteringPassConstructor *v9; // rdi
			//   HGSettingParameters *settingParams; // rax
			//   HGCamera *v11; // r13
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGLightCookieManager *lightCookieManager; // rsi
			//   CullingResults m_visibleLights; // xmm6
			//   HGSettingParameters *v16; // rax
			//   __int64 m_punctualLightCount; // rcx
			//   ProfilingSampler *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int64 v21; // rcx
			//   Object *v22; // rdx
			//   unsigned int v23; // edx
			//   unsigned __int64 v24; // r8
			//   char v25; // dl
			//   signed __int64 v26; // rtt
			//   LightCulling *m_lightCulling; // r12
			//   __int128 v28; // xmm6
			//   HGRenderGraph *v29; // xmm7_8
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v30; // xmm8
			//   int32_t m_directionalLightIndex; // r9d
			//   int32_t v32; // r10d
			//   __int64 m_lightMaskSpotOrPointWithoutOBB; // rcx
			//   __int64 m_lightMaskLinearWithOBB; // rdx
			//   uint32_t m_lightMaskLinearWithoutOBB; // r8d
			//   __int64 v36; // rdx
			//   LightCulling *v37; // rcx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   LightCulling *v40; // r12
			//   __int128 v41; // xmm6
			//   __int128 v42; // xmm7
			//   LightCulling__Class *klass; // r9
			//   const MethodInfo *v44; // rax
			//   __int64 v45; // rcx
			//   Object *v46; // rdx
			//   unsigned int v47; // edx
			//   unsigned __int64 v48; // r8
			//   char v49; // dl
			//   signed __int64 v50; // rtt
			//   ComputeBufferHandle *v51; // r12
			//   ComputeBufferHandle v52; // rax
			//   ComputeBufferHandle v53; // rdx
			//   ComputeBufferHandle v54; // rcx
			//   __int64 v55; // rdx
			//   LightCulling *v56; // rcx
			//   int32_t v57; // r8d
			//   LightClusteringPassConstructor_PassOutput *v58; // r9
			//   LightCulling *v59; // rax
			//   LightCulling *v60; // rax
			//   unsigned __int64 v61; // r8
			//   signed __int64 v62; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   int32_t uintCount; // [rsp+50h] [rbp-128h]
			//   CullingResults cullingResults; // [rsp+60h] [rbp-118h] BYREF
			//   Object *v68; // [rsp+70h] [rbp-108h] BYREF
			//   LightCullResult lightCullResult; // [rsp+80h] [rbp-F8h] BYREF
			//   LightClusteringPassConstructor_PassOutput *v70; // [rsp+90h] [rbp-E8h]
			//   HGRenderGraphBuilder v71; // [rsp+A0h] [rbp-D8h] BYREF
			//   NativeArray_1_System_Single_ v72; // [rsp+C0h] [rbp-B8h] BYREF
			//   NativeArray_1_System_Int32_ v73; // [rsp+D0h] [rbp-A8h] BYREF
			//   HGRenderGraphBuilder v74; // [rsp+E0h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v75; // [rsp+100h] [rbp-78h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v76; // [rsp+110h] [rbp-68h] BYREF
			// 
			//   v7 = output;
			//   v9 = this;
			//   v70 = output;
			//   if ( !byte_18D919E32 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::GetSubArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::GetSubArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5ECBE0);
			//     byte_18D919E32 = 1;
			//   }
			//   v68 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1650, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1650, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v65, v64);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_635(
			//       Patch,
			//       (Object *)v9,
			//       input,
			//       v7,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     settingParams = input.settingParams;
			//     lightCullResult = input.lightCullResult;
			//     cullingResults = input.cullingResults;
			//     v11 = camera;
			//     HG::Rendering::Runtime::LightClusteringPassConstructor::SetupState(
			//       v9,
			//       &cullingResults,
			//       &lightCullResult,
			//       camera,
			//       settingParams,
			//       0LL);
			//     if ( !camera )
			//       sub_180B536AC(v13, v12);
			//     lightCookieManager = camera.fields.lightCookieManager;
			//     m_visibleLights = (CullingResults)v9.fields.m_visibleLights;
			//     v16 = input.settingParams;
			//     m_punctualLightCount = (unsigned int)v9.fields.m_punctualLightCount;
			//     if ( !lightCookieManager )
			//       sub_180B536AC(m_punctualLightCount, v12);
			//     lightCullResult = (LightCullResult)v9.fields.m_punctualLightIndices;
			//     cullingResults = m_visibleLights;
			//     HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlas(
			//       lightCookieManager,
			//       renderGraph,
			//       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&cullingResults,
			//       camera,
			//       v16,
			//       (NativeArray_1_System_Int32_ *)&lightCullResult,
			//       m_punctualLightCount,
			//       0LL);
			//     v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x6Fu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v20, v19);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v71,
			//       renderGraph,
			//       (String *)"Compute GPU Light Buffers",
			//       &v68,
			//       v18,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
			//     v74 = v71;
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v74;
			//     try
			//     {
			//       v22 = v68;
			//       if ( !v68 )
			//         sub_1802DC2C8(v21, 0LL);
			//       v68[1].klass = (Object__Class *)camera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v23 = ((unsigned __int64)&v22[1] >> 12) & 0x1FFFFF;
			//         v24 = (unsigned __int64)v23 >> 6;
			//         v25 = v23 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v26 = qword_18D6405E0[v24 + 36190];
			//         while ( v26 != _InterlockedCompareExchange64(&qword_18D6405E0[v24 + 36190], v26 | (1LL << v25), v26) );
			//       }
			//       m_lightCulling = v9.fields.m_lightCulling;
			//       v28 = *(_OWORD *)&input.binningData.tileSize;
			//       v29 = *(HGRenderGraph **)&input.binningData.xyOffset;
			//       uintCount = input.binningData.uintCount;
			//       v30 = v9.fields.m_visibleLights;
			//       Unity::Collections::NativeArray<MagicaCloth::TwistConstraint::TwistData>::GetSubArray(
			//         (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v73,
			//         (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v9.fields.m_punctualLightIndices,
			//         0,
			//         v9.fields.m_punctualLightCount,
			//         MethodInfo::Unity::Collections::NativeArray<int>::GetSubArray);
			//       Unity::Collections::NativeArray<MagicaCloth::TwistConstraint::TwistData>::GetSubArray(
			//         (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v72,
			//         (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v9.fields.m_punctualLightDistances,
			//         0,
			//         v9.fields.m_punctualLightCount,
			//         MethodInfo::Unity::Collections::NativeArray<float>::GetSubArray);
			//       m_directionalLightIndex = v9.fields.m_directionalLightIndex;
			//       v32 = v9.fields.m_punctualLightCount;
			//       m_lightMaskSpotOrPointWithoutOBB = v9.fields.m_lightMaskSpotOrPointWithoutOBB;
			//       m_lightMaskLinearWithOBB = v9.fields.m_lightMaskLinearWithOBB;
			//       m_lightMaskLinearWithoutOBB = v9.fields.m_lightMaskLinearWithoutOBB;
			//       LODWORD(cullingResults.ptr) = v9.fields.m_lightMaskSpotOrPointWithOBB;
			//       HIDWORD(cullingResults.ptr) = m_lightMaskSpotOrPointWithoutOBB;
			//       cullingResults.m_AllocationInfo = (CullingAllocationInfo *)__PAIR64__(
			//                                                                    m_lightMaskLinearWithoutOBB,
			//                                                                    m_lightMaskLinearWithOBB);
			//       if ( !m_lightCulling )
			//         sub_1802DC2C8(m_lightMaskSpotOrPointWithoutOBB, m_lightMaskLinearWithOBB);
			//       v76 = v30;
			//       *(_OWORD *)&v71.m_RenderPass = v28;
			//       v71.m_RenderGraph = v29;
			//       *(_DWORD *)&v71.m_Disposed = uintCount;
			//       HG::Rendering::Runtime::LightCulling::PrepareCPUData(
			//         m_lightCulling,
			//         camera,
			//         (BinningPass_BinningData *)&v71,
			//         &v76,
			//         &v73,
			//         &v72,
			//         m_directionalLightIndex,
			//         v32,
			//         (uint4 *)&cullingResults,
			//         0LL);
			//       v37 = v9.fields.m_lightCulling;
			//       if ( !v37 )
			//         sub_1802DC2C8(0LL, v36);
			//       HG::Rendering::Runtime::LightCulling::SetOuputTileDrawBuffers(v37, input.outputTileResult, 0LL);
			//       v40 = v9.fields.m_lightCulling;
			//       if ( !v40 )
			//         sub_1802DC2C8(v39, v38);
			//       v41 = *(_OWORD *)&v74.m_RenderPass;
			//       v42 = *(_OWORD *)&v74.m_RenderGraph;
			//       sub_180003EE0(v40.klass);
			//       klass = v40.klass;
			//       v44 = v40.klass.vtable.PrepareRenderGraphBuffers.method;
			//       *(_OWORD *)&v71.m_RenderPass = v41;
			//       *(_OWORD *)&v71.m_RenderGraph = v42;
			//       ((void (__fastcall *)(LightCulling *, HGRenderGraph *, HGRenderGraphBuilder *, Il2CppMethodPointer))v44)(
			//         v40,
			//         renderGraph,
			//         &v71,
			//         klass.vtable.PrepareGPUData.methodPtr);
			//       v46 = v68;
			//       if ( !v68 )
			//         sub_1802DC2C8(v45, 0LL);
			//       v68[2].monitor = (MonitorData *)v9.fields.m_lightCulling;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v47 = ((unsigned __int64)&v46[2].monitor >> 12) & 0x1FFFFF;
			//         v48 = (unsigned __int64)v47 >> 6;
			//         v49 = v47 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//         do
			//           v50 = qword_18D6405E0[v48 + 36190];
			//         while ( v50 != _InterlockedCompareExchange64(&qword_18D6405E0[v48 + 36190], v50 | (1LL << v49), v50) );
			//       }
			//       v51 = (ComputeBufferHandle *)v68;
			//       v52 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v74, &input.binningBuffer, 0LL);
			//       if ( !v51 )
			//         sub_1802DC2C8(v54, v53);
			//       v51[6] = v52;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v74, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v74,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor.static_fields.s_lightCullingRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v75 )
			//     {
			//       lightCullResult.visibleLightsPtr = v75.ex;
			//       sub_180222690(&lightCullResult);
			//       v11 = camera;
			//       v7 = output;
			//       v9 = this;
			//       goto LABEL_22;
			//     }
			//     sub_180222690(&lightCullResult);
			// LABEL_22:
			//     HG::Rendering::Runtime::LightClusteringPassConstructor::TryGetDirectionalLightDir(
			//       v9,
			//       &v7.directionalLightDir,
			//       v11,
			//       0LL);
			//     v7[18].tileInstanceIndices.handle.m_Value = v9.fields.m_directionalLightIndex;
			//     v7[18].drawTileArgs.handle._type_k__BackingField = v9.fields.m_punctualLightCount;
			//     v57 = 0;
			//     if ( v9.fields.m_punctualLightIndices.m_Length > 0 )
			//     {
			//       v55 = 0LL;
			//       v58 = v70;
			//       do
			//       {
			//         v56 = (LightCulling *)*(_DWORD *)&v9.fields.m_punctualLightIndices.m_Buffer[v55];
			//         *(int32_t *)((char *)&v58.punctualLightIndices.FixedElementField + v55) = (int)v56;
			//         ++v57;
			//         v55 += 4LL;
			//       }
			//       while ( v57 < v9.fields.m_punctualLightIndices.m_Length );
			//     }
			//     v59 = v9.fields.m_lightCulling;
			//     if ( !v59
			//       || (*(ComputeBufferHandle *)&v7[18].tileInstanceIndices.handle._type_k__BackingField = v59.fields.m_drawTileArgsBufferHandle,
			//           (v60 = v9.fields.m_lightCulling) == 0LL)
			//       || (v7[18].quadIndexBuffer = (GraphicsBuffer *)v60.fields.m_tileInstanceIndicesBufferHandle,
			//           (v56 = v9.fields.m_lightCulling) == 0LL) )
			//     {
			//       sub_1802DC2C8(v56, v55);
			//     }
			//     *(_QWORD *)&v7[19].directionalLightDir.x = HG::Rendering::Runtime::LightCulling::get_QuadIndexBuffer(v56, 0LL);
			//     if ( dword_18D8E43F8 )
			//     {
			//       v61 = (((unsigned __int64)&v7[19] >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v61 + 36190]);
			//       do
			//         v62 = qword_18D6405E0[v61 + 36190];
			//       while ( v62 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v61 + 36190],
			//                        v62 | (1LL << (((unsigned __int64)&v7[19] >> 12) & 0x3F)),
			//                        v62) );
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         LightClusteringPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1651, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1651, 0LL);
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
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         LightClusteringPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1652, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1652, 0LL);
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
			//     HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(this, 0LL);
			//   }
			// }
			// 
		}

		private void System.IDisposable.Dispose()
		{
			// // Void System.IDisposable.Dispose()
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::System_IDisposable_Dispose(
			//         LightClusteringPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1654, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1654, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(this, 0LL);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(
			//         LightClusteringPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   LightCulling *m_lightCulling; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCEE )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     byte_18D8EDCEE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1653, 0LL) )
			//   {
			//     Unity::Collections::NativeArray<int>::Dispose(
			//       &this.fields.m_punctualLightIndices,
			//       MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_punctualLightDistances,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     m_lightCulling = this.fields.m_lightCulling;
			//     if ( m_lightCulling )
			//     {
			//       sub_180040B30(5LL, m_lightCulling);
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_punctualLightSortArray,
			//         MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::Dispose);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v3, m_lightCulling);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1653, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal const int MAX_PUNCTUAL_LIGHT_INDICES_COUNT = 256;

		private NativeArray<VisibleLight> m_visibleLights;

		private NativeArray<LightClusteringPassConstructor.PunctualLightSortStruct> m_punctualLightSortArray;

		private NativeArray<int> m_punctualLightIndices;

		private NativeArray<float> m_punctualLightDistances;

		private int m_punctualLightCount;

		private int m_directionalLightIndex;

		private uint m_lightMaskSpotOrPointWithOBB;

		private uint m_lightMaskSpotOrPointWithoutOBB;

		private uint m_lightMaskLinearWithOBB;

		private uint m_lightMaskLinearWithoutOBB;

		private LightCulling m_lightCulling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<LightClusteringPassConstructor.LightCullingPassData> s_lightCullingRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct PunctualLightSortStruct : IComparable<LightClusteringPassConstructor.PunctualLightSortStruct>
		{
			public PunctualLightSortStruct(int inIndex, float inDistance, int inPriority)
			{
				// // LightClusteringPassConstructor+PunctualLightSortStruct(Int32, Single, Int32)
				// void HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct::PunctualLightSortStruct(
				//         LightClusteringPassConstructor_PunctualLightSortStruct *this,
				//         int32_t inIndex,
				//         float inDistance,
				//         int32_t inPriority,
				//         MethodInfo *method)
				// {
				//   this.distance = inDistance;
				//   this.index = inIndex;
				//   this.priority = inPriority;
				// }
				// 
			}

			public int CompareTo(LightClusteringPassConstructor.PunctualLightSortStruct other)
			{
				// // Int32 CompareTo(LightClusteringPassConstructor+PunctualLightSortStruct)
				// int32_t HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct::CompareTo(
				//         LightClusteringPassConstructor_PunctualLightSortStruct *this,
				//         LightClusteringPassConstructor_PunctualLightSortStruct *other,
				//         MethodInfo *method)
				// {
				//   __int64 v6; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
				//   int32_t priority; // eax
				//   LightClusteringPassConstructor_PunctualLightSortStruct v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1655, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1655, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(0LL, v6);
				//     priority = other.priority;
				//     *(_QWORD *)&v9.index = *(_QWORD *)&other.index;
				//     v9.priority = priority;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_636(Patch, this, &v9, 0LL);
				//   }
				//   else if ( this.priority == other.priority )
				//   {
				//     return System::Single::CompareTo((Single *)&this.distance, other.distance, 0LL);
				//   }
				//   else
				//   {
				//     return System::Int32::CompareTo((Int32 *)&other.priority, this.priority, 0LL);
				//   }
				// }
				// 
				return 0;
			}

			public int index;

			public float distance;

			private int priority;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static LightClusteringPassConstructor.PunctualLightSortStruct INVALID_LIGHT;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal CullingResults cullingResults;

			internal LightCullResult lightCullResult;

			internal BinningPass.BinningData binningData;

			internal ComputeBufferHandle binningBuffer;

			internal HGSettingParameters settingParams;

			internal bool outputTileResult;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassOutput
		{
			internal Vector4 directionalLightDir;

			[FixedBuffer(typeof(int), 256)]
			internal LightClusteringPassConstructor.PassOutput.<punctualLightIndices>e__FixedBuffer punctualLightIndices;

			internal int punctualLightCount;

			internal int directionalLightIndex;

			internal ComputeBufferHandle drawTileArgs;

			internal ComputeBufferHandle tileInstanceIndices;

			internal GraphicsBuffer quadIndexBuffer;

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1024)]
			public struct <punctualLightIndices>e__FixedBuffer
			{
				public int FixedElementField;
			}
		}

		private class LightCullingPassData
		{
			public LightCullingPassData()
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

			public HGCamera hgCamera;

			public TextureHandle depthTexture;

			public LightCulling lightCulling;

			public ComputeBufferHandle binningBuffer;

			public float renderingScale;
		}
	}
}
