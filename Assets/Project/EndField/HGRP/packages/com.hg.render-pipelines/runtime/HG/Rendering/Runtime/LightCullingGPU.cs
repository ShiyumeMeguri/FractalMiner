using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class LightCullingGPU : LightCulling
	{
		public LightCullingGPU()
		{
			// // LightCullingGPU()
			// void HG::Rendering::Runtime::LightCullingGPU::LightCullingGPU(LightCullingGPU *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct Il2CppType *v4; // rbx
			//   int32_t NUM_FLOAT4_PUNCTUALIGHT_DESC; // esi
			//   __int64 v6; // rdx
			//   Type *TypeFromHandle; // rbx
			//   int v8; // eax
			//   LightCulling__StaticFields *static_fields; // rdx
			//   HGCamera *v10; // r9
			//   _BYTE v11[20]; // [rsp+30h] [rbp-28h] BYREF
			//   int v12; // [rsp+44h] [rbp-14h]
			//   MethodInfo *v13; // [rsp+80h] [rbp+28h]
			//   MethodInfo *v14; // [rsp+88h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDCEB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//     sub_18003C530(&TypeInfo::System::Type);
			//     sub_18003C530(&TypeRef::Unity::Mathematics::float4);
			//     byte_18D8EDCEB = 1;
			//   }
			//   *(_QWORD *)&this.fields.m_binningXYShaderKernel = -1LL;
			//   *(_QWORD *)&this.fields.m_binningXYShaderWithTileKernel = -1LL;
			//   if ( !TypeInfo::HG::Rendering::Runtime::LightCulling._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::LightCulling, method);
			//   HG::Rendering::Runtime::LightCulling::LightCulling((LightCulling *)this, 0LL);
			//   *(_OWORD *)v11 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_quaternion_ *)v11,
			//     TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC << 8,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//   this.fields.m_punctualLightDescArray = *(NativeArray_1_Unity_Mathematics_float4_ *)v11;
			//   v4 = TypeRef::Unity::Mathematics::float4;
			//   NUM_FLOAT4_PUNCTUALIGHT_DESC = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC;
			//   if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Type, v3);
			//   TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v4, 0LL);
			//   if ( !TypeInfo::System::Runtime::InteropServices::Marshal._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Runtime::InteropServices::Marshal, v6);
			//   v8 = sub_1800981B0(TypeFromHandle);
			//   *(_QWORD *)&v11[12] = 0LL;
			//   *(_DWORD *)&v11[8] = 0;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//   v12 = 0;
			//   *(_DWORD *)v11 = NUM_FLOAT4_PUNCTUALIGHT_DESC << 8;
			//   *(_DWORD *)&v11[4] = static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC * v8;
			//   *(_OWORD *)&this.fields.m_punctualLightDesc.count = *(unsigned __int64 *)v11;
			//   this.fields.m_punctualLightDesc.name = 0LL;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_punctualLightDesc.name,
			//     (HGRenderPathBase_HGRenderPathResources *)static_fields,
			//     0LL,
			//     v10,
			//     v13,
			//     v14);
			// }
			// 
		}

		public override void Dispose()
		{
		}

		public override void PrepareRenderGraphBuffers(HGRenderGraph renderGraph, HGRenderGraphBuilder builder)
		{
			// // Void PrepareRenderGraphBuffers(HGRenderGraph, HGRenderGraphBuilder)
			// void HG::Rendering::Runtime::LightCullingGPU::PrepareRenderGraphBuffers(
			//         LightCullingGPU *this,
			//         HGRenderGraph *renderGraph,
			//         HGRenderGraphBuilder *builder,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm1
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ComputeBufferHandle v10; // rax
			//   bool v11; // zf
			//   __int128 v12; // xmm1
			//   unsigned int v13; // eax
			//   bool DrawTileArgsBuffers; // al
			//   ComputeBuffer *v15; // rdx
			//   ComputeBufferHandle v16; // rax
			//   ComputeBuffer *v17; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int128 v21; // xmm1
			//   ComputeBufferHandle input; // [rsp+30h] [rbp-50h] BYREF
			//   ComputeBuffer *current; // [rsp+38h] [rbp-48h] BYREF
			//   ComputeBuffer *next; // [rsp+40h] [rbp-40h] BYREF
			//   HGRenderGraphBuilder desc; // [rsp+50h] [rbp-30h] BYREF
			//   __int128 v26; // [rsp+70h] [rbp-10h]
			// 
			//   current = 0LL;
			//   next = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1616, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1616, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     v21 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&desc.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&desc.m_RenderGraph = v21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_613(Patch, (Object *)this, (Object *)renderGraph, &desc, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&desc.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&desc.m_RenderGraph = v7;
			//     HG::Rendering::Runtime::LightCulling::PrepareRenderGraphBuffers((LightCulling *)this, renderGraph, &desc, 0LL);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//               renderGraph,
			//               &this.fields.m_punctualLightDesc,
			//               0LL);
			//     v10 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(builder, &input, 0LL);
			//     v11 = !this.fields._.m_outputTileDrawBuffers;
			//     this.fields.m_punctualLightDescBuffer = v10;
			//     if ( !v11 )
			//     {
			//       v12 = *(_OWORD *)&this.fields._.m_binningConstants.nearClipPlane;
			//       v13 = 2 * HIDWORD(*(_QWORD *)&this.fields._.m_binningConstants.lightCount);
			//       *(_QWORD *)&desc.m_Disposed = *(_QWORD *)&this.fields._.m_binningConstants.numTilesY;
			//       *(HGRenderGraphResourceRegistry **)((char *)&desc.m_Resources + 4) = 0LL;
			//       HIDWORD(desc.m_RenderGraph) = 0;
			//       desc.m_RenderPass = (HGRenderGraphPass *)(v13 | 0x400000000LL);
			//       v26 = v12;
			//       LODWORD(desc.m_Resources) = 16;
			//       input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                 renderGraph,
			//                 (ComputeBufferDesc *)&desc,
			//                 0LL);
			//       this.fields._.m_tileInstanceIndicesBufferHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                                                            builder,
			//                                                            &input,
			//                                                            0LL);
			//       DrawTileArgsBuffers = HG::Rendering::Runtime::LightCullingGPU::GetDrawTileArgsBuffers(this, &current, &next, 0LL);
			//       v15 = current;
			//       this.fields._.m_needClearArgsBuffer = DrawTileArgsBuffers;
			//       input = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(renderGraph, v15, 0LL);
			//       v16 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(builder, &input, 0LL);
			//       v17 = next;
			//       this.fields._.m_drawTileArgsBufferHandle = v16;
			//       input = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(renderGraph, v17, 0LL);
			//       this.fields._.m_drawTileArgsBufferNextFrameHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                                                              builder,
			//                                                              &input,
			//                                                              0LL);
			//     }
			//   }
			// }
			// 
		}

		protected override void _PreparePunctualLightDescInternal(in VisibleLight punctualLight, HGCamera hgCamera, int lightIndex)
		{
			// // Void _PreparePunctualLightDescInternal(VisibleLight ByRef, HGCamera, Int32)
			// void HG::Rendering::Runtime::LightCullingGPU::_PreparePunctualLightDescInternal(
			//         LightCullingGPU *this,
			//         VisibleLight *punctualLight,
			//         HGCamera *hgCamera,
			//         int32_t lightIndex,
			//         MethodInfo *method)
			// {
			//   Camera *camera; // rdx
			//   __int64 v10; // rcx
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   _OWORD *p_m00; // rbx
			//   Vector4 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   Vector4 *AsVector4; // rax
			//   Vector4 v17; // xmm6
			//   Vector4 v18; // xmm7
			//   __m128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   float range_Injected; // xmm6_4
			//   double v29; // xmm0_8
			//   float x; // xmm9_4
			//   float v31; // xmm0_4
			//   __int128 v32; // xmm1
			//   float m_ScreenSpaceArea; // eax
			//   float v34; // xmm10_4
			//   float y; // xmm11_4
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   Vector3 *v43; // rax
			//   __int128 v44; // xmm1
			//   float v45; // edi
			//   __int64 v46; // xmm7_8
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   Vector3 *Forward; // rax
			//   __int64 v55; // xmm6_8
			//   float v56; // ebx
			//   MethodInfo *v57; // r9
			//   Vector3 *v58; // rax
			//   float v59; // xmm2_4
			//   __m128 v60; // xmm0
			//   __m128 v61; // xmm1
			//   MethodInfo *v62; // r9
			//   Vector3 *v63; // rax
			//   __int128 v64; // xmm1
			//   float v65; // ebx
			//   __int64 v66; // xmm3_8
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm0
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   Vector3 *Right; // rax
			//   MethodInfo *v75; // r8
			//   Vector4 *v76; // rax
			//   __int128 v77; // xmm1
			//   __m128i v78; // xmm7
			//   __int128 v79; // xmm0
			//   __int128 v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int128 v82; // xmm1
			//   __int128 v83; // xmm0
			//   __int128 v84; // xmm1
			//   __int128 v85; // xmm0
			//   Vector3 *Up; // rax
			//   MethodInfo *v87; // r8
			//   __m128i v88; // xmm6
			//   __int128 v89; // xmm1
			//   float v90; // eax
			//   __int128 v91; // xmm0
			//   __int128 v92; // xmm1
			//   __int128 v93; // xmm0
			//   __int128 v94; // xmm1
			//   __int128 v95; // xmm0
			//   __int128 v96; // xmm1
			//   __int128 v97; // xmm0
			//   Vector3 *v98; // rax
			//   MethodInfo *v99; // r8
			//   Vector4 *v100; // rax
			//   __int128 v101; // xmm6
			//   __int128 v102; // xmm7
			//   __int128 v103; // xmm8
			//   __int128 v104; // xmm12
			//   Vector3 *cullingBoxHalfExtents; // rax
			//   float z; // edi
			//   Vector3 *cullingBoxRelativePosition; // rax
			//   __int64 v108; // xmm6_8
			//   float v109; // ebx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v111; // xmm1
			//   __int128 v112; // xmm0
			//   __int128 v113; // xmm1
			//   Vector3 *Position; // rax
			//   MethodInfo *v115; // r9
			//   Vector3 *v116; // rax
			//   __int64 v117; // xmm6_8
			//   float v118; // ebx
			//   Vector3 *cullingBoxOrientation; // rax
			//   MethodInfo *v120; // rax
			//   Vector3 *one; // rax
			//   Quaternion *v122; // rdx
			//   Quaternion v123; // xmm0
			//   Matrix4x4 *v124; // rax
			//   Matrix4x4 *v125; // rax
			//   __int128 v126; // xmm1
			//   __int128 v127; // xmm0
			//   __int128 v128; // xmm1
			//   Matrix4x4 *v129; // rax
			//   __int128 v130; // xmm1
			//   __int128 v131; // xmm0
			//   __int128 v132; // xmm1
			//   __m128 v133; // xmm6
			//   __m128 v134; // xmm7
			//   Vector3 *v135; // rax
			//   float3 *xyz; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v138; // [rsp+38h] [rbp-D0h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+48h] [rbp-C0h] BYREF
			//   __m128i v140; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector4 v141; // [rsp+68h] [rbp-A0h] BYREF
			//   Quaternion v142; // [rsp+78h] [rbp-90h] BYREF
			//   Vector4 v143; // [rsp+88h] [rbp-80h] BYREF
			//   float4 sphereParams; // [rsp+98h] [rbp-70h] BYREF
			//   Vector4 v145; // [rsp+A8h] [rbp-60h] BYREF
			//   Matrix4x4 v146; // [rsp+B8h] [rbp-50h] BYREF
			//   Matrix4x4 v147; // [rsp+F8h] [rbp-10h] BYREF
			//   Matrix4x4 v148; // [rsp+138h] [rbp+30h] BYREF
			//   VisibleLight v149; // [rsp+178h] [rbp+70h] BYREF
			//   Matrix4x4 v150[2]; // [rsp+218h] [rbp+110h] BYREF
			// 
			//   if ( !byte_18D919E29 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     byte_18D919E29 = 1;
			//   }
			//   sphereParams = 0LL;
			//   sub_1802F01E0(&v147, 0LL, 64LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1618, 0LL) )
			//   {
			//     HG::Rendering::Runtime::LightCullingGPU::GetLightSphere(punctualLight, &sphereParams, 0LL);
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v148, camera, 0LL);
			//         v143.x = sphereParams.x;
			//         p_m00 = (_OWORD *)&worldToCameraMatrix.m00;
			//         *(_QWORD *)&v143.y = *(_QWORD *)&sphereParams.y;
			//         v143.w = 1.0;
			//         v13 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                  &v145,
			//                  (CinemachineSmoothPath_Waypoint *)&v143,
			//                  0LL);
			//         *(_OWORD *)&v146.m00 = *p_m00;
			//         v14 = p_m00[2];
			//         v143 = v13;
			//         v15 = p_m00[1];
			//         *(_OWORD *)&v146.m02 = v14;
			//         *(_OWORD *)&v146.m01 = v15;
			//         *(_OWORD *)&v146.m03 = p_m00[3];
			//         v143 = *UnityEngine::Matrix4x4::op_Multiply(&v145, &v146, &v143, 0LL);
			//         AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                       &v145,
			//                       (CinemachineSmoothPath_Waypoint *)&v143,
			//                       0LL);
			//         v17 = 0LL;
			//         v18 = 0LL;
			//         v143 = 0LL;
			//         v19 = (__m128)_mm_loadu_si128((const __m128i *)AsVector4);
			//         _unity_self = punctualLight.hgSharedLightData;
			//         *(float *)&AsVector4 = punctualLight.m_ScreenSpaceArea;
			//         LODWORD(sphereParams.y) = _mm_shuffle_ps(v19, v19, 85).m128_u32[0];
			//         v20 = *(_OWORD *)&punctualLight.m_LightType;
			//         LODWORD(sphereParams.x) = v19.m128_i32[0];
			//         *(_OWORD *)&v149.m_LightType = v20;
			//         v21 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//         LODWORD(sphereParams.z) = _mm_shuffle_ps(v19, v19, 170).m128_u32[0];
			//         v22 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//         v145 = 0LL;
			//         *(_OWORD *)&v149.m_FinalColor.a = v22;
			//         v23 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//         *(_OWORD *)&v149.m_ScreenRect.m_Height = v21;
			//         v24 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//         *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v23;
			//         v25 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//         *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v24;
			//         v26 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//         *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v25;
			//         v27 = *(_OWORD *)&punctualLight.m_InstanceId;
			//         *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v26;
			//         *(_OWORD *)&v149.m_LightPriority = *(_OWORD *)&punctualLight.m_LightPriority;
			//         *(_OWORD *)&v149.m_InstanceId = v27;
			//         LODWORD(v149.m_ScreenSpaceArea) = (_DWORD)AsVector4;
			//         if ( v149.m_LightType && !UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//           goto LABEL_13;
			//         range_Injected = UnityEngine::HGSharedLightData::get_range_Injected(&_unity_self, 0LL);
			//         UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
			//         v29 = sub_1826D6280();
			//         x = *(float *)&v29 * range_Injected;
			//         if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//         {
			//           cullingBoxHalfExtents = UnityEngine::HGSharedLightData::get_cullingBoxHalfExtents(
			//                                     (Vector3 *)&v138,
			//                                     &_unity_self,
			//                                     0LL);
			//           z = cullingBoxHalfExtents.z;
			//           *(_QWORD *)&v141.x = *(_QWORD *)&cullingBoxHalfExtents.x;
			//           cullingBoxRelativePosition = UnityEngine::HGSharedLightData::get_cullingBoxRelativePosition(
			//                                          (Vector3 *)&v138,
			//                                          &_unity_self,
			//                                          0LL);
			//           v108 = *(_QWORD *)&cullingBoxRelativePosition.x;
			//           v109 = cullingBoxRelativePosition.z;
			//           localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v148, &_unity_self, 0LL);
			//           v111 = *(_OWORD *)&localToWorldMatrix.m01;
			//           *(_OWORD *)&v146.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//           v112 = *(_OWORD *)&localToWorldMatrix.m02;
			//           *(_OWORD *)&v146.m01 = v111;
			//           v113 = *(_OWORD *)&localToWorldMatrix.m03;
			//           *(_OWORD *)&v146.m02 = v112;
			//           *(_OWORD *)&v146.m03 = v113;
			//           Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v140, &v146, 0LL);
			//           *(_QWORD *)&v112 = *(_QWORD *)&Position.x;
			//           *(float *)&Position = Position.z;
			//           v138.m128i_i64[0] = v112;
			//           v138.m128i_i32[2] = (int)Position;
			//           v140.m128i_i64[0] = v108;
			//           *(float *)&v140.m128i_i32[2] = v109;
			//           v116 = UnityEngine::Vector3::op_Addition((Vector3 *)&v142, (Vector3 *)&v140, (Vector3 *)&v138, v115);
			//           v117 = *(_QWORD *)&v116.x;
			//           v118 = v116.z;
			//           cullingBoxOrientation = UnityEngine::HGSharedLightData::get_cullingBoxOrientation(
			//                                     (Vector3 *)&v142,
			//                                     &_unity_self,
			//                                     0LL);
			//           *(_QWORD *)&v112 = *(_QWORD *)&cullingBoxOrientation.x;
			//           *(float *)&cullingBoxOrientation = cullingBoxOrientation.z;
			//           v138.m128i_i64[0] = v112;
			//           v138.m128i_i32[2] = (int)cullingBoxOrientation;
			//           v120 = (MethodInfo *)sub_182504CA0(&v140, &v138);
			//           one = UnityEngine::Vector3::get_one((Vector3 *)&v142, v120);
			//           v123 = *v122;
			//           v140.m128i_i64[0] = v117;
			//           *(_QWORD *)&v113 = *(_QWORD *)&one.x;
			//           v138.m128i_i32[2] = LODWORD(one.z);
			//           v138.m128i_i64[0] = v113;
			//           v142 = v123;
			//           *(float *)&v140.m128i_i32[2] = v118;
			//           v124 = UnityEngine::Matrix4x4::TRS(&v148, (Vector3 *)&v140, &v142, (Vector3 *)&v138, 0LL);
			//           y = v141.y;
			//           x = v141.x;
			//           v34 = z;
			//           v104 = *(_OWORD *)&v124.m00;
			//           v103 = *(_OWORD *)&v124.m01;
			//           v102 = *(_OWORD *)&v124.m02;
			//           v101 = *(_OWORD *)&v124.m03;
			//         }
			//         else
			//         {
			//           v31 = UnityEngine::HGSharedLightData::get_range_Injected(&_unity_self, 0LL);
			//           v32 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//           m_ScreenSpaceArea = punctualLight.m_ScreenSpaceArea;
			//           v34 = v31 * 0.5;
			//           y = x;
			//           *(_OWORD *)&v149.m_LightType = *(_OWORD *)&punctualLight.m_LightType;
			//           v36 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//           *(_OWORD *)&v149.m_FinalColor.a = v32;
			//           v37 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//           *(_OWORD *)&v149.m_ScreenRect.m_Height = v36;
			//           v38 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v37;
			//           v39 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v38;
			//           v40 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v39;
			//           v41 = *(_OWORD *)&punctualLight.m_LightPriority;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v40;
			//           v42 = *(_OWORD *)&punctualLight.m_InstanceId;
			//           *(_OWORD *)&v149.m_LightPriority = v41;
			//           *(_OWORD *)&v149.m_InstanceId = v42;
			//           v149.m_ScreenSpaceArea = m_ScreenSpaceArea;
			//           v43 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetPosition((Vector3 *)&v141, &v149, 0LL);
			//           v44 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//           v45 = v43.z;
			//           v46 = *(_QWORD *)&v43.x;
			//           *(float *)&v43 = punctualLight.m_ScreenSpaceArea;
			//           *(_OWORD *)&v149.m_LightType = *(_OWORD *)&punctualLight.m_LightType;
			//           v47 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//           *(_OWORD *)&v149.m_FinalColor.a = v44;
			//           v48 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//           *(_OWORD *)&v149.m_ScreenRect.m_Height = v47;
			//           v49 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v48;
			//           v50 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v49;
			//           v51 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v50;
			//           v52 = *(_OWORD *)&punctualLight.m_LightPriority;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v51;
			//           v53 = *(_OWORD *)&punctualLight.m_InstanceId;
			//           *(_OWORD *)&v149.m_LightPriority = v52;
			//           *(_OWORD *)&v149.m_InstanceId = v53;
			//           LODWORD(v149.m_ScreenSpaceArea) = (_DWORD)v43;
			//           Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward((Vector3 *)&v141, &v149, 0LL);
			//           v55 = *(_QWORD *)&Forward.x;
			//           v56 = Forward.z;
			//           *(float *)&v53 = UnityEngine::HGSharedLightData::get_range_Injected(&_unity_self, 0LL);
			//           v140.m128i_i64[0] = v55;
			//           *(float *)&v140.m128i_i32[2] = v56;
			//           v58 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v141, (Vector3 *)&v140, *(float *)&v53, v57);
			//           v59 = v58.z;
			//           v140.m128i_i64[0] = *(_QWORD *)&v58.x;
			//           v60 = (__m128)v140.m128i_u32[0];
			//           v61 = (__m128)v140.m128i_u32[1];
			//           v60.m128_f32[0] = *(float *)v140.m128i_i32 * 0.5;
			//           v61.m128_f32[0] = *(float *)&v140.m128i_i32[1] * 0.5;
			//           v140.m128i_i64[0] = _mm_unpacklo_ps(v60, v61).m128_u64[0];
			//           *(float *)&v140.m128i_i32[2] = v59 * 0.5;
			//           v138.m128i_i64[0] = v46;
			//           *(float *)&v138.m128i_i32[2] = v45;
			//           v63 = UnityEngine::Vector3::op_Addition((Vector3 *)&v141, (Vector3 *)&v138, (Vector3 *)&v140, v62);
			//           v64 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//           v65 = v63.z;
			//           v66 = *(_QWORD *)&v63.x;
			//           *(float *)&v63 = punctualLight.m_ScreenSpaceArea;
			//           *(_OWORD *)&v149.m_LightType = *(_OWORD *)&punctualLight.m_LightType;
			//           v67 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//           *(_OWORD *)&v149.m_FinalColor.a = v64;
			//           v68 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//           *(_OWORD *)&v149.m_ScreenRect.m_Height = v67;
			//           v69 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v68;
			//           v70 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v69;
			//           v71 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v70;
			//           v72 = *(_OWORD *)&punctualLight.m_LightPriority;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v71;
			//           v73 = *(_OWORD *)&punctualLight.m_InstanceId;
			//           *(_OWORD *)&v149.m_LightPriority = v72;
			//           *(_OWORD *)&v149.m_InstanceId = v73;
			//           LODWORD(v149.m_ScreenSpaceArea) = (_DWORD)v63;
			//           v140.m128i_i64[0] = v66;
			//           Right = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetRight((Vector3 *)&v141, &v149, 0LL);
			//           *(_QWORD *)&v73 = *(_QWORD *)&Right.x;
			//           *(float *)&Right = Right.z;
			//           v138.m128i_i64[0] = v73;
			//           v138.m128i_i32[2] = (int)Right;
			//           v76 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v142, (Vector3 *)&v138, v75);
			//           v77 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//           v78 = _mm_loadu_si128((const __m128i *)v76);
			//           *(float *)&v76 = punctualLight.m_ScreenSpaceArea;
			//           *(_OWORD *)&v149.m_LightType = *(_OWORD *)&punctualLight.m_LightType;
			//           v79 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//           *(_OWORD *)&v149.m_FinalColor.a = v77;
			//           v80 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//           *(_OWORD *)&v149.m_ScreenRect.m_Height = v79;
			//           v81 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v80;
			//           v82 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v81;
			//           v83 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v82;
			//           v84 = *(_OWORD *)&punctualLight.m_LightPriority;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v83;
			//           v85 = *(_OWORD *)&punctualLight.m_InstanceId;
			//           *(_OWORD *)&v149.m_LightPriority = v84;
			//           *(_OWORD *)&v149.m_InstanceId = v85;
			//           LODWORD(v149.m_ScreenSpaceArea) = (_DWORD)v76;
			//           Up = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetUp((Vector3 *)&v141, &v149, 0LL);
			//           *(_QWORD *)&v85 = *(_QWORD *)&Up.x;
			//           *(float *)&Up = Up.z;
			//           v138.m128i_i64[0] = v85;
			//           v138.m128i_i32[2] = (int)Up;
			//           v88 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                    (Vector4 *)&v142,
			//                                                    (Vector3 *)&v138,
			//                                                    v87));
			//           v89 = *(_OWORD *)&punctualLight.m_FinalColor.a;
			//           v90 = punctualLight.m_ScreenSpaceArea;
			//           *(_OWORD *)&v149.m_LightType = *(_OWORD *)&punctualLight.m_LightType;
			//           v91 = *(_OWORD *)&punctualLight.m_ScreenRect.m_Height;
			//           *(_OWORD *)&v149.m_FinalColor.a = v89;
			//           v92 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m30;
			//           *(_OWORD *)&v149.m_ScreenRect.m_Height = v91;
			//           v93 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m31;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m30 = v92;
			//           v94 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m32;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m31 = v93;
			//           v95 = *(_OWORD *)&punctualLight.m_LocalToWorldMatrix.m33;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m32 = v94;
			//           v96 = *(_OWORD *)&punctualLight.m_LightPriority;
			//           *(_OWORD *)&v149.m_LocalToWorldMatrix.m33 = v95;
			//           v97 = *(_OWORD *)&punctualLight.m_InstanceId;
			//           *(_OWORD *)&v149.m_LightPriority = v96;
			//           *(_OWORD *)&v149.m_InstanceId = v97;
			//           v149.m_ScreenSpaceArea = v90;
			//           v98 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward((Vector3 *)&v141, &v149, 0LL);
			//           v142.z = v65;
			//           *(_QWORD *)&v97 = *(_QWORD *)&v98.x;
			//           *(float *)&v98 = v98.z;
			//           v138.m128i_i64[0] = v97;
			//           *(_QWORD *)&v142.x = v140.m128i_i64[0];
			//           v142.w = 1.0;
			//           v138.m128i_i32[2] = (int)v98;
			//           v100 = UnityEngine::Vector4::op_Implicit(&v141, (Vector3 *)&v138, v99);
			//           v138 = v88;
			//           v140 = v78;
			//           v141 = *v100;
			//           UnityEngine::Matrix4x4::Matrix4x4(&v147, (Vector4 *)&v140, (Vector4 *)&v138, &v141, (Vector4 *)&v142, 0LL);
			//           v101 = *(_OWORD *)&v147.m03;
			//           v102 = *(_OWORD *)&v147.m02;
			//           v103 = *(_OWORD *)&v147.m01;
			//           v104 = *(_OWORD *)&v147.m00;
			//         }
			//         camera = hgCamera.fields.camera;
			//         if ( camera )
			//         {
			//           v125 = UnityEngine::Camera::get_worldToCameraMatrix(v150, camera, 0LL);
			//           *(_OWORD *)&v146.m00 = v104;
			//           *(_OWORD *)&v146.m01 = v103;
			//           *(_OWORD *)&v146.m02 = v102;
			//           v126 = *(_OWORD *)&v125.m01;
			//           *(_OWORD *)&v148.m00 = *(_OWORD *)&v125.m00;
			//           v127 = *(_OWORD *)&v125.m02;
			//           *(_OWORD *)&v148.m01 = v126;
			//           v128 = *(_OWORD *)&v125.m03;
			//           *(_OWORD *)&v148.m02 = v127;
			//           *(_OWORD *)&v148.m03 = v128;
			//           *(_OWORD *)&v146.m03 = v101;
			//           v129 = UnityEngine::Matrix4x4::op_Multiply(v150, &v148, &v146, 0LL);
			//           v130 = *(_OWORD *)&v129.m01;
			//           *(_OWORD *)&v147.m00 = *(_OWORD *)&v129.m00;
			//           v131 = *(_OWORD *)&v129.m02;
			//           *(_OWORD *)&v147.m01 = v130;
			//           v132 = *(_OWORD *)&v129.m03;
			//           *(_OWORD *)&v147.m02 = v131;
			//           *(_OWORD *)&v147.m03 = v132;
			//           v133 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn(
			//                                                             (Vector4 *)&v142,
			//                                                             &v147,
			//                                                             0,
			//                                                             0LL));
			//           v134 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn(
			//                                                             (Vector4 *)&v142,
			//                                                             &v147,
			//                                                             1,
			//                                                             0LL));
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           v145.x = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(1.0, v133.m128_f32[0], 0LL);
			//           v145.y = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                      _mm_shuffle_ps(v133, v133, 85).m128_f32[0],
			//                      _mm_shuffle_ps(v133, v133, 170).m128_f32[0],
			//                      0LL);
			//           v145.z = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                      v134.m128_f32[0],
			//                      _mm_shuffle_ps(v134, v134, 85).m128_f32[0],
			//                      0LL);
			//           v145.w = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                      _mm_shuffle_ps(v134, v134, 170).m128_f32[0],
			//                      x,
			//                      0LL);
			//           v143.w = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(y, v34, 0LL);
			//           v135 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v142, &v147, 0LL);
			//           *(_QWORD *)&v131 = *(_QWORD *)&v135.x;
			//           *(float *)&v135 = v135.z;
			//           *(_QWORD *)&v141.x = v131;
			//           LODWORD(v141.z) = (_DWORD)v135;
			//           xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v142, (float4 *)&v141, 0LL);
			//           v17 = v145;
			//           *(_QWORD *)&v141.x = *(_QWORD *)&xyz.x;
			//           *(_QWORD *)&v143.x = *(_QWORD *)&v141.x;
			//           v143.z = xyz.z;
			//           v18 = v143;
			// LABEL_13:
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//           *(float4 *)&this.fields.m_punctualLightDescArray.m_Buffer[16
			//                                                                    * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC
			//                                                                    * lightIndex] = sphereParams;
			//           *(Vector4 *)&this.fields.m_punctualLightDescArray.m_Buffer[16
			//                                                                     * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC
			//                                                                     * lightIndex
			//                                                                     + 16] = v17;
			//           *(Vector4 *)&this.fields.m_punctualLightDescArray.m_Buffer[16
			//                                                                     * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT_DESC
			//                                                                     * lightIndex
			//                                                                     + 32] = v18;
			//           return;
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v10, camera);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1618, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_624(
			//     Patch,
			//     (Object *)this,
			//     punctualLight,
			//     (Object *)hgCamera,
			//     lightIndex,
			//     0LL);
			// }
			// 
		}

		protected override void _PrepareCPUDataInternal(HGCamera hgCamera, NativeArray<VisibleLight> visibleLights, NativeArray<int> lightIndices, int directionalLightIndex)
		{
			// // Void _PrepareCPUDataInternal(HGCamera, NativeArray`1[UnityEngine.Rendering.VisibleLight], NativeArray`1[System.Int32], Int32)
			// void HG::Rendering::Runtime::LightCullingGPU::_PrepareCPUDataInternal(
			//         LightCullingGPU *this,
			//         HGCamera *hgCamera,
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         NativeArray_1_System_Int32_ *lightIndices,
			//         int32_t directionalLightIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   Camera *camera; // rcx
			//   float aspect; // xmm7_4
			//   __int128 v13; // xmm6
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   float v18; // xmm0_4
			//   float v19; // xmm3_4
			//   float3 *v20; // rdx
			//   float3 *v21; // rcx
			//   float3 *v22; // r8
			//   float3 *v23; // r9
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v24; // xmm1
			//   NativeArray_1_System_Int32_ v25; // [rsp+40h] [rbp-88h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v26; // [rsp+50h] [rbp-78h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1622, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//         camera = hgCamera.fields.camera;
			//         if ( camera )
			//         {
			//           aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
			//           v13 = *(_OWORD *)&this.fields._.m_binningConstants.nearClipPlane;
			//           v18 = sub_1802ED290(v15, v14, v16, v17);
			//           v19 = (float)(v18 * *(float *)&v13) + (float)(v18 * *(float *)&v13);
			//           this.fields.m_gpuBinningConstants.nearPlaneParams.y = v19;
			//           this.fields.m_gpuBinningConstants.nearPlaneParams.x = v19 * aspect;
			//           this.fields.m_gpuBinningConstants.nearPlaneParams.z = (float)(v19
			//                                                                        / (float)(int)HIDWORD(*(_QWORD *)&this.fields._.m_binningConstants.actualWidth))
			//                                                                * COERCE_FLOAT(*(_OWORD *)&this.fields._.m_binningConstants.tileSize);
			//           this.fields.m_gpuBinningConstants.nearPlaneParams.w = sub_1802ECED0(v21, v20, v22, v23);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(camera, v10);
			//   }
			//   camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(1622, 0LL);
			//   if ( !camera )
			//     goto LABEL_7;
			//   v24 = *visibleLights;
			//   v25 = *lightIndices;
			//   v26 = v24;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_625(
			//     (ILFixDynamicMethodWrapper_2 *)camera,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     &v26,
			//     &v25,
			//     directionalLightIndex,
			//     0LL);
			// }
			// 
		}

		public override void PrepareGPUData(HGRenderGraphContext context, HGCamera hgCamera, float renderingScale, ComputeBufferHandle binningBuffer)
		{
			// // Void PrepareGPUData(HGRenderGraphContext, HGCamera, Single, ComputeBufferHandle)
			// void HG::Rendering::Runtime::LightCullingGPU::PrepareGPUData(
			//         LightCullingGPU *this,
			//         HGRenderGraphContext *context,
			//         HGCamera *hgCamera,
			//         float renderingScale,
			//         ComputeBufferHandle binningBuffer,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *static_fields; // rcx
			//   CommandBuffer *cmd; // r12
			//   int32_t v12; // ebx
			//   CBHandle *ConstantBuffer; // rax
			//   __m128i v14; // xmm7
			//   HGRenderPipeline *currentPipeline; // rax
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // r15
			//   ComputeShader *lightBinningXYCS; // r15
			//   int32_t m_clearArgsXYShaderKernel; // esi
			//   ComputeBufferHandle m_drawTileArgsBufferHandle; // rbx
			//   int32_t DrawTileArgsBuffer; // edi
			//   ComputeBuffer *v22; // rax
			//   int32_t v23; // edi
			//   ComputeBuffer *v24; // rax
			//   CBHandle *v25; // rax
			//   __m128i v26; // xmm6
			//   int32_t m_binningXYShaderWithTileKernel; // esi
			//   int32_t offset; // edi
			//   int32_t size; // r13d
			//   int32_t v30; // ebx
			//   ComputeBuffer *v31; // rax
			//   ComputeBufferHandle v32; // rbx
			//   int32_t v33; // edi
			//   ComputeBuffer *v34; // rax
			//   ComputeBuffer *v35; // rax
			//   ComputeBuffer *v36; // rax
			//   __m128 v37; // xmm6
			//   HGRenderPipeline *v38; // rax
			//   HGRenderPipelineRuntimeResources *v39; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v40; // rsi
			//   ComputeShader *lightBinningZCS; // rsi
			//   int32_t m_binningZShaderKernel; // edi
			//   int32_t v43; // ebx
			//   ComputeBuffer *v44; // rax
			//   int32_t v45; // [rsp+48h] [rbp-39h]
			//   int bufferId; // [rsp+4Ch] [rbp-35h]
			//   CBHandle v47[3]; // [rsp+50h] [rbp-31h] BYREF
			// 
			//   if ( !byte_18D919E2A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<Unity::Mathematics::float4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919E2A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1623, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       v12 = 16 * this.fields.m_punctualLightDescArray.m_Length;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                          v47,
			//                          &context.fields.renderContext,
			//                          v12,
			//                          0LL);
			//       v14 = *(__m128i *)&ConstantBuffer.bufferId;
			//       v47[0].ptr = ConstantBuffer.ptr;
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//         (Void *)v47[0].ptr,
			//         this.fields.m_punctualLightDescArray.m_Buffer,
			//         v12,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//       if ( currentPipeline )
			//       {
			//         defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
			//         if ( defaultResources )
			//         {
			//           shaders = defaultResources.fields.shaders;
			//           if ( shaders )
			//           {
			//             lightBinningXYCS = shaders.fields.lightBinningXYCS;
			//             HG::Rendering::Runtime::LightCullingGPU::_SetupKernelIndex(
			//               this,
			//               lightBinningXYCS,
			//               &this.fields.m_binningXYShaderKernel,
			//               0LL);
			//             HG::Rendering::Runtime::LightCullingGPU::_SetupTileKernelIndex(
			//               this,
			//               lightBinningXYCS,
			//               &this.fields.m_binningXYShaderWithTileKernel,
			//               0LL);
			//             HG::Rendering::Runtime::LightCullingGPU::_SetupClearKernelIndex(
			//               this,
			//               lightBinningXYCS,
			//               &this.fields.m_clearArgsXYShaderKernel,
			//               0LL);
			//             if ( this.fields._.m_outputTileDrawBuffers && this.fields._.m_needClearArgsBuffer )
			//             {
			//               this.fields._.m_needClearArgsBuffer = 0;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               v47[0].ptr = this.fields._._binningConstantsCBHandle_k__BackingField.ptr;
			//               static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               if ( !cmd )
			//                 goto LABEL_23;
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 HIDWORD(static_fields[6].fields.virtualMachine),
			//                 _mm_cvtsi128_si32(*(__m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.bufferId),
			//                 _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.bufferId, 4)),
			//                 _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.bufferId, 8)),
			//                 0LL);
			//               m_clearArgsXYShaderKernel = this.fields.m_clearArgsXYShaderKernel;
			//               m_drawTileArgsBufferHandle = this.fields._.m_drawTileArgsBufferHandle;
			//               DrawTileArgsBuffer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DrawTileArgsBuffer;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//               v22 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(m_drawTileArgsBufferHandle, 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 m_clearArgsXYShaderKernel,
			//                 DrawTileArgsBuffer,
			//                 v22,
			//                 0,
			//                 -1,
			//                 0LL);
			//               v23 = this.fields.m_clearArgsXYShaderKernel;
			//               m_drawTileArgsBufferHandle.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DrawTileArgsBufferNextFrame;
			//               v24 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
			//                       this.fields._.m_drawTileArgsBufferNextFrameHandle,
			//                       0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 v23,
			//                 m_drawTileArgsBufferHandle.handle.m_Value,
			//                 v24,
			//                 0,
			//                 -1,
			//                 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 this.fields.m_clearArgsXYShaderKernel,
			//                 1,
			//                 1,
			//                 1,
			//                 0LL);
			//             }
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             v25 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                     v47,
			//                     &context.fields.renderContext,
			//                     16,
			//                     0LL);
			//             v26 = *(__m128i *)&v25.bufferId;
			//             v47[0].ptr = v25.ptr;
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//               (Void *)v47[0].ptr,
			//               (Void *)&this.fields.m_gpuBinningConstants,
			//               16LL,
			//               0LL);
			//             if ( this.fields._.m_outputTileDrawBuffers )
			//               m_binningXYShaderWithTileKernel = this.fields.m_binningXYShaderWithTileKernel;
			//             else
			//               m_binningXYShaderWithTileKernel = this.fields.m_binningXYShaderKernel;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( cmd )
			//             {
			//               offset = _mm_cvtsi128_si32(_mm_srli_si128(v14, 4));
			//               size = _mm_cvtsi128_si32(_mm_srli_si128(v14, 8));
			//               v45 = offset;
			//               bufferId = _mm_cvtsi128_si32(v14);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 (int32_t)static_fields[7].monitor,
			//                 bufferId,
			//                 offset,
			//                 size,
			//                 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightBinningConstants,
			//                 this.fields._._binningConstantsCBHandle_k__BackingField.bufferId,
			//                 _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.bufferId, 4)),
			//                 _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.size)),
			//                 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPULightBinningConstants,
			//                 _mm_cvtsi128_si32(v26),
			//                 _mm_cvtsi128_si32(_mm_srli_si128(v26, 4)),
			//                 _mm_cvtsi128_si32(_mm_srli_si128(v26, 8)),
			//                 0LL);
			//               v30 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._BinningBuffer;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//               v31 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(binningBuffer, 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 m_binningXYShaderWithTileKernel,
			//                 v30,
			//                 v31,
			//                 0,
			//                 -1,
			//                 0LL);
			//               if ( this.fields._.m_outputTileDrawBuffers )
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 v32 = this.fields._.m_drawTileArgsBufferHandle;
			//                 v33 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DrawTileArgsBuffer;
			//                 sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//                 v34 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v32, 0LL);
			//                 UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                   cmd,
			//                   lightBinningXYCS,
			//                   m_binningXYShaderWithTileKernel,
			//                   v33,
			//                   v34,
			//                   0,
			//                   -1,
			//                   0LL);
			//                 v32.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DrawTileArgsBufferNextFrame;
			//                 v35 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
			//                         this.fields._.m_drawTileArgsBufferNextFrameHandle,
			//                         0LL);
			//                 UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                   cmd,
			//                   lightBinningXYCS,
			//                   m_binningXYShaderWithTileKernel,
			//                   v32.handle.m_Value,
			//                   v35,
			//                   0,
			//                   -1,
			//                   0LL);
			//                 v32.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._TileInstanceIndicesBuffer;
			//                 v36 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
			//                         this.fields._.m_tileInstanceIndicesBufferHandle,
			//                         0LL);
			//                 UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                   cmd,
			//                   lightBinningXYCS,
			//                   m_binningXYShaderWithTileKernel,
			//                   v32.handle.m_Value,
			//                   v36,
			//                   0,
			//                   -1,
			//                   0LL);
			//                 offset = v45;
			//               }
			//               v37 = *(__m128 *)&this.fields._.m_binningConstants.tileSize;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//               UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//                 cmd,
			//                 lightBinningXYCS,
			//                 m_binningXYShaderWithTileKernel,
			//                 ((int)_mm_shuffle_ps(v37, v37, 85).m128_f32[0]
			//                + TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.XYPLANE_BINNING_GROUP_SIZE
			//                - 1)
			//               / TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.XYPLANE_BINNING_GROUP_SIZE,
			//                 (TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.XYPLANE_BINNING_GROUP_SIZE
			//                - 1
			//                + (int)this.fields._.m_binningConstants.numTilesY)
			//               / TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.XYPLANE_BINNING_GROUP_SIZE,
			//                 1,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//               v38 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//               if ( v38 )
			//               {
			//                 v39 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v38, 0LL);
			//                 if ( v39 )
			//                 {
			//                   v40 = v39.fields.shaders;
			//                   if ( v40 )
			//                   {
			//                     lightBinningZCS = v40.fields.lightBinningZCS;
			//                     HG::Rendering::Runtime::LightCullingGPU::_SetupKernelIndex(
			//                       this,
			//                       lightBinningZCS,
			//                       &this.fields.m_binningZShaderKernel,
			//                       0LL);
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                     UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                       cmd,
			//                       lightBinningZCS,
			//                       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PunctualLights,
			//                       bufferId,
			//                       offset,
			//                       size,
			//                       0LL);
			//                     UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//                       cmd,
			//                       lightBinningZCS,
			//                       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightBinningConstants,
			//                       this.fields._._binningConstantsCBHandle_k__BackingField.bufferId,
			//                       _mm_cvtsi128_si32(
			//                         _mm_srli_si128(
			//                           *(__m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.bufferId,
			//                           4)),
			//                       _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&this.fields._._binningConstantsCBHandle_k__BackingField.size)),
			//                       0LL);
			//                     m_binningZShaderKernel = this.fields.m_binningZShaderKernel;
			//                     v43 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._BinningBuffer;
			//                     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//                     v44 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(binningBuffer, 0LL);
			//                     UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                       cmd,
			//                       lightBinningZCS,
			//                       m_binningZShaderKernel,
			//                       v43,
			//                       v44,
			//                       0,
			//                       -1,
			//                       0LL);
			//                     UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//                       cmd,
			//                       lightBinningZCS,
			//                       this.fields.m_binningZShaderKernel,
			//                       ((int)this.fields._.m_binningConstants.numSliceZ
			//                      - 1
			//                      + TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.ZPLANE_BINNING_GROUP_SIZE)
			//                     / TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.ZPLANE_BINNING_GROUP_SIZE,
			//                       1,
			//                       1,
			//                       0LL);
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_23:
			//     sub_180B536AC(static_fields, v9);
			//   }
			//   static_fields = IFix::WrappersManagerImpl::GetPatch(1623, 0LL);
			//   if ( !static_fields )
			//     goto LABEL_23;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_614(
			//     static_fields,
			//     (Object *)this,
			//     (Object *)context,
			//     (Object *)hgCamera,
			//     renderingScale,
			//     binningBuffer,
			//     0LL);
			// }
			// 
		}

		private void _SetupKernelIndex(ComputeShader shader, ref int kernelIndex)
		{
			// // Void _SetupKernelIndex(ComputeShader, Int32 ByRef)
			// void HG::Rendering::Runtime::LightCullingGPU::_SetupKernelIndex(
			//         LightCullingGPU *this,
			//         ComputeShader *shader,
			//         int32_t *kernelIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E2B )
			//   {
			//     sub_18003C530(&off_18C8F7BC0);
			//     byte_18D919E2B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1624, 0LL) )
			//   {
			//     if ( *kernelIndex != -1 )
			//       return;
			//     if ( shader )
			//     {
			//       *kernelIndex = UnityEngine::ComputeShader::FindKernel(shader, (String *)"CSMain", 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1624, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_214(
			//     (ILFixDynamicMethodWrapper_3 *)Patch,
			//     (Object *)this,
			//     (Object *)shader,
			//     kernelIndex,
			//     0LL);
			// }
			// 
		}

		private void _SetupTileKernelIndex(ComputeShader shader, ref int kernelIndex)
		{
			// // Void _SetupTileKernelIndex(ComputeShader, Int32 ByRef)
			// void HG::Rendering::Runtime::LightCullingGPU::_SetupTileKernelIndex(
			//         LightCullingGPU *this,
			//         ComputeShader *shader,
			//         int32_t *kernelIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E2C )
			//   {
			//     sub_18003C530(&off_18D5ECC80);
			//     byte_18D919E2C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1625, 0LL) )
			//   {
			//     if ( *kernelIndex != -1 )
			//       return;
			//     if ( shader )
			//     {
			//       *kernelIndex = UnityEngine::ComputeShader::FindKernel(shader, (String *)"CSMainWithTileDrawResult", 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1625, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_214(
			//     (ILFixDynamicMethodWrapper_3 *)Patch,
			//     (Object *)this,
			//     (Object *)shader,
			//     kernelIndex,
			//     0LL);
			// }
			// 
		}

		private void _SetupClearKernelIndex(ComputeShader shader, ref int kernelIndex)
		{
			// // Void _SetupClearKernelIndex(ComputeShader, Int32 ByRef)
			// void HG::Rendering::Runtime::LightCullingGPU::_SetupClearKernelIndex(
			//         LightCullingGPU *this,
			//         ComputeShader *shader,
			//         int32_t *kernelIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E2D )
			//   {
			//     sub_18003C530(&off_18D5ECC98);
			//     byte_18D919E2D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1626, 0LL) )
			//   {
			//     if ( *kernelIndex != -1 )
			//       return;
			//     if ( shader )
			//     {
			//       *kernelIndex = UnityEngine::ComputeShader::FindKernel(shader, (String *)"CSClear", 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1626, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_214(
			//     (ILFixDynamicMethodWrapper_3 *)Patch,
			//     (Object *)this,
			//     (Object *)shader,
			//     kernelIndex,
			//     0LL);
			// }
			// 
		}

		private bool GetDrawTileArgsBuffers(out ComputeBuffer current, out ComputeBuffer next)
		{
			// // Boolean GetDrawTileArgsBuffers(ComputeBuffer ByRef, ComputeBuffer ByRef)
			// bool HG::Rendering::Runtime::LightCullingGPU::GetDrawTileArgsBuffers(
			//         LightCullingGPU *this,
			//         ComputeBuffer **current,
			//         ComputeBuffer **next,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   __int64 v9; // r9
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   ComputeBuffer__Array *m_drawTileArgsBuffers; // r14
			//   ComputeBuffer *v14; // rax
			//   ComputeBuffer__Array *v15; // rcx
			//   ComputeBuffer *v16; // rbp
			//   ComputeBuffer__Array *v17; // r14
			//   ComputeBuffer *v18; // rax
			//   ComputeBuffer *v19; // rbp
			//   char v20; // r9
			//   HGCamera *v21; // r9
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   ComputeBuffer__Array *v24; // r10
			//   __int64 v25; // rax
			//   int v26; // r11d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v29; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v30; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v31; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v32; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D919E2E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     byte_18D919E2E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1617, 0LL) )
			//   {
			//     if ( !this.fields._.m_drawTileArgsBuffers )
			//     {
			//       this.fields._.m_drawTileArgsBuffers = (ComputeBuffer__Array *)il2cpp_array_new_specific_0(
			//                                                                        TypeInfo::UnityEngine::ComputeBuffer,
			//                                                                        2LL,
			//                                                                        v8,
			//                                                                        v9);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields._.m_drawTileArgsBuffers, v10, v11, v12, v29, v31);
			//       m_drawTileArgsBuffers = this.fields._.m_drawTileArgsBuffers;
			//       v14 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v16 = v14;
			//       if ( !v14 )
			//         goto LABEL_17;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v14, 2, 20, ComputeBufferType__Enum_DrawIndirect, 0LL);
			//       if ( !m_drawTileArgsBuffers )
			//         goto LABEL_17;
			//       sub_180328478(m_drawTileArgsBuffers, 0LL, v16);
			//       v17 = this.fields._.m_drawTileArgsBuffers;
			//       v18 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v19 = v18;
			//       if ( !v18 )
			//         goto LABEL_17;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v18, 2, 20, ComputeBufferType__Enum_DrawIndirect, 0LL);
			//       if ( !v17 )
			//         goto LABEL_17;
			//       sub_180328478(v17, 1LL, v19);
			//     }
			//     v20 = this.fields._.m_frameIndex++;
			//     v21 = (HGCamera *)(v20 & 1);
			//     v15 = this.fields._.m_drawTileArgsBuffers;
			//     if ( v15 )
			//     {
			//       if ( (unsigned int)v21 >= v15.max_length.size )
			//         goto LABEL_15;
			//       *current = v15.vector[(_QWORD)v21];
			//       sub_1800054D0((HGRenderPathScene *)current, v7, v8, v21, v29, v31);
			//       v24 = this.fields._.m_drawTileArgsBuffers;
			//       if ( v24 )
			//       {
			//         v25 = ((_BYTE)v23 - 1) & 1;
			//         if ( (unsigned int)v25 < v24.max_length.size )
			//         {
			//           *next = v24.vector[v25];
			//           sub_1800054D0((HGRenderPathScene *)next, v7, v22, v23, v30, v32);
			//           return v26 == 0;
			//         }
			// LABEL_15:
			//         sub_180070270(v15, v7);
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v15, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1617, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_622(Patch, (Object *)this, current, next, 0LL);
			// }
			// 
			return default(bool);
		}

		public static void GetLightSphere(in VisibleLight light, out float4 sphereParams)
		{
			// // Void GetLightSphere(VisibleLight ByRef, float4 ByRef)
			// void HG::Rendering::Runtime::LightCullingGPU::GetLightSphere(
			//         VisibleLight *light,
			//         float4 *sphereParams,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm1
			//   float m_ScreenSpaceArea; // eax
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   Vector3 *Forward; // rax
			//   float3 *xyz; // rax
			//   __int128 v15; // xmm1
			//   float z; // r14d
			//   __int64 v17; // xmm9_8
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   Vector3 *Position; // rax
			//   float3 *v26; // rax
			//   __int128 v27; // xmm1
			//   float v28; // esi
			//   __int64 v29; // xmm8_8
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   float m_Range; // xmm7_4
			//   float3__StaticFields *static_fields; // rcx
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   float v46; // eax
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   float v55; // xmm6_4
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   MethodInfo *v64; // r9
			//   float v65; // eax
			//   __int128 v66; // xmm2
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm2
			//   __int128 v69; // xmm1
			//   __int128 v70; // xmm1
			//   float v71; // xmm3_4
			//   __int128 v72; // xmm0
			//   __int128 v73; // xmm1
			//   float v74; // xmm3_4
			//   float3 *v75; // rax
			//   MethodInfo *v76; // r9
			//   float3 *v77; // r8
			//   float3 *v78; // rdx
			//   __int64 v79; // xmm3_8
			//   float v80; // eax
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   __int128 v84; // xmm0
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm0
			//   __int128 v87; // xmm1
			//   __int128 v88; // xmm0
			//   float3 *v89; // rax
			//   __int64 v90; // xmm3_8
			//   float3 *v91; // rax
			//   float v92; // ecx
			//   float y; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v95; // rdx
			//   __int64 v96; // rcx
			//   Vector3 v97; // [rsp+28h] [rbp-E0h] BYREF
			//   float4 v98; // [rsp+38h] [rbp-D0h] BYREF
			//   float3 v99; // [rsp+48h] [rbp-C0h] BYREF
			//   VisibleLight v100; // [rsp+58h] [rbp-B0h] BYREF
			// 
			//   if ( !byte_18D919E2F )
			//   {
			//     sub_18003C530(&TypeInfo::Unity::Mathematics::float3);
			//     byte_18D919E2F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1619, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1619, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v96, v95);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_623(Patch, light, sphereParams, 0LL);
			//   }
			//   else
			//   {
			//     *sphereParams = 0LL;
			//     v5 = *(_OWORD *)&light.m_FinalColor.a;
			//     m_ScreenSpaceArea = light.m_ScreenSpaceArea;
			//     *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//     v7 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//     *(_OWORD *)&v100.m_FinalColor.a = v5;
			//     v8 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//     *(_OWORD *)&v100.m_ScreenRect.m_Height = v7;
			//     v9 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v8;
			//     v10 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v9;
			//     v11 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v10;
			//     v12 = *(_OWORD *)&light.m_InstanceId;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v11;
			//     *(_OWORD *)&v100.m_LightPriority = *(_OWORD *)&light.m_LightPriority;
			//     *(_OWORD *)&v100.m_InstanceId = v12;
			//     v100.m_ScreenSpaceArea = m_ScreenSpaceArea;
			//     Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v97, &v100, 0LL);
			//     *(_QWORD *)&v11 = *(_QWORD *)&Forward.x;
			//     *(float *)&Forward = Forward.z;
			//     *(_QWORD *)&v98.x = v11;
			//     LODWORD(v98.z) = (_DWORD)Forward;
			//     xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v97, &v98, 0LL);
			//     v15 = *(_OWORD *)&light.m_FinalColor.a;
			//     z = xyz.z;
			//     v17 = *(_QWORD *)&xyz.x;
			//     *(float *)&xyz = light.m_ScreenSpaceArea;
			//     *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//     v18 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//     *(_OWORD *)&v100.m_FinalColor.a = v15;
			//     v19 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//     *(_OWORD *)&v100.m_ScreenRect.m_Height = v18;
			//     v20 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v19;
			//     v21 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v20;
			//     v22 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v21;
			//     v23 = *(_OWORD *)&light.m_LightPriority;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v22;
			//     v24 = *(_OWORD *)&light.m_InstanceId;
			//     *(_OWORD *)&v100.m_LightPriority = v23;
			//     *(_OWORD *)&v100.m_InstanceId = v24;
			//     LODWORD(v100.m_ScreenSpaceArea) = (_DWORD)xyz;
			//     Position = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetPosition(&v97, &v100, 0LL);
			//     *(_QWORD *)&v24 = *(_QWORD *)&Position.x;
			//     *(float *)&Position = Position.z;
			//     *(_QWORD *)&v98.x = v24;
			//     LODWORD(v98.z) = (_DWORD)Position;
			//     v26 = Unity::Mathematics::float4::get_xyz(&v99, &v98, 0LL);
			//     v27 = *(_OWORD *)&light.m_FinalColor.a;
			//     v28 = v26.z;
			//     v29 = *(_QWORD *)&v26.x;
			//     *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//     v30 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//     *(_OWORD *)&v100.m_FinalColor.a = v27;
			//     *(_OWORD *)&v100.m_ScreenRect.m_Height = v30;
			//     *(_QWORD *)&v97.x = v29;
			//     *(float *)&v26 = light.m_ScreenSpaceArea;
			//     v31 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//     v32 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v31;
			//     v33 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v32;
			//     v34 = *(_OWORD *)&light.m_LightPriority;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v33;
			//     v35 = *(_OWORD *)&light.m_InstanceId;
			//     *(_OWORD *)&v100.m_LightPriority = v34;
			//     *(_OWORD *)&v100.m_InstanceId = v35;
			//     LODWORD(v100.m_ScreenSpaceArea) = (_DWORD)v26;
			//     m_Range = v100.m_Range;
			//     static_fields = TypeInfo::Unity::Mathematics::float3.static_fields;
			//     *(_QWORD *)&v35 = *(_QWORD *)&static_fields.zero.x;
			//     *(float *)&v26 = static_fields.zero.z;
			//     sphereParams.w = 0.0;
			//     LODWORD(sphereParams.z) = (_DWORD)v26;
			//     *(_QWORD *)&v98.x = v35;
			//     *(_QWORD *)&sphereParams.x = v35;
			//     *(float *)&v26 = light.m_ScreenSpaceArea;
			//     v38 = *(_OWORD *)&light.m_FinalColor.a;
			//     *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//     v39 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//     *(_OWORD *)&v100.m_FinalColor.a = v38;
			//     v40 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//     *(_OWORD *)&v100.m_ScreenRect.m_Height = v39;
			//     v41 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v40;
			//     v42 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v41;
			//     v43 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v42;
			//     v44 = *(_OWORD *)&light.m_LightPriority;
			//     *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v43;
			//     v45 = *(_OWORD *)&light.m_InstanceId;
			//     *(_OWORD *)&v100.m_LightPriority = v44;
			//     *(_OWORD *)&v100.m_InstanceId = v45;
			//     LODWORD(v100.m_ScreenSpaceArea) = (_DWORD)v26;
			//     if ( v100.m_LightType )
			//     {
			//       if ( v100.m_LightType == 2 )
			//       {
			//         y = v97.y;
			//         sphereParams.x = v97.x;
			//         sphereParams.y = y;
			//         sphereParams.w = m_Range;
			//         sphereParams.z = v28;
			//       }
			//     }
			//     else
			//     {
			//       v46 = light.m_ScreenSpaceArea;
			//       v47 = *(_OWORD *)&light.m_FinalColor.a;
			//       *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//       v48 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//       *(_OWORD *)&v100.m_FinalColor.a = v47;
			//       v49 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//       *(_OWORD *)&v100.m_ScreenRect.m_Height = v48;
			//       v50 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v49;
			//       v51 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v50;
			//       v52 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v51;
			//       v53 = *(_OWORD *)&light.m_LightPriority;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v52;
			//       v54 = *(_OWORD *)&light.m_InstanceId;
			//       *(_OWORD *)&v100.m_LightPriority = v53;
			//       *(_OWORD *)&v100.m_InstanceId = v54;
			//       v100.m_ScreenSpaceArea = v46;
			//       v55 = v100.m_Range;
			//       v56 = *(_OWORD *)&light.m_FinalColor.a;
			//       *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//       v57 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//       *(_OWORD *)&v100.m_FinalColor.a = v56;
			//       v58 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//       *(_OWORD *)&v100.m_ScreenRect.m_Height = v57;
			//       v59 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v58;
			//       v60 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v59;
			//       v61 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v60;
			//       v62 = *(_OWORD *)&light.m_LightPriority;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v61;
			//       v63 = *(_OWORD *)&light.m_InstanceId;
			//       *(_OWORD *)&v100.m_LightPriority = v62;
			//       *(_OWORD *)&v100.m_InstanceId = v63;
			//       v100.m_ScreenSpaceArea = v46;
			//       *(double *)&v63 = sub_1826D6280();
			//       v65 = light.m_ScreenSpaceArea;
			//       v66 = *(_OWORD *)&light.m_FinalColor.a;
			//       *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//       v67 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//       *(_OWORD *)&v100.m_FinalColor.a = v66;
			//       v68 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//       *(_OWORD *)&v100.m_ScreenRect.m_Height = v67;
			//       v69 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v68;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v69;
			//       v70 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//       v71 = *(float *)&v63 * v55;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//       v72 = *(_OWORD *)&light.m_LightPriority;
			//       *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v70;
			//       v73 = *(_OWORD *)&light.m_InstanceId;
			//       *(_OWORD *)&v100.m_LightPriority = v72;
			//       *(_OWORD *)&v100.m_InstanceId = v73;
			//       v100.m_ScreenSpaceArea = v65;
			//       if ( v100.m_SpotAngle > 90.0 )
			//       {
			//         sphereParams.w = v71;
			//         v80 = light.m_ScreenSpaceArea;
			//         v81 = *(_OWORD *)&light.m_FinalColor.a;
			//         *(_OWORD *)&v100.m_LightType = *(_OWORD *)&light.m_LightType;
			//         v82 = *(_OWORD *)&light.m_ScreenRect.m_Height;
			//         *(_OWORD *)&v100.m_FinalColor.a = v81;
			//         v83 = *(_OWORD *)&light.m_LocalToWorldMatrix.m30;
			//         *(_OWORD *)&v100.m_ScreenRect.m_Height = v82;
			//         v84 = *(_OWORD *)&light.m_LocalToWorldMatrix.m31;
			//         *(_OWORD *)&v100.m_LocalToWorldMatrix.m30 = v83;
			//         v85 = *(_OWORD *)&light.m_LocalToWorldMatrix.m32;
			//         *(_OWORD *)&v100.m_LocalToWorldMatrix.m31 = v84;
			//         v86 = *(_OWORD *)&light.m_LocalToWorldMatrix.m33;
			//         *(_OWORD *)&v100.m_LocalToWorldMatrix.m32 = v85;
			//         v87 = *(_OWORD *)&light.m_LightPriority;
			//         *(_OWORD *)&v100.m_LocalToWorldMatrix.m33 = v86;
			//         v88 = *(_OWORD *)&light.m_InstanceId;
			//         *(_OWORD *)&v100.m_LightPriority = v87;
			//         *(_OWORD *)&v100.m_InstanceId = v88;
			//         v100.m_ScreenSpaceArea = v80;
			//         *(_QWORD *)&v97.x = v17;
			//         v97.z = z;
			//         v89 = Unity::Mathematics::float3::op_Multiply(&v99, (float3 *)&v97, v100.m_Range, v64);
			//         *(_QWORD *)&v98.x = v29;
			//         v77 = (float3 *)&v97;
			//         v98.z = v28;
			//         v78 = (float3 *)&v98;
			//         v90 = *(_QWORD *)&v89.x;
			//         *(float *)&v89 = v89.z;
			//         *(_QWORD *)&v97.x = v90;
			//         LODWORD(v97.z) = (_DWORD)v89;
			//       }
			//       else
			//       {
			//         v98.z = z;
			//         *(_QWORD *)&v98.x = v17;
			//         v74 = (float)((float)((float)(v71 * v71) / m_Range) + m_Range) * 0.5;
			//         sphereParams.w = v74;
			//         v75 = Unity::Mathematics::float3::op_Multiply(&v99, (float3 *)&v98, v74, v64);
			//         *(_QWORD *)&v97.x = v29;
			//         v77 = (float3 *)&v98;
			//         v97.z = v28;
			//         v78 = (float3 *)&v97;
			//         v79 = *(_QWORD *)&v75.x;
			//         *(float *)&v75 = v75.z;
			//         *(_QWORD *)&v98.x = v79;
			//         LODWORD(v98.z) = (_DWORD)v75;
			//       }
			//       v91 = Unity::Mathematics::float3::op_Addition(&v99, v78, v77, v76);
			//       v92 = v91.z;
			//       *(_QWORD *)&v97.x = *(_QWORD *)&v91.x;
			//       *(_QWORD *)&sphereParams.x = *(_QWORD *)&v97.x;
			//       sphereParams.z = v92;
			//     }
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose()
		{
			// // Void <>iFixBaseProxy_Dispose()
			// void HG::Rendering::Runtime::LightCullingGPU::__iFixBaseProxy_Dispose(LightCullingGPU *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::LightCulling::Dispose((LightCulling *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_PrepareRenderGraphBuffers(HGRenderGraph P0, HGRenderGraphBuilder P1)
		{
			// // Void <>iFixBaseProxy_PrepareRenderGraphBuffers(HGRenderGraph, HGRenderGraphBuilder)
			// void HG::Rendering::Runtime::LightCullingGPU::__iFixBaseProxy_PrepareRenderGraphBuffers(
			//         LightCullingGPU *this,
			//         HGRenderGraph *P0,
			//         HGRenderGraphBuilder *P1,
			//         MethodInfo *method)
			// {
			//   __int128 v4; // xmm1
			//   HGRenderGraphBuilder v5; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   v4 = *(_OWORD *)&P1.m_RenderGraph;
			//   *(_OWORD *)&v5.m_RenderPass = *(_OWORD *)&P1.m_RenderPass;
			//   *(_OWORD *)&v5.m_RenderGraph = v4;
			//   HG::Rendering::Runtime::LightCulling::PrepareRenderGraphBuffers((LightCulling *)this, P0, &v5, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_PrepareGPUData(HGRenderGraphContext P0, HGCamera P1, float P2, ComputeBufferHandle P3)
		{
			// // Void <>iFixBaseProxy_PrepareGPUData(HGRenderGraphContext, HGCamera, Single, ComputeBufferHandle)
			// void HG::Rendering::Runtime::LightCullingGPU::__iFixBaseProxy_PrepareGPUData(
			//         LightCullingGPU *this,
			//         HGRenderGraphContext *P0,
			//         HGCamera *P1,
			//         float P2,
			//         ComputeBufferHandle P3,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::LightCulling::PrepareGPUData((LightCulling *)this, P0, P1, P2, P3, 0LL);
			// }
			// 
		}

		private LightCullingGPU.GPUBinningConstants m_gpuBinningConstants;

		private NativeArray<float4> m_punctualLightDescArray;

		private ComputeBufferDesc m_punctualLightDesc;

		private ComputeBufferHandle m_punctualLightDescBuffer;

		private int m_binningXYShaderKernel;

		private int m_binningZShaderKernel;

		private int m_binningXYShaderWithTileKernel;

		private int m_clearArgsXYShaderKernel;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		private struct GPUBinningConstants
		{
			internal Vector4 nearPlaneParams;
		}
	}
}
