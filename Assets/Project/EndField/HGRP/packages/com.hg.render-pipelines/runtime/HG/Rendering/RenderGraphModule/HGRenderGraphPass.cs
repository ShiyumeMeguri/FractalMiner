using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class HGRenderGraphPass // TypeDefIndex: 37442
	{
		// Fields
		protected const int MAX_RENDER_FUNC_COUNT = 4; // Metadata: 0x02302D6A
		public AttachDesc depthAttachment; // 0x30
		public DynamicArray<AttachDesc> colorAttachments; // 0x68
		public List<ResourceHandle>[] resourceReadLists; // 0x78
		public List<ResourceHandle>[] resourceWriteLists; // 0x80
		public List<ResourceHandle>[] transientResourceList; // 0x88
		public List<RendererListHandle> usedRendererListList; // 0x90
		public List<RendererListHandle> dependsOnRendererListList; // 0x98
		private List<HGRenderGraphPass> m_childPasses; // 0xA0
		private HGRenderGraphPass m_parentPass; // 0xA8
	
		// Properties
		public string name { get; protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		

		// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
		void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
		        SortedList_2_System_Object_System_Object_ *dictionary,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		  String *v5; // [rsp+30h] [rbp+30h]
		  Extension *v6; // [rsp+38h] [rbp+38h]
		  MethodInfo *v7; // [rsp+40h] [rbp+40h]
		
		  this->fields._dict = dictionary;
		  sub_18002D1B0(
		    (FieldDescriptor *)&this->fields,
		    (FieldDescriptorProto *)dictionary,
		    (FileDescriptor *)method,
		    v3,
		    v4,
		    v5,
		    v6,
		    v7);
		}
		
		public int index { get; protected set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		// LayerMask get_value()
		LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
		        VolumeParameter_1_UnityEngine_LayerMask_ *this,
		        MethodInfo *method)
		{
		  return (LayerMask)this->fields.m_Value.m_Mask;
		}
		

		// Void set_value(LayerMask)
		void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
		        VolumeParameter_1_UnityEngine_LayerMask_ *this,
		        LayerMask value,
		        MethodInfo *method)
		{
		  this->fields.m_Value = value;
		}
		
		public ProfilingSampler customSampler { get; protected set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		

		// Void set_getValueDelegate(Func`1[Single])
		void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        Func_1_Single_ *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		  String *v5; // [rsp+30h] [rbp+30h]
		  MethodInfo *v6; // [rsp+38h] [rbp+38h]
		
		  this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
		  sub_18002D1B0(
		    (OneofDescriptor *)&this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
		    (OneofDescriptorProto *)value,
		    (FileDescriptor *)method,
		    v3,
		    v4,
		    v5,
		    v6);
		}
		
		public ProfilingHGPass profilingHgPass { get; protected set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		// Int32 get_Count()
		int32_t TMPro::TMP_TextProcessingStack<TMPro::HighlightState>::get_Count(
		        TMP_TextProcessingStack_1_HighlightState_ *this,
		        MethodInfo *method)
		{
		  return this->m_RolloverSize;
		}
		

		// Void set_countAll(Int32)
		void TMPro::TMP_ObjectPool<System::Object>::set_countAll(
		        TMP_ObjectPool_1_System_Object_ *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._countAll_k__BackingField = value;
		}
		
		public bool enableAsyncCompute { get; protected set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
		// Boolean get_Rotate()
		bool CW::Common::CwFollow::get_Rotate(CwFollow *this, MethodInfo *method)
		{
		  return this->fields.rotate;
		}
		

		// Void set_Rotate(Boolean)
		void CW::Common::CwFollow::set_Rotate(CwFollow *this, bool value, MethodInfo *method)
		{
		  this->fields.rotate = value;
		}
		
		public bool allowPassCulling { get; protected set; } // 0x0000000184D86CB0-0x0000000184D86CC0 0x0000000184D86CE0-0x0000000184D86CF0
		// Boolean get_IgnoreZ()
		bool CW::Common::CwFollow::get_IgnoreZ(CwFollow *this, MethodInfo *method)
		{
		  return this->fields.ignoreZ;
		}
		

		// Void set_IgnoreZ(Boolean)
		void CW::Common::CwFollow::set_IgnoreZ(CwFollow *this, bool value, MethodInfo *method)
		{
		  this->fields.ignoreZ = value;
		}
		
		public int refCount { get; protected set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
		// P3dPaintableTexture+FilterType get_Filter()
		P3dPaintableTexture_FilterType__Enum PaintIn3D::P3dPaintableTexture::get_Filter(
		        P3dPaintableTexture *this,
		        MethodInfo *method)
		{
		  return this->fields.filter;
		}
		

		// Void set_Filter(P3dPaintableTexture+FilterType)
		void PaintIn3D::P3dPaintableTexture::set_Filter(
		        P3dPaintableTexture *this,
		        P3dPaintableTexture_FilterType__Enum value,
		        MethodInfo *method)
		{
		  this->fields.filter = value;
		}
		
		public bool generateDebugData { get; protected set; } // 0x000000018157A7D0-0x000000018157A7E0 0x000000018157A810-0x000000018157A820
		// Boolean get_DiscardUnknownFields()
		bool Google::Protobuf::ParserInternalState::get_DiscardUnknownFields(ParserInternalState *this, MethodInfo *method)
		{
		  return this->_DiscardUnknownFields_k__BackingField;
		}
		

		// Void DblClickSnap(TextEditor+DblClickSnapping)
		void UnityEngine::TextEditor::DblClickSnap(
		        TextEditor *this,
		        TextEditor_DblClickSnapping__Enum snapping,
		        MethodInfo *method)
		{
		  this->fields.m_DblClickSnap = snapping;
		}
		
		public bool allowRendererListCulling { get; protected set; } // 0x000000018157A7E0-0x000000018157A7F0 0x000000018157A820-0x000000018157A830
		// Boolean get_IsNotationDeclared()
		bool System::Xml::Schema::SchemaElementDecl::get_IsNotationDeclared(SchemaElementDecl *this, MethodInfo *method)
		{
		  return this->fields.isNotationDeclared;
		}
		

		// Void set_IsNotationDeclared(Boolean)
		void System::Xml::Schema::SchemaElementDecl::set_IsNotationDeclared(
		        SchemaElementDecl *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields.isNotationDeclared = value;
		}
		
	
		// Constructors
		public HGRenderGraphPass() {} // 0x0000000189B384EC-0x0000000189B38764
		// HGRenderGraphPass()
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::HGRenderGraphPass(
		        HGRenderGraphPass *this,
		        MethodInfo *method)
		{
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v19; // rax
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *v20; // rdi
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v24; // rax
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *v25; // rdi
		  Type *v26; // rdx
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v29; // rax
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *v30; // rdi
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  int i; // edi
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceReadLists; // rbp
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v36; // rax
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v37; // rsi
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceWriteLists; // rbp
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v39; // rax
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v40; // rsi
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *transientResourceList; // rbp
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v42; // rax
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v43; // rsi
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+20h] [rbp-8h]
		  MethodInfo *v48; // [rsp+20h] [rbp-8h]
		  MethodInfo *v49; // [rsp+20h] [rbp-8h]
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		
		  v3 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>);
		  v6 = (DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *)v3;
		  if ( !v3 )
		    goto LABEL_14;
		  UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::DynamicArray(
		    v3,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::DynamicArray);
		  this->fields.colorAttachments = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.colorAttachments, v7, v8, v9, v44);
		  this->fields.resourceReadLists = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)il2cpp_array_new_specific_1(
		                                                                                                     TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>,
		                                                                                                     2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resourceReadLists, v10, v11, v12, v45);
		  this->fields.resourceWriteLists = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resourceWriteLists, v13, v14, v15, v46);
		  this->fields.transientResourceList = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.transientResourceList, v16, v17, v18, v47);
		  v19 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>);
		  v20 = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)v19;
		  if ( !v19 )
		    goto LABEL_14;
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v19,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::List);
		  this->fields.usedRendererListList = v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.usedRendererListList, v21, v22, v23, v48);
		  v24 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>);
		  v25 = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)v24;
		  if ( !v24
		    || (System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		          v24,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::List),
		        this->fields.dependsOnRendererListList = v25,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.dependsOnRendererListList, v26, v27, v28, v49),
		        v29 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>),
		        (v30 = (List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *)v29) == 0LL) )
		  {
		LABEL_14:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v29,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::List);
		  this->fields.m_childPasses = v30;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_childPasses, v31, v32, v33, v50);
		  for ( i = 0; i < 2; ++i )
		  {
		    resourceReadLists = this->fields.resourceReadLists;
		    v36 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>);
		    v37 = v36;
		    if ( !v36 )
		      goto LABEL_14;
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		      v36,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::List);
		    if ( !resourceReadLists )
		      goto LABEL_14;
		    sub_180031B10(resourceReadLists, v37);
		    sub_180378FEC(resourceReadLists, i, v37);
		    resourceWriteLists = this->fields.resourceWriteLists;
		    v39 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>);
		    v40 = v39;
		    if ( !v39 )
		      goto LABEL_14;
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		      v39,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::List);
		    if ( !resourceWriteLists )
		      goto LABEL_14;
		    sub_180031B10(resourceWriteLists, v40);
		    sub_180378FEC(resourceWriteLists, i, v40);
		    transientResourceList = this->fields.transientResourceList;
		    v42 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>);
		    v43 = v42;
		    if ( !v42 )
		      goto LABEL_14;
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		      v42,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::List);
		    if ( !transientResourceList )
		      goto LABEL_14;
		    sub_180031B10(transientResourceList, v43);
		    sub_180378FEC(transientResourceList, i, v43);
		  }
		}
		
	
		// Methods
		public abstract void ExecuteAsChildPass(HGRenderGraph renderGraph);
		public abstract void Release(HGRenderGraphObjectPool pool);
		public abstract bool HasRenderFunc();
		protected abstract void ExecuteInternal(HGRenderGraph renderGraph);
		public virtual void Clear() {} // 0x0000000189B37960-0x0000000189B37B18
		// Void Clear()
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::Clear(HGRenderGraphPass *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  int v9; // r9d
		  __int64 v10; // rdx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *resourceReadLists; // rcx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+50h] [rbp+28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(276, 0LL) )
		  {
		    this->fields._name_k__BackingField = (String *)"";
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v16);
		    this->fields._index_k__BackingField = -1;
		    this->fields._customSampler_k__BackingField = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields._customSampler_k__BackingField, v6, v7, v8, v17);
		    v9 = 0;
		    v10 = 1LL;
		    do
		    {
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.resourceReadLists;
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      if ( (unsigned int)v9 >= resourceReadLists->fields._size_k__BackingField )
		        goto LABEL_18;
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)*((_QWORD *)&resourceReadLists[1].klass + v9);
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      ++*(&resourceReadLists->fields._size_k__BackingField + 1);
		      resourceReadLists->fields._size_k__BackingField = 0;
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.resourceWriteLists;
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      if ( (unsigned int)v9 >= resourceReadLists->fields._size_k__BackingField )
		        goto LABEL_18;
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)*((_QWORD *)&resourceReadLists[1].klass + v9);
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      ++*(&resourceReadLists->fields._size_k__BackingField + 1);
		      resourceReadLists->fields._size_k__BackingField = 0;
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.transientResourceList;
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      if ( (unsigned int)v9 >= resourceReadLists->fields._size_k__BackingField )
		LABEL_18:
		        sub_1800D2AB0(resourceReadLists, 1LL);
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)*((_QWORD *)&resourceReadLists[1].klass + v9);
		      if ( !resourceReadLists )
		        goto LABEL_20;
		      ++*(&resourceReadLists->fields._size_k__BackingField + 1);
		      resourceReadLists->fields._size_k__BackingField = 0;
		      ++v9;
		    }
		    while ( v9 < 2 );
		    resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.usedRendererListList;
		    if ( resourceReadLists )
		    {
		      ++*(&resourceReadLists->fields._size_k__BackingField + 1);
		      resourceReadLists->fields._size_k__BackingField = 0;
		      resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.dependsOnRendererListList;
		      if ( resourceReadLists )
		      {
		        ++*(&resourceReadLists->fields._size_k__BackingField + 1);
		        resourceReadLists->fields._size_k__BackingField = 0;
		        this->fields._refCount_k__BackingField = 0;
		        resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.colorAttachments;
		        *(_WORD *)&this->fields._enableAsyncCompute_k__BackingField = 256;
		        *(_WORD *)&this->fields._generateDebugData_k__BackingField = 1;
		        if ( resourceReadLists )
		        {
		          UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		            resourceReadLists,
		            0,
		            0,
		            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::Resize);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::AttachDesc);
		          HG::Rendering::RenderGraphModule::AttachDesc::Reset(&this->fields.depthAttachment, 0LL);
		          resourceReadLists = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.m_childPasses;
		          if ( resourceReadLists )
		          {
		            sub_183127A90(
		              resourceReadLists,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Clear);
		            this->fields.m_parentPass = 0LL;
		            sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_parentPass, v12, v13, v14, v18);
		            return;
		          }
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(resourceReadLists, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(276, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void AddResourceWrite([IsReadOnly] in ResourceHandle res) {} // 0x0000000189B37760-0x0000000189B37808
		// Void AddResourceWrite(ResourceHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
		        HGRenderGraphPass *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceWriteLists; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(229, 0LL) )
		  {
		    resourceWriteLists = this->fields.resourceWriteLists;
		    v10 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
		    if ( resourceWriteLists )
		    {
		      if ( (unsigned int)iType >= resourceWriteLists->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)resourceWriteLists->vector[iType];
		      if ( v8 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		          v8,
		          (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)*res,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(229, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_23(Patch, (Object *)this, res, 0LL);
		}
		
		public void AddResourceRead([IsReadOnly] in ResourceHandle res) {} // 0x0000000189B376BC-0x0000000189B37760
		// Void AddResourceRead(ResourceHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
		        HGRenderGraphPass *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceReadLists; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(235, 0LL) )
		  {
		    resourceReadLists = this->fields.resourceReadLists;
		    v10 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
		    if ( resourceReadLists )
		    {
		      if ( (unsigned int)iType >= resourceReadLists->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)resourceReadLists->vector[iType];
		      if ( v8 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		          v8,
		          (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)*res,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(235, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_23(Patch, (Object *)this, res, 0LL);
		}
		
		public void AddTransientResource([IsReadOnly] in ResourceHandle res) {} // 0x0000000189B37808-0x0000000189B378B0
		// Void AddTransientResource(ResourceHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
		        HGRenderGraphPass *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *transientResourceList; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(249, 0LL) )
		  {
		    transientResourceList = this->fields.transientResourceList;
		    v10 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
		    if ( transientResourceList )
		    {
		      if ( (unsigned int)iType >= transientResourceList->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)transientResourceList->vector[iType];
		      if ( v8 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		          v8,
		          (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)*res,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(249, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_23(Patch, (Object *)this, res, 0LL);
		}
		
		public void UseRendererList(RendererListHandle rendererList) {} // 0x0000000189B3847C-0x0000000189B384EC
		// Void UseRendererList(RendererListHandle)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(
		        HGRenderGraphPass *this,
		        RendererListHandle rendererList,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *usedRendererListList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(252, 0LL) )
		  {
		    usedRendererListList = this->fields.usedRendererListList;
		    if ( usedRendererListList )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		        (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)usedRendererListList,
		        (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)rendererList,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(usedRendererListList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(252, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(Patch, (Object *)this, rendererList, 0LL);
		}
		
		public void DependsOnRendererList(RendererListHandle rendererList) {} // 0x0000000189B37B18-0x0000000189B37B88
		// Void DependsOnRendererList(RendererListHandle)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::DependsOnRendererList(
		        HGRenderGraphPass *this,
		        RendererListHandle rendererList,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(281, 0LL) )
		  {
		    dependsOnRendererListList = this->fields.dependsOnRendererListList;
		    if ( dependsOnRendererListList )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::Add(
		        (List_1_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ *)dependsOnRendererListList,
		        (CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent)rendererList,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(dependsOnRendererListList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(281, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_122(Patch, (Object *)this, rendererList, 0LL);
		}
		
		public void EnableAsyncCompute(bool value) {} // 0x0000000189B37B88-0x0000000189B37BE0
		// Void EnableAsyncCompute(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::EnableAsyncCompute(
		        HGRenderGraphPass *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(260, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(260, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._enableAsyncCompute_k__BackingField = value;
		  }
		}
		
		public void AllowPassCulling(bool value) {} // 0x0000000189B378B0-0x0000000189B37908
		// Void AllowPassCulling(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowPassCulling(
		        HGRenderGraphPass *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(202, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(202, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._allowPassCulling_k__BackingField = value;
		  }
		}
		
		public void AllowRendererListCulling(bool value) {} // 0x0000000189B37908-0x0000000189B37960
		// Void AllowRendererListCulling(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowRendererListCulling(
		        HGRenderGraphPass *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(263, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(263, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._allowRendererListCulling_k__BackingField = value;
		  }
		}
		
		public void GenerateDebugData(bool value) {} // 0x0000000189B37D8C-0x0000000189B37DE4
		// Void GenerateDebugData(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::GenerateDebugData(
		        HGRenderGraphPass *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(205, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(205, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._generateDebugData_k__BackingField = value;
		  }
		}
		
		[IDTag(2)]
		public void SetColorAttachment(TextureHandle attachment, int index, uint depthSlice) {} // 0x0000000189B37F44-0x0000000189B38004
		// Void SetColorAttachment(TextureHandle, Int32, UInt32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *attachment,
		        int32_t index,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  TileBase *v9; // rdx
		  Vector3Int *v10; // r8
		  ITilemap *v11; // r9
		  TileAnimationData v12; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  MethodInfo *v16; // [rsp+20h] [rbp-38h]
		  TileAnimationData v17; // [rsp+30h] [rbp-28h] BYREF
		  TextureHandle v18; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(226, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(226, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    v18 = *attachment;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_112(
		      Patch,
		      (Object *)this,
		      &v18,
		      (DepthAccess__Enum)index,
		      depthSlice,
		      0LL);
		  }
		  else
		  {
		    v12 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v18, v9, v10, v11, v16);
		    v18 = *attachment;
		    v17 = v12;
		    HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		      this,
		      &v18,
		      index,
		      (Color *)&v17,
		      depthSlice,
		      0LL);
		  }
		}
		
		[IDTag(1)]
		public void SetColorAttachment(TextureHandle attachment, int index, UnityEngine.Color clearColor, uint depthSlice) {} // 0x0000000189B37E5C-0x0000000189B37F44
		// Void SetColorAttachment(TextureHandle, Int32, Color, UInt32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *attachment,
		        int32_t index,
		        Color *clearColor,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  TextureHandle v10; // xmm1
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle v13; // xmm1
		  Color v14; // [rsp+50h] [rbp-28h] BYREF
		  TextureHandle v15; // [rsp+60h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(227, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(227, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v11);
		    v13 = *attachment;
		    v15 = (TextureHandle)*clearColor;
		    v14 = (Color)v13;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_106(
		      Patch,
		      (Object *)this,
		      (TextureHandle *)&v14,
		      index,
		      (Color *)&v15,
		      depthSlice,
		      0LL);
		  }
		  else
		  {
		    v10 = *attachment;
		    v14 = *clearColor;
		    v15 = v10;
		    HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		      this,
		      &v15,
		      index,
		      RenderBufferLoadAction__Enum_Load,
		      RenderBufferStoreAction__Enum_Store,
		      &v14,
		      depthSlice,
		      0,
		      0LL);
		  }
		}
		
		[IDTag(3)]
		public void SetColorAttachment(TextureHandle attachment, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, UnityEngine.Color clearColor, uint depthSlice) {} // 0x0000000189B38004-0x0000000189B38114
		// Void SetColorAttachment(TextureHandle, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *attachment,
		        int32_t index,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        Color *clearColor,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  TextureHandle v12; // xmm1
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle v15; // xmm1
		  Color v16; // [rsp+50h] [rbp-28h] BYREF
		  TextureHandle v17; // [rsp+60h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(232, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(232, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v13);
		    v15 = *attachment;
		    v17 = (TextureHandle)*clearColor;
		    v16 = (Color)v15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_110(
		      Patch,
		      (Object *)this,
		      (TextureHandle *)&v16,
		      index,
		      loadAction,
		      storeAction,
		      (Color *)&v17,
		      depthSlice,
		      0LL);
		  }
		  else
		  {
		    v12 = *attachment;
		    v16 = *clearColor;
		    v17 = v12;
		    HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		      this,
		      &v17,
		      index,
		      loadAction,
		      storeAction,
		      &v16,
		      depthSlice,
		      1,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		private void SetColorAttachment(TextureHandle attachment, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, UnityEngine.Color clearColor, uint depthSlice, bool manuallyOverride) {} // 0x0000000189B38114-0x0000000189B38288
		// Void SetColorAttachment(TextureHandle, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32, Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *attachment,
		        int32_t index,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        Color *clearColor,
		        uint32_t depthSlice,
		        bool manuallyOverride,
		        MethodInfo *method)
		{
		  __int64 v13; // rdx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *colorAttachments; // rcx
		  TextureHandle v15; // xmm6
		  Color v16; // xmm0
		  AttachDesc *Item; // rax
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  TextureHandle v20; // xmm1
		  Color v21; // [rsp+58h] [rbp-41h] BYREF
		  TextureHandle v22; // [rsp+68h] [rbp-31h] BYREF
		  __m256i v23; // [rsp+88h] [rbp-11h] BYREF
		  __int64 v24; // [rsp+A8h] [rbp+Fh]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(228, 0LL) )
		  {
		    colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.colorAttachments;
		    if ( colorAttachments )
		    {
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		        colorAttachments,
		        index + 1,
		        0,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::Resize);
		      colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.colorAttachments;
		      if ( colorAttachments )
		      {
		        v15 = *attachment;
		        v24 = 0LL;
		        memset(&v23.m256i_u64[1], 0, 24);
		        v23.m256i_i32[1] = storeAction;
		        v23.m256i_i32[0] = loadAction;
		        v16 = *clearColor;
		        v23.m256i_i64[3] = depthSlice | 0x3F80000000000000LL;
		        BYTE4(v24) = manuallyOverride;
		        *(Color *)&v23.m256i_u64[1] = v16;
		        Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
		                 (DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *)colorAttachments,
		                 index,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
		        v18 = *(_OWORD *)v23.m256i_i8;
		        v19 = *(_OWORD *)&v23.m256i_u64[2];
		        Item->textureHandle = v15;
		        *(_OWORD *)&Item->loadAction = v18;
		        *(_QWORD *)&v18 = v24;
		        *(_OWORD *)&Item->clearColor.b = v19;
		        *(_QWORD *)&Item->clearStencil = v18;
		        HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(this, &attachment->handle, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(colorAttachments, v13);
		  }
		  colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)IFix::WrappersManagerImpl::GetPatch(228, 0LL);
		  if ( !colorAttachments )
		    goto LABEL_6;
		  v20 = *attachment;
		  v21 = *clearColor;
		  v22 = v20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_105(
		    (ILFixDynamicMethodWrapper_2 *)colorAttachments,
		    (Object *)this,
		    &v22,
		    index,
		    loadAction,
		    storeAction,
		    &v21,
		    depthSlice,
		    manuallyOverride,
		    0LL);
		}
		
		[IDTag(0)]
		public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, uint depthSlice) {} // 0x0000000189B38288-0x0000000189B38374
		// Void SetDepthAttachment(TextureHandle, DepthAccess, UInt32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *depth,
		        DepthAccess__Enum depthAccess,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  __int64 v9; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  TextureHandle v13; // [rsp+30h] [rbp-58h] BYREF
		  __int128 v14; // [rsp+60h] [rbp-28h]
		  __int64 v15; // [rsp+70h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(234, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(234, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = *depth;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_112(Patch, (Object *)this, &v13, depthAccess, depthSlice, 0LL);
		  }
		  else
		  {
		    v15 = 0LL;
		    *(_OWORD *)&this->fields.depthAttachment.loadAction = 0LL;
		    v14 = 0LL;
		    DWORD2(v14) = depthSlice;
		    v9 = v15;
		    *(_OWORD *)&this->fields.depthAttachment.clearColor.b = v14;
		    *(_QWORD *)&this->fields.depthAttachment.clearStencil = v9;
		    this->fields.depthAttachment.textureHandle = *depth;
		    this->fields.depthAttachment.depthSlice = depthSlice;
		    if ( (depthAccess & 1) != 0 )
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(this, &depth->handle, 0LL);
		    if ( (depthAccess & 2) != 0 )
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(this, &depth->handle, 0LL);
		  }
		}
		
		[IDTag(1)]
		public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, uint depthSlice) {} // 0x0000000189B38374-0x0000000189B3847C
		// Void SetDepthAttachment(TextureHandle, DepthAccess, RenderBufferLoadAction, RenderBufferStoreAction, Single, Byte, UInt32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
		        HGRenderGraphPass *this,
		        TextureHandle *depth,
		        DepthAccess__Enum depthAccess,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        float clearDepth,
		        uint8_t clearStencil,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle v15; // [rsp+50h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(237, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v13);
		    v15 = *depth;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		      Patch,
		      (Object *)this,
		      &v15,
		      depthAccess,
		      loadAction,
		      storeAction,
		      clearDepth,
		      clearStencil,
		      depthSlice,
		      0LL);
		  }
		  else
		  {
		    v15 = *depth;
		    HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(this, &v15, depthAccess, depthSlice, 0LL);
		    this->fields.depthAttachment.storeAction = storeAction;
		    this->fields.depthAttachment.clearStencil = clearStencil;
		    this->fields.depthAttachment.clearDepth = clearDepth;
		    this->fields.depthAttachment.loadAction = loadAction;
		    this->fields.depthAttachment.manuallyOverride = 1;
		  }
		}
		
		internal abstract bool DepthRequiredIfMRT();
		protected bool NecessaryToIssueRenderPass() => default; // 0x0000000189B37DE4-0x0000000189B37E5C
		// Boolean NecessaryToIssueRenderPass()
		bool HG::Rendering::RenderGraphModule::HGRenderGraphPass::NecessaryToIssueRenderPass(
		        HGRenderGraphPass *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(282, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(282, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  colorAttachments = this->fields.colorAttachments;
		  if ( !colorAttachments )
		    goto LABEL_7;
		  if ( colorAttachments->fields._size_k__BackingField )
		    return 1;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  return HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.depthAttachment.textureHandle, 0LL);
		}
		
		public void Execute(HGRenderGraph renderGraph) {} // 0x0000000189B37D20-0x0000000189B37D8C
		// Void Execute(HGRenderGraph)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::Execute(
		        HGRenderGraphPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(83, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(83, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else if ( !this->fields.m_parentPass )
		  {
		    sub_1800DA430(7LL, this, renderGraph);
		  }
		}
		
		internal void AddChildPass(HGRenderGraphPass pass) {} // 0x0000000189B37634-0x0000000189B376BC
		// Void AddChildPass(HGRenderGraphPass)
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddChildPass(
		        HGRenderGraphPass *this,
		        HGRenderGraphPass *pass,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  List_1_System_Object_ *m_childPasses; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(258, 0LL) )
		  {
		    m_childPasses = (List_1_System_Object_ *)this->fields.m_childPasses;
		    if ( m_childPasses )
		    {
		      sub_182F01190(m_childPasses, (Object *)pass);
		      if ( pass )
		      {
		        pass->fields.m_parentPass = this;
		        sub_18002D1B0((SingleFieldAccessor *)&pass->fields.m_parentPass, v5, v7, v8, v10);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_childPasses, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(258, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)pass,
		    0LL);
		}
		
		protected void ExecuteChildPasses(HGRenderGraph renderGraph) {} // 0x0000000189B37BE0-0x0000000189B37D20
		// Void ExecuteChildPasses(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraphPass::ExecuteChildPasses(
		        HGRenderGraphPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_UInt64_ *m_childPasses; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *current; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v15; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v16; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(283, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(283, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    m_childPasses = (List_1_System_UInt64_ *)this->fields.m_childPasses;
		    if ( !m_childPasses )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v15,
		      m_childPasses,
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
		        if ( !v16._current )
		          sub_1800D8250(v9, v8);
		        sub_1800DA430(4LL, v16._current, renderGraph);
		        HG::Rendering::RenderGraphModule::HGRenderGraphPass::ExecuteChildPasses(
		          (HGRenderGraphPass *)current,
		          renderGraph,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v15._list = (List_1_System_Object_ *)v14->ex;
		      if ( v15._list )
		        sub_18007E1E0(v15._list);
		    }
		  }
		}
		
	}
}
