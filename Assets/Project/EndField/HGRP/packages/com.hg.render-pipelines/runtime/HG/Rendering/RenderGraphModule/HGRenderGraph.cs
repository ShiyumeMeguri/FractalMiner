using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public class HGRenderGraph // TypeDefIndex: 37432
	{
		// Fields
		public static readonly int kMaxMRTCount; // 0x00
		private HGRenderGraphResourceRegistry m_Resources; // 0x10
		private HGRenderGraphObjectPool m_RenderGraphPool; // 0x18
		private List<HGRenderGraphPass> m_RenderPasses; // 0x20
		private List<RendererListHandle> m_RendererLists; // 0x28
		private List<IRenderGraphCallbackOwner> m_callbackOwner; // 0x30
		private HGRenderGraphDebugParams m_DebugParameters; // 0x38
		private HGRenderGraphLogger m_FrameInformationLogger; // 0x40
		private HGRenderGraphDefaultResources m_DefaultResources; // 0x48
		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers; // 0x50
		private bool m_ExecutionExceptionWasRaised; // 0x58
		private HGRenderGraphContext m_RenderGraphContext; // 0x60
		private CommandBuffer m_PreviousCommandBuffer; // 0x68
		private int m_CurrentImmediatePassIndex; // 0x70
		private List<int>[] m_ImmediateModeResourceList; // 0x78
		private BackBufferInfo m_backBufferInfo; // 0x80
		private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos; // 0xA8
		private DynamicArray<CompiledPassInfo> m_CompiledPassInfos; // 0xB0
		private Stack<int> m_CullingStack; // 0xB8
		private int m_ExecutionCount; // 0xC0
		private int m_CurrentFrameIndex; // 0xC4
		private string m_CurrentExecutionName; // 0xC8
		private bool m_RendererListCulling; // 0xD0
		private int m_currentExecutorID; // 0xD4
		private int m_currentExecutorFrameIndex; // 0xD8
		private Dictionary<string, HGRenderGraphDebugData> m_DebugData; // 0xE0
		private static List<HGRenderGraph> s_RegisteredGraphs; // 0x08
		private static readonly RenderFunc<ProfilingScopePassData> s_beginProfilingSamplerRenderFunc; // 0x18
		private static readonly RenderFunc<ProfilingScopePassData> s_endProfilingSamplerRenderFunc; // 0x20
	
		// Properties
		public string name { get; private set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		// Object <RegisterPorts>b__9_2()
		Object *FlowCanvas::Nodes::CustomEvent<System::Object>::_RegisterPorts_b__9_2(
		        CustomEvent_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.receivedValue;
		}
		

		// Void set_atlasTextures(Texture2D[])
		void UnityEngine::TextCore::Text::FontAsset::set_atlasTextures(
		        FontAsset *this,
		        Texture2D__Array *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields.m_AtlasTextures = value;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_AtlasTextures, (Type *)value, (PropertyInfo_1 *)method, v3, v4);
		}
		
		internal static bool requireDebugData { get; set; } // 0x0000000189B301B4-0x0000000189B301E8 0x0000000189B304E4-0x0000000189B30528
		// Boolean get_requireDebugData()
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::get_requireDebugData(MethodInfo *method)
		{
		  struct HGRenderGraph__Class *v1; // rax
		
		  v1 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    v1 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  }
		  return v1->static_fields->_requireDebugData_k__BackingField;
		}
		

		// Void set_requireDebugData(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::set_requireDebugData(bool value, MethodInfo *method)
		{
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->_requireDebugData_k__BackingField = value;
		}
		
		public HGRenderGraphDefaultResources defaultResources { get => default; } // 0x0000000189B30168-0x0000000189B301B4 
		// HGRenderGraphDefaultResources get_defaultResources()
		HGRenderGraphDefaultResources *HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(120, 0LL) )
		    return this->fields.m_DefaultResources;
		  Patch = IFix::WrappersManagerImpl::GetPatch(120, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(Patch, (Object *)this, 0LL);
		}
		
		internal HGRenderGraphContext HGContext { get => default; } // 0x0000000189B3011C-0x0000000189B30168 
		// HGRenderGraphContext get_HGContext()
		HGRenderGraphContext *HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(121, 0LL) )
		    return this->fields.m_RenderGraphContext;
		  Patch = IFix::WrappersManagerImpl::GetPatch(121, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_57(Patch, (Object *)this, 0LL);
		}
		
		internal HGRenderGraphResourceRegistry resourceRegistry { get => default; } // 0x0000000189B301E8-0x0000000189B30234 
		// HGRenderGraphResourceRegistry get_resourceRegistry()
		HGRenderGraphResourceRegistry *HG::Rendering::RenderGraphModule::HGRenderGraph::get_resourceRegistry(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(122, 0LL) )
		    return this->fields.m_Resources;
		  Patch = IFix::WrappersManagerImpl::GetPatch(122, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_58(Patch, (Object *)this, 0LL);
		}
		
		public bool enableCppRenderPath { get; set; } // 0x0000000184D8E520-0x0000000184D8E530 0x0000000184D8E550-0x0000000184D8E560
		// Boolean UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS()
		bool UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS(
		        PointerEventBase_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;
		}
		

		// Void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(Boolean)
		void UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS(
		        PointerEventBase_1_System_Object_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField = value;
		}
		
		public bool enableSimpleUIRenderPath { get; set; } // 0x0000000184D9B5F0-0x0000000184D9B600 0x0000000184D9DEF0-0x0000000184D9DF00
		// Boolean UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer()
		bool UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer(
		        PointerEventBase_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;
		}
		

		// Void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(Boolean)
		void UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer(
		        PointerEventBase_1_System_Object_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField = value;
		}
		
	
		// Events
		internal static event OnGraphRegisteredDelegate onGraphRegistered;
		internal static event OnGraphRegisteredDelegate onGraphUnregistered;
		internal static event OnExecutionRegisteredDelegate onExecutionRegistered;
		internal static event OnExecutionRegisteredDelegate onExecutionUnregistered;
	
		// Nested types
		internal struct CompiledResourceInfo // TypeDefIndex: 37424
		{
			// Fields
			public List<int> producers; // 0x00
			public List<int> consumers; // 0x08
			public int refCount; // 0x10
			public bool imported; // 0x14
	
			// Methods
			public void Reset() {} // 0x0000000189B34B18-0x0000000189B34C00
			// Void Reset()
			void HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo::Reset(
			        HGRenderGraph_CompiledResourceInfo *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v4; // rax
			  List_1_System_Int32_ *producers; // rcx
			  List_1_System_Int32_ *v6; // rdi
			  Type *v7; // rdx
			  PropertyInfo_1 *v8; // r8
			  Int32__Array **v9; // r9
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
			  List_1_System_Int32_ *v11; // rdi
			  Type *v12; // rdx
			  PropertyInfo_1 *v13; // r8
			  Int32__Array **v14; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *v16; // [rsp+20h] [rbp-8h]
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(34, 0LL) )
			  {
			    if ( !this->producers )
			    {
			      v4 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
			      v6 = (List_1_System_Int32_ *)v4;
			      if ( !v4 )
			        goto LABEL_12;
			      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			        v4,
			        MethodInfo::System::Collections::Generic::List<int>::List);
			      this->producers = v6;
			      sub_18002D1B0((SingleFieldAccessor *)this, v7, v8, v9, v16);
			    }
			    if ( !this->consumers )
			    {
			      v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
			      v11 = (List_1_System_Int32_ *)v10;
			      if ( !v10 )
			        goto LABEL_12;
			      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			        v10,
			        MethodInfo::System::Collections::Generic::List<int>::List);
			      this->consumers = v11;
			      sub_18002D1B0((SingleFieldAccessor *)&this->consumers, v12, v13, v14, v16);
			    }
			    producers = this->producers;
			    if ( this->producers )
			    {
			      ++producers->fields._version;
			      producers->fields._size = 0;
			      producers = this->consumers;
			      if ( producers )
			      {
			        ++producers->fields._version;
			        producers->fields._size = 0;
			        this->refCount = 0;
			        this->imported = 0;
			        return;
			      }
			    }
			LABEL_12:
			    sub_1800D8260(producers, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(34, 0LL);
			  if ( !Patch )
			    goto LABEL_12;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(Patch, this, 0LL);
			}
			
		}
	
		private struct BackBufferInfo // TypeDefIndex: 37425
		{
			// Fields
			internal TextureHandle color; // 0x00
			internal TextureHandle depth; // 0x10
			internal bool offScreen; // 0x20
		}
	
		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo // TypeDefIndex: 37426
		{
			// Fields
			public HGRenderGraphPass pass; // 0x00
			public List<int>[] resourceCreateList; // 0x08
			public List<int>[] resourceReleaseList; // 0x10
			public int refCount; // 0x18
			public bool culled; // 0x1C
			public bool hasSideEffect; // 0x1D
			public int syncToPassIndex; // 0x20
			public int syncFromPassIndex; // 0x24
			public bool needGraphicsFence; // 0x28
			public GraphicsFence fence; // 0x30
			public bool enableAsyncCompute; // 0x40
	
			// Properties
			public bool allowPassCulling { get => default; } // 0x0000000189B34AC8-0x0000000189B34B18 
			// Boolean get_allowPassCulling()
			bool HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::get_allowPassCulling(
			        HGRenderGraph_CompiledPassInfo *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(47, 0LL) )
			  {
			    if ( this->pass )
			      return this->pass->fields._allowPassCulling_k__BackingField;
			LABEL_5:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(47, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_25(Patch, this, 0LL);
			}
			
	
			// Methods
			public void Reset(HGRenderGraphPass pass) {} // 0x0000000189B348F0-0x0000000189B34AC8
			// Void Reset(HGRenderGraphPass)
			void HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::Reset(
			        HGRenderGraph_CompiledPassInfo *this,
			        HGRenderGraphPass *pass,
			        MethodInfo *method)
			{
			  Type *v5; // rdx
			  PropertyInfo_1 *v6; // r8
			  Int32__Array **v7; // r9
			  List_1_System_Int32___Array *v8; // rdx
			  __int64 v9; // rcx
			  bool v10; // zf
			  Type *v11; // rdx
			  PropertyInfo_1 *v12; // r8
			  Int32__Array **v13; // r9
			  Type *v14; // rdx
			  PropertyInfo_1 *v15; // r8
			  Int32__Array **v16; // r9
			  int v17; // esi
			  List_1_System_Int32___Array *resourceCreateList; // rbp
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v19; // rax
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // rdi
			  List_1_System_Int32___Array *resourceReleaseList; // rbp
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v22; // rax
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v23; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *v25; // [rsp+20h] [rbp-8h]
			  MethodInfo *v26; // [rsp+20h] [rbp-8h]
			  MethodInfo *v27; // [rsp+20h] [rbp-8h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(36, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(36, 0LL);
			    if ( !Patch )
			      goto LABEL_21;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(Patch, this, (Object *)pass, 0LL);
			  }
			  else
			  {
			    this->pass = pass;
			    sub_18002D1B0((SingleFieldAccessor *)this, v5, v6, v7, v25);
			    if ( !pass )
			      goto LABEL_21;
			    v10 = this->resourceCreateList == 0LL;
			    this->enableAsyncCompute = pass->fields._enableAsyncCompute_k__BackingField;
			    if ( v10 )
			    {
			      this->resourceCreateList = (List_1_System_Int32___Array *)il2cpp_array_new_specific_1(
			                                                                  TypeInfo::System::Collections::Generic::List<int>,
			                                                                  2LL);
			      sub_18002D1B0((SingleFieldAccessor *)&this->resourceCreateList, v11, v12, v13, v26);
			      this->resourceReleaseList = (List_1_System_Int32___Array *)il2cpp_array_new_specific_1(
			                                                                   TypeInfo::System::Collections::Generic::List<int>,
			                                                                   2LL);
			      sub_18002D1B0((SingleFieldAccessor *)&this->resourceReleaseList, v14, v15, v16, v27);
			      v17 = 0;
			      while ( 1 )
			      {
			        resourceCreateList = this->resourceCreateList;
			        v19 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
			        v20 = v19;
			        if ( !v19 )
			          break;
			        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			          v19,
			          MethodInfo::System::Collections::Generic::List<int>::List);
			        if ( !resourceCreateList )
			          break;
			        sub_180031B10(resourceCreateList, v20);
			        sub_1800020D0(resourceCreateList, v17, v20);
			        resourceReleaseList = this->resourceReleaseList;
			        v22 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
			        v23 = v22;
			        if ( !v22 )
			          break;
			        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			          v22,
			          MethodInfo::System::Collections::Generic::List<int>::List);
			        if ( !resourceReleaseList )
			          break;
			        sub_180031B10(resourceReleaseList, v23);
			        sub_1800020D0(resourceReleaseList, v17++, v23);
			        if ( v17 >= 2 )
			          goto LABEL_10;
			      }
			LABEL_21:
			      sub_1800D8260(v9, v8);
			    }
			LABEL_10:
			    v9 = 0LL;
			    do
			    {
			      v8 = this->resourceCreateList;
			      if ( !v8 )
			        goto LABEL_21;
			      if ( (unsigned int)v9 >= v8->max_length.size )
			        goto LABEL_19;
			      v8 = (List_1_System_Int32___Array *)v8->vector[(int)v9];
			      if ( !v8 )
			        goto LABEL_21;
			      ++HIDWORD(v8->max_length.value);
			      v8->max_length.size = 0;
			      v8 = this->resourceReleaseList;
			      if ( !v8 )
			        goto LABEL_21;
			      if ( (unsigned int)v9 >= v8->max_length.size )
			LABEL_19:
			        sub_1800D2AB0(v9, v8);
			      v8 = (List_1_System_Int32___Array *)v8->vector[(int)v9];
			      if ( !v8 )
			        goto LABEL_21;
			      ++HIDWORD(v8->max_length.value);
			      v8->max_length.size = 0;
			      v9 = (unsigned int)(v9 + 1);
			    }
			    while ( (int)v9 < 2 );
			    this->refCount = 0;
			    *(_WORD *)&this->culled = 0;
			    this->needGraphicsFence = 0;
			    this->syncToPassIndex = -1;
			    this->syncFromPassIndex = -1;
			  }
			}
			
		}
	
		public class ExecuteHGRenderGraphV2PassData // TypeDefIndex: 37427
		{
			// Fields
			public long rg; // 0x10
			public NativeList<long> importAs; // 0x18
			public NativeList<TextureHandle> importBs; // 0x28
			public NativeList<long> importBufferResourceHandles; // 0x38
			public NativeList<ComputeBufferHandle> importBufferHandles; // 0x48
			public HGRenderGraph renderGraph; // 0x58
			public bool forceIssueRenderPass; // 0x60
	
			// Constructors
			public ExecuteHGRenderGraphV2PassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class ProfilingScopePassData // TypeDefIndex: 37428
		{
			// Fields
			public ProfilingSampler sampler; // 0x10
	
			// Constructors
			public ProfilingScopePassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal delegate void OnGraphRegisteredDelegate(HGRenderGraph graph); // TypeDefIndex: 37429; 0x0000000182B46B90-0x0000000182B46BA0
	
		internal delegate void OnExecutionRegisteredDelegate(HGRenderGraph graph, string executionName); // TypeDefIndex: 37430; 0x00000001838E1420-0x00000001838E1430
	
		// Constructors
		public HGRenderGraph() {} // Dummy constructor
		public HGRenderGraph(string name = "RenderGraph" /* Metadata: 0x02302D50 */) {} // 0x00000001839461F0-0x0000000183946620
		// HGRenderGraph(String)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::HGRenderGraph(
		        HGRenderGraph *this,
		        String *name,
		        MethodInfo *method)
		{
		  HGRenderGraphObjectPool *v5; // rax
		  Type *v6; // rdx
		  List_1_System_Object_ *s_RegisteredGraphs; // rcx
		  HGRenderGraphObjectPool *v8; // rdi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v12; // rax
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *v13; // rdi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rdi
		  __int64 v18; // rax
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
		  List_1_HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_ *v26; // rdi
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  HGRenderGraphDebugParams *v30; // rax
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  HGRenderGraphLogger *v33; // rax
		  HGRenderGraphLogger *v34; // rdi
		  Type *v35; // rdx
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  HGRenderGraphDefaultResources *v38; // rax
		  HGRenderGraphDefaultResources *v39; // rdi
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  Dictionary_2_System_Int32_System_Object_ *v43; // rax
		  Dictionary_2_System_Int32_UnityEngine_Rendering_ProfilingSampler_ *v44; // rdi
		  Type *v45; // rdx
		  PropertyInfo_1 *v46; // r8
		  Int32__Array **v47; // r9
		  HGRenderGraphContext *v48; // rax
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  Type *v51; // rdx
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  Type *v54; // rdx
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v57; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v58; // rdi
		  Type *v59; // rdx
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **v61; // r9
		  Stack_1_System_Int32Enum_ *v62; // rax
		  Stack_1_System_Int32_ *v63; // rdi
		  Type *v64; // rdx
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  Dictionary_2_System_Object_System_Object_ *v67; // rax
		  Dictionary_2_System_String_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ *v68; // rdi
		  Type *v69; // rdx
		  PropertyInfo_1 *v70; // r8
		  Int32__Array **v71; // r9
		  Type *v72; // rdx
		  PropertyInfo_1 *v73; // r8
		  Type *v74; // rdx
		  PropertyInfo_1 *v75; // r8
		  Int32__Array **v76; // r9
		  HGRenderGraphDebugParams *m_DebugParameters; // rsi
		  HGRenderGraphLogger *m_FrameInformationLogger; // rbp
		  HGRenderGraphResourceRegistry *v79; // rax
		  HGRenderGraphResourceRegistry *v80; // rdi
		  Type *v81; // rdx
		  PropertyInfo_1 *v82; // r8
		  Int32__Array **v83; // r9
		  int i; // esi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rdi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v86; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v87; // rbp
		  Type *v88; // rdx
		  __int64 v89; // rcx
		  PropertyInfo_1 *v90; // r8
		  Int32__Array **v91; // r9
		  struct HGRenderGraph__Class *v92; // rax
		  HGRenderGraph_OnGraphRegisteredDelegate *onGraphRegistered; // rax
		  MethodInfo *v94; // [rsp+20h] [rbp-8h]
		  MethodInfo *v95; // [rsp+20h] [rbp-8h]
		  MethodInfo *v96; // [rsp+20h] [rbp-8h]
		  MethodInfo *v97; // [rsp+20h] [rbp-8h]
		  MethodInfo *v98; // [rsp+20h] [rbp-8h]
		  MethodInfo *v99; // [rsp+20h] [rbp-8h]
		  MethodInfo *v100; // [rsp+20h] [rbp-8h]
		  MethodInfo *v101; // [rsp+20h] [rbp-8h]
		  MethodInfo *v102; // [rsp+20h] [rbp-8h]
		  MethodInfo *v103; // [rsp+20h] [rbp-8h]
		  MethodInfo *v104; // [rsp+20h] [rbp-8h]
		  MethodInfo *v105; // [rsp+20h] [rbp-8h]
		  MethodInfo *v106; // [rsp+20h] [rbp-8h]
		  MethodInfo *v107; // [rsp+20h] [rbp-8h]
		  MethodInfo *v108; // [rsp+20h] [rbp-8h]
		  MethodInfo *v109; // [rsp+20h] [rbp-8h]
		  MethodInfo *v110; // [rsp+20h] [rbp-8h]
		  MethodInfo *v111; // [rsp+20h] [rbp-8h]
		  MethodInfo *v112; // [rsp+20h] [rbp-8h]
		
		  v5 = (HGRenderGraphObjectPool *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool);
		  v8 = v5;
		  if ( !v5 )
		    goto LABEL_24;
		  HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::HGRenderGraphObjectPool(v5, 0LL);
		  this->fields.m_RenderGraphPool = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RenderGraphPool, v9, v10, v11, v94);
		  v12 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>);
		  v13 = (List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *)v12;
		  if ( !v12 )
		    goto LABEL_24;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v12,
		    64,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::List);
		  this->fields.m_RenderPasses = v13;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RenderPasses, v14, v15, v16, v95);
		  v17 = sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>);
		  if ( !v17 )
		    goto LABEL_24;
		  v18 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::List->klass->rgctx_data[1].rgctxDataDummy);
		  *(_QWORD *)(v17 + 16) = il2cpp_array_new_specific_1(v18, 32LL);
		  sub_18002D1B0((SingleFieldAccessor *)(v17 + 16), v19, v20, v21, v96);
		  this->fields.m_RendererLists = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RendererLists, v22, v23, v24, v97);
		  v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>);
		  v26 = (List_1_HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_ *)v25;
		  if ( !v25 )
		    goto LABEL_24;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v25,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::List);
		  this->fields.m_callbackOwner = v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_callbackOwner, v27, v28, v29, v98);
		  v30 = (HGRenderGraphDebugParams *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams);
		  if ( !v30 )
		    goto LABEL_24;
		  this->fields.m_DebugParameters = v30;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DebugParameters, v6, v31, v32, v99);
		  v33 = (HGRenderGraphLogger *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphLogger);
		  v34 = v33;
		  if ( !v33 )
		    goto LABEL_24;
		  HG::Rendering::RenderGraphModule::HGRenderGraphLogger::HGRenderGraphLogger(v33, 0LL);
		  this->fields.m_FrameInformationLogger = v34;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_FrameInformationLogger, v35, v36, v37, v100);
		  v38 = (HGRenderGraphDefaultResources *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources);
		  v39 = v38;
		  if ( !v38 )
		    goto LABEL_24;
		  HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::HGRenderGraphDefaultResources(v38, 0LL);
		  this->fields.m_DefaultResources = v39;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DefaultResources, v40, v41, v42, v101);
		  v43 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>);
		  v44 = (Dictionary_2_System_Int32_UnityEngine_Rendering_ProfilingSampler_ *)v43;
		  if ( !v43 )
		    goto LABEL_24;
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v43,
		    MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::Dictionary);
		  this->fields.m_DefaultProfilingSamplers = v44;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DefaultProfilingSamplers, v45, v46, v47, v102);
		  v48 = (HGRenderGraphContext *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphContext);
		  if ( !v48 )
		    goto LABEL_24;
		  this->fields.m_RenderGraphContext = v48;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RenderGraphContext, v6, v49, v50, v103);
		  this->fields.m_ImmediateModeResourceList = (List_1_System_Int32___Array *)il2cpp_array_new_specific_1(
		                                                                              TypeInfo::System::Collections::Generic::List<int>,
		                                                                              2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ImmediateModeResourceList, v51, v52, v53, v104);
		  this->fields.m_CompiledResourcesInfos = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CompiledResourcesInfos, v54, v55, v56, v105);
		  v57 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>);
		  v58 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *)v57;
		  if ( !v57 )
		    goto LABEL_24;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v57,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::DynamicArray);
		  this->fields.m_CompiledPassInfos = v58;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CompiledPassInfos, v59, v60, v61, v106);
		  v62 = (Stack_1_System_Int32Enum_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Stack<int>);
		  v63 = (Stack_1_System_Int32_ *)v62;
		  if ( !v62 )
		    goto LABEL_24;
		  System::Collections::Generic::Stack<System::Int32Enum>::Stack(
		    v62,
		    MethodInfo::System::Collections::Generic::Stack<int>::Stack);
		  this->fields.m_CullingStack = v63;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CullingStack, v64, v65, v66, v107);
		  v67 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>);
		  v68 = (Dictionary_2_System_String_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ *)v67;
		  if ( !v67 )
		    goto LABEL_24;
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v67,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Dictionary);
		  this->fields.m_DebugData = v68;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DebugData, v69, v70, v71, v108);
		  this->fields._name_k__BackingField = (String *)"RenderGraph";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields._name_k__BackingField,
		    v72,
		    v73,
		    (Int32__Array **)"RenderGraph",
		    v109);
		  this->fields._name_k__BackingField = name;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._name_k__BackingField, v74, v75, v76, v110);
		  m_DebugParameters = this->fields.m_DebugParameters;
		  m_FrameInformationLogger = this->fields.m_FrameInformationLogger;
		  v79 = (HGRenderGraphResourceRegistry *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry);
		  v80 = v79;
		  if ( !v79 )
		    goto LABEL_24;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourceRegistry(
		    v79,
		    m_DebugParameters,
		    m_FrameInformationLogger,
		    0LL);
		  this->fields.m_Resources = v80;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v81, v82, v83, v111);
		  for ( i = 0; i < 2; sub_18002D1B0((SingleFieldAccessor *)&m_CompiledResourcesInfos->vector[i++], v88, v90, v91, v112) )
		  {
		    m_CompiledResourcesInfos = this->fields.m_CompiledResourcesInfos;
		    v86 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>);
		    v87 = v86;
		    if ( !v86 )
		      goto LABEL_24;
		    UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		      v86,
		      MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray);
		    if ( !m_CompiledResourcesInfos )
		      goto LABEL_24;
		    sub_180031B10(m_CompiledResourcesInfos, v87);
		    if ( (unsigned int)i >= m_CompiledResourcesInfos->max_length.size )
		      sub_1800D2AB0(v89, v88);
		    m_CompiledResourcesInfos->vector[i] = v87;
		  }
		  v92 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    v92 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  }
		  s_RegisteredGraphs = (List_1_System_Object_ *)v92->static_fields->s_RegisteredGraphs;
		  if ( !s_RegisteredGraphs )
		LABEL_24:
		    sub_1800D8260(s_RegisteredGraphs, v6);
		  sub_182F01190(s_RegisteredGraphs, (Object *)this);
		  onGraphRegistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->onGraphRegistered;
		  if ( onGraphRegistered )
		    ((void (__fastcall *)(void *, HGRenderGraph *, void *))onGraphRegistered->fields._._.invoke_impl)(
		      onGraphRegistered->fields._._.method_code,
		      this,
		      onGraphRegistered->fields._._.method);
		}
		
		static HGRenderGraph() {} // 0x0000000184B2F880-0x0000000184B2FA00
		// HGRenderGraph()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::cctor(MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  MonitorData *v4; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  struct HGRenderGraph_c__Class *v8; // rax
		  Object *v9; // rdi
		  RenderFunc_1_System_Object_ *v10; // rax
		  Type__Class *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Object *v15; // rdi
		  RenderFunc_1_System_Object_ *v16; // rax
		  MonitorData *v17; // rbx
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->kMaxMRTCount = 8;
		  v1 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraph>);
		  v4 = (MonitorData *)v1;
		  if ( !v1 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v1,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraph>::List);
		  static_fields = (Type *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields;
		  static_fields->monitor = v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_RegisteredGraphs,
		    static_fields,
		    v6,
		    v7,
		    v21);
		  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->_requireDebugData_k__BackingField = 0;
		  v8 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c;
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c);
		    v8 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c;
		  }
		  v9 = (Object *)v8->static_fields->__9;
		  v10 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
		  v11 = (Type__Class *)v10;
		  if ( !v10
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v10,
		          v9,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c::__cctor_b__143_0,
		          0LL),
		        v12 = (Type *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields,
		        v12[1].klass = v11,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_beginProfilingSamplerRenderFunc,
		          v12,
		          v13,
		          v14,
		          v22),
		        v15 = (Object *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c->static_fields->__9,
		        v16 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>),
		        (v17 = (MonitorData *)v16) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v16,
		    v15,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::__c::__cctor_b__143_1,
		    0LL);
		  v18 = (Type *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields;
		  v18[1].monitor = v17;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_endProfilingSamplerRenderFunc,
		    v18,
		    v19,
		    v20,
		    v23);
		}
		
	
		// Methods
		public void Cleanup() {} // 0x0000000184CDC680-0x0000000184CDC730
		// Void Cleanup()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::Cleanup(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  struct HGRenderGraph__Class *v5; // rax
		  HGRenderGraph_OnGraphRegisteredDelegate *onGraphUnregistered; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(123, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(123, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_3:
		    sub_1800D8260(m_Resources, v3);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_3;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Cleanup(m_Resources, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_DefaultResources;
		  if ( !m_Resources )
		    goto LABEL_3;
		  HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::Cleanup(
		    (HGRenderGraphDefaultResources *)m_Resources,
		    0LL);
		  v5 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    v5 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
		  }
		  m_Resources = (HGRenderGraphResourceRegistry *)v5->static_fields->s_RegisteredGraphs;
		  if ( !m_Resources )
		    goto LABEL_3;
		  System::Collections::Generic::List<System::Object>::Remove(
		    (List_1_System_Object_ *)m_Resources,
		    (Object *)this,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraph>::Remove);
		  onGraphUnregistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->onGraphUnregistered;
		  if ( onGraphUnregistered )
		    ((void (__fastcall *)(void *, HGRenderGraph *, void *))onGraphUnregistered->fields._._.invoke_impl)(
		      onGraphUnregistered->fields._._.method_code,
		      this,
		      onGraphUnregistered->fields._._.method);
		}
		
		public void RegisterDebug(DebugUI.Panel panel = null) {} // 0x0000000189B2EE40-0x0000000189B2EEAC
		// Void RegisterDebug(DebugUI+Panel)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterDebug(
		        HGRenderGraph *this,
		        DebugUI_Panel *panel,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphDebugParams *m_DebugParameters; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(127, 0LL) )
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( m_DebugParameters )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::RegisterDebug(
		        m_DebugParameters,
		        this->fields._name_k__BackingField,
		        panel,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_DebugParameters, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(127, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)panel,
		    0LL);
		}
		
		public void UnRegisterDebug() {} // 0x0000000189B2F1E4-0x0000000189B2F244
		// Void UnRegisterDebug()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::UnRegisterDebug(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderGraphDebugParams *m_DebugParameters; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(129, 0LL) )
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( m_DebugParameters )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::UnRegisterDebug(
		        m_DebugParameters,
		        this->fields._name_k__BackingField,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_DebugParameters, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(129, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public static List<HGRenderGraph> GetRegisteredRenderGraphs() => default; // 0x0000000189B2D244-0x0000000189B2D2A0
		// List`1[HG.Rendering.RenderGraphModule.HGRenderGraph] GetRegisteredRenderGraphs()
		List_1_HG_Rendering_RenderGraphModule_HGRenderGraph_ *HG::Rendering::RenderGraphModule::HGRenderGraph::GetRegisteredRenderGraphs(
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(130, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(130, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59(Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    return TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_RegisteredGraphs;
		  }
		}
		
		internal HGRenderGraphDebugData GetDebugData(string executionName) => default; // 0x0000000189B2CD2C-0x0000000189B2CDB4
		// HGRenderGraphDebugData GetDebugData(String)
		HGRenderGraphDebugData *HG::Rendering::RenderGraphModule::HGRenderGraph::GetDebugData(
		        HGRenderGraph *this,
		        String *executionName,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_String_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ *m_DebugData; // rcx
		  bool v7; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(131, 0LL) )
		  {
		    m_DebugData = this->fields.m_DebugData;
		    if ( m_DebugData )
		    {
		      v7 = System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		             (Dictionary_2_System_Object_System_Object_ *)m_DebugData,
		             (Object *)executionName,
		             &value,
		             MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue);
		      return (HGRenderGraphDebugData *)((unsigned __int64)value & -(__int64)v7);
		    }
		LABEL_5:
		    sub_1800D8260(m_DebugData, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(131, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_60(Patch, (Object *)this, (Object *)executionName, 0LL);
		}
		
		public void EndFrame() {} // 0x00000001839469E0-0x0000000183946A70
		// Void EndFrame()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::EndFrame(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  __int64 v4; // rdx
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  HGRenderGraphDebugParams *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderGraphDebugParams *v8; // rax
		
		  m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *(_QWORD *)m_Resources[2].monitor;
		  if ( !v4 )
		    goto LABEL_12;
		  if ( *(int *)(v4 + 24) > 132 )
		  {
		    if ( !LODWORD(m_Resources[2].fields.m_FrameInformationLogger) )
		    {
		      il2cpp_runtime_class_init_1(m_Resources);
		      m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_Resources = *(HGRenderGraphResourceRegistry **)m_Resources[2].monitor;
		    if ( !m_Resources )
		      goto LABEL_12;
		    if ( LODWORD(m_Resources->fields.m_RendererListResources) <= 0x84 )
		      sub_1800D2AB0(m_Resources, v4);
		    if ( m_Resources[12].fields.m_RenderGraphDebug )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(132, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_12;
		    }
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_12;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PurgeUnusedGraphicsResources(m_Resources, 0LL);
		  m_DebugParameters = this->fields.m_DebugParameters;
		  if ( !m_DebugParameters )
		    goto LABEL_12;
		  if ( m_DebugParameters->fields.logFrameInformation )
		    m_DebugParameters->fields.logFrameInformation = 0;
		  v6 = this->fields.m_DebugParameters;
		  if ( !v6 )
		    goto LABEL_12;
		  if ( v6->fields.logResources )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::FlushLogs(m_Resources, 0LL);
		      v8 = this->fields.m_DebugParameters;
		      if ( v8 )
		      {
		        v8->fields.logResources = 0;
		        return;
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_Resources, v4);
		  }
		}
		
		[IDTag(0)]
		public TextureHandle ImportTexture(RTHandle rt) => default; // 0x0000000189B2D68C-0x0000000189B2D71C
		// TextureHandle ImportTexture(RTHandle)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  TextureHandle *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v11; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(136, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(136, 0LL);
		    if ( Patch )
		    {
		      v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(&v13, Patch, (Object *)this, (Object *)rt, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, m_Resources);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(&v13, m_Resources, rt, 0LL);
		LABEL_7:
		  v11 = *v9;
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		[IDTag(1)]
		public TextureHandle ImportTexture(RTHandle rt, int width, int height) => default; // 0x0000000189B2D71C-0x0000000189B2D7D8
		// TextureHandle ImportTexture(RTHandle, Int32, Int32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        RTHandle *rt,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  TextureHandle *v12; // rax
		  TextureHandle v13; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v15; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(139, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(139, 0LL);
		    if ( Patch )
		    {
		      v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_63(
		              &v15,
		              Patch,
		              (Object *)this,
		              (Object *)rt,
		              width,
		              height,
		              0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v10, Patch);
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_Resources;
		  if ( !Patch )
		    goto LABEL_5;
		  v12 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
		          &v15,
		          (HGRenderGraphResourceRegistry *)Patch,
		          rt,
		          width,
		          height,
		          0LL);
		LABEL_7:
		  v13 = *v12;
		  result = retstr;
		  *retstr = v13;
		  return result;
		}
		
		public TextureHandle ImportDepthbuffer(RTHandle rt) => default; // 0x0000000189B2D5FC-0x0000000189B2D68C
		// TextureHandle ImportDepthbuffer(RTHandle)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  TextureHandle *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v11; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(141, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(141, 0LL);
		    if ( Patch )
		    {
		      v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(&v13, Patch, (Object *)this, (Object *)rt, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, m_Resources);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportDepthbuffer(&v13, m_Resources, rt, 0LL);
		LABEL_7:
		  v11 = *v9;
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		public ValueTuple<TextureHandle, TextureHandle> ImportBackbuffer(RenderTargetIdentifier color, RenderTargetIdentifier depth, ref TextureDesc colorDesc, ref TextureDesc depthDesc, bool offScreen) => default; // 0x0000000189B2D3C8-0x0000000189B2D590
		// ValueTuple`2[HG.Rendering.RenderGraphModule.TextureHandle,HG.Rendering.RenderGraphModule.TextureHandle] ImportBackbuffer(RenderTargetIdentifier, RenderTargetIdentifier, TextureDesc ByRef, TextureDesc ByRef, Boolean)
		ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportBackbuffer(
		        ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *__return_ptr retstr,
		        HGRenderGraph *this,
		        RenderTargetIdentifier *color,
		        RenderTargetIdentifier *depth,
		        TextureDesc *colorDesc,
		        TextureDesc *depthDesc,
		        bool offScreen,
		        MethodInfo *method)
		{
		  __int64 v12; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int128 v14; // xmm1
		  TextureHandle *v15; // rax
		  TextureHandle v16; // xmm6
		  __int128 v17; // xmm1
		  TextureHandle v18; // xmm0
		  int32_t m_DepthSlice; // eax
		  TextureHandle v20; // xmm1
		  __int128 v21; // xmm1
		  __int64 v22; // xmm0_8
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *v25; // rax
		  TextureHandle Item2; // xmm1
		  RenderTargetIdentifier v28; // [rsp+58h] [rbp-59h] BYREF
		  RenderTargetIdentifier v29; // [rsp+88h] [rbp-29h] BYREF
		  ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ v30; // [rsp+B8h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(143, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(143, 0LL);
		    if ( Patch )
		    {
		      v21 = *(_OWORD *)&depth->m_BufferPointer;
		      *(_OWORD *)&v28.m_Type = *(_OWORD *)&depth->m_Type;
		      v22 = *(_QWORD *)&depth->m_DepthSlice;
		      *(_OWORD *)&v28.m_BufferPointer = v21;
		      v23 = *(_OWORD *)&color->m_Type;
		      *(_QWORD *)&v28.m_DepthSlice = v22;
		      v24 = *(_OWORD *)&color->m_BufferPointer;
		      *(_OWORD *)&v29.m_Type = v23;
		      *(_QWORD *)&v23 = *(_QWORD *)&color->m_DepthSlice;
		      *(_OWORD *)&v29.m_BufferPointer = v24;
		      *(_QWORD *)&v29.m_DepthSlice = v23;
		      v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(
		              &v30,
		              Patch,
		              (Object *)this,
		              &v29,
		              &v28,
		              colorDesc,
		              depthDesc,
		              offScreen,
		              0LL);
		      Item2 = v25->Item2;
		      retstr->Item1 = v25->Item1;
		      retstr->Item2 = Item2;
		      return retstr;
		    }
		LABEL_6:
		    sub_1800D8260(v12, Patch);
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_Resources;
		  v29.m_DepthSlice = 0;
		  if ( !Patch )
		    goto LABEL_6;
		  v14 = *(_OWORD *)&color->m_BufferPointer;
		  *(_OWORD *)&v28.m_Type = *(_OWORD *)&color->m_Type;
		  *(_QWORD *)&v28.m_DepthSlice = *(_QWORD *)&color->m_DepthSlice;
		  *(_OWORD *)&v28.m_BufferPointer = v14;
		  v15 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
		          &v30.Item1,
		          (HGRenderGraphResourceRegistry *)Patch,
		          &v28,
		          colorDesc,
		          HGRenderGraphResourceRegistry_BackBufferType__Enum_Color,
		          0LL);
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_Resources;
		  v16 = *v15;
		  if ( !Patch )
		    goto LABEL_6;
		  v17 = *(_OWORD *)&depth->m_BufferPointer;
		  *(_OWORD *)&v28.m_Type = *(_OWORD *)&depth->m_Type;
		  *(_QWORD *)&v28.m_DepthSlice = *(_QWORD *)&depth->m_DepthSlice;
		  *(_OWORD *)&v28.m_BufferPointer = v17;
		  v18 = *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
		           &v30.Item1,
		           (HGRenderGraphResourceRegistry *)Patch,
		           &v28,
		           depthDesc,
		           HGRenderGraphResourceRegistry_BackBufferType__Enum_Depth,
		           0LL);
		  this->fields.m_backBufferInfo.color = v16;
		  LOBYTE(v29.m_DepthSlice) = offScreen;
		  m_DepthSlice = v29.m_DepthSlice;
		  this->fields.m_backBufferInfo.depth = v18;
		  *(_DWORD *)&this->fields.m_backBufferInfo.offScreen = m_DepthSlice;
		  v20 = this->fields.m_backBufferInfo.depth;
		  retstr->Item1 = this->fields.m_backBufferInfo.color;
		  retstr->Item2 = v20;
		  return retstr;
		}
		
		public bool IsBackBuffer(TextureHandle rt) => default; // 0x0000000189B2DBC0-0x0000000189B2DC58
		// Boolean IsBackBuffer(TextureHandle)
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(
		        HGRenderGraph *this,
		        TextureHandle *rt,
		        MethodInfo *method)
		{
		  int32_t index; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(145, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(145, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = *rt;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(Patch, (Object *)this, &v10, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&rt->handle, 0LL);
		    return index == HG::Rendering::RenderGraphModule::ResourceHandle::get_index(
		                      &this->fields.m_backBufferInfo.color.handle,
		                      0LL)
		        && !this->fields.m_backBufferInfo.offScreen;
		  }
		}
		
		[IDTag(0)]
		public TextureHandle CreateTexture(ref TextureDesc desc) => default; // 0x0000000189B2AD3C-0x0000000189B2ADD0
		// TextureHandle CreateTexture(TextureDesc ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        TextureDesc *desc,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  TextureHandle *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v11; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(146, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(146, 0LL);
		    if ( Patch )
		    {
		      v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(&v13, Patch, (Object *)this, desc, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, m_Resources);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(&v13, m_Resources, desc, -1, 0LL);
		LABEL_7:
		  v11 = *v9;
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		[IDTag(1)]
		public TextureHandle CreateTexture(ref TextureHandle texture) => default; // 0x0000000189B2ADD0-0x0000000189B2AE80
		// TextureHandle CreateTexture(TextureHandle ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rbp
		  HGRenderGraphResourceRegistry *v9; // rcx
		  TextureDesc *TextureResourceDescRef; // rax
		  TextureHandle *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v13; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v15; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(149, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(149, 0LL);
		    if ( Patch )
		    {
		      v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71(&v15, Patch, (Object *)this, texture, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v9, v7);
		  }
		  m_Resources = this->fields.m_Resources;
		  v9 = m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  TextureResourceDescRef = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
		                             m_Resources,
		                             &texture->handle,
		                             0LL);
		  v11 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
		          &v15,
		          m_Resources,
		          TextureResourceDescRef,
		          -1,
		          0LL);
		LABEL_7:
		  v13 = *v11;
		  result = retstr;
		  *retstr = v13;
		  return result;
		}
		
		public void CreateTextureIfInvalid(ref TextureDesc desc, ref TextureHandle texture) {} // 0x0000000189B2AC90-0x0000000189B2AD3C
		// Void CreateTextureIfInvalid(TextureDesc ByRef, TextureHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTextureIfInvalid(
		        HGRenderGraph *this,
		        TextureDesc *desc,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(151, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
		      return;
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		    {
		      *texture = *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
		                    &v10,
		                    m_Resources,
		                    desc,
		                    -1,
		                    0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, m_Resources);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(151, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_74(Patch, (Object *)this, desc, texture, 0LL);
		}
		
		public TextureDesc GetTextureDesc([IsReadOnly] in TextureHandle texture) => default; // 0x0000000189B2D30C-0x0000000189B2D3C8
		// TextureDesc GetTextureDesc(TextureHandle ByRef)
		TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
		        TextureDesc *__return_ptr retstr,
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  TextureDesc *TextureResourceDesc; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  Color clearColor; // xmm1
		  TextureDesc *result; // rax
		  TextureDesc v17; // [rsp+30h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(154, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(154, 0LL);
		    if ( Patch )
		    {
		      TextureResourceDesc = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_76(&v17, Patch, (Object *)this, texture, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, m_Resources);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  TextureResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
		                          &v17,
		                          m_Resources,
		                          &texture->handle,
		                          0LL);
		LABEL_7:
		  v11 = *(_OWORD *)&TextureResourceDesc->colorFormat;
		  *(_OWORD *)&retstr->width = *(_OWORD *)&TextureResourceDesc->width;
		  v12 = *(_OWORD *)&TextureResourceDesc->enableRandomWrite;
		  *(_OWORD *)&retstr->colorFormat = v11;
		  v13 = *(_OWORD *)&TextureResourceDesc->bindTextureMS;
		  *(_OWORD *)&retstr->enableRandomWrite = v12;
		  v14 = *(_OWORD *)&TextureResourceDesc->fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&retstr->bindTextureMS = v13;
		  clearColor = TextureResourceDesc->clearColor;
		  result = retstr;
		  *(_OWORD *)&retstr->fastMemoryDesc.inFastMemory = v14;
		  retstr->clearColor = clearColor;
		  return result;
		}
		
		public ref TextureDesc GetTextureDescRef(ref TextureHandle texture) => ref _refReturnTypeForGetTextureDescRef; // 0x0000000189B2D2A0-0x0000000189B2D30C
		// TextureDesc& GetTextureDescRef(TextureHandle ByRef)
		TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(156, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
		               m_Resources,
		               &texture->handle,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(156, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_77(Patch, (Object *)this, texture, 0LL);
		}
		
		private ref TextureDesc _refReturnTypeForGetTextureDescRef; // Dummy field
		public TextureHandle PreserveTexture(ref TextureHandle texture, int frameCount, string info) => default; // 0x0000000189B2EA6C-0x0000000189B2EB34
		// TextureHandle PreserveTexture(TextureHandle ByRef, Int32, String)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        int32_t frameCount,
		        String *info,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphContext *m_RenderGraphContext; // rcx
		  TextureHandle *v12; // rax
		  TextureHandle v13; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v15; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(157, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(157, 0LL);
		    if ( Patch )
		    {
		      v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_80(
		              &v15,
		              Patch,
		              (Object *)this,
		              texture,
		              frameCount,
		              (Object *)info,
		              0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderGraphContext, Patch);
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_Resources;
		  m_RenderGraphContext = this->fields.m_RenderGraphContext;
		  if ( !Patch )
		    goto LABEL_5;
		  v12 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PreserveTexture(
		          &v15,
		          (HGRenderGraphResourceRegistry *)Patch,
		          texture,
		          frameCount,
		          m_RenderGraphContext,
		          info,
		          0LL);
		LABEL_7:
		  v13 = *v12;
		  result = retstr;
		  *retstr = v13;
		  return result;
		}
		
		public void ReleaseAllPreservedTextures(int executorID) {} // 0x0000000183946140-0x0000000183946190
		// Void ReleaseAllPreservedTextures(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseAllPreservedTextures(
		        HGRenderGraph *this,
		        int32_t executorID,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(164, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseAllPreservedResources(
		        m_Resources,
		        executorID,
		        0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(164, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, executorID, 0LL);
		}
		
		internal bool TextureNeedsClear(TextureHandle texture) => default; // 0x0000000189B2F040-0x0000000189B2F0B4
		// Boolean TextureNeedsClear(TextureHandle)
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::TextureNeedsClear(
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(166, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsClear(
		               m_Resources,
		               &texture->handle,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(166, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v9 = *texture;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(Patch, (Object *)this, &v9, 0LL);
		}
		
		internal void MarkTextureNeedsClearFlag(TextureHandle texture, bool flag) {} // 0x0000000189B2E3B4-0x0000000189B2E440
		// Void MarkTextureNeedsClearFlag(TextureHandle, Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::MarkTextureNeedsClearFlag(
		        HGRenderGraph *this,
		        TextureHandle *texture,
		        bool flag,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(168, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::MarkTextureNeedsClearFlag(
		        m_Resources,
		        &texture->handle,
		        flag,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_Resources, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(168, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v10 = *texture;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_82(Patch, (Object *)this, &v10, flag, 0LL);
		}
		
		public RendererListHandle CreateRendererList([IsReadOnly] in RendererListDesc desc) => default; // 0x0000000189B2AB5C-0x0000000189B2ABC8
		// RendererListHandle CreateRendererList(RendererListDesc ByRef)
		RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		        HGRenderGraph *this,
		        RendererListDesc *desc,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(170, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererList(m_Resources, desc, 0LL);
		LABEL_5:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(170, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(Patch, (Object *)this, desc, 0LL);
		}
		
		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) => default; // 0x0000000189B2D590-0x0000000189B2D5FC
		// ComputeBufferHandle ImportComputeBuffer(ComputeBuffer)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
		        HGRenderGraph *this,
		        ComputeBuffer *computeBuffer,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(173, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportComputeBuffer(
		               m_Resources,
		               computeBuffer,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(173, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_85(Patch, (Object *)this, (Object *)computeBuffer, 0LL);
		}
		
		[IDTag(0)]
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc) => default; // 0x0000000189B2AA48-0x0000000189B2AAB8
		// ComputeBufferHandle CreateComputeBuffer(ComputeBufferDesc ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		        HGRenderGraph *this,
		        ComputeBufferDesc *desc,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(175, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
		               m_Resources,
		               desc,
		               -1,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(175, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_88(Patch, (Object *)this, desc, 0LL);
		}
		
		[IDTag(1)]
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferHandle computeBuffer) => default; // 0x0000000189B2AAB8-0x0000000189B2AB5C
		// ComputeBufferHandle CreateComputeBuffer(ComputeBufferHandle ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		        HGRenderGraph *this,
		        ComputeBufferHandle *computeBuffer,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rsi
		  HGRenderGraphResourceRegistry *v7; // rdx
		  ComputeBufferDesc *ComputeBufferResourceDesc; // rax
		  String *name; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferDesc desc; // [rsp+20h] [rbp-38h] BYREF
		  ComputeBufferDesc v13; // [rsp+38h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(178, 0LL) )
		  {
		    m_Resources = this->fields.m_Resources;
		    v7 = m_Resources;
		    if ( m_Resources )
		    {
		      ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
		                                    &v13,
		                                    m_Resources,
		                                    &computeBuffer->handle,
		                                    0LL);
		      name = ComputeBufferResourceDesc->name;
		      *(_OWORD *)&desc.count = *(_OWORD *)&ComputeBufferResourceDesc->count;
		      desc.name = name;
		      return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
		               m_Resources,
		               &desc,
		               -1,
		               0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v5, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(178, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_90(Patch, (Object *)this, computeBuffer, 0LL);
		}
		
		public ComputeBufferDesc GetComputeBufferDesc([IsReadOnly] in ComputeBufferHandle computeBuffer) => default; // 0x0000000189B2CC94-0x0000000189B2CD2C
		// ComputeBufferDesc GetComputeBufferDesc(ComputeBufferHandle ByRef)
		ComputeBufferDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetComputeBufferDesc(
		        ComputeBufferDesc *__return_ptr retstr,
		        HGRenderGraph *this,
		        ComputeBufferHandle *computeBuffer,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  ComputeBufferDesc *ComputeBufferResourceDesc; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // xmm0
		  String *name; // xmm1_8
		  ComputeBufferDesc *result; // rax
		  ComputeBufferDesc v14; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(180, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(180, 0LL);
		    if ( Patch )
		    {
		      ComputeBufferResourceDesc = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_91(
		                                    &v14,
		                                    Patch,
		                                    (Object *)this,
		                                    computeBuffer,
		                                    0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, m_Resources);
		  }
		  m_Resources = this->fields.m_Resources;
		  if ( !m_Resources )
		    goto LABEL_5;
		  ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
		                                &v14,
		                                m_Resources,
		                                &computeBuffer->handle,
		                                0LL);
		LABEL_7:
		  v11 = *(_OWORD *)&ComputeBufferResourceDesc->count;
		  name = ComputeBufferResourceDesc->name;
		  result = retstr;
		  *(_OWORD *)&retstr->count = v11;
		  retstr->name = name;
		  return result;
		}
		
		public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData, ProfilingSampler sampler, bool useNativeRenderpass = true /* Metadata: 0x02302D5C */, ProfilingHGPass profilingHgPass = ProfilingHGPass.None /* Metadata: 0x02302D5D */)
			where PassData : class, new() {
			passData = default;
			return default;
		}
		public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData)
			where PassData : class, new() {
			passData = default;
			return default;
		}
		internal void RegisterCallbackOwner(IRenderGraphCallbackOwner owner) {} // 0x0000000189B2EDD0-0x0000000189B2EE40
		// Void RegisterCallbackOwner(IRenderGraphCallbackOwner)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterCallbackOwner(
		        HGRenderGraph *this,
		        IRenderGraphCallbackOwner *owner,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_callbackOwner; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(181, 0LL) )
		  {
		    m_callbackOwner = (List_1_System_Object_ *)this->fields.m_callbackOwner;
		    if ( m_callbackOwner )
		    {
		      sub_182F01190(m_callbackOwner, (Object *)owner);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_callbackOwner, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(181, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)owner,
		    0LL);
		}
		
		internal unsafe void InvokeOwnerCallback(DynamicArray<AttachDesc> colorAttachments, object camera, void* customPayload, bool renderPassIssued) {} // 0x0000000189B2DA6C-0x0000000189B2DBC0
		// Void InvokeOwnerCallback(DynamicArray`1[HG.Rendering.RenderGraphModule.AttachDesc], Object, Void*, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::InvokeOwnerCallback(
		        HGRenderGraph *this,
		        DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments,
		        Object *camera,
		        Void *customPayload,
		        bool renderPassIssued,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  Il2CppExceptionWrapper *v11; // [rsp+40h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v12; // [rsp+48h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v13; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( !this->fields.m_callbackOwner )
		    sub_1800D8260(this, colorAttachments);
		  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		    (List_1_T_Enumerator_System_UInt64_ *)&v12,
		    (List_1_System_UInt64_ *)this->fields.m_callbackOwner,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::GetEnumerator);
		  v13 = v12;
		  v12._list = 0LL;
		  *(_QWORD *)&v12._index = &v13;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v13,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::MoveNext) )
		    {
		      if ( !v13._current )
		        sub_1800D8250(0LL, v10);
		      if ( *(_DWORD *)&v13._current->klass->_1.method_count == 3433 )
		        HG::Rendering::Runtime::HGRenderPathBase::HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_OnRenderPassExecution(
		          (HGRenderPathBase *)v13._current,
		          this,
		          colorAttachments,
		          camera,
		          customPayload,
		          renderPassIssued,
		          0LL);
		      else
		        sub_1808AD1DC(
		          v13._current,
		          v10,
		          v13._current,
		          (_DWORD)this,
		          (__int64)colorAttachments,
		          (__int64)camera,
		          (__int64)customPayload,
		          renderPassIssued);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v11 )
		  {
		    v12._list = (List_1_System_Object_ *)v11->ex;
		    if ( v12._list )
		      sub_18007E1E0(v12._list);
		  }
		}
		
		public HGRenderGraphExecution RecordAndExecute([IsReadOnly] in HGRenderGraphParameters parameters) => default; // 0x0000000189B2EB34-0x0000000189B2EDD0
		// HGRenderGraphExecution RecordAndExecute(HGRenderGraphParameters ByRef)
		HGRenderGraphExecution HG::Rendering::RenderGraphModule::HGRenderGraph::RecordAndExecute(
		        HGRenderGraph *this,
		        HGRenderGraphParameters *parameters,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  int32_t executorID; // r8d
		  Type *m_ExecutionCount; // rdx
		  char *m_Resources; // rcx
		  int32_t executorFrameIndex; // r9d
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  PropertyInfo_1 *v15; // r8
		  HGRenderGraphContext *m_RenderGraphContext; // r9
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  PropertyInfo_1 *v19; // r8
		  HGRenderGraphDebugParams *v20; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rdi
		  int32_t Length; // eax
		  int i; // edi
		  List_1_System_Int32___Array *m_ImmediateModeResourceList; // rbp
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v26; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v29; // [rsp+20h] [rbp-18h]
		  MethodInfo *v30; // [rsp+20h] [rbp-18h]
		  MethodInfo *v31; // [rsp+20h] [rbp-18h]
		  MethodInfo *v32; // [rsp+20h] [rbp-18h]
		  MethodInfo *v33; // [rsp+20h] [rbp-18h]
		  HGRenderGraph *v34; // [rsp+58h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(182, 0LL) )
		  {
		    this->fields.m_CurrentFrameIndex = parameters->currentFrameIndex;
		    this->fields.m_CurrentExecutionName = parameters->executionName;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CurrentExecutionName, v5, v6, v7, v29);
		    executorID = parameters->executorID;
		    m_ExecutionCount = (Type *)(unsigned int)this->fields.m_ExecutionCount;
		    m_Resources = (char *)this->fields.m_Resources;
		    this->fields.m_currentExecutorID = executorID;
		    executorFrameIndex = parameters->executorFrameIndex;
		    this->fields.m_currentExecutorFrameIndex = executorFrameIndex;
		    this->fields.m_ExecutionCount = (_DWORD)m_ExecutionCount + 1;
		    if ( m_Resources )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginRenderGraph(
		        (HGRenderGraphResourceRegistry *)m_Resources,
		        (int32_t)m_ExecutionCount,
		        executorID,
		        executorFrameIndex,
		        0LL);
		      m_DebugParameters = this->fields.m_DebugParameters;
		      if ( m_DebugParameters )
		      {
		        if ( m_DebugParameters->fields.enableLogging )
		        {
		          m_Resources = (char *)this->fields.m_FrameInformationLogger;
		          if ( !m_Resources )
		            goto LABEL_30;
		          HG::Rendering::RenderGraphModule::HGRenderGraphLogger::Initialize(
		            (HGRenderGraphLogger *)m_Resources,
		            this->fields.m_CurrentExecutionName,
		            0LL);
		        }
		        m_Resources = (char *)this->fields.m_DefaultResources;
		        if ( m_Resources )
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::InitializeForRendering(
		            (HGRenderGraphDefaultResources *)m_Resources,
		            this,
		            0LL);
		          m_Resources = (char *)this->fields.m_RenderGraphContext;
		          if ( m_Resources )
		          {
		            *((_QWORD *)m_Resources + 3) = parameters->commandBuffer;
		            sub_18002D1B0((SingleFieldAccessor *)(m_Resources + 24), m_ExecutionCount, v13, v14, v30);
		            m_RenderGraphContext = this->fields.m_RenderGraphContext;
		            if ( m_RenderGraphContext )
		            {
		              m_RenderGraphContext->fields.renderContext.m_Ptr = parameters->scriptableRenderContext.m_Ptr;
		              m_Resources = (char *)this->fields.m_RenderGraphContext;
		              if ( m_Resources )
		              {
		                *((_QWORD *)m_Resources + 4) = this->fields.m_RenderGraphPool;
		                sub_18002D1B0(
		                  (SingleFieldAccessor *)(m_Resources + 32),
		                  m_ExecutionCount,
		                  v15,
		                  (Int32__Array **)m_RenderGraphContext,
		                  v31);
		                m_Resources = (char *)this->fields.m_RenderGraphContext;
		                if ( m_Resources )
		                {
		                  *((_QWORD *)m_Resources + 5) = this->fields.m_DefaultResources;
		                  sub_18002D1B0((SingleFieldAccessor *)(m_Resources + 40), m_ExecutionCount, v17, v18, v32);
		                  v20 = this->fields.m_DebugParameters;
		                  if ( v20 )
		                  {
		                    if ( !v20->fields.immediateMode )
		                    {
		LABEL_27:
		                      v34 = this;
		                      sub_18002D1B0((SingleFieldAccessor *)&v34, m_ExecutionCount, v19, (Int32__Array **)v20, v33);
		                      return (HGRenderGraphExecution)v34;
		                    }
		                    HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(this, 0LL);
		                    m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		                    m_Resources = (char *)m_CompiledPassInfos;
		                    if ( m_CompiledPassInfos )
		                    {
		                      Length = System::Threading::SparselyPopulatedArrayFragment<System::Object>::get_Length(
		                                 (SparselyPopulatedArrayFragment_1_System_Object_ *)m_CompiledPassInfos,
		                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_capacity);
		                      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		                        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledPassInfos,
		                        Length,
		                        0,
		                        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
		                      this->fields.m_CurrentImmediatePassIndex = 0;
		                      for ( i = 0; i < 2; ++i )
		                      {
		                        m_Resources = (char *)this->fields.m_ImmediateModeResourceList;
		                        if ( !m_Resources )
		                          goto LABEL_30;
		                        if ( (unsigned int)i >= *((_DWORD *)m_Resources + 6) )
		                          goto LABEL_28;
		                        if ( !*(_QWORD *)&m_Resources[8 * i + 32] )
		                        {
		                          m_ImmediateModeResourceList = this->fields.m_ImmediateModeResourceList;
		                          v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		                          v26 = v25;
		                          if ( !v25 )
		                            goto LABEL_30;
		                          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		                            v25,
		                            MethodInfo::System::Collections::Generic::List<int>::List);
		                          sub_180031B10(m_ImmediateModeResourceList, v26);
		                          sub_1800020D0(m_ImmediateModeResourceList, i, v26);
		                        }
		                        m_Resources = (char *)this->fields.m_ImmediateModeResourceList;
		                        if ( !m_Resources )
		                          goto LABEL_30;
		                        if ( (unsigned int)i >= *((_DWORD *)m_Resources + 6) )
		LABEL_28:
		                          sub_1800D2AB0(m_Resources, m_ExecutionCount);
		                        m_Resources = *(char **)&m_Resources[8 * i + 32];
		                        if ( !m_Resources )
		                          goto LABEL_30;
		                        ++*((_DWORD *)m_Resources + 7);
		                        *((_DWORD *)m_Resources + 6) = 0;
		                      }
		                      m_Resources = (char *)this->fields.m_Resources;
		                      if ( m_Resources )
		                      {
		                        HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
		                          (HGRenderGraphResourceRegistry *)m_Resources,
		                          this->fields.m_CurrentFrameIndex,
		                          0LL);
		                        goto LABEL_27;
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
		LABEL_30:
		    sub_1800D8260(m_Resources, m_ExecutionCount);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(182, 0LL);
		  if ( !Patch )
		    goto LABEL_30;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_93(Patch, (Object *)this, parameters, 0LL);
		}
		
		internal void Execute() {} // 0x0000000189B2BB54-0x0000000189B2BDB4
		// Void Execute()
		// Hidden C++ exception states: #wind=1 #try_helpers=2
		void HG::Rendering::RenderGraphModule::HGRenderGraph::Execute(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v2; // rdx
		  HGRenderGraphContext *m_RenderGraphContext; // rax
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  ProtocolViolationException *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  String *v14; // rax
		  __int64 v15; // rax
		  HGRenderGraph **v16; // [rsp+40h] [rbp-18h] BYREF
		  HGRenderGraph *v17; // [rsp+60h] [rbp+8h] BYREF
		
		  v17 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(27, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(27, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v17, 0LL);
		  }
		  else
		  {
		    v17->fields.m_ExecutionExceptionWasRaised = 0;
		    v16 = &v17;
		    m_RenderGraphContext = v17->fields.m_RenderGraphContext;
		    if ( !m_RenderGraphContext )
		      sub_1800D8250(v17, v2);
		    if ( !m_RenderGraphContext->fields.cmd )
		    {
		      v7 = sub_180035ED0(&TypeInfo::System::InvalidOperationException);
		      v10 = (ProtocolViolationException *)sub_18002C620(v7);
		      if ( v10 )
		      {
		        v14 = (String *)sub_180035ED0(&off_18E2E0A90);
		        System::Net::ProtocolViolationException::ProtocolViolationException(v10, v14, 0LL);
		        v15 = sub_180035ED0(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::Execute);
		        sub_18007E190(v10, v15);
		      }
		      sub_1800D8250(v9, v8);
		    }
		    m_DebugParameters = v17->fields.m_DebugParameters;
		    if ( !m_DebugParameters )
		      sub_1800D8250(v17, v2);
		    if ( !m_DebugParameters->fields.immediateMode )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(v17, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::CompileRenderGraph(v17, 0LL);
		      m_Resources = v17->fields.m_Resources;
		      if ( !m_Resources )
		        sub_1800D8250(0LL, v5);
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
		        m_Resources,
		        v17->fields.m_CurrentFrameIndex,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteRenderGraph(v17, 0LL);
		    }
		    sub_182CB7FB0(&v16);
		  }
		}
		
		public void BeginProfilingSampler(ProfilingSampler sampler) {} // 0x0000000189B29218-0x0000000189B293D4
		// Void BeginProfilingSampler(ProfilingSampler)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::BeginProfilingSampler(
		        HGRenderGraph *this,
		        ProfilingSampler *sampler,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  unsigned int v7; // edx
		  unsigned __int64 v8; // r8
		  char v9; // dl
		  signed __int64 v10; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Il2CppExceptionWrapper *v14; // [rsp+48h] [rbp-50h] BYREF
		  _QWORD v15[4]; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+70h] [rbp-28h] BYREF
		  __int64 v17; // [rsp+B8h] [rbp+20h] BYREF
		
		  memset(&v16, 0, sizeof(v16));
		  v17 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(200, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(200, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)sampler,
		      0LL);
		  }
		  else
		  {
		    v16 = *(HGRenderGraphBuilder *)sub_1808AD1A8(v15, this, "BeginProfile", &v17);
		    v15[0] = 0LL;
		    v15[1] = &v16;
		    try
		    {
		      v6 = v17;
		      if ( !v17 )
		        sub_1800D8250(v5, 0LL);
		      *(_QWORD *)(v17 + 16) = sampler;
		      if ( dword_18F35FD08 )
		      {
		        v7 = ((unsigned __int64)(v6 + 16) >> 12) & 0x1FFFFF;
		        v8 = (unsigned __int64)v7 >> 6;
		        v9 = v7 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v8]);
		        do
		          v10 = qword_18F103690[v8];
		        while ( v10 != _InterlockedCompareExchange64(&qword_18F103690[v8], v10 | (1LL << v9), v10) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v16, 0, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(&v16, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v16,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_beginProfilingSamplerRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v15[0] = v14->ex;
		    }
		    sub_180268AE0(v15);
		  }
		}
		
		public void EndProfilingSampler(ProfilingSampler sampler) {} // 0x0000000189B2B470-0x0000000189B2B62C
		// Void EndProfilingSampler(ProfilingSampler)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::EndProfilingSampler(
		        HGRenderGraph *this,
		        ProfilingSampler *sampler,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  unsigned int v7; // edx
		  unsigned __int64 v8; // r8
		  char v9; // dl
		  signed __int64 v10; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Il2CppExceptionWrapper *v14; // [rsp+48h] [rbp-50h] BYREF
		  _QWORD v15[4]; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+70h] [rbp-28h] BYREF
		  __int64 v17; // [rsp+B8h] [rbp+20h] BYREF
		
		  memset(&v16, 0, sizeof(v16));
		  v17 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(215, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(215, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)sampler,
		      0LL);
		  }
		  else
		  {
		    v16 = *(HGRenderGraphBuilder *)sub_1808AD1A8(v15, this, "EndProfile", &v17);
		    v15[0] = 0LL;
		    v15[1] = &v16;
		    try
		    {
		      v6 = v17;
		      if ( !v17 )
		        sub_1800D8250(v5, 0LL);
		      *(_QWORD *)(v17 + 16) = sampler;
		      if ( dword_18F35FD08 )
		      {
		        v7 = ((unsigned __int64)(v6 + 16) >> 12) & 0x1FFFFF;
		        v8 = (unsigned __int64)v7 >> 6;
		        v9 = v7 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v8]);
		        do
		          v10 = qword_18F103690[v8];
		        while ( v10 != _InterlockedCompareExchange64(&qword_18F103690[v8], v10 | (1LL << v9), v10) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v16, 0, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(&v16, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v16,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->s_endProfilingSamplerRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v15[0] = v14->ex;
		    }
		    sub_180268AE0(v15);
		  }
		}
		
		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos() => default; // 0x0000000189B2CC44-0x0000000189B2CC94
		// DynamicArray`1[HG.Rendering.RenderGraphModule.HGRenderGraph+CompiledPassInfo] GetCompiledPassInfos()
		DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *HG::Rendering::RenderGraphModule::HGRenderGraph::GetCompiledPassInfos(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(216, 0LL) )
		    return this->fields.m_CompiledPassInfos;
		  Patch = IFix::WrappersManagerImpl::GetPatch(216, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(Patch, (Object *)this, 0LL);
		}
		
		internal void ClearCompiledGraph() {} // 0x0000000189B29954-0x0000000189B29A2C
		// Void ClearCompiledGraph()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCompiledGraph(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  int i; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(100, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraph::ClearRenderPasses(this, 0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(this, 0LL);
		    m_Resources = this->fields.m_Resources;
		    if ( m_Resources )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Clear(
		        m_Resources,
		        this->fields.m_ExecutionExceptionWasRaised,
		        0LL);
		      m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_RendererLists;
		      if ( m_Resources )
		      {
		        ++HIDWORD(m_Resources->fields.m_RendererListResources);
		        LODWORD(m_Resources->fields.m_RendererListResources) = 0;
		        for ( i = 0; i < 2; ++i )
		        {
		          m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_CompiledResourcesInfos;
		          if ( !m_Resources )
		            goto LABEL_13;
		          if ( (unsigned int)i >= LODWORD(m_Resources->fields.m_RendererListResources) )
		            sub_1800D2AB0(m_Resources, v3);
		          m_Resources = (HGRenderGraphResourceRegistry *)*((_QWORD *)&m_Resources->fields.m_RenderGraphDebug + i);
		          if ( !m_Resources )
		            goto LABEL_13;
		          UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
		            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Clear);
		        }
		        m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_CompiledPassInfos;
		        if ( m_Resources )
		        {
		          UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
		            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Clear);
		          return;
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(m_Resources, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(100, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void InvalidateContext() {} // 0x0000000189B2D9E0-0x0000000189B2DA6C
		// Void InvalidateContext()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::InvalidateContext(HGRenderGraph *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  HGRenderGraphContext *m_RenderGraphContext; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(107, 0LL) )
		  {
		    m_RenderGraphContext = this->fields.m_RenderGraphContext;
		    if ( m_RenderGraphContext )
		    {
		      m_RenderGraphContext->fields.cmd = 0LL;
		      sub_18002D1B0((SingleFieldAccessor *)&m_RenderGraphContext->fields.cmd, v3, v4, v5, v12);
		      m_RenderGraphContext = this->fields.m_RenderGraphContext;
		      if ( m_RenderGraphContext )
		      {
		        m_RenderGraphContext->fields.renderGraphPool = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&m_RenderGraphContext->fields.renderGraphPool, v3, v7, v8, v13);
		        m_RenderGraphContext = this->fields.m_RenderGraphContext;
		        if ( m_RenderGraphContext )
		        {
		          m_RenderGraphContext->fields.defaultResources = 0LL;
		          sub_18002D1B0((SingleFieldAccessor *)&m_RenderGraphContext->fields.defaultResources, v3, v9, v10, v14);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_RenderGraphContext, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(107, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void OnPassAdded(HGRenderGraphPass pass) {} // 0x0000000189B2E440-0x0000000189B2E4B4
		// Void OnPassAdded(HGRenderGraphPass)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::OnPassAdded(
		        HGRenderGraph *this,
		        HGRenderGraphPass *pass,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(209, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(209, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)pass,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  m_DebugParameters = this->fields.m_DebugParameters;
		  if ( !m_DebugParameters )
		    goto LABEL_6;
		  if ( m_DebugParameters->fields.immediateMode )
		    HG::Rendering::RenderGraphModule::HGRenderGraph::ExecutePassImmediatly(this, pass, 0LL);
		}
		
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count) {} // 0x0000000189B2D7D8-0x0000000189B2D884
		// Void InitResourceInfosData(DynamicArray`1[HG.Rendering.RenderGraphModule.HGRenderGraph+CompiledResourceInfo], Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(
		        HGRenderGraph *this,
		        DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *resourceInfos,
		        int32_t count,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t v9; // ebx
		  HGRenderGraph_CompiledResourceInfo *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(33, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(33, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
		        (ILFixDynamicMethodWrapper_15 *)Patch,
		        (Object *)this,
		        (Object *)resourceInfos,
		        count,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !resourceInfos )
		    goto LABEL_7;
		  UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		    (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)resourceInfos,
		    count,
		    0,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Resize);
		  while ( v9 < resourceInfos->fields._size_k__BackingField )
		  {
		    Item = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                                                   (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)resourceInfos,
		                                                   v9,
		                                                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo::Reset(Item, 0LL);
		    ++v9;
		  }
		}
		
		private void InitializeCompilationData() {} // 0x0000000189B2D884-0x0000000189B2D9E0
		// Void InitializeCompilationData()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::InitializeCompilationData(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v6; // rdi
		  int32_t TextureResourceCount; // eax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v8; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v9; // rdi
		  int32_t ComputeBufferResourceCount; // eax
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rax
		  int32_t i; // edi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  RenderGraph_CompiledPassInfo *Item; // rax
		  HGRenderGraph_CompiledPassInfo *v15; // rsi
		  Object *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(31, 0LL) )
		  {
		    m_CompiledResourcesInfos = this->fields.m_CompiledResourcesInfos;
		    if ( !m_CompiledResourcesInfos )
		      goto LABEL_17;
		    if ( m_CompiledResourcesInfos->max_length.size )
		    {
		      m_Resources = this->fields.m_Resources;
		      v6 = m_CompiledResourcesInfos->vector[0];
		      if ( !m_Resources )
		        goto LABEL_17;
		      TextureResourceCount = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceCount(
		                               m_Resources,
		                               0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(this, v6, TextureResourceCount, 0LL);
		      v8 = this->fields.m_CompiledResourcesInfos;
		      if ( !v8 )
		        goto LABEL_17;
		      if ( v8->max_length.size > 1u )
		      {
		        m_Resources = this->fields.m_Resources;
		        v9 = v8->vector[1];
		        if ( m_Resources )
		        {
		          ComputeBufferResourceCount = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceCount(
		                                         m_Resources,
		                                         0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(
		            this,
		            v9,
		            ComputeBufferResourceCount,
		            0LL);
		          m_RenderPasses = this->fields.m_RenderPasses;
		          m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_CompiledPassInfos;
		          if ( m_RenderPasses )
		          {
		            if ( m_Resources )
		            {
		              UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
		                m_RenderPasses->fields._size,
		                0,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
		              for ( i = 0; ; ++i )
		              {
		                m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		                if ( !m_CompiledPassInfos )
		                  break;
		                if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		                  return;
		                Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos,
		                         i,
		                         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		                m_Resources = (HGRenderGraphResourceRegistry *)this->fields.m_RenderPasses;
		                v15 = (HGRenderGraph_CompiledPassInfo *)Item;
		                if ( !m_Resources )
		                  break;
		                v16 = System::Collections::Generic::List<System::Object>::get_Item(
		                        (List_1_System_Object_ *)m_Resources,
		                        i,
		                        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
		                HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::Reset(
		                  v15,
		                  (HGRenderGraphPass *)v16,
		                  0LL);
		              }
		            }
		          }
		        }
		LABEL_17:
		        sub_1800D8260(m_Resources, v3);
		      }
		    }
		    sub_1800D2AB0(m_Resources, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(31, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void CountReferences() {} // 0x0000000189B2A428-0x0000000189B2AA48
		// Void CountReferences()
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CountReferences(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraph *v2; // r14
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rdx
		  _QWORD *p_klass; // rcx
		  unsigned int i; // esi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  RenderGraph_CompiledPassInfo *Item; // r15
		  int j; // edi
		  unsigned int v9; // r13d
		  List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
		  __int64 v11; // rax
		  __int64 v12; // r8
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // rbx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v15; // r12
		  int32_t v16; // eax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  RenderGraph_CompiledResourceInfo *v20; // rbx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  __int64 v22; // rdx
		  List_1_System_Int32_ *consumers; // rcx
		  RenderGraphPass__Class *klass; // rax
		  __int64 v25; // rdx
		  unsigned int v26; // r13d
		  __int64 v27; // rcx
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent v28; // rbx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v29; // rax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v30; // r12
		  int32_t v31; // eax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  __int64 v34; // rdx
		  RenderGraph_CompiledResourceInfo *v35; // rbx
		  HGRenderGraphResourceRegistry *v36; // rcx
		  __int64 v37; // rdx
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent v38; // rbx
		  int32_t v39; // eax
		  __int64 v40; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v41; // rdx
		  __int64 size; // rcx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v43; // rcx
		  __int64 v44; // rdx
		  RenderGraph_CompiledResourceInfo *v45; // rbx
		  List_1_System_Int32_ *v46; // rcx
		  __int64 v47; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  _BYTE v51[32]; // [rsp+0h] [rbp-F8h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v52; // [rsp+20h] [rbp-D8h] BYREF
		  int v53; // [rsp+38h] [rbp-C0h]
		  int v54; // [rsp+3Ch] [rbp-BCh]
		  unsigned int v55; // [rsp+40h] [rbp-B8h]
		  unsigned int v56; // [rsp+44h] [rbp-B4h]
		  RenderGraph_CompiledPassInfo *v57; // [rsp+48h] [rbp-B0h]
		  ResourceHandle res; // [rsp+50h] [rbp-A8h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v59; // [rsp+60h] [rbp-98h] BYREF
		  Il2CppException *ex; // [rsp+78h] [rbp-80h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v61; // [rsp+80h] [rbp-78h]
		  Il2CppException *v62; // [rsp+88h] [rbp-70h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v63; // [rsp+90h] [rbp-68h]
		  Il2CppException *v64; // [rsp+98h] [rbp-60h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v65; // [rsp+A0h] [rbp-58h]
		  Il2CppExceptionWrapper *v66; // [rsp+A8h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v67; // [rsp+B0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v68; // [rsp+B8h] [rbp-40h] BYREF
		  unsigned int v70; // [rsp+118h] [rbp+20h]
		
		  v2 = this;
		  memset(&v52, 0, sizeof(v52));
		  if ( IFix::WrappersManagerImpl::IsPatched(38, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(38, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v50, v49);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    for ( i = 0; ; ++i )
		    {
		      v70 = i;
		      m_CompiledPassInfos = v2->fields.m_CompiledPassInfos;
		      if ( !m_CompiledPassInfos )
		LABEL_77:
		        sub_1800D8250(p_klass, v3);
		      if ( (signed int)i >= m_CompiledPassInfos->fields._size_k__BackingField )
		        break;
		      Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2->fields.m_CompiledPassInfos,
		               i,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		      v57 = Item;
		      for ( j = 0; ; ++j )
		      {
		        v56 = j;
		        v55 = j;
		        v54 = j;
		        v9 = j;
		        v53 = j;
		        if ( j >= 2 )
		          break;
		        if ( !Item->pass )
		          sub_1800D8260(p_klass, v3);
		        dependsOnRendererListList = Item->pass->fields.dependsOnRendererListList;
		        if ( !dependsOnRendererListList )
		          sub_1800D8260(p_klass, v3);
		        if ( (unsigned int)j >= dependsOnRendererListList->fields._size )
		          sub_1800D2AB0(p_klass, v3);
		        v11 = *((_QWORD *)&dependsOnRendererListList->fields._syncRoot + j);
		        if ( !v11 )
		          sub_1800D8260(p_klass, v3);
		        v52 = *(List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)sub_1808AD2E0(&v59, v11);
		        ex = 0LL;
		        v61 = &v52;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                    &v52,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		          {
		            current = v52._current;
		            res = (ResourceHandle)v52._current;
		            m_CompiledResourcesInfos = v2->fields.m_CompiledResourcesInfos;
		            if ( !m_CompiledResourcesInfos )
		              sub_1800D8250(p_klass, v3);
		            if ( (unsigned int)j >= m_CompiledResourcesInfos->max_length.size )
		              sub_1800D2AA0(p_klass, v3, v12);
		            v15 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos->vector[j];
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		            v16 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		            if ( !v15 )
		              sub_1800D8250(v18, v17);
		            v20 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                    v15,
		                    v16,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		            m_Resources = v2->fields.m_Resources;
		            if ( !m_Resources )
		              sub_1800D8250(0LL, v19);
		            v20->imported = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		                              m_Resources,
		                              &res,
		                              0LL);
		            consumers = v20->consumers;
		            if ( !consumers )
		              sub_1800D8250(0LL, v22);
		            sub_183081250(consumers, i, MethodInfo::System::Collections::Generic::List<int>::Add);
		            ++v20->refCount;
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v66 )
		        {
		          v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v51;
		          ex = v66->ex;
		          p_klass = &ex->object.klass;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v2 = this;
		          i = v70;
		          Item = v57;
		          v9 = v53;
		        }
		        if ( !Item->pass )
		          goto LABEL_77;
		        klass = Item->pass[1].klass;
		        if ( !klass )
		          goto LABEL_77;
		        v25 = j;
		        if ( v9 >= LODWORD(klass->_0.namespaze) )
		          goto LABEL_76;
		        v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&klass->_0.byval_arg.data.dummy + j);
		        if ( !v3 )
		          goto LABEL_77;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		          (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v59,
		          v3,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		        v52 = v59;
		        v62 = 0LL;
		        v63 = &v52;
		        try
		        {
		          v26 = v54;
		          while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                    &v52,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		          {
		            v28 = v52._current;
		            res = (ResourceHandle)v52._current;
		            v29 = v2->fields.m_CompiledResourcesInfos;
		            if ( !v29 )
		              sub_1800D8250(v27, v3);
		            if ( v26 >= v29->max_length.size )
		              sub_1800D2AA0(v27, v3, v12);
		            v30 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v29->vector[j];
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		            v31 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v28, 0LL);
		            if ( !v30 )
		              sub_1800D8250(v33, v32);
		            v35 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                    v30,
		                    v31,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		            v36 = v2->fields.m_Resources;
		            if ( !v36 )
		              sub_1800D8250(0LL, v34);
		            v35->imported = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		                              v36,
		                              &res,
		                              0LL);
		            if ( !v35->producers )
		              sub_1800D8250(0LL, v37);
		            sub_183081250(v35->producers, i, MethodInfo::System::Collections::Generic::List<int>::Add);
		            Item->hasSideEffect = v35->imported;
		            ++Item->refCount;
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v67 )
		        {
		          v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v51;
		          v62 = v67->ex;
		          if ( v62 )
		            sub_18007E1E0(v62);
		          v2 = this;
		          i = v70;
		          Item = v57;
		        }
		        p_klass = &Item->pass->klass;
		        if ( !Item->pass )
		          goto LABEL_77;
		        p_klass = (_QWORD *)p_klass[17];
		        if ( !p_klass )
		          goto LABEL_77;
		        v25 = j;
		        if ( v55 >= *((_DWORD *)p_klass + 6) )
		LABEL_76:
		          sub_1800D2AA0(p_klass, v25, v12);
		        v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)p_klass[j + 4];
		        if ( !v3 )
		          goto LABEL_77;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		          (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v59,
		          v3,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		        v52 = v59;
		        v64 = 0LL;
		        v65 = &v52;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                    &v52,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		          {
		            v38 = v52._current;
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		            v39 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v38, 0LL);
		            v41 = v2->fields.m_CompiledResourcesInfos;
		            if ( !v41 )
		              sub_1800D8250(v40, 0LL);
		            size = (unsigned int)v41->max_length.size;
		            if ( v56 >= (unsigned int)size )
		              sub_1800D2AA0(size, v41, j);
		            v43 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v41->vector[j];
		            if ( !v43 )
		              sub_1800D8250(0LL, v41);
		            v45 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                    v43,
		                    v39,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		            ++v45->refCount;
		            v46 = v45->consumers;
		            if ( !v46 )
		              sub_1800D8250(0LL, v44);
		            sub_183081250(v46, i, MethodInfo::System::Collections::Generic::List<int>::Add);
		            if ( !v45->producers )
		              sub_1800D8250(0LL, v47);
		            sub_183081250(v45->producers, i, MethodInfo::System::Collections::Generic::List<int>::Add);
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v68 )
		        {
		          v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v51;
		          v64 = v68->ex;
		          p_klass = &v64->object.klass;
		          if ( v64 )
		            sub_18007E1E0(v64);
		          v2 = this;
		          i = v70;
		          Item = v57;
		        }
		      }
		    }
		  }
		}
		
		private void CullUnusedPasses() {} // 0x0000000189B2AF7C-0x0000000189B2B470
		// Void CullUnusedPasses()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CullUnusedPasses(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraph *v2; // rsi
		  __int64 *v3; // rdx
		  Il2CppException *v4; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rbx
		  int i; // r14d
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v8; // r15
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v9; // r13
		  Stack_1_System_Int32_ *m_CullingStack; // rbx
		  int32_t j; // ebx
		  Stack_1_System_Int32_ *v12; // rax
		  int32_t v13; // eax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  RenderGraph_CompiledResourceInfo *Item; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rcx
		  HGRenderGraph_CompiledPassInfo *v20; // rax
		  HGRenderGraph_CompiledPassInfo *v21; // rbx
		  int v22; // ecx
		  __int64 v23; // rdx
		  __int64 v24; // r8
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceReadLists; // rcx
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v26; // rdx
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // rbx
		  int32_t v28; // eax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  RenderGraph_CompiledResourceInfo *v31; // rax
		  int v32; // ecx
		  Stack_1_System_Int32_ *v33; // r12
		  int32_t v34; // eax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  HGRenderGraphLogger *m_FrameInformationLogger; // rbx
		  Object__Array *v38; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  __int64 v44; // [rsp+0h] [rbp-D8h] BYREF
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v45; // [rsp+28h] [rbp-B0h]
		  List_1_T_Enumerator_System_Int32_ v46; // [rsp+30h] [rbp-A8h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v47; // [rsp+48h] [rbp-90h] BYREF
		  List_1_T_Enumerator_System_Int32_ v48; // [rsp+60h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+78h] [rbp-60h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v50; // [rsp+80h] [rbp-58h]
		  Il2CppException *v51; // [rsp+88h] [rbp-50h]
		  List_1_T_Enumerator_System_Int32_ *v52; // [rsp+90h] [rbp-48h]
		  Il2CppExceptionWrapper *v53; // [rsp+98h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+A0h] [rbp-38h] BYREF
		  int v56; // [rsp+F0h] [rbp+18h]
		  unsigned int v57; // [rsp+F8h] [rbp+20h]
		
		  v2 = this;
		  memset(&v46, 0, sizeof(v46));
		  memset(&v47, 0, sizeof(v47));
		  if ( IFix::WrappersManagerImpl::IsPatched(46, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(46, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v43, v42);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    m_DebugParameters = v2->fields.m_DebugParameters;
		    if ( !m_DebugParameters )
		      sub_1800D8260(v4, v3);
		    if ( m_DebugParameters->fields.disablePassCulling )
		    {
		      if ( m_DebugParameters->fields.enableLogging )
		      {
		        m_FrameInformationLogger = v2->fields.m_FrameInformationLogger;
		        v38 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		        if ( !m_FrameInformationLogger )
		          sub_1800D8260(v40, v39);
		        HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		          m_FrameInformationLogger,
		          (String *)"- Pass Culling Disabled -\n",
		          v38,
		          0LL);
		      }
		    }
		    else
		    {
		      for ( i = 0; ; ++i )
		      {
		        v56 = i;
		        v57 = i;
		        if ( i >= 2 )
		          break;
		        m_CompiledResourcesInfos = v2->fields.m_CompiledResourcesInfos;
		        if ( !m_CompiledResourcesInfos )
		          sub_1800D8260(v4, v3);
		        if ( (unsigned int)i >= m_CompiledResourcesInfos->max_length.size )
		          sub_1800D2AB0(v4, v3);
		        v8 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos->vector[i];
		        v9 = v8;
		        v45 = v8;
		        m_CullingStack = v2->fields.m_CullingStack;
		        if ( !m_CullingStack )
		          sub_1800D8260(v4, v3);
		        m_CullingStack->fields._size = 0;
		        ++m_CullingStack->fields._version;
		        for ( j = 0; ; ++j )
		        {
		          if ( !v8 )
		            sub_1800D8260(v4, v3);
		          if ( j >= v8->fields._size_k__BackingField )
		            break;
		          if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                  v8,
		                  j,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item)->refCount )
		          {
		            if ( !v2->fields.m_CullingStack )
		              sub_1800D8260(v4, v3);
		            System::Collections::Generic::Stack<int>::Push(
		              v2->fields.m_CullingStack,
		              j,
		              MethodInfo::System::Collections::Generic::Stack<int>::Push);
		          }
		        }
		        while ( 1 )
		        {
		          v12 = v2->fields.m_CullingStack;
		          if ( !v12 )
		            sub_1800D8250(v4, v3);
		          if ( !v12->fields._size )
		            break;
		          v13 = System::Collections::Generic::Stack<int>::Pop(
		                  v2->fields.m_CullingStack,
		                  MethodInfo::System::Collections::Generic::Stack<int>::Pop);
		          if ( !v9 )
		            sub_1800D8260(v15, v14);
		          Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                   v9,
		                   v13,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		          *(_QWORD *)&v48._current = *(_QWORD *)&Item->refCount;
		          if ( !Item->producers )
		            sub_1800D8260(v18, v17);
		          System::Collections::Generic::List<int>::GetEnumerator(
		            &v48,
		            Item->producers,
		            MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		          v46 = v48;
		          v51 = 0LL;
		          v52 = &v46;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                      &v46,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		            {
		              m_CompiledPassInfos = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2->fields.m_CompiledPassInfos;
		              if ( !m_CompiledPassInfos )
		                sub_1800D8250(0LL, v3);
		              v20 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                                        m_CompiledPassInfos,
		                                                        v46._current,
		                                                        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		              v21 = v20;
		              v22 = v20->refCount - 1;
		              v20->refCount = v22;
		              if ( !v22
		                && !v20->hasSideEffect
		                && HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::get_allowPassCulling(v20, 0LL) )
		              {
		                v21->culled = 1;
		                if ( !v21->pass )
		                  sub_1800D8250(0LL, v23);
		                resourceReadLists = v21->pass->fields.resourceReadLists;
		                if ( !resourceReadLists )
		                  sub_1800D8250(0LL, v23);
		                if ( v57 >= resourceReadLists->max_length.size )
		                  sub_1800D2AA0(resourceReadLists, i, v24);
		                v26 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)resourceReadLists->vector[i];
		                if ( !v26 )
		                  sub_1800D8250(resourceReadLists, 0LL);
		                System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		                  (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v48,
		                  v26,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		                v47 = (List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_)v48;
		                ex = 0LL;
		                v50 = &v47;
		                try
		                {
		                  while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                            &v47,
		                            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		                  {
		                    current = v47._current;
		                    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		                    v28 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		                    if ( !v9 )
		                      sub_1800D8250(v30, v29);
		                    v31 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                            v9,
		                            v28,
		                            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		                    v32 = v31->refCount - 1;
		                    v31->refCount = v32;
		                    if ( !v32 )
		                    {
		                      v33 = v2->fields.m_CullingStack;
		                      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		                      v34 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		                      if ( !v33 )
		                        sub_1800D8250(v36, v35);
		                      System::Collections::Generic::Stack<int>::Push(
		                        v33,
		                        v34,
		                        MethodInfo::System::Collections::Generic::Stack<int>::Push);
		                    }
		                  }
		                }
		                catch ( Il2CppExceptionWrapper *v53 )
		                {
		                  ex = v53->ex;
		                  if ( ex )
		                    sub_18007E1E0(ex);
		                  v2 = this;
		                  i = v56;
		                  v9 = v45;
		                }
		              }
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v54 )
		          {
		            v3 = &v44;
		            v51 = v54->ex;
		            v4 = v51;
		            if ( v51 )
		              sub_18007E1E0(v51);
		            v2 = this;
		            i = v56;
		            v9 = v45;
		          }
		        }
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraph::LogCulledPasses(v2, 0LL);
		    }
		  }
		}
		
		internal bool CheckIfResBeenUpdated(ResourceHandle resource, int passIndex) => default; // 0x0000000189B293D4-0x0000000189B29540
		// Boolean CheckIfResBeenUpdated(ResourceHandle, Int32)
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::CheckIfResBeenUpdated(
		        HGRenderGraph *this,
		        ResourceHandle resource,
		        int32_t passIndex,
		        MethodInfo *method)
		{
		  int32_t i; // ebx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rdi
		  int32_t iType; // eax
		  __int64 v10; // rdx
		  List_1_System_Int32_ *producers; // rcx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v12; // rdi
		  int32_t v13; // eax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v14; // rdi
		  int32_t v15; // eax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v16; // rdi
		  int32_t v17; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle handle; // [rsp+48h] [rbp+10h] BYREF
		
		  handle = resource;
		  if ( IFix::WrappersManagerImpl::IsPatched(217, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(217, 0LL);
		    if ( !Patch )
		LABEL_18:
		      sub_1800D8260(producers, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_100(Patch, (Object *)this, resource, passIndex, 0LL);
		  }
		  else
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_CompiledResourcesInfos = this->fields.m_CompiledResourcesInfos;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		      iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&handle, 0LL);
		      if ( !m_CompiledResourcesInfos )
		        goto LABEL_18;
		      if ( (unsigned int)iType >= m_CompiledResourcesInfos->max_length.size )
		        goto LABEL_16;
		      v12 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos->vector[iType];
		      v13 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		      if ( !v12 )
		        goto LABEL_18;
		      producers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                    v12,
		                    v13,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item)->producers;
		      if ( !producers )
		        goto LABEL_18;
		      if ( i >= producers->fields._size )
		        break;
		      v14 = this->fields.m_CompiledResourcesInfos;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		      v15 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&handle, 0LL);
		      if ( !v14 )
		        goto LABEL_18;
		      if ( (unsigned int)v15 >= v14->max_length.size )
		LABEL_16:
		        sub_1800D2AB0(producers, v10);
		      v16 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v14->vector[v15];
		      v17 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		      if ( !v16 )
		        goto LABEL_18;
		      producers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                    v16,
		                    v17,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item)->producers;
		      if ( !producers )
		        goto LABEL_18;
		      if ( System::Collections::Generic::List<int>::get_Item(
		             producers,
		             i,
		             MethodInfo::System::Collections::Generic::List<int>::get_Item) < passIndex )
		        return 1;
		    }
		    return 0;
		  }
		}
		
		internal bool CheckIfResWillBeUsed(ResourceHandle resource, int passIndex) => default; // 0x0000000189B29540-0x0000000189B29770
		// Boolean CheckIfResWillBeUsed(ResourceHandle, Int32)
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::CheckIfResWillBeUsed(
		        HGRenderGraph *this,
		        ResourceHandle resource,
		        int32_t passIndex,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
		  int32_t iType; // eax
		  __int64 v9; // rdx
		  List_1_System_Int32_ *consumers; // rcx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v11; // rbx
		  int32_t v12; // eax
		  RenderGraph_CompiledResourceInfo *Item; // rax
		  int32_t i; // ebx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v15; // rdi
		  int32_t v16; // eax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v17; // rdi
		  int32_t v18; // eax
		  int32_t j; // ebx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v20; // rdi
		  int32_t v21; // eax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v22; // rdi
		  int32_t v23; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v26; // [rsp+30h] [rbp-30h]
		  ResourceHandle handle; // [rsp+88h] [rbp+28h] BYREF
		
		  handle = resource;
		  if ( IFix::WrappersManagerImpl::IsPatched(218, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(218, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_100(Patch, (Object *)this, resource, passIndex, 0LL);
		LABEL_28:
		    sub_1800D8260(consumers, v9);
		  }
		  m_CompiledResourcesInfos = this->fields.m_CompiledResourcesInfos;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&handle, 0LL);
		  if ( !m_CompiledResourcesInfos )
		    goto LABEL_28;
		  if ( (unsigned int)iType >= m_CompiledResourcesInfos->max_length.size )
		LABEL_26:
		    sub_1800D2AB0(consumers, v9);
		  v11 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos->vector[iType];
		  v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		  if ( !v11 )
		    goto LABEL_28;
		  Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		           v11,
		           v12,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		  v26 = *(_OWORD *)&Item->producers;
		  if ( (unsigned __int8)BYTE4(*(_QWORD *)&Item->refCount) )
		    return 1;
		  for ( i = 0; ; ++i )
		  {
		    if ( !*((_QWORD *)&v26 + 1) )
		      goto LABEL_28;
		    if ( i >= *(_DWORD *)(*((_QWORD *)&v26 + 1) + 24LL) )
		      break;
		    v15 = this->fields.m_CompiledResourcesInfos;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    v16 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&handle, 0LL);
		    if ( !v15 )
		      goto LABEL_28;
		    if ( (unsigned int)v16 >= v15->max_length.size )
		      goto LABEL_26;
		    v17 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v15->vector[v16];
		    v18 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		    if ( !v17 )
		      goto LABEL_28;
		    consumers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                  v17,
		                  v18,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item)->consumers;
		    if ( !consumers )
		      goto LABEL_28;
		    if ( System::Collections::Generic::List<int>::get_Item(
		           consumers,
		           i,
		           MethodInfo::System::Collections::Generic::List<int>::get_Item) > passIndex )
		      return 1;
		  }
		  for ( j = 0; ; ++j )
		  {
		    if ( !(_QWORD)v26 )
		      goto LABEL_28;
		    if ( j >= *(_DWORD *)(v26 + 24) )
		      break;
		    v20 = this->fields.m_CompiledResourcesInfos;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    v21 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&handle, 0LL);
		    if ( !v20 )
		      goto LABEL_28;
		    if ( (unsigned int)v21 >= v20->max_length.size )
		      goto LABEL_26;
		    v22 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v20->vector[v21];
		    v23 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		    if ( !v22 )
		      goto LABEL_28;
		    consumers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                  v22,
		                  v23,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item)->producers;
		    if ( !consumers )
		      goto LABEL_28;
		    if ( System::Collections::Generic::List<int>::get_Item(
		           consumers,
		           j,
		           MethodInfo::System::Collections::Generic::List<int>::get_Item) > passIndex )
		      return 1;
		  }
		  return 0;
		}
		
		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) {} // 0x0000000189B2F3AC-0x0000000189B2F450
		// Void UpdatePassSynchronization(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraph+CompiledPassInfo ByRef, Int32, Int32, Int32 ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledPassInfo *currentPassInfo,
		        HGRenderGraph_CompiledPassInfo *producerPassInfo,
		        int32_t currentPassIndex,
		        int32_t lastProducer,
		        int32_t *intLastSyncIndex,
		        MethodInfo *method)
		{
		  bool v11; // zf
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(68, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(68, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_35(
		      Patch,
		      (Object *)this,
		      currentPassInfo,
		      producerPassInfo,
		      currentPassIndex,
		      lastProducer,
		      intLastSyncIndex,
		      0LL);
		  }
		  else
		  {
		    currentPassInfo->syncToPassIndex = lastProducer;
		    *intLastSyncIndex = lastProducer;
		    v11 = producerPassInfo->syncFromPassIndex == -1;
		    producerPassInfo->needGraphicsFence = 1;
		    if ( v11 )
		      producerPassInfo->syncFromPassIndex = currentPassIndex;
		  }
		}
		
		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [IsReadOnly] in CompiledResourceInfo resource) {} // 0x0000000189B2FCFC-0x0000000189B2FE6C
		// Void UpdateResourceSynchronization(Int32 ByRef, Int32 ByRef, Int32, HGRenderGraph+CompiledResourceInfo ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
		        HGRenderGraph *this,
		        int32_t *lastGraphicsPipeSync,
		        int32_t *lastComputePipeSync,
		        int32_t currentPassIndex,
		        HGRenderGraph_CompiledResourceInfo *resource,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  int32_t lastProducer; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  RenderGraph_CompiledPassInfo *Item; // rax
		  HGRenderGraph_CompiledPassInfo *v14; // rbp
		  RenderGraph_CompiledPassInfo *v15; // rax
		  bool enableAsyncCompute; // cl
		  HGRenderGraph_CompiledPassInfo *v17; // rax
		  HGRenderGraph_CompiledPassInfo *v18; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(66, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(66, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_36(
		        Patch,
		        (Object *)this,
		        lastGraphicsPipeSync,
		        lastComputePipeSync,
		        currentPassIndex,
		        resource,
		        0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(Patch, v10);
		  }
		  lastProducer = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestProducerIndex(
		                   this,
		                   currentPassIndex,
		                   resource,
		                   0LL);
		  if ( lastProducer == -1 )
		    return;
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CompiledPassInfos;
		  if ( !Patch )
		    goto LABEL_15;
		  Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		           (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
		           currentPassIndex,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CompiledPassInfos;
		  v14 = (HGRenderGraph_CompiledPassInfo *)Item;
		  if ( !Patch )
		    goto LABEL_15;
		  v15 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		          (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
		          lastProducer,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		  enableAsyncCompute = v14->enableAsyncCompute;
		  if ( v15->enableAsyncCompute == enableAsyncCompute )
		    return;
		  if ( enableAsyncCompute )
		  {
		    if ( lastProducer <= *lastGraphicsPipeSync )
		      return;
		    Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CompiledPassInfos;
		    if ( Patch )
		    {
		      v18 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
		                                                lastProducer,
		                                                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
		        this,
		        v14,
		        v18,
		        currentPassIndex,
		        lastProducer,
		        lastGraphicsPipeSync,
		        0LL);
		      return;
		    }
		    goto LABEL_15;
		  }
		  if ( lastProducer <= *lastComputePipeSync )
		    return;
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CompiledPassInfos;
		  if ( !Patch )
		    goto LABEL_15;
		  v17 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
		                                            lastProducer,
		                                            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
		    this,
		    v14,
		    v17,
		    currentPassIndex,
		    lastProducer,
		    lastComputePipeSync,
		    0LL);
		}
		
		private int GetLatestProducerIndex(int passIndex, [IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189B2CF70-0x0000000189B2D0AC
		// Int32 GetLatestProducerIndex(Int32, HGRenderGraph+CompiledResourceInfo ByRef)
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestProducerIndex(
		        HGRenderGraph *this,
		        int32_t passIndex,
		        HGRenderGraph_CompiledResourceInfo *info,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t current; // ebx
		  List_1_System_Int32_ *producers; // rdi
		  bool v11; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  int32_t v16; // [rsp+30h] [rbp-48h]
		  Il2CppExceptionWrapper *v17; // [rsp+38h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Int32_ v18; // [rsp+40h] [rbp-38h] BYREF
		  List_1_T_Enumerator_System_Int32_ v19; // [rsp+58h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(67, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(67, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(Patch, (Object *)this, passIndex, info, 0LL);
		  }
		  current = -1;
		  v16 = -1;
		  producers = info->producers;
		  if ( !producers )
		    sub_1800D8260(v8, v7);
		  System::Collections::Generic::List<int>::GetEnumerator(
		    &v18,
		    producers,
		    MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		  v19 = v18;
		  v18._list = 0LL;
		  *(_QWORD *)&v18._index = &v19;
		  while ( 1 )
		  {
		    try
		    {
		      v11 = System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		              &v19,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      v18._list = (List_1_System_Int32_ *)v17->ex;
		      if ( v18._list )
		        sub_18007E1E0(v18._list);
		      return v16;
		    }
		    if ( !v11 || v19._current >= passIndex )
		      return current;
		    current = v19._current;
		    v16 = v19._current;
		  }
		}
		
		private int GetLatestValidReadIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189B2D0AC-0x0000000189B2D178
		// Int32 GetLatestValidReadIndex(HGRenderGraph+CompiledResourceInfo ByRef)
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidReadIndex(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledResourceInfo *info,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_Int32_ *consumers; // rax
		  int32_t size; // ebx
		  List_1_System_Int32_ *v9; // rdi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rsi
		  int32_t Item; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(70, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(70, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(Patch, (Object *)this, info, 0LL);
		LABEL_11:
		    sub_1800D8260(v6, v5);
		  }
		  consumers = info->consumers;
		  if ( !consumers )
		    goto LABEL_11;
		  if ( consumers->fields._size )
		  {
		    size = consumers->fields._size;
		    v9 = consumers;
		    while ( --size >= 0 )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      Item = System::Collections::Generic::List<int>::get_Item(
		               v9,
		               size,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      if ( !m_CompiledPassInfos )
		        goto LABEL_11;
		      if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		              Item,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		        return System::Collections::Generic::List<int>::get_Item(
		                 v9,
		                 size,
		                 MethodInfo::System::Collections::Generic::List<int>::get_Item);
		    }
		  }
		  return -1;
		}
		
		private int GetFirstValidWriteIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189B2CEA4-0x0000000189B2CF70
		// Int32 GetFirstValidWriteIndex(HGRenderGraph+CompiledResourceInfo ByRef)
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetFirstValidWriteIndex(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledResourceInfo *info,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_Int32_ *producers; // rdi
		  int32_t i; // ebx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rsi
		  int32_t Item; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(69, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(69, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(Patch, (Object *)this, info, 0LL);
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !info->producers )
		    goto LABEL_12;
		  if ( info->producers->fields._size )
		  {
		    producers = info->producers;
		    for ( i = 0; i < producers->fields._size; ++i )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      Item = System::Collections::Generic::List<int>::get_Item(
		               producers,
		               i,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      if ( !m_CompiledPassInfos )
		        goto LABEL_12;
		      if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		              Item,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		        return System::Collections::Generic::List<int>::get_Item(
		                 producers,
		                 i,
		                 MethodInfo::System::Collections::Generic::List<int>::get_Item);
		    }
		  }
		  return -1;
		}
		
		private int GetLatestValidWriteIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189B2D178-0x0000000189B2D244
		// Int32 GetLatestValidWriteIndex(HGRenderGraph+CompiledResourceInfo ByRef)
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidWriteIndex(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledResourceInfo *info,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_Int32_ *producers; // rax
		  int32_t size; // ebx
		  List_1_System_Int32_ *v9; // rdi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rsi
		  int32_t Item; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(71, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(71, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(Patch, (Object *)this, info, 0LL);
		LABEL_11:
		    sub_1800D8260(v6, v5);
		  }
		  producers = info->producers;
		  if ( !info->producers )
		    goto LABEL_11;
		  if ( producers->fields._size )
		  {
		    size = producers->fields._size;
		    v9 = producers;
		    while ( --size >= 0 )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      Item = System::Collections::Generic::List<int>::get_Item(
		               v9,
		               size,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      if ( !m_CompiledPassInfos )
		        goto LABEL_11;
		      if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		              Item,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		        return System::Collections::Generic::List<int>::get_Item(
		                 v9,
		                 size,
		                 MethodInfo::System::Collections::Generic::List<int>::get_Item);
		    }
		  }
		  return -1;
		}
		
		private void CreateRendererLists() {} // 0x0000000189B2ABC8-0x0000000189B2AC90
		// Void CreateRendererLists()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererLists(HGRenderGraph *this, MethodInfo *method)
		{
		  RenderGraphPass *pass; // rdx
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *m_RendererLists; // rcx
		  int32_t i; // edi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  RenderGraph_CompiledPassInfo *Item; // rax
		  HGRenderGraphContext *m_RenderGraphContext; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(55, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      if ( !m_CompiledPassInfos )
		        goto LABEL_14;
		      if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		        break;
		      Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos,
		               i,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		      if ( !Item->culled )
		      {
		        pass = Item->pass;
		        if ( !Item->pass )
		          goto LABEL_14;
		        m_RendererLists = this->fields.m_RendererLists;
		        if ( !m_RendererLists )
		          goto LABEL_14;
		        System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::AddRange(
		          m_RendererLists,
		          (IEnumerable_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)pass[1].fields._name_k__BackingField,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::AddRange);
		      }
		    }
		    m_RenderGraphContext = this->fields.m_RenderGraphContext;
		    m_RendererLists = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)this->fields.m_Resources;
		    if ( m_RenderGraphContext && m_RendererLists )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
		        (HGRenderGraphResourceRegistry *)m_RendererLists,
		        this->fields.m_RendererLists,
		        m_RenderGraphContext->fields.renderContext,
		        1,
		        0LL);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(m_RendererLists, pass);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(55, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void UpdateResourceAllocationAndSynchronization() {} // 0x0000000189B2F450-0x0000000189B2FCFC
		// Void UpdateResourceAllocationAndSynchronization()
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  HGRenderGraph *v2; // r15
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rdx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *producers; // rcx
		  __int64 v5; // r8
		  int32_t i; // r14d
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  HGRenderGraph *v8; // r13
		  RenderGraph_CompiledPassInfo *Item; // r13
		  int j; // edi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v12; // r12
		  List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
		  __int64 v14; // rax
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // rbx
		  int32_t v16; // eax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  HGRenderGraph_CompiledResourceInfo *resource; // rax
		  RenderGraphPass__Class *klass; // rax
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent v21; // rbx
		  int32_t v22; // eax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  HGRenderGraph_CompiledResourceInfo *v25; // rax
		  int32_t v26; // edi
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v27; // rax
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v28; // rax
		  __int64 v29; // rbx
		  unsigned int v30; // r14d
		  int32_t v31; // eax
		  int32_t LatestValidReadIndex; // ebx
		  int32_t v33; // r12d
		  RenderGraph_CompiledPassInfo *v34; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v35; // r9
		  int32_t syncFromPassIndex; // r12d
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v37; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v38; // rax
		  List_1_System_Object_ *m_RenderPasses; // rbx
		  MethodInfo *v40; // rax
		  Object *v41; // rax
		  String *v42; // rdi
		  String *v43; // rbx
		  String *v44; // rax
		  String *v45; // r14
		  __int64 v46; // rbx
		  __int64 *v47; // rax
		  __int64 v48; // rcx
		  __int64 v49; // rdx
		  ProtocolViolationException *v50; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  __int64 v54; // rax
		  _BYTE v55[32]; // [rsp+0h] [rbp-108h] BYREF
		  __int64 (__fastcall *v56)(_QWORD, _QWORD); // [rsp+28h] [rbp-E0h]
		  int32_t lastComputePipeSync; // [rsp+30h] [rbp-D8h] BYREF
		  int32_t lastGraphicsPipeSync; // [rsp+34h] [rbp-D4h] BYREF
		  unsigned int v59; // [rsp+38h] [rbp-D0h]
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v60; // [rsp+40h] [rbp-C8h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v61; // [rsp+48h] [rbp-C0h] BYREF
		  HGRenderGraph_CompiledResourceInfo info; // [rsp+60h] [rbp-A8h] BYREF
		  RenderGraph_CompiledPassInfo *v63; // [rsp+80h] [rbp-88h]
		  HGRenderGraph *v64; // [rsp+88h] [rbp-80h]
		  Il2CppException *ex; // [rsp+A0h] [rbp-68h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v66; // [rsp+A8h] [rbp-60h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v67; // [rsp+B0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v68; // [rsp+C8h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v69; // [rsp+D0h] [rbp-38h] BYREF
		  __int64 *index; // [rsp+120h] [rbp+18h] BYREF
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *v72; // [rsp+128h] [rbp+20h] BYREF
		
		  v2 = this;
		  v64 = this;
		  memset(&v61, 0, sizeof(v61));
		  if ( !IFix::WrappersManagerImpl::IsPatched(65, 0LL) )
		  {
		    lastGraphicsPipeSync = -1;
		    lastComputePipeSync = -1;
		    for ( i = 0; ; ++i )
		    {
		      LODWORD(v72) = i;
		      m_CompiledPassInfos = v2->fields.m_CompiledPassInfos;
		      if ( !m_CompiledPassInfos )
		        goto LABEL_110;
		      v8 = v64;
		      if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		        break;
		      Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v64->fields.m_CompiledPassInfos,
		               i,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		      v63 = Item;
		      if ( !Item->culled )
		      {
		        for ( j = 0; ; ++j )
		        {
		          LODWORD(index) = j;
		          v59 = j;
		          if ( j >= 2 )
		            break;
		          m_CompiledResourcesInfos = v2->fields.m_CompiledResourcesInfos;
		          if ( !m_CompiledResourcesInfos )
		            sub_1800D8260(producers, v3);
		          if ( (unsigned int)j >= m_CompiledResourcesInfos->max_length.size )
		            sub_1800D2AB0(producers, v3);
		          v12 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos->vector[j];
		          v60 = v12;
		          if ( !Item->pass )
		            sub_1800D8260(producers, v3);
		          dependsOnRendererListList = Item->pass->fields.dependsOnRendererListList;
		          if ( !dependsOnRendererListList )
		            sub_1800D8260(producers, v3);
		          if ( (unsigned int)j >= dependsOnRendererListList->fields._size )
		            sub_1800D2AB0(producers, v3);
		          v14 = *((_QWORD *)&dependsOnRendererListList->fields._syncRoot + j);
		          if ( !v14 )
		            sub_1800D8260(producers, v3);
		          v61 = *(List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)sub_1808AD2E0(&v67, v14);
		          ex = 0LL;
		          v66 = &v61;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                      &v61,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		            {
		              current = v61._current;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		              v16 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		              if ( !v12 )
		                sub_1800D8250(v18, v17);
		              resource = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                                                                 v12,
		                                                                 v16,
		                                                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		              HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
		                v2,
		                &lastGraphicsPipeSync,
		                &lastComputePipeSync,
		                i,
		                resource,
		                0LL);
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v68 )
		          {
		            v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v55;
		            ex = v68->ex;
		            producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)ex;
		            if ( ex )
		              sub_18007E1E0(ex);
		            v2 = this;
		            i = (int)v72;
		            Item = v63;
		            j = (int)index;
		            v12 = v60;
		          }
		          if ( !Item->pass )
		            goto LABEL_110;
		          klass = Item->pass[1].klass;
		          if ( !klass )
		            goto LABEL_110;
		          v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)j;
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v59;
		          if ( v59 >= LODWORD(klass->_0.namespaze) )
		            goto LABEL_109;
		          v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&klass->_0.byval_arg.data.dummy + j);
		          if ( !v3 )
		            goto LABEL_110;
		          System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		            (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v67,
		            v3,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		          v61 = v67;
		          info.producers = 0LL;
		          info.consumers = (List_1_System_Int32_ *)&v61;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                      &v61,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		            {
		              v21 = v61._current;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		              v22 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v21, 0LL);
		              if ( !v12 )
		                sub_1800D8250(v24, v23);
		              v25 = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                                                            v12,
		                                                            v22,
		                                                            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		              HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
		                v2,
		                &lastGraphicsPipeSync,
		                &lastComputePipeSync,
		                i,
		                v25,
		                0LL);
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v69 )
		          {
		            v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v55;
		            info.producers = (List_1_System_Int32_ *)v69->ex;
		            producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)info.producers;
		            if ( info.producers )
		              sub_18007E1E0(info.producers);
		            v2 = this;
		            i = (int)v72;
		            Item = v63;
		            j = (int)index;
		          }
		        }
		      }
		    }
		    v26 = 0;
		    while ( 1 )
		    {
		      v27 = v2->fields.m_CompiledResourcesInfos;
		      if ( !v27 )
		        goto LABEL_110;
		      producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v26;
		      if ( (unsigned int)v26 >= v27->max_length.size )
		LABEL_109:
		        sub_1800D2AA0(producers, v3, v5);
		      v28 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v27->vector[v26];
		      v60 = v28;
		      v29 = v26;
		      v30 = 0;
		      if ( !v28 )
		LABEL_110:
		        sub_1800D8250(producers, v3);
		      while ( (signed int)v30 < v28->fields._size_k__BackingField )
		      {
		        info = *(HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                                                        v28,
		                                                        v30,
		                                                        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		        v31 = HG::Rendering::RenderGraphModule::HGRenderGraph::GetFirstValidWriteIndex(v2, &info, 0LL);
		        LODWORD(index) = v31;
		        if ( v31 != -1 )
		        {
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos;
		          if ( !producers )
		            goto LABEL_110;
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(producers, v31, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->resourceCreateList;
		          if ( !producers )
		            goto LABEL_110;
		          if ( (unsigned int)v26 >= producers->fields._size_k__BackingField )
		            goto LABEL_109;
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v29);
		          if ( !producers )
		            goto LABEL_110;
		          sub_183081250(producers, v30, MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		        LatestValidReadIndex = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidReadIndex(v2, &info, 0LL);
		        v33 = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidWriteIndex(v2, &info, 0LL);
		        if ( (_DWORD)index == -1 )
		        {
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)HIDWORD(*(_QWORD *)&info.refCount);
		          if ( !info.imported )
		            goto LABEL_72;
		        }
		        sub_1800036A0(TypeInfo::System::Math);
		        if ( v33 >= LatestValidReadIndex )
		          LatestValidReadIndex = v33;
		        if ( LatestValidReadIndex == -1 )
		          goto LABEL_72;
		        producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos;
		        if ( !producers )
		          goto LABEL_110;
		        v34 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                producers,
		                LatestValidReadIndex,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		        v35 = v8->fields.m_CompiledPassInfos;
		        if ( v34->enableAsyncCompute )
		        {
		          if ( !v35 )
		            goto LABEL_110;
		          syncFromPassIndex = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos,
		                                LatestValidReadIndex,
		                                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->syncFromPassIndex;
		          LODWORD(index) = LatestValidReadIndex;
		          if ( syncFromPassIndex == -1 )
		          {
		            LODWORD(index) = LatestValidReadIndex;
		            do
		            {
		              v37 = v8->fields.m_CompiledPassInfos;
		              if ( !v37 )
		                goto LABEL_110;
		              if ( LatestValidReadIndex >= v37->fields._size_k__BackingField )
		                break;
		              if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                     (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos,
		                     ++LatestValidReadIndex,
		                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->enableAsyncCompute )
		              {
		                producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos;
		                if ( !producers )
		                  goto LABEL_110;
		                syncFromPassIndex = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                      producers,
		                                      LatestValidReadIndex,
		                                      MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->syncFromPassIndex;
		              }
		            }
		            while ( syncFromPassIndex == -1 );
		          }
		          v72 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos;
		          sub_1800036A0(TypeInfo::System::Math);
		          v3 = 0LL;
		          if ( syncFromPassIndex - 1 > 0 )
		            v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)(unsigned int)(syncFromPassIndex - 1);
		          if ( !v72 )
		            goto LABEL_110;
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(v72, (int32_t)v3, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->resourceReleaseList;
		          if ( !producers )
		            goto LABEL_110;
		          if ( (unsigned int)v26 >= producers->fields._size_k__BackingField )
		            goto LABEL_109;
		          producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v26);
		          if ( !producers )
		            goto LABEL_110;
		          sub_183081250(producers, v30, MethodInfo::System::Collections::Generic::List<int>::Add);
		          v38 = v8->fields.m_CompiledPassInfos;
		          if ( !v38 )
		            goto LABEL_110;
		          if ( LatestValidReadIndex == v38->fields._size_k__BackingField )
		          {
		            m_RenderPasses = (List_1_System_Object_ *)v2->fields.m_RenderPasses;
		            if ( m_RenderPasses )
		            {
		              v40 = (MethodInfo *)sub_180035ED0(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
		              v41 = System::Collections::Generic::List<System::Object>::get_Item(m_RenderPasses, (int32_t)index, v40);
		              if ( v41 )
		              {
		                v42 = (String *)v41[1].klass;
		                v43 = (String *)sub_180035ED0(&off_18E2E0400);
		                v44 = (String *)sub_180035ED0(&off_18E2E03F8);
		                v45 = System::String::Concat(v44, v42, v43, 0LL);
		                v46 = sub_180035ED0(&TypeInfo::System::InvalidOperationException);
		                if ( (*(_BYTE *)(v46 + 312) & 2) == 0 )
		                {
		                  index = &qword_18F360A90;
		                  sub_1802DEE10(&qword_18F360A90);
		                  sub_18004C730(v46, &index);
		                  sub_1802DEE70(index);
		                }
		                if ( *(_QWORD *)(v46 + 96) && (*(_BYTE *)(v46 + 312) & 8) != 0 )
		                  v46 = *(_QWORD *)(v46 + 64);
		                if ( (*(_BYTE *)(v46 + 312) & 0x20) != 0 )
		                {
		                  v48 = *(unsigned int *)(v46 + 248);
		                  if ( *(_QWORD *)(v46 + 8) )
		                  {
		                    v47 = (__int64 *)sub_18002CF00(v48, v46);
		                  }
		                  else
		                  {
		                    v49 = 1LL;
		                    if ( dword_18F35FD0C == 1 )
		                      v49 = 4LL;
		                    v47 = (__int64 *)sub_180017620(v48, v49);
		                    *v47 = v46;
		                  }
		                  _InterlockedIncrement64(&qword_18F360F20);
		                }
		                else
		                {
		                  v47 = (__int64 *)sub_18002D340(v46);
		                }
		                v50 = (ProtocolViolationException *)v47;
		                if ( (*(_BYTE *)(v46 + 313) & 2) != 0 )
		                {
		                  v56 = mono_thread_suspend_all_other_threads;
		                  sub_18002E5E0((_DWORD)v47, (unsigned int)sub_18000A6C0, 0, (unsigned int)&v72, (__int64)&index);
		                }
		                if ( (dword_18F371F28 & 0x80u) != 0 )
		                  sub_1802ED490(v50, v46);
		                il2cpp_runtime_class_init_1(v46);
		                if ( v50 )
		                {
		                  System::Net::ProtocolViolationException::ProtocolViolationException(v50, v45, 0LL);
		                  v54 = sub_180035ED0(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization);
		                  sub_18007E190(v50, v54);
		                }
		              }
		            }
		            goto LABEL_110;
		          }
		LABEL_72:
		          v29 = v26;
		          goto LABEL_73;
		        }
		        if ( !v35 )
		          goto LABEL_110;
		        producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item((DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v8->fields.m_CompiledPassInfos, LatestValidReadIndex, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->resourceReleaseList;
		        if ( !producers )
		          goto LABEL_110;
		        if ( (unsigned int)v26 >= producers->fields._size_k__BackingField )
		          goto LABEL_109;
		        v29 = v26;
		        producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v26);
		        if ( !producers )
		          goto LABEL_110;
		        sub_183081250(producers, v30, MethodInfo::System::Collections::Generic::List<int>::Add);
		LABEL_73:
		        ++v30;
		        v28 = v60;
		      }
		      if ( ++v26 >= 2 )
		        return;
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(65, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v53, v52);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		}
		
		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) => default; // 0x0000000189B29068-0x0000000189B29218
		// Boolean AreRendererListsEmpty(List`1[HG.Rendering.RenderGraphModule.RendererListHandle])
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
		        HGRenderGraph *this,
		        List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *rendererLists,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  RendererList *RendererList; // rax
		  __int64 v10; // rdx
		  HGRenderGraphContext *m_RenderGraphContext; // rcx
		  ScriptableRenderContext *p_renderContext; // rsi
		  RendererList v13; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  RendererList v18; // [rsp+40h] [rbp-58h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v19; // [rsp+50h] [rbp-48h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v20; // [rsp+68h] [rbp-30h] BYREF
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // [rsp+B8h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(62, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(62, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)rendererLists,
		             0LL);
		  }
		  else
		  {
		    if ( !rendererLists )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v19,
		      (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)rendererLists,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
		    v20 = v19;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		              &v20,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
		    {
		      current = v20._current;
		      m_Resources = this->fields.m_Resources;
		      if ( !m_Resources )
		        sub_1800D8250(v7, 0LL);
		      RendererList = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(
		                       (RendererList *)&v19,
		                       m_Resources,
		                       (RendererListHandle *)&current,
		                       0LL);
		      m_RenderGraphContext = this->fields.m_RenderGraphContext;
		      if ( !m_RenderGraphContext )
		        sub_1800D8250(0LL, v10);
		      p_renderContext = &m_RenderGraphContext->fields.renderContext;
		      v13 = *RendererList;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v18 = v13;
		      if ( UnityEngine::Rendering::ScriptableRenderContext::QueryRendererListStatus(p_renderContext, &v18, 0LL) == RendererListStatus__Enum_kRendererListPopulated )
		        return 0;
		    }
		    return rendererLists->fields._size > 0;
		  }
		}
		
		private void TryCullPassAtIndex(int passIndex) {} // 0x0000000189B2F0B4-0x0000000189B2F1E4
		// Void TryCullPassAtIndex(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::TryCullPassAtIndex(
		        HGRenderGraph *this,
		        int32_t passIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rcx
		  RenderGraph_CompiledPassInfo *Item; // rax
		  RenderGraphPass *pass; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(60, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(60, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, passIndex, 0LL);
		  }
		  else
		  {
		    m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		    if ( !m_CompiledPassInfos )
		      goto LABEL_15;
		    Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		             passIndex,
		             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		    m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		    pass = Item->pass;
		    if ( !m_CompiledPassInfos )
		      goto LABEL_15;
		    if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		           (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		           passIndex,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		      return;
		    if ( !pass )
		      goto LABEL_15;
		    if ( BYTE1(pass->fields._depthBuffer_k__BackingField.handle.m_Value) && BYTE5(pass->fields.usedRendererListList) )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      if ( !m_CompiledPassInfos )
		        goto LABEL_15;
		      if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		              passIndex,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->hasSideEffect
		        && (HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
		              this,
		              (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)pass[1].fields._name_k__BackingField,
		              0LL)
		         || HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
		              this,
		              *(List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ **)&pass[1].fields._index_k__BackingField,
		              0LL)) )
		      {
		        m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		        if ( m_CompiledPassInfos )
		        {
		          UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
		            passIndex,
		            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled = 1;
		          return;
		        }
		LABEL_15:
		        sub_1800D8260(m_CompiledPassInfos, v5);
		      }
		    }
		  }
		}
		
		private void CullRendererLists() {} // 0x0000000189B2AE80-0x0000000189B2AF7C
		// Void CullRendererLists()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CullRendererLists(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *pass; // rcx
		  int32_t i; // ebx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  RenderGraph_CompiledPassInfo__Array *m_Array; // rax
		  __int64 v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(59, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		      if ( !m_CompiledPassInfos )
		        break;
		      if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		        return;
		      if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos,
		              i,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		      {
		        pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos;
		        if ( !pass )
		          break;
		        if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                pass,
		                i,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->hasSideEffect )
		        {
		          pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos;
		          if ( !pass )
		            break;
		          pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(pass, i, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->pass;
		          if ( !pass )
		            break;
		          m_Array = pass[4].fields.m_Array;
		          if ( !m_Array )
		            break;
		          if ( m_Array->max_length.size > 0 )
		            goto LABEL_14;
		          v8 = *(_QWORD *)&pass[4].fields._size_k__BackingField;
		          if ( !v8 )
		            break;
		          if ( *(int *)(v8 + 24) > 0 )
		LABEL_14:
		            HG::Rendering::RenderGraphModule::HGRenderGraph::TryCullPassAtIndex(this, i, 0LL);
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(pass, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(59, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void CompileRenderGraph() {} // 0x0000000189B2A30C-0x0000000189B2A428
		// Void CompileRenderGraph()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CompileRenderGraph(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Il2CppExceptionWrapper *v8; // [rsp+20h] [rbp-28h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-20h]
		  char *v10; // [rsp+30h] [rbp-18h]
		  char v11; // [rsp+60h] [rbp+18h] BYREF
		
		  v11 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(30, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(30, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_RenderGraphContext )
		      sub_1800D8260(v4, v3);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
		    ex = 0LL;
		    v10 = &v11;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::InitializeCompilationData(this, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::CountReferences(this, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::CullUnusedPasses(this, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererLists(this, 0LL);
		      if ( this->fields.m_RendererListCulling )
		        HG::Rendering::RenderGraphModule::HGRenderGraph::CullRendererLists(this, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization(this, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::LogRendererListsCreation(this, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v8 )
		    {
		      ex = v8->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private ref CompiledPassInfo CompilePassImmediatly(HGRenderGraphPass pass) => ref _refReturnTypeForCompilePassImmediatly; // 0x0000000189B29B90-0x0000000189B2A30C
		// HGRenderGraph+CompiledPassInfo& CompilePassImmediatly(HGRenderGraphPass)
		// Hidden C++ exception states: #wind=4
		HGRenderGraph_CompiledPassInfo *HG::Rendering::RenderGraphModule::HGRenderGraph::CompilePassImmediatly(
		        HGRenderGraph *this,
		        HGRenderGraphPass *pass,
		        MethodInfo *method)
		{
		  Object *v3; // r14
		  HGRenderGraph *v4; // rdi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rbx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *v8; // rbx
		  int32_t m_CurrentImmediatePassIndex; // esi
		  HGRenderGraph_CompiledPassInfo *Item; // r15
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v11; // rdx
		  HGRenderGraphResourceRegistry *v12; // rcx
		  int i; // esi
		  unsigned int v14; // r13d
		  unsigned int v15; // r12d
		  Object__Class *klass; // rbx
		  __int64 v17; // rax
		  __int64 v18; // r8
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // r8
		  List_1_System_Int32___Array *resourceCreateList; // rax
		  List_1_System_Int32_ *v24; // rbx
		  unsigned int v25; // eax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // r8
		  List_1_System_Int32___Array *m_ImmediateModeResourceList; // rax
		  List_1_System_Int32_ *v32; // rbx
		  unsigned int v33; // eax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  MonitorData *monitor; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // rbx
		  List_1_System_Int32___Array *v40; // rax
		  List_1_System_Int32_ *v41; // r12
		  unsigned int v42; // eax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // r8
		  List_1_System_Int32___Array *resourceReleaseList; // rax
		  List_1_System_Int32_ *v49; // r12
		  unsigned int v50; // eax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  HGRenderGraphResourceRegistry *v53; // rcx
		  __int64 v54; // rdx
		  List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *m_RendererLists; // rcx
		  ScriptableRenderContext *m_RenderGraphContext; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  _BYTE v61[32]; // [rsp+0h] [rbp-128h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v62; // [rsp+30h] [rbp-F8h] BYREF
		  HGRenderGraph_CompiledPassInfo *v63; // [rsp+48h] [rbp-E0h]
		  int v64; // [rsp+50h] [rbp-D8h]
		  unsigned int v65; // [rsp+58h] [rbp-D0h]
		  unsigned int v66; // [rsp+5Ch] [rbp-CCh]
		  ResourceHandle res; // [rsp+60h] [rbp-C8h] BYREF
		  Il2CppException *v68; // [rsp+68h] [rbp-C0h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v69; // [rsp+70h] [rbp-B8h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v70; // [rsp+78h] [rbp-B0h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v71; // [rsp+98h] [rbp-90h] BYREF
		  Il2CppException *ex; // [rsp+B0h] [rbp-78h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v73; // [rsp+B8h] [rbp-70h]
		  Il2CppException *v74; // [rsp+C0h] [rbp-68h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v75; // [rsp+C8h] [rbp-60h]
		  Il2CppExceptionWrapper *v76; // [rsp+D0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v77; // [rsp+D8h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v78; // [rsp+E0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v79; // [rsp+E8h] [rbp-40h] BYREF
		  RendererListHandle v82; // [rsp+148h] [rbp+20h] BYREF
		
		  v3 = (Object *)pass;
		  v4 = this;
		  memset(&v62, 0, sizeof(v62));
		  memset(&v71, 0, sizeof(v71));
		  if ( IFix::WrappersManagerImpl::IsPatched(211, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(211, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v60, v59);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_97(Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    m_CompiledPassInfos = v4->fields.m_CompiledPassInfos;
		    if ( !m_CompiledPassInfos )
		      sub_1800D8260(v6, v5);
		    if ( v4->fields.m_CurrentImmediatePassIndex >= m_CompiledPassInfos->fields._size_k__BackingField )
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v4->fields.m_CompiledPassInfos,
		        2 * m_CompiledPassInfos->fields._size_k__BackingField,
		        0,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
		    v8 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v4->fields.m_CompiledPassInfos;
		    m_CurrentImmediatePassIndex = v4->fields.m_CurrentImmediatePassIndex;
		    v4->fields.m_CurrentImmediatePassIndex = m_CurrentImmediatePassIndex + 1;
		    if ( !v8 )
		      sub_1800D8260(v6, v5);
		    Item = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                               v8,
		                                               m_CurrentImmediatePassIndex,
		                                               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		    v63 = Item;
		    HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::Reset(Item, (HGRenderGraphPass *)v3, 0LL);
		    Item->enableAsyncCompute = 0;
		    for ( i = 0; ; ++i )
		    {
		      *(_DWORD *)&v82.m_IsValid = i;
		      v66 = i;
		      v14 = i;
		      v64 = i;
		      v65 = i;
		      v15 = i;
		      if ( i >= 2 )
		        break;
		      if ( !v3 )
		        sub_1800D8260(v12, v11);
		      klass = v3[8].klass;
		      if ( !klass )
		        sub_1800D8260(v12, v11);
		      if ( (unsigned int)i >= LODWORD(klass->_0.namespaze) )
		        sub_1800D2AB0(v12, v11);
		      v17 = *((_QWORD *)&klass->_0.byval_arg.data.dummy + i);
		      if ( !v17 )
		        sub_1800D8260(v12, v11);
		      v62 = *(List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)sub_1808AD2E0(&v70, v17);
		      ex = 0LL;
		      v73 = &v62;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                  &v62,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		        {
		          res = (ResourceHandle)v62._current;
		          m_Resources = v4->fields.m_Resources;
		          if ( !m_Resources )
		            sub_1800D8250(0LL, v11);
		          if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsGraphicsResourceCreated(
		                  m_Resources,
		                  &res,
		                  0LL) )
		          {
		            resourceCreateList = Item->resourceCreateList;
		            if ( !resourceCreateList )
		              sub_1800D8250(v21, v20);
		            if ( (unsigned int)i >= resourceCreateList->max_length.size )
		              sub_1800D2AA0(v21, v20, v22);
		            v24 = resourceCreateList->vector[i];
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		            v25 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(res, 0LL);
		            if ( !v24 )
		              sub_1800D8250(v27, v26);
		            sub_183081250(v24, v25, MethodInfo::System::Collections::Generic::List<int>::Add);
		            m_ImmediateModeResourceList = v4->fields.m_ImmediateModeResourceList;
		            if ( !m_ImmediateModeResourceList )
		              sub_1800D8250(v29, v28);
		            if ( (unsigned int)i >= m_ImmediateModeResourceList->max_length.size )
		              sub_1800D2AA0(v29, v28, v30);
		            v32 = m_ImmediateModeResourceList->vector[i];
		            v33 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(res, 0LL);
		            if ( !v32 )
		              sub_1800D8250(v35, v34);
		            sub_183081250(v32, v33, MethodInfo::System::Collections::Generic::List<int>::Add);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v76 )
		      {
		        v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v61;
		        ex = v76->ex;
		        v12 = (HGRenderGraphResourceRegistry *)ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v3 = (Object *)pass;
		        v4 = this;
		        Item = v63;
		        i = *(_DWORD *)&v82.m_IsValid;
		        v14 = v64;
		        v15 = v64;
		      }
		      if ( !v3 )
		        goto LABEL_91;
		      monitor = v3[8].monitor;
		      if ( !monitor )
		        goto LABEL_91;
		      v37 = i;
		      if ( v15 >= *((_DWORD *)monitor + 6) )
		        goto LABEL_87;
		      v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)monitor + i + 4);
		      if ( !v11 )
		        goto LABEL_91;
		      System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		        (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v70,
		        v11,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		      v62 = v70;
		      v74 = 0LL;
		      v75 = &v62;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                  &v62,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		        {
		          current = v62._current;
		          v40 = Item->resourceCreateList;
		          if ( !v40 )
		            sub_1800D8250(v38, v11);
		          if ( v65 >= v40->max_length.size )
		            sub_1800D2AA0(v65, v11, v18);
		          v41 = v40->vector[i];
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		          v42 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		          if ( !v41 )
		            sub_1800D8250(v44, v43);
		          sub_183081250(v41, v42, MethodInfo::System::Collections::Generic::List<int>::Add);
		          resourceReleaseList = Item->resourceReleaseList;
		          if ( !resourceReleaseList )
		            sub_1800D8250(v46, v45);
		          if ( v14 >= resourceReleaseList->max_length.size )
		            sub_1800D2AA0(v46, v45, v47);
		          v49 = resourceReleaseList->vector[i];
		          v50 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		          if ( !v49 )
		            sub_1800D8250(v52, v51);
		          sub_183081250(v49, v50, MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v77 )
		      {
		        v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v61;
		        v74 = v77->ex;
		        if ( v74 )
		          sub_18007E1E0(v74);
		        v3 = (Object *)pass;
		        v4 = this;
		        Item = v63;
		        i = *(_DWORD *)&v82.m_IsValid;
		      }
		      v12 = (HGRenderGraphResourceRegistry *)v3[7].monitor;
		      if ( !v12 )
		        goto LABEL_91;
		      v37 = i;
		      if ( v66 >= LODWORD(v12->fields.m_RendererListResources) )
		LABEL_87:
		        sub_1800D2AA0(v12, v37, v18);
		      v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&v12->fields.m_RenderGraphDebug + i);
		      if ( !v11 )
		        goto LABEL_91;
		      System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		        (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v70,
		        v11,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		      v62 = v70;
		      v68 = 0LL;
		      v69 = &v62;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                  &v62,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		          ;
		      }
		      catch ( Il2CppExceptionWrapper *v78 )
		      {
		        v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v61;
		        v68 = v78->ex;
		        v12 = (HGRenderGraphResourceRegistry *)v68;
		        if ( v68 )
		          sub_18007E1E0(v68);
		        v3 = (Object *)pass;
		        v4 = this;
		        Item = v63;
		        i = *(_DWORD *)&v82.m_IsValid;
		      }
		    }
		    if ( !v3 )
		      goto LABEL_91;
		    v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v3[9].klass;
		    if ( !v11 )
		      goto LABEL_91;
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v70,
		      v11,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
		    v71 = v70;
		    v68 = 0LL;
		    v69 = &v71;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                &v71,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
		      {
		        v82 = (RendererListHandle)v71._current;
		        v53 = v4->fields.m_Resources;
		        if ( !v53 )
		          sub_1800D8250(0LL, v11);
		        if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRendererListCreated(v53, &v82, 0LL) )
		        {
		          m_RendererLists = (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)v4->fields.m_RendererLists;
		          if ( !m_RendererLists )
		            sub_1800D8250(0LL, v54);
		          System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		            m_RendererLists,
		            (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)v82,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v79 )
		    {
		      v11 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v61;
		      v68 = v79->ex;
		      if ( v68 )
		        sub_18007E1E0(v68);
		      v4 = this;
		      Item = v63;
		    }
		    v12 = v4->fields.m_Resources;
		    m_RenderGraphContext = (ScriptableRenderContext *)v4->fields.m_RenderGraphContext;
		    if ( !m_RenderGraphContext
		      || !v12
		      || (HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
		            v12,
		            v4->fields.m_RendererLists,
		            m_RenderGraphContext[2],
		            0,
		            0LL),
		          (v12 = (HGRenderGraphResourceRegistry *)v4->fields.m_RendererLists) == 0LL) )
		    {
		LABEL_91:
		      sub_1800D8250(v12, v11);
		    }
		    ++HIDWORD(v12->fields.m_RendererListResources);
		    LODWORD(v12->fields.m_RendererListResources) = 0;
		    return Item;
		  }
		}
		
		private ref CompiledPassInfo _refReturnTypeForCompilePassImmediatly; // Dummy field
		private void ExecutePassImmediatly(HGRenderGraphPass pass) {} // 0x0000000189B2B9B8-0x0000000189B2BA30
		// Void ExecutePassImmediatly(HGRenderGraphPass)
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecutePassImmediatly(
		        HGRenderGraph *this,
		        HGRenderGraphPass *pass,
		        MethodInfo *method)
		{
		  HGRenderGraph_CompiledPassInfo *v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(210, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(210, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)pass,
		      0LL);
		  }
		  else
		  {
		    v5 = HG::Rendering::RenderGraphModule::HGRenderGraph::CompilePassImmediatly(this, pass, 0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(
		      this,
		      v5,
		      this->fields.m_CurrentImmediatePassIndex - 1,
		      0LL);
		  }
		}
		
		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex) {} // 0x0000000189B2B62C-0x0000000189B2B9B8
		// Void ExecuteCompiledPass(HGRenderGraph+CompiledPassInfo ByRef, Int32)
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledPassInfo *passInfo,
		        int32_t passIndex,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRenderGraphPass *pass; // rbx
		  Object *name_k__BackingField; // rbx
		  String *v15; // rax
		  String *v16; // rsi
		  __int64 v17; // rax
		  ProtocolViolationException *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ProtocolViolationException *v21; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rax
		  char v26; // [rsp+30h] [rbp-98h] BYREF
		  HGRenderGraphLogIndent v27; // [rsp+38h] [rbp-90h] BYREF
		  Il2CppException *ex; // [rsp+58h] [rbp-70h]
		  char *v29; // [rsp+60h] [rbp-68h]
		  HGRenderGraphLogIndent v30; // [rsp+68h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v31; // [rsp+80h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v32; // [rsp+88h] [rbp-40h] BYREF
		
		  v26 = 0;
		  memset(&v30, 0, sizeof(v30));
		  if ( IFix::WrappersManagerImpl::IsPatched(76, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(76, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v24, v23);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_45(Patch, (Object *)this, passInfo, passIndex, 0LL);
		  }
		  else if ( !passInfo->culled )
		  {
		    if ( !passInfo->pass )
		      sub_1800D8260(v8, v7);
		    if ( !(unsigned __int8)sub_180006280(6LL, passInfo->pass) )
		    {
		      pass = passInfo->pass;
		      if ( pass )
		      {
		        name_k__BackingField = (Object *)pass->fields._name_k__BackingField;
		        v15 = (String *)sub_18007E180(&off_18E2E0380);
		        v16 = System::String::Format(v15, name_k__BackingField, 0LL);
		        v17 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		        v18 = (ProtocolViolationException *)sub_1800368D0(v17);
		        v21 = v18;
		        if ( !v18 )
		          sub_1800D8260(v20, v19);
		        System::Net::ProtocolViolationException::ProtocolViolationException(v18, v16, 0LL);
		        v25 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass);
		        sub_18007E190(v21, v25);
		      }
		      sub_1800D8260(v10, v9);
		    }
		    if ( !this->fields.m_RenderGraphContext )
		      sub_1800D8260(v10, v9);
		    if ( !passInfo->pass )
		      sub_1800D8260(v10, v9);
		    try
		    {
		      ex = 0LL;
		      v29 = &v26;
		      HG::Rendering::RenderGraphModule::HGRenderGraph::LogRenderPassBegin(this, passInfo, 0LL);
		      memset(&v27, 0, sizeof(v27));
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
		        &v27,
		        this->fields.m_FrameInformationLogger,
		        1,
		        0LL);
		      v30 = v27;
		      *(_QWORD *)&v27.m_Indentation = 0LL;
		      v27.m_Logger = (HGRenderGraphLogger *)&v30;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraph::PreRenderPassExecute(
		          this,
		          passInfo,
		          this->fields.m_RenderGraphContext,
		          0LL);
		        if ( !passInfo->pass )
		          sub_1800D8250(v12, v11);
		        HG::Rendering::RenderGraphModule::HGRenderGraphPass::Execute(passInfo->pass, this, 0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::PostRenderPassExecute(
		          this,
		          passInfo,
		          this->fields.m_RenderGraphContext,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v31 )
		      {
		        *(Il2CppExceptionWrapper *)&v27.m_Indentation = (Il2CppExceptionWrapper)v31->ex;
		      }
		      sub_180267B30(&v27);
		    }
		    catch ( Il2CppExceptionWrapper *v32 )
		    {
		      ex = v32->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void ExecuteRenderGraph() {} // 0x0000000189B2BA30-0x0000000189B2BB54
		// Void ExecuteRenderGraph()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteRenderGraph(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  HGRenderGraph_CompiledPassInfo *Item; // rax
		  int32_t i; // edi
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-28h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-20h]
		  char *v16; // [rsp+30h] [rbp-18h]
		  char v17; // [rsp+60h] [rbp+18h] BYREF
		
		  v17 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(75, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(75, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_RenderGraphContext )
		      sub_1800D8260(v4, v3);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)1u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
		    ex = 0LL;
		    v16 = &v17;
		    try
		    {
		      for ( i = 0; ; ++i )
		      {
		        m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		        if ( !m_CompiledPassInfos )
		          sub_1800D8250(v6, v5);
		        if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		          break;
		        Item = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                                                   (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos,
		                                                   i,
		                                                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(this, Item, i, 0LL);
		      }
		      m_Resources = this->fields.m_Resources;
		      if ( !m_Resources )
		        sub_1800D8250(0LL, v5);
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseUnusedPreservedResources(m_Resources, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      ex = v14->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void PreRenderPassExecute([IsReadOnly] in CompiledPassInfo passInfo, HGRenderGraphContext rgContext) {} // 0x0000000189B2E740-0x0000000189B2EA6C
		// Void PreRenderPassExecute(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraphContext)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::PreRenderPassExecute(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledPassInfo *passInfo,
		        HGRenderGraphContext *rgContext,
		        MethodInfo *method)
		{
		  HGRenderGraphContext *v4; // rsi
		  HGRenderGraph_CompiledPassInfo *v5; // r14
		  Type *v7; // rdx
		  __int64 v8; // rcx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  HGRenderGraphPass *pass; // r15
		  unsigned __int64 v12; // rdx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *m_Ptr; // rcx
		  int32_t i; // ebx
		  List_1_System_Int32___Array *resourceCreateList; // r12
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  CommandBuffer *cmd; // rbx
		  String *name_k__BackingField; // rbx
		  CommandBuffer *v19; // rax
		  CommandBuffer *v20; // rbx
		  unsigned __int64 v21; // r8
		  signed __int64 v22; // rtt
		  CommandBuffer *v23; // rbx
		  RenderGraph_CompiledPassInfo *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // [rsp+0h] [rbp-C8h] BYREF
		  String *name; // [rsp+20h] [rbp-A8h]
		  int32_t v30; // [rsp+30h] [rbp-98h]
		  HGRenderGraphPass *v31; // [rsp+40h] [rbp-88h]
		  GraphicsFence fence; // [rsp+50h] [rbp-78h] BYREF
		  List_1_T_Enumerator_System_Int32_ v33; // [rsp+60h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v34; // [rsp+78h] [rbp-50h] BYREF
		  List_1_T_Enumerator_System_Int32_ v35; // [rsp+80h] [rbp-48h] BYREF
		
		  v4 = rgContext;
		  v5 = passInfo;
		  memset(&v33, 0, sizeof(v33));
		  if ( !IFix::WrappersManagerImpl::IsPatched(79, 0LL) )
		  {
		    pass = v5->pass;
		    v31 = v5->pass;
		    if ( !v4 )
		      sub_1800D8260(v8, v7);
		    this->fields.m_PreviousCommandBuffer = v4->fields.cmd;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_PreviousCommandBuffer, v7, v9, v10, (MethodInfo *)name);
		    for ( i = 0; ; ++i )
		    {
		      v30 = i;
		      if ( i >= 2 )
		        break;
		      resourceCreateList = v5->resourceCreateList;
		      if ( !resourceCreateList )
		        sub_1800D8260(m_Ptr, v12);
		      if ( (unsigned int)i >= resourceCreateList->max_length.size )
		        sub_1800D2AB0(m_Ptr, v12);
		      if ( !resourceCreateList->vector[i] )
		        sub_1800D8260(m_Ptr, v12);
		      System::Collections::Generic::List<int>::GetEnumerator(
		        &v35,
		        resourceCreateList->vector[i],
		        MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		      v33 = v35;
		      fence.m_Ptr = 0LL;
		      *(_QWORD *)&fence.m_Version = &v33;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                  &v33,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		        {
		          m_Resources = this->fields.m_Resources;
		          if ( !pass )
		            sub_1800D8250(m_Resources, v12);
		          if ( !m_Resources )
		            sub_1800D8250(0LL, v12);
		          HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreatePooledResource(
		            m_Resources,
		            v4,
		            i,
		            v33._current,
		            pass->fields._name_k__BackingField,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v34 )
		      {
		        v12 = (unsigned __int64)&v28;
		        fence.m_Ptr = v34->ex;
		        m_Ptr = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)fence.m_Ptr;
		        if ( fence.m_Ptr )
		          sub_18007E1E0(fence.m_Ptr);
		        v4 = rgContext;
		        v5 = passInfo;
		        pass = v31;
		        i = v30;
		      }
		    }
		    if ( v4 )
		    {
		      cmd = v4->fields.cmd;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferNoCopy(&v4->fields.renderContext, cmd, 0LL);
		      if ( v5->enableAsyncCompute )
		      {
		        if ( !pass )
		          goto LABEL_37;
		        name_k__BackingField = pass->fields._name_k__BackingField;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		        v19 = UnityEngine::Rendering::CommandBufferPool::Get(name_k__BackingField, 0LL);
		        v20 = v19;
		        if ( !v19 )
		          goto LABEL_37;
		        UnityEngine::Rendering::CommandBuffer::SetExecutionFlags(
		          v19,
		          CommandBufferExecutionFlags__Enum_AsyncCompute,
		          0LL);
		        v4->fields.cmd = v20;
		        if ( dword_18F35FD08 )
		        {
		          v21 = (((unsigned __int64)&v4->fields.cmd >> 12) & 0x1FFFFF) >> 6;
		          v12 = ((unsigned __int64)&v4->fields.cmd >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F103690[v21]);
		          do
		            v22 = qword_18F103690[v21];
		          while ( v22 != _InterlockedCompareExchange64(&qword_18F103690[v21], v22 | (1LL << v12), v22) );
		        }
		      }
		      if ( v5->syncToPassIndex == -1 )
		        return;
		      v23 = v4->fields.cmd;
		      m_Ptr = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos;
		      if ( m_Ptr )
		      {
		        Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                 m_Ptr,
		                 v5->syncToPassIndex,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		        if ( v23 )
		        {
		          fence = Item->fence;
		          UnityEngine::Rendering::CommandBuffer::WaitOnAsyncGraphicsFence(
		            v23,
		            &fence,
		            SynchronisationStage__Enum_VertexProcessing,
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_37:
		    sub_1800D8250(m_Ptr, v12);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(79, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v27, v26);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_41(Patch, (Object *)this, v5, (Object *)v4, 0LL);
		}
		
		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, HGRenderGraphContext rgContext) {} // 0x0000000189B2E4B4-0x0000000189B2E740
		// Void PostRenderPassExecute(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraphContext)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::PostRenderPassExecute(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledPassInfo *passInfo,
		        HGRenderGraphContext *rgContext,
		        MethodInfo *method)
		{
		  HGRenderGraphContext *v4; // rsi
		  HGRenderGraph_CompiledPassInfo *v5; // r15
		  HGRenderGraph *v6; // r13
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  CommandBuffer *cmd; // rbx
		  CommandBuffer *v10; // rbx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo **v14; // rdx
		  void *m_Ptr; // rcx
		  int32_t i; // ebx
		  List_1_System_Int32___Array *resourceReleaseList; // r12
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  MethodInfo *v22[6]; // [rsp+0h] [rbp-B8h] BYREF
		  int32_t v23; // [rsp+30h] [rbp-88h]
		  Il2CppExceptionWrapper *v24; // [rsp+40h] [rbp-78h] BYREF
		  GraphicsFence v25; // [rsp+48h] [rbp-70h] BYREF
		  List_1_T_Enumerator_System_Int32_ v26; // [rsp+58h] [rbp-60h] BYREF
		  List_1_T_Enumerator_System_Int32_ v27; // [rsp+70h] [rbp-48h] BYREF
		
		  v4 = rgContext;
		  v5 = passInfo;
		  v6 = this;
		  memset(&v26, 0, sizeof(v26));
		  if ( IFix::WrappersManagerImpl::IsPatched(84, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(84, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_44(Patch, (Object *)v6, v5, (Object *)v4, 0LL);
		  }
		  else
		  {
		    if ( v5->needGraphicsFence )
		    {
		      if ( !v4 )
		        sub_1800D8260(v8, v7);
		      if ( !v4->fields.cmd )
		        sub_1800D8260(v8, v7);
		      v5->fence = *UnityEngine::Rendering::CommandBuffer::CreateAsyncGraphicsFence(&v25, v4->fields.cmd, 0LL);
		    }
		    if ( v5->enableAsyncCompute )
		    {
		      if ( !v4 )
		        sub_1800D8260(v8, v7);
		      cmd = v4->fields.cmd;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferAsyncNoCopy(
		        &v4->fields.renderContext,
		        cmd,
		        ComputeQueueType__Enum_Background,
		        0LL);
		      v10 = v4->fields.cmd;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		      UnityEngine::Rendering::CommandBufferPool::Release(v10, 0LL);
		      v4->fields.cmd = v6->fields.m_PreviousCommandBuffer;
		      sub_18002D1B0((SingleFieldAccessor *)&v4->fields.cmd, v11, v12, v13, v22[4]);
		    }
		    if ( !v6->fields.m_RenderGraphPool )
		      sub_1800D8260(v8, v7);
		    HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::ReleaseAllTempAlloc(v6->fields.m_RenderGraphPool, 0LL);
		    for ( i = 0; ; ++i )
		    {
		      v23 = i;
		      if ( i >= 2 )
		        break;
		      resourceReleaseList = v5->resourceReleaseList;
		      if ( !resourceReleaseList )
		        sub_1800D8260(m_Ptr, v14);
		      if ( (unsigned int)i >= resourceReleaseList->max_length.size )
		        sub_1800D2AB0(m_Ptr, v14);
		      if ( !resourceReleaseList->vector[i] )
		        sub_1800D8260(m_Ptr, v14);
		      System::Collections::Generic::List<int>::GetEnumerator(
		        &v27,
		        resourceReleaseList->vector[i],
		        MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		      v26 = v27;
		      v25.m_Ptr = 0LL;
		      *(_QWORD *)&v25.m_Version = &v26;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                  &v26,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		        {
		          m_Resources = v6->fields.m_Resources;
		          if ( !m_Resources )
		            sub_1800D8250(0LL, v14);
		          HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
		            m_Resources,
		            v4,
		            i,
		            v26._current,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v24 )
		      {
		        v14 = v22;
		        v25.m_Ptr = v24->ex;
		        m_Ptr = v25.m_Ptr;
		        if ( v25.m_Ptr )
		          sub_18007E1E0(v25.m_Ptr);
		        v4 = rgContext;
		        v5 = passInfo;
		        v6 = this;
		        i = v23;
		      }
		    }
		  }
		}
		
		private void ClearRenderPasses() {} // 0x0000000189B29A2C-0x0000000189B29B90
		// Void ClearRenderPasses()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearRenderPasses(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraph *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 *v5; // rdx
		  __int64 v6; // rcx
		  Object *current; // rdi
		  HGRenderGraphObjectPool *m_RenderGraphPool; // rsi
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // [rsp+0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v15; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v16; // [rsp+40h] [rbp-28h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(101, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(101, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.m_RenderPasses )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v15,
		      (List_1_System_UInt64_ *)v2->fields.m_RenderPasses,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::GetEnumerator);
		    v16 = v15;
		    v15._list = 0LL;
		    *(_QWORD *)&v15._index = &v16;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v16,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::MoveNext) )
		      {
		        current = v16._current;
		        m_RenderGraphPool = v2->fields.m_RenderGraphPool;
		        if ( !v16._current )
		          sub_1800D8250(v6, v5);
		        sub_1800049A0(v16._current->klass);
		        ((void (__fastcall *)(Object *, HGRenderGraphObjectPool *, void *))current->klass[1]._0.namespaze)(
		          current,
		          m_RenderGraphPool,
		          current->klass[1]._0.byval_arg.data.dummy);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v5 = &v13;
		      v15._list = (List_1_System_Object_ *)v14->ex;
		      if ( v15._list )
		        sub_18007E1E0(v15._list);
		      v2 = this;
		    }
		    m_RenderPasses = v2->fields.m_RenderPasses;
		    if ( !m_RenderPasses )
		      sub_1800D8250(0LL, v5);
		    sub_183127A90(
		      m_RenderPasses,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Clear);
		  }
		}
		
		internal void ClearCallbackOwners() {} // 0x0000000189B298F8-0x0000000189B29954
		// Void ClearCallbackOwners()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_ *m_callbackOwner; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(102, 0LL) )
		  {
		    m_callbackOwner = this->fields.m_callbackOwner;
		    if ( m_callbackOwner )
		    {
		      sub_183127A90(
		        m_callbackOwner,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::Clear);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_callbackOwner, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(102, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void ReleaseImmediateModeResources() {} // 0x0000000189B2EEAC-0x0000000189B2F040
		// Void ReleaseImmediateModeResources()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseImmediateModeResources(
		        HGRenderGraph *this,
		        MethodInfo *method)
		{
		  HGRenderGraph *v2; // rsi
		  __int64 *v3; // rdx
		  Il2CppException *v4; // rcx
		  int32_t i; // ebx
		  List_1_System_Int32___Array *m_ImmediateModeResourceList; // r14
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // [rsp+0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v12; // [rsp+30h] [rbp-68h] BYREF
		  Il2CppException *ex; // [rsp+38h] [rbp-60h]
		  List_1_T_Enumerator_System_Int32_ *v14; // [rsp+40h] [rbp-58h]
		  List_1_T_Enumerator_System_Int32_ v15; // [rsp+48h] [rbp-50h] BYREF
		  List_1_T_Enumerator_System_Int32_ v16; // [rsp+60h] [rbp-38h] BYREF
		
		  v2 = this;
		  memset(&v15, 0, sizeof(v15));
		  if ( IFix::WrappersManagerImpl::IsPatched(99, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(99, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    for ( i = 0; i < 2; ++i )
		    {
		      m_ImmediateModeResourceList = v2->fields.m_ImmediateModeResourceList;
		      if ( !m_ImmediateModeResourceList )
		        sub_1800D8260(v4, v3);
		      if ( (unsigned int)i >= m_ImmediateModeResourceList->max_length.size )
		        sub_1800D2AB0(v4, v3);
		      if ( !m_ImmediateModeResourceList->vector[i] )
		        sub_1800D8260(v4, v3);
		      System::Collections::Generic::List<int>::GetEnumerator(
		        &v16,
		        m_ImmediateModeResourceList->vector[i],
		        MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		      v15 = v16;
		      ex = 0LL;
		      v14 = &v15;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                  &v15,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		        {
		          m_Resources = v2->fields.m_Resources;
		          if ( !m_Resources )
		            sub_1800D8250(0LL, v3);
		          HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
		            m_Resources,
		            v2->fields.m_RenderGraphContext,
		            i,
		            v15._current,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v12 )
		      {
		        v3 = &v11;
		        ex = v12->ex;
		        v4 = ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v2 = this;
		      }
		    }
		  }
		}
		
		private void LogFrameInformation() {} // 0x0000000189B2DEE4-0x0000000189B2E02C
		// Void LogFrameInformation()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  HGRenderGraphLogger *m_FrameInformationLogger; // rdi
		  String *v7; // rsi
		  Object__Array *v8; // rax
		  HGRenderGraphDebugParams *v9; // rax
		  HGRenderGraphLogger *v10; // rsi
		  __int64 v11; // rax
		  Object__Array *v12; // rdi
		  __int64 v13; // rax
		  __int64 v14; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t size; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(28, 0LL) )
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( m_DebugParameters )
		    {
		      if ( !m_DebugParameters->fields.enableLogging )
		        return;
		      m_FrameInformationLogger = this->fields.m_FrameInformationLogger;
		      v7 = System::String::Concat(
		             (String *)"==== Staring render graph frame for: ",
		             this->fields.m_CurrentExecutionName,
		             (String *)" ====",
		             0LL);
		      v8 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		      if ( m_FrameInformationLogger )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(m_FrameInformationLogger, v7, v8, 0LL);
		        v9 = this->fields.m_DebugParameters;
		        if ( v9 )
		        {
		          if ( v9->fields.immediateMode )
		            return;
		          v10 = this->fields.m_FrameInformationLogger;
		          v11 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		          m_RenderPasses = this->fields.m_RenderPasses;
		          v12 = (Object__Array *)v11;
		          if ( m_RenderPasses )
		          {
		            size = m_RenderPasses->fields._size;
		            v13 = il2cpp_value_box_0(TypeInfo::System::Int32, &size);
		            v14 = v13;
		            if ( v12 )
		            {
		              sub_180031B10(v12, v13);
		              sub_180005370(v12, 0LL, v14);
		              if ( v10 )
		              {
		                HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		                  v10,
		                  (String *)"Number of passes declared: {0}\n",
		                  v12,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_RenderPasses, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(28, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void LogRendererListsCreation() {} // 0x0000000189B2E2D0-0x0000000189B2E3B4
		// Void LogRendererListsCreation()
		void HG::Rendering::RenderGraphModule::HGRenderGraph::LogRendererListsCreation(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *m_RendererLists; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rax
		  HGRenderGraphLogger *m_FrameInformationLogger; // rsi
		  __int64 v7; // rax
		  Object__Array *v8; // rdi
		  __int64 v9; // rax
		  __int64 v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t size; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(72, 0LL) )
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( m_DebugParameters )
		    {
		      if ( !m_DebugParameters->fields.enableLogging )
		        return;
		      m_FrameInformationLogger = this->fields.m_FrameInformationLogger;
		      v7 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		      m_RendererLists = this->fields.m_RendererLists;
		      v8 = (Object__Array *)v7;
		      if ( m_RendererLists )
		      {
		        size = m_RendererLists->fields._size;
		        v9 = il2cpp_value_box_0(TypeInfo::System::Int32, &size);
		        v10 = v9;
		        if ( v8 )
		        {
		          sub_180031B10(v8, v9);
		          sub_180005370(v8, 0LL, v10);
		          if ( m_FrameInformationLogger )
		          {
		            HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		              m_FrameInformationLogger,
		              (String *)"Number of renderer lists created: {0}\n",
		              v8,
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(m_RendererLists, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(72, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void LogRenderPassBegin([IsReadOnly] in CompiledPassInfo passInfo) {} // 0x0000000189B2E02C-0x0000000189B2E2D0
		// Void LogRenderPassBegin(HGRenderGraph+CompiledPassInfo ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::LogRenderPassBegin(
		        HGRenderGraph *this,
		        HGRenderGraph_CompiledPassInfo *passInfo,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rbx
		  HGRenderGraphPass *pass; // rsi
		  HGRenderGraphLogger *m_FrameInformationLogger; // r13
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object__Array *v12; // rbx
		  __int64 v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // r14
		  const char *v17; // r14
		  String *name_k__BackingField; // rsi
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  HGRenderGraphLogger *v21; // rdi
		  Object__Array *v22; // rbx
		  __int64 v23; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int64 v26; // rsi
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Il2CppExceptionWrapper *v32; // [rsp+20h] [rbp-58h] BYREF
		  _QWORD v33[2]; // [rsp+28h] [rbp-50h] BYREF
		  HGRenderGraphLogIndent v34; // [rsp+38h] [rbp-40h] BYREF
		  int32_t index_k__BackingField; // [rsp+98h] [rbp+20h] BYREF
		
		  memset(&v34, 0, sizeof(v34));
		  if ( IFix::WrappersManagerImpl::IsPatched(78, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(78, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_38(Patch, (Object *)this, passInfo, 0LL);
		  }
		  else
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( !m_DebugParameters )
		      sub_1800D8260(v6, v5);
		    if ( m_DebugParameters->fields.enableLogging )
		    {
		      pass = passInfo->pass;
		      m_FrameInformationLogger = this->fields.m_FrameInformationLogger;
		      v12 = (Object__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Object, 3LL);
		      if ( !pass )
		        sub_1800D8260(v11, v10);
		      index_k__BackingField = pass->fields._index_k__BackingField;
		      v13 = il2cpp_value_box_0(TypeInfo::System::Int32, &index_k__BackingField);
		      v16 = v13;
		      if ( !v12 )
		        sub_1800D8260(v15, v14);
		      sub_180031B10(v12, v13);
		      sub_180005370(v12, 0LL, v16);
		      v17 = "Compute";
		      if ( !pass->fields._enableAsyncCompute_k__BackingField )
		        v17 = "Graphics";
		      sub_180031B10(v12, v17);
		      sub_180005370(v12, 1LL, v17);
		      name_k__BackingField = pass->fields._name_k__BackingField;
		      sub_180031B10(v12, name_k__BackingField);
		      sub_180005370(v12, 2LL, name_k__BackingField);
		      if ( !m_FrameInformationLogger )
		        sub_1800D8260(v20, v19);
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		        m_FrameInformationLogger,
		        (String *)"[{0}][{1}] \"{2}\"",
		        v12,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
		        &v34,
		        this->fields.m_FrameInformationLogger,
		        1,
		        0LL);
		      v33[0] = 0LL;
		      v33[1] = &v34;
		      try
		      {
		        if ( passInfo->syncToPassIndex != -1 )
		        {
		          v21 = this->fields.m_FrameInformationLogger;
		          v22 = (Object__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Object, 1LL);
		          index_k__BackingField = passInfo->syncToPassIndex;
		          v23 = il2cpp_value_box_0(TypeInfo::System::Int32, &index_k__BackingField);
		          v26 = v23;
		          if ( !v22 )
		            sub_1800D8250(v25, v24);
		          sub_180031B10(v22, v23);
		          sub_180005370(v22, 0LL, v26);
		          if ( !v21 )
		            sub_1800D8250(v28, v27);
		          HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		            v21,
		            (String *)"Synchronize with [{0}]",
		            v22,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v32 )
		      {
		        v33[0] = v32->ex;
		      }
		      sub_180267B30(v33);
		    }
		  }
		}
		
		private void LogCulledPasses() {} // 0x0000000189B2DC58-0x0000000189B2DEE4
		// Void LogCulledPasses()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::LogCulledPasses(HGRenderGraph *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderGraphDebugParams *m_DebugParameters; // rdi
		  HGRenderGraphLogger *m_FrameInformationLogger; // rdi
		  Object__Array *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  List_1_System_Object_ *m_RenderPasses; // rcx
		  Object *Item; // r14
		  HGRenderGraphLogger *v15; // r12
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Object__Array *v18; // rsi
		  __int64 v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // r15
		  Object__Class *klass; // r14
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  int32_t i; // edi
		  HGRenderGraphLogger *v27; // rbx
		  Object__Array *v28; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  Il2CppExceptionWrapper *v34; // [rsp+20h] [rbp-48h] BYREF
		  _QWORD v35[2]; // [rsp+28h] [rbp-40h] BYREF
		  HGRenderGraphLogIndent v36; // [rsp+38h] [rbp-30h] BYREF
		  int monitor; // [rsp+80h] [rbp+18h] BYREF
		
		  memset(&v36, 0, sizeof(v36));
		  if ( IFix::WrappersManagerImpl::IsPatched(49, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(49, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v33, v32);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_DebugParameters = this->fields.m_DebugParameters;
		    if ( !m_DebugParameters )
		      sub_1800D8260(v4, v3);
		    if ( m_DebugParameters->fields.enableLogging )
		    {
		      m_FrameInformationLogger = this->fields.m_FrameInformationLogger;
		      v7 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		      if ( !m_FrameInformationLogger )
		        sub_1800D8260(v9, v8);
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		        m_FrameInformationLogger,
		        (String *)"Pass Culling Report:",
		        v7,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
		        &v36,
		        this->fields.m_FrameInformationLogger,
		        1,
		        0LL);
		      v35[0] = 0LL;
		      v35[1] = &v36;
		      try
		      {
		        for ( i = 0; ; ++i )
		        {
		          m_CompiledPassInfos = this->fields.m_CompiledPassInfos;
		          if ( !m_CompiledPassInfos )
		            sub_1800D8250(v11, v10);
		          if ( i >= m_CompiledPassInfos->fields._size_k__BackingField )
		            break;
		          if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                 (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this->fields.m_CompiledPassInfos,
		                 i,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item)->culled )
		          {
		            m_RenderPasses = (List_1_System_Object_ *)this->fields.m_RenderPasses;
		            if ( !m_RenderPasses )
		              sub_1800D8250(0LL, v10);
		            Item = System::Collections::Generic::List<System::Object>::get_Item(
		                     m_RenderPasses,
		                     i,
		                     MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
		            v15 = this->fields.m_FrameInformationLogger;
		            v18 = (Object__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Object, 2LL);
		            if ( !Item )
		              sub_1800D8250(v17, v16);
		            monitor = (int)Item[1].monitor;
		            v19 = il2cpp_value_box_0(TypeInfo::System::Int32, &monitor);
		            v22 = v19;
		            if ( !v18 )
		              sub_1800D8250(v21, v20);
		            sub_180031B10(v18, v19);
		            sub_180005370(v18, 0LL, v22);
		            klass = Item[1].klass;
		            sub_180031B10(v18, klass);
		            sub_180005370(v18, 1LL, klass);
		            if ( !v15 )
		              sub_1800D8250(v25, v24);
		            HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v15, (String *)"[{0}] {1}", v18, 0LL);
		          }
		        }
		        v27 = this->fields.m_FrameInformationLogger;
		        v28 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		        if ( !v27 )
		          sub_1800D8250(v30, v29);
		        HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v27, (String *)"\n", v28, 0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v34 )
		      {
		        v35[0] = v34->ex;
		      }
		      sub_180267B30(v35);
		    }
		  }
		}
		
		private ProfilingSampler GetDefaultProfilingSampler(string name) => default; // 0x0000000189B2CDB4-0x0000000189B2CEA4
		// ProfilingSampler GetDefaultProfilingSampler(String)
		ProfilingSampler *HG::Rendering::RenderGraphModule::HGRenderGraph::GetDefaultProfilingSampler(
		        HGRenderGraph *this,
		        String *name,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_Int32_UnityEngine_Rendering_ProfilingSampler_ *m_DefaultProfilingSamplers; // rcx
		  int32_t v7; // eax
		  int32_t v8; // ebp
		  ProfilingSampler *v9; // rax
		  Object *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(219, 0LL) )
		  {
		    if ( name )
		    {
		      v7 = sub_180002F70(2LL, name);
		      m_DefaultProfilingSamplers = this->fields.m_DefaultProfilingSamplers;
		      v8 = v7;
		      if ( m_DefaultProfilingSamplers )
		      {
		        if ( System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		               (Dictionary_2_System_Int32_System_Object_ *)m_DefaultProfilingSamplers,
		               v7,
		               &value,
		               MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::TryGetValue) )
		        {
		          return (ProfilingSampler *)value;
		        }
		        v9 = (ProfilingSampler *)sub_18002C620(TypeInfo::UnityEngine::Rendering::ProfilingSampler);
		        v10 = (Object *)v9;
		        if ( v9 )
		        {
		          UnityEngine::Rendering::ProfilingSampler::ProfilingSampler(v9, name, 0LL);
		          m_DefaultProfilingSamplers = this->fields.m_DefaultProfilingSamplers;
		          value = v10;
		          if ( m_DefaultProfilingSamplers )
		          {
		            System::Collections::Generic::Dictionary<int,System::Object>::Add(
		              (Dictionary_2_System_Int32_System_Object_ *)m_DefaultProfilingSamplers,
		              v8,
		              v10,
		              MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::Add);
		            return (ProfilingSampler *)value;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_DefaultProfilingSamplers, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(219, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_101(Patch, (Object *)this, (Object *)name, 0LL);
		}
		
		private void UpdateImportedResourceLifeTime(ref HGRenderGraphDebugData.ResourceDebugData data, List<int> passList) {} // 0x0000000189B2F244-0x0000000189B2F3AC
		// Void UpdateImportedResourceLifeTime(HGRenderGraphDebugData+ResourceDebugData ByRef, List`1[System.Int32])
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
		        HGRenderGraph *this,
		        HGRenderGraphDebugData_ResourceDebugData *data,
		        List_1_System_Int32_ *passList,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t current; // edi
		  int32_t creationPassIndex; // esi
		  int32_t releasePassIndex; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+30h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Int32_ v16; // [rsp+38h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Int32_ v17; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(97, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(97, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_49(Patch, (Object *)this, data, (Object *)passList, 0LL);
		  }
		  else
		  {
		    if ( !passList )
		      sub_1800D8260(v8, v7);
		    System::Collections::Generic::List<int>::GetEnumerator(
		      &v16,
		      passList,
		      MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		    v17 = v16;
		    v16._list = 0LL;
		    *(_QWORD *)&v16._index = &v17;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v17,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		      {
		        current = v17._current;
		        if ( data->creationPassIndex == -1 )
		        {
		          creationPassIndex = v17._current;
		        }
		        else
		        {
		          creationPassIndex = data->creationPassIndex;
		          sub_1800036A0(TypeInfo::System::Math);
		          if ( creationPassIndex > current )
		            creationPassIndex = current;
		        }
		        data->creationPassIndex = creationPassIndex;
		        if ( data->releasePassIndex == -1 )
		        {
		          data->releasePassIndex = current;
		        }
		        else
		        {
		          releasePassIndex = data->releasePassIndex;
		          sub_1800036A0(TypeInfo::System::Math);
		          if ( releasePassIndex < current )
		            releasePassIndex = current;
		          data->releasePassIndex = releasePassIndex;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      v16._list = (List_1_System_Int32_ *)v15->ex;
		      if ( v16._list )
		        sub_18007E1E0(v16._list);
		    }
		  }
		}
		
		private void GenerateDebugData() {} // 0x0000000189B2BDB4-0x0000000189B2CC44
		// Void GenerateDebugData()
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::RenderGraphModule::HGRenderGraph::GenerateDebugData(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraph *v2; // rsi
		  __int64 v3; // rdx
		  HGRenderGraph__StaticFields *static_fields; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraph_OnExecutionRegisteredDelegate *onExecutionRegistered; // rcx
		  HGRenderGraphDebugData *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Object *v11; // rbx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v14; // rdx
		  List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *resourceCreateList; // rcx
		  HGRenderGraphResourceType__Enum v16; // edi
		  __int64 v17; // r12
		  int32_t i; // r13d
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
		  __int64 v20; // rbx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v21; // rbx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v22; // rbx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  RenderGraph_CompiledResourceInfo *Item; // r15
		  Type *v26; // rdx
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  IEnumerable_1_System_Int32_ *consumers; // r14
		  List_1_System_Int32_ *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  FieldDescriptor *v35; // rbx
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  IEnumerable_1_System_Int32_ *producers; // r14
		  List_1_System_Int32_ *v40; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  Action_2_Google_Protobuf_IMessage_Object_ *v43; // rbx
		  Type *v44; // rdx
		  PropertyInfo_1 *v45; // r8
		  Int32__Array **v46; // r9
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  MonitorData *monitor; // rbx
		  __int64 v50; // rbx
		  int32_t j; // r15d
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
		  Type *v53; // rdx
		  __int64 v54; // rcx
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  RenderGraph_CompiledPassInfo *v57; // r14
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  Type *v60; // rdx
		  PropertyInfo_1 *v61; // r8
		  Int32__Array **v62; // r9
		  Type *v63; // rdx
		  PropertyInfo_1 *v64; // r8
		  Int32__Array **v65; // r9
		  int k; // edi
		  unsigned int clearDelegate; // r13d
		  __int64 v68; // r12
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v69; // rax
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v72; // rbx
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  __int64 v75; // r12
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v76; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v79; // rbx
		  __int64 v80; // rdx
		  __int64 v81; // rcx
		  __int64 v82; // rdx
		  __int64 v83; // rcx
		  List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
		  __int64 v85; // rax
		  __int64 v86; // r8
		  __int64 v87; // r12
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent current; // rbx
		  unsigned int v89; // eax
		  __int64 v90; // rdx
		  __int64 v91; // rcx
		  RenderGraphPass__Class *klass; // rax
		  __int64 v93; // rdx
		  unsigned int clearDelegate_high; // r13d
		  __int64 v95; // rcx
		  __int64 v96; // r12
		  CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent v97; // rbx
		  unsigned int v98; // eax
		  __int64 v99; // rdx
		  __int64 v100; // rcx
		  int32_t v101; // ebx
		  MonitorData *v102; // rcx
		  List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *v103; // rdx
		  __int64 v104; // rdx
		  __int64 v105; // r8
		  MonitorData *v106; // rcx
		  List_1_Beyond_StyledBlackboard_StyledDataPair_ *v107; // rcx
		  __int64 v108; // r8
		  int32_t v109; // ebx
		  MonitorData *v110; // rcx
		  List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *v111; // rdx
		  __int64 v112; // rdx
		  __int64 v113; // r8
		  MonitorData *v114; // rcx
		  List_1_Beyond_StyledBlackboard_StyledDataPair_ *v115; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v117; // rdx
		  __int64 v118; // rcx
		  _BYTE v119[32]; // [rsp+0h] [rbp-218h] BYREF
		  Object *value; // [rsp+20h] [rbp-1F8h] BYREF
		  Action_2_Google_Protobuf_IMessage_Object_ *setValueDelegate; // [rsp+28h] [rbp-1F0h]
		  __int128 v122; // [rsp+30h] [rbp-1E8h] BYREF
		  __int128 v123; // [rsp+40h] [rbp-1D8h] BYREF
		  __int128 v124; // [rsp+60h] [rbp-1B8h] BYREF
		  __int128 v125; // [rsp+70h] [rbp-1A8h]
		  WeaponComponent_WeaponMountPointModifier v126; // [rsp+80h] [rbp-198h] BYREF
		  SingleFieldAccessor data; // [rsp+B0h] [rbp-168h] BYREF
		  unsigned int v128; // [rsp+E8h] [rbp-130h]
		  unsigned int v129; // [rsp+ECh] [rbp-12Ch]
		  unsigned int v130; // [rsp+F0h] [rbp-128h]
		  unsigned int v131; // [rsp+F4h] [rbp-124h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v132; // [rsp+F8h] [rbp-120h] BYREF
		  List_1_T_Enumerator_System_Int32_ v133; // [rsp+110h] [rbp-108h] BYREF
		  FieldAccessorBase__Fields v134; // [rsp+128h] [rbp-F0h]
		  __int128 v135; // [rsp+138h] [rbp-E0h]
		  Il2CppException *ex; // [rsp+148h] [rbp-D0h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v137; // [rsp+150h] [rbp-C8h]
		  Il2CppException *v138; // [rsp+158h] [rbp-C0h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v139; // [rsp+160h] [rbp-B8h]
		  Il2CppExceptionWrapper *v140; // [rsp+168h] [rbp-B0h] BYREF
		  Il2CppExceptionWrapper *v141; // [rsp+170h] [rbp-A8h] BYREF
		  Il2CppExceptionWrapper *v142; // [rsp+178h] [rbp-A0h] BYREF
		  Il2CppExceptionWrapper *v143; // [rsp+180h] [rbp-98h] BYREF
		  __int128 v144; // [rsp+188h] [rbp-90h]
		  __int128 v145; // [rsp+1C0h] [rbp-58h]
		  int32_t v147; // [rsp+238h] [rbp+20h]
		
		  v2 = this;
		  value = 0LL;
		  memset(&data, 0, 40);
		  v122 = 0LL;
		  v123 = 0LL;
		  memset(&v132, 0, sizeof(v132));
		  memset(&v133, 0, sizeof(v133));
		  if ( IFix::WrappersManagerImpl::IsPatched(90, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(90, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v118, v117);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else if ( !v2->fields.m_ExecutionExceptionWasRaised )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		    static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields;
		    if ( static_fields->_requireDebugData_k__BackingField )
		    {
		      if ( !v2->fields.m_DebugData )
		        sub_1800D8260(static_fields, v3);
		      if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		              (Dictionary_2_System_Object_System_Object_ *)v2->fields.m_DebugData,
		              (Object *)v2->fields.m_CurrentExecutionName,
		              &value,
		              MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		        onExecutionRegistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->onExecutionRegistered;
		        if ( onExecutionRegistered )
		          ((void (__fastcall *)(void *, HGRenderGraph *, String *, void *))onExecutionRegistered->fields._._.invoke_impl)(
		            onExecutionRegistered->fields._._.method_code,
		            v2,
		            v2->fields.m_CurrentExecutionName,
		            onExecutionRegistered->fields._._.method);
		        v8 = (HGRenderGraphDebugData *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugData);
		        v11 = (Object *)v8;
		        if ( !v8 )
		          sub_1800D8260(v10, v9);
		        HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::HGRenderGraphDebugData(v8, 0LL);
		        value = v11;
		        if ( !v2->fields.m_DebugData )
		          sub_1800D8260(v13, v12);
		        System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		          (Dictionary_2_System_Object_System_Object_ *)v2->fields.m_DebugData,
		          (Object *)v2->fields.m_CurrentExecutionName,
		          v11,
		          MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Add);
		      }
		      if ( !value )
		        sub_1800D8260(v6, v5);
		      HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::Clear((HGRenderGraphDebugData *)value, 0LL);
		      v16 = HGRenderGraphResourceType__Enum_Texture;
		      v17 = 32LL;
		      do
		      {
		        for ( i = 0; ; ++i )
		        {
		          m_CompiledResourcesInfos = v2->fields.m_CompiledResourcesInfos;
		          if ( !m_CompiledResourcesInfos )
		            sub_1800D8260(resourceCreateList, v14);
		          if ( v16 >= m_CompiledResourcesInfos->max_length.size )
		            sub_1800D2AB0(resourceCreateList, v14);
		          v20 = *(__int64 *)((char *)&m_CompiledResourcesInfos->klass + v17);
		          if ( !v20 )
		            sub_1800D8260(resourceCreateList, v14);
		          if ( i >= *(_DWORD *)(v20 + 24) )
		            break;
		          v21 = v2->fields.m_CompiledResourcesInfos;
		          if ( !v21 )
		            sub_1800D8260(resourceCreateList, v14);
		          if ( v16 >= v21->max_length.size )
		            sub_1800D2AB0(resourceCreateList, v14);
		          v22 = *(DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ **)((char *)&v21->klass + v17);
		          if ( !v22 )
		            sub_1800D8260(resourceCreateList, v14);
		          Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                   v22,
		                   i,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
		          memset(&data, 0, 40);
		          if ( !v2->fields.m_Resources )
		            sub_1800D8260(v24, v23);
		          data.klass = (SingleFieldAccessor__Class *)HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
		                                                       v2->fields.m_Resources,
		                                                       v16,
		                                                       i,
		                                                       0LL);
		          sub_18002D1B0(&data, v26, v27, v28, (MethodInfo *)value);
		          if ( !v2->fields.m_Resources )
		            sub_1800D8260(v30, v29);
		          LOBYTE(data.monitor) = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		                                   v2->fields.m_Resources,
		                                   v16,
		                                   i,
		                                   0LL);
		          HIDWORD(data.monitor) = -1;
		          LODWORD(data.fields._.getValueDelegate) = -1;
		          consumers = (IEnumerable_1_System_Int32_ *)Item->consumers;
		          v32 = (List_1_System_Int32_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		          v35 = (FieldDescriptor *)v32;
		          if ( !v32 )
		            sub_1800D8260(v34, v33);
		          System::Collections::Generic::List<int>::List(
		            v32,
		            consumers,
		            MethodInfo::System::Collections::Generic::List<int>::List);
		          data.fields._.descriptor = v35;
		          sub_18002D1B0((SingleFieldAccessor *)&data.fields._.descriptor, v36, v37, v38, (MethodInfo *)value);
		          producers = (IEnumerable_1_System_Int32_ *)Item->producers;
		          v40 = (List_1_System_Int32_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		          v43 = (Action_2_Google_Protobuf_IMessage_Object_ *)v40;
		          if ( !v40 )
		            sub_1800D8260(v42, v41);
		          System::Collections::Generic::List<int>::List(
		            v40,
		            producers,
		            MethodInfo::System::Collections::Generic::List<int>::List);
		          data.fields.setValueDelegate = v43;
		          sub_18002D1B0((SingleFieldAccessor *)&data.fields.setValueDelegate, v44, v45, v46, (MethodInfo *)value);
		          if ( LOBYTE(data.monitor) )
		          {
		            HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
		              v2,
		              (HGRenderGraphDebugData_ResourceDebugData *)&data,
		              (List_1_System_Int32_ *)data.fields._.descriptor,
		              0LL);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
		              v2,
		              (HGRenderGraphDebugData_ResourceDebugData *)&data,
		              (List_1_System_Int32_ *)data.fields.setValueDelegate,
		              0LL);
		          }
		          if ( !value )
		            sub_1800D8260(v48, v47);
		          monitor = value[1].monitor;
		          if ( !monitor )
		            sub_1800D8260(v48, v47);
		          if ( v16 >= *((_DWORD *)monitor + 6) )
		            sub_1800D2AB0(v48, v47);
		          v50 = *(_QWORD *)((char *)monitor + v17);
		          v135 = *(_OWORD *)&data.klass;
		          v134 = data.fields._;
		          setValueDelegate = data.fields.setValueDelegate;
		          if ( !v50 )
		            sub_1800D8260(v48, v47);
		          *(_OWORD *)&v126.instId = *(_OWORD *)&data.klass;
		          *(FieldAccessorBase__Fields *)&v126.fightMp.value = data.fields._;
		          v126.fightNode = (Transform *)data.fields.setValueDelegate;
		          sub_180492B84(
		            v50,
		            &v126,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::Add);
		        }
		        ++v16;
		        v17 += 8LL;
		      }
		      while ( (int)v16 < (int)HGRenderGraphResourceType__Enum_Count );
		      for ( j = 0; ; ++j )
		      {
		        v147 = j;
		        m_CompiledPassInfos = v2->fields.m_CompiledPassInfos;
		        if ( !m_CompiledPassInfos )
		          break;
		        if ( j >= m_CompiledPassInfos->fields._size_k__BackingField )
		          return;
		        v57 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
		                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2->fields.m_CompiledPassInfos,
		                j,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
		        setValueDelegate = (Action_2_Google_Protobuf_IMessage_Object_ *)v57;
		        v122 = 0LL;
		        v123 = 0LL;
		        if ( !v57->pass )
		          sub_1800D8260(v54, v53);
		        *(_QWORD *)&v122 = v57->pass->fields._name_k__BackingField;
		        sub_18002D1B0((SingleFieldAccessor *)&v122, v53, v55, v56, (MethodInfo *)value);
		        BYTE8(v123) = v57->culled;
		        if ( !v57->pass )
		          sub_1800D8260(v59, v58);
		        BYTE9(v123) = BYTE4(v57->pass->fields.usedRendererListList);
		        *((_QWORD *)&v122 + 1) = il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<int>, 2LL);
		        sub_18002D1B0((SingleFieldAccessor *)((char *)&v122 + 8), v60, v61, v62, (MethodInfo *)value);
		        *(_QWORD *)&v123 = il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<int>, 2LL);
		        sub_18002D1B0((SingleFieldAccessor *)&v123, v63, v64, v65, (MethodInfo *)value);
		        for ( k = 0; ; ++k )
		        {
		          v131 = k;
		          v130 = k;
		          v129 = k;
		          v128 = k;
		          HIDWORD(data.fields.hasDelegate) = k;
		          LODWORD(data.fields.hasDelegate) = k;
		          HIDWORD(data.fields.clearDelegate) = k;
		          clearDelegate = k;
		          LODWORD(data.fields.clearDelegate) = k;
		          if ( k >= 2 )
		            break;
		          v68 = *((_QWORD *)&v122 + 1);
		          v69 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		          v72 = v69;
		          if ( !v69 )
		            sub_1800D8260(v71, v70);
		          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		            v69,
		            MethodInfo::System::Collections::Generic::List<int>::List);
		          if ( !v68 )
		            sub_1800D8260(v74, v73);
		          sub_180031B10(v68, v72);
		          sub_1800020D0(v68, k, v72);
		          v75 = v123;
		          v76 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		          v79 = v76;
		          if ( !v76 )
		            sub_1800D8260(v78, v77);
		          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		            v76,
		            MethodInfo::System::Collections::Generic::List<int>::List);
		          if ( !v75 )
		            sub_1800D8260(v81, v80);
		          sub_180031B10(v75, v79);
		          sub_1800020D0(v75, k, v79);
		          if ( !v57->pass )
		            sub_1800D8260(v83, v82);
		          dependsOnRendererListList = v57->pass->fields.dependsOnRendererListList;
		          if ( !dependsOnRendererListList )
		            sub_1800D8260(v83, v82);
		          if ( (unsigned int)k >= dependsOnRendererListList->fields._size )
		            sub_1800D2AB0(v83, v82);
		          v85 = *((_QWORD *)&dependsOnRendererListList->fields._syncRoot + k);
		          if ( !v85 )
		            sub_1800D8260(v83, v82);
		          v132 = *(List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)sub_1808AD2E0(&v124, v85);
		          ex = 0LL;
		          v137 = &v132;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                      &v132,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		            {
		              if ( !*((_QWORD *)&v122 + 1) )
		                sub_1800D8250(resourceCreateList, v14);
		              if ( (unsigned int)k >= *(_DWORD *)(*((_QWORD *)&v122 + 1) + 24LL) )
		                sub_1800D2AA0(resourceCreateList, v14, v86);
		              v87 = *(_QWORD *)(*((_QWORD *)&v122 + 1) + 8LL * k + 32);
		              current = v132._current;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		              v89 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
		              if ( !v87 )
		                sub_1800D8250(v91, v90);
		              sub_183081250(v87, v89, MethodInfo::System::Collections::Generic::List<int>::Add);
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v140 )
		          {
		            v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v119;
		            ex = v140->ex;
		            resourceCreateList = (List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *)ex;
		            if ( ex )
		              sub_18007E1E0(ex);
		            v2 = this;
		            j = v147;
		            v57 = (RenderGraph_CompiledPassInfo *)setValueDelegate;
		            clearDelegate = (unsigned int)data.fields.clearDelegate;
		          }
		          if ( !v57->pass )
		            goto LABEL_165;
		          klass = v57->pass[1].klass;
		          if ( !klass )
		            goto LABEL_165;
		          v93 = k;
		          if ( clearDelegate >= LODWORD(klass->_0.namespaze) )
		            goto LABEL_164;
		          v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&klass->_0.byval_arg.data.dummy + k);
		          if ( !v14 )
		            goto LABEL_165;
		          System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		            (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v124,
		            v14,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
		          *(_OWORD *)&v132._list = v124;
		          v132._current = (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)v125;
		          v138 = 0LL;
		          v139 = &v132;
		          try
		          {
		            clearDelegate_high = HIDWORD(data.fields.clearDelegate);
		            while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                      &v132,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
		            {
		              if ( !(_QWORD)v123 )
		                sub_1800D8250(v95, v14);
		              if ( clearDelegate_high >= *(_DWORD *)(v123 + 24) )
		                sub_1800D2AA0(v95, v14, v86);
		              v96 = *(_QWORD *)(v123 + 8LL * k + 32);
		              v97 = v132._current;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		              v98 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v97, 0LL);
		              if ( !v96 )
		                sub_1800D8250(v100, v99);
		              sub_183081250(v96, v98, MethodInfo::System::Collections::Generic::List<int>::Add);
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v141 )
		          {
		            v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v119;
		            v138 = v141->ex;
		            if ( v138 )
		              sub_18007E1E0(v138);
		            v2 = this;
		            j = v147;
		            v57 = (RenderGraph_CompiledPassInfo *)setValueDelegate;
		          }
		          resourceCreateList = (List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *)v57->resourceCreateList;
		          if ( !resourceCreateList )
		            goto LABEL_165;
		          v93 = k;
		          if ( LODWORD(data.fields.hasDelegate) >= resourceCreateList->fields._size )
		            goto LABEL_164;
		          v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&resourceCreateList->fields._syncRoot + k);
		          if ( !v14 )
		            goto LABEL_165;
		          System::Collections::Generic::List<int>::GetEnumerator(
		            (List_1_T_Enumerator_System_Int32_ *)&v124,
		            (List_1_System_Int32_ *)v14,
		            MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		          *(_OWORD *)&v133._list = v124;
		          *(_QWORD *)&v133._current = v125;
		          v134.getValueDelegate = 0LL;
		          v134.descriptor = (FieldDescriptor *)&v133;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                      &v133,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		            {
		              v101 = v133._current;
		              if ( !value )
		                sub_1800D8250(0LL, v14);
		              v102 = value[1].monitor;
		              if ( !v102 )
		                sub_1800D8250(0LL, v14);
		              if ( HIDWORD(data.fields.hasDelegate) >= *((_DWORD *)v102 + 6) )
		                sub_1800D2AA0(v102, k, v86);
		              v103 = (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)*((_QWORD *)v102 + k + 4);
		              if ( !v103 )
		                sub_1800D8250(v102, 0LL);
		              System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
		                &v126,
		                v103,
		                v133._current,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::get_Item);
		              v144 = *(_OWORD *)&v126.instId;
		              if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v126.instId, 8)) )
		              {
		                HIDWORD(v144) = j;
		                if ( !value )
		                  sub_1800D8250(0LL, v104);
		                v106 = value[1].monitor;
		                if ( !v106 )
		                  sub_1800D8250(0LL, v104);
		                if ( v128 >= *((_DWORD *)v106 + 6) )
		                  sub_1800D2AA0(v106, k, v105);
		                v107 = (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)*((_QWORD *)v106 + k + 4);
		                if ( !v107 )
		                  sub_1800D8250(0LL, k);
		                *(_OWORD *)&v126.instId = v144;
		                System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::set_Item(
		                  v107,
		                  v101,
		                  (StyledBlackboard_StyledDataPair *)&v126,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::set_Item);
		              }
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v142 )
		          {
		            v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v119;
		            v134.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)v142->ex;
		            if ( v134.getValueDelegate )
		              sub_18007E1E0(v134.getValueDelegate);
		            v2 = this;
		            j = v147;
		            v57 = (RenderGraph_CompiledPassInfo *)setValueDelegate;
		          }
		          resourceCreateList = (List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *)v57->resourceReleaseList;
		          if ( !resourceCreateList )
		            goto LABEL_165;
		          v93 = k;
		          if ( v129 >= resourceCreateList->fields._size )
		LABEL_164:
		            sub_1800D2AA0(resourceCreateList, v93, v86);
		          v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)*((_QWORD *)&resourceCreateList->fields._syncRoot + k);
		          if ( !v14 )
		            goto LABEL_165;
		          System::Collections::Generic::List<int>::GetEnumerator(
		            (List_1_T_Enumerator_System_Int32_ *)&v124,
		            (List_1_System_Int32_ *)v14,
		            MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		          *(_OWORD *)&v133._list = v124;
		          *(_QWORD *)&v133._current = v125;
		          *(_QWORD *)&v135 = 0LL;
		          *((_QWORD *)&v135 + 1) = &v133;
		          try
		          {
		            while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                      &v133,
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		            {
		              v109 = v133._current;
		              if ( !value )
		                sub_1800D8250(0LL, v14);
		              v110 = value[1].monitor;
		              if ( !v110 )
		                sub_1800D8250(0LL, v14);
		              if ( v130 >= *((_DWORD *)v110 + 6) )
		                sub_1800D2AA0(v110, k, v108);
		              v111 = (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)*((_QWORD *)v110 + k + 4);
		              if ( !v111 )
		                sub_1800D8250(v110, 0LL);
		              System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
		                &v126,
		                v111,
		                v133._current,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::get_Item);
		              v145 = *(_OWORD *)&v126.fightMp.value;
		              if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v126.instId, 8)) )
		              {
		                LODWORD(v145) = j;
		                if ( !value )
		                  sub_1800D8250(0LL, v112);
		                v114 = value[1].monitor;
		                if ( !v114 )
		                  sub_1800D8250(0LL, v112);
		                if ( v131 >= *((_DWORD *)v114 + 6) )
		                  sub_1800D2AA0(v114, k, v113);
		                v115 = (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)*((_QWORD *)v114 + k + 4);
		                if ( !v115 )
		                  sub_1800D8250(0LL, k);
		                *(_OWORD *)&v126.fightMp.value = v145;
		                System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::set_Item(
		                  v115,
		                  v109,
		                  (StyledBlackboard_StyledDataPair *)&v126,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::set_Item);
		              }
		            }
		          }
		          catch ( Il2CppExceptionWrapper *v143 )
		          {
		            v14 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v119;
		            *(Il2CppExceptionWrapper *)&v135 = (Il2CppExceptionWrapper)v143->ex;
		            resourceCreateList = (List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *)v135;
		            if ( (_QWORD)v135 )
		              sub_18007E1E0(v135);
		            v2 = this;
		            j = v147;
		            v57 = (RenderGraph_CompiledPassInfo *)setValueDelegate;
		          }
		        }
		        if ( !value )
		          break;
		        resourceCreateList = (List_1_UnityEngine_UIElements_VisualTreeAsset_AssetEntry_ *)value[1].klass;
		        if ( !resourceCreateList )
		          break;
		        v124 = v122;
		        v125 = v123;
		        *(_OWORD *)&v126.instId = v122;
		        *(_OWORD *)&v126.fightMp.value = v123;
		        System::Collections::Generic::List<UnityEngine::UIElements::VisualTreeAsset::AssetEntry>::Add(
		          resourceCreateList,
		          (VisualTreeAsset_AssetEntry *)&v126,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>::Add);
		      }
		LABEL_165:
		      sub_1800D8250(resourceCreateList, v14);
		    }
		    HG::Rendering::RenderGraphModule::HGRenderGraph::CleanupDebugData(v2, 0LL);
		  }
		}
		
		private void CleanupDebugData() {} // 0x0000000189B29770-0x0000000189B298F8
		// Void CleanupDebugData()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraph::CleanupDebugData(HGRenderGraph *this, MethodInfo *method)
		{
		  HGRenderGraph *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 *v5; // rdx
		  Object *key; // xmm6_8
		  HGRenderGraph_OnExecutionRegisteredDelegate *onExecutionUnregistered; // rcx
		  Dictionary_2_System_Object_System_Object_ *m_DebugData; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // [rsp+0h] [rbp-A8h] BYREF
		  Il2CppExceptionWrapper *v13; // [rsp+20h] [rbp-88h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v15; // [rsp+30h] [rbp-78h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v16; // [rsp+38h] [rbp-70h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v17; // [rsp+60h] [rbp-48h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(92, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(92, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.m_DebugData )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v17,
		      (Dictionary_2_System_UInt64_System_Object_ *)v2->fields.m_DebugData,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::GetEnumerator);
		    v16 = v17;
		    ex = 0LL;
		    v15 = &v16;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v16,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::MoveNext) )
		      {
		        key = v16._current.key;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
		        onExecutionUnregistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->onExecutionUnregistered;
		        if ( onExecutionUnregistered )
		          ((void (__fastcall *)(void *, HGRenderGraph *, Object *, void *))onExecutionUnregistered->fields._._.invoke_impl)(
		            onExecutionUnregistered->fields._._.method_code,
		            v2,
		            key,
		            onExecutionUnregistered->fields._._.method);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v13 )
		    {
		      v5 = &v12;
		      ex = v13->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		    }
		    m_DebugData = (Dictionary_2_System_Object_System_Object_ *)v2->fields.m_DebugData;
		    if ( !m_DebugData )
		      sub_1800D8250(0LL, v5);
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::Clear(
		      m_DebugData,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Clear);
		  }
		}
		
	}
}
