using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGManagerContext : HGManagerContextBase // TypeDefIndex: 37914
	{
		// Fields
		private const string PROFILE_MARK_MANAGERCONTEXT_GAMEPLAYUPDATE = "HGManagerContext: GameplayUpdate"; // Metadata: 0x023031D7
		private const string PROFILE_MARK_TERRAINSTREAMINGMANAGER = "HGManagerContext: HGTerrainStreamingManager Update"; // Metadata: 0x023031F8
		private const string PROFILE_MARK_RESOURCEMANAGERSCRIPT = "HGManagerContext: HGResourceManagerScript Update"; // Metadata: 0x0230322B
		private const string PROFILE_MARK_ENTITYRENDERHELPERECSMANAGER = "HGManagerContext: HGEntityRenderHelperECSManager Update"; // Metadata: 0x0230325C
		private const string PROFILE_MARK_REFLECTIONPROBETEXTUREMANAGER = "HGManagerContext: HGReflectionProbeTextureManager Update"; // Metadata: 0x02303294
		private const string PROFILE_MARK_FOLIAGEINTERACTIVEMANAGER = "HGManagerContext: HGFoliageInteractiveManager Update"; // Metadata: 0x023032CD
		private const string PROFILE_MARK_SLUDGEMANAGER = "HGManagerContext: HGSludgeManager Update"; // Metadata: 0x02303302
		private const string PROFILE_MARK_WINDMANAGER = "HGManagerContext: HGWindManager Update"; // Metadata: 0x0230332B
		private const string PROFILE_MARK_GPUCLOTHMANAGER = "HGManagerContext: GpuClothManager Update"; // Metadata: 0x02303352
		private const string PROFILE_MARK_TERRAINDEFORMMANAGER = "HGManagerContext: HGTerrainDeformManager Update"; // Metadata: 0x0230337B
		private const string PROFILE_MARK_VFXMANAGER = "HGManagerContext: HGVFXManager Update"; // Metadata: 0x023033AB
		private const string PROFILE_MARK_INKMANAGER = "HGManagerContext: HGInkManager Update"; // Metadata: 0x023033D1
		private const string PROFILE_MARK_MANAGERCONTEXT_EARLYUPDATE = "HGManagerContext: EarlyUpdate"; // Metadata: 0x023033F7
		private const string PROFILE_MARK_TERRAINSTREAMINGMANAGER_EARLYUPDATE = "HGManagerContext: HGTerrainStreamingManager EarlyUpdate"; // Metadata: 0x02303415
		private const string PROFILE_MARK_MANAGERCONTEXT_PIPELINEUPDATE = "HGManagerContext: PipelineUpdate"; // Metadata: 0x0230344D
		private const string PROFILE_MARK_REFLECTIONPROBETEXTUREMANAGER_PIPELINEUPDATE = "HGManagerContext: HGReflectionProbeTextureManager PipelineUpdate"; // Metadata: 0x0230346E
		private const string PROFILE_MARK_WATERMANAGER_PIPELINEUPDATE = "HGManagerContext: HGWaterManager PipelineUpdate"; // Metadata: 0x023034B0
		private const string PROFILE_MARK_WATERMANAGER_PIPELINE_EARLYUPDATE = "HGManagerContext: HGWaterManager Pipeline Early Update"; // Metadata: 0x023034E0
		private const string PROFILE_MARK_SKINNEDMESHCAPTUREMANAGER_PIPELINEUPDATE = "HGManagerContext: SkinnedMeshCaptureManager PipelineUpdate"; // Metadata: 0x02303517
		private const string PROFILE_MARK_FOLIAGEOCCLUDERMANAGER_PIPELINEUPDATE = "HGManagerContext: HGFoliageOccluderManager PipelineUpdate"; // Metadata: 0x02303552
		private const string PROFILE_MARK_INTERATIONMANAGER_PIPELINEUPDATE = "HGManagerContext: HGInterationManager PipelineUpdate"; // Metadata: 0x0230358C
		public HGIrradianceVolumeManager ivManager; // 0x58
		public HGIrradianceVolumeManagerV2 ivManagerV2; // 0x60
		private long windFoliageSyncSystemInstanceCPP; // 0xD0
	
		// Properties
		public static HGManagerContext currentManagerContext { get => default; } // 0x0000000183106820-0x00000001831068E0 
		// HGManagerContext get_currentManagerContext()
		HGManagerContext *HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  struct HGGlobalGameManager__Class *v3; // rax
		  HGManagerContextBase__Array *currentManagerContexts; // rax
		  HGManagerContext *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size <= 426 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v1 = (struct ILFixDynamicMethodWrapper_2__Class *)v1->static_fields->wrapperArray;
		  if ( !v1 )
		LABEL_13:
		    sub_1800D8260(wrapperArray, v1);
		  if ( LODWORD(v1->_0.namespaze) <= 0x1AA )
		LABEL_14:
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( *((_QWORD *)&v1[9]._0.this_arg + 1) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(426, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_205(Patch, 0LL);
		    goto LABEL_13;
		  }
		LABEL_5:
		  v3 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
		  if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
		    v3 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
		  }
		  currentManagerContexts = v3->static_fields->currentManagerContexts;
		  if ( !currentManagerContexts )
		    goto LABEL_13;
		  if ( !currentManagerContexts->max_length.size )
		    goto LABEL_14;
		  v5 = (HGManagerContext *)currentManagerContexts->vector[0];
		  if ( !v5 || !(unsigned __int8)sub_180005080(v5->klass, TypeInfo::HG::Rendering::Runtime::HGManagerContext) )
		    return 0LL;
		  return v5;
		}
		
		public HGResourceManagerScript resourceManagerScript { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
		public HGWaterManager waterManager { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
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
		
		public HGReflectionProbeTextureManager reflectionProbeTextureManager { get; } // 0x0000000184D86240-0x0000000184D86250 
		// Func`1[Object] get_getValueDelegate()
		Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
		        ValueWatcher_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public HGTerrainStreamingManager terrainStreamingManager { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
		IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
		        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
		}
		
		public HGEntityRenderHelperECSManager entityRenderHelperECSManager { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		// IUnit get_destinationUnit()
		IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
		        UnitConnection_2_System_Object_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._destinationUnit_k__BackingField;
		}
		
		public HGFoliageInteractiveManager foliageInteractiveManager { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		// ValueHandler`1[UnityEngine.Vector4] get_getter()
		ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
		        ValueOutput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._getter_k__BackingField;
		}
		
		public HGSludgeManager sludgeManager { get; } // 0x0000000184D86200-0x0000000184D86210 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
		        Variable_1_UnityEngine_Vector2_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public HGWindManager windManager { get; } // 0x0000000184D86270-0x0000000184D86280 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector4>::get_propertyPath(
		        Variable_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public GpuClothManager gpuClothManager { get; } // 0x0000000184D86230-0x0000000184D86240 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit2D>::get_propertyPath(
		        Variable_1_UnityEngine_RaycastHit2D_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public HGVFXManager vfxManager { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		// StyleValues get_to()
		StyleValues UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_to(
		        ValueAnimation_1_StyleValues_ *this,
		        MethodInfo *method)
		{
		  return (StyleValues)this->fields._to_k__BackingField.m_StyleValues;
		}
		
		public HGTerrainDeformManager terrainDeformManager { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
		        Variable_1_UnityEngine_ContactPoint2D_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SkinnedMeshCaptureManager skinnedMeshCaptureManager { get; } // 0x0000000184D86260-0x0000000184D86270 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit>::get_propertyPath(
		        Variable_1_UnityEngine_RaycastHit_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public HGFoliageOccluderManager foliageOccluderManager { get; } // 0x0000000184D861F0-0x0000000184D86200 
		// Func`3[Object,Object,Boolean] get_SameFunc()
		Func_3_Object_Object_Boolean_ *UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesDiscrete<System::Object>::get_SameFunc(
		        StylePropertyAnimationSystem_ValuesDiscrete_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._SameFunc_k__BackingField;
		}
		
		public HGRuntimeGrassQuery runtimeGrassQuery { get; } // 0x0000000184D86220-0x0000000184D86230 
		// WaterVolumePtr get_value()
		WaterVolumePtr Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Core::WaterVolumePtr>::get_value(
		        ParamVariable_1_Beyond_Gameplay_Core_WaterVolumePtr_ *this,
		        MethodInfo *method)
		{
		  return (WaterVolumePtr)this->fields.m_value.id;
		}
		
		public HGPlanarReflectionManager planarReflectionManager { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<Beyond::Gameplay::AI::Config::EnemyAISkillData>::get_propertyPath(
		        Variable_1_Beyond_Gameplay_AI_Config_EnemyAISkillData_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public HGInterationManager interactionManager { get; } // 0x0000000184D86210-0x0000000184D86220 
		// List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
		List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_variablesMap(
		        FSMStateNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._variablesMap;
		}
		
		public SubsurfaceManager subsurfaceManager { get; } // 0x0000000184D86290-0x0000000184D862A0 
		// Object get_currentInstance()
		Object *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_currentInstance(
		        FSMStateNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._currentInstance_k__BackingField;
		}
		
		public SubsurfaceProfileManager subsurfaceProfileManager { get; } // 0x0000000184D86250-0x0000000184D86260 
		// BBParameter get_parameter()
		BBParameter *FlowCanvas::Nodes::SetVariable<UnityEngine::Vector4>::get_parameter(
		        SetVariable_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return (BBParameter *)this->fields.targetVariable;
		}
		
		public VolumetricManager volumetricManager { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		// ValueInput`1[UnityEngine.Vector4] get_port()
		ValueInput_1_UnityEngine_Vector4_ *FlowCanvas::Nodes::RelayValueInput<UnityEngine::Vector4>::get_port(
		        RelayValueInput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._port_k__BackingField;
		}
		
		public VolumetricCloudVolumeManager volumetricCloudVolumeManager { get; } // 0x0000000184D892F0-0x0000000184D89300 
		// Dictionary`2[NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph] get_instances()
		Dictionary_2_NodeCanvas_Framework_Graph_NodeCanvas_Framework_Graph_ *FlowCanvas::FlowNodeNested<System::Object>::get_instances(
		        FlowNodeNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._instances_k__BackingField;
		}
		
		public HGInkManager inkManager { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
		// Object get_cachedValue()
		Object *FlowCanvas::Nodes::RelayValueInput<System::Object>::get_cachedValue(
		        RelayValueInput_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._cachedValue_k__BackingField;
		}
		
	
		// Constructors
		public HGManagerContext() {} // 0x0000000182ED8650-0x0000000182ED8AD0
		// HGManagerContext()
		void HG::Rendering::Runtime::HGManagerContext::HGManagerContext(HGManagerContext *this, MethodInfo *method)
		{
		  HGResourceManagerScript *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  HGResourceManagerScript *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  HGWaterManager *v10; // rax
		  HGWaterManager *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  HGReflectionProbeTextureManager *v15; // rax
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  HGTerrainStreamingManager *v18; // rax
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  HGFoliageInteractiveManager *v21; // rax
		  HGFoliageInteractiveManager *v22; // rdi
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  HGSludgeManager *v26; // rax
		  HGSludgeManager *v27; // rdi
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  HGWindManager *v31; // rax
		  HGWindManager *v32; // rdi
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  HGEntityRenderHelperECSManager *v36; // rax
		  HGEntityRenderHelperECSManager *v37; // rdi
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  HGIrradianceVolumeManager *v41; // rax
		  HGIrradianceVolumeManager *v42; // rdi
		  Type *v43; // rdx
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  HGIrradianceVolumeManagerV2 *v46; // rax
		  HGIrradianceVolumeManagerV2 *v47; // rdi
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  GpuClothManager *v51; // rax
		  GpuClothManager *v52; // rdi
		  Type *v53; // rdx
		  PropertyInfo_1 *v54; // r8
		  Int32__Array **v55; // r9
		  HGVFXManager *v56; // rax
		  HGVFXManager *v57; // rdi
		  Type *v58; // rdx
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  HGTerrainDeformManager *v61; // rax
		  HGTerrainDeformManager *v62; // rdi
		  Type *v63; // rdx
		  PropertyInfo_1 *v64; // r8
		  Int32__Array **v65; // r9
		  SkinnedMeshCaptureManager *v66; // rax
		  SkinnedMeshCaptureManager *v67; // rdi
		  Type *v68; // rdx
		  PropertyInfo_1 *v69; // r8
		  Int32__Array **v70; // r9
		  HGFoliageOccluderManager *v71; // rax
		  HGFoliageOccluderManager *v72; // rdi
		  Type *v73; // rdx
		  PropertyInfo_1 *v74; // r8
		  Int32__Array **v75; // r9
		  HGRuntimeGrassQuery *v76; // rax
		  HGRuntimeGrassQuery *v77; // rdi
		  Type *v78; // rdx
		  PropertyInfo_1 *v79; // r8
		  Int32__Array **v80; // r9
		  HGPlanarReflectionManager *v81; // rax
		  PropertyInfo_1 *v82; // r8
		  Int32__Array **v83; // r9
		  HGInterationManager *v84; // rax
		  HGInterationManager *v85; // rdi
		  Type *v86; // rdx
		  PropertyInfo_1 *v87; // r8
		  Int32__Array **v88; // r9
		  SubsurfaceManager *v89; // rax
		  SubsurfaceManager *v90; // rdi
		  Type *v91; // rdx
		  PropertyInfo_1 *v92; // r8
		  Int32__Array **v93; // r9
		  SubsurfaceProfileManager *v94; // rax
		  SubsurfaceProfileManager *v95; // rdi
		  Type *v96; // rdx
		  PropertyInfo_1 *v97; // r8
		  Int32__Array **v98; // r9
		  VolumetricManager *v99; // rax
		  VolumetricManager *v100; // rdi
		  Type *v101; // rdx
		  PropertyInfo_1 *v102; // r8
		  Int32__Array **v103; // r9
		  VolumetricCloudVolumeManager *v104; // rax
		  VolumetricCloudVolumeManager *v105; // rdi
		  Type *v106; // rdx
		  PropertyInfo_1 *v107; // r8
		  Int32__Array **v108; // r9
		  HGInkManager *v109; // rax
		  HGInkManager *v110; // rdi
		  Type *v111; // rdx
		  PropertyInfo_1 *v112; // r8
		  Int32__Array **v113; // r9
		  MethodInfo *v114; // [rsp+20h] [rbp-8h]
		  MethodInfo *v115; // [rsp+20h] [rbp-8h]
		  MethodInfo *v116; // [rsp+20h] [rbp-8h]
		  MethodInfo *v117; // [rsp+20h] [rbp-8h]
		  MethodInfo *v118; // [rsp+20h] [rbp-8h]
		  MethodInfo *v119; // [rsp+20h] [rbp-8h]
		  MethodInfo *v120; // [rsp+20h] [rbp-8h]
		  MethodInfo *v121; // [rsp+20h] [rbp-8h]
		  MethodInfo *v122; // [rsp+20h] [rbp-8h]
		  MethodInfo *v123; // [rsp+20h] [rbp-8h]
		  MethodInfo *v124; // [rsp+20h] [rbp-8h]
		  MethodInfo *v125; // [rsp+20h] [rbp-8h]
		  MethodInfo *v126; // [rsp+20h] [rbp-8h]
		  MethodInfo *v127; // [rsp+20h] [rbp-8h]
		  MethodInfo *v128; // [rsp+20h] [rbp-8h]
		  MethodInfo *v129; // [rsp+20h] [rbp-8h]
		  MethodInfo *v130; // [rsp+20h] [rbp-8h]
		  MethodInfo *v131; // [rsp+20h] [rbp-8h]
		  MethodInfo *v132; // [rsp+20h] [rbp-8h]
		  MethodInfo *v133; // [rsp+20h] [rbp-8h]
		  MethodInfo *v134; // [rsp+20h] [rbp-8h]
		  MethodInfo *v135; // [rsp+20h] [rbp-8h]
		  MethodInfo *v136; // [rsp+20h] [rbp-8h]
		
		  v3 = (HGResourceManagerScript *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGResourceManagerScript);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGResourceManagerScript::HGResourceManagerScript(v3, 0LL);
		  this->fields._resourceManagerScript_k__BackingField = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._resourceManagerScript_k__BackingField, v7, v8, v9, v114);
		  v10 = (HGWaterManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWaterManager);
		  v11 = v10;
		  if ( !v10 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGWaterManager::HGWaterManager(v10, 0LL);
		  this->fields._waterManager_k__BackingField = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._waterManager_k__BackingField, v12, v13, v14, v115);
		  v15 = (HGReflectionProbeTextureManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGReflectionProbeTextureManager);
		  if ( !v15 )
		    goto LABEL_2;
		  this->fields._reflectionProbeTextureManager_k__BackingField = v15;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._reflectionProbeTextureManager_k__BackingField, v4, v16, v17, v116);
		  v18 = (HGTerrainStreamingManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGTerrainStreamingManager);
		  if ( !v18 )
		    goto LABEL_2;
		  this->fields._terrainStreamingManager_k__BackingField = v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._terrainStreamingManager_k__BackingField, v4, v19, v20, v117);
		  v21 = (HGFoliageInteractiveManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveManager);
		  v22 = v21;
		  if ( !v21 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGFoliageInteractiveManager::HGFoliageInteractiveManager(v21, 0LL);
		  this->fields._foliageInteractiveManager_k__BackingField = v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._foliageInteractiveManager_k__BackingField, v23, v24, v25, v118);
		  v26 = (HGSludgeManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSludgeManager);
		  v27 = v26;
		  if ( !v26 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGSludgeManager::HGSludgeManager(v26, 0LL);
		  this->fields._sludgeManager_k__BackingField = v27;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._sludgeManager_k__BackingField, v28, v29, v30, v119);
		  v31 = (HGWindManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindManager);
		  v32 = v31;
		  if ( !v31 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGWindManager::HGWindManager(v31, 0LL);
		  this->fields._windManager_k__BackingField = v32;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._windManager_k__BackingField, v33, v34, v35, v120);
		  v36 = (HGEntityRenderHelperECSManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGEntityRenderHelperECSManager);
		  v37 = v36;
		  if ( !v36 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGEntityRenderHelperECSManager::HGEntityRenderHelperECSManager(v36, 0LL);
		  this->fields._entityRenderHelperECSManager_k__BackingField = v37;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._entityRenderHelperECSManager_k__BackingField, v38, v39, v40, v121);
		  v41 = (HGIrradianceVolumeManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeManager);
		  v42 = v41;
		  if ( !v41 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGIrradianceVolumeManager::HGIrradianceVolumeManager(v41, 0LL);
		  this->fields.ivManager = v42;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.ivManager, v43, v44, v45, v122);
		  v46 = (HGIrradianceVolumeManagerV2 *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeManagerV2);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::HGIrradianceVolumeManagerV2(v46, 0LL);
		  this->fields.ivManagerV2 = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.ivManagerV2, v48, v49, v50, v123);
		  v51 = (GpuClothManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GpuClothManager);
		  v52 = v51;
		  if ( !v51 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::GpuClothManager::GpuClothManager(v51, 0LL);
		  this->fields._gpuClothManager_k__BackingField = v52;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._gpuClothManager_k__BackingField, v53, v54, v55, v124);
		  v56 = (HGVFXManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		  v57 = v56;
		  if ( !v56 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGVFXManager::HGVFXManager(v56, 0LL);
		  this->fields._vfxManager_k__BackingField = v57;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._vfxManager_k__BackingField, v58, v59, v60, v125);
		  v61 = (HGTerrainDeformManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager);
		  v62 = v61;
		  if ( !v61 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGTerrainDeformManager::HGTerrainDeformManager(v61, 0LL);
		  this->fields._terrainDeformManager_k__BackingField = v62;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._terrainDeformManager_k__BackingField, v63, v64, v65, v126);
		  v66 = (SkinnedMeshCaptureManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager);
		  v67 = v66;
		  if ( !v66 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::SkinnedMeshCaptureManager::SkinnedMeshCaptureManager(v66, 0LL);
		  this->fields._skinnedMeshCaptureManager_k__BackingField = v67;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._skinnedMeshCaptureManager_k__BackingField, v68, v69, v70, v127);
		  v71 = (HGFoliageOccluderManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderManager);
		  v72 = v71;
		  if ( !v71 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGFoliageOccluderManager::HGFoliageOccluderManager(v71, 0LL);
		  this->fields._foliageOccluderManager_k__BackingField = v72;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._foliageOccluderManager_k__BackingField, v73, v74, v75, v128);
		  v76 = (HGRuntimeGrassQuery *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery);
		  v77 = v76;
		  if ( !v76 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGRuntimeGrassQuery::HGRuntimeGrassQuery(v76, 0LL);
		  this->fields._runtimeGrassQuery_k__BackingField = v77;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._runtimeGrassQuery_k__BackingField, v78, v79, v80, v129);
		  v81 = (HGPlanarReflectionManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGPlanarReflectionManager);
		  if ( !v81 )
		    goto LABEL_2;
		  this->fields._planarReflectionManager_k__BackingField = v81;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._planarReflectionManager_k__BackingField, v4, v82, v83, v130);
		  v84 = (HGInterationManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGInterationManager);
		  v85 = v84;
		  if ( !v84 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGInterationManager::HGInterationManager(v84, 0LL);
		  this->fields._interactionManager_k__BackingField = v85;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._interactionManager_k__BackingField, v86, v87, v88, v131);
		  v89 = (SubsurfaceManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SubsurfaceManager);
		  v90 = v89;
		  if ( !v89 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::SubsurfaceManager::SubsurfaceManager(v89, 0LL);
		  this->fields._subsurfaceManager_k__BackingField = v90;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._subsurfaceManager_k__BackingField, v91, v92, v93, v132);
		  v94 = (SubsurfaceProfileManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager);
		  v95 = v94;
		  if ( !v94 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileManager(v94, 0LL);
		  this->fields._subsurfaceProfileManager_k__BackingField = v95;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._subsurfaceProfileManager_k__BackingField, v96, v97, v98, v133);
		  v99 = (VolumetricManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricManager);
		  v100 = v99;
		  if ( !v99 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::VolumetricManager::VolumetricManager(v99, 0LL);
		  this->fields._volumetricManager_k__BackingField = v100;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._volumetricManager_k__BackingField, v101, v102, v103, v134);
		  v104 = (VolumetricCloudVolumeManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager);
		  v105 = v104;
		  if ( !v104
		    || (HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudVolumeManager(v104, 0LL),
		        this->fields._volumetricCloudVolumeManager_k__BackingField = v105,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields._volumetricCloudVolumeManager_k__BackingField,
		          v106,
		          v107,
		          v108,
		          v135),
		        v109 = (HGInkManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGInkManager),
		        (v110 = v109) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::Runtime::HGInkManager::HGInkManager(v109, 0LL);
		  this->fields._inkManager_k__BackingField = v110;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._inkManager_k__BackingField, v111, v112, v113, v136);
		  if ( !this->fields.windFoliageSyncSystemInstanceCPP )
		    this->fields.windFoliageSyncSystemInstanceCPP = UnityEngine::HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_Create(0LL);
		}
		
	
		// Methods
		public static HGManagerContext GetOrCreateManagerContext() => default; // 0x0000000183C540D0-0x0000000183C54130
		// HGManagerContext GetOrCreateManagerContext()
		HGManagerContext *HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(MethodInfo *method)
		{
		  HGGlobalGameManagerAssetBase *ManagerAsset; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2262, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2262, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_205(Patch, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
		    ManagerAsset = UnityEngine::HyperGryph::HGGlobalGameManager::GetManagerAsset(
		                     ManagerContextType__Enum_HGManagerContext,
		                     0LL);
		    UnityEngine::HyperGryph::HGGlobalGameManager::InitializeManagerContext(
		      ManagerContextType__Enum_HGManagerContext,
		      ManagerAsset,
		      0LL);
		    return HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		  }
		}
		
		protected override void Dispose(bool disposing) {} // 0x0000000189B57FF8-0x0000000189B581B0
		// Void Dispose(Boolean)
		void HG::Rendering::Runtime::HGManagerContext::Dispose(HGManagerContext *this, bool disposing, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2263, 0LL) )
		  {
		    waterManager_k__BackingField = this->fields._waterManager_k__BackingField;
		    if ( waterManager_k__BackingField )
		    {
		      HG::Rendering::Runtime::HGWaterManager::Release(waterManager_k__BackingField, 0LL);
		      waterManager_k__BackingField = (HGWaterManager *)this->fields._terrainStreamingManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(
		          (HGTerrainStreamingManager *)waterManager_k__BackingField,
		          0LL);
		        waterManager_k__BackingField = (HGWaterManager *)this->fields._foliageInteractiveManager_k__BackingField;
		        if ( waterManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::HGFoliageInteractiveManager::Dispose(
		            (HGFoliageInteractiveManager *)waterManager_k__BackingField,
		            0LL);
		          waterManager_k__BackingField = (HGWaterManager *)this->fields._sludgeManager_k__BackingField;
		          if ( waterManager_k__BackingField )
		          {
		            HG::Rendering::Runtime::HGSludgeManager::Dispose((HGSludgeManager *)waterManager_k__BackingField, 0LL);
		            waterManager_k__BackingField = (HGWaterManager *)this->fields.ivManager;
		            if ( waterManager_k__BackingField )
		            {
		              HG::Rendering::Runtime::HGIrradianceVolumeManager::Release(
		                (HGIrradianceVolumeManager *)waterManager_k__BackingField,
		                0LL);
		              waterManager_k__BackingField = (HGWaterManager *)this->fields.ivManagerV2;
		              if ( waterManager_k__BackingField )
		              {
		                HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReleaseV2(
		                  (HGIrradianceVolumeManagerV2 *)waterManager_k__BackingField,
		                  0LL);
		                waterManager_k__BackingField = (HGWaterManager *)this->fields._entityRenderHelperECSManager_k__BackingField;
		                if ( waterManager_k__BackingField )
		                {
		                  HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Dispose(
		                    (HGEntityRenderHelperECSManager *)waterManager_k__BackingField,
		                    0LL);
		                  waterManager_k__BackingField = (HGWaterManager *)this->fields._gpuClothManager_k__BackingField;
		                  if ( waterManager_k__BackingField )
		                  {
		                    HG::Rendering::Runtime::GpuClothManager::Dispose(
		                      (GpuClothManager *)waterManager_k__BackingField,
		                      0LL);
		                    waterManager_k__BackingField = (HGWaterManager *)this->fields._vfxManager_k__BackingField;
		                    if ( waterManager_k__BackingField )
		                    {
		                      HG::Rendering::Runtime::HGVFXManager::Dispose((HGVFXManager *)waterManager_k__BackingField, 0LL);
		                      waterManager_k__BackingField = (HGWaterManager *)this->fields._resourceManagerScript_k__BackingField;
		                      if ( waterManager_k__BackingField )
		                      {
		                        HG::Rendering::Runtime::HGResourceManagerScript::Dispose(
		                          (HGResourceManagerScript *)waterManager_k__BackingField,
		                          0LL);
		                        waterManager_k__BackingField = (HGWaterManager *)this->fields._planarReflectionManager_k__BackingField;
		                        if ( waterManager_k__BackingField )
		                        {
		                          HG::Rendering::Runtime::HGPlanarReflectionManager::Release(
		                            (HGPlanarReflectionManager *)waterManager_k__BackingField,
		                            0LL);
		                          waterManager_k__BackingField = (HGWaterManager *)this->fields._terrainDeformManager_k__BackingField;
		                          if ( waterManager_k__BackingField )
		                          {
		                            HG::Rendering::Runtime::HGTerrainDeformManager::Dispose(
		                              (HGTerrainDeformManager *)waterManager_k__BackingField,
		                              0LL);
		                            waterManager_k__BackingField = (HGWaterManager *)this->fields._interactionManager_k__BackingField;
		                            if ( waterManager_k__BackingField )
		                            {
		                              HG::Rendering::Runtime::HGInterationManager::Release(
		                                (HGInterationManager *)waterManager_k__BackingField,
		                                0LL);
		                              waterManager_k__BackingField = (HGWaterManager *)this->fields._windManager_k__BackingField;
		                              if ( waterManager_k__BackingField )
		                              {
		                                HG::Rendering::Runtime::HGWindManager::Dispose(
		                                  (HGWindManager *)waterManager_k__BackingField,
		                                  0LL);
		                                if ( this->fields.windFoliageSyncSystemInstanceCPP )
		                                {
		                                  UnityEngine::HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_Destroy(
		                                    this->fields.windFoliageSyncSystemInstanceCPP,
		                                    0LL);
		                                  this->fields.windFoliageSyncSystemInstanceCPP = 0LL;
		                                }
		                                waterManager_k__BackingField = (HGWaterManager *)this->fields._volumetricManager_k__BackingField;
		                                if ( waterManager_k__BackingField )
		                                {
		                                  HG::Rendering::Runtime::VolumetricManager::Release(
		                                    (VolumetricManager *)waterManager_k__BackingField,
		                                    0LL);
		                                  waterManager_k__BackingField = (HGWaterManager *)this->fields._inkManager_k__BackingField;
		                                  if ( waterManager_k__BackingField )
		                                  {
		                                    HG::Rendering::Runtime::HGInkManager::Release(
		                                      (HGInkManager *)waterManager_k__BackingField,
		                                      0LL);
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
		LABEL_22:
		    sub_1800D8260(waterManager_k__BackingField, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2263, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, disposing, 0LL);
		}
		
		protected override void EarlyUpdate() {} // 0x0000000183335B80-0x0000000183335D00
		// Void EarlyUpdate()
		void HG::Rendering::Runtime::HGManagerContext::EarlyUpdate(HGManagerContext *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGManagerContext *v3; // rdi
		  int *static_fields; // rdx
		  Object *terrainStreamingManager_k__BackingField; // rbx
		  struct HGGraphicsFeatureManager__Class *v6; // rcx
		  HGEntityRenderHelperECSManager *entityRenderHelperECSManager_k__BackingField; // rbx
		  unsigned __int8 m_contextDict; // bl
		  void (__fastcall *v9)(_QWORD); // rax
		  __int64 v10; // r8
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		  __int64 v12; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGManagerContext__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  __int64 v16; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_21;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 2285 )
		    goto LABEL_5;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v10 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_21;
		  if ( *(_DWORD *)(v10 + 24) <= 0x8EDu )
		    goto LABEL_45;
		  if ( !*(_QWORD *)(v10 + 18312) )
		  {
		LABEL_5:
		    terrainStreamingManager_k__BackingField = (Object *)v3->fields._terrainStreamingManager_k__BackingField;
		    if ( !terrainStreamingManager_k__BackingField )
		      goto LABEL_21;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGManagerContext *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_21;
		    if ( static_fields[6] > 2286 )
		    {
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (int *)v2->static_fields;
		      v12 = *(_QWORD *)static_fields;
		      if ( !*(_QWORD *)static_fields )
		        goto LABEL_21;
		      if ( *(_DWORD *)(v12 + 24) <= 0x8EEu )
		        goto LABEL_45;
		      if ( *(_QWORD *)(v12 + 18320) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(2286, 0LL);
		        if ( !Patch )
		          goto LABEL_21;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		          (ILFixDynamicMethodWrapper_39 *)Patch,
		          terrainStreamingManager_k__BackingField,
		          0LL);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		    }
		    v6 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      v6 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGManagerContext *)v6->static_fields;
		    entityRenderHelperECSManager_k__BackingField = this[2].fields._entityRenderHelperECSManager_k__BackingField;
		    if ( !entityRenderHelperECSManager_k__BackingField )
		      goto LABEL_21;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGManagerContext *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_21;
		    if ( static_fields[6] <= 412 )
		      goto LABEL_17;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGManagerContext *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		      goto LABEL_21;
		    if ( LODWORD(klass->_0.namespaze) > 0x19C )
		    {
		      if ( *(_QWORD *)&klass[7]._1.instance_size )
		      {
		        v15 = IFix::WrappersManagerImpl::GetPatch(412, 0LL);
		        if ( !v15 )
		          goto LABEL_21;
		        m_contextDict = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                          (ILFixDynamicMethodWrapper_20 *)v15,
		                          (Object *)entityRenderHelperECSManager_k__BackingField,
		                          0LL);
		        goto LABEL_18;
		      }
		LABEL_17:
		      m_contextDict = (unsigned __int8)entityRenderHelperECSManager_k__BackingField->fields.m_contextDict;
		LABEL_18:
		      v9 = (void (__fastcall *)(_QWORD))qword_18F370A10;
		      if ( !qword_18F370A10 )
		      {
		        v9 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryph.HGEditorTerrainManager::SetUseNewEditorTerrainRenderi"
		                                            "ng(System.Boolean)");
		        if ( !v9 )
		        {
		          v16 = sub_1802EE1B8("UnityEngine.HyperGryph.HGEditorTerrainManager::SetUseNewEditorTerrainRendering(System.Boolean)");
		          sub_18007E1B0(v16, 0LL);
		        }
		        qword_18F370A10 = (__int64)v9;
		      }
		      v9(m_contextDict);
		      this = (HGManagerContext *)v3->fields._waterManager_k__BackingField;
		      if ( this )
		      {
		        HG::Rendering::Runtime::HGWaterManager::EarlyUpdate((HGWaterManager *)this, 0LL);
		        return;
		      }
		LABEL_21:
		      sub_1800D8260(this, static_fields);
		    }
		LABEL_45:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v11 = IFix::WrappersManagerImpl::GetPatch(2285, 0LL);
		  if ( !v11 )
		    goto LABEL_21;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v11, (Object *)v3, 0LL);
		}
		
		internal void ForceGameplayUpdate() {} // 0x0000000189B581B0-0x0000000189B5820C
		// Void ForceGameplayUpdate()
		void HG::Rendering::Runtime::HGManagerContext::ForceGameplayUpdate(HGManagerContext *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2290, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2290, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields._._disposed_k__BackingField )
		  {
		    sub_180003290(5LL, this);
		  }
		}
		
		private void UpdateWindParam() {} // 0x00000001832DE6E0-0x00000001832DE9A0
		// Void UpdateWindParam()
		void HG::Rendering::Runtime::HGManagerContext::UpdateWindParam(HGManagerContext *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *klass; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Object *windManager_k__BackingField; // rbx
		  __int64 v6; // r8
		  _OWORD *v7; // rdx
		  __int64 v8; // rax
		  Il2CppClass **p_castClass; // rcx
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  Il2CppClass *v18; // rax
		  __int128 v19; // xmm1
		  char *v20; // rcx
		  _OWORD *v21; // rdx
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int64 v30; // rax
		  int64_t windFoliageSyncSystemInstanceCPP; // rbx
		  __int128 v32; // xmm1
		  float gameplayTime; // xmm6_4
		  float lastGameplayTime; // xmm0_4
		  void (__fastcall *v35)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v37; // rax
		  HGWindParamDataCache *v38; // rax
		  __int64 v39; // rax
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int64 v48; // rax
		  __int128 v49; // [rsp+50h] [rbp-3D8h] BYREF
		  __int128 v50; // [rsp+60h] [rbp-3C8h] BYREF
		  _OWORD v51[19]; // [rsp+70h] [rbp-3B8h] BYREF
		  char v52; // [rsp+1A0h] [rbp-288h] BYREF
		  char v53[64]; // [rsp+1B0h] [rbp-278h] BYREF
		  char v54[64]; // [rsp+1F0h] [rbp-238h] BYREF
		  char v55[64]; // [rsp+230h] [rbp-1F8h] BYREF
		  char v56[96]; // [rsp+270h] [rbp-1B8h] BYREF
		  HGWindParamDataCache v57[5]; // [rsp+2D0h] [rbp-158h] BYREF
		
		  klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = klass->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_19;
		  if ( wrapperArray->max_length.size > 2291 )
		  {
		    if ( !klass->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(klass);
		      klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = klass->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_19;
		    if ( wrapperArray->max_length.size <= 0x8F3u )
		      goto LABEL_38;
		    if ( wrapperArray[63].vector[23] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2291, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_19;
		    }
		  }
		  windManager_k__BackingField = (Object *)this->fields._windManager_k__BackingField;
		  if ( !windManager_k__BackingField )
		    goto LABEL_19;
		  if ( !klass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = klass->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_19;
		  if ( wrapperArray->max_length.size <= 1704 )
		    goto LABEL_10;
		  if ( !klass->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = (struct ILFixDynamicMethodWrapper_2__Class *)klass->static_fields->wrapperArray;
		  if ( !klass )
		LABEL_19:
		    sub_1800D8260(klass, wrapperArray);
		  if ( LODWORD(klass->_0.namespaze) <= 0x6A8 )
		LABEL_38:
		    sub_1800D2AB0(klass, wrapperArray);
		  if ( klass[36]._0.fields )
		  {
		    v37 = IFix::WrappersManagerImpl::GetPatch(1704, 0LL);
		    if ( v37 )
		    {
		      v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(v57, v37, windManager_k__BackingField, 0LL);
		      v6 = 2LL;
		      v7 = v51;
		      p_castClass = (Il2CppClass **)v38;
		      v39 = 2LL;
		      do
		      {
		        v7 += 8;
		        v40 = *(_OWORD *)p_castClass;
		        v41 = *((_OWORD *)p_castClass + 1);
		        p_castClass += 16;
		        *(v7 - 8) = v40;
		        v42 = *((_OWORD *)p_castClass - 6);
		        *(v7 - 7) = v41;
		        v43 = *((_OWORD *)p_castClass - 5);
		        *(v7 - 6) = v42;
		        v44 = *((_OWORD *)p_castClass - 4);
		        *(v7 - 5) = v43;
		        v45 = *((_OWORD *)p_castClass - 3);
		        *(v7 - 4) = v44;
		        v46 = *((_OWORD *)p_castClass - 2);
		        *(v7 - 3) = v45;
		        v47 = *((_OWORD *)p_castClass - 1);
		        *(v7 - 2) = v46;
		        *(v7 - 1) = v47;
		        --v39;
		      }
		      while ( v39 );
		      goto LABEL_13;
		    }
		    goto LABEL_19;
		  }
		LABEL_10:
		  klass = (struct ILFixDynamicMethodWrapper_2__Class *)windManager_k__BackingField[1].klass;
		  if ( !klass )
		    goto LABEL_19;
		  v6 = 2LL;
		  v7 = v51;
		  v8 = 2LL;
		  p_castClass = &klass->_0.castClass;
		  do
		  {
		    v7 += 8;
		    v10 = *(_OWORD *)p_castClass;
		    v11 = *((_OWORD *)p_castClass + 1);
		    p_castClass += 16;
		    *(v7 - 8) = v10;
		    v12 = *((_OWORD *)p_castClass - 6);
		    *(v7 - 7) = v11;
		    v13 = *((_OWORD *)p_castClass - 5);
		    *(v7 - 6) = v12;
		    v14 = *((_OWORD *)p_castClass - 4);
		    *(v7 - 5) = v13;
		    v15 = *((_OWORD *)p_castClass - 3);
		    *(v7 - 4) = v14;
		    v16 = *((_OWORD *)p_castClass - 2);
		    *(v7 - 3) = v15;
		    v17 = *((_OWORD *)p_castClass - 1);
		    *(v7 - 2) = v16;
		    *(v7 - 1) = v17;
		    --v8;
		  }
		  while ( v8 );
		LABEL_13:
		  v18 = p_castClass[4];
		  v19 = *((_OWORD *)p_castClass + 1);
		  *v7 = *(_OWORD *)p_castClass;
		  v7[1] = v19;
		  *((_QWORD *)v7 + 4) = v18;
		  LODWORD(v18) = *((_DWORD *)p_castClass + 10);
		  v20 = &v52;
		  *((_DWORD *)v7 + 10) = (_DWORD)v18;
		  v21 = v51;
		  do
		  {
		    v20 += 128;
		    v22 = *v21;
		    v23 = v21[1];
		    v21 += 8;
		    *((_OWORD *)v20 - 8) = v22;
		    v24 = *(v21 - 6);
		    *((_OWORD *)v20 - 7) = v23;
		    v25 = *(v21 - 5);
		    *((_OWORD *)v20 - 6) = v24;
		    v26 = *(v21 - 4);
		    *((_OWORD *)v20 - 5) = v25;
		    v27 = *(v21 - 3);
		    *((_OWORD *)v20 - 4) = v26;
		    v28 = *(v21 - 2);
		    *((_OWORD *)v20 - 3) = v27;
		    v29 = *(v21 - 1);
		    *((_OWORD *)v20 - 2) = v28;
		    *((_OWORD *)v20 - 1) = v29;
		    --v6;
		  }
		  while ( v6 );
		  v30 = *((_QWORD *)v21 + 4);
		  windFoliageSyncSystemInstanceCPP = this->fields.windFoliageSyncSystemInstanceCPP;
		  v32 = v21[1];
		  *(_OWORD *)v20 = *v21;
		  *((_OWORD *)v20 + 1) = v32;
		  *((_QWORD *)v20 + 4) = v30;
		  *((_DWORD *)v20 + 10) = *((_DWORD *)v21 + 10);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		  gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		  lastGameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
		  v35 = (void (__fastcall *)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD))qword_18F3706E8;
		  v49 = v51[17];
		  v50 = v51[0];
		  if ( !qword_18F3706E8 )
		  {
		    v35 = (void (__fastcall *)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD))il2cpp_resolve_icall_1("UnityEngine.HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64,UnityEngine.Vector4&,System.Single*,System.Single*,System.Single*,System.Single*,UnityEngine.Vector4&,System.Single,System.Single)");
		    if ( !v35 )
		    {
		      v48 = sub_1802EE1B8(
		              "UnityEngine.HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64,U"
		              "nityEngine.Vector4&,System.Single*,System.Single*,System.Single*,System.Single*,UnityEngine.Vector4&,Syste"
		              "m.Single,System.Single)");
		      sub_18007E1B0(v48, 0LL);
		    }
		    qword_18F3706E8 = (__int64)v35;
		  }
		  v35(
		    windFoliageSyncSystemInstanceCPP,
		    &v50,
		    v53,
		    v54,
		    v55,
		    v56,
		    &v49,
		    LODWORD(gameplayTime),
		    LODWORD(lastGameplayTime));
		}
		
		protected override void GameplayUpdate() {} // 0x00000001832E0C20-0x00000001832E0F40
		// Void GameplayUpdate()
		void HG::Rendering::Runtime::HGManagerContext::GameplayUpdate(HGManagerContext *this, MethodInfo *method)
		{
		  HGResourceManagerScript *resourceManagerScript_k__BackingField; // rcx
		  __int64 v4; // rdx
		  float deltaTime; // xmm0_4
		  Object *terrainStreamingManager_k__BackingField; // rdi
		  float v7; // xmm6_4
		  HGEntityRenderHelperECSManager *entityRenderHelperECSManager_k__BackingField; // rdi
		  int32_t i; // esi
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rax
		  Object *windManager_k__BackingField; // rdi
		  GpuClothManager *gpuClothManager_k__BackingField; // rdi
		  HGTerrainDeformManager *terrainDeformManager_k__BackingField; // rdi
		  float v14; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  Object *Item; // rax
		  __int64 v19; // r9
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) > 2292 )
		  {
		    if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		    {
		      il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		      resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		    if ( !v4 )
		      goto LABEL_48;
		    if ( *(_DWORD *)(v4 + 24) <= 0x8F4u )
		      goto LABEL_93;
		    if ( *(_QWORD *)(v4 + 18368) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2292, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_48;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		  HG::Rendering::Runtime::HGRPTimeManager::Update(0LL);
		  deltaTime = HG::Rendering::Runtime::HGRPTimeManager::get_deltaTime(0LL);
		  terrainStreamingManager_k__BackingField = (Object *)this->fields._terrainStreamingManager_k__BackingField;
		  v7 = deltaTime;
		  if ( !terrainStreamingManager_k__BackingField )
		    goto LABEL_48;
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) > 2296 )
		  {
		    if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		    {
		      il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		      resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		    if ( !v4 )
		      goto LABEL_48;
		    if ( *(_DWORD *)(v4 + 24) <= 0x8F8u )
		      goto LABEL_93;
		    if ( *(_QWORD *)(v4 + 18400) )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(2296, 0LL);
		      if ( !v16 )
		        goto LABEL_48;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)v16,
		        terrainStreamingManager_k__BackingField,
		        0LL);
		    }
		  }
		  resourceManagerScript_k__BackingField = this->fields._resourceManagerScript_k__BackingField;
		  if ( !resourceManagerScript_k__BackingField )
		    goto LABEL_48;
		  HG::Rendering::Runtime::HGResourceManagerScript::GameplayUpdate(resourceManagerScript_k__BackingField, 0LL);
		  entityRenderHelperECSManager_k__BackingField = this->fields._entityRenderHelperECSManager_k__BackingField;
		  if ( !entityRenderHelperECSManager_k__BackingField )
		    goto LABEL_48;
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) <= 1725 )
		    goto LABEL_18;
		  if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		  {
		    il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(_DWORD *)(v4 + 24) <= 0x6BDu )
		    goto LABEL_93;
		  if ( *(_QWORD *)(v4 + 13832) )
		  {
		    v17 = IFix::WrappersManagerImpl::GetPatch(1725, 0LL);
		    if ( !v17 )
		      goto LABEL_48;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)v17,
		      (Object *)entityRenderHelperECSManager_k__BackingField,
		      v7,
		      0LL);
		  }
		  else
		  {
		LABEL_18:
		    for ( i = 0; ; ++i )
		    {
		      m_activeHelpers = entityRenderHelperECSManager_k__BackingField->fields.m_activeHelpers;
		      if ( !m_activeHelpers )
		        goto LABEL_48;
		      if ( i >= m_activeHelpers->fields._size )
		        break;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               (List_1_System_Object_ *)entityRenderHelperECSManager_k__BackingField->fields.m_activeHelpers,
		               i,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
		      if ( !Item )
		        goto LABEL_48;
		      sub_1801F6448(1LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, Item, v19);
		    }
		    HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(
		      entityRenderHelperECSManager_k__BackingField,
		      0LL);
		  }
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)this->fields._foliageInteractiveManager_k__BackingField;
		  if ( !resourceManagerScript_k__BackingField )
		    goto LABEL_48;
		  HG::Rendering::Runtime::HGFoliageInteractiveManager::GameplayUpdate(
		    (HGFoliageInteractiveManager *)resourceManagerScript_k__BackingField,
		    0LL);
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)this->fields._sludgeManager_k__BackingField;
		  if ( !resourceManagerScript_k__BackingField )
		    goto LABEL_48;
		  HG::Rendering::Runtime::HGSludgeManager::GameplayUpdate((HGSludgeManager *)resourceManagerScript_k__BackingField, 0LL);
		  windManager_k__BackingField = (Object *)this->fields._windManager_k__BackingField;
		  if ( !windManager_k__BackingField )
		    goto LABEL_48;
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) <= 1701 )
		    goto LABEL_29;
		  if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		  {
		    il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(_DWORD *)(v4 + 24) <= 0x6A5u )
		    goto LABEL_93;
		  if ( *(_QWORD *)(v4 + 13640) )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(1701, 0LL);
		    if ( !v20 )
		      goto LABEL_48;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)v20,
		      windManager_k__BackingField,
		      v7,
		      0LL);
		  }
		  else
		  {
		LABEL_29:
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)windManager_k__BackingField[1].klass;
		    if ( !resourceManagerScript_k__BackingField )
		      goto LABEL_48;
		    HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(
		      (HGWindSimpleManager *)resourceManagerScript_k__BackingField,
		      v7,
		      0LL);
		  }
		  gpuClothManager_k__BackingField = this->fields._gpuClothManager_k__BackingField;
		  if ( !gpuClothManager_k__BackingField )
		    goto LABEL_48;
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) <= 1283 )
		    goto LABEL_36;
		  if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		  {
		    il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(_DWORD *)(v4 + 24) <= 0x503u )
		    goto LABEL_93;
		  if ( *(_QWORD *)(v4 + 10296) )
		  {
		    v21 = IFix::WrappersManagerImpl::GetPatch(1283, 0LL);
		    if ( !v21 )
		      goto LABEL_48;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)v21,
		      (Object *)gpuClothManager_k__BackingField,
		      v7,
		      0LL);
		  }
		  else
		  {
		LABEL_36:
		    gpuClothManager_k__BackingField[1].fields.CHARACTER_POSITION_OFFSET.x = v7;
		    HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(gpuClothManager_k__BackingField, 0LL);
		    if ( LOBYTE(gpuClothManager_k__BackingField[1].monitor) )
		    {
		      HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(gpuClothManager_k__BackingField, 0LL);
		      HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(gpuClothManager_k__BackingField, 0LL);
		      HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(gpuClothManager_k__BackingField, 0LL);
		    }
		  }
		  terrainDeformManager_k__BackingField = this->fields._terrainDeformManager_k__BackingField;
		  if ( !terrainDeformManager_k__BackingField )
		    goto LABEL_48;
		  resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(int *)(v4 + 24) <= 2298 )
		    goto LABEL_43;
		  if ( !LODWORD(resourceManagerScript_k__BackingField[2].fields.RESOURCE_MANAGER_SCRIPT_UPDATE_MARKER_UpdateAssetHandle.m_Ptr) )
		  {
		    il2cpp_runtime_class_init_1(resourceManagerScript_k__BackingField);
		    resourceManagerScript_k__BackingField = (HGResourceManagerScript *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&resourceManagerScript_k__BackingField[2].fields.m_assetHandleCount;
		  if ( !v4 )
		    goto LABEL_48;
		  if ( *(_DWORD *)(v4 + 24) <= 0x8FAu )
		LABEL_93:
		    sub_1800D2AB0(resourceManagerScript_k__BackingField, v4);
		  if ( !*(_QWORD *)(v4 + 18416) )
		  {
		LABEL_43:
		    v14 = v7 + terrainDeformManager_k__BackingField->fields.m_remainDeltaTime;
		    terrainDeformManager_k__BackingField->fields.deltaTime = 0.0;
		    terrainDeformManager_k__BackingField->fields.m_remainDeltaTime = v14;
		    if ( v14 >= 0.15000001 )
		    {
		      terrainDeformManager_k__BackingField->fields.deltaTime = 0.15000001;
		      terrainDeformManager_k__BackingField->fields.m_remainDeltaTime = v14 - 0.15000001;
		    }
		    goto LABEL_45;
		  }
		  v22 = IFix::WrappersManagerImpl::GetPatch(2298, 0LL);
		  if ( !v22 )
		LABEL_48:
		    sub_1800D8260(resourceManagerScript_k__BackingField, v4);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		    (ILFixDynamicMethodWrapper_18 *)v22,
		    (Object *)terrainDeformManager_k__BackingField,
		    v7,
		    0LL);
		LABEL_45:
		  if ( this->fields.windFoliageSyncSystemInstanceCPP )
		    HG::Rendering::Runtime::HGManagerContext::UpdateWindParam(this, 0LL);
		}
		
		protected override void PipelineUpdate() {} // 0x00000001831C8180-0x00000001831C8400
		// Void PipelineUpdate()
		void HG::Rendering::Runtime::HGManagerContext::PipelineUpdate(HGManagerContext *this, MethodInfo *method)
		{
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  int *wrapperArray; // rdx
		  Object *interactionManager_k__BackingField; // rdi
		  Object__Class *klass; // rsi
		  bool enableMobileInteraction; // al
		  Object *vfxManager_k__BackingField; // rdi
		  Object *inkManager_k__BackingField; // rdi
		  ILFixDynamicMethodWrapper_2 *v10; // rax
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		
		  waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)&waterManager_k__BackingField->fields.m_lastCenterRippleData.distanceXZ;
		  if ( !wrapperArray )
		    goto LABEL_34;
		  if ( wrapperArray[6] <= 2299 )
		    goto LABEL_5;
		  if ( !LODWORD(waterManager_k__BackingField->fields.m_StaleReadbackKeys) )
		  {
		    il2cpp_runtime_class_init_1(waterManager_k__BackingField);
		    waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)&waterManager_k__BackingField->fields.m_lastCenterRippleData.distanceXZ;
		  if ( !wrapperArray )
		    goto LABEL_34;
		  if ( (unsigned int)wrapperArray[6] <= 0x8FB )
		    goto LABEL_65;
		  if ( !*((_QWORD *)wrapperArray + 2303) )
		  {
		LABEL_5:
		    waterManager_k__BackingField = this->fields._waterManager_k__BackingField;
		    if ( !waterManager_k__BackingField )
		      goto LABEL_34;
		    HG::Rendering::Runtime::HGWaterManager::PipelineUpdate(waterManager_k__BackingField, 0LL);
		    waterManager_k__BackingField = (HGWaterManager *)this->fields._skinnedMeshCaptureManager_k__BackingField;
		    if ( !waterManager_k__BackingField )
		      goto LABEL_34;
		    HG::Rendering::Runtime::SkinnedMeshCaptureManager::PipelineUpdate(
		      (SkinnedMeshCaptureManager *)waterManager_k__BackingField,
		      0LL);
		    waterManager_k__BackingField = (HGWaterManager *)this->fields._foliageOccluderManager_k__BackingField;
		    if ( !waterManager_k__BackingField )
		      goto LABEL_34;
		    HG::Rendering::Runtime::HGFoliageOccluderManager::PipelineUpdate(
		      (HGFoliageOccluderManager *)waterManager_k__BackingField,
		      0LL);
		    interactionManager_k__BackingField = (Object *)this->fields._interactionManager_k__BackingField;
		    if ( !interactionManager_k__BackingField )
		      goto LABEL_34;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_34;
		    if ( wrapperArray[6] <= 1824 )
		      goto LABEL_13;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v11 = *(_QWORD *)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_34;
		    if ( *(_DWORD *)(v11 + 24) <= 0x720u )
		      goto LABEL_65;
		    if ( *(_QWORD *)(v11 + 14624) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1824, 0LL);
		      if ( !Patch )
		        goto LABEL_34;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        interactionManager_k__BackingField,
		        0LL);
		    }
		    else
		    {
		LABEL_13:
		      waterManager_k__BackingField = (HGWaterManager *)TypeInfo::UnityEngine::Object;
		      klass = interactionManager_k__BackingField[3].klass;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        waterManager_k__BackingField = (HGWaterManager *)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          waterManager_k__BackingField = (HGWaterManager *)TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( klass )
		      {
		        if ( !LODWORD(waterManager_k__BackingField->fields.m_StaleReadbackKeys) )
		          il2cpp_runtime_class_init_1(waterManager_k__BackingField);
		        if ( klass->_0.name )
		        {
		          HG::Rendering::Runtime::HGInterationManager::CollectInteractions(
		            (HGInterationManager *)interactionManager_k__BackingField,
		            0LL);
		          enableMobileInteraction = HG::Rendering::Runtime::HGDecalInteration::get_enableMobileInteraction(0LL);
		          HG::Rendering::Runtime::HGInterationManager::UpdateCppPipeline(
		            (HGInterationManager *)interactionManager_k__BackingField,
		            enableMobileInteraction,
		            0LL);
		        }
		      }
		    }
		    vfxManager_k__BackingField = (Object *)this->fields._vfxManager_k__BackingField;
		    if ( !vfxManager_k__BackingField )
		      goto LABEL_34;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_34;
		    if ( wrapperArray[6] <= 2328 )
		      goto LABEL_24;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v13 = *(_QWORD *)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_34;
		    if ( *(_DWORD *)(v13 + 24) <= 0x918u )
		      goto LABEL_65;
		    if ( *(_QWORD *)(v13 + 18656) )
		    {
		      v14 = IFix::WrappersManagerImpl::GetPatch(2328, 0LL);
		      if ( !v14 )
		        goto LABEL_34;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)v14,
		        vfxManager_k__BackingField,
		        0LL);
		    }
		    else
		    {
		LABEL_24:
		      HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue((HGVFXManager *)vfxManager_k__BackingField, 0LL);
		      HG::Rendering::Runtime::HGVFXManager::_UpdateAllCircles((HGVFXManager *)vfxManager_k__BackingField, 0LL);
		    }
		    inkManager_k__BackingField = (Object *)this->fields._inkManager_k__BackingField;
		    if ( !inkManager_k__BackingField )
		      goto LABEL_34;
		    waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)&waterManager_k__BackingField->fields.m_lastCenterRippleData.distanceXZ;
		    if ( !wrapperArray )
		      goto LABEL_34;
		    if ( wrapperArray[6] <= 2337 )
		      goto LABEL_30;
		    if ( !LODWORD(waterManager_k__BackingField->fields.m_StaleReadbackKeys) )
		    {
		      il2cpp_runtime_class_init_1(waterManager_k__BackingField);
		      waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    waterManager_k__BackingField = **(HGWaterManager ***)&waterManager_k__BackingField->fields.m_lastCenterRippleData.distanceXZ;
		    if ( !waterManager_k__BackingField )
		      goto LABEL_34;
		    if ( LODWORD(waterManager_k__BackingField->fields.m_globalConfigs) > 0x921 )
		    {
		      if ( *(_QWORD *)&waterManager_k__BackingField[80].fields.m_centerRippleData.priority )
		      {
		        v15 = IFix::WrappersManagerImpl::GetPatch(2337, 0LL);
		        if ( !v15 )
		          goto LABEL_34;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		          (ILFixDynamicMethodWrapper_39 *)v15,
		          inkManager_k__BackingField,
		          0LL);
		        goto LABEL_32;
		      }
		LABEL_30:
		      HG::Rendering::Runtime::HGInkManager::SetInkDynamicData((HGInkManager *)inkManager_k__BackingField, 0LL);
		      waterManager_k__BackingField = (HGWaterManager *)inkManager_k__BackingField[5].monitor;
		      if ( !waterManager_k__BackingField )
		        goto LABEL_34;
		      ++HIDWORD(waterManager_k__BackingField->fields.m_globalConfigs);
		      LODWORD(waterManager_k__BackingField->fields.m_globalConfigs) = 0;
		LABEL_32:
		      waterManager_k__BackingField = (HGWaterManager *)this->fields._volumetricManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::VolumetricManager::PipelineUpdate(
		          (VolumetricManager *)waterManager_k__BackingField,
		          0LL);
		        return;
		      }
		LABEL_34:
		      sub_1800D8260(waterManager_k__BackingField, wrapperArray);
		    }
		LABEL_65:
		    sub_1800D2AB0(waterManager_k__BackingField, wrapperArray);
		  }
		  v10 = IFix::WrappersManagerImpl::GetPatch(2299, 0LL);
		  if ( !v10 )
		    goto LABEL_34;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v10, (Object *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Dispose(bool P0) {} // 0x00000001841E1670-0x00000001841E1680
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
}
