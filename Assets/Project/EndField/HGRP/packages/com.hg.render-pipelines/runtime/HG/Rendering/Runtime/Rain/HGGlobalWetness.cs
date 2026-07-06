using System;

namespace HG.Rendering.Runtime.Rain
{
	public class HGGlobalWetness : HGBaseWetnessFeature
	{
		public HGGlobalWetness()
		{
			// // HGGlobalWetness()
			// void HG::Rendering::Runtime::Rain::HGGlobalWetness::HGGlobalWetness(HGGlobalWetness *this, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v4; // rdx
			//   __int64 v5; // rcx
			//   Bounds *v6; // r8
			//   Object__Array *v7; // r9
			//   MethodInfo *v8; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v9; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC29 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness::GlobalWetnessRenderParams);
			//     byte_18D8EDC29 = 1;
			//   }
			//   v3 = sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness::GlobalWetnessRenderParams);
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   *(_DWORD *)(v3 + 28) = 1065353216;
			//   *(_DWORD *)(v3 + 32) = 1065353216;
			//   *(_DWORD *)(v3 + 40) = 1065353216;
			//   *(_DWORD *)(v3 + 44) = 1065353216;
			//   this.fields.m_globalWetnessRenderParams = (HGGlobalWetness_GlobalWetnessRenderParams *)v3;
			//   sub_1800054D0((BSP *)&this.fields.m_globalWetnessRenderParams, v4, v6, v7, v8, v9);
			// }
			// 
		}

		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam, Single)
			// void HG::Rendering::Runtime::Rain::HGGlobalWetness::UpdateData(
			//         HGGlobalWetness *this,
			//         RainCommonRenderingParam *rainCommonRenderingParam,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   RainCommonPreSettingParam *commonPresettingParam; // rcx
			//   int v8; // ebx
			//   HGGlobalWetness_GlobalWetnessRenderParams *m_globalWetnessRenderParams; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v10; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v11; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v12; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v13; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v14; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v15; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v16; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v17; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v18; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v8 = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4782, 0LL) )
			//   {
			//     m_globalWetnessRenderParams = this.fields.m_globalWetnessRenderParams;
			//     if ( rainCommonRenderingParam )
			//     {
			//       if ( m_globalWetnessRenderParams )
			//       {
			//         m_globalWetnessRenderParams.fields.wetness = rainCommonRenderingParam.fields.wetness;
			//         v10 = this.fields.m_globalWetnessRenderParams;
			//         if ( v10 )
			//         {
			//           v10.fields.wetnessBasePorosity = rainCommonRenderingParam.fields.wetnessBasePorosity;
			//           v11 = this.fields.m_globalWetnessRenderParams;
			//           if ( v11 )
			//           {
			//             v11.fields.wetnessPorosityFactor = rainCommonRenderingParam.fields.wetnessPorosityFactor;
			//             commonPresettingParam = rainCommonRenderingParam.fields.commonPresettingParam;
			//             v12 = this.fields.m_globalWetnessRenderParams;
			//             if ( commonPresettingParam )
			//             {
			//               if ( v12 )
			//               {
			//                 v12.fields.wetnessOcclusionRange = commonPresettingParam.fields.rainOcclusionMapRange;
			//                 v13 = this.fields.m_globalWetnessRenderParams;
			//                 if ( v13 )
			//                 {
			//                   v13.fields.farSceneWetnessDistanceFactor = rainCommonRenderingParam.fields.farSceneWetnessDistanceFactor;
			//                   v14 = this.fields.m_globalWetnessRenderParams;
			//                   if ( v14 )
			//                   {
			//                     v14.fields.farSceneWetnessValue = rainCommonRenderingParam.fields.farSceneWetnessValue;
			//                     v15 = this.fields.m_globalWetnessRenderParams;
			//                     if ( v15 )
			//                     {
			//                       v15.fields.baseWetnessLevel = rainCommonRenderingParam.fields.baseWetnessLevel;
			//                       v16 = this.fields.m_globalWetnessRenderParams;
			//                       if ( v16 )
			//                       {
			//                         v16.fields.verticalWetnessScalar = rainCommonRenderingParam.fields.verticalWetnessScalar;
			//                         v17 = this.fields.m_globalWetnessRenderParams;
			//                         if ( v17 )
			//                         {
			//                           v17.fields.wetnessProceduralForWater = rainCommonRenderingParam.fields.wetnessProceduralForWater;
			//                           v18 = this.fields.m_globalWetnessRenderParams;
			//                           if ( v18 )
			//                           {
			//                             LOBYTE(v8) = rainCommonRenderingParam.fields.wetnessHighQualityKwEnabled;
			//                             v18.fields.wetnessHighQualityReflection = (float)v8;
			//                             return;
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
			//     }
			// LABEL_16:
			//     sub_180B536AC(commonPresettingParam, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4782, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
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
			// void HG::Rendering::Runtime::Rain::HGGlobalWetness::SetData(
			//         HGGlobalWetness *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGGlobalWetness_GlobalWetnessRenderParams *v6; // rcx
			//   HGGlobalWetness_GlobalWetnessRenderParams *m_globalWetnessRenderParams; // rax
			//   Vector4__Array *rainWetnessGlobalParams; // rsi
			//   float wetness; // xmm8_4
			//   float wetnessBasePorosity; // xmm9_4
			//   float wetnessPorosityFactor; // xmm7_4
			//   float wetnessOcclusionRange; // xmm6_4
			//   Vector4 *v13; // rax
			//   HGGlobalWetness_GlobalWetnessRenderParams *v14; // r8
			//   Vector4__Array *v15; // rsi
			//   Vector4 *v16; // rax
			//   Vector4__Array *v17; // rdi
			//   Vector4 *v18; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v20[3]; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919D45 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919D45 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4783, 0LL) )
			//   {
			//     if ( globalProps )
			//     {
			//       m_globalWetnessRenderParams = this.fields.m_globalWetnessRenderParams;
			//       rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//       if ( m_globalWetnessRenderParams )
			//       {
			//         wetness = m_globalWetnessRenderParams.fields.wetness;
			//         wetnessBasePorosity = m_globalWetnessRenderParams.fields.wetnessBasePorosity;
			//         wetnessPorosityFactor = m_globalWetnessRenderParams.fields.wetnessPorosityFactor;
			//         wetnessOcclusionRange = m_globalWetnessRenderParams.fields.wetnessOcclusionRange;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v13 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                 v20,
			//                 wetness,
			//                 wetnessBasePorosity,
			//                 wetnessPorosityFactor,
			//                 wetnessOcclusionRange,
			//                 0LL);
			//         if ( rainWetnessGlobalParams )
			//         {
			//           v20[0] = *v13;
			//           sub_18004D910(rainWetnessGlobalParams, 0LL, v20);
			//           v14 = this.fields.m_globalWetnessRenderParams;
			//           v15 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( v14 )
			//           {
			//             v16 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     v20,
			//                     v14.fields.farSceneWetnessDistanceFactor,
			//                     v14.fields.farSceneWetnessValue,
			//                     v14.fields.baseWetnessLevel,
			//                     v14.fields.verticalWetnessScalar,
			//                     0LL);
			//             if ( v15 )
			//             {
			//               v20[0] = *v16;
			//               sub_18004D910(v15, 8LL, v20);
			//               v6 = this.fields.m_globalWetnessRenderParams;
			//               v17 = globalProps.fields.rainWetnessGlobalParams;
			//               if ( v6 )
			//               {
			//                 v18 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                         v20,
			//                         v6.fields.wetnessProceduralForWater,
			//                         v6.fields.wetnessHighQualityReflection,
			//                         0.0,
			//                         0.0,
			//                         0LL);
			//                 if ( v17 )
			//                 {
			//                   v20[0] = *v18;
			//                   sub_18004D910(v17, 9LL, v20);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4783, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
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
			// void HG::Rendering::Runtime::Rain::HGGlobalWetness::ResetData(
			//         HGGlobalWetness *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   ITilemap *v3; // r9
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   Vector4__Array *rainWetnessGlobalParams; // rax
			//   __m128i si128; // xmm0
			//   Vector4__Array *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TileAnimationData v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, globalProps);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size <= 4784 )
			//     goto LABEL_26;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size <= 0x12B0u )
			//     goto LABEL_16;
			//   if ( !wrapperArray[133].klass )
			//   {
			// LABEL_26:
			//     if ( globalProps )
			//     {
			//       TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                  &v13,
			//                                  (TileBase *)globalProps.fields.rainWetnessGlobalParams,
			//                                  (Vector3Int *)method,
			//                                  v3,
			//                                  (MethodInfo *)v13.m_AnimatedSprites);
			//       if ( wrapperArray )
			//       {
			//         if ( !wrapperArray.max_length.size )
			//           goto LABEL_16;
			//         *(TileAnimationData *)wrapperArray.vector = *TileAnimationDataNoRef;
			//         rainWetnessGlobalParams = globalProps.fields.rainWetnessGlobalParams;
			//         if ( rainWetnessGlobalParams )
			//         {
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18A3573B0);
			//           if ( rainWetnessGlobalParams.max_length.size <= 8u )
			//             goto LABEL_16;
			//           rainWetnessGlobalParams.vector[8] = (Vector4)si128;
			//           v11 = globalProps.fields.rainWetnessGlobalParams;
			//           if ( v11 )
			//           {
			//             if ( v11.max_length.size > 9u )
			//             {
			//               v11.vector[9] = 0LL;
			//               return;
			//             }
			// LABEL_16:
			//             sub_180070270(v6, wrapperArray);
			//           }
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v6, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4784, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
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

		private HGGlobalWetness.GlobalWetnessRenderParams m_globalWetnessRenderParams;

		private class GlobalWetnessRenderParams
		{
			public GlobalWetnessRenderParams()
			{
				// // HGGlobalWetness+GlobalWetnessRenderParams()
				// void HG::Rendering::Runtime::Rain::HGGlobalWetness::GlobalWetnessRenderParams::GlobalWetnessRenderParams(
				//         HGGlobalWetness_GlobalWetnessRenderParams *this,
				//         MethodInfo *method)
				// {
				//   this.fields.baseWetnessLevel = 1.0;
				//   this.fields.verticalWetnessScalar = 1.0;
				//   this.fields.farSceneWetnessDistanceFactor = 1.0;
				//   this.fields.farSceneWetnessValue = 1.0;
				// }
				// 
			}

			public float wetness;

			public float wetnessBasePorosity;

			public float wetnessPorosityFactor;

			public float baseWetnessLevel;

			public float verticalWetnessScalar;

			public float wetnessOcclusionRange;

			public float farSceneWetnessDistanceFactor;

			public float farSceneWetnessValue;

			public float wetnessProceduralForWater;

			public float wetnessHighQualityReflection;
		}
	}
}
