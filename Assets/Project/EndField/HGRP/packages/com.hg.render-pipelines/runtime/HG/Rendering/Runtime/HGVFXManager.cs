using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVFXManager // TypeDefIndex: 37934
	{
		// Fields
		private List<VFXSceneDark> m_sceneDarks; // 0x10
		private float m_lastUpdateTime; // 0x18
		private const float SCENE_DARK_VALUE_CHANGE_THRESHOLD = 0.01f; // Metadata: 0x02303740
		private Vector3 m_currentSceneDarkValue; // 0x1C
		private float m_currentSceneSaturation; // 0x28
		private bool m_currentNeedStopAutoExposure; // 0x2C
		private Vector3 m_lastSceneDarkValue; // 0x30
		private float m_lastSceneSaturation; // 0x3C
		private bool m_lastNeedStopAutoExposure; // 0x40
		private Dictionary<int, float> m_savedCameraAutoExposure; // 0x48
		private Vector3 m_playerPosition; // 0x50
		private Vector4 m_playerHeights; // 0x5C
		private bool m_enabled; // 0x6C
		private Vector2 m_anchorPosition; // 0x70
		private float m_anchorRadius; // 0x78
		private float m_anchorBrightIntensity; // 0x7C
		private float m_brightInnerRadius; // 0x80
		private float m_brightOuterRadius; // 0x84
		private bool m_anchorBrightFlag; // 0x88
		private Material m_vfxSceneColorAdjustmentMaterial; // 0x90
		public const int MAX_RECTS = 4; // Metadata: 0x02303744
		private HashSet<EffectOcclusionRect> m_allRects; // 0x98
		private HashSet<EffectOcclusionCircle> m_allCircles; // 0xA0
		private List<EffectOcclusionRect> m_tempList; // 0xA8
		[TupleElementNames(new string[3] {"rectData", "dataVec", "rotVec" })]
		private readonly ValueTuple<Vector4, Vector4, Vector4>[] m_tempShaderData; // 0xB0
		private static readonly int[] _RectIds; // 0x00
		private static readonly int[] _DataIds; // 0x08
		private static readonly int[] _RotIds; // 0x10
		private static readonly int COUNT_ID; // 0x18
	
		// Properties
		public static HGVFXManager instance { get => default; } // 0x00000001831061D0-0x00000001831062E0 
		// HGVFXManager get_instance()
		HGVFXManager *HG::Rendering::Runtime::HGVFXManager::get_instance(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct HGGlobalGameManager__Class *v3; // rax
		  HGManagerContextBase__Array *currentManagerContexts; // rbx
		  HGManagerContext *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size > 894 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v1->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_18;
		    if ( wrapperArray->max_length.size <= 0x37Eu )
		      goto LABEL_19;
		    if ( wrapperArray[24].vector[30] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(894, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_353(Patch, 0LL);
		      goto LABEL_18;
		    }
		  }
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size <= 426 )
		    goto LABEL_9;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size <= 0x1AAu )
		    goto LABEL_19;
		  if ( !wrapperArray[11].vector[30] )
		  {
		LABEL_9:
		    v3 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
		    if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
		      v3 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
		    }
		    currentManagerContexts = v3->static_fields->currentManagerContexts;
		    if ( currentManagerContexts )
		    {
		      if ( currentManagerContexts->max_length.size )
		      {
		        v5 = (HGManagerContext *)currentManagerContexts->vector[0];
		        if ( !v5 || !(unsigned __int8)sub_180005080(v5->klass, TypeInfo::HG::Rendering::Runtime::HGManagerContext) )
		          v5 = 0LL;
		        goto LABEL_15;
		      }
		LABEL_19:
		      sub_1800D2AB0(v1, wrapperArray);
		    }
		LABEL_18:
		    sub_1800D8260(v1, wrapperArray);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(426, 0LL);
		  if ( !v8 )
		    goto LABEL_18;
		  v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_205(v8, 0LL);
		LABEL_15:
		  if ( v5 )
		    return v5->fields._vfxManager_k__BackingField;
		  else
		    return 0LL;
		}
		
	
		// Constructors
		public HGVFXManager() {} // 0x0000000182ED6C80-0x0000000182ED70E0
		// HGVFXManager()
		void HG::Rendering::Runtime::HGVFXManager::HGVFXManager(HGVFXManager *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_VFXSceneDark_ *v6; // rdi
		  bool v7; // zf
		  unsigned __int64 v8; // rdx
		  signed __int64 v9; // rtt
		  Dictionary_2_System_Int32_System_Single_ *v10; // rsi
		  struct MethodInfo *v11; // rdi
		  unsigned __int64 v12; // rdx
		  signed __int64 v13; // rtt
		  unsigned __int64 v14; // rdx
		  signed __int64 v15; // rtt
		  HashSet_1_System_Object_ *v16; // rax
		  HashSet_1_EffectOcclusionRect_ *v17; // rdi
		  unsigned __int64 v18; // rdx
		  signed __int64 v19; // rtt
		  HashSet_1_System_Object_ *v20; // rax
		  HashSet_1_EffectOcclusionCircle_ *v21; // rdi
		  unsigned __int64 v22; // rdx
		  signed __int64 v23; // rtt
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v24; // rax
		  List_1_EffectOcclusionRect_ *v25; // rdi
		  unsigned __int64 v26; // r8
		  signed __int64 v27; // rtt
		  ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4___Array *v28; // rax
		  unsigned __int64 v29; // rdx
		  signed __int64 v30; // rtt
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v31; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v32; // rdi
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v33; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v34; // rdi
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>);
		  v6 = (List_1_HG_Rendering_Runtime_VFXSceneDark_ *)v3;
		  if ( !v3 )
		    goto LABEL_35;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::List);
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_sceneDarks = v6;
		  if ( !v7 )
		  {
		    v8 = (((unsigned __int64)&this->fields >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v8 + 36190]);
		    do
		      v9 = qword_18F0BCBA0[v8 + 36190];
		    while ( v9 != _InterlockedCompareExchange64(
		                    &qword_18F0BCBA0[v8 + 36190],
		                    v9 | (1LL << (((unsigned __int64)&this->fields >> 12) & 0x3F)),
		                    v9) );
		  }
		  this->fields.m_currentSceneSaturation = 1.0;
		  *(_QWORD *)&this->fields.m_currentSceneDarkValue.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  this->fields.m_currentSceneDarkValue.z = 1.0;
		  this->fields.m_lastSceneSaturation = 1.0;
		  *(_QWORD *)&this->fields.m_lastSceneDarkValue.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  this->fields.m_lastSceneDarkValue.z = 1.0;
		  v10 = (Dictionary_2_System_Int32_System_Single_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<int,float>);
		  if ( !v10 )
		    goto LABEL_35;
		  v11 = MethodInfo::System::Collections::Generic::Dictionary<int,float>::Dictionary;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,float>::Dictionary->klass->rgctx_data->rgctxDataDummy
		        + 4) )
		    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,float>::Dictionary->klass->rgctx_data->rgctxDataDummy)();
		  if ( sub_182EEDA30(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)v11->klass->rgctx_data->rgctxDataDummy + 4) + 192LL) + 16LL)) )
		  {
		    v7 = dword_18F35FD08 == 0;
		    v10->fields._comparer = 0LL;
		    if ( !v7 )
		    {
		      v12 = (((unsigned __int64)&v10->fields._comparer >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v12 + 36190]);
		      do
		        v13 = qword_18F0BCBA0[v12 + 36190];
		      while ( v13 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v12 + 36190],
		                       v13 | (1LL << (((unsigned __int64)&v10->fields._comparer >> 12) & 0x3F)),
		                       v13) );
		    }
		  }
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_savedCameraAutoExposure = v10;
		  if ( !v7 )
		  {
		    v14 = (((unsigned __int64)&this->fields.m_savedCameraAutoExposure >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v14 + 36190]);
		    do
		      v15 = qword_18F0BCBA0[v14 + 36190];
		    while ( v15 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v14 + 36190],
		                     v15 | (1LL << (((unsigned __int64)&this->fields.m_savedCameraAutoExposure >> 12) & 0x3F)),
		                     v15) );
		  }
		  this->fields.m_anchorPosition = 0LL;
		  v16 = (HashSet_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<EffectOcclusionRect>);
		  v17 = (HashSet_1_EffectOcclusionRect_ *)v16;
		  if ( !v16 )
		    goto LABEL_35;
		  System::Collections::Generic::HashSet<System::Object>::HashSet(
		    v16,
		    MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionRect>::HashSet);
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_allRects = v17;
		  if ( !v7 )
		  {
		    v18 = (((unsigned __int64)&this->fields.m_allRects >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v18 + 36190]);
		    do
		      v19 = qword_18F0BCBA0[v18 + 36190];
		    while ( v19 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v18 + 36190],
		                     v19 | (1LL << (((unsigned __int64)&this->fields.m_allRects >> 12) & 0x3F)),
		                     v19) );
		  }
		  v20 = (HashSet_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<EffectOcclusionCircle>);
		  v21 = (HashSet_1_EffectOcclusionCircle_ *)v20;
		  if ( !v20 )
		    goto LABEL_35;
		  System::Collections::Generic::HashSet<System::Object>::HashSet(
		    v20,
		    MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionCircle>::HashSet);
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_allCircles = v21;
		  if ( !v7 )
		  {
		    v22 = (((unsigned __int64)&this->fields.m_allCircles >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v22 + 36190]);
		    do
		      v23 = qword_18F0BCBA0[v22 + 36190];
		    while ( v23 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v22 + 36190],
		                     v23 | (1LL << (((unsigned __int64)&this->fields.m_allCircles >> 12) & 0x3F)),
		                     v23) );
		  }
		  v24 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<EffectOcclusionRect>);
		  v25 = (List_1_EffectOcclusionRect_ *)v24;
		  if ( !v24 )
		    goto LABEL_35;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v24,
		    4,
		    MethodInfo::System::Collections::Generic::List<EffectOcclusionRect>::List);
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_tempList = v25;
		  if ( !v7 )
		  {
		    v26 = (((unsigned __int64)&this->fields.m_tempList >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		    do
		      v27 = qword_18F0BCBA0[v26 + 36190];
		    while ( v27 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v26 + 36190],
		                     v27 | (1LL << (((unsigned __int64)&this->fields.m_tempList >> 12) & 0x3F)),
		                     v27) );
		  }
		  v28 = (ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4___Array *)il2cpp_array_new_specific_1(
		                                                                                              TypeInfo::System::ValueTuple<UnityEngine::Vector4,UnityEngine::Vector4,UnityEngine::Vector4>,
		                                                                                              4LL);
		  v7 = dword_18F35FD08 == 0;
		  this->fields.m_tempShaderData = v28;
		  if ( !v7 )
		  {
		    v29 = (((unsigned __int64)&this->fields.m_tempShaderData >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v29 + 36190]);
		    do
		      v30 = qword_18F0BCBA0[v29 + 36190];
		    while ( v30 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v29 + 36190],
		                     v30 | (1LL << (((unsigned __int64)&this->fields.m_tempShaderData >> 12) & 0x3F)),
		                     v30) );
		  }
		  v31 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v32 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v31;
		  if ( !v31 )
		    goto LABEL_35;
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v31,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v32, 0LL);
		  v33 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v34 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v33;
		  if ( !v33 )
		LABEL_35:
		    sub_1800D8250(v5, v4);
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v33,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering,
		    0LL);
		  UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v34, 0LL);
		  this->fields.m_enabled = 1;
		}
		
		static HGVFXManager() {} // 0x00000001848AD500-0x00000001848AD740
		// HGVFXManager()
		void HG::Rendering::Runtime::HGVFXManager::cctor(MethodInfo *method)
		{
		  Int32__Array *v1; // rbx
		  int32_t v2; // eax
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // eax
		  int32_t v6; // eax
		  int32_t v7; // eax
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Int32__Array *v10; // rbx
		  int32_t v11; // eax
		  int32_t v12; // eax
		  int32_t v13; // eax
		  int32_t v14; // eax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Int32__Array *v17; // rbx
		  int32_t v18; // eax
		  int32_t v19; // eax
		  int32_t v20; // eax
		  int32_t v21; // eax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		
		  v1 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 4LL);
		  v2 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRect0", 0LL);
		  if ( !v1 )
		LABEL_2:
		    sub_1800D8260(v4, v3);
		  if ( !v1->max_length.size )
		    goto LABEL_18;
		  v1->vector[0] = v2;
		  v5 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRect1", 0LL);
		  if ( v1->max_length.size <= 1u )
		    goto LABEL_18;
		  v1->vector[1] = v5;
		  v6 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRect2", 0LL);
		  if ( v1->max_length.size <= 2u )
		    goto LABEL_18;
		  v1->vector[2] = v6;
		  v7 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRect3", 0LL);
		  if ( v1->max_length.size <= 3u )
		    goto LABEL_18;
		  v1->vector[3] = v7;
		  TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->_RectIds = v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields,
		    v3,
		    v8,
		    v9,
		    v24);
		  v10 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 4LL);
		  v11 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionData0", 0LL);
		  if ( !v10 )
		    goto LABEL_2;
		  if ( !v10->max_length.size )
		    goto LABEL_18;
		  v10->vector[0] = v11;
		  v12 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionData1", 0LL);
		  if ( v10->max_length.size <= 1u )
		    goto LABEL_18;
		  v10->vector[1] = v12;
		  v13 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionData2", 0LL);
		  if ( v10->max_length.size <= 2u )
		    goto LABEL_18;
		  v10->vector[2] = v13;
		  v14 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionData3", 0LL);
		  if ( v10->max_length.size <= 3u )
		    goto LABEL_18;
		  v10->vector[3] = v14;
		  TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->_DataIds = v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->_DataIds,
		    v3,
		    v15,
		    v16,
		    v25);
		  v17 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 4LL);
		  v18 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRot0", 0LL);
		  if ( !v17 )
		    goto LABEL_2;
		  if ( !v17->max_length.size
		    || (v17->vector[0] = v18,
		        v19 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRot1", 0LL),
		        v17->max_length.size <= 1u)
		    || (v17->vector[1] = v19,
		        v20 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRot2", 0LL),
		        v17->max_length.size <= 2u)
		    || (v17->vector[2] = v20,
		        v21 = UnityEngine::Shader::PropertyToID((String *)"_OcclusionRot3", 0LL),
		        v17->max_length.size <= 3u) )
		  {
		LABEL_18:
		    sub_1800D2AB0(v4, v3);
		  }
		  v17->vector[3] = v21;
		  TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->_RotIds = v17;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->_RotIds,
		    v3,
		    v22,
		    v23,
		    v26);
		  TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields->COUNT_ID = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_OcclusionRectCount",
		                                                                              0LL);
		}
		
	
		// Methods
		public void Dispose() {} // 0x0000000189B597D8-0x0000000189B59868
		// Void Dispose()
		void HG::Rendering::Runtime::HGVFXManager::Dispose(HGVFXManager *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2273, 0LL) )
		  {
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2273, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void AddSceneDarkToManager(VFXSceneDark sceneDark) {} // 0x0000000184695A80-0x0000000184695AD0
		// Void AddSceneDarkToManager(VFXSceneDark)
		void HG::Rendering::Runtime::HGVFXManager::AddSceneDarkToManager(
		        HGVFXManager *this,
		        VFXSceneDark *sceneDark,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_sceneDarks; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2401, 0LL) )
		  {
		    m_sceneDarks = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		    if ( m_sceneDarks )
		    {
		      sub_182F01190(m_sceneDarks, (Object *)sceneDark);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_sceneDarks, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2401, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)sceneDark,
		    0LL);
		}
		
		public void RemoveSceneDarkToManager(VFXSceneDark sceneDark) {} // 0x00000001847038F0-0x0000000184703940
		// Void RemoveSceneDarkToManager(VFXSceneDark)
		void HG::Rendering::Runtime::HGVFXManager::RemoveSceneDarkToManager(
		        HGVFXManager *this,
		        VFXSceneDark *sceneDark,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_sceneDarks; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2402, 0LL) )
		  {
		    m_sceneDarks = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		    if ( m_sceneDarks )
		    {
		      System::Collections::Generic::List<System::Object>::Remove(
		        m_sceneDarks,
		        (Object *)sceneDark,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::Remove);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_sceneDarks, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2402, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)sceneDark,
		    0LL);
		}
		
		public void SetSceneDarkEnabled(bool enable) {} // 0x000000018494F900-0x000000018494F940
		// Void SetSceneDarkEnabled(Boolean)
		void HG::Rendering::Runtime::HGVFXManager::SetSceneDarkEnabled(HGVFXManager *this, bool enable, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2403, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2403, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, enable, 0LL);
		  }
		  else
		  {
		    this->fields.m_enabled = enable;
		  }
		}
		
		private void _UpdateSceneDarkValue() {} // 0x00000001831C90E0-0x00000001831C9540
		// Void _UpdateSceneDarkValue()
		void HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue(HGVFXManager *this, MethodInfo *method)
		{
		  List_1_System_Object_ *v3; // rcx
		  __int64 v4; // rdx
		  __m128 v5; // xmm7
		  bool v6; // si
		  int v7; // r14d
		  int32_t v8; // edi
		  unsigned __int64 v9; // xmm8_8
		  List_1_HG_Rendering_Runtime_VFXSceneDark_ *m_sceneDarks; // rax
		  float unscaledTime; // xmm0_4
		  float z; // eax
		  float m_currentSceneSaturation; // xmm6_4
		  float x; // xmm3_4
		  float y; // xmm1_4
		  float v16; // xmm2_4
		  float v17; // xmm4_4
		  float v18; // xmm5_4
		  MethodInfo *v19; // r9
		  MethodInfo *v20; // r8
		  HGRenderPipeline *v21; // rax
		  Object *Item; // rax
		  struct Object_1__Class *v23; // rcx
		  Object *v24; // r15
		  Object *v25; // rax
		  Vector3 *sceneDark; // rax
		  __int64 v27; // xmm0_8
		  MethodInfo *v28; // r8
		  Vector4 v29; // xmm0
		  __m128 v30; // xmm4
		  __m128 v31; // xmm3
		  __m128 v32; // xmm1
		  __m128 v33; // xmm0
		  __m128i v34; // xmm2
		  Object *v35; // rax
		  Object *v36; // rax
		  float sceneSaturation; // xmm0_4
		  HGRenderPipeline *currentPipeline; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v40; // [rsp+20h] [rbp-29h]
		  Vector4 v41; // [rsp+30h] [rbp-19h] BYREF
		  Vector4 v42; // [rsp+40h] [rbp-9h] BYREF
		  Vector4 v43; // [rsp+50h] [rbp+7h] BYREF
		
		  v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&v3[4].fields._size;
		  if ( !v4 )
		    goto LABEL_42;
		  if ( *(int *)(v4 + 24) > 2329 )
		  {
		    if ( !v3[5].fields._size )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = **(List_1_System_Object_ ***)&v3[4].fields._size;
		    if ( !v3 )
		      goto LABEL_42;
		    if ( v3->fields._size <= 0x919u )
		      sub_1800D2AB0(v3, v4);
		    if ( *(_QWORD *)&v3[466].fields._size )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2329, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_42;
		    }
		  }
		  if ( UnityEngine::Time::get_unscaledTime(0LL) == this->fields.m_lastUpdateTime )
		    return;
		  if ( !this->fields.m_enabled )
		  {
		    this->fields.m_lastUpdateTime = UnityEngine::Time::get_unscaledTime(0LL);
		    this->fields.m_currentNeedStopAutoExposure = 0;
		    *(_QWORD *)&this->fields.m_currentSceneDarkValue.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    this->fields.m_currentSceneDarkValue.z = 1.0;
		    this->fields.m_currentSceneSaturation = 1.0;
		    return;
		  }
		  v5 = (__m128)0x3F800000u;
		  v6 = 0;
		  v7 = _mm_cvtsi128_si32((__m128i)0x3F800000u);
		  v8 = 0;
		  v9 = _mm_unpacklo_ps(v5, v5).m128_u64[0];
		  v40 = v9;
		  while ( 1 )
		  {
		    m_sceneDarks = this->fields.m_sceneDarks;
		    if ( !m_sceneDarks )
		      goto LABEL_42;
		    if ( v8 >= m_sceneDarks->fields._size )
		      break;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)this->fields.m_sceneDarks,
		             v8,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
		    v23 = TypeInfo::UnityEngine::Object;
		    v24 = Item;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v23 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v23 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !v24 )
		      goto LABEL_61;
		    if ( !v23->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v23);
		    if ( v24[1].klass )
		    {
		      v3 = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		      if ( !v3 )
		        goto LABEL_42;
		      v25 = System::Collections::Generic::List<System::Object>::get_Item(
		              v3,
		              v8,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
		      if ( !v25 )
		        goto LABEL_42;
		      sceneDark = HG::Rendering::Runtime::VFXSceneDark::get_sceneDark((Vector3 *)&v42, (VFXSceneDark *)v25, 0LL);
		      v27 = *(_QWORD *)&sceneDark->x;
		      *(float *)&sceneDark = sceneDark->z;
		      *(_QWORD *)&v41.x = v27;
		      LODWORD(v41.z) = (_DWORD)sceneDark;
		      v29 = *UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v41, v28);
		      v30 = (__m128)(unsigned int)v40;
		      if ( v29.x <= *(float *)&v40 )
		        v30 = (__m128)v29;
		      v31 = (__m128)HIDWORD(v40);
		      v32 = _mm_shuffle_ps((__m128)v29, (__m128)v29, 85);
		      if ( v32.m128_f32[0] <= *((float *)&v40 + 1) )
		        v31 = v32;
		      v33 = _mm_shuffle_ps((__m128)v29, (__m128)v29, 170);
		      v34 = _mm_cvtsi32_si128(v7);
		      if ( v33.m128_f32[0] <= *(float *)v34.m128i_i32 )
		        v34 = (__m128i)v33;
		      v7 = _mm_cvtsi128_si32(v34);
		      v40 = _mm_unpacklo_ps(v30, v31).m128_u64[0];
		      v9 = v40;
		      if ( v6 )
		        goto LABEL_60;
		      v3 = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		      if ( !v3 )
		        goto LABEL_42;
		      v35 = System::Collections::Generic::List<System::Object>::get_Item(
		              v3,
		              v8,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
		      if ( !v35 )
		        goto LABEL_42;
		      if ( HG::Rendering::Runtime::VFXSceneDark::get_stopAutoExposure((VFXSceneDark *)v35, 0LL) )
		LABEL_60:
		        v6 = 1;
		      v3 = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		      if ( !v3 )
		        goto LABEL_42;
		      v36 = System::Collections::Generic::List<System::Object>::get_Item(
		              v3,
		              v8,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
		      if ( !v36 )
		        goto LABEL_42;
		      sceneSaturation = HG::Rendering::Runtime::VFXSceneDark::get_sceneSaturation((VFXSceneDark *)v36, 0LL);
		      if ( sceneSaturation <= v5.m128_f32[0] )
		        v5.m128_f32[0] = sceneSaturation;
		      ++v8;
		    }
		    else
		    {
		LABEL_61:
		      v3 = (List_1_System_Object_ *)this->fields.m_sceneDarks;
		      if ( !v3 )
		        goto LABEL_42;
		      System::Collections::Generic::List<System::Object>::RemoveAt(
		        v3,
		        v8,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::RemoveAt);
		    }
		  }
		  unscaledTime = UnityEngine::Time::get_unscaledTime(0LL);
		  z = this->fields.m_currentSceneDarkValue.z;
		  m_currentSceneSaturation = this->fields.m_currentSceneSaturation;
		  this->fields.m_lastUpdateTime = unscaledTime;
		  *(_QWORD *)&this->fields.m_lastSceneDarkValue.x = *(_QWORD *)&this->fields.m_currentSceneDarkValue.x;
		  this->fields.m_lastSceneDarkValue.z = z;
		  this->fields.m_lastSceneSaturation = this->fields.m_currentSceneSaturation;
		  LOBYTE(z) = this->fields.m_currentNeedStopAutoExposure;
		  *(_QWORD *)&this->fields.m_currentSceneDarkValue.x = v9;
		  this->fields.m_lastNeedStopAutoExposure = LOBYTE(z);
		  LODWORD(this->fields.m_currentSceneSaturation) = v5.m128_i32[0];
		  LODWORD(this->fields.m_currentSceneDarkValue.z) = v7;
		  this->fields.m_currentNeedStopAutoExposure = v6;
		  x = this->fields.m_lastSceneDarkValue.x;
		  y = this->fields.m_currentSceneDarkValue.y;
		  v16 = this->fields.m_currentSceneDarkValue.z;
		  v17 = this->fields.m_lastSceneDarkValue.y;
		  v18 = this->fields.m_lastSceneDarkValue.z;
		  v42.x = this->fields.m_currentSceneDarkValue.x;
		  v42.y = y;
		  v42.z = v16;
		  v41.x = x;
		  v41.y = v17;
		  v41.z = v18;
		  LODWORD(v42.w) = v5.m128_i32[0];
		  v41.w = m_currentSceneSaturation;
		  v42 = *UnityEngine::Vector4::op_Subtraction(&v43, &v41, &v42, v19);
		  v41 = v42;
		  if ( UnityEngine::Vector4::Dot(&v41, &v42, v20) > 0.0099999998 )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( currentPipeline )
		      {
		        currentPipeline->fields._fastConvergeState_k__BackingField = 1;
		        return;
		      }
		      goto LABEL_42;
		    }
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v21 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( v21 )
		      {
		        v21->fields._fastConvergeState_k__BackingField = 0;
		        return;
		      }
		LABEL_42:
		      sub_1800D8260(v3, v4);
		    }
		  }
		}
		
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera targetCamera) {} // 0x000000018344FAF0-0x000000018344FBA0
		// Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
		void HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering(
		        HGVFXManager *this,
		        ScriptableRenderContext context,
		        Camera *targetCamera,
		        MethodInfo *method)
		{
		  Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *m_savedCameraAutoExposure; // rcx
		  Dictionary_2_TKey_TValue_Entry_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object___Array__Class *klass; // rdx
		  unsigned int (__fastcall *v9)(Camera *, Dictionary_2_TKey_TValue_Entry_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object___Array__Class *, Camera *, MethodInfo *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rax
		  HGCamera *v12; // rbx
		  int32_t InstanceID; // eax
		  int32_t v14; // esi
		  float Item; // xmm0_4
		
		  m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = m_savedCameraAutoExposure[2].fields._entries->klass;
		  if ( !klass )
		    goto LABEL_12;
		  if ( SLODWORD(klass->_0.namespaze) > 2274 )
		  {
		    if ( !LODWORD(m_savedCameraAutoExposure[2].fields._values) )
		    {
		      il2cpp_runtime_class_init_1(m_savedCameraAutoExposure);
		      m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)m_savedCameraAutoExposure[2].fields._entries->klass;
		    if ( !m_savedCameraAutoExposure )
		      goto LABEL_12;
		    if ( LODWORD(m_savedCameraAutoExposure->fields._entries) <= 0x8E2 )
		      sub_1800D2AB0(m_savedCameraAutoExposure, klass);
		    if ( m_savedCameraAutoExposure[227].fields._values )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2274, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
		        return;
		      }
		      goto LABEL_12;
		    }
		  }
		  if ( !targetCamera )
		    goto LABEL_12;
		  v9 = (unsigned int (__fastcall *)(Camera *, Dictionary_2_TKey_TValue_Entry_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object___Array__Class *, Camera *, MethodInfo *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v9 = (unsigned int (__fastcall *)(Camera *, Dictionary_2_TKey_TValue_Entry_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object___Array__Class *, Camera *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v9 )
		    {
		      v11 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F36F138 = (__int64)v9;
		  }
		  if ( v9(targetCamera, klass, targetCamera, method) == 1 )
		  {
		    if ( !this->fields.m_currentNeedStopAutoExposure )
		    {
		      m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)this->fields.m_savedCameraAutoExposure;
		      if ( m_savedCameraAutoExposure )
		      {
		        if ( m_savedCameraAutoExposure->fields._count - m_savedCameraAutoExposure->fields._freeCount > 0 )
		          System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		            m_savedCameraAutoExposure,
		            MethodInfo::System::Collections::Generic::Dictionary<int,float>::Clear);
		        return;
		      }
		      goto LABEL_12;
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v12 = HG::Rendering::Runtime::HGCamera::GetOrCreate(targetCamera, 0, 0LL);
		    if ( v12 )
		    {
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)targetCamera, 0LL);
		      m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)this->fields.m_savedCameraAutoExposure;
		      v14 = InstanceID;
		      if ( !m_savedCameraAutoExposure )
		        goto LABEL_12;
		      if ( !System::Collections::Generic::Dictionary<int,float>::ContainsKey(
		              (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
		              InstanceID,
		              MethodInfo::System::Collections::Generic::Dictionary<int,float>::ContainsKey) )
		      {
		        m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)this->fields.m_savedCameraAutoExposure;
		        if ( !m_savedCameraAutoExposure )
		          goto LABEL_12;
		        System::Collections::Generic::Dictionary<int,float>::Add(
		          (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
		          v14,
		          v12->fields.exposureAdaptation,
		          MethodInfo::System::Collections::Generic::Dictionary<int,float>::Add);
		      }
		      m_savedCameraAutoExposure = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)this->fields.m_savedCameraAutoExposure;
		      if ( m_savedCameraAutoExposure )
		      {
		        Item = System::Collections::Generic::Dictionary<int,float>::get_Item(
		                 (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
		                 v14,
		                 MethodInfo::System::Collections::Generic::Dictionary<int,float>::get_Item);
		        v12->fields.exposureTargetAdaptation = Item;
		        v12->fields.exposureAdaptation = Item;
		        return;
		      }
		LABEL_12:
		      sub_1800D8260(m_savedCameraAutoExposure, klass);
		    }
		  }
		}
		
		public void Tick() {} // 0x00000001831C8400-0x00000001831C8470
		// Void Tick()
		void HG::Rendering::Runtime::HGVFXManager::Tick(HGVFXManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 2328 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue(this, 0LL);
		    HG::Rendering::Runtime::HGVFXManager::_UpdateAllCircles(this, 0LL);
		    return;
		  }
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x918 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[49]._1.cctor_thread )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2328, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public static void SetPlayerPosition(Vector3 playerPosition) {} // 0x00000001831CC240-0x00000001831CC2C0
		// Void SetPlayerPosition(Vector3)
		void HG::Rendering::Runtime::HGVFXManager::SetPlayerPosition(Vector3 *playerPosition, MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float v6; // ecx
		  float z; // eax
		  Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2404, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2404, 0LL);
		    if ( Patch )
		    {
		      z = playerPosition->z;
		      *(_QWORD *)&v8.x = *(_QWORD *)&playerPosition->x;
		      v8.z = z;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_940(Patch, &v8, 0LL);
		      return;
		    }
		    goto LABEL_10;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		    {
		      v6 = playerPosition->z;
		      *(_QWORD *)&instance->fields.m_playerPosition.x = *(_QWORD *)&playerPosition->x;
		      instance->fields.m_playerPosition.z = v6;
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(Patch, v4);
		  }
		}
		
		public static Vector3 GetPlayerPosition() => default; // 0x0000000183D36CE0-0x0000000183D36D90
		// Vector3 GetPlayerPosition()
		Vector3 *HG::Rendering::Runtime::HGVFXManager::GetPlayerPosition(Vector3 *__return_ptr retstr, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGVFXManager *instance; // rax
		  __int64 v6; // xmm0_8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_14;
		  if ( wrapperArray->max_length.size > 897 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_14;
		    if ( LODWORD(v3->_0.namespaze) <= 0x381 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( v3[19]._0.element_class )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(897, 0LL);
		      if ( Patch )
		      {
		        v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_355(v12, Patch, 0LL);
		        v11 = *(_QWORD *)&v10->x;
		        z = v10->z;
		        *(_QWORD *)&retstr->x = v11;
		        goto LABEL_12;
		      }
		LABEL_14:
		      sub_1800D8260(v3, wrapperArray);
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		  {
		    *(_QWORD *)&retstr->x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    retstr->z = 0.0;
		    return retstr;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_14;
		  v6 = *(_QWORD *)&instance->fields.m_playerPosition.x;
		  z = instance->fields.m_playerPosition.z;
		  *(_QWORD *)&retstr->x = v6;
		LABEL_12:
		  retstr->z = z;
		  return retstr;
		}
		
		public static void SetPlayerHeights(List<float> playerHeights) {} // 0x000000018323B8B0-0x000000018323BA50
		// Void SetPlayerHeights(List`1[System.Single])
		void HG::Rendering::Runtime::HGVFXManager::SetPlayerHeights(List_1_System_Single_ *playerHeights, MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  Vector3Int *v4; // r8
		  ITilemap *v5; // r9
		  HGVFXManager *v6; // rdx
		  Single__Array *items; // rcx
		  TileAnimationData v8; // xmm1
		  unsigned int v9; // ebx
		  float v10; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2405, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2405, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)playerHeights, 0LL);
		      return;
		    }
		    goto LABEL_25;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		    return;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  v8 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		          &v12,
		          (TileBase *)instance,
		          v4,
		          v5,
		          (MethodInfo *)v12.m_AnimatedSprites);
		  if ( !v6 || (v6->fields.m_playerHeights = (Vector4)v8, v9 = 0, !playerHeights) )
		LABEL_25:
		    sub_1800D8260(items, v6);
		  while ( (signed int)v9 < playerHeights->fields._size && v9 <= 3 )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    v6 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( !v6 )
		      goto LABEL_25;
		    if ( v9 >= playerHeights->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = playerHeights->fields._items;
		    if ( !items )
		      goto LABEL_25;
		    if ( v9 >= items->max_length.size )
		      sub_1800D2AB0(items, v6);
		    v10 = items->vector[v9];
		    if ( v9 == 3 )
		    {
		      v6->fields.m_playerHeights.w = v10;
		      v9 = 4;
		    }
		    else if ( v9 )
		    {
		      if ( v9 == 1 )
		      {
		        v6->fields.m_playerHeights.y = v10;
		        v9 = 2;
		      }
		      else
		      {
		        v6->fields.m_playerHeights.z = v10;
		        v9 = 3;
		      }
		    }
		    else
		    {
		      v6->fields.m_playerHeights.x = v10;
		      v9 = 1;
		    }
		  }
		}
		
		public static Vector4 GetPlayerHeights() => default; // 0x0000000183D4E860-0x0000000183D4E910
		// Vector4 GetPlayerHeights()
		Vector4 *HG::Rendering::Runtime::HGVFXManager::GetPlayerHeights(Vector4 *__return_ptr retstr, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  TileBase *v5; // rdx
		  Vector3Int *v6; // r8
		  ITilemap *v7; // r9
		  HGVFXManager *instance; // rax
		  Vector4 m_playerHeights; // xmm0
		  Vector4 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 *TileAnimationDataNoRef; // rax
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size <= 903 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_13:
		    sub_1800D8260(v3, method);
		  if ( LODWORD(v3->_0.namespaze) <= 0x387 )
		    sub_1800D2AB0(v3, method);
		  if ( v3[19]._0.interopData )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(903, 0LL);
		    if ( !Patch )
		      goto LABEL_13;
		    TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_358(&v13, Patch, 0LL);
		LABEL_23:
		    m_playerHeights = *TileAnimationDataNoRef;
		    goto LABEL_12;
		  }
		LABEL_5:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		  {
		    TileAnimationDataNoRef = (Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                          (TileAnimationData *)&v13,
		                                          v5,
		                                          v6,
		                                          v7,
		                                          *(MethodInfo **)&v13.x);
		    goto LABEL_23;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_13;
		  m_playerHeights = instance->fields.m_playerHeights;
		LABEL_12:
		  result = retstr;
		  *retstr = m_playerHeights;
		  return result;
		}
		
		public static void SetAnchorWaveBright(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag) {} // 0x0000000189B599E8-0x0000000189B59AF4
		// Void SetAnchorWaveBright(Vector2, Single, Single, Boolean)
		void HG::Rendering::Runtime::HGVFXManager::SetAnchorWaveBright(
		        Vector2 anchorPosition,
		        float anchorRadius,
		        float anchorBrightIntensity,
		        bool anchorBrightFlag,
		        MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGVFXManager *v10; // rax
		  HGVFXManager *v11; // rax
		  HGVFXManager *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2406, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_anchorPosition = anchorPosition;
		      v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		      if ( v10 )
		      {
		        v10->fields.m_anchorRadius = anchorRadius;
		        v11 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		        if ( v11 )
		        {
		          v11->fields.m_anchorBrightIntensity = anchorBrightIntensity;
		          v12 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		          if ( v12 )
		          {
		            v12->fields.m_anchorBrightFlag = anchorBrightFlag;
		            return;
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2406, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_941(
		    Patch,
		    anchorPosition,
		    anchorRadius,
		    anchorBrightIntensity,
		    anchorBrightFlag,
		    0LL);
		}
		
		public static Vector4 GetAnchorWaveBright() => default; // 0x0000000183104670-0x0000000183104890
		// Vector4 GetAnchorWaveBright()
		Vector4 *HG::Rendering::Runtime::HGVFXManager::GetAnchorWaveBright(Vector4 *__return_ptr retstr, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  TileBase *v5; // rdx
		  Vector3Int *v6; // r8
		  ITilemap *v7; // r9
		  HGVFXManager *instance; // rax
		  float m_anchorBrightFlag; // xmm8_4
		  HGVFXManager *v10; // rax
		  __m128 x_low; // xmm6
		  HGVFXManager *v12; // rax
		  float y; // xmm10_4
		  HGVFXManager *v14; // rax
		  float m_anchorRadius; // xmm9_4
		  HGVFXManager *v16; // rax
		  float m_anchorBrightIntensity; // xmm7_4
		  float v18; // xmm7_4
		  __m128 v19; // xmm6
		  __m128 v20; // xmm6
		  __m128 v21; // xmm6
		  __m128 v22; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 *TileAnimationDataNoRef; // rax
		  ILFixDynamicMethodWrapper_2 *v26; // rax
		  MethodInfo *v27; // [rsp+20h] [rbp-88h]
		  Vector4 v28; // [rsp+40h] [rbp-68h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->max_length.size > 900 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_26;
		    if ( wrapperArray->max_length.size <= 0x384u )
		      goto LABEL_43;
		    if ( wrapperArray[25].vector[0] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(900, 0LL);
		      if ( !Patch )
		        goto LABEL_26;
		      TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_358(&v28, Patch, 0LL);
		LABEL_34:
		      *retstr = *TileAnimationDataNoRef;
		      return retstr;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		  {
		    TileAnimationDataNoRef = (Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                          (TileAnimationData *)&v28,
		                                          v5,
		                                          v6,
		                                          v7,
		                                          v27);
		    goto LABEL_34;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_26;
		  m_anchorBrightFlag = (float)instance->fields.m_anchorBrightFlag;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !v10 )
		    goto LABEL_26;
		  x_low = (__m128)LODWORD(v10->fields.m_anchorPosition.x);
		  v12 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !v12 )
		    goto LABEL_26;
		  y = v12->fields.m_anchorPosition.y;
		  v14 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !v14 )
		    goto LABEL_26;
		  m_anchorRadius = v14->fields.m_anchorRadius;
		  v16 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !v16 )
		    goto LABEL_26;
		  m_anchorBrightIntensity = v16->fields.m_anchorBrightIntensity;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v18 = m_anchorBrightIntensity * m_anchorBrightFlag;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->max_length.size > 899 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_26;
		    if ( LODWORD(v3->_0.namespaze) > 0x383 )
		    {
		      if ( !v3[19]._0.declaringType )
		        goto LABEL_23;
		      v26 = IFix::WrappersManagerImpl::GetPatch(899, 0LL);
		      if ( v26 )
		      {
		        v22 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_357(
		                           &v28,
		                           v26,
		                           x_low.m128_f32[0],
		                           y,
		                           m_anchorRadius,
		                           v18,
		                           0LL);
		        goto LABEL_24;
		      }
		LABEL_26:
		      sub_1800D8260(v3, wrapperArray);
		    }
		LABEL_43:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		LABEL_23:
		  v19 = _mm_shuffle_ps(x_low, x_low, 225);
		  v19.m128_f32[0] = y;
		  v20 = _mm_shuffle_ps(v19, v19, 198);
		  v20.m128_f32[0] = m_anchorRadius;
		  v21 = _mm_shuffle_ps(v20, v20, 39);
		  v21.m128_f32[0] = v18;
		  v22 = _mm_shuffle_ps(v21, v21, 57);
		LABEL_24:
		  *retstr = (Vector4)v22;
		  return retstr;
		}
		
		public static void SetGlobalBrightRadius(float brightInnerRadius, float brightOuterRadius) {} // 0x0000000189B59AF4-0x0000000189B59BA0
		// Void SetGlobalBrightRadius(Single, Single)
		void HG::Rendering::Runtime::HGVFXManager::SetGlobalBrightRadius(
		        float brightInnerRadius,
		        float brightOuterRadius,
		        MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGVFXManager *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2407, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_brightInnerRadius = brightInnerRadius;
		      v7 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		      if ( v7 )
		      {
		        v7->fields.m_brightOuterRadius = brightOuterRadius;
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2407, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_942(Patch, brightInnerRadius, brightOuterRadius, 0LL);
		}
		
		public static Vector4 GetGlobalBrightRadius() => default; // 0x0000000183C160D0-0x0000000183C16240
		// Vector4 GetGlobalBrightRadius()
		Vector4 *HG::Rendering::Runtime::HGVFXManager::GetGlobalBrightRadius(Vector4 *__return_ptr retstr, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  TileBase *v5; // rdx
		  Vector3Int *v6; // r8
		  ITilemap *v7; // r9
		  HGVFXManager *instance; // rax
		  float m_brightInnerRadius; // xmm7_4
		  HGVFXManager *v10; // rax
		  float m_brightOuterRadius; // xmm6_4
		  __m128 v12; // xmm0
		  __m128 v13; // xmm0
		  Vector4 v14; // xmm0
		  Vector4 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 *TileAnimationDataNoRef; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-48h]
		  Vector4 v20; // [rsp+30h] [rbp-38h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 901 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_20;
		    if ( wrapperArray->max_length.size <= 0x385u )
		      goto LABEL_37;
		    if ( wrapperArray[25].vector[1] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(901, 0LL);
		      if ( !Patch )
		        goto LABEL_20;
		      TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_358(&v20, Patch, 0LL);
		LABEL_28:
		      v14 = *TileAnimationDataNoRef;
		      goto LABEL_19;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		  {
		    TileAnimationDataNoRef = (Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                          (TileAnimationData *)&v20,
		                                          v5,
		                                          v6,
		                                          v7,
		                                          v19);
		    goto LABEL_28;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_20;
		  m_brightInnerRadius = instance->fields.m_brightInnerRadius;
		  v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		  if ( !v10 )
		    goto LABEL_20;
		  m_brightOuterRadius = v10->fields.m_brightOuterRadius;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 902 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_20;
		    if ( LODWORD(v3->_0.namespaze) > 0x386 )
		    {
		      if ( !v3[19]._0.typeMetadataHandle )
		        goto LABEL_18;
		      v18 = IFix::WrappersManagerImpl::GetPatch(902, 0LL);
		      if ( v18 )
		      {
		        TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
		                                   &v20,
		                                   v18,
		                                   m_brightInnerRadius,
		                                   m_brightOuterRadius,
		                                   0LL);
		        goto LABEL_28;
		      }
		LABEL_20:
		      sub_1800D8260(v3, wrapperArray);
		    }
		LABEL_37:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		LABEL_18:
		  *(_QWORD *)&v20.z = 0LL;
		  v12 = (__m128)*(unsigned __int64 *)&v20.x;
		  v12.m128_f32[0] = m_brightInnerRadius;
		  v13 = _mm_shuffle_ps(v12, v12, 225);
		  v13.m128_f32[0] = m_brightOuterRadius;
		  v14 = (Vector4)_mm_shuffle_ps(v13, v13, 225);
		LABEL_19:
		  result = retstr;
		  *retstr = v14;
		  return result;
		}
		
		public void InitVFXSceneColorAdjustment(Shader sceneColorAdjustmentShader) {} // 0x0000000184CDD0F0-0x0000000184CDD160
		// Void InitVFXSceneColorAdjustment(Shader)
		void HG::Rendering::Runtime::HGVFXManager::InitVFXSceneColorAdjustment(
		        HGVFXManager *this,
		        Shader *sceneColorAdjustmentShader,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2408, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2408, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)sceneColorAdjustmentShader,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_vfxSceneColorAdjustmentMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                                       sceneColorAdjustmentShader,
		                                                       0,
		                                                       0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_vfxSceneColorAdjustmentMaterial, v5, v6, v7, v11);
		  }
		}
		
		public bool UseSceneSaturationColorAdjustment() => default; // 0x0000000189B59C80-0x0000000189B59CE0
		// Boolean UseSceneSaturationColorAdjustment()
		bool HG::Rendering::Runtime::HGVFXManager::UseSceneSaturationColorAdjustment(HGVFXManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2409, 0LL) )
		    return this->fields.m_currentSceneSaturation < 0.99;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2409, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public Material BeforeDrawVFXSceneColorAdjustmentMaterial() => default; // 0x0000000189B59190-0x0000000189B592E4
		// Material BeforeDrawVFXSceneColorAdjustmentMaterial()
		Material *HG::Rendering::Runtime::HGVFXManager::BeforeDrawVFXSceneColorAdjustmentMaterial(
		        HGVFXManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Material *m_vfxSceneColorAdjustmentMaterial; // rcx
		  Shader *shader; // rbx
		  double m_currentSceneSaturation; // xmm0_8
		  float v8; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword keyword; // [rsp+20h] [rbp-38h] BYREF
		
		  memset(&keyword, 0, sizeof(keyword));
		  if ( !IFix::WrappersManagerImpl::IsPatched(2410, 0LL) )
		  {
		    if ( fminf(
		           fminf(this->fields.m_currentSceneDarkValue.x, this->fields.m_currentSceneDarkValue.y),
		           this->fields.m_currentSceneDarkValue.z) > 0.99
		      && this->fields.m_currentSceneSaturation > 0.99 )
		    {
		      return 0LL;
		    }
		    m_vfxSceneColorAdjustmentMaterial = this->fields.m_vfxSceneColorAdjustmentMaterial;
		    if ( m_vfxSceneColorAdjustmentMaterial )
		    {
		      shader = UnityEngine::Material::get_shader(m_vfxSceneColorAdjustmentMaterial, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		        &keyword,
		        shader,
		        TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SceneColorAdjustMentEnableSaturation,
		        0LL);
		      m_vfxSceneColorAdjustmentMaterial = this->fields.m_vfxSceneColorAdjustmentMaterial;
		      m_currentSceneSaturation = this->fields.m_currentSceneSaturation;
		      if ( m_vfxSceneColorAdjustmentMaterial )
		      {
		        UnityEngine::Material::SetKeyword(
		          m_vfxSceneColorAdjustmentMaterial,
		          &keyword,
		          m_currentSceneSaturation < 0.99,
		          0LL);
		        m_vfxSceneColorAdjustmentMaterial = this->fields.m_vfxSceneColorAdjustmentMaterial;
		        if ( m_currentSceneSaturation < 0.99 )
		        {
		          if ( m_vfxSceneColorAdjustmentMaterial )
		          {
		            v8 = 1.0;
		            goto LABEL_12;
		          }
		        }
		        else if ( m_vfxSceneColorAdjustmentMaterial )
		        {
		          v8 = 2.0;
		LABEL_12:
		          UnityEngine::Material::SetFloat(m_vfxSceneColorAdjustmentMaterial, (String *)"_SrcBlend", v8, 0LL);
		          return this->fields.m_vfxSceneColorAdjustmentMaterial;
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(m_vfxSceneColorAdjustmentMaterial, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2410, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
		}
		
		public void DrawVFXSceneColorAdjustmentMaterial(CommandBuffer cmd) {} // 0x0000000189B59868-0x0000000189B59908
		// Void DrawVFXSceneColorAdjustmentMaterial(CommandBuffer)
		void HG::Rendering::Runtime::HGVFXManager::DrawVFXSceneColorAdjustmentMaterial(
		        HGVFXManager *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  Material *v5; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2411, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2411, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    v5 = HG::Rendering::Runtime::HGVFXManager::BeforeDrawVFXSceneColorAdjustmentMaterial(this, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)v5, 0LL, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, v5, 0LL, 0, 0LL);
		    }
		  }
		}
		
		public void GetSceneColorAdjustmentParams(out Vector3 value, out float saturation) {
			value = default;
			saturation = default;
		} // 0x0000000183E022F0-0x0000000183E02370
		// Void GetSceneColorAdjustmentParams(Vector3 ByRef, Single ByRef)
		void HG::Rendering::Runtime::HGVFXManager::GetSceneColorAdjustmentParams(
		        HGVFXManager *this,
		        Vector3 *value,
		        float *saturation,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 896 )
		  {
		LABEL_5:
		    z = this->fields.m_currentSceneDarkValue.z;
		    *(_QWORD *)&value->x = *(_QWORD *)&this->fields.m_currentSceneDarkValue.x;
		    value->z = z;
		    *saturation = this->fields.m_currentSceneSaturation;
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x380 )
		    sub_1800D2AB0(v6, value);
		  if ( !*((_QWORD *)&v6[19]._0.this_arg + 1) )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(896, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, value);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_354(Patch, (Object *)this, value, saturation, 0LL);
		}
		
		private static void _GetOrthographicNearClipCorners(Camera camera, float posZ, Vector3[] result) {} // 0x0000000189B59CE0-0x0000000189B5A1DC
		// Void _GetOrthographicNearClipCorners(Camera, Single, Vector3[])
		void HG::Rendering::Runtime::HGVFXManager::_GetOrthographicNearClipCorners(
		        Camera *camera,
		        float posZ,
		        Vector3__Array *result,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  float v8; // xmm12_4
		  float orthographicSize; // xmm8_4
		  float v10; // xmm7_4
		  Transform *transform; // rax
		  Vector3 *right; // rax
		  __int64 v13; // xmm11_8
		  float z; // r15d
		  Transform *v15; // rax
		  Vector3 *up; // rax
		  __int64 v17; // xmm10_8
		  float v18; // r14d
		  Transform *v19; // rax
		  Vector3 *forward; // rax
		  __int64 v21; // xmm9_8
		  float v22; // esi
		  Transform *v23; // rax
		  Vector3 *position; // rax
		  __int64 v25; // xmm13_8
		  float v26; // ebx
		  MethodInfo *v27; // r9
		  Vector3 *v28; // rax
		  __int64 v29; // xmm3_8
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // xmm3_8
		  MethodInfo *v33; // r9
		  Vector3 *v34; // rax
		  __int64 v35; // xmm3_8
		  MethodInfo *v36; // r9
		  Vector3 *v37; // rax
		  __int64 v38; // xmm3_8
		  MethodInfo *v39; // r9
		  Vector3 *v40; // rax
		  __int64 v41; // xmm3_8
		  MethodInfo *v42; // r9
		  Vector3 *v43; // rax
		  __int64 v44; // xmm0_8
		  float v45; // eax
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm3_8
		  MethodInfo *v52; // r9
		  Vector3 *v53; // rax
		  __int64 v54; // xmm3_8
		  MethodInfo *v55; // r9
		  Vector3 *v56; // rax
		  __int64 v57; // xmm3_8
		  MethodInfo *v58; // r9
		  Vector3 *v59; // rax
		  __int64 v60; // xmm3_8
		  MethodInfo *v61; // r9
		  Vector3 *v62; // rax
		  __int64 v63; // xmm3_8
		  MethodInfo *v64; // r9
		  Vector3 *v65; // rax
		  __int64 v66; // xmm3_8
		  MethodInfo *v67; // r9
		  Vector3 *v68; // rax
		  __int64 v69; // xmm3_8
		  MethodInfo *v70; // r9
		  Vector3 *v71; // rax
		  __int64 v72; // xmm3_8
		  MethodInfo *v73; // r9
		  Vector3 *v74; // rax
		  __int64 v75; // xmm3_8
		  MethodInfo *v76; // r9
		  Vector3 *v77; // rax
		  __int64 v78; // xmm3_8
		  MethodInfo *v79; // r9
		  Vector3 *v80; // rax
		  __int64 v81; // xmm3_8
		  MethodInfo *v82; // r9
		  Vector3 *v83; // rax
		  __int64 v84; // xmm3_8
		  MethodInfo *v85; // r9
		  Vector3 *v86; // rax
		  __int64 v87; // xmm3_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v89; // [rsp+38h] [rbp-89h] BYREF
		  Vector3 v90; // [rsp+48h] [rbp-79h] BYREF
		  Vector3 v91; // [rsp+58h] [rbp-69h] BYREF
		  Vector3 v92; // [rsp+68h] [rbp-59h] BYREF
		  Vector3 v93[12]; // [rsp+78h] [rbp-49h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1131, 0LL) )
		  {
		    if ( camera )
		    {
		      v8 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		      orthographicSize = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
		      v10 = UnityEngine::Camera::get_aspect(camera, 0LL) * orthographicSize;
		      transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		      if ( transform )
		      {
		        right = UnityEngine::Transform::get_right(&v92, transform, 0LL);
		        v13 = *(_QWORD *)&right->x;
		        z = right->z;
		        v15 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		        if ( v15 )
		        {
		          up = UnityEngine::Transform::get_up(&v92, v15, 0LL);
		          v17 = *(_QWORD *)&up->x;
		          v18 = up->z;
		          v19 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		          if ( v19 )
		          {
		            forward = UnityEngine::Transform::get_forward(&v92, v19, 0LL);
		            v21 = *(_QWORD *)&forward->x;
		            v22 = forward->z;
		            v23 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		            if ( v23 )
		            {
		              position = UnityEngine::Transform::get_position(&v92, v23, 0LL);
		              *(_QWORD *)&v89.x = v21;
		              v89.z = v22;
		              v25 = *(_QWORD *)&position->x;
		              v26 = position->z;
		              v28 = UnityEngine::Vector3::op_Multiply(&v91, &v89, v8, v27);
		              *(_QWORD *)&v89.x = v13;
		              v89.z = z;
		              v29 = *(_QWORD *)&v28->x;
		              *(float *)&v28 = v28->z;
		              *(_QWORD *)&v90.x = v29;
		              LODWORD(v90.z) = (_DWORD)v28;
		              *(_QWORD *)&v91.x = v25;
		              v91.z = v26;
		              v31 = UnityEngine::Vector3::op_Multiply(&v92, &v89, v10, v30);
		              v32 = *(_QWORD *)&v31->x;
		              *(float *)&v31 = v31->z;
		              *(_QWORD *)&v89.x = v32;
		              LODWORD(v89.z) = (_DWORD)v31;
		              v34 = UnityEngine::Vector3::op_Addition(&v92, &v91, &v90, v33);
		              *(_QWORD *)&v91.x = v17;
		              v91.z = v18;
		              v35 = *(_QWORD *)&v34->x;
		              *(float *)&v34 = v34->z;
		              *(_QWORD *)&v90.x = v35;
		              LODWORD(v90.z) = (_DWORD)v34;
		              v37 = UnityEngine::Vector3::op_Multiply(&v92, &v91, orthographicSize, v36);
		              v38 = *(_QWORD *)&v37->x;
		              *(float *)&v37 = v37->z;
		              *(_QWORD *)&v91.x = v38;
		              LODWORD(v91.z) = (_DWORD)v37;
		              v40 = UnityEngine::Vector3::op_Subtraction(&v92, &v90, &v89, v39);
		              v41 = *(_QWORD *)&v40->x;
		              *(float *)&v40 = v40->z;
		              *(_QWORD *)&v90.x = v41;
		              LODWORD(v90.z) = (_DWORD)v40;
		              v43 = UnityEngine::Vector3::op_Subtraction(&v92, &v90, &v91, v42);
		              if ( result )
		              {
		                v44 = *(_QWORD *)&v43->x;
		                v45 = v43->z;
		                *(_QWORD *)&v91.x = v44;
		                v91.z = v45;
		                sub_180049BD0(result, 0LL, &v91);
		                *(_QWORD *)&v91.x = v21;
		                v91.z = v22;
		                v47 = UnityEngine::Vector3::op_Multiply(&v92, &v91, v8, v46);
		                *(_QWORD *)&v89.x = v25;
		                v89.z = v26;
		                *(_QWORD *)&v91.x = v13;
		                v48 = *(_QWORD *)&v47->x;
		                *(float *)&v47 = v47->z;
		                *(_QWORD *)&v90.x = v48;
		                LODWORD(v90.z) = (_DWORD)v47;
		                v91.z = z;
		                v50 = UnityEngine::Vector3::op_Multiply(&v92, &v91, v10, v49);
		                v51 = *(_QWORD *)&v50->x;
		                *(float *)&v50 = v50->z;
		                *(_QWORD *)&v91.x = v51;
		                LODWORD(v91.z) = (_DWORD)v50;
		                v53 = UnityEngine::Vector3::op_Multiply(v93, &v91, 3.0, v52);
		                v54 = *(_QWORD *)&v53->x;
		                *(float *)&v53 = v53->z;
		                *(_QWORD *)&v92.x = v54;
		                LODWORD(v92.z) = (_DWORD)v53;
		                v56 = UnityEngine::Vector3::op_Addition(v93, &v89, &v90, v55);
		                *(_QWORD *)&v91.x = v17;
		                v91.z = v18;
		                v57 = *(_QWORD *)&v56->x;
		                *(float *)&v56 = v56->z;
		                *(_QWORD *)&v90.x = v57;
		                LODWORD(v90.z) = (_DWORD)v56;
		                v59 = UnityEngine::Vector3::op_Multiply(v93, &v91, orthographicSize, v58);
		                v60 = *(_QWORD *)&v59->x;
		                *(float *)&v59 = v59->z;
		                *(_QWORD *)&v91.x = v60;
		                LODWORD(v91.z) = (_DWORD)v59;
		                v62 = UnityEngine::Vector3::op_Addition(v93, &v90, &v92, v61);
		                v63 = *(_QWORD *)&v62->x;
		                *(float *)&v62 = v62->z;
		                *(_QWORD *)&v92.x = v63;
		                LODWORD(v92.z) = (_DWORD)v62;
		                v65 = UnityEngine::Vector3::op_Subtraction(v93, &v92, &v91, v64);
		                v66 = *(_QWORD *)&v65->x;
		                *(float *)&v65 = v65->z;
		                *(_QWORD *)&v92.x = v66;
		                LODWORD(v92.z) = (_DWORD)v65;
		                sub_180049BD0(result, 1LL, &v92);
		                *(_QWORD *)&v92.x = v21;
		                v92.z = v22;
		                v68 = UnityEngine::Vector3::op_Multiply(v93, &v92, v8, v67);
		                *(_QWORD *)&v90.x = v25;
		                v90.z = v26;
		                *(_QWORD *)&v92.x = v13;
		                v69 = *(_QWORD *)&v68->x;
		                *(float *)&v68 = v68->z;
		                *(_QWORD *)&v91.x = v69;
		                LODWORD(v91.z) = (_DWORD)v68;
		                v92.z = z;
		                v71 = UnityEngine::Vector3::op_Multiply(v93, &v92, v10, v70);
		                v72 = *(_QWORD *)&v71->x;
		                *(float *)&v71 = v71->z;
		                *(_QWORD *)&v89.x = v72;
		                LODWORD(v89.z) = (_DWORD)v71;
		                v74 = UnityEngine::Vector3::op_Addition(v93, &v90, &v91, v73);
		                *(_QWORD *)&v92.x = v17;
		                v92.z = v18;
		                v75 = *(_QWORD *)&v74->x;
		                *(float *)&v74 = v74->z;
		                *(_QWORD *)&v91.x = v75;
		                LODWORD(v91.z) = (_DWORD)v74;
		                v77 = UnityEngine::Vector3::op_Multiply(v93, &v92, orthographicSize, v76);
		                v78 = *(_QWORD *)&v77->x;
		                *(float *)&v77 = v77->z;
		                *(_QWORD *)&v92.x = v78;
		                LODWORD(v92.z) = (_DWORD)v77;
		                v80 = UnityEngine::Vector3::op_Multiply(v93, &v92, 3.0, v79);
		                v81 = *(_QWORD *)&v80->x;
		                *(float *)&v80 = v80->z;
		                *(_QWORD *)&v92.x = v81;
		                LODWORD(v92.z) = (_DWORD)v80;
		                v83 = UnityEngine::Vector3::op_Subtraction(v93, &v91, &v89, v82);
		                v84 = *(_QWORD *)&v83->x;
		                *(float *)&v83 = v83->z;
		                *(_QWORD *)&v91.x = v84;
		                LODWORD(v91.z) = (_DWORD)v83;
		                v86 = UnityEngine::Vector3::op_Addition(v93, &v91, &v92, v85);
		                v87 = *(_QWORD *)&v86->x;
		                *(float *)&v86 = v86->z;
		                *(_QWORD *)&v92.x = v87;
		                LODWORD(v92.z) = (_DWORD)v86;
		                sub_180049BD0(result, 2LL, &v92);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1131, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		    (ILFixDynamicMethodWrapper_4 *)Patch,
		    (Object *)camera,
		    posZ,
		    (Object *)result,
		    0LL);
		}
		
		private static void _GetPerspectiveNearClipCorners(Camera camera, float posZ, Vector3[] result) {} // 0x00000001831D0FB0-0x00000001831D14F0
		// Void _GetPerspectiveNearClipCorners(Camera, Single, Vector3[])
		void HG::Rendering::Runtime::HGVFXManager::_GetPerspectiveNearClipCorners(
		        Camera *camera,
		        float posZ,
		        Vector3__Array *result,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // r8
		  __int64 v11; // r9
		  float v12; // xmm0_4
		  float v13; // xmm6_4
		  float v14; // xmm7_4
		  Transform *transform; // rax
		  Vector3 *right; // rax
		  __int64 v17; // xmm12_8
		  float z; // r15d
		  Transform *v19; // rax
		  Vector3 *up; // rax
		  __int64 v21; // xmm11_8
		  float v22; // r14d
		  Transform *v23; // rax
		  Vector3 *forward; // rax
		  __int64 v25; // xmm10_8
		  float v26; // esi
		  Transform *v27; // rax
		  Vector3 *position; // rax
		  Vector3 *v29; // rax
		  __int64 v30; // xmm3_8
		  __int64 v31; // xmm5_8
		  MethodInfo *v32; // r9
		  Vector3 *v33; // rax
		  __int64 v34; // xmm3_8
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  __int64 v37; // xmm3_8
		  MethodInfo *v38; // r9
		  Vector3 *v39; // rax
		  __int64 v40; // xmm3_8
		  MethodInfo *v41; // r9
		  Vector3 *v42; // rax
		  __int64 v43; // xmm3_8
		  MethodInfo *v44; // r9
		  Vector3 *v45; // rax
		  __int64 v46; // xmm3_8
		  MethodInfo *v47; // r9
		  Vector3 *v48; // rax
		  __int64 v49; // xmm3_8
		  MethodInfo *v50; // r9
		  Vector3 *v51; // rax
		  MethodInfo *v52; // r9
		  Vector3 *v53; // rax
		  __int64 v54; // xmm5_8
		  MethodInfo *v55; // r9
		  __int64 v56; // xmm3_8
		  Vector3 *v57; // rax
		  __int64 v58; // xmm3_8
		  MethodInfo *v59; // r9
		  Vector3 *v60; // rax
		  __int64 v61; // xmm3_8
		  MethodInfo *v62; // r9
		  Vector3 *v63; // rax
		  __int64 v64; // xmm3_8
		  MethodInfo *v65; // r9
		  Vector3 *v66; // rax
		  __int64 v67; // xmm3_8
		  MethodInfo *v68; // r9
		  Vector3 *v69; // rax
		  __int64 v70; // xmm3_8
		  MethodInfo *v71; // r9
		  Vector3 *v72; // rax
		  __int64 v73; // xmm3_8
		  MethodInfo *v74; // r9
		  Vector3 *v75; // rax
		  MethodInfo *v76; // r9
		  Vector3 *v77; // rax
		  __int64 v78; // xmm5_8
		  MethodInfo *v79; // r9
		  __int64 v80; // xmm3_8
		  Vector3 *v81; // rax
		  __int64 v82; // xmm3_8
		  MethodInfo *v83; // r9
		  Vector3 *v84; // rax
		  __int64 v85; // xmm3_8
		  MethodInfo *v86; // r9
		  Vector3 *v87; // rax
		  __int64 v88; // xmm3_8
		  MethodInfo *v89; // r9
		  Vector3 *v90; // rax
		  __int64 v91; // xmm3_8
		  MethodInfo *v92; // r9
		  float v93; // xmm4_4
		  Vector3 *v94; // rax
		  __int64 v95; // xmm3_8
		  MethodInfo *v96; // r9
		  Vector3 *v97; // rax
		  __int64 v98; // xmm3_8
		  MethodInfo *v99; // r9
		  Vector3 *v100; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v102; // [rsp+38h] [rbp-79h] BYREF
		  Vector3 v103; // [rsp+48h] [rbp-69h] BYREF
		  Vector3 v104; // [rsp+58h] [rbp-59h] BYREF
		  Vector3 v105; // [rsp+68h] [rbp-49h] BYREF
		  Vector3 v106[10]; // [rsp+78h] [rbp-39h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1132, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1132, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		        (ILFixDynamicMethodWrapper_4 *)Patch,
		        (Object *)camera,
		        posZ,
		        (Object *)result,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v7, v6);
		  }
		  if ( !camera )
		    goto LABEL_12;
		  UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		  v12 = sub_180338A80(v9, v8, v10, v11);
		  v13 = (float)(v12 * posZ) + (float)(v12 * posZ);
		  v14 = UnityEngine::Camera::get_aspect(camera, 0LL) * v13;
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !transform )
		    goto LABEL_12;
		  right = UnityEngine::Transform::get_right(&v105, transform, 0LL);
		  v17 = *(_QWORD *)&right->x;
		  z = right->z;
		  v19 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v19 )
		    goto LABEL_12;
		  up = UnityEngine::Transform::get_up(&v105, v19, 0LL);
		  v21 = *(_QWORD *)&up->x;
		  v22 = up->z;
		  v23 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v23 )
		    goto LABEL_12;
		  forward = UnityEngine::Transform::get_forward(&v105, v23, 0LL);
		  v25 = *(_QWORD *)&forward->x;
		  v26 = forward->z;
		  v27 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v27 )
		    goto LABEL_12;
		  position = UnityEngine::Transform::get_position(&v105, v27, 0LL);
		  *(_QWORD *)&v102.x = v25;
		  v102.z = v26;
		  v29 = UnityEngine::Vector3::op_Multiply(&v104, &v102, posZ, (MethodInfo *)LODWORD(position->z));
		  *(_QWORD *)&v102.x = v17;
		  v102.z = z;
		  v30 = *(_QWORD *)&v29->x;
		  *(float *)&v29 = v29->z;
		  *(_QWORD *)&v103.x = v30;
		  LODWORD(v103.z) = (_DWORD)v29;
		  *(_QWORD *)&v104.x = v31;
		  LODWORD(v104.z) = (_DWORD)v32;
		  v33 = UnityEngine::Vector3::op_Multiply(&v105, &v102, v14, v32);
		  v34 = *(_QWORD *)&v33->x;
		  *(float *)&v33 = v33->z;
		  *(_QWORD *)&v102.x = v34;
		  LODWORD(v102.z) = (_DWORD)v33;
		  v36 = UnityEngine::Vector3::op_Multiply(&v105, &v102, 0.5, v35);
		  v37 = *(_QWORD *)&v36->x;
		  *(float *)&v36 = v36->z;
		  *(_QWORD *)&v102.x = v37;
		  LODWORD(v102.z) = (_DWORD)v36;
		  v39 = UnityEngine::Vector3::op_Addition(&v105, &v104, &v103, v38);
		  *(_QWORD *)&v104.x = v21;
		  v104.z = v22;
		  v40 = *(_QWORD *)&v39->x;
		  *(float *)&v39 = v39->z;
		  *(_QWORD *)&v103.x = v40;
		  LODWORD(v103.z) = (_DWORD)v39;
		  v42 = UnityEngine::Vector3::op_Multiply(&v105, &v104, v13, v41);
		  v43 = *(_QWORD *)&v42->x;
		  *(float *)&v42 = v42->z;
		  *(_QWORD *)&v104.x = v43;
		  LODWORD(v104.z) = (_DWORD)v42;
		  v45 = UnityEngine::Vector3::op_Multiply(&v105, &v104, 0.5, v44);
		  v46 = *(_QWORD *)&v45->x;
		  *(float *)&v45 = v45->z;
		  *(_QWORD *)&v104.x = v46;
		  LODWORD(v104.z) = (_DWORD)v45;
		  v48 = UnityEngine::Vector3::op_Subtraction(&v105, &v103, &v102, v47);
		  v49 = *(_QWORD *)&v48->x;
		  *(float *)&v48 = v48->z;
		  *(_QWORD *)&v103.x = v49;
		  LODWORD(v103.z) = (_DWORD)v48;
		  v51 = UnityEngine::Vector3::op_Subtraction(&v105, &v103, &v104, v50);
		  if ( !result )
		    goto LABEL_12;
		  if ( !result->max_length.size )
		    goto LABEL_13;
		  *(_QWORD *)&result->vector[0].x = *(_QWORD *)&v51->x;
		  result->vector[0].z = v51->z;
		  *(_QWORD *)&v104.x = v25;
		  v104.z = v26;
		  v53 = UnityEngine::Vector3::op_Multiply(&v105, &v104, posZ, v52);
		  *(_QWORD *)&v102.x = v54;
		  LODWORD(v102.z) = (_DWORD)v55;
		  *(_QWORD *)&v104.x = v17;
		  v56 = *(_QWORD *)&v53->x;
		  *(float *)&v53 = v53->z;
		  *(_QWORD *)&v103.x = v56;
		  LODWORD(v103.z) = (_DWORD)v53;
		  v104.z = z;
		  v57 = UnityEngine::Vector3::op_Multiply(&v105, &v104, v14, v55);
		  v58 = *(_QWORD *)&v57->x;
		  *(float *)&v57 = v57->z;
		  *(_QWORD *)&v104.x = v58;
		  LODWORD(v104.z) = (_DWORD)v57;
		  v60 = UnityEngine::Vector3::op_Multiply(v106, &v104, 1.5, v59);
		  v61 = *(_QWORD *)&v60->x;
		  *(float *)&v60 = v60->z;
		  *(_QWORD *)&v105.x = v61;
		  LODWORD(v105.z) = (_DWORD)v60;
		  v63 = UnityEngine::Vector3::op_Addition(v106, &v102, &v103, v62);
		  *(_QWORD *)&v104.x = v21;
		  v104.z = v22;
		  v64 = *(_QWORD *)&v63->x;
		  *(float *)&v63 = v63->z;
		  *(_QWORD *)&v103.x = v64;
		  LODWORD(v103.z) = (_DWORD)v63;
		  v66 = UnityEngine::Vector3::op_Multiply(v106, &v104, v13, v65);
		  v67 = *(_QWORD *)&v66->x;
		  *(float *)&v66 = v66->z;
		  *(_QWORD *)&v104.x = v67;
		  LODWORD(v104.z) = (_DWORD)v66;
		  v69 = UnityEngine::Vector3::op_Multiply(v106, &v104, 0.5, v68);
		  v70 = *(_QWORD *)&v69->x;
		  *(float *)&v69 = v69->z;
		  *(_QWORD *)&v104.x = v70;
		  LODWORD(v104.z) = (_DWORD)v69;
		  v72 = UnityEngine::Vector3::op_Addition(v106, &v103, &v105, v71);
		  v73 = *(_QWORD *)&v72->x;
		  *(float *)&v72 = v72->z;
		  *(_QWORD *)&v105.x = v73;
		  LODWORD(v105.z) = (_DWORD)v72;
		  v75 = UnityEngine::Vector3::op_Subtraction(v106, &v105, &v104, v74);
		  if ( result->max_length.size <= 1u )
		    goto LABEL_13;
		  *(_QWORD *)&result->vector[1].x = *(_QWORD *)&v75->x;
		  result->vector[1].z = v75->z;
		  *(_QWORD *)&v105.x = v25;
		  v105.z = v26;
		  v77 = UnityEngine::Vector3::op_Multiply(v106, &v105, posZ, v76);
		  *(_QWORD *)&v103.x = v78;
		  LODWORD(v103.z) = (_DWORD)v79;
		  *(_QWORD *)&v105.x = v17;
		  v80 = *(_QWORD *)&v77->x;
		  *(float *)&v77 = v77->z;
		  *(_QWORD *)&v104.x = v80;
		  LODWORD(v104.z) = (_DWORD)v77;
		  v105.z = z;
		  v81 = UnityEngine::Vector3::op_Multiply(v106, &v105, v14, v79);
		  v82 = *(_QWORD *)&v81->x;
		  *(float *)&v81 = v81->z;
		  *(_QWORD *)&v105.x = v82;
		  LODWORD(v105.z) = (_DWORD)v81;
		  v84 = UnityEngine::Vector3::op_Multiply(v106, &v105, 0.5, v83);
		  v85 = *(_QWORD *)&v84->x;
		  *(float *)&v84 = v84->z;
		  *(_QWORD *)&v102.x = v85;
		  LODWORD(v102.z) = (_DWORD)v84;
		  v87 = UnityEngine::Vector3::op_Addition(v106, &v103, &v104, v86);
		  *(_QWORD *)&v105.x = v21;
		  v105.z = v22;
		  v88 = *(_QWORD *)&v87->x;
		  *(float *)&v87 = v87->z;
		  *(_QWORD *)&v104.x = v88;
		  LODWORD(v104.z) = (_DWORD)v87;
		  v90 = UnityEngine::Vector3::op_Multiply(v106, &v105, v13, v89);
		  v91 = *(_QWORD *)&v90->x;
		  *(float *)&v90 = v90->z;
		  *(_QWORD *)&v105.x = v91;
		  LODWORD(v105.z) = (_DWORD)v90;
		  v94 = UnityEngine::Vector3::op_Multiply(v106, &v105, v93, v92);
		  v95 = *(_QWORD *)&v94->x;
		  *(float *)&v94 = v94->z;
		  *(_QWORD *)&v105.x = v95;
		  LODWORD(v105.z) = (_DWORD)v94;
		  v97 = UnityEngine::Vector3::op_Subtraction(v106, &v104, &v102, v96);
		  v98 = *(_QWORD *)&v97->x;
		  *(float *)&v97 = v97->z;
		  *(_QWORD *)&v104.x = v98;
		  LODWORD(v104.z) = (_DWORD)v97;
		  v100 = UnityEngine::Vector3::op_Addition(v106, &v104, &v105, v99);
		  if ( result->max_length.size <= 2u )
		LABEL_13:
		    sub_1800D2AB0(v7, v6);
		  *(_QWORD *)&result->vector[2].x = *(_QWORD *)&v100->x;
		  result->vector[2].z = v100->z;
		}
		
		public static void CalculateScreenMaterialMeshVertex(Camera camera, float posZ, Vector3[] result) {} // 0x00000001831D0D20-0x00000001831D0DB0
		// Void CalculateScreenMaterialMeshVertex(Camera, Single, Vector3[])
		void HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialMeshVertex(
		        Camera *camera,
		        float posZ,
		        Vector3__Array *result,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1130, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1130, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		        (ILFixDynamicMethodWrapper_4 *)Patch,
		        (Object *)camera,
		        posZ,
		        (Object *)result,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v7, v6);
		  }
		  if ( !camera )
		    goto LABEL_7;
		  if ( UnityEngine::Camera::get_orthographic(camera, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    HG::Rendering::Runtime::HGVFXManager::_GetOrthographicNearClipCorners(camera, posZ, result, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    HG::Rendering::Runtime::HGVFXManager::_GetPerspectiveNearClipCorners(camera, posZ, result, 0LL);
		  }
		}
		
		private static void _GetScreenNearClipRectCorners(Camera camera, float posZ, out Vector3 bottomLeft, out Vector3 bottomRight, out Vector3 topLeft, out Vector3 topRight) {
			bottomLeft = default;
			bottomRight = default;
			topLeft = default;
			topRight = default;
		} // 0x0000000189B5A1DC-0x0000000189B5A7D4
		// Void _GetScreenNearClipRectCorners(Camera, Single, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGVFXManager::_GetScreenNearClipRectCorners(
		        Camera *camera,
		        float posZ,
		        Vector3 *bottomLeft,
		        Vector3 *bottomRight,
		        Vector3 *topLeft,
		        Vector3 *topRight,
		        MethodInfo *method)
		{
		  float v10; // xmm7_4
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Transform *transform; // rax
		  Vector3 *right; // rax
		  __int64 v15; // xmm10_8
		  float z; // r15d
		  Transform *v17; // rax
		  Vector3 *up; // rax
		  __int64 v19; // xmm9_8
		  float v20; // r14d
		  Transform *v21; // rax
		  Vector3 *forward; // rax
		  __int64 v23; // xmm12_8
		  float v24; // r13d
		  Transform *v25; // rax
		  Vector3 *position; // rax
		  __int64 v27; // xmm11_8
		  float v28; // r12d
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int64 v31; // r8
		  __int64 v32; // r9
		  float orthographicSize; // xmm6_4
		  float v34; // xmm6_4
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  __int64 v37; // xmm3_8
		  MethodInfo *v38; // r9
		  Vector3 *v39; // rax
		  float v40; // xmm5_4
		  Vector3 *v41; // rax
		  __int64 v42; // xmm3_8
		  MethodInfo *v43; // r9
		  Vector3 *v44; // rax
		  __int64 v45; // xmm3_8
		  __int64 v46; // xmm4_8
		  MethodInfo *v47; // r9
		  Vector3 *v48; // rax
		  __int64 v49; // xmm3_8
		  MethodInfo *v50; // r9
		  Vector3 *v51; // rax
		  __int64 v52; // xmm3_8
		  MethodInfo *v53; // r9
		  Vector3 *v54; // rax
		  __int64 v55; // xmm3_8
		  MethodInfo *v56; // r9
		  Vector3 *v57; // rax
		  float v58; // ecx
		  MethodInfo *v59; // r9
		  float v60; // xmm5_4
		  Vector3 *v61; // rax
		  __int64 v62; // xmm3_8
		  MethodInfo *v63; // r9
		  Vector3 *v64; // rax
		  __int64 v65; // xmm4_8
		  MethodInfo *v66; // r9
		  __int64 v67; // xmm3_8
		  Vector3 *v68; // rax
		  __int64 v69; // xmm3_8
		  MethodInfo *v70; // r9
		  Vector3 *v71; // rax
		  __int64 v72; // xmm3_8
		  MethodInfo *v73; // r9
		  Vector3 *v74; // rax
		  __int64 v75; // xmm3_8
		  MethodInfo *v76; // r9
		  Vector3 *v77; // rax
		  float v78; // ecx
		  MethodInfo *v79; // r9
		  float v80; // xmm5_4
		  Vector3 *v81; // rax
		  __int64 v82; // xmm3_8
		  MethodInfo *v83; // r9
		  Vector3 *v84; // rax
		  __int64 v85; // xmm4_8
		  MethodInfo *v86; // r9
		  __int64 v87; // xmm3_8
		  Vector3 *v88; // rax
		  __int64 v89; // xmm3_8
		  MethodInfo *v90; // r9
		  MethodInfo *v91; // r9
		  Vector3 *v92; // rax
		  __int64 v93; // xmm3_8
		  MethodInfo *v94; // r9
		  Vector3 *v95; // rax
		  float v96; // edx
		  MethodInfo *v97; // r9
		  float v98; // xmm5_4
		  Vector3 *v99; // rax
		  __int64 v100; // xmm3_8
		  MethodInfo *v101; // r9
		  Vector3 *v102; // rax
		  __int64 v103; // xmm4_8
		  MethodInfo *v104; // r9
		  __int64 v105; // xmm3_8
		  Vector3 *v106; // rax
		  __int64 v107; // xmm3_8
		  MethodInfo *v108; // r9
		  Vector3 *v109; // rax
		  __int64 v110; // xmm3_8
		  MethodInfo *v111; // r9
		  Vector3 *v112; // rax
		  __int64 v113; // xmm3_8
		  MethodInfo *v114; // r9
		  Vector3 *v115; // rax
		  float v116; // edx
		  Vector3 v117; // [rsp+48h] [rbp-91h] BYREF
		  Vector3 v118; // [rsp+58h] [rbp-81h] BYREF
		  Vector3 v119; // [rsp+68h] [rbp-71h] BYREF
		  Vector3 v120[10]; // [rsp+78h] [rbp-61h] BYREF
		
		  v10 = posZ;
		  if ( IFix::WrappersManagerImpl::IsPatched(1129, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1129, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_427(
		        Patch,
		        (Object *)camera,
		        posZ,
		        bottomLeft,
		        bottomRight,
		        topLeft,
		        topRight,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(Patch, v11);
		  }
		  if ( !camera )
		    goto LABEL_12;
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !transform )
		    goto LABEL_12;
		  right = UnityEngine::Transform::get_right(&v119, transform, 0LL);
		  v15 = *(_QWORD *)&right->x;
		  z = right->z;
		  v17 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v17 )
		    goto LABEL_12;
		  up = UnityEngine::Transform::get_up(&v119, v17, 0LL);
		  v19 = *(_QWORD *)&up->x;
		  v20 = up->z;
		  v21 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v21 )
		    goto LABEL_12;
		  forward = UnityEngine::Transform::get_forward(&v119, v21, 0LL);
		  v23 = *(_QWORD *)&forward->x;
		  v24 = forward->z;
		  v25 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v25 )
		    goto LABEL_12;
		  position = UnityEngine::Transform::get_position(&v119, v25, 0LL);
		  v27 = *(_QWORD *)&position->x;
		  v28 = position->z;
		  if ( UnityEngine::Camera::get_orthographic(camera, 0LL) )
		  {
		    v10 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		    orthographicSize = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
		  }
		  else
		  {
		    UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		    orthographicSize = sub_180338A80(v30, v29, v31, v32) * posZ;
		  }
		  v34 = orthographicSize + orthographicSize;
		  UnityEngine::Camera::get_aspect(camera, 0LL);
		  *(_QWORD *)&v117.x = v23;
		  v117.z = v24;
		  v36 = UnityEngine::Vector3::op_Multiply(&v119, &v117, v10, v35);
		  *(_QWORD *)&v118.x = v27;
		  v118.z = v28;
		  v37 = *(_QWORD *)&v36->x;
		  *(float *)&v36 = v36->z;
		  *(_QWORD *)&v117.x = v37;
		  LODWORD(v117.z) = (_DWORD)v36;
		  v39 = UnityEngine::Vector3::op_Addition(v120, &v118, &v117, v38);
		  *(_QWORD *)&v118.x = v15;
		  v118.z = z;
		  v41 = UnityEngine::Vector3::op_Multiply(&v119, &v118, v40, (MethodInfo *)LODWORD(v39->z));
		  v42 = *(_QWORD *)&v41->x;
		  *(float *)&v41 = v41->z;
		  *(_QWORD *)&v118.x = v42;
		  LODWORD(v118.z) = (_DWORD)v41;
		  v44 = UnityEngine::Vector3::op_Multiply(&v119, &v118, 0.5, v43);
		  *(_QWORD *)&v118.x = v19;
		  v118.z = v20;
		  v45 = *(_QWORD *)&v44->x;
		  *(float *)&v44 = v44->z;
		  *(_QWORD *)&v117.x = v45;
		  LODWORD(v117.z) = (_DWORD)v44;
		  *(_QWORD *)&v119.x = v46;
		  LODWORD(v119.z) = (_DWORD)v47;
		  v48 = UnityEngine::Vector3::op_Multiply(v120, &v118, v34, v47);
		  v49 = *(_QWORD *)&v48->x;
		  *(float *)&v48 = v48->z;
		  *(_QWORD *)&v118.x = v49;
		  LODWORD(v118.z) = (_DWORD)v48;
		  v51 = UnityEngine::Vector3::op_Multiply(v120, &v118, 0.5, v50);
		  v52 = *(_QWORD *)&v51->x;
		  *(float *)&v51 = v51->z;
		  *(_QWORD *)&v118.x = v52;
		  LODWORD(v118.z) = (_DWORD)v51;
		  v54 = UnityEngine::Vector3::op_Subtraction(v120, &v119, &v117, v53);
		  v55 = *(_QWORD *)&v54->x;
		  *(float *)&v54 = v54->z;
		  *(_QWORD *)&v119.x = v55;
		  LODWORD(v119.z) = (_DWORD)v54;
		  v57 = UnityEngine::Vector3::op_Subtraction(v120, &v119, &v118, v56);
		  *(_QWORD *)&v119.x = v15;
		  v119.z = z;
		  v58 = v57->z;
		  *(_QWORD *)&bottomLeft->x = *(_QWORD *)&v57->x;
		  bottomLeft->z = v58;
		  v61 = UnityEngine::Vector3::op_Multiply(v120, &v119, v60, v59);
		  v62 = *(_QWORD *)&v61->x;
		  *(float *)&v61 = v61->z;
		  *(_QWORD *)&v119.x = v62;
		  LODWORD(v119.z) = (_DWORD)v61;
		  v64 = UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v63);
		  *(_QWORD *)&v117.x = v65;
		  LODWORD(v117.z) = (_DWORD)v66;
		  *(_QWORD *)&v119.x = v19;
		  v67 = *(_QWORD *)&v64->x;
		  *(float *)&v64 = v64->z;
		  *(_QWORD *)&v118.x = v67;
		  LODWORD(v118.z) = (_DWORD)v64;
		  v119.z = v20;
		  v68 = UnityEngine::Vector3::op_Multiply(v120, &v119, v34, v66);
		  v69 = *(_QWORD *)&v68->x;
		  *(float *)&v68 = v68->z;
		  *(_QWORD *)&v119.x = v69;
		  LODWORD(v119.z) = (_DWORD)v68;
		  v71 = UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v70);
		  v72 = *(_QWORD *)&v71->x;
		  *(float *)&v71 = v71->z;
		  *(_QWORD *)&v119.x = v72;
		  LODWORD(v119.z) = (_DWORD)v71;
		  v74 = UnityEngine::Vector3::op_Addition(v120, &v117, &v118, v73);
		  v75 = *(_QWORD *)&v74->x;
		  *(float *)&v74 = v74->z;
		  *(_QWORD *)&v118.x = v75;
		  LODWORD(v118.z) = (_DWORD)v74;
		  v77 = UnityEngine::Vector3::op_Subtraction(v120, &v118, &v119, v76);
		  *(_QWORD *)&v119.x = v15;
		  v119.z = z;
		  v78 = v77->z;
		  *(_QWORD *)&bottomRight->x = *(_QWORD *)&v77->x;
		  bottomRight->z = v78;
		  v81 = UnityEngine::Vector3::op_Multiply(v120, &v119, v80, v79);
		  v82 = *(_QWORD *)&v81->x;
		  *(float *)&v81 = v81->z;
		  *(_QWORD *)&v119.x = v82;
		  LODWORD(v119.z) = (_DWORD)v81;
		  v84 = UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v83);
		  *(_QWORD *)&v117.x = v85;
		  LODWORD(v117.z) = (_DWORD)v86;
		  *(_QWORD *)&v119.x = v19;
		  v87 = *(_QWORD *)&v84->x;
		  *(float *)&v84 = v84->z;
		  *(_QWORD *)&v118.x = v87;
		  LODWORD(v118.z) = (_DWORD)v84;
		  v119.z = v20;
		  v88 = UnityEngine::Vector3::op_Multiply(v120, &v119, v34, v86);
		  v89 = *(_QWORD *)&v88->x;
		  *(float *)&v88 = v88->z;
		  *(_QWORD *)&v119.x = v89;
		  LODWORD(v119.z) = (_DWORD)v88;
		  v119 = *UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v90);
		  v92 = UnityEngine::Vector3::op_Subtraction(v120, &v117, &v118, v91);
		  v93 = *(_QWORD *)&v92->x;
		  *(float *)&v92 = v92->z;
		  *(_QWORD *)&v118.x = v93;
		  LODWORD(v118.z) = (_DWORD)v92;
		  v95 = UnityEngine::Vector3::op_Addition(v120, &v118, &v119, v94);
		  *(_QWORD *)&v119.x = v15;
		  v119.z = z;
		  v96 = v95->z;
		  *(_QWORD *)&topLeft->x = *(_QWORD *)&v95->x;
		  topLeft->z = v96;
		  v99 = UnityEngine::Vector3::op_Multiply(v120, &v119, v98, v97);
		  v100 = *(_QWORD *)&v99->x;
		  *(float *)&v99 = v99->z;
		  *(_QWORD *)&v119.x = v100;
		  LODWORD(v119.z) = (_DWORD)v99;
		  v102 = UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v101);
		  *(_QWORD *)&v117.x = v103;
		  LODWORD(v117.z) = (_DWORD)v104;
		  *(_QWORD *)&v119.x = v19;
		  v105 = *(_QWORD *)&v102->x;
		  *(float *)&v102 = v102->z;
		  *(_QWORD *)&v118.x = v105;
		  LODWORD(v118.z) = (_DWORD)v102;
		  v119.z = v20;
		  v106 = UnityEngine::Vector3::op_Multiply(v120, &v119, v34, v104);
		  v107 = *(_QWORD *)&v106->x;
		  *(float *)&v106 = v106->z;
		  *(_QWORD *)&v119.x = v107;
		  LODWORD(v119.z) = (_DWORD)v106;
		  v109 = UnityEngine::Vector3::op_Multiply(v120, &v119, 0.5, v108);
		  v110 = *(_QWORD *)&v109->x;
		  *(float *)&v109 = v109->z;
		  *(_QWORD *)&v119.x = v110;
		  LODWORD(v119.z) = (_DWORD)v109;
		  v112 = UnityEngine::Vector3::op_Addition(v120, &v117, &v118, v111);
		  v113 = *(_QWORD *)&v112->x;
		  *(float *)&v112 = v112->z;
		  *(_QWORD *)&v118.x = v113;
		  LODWORD(v118.z) = (_DWORD)v112;
		  v115 = UnityEngine::Vector3::op_Addition(v120, &v118, &v119, v114);
		  v116 = v115->z;
		  *(_QWORD *)&topRight->x = *(_QWORD *)&v115->x;
		  topRight->z = v116;
		}
		
		public static void CalculateScreenMaterialGridCellMeshVertex(Camera camera, float posZ, bool[] mask, Vector3[] result) {} // 0x0000000189B592E4-0x0000000189B597D8
		// Void CalculateScreenMaterialGridCellMeshVertex(Camera, Single, Boolean[], Vector3[])
		void HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialGridCellMeshVertex(
		        Camera *camera,
		        float posZ,
		        Boolean__Array *mask,
		        Vector3__Array *result,
		        MethodInfo *method)
		{
		  int v8; // r13d
		  float z; // eax
		  int v10; // r8d
		  int v11; // r12d
		  float v12; // eax
		  unsigned int v13; // edx
		  unsigned int v14; // edi
		  int v15; // esi
		  __int64 v16; // rax
		  __int64 v17; // xmm11_8
		  __int64 v18; // rax
		  __int64 v19; // xmm6_8
		  int v20; // ebx
		  __int64 v21; // rax
		  __int64 v22; // xmm12_8
		  __int64 v23; // rax
		  __int64 v24; // xmm10_8
		  __int64 v25; // r9
		  __int64 v26; // r10
		  __int64 v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // xmm0_8
		  __int64 v31; // rax
		  __int64 v32; // xmm4_8
		  __int64 v33; // rax
		  __int64 v34; // xmm4_8
		  __int64 v35; // rax
		  __int64 v36; // xmm4_8
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // xmm6_8
		  int v40; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int v42; // [rsp+48h] [rbp-C0h]
		  int v43; // [rsp+4Ch] [rbp-BCh]
		  __int64 v44; // [rsp+50h] [rbp-B8h]
		  Vector3 bottomRight; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 bottomLeft; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 topRight; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 topLeft; // [rsp+88h] [rbp-80h] BYREF
		  int v49; // [rsp+98h] [rbp-70h]
		  int v50; // [rsp+9Ch] [rbp-6Ch]
		  Vector3 v51; // [rsp+A8h] [rbp-60h] BYREF
		  __int64 v52; // [rsp+B8h] [rbp-50h] BYREF
		  float v53; // [rsp+C0h] [rbp-48h]
		  Vector3 v54; // [rsp+C8h] [rbp-40h] BYREF
		  __int64 v55; // [rsp+D8h] [rbp-30h] BYREF
		  float v56; // [rsp+E0h] [rbp-28h]
		  __int64 v57; // [rsp+E8h] [rbp-20h] BYREF
		  int v58; // [rsp+F0h] [rbp-18h]
		  __int64 v59; // [rsp+F8h] [rbp-10h] BYREF
		  int v60; // [rsp+100h] [rbp-8h]
		  __int64 v61; // [rsp+108h] [rbp+0h] BYREF
		  int v62; // [rsp+110h] [rbp+8h]
		  __int64 v63; // [rsp+118h] [rbp+10h] BYREF
		  int v64; // [rsp+120h] [rbp+18h]
		  __int64 v65; // [rsp+128h] [rbp+20h] BYREF
		  int v66; // [rsp+130h] [rbp+28h]
		  __int64 v67; // [rsp+138h] [rbp+30h] BYREF
		  int v68; // [rsp+140h] [rbp+38h]
		  __int64 v69; // [rsp+148h] [rbp+40h] BYREF
		  int v70; // [rsp+150h] [rbp+48h]
		  __int64 v71; // [rsp+158h] [rbp+50h] BYREF
		  int v72; // [rsp+160h] [rbp+58h]
		  __int64 v73; // [rsp+168h] [rbp+60h] BYREF
		  int v74; // [rsp+170h] [rbp+68h]
		  __int64 v75; // [rsp+178h] [rbp+70h] BYREF
		  int v76; // [rsp+180h] [rbp+78h]
		  __int64 v77; // [rsp+188h] [rbp+80h] BYREF
		  int v78; // [rsp+190h] [rbp+88h]
		  __int64 v79; // [rsp+198h] [rbp+90h] BYREF
		  int v80; // [rsp+1A0h] [rbp+98h]
		  __int64 v81; // [rsp+1A8h] [rbp+A0h] BYREF
		  int v82; // [rsp+1B0h] [rbp+A8h]
		  __int64 v83; // [rsp+1B8h] [rbp+B0h] BYREF
		  int v84; // [rsp+1C0h] [rbp+B8h]
		  __int64 v85; // [rsp+1C8h] [rbp+C0h] BYREF
		  int v86; // [rsp+1D0h] [rbp+C8h]
		  __int64 v87; // [rsp+1D8h] [rbp+D0h] BYREF
		  int v88; // [rsp+1E0h] [rbp+D8h]
		  _BYTE v89[16]; // [rsp+1E8h] [rbp+E0h] BYREF
		  _BYTE v90[16]; // [rsp+1F8h] [rbp+F0h] BYREF
		  _BYTE v91[16]; // [rsp+208h] [rbp+100h] BYREF
		  _BYTE v92[16]; // [rsp+218h] [rbp+110h] BYREF
		  _BYTE v93[16]; // [rsp+228h] [rbp+120h] BYREF
		  _BYTE v94[16]; // [rsp+238h] [rbp+130h] BYREF
		  _BYTE v95[16]; // [rsp+248h] [rbp+140h] BYREF
		  _BYTE v96[112]; // [rsp+258h] [rbp+150h] BYREF
		
		  *(_QWORD *)&bottomLeft.x = 0LL;
		  bottomLeft.z = 0.0;
		  *(_QWORD *)&bottomRight.x = 0LL;
		  bottomRight.z = 0.0;
		  *(_QWORD *)&topLeft.x = 0LL;
		  topLeft.z = 0.0;
		  *(_QWORD *)&topRight.x = 0LL;
		  topRight.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1128, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1128, 0LL);
		    if ( !Patch )
		LABEL_15:
		      sub_1800D8260(v29, v28);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_109(
		      (ILFixDynamicMethodWrapper_10 *)Patch,
		      (Object *)camera,
		      posZ,
		      (Object *)mask,
		      (Object *)result,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    HG::Rendering::Runtime::HGVFXManager::_GetScreenNearClipRectCorners(
		      camera,
		      posZ,
		      &bottomLeft,
		      &bottomRight,
		      &topLeft,
		      &topRight,
		      0LL);
		    v8 = 0;
		    z = bottomLeft.z;
		    v51 = bottomRight;
		    v10 = 2;
		    bottomLeft.z = bottomRight.z;
		    v11 = 1;
		    bottomRight.z = z;
		    v53 = z;
		    v12 = topLeft.z;
		    v54 = topRight;
		    topLeft.z = topRight.z;
		    v13 = 0;
		    *(_QWORD *)&bottomRight.x = *(_QWORD *)&bottomLeft.x;
		    *(_QWORD *)&bottomLeft.x = *(_QWORD *)&v51.x;
		    v52 = *(_QWORD *)&bottomRight.x;
		    v44 = 0LL;
		    *(_QWORD *)&topRight.x = *(_QWORD *)&topLeft.x;
		    topRight.z = v12;
		    *(_QWORD *)&topLeft.x = *(_QWORD *)&v54.x;
		    v55 = *(_QWORD *)&topRight.x;
		    v56 = v12;
		    v43 = 2;
		    do
		    {
		      v14 = v13;
		      v15 = v10;
		      do
		      {
		        v16 = sub_183276430(v89, &bottomRight, &v51);
		        v17 = *(_QWORD *)v16;
		        v50 = *(_DWORD *)(v16 + 8);
		        v18 = sub_183276430(v90, &v52, &bottomLeft);
		        v19 = *(_QWORD *)v18;
		        v20 = *(_DWORD *)(v18 + 8);
		        v21 = sub_183276430(v91, &topRight, &v54);
		        v22 = *(_QWORD *)v21;
		        v49 = *(_DWORD *)(v21 + 8);
		        v23 = sub_183276430(v92, &v55, &topLeft);
		        v57 = v22;
		        v59 = v17;
		        v24 = *(_QWORD *)v23;
		        v42 = *(_DWORD *)(v23 + 8);
		        v58 = *(_DWORD *)(v25 + 8);
		        v60 = *(_DWORD *)(v26 + 8);
		        v27 = sub_183276430(v93, &v59, &v57);
		        if ( !result )
		          goto LABEL_15;
		        v30 = *(_QWORD *)v27;
		        v62 = *(_DWORD *)(v27 + 8);
		        v61 = v30;
		        sub_180049BD0(result, v15 - 2, &v61);
		        v64 = v49;
		        v66 = v50;
		        v63 = v22;
		        v65 = v17;
		        v31 = sub_183276430(v94, &v65, &v63);
		        v32 = *(_QWORD *)v31;
		        v68 = *(_DWORD *)(v31 + 8);
		        v67 = v32;
		        sub_180049BD0(result, v15 - 1, &v67);
		        v70 = v42;
		        v69 = v24;
		        v71 = v19;
		        v72 = v20;
		        v33 = sub_183276430(v95, &v71, &v69);
		        v34 = *(_QWORD *)v33;
		        LODWORD(v33) = *(_DWORD *)(v33 + 8);
		        v73 = v34;
		        v74 = v33;
		        sub_180049BD0(result, v15, &v73);
		        v76 = v42;
		        v75 = v24;
		        v77 = v19;
		        v78 = v20;
		        v35 = sub_183276430(v96, &v77, &v75);
		        v36 = *(_QWORD *)v35;
		        v80 = *(_DWORD *)(v35 + 8);
		        v79 = v36;
		        sub_180049BD0(result, v15 + 1, &v79);
		        if ( mask && mask->max_length.size == 36 )
		        {
		          if ( v14 >= mask->max_length.size )
		            sub_1800D2AB0(v38, v37);
		          if ( !mask->vector[v14] )
		          {
		            sub_180049C60(result, &v81, v15 - 2);
		            v39 = v81;
		            v40 = v82;
		            v83 = v81;
		            v84 = v82;
		            sub_180049BD0(result, v15 - 1, &v83);
		            v85 = v39;
		            v86 = v40;
		            sub_180049BD0(result, v15, &v85);
		            v87 = v39;
		            v88 = v40;
		            sub_180049BD0(result, v15 + 1, &v87);
		          }
		        }
		        ++v14;
		        v15 += 4;
		      }
		      while ( (int)(HIDWORD(v44) + v14) < 6 );
		      v10 = v43 + 24;
		      v13 = v44 + 6;
		      v43 += 24;
		      ++v8;
		      LODWORD(v44) = v44 + 6;
		      v11 -= 6;
		      HIDWORD(v44) -= 6;
		    }
		    while ( v11 > -35 );
		  }
		}
		
		public void RegisterRect(EffectOcclusionRect rect) {} // 0x0000000189B59978-0x0000000189B599E8
		// Void RegisterRect(EffectOcclusionRect)
		void HG::Rendering::Runtime::HGVFXManager::RegisterRect(
		        HGVFXManager *this,
		        EffectOcclusionRect *rect,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_EffectOcclusionRect_ *m_allRects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2412, 0LL) )
		  {
		    m_allRects = this->fields.m_allRects;
		    if ( m_allRects )
		    {
		      System::Collections::Generic::HashSet<System::Object>::Add(
		        (HashSet_1_System_Object_ *)m_allRects,
		        (Object *)rect,
		        MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionRect>::Add);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_allRects, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2412, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)rect,
		    0LL);
		}
		
		public void UnregisterRect(EffectOcclusionRect rect) {} // 0x0000000189B59C10-0x0000000189B59C80
		// Void UnregisterRect(EffectOcclusionRect)
		void HG::Rendering::Runtime::HGVFXManager::UnregisterRect(
		        HGVFXManager *this,
		        EffectOcclusionRect *rect,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_EffectOcclusionRect_ *m_allRects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2413, 0LL) )
		  {
		    m_allRects = this->fields.m_allRects;
		    if ( m_allRects )
		    {
		      System::Collections::Generic::HashSet<System::Object>::Remove(
		        (HashSet_1_System_Object_ *)m_allRects,
		        (Object *)rect,
		        MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionRect>::Remove);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_allRects, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2413, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)rect,
		    0LL);
		}
		
		public void RegisterCircle(EffectOcclusionCircle effectOcclusionCircle) {} // 0x0000000189B59908-0x0000000189B59978
		// Void RegisterCircle(EffectOcclusionCircle)
		void HG::Rendering::Runtime::HGVFXManager::RegisterCircle(
		        HGVFXManager *this,
		        EffectOcclusionCircle *effectOcclusionCircle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_EffectOcclusionCircle_ *m_allCircles; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2414, 0LL) )
		  {
		    m_allCircles = this->fields.m_allCircles;
		    if ( m_allCircles )
		    {
		      System::Collections::Generic::HashSet<System::Object>::Add(
		        (HashSet_1_System_Object_ *)m_allCircles,
		        (Object *)effectOcclusionCircle,
		        MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionCircle>::Add);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_allCircles, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2414, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)effectOcclusionCircle,
		    0LL);
		}
		
		public void UnregisterCircle(EffectOcclusionCircle effectOcclusionCircle) {} // 0x0000000189B59BA0-0x0000000189B59C10
		// Void UnregisterCircle(EffectOcclusionCircle)
		void HG::Rendering::Runtime::HGVFXManager::UnregisterCircle(
		        HGVFXManager *this,
		        EffectOcclusionCircle *effectOcclusionCircle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_EffectOcclusionCircle_ *m_allCircles; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2415, 0LL) )
		  {
		    m_allCircles = this->fields.m_allCircles;
		    if ( m_allCircles )
		    {
		      System::Collections::Generic::HashSet<System::Object>::Remove(
		        (HashSet_1_System_Object_ *)m_allCircles,
		        (Object *)effectOcclusionCircle,
		        MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionCircle>::Remove);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_allCircles, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2415, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)effectOcclusionCircle,
		    0LL);
		}
		
		private void _UpdateAllCircles() {} // 0x00000001831C87A0-0x00000001831C8990
		// Void _UpdateAllCircles()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGVFXManager::_UpdateAllCircles(HGVFXManager *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HashSet_1_EffectOcclusionCircle_ *m_allCircles; // rbx
		  EffectOcclusionCircle *v12; // rbx
		  struct Object_1__Class *v13; // rcx
		  MethodInfo *v14; // [rsp+20h] [rbp-48h] BYREF
		  _BYTE v15[64]; // [rsp+28h] [rbp-40h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, method);
		  if ( wrapperArray->max_length.size <= 2333 )
		    goto LABEL_13;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v5->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v5, method);
		  if ( v7->max_length.size <= 0x91Du )
		    sub_1800D2AB0(v5, method);
		  if ( v7[64].vector[29] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2333, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    m_allCircles = this->fields.m_allCircles;
		    if ( !m_allCircles )
		      sub_1800D8260(v5, method);
		    *(_OWORD *)&v15[8] = 0LL;
		    *(_QWORD *)v15 = m_allCircles;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)v15, (HGRuntimeGrassQuery_Node *)method, v2, v3, v14);
		    *(_DWORD *)&v15[8] = 0;
		    *(_DWORD *)&v15[12] = m_allCircles->fields._version;
		    *(_QWORD *)&v15[16] = 0LL;
		    *(_OWORD *)&v15[24] = *(_OWORD *)v15;
		    *(_QWORD *)&v15[40] = 0LL;
		    *(_QWORD *)v15 = 0LL;
		    *(_QWORD *)&v15[8] = &v15[24];
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		                (HashSet_1_T_Enumerator_System_Object_ *)&v15[24],
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<EffectOcclusionCircle>::MoveNext) )
		      {
		        v12 = *(EffectOcclusionCircle **)&v15[40];
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
		        if ( v12 )
		        {
		          if ( !v13->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v13);
		          if ( v12->fields._._._._.m_CachedPtr && UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)v12, 0LL) )
		            HG::Rendering::Runtime::HGVFXManager::_UpdateOcclusionForCircle(this, v12, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      *(_QWORD *)v15 = v14->methodPointer;
		      if ( *(_QWORD *)v15 )
		        sub_18007E1E0(*(_QWORD *)v15);
		    }
		  }
		}
		
		private void _UpdateOcclusionForCircle(EffectOcclusionCircle circle) {} // 0x0000000189B5ABA4-0x0000000189B5B08C
		// Void _UpdateOcclusionForCircle(EffectOcclusionCircle)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::HGVFXManager::_UpdateOcclusionForCircle(
		        HGVFXManager *this,
		        EffectOcclusionCircle *circle,
		        MethodInfo *method)
		{
		  HashSet_1_System_UInt64_ *m_allRects; // rdx
		  List_1_EffectOcclusionRect_ *m_tempList; // rcx
		  Vector2 Center; // xmm6_8
		  float m_radius; // xmm7_4
		  Object *current; // r14
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  List_1_System_Object_ *v13; // rcx
		  List_1_EffectOcclusionRect_ *v14; // rax
		  List_1_EffectOcclusionRect_ *v15; // rax
		  int32_t size; // r12d
		  int32_t v17; // r14d
		  ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4___Array *m_tempShaderData; // r15
		  Object *Item; // rax
		  ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *ShaderData; // rax
		  __int64 v21; // r8
		  MaterialPropertyBlock *m_propertyBlock; // r13
		  List_1_System_ValueTuple_2_UnityEngine_Renderer_Int32_ *m_rendererSlots; // r15
		  int v24; // r14d
		  int v25; // r8d
		  __m128i v26; // xmm6
		  List_1_UnityEngine_HGDecalProjector_ *m_decalSlots; // r14
		  unsigned int v28; // esi
		  int v29; // r15d
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  HGDecalProjector *v32; // r15
		  Material *material; // r15
		  List_1_UnityEngine_Material_ *m_materials; // r14
		  unsigned int v35; // esi
		  int v36; // r15d
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  Material *v39; // r15
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ v41; // [rsp+38h] [rbp-90h] BYREF
		  HashSet_1_T_Enumerator_System_Object_ v42; // [rsp+68h] [rbp-60h] BYREF
		  int i; // [rsp+E8h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2334, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2334, 0LL);
		    if ( !Patch )
		      goto LABEL_46;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)circle,
		      0LL);
		  }
		  else
		  {
		    if ( !circle )
		      goto LABEL_46;
		    Center = EffectOcclusionRect::get_Center((EffectOcclusionRect *)circle, 0LL);
		    m_radius = circle->fields.m_radius;
		    m_tempList = this->fields.m_tempList;
		    if ( !m_tempList )
		      goto LABEL_46;
		    sub_183127A90(m_tempList, MethodInfo::System::Collections::Generic::List<EffectOcclusionRect>::Clear);
		    m_allRects = (HashSet_1_System_UInt64_ *)this->fields.m_allRects;
		    if ( !m_allRects )
		      goto LABEL_46;
		    System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
		      (HashSet_1_T_Enumerator_System_UInt64_ *)&v41,
		      m_allRects,
		      MethodInfo::System::Collections::Generic::HashSet<EffectOcclusionRect>::GetEnumerator);
		    *(Vector4 *)&v42._set = v41.Item1;
		    v42._current = *(Object **)&v41.Item2.x;
		    *(_QWORD *)&v41.Item1.x = 0LL;
		    *(_QWORD *)&v41.Item1.z = &v42;
		    while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		              &v42,
		              MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<EffectOcclusionRect>::MoveNext) )
		    {
		      current = v42._current;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality((Object_1 *)current, 0LL, 0LL) )
		      {
		        if ( !current )
		          sub_1800D8250(v11, v10);
		        if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)current, 0LL)
		          && EffectOcclusionRect::IntersectsCircle((EffectOcclusionRect *)current, Center, m_radius, 0LL) )
		        {
		          v13 = (List_1_System_Object_ *)this->fields.m_tempList;
		          if ( !v13 )
		            sub_1800D8250(0LL, v12);
		          sub_182F01190(v13, current);
		          v14 = this->fields.m_tempList;
		          if ( !v14 )
		            sub_1800D8250(m_tempList, m_allRects);
		          if ( v14->fields._size >= 4 )
		            break;
		        }
		      }
		    }
		    v15 = this->fields.m_tempList;
		    if ( !v15 )
		      goto LABEL_46;
		    size = v15->fields._size;
		    v17 = 0;
		    if ( size > 0 )
		    {
		      do
		      {
		        m_tempShaderData = this->fields.m_tempShaderData;
		        m_tempList = this->fields.m_tempList;
		        if ( !m_tempList )
		          goto LABEL_46;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)m_tempList,
		                 v17,
		                 MethodInfo::System::Collections::Generic::List<EffectOcclusionRect>::get_Item);
		        if ( !Item )
		          goto LABEL_46;
		        ShaderData = EffectOcclusionRect::GetShaderData(&v41, (EffectOcclusionRect *)Item, Center, 0LL);
		        if ( !m_tempShaderData )
		          goto LABEL_46;
		        if ( (unsigned int)v17 >= m_tempShaderData->max_length.size )
		          sub_1800D2AA0(m_tempList, m_allRects, v21);
		        m_tempList = (List_1_EffectOcclusionRect_ *)v17;
		        m_allRects = (HashSet_1_System_UInt64_ *)(6LL * v17);
		        *(Vector4 *)((char *)&m_tempShaderData->vector[0].Item1 + 8 * (_QWORD)m_allRects) = ShaderData->Item1;
		        *(Vector4 *)((char *)&m_tempShaderData->vector[0].Item2 + 8 * (_QWORD)m_allRects) = ShaderData->Item2;
		        *(Vector4 *)((char *)&m_tempShaderData->vector[0].Item3 + 8 * (_QWORD)m_allRects) = ShaderData->Item3;
		      }
		      while ( ++v17 < size );
		    }
		    if ( circle->fields.m_useInstantiatedMaterials )
		    {
		      m_materials = circle->fields.m_materials;
		      v35 = 0;
		      v36 = 0;
		      if ( !m_materials )
		        goto LABEL_46;
		      while ( v36 < (int)sub_1800320D0(
		                           0LL,
		                           TypeInfo::System::Collections::Generic::IReadOnlyCollection<UnityEngine::Material>,
		                           m_materials) )
		      {
		        v39 = (Material *)sub_18026AB20(v38, v37, m_materials, v35);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( !UnityEngine::Object::op_Equality((Object_1 *)v39, 0LL, 0LL) )
		          HG::Rendering::Runtime::HGVFXManager::_SetMaterialData(this, v39, this->fields.m_tempShaderData, size, 0LL);
		        v36 = ++v35;
		      }
		    }
		    else
		    {
		      m_propertyBlock = circle->fields.m_propertyBlock;
		      m_rendererSlots = circle->fields.m_rendererSlots;
		      if ( m_propertyBlock )
		      {
		        if ( !m_rendererSlots )
		          goto LABEL_46;
		        if ( (int)sub_1800320D0(
		                    0LL,
		                    TypeInfo::System::Collections::Generic::IReadOnlyCollection<System::ValueTuple<UnityEngine::Renderer,int>>,
		                    circle->fields.m_rendererSlots) > 0 )
		        {
		          HG::Rendering::Runtime::HGVFXManager::_SetPropertyBlockData(
		            this,
		            m_propertyBlock,
		            this->fields.m_tempShaderData,
		            size,
		            0LL);
		          v24 = 0;
		          for ( i = 0;
		                i < (int)sub_1800320D0(
		                           0LL,
		                           TypeInfo::System::Collections::Generic::IReadOnlyCollection<System::ValueTuple<UnityEngine::Renderer,int>>,
		                           m_rendererSlots);
		                i = v24 )
		          {
		            v26 = *(__m128i *)sub_18026ABD0((unsigned int)&v41, (_DWORD)m_allRects, v25, (_DWORD)m_rendererSlots, v24);
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Inequality((Object_1 *)v26.m128i_i64[0], 0LL, 0LL) )
		            {
		              m_tempList = (List_1_EffectOcclusionRect_ *)v26.m128i_i64[0];
		              if ( !v26.m128i_i64[0] )
		                goto LABEL_46;
		              UnityEngine::Renderer::Internal_SetPropertyBlockMaterialIndex(
		                (Renderer *)v26.m128i_i64[0],
		                m_propertyBlock,
		                _mm_cvtsi128_si32(_mm_srli_si128(v26, 8)),
		                0LL);
		            }
		            ++v24;
		          }
		        }
		      }
		      m_decalSlots = circle->fields.m_decalSlots;
		      v28 = 0;
		      v29 = 0;
		      if ( !m_decalSlots )
		LABEL_46:
		        sub_1800D8250(m_tempList, m_allRects);
		      while ( v29 < (int)sub_1800320D0(
		                           0LL,
		                           TypeInfo::System::Collections::Generic::IReadOnlyCollection<UnityEngine::HGDecalProjector>,
		                           m_decalSlots) )
		      {
		        v32 = (HGDecalProjector *)sub_18026AA70(v31, v30, m_decalSlots, v28);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality((Object_1 *)v32, 0LL, 0LL) )
		        {
		          if ( !v32 )
		            goto LABEL_46;
		          material = UnityEngine::HGDecalProjector::get_material(v32, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality((Object_1 *)material, 0LL, 0LL) )
		            HG::Rendering::Runtime::HGVFXManager::_SetMaterialData(
		              this,
		              material,
		              this->fields.m_tempShaderData,
		              size,
		              0LL);
		        }
		        v29 = ++v28;
		      }
		    }
		  }
		}
		
		private void _SetMaterialData(Material material, [TupleElementNames(new string[3] {"rectData", "dataVec", "rotVec" })] ValueTuple<Vector4, Vector4, Vector4>[] shaderDataList, int count) {} // 0x0000000189B5A7D4-0x0000000189B5A9BC
		// Void _SetMaterialData(Material, ValueTuple`3[UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4][], Int32)
		void HG::Rendering::Runtime::HGVFXManager::_SetMaterialData(
		        HGVFXManager *this,
		        Material *material,
		        ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4___Array *shaderDataList,
		        int32_t count,
		        MethodInfo *method)
		{
		  int32_t v9; // edi
		  HGVFXManager__StaticFields *static_fields; // rcx
		  Int32__Array *RectIds; // rdx
		  int32_t v12; // ebx
		  Vector4 *v13; // rax
		  Int32__Array *DataIds; // rbx
		  int32_t v15; // ebx
		  Int32__Array *RotIds; // rbx
		  int32_t v17; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v19; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2335, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2335, 0LL);
		    if ( !Patch )
		      goto LABEL_16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(
		      (ILFixDynamicMethodWrapper_14 *)Patch,
		      (Object *)this,
		      (Object *)material,
		      (Object *)shaderDataList,
		      (LogType__Enum)count,
		      0LL);
		  }
		  else
		  {
		    v9 = 0;
		    if ( count > 0 )
		    {
		      while ( 1 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        RectIds = static_fields->_RectIds;
		        if ( !static_fields->_RectIds )
		          break;
		        if ( (unsigned int)v9 >= RectIds->max_length.size )
		          goto LABEL_14;
		        v12 = RectIds->vector[v9];
		        if ( !shaderDataList )
		          break;
		        v13 = (Vector4 *)sub_18047F748(shaderDataList, v9);
		        if ( !material )
		          break;
		        v19 = *v13;
		        UnityEngine::Material::SetVector(material, v12, &v19, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        DataIds = static_fields->_DataIds;
		        if ( !DataIds )
		          break;
		        if ( (unsigned int)v9 >= DataIds->max_length.size )
		          goto LABEL_14;
		        v15 = DataIds->vector[v9];
		        v19 = *(Vector4 *)(sub_18047F748(shaderDataList, v9) + 16);
		        UnityEngine::Material::SetVector(material, v15, &v19, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        RotIds = static_fields->_RotIds;
		        if ( !RotIds )
		          break;
		        if ( (unsigned int)v9 >= RotIds->max_length.size )
		LABEL_14:
		          sub_1800D2AB0(static_fields, RectIds);
		        v17 = RotIds->vector[v9];
		        v19 = *(Vector4 *)(sub_18047F748(shaderDataList, v9) + 32);
		        UnityEngine::Material::SetVector(material, v17, &v19, 0LL);
		        if ( ++v9 >= count )
		          goto LABEL_12;
		      }
		LABEL_16:
		      sub_1800D8260(static_fields, RectIds);
		    }
		LABEL_12:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		    if ( !material )
		      goto LABEL_16;
		    UnityEngine::Material::SetFloatImpl(material, static_fields->COUNT_ID, (float)count, 0LL);
		  }
		}
		
		private void _SetPropertyBlockData(MaterialPropertyBlock propertyBlock, [TupleElementNames(new string[3] {"rectData", "dataVec", "rotVec" })] ValueTuple<Vector4, Vector4, Vector4>[] shaderDataList, int count) {} // 0x0000000189B5A9BC-0x0000000189B5ABA4
		// Void _SetPropertyBlockData(MaterialPropertyBlock, ValueTuple`3[UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4][], Int32)
		void HG::Rendering::Runtime::HGVFXManager::_SetPropertyBlockData(
		        HGVFXManager *this,
		        MaterialPropertyBlock *propertyBlock,
		        ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4___Array *shaderDataList,
		        int32_t count,
		        MethodInfo *method)
		{
		  int32_t v9; // edi
		  HGVFXManager__StaticFields *static_fields; // rcx
		  Int32__Array *RectIds; // rdx
		  int32_t v12; // ebx
		  Vector4 *v13; // rax
		  Int32__Array *DataIds; // rbx
		  int32_t v15; // ebx
		  Int32__Array *RotIds; // rbx
		  int32_t v17; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v19; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2336, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2336, 0LL);
		    if ( !Patch )
		      goto LABEL_16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(
		      (ILFixDynamicMethodWrapper_14 *)Patch,
		      (Object *)this,
		      (Object *)propertyBlock,
		      (Object *)shaderDataList,
		      (LogType__Enum)count,
		      0LL);
		  }
		  else
		  {
		    v9 = 0;
		    if ( count > 0 )
		    {
		      while ( 1 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        RectIds = static_fields->_RectIds;
		        if ( !static_fields->_RectIds )
		          break;
		        if ( (unsigned int)v9 >= RectIds->max_length.size )
		          goto LABEL_14;
		        v12 = RectIds->vector[v9];
		        if ( !shaderDataList )
		          break;
		        v13 = (Vector4 *)sub_18047F748(shaderDataList, v9);
		        if ( !propertyBlock )
		          break;
		        v19 = *v13;
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v12, &v19, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        DataIds = static_fields->_DataIds;
		        if ( !DataIds )
		          break;
		        if ( (unsigned int)v9 >= DataIds->max_length.size )
		          goto LABEL_14;
		        v15 = DataIds->vector[v9];
		        v19 = *(Vector4 *)(sub_18047F748(shaderDataList, v9) + 16);
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v15, &v19, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		        RotIds = static_fields->_RotIds;
		        if ( !RotIds )
		          break;
		        if ( (unsigned int)v9 >= RotIds->max_length.size )
		LABEL_14:
		          sub_1800D2AB0(static_fields, RectIds);
		        v17 = RotIds->vector[v9];
		        v19 = *(Vector4 *)(sub_18047F748(shaderDataList, v9) + 32);
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v17, &v19, 0LL);
		        if ( ++v9 >= count )
		          goto LABEL_12;
		      }
		LABEL_16:
		      sub_1800D8260(static_fields, RectIds);
		    }
		LABEL_12:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGVFXManager->static_fields;
		    if ( !propertyBlock )
		      goto LABEL_16;
		    UnityEngine::MaterialPropertyBlock::SetFloatImpl(propertyBlock, static_fields->COUNT_ID, (float)count, 0LL);
		  }
		}
		
	}
}
