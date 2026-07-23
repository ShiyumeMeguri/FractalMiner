using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSettingParameters // TypeDefIndex: 38603
	{
		// Fields
		public static readonly string ECS_FEATURE_NAME; // 0x00
		public static readonly string TAAU_FEATURE_NAME; // 0x08
		public static readonly string PSSR_FEATURE_NAME; // 0x10
		public static readonly string DLSS_FEATURE_NAME; // 0x18
		public static readonly string DLSSG_FEATURE_NAME; // 0x20
		public static readonly string FSR3_FEATURE_NAME; // 0x28
		public static readonly string FSR3FI_FEATURE_NAME; // 0x30
		public static readonly string PP_FEATURE_NAME; // 0x38
		public static readonly string ASTREAKS_FEATURE_NAME; // 0x40
		public static readonly string LIGHTING_FEATURE_NAME; // 0x48
		public static readonly string SSR_FEATURE_NAME; // 0x50
		public static readonly string FAKE_PR_FEATURE_NAME; // 0x58
		public static readonly string SHADOWMAP_FEATURE_NAME; // 0x60
		public static readonly string VISIBILITY_SH_FEATURE_NAME; // 0x68
		public static readonly string RT_SETTING_NAME; // 0x70
		public static readonly string TEXTURE_STREAMING_SETTING_NAME; // 0x78
		public static readonly string TEXTURE_QUALITY_SETTING_NAME; // 0x80
		public static readonly string CONTACT_SHADOW_FEATURE_NAME; // 0x88
		public static readonly string GTAO_FEATURE_NAME; // 0x90
		public static readonly string MISC_NAME; // 0x98
		public static readonly string GRASS_NAME; // 0xA0
		public static readonly string TERRAIN_NAME; // 0xA8
		public static readonly string WATER_NAME; // 0xB0
		public static readonly string FOLIAGE_NAME; // 0xB8
		public static readonly string ART_TAGS_NAME; // 0xC0
		public static readonly string ONE_PASS_FEATURE_NAME; // 0xC8
		public static readonly string REFLECTION_PROBE_TAGS_NAME; // 0xD0
		public static readonly string TRANSPARENT_NAME; // 0xD8
		public static readonly string CHROMATIC_ABERRATION_TRACING_NAME; // 0xE0
		public static readonly string RAY_TRACING_NAME; // 0xE8
		public static readonly string FRAME_INTERPOLATION_NAME; // 0xF0
		public static readonly string AFME_THRESHOLD_NAME; // 0xF8
		public static readonly string MFRC_THRESHOLD_NAME; // 0x100
		public static readonly string INK_NAME; // 0x108
	
		// Properties
		public SettingParameter<float> cullingViewScreenSizeMin { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
		public SettingParameter<float> ocScreenSizeMin { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
		public SettingParameter<bool> taauEnable { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<TAAUQuality> taauQuality { get; } // 0x0000000184D86240-0x0000000184D86250 
		// Func`1[Object] get_getValueDelegate()
		Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
		        ValueWatcher_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<float> historyWeight { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
		IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
		        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
		}
		
		public SettingParameter<float> historyWeightInMotion { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		// IUnit get_destinationUnit()
		IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
		        UnitConnection_2_System_Object_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._destinationUnit_k__BackingField;
		}
		
		public SettingParameter<float> fastConvergeHistoryWeight { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		// ValueHandler`1[UnityEngine.Vector4] get_getter()
		ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
		        ValueOutput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._getter_k__BackingField;
		}
		
		public SettingParameter<float> responsiveAAWeight { get; } // 0x0000000184D86200-0x0000000184D86210 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
		        Variable_1_UnityEngine_Vector2_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> minMotion { get; } // 0x0000000184D86270-0x0000000184D86280 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector4>::get_propertyPath(
		        Variable_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> maxMotion { get; } // 0x0000000182E56440-0x0000000182E56460 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Ray>::get_propertyPath(
		        Variable_1_UnityEngine_Ray_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> characterMotionSensitivity { get; } // 0x0000000184D86280-0x0000000184D86290 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Keyframe>::get_propertyPath(
		        Variable_1_UnityEngine_Keyframe_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> occlusionDepthDiff { get; } // 0x0000000184D86230-0x0000000184D86240 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit2D>::get_propertyPath(
		        Variable_1_UnityEngine_RaycastHit2D_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> inputLumaWeight { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		// StyleValues get_to()
		StyleValues UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_to(
		        ValueAnimation_1_StyleValues_ *this,
		        MethodInfo *method)
		{
		  return (StyleValues)this->fields._to_k__BackingField.m_StyleValues;
		}
		
		public SettingParameter<float> sharpenStrength1K { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
		        Variable_1_UnityEngine_ContactPoint2D_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> sharpenStrength2K { get; } // 0x0000000184D86260-0x0000000184D86270 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit>::get_propertyPath(
		        Variable_1_UnityEngine_RaycastHit_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<float> sharpenStrength4K { get; } // 0x0000000184D861F0-0x0000000184D86200 
		// Func`3[Object,Object,Boolean] get_SameFunc()
		Func_3_Object_Object_Boolean_ *UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesDiscrete<System::Object>::get_SameFunc(
		        StylePropertyAnimationSystem_ValuesDiscrete_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._SameFunc_k__BackingField;
		}
		
		public SettingParameter<bool> pssrEnable { get; } // 0x0000000184D86220-0x0000000184D86230 
		// WaterVolumePtr get_value()
		WaterVolumePtr Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Core::WaterVolumePtr>::get_value(
		        ParamVariable_1_Beyond_Gameplay_Core_WaterVolumePtr_ *this,
		        MethodInfo *method)
		{
		  return (WaterVolumePtr)this->fields.m_value.id;
		}
		
		public SettingParameter<float> pssrSharpness { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<Beyond::Gameplay::AI::Config::EnemyAISkillData>::get_propertyPath(
		        Variable_1_Beyond_Gameplay_AI_Config_EnemyAISkillData_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<bool> dlssEnable { get; } // 0x0000000184D86210-0x0000000184D86220 
		// List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
		List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_variablesMap(
		        FSMStateNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._variablesMap;
		}
		
		public SettingParameter<DLSSQuality> dlssQuality { get; } // 0x0000000184D86290-0x0000000184D862A0 
		// Object get_currentInstance()
		Object *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_currentInstance(
		        FSMStateNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._currentInstance_k__BackingField;
		}
		
		public SettingParameter<bool> dlssUseAutoExposure { get; } // 0x0000000184D86250-0x0000000184D86260 
		// BBParameter get_parameter()
		BBParameter *FlowCanvas::Nodes::SetVariable<UnityEngine::Vector4>::get_parameter(
		        SetVariable_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return (BBParameter *)this->fields.targetVariable;
		}
		
		public SettingParameter<StreamlineDLSSFGMode> dlssGMode { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		// ValueInput`1[UnityEngine.Vector4] get_port()
		ValueInput_1_UnityEngine_Vector4_ *FlowCanvas::Nodes::RelayValueInput<UnityEngine::Vector4>::get_port(
		        RelayValueInput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._port_k__BackingField;
		}
		
		public SettingParameter<int> dlssGGenFrames { get; } // 0x0000000184D892F0-0x0000000184D89300 
		// Dictionary`2[NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph] get_instances()
		Dictionary_2_NodeCanvas_Framework_Graph_NodeCanvas_Framework_Graph_ *FlowCanvas::FlowNodeNested<System::Object>::get_instances(
		        FlowNodeNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._instances_k__BackingField;
		}
		
		public SettingParameter<StreamlineReflexMode> dlssReflexMode { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
		// Object get_cachedValue()
		Object *FlowCanvas::Nodes::RelayValueInput<System::Object>::get_cachedValue(
		        RelayValueInput_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._cachedValue_k__BackingField;
		}
		
		public SettingParameter<bool> dlssPCLEnable { get; } // 0x0000000184D876B0-0x0000000184D876C0 
		// Object <RegisterPorts>b__6_0()
		Object *FlowCanvas::Nodes::StaticCodeEvent<System::Object>::_RegisterPorts_b__6_0(
		        StaticCodeEvent_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.eventValue;
		}
		
		public SettingParameter<float> dlssSharpenStrength { get; } // 0x0000000184D88EF0-0x0000000184D88F00 
		// GraphOwner <RegisterPorts>b__9_1()
		GraphOwner *FlowCanvas::Nodes::CustomEvent<UnityEngine::Vector4>::_RegisterPorts_b__9_1(
		        CustomEvent_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields.sender;
		}
		
		public SettingParameter<bool> dlssUseUIHint { get; } // 0x0000000184D8D1C0-0x0000000184D8D1D0 
		// GraphOwner <RegisterPorts>b__9_0()
		GraphOwner *FlowCanvas::Nodes::CustomEvent<UnityEngine::Vector4>::_RegisterPorts_b__9_0(
		        CustomEvent_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields.receiver;
		}
		
		public SettingParameter<float> dlssUIHintAlphaThreshold { get; } // 0x0000000184D88590-0x0000000184D885A0 
		// Object <RegisterPorts>b__9_2()
		Object *FlowCanvas::Nodes::CustomEvent<System::Object>::_RegisterPorts_b__9_2(
		        CustomEvent_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.receivedValue;
		}
		
		public SettingParameter<DLSSModel> dlssModel { get; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 
		// Mouse get_virtualMouse()
		Mouse_1 *UnityEngine::InputSystem::UI::DebugVirtualMouseInput::get_virtualMouse(
		        DebugVirtualMouseInput *this,
		        MethodInfo *method)
		{
		  return this->fields.m_VirtualMouse;
		}
		
		public SettingParameter<bool> fsr3Enable { get; } // 0x0000000184D877C0-0x0000000184D877D0 
		// Variable`1[Beyond.Gameplay.AI.AIEntity] get_varRef()
		Variable_1_Beyond_Gameplay_AI_AIEntity_ *NodeCanvas::Framework::ExposedParameter<Beyond::Gameplay::AI::AIEntity>::get_varRef(
		        ExposedParameter_1_Beyond_Gameplay_AI_AIEntity_ *this,
		        MethodInfo *method)
		{
		  return this->fields._varRef_k__BackingField;
		}
		
		public SettingParameter<bool> fsr3UseReaciveAndTCMask { get; } // 0x0000000184D87D50-0x0000000184D87D60 
		// ICinemachineCamera get_LiveChild()
		ICinemachineCamera *Cinemachine::CinemachineStateDrivenCamera::get_LiveChild(
		        CinemachineStateDrivenCamera *this,
		        MethodInfo *method)
		{
		  return this->fields._LiveChild_k__BackingField;
		}
		
		public SettingParameter<FSR3Quality> fsr3Quality { get; } // 0x0000000184D85F90-0x0000000184D85FA0 
		// List`1[RVO.RVOAgent] get_agents()
		List_1_RVO_RVOAgent_ *RVO::Simulator::get_agents(Simulator *this, MethodInfo *method)
		{
		  return this->fields.m_agents;
		}
		
		public SettingParameter<float> fsr3SharpenStrength { get; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 
		// AvatarMask get_avatarMask()
		AvatarMask *UnityEngine::Timeline::AnimationTrack::get_avatarMask(AnimationTrack *this, MethodInfo *method)
		{
		  return this->fields.m_AvatarMask;
		}
		
		public SettingParameter<bool> fsr3UseFP16 { get; } // 0x0000000184D85F80-0x0000000184D85F90 
		// RVOQuadtree get_Quadtree()
		RVOQuadtree *RVO::Simulator::get_Quadtree(Simulator *this, MethodInfo *method)
		{
		  return this->fields._Quadtree_k__BackingField;
		}
		
		public SettingParameter<bool> fsr3UseWave { get; } // 0x0000000184D8DC70-0x0000000184D8DC80 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<Beyond::Gameplay::AI::AIEntity>::get_propertyPath(
		        Variable_1_Beyond_Gameplay_AI_AIEntity_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<bool> fsr3UseWave64 { get; } // 0x0000000184D8D910-0x0000000184D8D920 
		// HashSet`1[PaintIn3D.P3dPaintableTexture] get_PaintableTextures()
		HashSet_1_PaintIn3D_P3dPaintableTexture_ *PaintIn3D::P3dPaintable::get_PaintableTextures(
		        P3dPaintable *this,
		        MethodInfo *method)
		{
		  return this->fields.paintableTextures;
		}
		
		public SettingParameter<bool> fsr3UseLanczosLut { get; } // 0x0000000184D8D8A0-0x0000000184D8D8B0 
		// ButtonControl get_left()
		ButtonControl *UnityEngine::InputSystem::Controls::StickControl::get_left(StickControl *this, MethodInfo *method)
		{
		  return (ButtonControl *)this->fields._._._.m_MaxValue.m_LongValue;
		}
		
		public SettingParameter<bool> fsr3FIEnable { get; } // 0x0000000184D8DC90-0x0000000184D8DCA0 
		// HGVirtualMouse get_virtualMouse()
		HGVirtualMouse *Beyond::Input::InputManager::get_virtualMouse(InputManager_2 *this, MethodInfo *method)
		{
		  return this->fields._virtualMouse_k__BackingField;
		}
		
		public SettingParameter<BloomQuality> bloomQuality { get; } // 0x0000000184D8DA60-0x0000000184D8DA70 
		// Object get_data()
		Object *Beyond::Gameplay::Core::ViewComponentWithDynamicProperty<System::Object>::get_data(
		        ViewComponentWithDynamicProperty_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._data_k__BackingField;
		}
		
		public SettingParameter<bool> bloomUseComputeShader { get; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 
		// ParamBlackboard get_properties()
		ParamBlackboard *Beyond::Gameplay::Core::ViewComponentWithDynamicProperty<System::Object>::get_properties(
		        ViewComponentWithDynamicProperty_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._properties_k__BackingField;
		}
		
		public SettingParameter<int> lutSize { get; } // 0x0000000184D8D890-0x0000000184D8D8A0 
		// ParamBlackboard get_properties()
		ParamBlackboard *Beyond::Gameplay::Core::LogicComponentWithDynamicProperty<System::Object>::get_properties(
		        LogicComponentWithDynamicProperty_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._properties_k__BackingField;
		}
		
		public SettingParameter<GraphicsFormat> lutFormat { get; } // 0x0000000184D8D8E0-0x0000000184D8D8F0 
		// MeshGenerationContext get_meshGenerationContext()
		MeshGenerationContext *UnityEngine::UIElements::UIR::Implementation::UIRStylePainter::get_meshGenerationContext(
		        UIRStylePainter *this,
		        MethodInfo *method)
		{
		  return this->fields._meshGenerationContext_k__BackingField;
		}
		
		public SettingParameter<GraphicsFormat> ppBufferFormat { get; } // 0x0000000184D8D8F0-0x0000000184D8D900 
		// ProbeVolumeDebug get_debugDisplay()
		ProbeVolumeDebug *UnityEngine::Experimental::Rendering::ProbeReferenceVolume::get_debugDisplay(
		        ProbeReferenceVolume *this,
		        MethodInfo *method)
		{
		  return this->fields._debugDisplay_k__BackingField;
		}
		
		public SettingParameter<GraphicsFormat> uiPPBufferFormat { get; } // 0x0000000184D8DF00-0x0000000184D8DF10 
		// IMouseInputSource get_mouseSource()
		IMouseInputSource *Rewired::Integration::UnityUI::PlayerPointerEventData::get_mouseSource(
		        PlayerPointerEventData *this,
		        MethodInfo *method)
		{
		  return this->fields._mouseSource_k__BackingField;
		}
		
		public SettingParameter<bool> frostedGlassUseComputeShader { get; } // 0x0000000184D8DEF0-0x0000000184D8DF00 
		// ITouchInputSource get_touchSource()
		ITouchInputSource *Rewired::Integration::UnityUI::PlayerPointerEventData::get_touchSource(
		        PlayerPointerEventData *this,
		        MethodInfo *method)
		{
		  return this->fields._touchSource_k__BackingField;
		}
		
		public SettingParameter<bool> enablePermenantSceneFrostedGlass { get; } // 0x0000000184D8DEE0-0x0000000184D8DEF0 
		// Transform get_customControllerMouseTrans()
		Transform *Beyond::Input::InputManager::get_customControllerMouseTrans(InputManager_2 *this, MethodInfo *method)
		{
		  return this->fields._customControllerMouseTrans_k__BackingField;
		}
		
		public SettingParameter<HGDepthOfFieldQuality> depthOfFieldQuality { get; } // 0x0000000184D8DD60-0x0000000184D8DD70 
		// Camera get_customControllerMouseUICamera()
		Camera *Beyond::Input::InputManager::get_customControllerMouseUICamera(InputManager_2 *this, MethodInfo *method)
		{
		  return this->fields._customControllerMouseUICamera_k__BackingField;
		}
		
		public SettingParameter<float> depthOfFieldMaxRadius { get; } // 0x0000000184D8DA20-0x0000000184D8DA30 
		// RectTransform get_fillRect()
		RectTransform *UnityEngine::UI::Slider::get_fillRect(Slider *this, MethodInfo *method)
		{
		  return this->fields.m_FillRect;
		}
		
		public SettingParameter<bool> depthOfFieldScaleAdjust { get; } // 0x0000000184D8DD50-0x0000000184D8DD60 
		// SRSpinner+SpinEvent get_OnSpinDecrement()
		SRSpinner_SpinEvent *SRF::UI::SRSpinner::get_OnSpinDecrement(SRSpinner *this, MethodInfo *method)
		{
		  return this->fields._onSpinDecrement;
		}
		
		public SettingParameter<float> depthOfFieldScaleAdjustThreshold { get; } // 0x0000000184D8DED0-0x0000000184D8DEE0 
		// SRSpinner+SpinEvent get_OnSpinIncrement()
		SRSpinner_SpinEvent *SRF::UI::SRSpinner::get_OnSpinIncrement(SRSpinner *this, MethodInfo *method)
		{
		  return this->fields._onSpinIncrement;
		}
		
		public SettingParameter<bool> motionBlurEnable { get; } // 0x0000000184D8DA10-0x0000000184D8DA20 
		// Scrollbar+ScrollEvent get_onValueChanged()
		Scrollbar_ScrollEvent *UnityEngine::UI::Scrollbar::get_onValueChanged(Scrollbar *this, MethodInfo *method)
		{
		  return this->fields.m_OnValueChanged;
		}
		
		public SettingParameter<bool> bloomEnabled { get; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 
		// Image get_itemImage()
		Image *UnityEngine::UI::Dropdown::get_itemImage(Dropdown *this, MethodInfo *method)
		{
		  return this->fields.m_ItemImage;
		}
		
		public SettingParameter<bool> vignetteEnabled { get; } // 0x0000000184D8D960-0x0000000184D8D970 
		// Slider+SliderEvent get_onValueChanged()
		Slider_SliderEvent *UnityEngine::UI::Slider::get_onValueChanged(Slider *this, MethodInfo *method)
		{
		  return this->fields.m_OnValueChanged;
		}
		
		public SettingParameter<bool> radialBlurEnabled { get; } // 0x0000000184D8DA90-0x0000000184D8DAA0 
		// HEU_BakedDataEvent get_BakedDataEvent()
		HEU_BakedDataEvent *HoudiniEngineUnity::HEU_HoudiniAsset::get_BakedDataEvent(
		        HEU_HoudiniAsset *this,
		        MethodInfo *method)
		{
		  return this->fields._bakedDataEvent;
		}
		
		public SettingParameter<bool> chromaticAberrationEnabled { get; } // 0x0000000184D8DA80-0x0000000184D8DA90 
		// InputField+SubmitEvent get_onSubmit()
		InputField_SubmitEvent *UnityEngine::UI::InputField::get_onSubmit(InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnSubmit;
		}
		
		public SettingParameter<bool> dirtyLensEnabled { get; } // 0x0000000184D8D790-0x0000000184D8D7A0 
		// InputField+EndEditEvent get_onEndEdit()
		InputField_EndEditEvent *UnityEngine::UI::InputField::get_onEndEdit(InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnDidEndEdit;
		}
		
		public SettingParameter<bool> sharpenEnabled { get; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 
		// InputField+OnChangeEvent get_onValueChanged()
		InputField_OnChangeEvent *UnityEngine::UI::InputField::get_onValueChanged(InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnValueChanged;
		}
		
		public SettingParameter<bool> frostedGlassEnabled { get; } // 0x0000000184D87870-0x0000000184D87880 
		// Transform get_Follow()
		Transform *Cinemachine::CinemachineExternalCamera::get_Follow(CinemachineExternalCamera *this, MethodInfo *method)
		{
		  return this->fields._Follow_k__BackingField;
		}
		
		public SettingParameter<bool> cutsceneEffectEnabled { get; } // 0x0000000184D8D930-0x0000000184D8D940 
		// InputBindingGroupMonoTarget get_parent()
		InputBindingGroupMonoTarget *Beyond::UI::UITouchPanel::get_parent(UITouchPanel *this, MethodInfo *method)
		{
		  return this->fields._parent_k__BackingField;
		}
		
		public SettingParameter<bool> fisheyeEffectEnabled { get; } // 0x0000000184D87930-0x0000000184D87940 
		// ICinemachineCamera get_LiveChild()
		ICinemachineCamera *Cinemachine::CinemachineMixingCamera::get_LiveChild(
		        CinemachineMixingCamera *this,
		        MethodInfo *method)
		{
		  return this->fields._LiveChild_k__BackingField;
		}
		
		public SettingParameter<bool> lensFlareEnabled { get; } // 0x0000000184D87940-0x0000000184D87950 
		// Transform get_LookAt()
		Transform *Cinemachine::CinemachineMixingCamera::get_LookAt(CinemachineMixingCamera *this, MethodInfo *method)
		{
		  return this->fields._LookAt_k__BackingField;
		}
		
		public SettingParameter<int> lensFlareOccSampleCount { get; } // 0x0000000184D87920-0x0000000184D87930 
		// Transform get_Follow()
		Transform *Cinemachine::CinemachineMixingCamera::get_Follow(CinemachineMixingCamera *this, MethodInfo *method)
		{
		  return this->fields._Follow_k__BackingField;
		}
		
		public SettingParameter<bool> enableAnamorphicStreaks { get; } // 0x0000000184D8DA40-0x0000000184D8DA50 
		// BezierParam GetPenetrationConnectDistance()
		BezierParam *MagicaCloth::ClothParams::GetPenetrationConnectDistance(ClothParams *this, MethodInfo *method)
		{
		  return this->fields.penetrationConnectDistance;
		}
		
		public SettingParameter<float> anamorphicStreaksDownSampleFactor { get; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 
		// String get_text()
		String *UnityEngine::UI::InputField::get_text(InputField *this, MethodInfo *method)
		{
		  return this->fields.m_Text;
		}
		
		public SettingParameter<int> punctualLightMaxCount { get; } // 0x0000000184D8D8B0-0x0000000184D8D8C0 
		// BezierParam GetPenetrationRadius()
		BezierParam *MagicaCloth::ClothParams::GetPenetrationRadius(ClothParams *this, MethodInfo *method)
		{
		  return this->fields.penetrationRadius;
		}
		
		public SettingParameter<bool> enableShadowProxy { get; } // 0x0000000184D8D3D0-0x0000000184D8D3E0 
		// ButtonControl get_optionsButton()
		ButtonControl *UnityEngine::InputSystem::DualShock::DualShockGamepad::get_optionsButton(
		        DualShockGamepad *this,
		        MethodInfo *method)
		{
		  return this->fields._._buttonSouth_k__BackingField;
		}
		
		public SettingParameter<DepthBits> shadowDepthBits { get; } // 0x0000000184D8D870-0x0000000184D8D880 
		// List`1[HoudiniEngineUnity.HEU_InputNode] GetInputNodes()
		List_1_HoudiniEngineUnity_HEU_InputNode_ *HoudiniEngineUnity::HEU_HoudiniAsset::GetInputNodes(
		        HEU_HoudiniAsset *this,
		        MethodInfo *method)
		{
		  return this->fields._inputNodes;
		}
		
		public SettingParameter<bool> csmEnabled { get; } // 0x0000000184D8D440-0x0000000184D8D450 
		// RenderTexture[] get_dynamicRenderTextures()
		RenderTexture__Array *TMPro::TMP_FontAsset::get_dynamicRenderTextures(TMP_FontAsset *this, MethodInfo *method)
		{
		  return this->fields.m_DynamicRenderTextures;
		}
		
		public SettingParameter<int> csmShadowMapTileResolution { get; } // 0x0000000184D8DAE0-0x0000000184D8DAF0 
		// ButtonControl get_R1()
		ButtonControl *UnityEngine::InputSystem::DualShock::DualShockGamepad::get_R1(
		        DualShockGamepad *this,
		        MethodInfo *method)
		{
		  return this->fields._._rightStickButton_k__BackingField;
		}
		
		public SettingParameter<bool> enableScreenSpaceShadowMask { get; } // 0x0000000184D8DAD0-0x0000000184D8DAE0 
		// TMP_InputField+SubmitEvent get_onEndEdit()
		TMP_InputField_SubmitEvent *TMPro::TMP_InputField::get_onEndEdit(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnEndEdit;
		}
		
		public SettingParameter<float> csmMaxDistance { get; } // 0x0000000184D8DE80-0x0000000184D8DE90 
		// TMP_InputField+SubmitEvent get_onSubmit()
		TMP_InputField_SubmitEvent *TMPro::TMP_InputField::get_onSubmit(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnSubmit;
		}
		
		public SettingParameter<float> csmFadeInnerDistance { get; } // 0x0000000184D8D840-0x0000000184D8D850 
		// TMP_InputField+SelectionEvent get_onSelect()
		TMP_InputField_SelectionEvent *TMPro::TMP_InputField::get_onSelect(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnSelect;
		}
		
		public SettingParameter<int> csmSplitCount { get; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 
		// TMP_InputField+SelectionEvent get_onDeselect()
		TMP_InputField_SelectionEvent *TMPro::TMP_InputField::get_onDeselect(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnDeselect;
		}
		
		public SettingParameter<float> csmSplit0 { get; } // 0x0000000184D8DE70-0x0000000184D8DE80 
		// TMP_InputField+TextSelectionEvent get_onTextSelection()
		TMP_InputField_TextSelectionEvent *TMPro::TMP_InputField::get_onTextSelection(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnTextSelection;
		}
		
		public SettingParameter<float> csmSplit1 { get; } // 0x0000000184D8D810-0x0000000184D8D820 
		// TMP_InputField+TextSelectionEvent get_onEndTextSelection()
		TMP_InputField_TextSelectionEvent *TMPro::TMP_InputField::get_onEndTextSelection(
		        TMP_InputField *this,
		        MethodInfo *method)
		{
		  return this->fields.m_OnEndTextSelection;
		}
		
		public SettingParameter<float> csmSplit2 { get; } // 0x0000000184D8DE90-0x0000000184D8DEA0 
		// TMP_InputField+OnChangeEvent get_onValueChanged()
		TMP_InputField_OnChangeEvent *TMPro::TMP_InputField::get_onValueChanged(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnValueChanged;
		}
		
		public SettingParameter<float> csmSplit3 { get; } // 0x0000000184D8DF10-0x0000000184D8DF20 
		// TMP_InputField+TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged()
		TMP_InputField_TouchScreenKeyboardEvent *TMPro::TMP_InputField::get_onTouchScreenKeyboardStatusChanged(
		        TMP_InputField *this,
		        MethodInfo *method)
		{
		  return this->fields.m_OnTouchScreenKeyboardStatusChanged;
		}
		
		public SettingParameter<bool> csmUseShadowmapCache { get; } // 0x0000000184D8DB90-0x0000000184D8DBA0 
		// TMP_InputField+OnValidateInput get_onValidateInput()
		TMP_InputField_OnValidateInput *TMPro::TMP_InputField::get_onValidateInput(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnValidateInput;
		}
		
		public SettingParameter<int> csmCachedFrame0 { get; } // 0x0000000184D8DD90-0x0000000184D8DDA0 
		// UnityEvent get_onFocused()
		UnityEvent *TMPro::TMP_InputField::get_onFocused(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_OnFocused;
		}
		
		public SettingParameter<int> csmCachedFrame1 { get; } // 0x0000000184D8D820-0x0000000184D8D830 
		// DisposedUnityEvent get_bindingViewUpdateEvent()
		DisposedUnityEvent *Beyond::UI::UIMultiSelectDropdown::get_bindingViewUpdateEvent(
		        UIMultiSelectDropdown *this,
		        MethodInfo *method)
		{
		  return this->fields._bindingViewUpdateEvent_k__BackingField;
		}
		
		public SettingParameter<int> csmCachedFrame2 { get; } // 0x0000000184D8D800-0x0000000184D8D810 
		// ButtonControl get_rightTriggerButton()
		ButtonControl *UnityEngine::InputSystem::DualShock::DualShock3GamepadHID::get_rightTriggerButton(
		        DualShock3GamepadHID *this,
		        MethodInfo *method)
		{
		  return this->fields._._optionsButton_k__BackingField;
		}
		
		public SettingParameter<int> csmCachedFrame3 { get; } // 0x0000000184D8DA30-0x0000000184D8DA40 
		// DisposedUnityEvent get_bindingViewUpdateEvent()
		DisposedUnityEvent *Beyond::UI::UIButton::get_bindingViewUpdateEvent(UIButton *this, MethodInfo *method)
		{
		  return this->fields._bindingViewUpdateEvent_k__BackingField;
		}
		
		public SettingParameter<float> csmScreenSizeMin0 { get; } // 0x0000000184D8DE00-0x0000000184D8DE10 
		// SettingParameter`1[System.Single] get_csmScreenSizeMin0()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmScreenSizeMin0(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmScreenSizeMin0_k__BackingField;
		}
		
		public SettingParameter<float> csmScreenSizeMin1 { get; } // 0x0000000184D8D920-0x0000000184D8D930 
		// SettingParameter`1[System.Single] get_csmScreenSizeMin1()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmScreenSizeMin1(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmScreenSizeMin1_k__BackingField;
		}
		
		public SettingParameter<float> csmScreenSizeMin2 { get; } // 0x0000000184D8DEA0-0x0000000184D8DEB0 
		// String get_text()
		String *TMPro::TMP_InputField::get_text(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_Text;
		}
		
		public SettingParameter<float> csmScreenSizeMin3 { get; } // 0x0000000184D8DEB0-0x0000000184D8DEC0 
		// SettingParameter`1[System.Single] get_csmScreenSizeMin3()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmScreenSizeMin3(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmScreenSizeMin3_k__BackingField;
		}
		
		public SettingParameter<bool> csmEnableOcclusionCulling0 { get; } // 0x0000000184D8DB30-0x0000000184D8DB40 
		// SettingParameter`1[System.Boolean] get_csmEnableOcclusionCulling0()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_csmEnableOcclusionCulling0(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmEnableOcclusionCulling0_k__BackingField;
		}
		
		public SettingParameter<bool> csmEnableOcclusionCulling1 { get; } // 0x0000000184D8DB10-0x0000000184D8DB20 
		// YogaNode get_yogaNode()
		YogaNode *UnityEngine::UIElements::VisualElement::get_yogaNode(VisualElement *this, MethodInfo *method)
		{
		  return this->fields._yogaNode_k__BackingField;
		}
		
		public SettingParameter<bool> csmEnableOcclusionCulling2 { get; } // 0x0000000184D8DB00-0x0000000184D8DB10 
		// SettingParameter`1[System.Boolean] get_csmEnableOcclusionCulling2()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_csmEnableOcclusionCulling2(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmEnableOcclusionCulling2_k__BackingField;
		}
		
		public SettingParameter<bool> csmEnableOcclusionCulling3 { get; } // 0x0000000184D8DC10-0x0000000184D8DC20 
		// SettingParameter`1[System.Boolean] get_csmEnableOcclusionCulling3()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_csmEnableOcclusionCulling3(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmEnableOcclusionCulling3_k__BackingField;
		}
		
		public SettingParameter<int> csmOcclusionDepthSize { get; } // 0x0000000184D8DDB0-0x0000000184D8DDC0 
		// SettingParameter`1[System.Int32] get_csmOcclusionDepthSize()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_csmOcclusionDepthSize(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmOcclusionDepthSize_k__BackingField;
		}
		
		public SettingParameter<int> csmStopRenderCharacterCascade { get; } // 0x0000000184D8D970-0x0000000184D8D980 
		// SettingParameter`1[System.Int32] get_csmStopRenderCharacterCascade()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_csmStopRenderCharacterCascade(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmStopRenderCharacterCascade_k__BackingField;
		}
		
		public SettingParameter<float> csmNearPlaneOffset { get; } // 0x0000000184D8D9D0-0x0000000184D8D9E0 
		// SettingParameter`1[System.Single] get_csmNearPlaneOffset()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmNearPlaneOffset(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmNearPlaneOffset_k__BackingField;
		}
		
		public SettingParameter<float> csmHardwareBias { get; } // 0x0000000184D8D9E0-0x0000000184D8D9F0 
		// SettingParameter`1[System.Single] get_csmHardwareBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmHardwareBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmHardwareBias_k__BackingField;
		}
		
		public SettingParameter<float> csmHardwareNormalBias { get; } // 0x0000000184D8DC60-0x0000000184D8DC70 
		// SettingParameter`1[System.Single] get_csmHardwareNormalBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_csmHardwareNormalBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._csmHardwareNormalBias_k__BackingField;
		}
		
		public SettingParameter<bool> characterShadowEnabled { get; } // 0x0000000184D8DA70-0x0000000184D8DA80 
		// SettingParameter`1[System.Boolean] get_characterShadowEnabled()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowEnabled(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowEnabled_k__BackingField;
		}
		
		public SettingParameter<int> characterShadowMapResolution { get; } // 0x0000000184D8DDA0-0x0000000184D8DDB0 
		// SettingParameter`1[System.Int32] get_characterShadowMapResolution()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowMapResolution(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowMapResolution_k__BackingField;
		}
		
		public SettingParameter<float> characterShadowHardwareBias { get; } // 0x0000000184D8DDC0-0x0000000184D8DDD0 
		// SettingParameter`1[System.Single] get_characterShadowHardwareBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowHardwareBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowHardwareBias_k__BackingField;
		}
		
		public SettingParameter<float> characterShadowHardwareNormalBias { get; } // 0x0000000184D8D830-0x0000000184D8D840 
		// SettingParameter`1[System.Single] get_characterShadowHardwareNormalBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowHardwareNormalBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowHardwareNormalBias_k__BackingField;
		}
		
		public SettingParameter<float> characterShadowShaderBias { get; } // 0x0000000184D8D7D0-0x0000000184D8D7E0 
		// SettingParameter`1[System.Single] get_characterShadowShaderBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowShaderBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowShaderBias_k__BackingField;
		}
		
		public SettingParameter<float> characterShadowShaderNormalBias { get; } // 0x0000000184D8DEC0-0x0000000184D8DED0 
		// SettingParameter`1[System.Single] get_characterShadowShaderNormalBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_characterShadowShaderNormalBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._characterShadowShaderNormalBias_k__BackingField;
		}
		
		public SettingParameter<bool> punctualLightShadowEnabled { get; } // 0x0000000184D8D9F0-0x0000000184D8DA00 
		// SettingParameter`1[System.Boolean] get_punctualLightShadowEnabled()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_punctualLightShadowEnabled(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._punctualLightShadowEnabled_k__BackingField;
		}
		
		public SettingParameter<int> punctualLightTileMaxSize { get; } // 0x0000000184D8DB60-0x0000000184D8DB70 
		// SettingParameter`1[System.Int32] get_punctualLightTileMaxSize()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_punctualLightTileMaxSize(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._punctualLightTileMaxSize_k__BackingField;
		}
		
		public SettingParameter<float> punctualLightForceCullDistance { get; } // 0x0000000184D8DE30-0x0000000184D8DE40 
		// Action`1[UnityEngine.UIElements.MeshGenerationContext] get_generateVisualContent()
		Action_1_UnityEngine_UIElements_MeshGenerationContext_ *UnityEngine::UIElements::VisualElement::get_generateVisualContent(
		        VisualElement *this,
		        MethodInfo *method)
		{
		  return this->fields._generateVisualContent_k__BackingField;
		}
		
		public SettingParameter<int> punctualLightEnvDynamicCasterCount { get; } // 0x0000000184D8DBA0-0x0000000184D8DBB0 
		// SettingParameter`1[System.Int32] get_punctualLightEnvDynamicCasterCount()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_punctualLightEnvDynamicCasterCount(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._punctualLightEnvDynamicCasterCount_k__BackingField;
		}
		
		public SettingParameter<int> punctualLightMovableDynamicCasterCount { get; } // 0x0000000184D8DF30-0x0000000184D8DF40 
		// SettingParameter`1[System.Int32] get_punctualLightMovableDynamicCasterCount()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_punctualLightMovableDynamicCasterCount(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._punctualLightMovableDynamicCasterCount_k__BackingField;
		}
		
		public SettingParameter<float> punctualLightShadowScreenSizeMin { get; } // 0x0000000184D8D990-0x0000000184D8D9A0 
		// SettingParameter`1[System.Single] get_punctualLightShadowScreenSizeMin()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_punctualLightShadowScreenSizeMin(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._punctualLightShadowScreenSizeMin_k__BackingField;
		}
		
		public SettingParameter<bool> hdplsCharacterShadowEnabled { get; } // 0x0000000184D8D980-0x0000000184D8D990 
		// SettingParameter`1[System.Boolean] get_hdplsCharacterShadowEnabled()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_hdplsCharacterShadowEnabled(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._hdplsCharacterShadowEnabled_k__BackingField;
		}
		
		public SettingParameter<int> hdplsAtlasHeight { get; } // 0x0000000184D8DBB0-0x0000000184D8DBC0 
		// VisualElement+Hierarchy get_hierarchy()
		VisualElement_Hierarchy UnityEngine::UIElements::VisualElement::get_hierarchy(VisualElement *this, MethodInfo *method)
		{
		  return (VisualElement_Hierarchy)this->fields._hierarchy_k__BackingField.m_Owner;
		}
		
		public SettingParameter<bool> hdplsScreenSpaceReduceResolution { get; } // 0x0000000184D8DD00-0x0000000184D8DD10 
		// TMP_InputValidator get_inputValidator()
		TMP_InputValidator *TMPro::TMP_InputField::get_inputValidator(TMP_InputField *this, MethodInfo *method)
		{
		  return this->fields.m_InputValidator;
		}
		
		public SettingParameter<float> hdplsDepthBias { get; } // 0x0000000184D8DCF0-0x0000000184D8DD00 
		// SettingParameter`1[System.Single] get_hdplsDepthBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_hdplsDepthBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._hdplsDepthBias_k__BackingField;
		}
		
		public SettingParameter<float> hdplsNormalBias { get; } // 0x0000000184D8D7F0-0x0000000184D8D800 
		// SettingParameter`1[System.Single] get_hdplsNormalBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_hdplsNormalBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._hdplsNormalBias_k__BackingField;
		}
		
		public SettingParameter<float> hdplsSoftness { get; } // 0x0000000184D8DD80-0x0000000184D8DD90 
		// GameObject get_localMultiPlayerRoot()
		GameObject *UnityEngine::InputSystem::UI::InputSystemUIInputModule::get_localMultiPlayerRoot(
		        InputSystemUIInputModule *this,
		        MethodInfo *method)
		{
		  return this->fields.m_LocalMultiPlayerRoot;
		}
		
		public SettingParameter<bool> asmEnabled { get; } // 0x0000000184D86FC0-0x0000000184D86FD0 
		// VirtualMeshContainer get_ProxyMeshContainer()
		VirtualMeshContainer *BeyondDynamicBone::ClothProcess::get_ProxyMeshContainer(ClothProcess *this, MethodInfo *method)
		{
		  return this->fields._ProxyMeshContainer_k__BackingField;
		}
		
		public SettingParameter<int> asmShadowMapTileResolution { get; } // 0x0000000184D8DE60-0x0000000184D8DE70 
		// SettingParameter`1[System.Int32] get_asmShadowMapTileResolution()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_asmShadowMapTileResolution(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._asmShadowMapTileResolution_k__BackingField;
		}
		
		public SettingParameter<float> asmMaxDistance { get; } // 0x0000000184D8DE50-0x0000000184D8DE60 
		// SettingParameter`1[System.Single] get_asmMaxDistance()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_asmMaxDistance(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._asmMaxDistance_k__BackingField;
		}
		
		public SettingParameter<int> asmMaxTileRenderCountPerFrame { get; } // 0x0000000184D8D780-0x0000000184D8D790 
		// SettingParameter`1[System.Int32] get_asmMaxTileRenderCountPerFrame()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_asmMaxTileRenderCountPerFrame(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._asmMaxTileRenderCountPerFrame_k__BackingField;
		}
		
		public SettingParameter<float> asmDepthBias { get; } // 0x0000000184D8DAB0-0x0000000184D8DAC0 
		// SettingParameter`1[System.Single] get_asmDepthBias()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_asmDepthBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._asmDepthBias_k__BackingField;
		}
		
		public SettingParameter<float> asmNormalBias { get; } // 0x0000000184D8DC00-0x0000000184D8DC10 
		// VisualElement get_dragArea()
		VisualElement *UnityEngine::UIElements::Internal::MultiColumnHeaderColumnResizeHandle::get_dragArea(
		        MultiColumnHeaderColumnResizeHandle *this,
		        MethodInfo *method)
		{
		  return this->fields._dragArea_k__BackingField;
		}
		
		public SettingParameter<float> asmScreenSizeMin { get; } // 0x0000000184D8DC40-0x0000000184D8DC50 
		// VisualElement get_content()
		VisualElement *UnityEngine::UIElements::Internal::MultiColumnHeaderColumn::get_content(
		        MultiColumnHeaderColumn *this,
		        MethodInfo *method)
		{
		  return this->fields.m_Content;
		}
		
		public SettingParameter<bool> shadowDecalProjectorEnabled { get; } // 0x0000000184D8DC20-0x0000000184D8DC30 
		// SortColumnDescriptions get_sortDescriptions()
		SortColumnDescriptions *UnityEngine::UIElements::Internal::MultiColumnCollectionHeader::get_sortDescriptions(
		        MultiColumnCollectionHeader *this,
		        MethodInfo *method)
		{
		  return this->fields.m_SortDescriptions;
		}
		
		public SettingParameter<int> shadowDecalProjectorMaxCount { get; } // 0x0000000184D8D950-0x0000000184D8D960 
		// VisualElement get_flexedPane()
		VisualElement *UnityEngine::UIElements::TwoPaneSplitView::get_flexedPane(TwoPaneSplitView *this, MethodInfo *method)
		{
		  return this->fields.m_FlexedPane;
		}
		
		public SettingParameter<bool> visSHEnabled { get; } // 0x0000000184D8DE20-0x0000000184D8DE30 
		// Clickable get_clickable()
		Clickable *UnityEngine::UIElements::Internal::MultiColumnHeaderColumn::get_clickable(
		        MultiColumnHeaderColumn *this,
		        MethodInfo *method)
		{
		  return this->fields._clickable_k__BackingField;
		}
		
		public SettingParameter<float> visSHSphereIntervalScale { get; } // 0x0000000184D8DA00-0x0000000184D8DA10 
		// ColumnMover get_mover()
		ColumnMover *UnityEngine::UIElements::Internal::MultiColumnHeaderColumn::get_mover(
		        MultiColumnHeaderColumn *this,
		        MethodInfo *method)
		{
		  return this->fields._mover_k__BackingField;
		}
		
		public SettingParameter<float> visSHSphereRangeScale { get; } // 0x0000000184D8DD30-0x0000000184D8DD40 
		// Label get_labelElement()
		Label *UnityEngine::UIElements::BaseField<UnityEngine::Vector2>::get_labelElement(
		        BaseField_1_UnityEngine_Vector2_ *this,
		        MethodInfo *method)
		{
		  return this->fields._labelElement_k__BackingField;
		}
		
		public SettingParameter<bool> visSHHalfRez { get; } // 0x0000000184D8DD40-0x0000000184D8DD50 
		// Dictionary`2[UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ColumnData] get_columnDataMap()
		Dictionary_2_UnityEngine_UIElements_Column_UnityEngine_UIElements_Internal_MultiColumnCollectionHeader_ColumnData_ *UnityEngine::UIElements::Internal::MultiColumnCollectionHeader::get_columnDataMap(
		        MultiColumnCollectionHeader *this,
		        MethodInfo *method)
		{
		  return this->fields._columnDataMap_k__BackingField;
		}
		
		public SettingParameter<bool> visSHUseTileRendering { get; } // 0x0000000184D8D7C0-0x0000000184D8D7D0 
		// TextEditorEventHandler get_editorEventHandler()
		TextEditorEventHandler *UnityEngine::UIElements::TextInputBaseField_1_TValueType_::TextInputBase<System::Object>::get_editorEventHandler(
		        TextInputBaseField_1_TValueType_TextInputBase_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._editorEventHandler_k__BackingField;
		}
		
		public SettingParameter<int> visSHTileSize { get; } // 0x0000000184D8D770-0x0000000184D8D780 
		// TextEditorEngine get_editorEngine()
		TextEditorEngine *UnityEngine::UIElements::TextInputBaseField_1_TValueType_::TextInputBase<System::Object>::get_editorEngine(
		        TextInputBaseField_1_TValueType_TextInputBase_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._editorEngine_k__BackingField;
		}
		
		public SettingParameter<bool> transientGBuffer { get; } // 0x0000000184D8DD20-0x0000000184D8DD30 
		// VisualElement get_resizeHandleContainer()
		VisualElement *UnityEngine::UIElements::Internal::MultiColumnCollectionHeader::get_resizeHandleContainer(
		        MultiColumnCollectionHeader *this,
		        MethodInfo *method)
		{
		  return this->fields._resizeHandleContainer_k__BackingField;
		}
		
		public SettingParameter<DepthBits> depthBitsGBuffer { get; } // 0x0000000184D8D9B0-0x0000000184D8D9C0 
		// VisualElement get_dragContainer()
		VisualElement *UnityEngine::UIElements::BaseSlider<float>::get_dragContainer(
		        BaseSlider_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields._dragContainer_k__BackingField;
		}
		
		public SettingParameter<bool> depthCombinedWithStencil { get; } // 0x0000000184D8DF20-0x0000000184D8DF30 
		// TextInputBaseField`1[TValueType]+TextInputBase[System.Object] get_textInputBase()
		TextInputBaseField_1_TValueType_TextInputBase_System_Object_ *UnityEngine::UIElements::TextInputBaseField<System::Object>::get_textInputBase(
		        TextInputBaseField_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_TextInputBase;
		}
		
		public SettingParameter<float> copySceneRTScale { get; } // 0x0000000184D8DC50-0x0000000184D8DC60 
		// VisualElement get_dragBorderElement()
		VisualElement *UnityEngine::UIElements::BaseSlider<float>::get_dragBorderElement(
		        BaseSlider_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields._dragBorderElement_k__BackingField;
		}
		
		public SettingParameter<int> taauResolveResolutionHeight { get; } // 0x0000000184D8DCA0-0x0000000184D8DCB0 
		// TextField get_inputTextField()
		TextField *UnityEngine::UIElements::BaseSlider<float>::get_inputTextField(
		        BaseSlider_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields._inputTextField_k__BackingField;
		}
		
		public SettingParameter<float> renderingScale { get; } // 0x0000000184D8DD70-0x0000000184D8DD80 
		// ScrollView get_scrollView()
		ScrollView *UnityEngine::UIElements::BaseVerticalCollectionView::get_scrollView(
		        BaseVerticalCollectionView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_ScrollView;
		}
		
		public SettingParameter<int> backBufferResolutionHeight { get; } // 0x0000000184D8D860-0x0000000184D8D870 
		// CollectionViewController get_viewController()
		CollectionViewController *UnityEngine::UIElements::BaseVerticalCollectionView::get_viewController(
		        BaseVerticalCollectionView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_ViewController;
		}
		
		public SettingParameter<bool> textureStreamingEnable { get; } // 0x0000000184D8DBE0-0x0000000184D8DBF0 
		// ClampedDragger`1[System.Single] get_clampedDragger()
		ClampedDragger_1_System_Single_ *UnityEngine::UIElements::BaseSlider<float>::get_clampedDragger(
		        BaseSlider_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields._clampedDragger_k__BackingField;
		}
		
		public SettingParameter<int> textureStreamingBudget { get; } // 0x0000000184D8DBD0-0x0000000184D8DBE0 
		// ClampedDragger`1[System.Object] get_clampedDragger()
		ClampedDragger_1_System_Object_ *UnityEngine::UIElements::BaseSlider<System::Object>::get_clampedDragger(
		        BaseSlider_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._clampedDragger_k__BackingField;
		}
		
		public SettingParameter<int> textureStreamingMaxBudget { get; } // 0x0000000184D8D8D0-0x0000000184D8D8E0 
		// SettingParameter`1[System.Int32] get_textureStreamingMaxBudget()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureStreamingMaxBudget(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureStreamingMaxBudget_k__BackingField;
		}
		
		public SettingParameter<int> reservedMemoryForNonTextureStreaming { get; } // 0x0000000184D8D9A0-0x0000000184D8D9B0 
		// SettingParameter`1[System.Int32] get_reservedMemoryForNonTextureStreaming()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_reservedMemoryForNonTextureStreaming(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reservedMemoryForNonTextureStreaming_k__BackingField;
		}
		
		public SettingParameter<float> textureStreamingMobileBudgetPercent { get; } // 0x0000000184D8DCB0-0x0000000184D8DCC0 
		// SettingParameter`1[System.Single] get_textureStreamingMobileBudgetPercent()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_textureStreamingMobileBudgetPercent(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureStreamingMobileBudgetPercent_k__BackingField;
		}
		
		public SettingParameter<int> textureStreamingRendererPerFrame { get; } // 0x0000000184D8DB80-0x0000000184D8DB90 
		// SettingParameter`1[System.Int32] get_textureStreamingRendererPerFrame()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureStreamingRendererPerFrame(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureStreamingRendererPerFrame_k__BackingField;
		}
		
		public SettingParameter<int> textureStreamingMaxFileIORequests { get; } // 0x0000000184D8DB40-0x0000000184D8DB50 
		// ListViewDragger get_dragger()
		ListViewDragger *UnityEngine::UIElements::BaseVerticalCollectionView::get_dragger(
		        BaseVerticalCollectionView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_Dragger;
		}
		
		public SettingParameter<int> textureQuality6GB { get; } // 0x0000000184D8DB20-0x0000000184D8DB30 
		// SettingParameter`1[System.Int32] get_textureQuality6GB()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureQuality6GB(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureQuality6GB_k__BackingField;
		}
		
		public SettingParameter<int> textureQuality8GB { get; } // 0x0000000184D8DB50-0x0000000184D8DB60 
		// SettingParameter`1[System.Int32] get_textureQuality8GB()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureQuality8GB(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureQuality8GB_k__BackingField;
		}
		
		public SettingParameter<int> textureQuality10GB { get; } // 0x0000000184D8DC30-0x0000000184D8DC40 
		// InputSettings get_settings()
		InputSettings *UnityEngine::InputSystem::InputManager::get_settings(InputManager_1 *this, MethodInfo *method)
		{
		  return this->fields.m_Settings;
		}
		
		public SettingParameter<int> textureQuality12GB { get; } // 0x0000000184D8DBC0-0x0000000184D8DBD0 
		// SettingParameter`1[System.Int32] get_textureQuality12GB()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureQuality12GB(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureQuality12GB_k__BackingField;
		}
		
		public SettingParameter<int> textureQuality16GB { get; } // 0x0000000184D8DDE0-0x0000000184D8DDF0 
		// SettingParameter`1[System.Int32] get_textureQuality16GB()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_textureQuality16GB(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._textureQuality16GB_k__BackingField;
		}
		
		public SettingParameter<bool> contactShadowEnableParam { get; } // 0x0000000184D8D880-0x0000000184D8D890 
		// SettingParameter`1[System.Boolean] get_contactShadowEnableParam()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_contactShadowEnableParam(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._contactShadowEnableParam_k__BackingField;
		}
		
		public SettingParameter<bool> gtaoEnable { get; } // 0x0000000184D8DDD0-0x0000000184D8DDE0 
		// List`1[System.Int32] get_expandedItemIds()
		List_1_System_Int32_ *UnityEngine::UIElements::BaseTreeView::get_expandedItemIds(
		        BaseTreeView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_ExpandedItemIds;
		}
		
		public SettingParameter<int> gtaoQualityLevel { get; } // 0x0000000184D8DA50-0x0000000184D8DA60 
		// Columns get_columns()
		Columns *UnityEngine::UIElements::MultiColumnTreeView::get_columns(MultiColumnTreeView *this, MethodInfo *method)
		{
		  return this->fields.m_Columns;
		}
		
		public SettingParameter<bool> ssrEnable { get; } // 0x0000000184D8DE40-0x0000000184D8DE50 
		// Action`2[UnityEngine.UIElements.VisualElement,Int32] get_bindItem()
		Action_2_UnityEngine_UIElements_VisualElement_Int32_ *UnityEngine::UIElements::TreeView::get_bindItem(
		        TreeView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_BindItem;
		}
		
		public SettingParameter<int> ssrRayMarchingSampleCount { get; } // 0x0000000184D8DAF0-0x0000000184D8DB00 
		// SortColumnDescriptions get_sortColumnDescriptions()
		SortColumnDescriptions *UnityEngine::UIElements::MultiColumnTreeView::get_sortColumnDescriptions(
		        MultiColumnTreeView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_SortColumnDescriptions;
		}
		
		public SettingParameter<bool> ssrImportanceSample { get; } // 0x0000000184D8D7A0-0x0000000184D8D7B0 
		// Action`1[UnityEngine.UIElements.VisualElement] get_destroyItem()
		Action_1_UnityEngine_UIElements_VisualElement_ *UnityEngine::UIElements::TreeView::get_destroyItem(
		        TreeView *this,
		        MethodInfo *method)
		{
		  return this->fields._destroyItem_k__BackingField;
		}
		
		public SettingParameter<bool> ssrV2 { get; } // 0x0000000184D8D940-0x0000000184D8D950 
		// SettingParameter`1[System.Boolean] get_ssrV2()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_ssrV2(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._ssrV2_k__BackingField;
		}
		
		public SettingParameter<bool> ssrV2Upsample { get; } // 0x0000000184D8D850-0x0000000184D8D860 
		// SettingParameter`1[System.Boolean] get_ssrV2Upsample()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_ssrV2Upsample(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._ssrV2Upsample_k__BackingField;
		}
		
		public SettingParameter<bool> fakePlanarReflectionEnable { get; } // 0x0000000184D8D900-0x0000000184D8D910 
		// SettingParameter`1[System.Boolean] get_fakePlanarReflectionEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_fakePlanarReflectionEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._fakePlanarReflectionEnable_k__BackingField;
		}
		
		public SettingParameter<bool> terrainFallbackGBuffer { get; } // 0x0000000184D8D7E0-0x0000000184D8D7F0 
		// VisualElement get_footer()
		VisualElement *UnityEngine::UIElements::BaseListView::get_footer(BaseListView *this, MethodInfo *method)
		{
		  return this->fields.m_Footer;
		}
		
		public SettingParameter<int> terrainLODFactor { get; } // 0x0000000184D8DD10-0x0000000184D8DD20 
		// SettingParameter`1[System.Int32] get_terrainLODFactor()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_terrainLODFactor(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainLODFactor_k__BackingField;
		}
		
		public SettingParameter<bool> terrainIndirectionCPUUpload { get; } // 0x0000000184D8DBF0-0x0000000184D8DC00 
		// SettingParameter`1[System.Boolean] get_terrainIndirectionCPUUpload()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_terrainIndirectionCPUUpload(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainIndirectionCPUUpload_k__BackingField;
		}
		
		public SettingParameter<bool> terrainSplitNormalRO { get; } // 0x0000000184D8DB70-0x0000000184D8DB80 
		// SettingParameter`1[System.Boolean] get_terrainSplitNormalRO()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_terrainSplitNormalRO(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainSplitNormalRO_k__BackingField;
		}
		
		public SettingParameter<bool> terrainCompressUseBuffer { get; } // 0x0000000184D8DCC0-0x0000000184D8DCD0 
		// SettingParameter`1[System.Boolean] get_terrainCompressUseBuffer()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_terrainCompressUseBuffer(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainCompressUseBuffer_k__BackingField;
		}
		
		public SettingParameter<bool> terrainPOM { get; } // 0x0000000184D8DCD0-0x0000000184D8DCE0 
		// SettingParameter`1[System.Boolean] get_terrainPOM()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_terrainPOM(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainPOM_k__BackingField;
		}
		
		public HGTerrainDeformSettingParameters terrainDeform { get; } // 0x0000000184D8DC80-0x0000000184D8DC90 
		// HGTerrainDeformSettingParameters get_terrainDeform()
		HGTerrainDeformSettingParameters *HG::Rendering::Runtime::HGSettingParameters::get_terrainDeform(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._terrainDeform_k__BackingField;
		}
		
		public HGVolumetricCloudSettingParameters volumetricCloud { get; } // 0x0000000184D8DAA0-0x0000000184D8DAB0 
		// HGVolumetricCloudSettingParameters get_volumetricCloud()
		HGVolumetricCloudSettingParameters *HG::Rendering::Runtime::HGSettingParameters::get_volumetricCloud(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._volumetricCloud_k__BackingField;
		}
		
		public HGErosionBlendSettingParameters erosionBlend { get; } // 0x0000000184D8DE10-0x0000000184D8DE20 
		// HGErosionBlendSettingParameters get_erosionBlend()
		HGErosionBlendSettingParameters *HG::Rendering::Runtime::HGSettingParameters::get_erosionBlend(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._erosionBlend_k__BackingField;
		}
		
		public HGLightShaftSettingParameters lightShaft { get; } // 0x0000000184DA1A10-0x0000000184DA1A20 
		// Columns get_columns()
		Columns *UnityEngine::UIElements::MultiColumnListView::get_columns(MultiColumnListView *this, MethodInfo *method)
		{
		  return this->fields.m_Columns;
		}
		
		public HGRainAndWetnessSettingParameters rainAndWetness { get; } // 0x0000000184D90280-0x0000000184D90290 
		// Action`2[UnityEngine.UIElements.VisualElement,Int32] get_bindItem()
		Action_2_UnityEngine_UIElements_VisualElement_Int32_ *UnityEngine::UIElements::ListView::get_bindItem(
		        ListView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_BindItem;
		}
		
		public HGSnowSettingParameters snow { get; } // 0x0000000184D90290-0x0000000184D902A0 
		// SortColumnDescriptions get_sortColumnDescriptions()
		SortColumnDescriptions *UnityEngine::UIElements::MultiColumnListView::get_sortColumnDescriptions(
		        MultiColumnListView *this,
		        MethodInfo *method)
		{
		  return this->fields.m_SortColumnDescriptions;
		}
		
		public HGVerticalOcclusionMapSettingParameters verticalOcclusionMap { get; } // 0x0000000184DA1BB0-0x0000000184DA1BC0 
		// Action`1[UnityEngine.UIElements.VisualElement] get_destroyItem()
		Action_1_UnityEngine_UIElements_VisualElement_ *UnityEngine::UIElements::ListView::get_destroyItem(
		        ListView *this,
		        MethodInfo *method)
		{
		  return this->fields._destroyItem_k__BackingField;
		}
		
		public HGAtmosphereSettingParameters atmosphereParams { get; } // 0x0000000184DA1980-0x0000000184DA1990 
		// HGAtmosphereSettingParameters get_atmosphereParams()
		HGAtmosphereSettingParameters *HG::Rendering::Runtime::HGSettingParameters::get_atmosphereParams(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._atmosphereParams_k__BackingField;
		}
		
		public SettingParameter<float> waterPrepassTextureSize { get; } // 0x0000000184DA1C50-0x0000000184DA1C60 
		// SettingParameter`1[System.Single] get_waterPrepassTextureSize()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_waterPrepassTextureSize(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterPrepassTextureSize_k__BackingField;
		}
		
		public SettingParameter<bool> waterInteractiveEnable { get; } // 0x0000000184DA1C10-0x0000000184DA1C20 
		// SettingParameter`1[System.Boolean] get_waterInteractiveEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_waterInteractiveEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterInteractiveEnable_k__BackingField;
		}
		
		public SettingParameter<bool> waterIndirectEnable { get; } // 0x0000000184DA1C00-0x0000000184DA1C10 
		// SettingParameter`1[System.Boolean] get_waterIndirectEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_waterIndirectEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterIndirectEnable_k__BackingField;
		}
		
		public SettingParameter<bool> waterUseAnchorSH { get; } // 0x0000000184DA1C70-0x0000000184DA1C80 
		// SettingParameter`1[System.Boolean] get_waterUseAnchorSH()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_waterUseAnchorSH(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterUseAnchorSH_k__BackingField;
		}
		
		public SettingParameter<int> waterVRRx { get; } // 0x0000000184DA1C80-0x0000000184DA1C90 
		// SettingParameter`1[System.Int32] get_waterVRRx()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterVRRx(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterVRRx_k__BackingField;
		}
		
		public SettingParameter<int> waterVRRy { get; } // 0x0000000184DA1C90-0x0000000184DA1CA0 
		// SettingParameter`1[System.Int32] get_waterVRRy()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterVRRy(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterVRRy_k__BackingField;
		}
		
		public SettingParameter<float> waterDisplacementWeight { get; } // 0x0000000184DA1BD0-0x0000000184DA1BE0 
		// SettingParameter`1[System.Single] get_waterDisplacementWeight()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_waterDisplacementWeight(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterDisplacementWeight_k__BackingField;
		}
		
		public SettingParameter<float> waterDisplacementDistance { get; } // 0x0000000184DA1BC0-0x0000000184DA1BD0 
		// SettingParameter`1[System.Single] get_waterDisplacementDistance()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_waterDisplacementDistance(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterDisplacementDistance_k__BackingField;
		}
		
		public SettingParameter<int> waterHeightTextureSize { get; } // 0x0000000184DA1BF0-0x0000000184DA1C00 
		// SettingParameter`1[System.Int32] get_waterHeightTextureSize()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterHeightTextureSize(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterHeightTextureSize_k__BackingField;
		}
		
		public SettingParameter<int> waterLODNumAdded { get; } // 0x0000000184DA1C20-0x0000000184DA1C30 
		// SettingParameter`1[System.Int32] get_waterLODNumAdded()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterLODNumAdded(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterLODNumAdded_k__BackingField;
		}
		
		public SettingParameter<int> waterMeshNumPerLODAdded { get; } // 0x0000000184DA1C30-0x0000000184DA1C40 
		// SettingParameter`1[System.Int32] get_waterMeshNumPerLODAdded()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterMeshNumPerLODAdded(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterMeshNumPerLODAdded_k__BackingField;
		}
		
		public SettingParameter<int> waterMeshSizeAdded { get; } // 0x0000000184DA1C40-0x0000000184DA1C50 
		// SettingParameter`1[System.Int32] get_waterMeshSizeAdded()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterMeshSizeAdded(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterMeshSizeAdded_k__BackingField;
		}
		
		public SettingParameter<int> waterHeightMapXZAdded { get; } // 0x0000000184DA1BE0-0x0000000184DA1BF0 
		// SettingParameter`1[System.Int32] get_waterHeightMapXZAdded()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_waterHeightMapXZAdded(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterHeightMapXZAdded_k__BackingField;
		}
		
		public SettingParameter<bool> waterSectorRendering { get; } // 0x0000000184DA1C60-0x0000000184DA1C70 
		// SettingParameter`1[System.Boolean] get_waterSectorRendering()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_waterSectorRendering(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._waterSectorRendering_k__BackingField;
		}
		
		public SettingParameter<bool> foliageInteractiveEnable { get; } // 0x0000000184DA1990-0x0000000184DA19A0 
		// SettingParameter`1[System.Boolean] get_foliageInteractiveEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_foliageInteractiveEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._foliageInteractiveEnable_k__BackingField;
		}
		
		public SettingParameter<float> artTagLODBiasAll { get; } // 0x0000000184DA1960-0x0000000184DA1970 
		// SettingParameter`1[System.Single] get_artTagLODBiasAll()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_artTagLODBiasAll(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._artTagLODBiasAll_k__BackingField;
		}
		
		public List<SettingParameter<float>> artTagLODBias { get; } // 0x0000000184DA1970-0x0000000184DA1980 
		// List`1[HG.Rendering.Runtime.SettingParameter`1[System.Single]] get_artTagLODBias()
		List_1_HG_Rendering_Runtime_SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_artTagLODBias(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._artTagLODBias_k__BackingField;
		}
		
		public SettingParameter<bool> shouldSplitOnePass { get; } // 0x0000000184DA1B60-0x0000000184DA1B70 
		// SettingParameter`1[System.Boolean] get_shouldSplitOnePass()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_shouldSplitOnePass(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._shouldSplitOnePass_k__BackingField;
		}
		
		public SettingParameter<bool> reflectionProbeUseRGBAHalf { get; } // 0x0000000184DA1B50-0x0000000184DA1B60 
		// SettingParameter`1[System.Boolean] get_reflectionProbeUseRGBAHalf()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_reflectionProbeUseRGBAHalf(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reflectionProbeUseRGBAHalf_k__BackingField;
		}
		
		public SettingParameter<int> reflectionProbeOctTextureArrayCount { get; } // 0x0000000184DA1B30-0x0000000184DA1B40 
		// SettingParameter`1[System.Int32] get_reflectionProbeOctTextureArrayCount()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_reflectionProbeOctTextureArrayCount(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reflectionProbeOctTextureArrayCount_k__BackingField;
		}
		
		public SettingParameter<int> reflectionProbeOctTextureSize { get; } // 0x0000000184DA1B40-0x0000000184DA1B50 
		// SettingParameter`1[System.Int32] get_reflectionProbeOctTextureSize()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_reflectionProbeOctTextureSize(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reflectionProbeOctTextureSize_k__BackingField;
		}
		
		public SettingParameter<int> reflectionProbeMaxSampleMip { get; } // 0x0000000184DA1B20-0x0000000184DA1B30 
		// SettingParameter`1[System.Int32] get_reflectionProbeMaxSampleMip()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_reflectionProbeMaxSampleMip(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reflectionProbeMaxSampleMip_k__BackingField;
		}
		
		public SettingParameter<int> reflectionProbeMaxBlitCountPerFrame { get; } // 0x0000000184DA1B10-0x0000000184DA1B20 
		// SettingParameter`1[System.Int32] get_reflectionProbeMaxBlitCountPerFrame()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_reflectionProbeMaxBlitCountPerFrame(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._reflectionProbeMaxBlitCountPerFrame_k__BackingField;
		}
		
		public SettingParameter<bool> transparentLowResOffscreenEnable { get; } // 0x0000000184DA1B70-0x0000000184DA1B80 
		// SettingParameter`1[System.Boolean] get_transparentLowResOffscreenEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_transparentLowResOffscreenEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._transparentLowResOffscreenEnable_k__BackingField;
		}
		
		public SettingParameter<bool> transparentLowResVRSEnable { get; } // 0x0000000184DA1B80-0x0000000184DA1B90 
		// SettingParameter`1[System.Boolean] get_transparentLowResVRSEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_transparentLowResVRSEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._transparentLowResVRSEnable_k__BackingField;
		}
		
		public SettingParameter<int> transparentVRRx { get; } // 0x0000000184DA1B90-0x0000000184DA1BA0 
		// SettingParameter`1[System.Int32] get_transparentVRRx()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_transparentVRRx(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._transparentVRRx_k__BackingField;
		}
		
		public SettingParameter<int> transparentVRRy { get; } // 0x0000000184DA1BA0-0x0000000184DA1BB0 
		// SettingParameter`1[System.Int32] get_transparentVRRy()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_transparentVRRy(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._transparentVRRy_k__BackingField;
		}
		
		public SettingParameter<bool> rayTracingReflectionEnable { get; } // 0x0000000184DA1A70-0x0000000184DA1A80 
		// SettingParameter`1[System.Boolean] get_rayTracingReflectionEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionEnable_k__BackingField;
		}
		
		public SettingParameter<int> rayTracingReflectionMode { get; } // 0x0000000184DA1A80-0x0000000184DA1A90 
		// SettingParameter`1[System.Int32] get_rayTracingReflectionMode()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionMode(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionMode_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionSSQuality0 { get; } // 0x0000000184DA1AD0-0x0000000184DA1AE0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionSSQuality0()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionSSQuality0(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionSSQuality0_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionSSQuality1 { get; } // 0x0000000184DA1AE0-0x0000000184DA1AF0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionSSQuality1()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionSSQuality1(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionSSQuality1_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionSSQuality2 { get; } // 0x0000000184DA1AF0-0x0000000184DA1B00 
		// SettingParameter`1[System.Single] get_rayTracingReflectionSSQuality2()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionSSQuality2(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionSSQuality2_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionSSQuality3 { get; } // 0x0000000184DA1B00-0x0000000184DA1B10 
		// SettingParameter`1[System.Single] get_rayTracingReflectionSSQuality3()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionSSQuality3(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionSSQuality3_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionRTQuality0 { get; } // 0x0000000184DA1A90-0x0000000184DA1AA0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionRTQuality0()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionRTQuality0(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionRTQuality0_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionRTQuality1 { get; } // 0x0000000184DA1AA0-0x0000000184DA1AB0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionRTQuality1()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionRTQuality1(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionRTQuality1_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionRTQuality2 { get; } // 0x0000000184DA1AB0-0x0000000184DA1AC0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionRTQuality2()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionRTQuality2(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionRTQuality2_k__BackingField;
		}
		
		public SettingParameter<float> rayTracingReflectionRTQuality3 { get; } // 0x0000000184DA1AC0-0x0000000184DA1AD0 
		// SettingParameter`1[System.Single] get_rayTracingReflectionRTQuality3()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_rayTracingReflectionRTQuality3(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._rayTracingReflectionRTQuality3_k__BackingField;
		}
		
		public SettingParameter<bool> frameInterpolationEnable { get; } // 0x0000000184DA19B0-0x0000000184DA19C0 
		// SettingParameter`1[System.Boolean] get_frameInterpolationEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_frameInterpolationEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._frameInterpolationEnable_k__BackingField;
		}
		
		public SettingParameter<bool> frameInterpolationPause { get; } // 0x0000000184DA19C0-0x0000000184DA19D0 
		// SettingParameter`1[System.Boolean] get_frameInterpolationPause()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_frameInterpolationPause(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._frameInterpolationPause_k__BackingField;
		}
		
		public SettingParameter<FrameInterpolationAlgo> frameInterpolationAlgo { get; } // 0x0000000184DA19A0-0x0000000184DA19B0 
		// SettingParameter`1[UnityEngine.HyperGryphEngineCode.FrameInterpolationAlgo] get_frameInterpolationAlgo()
		SettingParameter_1_UnityEngine_HyperGryphEngineCode_FrameInterpolationAlgo_ *HG::Rendering::Runtime::HGSettingParameters::get_frameInterpolationAlgo(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._frameInterpolationAlgo_k__BackingField;
		}
		
		public SettingParameter<bool> hasWorldUIAfterFrameInterpolation { get; } // 0x0000000184DA19D0-0x0000000184DA19E0 
		// SettingParameter`1[System.Boolean] get_hasWorldUIAfterFrameInterpolation()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_hasWorldUIAfterFrameInterpolation(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._hasWorldUIAfterFrameInterpolation_k__BackingField;
		}
		
		public SettingParameter<float> afmeCameraRotationCosFallbackThreshold { get; } // 0x0000000184DA16A0-0x0000000184DA16B0 
		// SettingParameter`1[System.Single] get_afmeCameraRotationCosFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_afmeCameraRotationCosFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._afmeCameraRotationCosFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> afmeCameraMoveDistanceSqrFallbackThreshold { get; } // 0x0000000184DA1950-0x0000000184DA1960 
		// SettingParameter`1[System.Single] get_afmeCameraMoveDistanceSqrFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_afmeCameraMoveDistanceSqrFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> mfrcCameraRotationCosFallbackThreshold { get; } // 0x0000000184DA1A40-0x0000000184DA1A50 
		// SettingParameter`1[System.Single] get_mfrcCameraRotationCosFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_mfrcCameraRotationCosFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._mfrcCameraRotationCosFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> mfrcCameraMoveDistanceSqrFallbackThreshold { get; } // 0x0000000184DA1A30-0x0000000184DA1A40 
		// SettingParameter`1[System.Single] get_mfrcCameraMoveDistanceSqrFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_mfrcCameraMoveDistanceSqrFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> mfrcGeneralFallbackThreshold { get; } // 0x0000000184DA1A50-0x0000000184DA1A60 
		// SettingParameter`1[System.Single] get_mfrcGeneralFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_mfrcGeneralFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._mfrcGeneralFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> mfrcBrightnessDiffFallbackThreshold { get; } // 0x0000000184DA1A20-0x0000000184DA1A30 
		// SettingParameter`1[System.Single] get_mfrcBrightnessDiffFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_mfrcBrightnessDiffFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._mfrcBrightnessDiffFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<float> mfrcRepeatedPatternFallbackThreshold { get; } // 0x0000000184DA1A60-0x0000000184DA1A70 
		// SettingParameter`1[System.Single] get_mfrcRepeatedPatternFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_mfrcRepeatedPatternFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._mfrcRepeatedPatternFallbackThreshold_k__BackingField;
		}
		
		public SettingParameter<int> inkSimulationResolution { get; } // 0x0000000184DA1A00-0x0000000184DA1A10 
		// SettingParameter`1[System.Int32] get_inkSimulationResolution()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_inkSimulationResolution(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._inkSimulationResolution_k__BackingField;
		}
		
		public SettingParameter<int> inkDensityResolution { get; } // 0x0000000184DA19E0-0x0000000184DA19F0 
		// SettingParameter`1[System.Int32] get_inkDensityResolution()
		SettingParameter_1_System_Int32_ *HG::Rendering::Runtime::HGSettingParameters::get_inkDensityResolution(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._inkDensityResolution_k__BackingField;
		}
		
		public SettingParameter<bool> inkSimulationEnable { get; } // 0x0000000184DA19F0-0x0000000184DA1A00 
		// SettingParameter`1[System.Boolean] get_inkSimulationEnable()
		SettingParameter_1_System_Boolean_ *HG::Rendering::Runtime::HGSettingParameters::get_inkSimulationEnable(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._inkSimulationEnable_k__BackingField;
		}
		
	
		// Constructors
		public HGSettingParameters() {} // 0x00000001836590A0-0x000000018365C660
		// HGSettingParameters()
		void HG::Rendering::Runtime::HGSettingParameters::HGSettingParameters(HGSettingParameters *this, MethodInfo *method)
		{
		  struct HGSettingParameters__Class *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  HGRuntimeGrassQuery_Node *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  HGRuntimeGrassQuery_Node *v31; // rdx
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  HGRuntimeGrassQuery_Node *v34; // rdx
		  HGRuntimeGrassQuery_Node *v35; // r8
		  Int32__Array **v36; // r9
		  HGRuntimeGrassQuery_Node *v37; // rdx
		  HGRuntimeGrassQuery_Node *v38; // r8
		  Int32__Array **v39; // r9
		  HGRuntimeGrassQuery_Node *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  HGRuntimeGrassQuery_Node *v43; // rdx
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  HGRuntimeGrassQuery_Node *v46; // rdx
		  HGRuntimeGrassQuery_Node *v47; // r8
		  Int32__Array **v48; // r9
		  HGRuntimeGrassQuery_Node *v49; // rdx
		  HGRuntimeGrassQuery_Node *v50; // r8
		  Int32__Array **v51; // r9
		  HGRuntimeGrassQuery_Node *v52; // rdx
		  HGRuntimeGrassQuery_Node *v53; // r8
		  Int32__Array **v54; // r9
		  HGRuntimeGrassQuery_Node *v55; // rdx
		  HGRuntimeGrassQuery_Node *v56; // r8
		  Int32__Array **v57; // r9
		  HGRuntimeGrassQuery_Node *v58; // rdx
		  HGRuntimeGrassQuery_Node *v59; // r8
		  Int32__Array **v60; // r9
		  HGRuntimeGrassQuery_Node *v61; // rdx
		  HGRuntimeGrassQuery_Node *v62; // r8
		  Int32__Array **v63; // r9
		  HGRuntimeGrassQuery_Node *v64; // rdx
		  HGRuntimeGrassQuery_Node *v65; // r8
		  Int32__Array **v66; // r9
		  HGRuntimeGrassQuery_Node *v67; // rdx
		  HGRuntimeGrassQuery_Node *v68; // r8
		  Int32__Array **v69; // r9
		  HGRuntimeGrassQuery_Node *v70; // rdx
		  HGRuntimeGrassQuery_Node *v71; // r8
		  Int32__Array **v72; // r9
		  HGRuntimeGrassQuery_Node *v73; // rdx
		  HGRuntimeGrassQuery_Node *v74; // r8
		  Int32__Array **v75; // r9
		  HGRuntimeGrassQuery_Node *v76; // rdx
		  HGRuntimeGrassQuery_Node *v77; // r8
		  Int32__Array **v78; // r9
		  HGRuntimeGrassQuery_Node *v79; // rdx
		  HGRuntimeGrassQuery_Node *v80; // r8
		  Int32__Array **v81; // r9
		  HGRuntimeGrassQuery_Node *v82; // rdx
		  HGRuntimeGrassQuery_Node *v83; // r8
		  Int32__Array **v84; // r9
		  HGRuntimeGrassQuery_Node *v85; // rdx
		  HGRuntimeGrassQuery_Node *v86; // r8
		  Int32__Array **v87; // r9
		  HGRuntimeGrassQuery_Node *v88; // rdx
		  HGRuntimeGrassQuery_Node *v89; // r8
		  Int32__Array **v90; // r9
		  HGRuntimeGrassQuery_Node *v91; // rdx
		  HGRuntimeGrassQuery_Node *v92; // r8
		  Int32__Array **v93; // r9
		  HGRuntimeGrassQuery_Node *v94; // rdx
		  HGRuntimeGrassQuery_Node *v95; // r8
		  Int32__Array **v96; // r9
		  HGRuntimeGrassQuery_Node *v97; // rdx
		  HGRuntimeGrassQuery_Node *v98; // r8
		  Int32__Array **v99; // r9
		  HGRuntimeGrassQuery_Node *v100; // rdx
		  HGRuntimeGrassQuery_Node *v101; // r8
		  Int32__Array **v102; // r9
		  HGRuntimeGrassQuery_Node *v103; // rdx
		  HGRuntimeGrassQuery_Node *v104; // r8
		  Int32__Array **v105; // r9
		  HGRuntimeGrassQuery_Node *v106; // rdx
		  HGRuntimeGrassQuery_Node *v107; // r8
		  Int32__Array **v108; // r9
		  HGRuntimeGrassQuery_Node *v109; // rdx
		  HGRuntimeGrassQuery_Node *v110; // r8
		  Int32__Array **v111; // r9
		  HGRuntimeGrassQuery_Node *v112; // rdx
		  HGRuntimeGrassQuery_Node *v113; // r8
		  Int32__Array **v114; // r9
		  HGRuntimeGrassQuery_Node *v115; // rdx
		  HGRuntimeGrassQuery_Node *v116; // r8
		  Int32__Array **v117; // r9
		  HGRuntimeGrassQuery_Node *v118; // rdx
		  HGRuntimeGrassQuery_Node *v119; // r8
		  Int32__Array **v120; // r9
		  HGRuntimeGrassQuery_Node *v121; // rdx
		  HGRuntimeGrassQuery_Node *v122; // r8
		  Int32__Array **v123; // r9
		  HGRuntimeGrassQuery_Node *v124; // rdx
		  HGRuntimeGrassQuery_Node *v125; // r8
		  Int32__Array **v126; // r9
		  HGRuntimeGrassQuery_Node *v127; // rdx
		  HGRuntimeGrassQuery_Node *v128; // r8
		  Int32__Array **v129; // r9
		  HGRuntimeGrassQuery_Node *v130; // rdx
		  HGRuntimeGrassQuery_Node *v131; // r8
		  Int32__Array **v132; // r9
		  HGRuntimeGrassQuery_Node *v133; // rdx
		  HGRuntimeGrassQuery_Node *v134; // r8
		  Int32__Array **v135; // r9
		  HGRuntimeGrassQuery_Node *v136; // rdx
		  HGRuntimeGrassQuery_Node *v137; // r8
		  Int32__Array **v138; // r9
		  HGRuntimeGrassQuery_Node *v139; // rdx
		  HGRuntimeGrassQuery_Node *v140; // r8
		  Int32__Array **v141; // r9
		  HGRuntimeGrassQuery_Node *v142; // rdx
		  HGRuntimeGrassQuery_Node *v143; // r8
		  Int32__Array **v144; // r9
		  HGRuntimeGrassQuery_Node *v145; // rdx
		  HGRuntimeGrassQuery_Node *v146; // r8
		  Int32__Array **v147; // r9
		  HGRuntimeGrassQuery_Node *v148; // rdx
		  HGRuntimeGrassQuery_Node *v149; // r8
		  Int32__Array **v150; // r9
		  HGRuntimeGrassQuery_Node *v151; // rdx
		  HGRuntimeGrassQuery_Node *v152; // r8
		  Int32__Array **v153; // r9
		  HGRuntimeGrassQuery_Node *v154; // rdx
		  HGRuntimeGrassQuery_Node *v155; // r8
		  Int32__Array **v156; // r9
		  HGRuntimeGrassQuery_Node *v157; // rdx
		  HGRuntimeGrassQuery_Node *v158; // r8
		  Int32__Array **v159; // r9
		  HGRuntimeGrassQuery_Node *v160; // rdx
		  HGRuntimeGrassQuery_Node *v161; // r8
		  Int32__Array **v162; // r9
		  HGRuntimeGrassQuery_Node *v163; // rdx
		  HGRuntimeGrassQuery_Node *v164; // r8
		  Int32__Array **v165; // r9
		  HGRuntimeGrassQuery_Node *v166; // rdx
		  HGRuntimeGrassQuery_Node *v167; // r8
		  Int32__Array **v168; // r9
		  HGRuntimeGrassQuery_Node *v169; // rdx
		  HGRuntimeGrassQuery_Node *v170; // r8
		  Int32__Array **v171; // r9
		  HGRuntimeGrassQuery_Node *v172; // rdx
		  HGRuntimeGrassQuery_Node *v173; // r8
		  Int32__Array **v174; // r9
		  HGRuntimeGrassQuery_Node *v175; // rdx
		  HGRuntimeGrassQuery_Node *v176; // r8
		  Int32__Array **v177; // r9
		  HGRuntimeGrassQuery_Node *v178; // rdx
		  HGRuntimeGrassQuery_Node *v179; // r8
		  Int32__Array **v180; // r9
		  HGRuntimeGrassQuery_Node *v181; // rdx
		  HGRuntimeGrassQuery_Node *v182; // r8
		  Int32__Array **v183; // r9
		  HGRuntimeGrassQuery_Node *v184; // rdx
		  HGRuntimeGrassQuery_Node *v185; // r8
		  Int32__Array **v186; // r9
		  HGRuntimeGrassQuery_Node *v187; // rdx
		  HGRuntimeGrassQuery_Node *v188; // r8
		  Int32__Array **v189; // r9
		  HGRuntimeGrassQuery_Node *v190; // rdx
		  HGRuntimeGrassQuery_Node *v191; // r8
		  Int32__Array **v192; // r9
		  HGRuntimeGrassQuery_Node *v193; // rdx
		  HGRuntimeGrassQuery_Node *v194; // r8
		  Int32__Array **v195; // r9
		  HGRuntimeGrassQuery_Node *v196; // rdx
		  HGRuntimeGrassQuery_Node *v197; // r8
		  Int32__Array **v198; // r9
		  HGRuntimeGrassQuery_Node *v199; // rdx
		  HGRuntimeGrassQuery_Node *v200; // r8
		  Int32__Array **v201; // r9
		  HGRuntimeGrassQuery_Node *v202; // rdx
		  HGRuntimeGrassQuery_Node *v203; // r8
		  Int32__Array **v204; // r9
		  HGRuntimeGrassQuery_Node *v205; // rdx
		  HGRuntimeGrassQuery_Node *v206; // r8
		  Int32__Array **v207; // r9
		  HGRuntimeGrassQuery_Node *v208; // rdx
		  HGRuntimeGrassQuery_Node *v209; // r8
		  Int32__Array **v210; // r9
		  HGRuntimeGrassQuery_Node *v211; // rdx
		  HGRuntimeGrassQuery_Node *v212; // r8
		  Int32__Array **v213; // r9
		  HGRuntimeGrassQuery_Node *v214; // rdx
		  HGRuntimeGrassQuery_Node *v215; // r8
		  Int32__Array **v216; // r9
		  HGRuntimeGrassQuery_Node *v217; // rdx
		  HGRuntimeGrassQuery_Node *v218; // r8
		  Int32__Array **v219; // r9
		  HGRuntimeGrassQuery_Node *v220; // rdx
		  HGRuntimeGrassQuery_Node *v221; // r8
		  Int32__Array **v222; // r9
		  HGRuntimeGrassQuery_Node *v223; // rdx
		  HGRuntimeGrassQuery_Node *v224; // r8
		  Int32__Array **v225; // r9
		  HGRuntimeGrassQuery_Node *v226; // rdx
		  HGRuntimeGrassQuery_Node *v227; // r8
		  Int32__Array **v228; // r9
		  HGRuntimeGrassQuery_Node *v229; // rdx
		  HGRuntimeGrassQuery_Node *v230; // r8
		  Int32__Array **v231; // r9
		  HGRuntimeGrassQuery_Node *v232; // rdx
		  HGRuntimeGrassQuery_Node *v233; // r8
		  Int32__Array **v234; // r9
		  HGRuntimeGrassQuery_Node *v235; // rdx
		  HGRuntimeGrassQuery_Node *v236; // r8
		  Int32__Array **v237; // r9
		  HGRuntimeGrassQuery_Node *v238; // rdx
		  HGRuntimeGrassQuery_Node *v239; // r8
		  Int32__Array **v240; // r9
		  HGRuntimeGrassQuery_Node *v241; // rdx
		  HGRuntimeGrassQuery_Node *v242; // r8
		  Int32__Array **v243; // r9
		  HGRuntimeGrassQuery_Node *v244; // rdx
		  HGRuntimeGrassQuery_Node *v245; // r8
		  Int32__Array **v246; // r9
		  HGRuntimeGrassQuery_Node *v247; // rdx
		  HGRuntimeGrassQuery_Node *v248; // r8
		  Int32__Array **v249; // r9
		  HGRuntimeGrassQuery_Node *v250; // rdx
		  HGRuntimeGrassQuery_Node *v251; // r8
		  Int32__Array **v252; // r9
		  HGRuntimeGrassQuery_Node *v253; // rdx
		  HGRuntimeGrassQuery_Node *v254; // r8
		  Int32__Array **v255; // r9
		  HGRuntimeGrassQuery_Node *v256; // rdx
		  HGRuntimeGrassQuery_Node *v257; // r8
		  Int32__Array **v258; // r9
		  HGRuntimeGrassQuery_Node *v259; // rdx
		  HGRuntimeGrassQuery_Node *v260; // r8
		  Int32__Array **v261; // r9
		  HGRuntimeGrassQuery_Node *v262; // rdx
		  HGRuntimeGrassQuery_Node *v263; // r8
		  Int32__Array **v264; // r9
		  HGRuntimeGrassQuery_Node *v265; // rdx
		  HGRuntimeGrassQuery_Node *v266; // r8
		  Int32__Array **v267; // r9
		  HGRuntimeGrassQuery_Node *v268; // rdx
		  HGRuntimeGrassQuery_Node *v269; // r8
		  Int32__Array **v270; // r9
		  HGRuntimeGrassQuery_Node *v271; // rdx
		  HGRuntimeGrassQuery_Node *v272; // r8
		  Int32__Array **v273; // r9
		  HGRuntimeGrassQuery_Node *v274; // rdx
		  HGRuntimeGrassQuery_Node *v275; // r8
		  Int32__Array **v276; // r9
		  HGRuntimeGrassQuery_Node *v277; // rdx
		  HGRuntimeGrassQuery_Node *v278; // r8
		  Int32__Array **v279; // r9
		  HGRuntimeGrassQuery_Node *v280; // rdx
		  HGRuntimeGrassQuery_Node *v281; // r8
		  Int32__Array **v282; // r9
		  HGRuntimeGrassQuery_Node *v283; // rdx
		  HGRuntimeGrassQuery_Node *v284; // r8
		  Int32__Array **v285; // r9
		  HGRuntimeGrassQuery_Node *v286; // rdx
		  HGRuntimeGrassQuery_Node *v287; // r8
		  Int32__Array **v288; // r9
		  HGRuntimeGrassQuery_Node *v289; // rdx
		  HGRuntimeGrassQuery_Node *v290; // r8
		  Int32__Array **v291; // r9
		  HGRuntimeGrassQuery_Node *v292; // rdx
		  HGRuntimeGrassQuery_Node *v293; // r8
		  Int32__Array **v294; // r9
		  HGRuntimeGrassQuery_Node *v295; // rdx
		  HGRuntimeGrassQuery_Node *v296; // r8
		  Int32__Array **v297; // r9
		  HGRuntimeGrassQuery_Node *v298; // rdx
		  HGRuntimeGrassQuery_Node *v299; // r8
		  Int32__Array **v300; // r9
		  HGRuntimeGrassQuery_Node *v301; // rdx
		  HGRuntimeGrassQuery_Node *v302; // r8
		  Int32__Array **v303; // r9
		  HGRuntimeGrassQuery_Node *v304; // rdx
		  HGRuntimeGrassQuery_Node *v305; // r8
		  Int32__Array **v306; // r9
		  HGRuntimeGrassQuery_Node *v307; // rdx
		  HGRuntimeGrassQuery_Node *v308; // r8
		  Int32__Array **v309; // r9
		  HGRuntimeGrassQuery_Node *v310; // rdx
		  HGRuntimeGrassQuery_Node *v311; // r8
		  Int32__Array **v312; // r9
		  HGRuntimeGrassQuery_Node *v313; // rdx
		  HGRuntimeGrassQuery_Node *v314; // r8
		  Int32__Array **v315; // r9
		  HGRuntimeGrassQuery_Node *v316; // rdx
		  HGRuntimeGrassQuery_Node *v317; // r8
		  Int32__Array **v318; // r9
		  HGRuntimeGrassQuery_Node *v319; // rdx
		  HGRuntimeGrassQuery_Node *v320; // r8
		  Int32__Array **v321; // r9
		  HGRuntimeGrassQuery_Node *v322; // rdx
		  HGRuntimeGrassQuery_Node *v323; // r8
		  Int32__Array **v324; // r9
		  HGRuntimeGrassQuery_Node *v325; // rdx
		  HGRuntimeGrassQuery_Node *v326; // r8
		  Int32__Array **v327; // r9
		  HGRuntimeGrassQuery_Node *v328; // rdx
		  HGRuntimeGrassQuery_Node *v329; // r8
		  Int32__Array **v330; // r9
		  HGRuntimeGrassQuery_Node *v331; // rdx
		  HGRuntimeGrassQuery_Node *v332; // r8
		  Int32__Array **v333; // r9
		  HGRuntimeGrassQuery_Node *v334; // rdx
		  HGRuntimeGrassQuery_Node *v335; // r8
		  Int32__Array **v336; // r9
		  HGRuntimeGrassQuery_Node *v337; // rdx
		  HGRuntimeGrassQuery_Node *v338; // r8
		  Int32__Array **v339; // r9
		  HGRuntimeGrassQuery_Node *v340; // rdx
		  HGRuntimeGrassQuery_Node *v341; // r8
		  Int32__Array **v342; // r9
		  HGRuntimeGrassQuery_Node *v343; // rdx
		  HGRuntimeGrassQuery_Node *v344; // r8
		  Int32__Array **v345; // r9
		  HGRuntimeGrassQuery_Node *v346; // rdx
		  HGRuntimeGrassQuery_Node *v347; // r8
		  Int32__Array **v348; // r9
		  HGRuntimeGrassQuery_Node *v349; // rdx
		  HGRuntimeGrassQuery_Node *v350; // r8
		  Int32__Array **v351; // r9
		  HGRuntimeGrassQuery_Node *v352; // rdx
		  HGRuntimeGrassQuery_Node *v353; // r8
		  Int32__Array **v354; // r9
		  HGRuntimeGrassQuery_Node *v355; // rdx
		  HGRuntimeGrassQuery_Node *v356; // r8
		  Int32__Array **v357; // r9
		  HGRuntimeGrassQuery_Node *v358; // rdx
		  HGRuntimeGrassQuery_Node *v359; // r8
		  Int32__Array **v360; // r9
		  HGRuntimeGrassQuery_Node *v361; // rdx
		  HGRuntimeGrassQuery_Node *v362; // r8
		  Int32__Array **v363; // r9
		  HGRuntimeGrassQuery_Node *v364; // rdx
		  HGRuntimeGrassQuery_Node *v365; // r8
		  Int32__Array **v366; // r9
		  HGRuntimeGrassQuery_Node *v367; // rdx
		  HGRuntimeGrassQuery_Node *v368; // r8
		  Int32__Array **v369; // r9
		  HGRuntimeGrassQuery_Node *v370; // rdx
		  HGRuntimeGrassQuery_Node *v371; // r8
		  Int32__Array **v372; // r9
		  HGRuntimeGrassQuery_Node *v373; // rdx
		  HGRuntimeGrassQuery_Node *v374; // r8
		  Int32__Array **v375; // r9
		  HGRuntimeGrassQuery_Node *v376; // rdx
		  HGRuntimeGrassQuery_Node *v377; // r8
		  Int32__Array **v378; // r9
		  HGRuntimeGrassQuery_Node *v379; // rdx
		  HGRuntimeGrassQuery_Node *v380; // r8
		  Int32__Array **v381; // r9
		  HGRuntimeGrassQuery_Node *v382; // rdx
		  HGRuntimeGrassQuery_Node *v383; // r8
		  Int32__Array **v384; // r9
		  HGRuntimeGrassQuery_Node *v385; // rdx
		  HGRuntimeGrassQuery_Node *v386; // r8
		  Int32__Array **v387; // r9
		  HGRuntimeGrassQuery_Node *v388; // rdx
		  HGRuntimeGrassQuery_Node *v389; // r8
		  Int32__Array **v390; // r9
		  HGRuntimeGrassQuery_Node *v391; // rdx
		  HGRuntimeGrassQuery_Node *v392; // r8
		  Int32__Array **v393; // r9
		  HGRuntimeGrassQuery_Node *v394; // rdx
		  HGRuntimeGrassQuery_Node *v395; // r8
		  Int32__Array **v396; // r9
		  HGRuntimeGrassQuery_Node *v397; // rdx
		  HGRuntimeGrassQuery_Node *v398; // r8
		  Int32__Array **v399; // r9
		  HGRuntimeGrassQuery_Node *v400; // rdx
		  HGRuntimeGrassQuery_Node *v401; // r8
		  Int32__Array **v402; // r9
		  HGRuntimeGrassQuery_Node *v403; // rdx
		  HGRuntimeGrassQuery_Node *v404; // r8
		  Int32__Array **v405; // r9
		  HGRuntimeGrassQuery_Node *v406; // rdx
		  HGRuntimeGrassQuery_Node *v407; // r8
		  Int32__Array **v408; // r9
		  HGRuntimeGrassQuery_Node *v409; // rdx
		  HGRuntimeGrassQuery_Node *v410; // r8
		  Int32__Array **v411; // r9
		  HGRuntimeGrassQuery_Node *v412; // rdx
		  HGRuntimeGrassQuery_Node *v413; // r8
		  Int32__Array **v414; // r9
		  HGRuntimeGrassQuery_Node *v415; // rdx
		  HGRuntimeGrassQuery_Node *v416; // r8
		  Int32__Array **v417; // r9
		  HGRuntimeGrassQuery_Node *v418; // rdx
		  HGRuntimeGrassQuery_Node *v419; // r8
		  Int32__Array **v420; // r9
		  HGRuntimeGrassQuery_Node *v421; // rdx
		  HGRuntimeGrassQuery_Node *v422; // r8
		  Int32__Array **v423; // r9
		  HGRuntimeGrassQuery_Node *v424; // rdx
		  HGRuntimeGrassQuery_Node *v425; // r8
		  Int32__Array **v426; // r9
		  HGRuntimeGrassQuery_Node *v427; // rdx
		  HGRuntimeGrassQuery_Node *v428; // r8
		  Int32__Array **v429; // r9
		  HGRuntimeGrassQuery_Node *v430; // rdx
		  HGRuntimeGrassQuery_Node *v431; // r8
		  Int32__Array **v432; // r9
		  HGRuntimeGrassQuery_Node *v433; // rdx
		  HGRuntimeGrassQuery_Node *v434; // r8
		  Int32__Array **v435; // r9
		  HGRuntimeGrassQuery_Node *v436; // rdx
		  HGRuntimeGrassQuery_Node *v437; // r8
		  Int32__Array **v438; // r9
		  HGRuntimeGrassQuery_Node *v439; // rdx
		  HGRuntimeGrassQuery_Node *v440; // r8
		  Int32__Array **v441; // r9
		  HGRuntimeGrassQuery_Node *v442; // rdx
		  HGRuntimeGrassQuery_Node *v443; // r8
		  Int32__Array **v444; // r9
		  HGRuntimeGrassQuery_Node *v445; // rdx
		  HGRuntimeGrassQuery_Node *v446; // r8
		  Int32__Array **v447; // r9
		  HGRuntimeGrassQuery_Node *v448; // rdx
		  HGRuntimeGrassQuery_Node *v449; // r8
		  Int32__Array **v450; // r9
		  HGRuntimeGrassQuery_Node *v451; // rdx
		  HGRuntimeGrassQuery_Node *v452; // r8
		  Int32__Array **v453; // r9
		  HGRuntimeGrassQuery_Node *v454; // rdx
		  HGRuntimeGrassQuery_Node *v455; // r8
		  Int32__Array **v456; // r9
		  HGRuntimeGrassQuery_Node *v457; // rdx
		  HGRuntimeGrassQuery_Node *v458; // r8
		  Int32__Array **v459; // r9
		  HGRuntimeGrassQuery_Node *v460; // rdx
		  HGRuntimeGrassQuery_Node *v461; // r8
		  Int32__Array **v462; // r9
		  HGRuntimeGrassQuery_Node *v463; // rdx
		  HGRuntimeGrassQuery_Node *v464; // r8
		  Int32__Array **v465; // r9
		  HGRuntimeGrassQuery_Node *v466; // rdx
		  HGRuntimeGrassQuery_Node *v467; // r8
		  Int32__Array **v468; // r9
		  HGRuntimeGrassQuery_Node *v469; // rdx
		  HGRuntimeGrassQuery_Node *v470; // r8
		  Int32__Array **v471; // r9
		  HGRuntimeGrassQuery_Node *v472; // rdx
		  HGRuntimeGrassQuery_Node *v473; // r8
		  Int32__Array **v474; // r9
		  HGRuntimeGrassQuery_Node *v475; // rdx
		  HGRuntimeGrassQuery_Node *v476; // r8
		  Int32__Array **v477; // r9
		  HGRuntimeGrassQuery_Node *v478; // rdx
		  HGRuntimeGrassQuery_Node *v479; // r8
		  Int32__Array **v480; // r9
		  HGRuntimeGrassQuery_Node *v481; // rdx
		  HGRuntimeGrassQuery_Node *v482; // r8
		  Int32__Array **v483; // r9
		  HGRuntimeGrassQuery_Node *v484; // rdx
		  HGRuntimeGrassQuery_Node *v485; // r8
		  Int32__Array **v486; // r9
		  HGRuntimeGrassQuery_Node *v487; // rdx
		  HGRuntimeGrassQuery_Node *v488; // r8
		  Int32__Array **v489; // r9
		  HGTerrainDeformSettingParameters *v490; // rax
		  __int64 v491; // rdx
		  __int64 v492; // rcx
		  HGTerrainDeformSettingParameters *v493; // rbx
		  HGRuntimeGrassQuery_Node *v494; // rdx
		  HGRuntimeGrassQuery_Node *v495; // r8
		  Int32__Array **v496; // r9
		  HGErosionBlendSettingParameters *v497; // rax
		  HGErosionBlendSettingParameters *v498; // rbx
		  HGRuntimeGrassQuery_Node *v499; // rdx
		  HGRuntimeGrassQuery_Node *v500; // r8
		  Int32__Array **v501; // r9
		  HGLightShaftSettingParameters *v502; // rax
		  HGLightShaftSettingParameters *v503; // rbx
		  HGRuntimeGrassQuery_Node *v504; // rdx
		  HGRuntimeGrassQuery_Node *v505; // r8
		  Int32__Array **v506; // r9
		  HGRainAndWetnessSettingParameters *v507; // rax
		  HGRainAndWetnessSettingParameters *v508; // rbx
		  HGRuntimeGrassQuery_Node *v509; // rdx
		  HGRuntimeGrassQuery_Node *v510; // r8
		  Int32__Array **v511; // r9
		  HGSnowSettingParameters *v512; // rax
		  HGSnowSettingParameters *v513; // rbx
		  HGRuntimeGrassQuery_Node *v514; // rdx
		  HGRuntimeGrassQuery_Node *v515; // r8
		  Int32__Array **v516; // r9
		  HGVerticalOcclusionMapSettingParameters *v517; // rax
		  HGVerticalOcclusionMapSettingParameters *v518; // rbx
		  HGRuntimeGrassQuery_Node *v519; // rdx
		  HGRuntimeGrassQuery_Node *v520; // r8
		  Int32__Array **v521; // r9
		  HGAtmosphereSettingParameters *v522; // rax
		  HGAtmosphereSettingParameters *v523; // rbx
		  HGRuntimeGrassQuery_Node *v524; // rdx
		  HGRuntimeGrassQuery_Node *v525; // r8
		  Int32__Array **v526; // r9
		  HGVolumetricCloudSettingParameters *v527; // rax
		  HGVolumetricCloudSettingParameters *v528; // rbx
		  HGRuntimeGrassQuery_Node *v529; // rdx
		  HGRuntimeGrassQuery_Node *v530; // r8
		  Int32__Array **v531; // r9
		  HGRuntimeGrassQuery_Node *v532; // rdx
		  HGRuntimeGrassQuery_Node *v533; // r8
		  Int32__Array **v534; // r9
		  HGRuntimeGrassQuery_Node *v535; // rdx
		  HGRuntimeGrassQuery_Node *v536; // r8
		  Int32__Array **v537; // r9
		  HGRuntimeGrassQuery_Node *v538; // rdx
		  HGRuntimeGrassQuery_Node *v539; // r8
		  Int32__Array **v540; // r9
		  HGRuntimeGrassQuery_Node *v541; // rdx
		  HGRuntimeGrassQuery_Node *v542; // r8
		  Int32__Array **v543; // r9
		  HGRuntimeGrassQuery_Node *v544; // rdx
		  HGRuntimeGrassQuery_Node *v545; // r8
		  Int32__Array **v546; // r9
		  HGRuntimeGrassQuery_Node *v547; // rdx
		  HGRuntimeGrassQuery_Node *v548; // r8
		  Int32__Array **v549; // r9
		  HGRuntimeGrassQuery_Node *v550; // rdx
		  HGRuntimeGrassQuery_Node *v551; // r8
		  Int32__Array **v552; // r9
		  HGRuntimeGrassQuery_Node *v553; // rdx
		  HGRuntimeGrassQuery_Node *v554; // r8
		  Int32__Array **v555; // r9
		  HGRuntimeGrassQuery_Node *v556; // rdx
		  HGRuntimeGrassQuery_Node *v557; // r8
		  Int32__Array **v558; // r9
		  HGRuntimeGrassQuery_Node *v559; // rdx
		  HGRuntimeGrassQuery_Node *v560; // r8
		  Int32__Array **v561; // r9
		  HGRuntimeGrassQuery_Node *v562; // rdx
		  HGRuntimeGrassQuery_Node *v563; // r8
		  Int32__Array **v564; // r9
		  HGRuntimeGrassQuery_Node *v565; // rdx
		  HGRuntimeGrassQuery_Node *v566; // r8
		  Int32__Array **v567; // r9
		  HGRuntimeGrassQuery_Node *v568; // rdx
		  HGRuntimeGrassQuery_Node *v569; // r8
		  Int32__Array **v570; // r9
		  HGRuntimeGrassQuery_Node *v571; // rdx
		  HGRuntimeGrassQuery_Node *v572; // r8
		  Int32__Array **v573; // r9
		  HGRuntimeGrassQuery_Node *v574; // rdx
		  HGRuntimeGrassQuery_Node *v575; // r8
		  Int32__Array **v576; // r9
		  HGRuntimeGrassQuery_Node *v577; // rdx
		  HGRuntimeGrassQuery_Node *v578; // r8
		  Int32__Array **v579; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v580; // rax
		  List_1_HG_Rendering_Runtime_SettingParameter_1_System_Single_ *v581; // rbx
		  HGRuntimeGrassQuery_Node *v582; // rdx
		  HGRuntimeGrassQuery_Node *v583; // r8
		  Int32__Array **v584; // r9
		  int i; // ebx
		  struct HGSettingParameters__Class *v586; // rax
		  List_1_System_Object_ *artTagLODBias_k__BackingField; // rdi
		  HGSettingParameters__StaticFields *static_fields; // rax
		  String *ART_TAGS_NAME; // rbp
		  Object *v590; // r14
		  String *v591; // rax
		  Object *v592; // rax
		  struct HGSettingParameters__Class *v593; // rax
		  HGRuntimeGrassQuery_Node *v594; // rdx
		  HGRuntimeGrassQuery_Node *v595; // r8
		  Int32__Array **v596; // r9
		  HGRuntimeGrassQuery_Node *v597; // rdx
		  HGRuntimeGrassQuery_Node *v598; // r8
		  Int32__Array **v599; // r9
		  HGRuntimeGrassQuery_Node *v600; // rdx
		  HGRuntimeGrassQuery_Node *v601; // r8
		  Int32__Array **v602; // r9
		  HGRuntimeGrassQuery_Node *v603; // rdx
		  HGRuntimeGrassQuery_Node *v604; // r8
		  Int32__Array **v605; // r9
		  HGRuntimeGrassQuery_Node *v606; // rdx
		  HGRuntimeGrassQuery_Node *v607; // r8
		  Int32__Array **v608; // r9
		  HGRuntimeGrassQuery_Node *v609; // rdx
		  HGRuntimeGrassQuery_Node *v610; // r8
		  Int32__Array **v611; // r9
		  HGRuntimeGrassQuery_Node *v612; // rdx
		  HGRuntimeGrassQuery_Node *v613; // r8
		  Int32__Array **v614; // r9
		  HGRuntimeGrassQuery_Node *v615; // rdx
		  HGRuntimeGrassQuery_Node *v616; // r8
		  Int32__Array **v617; // r9
		  HGRuntimeGrassQuery_Node *v618; // rdx
		  HGRuntimeGrassQuery_Node *v619; // r8
		  Int32__Array **v620; // r9
		  HGRuntimeGrassQuery_Node *v621; // rdx
		  HGRuntimeGrassQuery_Node *v622; // r8
		  Int32__Array **v623; // r9
		  HGRuntimeGrassQuery_Node *v624; // rdx
		  HGRuntimeGrassQuery_Node *v625; // r8
		  Int32__Array **v626; // r9
		  HGRuntimeGrassQuery_Node *v627; // rdx
		  HGRuntimeGrassQuery_Node *v628; // r8
		  Int32__Array **v629; // r9
		  HGRuntimeGrassQuery_Node *v630; // rdx
		  HGRuntimeGrassQuery_Node *v631; // r8
		  Int32__Array **v632; // r9
		  HGRuntimeGrassQuery_Node *v633; // rdx
		  HGRuntimeGrassQuery_Node *v634; // r8
		  Int32__Array **v635; // r9
		  HGRuntimeGrassQuery_Node *v636; // rdx
		  HGRuntimeGrassQuery_Node *v637; // r8
		  Int32__Array **v638; // r9
		  HGRuntimeGrassQuery_Node *v639; // rdx
		  HGRuntimeGrassQuery_Node *v640; // r8
		  Int32__Array **v641; // r9
		  HGRuntimeGrassQuery_Node *v642; // rdx
		  HGRuntimeGrassQuery_Node *v643; // r8
		  Int32__Array **v644; // r9
		  HGRuntimeGrassQuery_Node *v645; // rdx
		  HGRuntimeGrassQuery_Node *v646; // r8
		  Int32__Array **v647; // r9
		  HGRuntimeGrassQuery_Node *v648; // rdx
		  HGRuntimeGrassQuery_Node *v649; // r8
		  Int32__Array **v650; // r9
		  HGRuntimeGrassQuery_Node *v651; // rdx
		  HGRuntimeGrassQuery_Node *v652; // r8
		  Int32__Array **v653; // r9
		  HGRuntimeGrassQuery_Node *v654; // rdx
		  HGRuntimeGrassQuery_Node *v655; // r8
		  Int32__Array **v656; // r9
		  HGRuntimeGrassQuery_Node *v657; // rdx
		  HGRuntimeGrassQuery_Node *v658; // r8
		  Int32__Array **v659; // r9
		  HGRuntimeGrassQuery_Node *v660; // rdx
		  HGRuntimeGrassQuery_Node *v661; // r8
		  Int32__Array **v662; // r9
		  HGRuntimeGrassQuery_Node *v663; // rdx
		  HGRuntimeGrassQuery_Node *v664; // r8
		  Int32__Array **v665; // r9
		  HGRuntimeGrassQuery_Node *v666; // rdx
		  HGRuntimeGrassQuery_Node *v667; // r8
		  Int32__Array **v668; // r9
		  HGRuntimeGrassQuery_Node *v669; // rdx
		  HGRuntimeGrassQuery_Node *v670; // r8
		  Int32__Array **v671; // r9
		  HGRuntimeGrassQuery_Node *v672; // rdx
		  HGRuntimeGrassQuery_Node *v673; // r8
		  Int32__Array **v674; // r9
		  HGRuntimeGrassQuery_Node *v675; // rdx
		  HGRuntimeGrassQuery_Node *v676; // r8
		  Int32__Array **v677; // r9
		  HGRuntimeGrassQuery_Node *v678; // rdx
		  HGRuntimeGrassQuery_Node *v679; // r8
		  Int32__Array **v680; // r9
		  HGRuntimeGrassQuery_Node *v681; // rdx
		  HGRuntimeGrassQuery_Node *v682; // r8
		  Int32__Array **v683; // r9
		  HGRuntimeGrassQuery_Node *v684; // rdx
		  HGRuntimeGrassQuery_Node *v685; // r8
		  Int32__Array **v686; // r9
		  HGRuntimeGrassQuery_Node *v687; // rdx
		  HGRuntimeGrassQuery_Node *v688; // r8
		  Int32__Array **v689; // r9
		  HGRuntimeGrassQuery_Node *v690; // rdx
		  HGRuntimeGrassQuery_Node *v691; // r8
		  Int32__Array **v692; // r9
		  HGRuntimeGrassQuery_Node *v693; // rdx
		  HGRuntimeGrassQuery_Node *v694; // r8
		  Int32__Array **v695; // r9
		  Enum v696; // [rsp+20h] [rbp-88h] BYREF
		  int v697; // [rsp+30h] [rbp-78h]
		  MethodInfo *v698; // [rsp+D0h] [rbp+28h]
		
		  v3 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSettingParameters);
		    v3 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  }
		  this->fields._cullingViewScreenSizeMin_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                             0.0,
		                                                             v3->static_fields->ECS_FEATURE_NAME,
		                                                             (String *)"CullingViewScreenSizeMin",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v4, v5, v6, (MethodInfo *)v696.klass);
		  this->fields._ocScreenSizeMin_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                    0.050000001,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ECS_FEATURE_NAME,
		                                                    (String *)"OCScreenSizeMin",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ocScreenSizeMin_k__BackingField,
		    v7,
		    v8,
		    v9,
		    (MethodInfo *)v696.klass);
		  this->fields._taauEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               1,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                               (String *)"Enable",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._taauEnable_k__BackingField,
		    v10,
		    v11,
		    v12,
		    (MethodInfo *)v696.klass);
		  this->fields._taauQuality_k__BackingField = (SettingParameter_1_TAAUQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
		                                                                                   (Int32Enum__Enum)0,
		                                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                                                   (String *)"Quality",
		                                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::TAAUQuality>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._taauQuality_k__BackingField,
		    v13,
		    v14,
		    v15,
		    (MethodInfo *)v696.klass);
		  this->fields._historyWeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                  0.89999998,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                  (String *)"HistoryWeight",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._historyWeight_k__BackingField,
		    v16,
		    v17,
		    v18,
		    (MethodInfo *)v696.klass);
		  this->fields._historyWeightInMotion_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                          0.80000001,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                          (String *)"HistoryWeightInMotion",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._historyWeightInMotion_k__BackingField,
		    v19,
		    v20,
		    v21,
		    (MethodInfo *)v696.klass);
		  this->fields._fastConvergeHistoryWeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                              0.5,
		                                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                              (String *)"FastConvergeHistoryWeight",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fastConvergeHistoryWeight_k__BackingField,
		    v22,
		    v23,
		    v24,
		    (MethodInfo *)v696.klass);
		  this->fields._responsiveAAWeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                       0.0,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                       (String *)"ResponsiveAAWeight",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._responsiveAAWeight_k__BackingField,
		    v25,
		    v26,
		    v27,
		    (MethodInfo *)v696.klass);
		  this->fields._minMotion_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              0.0000099999997,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                              (String *)"MinMotion",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._minMotion_k__BackingField,
		    v28,
		    v29,
		    v30,
		    (MethodInfo *)v696.klass);
		  this->fields._maxMotion_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              0.000049999999,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                              (String *)"MaxMotion",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._maxMotion_k__BackingField,
		    v31,
		    v32,
		    v33,
		    (MethodInfo *)v696.klass);
		  this->fields._characterMotionSensitivity_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                               0.000049999999,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                               (String *)"CharacterMotionSensitivity",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterMotionSensitivity_k__BackingField,
		    v34,
		    v35,
		    v36,
		    (MethodInfo *)v696.klass);
		  this->fields._occlusionDepthDiff_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                       0.00019999999,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                       (String *)"OcclusionDepthDiff",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._occlusionDepthDiff_k__BackingField,
		    v37,
		    v38,
		    v39,
		    (MethodInfo *)v696.klass);
		  this->fields._inputLumaWeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                    1.0,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                    (String *)"InputLumaWeight",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._inputLumaWeight_k__BackingField,
		    v40,
		    v41,
		    v42,
		    (MethodInfo *)v696.klass);
		  this->fields._sharpenStrength1K_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.2,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                      (String *)"1KSharpenStrength",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._sharpenStrength1K_k__BackingField,
		    v43,
		    v44,
		    v45,
		    (MethodInfo *)v696.klass);
		  this->fields._sharpenStrength2K_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.2,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                      (String *)"2KSharpenStrength",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._sharpenStrength2K_k__BackingField,
		    v46,
		    v47,
		    v48,
		    (MethodInfo *)v696.klass);
		  this->fields._sharpenStrength4K_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.2,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		                                                      (String *)"4KSharpenStrength",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._sharpenStrength4K_k__BackingField,
		    v49,
		    v50,
		    v51,
		    (MethodInfo *)v696.klass);
		  this->fields._pssrEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               0,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PSSR_FEATURE_NAME,
		                                               (String *)"PssrEnable",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._pssrEnable_k__BackingField,
		    v52,
		    v53,
		    v54,
		    (MethodInfo *)v696.klass);
		  this->fields._pssrSharpness_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                  0.0,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PSSR_FEATURE_NAME,
		                                                  (String *)"PssrSharpness",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._pssrSharpness_k__BackingField,
		    v55,
		    v56,
		    v57,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               0,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME,
		                                               (String *)"Enable",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssEnable_k__BackingField,
		    v58,
		    v59,
		    v60,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssQuality_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)3u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME, (String *)"DLSSQuality", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::DLSSQuality>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssQuality_k__BackingField,
		    v61,
		    v62,
		    v63,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssUseAutoExposure_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        0,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME,
		                                                        (String *)"DLSSUseAutoExposure",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssUseAutoExposure_k__BackingField,
		    v64,
		    v65,
		    v66,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssGMode_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineDLSSFGMode_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME, (String *)"DLSSGMode", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssGMode_k__BackingField,
		    v67,
		    v68,
		    v69,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssGGenFrames_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                   0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME,
		                                                   (String *)"DLSSGGenFrames",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssGGenFrames_k__BackingField,
		    v70,
		    v71,
		    v72,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssReflexMode_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineReflexMode_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME, (String *)"DLSSReflexMode", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssReflexMode_k__BackingField,
		    v73,
		    v74,
		    v75,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssPCLEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                  1,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME,
		                                                  (String *)"DLSSPCLEnable",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssPCLEnable_k__BackingField,
		    v76,
		    v77,
		    v78,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssSharpenStrength_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                        0.2,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME,
		                                                        (String *)"DLSSSharpenStrength",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssSharpenStrength_k__BackingField,
		    v79,
		    v80,
		    v81,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssUseUIHint_k__BackingField = HG::Rendering::Runtime::SettingParameter<bool>::Create(
		                                                  0,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME,
		                                                  (String *)"DLSSUseUIHint",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::Create);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssUseUIHint_k__BackingField,
		    v82,
		    v83,
		    v84,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssUIHintAlphaThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter<float>::Create(
		                                                             0.0,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME,
		                                                             (String *)"DLSSUIHintAlphaThreshold",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Create);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssUIHintAlphaThreshold_k__BackingField,
		    v85,
		    v86,
		    v87,
		    (MethodInfo *)v696.klass);
		  this->fields._dlssModel_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSModel_ *)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::Create((Int32Enum__Enum)0, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME, (String *)"DLSSModel", MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSModel>::Create);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dlssModel_k__BackingField,
		    v88,
		    v89,
		    v90,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3Enable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               0,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                               (String *)"Enable",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3Enable_k__BackingField,
		    v91,
		    v92,
		    v93,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3UseReaciveAndTCMask_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                            1,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                            (String *)"useReaciveAndTCMask",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3UseReaciveAndTCMask_k__BackingField,
		    v94,
		    v95,
		    v96,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3Quality_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_FSR3Quality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)3u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME, (String *)"FSR3Quality", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::FSR3Quality>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3Quality_k__BackingField,
		    v97,
		    v98,
		    v99,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3SharpenStrength_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                        0.2,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                        (String *)"FSR3SharpenStrength",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3SharpenStrength_k__BackingField,
		    v100,
		    v101,
		    v102,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3UseFP16_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                1,
		                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                (String *)"useFP16",
		                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3UseFP16_k__BackingField,
		    v103,
		    v104,
		    v105,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3UseWave_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                1,
		                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                (String *)"useWave",
		                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3UseWave_k__BackingField,
		    v106,
		    v107,
		    v108,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3UseWave64_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                  1,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                  (String *)"useWave64",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3UseWave64_k__BackingField,
		    v109,
		    v110,
		    v111,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3UseLanczosLut_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                      0,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		                                                      (String *)"useLanczosLut",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3UseLanczosLut_k__BackingField,
		    v112,
		    v113,
		    v114,
		    (MethodInfo *)v696.klass);
		  this->fields._fsr3FIEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter<bool>::Create(
		                                                 0,
		                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3FI_FEATURE_NAME,
		                                                 (String *)"Enable",
		                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::Create);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fsr3FIEnable_k__BackingField,
		    v115,
		    v116,
		    v117,
		    (MethodInfo *)v696.klass);
		  this->fields._bloomQuality_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_BloomQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)1u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME, (String *)"BloomQuality", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::BloomQuality>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._bloomQuality_k__BackingField,
		    v118,
		    v119,
		    v120,
		    (MethodInfo *)v696.klass);
		  this->fields._bloomUseComputeShader_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                          1,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                          (String *)"BloomUseComputeShader",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._bloomUseComputeShader_k__BackingField,
		    v121,
		    v122,
		    v123,
		    (MethodInfo *)v696.klass);
		  this->fields._lutSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                            32,
		                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                            (String *)"LutSize",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._lutSize_k__BackingField,
		    v124,
		    v125,
		    v126,
		    (MethodInfo *)v696.klass);
		  this->fields._lutFormat_k__BackingField = (SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0x30u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME, (String *)"LutFormat", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::Experimental::Rendering::GraphicsFormat>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._lutFormat_k__BackingField,
		    v127,
		    v128,
		    v129,
		    (MethodInfo *)v696.klass);
		  this->fields._ppBufferFormat_k__BackingField = (SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0x4Au, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME, (String *)"PPBufferFormat", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::Experimental::Rendering::GraphicsFormat>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ppBufferFormat_k__BackingField,
		    v130,
		    v131,
		    v132,
		    (MethodInfo *)v696.klass);
		  this->fields._uiPPBufferFormat_k__BackingField = (SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0x4Au, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME, (String *)"UIPPBufferFormat", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::Experimental::Rendering::GraphicsFormat>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._uiPPBufferFormat_k__BackingField,
		    v133,
		    v134,
		    v135,
		    (MethodInfo *)v696.klass);
		  this->fields._frostedGlassUseComputeShader_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                 1,
		                                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                                 (String *)"FrostedGlassUseComputeShader",
		                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._frostedGlassUseComputeShader_k__BackingField,
		    v136,
		    v137,
		    v138,
		    (MethodInfo *)v696.klass);
		  this->fields._enablePermenantSceneFrostedGlass_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                     1,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                                     (String *)"EnablePermenantSceneFrostedGlass",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._enablePermenantSceneFrostedGlass_k__BackingField,
		    v139,
		    v140,
		    v141,
		    (MethodInfo *)v696.klass);
		  this->fields._depthOfFieldQuality_k__BackingField = (SettingParameter_1_HGDepthOfFieldQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
		                                                                                                     (Int32Enum__Enum)0,
		                                                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                                                                     (String *)"DepthOfFieldQuality",
		                                                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::HGDepthOfFieldQuality>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthOfFieldQuality_k__BackingField,
		    v142,
		    v143,
		    v144,
		    (MethodInfo *)v696.klass);
		  this->fields._depthOfFieldMaxRadius_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                          100.0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                          (String *)"DepthOfFieldMaxRadius",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthOfFieldMaxRadius_k__BackingField,
		    v145,
		    v146,
		    v147,
		    (MethodInfo *)v696.klass);
		  this->fields._depthOfFieldScaleAdjust_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                            0,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                            (String *)"depthOfFieldScaleAdjust",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthOfFieldScaleAdjust_k__BackingField,
		    v148,
		    v149,
		    v150,
		    (MethodInfo *)v696.klass);
		  this->fields._depthOfFieldScaleAdjustThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                     0.80000001,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                                     (String *)"depthOfFieldScaleAdjustThreshold",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthOfFieldScaleAdjustThreshold_k__BackingField,
		    v151,
		    v152,
		    v153,
		    (MethodInfo *)v696.klass);
		  this->fields._motionBlurEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                     1,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                     (String *)"MotionBlurEnable",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._motionBlurEnable_k__BackingField,
		    v154,
		    v155,
		    v156,
		    (MethodInfo *)v696.klass);
		  this->fields._bloomEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                 1,
		                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                 (String *)"BloomEnabled",
		                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._bloomEnabled_k__BackingField,
		    v157,
		    v158,
		    v159,
		    (MethodInfo *)v696.klass);
		  this->fields._vignetteEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                    1,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                    (String *)"VignetteEnabled",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._vignetteEnabled_k__BackingField,
		    v160,
		    v161,
		    v162,
		    (MethodInfo *)v696.klass);
		  this->fields._radialBlurEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                      1,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                      (String *)"RadialBlurEnabled",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._radialBlurEnabled_k__BackingField,
		    v163,
		    v164,
		    v165,
		    (MethodInfo *)v696.klass);
		  this->fields._dirtyLensEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                     1,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                     (String *)"DirtyLensEnabled",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._dirtyLensEnabled_k__BackingField,
		    v166,
		    v167,
		    v168,
		    (MethodInfo *)v696.klass);
		  this->fields._sharpenEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                   1,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                   (String *)"SharpenEnabled",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._sharpenEnabled_k__BackingField,
		    v169,
		    v170,
		    v171,
		    (MethodInfo *)v696.klass);
		  this->fields._frostedGlassEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        1,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                        (String *)"FrostedGlassEnabled",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._frostedGlassEnabled_k__BackingField,
		    v172,
		    v173,
		    v174,
		    (MethodInfo *)v696.klass);
		  this->fields._cutsceneEffectEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                          1,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                          (String *)"CutsceneEffectEnabled",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._cutsceneEffectEnabled_k__BackingField,
		    v175,
		    v176,
		    v177,
		    (MethodInfo *)v696.klass);
		  this->fields._fisheyeEffectEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         1,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                         (String *)"FisheyeEffectEnabled",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fisheyeEffectEnabled_k__BackingField,
		    v178,
		    v179,
		    v180,
		    (MethodInfo *)v696.klass);
		  this->fields._lensFlareEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                     1,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                     (String *)"LensFlareEnabled",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._lensFlareEnabled_k__BackingField,
		    v181,
		    v182,
		    v183,
		    (MethodInfo *)v696.klass);
		  this->fields._lensFlareOccSampleCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                            1,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		                                                            (String *)"lensFlareOccSampleCount",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._lensFlareOccSampleCount_k__BackingField,
		    v184,
		    v185,
		    v186,
		    (MethodInfo *)v696.klass);
		  this->fields._chromaticAberrationEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               1,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CHROMATIC_ABERRATION_TRACING_NAME,
		                                                               (String *)"ChromaticAberrationEnabled",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._chromaticAberrationEnabled_k__BackingField,
		    v187,
		    v188,
		    v189,
		    (MethodInfo *)v696.klass);
		  this->fields._enableAnamorphicStreaks_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                            1,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ASTREAKS_FEATURE_NAME,
		                                                            (String *)"enableAnamorphicStreaks",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._enableAnamorphicStreaks_k__BackingField,
		    v190,
		    v191,
		    v192,
		    (MethodInfo *)v696.klass);
		  this->fields._anamorphicStreaksDownSampleFactor_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                      0.5,
		                                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ASTREAKS_FEATURE_NAME,
		                                                                      (String *)"anamorphicStreaksDownSampleFactor",
		                                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._anamorphicStreaksDownSampleFactor_k__BackingField,
		    v193,
		    v194,
		    v195,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightMaxCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                          256,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->LIGHTING_FEATURE_NAME,
		                                                          (String *)"PunctualLightMaxCount",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightMaxCount_k__BackingField,
		    v196,
		    v197,
		    v198,
		    (MethodInfo *)v696.klass);
		  this->fields._enableShadowProxy_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                      1,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                      (String *)"EnableShadowProxy",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._enableShadowProxy_k__BackingField,
		    v199,
		    v200,
		    v201,
		    (MethodInfo *)v696.klass);
		  this->fields._shadowDepthBits_k__BackingField = (SettingParameter_1_UnityEngine_Rendering_DepthBits_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0x10u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME, (String *)"DepthBits", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::Rendering::DepthBits>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._shadowDepthBits_k__BackingField,
		    v202,
		    v203,
		    v204,
		    (MethodInfo *)v696.klass);
		  this->fields._enableScreenSpaceShadowMask_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                0,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                (String *)"EnableScreenSpaceShadowMask",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._enableScreenSpaceShadowMask_k__BackingField,
		    v205,
		    v206,
		    v207,
		    (MethodInfo *)v696.klass);
		  this->fields._csmEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               1,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                               (String *)"CSMEnabled",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmEnabled_k__BackingField,
		    v208,
		    v209,
		    v210,
		    (MethodInfo *)v696.klass);
		  this->fields._csmShadowMapTileResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                               1024,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"CSMTileResolution",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmShadowMapTileResolution_k__BackingField,
		    v211,
		    v212,
		    v213,
		    (MethodInfo *)v696.klass);
		  this->fields._csmMaxDistance_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                   80.0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                   (String *)"CSMMaxDistance",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmMaxDistance_k__BackingField,
		    v214,
		    v215,
		    v216,
		    (MethodInfo *)v696.klass);
		  this->fields._csmFadeInnerDistance_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                         60.0,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                         (String *)"CSMFadeInnerDistance",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmFadeInnerDistance_k__BackingField,
		    v217,
		    v218,
		    v219,
		    (MethodInfo *)v696.klass);
		  this->fields._csmSplitCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                  3,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                  (String *)"CSMSplitCount",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmSplitCount_k__BackingField,
		    v220,
		    v221,
		    v222,
		    (MethodInfo *)v696.klass);
		  this->fields._csmSplit0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              0.15000001,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                              (String *)"CSMSplit0",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmSplit0_k__BackingField,
		    v223,
		    v224,
		    v225,
		    (MethodInfo *)v696.klass);
		  this->fields._csmSplit1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              0.375,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                              (String *)"CSMSplit1",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmSplit1_k__BackingField,
		    v226,
		    v227,
		    v228,
		    (MethodInfo *)v696.klass);
		  this->fields._csmSplit2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              0.5,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                              (String *)"CSMSplit2",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmSplit2_k__BackingField,
		    v229,
		    v230,
		    v231,
		    (MethodInfo *)v696.klass);
		  this->fields._csmSplit3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              1.0,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                              (String *)"CSMSplit3",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmSplit3_k__BackingField,
		    v232,
		    v233,
		    v234,
		    (MethodInfo *)v696.klass);
		  this->fields._csmUseShadowmapCache_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         0,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                         (String *)"CSMUseShadowMapCache",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmUseShadowmapCache_k__BackingField,
		    v235,
		    v236,
		    v237,
		    (MethodInfo *)v696.klass);
		  this->fields._csmCachedFrame0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    1,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"CSMCachedFrame0",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmCachedFrame0_k__BackingField,
		    v238,
		    v239,
		    v240,
		    (MethodInfo *)v696.klass);
		  this->fields._csmCachedFrame1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    2,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"CSMCachedFrame1",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmCachedFrame1_k__BackingField,
		    v241,
		    v242,
		    v243,
		    (MethodInfo *)v696.klass);
		  this->fields._csmCachedFrame2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    4,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"CSMCachedFrame2",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmCachedFrame2_k__BackingField,
		    v244,
		    v245,
		    v246,
		    (MethodInfo *)v696.klass);
		  this->fields._csmCachedFrame3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    4,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"CSMCachedFrame3",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmCachedFrame3_k__BackingField,
		    v247,
		    v248,
		    v249,
		    (MethodInfo *)v696.klass);
		  this->fields._csmScreenSizeMin0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.02,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                      (String *)"CSMScreenSizeMin0",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmScreenSizeMin0_k__BackingField,
		    v250,
		    v251,
		    v252,
		    (MethodInfo *)v696.klass);
		  this->fields._csmScreenSizeMin1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.029999999,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                      (String *)"CSMScreenSizeMin1",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmScreenSizeMin1_k__BackingField,
		    v253,
		    v254,
		    v255,
		    (MethodInfo *)v696.klass);
		  this->fields._csmScreenSizeMin2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.050000001,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                      (String *)"CSMScreenSizeMin2",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmScreenSizeMin2_k__BackingField,
		    v256,
		    v257,
		    v258,
		    (MethodInfo *)v696.klass);
		  this->fields._csmScreenSizeMin3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      0.079999998,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                      (String *)"CSMScreenSizeMin3",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmScreenSizeMin3_k__BackingField,
		    v259,
		    v260,
		    v261,
		    (MethodInfo *)v696.klass);
		  this->fields._csmEnableOcclusionCulling0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"CSMEnableOcclusionCulling0",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmEnableOcclusionCulling0_k__BackingField,
		    v262,
		    v263,
		    v264,
		    (MethodInfo *)v696.klass);
		  this->fields._csmEnableOcclusionCulling1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"CSMEnableOcclusionCulling1",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmEnableOcclusionCulling1_k__BackingField,
		    v265,
		    v266,
		    v267,
		    (MethodInfo *)v696.klass);
		  this->fields._csmEnableOcclusionCulling2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               1,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"CSMEnableOcclusionCulling2",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmEnableOcclusionCulling2_k__BackingField,
		    v268,
		    v269,
		    v270,
		    (MethodInfo *)v696.klass);
		  this->fields._csmEnableOcclusionCulling3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               1,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"CSMEnableOcclusionCulling3",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmEnableOcclusionCulling3_k__BackingField,
		    v271,
		    v272,
		    v273,
		    (MethodInfo *)v696.klass);
		  this->fields._csmOcclusionDepthSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                          256,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                          (String *)"CSMOcclusionDepthSize",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmOcclusionDepthSize_k__BackingField,
		    v274,
		    v275,
		    v276,
		    (MethodInfo *)v696.klass);
		  this->fields._csmStopRenderCharacterCascade_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                  2,
		                                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                  (String *)"CSMStopRenderCharacterCascade",
		                                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmStopRenderCharacterCascade_k__BackingField,
		    v277,
		    v278,
		    v279,
		    (MethodInfo *)v696.klass);
		  this->fields._csmNearPlaneOffset_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                       10.0,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                       (String *)"CSMNearPlaneOffset",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmNearPlaneOffset_k__BackingField,
		    v280,
		    v281,
		    v282,
		    (MethodInfo *)v696.klass);
		  this->fields._csmHardwareBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                    1.0,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"CSMHardwareBias",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmHardwareBias_k__BackingField,
		    v283,
		    v284,
		    v285,
		    (MethodInfo *)v696.klass);
		  this->fields._csmHardwareNormalBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                          1.0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                          (String *)"CSMHardwareNormalBias",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._csmHardwareNormalBias_k__BackingField,
		    v286,
		    v287,
		    v288,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                           1,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                           (String *)"CharacterShadowEnabled",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowEnabled_k__BackingField,
		    v289,
		    v290,
		    v291,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowMapResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                 512,
		                                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                 (String *)"CharacterShadowMapResolution",
		                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowMapResolution_k__BackingField,
		    v292,
		    v293,
		    v294,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowHardwareBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                1.0,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                (String *)"CharacterShadowHardwareBias",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowHardwareBias_k__BackingField,
		    v295,
		    v296,
		    v297,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowHardwareNormalBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                      1.0,
		                                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                      (String *)"CharacterShadowHardwareNormalBias",
		                                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowHardwareNormalBias_k__BackingField,
		    v298,
		    v299,
		    v300,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowShaderBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                              1.0,
		                                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                              (String *)"CharacterShadowShaderBias",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowShaderBias_k__BackingField,
		    v301,
		    v302,
		    v303,
		    (MethodInfo *)v696.klass);
		  this->fields._characterShadowShaderNormalBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                    1.0,
		                                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                    (String *)"CharacterShadowShaderNormalBias",
		                                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._characterShadowShaderNormalBias_k__BackingField,
		    v304,
		    v305,
		    v306,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightShadowEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               1,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"PunctualLightShadowEnabled",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightShadowEnabled_k__BackingField,
		    v307,
		    v308,
		    v309,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightTileMaxSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                             512,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                             (String *)"PunctualLightTileMaxSize",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightTileMaxSize_k__BackingField,
		    v310,
		    v311,
		    v312,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightForceCullDistance_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   200.0,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                   (String *)"PunctualLightForceCullDistance",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightForceCullDistance_k__BackingField,
		    v313,
		    v314,
		    v315,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightEnvDynamicCasterCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                       6,
		                                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                       (String *)"PunctualLightEnvDynamicCasterCount",
		                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightEnvDynamicCasterCount_k__BackingField,
		    v316,
		    v317,
		    v318,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightMovableDynamicCasterCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                           2,
		                                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                           (String *)"PunctualLightMovableDynamicCasterCount",
		                                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightMovableDynamicCasterCount_k__BackingField,
		    v319,
		    v320,
		    v321,
		    (MethodInfo *)v696.klass);
		  this->fields._punctualLightShadowScreenSizeMin_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                     0.001,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                     (String *)"PunctualLightShadowScreenSizeMin",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._punctualLightShadowScreenSizeMin_k__BackingField,
		    v322,
		    v323,
		    v324,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsCharacterShadowEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                1,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                (String *)"HDPLSCharacterShadowEnabled",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsCharacterShadowEnabled_k__BackingField,
		    v325,
		    v326,
		    v327,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsAtlasHeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                     2048,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                     (String *)"HDPLSAtlasHeight",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsAtlasHeight_k__BackingField,
		    v328,
		    v329,
		    v330,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsScreenSpaceReduceResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                     1,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                     (String *)"HDPLSScreenSpaceReduceResolution",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsScreenSpaceReduceResolution_k__BackingField,
		    v331,
		    v332,
		    v333,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsDepthBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                   0.0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                   (String *)"HDPLSDepthBias",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsDepthBias_k__BackingField,
		    v334,
		    v335,
		    v336,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsNormalBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                    0.0,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                    (String *)"HDPLSNormalBias",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsNormalBias_k__BackingField,
		    v337,
		    v338,
		    v339,
		    (MethodInfo *)v696.klass);
		  this->fields._hdplsSoftness_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                  0.0,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                  (String *)"HDPLSSoftness",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hdplsSoftness_k__BackingField,
		    v340,
		    v341,
		    v342,
		    (MethodInfo *)v696.klass);
		  this->fields._asmEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               1,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                               (String *)"ASMEnabled",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmEnabled_k__BackingField,
		    v343,
		    v344,
		    v345,
		    (MethodInfo *)v696.klass);
		  this->fields._asmShadowMapTileResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                               256,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                               (String *)"ASMShadowMapTileResolution",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmShadowMapTileResolution_k__BackingField,
		    v346,
		    v347,
		    v348,
		    (MethodInfo *)v696.klass);
		  this->fields._asmMaxDistance_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                   1000.0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                   (String *)"ASMMaxDistance",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmMaxDistance_k__BackingField,
		    v349,
		    v350,
		    v351,
		    (MethodInfo *)v696.klass);
		  this->fields._asmMaxTileRenderCountPerFrame_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                  8,
		                                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                  (String *)"ASMMaxTileRenderCountPerFrame",
		                                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmMaxTileRenderCountPerFrame_k__BackingField,
		    v352,
		    v353,
		    v354,
		    (MethodInfo *)v696.klass);
		  this->fields._asmDepthBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                 2.0,
		                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                 (String *)"ASMDepthBias",
		                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmDepthBias_k__BackingField,
		    v355,
		    v356,
		    v357,
		    (MethodInfo *)v696.klass);
		  this->fields._asmNormalBias_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                  0.1,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                  (String *)"ASMNormalBias",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmNormalBias_k__BackingField,
		    v358,
		    v359,
		    v360,
		    (MethodInfo *)v696.klass);
		  this->fields._asmScreenSizeMin_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                     0.0099999998,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                     (String *)"ASMScreenSizeMin",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._asmScreenSizeMin_k__BackingField,
		    v361,
		    v362,
		    v363,
		    (MethodInfo *)v696.klass);
		  this->fields._shadowDecalProjectorEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                0,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                (String *)"ShadowDecalProjectorEnabled",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._shadowDecalProjectorEnabled_k__BackingField,
		    v364,
		    v365,
		    v366,
		    (MethodInfo *)v696.klass);
		  this->fields._shadowDecalProjectorMaxCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                 1,
		                                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		                                                                 (String *)"ShadowDecalProjectorMaxCount",
		                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._shadowDecalProjectorMaxCount_k__BackingField,
		    v367,
		    v368,
		    v369,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                 1,
		                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                 (String *)"VisSHEnabled",
		                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHEnabled_k__BackingField,
		    v370,
		    v371,
		    v372,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHSphereIntervalScale_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                             0.80000001,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                             (String *)"VisSHSphereIntervalScale",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHSphereIntervalScale_k__BackingField,
		    v373,
		    v374,
		    v375,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHSphereRangeScale_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                          5.0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                          (String *)"VisSHSphereRangeScale",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHSphereRangeScale_k__BackingField,
		    v376,
		    v377,
		    v378,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHHalfRez_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                 1,
		                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                 (String *)"VisSHHalfRez",
		                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHHalfRez_k__BackingField,
		    v379,
		    v380,
		    v381,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHUseTileRendering_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                          0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                          (String *)"VisSHUseTileRendering",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHUseTileRendering_k__BackingField,
		    v382,
		    v383,
		    v384,
		    (MethodInfo *)v696.klass);
		  this->fields._visSHTileSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                  32,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		                                                  (String *)"VisSHTilSize",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._visSHTileSize_k__BackingField,
		    v385,
		    v386,
		    v387,
		    (MethodInfo *)v696.klass);
		  this->fields._transientGBuffer_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                     0,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                     (String *)"TransientGBuffer",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._transientGBuffer_k__BackingField,
		    v388,
		    v389,
		    v390,
		    (MethodInfo *)v696.klass);
		  this->fields._depthBitsGBuffer_k__BackingField = (SettingParameter_1_UnityEngine_Rendering_DepthBits_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0x20u, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME, (String *)"DepthBits", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::Rendering::DepthBits>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthBitsGBuffer_k__BackingField,
		    v391,
		    v392,
		    v393,
		    (MethodInfo *)v696.klass);
		  this->fields._depthCombinedWithStencil_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                             1,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                             (String *)"DepthCombinedWithStencil",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._depthCombinedWithStencil_k__BackingField,
		    v394,
		    v395,
		    v396,
		    (MethodInfo *)v696.klass);
		  this->fields._copySceneRTScale_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                     1.0,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                     (String *)"CopySceneRTScale",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._copySceneRTScale_k__BackingField,
		    v397,
		    v398,
		    v399,
		    (MethodInfo *)v696.klass);
		  this->fields._taauResolveResolutionHeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                2160,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                                (String *)"TAAUResolveResolutionHeight",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._taauResolveResolutionHeight_k__BackingField,
		    v400,
		    v401,
		    v402,
		    (MethodInfo *)v696.klass);
		  this->fields._renderingScale_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                   1.0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                   (String *)"RenderingScale",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._renderingScale_k__BackingField,
		    v403,
		    v404,
		    v405,
		    (MethodInfo *)v696.klass);
		  this->fields._backBufferResolutionHeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                               2160,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		                                                               (String *)"BackBufferResolutionHeight",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._backBufferResolutionHeight_k__BackingField,
		    v406,
		    v407,
		    v408,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                           0,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                           (String *)"Enable",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingEnable_k__BackingField,
		    v409,
		    v410,
		    v411,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingBudget_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                           512,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                           (String *)"Budget",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingBudget_k__BackingField,
		    v412,
		    v413,
		    v414,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingMaxBudget_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                              0x2000,
		                                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                              (String *)"MaxBudget",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingMaxBudget_k__BackingField,
		    v415,
		    v416,
		    v417,
		    (MethodInfo *)v696.klass);
		  this->fields._reservedMemoryForNonTextureStreaming_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                         3072,
		                                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                                         (String *)"ReservedMemoryForNonTextureStreaming",
		                                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reservedMemoryForNonTextureStreaming_k__BackingField,
		    v418,
		    v419,
		    v420,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingMobileBudgetPercent_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                        1.0,
		                                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                                        (String *)"MobileBudgetPercent",
		                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingMobileBudgetPercent_k__BackingField,
		    v421,
		    v422,
		    v423,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingRendererPerFrame_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                     512,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                                     (String *)"RendererPerFrame",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingRendererPerFrame_k__BackingField,
		    v424,
		    v425,
		    v426,
		    (MethodInfo *)v696.klass);
		  this->fields._textureStreamingMaxFileIORequests_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                      32,
		                                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		                                                                      (String *)"MaxFileIORequests",
		                                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureStreamingMaxFileIORequests_k__BackingField,
		    v427,
		    v428,
		    v429,
		    (MethodInfo *)v696.klass);
		  this->fields._textureQuality6GB_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                      2000,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		                                                      (String *)"TextureQuality_6GB",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureQuality6GB_k__BackingField,
		    v430,
		    v431,
		    v432,
		    (MethodInfo *)v696.klass);
		  this->fields._textureQuality8GB_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                      2500,
		                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		                                                      (String *)"TextureQuality_8GB",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureQuality8GB_k__BackingField,
		    v433,
		    v434,
		    v435,
		    (MethodInfo *)v696.klass);
		  this->fields._textureQuality10GB_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                       3500,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		                                                       (String *)"TextureQuality_10GB",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureQuality10GB_k__BackingField,
		    v436,
		    v437,
		    v438,
		    (MethodInfo *)v696.klass);
		  this->fields._textureQuality12GB_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                       4500,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		                                                       (String *)"TextureQuality_12GB",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureQuality12GB_k__BackingField,
		    v439,
		    v440,
		    v441,
		    (MethodInfo *)v696.klass);
		  this->fields._textureQuality16GB_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                       5500,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		                                                       (String *)"TextureQuality_16GB",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._textureQuality16GB_k__BackingField,
		    v442,
		    v443,
		    v444,
		    (MethodInfo *)v696.klass);
		  this->fields._contactShadowEnableParam_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                             0,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CONTACT_SHADOW_FEATURE_NAME,
		                                                             (String *)"contactShadowEnable",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._contactShadowEnableParam_k__BackingField,
		    v445,
		    v446,
		    v447,
		    (MethodInfo *)v696.klass);
		  this->fields._gtaoEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               1,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GTAO_FEATURE_NAME,
		                                               (String *)"GTAOEnable",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._gtaoEnable_k__BackingField,
		    v448,
		    v449,
		    v450,
		    (MethodInfo *)v696.klass);
		  this->fields._gtaoQualityLevel_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                     3,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GTAO_FEATURE_NAME,
		                                                     (String *)"GTAOQualityLevel",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._gtaoQualityLevel_k__BackingField,
		    v451,
		    v452,
		    v453,
		    (MethodInfo *)v696.klass);
		  this->fields._ssrEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                              0,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		                                              (String *)"ssrEnable",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ssrEnable_k__BackingField,
		    v454,
		    v455,
		    v456,
		    (MethodInfo *)v696.klass);
		  this->fields._ssrRayMarchingSampleCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                              32,
		                                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		                                                              (String *)"ssrRayMarchingSampleCount",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ssrRayMarchingSampleCount_k__BackingField,
		    v457,
		    v458,
		    v459,
		    (MethodInfo *)v696.klass);
		  this->fields._ssrImportanceSample_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        0,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		                                                        (String *)"ssrImportanceSample",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ssrImportanceSample_k__BackingField,
		    v460,
		    v461,
		    v462,
		    (MethodInfo *)v696.klass);
		  this->fields._ssrV2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                          0,
		                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		                                          (String *)"ssrV2",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ssrV2_k__BackingField,
		    v463,
		    v464,
		    v465,
		    (MethodInfo *)v696.klass);
		  this->fields._ssrV2Upsample_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                  0,
		                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		                                                  (String *)"ssrV2Upsample",
		                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._ssrV2Upsample_k__BackingField,
		    v466,
		    v467,
		    v468,
		    (MethodInfo *)v696.klass);
		  this->fields._fakePlanarReflectionEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FAKE_PR_FEATURE_NAME,
		                                                               (String *)"fakePlanarReflectionEnable",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._fakePlanarReflectionEnable_k__BackingField,
		    v469,
		    v470,
		    v471,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainFallbackGBuffer_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                           0,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                                           (String *)"TerrainFallbackGBuffer",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainFallbackGBuffer_k__BackingField,
		    v472,
		    v473,
		    v474,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainLODFactor_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                     900,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                                     (String *)"TerrainLODFactor",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainLODFactor_k__BackingField,
		    v475,
		    v476,
		    v477,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainIndirectionCPUUpload_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                0,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                                                (String *)"TerrainIndirectionCPUUpload",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainIndirectionCPUUpload_k__BackingField,
		    v478,
		    v479,
		    v480,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainSplitNormalRO_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         0,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                                         (String *)"TerrainSplitNormalRO",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainSplitNormalRO_k__BackingField,
		    v481,
		    v482,
		    v483,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainCompressUseBuffer_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                             0,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                                             (String *)"TerrainCompressUseBuffer",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainCompressUseBuffer_k__BackingField,
		    v484,
		    v485,
		    v486,
		    (MethodInfo *)v696.klass);
		  this->fields._terrainPOM_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                               0,
		                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		                                               (String *)"TerrainPOM",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainPOM_k__BackingField,
		    v487,
		    v488,
		    v489,
		    (MethodInfo *)v696.klass);
		  v490 = (HGTerrainDeformSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters);
		  v493 = v490;
		  if ( !v490 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGTerrainDeformSettingParameters::HGTerrainDeformSettingParameters(v490, 0LL);
		  this->fields._terrainDeform_k__BackingField = v493;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._terrainDeform_k__BackingField,
		    v494,
		    v495,
		    v496,
		    (MethodInfo *)v696.klass);
		  v497 = (HGErosionBlendSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters);
		  v498 = v497;
		  if ( !v497 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGErosionBlendSettingParameters::HGErosionBlendSettingParameters(v497, 0LL);
		  this->fields._erosionBlend_k__BackingField = v498;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._erosionBlend_k__BackingField,
		    v499,
		    v500,
		    v501,
		    (MethodInfo *)v696.klass);
		  v502 = (HGLightShaftSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGLightShaftSettingParameters);
		  v503 = v502;
		  if ( !v502 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGLightShaftSettingParameters::HGLightShaftSettingParameters(v502, 0LL);
		  this->fields._lightShaft_k__BackingField = v503;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._lightShaft_k__BackingField,
		    v504,
		    v505,
		    v506,
		    (MethodInfo *)v696.klass);
		  v507 = (HGRainAndWetnessSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters);
		  v508 = v507;
		  if ( !v507 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGRainAndWetnessSettingParameters::HGRainAndWetnessSettingParameters(v507, 0LL);
		  this->fields._rainAndWetness_k__BackingField = v508;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rainAndWetness_k__BackingField,
		    v509,
		    v510,
		    v511,
		    (MethodInfo *)v696.klass);
		  v512 = (HGSnowSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters);
		  v513 = v512;
		  if ( !v512 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGSnowSettingParameters::HGSnowSettingParameters(v512, 0LL);
		  this->fields._snow_k__BackingField = v513;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._snow_k__BackingField,
		    v514,
		    v515,
		    v516,
		    (MethodInfo *)v696.klass);
		  v517 = (HGVerticalOcclusionMapSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters);
		  v518 = v517;
		  if ( !v517 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters::HGVerticalOcclusionMapSettingParameters(v517, 0LL);
		  this->fields._verticalOcclusionMap_k__BackingField = v518;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._verticalOcclusionMap_k__BackingField,
		    v519,
		    v520,
		    v521,
		    (MethodInfo *)v696.klass);
		  v522 = (HGAtmosphereSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereSettingParameters);
		  v523 = v522;
		  if ( !v522 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGAtmosphereSettingParameters::HGAtmosphereSettingParameters(v522, 0LL);
		  this->fields._atmosphereParams_k__BackingField = v523;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._atmosphereParams_k__BackingField,
		    v524,
		    v525,
		    v526,
		    (MethodInfo *)v696.klass);
		  v527 = (HGVolumetricCloudSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudSettingParameters);
		  v528 = v527;
		  if ( !v527 )
		    goto LABEL_22;
		  HG::Rendering::Runtime::HGVolumetricCloudSettingParameters::HGVolumetricCloudSettingParameters(v527, 0LL);
		  this->fields._volumetricCloud_k__BackingField = v528;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._volumetricCloud_k__BackingField,
		    v529,
		    v530,
		    v531,
		    (MethodInfo *)v696.klass);
		  this->fields._waterPrepassTextureSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                            512.0,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                            (String *)"waterPrepassTextureSize",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterPrepassTextureSize_k__BackingField,
		    v532,
		    v533,
		    v534,
		    (MethodInfo *)v696.klass);
		  this->fields._waterInteractiveEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                           1,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                           (String *)"waterInteractiveEnable",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterInteractiveEnable_k__BackingField,
		    v535,
		    v536,
		    v537,
		    (MethodInfo *)v696.klass);
		  this->fields._waterIndirectEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        1,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                        (String *)"waterIndirectEnable",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterIndirectEnable_k__BackingField,
		    v538,
		    v539,
		    v540,
		    (MethodInfo *)v696.klass);
		  this->fields._waterUseAnchorSH_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                     0,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                     (String *)"waterUseAnchorSH",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterUseAnchorSH_k__BackingField,
		    v541,
		    v542,
		    v543,
		    (MethodInfo *)v696.klass);
		  this->fields._waterVRRx_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                              1,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                              (String *)"waterVRRx",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterVRRx_k__BackingField,
		    v544,
		    v545,
		    v546,
		    (MethodInfo *)v696.klass);
		  this->fields._waterVRRy_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                              1,
		                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                              (String *)"waterVRRy",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterVRRy_k__BackingField,
		    v547,
		    v548,
		    v549,
		    (MethodInfo *)v696.klass);
		  this->fields._waterDisplacementWeight_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                            1.0,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                            (String *)"waterDisplacementWeight",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterDisplacementWeight_k__BackingField,
		    v550,
		    v551,
		    v552,
		    (MethodInfo *)v696.klass);
		  this->fields._waterDisplacementDistance_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                              32.0,
		                                                              TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                              (String *)"waterDisplacementDistance",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterDisplacementDistance_k__BackingField,
		    v553,
		    v554,
		    v555,
		    (MethodInfo *)v696.klass);
		  this->fields._waterHeightTextureSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                           1024,
		                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                           (String *)"waterHeightTextureSize",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterHeightTextureSize_k__BackingField,
		    v556,
		    v557,
		    v558,
		    (MethodInfo *)v696.klass);
		  this->fields._waterLODNumAdded_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                     0,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                     (String *)"waterLODNumAdded",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterLODNumAdded_k__BackingField,
		    v559,
		    v560,
		    v561,
		    (MethodInfo *)v696.klass);
		  this->fields._waterMeshNumPerLODAdded_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                            0,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                            (String *)"waterMeshNumPerLODAdded",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterMeshNumPerLODAdded_k__BackingField,
		    v562,
		    v563,
		    v564,
		    (MethodInfo *)v696.klass);
		  this->fields._waterMeshSizeAdded_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                       0,
		                                                       TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                       (String *)"waterMeshSizeAdded",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterMeshSizeAdded_k__BackingField,
		    v565,
		    v566,
		    v567,
		    (MethodInfo *)v696.klass);
		  this->fields._waterHeightMapXZAdded_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                          0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                          (String *)"waterHeightMapXZAdded",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterHeightMapXZAdded_k__BackingField,
		    v568,
		    v569,
		    v570,
		    (MethodInfo *)v696.klass);
		  this->fields._waterSectorRendering_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         1,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		                                                         (String *)"WaterSectorRendering",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._waterSectorRendering_k__BackingField,
		    v571,
		    v572,
		    v573,
		    (MethodInfo *)v696.klass);
		  this->fields._foliageInteractiveEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                             1,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FOLIAGE_NAME,
		                                                             (String *)"foliageInteractiveEnable",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._foliageInteractiveEnable_k__BackingField,
		    v574,
		    v575,
		    v576,
		    (MethodInfo *)v696.klass);
		  this->fields._artTagLODBiasAll_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                     1.0,
		                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ART_TAGS_NAME,
		                                                     (String *)"LODBias.All",
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._artTagLODBiasAll_k__BackingField,
		    v577,
		    v578,
		    v579,
		    (MethodInfo *)v696.klass);
		  v580 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<float>>);
		  v581 = (List_1_HG_Rendering_Runtime_SettingParameter_1_System_Single_ *)v580;
		  if ( !v580 )
		LABEL_22:
		    sub_1800D8260(v492, v491);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v580,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<float>>::List);
		  this->fields._artTagLODBias_k__BackingField = v581;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._artTagLODBias_k__BackingField,
		    v582,
		    v583,
		    v584,
		    (MethodInfo *)v696.klass);
		  for ( i = 0; i < 35; ++i )
		  {
		    v586 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		    artTagLODBias_k__BackingField = (List_1_System_Object_ *)this->fields._artTagLODBias_k__BackingField;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSettingParameters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSettingParameters);
		      v586 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		    }
		    static_fields = v586->static_fields;
		    v696.monitor = (MonitorData *)-1LL;
		    v697 = i;
		    ART_TAGS_NAME = static_fields->ART_TAGS_NAME;
		    v696.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::ArtTags;
		    v590 = (Object *)System::Enum::ToString(&v696, 0LL);
		    if ( !TypeInfo::Cysharp::Text::ZString->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::Cysharp::Text::ZString);
		    v591 = (String *)sub_182F27000((String *)"LODBias.{0}", v590);
		    v592 = (Object *)HG::Rendering::Runtime::SettingParameter::Create<float>(
		                       1.0,
		                       ART_TAGS_NAME,
		                       v591,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		    if ( !artTagLODBias_k__BackingField )
		      goto LABEL_22;
		    sub_182F01190(artTagLODBias_k__BackingField, v592);
		  }
		  v593 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSettingParameters);
		    v593 = TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  }
		  this->fields._shouldSplitOnePass_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                       0,
		                                                       v593->static_fields->ONE_PASS_FEATURE_NAME,
		                                                       (String *)"shouldSplitOnePass",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._shouldSplitOnePass_k__BackingField,
		    v594,
		    v595,
		    v596,
		    (MethodInfo *)v696.klass);
		  this->fields._reflectionProbeUseRGBAHalf_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		                                                               (String *)"reflectionProbeUseRGBAHalf",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reflectionProbeUseRGBAHalf_k__BackingField,
		    v597,
		    v598,
		    v599,
		    (MethodInfo *)v696.klass);
		  this->fields._reflectionProbeOctTextureArrayCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                        32,
		                                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		                                                                        (String *)"reflectionProbeOctTextureArrayCount",
		                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reflectionProbeOctTextureArrayCount_k__BackingField,
		    v600,
		    v601,
		    v602,
		    (MethodInfo *)v696.klass);
		  this->fields._reflectionProbeOctTextureSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                  512,
		                                                                  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		                                                                  (String *)"reflectionProbeOctTextureSize",
		                                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reflectionProbeOctTextureSize_k__BackingField,
		    v603,
		    v604,
		    v605,
		    (MethodInfo *)v696.klass);
		  this->fields._reflectionProbeMaxSampleMip_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                7,
		                                                                TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		                                                                (String *)"reflectionProbeMaxSampleMip",
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reflectionProbeMaxSampleMip_k__BackingField,
		    v606,
		    v607,
		    v608,
		    (MethodInfo *)v696.klass);
		  this->fields._reflectionProbeMaxBlitCountPerFrame_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                        3,
		                                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		                                                                        (String *)"reflectionProbeMaxBlitCountPerFrame",
		                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._reflectionProbeMaxBlitCountPerFrame_k__BackingField,
		    v609,
		    v610,
		    v611,
		    (MethodInfo *)v696.klass);
		  this->fields._transparentLowResOffscreenEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                     0,
		                                                                     TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME,
		                                                                     (String *)"transparentLowResOffscreenEnable",
		                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._transparentLowResOffscreenEnable_k__BackingField,
		    v612,
		    v613,
		    v614,
		    (MethodInfo *)v696.klass);
		  this->fields._transparentLowResVRSEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME,
		                                                               (String *)"transparentLowResEnable",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._transparentLowResVRSEnable_k__BackingField,
		    v615,
		    v616,
		    v617,
		    (MethodInfo *)v696.klass);
		  this->fields._transparentVRRx_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    1,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME,
		                                                    (String *)"transparentVRRx",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._transparentVRRx_k__BackingField,
		    v618,
		    v619,
		    v620,
		    (MethodInfo *)v696.klass);
		  this->fields._transparentVRRy_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    1,
		                                                    TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME,
		                                                    (String *)"transparentVRRy",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._transparentVRRy_k__BackingField,
		    v621,
		    v622,
		    v623,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                               0,
		                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                               (String *)"rayTracingReflectionEnable",
		                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionEnable_k__BackingField,
		    v624,
		    v625,
		    v626,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionMode_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                             0,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                             (String *)"rayTracingReflectionMode",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionMode_k__BackingField,
		    v627,
		    v628,
		    v629,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionSSQuality0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.2,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionSSQuality0",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionSSQuality0_k__BackingField,
		    v630,
		    v631,
		    v632,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionSSQuality1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.5,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionSSQuality1",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionSSQuality1_k__BackingField,
		    v633,
		    v634,
		    v635,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionSSQuality2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.89999998,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionSSQuality2",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionSSQuality2_k__BackingField,
		    v636,
		    v637,
		    v638,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionSSQuality3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   1.0,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionSSQuality3",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionSSQuality3_k__BackingField,
		    v639,
		    v640,
		    v641,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionRTQuality0_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.30000001,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionRTQuality0",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionRTQuality0_k__BackingField,
		    v642,
		    v643,
		    v644,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionRTQuality1_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.5,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionRTQuality1",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionRTQuality1_k__BackingField,
		    v645,
		    v646,
		    v647,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionRTQuality2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   0.89999998,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionRTQuality2",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionRTQuality2_k__BackingField,
		    v648,
		    v649,
		    v650,
		    (MethodInfo *)v696.klass);
		  this->fields._rayTracingReflectionRTQuality3_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                   1.0,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		                                                                   (String *)"rayTracingReflectionRTQuality3",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._rayTracingReflectionRTQuality3_k__BackingField,
		    v651,
		    v652,
		    v653,
		    (MethodInfo *)v696.klass);
		  this->fields._frameInterpolationEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                             0,
		                                                             TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME,
		                                                             (String *)"frameInterpolationEnable",
		                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._frameInterpolationEnable_k__BackingField,
		    v654,
		    v655,
		    v656,
		    (MethodInfo *)v696.klass);
		  this->fields._frameInterpolationPause_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                            0,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME,
		                                                            (String *)"frameInterpolationPause",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._frameInterpolationPause_k__BackingField,
		    v657,
		    v658,
		    v659,
		    (MethodInfo *)v696.klass);
		  this->fields._frameInterpolationAlgo_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_FrameInterpolationAlgo_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>((Int32Enum__Enum)0, TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME, (String *)"frameInterpolationAlgo", MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._frameInterpolationAlgo_k__BackingField,
		    v660,
		    v661,
		    v662,
		    (MethodInfo *)v696.klass);
		  this->fields._hasWorldUIAfterFrameInterpolation_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                      1,
		                                                                      TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME,
		                                                                      (String *)"hasWorldUIAfterFrameInterpolation",
		                                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._hasWorldUIAfterFrameInterpolation_k__BackingField,
		    v663,
		    v664,
		    v665,
		    (MethodInfo *)v696.klass);
		  this->fields._afmeCameraRotationCosFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                           0.98479998,
		                                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->AFME_THRESHOLD_NAME,
		                                                                           (String *)"afmeCameraRotationCosFallbackThreshold",
		                                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._afmeCameraRotationCosFallbackThreshold_k__BackingField,
		    v666,
		    v667,
		    v668,
		    (MethodInfo *)v696.klass);
		  this->fields._afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                               1.0,
		                                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->AFME_THRESHOLD_NAME,
		                                                                               (String *)"afmeCameraMoveDistanceSqrFallbackThreshold",
		                                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField,
		    v669,
		    v670,
		    v671,
		    (MethodInfo *)v696.klass);
		  this->fields._mfrcCameraRotationCosFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                           0.9659,
		                                                                           TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		                                                                           (String *)"mfrcCameraRotationCosFallbackThreshold",
		                                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._mfrcCameraRotationCosFallbackThreshold_k__BackingField,
		    v672,
		    v673,
		    v674,
		    (MethodInfo *)v696.klass);
		  this->fields._mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                               1.0,
		                                                                               TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		                                                                               (String *)"mfrcCameraMoveDistanceSqrFallbackThreshold",
		                                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField,
		    v675,
		    v676,
		    v677,
		    (MethodInfo *)v696.klass);
		  this->fields._mfrcGeneralFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                 0.2,
		                                                                 TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		                                                                 (String *)"mfrcGeneralFallbackThreshold",
		                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._mfrcGeneralFallbackThreshold_k__BackingField,
		    v678,
		    v679,
		    v680,
		    (MethodInfo *)v696.klass);
		  this->fields._mfrcBrightnessDiffFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                        0.015,
		                                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		                                                                        (String *)"mfrcBrightnessDiffFallbackThreshold",
		                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._mfrcBrightnessDiffFallbackThreshold_k__BackingField,
		    v681,
		    v682,
		    v683,
		    (MethodInfo *)v696.klass);
		  this->fields._mfrcRepeatedPatternFallbackThreshold_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                                         1.0,
		                                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		                                                                         (String *)"mfrcRepeatedPatternFallbackThreshold",
		                                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._mfrcRepeatedPatternFallbackThreshold_k__BackingField,
		    v684,
		    v685,
		    v686,
		    (MethodInfo *)v696.klass);
		  this->fields._inkSimulationResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                            128,
		                                                            TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->INK_NAME,
		                                                            (String *)"inkSimulationResolution",
		                                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._inkSimulationResolution_k__BackingField,
		    v687,
		    v688,
		    v689,
		    (MethodInfo *)v696.klass);
		  this->fields._inkDensityResolution_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                         512,
		                                                         TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->INK_NAME,
		                                                         (String *)"inkDensityResolution",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._inkDensityResolution_k__BackingField,
		    v690,
		    v691,
		    v692,
		    (MethodInfo *)v696.klass);
		  this->fields._inkSimulationEnable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        1,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->INK_NAME,
		                                                        (String *)"inkSimulationEnable",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._inkSimulationEnable_k__BackingField, v693, v694, v695, v698);
		}
		
		static HGSettingParameters() {} // 0x000000018479ECD0-0x000000018479F3A0
		// HGSettingParameters()
		void HG::Rendering::Runtime::HGSettingParameters::cctor(MethodInfo *method)
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
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  HGRuntimeGrassQuery_Node *v26; // rdx
		  HGRuntimeGrassQuery_Node *v27; // r8
		  Int32__Array **v28; // r9
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  HGRuntimeGrassQuery_Node *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGRuntimeGrassQuery_Node *v41; // rdx
		  HGRuntimeGrassQuery_Node *v42; // r8
		  Int32__Array **v43; // r9
		  HGRuntimeGrassQuery_Node *v44; // rdx
		  HGRuntimeGrassQuery_Node *v45; // r8
		  Int32__Array **v46; // r9
		  HGRuntimeGrassQuery_Node *v47; // rdx
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Int32__Array **v49; // r9
		  HGRuntimeGrassQuery_Node *v50; // rdx
		  HGRuntimeGrassQuery_Node *v51; // r8
		  Int32__Array **v52; // r9
		  HGRuntimeGrassQuery_Node *v53; // rdx
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  HGRuntimeGrassQuery_Node *v56; // rdx
		  HGRuntimeGrassQuery_Node *v57; // r8
		  Int32__Array **v58; // r9
		  HGRuntimeGrassQuery_Node *v59; // rdx
		  HGRuntimeGrassQuery_Node *v60; // r8
		  Int32__Array **v61; // r9
		  HGRuntimeGrassQuery_Node *v62; // rdx
		  HGRuntimeGrassQuery_Node *v63; // r8
		  Int32__Array **v64; // r9
		  HGRuntimeGrassQuery_Node *v65; // rdx
		  HGRuntimeGrassQuery_Node *v66; // r8
		  Int32__Array **v67; // r9
		  HGRuntimeGrassQuery_Node *v68; // rdx
		  HGRuntimeGrassQuery_Node *v69; // r8
		  Int32__Array **v70; // r9
		  HGRuntimeGrassQuery_Node *v71; // rdx
		  HGRuntimeGrassQuery_Node *v72; // r8
		  Int32__Array **v73; // r9
		  HGRuntimeGrassQuery_Node *v74; // rdx
		  HGRuntimeGrassQuery_Node *v75; // r8
		  Int32__Array **v76; // r9
		  HGRuntimeGrassQuery_Node *v77; // rdx
		  HGRuntimeGrassQuery_Node *v78; // r8
		  Int32__Array **v79; // r9
		  HGRuntimeGrassQuery_Node *v80; // rdx
		  HGRuntimeGrassQuery_Node *v81; // r8
		  Int32__Array **v82; // r9
		  HGRuntimeGrassQuery_Node *v83; // rdx
		  HGRuntimeGrassQuery_Node *v84; // r8
		  Int32__Array **v85; // r9
		  HGRuntimeGrassQuery_Node *v86; // rdx
		  HGRuntimeGrassQuery_Node *v87; // r8
		  Int32__Array **v88; // r9
		  HGRuntimeGrassQuery_Node *v89; // rdx
		  HGRuntimeGrassQuery_Node *v90; // r8
		  Int32__Array **v91; // r9
		  HGRuntimeGrassQuery_Node *v92; // rdx
		  HGRuntimeGrassQuery_Node *v93; // r8
		  Int32__Array **v94; // r9
		  HGRuntimeGrassQuery_Node *v95; // rdx
		  HGRuntimeGrassQuery_Node *v96; // r8
		  Int32__Array **v97; // r9
		  HGRuntimeGrassQuery_Node *v98; // rdx
		  HGRuntimeGrassQuery_Node *v99; // r8
		  Int32__Array **v100; // r9
		  HGRuntimeGrassQuery_Node *v101; // rdx
		  HGRuntimeGrassQuery_Node *v102; // r8
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
		  MethodInfo *v113; // [rsp+20h] [rbp-8h]
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
		  MethodInfo *v136; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ECS_FEATURE_NAME = (String *)"ECS";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v103);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME = (String *)"TAAU";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TAAU_FEATURE_NAME,
		    v5,
		    v6,
		    v4,
		    v104);
		  v7 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PSSR_FEATURE_NAME = (String *)"PSSR";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PSSR_FEATURE_NAME,
		    v8,
		    v9,
		    v7,
		    v105);
		  v10 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME = (String *)"DLSS";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSS_FEATURE_NAME,
		    v11,
		    v12,
		    v10,
		    v106);
		  v13 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME = (String *)"DLSSG";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->DLSSG_FEATURE_NAME,
		    v14,
		    v15,
		    v13,
		    v107);
		  v16 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME = (String *)"FSR3";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3_FEATURE_NAME,
		    v17,
		    v18,
		    v16,
		    v108);
		  v19 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3FI_FEATURE_NAME = (String *)"FSR3FI";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FSR3FI_FEATURE_NAME,
		    v20,
		    v21,
		    v19,
		    v109);
		  v22 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME = (String *)"PostProcess";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->PP_FEATURE_NAME,
		    v23,
		    v24,
		    v22,
		    v110);
		  v25 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ASTREAKS_FEATURE_NAME = (String *)"AStreaks";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ASTREAKS_FEATURE_NAME,
		    v26,
		    v27,
		    v25,
		    v111);
		  v28 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->LIGHTING_FEATURE_NAME = (String *)"Lighting";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->LIGHTING_FEATURE_NAME,
		    v29,
		    v30,
		    v28,
		    v112);
		  v31 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME = (String *)"SSR";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SSR_FEATURE_NAME,
		    v32,
		    v33,
		    v31,
		    v113);
		  v34 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FAKE_PR_FEATURE_NAME = (String *)"FakePR";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FAKE_PR_FEATURE_NAME,
		    v35,
		    v36,
		    v34,
		    v114);
		  v37 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME = (String *)"ShadowMap";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->SHADOWMAP_FEATURE_NAME,
		    v38,
		    v39,
		    v37,
		    v115);
		  v40 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME = (String *)"VisibilitySH";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->VISIBILITY_SH_FEATURE_NAME,
		    v41,
		    v42,
		    v40,
		    v116);
		  v43 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME = (String *)"RenderTargetSettings";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RT_SETTING_NAME,
		    v44,
		    v45,
		    v43,
		    v117);
		  v46 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME = (String *)"TextureStreaming";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_STREAMING_SETTING_NAME,
		    v47,
		    v48,
		    v46,
		    v118);
		  v49 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME = (String *)"TextureQuality";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TEXTURE_QUALITY_SETTING_NAME,
		    v50,
		    v51,
		    v49,
		    v119);
		  v52 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CONTACT_SHADOW_FEATURE_NAME = (String *)"ContactShadow";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CONTACT_SHADOW_FEATURE_NAME,
		    v53,
		    v54,
		    v52,
		    v120);
		  v55 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GTAO_FEATURE_NAME = (String *)"GTAO";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GTAO_FEATURE_NAME,
		    v56,
		    v57,
		    v55,
		    v121);
		  v58 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MISC_NAME = (String *)"Misc";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MISC_NAME,
		    v59,
		    v60,
		    v58,
		    v122);
		  v61 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GRASS_NAME = (String *)"Grass";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->GRASS_NAME,
		    v62,
		    v63,
		    v61,
		    v123);
		  v64 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME = (String *)"Terrain";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TERRAIN_NAME,
		    v65,
		    v66,
		    v64,
		    v124);
		  v67 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME = (String *)"Water";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->WATER_NAME,
		    v68,
		    v69,
		    v67,
		    v125);
		  v70 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FOLIAGE_NAME = (String *)"Foliage";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FOLIAGE_NAME,
		    v71,
		    v72,
		    v70,
		    v126);
		  v73 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ART_TAGS_NAME = (String *)"ArtTags";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ART_TAGS_NAME,
		    v74,
		    v75,
		    v73,
		    v127);
		  v76 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ONE_PASS_FEATURE_NAME = (String *)"OnePassDeferred";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->ONE_PASS_FEATURE_NAME,
		    v77,
		    v78,
		    v76,
		    v128);
		  v79 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME = (String *)"ReflectionProbe";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->REFLECTION_PROBE_TAGS_NAME,
		    v80,
		    v81,
		    v79,
		    v129);
		  v82 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME = (String *)"Transparent";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->TRANSPARENT_NAME,
		    v83,
		    v84,
		    v82,
		    v130);
		  v85 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CHROMATIC_ABERRATION_TRACING_NAME = (String *)"ChromaticAberration";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->CHROMATIC_ABERRATION_TRACING_NAME,
		    v86,
		    v87,
		    v85,
		    v131);
		  v88 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME = (String *)"RayTracing";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->RAY_TRACING_NAME,
		    v89,
		    v90,
		    v88,
		    v132);
		  v91 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME = (String *)"FrameInterpolation";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->FRAME_INTERPOLATION_NAME,
		    v92,
		    v93,
		    v91,
		    v133);
		  v94 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->AFME_THRESHOLD_NAME = (String *)"AFMEThreshold";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->AFME_THRESHOLD_NAME,
		    v95,
		    v96,
		    v94,
		    v134);
		  v97 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME = (String *)"MFRCThreshold";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->MFRC_THRESHOLD_NAME,
		    v98,
		    v99,
		    v97,
		    v135);
		  v100 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGSettingParameters;
		  TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->INK_NAME = (String *)"Ink";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSettingParameters->static_fields->INK_NAME,
		    v101,
		    v102,
		    v100,
		    v136);
		}
		
	}
}
