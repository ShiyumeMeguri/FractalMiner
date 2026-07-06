using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	public static class HGUtils
	{
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000025D2 File Offset: 0x000007D2
		internal static HGAdditionalCameraData s_DefaultHGAdditionalCameraData
		{
			get
			{
				// // HGAdditionalCameraData get_s_DefaultHGAdditionalCameraData()
				// HGAdditionalCameraData *HG::Rendering::Runtime::HGUtils::get_s_DefaultHGAdditionalCameraData(MethodInfo *method)
				// {
				//   if ( !byte_18D9196AA )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::get_instance);
				//     byte_18D9196AA = 1;
				//   }
				//   return (HGAdditionalCameraData *)UnityEngine::Rendering::ComponentSingleton<System::Object>::get_instance(MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::get_instance);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Texture3D clearTexture3D
		{
			get
			{
				// // Texture3D get_clearTexture3D()
				// Texture3D *HG::Rendering::Runtime::HGUtils::get_clearTexture3D(MethodInfo *method)
				// {
				//   Object_1 *m_ClearTexture3D; // rbx
				//   Texture3D *v2; // rax
				//   __int64 v3; // rdx
				//   Texture3D *m_ClearTexture3DRTH; // rcx
				//   Object_1 *v5; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
				//   PassConstructorID__Enum__Array *v7; // r8
				//   HGCamera *v8; // r9
				//   TileBase *v9; // rdx
				//   Vector3Int *v10; // r8
				//   TileAnimationData *TileAnimationDataNoRef; // rax
				//   Texture3D *v12; // r10
				//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
				//   PassConstructorID__Enum__Array *v14; // r8
				//   HGCamera *v15; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *formata; // [rsp+20h] [rbp-38h]
				//   MethodInfo *formatb; // [rsp+20h] [rbp-38h]
				//   MethodInfo *format; // [rsp+20h] [rbp-38h]
				//   MethodInfo *v21; // [rsp+28h] [rbp-30h]
				//   MethodInfo *v22; // [rsp+28h] [rbp-30h]
				//   TileAnimationData v23; // [rsp+40h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D9196AB )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&TypeInfo::UnityEngine::Texture3D);
				//     sub_18003C530(&off_18D5115B0);
				//     byte_18D9196AB = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3153, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     m_ClearTexture3D = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3D;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Equality(m_ClearTexture3D, 0LL, 0LL) )
				//     {
				// LABEL_10:
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
				//       return TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3D;
				//     }
				//     v2 = (Texture3D *)sub_180004920(TypeInfo::UnityEngine::Texture3D);
				//     v5 = (Object_1 *)v2;
				//     if ( v2 )
				//     {
				//       UnityEngine::Texture3D::Texture3D(
				//         v2,
				//         1,
				//         1,
				//         1,
				//         GraphicsFormat__Enum_R8G8B8A8_SRGB,
				//         TextureCreationFlags__Enum_None,
				//         0LL);
				//       UnityEngine::Object::set_name(v5, (String *)"Transparent Texture 3D", 0LL);
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
				//       TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3D = (Texture3D *)v5;
				//       sub_1800054D0(
				//         (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3D,
				//         v6,
				//         v7,
				//         v8,
				//         formata,
				//         v21);
				//       TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                  &v23,
				//                                  v9,
				//                                  v10,
				//                                  (ITilemap *)TypeInfo::HG::Rendering::Runtime::HGUtils,
				//                                  formatb);
				//       if ( v12 )
				//       {
				//         v23 = *TileAnimationDataNoRef;
				//         UnityEngine::Texture3D::SetPixel(v12, 0, 0, 0, (Color *)&v23, 0LL);
				//         m_ClearTexture3DRTH = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3D;
				//         if ( m_ClearTexture3DRTH )
				//         {
				//           UnityEngine::Texture3D::Apply(m_ClearTexture3DRTH, 0LL);
				//           m_ClearTexture3DRTH = (Texture3D *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3DRTH;
				//           if ( m_ClearTexture3DRTH )
				//           {
				//             UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_ClearTexture3DRTH, 0LL);
				//             TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3DRTH = 0LL;
				//             sub_1800054D0(
				//               (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_ClearTexture3DRTH,
				//               v13,
				//               v14,
				//               v15,
				//               format,
				//               v22);
				//             goto LABEL_10;
				//           }
				//         }
				//       }
				//     }
				// LABEL_12:
				//     sub_180B536AC(m_ClearTexture3DRTH, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3153, 0LL);
				//   if ( !Patch )
				//     goto LABEL_12;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001397 RID: 5015 RVA: 0x000025D2 File Offset: 0x000007D2
		public static RTHandle clearTexture3DRTH
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000025D2 File Offset: 0x000007D2
		public static RenderPipelineSettings hgrpSettings
		{
			get
			{
				// // RenderPipelineSettings get_hgrpSettings()
				// RenderPipelineSettings *HG::Rendering::Runtime::HGUtils::get_hgrpSettings(
				//         RenderPipelineSettings *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineAsset *currentAsset; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   __int128 v6; // xmm1
				//   __int128 v7; // xmm0
				//   __int128 v8; // xmm1
				//   __int128 v9; // xmm0
				//   __int128 v10; // xmm1
				//   __int128 v11; // xmm0
				//   RenderPipelineSettings *result; // rax
				// 
				//   if ( !byte_18D9196AD )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
				//     byte_18D9196AD = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
				//   currentAsset = HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
				//   if ( !currentAsset )
				//     sub_180B536AC(v5, v4);
				//   v6 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
				//   *(_OWORD *)&retstr.colorBufferFormat = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.colorBufferFormat;
				//   v7 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
				//   *(_OWORD *)&retstr.dynamicResolutionSettings.DLSSSharpness = v6;
				//   v8 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
				//   *(_OWORD *)&retstr.dynamicResolutionSettings.forcedPercentage = v7;
				//   v9 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName0 = v8;
				//   v10 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName2 = v9;
				//   v11 = *(_OWORD *)&currentAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
				//   result = retstr;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName4 = v10;
				//   *(_OWORD *)&retstr.m_ObsoleteLightLayerName6 = v11;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public static PerObjectData GetBakedLightingRenderConfig()
		{
			// // PerObjectData GetBakedLightingRenderConfig()
			// PerObjectData__Enum HG::Rendering::Runtime::HGUtils::GetBakedLightingRenderConfig(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3151, 0LL) )
			//     return 15;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3151, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return (PerObjectData)PerObjectData.None;
		}

		public static PerObjectData GetBakedLightingWithShadowMaskRenderConfig()
		{
			// // PerObjectData GetBakedLightingWithShadowMaskRenderConfig()
			// PerObjectData__Enum HG::Rendering::Runtime::HGUtils::GetBakedLightingWithShadowMaskRenderConfig(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3152, 0LL) )
			//     return 1807;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3152, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return (PerObjectData)PerObjectData.None;
		}

		public static Material GetBlitMaterial(bool isFP32Output, TextureDimension dimension, [MetadataOffset(Offset = "0x01F91A88")] bool singleSlice = false)
		{
			// // Material GetBlitMaterial(Boolean, TextureDimension, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// Material *HG::Rendering::Runtime::HGUtils::GetBlitMaterial(
			//         bool isFP32Output,
			//         TextureDimension__Enum dimension,
			//         bool singleSlice,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct Blitter__Class *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB29 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D8EDB29 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&dimension);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size > 1029 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x405 )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !v7[21].vtable.ToString.method )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1029, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_369(Patch, isFP32Output, dimension, singleSlice, 0LL);
			//     }
			// LABEL_17:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_9:
			//   v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//   if ( !TypeInfo::UnityEngine::Rendering::Blitter._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::Blitter, wrapperArray);
			//     v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//   }
			//   if ( !byte_18D8F362F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//     byte_18D8F362F = 1;
			//   }
			//   if ( dimension == TextureDimension__Enum_Tex2DArray )
			//   {
			//     if ( singleSlice )
			//     {
			//       if ( !v9._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v9, wrapperArray);
			//         v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//       }
			//       return v9.static_fields.s_BlitTexArraySingleSlice;
			//     }
			//     else
			//     {
			//       if ( !v9._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v9, wrapperArray);
			//         v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//       }
			//       return v9.static_fields.s_BlitTexArray;
			//     }
			//   }
			//   else
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::UnityEngine::Rendering::Blitter;
			//     }
			//     return v9.static_fields.s_Blit;
			//   }
			// }
			// 
			return null;
		}

		[IDTag(5)]
		public static Vector4 PackVector4(Vector3 v)
		{
			// // Vector4 PackVector4(Vector3)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1199, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1199, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.w = 0.0;
			//     retstr.x = x;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 PackVector4(Vector3 v, float w)
		{
			// // Vector4 PackVector4(Vector3, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         Vector3 *v,
			//         float w,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v11; // [rsp+30h] [rbp-38h] BYREF
			//   Vector4 v12; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 825 )
			//   {
			//     if ( !v6._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v6, wrapperArray);
			//       v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//     if ( v6 )
			//     {
			//       if ( LODWORD(v6._0.namespaze) <= 0x339 )
			//         sub_180070270(v6, wrapperArray);
			//       if ( !v6[17]._1.genericContainerHandle )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(825, 0LL);
			//       if ( Patch )
			//       {
			//         v10 = *(_QWORD *)&v.x;
			//         v11.z = v.z;
			//         *(_QWORD *)&v11.x = v10;
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_317(&v12, Patch, &v11, w, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = v.x;
			//   retstr.y = v.y;
			//   retstr.z = v.z;
			//   retstr.w = w;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(6)]
		public static Vector4 PackVector4(Color c)
		{
			// // Vector4 PackVector4(Color)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1264, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1264, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_476(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.w = 0.0;
			//     retstr.x = r;
			//     retstr.y = c.g;
			//     retstr.z = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(4)]
		public static Vector4 PackVector4(Color c, float w)
		{
			// // Vector4 PackVector4(Color, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         Color *c,
			//         float w,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+30h] [rbp-38h] BYREF
			//   Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1196, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1196, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_448(&v11, Patch, &v10, w, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.g;
			//     retstr.z = c.b;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(11)]
		public static Vector4 PackVector4(Vector2 v1)
		{
			// // Vector4 PackVector4(Vector2)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, Vector2 v1, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3155, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3155, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v1, 0LL);
			//   }
			//   else
			//   {
			//     retstr.z = 0.0;
			//     retstr.w = 0.0;
			//     *(Vector2 *)&retstr.x = v1;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(9)]
		public static Vector4 PackVector4(Vector2 v1, Vector2 v2)
		{
			// // Vector4 PackVector4(Vector2, Vector2)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         Vector2 v1,
			//         Vector2 v2,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v13; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1288, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1288, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_495(&v13, Patch, v1, v2, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v1;
			//     *(Vector2 *)&retstr.z = v2;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(8)]
		public static Vector4 PackVector4(Vector2 v, float f1, float f2)
		{
			// // Vector4 PackVector4(Vector2, Single, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         Vector2 v,
			//         float f1,
			//         float f2,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v12; // [rsp+38h] [rbp-50h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1277, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1277, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_486(&v12, Patch, v, f1, f2, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = f1;
			//     retstr.w = f2;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(7)]
		public static Vector4 PackVector4(float f1, float f2, Vector2 v)
		{
			// // Vector4 PackVector4(Single, Single, Vector2)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         float f1,
			//         float f2,
			//         Vector2 v,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v12; // [rsp+38h] [rbp-50h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1276, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1276, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_485(&v12, Patch, f1, f2, v, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.z = v;
			//     retstr.x = f1;
			//     retstr.y = f2;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(10)]
		public static Vector4 PackVector4(float f1)
		{
			// // Vector4 PackVector4(Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(Vector4 *__return_ptr retstr, float f1, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v8; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2758, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2758, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1010(&v8, Patch, f1, 0LL);
			//   }
			//   else
			//   {
			//     retstr.y = 0.0;
			//     retstr.z = 0.0;
			//     retstr.w = 0.0;
			//     retstr.x = f1;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 PackVector4(float f1, float f2)
		{
			// // Vector4 PackVector4(Single, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         float f1,
			//         float f2,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v10; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 867 )
			//   {
			//     if ( !v6._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v6, wrapperArray);
			//       v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//     if ( v6 )
			//     {
			//       if ( LODWORD(v6._0.namespaze) <= 0x363 )
			//         sub_180070270(v6, wrapperArray);
			//       if ( !v6[18]._1.typeHierarchy )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(867, 0LL);
			//       if ( Patch )
			//       {
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_335(&v10, Patch, f1, f2, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = f1;
			//   *(_QWORD *)&retstr.z = 0LL;
			//   retstr.y = f2;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static Vector4 PackVector4(float f1, float f2, float f3)
		{
			// // Vector4 PackVector4(Single, Single, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         float f1,
			//         float f2,
			//         float f3,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v11; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v5);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 869 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x365 )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !*(_QWORD *)&v7[18]._1.initializationExceptionGCHandle )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(869, 0LL);
			//       if ( Patch )
			//       {
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_336(&v11, Patch, f1, f2, f3, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = f1;
			//   retstr.w = 0.0;
			//   retstr.y = f2;
			//   retstr.z = f3;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 PackVector4(float f1, float f2, float f3, float f4)
		{
			// // Vector4 PackVector4(Single, Single, Single, Single)
			// Vector4 *HG::Rendering::Runtime::HGUtils::PackVector4(
			//         Vector4 *__return_ptr retstr,
			//         float f1,
			//         float f2,
			//         float f3,
			//         float f4,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v12; // [rsp+40h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v6);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v8.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 826 )
			//   {
			//     if ( !v8._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v8, wrapperArray);
			//       v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields.wrapperArray;
			//     if ( v8 )
			//     {
			//       if ( LODWORD(v8._0.namespaze) <= 0x33A )
			//         sub_180070270(v8, wrapperArray);
			//       if ( !*(_QWORD *)&v8[17]._1.instance_size )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
			//       if ( Patch )
			//       {
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_318(&v12, Patch, f1, f2, f3, f4, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v8, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.w = f4;
			//   retstr.x = f1;
			//   retstr.y = f2;
			//   retstr.z = f3;
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static int GetRuntimeDebugPanelWidth(HGCamera hgCamera)
		{
			// // Int32 GetRuntimeDebugPanelWidth(HGCamera)
			// int32_t HG::Rendering::Runtime::HGUtils::GetRuntimeDebugPanelWidth(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   DebugManager *instance; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   bool displayRuntimeUI; // al
			//   int32_t actualWidth_k__BackingField; // edi
			//   int32_t v8; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196AE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugManager);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D9196AE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3156, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3156, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//                (ILFixDynamicMethodWrapper_29 *)Patch,
			//                (Object *)hgCamera,
			//                0LL);
			// LABEL_10:
			//     sub_180B536AC(v5, v4);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::DebugManager);
			//   instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_10;
			//   displayRuntimeUI = UnityEngine::Rendering::DebugManager::get_displayRuntimeUI(instance, 0LL);
			//   if ( !hgCamera )
			//     goto LABEL_10;
			//   actualWidth_k__BackingField = hgCamera.fields._actualWidth_k__BackingField;
			//   v8 = displayRuntimeUI ? 0x262 : 0;
			//   sub_180002C70(TypeInfo::System::Math);
			//   if ( actualWidth_k__BackingField <= v8 )
			//     return actualWidth_k__BackingField;
			//   return v8;
			// }
			// 
			return 0;
		}

		internal static float ProjectionMatrixAspect(in Matrix4x4 matrix)
		{
			// // Single ProjectionMatrixAspect(Matrix4x4 ByRef)
			// float HG::Rendering::Runtime::HGUtils::ProjectionMatrixAspect(Matrix4x4 *matrix, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 710 )
			//     return (float)-matrix.m11 / matrix.m00;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x2C6 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[15]._0.castClass )
			//     return (float)-matrix.m11 / matrix.m00;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(710, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_264(Patch, matrix, 0LL);
			// }
			// 
			return 0f;
		}

		internal static bool IsProjectionMatrixAsymmetric(in Matrix4x4 matrix)
		{
			// // Boolean IsProjectionMatrixAsymmetric(Matrix4x4 ByRef)
			// bool HG::Rendering::Runtime::HGUtils::IsProjectionMatrixAsymmetric(Matrix4x4 *matrix, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 712 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x2C8 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[15]._0.parent )
			//         return matrix.m02 != 0.0 || matrix.m12 != 0.0;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(712, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_265(Patch, matrix, 0LL);
			//     }
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   return matrix.m02 != 0.0 || matrix.m12 != 0.0;
			// }
			// 
			return default(bool);
		}

		internal static Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(float verticalFoV, Vector2 lensShift, Vector4 screenSize, Matrix4x4 worldToViewMatrix, bool renderToCubemap, [MetadataOffset(Offset = "0x01F91A89")] float aspectRatio = -1f, [MetadataOffset(Offset = "0x01F91A8D")] bool isOrthographic = false)
		{
			// // Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(Single, Vector2, Vector4, Matrix4x4, Boolean, Single, Boolean)
			// Matrix4x4 *HG::Rendering::Runtime::HGUtils::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         float verticalFoV,
			//         Vector2 lensShift,
			//         Vector4 *screenSize,
			//         Matrix4x4 *worldToViewMatrix,
			//         bool renderToCubemap,
			//         float aspectRatio,
			//         bool isOrthographic,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // r8
			//   __int64 v15; // r9
			//   float v16; // xmm7_4
			//   float v17; // xmm3_4
			//   float v18; // xmm5_4
			//   float v19; // xmm6_4
			//   float v20; // xmm2_4
			//   __m128i v21; // xmm0
			//   Vector4 *v22; // r8
			//   Vector4 *v23; // rdx
			//   MethodInfo *v24; // r8
			//   Vector4 v25; // xmm6
			//   Matrix4x4 *transpose; // rax
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   void (__fastcall *v30)(Matrix4x4 *, _OWORD *, Matrix4x4 *); // rax
			//   __int128 v31; // xmm1
			//   void (__fastcall *v32)(Matrix4x4 *, __int128 *); // rax
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   Matrix4x4 *result; // rax
			//   float w; // xmm2_4
			//   float v38; // xmm3_4
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v42; // rcx
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   Vector4 v47; // xmm0
			//   Matrix4x4 *v48; // rax
			//   __int128 v49; // xmm1
			//   __int64 v50; // [rsp+54h] [rbp-B4h] BYREF
			//   _DWORD v51[7]; // [rsp+5Ch] [rbp-ACh] BYREF
			//   __m128i v52; // [rsp+78h] [rbp-90h] BYREF
			//   __m128i si128; // [rsp+88h] [rbp-80h] BYREF
			//   Vector2 v54; // [rsp+98h] [rbp-70h]
			//   Matrix4x4 v55; // [rsp+A8h] [rbp-60h] BYREF
			//   Matrix4x4 v56; // [rsp+E8h] [rbp-20h] BYREF
			//   __int128 v57; // [rsp+128h] [rbp+20h] BYREF
			//   __int128 v58; // [rsp+138h] [rbp+30h]
			//   __int128 v59; // [rsp+148h] [rbp+40h]
			//   __int128 v60; // [rsp+158h] [rbp+50h]
			//   Matrix4x4 v61; // [rsp+168h] [rbp+60h] BYREF
			//   _OWORD v62[4]; // [rsp+1A8h] [rbp+A0h] BYREF
			// 
			//   v54 = lensShift;
			//   memset(&v55, 0, sizeof(v55));
			//   if ( IFix::WrappersManagerImpl::IsPatched(713, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(713, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v42, 0LL);
			//     v44 = *(_OWORD *)&worldToViewMatrix.m01;
			//     *(_OWORD *)&v56.m00 = *(_OWORD *)&worldToViewMatrix.m00;
			//     v45 = *(_OWORD *)&worldToViewMatrix.m02;
			//     *(_OWORD *)&v56.m01 = v44;
			//     v46 = *(_OWORD *)&worldToViewMatrix.m03;
			//     *(_OWORD *)&v56.m02 = v45;
			//     v47 = *screenSize;
			//     *(_OWORD *)&v56.m03 = v46;
			//     v52 = (__m128i)v47;
			//     v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_266(
			//             &v61,
			//             Patch,
			//             verticalFoV,
			//             lensShift,
			//             (Vector4 *)&v52,
			//             &v56,
			//             renderToCubemap,
			//             aspectRatio,
			//             isOrthographic,
			//             0LL);
			//     v49 = *(_OWORD *)&v48.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v48.m00;
			//     v34 = *(_OWORD *)&v48.m02;
			//     *(_OWORD *)&retstr.m01 = v49;
			//     v35 = *(_OWORD *)&v48.m03;
			//   }
			//   else
			//   {
			//     if ( isOrthographic )
			//     {
			//       v22 = (Vector4 *)((char *)&v50 + 4);
			//       w = screenSize.w;
			//       v23 = (Vector4 *)&v51[3];
			//       v38 = screenSize.z * -2.0;
			//       v21 = 0LL;
			//       HIDWORD(v50) = 0;
			//       *(_QWORD *)&v51[1] = 0LL;
			//       *(float *)&v51[3] = v38;
			//       *(float *)v51 = w * -2.0;
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18C370E50);
			//       memset(&v51[4], 0, 12);
			//     }
			//     else
			//     {
			//       v16 = aspectRatio;
			//       if ( aspectRatio < 0.0 )
			//         v16 = screenSize.w * screenSize.x;
			//       v17 = sub_1802ED290(v13, v12, v14, v15);
			//       v18 = (float)(1.0 - (float)(v54.y * 2.0)) * v17;
			//       v19 = (float)(screenSize.w * -2.0) * v17;
			//       v20 = (float)((float)(screenSize.z * -2.0) * v17) * v16;
			//       if ( renderToCubemap )
			//       {
			//         v19 = -v19;
			//         v18 = -v18;
			//       }
			//       v21 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       v22 = (Vector4 *)&v51[3];
			//       *(float *)si128.m128i_i32 = (float)((float)(1.0 - (float)(v54.x * 2.0)) * v17) * v16;
			//       v23 = (Vector4 *)((char *)&v50 + 4);
			//       *(float *)&si128.m128i_i32[1] = v18;
			//       *(float *)&v51[4] = v19;
			//       *((float *)&v50 + 1) = v20;
			//       si128.m128i_i64[1] = 3212836864LL;
			//       *(_QWORD *)&v51[5] = 0LL;
			//       *(_OWORD *)v51 = 0uLL;
			//     }
			//     v52 = v21;
			//     UnityEngine::Matrix4x4::Matrix4x4(&v55, v23, v22, (Vector4 *)&si128, (Vector4 *)&v52, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 12, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 13, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 14, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 15, 1.0, 0LL);
			//     v52 = *(__m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v52, worldToViewMatrix, 2, 0LL);
			//     v25 = *UnityEngine::Vector4::op_UnaryNegation((Vector4 *)((char *)&v50 + 4), (Vector4 *)&v52, v24);
			//     UnityEngine::Matrix4x4::set_Item(worldToViewMatrix, 2, v25.x, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(
			//       worldToViewMatrix,
			//       6,
			//       _mm_shuffle_ps((__m128)v25, (__m128)v25, 85).m128_f32[0],
			//       0LL);
			//     UnityEngine::Matrix4x4::set_Item(
			//       worldToViewMatrix,
			//       10,
			//       _mm_shuffle_ps((__m128)v25, (__m128)v25, 170).m128_f32[0],
			//       0LL);
			//     UnityEngine::Matrix4x4::set_Item(
			//       worldToViewMatrix,
			//       14,
			//       _mm_shuffle_ps((__m128)v25, (__m128)v25, 255).m128_f32[0],
			//       0LL);
			//     transpose = UnityEngine::Matrix4x4::get_transpose(&v56, worldToViewMatrix, 0LL);
			//     v27 = *(_OWORD *)&transpose.m01;
			//     *(_OWORD *)&v61.m00 = *(_OWORD *)&transpose.m00;
			//     v28 = *(_OWORD *)&transpose.m02;
			//     *(_OWORD *)&v61.m01 = v27;
			//     v29 = *(_OWORD *)&transpose.m03;
			//     v30 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))qword_18D8F4BC0;
			//     *(_OWORD *)&v61.m02 = v28;
			//     v62[0] = *(_OWORD *)&v55.m00;
			//     *(_OWORD *)&v61.m03 = v29;
			//     v62[2] = *(_OWORD *)&v55.m02;
			//     v62[1] = *(_OWORD *)&v55.m01;
			//     v31 = *(_OWORD *)&v55.m03;
			//     memset(&v55, 0, sizeof(v55));
			//     v62[3] = v31;
			//     if ( !qword_18D8F4BC0 )
			//     {
			//       v30 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
			//                                                                        "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
			//                                                                        "x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v30 )
			//       {
			//         v39 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Un"
			//                 "ityEngine.Matrix4x4&)");
			//         sub_18000F750(v39, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v30;
			//     }
			//     v30(&v61, v62, &v55);
			//     v32 = (void (__fastcall *)(Matrix4x4 *, __int128 *))qword_18D8F4BD8;
			//     v56 = v55;
			//     v57 = 0LL;
			//     v58 = 0LL;
			//     v59 = 0LL;
			//     v60 = 0LL;
			//     if ( !qword_18D8F4BD8 )
			//     {
			//       v32 = (void (__fastcall *)(Matrix4x4 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix"
			//                                                             "4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v32 )
			//       {
			//         v40 = sub_1802DBBE8("UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v40, 0LL);
			//       }
			//       qword_18D8F4BD8 = (__int64)v32;
			//     }
			//     v32(&v56, &v57);
			//     v33 = v58;
			//     *(_OWORD *)&retstr.m00 = v57;
			//     v34 = v59;
			//     *(_OWORD *)&retstr.m01 = v33;
			//     v35 = v60;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v34;
			//   *(_OWORD *)&retstr.m03 = v35;
			//   return result;
			// }
			// 
			return null;
		}

		internal static float ComputZPlaneTexelSpacing(float planeDepth, float verticalFoV, float resolutionY)
		{
			// // Single ComputZPlaneTexelSpacing(Single, Single, Single)
			// float HG::Rendering::Runtime::HGUtils::ComputZPlaneTexelSpacing(
			//         float planeDepth,
			//         float verticalFoV,
			//         float resolutionY,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // r8
			//   __int64 v7; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3157, 0LL) )
			//     return (float)(sub_1802ED290(v5, v4, v6, v7) * (float)(2.0 / resolutionY)) * planeDepth;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3157, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v11, v10);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            planeDepth,
			//            verticalFoV,
			//            resolutionY,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear)
		{
			// // Void BlitQuad(CommandBuffer, Texture, Vector4, Vector4, Int32, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitQuad(
			//         CommandBuffer *cmd,
			//         Texture *source,
			//         Vector4 *scaleBiasTex,
			//         Vector4 *scaleBiasRT,
			//         int32_t mipLevelTex,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   Vector4 v11; // xmm1
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v14; // xmm1
			//   Vector4 v15; // [rsp+40h] [rbp-28h] BYREF
			//   Vector4 v16; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196AF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196AF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3158, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3158, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     v14 = *scaleBiasTex;
			//     v16 = *scaleBiasRT;
			//     v15 = v14;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1118(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       &v15,
			//       &v16,
			//       mipLevelTex,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v11 = *scaleBiasTex;
			//     v15 = *scaleBiasRT;
			//     v16 = v11;
			//     UnityEngine::Rendering::Blitter::BlitQuad(cmd, source, &v16, &v15, mipLevelTex, bilinear, 0LL);
			//   }
			// }
			// 
		}

		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			// // Void BlitQuadWithPadding(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitQuadWithPadding(
			//         CommandBuffer *cmd,
			//         Texture *source,
			//         Vector2 textureSize,
			//         Vector4 *scaleBiasTex,
			//         Vector4 *scaleBiasRT,
			//         int32_t mipLevelTex,
			//         bool bilinear,
			//         int32_t paddingInPixels,
			//         MethodInfo *method)
			// {
			//   Vector4 v13; // xmm1
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v16; // xmm1
			//   Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
			//   Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3159, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3159, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     v16 = *scaleBiasTex;
			//     v18 = *scaleBiasRT;
			//     v17 = v16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       textureSize,
			//       &v17,
			//       &v18,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *scaleBiasTex;
			//     v17 = *scaleBiasRT;
			//     v18 = v13;
			//     UnityEngine::Rendering::Blitter::BlitQuadWithPadding(
			//       cmd,
			//       source,
			//       textureSize,
			//       &v18,
			//       &v17,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			// }
			// 
		}

		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			// // Void BlitQuadWithPaddingMultiply(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitQuadWithPaddingMultiply(
			//         CommandBuffer *cmd,
			//         Texture *source,
			//         Vector2 textureSize,
			//         Vector4 *scaleBiasTex,
			//         Vector4 *scaleBiasRT,
			//         int32_t mipLevelTex,
			//         bool bilinear,
			//         int32_t paddingInPixels,
			//         MethodInfo *method)
			// {
			//   Vector4 v13; // xmm1
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v16; // xmm1
			//   Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
			//   Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3160, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3160, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     v16 = *scaleBiasTex;
			//     v18 = *scaleBiasRT;
			//     v17 = v16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       textureSize,
			//       &v17,
			//       &v18,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *scaleBiasTex;
			//     v17 = *scaleBiasRT;
			//     v18 = v13;
			//     UnityEngine::Rendering::Blitter::BlitQuadWithPaddingMultiply(
			//       cmd,
			//       source,
			//       textureSize,
			//       &v18,
			//       &v17,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			// }
			// 
		}

		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			// // Void BlitOctahedralWithPadding(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitOctahedralWithPadding(
			//         CommandBuffer *cmd,
			//         Texture *source,
			//         Vector2 textureSize,
			//         Vector4 *scaleBiasTex,
			//         Vector4 *scaleBiasRT,
			//         int32_t mipLevelTex,
			//         bool bilinear,
			//         int32_t paddingInPixels,
			//         MethodInfo *method)
			// {
			//   Vector4 v13; // xmm1
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v16; // xmm1
			//   Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
			//   Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3161, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3161, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     v16 = *scaleBiasTex;
			//     v18 = *scaleBiasRT;
			//     v17 = v16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       textureSize,
			//       &v17,
			//       &v18,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *scaleBiasTex;
			//     v17 = *scaleBiasRT;
			//     v18 = v13;
			//     UnityEngine::Rendering::Blitter::BlitOctahedralWithPadding(
			//       cmd,
			//       source,
			//       textureSize,
			//       &v18,
			//       &v17,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			// }
			// 
		}

		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
			// // Void BlitOctahedralWithPaddingMultiply(CommandBuffer, Texture, Vector2, Vector4, Vector4, Int32, Boolean, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitOctahedralWithPaddingMultiply(
			//         CommandBuffer *cmd,
			//         Texture *source,
			//         Vector2 textureSize,
			//         Vector4 *scaleBiasTex,
			//         Vector4 *scaleBiasRT,
			//         int32_t mipLevelTex,
			//         bool bilinear,
			//         int32_t paddingInPixels,
			//         MethodInfo *method)
			// {
			//   Vector4 v13; // xmm1
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v16; // xmm1
			//   Vector4 v17; // [rsp+50h] [rbp-38h] BYREF
			//   Vector4 v18; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3162, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3162, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     v16 = *scaleBiasTex;
			//     v18 = *scaleBiasRT;
			//     v17 = v16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       textureSize,
			//       &v17,
			//       &v18,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *scaleBiasTex;
			//     v17 = *scaleBiasRT;
			//     v18 = v13;
			//     UnityEngine::Rendering::Blitter::BlitOctahedralWithPaddingMultiply(
			//       cmd,
			//       source,
			//       textureSize,
			//       &v18,
			//       &v17,
			//       mipLevelTex,
			//       bilinear,
			//       paddingInPixels,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
			// // Void BlitTexture(CommandBuffer, RTHandle, Vector4, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         Vector4 *scaleBias,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3163, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3163, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     v11 = *scaleBias;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1120(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       &v11,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v11 = *scaleBias;
			//     UnityEngine::Rendering::Blitter::BlitTexture(cmd, source, &v11, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
			// // Void BlitTexture2D(CommandBuffer, RTHandle, Vector4, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitTexture2D(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         Vector4 *scaleBias,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v11; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196B5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3164, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3164, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     v11 = *scaleBias;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1120(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       &v11,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v11 = *scaleBias;
			//     UnityEngine::Rendering::Blitter::BlitTexture2D(cmd, source, &v11, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		private static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
			// // Void BlitTexture(CommandBuffer, RTHandle, Vector4, Material, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         Vector4 *scaleBias,
			//         Material *material,
			//         int32_t pass,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v12; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196B6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3165, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3165, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     v12 = *scaleBias;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1121(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       &v12,
			//       (Object *)material,
			//       pass,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v12 = *scaleBias;
			//     UnityEngine::Rendering::Blitter::BlitTexture(cmd, source, &v12, material, pass, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, [MetadataOffset(Offset = "0x01F91A8E")] float mipLevel = 0f, [MetadataOffset(Offset = "0x01F91A92")] bool bilinear = false)
		{
			// // Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         RTHandle *destination,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D9196B7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3166, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3166, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1122(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       (Object *)destination,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, [MetadataOffset(Offset = "0x01F91A93")] float mipLevel = 0f, [MetadataOffset(Offset = "0x01F91A97")] bool bilinear = false)
		{
			// // Void BlitCameraTexture2D(CommandBuffer, RTHandle, RTHandle, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitCameraTexture2D(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         RTHandle *destination,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D9196B8 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3167, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3167, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1122(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       (Object *)destination,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     UnityEngine::Rendering::Blitter::BlitCameraTexture2D(cmd, source, destination, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass)
		{
			// // Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Material, Int32)
			// void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         RTHandle *destination,
			//         Material *material,
			//         int32_t pass,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D9196B9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196B9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3168, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3168, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1011(
			//       (ILFixDynamicMethodWrapper_3 *)Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       (Object *)destination,
			//       (Object *)material,
			//       pass,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, material, pass, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(2)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, [MetadataOffset(Offset = "0x01F91A98")] float mipLevel = 0f, [MetadataOffset(Offset = "0x01F91A9C")] bool bilinear = false)
		{
			// // Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Vector4, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         RTHandle *destination,
			//         Vector4 *scaleBias,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 v13; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196BA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196BA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3169, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3169, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     v13 = *scaleBias;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1124(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       (Object *)destination,
			//       &v13,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *scaleBias;
			//     UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, &v13, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(3)]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, [MetadataOffset(Offset = "0x01F91A9D")] float mipLevel = 0f, [MetadataOffset(Offset = "0x01F91AA1")] bool bilinear = false)
		{
			// // Void BlitCameraTexture(CommandBuffer, RTHandle, RTHandle, Rect, Single, Boolean)
			// void HG::Rendering::Runtime::HGUtils::BlitCameraTexture(
			//         CommandBuffer *cmd,
			//         RTHandle *source,
			//         RTHandle *destination,
			//         Rect *destViewport,
			//         float mipLevel,
			//         bool bilinear,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Rect v13; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196BB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Blitter);
			//     byte_18D9196BB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3170, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3170, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     v13 = *destViewport;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1125(
			//       Patch,
			//       (Object *)cmd,
			//       (Object *)source,
			//       (Object *)destination,
			//       &v13,
			//       mipLevel,
			//       bilinear,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::Blitter);
			//     v13 = *destViewport;
			//     UnityEngine::Rendering::Blitter::BlitCameraTexture(cmd, source, destination, &v13, mipLevel, bilinear, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RTHandle colorBuffer, MaterialPropertyBlock properties = null, [MetadataOffset(Offset = "0x01F91AA2")] int shaderPassId = 0)
		{
			// // Void DrawFullScreen(CommandBuffer, Material, RTHandle, MaterialPropertyBlock, Int32)
			// void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
			//         CommandBuffer *commandBuffer,
			//         Material *material,
			//         RTHandle *colorBuffer,
			//         MaterialPropertyBlock *properties,
			//         int32_t shaderPassId,
			//         MethodInfo *method)
			// {
			//   _OWORD *v10; // rax
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   Matrix4x4 v16; // [rsp+50h] [rbp-88h] BYREF
			//   _BYTE v17[64]; // [rsp+90h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9196BC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196BC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3171, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//       commandBuffer,
			//       colorBuffer,
			//       ClearFlag__Enum_None,
			//       0,
			//       CubemapFace__Enum_Unknown,
			//       -1,
			//       0LL);
			//     v10 = (_OWORD *)sub_182805160(v17);
			//     if ( commandBuffer )
			//     {
			//       v13 = v10[1];
			//       *(_OWORD *)&v16.m00 = *v10;
			//       v14 = v10[2];
			//       *(_OWORD *)&v16.m01 = v13;
			//       v15 = v10[3];
			//       *(_OWORD *)&v16.m02 = v14;
			//       *(_OWORD *)&v16.m03 = v15;
			//       UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//         commandBuffer,
			//         &v16,
			//         material,
			//         shaderPassId,
			//         MeshTopology__Enum_Triangles,
			//         3,
			//         1,
			//         properties,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3171, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1011(
			//     (ILFixDynamicMethodWrapper_3 *)Patch,
			//     (Object *)commandBuffer,
			//     (Object *)material,
			//     (Object *)colorBuffer,
			//     (Object *)properties,
			//     shaderPassId,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RTHandle colorBuffer, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, [MetadataOffset(Offset = "0x01F91AA3")] int shaderPassId = 0)
		{
			// // Void DrawFullScreen(CommandBuffer, Material, RTHandle, RTHandle, MaterialPropertyBlock, Int32)
			// void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
			//         CommandBuffer *commandBuffer,
			//         Material *material,
			//         RTHandle *colorBuffer,
			//         RTHandle *depthStencilBuffer,
			//         MaterialPropertyBlock *properties,
			//         int32_t shaderPassId,
			//         MethodInfo *method)
			// {
			//   _OWORD *v11; // rax
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   Matrix4x4 v17; // [rsp+50h] [rbp-88h] BYREF
			//   _BYTE v18[64]; // [rsp+90h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9196BD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196BD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3172, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//       commandBuffer,
			//       colorBuffer,
			//       depthStencilBuffer,
			//       0,
			//       CubemapFace__Enum_Unknown,
			//       -1,
			//       0LL);
			//     v11 = (_OWORD *)sub_182805160(v18);
			//     if ( commandBuffer )
			//     {
			//       v14 = v11[1];
			//       *(_OWORD *)&v17.m00 = *v11;
			//       v15 = v11[2];
			//       *(_OWORD *)&v17.m01 = v14;
			//       v16 = v11[3];
			//       *(_OWORD *)&v17.m02 = v15;
			//       *(_OWORD *)&v17.m03 = v16;
			//       UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//         commandBuffer,
			//         &v17,
			//         material,
			//         shaderPassId,
			//         MeshTopology__Enum_Triangles,
			//         3,
			//         1,
			//         properties,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3172, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1126(
			//     Patch,
			//     (Object *)commandBuffer,
			//     (Object *)material,
			//     (Object *)colorBuffer,
			//     (Object *)depthStencilBuffer,
			//     (Object *)properties,
			//     shaderPassId,
			//     0LL);
			// }
			// 
		}

		[IDTag(2)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, [MetadataOffset(Offset = "0x01F91AA4")] int shaderPassId = 0)
		{
			// // Void DrawFullScreen(CommandBuffer, Material, RenderTargetIdentifier[], RTHandle, MaterialPropertyBlock, Int32)
			// void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
			//         CommandBuffer *commandBuffer,
			//         Material *material,
			//         RenderTargetIdentifier__Array *colorBuffers,
			//         RTHandle *depthStencilBuffer,
			//         MaterialPropertyBlock *properties,
			//         int32_t shaderPassId,
			//         MethodInfo *method)
			// {
			//   _OWORD *v11; // rax
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   Matrix4x4 v17; // [rsp+50h] [rbp-88h] BYREF
			//   _BYTE v18[64]; // [rsp+90h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9196BE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196BE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3173, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::SetRenderTarget(commandBuffer, colorBuffers, depthStencilBuffer, 0LL);
			//     v11 = (_OWORD *)sub_182805160(v18);
			//     if ( commandBuffer )
			//     {
			//       v14 = v11[1];
			//       *(_OWORD *)&v17.m00 = *v11;
			//       v15 = v11[2];
			//       *(_OWORD *)&v17.m01 = v14;
			//       v16 = v11[3];
			//       *(_OWORD *)&v17.m02 = v15;
			//       *(_OWORD *)&v17.m03 = v16;
			//       UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//         commandBuffer,
			//         &v17,
			//         material,
			//         shaderPassId,
			//         MeshTopology__Enum_Triangles,
			//         3,
			//         1,
			//         properties,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3173, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1126(
			//     Patch,
			//     (Object *)commandBuffer,
			//     (Object *)material,
			//     (Object *)colorBuffers,
			//     (Object *)depthStencilBuffer,
			//     (Object *)properties,
			//     shaderPassId,
			//     0LL);
			// }
			// 
		}

		[IDTag(3)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Rect viewport, Material material, RenderTargetIdentifier destination, MaterialPropertyBlock properties = null, [MetadataOffset(Offset = "0x01F91AA5")] int shaderPassId = 0, [MetadataOffset(Offset = "0x01F91AA6")] int depthSlice = -1)
		{
			// // Void DrawFullScreen(CommandBuffer, Rect, Material, RenderTargetIdentifier, MaterialPropertyBlock, Int32, Int32)
			// void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
			//         CommandBuffer *commandBuffer,
			//         Rect *viewport,
			//         Material *material,
			//         RenderTargetIdentifier *destination,
			//         MaterialPropertyBlock *properties,
			//         int32_t shaderPassId,
			//         int32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   __int128 v12; // xmm1
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   _OWORD *v15; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int64 v19; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v21; // xmm0
			//   Rect v22; // xmm1
			//   Rect v23; // [rsp+58h] [rbp-59h] BYREF
			//   Matrix4x4 v24; // [rsp+68h] [rbp-49h] BYREF
			//   _BYTE v25[64]; // [rsp+A8h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D9196BF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196BF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3174, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3174, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v19);
			//     v21 = *(_OWORD *)&destination.m_Type;
			//     *(_OWORD *)&v24.m01 = *(_OWORD *)&destination.m_BufferPointer;
			//     v22 = *viewport;
			//     *(_OWORD *)&v24.m00 = v21;
			//     *(_QWORD *)&v21 = *(_QWORD *)&destination.m_DepthSlice;
			//     v23 = v22;
			//     *(_QWORD *)&v24.m02 = v21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1127(
			//       Patch,
			//       (Object *)commandBuffer,
			//       &v23,
			//       (Object *)material,
			//       (RenderTargetIdentifier *)&v24,
			//       (Object *)properties,
			//       shaderPassId,
			//       depthSlice,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     v12 = *(_OWORD *)&destination.m_BufferPointer;
			//     *(_OWORD *)&v24.m00 = *(_OWORD *)&destination.m_Type;
			//     *(_QWORD *)&v24.m02 = *(_QWORD *)&destination.m_DepthSlice;
			//     *(_OWORD *)&v24.m01 = v12;
			//     UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//       commandBuffer,
			//       (RenderTargetIdentifier *)&v24,
			//       ClearFlag__Enum_None,
			//       0,
			//       CubemapFace__Enum_Unknown,
			//       depthSlice,
			//       0LL);
			//     if ( !commandBuffer )
			//       sub_180B536AC(v14, v13);
			//     v23 = *viewport;
			//     UnityEngine::Rendering::CommandBuffer::SetViewport(commandBuffer, &v23, 0LL);
			//     v15 = (_OWORD *)sub_182805160(v25);
			//     v16 = v15[1];
			//     *(_OWORD *)&v24.m00 = *v15;
			//     v17 = v15[2];
			//     *(_OWORD *)&v24.m01 = v16;
			//     v18 = v15[3];
			//     *(_OWORD *)&v24.m02 = v17;
			//     *(_OWORD *)&v24.m03 = v18;
			//     UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//       commandBuffer,
			//       &v24,
			//       material,
			//       shaderPassId,
			//       MeshTopology__Enum_Triangles,
			//       3,
			//       1,
			//       properties,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(4)]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Rect viewport, Material material, RenderTargetIdentifier destination, RTHandle depthStencilBuffer, MaterialPropertyBlock properties = null, [MetadataOffset(Offset = "0x01F91AA7")] int shaderPassId = 0)
		{
			// // Void DrawFullScreen(CommandBuffer, Rect, Material, RenderTargetIdentifier, RTHandle, MaterialPropertyBlock, Int32)
			// void HG::Rendering::Runtime::HGUtils::DrawFullScreen(
			//         CommandBuffer *commandBuffer,
			//         Rect *viewport,
			//         Material *material,
			//         RenderTargetIdentifier *destination,
			//         RTHandle *depthStencilBuffer,
			//         MaterialPropertyBlock *properties,
			//         int32_t shaderPassId,
			//         MethodInfo *method)
			// {
			//   RenderTargetIdentifier *v12; // rax
			//   __int128 v13; // xmm7
			//   __int128 v14; // xmm8
			//   __int64 v15; // xmm6_8
			//   __int128 v16; // xmm1
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   _OWORD *v19; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int64 v23; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v25; // xmm0
			//   Rect v26; // xmm1
			//   Rect v27; // [rsp+58h] [rbp-B0h] BYREF
			//   Matrix4x4 v28; // [rsp+68h] [rbp-A0h] BYREF
			//   RenderTargetIdentifier v29[2]; // [rsp+A8h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D9196C0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196C0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3175, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3175, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v23);
			//     v25 = *(_OWORD *)&destination.m_Type;
			//     *(_OWORD *)&v28.m01 = *(_OWORD *)&destination.m_BufferPointer;
			//     v26 = *viewport;
			//     *(_OWORD *)&v28.m00 = v25;
			//     *(_QWORD *)&v28.m02 = *(_QWORD *)&destination.m_DepthSlice;
			//     v27 = v26;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1128(
			//       Patch,
			//       (Object *)commandBuffer,
			//       &v27,
			//       (Object *)material,
			//       (RenderTargetIdentifier *)&v28,
			//       (Object *)depthStencilBuffer,
			//       (Object *)properties,
			//       shaderPassId,
			//       0LL);
			//   }
			//   else
			//   {
			//     v12 = UnityEngine::Rendering::RTHandle::op_Implicit((RenderTargetIdentifier *)&v28, depthStencilBuffer, 0LL);
			//     v13 = *(_OWORD *)&v12.m_Type;
			//     v14 = *(_OWORD *)&v12.m_BufferPointer;
			//     v15 = *(_QWORD *)&v12.m_DepthSlice;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     v16 = *(_OWORD *)&destination.m_BufferPointer;
			//     *(_OWORD *)&v28.m00 = *(_OWORD *)&destination.m_Type;
			//     *(_QWORD *)&v28.m02 = *(_QWORD *)&destination.m_DepthSlice;
			//     *(_OWORD *)&v29[0].m_Type = v13;
			//     *(_OWORD *)&v29[0].m_BufferPointer = v14;
			//     *(_QWORD *)&v29[0].m_DepthSlice = v15;
			//     *(_OWORD *)&v28.m01 = v16;
			//     UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//       commandBuffer,
			//       (RenderTargetIdentifier *)&v28,
			//       v29,
			//       ClearFlag__Enum_None,
			//       0,
			//       CubemapFace__Enum_Unknown,
			//       -1,
			//       0LL);
			//     if ( !commandBuffer )
			//       sub_180B536AC(v18, v17);
			//     v27 = *viewport;
			//     UnityEngine::Rendering::CommandBuffer::SetViewport(commandBuffer, &v27, 0LL);
			//     v19 = (_OWORD *)sub_182805160(v29);
			//     v20 = v19[1];
			//     *(_OWORD *)&v28.m00 = *v19;
			//     v21 = v19[2];
			//     *(_OWORD *)&v28.m01 = v20;
			//     v22 = v19[3];
			//     *(_OWORD *)&v28.m02 = v21;
			//     *(_OWORD *)&v28.m03 = v22;
			//     UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//       commandBuffer,
			//       &v28,
			//       material,
			//       shaderPassId,
			//       MeshTopology__Enum_Triangles,
			//       3,
			//       1,
			//       properties,
			//       0LL);
			//   }
			// }
			// 
		}

		internal static Vector4 GetMouseCoordinates(HGCamera camera)
		{
			// // Vector4 GetMouseCoordinates(HGCamera)
			// Vector4 *HG::Rendering::Runtime::HGUtils::GetMouseCoordinates(
			//         Vector4 *__return_ptr retstr,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Camera *v6; // rcx
			//   MousePositionDebug *instance; // rsi
			//   float m_X; // xmm0_4
			//   __int64 v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
			//   Vector2 InputMousePosition; // [rsp+40h] [rbp+8h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3176, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3176, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v12, Patch, (Object *)camera, 0LL);
			//       return retstr;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   instance = UnityEngine::Rendering::MousePositionDebug::get_instance(0LL);
			//   if ( !camera )
			//     goto LABEL_7;
			//   v6 = camera.fields.camera;
			//   if ( !v6 )
			//     goto LABEL_7;
			//   UnityEngine::Camera::get_cameraType(v6, 0LL);
			//   if ( !instance )
			//     goto LABEL_7;
			//   InputMousePosition = UnityEngine::Rendering::MousePositionDebug::GetInputMousePosition(instance, 0LL);
			//   m_X = (float)camera.fields._taauRTSize_k__BackingField.m_X;
			//   v9 = HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField);
			//   *(Vector2 *)&retstr.x = InputMousePosition;
			//   retstr.z = InputMousePosition.x / m_X;
			//   retstr.w = InputMousePosition.y / (float)(int)v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static Vector4 GetMouseClickCoordinates(HGCamera camera)
		{
			// // Vector4 GetMouseClickCoordinates(HGCamera)
			// Vector4 *HG::Rendering::Runtime::HGUtils::GetMouseClickCoordinates(
			//         Vector4 *__return_ptr retstr,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   MousePositionDebug *instance; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __m128i v8; // xmm1
			//   __int64 v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3177, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3177, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v12, Patch, (Object *)camera, 0LL);
			//       return retstr;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v7, v6);
			//   }
			//   instance = UnityEngine::Rendering::MousePositionDebug::get_instance(0LL);
			//   if ( !camera || !instance )
			//     goto LABEL_6;
			//   v8 = _mm_cvtsi32_si128(camera.fields._taauRTSize_k__BackingField.m_X);
			//   retstr.x = 0.0;
			//   retstr.y = 0.0;
			//   v9 = HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField);
			//   retstr.z = 0.0 / _mm_cvtepi32_ps(v8).m128_f32[0];
			//   retstr.w = 0.0 / (float)(int)v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static bool IsRegularPreviewCamera(Camera camera)
		{
			// // Boolean IsRegularPreviewCamera(Camera)
			// bool HG::Rendering::Runtime::HGUtils::IsRegularPreviewCamera(Camera *camera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   unsigned int (__fastcall *v5)(Camera *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rax
			//   __int64 v9; // rdx
			//   Object *v10; // rbx
			//   Object *component; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDB2A )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB2A = 1;
			//   }
			//   component = 0LL;
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size > 648 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_13;
			//     if ( LODWORD(v3._0.namespaze) <= 0x288 )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[13].vtable.Finalize.methodPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(648, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                  (ILFixDynamicMethodWrapper_27 *)Patch,
			//                  (Object *)camera,
			//                  0LL);
			//       goto LABEL_13;
			//     }
			//   }
			//   if ( !camera )
			//     goto LABEL_13;
			//   v5 = (unsigned int (__fastcall *)(Camera *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v5 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v5 )
			//     {
			//       v8 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v8, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v5;
			//   }
			//   if ( v5(camera) != 4 )
			//     return 0;
			//   UnityEngine::Component::TryGetComponent<System::Object>(
			//     (Component *)camera,
			//     &component,
			//     MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//   v10 = component;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v9);
			//   if ( UnityEngine::Object::op_Equality((Object_1 *)v10, 0LL, 0LL) )
			//     return 1;
			//   if ( !component )
			// LABEL_13:
			//     sub_180B536AC(v3, wrapperArray);
			//   return LOBYTE(component[22].klass) == 0;
			// }
			// 
			return default(bool);
		}

		internal static string GetHGRenderPipelinePath()
		{
			// // String GetHGRenderPipelinePath()
			// String *HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !byte_18D9196C1 )
			//   {
			//     sub_18003C530(&off_18D5113B0);
			//     byte_18D9196C1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3178, 0LL) )
			//     return (String *)"Packages/com.hg.render-pipelines/";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3178, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(Patch, 0LL);
			// }
			// 
			return null;
		}

		internal static string GetCorePath()
		{
			// // String GetCorePath()
			// String *HG::Rendering::Runtime::HGUtils::GetCorePath(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !byte_18D9196C2 )
			//   {
			//     sub_18003C530(&off_18D511380);
			//     byte_18D9196C2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3179, 0LL) )
			//     return (String *)"Packages/com.unity.render-pipelines.core/";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3179, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(Patch, 0LL);
			// }
			// 
			return null;
		}

		internal static string GetVFXPath()
		{
			// // String GetVFXPath()
			// String *HG::Rendering::Runtime::HGUtils::GetVFXPath(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !byte_18D9196C3 )
			//   {
			//     sub_18003C530(&off_18D5113A0);
			//     byte_18D9196C3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3180, 0LL) )
			//     return (String *)"Packages/com.unity.visualeffectgraph/";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3180, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(Patch, 0LL);
			// }
			// 
			return null;
		}

		internal static RenderPipelineAsset SwitchToBuiltinRenderPipeline(out bool assetWasFromQuality)
		{
			// // RenderPipelineAsset SwitchToBuiltinRenderPipeline(Boolean ByRef)
			// RenderPipelineAsset *HG::Rendering::Runtime::HGUtils::SwitchToBuiltinRenderPipeline(
			//         bool *assetWasFromQuality,
			//         MethodInfo *method)
			// {
			//   RenderPipelineAsset *defaultRenderPipeline; // rax
			//   RenderPipelineAsset *v4; // rsi
			//   Object_1 *currentRenderPipeline; // rbx
			//   RenderPipelineAsset *result; // rax
			//   RenderPipelineAsset *renderPipeline; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !byte_18D9196C4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196C4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3181, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3181, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1130(Patch, assetWasFromQuality, 0LL);
			//   }
			//   else
			//   {
			//     defaultRenderPipeline = UnityEngine::Rendering::GraphicsSettings::get_defaultRenderPipeline(0LL);
			//     *assetWasFromQuality = 0;
			//     v4 = defaultRenderPipeline;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)v4, 0LL, 0LL)
			//       && (currentRenderPipeline = (Object_1 *)UnityEngine::Rendering::GraphicsSettings::get_currentRenderPipeline(0LL),
			//           sub_180002C70(TypeInfo::UnityEngine::Object),
			//           UnityEngine::Object::op_Equality(currentRenderPipeline, (Object_1 *)v4, 0LL)) )
			//     {
			//       UnityEngine::Rendering::GraphicsSettings::set_INTERNAL_defaultRenderPipeline(0LL, 0LL);
			//       return v4;
			//     }
			//     else
			//     {
			//       renderPipeline = UnityEngine::QualitySettings::get_renderPipeline(0LL);
			//       UnityEngine::QualitySettings::set_INTERNAL_renderPipeline(0LL, 0LL);
			//       result = renderPipeline;
			//       *assetWasFromQuality = 1;
			//     }
			//   }
			//   return result;
			// }
			// 
			return null;
		}

		internal static void RestoreRenderPipelineAsset(bool wasUnsetFromQuality, RenderPipelineAsset renderPipelineAsset)
		{
			// // Void RestoreRenderPipelineAsset(Boolean, RenderPipelineAsset)
			// void HG::Rendering::Runtime::HGUtils::RestoreRenderPipelineAsset(
			//         bool wasUnsetFromQuality,
			//         RenderPipelineAsset *renderPipelineAsset,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3182, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3182, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1131(Patch, wasUnsetFromQuality, (Object *)renderPipelineAsset, 0LL);
			//   }
			//   else if ( wasUnsetFromQuality )
			//   {
			//     UnityEngine::QualitySettings::set_INTERNAL_renderPipeline((ScriptableObject *)renderPipelineAsset, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::GraphicsSettings::set_INTERNAL_defaultRenderPipeline(
			//       (ScriptableObject *)renderPipelineAsset,
			//       0LL);
			//   }
			// }
			// 
		}

		internal static int DivRoundUp(int x, int y)
		{
			// // Int32 DivRoundUp(Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGUtils::DivRoundUp(int32_t x, int32_t y, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3183, 0LL) )
			//     return (x + y - 1) / y;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3183, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47((ILFixDynamicMethodWrapper_16 *)Patch, x, y, 0LL);
			// }
			// 
			return 0;
		}

		internal static bool IsQuaternionValid(Quaternion q)
		{
			// // Boolean IsQuaternionValid(Quaternion)
			// bool HG::Rendering::Runtime::HGUtils::IsQuaternionValid(Quaternion *q, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Quaternion v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3184, 0LL) )
			//     return (float)((float)((float)((float)(q.x * q.x) + (float)(q.y * q.y)) + (float)(q.z * q.z))
			//                  + (float)(q.w * q.w)) > COERCE_FLOAT(1);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3184, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *q;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1132(Patch, &v7, 0LL);
			// }
			// 
			return default(bool);
		}

		internal static void CheckRTCreated(RenderTexture rt)
		{
			// // Void CheckRTCreated(RenderTexture)
			// void HG::Rendering::Runtime::HGUtils::CheckRTCreated(RenderTexture *rt, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3185, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3185, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)rt, 0LL);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v4, v3);
			//   }
			//   if ( !rt )
			//     goto LABEL_6;
			//   if ( !UnityEngine::RenderTexture::IsCreated(rt, 0LL) )
			//     UnityEngine::RenderTexture::Create(rt, 0LL);
			// }
			// 
		}

		internal static float ComputeViewportScale(int viewportSize, int bufferSize)
		{
			// // Single ComputeViewportScale(Int32, Int32)
			// float HG::Rendering::Runtime::HGUtils::ComputeViewportScale(
			//         int32_t viewportSize,
			//         int32_t bufferSize,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3186, 0LL) )
			//     return (float)(1.0 / (float)bufferSize) * (float)viewportSize;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3186, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1133(Patch, viewportSize, bufferSize, 0LL);
			// }
			// 
			return 0f;
		}

		internal static float ComputeViewportLimit(int viewportSize, int bufferSize)
		{
			// // Single ComputeViewportLimit(Int32, Int32)
			// float HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(
			//         int32_t viewportSize,
			//         int32_t bufferSize,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3187, 0LL) )
			//     return (float)((float)viewportSize - 0.5) * (float)(1.0 / (float)bufferSize);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3187, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1133(Patch, viewportSize, bufferSize, 0LL);
			// }
			// 
			return 0f;
		}

		internal static Vector4 ComputeViewportScaleAndLimit(Vector2Int viewportSize, Vector2Int bufferSize)
		{
			// // Vector4 ComputeViewportScaleAndLimit(Vector2Int, Vector2Int)
			// Vector4 *HG::Rendering::Runtime::HGUtils::ComputeViewportScaleAndLimit(
			//         Vector4 *__return_ptr retstr,
			//         Vector2Int viewportSize,
			//         Vector2Int bufferSize,
			//         MethodInfo *method)
			// {
			//   float v7; // xmm8_4
			//   float v8; // xmm7_4
			//   float v9; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Vector4 v14; // [rsp+30h] [rbp-48h] BYREF
			//   int32_t viewportSizea; // [rsp+8Ch] [rbp+14h]
			//   int32_t bufferSizea; // [rsp+94h] [rbp+1Ch]
			// 
			//   bufferSizea = bufferSize.m_Y;
			//   viewportSizea = viewportSize.m_Y;
			//   if ( !byte_18D9196C5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196C5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3188, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3188, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1134(&v14, Patch, viewportSize, bufferSize, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v7 = HG::Rendering::Runtime::HGUtils::ComputeViewportScale(viewportSize.m_X, bufferSize.m_X, 0LL);
			//     v8 = HG::Rendering::Runtime::HGUtils::ComputeViewportScale(viewportSizea, bufferSizea, 0LL);
			//     v9 = HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(viewportSize.m_X, bufferSize.m_X, 0LL);
			//     retstr.w = HG::Rendering::Runtime::HGUtils::ComputeViewportLimit(viewportSizea, bufferSizea, 0LL);
			//     retstr.x = v7;
			//     retstr.y = v8;
			//     retstr.z = v9;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static bool IsSupportedGraphicDevice(GraphicsDeviceType graphicDevice)
		{
			// // Boolean IsSupportedGraphicDevice(GraphicsDeviceType)
			// bool HG::Rendering::Runtime::HGUtils::IsSupportedGraphicDevice(
			//         GraphicsDeviceType__Enum graphicDevice,
			//         MethodInfo *method)
			// {
			//   int v3; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3189, 0LL) )
			//     return (unsigned int)graphicDevice <= GraphicsDeviceType__Enum_PlayStation5NGGC
			//         && (v3 = 262627588, _bittest(&v3, graphicDevice))
			//         || graphicDevice == GraphicsDeviceType__Enum_OpenGLES3;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3189, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v7, v6);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)graphicDevice,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal static bool IsMacOSVersionAtLeast(string os, int majorVersion, int minorVersion, int patchVersion)
		{
			// // Boolean IsMacOSVersionAtLeast(String, Int32, Int32, Int32)
			// bool HG::Rendering::Runtime::HGUtils::IsMacOSVersionAtLeast(
			//         String *os,
			//         int32_t majorVersion,
			//         int32_t minorVersion,
			//         int32_t patchVersion,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t IndexOf; // eax
			//   String *v12; // rax
			//   String__Array *v13; // rax
			//   String__Array *v14; // rdi
			//   String *v15; // rbx
			//   int32_t v16; // ebp
			//   int32_t v17; // ebx
			//   int32_t v18; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196C6 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Convert);
			//     sub_18003C530(&off_18C9E5098);
			//     byte_18D9196C6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3190, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3190, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1136(
			//                Patch,
			//                (Object *)os,
			//                majorVersion,
			//                minorVersion,
			//                patchVersion,
			//                0LL);
			// LABEL_19:
			//     sub_180B536AC(v10, v9);
			//   }
			//   if ( !os )
			//     goto LABEL_19;
			//   IndexOf = System::String::LastIndexOf(os, (String *)" ", 0LL);
			//   v12 = System::String::Substring(os, IndexOf + 1, 0LL);
			//   if ( !v12 )
			//     goto LABEL_19;
			//   v13 = System::String::Split(v12, 0x2Eu, StringSplitOptions__Enum_None, 0LL);
			//   v14 = v13;
			//   if ( !v13 )
			//     goto LABEL_19;
			//   if ( !v13.max_length.size
			//     || (v15 = v13.vector[0],
			//         sub_180002C70(TypeInfo::System::Convert),
			//         v16 = System::Convert::ToInt32(v15, 0LL),
			//         v14.max_length.size <= 1u)
			//     || (v17 = System::Convert::ToInt32(v14.vector[1], 0LL), v14.max_length.size <= 2u) )
			//   {
			//     sub_180070270(v10, v9);
			//   }
			//   v18 = System::Convert::ToInt32(v14.vector[2], 0LL);
			//   return v16 >= majorVersion
			//       && (v16 > majorVersion || v17 >= minorVersion && (v17 > minorVersion || v18 >= patchVersion));
			// }
			// 
			return default(bool);
		}

		internal static bool IsOperatingSystemSupported(string os)
		{
			// // Boolean IsOperatingSystemSupported(String)
			// bool HG::Rendering::Runtime::HGUtils::IsOperatingSystemSupported(String *os, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3191, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3191, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)os, 0LL);
			// }
			// 
			return default(bool);
		}

		internal static bool IsGraphicsAPIOpenGL()
		{
			// // Boolean IsGraphicsAPIOpenGL()
			// bool HG::Rendering::Runtime::HGUtils::IsGraphicsAPIOpenGL(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3192, 0LL) )
			//     return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES2
			//         || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES3
			//         || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLCore;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3192, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return default(bool);
		}

		internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, out float scale, out float bias)
		{
			// // Void GetScaleAndBiasForLinearDistanceFade(Single, Single ByRef, Single ByRef)
			// void HG::Rendering::Runtime::HGUtils::GetScaleAndBiasForLinearDistanceFade(
			//         float fadeDistance,
			//         float *scale,
			//         float *bias,
			//         MethodInfo *method)
			// {
			//   float v6; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3193, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3193, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1137(Patch, fadeDistance, scale, bias, 0LL);
			//   }
			//   else
			//   {
			//     v6 = fadeDistance - (float)(fadeDistance * 0.89999998);
			//     *scale = 1.0 / v6;
			//     *bias = (float)-(float)(fadeDistance * 0.89999998) / v6;
			//   }
			// }
			// 
		}

		internal static float ComputeLinearDistanceFade(float distanceToCamera, float fadeDistance)
		{
			// // Single ComputeLinearDistanceFade(Single, Single)
			// float HG::Rendering::Runtime::HGUtils::ComputeLinearDistanceFade(
			//         float distanceToCamera,
			//         float fadeDistance,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm0_4
			//   Beyond::JobMathf *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   float bias[4]; // [rsp+20h] [rbp-38h] BYREF
			//   float scale; // [rsp+78h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9196C7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196C7 = 1;
			//   }
			//   scale = 0.0;
			//   bias[0] = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3194, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3194, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//              (ILFixDynamicMethodWrapper_3 *)Patch,
			//              distanceToCamera,
			//              fadeDistance,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     HG::Rendering::Runtime::HGUtils::GetScaleAndBiasForLinearDistanceFade(fadeDistance, &scale, bias, 0LL);
			//     v4 = (float)(scale * distanceToCamera) + bias[0];
			//     Beyond::JobMathf::Clamp01(v5);
			//     return 1.0 - v4;
			//   }
			// }
			// 
			return 0f;
		}

		internal static float ComputeWeightedLinearFadeDistance(Vector3 position1, Vector3 position2, float weight, float fadeDistance)
		{
			// // Single ComputeWeightedLinearFadeDistance(Vector3, Vector3, Single, Single)
			// float HG::Rendering::Runtime::HGUtils::ComputeWeightedLinearFadeDistance(
			//         Vector3 *position1,
			//         Vector3 *position2,
			//         float weight,
			//         float fadeDistance,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v8; // r9
			//   float v9; // eax
			//   __int64 v10; // xmm0_8
			//   float v11; // eax
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm3_8
			//   float v14; // xmm6_4
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   __int64 v19; // xmm0_8
			//   float v20; // eax
			//   Vector3 v21; // [rsp+38h] [rbp-11h] BYREF
			//   Vector3 v22; // [rsp+48h] [rbp-1h] BYREF
			//   Vector3 v23[2]; // [rsp+58h] [rbp+Fh] BYREF
			// 
			//   if ( !byte_18D9196C8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196C8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3195, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3195, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v16);
			//     z = position2.z;
			//     *(_QWORD *)&v22.x = *(_QWORD *)&position2.x;
			//     v19 = *(_QWORD *)&position1.x;
			//     v22.z = z;
			//     v20 = position1.z;
			//     *(_QWORD *)&v21.x = v19;
			//     v21.z = v20;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(Patch, &v21, &v22, weight, fadeDistance, 0LL);
			//   }
			//   else
			//   {
			//     v9 = position2.z;
			//     *(_QWORD *)&v21.x = *(_QWORD *)&position2.x;
			//     v10 = *(_QWORD *)&position1.x;
			//     v21.z = v9;
			//     v11 = position1.z;
			//     *(_QWORD *)&v22.x = v10;
			//     v22.z = v11;
			//     v12 = UnityEngine::Vector3::op_Subtraction(v23, &v22, &v21, v8);
			//     v13 = *(_QWORD *)&v12.x;
			//     *(float *)&v12 = v12.z;
			//     *(_QWORD *)&v22.x = v13;
			//     LODWORD(v22.z) = (_DWORD)v12;
			//     v14 = sub_1824133B0(&v22);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     return HG::Rendering::Runtime::HGUtils::ComputeLinearDistanceFade(v14, fadeDistance, 0LL) * weight;
			//   }
			// }
			// 
			return 0f;
		}

		internal static bool PostProcessIsFinalPass(HGCamera hgCamera)
		{
			// // Boolean PostProcessIsFinalPass(HGCamera)
			// bool HG::Rendering::Runtime::HGUtils::PostProcessIsFinalPass(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9196C9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     byte_18D9196C9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3196, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3196, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)hgCamera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     return !UnityEngine::Debug::get_isDebugBuild(0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		internal static Vector4 ConvertGUIDToVector4(string guid)
		{
			// // Vector4 ConvertGUIDToVector4(String)
			// Vector4 *HG::Rendering::Runtime::HGUtils::ConvertGUIDToVector4(
			//         Vector4 *__return_ptr retstr,
			//         String *guid,
			//         MethodInfo *method)
			// {
			//   Vector4 *v3; // rbx
			//   __int64 v6; // r8
			//   __int64 v7; // r9
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rdi
			//   int v11; // esi
			//   String *v12; // rax
			//   uint8_t v13; // al
			//   __int64 v14; // rcx
			//   Vector4 v15; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 *result; // rax
			//   Vector4 v18; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v3 = 0LL;
			//   if ( !byte_18D9196CA )
			//   {
			//     sub_18003C530(&TypeInfo::System::Byte);
			//     byte_18D9196CA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3197, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3197, 0LL);
			//     if ( Patch )
			//     {
			//       v15 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v18, Patch, (Object *)guid, 0LL);
			//       goto LABEL_15;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v10 = il2cpp_array_new_specific_0(TypeInfo::System::Byte, 16LL, v6, v7);
			//   v11 = 0;
			//   if ( !guid )
			//     goto LABEL_13;
			//   do
			//   {
			//     v12 = System::String::Substring(guid, 2 * v11, 2, 0LL);
			//     v13 = System::Byte::Parse(v12, NumberStyles__Enum_HexNumber, 0LL);
			//     if ( !v10 )
			//       goto LABEL_13;
			//     if ( (unsigned int)v11 >= *(_DWORD *)(v10 + 24) )
			//       sub_180070270(v9, v8);
			//     v14 = v11++;
			//     *(_BYTE *)(v14 + v10 + 32) = v13;
			//   }
			//   while ( v11 < 16 );
			//   if ( *(_DWORD *)(v10 + 24) )
			//     v3 = (Vector4 *)(v10 + 32);
			//   v15 = *v3;
			// LABEL_15:
			//   result = retstr;
			//   *retstr = v15;
			//   return result;
			// }
			// 
			return null;
		}

		internal static string ConvertVector4ToGUID(Vector4 vector)
		{
			// // String ConvertVector4ToGUID(Vector4)
			// String *HG::Rendering::Runtime::HGUtils::ConvertVector4ToGUID(Vector4 *vector, MethodInfo *method)
			// {
			//   StringBuilder *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   StringBuilder *v6; // rdi
			//   Byte *v7; // rbx
			//   __int64 v8; // rbp
			//   String *v9; // rax
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   Byte__Array *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196CB )
			//   {
			//     sub_18003C530(&TypeInfo::System::Byte);
			//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
			//     sub_18003C530(&TypeInfo::System::Text::StringBuilder);
			//     sub_18003C530(&off_18C9F2598);
			//     byte_18D9196CB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3198, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3198, 0LL);
			//     if ( Patch )
			//     {
			//       v15 = *vector;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1139(Patch, &v15, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   v3 = (StringBuilder *)sub_180004920(TypeInfo::System::Text::StringBuilder);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   System::Text::StringBuilder::StringBuilder(v3, 0LL);
			//   v7 = (Byte *)vector;
			//   v8 = 16LL;
			//   do
			//   {
			//     v9 = System::Byte::ToString(v7, (String *)"x2", 0LL);
			//     System::Text::StringBuilder::Append(v6, v9, 0LL);
			//     ++v7;
			//     --v8;
			//   }
			//   while ( v8 );
			//   v12 = (Byte__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Byte, 16LL, v10, v11);
			//   sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
			//   System::Runtime::InteropServices::Marshal::Copy(vector, v12, 0, 16, 0LL);
			//   return (String *)sub_18003F3E0(3LL, v6);
			// }
			// 
			return null;
		}

		public static Color NormalizeColor(Color color)
		{
			// // Color NormalizeColor(Color)
			// Color *HG::Rendering::Runtime::HGUtils::NormalizeColor(Color *__return_ptr retstr, Color *color, MethodInfo *method)
			// {
			//   MethodInfo *v5; // rdx
			//   MethodInfo *v6; // r9
			//   MethodInfo *v7; // r8
			//   MethodInfo *v8; // r8
			//   __m128 v9; // xmm1
			//   __m128 v10; // xmm4
			//   float v11; // xmm5_4
			//   float v12; // xmm2_4
			//   float v13; // xmm0_4
			//   float v14; // xmm3_4
			//   float v15; // xmm0_4
			//   float v16; // xmm1_4
			//   float v17; // xmm4_4
			//   __m128 v18; // xmm7
			//   __m128 v19; // xmm6
			//   float v20; // xmm3_4
			//   MethodInfo *v21; // r8
			//   Color v22; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   Color *result; // rax
			//   Vector4 v27; // [rsp+20h] [rbp-50h] BYREF
			//   Color v28; // [rsp+30h] [rbp-40h] BYREF
			//   Vector4 v29; // [rsp+40h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9196CC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
			//     byte_18D9196CC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3199, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3199, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v25, v24);
			//     v28 = *color;
			//     v22 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140((Color *)&v29, Patch, &v28, 0LL);
			//   }
			//   else
			//   {
			//     v28 = *color;
			//     v27 = *UnityEngine::Vector4::get_one(&v27, v5);
			//     UnityEngine::Vector4::op_Multiply(&v29, &v27, 0.000099999997, v6);
			//     v9 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v7));
			//     if ( v9.m128_f32[0] <= v10.m128_f32[0] )
			//       v11 = v10.m128_f32[0];
			//     else
			//       v11 = v9.m128_f32[0];
			//     v12 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
			//     v13 = _mm_shuffle_ps(v10, v10, 85).m128_f32[0];
			//     if ( v12 <= v13 )
			//       v12 = v13;
			//     v14 = _mm_shuffle_ps(v9, v9, 170).m128_f32[0];
			//     v15 = _mm_shuffle_ps(v10, v10, 170).m128_f32[0];
			//     if ( v14 <= v15 )
			//       v14 = v15;
			//     v16 = _mm_shuffle_ps(v9, v9, 255).m128_f32[0];
			//     v17 = _mm_shuffle_ps(v10, v10, 255).m128_f32[0];
			//     if ( v16 <= v17 )
			//       v16 = v17;
			//     v27.x = v11;
			//     v27.y = v12;
			//     v27.z = v14;
			//     v27.w = v16;
			//     v18 = (__m128)v27;
			//     v28 = (Color)v27;
			//     v19 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v8));
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ColorUtils);
			//     v20 = (float)((float)(_mm_shuffle_ps(v19, v19, 85).m128_f32[0] * 0.7151522) + (float)(v19.m128_f32[0] * 0.2126729))
			//         + (float)(_mm_shuffle_ps(v19, v19, 170).m128_f32[0] * 0.072175004);
			//     v27.x = v18.m128_f32[0] / v20;
			//     v27.y = _mm_shuffle_ps(v18, v18, 85).m128_f32[0] / v20;
			//     v27.z = _mm_shuffle_ps(v18, v18, 170).m128_f32[0] / v20;
			//     v27.w = _mm_shuffle_ps(v18, v18, 255).m128_f32[0] / v20;
			//     v28 = (Color)v27;
			//     *color = *UnityEngine::Color::op_Implicit((Color *)&v29, (Vector4 *)&v28, v21);
			//     color.a = 1.0;
			//     v22 = *color;
			//   }
			//   result = retstr;
			//   *retstr = v22;
			//   return result;
			// }
			// 
			return null;
		}

		[Obsolete("Please use CoreUtils.DrawRendererList instead.")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, global::UnityEngine.Rendering.RendererUtils.RendererList rendererList)
		{
			// // Void DrawRendererList(ScriptableRenderContext, CommandBuffer, RendererList)
			// void HG::Rendering::Runtime::HGUtils::DrawRendererList(
			//         ScriptableRenderContext renderContext,
			//         CommandBuffer *cmd,
			//         RendererList *rendererList,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   RendererList v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196CD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196CD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3200, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3200, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = *rendererList;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1141(Patch, renderContext, (Object *)cmd, &v10, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     v10 = *rendererList;
			//     UnityEngine::Rendering::CoreUtils::DrawRendererList(renderContext, cmd, &v10, 0LL);
			//   }
			// }
			// 
		}

		internal static string ComputeProbeCameraName(string probeName, int face, string viewerName)
		{
			// // String ComputeProbeCameraName(String, Int32, String)
			// String *HG::Rendering::Runtime::HGUtils::ComputeProbeCameraName(
			//         String *probeName,
			//         int32_t face,
			//         String *viewerName,
			//         MethodInfo *method)
			// {
			//   __int64 stringLength; // rdx
			//   unsigned __int64 static_fields; // rcx
			//   String *v9; // r14
			//   unsigned __int64 v10; // r8
			//   __int64 v11; // rax
			//   void *v12; // rsp
			//   uint16_t *p_value; // r12
			//   int32_t v14; // esi
			//   uint16_t *i; // rdi
			//   uint16_t Chars; // ax
			//   int32_t v17; // esi
			//   int32_t v18; // r15d
			//   int32_t j; // ebx
			//   _WORD *v20; // r15
			//   int v21; // ecx
			//   uint16_t *v22; // rdi
			//   int32_t k; // ebx
			//   uint16_t v24; // ax
			//   int v25; // ebx
			//   int32_t v26; // r15d
			//   int v27; // esi
			//   int32_t m; // ebx
			//   uint16_t v29; // ax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   uint16_t value; // [rsp+30h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D9196CE )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::ComputeProbeCameraName);
			//     sub_18003C530(&TypeInfo::System::String);
			//     sub_18003C530(&off_18D5112E8);
			//     sub_18003C530(&off_18D5112F8);
			//     sub_18003C530(&off_18C9DAAB8);
			//     sub_18003C530(&off_18D511300);
			//     sub_18003C530(&off_18C957790);
			//     byte_18D9196CE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3201, 0LL) )
			//   {
			//     if ( !probeName )
			//     {
			//       static_fields = (unsigned __int64)TypeInfo::System::String.static_fields;
			//       probeName = *(String **)static_fields;
			//     }
			//     v9 = (String *)"null";
			//     if ( viewerName )
			//       v9 = viewerName;
			//     if ( !probeName )
			//       goto LABEL_54;
			//     static_fields = 40LL;
			//     if ( probeName.fields._stringLength < 40 )
			//       static_fields = (unsigned int)probeName.fields._stringLength;
			//     if ( !v9 )
			//       goto LABEL_54;
			//     stringLength = 40LL;
			//     if ( v9.fields._stringLength < 40 )
			//       stringLength = (unsigned int)v9.fields._stringLength;
			//     if ( !"HGProbe RenderCamera (" || !": " || !" for viewer '" || !"')" )
			//       goto LABEL_54;
			//     v10 = 2LL
			//         * (*(_DWORD *)"mera ("
			//          + *(_DWORD *)&asc_18F25FDB6[16]
			//          + *(_DWORD *)&aForViewer[16]
			//          + 2
			//          + (int)static_fields
			//          + (int)stringLength
			//          + *(_DWORD *)&asc_18F28FBAB[16]);
			//     if ( v10 )
			//     {
			//       v11 = v10 + 15;
			//       if ( v10 + 15 < v10 )
			//         v11 = 0xFFFFFFFFFFFFFF0LL;
			//       v12 = alloca(v11 & 0xFFFFFFFFFFFFFFF0uLL);
			//       p_value = &value;
			//     }
			//     else
			//     {
			//       p_value = 0LL;
			//     }
			//     sub_1802F01E0(p_value, 0LL, v10);
			//     v14 = 0;
			//     for ( i = p_value; ; ++i )
			//     {
			//       static_fields = (unsigned __int64)"HGProbe RenderCamera (";
			//       if ( !"HGProbe RenderCamera (" )
			//         goto LABEL_54;
			//       if ( v14 >= *(_DWORD *)"mera (" )
			//         break;
			//       Chars = System::String::get_Chars((String *)"HGProbe RenderCamera (", v14++, 0LL);
			//       *i = Chars;
			//     }
			//     v17 = probeName.fields._stringLength;
			//     v18 = 0;
			//     if ( v17 >= 40 )
			//     {
			//       v17 = 40;
			//     }
			//     else if ( v17 <= 0 )
			//     {
			// LABEL_32:
			//       for ( j = 0; ; ++j )
			//       {
			//         static_fields = (unsigned __int64)": ";
			//         if ( !": " )
			//           goto LABEL_54;
			//         v20 = i + 1;
			//         if ( j >= *(_DWORD *)&asc_18F25FDB6[16] )
			//           break;
			//         *i++ = System::String::get_Chars((String *)": ", j, 0LL);
			//       }
			//       v21 = (205 * face) >> 11;
			//       *i = v21 + 48;
			//       v22 = i + 2;
			//       *v20 = face - 10 * v21 + 48;
			//       for ( k = 0; ; ++k )
			//       {
			//         static_fields = (unsigned __int64)" for viewer '";
			//         if ( !" for viewer '" )
			//           goto LABEL_54;
			//         if ( k >= *(_DWORD *)&aForViewer[16] )
			//           break;
			//         v24 = System::String::get_Chars((String *)" for viewer '", k, 0LL);
			//         *v22++ = v24;
			//       }
			//       v25 = v9.fields._stringLength;
			//       v26 = 0;
			//       if ( v25 >= 40 )
			//       {
			//         v25 = 40;
			//       }
			//       else if ( v25 <= 0 )
			//       {
			// LABEL_45:
			//         v27 = v25 + v17;
			//         for ( m = 0; ; ++m )
			//         {
			//           if ( !"')" )
			//             goto LABEL_54;
			//           if ( m >= *(_DWORD *)&asc_18F28FBAB[16] )
			//             break;
			//           v29 = System::String::get_Chars((String *)"')", m, 0LL);
			//           *v22++ = v29;
			//         }
			//         static_fields = (unsigned __int64)"HGProbe RenderCamera (";
			//         if ( "HGProbe RenderCamera (" )
			//         {
			//           static_fields = (unsigned __int64)": ";
			//           if ( ": " )
			//           {
			//             static_fields = (unsigned __int64)" for viewer '";
			//             if ( " for viewer '" )
			//               return System::String::CreateString(
			//                        0LL,
			//                        p_value,
			//                        0,
			//                        *(_DWORD *)"mera ("
			//                      + 2
			//                      + *(_DWORD *)&aForViewer[16]
			//                      + v27
			//                      + *(_DWORD *)&asc_18F28FBAB[16]
			//                      + *(_DWORD *)&asc_18F25FDB6[16],
			//                        0LL);
			//           }
			//         }
			// LABEL_54:
			//         sub_180B536AC(static_fields, stringLength);
			//       }
			//       do
			//         *v22++ = System::String::get_Chars(v9, v26++, 0LL);
			//       while ( v26 < v25 );
			//       goto LABEL_45;
			//     }
			//     do
			//       *i++ = System::String::get_Chars(probeName, v18++, 0LL);
			//     while ( v18 < v17 );
			//     goto LABEL_32;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3201, 0LL);
			//   if ( !Patch )
			//     goto LABEL_54;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1142(Patch, (Object *)probeName, face, (Object *)viewerName, 0LL);
			// }
			// 
			return null;
		}

		internal static string ComputeCameraName(string cameraName)
		{
			// // String ComputeCameraName(String)
			// String *HG::Rendering::Runtime::HGUtils::ComputeCameraName(String *cameraName, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t stringLength; // ebx
			//   unsigned __int64 v6; // r8
			//   __int64 v7; // rax
			//   void *v8; // rsp
			//   uint16_t *p_value; // rsi
			//   int32_t v10; // r14d
			//   uint16_t *i; // r15
			//   uint16_t Chars; // ax
			//   int32_t j; // r14d
			//   uint16_t v14; // ax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   uint16_t value; // [rsp+30h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D9196CF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::ComputeCameraName);
			//     sub_18003C530(&off_18D5114A0);
			//     byte_18D9196CF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2301, 0LL) )
			//   {
			//     if ( cameraName )
			//     {
			//       stringLength = 40;
			//       if ( cameraName.fields._stringLength < 40 )
			//         stringLength = cameraName.fields._stringLength;
			//       if ( "HGRenderPipeline::Render " )
			//       {
			//         v6 = 2LL * (stringLength + *(_DWORD *)"::Render ");
			//         if ( v6 )
			//         {
			//           v7 = v6 + 15;
			//           if ( v6 + 15 < v6 )
			//             v7 = 0xFFFFFFFFFFFFFF0LL;
			//           v8 = alloca(v7 & 0xFFFFFFFFFFFFFFF0uLL);
			//           p_value = &value;
			//         }
			//         else
			//         {
			//           p_value = 0LL;
			//         }
			//         sub_1802F01E0(p_value, 0LL, v6);
			//         v10 = 0;
			//         for ( i = p_value; ; ++i )
			//         {
			//           if ( !"HGRenderPipeline::Render " )
			//             goto LABEL_22;
			//           if ( v10 >= *(_DWORD *)"::Render " )
			//             break;
			//           Chars = System::String::get_Chars((String *)"HGRenderPipeline::Render ", v10++, 0LL);
			//           *i = Chars;
			//         }
			//         for ( j = 0; j < stringLength; ++i )
			//         {
			//           v14 = System::String::get_Chars(cameraName, j++, 0LL);
			//           *i = v14;
			//         }
			//         if ( "HGRenderPipeline::Render " )
			//           return System::String::CreateString(0LL, p_value, 0, stringLength + *(_DWORD *)"::Render ", 0LL);
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2301, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)cameraName, 0LL);
			// }
			// 
			return null;
		}

		internal static float ClampFOV(float fov)
		{
			// // Single ClampFOV(Single)
			// float HG::Rendering::Runtime::HGUtils::ClampFOV(float fov, MethodInfo *method)
			// {
			//   float v2; // xmm6_4
			//   int v3; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   v2 = fov;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3202, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3202, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, fov, 0LL);
			//   }
			//   else
			//   {
			//     v3 = 925353388;
			//     if ( v2 < 0.0000099999997 )
			//       return *(float *)&v3;
			//     v3 = 1127415808;
			//     if ( v2 > 179.0 )
			//       return *(float *)&v3;
			//     return v2;
			//   }
			// }
			// 
			return 0f;
		}

		internal static ulong GetSceneCullingMaskFromCamera(Camera camera)
		{
			// // UInt64 GetSceneCullingMaskFromCamera(Camera)
			// uint64_t HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(Camera *camera, MethodInfo *method)
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
			//   if ( wrapperArray.max_length.size <= 793 )
			//     return 0LL;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x319u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[22].vector[1] )
			//     return 0LL;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(793, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)camera, 0LL);
			// }
			// 
			return 0UL;
		}

		internal static HGAdditionalCameraData TryGetAdditionalCameraDataOrDefault(Camera camera)
		{
			// // HGAdditionalCameraData TryGetAdditionalCameraDataOrDefault(Camera)
			// HGAdditionalCameraData *HG::Rendering::Runtime::HGUtils::TryGetAdditionalCameraDataOrDefault(
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v5; // rdx
			//   bool (*v6)(Object *, Object *, MethodInfo *); // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDB2B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB2B = 1;
			//   }
			//   component = 0LL;
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_28;
			//   if ( wrapperArray.max_length.size > 642 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x282 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !*(_QWORD *)&v3[13]._1.token )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(642, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_239(Patch, (Object *)camera, 0LL);
			//     }
			// LABEL_28:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( camera )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( camera.fields._._._.m_CachedPtr )
			//     {
			//       sub_180003EE0(camera.klass);
			//       v6 = (bool (*)(Object *, Object *, MethodInfo *))camera.klass.vtable.Equals.method;
			//       if ( v6 == System::Object::Equals || (char *)v6 == (char *)System::RuntimeType::Equals )
			//         goto LABEL_26;
			//       if ( (char *)v6 == (char *)System::RuntimeType::IsInstanceOfType )
			//       {
			//         LOBYTE(v5) = 1;
			//         sub_18000AEC0(camera.fields._._._.m_CachedPtr, v5);
			//         goto LABEL_26;
			//       }
			//       if ( !((unsigned __int8 (__fastcall *)(Camera *, _QWORD, Il2CppMethodPointer))v6)(
			//               camera,
			//               0LL,
			//               camera.klass.vtable.Finalize.methodPtr) )
			//       {
			// LABEL_26:
			//         if ( UnityEngine::Component::TryGetComponent<System::Object>(
			//                (Component *)camera,
			//                &component,
			//                MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
			//         {
			//           return (HGAdditionalCameraData *)component;
			//         }
			//       }
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//   return HG::Rendering::Runtime::HGUtils::get_s_DefaultHGAdditionalCameraData(0LL);
			// }
			// 
			return null;
		}

		internal static int GetFormatSizeInBytes(GraphicsFormat format)
		{
			// // Int32 GetFormatSizeInBytes(GraphicsFormat)
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::HGUtils::GetFormatSizeInBytes(GraphicsFormat__Enum format, MethodInfo *method)
			// {
			//   GraphicsFormat__Enum v2; // edi
			//   __int64 v3; // rdx
			//   HGUtils__StaticFields *static_fields; // rcx
			//   String *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   String *v8; // rbx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t stringLength; // esi
			//   String *v12; // rbx
			//   int32_t v13; // esi
			//   MatchCollection *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int64 v21; // rax
			//   Capture *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   String *v25; // rax
			//   HGUtils__StaticFields *v26; // rdx
			//   Dictionary_2_System_Int32Enum_System_Int32_ *graphicsFormatSizeCache; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // [rsp+20h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v33; // [rsp+28h] [rbp-50h] BYREF
			//   __int128 v34; // [rsp+30h] [rbp-48h]
			//   void *ex; // [rsp+40h] [rbp-38h] BYREF
			//   _OWORD v36[3]; // [rsp+48h] [rbp-30h] BYREF
			//   int32_t value; // [rsp+90h] [rbp+18h] BYREF
			//   IEnumerator *Enumerator; // [rsp+98h] [rbp+20h] BYREF
			// 
			//   v2 = format;
			//   if ( !byte_18D9196D0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::set_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&TypeInfo::System::Text::RegularExpressions::Match);
			//     sub_18003C530(&TypeInfo::System::Text::RegularExpressions::Regex);
			//     sub_18003C530(&off_18C919C10);
			//     byte_18D9196D0 = 1;
			//   }
			//   value = 0;
			//   v32 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3203, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//     if ( !static_fields.graphicsFormatSizeCache )
			//       sub_180B536AC(static_fields, v3);
			//     if ( System::Collections::Generic::Dictionary<System::Int32Enum,int>::TryGetValue(
			//            (Dictionary_2_System_Int32Enum_System_Int32_ *)static_fields.graphicsFormatSizeCache,
			//            (Int32Enum__Enum)v2,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::TryGetValue) )
			//     {
			//       return value;
			//     }
			//     ex = TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat;
			//     *(_QWORD *)&v36[0] = -1LL;
			//     DWORD2(v36[0]) = v2;
			//     v5 = System::Enum::ToString((Enum *)&ex, 0LL);
			//     v8 = v5;
			//     if ( !v5 )
			//       sub_180B536AC(v7, v6);
			//     stringLength = System::String::IndexOf(v5, 0x5Fu, 0LL);
			//     if ( stringLength == -1 )
			//     {
			//       if ( !v8 )
			//         sub_180B536AC(v10, v9);
			//       stringLength = v8.fields._stringLength;
			//     }
			//     if ( !v8 )
			//       sub_180B536AC(v10, v9);
			//     v12 = System::String::Substring(v8, 0, stringLength, 0LL);
			//     v13 = 0;
			//     value = 0;
			//     sub_180002C70(TypeInfo::System::Text::RegularExpressions::Regex);
			//     v14 = System::Text::RegularExpressions::Regex::Matches(v12, (String *)"\\d+", 0LL);
			//     if ( !v14 )
			//       sub_180B536AC(v16, v15);
			//     Enumerator = System::Text::RegularExpressions::MatchCollection::GetEnumerator(v14, 0LL);
			//     *(_QWORD *)&v34 = &Enumerator;
			//     *((_QWORD *)&v34 + 1) = &v32;
			//     ex = 0LL;
			//     v36[0] = v34;
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         if ( !Enumerator )
			//           sub_1802DC2C8(v18, v17);
			//         if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//           break;
			//         if ( !Enumerator )
			//           sub_1802DC2C8(v20, v19);
			//         v21 = sub_1800513A0(1LL, TypeInfo::System::Collections::IEnumerator, Enumerator);
			//         v22 = (Capture *)sub_18003F550(v21, TypeInfo::System::Text::RegularExpressions::Match);
			//         if ( !v22 )
			//           sub_1802DC2C8(v24, v23);
			//         v25 = System::Text::RegularExpressions::Capture::get_Value(v22, 0LL);
			//         v13 += System::Int32::Parse(v25, 0LL);
			//         value = v13;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v33 )
			//     {
			//       ex = v33.ex;
			//       sub_180B5A040(v36);
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = format;
			//       v13 = value;
			//       goto LABEL_21;
			//     }
			//     sub_180B5A040(v36);
			// LABEL_21:
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v26 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//     graphicsFormatSizeCache = (Dictionary_2_System_Int32Enum_System_Int32_ *)v26.graphicsFormatSizeCache;
			//     if ( !graphicsFormatSizeCache )
			//       sub_1802DC2C8(0LL, v26);
			//     System::Collections::Generic::Dictionary<System::Int32Enum,int>::set_Item(
			//       graphicsFormatSizeCache,
			//       (Int32Enum__Enum)v2,
			//       v13 / 8,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Experimental::Rendering::GraphicsFormat,int>::set_Item);
			//     return v13 / 8;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3203, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v31, v30);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, v2, 0LL);
			// }
			// 
			return 0;
		}

		internal static void DisplayMessageNotification(string msg)
		{
			// // Void DisplayMessageNotification(String)
			// void HG::Rendering::Runtime::HGUtils::DisplayMessageNotification(String *msg, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3204, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3204, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)msg, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::HGRPLogger::LogError(msg, 0LL);
			//   }
			// }
			// 
		}

		internal static string GetUnsupportedAPIMessage(string graphicAPI)
		{
			// // String GetUnsupportedAPIMessage(String)
			// String *HG::Rendering::Runtime::HGUtils::GetUnsupportedAPIMessage(String *graphicAPI, MethodInfo *method)
			// {
			//   String *OperatingSystem; // rbp
			//   char *v4; // rbx
			//   unsigned __int32 v5; // eax
			//   __int64 v6; // r8
			//   __int64 v7; // r9
			//   unsigned __int32 v8; // eax
			//   __int64 v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   String__Array *v12; // rdi
			//   String *v13; // rdi
			//   String *v14; // rax
			//   String *v15; // rax
			//   char *v16; // rdx
			//   String *result; // rax
			//   __int64 v18; // rax
			//   ArgumentNullException *v19; // rbx
			//   String *v20; // rax
			//   __int64 v21; // rax
			//   __int64 v22; // rax
			//   ArgumentNullException *v23; // rbx
			//   String *v24; // rax
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   ArgumentNullException *v27; // rbx
			//   String *v28; // rax
			//   __int64 v29; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196D1 )
			//   {
			//     sub_18003C530(&TypeInfo::System::String);
			//     sub_18003C530(&off_18D511518);
			//     sub_18003C530(&off_18D511528);
			//     sub_18003C530(&off_18D511538);
			//     sub_18003C530(&off_18D511540);
			//     sub_18003C530(&off_18D5114E0);
			//     sub_18003C530(&off_18C9C93E8);
			//     sub_18003C530(&off_18D5114E8);
			//     sub_18003C530(&off_18D5114F8);
			//     sub_18003C530(&off_18D511508);
			//     sub_18003C530(&off_18D511550);
			//     sub_18003C530(&off_18D511560);
			//     sub_18003C530(&off_18D511568);
			//     byte_18D9196D1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3205, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3205, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)graphicAPI, 0LL);
			//     goto LABEL_32;
			//   }
			//   OperatingSystem = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
			//   v4 = 0LL;
			//   v5 = UnityEngine::SystemInfo::GetOperatingSystemFamily(0LL) - 1;
			//   if ( v5 )
			//   {
			//     v8 = v5 - 1;
			//     if ( v8 )
			//     {
			//       if ( v8 == 1 )
			//         v4 = "Linux";
			//     }
			//     else
			//     {
			//       v4 = "Windows";
			//     }
			//   }
			//   else
			//   {
			//     v4 = "Mac";
			//   }
			//   v9 = il2cpp_array_new_specific_0(TypeInfo::System::String, 5LL, v6, v7);
			//   v12 = (String__Array *)v9;
			//   if ( !v9 )
			//     goto LABEL_32;
			//   sub_1800046C0(v9, 0LL, "Platform ");
			//   sub_1800046C0(v12, 1LL, OperatingSystem);
			//   sub_1800046C0(v12, 2LL, " with graphics API ");
			//   sub_1800046C0(v12, 3LL, graphicAPI);
			//   sub_1800046C0(v12, 4LL, " is not supported with HGRP");
			//   v13 = System::String::Concat(v12, 0LL);
			//   if ( !graphicAPI )
			//     goto LABEL_32;
			//   if ( !"OpenGL" )
			//   {
			//     v26 = sub_18000F7E0(&TypeInfo::System::ArgumentNullException);
			//     v27 = (ArgumentNullException *)sub_180004920(v26);
			//     if ( v27 )
			//     {
			//       v28 = (String *)sub_18000F7E0(&off_18C8F6DE0);
			//       System::ArgumentNullException::ArgumentNullException(v27, v28, 0LL);
			//       v29 = sub_18000F7E0(&MethodInfo::System::String::StartsWith);
			//       sub_18000F7C0(v27, v29);
			//     }
			//     goto LABEL_32;
			//   }
			//   if ( !System::String::StartsWith(graphicAPI, (String *)"OpenGL", StringComparison__Enum_CurrentCulture, 0LL) )
			//     goto LABEL_22;
			//   v14 = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
			//   if ( !v14 )
			//     goto LABEL_32;
			//   if ( !"Mac" )
			//   {
			//     v22 = sub_18000F7E0(&TypeInfo::System::ArgumentNullException);
			//     v23 = (ArgumentNullException *)sub_180004920(v22);
			//     if ( v23 )
			//     {
			//       v24 = (String *)sub_18000F7E0(&off_18C8F6DE0);
			//       System::ArgumentNullException::ArgumentNullException(v23, v24, 0LL);
			//       v25 = sub_18000F7E0(&MethodInfo::System::String::StartsWith);
			//       sub_18000F7C0(v23, v25);
			//     }
			//     goto LABEL_32;
			//   }
			//   if ( System::String::StartsWith(v14, (String *)"Mac", StringComparison__Enum_CurrentCulture, 0LL) )
			//   {
			//     v16 = ", use the Metal graphics API instead";
			//     goto LABEL_21;
			//   }
			//   v15 = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
			//   if ( !v15 )
			// LABEL_32:
			//     sub_180B536AC(v11, v10);
			//   if ( !"Windows" )
			//   {
			//     v18 = sub_18000F7E0(&TypeInfo::System::ArgumentNullException);
			//     v19 = (ArgumentNullException *)sub_180004920(v18);
			//     if ( v19 )
			//     {
			//       v20 = (String *)sub_18000F7E0(&off_18C8F6DE0);
			//       System::ArgumentNullException::ArgumentNullException(v19, v20, 0LL);
			//       v21 = sub_18000F7E0(&MethodInfo::System::String::StartsWith);
			//       sub_18000F7C0(v19, v21);
			//     }
			//     goto LABEL_32;
			//   }
			//   if ( !System::String::StartsWith(v15, (String *)"Windows", StringComparison__Enum_CurrentCulture, 0LL) )
			//     goto LABEL_22;
			//   v16 = ", use the Vulkan graphics API instead";
			// LABEL_21:
			//   v13 = System::String::Concat(v13, (String *)v16, 0LL);
			// LABEL_22:
			//   result = System::String::Concat(
			//              v13,
			//              (String *)".\nChange the platform/device to a compatible one or remove incompatible graphics APIs.\n",
			//              0LL);
			//   if ( v4 )
			//     return System::String::Concat(
			//              result,
			//              (String *)"To do this, go to Project Settings > Player > Other Settings and modify the Graphics APIs for ",
			//              (String *)v4,
			//              (String *)" list.",
			//              0LL);
			//   return result;
			// }
			// 
			return null;
		}

		internal static int GetTextureHash(Texture texture)
		{
			// // Int32 GetTextureHash(Texture)
			// int32_t HG::Rendering::Runtime::HGUtils::GetTextureHash(Texture *texture, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9196D2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D9196D2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3206, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3206, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)texture, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     return UnityEngine::Rendering::CoreUtils::GetTextureHash(texture, 0LL);
			//   }
			// }
			// 
			return 0;
		}

		internal static void ReleaseComponentSingletons()
		{
			// // Void ReleaseComponentSingletons()
			// void HG::Rendering::Runtime::HGUtils::ReleaseComponentSingletons(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			// 
			//   if ( !byte_18D8EDB2C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::Release);
			//     byte_18D8EDB2C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(534, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(534, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v3, v2);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::ComponentSingleton<System::Object>::Release(MethodInfo::UnityEngine::Rendering::ComponentSingleton<HG::Rendering::Runtime::HGAdditionalCameraData>::Release);
			//   }
			// }
			// 
		}

		internal static float CopySign(float x, float s, [MetadataOffset(Offset = "0x01F91AA8")] bool ignoreNegZero = true)
		{
			// // Single CopySign(Single, Single, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// float HG::Rendering::Runtime::HGUtils::CopySign(float x, float s, bool ignoreNegZero, MethodInfo *method)
			// {
			//   float result; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1609, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1609, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_616(Patch, x, s, ignoreNegZero, 0LL);
			//   }
			//   else
			//   {
			//     LODWORD(result) = _mm_cvtsi128_si32(*(__m128i *)&x) & 0x7FFFFFFF;
			//     if ( s < 0.0 )
			//       return -result;
			//   }
			//   return result;
			// }
			// 
			return 0f;
		}

		internal static float2 PackNormalOctRectEncode(float3 n)
		{
			// // float2 PackNormalOctRectEncode(float3)
			// float2 HG::Rendering::Runtime::HGUtils::PackNormalOctRectEncode(float3 *n, MethodInfo *method)
			// {
			//   MethodInfo *v3; // r8
			//   float v4; // eax
			//   float3 *v5; // rax
			//   __int64 v6; // xmm0_8
			//   __int64 v7; // xmm1_8
			//   MethodInfo *v8; // r8
			//   MethodInfo *v9; // r9
			//   float3 *v10; // rax
			//   float v11; // ebx
			//   __m128 v12; // xmm0
			//   __m128 y_low; // xmm6
			//   __int64 v14; // rcx
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 vector; // [rsp+20h] [rbp-50h] BYREF
			//   Vector3 value; // [rsp+30h] [rbp-40h] BYREF
			//   float3 v21; // [rsp+40h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9196D3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196D3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1608, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1608, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v16);
			//     z = n.z;
			//     *(_QWORD *)&v21.x = *(_QWORD *)&n.x;
			//     v21.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(Patch, &v21, 0LL);
			//   }
			//   else
			//   {
			//     v4 = n.z;
			//     *(_QWORD *)&vector.x = *(_QWORD *)&n.x;
			//     *(_QWORD *)&value.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//     value.z = 1.0;
			//     vector.z = v4;
			//     v5 = Unity::Mathematics::math::abs(&v21, (float3 *)&vector, v3);
			//     v6 = *(_QWORD *)&n.x;
			//     v7 = *(_QWORD *)&v5.x;
			//     vector.z = v5.z;
			//     v21.z = n.z;
			//     *(_QWORD *)&vector.x = v7;
			//     *(_QWORD *)&v21.x = v6;
			//     *(float *)&v6 = Dest::Math::Vector3ex::Dot(&vector, &value, v8);
			//     v10 = Unity::Mathematics::float3::op_Multiply((float3 *)&value, &v21, 1.0 / *(float *)&v6, v9);
			//     v11 = v10.z;
			//     *(_QWORD *)&vector.x = *(_QWORD *)&v10.x;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v12 = (__m128)0x3F000000u;
			//     y_low = (__m128)LODWORD(vector.y);
			//     v12.m128_f32[0] = sub_18238C950(v14);
			//     v12.m128_f32[0] = HG::Rendering::Runtime::HGUtils::CopySign(v12.m128_f32[0], v11, 1, 0LL);
			//     y_low.m128_f32[0] = y_low.m128_f32[0] + vector.x;
			//     return (float2)_mm_unpacklo_ps(v12, y_low).m128_u64[0];
			//   }
			// }
			// 
			return null;
		}

		internal static float PackTwoHalfValuesAsFloat(float x, float y)
		{
			// // Single PackTwoHalfValuesAsFloat(Single, Single)
			// float HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(float x, float y, MethodInfo *method)
			// {
			//   Unity::Mathematics::math *v3; // rcx
			//   Unity::Mathematics::math *v4; // rcx
			//   int v5; // eax
			//   int v6; // r8d
			//   float result; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1611, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1611, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359((ILFixDynamicMethodWrapper_3 *)Patch, x, y, 0LL);
			//   }
			//   else
			//   {
			//     Unity::Mathematics::math::half(v3, y);
			//     v5 = Unity::Mathematics::math::half(v4, y);
			//     LODWORD(result) = v5 | v6;
			//   }
			//   return result;
			// }
			// 
			return 0f;
		}

		public static GraphicsFormat GetDeviceSupportedRWTextureFormat(bool useAlpha)
		{
			// // GraphicsFormat GetDeviceSupportedRWTextureFormat(Boolean)
			// GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetDeviceSupportedRWTextureFormat(
			//         bool useAlpha,
			//         MethodInfo *method)
			// {
			//   struct HGUtils__Class *v3; // rcx
			//   HGUtils__StaticFields *static_fields; // rax
			//   unsigned int i; // ebx
			//   _DWORD *m_RWTextureWithAlphaColorFormatList; // rcx
			//   GraphicsFormat__Enum__Array *m_RWTextureWithoutAlphaColorFormatList; // rdx
			//   bool IsFormatSupported; // al
			//   unsigned int j; // ebx
			//   bool v11; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196D4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&off_18D5113F0);
			//     byte_18D9196D4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2389, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2389, 0LL);
			//     if ( !Patch )
			//       goto LABEL_35;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_863(Patch, useAlpha, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//     if ( !useAlpha )
			//     {
			//       if ( static_fields.m_RWTextureWithoutAlphaFormat )
			//       {
			// LABEL_18:
			//         sub_180002C70(v3);
			//         return TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaFormat;
			//       }
			//       for ( i = 0; ; ++i )
			//       {
			//         sub_180002C70(v3);
			//         m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//         m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaColorFormatList;
			//         if ( !m_RWTextureWithoutAlphaColorFormatList )
			//           goto LABEL_35;
			//         if ( (signed int)i >= m_RWTextureWithoutAlphaColorFormatList.max_length.size )
			//           goto LABEL_16;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaColorFormatList;
			//         if ( !m_RWTextureWithAlphaColorFormatList )
			//           goto LABEL_35;
			//         if ( i >= m_RWTextureWithAlphaColorFormatList[6] )
			//           goto LABEL_33;
			//         IsFormatSupported = UnityEngine::SystemInfo::IsFormatSupported(
			//                               (GraphicsFormat__Enum)m_RWTextureWithAlphaColorFormatList[i + 8],
			//                               FormatUsage__Enum_LoadStore,
			//                               0LL);
			//         v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//         if ( IsFormatSupported )
			//           break;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//       m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaColorFormatList;
			//       if ( m_RWTextureWithoutAlphaColorFormatList )
			//       {
			//         if ( i < m_RWTextureWithoutAlphaColorFormatList.max_length.size )
			//         {
			//           TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaFormat = m_RWTextureWithoutAlphaColorFormatList.vector[i];
			//           m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			// LABEL_16:
			//           sub_180002C70(m_RWTextureWithAlphaColorFormatList);
			//           v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithoutAlphaFormat )
			//           {
			//             HG::Rendering::HGRPLogger::LogWarning(
			//               (String *)"No supported texture format could enable random write in HGUtils defined format list",
			//               0LL);
			//             v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//           }
			//           goto LABEL_18;
			//         }
			// LABEL_33:
			//         sub_180070270(m_RWTextureWithAlphaColorFormatList, m_RWTextureWithoutAlphaColorFormatList);
			//       }
			// LABEL_35:
			//       sub_180B536AC(m_RWTextureWithAlphaColorFormatList, m_RWTextureWithoutAlphaColorFormatList);
			//     }
			//     if ( !static_fields.m_RWTextureWithAlphaFormat )
			//     {
			//       for ( j = 0; ; ++j )
			//       {
			//         sub_180002C70(v3);
			//         m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//         m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaColorFormatList;
			//         if ( !m_RWTextureWithoutAlphaColorFormatList )
			//           goto LABEL_35;
			//         if ( (signed int)j >= m_RWTextureWithoutAlphaColorFormatList.max_length.size )
			//           goto LABEL_30;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaColorFormatList;
			//         if ( !m_RWTextureWithAlphaColorFormatList )
			//           goto LABEL_35;
			//         if ( j >= m_RWTextureWithAlphaColorFormatList[6] )
			//           goto LABEL_33;
			//         v11 = UnityEngine::SystemInfo::IsFormatSupported(
			//                 (GraphicsFormat__Enum)m_RWTextureWithAlphaColorFormatList[j + 8],
			//                 FormatUsage__Enum_LoadStore,
			//                 0LL);
			//         v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//         if ( v11 )
			//           break;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//       m_RWTextureWithoutAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaColorFormatList;
			//       if ( !m_RWTextureWithoutAlphaColorFormatList )
			//         goto LABEL_35;
			//       if ( j >= m_RWTextureWithoutAlphaColorFormatList.max_length.size )
			//         goto LABEL_33;
			//       TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaFormat = m_RWTextureWithoutAlphaColorFormatList.vector[j];
			//       m_RWTextureWithAlphaColorFormatList = TypeInfo::HG::Rendering::Runtime::HGUtils;
			// LABEL_30:
			//       sub_180002C70(m_RWTextureWithAlphaColorFormatList);
			//       v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaFormat )
			//       {
			//         HG::Rendering::HGRPLogger::LogWarning(
			//           (String *)"No supported texture format could enable random write in HGUtils defined format list",
			//           0LL);
			//         v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//       }
			//     }
			//     sub_180002C70(v3);
			//     return TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.m_RWTextureWithAlphaFormat;
			//   }
			// }
			// 
			return (GraphicsFormat)GraphicsFormat.None;
		}

		public static bool IsSkyboxRenderingEnabled(HGCamera hgCamera)
		{
			// // Boolean IsSkyboxRenderingEnabled(HGCamera)
			// bool HG::Rendering::Runtime::HGUtils::IsSkyboxRenderingEnabled(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   Camera *static_fields; // rcx
			//   int *klass; // rdx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rdi
			//   HGAdditionalCameraData *v7; // rax
			//   int32_t clearColorMode; // eax
			//   __int64 v10; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Camera__Class *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *v13; // rax
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
			//   static_fields = (Camera *)v3.static_fields;
			//   klass = (int *)static_fields.klass;
			//   if ( !static_fields.klass )
			//     goto LABEL_31;
			//   if ( klass[6] > 978 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, klass);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     klass = (int *)v3.static_fields;
			//     v10 = *(_QWORD *)klass;
			//     if ( !*(_QWORD *)klass )
			//       goto LABEL_31;
			//     if ( *(_DWORD *)(v10 + 24) <= 0x3D2u )
			//       goto LABEL_46;
			//     if ( *(_QWORD *)(v10 + 7856) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(978, 0LL);
			//       if ( !Patch )
			//         goto LABEL_31;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                (ILFixDynamicMethodWrapper_27 *)Patch,
			//                (Object *)hgCamera,
			//                0LL);
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_31;
			//   if ( !byte_18D8EDA05 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDA05 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, klass);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (Camera *)v3.static_fields;
			//   klass = (int *)static_fields.klass;
			//   if ( !static_fields.klass )
			//     goto LABEL_31;
			//   if ( klass[6] > 681 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, klass);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (Camera *)v3.static_fields;
			//     v12 = static_fields.klass;
			//     if ( !static_fields.klass )
			//       goto LABEL_31;
			//     if ( LODWORD(v12._0.namespaze) > 0x2A9 )
			//     {
			//       if ( *(_QWORD *)&v12[14]._1.initializationExceptionGCHandle )
			//       {
			//         v13 = IFix::WrappersManagerImpl::GetPatch(681, 0LL);
			//         if ( v13 )
			//         {
			//           clearColorMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(
			//                              (ILFixDynamicMethodWrapper_20 *)v13,
			//                              (Object *)hgCamera,
			//                              0LL);
			//           return clearColorMode == 0;
			//         }
			// LABEL_31:
			//         sub_180B536AC(static_fields, klass);
			//       }
			//       goto LABEL_16;
			//     }
			// LABEL_46:
			//     sub_180070270(static_fields, klass);
			//   }
			// LABEL_16:
			//   m_AdditionalCameraData = hgCamera.fields.m_AdditionalCameraData;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_AdditionalCameraData )
			//   {
			//     static_fields = (Camera *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//     if ( m_AdditionalCameraData.fields._._._._.m_CachedPtr )
			//     {
			//       v7 = hgCamera.fields.m_AdditionalCameraData;
			//       if ( v7 )
			//       {
			//         clearColorMode = v7.fields.clearColorMode;
			//         return clearColorMode == 0;
			//       }
			//       goto LABEL_31;
			//     }
			//   }
			//   static_fields = hgCamera.fields.camera;
			//   if ( !static_fields )
			//     goto LABEL_31;
			//   if ( UnityEngine::Camera::get_clearFlags(static_fields, 0LL) == CameraClearFlags__Enum_Skybox )
			//     return 1;
			//   static_fields = hgCamera.fields.camera;
			//   if ( !static_fields )
			//     goto LABEL_31;
			//   UnityEngine::Camera::get_clearFlags(static_fields, 0LL);
			//   return 0;
			// }
			// 
			return default(bool);
		}

		public static bool IsInIsolatedDisplayMode(Camera camera)
		{
			// // Boolean IsInIsolatedDisplayMode(Camera)
			// bool HG::Rendering::Runtime::HGUtils::IsInIsolatedDisplayMode(Camera *camera, MethodInfo *method)
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
			//   if ( wrapperArray.max_length.size <= 736 )
			//     return 0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x2E0u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[20].vector[16] )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)camera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static void ReleaseTemporaryRenderTexture(ref RenderTexture renderTexture)
		{
			// // Void ReleaseTemporaryRenderTexture(RenderTexture ByRef)
			// void HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(RenderTexture **renderTexture, MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(517, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(517, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, renderTexture, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::RenderTexture::ReleaseTemporary(*renderTexture, 0LL);
			//     *renderTexture = 0LL;
			//     sub_1800054D0((HGRenderPathScene *)renderTexture, v3, v4, v5, v9, v10);
			//   }
			// }
			// 
		}

		public static void Destroy(global::UnityEngine.Object obj)
		{
			// // Void Destroy(Object)
			// void HG::Rendering::Runtime::HGUtils::Destroy(Object_1 *obj, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D9196D5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196D5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2099, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2099, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)obj, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     UnityEngine::Object::Destroy(obj, 0LL);
			//   }
			// }
			// 
		}

		internal static HGRenderPathInternal GetInternalRenderPath(HGRenderPath renderPath)
		{
			// // HGRenderPathInternal GetInternalRenderPath(HGRenderPath)
			// HGRenderPathInternal__Enum HG::Rendering::Runtime::HGUtils::GetInternalRenderPath(
			//         HGRenderPath__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (*v5)(void); // rax
			//   unsigned int v6; // edi
			//   unsigned __int8 (__fastcall *v7)(_QWORD, __int64); // rax
			//   HGRenderPathInternal__Enum result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rax
			//   __int64 v11; // rax
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size > 660 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x294 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[14]._0.this_arg.data.dummy )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(660, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, renderPath, 0LL);
			//     }
			// LABEL_15:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( !byte_18D8F5550 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     byte_18D8F5550 = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Graphics._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Graphics, wrapperArray);
			//   v5 = (__int64 (*)(void))qword_18D8F4460;
			//   if ( !qword_18D8F4460 )
			//   {
			//     v5 = (__int64 (*)(void))il2cpp_resolve_icall_0("UnityEngine.Graphics::get_activeTier()");
			//     if ( !v5 )
			//     {
			//       v10 = sub_1802DBBE8("UnityEngine.Graphics::get_activeTier()");
			//       sub_18000F750(v10, 0LL);
			//     }
			//     qword_18D8F4460 = (__int64)v5;
			//   }
			//   v6 = v5();
			//   v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18D8F5548;
			//   if ( !qword_18D8F5548 )
			//   {
			//     v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Unit"
			//                                                             "yEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
			//     if ( !v7 )
			//     {
			//       v11 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Ren"
			//               "dering.BuiltinShaderDefine)");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F5548 = (__int64)v7;
			//   }
			//   if ( !v7(v6, 37LL) )
			//     return renderPath;
			//   result = HGRenderPathInternal__Enum_OnePassDeferredSubpass;
			//   if ( renderPath != HGRenderPath__Enum_Deferred )
			//     return renderPath;
			//   return result;
			// }
			// 
			return (HGRenderPathInternal)HGRenderPathInternal.Forward;
		}

		[IDTag(1)]
		internal static float GetRenderingScale(HGCamera hgCamera, HGSettingParameters settingParameters)
		{
			// // Single GetRenderingScale(HGCamera, HGSettingParameters)
			// float HG::Rendering::Runtime::HGUtils::GetRenderingScale(
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB2D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDB2D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size <= 694 )
			//     goto LABEL_9;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_15:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x2B6 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[14].vtable.Equals.method )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(694, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
			//                (ILFixDynamicMethodWrapper_20 *)Patch,
			//                (Object *)hgCamera,
			//                (Object *)settingParameters,
			//                0LL);
			//     goto LABEL_15;
			//   }
			// LABEL_9:
			//   if ( !hgCamera )
			//     goto LABEL_15;
			//   m_AdditionalCameraData = hgCamera.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_15;
			//   if ( m_AdditionalCameraData.fields.hgRenderPath != 3
			//     && HG::Rendering::Runtime::HGCamera::get_renderPath(hgCamera, 0LL) )
			//   {
			//     return 1.0;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//   return HG::Rendering::Runtime::HGUtils::GetRenderingScale(settingParameters, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(0)]
		internal static float GetRenderingScale(HGSettingParameters settingParameters)
		{
			// // Single GetRenderingScale(HGSettingParameters)
			// float HG::Rendering::Runtime::HGUtils::GetRenderingScale(HGSettingParameters *settingParameters, MethodInfo *method)
			// {
			//   _QWORD **static_fields; // rcx
			//   __int64 v4; // rdx
			//   _QWORD *v5; // rbx
			//   __int64 v6; // rbx
			//   void (__fastcall *v7)(__int64, int *, int *); // rax
			//   __int64 v8; // rbx
			//   __int64 v9; // rbx
			//   void (__fastcall *v10)(__int64, int *, int *); // rax
			//   __int64 v11; // rcx
			//   unsigned int (__fastcall *v12)(__int64); // rax
			//   int v13; // ebp
			//   unsigned int (__fastcall *v14)(_QWORD **); // rax
			//   SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rbx
			//   struct MethodInfo *v16; // rdi
			//   Il2CppClass *klass; // rax
			//   Il2CppClass *v18; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rax
			//   __int64 v22; // rax
			//   __int64 v23; // rax
			//   __int64 v24; // rax
			//   __int64 v25; // rax
			//   int v26; // [rsp+20h] [rbp-28h] BYREF
			//   int v27[3]; // [rsp+24h] [rbp-24h] BYREF
			//   int v28; // [rsp+60h] [rbp+18h] BYREF
			//   int v29; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDB2E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8EDB2E = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = *static_fields[23];
			//   if ( !v4 )
			//     goto LABEL_45;
			//   if ( *(int *)(v4 + 24) <= 695 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)static_fields + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(static_fields, v4);
			//     static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (_QWORD **)*static_fields[23];
			//   if ( !static_fields )
			// LABEL_45:
			//     sub_180B536AC(static_fields, v4);
			//   if ( *((_DWORD *)static_fields + 6) <= 0x2B7u )
			//     sub_180070270(static_fields, v4);
			//   if ( static_fields[699] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(695, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                (ILFixDynamicMethodWrapper_16 *)Patch,
			//                (Object *)settingParameters,
			//                0LL);
			//     goto LABEL_45;
			//   }
			// LABEL_9:
			//   if ( !TypeInfo::UnityEngine::Display._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Display, v4);
			//   if ( !byte_18D8F43DF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     byte_18D8F43DF = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Display._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Display, v4);
			//   static_fields = (_QWORD **)TypeInfo::UnityEngine::Display.static_fields;
			//   v5 = static_fields[1];
			//   if ( !v5 )
			//     goto LABEL_45;
			//   if ( !byte_18D8F43DC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     byte_18D8F43DC = 1;
			//   }
			//   v6 = v5[2];
			//   v29 = 0;
			//   v26 = 0;
			//   if ( !TypeInfo::UnityEngine::Display._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Display, v4);
			//   v7 = (void (__fastcall *)(__int64, int *, int *))qword_18D8F43E8;
			//   if ( !qword_18D8F43E8 )
			//   {
			//     v7 = (void (__fastcall *)(__int64, int *, int *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
			//     if ( !v7 )
			//     {
			//       v21 = sub_1802DBBE8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
			//       sub_18000F750(v21, 0LL);
			//     }
			//     qword_18D8F43E8 = (__int64)v7;
			//   }
			//   v7(v6, &v29, &v26);
			//   if ( !byte_18D8F43DF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     byte_18D8F43DF = 1;
			//   }
			//   static_fields = (_QWORD **)TypeInfo::UnityEngine::Display;
			//   if ( !TypeInfo::UnityEngine::Display._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Display, v4);
			//     static_fields = (_QWORD **)TypeInfo::UnityEngine::Display;
			//   }
			//   v8 = static_fields[23][1];
			//   if ( !v8 )
			//     goto LABEL_45;
			//   if ( !byte_18D8F43DD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     static_fields = (_QWORD **)TypeInfo::UnityEngine::Display;
			//     byte_18D8F43DD = 1;
			//   }
			//   v9 = *(_QWORD *)(v8 + 16);
			//   v27[0] = 0;
			//   v28 = 0;
			//   if ( !*((_DWORD *)static_fields + 56) )
			//     il2cpp_runtime_class_init_0(static_fields, v4);
			//   v10 = (void (__fastcall *)(__int64, int *, int *))qword_18D8F43E8;
			//   if ( !qword_18D8F43E8 )
			//   {
			//     v10 = (void (__fastcall *)(__int64, int *, int *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32"
			//                                                         "&,System.Int32&)");
			//     if ( !v10 )
			//     {
			//       v22 = sub_1802DBBE8("UnityEngine.Display::GetSystemExtImpl(System.IntPtr,System.Int32&,System.Int32&)");
			//       sub_18000F750(v22, 0LL);
			//     }
			//     qword_18D8F43E8 = (__int64)v10;
			//   }
			//   v10(v9, v27, &v28);
			//   v12 = (unsigned int (__fastcall *)(__int64))qword_18D8F4418;
			//   v13 = v28;
			//   if ( !qword_18D8F4418 )
			//   {
			//     v12 = (unsigned int (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.Screen::GetScreenOrientation()");
			//     if ( !v12 )
			//     {
			//       v23 = sub_1802DBBE8("UnityEngine.Screen::GetScreenOrientation()");
			//       sub_18000F750(v23, 0LL);
			//     }
			//     qword_18D8F4418 = (__int64)v12;
			//   }
			//   if ( v12(v11) == 3 )
			//     goto LABEL_66;
			//   v14 = (unsigned int (__fastcall *)(_QWORD **))qword_18D8F4418;
			//   if ( !qword_18D8F4418 )
			//   {
			//     v14 = (unsigned int (__fastcall *)(_QWORD **))il2cpp_resolve_icall_0("UnityEngine.Screen::GetScreenOrientation()");
			//     if ( !v14 )
			//     {
			//       v24 = sub_1802DBBE8("UnityEngine.Screen::GetScreenOrientation()");
			//       sub_18000F750(v24, 0LL);
			//     }
			//     qword_18D8F4418 = (__int64)v14;
			//   }
			//   if ( v14(static_fields) == 4 )
			//   {
			// LABEL_66:
			//     if ( v13 > v29 )
			//       v13 = v29;
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_45;
			//   renderingScale_k__BackingField = settingParameters.fields._renderingScale_k__BackingField;
			//   v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !renderingScale_k__BackingField )
			//     goto LABEL_45;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v25 = sub_18010B520(v16.klass);
			//     (**(void (__fastcall ***)(_QWORD))(*(_QWORD *)(v25 + 192) + 48LL))(*(_QWORD *)(v25 + 192));
			//   }
			//   v18 = v16.klass;
			//   if ( ((__int64)v18.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v18);
			//   if ( v13 > 1080 )
			//     return renderingScale_k__BackingField.fields._paramValue_k__BackingField;
			//   if ( v13 < 432 )
			//     return 1.0;
			//   return (float)((sub_1825C6750(v18, v4) + 432) & 0xFFFFFFFE) / (float)v13;
			// }
			// 
			return 0f;
		}

		[IDTag(1)]
		public static Bounds TransformBounds(in Bounds b, Transform t)
		{
			// // Bounds TransformBounds(Bounds ByRef, Transform)
			// Bounds *HG::Rendering::Runtime::HGUtils::TransformBounds(
			//         Bounds *__return_ptr retstr,
			//         Bounds *b,
			//         Transform *t,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   Bounds *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v12; // xmm0
			//   __int64 v13; // xmm1_8
			//   Bounds *result; // rax
			//   Bounds v15; // [rsp+30h] [rbp-98h] BYREF
			//   __int128 v16; // [rsp+48h] [rbp-80h]
			//   __int128 v17; // [rsp+58h] [rbp-70h]
			//   __int128 v18; // [rsp+68h] [rbp-60h]
			//   Matrix4x4 v19; // [rsp+80h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9196D6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196D6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3207, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3207, 0LL);
			//     if ( Patch )
			//     {
			//       v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1144(&v15, Patch, b, (Object *)t, 0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !t )
			//     goto LABEL_7;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v19, t, 0LL);
			//   v16 = *(_OWORD *)&localToWorldMatrix.m00;
			//   v17 = *(_OWORD *)&localToWorldMatrix.m01;
			//   v18 = *(_OWORD *)&localToWorldMatrix.m02;
			//   *(_OWORD *)&v15.m_Center.x = *(_OWORD *)&localToWorldMatrix.m03;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(_OWORD *)&v19.m00 = v16;
			//   *(_OWORD *)&v19.m01 = v17;
			//   *(_OWORD *)&v19.m02 = v18;
			//   *(_OWORD *)&v19.m03 = *(_OWORD *)&v15.m_Center.x;
			//   v10 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v15, b, &v19, 0LL);
			// LABEL_9:
			//   v12 = *(_OWORD *)&v10.m_Center.x;
			//   v13 = *(_QWORD *)&v10.m_Extents.y;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m_Center.x = v12;
			//   *(_QWORD *)&retstr.m_Extents.y = v13;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Bounds TransformBounds(in Bounds b, Matrix4x4 m)
		{
			// // Bounds TransformBounds(Bounds ByRef, Matrix4x4)
			// Bounds *HG::Rendering::Runtime::HGUtils::TransformBounds(
			//         Bounds *__return_ptr retstr,
			//         Bounds *b,
			//         Matrix4x4 *m,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm1
			//   __int128 v8; // xmm4
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm3
			//   __m128 y_low; // xmm8
			//   __m128 si128; // xmm5
			//   __m128 v13; // xmm8
			//   __int128 v14; // xmm0
			//   __m128 v15; // xmm7
			//   __m128 v16; // xmm7
			//   __int128 v17; // xmm0
			//   float v18; // xmm6_4
			//   Vector3 *v19; // rax
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // rax
			//   float v22; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   Vector3 v30; // [rsp+38h] [rbp-59h] BYREF
			//   Vector3 m_Extents; // [rsp+48h] [rbp-49h] BYREF
			//   Bounds v32; // [rsp+58h] [rbp-39h] BYREF
			//   Matrix4x4 v33; // [rsp+78h] [rbp-19h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1445, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1445, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v25, v24);
			//     v26 = *(_OWORD *)&m.m01;
			//     *(_OWORD *)&v33.m00 = *(_OWORD *)&m.m00;
			//     v27 = *(_OWORD *)&m.m02;
			//     *(_OWORD *)&v33.m01 = v26;
			//     v28 = *(_OWORD *)&m.m03;
			//     *(_OWORD *)&v33.m02 = v27;
			//     *(_OWORD *)&v33.m03 = v28;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_542(&v32, Patch, b, &v33, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_OWORD *)&b.m_Center.x;
			//     v8 = *(_OWORD *)&m.m00;
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     *(_OWORD *)&v32.m_Center.x = v7;
			//     m_Extents = v32.m_Extents;
			//     v9 = *(_OWORD *)&b.m_Center.x;
			//     v10 = *(_OWORD *)&m.m01;
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     *(_OWORD *)&v32.m_Center.x = v9;
			//     v30.z = v32.m_Extents.z;
			//     *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
			//     y_low = (__m128)LODWORD(v32.m_Extents.y);
			//     si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18A357260);
			//     y_low.m128_f32[0] = v32.m_Extents.y * *(float *)&v10;
			//     v13 = _mm_and_ps(y_low, si128);
			//     LODWORD(v7) = COERCE_UNSIGNED_INT(v32.m_Extents.z * COERCE_FLOAT(*(_OWORD *)&m.m02)) & si128.m128_i32[0];
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     v30.z = v32.m_Extents.z;
			//     v13.m128_f32[0] = (float)(v13.m128_f32[0]
			//                             + COERCE_FLOAT(COERCE_UNSIGNED_INT(m_Extents.x * *(float *)&v8) & si128.m128_i32[0]))
			//                     + *(float *)&v7;
			//     *(_OWORD *)&v32.m_Center.x = *(_OWORD *)&b.m_Center.x;
			//     *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
			//     v14 = *(_OWORD *)&b.m_Center.x;
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     *(_OWORD *)&v32.m_Center.x = v14;
			//     m_Extents = v32.m_Extents;
			//     v15 = (__m128)LODWORD(v32.m_Extents.y);
			//     v15.m128_f32[0] = v32.m_Extents.y * m.m11;
			//     LODWORD(v7) = COERCE_UNSIGNED_INT(v32.m_Extents.z * m.m12) & si128.m128_i32[0];
			//     v16 = _mm_and_ps(v15, si128);
			//     v16.m128_f32[0] = v16.m128_f32[0] + COERCE_FLOAT(COERCE_UNSIGNED_INT(v30.x * m.m10) & si128.m128_i32[0]);
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     v30.z = v32.m_Extents.z;
			//     v16.m128_f32[0] = v16.m128_f32[0] + *(float *)&v7;
			//     *(_OWORD *)&v32.m_Center.x = *(_OWORD *)&b.m_Center.x;
			//     *(_QWORD *)&v30.x = *(_QWORD *)&v32.m_Extents.x;
			//     v17 = *(_OWORD *)&b.m_Center.x;
			//     *(_QWORD *)&v32.m_Extents.y = *(_QWORD *)&b.m_Extents.y;
			//     *(_OWORD *)&v32.m_Center.x = v17;
			//     m_Extents = v32.m_Extents;
			//     v18 = (float)(COERCE_FLOAT(COERCE_UNSIGNED_INT(v32.m_Extents.y * m.m21) & si128.m128_i32[0])
			//                 + COERCE_FLOAT(COERCE_UNSIGNED_INT(v30.x * m.m20) & si128.m128_i32[0]))
			//         + COERCE_FLOAT(COERCE_UNSIGNED_INT(v32.m_Extents.z * m.m22) & si128.m128_i32[0]);
			//     *(_QWORD *)&m_Extents.x = *(_QWORD *)&b.m_Center.x;
			//     LODWORD(m_Extents.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&b.m_Center.z));
			//     v19 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v30, m, &m_Extents, 0LL);
			//     m_Extents.z = v18;
			//     *(_QWORD *)&v10 = *(_QWORD *)&v19.x;
			//     *(_QWORD *)&m_Extents.x = _mm_unpacklo_ps(v13, v16).m128_u64[0];
			//     v21 = UnityEngine::Vector3::op_Multiply(&v30, &m_Extents, 2.0, v20);
			//     *(_QWORD *)&v7 = *(_QWORD *)&v21.x;
			//     m_Extents.z = v21.z;
			//     v30.z = v22;
			//     *(_OWORD *)&retstr.m_Center.x = 0LL;
			//     *(_QWORD *)&retstr.m_Extents.y = 0LL;
			//     *(_QWORD *)&m_Extents.x = v7;
			//     *(_QWORD *)&v30.x = v10;
			//     UnityEngine::Bounds::Bounds(retstr, &v30, &m_Extents, 0LL);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static float Sqr(this float f)
		{
			// // Single Sqr(Single)
			// float HG::Rendering::Runtime::HGUtils::Sqr(float f, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3208, 0LL) )
			//     return f * f;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3208, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, f, 0LL);
			// }
			// 
			return 0f;
		}

		public static float Sqrt(this float f)
		{
			// // Single Sqrt(Single)
			// float HG::Rendering::Runtime::HGUtils::Sqrt(float f, MethodInfo *method)
			// {
			//   float3 *v2; // rdx
			//   float3 *v3; // rcx
			//   float3 *v4; // r8
			//   float3 *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3209, 0LL) )
			//     return sub_1802ECED0(v3, v2, v4, v5);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3209, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v9, v8);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, f, 0LL);
			// }
			// 
			return 0f;
		}

		internal static int MaxAxis(this Vector3 v)
		{
			// // Int32 MaxAxis(Vector3)
			// int32_t HG::Rendering::Runtime::HGUtils::MaxAxis(Vector3 *v, MethodInfo *method)
			// {
			//   int32_t v3; // edi
			//   float v4; // xmm0_4
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3210, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3210, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v6);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1145(Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     v4 = v.z;
			//     if ( v4 <= v.x || v4 <= v.y )
			//     {
			//       LOBYTE(v3) = v.y > v.x;
			//       return v3;
			//     }
			//     else
			//     {
			//       return 2;
			//     }
			//   }
			// }
			// 
			return 0;
		}

		[IDTag(1)]
		public static float Abs(this float f)
		{
			// // Single Abs(Single)
			// float HG::Rendering::Runtime::HGUtils::Abs(float f, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3211, 0LL) )
			//     return fabs(f);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3211, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, f, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(2)]
		public static Vector2 Abs(this Vector2 v)
		{
			// // Vector2 Abs(Vector2)
			// Vector2 HG::Rendering::Runtime::HGUtils::Abs(Vector2 v, MethodInfo *method)
			// {
			//   MethodInfo *v3; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3212, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3212, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1146(Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(_QWORD *)&v9.x = _mm_unpacklo_ps(
			//                          _mm_and_ps((__m128)LODWORD(v.x), (__m128)xmmword_18A357260),
			//                          _mm_and_ps((__m128)LODWORD(v.y), (__m128)xmmword_18A357260)).m128_u64[0];
			//     v9.z = 0.0;
			//     return UnityEngine::Vector4::op_Implicit(&v9, v3);
			//   }
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 Abs(this Vector3 v)
		{
			// // Vector3 Abs(Vector3)
			// Vector3 *HG::Rendering::Runtime::HGUtils::Abs(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int32 v7; // xmm2_4
			//   float z; // xmm1_4
			//   int v9; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // xmm0_8
			//   Vector3 *v13; // rax
			//   __int64 v14; // xmm0_8
			//   Vector3 v15; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v16[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 596 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x254 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !*(_QWORD *)&v5[12]._1.field_count )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(596, 0LL);
			//       if ( Patch )
			//       {
			//         v12 = *(_QWORD *)&v.x;
			//         v15.z = v.z;
			//         *(_QWORD *)&v15.x = v12;
			//         v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v16, Patch, &v15, 0LL);
			//         v14 = *(_QWORD *)&v13.x;
			//         *(float *)&v13 = v13.z;
			//         *(_QWORD *)&retstr.x = v14;
			//         LODWORD(retstr.z) = (_DWORD)v13;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   COERCE_FLOAT(v7 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//   z = v.z;
			//   LODWORD(retstr.x) = LODWORD(v.x) & v7;
			//   v9 = LODWORD(v.y) & v7;
			//   LODWORD(retstr.z) = LODWORD(z) & v7;
			//   LODWORD(retstr.y) = v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static Vector4 Abs(this Vector4 v)
		{
			// // Vector4 Abs(Vector4)
			// Vector4 *HG::Rendering::Runtime::HGUtils::Abs(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3213, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3213, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_and_ps(*(__m128 *)v, (__m128)xmmword_18A357260);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void SetCBData<T>(ref CBHandle cbHandle, T value, int offset) where T : struct
		{
		}

		public static void SetPerPassConstants(float flipX, float flipY, float renderPathInjected, float orientationType, CommandBuffer cmd, ScriptableRenderContext context)
		{
			// // Void SetPerPassConstants(Single, Single, Single, Single, CommandBuffer, ScriptableRenderContext)
			// void HG::Rendering::Runtime::HGUtils::SetPerPassConstants(
			//         float flipX,
			//         float flipY,
			//         float renderPathInjected,
			//         float orientationType,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool v11; // zf
			//   void (__fastcall *v12)(ScriptableRenderContext *, __int64, __int128 *); // rax
			//   __int64 v13; // rdx
			//   void (__fastcall *v14)(__int64, _DWORD *, __int64); // rax
			//   __int64 v15; // rbx
			//   void (__fastcall *v16)(__int64, __int128 *, __int64); // rax
			//   struct HGShaderIDs__Class *v17; // rax
			//   unsigned int PerPassConstants; // edi
			//   void (__fastcall *v19)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rax
			//   __int64 v22; // rax
			//   __int64 v23; // rax
			//   __int64 v24; // rax
			//   _DWORD v25[4]; // [rsp+40h] [rbp-88h] BYREF
			//   __int128 v26; // [rsp+50h] [rbp-78h] BYREF
			//   __int128 v27; // [rsp+60h] [rbp-68h] BYREF
			//   __int64 v28; // [rsp+70h] [rbp-58h]
			// 
			//   if ( !byte_18D8EDB2F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D8EDB2F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v7);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_31;
			//   if ( wrapperArray.max_length.size <= 1081 )
			//     goto LABEL_9;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//   if ( !v9 )
			// LABEL_31:
			//     sub_180B536AC(v9, wrapperArray);
			//   if ( LODWORD(v9._0.namespaze) <= 0x439 )
			//     sub_180070270(v9, wrapperArray);
			//   if ( v9[23]._0.byval_arg.data.dummy )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1081, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_393(
			//         Patch,
			//         flipX,
			//         flipY,
			//         renderPathInjected,
			//         orientationType,
			//         (Object *)cmd,
			//         context,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_31;
			//   }
			// LABEL_9:
			//   *(float *)&v25[3] = orientationType;
			//   *(float *)v25 = renderPathInjected;
			//   *(float *)&v25[1] = flipX;
			//   v11 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor == 0;
			//   *(float *)&v25[2] = flipY;
			//   if ( v11 )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, wrapperArray);
			//   if ( !byte_18D8F560A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D8F560A = 1;
			//   }
			//   v28 = 0LL;
			//   v27 = 0LL;
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, wrapperArray);
			//   v12 = (void (__fastcall *)(ScriptableRenderContext *, __int64, __int128 *))qword_18D8F5630;
			//   if ( !qword_18D8F5630 )
			//   {
			//     v12 = (void (__fastcall *)(ScriptableRenderContext *, __int64, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                  "UnityEngine.Rendering.ScriptableRenderC"
			//                                                                                  "ontext::AllocateConstantBuffer_Injected"
			//                                                                                  "(UnityEngine.Rendering.ScriptableRender"
			//                                                                                  "Context&,System.Int32,UnityEngine.Rendering.CBHandle&)");
			//     if ( !v12 )
			//     {
			//       v21 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.ScriptableRenderContext::AllocateConstantBuffer_Injected(UnityEngine.Rendering.Scrip"
			//               "tableRenderContext&,System.Int32,UnityEngine.Rendering.CBHandle&)");
			//       sub_18000F750(v21, 0LL);
			//     }
			//     qword_18D8F5630 = (__int64)v12;
			//   }
			//   v12(&context, 32LL, &v27);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v13);
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>.rgctx_data )
			//     sub_180041F40(MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>);
			//   v14 = (void (__fastcall *)(__int64, _DWORD *, __int64))qword_18D8F3FE0;
			//   if ( !qword_18D8F3FE0 )
			//   {
			//     v14 = (void (__fastcall *)(__int64, _DWORD *, __int64))il2cpp_resolve_icall_0(
			//                                                              "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(Sys"
			//                                                              "tem.Void*,System.Void*,System.Int64)");
			//     if ( !v14 )
			//     {
			//       v22 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
			//       sub_18000F750(v22, 0LL);
			//     }
			//     qword_18D8F3FE0 = (__int64)v14;
			//   }
			//   v15 = v28;
			//   v14(v28, v25, 16LL);
			//   v26 = 0LL;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>.rgctx_data )
			//     sub_180041F40(MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>);
			//   v16 = (void (__fastcall *)(__int64, __int128 *, __int64))qword_18D8F3FE0;
			//   if ( !qword_18D8F3FE0 )
			//   {
			//     v16 = (void (__fastcall *)(__int64, __int128 *, __int64))il2cpp_resolve_icall_0(
			//                                                                "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(S"
			//                                                                "ystem.Void*,System.Void*,System.Int64)");
			//     if ( !v16 )
			//     {
			//       v23 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
			//       sub_18000F750(v23, 0LL);
			//     }
			//     qword_18D8F3FE0 = (__int64)v16;
			//   }
			//   v16(v15 + 16, &v26, 16LL);
			//   v17 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs, wrapperArray);
			//     v17 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   }
			//   PerPassConstants = v17.static_fields._PerPassConstants;
			//   if ( !cmd )
			//     goto LABEL_31;
			//   v19 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int))qword_18D8F55E0;
			//   if ( !qword_18D8F55E0 )
			//   {
			//     v19 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD, _QWORD, int))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.Rendering.CommandBuffer::SetG"
			//                                                                                "lobalConstantBufferInternal0(System.UInt3"
			//                                                                                "2,System.Int32,System.Int32,System.Int32)");
			//     if ( !v19 )
			//     {
			//       v24 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.CommandBuffer::SetGlobalConstantBufferInternal0(System.UInt32,System.Int32,System.In"
			//               "t32,System.Int32)");
			//       sub_18000F750(v24, 0LL);
			//     }
			//     qword_18D8F55E0 = (__int64)v19;
			//   }
			//   v19(cmd, (unsigned int)v27, PerPassConstants, DWORD1(v27), 32);
			// }
			// 
		}

		internal static Matrix4x4 GetPreTransformMatrix(bool renderToBackBuffer)
		{
			// // Matrix4x4 GetPreTransformMatrix(Boolean)
			// Matrix4x4 *HG::Rendering::Runtime::HGUtils::GetPreTransformMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         bool renderToBackBuffer,
			//         MethodInfo *method)
			// {
			//   unsigned __int32 v5; // eax
			//   unsigned __int32 v6; // eax
			//   Matrix4x4 *v7; // rax
			//   HGUtils__StaticFields *static_fields; // rcx
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   HGUtils__StaticFields *v12; // rcx
			//   __int128 v13; // xmm1
			//   HGUtils__StaticFields *v14; // rcx
			//   __int128 v15; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int128 v19; // xmm1
			//   Matrix4x4 *result; // rax
			//   Matrix4x4 v21; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9196D7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196D7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3214, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3214, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1148(&v21, Patch, renderToBackBuffer, 0LL);
			//     goto LABEL_15;
			//   }
			//   if ( !renderToBackBuffer )
			//   {
			// LABEL_8:
			//     v7 = (Matrix4x4 *)sub_182805160(&v21);
			// LABEL_15:
			//     v19 = *(_OWORD *)&v7.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v7.m00;
			//     v10 = *(_OWORD *)&v7.m02;
			//     *(_OWORD *)&retstr.m01 = v19;
			//     v11 = *(_OWORD *)&v7.m03;
			//     goto LABEL_16;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Display);
			//   v5 = UnityEngine::Display::get_preTransform(0LL) - 1;
			//   if ( v5 )
			//   {
			//     v6 = v5 - 1;
			//     if ( v6 )
			//     {
			//       if ( v6 != 1 )
			//         goto LABEL_8;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//       v9 = *(_OWORD *)&static_fields.s_preTransform270Matrix.m01;
			//       *(_OWORD *)&retstr.m00 = *(_OWORD *)&static_fields.s_preTransform270Matrix.m00;
			//       v10 = *(_OWORD *)&static_fields.s_preTransform270Matrix.m02;
			//       *(_OWORD *)&retstr.m01 = v9;
			//       v11 = *(_OWORD *)&static_fields.s_preTransform270Matrix.m03;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v12 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//       v13 = *(_OWORD *)&v12.s_preTransform180Matrix.m01;
			//       *(_OWORD *)&retstr.m00 = *(_OWORD *)&v12.s_preTransform180Matrix.m00;
			//       v10 = *(_OWORD *)&v12.s_preTransform180Matrix.m02;
			//       *(_OWORD *)&retstr.m01 = v13;
			//       v11 = *(_OWORD *)&v12.s_preTransform180Matrix.m03;
			//     }
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v14 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//     v15 = *(_OWORD *)&v14.s_preTransform90Matrix.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v14.s_preTransform90Matrix.m00;
			//     v10 = *(_OWORD *)&v14.s_preTransform90Matrix.m02;
			//     *(_OWORD *)&retstr.m01 = v15;
			//     v11 = *(_OWORD *)&v14.s_preTransform90Matrix.m03;
			//   }
			// LABEL_16:
			//   *(_OWORD *)&retstr.m02 = v10;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m03 = v11;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		internal static GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat format)
		{
			// // GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat)
			// GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//         GraphicsFormat__Enum format,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   DepthBits__Enum depthBits; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D9196D8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9196D8 = 1;
			//   }
			//   depthBits = DepthBits__Enum_None;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1064, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1064, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, format, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     return HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(format, &depthBits, 0LL);
			//   }
			// }
			// 
			return (GraphicsFormat)GraphicsFormat.None;
		}

		[IDTag(0)]
		internal static GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat format, out DepthBits depthBits)
		{
			// // GraphicsFormat GetSupportedFormatForDepth(GraphicsFormat, DepthBits ByRef)
			// GraphicsFormat__Enum HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//         GraphicsFormat__Enum format,
			//         DepthBits__Enum *depthBits,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   unsigned __int8 (__fastcall *v7)(__int64, __int64, MethodInfo *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, depthBits);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size <= 136 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_17:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x88 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[2].vtable.ToString.method )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(136, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_60(Patch, format, depthBits, 0LL);
			//     goto LABEL_17;
			//   }
			// LABEL_7:
			//   switch ( format )
			//   {
			//     case GraphicsFormat__Enum_D16_UNorm:
			//       if ( UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D16_UNorm, FormatUsage__Enum_Render, 0LL) )
			//       {
			//         *depthBits = DepthBits__Enum_Depth16;
			//         return 90;
			//       }
			//       goto LABEL_36;
			//     case GraphicsFormat__Enum_D24_UNorm:
			//       if ( UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D24_UNorm, FormatUsage__Enum_Render, 0LL) )
			//         goto LABEL_33;
			//       if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D32_SFloat, FormatUsage__Enum_Render, 0LL) )
			//         goto LABEL_36;
			//       goto LABEL_30;
			//     case GraphicsFormat__Enum_D32_SFloat:
			//       if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D32_SFloat, FormatUsage__Enum_Render, 0LL) )
			//       {
			//         if ( !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_D24_UNorm, FormatUsage__Enum_Render, 0LL) )
			//           goto LABEL_36;
			// LABEL_33:
			//         *depthBits = DepthBits__Enum_Depth24;
			//         return 91;
			//       }
			// LABEL_30:
			//       *depthBits = DepthBits__Enum_Depth32;
			//       return 93;
			//   }
			//   if ( format != GraphicsFormat__Enum_D24_UNorm_S8_UInt )
			//   {
			//     if ( format == GraphicsFormat__Enum_D32_SFloat_S8_UInt )
			//     {
			//       v7 = (unsigned __int8 (__fastcall *)(__int64, __int64, MethodInfo *))qword_18D8F5158;
			//       if ( !qword_18D8F5158 )
			//       {
			//         v7 = (unsigned __int8 (__fastcall *)(__int64, __int64, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.SystemInfo::IsFormatSupported"
			//                                                                                "(UnityEngine.Experimental.Rendering.Graph"
			//                                                                                "icsFormat,UnityEngine.Experimental.Render"
			//                                                                                "ing.FormatUsage)");
			//         if ( !v7 )
			//         {
			//           v10 = sub_1802DBBE8(
			//                   "UnityEngine.SystemInfo::IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat,UnityEngin"
			//                   "e.Experimental.Rendering.FormatUsage)");
			//           sub_18000F750(v10, 0LL);
			//         }
			//         qword_18D8F5158 = (__int64)v7;
			//       }
			//       if ( v7(94LL, 4LL, method) )
			//         goto LABEL_14;
			//       if ( UnityEngine::SystemInfo::IsFormatSupported(
			//              GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//              FormatUsage__Enum_Render,
			//              0LL) )
			//       {
			//         goto LABEL_39;
			//       }
			//     }
			// LABEL_36:
			//     *depthBits = DepthBits__Enum_None;
			//     return 0;
			//   }
			//   if ( !UnityEngine::SystemInfo::IsFormatSupported(
			//           GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//           FormatUsage__Enum_Render,
			//           0LL) )
			//   {
			//     if ( UnityEngine::SystemInfo::IsFormatSupported(
			//            GraphicsFormat__Enum_D32_SFloat_S8_UInt,
			//            FormatUsage__Enum_Render,
			//            0LL) )
			//     {
			// LABEL_14:
			//       *depthBits = DepthBits__Enum_Depth32;
			//       return 94;
			//     }
			//     goto LABEL_36;
			//   }
			// LABEL_39:
			//   *depthBits = DepthBits__Enum_Depth24;
			//   return 92;
			// }
			// 
			return (GraphicsFormat)GraphicsFormat.None;
		}

		internal static TextureHandle GeneratePairedDepthTarget(HGRenderGraph renderGraph, HGCamera camera, TextureHandle colorTarget)
		{
			// // TextureHandle GeneratePairedDepthTarget(HGRenderGraph, HGCamera, TextureHandle)
			// TextureHandle *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         TextureHandle *colorTarget,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t msaaSamples_k__BackingField; // r13d
			//   TextureDesc *TextureDescRef; // rax
			//   int32_t width; // r14d
			//   int32_t height; // r15d
			//   int32_t v15; // eax
			//   bool clearDepth; // al
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   char *v20; // rax
			//   TextureHandle *v21; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v23; // xmm0
			//   TextureHandle *result; // rax
			//   MethodInfo *v25; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v26; // [rsp+30h] [rbp-D8h]
			//   TextureHandle v27; // [rsp+38h] [rbp-D0h] BYREF
			//   TextureHandle v28; // [rsp+48h] [rbp-C0h] BYREF
			//   TextureDesc v29; // [rsp+58h] [rbp-B0h] BYREF
			//   TextureDesc v30; // [rsp+B8h] [rbp-50h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+158h] [rbp+50h] BYREF
			// 
			//   if ( !byte_18D9196D9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&off_18D506858);
			//     sub_18003C530(&off_18D5068B0);
			//     byte_18D9196D9 = 1;
			//   }
			//   depthBits = DepthBits__Enum_None;
			//   v27.handle = 0LL;
			//   v27.fallBackResource.m_Value = 0;
			//   sub_1802F01E0(&v29, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2465, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2465, 0LL);
			//     if ( Patch )
			//     {
			//       v28 = *colorTarget;
			//       v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_901(
			//               &v27,
			//               Patch,
			//               (Object *)renderGraph,
			//               (Object *)camera,
			//               &v28,
			//               0LL);
			//       goto LABEL_17;
			//     }
			// LABEL_15:
			//     sub_180B536AC(v10, v9);
			//   }
			//   if ( !camera )
			//     goto LABEL_15;
			//   msaaSamples_k__BackingField = camera.fields._msaaSamples_k__BackingField;
			//   LOBYTE(v27.handle.m_Value) = 1;
			//   v27.handle._type_k__BackingField = 1;
			//   if ( !renderGraph )
			//     goto LABEL_15;
			//   TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, colorTarget, 0LL);
			//   width = TextureDescRef.width;
			//   height = TextureDescRef.height;
			//   if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Vulkan )
			//   {
			//     v28 = *colorTarget;
			//     if ( HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(renderGraph, &v28, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Display);
			//       if ( UnityEngine::Display::get_preTransform(0LL) == Display_PreTransform__Enum_PreTransformRotate90
			//         || (sub_180002C70(TypeInfo::UnityEngine::Display),
			//             UnityEngine::Display::get_preTransform(0LL) == Display_PreTransform__Enum_PreTransformRotate270) )
			//       {
			//         v15 = width;
			//         width = height;
			//         height = v15;
			//       }
			//     }
			//   }
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v29, width, height, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   v29.colorFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//                       GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//                       &depthBits,
			//                       0LL);
			//   v29.bindTextureMS = msaaSamples_k__BackingField != 1;
			//   v29.depthBufferBits = depthBits;
			//   v29.msaaSamples = camera.fields._msaaSamples_k__BackingField;
			//   clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(camera, 0LL);
			//   v29.filterMode = 0;
			//   v29.clearBuffer = clearDepth;
			//   v20 = "CameraDepthStencil";
			//   if ( msaaSamples_k__BackingField != 1 )
			//     v20 = "CameraDepthStencilMSAA";
			//   v29.wrapMode = 1;
			//   v29.name = (String *)v20;
			//   sub_1800054D0((HGRenderPathScene *)&v29.name, v17, v18, v19, v25, v26);
			//   *(ResourceHandle *)&v29.fastMemoryDesc.inFastMemory = v27.handle;
			//   v29.memoryless = 2;
			//   v29.fastMemoryDesc.residencyFraction = 1.0;
			//   v30 = v29;
			//   v21 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v28, renderGraph, &v30, 0LL);
			// LABEL_17:
			//   v23 = *v21;
			//   result = retstr;
			//   *retstr = v23;
			//   return result;
			// }
			// 
			return null;
		}

		internal static bool RenderWithAlpha(HGCamera hgCamera = null)
		{
			// // Boolean RenderWithAlpha(HGCamera)
			// bool HG::Rendering::Runtime::HGUtils::RenderWithAlpha(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool v6; // bl
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB30 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D8EDB30 = 1;
			//   }
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
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size > 890 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v3.static_fields;
			//     v8 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v8.max_length.size <= 0x37Au )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v8[24].vector[26] )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(890, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                  (ILFixDynamicMethodWrapper_27 *)Patch,
			//                  (Object *)hgCamera,
			//                  0LL);
			//     }
			// LABEL_15:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_9:
			//   v6 = hgCamera && HG::Rendering::Runtime::HGCamera::get_enableAlpha(hgCamera, 0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, wrapperArray);
			//   return v6;
			// }
			// 
			return default(bool);
		}

		internal static bool ProcessRTExtraction(RTExtractionType type, TextureHandle src, HGCamera camera, HGRenderGraph renderGraph)
		{
			// // Boolean ProcessRTExtraction(RTExtractionType, TextureHandle, HGCamera, HGRenderGraph)
			// // Hidden C++ exception states: #wind=2
			// bool HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//         RTExtractionType__Enum type,
			//         TextureHandle *src,
			//         HGCamera *camera,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   Object *v5; // rsi
			//   Object *v6; // r15
			//   TextureHandle *v7; // r13
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v13; // xmm0
			//   HashSet_1_UnityEngine_Rendering_RTHandle_ *Item1; // r14
			//   _BYTE *v15; // rdx
			//   Il2CppException *v16; // rcx
			//   Object *current; // rdi
			//   TextureHandle v18; // xmm6
			//   __int64 v19; // rax
			//   __int64 v20; // rdx
			//   HashSet_1_UnityEngine_Rendering_RTHandle_ *Item2; // rdi
			//   Object *v22; // r12
			//   TextureHandle v23; // xmm6
			//   __int64 v24; // rax
			//   __int64 v25; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   _BYTE v30[32]; // [rsp+0h] [rbp-138h] BYREF
			//   Il2CppException *ex; // [rsp+50h] [rbp-E8h]
			//   HashSet_1_T_Enumerator_System_Object_ *v32; // [rsp+58h] [rbp-E0h]
			//   HashSet_1_T_Enumerator_System_Object_ v33; // [rsp+60h] [rbp-D8h] BYREF
			//   TextureHandle v34; // [rsp+80h] [rbp-B8h] BYREF
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v35; // [rsp+90h] [rbp-A8h]
			//   TextureHandle v36; // [rsp+A0h] [rbp-98h] BYREF
			//   TextureHandle v37; // [rsp+B0h] [rbp-88h] BYREF
			//   HashSet_1_T_Enumerator_System_Object_ v38; // [rsp+C0h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v39; // [rsp+D8h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v40; // [rsp+E0h] [rbp-58h] BYREF
			// 
			//   v5 = (Object *)renderGraph;
			//   v6 = (Object *)camera;
			//   v7 = src;
			//   if ( !byte_18D9196DA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::get_Count);
			//     byte_18D9196DA = 1;
			//   }
			//   memset(&v33, 0, sizeof(v33));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2970, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2970, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v29, v28);
			//     v34 = *v7;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1067(Patch, type, &v34, v6, v5, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v6 )
			//       sub_180B536AC(v10, v9);
			//     v13 = *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
			//              (ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *)&v34,
			//              (HGCamera *)v6,
			//              type,
			//              0LL);
			//     v35 = v13;
			//     Item1 = v13.Item1;
			//     if ( !v13.Item1 )
			//       sub_180B536AC(v12, v11);
			//     v33 = *(HashSet_1_T_Enumerator_System_Object_ *)sub_180314F0C(&v38, v13.Item1);
			//     ex = 0LL;
			//     v32 = &v33;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v33,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//       {
			//         current = v33._current;
			//         if ( !v5 )
			//           sub_1802DC2C8(v16, v15);
			//         v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v38,
			//                  (HGRenderGraph *)v5,
			//                  (RTHandle *)v33._current,
			//                  0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//         v36 = 0LL;
			//         v37 = v18;
			//         v34 = *v7;
			//         HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//           (HGRenderGraph *)v5,
			//           &v34,
			//           &v37,
			//           1,
			//           -1,
			//           0,
			//           (Rect *)&v36,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//         v19 = sub_188672978();
			//         if ( !v19 )
			//           sub_1802DC2C8(0LL, v20);
			//         (*(void (__fastcall **)(_QWORD, Object *, Object *, _QWORD))(v19 + 24))(
			//           *(_QWORD *)(v19 + 64),
			//           v6,
			//           current,
			//           *(_QWORD *)(v19 + 40));
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v39 )
			//     {
			//       v15 = v30;
			//       ex = v39.ex;
			//       v16 = ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v5 = (Object *)renderGraph;
			//       v6 = (Object *)camera;
			//       v7 = src;
			//       Item1 = v35.Item1;
			//     }
			//     Item2 = v35.Item2;
			//     if ( !v35.Item2 )
			//       goto LABEL_36;
			//     System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
			//       (HashSet_1_T_Enumerator_System_UInt64_ *)&v38,
			//       (HashSet_1_System_UInt64_ *)v35.Item2,
			//       MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
			//     v33 = v38;
			//     ex = 0LL;
			//     v32 = &v33;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v33,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//       {
			//         v22 = v33._current;
			//         if ( !v5 )
			//           sub_1802DC2C8(v16, v15);
			//         v23 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v38,
			//                  (HGRenderGraph *)v5,
			//                  (RTHandle *)v33._current,
			//                  0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//         v34 = 0LL;
			//         v37 = v23;
			//         v36 = *v7;
			//         HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//           (HGRenderGraph *)v5,
			//           &v36,
			//           &v37,
			//           1,
			//           -1,
			//           0,
			//           (Rect *)&v34,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//         v24 = sub_188672978();
			//         if ( !v24 )
			//           sub_1802DC2C8(0LL, v25);
			//         (*(void (__fastcall **)(_QWORD, Object *, Object *, _QWORD))(v24 + 24))(
			//           *(_QWORD *)(v24 + 64),
			//           v6,
			//           v22,
			//           *(_QWORD *)(v24 + 40));
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v40 )
			//     {
			//       v15 = v30;
			//       ex = v40.ex;
			//       v16 = ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       Item2 = v35.Item2;
			//       Item1 = v35.Item1;
			//     }
			//     if ( !Item1 )
			//       goto LABEL_36;
			//     if ( Item1.fields._count > 0 )
			//       return 1;
			//     if ( !Item2 )
			// LABEL_36:
			//       sub_1802DC2C8(v16, v15);
			//     return Item2.fields._count > 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal static bool ProcessWaterMarkRTs(HGCamera camera, HGCamera uiCamera, Shader blitPS, IntPtr cullingResults, HGRenderGraph renderGraph, ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Boolean ProcessWaterMarkRTs(HGCamera, HGCamera, Shader, IntPtr, HGRenderGraph, HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=3
			// bool HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
			//         HGCamera *camera,
			//         HGCamera *uiCamera,
			//         Shader *blitPS,
			//         void *cullingResults,
			//         HGRenderGraph *renderGraph,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGCamera *v9; // r15
			//   HGCamera *v10; // r13
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *WaterMarkRTs; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *v16; // rsi
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   RTHandle *end; // xmm6_8
			//   TextureHandle v20; // xmm8
			//   TextureHandle v21; // xmm6
			//   int32_t cullingLayerMask; // ebx
			//   Object_1 *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *UISprite; // rdx
			//   HGRenderGraph *v25; // r14
			//   HGRenderGraphContext *m_RenderGraphContext; // r12
			//   uint32_t RendererList; // eax
			//   uint32_t v28; // r12d
			//   _BYTE *m_CachedPtr; // rax
			//   HGRenderGraphContext *v30; // r12
			//   __int64 v31; // rdx
			//   RTHandle *v32; // r12
			//   float v33; // xmm6_4
			//   RenderTexture *v34; // rcx
			//   RenderTexture *v35; // rbx
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   int v40; // esi
			//   TextureHandle v41; // xmm7
			//   int v42; // r12d
			//   TextureHandle v43; // xmm6
			//   ProfilingSampler *v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   bool clearDepth; // r12
			//   unsigned int v48; // esi
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v53; // rdx
			//   __int64 v54; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-288h]
			//   uint32_t viewHandle; // [rsp+60h] [rbp-248h]
			//   uint32_t viewHandlea; // [rsp+60h] [rbp-248h]
			//   signed int viewHandleb; // [rsp+60h] [rbp-248h]
			//   uint32_t viewHandlec; // [rsp+60h] [rbp-248h]
			//   int v60; // [rsp+64h] [rbp-244h]
			//   uint32_t v61; // [rsp+68h] [rbp-240h]
			//   uint32_t v62; // [rsp+6Ch] [rbp-23Ch]
			//   Object *v63; // [rsp+70h] [rbp-238h] BYREF
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *v64; // [rsp+78h] [rbp-230h]
			//   Il2CppException *ex; // [rsp+80h] [rbp-228h] BYREF
			//   void *v66; // [rsp+88h] [rbp-220h]
			//   uint32_t key; // [rsp+90h] [rbp-218h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+94h] [rbp-214h]
			//   Rect v69; // [rsp+A0h] [rbp-208h] BYREF
			//   uint32_t v70; // [rsp+B0h] [rbp-1F8h]
			//   MonitorData *v71; // [rsp+B8h] [rbp-1F0h]
			//   Rect v72; // [rsp+C0h] [rbp-1E8h] BYREF
			//   Rect v73; // [rsp+D0h] [rbp-1D8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v74; // [rsp+E0h] [rbp-1C8h] BYREF
			//   HGRenderGraphBuilder v75; // [rsp+118h] [rbp-190h] BYREF
			//   HGRenderPathBase_HGRenderPathParams *v76; // [rsp+138h] [rbp-170h]
			//   TextureHandle v77; // [rsp+140h] [rbp-168h] BYREF
			//   HGRenderGraphBuilder v78; // [rsp+150h] [rbp-158h] BYREF
			//   FacLineDrawer_LineData value; // [rsp+170h] [rbp-138h] BYREF
			//   TextureHandle v80; // [rsp+190h] [rbp-118h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ v81; // [rsp+1A0h] [rbp-108h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+1D8h] [rbp-D0h] BYREF
			//   Il2CppExceptionWrapper *v83; // [rsp+1E0h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v84; // [rsp+1E8h] [rbp-C0h] BYREF
			//   TextureHandle v85; // [rsp+1F0h] [rbp-B8h] BYREF
			//   __int64 v86; // [rsp+200h] [rbp-A8h]
			//   TextureHandle v87; // [rsp+208h] [rbp-A0h] BYREF
			//   TextureHandle v88; // [rsp+218h] [rbp-90h] BYREF
			//   TextureHandle v89; // [rsp+228h] [rbp-80h] BYREF
			//   TextureHandle v90; // [rsp+238h] [rbp-70h] BYREF
			// 
			//   v9 = uiCamera;
			//   v10 = camera;
			//   v76 = renderPathParams;
			//   if ( !byte_18D9196DB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Value);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D5110B8);
			//     byte_18D9196DB = 1;
			//   }
			//   memset(&v74, 0, sizeof(v74));
			//   key = 0;
			//   memset(&value, 0, sizeof(value));
			//   v71 = 0LL;
			//   memset(&v75, 0, sizeof(v75));
			//   v63 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2968, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2968, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v54, v53);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1066(
			//              Patch,
			//              (Object *)v10,
			//              (Object *)v9,
			//              (Object *)blitPS,
			//              cullingResults,
			//              (Object *)renderGraph,
			//              renderPathParams,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !v10 )
			//       sub_180B536AC(v12, v11);
			//     WaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetWaterMarkRTs(v10, 0LL);
			//     v16 = (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)WaterMarkRTs;
			//     v64 = WaterMarkRTs;
			//     if ( !WaterMarkRTs )
			//       sub_180B536AC(v15, v14);
			//     if ( WaterMarkRTs.fields._count != WaterMarkRTs.fields._freeCount )
			//     {
			//       if ( v9 )
			//         goto LABEL_14;
			//       v74 = *(Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)sub_180830350(&v81, WaterMarkRTs);
			//       ex = 0LL;
			//       v66 = &v74;
			//       try
			//       {
			//         while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
			//                   &v74,
			//                   MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//         {
			//           *(_OWORD *)&v81._dictionary = *(_OWORD *)&v74._current.key;
			//           end = (RTHandle *)v74._current.value.end;
			//           v86 = *(_OWORD *)&_mm_unpackhi_pd(*(__m128d *)&v74._current.value.end, *(__m128d *)&v74._current.value.end);
			//           if ( !renderGraph )
			//             sub_1802DC2C8(v18, v17);
			//           v20 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                    &v80,
			//                    renderGraph,
			//                    (RTHandle *)v74._current.value.start,
			//                    0LL);
			//           v21 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                    (TextureHandle *)&v78,
			//                    renderGraph,
			//                    end,
			//                    0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           v73 = 0LL;
			//           v72 = (Rect)v21;
			//           v69 = (Rect)v20;
			//           HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//             renderGraph,
			//             (TextureHandle *)&v69,
			//             (TextureHandle *)&v72,
			//             1,
			//             -1,
			//             0,
			//             &v73,
			//             0,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v82 )
			//       {
			//         ex = v82.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v9 = uiCamera;
			//         v10 = camera;
			//         v16 = (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)v64;
			// LABEL_14:
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         cullingLayerMask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_2D_LAYER.m_Mask;
			//         UnityEngine::SystemInfo::IsFormatSupported(
			//           GraphicsFormat__Enum_D32_SFloat_S8_UInt,
			//           FormatUsage__Enum_Render,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//         UISprite = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.UISprite;
			//         if ( !UISprite )
			//           goto LABEL_64;
			//         if ( UISprite.fields.m_defaultValue )
			//         {
			//           if ( !v9 )
			//             goto LABEL_64;
			//           viewHandle = v9.fields.cullingViewHandle;
			//           v25 = renderGraph;
			//           if ( !renderGraph )
			//             goto LABEL_64;
			//           m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//           if ( !m_RenderGraphContext )
			//             goto LABEL_64;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(globalKeywords) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            viewHandle,
			//                            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//                            HGRenderFlags__Enum_Transparent,
			//                            HGShaderLightMode__Enum_WaterMarkUI,
			//                            globalKeywords,
			//                            m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                            0,
			//                            0,
			//                            cullingLayerMask,
			//                            0,
			//                            0,
			//                            0LL);
			//           v28 = -1;
			//           static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//         }
			//         else
			//         {
			//           v28 = -1;
			//           RendererList = -1;
			//           v25 = renderGraph;
			//         }
			//         v61 = RendererList;
			//         v60 = -1;
			//         v70 = RendererList;
			//         sub_180002C70(static_fields);
			//         static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         m_CachedPtr = static_fields[10].fields.m_CachedPtr;
			//         if ( !m_CachedPtr )
			//           goto LABEL_64;
			//         if ( m_CachedPtr[16] )
			//         {
			//           if ( !v9 )
			//             goto LABEL_64;
			//           static_fields = (Object_1 *)v9.fields.camera;
			//           if ( !static_fields )
			//             goto LABEL_64;
			//           viewHandlea = UnityEngine::Object::GetInstanceID(static_fields, 0LL);
			//           if ( !v25 )
			//             goto LABEL_64;
			//           v30 = v25.fields.m_RenderGraphContext;
			//           if ( !v30 )
			//             goto LABEL_64;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v28 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                   cullingLayerMask,
			//                   0,
			//                   0,
			//                   0x1000000u,
			//                   0x8000,
			//                   0x7FFF,
			//                   viewHandlea,
			//                   v30.fields.renderContext.m_Ptr,
			//                   0,
			//                   3.4028235e38,
			//                   0LL);
			//           v60 = v28;
			//         }
			//         v62 = v28;
			//         if ( v16 )
			//         {
			//           System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
			//             &v81,
			//             v16,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//           v74 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_)v81;
			//           *(_QWORD *)&v73.m_XMin = 0LL;
			//           *(_QWORD *)&v73.m_Width = &v74;
			//           try
			//           {
			//             while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
			//                       &v74,
			//                       MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//             {
			//               *(_OWORD *)&v81._dictionary = *(_OWORD *)&v74._current.key;
			//               *(_OWORD *)&v81._current.key._options = *(_OWORD *)&v74._current.value.end;
			//               System::Collections::Generic::KeyValuePair<unsigned int,Beyond::UI::FacLineDrawer::LineData>::Deconstruct(
			//                 (KeyValuePair_2_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)&v81,
			//                 &key,
			//                 &value,
			//                 MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
			//               *(_QWORD *)&v69.m_XMin = value.start;
			//               v32 = (RTHandle *)value.end;
			//               v33 = *(float *)&value.link;
			//               if ( value.start )
			//                 v34 = (RenderTexture *)value.start.fields._._._._.m_CachedPtr;
			//               else
			//                 v34 = 0LL;
			//               if ( value.end )
			//                 v35 = (RenderTexture *)value.end.fields._._._._.m_CachedPtr;
			//               else
			//                 v35 = 0LL;
			//               if ( !v34 )
			//                 sub_1802DC2C8(0LL, v31);
			//               UnityEngine::RenderTexture::Create(v34, 0LL);
			//               if ( !v35 )
			//                 sub_1802DC2C8(v37, v36);
			//               UnityEngine::RenderTexture::Create(v35, 0LL);
			//               viewHandleb = sub_18003ED00(5LL);
			//               v40 = sub_18003ED00(7LL);
			//               if ( !v25 )
			//                 sub_1802DC2C8(v39, v38);
			//               v41 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v87, v25, v32, 0LL);
			//               v80 = v41;
			//               LODWORD(v71) = viewHandleb;
			//               v42 = (int)(float)((float)v40 / v33);
			//               HIDWORD(v71) = v42;
			//               v43 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                        &v88,
			//                        v25,
			//                        *(RTHandle **)&v69.m_XMin,
			//                        0LL);
			//               v72.m_XMin = 0.0;
			//               v72.m_YMin = (float)(v40 - v42);
			//               v72.m_Width = (float)viewHandleb;
			//               v72.m_Height = (float)v42;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//               v69 = v72;
			//               v77 = v41;
			//               *(TextureHandle *)&v78.m_RenderPass = v43;
			//               HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//                 v25,
			//                 (TextureHandle *)&v78,
			//                 &v77,
			//                 1,
			//                 -1,
			//                 0,
			//                 &v69,
			//                 0,
			//                 0LL);
			//               v44 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                       (Int32Enum__Enum)0xCBu,
			//                       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//               HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//                 &v78,
			//                 v25,
			//                 (String *)"Water Mark",
			//                 &v63,
			//                 v44,
			//                 1,
			//                 ProfilingHGPass__Enum_None,
			//                 MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//               v75 = v78;
			//               ex = 0LL;
			//               v66 = &v75;
			//               try
			//               {
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v75, 0, 0LL);
			//                 if ( !v10 )
			//                   sub_1802DC2C8(v46, v45);
			//                 clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(v10, 0LL);
			//                 LODWORD(v69.m_XMin) = v10.fields._msaaSamples_k__BackingField;
			//                 depthBits = v76.perFrameSetup.depthBits;
			//                 viewHandlec = v76.perFrameSetup.depthGraphicsFormat;
			//                 v48 = sub_18003ED00(5LL);
			//                 v64 = (Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *)__PAIR64__(sub_18003ED00(7LL), v48);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//                 v77 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
			//                          &v89,
			//                          v25,
			//                          clearDepth,
			//                          LODWORD(v69.m_XMin),
			//                          depthBits,
			//                          (GraphicsFormat__Enum)viewHandlec,
			//                          (Vector2Int)v64,
			//                          0LL);
			//                 *(_OWORD *)&v78.m_RenderPass = 0LL;
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//                   &v90,
			//                   &v75,
			//                   &v80,
			//                   0,
			//                   RenderBufferLoadAction__Enum_Load,
			//                   RenderBufferStoreAction__Enum_Store,
			//                   (Color *)&v78,
			//                   0,
			//                   0LL);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//                   &v85,
			//                   &v75,
			//                   &v77,
			//                   DepthAccess__Enum_Write,
			//                   RenderBufferLoadAction__Enum_Clear,
			//                   RenderBufferStoreAction__Enum_DontCare,
			//                   1.0,
			//                   0,
			//                   0,
			//                   0LL);
			//                 if ( !v63 )
			//                   sub_1802DC2C8(v50, v49);
			//                 LODWORD(v63[1].klass) = v61;
			//                 if ( !v63 )
			//                   sub_1802DC2C8(v61, v49);
			//                 HIDWORD(v63[1].klass) = v60;
			//                 if ( !v63 )
			//                   sub_1802DC2C8(0LL, v49);
			//                 v63[1].monitor = v71;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//                   &v75,
			//                   (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_WaterMarkRenderFunc,
			//                   (Object *)v9,
			//                   0,
			//                   MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//               }
			//               catch ( Il2CppExceptionWrapper *v83 )
			//               {
			//                 ex = v83.ex;
			//                 sub_180222690(&ex);
			//                 v25 = renderGraph;
			//                 v9 = uiCamera;
			//                 v10 = camera;
			//                 v61 = v70;
			//                 v60 = v62;
			//                 continue;
			//               }
			//               sub_180222690(&ex);
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v84 )
			//           {
			//             *(Il2CppExceptionWrapper *)&v73.m_XMin = (Il2CppExceptionWrapper)v84.ex;
			//             if ( *(_QWORD *)&v73.m_XMin )
			//               sub_18000F780(*(_QWORD *)&v73.m_XMin);
			//           }
			//           return 1;
			//         }
			// LABEL_64:
			//         sub_1802DC2C8(static_fields, UISprite);
			//       }
			//       return 1;
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal static bool ProcessInplaceWaterMarkRTs(HGCamera camera, HGCamera uiCamera, Shader blitPS, IntPtr cullingResults, HGRenderGraph renderGraph, ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Boolean ProcessInplaceWaterMarkRTs(HGCamera, HGCamera, Shader, IntPtr, HGRenderGraph, HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=2
			// bool HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
			//         HGCamera *camera,
			//         HGCamera *uiCamera,
			//         Shader *blitPS,
			//         void *cullingResults,
			//         HGRenderGraph *renderGraph,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGCamera *v9; // r13
			//   HGCamera *v10; // r15
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v16; // r12
			//   int32_t cullingLayerMask; // ebx
			//   __int64 v18; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *UISprite; // rsi
			//   bool v21; // zf
			//   HGRenderGraph *v22; // rsi
			//   uint32_t cullingViewHandle; // r13d
			//   HGRenderGraphContext *m_RenderGraphContext; // r14
			//   uint32_t RendererList; // eax
			//   __int64 v26; // rdx
			//   HGGraphicsFeatureManager__StaticFields *v27; // rcx
			//   HGGraphicsFeatureSwitch *v28; // r14
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   HGRenderGraphContext *v31; // r14
			//   uint32_t v32; // ebx
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   ObjectReflector_ReflectType_FieldInfo current; // xmm6
			//   String *name; // r14
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   ProfilingSampler *v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   unsigned int v42; // r14d
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   int32_t v45; // r12d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-1C8h]
			//   int32_t cameraInstanceID; // [rsp+60h] [rbp-188h]
			//   int32_t cameraInstanceIDa; // [rsp+60h] [rbp-188h]
			//   int32_t cameraInstanceIDb; // [rsp+60h] [rbp-188h]
			//   unsigned int cameraInstanceIDc; // [rsp+60h] [rbp-188h]
			//   bool clearDepth; // [rsp+64h] [rbp-184h]
			//   uint32_t v56; // [rsp+68h] [rbp-180h]
			//   int v57; // [rsp+6Ch] [rbp-17Ch]
			//   GraphicsFormat__Enum depthGraphicsFormat; // [rsp+6Ch] [rbp-17Ch]
			//   Object *v59; // [rsp+70h] [rbp-178h] BYREF
			//   MSAASamples__Enum msaaSamples_k__BackingField; // [rsp+78h] [rbp-170h]
			//   uint32_t v61; // [rsp+7Ch] [rbp-16Ch]
			//   uint32_t v62; // [rsp+80h] [rbp-168h]
			//   MonitorData *v63; // [rsp+88h] [rbp-160h]
			//   Vector2Int v64; // [rsp+90h] [rbp-158h]
			//   _QWORD v65[2]; // [rsp+98h] [rbp-150h] BYREF
			//   HGRenderGraphBuilder v66; // [rsp+A8h] [rbp-140h] BYREF
			//   HGRenderPathBase_HGRenderPathParams *v67; // [rsp+C8h] [rbp-120h]
			//   Il2CppException *ex; // [rsp+D0h] [rbp-118h]
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *v69; // [rsp+D8h] [rbp-110h]
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ v70; // [rsp+E0h] [rbp-108h] BYREF
			//   HGRenderGraphBuilder v71; // [rsp+100h] [rbp-E8h] BYREF
			//   Il2CppExceptionWrapper *v72; // [rsp+120h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v73; // [rsp+128h] [rbp-C0h] BYREF
			//   Color v74; // [rsp+130h] [rbp-B8h] BYREF
			//   TextureHandle v75; // [rsp+140h] [rbp-A8h] BYREF
			//   TextureHandle v76; // [rsp+150h] [rbp-98h] BYREF
			//   TextureHandle v77; // [rsp+160h] [rbp-88h] BYREF
			//   TextureHandle v78; // [rsp+170h] [rbp-78h] BYREF
			//   TextureHandle v79[4]; // [rsp+180h] [rbp-68h] BYREF
			// 
			//   v9 = uiCamera;
			//   v10 = camera;
			//   v67 = renderPathParams;
			//   if ( !byte_18D9196DC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D5110B8);
			//     byte_18D9196DC = 1;
			//   }
			//   memset(&v70, 0, sizeof(v70));
			//   v63 = 0LL;
			//   memset(&v66, 0, sizeof(v66));
			//   v59 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2969, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2969, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v49, v48);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1066(
			//              Patch,
			//              (Object *)v10,
			//              (Object *)v9,
			//              (Object *)blitPS,
			//              cullingResults,
			//              (Object *)renderGraph,
			//              renderPathParams,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !v10 )
			//       sub_180B536AC(v12, v11);
			//     InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v10, 0LL);
			//     v16 = InplaceWaterMarkRTs;
			//     if ( !InplaceWaterMarkRTs )
			//       sub_180B536AC(v15, v14);
			//     if ( InplaceWaterMarkRTs.fields._size )
			//     {
			//       if ( v9 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         cullingLayerMask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_2D_LAYER.m_Mask;
			//         UnityEngine::SystemInfo::IsFormatSupported(
			//           GraphicsFormat__Enum_D32_SFloat_S8_UInt,
			//           FormatUsage__Enum_Render,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         UISprite = static_fields.UISprite;
			//         if ( !UISprite )
			//           sub_180B536AC(static_fields, v18);
			//         v21 = !UISprite.fields.m_defaultValue;
			//         v22 = renderGraph;
			//         if ( v21 )
			//         {
			//           RendererList = -1;
			//           cameraInstanceID = -1;
			//         }
			//         else
			//         {
			//           cullingViewHandle = v9.fields.cullingViewHandle;
			//           if ( !renderGraph )
			//             sub_180B536AC(static_fields, v18);
			//           m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//           if ( !m_RenderGraphContext )
			//             sub_180B536AC(static_fields, v18);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(globalKeywords) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            cullingViewHandle,
			//                            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//                            HGRenderFlags__Enum_Transparent,
			//                            HGShaderLightMode__Enum_WaterMarkUI,
			//                            globalKeywords,
			//                            m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                            0,
			//                            0,
			//                            cullingLayerMask,
			//                            0,
			//                            0,
			//                            0LL);
			//           cameraInstanceID = -1;
			//           v9 = uiCamera;
			//         }
			//         v56 = RendererList;
			//         v61 = RendererList;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         v27 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         v28 = v27.UISprite;
			//         if ( !v28 )
			//           sub_180B536AC(v27, v26);
			//         if ( v28.fields.m_defaultValue )
			//         {
			//           if ( !v9.fields.camera )
			//             sub_180B536AC(v27, v26);
			//           cameraInstanceIDa = UnityEngine::Object::GetInstanceID((Object_1 *)v9.fields.camera, 0LL);
			//           if ( !renderGraph )
			//             sub_180B536AC(v30, v29);
			//           v31 = renderGraph.fields.m_RenderGraphContext;
			//           if ( !v31 )
			//             sub_180B536AC(v30, v29);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v32 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                   cullingLayerMask,
			//                   0,
			//                   0,
			//                   0x1000000u,
			//                   0x8000,
			//                   0x7FFF,
			//                   cameraInstanceIDa,
			//                   v31.fields.renderContext.m_Ptr,
			//                   0,
			//                   3.4028235e38,
			//                   0LL);
			//           cameraInstanceID = v32;
			//         }
			//         else
			//         {
			//           v32 = -1;
			//         }
			//         v62 = v32;
			//         v70 = *(List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)sub_180830394(v79, v16);
			//         ex = 0LL;
			//         v69 = &v70;
			//         try
			//         {
			//           v45 = cameraInstanceID;
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::MoveNext(
			//                     &v70,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//           {
			//             current = v70._current;
			//             name = v70._current.name;
			//             if ( !v70._current.name || !*(_QWORD *)&v70._current.name.fields )
			//               sub_1802DC2C8(v34, v33);
			//             UnityEngine::RenderTexture::Create(*(RenderTexture **)&v70._current.name.fields, 0LL);
			//             v57 = sub_18003ED00(5LL);
			//             cameraInstanceIDb = sub_18003ED00(7LL);
			//             if ( !v22 )
			//               sub_1802DC2C8(v38, v37);
			//             v75 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v76, v22, (RTHandle *)name, 0LL);
			//             LODWORD(v63) = v57;
			//             HIDWORD(v63) = (int)(float)((float)cameraInstanceIDb
			//                                       / _mm_shuffle_ps((__m128)current, (__m128)current, 170).m128_f32[0]);
			//             v39 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                     (Int32Enum__Enum)0xCBu,
			//                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//             HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//               &v71,
			//               v22,
			//               (String *)"Water Mark",
			//               &v59,
			//               v39,
			//               1,
			//               ProfilingHGPass__Enum_None,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//             v66 = v71;
			//             v65[0] = 0LL;
			//             v65[1] = &v66;
			//             try
			//             {
			//               HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v66, 0, 0LL);
			//               if ( !v10 )
			//                 sub_1802DC2C8(v41, v40);
			//               clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth(v10, 0LL);
			//               msaaSamples_k__BackingField = v10.fields._msaaSamples_k__BackingField;
			//               cameraInstanceIDc = v67.perFrameSetup.depthBits;
			//               depthGraphicsFormat = v67.perFrameSetup.depthGraphicsFormat;
			//               v42 = sub_18003ED00(5LL);
			//               v64 = (Vector2Int)__PAIR64__(sub_18003ED00(7LL), v42);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//               *(TextureHandle *)&v71.m_RenderPass = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
			//                                                        &v77,
			//                                                        v22,
			//                                                        clearDepth,
			//                                                        msaaSamples_k__BackingField,
			//                                                        (DepthBits__Enum)cameraInstanceIDc,
			//                                                        depthGraphicsFormat,
			//                                                        v64,
			//                                                        0LL);
			//               v74 = 0LL;
			//               HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//                 &v78,
			//                 &v66,
			//                 &v75,
			//                 0,
			//                 RenderBufferLoadAction__Enum_Clear,
			//                 RenderBufferStoreAction__Enum_Store,
			//                 &v74,
			//                 0,
			//                 0LL);
			//               HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//                 v79,
			//                 &v66,
			//                 (TextureHandle *)&v71,
			//                 DepthAccess__Enum_Write,
			//                 RenderBufferLoadAction__Enum_Clear,
			//                 RenderBufferStoreAction__Enum_DontCare,
			//                 1.0,
			//                 0,
			//                 0,
			//                 0LL);
			//               if ( !v59 )
			//                 sub_1802DC2C8(v44, v43);
			//               LODWORD(v59[1].klass) = v56;
			//               if ( !v59 )
			//                 sub_1802DC2C8(v56, v43);
			//               HIDWORD(v59[1].klass) = v45;
			//               if ( !v59 )
			//                 sub_1802DC2C8(0LL, v43);
			//               v59[1].monitor = v63;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//                 &v66,
			//                 (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_WaterMarkRenderFunc,
			//                 (Object *)v9,
			//                 0,
			//                 MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGUtils::WaterMarkPassData>);
			//             }
			//             catch ( Il2CppExceptionWrapper *v72 )
			//             {
			//               v65[0] = v72.ex;
			//               sub_180222690(v65);
			//               v22 = renderGraph;
			//               v10 = camera;
			//               v56 = v61;
			//               v9 = uiCamera;
			//               v45 = v62;
			//               continue;
			//             }
			//             sub_180222690(v65);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v73 )
			//         {
			//           ex = v73.ex;
			//           if ( ex )
			//             sub_18000F780(ex);
			//         }
			//       }
			//       return 1;
			//     }
			//     else
			//     {
			//       return 0;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		internal static bool ExtractFinalResultForInplaceWaterMarkRTs(TextureHandle src, HGCamera camera, HGRenderGraph renderGraph)
		{
			// // Boolean ExtractFinalResultForInplaceWaterMarkRTs(TextureHandle, HGCamera, HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
			//         TextureHandle *src,
			//         HGCamera *camera,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   ObjectReflector_ReflectType_FieldInfo current; // xmm6
			//   String *name; // rsi
			//   int v16; // r12d
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   int v19; // edi
			//   TextureHandle *v20; // rax
			//   int v21; // ecx
			//   TextureHandle v22; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   Rect v27; // [rsp+50h] [rbp-B8h]
			//   Il2CppException *ex; // [rsp+60h] [rbp-A8h]
			//   TextureHandle v29; // [rsp+70h] [rbp-98h] BYREF
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ v30; // [rsp+80h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v31; // [rsp+A0h] [rbp-68h] BYREF
			//   Rect v32; // [rsp+B0h] [rbp-58h] BYREF
			//   TextureHandle v33; // [rsp+C0h] [rbp-48h] BYREF
			//   TextureHandle v34[3]; // [rsp+D0h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9196DD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     byte_18D9196DD = 1;
			//   }
			//   memset(&v30, 0, sizeof(v30));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2973, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2973, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v26, v25);
			//     v29 = *src;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1068(Patch, &v29, (Object *)camera, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     if ( !camera )
			//       sub_180B536AC(v8, v7);
			//     InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(camera, 0LL);
			//     if ( !InplaceWaterMarkRTs )
			//       sub_180B536AC(v11, v10);
			//     if ( InplaceWaterMarkRTs.fields._size )
			//     {
			//       v30 = *(List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)sub_180830394(v34, InplaceWaterMarkRTs);
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::MoveNext(
			//                   &v30,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//         {
			//           current = v30._current;
			//           name = v30._current.name;
			//           if ( !v30._current.name || !*(_QWORD *)&v30._current.name.fields )
			//             sub_1802DC2C8(v13, v12);
			//           UnityEngine::RenderTexture::Create(*(RenderTexture **)&v30._current.name.fields, 0LL);
			//           v16 = sub_18003ED00(5LL);
			//           v19 = sub_18003ED00(7LL);
			//           if ( !renderGraph )
			//             sub_1802DC2C8(v18, v17);
			//           v20 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(v34, renderGraph, (RTHandle *)name, 0LL);
			//           v21 = (int)(float)((float)v19 / _mm_shuffle_ps((__m128)current, (__m128)current, 170).m128_f32[0]);
			//           v22 = *v20;
			//           v27.m_XMin = 0.0;
			//           v27.m_YMin = (float)(v19 - v21);
			//           v27.m_Width = (float)v16;
			//           v27.m_Height = (float)v21;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           v32 = v27;
			//           v33 = v22;
			//           v29 = *src;
			//           HG::Rendering::Runtime::CopyTexturePass::BlitTexture(renderGraph, &v29, &v33, 1, -1, 0, &v32, 1, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v31 )
			//       {
			//         ex = v31.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//       }
			//       return 1;
			//     }
			//     else
			//     {
			//       return 0;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		internal static RTHandle GetOrCreateUICameraClearRT(Color clearColor)
		{
			// // RTHandle GetOrCreateUICameraClearRT(Color)
			// RTHandle *HG::Rendering::Runtime::HGUtils::GetOrCreateUICameraClearRT(Color *clearColor, MethodInfo *method)
			// {
			//   struct HGUtils__Class *v3; // rcx
			//   Object_1 *s_uiCameraTexture; // rbx
			//   struct HGUtils__Class *v5; // r8
			//   __int64 v6; // rdx
			//   Texture2D *v7; // rcx
			//   Texture2D *v8; // rax
			//   Texture2D *v9; // rbx
			//   HGRenderPathBase_HGRenderPathResources *static_fields; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   Texture2D *v13; // rbx
			//   RTHandle *v14; // rax
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *mipChaina; // [rsp+20h] [rbp-38h]
			//   MethodInfo *mipChain; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v22; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v23; // [rsp+28h] [rbp-30h]
			//   Color v24; // [rsp+30h] [rbp-28h] BYREF
			//   Color s_cachedUiCameraClearColor; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196DE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     byte_18D9196DE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3067, 0LL) )
			//   {
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//     clearColor.a = 1.0;
			//     sub_180002C70(v3);
			//     s_uiCameraTexture = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(s_uiCameraTexture, 0LL, 0LL) )
			//     {
			//       v8 = (Texture2D *)sub_180004920(TypeInfo::UnityEngine::Texture2D);
			//       v9 = v8;
			//       if ( v8 )
			//       {
			//         UnityEngine::Texture2D::Texture2D(v8, 1, 1, TextureFormat__Enum_RGBA32, 0, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         static_fields = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//         static_fields[18].settingParameters = (HGSettingParameters *)v9;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture,
			//           static_fields,
			//           v11,
			//           v12,
			//           mipChaina,
			//           v22);
			//         v7 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//         if ( v7 )
			//         {
			//           s_cachedUiCameraClearColor = *clearColor;
			//           UnityEngine::Texture2D::SetPixel(v7, 0, 0, &s_cachedUiCameraClearColor, 0LL);
			//           v7 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//           if ( v7 )
			//           {
			//             UnityEngine::Texture2D::Apply(v7, 0LL);
			//             TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_cachedUiCameraClearColor = *clearColor;
			//             v13 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//             v14 = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)v13, 0LL);
			//             v15 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//             v15[19].defaultResources = (HGRenderPipelineRuntimeResources *)v14;
			//             sub_1800054D0(
			//               (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraRT,
			//               v15,
			//               v16,
			//               v17,
			//               mipChain,
			//               v23);
			//             goto LABEL_13;
			//           }
			//         }
			//       }
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v24 = *clearColor;
			//       s_cachedUiCameraClearColor = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_cachedUiCameraClearColor;
			//       if ( !(unsigned __int8)sub_182F6C030(&s_cachedUiCameraClearColor, &v24) )
			//       {
			// LABEL_14:
			//         sub_180002C70(v5);
			//         return TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraRT;
			//       }
			//       sub_180002C70(v5);
			//       v7 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//       if ( v7 )
			//       {
			//         s_cachedUiCameraClearColor = *clearColor;
			//         UnityEngine::Texture2D::SetPixel(v7, 0, 0, &s_cachedUiCameraClearColor, 0LL);
			//         v7 = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_uiCameraTexture;
			//         if ( v7 )
			//         {
			//           UnityEngine::Texture2D::Apply(v7, 0LL);
			//           TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.s_cachedUiCameraClearColor = *clearColor;
			// LABEL_13:
			//           v5 = TypeInfo::HG::Rendering::Runtime::HGUtils;
			//           goto LABEL_14;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3067, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   s_cachedUiCameraClearColor = *clearColor;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1073(Patch, &s_cachedUiCameraClearColor, 0LL);
			// }
			// 
			return null;
		}

		public static int ComputeTextureStreamingBudget(HGSettingParameters settingParameters)
		{
			// // Int32 ComputeTextureStreamingBudget(HGSettingParameters)
			// int32_t HG::Rendering::Runtime::HGUtils::ComputeTextureStreamingBudget(
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int32_t GraphicsMemorySize; // eax
			//   SettingParameter_1_System_Int32_ *textureQuality16GB_k__BackingField; // rbx
			//   struct MethodInfo *v7; // rsi
			//   Il2CppClass *klass; // rax
			//   Int32Enum__Enum paramValue_k__BackingField; // ebx
			//   SettingParameter_1_System_Int32_ *textureStreamingMaxBudget_k__BackingField; // rdi
			//   struct MethodInfo *v11; // rsi
			//   Il2CppClass *v12; // rax
			//   Il2CppClass *v13; // rcx
			//   int32_t v14; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rax
			//   SettingParameter_1_System_Int32_ *textureQuality6GB_k__BackingField; // rcx
			//   __int64 v19; // rax
			// 
			//   if ( !byte_18D8EDB31 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDB31 = 1;
			//   }
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_34;
			//   if ( wrapperArray.max_length.size > 481 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_34;
			//     if ( LODWORD(v3._0.namespaze) <= 0x1E1 )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[10]._0.klass )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(481, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//                  (ILFixDynamicMethodWrapper_29 *)Patch,
			//                  (Object *)settingParameters,
			//                  0LL);
			//       goto LABEL_34;
			//     }
			//   }
			//   GraphicsMemorySize = UnityEngine::SystemInfo::GetGraphicsMemorySize(0LL);
			//   if ( (float)GraphicsMemorySize < 7311.3599 )
			//   {
			//     if ( settingParameters )
			//     {
			//       textureQuality6GB_k__BackingField = settingParameters.fields._textureQuality6GB_k__BackingField;
			//       goto LABEL_50;
			//     }
			//     goto LABEL_34;
			//   }
			//   if ( (float)GraphicsMemorySize < 9400.3203 )
			//   {
			//     if ( settingParameters )
			//     {
			//       textureQuality6GB_k__BackingField = settingParameters.fields._textureQuality8GB_k__BackingField;
			//       goto LABEL_50;
			//     }
			//     goto LABEL_34;
			//   }
			//   if ( (float)GraphicsMemorySize < 11489.279 )
			//   {
			//     if ( settingParameters )
			//     {
			//       textureQuality6GB_k__BackingField = settingParameters.fields._textureQuality10GB_k__BackingField;
			//       goto LABEL_50;
			//     }
			// LABEL_34:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_34;
			//   if ( (float)GraphicsMemorySize < 13578.24 )
			//   {
			//     textureQuality6GB_k__BackingField = settingParameters.fields._textureQuality12GB_k__BackingField;
			// LABEL_50:
			//     paramValue_k__BackingField = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                    (SettingParameter_1_System_Int32Enum_ *)textureQuality6GB_k__BackingField,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     goto LABEL_22;
			//   }
			//   textureQuality16GB_k__BackingField = settingParameters.fields._textureQuality16GB_k__BackingField;
			//   v7 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureQuality16GB_k__BackingField )
			//     goto LABEL_34;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v17 = sub_18010B520(v7.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v17 + 192) + 48LL))();
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.klass;
			//   if ( ((__int64)v3.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v3);
			//   paramValue_k__BackingField = textureQuality16GB_k__BackingField.fields._paramValue_k__BackingField;
			// LABEL_22:
			//   textureStreamingMaxBudget_k__BackingField = settingParameters.fields._textureStreamingMaxBudget_k__BackingField;
			//   v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureStreamingMaxBudget_k__BackingField )
			//     goto LABEL_34;
			//   v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v12.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v12.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v19 = sub_18010B520(v11.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v19 + 192) + 48LL))();
			//   }
			//   v13 = v11.klass;
			//   if ( ((__int64)v13.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v13);
			//   v14 = textureStreamingMaxBudget_k__BackingField.fields._paramValue_k__BackingField;
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, wrapperArray);
			//   if ( (int)paramValue_k__BackingField > v14 )
			//     return v14;
			//   return paramValue_k__BackingField;
			// }
			// 
			return 0;
		}

		public static int GetEstimatedVRAMUsage()
		{
			// // Int32 GetEstimatedVRAMUsage()
			// int32_t HG::Rendering::Runtime::HGUtils::GetEstimatedVRAMUsage(MethodInfo *method)
			// {
			//   HGRenderPipelineSettingHub *instance; // rax
			//   __int64 v2; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   HGRenderPipeline *currentPipeline; // rax
			//   HGSettingParameters *settingParameters_k__BackingField; // rdi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   int32_t v17; // ebp
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v20; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v25; // rax
			//   int32_t TAAUResolveResolutionWidth; // ebx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v29; // rax
			//   SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineDLSSFGMode_ *dlssGMode_k__BackingField; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3Int v35; // [rsp+30h] [rbp-D8h] BYREF
			//   Vector2Int finalRTSizea; // [rsp+118h] [rbp+10h]
			//   Vector2Int finalRTSize; // [rsp+118h] [rbp+10h]
			//   Vector2Int taauSize; // [rsp+120h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D9196DF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D9196DF = 1;
			//   }
			//   taauSize = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3215, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3215, 0LL);
			//     if ( !Patch )
			//       goto LABEL_32;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
			//     {
			//       instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//       if ( instance )
			//       {
			//         HG::Rendering::Runtime::HGRenderPipelineSettingHub::RefreshDirtySettings(instance, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//         currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//         if ( currentPipeline )
			//         {
			//           settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           HG::Rendering::Runtime::HGUtils::GetRenderingScale(settingParameters_k__BackingField, 0LL);
			//           v8 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v7, v6);
			//           if ( v8 )
			//           {
			//             HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(v8, 0LL);
			//             v11 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v10, v9);
			//             if ( v11 )
			//             {
			//               HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(v11, 0LL);
			//               v14 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v13, v12);
			//               if ( v14 )
			//               {
			//                 HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(v14, 0LL);
			//                 v17 = sub_1825C6750(v16, v15);
			//                 v20 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v19, v18);
			//                 if ( v20 )
			//                 {
			//                   HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(
			//                     v20,
			//                     0LL);
			//                   finalRTSizea.m_X = v17;
			//                   finalRTSizea.m_Y = sub_1825C6750(v22, v21);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//                   HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
			//                     &v35,
			//                     finalRTSizea,
			//                     &taauSize,
			//                     0LL);
			//                   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//                   if ( s_settingParameters )
			//                   {
			//                     HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       s_settingParameters.fields.enableVolumetricFog,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                     if ( settingParameters_k__BackingField )
			//                     {
			//                       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                              settingParameters_k__BackingField.fields._csmEnabled_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//                       {
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._csmShadowMapTileResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._csmShadowMapTileResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                       }
			//                       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                              settingParameters_k__BackingField.fields._asmEnabled_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//                       {
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._asmShadowMapTileResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._asmShadowMapTileResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                       }
			//                       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                              settingParameters_k__BackingField.fields._characterShadowEnabled_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//                       {
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._characterShadowMapResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._characterShadowMapResolution_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                       }
			//                       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                              settingParameters_k__BackingField.fields._punctualLightShadowEnabled_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//                       {
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._punctualLightTileMaxSize_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._punctualLightTileMaxSize_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._punctualLightEnvDynamicCasterCount_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                           (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._punctualLightMovableDynamicCasterCount_k__BackingField,
			//                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         sub_1826E82D0();
			//                       }
			//                       HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                         settingParameters_k__BackingField.fields._contactShadowEnableParam_k__BackingField,
			//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                       HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                         settingParameters_k__BackingField.fields._ssrEnable_k__BackingField,
			//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                       HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                         settingParameters_k__BackingField.fields._ssrV2Upsample_k__BackingField,
			//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                       if ( !UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSSupported(0LL)
			//                         || settingParameters_k__BackingField.fields._dlssEnable_k__BackingField )
			//                       {
			//                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//                         v25 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v24, v23);
			//                         if ( v25 )
			//                         {
			//                           TAAUResolveResolutionWidth = HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionWidth(
			//                                                          v25,
			//                                                          0LL);
			//                           v29 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v28, v27);
			//                           if ( v29 )
			//                           {
			//                             taauSize.m_X = TAAUResolveResolutionWidth;
			//                             taauSize.m_Y = HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::GetTAAUResolveResolutionHeight(
			//                                              v29,
			//                                              0LL);
			//                             finalRTSize.m_X = UnityEngine::Screen::get_width(0LL);
			//                             finalRTSize.m_Y = UnityEngine::Screen::get_height(0LL);
			//                             if ( !UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSGSupported(0LL) )
			//                             {
			// LABEL_29:
			//                               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                               HG::Rendering::Runtime::HGUtils::ComputeTextureStreamingBudget(
			//                                 settingParameters_k__BackingField,
			//                                 0LL);
			//                               return sub_1825C6750(v32, v31);
			//                             }
			//                             dlssGMode_k__BackingField = settingParameters_k__BackingField.fields._dlssGMode_k__BackingField;
			//                             if ( dlssGMode_k__BackingField )
			//                             {
			//                               if ( dlssGMode_k__BackingField.fields._paramValue_k__BackingField )
			//                                 UnityEngine::HyperGryphEngineCode::HGCPPDLSSUtil::CalcStreamlineDLSSGVRAMUsage(
			//                                   taauSize,
			//                                   finalRTSize,
			//                                   0LL);
			//                               goto LABEL_29;
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
			// LABEL_32:
			//       sub_180B536AC(s_settingParameters, v2);
			//     }
			//     return -1;
			//   }
			// }
			// 
			return 0;
		}

		public static int GetVRAMUsageWarningThreshold()
		{
			// // Int32 GetVRAMUsageWarningThreshold()
			// int32_t HG::Rendering::Runtime::HGUtils::GetVRAMUsageWarningThreshold(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   __int64 v2; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3216, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3216, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::SystemInfo::GetGraphicsMemorySize(0LL);
			//     return sub_1825C6750(v2, v1);
			//   }
			// }
			// 
			return 0;
		}

		internal const PerObjectData k_RendererConfigurationBakedLighting = PerObjectData.LightProbe | PerObjectData.ReflectionProbes | PerObjectData.LightProbeProxyVolume | PerObjectData.Lightmaps;

		internal const PerObjectData k_RendererConfigurationBakedLightingWithShadowMask = PerObjectData.LightProbe | PerObjectData.ReflectionProbes | PerObjectData.LightProbeProxyVolume | PerObjectData.Lightmaps | PerObjectData.OcclusionProbe | PerObjectData.OcclusionProbeProxyVolume | PerObjectData.ShadowMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static LayerMask UI_2D_LAYER;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static LayerMask UI_3D_LAYER;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Matrix4x4 s_preTransform90Matrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		private static Matrix4x4 s_preTransform270Matrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		private static Matrix4x4 s_preTransform180Matrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		private static RenderTargetIdentifier s_backBufferIdentifier;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		private static Texture3D m_ClearTexture3D;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		private static RTHandle m_ClearTexture3DRTH;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		private static Dictionary<GraphicsFormat, int> graphicsFormatSizeCache;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		private static GraphicsFormat[] m_RWTextureWithoutAlphaColorFormatList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		private static GraphicsFormat[] m_RWTextureWithAlphaColorFormatList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		private static GraphicsFormat m_RWTextureWithAlphaFormat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x11C")]
		private static GraphicsFormat m_RWTextureWithoutAlphaFormat;

		private const int MAX_RESOLUTION_HEIGHT_MOBILE = 1080;

		private const int MIN_RESOLUTION_HEIGHT_MOBILE = 432;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		private static readonly RenderFunc<HGUtils.WaterMarkPassData> s_WaterMarkRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		private static Texture2D s_uiCameraTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		private static RTHandle s_uiCameraRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		private static Color s_cachedUiCameraClearColor;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		internal struct PackedMipChainInfo
		{
			public void Allocate()
			{
			}

			public void ComputePackedMipChainInfo(Vector2Int viewportSize)
			{
				// // Void ComputePackedMipChainInfo(Vector2Int)
				// void HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::ComputePackedMipChainInfo(
				//         HGUtils_PackedMipChainInfo *this,
				//         Vector2Int viewportSize,
				//         MethodInfo *method)
				// {
				//   void *v5; // rcx
				//   Vector2Int__Array *v6; // rdx
				//   Vector2Int__Array *mipLevelSizes; // rax
				//   struct DynamicResolutionHandler__Class *v8; // rcx
				//   DynamicResolutionHandler *v9; // rax
				//   __int64 v10; // r8
				//   Vector2Int__Array *mipLevelOffsets; // rbx
				//   __int64 v12; // rax
				//   unsigned int v13; // ebx
				//   int hardwareTextureSize; // r15d
				//   int v15; // r13d
				//   __int64 v16; // rsi
				//   int v17; // eax
				//   int v18; // eax
				//   Vector2Int__Array *v19; // rax
				//   unsigned __int64 v20; // rbp
				//   __int64 v21; // rax
				//   int v22; // r14d
				//   unsigned __int64 v23; // rbp
				//   int32_t m_X; // esi
				//   int32_t m_Y; // esi
				//   float v26; // xmm0_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   struct DynamicResolutionHandler__Class *v28; // rcx
				//   DynamicResolutionHandler *v29; // rax
				//   Vector2Int v30; // [rsp+20h] [rbp-68h]
				//   Vector2Int v31; // [rsp+A8h] [rbp+20h]
				//   Vector2Int v32; // [rsp+A8h] [rbp+20h]
				// 
				//   if ( !byte_18D8EDB34 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
				//     sub_18003C530(&TypeInfo::System::Math);
				//     byte_18D8EDB34 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
				//       TypeInfo::IFix::ILFixDynamicMethodWrapper,
				//       viewportSize);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v6 = (Vector2Int__Array *)**((_QWORD **)v5 + 23);
				//   if ( !v6 )
				//     goto LABEL_48;
				//   if ( v6.max_length.size > 685 )
				//   {
				//     if ( !*((_DWORD *)v5 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v5, v6);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v6 = (Vector2Int__Array *)**((_QWORD **)v5 + 23);
				//     if ( !v6 )
				//       goto LABEL_48;
				//     if ( v6.max_length.size <= 0x2ADu )
				// LABEL_49:
				//       sub_180070270(v5, v6);
				//     if ( v6[19].vector[1] )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(685, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_259(Patch, this, viewportSize, 0LL);
				//         return;
				//       }
				//       goto LABEL_48;
				//     }
				//   }
				//   mipLevelSizes = this.mipLevelSizes;
				//   if ( !mipLevelSizes )
				//     goto LABEL_48;
				//   if ( !mipLevelSizes.max_length.size )
				//     goto LABEL_49;
				//   if ( viewportSize == *(_QWORD *)mipLevelSizes.vector )
				//     return;
				//   v8 = TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler;
				//   if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler, v6);
				//   v9 = (DynamicResolutionHandler *)sub_18256BBD0(v8, v6, method);
				//   if ( !v9 )
				//     goto LABEL_48;
				//   if ( UnityEngine::Rendering::DynamicResolutionHandler::HardwareDynamicResIsEnabled(v9, 0LL) )
				//   {
				//     v28 = TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler;
				//     if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler, v6);
				//     v29 = (DynamicResolutionHandler *)sub_18256BBD0(v28, v6, v10);
				//     if ( !v29 )
				//       goto LABEL_48;
				//     this.hardwareTextureSize = UnityEngine::Rendering::DynamicResolutionHandler::ApplyScalesOnSize(
				//                                   v29,
				//                                   viewportSize,
				//                                   0LL);
				//   }
				//   else
				//   {
				//     this.hardwareTextureSize = viewportSize;
				//   }
				//   v5 = this.mipLevelSizes;
				//   if ( !v5 )
				//     goto LABEL_48;
				//   if ( !*((_DWORD *)v5 + 6) )
				//     goto LABEL_49;
				//   *((_QWORD *)v5 + 4) = this.hardwareTextureSize;
				//   mipLevelOffsets = this.mipLevelOffsets;
				//   v12 = sub_182E7BD70(v5, v6, v10);
				//   if ( !mipLevelOffsets )
				// LABEL_48:
				//     sub_180B536AC(v5, v6);
				//   if ( !mipLevelOffsets.max_length.size )
				//     goto LABEL_49;
				//   mipLevelOffsets.vector[0] = (Vector2Int)v12;
				//   v13 = 0;
				//   hardwareTextureSize = (int)this.hardwareTextureSize;
				//   v15 = HIDWORD(*(_QWORD *)&this.hardwareTextureSize);
				//   do
				//   {
				//     v16 = (int)v13++;
				//     v5 = TypeInfo::System::Math;
				//     if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v6);
				//     v17 = (hardwareTextureSize + 1) >> 1;
				//     hardwareTextureSize = 1;
				//     if ( v17 > 1 )
				//       hardwareTextureSize = v17;
				//     v31.m_X = hardwareTextureSize;
				//     v18 = (v15 + 1) >> 1;
				//     v6 = this.mipLevelSizes;
				//     v15 = 1;
				//     if ( v18 > 1 )
				//       v15 = v18;
				//     v31.m_Y = v15;
				//     if ( !v6 )
				//       goto LABEL_48;
				//     if ( v13 >= v6.max_length.size )
				//       goto LABEL_49;
				//     v6.vector[v13] = v31;
				//     v5 = this.mipLevelOffsets;
				//     if ( !v5 )
				//       goto LABEL_48;
				//     if ( (unsigned int)v16 >= *((_DWORD *)v5 + 6) )
				//       goto LABEL_49;
				//     v19 = this.mipLevelSizes;
				//     v20 = *((_QWORD *)v5 + v16 + 4);
				//     if ( !v19 )
				//       goto LABEL_48;
				//     if ( (unsigned int)v16 >= v19.max_length.size )
				//       goto LABEL_49;
				//     v21 = sub_184CE95D4(*((_QWORD *)v5 + v16 + 4), *(_QWORD *)&v19.vector[v16]);
				//     if ( (v13 & 1) != 0 )
				//     {
				//       v22 = v20;
				//       v30.m_X = v20;
				//       v20 = v21;
				//     }
				//     else
				//     {
				//       v22 = v21;
				//       v30.m_X = v21;
				//     }
				//     v23 = HIDWORD(v20);
				//     v30.m_Y = v23;
				//     v6 = this.mipLevelOffsets;
				//     if ( !v6 )
				//       goto LABEL_48;
				//     if ( v13 >= v6.max_length.size )
				//       goto LABEL_49;
				//     v6.vector[v13] = v30;
				//     m_X = this.hardwareTextureSize.m_X;
				//     if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v6);
				//     if ( m_X < v22 + hardwareTextureSize )
				//       m_X = v22 + hardwareTextureSize;
				//     this.hardwareTextureSize.m_X = m_X;
				//     m_Y = this.hardwareTextureSize.m_Y;
				//     if ( m_Y < v15 + (int)v23 )
				//       m_Y = v15 + v23;
				//     this.hardwareTextureSize.m_Y = m_Y;
				//   }
				//   while ( hardwareTextureSize > 1 || v15 > 1 );
				//   v32.m_X = (int)sub_1801C2670();
				//   v26 = sub_1801C2670();
				//   this.m_OffsetBufferWillNeedUpdate = 1;
				//   v32.m_Y = (int)v26;
				//   this.textureSize = v32;
				//   this.mipLevelCount = v13 + 1;
				// }
				// 
			}

			public ComputeBuffer GetOffsetBufferData(ComputeBuffer mipLevelOffsetsBuffer)
			{
				// // ComputeBuffer GetOffsetBufferData(ComputeBuffer)
				// ComputeBuffer *HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::GetOffsetBufferData(
				//         HGUtils_PackedMipChainInfo *this,
				//         ComputeBuffer *mipLevelOffsetsBuffer,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3218, 0LL) )
				//   {
				//     if ( !this.m_OffsetBufferWillNeedUpdate )
				//       return mipLevelOffsetsBuffer;
				//     if ( mipLevelOffsetsBuffer )
				//     {
				//       UnityEngine::ComputeBuffer::SetData(mipLevelOffsetsBuffer, (Array *)this.mipLevelOffsets, 0LL);
				//       this.m_OffsetBufferWillNeedUpdate = 0;
				//       return mipLevelOffsetsBuffer;
				//     }
				// LABEL_7:
				//     sub_180B536AC(v6, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3218, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1150(Patch, this, (Object *)mipLevelOffsetsBuffer, 0LL);
				// }
				// 
				return null;
			}

			public Vector2Int textureSize;

			public Vector2Int hardwareTextureSize;

			public int mipLevelCount;

			public Vector2Int[] mipLevelSizes;

			public Vector2Int[] mipLevelOffsets;

			private bool m_OffsetBufferWillNeedUpdate;
		}

		private class WaterMarkPassData
		{
			public WaterMarkPassData()
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

			public uint ecsRendererList;

			public uint hgUiRendererList;

			public Vector2Int finalRTSize;
		}
	}
}
