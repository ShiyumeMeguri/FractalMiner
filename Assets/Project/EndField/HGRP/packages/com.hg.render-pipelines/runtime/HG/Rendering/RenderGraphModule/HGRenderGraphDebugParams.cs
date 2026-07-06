using System;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphDebugParams
	{
		public HGRenderGraphDebugParams()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null)
		{
			// // Void RegisterDebug(String, DebugUI+Panel)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::RegisterDebug(
			//         HGRenderGraphDebugParams *this,
			//         String *name,
			//         DebugUI_Panel *debugPanel,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v7; // rax
			//   __int64 v8; // rdx
			//   ObservableList_1_System_Object_ *v9; // rcx
			//   List_1_System_Object_ *v10; // r13
			//   DebugUI_Container *v11; // rax
			//   DebugUI_Container *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   DebugUI_BoolField *v16; // rax
			//   DebugUI_BoolField *v17; // rsi
			//   Func_1_Boolean_ *v18; // rax
			//   Func_1_Boolean_ *v19; // r15
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   Action_1_Boolean_ *v23; // rax
			//   Action_1_Boolean_ *v24; // r15
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   DebugUI_BoolField *v28; // rax
			//   DebugUI_BoolField *v29; // rsi
			//   Func_1_Boolean_ *v30; // rax
			//   Func_1_Boolean_ *v31; // r15
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   Action_1_Boolean_ *v35; // rax
			//   Action_1_Boolean_ *v36; // r15
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   DebugUI_BoolField *v40; // rax
			//   DebugUI_BoolField *v41; // rsi
			//   Func_1_Boolean_ *v42; // rax
			//   Func_1_Boolean_ *v43; // r15
			//   OneofDescriptorProto *v44; // rdx
			//   FileDescriptor *v45; // r8
			//   MessageDescriptor *v46; // r9
			//   Action_1_Boolean_ *v47; // rax
			//   Action_1_Boolean_ *v48; // r15
			//   OneofDescriptorProto *v49; // rdx
			//   FileDescriptor *v50; // r8
			//   MessageDescriptor *v51; // r9
			//   DebugUI_BoolField *v52; // rax
			//   DebugUI_BoolField *v53; // rsi
			//   Func_1_Boolean_ *v54; // rax
			//   Func_1_Boolean_ *v55; // r15
			//   OneofDescriptorProto *v56; // rdx
			//   FileDescriptor *v57; // r8
			//   MessageDescriptor *v58; // r9
			//   Action_1_Boolean_ *v59; // rax
			//   Action_1_Boolean_ *v60; // r15
			//   OneofDescriptorProto *v61; // rdx
			//   FileDescriptor *v62; // r8
			//   MessageDescriptor *v63; // r9
			//   DebugUI_Widget *v64; // rax
			//   DebugUI_Widget *v65; // rsi
			//   Action *v66; // rax
			//   Action *v67; // r15
			//   OneofDescriptorProto *v68; // rdx
			//   FileDescriptor *v69; // r8
			//   MessageDescriptor *v70; // r9
			//   DebugUI_Widget *v71; // rax
			//   DebugUI_Widget *v72; // rsi
			//   Action *v73; // rax
			//   Action *v74; // r15
			//   OneofDescriptorProto *v75; // rdx
			//   FileDescriptor *v76; // r8
			//   MessageDescriptor *v77; // r9
			//   OneofDescriptorProto *v78; // rdx
			//   FileDescriptor *v79; // r8
			//   MessageDescriptor *v80; // r9
			//   OneofDescriptorProto *v81; // rdx
			//   FileDescriptor *v82; // r8
			//   MessageDescriptor *v83; // r9
			//   DebugManager *instance; // rax
			//   DebugUI_Panel *m_DebugPanel; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *overrideIfExist; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExista; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistb; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistc; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistd; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExiste; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistf; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistg; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExisth; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExisti; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistj; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistk; // [rsp+20h] [rbp-30h]
			//   String__Array *overrideIfExistl; // [rsp+20h] [rbp-30h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-28h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-28h]
			//   MethodInfo *v113; // [rsp+30h] [rbp-20h]
			//   MethodInfo *children_k__BackingField; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v115; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v116; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v117; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v118; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v119; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v120; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v121; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v122; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v123; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v124; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v125; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v126; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v127; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v128; // [rsp+30h] [rbp-20h]
			//   ObservableList_1_System_Object_ *v129; // [rsp+30h] [rbp-20h]
			//   MethodInfo *v130; // [rsp+30h] [rbp-20h]
			//   DebugUI_Widget_NameAndTooltip ClearRenderTargetsAtCreation; // [rsp+40h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919317 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<bool>);
			//     sub_18003C530(&TypeInfo::System::Action);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::Button);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugUI::Container);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DebugManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<bool>::set_getter);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DebugUI::Field<bool>::set_setter);
			//     sub_18003C530(&TypeInfo::System::Func<bool>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_3);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_4);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_5);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_6);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_7);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_8);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_9);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings);
			//     sub_18003C530(&off_18D5843F0);
			//     sub_18003C530(&off_18D584408);
			//     byte_18D919317 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(109, 0LL) )
			//   {
			//     v7 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
			//     v10 = (List_1_System_Object_ *)v7;
			//     if ( !v7 )
			//       goto LABEL_38;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v7,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
			//     v11 = (DebugUI_Container *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::Container);
			//     v12 = v11;
			//     if ( !v11 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::DebugUI::Container::Container(v11, 0LL);
			//     v12.fields._._displayName_k__BackingField = System::String::Concat(name, (String *)" Render Graph", 0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v12.fields._._displayName_k__BackingField,
			//       v13,
			//       v14,
			//       v15,
			//       overrideIfExist,
			//       (String *)methoda,
			//       v113);
			//     children_k__BackingField = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v16 = (DebugUI_BoolField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
			//     v17 = v16;
			//     if ( !v16 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::DebugUI::BoolField::BoolField(v16, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings);
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.ClearRenderTargetsAtCreation;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
			//       (DebugUI_Widget *)v17,
			//       &ClearRenderTargetsAtCreation,
			//       0LL);
			//     v18 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//     v19 = v18;
			//     if ( !v18 )
			//       goto LABEL_38;
			//     System::Func<bool>::Func(
			//       v18,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_0,
			//       0LL);
			//     v17.fields._._getter_k__BackingField = v19;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v17.fields._._getter_k__BackingField,
			//       v20,
			//       v21,
			//       v22,
			//       overrideIfExista,
			//       (String *)methodb,
			//       children_k__BackingField);
			//     v23 = (Action_1_Boolean_ *)sub_180004920(TypeInfo::System::Action<bool>);
			//     v24 = v23;
			//     if ( !v23 )
			//       goto LABEL_38;
			//     System::Action<bool>::Action(
			//       v23,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_1,
			//       0LL);
			//     v17.fields._._setter_k__BackingField = v24;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v17.fields._._setter_k__BackingField,
			//       v25,
			//       v26,
			//       v27,
			//       overrideIfExistb,
			//       (String *)methodc,
			//       v115);
			//     if ( !v116 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v116,
			//       (Object *)v17,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     v117 = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v28 = (DebugUI_BoolField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
			//     v29 = v28;
			//     if ( !v28 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::DebugUI::BoolField::BoolField(v28, 0LL);
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.DisablePassCulling;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
			//       (DebugUI_Widget *)v29,
			//       &ClearRenderTargetsAtCreation,
			//       0LL);
			//     v30 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//     v31 = v30;
			//     if ( !v30 )
			//       goto LABEL_38;
			//     System::Func<bool>::Func(
			//       v30,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_2,
			//       0LL);
			//     v29.fields._._getter_k__BackingField = v31;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.fields._._getter_k__BackingField,
			//       v32,
			//       v33,
			//       v34,
			//       overrideIfExistc,
			//       (String *)methodd,
			//       v117);
			//     v35 = (Action_1_Boolean_ *)sub_180004920(TypeInfo::System::Action<bool>);
			//     v36 = v35;
			//     if ( !v35 )
			//       goto LABEL_38;
			//     System::Action<bool>::Action(
			//       v35,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_3,
			//       0LL);
			//     v29.fields._._setter_k__BackingField = v36;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.fields._._setter_k__BackingField,
			//       v37,
			//       v38,
			//       v39,
			//       overrideIfExistd,
			//       (String *)methode,
			//       v118);
			//     if ( !v119 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v119,
			//       (Object *)v29,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     v120 = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v40 = (DebugUI_BoolField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
			//     v41 = v40;
			//     if ( !v40 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::DebugUI::BoolField::BoolField(v40, 0LL);
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.ImmediateMode;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
			//       (DebugUI_Widget *)v41,
			//       &ClearRenderTargetsAtCreation,
			//       0LL);
			//     v42 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//     v43 = v42;
			//     if ( !v42 )
			//       goto LABEL_38;
			//     System::Func<bool>::Func(
			//       v42,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_4,
			//       0LL);
			//     v41.fields._._getter_k__BackingField = v43;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v41.fields._._getter_k__BackingField,
			//       v44,
			//       v45,
			//       v46,
			//       overrideIfExiste,
			//       (String *)methodf,
			//       v120);
			//     v47 = (Action_1_Boolean_ *)sub_180004920(TypeInfo::System::Action<bool>);
			//     v48 = v47;
			//     if ( !v47 )
			//       goto LABEL_38;
			//     System::Action<bool>::Action(
			//       v47,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_5,
			//       0LL);
			//     v41.fields._._setter_k__BackingField = v48;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v41.fields._._setter_k__BackingField,
			//       v49,
			//       v50,
			//       v51,
			//       overrideIfExistf,
			//       (String *)methodg,
			//       v121);
			//     if ( !v122 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v122,
			//       (Object *)v41,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     v123 = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v52 = (DebugUI_BoolField *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::BoolField);
			//     v53 = v52;
			//     if ( !v52 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::DebugUI::BoolField::BoolField(v52, 0LL);
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.EnableLogging;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(
			//       (DebugUI_Widget *)v53,
			//       &ClearRenderTargetsAtCreation,
			//       0LL);
			//     v54 = (Func_1_Boolean_ *)sub_180004920(TypeInfo::System::Func<bool>);
			//     v55 = v54;
			//     if ( !v54 )
			//       goto LABEL_38;
			//     System::Func<bool>::Func(
			//       v54,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_6,
			//       0LL);
			//     v53.fields._._getter_k__BackingField = v55;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v53.fields._._getter_k__BackingField,
			//       v56,
			//       v57,
			//       v58,
			//       overrideIfExistg,
			//       (String *)methodh,
			//       v123);
			//     v59 = (Action_1_Boolean_ *)sub_180004920(TypeInfo::System::Action<bool>);
			//     v60 = v59;
			//     if ( !v59 )
			//       goto LABEL_38;
			//     System::Action<bool>::Action(
			//       v59,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_7,
			//       0LL);
			//     v53.fields._._setter_k__BackingField = v60;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v53.fields._._setter_k__BackingField,
			//       v61,
			//       v62,
			//       v63,
			//       overrideIfExisth,
			//       (String *)methodi,
			//       v124);
			//     if ( !v125 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v125,
			//       (Object *)v53,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     v126 = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v64 = (DebugUI_Widget *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::Button);
			//     v65 = v64;
			//     if ( !v64 )
			//       goto LABEL_38;
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.LogFrameInformation;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(v64, &ClearRenderTargetsAtCreation, 0LL);
			//     v66 = (Action *)sub_180004920(TypeInfo::System::Action);
			//     v67 = v66;
			//     if ( !v66 )
			//       goto LABEL_38;
			//     System::Action::Action(
			//       v66,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_8,
			//       0LL);
			//     v65[1].klass = (DebugUI_Widget__Class *)v67;
			//     sub_1800054D0((OneofDescriptor *)&v65[1], v68, v69, v70, overrideIfExisti, (String *)methodj, v126);
			//     if ( !v127 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v127,
			//       (Object *)v65,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     v128 = (MethodInfo *)v12.fields._children_k__BackingField;
			//     v71 = (DebugUI_Widget *)sub_180004920(TypeInfo::UnityEngine::Rendering::DebugUI::Button);
			//     v72 = v71;
			//     if ( !v71 )
			//       goto LABEL_38;
			//     ClearRenderTargetsAtCreation = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::Strings.static_fields.LogResources;
			//     UnityEngine::Rendering::DebugUI::Widget::set_nameAndTooltip(v71, &ClearRenderTargetsAtCreation, 0LL);
			//     v73 = (Action *)sub_180004920(TypeInfo::System::Action);
			//     v74 = v73;
			//     if ( !v73 )
			//       goto LABEL_38;
			//     System::Action::Action(
			//       v73,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::_RegisterDebug_b__10_9,
			//       0LL);
			//     v72[1].klass = (DebugUI_Widget__Class *)v74;
			//     sub_1800054D0((OneofDescriptor *)&v72[1], v75, v76, v77, overrideIfExistj, (String *)methodk, v128);
			//     if ( !v129 )
			//       goto LABEL_38;
			//     UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//       v129,
			//       (Object *)v72,
			//       MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//     sub_1822AD140(v10, (Object *)v12);
			//     this.fields.m_DebugItems = (DebugUI_Widget__Array *)System::Collections::Generic::List<System::Object>::ToArray(
			//                                                            v10,
			//                                                            MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields,
			//       v78,
			//       v79,
			//       v80,
			//       overrideIfExistk,
			//       (String *)methodl,
			//       (MethodInfo *)v129);
			//     if ( !debugPanel )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::DebugManager);
			//       instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
			//       if ( !name )
			//         goto LABEL_38;
			//       if ( !name.fields._stringLength )
			//         name = (String *)"Render Graph";
			//       if ( !instance )
			//         goto LABEL_38;
			//       debugPanel = UnityEngine::Rendering::DebugManager::GetPanel(instance, name, 1, 0, 0, 0LL);
			//     }
			//     this.fields.m_DebugPanel = debugPanel;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_DebugPanel,
			//       v81,
			//       v82,
			//       v83,
			//       overrideIfExistl,
			//       (String *)methodm,
			//       v130);
			//     m_DebugPanel = this.fields.m_DebugPanel;
			//     if ( m_DebugPanel )
			//     {
			//       v9 = (ObservableList_1_System_Object_ *)m_DebugPanel.fields._children_k__BackingField;
			//       if ( v9 )
			//       {
			//         UnityEngine::Rendering::ObservableList<System::Object>::Add(
			//           v9,
			//           (Object__Array *)this.fields.m_DebugItems,
			//           MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
			//         return;
			//       }
			//     }
			// LABEL_38:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(109, 0LL);
			//   if ( !Patch )
			//     goto LABEL_38;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)name,
			//     (Object *)debugPanel,
			//     0LL);
			// }
			// 
		}

		public void UnRegisterDebug(string name)
		{
		}

		private DebugUI.Widget[] m_DebugItems;

		private DebugUI.Panel m_DebugPanel;

		public bool clearRenderTargetsAtCreation;

		public bool clearRenderTargetsAtRelease;

		public bool disablePassCulling;

		public bool immediateMode;

		public bool enableLogging;

		public bool logFrameInformation;

		public bool logResources;

		private static class Strings
		{
			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
			public static readonly DebugUI.Widget.NameAndTooltip LogResources;
		}
	}
}
