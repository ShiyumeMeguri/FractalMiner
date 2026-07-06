using System;
using System.Collections.Generic;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGCapsuleShadowManager
	{
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool Enabled
		{
			get
			{
				// // Boolean get_Enabled()
				// bool HG::Rendering::Runtime::HGCapsuleShadowManager::get_Enabled(HGCapsuleShadowManager *this, MethodInfo *method)
				// {
				//   if ( !byte_18D919E6B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
				//     byte_18D919E6B = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows.static_fields.instance )
				//     return 0;
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
				//   return HG::Rendering::Runtime::HGCapsuleShadows::get_count(0LL) > 0;
				// }
				// 
				return default(bool);
			}
		}

		public HGCapsuleShadowManager()
		{
			// // HGCapsuleShadowManager()
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::HGCapsuleShadowManager(
			//         HGCapsuleShadowManager *this,
			//         MethodInfo *method)
			// {
			//   Vector3Int *v2; // r8
			//   ITilemap *v3; // r9
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v5; // rdx
			//   TileAnimationData v6; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                              &v6,
			//                              (TileBase *)this,
			//                              v2,
			//                              v3,
			//                              (MethodInfo *)v6.m_AnimatedSprites);
			//   *(TileAnimationData *)(v5 + 136) = *TileAnimationDataNoRef;
			// }
			// 
		}

		public void Initialize(Material capsuleShadowCasterMat, Mesh sphereMesh)
		{
			// // Void Initialize(Material, Mesh)
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::Initialize(
			//         HGCapsuleShadowManager *this,
			//         Material *capsuleShadowCasterMat,
			//         Mesh *sphereMesh,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_Unity_Mathematics_quaternion_ v7; // xmm0
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   MaterialPropertyBlock *v13; // rsi
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methodb; // [rsp+20h] [rbp-20h]
			//   MethodInfo *methoda; // [rsp+20h] [rbp-20h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-20h]
			//   String *v24; // [rsp+28h] [rbp-18h]
			//   String *v25; // [rsp+28h] [rbp-18h]
			//   String *v26; // [rsp+28h] [rbp-18h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v27; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919E6C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     byte_18D919E6C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1762, 0LL) )
			//   {
			//     v27 = 0LL;
			//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//       &v27,
			//       256,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     this.fields.m_capsuleShadowData1 = (NativeArray_1_UnityEngine_Vector4_)v27;
			//     v27 = 0LL;
			//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//       &v27,
			//       256,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     this.fields.m_capsuleShadowData2 = (NativeArray_1_UnityEngine_Vector4_)v27;
			//     v27 = 0LL;
			//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//       &v27,
			//       256,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     this.fields.m_capsuleShadowData3 = (NativeArray_1_UnityEngine_Vector4_)v27;
			//     v27 = 0LL;
			//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//       &v27,
			//       256,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     this.fields.m_capsuleShadowData4 = (NativeArray_1_UnityEngine_Vector4_)v27;
			//     v27 = 0LL;
			//     Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
			//       (NativeArray_1_UnityEngine_Matrix4x4_ *)&v27,
			//       256,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     v7 = v27;
			//     this.fields.m_capsuleShadowCasterMaterial = capsuleShadowCasterMat;
			//     this.fields.m_capsuleStencilWriterMatrixes = (NativeArray_1_UnityEngine_Matrix4x4_)v7;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_capsuleShadowCasterMaterial,
			//       v8,
			//       v9,
			//       v10,
			//       (String__Array *)methodb,
			//       v24,
			//       (MethodInfo *)v27.m_Buffer);
			//     v13 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     if ( v13 )
			//     {
			//       v13.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//       this.fields.m_capsuleShadowPropertyBlock = v13;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_capsuleShadowPropertyBlock,
			//         v14,
			//         v15,
			//         v16,
			//         (String__Array *)methoda,
			//         v25,
			//         (MethodInfo *)v27.m_Buffer);
			//       this.fields.m_sphereMesh = sphereMesh;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_sphereMesh,
			//         v17,
			//         v18,
			//         v19,
			//         (String__Array *)methodc,
			//         v26,
			//         (MethodInfo *)v27.m_Buffer);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v12, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1762, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)capsuleShadowCasterMat,
			//     (Object *)sphereMesh,
			//     0LL);
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::Release(HGCapsuleShadowManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   MaterialPropertyBlock *m_capsuleShadowPropertyBlock; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E6D )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::get_IsCreated);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::get_IsCreated);
			//     byte_18D919E6D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1763, 0LL) )
			//   {
			//     if ( this.fields.m_capsuleShadowData1.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_capsuleShadowData1,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.m_capsuleShadowData2.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_capsuleShadowData2,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.m_capsuleShadowData3.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_capsuleShadowData3,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.m_capsuleShadowData4.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_capsuleShadowData4,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     if ( this.fields.m_capsuleStencilWriterMatrixes.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.m_capsuleStencilWriterMatrixes,
			//         MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::Dispose);
			//     m_capsuleShadowPropertyBlock = this.fields.m_capsuleShadowPropertyBlock;
			//     if ( m_capsuleShadowPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::Clear(m_capsuleShadowPropertyBlock, 1, 0LL);
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(m_capsuleShadowPropertyBlock, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1763, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void FrameSetup(CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, HGCamera hgCamera)
		{
			// // Void FrameSetup(CullingResults, LightCullResult, Int32, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::FrameSetup(
			//         HGCapsuleShadowManager *this,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         int32_t directionalLightIndex,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   int32_t v6; // r14d
			//   LightCullResult *v7; // r13
			//   HGCapsuleShadowManager *v9; // rdi
			//   __m128 v10; // xmm9
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   String__Array **v14; // rdx
			//   Il2CppException *v15; // rcx
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *m_capsuleShadowHelpers; // rsi
			//   int32_t v17; // esi
			//   __m128 v18; // xmm12
			//   Object *Item; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Object *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   HGCapsuleShadowHelper *v25; // r15
			//   __m128 v26; // xmm6
			//   __m128 v27; // xmm11
			//   Matrix4x4 *CapsuleLocalToWorldMatrix; // rax
			//   __m128 v29; // xmm13
			//   __m128 v30; // xmm8
			//   __m128 v31; // xmm6
			//   __int64 v32; // rax
			//   __int64 v33; // xmm15_8
			//   float v34; // edx
			//   float v35; // xmm4_4
			//   float v36; // xmm5_4
			//   unsigned int v37; // xmm7_4
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v40; // xmm0
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // r13
			//   Light *light; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   __int64 v48; // xmm0_8
			//   float z; // ecx
			//   Vector3 *Forward; // rax
			//   unsigned int v51; // xmm3_4
			//   unsigned int v52; // xmm2_4
			//   float m_ditherAlpha; // xmm0_4
			//   Quaternion *v54; // rax
			//   __m128 v55; // xmm1
			//   Matrix4x4 *v56; // rax
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm2
			//   __int128 v60; // xmm3
			//   __int64 v61; // rcx
			//   Void *m_Buffer; // rax
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *v63; // rdx
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rsi
			//   String__Array *v67[8]; // [rsp+0h] [rbp-4A8h] BYREF
			//   int32_t v68; // [rsp+40h] [rbp-468h]
			//   float v69; // [rsp+44h] [rbp-464h]
			//   __int64 v70; // [rsp+48h] [rbp-460h]
			//   __int64 v71; // [rsp+58h] [rbp-450h]
			//   __int128 v72; // [rsp+68h] [rbp-440h]
			//   __int128 v73; // [rsp+78h] [rbp-430h]
			//   __int128 v74; // [rsp+88h] [rbp-420h]
			//   __int128 v75; // [rsp+98h] [rbp-410h]
			//   __m128 v76; // [rsp+B0h] [rbp-3F8h]
			//   Vector3 v77; // [rsp+C0h] [rbp-3E8h] BYREF
			//   Vector3 v78; // [rsp+D0h] [rbp-3D8h] BYREF
			//   Vector3 v79; // [rsp+E0h] [rbp-3C8h] BYREF
			//   Vector3 v80; // [rsp+F0h] [rbp-3B8h] BYREF
			//   Vector3 v81; // [rsp+100h] [rbp-3A8h] BYREF
			//   Il2CppException *ex; // [rsp+110h] [rbp-398h]
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v83; // [rsp+118h] [rbp-390h]
			//   CullingResults v84; // [rsp+120h] [rbp-388h] BYREF
			//   LightCullResult v85; // [rsp+130h] [rbp-378h] BYREF
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ v86; // [rsp+140h] [rbp-368h] BYREF
			//   Il2CppExceptionWrapper *v87; // [rsp+180h] [rbp-328h] BYREF
			//   HGCapsuleShadowContainer current; // [rsp+190h] [rbp-318h] BYREF
			//   Vector3 v89; // [rsp+1D0h] [rbp-2D8h] BYREF
			//   _BYTE v90[16]; // [rsp+1E0h] [rbp-2C8h] BYREF
			//   Vector3 v91; // [rsp+1F0h] [rbp-2B8h] BYREF
			//   Matrix4x4 v92; // [rsp+200h] [rbp-2A8h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v93; // [rsp+240h] [rbp-268h] BYREF
			//   Quaternion v94; // [rsp+250h] [rbp-258h] BYREF
			//   Matrix4x4 v95; // [rsp+260h] [rbp-248h] BYREF
			//   VisibleLight v96; // [rsp+2A0h] [rbp-208h] BYREF
			//   VisibleLight v97[2]; // [rsp+340h] [rbp-168h] BYREF
			// 
			//   v6 = directionalLightIndex;
			//   v7 = lightCullResult;
			//   v9 = this;
			//   if ( !byte_18D919E6E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Item);
			//     sub_18003C530(&off_18D5EF758);
			//     byte_18D919E6E = 1;
			//   }
			//   sub_1802F01E0(&v86, 0LL, 64LL);
			//   v10 = 0LL;
			//   v70 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1764, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1764, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v65, v64);
			//     v85 = *v7;
			//     v84 = *cullingResults;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_683(Patch, (Object *)v9, &v84, &v85, v6, (Object *)hgCamera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
			//     v9.fields.m_capsuleShadowHelpers = HG::Rendering::Runtime::HGCapsuleShadows::get_capsuleShadowHelpers(0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v9.fields.m_capsuleShadowHelpers,
			//       v11,
			//       v12,
			//       v13,
			//       v67[4],
			//       (String *)v67[5],
			//       (MethodInfo *)v67[6]);
			//     m_capsuleShadowHelpers = v9.fields.m_capsuleShadowHelpers;
			//     if ( !m_capsuleShadowHelpers )
			//       sub_180B536AC(v15, v14);
			//     *(_QWORD *)&v9.fields.m_capsuleHelperNum = (unsigned int)m_capsuleShadowHelpers.fields._size;
			//     v17 = 0;
			//     v18 = (__m128)0x3F800000u;
			//     while ( 1 )
			//     {
			//       v68 = v17;
			//       if ( v17 >= v9.fields.m_capsuleHelperNum )
			//         break;
			//       if ( !v9.fields.m_capsuleShadowHelpers )
			//         sub_180B536AC(v15, v14);
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                (List_1_System_Object_ *)v9.fields.m_capsuleShadowHelpers,
			//                v17,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Item);
			//       if ( !Item )
			//         sub_180B536AC(v21, v20);
			//       if ( UnityEngine::Behaviour::get_enabled((Behaviour *)Item, 0LL) )
			//       {
			//         if ( !v9.fields.m_capsuleShadowHelpers )
			//           sub_180B536AC(v15, v14);
			//         v22 = System::Collections::Generic::List<System::Object>::get_Item(
			//                 (List_1_System_Object_ *)v9.fields.m_capsuleShadowHelpers,
			//                 v17,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Item);
			//         v25 = (HGCapsuleShadowHelper *)v22;
			//         if ( !v22 )
			//           sub_180B536AC(v24, v23);
			//         if ( !v22[1].monitor )
			//           sub_180B536AC(v24, v23);
			//         v86 = *(List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *)sub_18031E490(
			//                                                                                        &current,
			//                                                                                        v22[1].monitor);
			//         ex = 0LL;
			//         v83 = &v86;
			//         try
			//         {
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext(
			//                     &v86,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext) )
			//           {
			//             v26 = *(__m128 *)&v86._current.rootTransform;
			//             *(_OWORD *)&current.localOffset.x = *(_OWORD *)&v86._current.localOffset.x;
			//             v27 = *(__m128 *)&v86._current.localRotation.y;
			//             if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v86._current.localRotation.y, 12)) )
			//             {
			//               if ( v9.fields.m_capsuleNum >= 256 )
			//               {
			//                 v63 = v9.fields.m_capsuleShadowHelpers;
			//                 if ( !v63 )
			//                   sub_1802DC2C8(v15, 0LL);
			//                 HG::Rendering::HGRPLogger::LogError<int>(
			//                   (String *)"Shadow Capsule num is higher than max limit (256). Active HGCapsuleShadowHelper Num is: {0}",
			//                   v63.fields._size,
			//                   MethodInfo::HG::Rendering::HGRPLogger::LogError<int>);
			//               }
			//               else
			//               {
			//                 if ( !v25 )
			//                   sub_1802DC2C8(v15, v14);
			//                 current = v86._current;
			//                 CapsuleLocalToWorldMatrix = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleLocalToWorldMatrix(
			//                                               &v95,
			//                                               v25,
			//                                               &current,
			//                                               0LL);
			//                 *(_OWORD *)&v92.m00 = *(_OWORD *)&CapsuleLocalToWorldMatrix.m00;
			//                 *(_OWORD *)&v92.m01 = *(_OWORD *)&CapsuleLocalToWorldMatrix.m01;
			//                 *(_OWORD *)&v92.m02 = *(_OWORD *)&CapsuleLocalToWorldMatrix.m02;
			//                 v29 = *(__m128 *)&CapsuleLocalToWorldMatrix.m03;
			//                 *(__m128 *)&v92.m03 = v29;
			//                 v30 = _mm_shuffle_ps(v26, v26, 170);
			//                 v31 = _mm_shuffle_ps(v26, v26, 255);
			//                 if ( v31.m128_f32[0] <= (float)(v30.m128_f32[0] + v30.m128_f32[0]) )
			//                   v31 = v30;
			//                 *(_QWORD *)&v77.x = _mm_unpacklo_ps(v10, v18).m128_u64[0];
			//                 LODWORD(v77.z) = v10.m128_i32[0];
			//                 v78 = *UnityEngine::Matrix4x4::MultiplyVector(&v89, &v92, &v77, 0LL);
			//                 v32 = sub_182413270(v90, &v78);
			//                 v33 = *(_QWORD *)v32;
			//                 v70 = *(_QWORD *)v32;
			//                 v34 = *(float *)(v32 + 8);
			//                 v69 = v34;
			//                 if ( v6 == -1 )
			//                 {
			//                   v35 = v10.m128_f32[0];
			//                   v36 = v10.m128_f32[0];
			//                   v37 = v18.m128_i32[0];
			//                 }
			//                 else
			//                 {
			//                   v40 = *UnityEngine::HyperGryph::LightCullResult::get_visibleLights(&v93, v7, 0LL);
			//                   if ( !hgCamera )
			//                     sub_1802DC2C8(v39, v38);
			//                   m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//                   v76.m128_u64[0] = (unsigned __int64)v40.m_Buffer;
			//                   v96 = *(VisibleLight *)&v40.m_Buffer[148 * v6];
			//                   light = UnityEngine::Rendering::VisibleLight::get_light(&v96, 0LL);
			//                   if ( !m_envVolumeCameraComponent )
			//                     sub_1802DC2C8(v44, v43);
			//                   if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//                          m_envVolumeCameraComponent,
			//                          light,
			//                          0LL) )
			//                   {
			//                     m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//                     if ( !m_interpolatedPhase )
			//                       sub_1802DC2C8(v46, v45);
			//                     v48 = *(_QWORD *)&m_interpolatedPhase.fields.lightConfig.forwardDirect.x;
			//                     z = m_interpolatedPhase.fields.lightConfig.forwardDirect.z;
			//                   }
			//                   else
			//                   {
			//                     v97[0] = *(VisibleLight *)(148LL * v6 + v76.m128_u64[0]);
			//                     Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v91, v97, 0LL);
			//                     v48 = *(_QWORD *)&Forward.x;
			//                     z = Forward.z;
			//                   }
			//                   v71 = v48;
			//                   v35 = -*(float *)&v48;
			//                   v36 = -*((float *)&v48 + 1);
			//                   v37 = LODWORD(z) ^ 0x80000000;
			//                   v7 = lightCullResult;
			//                   v34 = v69;
			//                 }
			//                 LODWORD(v72) = v29.m128_i32[0];
			//                 v76 = _mm_shuffle_ps(v29, v29, 85);
			//                 DWORD1(v72) = v76.m128_i32[0];
			//                 v84 = (CullingResults)_mm_shuffle_ps(v29, v29, 170);
			//                 *((_QWORD *)&v72 + 1) = __PAIR64__(v30.m128_u32[0], (unsigned int)v84.ptr);
			//                 *(_OWORD *)&v9.fields.m_capsuleShadowData1.m_Buffer[16 * v9.fields.m_capsuleNum] = v72;
			//                 v51 = v70;
			//                 *(_QWORD *)&v73 = v70;
			//                 v52 = HIDWORD(v70);
			//                 *((float *)&v73 + 2) = v34;
			//                 *((float *)&v73 + 3) = v18.m128_f32[0] / v31.m128_f32[0];
			//                 *(_OWORD *)&v9.fields.m_capsuleShadowData2.m_Buffer[16 * v9.fields.m_capsuleNum] = v73;
			//                 m_ditherAlpha = v25.fields.m_ditherAlpha;
			//                 *(_QWORD *)&v74 = __PAIR64__(LODWORD(v36), LODWORD(v35));
			//                 DWORD2(v74) = v37;
			//                 *((float *)&v74 + 3) = (float)(m_ditherAlpha * v25.fields.m_intensity)
			//                                      * _mm_shuffle_ps(v27, v27, 170).m128_f32[0];
			//                 *(_OWORD *)&v9.fields.m_capsuleShadowData3.m_Buffer[16 * v9.fields.m_capsuleNum] = v74;
			//                 *(_QWORD *)&v75 = __PAIR64__(v52, v51);
			//                 *((_QWORD *)&v75 + 1) = __PAIR64__(v31.m128_u32[0], LODWORD(v34));
			//                 *(_OWORD *)&v9.fields.m_capsuleShadowData4.m_Buffer[16 * v9.fields.m_capsuleNum] = v75;
			//                 *(_QWORD *)&v79.x = v33;
			//                 v79.z = v34;
			//                 v54 = UnityEngine::Quaternion::LookRotation(&v94, &v79, 0LL);
			//                 v55 = v31;
			//                 v31.m128_f32[0] = v31.m128_f32[0] * 5.0;
			//                 v55.m128_f32[0] = v31.m128_f32[0];
			//                 *(_QWORD *)&v80.x = _mm_unpacklo_ps(v31, v55).m128_u64[0];
			//                 LODWORD(v80.z) = v31.m128_i32[0];
			//                 v85 = (LightCullResult)*v54;
			//                 *(_QWORD *)&v81.x = _mm_unpacklo_ps(v29, v76).m128_u64[0];
			//                 v81.z = *(float *)&v84.ptr;
			//                 v56 = UnityEngine::Matrix4x4::TRS(&v95, &v81, (Quaternion *)&v85, &v80, 0LL);
			//                 v57 = *(_OWORD *)&v56.m00;
			//                 v58 = *(_OWORD *)&v56.m01;
			//                 v59 = *(_OWORD *)&v56.m02;
			//                 v60 = *(_OWORD *)&v56.m03;
			//                 v61 = (__int64)v9.fields.m_capsuleNum << 6;
			//                 m_Buffer = v9.fields.m_capsuleStencilWriterMatrixes.m_Buffer;
			//                 *(_OWORD *)&m_Buffer[v61] = v57;
			//                 *(_OWORD *)&m_Buffer[v61 + 16] = v58;
			//                 *(_OWORD *)&m_Buffer[v61 + 32] = v59;
			//                 *(_OWORD *)&m_Buffer[v61 + 48] = v60;
			//                 ++v9.fields.m_capsuleNum;
			//               }
			//             }
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v87 )
			//         {
			//           v14 = v67;
			//           ex = v87.ex;
			//           v15 = ex;
			//           if ( ex )
			//             sub_18000F780(ex);
			//           v6 = directionalLightIndex;
			//           v9 = this;
			//           v17 = v68;
			//           v10 = 0LL;
			//           v18 = (__m128)0x3F800000u;
			//           v7 = lightCullResult;
			//         }
			//       }
			//       ++v17;
			//     }
			//   }
			// }
			// 
		}

		public void GetCapsuleDatas(out int capsuleNum, out NativeArray<Vector4> data1, out NativeArray<Vector4> data2, out NativeArray<Vector4> data3, out NativeArray<Vector4> data4, out NativeArray<Matrix4x4> transforms)
		{
			// // Void GetCapsuleDatas(Int32 ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Matrix4x4] ByRef)
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::GetCapsuleDatas(
			//         HGCapsuleShadowManager *this,
			//         int32_t *capsuleNum,
			//         NativeArray_1_UnityEngine_Vector4_ *data1,
			//         NativeArray_1_UnityEngine_Vector4_ *data2,
			//         NativeArray_1_UnityEngine_Vector4_ *data3,
			//         NativeArray_1_UnityEngine_Vector4_ *data4,
			//         NativeArray_1_UnityEngine_Matrix4x4_ *transforms,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1768, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1768, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_684(
			//       Patch,
			//       (Object *)this,
			//       capsuleNum,
			//       data1,
			//       data2,
			//       data3,
			//       data4,
			//       transforms,
			//       0LL);
			//   }
			//   else
			//   {
			//     *capsuleNum = this.fields.m_capsuleNum;
			//     *data1 = this.fields.m_capsuleShadowData1;
			//     *data2 = this.fields.m_capsuleShadowData2;
			//     *data3 = this.fields.m_capsuleShadowData3;
			//     *data4 = this.fields.m_capsuleShadowData4;
			//     *transforms = this.fields.m_capsuleStencilWriterMatrixes;
			//   }
			// }
			// 
		}

		public Mesh GetSphereMesh()
		{
			// // Mesh GetSphereMesh()
			// Mesh *HG::Rendering::Runtime::HGCapsuleShadowManager::GetSphereMesh(HGCapsuleShadowManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1769, 0LL) )
			//     return this.fields.m_sphereMesh;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1769, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_355(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public Material GetCapsuleShadowMaterial()
		{
			// // Material GetCapsuleShadowMaterial()
			// Material *HG::Rendering::Runtime::HGCapsuleShadowManager::GetCapsuleShadowMaterial(
			//         HGCapsuleShadowManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1770, 0LL) )
			//     return this.fields.m_capsuleShadowCasterMaterial;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1770, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_685(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public MaterialPropertyBlock GetMaterialPropertyBlock()
		{
			// // MaterialPropertyBlock GetMaterialPropertyBlock()
			// MaterialPropertyBlock *HG::Rendering::Runtime::HGCapsuleShadowManager::GetMaterialPropertyBlock(
			//         HGCapsuleShadowManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1771, 0LL) )
			//     return this.fields.m_capsuleShadowPropertyBlock;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1771, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_129(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void RenderCapsuleShadow(CommandBuffer cmd, int shaderPass, TextureHandle gbufferNormalTexture)
		{
			// // Void RenderCapsuleShadow(CommandBuffer, Int32, TextureHandle)
			// void HG::Rendering::Runtime::HGCapsuleShadowManager::RenderCapsuleShadow(
			//         HGCapsuleShadowManager *this,
			//         CommandBuffer *cmd,
			//         int32_t shaderPass,
			//         TextureHandle *gbufferNormalTexture,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   MaterialPropertyBlock *m_capsuleShadowPropertyBlock; // rcx
			//   MaterialPropertyBlock *v11; // rdi
			//   int32_t CapsuleShadowData1; // edx
			//   int32_t CapsuleShadowData2; // edx
			//   int32_t CapsuleShadowData3; // edx
			//   int32_t CapsuleShadowData4; // edx
			//   MaterialPropertyBlock *v16; // rdi
			//   _DWORD *m_Ptr; // rax
			//   int32_t v18; // r14d
			//   Texture *v19; // rax
			//   int32_t m_capsuleNum; // edi
			//   MaterialPropertyBlock *v21; // rsi
			//   Material *m_capsuleShadowCasterMaterial; // r9
			//   Mesh *m_sphereMesh; // rdx
			//   NativeArray_1_UnityEngine_Matrix4x4_ m_capsuleStencilWriterMatrixes; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle m_capsuleShadowData1; // [rsp+58h] [rbp-B0h] BYREF
			//   _OWORD v27[7]; // [rsp+68h] [rbp-A0h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v28; // [rsp+D8h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919E6F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919E6F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1772, 0LL) )
			//   {
			//     if ( !this.fields.m_capsuleNum )
			//       return;
			//     m_capsuleShadowPropertyBlock = this.fields.m_capsuleShadowPropertyBlock;
			//     if ( m_capsuleShadowPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::Clear(m_capsuleShadowPropertyBlock, 1, 0LL);
			//       v11 = this.fields.m_capsuleShadowPropertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( v11 )
			//       {
			//         CapsuleShadowData1 = static_fields._CapsuleShadowData1;
			//         m_capsuleShadowData1 = (TextureHandle)this.fields.m_capsuleShadowData1;
			//         UnityEngine::MaterialPropertyBlock::SetVectorArray(
			//           v11,
			//           CapsuleShadowData1,
			//           (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
			//           0LL);
			//         m_capsuleShadowPropertyBlock = this.fields.m_capsuleShadowPropertyBlock;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( m_capsuleShadowPropertyBlock )
			//         {
			//           CapsuleShadowData2 = static_fields._CapsuleShadowData2;
			//           m_capsuleShadowData1 = (TextureHandle)this.fields.m_capsuleShadowData2;
			//           UnityEngine::MaterialPropertyBlock::SetVectorArray(
			//             m_capsuleShadowPropertyBlock,
			//             CapsuleShadowData2,
			//             (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
			//             0LL);
			//           m_capsuleShadowPropertyBlock = this.fields.m_capsuleShadowPropertyBlock;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           if ( m_capsuleShadowPropertyBlock )
			//           {
			//             CapsuleShadowData3 = static_fields._CapsuleShadowData3;
			//             m_capsuleShadowData1 = (TextureHandle)this.fields.m_capsuleShadowData3;
			//             UnityEngine::MaterialPropertyBlock::SetVectorArray(
			//               m_capsuleShadowPropertyBlock,
			//               CapsuleShadowData3,
			//               (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
			//               0LL);
			//             m_capsuleShadowPropertyBlock = this.fields.m_capsuleShadowPropertyBlock;
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( m_capsuleShadowPropertyBlock )
			//             {
			//               CapsuleShadowData4 = static_fields._CapsuleShadowData4;
			//               m_capsuleShadowData1 = (TextureHandle)this.fields.m_capsuleShadowData4;
			//               UnityEngine::MaterialPropertyBlock::SetVectorArray(
			//                 m_capsuleShadowPropertyBlock,
			//                 CapsuleShadowData4,
			//                 (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//               if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(gbufferNormalTexture, 0LL) )
			//               {
			//                 v16 = this.fields.m_capsuleShadowPropertyBlock;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 m_capsuleShadowPropertyBlock = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                 m_Ptr = m_capsuleShadowPropertyBlock[22].fields.m_Ptr;
			//                 if ( !m_Ptr )
			//                   goto LABEL_19;
			//                 if ( m_Ptr[6] <= 1u )
			//                   sub_180070270(m_capsuleShadowPropertyBlock, static_fields);
			//                 v18 = m_Ptr[9];
			//                 sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//                 m_capsuleShadowData1 = *gbufferNormalTexture;
			//                 v19 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&m_capsuleShadowData1, 0LL);
			//                 if ( !v16 )
			//                   goto LABEL_19;
			//                 UnityEngine::MaterialPropertyBlock::SetTextureImpl(v16, v18, v19, 0LL);
			//               }
			//               m_capsuleNum = this.fields.m_capsuleNum;
			//               v21 = this.fields.m_capsuleShadowPropertyBlock;
			//               sub_1802F01E0(v27, 0LL, 112LL);
			//               if ( cmd )
			//               {
			//                 m_capsuleShadowCasterMaterial = this.fields.m_capsuleShadowCasterMaterial;
			//                 m_sphereMesh = this.fields.m_sphereMesh;
			//                 *(_OWORD *)&v28.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v27[1];
			//                 *(_OWORD *)&v28.hasValue = v27[0];
			//                 *(_OWORD *)&v28.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v27[3];
			//                 *(_OWORD *)&v28.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v27[2];
			//                 *(_OWORD *)&v28.value.m_RasterState.m_OffsetFactor = v27[5];
			//                 m_capsuleStencilWriterMatrixes = this.fields.m_capsuleStencilWriterMatrixes;
			//                 *(_OWORD *)&v28.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v27[4];
			//                 m_capsuleShadowData1 = (TextureHandle)m_capsuleStencilWriterMatrixes;
			//                 *(_OWORD *)&v28.value.m_StencilState.m_FailOperationFront = v27[6];
			//                 UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//                   cmd,
			//                   m_sphereMesh,
			//                   0,
			//                   m_capsuleShadowCasterMaterial,
			//                   shaderPass,
			//                   (NativeArray_1_UnityEngine_Matrix4x4_ *)&m_capsuleShadowData1,
			//                   m_capsuleNum,
			//                   v21,
			//                   &v28,
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(m_capsuleShadowPropertyBlock, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1772, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   m_capsuleShadowData1 = *gbufferNormalTexture;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(
			//     Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     shaderPass,
			//     &m_capsuleShadowData1,
			//     0LL);
			// }
			// 
		}

		private const int MAX_CAPSULE_NUM = 256;

		private int m_capsuleHelperNum;

		private int m_capsuleNum;

		private NativeArray<Vector4> m_capsuleShadowData1;

		private NativeArray<Vector4> m_capsuleShadowData2;

		private NativeArray<Vector4> m_capsuleShadowData3;

		private NativeArray<Vector4> m_capsuleShadowData4;

		private List<HGCapsuleShadowHelper> m_capsuleShadowHelpers;

		private NativeArray<Matrix4x4> m_capsuleStencilWriterMatrixes;

		private Material m_capsuleShadowCasterMaterial;

		private Mesh m_sphereMesh;

		private MaterialPropertyBlock m_capsuleShadowPropertyBlock;

		public Vector4 fakeSphericalLightSource;
	}
}
