using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	public class HGWetnessRipple : HGBaseWetnessFeature
	{
		public HGWetnessRipple()
		{
			// // HGWetnessRipple()
			// void HG::Rendering::Runtime::Rain::HGWetnessRipple::HGWetnessRipple(HGWetnessRipple *this, MethodInfo *method)
			// {
			//   HGWetnessRipple_WetnessRippleRenderParams *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   HGWetnessRipple_WetnessRippleRenderParams *v6; // rbx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v7; // rdx
			//   Bounds *v8; // r8
			//   Object__Array *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC2B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple::WetnessRippleRenderParams);
			//     byte_18D8EDC2B = 1;
			//   }
			//   v3 = (HGWetnessRipple_WetnessRippleRenderParams *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple::WetnessRippleRenderParams);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   HG::Rendering::Runtime::Rain::HGWetnessRipple::WetnessRippleRenderParams::WetnessRippleRenderParams(v3, 0LL);
			//   this.fields.m_wetnessRippleRenderParams = v6;
			//   sub_1800054D0((BSP *)&this.fields.m_wetnessRippleRenderParams, v7, v8, v9, v10, v11);
			// }
			// 
		}

		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam, Single)
			// void HG::Rendering::Runtime::Rain::HGWetnessRipple::UpdateData(
			//         HGWetnessRipple *this,
			//         RainCommonRenderingParam *rainCommonRenderingParam,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   Texture2D *rippleTexture; // rdx
			//   Bounds *v7; // r8
			//   Object__Array *v8; // r9
			//   char *m_wetnessRippleRenderParams; // rcx
			//   RainCommonPreSettingParam *commonPresettingParam; // rax
			//   RainCommonPreSettingParam *v11; // rax
			//   HGWetnessRipple_WetnessRippleRenderParams *v12; // r9
			//   float y; // xmm1_4
			//   HGWetnessRipple_WetnessRippleRenderParams *v14; // rax
			//   HGWetnessRipple_WetnessRippleRenderParams *v15; // rax
			//   HGWetnessRipple_WetnessRippleRenderParams *v16; // rax
			//   HGWetnessRipple_WetnessRippleRenderParams *v17; // rax
			//   float v18; // xmm6_4
			//   float v19; // xmm7_4
			//   System::MathF *v20; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v22; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v23; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4785, 0LL) )
			//   {
			//     m_wetnessRippleRenderParams = (char *)this.fields.m_wetnessRippleRenderParams;
			//     if ( rainCommonRenderingParam )
			//     {
			//       commonPresettingParam = rainCommonRenderingParam.fields.commonPresettingParam;
			//       if ( commonPresettingParam )
			//       {
			//         rippleTexture = commonPresettingParam.fields.rippleTexture;
			//         if ( m_wetnessRippleRenderParams )
			//         {
			//           *((_QWORD *)m_wetnessRippleRenderParams + 2) = rippleTexture;
			//           sub_1800054D0(
			//             (BSP *)(m_wetnessRippleRenderParams + 16),
			//             (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)rippleTexture,
			//             v7,
			//             v8,
			//             v22,
			//             v23);
			//           v11 = rainCommonRenderingParam.fields.commonPresettingParam;
			//           v12 = this.fields.m_wetnessRippleRenderParams;
			//           if ( v11 )
			//           {
			//             y = v11.fields.rippleTexture_ST.y;
			//             if ( v12 )
			//             {
			//               v12.fields.rippleTexture_ST.x = v11.fields.rippleTexture_ST.x;
			//               v12.fields.rippleTexture_ST.y = y;
			//               v14 = this.fields.m_wetnessRippleRenderParams;
			//               if ( v14 )
			//               {
			//                 v14.fields.rippleNormalStrength = rainCommonRenderingParam.fields.rippleNormalStrength;
			//                 v15 = this.fields.m_wetnessRippleRenderParams;
			//                 if ( v15 )
			//                 {
			//                   v15.fields.rippleWaveNormalStrength = rainCommonRenderingParam.fields.rippleWaveNormalStrength;
			//                   m_wetnessRippleRenderParams = (char *)rainCommonRenderingParam.fields.commonPresettingParam;
			//                   v16 = this.fields.m_wetnessRippleRenderParams;
			//                   if ( m_wetnessRippleRenderParams )
			//                   {
			//                     rippleTexture = (Texture2D *)*((unsigned int *)m_wetnessRippleRenderParams + 62);
			//                     if ( v16 )
			//                     {
			//                       v16.fields.rippleRowColumnCount = (int)rippleTexture;
			//                       v17 = this.fields.m_wetnessRippleRenderParams;
			//                       if ( v17 )
			//                       {
			//                         v17.fields.rippleRoughnessMaskThreshold = rainCommonRenderingParam.fields.rippleRoughnessMaskThreshold;
			//                         v18 = (float)(deltaTime * rainCommonRenderingParam.fields.rippleFrequency)
			//                             + this.fields.m_rippleTimeOffset;
			//                         System::MathF::Floor((System::MathF *)m_wetnessRippleRenderParams, y);
			//                         this.fields.m_rippleTimeOffset = v18 - v18;
			//                         v19 = (float)(deltaTime * rainCommonRenderingParam.fields.rippleWaveSpeed)
			//                             + this.fields.m_rippleWaveTimeOffset;
			//                         System::MathF::Floor(v20, y);
			//                         this.fields.m_rippleWaveTimeOffset = v19 - v19;
			//                         return;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_wetnessRippleRenderParams, rippleTexture);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4785, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
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
			// void HG::Rendering::Runtime::Rain::HGWetnessRipple::SetData(
			//         HGWetnessRipple *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   HGWetnessRipple_WetnessRippleRenderParams *v5; // rdx
			//   __int64 v6; // rcx
			//   HGWetnessRipple_WetnessRippleRenderParams *m_wetnessRippleRenderParams; // rax
			//   Vector4__Array *rainWetnessGlobalParams; // rsi
			//   float m_rippleTimeOffset; // xmm9_4
			//   float rippleNormalStrength; // xmm8_4
			//   float m_rippleWaveTimeOffset; // xmm7_4
			//   float rippleWaveNormalStrength; // xmm6_4
			//   Vector4 *v13; // rax
			//   Vector4__Array *v14; // rdi
			//   Vector4 *v15; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v17[3]; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919D46 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919D46 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4786, 0LL) )
			//   {
			//     m_wetnessRippleRenderParams = this.fields.m_wetnessRippleRenderParams;
			//     if ( m_wetnessRippleRenderParams )
			//     {
			//       if ( m_wetnessRippleRenderParams.fields.rippleRoughnessMaskThreshold <= 0.0 )
			//       {
			//         sub_18004E2C0(7LL, this, globalProps);
			//         return;
			//       }
			//       if ( globalProps )
			//       {
			//         rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//         m_rippleTimeOffset = this.fields.m_rippleTimeOffset;
			//         rippleNormalStrength = m_wetnessRippleRenderParams.fields.rippleNormalStrength;
			//         m_rippleWaveTimeOffset = this.fields.m_rippleWaveTimeOffset;
			//         rippleWaveNormalStrength = m_wetnessRippleRenderParams.fields.rippleWaveNormalStrength;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v13 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                 v17,
			//                 m_rippleTimeOffset,
			//                 rippleNormalStrength,
			//                 m_rippleWaveTimeOffset,
			//                 rippleWaveNormalStrength,
			//                 0LL);
			//         if ( rainWetnessGlobalParams )
			//         {
			//           v17[0] = *v13;
			//           sub_18004D910(rainWetnessGlobalParams, 5LL, v17);
			//           v5 = this.fields.m_wetnessRippleRenderParams;
			//           v14 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( v5 )
			//           {
			//             v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     v17,
			//                     v5.fields.rippleTexture_ST.x,
			//                     v5.fields.rippleTexture_ST.y,
			//                     (float)v5.fields.rippleRowColumnCount,
			//                     v5.fields.rippleRoughnessMaskThreshold,
			//                     0LL);
			//             if ( v14 )
			//             {
			//               v17[0] = *v15;
			//               sub_18004D910(v14, 6LL, v17);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4786, 0LL);
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
			// void HG::Rendering::Runtime::Rain::HGWetnessRipple::ResetData(
			//         HGWetnessRipple *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Vector4__Array *rainWetnessGlobalParams; // rsi
			//   float m_rippleTimeOffset; // xmm6_4
			//   float m_rippleWaveTimeOffset; // xmm7_4
			//   __m128 v10; // xmm0
			//   __m128 v11; // xmm0
			//   Vector4 v12; // xmm0
			//   HGWetnessRipple_WetnessRippleRenderParams *m_wetnessRippleRenderParams; // rax
			//   Vector4__Array *v14; // rdi
			//   float x; // xmm6_4
			//   float y; // xmm7_4
			//   float rippleRowColumnCount; // xmm8_4
			//   __m128 v18; // xmm0
			//   __m128 v19; // xmm0
			//   __m128 v20; // xmm0
			//   Vector4 v21; // xmm0
			//   ILFixDynamicMethodWrapper_2 *v22; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v24; // rax
			//   Vector4 v25; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC2A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDC2A = 1;
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
			//   if ( wrapperArray.max_length.size <= 4787 )
			//     goto LABEL_57;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_32;
			//   if ( wrapperArray.max_length.size <= 0x12B3u )
			//     goto LABEL_33;
			//   if ( !wrapperArray[133].max_length.value )
			//   {
			// LABEL_57:
			//     if ( globalProps )
			//     {
			//       rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//       m_rippleTimeOffset = this.fields.m_rippleTimeOffset;
			//       m_rippleWaveTimeOffset = this.fields.m_rippleWaveTimeOffset;
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
			//         if ( wrapperArray.max_length.size <= 826 )
			//           goto LABEL_18;
			//         if ( !v5._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v5, wrapperArray);
			//           v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//         if ( !v5 )
			//           goto LABEL_32;
			//         if ( LODWORD(v5._0.namespaze) <= 0x33A )
			//           goto LABEL_33;
			//         if ( *(_QWORD *)&v5[17]._1.instance_size )
			//         {
			//           Patch = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
			//           if ( !Patch )
			//             goto LABEL_32;
			//           v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_318(
			//                    &v25,
			//                    Patch,
			//                    m_rippleTimeOffset,
			//                    0.0,
			//                    m_rippleWaveTimeOffset,
			//                    0.0,
			//                    0LL);
			//         }
			//         else
			//         {
			// LABEL_18:
			//           v25.y = 0.0;
			//           v25.w = 0.0;
			//           v10 = (__m128)v25;
			//           v10.m128_f32[0] = m_rippleTimeOffset;
			//           v11 = _mm_shuffle_ps(v10, v10, 210);
			//           v11.m128_f32[0] = m_rippleWaveTimeOffset;
			//           v12 = (Vector4)_mm_shuffle_ps(v11, v11, 201);
			//           v25 = v12;
			//         }
			//         if ( rainWetnessGlobalParams )
			//         {
			//           if ( rainWetnessGlobalParams.max_length.size <= 5u )
			//             goto LABEL_33;
			//           rainWetnessGlobalParams.vector[5] = v12;
			//           m_wetnessRippleRenderParams = this.fields.m_wetnessRippleRenderParams;
			//           v14 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( m_wetnessRippleRenderParams )
			//           {
			//             x = m_wetnessRippleRenderParams.fields.rippleTexture_ST.x;
			//             y = m_wetnessRippleRenderParams.fields.rippleTexture_ST.y;
			//             rippleRowColumnCount = (float)m_wetnessRippleRenderParams.fields.rippleRowColumnCount;
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
			//               if ( wrapperArray.max_length.size <= 826 )
			//                 goto LABEL_28;
			//               if ( !v5._1.cctor_finished_or_no_cctor )
			//               {
			//                 il2cpp_runtime_class_init_0(v5, wrapperArray);
			//                 v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//               }
			//               wrapperArray = v5.static_fields.wrapperArray;
			//               if ( !wrapperArray )
			//                 goto LABEL_32;
			//               if ( wrapperArray.max_length.size <= 0x33Au )
			//                 goto LABEL_33;
			//               if ( wrapperArray[23].bounds )
			//               {
			//                 v24 = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
			//                 if ( !v24 )
			//                   goto LABEL_32;
			//                 v21 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_318(&v25, v24, x, y, rippleRowColumnCount, 0.0, 0LL);
			//               }
			//               else
			//               {
			// LABEL_28:
			//                 v25.w = 0.0;
			//                 v18 = (__m128)v25;
			//                 v18.m128_f32[0] = x;
			//                 v19 = _mm_shuffle_ps(v18, v18, 225);
			//                 v19.m128_f32[0] = y;
			//                 v20 = _mm_shuffle_ps(v19, v19, 198);
			//                 v20.m128_f32[0] = rippleRowColumnCount;
			//                 v21 = (Vector4)_mm_shuffle_ps(v20, v20, 201);
			//               }
			//               if ( v14 )
			//               {
			//                 if ( v14.max_length.size > 6u )
			//                 {
			//                   v14.vector[6] = v21;
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
			//   v22 = IFix::WrappersManagerImpl::GetPatch(4787, 0LL);
			//   if ( !v22 )
			//     goto LABEL_32;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)v22,
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

		private float m_rippleTimeOffset;

		private float m_rippleWaveTimeOffset;

		private HGWetnessRipple.WetnessRippleRenderParams m_wetnessRippleRenderParams;

		private class WetnessRippleRenderParams
		{
			public WetnessRippleRenderParams()
			{
			}

			public Texture2D rippleTexture;

			public Vector2 rippleTexture_ST;

			public float rippleNormalStrength;

			public float rippleWaveNormalStrength;

			public int rippleRowColumnCount;

			public float rippleRoughnessMaskThreshold;
		}
	}
}
