using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class DeferredLightingPass // TypeDefIndex: 38209
	{
		// Fields
		private static MaterialPropertyBlock s_coneMpb; // 0x00
		private static MaterialPropertyBlock s_sphereMpb; // 0x08
	
		// Nested types
		internal enum LightMeshType // TypeDefIndex: 38206
		{
			Cone = 0,
			Sphere = 1
		}
	
		internal struct LightMeshDrawRequest // TypeDefIndex: 38207
		{
			// Fields
			public LightMeshType lightMeshType; // 0x00
			public Matrix4x4 lightMeshMatrix; // 0x04
			public uint lightIndex; // 0x44
		}
	
		internal struct DeferredLightingRenderParams // TypeDefIndex: 38208
		{
			// Fields
			public bool enableDeferredShadingDefaultLit; // 0x00
			public bool enableDeferredShadingTwoSidedFoliage; // 0x01
			public bool enableDeferredShadingSubsurface; // 0x02
			public bool splitDeferredShadingStage; // 0x03
			public bool usePerLightDynamicLighting; // 0x04
			public bool enableDeferredShadingDirectionalLightStage; // 0x05
			public bool enableDeferredShadingDynamicLightStage; // 0x06
			public bool enableDeferredShadingIndirectStage; // 0x07
			public bool enableDeferredShadingTileDraw; // 0x08
			public ComputeBufferHandle drawTileArgs; // 0x0C
			public ComputeBufferHandle tileInstanceIndices; // 0x14
			public GraphicsBuffer quadIndexBuffer; // 0x20
		}
	
		// Constructors
		static DeferredLightingPass() {} // 0x0000000189B94674-0x0000000189B94710
		// DeferredLightingPass()
		void HG::Rendering::Runtime::DeferredLightingPass::cctor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // rcx
		  __int64 v3; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  __int64 v7; // rbx
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+50h] [rbp+28h]
		
		  v3 = sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v3
		    || (*(_QWORD *)(v3 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields,
		        static_fields->klass = (Type__Class *)v3,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields,
		          static_fields,
		          v5,
		          v6,
		          v11),
		        (v7 = sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0) )
		  {
		    sub_1800D8260(v2, v1);
		  }
		  *(_QWORD *)(v7 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  v8 = (Type *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields;
		  v8->monitor = (MonitorData *)v7;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_sphereMpb,
		    v8,
		    v9,
		    v10,
		    v12);
		}
		
	
		// Methods
		internal static DeferredLightingRenderParams InitDeferredLightingRenderParams(bool isOnePassDeferred) => default; // 0x0000000189B9445C-0x0000000189B94674
		// DeferredLightingPass+DeferredLightingRenderParams InitDeferredLightingRenderParams(Boolean)
		DeferredLightingPass_DeferredLightingRenderParams *HG::Rendering::Runtime::DeferredLightingPass::InitDeferredLightingRenderParams(
		        DeferredLightingPass_DeferredLightingRenderParams *__return_ptr retstr,
		        bool isOnePassDeferred,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGGraphicsFeatureSwitch *deferredShadingDefaultLit; // rcx
		  __int128 v7; // xmm1
		  GraphicsBuffer *quadIndexBuffer; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  DeferredLightingPass_DeferredLightingRenderParams *v10; // rax
		  DeferredLightingPass_DeferredLightingRenderParams *result; // rax
		  DeferredLightingPass_DeferredLightingRenderParams v12; // [rsp+20h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3044, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3044, 0LL);
		    if ( Patch )
		    {
		      v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1130(&v12, Patch, isOnePassDeferred, 0LL);
		      v7 = *(_OWORD *)&v10->drawTileArgs.handle._type_k__BackingField;
		      *(_OWORD *)&retstr->enableDeferredShadingDefaultLit = *(_OWORD *)&v10->enableDeferredShadingDefaultLit;
		      quadIndexBuffer = v10->quadIndexBuffer;
		      goto LABEL_17;
		    }
		LABEL_15:
		    sub_1800D8260(deferredShadingDefaultLit, v5);
		  }
		  *(_OWORD *)&v12.enableDeferredShadingDefaultLit = 0LL;
		  v12.quadIndexBuffer = 0LL;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDefaultLit;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingDefaultLit = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                          deferredShadingDefaultLit,
		                                          0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingTwoSidedFoliage;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingTwoSidedFoliage = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                               deferredShadingDefaultLit,
		                                               0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingSubsurface;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingSubsurface = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                          deferredShadingDefaultLit,
		                                          0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->splitDeferredShadingStage;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.splitDeferredShadingStage = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                    deferredShadingDefaultLit,
		                                    0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->usePerLightDynamicLighting;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.usePerLightDynamicLighting = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                     deferredShadingDefaultLit,
		                                     0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDirectionalLightStage;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingDirectionalLightStage = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                                     deferredShadingDefaultLit,
		                                                     0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDynamicLightStage;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingDynamicLightStage = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                                 deferredShadingDefaultLit,
		                                                 0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingIndirectStage;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingIndirectStage = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                             deferredShadingDefaultLit,
		                                             0LL);
		  deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->usePerTileDeferredLighting;
		  if ( !deferredShadingDefaultLit )
		    goto LABEL_15;
		  v12.enableDeferredShadingTileDraw = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                        deferredShadingDefaultLit,
		                                        0LL);
		  if ( !isOnePassDeferred )
		  {
		    v12.splitDeferredShadingStage = 0;
		    v12.enableDeferredShadingTileDraw = 0;
		  }
		  v7 = 0LL;
		  *(_OWORD *)&retstr->enableDeferredShadingDefaultLit = *(_OWORD *)&v12.enableDeferredShadingDefaultLit;
		  quadIndexBuffer = v12.quadIndexBuffer;
		LABEL_17:
		  result = retstr;
		  *(_OWORD *)&retstr->drawTileArgs.handle._type_k__BackingField = v7;
		  retstr->quadIndexBuffer = quadIndexBuffer;
		  return result;
		}
		
		internal static void DrawDeferredLighting(HGRenderGraphContext context, CommandBuffer cmd, Material deferredLightingMaterial, DeferredLightingRenderParams renderParams) {} // 0x0000000189B93778-0x0000000189B93CA4
		// Void DrawDeferredLighting(HGRenderGraphContext, CommandBuffer, Material, DeferredLightingPass+DeferredLightingRenderParams)
		void HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLighting(
		        HGRenderGraphContext *context,
		        CommandBuffer *cmd,
		        Material *deferredLightingMaterial,
		        DeferredLightingPass_DeferredLightingRenderParams *renderParams,
		        MethodInfo *method)
		{
		  __int128 v9; // xmm0
		  __int64 v10; // rax
		  GraphicsBuffer *quadIndexBuffer; // xmm1_8
		  unsigned __int128 v12; // xmm1
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  GraphicsBuffer *v14; // xmm0_8
		  int32_t TileInstanceIndicesBuffer; // r14d
		  ComputeBuffer *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int128 v19; // xmm1
		  ComputeBuffer *v20; // rax
		  Matrix4x4__StaticFields *v21; // rcx
		  ComputeBuffer *v22; // rax
		  int32_t v23; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v25; // xmm1
		  Matrix4x4 v26; // [rsp+58h] [rbp-B0h] BYREF
		  Matrix4x4 v27; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 identityMatrix; // [rsp+D8h] [rbp-30h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3045, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3045, 0LL);
		    if ( Patch )
		    {
		      v25 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		      *(_OWORD *)&v26.m00 = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		      *(_QWORD *)&v26.m02 = renderParams->quadIndexBuffer;
		      *(_OWORD *)&v26.m01 = v25;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1131(
		        Patch,
		        (Object *)context,
		        (Object *)cmd,
		        (Object *)deferredLightingMaterial,
		        (DeferredLightingPass_DeferredLightingRenderParams *)&v26,
		        0LL);
		      return;
		    }
		    goto LABEL_28;
		  }
		  v9 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		  v10 = *(_QWORD *)&renderParams->enableDeferredShadingDefaultLit >> 24;
		  quadIndexBuffer = renderParams->quadIndexBuffer;
		  *(_QWORD *)&v26.m02 = quadIndexBuffer;
		  *(_OWORD *)&v26.m01 = v9;
		  if ( !(_BYTE)v10 )
		  {
		    *(_OWORD *)&v26.m01 = v9;
		    *(_QWORD *)&v26.m02 = quadIndexBuffer;
		    if ( !renderParams->enableDeferredShadingDefaultLit )
		      goto LABEL_8;
		    *(_OWORD *)&v26.m01 = v9;
		    *(_QWORD *)&v26.m02 = quadIndexBuffer;
		    if ( !renderParams->enableDeferredShadingTileDraw )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 0, 0LL);
		      goto LABEL_8;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v12 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		    *(_OWORD *)&v27.m00 = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    v14 = renderParams->quadIndexBuffer;
		    *(_OWORD *)&v27.m01 = v12;
		    TileInstanceIndicesBuffer = static_fields->_TileInstanceIndicesBuffer;
		    *(_QWORD *)&v27.m02 = v14;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		    v16 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit((ComputeBufferHandle)(v12 >> 32), 0LL);
		    if ( cmd )
		    {
		      UnityEngine::Rendering::CommandBuffer::SetGlobalBufferInternal(cmd, TileInstanceIndicesBuffer, v16, 0LL);
		      v19 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		      *(_OWORD *)&v26.m00 = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		      *(_QWORD *)&v26.m02 = renderParams->quadIndexBuffer;
		      *(_OWORD *)&v26.m01 = v19;
		      *(_OWORD *)&v27.m01 = v19;
		      identityMatrix = TypeInfo::UnityEngine::Matrix4x4->static_fields->identityMatrix;
		      *(_OWORD *)&v27.m00 = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		      v20 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(*(ComputeBufferHandle *)&v27.m30, 0LL);
		      v27 = identityMatrix;
		      UnityEngine::Rendering::CommandBuffer::DrawProceduralIndirect(
		        cmd,
		        *(GraphicsBuffer **)&v26.m02,
		        &v27,
		        deferredLightingMaterial,
		        12,
		        MeshTopology__Enum_Triangles,
		        v20,
		        0LL);
		      *(_QWORD *)&v27.m02 = renderParams->quadIndexBuffer;
		      v21 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      *(_OWORD *)&v26.m01 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		      *(_OWORD *)&identityMatrix.m03 = *(_OWORD *)&v21->identityMatrix.m00;
		      *(_OWORD *)&identityMatrix.m02 = *(_OWORD *)&v21->identityMatrix.m01;
		      *(_OWORD *)&identityMatrix.m01 = *(_OWORD *)&v21->identityMatrix.m02;
		      *(_OWORD *)&identityMatrix.m00 = *(_OWORD *)&v21->identityMatrix.m03;
		      *(_OWORD *)&v26.m00 = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		      v22 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(*(ComputeBufferHandle *)&v26.m30, 0LL);
		      *(_OWORD *)&v26.m00 = *(_OWORD *)&identityMatrix.m03;
		      *(_OWORD *)&v26.m01 = *(_OWORD *)&identityMatrix.m02;
		      *(_OWORD *)&v26.m02 = *(_OWORD *)&identityMatrix.m01;
		      *(_OWORD *)&v26.m03 = *(_OWORD *)&identityMatrix.m00;
		      UnityEngine::Rendering::CommandBuffer::DrawProceduralIndirect(
		        cmd,
		        *(GraphicsBuffer **)&v27.m02,
		        &v26,
		        deferredLightingMaterial,
		        13,
		        MeshTopology__Enum_Triangles,
		        v22,
		        20,
		        0LL);
		LABEL_8:
		      if ( BYTE1(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 1, 0LL);
		      }
		      if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        v23 = 2;
		LABEL_12:
		        UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, v23, 0LL);
		        return;
		      }
		      return;
		    }
		LABEL_28:
		    sub_1800D8260(v18, v17);
		  }
		  if ( (unsigned __int16)WORD2(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) >> 8 )
		  {
		    if ( renderParams->enableDeferredShadingDefaultLit )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 3, 0LL);
		    }
		    if ( BYTE1(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 4, 0LL);
		    }
		    if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 5, 0LL);
		    }
		  }
		  if ( HIBYTE(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		  {
		    if ( renderParams->enableDeferredShadingDefaultLit )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 9, 0LL);
		    }
		    if ( BYTE1(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 10, 0LL);
		    }
		    if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      v23 = 11;
		      goto LABEL_12;
		    }
		  }
		}
		
		internal static void DrawPerLightDeferredLighting(HGRenderGraphContext context, CommandBuffer cmd, DeferredLightingRenderParams renderParams, int punctualLightCount, LightMeshDrawRequest[] drawRequests, Material deferredLightingPerLightMaterial, Mesh sphereMesh, Mesh coneMesh) {} // 0x0000000189B93CA4-0x0000000189B9445C
		// Void DrawPerLightDeferredLighting(HGRenderGraphContext, CommandBuffer, DeferredLightingPass+DeferredLightingRenderParams, Int32, DeferredLightingPass+LightMeshDrawRequest[], Material, Mesh, Mesh)
		void HG::Rendering::Runtime::DeferredLightingPass::DrawPerLightDeferredLighting(
		        HGRenderGraphContext *context,
		        CommandBuffer *cmd,
		        DeferredLightingPass_DeferredLightingRenderParams *renderParams,
		        int32_t punctualLightCount,
		        DeferredLightingPass_LightMeshDrawRequest__Array *drawRequests,
		        Material *deferredLightingPerLightMaterial,
		        Mesh *sphereMesh,
		        Mesh *coneMesh,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Void *m_Buffer; // r14
		  Void *v16; // rsi
		  int32_t v17; // r15d
		  int32_t v18; // ebx
		  int32_t v19; // r12d
		  __int64 v20; // rax
		  Void *v21; // r15
		  __int64 v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm2
		  __int128 v25; // xmm3
		  __int64 v26; // rax
		  Void *v27; // r15
		  __int64 v28; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm2
		  __int128 v31; // xmm3
		  MaterialPropertyBlock *s_coneMpb; // rbx
		  MaterialPropertyBlock *v33; // rbx
		  NativeArray_1_UnityEngine_Matrix4x4_ v34; // xmm6
		  __int128 v35; // xmm13
		  __int128 v36; // xmm12
		  __int128 v37; // xmm11
		  __int128 v38; // xmm10
		  __int128 v39; // xmm9
		  __int128 v40; // xmm8
		  __int128 v41; // xmm7
		  DeferredLightingPass__StaticFields *v42; // rcx
		  MaterialPropertyBlock *v43; // rax
		  DeferredLightingPass__StaticFields *v44; // rcx
		  MaterialPropertyBlock *v45; // rax
		  MaterialPropertyBlock *s_sphereMpb; // rbx
		  MaterialPropertyBlock *v47; // rbx
		  NativeArray_1_UnityEngine_Matrix4x4_ v48; // xmm6
		  __int128 v49; // xmm13
		  __int128 v50; // xmm12
		  __int128 v51; // xmm11
		  __int128 v52; // xmm10
		  __int128 v53; // xmm9
		  __int128 v54; // xmm8
		  __int128 v55; // xmm7
		  DeferredLightingPass__StaticFields *v56; // rcx
		  MaterialPropertyBlock *v57; // rax
		  DeferredLightingPass__StaticFields *v58; // rcx
		  MaterialPropertyBlock *v59; // rax
		  __int128 v60; // xmm1
		  GraphicsBuffer *quadIndexBuffer; // xmm0_8
		  int32_t v62; // [rsp+58h] [rbp-B0h]
		  __int64 v63; // [rsp+60h] [rbp-A8h]
		  NativeArray_1_UnityEngine_Matrix4x4_ v64; // [rsp+68h] [rbp-A0h] BYREF
		  NativeArray_1_UnityEngine_Matrix4x4_ v65; // [rsp+78h] [rbp-90h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v66; // [rsp+88h] [rbp-80h] BYREF
		  Void *v67; // [rsp+F8h] [rbp-10h]
		  Void *v68; // [rsp+100h] [rbp-8h]
		  NativeArray_1_System_Single_ v69; // [rsp+108h] [rbp+0h] BYREF
		  NativeArray_1_System_Single_ v70; // [rsp+118h] [rbp+10h] BYREF
		  DeferredLightingPass_DeferredLightingRenderParams v71; // [rsp+128h] [rbp+20h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v72[2]; // [rsp+158h] [rbp+50h] BYREF
		
		  v69 = 0LL;
		  v70 = 0LL;
		  v64 = 0LL;
		  v65 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3046, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3046, 0LL);
		    if ( !Patch )
		      goto LABEL_21;
		    v60 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		    *(_OWORD *)&v71.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		    quadIndexBuffer = renderParams->quadIndexBuffer;
		    *(_OWORD *)&v71.drawTileArgs.handle._type_k__BackingField = v60;
		    v71.quadIndexBuffer = quadIndexBuffer;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1132(
		      Patch,
		      (Object *)context,
		      (Object *)cmd,
		      &v71,
		      punctualLightCount,
		      (Object *)drawRequests,
		      (Object *)deferredLightingPerLightMaterial,
		      (Object *)sphereMesh,
		      (Object *)coneMesh,
		      0LL);
		  }
		  else if ( BYTE3(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		  {
		    Unity::Collections::NativeArray<float>::NativeArray(
		      &v69,
		      32,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		    Unity::Collections::NativeArray<float>::NativeArray(
		      &v70,
		      32,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		    Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
		      &v64,
		      32,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
		    Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
		      &v65,
		      32,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
		    if ( punctualLightCount > 0 )
		    {
		      m_Buffer = v64.m_Buffer;
		      v16 = v65.m_Buffer;
		      v68 = v69.m_Buffer;
		      v67 = v70.m_Buffer;
		      v17 = 0;
		      v18 = 0;
		      v62 = 0;
		      if ( !drawRequests )
		        goto LABEL_21;
		      v19 = 0;
		      do
		      {
		        v63 = v17;
		        if ( *(_DWORD *)sub_1804A20EC(drawRequests, v18) )
		        {
		          v20 = sub_1804A20EC(drawRequests, v17);
		          v21 = v67;
		          *(float *)v67 = (float)*(int *)(v20 + 68);
		          v22 = sub_1804A20EC(drawRequests, v63);
		          ++v62;
		          v67 = v21 + 4;
		          v23 = *(_OWORD *)(v22 + 20);
		          v24 = *(_OWORD *)(v22 + 36);
		          v25 = *(_OWORD *)(v22 + 52);
		          *(_OWORD *)v16 = *(_OWORD *)(v22 + 4);
		          *(_OWORD *)&v16[16] = v23;
		          *(_OWORD *)&v16[32] = v24;
		          *(_OWORD *)&v16[48] = v25;
		          v16 += 64;
		        }
		        else
		        {
		          v26 = sub_1804A20EC(drawRequests, v17);
		          v27 = v68;
		          *(float *)v68 = (float)*(int *)(v26 + 68);
		          v28 = sub_1804A20EC(drawRequests, v63);
		          ++v19;
		          v68 = v27 + 4;
		          v29 = *(_OWORD *)(v28 + 20);
		          v30 = *(_OWORD *)(v28 + 36);
		          v31 = *(_OWORD *)(v28 + 52);
		          *(_OWORD *)m_Buffer = *(_OWORD *)(v28 + 4);
		          *(_OWORD *)&m_Buffer[16] = v29;
		          *(_OWORD *)&m_Buffer[32] = v30;
		          *(_OWORD *)&m_Buffer[48] = v31;
		          m_Buffer += 64;
		        }
		        v17 = ++v18;
		      }
		      while ( v18 < punctualLightCount );
		      if ( v19 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
		        Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_coneMpb;
		        if ( !Patch )
		          goto LABEL_21;
		        UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)Patch, 1, 0LL);
		        s_coneMpb = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_coneMpb;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !s_coneMpb )
		          goto LABEL_21;
		        UnityEngine::MaterialPropertyBlock::SetFloatArray(s_coneMpb, static_fields->_PerLightIndex, &v69, 0LL);
		        v33 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_coneMpb;
		        sub_18033B9D0(v72, 0LL, 112LL);
		        if ( !cmd )
		          goto LABEL_21;
		        v34 = v64;
		        v35 = *(_OWORD *)&v72[0].hasValue;
		        v36 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        v37 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        v38 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        v39 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        v40 = *(_OWORD *)&v72[0].value.m_RasterState.m_OffsetFactor;
		        v41 = *(_OWORD *)&v72[0].value.m_StencilState.m_FailOperationFront;
		        v66 = v72[0];
		        UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		          cmd,
		          coneMesh,
		          0,
		          deferredLightingPerLightMaterial,
		          0,
		          &v64,
		          v19,
		          v33,
		          &v66,
		          0LL);
		        *(_OWORD *)&v66.hasValue = v35;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v36;
		        v42 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v37;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v38;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v39;
		        v43 = v42->s_coneMpb;
		        *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v40;
		        *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v41;
		        v64 = v34;
		        UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		          cmd,
		          coneMesh,
		          0,
		          deferredLightingPerLightMaterial,
		          1,
		          &v64,
		          v19,
		          v43,
		          &v66,
		          0LL);
		        *(_OWORD *)&v66.hasValue = v35;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v36;
		        v44 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v37;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v38;
		        *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v39;
		        v45 = v44->s_coneMpb;
		        *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v40;
		        *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v41;
		        v64 = v34;
		        UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		          cmd,
		          coneMesh,
		          0,
		          deferredLightingPerLightMaterial,
		          2,
		          &v64,
		          v19,
		          v45,
		          &v66,
		          0LL);
		      }
		      if ( !v62 )
		        return;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
		      Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_sphereMpb;
		      if ( Patch )
		      {
		        UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)Patch, 1, 0LL);
		        s_sphereMpb = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_sphereMpb;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( s_sphereMpb )
		        {
		          UnityEngine::MaterialPropertyBlock::SetFloatArray(s_sphereMpb, static_fields->_PerLightIndex, &v70, 0LL);
		          v47 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields->s_sphereMpb;
		          sub_18033B9D0(v72, 0LL, 112LL);
		          if ( cmd )
		          {
		            v48 = v65;
		            v49 = *(_OWORD *)&v72[0].hasValue;
		            v50 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            v51 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            v52 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            v53 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            v54 = *(_OWORD *)&v72[0].value.m_RasterState.m_OffsetFactor;
		            v55 = *(_OWORD *)&v72[0].value.m_StencilState.m_FailOperationFront;
		            v66 = v72[0];
		            UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		              cmd,
		              sphereMesh,
		              0,
		              deferredLightingPerLightMaterial,
		              0,
		              &v65,
		              v62,
		              v47,
		              &v66,
		              0LL);
		            *(_OWORD *)&v66.hasValue = v49;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v50;
		            v56 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v51;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v52;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v53;
		            v57 = v56->s_sphereMpb;
		            *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v54;
		            *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v55;
		            v65 = v48;
		            UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		              cmd,
		              sphereMesh,
		              0,
		              deferredLightingPerLightMaterial,
		              1,
		              &v65,
		              v62,
		              v57,
		              &v66,
		              0LL);
		            *(_OWORD *)&v66.hasValue = v49;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v50;
		            v58 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass->static_fields;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v51;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v52;
		            *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v53;
		            v59 = v58->s_sphereMpb;
		            *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v54;
		            *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v55;
		            v65 = v48;
		            UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		              cmd,
		              sphereMesh,
		              0,
		              deferredLightingPerLightMaterial,
		              2,
		              &v65,
		              v62,
		              v59,
		              &v66,
		              0LL);
		            return;
		          }
		        }
		      }
		LABEL_21:
		      sub_1800D8260(Patch, static_fields);
		    }
		  }
		}
		
		internal static void DrawDeferredLightingWriteAlpha(HGRenderGraphContext context, CommandBuffer cmd, HGCamera hgCamera, Material deferredLightingWriteAlphaMaterial, DeferredLightingRenderParams renderParams) {} // 0x0000000189B93614-0x0000000189B93778
		// Void DrawDeferredLightingWriteAlpha(HGRenderGraphContext, CommandBuffer, HGCamera, Material, DeferredLightingPass+DeferredLightingRenderParams)
		void HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLightingWriteAlpha(
		        HGRenderGraphContext *context,
		        CommandBuffer *cmd,
		        HGCamera *hgCamera,
		        Material *deferredLightingWriteAlphaMaterial,
		        DeferredLightingPass_DeferredLightingRenderParams *renderParams,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v12; // xmm1
		  GraphicsBuffer *quadIndexBuffer; // xmm0_8
		  DeferredLightingPass_DeferredLightingRenderParams v14; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3047, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3047, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    v12 = *(_OWORD *)&renderParams->drawTileArgs.handle._type_k__BackingField;
		    *(_OWORD *)&v14.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams->enableDeferredShadingDefaultLit;
		    quadIndexBuffer = renderParams->quadIndexBuffer;
		    *(_OWORD *)&v14.drawTileArgs.handle._type_k__BackingField = v12;
		    v14.quadIndexBuffer = quadIndexBuffer;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1133(
		      Patch,
		      (Object *)context,
		      (Object *)cmd,
		      (Object *)hgCamera,
		      (Object *)deferredLightingWriteAlphaMaterial,
		      &v14,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    if ( HG::Rendering::Runtime::HGUtils::RenderWithAlpha(hgCamera, 0LL) )
		    {
		      if ( renderParams->enableDeferredShadingDefaultLit )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 0, 0LL);
		      }
		      if ( BYTE1(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 1, 0LL);
		      }
		      if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams->enableDeferredShadingDefaultLit) )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 2, 0LL);
		      }
		    }
		  }
		}
		
	}
}
