using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathBase : IRenderGraphCallbackOwner // TypeDefIndex: 38519
	{
		// Fields
		private HGCamera m_trackingCamera; // 0x48
		private bool m_trackingBackBufferState; // 0x50
		private static int s_createdCount; // 0x00
		private BasicTransformConstants m_basicTransformConstants; // 0x60
		private ShaderVariablesGlobal m_shaderVariablesGlobal; // 0x580
		private UIShaderVariablesGlobal m_uiShaderVariableGlobal; // 0x1200
		private List<IPassConstructor> m_passConstructors; // 0x1248
		private NativeArray<int> m_passConstructorMapping; // 0x1250
		internal HGRenderPipelineMaterialCollector m_materialCollector; // 0x1260
	
		// Properties
		private TextureHandle intermediateBackBuffer { get; set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
		// Guid get_Item1()
		Guid *System::Tuple<System::Guid,System::Object>::get_Item1(
		        Guid *__return_ptr retstr,
		        Tuple_2_Guid_Object_ *this,
		        MethodInfo *method)
		{
		  Guid *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_Item1;
		  return result;
		}
		

		// Void set_value(Vector4)
		void ParadoxNotion::EventData<UnityEngine::Vector4>::set_value(
		        EventData_1_UnityEngine_Vector4_ *this,
		        Vector4 *value,
		        MethodInfo *method)
		{
		  this->_value_k__BackingField = *value;
		}
		
		protected TextureHandle backBufferColor { get; private set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
		// ValueTuple`2[Object,Int32] get_Current()
		ValueTuple_2_Object_Int32_ *System::Collections::Generic::SortedList_2_TKey_TValue_::SortedListValueEnumerator<int,System::ValueTuple<System::Object,int>>::get_Current(
		        ValueTuple_2_Object_Int32_ *__return_ptr retstr,
		        SortedList_2_TKey_TValue_SortedListValueEnumerator_System_Int32_System_ValueTuple_2_Object_Int32_ *this,
		        MethodInfo *method)
		{
		  ValueTuple_2_Object_Int32_ *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._currentValue;
		  return result;
		}
		

		// Void set_color(Color)
		void UnityEngine::Tilemaps::Tile::set_color(Tile *this, Color *value, MethodInfo *method)
		{
		  this->fields.m_Color = *value;
		}
		
		protected TextureHandle backBufferDepth { get; private set; } // 0x0000000184D87480-0x0000000184D87490 0x0000000184D87490-0x0000000184D874A0
		// Color get_Color()
		Color *CW::Common::CwDemoButtonBuilder::get_Color(
		        Color *__return_ptr retstr,
		        CwDemoButtonBuilder *this,
		        MethodInfo *method)
		{
		  Color *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.color;
		  return result;
		}
		

		// Void set_dryColor(Color)
		void UnityEngine::DetailPrototype::set_dryColor(DetailPrototype *this, Color *value, MethodInfo *method)
		{
		  this->fields.m_DryColor = *value;
		}
		
		protected PassConstructorID firstBackbufferPass { get; private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		// Int32Enum get_defaultValue()
		Int32Enum__Enum UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::get_defaultValue(
		        TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
		        MethodInfo *method)
		{
		  return this->fields._defaultValue_k__BackingField;
		}
		

		// Void set_defaultValue(Int32Enum)
		void UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::set_defaultValue(
		        TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
		        Int32Enum__Enum value,
		        MethodInfo *method)
		{
		  this->fields._defaultValue_k__BackingField = value;
		}
		
		internal int renderPathID { get; private set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
		// Int32 get_bindingId()
		int32_t Beyond::Input::UIEvent<System::Object>::get_bindingId(UIEvent_1_System_Object_ *this, MethodInfo *method)
		{
		  return this->fields._bindingId_k__BackingField;
		}
		

		// Void set_bindingId(Int32)
		void Beyond::Input::UIEvent<System::Object>::set_bindingId(
		        UIEvent_1_System_Object_ *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._bindingId_k__BackingField = value;
		}
		
		internal int renderPathFrameIndex { get; private set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		// Int32 get_defaultArea()
		int32_t UnityEngine::AI::NavMeshSurface::get_defaultArea(NavMeshSurface *this, MethodInfo *method)
		{
		  return this->fields.m_DefaultArea;
		}
		

		// Void set_flags(TileFlags)
		void UnityEngine::Tilemaps::TileData::set_flags(TileData *this, TileFlags__Enum value, MethodInfo *method)
		{
		  this->m_Flags = value;
		}
		
		protected HGRenderPathInternal renderPath { get; private set; } // 0x0000000184D86560-0x0000000184D86570 0x0000000184D865C0-0x0000000184D865D0
		// Int32 get_optionIndex()
		int32_t UnityEngine::Timeline::RuntimeClip::get_optionIndex(RuntimeClip *this, MethodInfo *method)
		{
		  return this->fields._optionIndex_k__BackingField;
		}
		

		// Void set_colliderType(Tile+ColliderType)
		void UnityEngine::Tilemaps::TileData::set_colliderType(
		        TileData *this,
		        Tile_ColliderType__Enum value,
		        MethodInfo *method)
		{
		  this->m_ColliderType = value;
		}
		
		internal HGRenderPathInternal renderPathInternalEnum { get; } // 0x00000001830FE840-0x00000001830FE8A0 
		// HGRenderPathInternal get_renderPathInternalEnum()
		HGRenderPathInternal__Enum HG::Rendering::Runtime::HGRenderPathBase::get_renderPathInternalEnum(
		        HGRenderPathBase *this,
		        MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 706 )
		    return this->fields._renderPath_k__BackingField;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2C2 )
		    sub_1800D2AB0(v3, method);
		  if ( !*((_QWORD *)&v3[15]._0.byval_arg + 1) )
		    return this->fields._renderPath_k__BackingField;
		  Patch = IFix::WrappersManagerImpl::GetPatch(706, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		protected ref BasicTransformConstants basicTransformConstants { get; } // 0x0000000189BDF140-0x0000000189BDF190 
		// BasicTransformConstants& get_basicTransformConstants()
		BasicTransformConstants *HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(
		        HGRenderPathBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1183, 0LL) )
		    return &this->fields.m_basicTransformConstants;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1183, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_449(Patch, (Object *)this, 0LL);
		}
		
		protected ref ShaderVariablesGlobal shaderVariablesGlobal { get; } // 0x0000000189BDF190-0x0000000189BDF1E0 
		// ShaderVariablesGlobal& get_shaderVariablesGlobal()
		ShaderVariablesGlobal *HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		        HGRenderPathBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1188, 0LL) )
		    return &this->fields.m_shaderVariablesGlobal;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1188, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_452(Patch, (Object *)this, 0LL);
		}
		
		protected ref UIShaderVariablesGlobal uiShaderVariablesGlobal { get; } // 0x0000000189BDF1E0-0x0000000189BDF230 
		// UIShaderVariablesGlobal& get_uiShaderVariablesGlobal()
		UIShaderVariablesGlobal *HG::Rendering::Runtime::HGRenderPathBase::get_uiShaderVariablesGlobal(
		        HGRenderPathBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3556, 0LL) )
		    return (UIShaderVariablesGlobal *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3556, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1267(Patch, (Object *)this, 0LL);
		}
		
		protected HGCamera camera { get; private set; } // 0x0000000184DA17E0-0x0000000184DA17F0 0x0000000189BDF230-0x0000000189BDF244
		// HGCamera get_camera()
		HGCamera *HG::Rendering::Runtime::HGRenderPathBase::get_camera(HGRenderPathBase *this, MethodInfo *method)
		{
		  return *(HGCamera **)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		}
		

		// Void set_camera(HGCamera)
		void HG::Rendering::Runtime::HGRenderPathBase::set_camera(HGRenderPathBase *this, HGCamera *value, MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23,
		    (Type *)value,
		    (PropertyInfo_1 *)method,
		    v3,
		    v4);
		}
		
	
		// Nested types
		internal struct PerFrameSetup // TypeDefIndex: 38515
		{
			// Fields
			internal GraphicsFormat depthGraphicsFormat; // 0x00
			internal DepthBits depthBits; // 0x04
			public unsafe HGSettingParametersCpp* settingParametersCpp; // 0x08
		}
	
		internal struct HGRenderPathParams // TypeDefIndex: 38516
		{
			// Fields
			internal bool skipRender; // 0x00
			internal HGRenderPipeline hgrp; // 0x08
			internal HGRenderPipeline.RenderRequest renderRequest; // 0x10
			internal HGRenderGraphParameters renderGraphParams; // 0x290
			internal PerFrameSetup perFrameSetup; // 0x2B8
		}
	
		internal enum RenderPathProfileScope // TypeDefIndex: 38517
		{
			PreRendering = 0,
			Rendering = 1,
			PostRendering = 2,
			Count = 3
		}
	
		internal struct HGRenderPathResources // TypeDefIndex: 38518
		{
			// Fields
			public HGRenderPipelineRuntimeResources defaultResources; // 0x00
			public HGSettingParameters settingParameters; // 0x08
	
			// Constructors
			public HGRenderPathResources(HGRenderPipeline hgrp) {
				defaultResources = default;
				settingParameters = default;
			} // 0x0000000184A353B0-0x0000000184A35400
			// HGRenderPathBase+HGRenderPathResources(HGRenderPipeline)
			void HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathResources::HGRenderPathResources(
			        HGRenderPathBase_HGRenderPathResources *this,
			        HGRenderPipeline *hgrp,
			        MethodInfo *method)
			{
			  Type *v5; // rdx
			  PropertyInfo_1 *v6; // r8
			  Int32__Array **v7; // r9
			  HGSettingParameters *settingParameters_k__BackingField; // r9
			  Type *v9; // rdx
			  PropertyInfo_1 *v10; // r8
			  MethodInfo *v11; // [rsp+20h] [rbp-8h]
			  MethodInfo *v12; // [rsp+50h] [rbp+28h]
			
			  if ( !hgrp )
			    sub_1800D8260(this, 0LL);
			  this->defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			  sub_18002D1B0((SingleFieldAccessor *)this, v5, v6, v7, v11);
			  settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
			  this->settingParameters = settingParameters_k__BackingField;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->settingParameters,
			    v9,
			    v10,
			    (Int32__Array **)settingParameters_k__BackingField,
			    v12);
			}
			
		}
	
		// Constructors
		protected HGRenderPathBase() {} // Dummy constructor
		internal HGRenderPathBase(HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath) {} // 0x0000000183B94B80-0x0000000183B94D60
		// HGRenderPathBase(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
		void HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        PassConstructorID__Enum__Array *passConstructorIDs,
		        HGCamera *camera,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  HGRenderPipelineMaterialCollector *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRenderPipelineMaterialCollector *v13; // rbx
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  SegmentHandle__Array *v17; // rdi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v18; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v19; // rbx
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Type *v23; // rdx
		  __int64 v24; // rcx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  int v27; // r15d
		  int32_t v28; // ebx
		  __int64 v29; // rdi
		  HGRenderPipelineMaterialCollector *v30; // rcx
		  List_1_System_Object_ *v31; // r14
		  Object *v32; // rax
		  HGRenderPathBase__StaticFields *static_fields; // rax
		  int32_t v34; // r8d
		  NativeArray_1_System_Int32_ v35; // [rsp+20h] [rbp-38h] BYREF
		
		  v10 = (HGRenderPipelineMaterialCollector *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		  v13 = v10;
		  if ( !v10
		    || (HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::HGRenderPipelineMaterialCollector(v10, 0LL),
		        *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = v13,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21,
		          v14,
		          v15,
		          v16,
		          (MethodInfo *)v35.m_Buffer),
		        v17 = (SegmentHandle__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 60LL),
		        System::Array::Fill<Beyond::Gameplay::Core::SegmentHandle>(
		          v17,
		          (SegmentHandle)-1,
		          MethodInfo::System::Array::Fill<int>),
		        !passConstructorIDs)
		    || (v18 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>),
		        (v19 = v18) == 0LL) )
		  {
		LABEL_12:
		    sub_1800D8260(v12, v11);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v18,
		    passConstructorIDs->max_length.size,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::List);
		  *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = v19;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix,
		    v20,
		    v21,
		    v22,
		    (MethodInfo *)v35.m_Buffer);
		  v35 = 0LL;
		  Unity::Collections::NativeArray<int>::NativeArray(
		    &v35,
		    (Int32__Array *)v17,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  v27 = 0;
		  v28 = 0;
		  *(NativeArray_1_System_Int32_ *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = v35;
		  while ( v28 < passConstructorIDs->max_length.size )
		  {
		    if ( (unsigned int)v28 >= passConstructorIDs->max_length.size )
		      sub_1800D2AB0(v24, v23);
		    v29 = (int)passConstructorIDs->vector[v28];
		    if ( *(_DWORD *)(*(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 + 4 * v29) == -1 )
		    {
		      v30 = *(HGRenderPipelineMaterialCollector **)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21;
		      v31 = *(List_1_System_Object_ **)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		      v35 = (NativeArray_1_System_Int32_)*resources;
		      v32 = (Object *)HG::Rendering::Runtime::PassConstructorFactory::Create(
		                        v30,
		                        (PassConstructorID__Enum)v29,
		                        (HGRenderPathBase_HGRenderPathResources *)&v35,
		                        0LL);
		      if ( !v31 )
		        goto LABEL_12;
		      sub_182F01190(v31, v32);
		      *(_DWORD *)(*(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 + 4 * v29) = v27++;
		    }
		    ++v28;
		  }
		  *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = camera;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23,
		    v23,
		    v25,
		    v26,
		    (MethodInfo *)v35.m_Buffer);
		  this->fields._renderPath_k__BackingField = renderPath;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderPathBase->static_fields;
		  v34 = static_fields->s_createdCount++;
		  this->fields._renderPathID_k__BackingField = v34;
		}
		
	
		// Methods
		unsafe void IRenderGraphCallbackOwner.OnRenderPassExecution(HGRenderGraph renderGraph, DynamicArray<AttachDesc> colorAttachments, object targetCamera, void* customPayload, bool renderPassIssued) {} // 0x0000000189BDC198-0x0000000189BDC82C
		// Void HG.Rendering.RenderGraphModule.IRenderGraphCallbackOwner.OnRenderPassExecution(HGRenderGraph, DynamicArray`1[HG.Rendering.RenderGraphModule.AttachDesc], Object, Void*, Boolean)
		void HG::Rendering::Runtime::HGRenderPathBase::HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_OnRenderPassExecution(
		        HGRenderPathBase *this,
		        HGRenderGraph *renderGraph,
		        DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments,
		        Object *targetCamera,
		        Void *customPayload,
		        bool renderPassIssued,
		        MethodInfo *method)
		{
		  HGRenderGraph *v8; // r12
		  HGRenderPathBase *v9; // rsi
		  bool v10; // r15
		  int32_t v11; // edi
		  int v12; // r13d
		  AttachDesc *Item; // rbx
		  AttachDesc *v14; // rax
		  Object *v15; // rax
		  HGCamera *v16; // rbx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  HGRenderGraphContext *HGContext; // r14
		  BasicTransformConstants *basicTransformConstants; // rdi
		  Matrix4x4 *PreTransformMatrix; // rbx
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __m128i v24; // xmm2
		  __int128 v25; // xmm0
		  __int64 v26; // rbx
		  CBHandle *v27; // rax
		  void *ptr; // xmm1_8
		  BasicTransformConstants *v29; // rax
		  __int64 v30; // rdx
		  _OWORD *v31; // rcx
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  UIShaderVariablesGlobal *uiShaderVariablesGlobal; // rax
		  Vector4 ProjectionParams; // xmm1
		  Vector4 ScreenParams; // xmm0
		  Vector4 ZBufferParams; // xmm1
		  CommandBuffer *cmd; // rdi
		  CBHandle *v48; // rax
		  void *v49; // xmm1_8
		  CBHandle *v50; // rax
		  void *v51; // xmm1_8
		  BasicTransformConstants *v52; // rax
		  ShaderVariablesGlobal *shaderVariablesGlobal; // rax
		  uint32_t v54; // xmm7_4
		  int v55; // xmm8_4
		  unsigned __int32 v56; // eax
		  float preTransform; // xmm9_4
		  __int128 v58; // xmm6
		  CommandBuffer *v59; // rbx
		  __int64 v60; // rax
		  Exception *v61; // rbx
		  String *v62; // rax
		  __int64 v63; // rax
		  MethodInfo *size; // [rsp+28h] [rbp-E0h]
		  CBHandle offset_8; // [rsp+38h] [rbp-D0h] BYREF
		  CBHandle v66; // [rsp+58h] [rbp-B0h] BYREF
		  Nullable_1_UnityEngine_Matrix4x4_ pretransformMatrix_8; // [rsp+78h] [rbp-90h] BYREF
		  _BYTE v68[68]; // [rsp+C8h] [rbp-40h] BYREF
		  CBHandle v69; // [rsp+118h] [rbp+10h] BYREF
		  _BYTE v70[3264]; // [rsp+138h] [rbp+30h] BYREF
		
		  v8 = renderGraph;
		  v9 = this;
		  if ( renderPassIssued )
		  {
		    v10 = 0;
		    v11 = 0;
		    if ( !colorAttachments )
		      goto LABEL_42;
		    v12 = 1;
		    while ( v11 < colorAttachments->fields._size_k__BackingField )
		    {
		      Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
		               colorAttachments,
		               v11,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&Item->textureHandle, 0LL) )
		      {
		        v14 = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
		                colorAttachments,
		                v11,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
		        if ( !v8 )
		          goto LABEL_42;
		        *(TextureHandle *)&offset_8.bufferId = v14->textureHandle;
		        v10 = (v10 | HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(v8, (TextureHandle *)&offset_8, 0LL)) != 0;
		      }
		      ++v11;
		    }
		    v15 = targetCamera;
		    if ( !targetCamera )
		      v15 = *(Object **)&v9[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		    *(_QWORD *)&offset_8.bufferId = sub_180005050(v15, TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v16 = *(HGCamera **)&offset_8.bufferId;
		    if ( !*(_QWORD *)&offset_8.bufferId )
		    {
		      v60 = sub_18007E180(&TypeInfo::System::Exception);
		      v61 = (Exception *)sub_18002C620(v60);
		      if ( v61 )
		      {
		        v62 = (String *)sub_18007E180(&off_18E270CE0);
		        System::Exception::Exception(v61, v62, 0LL);
		        v63 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGRenderPathBase::HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_OnRenderPassExecution);
		        sub_18007E190(v61, v63);
		      }
		      goto LABEL_42;
		    }
		    if ( !v8 )
		      goto LABEL_42;
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v8, 0LL);
		    if ( v16 != v9->fields.m_trackingCamera || v9->fields.m_trackingBackBufferState != v10 )
		    {
		      v9->fields.m_trackingCamera = v16;
		      sub_18002D1B0((SingleFieldAccessor *)&v9->fields.m_trackingCamera, (Type *)renderGraph, v17, v18, size);
		      v9->fields.m_trackingBackBufferState = v10;
		      basicTransformConstants = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(v9, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      PreTransformMatrix = HG::Rendering::Runtime::HGUtils::GetPreTransformMatrix(
		                             (Matrix4x4 *)&pretransformMatrix_8,
		                             v10,
		                             0LL);
		      sub_18033B9D0(v68, 0LL, 68LL);
		      v22 = *(_OWORD *)&PreTransformMatrix->m00;
		      v68[0] = 1;
		      v23 = *(_OWORD *)&PreTransformMatrix->m01;
		      v24 = *(__m128i *)&PreTransformMatrix->m03;
		      *(_OWORD *)&v68[4] = v22;
		      v25 = *(_OWORD *)&PreTransformMatrix->m02;
		      v26 = *(_QWORD *)&offset_8.bufferId;
		      *(_OWORD *)&v68[20] = v23;
		      *(_OWORD *)&v68[36] = v25;
		      *(__m128i *)&v68[52] = v24;
		      *(_OWORD *)&pretransformMatrix_8.hasValue = *(_OWORD *)v68;
		      *(_OWORD *)&pretransformMatrix_8.value.m30 = *(_OWORD *)&v68[16];
		      *(_OWORD *)&pretransformMatrix_8.value.m31 = *(_OWORD *)&v68[32];
		      *(_OWORD *)&pretransformMatrix_8.value.m32 = *(_OWORD *)&v68[48];
		      LODWORD(pretransformMatrix_8.value.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v24, 12));
		      HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
		        *(HGCamera **)&offset_8.bufferId,
		        basicTransformConstants,
		        &pretransformMatrix_8,
		        0LL);
		      if ( !HGContext )
		        goto LABEL_42;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v27 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &v66,
		              &HGContext->fields.renderContext,
		              784,
		              0LL);
		      ptr = v27->ptr;
		      *(_OWORD *)&offset_8.bufferId = *(_OWORD *)&v27->bufferId;
		      offset_8.ptr = ptr;
		      v29 = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(v9, 0LL);
		      v30 = 5LL;
		      v31 = v70;
		      do
		      {
		        v32 = *(_OWORD *)&v29->current._ViewMatrix.m01;
		        *v31 = *(_OWORD *)&v29->current._ViewMatrix.m00;
		        v33 = *(_OWORD *)&v29->current._ViewMatrix.m02;
		        v31[1] = v32;
		        v34 = *(_OWORD *)&v29->current._ViewMatrix.m03;
		        v31[2] = v33;
		        v35 = *(_OWORD *)&v29->current._InvViewMatrix.m00;
		        v31[3] = v34;
		        v36 = *(_OWORD *)&v29->current._InvViewMatrix.m01;
		        v31[4] = v35;
		        v37 = *(_OWORD *)&v29->current._InvViewMatrix.m02;
		        v31[5] = v36;
		        v38 = *(_OWORD *)&v29->current._InvViewMatrix.m03;
		        v29 = (BasicTransformConstants *)((char *)v29 + 128);
		        v31[6] = v37;
		        v31 += 8;
		        *(v31 - 1) = v38;
		        --v30;
		      }
		      while ( v30 );
		      v39 = *(_OWORD *)&v29->current._ViewMatrix.m01;
		      *v31 = *(_OWORD *)&v29->current._ViewMatrix.m00;
		      v40 = *(_OWORD *)&v29->current._ViewMatrix.m02;
		      v31[1] = v39;
		      v41 = *(_OWORD *)&v29->current._ViewMatrix.m03;
		      v31[2] = v40;
		      v42 = *(_OWORD *)&v29->current._InvViewMatrix.m00;
		      v31[3] = v41;
		      v31[4] = v42;
		      sub_1808AFD88(&offset_8, v70, 128LL);
		      uiShaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_uiShaderVariablesGlobal(v9, 0LL);
		      ProjectionParams = uiShaderVariablesGlobal->_ProjectionParams;
		      *(Vector4 *)&pretransformMatrix_8.hasValue = uiShaderVariablesGlobal->_Time;
		      ScreenParams = uiShaderVariablesGlobal->_ScreenParams;
		      *(Vector4 *)&pretransformMatrix_8.value.m30 = ProjectionParams;
		      ZBufferParams = uiShaderVariablesGlobal->_ZBufferParams;
		      *(Vector4 *)&pretransformMatrix_8.value.m31 = ScreenParams;
		      *(Vector4 *)&pretransformMatrix_8.value.m32 = ZBufferParams;
		      sub_1808AFE28(&offset_8, &pretransformMatrix_8);
		      cmd = HGContext->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !cmd )
		        goto LABEL_42;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        cmd,
		        offset_8.bufferId,
		        (int32_t)renderGraph[3].fields.m_FrameInformationLogger,
		        offset_8.offset,
		        784,
		        0LL);
		      *(__m128i *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(v9, 0LL)->_GraphicsFeaturesGlobalParam0.z = _mm_loadu_si128((const __m128i *)(v26 + 104));
		      v48 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &offset_8,
		              &HGContext->fields.renderContext,
		              1312,
		              0LL);
		      v49 = v48->ptr;
		      *(_OWORD *)&v66.bufferId = *(_OWORD *)&v48->bufferId;
		      v66.ptr = v49;
		      v50 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &v69,
		              &HGContext->fields.renderContext,
		              3200,
		              0LL);
		      v51 = v50->ptr;
		      *(_OWORD *)&offset_8.bufferId = *(_OWORD *)&v50->bufferId;
		      offset_8.ptr = v51;
		      v52 = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(v9, 0LL);
		      sub_18033B330(v70, v52, 1312LL);
		      sub_1808AF3F0(&v66, v70);
		      shaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(v9, 0LL);
		      sub_18033B330(v70, shaderVariablesGlobal, 3200LL);
		      sub_1808AF42C(&offset_8, v70);
		      this = (HGRenderPathBase *)HGContext->fields.cmd;
		      renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !this )
		        goto LABEL_42;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        (CommandBuffer *)this,
		        v66.bufferId,
		        HIDWORD(renderGraph[3].fields.m_DebugParameters),
		        v66.offset,
		        1312,
		        0LL);
		      this = (HGRenderPathBase *)HGContext->fields.cmd;
		      renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !this )
		        goto LABEL_42;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        (CommandBuffer *)this,
		        offset_8.bufferId,
		        (int32_t)renderGraph[3].fields.m_DebugParameters,
		        offset_8.offset,
		        3200,
		        0LL);
		    }
		    if ( !v10
		      || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES2
		      || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES3 )
		    {
		      v55 = 0;
		      v54 = 0;
		    }
		    else
		    {
		      v54 = 0;
		      v55 = 0;
		      if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Display);
		        v56 = UnityEngine::Display::get_preTransform(0LL) - 1;
		        if ( !v56 || v56 == 2 )
		          v54 = 1065353216;
		        else
		          v55 = 1065353216;
		        sub_1800036A0(TypeInfo::UnityEngine::Display);
		        preTransform = (float)(int)UnityEngine::Display::get_preTransform(0LL);
		LABEL_33:
		        if ( HGContext )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v66 = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                   &v69,
		                   &HGContext->fields.renderContext,
		                   32,
		                   0LL);
		          if ( customPayload )
		          {
		            if ( *(float *)&customPayload[4] != 0.0 )
		              v12 = 0;
		            offset_8.offset = v54;
		            *(float *)&offset_8.bufferId = (float)v12;
		            *(_QWORD *)&offset_8.size = __PAIR64__(LODWORD(preTransform), v55);
		            v58 = *(_OWORD *)&offset_8.bufferId;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            *(_OWORD *)&offset_8.bufferId = v58;
		            sub_1803693E8(&v66, &offset_8);
		            *(_OWORD *)&offset_8.bufferId = *(_OWORD *)customPayload;
		            sub_1803693C0(&v66, &offset_8);
		            v59 = HGContext->fields.cmd;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( v59 )
		            {
		              UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		                v59,
		                v66.bufferId,
		                (int32_t)renderGraph[3].fields.m_callbackOwner,
		                v66.offset,
		                32,
		                0LL);
		              return;
		            }
		          }
		        }
		LABEL_42:
		        sub_1800D8260(this, renderGraph);
		      }
		    }
		    preTransform = 0.0;
		    goto LABEL_33;
		  }
		}
		
		protected virtual bool SkipRender(ref HGRenderPathParams renderPathParams) => default; // 0x0000000189BDDDB0-0x0000000189BDDE08
		// Boolean SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
		bool HG::Rendering::Runtime::HGRenderPathBase::SkipRender(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(1178, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1178, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_446(Patch, (Object *)this, renderPathParams, 0LL);
		  }
		  else
		  {
		    renderPathParams->skipRender = 0;
		  }
		  return result;
		}
		
		protected virtual PassConstructorID GetDefaultFirstBackbufferPass() => default; // 0x0000000189BDC148-0x0000000189BDC198
		// PassConstructorID GetDefaultFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathBase::GetDefaultFirstBackbufferPass(
		        HGRenderPathBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3553, 0LL) )
		    return 52;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3553, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected virtual PassConstructorID FindFirstBackbufferPass() => default; // 0x0000000189BDC070-0x0000000189BDC0C0
		// PassConstructorID FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass(
		        HGRenderPathBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1193, 0LL) )
		    return 52;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1193, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected virtual void UpdateShaderVariablesGlobal(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ref ShaderVariablesGlobal shaderVariablesGlobal, ref ScriptableRenderContext context) {} // 0x0000000189BDE780-0x0000000189BDE840
		// Void UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
		        HGRenderPathBase *this,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1184, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalVFX(this, shaderVariablesGlobal, camera, 0LL);
		    if ( hgrp )
		    {
		      HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalWater(
		        this,
		        shaderVariablesGlobal,
		        hgrp->fields._settingParameters_k__BackingField,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(Patch, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1184, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_450(
		    Patch,
		    (Object *)this,
		    (Object *)hgrp,
		    (Object *)camera,
		    (Object *)cmd,
		    shaderVariablesGlobal,
		    context,
		    0LL);
		}
		
		private void UpdateUIShaderVariablesGlobal(HGCamera camera, ref UIShaderVariablesGlobal uiShaderVariablesGlobal, ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BDF09C-0x0000000189BDF140
		// Void UpdateUIShaderVariablesGlobal(HGCamera, UIShaderVariablesGlobal ByRef, ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateUIShaderVariablesGlobal(
		        HGRenderPathBase *this,
		        HGCamera *camera,
		        UIShaderVariablesGlobal *uiShaderVariablesGlobal,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1187, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1187, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_451(
		      Patch,
		      (Object *)this,
		      (Object *)camera,
		      uiShaderVariablesGlobal,
		      shaderVariablesGlobal,
		      0LL);
		  }
		  else
		  {
		    uiShaderVariablesGlobal->_Time = (Vector4)_mm_loadu_si128((const __m128i *)&shaderVariablesGlobal->_GraphicsFeaturesGlobalParam1.z);
		    uiShaderVariablesGlobal->_ProjectionParams = (Vector4)_mm_loadu_si128((const __m128i *)&shaderVariablesGlobal->_ProjectionParams);
		    uiShaderVariablesGlobal->_ScreenParams = (Vector4)_mm_loadu_si128((const __m128i *)shaderVariablesGlobal);
		    uiShaderVariablesGlobal->_ZBufferParams = (Vector4)_mm_loadu_si128((const __m128i *)&shaderVariablesGlobal->_ZBufferParams);
		  }
		}
		
		[IDTag(0)]
		protected virtual void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BDCB70-0x0000000189BDCBC4
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1200, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1200, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		  }
		}
		
		protected abstract void RenderInternal(ref HGRenderPathParams renderPathParams);
		[IDTag(0)]
		protected virtual void OnPostRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BDCB1C-0x0000000189BDCB70
		// Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1206, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1206, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		  }
		}
		
		private void UpdateShaderVariablesIrradianceVolume(ref HGIrradianceVolumePipelineUpdateResult result, int curFrameIdx, HGCamera camera, CommandBuffer cmd) {} // 0x0000000189BDEB2C-0x0000000189BDF09C
		// Void UpdateShaderVariablesIrradianceVolume(HGIrradianceVolumePipelineUpdateResult ByRef, Int32, HGCamera, CommandBuffer)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolume(
		        HGRenderPathBase *this,
		        HGIrradianceVolumePipelineUpdateResult *result,
		        int32_t curFrameIdx,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  int32_t IrradianceVolumeIndirectTexture; // ebx
		  RenderTargetIdentifier *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Vector4 v14; // xmm1
		  int32_t IrradianceVolumeAtlas0; // ebx
		  RenderTargetIdentifier *v16; // rax
		  Vector4 v17; // xmm1
		  int32_t IrradianceVolumeAtlas1; // ebx
		  RenderTargetIdentifier *v19; // rax
		  Vector4 v20; // xmm1
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // r8
		  HGSkyConfig *p_skyConfig; // rcx
		  HGSkyConfig *v26; // rax
		  char *v27; // rdx
		  __int64 v28; // r9
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int64 v36; // r9
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int64 v41; // rax
		  HGSkyConfig *v42; // rax
		  _OWORD *v43; // rdx
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int64 v55; // rax
		  _OWORD *v56; // rdx
		  __int128 v57; // xmm1
		  __int128 v58; // xmm0
		  __int128 v59; // xmm1
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int64 v64; // rax
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  __int128 v68; // xmm0
		  __int128 v69; // xmm0
		  float v70; // eax
		  __int128 v71; // xmm1
		  __int128 v72; // xmm2
		  __int128 v73; // xmm3
		  __int128 v74; // xmm4
		  __int128 v75; // xmm5
		  __int64 v76; // xmm6_8
		  __int128 v77; // xmm1
		  __int128 v78; // xmm0
		  __int128 v79; // xmm1
		  __int128 v80; // xmm0
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int64 v84; // rax
		  __int128 v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  __int128 v88; // xmm0
		  SHCoefficientsL1 *CoefficientsL1; // rax
		  Vector4 shAg; // xmm6
		  Vector4 shAb; // xmm7
		  MethodInfo *v92; // r9
		  Vector4 *v93; // rax
		  MethodInfo *v94; // r9
		  float v95; // xmm5_4
		  Vector4 *v96; // rax
		  MethodInfo *v97; // r9
		  float v98; // xmm5_4
		  __int64 v99; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 shAr; // [rsp+48h] [rbp-C0h] BYREF
		  SHCoefficientsL1 v102; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v103; // [rsp+88h] [rbp-80h] BYREF
		  RenderTargetIdentifier v104; // [rsp+98h] [rbp-70h] BYREF
		  SphericalHarmonicsL2 v105; // [rsp+C8h] [rbp-40h] BYREF
		  _BYTE v106[24]; // [rsp+138h] [rbp+30h] BYREF
		  __int128 v107; // [rsp+150h] [rbp+48h]
		  __int128 v108; // [rsp+160h] [rbp+58h]
		  __int128 v109; // [rsp+170h] [rbp+68h]
		  __int128 v110; // [rsp+180h] [rbp+78h]
		  __int128 v111; // [rsp+190h] [rbp+88h]
		  __int128 v112; // [rsp+1A0h] [rbp+98h]
		  __int64 v113; // [rsp+1B0h] [rbp+A8h]
		  float v114; // [rsp+1B8h] [rbp+B0h]
		  __int128 v115; // [rsp+214h] [rbp+10Ch]
		  __int128 v116; // [rsp+224h] [rbp+11Ch]
		  __int128 v117; // [rsp+234h] [rbp+12Ch]
		  __int128 v118; // [rsp+244h] [rbp+13Ch]
		  __int128 v119; // [rsp+254h] [rbp+14Ch]
		  __int128 v120; // [rsp+264h] [rbp+15Ch]
		  __int64 v121; // [rsp+274h] [rbp+16Ch]
		  float v122; // [rsp+27Ch] [rbp+174h]
		  char v123; // [rsp+298h] [rbp+190h] BYREF
		  float v124; // [rsp+2A8h] [rbp+1A0h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1180, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1180, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v99);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_447(
		      Patch,
		      (Object *)this,
		      result,
		      curFrameIdx,
		      (Object *)camera,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    shAr.y = 0.0;
		    *(_QWORD *)&shAr.z = 0LL;
		    this->fields.m_passConstructorMapping = (NativeArray_1_System_Int32_)_mm_loadu_si128((const __m128i *)result);
		    *(__m128i *)&this->fields.m_materialCollector = _mm_loadu_si128((const __m128i *)&result->param1);
		    shAr.x = (float)(curFrameIdx % 64);
		    *(Vector4 *)&this[1].monitor = shAr;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    IrradianceVolumeIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeIndirectTexture;
		    v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result->indirectionTexture, 0LL);
		    if ( !cmd )
		      sub_1800D8260(v13, v12);
		    v14 = *(Vector4 *)&v11->m_BufferPointer;
		    v102.shAr = *(Vector4 *)&v11->m_Type;
		    *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v11->m_DepthSlice;
		    v102.shAg = v14;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		      cmd,
		      IrradianceVolumeIndirectTexture,
		      (RenderTargetIdentifier *)&v102,
		      0LL);
		    IrradianceVolumeAtlas0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeAtlas0;
		    v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result->physicalTexture0, 0LL);
		    v17 = *(Vector4 *)&v16->m_BufferPointer;
		    v102.shAr = *(Vector4 *)&v16->m_Type;
		    *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v16->m_DepthSlice;
		    v102.shAg = v17;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		      cmd,
		      IrradianceVolumeAtlas0,
		      (RenderTargetIdentifier *)&v102,
		      0LL);
		    IrradianceVolumeAtlas1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeAtlas1;
		    v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result->physicalTexture1, 0LL);
		    v20 = *(Vector4 *)&v19->m_BufferPointer;
		    v102.shAr = *(Vector4 *)&v19->m_Type;
		    *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v19->m_DepthSlice;
		    v102.shAg = v20;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		      cmd,
		      IrradianceVolumeAtlas1,
		      (RenderTargetIdentifier *)&v102,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( !InterpolatedPhase )
		      sub_1800D8260(v23, v22);
		    v24 = 2LL;
		    p_skyConfig = &InterpolatedPhase->fields.skyConfig;
		    v26 = &InterpolatedPhase->fields.skyConfig;
		    v27 = &v123;
		    v28 = 2LL;
		    do
		    {
		      v29 = *(_OWORD *)&v26->skyDirectIntensity;
		      *(_OWORD *)v27 = *(_OWORD *)&v26->parentEnvPhaseGuid;
		      v30 = *(_OWORD *)&v26->customIVDefaultSH.shr2;
		      *((_OWORD *)v27 + 1) = v29;
		      v31 = *(_OWORD *)&v26->customIVDefaultSH.shr6;
		      *((_OWORD *)v27 + 2) = v30;
		      v32 = *(_OWORD *)&v26->customIVDefaultSH.shg1;
		      *((_OWORD *)v27 + 3) = v31;
		      v33 = *(_OWORD *)&v26->customIVDefaultSH.shg5;
		      *((_OWORD *)v27 + 4) = v32;
		      v34 = *(_OWORD *)&v26->customIVDefaultSH.shb0;
		      *((_OWORD *)v27 + 5) = v33;
		      v35 = *(_OWORD *)&v26->customIVDefaultSH.shb4;
		      v26 = (HGSkyConfig *)((char *)v26 + 128);
		      *((_OWORD *)v27 + 6) = v34;
		      v27 += 128;
		      *((_OWORD *)v27 - 1) = v35;
		      --v28;
		    }
		    while ( v28 );
		    v36 = 2LL;
		    v37 = *(_OWORD *)&v26->skyDirectIntensity;
		    *(_OWORD *)v27 = *(_OWORD *)&v26->parentEnvPhaseGuid;
		    v38 = *(_OWORD *)&v26->customIVDefaultSH.shr2;
		    *((_OWORD *)v27 + 1) = v37;
		    v39 = *(_OWORD *)&v26->customIVDefaultSH.shr6;
		    *((_OWORD *)v27 + 2) = v38;
		    v40 = *(_OWORD *)&v26->customIVDefaultSH.shg1;
		    v41 = *(_QWORD *)&v26->customIVDefaultSH.shg5;
		    *((_OWORD *)v27 + 3) = v39;
		    *((_OWORD *)v27 + 4) = v40;
		    *((_QWORD *)v27 + 10) = v41;
		    v42 = p_skyConfig;
		    v43 = v106;
		    do
		    {
		      v44 = *(_OWORD *)&v42->skyDirectIntensity;
		      *v43 = *(_OWORD *)&v42->parentEnvPhaseGuid;
		      v45 = *(_OWORD *)&v42->customIVDefaultSH.shr2;
		      v43[1] = v44;
		      v46 = *(_OWORD *)&v42->customIVDefaultSH.shr6;
		      v43[2] = v45;
		      v47 = *(_OWORD *)&v42->customIVDefaultSH.shg1;
		      v43[3] = v46;
		      v48 = *(_OWORD *)&v42->customIVDefaultSH.shg5;
		      v43[4] = v47;
		      v49 = *(_OWORD *)&v42->customIVDefaultSH.shb0;
		      v43[5] = v48;
		      v50 = *(_OWORD *)&v42->customIVDefaultSH.shb4;
		      v42 = (HGSkyConfig *)((char *)v42 + 128);
		      v43[6] = v49;
		      v43 += 8;
		      *(v43 - 1) = v50;
		      --v36;
		    }
		    while ( v36 );
		    v51 = *(_OWORD *)&v42->skyDirectIntensity;
		    *v43 = *(_OWORD *)&v42->parentEnvPhaseGuid;
		    v52 = *(_OWORD *)&v42->customIVDefaultSH.shr2;
		    v43[1] = v51;
		    v53 = *(_OWORD *)&v42->customIVDefaultSH.shr6;
		    v43[2] = v52;
		    v54 = *(_OWORD *)&v42->customIVDefaultSH.shg1;
		    v55 = *(_QWORD *)&v42->customIVDefaultSH.shg5;
		    v43[3] = v53;
		    v43[4] = v54;
		    *((_QWORD *)v43 + 10) = v55;
		    v56 = v106;
		    if ( v106[20] )
		    {
		      do
		      {
		        v57 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		        *v56 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		        v58 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		        v56[1] = v57;
		        v59 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		        v56[2] = v58;
		        v60 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		        v56[3] = v59;
		        v61 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		        v56[4] = v60;
		        v62 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb0;
		        v56[5] = v61;
		        v63 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb4;
		        p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		        v56[6] = v62;
		        v56 += 8;
		        *(v56 - 1) = v63;
		        --v24;
		      }
		      while ( v24 );
		      v64 = *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		      v65 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		      *v56 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		      v66 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		      v56[1] = v65;
		      v67 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		      v56[2] = v66;
		      v68 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		      v56[3] = v67;
		      v56[4] = v68;
		      *((_QWORD *)v56 + 10) = v64;
		      v69 = v107;
		      v70 = v114;
		      v71 = v108;
		      v72 = v109;
		      v73 = v110;
		      v74 = v111;
		      v75 = v112;
		      v76 = v113;
		    }
		    else
		    {
		      do
		      {
		        v77 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		        *v56 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		        v78 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		        v56[1] = v77;
		        v79 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		        v56[2] = v78;
		        v80 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		        v56[3] = v79;
		        v81 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		        v56[4] = v80;
		        v82 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb0;
		        v56[5] = v81;
		        v83 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb4;
		        p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		        v56[6] = v82;
		        v56 += 8;
		        *(v56 - 1) = v83;
		        --v24;
		      }
		      while ( v24 );
		      v84 = *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		      v85 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		      *v56 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		      v86 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		      v56[1] = v85;
		      v87 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		      v56[2] = v86;
		      v88 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		      v56[3] = v87;
		      v56[4] = v88;
		      *((_QWORD *)v56 + 10) = v84;
		      v69 = v115;
		      v70 = v122;
		      v71 = v116;
		      v72 = v117;
		      v73 = v118;
		      v74 = v119;
		      v75 = v120;
		      v76 = v121;
		    }
		    *(_OWORD *)&v105.shr0 = v69;
		    *(_OWORD *)&v105.shr4 = v71;
		    *(_OWORD *)&v105.shr8 = v72;
		    *(_OWORD *)&v105.shg3 = v73;
		    *(_OWORD *)&v105.shg7 = v74;
		    *(_OWORD *)&v105.shb2 = v75;
		    *(_QWORD *)&v105.shb6 = v76;
		    v105.shb8 = v70;
		    CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(&v102, &v105, 0LL);
		    shAg = CoefficientsL1->shAg;
		    shAb = CoefficientsL1->shAb;
		    shAr = CoefficientsL1->shAr;
		    v93 = UnityEngine::Vector4::op_Multiply(&v103, &shAr, v124, v92);
		    shAr = shAg;
		    *(__m128i *)&this[1].fields._intermediateBackBuffer_k__BackingField.fallBackResource.m_Value = _mm_loadu_si128((const __m128i *)v93);
		    v96 = UnityEngine::Vector4::op_Multiply(&v103, &shAr, v95, v94);
		    shAr = shAb;
		    *(__m128i *)&this[1].fields._backBufferColor_k__BackingField.fallBackResource.m_Value = _mm_loadu_si128((const __m128i *)v96);
		    *(__m128i *)&this[1].fields._backBufferDepth_k__BackingField.fallBackResource.m_Value = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(&v103, &shAr, v98, v97));
		  }
		}
		
		private void UpdateShaderVariablesIrradianceVolumeV2(ref HGIrradianceVolumePipelineUpdateResultV2 result, int curFrameIdx, HGCamera camera, CommandBuffer cmd) {} // 0x0000000189BDE840-0x0000000189BDEB2C
		// Void UpdateShaderVariablesIrradianceVolumeV2(HGIrradianceVolumePipelineUpdateResultV2 ByRef, Int32, HGCamera, CommandBuffer)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolumeV2(
		        HGRenderPathBase *this,
		        HGIrradianceVolumePipelineUpdateResultV2 *result,
		        int32_t curFrameIdx,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  int32_t IrradianceVolumeClipmapTextureALod0; // ebx
		  RenderTargetIdentifier *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int128 v14; // xmm1
		  int32_t IrradianceVolumeClipmapTextureBLod0; // ebx
		  RenderTargetIdentifier *v16; // rax
		  __int128 v17; // xmm1
		  int32_t IrradianceVolumeClipmapTextureALod1; // ebx
		  RenderTargetIdentifier *v19; // rax
		  __int128 v20; // xmm1
		  int32_t IrradianceVolumeClipmapTextureBLod1; // ebx
		  RenderTargetIdentifier *v22; // rax
		  __int128 v23; // xmm1
		  int32_t IrradianceVolumeClipmapTextureALod3; // ebx
		  RenderTargetIdentifier *v25; // rax
		  __int128 v26; // xmm1
		  int32_t IrradianceVolumeClipmapTextureBLod3; // ebx
		  RenderTargetIdentifier *v28; // rax
		  __int128 v29; // xmm1
		  __int64 v30; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v32; // [rsp+48h] [rbp-29h]
		  RenderTargetIdentifier v33; // [rsp+58h] [rbp-19h] BYREF
		  RenderTargetIdentifier v34; // [rsp+88h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1181, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1181, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v30);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_448(
		      Patch,
		      (Object *)this,
		      result,
		      curFrameIdx,
		      (Object *)camera,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    HIDWORD(v32) = 0;
		    *(__m128i *)&this[1].fields.m_trackingCamera = _mm_loadu_si128((const __m128i *)result);
		    *(__m128i *)&this[1].fields._renderPathFrameIndex_k__BackingField = _mm_loadu_si128((const __m128i *)&result->param1);
		    *(__m128i *)&this[1].fields.m_basicTransformConstants.current._ViewMatrix.m20 = _mm_loadu_si128((const __m128i *)&result->param2);
		    *(_QWORD *)&v32 = *(_QWORD *)&result->param3.x;
		    *((float *)&v32 + 2) = (float)(curFrameIdx % 64);
		    *(_OWORD *)&this[1].fields.m_basicTransformConstants.current._ViewMatrix.m21 = v32;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    IrradianceVolumeClipmapTextureALod0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod0;
		    v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureALod0, 0LL);
		    if ( !cmd )
		      sub_1800D8260(v13, v12);
		    v14 = *(_OWORD *)&v11->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v11->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v11->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v14;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod0, &v33, 0LL);
		    IrradianceVolumeClipmapTextureBLod0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod0;
		    v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureBLod0, 0LL);
		    v17 = *(_OWORD *)&v16->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v16->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v16->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v17;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod0, &v33, 0LL);
		    IrradianceVolumeClipmapTextureALod1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod1;
		    v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureALod1, 0LL);
		    v20 = *(_OWORD *)&v19->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v19->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v19->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v20;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod1, &v33, 0LL);
		    IrradianceVolumeClipmapTextureBLod1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod1;
		    v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureBLod1, 0LL);
		    v23 = *(_OWORD *)&v22->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v22->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v22->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v23;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod1, &v33, 0LL);
		    IrradianceVolumeClipmapTextureALod3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod3;
		    v25 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureALod3, 0LL);
		    v26 = *(_OWORD *)&v25->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v25->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v25->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v26;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod3, &v33, 0LL);
		    IrradianceVolumeClipmapTextureBLod3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod3;
		    v28 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result->clipmapTextureBLod3, 0LL);
		    v29 = *(_OWORD *)&v28->m_BufferPointer;
		    *(_OWORD *)&v33.m_Type = *(_OWORD *)&v28->m_Type;
		    *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v28->m_DepthSlice;
		    *(_OWORD *)&v33.m_BufferPointer = v29;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod3, &v33, 0LL);
		  }
		}
		
		private void UpdateShaderVariablesGlobalCB(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ScriptableRenderContext context) {} // 0x0000000189BDDEB4-0x0000000189BDE508
		// Void UpdateShaderVariablesGlobalCB(HGRenderPipeline, HGCamera, CommandBuffer, ScriptableRenderContext)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalCB(
		        HGRenderPathBase *this,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  Object *v6; // r15
		  Object *v7; // r14
		  HGRenderPathBase *v9; // rsi
		  BasicTransformConstants *basicTransformConstants; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  List_1_System_UInt64_ *v13; // rdx
		  ShaderVariablesGlobal *p_m_shaderVariablesGlobal; // rdx
		  _OWORD *p_m00; // rax
		  _OWORD *v16; // rcx
		  __int64 v17; // rbx
		  __int64 v18; // rdx
		  ShaderVariablesGlobal *v19; // rax
		  Vector4 *v20; // rcx
		  __int64 v21; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  BasicTransformConstants *v23; // rax
		  ShaderVariablesGlobal *shaderVariablesGlobal; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  char v28; // [rsp+40h] [rbp-1048h] BYREF
		  CBHandle bufferId; // [rsp+48h] [rbp-1040h] BYREF
		  CBHandle v30; // [rsp+60h] [rbp-1028h] BYREF
		  List_1_T_Enumerator_System_Object_ v31; // [rsp+78h] [rbp-1010h] BYREF
		  Il2CppException *ex; // [rsp+90h] [rbp-FF8h]
		  char *v33; // [rsp+98h] [rbp-FF0h]
		  Matrix4x4 identityMatrix; // [rsp+A0h] [rbp-FE8h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+E0h] [rbp-FA8h] BYREF
		  Il2CppExceptionWrapper *v36; // [rsp+E8h] [rbp-FA0h] BYREF
		  CBHandle v37; // [rsp+F0h] [rbp-F98h] BYREF
		  _BYTE v38[720]; // [rsp+110h] [rbp-F78h] BYREF
		  ShaderVariablesGlobal v39; // [rsp+3E0h] [rbp-CA8h] BYREF
		
		  v6 = (Object *)cmd;
		  v7 = (Object *)camera;
		  v9 = this;
		  v28 = 0;
		  memset(&v31, 0, sizeof(v31));
		  if ( IFix::WrappersManagerImpl::IsPatched(1182, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1182, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_453(Patch, (Object *)v9, (Object *)hgrp, v7, v6, context, 0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x6Cu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    ex = 0LL;
		    v33 = &v28;
		    try
		    {
		      basicTransformConstants = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(v9, 0LL);
		      if ( !v7 )
		        sub_1800D8250(TypeInfo::UnityEngine::Matrix4x4, v11);
		      identityMatrix = TypeInfo::UnityEngine::Matrix4x4->static_fields->identityMatrix;
		      HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
		        (HGCamera *)v7,
		        &v9->fields.m_shaderVariablesGlobal,
		        basicTransformConstants,
		        &identityMatrix,
		        0LL);
		      sub_1800049A0(v9->klass);
		      ((void (__fastcall *)(HGRenderPathBase *, HGRenderPipeline *, Object *, Object *, ShaderVariablesGlobal *))v9->klass->vtable.UpdateShaderVariablesGlobal.method)(
		        v9,
		        hgrp,
		        v7,
		        v6,
		        &v9->fields.m_shaderVariablesGlobal);
		      v13 = *(List_1_System_UInt64_ **)&v9[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		      if ( !v13 )
		        sub_1800D8250(v12, 0LL);
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v30,
		        v13,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
		      v31 = (List_1_T_Enumerator_System_Object_)v30;
		      *(_QWORD *)&bufferId.bufferId = 0LL;
		      *(_QWORD *)&bufferId.size = &v31;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v31,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
		        {
		          p_m_shaderVariablesGlobal = &v9->fields.m_shaderVariablesGlobal;
		          if ( !v31._current )
		            sub_1800D8250(0LL, p_m_shaderVariablesGlobal);
		          sub_189BDBB7C(v31._current, p_m_shaderVariablesGlobal);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v35 )
		      {
		        *(Il2CppExceptionWrapper *)&bufferId.bufferId = (Il2CppExceptionWrapper)v35->ex;
		        if ( *(_QWORD *)&bufferId.bufferId )
		          sub_18007E1E0(*(_QWORD *)&bufferId.bufferId);
		        v6 = (Object *)cmd;
		        v7 = (Object *)camera;
		        v9 = this;
		      }
		      HG::Rendering::Runtime::HGRenderPathBase::UpdateUIShaderVariablesGlobal(
		        v9,
		        (HGCamera *)v7,
		        (UIShaderVariablesGlobal *)&v9[1].fields.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23,
		        &v9->fields.m_shaderVariablesGlobal,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      bufferId = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v30, &context, 784, 0LL);
		      p_m00 = (_OWORD *)&v9->fields.m_basicTransformConstants.current._ViewMatrix.m00;
		      v16 = v38;
		      v17 = 5LL;
		      v18 = 5LL;
		      do
		      {
		        *v16 = *p_m00;
		        v16[1] = p_m00[1];
		        v16[2] = p_m00[2];
		        v16[3] = p_m00[3];
		        v16[4] = p_m00[4];
		        v16[5] = p_m00[5];
		        v16[6] = p_m00[6];
		        v16 += 8;
		        *(v16 - 1) = p_m00[7];
		        p_m00 += 8;
		        --v18;
		      }
		      while ( v18 );
		      *v16 = *p_m00;
		      v16[1] = p_m00[1];
		      v16[2] = p_m00[2];
		      v16[3] = p_m00[3];
		      v16[4] = p_m00[4];
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v19 = &v39;
		      v20 = (Vector4 *)v38;
		      do
		      {
		        v19->_ScreenSize = *v20;
		        v19->_BackBufferSize = v20[1];
		        v19->_ZBufferParams = v20[2];
		        v19->_ProjectionParams = v20[3];
		        v19->unity_OrthoParams = v20[4];
		        v19->_ScreenParams = v20[5];
		        *(Vector4 *)&v19->_FrustumPlanes.FixedElementField = v20[6];
		        v19 = (ShaderVariablesGlobal *)((char *)v19 + 128);
		        *(Vector4 *)&v19[-1]._VolumetricComposeParams.y = v20[7];
		        v20 += 8;
		        --v17;
		      }
		      while ( v17 );
		      v19->_ScreenSize = *v20;
		      v19->_BackBufferSize = v20[1];
		      v19->_ZBufferParams = v20[2];
		      v19->_ProjectionParams = v20[3];
		      v19->unity_OrthoParams = v20[4];
		      HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::CurrentViewTransformConstants>(
		        &bufferId,
		        (CurrentViewTransformConstants *)&v39,
		        0,
		        MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::CurrentViewTransformConstants>);
		      identityMatrix = *(Matrix4x4 *)&v9[1].fields.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		      HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::UIShaderVariablesGlobal>(
		        &bufferId,
		        (UIShaderVariablesGlobal *)&identityMatrix,
		        720,
		        MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::UIShaderVariablesGlobal>);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( !v6 )
		        sub_1800D8250(static_fields, v21);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        (CommandBuffer *)v6,
		        bufferId.bufferId,
		        static_fields->_UIRenderingConstants,
		        bufferId.offset,
		        784,
		        0LL);
		      bufferId = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v30, &context, 1312, 0LL);
		      v30 = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v37, &context, 3200, 0LL);
		      v23 = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(v9, 0LL);
		      sub_18033B330(&v39, v23, 1312LL);
		      HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>(
		        &bufferId,
		        (BasicTransformConstants *)&v39,
		        0,
		        MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
		      shaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(v9, 0LL);
		      sub_18033B330(&v39, shaderVariablesGlobal, 3200LL);
		      HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>(
		        &v30,
		        &v39,
		        0,
		        MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        (CommandBuffer *)v6,
		        bufferId.bufferId,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransformVariables,
		        bufferId.offset,
		        1312,
		        0LL);
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        (CommandBuffer *)v6,
		        v30.bufferId,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShaderVariablesGlobal,
		        v30.offset,
		        3200,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v36 )
		    {
		      ex = v36->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		[IDTag(1)]
		private void OnPreRendering(ref HGRenderPathParams renderPathParams, bool skipRender) {} // 0x0000000189BDCBC4-0x0000000189BDD454
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        bool skipRender,
		        MethodInfo *method)
		{
		  HGRenderPipeline *v7; // rbx
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  HGCamera **p_camera; // rcx
		  __int64 v10; // rdx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  HGCamera *v14; // r14
		  bool IsUICamera; // al
		  HGCamera *v16; // r12
		  CommandBuffer *commandBuffer; // rdi
		  void *m_Ptr; // rbx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Object_1 *targetTexture; // rbx
		  bool v24; // di
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  RenderTexture *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  RenderTexture *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  GraphicsFormat__Enum graphicsFormat; // eax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int128 v40; // xmm9
		  __int128 v41; // xmm10
		  __int64 v42; // xmm11_8
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *v45; // rax
		  TextureHandle Item2; // xmm2
		  bool msaaEnabled; // di
		  MethodInfo *taauRTSize_k__BackingField; // rbx
		  HGRenderGraph *v49; // rbx
		  Type *v50; // rdx
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **v52; // r9
		  Type *v53; // rdx
		  PropertyInfo_1 *v54; // r8
		  Int32__Array **v55; // r9
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  Type *v59; // rdx
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **v61; // r9
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  __int64 v64; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  MethodInfo *cmd; // [rsp+20h] [rbp-578h]
		  MethodInfo *cmda; // [rsp+20h] [rbp-578h]
		  MethodInfo *cmdb; // [rsp+20h] [rbp-578h]
		  MethodInfo *cmdc; // [rsp+20h] [rbp-578h]
		  MethodInfo *cmdd; // [rsp+20h] [rbp-578h]
		  MethodInfo *methoda; // [rsp+28h] [rbp-570h]
		  RenderTargetIdentifier v74; // [rsp+50h] [rbp-548h] BYREF
		  HGRenderPipeline *hgrp; // [rsp+80h] [rbp-518h]
		  List_1_T_Enumerator_System_Object_ *v76; // [rsp+88h] [rbp-510h]
		  _BYTE v77[40]; // [rsp+90h] [rbp-508h] BYREF
		  HGRenderGraph *renderGraph; // [rsp+B8h] [rbp-4E0h]
		  List_1_T_Enumerator_System_Object_ v79; // [rsp+C0h] [rbp-4D8h] BYREF
		  ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ v80; // [rsp+E0h] [rbp-4B8h] BYREF
		  TextureDesc v81; // [rsp+100h] [rbp-498h] BYREF
		  Il2CppExceptionWrapper *v82; // [rsp+160h] [rbp-438h] BYREF
		  RenderTargetIdentifier v83; // [rsp+170h] [rbp-428h] BYREF
		  _OWORD v84[2]; // [rsp+1A0h] [rbp-3F8h] BYREF
		  __int64 v85; // [rsp+1C0h] [rbp-3D8h]
		  TextureDesc v86; // [rsp+1D0h] [rbp-3C8h] BYREF
		  TextureDesc v87; // [rsp+230h] [rbp-368h] BYREF
		  HGCamera *camera; // [rsp+290h] [rbp-308h] BYREF
		  HGCamera *v89; // [rsp+298h] [rbp-300h]
		  HGIrradianceVolumePipelineUpdateResult result; // [rsp+438h] [rbp-160h] BYREF
		  HGIrradianceVolumePipelineUpdateResultV2 v91; // [rsp+490h] [rbp-108h] BYREF
		
		  sub_18033B9D0(&camera, 0LL, 640LL);
		  memset(&v77[8], 0, 32);
		  memset(&v79, 0, sizeof(v79));
		  if ( IFix::WrappersManagerImpl::IsPatched(1179, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1179, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v67, v66);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_458(Patch, (Object *)this, renderPathParams, skipRender, 0LL);
		  }
		  else
		  {
		    v7 = renderPathParams->hgrp;
		    hgrp = v7;
		    p_renderRequest = &renderPathParams->renderRequest;
		    p_camera = &camera;
		    v10 = 5LL;
		    do
		    {
		      *(_OWORD *)p_camera = *(_OWORD *)&p_renderRequest->hgCamera;
		      *((_OWORD *)p_camera + 1) = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      *((_OWORD *)p_camera + 2) = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      *((_OWORD *)p_camera + 3) = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      *((_OWORD *)p_camera + 4) = *(_OWORD *)&p_renderRequest->target.face;
		      *((_OWORD *)p_camera + 5) = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      *((_OWORD *)p_camera + 6) = p_renderRequest->cullingResults.cullingResults;
		      p_camera += 16;
		      *((_OWORD *)p_camera - 1) = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      --v10;
		    }
		    while ( v10 );
		    if ( !v7 )
		      sub_1800D8260(p_camera, 0LL);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(v7, 0LL);
		    v14 = camera;
		    if ( !v89 || (IsUICamera = HG::Rendering::Runtime::HGCamera::IsUICamera(v89, 0LL), v16 = v89, !IsUICamera) )
		      v16 = 0LL;
		    commandBuffer = renderPathParams->renderGraphParams.commandBuffer;
		    m_Ptr = renderPathParams->renderGraphParams.scriptableRenderContext.m_Ptr;
		    this->fields.m_trackingCamera = v14;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_trackingCamera, v11, v12, v13, cmd);
		    this->fields.m_trackingBackBufferState = 0;
		    HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolume(
		      this,
		      &result,
		      renderPathParams->renderGraphParams.currentFrameIndex,
		      v14,
		      commandBuffer,
		      0LL);
		    HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolumeV2(
		      this,
		      &v91,
		      renderPathParams->renderGraphParams.currentFrameIndex,
		      v14,
		      commandBuffer,
		      0LL);
		    HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalCB(
		      this,
		      hgrp,
		      v14,
		      commandBuffer,
		      (ScriptableRenderContext)m_Ptr,
		      0LL);
		    if ( !v14 )
		      sub_1800D8260(v20, v19);
		    HG::Rendering::Runtime::HGCamera::OnRecordingBegin(v14, 0LL);
		    if ( v16 )
		      HG::Rendering::Runtime::HGCamera::OnRecordingBegin(v16, 0LL);
		    if ( !v14->fields.camera )
		      sub_1800D8260(v22, v21);
		    targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(v14->fields.camera, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    v24 = UnityEngine::Object::op_Inequality(targetTexture, 0LL, 0LL);
		    sub_18033B9D0(&v81, 0LL, 96LL);
		    if ( v24 )
		    {
		      if ( !v14->fields.camera )
		        sub_1800D8260(v26, v25);
		      v27 = UnityEngine::Camera::get_targetTexture(v14->fields.camera, 0LL);
		      if ( !v27 )
		        sub_1800D8260(v29, v28);
		      v81.width = sub_180002F70(5LL, v27);
		      if ( !v14->fields.camera )
		        sub_1800D8260(v31, v30);
		      v32 = UnityEngine::Camera::get_targetTexture(v14->fields.camera, 0LL);
		      if ( !v32 )
		        sub_1800D8260(v34, v33);
		      v81.height = sub_180002F70(7LL, v32);
		      if ( !targetTexture )
		        sub_1800D8260(v36, v35);
		      graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)targetTexture, 0LL);
		    }
		    else
		    {
		      v81.width = UnityEngine::Screen::get_width(0LL);
		      v81.height = UnityEngine::Screen::get_height(0LL);
		      graphicsFormat = GraphicsFormat__Enum_R8G8B8A8_UNorm;
		    }
		    v81.colorFormat = graphicsFormat;
		    v81.dimension = 2;
		    v81.slices = 1;
		    v81.msaaSamples = 1;
		    v87 = v81;
		    v86 = v81;
		    if ( v24 )
		    {
		      if ( !targetTexture )
		        sub_1800D8260(v39, v38);
		      v86.colorFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)targetTexture, 0LL);
		      memset(&v74, 0, sizeof(v74));
		      v80.Item1 = (TextureHandle)*UnityEngine::RenderTexture::get_colorBuffer(
		                                    (RenderBuffer *)&v80,
		                                    (RenderTexture *)targetTexture,
		                                    0LL);
		      UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
		        &v74,
		        (RenderBuffer *)&v80,
		        0,
		        CubemapFace__Enum_Unknown,
		        0,
		        0LL);
		      v40 = *(_OWORD *)&v74.m_Type;
		      v41 = *(_OWORD *)&v74.m_BufferPointer;
		      v42 = *(_QWORD *)&v74.m_DepthSlice;
		      memset(&v74, 0, sizeof(v74));
		      v80.Item1 = (TextureHandle)*UnityEngine::RenderTexture::get_depthBuffer(
		                                    (RenderBuffer *)&v80,
		                                    (RenderTexture *)targetTexture,
		                                    0LL);
		      UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
		        &v74,
		        (RenderBuffer *)&v80,
		        0,
		        CubemapFace__Enum_Unknown,
		        0,
		        0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v86.colorFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
		                          GraphicsFormat__Enum_D24_UNorm_S8_UInt,
		                          0LL);
		      *(_OWORD *)&v74.m_Type = 0xFFFFFFFF00000002uLL;
		      v74.m_BufferPointer = 0LL;
		      *(_QWORD *)&v74.m_MipLevel = 0xFFFFFFFF00000000uLL;
		      v40 = 0xFFFFFFFF00000002uLL;
		      v41 = *(_OWORD *)&v74.m_BufferPointer;
		      v42 = 0LL;
		      *(_QWORD *)&v74.m_InstanceID = 0LL;
		      *(_QWORD *)&v74.m_DepthSlice = 0LL;
		      v74.m_Type = 3;
		      v74.m_BufferPointer = 0LL;
		      *(_QWORD *)&v74.m_MipLevel = 0xFFFFFFFF00000000uLL;
		    }
		    if ( !renderGraph )
		      sub_1800D8260(v44, v43);
		    *(_OWORD *)&v83.m_Type = v40;
		    *(_OWORD *)&v83.m_BufferPointer = v41;
		    *(_QWORD *)&v83.m_DepthSlice = v42;
		    v45 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportBackbuffer(
		            &v80,
		            renderGraph,
		            &v83,
		            &v74,
		            &v87,
		            &v86,
		            v24,
		            0LL);
		    Item2 = v45->Item2;
		    this->fields._backBufferColor_k__BackingField = v45->Item1;
		    this->fields._backBufferDepth_k__BackingField = Item2;
		    this->fields._firstBackbufferPass_k__BackingField = sub_180002F70(7LL, this);
		    msaaEnabled = HG::Rendering::Runtime::HGCamera::get_msaaEnabled(v14, 0LL);
		    taauRTSize_k__BackingField = (MethodInfo *)v14->fields._taauRTSize_k__BackingField;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    methoda = taauRTSize_k__BackingField;
		    v49 = renderGraph;
		    this->fields._intermediateBackBuffer_k__BackingField = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
		                                                              &v80.Item1,
		                                                              renderGraph,
		                                                              v14,
		                                                              msaaEnabled,
		                                                              GraphicsFormat__Enum_R8G8B8A8_UNorm,
		                                                              (Vector2Int)methoda,
		                                                              0LL);
		    sub_180073530(9LL, this, renderPathParams);
		    memset(&v77[8], 0, 32);
		    *(_QWORD *)v77 = v14;
		    sub_18002D1B0((SingleFieldAccessor *)v77, v50, v51, v52, cmda);
		    *(_QWORD *)&v77[8] = v16;
		    sub_18002D1B0((SingleFieldAccessor *)&v77[8], v53, v54, v55, cmdb);
		    *(_QWORD *)&v77[16] = v49;
		    sub_18002D1B0((SingleFieldAccessor *)&v77[16], v56, v57, v58, cmdc);
		    *(_QWORD *)&v77[24] = hgrp;
		    sub_18002D1B0((SingleFieldAccessor *)&v77[24], v59, v60, v61, cmdd);
		    v77[32] = skipRender;
		    v84[0] = *(_OWORD *)v77;
		    v84[1] = *(_OWORD *)&v77[16];
		    v85 = *(_QWORD *)&v77[32];
		    if ( !*(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 )
		      sub_1800D8260(v63, v62);
		    v79 = *(List_1_T_Enumerator_System_Object_ *)sub_180368A78(
		                                                   &v80,
		                                                   *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00);
		    hgrp = 0LL;
		    v76 = &v79;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v79,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
		      {
		        if ( !v79._current )
		          sub_1800D8250(0LL, v64);
		        sub_189BDB7D0(v79._current, v84);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v82 )
		    {
		      hgrp = (HGRenderPipeline *)v82->ex;
		      if ( hgrp )
		        sub_18007E1E0(hgrp);
		    }
		  }
		}
		
		internal void Render(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BDD8E8-0x0000000189BDDDB0
		// Void Render(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGRenderPathBase::Render(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // rdi
		  HGRenderPathBase *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraph *renderGraph; // rsi
		  char v8; // r14
		  HGCamera *renderPathInstance_k__BackingField; // rcx
		  __int64 *v10; // rdx
		  IPassConstructor *v11; // rsi
		  __int64 v12; // rax
		  char v13; // r15
		  HGCamera *v14; // r12
		  char v15; // al
		  HGCamera *LightWeightCamera; // rax
		  HGCamera *v17; // rsi
		  HGRenderPathBase_HGRenderPathParams *v18; // rax
		  HGRenderPathBase_HGRenderPathParams *p_renderPathParamsa; // rcx
		  __int64 v20; // rdx
		  int v21; // eax
		  unsigned __int64 v22; // r9
		  signed __int64 v23; // rtt
		  unsigned __int64 v24; // r9
		  signed __int64 v25; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int64 v29; // [rsp+0h] [rbp-358h] BYREF
		  char v30; // [rsp+20h] [rbp-338h]
		  Il2CppException *ex; // [rsp+28h] [rbp-330h]
		  char *v32; // [rsp+30h] [rbp-328h]
		  HGRenderGraph *v33; // [rsp+38h] [rbp-320h]
		  IPassConstructor *pass; // [rsp+40h] [rbp-318h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+48h] [rbp-310h] BYREF
		  Il2CppExceptionWrapper *v36; // [rsp+50h] [rbp-308h] BYREF
		  Il2CppExceptionWrapper *v37; // [rsp+58h] [rbp-300h] BYREF
		  HGRenderPathBase_HGRenderPathParams renderPathParamsa; // [rsp+60h] [rbp-2F8h] BYREF
		  char v41; // [rsp+378h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v41 = 0;
		  pass = 0LL;
		  sub_18033B9D0(&renderPathParamsa, 0LL, 712LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(1177, 0LL) )
		  {
		    if ( !v3->hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(v3->hgrp, 0LL);
		    v33 = renderGraph;
		    sub_1800049A0(v4->klass);
		    v8 = ((__int64 (__fastcall *)(HGRenderPathBase *, HGRenderPathBase_HGRenderPathParams *, Il2CppMethodPointer))v4->klass->vtable.SkipRender.method)(
		           v4,
		           v3,
		           v4->klass->vtable.GetDefaultFirstBackbufferPass.methodPtr);
		    v30 = v8;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
		    ex = 0LL;
		    v32 = &v41;
		    try
		    {
		      HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(v4, v3, v8, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v35 )
		    {
		      v10 = &v29;
		      ex = v35->ex;
		      renderPathInstance_k__BackingField = (HGCamera *)ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      renderGraph = v33;
		      v8 = v30;
		    }
		    if ( renderGraph )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterCallbackOwner(
		        renderGraph,
		        (IRenderGraphCallbackOwner *)v4,
		        0LL);
		      if ( !v8 )
		      {
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)1u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
		        ex = 0LL;
		        v32 = &v41;
		        try
		        {
		          sub_180073530(10LL, v4, v3);
		        }
		        catch ( Il2CppExceptionWrapper *v36 )
		        {
		          ex = v36->ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v3 = renderPathParams;
		          v4 = this;
		          v8 = v30;
		        }
		        goto LABEL_31;
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(renderGraph, 0LL);
		      if ( HG::Rendering::Runtime::HGRenderPathBase::TryGetPassConstructor(
		             v4,
		             PassConstructorID__Enum_VolumetricFog,
		             &pass,
		             0LL) )
		      {
		        v11 = pass;
		        v12 = *(_QWORD *)&v4[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		        if ( !v12 )
		          goto LABEL_40;
		        v13 = *(_BYTE *)(v12 + 1640);
		        v14 = *(HGCamera **)&v4[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		        if ( !pass
		          || !(unsigned __int8)sub_180005080(
		                                 pass->klass,
		                                 TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor)
		          || !v11 )
		        {
		          goto LABEL_40;
		        }
		        v15 = sub_180005080(v11->klass, TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
		        HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructSkipRender(
		          (VolumetricFogPassConstructor *)((unsigned __int64)v11 & -(__int64)(v15 != 0)),
		          v13,
		          v14,
		          0LL);
		      }
		      renderPathInstance_k__BackingField = *(HGCamera **)&v4[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		      if ( renderPathInstance_k__BackingField )
		      {
		        LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(
		                              renderPathInstance_k__BackingField,
		                              0LL);
		        v17 = LightWeightCamera;
		        if ( !LightWeightCamera )
		          goto LABEL_31;
		        renderPathInstance_k__BackingField = *(HGCamera **)&v4[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		        if ( renderPathInstance_k__BackingField )
		        {
		          HG::Rendering::Runtime::HGCamera::TransferWaterMarkRTs(
		            renderPathInstance_k__BackingField,
		            LightWeightCamera,
		            0LL);
		          v18 = v3;
		          p_renderPathParamsa = &renderPathParamsa;
		          v20 = 5LL;
		          do
		          {
		            *(_OWORD *)&p_renderPathParamsa->skipRender = *(_OWORD *)&v18->skipRender;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.hgCamera = *(_OWORD *)&v18->renderRequest.hgCamera;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.clearCameraSettings = *(_OWORD *)&v18->renderRequest.clearCameraSettings;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.target.id.m_InstanceID = *(_OWORD *)&v18->renderRequest.target.id.m_InstanceID;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.target.id.m_MipLevel = *(_OWORD *)&v18->renderRequest.target.id.m_MipLevel;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.target.face = *(_OWORD *)&v18->renderRequest.target.face;
		            *(_OWORD *)&p_renderPathParamsa->renderRequest.target.targetDepth = *(_OWORD *)&v18->renderRequest.target.targetDepth;
		            p_renderPathParamsa = (HGRenderPathBase_HGRenderPathParams *)((char *)p_renderPathParamsa + 128);
		            p_renderPathParamsa[-1].perFrameSetup = (HGRenderPathBase_PerFrameSetup)v18->renderRequest.cullingResults.cullingResults;
		            v18 = (HGRenderPathBase_HGRenderPathParams *)((char *)v18 + 128);
		            --v20;
		          }
		          while ( v20 );
		          *(_OWORD *)&p_renderPathParamsa->skipRender = *(_OWORD *)&v18->skipRender;
		          *(_OWORD *)&p_renderPathParamsa->renderRequest.hgCamera = *(_OWORD *)&v18->renderRequest.hgCamera;
		          *(_OWORD *)&p_renderPathParamsa->renderRequest.clearCameraSettings = *(_OWORD *)&v18->renderRequest.clearCameraSettings;
		          *(_OWORD *)&p_renderPathParamsa->renderRequest.target.id.m_InstanceID = *(_OWORD *)&v18->renderRequest.target.id.m_InstanceID;
		          *(_QWORD *)&p_renderPathParamsa->renderRequest.target.id.m_MipLevel = *(_QWORD *)&v18->renderRequest.target.id.m_MipLevel;
		          renderPathParamsa.renderRequest.hgCamera = v17;
		          v21 = dword_18F35FD08;
		          v10 = qword_18F0BCBA0;
		          if ( dword_18F35FD08 )
		          {
		            v22 = (((unsigned __int64)&renderPathParamsa.renderRequest >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v22 + 36190]);
		            do
		              v23 = qword_18F0BCBA0[v22 + 36190];
		            while ( v23 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v22 + 36190],
		                             v23 | (1LL << (((unsigned __int64)&renderPathParamsa.renderRequest >> 12) & 0x3F)),
		                             v23) );
		            v21 = dword_18F35FD08;
		          }
		          renderPathParamsa.renderRequest.hgLWCamera = 0LL;
		          if ( v21 )
		          {
		            v24 = (((unsigned __int64)&renderPathParamsa.renderRequest.hgLWCamera >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		            do
		              v25 = qword_18F0BCBA0[v24 + 36190];
		            while ( v25 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v24 + 36190],
		                             v25 | (1LL << (((unsigned __int64)&renderPathParamsa.renderRequest.hgLWCamera >> 12) & 0x3F)),
		                             v25) );
		          }
		          renderPathInstance_k__BackingField = (HGCamera *)v17->fields._renderPathInstance_k__BackingField;
		          if ( renderPathInstance_k__BackingField )
		          {
		            HG::Rendering::Runtime::HGRenderPathBase::Render(
		              (HGRenderPathBase *)renderPathInstance_k__BackingField,
		              &renderPathParamsa,
		              0LL);
		LABEL_31:
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)2u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
		            ex = 0LL;
		            v32 = &v41;
		            try
		            {
		              HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(v4, v3, v8, 0LL);
		            }
		            catch ( Il2CppExceptionWrapper *v37 )
		            {
		              ex = v37->ex;
		              if ( ex )
		                sub_18007E1E0(ex);
		            }
		            return;
		          }
		        }
		      }
		    }
		LABEL_40:
		    sub_1800D8250(renderPathInstance_k__BackingField, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1177, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v28, v27);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, v3, 0LL);
		}
		
		[IDTag(1)]
		private void OnPostRendering(ref HGRenderPathParams renderPathParams, bool skipRender) {} // 0x0000000189BDC82C-0x0000000189BDCB1C
		// Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(
		        HGRenderPathBase *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        bool skipRender,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v5; // rdi
		  Object *v6; // r14
		  HGRenderPipeline *hgrp; // r15
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  HGCamera **v9; // rcx
		  __int64 v10; // rdx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  HGRenderGraph *renderGraph; // r13
		  HGCamera *v15; // rsi
		  HGCamera *v16; // rbx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // rdx
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  MethodInfo *v34; // [rsp+20h] [rbp-358h]
		  MethodInfo *v35; // [rsp+20h] [rbp-358h]
		  MethodInfo *v36; // [rsp+20h] [rbp-358h]
		  MethodInfo *v37; // [rsp+20h] [rbp-358h]
		  _BYTE v38[40]; // [rsp+30h] [rbp-348h] BYREF
		  List_1_T_Enumerator_System_Object_ v39; // [rsp+58h] [rbp-320h] BYREF
		  HGCamera *v40; // [rsp+70h] [rbp-308h]
		  HGCamera *v41; // [rsp+78h] [rbp-300h]
		  _QWORD v42[3]; // [rsp+80h] [rbp-2F8h] BYREF
		  Il2CppExceptionWrapper *v43; // [rsp+98h] [rbp-2E0h] BYREF
		  _OWORD v44[2]; // [rsp+A0h] [rbp-2D8h] BYREF
		  __int64 v45; // [rsp+C0h] [rbp-2B8h]
		  HGCamera *v46; // [rsp+D0h] [rbp-2A8h] BYREF
		  HGCamera *v47; // [rsp+D8h] [rbp-2A0h]
		
		  v5 = renderPathParams;
		  v6 = (Object *)this;
		  memset(&v39, 0, sizeof(v39));
		  if ( IFix::WrappersManagerImpl::IsPatched(1205, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1205, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v33, v32);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_458(Patch, v6, v5, skipRender, 0LL);
		  }
		  else
		  {
		    hgrp = v5->hgrp;
		    p_renderRequest = &v5->renderRequest;
		    v9 = &v46;
		    v10 = 5LL;
		    do
		    {
		      *(_OWORD *)v9 = *(_OWORD *)&p_renderRequest->hgCamera;
		      *((_OWORD *)v9 + 1) = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      *((_OWORD *)v9 + 2) = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      *((_OWORD *)v9 + 3) = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      *((_OWORD *)v9 + 4) = *(_OWORD *)&p_renderRequest->target.face;
		      *((_OWORD *)v9 + 5) = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      *((_OWORD *)v9 + 6) = p_renderRequest->cullingResults.cullingResults;
		      v9 += 16;
		      *((_OWORD *)v9 - 1) = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      --v10;
		    }
		    while ( v10 );
		    if ( !hgrp )
		      sub_1800D8260(v9, 0LL);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v15 = v46;
		    v40 = v46;
		    v16 = v47;
		    if ( !v47 || !HG::Rendering::Runtime::HGCamera::IsUICamera(v47, 0LL) )
		      v16 = 0LL;
		    v41 = v16;
		    memset(&v38[8], 0, 32);
		    *(_QWORD *)v38 = v15;
		    sub_18002D1B0((SingleFieldAccessor *)v38, v11, v12, v13, v34);
		    *(_QWORD *)&v38[8] = v16;
		    sub_18002D1B0((SingleFieldAccessor *)&v38[8], v17, v18, v19, v35);
		    *(_QWORD *)&v38[16] = renderGraph;
		    sub_18002D1B0((SingleFieldAccessor *)&v38[16], v20, v21, v22, v36);
		    *(_QWORD *)&v38[24] = hgrp;
		    sub_18002D1B0((SingleFieldAccessor *)&v38[24], v23, v24, v25, v37);
		    v38[32] = skipRender;
		    v44[0] = *(_OWORD *)v38;
		    v44[1] = *(_OWORD *)&v38[16];
		    v45 = *(_QWORD *)&v38[32];
		    if ( !v6[292].monitor )
		      sub_1800D8260(v27, v26);
		    v39 = *(List_1_T_Enumerator_System_Object_ *)sub_180368A78(v42, v6[292].monitor);
		    v42[0] = 0LL;
		    v42[1] = &v39;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v39,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
		      {
		        if ( !v39._current )
		          sub_1800D8250(0LL, v28);
		        sub_189BDB424(v39._current, v44);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v43 )
		    {
		      v42[0] = v43->ex;
		      if ( v42[0] )
		        sub_18007E1E0(v42[0]);
		      v5 = renderPathParams;
		      v6 = (Object *)this;
		      v15 = v40;
		      v16 = v41;
		    }
		    sub_180073530(11LL, v6, v5);
		    if ( !v15 )
		      sub_1800D8250(v30, v29);
		    HG::Rendering::Runtime::HGCamera::OnRecordingEnd(v15, 0LL);
		    if ( v16 )
		      HG::Rendering::Runtime::HGCamera::OnRecordingEnd(v16, 0LL);
		  }
		}
		
		internal void RecordAndExecute(HGRenderPipeline hgrp, [IsReadOnly] in HGRenderPipeline.RenderRequest renderRequest, string executionName, int frameIndex, bool rendererListCulling, ScriptableRenderContext srp, CommandBuffer cmd) {} // 0x0000000189BDD4A8-0x0000000189BDD8E8
		// Void RecordAndExecute(HGRenderPipeline, HGRenderPipeline+RenderRequest ByRef, String, Int32, Boolean, ScriptableRenderContext, CommandBuffer)
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		void HG::Rendering::Runtime::HGRenderPathBase::RecordAndExecute(
		        HGRenderPathBase *this,
		        HGRenderPipeline *hgrp,
		        HGRenderPipeline_RenderRequest *renderRequest,
		        String *executionName,
		        int32_t frameIndex,
		        bool rendererListCulling,
		        ScriptableRenderContext srp,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  __int128 v17; // xmm6
		  FieldAccessorBase__Fields v18; // xmm7
		  Action_2_Google_Protobuf_IMessage_Object_ *v19; // xmm8_8
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  MonitorData **p_monitor; // rax
		  __int64 v27; // rsi
		  __int64 v28; // rcx
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  HGRenderPathBase_HGRenderPathParams *p_renderPathParams; // rcx
		  _OWORD *v35; // rax
		  HGRenderGraph *renderGraph; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  MethodInfo *P3; // [rsp+20h] [rbp-6A8h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-6A8h]
		  MethodInfo *P3c; // [rsp+20h] [rbp-6A8h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-6A8h]
		  MethodInfo *P3d; // [rsp+20h] [rbp-6A8h]
		  HGRenderPathBase_PerFrameSetup v47; // [rsp+50h] [rbp-678h] BYREF
		  int v48; // [rsp+60h] [rbp-668h] BYREF
		  HGRenderGraph *v49; // [rsp+68h] [rbp-660h] BYREF
		  HGRenderGraphParameters v50; // [rsp+70h] [rbp-658h] BYREF
		  __int64 v51; // [rsp+98h] [rbp-630h] BYREF
		  HGRenderPathBase_PerFrameSetup v52; // [rsp+A0h] [rbp-628h]
		  Il2CppExceptionWrapper *v53; // [rsp+B0h] [rbp-618h] BYREF
		  HGRenderGraphParameters parameters; // [rsp+C0h] [rbp-608h] BYREF
		  _BYTE v55[8]; // [rsp+F0h] [rbp-5D8h] BYREF
		  SingleFieldAccessor v56[11]; // [rsp+F8h] [rbp-5D0h] BYREF
		  SingleFieldAccessor v57; // [rsp+380h] [rbp-348h] BYREF
		  HGRenderPathBase_HGRenderPathParams renderPathParams; // [rsp+3C0h] [rbp-308h] BYREF
		  HGRenderPathBase *v59; // [rsp+6D0h] [rbp+8h] BYREF
		
		  v59 = this;
		  v49 = 0LL;
		  v48 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1175, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1175, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v40, v39);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_460(
		      Patch,
		      (Object *)v59,
		      (Object *)hgrp,
		      renderRequest,
		      (Object *)executionName,
		      frameIndex,
		      rendererListCulling,
		      srp,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    memset(&v50.scriptableRenderContext, 0, 24);
		    *(_OWORD *)&v50.executionName = (unsigned __int64)executionName;
		    sub_18002D1B0((SingleFieldAccessor *)&v50, v12, v13, v14, P3);
		    v50.currentFrameIndex = frameIndex;
		    v50.rendererListCulling = rendererListCulling;
		    *(_OWORD *)&v50.scriptableRenderContext.m_Ptr = __PAIR128__((unsigned __int64)cmd, (unsigned __int64)srp.m_Ptr);
		    sub_18002D1B0((SingleFieldAccessor *)&v50.commandBuffer, v15, v16, (Int32__Array **)(unsigned int)frameIndex, P3b);
		    *(_QWORD *)&v50.executorID = *(_QWORD *)&v59->fields._renderPathID_k__BackingField;
		    v17 = *(_OWORD *)&v50.executionName;
		    parameters = v50;
		    v18 = *(FieldAccessorBase__Fields *)&v50.scriptableRenderContext.m_Ptr;
		    v19 = *(Action_2_Google_Protobuf_IMessage_Object_ **)&v50.executorID;
		    sub_18033B9D0(v55, 0LL, 712LL);
		    v56[0].klass = (SingleFieldAccessor__Class *)hgrp;
		    sub_18002D1B0(v56, v20, v21, v22, P3c);
		    p_monitor = &v56[0].monitor;
		    v27 = 5LL;
		    v28 = 5LL;
		    do
		    {
		      *(_OWORD *)p_monitor = *(_OWORD *)&renderRequest->hgCamera;
		      *((_OWORD *)p_monitor + 1) = *(_OWORD *)&renderRequest->clearCameraSettings;
		      *((_OWORD *)p_monitor + 2) = *(_OWORD *)&renderRequest->target.id.m_InstanceID;
		      *((_OWORD *)p_monitor + 3) = *(_OWORD *)&renderRequest->target.id.m_MipLevel;
		      *((_OWORD *)p_monitor + 4) = *(_OWORD *)&renderRequest->target.face;
		      *((_OWORD *)p_monitor + 5) = *(_OWORD *)&renderRequest->target.targetDepth;
		      *((_OWORD *)p_monitor + 6) = renderRequest->cullingResults.cullingResults;
		      p_monitor += 16;
		      *((_OWORD *)p_monitor - 1) = *(_OWORD *)&renderRequest->cullingResults.customPassCullingResults.hasValue;
		      renderRequest = (HGRenderPipeline_RenderRequest *)((char *)renderRequest + 128);
		      --v28;
		    }
		    while ( v28 );
		    sub_18002D1B0((SingleFieldAccessor *)&v56[0].monitor, v23, v24, v25, P3a);
		    *(_OWORD *)&v57.klass = v17;
		    v57.fields._ = v18;
		    v57.fields.setValueDelegate = v19;
		    sub_18002D1B0(&v57, v29, v30, v31, P3d);
		    if ( !hgrp )
		      sub_1800D8260(v33, v32);
		    *(HGRenderPathBase_PerFrameSetup *)&v57.fields.clearDelegate = *HG::Rendering::Runtime::HGRenderPathBase::PreparePerFrameSetup(
		                                                                      &v47,
		                                                                      hgrp->fields._settingParameters_k__BackingField,
		                                                                      0LL);
		    p_renderPathParams = &renderPathParams;
		    v35 = v55;
		    do
		    {
		      *(_OWORD *)&p_renderPathParams->skipRender = *v35;
		      *(_OWORD *)&p_renderPathParams->renderRequest.hgCamera = v35[1];
		      *(_OWORD *)&p_renderPathParams->renderRequest.clearCameraSettings = v35[2];
		      *(_OWORD *)&p_renderPathParams->renderRequest.target.id.m_InstanceID = v35[3];
		      *(_OWORD *)&p_renderPathParams->renderRequest.target.id.m_MipLevel = v35[4];
		      *(_OWORD *)&p_renderPathParams->renderRequest.target.face = v35[5];
		      *(_OWORD *)&p_renderPathParams->renderRequest.target.targetDepth = v35[6];
		      p_renderPathParams = (HGRenderPathBase_HGRenderPathParams *)((char *)p_renderPathParams + 128);
		      p_renderPathParams[-1].perFrameSetup = (HGRenderPathBase_PerFrameSetup)v35[7];
		      v35 += 8;
		      --v27;
		    }
		    while ( v27 );
		    *(_OWORD *)&p_renderPathParams->skipRender = *v35;
		    *(_OWORD *)&p_renderPathParams->renderRequest.hgCamera = v35[1];
		    *(_OWORD *)&p_renderPathParams->renderRequest.clearCameraSettings = v35[2];
		    *(_OWORD *)&p_renderPathParams->renderRequest.target.id.m_InstanceID = v35[3];
		    *(_QWORD *)&p_renderPathParams->renderRequest.target.id.m_MipLevel = *((_QWORD *)v35 + 8);
		    *(_QWORD *)&v47.depthGraphicsFormat = &v59;
		    v47.settingParametersCpp = (HGSettingParametersCpp *)&v48;
		    v51 = 0LL;
		    v52 = v47;
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    if ( !renderGraph )
		      sub_1800D8250(v38, v37);
		    v49 = HG::Rendering::RenderGraphModule::HGRenderGraph::RecordAndExecute(renderGraph, &parameters, 0LL).renderGraph;
		    *(_QWORD *)&v47.depthGraphicsFormat = 0LL;
		    v47.settingParametersCpp = (HGSettingParametersCpp *)&v49;
		    try
		    {
		      HG::Rendering::Runtime::HGRenderPathBase::Render(v59, &renderPathParams, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v53 )
		    {
		      *(Il2CppExceptionWrapper *)&v47.depthGraphicsFormat = (Il2CppExceptionWrapper)v53->ex;
		    }
		    sub_18026AE00(&v47);
		    sub_18026B5D0(&v51);
		  }
		}
		
		protected virtual void OnSwitchRenderPath(HGRenderPathInternal prevRenderPath) {} // 0x0000000189BDD454-0x0000000189BDD4A8
		// Void OnSwitchRenderPath(HGRenderPathInternal)
		void HG::Rendering::Runtime::HGRenderPathBase::OnSwitchRenderPath(
		        HGRenderPathBase *this,
		        HGRenderPathInternal__Enum prevRenderPath,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3554, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3554, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      prevRenderPath,
		      0LL);
		  }
		}
		
		public static PerFrameSetup PreparePerFrameSetup(HGSettingParameters settingParameters) => default; // 0x00000001837E02E0-0x00000001837E04A0
		// HGRenderPathBase+PerFrameSetup PreparePerFrameSetup(HGSettingParameters)
		HGRenderPathBase_PerFrameSetup *HG::Rendering::Runtime::HGRenderPathBase::PreparePerFrameSetup(
		        HGRenderPathBase_PerFrameSetup *__return_ptr retstr,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  SettingParameter_1_System_Boolean_ *depthCombinedWithStencil_k__BackingField; // rdi
		  struct MethodInfo *v8; // rsi
		  Il2CppClass *klass; // rax
		  SettingParameter_1_UnityEngine_Rendering_DepthBits_ *depthBitsGBuffer_k__BackingField; // rbx
		  struct MethodInfo *v11; // rdi
		  Il2CppClass *v12; // rax
		  Il2CppClass *v13; // rcx
		  int32_t paramValue_k__BackingField; // eax
		  GraphicsFormat__Enum v15; // ecx
		  HGRenderPathBase_PerFrameSetup v16; // xmm0
		  HGRenderPathBase_PerFrameSetup *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rax
		  Int32Enum__Enum v20; // eax
		  __int64 v21; // rax
		  HGRenderPathBase_PerFrameSetup v22; // [rsp+20h] [rbp-28h] BYREF
		  DepthBits__Enum depthBits; // [rsp+50h] [rbp+8h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  depthBits = DepthBits__Enum_None;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_27;
		  if ( wrapperArray->max_length.size > 883 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		    if ( !v4 )
		      goto LABEL_27;
		    if ( LODWORD(v4->_0.namespaze) <= 0x373 )
		      sub_1800D2AB0(v4, wrapperArray);
		    if ( v4[18].vtable.Finalize.methodPtr )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(883, 0LL);
		      if ( Patch )
		      {
		        v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_348(&v22, Patch, (Object *)settingParameters, 0LL);
		        goto LABEL_26;
		      }
		      goto LABEL_27;
		    }
		  }
		  if ( !settingParameters )
		    goto LABEL_27;
		  depthCombinedWithStencil_k__BackingField = settingParameters->fields._depthCombinedWithStencil_k__BackingField;
		  v8 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !depthCombinedWithStencil_k__BackingField )
		    goto LABEL_27;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v19 = sub_18011C4C0(v8->klass);
		    (**(void (***)(void))(*(_QWORD *)(v19 + 192) + 48LL))();
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v8->klass;
		  if ( ((__int64)v4->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v4, wrapperArray);
		  if ( !depthCombinedWithStencil_k__BackingField->fields._paramValue_k__BackingField )
		  {
		    v20 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._depthBitsGBuffer_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
		    if ( v20 == 16 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v15 = GraphicsFormat__Enum_D16_UNorm;
		    }
		    else if ( v20 == 24 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v15 = GraphicsFormat__Enum_D24_UNorm;
		    }
		    else
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v15 = GraphicsFormat__Enum_D32_SFloat;
		    }
		    goto LABEL_25;
		  }
		  depthBitsGBuffer_k__BackingField = settingParameters->fields._depthBitsGBuffer_k__BackingField;
		  v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit;
		  if ( !depthBitsGBuffer_k__BackingField )
		LABEL_27:
		    sub_1800D8260(v4, wrapperArray);
		  v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit->klass;
		  if ( ((__int64)v12->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit->klass,
		      wrapperArray);
		  if ( !*((_QWORD *)v12->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v21 = sub_18011C4C0(v11->klass);
		    (**(void (***)(void))(*(_QWORD *)(v21 + 192) + 48LL))();
		  }
		  v13 = v11->klass;
		  if ( ((__int64)v13->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v13, wrapperArray);
		  paramValue_k__BackingField = depthBitsGBuffer_k__BackingField->fields._paramValue_k__BackingField;
		  if ( paramValue_k__BackingField == 24 )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v15 = GraphicsFormat__Enum_D24_UNorm_S8_UInt;
		    goto LABEL_25;
		  }
		  if ( paramValue_k__BackingField != 32 )
		  {
		    if ( TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		      goto LABEL_24;
		    goto LABEL_28;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		LABEL_28:
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		LABEL_24:
		  v15 = GraphicsFormat__Enum_D32_SFloat_S8_UInt;
		LABEL_25:
		  v22.depthGraphicsFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v15, &depthBits, 0LL);
		  v22.depthBits = depthBits;
		  v22.settingParametersCpp = 0LL;
		  v16 = (HGRenderPathBase_PerFrameSetup)*(unsigned __int64 *)&v22.depthGraphicsFormat;
		LABEL_26:
		  result = retstr;
		  *retstr = v16;
		  return result;
		}
		
		public bool TryGetPassConstructor(PassConstructorID id, out IPassConstructor pass) {
			pass = default;
			return default;
		} // 0x0000000189BDDE08-0x0000000189BDDEB4
		// Boolean TryGetPassConstructor(PassConstructorID, IPassConstructor ByRef)
		bool HG::Rendering::Runtime::HGRenderPathBase::TryGetPassConstructor(
		        HGRenderPathBase *this,
		        PassConstructorID__Enum id,
		        IPassConstructor **pass,
		        MethodInfo *method)
		{
		  __int64 v4; // rsi
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  List_1_System_Object_ *v10; // rcx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-18h]
		
		  v4 = (int)id;
		  if ( IFix::WrappersManagerImpl::IsPatched(1201, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1201, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_459(
		             Patch,
		             (Object *)this,
		             (PassConstructorID__Enum)v4,
		             pass,
		             0LL);
		  }
		  else
		  {
		    v9 = (Type *)*(unsigned int *)(*(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20
		                                 + 4 * v4);
		    if ( (_DWORD)v9 != -1 )
		    {
		      v10 = *(List_1_System_Object_ **)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		      if ( v10 )
		      {
		        *pass = (IPassConstructor *)System::Collections::Generic::List<System::Object>::get_Item(
		                                      v10,
		                                      (int32_t)v9,
		                                      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
		        sub_18002D1B0((SingleFieldAccessor *)pass, v11, v12, v13, v16);
		        return 1;
		      }
		LABEL_7:
		      sub_1800D8260(v10, v9);
		    }
		    *pass = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)pass, v9, v7, v8, v16);
		    return 0;
		  }
		}
		
		protected IPassConstructor GetPassConstructor(PassConstructorID id) => default; // 0x0000000182EDA3E0-0x0000000182EDA450
		// IPassConstructor GetPassConstructor(PassConstructorID)
		IPassConstructor *HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		        HGRenderPathBase *this,
		        PassConstructorID__Enum id,
		        MethodInfo *method)
		{
		  __int64 v3; // rbx
		  __int64 v5; // rdx
		  List_1_System_Object_ *v6; // rcx
		  __int64 v8; // rax
		  String__Array *v9; // rsi
		  __int64 v10; // rax
		  String *v11; // rax
		  __int64 v12; // rax
		  int32_t renderPath_k__BackingField; // ebx
		  String *v14; // rax
		  __int64 v15; // rax
		  __int64 v16; // r8
		  String *v17; // rdi
		  __int64 v18; // rax
		  Exception *v19; // rax
		  Exception *v20; // rbx
		  __int64 v21; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Enum v23; // [rsp+20h] [rbp-28h] BYREF
		  int32_t v24; // [rsp+30h] [rbp-18h]
		
		  v3 = (int)id;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3555, 0LL) )
		  {
		    v5 = *(unsigned int *)(*(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20
		                         + 4 * v3);
		    if ( (_DWORD)v5 == -1 )
		    {
		      v8 = sub_180035ED0(&TypeInfo::System::String);
		      v9 = (String__Array *)il2cpp_array_new_specific_1(v8, 6LL);
		      if ( v9 )
		      {
		        v10 = sub_180035ED0(&off_18E270E08);
		        sub_180005370(v9, 0LL, v10);
		        v23.klass = (Enum__Class *)sub_180035ED0(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
		        v23.monitor = (MonitorData *)-1LL;
		        v24 = v3;
		        v11 = System::Enum::ToString(&v23, 0LL);
		        sub_180005370(v9, 1LL, v11);
		        v12 = sub_180035ED0(&off_18E270E18);
		        sub_180005370(v9, 2LL, v12);
		        renderPath_k__BackingField = this->fields._renderPath_k__BackingField;
		        v23.klass = (Enum__Class *)sub_180035ED0(&TypeInfo::HG::Rendering::Runtime::HGRenderPathInternal);
		        v23.monitor = (MonitorData *)-1LL;
		        v24 = renderPath_k__BackingField;
		        v14 = System::Enum::ToString(&v23, 0LL);
		        sub_180005370(v9, 3LL, v14);
		        v15 = sub_180035ED0(&off_18E270DE8);
		        sub_180005370(v9, 4LL, v15);
		        v16 = *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		        if ( v16 )
		        {
		          sub_180005370(v9, 5LL, *(_QWORD *)(v16 + 16));
		          v17 = System::String::Concat(v9, 0LL);
		          v18 = sub_180035ED0(&TypeInfo::System::Exception);
		          v19 = (Exception *)sub_1800368D0(v18);
		          v20 = v19;
		          if ( v19 )
		          {
		            System::Exception::Exception(v19, v17, 0LL);
		            v21 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor);
		            sub_18007E190(v20, v21);
		          }
		        }
		      }
		    }
		    else
		    {
		      v6 = *(List_1_System_Object_ **)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		      if ( v6 )
		        return (IPassConstructor *)System::Collections::Generic::List<System::Object>::get_Item(
		                                     v6,
		                                     v5,
		                                     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3555, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1266(Patch, (Object *)this, (PassConstructorID__Enum)v3, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalVFX(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189BDE508-0x0000000189BDE6B0
		// Void UpdateShaderVariablesGlobalVFX(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalVFX(
		        HGRenderPathBase *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  float v4; // xmm2_4
		  HGVFXManager *instance; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Vector3 *PlayerPosition; // rax
		  float w; // xmm7_4
		  __int64 v13; // xmm6_8
		  float z; // ebx
		  Beyond::JobMathf *v15; // rcx
		  Vector4 *v16; // rax
		  float v17; // xmm3_4
		  float y; // xmm2_4
		  float x; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float v21; // [rsp+28h] [rbp-19h]
		  float saturation; // [rsp+38h] [rbp-9h] BYREF
		  Vector3 value; // [rsp+40h] [rbp-1h] BYREF
		  Vector3 v24; // [rsp+58h] [rbp+17h] BYREF
		  Vector4 v25[3]; // [rsp+68h] [rbp+27h] BYREF
		
		  saturation = 0.0;
		  *(_QWORD *)&value.x = 0LL;
		  value.z = 0.0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1185, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGVFXManager::GetSceneColorAdjustmentParams(instance, &value, &saturation, 0LL);
		      PlayerPosition = HG::Rendering::Runtime::HGVFXManager::GetPlayerPosition(&v24, 0LL);
		      w = cb->_GraphicsFeaturesGlobalParam1.w;
		      v13 = *(_QWORD *)&PlayerPosition->x;
		      z = PlayerPosition->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v24.x = v13;
		      v24.z = z;
		      Beyond::JobMathf::Fmod(v15, 1024.0, v4);
		      v16 = HG::Rendering::Runtime::HGUtils::PackVector4(v25, &v24, w, 0LL);
		      v17 = value.z;
		      y = value.y;
		      v21 = saturation;
		      x = value.x;
		      *(__m128i *)&cb->_RainWetnessGlobalParam0.y = _mm_loadu_si128((const __m128i *)v16);
		      *(__m128i *)&cb->_RainWetnessGlobalParam1.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                       v25,
		                                                                                       x,
		                                                                                       y,
		                                                                                       v17,
		                                                                                       v21,
		                                                                                       0LL));
		      *(__m128i *)&cb->_RainWetnessGlobalParam2.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGVFXManager::GetAnchorWaveBright(
		                                                                                       v25,
		                                                                                       0LL));
		      *(__m128i *)&cb->_RainWetnessGlobalParam3.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGVFXManager::GetGlobalBrightRadius(
		                                                                                       v25,
		                                                                                       0LL));
		      *(__m128i *)&cb->_AtmosphereFogParams4.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGVFXManager::GetPlayerHeights(
		                                                                                    v25,
		                                                                                    0LL));
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1185, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalWater(ref ShaderVariablesGlobal cb, HGSettingParameters settingParameters) {} // 0x0000000189BDE6B0-0x0000000189BDE780
		// Void UpdateShaderVariablesGlobalWater(ShaderVariablesGlobal ByRef, HGSettingParameters)
		void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalWater(
		        HGRenderPathBase *this,
		        ShaderVariablesGlobal *cb,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float v9; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v11; // [rsp+30h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1186, 0LL) )
		  {
		    if ( settingParameters )
		    {
		      v9 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		             settingParameters->fields._waterPrepassTextureSize_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v11.z = 1.0 / v9;
		      v11.x = v9;
		      v11.y = v9;
		      v11.w = 1.0 / v9;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterSettings);
		      TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize = v11;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1186, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)settingParameters, 0LL);
		}
		
		internal virtual void Dispose(HGRenderGraph renderGraph) {} // 0x0000000183945AF0-0x00000001839460B0
		// Void Dispose(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRenderPathBase::Dispose(
		        HGRenderPathBase *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  HGRenderPathBase *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 *v11; // rdx
		  struct MethodInfo *v12; // rdi
		  Il2CppClass *klass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rax
		  ProtocolViolationException *v18; // rbx
		  String *v19; // rax
		  __int64 v20; // [rsp+0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v21; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v22; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v23; // [rsp+40h] [rbp-28h] BYREF
		
		  v4 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(538, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(538, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)v4,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    if ( !renderGraph )
		      sub_1800D8260(v6, v5);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseAllPreservedTextures(
		      renderGraph,
		      v4->fields._renderPathID_k__BackingField,
		      0LL);
		    if ( !*(_QWORD *)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 )
		      sub_1800D8260(v8, v7);
		    HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearMaterials(
		      *(HGRenderPipelineMaterialCollector **)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21,
		      0LL);
		    if ( !*(_QWORD *)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 )
		      sub_1800D8260(v10, v9);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v22,
		      *(List_1_System_UInt64_ **)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
		    v23 = v22;
		    v22._list = 0LL;
		    *(_QWORD *)&v22._index = &v23;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v23,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
		      {
		        if ( !v23._current )
		          sub_1800D8250(0LL, v11);
		        sub_183945D00(v23._current, renderGraph);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v21 )
		    {
		      v11 = &v20;
		      v22._list = (List_1_System_Object_ *)v21->ex;
		      if ( v22._list )
		        sub_18007E1E0(v22._list);
		      v4 = this;
		    }
		    v12 = MethodInfo::Unity::Collections::NativeArray<int>::Dispose;
		    klass = MethodInfo::Unity::Collections::NativeArray<int>::Dispose->klass;
		    if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		      sub_1800360B0(klass, v11);
		    if ( *(_QWORD *)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 )
		    {
		      if ( !LODWORD(v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11) )
		      {
		        v17 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		        v18 = (ProtocolViolationException *)sub_1800368D0(v17);
		        sub_180003640(v18);
		        v19 = (String *)sub_18007E180(&off_18E367388);
		        System::Net::ProtocolViolationException::ProtocolViolationException(v18, v19, 0LL);
		        sub_18007E190(v18, v12);
		      }
		      if ( SLODWORD(v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11) > 1 )
		      {
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::FreeTracked(
		          *(Void **)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20,
		          LODWORD(v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11),
		          0LL);
		        v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = 0.0;
		      }
		      *(_QWORD *)&v4[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = 0LL;
		    }
		  }
		}
		
		protected TextureHandle GetBackbufferOrIntermediate(PassConstructorID pass) => default; // 0x0000000189BDC0C0-0x0000000189BDC148
		// TextureHandle GetBackbufferOrIntermediate(PassConstructorID)
		TextureHandle *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathBase *this,
		        PassConstructorID__Enum pass,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		  TextureHandle intermediateBackBuffer_k__BackingField; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3557, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3557, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    intermediateBackBuffer_k__BackingField = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1268(
		                                                &v12,
		                                                Patch,
		                                                (Object *)this,
		                                                pass,
		                                                0LL);
		    result = retstr;
		  }
		  else
		  {
		    result = retstr;
		    if ( (int)pass < this->fields._firstBackbufferPass_k__BackingField )
		      intermediateBackBuffer_k__BackingField = this->fields._intermediateBackBuffer_k__BackingField;
		    else
		      intermediateBackBuffer_k__BackingField = this->fields._backBufferColor_k__BackingField;
		  }
		  *retstr = intermediateBackBuffer_k__BackingField;
		  return result;
		}
		
		internal static HGRenderPathBase CreateRenderPath(HGRenderPathInternal renderPath, HGRenderPathResources resources, HGCamera camera) => default; // 0x0000000182ED90A0-0x0000000182ED91C0
		// HGRenderPathBase CreateRenderPath(HGRenderPathInternal, HGRenderPathBase+HGRenderPathResources, HGCamera)
		HGRenderPathBase *HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
		        HGRenderPathInternal__Enum renderPath,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  unsigned __int32 v7; // ebx
		  HGRenderPathUI *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGRenderPathBase *v11; // rbx
		  HGRenderPathDefaultDeferred *v13; // rax
		  HGRenderPathBase *v14; // rbx
		  unsigned __int32 v15; // ebx
		  HGRenderPath3DUI *v16; // rax
		  HGRenderPathBase *v17; // rbx
		  HGRenderPathDefaultDeferred *v18; // rax
		  HGRenderPathBase *v19; // rbx
		  HGRenderPathOnePassDeferred *v20; // rax
		  HGRenderPathBase *v21; // rbx
		  HGRenderPathForward *v22; // rax
		  HGRenderPathBase *v23; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderPathBase_HGRenderPathResources v25; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(708, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(708, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    v25 = *resources;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, renderPath, &v25, (Object *)camera, 0LL);
		  }
		  else if ( renderPath == HGRenderPathInternal__Enum_DefaultDeferred )
		  {
		    v13 = (HGRenderPathDefaultDeferred *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPathDefaultDeferred);
		    v14 = (HGRenderPathBase *)v13;
		    if ( !v13 )
		      goto LABEL_8;
		    v25 = *resources;
		    HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
		      v13,
		      &v25,
		      camera,
		      HGRenderPathInternal__Enum_DefaultDeferred,
		      0LL);
		    return v14;
		  }
		  else if ( renderPath )
		  {
		    v7 = renderPath - 1;
		    if ( !v7 )
		    {
		      v8 = (HGRenderPathUI *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPathUI);
		      v11 = (HGRenderPathBase *)v8;
		      if ( v8 )
		      {
		        v25 = *resources;
		        HG::Rendering::Runtime::HGRenderPathUI::HGRenderPathUI(v8, &v25, camera, 0LL);
		        return v11;
		      }
		LABEL_8:
		      sub_1800D8260(v10, v9);
		    }
		    v15 = v7 - 1;
		    if ( v15 )
		    {
		      if ( v15 == 2 )
		      {
		        v20 = (HGRenderPathOnePassDeferred *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPathOnePassDeferred);
		        v21 = (HGRenderPathBase *)v20;
		        if ( !v20 )
		          goto LABEL_8;
		        v25 = *resources;
		        HG::Rendering::Runtime::HGRenderPathOnePassDeferred::HGRenderPathOnePassDeferred(
		          v20,
		          &v25,
		          camera,
		          HGRenderPathInternal__Enum_OnePassDeferredSubpass,
		          0LL);
		        return v21;
		      }
		      else
		      {
		        v18 = (HGRenderPathDefaultDeferred *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPathDefaultDeferred);
		        v19 = (HGRenderPathBase *)v18;
		        if ( !v18 )
		          goto LABEL_8;
		        v25 = *resources;
		        HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(v18, &v25, camera, 0LL);
		        return v19;
		      }
		    }
		    else
		    {
		      v16 = (HGRenderPath3DUI *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPath3DUI);
		      v17 = (HGRenderPathBase *)v16;
		      if ( !v16 )
		        goto LABEL_8;
		      v25 = *resources;
		      HG::Rendering::Runtime::HGRenderPath3DUI::HGRenderPath3DUI(v16, &v25, camera, 0LL);
		      return v17;
		    }
		  }
		  else
		  {
		    v22 = (HGRenderPathForward *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPathForward);
		    v23 = (HGRenderPathBase *)v22;
		    if ( !v22 )
		      goto LABEL_8;
		    v25 = *resources;
		    HG::Rendering::Runtime::HGRenderPathForward::HGRenderPathForward(v22, &v25, camera, 0LL);
		    return v23;
		  }
		}
		
	}
}
