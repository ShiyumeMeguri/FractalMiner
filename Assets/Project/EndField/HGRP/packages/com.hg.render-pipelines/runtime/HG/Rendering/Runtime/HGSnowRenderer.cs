using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Snow;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSnowRenderer // TypeDefIndex: 37690
	{
		// Fields
		public static readonly string EDITOR_KW; // 0x00
		public static readonly string LIGHTING_KW; // 0x08
		public static readonly string SNOWFLAKE_KW; // 0x10
		public static readonly string SNOW_COLLISION_KW; // 0x18
		private static readonly float UPDATE_DELTA_TIME_THRESHOLD; // 0x20
		private static readonly float FOV_FADE_HIGHERTHRESHOLD; // 0x24
		private static readonly float FOV_FADE_LOWERTHRESHOLD; // 0x28
		private List<SnowRenderSeq> m_snowRenderSeqs; // 0x10
		private SnowCommonPreSettingParam m_snowCommonPreSettingParam; // 0x18
		private SnowCommonResources m_snowCommonResources; // 0x20
		private SnowQualityParams m_qualityParams; // 0x28
	
		// Nested types
		private class SnowRenderSeq // TypeDefIndex: 37688
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public int cameraMask; // 0x18
			public List<HGBaseSubSnowRenderer> subSnowRenderers; // 0x20
			public SnowCommonRenderingParam snowCommonRenderingParam; // 0x28
			private float m_deltaTime; // 0x30
			private float m_lastTime; // 0x34
	
			// Constructors
			public SnowRenderSeq() {} // 0x0000000184D87910-0x0000000184D87920
			// Void Reset()
			void USD::NET::SampleEnumerator<System::Object>::Reset(SampleEnumerator_1_System_Object_ *this, MethodInfo *method)
			{
			  this->fields.m_i = -1;
			}
			
	
			// Methods
			public void CreateDefaultFeatures() {} // 0x0000000182EDED50-0x0000000182EDEDE0
			// Void CreateDefaultFeatures()
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::CreateDefaultFeatures(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rcx
			  List_1_System_Object_ *v5; // rdi
			  HGSceneEffectSnowRenderer *v6; // rax
			  HGSceneEffectSnowRenderer *v7; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(818, 0LL) )
			  {
			    subSnowRenderers = this->fields.subSnowRenderers;
			    if ( subSnowRenderers )
			    {
			      sub_183127A90(
			        subSnowRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
			      v5 = (List_1_System_Object_ *)this->fields.subSnowRenderers;
			      v6 = (HGSceneEffectSnowRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer);
			      v7 = v6;
			      if ( v6 )
			      {
			        HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::HGSceneEffectSnowRenderer(v6, 0LL);
			        v7->fields._.snowRenderQueue = 3000;
			        if ( v5 )
			        {
			          sub_182F01190(v5, (Object *)v7);
			          return;
			        }
			      }
			    }
			LABEL_3:
			    sub_1800D8260(subSnowRenderers, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(818, 0LL);
			  if ( !Patch )
			    goto LABEL_3;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			public void PrepareResources(SnowCommonResources commonResources) {} // 0x000000018474F1B0-0x000000018474F2C0
			// Void PrepareResources(SnowCommonResources)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PrepareResources(
			        HGSnowRenderer_SnowRenderSeq *this,
			        SnowCommonResources *commonResources,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  List_1_System_UInt64_ *subSnowRenderers; // rbx
			  Object *current; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			  Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-48h] BYREF
			  List_1_T_Enumerator_System_Object_ v13; // [rsp+28h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v14; // [rsp+40h] [rbp-28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(819, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(819, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v11, v10);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)this,
			      (Object *)commonResources,
			      0LL);
			  }
			  else
			  {
			    subSnowRenderers = (List_1_System_UInt64_ *)this->fields.subSnowRenderers;
			    if ( !subSnowRenderers )
			      sub_1800D8260(v6, v5);
			    System::Collections::Generic::List<unsigned long>::GetEnumerator(
			      (List_1_T_Enumerator_System_UInt64_ *)&v13,
			      subSnowRenderers,
			      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
			    v14 = v13;
			    v13._list = 0LL;
			    *(_QWORD *)&v13._index = &v14;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v14,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
			      {
			        current = v14._current;
			        if ( v14._current )
			        {
			          sub_1800049A0(v14._current->klass);
			          ((void (__fastcall *)(Object *, SnowCommonResources *, const char *))current->klass[1]._0.gc_desc)(
			            current,
			            commonResources,
			            current->klass[1]._0.name);
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v12 )
			    {
			      v13._list = (List_1_System_Object_ *)v12->ex;
			      if ( v13._list )
			        sub_18007E1E0(v13._list);
			    }
			  }
			}
			
			public void PerFrameClear() {} // 0x00000001832DCB60-0x00000001832DCDC0
			// Void PerFrameClear()
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PerFrameClear(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v2; // r8
			  Int32__Array **v3; // r9
			  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rax
			  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *v12; // rbx
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  __int64 v15; // r8
			  Object *v16; // rbx
			  struct ILFixDynamicMethodWrapper_2__Class *v17; // rcx
			  ILFixDynamicMethodWrapper_2__Array *v18; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v19; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v20; // rcx
			  ILFixDynamicMethodWrapper_39 *v21; // rcx
			  MethodInfo *v22; // [rsp+20h] [rbp-48h] BYREF
			  _BYTE v23[64]; // [rsp+28h] [rbp-40h] BYREF
			
			  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v5->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v5, method);
			  if ( wrapperArray->max_length.size <= 668 )
			    goto LABEL_55;
			  if ( !v5->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v5);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v7 = v5->static_fields->wrapperArray;
			  if ( !v7 )
			    sub_1800D8260(v5, method);
			  if ( v7->max_length.size <= 0x29Cu )
			    sub_1800D2AB0(v5, method);
			  if ( v7[18].vector[20] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(668, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			LABEL_55:
			    if ( this->fields.subSnowRenderers )
			    {
			      subSnowRenderers = this->fields.subSnowRenderers;
			      if ( subSnowRenderers->fields._size > 0 )
			      {
			        v12 = this->fields.subSnowRenderers;
			        *(_OWORD *)&v23[8] = 0LL;
			        *(_QWORD *)v23 = subSnowRenderers;
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)v23, (HGRuntimeGrassQuery_Node *)method, v2, v3, v22);
			        *(_DWORD *)&v23[8] = 0;
			        if ( !v12 )
			          sub_1800D8260(v14, v13);
			        *(_DWORD *)&v23[12] = v12->fields._version;
			        *(_QWORD *)&v23[16] = 0LL;
			        *(_OWORD *)&v23[24] = *(_OWORD *)v23;
			        *(_QWORD *)&v23[40] = 0LL;
			        *(_QWORD *)v23 = 0LL;
			        *(_QWORD *)&v23[8] = &v23[24];
			        try
			        {
			          while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                    (List_1_T_Enumerator_System_Object_ *)&v23[24],
			                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
			          {
			            v16 = *(Object **)&v23[40];
			            if ( *(_QWORD *)&v23[40] )
			            {
			              v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			              if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			              {
			                il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			                v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			              }
			              v18 = v17->static_fields->wrapperArray;
			              if ( !v18 )
			                sub_1800D8250(v17, 0LL);
			              if ( v18->max_length.size > 669 )
			              {
			                if ( !v17->_1.cctor_finished_or_no_cctor )
			                {
			                  il2cpp_runtime_class_init_1(v17);
			                  v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			                }
			                v19 = v17->static_fields->wrapperArray;
			                if ( !v19 )
			                  sub_1800D8250(v17, 0LL);
			                if ( v19->max_length.size <= 0x29Du )
			                  sub_1800D2AA0(v17, v19, v15);
			                if ( v19[18].vector[21] )
			                {
			                  if ( !v17->_1.cctor_finished_or_no_cctor )
			                  {
			                    il2cpp_runtime_class_init_1(v17);
			                    v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			                  }
			                  v20 = v17->static_fields->wrapperArray;
			                  if ( !v20 )
			                    sub_1800D8250(0LL, v19);
			                  if ( v20->max_length.size <= 0x29Du )
			                    sub_1800D2AA0(v20, v19, v15);
			                  v21 = (ILFixDynamicMethodWrapper_39 *)v20[18].vector[21];
			                  if ( !v21 )
			                    sub_1800D8250(0LL, v19);
			                  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(v21, v16, 0LL);
			                }
			              }
			            }
			          }
			        }
			        catch ( Il2CppExceptionWrapper *v22 )
			        {
			          *(_QWORD *)v23 = v22->methodPointer;
			          if ( *(_QWORD *)v23 )
			            sub_18007E1E0(*(_QWORD *)v23);
			        }
			      }
			    }
			  }
			}
			
			public void Dispose() {} // 0x0000000184A38F20-0x0000000184A39060
			// Void Dispose()
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  Object *current; // rbx
			  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  List_1_T_Enumerator_System_Object_ v8; // [rsp+28h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v9; // [rsp+40h] [rbp-28h] BYREF
			
			  memset(&v9, 0, sizeof(v9));
			  if ( IFix::WrappersManagerImpl::IsPatched(523, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(523, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    if ( this->fields.subSnowRenderers && this->fields.subSnowRenderers->fields._size > 0 )
			    {
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v8,
			        (List_1_System_UInt64_ *)this->fields.subSnowRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::GetEnumerator);
			      v9 = v8;
			      v8._list = 0LL;
			      *(_QWORD *)&v8._index = &v9;
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v9,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
			      {
			        current = v9._current;
			        if ( v9._current )
			        {
			          sub_1800049A0(v9._current->klass);
			          ((void (__fastcall *)(Object *, FieldInfo *))current->klass[1]._0.klass)(current, current->klass[1]._0.fields);
			        }
			      }
			    }
			    subSnowRenderers = this->fields.subSnowRenderers;
			    if ( subSnowRenderers )
			      sub_183127A90(
			        subSnowRenderers,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::Clear);
			  }
			}
			
			private void _UpdateDeltaTime() {} // 0x00000001832DE1E0-0x00000001832DE2D0
			// Void _UpdateDeltaTime()
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateDeltaTime(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  float time; // xmm0_4
			  struct HGSnowRenderer__Class *v6; // rcx
			  float v7; // xmm6_4
			  float m_lastTime; // xmm7_4
			  HGSnowRenderer__StaticFields *static_fields; // rax
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
			  if ( wrapperArray->max_length.size > 821 )
			  {
			    if ( !v3->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v3);
			      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			    if ( v3 )
			    {
			      if ( LODWORD(v3->_0.namespaze) <= 0x335 )
			        sub_1800D2AB0(v3, wrapperArray);
			      if ( !v3[17]._1.unity_user_data )
			        goto LABEL_5;
			      Patch = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
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
			  v6 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
			  v7 = time;
			  m_lastTime = this->fields.m_lastTime;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			    v6 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
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
			
			public void UpdateSnowDataSeq(SnowQualityParams qualityParams, ref ScriptableRenderContext renderContext) {} // 0x00000001832DDE80-0x00000001832DE0F0
			// Void UpdateSnowDataSeq(HGSnowRenderer+SnowQualityParams, ScriptableRenderContext ByRef)
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::UpdateSnowDataSeq(
			        HGSnowRenderer_SnowRenderSeq *this,
			        HGSnowRenderer_SnowQualityParams *qualityParams,
			        ScriptableRenderContext *renderContext,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			  Object *v7; // rsi
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
			  float time; // xmm0_4
			  struct HGSnowRenderer__Class *v10; // rcx
			  float v11; // xmm6_4
			  float m_lastTime; // xmm7_4
			  HGSnowRenderer__StaticFields *static_fields; // rax
			  float UPDATE_DELTA_TIME_THRESHOLD; // xmm0_4
			  HGCamera *hgCamera; // rdi
			  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rdi
			  SnowCommonRenderingParam *snowCommonRenderingParam; // rax
			  bool enable; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  ILFixDynamicMethodWrapper_2 *v20; // rax
			  ILFixDynamicMethodWrapper_2 *v21; // rax
			  ILFixDynamicMethodWrapper_2 *v22; // rax
			  ILFixDynamicMethodWrapper_2 *v23; // rax
			
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  v7 = (Object *)qualityParams;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v6->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_36;
			  if ( wrapperArray->max_length.size > 820 )
			  {
			    if ( !v6->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			    if ( !qualityParams )
			      goto LABEL_36;
			    if ( LODWORD(qualityParams[1].klass) <= 0x334 )
			      goto LABEL_72;
			    if ( qualityParams[274].fields )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(820, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(Patch, (Object *)this, v7, renderContext, 0LL);
			        return;
			      }
			      goto LABEL_36;
			    }
			  }
			  if ( !v6->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			  if ( !qualityParams )
			    goto LABEL_36;
			  if ( SLODWORD(qualityParams[1].klass) <= 821 )
			    goto LABEL_76;
			  if ( !v6->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			  if ( !qualityParams )
			    goto LABEL_36;
			  if ( LODWORD(qualityParams[1].klass) <= 0x335 )
			    goto LABEL_72;
			  if ( qualityParams[275].klass )
			  {
			    v20 = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
			    if ( !v20 )
			      goto LABEL_36;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v20, (Object *)this, 0LL);
			  }
			  else
			  {
			LABEL_76:
			    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			    time = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
			    v10 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
			    v11 = time;
			    m_lastTime = this->fields.m_lastTime;
			    if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			      v10 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
			    }
			    static_fields = v10->static_fields;
			    UPDATE_DELTA_TIME_THRESHOLD = v11 - m_lastTime;
			    if ( (float)-static_fields->UPDATE_DELTA_TIME_THRESHOLD > (float)(v11 - m_lastTime) )
			    {
			      UPDATE_DELTA_TIME_THRESHOLD = -static_fields->UPDATE_DELTA_TIME_THRESHOLD;
			    }
			    else if ( UPDATE_DELTA_TIME_THRESHOLD > static_fields->UPDATE_DELTA_TIME_THRESHOLD )
			    {
			      UPDATE_DELTA_TIME_THRESHOLD = static_fields->UPDATE_DELTA_TIME_THRESHOLD;
			    }
			    this->fields.m_lastTime = v11;
			    this->fields.m_deltaTime = UPDATE_DELTA_TIME_THRESHOLD;
			  }
			  HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
			    this,
			    this->fields.m_deltaTime,
			    (HGSnowRenderer_SnowQualityParams *)v7,
			    renderContext,
			    0LL);
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			  if ( !qualityParams )
			    goto LABEL_36;
			  if ( SLODWORD(qualityParams[1].klass) > 827 )
			  {
			    if ( !v6->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			    if ( !qualityParams )
			      goto LABEL_36;
			    if ( LODWORD(qualityParams[1].klass) <= 0x33B )
			      goto LABEL_72;
			    if ( qualityParams[277].klass )
			    {
			      v21 = IFix::WrappersManagerImpl::GetPatch(827, 0LL);
			      if ( v21 )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v21, (Object *)this, 0LL);
			        return;
			      }
			      goto LABEL_36;
			    }
			  }
			  hgCamera = this->fields.hgCamera;
			  if ( !hgCamera )
			    goto LABEL_36;
			  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
			  if ( !v6->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			  if ( !qualityParams )
			    goto LABEL_36;
			  if ( SLODWORD(qualityParams[1].klass) <= 828 )
			    goto LABEL_26;
			  if ( !v6->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			  if ( !qualityParams )
			    goto LABEL_36;
			  if ( LODWORD(qualityParams[1].klass) <= 0x33C )
			    goto LABEL_72;
			  if ( qualityParams[277].monitor )
			  {
			    v22 = IFix::WrappersManagerImpl::GetPatch(828, 0LL);
			    if ( !v22 )
			      goto LABEL_36;
			    enable = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v22, (Object *)this, 0LL);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  else
			  {
			LABEL_26:
			    snowCommonRenderingParam = this->fields.snowCommonRenderingParam;
			    if ( !snowCommonRenderingParam )
			      goto LABEL_36;
			    enable = snowCommonRenderingParam->fields.enable;
			  }
			  if ( !verticalOcclusionMapManager )
			    goto LABEL_36;
			  if ( !enable )
			  {
			    if ( !v6->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    qualityParams = (HGSnowRenderer_SnowQualityParams *)v6->static_fields->wrapperArray;
			    if ( !qualityParams )
			      goto LABEL_36;
			    if ( SLODWORD(qualityParams[1].klass) <= 816 )
			    {
			LABEL_34:
			      verticalOcclusionMapManager->fields.m_requestType &= ~4u;
			      return;
			    }
			    if ( !v6->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v6);
			      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
			    if ( !v6 )
			      goto LABEL_36;
			    if ( LODWORD(v6->_0.namespaze) > 0x330 )
			    {
			      if ( !v6[17]._0.implementedInterfaces )
			        goto LABEL_34;
			      v23 = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
			      if ( v23 )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			          (ILFixDynamicMethodWrapper_30 *)v23,
			          (Object *)verticalOcclusionMapManager,
			          4,
			          0LL);
			        return;
			      }
			LABEL_36:
			      sub_1800D8260(v6, qualityParams);
			    }
			LABEL_72:
			    sub_1800D2AB0(v6, qualityParams);
			  }
			  HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			    verticalOcclusionMapManager,
			    HGVerticalOcclusionMapManager_RequestUsageType__Enum_SnowOcclusion,
			    0LL);
			}
			
			private void _PrepareSnowRenderData(float deltaTime, SnowQualityParams qualityParams, ref ScriptableRenderContext renderContext) {} // 0x00000001832DCDC0-0x00000001832DD110
			// Void _PrepareSnowRenderData(Single, HGSnowRenderer+SnowQualityParams, ScriptableRenderContext ByRef)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
			        HGSnowRenderer_SnowRenderSeq *this,
			        float deltaTime,
			        HGSnowRenderer_SnowQualityParams *qualityParams,
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
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  __int64 v16; // rcx
			  HGRuntimeGrassQuery_Node *v17; // r8
			  Int32__Array **v18; // r9
			  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rbx
			  __int64 v20; // rdx
			  __int64 v21; // rcx
			  __int64 v22; // r8
			  HGBaseSubSnowRenderer *left; // rbx
			  SnowCommonRenderingParam *snowCommonRenderingParam; // rax
			  struct ILFixDynamicMethodWrapper_2__Class *v25; // rcx
			  ILFixDynamicMethodWrapper_2__Array *v26; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v27; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v28; // rcx
			  ILFixDynamicMethodWrapper_20 *monitor; // rcx
			  __int64 v30; // rdx
			  __int64 v31; // rcx
			  __int64 v32; // rdx
			  __int64 v33; // rcx
			  MethodInfo *P3; // [rsp+20h] [rbp-68h]
			  ScriptableRenderContext *P3a; // [rsp+20h] [rbp-68h]
			  HGRuntimeGrassQuery_Node v36; // [rsp+30h] [rbp-58h] BYREF
			
			  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v9->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v9, v5);
			  if ( wrapperArray->max_length.size <= 822 )
			    goto LABEL_13;
			  if ( !v9->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v9);
			    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v11 = v9->static_fields->wrapperArray;
			  if ( !v11 )
			    sub_1800D8260(v9, v5);
			  if ( v11->max_length.size <= 0x336u )
			    sub_1800D2AB0(v9, v5);
			  if ( v11[22].vector[30] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(822, 0LL);
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
			    HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateSnowCommonParams(this, deltaTime, qualityParams, 0LL);
			    subSnowRenderers = this->fields.subSnowRenderers;
			    if ( !subSnowRenderers )
			      sub_1800D8260(v16, v15);
			    *(_OWORD *)&v36.monitor = 0LL;
			    v36.klass = (HGRuntimeGrassQuery_Node__Class *)subSnowRenderers;
			    sub_18002D1B0(&v36, v15, v17, v18, P3);
			    LODWORD(v36.monitor) = 0;
			    HIDWORD(v36.monitor) = subSnowRenderers->fields._version;
			    *(_QWORD *)&v36.fields.bounds.m_Center.x = 0LL;
			    *(_OWORD *)&v36.fields.bounds.m_Extents.y = *(_OWORD *)&v36.klass;
			    v36.fields.left = 0LL;
			    v36.klass = 0LL;
			    v36.monitor = (MonitorData *)&v36.fields.bounds.m_Extents.y;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                (List_1_T_Enumerator_System_Object_ *)&v36.fields.bounds.m_Extents.y,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
			      {
			        left = (HGBaseSubSnowRenderer *)v36.fields.left;
			        snowCommonRenderingParam = this->fields.snowCommonRenderingParam;
			        if ( !snowCommonRenderingParam )
			          sub_1800D8250(v21, v20);
			        if ( snowCommonRenderingParam->fields.enable )
			        {
			          if ( !v36.fields.left )
			            sub_1800D8250(v21, v20);
			          *(float *)&P3a = deltaTime;
			          sub_1808B4BAC(v21, v36.fields.left, (_DWORD)this + 40, this->fields.hgCamera, (__int64)P3a);
			          if ( !left )
			            sub_1800D8250(v33, v32);
			          sub_18059DDC4(v33, left, &this->fields.snowCommonRenderingParam, renderContext);
			        }
			        else
			        {
			          if ( !v36.fields.left )
			            sub_1800D8250(v21, v20);
			          v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			            v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			          }
			          v26 = v25->static_fields->wrapperArray;
			          if ( !v26 )
			            sub_1800D8250(v25, 0LL);
			          if ( v26->max_length.size > 825 )
			          {
			            if ( !v25->_1.cctor_finished_or_no_cctor )
			            {
			              il2cpp_runtime_class_init_1(v25);
			              v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			            }
			            v27 = v25->static_fields->wrapperArray;
			            if ( !v27 )
			              sub_1800D8250(v25, 0LL);
			            if ( v27->max_length.size <= 0x339u )
			              sub_1800D2AA0(v25, v27, v22);
			            if ( v27[23].monitor )
			            {
			              if ( !v25->_1.cctor_finished_or_no_cctor )
			              {
			                il2cpp_runtime_class_init_1(v25);
			                v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			              }
			              v28 = v25->static_fields->wrapperArray;
			              if ( !v28 )
			                sub_1800D8250(0LL, v27);
			              if ( v28->max_length.size <= 0x339u )
			                sub_1800D2AA0(v28, v27, v22);
			              monitor = (ILFixDynamicMethodWrapper_20 *)v28[23].monitor;
			              if ( !monitor )
			                sub_1800D8250(0LL, v27);
			              if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(monitor, (Object *)left, 0LL) )
			              {
			                if ( !left )
			                  sub_1800D8250(v31, v30);
			                HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::ClearData(left, 0LL);
			              }
			            }
			          }
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *(HGRuntimeGrassQuery_Node *)&v36.fields.bounds.m_Center.z )
			    {
			      v36.klass = **(HGRuntimeGrassQuery_Node__Class ***)&v36.fields.bounds.m_Center.z;
			      if ( v36.klass )
			        sub_18007E1E0(v36.klass);
			    }
			  }
			}
			
			private void _UpdateSnowCommonParams(float deltaTime, SnowQualityParams qualityParams) {} // 0x00000001832DBD90-0x00000001832DC700
			// Void _UpdateSnowCommonParams(Single, HGSnowRenderer+SnowQualityParams)
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_UpdateSnowCommonParams(
			        HGSnowRenderer_SnowRenderSeq *this,
			        float deltaTime,
			        HGSnowRenderer_SnowQualityParams *qualityParams,
			        MethodInfo *method)
			{
			  char *snowCommonPreSettingParam; // rcx
			  SnowCommonRenderingParam *v8; // rdx
			  HGCamera *hgCamera; // rsi
			  HGEnvironmentPhase *InterpolatedPhase; // rax
			  __int64 v11; // xmm0_8
			  __m128 v12; // xmm7
			  Color color; // xmm13
			  __m128 v14; // xmm10
			  __m128 v15; // xmm8
			  __m128 v16; // xmm12
			  HGCamera *v17; // rax
			  Object *camera; // rsi
			  SnowCommonRenderingParam *snowCommonRenderingParam; // rax
			  HGCamera *v20; // rax
			  Camera *v21; // rsi
			  unsigned __int8 (__fastcall *v22)(Camera *); // rax
			  HGCamera *v23; // rax
			  Camera *v24; // rsi
			  double (__fastcall *v25)(Camera *); // rax
			  double v26; // xmm0_8
			  struct HGSnowRenderer__Class *v27; // rcx
			  float v28; // xmm6_4
			  __m128 v29; // xmm9
			  float v30; // xmm6_4
			  SnowCommonRenderingParam *v31; // rax
			  SnowCommonRenderingParam *v32; // rax
			  SnowCommonRenderingParam *v33; // rax
			  SnowCommonRenderingParam *v34; // rax
			  SnowCommonRenderingParam *v35; // rax
			  SnowCommonRenderingParam *v36; // rax
			  SnowCommonRenderingParam *v37; // rax
			  SnowCommonRenderingParam *v38; // rax
			  SnowCommonRenderingParam *v39; // rax
			  SnowCommonRenderingParam *v40; // rax
			  SnowCommonRenderingParam *v41; // rax
			  SnowCommonRenderingParam *v42; // rax
			  HGCamera *v43; // rax
			  Camera *v44; // rdi
			  __int64 (__fastcall *v45)(Camera *); // rax
			  __int64 v46; // rdi
			  void (__fastcall *v47)(__int64, __int64 *); // rax
			  SnowCommonRenderingParam *v48; // rax
			  float v49; // xmm8_4
			  float v50; // xmm7_4
			  __m128 v51; // xmm6
			  SnowCommonRenderingParam *v52; // rax
			  float *v53; // rax
			  __m128 v54; // xmm2
			  __m128 v55; // xmm12
			  __m128 v56; // xmm0
			  float v57; // xmm1_4
			  __int64 v58; // rax
			  float v59; // esi
			  SnowCommonRenderingParam *v60; // rax
			  SnowCommonPreSettingParam *v61; // rax
			  float v62; // xmm0_4
			  SnowCommonRenderingParam *v63; // rdi
			  float z; // xmm3_4
			  float v65; // xmm5_4
			  float v66; // xmm4_4
			  __m128 v67; // xmm6
			  __m128 v68; // xmm2
			  __m128 v69; // xmm1
			  __int64 v70; // rax
			  SnowCommonRenderingParam *v71; // rax
			  SnowCommonRenderingParam *v72; // rax
			  SnowCommonRenderingParam *v73; // rdi
			  __int64 v74; // rax
			  SnowCommonRenderingParam *v75; // rax
			  float v76; // xmm2_4
			  float v77; // xmm1_4
			  __int64 v78; // rax
			  __int64 v79; // rax
			  __int64 v80; // rax
			  __int64 v81; // rax
			  unsigned __int64 v82; // [rsp+30h] [rbp-D0h] BYREF
			  float v83; // [rsp+38h] [rbp-C8h]
			  __int64 v84; // [rsp+40h] [rbp-C0h] BYREF
			  float v85; // [rsp+48h] [rbp-B8h]
			  float v86[4]; // [rsp+50h] [rbp-B0h] BYREF
			  _QWORD v87[12]; // [rsp+60h] [rbp-A0h] BYREF
			  float v88[4]; // [rsp+C0h] [rbp-40h]
			
			  snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v8 = (SnowCommonRenderingParam *)**((_QWORD **)snowCommonPreSettingParam + 23);
			  if ( !v8 )
			    goto LABEL_104;
			  if ( SLODWORD(v8->fields.speed.x) > 823 )
			  {
			    if ( !*((_DWORD *)snowCommonPreSettingParam + 56) )
			    {
			      il2cpp_runtime_class_init_1(snowCommonPreSettingParam);
			      snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v8 = (SnowCommonRenderingParam *)**((_QWORD **)snowCommonPreSettingParam + 23);
			    if ( !v8 )
			      goto LABEL_104;
			    if ( LODWORD(v8->fields.speed.x) <= 0x337 )
			      goto LABEL_105;
			    if ( v8[51].fields.snowSizeRange )
			    {
			      if ( !*((_DWORD *)snowCommonPreSettingParam + 56) )
			      {
			        il2cpp_runtime_class_init_1(snowCommonPreSettingParam);
			        snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      snowCommonPreSettingParam = (char *)**((_QWORD **)snowCommonPreSettingParam + 23);
			      if ( !snowCommonPreSettingParam )
			        goto LABEL_104;
			      if ( *((_DWORD *)snowCommonPreSettingParam + 6) > 0x337u )
			      {
			        snowCommonPreSettingParam = (char *)*((_QWORD *)snowCommonPreSettingParam + 827);
			        if ( snowCommonPreSettingParam )
			        {
			          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
			            (ILFixDynamicMethodWrapper_4 *)snowCommonPreSettingParam,
			            (Object *)this,
			            deltaTime,
			            (Object *)qualityParams,
			            0LL);
			          return;
			        }
			LABEL_104:
			        sub_1800D8250(snowCommonPreSettingParam, v8);
			      }
			LABEL_105:
			      sub_1800D2AA0(snowCommonPreSettingParam, v8, qualityParams);
			    }
			  }
			  hgCamera = this->fields.hgCamera;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			  if ( !InterpolatedPhase )
			    goto LABEL_104;
			  v11 = *(_QWORD *)&InterpolatedPhase->fields.snowConfig.snowDirection.z;
			  v12 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.enable;
			  color = InterpolatedPhase->fields.snowConfig.color;
			  v14 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.snowSizeRange.x;
			  v15 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.snowTrailLength;
			  v16 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.snowLightingPercent;
			  v17 = this->fields.hgCamera;
			  *(_QWORD *)v88 = v11;
			  if ( !v17 )
			    goto LABEL_104;
			  camera = (Object *)v17->fields.camera;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
			  snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v8 = (SnowCommonRenderingParam *)**((_QWORD **)snowCommonPreSettingParam + 23);
			  if ( !v8 )
			    goto LABEL_104;
			  if ( SLODWORD(v8->fields.speed.x) > 804 )
			  {
			    if ( !*((_DWORD *)snowCommonPreSettingParam + 56) )
			    {
			      il2cpp_runtime_class_init_1(snowCommonPreSettingParam);
			      snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v8 = (SnowCommonRenderingParam *)**((_QWORD **)snowCommonPreSettingParam + 23);
			    if ( !v8 )
			      goto LABEL_104;
			    if ( LODWORD(v8->fields.speed.x) <= 0x324 )
			      goto LABEL_105;
			    if ( *(_QWORD *)&v8[50].fields.lastCamPos.y )
			    {
			      if ( !*((_DWORD *)snowCommonPreSettingParam + 56) )
			      {
			        il2cpp_runtime_class_init_1(snowCommonPreSettingParam);
			        snowCommonPreSettingParam = (char *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      snowCommonPreSettingParam = (char *)**((_QWORD **)snowCommonPreSettingParam + 23);
			      if ( !snowCommonPreSettingParam )
			        goto LABEL_104;
			      if ( *((_DWORD *)snowCommonPreSettingParam + 6) <= 0x324u )
			        goto LABEL_105;
			      snowCommonPreSettingParam = (char *)*((_QWORD *)snowCommonPreSettingParam + 808);
			      if ( !snowCommonPreSettingParam )
			        goto LABEL_104;
			      if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			             (ILFixDynamicMethodWrapper_20 *)snowCommonPreSettingParam,
			             camera,
			             0LL) )
			      {
			        snowCommonRenderingParam = this->fields.snowCommonRenderingParam;
			        if ( snowCommonRenderingParam )
			        {
			          snowCommonRenderingParam->fields.enable = 0;
			          return;
			        }
			        goto LABEL_104;
			      }
			    }
			  }
			  v20 = this->fields.hgCamera;
			  if ( !v20 )
			    goto LABEL_104;
			  v21 = v20->fields.camera;
			  if ( !v21 )
			    goto LABEL_104;
			  v22 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
			  if ( !qword_18F36F100 )
			  {
			    v22 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
			    if ( !v22 )
			    {
			      v78 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
			      sub_18007E1B0(v78, 0LL);
			    }
			    qword_18F36F100 = (__int64)v22;
			  }
			  if ( v22(v21) )
			  {
			    v29 = 0LL;
			LABEL_57:
			    v30 = 0.0;
			    goto LABEL_58;
			  }
			  v23 = this->fields.hgCamera;
			  if ( !v23 )
			    goto LABEL_104;
			  v24 = v23->fields.camera;
			  if ( !v24 )
			    goto LABEL_104;
			  v25 = (double (__fastcall *)(Camera *))qword_18F36F0D0;
			  if ( !qword_18F36F0D0 )
			  {
			    v25 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_fieldOfView()");
			    if ( !v25 )
			    {
			      v79 = sub_1802EE1B8("UnityEngine.Camera::get_fieldOfView()");
			      sub_18007E1B0(v79, 0LL);
			    }
			    qword_18F36F0D0 = (__int64)v25;
			  }
			  v26 = v25(v24);
			  v27 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
			  v28 = *(float *)&v26;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			    v27 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
			  }
			  v29 = 0LL;
			  v30 = (float)(v28 - v27->static_fields->FOV_FADE_LOWERTHRESHOLD)
			      / (float)(v27->static_fields->FOV_FADE_HIGHERTHRESHOLD - v27->static_fields->FOV_FADE_LOWERTHRESHOLD);
			  if ( v30 < 0.0 )
			    goto LABEL_57;
			  if ( v30 > 1.0 )
			    v30 = 1.0;
			LABEL_58:
			  snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			  if ( !snowCommonPreSettingParam )
			    goto LABEL_104;
			  snowCommonPreSettingParam[16] = _mm_cvtsi128_si32((__m128i)v12);
			  v31 = this->fields.snowCommonRenderingParam;
			  if ( !v31 )
			    goto LABEL_104;
			  v31->fields.intensity = _mm_shuffle_ps(v12, v12, 85).m128_f32[0] * v30;
			  v32 = this->fields.snowCommonRenderingParam;
			  if ( !v32 )
			    goto LABEL_104;
			  LODWORD(v32->fields.speed.y) = _mm_shuffle_ps(v12, v12, 255).m128_u32[0];
			  LODWORD(v32->fields.speed.x) = _mm_shuffle_ps(v12, v12, 170).m128_u32[0];
			  v33 = this->fields.snowCommonRenderingParam;
			  if ( !v33 )
			    goto LABEL_104;
			  v33->fields.color = color;
			  v34 = this->fields.snowCommonRenderingParam;
			  if ( !v34 )
			    goto LABEL_104;
			  v34->fields.color.a = v30 * v34->fields.color.a;
			  v35 = this->fields.snowCommonRenderingParam;
			  if ( !v35 )
			    goto LABEL_104;
			  LODWORD(v35->fields.snowLightingPercent) = v16.m128_i32[0];
			  v36 = this->fields.snowCommonRenderingParam;
			  if ( !v36 )
			    goto LABEL_104;
			  LODWORD(v36->fields.snowCollisionFadeTimeScale) = _mm_shuffle_ps(v16, v16, 85).m128_u32[0];
			  v37 = this->fields.snowCommonRenderingParam;
			  if ( !v37 )
			    goto LABEL_104;
			  LODWORD(v37->fields.snowSizeRange.x) = v14.m128_i32[0];
			  LODWORD(v37->fields.snowSizeRange.y) = _mm_shuffle_ps(v14, v14, 85).m128_u32[0];
			  if ( !qualityParams )
			    goto LABEL_104;
			  snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			  if ( !snowCommonPreSettingParam )
			    goto LABEL_104;
			  snowCommonPreSettingParam[104] = qualityParams->fields.enableSnowLighting;
			  snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			  if ( !snowCommonPreSettingParam )
			    goto LABEL_104;
			  snowCommonPreSettingParam[112] = qualityParams->fields.enableSnowCollision;
			  v38 = this->fields.snowCommonRenderingParam;
			  if ( !v38 )
			    goto LABEL_104;
			  LODWORD(v38->fields.snowJitterLevel) = _mm_shuffle_ps(v15, v15, 85).m128_u32[0];
			  v39 = this->fields.snowCommonRenderingParam;
			  if ( !v39 )
			    goto LABEL_104;
			  LODWORD(v39->fields.snowSpeedNoiseLevel) = _mm_shuffle_ps(v15, v15, 170).m128_u32[0];
			  v40 = this->fields.snowCommonRenderingParam;
			  if ( !v40 )
			    goto LABEL_104;
			  LODWORD(v40->fields.snowSpeedNoiseFreq) = _mm_shuffle_ps(v15, v15, 255).m128_u32[0];
			  v41 = this->fields.snowCommonRenderingParam;
			  if ( !v41 )
			    goto LABEL_104;
			  LODWORD(v41->fields.snowTrailLength) = v15.m128_i32[0];
			  snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			  if ( !snowCommonPreSettingParam )
			    goto LABEL_104;
			  *((_DWORD *)snowCommonPreSettingParam + 27) = qualityParams->fields.snowLayerCount;
			  snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			  if ( !snowCommonPreSettingParam )
			    goto LABEL_104;
			  *((_DWORD *)snowCommonPreSettingParam + 29) = this->fields.cameraMask;
			  v42 = this->fields.snowCommonRenderingParam;
			  if ( !v42 )
			    goto LABEL_104;
			  if ( v42->fields.enable )
			  {
			    v43 = this->fields.hgCamera;
			    if ( !v43 )
			      goto LABEL_104;
			    v44 = v43->fields.camera;
			    if ( !v44 )
			      goto LABEL_104;
			    v45 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
			    if ( !qword_18F36FBC0 )
			    {
			      v45 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
			      if ( !v45 )
			      {
			        v80 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
			        sub_18007E1B0(v80, 0LL);
			      }
			      qword_18F36FBC0 = (__int64)v45;
			    }
			    v46 = v45(v44);
			    if ( !v46 )
			      goto LABEL_104;
			    v84 = 0LL;
			    v85 = 0.0;
			    v47 = (void (__fastcall *)(__int64, __int64 *))qword_18F3700F0;
			    if ( !qword_18F3700F0 )
			    {
			      v47 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_1(
			                                                       "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			      if ( !v47 )
			      {
			        v81 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			        sub_18007E1B0(v81, 0LL);
			      }
			      qword_18F3700F0 = (__int64)v47;
			    }
			    v47(v46, &v84);
			    v48 = this->fields.snowCommonRenderingParam;
			    if ( !v48 )
			      goto LABEL_104;
			    v49 = v85;
			    v51 = (__m128)(unsigned int)v84;
			    v50 = v85 - v48->fields.lastCamPos.z;
			    *(_QWORD *)v86 = *(_QWORD *)&v48->fields.lastCamPos.x;
			    v51.m128_f32[0] = *(float *)&v84 - v86[0];
			    snowCommonPreSettingParam = (char *)TypeInfo::Beyond::MathUtils;
			    if ( !TypeInfo::Beyond::MathUtils->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::Beyond::MathUtils);
			    v52 = this->fields.snowCommonRenderingParam;
			    if ( !v52 )
			      goto LABEL_104;
			    snowCommonPreSettingParam = (char *)v52->fields.snowCommonPreSettingParam;
			    if ( !snowCommonPreSettingParam )
			      goto LABEL_104;
			    v82 = _mm_unpacklo_ps(v51, v29).m128_u64[0];
			    v83 = v50;
			    v53 = (float *)sub_182F5BF40(v86, &v82);
			    v54 = _mm_shuffle_ps(v16, v16, 170);
			    v55 = _mm_shuffle_ps(v16, v16, 255);
			    v56 = (__m128)*(unsigned __int64 *)v53;
			    v82 = v56.m128_u64[0];
			    v54.m128_f32[0] = v54.m128_f32[0] - v56.m128_f32[0];
			    v55.m128_f32[0] = v55.m128_f32[0] - _mm_shuffle_ps(v56, v56, 85).m128_f32[0];
			    v57 = v88[0] - v53[2];
			    v82 = _mm_unpacklo_ps(v54, v55).m128_u64[0];
			    v83 = v57;
			    v58 = sub_182FAE2B0(v87, &v82);
			    snowCommonPreSettingParam = (char *)this->fields.snowCommonRenderingParam;
			    v59 = *(float *)(v58 + 8);
			    *(_QWORD *)v86 = *(_QWORD *)v58;
			    if ( !snowCommonPreSettingParam )
			      goto LABEL_104;
			    *(_QWORD *)(snowCommonPreSettingParam + 60) = v84;
			    *((float *)snowCommonPreSettingParam + 17) = v49;
			    v60 = this->fields.snowCommonRenderingParam;
			    if ( !v60 )
			      goto LABEL_104;
			    v61 = v60->fields.snowCommonPreSettingParam;
			    if ( !v61 )
			      goto LABEL_104;
			    v62 = HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
			            v61->fields.snowTemporalTimeThreshold,
			            deltaTime,
			            0LL);
			    v63 = this->fields.snowCommonRenderingParam;
			    if ( !v63 )
			      goto LABEL_104;
			    z = v63->fields.snowDirection.z;
			    v65 = _mm_shuffle_ps(
			            (__m128)*(unsigned __int64 *)&v63->fields.snowDirection.x,
			            (__m128)*(unsigned __int64 *)&v63->fields.snowDirection.x,
			            85).m128_f32[0]
			        * v62;
			    v66 = COERCE_FLOAT(*(_QWORD *)&v63->fields.snowDirection.x) * v62;
			    v87[0] = *(_QWORD *)&v63->fields.snowDirection.x;
			    v67 = (__m128)0x3F800000u;
			    v67.m128_f32[0] = 1.0 - v62;
			    v68 = v67;
			    v69 = v67;
			    v68.m128_f32[0] = (float)((float)(1.0 - v62) * v86[0]) + v66;
			    v69.m128_f32[0] = (float)((float)(1.0 - v62) * v86[1]) + v65;
			    v82 = _mm_unpacklo_ps(v68, v69).m128_u64[0];
			    v83 = (float)((float)(1.0 - v62) * v59) + (float)(z * v62);
			    v70 = sub_182FAE2B0(v87, &v82);
			    snowCommonPreSettingParam = (char *)*(unsigned int *)(v70 + 8);
			    *(_QWORD *)&v63->fields.snowDirection.x = *(_QWORD *)v70;
			    LODWORD(v63->fields.snowDirection.z) = (_DWORD)snowCommonPreSettingParam;
			    v71 = this->fields.snowCommonRenderingParam;
			    if ( !v71 )
			      goto LABEL_104;
			    v71->fields.snowDirection.x = v71->fields.snowDirection.x * 4.0;
			    v72 = this->fields.snowCommonRenderingParam;
			    if ( !v72 )
			      goto LABEL_104;
			    v72->fields.snowDirection.z = v72->fields.snowDirection.z * 4.0;
			    v73 = this->fields.snowCommonRenderingParam;
			    v8 = v73;
			    if ( !v73 )
			      goto LABEL_104;
			    v74 = sub_182FAE2B0(v87, &v73->fields.snowDirection);
			    snowCommonPreSettingParam = (char *)*(unsigned int *)(v74 + 8);
			    *(_QWORD *)&v73->fields.snowDirection.x = *(_QWORD *)v74;
			    LODWORD(v73->fields.snowDirection.z) = (_DWORD)snowCommonPreSettingParam;
			    v75 = this->fields.snowCommonRenderingParam;
			    if ( !v75 )
			      goto LABEL_104;
			    v76 = 1.0
			        / fmaxf(
			            fabs(
			              (float)((float)(_mm_shuffle_ps(
			                                (__m128)*(unsigned __int64 *)&v75->fields.snowDirection.x,
			                                (__m128)*(unsigned __int64 *)&v75->fields.snowDirection.x,
			                                85).m128_f32[0]
			                            * -1.0)
			                    + (float)(COERCE_FLOAT(*(_QWORD *)&v75->fields.snowDirection.x) * v29.m128_f32[0]))
			            + (float)(v75->fields.snowDirection.z * v29.m128_f32[0])),
			            0.0099999998);
			    if ( v76 < 1.0 )
			    {
			      v76 = 1.0;
			    }
			    else if ( v76 > 2.0 )
			    {
			      v76 = 2.0;
			    }
			    v77 = v75->fields.speed.y * v76;
			    v75->fields.speed.x = v75->fields.speed.x * v76;
			    v75->fields.speed.y = v77;
			  }
			}
			
			private void _RequestOcclusionMap() {} // 0x00000001832DD900-0x00000001832DDA10
			// Void _RequestOcclusionMap()
			void HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_RequestOcclusionMap(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
			  HGSnowRenderer_SnowRenderSeq *v3; // rdi
			  int *static_fields; // rdx
			  HGCamera *hgCamera; // rbx
			  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rbx
			  __int64 v7; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // r8
			  ILFixDynamicMethodWrapper_2 *v10; // rax
			  HGSnowRenderer_SnowRenderSeq__Class *klass; // rax
			  ILFixDynamicMethodWrapper_2 *v12; // rax
			
			  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  v3 = this;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  static_fields = (int *)v2->static_fields;
			  if ( !*(_QWORD *)static_fields )
			    goto LABEL_19;
			  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 827 )
			  {
			    if ( !v2->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v2);
			      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    static_fields = (int *)v2->static_fields;
			    v7 = *(_QWORD *)static_fields;
			    if ( !*(_QWORD *)static_fields )
			      goto LABEL_19;
			    if ( *(_DWORD *)(v7 + 24) <= 0x33Bu )
			      goto LABEL_41;
			    if ( *(_QWORD *)(v7 + 6648) )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(827, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v3, 0LL);
			        return;
			      }
			      goto LABEL_19;
			    }
			  }
			  hgCamera = v3->fields.hgCamera;
			  if ( !hgCamera )
			    goto LABEL_19;
			  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
			  if ( !v2->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v2);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  this = (HGSnowRenderer_SnowRenderSeq *)v2->static_fields;
			  static_fields = (int *)this->klass;
			  if ( !this->klass )
			    goto LABEL_19;
			  if ( static_fields[6] <= 828 )
			    goto LABEL_10;
			  if ( !v2->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v2);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  static_fields = (int *)v2->static_fields;
			  v9 = *(_QWORD *)static_fields;
			  if ( !*(_QWORD *)static_fields )
			    goto LABEL_19;
			  if ( *(_DWORD *)(v9 + 24) <= 0x33Cu )
			    goto LABEL_41;
			  if ( *(_QWORD *)(v9 + 6656) )
			  {
			    v10 = IFix::WrappersManagerImpl::GetPatch(828, 0LL);
			    if ( !v10 )
			      goto LABEL_19;
			    this = (HGSnowRenderer_SnowRenderSeq *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			                                             (ILFixDynamicMethodWrapper_20 *)v10,
			                                             (Object *)v3,
			                                             0LL);
			    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  else
			  {
			LABEL_10:
			    this = (HGSnowRenderer_SnowRenderSeq *)v3->fields.snowCommonRenderingParam;
			    if ( !this )
			      goto LABEL_19;
			    this = (HGSnowRenderer_SnowRenderSeq *)LOBYTE(this->fields.hgCamera);
			  }
			  if ( !verticalOcclusionMapManager )
			    goto LABEL_19;
			  if ( !(_BYTE)this )
			  {
			    if ( !v2->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v2);
			      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    this = (HGSnowRenderer_SnowRenderSeq *)v2->static_fields;
			    static_fields = (int *)this->klass;
			    if ( !this->klass )
			      goto LABEL_19;
			    if ( static_fields[6] <= 816 )
			    {
			LABEL_18:
			      verticalOcclusionMapManager->fields.m_requestType &= ~4u;
			      return;
			    }
			    if ( !v2->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v2);
			      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    this = (HGSnowRenderer_SnowRenderSeq *)v2->static_fields;
			    klass = this->klass;
			    if ( !this->klass )
			      goto LABEL_19;
			    if ( LODWORD(klass->_0.namespaze) > 0x330 )
			    {
			      if ( !klass[17]._0.implementedInterfaces )
			        goto LABEL_18;
			      v12 = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
			      if ( v12 )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			          (ILFixDynamicMethodWrapper_30 *)v12,
			          (Object *)verticalOcclusionMapManager,
			          4,
			          0LL);
			        return;
			      }
			LABEL_19:
			      sub_1800D8260(this, static_fields);
			    }
			LABEL_41:
			    sub_1800D2AB0(this, static_fields);
			  }
			  HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			    verticalOcclusionMapManager,
			    HGVerticalOcclusionMapManager_RequestUsageType__Enum_SnowOcclusion,
			    0LL);
			}
			
			public bool ShouldRequestSnowOcclusionMap() => default; // 0x00000001832DDA10-0x00000001832DDA70
			// Boolean ShouldRequestSnowOcclusionMap()
			bool HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::ShouldRequestSnowOcclusionMap(
			        HGSnowRenderer_SnowRenderSeq *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  SnowCommonRenderingParam *snowCommonRenderingParam; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_7;
			  if ( wrapperArray->max_length.size <= 828 )
			    goto LABEL_5;
			  if ( !v3->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v3);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			  if ( !v3 )
			    goto LABEL_7;
			  if ( LODWORD(v3->_0.namespaze) <= 0x33C )
			    sub_1800D2AB0(v3, wrapperArray);
			  if ( !*(_QWORD *)&v3[17]._1.static_fields_size )
			  {
			LABEL_5:
			    snowCommonRenderingParam = this->fields.snowCommonRenderingParam;
			    if ( snowCommonRenderingParam )
			      return snowCommonRenderingParam->fields.enable;
			LABEL_7:
			    sub_1800D8260(v3, wrapperArray);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(828, 0LL);
			  if ( !Patch )
			    goto LABEL_7;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			}
			
		}
	
		private class SnowQualityParams // TypeDefIndex: 37689
		{
			// Fields
			public bool enableSnowLighting; // 0x10
			public bool enableSnowCollision; // 0x11
			public int snowLayerCount; // 0x14
	
			// Constructors
			public SnowQualityParams() {} // 0x0000000184D9E080-0x0000000184D9E090
			// Primvar`1[System.Object]()
			void USD::NET::Primvar<System::Object>::Primvar(Primvar_1_System_Object_ *this, MethodInfo *method)
			{
			  this->fields._.elementSize = 1;
			}
			
		}
	
		// Constructors
		public HGSnowRenderer() {} // 0x00000001831D38E0-0x00000001831D39A0
		// HGSnowRenderer()
		void HG::Rendering::Runtime::HGSnowRenderer::HGSnowRenderer(HGSnowRenderer *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  SnowCommonPreSettingParam *v10; // rax
		  SnowCommonPreSettingParam *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  SnowCommonResources *v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGSnowRenderer_SnowQualityParams *v18; // rax
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>);
		  v6 = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)v3;
		  if ( !v3 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::List);
		  this->fields.m_snowRenderSeqs = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v21);
		  v10 = (SnowCommonPreSettingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam);
		  v11 = v10;
		  if ( !v10
		    || (HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(v10, 0LL),
		        this->fields.m_snowCommonPreSettingParam = v11,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_snowCommonPreSettingParam, v12, v13, v14, v22),
		        (v15 = (SnowCommonResources *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonResources)) == 0LL)
		    || (this->fields.m_snowCommonResources = v15,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_snowCommonResources, v4, v16, v17, v23),
		        (v18 = (HGSnowRenderer_SnowQualityParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer::SnowQualityParams)) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  }
		  v18->fields.snowLayerCount = 1;
		  this->fields.m_qualityParams = v18;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_qualityParams, v4, v19, v20, v24);
		}
		
		static HGSnowRenderer() {} // 0x0000000184CC3560-0x0000000184CC3670
		// HGSnowRenderer()
		void HG::Rendering::Runtime::HGSnowRenderer::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->EDITOR_KW = (String *)"HG_EDITOR";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields,
		    v1,
		    v2,
		    v3,
		    v13);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->LIGHTING_KW = (String *)"RAIN_LIGHTING";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->LIGHTING_KW,
		    v5,
		    v6,
		    v4,
		    v14);
		  v7 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->SNOWFLAKE_KW = (String *)"SNOW_FLAKE";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->SNOWFLAKE_KW,
		    v8,
		    v9,
		    v7,
		    v15);
		  v10 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->SNOW_COLLISION_KW = (String *)"SNOW_COLLISION";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->SNOW_COLLISION_KW,
		    v11,
		    v12,
		    v10,
		    v16);
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->UPDATE_DELTA_TIME_THRESHOLD = 0.033;
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->FOV_FADE_HIGHERTHRESHOLD = 20.0;
		  TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->static_fields->FOV_FADE_LOWERTHRESHOLD = 10.0;
		}
		
	
		// Methods
		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources, HGSettingParameters settingParameters) {} // 0x00000001849BF1E0-0x00000001849BF300
		// Void PrepareResources(HGRenderPipelineRuntimeResources, HGSettingParameters)
		void HG::Rendering::Runtime::HGSnowRenderer::PrepareResources(
		        HGSnowRenderer *this,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *sceneEffectRainMesh; // rdx
		  SnowCommonResources *m_snowCommonResources; // rcx
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  HGSnowPresettingAsset *snowPresettingAsset; // rsi
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  struct Object_1__Class *v13; // rcx
		  HGRenderPipelineRuntimeResources_AssetResources *v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1669, 0LL) )
		  {
		    if ( defaultResources )
		    {
		      assets = defaultResources->fields.assets;
		      if ( assets )
		      {
		        snowPresettingAsset = assets->fields.snowPresettingAsset;
		        HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(this, settingParameters, 0LL);
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
		        if ( snowPresettingAsset )
		        {
		          if ( !v13->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v13);
		          if ( snowPresettingAsset->fields._._.m_CachedPtr )
		          {
		            this->fields.m_snowCommonPreSettingParam = snowPresettingAsset->fields.snowCommonPreSettingParam;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&this->fields.m_snowCommonPreSettingParam,
		              sceneEffectRainMesh,
		              v11,
		              v12,
		              methoda);
		          }
		        }
		        v14 = defaultResources->fields.assets;
		        m_snowCommonResources = this->fields.m_snowCommonResources;
		        if ( v14 )
		        {
		          sceneEffectRainMesh = (HGRuntimeGrassQuery_Node *)v14->fields.sceneEffectRainMesh;
		          if ( m_snowCommonResources )
		          {
		            m_snowCommonResources->fields.snowMesh = (Mesh *)sceneEffectRainMesh;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&m_snowCommonResources->fields,
		              sceneEffectRainMesh,
		              v11,
		              v12,
		              methoda);
		            shaders = defaultResources->fields.shaders;
		            m_snowCommonResources = this->fields.m_snowCommonResources;
		            if ( shaders )
		            {
		              sceneEffectRainMesh = (HGRuntimeGrassQuery_Node *)shaders->fields.sceneEffectRainPS;
		              if ( m_snowCommonResources )
		              {
		                m_snowCommonResources->fields.snowShader = (Shader *)sceneEffectRainMesh;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&m_snowCommonResources->fields.snowShader,
		                  sceneEffectRainMesh,
		                  v15,
		                  v16,
		                  methodb);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(m_snowCommonResources, sceneEffectRainMesh);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1669, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)defaultResources,
		    (Object *)settingParameters,
		    0LL);
		}
		
		internal void SnowPipelineUpdate(HGSettingParameters settingParameters) {} // 0x0000000182EE0670-0x0000000182EE0820
		// Void SnowPipelineUpdate(HGSettingParameters)
		void HG::Rendering::Runtime::HGSnowRenderer::SnowPipelineUpdate(
		        HGSnowRenderer *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v4; // rbx
		  void *items; // rcx
		  __int64 v6; // r8
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *m_snowRenderSeqs; // rbx
		  int32_t v8; // ebx
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v9; // rax
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
		  if ( *(int *)(v6 + 24) <= 662 )
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
		  if ( LODWORD(settingParameters->fields._ocScreenSizeMin_k__BackingField) <= 0x296 )
		LABEL_28:
		    sub_1800D2AB0(items, settingParameters);
		  if ( settingParameters[2].fields._inkSimulationResolution_k__BackingField )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(662, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, v4, 0LL);
		      return;
		    }
		    goto LABEL_25;
		  }
		LABEL_5:
		  HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(this, (HGSettingParameters *)v4, 0LL);
		  m_snowRenderSeqs = this->fields.m_snowRenderSeqs;
		  if ( !m_snowRenderSeqs )
		    goto LABEL_25;
		  v8 = m_snowRenderSeqs->fields._size - 1;
		  if ( v8 >= 0 )
		  {
		    while ( 1 )
		    {
		      v9 = this->fields.m_snowRenderSeqs;
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
		      HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PerFrameClear(
		        this->fields.m_snowRenderSeqs->fields._items->vector[v8],
		        0LL);
		      items = this->fields.m_snowRenderSeqs;
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
		      camera = this->fields.m_snowRenderSeqs->fields._items->vector[v8]->fields.hgCamera->fields.camera;
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
		        items = this->fields.m_snowRenderSeqs;
		        if ( !items )
		          goto LABEL_25;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)items,
		                 v8,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::get_Item);
		        if ( !Item )
		          goto LABEL_25;
		        HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose((HGSnowRenderer_SnowRenderSeq *)Item, 0LL);
		        items = this->fields.m_snowRenderSeqs;
		        if ( !items )
		          goto LABEL_25;
		        goto LABEL_41;
		      }
		LABEL_23:
		      if ( --v8 < 0 )
		        return;
		    }
		    items = this->fields.m_snowRenderSeqs;
		LABEL_41:
		    System::Collections::Generic::List<System::Object>::RemoveAt(
		      (List_1_System_Object_ *)items,
		      v8,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::RemoveAt);
		    goto LABEL_23;
		  }
		}
		
		private void _UpdateQualitySettings(HGSettingParameters settingParameters) {} // 0x000000018350DCB0-0x000000018350DEA0
		// Void _UpdateQualitySettings(HGSettingParameters)
		void HG::Rendering::Runtime::HGSnowRenderer::_UpdateQualitySettings(
		        HGSnowRenderer *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGSnowSettingParameters *snow_k__BackingField; // rbx
		  HGSnowRenderer_SnowQualityParams *m_qualityParams; // rsi
		  SettingParameter_1_System_Boolean_ *EnableSnowLighting_k__BackingField; // rdi
		  struct MethodInfo *v10; // rbp
		  Il2CppClass *klass; // rax
		  SettingParameter_1_System_Boolean_ *EnableSnowCollision_k__BackingField; // rsi
		  HGSnowRenderer_SnowQualityParams *v13; // rdi
		  struct MethodInfo *v14; // rbp
		  Il2CppClass *v15; // rax
		  SettingParameter_1_System_Int32_ *SnowLayerCount_k__BackingField; // rbx
		  HGSnowRenderer_SnowQualityParams *v17; // rdi
		  struct MethodInfo *v18; // rsi
		  Il2CppClass *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rax
		  __int64 v22; // rax
		  __int64 v23; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_32;
		  if ( wrapperArray->max_length.size <= 663 )
		    goto LABEL_30;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_32;
		  if ( LODWORD(v5->_0.namespaze) <= 0x297 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( !v5[14]._0.castClass )
		  {
		LABEL_30:
		    if ( settingParameters )
		    {
		      snow_k__BackingField = settingParameters->fields._snow_k__BackingField;
		      m_qualityParams = this->fields.m_qualityParams;
		      if ( snow_k__BackingField )
		      {
		        EnableSnowLighting_k__BackingField = snow_k__BackingField->fields._EnableSnowLighting_k__BackingField;
		        v10 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		        if ( EnableSnowLighting_k__BackingField )
		        {
		          klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		          if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		          {
		            v21 = sub_18011C4C0(v10->klass);
		            (**(void (***)(void))(*(_QWORD *)(v21 + 192) + 48LL))();
		          }
		          v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v10->klass;
		          if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		            sub_1800360B0(v5, wrapperArray);
		          if ( m_qualityParams )
		          {
		            m_qualityParams->fields.enableSnowLighting = EnableSnowLighting_k__BackingField->fields._paramValue_k__BackingField;
		            EnableSnowCollision_k__BackingField = snow_k__BackingField->fields._EnableSnowCollision_k__BackingField;
		            v13 = this->fields.m_qualityParams;
		            v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		            if ( EnableSnowCollision_k__BackingField )
		            {
		              v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		              if ( ((__int64)v15->vtable[0].methodPtr & 1) == 0 )
		                sub_1800360B0(
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass,
		                  wrapperArray);
		              if ( !*((_QWORD *)v15->rgctx_data[6].rgctxDataDummy + 4) )
		              {
		                v22 = sub_18011C4C0(v14->klass);
		                (**(void (***)(void))(*(_QWORD *)(v22 + 192) + 48LL))();
		              }
		              v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v14->klass;
		              if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                sub_1800360B0(v5, wrapperArray);
		              if ( v13 )
		              {
		                v13->fields.enableSnowCollision = EnableSnowCollision_k__BackingField->fields._paramValue_k__BackingField;
		                SnowLayerCount_k__BackingField = snow_k__BackingField->fields._SnowLayerCount_k__BackingField;
		                v17 = this->fields.m_qualityParams;
		                v18 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		                if ( SnowLayerCount_k__BackingField )
		                {
		                  v19 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		                  if ( ((__int64)v19->vtable[0].methodPtr & 1) == 0 )
		                    sub_1800360B0(
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass,
		                      wrapperArray);
		                  if ( !*((_QWORD *)v19->rgctx_data[6].rgctxDataDummy + 4) )
		                  {
		                    v23 = sub_18011C4C0(v18->klass);
		                    (**(void (***)(void))(*(_QWORD *)(v23 + 192) + 48LL))();
		                  }
		                  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v18->klass;
		                  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		                    sub_1800360B0(v5, wrapperArray);
		                  if ( v17 )
		                  {
		                    v17->fields.snowLayerCount = SnowLayerCount_k__BackingField->fields._paramValue_k__BackingField;
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_32:
		    sub_1800D8260(v5, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(663, 0LL);
		  if ( !Patch )
		    goto LABEL_32;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)settingParameters,
		    0LL);
		}
		
		internal void UpdateSnowData(HGCamera camera, ref ScriptableRenderContext renderContext) {} // 0x0000000182EE0010-0x0000000182EE0550
		// Void UpdateSnowData(HGCamera, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(
		        HGSnowRenderer *this,
		        HGCamera *camera,
		        ScriptableRenderContext *renderContext,
		        MethodInfo *method)
		{
		  void *items; // rcx
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *m_snowRenderSeqs; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **i; // r9
		  int32_t v11; // r9d
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v12; // rax
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v13; // rax
		  HGSnowRenderer_SnowRenderSeq__Array *v14; // rbx
		  Object *m_qualityParams; // rdi
		  HGSnowRenderer_SnowRenderSeq *v16; // rbx
		  float time; // xmm0_4
		  struct HGSnowRenderer__Class *v18; // rcx
		  float v19; // xmm6_4
		  float m_lastTime; // xmm7_4
		  HGSnowRenderer__StaticFields *static_fields; // rax
		  float UPDATE_DELTA_TIME_THRESHOLD; // xmm0_4
		  HGCamera *hgCamera; // rdi
		  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rdi
		  SnowCommonRenderingParam *snowCommonRenderingParam; // rax
		  bool enable; // al
		  __int64 v27; // rax
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  __int64 v30; // rsi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v31; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v32; // rbx
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  SnowCommonRenderingParam *v36; // rax
		  SnowCommonRenderingParam *v37; // rbx
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGRuntimeGrassQuery_Node *v41; // rdx
		  HGRuntimeGrassQuery_Node *v42; // r8
		  Int32__Array **v43; // r9
		  List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *v44; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v46; // rax
		  bool v47; // al
		  ILFixDynamicMethodWrapper_2 *v48; // rax
		  ILFixDynamicMethodWrapper_2 *v49; // rax
		  ILFixDynamicMethodWrapper_2 *v50; // rax
		  ILFixDynamicMethodWrapper_2 *v51; // rax
		  ILFixDynamicMethodWrapper_2 *v52; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-48h]
		  MethodInfo *methode; // [rsp+20h] [rbp-48h]
		  int32_t P3; // [rsp+30h] [rbp-38h] BYREF
		  _BYTE P2[48]; // [rsp+38h] [rbp-30h] BYREF
		
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)P2 = 0LL;
		  P3 = 0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size > 817 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		    if ( !m_snowRenderSeqs )
		      goto LABEL_69;
		    if ( m_snowRenderSeqs->fields._size <= 0x331u )
		      goto LABEL_76;
		    if ( m_snowRenderSeqs[164].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(817, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(Patch, (Object *)this, (Object *)camera, renderContext, 0LL);
		        return;
		      }
		      goto LABEL_69;
		    }
		  }
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 546 )
		    goto LABEL_9;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 0x222u )
		    goto LABEL_76;
		  if ( m_snowRenderSeqs[110].klass )
		  {
		    v46 = IFix::WrappersManagerImpl::GetPatch(546, 0LL);
		    if ( !v46 )
		      goto LABEL_69;
		    v47 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(
		            v46,
		            (Object *)this,
		            (Object *)camera,
		            (HGSnowRenderer_SnowRenderSeq **)P2,
		            &P3,
		            0LL);
		    v11 = P3;
		    if ( !v47 && P3 < 0 )
		      goto LABEL_70;
		  }
		  else
		  {
		LABEL_9:
		    *(_QWORD *)P2 = 0LL;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)P2,
		      (HGRuntimeGrassQuery_Node *)m_snowRenderSeqs,
		      (HGRuntimeGrassQuery_Node *)renderContext,
		      (Int32__Array **)method,
		      methoda);
		    if ( !camera || !this->fields.m_snowRenderSeqs || this->fields.m_snowRenderSeqs->fields._size <= 0 )
		      goto LABEL_70;
		    m_snowRenderSeqs = this->fields.m_snowRenderSeqs;
		    for ( i = 0LL; ; i = (Int32__Array **)(unsigned int)((_DWORD)i + 1) )
		    {
		      if ( (int)i >= m_snowRenderSeqs->fields._size )
		        goto LABEL_70;
		      if ( (unsigned int)i >= m_snowRenderSeqs->fields._size )
		        goto LABEL_130;
		      items = m_snowRenderSeqs->fields._items;
		      if ( !items )
		        goto LABEL_69;
		      if ( (unsigned int)i >= *((_DWORD *)items + 6) )
		        goto LABEL_76;
		      if ( *((_QWORD *)items + (int)i + 4) )
		      {
		        items = (void *)*((_QWORD *)items + (int)i + 4);
		        if ( *((HGCamera **)items + 2) == camera )
		          break;
		      }
		    }
		    if ( (int)i <= -1 )
		    {
		LABEL_70:
		      v27 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq);
		      v30 = v27;
		      if ( !v27 )
		        goto LABEL_69;
		      *(_DWORD *)(v27 + 24) = -1;
		      *(_QWORD *)(v27 + 16) = camera;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)(v27 + 16),
		        (HGRuntimeGrassQuery_Node *)m_snowRenderSeqs,
		        v28,
		        v29,
		        methodb);
		      v31 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>);
		      v32 = v31;
		      if ( !v31 )
		        goto LABEL_69;
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v31,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::List);
		      *(_QWORD *)(v30 + 32) = v32;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v30 + 32), v33, v34, v35, methodc);
		      v36 = (SnowCommonRenderingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonRenderingParam);
		      v37 = v36;
		      if ( !v36 )
		        goto LABEL_69;
		      HG::Rendering::Runtime::Snow::SnowCommonRenderingParam::SnowCommonRenderingParam(v36, 0LL);
		      v37->fields.snowCommonPreSettingParam = this->fields.m_snowCommonPreSettingParam;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v37->fields.snowCommonPreSettingParam, v38, v39, v40, methodd);
		      *(_QWORD *)(v30 + 40) = v37;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v30 + 40), v41, v42, v43, methode);
		      HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::CreateDefaultFeatures(
		        (HGSnowRenderer_SnowRenderSeq *)v30,
		        0LL);
		      HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::PrepareResources(
		        (HGSnowRenderer_SnowRenderSeq *)v30,
		        this->fields.m_snowCommonResources,
		        0LL);
		      items = this->fields.m_snowRenderSeqs;
		      if ( !items )
		        goto LABEL_69;
		      sub_182F01190((List_1_System_Object_ *)items, (Object *)v30);
		      v44 = this->fields.m_snowRenderSeqs;
		      if ( !v44 )
		        goto LABEL_69;
		      v11 = v44->fields._size - 1;
		      goto LABEL_22;
		    }
		    if ( !m_snowRenderSeqs )
		      goto LABEL_69;
		    *(_QWORD *)P2 = m_snowRenderSeqs->fields._items->vector[(int)i];
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)P2, (HGRuntimeGrassQuery_Node *)m_snowRenderSeqs, v9, i, methodb);
		  }
		LABEL_22:
		  if ( v11 <= -1 )
		    return;
		  v12 = this->fields.m_snowRenderSeqs;
		  if ( !v12 )
		    goto LABEL_69;
		  if ( (unsigned int)v11 >= v12->fields._size )
		    goto LABEL_130;
		  items = v12->fields._items;
		  if ( !items )
		    goto LABEL_69;
		  if ( (unsigned int)v11 >= *((_DWORD *)items + 6) )
		    goto LABEL_76;
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)*((_QWORD *)items + v11 + 4);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  m_snowRenderSeqs->fields._size = v11;
		  v13 = this->fields.m_snowRenderSeqs;
		  if ( !v13 )
		    goto LABEL_69;
		  if ( (unsigned int)v11 >= v13->fields._size )
		LABEL_130:
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  v14 = v13->fields._items;
		  if ( !v14 )
		    goto LABEL_69;
		  if ( (unsigned int)v11 >= v14->max_length.size )
		LABEL_76:
		    sub_1800D2AB0(items, m_snowRenderSeqs);
		  m_qualityParams = (Object *)this->fields.m_qualityParams;
		  v16 = v14->vector[v11];
		  if ( !v16 )
		    goto LABEL_69;
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size > 820 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		    if ( !m_snowRenderSeqs )
		      goto LABEL_69;
		    if ( m_snowRenderSeqs->fields._size <= 0x334u )
		      goto LABEL_76;
		    if ( m_snowRenderSeqs[164].fields._syncRoot )
		    {
		      v48 = IFix::WrappersManagerImpl::GetPatch(820, 0LL);
		      if ( v48 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(v48, (Object *)v16, m_qualityParams, renderContext, 0LL);
		        return;
		      }
		      goto LABEL_69;
		    }
		  }
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 821 )
		    goto LABEL_133;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 0x335u )
		    goto LABEL_76;
		  if ( m_snowRenderSeqs[165].klass )
		  {
		    v49 = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
		    if ( !v49 )
		      goto LABEL_69;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v49, (Object *)v16, 0LL);
		  }
		  else
		  {
		LABEL_133:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    time = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
		    v18 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
		    v19 = time;
		    m_lastTime = v16->fields.m_lastTime;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSnowRenderer->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
		      v18 = TypeInfo::HG::Rendering::Runtime::HGSnowRenderer;
		    }
		    static_fields = v18->static_fields;
		    UPDATE_DELTA_TIME_THRESHOLD = v19 - m_lastTime;
		    if ( (float)-static_fields->UPDATE_DELTA_TIME_THRESHOLD > (float)(v19 - m_lastTime) )
		    {
		      UPDATE_DELTA_TIME_THRESHOLD = -static_fields->UPDATE_DELTA_TIME_THRESHOLD;
		    }
		    else if ( UPDATE_DELTA_TIME_THRESHOLD > static_fields->UPDATE_DELTA_TIME_THRESHOLD )
		    {
		      UPDATE_DELTA_TIME_THRESHOLD = static_fields->UPDATE_DELTA_TIME_THRESHOLD;
		    }
		    v16->fields.m_lastTime = v19;
		    v16->fields.m_deltaTime = UPDATE_DELTA_TIME_THRESHOLD;
		  }
		  HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::_PrepareSnowRenderData(
		    v16,
		    v16->fields.m_deltaTime,
		    (HGSnowRenderer_SnowQualityParams *)m_qualityParams,
		    renderContext,
		    0LL);
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size > 827 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		    if ( !m_snowRenderSeqs )
		      goto LABEL_69;
		    if ( m_snowRenderSeqs->fields._size <= 0x33Bu )
		      goto LABEL_76;
		    if ( m_snowRenderSeqs[166].monitor )
		    {
		      v50 = IFix::WrappersManagerImpl::GetPatch(827, 0LL);
		      if ( v50 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v50, (Object *)v16, 0LL);
		        return;
		      }
		      goto LABEL_69;
		    }
		  }
		  hgCamera = v16->fields.hgCamera;
		  if ( !hgCamera )
		    goto LABEL_69;
		  verticalOcclusionMapManager = hgCamera->fields.verticalOcclusionMapManager;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 828 )
		    goto LABEL_58;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size <= 0x33Cu )
		    goto LABEL_76;
		  if ( m_snowRenderSeqs[166].fields._items )
		  {
		    v51 = IFix::WrappersManagerImpl::GetPatch(828, 0LL);
		    if ( !v51 )
		      goto LABEL_69;
		    enable = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v51, (Object *)v16, 0LL);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_58:
		    snowCommonRenderingParam = v16->fields.snowCommonRenderingParam;
		    if ( !snowCommonRenderingParam )
		      goto LABEL_69;
		    enable = snowCommonRenderingParam->fields.enable;
		  }
		  if ( !verticalOcclusionMapManager )
		    goto LABEL_69;
		  if ( enable )
		  {
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
		      verticalOcclusionMapManager,
		      HGVerticalOcclusionMapManager_RequestUsageType__Enum_SnowOcclusion,
		      0LL);
		    return;
		  }
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		  if ( !m_snowRenderSeqs )
		    goto LABEL_69;
		  if ( m_snowRenderSeqs->fields._size > 816 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_snowRenderSeqs = (List_1_HG_Rendering_Runtime_HGSnowRenderer_SnowRenderSeq_ *)**((_QWORD **)items + 23);
		    if ( !m_snowRenderSeqs )
		      goto LABEL_69;
		    if ( m_snowRenderSeqs->fields._size > 0x330u )
		    {
		      if ( !m_snowRenderSeqs[164].klass )
		        goto LABEL_66;
		      v52 = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
		      if ( v52 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		          (ILFixDynamicMethodWrapper_30 *)v52,
		          (Object *)verticalOcclusionMapManager,
		          4,
		          0LL);
		        return;
		      }
		LABEL_69:
		      sub_1800D8260(items, m_snowRenderSeqs);
		    }
		    goto LABEL_76;
		  }
		LABEL_66:
		  verticalOcclusionMapManager->fields.m_requestType &= ~4u;
		}
		
		internal void RenderSnow(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189CF6D84-0x0000000189CF6F3C
		// Void RenderSnow(HGRenderGraphContext, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGSnowRenderer::RenderSnow(
		        HGSnowRenderer *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  SnowCommonRenderingParam *snowCommonRenderingParam; // rsi
		  List_1_HG_Rendering_Runtime_Snow_HGBaseSubSnowRenderer_ *subSnowRenderers; // rdi
		  __int64 v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int32_t index; // [rsp+30h] [rbp-58h] BYREF
		  HGSnowRenderer_SnowRenderSeq *seq; // [rsp+38h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+40h] [rbp-48h] BYREF
		  _QWORD v18[3]; // [rsp+48h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v19; // [rsp+60h] [rbp-28h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  memset(&v19, 0, sizeof(v19));
		  if ( IFix::WrappersManagerImpl::IsPatched(1670, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1670, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)ctx,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    if ( !seq )
		      sub_1800D8260(v8, v7);
		    snowCommonRenderingParam = seq->fields.snowCommonRenderingParam;
		    if ( !snowCommonRenderingParam )
		      sub_1800D8260(v8, v7);
		    if ( snowCommonRenderingParam->fields.enable )
		    {
		      subSnowRenderers = seq->fields.subSnowRenderers;
		      if ( !subSnowRenderers )
		        sub_1800D8260(v8, v7);
		      v19 = *(List_1_T_Enumerator_System_Object_ *)sub_180364948(v18, subSnowRenderers);
		      v18[0] = 0LL;
		      v18[1] = &v19;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v19,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer>::MoveNext) )
		        {
		          if ( !v19._current )
		            sub_1800D8250(v11, 0LL);
		          sub_1808B4B14(v11, v19._current, ctx, hgCamera);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v17 )
		      {
		        v18[0] = v17->ex;
		        if ( v18[0] )
		          sub_18007E1E0(v18[0]);
		      }
		    }
		  }
		}
		
		internal bool IsSnowRenderingEnabled(HGCamera hgCamera) => default; // 0x0000000189CF6CE4-0x0000000189CF6D84
		// Boolean IsSnowRenderingEnabled(HGCamera)
		bool HG::Rendering::Runtime::HGSnowRenderer::IsSnowRenderingEnabled(
		        HGSnowRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  bool v5; // bl
		  __int64 v6; // rdx
		  SnowCommonRenderingParam *snowCommonRenderingParam; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGSnowRenderer_SnowRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
		  int32_t index; // [rsp+68h] [rbp+20h] BYREF
		
		  v5 = 0;
		  seq = 0LL;
		  index = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1672, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		      return v5;
		    if ( seq )
		    {
		      snowCommonRenderingParam = seq->fields.snowCommonRenderingParam;
		      if ( snowCommonRenderingParam )
		        return snowCommonRenderingParam->fields.enable;
		    }
		LABEL_8:
		    sub_1800D8260(snowCommonRenderingParam, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1672, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)hgCamera,
		           0LL);
		}
		
		internal unsafe HGSnowRendererInputCPP* PrepareCppInput(HGCamera hgCamera) => default; // 0x0000000183A6F150-0x0000000183A6F330
		// HGSnowRendererInputCPP* PrepareCppInput(HGCamera)
		HGSnowRendererInputCPP *HG::Rendering::Runtime::HGSnowRenderer::PrepareCppInput(
		        HGSnowRenderer *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGSnowRendererInputCPP *v5; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // xmm0_8
		  __m128 v10; // xmm3
		  MethodInfo *m_snowCommonPreSettingParam; // r8
		  Vector4 color; // xmm7
		  __m128 v13; // xmm6
		  int v14; // eax
		  BOOL v15; // eax
		  __m128 v16; // xmm5
		  TileBase *v17; // rdx
		  __int64 v18; // r8
		  ITilemap *v19; // r9
		  Color v20; // xmm1
		  float v21; // eax
		  __m128 v22; // xmm4
		  TileAnimationData v23; // xmm0
		  HGSnowRendererInputCPP *result; // rax
		  Vector4 v25; // [rsp+20h] [rbp-108h] BYREF
		  Color v26[12]; // [rsp+30h] [rbp-F8h] BYREF
		  float v27[4]; // [rsp+F0h] [rbp-38h]
		
		  v5 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGSnowRendererInputCPP>(MethodInfo::UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGSnowRendererInputCPP>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_8;
		  v9 = *(_QWORD *)&InterpolatedPhase->fields.snowConfig.snowDirection.z;
		  v10 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.enable;
		  m_snowCommonPreSettingParam = (MethodInfo *)this->fields.m_snowCommonPreSettingParam;
		  color = (Vector4)InterpolatedPhase->fields.snowConfig.color;
		  v13 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.snowSizeRange.x;
		  v14 = *(_DWORD *)&InterpolatedPhase->fields.snowConfig.enable;
		  *(_QWORD *)v27 = v9;
		  v15 = (_BYTE)v14 != 0;
		  if ( !v5 )
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  v5->enable = v15;
		  v25 = color;
		  LODWORD(v5->intensity) = _mm_shuffle_ps(v10, v10, 85).m128_u32[0];
		  LODWORD(v5->speed.y) = _mm_shuffle_ps(v10, v10, 255).m128_u32[0];
		  LODWORD(v5->speed.x) = _mm_shuffle_ps(v10, v10, 170).m128_u32[0];
		  v20 = *UnityEngine::Color::op_Implicit(v26, &v25, m_snowCommonPreSettingParam);
		  v21 = v27[0];
		  *(_QWORD *)&v5->snowDirection.x = *(_OWORD *)&_mm_unpackhi_pd((__m128d)v16, (__m128d)v16);
		  LODWORD(v5->snowJitterLevel) = _mm_shuffle_ps(v22, v22, 85).m128_u32[0];
		  LODWORD(v5->snowSizeRange.x) = v13.m128_i32[0];
		  LODWORD(v5->snowLightingPercent) = v16.m128_i32[0];
		  LODWORD(v5->snowSpeedNoiseFreq) = _mm_shuffle_ps(v22, v22, 255).m128_u32[0];
		  LODWORD(v5->snowTrailLength) = v22.m128_i32[0];
		  LODWORD(v5->snowSizeRange.y) = _mm_shuffle_ps(v13, v13, 85).m128_u32[0];
		  LODWORD(v5->snowCollisionFadeTimeScale) = _mm_shuffle_ps(v16, v16, 85).m128_u32[0];
		  v5->snowDirection.z = v21;
		  v5->color = (Vector4)v20;
		  LODWORD(v5->snowSpeedNoiseLevel) = _mm_shuffle_ps(v22, v22, 170).m128_u32[0];
		  if ( v18 )
		  {
		    v5->maxSnowHeight = *(float *)(v18 + 40);
		    v5->snowMaxUVFlowSpeed = *(float *)(v18 + 44);
		    v5->snowRange = *(float *)(v18 + 48);
		    v5->maxMoveDirectionLength = *(float *)(v18 + 52);
		    v5->snowTemporalTimeThreshold = *(float *)(v18 + 56);
		    v23 = *(TileAnimationData *)(v18 + 24);
		  }
		  else
		  {
		    v5->maxSnowHeight = 100.0;
		    v5->snowMaxUVFlowSpeed = 100.0;
		    v5->snowRange = 50.0;
		    v5->maxMoveDirectionLength = 0.5;
		    v5->snowTemporalTimeThreshold = 1.0;
		    v23 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		             (TileAnimationData *)v26,
		             v17,
		             0LL,
		             v19,
		             *(MethodInfo **)&v25.x);
		  }
		  result = v5;
		  v5->snowflakeTex_ST = (Vector4)v23;
		  return result;
		}
		
		internal void Dispose() {} // 0x0000000184D39C90-0x0000000184D39D80
		// Void Dispose()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGSnowRenderer::Dispose(HGSnowRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Il2CppExceptionWrapper *v6; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v7; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v8; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(522, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(522, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_snowRenderSeqs && this->fields.m_snowRenderSeqs->fields._size > 0 )
		  {
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v7,
		      (List_1_System_UInt64_ *)this->fields.m_snowRenderSeqs,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::GetEnumerator);
		    v8 = v7;
		    v7._list = 0LL;
		    *(_QWORD *)&v7._index = &v8;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v8,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::MoveNext) )
		      {
		        if ( v8._current )
		          HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(
		            (HGSnowRenderer_SnowRenderSeq *)v8._current,
		            0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v6 )
		    {
		      v7._list = (List_1_System_Object_ *)v6->ex;
		      if ( v7._list )
		        sub_18007E1E0(v7._list);
		    }
		  }
		}
		
		internal void DisposeSeq(HGCamera hgCamera) {} // 0x0000000182EDF000-0x0000000182EDF0B0
		// Void DisposeSeq(HGCamera)
		void HG::Rendering::Runtime::HGSnowRenderer::DisposeSeq(HGSnowRenderer *this, HGCamera *hgCamera, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_snowRenderSeqs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGSnowRenderer_SnowRenderSeq *seq; // [rsp+30h] [rbp-18h] BYREF
		  int32_t index; // [rsp+68h] [rbp+20h] BYREF
		
		  seq = 0LL;
		  index = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(545, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(545, 0LL);
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
		    sub_1800D8260(m_snowRenderSeqs, v5);
		  }
		  if ( hgCamera && HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(this, hgCamera, &seq, &index, 0LL) )
		  {
		    m_snowRenderSeqs = (List_1_System_Object_ *)seq;
		    if ( seq )
		    {
		      HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq::Dispose(seq, 0LL);
		      m_snowRenderSeqs = (List_1_System_Object_ *)this->fields.m_snowRenderSeqs;
		      if ( m_snowRenderSeqs )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          m_snowRenderSeqs,
		          (Object *)seq,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGSnowRenderer::SnowRenderSeq>::Remove);
		        return;
		      }
		    }
		    goto LABEL_7;
		  }
		}
		
		private bool _TryGetSeqByCamera(HGCamera hgCamera, out SnowRenderSeq seq, out int index) {
			seq = default;
			index = default;
			return default;
		} // 0x0000000182EE0550-0x0000000182EE0670
		// Boolean _TryGetSeqByCamera(HGCamera, HGSnowRenderer+SnowRenderSeq ByRef, Int32 ByRef)
		bool HG::Rendering::Runtime::HGSnowRenderer::_TryGetSeqByCamera(
		        HGSnowRenderer *this,
		        HGCamera *hgCamera,
		        HGSnowRenderer_SnowRenderSeq **seq,
		        int32_t *index,
		        MethodInfo *method)
		{
		  void *name_k__BackingField; // rcx
		  Object *v9; // rbp
		  __int64 v10; // r8
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  bool result; // al
		  int32_t v14; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t *P3; // [rsp+20h] [rbp-18h]
		  int32_t *P3a; // [rsp+20h] [rbp-18h]
		
		  name_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = (Object *)hgCamera;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    name_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v10 = **((_QWORD **)name_k__BackingField + 23);
		  if ( !v10 )
		    goto LABEL_19;
		  if ( *(int *)(v10 + 24) <= 546 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)name_k__BackingField + 56) )
		  {
		    il2cpp_runtime_class_init_1(name_k__BackingField);
		    name_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  hgCamera = (HGCamera *)**((_QWORD **)name_k__BackingField + 23);
		  if ( !hgCamera )
		    goto LABEL_19;
		  if ( hgCamera->fields._taauRTSize_k__BackingField.m_X <= 0x222u )
		LABEL_21:
		    sub_1800D2AB0(name_k__BackingField, hgCamera);
		  if ( !*(_QWORD *)&hgCamera[1].fields.mainViewConstants.worldSpaceCameraPos.z )
		  {
		LABEL_5:
		    *seq = 0LL;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)seq,
		      (HGRuntimeGrassQuery_Node *)hgCamera,
		      (HGRuntimeGrassQuery_Node *)v10,
		      0LL,
		      (MethodInfo *)P3);
		    *index = -1;
		    if ( !v9
		      || (Int32__Array **)this->fields.m_snowRenderSeqs == v12
		      || this->fields.m_snowRenderSeqs->fields._size <= (int)v12 )
		    {
		      return 0;
		    }
		    hgCamera = (HGCamera *)this->fields.m_snowRenderSeqs;
		    while ( 1 )
		    {
		      if ( (int)v12 >= hgCamera->fields._taauRTSize_k__BackingField.m_X )
		        return 0;
		      if ( (unsigned int)v12 >= hgCamera->fields._taauRTSize_k__BackingField.m_X )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      name_k__BackingField = hgCamera->fields._name_k__BackingField;
		      if ( !name_k__BackingField )
		        goto LABEL_19;
		      if ( (unsigned int)v12 >= *((_DWORD *)name_k__BackingField + 6) )
		        goto LABEL_21;
		      if ( *((_QWORD *)name_k__BackingField + (int)v12 + 4) )
		      {
		        name_k__BackingField = (void *)*((_QWORD *)name_k__BackingField + (int)v12 + 4);
		        if ( *((Object **)name_k__BackingField + 2) == v9 )
		          break;
		      }
		      v12 = (Int32__Array **)(unsigned int)((_DWORD)v12 + 1);
		    }
		    if ( (int)v12 <= -1 )
		      return 0;
		    if ( hgCamera )
		    {
		      *seq = (HGSnowRenderer_SnowRenderSeq *)*((_QWORD *)&hgCamera->fields._name_k__BackingField[1].monitor + (int)v12);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)seq, (HGRuntimeGrassQuery_Node *)hgCamera, v11, v12, (MethodInfo *)P3a);
		      result = 1;
		      *index = v14;
		      return result;
		    }
		LABEL_19:
		    sub_1800D8260(name_k__BackingField, hgCamera);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(546, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(Patch, (Object *)this, v9, seq, index, 0LL);
		}
		
		public float GetCurrentSnowIntensity(Camera inMainCamera) => default; // 0x0000000189CF6C14-0x0000000189CF6CE4
		// Single GetCurrentSnowIntensity(Camera)
		float HG::Rendering::Runtime::HGSnowRenderer::GetCurrentSnowIntensity(
		        HGSnowRenderer *this,
		        Camera *inMainCamera,
		        MethodInfo *method)
		{
		  HGCamera *v5; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __m128 v9; // xmm2
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1673, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality((Object_1 *)inMainCamera, 0LL, 0LL) )
		      return 0.0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v5 = HG::Rendering::Runtime::HGCamera::GetOrCreate(inMainCamera, 0, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v5, 0LL);
		    if ( InterpolatedPhase )
		    {
		      v9 = *(__m128 *)&InterpolatedPhase->fields.snowConfig.enable;
		      if ( (unsigned __int8)_mm_cvtsi128_si32((__m128i)v9) )
		      {
		        LODWORD(result) = _mm_shuffle_ps(v9, v9, 85).m128_u32[0];
		        return result;
		      }
		      return 0.0;
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1673, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_297(Patch, (Object *)this, (Object *)inMainCamera, 0LL);
		}
		
	}
}
