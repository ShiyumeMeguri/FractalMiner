using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGInterationManager // TypeDefIndex: 37754
	{
		// Fields
		private const int MAX_BATCH_INSTANCE_NUM = 100; // Metadata: 0x02303094
		private List<IHGInteractionObject> objects; // 0x10
		private List<HGInteractionNode> nodes; // 0x18
		private List<HGInteractionNodeRenderData> renderDatas; // 0x20
		private HGDecalInteration decalInteraction; // 0x28
		private HGInteractionSettingAsset settingAsset; // 0x30
	
		// Constructors
		public HGInterationManager() {} // 0x0000000182ED82F0-0x0000000182ED83D0
		// HGInterationManager()
		void HG::Rendering::Runtime::HGInterationManager::HGInterationManager(HGInterationManager *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_IHGInteractionObject_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v10; // rax
		  List_1_HG_Rendering_Runtime_HGInteractionNode_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v15; // rax
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  HGDecalInteration *v20; // rax
		  HGDecalInteration *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>);
		  v6 = (List_1_HG_Rendering_Runtime_IHGInteractionObject_ *)v3;
		  if ( !v3 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::List);
		  this->fields.objects = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v25);
		  v10 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>);
		  v11 = (List_1_HG_Rendering_Runtime_HGInteractionNode_ *)v10;
		  if ( !v10 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::List);
		  this->fields.nodes = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.nodes, v12, v13, v14, v26);
		  v15 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>);
		  v16 = (List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *)v15;
		  if ( !v15
		    || (System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		          v15,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::List),
		        this->fields.renderDatas = v16,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.renderDatas, v17, v18, v19, v27),
		        v20 = (HGDecalInteration *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGDecalInteration),
		        (v21 = v20) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::Runtime::HGDecalInteration::HGDecalInteration(v20, 0LL);
		  this->fields.decalInteraction = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.decalInteraction, v22, v23, v24, v28);
		}
		
	
		// Methods
		public void Release() {} // 0x0000000189D024D4-0x0000000189D0252C
		// Void Release()
		void HG::Rendering::Runtime::HGInterationManager::Release(HGInterationManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGDecalInteration *decalInteraction; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1822, 0LL) )
		  {
		    decalInteraction = this->fields.decalInteraction;
		    if ( decalInteraction )
		    {
		      HG::Rendering::Runtime::HGDecalInteration::Release(decalInteraction, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(decalInteraction, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1822, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources) {} // 0x0000000184A790A0-0x0000000184A79110
		// Void PrepareResources(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGInterationManager::PrepareResources(
		        HGInterationManager *this,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  HGDecalInteration *decalInteraction; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1823, 0LL) )
		  {
		    if ( defaultResources )
		    {
		      assets = defaultResources->fields.assets;
		      if ( assets )
		      {
		        this->fields.settingAsset = assets->fields.interactionSettingAsset;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.settingAsset, v5, v7, v8, v11);
		        decalInteraction = this->fields.decalInteraction;
		        if ( decalInteraction )
		        {
		          HG::Rendering::Runtime::HGDecalInteration::UpdateSettingAsset(
		            decalInteraction,
		            this->fields.settingAsset,
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(decalInteraction, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1823, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)defaultResources,
		    0LL);
		}
		
		public void Register(IHGInteractionObject obj) {} // 0x000000018435D9A0-0x000000018435DA10
		// Void Register(IHGInteractionObject)
		void HG::Rendering::Runtime::HGInterationManager::Register(
		        HGInterationManager *this,
		        IHGInteractionObject *obj,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *objects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1795, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1795, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)obj,
		        0LL);
		      return;
		    }
		    goto LABEL_8;
		  }
		  if ( !obj )
		    return;
		  objects = (List_1_System_Object_ *)this->fields.objects;
		  if ( !objects )
		    goto LABEL_8;
		  if ( System::Collections::Generic::List<System::Object>::Contains(
		         objects,
		         (Object *)obj,
		         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains) )
		  {
		    return;
		  }
		  objects = (List_1_System_Object_ *)this->fields.objects;
		  if ( !objects )
		LABEL_8:
		    sub_1800D8260(objects, v5);
		  sub_182F01190(objects, (Object *)obj);
		}
		
		public void Unregister(IHGInteractionObject obj) {} // 0x000000018435D730-0x000000018435D7A0
		// Void Unregister(IHGInteractionObject)
		void HG::Rendering::Runtime::HGInterationManager::Unregister(
		        HGInterationManager *this,
		        IHGInteractionObject *obj,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *objects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1797, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1797, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)obj,
		        0LL);
		      return;
		    }
		    goto LABEL_8;
		  }
		  if ( !obj )
		    return;
		  objects = (List_1_System_Object_ *)this->fields.objects;
		  if ( !objects )
		    goto LABEL_8;
		  if ( !System::Collections::Generic::List<System::Object>::Contains(
		          objects,
		          (Object *)obj,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains) )
		    return;
		  objects = (List_1_System_Object_ *)this->fields.objects;
		  if ( !objects )
		LABEL_8:
		    sub_1800D8260(objects, v5);
		  System::Collections::Generic::List<System::Object>::Remove(
		    objects,
		    (Object *)obj,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Remove);
		}
		
		public void PipelineUpdate() {} // 0x00000001831C84E0-0x00000001831C85C0
		// Void PipelineUpdate()
		void HG::Rendering::Runtime::HGInterationManager::PipelineUpdate(HGInterationManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  struct Object_1__Class *v5; // rcx
		  HGInteractionSettingAsset *settingAsset; // rbx
		  bool enableMobileInteraction; // al
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
		  if ( wrapperArray->max_length.size > 1824 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x720 )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[38].vtable.Finalize.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1824, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  v5 = TypeInfo::UnityEngine::Object;
		  settingAsset = this->fields.settingAsset;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( settingAsset )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( settingAsset->fields._._.m_CachedPtr )
		    {
		      HG::Rendering::Runtime::HGInterationManager::CollectInteractions(this, 0LL);
		      enableMobileInteraction = HG::Rendering::Runtime::HGDecalInteration::get_enableMobileInteraction(0LL);
		      HG::Rendering::Runtime::HGInterationManager::UpdateCppPipeline(this, enableMobileInteraction, 0LL);
		    }
		  }
		}
		
		private void UpdateCppPipeline(bool updateMobile) {} // 0x00000001831056B0-0x0000000183105DB0
		// Void UpdateCppPipeline(Boolean)
		void HG::Rendering::Runtime::HGInterationManager::UpdateCppPipeline(
		        HGInterationManager *this,
		        bool updateMobile,
		        MethodInfo *method)
		{
		  __int128 *mesh; // rcx
		  HGDecalInteration *decalInteraction; // rdx
		  HGDecalInteractionParametersV2 *v7; // rax
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  void (__fastcall *v11)(_OWORD *); // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes; // rax
		  struct MethodInfo *v15; // rsi
		  __int64 size; // rdi
		  Il2CppClass *klass; // rax
		  _QWORD *rgctxDataDummy; // rbx
		  __int64 v19; // rax
		  __int64 v20; // rcx
		  __int64 v21; // rax
		  unsigned int v22; // ebx
		  __int64 (__fastcall *v23)(__int64, _QWORD, __int64, _QWORD); // rax
		  __int64 v24; // rdx
		  __int64 v25; // r12
		  Il2CppClass *v26; // rax
		  Il2CppRGCTXData v27; // rcx
		  void (__fastcall *v28)(__int64, _QWORD, __int64); // rax
		  unsigned int v29; // ebx
		  __int64 i; // r15
		  List_1_HG_Rendering_Runtime_HGInteractionNode_ *v31; // rax
		  Object_1 *texture; // r8
		  Texture *v33; // rsi
		  Texture *v34; // rdi
		  bool v35; // zf
		  int32_t InstanceID; // eax
		  Mesh *v37; // rsi
		  Mesh *v38; // rdi
		  int32_t v39; // eax
		  HGInteractionNodeV2 *v40; // rax
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int128 v50; // xmm0
		  int32_t m_mesh; // eax
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  int32_t v62; // eax
		  unsigned int v63; // ebx
		  void (__fastcall *v64)(__int64, _QWORD, bool); // rax
		  __int64 v65; // rdx
		  Il2CppClass *v66; // rcx
		  void (__fastcall *v67)(__int64, __int64); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v69; // rax
		  __int64 v70; // rax
		  __int64 v71; // rax
		  ILFixDynamicMethodWrapper_2 *v72; // rax
		  __int64 v73; // rax
		  __int64 v74; // rax
		  HGInteractionNode v75; // [rsp+20h] [rbp-E0h] BYREF
		  _DWORD v76[2]; // [rsp+E0h] [rbp-20h] BYREF
		  __int128 v77; // [rsp+E8h] [rbp-18h]
		  __int128 v78; // [rsp+F8h] [rbp-8h]
		  __int128 v79; // [rsp+108h] [rbp+8h]
		  __int128 v80; // [rsp+118h] [rbp+18h]
		  Matrix4x4 prevLocalToWorldMatrix; // [rsp+128h] [rbp+28h]
		  float GroundHeight; // [rsp+168h] [rbp+68h]
		  bool bUseCCD; // [rsp+16Ch] [rbp+6Ch]
		  __int16 v84; // [rsp+16Dh] [rbp+6Dh]
		  char v85; // [rsp+16Fh] [rbp+6Fh]
		  __int128 v86; // [rsp+170h] [rbp+70h]
		  int32_t v87; // [rsp+180h] [rbp+80h]
		  Vector2 extent; // [rsp+184h] [rbp+84h]
		  float heightScale; // [rsp+18Ch] [rbp+8Ch]
		  int32_t v90; // [rsp+190h] [rbp+90h]
		  _OWORD v91[4]; // [rsp+1A0h] [rbp+A0h] BYREF
		  __int128 v92; // [rsp+1E0h] [rbp+E0h] BYREF
		  __int128 v93; // [rsp+1F0h] [rbp+F0h]
		  __int128 v94; // [rsp+200h] [rbp+100h]
		  __int128 v95; // [rsp+210h] [rbp+110h]
		  __int128 v96; // [rsp+220h] [rbp+120h]
		  __int128 v97; // [rsp+230h] [rbp+130h]
		  __int128 v98; // [rsp+240h] [rbp+140h]
		  __int128 v99; // [rsp+250h] [rbp+150h]
		  __int128 v100; // [rsp+260h] [rbp+160h]
		  __int128 v101; // [rsp+270h] [rbp+170h]
		  __int128 v102; // [rsp+280h] [rbp+180h]
		  int32_t v103; // [rsp+290h] [rbp+190h]
		  HGDecalInteractionParametersV2 v104; // [rsp+298h] [rbp+198h] BYREF
		  HGInteractionNodeV2 v105; // [rsp+2D8h] [rbp+1D8h] BYREF
		
		  sub_18033B9D0(&v75, 0LL, 192LL);
		  mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  decalInteraction = (HGDecalInteration *)**((_QWORD **)mesh + 23);
		  if ( !decalInteraction )
		    goto LABEL_59;
		  if ( SLODWORD(decalInteraction->fields.busyChains) <= 1826 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)mesh + 56) )
		  {
		    il2cpp_runtime_class_init_1(mesh);
		    mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  decalInteraction = (HGDecalInteration *)**((_QWORD **)mesh + 23);
		  if ( !decalInteraction )
		LABEL_59:
		    sub_1800D8260(mesh, decalInteraction);
		  if ( LODWORD(decalInteraction->fields.busyChains) <= 0x722 )
		LABEL_65:
		    sub_1800D2AB0(mesh, decalInteraction);
		  if ( decalInteraction[305].klass )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1826, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		        (ILFixDynamicMethodWrapper_18 *)Patch,
		        (Object *)this,
		        updateMobile,
		        0LL);
		      return;
		    }
		    goto LABEL_59;
		  }
		LABEL_5:
		  decalInteraction = this->fields.decalInteraction;
		  if ( !decalInteraction )
		    goto LABEL_59;
		  v7 = HG::Rendering::Runtime::HGDecalInteration::BuildNativeSettingParameters(&v104, decalInteraction, 0LL);
		  v8 = *(_OWORD *)&v7->m_decalNodeWidth;
		  v91[0] = *(_OWORD *)&v7->m_enableDecalInteraction;
		  v9 = *(_OWORD *)&v7->m_nodeDistanceThreshold;
		  v91[1] = v8;
		  v10 = *(_OWORD *)&v7->m_rotationThreshold;
		  v11 = (void (__fastcall *)(_OWORD *))qword_18F3708B8;
		  v91[2] = v9;
		  v91[3] = v10;
		  if ( !qword_18F3708B8 )
		  {
		    v11 = (void (__fastcall *)(_OWORD *))il2cpp_resolve_icall_1(
		                                           "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateSettingParameters_Inject"
		                                           "ed(UnityEngine.HyperGryph.HGDecalInteractionParametersV2&)");
		    if ( !v11 )
		    {
		      v69 = sub_1802EE1B8(
		              "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateSettingParameters_Injected(UnityEngine.HyperGryph.HGD"
		              "ecalInteractionParametersV2&)");
		      sub_18007E1B0(v69, 0LL);
		    }
		    qword_18F3708B8 = (__int64)v11;
		  }
		  v11(v91);
		  nodes = this->fields.nodes;
		  if ( !nodes )
		    sub_1800D8260(v13, v12);
		  v15 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray;
		  size = nodes->fields._size;
		  klass = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray->klass,
		      v12);
		  rgctxDataDummy = klass->rgctx_data->rgctxDataDummy;
		  v19 = rgctxDataDummy[4];
		  if ( (*(_BYTE *)(v19 + 312) & 1) == 0 )
		    sub_1800360B0(rgctxDataDummy[4], v12);
		  v20 = *(_QWORD *)(*(_QWORD *)(v19 + 192) + 16LL);
		  if ( !*(_QWORD *)(v20 + 56) )
		    sub_1800430B0(v20);
		  v21 = rgctxDataDummy[4];
		  if ( (*(_BYTE *)(v21 + 312) & 1) == 0 )
		    sub_1800360B0(rgctxDataDummy[4], v12);
		  v22 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::AlignOf<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::VATFSMAudioData>(*(MethodInfo **)(*(_QWORD *)(v21 + 192) + 40LL));
		  v23 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))qword_18F36EF08;
		  if ( !qword_18F36EF08 )
		  {
		    v23 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))il2cpp_resolve_icall_1(
		                                                                      "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::M"
		                                                                      "allocTracked(System.Int64,System.Int32,Unity.Colle"
		                                                                      "ctions.Allocator,System.Int32)");
		    if ( !v23 )
		    {
		      v70 = sub_1802EE1B8(
		              "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MallocTracked(System.Int64,System.Int32,Unity.Collections"
		              ".Allocator,System.Int32)");
		      sub_18007E1B0(v70, 0LL);
		    }
		    qword_18F36EF08 = (__int64)v23;
		  }
		  v25 = v23(180 * size, v22, 2LL, 0LL);
		  v26 = v15->klass;
		  if ( ((__int64)v26->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v15->klass, v24);
		  v27.rgctxDataDummy = v26->rgctx_data[2].rgctxDataDummy;
		  if ( !*((_QWORD *)v27.rgctxDataDummy + 7) )
		    ((void (__fastcall *)(_QWORD))sub_1800430B0)((Il2CppRGCTXData)v27.rgctxDataDummy);
		  v28 = (void (__fastcall *)(__int64, _QWORD, __int64))qword_18F36EF38;
		  if ( !qword_18F36EF38 )
		  {
		    v28 = (void (__fastcall *)(__int64, _QWORD, __int64))il2cpp_resolve_icall_1(
		                                                           "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(Syste"
		                                                           "m.Void*,System.Byte,System.Int64)");
		    if ( !v28 )
		    {
		      v71 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)");
		      sub_18007E1B0(v71, 0LL);
		    }
		    qword_18F36EF38 = (__int64)v28;
		  }
		  v28(v25, 0LL, 180 * size);
		  v29 = 0;
		  for ( i = v25; ; i += 180LL )
		  {
		    v31 = this->fields.nodes;
		    if ( !v31 )
		      goto LABEL_59;
		    if ( (signed int)v29 >= v31->fields._size )
		      break;
		    if ( v29 >= v31->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    decalInteraction = (HGDecalInteration *)v31->fields._items;
		    if ( !decalInteraction )
		      goto LABEL_59;
		    if ( v29 >= LODWORD(decalInteraction->fields.busyChains) )
		      goto LABEL_65;
		    v75 = *(HGInteractionNode *)&decalInteraction[4 * (int)v29].fields.pendingFreeChains;
		    mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    decalInteraction = (HGDecalInteration *)**((_QWORD **)mesh + 23);
		    if ( !decalInteraction )
		      goto LABEL_59;
		    if ( SLODWORD(decalInteraction->fields.busyChains) <= 1821 )
		      goto LABEL_32;
		    if ( !*((_DWORD *)mesh + 56) )
		    {
		      il2cpp_runtime_class_init_1(mesh);
		      mesh = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    mesh = (__int128 *)**((_QWORD **)mesh + 23);
		    if ( !mesh )
		      goto LABEL_59;
		    if ( *((_DWORD *)mesh + 6) <= 0x71Du )
		      goto LABEL_65;
		    if ( *((_QWORD *)mesh + 1825) )
		    {
		      v72 = IFix::WrappersManagerImpl::GetPatch(1821, 0LL);
		      if ( !v72 )
		        goto LABEL_59;
		      v40 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_735(&v105, v72, &v75, 0LL);
		    }
		    else
		    {
		LABEL_32:
		      texture = (Object_1 *)v75.texture;
		      v33 = v75.texture;
		      v77 = *(_OWORD *)&v75.localToWorldMatrix.m00;
		      v84 = 0;
		      v34 = v75.texture;
		      v35 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		      v78 = *(_OWORD *)&v75.localToWorldMatrix.m01;
		      v85 = 0;
		      v79 = *(_OWORD *)&v75.localToWorldMatrix.m02;
		      v76[0] = v75.NodeKey;
		      v80 = *(_OWORD *)&v75.localToWorldMatrix.m03;
		      v76[1] = v75.ProxyType;
		      prevLocalToWorldMatrix = v75.prevLocalToWorldMatrix;
		      bUseCCD = v75.bUseCCD;
		      GroundHeight = v75.GroundHeight;
		      v86 = *(_OWORD *)&v75.length;
		      if ( v35 )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        texture = (Object_1 *)v75.texture;
		      }
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        texture = (Object_1 *)v75.texture;
		      }
		      if ( !v34 )
		        goto LABEL_40;
		      mesh = (__int128 *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        texture = (Object_1 *)v75.texture;
		      }
		      if ( v33->fields._.m_CachedPtr )
		      {
		        if ( !texture )
		          goto LABEL_59;
		        InstanceID = UnityEngine::Object::GetInstanceID(texture, 0LL);
		      }
		      else
		      {
		LABEL_40:
		        InstanceID = 0;
		      }
		      mesh = (__int128 *)v75.mesh;
		      v37 = v75.mesh;
		      v87 = InstanceID;
		      v38 = v75.mesh;
		      extent = v75.extent;
		      v35 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		      heightScale = v75.heightScale;
		      if ( v35 )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        mesh = (__int128 *)v75.mesh;
		      }
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        mesh = (__int128 *)v75.mesh;
		      }
		      if ( !v38 )
		        goto LABEL_49;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        mesh = (__int128 *)v75.mesh;
		      }
		      if ( v37->fields._.m_CachedPtr )
		      {
		        if ( !mesh )
		          goto LABEL_59;
		        v39 = UnityEngine::Object::GetInstanceID((Object_1 *)mesh, 0LL);
		      }
		      else
		      {
		LABEL_49:
		        v39 = 0;
		      }
		      v90 = v39;
		      v40 = (HGInteractionNodeV2 *)v76;
		    }
		    mesh = &v92;
		    ++v29;
		    v41 = *(_OWORD *)&v40->m_localToWorldMatrix.m20;
		    v92 = *(_OWORD *)&v40->m_nodeKey;
		    v42 = *(_OWORD *)&v40->m_localToWorldMatrix.m21;
		    v93 = v41;
		    v43 = *(_OWORD *)&v40->m_localToWorldMatrix.m22;
		    v94 = v42;
		    v44 = *(_OWORD *)&v40->m_localToWorldMatrix.m23;
		    v95 = v43;
		    v45 = *(_OWORD *)&v40->m_prevLocalToWorldMatrix.m20;
		    v96 = v44;
		    v46 = *(_OWORD *)&v40->m_prevLocalToWorldMatrix.m21;
		    v97 = v45;
		    v47 = *(_OWORD *)&v40->m_prevLocalToWorldMatrix.m22;
		    v98 = v46;
		    v48 = *(_OWORD *)&v40->m_prevLocalToWorldMatrix.m23;
		    v99 = v47;
		    v49 = *(_OWORD *)&v40->m_length;
		    v100 = v48;
		    v50 = *(_OWORD *)&v40->m_texture;
		    m_mesh = v40->m_mesh;
		    v101 = v49;
		    v102 = v50;
		    v103 = m_mesh;
		    v52 = v93;
		    *(_OWORD *)i = v92;
		    v53 = v94;
		    *(_OWORD *)(i + 16) = v52;
		    v54 = v95;
		    *(_OWORD *)(i + 32) = v53;
		    v55 = v96;
		    *(_OWORD *)(i + 48) = v54;
		    v56 = v97;
		    *(_OWORD *)(i + 64) = v55;
		    v57 = v98;
		    *(_OWORD *)(i + 80) = v56;
		    v58 = v99;
		    *(_OWORD *)(i + 96) = v57;
		    v59 = v100;
		    *(_OWORD *)(i + 112) = v58;
		    v60 = v101;
		    *(_OWORD *)(i + 128) = v59;
		    v61 = v102;
		    v62 = v103;
		    *(_OWORD *)(i + 144) = v60;
		    *(_OWORD *)(i + 160) = v61;
		    *(_DWORD *)(i + 176) = v62;
		  }
		  v63 = v31->fields._size;
		  v64 = (void (__fastcall *)(__int64, _QWORD, bool))qword_18F3708B0;
		  if ( !qword_18F3708B0 )
		  {
		    v64 = (void (__fastcall *)(__int64, _QWORD, bool))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateFromNodes(S"
		                                                        "ystem.IntPtr,System.Int32,System.Boolean)");
		    if ( !v64 )
		    {
		      v73 = sub_1802EE1B8(
		              "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateFromNodes(System.IntPtr,System.Int32,System.Boolean)");
		      sub_18007E1B0(v73, 0LL);
		    }
		    qword_18F3708B0 = (__int64)v64;
		  }
		  v64(v25, v63, updateMobile);
		  v66 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::Dispose->klass;
		  if ( ((__int64)v66->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v66, v65);
		  if ( v25 )
		  {
		    v67 = (void (__fastcall *)(__int64, __int64))qword_18F36EF10;
		    if ( !qword_18F36EF10 )
		    {
		      v67 = (void (__fastcall *)(__int64, __int64))il2cpp_resolve_icall_1(
		                                                     "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::FreeTracked(System"
		                                                     ".Void*,Unity.Collections.Allocator)");
		      if ( !v67 )
		      {
		        v74 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::FreeTracked(System.Void*,Unity.Collections.Allocator)");
		        sub_18007E1B0(v74, 0LL);
		      }
		      qword_18F36EF10 = (__int64)v67;
		    }
		    v67(v25, 2LL);
		  }
		}
		
		private void CollectInteractions() {} // 0x0000000183B4FA60-0x0000000183B4FD80
		// Void CollectInteractions()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGInterationManager::CollectInteractions(HGInterationManager *this, MethodInfo *method)
		{
		  Int32__Array **v2; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes; // rbx
		  PropertyInfo_1 *size; // r8
		  List_1_HG_Rendering_Runtime_IHGInteractionObject_ *objects; // rbx
		  __int64 v13; // rdx
		  struct Object_1__Class *v14; // rcx
		  HGInteractionComponent *clearDelegate; // rbx
		  bool v16; // zf
		  List_1_HG_Rendering_Runtime_HGInteractionNode_ *v17; // rsi
		  struct IHGInteractionObject__Class *v18; // rdi
		  HGInteractionComponent__Class *klass; // r14
		  unsigned __int16 v20; // cx
		  unsigned __int16 v21; // dx
		  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
		  __int64 v23; // r8
		  MethodInfo *v24; // [rsp+20h] [rbp-58h] BYREF
		  SingleFieldAccessor v25; // [rsp+28h] [rbp-50h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v4, method);
		  if ( wrapperArray->max_length.size <= 1825 )
		    goto LABEL_13;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = v4->static_fields->wrapperArray;
		  if ( !v6 )
		    sub_1800D8260(v4, method);
		  if ( v6->max_length.size <= 0x721u )
		    sub_1800D2AB0(v4, method);
		  if ( v6[50].vector[25] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1825, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    nodes = this->fields.nodes;
		    if ( !nodes )
		      sub_1800D8260(v4, method);
		    ++nodes->fields._version;
		    size = (PropertyInfo_1 *)(unsigned int)nodes->fields._size;
		    nodes->fields._size = 0;
		    if ( (int)size > 0 )
		      System::Array::Clear((Array *)nodes->fields._items, 0, (int32_t)size, 0LL);
		    objects = this->fields.objects;
		    if ( !objects )
		      sub_1800D8260(v4, method);
		    *(_OWORD *)&v25.monitor = 0LL;
		    v25.klass = (SingleFieldAccessor__Class *)objects;
		    sub_18002D1B0(&v25, (Type *)method, size, v2, v24);
		    LODWORD(v25.monitor) = 0;
		    HIDWORD(v25.monitor) = objects->fields._version;
		    v25.fields._.getValueDelegate = 0LL;
		    *(_OWORD *)&v25.fields._.descriptor = *(_OWORD *)&v25.klass;
		    v25.fields.clearDelegate = 0LL;
		    v25.klass = 0LL;
		    v25.monitor = (MonitorData *)&v25.fields._.descriptor;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                (List_1_T_Enumerator_System_Object_ *)&v25.fields._.descriptor,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IHGInteractionObject>::MoveNext) )
		      {
		        clearDelegate = (HGInteractionComponent *)v25.fields.clearDelegate;
		        v16 = v25.fields.clearDelegate == 0LL;
		        if ( v25.fields.clearDelegate )
		        {
		          if ( (unsigned __int8)sub_180005080(v25.fields.clearDelegate->klass, TypeInfo::UnityEngine::Object) )
		          {
		            v16 = clearDelegate == 0LL;
		            if ( clearDelegate )
		            {
		              v14 = TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v14 = TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  v14 = TypeInfo::UnityEngine::Object;
		                  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                }
		              }
		              v16 = clearDelegate->fields._._._._.m_CachedPtr == 0LL;
		            }
		          }
		          else
		          {
		            v16 = clearDelegate == 0LL;
		          }
		        }
		        if ( !v16 )
		        {
		          v17 = this->fields.nodes;
		          if ( !clearDelegate )
		            sub_1800D8250(v14, v13);
		          if ( *(_DWORD *)&clearDelegate->klass->_1.method_count == 3356 )
		          {
		            HG::Rendering::Runtime::HGInteractionComponent::CollectInteractionNodes(
		              clearDelegate,
		              this->fields.nodes,
		              0LL);
		          }
		          else if ( *(_DWORD *)&clearDelegate->klass->_1.method_count == 3357 )
		          {
		            HG::Rendering::Runtime::HGCapsuleShadowHelper::CollectInteractionNodes(
		              (HGCapsuleShadowHelper *)clearDelegate,
		              this->fields.nodes,
		              0LL);
		          }
		          else
		          {
		            v18 = TypeInfo::HG::Rendering::Runtime::IHGInteractionObject;
		            klass = clearDelegate->klass;
		            sub_1800049A0(clearDelegate->klass);
		            v20 = 0;
		            v21 = *(_WORD *)&klass->_1.naturalAligment;
		            if ( v21 )
		            {
		              interfaceOffsets = klass->interfaceOffsets;
		              while ( (struct IHGInteractionObject__Class *)interfaceOffsets[v20].interfaceType != v18 )
		              {
		                if ( ++v20 >= v21 )
		                  goto LABEL_36;
		              }
		              v23 = (__int64)(&klass->vtable.Equals.method + 2 * interfaceOffsets[v20].offset);
		            }
		            else
		            {
		LABEL_36:
		              v23 = sub_1800219C0(clearDelegate, v18, 0LL);
		            }
		            (*(void (__fastcall **)(HGInteractionComponent *, List_1_HG_Rendering_Runtime_HGInteractionNode_ *, _QWORD))v23)(
		              clearDelegate,
		              v17,
		              *(_QWORD *)(v23 + 8));
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      v25.klass = (SingleFieldAccessor__Class *)v24->methodPointer;
		      if ( v25.klass )
		        sub_18007E1E0(v25.klass);
		    }
		  }
		}
		
		private void BatchInstanceDraw(CommandBuffer cmd, ScriptableRenderContext renderContext, int batchStart, int batchEnd, Material material) {} // 0x0000000189D01960-0x0000000189D01D34
		// Void BatchInstanceDraw(CommandBuffer, ScriptableRenderContext, Int32, Int32, Material)
		void HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
		        HGInterationManager *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        int32_t batchStart,
		        int32_t batchEnd,
		        Material *material,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int v12; // ebx
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *renderDatas; // rax
		  int v14; // edi
		  signed int v15; // eax
		  signed int v16; // r13d
		  int32_t count; // r15d
		  CBHandle *v18; // rax
		  void *ptr; // xmm0_8
		  int32_t v20; // eax
		  __int64 v21; // rax
		  __int64 v22; // rcx
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  Quaternion hitEffectRotation; // xmm0
		  __int128 v27; // xmm1
		  ObjectPtr_1_Beyond_Gameplay_Core_Entity_ attacker; // xmm0
		  ObjectPtr_1_Beyond_Gameplay_Core_IHittableObject_ hitTarget; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *v36; // rdx
		  Shader *shader; // rbx
		  String *s_InteractionUseCCD; // r8
		  int v39; // [rsp+48h] [rbp-C0h]
		  int32_t v40; // [rsp+4Ch] [rbp-BCh]
		  signed int v41; // [rsp+50h] [rbp-B8h]
		  LocalKeyword v42; // [rsp+58h] [rbp-B0h] BYREF
		  uint32_t bufferId_8[4]; // [rsp+70h] [rbp-98h]
		  LocalKeyword keyword_8; // [rsp+80h] [rbp-88h] BYREF
		  void *v45; // [rsp+A8h] [rbp-60h]
		  DamageAction_ExtraTarget v46; // [rsp+B0h] [rbp-58h] BYREF
		  DamageAction_ExtraTarget v47; // [rsp+1A0h] [rbp+98h] BYREF
		  DamageAction_ExtraTarget v48; // [rsp+290h] [rbp+188h] BYREF
		  ScriptableRenderContext P2; // [rsp+3C8h] [rbp+2C0h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  v12 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1827, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1827, 0LL);
		    if ( !Patch )
		      goto LABEL_23;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_736(
		      Patch,
		      (Object *)this,
		      (Object *)cmd,
		      P2,
		      batchStart,
		      batchEnd,
		      (Object *)material,
		      0LL);
		  }
		  else if ( batchEnd >= batchStart )
		  {
		    renderDatas = this->fields.renderDatas;
		    if ( !renderDatas )
		      goto LABEL_23;
		    if ( batchEnd < renderDatas->fields._size && batchStart < renderDatas->fields._size )
		    {
		      v14 = batchEnd - batchStart;
		      v41 = 0;
		      v15 = 0;
		      v16 = ((int)((unsigned __int64)(1374389535LL * v14) >> 32) >> 5)
		          + ((unsigned int)((unsigned __int64)(1374389535LL * v14) >> 32) >> 31)
		          + 1;
		      if ( v16 > 0 )
		      {
		        v39 = 0;
		        while ( 1 )
		        {
		          count = v15 == v14 / 100 ? v14 + 1 - 100 * v16 + 100 : 100;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v18 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                  (CBHandle *)&v42,
		                  &P2,
		                  224 * count,
		                  0LL);
		          v40 = 0;
		          *(_OWORD *)bufferId_8 = *(_OWORD *)&v18->bufferId;
		          ptr = v18->ptr;
		          v20 = 0;
		          v45 = ptr;
		          if ( count > 0 )
		            break;
		LABEL_14:
		          v36 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)this->fields.renderDatas;
		          if ( !v36
		            || (System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		                  &v46,
		                  v36,
		                  batchStart,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
		                (v36 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)this->fields.renderDatas) == 0LL)
		            || (System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		                  &v47,
		                  v36,
		                  batchStart,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
		                (v36 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)this->fields.renderDatas) == 0LL)
		            || (System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		                  &v48,
		                  v36,
		                  batchStart,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
		                !cmd)
		            || (UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		                  cmd,
		                  bufferId_8[0],
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractionDataCB,
		                  bufferId_8[1],
		                  22400,
		                  0LL),
		                !material) )
		          {
		            sub_1800D8260(Patch, v36);
		          }
		          shader = UnityEngine::Material::get_shader(material, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD;
		          memset(&v42, 0, sizeof(v42));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v42, shader, s_InteractionUseCCD, 0LL);
		          v12 = 0;
		          keyword_8 = v42;
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            material,
		            &keyword_8,
		            *((bool *)&v46.transferredSource.cachedUid + 4),
		            0LL);
		          UnityEngine::Rendering::CommandBuffer::HGDrawMeshInstanced(
		            cmd,
		            (Mesh *)v48.transferredSource.obj,
		            0,
		            material,
		            v47.transferredSource.cachedUid,
		            count,
		            0LL,
		            0LL);
		          v39 += 100;
		          v15 = v41 + 1;
		          v41 = v15;
		          if ( v15 >= v16 )
		            return;
		        }
		        while ( 1 )
		        {
		          v10 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)this->fields.renderDatas;
		          if ( !v10 )
		            break;
		          System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		            &v46,
		            v10,
		            batchStart + v20 + v39,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
		          v21 = v12;
		          v12 += 224;
		          v22 = (__int64)v45 + v21;
		          v23 = *(_OWORD *)&v46.targetWrapper.m_position.x;
		          *(ObjectPtr_1_Beyond_Gameplay_Core_AbilitySystem_ *)v22 = v46.targetWrapper.m_entityPtr;
		          v24 = *(_OWORD *)&v46.targetWrapper.m_targetDetail.hasValue;
		          *(_OWORD *)(v22 + 16) = v23;
		          v25 = *(_OWORD *)&v46.targetWrapper.m_targetDetail.value.hitPosition.z;
		          *(_OWORD *)(v22 + 32) = v24;
		          hitEffectRotation = v46.targetWrapper.m_targetDetail.value.hitEffectRotation;
		          *(_OWORD *)(v22 + 48) = v25;
		          v27 = *(_OWORD *)&v46.targetWrapper.m_targetDetail.value.hitColliderName;
		          *(Quaternion *)(v22 + 64) = hitEffectRotation;
		          attacker = v46.targetWrapper.m_hitInfo.attacker;
		          *(_OWORD *)(v22 + 80) = v27;
		          hitTarget = v46.targetWrapper.m_hitInfo.hitTarget;
		          *(ObjectPtr_1_Beyond_Gameplay_Core_Entity_ *)(v22 + 96) = attacker;
		          Patch = (ILFixDynamicMethodWrapper_2 *)(v22 + 128);
		          v30 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.hitPoint.x;
		          *(ObjectPtr_1_Beyond_Gameplay_Core_IHittableObject_ *)&Patch[-1].fields.methodId = hitTarget;
		          v31 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.hitColliderName;
		          *(_OWORD *)&Patch->klass = v30;
		          v32 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.hitEffectPoint.z;
		          *(_OWORD *)&Patch->fields.virtualMachine = v31;
		          v33 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.hitEffectRotation.w;
		          *(_OWORD *)&Patch->fields.anonObj = v32;
		          v34 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.hitValue;
		          *(_OWORD *)&Patch[1].monitor = v33;
		          v35 = *(_OWORD *)&v46.targetWrapper.m_hitInfo.dontHitImportInteractive;
		          v20 = ++v40;
		          *(_OWORD *)&Patch[1].fields.methodId = v34;
		          *(_OWORD *)&Patch[2].klass = v35;
		          if ( v40 >= count )
		            goto LABEL_14;
		        }
		LABEL_23:
		        sub_1800D8260(Patch, v10);
		      }
		    }
		  }
		}
		
		public void DrawInteractions(CommandBuffer cmd, ScriptableRenderContext renderContext, Material material, Bounds bounds) {} // 0x0000000189D01E08-0x0000000189D024D4
		// Void DrawInteractions(CommandBuffer, ScriptableRenderContext, Material, Bounds)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGInterationManager::DrawInteractions(
		        HGInterationManager *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        Material *material,
		        Bounds *bounds,
		        MethodInfo *method)
		{
		  Object *v6; // r14
		  void *m_Ptr; // rbx
		  Object *v8; // r12
		  HGInterationManager *v9; // rdi
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *renderDatas; // rcx
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v18; // r13
		  Comparison_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *v19; // rax
		  List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *v20; // rdx
		  Matrix4x4 *i; // rcx
		  Comparison_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v22; // rsi
		  int32_t v23; // r13d
		  int32_t v24; // esi
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v25; // rax
		  List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  Il2CppException *ex; // [rsp+40h] [rbp-5E8h]
		  Bounds v31; // [rsp+50h] [rbp-5D8h] BYREF
		  Bounds v32; // [rsp+70h] [rbp-5B8h] BYREF
		  Il2CppExceptionWrapper *v33; // [rsp+90h] [rbp-598h] BYREF
		  HGInteractionNodeRenderData v34; // [rsp+A0h] [rbp-588h] BYREF
		  HGInteractionNode current; // [rsp+190h] [rbp-498h] BYREF
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ v36; // [rsp+250h] [rbp-3D8h] BYREF
		  HGInteractionNodeRenderData renderData; // [rsp+320h] [rbp-308h] BYREF
		  HGInteractionNodeRenderData v38; // [rsp+410h] [rbp-218h] BYREF
		  HGInteractionNodeRenderData other; // [rsp+500h] [rbp-128h] BYREF
		
		  v6 = (Object *)material;
		  m_Ptr = renderContext.m_Ptr;
		  v8 = (Object *)cmd;
		  v9 = this;
		  sub_18033B9D0(&current, 0LL, 192LL);
		  sub_18033B9D0(&renderData, 0LL, 240LL);
		  sub_18033B9D0(&v38, 0LL, 240LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1828, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1828, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v28, v27);
		    v31 = *bounds;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_737(
		      Patch,
		      (Object *)v9,
		      v8,
		      (ScriptableRenderContext)m_Ptr,
		      v6,
		      &v31,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)v6, 0LL) )
		    {
		      if ( !v9->fields.renderDatas )
		        sub_1800D8260(v11, v10);
		      System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		        (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v9->fields.renderDatas,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Clear);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		      if ( !static_fields->terrainDeform )
		        sub_1800D8260(static_fields, v12);
		      HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(static_fields->terrainDeform, 0LL);
		      if ( !v9->fields.nodes )
		        sub_1800D8260(v15, v14);
		      System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator(
		        (List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ *)&v34,
		        v9->fields.nodes,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
		      *(_OWORD *)&v36._list = *(_OWORD *)&v34.instanceData.localToWorld.m00;
		      *(_OWORD *)&v36._current.NodeKey = *(_OWORD *)&v34.instanceData.localToWorld.m01;
		      *(Nullable_1_Beyond_Gameplay_Core_BattleTargetWrapper_TargetDetail_ *)&v36._current.localToWorldMatrix.m20 = *(Nullable_1_Beyond_Gameplay_Core_BattleTargetWrapper_TargetDetail_ *)&v34.instanceData.localToWorld.m02;
		      *(_OWORD *)&v36._current.prevLocalToWorldMatrix.m20 = *(_OWORD *)&v34.instanceData.worldToLocal.m02;
		      *(_OWORD *)&v36._current.prevLocalToWorldMatrix.m21 = *(_OWORD *)&v34.instanceData.worldToLocal.m03;
		      *(_OWORD *)&v36._current.prevLocalToWorldMatrix.m22 = *(_OWORD *)&v34.instanceData.prevLocalToWorld.m00;
		      *(_OWORD *)&v36._current.prevLocalToWorldMatrix.m23 = *(_OWORD *)&v34.instanceData.prevLocalToWorld.m01;
		      *(_OWORD *)&v36._current.length = *(_OWORD *)&v34.instanceData.prevLocalToWorld.m02;
		      *(_OWORD *)&v36._current.texture = *(_OWORD *)&v34.instanceData.prevLocalToWorld.m03;
		      *(_OWORD *)&v36._current.heightScale = *(_OWORD *)&v34.instanceData.radius;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext(
		                  &v36,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext) )
		        {
		          current = v36._current;
		          v31 = *HG::Rendering::Runtime::HGInteractionNode::GetBounds(&v32, &current, 0LL);
		          v32 = *bounds;
		          if ( UnityEngine::Bounds::Intersects(&v31, &v32, 0LL) )
		          {
		            if ( HG::Rendering::Runtime::HGInteractionNode::BuildRenderData(&current, &renderData, 0LL) )
		            {
		              renderDatas = v9->fields.renderDatas;
		              if ( !renderDatas )
		                sub_1800D8250(0LL, v16);
		              v34 = renderData;
		              System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Add(
		                renderDatas,
		                &v34,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Add);
		            }
		            else
		            {
		              HG::Rendering::Runtime::HGInteractionNode::DrawNode(&current, (CommandBuffer *)v8, (Material *)v6, 0LL);
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v33 )
		      {
		        ex = v33->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v6 = (Object *)material;
		        m_Ptr = renderContext.m_Ptr;
		        v8 = (Object *)cmd;
		        v9 = this;
		      }
		      v18 = v9->fields.renderDatas;
		      v19 = (Comparison_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)sub_18002C620(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGInteractionNodeRenderData>);
		      v22 = (Comparison_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *)v19;
		      if ( !v19 )
		        goto LABEL_37;
		      System::Comparison<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::Comparison(
		        v19,
		        0LL,
		        MethodInfo::HG::Rendering::Runtime::HGInteractionNodeRenderData::Sorter,
		        0LL);
		      if ( !v18 )
		        goto LABEL_37;
		      System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Sort(
		        v18,
		        v22,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Sort);
		      v23 = 0;
		      v24 = 0;
		      for ( i = 0LL; ; i = (Matrix4x4 *)(unsigned int)++v24 )
		      {
		        v25 = v9->fields.renderDatas;
		        if ( !v25 )
		          goto LABEL_37;
		        if ( (int)i >= v25->fields._size )
		          break;
		        if ( v24 )
		        {
		          v20 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)v9->fields.renderDatas;
		          if ( !v20 )
		            goto LABEL_37;
		          System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		            (DamageAction_ExtraTarget *)&v34,
		            v20,
		            v24,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
		          v38 = v34;
		          i = &v38.instanceData.prevLocalToWorld;
		          v20 = (List_1_Beyond_Gameplay_Core_DamageAction_ExtraTarget_ *)v9->fields.renderDatas;
		          if ( !v20 )
		            goto LABEL_37;
		          System::Collections::Generic::List<Beyond::Gameplay::Core::DamageAction::ExtraTarget>::get_Item(
		            (DamageAction_ExtraTarget *)&v34,
		            v20,
		            v24 - 1,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
		          other = v34;
		          if ( !HG::Rendering::Runtime::HGInteractionNodeRenderData::Match(&v38, &other, 0LL) )
		          {
		            HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
		              v9,
		              (CommandBuffer *)v8,
		              (ScriptableRenderContext)m_Ptr,
		              v23,
		              v24 - 1,
		              (Material *)v6,
		              0LL);
		            v23 = v24;
		          }
		        }
		      }
		      v26 = v9->fields.renderDatas;
		      if ( !v26 )
		LABEL_37:
		        sub_1800D8250(i, v20);
		      HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
		        v9,
		        (CommandBuffer *)v8,
		        (ScriptableRenderContext)m_Ptr,
		        v23,
		        v26->fields._size - 1,
		        (Material *)v6,
		        0LL);
		    }
		  }
		}
		
		public void DrawInteractionsMobile(CommandBuffer cmd) {} // 0x0000000189D01D34-0x0000000189D01E08
		// Void DrawInteractionsMobile(CommandBuffer)
		void HG::Rendering::Runtime::HGInterationManager::DrawInteractionsMobile(
		        HGInterationManager *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGGraphicsFeatureSwitch *terrainDeform; // rcx
		  HGInteractionSettingAsset *settingAsset; // rax
		  Material *decalInteractionMaterial; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1829, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1829, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    settingAsset = this->fields.settingAsset;
		    if ( !settingAsset )
		      goto LABEL_9;
		    decalInteractionMaterial = settingAsset->fields.decalInteractionMaterial;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)decalInteractionMaterial, 0LL)
		      && HG::Rendering::Runtime::HGDecalInteration::get_enableMobileInteraction(0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      terrainDeform = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainDeform;
		      if ( terrainDeform )
		      {
		        HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(terrainDeform, 0LL);
		        terrainDeform = (HGGraphicsFeatureSwitch *)this->fields.decalInteraction;
		        if ( terrainDeform )
		        {
		          HG::Rendering::Runtime::HGDecalInteration::DrawAllChains(
		            (HGDecalInteration *)terrainDeform,
		            cmd,
		            decalInteractionMaterial,
		            0LL);
		          return;
		        }
		      }
		LABEL_9:
		      sub_1800D8260(terrainDeform, v5);
		    }
		  }
		}
		
	}
}
