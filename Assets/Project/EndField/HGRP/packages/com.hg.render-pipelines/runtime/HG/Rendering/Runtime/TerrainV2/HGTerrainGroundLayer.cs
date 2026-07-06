using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.TerrainV2
{
	public class HGTerrainGroundLayer
	{
		public HGTerrainGroundLayer()
		{
			// // HGTerrainGroundLayer()
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::HGTerrainGroundLayer(
			//         HGTerrainGroundLayer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v3; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v5; // rdx
			//   Bounds *v6; // r8
			//   Object__Array *v7; // r9
			//   MethodInfo *v8; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v9; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC1A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap);
			//     byte_18D8EDC1A = 1;
			//   }
			//   this.fields.clipmaps = (HGTerrainGroundLayerClipmap__Array *)il2cpp_array_new_specific_0(
			//                                                                   TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap,
			//                                                                   2LL,
			//                                                                   v2,
			//                                                                   v3);
			//   sub_1800054D0((BSP *)&this.fields.clipmaps, v5, v6, v7, v8, v9);
			// }
			// 
		}

		private void InitializeRenderTextureResources()
		{
			// // Void InitializeRenderTextureResources()
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::InitializeRenderTextureResources(
			//         HGTerrainGroundLayer *this,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v3; // rdx
			//   Bounds *v4; // r8
			//   Object__Array *v5; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v6; // rdx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v9; // rdx
			//   Bounds *v10; // r8
			//   Object__Array *v11; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v12; // rdx
			//   Bounds *v13; // r8
			//   Object__Array *v14; // r9
			//   Texture2D *blackTexture; // rbx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v16; // rdx
			//   Bounds *v17; // r8
			//   Object__Array *v18; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   MethodInfo *colorFormat; // [rsp+20h] [rbp-98h]
			//   MethodInfo *colorFormata; // [rsp+20h] [rbp-98h]
			//   MethodInfo *colorFormatb; // [rsp+20h] [rbp-98h]
			//   MethodInfo *colorFormatc; // [rsp+20h] [rbp-98h]
			//   MethodInfo *colorFormatd; // [rsp+20h] [rbp-98h]
			//   MethodInfo *filterMode; // [rsp+28h] [rbp-90h]
			//   MethodInfo *filterModea; // [rsp+28h] [rbp-90h]
			//   MethodInfo *filterModeb; // [rsp+28h] [rbp-90h]
			//   MethodInfo *filterModec; // [rsp+28h] [rbp-90h]
			//   MethodInfo *filterModed; // [rsp+28h] [rbp-90h]
			// 
			//   if ( !byte_18D919D38 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18D5DF238);
			//     sub_18003C530(&off_18D5DF230);
			//     sub_18003C530(&off_18D5DF268);
			//     byte_18D919D38 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2842, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2842, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_groundLayerBaseRT )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_groundLayerBaseRT = UnityEngine::Rendering::RTHandles::Alloc(
			//                                            1024,
			//                                            1024,
			//                                            2,
			//                                            DepthBits__Enum_None,
			//                                            GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//                                            FilterMode__Enum_Bilinear,
			//                                            TextureWrapMode__Enum_Clamp,
			//                                            TextureDimension__Enum_Tex2DArray,
			//                                            1,
			//                                            0,
			//                                            0,
			//                                            0,
			//                                            1,
			//                                            0.0,
			//                                            MSAASamples__Enum_None,
			//                                            0,
			//                                            RenderTextureMemoryless__Enum_None,
			//                                            (String *)"TerrainGroundLayerBaseRT",
			//                                            0LL);
			//       sub_1800054D0((BSP *)&this.fields, v3, v4, v5, colorFormata, filterModea);
			//     }
			//     if ( !this.fields.m_groundLayerNormalRT )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_groundLayerNormalRT = UnityEngine::Rendering::RTHandles::Alloc(
			//                                              1024,
			//                                              1024,
			//                                              2,
			//                                              DepthBits__Enum_None,
			//                                              GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//                                              FilterMode__Enum_Bilinear,
			//                                              TextureWrapMode__Enum_Clamp,
			//                                              TextureDimension__Enum_Tex2DArray,
			//                                              1,
			//                                              0,
			//                                              0,
			//                                              0,
			//                                              1,
			//                                              0.0,
			//                                              MSAASamples__Enum_None,
			//                                              0,
			//                                              RenderTextureMemoryless__Enum_None,
			//                                              (String *)"TerrainGroundLayerNormalRT",
			//                                              0LL);
			//       sub_1800054D0((BSP *)&this.fields.m_groundLayerNormalRT, v6, v7, v8, colorFormatb, filterModeb);
			//     }
			//     if ( !this.fields.m_groundLayerWetRT )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_groundLayerWetRT = UnityEngine::Rendering::RTHandles::Alloc(
			//                                           1024,
			//                                           1024,
			//                                           2,
			//                                           DepthBits__Enum_None,
			//                                           GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//                                           FilterMode__Enum_Bilinear,
			//                                           TextureWrapMode__Enum_Clamp,
			//                                           TextureDimension__Enum_Tex2DArray,
			//                                           1,
			//                                           0,
			//                                           0,
			//                                           0,
			//                                           1,
			//                                           0.0,
			//                                           MSAASamples__Enum_None,
			//                                           0,
			//                                           RenderTextureMemoryless__Enum_None,
			//                                           (String *)"TerrainGroundLayerWetRT",
			//                                           0LL);
			//       sub_1800054D0((BSP *)&this.fields.m_groundLayerWetRT, v9, v10, v11, colorFormatc, filterModec);
			//     }
			//     if ( !this.fields.m_groundLayerHeightRT )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_groundLayerHeightRT = UnityEngine::Rendering::RTHandles::Alloc(
			//                                              1024,
			//                                              1024,
			//                                              2,
			//                                              DepthBits__Enum_None,
			//                                              GraphicsFormat__Enum_R16_UNorm,
			//                                              FilterMode__Enum_Bilinear,
			//                                              TextureWrapMode__Enum_Clamp,
			//                                              TextureDimension__Enum_Tex2DArray,
			//                                              1,
			//                                              0,
			//                                              0,
			//                                              0,
			//                                              1,
			//                                              0.0,
			//                                              MSAASamples__Enum_None,
			//                                              0,
			//                                              RenderTextureMemoryless__Enum_None,
			//                                              (String *)"TerrainGroundLayerWetRT",
			//                                              0LL);
			//       sub_1800054D0((BSP *)&this.fields.m_groundLayerHeightRT, v12, v13, v14, colorFormatd, filterModed);
			//     }
			//     if ( !this.fields.m_defaultRT )
			//     {
			//       blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_defaultRT = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)blackTexture, 0LL);
			//       sub_1800054D0((BSP *)&this.fields.m_defaultRT, v16, v17, v18, colorFormat, filterMode);
			//     }
			//   }
			// }
			// 
		}

		public void Initialize()
		{
			// // Void Initialize()
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Initialize(
			//         HGTerrainGroundLayer *this,
			//         MethodInfo *method)
			// {
			//   float v3; // xmm6_4
			//   __int64 v4; // rbx
			//   HGTerrainGroundLayerClipmap__Array *clipmaps; // rsi
			//   __int64 v6; // rax
			//   __int64 v7; // rdx
			//   HGTerrainGroundLayerClipmap__Array *v8; // rcx
			//   __int64 v9; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC19 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap);
			//     byte_18D8EDC19 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4757, 0LL) )
			//   {
			//     v3 = 15.0;
			//     v4 = 0LL;
			//     while ( 1 )
			//     {
			//       clipmaps = this.fields.clipmaps;
			//       v6 = sub_180004920(TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap);
			//       v9 = v6;
			//       if ( !v6 )
			//         break;
			//       *(_DWORD *)(v6 + 28) = 1092616192;
			//       *(_QWORD *)(v6 + 16) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//       *(_DWORD *)(v6 + 24) = 0;
			//       if ( !clipmaps )
			//         break;
			//       sub_180036D40(clipmaps, v6);
			//       sub_18000FDA0(clipmaps, (unsigned int)v4, v9);
			//       v8 = this.fields.clipmaps;
			//       if ( !v8 )
			//         break;
			//       if ( (unsigned int)v4 >= v8.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = (HGTerrainGroundLayerClipmap__Array *)v8.vector[v4];
			//       if ( !v8 )
			//         break;
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Initialize(
			//         (HGTerrainGroundLayerClipmap *)v8,
			//         v3,
			//         v4,
			//         0LL);
			//       v3 = v3 * 5.0;
			//       v4 = (unsigned int)(v4 + 1);
			//       if ( (unsigned int)v4 >= 2 )
			//         return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4757, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void Release()
		{
		}

		public void GetTerrainDeformParams(ref ShaderVariablesGlobal cb)
		{
			// // Void GetTerrainDeformParams(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::GetTerrainDeformParams(
			//         HGTerrainGroundLayer *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   int v6; // ebx
			//   char *i; // rdi
			//   HGTerrainGroundLayerClipmap__Array *clipmaps; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 params0; // [rsp+20h] [rbp-20h] BYREF
			//   Vector4 params1; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   params0 = 0LL;
			//   params1 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2831, 0LL) )
			//   {
			//     v6 = 0;
			//     for ( i = (char *)&cb[1]._PrevViewProjMatrix.m10; ; i += 16 )
			//     {
			//       clipmaps = this.fields.clipmaps;
			//       if ( !clipmaps )
			//         break;
			//       if ( (unsigned int)v6 >= clipmaps.max_length.size )
			//         sub_180070270(clipmaps, v5);
			//       clipmaps = (HGTerrainGroundLayerClipmap__Array *)clipmaps.vector[v6];
			//       if ( !clipmaps )
			//         break;
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::GetTerrainDeformParams(
			//         (HGTerrainGroundLayerClipmap *)clipmaps,
			//         &params0,
			//         &params1,
			//         0LL);
			//       ++v6;
			//       *(Vector4 *)(i - 4) = params0;
			//       *(Vector4 *)(i + 28) = params1;
			//       if ( v6 >= 2 )
			//         return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(clipmaps, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2831, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		public void SetPlayerCenter(Vector3 position)
		{
			// // Void SetPlayerCenter(Vector3)
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::SetPlayerCenter(
			//         HGTerrainGroundLayer *this,
			//         Vector3 *position,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGTerrainGroundLayerClipmap__Array *clipmaps; // rbx
			//   int32_t v8; // edi
			//   float v9; // eax
			//   float z; // eax
			//   Vector3 v11[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3424, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3424, 0LL);
			//     if ( Patch )
			//     {
			//       z = position.z;
			//       *(_QWORD *)&v11[0].x = *(_QWORD *)&position.x;
			//       v11[0].z = z;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, v11, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(Patch, v5);
			//   }
			//   clipmaps = this.fields.clipmaps;
			//   v8 = 0;
			//   if ( !clipmaps )
			//     goto LABEL_8;
			//   while ( v8 < clipmaps.max_length.size )
			//   {
			//     if ( (unsigned int)v8 >= clipmaps.max_length.size )
			//       sub_180070270(Patch, v5);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)clipmaps.vector[v8];
			//     if ( !Patch )
			//       goto LABEL_8;
			//     v9 = position.z;
			//     *(_QWORD *)&v11[0].x = *(_QWORD *)&position.x;
			//     v11[0].z = v9;
			//     HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::SetPlayerCenter(
			//       (HGTerrainGroundLayerClipmap *)Patch,
			//       v11,
			//       0LL);
			//     ++v8;
			//   }
			// }
			// 
		}

		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void Render(HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Render(
			//         HGTerrainGroundLayer *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v7; // rdx
			//   Bounds *v8; // r8
			//   Object__Array *v9; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Bounds *v11; // r8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v12; // rdx
			//   Bounds *v13; // r8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v16; // rdx
			//   Bounds *v17; // r8
			//   __int64 v18; // rdx
			//   __int128 v19; // xmm6
			//   unsigned int v20; // ebx
			//   __int128 v21; // xmm7
			//   Node_2 *root; // xmm8_8
			//   HGTerrainGroundLayerClipmap__Array *clipmaps; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v25; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v29; // [rsp+28h] [rbp-49h]
			//   MethodInfo *v30; // [rsp+30h] [rbp-41h]
			//   MethodInfo *v31; // [rsp+30h] [rbp-41h]
			//   MethodInfo *v32; // [rsp+30h] [rbp-41h]
			//   MethodInfo *v33; // [rsp+30h] [rbp-41h]
			//   MethodInfo *v34; // [rsp+30h] [rbp-41h]
			//   BSP v35; // [rsp+38h] [rbp-39h] BYREF
			//   Node_2 *v36; // [rsp+88h] [rbp+17h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2841, 0LL) )
			//   {
			//     HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::InitializeRenderTextureResources(this, 0LL);
			//     v35.klass = (BSP__Class *)this.fields.m_groundLayerBaseRT;
			//     memset(&v35.monitor, 0, 32);
			//     sub_1800054D0(&v35, v7, v8, v9, v25, v30);
			//     v35.monitor = (MonitorData *)this.fields.m_groundLayerNormalRT;
			//     sub_1800054D0((BSP *)&v35.monitor, v10, v11, (Object__Array *)v35.monitor, v26, v31);
			//     *(_QWORD *)&v35.fields._createDescription = this.fields.m_groundLayerWetRT;
			//     sub_1800054D0((BSP *)&v35.fields, v12, v13, *(Object__Array **)&v35.fields._createDescription, v27, v32);
			//     v35.fields.description = (Object__Array *)this.fields.m_groundLayerHeightRT;
			//     sub_1800054D0((BSP *)&v35.fields.description, v14, v15, v35.fields.description, v28, v33);
			//     v35.fields.root = (Node_2 *)this.fields.m_defaultRT;
			//     sub_1800054D0((BSP *)&v35.fields.root, v16, v17, (Object__Array *)v35.fields.root, v29, v34);
			//     v19 = *(_OWORD *)&v35.klass;
			//     v20 = 0;
			//     v21 = *(_OWORD *)&v35.fields._createDescription;
			//     root = v35.fields.root;
			//     while ( 1 )
			//     {
			//       clipmaps = this.fields.clipmaps;
			//       if ( !clipmaps )
			//         break;
			//       if ( v20 >= clipmaps.max_length.size )
			//         sub_180070270(clipmaps, v18);
			//       clipmaps = (HGTerrainGroundLayerClipmap__Array *)clipmaps.vector[v20];
			//       if ( !clipmaps )
			//         break;
			//       *(_OWORD *)&v35.fields._Bounds_k__BackingField.hasValue = v19;
			//       *(_OWORD *)&v35.fields._Bounds_k__BackingField.value.m_Extents.x = v21;
			//       v36 = root;
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Render(
			//         (HGTerrainGroundLayerClipmap *)clipmaps,
			//         renderGraph,
			//         hgCamera,
			//         (GroundLayerRTs *)&v35.fields._Bounds_k__BackingField,
			//         0LL);
			//       if ( (int)++v20 >= 2 )
			//         return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(clipmaps, v18);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2841, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private RTHandle m_groundLayerBaseRT;

		private RTHandle m_groundLayerNormalRT;

		private RTHandle m_groundLayerWetRT;

		private RTHandle m_groundLayerHeightRT;

		private RTHandle m_defaultRT;

		public const int TEXTURE_SIZE = 1024;

		public const int TERRAIN_GROUND_LAYER_CLIPMAP_NUM = 2;

		private HGTerrainGroundLayerClipmap[] clipmaps;
	}
}
