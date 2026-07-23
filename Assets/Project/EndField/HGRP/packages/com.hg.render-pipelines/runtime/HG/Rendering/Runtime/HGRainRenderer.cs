using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Rain;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRainRenderer // TypeDefIndex: 37671
	{
		// Fields
		public static readonly string EDITOR_KW; // 0x00
		public static readonly string LIGHTING_KW; // 0x08
		private List<RainWetnessRenderSeq> m_rainWetnessRenderSeqs; // 0x10
		private static readonly RainDropsType SCENE_DROP_MASK; // 0x10
		private static readonly RainDropsType SCREEN_FX_DROP_MASK; // 0x14
		private static readonly WetnessFeaturesType HIGH_QUALITY_WETNESS_MASK; // 0x18
		private static readonly WetnessFeaturesType LOW_QUALITY_WETNESS_MASK; // 0x1C
		private static readonly float UPDATE_DELTA_TIME_THRESHOLD; // 0x20
		private static readonly float FOV_FADE_HIGHERTHRESHOLD; // 0x24
		private static readonly float FOV_FADE_LOWERTHRESHOLD; // 0x28
		private static readonly int FAR_RAIN_RENDERQUEUE; // 0x2C
		private static readonly int SCENEEFFECT_RAIN_RENDERQUEUE; // 0x30
		private static readonly int RAIN_SPLASH_RENDERQUEUE; // 0x34
		private static readonly int SCREEN_RAIN_DROP_RENDERQUEUE; // 0x38
		private RainCommonPreSettingParam m_rainCommonPreSettingParam; // 0x18
		private RainCommonResources m_rainCommonResources; // 0x20
		private RainWetnessQualityParams m_qualityParams; // 0x28
	
		// Nested types
		[Flags]
		public enum RainDropsType // TypeDefIndex: 37667
		{
			None = 0,
			FarRain = 1,
			SceneEffectRain = 2,
			GPUParticleRain = 4,
			ScreenRainDrops = 8,
			RainSplashes = 16
		}
	
		[Flags]
		public enum WetnessFeaturesType // TypeDefIndex: 37668
		{
			None = 0,
			Wetness = 1,
			VerticalFlow = 2,
			Ripple = 4
		}
	
		private class RainWetnessRenderSeq // TypeDefIndex: 37669
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public int cameraMask; // 0x18
			public List<HGBaseSubRainRenderer> subRainRenderers; // 0x20
			public List<HGBaseWetnessFeature> wetnessFeatures; // 0x28
			public RainCommonRenderingParam rainCommonRenderingParam; // 0x30
			public RainWetnessGlobalProps rainWetnessGlobalProps; // 0x38
			private float m_deltaTime; // 0x40
			private float m_lastTime; // 0x44
	
			// Constructors
			public RainWetnessRenderSeq() {} // 0x0000000184D87910-0x0000000184D87920
			// Void Reset()
			void USD::NET::SampleEnumerator<System::Object>::Reset(SampleEnumerator_1_System_Object_ *this, MethodInfo *method)
			{
			  this->fields.m_i = -1;
			}
			
	
			// Methods
			public void CreateDefaultFeatures() {} // 0x0000000182EDA930-0x0000000182EDAC00
			// Void CreateDefaultFeatures()
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::CreateDefaultFeatures(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  __int64 FAR_RAIN_RENDERQUEUE; // rdx
			  void *subRainRenderers; // rcx
			  List_1_System_Object_ *v5; // rsi
			  HGFarRainRenderer *v6; // rax
			  HGFarRainRenderer *v7; // rdi
			  struct HGRainRenderer__Class *v8; // rax
			  List_1_System_Object_ *v9; // rsi
			  HGSceneEffectRainRenderer *v10; // rax
			  HGSceneEffectRainRenderer *v11; // rdi
			  List_1_System_Object_ *v12; // rsi
			  HGRainSplashRenderer *v13; // rax
			  HGRainSplashRenderer *v14; // rdi
			  List_1_System_Object_ *v15; // rsi
			  HGScreenRainDropFXRenderer *v16; // rax
			  HGScreenRainDropFXRenderer *v17; // rdi
			  List_1_System_Object_ *wetnessFeatures; // rsi
			  HGGlobalWetness *v19; // rax
			  HGGlobalWetness *v20; // rdi
			  List_1_System_Object_ *v21; // rsi
			  HGWetnessVerticalFlow *v22; // rax
			  HGWetnessVerticalFlow *v23; // rdi
			  List_1_System_Object_ *v24; // rdi
			  HGWetnessRipple *v25; // rax
			  HGWetnessRipple *v26; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(796, 0LL) )
			  {
			    subRainRenderers = this->fields.subRainRenderers;
			    if ( subRainRenderers )
			    {
			      sub_183127A90(
			        subRainRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
			      subRainRenderers = this->fields.wetnessFeatures;
			      if ( subRainRenderers )
			      {
			        sub_183127A90(
			          subRainRenderers,
			          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
			        v5 = (List_1_System_Object_ *)this->fields.subRainRenderers;
			        v6 = (HGFarRainRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGFarRainRenderer);
			        v7 = v6;
			        if ( v6 )
			        {
			          HG::Rendering::Runtime::Rain::HGFarRainRenderer::HGFarRainRenderer(v6, 0LL);
			          v7->fields._.rainDropsType = 1;
			          v8 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			          if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			            v8 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			          }
			          FAR_RAIN_RENDERQUEUE = (unsigned int)v8->static_fields->FAR_RAIN_RENDERQUEUE;
			          v7->fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
			          if ( v5 )
			          {
			            sub_182F01190(v5, (Object *)v7);
			            v9 = (List_1_System_Object_ *)this->fields.subRainRenderers;
			            v10 = (HGSceneEffectRainRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
			            v11 = v10;
			            if ( v10 )
			            {
			              HG::Rendering::Runtime::HGSceneEffectRainRenderer::HGSceneEffectRainRenderer(v10, 0LL);
			              v11->fields._.rainDropsType = 2;
			              FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCENEEFFECT_RAIN_RENDERQUEUE;
			              v11->fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
			              if ( v9 )
			              {
			                sub_182F01190(v9, (Object *)v11);
			                v12 = (List_1_System_Object_ *)this->fields.subRainRenderers;
			                v13 = (HGRainSplashRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainSplashRenderer);
			                v14 = v13;
			                if ( v13 )
			                {
			                  HG::Rendering::Runtime::HGRainSplashRenderer::HGRainSplashRenderer(v13, 0LL);
			                  v14->fields._.rainDropsType = 16;
			                  FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->RAIN_SPLASH_RENDERQUEUE;
			                  v14->fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
			                  if ( v12 )
			                  {
			                    sub_182F01190(v12, (Object *)v14);
			                    v15 = (List_1_System_Object_ *)this->fields.subRainRenderers;
			                    v16 = (HGScreenRainDropFXRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGScreenRainDropFXRenderer);
			                    v17 = v16;
			                    if ( v16 )
			                    {
			                      HG::Rendering::Runtime::HGScreenRainDropFXRenderer::HGScreenRainDropFXRenderer(v16, 0LL);
			                      v17->fields._.rainDropsType = 8;
			                      FAR_RAIN_RENDERQUEUE = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCREEN_RAIN_DROP_RENDERQUEUE;
			                      v17->fields._.rainRenderQueue = FAR_RAIN_RENDERQUEUE;
			                      if ( v15 )
			                      {
			                        sub_182F01190(v15, (Object *)v17);
			                        wetnessFeatures = (List_1_System_Object_ *)this->fields.wetnessFeatures;
			                        v19 = (HGGlobalWetness *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness);
			                        v20 = v19;
			                        if ( v19 )
			                        {
			                          HG::Rendering::Runtime::Rain::HGGlobalWetness::HGGlobalWetness(v19, 0LL);
			                          v20->fields._.wetnessType = 1;
			                          if ( wetnessFeatures )
			                          {
			                            sub_182F01190(wetnessFeatures, (Object *)v20);
			                            v21 = (List_1_System_Object_ *)this->fields.wetnessFeatures;
			                            v22 = (HGWetnessVerticalFlow *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow);
			                            v23 = v22;
			                            if ( v22 )
			                            {
			                              HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::HGWetnessVerticalFlow(v22, 0LL);
			                              v23->fields._.wetnessType = 2;
			                              if ( v21 )
			                              {
			                                sub_182F01190(v21, (Object *)v23);
			                                v24 = (List_1_System_Object_ *)this->fields.wetnessFeatures;
			                                v25 = (HGWetnessRipple *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessRipple);
			                                v26 = v25;
			                                if ( v25 )
			                                {
			                                  HG::Rendering::Runtime::Rain::HGWetnessRipple::HGWetnessRipple(v25, 0LL);
			                                  v26->fields._.wetnessType = 4;
			                                  if ( v24 )
			                                  {
			                                    sub_182F01190(v24, (Object *)v26);
			                                    return;
			                                  }
			                                }
			                              }
			                            }
			                          }
			                        }
			                      }
			                    }
			                  }
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_3:
			    sub_1800D8260(subRainRenderers, FAR_RAIN_RENDERQUEUE);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(796, 0LL);
			  if ( !Patch )
			    goto LABEL_3;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			public void PrepareResources(RainCommonResources commonResources) {} // 0x0000000184527E30-0x0000000184528130
			// Void PrepareResources(RainCommonResources)
			// Hidden C++ exception states: #wind=2
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PrepareResources(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        RainCommonResources *commonResources,
			        MethodInfo *method)
			{
			  Object *v3; // rdi
			  HGRainRenderer_RainWetnessRenderSeq *v4; // rbx
			  __int64 v5; // rcx
			  List_1_System_UInt64_ *wetnessFeatures; // rax
			  List_1_HG_Rendering_Runtime_Rain_HGBaseWetnessFeature_ *v7; // r9
			  __int64 *v8; // rdx
			  __int64 v9; // rtt
			  __int64 v10; // r8
			  Object *current; // rbx
			  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v14; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v15; // rcx
			  ILFixDynamicMethodWrapper_39 *v16; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v18; // rdx
			  __int64 v19; // rcx
			  Il2CppExceptionWrapper *v20; // [rsp+20h] [rbp-78h] BYREF
			  Il2CppExceptionWrapper *v21; // [rsp+28h] [rbp-70h] BYREF
			  List_1_T_Enumerator_System_Object_ v22; // [rsp+30h] [rbp-68h] BYREF
			  List_1_T_Enumerator_System_Object_ v23; // [rsp+48h] [rbp-50h] BYREF
			  List_1_T_Enumerator_System_Object_ v24; // [rsp+60h] [rbp-38h] BYREF
			
			  v3 = (Object *)commonResources;
			  v4 = this;
			  memset(&v23, 0, sizeof(v23));
			  memset(&v24, 0, sizeof(v24));
			  if ( IFix::WrappersManagerImpl::IsPatched(797, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(797, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v19, v18);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, v3, 0LL);
			  }
			  else
			  {
			    if ( v4->fields.subRainRenderers && v4->fields.subRainRenderers->fields._size > 0 )
			    {
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v22,
			        (List_1_System_UInt64_ *)v4->fields.subRainRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
			      v23 = v22;
			      v22._list = 0LL;
			      *(_QWORD *)&v22._index = &v23;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v23,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
			        {
			          if ( v23._current )
			            sub_1800C0840(v5, v23._current, v3);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v20 )
			      {
			        v22._list = (List_1_System_Object_ *)v20->ex;
			        if ( v22._list )
			          sub_18007E1E0(v22._list);
			        v3 = (Object *)commonResources;
			        v4 = this;
			      }
			    }
			    if ( v4->fields.wetnessFeatures )
			    {
			      wetnessFeatures = (List_1_System_UInt64_ *)v4->fields.wetnessFeatures;
			      if ( wetnessFeatures->fields._size > 0 )
			      {
			        v7 = v4->fields.wetnessFeatures;
			        *(_OWORD *)&v22._index = 0LL;
			        v22._list = (List_1_System_Object_ *)wetnessFeatures;
			        if ( dword_18F35FD08 )
			        {
			          v8 = &qword_18F103690[(((unsigned __int64)&v22 >> 12) & 0x1FFFFF) >> 6];
			          _m_prefetchw(v8);
			          do
			            v9 = *v8;
			          while ( v9 != _InterlockedCompareExchange64(v8, *v8 | (1LL << (((unsigned __int64)&v22 >> 12) & 0x3F)), *v8) );
			        }
			        v22._index = 0;
			        v22._version = v7->fields._version;
			        v22._current = 0LL;
			        *(_OWORD *)&v24._list = *(_OWORD *)&v22._list;
			        v24._current = 0LL;
			        v22._list = 0LL;
			        *(_QWORD *)&v22._index = &v24;
			        try
			        {
			          while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                    &v24,
			                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
			          {
			            current = v24._current;
			            if ( v24._current )
			            {
			              v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			              if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			              {
			                il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			                v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			              }
			              wrapperArray = v12->static_fields->wrapperArray;
			              if ( !wrapperArray )
			                sub_1800D8250(v12, 0LL);
			              if ( wrapperArray->max_length.size > 798 )
			              {
			                if ( !v12->_1.cctor_finished_or_no_cctor )
			                {
			                  il2cpp_runtime_class_init_1(v12);
			                  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			                }
			                v14 = v12->static_fields->wrapperArray;
			                if ( !v14 )
			                  sub_1800D8250(v12, 0LL);
			                if ( v14->max_length.size <= 0x31Eu )
			                  sub_1800D2AA0(v12, v14, v10);
			                if ( v14[22].vector[6] )
			                {
			                  if ( !v12->_1.cctor_finished_or_no_cctor )
			                  {
			                    il2cpp_runtime_class_init_1(v12);
			                    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			                  }
			                  v15 = v12->static_fields->wrapperArray;
			                  if ( !v15 )
			                    sub_1800D8250(0LL, v14);
			                  if ( v15->max_length.size <= 0x31Eu )
			                    sub_1800D2AA0(v15, v14, v10);
			                  v16 = (ILFixDynamicMethodWrapper_39 *)v15[22].vector[6];
			                  if ( !v16 )
			                    sub_1800D8250(0LL, v14);
			                  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(v16, current, v3, 0LL);
			                }
			              }
			            }
			          }
			        }
			        catch ( Il2CppExceptionWrapper *v21 )
			        {
			          v22._list = (List_1_System_Object_ *)v21->ex;
			          if ( v22._list )
			            sub_18007E1E0(v22._list);
			        }
			      }
			    }
			  }
			}
			
			public void PerFrameClear() {} // 0x00000001832DD170-0x00000001832DD300
			// Void PerFrameClear()
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PerFrameClear(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rax
			  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *v12; // rbx
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  MethodInfo *v15; // [rsp+20h] [rbp-48h] BYREF
			  SingleFieldAccessor v16; // [rsp+28h] [rbp-40h] BYREF
			
			  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v5->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v5, method);
			  if ( wrapperArray->max_length.size <= 660 )
			    goto LABEL_35;
			  if ( !v5->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v5);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v7 = v5->static_fields->wrapperArray;
			  if ( !v7 )
			    sub_1800D8260(v5, method);
			  if ( v7->max_length.size <= 0x294u )
			    sub_1800D2AB0(v5, method);
			  if ( v7[18].vector[12] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(660, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			LABEL_35:
			    if ( this->fields.subRainRenderers )
			    {
			      subRainRenderers = this->fields.subRainRenderers;
			      if ( subRainRenderers->fields._size > 0 )
			      {
			        v12 = this->fields.subRainRenderers;
			        *(_OWORD *)&v16.monitor = 0LL;
			        v16.klass = (SingleFieldAccessor__Class *)subRainRenderers;
			        sub_18002D1B0(&v16, (Type *)method, v2, v3, v15);
			        LODWORD(v16.monitor) = 0;
			        if ( !v12 )
			          sub_1800D8260(v14, v13);
			        HIDWORD(v16.monitor) = v12->fields._version;
			        v16.fields._.getValueDelegate = 0LL;
			        *(_OWORD *)&v16.fields._.descriptor = *(_OWORD *)&v16.klass;
			        v16.fields.clearDelegate = 0LL;
			        v16.klass = 0LL;
			        v16.monitor = (MonitorData *)&v16.fields._.descriptor;
			        try
			        {
			          while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                    (List_1_T_Enumerator_System_Object_ *)&v16.fields._.descriptor,
			                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
			          {
			            if ( v16.fields.clearDelegate )
			              sub_180003290(6LL, v16.fields.clearDelegate);
			          }
			        }
			        catch ( Il2CppExceptionWrapper *v15 )
			        {
			          v16.klass = (SingleFieldAccessor__Class *)v15->methodPointer;
			          if ( v16.klass )
			            sub_18007E1E0(v16.klass);
			        }
			      }
			    }
			  }
			}
			
			public void Dispose() {} // 0x0000000182ED8F00-0x0000000182ED9050
			// Void Dispose()
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  HGRainRenderer_RainWetnessRenderSeq *v2; // rdi
			  Object *current; // rbx
			  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rcx
			  List_1_HG_Rendering_Runtime_Rain_HGBaseWetnessFeature_ *wetnessFeatures; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  Il2CppExceptionWrapper *v9; // [rsp+20h] [rbp-48h] BYREF
			  List_1_T_Enumerator_System_Object_ v10; // [rsp+28h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v11; // [rsp+40h] [rbp-28h] BYREF
			
			  v2 = this;
			  memset(&v11, 0, sizeof(v11));
			  if ( IFix::WrappersManagerImpl::IsPatched(519, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(519, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
			  }
			  else
			  {
			    if ( v2->fields.subRainRenderers && v2->fields.subRainRenderers->fields._size > 0 )
			    {
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v10,
			        (List_1_System_UInt64_ *)v2->fields.subRainRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::GetEnumerator);
			      v11 = v10;
			      v10._list = 0LL;
			      *(_QWORD *)&v10._index = &v11;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v11,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
			        {
			          current = v11._current;
			          if ( v11._current )
			          {
			            sub_1800049A0(v11._current->klass);
			            ((void (__fastcall *)(Object *, FieldInfo *))current->klass[1]._0.klass)(
			              current,
			              current->klass[1]._0.fields);
			          }
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v9 )
			      {
			        v10._list = (List_1_System_Object_ *)v9->ex;
			        if ( v10._list )
			          sub_18007E1E0(v10._list);
			        v2 = this;
			      }
			    }
			    subRainRenderers = v2->fields.subRainRenderers;
			    if ( subRainRenderers )
			      sub_183127A90(
			        subRainRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::Clear);
			    wetnessFeatures = v2->fields.wetnessFeatures;
			    if ( wetnessFeatures )
			      sub_183127A90(
			        wetnessFeatures,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::Clear);
			  }
			}
			
			private void _UpdateDeltaTime() {} // 0x00000001832DE0F0-0x00000001832DE1E0
			// Void _UpdateDeltaTime()
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateDeltaTime(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  float time; // xmm0_4
			  struct HGRainRenderer__Class *v6; // rcx
			  float v7; // xmm6_4
			  float m_lastTime; // xmm7_4
			  HGRainRenderer__StaticFields *static_fields; // rax
			  float UPDATE_DELTA_TIME_THRESHOLD; // xmm0_4
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_14;
			  if ( wrapperArray->max_length.size > 800 )
			  {
			    if ( !v3->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v3);
			      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			    if ( v3 )
			    {
			      if ( LODWORD(v3->_0.namespaze) <= 0x320 )
			        sub_1800D2AB0(v3, wrapperArray);
			      if ( !*((_QWORD *)&v3[17]._0.byval_arg + 1) )
			        goto LABEL_5;
			      Patch = IFix::WrappersManagerImpl::GetPatch(800, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			        return;
			      }
			    }
			LABEL_14:
			    sub_1800D8260(v3, wrapperArray);
			  }
			LABEL_5:
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			  time = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
			  v6 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			  v7 = time;
			  m_lastTime = this->fields.m_lastTime;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			    v6 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			  }
			  static_fields = v6->static_fields;
			  UPDATE_DELTA_TIME_THRESHOLD = v7 - m_lastTime;
			  if ( (float)-static_fields->UPDATE_DELTA_TIME_THRESHOLD > (float)(v7 - m_lastTime) )
			  {
			    UPDATE_DELTA_TIME_THRESHOLD = -static_fields->UPDATE_DELTA_TIME_THRESHOLD;
			  }
			  else if ( UPDATE_DELTA_TIME_THRESHOLD > static_fields->UPDATE_DELTA_TIME_THRESHOLD )
			  {
			    UPDATE_DELTA_TIME_THRESHOLD = static_fields->UPDATE_DELTA_TIME_THRESHOLD;
			  }
			  this->fields.m_lastTime = v7;
			  this->fields.m_deltaTime = UPDATE_DELTA_TIME_THRESHOLD;
			}
			
			public void UpdateRainAndWetnessDataSeq(RainWetnessQualityParams qualityParams, ref ScriptableRenderContext renderContext) {} // 0x00000001832DDBB0-0x00000001832DDE80
			// Void UpdateRainAndWetnessDataSeq(HGRainRenderer+RainWetnessQualityParams, ScriptableRenderContext ByRef)
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateRainAndWetnessDataSeq(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        HGRainRenderer_RainWetnessQualityParams *qualityParams,
			        ScriptableRenderContext *renderContext,
			        MethodInfo *method)
			{
			  void *v6; // rcx
			  HGRainRenderer_RainWetnessQualityParams *v7; // rdi
			  __int64 v8; // r8
			  float time; // xmm0_4
			  float v10; // xmm6_4
			  float m_lastTime; // xmm7_4
			  __int64 v12; // rax
			  float v13; // xmm0_4
			  HGCamera *hgCamera; // rdi
			  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rdi
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  bool enableWetness; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  ILFixDynamicMethodWrapper_2 *v19; // rax
			  ILFixDynamicMethodWrapper_2 *v20; // rax
			  ILFixDynamicMethodWrapper_2 *v21; // rax
			  ILFixDynamicMethodWrapper_2 *v22; // rax
			
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  v7 = qualityParams;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v8 = **((_QWORD **)v6 + 23);
			  if ( !v8 )
			    goto LABEL_41;
			  if ( *(int *)(v8 + 24) > 799 )
			  {
			    if ( !*((_DWORD *)v6 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			    if ( !qualityParams )
			      goto LABEL_41;
			    if ( qualityParams->fields.rainSplashMaxCount <= 0x31Fu )
			      goto LABEL_79;
			    if ( *(_QWORD *)&qualityParams[160].fields.rainSplashMaxCount )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(799, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(Patch, (Object *)this, (Object *)v7, renderContext, 0LL);
			        return;
			      }
			      goto LABEL_41;
			    }
			  }
			  if ( !*((_DWORD *)v6 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount <= 800 )
			    goto LABEL_82;
			  if ( !*((_DWORD *)v6 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount <= 0x320u )
			    goto LABEL_79;
			  if ( *(_QWORD *)&qualityParams[160].fields.sceneEffectRainLayerCount )
			  {
			    v19 = IFix::WrappersManagerImpl::GetPatch(800, 0LL);
			    if ( !v19 )
			      goto LABEL_41;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v19, (Object *)this, 0LL);
			  }
			  else
			  {
			LABEL_82:
			    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			    time = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
			    v6 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			    v10 = time;
			    m_lastTime = this->fields.m_lastTime;
			    if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			      v6 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			    }
			    v12 = *((_QWORD *)v6 + 23);
			    v13 = v10 - m_lastTime;
			    if ( (float)-*(float *)(v12 + 32) > (float)(v10 - m_lastTime) )
			    {
			      v13 = -*(float *)(v12 + 32);
			    }
			    else if ( v13 > *(float *)(v12 + 32) )
			    {
			      v13 = *(float *)(v12 + 32);
			    }
			    this->fields.m_lastTime = v10;
			    this->fields.m_deltaTime = v13;
			  }
			  if ( !v7 )
			    goto LABEL_41;
			  HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareWetnessRenderData(
			    this,
			    this->fields.m_deltaTime,
			    v7->fields.enableRainWetnessHighQuality,
			    0LL);
			  HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareRainRenderData(
			    this,
			    this->fields.m_deltaTime,
			    v7,
			    renderContext,
			    0LL);
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount > 812 )
			  {
			    if ( !*((_DWORD *)v6 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			    if ( !qualityParams )
			      goto LABEL_41;
			    if ( qualityParams->fields.rainSplashMaxCount <= 0x32Cu )
			      goto LABEL_79;
			    if ( qualityParams[163].monitor )
			    {
			      v20 = IFix::WrappersManagerImpl::GetPatch(812, 0LL);
			      if ( v20 )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v20, (Object *)this, 0LL);
			        return;
			      }
			      goto LABEL_41;
			    }
			  }
			  hgCamera = this->fields.hgCamera;
			  if ( !hgCamera )
			    goto LABEL_41;
			  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
			  if ( !*((_DWORD *)v6 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount <= 813 )
			    goto LABEL_27;
			  if ( !*((_DWORD *)v6 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount <= 0x32Du )
			LABEL_79:
			    sub_1800D2AB0(v6, qualityParams);
			  if ( *(_QWORD *)&qualityParams[163].fields.enableRainWetnessHighQuality )
			  {
			    v21 = IFix::WrappersManagerImpl::GetPatch(813, 0LL);
			    if ( !v21 )
			      goto LABEL_41;
			    enableWetness = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			                      (ILFixDynamicMethodWrapper_20 *)v21,
			                      (Object *)this,
			                      0LL);
			    goto LABEL_33;
			  }
			LABEL_27:
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			  if ( HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL) <= 0 )
			    goto LABEL_34;
			  rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			  if ( !rainCommonRenderingParam )
			    goto LABEL_41;
			  if ( rainCommonRenderingParam->fields.enable )
			    goto LABEL_70;
			  enableWetness = rainCommonRenderingParam->fields.enableWetness;
			LABEL_33:
			  if ( enableWetness )
			  {
			LABEL_70:
			    if ( verticalOcclusionMapManager )
			    {
			      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			        verticalOcclusionMapManager,
			        HGVerticalOcclusionMapManager_RequestUsageType__Enum_RainWetnessOcclusion,
			        0LL);
			      return;
			    }
			LABEL_41:
			    sub_1800D8260(v6, qualityParams);
			  }
			LABEL_34:
			  if ( !verticalOcclusionMapManager )
			    goto LABEL_41;
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGRainRenderer_RainWetnessQualityParams *)**((_QWORD **)v6 + 23);
			  if ( !qualityParams )
			    goto LABEL_41;
			  if ( qualityParams->fields.rainSplashMaxCount <= 816 )
			  {
			LABEL_39:
			    verticalOcclusionMapManager->fields.m_requestType &= ~1u;
			    return;
			  }
			  if ( !*((_DWORD *)v6 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v6 = (void *)**((_QWORD **)v6 + 23);
			  if ( !v6 )
			    goto LABEL_41;
			  if ( *((_DWORD *)v6 + 6) <= 0x330u )
			    goto LABEL_79;
			  if ( !*((_QWORD *)v6 + 820) )
			    goto LABEL_39;
			  v22 = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
			  if ( !v22 )
			    goto LABEL_41;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			    (ILFixDynamicMethodWrapper_30 *)v22,
			    (Object *)verticalOcclusionMapManager,
			    1,
			    0LL);
			}
			
			private void _PrepareWetnessRenderData(float deltaTime, bool enableHighQualityWetness) {} // 0x00000001832DD580-0x00000001832DD7B0
			// Void _PrepareWetnessRenderData(Single, Boolean)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareWetnessRenderData(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        float deltaTime,
			        bool enableHighQualityWetness,
			        MethodInfo *method)
			{
			  __int64 v4; // rdx
			  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			  ILFixDynamicMethodWrapper_2__Array *v9; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v11; // rdx
			  __int64 v12; // rcx
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  RainCommonRenderingParam *rainCommonRenderingParam; // rdi
			  struct HGRainRenderer__Class *v16; // rax
			  int32_t HIGH_QUALITY_WETNESS_MASK; // edi
			  __int64 v18; // rcx
			  List_1_T_Enumerator_System_Object_ v19; // [rsp+30h] [rbp-58h] BYREF
			  Il2CppExceptionWrapper *v20; // [rsp+48h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v21; // [rsp+50h] [rbp-38h] BYREF
			
			  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v7->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v7, v4);
			  if ( wrapperArray->max_length.size <= 802 )
			    goto LABEL_13;
			  if ( !v7->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v7);
			    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v9 = v7->static_fields->wrapperArray;
			  if ( !v9 )
			    sub_1800D8260(v7, v4);
			  if ( v9->max_length.size <= 0x322u )
			    sub_1800D2AB0(v7, v4);
			  if ( v9[22].vector[10] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(802, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v12, v11);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_319(Patch, (Object *)this, deltaTime, enableHighQualityWetness, 0LL);
			  }
			  else
			  {
			LABEL_13:
			    HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessCommonParams(
			      this,
			      enableHighQualityWetness,
			      0LL);
			    rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			    if ( !rainCommonRenderingParam )
			      sub_1800D8260(v14, v13);
			    if ( rainCommonRenderingParam->fields.enableWetness )
			    {
			      v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			      if ( rainCommonRenderingParam->fields.wetnessHighQualityKwEnabled )
			      {
			        if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			        {
			          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			          v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			        }
			        HIGH_QUALITY_WETNESS_MASK = v16->static_fields->HIGH_QUALITY_WETNESS_MASK;
			      }
			      else
			      {
			        if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			        {
			          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			          v16 = TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			        }
			        HIGH_QUALITY_WETNESS_MASK = v16->static_fields->LOW_QUALITY_WETNESS_MASK;
			      }
			      if ( !this->fields.wetnessFeatures )
			        sub_1800D8260(v14, v13);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v19,
			        (List_1_System_UInt64_ *)this->fields.wetnessFeatures,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
			      v21 = v19;
			      v19._list = 0LL;
			      *(_QWORD *)&v19._index = &v21;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v21,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
			        {
			          if ( !v21._current )
			            sub_1800D8250(v18, 0LL);
			          if ( (HIGH_QUALITY_WETNESS_MASK & (__int64)v21._current[1].klass) > 0 )
			            sub_1808B4B60(v18, v21._current, this->fields.rainCommonRenderingParam);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v20 )
			      {
			        v19._list = (List_1_System_Object_ *)v20->ex;
			        if ( v19._list )
			          sub_18007E1E0(v19._list);
			      }
			    }
			  }
			}
			
			private void _UpdateWetnessCommonParams(bool enableHighQualityWetness) {} // 0x00000001832DC760-0x00000001832DCB60
			// Void _UpdateWetnessCommonParams(Boolean)
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessCommonParams(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        bool enableHighQualityWetness,
			        MethodInfo *method)
			{
			  _BYTE *v5; // rcx
			  HGRainConfig *p_rainConfig; // rdx
			  HGCamera *hgCamera; // rdi
			  HGEnvironmentPhase *InterpolatedPhase; // rax
			  __int64 v9; // r8
			  HGRainConfig *v10; // rax
			  char *v11; // rcx
			  __int64 v12; // r9
			  __int128 v13; // xmm0
			  __int128 v14; // xmm1
			  __int128 v15; // xmm0
			  __int128 v16; // xmm1
			  __int128 v17; // xmm0
			  __int128 v18; // xmm1
			  __int128 v19; // xmm0
			  __int128 v20; // xmm1
			  __int64 v21; // r9
			  __int128 v22; // xmm1
			  __int128 v23; // xmm0
			  HGRainConfig *v24; // rax
			  __int128 v25; // xmm0
			  __int128 v26; // xmm1
			  __int128 v27; // xmm0
			  __int128 v28; // xmm1
			  __int128 v29; // xmm0
			  __int128 v30; // xmm1
			  __int128 v31; // xmm0
			  __int128 v32; // xmm1
			  __int128 v33; // xmm1
			  __int128 v34; // xmm0
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  float v36; // xmm1_4
			  float v37; // xmm0_4
			  RainCommonRenderingParam *v38; // rax
			  float v39; // xmm0_4
			  RainCommonRenderingParam *v40; // rax
			  float v41; // xmm0_4
			  RainCommonRenderingParam *v42; // rax
			  float v43; // xmm0_4
			  RainCommonRenderingParam *v44; // rax
			  float v45; // xmm0_4
			  RainCommonRenderingParam *v46; // rax
			  RainCommonRenderingParam *v47; // rax
			  RainCommonRenderingParam *v48; // rax
			  RainCommonRenderingParam *v49; // rax
			  RainCommonRenderingParam *v50; // rax
			  RainCommonRenderingParam *v51; // rax
			  RainCommonRenderingParam *v52; // rax
			  RainCommonRenderingParam *v53; // rax
			  RainCommonRenderingParam *v54; // rax
			  RainCommonRenderingParam *v55; // rax
			  RainCommonRenderingParam *v56; // rax
			  RainCommonRenderingParam *v57; // rax
			  RainCommonRenderingParam *v58; // rax
			  RainCommonRenderingParam *v59; // rax
			  RainCommonRenderingParam *v60; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  _OWORD *v62; // rax
			  __int128 v63; // xmm0
			  __int128 v64; // xmm1
			  __int128 v65; // xmm0
			  __int128 v66; // xmm1
			  __int128 v67; // xmm0
			  __int128 v68; // xmm1
			  __int128 v69; // xmm0
			  __int128 v70; // xmm1
			  __int128 v71; // xmm1
			  __int128 v72; // xmm0
			  HGCamera *v73; // rax
			  Camera *camera; // rdi
			  char v75; // [rsp+20h] [rbp-E0h] BYREF
			  float v76; // [rsp+54h] [rbp-ACh]
			  char v77; // [rsp+E1h] [rbp-1Fh]
			  float v78; // [rsp+E4h] [rbp-1Ch]
			  float v79; // [rsp+E8h] [rbp-18h]
			  float v80; // [rsp+ECh] [rbp-14h]
			  float v81; // [rsp+F0h] [rbp-10h]
			  int v82; // [rsp+F4h] [rbp-Ch]
			  float v83; // [rsp+F8h] [rbp-8h]
			  float v84; // [rsp+FCh] [rbp-4h]
			  float v85; // [rsp+100h] [rbp+0h]
			  float v86; // [rsp+104h] [rbp+4h]
			  float v87; // [rsp+108h] [rbp+8h]
			  float v88; // [rsp+10Ch] [rbp+Ch]
			  float v89; // [rsp+110h] [rbp+10h]
			  float v90; // [rsp+114h] [rbp+14h]
			  float v91; // [rsp+118h] [rbp+18h]
			  float v92; // [rsp+11Ch] [rbp+1Ch]
			  float v93; // [rsp+120h] [rbp+20h]
			  float v94; // [rsp+124h] [rbp+24h]
			  _BYTE v95[196]; // [rsp+150h] [rbp+50h] BYREF
			  float v96; // [rsp+214h] [rbp+114h]
			
			  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  p_rainConfig = (HGRainConfig *)**((_QWORD **)v5 + 23);
			  if ( !p_rainConfig )
			    goto LABEL_48;
			  if ( SLODWORD(p_rainConfig->color.a) <= 803 )
			    goto LABEL_5;
			  if ( !*((_DWORD *)v5 + 56) )
			  {
			    il2cpp_runtime_class_init_1(v5);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v5 = (_BYTE *)**((_QWORD **)v5 + 23);
			  if ( !v5 )
			    goto LABEL_48;
			  if ( *((_DWORD *)v5 + 6) <= 0x323u )
			    sub_1800D2AB0(v5, p_rainConfig);
			  if ( !*((_QWORD *)v5 + 807) )
			  {
			LABEL_5:
			    hgCamera = this->fields.hgCamera;
			    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			    if ( InterpolatedPhase )
			    {
			      p_rainConfig = &InterpolatedPhase->fields.rainConfig;
			      v9 = 2LL;
			      v10 = &InterpolatedPhase->fields.rainConfig;
			      v11 = &v75;
			      v12 = 2LL;
			      do
			      {
			        v11 += 128;
			        v13 = *(_OWORD *)&v10->enable;
			        v14 = *(_OWORD *)&v10->color.g;
			        v10 = (HGRainConfig *)((char *)v10 + 128);
			        *((_OWORD *)v11 - 8) = v13;
			        v15 = *(_OWORD *)&v10[-1].baseWetnessLevel;
			        *((_OWORD *)v11 - 7) = v14;
			        v16 = *(_OWORD *)&v10[-1].verticalFlowSurfaceThreshold;
			        *((_OWORD *)v11 - 6) = v15;
			        v17 = *(_OWORD *)&v10[-1].rippleWaveSpeed;
			        *((_OWORD *)v11 - 5) = v16;
			        v18 = *(_OWORD *)&v10[-1].farSceneWetnessValue;
			        *((_OWORD *)v11 - 4) = v17;
			        v19 = *(_OWORD *)&v10[-1].rainDirection.z;
			        *((_OWORD *)v11 - 3) = v18;
			        v20 = *(_OWORD *)&v10[-1].farRainDirection.x;
			        *((_OWORD *)v11 - 2) = v19;
			        *((_OWORD *)v11 - 1) = v20;
			        --v12;
			      }
			      while ( v12 );
			      v21 = 2LL;
			      v22 = *(_OWORD *)&v10->color.g;
			      *(_OWORD *)v11 = *(_OWORD *)&v10->enable;
			      v23 = *(_OWORD *)&v10->horizontalRainAngle;
			      v24 = p_rainConfig;
			      *((_OWORD *)v11 + 1) = v22;
			      *((_OWORD *)v11 + 2) = v23;
			      v5 = v95;
			      do
			      {
			        v5 += 128;
			        v25 = *(_OWORD *)&v24->enable;
			        v26 = *(_OWORD *)&v24->color.g;
			        v24 = (HGRainConfig *)((char *)v24 + 128);
			        *((_OWORD *)v5 - 8) = v25;
			        v27 = *(_OWORD *)&v24[-1].baseWetnessLevel;
			        *((_OWORD *)v5 - 7) = v26;
			        v28 = *(_OWORD *)&v24[-1].verticalFlowSurfaceThreshold;
			        *((_OWORD *)v5 - 6) = v27;
			        v29 = *(_OWORD *)&v24[-1].rippleWaveSpeed;
			        *((_OWORD *)v5 - 5) = v28;
			        v30 = *(_OWORD *)&v24[-1].farSceneWetnessValue;
			        *((_OWORD *)v5 - 4) = v29;
			        v31 = *(_OWORD *)&v24[-1].rainDirection.z;
			        *((_OWORD *)v5 - 3) = v30;
			        v32 = *(_OWORD *)&v24[-1].farRainDirection.x;
			        *((_OWORD *)v5 - 2) = v31;
			        *((_OWORD *)v5 - 1) = v32;
			        --v21;
			      }
			      while ( v21 );
			      v33 = *(_OWORD *)&v24->color.g;
			      *(_OWORD *)v5 = *(_OWORD *)&v24->enable;
			      v34 = *(_OWORD *)&v24->horizontalRainAngle;
			      *((_OWORD *)v5 + 1) = v33;
			      *((_OWORD *)v5 + 2) = v34;
			      if ( !v95[192] )
			        goto LABEL_13;
			      v62 = v95;
			      do
			      {
			        v62 += 8;
			        v63 = *(_OWORD *)&p_rainConfig->enable;
			        v64 = *(_OWORD *)&p_rainConfig->color.g;
			        p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			        *(v62 - 8) = v63;
			        v65 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
			        *(v62 - 7) = v64;
			        v66 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
			        *(v62 - 6) = v65;
			        v67 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
			        *(v62 - 5) = v66;
			        v68 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
			        *(v62 - 4) = v67;
			        v69 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
			        *(v62 - 3) = v68;
			        v70 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
			        *(v62 - 2) = v69;
			        *(v62 - 1) = v70;
			        --v9;
			      }
			      while ( v9 );
			      v71 = *(_OWORD *)&p_rainConfig->color.g;
			      *v62 = *(_OWORD *)&p_rainConfig->enable;
			      v72 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
			      v62[1] = v71;
			      v62[2] = v72;
			      if ( v96 <= COERCE_FLOAT(1) )
			        goto LABEL_13;
			      v73 = this->fields.hgCamera;
			      if ( !v73 )
			        goto LABEL_48;
			      camera = v73->fields.camera;
			      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
			        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
			      if ( HG::Rendering::Runtime::HGUtils::IsInIsolatedDisplayMode(camera, 0LL) )
			LABEL_13:
			        LOBYTE(p_rainConfig) = 0;
			      else
			        LOBYTE(p_rainConfig) = 1;
			      rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			      if ( rainCommonRenderingParam )
			      {
			        rainCommonRenderingParam->fields.enableWetness = (char)p_rainConfig;
			        v5 = this->fields.rainCommonRenderingParam;
			        if ( v5 )
			        {
			          v36 = 0.0;
			          v5[254] = v77;
			          v37 = (_BYTE)p_rainConfig ? v78 : 0.0;
			          v38 = this->fields.rainCommonRenderingParam;
			          if ( v38 )
			          {
			            v38->fields.wetness = v37;
			            v39 = (_BYTE)p_rainConfig ? v79 : 0.0;
			            v40 = this->fields.rainCommonRenderingParam;
			            if ( v40 )
			            {
			              v40->fields.wetnessBasePorosity = v39;
			              v41 = (_BYTE)p_rainConfig ? v80 : 0.0;
			              v42 = this->fields.rainCommonRenderingParam;
			              if ( v42 )
			              {
			                v42->fields.wetnessPorosityFactor = v41;
			                v43 = (_BYTE)p_rainConfig ? v81 : 0.0;
			                v44 = this->fields.rainCommonRenderingParam;
			                if ( v44 )
			                {
			                  v44->fields.baseWetnessLevel = v43;
			                  v45 = (_BYTE)p_rainConfig ? *(float *)&v82 : 1.0;
			                  v46 = this->fields.rainCommonRenderingParam;
			                  if ( v46 )
			                  {
			                    v46->fields.verticalWetnessScalar = v45;
			                    v47 = this->fields.rainCommonRenderingParam;
			                    if ( v47 )
			                    {
			                      v47->fields.verticalFlowNormalStrength = v84;
			                      v48 = this->fields.rainCommonRenderingParam;
			                      if ( v48 )
			                      {
			                        v48->fields.verticalFlowSpeed = v83;
			                        v49 = this->fields.rainCommonRenderingParam;
			                        if ( v49 )
			                        {
			                          v49->fields.verticalFlowSurfaceThreshold = v85;
			                          v50 = this->fields.rainCommonRenderingParam;
			                          if ( v50 )
			                          {
			                            v50->fields.verticalFlowPorosityBias = v86;
			                            v51 = this->fields.rainCommonRenderingParam;
			                            if ( v51 )
			                            {
			                              v51->fields.rippleNormalStrength = v88;
			                              v52 = this->fields.rainCommonRenderingParam;
			                              if ( v52 )
			                              {
			                                v52->fields.rippleWaveNormalStrength = v90;
			                                v53 = this->fields.rainCommonRenderingParam;
			                                if ( v53 )
			                                {
			                                  v53->fields.rippleRoughnessMaskThreshold = v91;
			                                  v54 = this->fields.rainCommonRenderingParam;
			                                  if ( v54 )
			                                  {
			                                    v54->fields.rippleFrequency = v87;
			                                    v55 = this->fields.rainCommonRenderingParam;
			                                    if ( v55 )
			                                    {
			                                      v55->fields.rippleWaveSpeed = v89;
			                                      v56 = this->fields.rainCommonRenderingParam;
			                                      if ( v56 )
			                                      {
			                                        v56->fields.farSceneWetnessDistanceFactor = v92;
			                                        v57 = this->fields.rainCommonRenderingParam;
			                                        if ( v57 )
			                                        {
			                                          v57->fields.farSceneWetnessValue = v93;
			                                          v58 = this->fields.rainCommonRenderingParam;
			                                          if ( v58 )
			                                          {
			                                            v58->fields.rainCenterBias = v76;
			                                            v59 = this->fields.rainCommonRenderingParam;
			                                            if ( v59 )
			                                            {
			                                              v5 = this->fields.rainCommonRenderingParam;
			                                              v59->fields.wetnessHighQualityKwEnabled = enableHighQualityWetness
			                                                                                     && v59->fields.enableWetness;
			                                              if ( (_BYTE)p_rainConfig )
			                                                v36 = v94;
			                                              v60 = this->fields.rainCommonRenderingParam;
			                                              if ( v60 )
			                                              {
			                                                v60->fields.wetnessProceduralForWater = v36;
			                                                return;
			                                              }
			                                            }
			                                          }
			                                        }
			                                      }
			                                    }
			                                  }
			                                }
			                              }
			                            }
			                          }
			                        }
			                      }
			                    }
			                  }
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_48:
			    sub_1800D8260(v5, p_rainConfig);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(803, 0LL);
			  if ( !Patch )
			    goto LABEL_48;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			    (ILFixDynamicMethodWrapper_18 *)Patch,
			    (Object *)this,
			    enableHighQualityWetness,
			    0LL);
			}
			
			private void _PrepareRainRenderData(float deltaTime, RainWetnessQualityParams qualityParams, ref ScriptableRenderContext renderContext) {} // 0x00000001832DD300-0x00000001832DD580
			// Void _PrepareRainRenderData(Single, HGRainRenderer+RainWetnessQualityParams, ScriptableRenderContext ByRef)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_PrepareRainRenderData(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        float deltaTime,
			        HGRainRenderer_RainWetnessQualityParams *qualityParams,
			        ScriptableRenderContext *renderContext,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			  ILFixDynamicMethodWrapper_2__Array *v11; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  Type *v15; // rdx
			  __int64 v16; // rcx
			  PropertyInfo_1 *v17; // r8
			  Int32__Array **v18; // r9
			  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rbx
			  __int64 v20; // rdx
			  __int64 v21; // rcx
			  Func_2_Google_Protobuf_IMessage_Boolean_ *hasDelegate; // rbx
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  __int64 v24; // rdx
			  __int64 v25; // rcx
			  __int64 v26; // rdx
			  __int64 v27; // rcx
			  MethodInfo *P3; // [rsp+20h] [rbp-68h]
			  ScriptableRenderContext *P3a; // [rsp+20h] [rbp-68h]
			  SingleFieldAccessor v30; // [rsp+30h] [rbp-58h] BYREF
			
			  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v9->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v9, v5);
			  if ( wrapperArray->max_length.size <= 806 )
			    goto LABEL_13;
			  if ( !v9->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v9);
			    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v11 = v9->static_fields->wrapperArray;
			  if ( !v11 )
			    sub_1800D8260(v9, v5);
			  if ( v11->max_length.size <= 0x326u )
			    sub_1800D2AB0(v9, v5);
			  if ( v11[22].vector[14] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(806, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v14, v13);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_323(
			      Patch,
			      (Object *)this,
			      deltaTime,
			      (Object *)qualityParams,
			      renderContext,
			      0LL);
			  }
			  else
			  {
			LABEL_13:
			    HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainCommonParams(
			      this,
			      deltaTime,
			      qualityParams,
			      0LL);
			    subRainRenderers = this->fields.subRainRenderers;
			    if ( !subRainRenderers )
			      sub_1800D8260(v16, v15);
			    *(_OWORD *)&v30.monitor = 0LL;
			    v30.klass = (SingleFieldAccessor__Class *)subRainRenderers;
			    sub_18002D1B0(&v30, v15, v17, v18, P3);
			    LODWORD(v30.monitor) = 0;
			    HIDWORD(v30.monitor) = subRainRenderers->fields._version;
			    v30.fields._.getValueDelegate = 0LL;
			    *(_OWORD *)&v30.fields.setValueDelegate = *(_OWORD *)&v30.klass;
			    v30.fields.hasDelegate = 0LL;
			    v30.klass = 0LL;
			    v30.monitor = (MonitorData *)&v30.fields.setValueDelegate;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                (List_1_T_Enumerator_System_Object_ *)&v30.fields.setValueDelegate,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
			      {
			        hasDelegate = v30.fields.hasDelegate;
			        rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			        if ( !rainCommonRenderingParam )
			          sub_1800D8250(v21, v20);
			        if ( rainCommonRenderingParam->fields.enable )
			        {
			          if ( !v30.fields.hasDelegate )
			            sub_1800D8250(v21, v20);
			          *(float *)&P3a = deltaTime;
			          sub_1808B4BAC(v21, v30.fields.hasDelegate, (_DWORD)this + 48, this->fields.hgCamera, (__int64)P3a);
			          if ( !hasDelegate )
			            sub_1800D8250(v27, v26);
			          sub_18059DDC4(v27, hasDelegate, &this->fields.rainCommonRenderingParam, renderContext);
			        }
			        else
			        {
			          if ( !v30.fields.hasDelegate )
			            sub_1800D8250(v21, v20);
			          sub_1800049A0(v30.fields.hasDelegate->klass);
			          if ( ((unsigned __int8 (__fastcall *)(Func_2_Google_Protobuf_IMessage_Boolean_ *, Il2CppMethodPointer))hasDelegate->klass->vtable.GetInvocationList.method)(
			                 hasDelegate,
			                 hasDelegate->klass->vtable.CombineImpl.methodPtr) )
			          {
			            if ( !hasDelegate )
			              sub_1800D8250(v25, v24);
			            sub_180003290(10LL, hasDelegate);
			          }
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *&v30.fields._.descriptor )
			    {
			      v30.klass = (SingleFieldAccessor__Class *)v30.fields._.descriptor->klass;
			      if ( v30.klass )
			        sub_18007E1E0(v30.klass);
			    }
			  }
			}
			
			private void _UpdateRainCommonParams(float deltaTime, RainWetnessQualityParams qualityParams) {} // 0x00000001832DAE60-0x00000001832DBD90
			// Void _UpdateRainCommonParams(Single, HGRainRenderer+RainWetnessQualityParams)
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainCommonParams(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        float deltaTime,
			        HGRainRenderer_RainWetnessQualityParams *qualityParams,
			        MethodInfo *method)
			{
			  unsigned __int64 rainSplashMaxCount; // rcx
			  __int64 v8; // rdx
			  HGCamera *hgCamera; // rsi
			  HGEnvironmentPhase *InterpolatedPhase; // rax
			  HGRainConfig *p_rainConfig; // rax
			  __int128 v12; // xmm0
			  __int128 v13; // xmm1
			  __int128 v14; // xmm0
			  __int128 v15; // xmm1
			  __int128 v16; // xmm0
			  __int128 v17; // xmm1
			  __int128 v18; // xmm0
			  __int128 v19; // xmm1
			  __int128 v20; // xmm1
			  __int128 v21; // xmm0
			  HGCamera *v22; // rax
			  Object *camera; // rsi
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  HGCamera *v25; // rax
			  Camera *v26; // rsi
			  unsigned __int8 (__fastcall *v27)(Camera *); // rax
			  HGCamera *v28; // rax
			  Camera *v29; // rsi
			  double (__fastcall *v30)(Camera *); // rax
			  double v31; // xmm0_8
			  float v32; // xmm6_4
			  __m128 v33; // xmm10
			  float v34; // xmm6_4
			  HGCamera *v35; // rax
			  Camera *v36; // rsi
			  __int64 (__fastcall *v37)(Camera *); // rax
			  Transform *v38; // rax
			  Vector3 *forward; // rax
			  float v40; // xmm6_4
			  RainCommonRenderingParam *v41; // rax
			  float v42; // xmm0_4
			  RainCommonRenderingParam *v43; // rax
			  RainCommonRenderingParam *v44; // rax
			  RainCommonRenderingParam *v45; // rax
			  RainCommonRenderingParam *v46; // rax
			  RainCommonRenderingParam *v47; // rax
			  RainCommonRenderingParam *v48; // rax
			  RainCommonRenderingParam *v49; // rax
			  RainCommonRenderingParam *v50; // rax
			  RainCommonRenderingParam *v51; // rax
			  RainCommonRenderingParam *v52; // rax
			  RainCommonRenderingParam *v53; // rax
			  RainCommonRenderingParam *v54; // rax
			  RainCommonRenderingParam *v55; // rax
			  RainCommonRenderingParam *v56; // rax
			  RainCommonRenderingParam *v57; // rax
			  RainCommonRenderingParam *v58; // rax
			  RainCommonRenderingParam *v59; // rax
			  RainCommonRenderingParam *v60; // rax
			  __m128i v61; // xmm6
			  RainCommonRenderingParam *v62; // rsi
			  float v63; // xmm6_4
			  RainCommonRenderingParam *v64; // rax
			  RainCommonRenderingParam *v65; // rax
			  RainCommonRenderingParam *v66; // rax
			  float v67; // xmm1_4
			  RainCommonRenderingParam *v68; // rax
			  float v69; // xmm1_4
			  RainCommonRenderingParam *v70; // rax
			  float v71; // xmm1_4
			  RainCommonRenderingParam *v72; // rax
			  float v73; // xmm1_4
			  int32_t v74; // eax
			  RainCommonRenderingParam *v75; // rax
			  RainCommonRenderingParam *v76; // rax
			  RainCommonRenderingParam *v77; // rax
			  float v78; // xmm1_4
			  RainCommonRenderingParam *v79; // rax
			  RainCommonRenderingParam *v80; // rax
			  HGCamera *v81; // rax
			  Camera *v82; // rbx
			  __int64 (__fastcall *v83)(Camera *); // rax
			  __int64 v84; // rbx
			  void (__fastcall *v85)(__int64, __int64 *); // rax
			  RainCommonRenderingParam *v86; // rax
			  float v87; // xmm11_4
			  float v88; // xmm7_4
			  __m128 v89; // xmm6
			  RainCommonRenderingParam *v90; // rax
			  float *v91; // rax
			  __m128 v92; // xmm3
			  __m128 v93; // xmm2
			  __int64 v94; // xmm8_8
			  float v95; // ebx
			  __m128 v96; // xmm0
			  float v97; // xmm1_4
			  __int64 v98; // rax
			  __m128 v99; // xmm1
			  float v100; // esi
			  __m128 v101; // xmm0
			  __int64 v102; // rax
			  __m128 v103; // xmm1
			  float v104; // r14d
			  __m128 v105; // xmm0
			  __int64 v106; // rax
			  float v107; // r15d
			  RainCommonRenderingParam *v108; // rax
			  RainCommonPreSettingParam *commonPresettingParam; // rax
			  float v110; // xmm0_4
			  RainCommonRenderingParam *v111; // rbx
			  float z; // xmm3_4
			  float v113; // xmm5_4
			  float v114; // xmm4_4
			  __m128 v115; // xmm6
			  __m128 v116; // xmm2
			  __m128 v117; // xmm1
			  __int64 v118; // rax
			  RainCommonRenderingParam *v119; // rbx
			  float v120; // xmm3_4
			  float v121; // xmm5_4
			  float v122; // xmm4_4
			  __m128 v123; // xmm6
			  __m128 v124; // xmm2
			  __m128 v125; // xmm1
			  __int64 v126; // rax
			  RainCommonRenderingParam *v127; // rbx
			  float v128; // xmm3_4
			  float v129; // xmm5_4
			  float v130; // xmm4_4
			  __m128 v131; // xmm6
			  __m128 v132; // xmm2
			  __m128 v133; // xmm1
			  __int64 v134; // rax
			  RainCommonRenderingParam *v135; // rax
			  float v136; // xmm0_4
			  __int64 v137; // rax
			  __int64 v138; // rax
			  __int64 v139; // rax
			  __int64 v140; // rax
			  __int64 v141; // rax
			  unsigned __int64 v142; // [rsp+30h] [rbp-D0h] BYREF
			  float v143; // [rsp+38h] [rbp-C8h]
			  Vector3 v144; // [rsp+40h] [rbp-C0h] BYREF
			  _QWORD v145[2]; // [rsp+50h] [rbp-B0h] BYREF
			  __int64 v146; // [rsp+60h] [rbp-A0h] BYREF
			  float v147; // [rsp+68h] [rbp-98h]
			  unsigned __int64 v148; // [rsp+70h] [rbp-90h]
			  __int64 v149; // [rsp+80h] [rbp-80h]
			  char v150; // [rsp+90h] [rbp-70h] BYREF
			  float v151; // [rsp+94h] [rbp-6Ch]
			  float v152; // [rsp+98h] [rbp-68h]
			  Color v153; // [rsp+9Ch] [rbp-64h]
			  float v154; // [rsp+ACh] [rbp-54h]
			  float v155; // [rsp+B8h] [rbp-48h]
			  float v156; // [rsp+BCh] [rbp-44h]
			  float v157; // [rsp+C0h] [rbp-40h]
			  float v158; // [rsp+C8h] [rbp-38h]
			  float v159; // [rsp+CCh] [rbp-34h]
			  float v160; // [rsp+D8h] [rbp-28h]
			  float v161; // [rsp+DCh] [rbp-24h]
			  float v162; // [rsp+E0h] [rbp-20h]
			  float v163; // [rsp+ECh] [rbp-14h]
			  float v164; // [rsp+F0h] [rbp-10h]
			  float v165; // [rsp+F4h] [rbp-Ch]
			  float v166; // [rsp+F8h] [rbp-8h]
			  Color v167; // [rsp+FCh] [rbp-4h]
			  unsigned int v168; // [rsp+10Ch] [rbp+Ch]
			  float v169; // [rsp+110h] [rbp+10h]
			  float v170; // [rsp+114h] [rbp+14h]
			  float v171; // [rsp+118h] [rbp+18h]
			  float v172; // [rsp+11Ch] [rbp+1Ch]
			  float v173; // [rsp+120h] [rbp+20h]
			  float v174; // [rsp+124h] [rbp+24h]
			  float v175; // [rsp+128h] [rbp+28h]
			  float v176; // [rsp+12Ch] [rbp+2Ch]
			  float v177; // [rsp+130h] [rbp+30h]
			  float v178; // [rsp+134h] [rbp+34h]
			  int v179; // [rsp+138h] [rbp+38h]
			  float v180; // [rsp+13Ch] [rbp+3Ch]
			  float v181; // [rsp+140h] [rbp+40h]
			  float v182; // [rsp+144h] [rbp+44h]
			  float v183; // [rsp+148h] [rbp+48h]
			  float v184; // [rsp+14Ch] [rbp+4Ch]
			  float v185; // [rsp+198h] [rbp+98h]
			  float v186; // [rsp+19Ch] [rbp+9Ch]
			  float v187; // [rsp+1A0h] [rbp+A0h]
			  float v188; // [rsp+1A4h] [rbp+A4h]
			  float v189; // [rsp+1A8h] [rbp+A8h]
			  float v190; // [rsp+1ACh] [rbp+ACh]
			  float v191; // [rsp+1B0h] [rbp+B0h]
			  float v192; // [rsp+1B4h] [rbp+B4h]
			  float v193; // [rsp+1B8h] [rbp+B8h]
			
			  rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v8 = **(_QWORD **)(rainSplashMaxCount + 184);
			  if ( !v8 )
			    goto LABEL_141;
			  if ( *(int *)(v8 + 24) > 807 )
			  {
			    if ( !*(_DWORD *)(rainSplashMaxCount + 224) )
			    {
			      il2cpp_runtime_class_init_1(rainSplashMaxCount);
			      rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v8 = **(_QWORD **)(rainSplashMaxCount + 184);
			    if ( !v8 )
			      goto LABEL_141;
			    if ( *(_DWORD *)(v8 + 24) <= 0x327u )
			      goto LABEL_142;
			    if ( *(_QWORD *)(v8 + 6488) )
			    {
			      if ( !*(_DWORD *)(rainSplashMaxCount + 224) )
			      {
			        il2cpp_runtime_class_init_1(rainSplashMaxCount);
			        rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      rainSplashMaxCount = **(_QWORD **)(rainSplashMaxCount + 184);
			      if ( !rainSplashMaxCount )
			        goto LABEL_141;
			      if ( *(_DWORD *)(rainSplashMaxCount + 24) > 0x327u )
			      {
			        rainSplashMaxCount = *(_QWORD *)(rainSplashMaxCount + 6488);
			        if ( rainSplashMaxCount )
			        {
			          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
			            (ILFixDynamicMethodWrapper_4 *)rainSplashMaxCount,
			            (Object *)this,
			            deltaTime,
			            (Object *)qualityParams,
			            0LL);
			          return;
			        }
			LABEL_141:
			        sub_1800D8250(rainSplashMaxCount, v8);
			      }
			LABEL_142:
			      sub_1800D2AA0(rainSplashMaxCount, v8, qualityParams);
			    }
			  }
			  hgCamera = this->fields.hgCamera;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			  if ( !InterpolatedPhase )
			    goto LABEL_141;
			  p_rainConfig = &InterpolatedPhase->fields.rainConfig;
			  rainSplashMaxCount = (unsigned __int64)&v150;
			  v8 = 2LL;
			  do
			  {
			    rainSplashMaxCount += 128LL;
			    v12 = *(_OWORD *)&p_rainConfig->enable;
			    v13 = *(_OWORD *)&p_rainConfig->color.g;
			    p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			    *(_OWORD *)(rainSplashMaxCount - 128) = v12;
			    v14 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
			    *(_OWORD *)(rainSplashMaxCount - 112) = v13;
			    v15 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
			    *(_OWORD *)(rainSplashMaxCount - 96) = v14;
			    v16 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
			    *(_OWORD *)(rainSplashMaxCount - 80) = v15;
			    v17 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
			    *(_OWORD *)(rainSplashMaxCount - 64) = v16;
			    v18 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
			    *(_OWORD *)(rainSplashMaxCount - 48) = v17;
			    v19 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
			    *(_OWORD *)(rainSplashMaxCount - 32) = v18;
			    *(_OWORD *)(rainSplashMaxCount - 16) = v19;
			    --v8;
			  }
			  while ( v8 );
			  v20 = *(_OWORD *)&p_rainConfig->color.g;
			  *(_OWORD *)rainSplashMaxCount = *(_OWORD *)&p_rainConfig->enable;
			  v21 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
			  v22 = this->fields.hgCamera;
			  *(_OWORD *)(rainSplashMaxCount + 16) = v20;
			  *(_OWORD *)(rainSplashMaxCount + 32) = v21;
			  if ( !v22 )
			    goto LABEL_141;
			  camera = (Object *)v22->fields.camera;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
			  rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v8 = **(_QWORD **)(rainSplashMaxCount + 184);
			  if ( !v8 )
			    goto LABEL_141;
			  if ( *(int *)(v8 + 24) > 804 )
			  {
			    if ( !*(_DWORD *)(rainSplashMaxCount + 224) )
			    {
			      il2cpp_runtime_class_init_1(rainSplashMaxCount);
			      rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v8 = **(_QWORD **)(rainSplashMaxCount + 184);
			    if ( !v8 )
			      goto LABEL_141;
			    if ( *(_DWORD *)(v8 + 24) <= 0x324u )
			      goto LABEL_142;
			    if ( *(_QWORD *)(v8 + 6464) )
			    {
			      if ( !*(_DWORD *)(rainSplashMaxCount + 224) )
			      {
			        il2cpp_runtime_class_init_1(rainSplashMaxCount);
			        rainSplashMaxCount = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      rainSplashMaxCount = **(_QWORD **)(rainSplashMaxCount + 184);
			      if ( !rainSplashMaxCount )
			        goto LABEL_141;
			      if ( *(_DWORD *)(rainSplashMaxCount + 24) <= 0x324u )
			        goto LABEL_142;
			      rainSplashMaxCount = *(_QWORD *)(rainSplashMaxCount + 6464);
			      if ( !rainSplashMaxCount )
			        goto LABEL_141;
			      if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			             (ILFixDynamicMethodWrapper_20 *)rainSplashMaxCount,
			             camera,
			             0LL) )
			      {
			        rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			        if ( rainCommonRenderingParam )
			        {
			          rainCommonRenderingParam->fields.enable = 0;
			          return;
			        }
			        goto LABEL_141;
			      }
			    }
			  }
			  v25 = this->fields.hgCamera;
			  if ( !v25 )
			    goto LABEL_141;
			  v26 = v25->fields.camera;
			  if ( !v26 )
			    goto LABEL_141;
			  v27 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
			  if ( !qword_18F36F100 )
			  {
			    v27 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
			    if ( !v27 )
			    {
			      v137 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
			      sub_18007E1B0(v137, 0LL);
			    }
			    qword_18F36F100 = (__int64)v27;
			  }
			  if ( v27(v26) )
			  {
			    v33 = 0LL;
			    v40 = 0.0;
			  }
			  else
			  {
			    v28 = this->fields.hgCamera;
			    if ( !v28 )
			      goto LABEL_141;
			    v29 = v28->fields.camera;
			    if ( !v29 )
			      goto LABEL_141;
			    v30 = (double (__fastcall *)(Camera *))qword_18F36F0D0;
			    if ( !qword_18F36F0D0 )
			    {
			      v30 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_fieldOfView()");
			      if ( !v30 )
			      {
			        v138 = sub_1802EE1B8("UnityEngine.Camera::get_fieldOfView()");
			        sub_18007E1B0(v138, 0LL);
			      }
			      qword_18F36F0D0 = (__int64)v30;
			    }
			    v31 = v30(v29);
			    rainSplashMaxCount = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			    v32 = *(float *)&v31;
			    if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			      rainSplashMaxCount = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
			    }
			    v33 = 0LL;
			    v34 = (float)(v32 - *(float *)(*(_QWORD *)(rainSplashMaxCount + 184) + 40LL))
			        / (float)(*(float *)(*(_QWORD *)(rainSplashMaxCount + 184) + 36LL)
			                - *(float *)(*(_QWORD *)(rainSplashMaxCount + 184) + 40LL));
			    if ( v34 < 0.0 )
			    {
			      v34 = 0.0;
			    }
			    else if ( v34 > 1.0 )
			    {
			      v34 = 1.0;
			    }
			    v35 = this->fields.hgCamera;
			    if ( !v35 )
			      goto LABEL_141;
			    v36 = v35->fields.camera;
			    if ( !v36 )
			      goto LABEL_141;
			    v37 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
			    if ( !qword_18F36FBC0 )
			    {
			      v37 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
			      if ( !v37 )
			      {
			        v139 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
			        sub_18007E1B0(v139, 0LL);
			      }
			      qword_18F36FBC0 = (__int64)v37;
			    }
			    v38 = (Transform *)v37(v36);
			    if ( !v38 )
			      goto LABEL_141;
			    forward = UnityEngine::Transform::get_forward(&v144, v38, 0LL);
			    v148 = *(_QWORD *)&forward->x;
			    *(_QWORD *)&v20 = _mm_shuffle_ps((__m128)v148, (__m128)v148, 85).m128_u64[0];
			    *(float *)&v20 = (float)((float)((float)((float)(*(float *)&v20 * -1.0) + (float)(*(float *)&v148 * 0.0))
			                                   + (float)(forward->z * 0.0))
			                           - 0.89999998)
			                   * 10.0;
			    if ( *(float *)&v20 < 0.0 )
			    {
			      *(_QWORD *)&v20 = 0LL;
			    }
			    else if ( *(float *)&v20 > 1.0 )
			    {
			      *(_QWORD *)&v20 = 1065353216LL;
			      v40 = fmaxf(v34, 1.0 - 1.0);
			      goto LABEL_71;
			    }
			    v40 = fmaxf(v34, 1.0 - *(float *)&v20);
			  }
			LABEL_71:
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_BYTE *)(rainSplashMaxCount + 16) = v150;
			  v41 = this->fields.rainCommonRenderingParam;
			  if ( !v41 )
			    goto LABEL_141;
			  v42 = v151;
			  v41->fields.rawIntensity = v151;
			  v43 = this->fields.rainCommonRenderingParam;
			  if ( !v43 )
			    goto LABEL_141;
			  v43->fields.intensity = v42 * v40;
			  v44 = this->fields.rainCommonRenderingParam;
			  if ( !v44 )
			    goto LABEL_141;
			  v44->fields.speed = v152;
			  v45 = this->fields.rainCommonRenderingParam;
			  if ( !v45 )
			    goto LABEL_141;
			  v45->fields.color = v153;
			  v46 = this->fields.rainCommonRenderingParam;
			  if ( !v46 )
			    goto LABEL_141;
			  v46->fields.color.a = v40 * v46->fields.color.a;
			  v47 = this->fields.rainCommonRenderingParam;
			  if ( !v47 )
			    goto LABEL_141;
			  v47->fields.streakLength = v154;
			  v48 = this->fields.rainCommonRenderingParam;
			  if ( !v48 )
			    goto LABEL_141;
			  v48->fields.sceneEffectRainLightingPercent = v157;
			  if ( !qualityParams )
			    goto LABEL_141;
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_BYTE *)(rainSplashMaxCount + 56) = qualityParams->fields.enableMiddleRain;
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_BYTE *)(rainSplashMaxCount + 252) = qualityParams->fields.enableRainLighting;
			  v49 = this->fields.rainCommonRenderingParam;
			  if ( !v49 )
			    goto LABEL_141;
			  v49->fields.middleRainLayerSpeedDiffMultiplier = v158;
			  v50 = this->fields.rainCommonRenderingParam;
			  if ( !v50 )
			    goto LABEL_141;
			  v50->fields.middleRainAlphaMultiplier = v159;
			  v51 = this->fields.rainCommonRenderingParam;
			  if ( !v51 )
			    goto LABEL_141;
			  v51->fields.middleRainLightingPercent = v160;
			  v52 = this->fields.rainCommonRenderingParam;
			  if ( !v52 )
			    goto LABEL_141;
			  v52->fields.farRainLayerSpeedDiffMultiplier = v161;
			  v53 = this->fields.rainCommonRenderingParam;
			  if ( !v53 )
			    goto LABEL_141;
			  v53->fields.farRainAlphaMultiplier = v162;
			  v54 = this->fields.rainCommonRenderingParam;
			  if ( !v54 )
			    goto LABEL_141;
			  v54->fields.sceneEffectRainJitterLevel = v155;
			  v55 = this->fields.rainCommonRenderingParam;
			  if ( !v55 )
			    goto LABEL_141;
			  v55->fields.sceneEffectRainWidthScale = v156;
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_DWORD *)(rainSplashMaxCount + 160) = qualityParams->fields.sceneEffectRainLayerCount;
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_BYTE *)(rainSplashMaxCount + 80) = qualityParams->fields.enableRainWave;
			  v56 = this->fields.rainCommonRenderingParam;
			  if ( !v56 )
			    goto LABEL_141;
			  v56->fields.rainWaveAlpha = v165;
			  v57 = this->fields.rainCommonRenderingParam;
			  if ( !v57 )
			    goto LABEL_141;
			  v57->fields.rainWaveVerticalSpeed = v163;
			  v58 = this->fields.rainCommonRenderingParam;
			  if ( !v58 )
			    goto LABEL_141;
			  v58->fields.rainWaveHorizontalSpeed = v164;
			  v59 = this->fields.rainCommonRenderingParam;
			  if ( !v59 )
			    goto LABEL_141;
			  v59->fields.rainWaveBottomFadeFactor = v166;
			  v60 = this->fields.rainCommonRenderingParam;
			  if ( !v60 )
			    goto LABEL_141;
			  v61 = _mm_cvtsi32_si128(v168);
			  v60->fields.screenDropColor = v167;
			  rainSplashMaxCount = (unsigned __int64)TypeInfo::System::Math;
			  v62 = this->fields.rainCommonRenderingParam;
			  v63 = _mm_cvtepi32_ps(v61).m128_f32[0] * qualityParams->fields.screenRainDropPercent;
			  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
			  if ( !v62 )
			    goto LABEL_141;
			  System::Math::Ceiling((System::Math *)rainSplashMaxCount, *(double *)&v20);
			  v62->fields.screenDropMaxCountLim = (int)v63;
			  v64 = this->fields.rainCommonRenderingParam;
			  if ( !v64 )
			    goto LABEL_141;
			  v64->fields.screenDropFlowPercent = v175;
			  v65 = this->fields.rainCommonRenderingParam;
			  if ( !v65 )
			    goto LABEL_141;
			  v65->fields.screenDropJitterSpeedScale = v178;
			  v66 = this->fields.rainCommonRenderingParam;
			  if ( !v66 )
			    goto LABEL_141;
			  v67 = v170;
			  v66->fields.screenDropMinMaxLifeTime.x = v169;
			  v66->fields.screenDropMinMaxLifeTime.y = v67;
			  v68 = this->fields.rainCommonRenderingParam;
			  if ( !v68 )
			    goto LABEL_141;
			  v69 = v172;
			  v68->fields.screenDropMinMaxSize.x = v171;
			  v68->fields.screenDropMinMaxSize.y = v69;
			  v70 = this->fields.rainCommonRenderingParam;
			  if ( !v70 )
			    goto LABEL_141;
			  v71 = v177;
			  v70->fields.screenDropMinMaxSpeed.x = v176;
			  v70->fields.screenDropMinMaxSpeed.y = v71;
			  v72 = this->fields.rainCommonRenderingParam;
			  if ( !v72 )
			    goto LABEL_141;
			  v73 = v174;
			  v72->fields.screenDropCentroidFadeParam.x = v173;
			  v72->fields.screenDropCentroidFadeParam.y = v73;
			  v8 = (__int64)this->fields.rainCommonRenderingParam;
			  rainSplashMaxCount = (unsigned int)qualityParams->fields.rainSplashMaxCount;
			  if ( !v8 )
			    goto LABEL_141;
			  v74 = v179;
			  if ( v179 >= (int)rainSplashMaxCount )
			    v74 = qualityParams->fields.rainSplashMaxCount;
			  *(_DWORD *)(v8 + 228) = v74;
			  v75 = this->fields.rainCommonRenderingParam;
			  if ( !v75 )
			    goto LABEL_141;
			  v75->fields.rainSplashSpeed = v180;
			  v76 = this->fields.rainCommonRenderingParam;
			  if ( !v76 )
			    goto LABEL_141;
			  v76->fields.rainSplashAlpha = v181;
			  v77 = this->fields.rainCommonRenderingParam;
			  if ( !v77 )
			    goto LABEL_141;
			  v78 = v183;
			  v77->fields.rainSplashMinMaxSize.x = v182;
			  v77->fields.rainSplashMinMaxSize.y = v78;
			  v79 = this->fields.rainCommonRenderingParam;
			  if ( !v79 )
			    goto LABEL_141;
			  v79->fields.rainSplashLightingPercent = v184;
			  rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			  if ( !rainSplashMaxCount )
			    goto LABEL_141;
			  *(_DWORD *)(rainSplashMaxCount + 328) = this->fields.cameraMask;
			  v80 = this->fields.rainCommonRenderingParam;
			  if ( !v80 )
			    goto LABEL_141;
			  if ( v80->fields.enable )
			  {
			    v81 = this->fields.hgCamera;
			    if ( !v81 )
			      goto LABEL_141;
			    v82 = v81->fields.camera;
			    if ( !v82 )
			      goto LABEL_141;
			    v83 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
			    if ( !qword_18F36FBC0 )
			    {
			      v83 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
			      if ( !v83 )
			      {
			        v140 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
			        sub_18007E1B0(v140, 0LL);
			      }
			      qword_18F36FBC0 = (__int64)v83;
			    }
			    v84 = v83(v82);
			    if ( !v84 )
			      goto LABEL_141;
			    v146 = 0LL;
			    v147 = 0.0;
			    v85 = (void (__fastcall *)(__int64, __int64 *))qword_18F3700F0;
			    if ( !qword_18F3700F0 )
			    {
			      v85 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_1(
			                                                       "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			      if ( !v85 )
			      {
			        v141 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			        sub_18007E1B0(v141, 0LL);
			      }
			      qword_18F3700F0 = (__int64)v85;
			    }
			    v85(v84, &v146);
			    v86 = this->fields.rainCommonRenderingParam;
			    if ( !v86 )
			      goto LABEL_141;
			    v87 = v147;
			    v89 = (__m128)(unsigned int)v146;
			    v88 = v147 - v86->fields.lastCamPos.z;
			    *(_QWORD *)&v144.x = *(_QWORD *)&v86->fields.lastCamPos.x;
			    v89.m128_f32[0] = *(float *)&v146 - v144.x;
			    rainSplashMaxCount = (unsigned __int64)TypeInfo::Beyond::MathUtils;
			    if ( !TypeInfo::Beyond::MathUtils->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::Beyond::MathUtils);
			    v90 = this->fields.rainCommonRenderingParam;
			    if ( !v90 )
			      goto LABEL_141;
			    rainSplashMaxCount = (unsigned __int64)v90->fields.commonPresettingParam;
			    if ( !rainSplashMaxCount )
			      goto LABEL_141;
			    v142 = _mm_unpacklo_ps(v89, v33).m128_u64[0];
			    v143 = v88;
			    v91 = (float *)sub_182F5BF40(&v144, &v142);
			    v92 = (__m128)LODWORD(v185);
			    v93 = (__m128)LODWORD(v186);
			    v94 = *(_QWORD *)v91;
			    v95 = v91[2];
			    v96 = (__m128)*(unsigned __int64 *)v91;
			    v148 = v96.m128_u64[0];
			    v92.m128_f32[0] = v185 - v96.m128_f32[0];
			    v93.m128_f32[0] = v186 - _mm_shuffle_ps(v96, v96, 85).m128_f32[0];
			    v97 = v187 - v91[2];
			    v142 = _mm_unpacklo_ps(v92, v93).m128_u64[0];
			    v143 = v97;
			    v98 = sub_182FAE2B0(&v144, &v142);
			    v99 = (__m128)LODWORD(v189);
			    v100 = *(float *)(v98 + 8);
			    v149 = *(_QWORD *)v98;
			    v101 = (__m128)LODWORD(v188);
			    *(_QWORD *)&v144.x = v94;
			    v101.m128_f32[0] = v188 - *(float *)&v94;
			    v99.m128_f32[0] = v189 - *((float *)&v94 + 1);
			    v142 = _mm_unpacklo_ps(v101, v99).m128_u64[0];
			    v143 = v190 - v95;
			    v102 = sub_182FAE2B0(&v144, &v142);
			    v103 = (__m128)LODWORD(v192);
			    v103.m128_f32[0] = v192 - *((float *)&v94 + 1);
			    v104 = *(float *)(v102 + 8);
			    v148 = *(_QWORD *)v102;
			    v105 = (__m128)LODWORD(v191);
			    v105.m128_f32[0] = v191 - *(float *)&v94;
			    v142 = _mm_unpacklo_ps(v105, v103).m128_u64[0];
			    v143 = v193 - v95;
			    v106 = sub_182FAE2B0(v145, &v142);
			    rainSplashMaxCount = (unsigned __int64)this->fields.rainCommonRenderingParam;
			    v107 = *(float *)(v106 + 8);
			    *(_QWORD *)&v144.x = *(_QWORD *)v106;
			    if ( !rainSplashMaxCount )
			      goto LABEL_141;
			    *(_QWORD *)(rainSplashMaxCount + 136) = v146;
			    *(float *)(rainSplashMaxCount + 144) = v87;
			    v108 = this->fields.rainCommonRenderingParam;
			    if ( !v108 )
			      goto LABEL_141;
			    commonPresettingParam = v108->fields.commonPresettingParam;
			    if ( !commonPresettingParam )
			      goto LABEL_141;
			    v110 = HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
			             commonPresettingParam->fields.rainTemporalTimeThreshold,
			             deltaTime,
			             0LL);
			    v111 = this->fields.rainCommonRenderingParam;
			    if ( !v111 )
			      goto LABEL_141;
			    z = v111->fields.rainDirection.z;
			    v113 = _mm_shuffle_ps(
			             (__m128)*(unsigned __int64 *)&v111->fields.rainDirection.x,
			             (__m128)*(unsigned __int64 *)&v111->fields.rainDirection.x,
			             85).m128_f32[0]
			         * v110;
			    v114 = COERCE_FLOAT(*(_QWORD *)&v111->fields.rainDirection.x) * v110;
			    v145[0] = *(_QWORD *)&v111->fields.rainDirection.x;
			    v115 = (__m128)0x3F800000u;
			    v115.m128_f32[0] = 1.0 - v110;
			    v116 = v115;
			    v117 = v115;
			    v116.m128_f32[0] = (float)((float)(1.0 - v110) * *(float *)&v149) + v114;
			    v117.m128_f32[0] = (float)((float)(1.0 - v110) * *((float *)&v149 + 1)) + v113;
			    v142 = _mm_unpacklo_ps(v116, v117).m128_u64[0];
			    v143 = (float)((float)(1.0 - v110) * v100) + (float)(z * v110);
			    v118 = sub_182FAE2B0(v145, &v142);
			    rainSplashMaxCount = *(unsigned int *)(v118 + 8);
			    *(_QWORD *)&v111->fields.rainDirection.x = *(_QWORD *)v118;
			    LODWORD(v111->fields.rainDirection.z) = rainSplashMaxCount;
			    v119 = this->fields.rainCommonRenderingParam;
			    if ( !v119 )
			      goto LABEL_141;
			    v120 = v119->fields.middleRainDirection.z;
			    v121 = _mm_shuffle_ps(
			             (__m128)*(unsigned __int64 *)&v119->fields.middleRainDirection.x,
			             (__m128)*(unsigned __int64 *)&v119->fields.middleRainDirection.x,
			             85).m128_f32[0]
			         * v110;
			    v122 = COERCE_FLOAT(*(_QWORD *)&v119->fields.middleRainDirection.x) * v110;
			    v145[0] = *(_QWORD *)&v119->fields.middleRainDirection.x;
			    v123 = (__m128)0x3F800000u;
			    v123.m128_f32[0] = 1.0 - v110;
			    v124 = v123;
			    v125 = v123;
			    v124.m128_f32[0] = (float)((float)(1.0 - v110) * *(float *)&v148) + v122;
			    v125.m128_f32[0] = (float)((float)(1.0 - v110) * *((float *)&v148 + 1)) + v121;
			    v142 = _mm_unpacklo_ps(v124, v125).m128_u64[0];
			    v143 = (float)((float)(1.0 - v110) * v104) + (float)(v120 * v110);
			    v126 = sub_182FAE2B0(v145, &v142);
			    rainSplashMaxCount = *(unsigned int *)(v126 + 8);
			    *(_QWORD *)&v119->fields.middleRainDirection.x = *(_QWORD *)v126;
			    LODWORD(v119->fields.middleRainDirection.z) = rainSplashMaxCount;
			    v127 = this->fields.rainCommonRenderingParam;
			    if ( !v127 )
			      goto LABEL_141;
			    v128 = v127->fields.farRainDirection.z;
			    v129 = _mm_shuffle_ps(
			             (__m128)*(unsigned __int64 *)&v127->fields.farRainDirection.x,
			             (__m128)*(unsigned __int64 *)&v127->fields.farRainDirection.x,
			             85).m128_f32[0]
			         * v110;
			    v130 = COERCE_FLOAT(*(_QWORD *)&v127->fields.farRainDirection.x) * v110;
			    v145[0] = *(_QWORD *)&v127->fields.farRainDirection.x;
			    v131 = (__m128)0x3F800000u;
			    v131.m128_f32[0] = 1.0 - v110;
			    v132 = v131;
			    v133 = v131;
			    v132.m128_f32[0] = (float)((float)(1.0 - v110) * v144.x) + v130;
			    v133.m128_f32[0] = (float)((float)(1.0 - v110) * v144.y) + v129;
			    v142 = _mm_unpacklo_ps(v132, v133).m128_u64[0];
			    v143 = (float)((float)(1.0 - v110) * v107) + (float)(v128 * v110);
			    v134 = sub_182FAE2B0(v145, &v142);
			    rainSplashMaxCount = *(unsigned int *)(v134 + 8);
			    *(_QWORD *)&v127->fields.farRainDirection.x = *(_QWORD *)v134;
			    LODWORD(v127->fields.farRainDirection.z) = rainSplashMaxCount;
			    v135 = this->fields.rainCommonRenderingParam;
			    if ( !v135 )
			      goto LABEL_141;
			    v136 = 1.0
			         / fmaxf(
			             fabs(
			               (float)((float)(_mm_shuffle_ps(
			                                 (__m128)*(unsigned __int64 *)&v135->fields.rainDirection.x,
			                                 (__m128)*(unsigned __int64 *)&v135->fields.rainDirection.x,
			                                 85).m128_f32[0]
			                             * -1.0)
			                     + (float)(COERCE_FLOAT(*(_QWORD *)&v135->fields.rainDirection.x) * v33.m128_f32[0]))
			             + (float)(v135->fields.rainDirection.z * v33.m128_f32[0])),
			             0.0099999998);
			    if ( v136 < 1.0 )
			    {
			      v136 = 1.0;
			    }
			    else if ( v136 > 2.0 )
			    {
			      v136 = 2.0;
			    }
			    v135->fields.speed = v136 * v135->fields.speed;
			  }
			}
			
			private void _RequestOcclusionMap() {} // 0x00000001832DD7B0-0x00000001832DD900
			// Void _RequestOcclusionMap()
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_RequestOcclusionMap(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
			  struct ILFixDynamicMethodWrapper_2__Class **static_fields; // rdx
			  struct ILFixDynamicMethodWrapper_2__Class *wrapperArray; // rcx
			  HGCamera *hgCamera; // rbx
			  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rbx
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  bool enableWetness; // al
			  struct ILFixDynamicMethodWrapper_2__Class *v10; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  struct ILFixDynamicMethodWrapper_2__Class *v12; // rax
			  ILFixDynamicMethodWrapper_2 *v13; // rax
			  ILFixDynamicMethodWrapper_2 *v14; // rax
			
			  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  static_fields = (struct ILFixDynamicMethodWrapper_2__Class **)v2->static_fields;
			  wrapperArray = *static_fields;
			  if ( !*static_fields )
			    goto LABEL_23;
			  if ( SLODWORD(wrapperArray->_0.namespaze) > 812 )
			  {
			    if ( !v2->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v2);
			      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    static_fields = (struct ILFixDynamicMethodWrapper_2__Class **)v2->static_fields;
			    v10 = *static_fields;
			    if ( !*static_fields )
			      goto LABEL_23;
			    if ( LODWORD(v10->_0.namespaze) <= 0x32C )
			      goto LABEL_47;
			    if ( v10[17]._0.events )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(812, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			        return;
			      }
			      goto LABEL_23;
			    }
			  }
			  hgCamera = this->fields.hgCamera;
			  if ( !hgCamera )
			    goto LABEL_23;
			  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
			  if ( !v2->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v2);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v2->static_fields;
			  static_fields = (struct ILFixDynamicMethodWrapper_2__Class **)wrapperArray->_0.image;
			  if ( !wrapperArray->_0.image )
			    goto LABEL_23;
			  if ( *((int *)static_fields + 6) <= 813 )
			    goto LABEL_10;
			  if ( !v2->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v2);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  static_fields = (struct ILFixDynamicMethodWrapper_2__Class **)v2->static_fields;
			  v12 = *static_fields;
			  if ( !*static_fields )
			    goto LABEL_23;
			  if ( LODWORD(v12->_0.namespaze) <= 0x32D )
			LABEL_47:
			    sub_1800D2AB0(wrapperArray, static_fields);
			  if ( v12[17]._0.properties )
			  {
			    v13 = IFix::WrappersManagerImpl::GetPatch(813, 0LL);
			    if ( !v13 )
			      goto LABEL_23;
			    enableWetness = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			                      (ILFixDynamicMethodWrapper_20 *)v13,
			                      (Object *)this,
			                      0LL);
			    goto LABEL_16;
			  }
			LABEL_10:
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			  if ( HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL) <= 0 )
			    goto LABEL_17;
			  rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			  if ( !rainCommonRenderingParam )
			    goto LABEL_23;
			  if ( rainCommonRenderingParam->fields.enable )
			    goto LABEL_38;
			  enableWetness = rainCommonRenderingParam->fields.enableWetness;
			LABEL_16:
			  if ( enableWetness )
			  {
			LABEL_38:
			    if ( verticalOcclusionMapManager )
			    {
			      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			        verticalOcclusionMapManager,
			        HGVerticalOcclusionMapManager_RequestUsageType__Enum_RainWetnessOcclusion,
			        0LL);
			      return;
			    }
			LABEL_23:
			    sub_1800D8260(wrapperArray, static_fields);
			  }
			LABEL_17:
			  if ( !verticalOcclusionMapManager )
			    goto LABEL_23;
			  wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  static_fields = (struct ILFixDynamicMethodWrapper_2__Class **)wrapperArray->static_fields->wrapperArray;
			  if ( !static_fields )
			    goto LABEL_23;
			  if ( *((int *)static_fields + 6) <= 816 )
			  {
			LABEL_22:
			    verticalOcclusionMapManager->fields.m_requestType &= ~1u;
			    return;
			  }
			  if ( !wrapperArray->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(wrapperArray);
			    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_23;
			  if ( LODWORD(wrapperArray->_0.namespaze) <= 0x330 )
			    goto LABEL_47;
			  if ( !wrapperArray[17]._0.implementedInterfaces )
			    goto LABEL_22;
			  v14 = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
			  if ( !v14 )
			    goto LABEL_23;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			    (ILFixDynamicMethodWrapper_30 *)v14,
			    (Object *)verticalOcclusionMapManager,
			    1,
			    0LL);
			}
			
			public void UpdateShaderVariables(ref ScriptableRenderContext context, RainWetnessQualityParams qualityParams) {} // 0x0000000189CF0040-0x0000000189CF00CC
			// Void UpdateShaderVariables(ScriptableRenderContext ByRef, HGRainRenderer+RainWetnessQualityParams)
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateShaderVariables(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        ScriptableRenderContext *context,
			        HGRainRenderer_RainWetnessQualityParams *qualityParams,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1575, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1575, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_644(Patch, (Object *)this, context, (Object *)qualityParams, 0LL);
			  }
			  else
			  {
			    HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessShaderVariables(
			      this,
			      this->fields.rainWetnessGlobalProps,
			      0LL);
			    HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainOcclusionMapShaderVariables(
			      this,
			      qualityParams,
			      this->fields.rainWetnessGlobalProps,
			      0LL);
			  }
			}
			
			private void _UpdateWetnessShaderVariables(RainWetnessGlobalProps globalProps) {} // 0x0000000189CF02D8-0x0000000189CF05AC
			// Void _UpdateWetnessShaderVariables(RainWetnessGlobalProps)
			// Hidden C++ exception states: #wind=2
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateWetnessShaderVariables(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        RainWetnessGlobalProps *globalProps,
			        MethodInfo *method)
			{
			  RainWetnessGlobalProps *v3; // rdi
			  Object *v4; // rbx
			  __int64 v5; // rdx
			  List_1_System_UInt64_ *list; // rcx
			  Object__Class *klass; // rsi
			  char v8; // si
			  Object__Class *v9; // rsi
			  Object__Class *v10; // rsi
			  __int64 v11; // rdx
			  HGRainRenderer__StaticFields *static_fields; // rcx
			  int32_t HIGH_QUALITY_WETNESS_MASK; // esi
			  MonitorData *monitor; // rbx
			  __int64 v15; // rcx
			  __int64 v16; // rcx
			  List_1_System_UInt64_ *v17; // rdx
			  __int64 v18; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v20; // rdx
			  __int64 v21; // rcx
			  Il2CppExceptionWrapper *v22; // [rsp+20h] [rbp-48h] BYREF
			  Il2CppExceptionWrapper *v23; // [rsp+28h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v24; // [rsp+30h] [rbp-38h] BYREF
			  List_1_T_Enumerator_System_Object_ v25; // [rsp+48h] [rbp-20h] BYREF
			
			  v3 = globalProps;
			  v4 = (Object *)this;
			  memset(&v25, 0, sizeof(v25));
			  if ( IFix::WrappersManagerImpl::IsPatched(1576, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1576, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v21, v20);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, v4, (Object *)v3, 0LL);
			  }
			  else
			  {
			    klass = v4[3].klass;
			    if ( !klass )
			      sub_1800D8260(list, v5);
			    v8 = BYTE1(klass->_1.actualSize);
			    if ( !v3 )
			      sub_1800D8260(list, v5);
			    v3->fields.enableWetness = v8;
			    v9 = v4[3].klass;
			    if ( !v9 )
			      sub_1800D8260(list, v5);
			    v3->fields.enableWetnessHighQuality = BYTE4(v9->vtable.Equals.method);
			    v10 = v4[3].klass;
			    if ( !v10 )
			      sub_1800D8260(list, v5);
			    if ( !BYTE1(v10->_1.actualSize) )
			      goto LABEL_19;
			    if ( BYTE4(v10->vtable.Equals.method) )
			    {
			      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			      static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
			      HIGH_QUALITY_WETNESS_MASK = static_fields->HIGH_QUALITY_WETNESS_MASK;
			    }
			    else
			    {
			      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			      static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
			      HIGH_QUALITY_WETNESS_MASK = static_fields->LOW_QUALITY_WETNESS_MASK;
			    }
			    monitor = v4[2].monitor;
			    if ( !monitor )
			      sub_1800D8260(static_fields, v11);
			    v25 = *(List_1_T_Enumerator_System_Object_ *)sub_180370FFC(&v24, monitor);
			    v24._list = 0LL;
			    *(_QWORD *)&v24._index = &v25;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v25,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
			      {
			        if ( !v25._current )
			          sub_1800D8250(v15, 0LL);
			        v16 = 7LL;
			        if ( (HIGH_QUALITY_WETNESS_MASK & (__int64)v25._current[1].klass) > 0 )
			          v16 = 6LL;
			        sub_180073530(v16, v25._current, v3);
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v22 )
			    {
			      v24._list = (List_1_System_Object_ *)v22->ex;
			      list = (List_1_System_UInt64_ *)v24._list;
			      if ( v24._list )
			        sub_18007E1E0(v24._list);
			      v3 = globalProps;
			      v4 = (Object *)this;
			LABEL_19:
			      v17 = (List_1_System_UInt64_ *)v4[2].monitor;
			      if ( !v17 )
			        sub_1800D8250(list, 0LL);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v24,
			        v17,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::GetEnumerator);
			      v25 = v24;
			      v24._list = 0LL;
			      *(_QWORD *)&v24._index = &v25;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v25,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::MoveNext) )
			        {
			          if ( !v25._current )
			            sub_1800D8250(v18, 0LL);
			          sub_180073530(7LL, v25._current, v3);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v23 )
			      {
			        v24._list = (List_1_System_Object_ *)v23->ex;
			        if ( v24._list )
			          sub_18007E1E0(v24._list);
			      }
			    }
			  }
			}
			
			private void _UpdateRainOcclusionMapShaderVariables(RainWetnessQualityParams qualityParams, RainWetnessGlobalProps globalProps) {} // 0x0000000189CF00CC-0x0000000189CF02D8
			// Void _UpdateRainOcclusionMapShaderVariables(HGRainRenderer+RainWetnessQualityParams, RainWetnessGlobalProps)
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::_UpdateRainOcclusionMapShaderVariables(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        HGRainRenderer_RainWetnessQualityParams *qualityParams,
			        RainWetnessGlobalProps *globalProps,
			        MethodInfo *method)
			{
			  __int64 v7; // rdx
			  RainCommonRenderingParam *commonPresettingParam; // rcx
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  Vector4__Array *rainWetnessGlobalParams; // rbp
			  float rippleFrequency; // xmm8_4
			  float rippleWaveSpeed; // xmm6_4
			  float acneFixNormalBiasScale; // xmm7_4
			  Vector4 *v14; // rax
			  Vector4__Array *v15; // rsi
			  int32_t RainOcclusionMaskSamplePosJitterMode; // ebp
			  int32_t RainOcclusionMaskSampleMode; // eax
			  Vector4 *v18; // rax
			  RainCommonRenderingParam *v19; // rax
			  Vector4__Array *v20; // rbx
			  float *v21; // r9
			  Vector4 *v22; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Vector4 v24[2]; // [rsp+30h] [rbp-48h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1579, 0LL) )
			  {
			    if ( globalProps )
			    {
			      rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			      rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
			      if ( rainCommonRenderingParam )
			      {
			        commonPresettingParam = (RainCommonRenderingParam *)rainCommonRenderingParam->fields.commonPresettingParam;
			        if ( commonPresettingParam )
			        {
			          rippleFrequency = commonPresettingParam->fields.rippleFrequency;
			          if ( qualityParams )
			          {
			            rippleWaveSpeed = commonPresettingParam->fields.rippleWaveSpeed;
			            acneFixNormalBiasScale = qualityParams->fields.acneFixNormalBiasScale;
			            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
			            v14 = HG::Rendering::Runtime::HGUtils::PackVector4(
			                    v24,
			                    acneFixNormalBiasScale * rippleFrequency,
			                    rippleWaveSpeed,
			                    0LL);
			            if ( rainWetnessGlobalParams )
			            {
			              v24[0] = *v14;
			              sub_18003FEF0(rainWetnessGlobalParams, 3LL, v24);
			              v15 = globalProps->fields.rainWetnessGlobalParams;
			              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			              RainOcclusionMaskSamplePosJitterMode = HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSamplePosJitterMode(0LL);
			              RainOcclusionMaskSampleMode = HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL);
			              commonPresettingParam = this->fields.rainCommonRenderingParam;
			              if ( commonPresettingParam )
			              {
			                v18 = HG::Rendering::Runtime::HGUtils::PackVector4(
			                        v24,
			                        (float)RainOcclusionMaskSamplePosJitterMode,
			                        (float)RainOcclusionMaskSampleMode,
			                        commonPresettingParam->fields.rainCenterBias,
			                        0LL);
			                if ( v15 )
			                {
			                  v24[0] = *v18;
			                  sub_18003FEF0(v15, 4LL, v24);
			                  v19 = this->fields.rainCommonRenderingParam;
			                  v20 = globalProps->fields.rainWetnessGlobalParams;
			                  if ( v19 )
			                  {
			                    v21 = (float *)v19->fields.commonPresettingParam;
			                    if ( v21 )
			                    {
			                      v22 = HG::Rendering::Runtime::HGUtils::PackVector4(
			                              v24,
			                              v21[78],
			                              v21[79],
			                              v21[80],
			                              (float)this->fields.cameraMask,
			                              0LL);
			                      if ( v20 )
			                      {
			                        v24[0] = *v22;
			                        sub_18003FEF0(v20, 7LL, v24);
			                        return;
			                      }
			                    }
			                  }
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_14:
			    sub_1800D8260(commonPresettingParam, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1579, 0LL);
			  if ( !Patch )
			    goto LABEL_14;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			    (ILFixDynamicMethodWrapper_30 *)Patch,
			    (Object *)this,
			    (Object *)qualityParams,
			    (Object *)globalProps,
			    0LL);
			}
			
			public bool ShouldRequestRainOcclusionMap() => default; // 0x00000001832DDAD0-0x00000001832DDB60
			// Boolean ShouldRequestRainOcclusionMap()
			bool HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::ShouldRequestRainOcclusionMap(
			        HGRainRenderer_RainWetnessRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  RainCommonRenderingParam *rainCommonRenderingParam; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_11;
			  if ( wrapperArray->max_length.size > 813 )
			  {
			    if ( !v3->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v3);
			      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			    if ( !v3 )
			      goto LABEL_11;
			    if ( LODWORD(v3->_0.namespaze) <= 0x32D )
			      sub_1800D2AB0(v3, wrapperArray);
			    if ( v3[17]._0.properties )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(813, 0LL);
			      if ( Patch )
			        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			                 (ILFixDynamicMethodWrapper_20 *)Patch,
			                 (Object *)this,
			                 0LL);
			LABEL_11:
			      sub_1800D8260(v3, wrapperArray);
			    }
			  }
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRainRenderer->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			  if ( HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(0LL) <= 0 )
			    return 0;
			  rainCommonRenderingParam = this->fields.rainCommonRenderingParam;
			  if ( !rainCommonRenderingParam )
			    goto LABEL_11;
			  return rainCommonRenderingParam->fields.enable || rainCommonRenderingParam->fields.enableWetness;
			}
			
		}
	
		private class RainWetnessQualityParams // TypeDefIndex: 37670
		{
			// Fields
			public bool enableRainWetnessHighQuality; // 0x10
			public bool enableMiddleRain; // 0x11
			public bool enableRainWave; // 0x12
			public bool enableRainLighting; // 0x13
			public float screenRainDropPercent; // 0x14
			public int rainSplashMaxCount; // 0x18
			public float acneFixNormalBiasScale; // 0x1C
			public int sceneEffectRainLayerCount; // 0x20
	
			// Constructors
			public RainWetnessQualityParams() {} // 0x0000000184DA2190-0x0000000184DA21B0
			// HGRainRenderer+RainWetnessQualityParams()
			void HG::Rendering::Runtime::HGRainRenderer::RainWetnessQualityParams::RainWetnessQualityParams(
			        HGRainRenderer_RainWetnessQualityParams *this,
			        MethodInfo *method)
			{
			  this->fields.screenRainDropPercent = 1.0;
			  this->fields.rainSplashMaxCount = 1000;
			  this->fields.acneFixNormalBiasScale = 1.0;
			  this->fields.sceneEffectRainLayerCount = 1;
			}
			
		}
	
		// Constructors
		public HGRainRenderer() {} // 0x00000001831D39A0-0x00000001831D3A70
		// HGRainRenderer()
		void HG::Rendering::Runtime::HGRainRenderer::HGRainRenderer(HGRainRenderer *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  RainCommonPreSettingParam *v10; // rax
		  RainCommonPreSettingParam *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  RainCommonResources *v15; // rax
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  __int64 v18; // rax
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>);
		  v6 = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)v3;
		  if ( !v3 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::List);
		  this->fields.m_rainWetnessRenderSeqs = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v21);
		  v10 = (RainCommonPreSettingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonPreSettingParam);
		  v11 = v10;
		  if ( !v10
		    || (HG::Rendering::Runtime::Rain::RainCommonPreSettingParam::RainCommonPreSettingParam(v10, 0LL),
		        this->fields.m_rainCommonPreSettingParam = v11,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainCommonPreSettingParam, v12, v13, v14, v22),
		        (v15 = (RainCommonResources *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonResources)) == 0LL)
		    || (this->fields.m_rainCommonResources = v15,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainCommonResources, v4, v16, v17, v23),
		        (v18 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer::RainWetnessQualityParams)) == 0) )
		  {
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v18 + 20) = 1065353216;
		  *(_DWORD *)(v18 + 24) = 1000;
		  *(_DWORD *)(v18 + 28) = 1065353216;
		  *(_DWORD *)(v18 + 32) = 1;
		  this->fields.m_qualityParams = (HGRainRenderer_RainWetnessQualityParams *)v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_qualityParams, v4, v19, v20, v24);
		}
		
		static HGRainRenderer() {} // 0x0000000184B8B2C0-0x0000000184B8B410
		// HGRainRenderer()
		void HG::Rendering::Runtime::HGRainRenderer::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  MethodInfo *v7; // [rsp+20h] [rbp-8h]
		  MethodInfo *v8; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->EDITOR_KW = (String *)"HG_EDITOR";
		  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields, v1, v2, v3, v7);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRainRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->LIGHTING_KW = (String *)"RAIN_LIGHTING";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->LIGHTING_KW,
		    v5,
		    v6,
		    v4,
		    v8);
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCENE_DROP_MASK = -9;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCREEN_FX_DROP_MASK = 8;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->HIGH_QUALITY_WETNESS_MASK = -1;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->LOW_QUALITY_WETNESS_MASK = -7;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->UPDATE_DELTA_TIME_THRESHOLD = 0.033;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->FOV_FADE_HIGHERTHRESHOLD = 20.0;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->FOV_FADE_LOWERTHRESHOLD = 10.0;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->FAR_RAIN_RENDERQUEUE = 3000;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCENEEFFECT_RAIN_RENDERQUEUE = 3003;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->RAIN_SPLASH_RENDERQUEUE = 3007;
		  TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields->SCREEN_RAIN_DROP_RENDERQUEUE = 3000;
		}
		
	
		// Methods
		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources, HGSettingParameters settingParameters) {} // 0x00000001847C7C70-0x00000001847C7E90
		// Void PrepareResources(HGRenderPipelineRuntimeResources, HGSettingParameters)
		void HG::Rendering::Runtime::HGRainRenderer::PrepareResources(
		        HGRainRenderer *this,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Type *farRainSpindleMesh; // rdx
		  RainCommonResources *m_rainCommonResources; // rcx
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rsi
		  HGRainPresettingAsset *rainPresettingAsset; // rsi
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  struct Object_1__Class *v13; // rcx
		  HGRenderPipelineRuntimeResources_AssetResources *v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *v17; // rax
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *v20; // rax
		  RainCommonResources *v21; // rsi
		  Mesh *ScreenDropQuadSeq; // rax
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v30; // rax
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v33; // rax
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v36; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-18h]
		  MethodInfo *methode; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodf; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodg; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodh; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1572, 0LL) )
		  {
		    if ( defaultResources )
		    {
		      assets = defaultResources->fields.assets;
		      if ( assets )
		      {
		        rainPresettingAsset = assets->fields.rainPresettingAsset;
		        HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
		        v13 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v13 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v13 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( rainPresettingAsset )
		        {
		          if ( !v13->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v13);
		          if ( rainPresettingAsset->fields._._.m_CachedPtr )
		          {
		            this->fields.m_rainCommonPreSettingParam = rainPresettingAsset->fields.rainCommonPreSettingParam;
		            sub_18002D1B0(
		              (SingleFieldAccessor *)&this->fields.m_rainCommonPreSettingParam,
		              farRainSpindleMesh,
		              v11,
		              v12,
		              methoda);
		          }
		        }
		        v14 = defaultResources->fields.assets;
		        m_rainCommonResources = this->fields.m_rainCommonResources;
		        if ( v14 )
		        {
		          farRainSpindleMesh = (Type *)v14->fields.farRainSpindleMesh;
		          if ( m_rainCommonResources )
		          {
		            m_rainCommonResources->fields.farRainSpindleMesh = (Mesh *)farRainSpindleMesh;
		            sub_18002D1B0((SingleFieldAccessor *)&m_rainCommonResources->fields, farRainSpindleMesh, v11, v12, methoda);
		            v17 = defaultResources->fields.assets;
		            m_rainCommonResources = this->fields.m_rainCommonResources;
		            if ( v17 )
		            {
		              farRainSpindleMesh = (Type *)v17->fields.sceneEffectRainMesh;
		              if ( m_rainCommonResources )
		              {
		                m_rainCommonResources->fields.sceneEffectRainMesh = (Mesh *)farRainSpindleMesh;
		                sub_18002D1B0(
		                  (SingleFieldAccessor *)&m_rainCommonResources->fields.sceneEffectRainMesh,
		                  farRainSpindleMesh,
		                  v15,
		                  v16,
		                  methodb);
		                v20 = defaultResources->fields.assets;
		                m_rainCommonResources = this->fields.m_rainCommonResources;
		                if ( v20 )
		                {
		                  farRainSpindleMesh = (Type *)v20->fields.rainSplashMesh;
		                  if ( m_rainCommonResources )
		                  {
		                    m_rainCommonResources->fields.rainSplashMesh = (Mesh *)farRainSpindleMesh;
		                    sub_18002D1B0(
		                      (SingleFieldAccessor *)&m_rainCommonResources->fields.rainSplashMesh,
		                      farRainSpindleMesh,
		                      v18,
		                      v19,
		                      methodc);
		                    v21 = this->fields.m_rainCommonResources;
		                    ScreenDropQuadSeq = HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropQuadSeq(0LL);
		                    if ( v21 )
		                    {
		                      v21->fields.screenDropFxMesh = ScreenDropQuadSeq;
		                      sub_18002D1B0(
		                        (SingleFieldAccessor *)&v21->fields.screenDropFxMesh,
		                        farRainSpindleMesh,
		                        v23,
		                        v24,
		                        methodd);
		                      shaders = defaultResources->fields.shaders;
		                      m_rainCommonResources = this->fields.m_rainCommonResources;
		                      if ( shaders )
		                      {
		                        farRainSpindleMesh = (Type *)shaders->fields.farRainPS;
		                        if ( m_rainCommonResources )
		                        {
		                          m_rainCommonResources->fields.farRainShader = (Shader *)farRainSpindleMesh;
		                          sub_18002D1B0(
		                            (SingleFieldAccessor *)&m_rainCommonResources->fields.farRainShader,
		                            farRainSpindleMesh,
		                            v25,
		                            v26,
		                            methode);
		                          v30 = defaultResources->fields.shaders;
		                          m_rainCommonResources = this->fields.m_rainCommonResources;
		                          if ( v30 )
		                          {
		                            farRainSpindleMesh = (Type *)v30->fields.sceneEffectRainPS;
		                            if ( m_rainCommonResources )
		                            {
		                              m_rainCommonResources->fields.sceneEffectRainShader = (Shader *)farRainSpindleMesh;
		                              sub_18002D1B0(
		                                (SingleFieldAccessor *)&m_rainCommonResources->fields.sceneEffectRainShader,
		                                farRainSpindleMesh,
		                                v28,
		                                v29,
		                                methodf);
		                              v33 = defaultResources->fields.shaders;
		                              m_rainCommonResources = this->fields.m_rainCommonResources;
		                              if ( v33 )
		                              {
		                                farRainSpindleMesh = (Type *)v33->fields.rainSplashShader;
		                                if ( m_rainCommonResources )
		                                {
		                                  m_rainCommonResources->fields.rainSplashShader = (Shader *)farRainSpindleMesh;
		                                  sub_18002D1B0(
		                                    (SingleFieldAccessor *)&m_rainCommonResources->fields.rainSplashShader,
		                                    farRainSpindleMesh,
		                                    v31,
		                                    v32,
		                                    methodg);
		                                  v36 = defaultResources->fields.shaders;
		                                  m_rainCommonResources = this->fields.m_rainCommonResources;
		                                  if ( v36 )
		                                  {
		                                    farRainSpindleMesh = (Type *)v36->fields.screenRainDropFXShader;
		                                    if ( m_rainCommonResources )
		                                    {
		                                      m_rainCommonResources->fields.screenRainDropFXShader = (Shader *)farRainSpindleMesh;
		                                      sub_18002D1B0(
		                                        (SingleFieldAccessor *)&m_rainCommonResources->fields.screenRainDropFXShader,
		                                        farRainSpindleMesh,
		                                        v34,
		                                        v35,
		                                        methodh);
		                                      return;
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(m_rainCommonResources, farRainSpindleMesh);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1572, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)defaultResources,
		    (Object *)settingParameters,
		    0LL);
		}
		
		internal void RainAndWetnessPipelineUpdate(HGSettingParameters settingParameters) {} // 0x0000000182EE0B60-0x0000000182EE0D10
		// Void RainAndWetnessPipelineUpdate(HGSettingParameters)
		void HG::Rendering::Runtime::HGRainRenderer::RainAndWetnessPipelineUpdate(
		        HGRainRenderer *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v4; // rbx
		  void *items; // rcx
		  __int64 v6; // r8
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *m_rainWetnessRenderSeqs; // rbx
		  int32_t v8; // ebx
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v9; // rax
		  Camera *camera; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *Item; // rax
		
		  v4 = (Object *)settingParameters;
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **((_QWORD **)items + 23);
		  if ( !v6 )
		    goto LABEL_25;
		  if ( *(int *)(v6 + 24) <= 648 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  settingParameters = (HGSettingParameters *)**((_QWORD **)items + 23);
		  if ( !settingParameters )
		LABEL_25:
		    sub_1800D8260(items, settingParameters);
		  if ( LODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 0x288 )
		LABEL_28:
		    sub_1800D2AB0(items, settingParameters);
		  if ( settingParameters[2].fields._rayTracingReflectionRTQuality1_k__BackingField )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(648, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, v4, 0LL);
		      return;
		    }
		    goto LABEL_25;
		  }
		LABEL_5:
		  HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(this, (HGSettingParameters *)v4, 0LL);
		  m_rainWetnessRenderSeqs = this->fields.m_rainWetnessRenderSeqs;
		  if ( !m_rainWetnessRenderSeqs )
		    goto LABEL_25;
		  v8 = m_rainWetnessRenderSeqs->fields._size - 1;
		  if ( v8 >= 0 )
		  {
		    while ( 1 )
		    {
		      v9 = this->fields.m_rainWetnessRenderSeqs;
		      if ( !v9 )
		        goto LABEL_25;
		      if ( (unsigned int)v8 >= v9->fields._size )
		        goto LABEL_42;
		      items = v9->fields._items;
		      if ( !items )
		        goto LABEL_25;
		      if ( (unsigned int)v8 >= *((_DWORD *)items + 6) )
		        goto LABEL_28;
		      if ( !*((_QWORD *)items + v8 + 4) )
		        break;
		      HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PerFrameClear(
		        this->fields.m_rainWetnessRenderSeqs->fields._items->vector[v8],
		        0LL);
		      items = this->fields.m_rainWetnessRenderSeqs;
		      if ( !items )
		        goto LABEL_25;
		      if ( (unsigned int)v8 >= *((_DWORD *)items + 6) )
		LABEL_42:
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = (void *)*((_QWORD *)items + 2);
		      if ( !items )
		        goto LABEL_25;
		      if ( (unsigned int)v8 >= *((_DWORD *)items + 6) )
		        goto LABEL_28;
		      settingParameters = (HGSettingParameters *)*((_QWORD *)items + v8 + 4);
		      if ( !settingParameters )
		        goto LABEL_25;
		      if ( !settingParameters->fields._cullingViewScreenSizeMin_k__BackingField )
		        goto LABEL_36;
		      items = TypeInfo::UnityEngine::Object;
		      camera = this->fields.m_rainWetnessRenderSeqs->fields._items->vector[v8]->fields.hgCamera->fields.camera;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        items = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          items = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !camera )
		        goto LABEL_36;
		      if ( !*((_DWORD *)items + 56) )
		        il2cpp_runtime_class_init_1(items);
		      if ( !camera->fields._._._.m_CachedPtr )
		      {
		LABEL_36:
		        items = this->fields.m_rainWetnessRenderSeqs;
		        if ( !items )
		          goto LABEL_25;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)items,
		                 v8,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::get_Item);
		        if ( !Item )
		          goto LABEL_25;
		        HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
		          (HGRainRenderer_RainWetnessRenderSeq *)Item,
		          0LL);
		        items = this->fields.m_rainWetnessRenderSeqs;
		        if ( !items )
		          goto LABEL_25;
		        goto LABEL_41;
		      }
		LABEL_23:
		      if ( --v8 < 0 )
		        return;
		    }
		    items = this->fields.m_rainWetnessRenderSeqs;
		LABEL_41:
		    System::Collections::Generic::List<System::Object>::RemoveAt(
		      (List_1_System_Object_ *)items,
		      v8,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::RemoveAt);
		    goto LABEL_23;
		  }
		}
		
		private void _UpdateQualitySettings(HGSettingParameters settingParameters) {} // 0x000000018350DEA0-0x000000018350E320
		// Void _UpdateQualitySettings(HGSettingParameters)
		void HG::Rendering::Runtime::HGRainRenderer::_UpdateQualitySettings(
		        HGRainRenderer *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGRainAndWetnessSettingParameters *rainAndWetness_k__BackingField; // rbx
		  HGVerticalOcclusionMapSettingParameters *verticalOcclusionMap_k__BackingField; // r15
		  HGRainRenderer_RainWetnessQualityParams *m_qualityParams; // rbp
		  SettingParameter_1_System_Boolean_ *EnableRainWetnessHighQuality_k__BackingField; // rdi
		  struct MethodInfo *v11; // r14
		  Il2CppClass *klass; // rax
		  SettingParameter_1_System_Int32_ *RainSplashMaxCount_k__BackingField; // r14
		  HGRainRenderer_RainWetnessQualityParams *v14; // rdi
		  struct MethodInfo *v15; // rbp
		  Il2CppClass *v16; // rax
		  HGRainRenderer_RainWetnessQualityParams *v17; // r14
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rdi
		  struct MethodInfo *v19; // rbp
		  Il2CppClass *v20; // rax
		  int v21; // eax
		  SettingParameter_1_System_Boolean_ *EnableMiddleDistRain_k__BackingField; // r14
		  HGRainRenderer_RainWetnessQualityParams *v23; // rdi
		  struct MethodInfo *v24; // rbp
		  Il2CppClass *v25; // rax
		  SettingParameter_1_System_Boolean_ *EnableRainWave_k__BackingField; // rbp
		  HGRainRenderer_RainWetnessQualityParams *v27; // rdi
		  struct MethodInfo *v28; // r14
		  Il2CppClass *v29; // rax
		  SettingParameter_1_System_Boolean_ *EnableRainLighting_k__BackingField; // rbp
		  HGRainRenderer_RainWetnessQualityParams *v31; // rdi
		  struct MethodInfo *v32; // r14
		  Il2CppClass *v33; // rax
		  SettingParameter_1_System_Single_ *ScreenRainDropPercent_k__BackingField; // rbp
		  HGRainRenderer_RainWetnessQualityParams *v35; // rdi
		  struct MethodInfo *v36; // r14
		  Il2CppClass *v37; // rax
		  SettingParameter_1_System_Int32_ *SceneEffectRainLayerCount_k__BackingField; // rbx
		  HGRainRenderer_RainWetnessQualityParams *v39; // rdi
		  struct MethodInfo *v40; // rsi
		  Il2CppClass *v41; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  __int64 v46; // rax
		  __int64 v47; // rax
		  __int64 v48; // rax
		  __int64 v49; // rax
		  __int64 v50; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_75;
		  if ( wrapperArray->max_length.size <= 649 )
		    goto LABEL_73;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_75;
		  if ( LODWORD(v5->_0.namespaze) <= 0x289 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( !v5[13].vtable.Finalize.method )
		  {
		LABEL_73:
		    if ( settingParameters )
		    {
		      rainAndWetness_k__BackingField = settingParameters->fields._rainAndWetness_k__BackingField;
		      verticalOcclusionMap_k__BackingField = settingParameters->fields._verticalOcclusionMap_k__BackingField;
		      m_qualityParams = this->fields.m_qualityParams;
		      if ( rainAndWetness_k__BackingField )
		      {
		        EnableRainWetnessHighQuality_k__BackingField = rainAndWetness_k__BackingField->fields._EnableRainWetnessHighQuality_k__BackingField;
		        v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		        if ( EnableRainWetnessHighQuality_k__BackingField )
		        {
		          klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		          if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		          {
		            v43 = sub_18011C4C0(v11->klass);
		            (**(void (***)(void))(*(_QWORD *)(v43 + 192) + 48LL))();
		          }
		          v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v11->klass;
		          if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		            sub_1800360B0(v5, wrapperArray);
		          if ( m_qualityParams )
		          {
		            m_qualityParams->fields.enableRainWetnessHighQuality = EnableRainWetnessHighQuality_k__BackingField->fields._paramValue_k__BackingField;
		            RainSplashMaxCount_k__BackingField = rainAndWetness_k__BackingField->fields._RainSplashMaxCount_k__BackingField;
		            v14 = this->fields.m_qualityParams;
		            v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		            if ( RainSplashMaxCount_k__BackingField )
		            {
		              v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		              if ( ((__int64)v16->vtable[0].methodPtr & 1) == 0 )
		                sub_1800360B0(
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass,
		                  wrapperArray);
		              if ( !*((_QWORD *)v16->rgctx_data[6].rgctxDataDummy + 4) )
		              {
		                v44 = sub_18011C4C0(v15->klass);
		                (**(void (***)(void))(*(_QWORD *)(v44 + 192) + 48LL))();
		              }
		              v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v15->klass;
		              if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                sub_1800360B0(v5, wrapperArray);
		              if ( v14 )
		              {
		                v14->fields.rainSplashMaxCount = RainSplashMaxCount_k__BackingField->fields._paramValue_k__BackingField;
		                v17 = this->fields.m_qualityParams;
		                if ( verticalOcclusionMap_k__BackingField )
		                {
		                  DepthOcclusionMapRange_k__BackingField = verticalOcclusionMap_k__BackingField->fields._DepthOcclusionMapRange_k__BackingField;
		                  v19 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		                  if ( DepthOcclusionMapRange_k__BackingField )
		                  {
		                    v20 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		                    if ( ((__int64)v20->vtable[0].methodPtr & 1) == 0 )
		                      sub_1800360B0(
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass,
		                        wrapperArray);
		                    if ( !*((_QWORD *)v20->rgctx_data[6].rgctxDataDummy + 4) )
		                    {
		                      v45 = sub_18011C4C0(v19->klass);
		                      (**(void (***)(void))(*(_QWORD *)(v45 + 192) + 48LL))();
		                    }
		                    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v19->klass;
		                    if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                      sub_1800360B0(v5, wrapperArray);
		                    v21 = (float)DepthOcclusionMapRange_k__BackingField->fields._paramValue_k__BackingField <= 63.0
		                        ? 2
		                        : 1;
		                    if ( v17 )
		                    {
		                      v17->fields.acneFixNormalBiasScale = (float)v21;
		                      EnableMiddleDistRain_k__BackingField = rainAndWetness_k__BackingField->fields._EnableMiddleDistRain_k__BackingField;
		                      v23 = this->fields.m_qualityParams;
		                      v24 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		                      if ( EnableMiddleDistRain_k__BackingField )
		                      {
		                        v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		                        if ( ((__int64)v25->vtable[0].methodPtr & 1) == 0 )
		                          sub_1800360B0(
		                            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass,
		                            wrapperArray);
		                        if ( !*((_QWORD *)v25->rgctx_data[6].rgctxDataDummy + 4) )
		                        {
		                          v46 = sub_18011C4C0(v24->klass);
		                          (**(void (***)(void))(*(_QWORD *)(v46 + 192) + 48LL))();
		                        }
		                        v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v24->klass;
		                        if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                          sub_1800360B0(v5, wrapperArray);
		                        if ( v23 )
		                        {
		                          v23->fields.enableMiddleRain = EnableMiddleDistRain_k__BackingField->fields._paramValue_k__BackingField;
		                          EnableRainWave_k__BackingField = rainAndWetness_k__BackingField->fields._EnableRainWave_k__BackingField;
		                          v27 = this->fields.m_qualityParams;
		                          v28 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		                          if ( EnableRainWave_k__BackingField )
		                          {
		                            v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		                            if ( ((__int64)v29->vtable[0].methodPtr & 1) == 0 )
		                              sub_1800360B0(
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass,
		                                wrapperArray);
		                            if ( !*((_QWORD *)v29->rgctx_data[6].rgctxDataDummy + 4) )
		                            {
		                              v47 = sub_18011C4C0(v28->klass);
		                              (**(void (***)(void))(*(_QWORD *)(v47 + 192) + 48LL))();
		                            }
		                            v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v28->klass;
		                            if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                              sub_1800360B0(v5, wrapperArray);
		                            if ( v27 )
		                            {
		                              v27->fields.enableRainWave = EnableRainWave_k__BackingField->fields._paramValue_k__BackingField;
		                              EnableRainLighting_k__BackingField = rainAndWetness_k__BackingField->fields._EnableRainLighting_k__BackingField;
		                              v31 = this->fields.m_qualityParams;
		                              v32 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		                              if ( EnableRainLighting_k__BackingField )
		                              {
		                                v33 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		                                if ( ((__int64)v33->vtable[0].methodPtr & 1) == 0 )
		                                  sub_1800360B0(
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass,
		                                    wrapperArray);
		                                if ( !*((_QWORD *)v33->rgctx_data[6].rgctxDataDummy + 4) )
		                                {
		                                  v48 = sub_18011C4C0(v32->klass);
		                                  (**(void (***)(void))(*(_QWORD *)(v48 + 192) + 48LL))();
		                                }
		                                v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v32->klass;
		                                if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                                  sub_1800360B0(v5, wrapperArray);
		                                if ( v31 )
		                                {
		                                  v31->fields.enableRainLighting = EnableRainLighting_k__BackingField->fields._paramValue_k__BackingField;
		                                  ScreenRainDropPercent_k__BackingField = rainAndWetness_k__BackingField->fields._ScreenRainDropPercent_k__BackingField;
		                                  v35 = this->fields.m_qualityParams;
		                                  v36 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		                                  if ( ScreenRainDropPercent_k__BackingField )
		                                  {
		                                    v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		                                    if ( ((__int64)v37->vtable[0].methodPtr & 1) == 0 )
		                                      sub_1800360B0(
		                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass,
		                                        wrapperArray);
		                                    if ( !*((_QWORD *)v37->rgctx_data[6].rgctxDataDummy + 4) )
		                                    {
		                                      v49 = sub_18011C4C0(v36->klass);
		                                      (**(void (***)(void))(*(_QWORD *)(v49 + 192) + 48LL))();
		                                    }
		                                    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v36->klass;
		                                    if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                                      sub_1800360B0(v5, wrapperArray);
		                                    if ( v35 )
		                                    {
		                                      v35->fields.screenRainDropPercent = ScreenRainDropPercent_k__BackingField->fields._paramValue_k__BackingField;
		                                      SceneEffectRainLayerCount_k__BackingField = rainAndWetness_k__BackingField->fields._SceneEffectRainLayerCount_k__BackingField;
		                                      v39 = this->fields.m_qualityParams;
		                                      v40 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		                                      if ( SceneEffectRainLayerCount_k__BackingField )
		                                      {
		                                        v41 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		                                        if ( ((__int64)v41->vtable[0].methodPtr & 1) == 0 )
		                                          sub_1800360B0(
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass,
		                                            wrapperArray);
		                                        if ( !*((_QWORD *)v41->rgctx_data[6].rgctxDataDummy + 4) )
		                                        {
		                                          v50 = sub_18011C4C0(v40->klass);
		                                          (**(void (***)(void))(*(_QWORD *)(v50 + 192) + 48LL))();
		                                        }
		                                        v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v40->klass;
		                                        if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                                          sub_1800360B0(v5, wrapperArray);
		                                        if ( v39 )
		                                        {
		                                          v39->fields.sceneEffectRainLayerCount = SceneEffectRainLayerCount_k__BackingField->fields._paramValue_k__BackingField;
		                                          return;
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_75:
		    sub_1800D8260(v5, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(649, 0LL);
		  if ( !Patch )
		    goto LABEL_75;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)settingParameters,
		    0LL);
		}
		
		internal void UpdateRainAndWetnessData(HGCamera camera, ref ScriptableRenderContext renderContext) {} // 0x0000000182EE0820-0x0000000182EE0B60
		// Void UpdateRainAndWetnessData(HGCamera, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(
		        HGRainRenderer *this,
		        HGCamera *camera,
		        ScriptableRenderContext *renderContext,
		        MethodInfo *method)
		{
		  int32_t v4; // ebx
		  void *items; // rcx
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *m_rainWetnessRenderSeqs; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v12; // rax
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v13; // rax
		  __int64 v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v18; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v19; // rsi
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v23; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v24; // rsi
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  RainCommonRenderingParam *v28; // rax
		  SingleFieldAccessor *v29; // rsi
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  RainWetnessGlobalProps *v36; // rax
		  RainWetnessGlobalProps *v37; // rsi
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v41; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v43; // rax
		  bool v44; // al
		  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-28h]
		  MethodInfo *methode; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodg; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodf; // [rsp+20h] [rbp-28h]
		  int32_t P3; // [rsp+30h] [rbp-18h] BYREF
		  __int128 P2; // [rsp+38h] [rbp-10h] BYREF
		
		  v4 = 0;
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)&P2 = 0LL;
		  P3 = 0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_rainWetnessRenderSeqs = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_rainWetnessRenderSeqs )
		    goto LABEL_35;
		  if ( m_rainWetnessRenderSeqs->fields._size > 795 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_rainWetnessRenderSeqs = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)**((_QWORD **)items + 23);
		    if ( !m_rainWetnessRenderSeqs )
		      goto LABEL_35;
		    if ( m_rainWetnessRenderSeqs->fields._size <= 0x31Bu )
		      goto LABEL_44;
		    if ( m_rainWetnessRenderSeqs[159].fields._syncRoot )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(795, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(Patch, (Object *)this, (Object *)camera, renderContext, 0LL);
		        return;
		      }
		      goto LABEL_35;
		    }
		  }
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_rainWetnessRenderSeqs = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_rainWetnessRenderSeqs )
		    goto LABEL_35;
		  if ( m_rainWetnessRenderSeqs->fields._size <= 544 )
		    goto LABEL_9;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_rainWetnessRenderSeqs = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_rainWetnessRenderSeqs )
		    goto LABEL_35;
		  if ( m_rainWetnessRenderSeqs->fields._size <= 0x220u )
		    goto LABEL_44;
		  if ( *(_QWORD *)&m_rainWetnessRenderSeqs[109].fields._size )
		  {
		    v43 = IFix::WrappersManagerImpl::GetPatch(544, 0LL);
		    if ( !v43 )
		      goto LABEL_35;
		    v44 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(
		            v43,
		            (Object *)this,
		            (Object *)camera,
		            (HGRainRenderer_RainWetnessRenderSeq **)&P2,
		            &P3,
		            0LL);
		    v4 = P3;
		    if ( v44 || P3 >= 0 )
		      goto LABEL_22;
		  }
		  else
		  {
		LABEL_9:
		    *(_QWORD *)&P2 = 0LL;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&P2,
		      (Type *)m_rainWetnessRenderSeqs,
		      (PropertyInfo_1 *)renderContext,
		      (Int32__Array **)method,
		      methoda);
		    if ( camera && this->fields.m_rainWetnessRenderSeqs && this->fields.m_rainWetnessRenderSeqs->fields._size > 0 )
		    {
		      m_rainWetnessRenderSeqs = this->fields.m_rainWetnessRenderSeqs;
		      while ( 1 )
		      {
		        if ( v4 >= m_rainWetnessRenderSeqs->fields._size )
		          goto LABEL_36;
		        if ( (unsigned int)v4 >= m_rainWetnessRenderSeqs->fields._size )
		          goto LABEL_62;
		        items = m_rainWetnessRenderSeqs->fields._items;
		        if ( !items )
		          goto LABEL_35;
		        if ( (unsigned int)v4 >= *((_DWORD *)items + 6) )
		          goto LABEL_44;
		        if ( *((_QWORD *)items + v4 + 4) )
		        {
		          items = (void *)*((_QWORD *)items + v4 + 4);
		          if ( *((HGCamera **)items + 2) == camera )
		            break;
		        }
		        ++v4;
		      }
		      if ( v4 > -1 )
		      {
		        if ( !m_rainWetnessRenderSeqs )
		          goto LABEL_35;
		        *(_QWORD *)&P2 = m_rainWetnessRenderSeqs->fields._items->vector[v4];
		        sub_18002D1B0((SingleFieldAccessor *)&P2, (Type *)m_rainWetnessRenderSeqs, v10, v11, methodb);
		        goto LABEL_22;
		      }
		    }
		  }
		LABEL_36:
		  v14 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq);
		  v17 = v14;
		  if ( !v14 )
		    goto LABEL_35;
		  *(_DWORD *)(v14 + 24) = -1;
		  *(_QWORD *)(v14 + 16) = camera;
		  sub_18002D1B0((SingleFieldAccessor *)(v14 + 16), (Type *)m_rainWetnessRenderSeqs, v15, v16, methodb);
		  v18 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>);
		  v19 = v18;
		  if ( !v18 )
		    goto LABEL_35;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v18,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::List);
		  *(_QWORD *)(v17 + 32) = v19;
		  sub_18002D1B0((SingleFieldAccessor *)(v17 + 32), v20, v21, v22, methodc);
		  v23 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>);
		  v24 = v23;
		  if ( !v23 )
		    goto LABEL_35;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v23,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Rain::HGBaseWetnessFeature>::List);
		  *(_QWORD *)(v17 + 40) = v24;
		  sub_18002D1B0((SingleFieldAccessor *)(v17 + 40), v25, v26, v27, methodd);
		  v28 = (RainCommonRenderingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonRenderingParam);
		  v29 = (SingleFieldAccessor *)v28;
		  if ( !v28 )
		    goto LABEL_35;
		  HG::Rendering::Runtime::Rain::RainCommonRenderingParam::RainCommonRenderingParam(v28, 0LL);
		  v29[6].klass = (SingleFieldAccessor__Class *)this->fields.m_rainCommonPreSettingParam;
		  sub_18002D1B0(v29 + 6, v30, v31, v32, methode);
		  *(_QWORD *)(v17 + 48) = v29;
		  sub_18002D1B0((SingleFieldAccessor *)(v17 + 48), v33, v34, v35, methodg);
		  v36 = (RainWetnessGlobalProps *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::RainWetnessGlobalProps);
		  v37 = v36;
		  if ( !v36 )
		    goto LABEL_35;
		  HG::Rendering::Runtime::Rain::RainWetnessGlobalProps::RainWetnessGlobalProps(v36, 0LL);
		  *(_QWORD *)(v17 + 56) = v37;
		  sub_18002D1B0((SingleFieldAccessor *)(v17 + 56), v38, v39, v40, methodf);
		  HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::CreateDefaultFeatures(
		    (HGRainRenderer_RainWetnessRenderSeq *)v17,
		    0LL);
		  HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::PrepareResources(
		    (HGRainRenderer_RainWetnessRenderSeq *)v17,
		    this->fields.m_rainCommonResources,
		    0LL);
		  items = this->fields.m_rainWetnessRenderSeqs;
		  if ( !items )
		    goto LABEL_35;
		  sub_182F01190((List_1_System_Object_ *)items, (Object *)v17);
		  v41 = this->fields.m_rainWetnessRenderSeqs;
		  if ( !v41 )
		    goto LABEL_35;
		  v4 = v41->fields._size - 1;
		LABEL_22:
		  if ( v4 <= -1 )
		    return;
		  v12 = this->fields.m_rainWetnessRenderSeqs;
		  if ( !v12 )
		    goto LABEL_35;
		  if ( (unsigned int)v4 >= v12->fields._size )
		    goto LABEL_62;
		  items = v12->fields._items;
		  if ( !items )
		    goto LABEL_35;
		  if ( (unsigned int)v4 >= *((_DWORD *)items + 6) )
		    goto LABEL_44;
		  m_rainWetnessRenderSeqs = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)*((_QWORD *)items
		                                                                                                + v4
		                                                                                                + 4);
		  if ( !m_rainWetnessRenderSeqs
		    || (m_rainWetnessRenderSeqs->fields._size = v4, (v13 = this->fields.m_rainWetnessRenderSeqs) == 0LL) )
		  {
		LABEL_35:
		    sub_1800D8260(items, m_rainWetnessRenderSeqs);
		  }
		  if ( (unsigned int)v4 >= v13->fields._size )
		LABEL_62:
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  items = v13->fields._items;
		  if ( !items )
		    goto LABEL_35;
		  if ( (unsigned int)v4 >= *((_DWORD *)items + 6) )
		LABEL_44:
		    sub_1800D2AB0(items, m_rainWetnessRenderSeqs);
		  items = (void *)*((_QWORD *)items + v4 + 4);
		  if ( !items )
		    goto LABEL_35;
		  HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateRainAndWetnessDataSeq(
		    (HGRainRenderer_RainWetnessRenderSeq *)items,
		    this->fields.m_qualityParams,
		    renderContext,
		    0LL);
		}
		
		internal void UpdateRainAndWetnessShaderVariables(HGCamera hgCamera, ref ScriptableRenderContext context, HGVerticalOcclusionMapManager verticalOcclusionMapManager, out RainWetnessGlobalProps outProps, out bool success) {
			outProps = default;
			success = default;
		} // 0x0000000189CE4CF0-0x0000000189CE4E10
		// Void UpdateRainAndWetnessShaderVariables(HGCamera, ScriptableRenderContext ByRef, HGVerticalOcclusionMapManager, RainWetnessGlobalProps ByRef, Boolean ByRef)
		void HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessShaderVariables(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext *context,
		        HGVerticalOcclusionMapManager *verticalOcclusionMapManager,
		        RainWetnessGlobalProps **outProps,
		        bool *success,
		        MethodInfo *method)
		{
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Type *v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  MethodInfo *P3; // [rsp+20h] [rbp-38h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-38h]
		  int32_t index; // [rsp+40h] [rbp-18h] BYREF
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+48h] [rbp-10h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1574, 0LL) )
		  {
		    *outProps = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)outProps, v11, v12, v13, P3);
		    *success = 0;
		    if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		      return;
		    Patch = (ILFixDynamicMethodWrapper_2 *)seq;
		    if ( seq )
		    {
		      HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::UpdateShaderVariables(
		        seq,
		        context,
		        this->fields.m_qualityParams,
		        0LL);
		      if ( seq )
		      {
		        *outProps = seq->fields.rainWetnessGlobalProps;
		        sub_18002D1B0((SingleFieldAccessor *)outProps, v14, v16, v17, P3a);
		        *success = 1;
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(Patch, v14);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1574, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_645(
		    Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    context,
		    (Object *)verticalOcclusionMapManager,
		    outProps,
		    success,
		    0LL);
		}
		
		internal void RenderSceneRain(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CE4918-0x0000000189CE4B04
		// Void RenderSceneRain(HGRenderGraphContext, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRainRenderer::RenderSceneRain(
		        HGRainRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  RainCommonRenderingParam *rainCommonRenderingParam; // rsi
		  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Object *current; // rdi
		  int klass; // esi
		  __int64 v15; // rdx
		  HGRainRenderer__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  int32_t index; // [rsp+30h] [rbp-58h] BYREF
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+38h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v22; // [rsp+40h] [rbp-48h] BYREF
		  _QWORD v23[3]; // [rsp+48h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v24; // [rsp+60h] [rbp-28h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  memset(&v24, 0, sizeof(v24));
		  if ( IFix::WrappersManagerImpl::IsPatched(1581, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1581, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    if ( !seq )
		      sub_1800D8260(v8, v7);
		    rainCommonRenderingParam = seq->fields.rainCommonRenderingParam;
		    if ( !rainCommonRenderingParam )
		      sub_1800D8260(v8, v7);
		    if ( rainCommonRenderingParam->fields.enable )
		    {
		      subRainRenderers = seq->fields.subRainRenderers;
		      if ( !subRainRenderers )
		        sub_1800D8260(v8, v7);
		      v24 = *(List_1_T_Enumerator_System_Object_ *)sub_180364968(v23, subRainRenderers);
		      v23[0] = 0LL;
		      v23[1] = &v24;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v24,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
		        {
		          current = v24._current;
		          if ( !v24._current )
		            sub_1800D8250(v12, v11);
		          klass = (int)v24._current[1].klass;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		          if ( (klass & static_fields->SCENE_DROP_MASK) != 0 )
		          {
		            if ( !current )
		              sub_1800D8250(static_fields, v15);
		            sub_1808B4B14(static_fields, current, ctx, hgCamera);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v22 )
		      {
		        v23[0] = v22->ex;
		        if ( v23[0] )
		          sub_18007E1E0(v23[0]);
		      }
		    }
		  }
		}
		
		internal void RenderScreenDropFX(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CE4B04-0x0000000189CE4CF0
		// Void RenderScreenDropFX(HGRenderGraphContext, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRainRenderer::RenderScreenDropFX(
		        HGRainRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  RainCommonRenderingParam *rainCommonRenderingParam; // rsi
		  List_1_HG_Rendering_Runtime_Rain_HGBaseSubRainRenderer_ *subRainRenderers; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Object *current; // rdi
		  int klass; // esi
		  __int64 v15; // rdx
		  HGRainRenderer__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  int32_t index; // [rsp+30h] [rbp-58h] BYREF
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+38h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v22; // [rsp+40h] [rbp-48h] BYREF
		  _QWORD v23[3]; // [rsp+48h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v24; // [rsp+60h] [rbp-28h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  memset(&v24, 0, sizeof(v24));
		  if ( IFix::WrappersManagerImpl::IsPatched(1583, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1583, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    if ( !seq )
		      sub_1800D8260(v8, v7);
		    rainCommonRenderingParam = seq->fields.rainCommonRenderingParam;
		    if ( !rainCommonRenderingParam )
		      sub_1800D8260(v8, v7);
		    if ( rainCommonRenderingParam->fields.enable )
		    {
		      subRainRenderers = seq->fields.subRainRenderers;
		      if ( !subRainRenderers )
		        sub_1800D8260(v8, v7);
		      v24 = *(List_1_T_Enumerator_System_Object_ *)sub_180364968(v23, subRainRenderers);
		      v23[0] = 0LL;
		      v23[1] = &v24;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v24,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer>::MoveNext) )
		        {
		          current = v24._current;
		          if ( !v24._current )
		            sub_1800D8250(v12, v11);
		          klass = (int)v24._current[1].klass;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer->static_fields;
		          if ( (klass & static_fields->SCREEN_FX_DROP_MASK) != 0 )
		          {
		            if ( !current )
		              sub_1800D8250(static_fields, v15);
		            sub_1808B4B14(static_fields, current, ctx, hgCamera);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v22 )
		      {
		        v23[0] = v22->ex;
		        if ( v23[0] )
		          sub_18007E1E0(v23[0]);
		      }
		    }
		  }
		}
		
		internal bool IsRainRenderingEnabled(HGCamera hgCamera) => default; // 0x0000000189CE4878-0x0000000189CE4918
		// Boolean IsRainRenderingEnabled(HGCamera)
		bool HG::Rendering::Runtime::HGRainRenderer::IsRainRenderingEnabled(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  bool v5; // bl
		  __int64 v6; // rdx
		  RainCommonRenderingParam *rainCommonRenderingParam; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
		  int32_t index; // [rsp+68h] [rbp+20h] BYREF
		
		  v5 = 0;
		  seq = 0LL;
		  index = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1584, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		      return v5;
		    if ( seq )
		    {
		      rainCommonRenderingParam = seq->fields.rainCommonRenderingParam;
		      if ( rainCommonRenderingParam )
		        return rainCommonRenderingParam->fields.enable;
		    }
		LABEL_8:
		    sub_1800D8260(rainCommonRenderingParam, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1584, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)hgCamera,
		           0LL);
		}
		
		internal unsafe HGRainWetnessRendererInputCPP* PrepareCppInput(HGCamera hgCamera, HGVerticalOcclusionMapSettingParameters occSettings) => default; // 0x000000018350D200-0x000000018350D930
		// HGRainWetnessRendererInputCPP* PrepareCppInput(HGCamera, HGVerticalOcclusionMapSettingParameters)
		HGRainWetnessRendererInputCPP *HG::Rendering::Runtime::HGRainRenderer::PrepareCppInput(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        HGVerticalOcclusionMapSettingParameters *occSettings,
		        MethodInfo *method)
		{
		  HGRainWetnessRendererInputCPP *v7; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  _BOOL8 v9; // rdx
		  _OWORD *v10; // rcx
		  HGRainConfig *p_rainConfig; // rdx
		  __int64 v12; // r8
		  HGRainConfig *v13; // rax
		  char *v14; // rcx
		  __int64 v15; // r9
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  RainCommonPreSettingParam *m_rainCommonPreSettingParam; // rdi
		  __int64 v25; // r9
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  HGRainConfig *v28; // rax
		  char *v29; // rcx
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int64 v38; // r9
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  HGRainConfig *v41; // rax
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  float v52; // xmm0_4
		  float v53; // xmm1_4
		  Vector4 v54; // xmm0
		  MethodInfo *v55; // r8
		  Color v56; // xmm1
		  float v57; // eax
		  int farRainDistance_low; // xmm1_4
		  float v59; // xmm0_4
		  float v60; // eax
		  float v61; // xmm1_4
		  float v62; // xmm0_4
		  float v63; // xmm1_4
		  __int64 v64; // xmm0_8
		  __int64 v65; // xmm1_8
		  float v66; // eax
		  float v67; // xmm1_4
		  float v68; // xmm0_4
		  int sceneEffectRainRange_low; // xmm0_4
		  float rainSplashYBias; // xmm2_4
		  int rainOcclusionSampleVerticalJitterLevel_low; // xmm3_4
		  Color v72; // xmm1
		  float v73; // xmm4_4
		  float v74; // xmm5_4
		  int32_t v75; // eax
		  __int128 v76; // xmm0
		  float y; // xmm1_4
		  int screenDropNoiseLevel_low; // xmm1_4
		  int32_t v79; // eax
		  float v80; // xmm1_4
		  int v81; // xmm6_4
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rsi
		  struct MethodInfo *v83; // r14
		  Il2CppClass *klass; // rax
		  Il2CppClass *v85; // rcx
		  float v86; // xmm1_4
		  _OWORD *v88; // rax
		  __int128 v89; // xmm0
		  __int128 v90; // xmm1
		  __int128 v91; // xmm0
		  __int128 v92; // xmm1
		  __int128 v93; // xmm0
		  __int128 v94; // xmm1
		  __int128 v95; // xmm0
		  __int128 v96; // xmm1
		  __int128 v97; // xmm1
		  __int128 v98; // xmm0
		  float v99; // xmm0_4
		  float v100; // xmm1_4
		  __m128 v101; // xmm0
		  __int64 v102; // rax
		  Vector4 v103; // [rsp+20h] [rbp-E0h] BYREF
		  char v104; // [rsp+30h] [rbp-D0h] BYREF
		  float v105; // [rsp+34h] [rbp-CCh]
		  float v106; // [rsp+38h] [rbp-C8h]
		  Vector4 v107; // [rsp+3Ch] [rbp-C4h]
		  float v108; // [rsp+4Ch] [rbp-B4h]
		  float v109; // [rsp+58h] [rbp-A8h]
		  float v110; // [rsp+5Ch] [rbp-A4h]
		  float v111; // [rsp+60h] [rbp-A0h]
		  float v112; // [rsp+64h] [rbp-9Ch]
		  float v113; // [rsp+68h] [rbp-98h]
		  float v114; // [rsp+6Ch] [rbp-94h]
		  float v115; // [rsp+78h] [rbp-88h]
		  float v116; // [rsp+7Ch] [rbp-84h]
		  float v117; // [rsp+80h] [rbp-80h]
		  int v118; // [rsp+8Ch] [rbp-74h]
		  int v119; // [rsp+90h] [rbp-70h]
		  int v120; // [rsp+94h] [rbp-6Ch]
		  int v121; // [rsp+98h] [rbp-68h]
		  Vector4 v122; // [rsp+9Ch] [rbp-64h]
		  int32_t v123; // [rsp+ACh] [rbp-54h]
		  __int128 v124; // [rsp+B0h] [rbp-50h]
		  float v125; // [rsp+C0h] [rbp-40h]
		  float v126; // [rsp+C4h] [rbp-3Ch]
		  float v127; // [rsp+C8h] [rbp-38h]
		  float v128; // [rsp+CCh] [rbp-34h]
		  float v129; // [rsp+D0h] [rbp-30h]
		  float v130; // [rsp+D4h] [rbp-2Ch]
		  int32_t v131; // [rsp+D8h] [rbp-28h]
		  __int128 v132; // [rsp+DCh] [rbp-24h]
		  float v133; // [rsp+ECh] [rbp-14h]
		  char v134; // [rsp+F1h] [rbp-Fh]
		  __int128 v135; // [rsp+F4h] [rbp-Ch]
		  float v136; // [rsp+104h] [rbp+4h]
		  __int128 v137; // [rsp+108h] [rbp+8h]
		  __int128 v138; // [rsp+118h] [rbp+18h]
		  float v139; // [rsp+128h] [rbp+28h]
		  float v140; // [rsp+12Ch] [rbp+2Ch]
		  float v141; // [rsp+130h] [rbp+30h]
		  float v142; // [rsp+134h] [rbp+34h]
		  __int64 v143; // [rsp+138h] [rbp+38h]
		  float v144; // [rsp+140h] [rbp+40h]
		  __int64 v145; // [rsp+144h] [rbp+44h]
		  float v146; // [rsp+14Ch] [rbp+4Ch]
		  __int64 v147; // [rsp+150h] [rbp+50h]
		  float v148; // [rsp+158h] [rbp+58h]
		  Color v149; // [rsp+160h] [rbp+60h] BYREF
		  _BYTE v150[196]; // [rsp+170h] [rbp+70h] BYREF
		  float v151; // [rsp+234h] [rbp+134h]
		  char v152; // [rsp+2A0h] [rbp+1A0h] BYREF
		
		  v7 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGRainWetnessRendererInputCPP>(MethodInfo::UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGRainWetnessRendererInputCPP>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_36;
		  p_rainConfig = &InterpolatedPhase->fields.rainConfig;
		  v12 = 2LL;
		  v13 = &InterpolatedPhase->fields.rainConfig;
		  v14 = &v104;
		  v15 = 2LL;
		  do
		  {
		    v14 += 128;
		    v16 = *(_OWORD *)&v13->enable;
		    v17 = *(_OWORD *)&v13->color.g;
		    v13 = (HGRainConfig *)((char *)v13 + 128);
		    *((_OWORD *)v14 - 8) = v16;
		    v18 = *(_OWORD *)&v13[-1].baseWetnessLevel;
		    *((_OWORD *)v14 - 7) = v17;
		    v19 = *(_OWORD *)&v13[-1].verticalFlowSurfaceThreshold;
		    *((_OWORD *)v14 - 6) = v18;
		    v20 = *(_OWORD *)&v13[-1].rippleWaveSpeed;
		    *((_OWORD *)v14 - 5) = v19;
		    v21 = *(_OWORD *)&v13[-1].farSceneWetnessValue;
		    *((_OWORD *)v14 - 4) = v20;
		    v22 = *(_OWORD *)&v13[-1].rainDirection.z;
		    *((_OWORD *)v14 - 3) = v21;
		    v23 = *(_OWORD *)&v13[-1].farRainDirection.x;
		    *((_OWORD *)v14 - 2) = v22;
		    *((_OWORD *)v14 - 1) = v23;
		    --v15;
		  }
		  while ( v15 );
		  m_rainCommonPreSettingParam = this->fields.m_rainCommonPreSettingParam;
		  v25 = 2LL;
		  v26 = *(_OWORD *)&v13->color.g;
		  *(_OWORD *)v14 = *(_OWORD *)&v13->enable;
		  v27 = *(_OWORD *)&v13->horizontalRainAngle;
		  v28 = p_rainConfig;
		  *((_OWORD *)v14 + 1) = v26;
		  *((_OWORD *)v14 + 2) = v27;
		  v29 = &v152;
		  do
		  {
		    v29 += 128;
		    v30 = *(_OWORD *)&v28->enable;
		    v31 = *(_OWORD *)&v28->color.g;
		    v28 = (HGRainConfig *)((char *)v28 + 128);
		    *((_OWORD *)v29 - 8) = v30;
		    v32 = *(_OWORD *)&v28[-1].baseWetnessLevel;
		    *((_OWORD *)v29 - 7) = v31;
		    v33 = *(_OWORD *)&v28[-1].verticalFlowSurfaceThreshold;
		    *((_OWORD *)v29 - 6) = v32;
		    v34 = *(_OWORD *)&v28[-1].rippleWaveSpeed;
		    *((_OWORD *)v29 - 5) = v33;
		    v35 = *(_OWORD *)&v28[-1].farSceneWetnessValue;
		    *((_OWORD *)v29 - 4) = v34;
		    v36 = *(_OWORD *)&v28[-1].rainDirection.z;
		    *((_OWORD *)v29 - 3) = v35;
		    v37 = *(_OWORD *)&v28[-1].farRainDirection.x;
		    *((_OWORD *)v29 - 2) = v36;
		    *((_OWORD *)v29 - 1) = v37;
		    --v25;
		  }
		  while ( v25 );
		  v38 = 2LL;
		  v39 = *(_OWORD *)&v28->color.g;
		  *(_OWORD *)v29 = *(_OWORD *)&v28->enable;
		  v40 = *(_OWORD *)&v28->horizontalRainAngle;
		  v41 = p_rainConfig;
		  *((_OWORD *)v29 + 1) = v39;
		  *((_OWORD *)v29 + 2) = v40;
		  v10 = v150;
		  do
		  {
		    v10 += 8;
		    v42 = *(_OWORD *)&v41->enable;
		    v43 = *(_OWORD *)&v41->color.g;
		    v41 = (HGRainConfig *)((char *)v41 + 128);
		    *(v10 - 8) = v42;
		    v44 = *(_OWORD *)&v41[-1].baseWetnessLevel;
		    *(v10 - 7) = v43;
		    v45 = *(_OWORD *)&v41[-1].verticalFlowSurfaceThreshold;
		    *(v10 - 6) = v44;
		    v46 = *(_OWORD *)&v41[-1].rippleWaveSpeed;
		    *(v10 - 5) = v45;
		    v47 = *(_OWORD *)&v41[-1].farSceneWetnessValue;
		    *(v10 - 4) = v46;
		    v48 = *(_OWORD *)&v41[-1].rainDirection.z;
		    *(v10 - 3) = v47;
		    v49 = *(_OWORD *)&v41[-1].farRainDirection.x;
		    *(v10 - 2) = v48;
		    *(v10 - 1) = v49;
		    --v38;
		  }
		  while ( v38 );
		  v50 = *(_OWORD *)&v41->color.g;
		  *v10 = *(_OWORD *)&v41->enable;
		  v51 = *(_OWORD *)&v41->horizontalRainAngle;
		  v10[1] = v50;
		  v10[2] = v51;
		  if ( !v150[192] )
		    goto LABEL_11;
		  v88 = v150;
		  do
		  {
		    v88 += 8;
		    v89 = *(_OWORD *)&p_rainConfig->enable;
		    v90 = *(_OWORD *)&p_rainConfig->color.g;
		    p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		    *(v88 - 8) = v89;
		    v91 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
		    *(v88 - 7) = v90;
		    v92 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
		    *(v88 - 6) = v91;
		    v93 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
		    *(v88 - 5) = v92;
		    v94 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
		    *(v88 - 4) = v93;
		    v95 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
		    *(v88 - 3) = v94;
		    v96 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
		    *(v88 - 2) = v95;
		    *(v88 - 1) = v96;
		    --v12;
		  }
		  while ( v12 );
		  v97 = *(_OWORD *)&p_rainConfig->color.g;
		  *v88 = *(_OWORD *)&p_rainConfig->enable;
		  v98 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
		  v88[1] = v97;
		  v88[2] = v98;
		  if ( v151 > COERCE_FLOAT(1) )
		    LOBYTE(v10) = 1;
		  else
		LABEL_11:
		    LOBYTE(v10) = 0;
		  v9 = v152 != 0;
		  if ( !v7 )
		    goto LABEL_36;
		  v7->enable = v9;
		  v7->enableWetness = (_BYTE)v10 != 0;
		  v52 = v105;
		  v53 = v106;
		  v7->enableWetnessAffectSSR = v134 != 0;
		  v7->intensity = v52;
		  v54 = v107;
		  v7->speed = v53;
		  v103 = v54;
		  v56 = *UnityEngine::Color::op_Implicit(&v149, &v103, (MethodInfo *)v12);
		  v57 = v144;
		  v7->streakLength = v108;
		  *(_QWORD *)&v7->rainDirection.x = v143;
		  v7->rainDirection.z = v57;
		  v7->color = (Vector4)v56;
		  v7->rainCenterBias = v112;
		  if ( m_rainCommonPreSettingParam )
		  {
		    v7->middleRainDistance = m_rainCommonPreSettingParam->fields.middleRainDistance;
		    farRainDistance_low = LODWORD(m_rainCommonPreSettingParam->fields.farRainDistance);
		  }
		  else
		  {
		    farRainDistance_low = 1120403456;
		    v7->middleRainDistance = 30.0;
		  }
		  v59 = v113;
		  v60 = v146;
		  LODWORD(v7->farRainDistance) = farRainDistance_low;
		  v61 = v116;
		  v7->middleRainLayerSpeedDiffMultiplier = v59;
		  v7->middleRainAlphaMultiplier = v114;
		  v62 = v115;
		  v7->farRainLayerSpeedDiffMultiplier = v61;
		  v63 = v117;
		  v7->middleRainLightingPercent = v62;
		  v64 = v147;
		  v7->farRainAlphaMultiplier = v63;
		  v65 = v145;
		  *(_QWORD *)&v7->farRainDirection.x = v64;
		  LODWORD(v64) = v120;
		  *(_QWORD *)&v7->middleRainDirection.x = v65;
		  LODWORD(v65) = v118;
		  LODWORD(v7->rainWaveAlpha) = v64;
		  LODWORD(v64) = v119;
		  LODWORD(v7->rainWaveVerticalSpeed) = v65;
		  LODWORD(v65) = v121;
		  v7->middleRainDirection.z = v60;
		  v66 = v148;
		  LODWORD(v7->rainWaveHorizontalSpeed) = v64;
		  LODWORD(v7->rainWaveBottomFadeFactor) = v65;
		  v7->farRainDirection.z = v66;
		  if ( m_rainCommonPreSettingParam )
		  {
		    v67 = v109;
		    v7->rainWaveDistance = m_rainCommonPreSettingParam->fields.rainWaveDistance;
		    v68 = v110;
		    v7->sceneEffectRainJitterLevel = v67;
		    v7->sceneEffectRainLightingPercent = v111;
		    v7->sceneEffectRainWidthScale = v68;
		    sceneEffectRainRange_low = LODWORD(m_rainCommonPreSettingParam->fields.sceneEffectRainRange);
		  }
		  else
		  {
		    v99 = v109;
		    v100 = v110;
		    v7->rainWaveDistance = 100.0;
		    v7->sceneEffectRainJitterLevel = v99;
		    v7->sceneEffectRainLightingPercent = v111;
		    sceneEffectRainRange_low = 1112014848;
		    v7->sceneEffectRainWidthScale = v100;
		  }
		  LODWORD(v7->sceneEffectRainRange) = sceneEffectRainRange_low;
		  v103 = v122;
		  rainSplashYBias = 0.0;
		  rainOcclusionSampleVerticalJitterLevel_low = 1036831949;
		  v72 = *UnityEngine::Color::op_Implicit(&v149, &v103, v55);
		  v75 = v123;
		  v7->screenDropFlowPercent = v127;
		  v76 = v124;
		  v7->screenDropMaxCountLim = v75;
		  v7->screenDropColor = (Vector4)v72;
		  v7->screenDropJitterSpeedScale = v130;
		  v7->screenDropMinMaxSpeed.y = v129;
		  v7->screenDropCentroidFadeParam.y = v126;
		  *(_OWORD *)&v7->screenDropMinMaxLifeTime.x = v76;
		  v7->screenDropMinMaxSpeed.x = v128;
		  v7->screenDropCentroidFadeParam.x = v125;
		  if ( m_rainCommonPreSettingParam )
		  {
		    y = m_rainCommonPreSettingParam->fields.screenDropScatterParam.y;
		    v7->screenDropScatterParam.x = m_rainCommonPreSettingParam->fields.screenDropScatterParam.x;
		    v7->screenDropScatterParam.y = y;
		    v7->screenDropFXShadingSize = m_rainCommonPreSettingParam->fields.screenDropFXShadingSize;
		    screenDropNoiseLevel_low = LODWORD(m_rainCommonPreSettingParam->fields.screenDropNoiseLevel);
		  }
		  else
		  {
		    screenDropNoiseLevel_low = 1036831949;
		    v101 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL);
		    LODWORD(v7->screenDropScatterParam.x) = v101.m128_i32[0];
		    LODWORD(v7->screenDropScatterParam.y) = _mm_shuffle_ps(v101, v101, 85).m128_u32[0];
		    v7->screenDropFXShadingSize = 0.1;
		  }
		  v79 = v131;
		  LODWORD(v7->screenDropNoiseLevel) = screenDropNoiseLevel_low;
		  v7->rainSplashCount = v79;
		  *(_OWORD *)&v7->rainSplashSpeed = v132;
		  v7->rainSplashLightingPercent = v133;
		  if ( m_rainCommonPreSettingParam )
		  {
		    v7->rainSplashRange = m_rainCommonPreSettingParam->fields.rainSplashRange;
		    rainSplashYBias = m_rainCommonPreSettingParam->fields.rainSplashYBias;
		  }
		  else
		  {
		    v7->rainSplashRange = v73;
		  }
		  v80 = v140;
		  v81 = 1065353216;
		  v7->rainSplashYBias = rainSplashYBias;
		  v7->farSceneWetnessDistanceFactor = v80;
		  v7->wetnessProceduralForWater = v142;
		  *(_OWORD *)&v7->wetness = v135;
		  v7->verticalWetnessScalar = v136;
		  v7->farSceneWetnessValue = v141;
		  *(_OWORD *)&v7->verticalFlowSpeed = v137;
		  *(_OWORD *)&v7->rippleFrequency = v138;
		  v7->rippleRoughnessMaskThreshold = v139;
		  if ( m_rainCommonPreSettingParam )
		  {
		    v7->maxRainHeight = m_rainCommonPreSettingParam->fields.maxRainHeight;
		    v7->maxMoveDirectionLength = m_rainCommonPreSettingParam->fields.maxMoveDirectionLength;
		    v7->rainTemporalTimeThreshold = m_rainCommonPreSettingParam->fields.rainTemporalTimeThreshold;
		    v7->farRainMaxUVFlowSpeed = m_rainCommonPreSettingParam->fields.farRainMaxUVFlowSpeed;
		    v7->sceneEffectRainMaxUVFlowSpeed = m_rainCommonPreSettingParam->fields.sceneEffectRainMaxUVFlowSpeed;
		    v7->rainWaveNoiseFlowSpeedMultiplier = m_rainCommonPreSettingParam->fields.rainWaveNoiseFlowSpeedMultiplier;
		    v7->rainOcclusionMaskSampleMode = 1;
		    v7->rainOcclusionMaskSamplePosJitterMode = 1;
		    v7->rainOcclusionMapRange = m_rainCommonPreSettingParam->fields.rainOcclusionMapRange;
		    v7->rainOcclusionMapHeight = m_rainCommonPreSettingParam->fields.rainOcclusionMapHeight;
		    v7->rainOcclusionSampleNormalBias = m_rainCommonPreSettingParam->fields.rainOcclusionSampleNormalBias;
		    v7->rainOcclusionSampleDepthBias = m_rainCommonPreSettingParam->fields.rainOcclusionSampleDepthBias;
		    v7->rainOcclusionSampleNoiseScale = m_rainCommonPreSettingParam->fields.rainOcclusionSampleNoiseScale;
		    v7->rainOcclusionSampleHorizontalJitterLevel = m_rainCommonPreSettingParam->fields.rainOcclusionSampleHorizontalJitterLevel;
		    rainOcclusionSampleVerticalJitterLevel_low = LODWORD(m_rainCommonPreSettingParam->fields.rainOcclusionSampleVerticalJitterLevel);
		  }
		  else
		  {
		    v7->maxRainHeight = v74;
		    v7->maxMoveDirectionLength = 0.5;
		    v7->rainTemporalTimeThreshold = 1.0;
		    v7->farRainMaxUVFlowSpeed = v74;
		    v7->sceneEffectRainMaxUVFlowSpeed = v74;
		    v7->rainWaveNoiseFlowSpeedMultiplier = 1.0;
		    v7->rainOcclusionMaskSampleMode = 1;
		    v7->rainOcclusionMaskSamplePosJitterMode = 1;
		    *(_OWORD *)&v7->rainOcclusionMapRange = xmmword_18DC81220;
		    v7->rainOcclusionSampleNoiseScale = 0.5;
		    v7->rainOcclusionSampleHorizontalJitterLevel = 0.30000001;
		  }
		  LODWORD(v7->rainOcclusionSampleVerticalJitterLevel) = rainOcclusionSampleVerticalJitterLevel_low;
		  if ( !occSettings
		    || (DepthOcclusionMapRange_k__BackingField = occSettings->fields._DepthOcclusionMapRange_k__BackingField,
		        v83 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit,
		        !DepthOcclusionMapRange_k__BackingField) )
		  {
		LABEL_36:
		    sub_1800D8260(v10, v9);
		  }
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v9);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v102 = sub_18011C4C0(v83->klass);
		    (**(void (***)(void))(*(_QWORD *)(v102 + 192) + 48LL))();
		  }
		  v85 = v83->klass;
		  if ( ((__int64)v85->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v85, v9);
		  if ( (float)DepthOcclusionMapRange_k__BackingField->fields._paramValue_k__BackingField <= 63.0 )
		    v81 = 0x40000000;
		  LODWORD(v7->acneFixNormalBiasScale) = v81;
		  if ( m_rainCommonPreSettingParam )
		  {
		    v7->farRainTex0_ST = m_rainCommonPreSettingParam->fields.farRainTex0_ST;
		    v7->farRainTex1_ST = m_rainCommonPreSettingParam->fields.farRainTex1_ST;
		    v7->sceneEffectRainTex_ST = m_rainCommonPreSettingParam->fields.sceneEffectRainTex_ST;
		    v7->rainWaveTex_ST = m_rainCommonPreSettingParam->fields.rainWaveTex_ST;
		    v7->rainWaveNoise_ST = m_rainCommonPreSettingParam->fields.rainWaveNoise_ST;
		    v7->screenDropFXNoiseTex_ST = m_rainCommonPreSettingParam->fields.screenDropFXNoiseTex_ST;
		    v7->verticalFlowTexture_ST = m_rainCommonPreSettingParam->fields.verticalFlowTexture_ST;
		    v86 = m_rainCommonPreSettingParam->fields.rippleTexture_ST.y;
		    v7->rippleTexture_ST.x = m_rainCommonPreSettingParam->fields.rippleTexture_ST.x;
		    v7->rippleTexture_ST.y = v86;
		    v7->rippleRowColumnCount = m_rainCommonPreSettingParam->fields.rippleRowColumnCount;
		    v7->rainSplashTextureRowColumnCount = m_rainCommonPreSettingParam->fields.rainSplashTextureRowColumnCount;
		  }
		  return v7;
		}
		
		internal void Dispose() {} // 0x0000000184D39D80-0x0000000184D39E70
		// Void Dispose()
		void HG::Rendering::Runtime::HGRainRenderer::Dispose(HGRainRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_T_Enumerator_System_Object_ v6; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v7; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(518, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(518, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_rainWetnessRenderSeqs && this->fields.m_rainWetnessRenderSeqs->fields._size > 0 )
		  {
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v6,
		      (List_1_System_UInt64_ *)this->fields.m_rainWetnessRenderSeqs,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::GetEnumerator);
		    v7 = v6;
		    v6._list = 0LL;
		    *(_QWORD *)&v6._index = &v7;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v7,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::MoveNext) )
		    {
		      if ( v7._current )
		        HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(
		          (HGRainRenderer_RainWetnessRenderSeq *)v7._current,
		          0LL);
		    }
		  }
		}
		
		private static int _GetRainOcclusionMaskSampleMode() => default; // 0x00000001832DDB60-0x00000001832DDBB0
		// Int32 _GetRainOcclusionMaskSampleMode()
		int32_t HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSampleMode(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 814 )
		    return 1;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2->static_fields->wrapperArray;
		  if ( !v2 )
		    goto LABEL_6;
		  if ( LODWORD(v2->_0.namespaze) <= 0x32E )
		    sub_1800D2AB0(v2, v1);
		  if ( !v2[17]._0.methods )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(814, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v2, v1);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		private static int _GetRainOcclusionMaskSamplePosJitterMode() => default; // 0x0000000189CE4E10-0x0000000189CE4E54
		// Int32 _GetRainOcclusionMaskSamplePosJitterMode()
		int32_t HG::Rendering::Runtime::HGRainRenderer::_GetRainOcclusionMaskSamplePosJitterMode(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1580, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1580, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		internal void DisposeSeq(HGCamera hgCamera) {} // 0x0000000182EDEF50-0x0000000182EDF000
		// Void DisposeSeq(HGCamera)
		void HG::Rendering::Runtime::HGRainRenderer::DisposeSeq(HGRainRenderer *this, HGCamera *hgCamera, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_rainWetnessRenderSeqs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
		  int32_t index; // [rsp+68h] [rbp+20h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(543, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(543, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)hgCamera,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_rainWetnessRenderSeqs, v5);
		  }
		  if ( hgCamera && HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    m_rainWetnessRenderSeqs = (List_1_System_Object_ *)seq;
		    if ( seq )
		    {
		      HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::Dispose(seq, 0LL);
		      m_rainWetnessRenderSeqs = (List_1_System_Object_ *)this->fields.m_rainWetnessRenderSeqs;
		      if ( m_rainWetnessRenderSeqs )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          m_rainWetnessRenderSeqs,
		          (Object *)seq,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq>::Remove);
		        return;
		      }
		    }
		    goto LABEL_7;
		  }
		}
		
		private bool _TryGetSeqByCamera(HGCamera hgCamera, out RainWetnessRenderSeq seq, out int index) {
			seq = default;
			index = default;
			return default;
		} // 0x0000000182EE0D10-0x0000000182EE0F70
		// Boolean _TryGetSeqByCamera(HGCamera, HGRainRenderer+RainWetnessRenderSeq ByRef, Int32 ByRef)
		bool HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        HGRainRenderer_RainWetnessRenderSeq **seq,
		        int32_t *index,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v11; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int v16; // r10d
		  __int64 v17; // rdx
		  __int64 *v18; // r8
		  signed __int64 v19; // rtt
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *m_rainWetnessRenderSeqs; // rax
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *v21; // r8
		  HGRainRenderer_RainWetnessRenderSeq__Array *items; // rcx
		  unsigned int v23; // ebx
		  unsigned __int64 v24; // rax
		  char v25; // bl
		  __int64 *v26; // r8
		  signed __int64 v27; // rtt
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, hgCamera);
		  if ( wrapperArray->max_length.size <= 544 )
		    goto LABEL_12;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = v7->static_fields->wrapperArray;
		  if ( !v11 )
		    sub_1800D8260(v7, hgCamera);
		  if ( v11->max_length.size <= 0x220u )
		    sub_1800D2AB0(v7, hgCamera);
		  if ( v11[15].vector[4] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(544, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(Patch, (Object *)this, (Object *)hgCamera, seq, index, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    v16 = dword_18F35FD08;
		    v17 = 0LL;
		    *seq = 0LL;
		    if ( v16 )
		    {
		      v18 = &qword_18F0BCBA0[(((unsigned __int64)seq >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v18 + 36190);
		      do
		        v19 = v18[36190];
		      while ( v19 != _InterlockedCompareExchange64(
		                       v18 + 36190,
		                       v19 | (1LL << (((unsigned __int64)seq >> 12) & 0x3F)),
		                       v19) );
		      v16 = dword_18F35FD08;
		    }
		    *index = -1;
		    if ( hgCamera )
		    {
		      if ( this->fields.m_rainWetnessRenderSeqs )
		      {
		        m_rainWetnessRenderSeqs = this->fields.m_rainWetnessRenderSeqs;
		        if ( m_rainWetnessRenderSeqs->fields._size > 0 )
		        {
		          v21 = this->fields.m_rainWetnessRenderSeqs;
		          while ( (int)v17 < m_rainWetnessRenderSeqs->fields._size )
		          {
		            if ( (unsigned int)v17 >= v21->fields._size )
		              System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		            items = v21->fields._items;
		            if ( !items )
		              sub_1800D8250(0LL, v17);
		            if ( (unsigned int)v17 >= items->max_length.size )
		              goto LABEL_38;
		            if ( items->vector[(int)v17] && items->vector[(int)v17]->fields.hgCamera == hgCamera )
		            {
		              if ( (int)v17 <= -1 )
		                return 0;
		              items = v21->fields._items;
		              if ( (unsigned int)v17 >= items->max_length.size )
		LABEL_38:
		                sub_1800D2AA0(items, v17, v21);
		              *seq = items->vector[(int)v17];
		              if ( v16 )
		              {
		                v23 = ((unsigned __int64)seq >> 12) & 0x1FFFFF;
		                v24 = (unsigned __int64)v23 >> 6;
		                v25 = v23 & 0x3F;
		                v26 = &qword_18F0BCBA0[v24];
		                _m_prefetchw(v26 + 36190);
		                do
		                  v27 = v26[36190];
		                while ( v27 != _InterlockedCompareExchange64(v26 + 36190, v27 | (1LL << v25), v27) );
		              }
		              *index = v17;
		              return 1;
		            }
		            v17 = (unsigned int)(v17 + 1);
		          }
		        }
		      }
		    }
		    return 0;
		  }
		}
		
		public Vector3 GetRainDirection(HGCamera hgCamera) => default; // 0x0000000189CE4718-0x0000000189CE47E4
		// Vector3 GetRainDirection(HGCamera)
		Vector3 *HG::Rendering::Runtime::HGRainRenderer::GetRainDirection(
		        Vector3 *__return_ptr retstr,
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  MethodInfo *v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *up; // rax
		  RainCommonRenderingParam *rainCommonRenderingParam; // rax
		  __int64 v11; // xmm0_8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v16[2]; // [rsp+38h] [rbp-20h] BYREF
		  int32_t index; // [rsp+60h] [rbp+8h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1585, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1585, 0LL);
		    if ( Patch )
		    {
		      up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_364(v16, Patch, (Object *)this, (Object *)hgCamera, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    up = UnityEngine::Vector3::get_up(v16, v7);
		LABEL_10:
		    v11 = *(_QWORD *)&up->x;
		    z = up->z;
		    goto LABEL_11;
		  }
		  if ( !seq )
		    goto LABEL_8;
		  rainCommonRenderingParam = seq->fields.rainCommonRenderingParam;
		  if ( !rainCommonRenderingParam )
		    goto LABEL_8;
		  v11 = *(_QWORD *)&rainCommonRenderingParam->fields.rainDirection.x;
		  z = rainCommonRenderingParam->fields.rainDirection.z;
		LABEL_11:
		  *(_QWORD *)&retstr->x = v11;
		  retstr->z = z;
		  return retstr;
		}
		
		public float GetCurrentRainIntensity(Camera inMainCamera, bool noOrthoClamp = true /* Metadata: 0x0230304E */) => default; // 0x00000001830A03B0-0x00000001830A0590
		// Single GetCurrentRainIntensity(Camera, Boolean)
		float HG::Rendering::Runtime::HGRainRenderer::GetCurrentRainIntensity(
		        HGRainRenderer *this,
		        Camera *inMainCamera,
		        bool noOrthoClamp,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v9; // rcx
		  HGCamera *v10; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGRainConfig *p_rainConfig; // r8
		  __int64 v13; // r9
		  HGRainConfig *v14; // rax
		  _OWORD *v15; // rcx
		  __int64 v16; // rdx
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _OWORD *v29; // rax
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm1
		  __int128 v39; // xmm0
		  _BYTE v40[4]; // [rsp+30h] [rbp-138h] BYREF
		  float v41; // [rsp+34h] [rbp-134h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_19;
		  if ( wrapperArray->max_length.size > 1586 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_19;
		    if ( LODWORD(v6->_0.namespaze) <= 0x632 )
		      sub_1800D2AB0(v6, wrapperArray);
		    if ( v6[33].vtable.Equals.methodPtr )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1586, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_214(
		                 (ILFixDynamicMethodWrapper_6 *)Patch,
		                 (Object *)this,
		                 (Object *)inMainCamera,
		                 noOrthoClamp,
		                 0LL);
		LABEL_19:
		      sub_1800D8260(v6, wrapperArray);
		    }
		  }
		  v9 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v9 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !inMainCamera )
		    return 0.0;
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v9);
		  if ( !inMainCamera->fields._._._.m_CachedPtr )
		    return 0.0;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v10 = HG::Rendering::Runtime::HGCamera::GetOrCreate(inMainCamera, 0, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v10, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_19;
		  p_rainConfig = &InterpolatedPhase->fields.rainConfig;
		  v13 = 2LL;
		  v14 = &InterpolatedPhase->fields.rainConfig;
		  v15 = v40;
		  v16 = 2LL;
		  do
		  {
		    v15 += 8;
		    v17 = *(_OWORD *)&v14->enable;
		    v18 = *(_OWORD *)&v14->color.g;
		    v14 = (HGRainConfig *)((char *)v14 + 128);
		    *(v15 - 8) = v17;
		    v19 = *(_OWORD *)&v14[-1].baseWetnessLevel;
		    *(v15 - 7) = v18;
		    v20 = *(_OWORD *)&v14[-1].verticalFlowSurfaceThreshold;
		    *(v15 - 6) = v19;
		    v21 = *(_OWORD *)&v14[-1].rippleWaveSpeed;
		    *(v15 - 5) = v20;
		    v22 = *(_OWORD *)&v14[-1].farSceneWetnessValue;
		    *(v15 - 4) = v21;
		    v23 = *(_OWORD *)&v14[-1].rainDirection.z;
		    *(v15 - 3) = v22;
		    v24 = *(_OWORD *)&v14[-1].farRainDirection.x;
		    *(v15 - 2) = v23;
		    *(v15 - 1) = v24;
		    --v16;
		  }
		  while ( v16 );
		  v25 = *(_OWORD *)&v14->color.g;
		  *v15 = *(_OWORD *)&v14->enable;
		  v26 = *(_OWORD *)&v14->horizontalRainAngle;
		  v15[1] = v25;
		  v15[2] = v26;
		  if ( !v40[0] )
		    return 0.0;
		  v29 = v40;
		  do
		  {
		    v29 += 8;
		    v30 = *(_OWORD *)&p_rainConfig->enable;
		    v31 = *(_OWORD *)&p_rainConfig->color.g;
		    p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		    *(v29 - 8) = v30;
		    v32 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
		    *(v29 - 7) = v31;
		    v33 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
		    *(v29 - 6) = v32;
		    v34 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
		    *(v29 - 5) = v33;
		    v35 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
		    *(v29 - 4) = v34;
		    v36 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
		    *(v29 - 3) = v35;
		    v37 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
		    *(v29 - 2) = v36;
		    *(v29 - 1) = v37;
		    --v13;
		  }
		  while ( v13 );
		  v38 = *(_OWORD *)&p_rainConfig->color.g;
		  *v29 = *(_OWORD *)&p_rainConfig->enable;
		  v39 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
		  v29[1] = v38;
		  v29[2] = v39;
		  return v41;
		}
		
		public bool GetShouldRequestOcclusionMap(HGCamera hgCamera) => default; // 0x0000000189CE47E4-0x0000000189CE4878
		// Boolean GetShouldRequestOcclusionMap(HGCamera)
		bool HG::Rendering::Runtime::HGRainRenderer::GetShouldRequestOcclusionMap(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  bool result; // al
		  __int64 v6; // rdx
		  HGRainRenderer_RainWetnessRenderSeq *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRainRenderer_RainWetnessRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
		  int32_t index; // [rsp+68h] [rbp+20h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1587, 0LL) )
		  {
		    result = HG::Rendering::Runtime::HGRainRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL);
		    if ( !result )
		      return result;
		    v7 = seq;
		    if ( seq )
		      return HG::Rendering::Runtime::HGRainRenderer::RainWetnessRenderSeq::ShouldRequestRainOcclusionMap(seq, 0LL);
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1587, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)hgCamera,
		           0LL);
		}
		
		public bool GetWetnessEnabled(HGCamera hgCamera) => default; // 0x0000000182EDFE80-0x0000000182EE0010
		// Boolean GetWetnessEnabled(HGCamera)
		bool HG::Rendering::Runtime::HGRainRenderer::GetWetnessEnabled(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  int v4; // ebx
		  struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *wrapperArray; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  int32_t *P3; // [rsp+20h] [rbp-28h]
		  int32_t *P3a; // [rsp+20h] [rbp-28h]
		  _BYTE P2[24]; // [rsp+30h] [rbp-18h] BYREF
		  int32_t v18; // [rsp+68h] [rbp+20h] BYREF
		
		  v4 = 0;
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)P2 = 0LL;
		  v18 = 0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->fields._size > 834 )
		  {
		    if ( !items->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_26;
		    if ( wrapperArray->fields._size <= 0x342u )
		      goto LABEL_28;
		    if ( *(_QWORD *)&wrapperArray[167].fields._size )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(834, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                 (ILFixDynamicMethodWrapper_33 *)Patch,
		                 (Object *)this,
		                 (Object *)hgCamera,
		                 0LL);
		      goto LABEL_26;
		    }
		  }
		  if ( !items->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->fields._size <= 544 )
		    goto LABEL_9;
		  if ( !items->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->fields._size <= 0x220u )
		LABEL_28:
		    sub_1800D2AB0(items, wrapperArray);
		  if ( !*(_QWORD *)&wrapperArray[109].fields._size )
		  {
		LABEL_9:
		    *(_QWORD *)P2 = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)P2, (Type *)wrapperArray, (PropertyInfo_1 *)method, v3, (MethodInfo *)P3);
		    if ( !hgCamera || !this->fields.m_rainWetnessRenderSeqs || this->fields.m_rainWetnessRenderSeqs->fields._size <= 0 )
		      return 0;
		    wrapperArray = this->fields.m_rainWetnessRenderSeqs;
		    while ( 1 )
		    {
		      if ( v4 >= wrapperArray->fields._size )
		        return 0;
		      if ( (unsigned int)v4 >= wrapperArray->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->fields._items;
		      if ( !items )
		        goto LABEL_26;
		      if ( (unsigned int)v4 >= LODWORD(items->_0.namespaze) )
		        goto LABEL_28;
		      if ( *((_QWORD *)&items->_0.byval_arg.data.dummy + v4) )
		      {
		        items = (struct ILFixDynamicMethodWrapper_2__Class *)*((_QWORD *)&items->_0.byval_arg.data.dummy + v4);
		        if ( (HGCamera *)items->_0.name == hgCamera )
		          break;
		      }
		      ++v4;
		    }
		    if ( v4 <= -1 )
		      return 0;
		    if ( wrapperArray )
		    {
		      *(_QWORD *)P2 = wrapperArray->fields._items->vector[v4];
		      sub_18002D1B0((SingleFieldAccessor *)P2, (Type *)wrapperArray, v9, v10, (MethodInfo *)P3a);
		      goto LABEL_22;
		    }
		LABEL_26:
		    sub_1800D8260(items, wrapperArray);
		  }
		  v14 = IFix::WrappersManagerImpl::GetPatch(544, 0LL);
		  if ( !v14 )
		    goto LABEL_26;
		  if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(
		          v14,
		          (Object *)this,
		          (Object *)hgCamera,
		          (HGRainRenderer_RainWetnessRenderSeq **)P2,
		          &v18,
		          0LL) )
		    return 0;
		LABEL_22:
		  items = *(struct ILFixDynamicMethodWrapper_2__Class **)P2;
		  if ( !*(_QWORD *)P2 )
		    goto LABEL_26;
		  if ( !*(_QWORD *)(*(_QWORD *)P2 + 48LL) )
		    return 0;
		  v11 = *(_QWORD *)(*(_QWORD *)P2 + 48LL);
		  if ( !*(_BYTE *)(v11 + 253) )
		    return 0;
		  return *(_BYTE *)(v11 + 254);
		}
		
		public bool GetWetnessHighQualityEnabled(HGCamera hgCamera) => default; // 0x0000000182EDFCF0-0x0000000182EDFE80
		// Boolean GetWetnessHighQualityEnabled(HGCamera)
		bool HG::Rendering::Runtime::HGRainRenderer::GetWetnessHighQualityEnabled(
		        HGRainRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  int v4; // ebx
		  struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
		  List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *wrapperArray; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t *P3; // [rsp+20h] [rbp-28h]
		  int32_t *P3a; // [rsp+20h] [rbp-28h]
		  _BYTE P2[24]; // [rsp+30h] [rbp-18h] BYREF
		  int32_t v17; // [rsp+68h] [rbp+20h] BYREF
		
		  v4 = 0;
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)P2 = 0LL;
		  v17 = 0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_25;
		  if ( wrapperArray->fields._size <= 835 )
		    goto LABEL_47;
		  if ( !items->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_25;
		  if ( wrapperArray->fields._size <= 0x343u )
		    goto LABEL_27;
		  if ( !wrapperArray[167].fields._syncRoot )
		  {
		LABEL_47:
		    if ( !items->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_25;
		    if ( wrapperArray->fields._size <= 544 )
		      goto LABEL_9;
		    if ( !items->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (List_1_HG_Rendering_Runtime_HGRainRenderer_RainWetnessRenderSeq_ *)items->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_25;
		    if ( wrapperArray->fields._size > 0x220u )
		    {
		      if ( *(_QWORD *)&wrapperArray[109].fields._size )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(544, 0LL);
		        if ( !Patch )
		          goto LABEL_25;
		        if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(
		               Patch,
		               (Object *)this,
		               (Object *)hgCamera,
		               (HGRainRenderer_RainWetnessRenderSeq **)P2,
		               &v17,
		               0LL) )
		        {
		          goto LABEL_22;
		        }
		        return 0;
		      }
		LABEL_9:
		      *(_QWORD *)P2 = 0LL;
		      sub_18002D1B0((SingleFieldAccessor *)P2, (Type *)wrapperArray, (PropertyInfo_1 *)method, v3, (MethodInfo *)P3);
		      if ( hgCamera && this->fields.m_rainWetnessRenderSeqs && this->fields.m_rainWetnessRenderSeqs->fields._size > 0 )
		      {
		        wrapperArray = this->fields.m_rainWetnessRenderSeqs;
		        while ( 1 )
		        {
		          if ( v4 >= wrapperArray->fields._size )
		            return 0;
		          if ( (unsigned int)v4 >= wrapperArray->fields._size )
		            System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		          items = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->fields._items;
		          if ( !items )
		            goto LABEL_25;
		          if ( (unsigned int)v4 >= LODWORD(items->_0.namespaze) )
		            goto LABEL_27;
		          if ( *((_QWORD *)&items->_0.byval_arg.data.dummy + v4) )
		          {
		            items = (struct ILFixDynamicMethodWrapper_2__Class *)*((_QWORD *)&items->_0.byval_arg.data.dummy + v4);
		            if ( (HGCamera *)items->_0.name == hgCamera )
		              break;
		          }
		          ++v4;
		        }
		        if ( v4 > -1 )
		        {
		          if ( !wrapperArray )
		            goto LABEL_25;
		          *(_QWORD *)P2 = wrapperArray->fields._items->vector[v4];
		          sub_18002D1B0((SingleFieldAccessor *)P2, (Type *)wrapperArray, v9, v10, (MethodInfo *)P3a);
		LABEL_22:
		          if ( *(_QWORD *)P2 )
		          {
		            if ( *(_QWORD *)(*(_QWORD *)P2 + 48LL) )
		              return *(_BYTE *)(*(_QWORD *)(*(_QWORD *)P2 + 48LL) + 324LL);
		            return 0;
		          }
		LABEL_25:
		          sub_1800D8260(items, wrapperArray);
		        }
		      }
		      return 0;
		    }
		LABEL_27:
		    sub_1800D2AB0(items, wrapperArray);
		  }
		  v12 = IFix::WrappersManagerImpl::GetPatch(835, 0LL);
		  if ( !v12 )
		    goto LABEL_25;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)v12,
		           (Object *)this,
		           (Object *)hgCamera,
		           0LL);
		}
		
		internal RainCommonPreSettingParam GetCurrentPresettingParams() => default; // 0x0000000189CE46C8-0x0000000189CE4718
		// RainCommonPreSettingParam GetCurrentPresettingParams()
		RainCommonPreSettingParam *HG::Rendering::Runtime::HGRainRenderer::GetCurrentPresettingParams(
		        HGRainRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1588, 0LL) )
		    return this->fields.m_rainCommonPreSettingParam;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1588, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_647(Patch, (Object *)this, 0LL);
		}
		
	}
}
