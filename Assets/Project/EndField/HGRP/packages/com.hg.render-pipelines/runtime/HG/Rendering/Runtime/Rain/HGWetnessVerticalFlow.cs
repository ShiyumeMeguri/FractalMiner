using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	public class HGWetnessVerticalFlow : HGBaseWetnessFeature
	{
		public HGWetnessVerticalFlow()
		{
			// // HGWetnessVerticalFlow()
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::HGWetnessVerticalFlow(
			//         HGWetnessVerticalFlow *this,
			//         MethodInfo *method)
			// {
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v6; // rbx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v7; // rdx
			//   Bounds *v8; // r8
			//   Object__Array *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC2D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams);
			//     byte_18D8EDC2D = 1;
			//   }
			//   v3 = (HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams::WetnessVerticalFlowRenderParams(
			//     v3,
			//     0LL);
			//   this.fields.m_wetnessVerticalFlowRenderParams = v6;
			//   sub_1800054D0((BSP *)&this.fields.m_wetnessVerticalFlowRenderParams, v7, v8, v9, v10, v11);
			// }
			// 
		}

		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam, Single)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::UpdateData(
			//         HGWetnessVerticalFlow *this,
			//         RainCommonRenderingParam *rainCommonRenderingParam,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *verticalFlowTexture; // rdx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *m_wetnessVerticalFlowRenderParams; // rcx
			//   RainCommonPreSettingParam *commonPresettingParam; // rax
			//   RainCommonPreSettingParam *v11; // rax
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v12; // r9
			//   __m128i v13; // xmm0
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v14; // rax
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v15; // rax
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v18; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4788, 0LL) )
			//   {
			//     m_wetnessVerticalFlowRenderParams = this.fields.m_wetnessVerticalFlowRenderParams;
			//     if ( rainCommonRenderingParam )
			//     {
			//       commonPresettingParam = rainCommonRenderingParam.fields.commonPresettingParam;
			//       if ( commonPresettingParam )
			//       {
			//         verticalFlowTexture = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)commonPresettingParam.fields.verticalFlowTexture;
			//         if ( m_wetnessVerticalFlowRenderParams )
			//         {
			//           m_wetnessVerticalFlowRenderParams.fields.verticalFlowTexture = (Texture2D *)verticalFlowTexture;
			//           sub_1800054D0((BSP *)&m_wetnessVerticalFlowRenderParams.fields, verticalFlowTexture, v7, v8, v18, v19);
			//           v11 = rainCommonRenderingParam.fields.commonPresettingParam;
			//           v12 = this.fields.m_wetnessVerticalFlowRenderParams;
			//           if ( v11 )
			//           {
			//             v13 = _mm_loadu_si128((const __m128i *)&v11.fields.verticalFlowTexture_ST);
			//             if ( v12 )
			//             {
			//               v12.fields.verticalFlowTexture_ST = (Vector4)v13;
			//               v14 = this.fields.m_wetnessVerticalFlowRenderParams;
			//               if ( v14 )
			//               {
			//                 v14.fields.verticalFlowNormalStrength = rainCommonRenderingParam.fields.verticalFlowNormalStrength;
			//                 v15 = this.fields.m_wetnessVerticalFlowRenderParams;
			//                 if ( v15 )
			//                 {
			//                   v15.fields.verticalFlowSurfaceThreshold = rainCommonRenderingParam.fields.verticalFlowSurfaceThreshold;
			//                   v16 = this.fields.m_wetnessVerticalFlowRenderParams;
			//                   if ( v16 )
			//                   {
			//                     v16.fields.verticalFlowPorosityBias = rainCommonRenderingParam.fields.verticalFlowPorosityBias;
			//                     this.fields.m_verticalFlowUVOffset = (float)((float)(deltaTime
			//                                                                         * rainCommonRenderingParam.fields.verticalFlowSpeed)
			//                                                                 * 0.07)
			//                                                         + this.fields.m_verticalFlowUVOffset;
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_wetnessVerticalFlowRenderParams, verticalFlowTexture);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4788, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//     (ILFixDynamicMethodWrapper_9 *)Patch,
			//     (Object *)this,
			//     (Object *)rainCommonRenderingParam,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		internal override void SetData(RainWetnessGlobalProps globalProps)
		{
			// // Void SetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::SetData(
			//         HGWetnessVerticalFlow *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v6; // rcx
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *m_wetnessVerticalFlowRenderParams; // rax
			//   Vector4__Array *rainWetnessGlobalParams; // rsi
			//   float m_verticalFlowUVOffset; // xmm8_4
			//   float verticalFlowNormalStrength; // xmm7_4
			//   float verticalFlowSurfaceThreshold; // xmm6_4
			//   Vector4 *v12; // rax
			//   Vector4__Array *v13; // rdi
			//   Vector4 *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v16[2]; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919D47 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919D47 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4789, 0LL) )
			//   {
			//     m_wetnessVerticalFlowRenderParams = this.fields.m_wetnessVerticalFlowRenderParams;
			//     if ( m_wetnessVerticalFlowRenderParams )
			//     {
			//       if ( m_wetnessVerticalFlowRenderParams.fields.verticalFlowNormalStrength <= 0.0 )
			//       {
			//         sub_18004E2C0(7LL, this, globalProps);
			//         return;
			//       }
			//       if ( globalProps )
			//       {
			//         rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//         m_verticalFlowUVOffset = this.fields.m_verticalFlowUVOffset;
			//         verticalFlowNormalStrength = m_wetnessVerticalFlowRenderParams.fields.verticalFlowNormalStrength;
			//         verticalFlowSurfaceThreshold = m_wetnessVerticalFlowRenderParams.fields.verticalFlowSurfaceThreshold;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v12 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                 v16,
			//                 m_verticalFlowUVOffset,
			//                 verticalFlowNormalStrength,
			//                 verticalFlowSurfaceThreshold,
			//                 0LL);
			//         if ( rainWetnessGlobalParams )
			//         {
			//           v16[0] = *v12;
			//           sub_18004D910(rainWetnessGlobalParams, 1LL, v16);
			//           v6 = this.fields.m_wetnessVerticalFlowRenderParams;
			//           v13 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( v6 )
			//           {
			//             v14 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     v16,
			//                     v6.fields.verticalFlowTexture_ST.x,
			//                     v6.fields.verticalFlowTexture_ST.y,
			//                     v6.fields.verticalFlowPorosityBias,
			//                     0LL);
			//             if ( v13 )
			//             {
			//               v16[0] = *v14;
			//               sub_18004D910(v13, 2LL, v16);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4789, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)globalProps,
			//     0LL);
			// }
			// 
		}

		internal override void ResetData(RainWetnessGlobalProps globalProps)
		{
			// // Void ResetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::ResetData(
			//         HGWetnessVerticalFlow *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Vector4__Array *rainWetnessGlobalParams; // rdi
			//   float m_verticalFlowUVOffset; // xmm6_4
			//   Vector4 x_low; // xmm0
			//   HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *m_wetnessVerticalFlowRenderParams; // rax
			//   Vector4__Array *v11; // rbx
			//   float x; // xmm6_4
			//   float y; // xmm7_4
			//   __m128 v14; // xmm0
			//   __m128 v15; // xmm0
			//   Vector4 v16; // xmm0
			//   ILFixDynamicMethodWrapper_2 *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v19; // rax
			//   Vector4 v20; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDC2C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDC2C = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, globalProps);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_32;
			//   if ( wrapperArray.max_length.size <= 4790 )
			//     goto LABEL_57;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_32;
			//   if ( wrapperArray.max_length.size <= 0x12B6u )
			//     goto LABEL_33;
			//   if ( !wrapperArray[133].vector[2] )
			//   {
			// LABEL_57:
			//     if ( globalProps )
			//     {
			//       rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//       m_verticalFlowUVOffset = this.fields.m_verticalFlowUVOffset;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//         v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         byte_18D8EDC37 = 1;
			//       }
			//       if ( !v5._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v5, wrapperArray);
			//         v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       wrapperArray = v5.static_fields.wrapperArray;
			//       if ( wrapperArray )
			//       {
			//         if ( wrapperArray.max_length.size <= 869 )
			//           goto LABEL_18;
			//         if ( !v5._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v5, wrapperArray);
			//           v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//         if ( !v5 )
			//           goto LABEL_32;
			//         if ( LODWORD(v5._0.namespaze) <= 0x365 )
			//           goto LABEL_33;
			//         if ( *(_QWORD *)&v5[18]._1.initializationExceptionGCHandle )
			//         {
			//           Patch = IFix::WrappersManagerImpl::GetPatch(869, 0LL);
			//           if ( !Patch )
			//             goto LABEL_32;
			//           x_low = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_336(&v20, Patch, m_verticalFlowUVOffset, 0.0, 0.0, 0LL);
			//         }
			//         else
			//         {
			// LABEL_18:
			//           x_low = (Vector4)LODWORD(v20.x);
			//           x_low.x = m_verticalFlowUVOffset;
			//           v20 = x_low;
			//         }
			//         if ( rainWetnessGlobalParams )
			//         {
			//           if ( rainWetnessGlobalParams.max_length.size <= 1u )
			//             goto LABEL_33;
			//           rainWetnessGlobalParams.vector[1] = x_low;
			//           m_wetnessVerticalFlowRenderParams = this.fields.m_wetnessVerticalFlowRenderParams;
			//           v11 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( m_wetnessVerticalFlowRenderParams )
			//           {
			//             x = m_wetnessVerticalFlowRenderParams.fields.verticalFlowTexture_ST.x;
			//             y = m_wetnessVerticalFlowRenderParams.fields.verticalFlowTexture_ST.y;
			//             if ( !byte_18D8EDC37 )
			//             {
			//               sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//               byte_18D8EDC37 = 1;
			//             }
			//             v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//               v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             }
			//             wrapperArray = v5.static_fields.wrapperArray;
			//             if ( wrapperArray )
			//             {
			//               if ( wrapperArray.max_length.size <= 869 )
			//                 goto LABEL_28;
			//               if ( !v5._1.cctor_finished_or_no_cctor )
			//               {
			//                 il2cpp_runtime_class_init_0(v5, wrapperArray);
			//                 v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//               }
			//               wrapperArray = v5.static_fields.wrapperArray;
			//               if ( !wrapperArray )
			//                 goto LABEL_32;
			//               if ( wrapperArray.max_length.size <= 0x365u )
			//                 goto LABEL_33;
			//               if ( wrapperArray[24].vector[5] )
			//               {
			//                 v19 = IFix::WrappersManagerImpl::GetPatch(869, 0LL);
			//                 if ( !v19 )
			//                   goto LABEL_32;
			//                 v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_336(&v20, v19, x, y, 0.0, 0LL);
			//               }
			//               else
			//               {
			// LABEL_28:
			//                 *(_QWORD *)&v20.z = 0LL;
			//                 v14 = (__m128)*(unsigned __int64 *)&v20.x;
			//                 v14.m128_f32[0] = x;
			//                 v15 = _mm_shuffle_ps(v14, v14, 225);
			//                 v15.m128_f32[0] = y;
			//                 v16 = (Vector4)_mm_shuffle_ps(v15, v15, 225);
			//               }
			//               if ( v11 )
			//               {
			//                 if ( v11.max_length.size > 2u )
			//                 {
			//                   v11.vector[2] = v16;
			//                   return;
			//                 }
			// LABEL_33:
			//                 sub_180070270(v5, wrapperArray);
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_32:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			//   v17 = IFix::WrappersManagerImpl::GetPatch(4790, 0LL);
			//   if ( !v17 )
			//     goto LABEL_32;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)v17,
			//     (Object *)this,
			//     (Object *)globalProps,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_UpdateData(RainCommonRenderingParam P0, float P1)
		{
			// // Void <>iFixBaseProxy_UpdateData(RainCommonRenderingParam, Single)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_UpdateData(
			//         HGWetnessVerticalFlow *this,
			//         RainCommonRenderingParam *P0,
			//         float P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::UpdateData((HGBaseWetnessFeature *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_SetData(RainWetnessGlobalProps P0)
		{
			// // Void <>iFixBaseProxy_SetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_SetData(
			//         HGWetnessVerticalFlow *this,
			//         RainWetnessGlobalProps *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::SetData((HGBaseWetnessFeature *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetData(RainWetnessGlobalProps P0)
		{
			// // Void <>iFixBaseProxy_ResetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_ResetData(
			//         HGWetnessVerticalFlow *this,
			//         RainWetnessGlobalProps *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::ResetData((HGBaseWetnessFeature *)this, P0, 0LL);
			// }
			// 
		}

		private float m_verticalFlowUVOffset;

		private HGWetnessVerticalFlow.WetnessVerticalFlowRenderParams m_wetnessVerticalFlowRenderParams;

		private class WetnessVerticalFlowRenderParams
		{
			public WetnessVerticalFlowRenderParams()
			{
				// // HGWetnessVerticalFlow+WetnessVerticalFlowRenderParams()
				// void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams::WetnessVerticalFlowRenderParams(
				//         HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *this,
				//         MethodInfo *method)
				// {
				//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v3; // rdx
				//   Bounds *v4; // r8
				//   Object__Array *v5; // r9
				//   TileBase *v6; // rdx
				//   Vector3Int *v7; // r8
				//   ITilemap *v8; // r9
				//   TileAnimationData v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   this.fields.verticalFlowTexture = UnityEngine::Texture2D::get_normalTexture(0LL);
				//   sub_1800054D0(
				//     (BSP *)&this.fields,
				//     v3,
				//     v4,
				//     v5,
				//     (MethodInfo *)v9.m_AnimatedSprites,
				//     *(MethodInfo **)&v9.m_AnimationSpeed);
				//   this.fields.verticalFlowTexture_ST = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                                     &v9,
				//                                                     v6,
				//                                                     v7,
				//                                                     v8,
				//                                                     (MethodInfo *)v9.m_AnimatedSprites);
				// }
				// 
			}

			public Texture2D verticalFlowTexture;

			public Vector4 verticalFlowTexture_ST;

			public float verticalFlowNormalStrength;

			public float verticalFlowSurfaceThreshold;

			public float verticalFlowPorosityBias;
		}
	}
}
