using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphDebugParams // TypeDefIndex: 37418
	{
		// Fields
		private DebugUI.Widget[] m_DebugItems; // 0x10
		private DebugUI.Panel m_DebugPanel; // 0x18
		public bool clearRenderTargetsAtCreation; // 0x20
		public bool clearRenderTargetsAtRelease; // 0x21
		public bool disablePassCulling; // 0x22
		public bool immediateMode; // 0x23
		public bool enableLogging; // 0x24
		public bool logFrameInformation; // 0x25
		public bool logResources; // 0x26
	
		// Nested types
		private static class Strings // TypeDefIndex: 37417
		{
			// Fields
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation; // 0x00
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling; // 0x10
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode; // 0x20
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging; // 0x30
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation; // 0x40
			public static readonly DebugUI.Widget.NameAndTooltip LogResources; // 0x50
	
			// Constructors
			static Strings() {} // 0x0000000189B32BFC-0x0000000189B32E28
			// HGRenderGraphDebugParams+Strings()
			void HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  Int32__Array **v8; // r9
			  String *v9; // r10
			  Type *v10; // rdx
			  PropertyInfo_1 *v11; // r8
			  Int32__Array **v12; // r9
			  Type *v13; // rdx
			  PropertyInfo_1 *v14; // r8
			  Type *v15; // rdx
			  PropertyInfo_1 *v16; // r8
			  Int32__Array **v17; // r9
			  String *v18; // r10
			  Type *v19; // rdx
			  PropertyInfo_1 *v20; // r8
			  Int32__Array **v21; // r9
			  Type *v22; // rdx
			  PropertyInfo_1 *v23; // r8
			  Type *v24; // rdx
			  PropertyInfo_1 *v25; // r8
			  Int32__Array **v26; // r9
			  String *v27; // r10
			  Type *v28; // rdx
			  PropertyInfo_1 *v29; // r8
			  Int32__Array **v30; // r9
			  Type *v31; // rdx
			  PropertyInfo_1 *v32; // r8
			  Type *v33; // rdx
			  PropertyInfo_1 *v34; // r8
			  Int32__Array **v35; // r9
			  String *v36; // r10
			  Type *v37; // rdx
			  PropertyInfo_1 *v38; // r8
			  Int32__Array **v39; // r9
			  Type *v40; // rdx
			  PropertyInfo_1 *v41; // r8
			  Type *v42; // rdx
			  PropertyInfo_1 *v43; // r8
			  Int32__Array **v44; // r9
			  String *v45; // r10
			  Type *v46; // rdx
			  PropertyInfo_1 *v47; // r8
			  Int32__Array **v48; // r9
			  Type *v49; // rdx
			  PropertyInfo_1 *v50; // r8
			  Type *v51; // rdx
			  PropertyInfo_1 *v52; // r8
			  Int32__Array **v53; // r9
			  DebugUI_Widget_NameAndTooltip v54; // [rsp+20h] [rbp-10h] BYREF
			
			  v54.name = (String *)"Clear Render Targets At Creation";
			  v54.tooltip = 0LL;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v1,
			    v2,
			    v3);
			  v54.tooltip = (String *)"Enable to clear all render textures before any rendergraph passes to check if some clears are missing.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v4,
			    v5,
			    (Int32__Array **)"Enable to clear all render textures before any rendergraph passes to check if some clears are missing.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->ClearRenderTargetsAtCreation = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields,
			    v6,
			    v7,
			    v8,
			    (MethodInfo *)v54.name);
			  v54.name = (String *)"Disable Pass Culling";
			  v54.tooltip = v9;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v10,
			    v11,
			    v12);
			  v54.tooltip = (String *)"Enable to temporarily disable culling to asses if a pass is culled.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v13,
			    v14,
			    (Int32__Array **)"Enable to temporarily disable culling to asses if a pass is culled.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->DisablePassCulling = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->DisablePassCulling,
			    v15,
			    v16,
			    v17,
			    (MethodInfo *)v54.name);
			  v54.name = (String *)"Immediate Mode";
			  v54.tooltip = v18;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v19,
			    v20,
			    v21);
			  v54.tooltip = (String *)"Enable to force render graph to execute all passes in the order you registered them.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v22,
			    v23,
			    (Int32__Array **)"Enable to force render graph to execute all passes in the order you registered them.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->ImmediateMode = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->ImmediateMode,
			    v24,
			    v25,
			    v26,
			    (MethodInfo *)v54.name);
			  v54.name = (String *)"Enable Logging";
			  v54.tooltip = v27;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v28,
			    v29,
			    v30);
			  v54.tooltip = (String *)"Enable to allow HGRP to capture information in the log.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v31,
			    v32,
			    (Int32__Array **)"Enable to allow HGRP to capture information in the log.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->EnableLogging = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->EnableLogging,
			    v33,
			    v34,
			    v35,
			    (MethodInfo *)v54.name);
			  v54.name = (String *)"Log Frame Information";
			  v54.tooltip = v36;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v37,
			    v38,
			    v39);
			  v54.tooltip = (String *)"Enable to log information output from each frame.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v40,
			    v41,
			    (Int32__Array **)"Enable to log information output from each frame.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogFrameInformation = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogFrameInformation,
			    v42,
			    v43,
			    v44,
			    (MethodInfo *)v54.name);
			  v54.name = (String *)"Log Resources";
			  v54.tooltip = v45;
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)&v54,
			    v46,
			    v47,
			    v48);
			  v54.tooltip = (String *)"Enable to log the current render graph's global resource usage.";
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v54.tooltip,
			    v49,
			    v50,
			    (Int32__Array **)"Enable to log the current render graph's global resource usage.",
			    (MethodInfo *)v54.name);
			  TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogResources = v54;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogResources,
			    v51,
			    v52,
			    v53,
			    (MethodInfo *)v54.name);
			}
			
		}
	
		// Constructors
		public HGRenderGraphDebugParams() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	
		// Methods
		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null) {} // 0x0000000189B28940-0x0000000189B28F84
		// Void RegisterDebug(String, DebugUI+Panel)
		void HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::RegisterDebug(
		        HGRenderGraphDebugParams *this,
		        String *name,
		        DebugUI_Panel *debugPanel,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v7; // rax
		  __int64 v8; // rdx
		  ObservableList_1_System_Object_ *v9; // rcx
		  DebugUI_Container *v10; // rax
		  DebugUI_Container *v11; // r14
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  ObservableList_1_System_Object_ *children_k__BackingField; // r12
		  DebugUI_BoolField *v16; // rax
		  DebugUI_BoolField *v17; // rdi
		  Func_1_Boolean_ *v18; // rax
		  Func_1_Boolean_ *v19; // r15
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Action_1_Boolean_ *v23; // rax
		  Action_1_Boolean_ *v24; // r15
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  ObservableList_1_System_Object_ *v28; // r12
		  DebugUI_BoolField *v29; // rax
		  DebugUI_BoolField *v30; // rdi
		  Func_1_Boolean_ *v31; // rax
		  Func_1_Boolean_ *v32; // r15
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Action_1_Boolean_ *v36; // rax
		  Action_1_Boolean_ *v37; // r15
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  ObservableList_1_System_Object_ *v41; // r12
		  DebugUI_BoolField *v42; // rax
		  DebugUI_BoolField *v43; // rdi
		  Func_1_Boolean_ *v44; // rax
		  Func_1_Boolean_ *v45; // r15
		  Type *v46; // rdx
		  PropertyInfo_1 *v47; // r8
		  Int32__Array **v48; // r9
		  Action_1_Boolean_ *v49; // rax
		  Action_1_Boolean_ *v50; // r15
		  Type *v51; // rdx
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  ObservableList_1_System_Object_ *v54; // r12
		  DebugUI_BoolField *v55; // rax
		  DebugUI_BoolField *v56; // rdi
		  Func_1_Boolean_ *v57; // rax
		  Func_1_Boolean_ *v58; // r15
		  Type *v59; // rdx
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **v61; // r9
		  Action_1_Boolean_ *v62; // rax
		  Action_1_Boolean_ *v63; // r15
		  Type *v64; // rdx
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  ObservableList_1_System_Object_ *v67; // r12
		  DebugUI_Widget *v68; // rax
		  DebugUI_Widget *v69; // rdi
		  Action *v70; // rax
		  Action *v71; // r15
		  Type *v72; // rdx
		  PropertyInfo_1 *v73; // r8
		  Int32__Array **v74; // r9
		  ObservableList_1_System_Object_ *v75; // r12
		  DebugUI_Widget *v76; // rax
		  DebugUI_Widget *v77; // rdi
		  Action *v78; // rax
		  Action *v79; // r15
		  Type *v80; // rdx
		  PropertyInfo_1 *v81; // r8
		  Int32__Array **v82; // r9
		  Type *v83; // rdx
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **v85; // r9
		  Type *v86; // rdx
		  PropertyInfo_1 *v87; // r8
		  Int32__Array **v88; // r9
		  DebugManager *instance; // rax
		  DebugUI_Panel *m_DebugPanel; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *overrideIfExist; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExista; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistb; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistc; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistd; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExiste; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistf; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistg; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExisth; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExisti; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistj; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistk; // [rsp+20h] [rbp-30h]
		  MethodInfo *overrideIfExistl; // [rsp+20h] [rbp-30h]
		  List_1_System_Object_ *v105; // [rsp+30h] [rbp-20h]
		  DebugUI_Widget_NameAndTooltip ClearRenderTargetsAtCreation; // [rsp+40h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(108, 0LL) )
		  {
		    v7 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
		    v105 = (List_1_System_Object_ *)v7;
		    if ( !v7 )
		      goto LABEL_36;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v7,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
		    v10 = (DebugUI_Container *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::Container);
		    v11 = v10;
		    if ( !v10 )
		      goto LABEL_36;
		    UnityEngine::Rendering::DebugUI::Container::Container(v10, 0LL);
		    v11->fields._._displayName_k__BackingField = System::String::Concat(name, (String *)" Render Graph", 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&v11->fields._._displayName_k__BackingField, v12, v13, v14, overrideIfExist);
		    children_k__BackingField = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v16 = (DebugUI_BoolField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
		    v17 = v16;
		    if ( !v16 )
		      goto LABEL_36;
		    UnityEngine::Rendering::DebugUI::BoolField::BoolField(v16, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings);
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->ClearRenderTargetsAtCreation;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
		      (DebugUI_Widget *)v17,
		      &ClearRenderTargetsAtCreation,
		      0LL);
		    v18 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		    v19 = v18;
		    if ( !v18 )
		      goto LABEL_36;
		    System::Func<bool>::Func(
		      v18,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_0,
		      0LL);
		    v17->fields._._getter_k__BackingField = v19;
		    sub_18002D1B0((SingleFieldAccessor *)&v17->fields._._getter_k__BackingField, v20, v21, v22, overrideIfExista);
		    v23 = (Action_1_Boolean_ *)sub_18002C620(TypeInfo::System::Action<bool>);
		    v24 = v23;
		    if ( !v23 )
		      goto LABEL_36;
		    System::Action<bool>::Action(
		      v23,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_1,
		      0LL);
		    v17->fields._._setter_k__BackingField = v24;
		    sub_18002D1B0((SingleFieldAccessor *)&v17->fields._._setter_k__BackingField, v25, v26, v27, overrideIfExistb);
		    if ( !children_k__BackingField )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      children_k__BackingField,
		      (Object *)v17,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    v28 = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v29 = (DebugUI_BoolField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
		    v30 = v29;
		    if ( !v29 )
		      goto LABEL_36;
		    UnityEngine::Rendering::DebugUI::BoolField::BoolField(v29, 0LL);
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->DisablePassCulling;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
		      (DebugUI_Widget *)v30,
		      &ClearRenderTargetsAtCreation,
		      0LL);
		    v31 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		    v32 = v31;
		    if ( !v31 )
		      goto LABEL_36;
		    System::Func<bool>::Func(
		      v31,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_2,
		      0LL);
		    v30->fields._._getter_k__BackingField = v32;
		    sub_18002D1B0((SingleFieldAccessor *)&v30->fields._._getter_k__BackingField, v33, v34, v35, overrideIfExistc);
		    v36 = (Action_1_Boolean_ *)sub_18002C620(TypeInfo::System::Action<bool>);
		    v37 = v36;
		    if ( !v36 )
		      goto LABEL_36;
		    System::Action<bool>::Action(
		      v36,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_3,
		      0LL);
		    v30->fields._._setter_k__BackingField = v37;
		    sub_18002D1B0((SingleFieldAccessor *)&v30->fields._._setter_k__BackingField, v38, v39, v40, overrideIfExistd);
		    if ( !v28 )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      v28,
		      (Object *)v30,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    v41 = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v42 = (DebugUI_BoolField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
		    v43 = v42;
		    if ( !v42 )
		      goto LABEL_36;
		    UnityEngine::Rendering::DebugUI::BoolField::BoolField(v42, 0LL);
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->ImmediateMode;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
		      (DebugUI_Widget *)v43,
		      &ClearRenderTargetsAtCreation,
		      0LL);
		    v44 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		    v45 = v44;
		    if ( !v44 )
		      goto LABEL_36;
		    System::Func<bool>::Func(
		      v44,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_4,
		      0LL);
		    v43->fields._._getter_k__BackingField = v45;
		    sub_18002D1B0((SingleFieldAccessor *)&v43->fields._._getter_k__BackingField, v46, v47, v48, overrideIfExiste);
		    v49 = (Action_1_Boolean_ *)sub_18002C620(TypeInfo::System::Action<bool>);
		    v50 = v49;
		    if ( !v49 )
		      goto LABEL_36;
		    System::Action<bool>::Action(
		      v49,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_5,
		      0LL);
		    v43->fields._._setter_k__BackingField = v50;
		    sub_18002D1B0((SingleFieldAccessor *)&v43->fields._._setter_k__BackingField, v51, v52, v53, overrideIfExistf);
		    if ( !v41 )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      v41,
		      (Object *)v43,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    v54 = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v55 = (DebugUI_BoolField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
		    v56 = v55;
		    if ( !v55 )
		      goto LABEL_36;
		    UnityEngine::Rendering::DebugUI::BoolField::BoolField(v55, 0LL);
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->EnableLogging;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
		      (DebugUI_Widget *)v56,
		      &ClearRenderTargetsAtCreation,
		      0LL);
		    v57 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		    v58 = v57;
		    if ( !v57 )
		      goto LABEL_36;
		    System::Func<bool>::Func(
		      v57,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_6,
		      0LL);
		    v56->fields._._getter_k__BackingField = v58;
		    sub_18002D1B0((SingleFieldAccessor *)&v56->fields._._getter_k__BackingField, v59, v60, v61, overrideIfExistg);
		    v62 = (Action_1_Boolean_ *)sub_18002C620(TypeInfo::System::Action<bool>);
		    v63 = v62;
		    if ( !v62 )
		      goto LABEL_36;
		    System::Action<bool>::Action(
		      v62,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_7,
		      0LL);
		    v56->fields._._setter_k__BackingField = v63;
		    sub_18002D1B0((SingleFieldAccessor *)&v56->fields._._setter_k__BackingField, v64, v65, v66, overrideIfExisth);
		    if ( !v54 )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      v54,
		      (Object *)v56,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    v67 = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v68 = (DebugUI_Widget *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::Button);
		    v69 = v68;
		    if ( !v68 )
		      goto LABEL_36;
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogFrameInformation;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(v68, &ClearRenderTargetsAtCreation, 0LL);
		    v70 = (Action *)sub_18002C620(TypeInfo::System::Action);
		    v71 = v70;
		    if ( !v70 )
		      goto LABEL_36;
		    System::Action::Action(
		      v70,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_8,
		      0LL);
		    v69[1].klass = (DebugUI_Widget__Class *)v71;
		    sub_18002D1B0((SingleFieldAccessor *)&v69[1], v72, v73, v74, overrideIfExisti);
		    if ( !v67 )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      v67,
		      (Object *)v69,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    v75 = (ObservableList_1_System_Object_ *)v11->fields._children_k__BackingField;
		    v76 = (DebugUI_Widget *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::Button);
		    v77 = v76;
		    if ( !v76 )
		      goto LABEL_36;
		    ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings->static_fields->LogResources;
		    UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(v76, &ClearRenderTargetsAtCreation, 0LL);
		    v78 = (Action *)sub_18002C620(TypeInfo::System::Action);
		    v79 = v78;
		    if ( !v78 )
		      goto LABEL_36;
		    System::Action::Action(
		      v78,
		      (Object *)this,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_9,
		      0LL);
		    v77[1].klass = (DebugUI_Widget__Class *)v79;
		    sub_18002D1B0((SingleFieldAccessor *)&v77[1], v80, v81, v82, overrideIfExistj);
		    if ( !v75 )
		      goto LABEL_36;
		    UnityEngine::Rendering::ObservableList<System::Object>::Add(
		      v75,
		      (Object *)v77,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		    sub_182F01190(v105, (Object *)v11);
		    this->fields.m_DebugItems = (DebugUI_Widget__Array *)System::Collections::Generic::List<System::Object>::ToArray(
		                                                           v105,
		                                                           MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields, v83, v84, v85, overrideIfExistk);
		    if ( !debugPanel )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::DebugManager);
		      instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		      if ( !name )
		        goto LABEL_36;
		      if ( !name->fields._stringLength )
		        name = (String *)"Render Graph";
		      if ( !instance )
		        goto LABEL_36;
		      debugPanel = UnityEngine::Rendering::DebugManager::GetPanel(instance, name, 1, 0, 0, 0LL);
		    }
		    this->fields.m_DebugPanel = debugPanel;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DebugPanel, v86, v87, v88, overrideIfExistl);
		    m_DebugPanel = this->fields.m_DebugPanel;
		    if ( m_DebugPanel )
		    {
		      v9 = (ObservableList_1_System_Object_ *)m_DebugPanel->fields._children_k__BackingField;
		      if ( v9 )
		      {
		        UnityEngine::Rendering::ObservableList<System::Object>::Add(
		          v9,
		          (Object__Array *)this->fields.m_DebugItems,
		          MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		        return;
		      }
		    }
		LABEL_36:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(108, 0LL);
		  if ( !Patch )
		    goto LABEL_36;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)name,
		    (Object *)debugPanel,
		    0LL);
		}
		
		public void UnRegisterDebug(string name) {} // 0x0000000189B28F84-0x0000000189B29014
		// Void UnRegisterDebug(String)
		void HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::UnRegisterDebug(
		        HGRenderGraphDebugParams *this,
		        String *name,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ObservableList_1_System_Object_ *children_k__BackingField; // rcx
		  DebugUI_Panel *m_DebugPanel; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(119, 0LL) )
		  {
		    m_DebugPanel = this->fields.m_DebugPanel;
		    if ( m_DebugPanel )
		    {
		      children_k__BackingField = (ObservableList_1_System_Object_ *)m_DebugPanel->fields._children_k__BackingField;
		      if ( children_k__BackingField )
		      {
		        UnityEngine::Rendering::ObservableList<System::Object>::Remove(
		          children_k__BackingField,
		          (Object__Array *)this->fields.m_DebugItems,
		          MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Remove);
		        this->fields.m_DebugPanel = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DebugPanel, v8, v9, v10, v15);
		        this->fields.m_DebugItems = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v11, v12, v13, v16);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(children_k__BackingField, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(119, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)name,
		    0LL);
		}
		
	}
}
