using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal abstract class LightCulling : IDisposable
	{
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00002608 File Offset: 0x00000808
		public int numTiles
		{
			get
			{
				// // Int32 get_numTiles()
				// int32_t HG::Rendering::Runtime::LightCulling::get_numTiles(LightCulling *this, MethodInfo *method)
				// {
				//   return HIDWORD(*(_QWORD *)&this.fields.m_binningConstants.lightCount);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000885 RID: 2181 RVA: 0x000028D8 File Offset: 0x00000AD8
		protected LightCulling.BinningConstants binningConstants
		{
			get
			{
				// // LightCulling+BinningConstants get_binningConstants()
				// LightCulling_BinningConstants *HG::Rendering::Runtime::LightCulling::get_binningConstants(
				//         LightCulling_BinningConstants *__return_ptr retstr,
				//         LightCulling *this,
				//         MethodInfo *method)
				// {
				//   LightCulling_BinningConstants *result; // rax
				//   __int128 v4; // xmm1
				//   __int128 v5; // xmm0
				// 
				//   result = retstr;
				//   v4 = *(_OWORD *)&this.fields.m_binningConstants.tileSize;
				//   *(_OWORD *)&retstr.lightCount = *(_OWORD *)&this.fields.m_binningConstants.lightCount;
				//   v5 = *(_OWORD *)&this.fields.m_binningConstants.nearClipPlane;
				//   *(_OWORD *)&retstr.tileSize = v4;
				//   *(_OWORD *)&retstr.nearClipPlane = v5;
				//   return result;
				// }
				// 
				return default(LightCulling.BinningConstants);
			}
		}

		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected CBHandle binningConstantsCBHandle
		{
			[CompilerGenerated]
			protected get
			{
				// // CameraControlStateInitialParam get_value()
				// CameraControlStateInitialParam *Beyond::Gameplay::ParamVariable<Beyond::Gameplay::View::CameraControlStateInitialParam>::get_value(
				//         CameraControlStateInitialParam *__return_ptr retstr,
				//         ParamVariable_1_Beyond_Gameplay_View_CameraControlStateInitialParam_ *this,
				//         MethodInfo *method)
				// {
				//   CameraControlStateInitialParam *result; // rax
				//   __int64 v4; // xmm1_8
				// 
				//   result = retstr;
				//   v4 = *(_QWORD *)&this.fields.m_value.applyZoomScale;
				//   *(_OWORD *)&retstr.applyHorizontalAngle = *(_OWORD *)&this.fields.m_value.applyHorizontalAngle;
				//   *(_QWORD *)&retstr.applyZoomScale = v4;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_binningConstantsCBHandle(CBHandle)
				// void HG::Rendering::Runtime::LightCulling::set_binningConstantsCBHandle(
				//         LightCulling *this,
				//         CBHandle *value,
				//         MethodInfo *method)
				// {
				//   void *ptr; // xmm1_8
				// 
				//   ptr = value.ptr;
				//   *(_OWORD *)&this.fields._binningConstantsCBHandle_k__BackingField.bufferId = *(_OWORD *)&value.bufferId;
				//   this.fields._binningConstantsCBHandle_k__BackingField.ptr = ptr;
				// }
				// 
			}
		}

		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBufferHandle DrawTileArgsBufferHandle
		{
			get
			{
				// // ICinemachineCamera get_LiveChild()
				// ICinemachineCamera *Cinemachine::CinemachineClearShot::get_LiveChild(CinemachineClearShot *this, MethodInfo *method)
				// {
				//   return this.fields._LiveChild_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBufferHandle TileInstanceIndicesBufferHandle
		{
			get
			{
				// // List`1[UnityEngine.Renderer] get_OtherRenderers()
				// List_1_UnityEngine_Renderer_ *PaintIn3D::P3dPaintable::get_OtherRenderers(P3dPaintable *this, MethodInfo *method)
				// {
				//   return this.fields.otherRenderers;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000025D2 File Offset: 0x000007D2
		public GraphicsBuffer QuadIndexBuffer
		{
			get
			{
				// // GraphicsBuffer get_QuadIndexBuffer()
				// GraphicsBuffer *HG::Rendering::Runtime::LightCulling::get_QuadIndexBuffer(LightCulling *this, MethodInfo *method)
				// {
				//   GraphicsBuffer *v3; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   GraphicsBuffer *v6; // rdi
				//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
				//   PassConstructorID__Enum__Array *v8; // r8
				//   HGCamera *v9; // r9
				//   GraphicsBuffer *m_quadIndexBuffer; // rdi
				//   __int64 v11; // r8
				//   __int64 v12; // r9
				//   Array *v13; // rsi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *v16; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v17; // [rsp+28h] [rbp-10h]
				// 
				//   if ( !byte_18D919E26 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::GraphicsBuffer);
				//     sub_18003C530(&FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_1);
				//     sub_18003C530(&TypeInfo::System::UInt32);
				//     byte_18D919E26 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1597, 0LL) )
				//   {
				//     if ( this.fields.m_quadIndexBuffer )
				//       return this.fields.m_quadIndexBuffer;
				//     v3 = (GraphicsBuffer *)sub_180004920(TypeInfo::UnityEngine::GraphicsBuffer);
				//     v6 = v3;
				//     if ( v3 )
				//     {
				//       UnityEngine::GraphicsBuffer::GraphicsBuffer(v3, GraphicsBuffer_Target__Enum_Index, 6, 4, 0LL);
				//       this.fields.m_quadIndexBuffer = v6;
				//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_quadIndexBuffer, v7, v8, v9, v16, v17);
				//       m_quadIndexBuffer = this.fields.m_quadIndexBuffer;
				//       v13 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::UInt32, 6LL, v11, v12);
				//       System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
				//         v13,
				//         FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_1,
				//         0LL);
				//       if ( m_quadIndexBuffer )
				//       {
				//         UnityEngine::GraphicsBuffer::SetData(m_quadIndexBuffer, v13, 0LL);
				//         return this.fields.m_quadIndexBuffer;
				//       }
				//     }
				// LABEL_10:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1597, 0LL);
				//   if ( !Patch )
				//     goto LABEL_10;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_612(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		public LightCulling()
		{
			// // LightCulling()
			// void HG::Rendering::Runtime::LightCulling::LightCulling(LightCulling *this, MethodInfo *method)
			// {
			//   __int128 v3; // xmm1
			//   __int128 v4; // xmm0
			//   __int64 v5; // rdx
			//   struct LightCulling__Class *v6; // rcx
			//   LightCulling__StaticFields *static_fields; // rax
			//   __int64 v8; // rdx
			//   struct Il2CppType *v9; // rbx
			//   int32_t NUM_FLOAT4_PUNCTUALIGHT; // esi
			//   __int64 v11; // rdx
			//   Type *TypeFromHandle; // rbx
			//   int v13; // eax
			//   String *v14; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   _BYTE v18[48]; // [rsp+30h] [rbp-30h] BYREF
			//   MethodInfo *v19; // [rsp+90h] [rbp+30h]
			//   MethodInfo *v20; // [rsp+98h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDCE8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray);
			//     sub_18003C530(&TypeInfo::System::Type);
			//     sub_18003C530(&TypeRef::Unity::Mathematics::float4);
			//     byte_18D8EDCE8 = 1;
			//   }
			//   *(_DWORD *)&v18[16] = 1107296256;
			//   memset(&v18[20], 0, 20);
			//   *(_DWORD *)&v18[40] = 1065353216;
			//   v3 = *(_OWORD *)&v18[16];
			//   *(_DWORD *)&v18[44] = 1065353216;
			//   *(_OWORD *)&this.fields.m_binningConstants.lightCount = 0u;
			//   v4 = *(_OWORD *)&v18[32];
			//   *(_OWORD *)&this.fields.m_binningConstants.tileSize = v3;
			//   *(_OWORD *)&this.fields.m_binningConstants.nearClipPlane = v4;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_float3_ *)v18,
			//     8,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray);
			//   this.fields.m_frustumCorners = *(NativeArray_1_Unity_Mathematics_float3_ *)v18;
			//   v6 = TypeInfo::HG::Rendering::Runtime::LightCulling;
			//   if ( !TypeInfo::HG::Rendering::Runtime::LightCulling._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::LightCulling, v5);
			//     v6 = TypeInfo::HG::Rendering::Runtime::LightCulling;
			//   }
			//   static_fields = v6.static_fields;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_float3_ *)v18,
			//     (static_fields.MAX_NUM_TILE_X + 1) * (static_fields.MAX_NUM_TILE_Y + 1),
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::NativeArray);
			//   this.fields.m_tileVertices = *(NativeArray_1_Unity_Mathematics_float3_ *)v18;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_quaternion_ *)v18,
			//     TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.MAX_NUM_TILE_X + 1,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//   this.fields.m_XPlanes = *(NativeArray_1_Unity_Mathematics_float4_ *)v18;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_quaternion_ *)v18,
			//     TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.MAX_NUM_TILE_Y + 1,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//   this.fields.m_YPlanes = *(NativeArray_1_Unity_Mathematics_float4_ *)v18;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_quaternion_ *)v18,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//   this.fields.m_lightSphereData = *(NativeArray_1_Unity_Mathematics_float4_ *)v18;
			//   *(_OWORD *)v18 = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     (NativeArray_1_Unity_Mathematics_quaternion_ *)v18,
			//     (TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT << 8) + 6,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
			//   this.fields.m_punctualLightDataArray = *(NativeArray_1_Unity_Mathematics_float4_ *)v18;
			//   v9 = TypeRef::Unity::Mathematics::float4;
			//   NUM_FLOAT4_PUNCTUALIGHT = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//   if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Type, v8);
			//   TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v9, 0LL);
			//   if ( !TypeInfo::System::Runtime::InteropServices::Marshal._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Runtime::InteropServices::Marshal, v11);
			//   *(_QWORD *)&v18[12] = 0LL;
			//   *(_DWORD *)v18 = (NUM_FLOAT4_PUNCTUALIGHT << 8) + 6;
			//   *(_DWORD *)&v18[20] = 0;
			//   v13 = sub_1800981B0(TypeFromHandle);
			//   v14 = *(String **)&v18[16];
			//   *(_DWORD *)&v18[4] = v13;
			//   *(_DWORD *)&v18[8] = 8;
			//   *(_OWORD *)&this.fields.m_punctualLightDataDesc.count = *(_OWORD *)v18;
			//   this.fields.m_punctualLightDataDesc.name = v14;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_punctualLightDataDesc.name, v15, v16, v17, v19, v20);
			// }
			// 
		}

		public virtual void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::LightCulling::Dispose(LightCulling *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D8EDCE9 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
			//     byte_18D8EDCE9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1598, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1598, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_tileVertices,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float3>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_XPlanes,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_YPlanes,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_lightSphereData,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_punctualLightDataArray,
			//       MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::Dispose);
			//   }
			// }
			// 
		}

		protected abstract void _PreparePunctualLightDescInternal(in VisibleLight punctualLight, HGCamera hgCamera, int lightIndex);

		protected abstract void _PrepareCPUDataInternal(HGCamera hgCamera, NativeArray<VisibleLight> visibleLights, NativeArray<int> lightIndices, int directionalLightIndex);

		public virtual void SetOuputTileDrawBuffers(bool isNeed)
		{
			// // Void SetOuputTileDrawBuffers(Boolean)
			// void HG::Rendering::Runtime::LightCulling::SetOuputTileDrawBuffers(LightCulling *this, bool isNeed, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1599, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1599, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, isNeed, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_outputTileDrawBuffers = isNeed;
			//   }
			// }
			// 
		}

		public virtual void PrepareRenderGraphBuffers(HGRenderGraph renderGraph, HGRenderGraphBuilder builder)
		{
			// // Void PrepareRenderGraphBuffers(HGRenderGraph, HGRenderGraphBuilder)
			// void HG::Rendering::Runtime::LightCulling::PrepareRenderGraphBuffers(
			//         LightCulling *this,
			//         HGRenderGraph *renderGraph,
			//         HGRenderGraphBuilder *builder,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v10; // xmm1
			//   ComputeBufferHandle input; // [rsp+30h] [rbp-38h] BYREF
			//   HGRenderGraphBuilder v12; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1600, 0LL) )
			//   {
			//     if ( renderGraph )
			//     {
			//       input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                 renderGraph,
			//                 &this.fields.m_punctualLightDataDesc,
			//                 0LL);
			//       this.fields.m_punctualLightDataBuffer = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			//                                                  builder,
			//                                                  &input,
			//                                                  0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1600, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v10 = *(_OWORD *)&builder.m_RenderGraph;
			//   *(_OWORD *)&v12.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//   *(_OWORD *)&v12.m_RenderGraph = v10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_613(Patch, (Object *)this, (Object *)renderGraph, &v12, 0LL);
			// }
			// 
		}

		public virtual void PrepareGPUData(HGRenderGraphContext context, HGCamera hgCamera, float renderingScale, ComputeBufferHandle binningBuffer)
		{
			// // Void PrepareGPUData(HGRenderGraphContext, HGCamera, Single, ComputeBufferHandle)
			// void HG::Rendering::Runtime::LightCulling::PrepareGPUData(
			//         LightCulling *this,
			//         HGRenderGraphContext *context,
			//         HGCamera *hgCamera,
			//         float renderingScale,
			//         ComputeBufferHandle binningBuffer,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1601, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1601, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_614(
			//       Patch,
			//       (Object *)this,
			//       (Object *)context,
			//       (Object *)hgCamera,
			//       renderingScale,
			//       binningBuffer,
			//       0LL);
			//   }
			// }
			// 
		}

		public virtual void SetupGlobalConstants(HGRenderGraphContext context)
		{
			// // Void SetupGlobalConstants(HGRenderGraphContext)
			// void HG::Rendering::Runtime::LightCulling::SetupGlobalConstants(
			//         LightCulling *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   CommandBuffer *cmd; // rbp
			//   int32_t size; // edi
			//   CBHandle *ConstantBuffer; // rax
			//   __m128i v10; // xmm6
			//   CBHandle *v11; // rax
			//   __int128 v12; // xmm1
			//   void *ptr; // xmm0_8
			//   Void *v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CBHandle v16[2]; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919E27 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<Unity::Mathematics::float4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919E27 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1602, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       size = 16 * this.fields.m_punctualLightDataArray.m_Length;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                          v16,
			//                          &context.fields.renderContext,
			//                          size,
			//                          0LL);
			//       v10 = *(__m128i *)&ConstantBuffer.bufferId;
			//       v16[0].ptr = ConstantBuffer.ptr;
			//       System::Buffer::MemoryCopy(this.fields.m_punctualLightDataArray.m_Buffer, (Void *)v16[0].ptr, size, size, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( cmd )
			//       {
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//           cmd,
			//           _mm_cvtsi128_si32(v10),
			//           static_fields._LightDataBuffer,
			//           _mm_cvtsi128_si32(_mm_srli_si128(v10, 4)),
			//           size,
			//           0LL);
			//         v11 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                 v16,
			//                 &context.fields.renderContext,
			//                 48,
			//                 0LL);
			//         v12 = *(_OWORD *)&v11.bufferId;
			//         v16[0].ptr = v11.ptr;
			//         ptr = v16[0].ptr;
			//         v14 = (Void *)v16[0].ptr;
			//         *(_OWORD *)&this.fields._binningConstantsCBHandle_k__BackingField.bufferId = v12;
			//         this.fields._binningConstantsCBHandle_k__BackingField.ptr = ptr;
			//         System::Buffer::MemoryCopy((Void *)&this.fields.m_binningConstants, v14, 48LL, 48LL, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//           cmd,
			//           this.fields._binningConstantsCBHandle_k__BackingField.bufferId,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightBinningConstants,
			//           _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&this.fields._binningConstantsCBHandle_k__BackingField.bufferId, 4)),
			//           48,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//           cmd,
			//           &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_DisableDynamicLightLoop,
			//           this.fields.m_binningConstants.lightCount == 0,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1602, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		public virtual void FrameSetup(HGCamera hgCamera)
		{
			// // Void FrameSetup(HGCamera)
			// void HG::Rendering::Runtime::LightCulling::FrameSetup(LightCulling *this, HGCamera *hgCamera, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Camera *camera; // rsi
			//   Frustum frustum; // xmm6
			//   unsigned __int64 v9; // xmm6_8
			//   float3 *v10; // rax
			//   Void *v11; // rcx
			//   float v12; // edx
			//   float3 *v13; // rax
			//   Void *v14; // rcx
			//   float v15; // edx
			//   float3 *v16; // rax
			//   Void *v17; // rdx
			//   float v18; // r8d
			//   __int64 v19; // r8
			//   float3 *xyz; // rax
			//   Void *m_Buffer; // rcx
			//   float z; // edx
			//   float3 *v23; // rax
			//   Void *v24; // rcx
			//   float v25; // edx
			//   float3 *v26; // rax
			//   Void *v27; // rdx
			//   float v28; // r8d
			//   float3 *v29; // rax
			//   Void *v30; // rcx
			//   float v31; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float4 v33; // [rsp+20h] [rbp-30h] BYREF
			//   float4 v34; // [rsp+30h] [rbp-20h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1605, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       frustum = hgCamera.fields.frustum;
			//       if ( camera )
			//       {
			//         this.fields.m_binningConstants.nearClipPlane = UnityEngine::Camera::get_nearClipPlane(
			//                                                           hgCamera.fields.camera,
			//                                                           0LL);
			//         this.fields.m_binningConstants.farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
			//         v9 = _mm_srli_si128((__m128i)frustum, 8).m128i_u64[0];
			//         if ( UnityEngine::SystemInfo::GetGraphicsUVStartsAtTop(0LL) )
			//         {
			//           if ( v9 )
			//           {
			//             sub_180040F70(v9, &v34, 4LL);
			//             *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//             v33.z = v34.z;
			//             xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//             m_Buffer = this.fields.m_frustumCorners.m_Buffer;
			//             z = xyz.z;
			//             *(_QWORD *)m_Buffer = *(_QWORD *)&xyz.x;
			//             *(float *)&m_Buffer[8] = z;
			//             sub_180040F70(v9, &v34, 5LL);
			//             *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//             v33.z = v34.z;
			//             v23 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//             v24 = this.fields.m_frustumCorners.m_Buffer;
			//             v25 = v23.z;
			//             *(_QWORD *)&v24[12] = *(_QWORD *)&v23.x;
			//             *(float *)&v24[20] = v25;
			//             sub_180040F70(v9, &v34, 6LL);
			//             *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//             v33.z = v34.z;
			//             v26 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//             v27 = this.fields.m_frustumCorners.m_Buffer;
			//             v28 = v26.z;
			//             *(_QWORD *)&v27[24] = *(_QWORD *)&v26.x;
			//             *(float *)&v27[32] = v28;
			//             v19 = 7LL;
			//             goto LABEL_9;
			//           }
			//         }
			//         else if ( v9 )
			//         {
			//           sub_180040F70(v9, &v33, 6LL);
			//           *(_QWORD *)&v34.x = *(_QWORD *)&v33.x;
			//           v34.z = v33.z;
			//           v10 = Unity::Mathematics::float4::get_xyz((float3 *)&v33, &v34, 0LL);
			//           v11 = this.fields.m_frustumCorners.m_Buffer;
			//           v12 = v10.z;
			//           *(_QWORD *)v11 = *(_QWORD *)&v10.x;
			//           *(float *)&v11[8] = v12;
			//           sub_180040F70(v9, &v34, 7LL);
			//           *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//           v33.z = v34.z;
			//           v13 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//           v14 = this.fields.m_frustumCorners.m_Buffer;
			//           v15 = v13.z;
			//           *(_QWORD *)&v14[12] = *(_QWORD *)&v13.x;
			//           *(float *)&v14[20] = v15;
			//           sub_180040F70(v9, &v34, 4LL);
			//           *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//           v33.z = v34.z;
			//           v16 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//           v17 = this.fields.m_frustumCorners.m_Buffer;
			//           v18 = v16.z;
			//           *(_QWORD *)&v17[24] = *(_QWORD *)&v16.x;
			//           *(float *)&v17[32] = v18;
			//           v19 = 5LL;
			// LABEL_9:
			//           sub_180040F70(v9, &v34, v19);
			//           *(_QWORD *)&v33.x = *(_QWORD *)&v34.x;
			//           v33.z = v34.z;
			//           v29 = Unity::Mathematics::float4::get_xyz((float3 *)&v34, &v33, 0LL);
			//           v30 = this.fields.m_frustumCorners.m_Buffer;
			//           v31 = v29.z;
			//           *(_QWORD *)&v30[36] = *(_QWORD *)&v29.x;
			//           *(float *)&v30[44] = v31;
			//           return;
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1605, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		public void PrepareCPUData(HGCamera camera, BinningPass.BinningData binningData, NativeArray<VisibleLight> visibleLights, NativeArray<int> lightIndices, NativeArray<float> lightDistances, int directionalLightIndex, int punctualLightCount, uint4 lightMasks)
		{
			// // Void PrepareCPUData(HGCamera, BinningPass+BinningData, NativeArray`1[UnityEngine.Rendering.VisibleLight], NativeArray`1[System.Int32], NativeArray`1[System.Single], Int32, Int32, uint4)
			// void HG::Rendering::Runtime::LightCulling::PrepareCPUData(
			//         LightCulling *this,
			//         HGCamera *camera,
			//         BinningPass_BinningData *binningData,
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         NativeArray_1_System_Int32_ *lightIndices,
			//         NativeArray_1_System_Single_ *lightDistances,
			//         int32_t directionalLightIndex,
			//         int32_t punctualLightCount,
			//         uint4 *lightMasks,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *v10; // rdi
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector2Int sceneRTSize_k__BackingField; // rax
			//   __m128i v17; // xmm0
			//   __int64 v18; // rax
			//   __int64 v19; // rax
			//   float v20; // xmm1_4
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbx
			//   Light *light; // rax
			//   MethodInfo *v23; // r8
			//   Vector3 *Forward; // rax
			//   __int64 v25; // xmm0_8
			//   MethodInfo *v26; // r8
			//   MethodInfo *v27; // r8
			//   double v28; // xmm0_8
			//   double v29; // xmm0_8
			//   HGEnvironmentVolumeCameraComponent *v30; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rbx
			//   float z; // eax
			//   __int64 v33; // xmm0_8
			//   HGLightConfig *p_lightConfig; // rbx
			//   MethodInfo *v35; // r8
			//   MethodInfo *v36; // r8
			//   Vector4 *AsVector4; // rax
			//   int32_t directIntensityDividePi_low; // xmm1_4
			//   double v39; // xmm0_8
			//   double v40; // xmm0_8
			//   HGShadowManager *shadowManager; // rax
			//   HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // r14
			//   int32_t v43; // esi
			//   HGLightCookieManager *lightCookieManager; // r15
			//   Void *m_Buffer; // r8
			//   float *v46; // rdx
			//   unsigned __int64 v47; // rax
			//   Void *v48; // rax
			//   float LightFalloff; // xmm2_4
			//   MethodInfo *v50; // r8
			//   MethodInfo *v51; // r9
			//   __m128i v52; // xmm6
			//   float flickerScale_Injected; // xmm0_4
			//   MethodInfo *v54; // r9
			//   __m128 v55; // xmm14
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm0_8
			//   float3 *xyz; // rax
			//   float v59; // ebx
			//   Entity_1 Entity; // rax
			//   int v61; // r15d
			//   Vector3 *Position; // rax
			//   __int64 v63; // xmm0_8
			//   float3 *v64; // rax
			//   int v65; // ecx
			//   HGLightAdditionalData *LightAdditionalData; // rcx
			//   __m128i v67; // xmm1
			//   __m128 v68; // xmm15
			//   __m128 v69; // xmm12
			//   Vector3 *cullingBoxRelativePosition; // rax
			//   __int64 v71; // xmm0_8
			//   float3 *v72; // rax
			//   float v73; // ebx
			//   Vector3 *cullingBoxHalfExtents; // rax
			//   __int64 v75; // xmm0_8
			//   float3 *v76; // rax
			//   __int64 v77; // xmm0_8
			//   Vector3 *cullingBoxOrientation; // rax
			//   __int64 v79; // xmm0_8
			//   float3 *v80; // rax
			//   float v81; // xmm6_4
			//   float v82; // xmm7_4
			//   float v83; // xmm8_4
			//   __int64 v84; // xmm0_8
			//   float v85; // xmm9_4
			//   unsigned int v86; // xmm10_4
			//   int v87; // xmm11_4
			//   float3 *v88; // rax
			//   __int64 v89; // xmm6_8
			//   float v90; // edi
			//   float3 *v91; // rax
			//   __int64 v92; // xmm0_8
			//   __int128 *v93; // rbx
			//   float3 *v94; // rax
			//   __int64 v95; // xmm0_8
			//   __int128 v96; // xmm0
			//   Matrix4x4 *v97; // rax
			//   __int128 v98; // xmm1
			//   __int128 v99; // xmm0
			//   __int128 v100; // xmm1
			//   Matrix4x4 *inverse; // rax
			//   __m128 v102; // xmm11
			//   __m128 v103; // xmm10
			//   __m128 v104; // xmm9
			//   __m128 v105; // xmm8
			//   double v106; // xmm0_8
			//   float v107; // xmm6_4
			//   double v108; // xmm0_8
			//   Entity_1 v109; // rax
			//   int32_t v110; // edi
			//   int32_t v111; // ebx
			//   __m128i v112; // xmm0
			//   Void *v113; // rax
			//   LightCulling__StaticFields *v114; // rcx
			//   int v115; // eax
			//   __int64 v116; // rcx
			//   Void *v117; // rax
			//   Void *v118; // rax
			//   __int64 v119; // rcx
			//   int v120; // ebx
			//   int v121; // xmm0_4
			//   Void *v122; // rax
			//   LightCulling__StaticFields *v123; // rcx
			//   int32_t v124; // ebx
			//   __int128 v125; // xmm0
			//   Entity_1 v126; // rax
			//   int32_t ShadowCacheIndexForCaster; // r15d
			//   Entity_1 v128; // rax
			//   int32_t v129; // esi
			//   Entity_1 v130; // rax
			//   int32_t v131; // edi
			//   Entity_1 v132; // rax
			//   int32_t v133; // ebx
			//   Entity_1 v134; // rax
			//   int32_t v135; // r14d
			//   Entity_1 v136; // rax
			//   int32_t v137; // eax
			//   int v138; // r14d
			//   int v139; // r15d
			//   int32_t NUM_FLOAT4_PUNCTUALIGHT; // ebx
			//   bool shadowOnly_Injected; // al
			//   __m128i v142; // xmm0
			//   Void *v143; // rax
			//   LightCulling__StaticFields *static_fields; // rcx
			//   int32_t v145; // ebx
			//   Void *v146; // rax
			//   int v147; // ebx
			//   int v148; // xmm0_4
			//   Void *v149; // rax
			//   LightCulling__StaticFields *v150; // rcx
			//   float v151; // xmm0_4
			//   Void *v152; // rax
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v153; // xmm1
			//   int v154; // xmm2_4
			//   Void *v155; // rax
			//   NativeArray_1_System_Int32_ v156; // xmm0
			//   Vector4 v157; // xmm1
			//   Void *v158; // rax
			//   Void *v159; // rcx
			//   NativeArray_1_System_Single_ v160; // xmm0
			//   NativeArray_1_System_Int32_ v161; // xmm0
			//   __m128i v162; // xmm1
			//   __int128 v163; // xmm0
			//   __int64 v164; // [rsp+28h] [rbp-E0h]
			//   HGSharedLightData _unity_self; // [rsp+68h] [rbp-A0h] BYREF
			//   _QWORD v166[3]; // [rsp+70h] [rbp-98h] BYREF
			//   int v167; // [rsp+88h] [rbp-80h]
			//   float specularIntensity_Injected; // [rsp+8Ch] [rbp-7Ch]
			//   int v169; // [rsp+90h] [rbp-78h]
			//   int v170; // [rsp+94h] [rbp-74h]
			//   float v171; // [rsp+98h] [rbp-70h]
			//   float v172; // [rsp+9Ch] [rbp-6Ch]
			//   NativeArray_1_System_Single_ v173; // [rsp+A8h] [rbp-60h] BYREF
			//   float v174; // [rsp+B8h] [rbp-50h]
			//   int v175; // [rsp+BCh] [rbp-4Ch]
			//   int32_t v176; // [rsp+C0h] [rbp-48h]
			//   __int64 v177; // [rsp+C8h] [rbp-40h]
			//   Vector3 v178; // [rsp+D8h] [rbp-30h] BYREF
			//   Matrix4x4 v179; // [rsp+E8h] [rbp-20h] BYREF
			//   float2 v180; // [rsp+128h] [rbp+20h]
			//   __int128 v181; // [rsp+130h] [rbp+28h]
			//   __m128i v182; // [rsp+148h] [rbp+40h] BYREF
			//   BinningPass_BinningData v183; // [rsp+158h] [rbp+50h] BYREF
			//   int32_t LightCookieIndex; // [rsp+178h] [rbp+70h]
			//   __int128 v185; // [rsp+180h] [rbp+78h]
			//   __m128i v186; // [rsp+198h] [rbp+90h] BYREF
			//   Void *v187; // [rsp+1A8h] [rbp+A0h]
			//   HGPunctualLightShadowManagerV2 *v188; // [rsp+1B0h] [rbp+A8h]
			//   Vector3 v189; // [rsp+1B8h] [rbp+B0h] BYREF
			//   __int128 v190; // [rsp+1C8h] [rbp+C0h]
			//   __int128 v191; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v192; // [rsp+1E8h] [rbp+E0h]
			//   __int128 v193; // [rsp+1F8h] [rbp+F0h]
			//   __int128 v194; // [rsp+208h] [rbp+100h]
			//   __int128 v195; // [rsp+218h] [rbp+110h]
			//   __int128 v196; // [rsp+228h] [rbp+120h]
			//   __int128 v197; // [rsp+238h] [rbp+130h]
			//   __int128 v198; // [rsp+248h] [rbp+140h]
			//   __int128 v199; // [rsp+258h] [rbp+150h]
			//   __int128 v200; // [rsp+268h] [rbp+160h]
			//   float4 v201; // [rsp+278h] [rbp+170h] BYREF
			//   Vector3 v202; // [rsp+288h] [rbp+180h] BYREF
			//   __int64 v203; // [rsp+298h] [rbp+190h] BYREF
			//   int v204; // [rsp+2A0h] [rbp+198h]
			//   __int64 v205; // [rsp+2A8h] [rbp+1A0h]
			//   unsigned __int64 v206; // [rsp+2B0h] [rbp+1A8h]
			//   HGLightCookieManager *v207; // [rsp+2B8h] [rbp+1B0h]
			//   float4 v208; // [rsp+2C8h] [rbp+1C0h] BYREF
			//   float3 v209; // [rsp+2D8h] [rbp+1D0h] BYREF
			//   float4 v210; // [rsp+2E8h] [rbp+1E0h] BYREF
			//   __int64 v211; // [rsp+2F8h] [rbp+1F0h]
			//   __m128i v212; // [rsp+308h] [rbp+200h]
			//   float4 v213; // [rsp+318h] [rbp+210h] BYREF
			//   float4 v214; // [rsp+328h] [rbp+220h] BYREF
			//   float4 v215; // [rsp+338h] [rbp+230h] BYREF
			//   float4 v216; // [rsp+348h] [rbp+240h] BYREF
			//   float4 v217; // [rsp+358h] [rbp+250h] BYREF
			//   Matrix4x4 v218; // [rsp+368h] [rbp+260h] BYREF
			//   Vector3 v219; // [rsp+3A8h] [rbp+2A0h] BYREF
			//   float3 v220; // [rsp+3B8h] [rbp+2B0h] BYREF
			//   Vector3 v221; // [rsp+3C8h] [rbp+2C0h] BYREF
			//   float3 v222; // [rsp+3D8h] [rbp+2D0h] BYREF
			//   float3 v223; // [rsp+3E8h] [rbp+2E0h] BYREF
			//   float3 v224; // [rsp+3F8h] [rbp+2F0h] BYREF
			//   float3 v225; // [rsp+408h] [rbp+300h] BYREF
			//   Vector3 v226; // [rsp+418h] [rbp+310h] BYREF
			//   float3 v227; // [rsp+428h] [rbp+320h] BYREF
			//   float3 v228; // [rsp+438h] [rbp+330h] BYREF
			//   Vector3 v229; // [rsp+448h] [rbp+340h] BYREF
			//   float3 v230; // [rsp+458h] [rbp+350h] BYREF
			//   Vector3 v231; // [rsp+468h] [rbp+360h] BYREF
			//   Matrix4x4 v232; // [rsp+478h] [rbp+370h] BYREF
			//   VisibleLight v233; // [rsp+4B8h] [rbp+3B0h] BYREF
			//   __m256i v234; // [rsp+558h] [rbp+450h] BYREF
			//   __int128 v235; // [rsp+578h] [rbp+470h]
			//   __int128 v236; // [rsp+588h] [rbp+480h]
			//   __int128 v237; // [rsp+598h] [rbp+490h]
			//   __int128 v238; // [rsp+5A8h] [rbp+4A0h]
			//   __int128 v239; // [rsp+5B8h] [rbp+4B0h]
			//   __int128 v240; // [rsp+5C8h] [rbp+4C0h]
			//   __int128 v241; // [rsp+5D8h] [rbp+4D0h]
			//   float v242; // [rsp+5E8h] [rbp+4E0h]
			//   Color v243; // [rsp+5F8h] [rbp+4F0h] BYREF
			//   Vector4 v244; // [rsp+608h] [rbp+500h] BYREF
			//   Vector4 v245; // [rsp+618h] [rbp+510h] BYREF
			//   Vector4 v246; // [rsp+628h] [rbp+520h] BYREF
			//   char v247[16]; // [rsp+638h] [rbp+530h] BYREF
			//   Vector4 v248; // [rsp+648h] [rbp+540h] BYREF
			//   VisibleLight v249; // [rsp+658h] [rbp+550h] BYREF
			// 
			//   v10 = visibleLights;
			//   if ( !byte_18D919E28 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     byte_18D919E28 = 1;
			//   }
			//   sub_1802F01E0(&v233, 0LL, 148LL);
			//   sub_1802F01E0(&v234, 0LL, 148LL);
			//   _unity_self = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1606, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1606, 0LL);
			//     if ( Patch )
			//     {
			//       *(uint4 *)&v166[1] = *lightMasks;
			//       v173 = *lightDistances;
			//       v161 = *lightIndices;
			//       v162 = *(__m128i *)v10;
			//       v183.uintCount = binningData.uintCount;
			//       v182 = (__m128i)v161;
			//       v163 = *(_OWORD *)&binningData.tileSize;
			//       v186 = v162;
			//       v162.m128i_i64[0] = *(_QWORD *)&binningData.xyOffset;
			//       *(_OWORD *)&v183.tileSize = v163;
			//       *(_QWORD *)&v183.xyOffset = v162.m128i_i64[0];
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_621(
			//         Patch,
			//         (Object *)this,
			//         (Object *)camera,
			//         &v183,
			//         (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v186,
			//         (NativeArray_1_System_Int32_ *)&v182,
			//         &v173,
			//         directionalLightIndex,
			//         punctualLightCount,
			//         (uint4 *)&v166[1],
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_51;
			//   }
			//   if ( !camera )
			//     goto LABEL_51;
			//   this.fields.m_binningConstants.actualWidth = camera.fields._sceneRTSize_k__BackingField.m_X;
			//   sceneRTSize_k__BackingField = camera.fields._sceneRTSize_k__BackingField;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)lightIndices;
			//   *(_QWORD *)&v183.xyOffset = *(_QWORD *)&binningData.xyOffset;
			//   v17 = _mm_cvtsi32_si128(binningData.tileSize);
			//   this.fields.m_binningConstants.actualHeight = sceneRTSize_k__BackingField.m_Y;
			//   v183.uintCount = binningData.uintCount;
			//   v18 = HIDWORD(*(_QWORD *)&binningData.tileSize);
			//   specularIntensity_Injected = 0.0;
			//   LODWORD(this.fields.m_binningConstants.tileSize) = _mm_cvtepi32_ps(v17).m128_u32[0];
			//   *(_QWORD *)&v183.xyOffset = *(_QWORD *)&binningData.xyOffset;
			//   *(float *)v17.m128i_i32 = (float)(int)v18;
			//   v183.uintCount = binningData.uintCount;
			//   v19 = HIDWORD(*(_QWORD *)&binningData.tileY);
			//   v169 = 0;
			//   LODWORD(this.fields.m_binningConstants.numTilesX) = v17.m128i_i32[0];
			//   *(_QWORD *)&v183.xyOffset = *(_QWORD *)&binningData.xyOffset;
			//   *(float *)v17.m128i_i32 = (float)binningData.tileY;
			//   v170 = 1065353216;
			//   LODWORD(this.fields.m_binningConstants.numTilesY) = v17.m128i_i32[0];
			//   *(_QWORD *)&v183.xyOffset = *(_QWORD *)&binningData.xyOffset;
			//   v212 = 0LL;
			//   this.fields.m_binningConstants.numSliceZ = (float)(int)v19;
			//   v20 = this.fields.m_binningConstants.numTilesY * this.fields.m_binningConstants.numTilesX;
			//   v186 = 0LL;
			//   v182 = 0LL;
			//   this.fields.m_binningConstants.numTiles = (int)v20;
			//   this.fields.m_binningConstants.lightCount = lightIndices.m_Length;
			//   v173 = 0LL;
			//   if ( directionalLightIndex != -1 )
			//   {
			//     v233 = *(VisibleLight *)&v10.m_Buffer[148 * directionalLightIndex];
			//     m_envVolumeCameraComponent = camera.fields.m_envVolumeCameraComponent;
			//     light = UnityEngine::Rendering::VisibleLight::get_light(&v233, 0LL);
			//     if ( !m_envVolumeCameraComponent )
			//       goto LABEL_51;
			//     if ( !HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//             m_envVolumeCameraComponent,
			//             light,
			//             0LL) )
			//     {
			//       v249 = v233;
			//       Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v189, &v249, 0LL);
			//       v25 = *(_QWORD *)&Forward.x;
			//       *(float *)&Forward = Forward.z;
			//       *(_QWORD *)&v178.x = v25;
			//       LODWORD(v178.z) = (_DWORD)Forward;
			//       *(Vector4 *)&v166[1] = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v166[1], &v178, v26);
			//       v212 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                 (Vector4 *)&v173,
			//                                                 (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                                                 0LL));
			//       *(Color *)&v166[1] = v233.m_FinalColor;
			//       *(Color *)&v166[1] = *UnityEngine::Color::op_Implicit((Color *)&v173, (Vector4 *)&v166[1], v27);
			//       v186 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                 (Vector4 *)&v173,
			//                                                 (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                                                 0LL));
			//       v182 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetOriginalColorAndIntensity(
			//                                                 (float4 *)&v166[1],
			//                                                 v233.hgSharedLightData,
			//                                                 0LL));
			//       v173 = (NativeArray_1_System_Single_)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//                                                                               (float4 *)&v166[1],
			//                                                                               v233.hgSharedLightData,
			//                                                                               camera,
			//                                                                               0LL));
			//       specularIntensity_Injected = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(
			//                                      &v233.hgSharedLightData,
			//                                      0LL);
			//       UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&v233.hgSharedLightData, 0LL);
			//       v28 = Beyond::DampingMath::sinf();
			//       v169 = LODWORD(v28);
			//       UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&v233.hgSharedLightData, 0LL);
			//       v29 = Beyond::DampingMath::cosf();
			//       v170 = LODWORD(v29);
			// LABEL_12:
			//       Patch = (ILFixDynamicMethodWrapper_2 *)lightIndices;
			//       goto LABEL_13;
			//     }
			//     v30 = camera.fields.m_envVolumeCameraComponent;
			//     if ( v30 )
			//     {
			//       m_interpolatedPhase = v30.fields.m_interpolatedPhase;
			//       if ( m_interpolatedPhase )
			//       {
			//         z = m_interpolatedPhase.fields.lightConfig.forwardDirect.z;
			//         v33 = *(_QWORD *)&m_interpolatedPhase.fields.lightConfig.forwardDirect.x;
			//         p_lightConfig = &m_interpolatedPhase.fields.lightConfig;
			//         *(_QWORD *)&v178.x = v33;
			//         v178.z = z;
			//         *(Vector4 *)&v166[1] = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v166[1], &v178, v23);
			//         v212 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                   (Vector4 *)&v173,
			//                                                   (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                                                   0LL));
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//         *(Color *)&v166[1] = *HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalColor(
			//                                 (Color *)&v166[1],
			//                                 p_lightConfig,
			//                                 0LL);
			//         *(Color *)&v166[1] = *UnityEngine::Color::op_Implicit((Color *)&v173, (Vector4 *)&v166[1], v35);
			//         v186 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                   (Vector4 *)&v173,
			//                                                   (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                                                   0LL));
			//         *(_OWORD *)&v166[1] = *(_OWORD *)sub_182F8C840(&v166[1], p_lightConfig);
			//         *(Color *)&v166[1] = *UnityEngine::Color::op_Implicit((Color *)&v173, (Vector4 *)&v166[1], v36);
			//         AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                       (Vector4 *)&v173,
			//                       (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                       0LL);
			//         directIntensityDividePi_low = LODWORD(p_lightConfig.directIntensityDividePi);
			//         v182 = *(__m128i *)AsVector4;
			//         v182.m128i_i32[3] = directIntensityDividePi_low;
			//         v173 = (NativeArray_1_System_Single_)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//                                                                                 (float4 *)&v166[1],
			//                                                                                 p_lightConfig,
			//                                                                                 camera,
			//                                                                                 0LL));
			//         specularIntensity_Injected = p_lightConfig.directSpecularIntensity;
			//         v39 = Beyond::DampingMath::sinf();
			//         v169 = LODWORD(v39);
			//         v40 = Beyond::DampingMath::cosf();
			//         v170 = LODWORD(v40);
			//         goto LABEL_12;
			//       }
			//     }
			// LABEL_51:
			//     sub_180B536AC(Patch, v14);
			//   }
			// LABEL_13:
			//   shadowManager = camera.fields.shadowManager;
			//   if ( !shadowManager )
			//     goto LABEL_51;
			//   m_punctualLightShadowManagerV2 = shadowManager.fields.m_punctualLightShadowManagerV2;
			//   v43 = 0;
			//   lightCookieManager = camera.fields.lightCookieManager;
			//   v188 = m_punctualLightShadowManagerV2;
			//   v207 = lightCookieManager;
			//   v176 = 0;
			//   if ( this.fields.m_binningConstants.lightCount <= 0 )
			//     goto LABEL_49;
			//   m_Buffer = v10.m_Buffer;
			//   *(_QWORD *)&v178.x = v10.m_Buffer;
			//   v46 = (float *)lightDistances.m_Buffer;
			//   v47 = (char *)Patch.klass - (char *)lightDistances.m_Buffer;
			//   v187 = lightDistances.m_Buffer;
			//   v206 = v47;
			//   do
			//   {
			//     v48 = &m_Buffer[148 * *(int *)((char *)v46 + v47)];
			//     v234 = *(__m256i *)v48;
			//     v235 = *(_OWORD *)&v48[32];
			//     v236 = *(_OWORD *)&v48[48];
			//     v237 = *(_OWORD *)&v48[64];
			//     v238 = *(_OWORD *)&v48[80];
			//     v239 = *(_OWORD *)&v48[96];
			//     v240 = *(_OWORD *)&v48[112];
			//     v241 = *(_OWORD *)&v48[128];
			//     v242 = *(float *)&v48[144];
			//     _unity_self = (HGSharedLightData)*((_QWORD *)&v241 + 1);
			//     LightFalloff = HG::Rendering::Runtime::LightExtensions::GetLightFalloff(
			//                      *(HGSharedLightData *)((char *)&v241 + 8),
			//                      *v46,
			//                      0LL);
			//     *(_OWORD *)&v166[1] = *(_OWORD *)((char *)v234.m256i_i64 + 4);
			//     *(Color *)&v166[1] = *UnityEngine::Color::op_Implicit(&v243, (Vector4 *)&v166[1], v50);
			//     v52 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
			//                                              &v244,
			//                                              (Vector4 *)&v166[1],
			//                                              LightFalloff,
			//                                              v51));
			//     flickerScale_Injected = UnityEngine::HGSharedLightData::get_flickerScale_Injected(&_unity_self, 0LL);
			//     *(__m128i *)&v166[1] = v52;
			//     *(Vector4 *)&v166[1] = *UnityEngine::Vector4::op_Multiply(&v245, (Vector4 *)&v166[1], flickerScale_Injected, v54);
			//     v55 = (__m128)_mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                      &v246,
			//                                                      (CinemachineSmoothPath_Waypoint *)&v166[1],
			//                                                      0LL));
			//     *(_OWORD *)&v249.m_LightType = *(_OWORD *)v234.m256i_i8;
			//     *(_OWORD *)&v249.m_FinalColor.a = *(_OWORD *)&v234.m256i_u64[2];
			//     *(_OWORD *)&v249.m_ScreenRect.m_Height = v235;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m30 = v236;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m31 = v237;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m32 = v238;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m33 = v239;
			//     *(_OWORD *)&v249.m_LightPriority = v240;
			//     *(_OWORD *)&v249.m_InstanceId = v241;
			//     v249.m_ScreenSpaceArea = v242;
			//     v56 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v231, &v249, 0LL);
			//     v57 = *(_QWORD *)&v56.x;
			//     *(float *)&v56 = v56.z;
			//     *(_QWORD *)&v208.x = v57;
			//     LODWORD(v208.z) = (_DWORD)v56;
			//     xyz = Unity::Mathematics::float4::get_xyz(&v230, &v208, 0LL);
			//     v52.m128i_i64[0] = *(_QWORD *)&xyz.x;
			//     v59 = xyz.z;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     *(_QWORD *)&v209.x = v52.m128i_i64[0];
			//     v209.z = v59;
			//     v180 = HG::Rendering::Runtime::HGUtils::PackNormalOctRectEncode(&v209, 0LL);
			//     Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(
			//                *(HGSharedLightData *)((char *)&v241 + 8),
			//                0LL);
			//     if ( !lightCookieManager )
			//       goto LABEL_51;
			//     LightCookieIndex = HG::Rendering::Runtime::HGLightCookieManager::GetLightCookieIndex(
			//                          lightCookieManager,
			//                          Entity,
			//                          0LL);
			//     v61 = LightCookieIndex;
			//     *(_OWORD *)&v249.m_LightType = *(_OWORD *)v234.m256i_i8;
			//     *(_OWORD *)&v249.m_FinalColor.a = *(_OWORD *)&v234.m256i_u64[2];
			//     *(_OWORD *)&v249.m_ScreenRect.m_Height = v235;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m30 = v236;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m31 = v237;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m32 = v238;
			//     *(_OWORD *)&v249.m_LocalToWorldMatrix.m33 = v239;
			//     *(_OWORD *)&v249.m_LightPriority = v240;
			//     *(_OWORD *)&v249.m_InstanceId = v241;
			//     v249.m_ScreenSpaceArea = v242;
			//     Position = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetPosition(&v229, &v249, 0LL);
			//     v63 = *(_QWORD *)&Position.x;
			//     *(float *)&Position = Position.z;
			//     *(_QWORD *)&v210.x = v63;
			//     LODWORD(v210.z) = (_DWORD)Position;
			//     v64 = Unity::Mathematics::float4::get_xyz(&v228, &v210, 0LL);
			//     v211 = *(_QWORD *)&v64.x;
			//     *(_QWORD *)&v185 = v211;
			//     DWORD2(v185) = LODWORD(v64.z);
			//     LODWORD(v164) = v43;
			//     *((float *)&v185 + 3) = 1.0 / *((float *)&v239 + 2);
			//     sub_1804431F4(v65, (_DWORD)this, (unsigned int)&v234, (_DWORD)camera, v164);
			//     LightAdditionalData = HG::Rendering::Runtime::LightExtensions::GetLightAdditionalData(
			//                             (HGLightAdditionalData *)&v179,
			//                             _unity_self,
			//                             0LL);
			//     *(Vector4 *)&v218.m00 = LightAdditionalData.lightNPRData;
			//     *(_OWORD *)&v166[1] = *(_OWORD *)&v218.m00;
			//     v67 = *(__m128i *)&LightAdditionalData.lightNPRType;
			//     v175 = _mm_cvtsi128_si32(v67);
			//     *(__m128i *)&v218.m01 = v67;
			//     if ( v67.m128i_i8[4] )
			//       v167 = 1065353216;
			//     else
			//       v167 = 0;
			//     v68 = (__m128)v67;
			//     *(Vector4 *)&v218.m00 = LightAdditionalData.lightNPRData;
			//     v69 = (__m128)v67;
			//     cullingBoxRelativePosition = UnityEngine::HGSharedLightData::get_cullingBoxRelativePosition(
			//                                    &v226,
			//                                    &_unity_self,
			//                                    0LL);
			//     v71 = *(_QWORD *)&cullingBoxRelativePosition.x;
			//     *(float *)&cullingBoxRelativePosition = cullingBoxRelativePosition.z;
			//     *(_QWORD *)&v213.x = v71;
			//     LODWORD(v213.z) = (_DWORD)cullingBoxRelativePosition;
			//     v72 = Unity::Mathematics::float4::get_xyz(&v227, &v213, 0LL);
			//     v73 = v72.z;
			//     v177 = *(_QWORD *)&v72.x;
			//     cullingBoxHalfExtents = UnityEngine::HGSharedLightData::get_cullingBoxHalfExtents(&v219, &_unity_self, 0LL);
			//     v75 = *(_QWORD *)&cullingBoxHalfExtents.x;
			//     *(float *)&cullingBoxHalfExtents = cullingBoxHalfExtents.z;
			//     *(_QWORD *)&v214.x = v75;
			//     LODWORD(v214.z) = (_DWORD)cullingBoxHalfExtents;
			//     v76 = Unity::Mathematics::float4::get_xyz(&v220, &v214, 0LL);
			//     v77 = *(_QWORD *)&v76.x;
			//     *(float *)&v76 = v76.z;
			//     *(_QWORD *)&v179.m00 = v77;
			//     v172 = *(float *)&v76;
			//     cullingBoxOrientation = UnityEngine::HGSharedLightData::get_cullingBoxOrientation(&v221, &_unity_self, 0LL);
			//     v79 = *(_QWORD *)&cullingBoxOrientation.x;
			//     *(float *)&cullingBoxOrientation = cullingBoxOrientation.z;
			//     *(_QWORD *)&v215.x = v79;
			//     LODWORD(v215.z) = (_DWORD)cullingBoxOrientation;
			//     v80 = Unity::Mathematics::float4::get_xyz(&v222, &v215, 0LL);
			//     v81 = 0.0;
			//     v174 = 0.0;
			//     v82 = 0.0;
			//     v83 = 0.0;
			//     v84 = *(_QWORD *)&v80.x;
			//     v85 = 0.0;
			//     *(float *)&v80 = v80.z;
			//     v86 = 0;
			//     v205 = v84;
			//     v87 = 0;
			//     v171 = *(float *)&v80;
			//     if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//     {
			//       *(_QWORD *)&v216.x = v177;
			//       v216.z = v73;
			//       v88 = Unity::Mathematics::float4::get_xyz(&v223, &v216, 0LL);
			//       *(_QWORD *)&v217.x = v205;
			//       v89 = *(_QWORD *)&v88.x;
			//       v90 = v88.z;
			//       v217.z = v171;
			//       v91 = Unity::Mathematics::float4::get_xyz(&v224, &v217, 0LL);
			//       v92 = *(_QWORD *)&v91.x;
			//       *(float *)&v91 = v91.z;
			//       v203 = v92;
			//       v204 = (int)v91;
			//       v93 = (__int128 *)sub_182504CA0(v247, &v203);
			//       *(_QWORD *)&v201.x = *(_QWORD *)&v179.m00;
			//       v201.z = v172;
			//       v94 = Unity::Mathematics::float4::get_xyz(&v225, &v201, 0LL);
			//       *(_QWORD *)&v189.x = v89;
			//       v189.z = v90;
			//       v95 = *(_QWORD *)&v94.x;
			//       *(float *)&v94 = v94.z;
			//       *(_QWORD *)&v202.x = v95;
			//       v96 = *v93;
			//       LODWORD(v202.z) = (_DWORD)v94;
			//       *(_OWORD *)&v179.m00 = v96;
			//       v97 = UnityEngine::Matrix4x4::TRS(&v218, &v189, (Quaternion *)&v179, &v202, 0LL);
			//       v98 = *(_OWORD *)&v97.m01;
			//       *(_OWORD *)&v232.m00 = *(_OWORD *)&v97.m00;
			//       v99 = *(_OWORD *)&v97.m02;
			//       *(_OWORD *)&v232.m01 = v98;
			//       v100 = *(_OWORD *)&v97.m03;
			//       *(_OWORD *)&v232.m02 = v99;
			//       *(_OWORD *)&v232.m03 = v100;
			//       inverse = UnityEngine::Matrix4x4::get_inverse(&v179, &v232, 0LL);
			//       v103 = *(__m128 *)&inverse.m03;
			//       v104 = *(__m128 *)&inverse.m00;
			//       v105 = *(__m128 *)&inverse.m01;
			//       *(_OWORD *)&v218.m02 = *(_OWORD *)&inverse.m02;
			//       v102 = *(__m128 *)&v218.m02;
			//       *(__m128 *)&v218.m03 = v103;
			//       *(__m128 *)&v218.m01 = v105;
			//       *(__m128 *)&v218.m00 = v104;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v82 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v104.m128_f32[0], v105.m128_f32[0], 0LL);
			//       v81 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v102.m128_f32[0], v103.m128_f32[0], 0LL);
			//       v174 = v81;
			//       v172 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                _mm_shuffle_ps(v104, v104, 85).m128_f32[0],
			//                _mm_shuffle_ps(v105, v105, 85).m128_f32[0],
			//                0LL);
			//       v171 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                _mm_shuffle_ps(v102, v102, 85).m128_f32[0],
			//                _mm_shuffle_ps(v103, v103, 85).m128_f32[0],
			//                0LL);
			//       LODWORD(v177) = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                         _mm_shuffle_ps(v104, v104, 170).m128_f32[0],
			//                         _mm_shuffle_ps(v105, v105, 170).m128_f32[0],
			//                         0LL);
			//       *(float *)&v99 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(
			//                          _mm_shuffle_ps(v102, v102, 170).m128_f32[0],
			//                          _mm_shuffle_ps(v103, v103, 170).m128_f32[0],
			//                          0LL);
			//       v83 = v172;
			//       v87 = v99;
			//       v85 = v171;
			//       v86 = v177;
			//     }
			//     if ( v234.m256i_i32[0] )
			//     {
			//       if ( v234.m256i_i32[0] != 2 )
			//         goto LABEL_47;
			//       v126 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v126, 0, 0LL);
			//       if ( !m_punctualLightShadowManagerV2 )
			//         goto LABEL_51;
			//       ShadowCacheIndexForCaster = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                                     m_punctualLightShadowManagerV2,
			//                                     (LightCaster *)&v179,
			//                                     0LL);
			//       v128 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v128, 1, 0LL);
			//       v129 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                m_punctualLightShadowManagerV2,
			//                (LightCaster *)&v179,
			//                0LL);
			//       v130 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v130, 2, 0LL);
			//       v131 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                m_punctualLightShadowManagerV2,
			//                (LightCaster *)&v179,
			//                0LL);
			//       v132 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v132, 3, 0LL);
			//       v133 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                m_punctualLightShadowManagerV2,
			//                (LightCaster *)&v179,
			//                0LL);
			//       v134 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v134, 4, 0LL);
			//       v135 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                m_punctualLightShadowManagerV2,
			//                (LightCaster *)&v179,
			//                0LL);
			//       v136 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v136, 5, 0LL);
			//       v137 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                v188,
			//                (LightCaster *)&v179,
			//                0LL);
			//       if ( ShadowCacheIndexForCaster == -1 )
			//         ShadowCacheIndexForCaster = 255;
			//       if ( v129 == -1 )
			//         v129 = 255;
			//       if ( v131 == -1 )
			//         v131 = 255;
			//       if ( v133 == -1 )
			//         v133 = 255;
			//       if ( v135 == -1 )
			//         v135 = 255;
			//       if ( v137 == -1 )
			//         v137 = 255;
			//       v138 = v137 | (v135 << 8);
			//       v139 = v133 | ((v131 | ((v129 | (ShadowCacheIndexForCaster << 8)) << 8)) << 8);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       NUM_FLOAT4_PUNCTUALIGHT = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       LODWORD(v195) = v55.m128_i32[0];
			//       DWORD2(v195) = _mm_shuffle_ps(v55, v55, 170).m128_u32[0];
			//       DWORD1(v195) = _mm_shuffle_ps(v55, v55, 85).m128_u32[0];
			//       shadowOnly_Injected = UnityEngine::HGSharedLightData::get_shadowOnly_Injected(&_unity_self, 0LL);
			//       v43 = v176;
			//       v142 = _mm_cvtsi32_si128(2 * (unsigned int)shadowOnly_Injected + 1);
			//       v143 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       HIDWORD(v195) = _mm_cvtepi32_ps(v142).m128_u32[0];
			//       *(_OWORD *)&v143[16 * v176 * NUM_FLOAT4_PUNCTUALIGHT + 96] = v195;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//       DWORD1(v196) = LODWORD(v180.y);
			//       *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16 * static_fields.NUM_FLOAT4_PUNCTUALIGHT * v43 + 112] = v185;
			//       *(float *)&v196 = v180.x;
			//       v145 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       *(float *)v142.m128i_i32 = UnityEngine::HGSharedLightData::get_length_Injected(&_unity_self, 0LL);
			//       v146 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       *((_QWORD *)&v196 + 1) = __PAIR64__(v139, v142.m128i_u32[0]);
			//       LODWORD(v197) = v138;
			//       DWORD1(v197) = _mm_shuffle_ps(v68, v68, 170).m128_u32[0];
			//       *(_OWORD *)&v146[16 * v43 * v145 + 128] = v196;
			//       *((_QWORD *)&v197 + 1) = __PAIR64__(v175, v167);
			//       *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16
			//                                                                * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT
			//                                                                * v43
			//                                                                + 144] = v197;
			//       *(__m128i *)&this.fields.m_punctualLightDataArray.m_Buffer[16
			//                                                                 * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT
			//                                                                 * v43
			//                                                                 + 160] = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4((Vector4 *)&v183, (CinemachineSmoothPath_Waypoint *)&v166[1], 0LL));
			//       v147 = v43 * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//         v148 = 1065353216;
			//       else
			//         v148 = 0;
			//       v149 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       *(_QWORD *)&v198 = __PAIR64__(LODWORD(v81), LODWORD(v82));
			//       *((_QWORD *)&v198 + 1) = __PAIR64__(v148, LODWORD(v83));
			//       *(_OWORD *)&v149[16 * v147 + 176] = v198;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       *(_QWORD *)&v199 = __PAIR64__(v86, LODWORD(v85));
			//       v150 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//       DWORD2(v199) = v87;
			//       HIDWORD(v199) = _mm_shuffle_ps(v69, v69, 255).m128_u32[0];
			//       *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16 * v150.NUM_FLOAT4_PUNCTUALIGHT * v43 + 192] = v199;
			//       v124 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       LODWORD(v181) = UnityEngine::HGSharedLightData::get_cullingBoxFalloffThreshold_Injected(&_unity_self, 0LL);
			//       DWORD1(v181) = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&_unity_self, 0LL);
			//       v151 = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(&_unity_self, 0LL);
			//       m_punctualLightShadowManagerV2 = v188;
			//       *((float *)&v181 + 2) = v151;
			//       *((float *)&v181 + 3) = (float)LightCookieIndex;
			//       v125 = v181;
			//     }
			//     else
			//     {
			//       UnityEngine::HGSharedLightData::get_innerSpotAngle_Injected(&_unity_self, 0LL);
			//       v106 = Beyond::DampingMath::cosf();
			//       v107 = *(float *)&v106;
			//       UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
			//       v108 = Beyond::DampingMath::cosf();
			//       LODWORD(v177) = LODWORD(v108);
			//       v109 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
			//       *(_OWORD *)&v179.m00 = 0LL;
			//       HG::Rendering::Runtime::LightCaster::LightCaster((LightCaster *)&v179, v109, 0, 0LL);
			//       if ( !m_punctualLightShadowManagerV2 )
			//         goto LABEL_51;
			//       v110 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//                m_punctualLightShadowManagerV2,
			//                (LightCaster *)&v179,
			//                0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       v111 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       LODWORD(v192) = v55.m128_i32[0];
			//       DWORD2(v192) = _mm_shuffle_ps(v55, v55, 170).m128_u32[0];
			//       DWORD1(v192) = _mm_shuffle_ps(v55, v55, 85).m128_u32[0];
			//       v112 = _mm_cvtsi32_si128(2 * (unsigned int)UnityEngine::HGSharedLightData::get_shadowOnly_Injected(
			//                                                    &_unity_self,
			//                                                    0LL));
			//       v113 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       HIDWORD(v192) = _mm_cvtepi32_ps(v112).m128_u32[0];
			//       *(_OWORD *)&v113[16 * v43 * v111 + 96] = v192;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       v114 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//       *(float *)&v193 = v180.x;
			//       v115 = v114.NUM_FLOAT4_PUNCTUALIGHT * v43;
			//       *(float *)&v191 = (float)v110;
			//       v116 = v115;
			//       v117 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       DWORD1(v191) = _mm_shuffle_ps(v68, v68, 170).m128_u32[0];
			//       *(_OWORD *)&v117[16 * v116 + 112] = v185;
			//       *(_QWORD *)((char *)&v193 + 4) = __PAIR64__(v177, LODWORD(v180.y));
			//       v118 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       v119 = 2 * (TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT * v43 + 8LL);
			//       *((float *)&v193 + 3) = 1.0 / (float)(v107 - *(float *)&v177);
			//       *(_OWORD *)&v118[8 * v119] = v193;
			//       *((_QWORD *)&v191 + 1) = __PAIR64__(v175, v167);
			//       *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16
			//                                                                * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT
			//                                                                * v43
			//                                                                + 144] = v191;
			//       *(__m128i *)&this.fields.m_punctualLightDataArray.m_Buffer[16
			//                                                                 * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT
			//                                                                 * v43
			//                                                                 + 160] = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(&v248, (CinemachineSmoothPath_Waypoint *)&v166[1], 0LL));
			//       v120 = v43 * TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//         v121 = 1065353216;
			//       else
			//         v121 = 0;
			//       v122 = this.fields.m_punctualLightDataArray.m_Buffer;
			//       *(_QWORD *)&v190 = __PAIR64__(LODWORD(v174), LODWORD(v82));
			//       *((_QWORD *)&v190 + 1) = __PAIR64__(v121, LODWORD(v83));
			//       *(_OWORD *)&v122[16 * v120 + 176] = v190;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//       *(_QWORD *)&v200 = __PAIR64__(v86, LODWORD(v85));
			//       v123 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//       DWORD2(v200) = v87;
			//       HIDWORD(v200) = _mm_shuffle_ps(v69, v69, 255).m128_u32[0];
			//       *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16 * v123.NUM_FLOAT4_PUNCTUALIGHT * v43 + 192] = v200;
			//       v124 = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields.NUM_FLOAT4_PUNCTUALIGHT;
			//       LODWORD(v194) = UnityEngine::HGSharedLightData::get_cullingBoxFalloffThreshold_Injected(&_unity_self, 0LL);
			//       DWORD1(v194) = UnityEngine::HGSharedLightData::get_softSourceRadius_Injected(&_unity_self, 0LL);
			//       DWORD2(v194) = UnityEngine::HGSharedLightData::get_specularIntensity_Injected(&_unity_self, 0LL);
			//       *((float *)&v194 + 3) = (float)v61;
			//       v125 = v194;
			//     }
			//     *(_OWORD *)&this.fields.m_punctualLightDataArray.m_Buffer[16 * v43 * v124 + 208] = v125;
			// LABEL_47:
			//     ++v43;
			//     v47 = v206;
			//     v46 = (float *)&v187[4];
			//     lightCookieManager = v207;
			//     m_Buffer = *(Void **)&v178.x;
			//     v176 = v43;
			//     v187 += 4;
			//   }
			//   while ( v43 < this.fields.m_binningConstants.lightCount );
			//   v10 = visibleLights;
			// LABEL_49:
			//   v152 = this.fields.m_punctualLightDataArray.m_Buffer;
			//   HIDWORD(v181) = 0;
			//   v153 = (NativeArray_1_UnityEngine_Rendering_VisibleLight_)v186;
			//   v154 = v169;
			//   *(__m128i *)v152 = v212;
			//   v155 = this.fields.m_punctualLightDataArray.m_Buffer;
			//   v156 = (NativeArray_1_System_Int32_)v182;
			//   DWORD1(v181) = v154;
			//   *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v155[16] = v153;
			//   v157 = (Vector4)v173;
			//   *(NativeArray_1_System_Int32_ *)&this.fields.m_punctualLightDataArray.m_Buffer[32] = v156;
			//   v158 = this.fields.m_punctualLightDataArray.m_Buffer;
			//   *(float *)&v181 = specularIntensity_Injected;
			//   *(Vector4 *)&v158[48] = v157;
			//   DWORD2(v181) = v170;
			//   *(_OWORD *)&v166[1] = v181;
			//   *(__m128i *)&this.fields.m_punctualLightDataArray.m_Buffer[64] = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4((Vector4 *)&v183, (CinemachineSmoothPath_Waypoint *)&v166[1], 0LL));
			//   v159 = this.fields.m_punctualLightDataArray.m_Buffer;
			//   *(uint4 *)&v159[80] = *lightMasks;
			//   v160 = (NativeArray_1_System_Single_)*v10;
			//   *(NativeArray_1_System_Int32_ *)&v166[1] = *lightIndices;
			//   v173 = v160;
			//   sub_180836664(
			//     (_DWORD)v159,
			//     (_DWORD)this,
			//     (_DWORD)camera,
			//     (unsigned int)&v173,
			//     (__int64)&v166[1],
			//     directionalLightIndex);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int MAX_NUM_TILE_X;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static readonly int MAX_NUM_TILE_Y;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly int NUM_Z_SLICES;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		public static readonly int NUM_FLOAT4_PUNCTUALIGHT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly int NUM_FLOAT4_PUNCTUALIGHT_DESC;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		public static readonly int XYPLANE_BINNING_GROUP_SIZE;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly int ZPLANE_BINNING_GROUP_SIZE;

		protected NativeArray<float3> m_frustumCorners;

		protected NativeArray<float3> m_tileVertices;

		protected NativeArray<float4> m_XPlanes;

		protected NativeArray<float4> m_YPlanes;

		protected NativeArray<float4> m_lightSphereData;

		private LightCulling.BinningConstants m_binningConstants;

		private ComputeBufferDesc m_punctualLightDataDesc;

		protected ComputeBufferHandle m_punctualLightDataBuffer;

		protected NativeArray<float4> m_punctualLightDataArray;

		protected bool m_outputTileDrawBuffers;

		protected GraphicsBuffer m_quadIndexBuffer;

		protected ComputeBuffer[] m_drawTileArgsBuffers;

		protected uint m_frameIndex;

		protected bool m_needClearArgsBuffer;

		protected ComputeBufferHandle m_drawTileArgsBufferHandle;

		protected ComputeBufferHandle m_drawTileArgsBufferNextFrameHandle;

		protected ComputeBufferHandle m_tileInstanceIndicesBufferHandle;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		protected struct BinningConstants
		{
			internal int lightCount;

			internal int numTiles;

			internal int actualWidth;

			internal int actualHeight;

			internal float tileSize;

			internal float numTilesX;

			internal float numTilesY;

			internal float numSliceZ;

			internal float nearClipPlane;

			internal float farClipPlane;

			internal float zBinSlice;

			internal float invZBinSlice;
		}
	}
}
