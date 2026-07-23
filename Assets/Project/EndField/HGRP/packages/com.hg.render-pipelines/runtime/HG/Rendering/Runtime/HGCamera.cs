using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[DebuggerDisplay("({camera.name})")]
	public class HGCamera // TypeDefIndex: 38102
	{
		// Fields
		private Vector2Int m_finalRTSize; // 0x48
		public Frustum frustum; // 0x50
		public Camera camera; // 0x60
		public Vector4 taaJitter; // 0x68
		public ViewConstants mainViewConstants; // 0x78
		public bool prevTransformReset; // 0x668
		public Rect? overridePixelRect; // 0x674
		internal ComputeBuffer autoExposureHistogramBuffer; // 0x6B0
		internal float[] autoExposureHistogramRes; // 0x6B8
		internal bool autoExposureReadyForNextFetch; // 0x6C0
		public float exposureTargetAdaptation; // 0x6C4
		public float exposureAdaptation; // 0x6C8
		public float waterCameraFoVInc; // 0x6CC
		public float waterCameraPositionOffset; // 0x6D0
		internal HGVerticalOcclusionMapManager verticalOcclusionMapManager; // 0x6D8
		private List<HashSet<RTHandle>>[] m_rtExtractionLists; // 0x6E0
		private uint m_nextWaterMarkHandle; // 0x6E8
		private Dictionary<uint, ValueTuple<RTHandle, RTHandle, float>> m_waterMarkRTs; // 0x6F0
		private List<ValueTuple<RTHandle, float>> m_inplaceWaterMarkRTs; // 0x6F8
		internal bool previousFrameWasTAAUpsampled; // 0x700
		private bool m_DisableFrameGenTemporarily; // 0x701
		public long renderPathInstanceCPP; // 0x710
		public unsafe HGRenderPathBeforeCullingParamsCPP* beforeCullingParams; // 0x718
		public Material lutBuilder2DMaterialCPP; // 0x720
		public Material uiImageBlurMatCPP; // 0x728
		internal Material fishEyeEffectMaterialCPP; // 0x730
		internal HGShadowManager shadowManager; // 0x738
		internal HGLightCookieManager lightCookieManager; // 0x740
		internal bool regenerateAsmTriggerForCpp; // 0x748
		internal Vector4[] frustumPlaneEquations; // 0x750
		internal int taaFrameIndex; // 0x758
		internal float taaSharpenStrength; // 0x75C
		internal float taaHistorySharpening; // 0x760
		internal float taaAntiFlicker; // 0x764
		internal float taaMotionVectorRejection; // 0x768
		internal float taaBaseBlendFactor; // 0x76C
		internal bool taaAntiRinging; // 0x770
		internal int taaJitterPhaseCount; // 0x774
		internal Vector4 zBufferParams; // 0x778
		internal Vector4 unity_OrthoParams; // 0x788
		internal Vector4 projectionParams; // 0x798
		internal Vector4 screenParams; // 0x7A8
		internal int volumeLayerMask; // 0x7B8
		internal Transform volumeAnchor; // 0x7C0
		internal Rect finalViewport; // 0x7C8
		internal Rect prevFinalViewport; // 0x7D8
		internal int colorPyramidHistoryMipCount; // 0x7E8
		internal RenderTexture volumetricIntegratedLightScatteringTexture; // 0x7F0
		internal RenderTexture historyVolumetricLightScatteringTexture; // 0x7F8
		internal float historyVolumetricLightScatteringPreExposure; // 0x800
		internal RenderTexture atmosphereSkyViewLutTexture; // 0x808
		internal HGAtmosphereRenderer.AtmosphereLutConstants atmosphereLutConstants; // 0x810
		internal const int PINGPONG_COUNT = 2; // Metadata: 0x023038BD
		internal Matrix4x4 frustumCornorsRay; // 0x8D0
		internal Mesh parafinMesh; // 0x910
		public static readonly uint COMPOUND_CHARACTER_LAYER_MASK; // 0x08
		private bool m_firstGetDoFComponent; // 0x918
		internal uint cameraFrameCount; // 0x91C
		private Camera m_parentCamera; // 0x920
		internal float lowResScale; // 0x928
		internal bool realtimeReflectionProbe; // 0x92C
		internal bool isPersistent; // 0x92D
		internal HGUtils.PackedMipChainInfo m_DepthBufferMipChainInfo; // 0x930
		private HGAdditionalCameraData.ClearColorMode m_PreviousClearColorMode; // 0x968
		private HGAdditionalCameraData.AntialiasingMode m_antialiasingMode; // 0x96C
		internal NativeArray<int> sortingOrdersToBlurInternal; // 0x970
		internal bool enableUpdatingSceneFrostedGlass; // 0x980
		private short m_uiAfterBlurSortingOrder; // 0x982
		private List<int> m_sortingOrdersToBlur; // 0x988
		private HGCamera m_lwCameraAttached; // 0x990
		public bool applyTableSettings; // 0x998
		internal bool resetPostProcessingHistory; // 0x999
		internal bool didResetPostProcessingHistoryInLastFrame; // 0x99A
		private VolumeComponentsData m_volumeComponentsData; // 0x9C8
		public HGEnvironmentVolumeCameraComponent m_envVolumeCameraComponent; // 0x9D0
		public float screenCullingRatio; // 0x9D8
		public float screenRatioCullingDistance; // 0x9DC
		private uint _screenCullingLayerMask; // 0x9E0
		internal bool preivousEnableCppRenderPath; // 0x9E4
		internal bool enableShadowCulling; // 0x9E5
		internal LODCrossFadeConfig lodCrossFadeConfig; // 0x9E8
		internal uint cullingViewHandle; // 0xA20
		internal JobHandle cullingJobHandle; // 0xA28
		internal int vtFeedbackViewId; // 0xA38
		internal int subdivisionHandle; // 0xA3C
		internal uint terrainCullViewHandle; // 0xA40
		internal uint editorTerrainCullViewHandle; // 0xA44
		internal uint waterProxyVisibleCount; // 0xA48
		internal uint waterDecalVisibleCount; // 0xA4C
		internal uint waterProxyCullHandle; // 0xA50
		internal uint waterDecalCullHandle; // 0xA54
		internal Matrix4x4 waterCullingMatrix; // 0xA58
		internal bool useWetnessMask; // 0xA98
		internal bool reflectionProbeReset; // 0xA99
		internal uint reflectionProbeViewHandle; // 0xA9C
		internal int reflectionProbeOctTextureSize; // 0xAA0
		internal int reflectionProbeOctTextureArrayCount; // 0xAA4
		internal GraphicsFormat reflectionProbeOctTextureFormat; // 0xAA8
		internal uint cullingViewUniqueID; // 0xAAC
		internal uint rayTracingCullingViewHandle; // 0xAB0
		internal uint rayTracingTLASHandle; // 0xAB4
		internal bool overrideCsmShadowDistance; // 0xAB8
		internal float overrideCsmMaxDistanceValue; // 0xABC
		public static Dictionary<ValueTuple<Camera, int>, HGCamera> s_Cameras; // 0x10
		private static List<ValueTuple<Camera, int>> s_Cleanup; // 0x18
		private static int worldUILayerIndex; // 0x20
		private HGAdditionalCameraData m_AdditionalCameraData; // 0xAC0
		private BufferedRTHandleSystem m_HistoryRTSystem; // 0xAC8
		private IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> m_RecorderCaptureActions; // 0xAD0
		private int m_RecorderTempRT; // 0xAD8
		private MaterialPropertyBlock m_RecorderPropertyBlock; // 0xAE0
		private int m_ForceJitterIdx; // 0xAE8
	
		// Properties
		public string name { get; private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
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
		
		internal Vector2Int taauRTSize { get; private set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		

		// Void set_value(Vector2)
		void UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector2>::set_value(
		        VolumeParameter_1_UnityEngine_Vector2_ *this,
		        Vector2 value,
		        MethodInfo *method)
		{
		  this->fields.m_Value = value;
		}
		
		internal Vector4 taauRTSizeParam { get; private set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
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
		
		internal Vector2Int sceneRTSize { get; private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x00000001811F36F0-0x00000001811F3700
		// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
		IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
		        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
		}
		

		// Void set_AreaMax(Vector2)
		void HG::Rendering::HgMath::CellGrid2D<System::Object>::set_AreaMax(
		        CellGrid2D_1_System_Object_ *this,
		        Vector2 value,
		        MethodInfo *method)
		{
		  this->fields._AreaMax_k__BackingField = value;
		}
		
		internal Vector4 sceneRTSizeParam { get; private set; } // 0x0000000184D8FD20-0x0000000184D8FD30 0x0000000184D91AB0-0x0000000184D91AC0
		// Nullable`1[Int64] get_To()
		Nullable_1_Int64_ *System::Net::Http::Headers::ContentRangeHeaderValue::get_To(
		        Nullable_1_Int64_ *__return_ptr retstr,
		        ContentRangeHeaderValue *this,
		        MethodInfo *method)
		{
		  Nullable_1_Int64_ *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._To_k__BackingField;
		  return result;
		}
		

		// BBParameter`1[UnityEngine.Vector4](Vector4)
		void NodeCanvas::Framework::BBParameter<UnityEngine::Vector4>::BBParameter(
		        BBParameter_1_UnityEngine_Vector4_ *this,
		        Vector4 *value,
		        MethodInfo *method)
		{
		  this->fields._value = *value;
		}
		
		public Vector2Int finalRTSize { get => default; set {} } // 0x00000001830FF3E0-0x00000001830FF450 0x0000000184CD9380-0x0000000184CD93C0
		// Vector2Int get_finalRTSize()
		Vector2Int HG::Rendering::Runtime::HGCamera::get_finalRTSize(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 713 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x2C9 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[15]._0.generic_class )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(713, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_283(Patch, (Object *)this, 0LL);
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		    return this->fields._taauRTSize_k__BackingField;
		  else
		    return this->fields.m_finalRTSize;
		}
		

		// Void set_finalRTSize(Vector2Int)
		void HG::Rendering::Runtime::HGCamera::set_finalRTSize(HGCamera *this, Vector2Int value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(715, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(715, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_284(Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_finalRTSize = value;
		  }
		}
		
		internal Vector4 finalRTSizeParam { get => default; } // 0x00000001832E0B60-0x00000001832E0C20 
		// Vector4 get_finalRTSizeParam()
		Vector4 *HG::Rendering::Runtime::HGCamera::get_finalRTSizeParam(
		        Vector4 *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __m128i v7; // xmm2
		  float m_X; // xmm0_4
		  __m128i v9; // xmm1
		  Vector4 taauRTSizeParam_k__BackingField; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 889 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_9:
		    sub_1800D8260(v5, wrapperArray);
		  if ( LODWORD(v5->_0.namespaze) <= 0x379 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( v5[19]._0.image )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
		    if ( Patch )
		    {
		      taauRTSizeParam_k__BackingField = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(
		                                           &v13,
		                                           Patch,
		                                           (Object *)this,
		                                           0LL);
		      goto LABEL_19;
		    }
		    goto LABEL_9;
		  }
		LABEL_5:
		  if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		  {
		    taauRTSizeParam_k__BackingField = this->fields._taauRTSizeParam_k__BackingField;
		LABEL_19:
		    *retstr = taauRTSizeParam_k__BackingField;
		    return retstr;
		  }
		  v7 = _mm_cvtsi32_si128(this->fields.m_finalRTSize.m_X);
		  m_X = (float)this->fields.m_finalRTSize.m_X;
		  retstr->y = (float)this->fields.m_finalRTSize.m_Y;
		  v9 = _mm_cvtsi32_si128(this->fields.m_finalRTSize.m_Y);
		  retstr->x = m_X;
		  retstr->w = 1.0 / _mm_cvtepi32_ps(v9).m128_f32[0];
		  retstr->z = 1.0 / _mm_cvtepi32_ps(v7).m128_f32[0];
		  return retstr;
		}
		
		public int actualWidth { get; private set; } // 0x0000000184DA1600-0x0000000184DA1610 0x0000000184DA16D0-0x0000000184DA16E0
		// Int32 get_actualWidth()
		int32_t HG::Rendering::Runtime::HGCamera::get_actualWidth(HGCamera *this, MethodInfo *method)
		{
		  return this->fields._actualWidth_k__BackingField;
		}
		

		// Void set_actualWidth(Int32)
		void HG::Rendering::Runtime::HGCamera::set_actualWidth(HGCamera *this, int32_t value, MethodInfo *method)
		{
		  this->fields._actualWidth_k__BackingField = value;
		}
		
		public int actualHeight { get; private set; } // 0x0000000184DA15F0-0x0000000184DA1600 0x0000000184DA16C0-0x0000000184DA16D0
		// FontStyles get_fontStyle()
		FontStyles__Enum TMPro::TMP_Text::get_fontStyle(TMP_Text *this, MethodInfo *method)
		{
		  return this->fields.m_FontWeightStack.m_Capacity;
		}
		

		// Void set_actualHeight(Int32)
		void HG::Rendering::Runtime::HGCamera::set_actualHeight(HGCamera *this, int32_t value, MethodInfo *method)
		{
		  this->fields._actualHeight_k__BackingField = value;
		}
		
		public MSAASamples msaaSamples { get; private set; } // 0x0000000184DA1650-0x0000000184DA1660 0x0000000184DA1720-0x0000000184DA1730
		// VerticalAlignmentOptions get_verticalAlignment()
		VerticalAlignmentOptions__Enum TMPro::TMP_Text::get_verticalAlignment(TMP_Text *this, MethodInfo *method)
		{
		  return LODWORD(this->fields.m_minFontSize);
		}
		

		// Void set_msaaSamples(MSAASamples)
		void HG::Rendering::Runtime::HGCamera::set_msaaSamples(HGCamera *this, MSAASamples__Enum value, MethodInfo *method)
		{
		  this->fields._msaaSamples_k__BackingField = value;
		}
		
		public bool msaaEnabled { get => default; } // 0x0000000189B74948-0x0000000189B7499C 
		// Boolean get_msaaEnabled()
		bool HG::Rendering::Runtime::HGCamera::get_msaaEnabled(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1195, 0LL) )
		    return this->fields._msaaSamples_k__BackingField != 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1195, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public FrameSettings frameSettings { get; private set; } // 0x0000000184DA1610-0x0000000184DA1630 0x0000000184DA16E0-0x0000000184DA1700
		// FrameSettings get_frameSettings()
		FrameSettings *HG::Rendering::Runtime::HGCamera::get_frameSettings(
		        FrameSettings *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  FrameSettings *result; // rax
		  __int64 v4; // xmm1_8
		
		  result = retstr;
		  v4 = *(_QWORD *)&this->fields._frameSettings_k__BackingField.materialQuality;
		  retstr->bitDatas = this->fields._frameSettings_k__BackingField.bitDatas;
		  *(_QWORD *)&retstr->materialQuality = v4;
		  return result;
		}
		

		// Void set_frameSettings(FrameSettings)
		void HG::Rendering::Runtime::HGCamera::set_frameSettings(HGCamera *this, FrameSettings *value, MethodInfo *method)
		{
		  __int64 v3; // xmm1_8
		
		  v3 = *(_QWORD *)&value->materialQuality;
		  this->fields._frameSettings_k__BackingField.bitDatas = value->bitDatas;
		  *(_QWORD *)&this->fields._frameSettings_k__BackingField.materialQuality = v3;
		}
		
		public VolumeStack volumeStack { get; private set; } // 0x0000000184DA16A0-0x0000000184DA16B0 0x0000000189B74B60-0x0000000189B74B74
		// SettingParameter`1[System.Single] get_afmeCameraRotationCosFallbackThreshold()
		SettingParameter_1_System_Single_ *HG::Rendering::Runtime::HGSettingParameters::get_afmeCameraRotationCosFallbackThreshold(
		        HGSettingParameters *this,
		        MethodInfo *method)
		{
		  return this->fields._afmeCameraRotationCosFallbackThreshold_k__BackingField;
		}
		

		// Void set_volumeStack(VolumeStack)
		void HG::Rendering::Runtime::HGCamera::set_volumeStack(HGCamera *this, VolumeStack *value, MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields._volumeStack_k__BackingField = value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields._volumeStack_k__BackingField,
		    (Type *)value,
		    (PropertyInfo_1 *)method,
		    v3,
		    v4);
		}
		
		public static ExtractionDoneCallback extractionDoneCallback { get; private set; } // 0x0000000189B74790-0x0000000189B747C4 0x0000000189B74B00-0x0000000189B74B4C
		// ExtractionDoneCallback get_extractionDoneCallback()
		ExtractionDoneCallback *HG::Rendering::Runtime::HGCamera::get_extractionDoneCallback(MethodInfo *method)
		{
		  struct HGCamera__Class *v1; // rax
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  }
		  return v1->static_fields->_extractionDoneCallback_k__BackingField;
		}
		

		// Void set_extractionDoneCallback(ExtractionDoneCallback)
		void HG::Rendering::Runtime::HGCamera::set_extractionDoneCallback(ExtractionDoneCallback *value, MethodInfo *method)
		{
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  struct HGCamera__Class *v4; // rax
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		
		  v4 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v4 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  }
		  v4->static_fields->_extractionDoneCallback_k__BackingField = value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields,
		    (Type *)method,
		    v2,
		    v3,
		    v6);
		}
		
		internal HGRenderPathBase renderPathInstance { get; private set; } // 0x0000000184DA1690-0x0000000184DA16A0 0x0000000189B74B4C-0x0000000189B74B60
		// HGRenderPathBase get_renderPathInstance()
		HGRenderPathBase *HG::Rendering::Runtime::HGCamera::get_renderPathInstance(HGCamera *this, MethodInfo *method)
		{
		  return this->fields._renderPathInstance_k__BackingField;
		}
		

		// Void set_renderPathInstance(HGRenderPathBase)
		void HG::Rendering::Runtime::HGCamera::set_renderPathInstance(
		        HGCamera *this,
		        HGRenderPathBase *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields._renderPathInstance_k__BackingField = value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields._renderPathInstance_k__BackingField,
		    (Type *)value,
		    (PropertyInfo_1 *)method,
		    v3,
		    v4);
		}
		
		internal HGRenderPipelineMaterialCollector MaterialCollector { get => default; } // 0x0000000189B74388-0x0000000189B743E4 
		// HGRenderPipelineMaterialCollector get_MaterialCollector()
		HGRenderPipelineMaterialCollector *HG::Rendering::Runtime::HGCamera::get_MaterialCollector(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderPathBase *renderPathInstance_k__BackingField; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2804, 0LL) )
		  {
		    renderPathInstance_k__BackingField = this->fields._renderPathInstance_k__BackingField;
		    if ( renderPathInstance_k__BackingField )
		      return *(HGRenderPipelineMaterialCollector **)&renderPathInstance_k__BackingField[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2804, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1027(Patch, (Object *)this, 0LL);
		}
		
		internal bool ssrEnable { get => default; } // 0x00000001831CB6D0-0x00000001831CBA40 
		// Boolean get_ssrEnable()
		bool HG::Rendering::Runtime::HGCamera::get_ssrEnable(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  HGCamera__Class *static_fields; // rdx
		  __int64 v5; // rdi
		  struct Object_1__Class *v6; // rcx
		  Object *v7; // rbx
		  Object__Class *klass; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  const Il2CppCodeGenModule *codeGenModule; // rdx
		  char HasInstantiation; // al
		  HGRenderPipeline *currentPipeline; // rax
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *ssrEnable_k__BackingField; // rbx
		  struct MethodInfo *v16; // rdi
		  Il2CppClass *v17; // rax
		  Il2CppClass *v18; // rcx
		  const char *name; // rax
		  char v20; // al
		  const char *v21; // rax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  const Il2CppImage *v25; // r8
		  ILFixDynamicMethodWrapper_2 *v26; // rax
		  HGCamera__Class *v27; // rax
		  ILFixDynamicMethodWrapper_2 *v28; // rax
		  __int64 v29; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_59;
		  if ( (int)static_fields->_0.image->typeCount > 949 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    image = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_59;
		    if ( image->typeCount <= 0x3B5 )
		      goto LABEL_90;
		    if ( *(_QWORD *)&image[105].token )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(949, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)v3, 0LL);
		LABEL_59:
		      sub_1800D8260(this, static_fields);
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_59;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_9;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_59;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x30F )
		    goto LABEL_90;
		  if ( *(_QWORD *)&static_fields[16]._1.token )
		  {
		    v24 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v24 )
		      goto LABEL_59;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v24, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_59;
		  v5 = *(_QWORD *)&this->fields.mainViewConstants.viewMatrix.m20;
		  v6 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  if ( !v5 )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !*(_QWORD *)(v5 + 16) )
		    return 0;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_59;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_20;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  v25 = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_59;
		  if ( v25->typeCount <= 0x30F )
		    goto LABEL_90;
		  if ( *(_QWORD *)&v25[87].customAttributeCount )
		  {
		    v26 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v26 )
		      goto LABEL_59;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v26, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_20:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_59;
		  v7 = *(Object **)&this->fields.mainViewConstants.viewMatrix.m20;
		  if ( !v7 )
		    goto LABEL_59;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_59;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 950 )
		  {
		LABEL_27:
		    klass = v7[3].klass;
		    if ( !klass )
		      goto LABEL_59;
		    sub_1800049A0(klass->_0.image);
		    nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))klass->_0.image[6].nameToClassHashTable;
		    codeGenModule = klass->_0.image[6].codeGenModule;
		    if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		    {
		      name = klass->_0.name;
		      if ( (*((_DWORD *)name + 2) & 0x20000000) != 0
		        || (v20 = name[10], v20 == 29)
		        || v20 == 16
		        || v20 == 20
		        || v20 == 15 )
		      {
		LABEL_58:
		        HasInstantiation = 1;
		        goto LABEL_32;
		      }
		    }
		    else
		    {
		      if ( nameToClassHashTable == System::RuntimeType::get_IsGenericType )
		      {
		        HasInstantiation = System::RuntimeTypeHandle::HasInstantiation(klass, codeGenModule);
		        goto LABEL_32;
		      }
		      if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		      {
		        HasInstantiation = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		                             klass,
		                             codeGenModule);
		        goto LABEL_32;
		      }
		      v21 = klass->_0.name;
		      if ( (*((_DWORD *)v21 + 2) & 0x20000000) == 0 && (v21[10] == 19 || v21[10] == 30) )
		        goto LABEL_58;
		    }
		    HasInstantiation = 0;
		    goto LABEL_32;
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  v27 = this->klass;
		  if ( !this->klass )
		    goto LABEL_59;
		  if ( LODWORD(v27->_0.namespaze) <= 0x3B6 )
		LABEL_90:
		    sub_1800D2AB0(this, static_fields);
		  if ( !v27[20]._0.interopData )
		    goto LABEL_27;
		  v28 = IFix::WrappersManagerImpl::GetPatch(950, 0LL);
		  if ( !v28 )
		    goto LABEL_59;
		  HasInstantiation = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v28, v7, 0LL);
		LABEL_32:
		  if ( !HasInstantiation )
		    return 0;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !currentPipeline )
		    goto LABEL_59;
		  settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_59;
		  ssrEnable_k__BackingField = settingParameters_k__BackingField->fields._ssrEnable_k__BackingField;
		  v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !ssrEnable_k__BackingField )
		    goto LABEL_59;
		  v17 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v17->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v17->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v29 = sub_18011C4C0(v16->klass);
		    (**(void (***)(void))(*(_QWORD *)(v29 + 192) + 48LL))();
		  }
		  v18 = v16->klass;
		  if ( ((__int64)v18->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v18, static_fields);
		  return ssrEnable_k__BackingField->fields._paramValue_k__BackingField
		      && UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
		}
		
		internal bool aoEnable { get => default; } // 0x0000000183C2F060-0x0000000183C2F320 
		// Boolean get_aoEnable()
		bool HG::Rendering::Runtime::HGCamera::get_aoEnable(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  HGCamera__Class *static_fields; // rdx
		  __int64 v5; // rdi
		  struct Object_1__Class *v6; // rcx
		  Object *v7; // rbx
		  Object__Class *klass; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  const Il2CppCodeGenModule *codeGenModule; // rdx
		  char v11; // al
		  const char *name; // rax
		  char v14; // al
		  const char *v15; // rax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  const Il2CppImage *v19; // r8
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  HGCamera__Class *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_45;
		  if ( (int)static_fields->_0.image->typeCount <= 1092 )
		    goto LABEL_79;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  image = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_45;
		  if ( image->typeCount <= 0x444 )
		    goto LABEL_76;
		  if ( !image[121].codeGenModule )
		  {
		LABEL_79:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_45;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		      goto LABEL_9;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_45;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x30F )
		      goto LABEL_76;
		    if ( *(_QWORD *)&static_fields[16]._1.token )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		      if ( !Patch )
		        goto LABEL_45;
		      this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(Patch, (Object *)v3, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_9:
		      this = (HGCamera *)v3->fields.m_volumeComponentsData;
		    }
		    if ( !this )
		      goto LABEL_45;
		    v5 = *(_QWORD *)&this->fields.mainViewConstants.viewMatrix.m22;
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = TypeInfo::UnityEngine::Object;
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		    }
		    if ( !v5 )
		      return 0;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !*(_QWORD *)(v5 + 16) )
		      return 0;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_45;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		      goto LABEL_20;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    v19 = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_45;
		    if ( v19->typeCount <= 0x30F )
		      goto LABEL_76;
		    if ( *(_QWORD *)&v19[87].customAttributeCount )
		    {
		      v20 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		      if ( !v20 )
		        goto LABEL_45;
		      this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v20, (Object *)v3, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_20:
		      this = (HGCamera *)v3->fields.m_volumeComponentsData;
		    }
		    if ( !this )
		      goto LABEL_45;
		    v7 = *(Object **)&this->fields.mainViewConstants.viewMatrix.m22;
		    if ( !v7 )
		      goto LABEL_45;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_45;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 1093 )
		    {
		LABEL_27:
		      klass = v7[3].klass;
		      if ( klass )
		      {
		        sub_1800049A0(klass->_0.image);
		        nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))klass->_0.image[6].nameToClassHashTable;
		        codeGenModule = klass->_0.image[6].codeGenModule;
		        if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		        {
		          name = klass->_0.name;
		          if ( (*((_DWORD *)name + 2) & 0x20000000) != 0 )
		            return 1;
		          v14 = name[10];
		          if ( v14 == 29 || v14 == 16 || v14 == 20 || v14 == 15 )
		            return 1;
		        }
		        else
		        {
		          if ( nameToClassHashTable == System::RuntimeType::get_IsGenericType )
		            return (unsigned __int8)System::RuntimeTypeHandle::HasInstantiation(klass, codeGenModule) != 0;
		          if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		          {
		            v11 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		                    klass,
		                    codeGenModule);
		            return v11 != 0;
		          }
		          v15 = klass->_0.name;
		          if ( (*((_DWORD *)v15 + 2) & 0x20000000) == 0 && (v15[10] == 19 || v15[10] == 30) )
		            return 1;
		        }
		        return 0;
		      }
		LABEL_45:
		      sub_1800D8260(this, static_fields);
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    v21 = this->klass;
		    if ( !this->klass )
		      goto LABEL_45;
		    if ( LODWORD(v21->_0.namespaze) > 0x445 )
		    {
		      if ( v21[23]._0.fields )
		      {
		        v22 = IFix::WrappersManagerImpl::GetPatch(1093, 0LL);
		        if ( v22 )
		        {
		          v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v22, v7, 0LL);
		          return v11 != 0;
		        }
		        goto LABEL_45;
		      }
		      goto LABEL_27;
		    }
		LABEL_76:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v17 = IFix::WrappersManagerImpl::GetPatch(1092, 0LL);
		  if ( !v17 )
		    goto LABEL_45;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v17, (Object *)v3, 0LL);
		}
		
		internal bool fakePlanarReflectionEnable { get => default; } // 0x0000000183973EE0-0x00000001839741A0 
		// Boolean get_fakePlanarReflectionEnable()
		bool HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rdi
		  HGCamera__Class *static_fields; // rdx
		  __int64 v5; // rbx
		  struct Object_1__Class *v6; // rcx
		  Object *v7; // rbx
		  Object__Class *v8; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  const Il2CppCodeGenModule *codeGenModule; // rdx
		  char v11; // al
		  const char *name; // rax
		  char v14; // al
		  const char *v15; // rcx
		  __int64 v16; // rax
		  const char *v17; // rax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  const Il2CppImage *v21; // r8
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  OtherSettings *m_otherSettings; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_48;
		  if ( (int)static_fields->_0.image->typeCount > 1096 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    image = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_48;
		    if ( image->typeCount <= 0x448 )
		      goto LABEL_80;
		    if ( image[122].assembly )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1096, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)v3, 0LL);
		LABEL_48:
		      sub_1800D8260(this, static_fields);
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_48;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_9;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_48;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x30F )
		    goto LABEL_80;
		  if ( *(_QWORD *)&static_fields[16]._1.token )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v20 )
		      goto LABEL_48;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v20, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_48;
		  v5 = *(_QWORD *)&this->fields.mainViewConstants.viewMatrix.m03;
		  v6 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  if ( !v5 )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !*(_QWORD *)(v5 + 16) )
		    return 0;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_48;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_20;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  v21 = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_48;
		  if ( v21->typeCount <= 0x30F )
		    goto LABEL_80;
		  if ( *(_QWORD *)&v21[87].customAttributeCount )
		  {
		    v22 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v22 )
		      goto LABEL_48;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v22, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_20:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_48;
		  v7 = *(Object **)&this->fields.mainViewConstants.viewMatrix.m03;
		  if ( !v7 )
		    goto LABEL_48;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_48;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 1097 )
		    goto LABEL_27;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  klass = this->klass;
		  if ( !this->klass )
		    goto LABEL_48;
		  if ( LODWORD(klass->_0.namespaze) <= 0x449 )
		LABEL_80:
		    sub_1800D2AB0(this, static_fields);
		  if ( klass[23]._0.nestedTypes )
		  {
		    v24 = IFix::WrappersManagerImpl::GetPatch(1097, 0LL);
		    if ( !v24 )
		      goto LABEL_48;
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v24, v7, 0LL);
		    goto LABEL_32;
		  }
		LABEL_27:
		  v8 = v7[3].klass;
		  if ( !v8 )
		    goto LABEL_48;
		  sub_1800049A0(v8->_0.image);
		  nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))v8->_0.image[6].nameToClassHashTable;
		  codeGenModule = v8->_0.image[6].codeGenModule;
		  if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		  {
		    name = v8->_0.name;
		    if ( (*((_DWORD *)name + 2) & 0x20000000) != 0 || (v14 = name[10], v14 == 29) || v14 == 16 || v14 == 20 || v14 == 15 )
		    {
		LABEL_47:
		      v11 = 1;
		      goto LABEL_32;
		    }
		LABEL_39:
		    v11 = 0;
		    goto LABEL_32;
		  }
		  if ( nameToClassHashTable != System::RuntimeType::get_IsGenericType )
		  {
		    if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		    {
		      v11 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		              v8,
		              codeGenModule);
		      goto LABEL_32;
		    }
		    v17 = v8->_0.name;
		    if ( (*((_DWORD *)v17 + 2) & 0x20000000) == 0 && (v17[10] == 19 || v17[10] == 30) )
		      goto LABEL_47;
		    goto LABEL_39;
		  }
		  v15 = v8->_0.name;
		  if ( (*((_DWORD *)v15 + 2) & 0x20000000) == 0 )
		  {
		    LOBYTE(codeGenModule) = 1;
		    v16 = sub_180028750(v15, codeGenModule);
		    if ( (*(_BYTE *)(v16 + 312) & 0x10) == 0 && !*(_QWORD *)(v16 + 96) )
		    {
		      v11 = 0;
		      goto LABEL_32;
		    }
		    goto LABEL_47;
		  }
		  v11 = 0;
		LABEL_32:
		  if ( !v11 )
		    return 0;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(v3, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_48;
		  m_otherSettings = volumeComponentsData->fields.m_otherSettings;
		  if ( !m_otherSettings )
		    goto LABEL_48;
		  static_fields = (HGCamera__Class *)m_otherSettings->fields.fakePlanarReflection;
		  if ( !static_fields )
		    goto LABEL_48;
		  return (unsigned __int8)sub_180006280(10LL, static_fields) != 0;
		}
		
		internal bool fakePlanarRelectionDisableCharacterOutline { get => default; } // 0x0000000183973C50-0x0000000183973EE0 
		// Boolean get_fakePlanarRelectionDisableCharacterOutline()
		bool HG::Rendering::Runtime::HGCamera::get_fakePlanarRelectionDisableCharacterOutline(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rdi
		  HGCamera__Class *static_fields; // rdx
		  __int64 v5; // rbx
		  struct Object_1__Class *v6; // rcx
		  Object *v7; // rbx
		  Object__Class *klass; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  const Il2CppCodeGenModule *codeGenModule; // rdx
		  char HasInstantiation; // al
		  const char *name; // rax
		  char v14; // al
		  const char *v15; // rax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  const Il2CppImage *v19; // r8
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  HGCamera__Class *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  OtherSettings *m_otherSettings; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_45;
		  if ( (int)static_fields->_0.image->typeCount > 1099 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    image = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_45;
		    if ( image->typeCount <= 0x44B )
		      goto LABEL_76;
		    if ( image[122].metadataHandle )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1099, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)v3, 0LL);
		LABEL_45:
		      sub_1800D8260(this, static_fields);
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_45;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_9;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_45;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x30F )
		    goto LABEL_76;
		  if ( *(_QWORD *)&static_fields[16]._1.token )
		  {
		    v18 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v18 )
		      goto LABEL_45;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v18, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_45;
		  v5 = *(_QWORD *)&this->fields.mainViewConstants.viewMatrix.m03;
		  v6 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  if ( !v5 )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !*(_QWORD *)(v5 + 16) )
		    return 0;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_45;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 783 )
		    goto LABEL_20;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  v19 = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_45;
		  if ( v19->typeCount <= 0x30F )
		    goto LABEL_76;
		  if ( *(_QWORD *)&v19[87].customAttributeCount )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v20 )
		      goto LABEL_45;
		    this = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v20, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_20:
		    this = (HGCamera *)v3->fields.m_volumeComponentsData;
		  }
		  if ( !this )
		    goto LABEL_45;
		  v7 = *(Object **)&this->fields.mainViewConstants.viewMatrix.m03;
		  if ( !v7 )
		    goto LABEL_45;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_45;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 1097 )
		  {
		LABEL_27:
		    klass = v7[3].klass;
		    if ( !klass )
		      goto LABEL_45;
		    sub_1800049A0(klass->_0.image);
		    nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))klass->_0.image[6].nameToClassHashTable;
		    codeGenModule = klass->_0.image[6].codeGenModule;
		    if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		    {
		      name = klass->_0.name;
		      if ( (*((_DWORD *)name + 2) & 0x20000000) != 0
		        || (v14 = name[10], v14 == 29)
		        || v14 == 16
		        || v14 == 20
		        || v14 == 15 )
		      {
		LABEL_44:
		        HasInstantiation = 1;
		        goto LABEL_32;
		      }
		    }
		    else
		    {
		      if ( nameToClassHashTable == System::RuntimeType::get_IsGenericType )
		      {
		        HasInstantiation = System::RuntimeTypeHandle::HasInstantiation(klass, codeGenModule);
		        goto LABEL_32;
		      }
		      if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		      {
		        HasInstantiation = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		                             klass,
		                             codeGenModule);
		        goto LABEL_32;
		      }
		      v15 = klass->_0.name;
		      if ( (*((_DWORD *)v15 + 2) & 0x20000000) == 0 && (v15[10] == 19 || v15[10] == 30) )
		        goto LABEL_44;
		    }
		    HasInstantiation = 0;
		    goto LABEL_32;
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  v21 = this->klass;
		  if ( !this->klass )
		    goto LABEL_45;
		  if ( LODWORD(v21->_0.namespaze) <= 0x449 )
		LABEL_76:
		    sub_1800D2AB0(this, static_fields);
		  if ( !v21[23]._0.nestedTypes )
		    goto LABEL_27;
		  v22 = IFix::WrappersManagerImpl::GetPatch(1097, 0LL);
		  if ( !v22 )
		    goto LABEL_45;
		  HasInstantiation = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v22, v7, 0LL);
		LABEL_32:
		  if ( !HasInstantiation )
		    return 0;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(v3, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_45;
		  m_otherSettings = volumeComponentsData->fields.m_otherSettings;
		  if ( !m_otherSettings )
		    goto LABEL_45;
		  static_fields = (HGCamera__Class *)m_otherSettings->fields.fakePlanarDisableCharacterOutline;
		  if ( !static_fields )
		    goto LABEL_45;
		  return (unsigned __int8)sub_180006280(10LL, static_fields) != 0;
		}
		
		internal Vector3 fakeReflectionProbeNormal { get => default; } // 0x0000000183973AE0-0x0000000183973B60 
		// Vector3 get_fakeReflectionProbeNormal()
		Vector3 *HG::Rendering::Runtime::HGCamera::get_fakeReflectionProbeNormal(
		        Vector3 *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v9; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  OtherSettings *m_otherSettings; // rax
		  Vector3Parameter *fakeReflectionProbeNormal; // r8
		  __int64 v13; // xmm0_8
		  float z; // eax
		  Vector3 v15[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 1101 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_8;
		    if ( LODWORD(v5->_0.namespaze) <= 0x44D )
		      sub_1800D2AB0(v5, this);
		    if ( v5[23].rgctx_data )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1101, 0LL);
		      if ( Patch )
		      {
		        v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v15, Patch, (Object *)this, 0LL);
		LABEL_21:
		        v13 = *(_QWORD *)&v9->x;
		        z = v9->z;
		        *(_QWORD *)&retstr->x = v13;
		        retstr->z = z;
		        return retstr;
		      }
		LABEL_8:
		      sub_1800D8260(v5, this);
		    }
		  }
		  if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
		  {
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(this, 0LL);
		    if ( volumeComponentsData )
		    {
		      m_otherSettings = volumeComponentsData->fields.m_otherSettings;
		      if ( m_otherSettings )
		      {
		        fakeReflectionProbeNormal = m_otherSettings->fields.fakeReflectionProbeNormal;
		        if ( fakeReflectionProbeNormal )
		        {
		          v9 = (Vector3 *)sub_180049560(v15, 10LL, fakeReflectionProbeNormal);
		          goto LABEL_21;
		        }
		      }
		    }
		    goto LABEL_8;
		  }
		  *(_QWORD *)&retstr->y = 1065353216LL;
		  retstr->x = 0.0;
		  return retstr;
		}
		
		internal Vector3 fakeReflectionPlanePos { get => default; } // 0x0000000183973B60-0x0000000183973BE0 
		// Vector3 get_fakeReflectionPlanePos()
		Vector3 *HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(
		        Vector3 *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v10; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  OtherSettings *m_otherSettings; // rax
		  Vector3Parameter *fakeReflectionPos; // r8
		  __int64 v14; // xmm0_8
		  Vector3 v15[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 1102 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_8;
		    if ( LODWORD(v5->_0.namespaze) <= 0x44E )
		      sub_1800D2AB0(v5, this);
		    if ( v5[23]._1.typeHierarchy )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1102, 0LL);
		      if ( Patch )
		      {
		        v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v15, Patch, (Object *)this, 0LL);
		LABEL_21:
		        v14 = *(_QWORD *)&v10->x;
		        z = v10->z;
		        *(_QWORD *)&retstr->x = v14;
		        goto LABEL_7;
		      }
		LABEL_8:
		      sub_1800D8260(v5, this);
		    }
		  }
		  if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
		  {
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(this, 0LL);
		    if ( volumeComponentsData )
		    {
		      m_otherSettings = volumeComponentsData->fields.m_otherSettings;
		      if ( m_otherSettings )
		      {
		        fakeReflectionPos = m_otherSettings->fields.fakeReflectionPos;
		        if ( fakeReflectionPos )
		        {
		          v10 = (Vector3 *)sub_180049560(v15, 10LL, fakeReflectionPos);
		          goto LABEL_21;
		        }
		      }
		    }
		    goto LABEL_8;
		  }
		  z = 0.0;
		  *(_QWORD *)&retstr->x = 0LL;
		LABEL_7:
		  retstr->z = z;
		  return retstr;
		}
		
		internal float fakePlanarReflectionBlur { get => default; } // 0x0000000183973BE0-0x0000000183973C50 
		// Single get_fakePlanarReflectionBlur()
		float HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  OtherSettings *m_otherSettings; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1100 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_7;
		    if ( LODWORD(v3->_0.namespaze) <= 0x44C )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( v3[23].static_fields )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1100, 0LL);
		      if ( Patch )
		      {
		        *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                          (ILFixDynamicMethodWrapper_15 *)Patch,
		                          (Object *)this,
		                          0LL);
		        return *(float *)&v5;
		      }
		LABEL_7:
		      sub_1800D8260(v3, wrapperArray);
		    }
		  }
		  if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
		  {
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(this, 0LL);
		    if ( volumeComponentsData )
		    {
		      m_otherSettings = volumeComponentsData->fields.m_otherSettings;
		      if ( m_otherSettings )
		      {
		        wrapperArray = (ILFixDynamicMethodWrapper_2__Array *)m_otherSettings->fields.fakePlanarReflectionBlur;
		        if ( wrapperArray )
		        {
		          v5 = sub_1800057D0(10LL, wrapperArray);
		          return *(float *)&v5;
		        }
		      }
		    }
		    goto LABEL_7;
		  }
		  LODWORD(v5) = 0;
		  return *(float *)&v5;
		}
		
		internal bool enableDepthOfField { get => default; } // 0x0000000189B745A8-0x0000000189B74654 
		// Boolean get_enableDepthOfField()
		bool HG::Rendering::Runtime::HGCamera::get_enableDepthOfField(HGCamera *this, MethodInfo *method)
		{
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v4; // rdx
		  Camera *camera; // rcx
		  HGDepthOfField *m_depthOfField; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2806, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2806, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(this, 0LL);
		    if ( !volumeComponentsData )
		      goto LABEL_10;
		    m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)m_depthOfField, 0LL, 0LL) )
		    {
		      if ( !m_depthOfField )
		        goto LABEL_10;
		      if ( HG::Rendering::Runtime::HGDepthOfField::IsActive(m_depthOfField, 0LL) )
		      {
		        camera = this->fields.camera;
		        if ( camera )
		          return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_Game;
		LABEL_10:
		        sub_1800D8260(camera, v4);
		      }
		    }
		    return 0;
		  }
		}
		
		internal bool enableMotionBlur { get => default; } // 0x0000000183C233F0-0x0000000183C23680 
		// Boolean get_enableMotionBlur()
		bool HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  _DWORD *wrapperArray; // rdx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  HGMotionBlur *m_motionBlur; // rdi
		  struct Object_1__Class *v7; // rax
		  HGCamera_VolumeComponentsData *v8; // rax
		  Object *v9; // rdi
		  Object__Class *klass; // rbx
		  bool (*nameToClassHashTable)(RuntimeType *, MethodInfo *); // r8
		  const Il2CppCodeGenModule *codeGenModule; // rdx
		  char HasInstantiation; // al
		  const char *name; // rax
		  char v16; // al
		  const char *v17; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v19; // rax
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  double v22; // xmm0_8
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( (int)wrapperArray[6] > 1113 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_45;
		    if ( wrapperArray[6] <= 0x459u )
		      goto LABEL_76;
		    if ( *((_QWORD *)wrapperArray + 1117) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1113, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		      goto LABEL_45;
		    }
		  }
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( (int)wrapperArray[6] <= 783 )
		    goto LABEL_9;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( wrapperArray[6] <= 0x30Fu )
		    goto LABEL_76;
		  if ( *((_QWORD *)wrapperArray + 787) )
		  {
		    v19 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v19 )
		      goto LABEL_45;
		    m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v19, (Object *)this, 0LL);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    m_volumeComponentsData = this->fields.m_volumeComponentsData;
		  }
		  if ( !m_volumeComponentsData )
		    goto LABEL_45;
		  m_motionBlur = m_volumeComponentsData->fields.m_motionBlur;
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v7 = TypeInfo::UnityEngine::Object;
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  if ( !m_motionBlur )
		    return 0;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !m_motionBlur->fields._._._.m_CachedPtr )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( (int)wrapperArray[6] <= 783 )
		    goto LABEL_20;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( wrapperArray[6] <= 0x30Fu )
		    goto LABEL_76;
		  if ( *((_QWORD *)wrapperArray + 787) )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v20 )
		      goto LABEL_45;
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v20, (Object *)this, 0LL);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_20:
		    v8 = this->fields.m_volumeComponentsData;
		  }
		  if ( !v8 )
		    goto LABEL_45;
		  v9 = (Object *)v8->fields.m_motionBlur;
		  if ( !v9 )
		    goto LABEL_45;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  if ( (int)wrapperArray[6] > 1114 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_45;
		    if ( LODWORD(v3->_0.namespaze) > 0x45A )
		    {
		      if ( !*(_QWORD *)&v3[23]._1.interfaces_count )
		        goto LABEL_27;
		      v21 = IFix::WrappersManagerImpl::GetPatch(1114, 0LL);
		      if ( v21 )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v21, v9, 0LL);
		LABEL_45:
		      sub_1800D8260(v3, wrapperArray);
		    }
		LABEL_76:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		LABEL_27:
		  klass = v9[3].klass;
		  if ( !klass )
		    goto LABEL_45;
		  sub_1800049A0(klass->_0.image);
		  nameToClassHashTable = (bool (*)(RuntimeType *, MethodInfo *))klass->_0.image[6].nameToClassHashTable;
		  codeGenModule = klass->_0.image[6].codeGenModule;
		  if ( nameToClassHashTable == System::RuntimeType::HasElementTypeImpl )
		  {
		    name = klass->_0.name;
		    if ( (*((_DWORD *)name + 2) & 0x20000000) != 0 )
		      goto LABEL_44;
		    v16 = name[10];
		    if ( v16 == 29 || v16 == 16 || v16 == 20 || v16 == 15 )
		      goto LABEL_44;
		LABEL_39:
		    HasInstantiation = 0;
		    goto LABEL_32;
		  }
		  if ( nameToClassHashTable == System::RuntimeType::get_IsGenericType )
		  {
		    HasInstantiation = System::RuntimeTypeHandle::HasInstantiation(klass, codeGenModule);
		    goto LABEL_32;
		  }
		  if ( nameToClassHashTable != System::RuntimeType::get_IsGenericParameter )
		  {
		    HasInstantiation = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		                         klass,
		                         codeGenModule);
		    goto LABEL_32;
		  }
		  v17 = klass->_0.name;
		  if ( (*((_DWORD *)v17 + 2) & 0x20000000) != 0 || v17[10] != 19 && v17[10] != 30 )
		    goto LABEL_39;
		LABEL_44:
		  HasInstantiation = 1;
		LABEL_32:
		  if ( !HasInstantiation )
		    return 0;
		  wrapperArray = v9[3].monitor;
		  if ( !wrapperArray )
		    goto LABEL_45;
		  v22 = sub_1800057D0(10LL, wrapperArray);
		  return *(float *)&v22 > 0.0;
		}
		
		internal bool enableTransparentAfterDOF { get => default; } // 0x0000000189B7470C-0x0000000189B74790 
		// Boolean get_enableTransparentAfterDOF()
		bool HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(HGCamera *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Camera *camera; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2807, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2807, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !HG::Rendering::Runtime::HGCamera::get_enableDepthOfField(this, 0LL)
		      && !HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(this, 0LL) )
		    {
		      camera = this->fields.camera;
		      if ( camera )
		        return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_SceneView;
		LABEL_8:
		      sub_1800D8260(camera, v3);
		    }
		    return 1;
		  }
		}
		
		internal float rayTracingReflectionVolumeBlend { get => default; } // 0x0000000183E9D1B0-0x0000000183E9D2E0 
		// Single get_rayTracingReflectionVolumeBlend()
		float HG::Rendering::Runtime::HGCamera::get_rayTracingReflectionVolumeBlend(HGCamera *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  FloatParameter *enable; // rdx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  RayTracingReflectionVolume *m_rayTracingReflectionVolume; // rbx
		  double v7; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v9; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  enable = (FloatParameter *)*v3[23];
		  if ( !enable )
		    goto LABEL_19;
		  if ( SLODWORD(enable->fields._.m_Value) > 1156 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    enable = (FloatParameter *)*v3[23];
		    if ( !enable )
		      goto LABEL_19;
		    if ( LODWORD(enable->fields._.m_Value) <= 0x484 )
		      goto LABEL_36;
		    if ( enable[290].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1156, 0LL);
		      if ( Patch )
		      {
		        *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                          (ILFixDynamicMethodWrapper_15 *)Patch,
		                          (Object *)this,
		                          0LL);
		        return *(float *)&v7;
		      }
		      goto LABEL_19;
		    }
		  }
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  enable = (FloatParameter *)*v3[23];
		  if ( !enable )
		    goto LABEL_19;
		  if ( SLODWORD(enable->fields._.m_Value) <= 783 )
		    goto LABEL_9;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_19;
		  if ( *((_DWORD *)v3 + 6) <= 0x30Fu )
		LABEL_36:
		    sub_1800D2AB0(v3, enable);
		  if ( !v3[787] )
		  {
		LABEL_9:
		    m_volumeComponentsData = this->fields.m_volumeComponentsData;
		    goto LABEL_10;
		  }
		  v9 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		  if ( !v9 )
		    goto LABEL_19;
		  m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v9, (Object *)this, 0LL);
		LABEL_10:
		  if ( !m_volumeComponentsData )
		    goto LABEL_19;
		  v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  m_rayTracingReflectionVolume = m_volumeComponentsData->fields.m_rayTracingReflectionVolume;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_rayTracingReflectionVolume )
		    goto LABEL_18;
		  if ( !*((_DWORD *)v3 + 56) )
		    il2cpp_runtime_class_init_1(v3);
		  if ( !m_rayTracingReflectionVolume->fields._._._.m_CachedPtr )
		  {
		LABEL_18:
		    LODWORD(v7) = 0;
		    return *(float *)&v7;
		  }
		  enable = m_rayTracingReflectionVolume->fields.enable;
		  if ( !enable )
		LABEL_19:
		    sub_1800D8260(v3, enable);
		  v7 = sub_1800057D0(10LL, enable);
		  return *(float *)&v7;
		}
		
		internal RayTracingReflectionMode rayTracingReflectionVolumeMode { get => default; } // 0x0000000183CCE7F0-0x0000000183CCE9F0 
		// RayTracingReflectionMode get_rayTracingReflectionVolumeMode()
		RayTracingReflectionMode__Enum HG::Rendering::Runtime::HGCamera::get_rayTracingReflectionVolumeMode(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  Object *v3; // rbx
		  int *static_fields; // rdx
		  HGCamera_VolumeComponentsData *monitor; // rax
		  RayTracingReflectionVolume *m_rayTracingReflectionVolume; // rbx
		  __int64 v8; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = (Object *)this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_19;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 1157 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v8 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_19;
		    if ( *(_DWORD *)(v8 + 24) <= 0x485u )
		      goto LABEL_36;
		    if ( *(_QWORD *)(v8 + 9288) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1157, 0LL);
		      if ( !Patch )
		        goto LABEL_19;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, v3, 0LL);
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = (int *)this->klass;
		  if ( !this->klass )
		    goto LABEL_19;
		  if ( static_fields[6] <= 783 )
		    goto LABEL_9;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  klass = this->klass;
		  if ( !this->klass )
		    goto LABEL_19;
		  if ( LODWORD(klass->_0.namespaze) <= 0x30F )
		LABEL_36:
		    sub_1800D2AB0(this, static_fields);
		  if ( *(_QWORD *)&klass[16]._1.token )
		  {
		    v11 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v11 )
		      goto LABEL_19;
		    monitor = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v11, v3, 0LL);
		    goto LABEL_10;
		  }
		LABEL_9:
		  monitor = (HGCamera_VolumeComponentsData *)v3[156].monitor;
		LABEL_10:
		  if ( !monitor )
		    goto LABEL_19;
		  this = (HGCamera *)TypeInfo::UnityEngine::Object;
		  m_rayTracingReflectionVolume = monitor->fields.m_rayTracingReflectionVolume;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    this = (HGCamera *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      this = (HGCamera *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_rayTracingReflectionVolume )
		  {
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		      il2cpp_runtime_class_init_1(this);
		    if ( m_rayTracingReflectionVolume->fields._._._.m_CachedPtr )
		    {
		      static_fields = (int *)m_rayTracingReflectionVolume->fields.mode;
		      if ( static_fields )
		        return (unsigned int)sub_180002F70(10LL, static_fields);
		LABEL_19:
		      sub_1800D8260(this, static_fields);
		    }
		  }
		  return 0;
		}
		
		internal Camera parentCamera { get => default; } // 0x0000000183EC9480-0x0000000183EC94E0 
		// Camera get_parentCamera()
		Camera *HG::Rendering::Runtime::HGCamera::get_parentCamera(HGCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 697 )
		    return this->fields.m_parentCamera;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2B9 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[14].vtable.GetHashCode.methodPtr )
		    return this->fields.m_parentCamera;
		  Patch = IFix::WrappersManagerImpl::GetPatch(697, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_276(Patch, (Object *)this, 0LL);
		}
		
		internal bool isLowResScaleHalf { get => default; } // 0x0000000189B7484C-0x0000000189B748B4 
		// Boolean get_isLowResScaleHalf()
		bool HG::Rendering::Runtime::HGCamera::get_isLowResScaleHalf(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2808, 0LL) )
		    return this->fields.lowResScale == 0.5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2808, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal ref HGUtils.PackedMipChainInfo depthBufferMipChainInfo { get => default; } // 0x0000000189B74508-0x0000000189B74558 
		// HGUtils+PackedMipChainInfo& get_depthBufferMipChainInfo()
		HGUtils_PackedMipChainInfo *HG::Rendering::Runtime::HGCamera::get_depthBufferMipChainInfo(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1173, 0LL) )
		    return &this->fields.m_DepthBufferMipChainInfo;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1173, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_445(Patch, (Object *)this, 0LL);
		}
		
		internal Vector2Int depthMipChainSize { get => default; } // 0x0000000189B74558-0x0000000189B745A8 
		// Vector2Int get_depthMipChainSize()
		Vector2Int HG::Rendering::Runtime::HGCamera::get_depthMipChainSize(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2810, 0LL) )
		    return this->fields.m_DepthBufferMipChainInfo.textureSize;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2810, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_283(Patch, (Object *)this, 0LL);
		}
		
		internal float globalMipBias { get; set; } // 0x0000000184DA1630-0x0000000184DA1640 0x0000000184DA1700-0x0000000184DA1710
		// Single get_globalMipBias()
		float HG::Rendering::Runtime::HGCamera::get_globalMipBias(HGCamera *this, MethodInfo *method)
		{
		  return this->fields._globalMipBias_k__BackingField;
		}
		

		// Void set_globalMipBias(Single)
		void HG::Rendering::Runtime::HGCamera::set_globalMipBias(HGCamera *this, float value, MethodInfo *method)
		{
		  this->fields._globalMipBias_k__BackingField = value;
		}
		
		internal Matrix4x4 nonObliqueProjMatrix { get => default; } // 0x0000000189B7499C-0x0000000189B74A74 
		// Matrix4x4 get_nonObliqueProjMatrix()
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::get_nonObliqueProjMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  Object_1 *m_AdditionalCameraData; // rbx
		  __int64 v6; // rcx
		  HGAdditionalCameraData *v7; // rdx
		  Matrix4x4 *NonObliqueProjection; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v14; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2811, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2811, 0LL);
		    if ( Patch )
		    {
		      NonObliqueProjection = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_193(&v14, Patch, (Object *)this, 0LL);
		      goto LABEL_9;
		    }
		    goto LABEL_7;
		  }
		  m_AdditionalCameraData = (Object_1 *)this->fields.m_AdditionalCameraData;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
		  {
		    NonObliqueProjection = HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix(
		                             &v14,
		                             this->fields.camera,
		                             0LL);
		    goto LABEL_9;
		  }
		  v7 = this->fields.m_AdditionalCameraData;
		  if ( !v7 )
		LABEL_7:
		    sub_1800D8260(v6, v7);
		  NonObliqueProjection = HG::Rendering::Runtime::HGAdditionalCameraData::GetNonObliqueProjection(
		                           &v14,
		                           v7,
		                           this->fields.camera,
		                           0LL);
		LABEL_9:
		  v10 = *(_OWORD *)&NonObliqueProjection->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&NonObliqueProjection->m00;
		  v11 = *(_OWORD *)&NonObliqueProjection->m02;
		  *(_OWORD *)&retstr->m01 = v10;
		  v12 = *(_OWORD *)&NonObliqueProjection->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v11;
		  *(_OWORD *)&retstr->m03 = v12;
		  return result;
		}
		
		internal bool isFirstFrame { get; private set; } // 0x0000000184DA1640-0x0000000184DA1650 0x0000000184DA1710-0x0000000184DA1720
		// Boolean get_isFirstFrame()
		bool HG::Rendering::Runtime::HGCamera::get_isFirstFrame(HGCamera *this, MethodInfo *method)
		{
		  return this->fields._isFirstFrame_k__BackingField;
		}
		

		// Void set_isFirstFrame(Boolean)
		void HG::Rendering::Runtime::HGCamera::set_isFirstFrame(HGCamera *this, bool value, MethodInfo *method)
		{
		  this->fields._isFirstFrame_k__BackingField = value;
		}
		
		internal bool isMainGameView { get => default; } // 0x0000000189B748B4-0x0000000189B74948 
		// Boolean get_isMainGameView()
		bool HG::Rendering::Runtime::HGCamera::get_isMainGameView(HGCamera *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Camera *camera; // rcx
		  Object_1 *targetTexture; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2812, 0LL) )
		  {
		    camera = this->fields.camera;
		    if ( camera )
		    {
		      if ( UnityEngine::Camera::get_cameraType(camera, 0LL) != CameraType__Enum_Game )
		        return 0;
		      camera = this->fields.camera;
		      if ( camera )
		      {
		        targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(camera, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        return UnityEngine::Object::op_Equality(targetTexture, 0LL, 0LL);
		      }
		    }
		LABEL_8:
		    sub_1800D8260(camera, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2812, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool canDoDynamicResolution { get => default; } // 0x000000018344FBA0-0x000000018344FC20 
		// Boolean get_canDoDynamicResolution()
		bool HG::Rendering::Runtime::HGCamera::get_canDoDynamicResolution(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *camera; // rbx
		  __int64 (__fastcall *v6)(Camera *); // rax
		  int v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 746 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_10:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x2EA )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[15].vtable.ToString.methodPtr )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(746, 0LL);
		    if ( Patch )
		    {
		      LOBYTE(v7) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                     (ILFixDynamicMethodWrapper_20 *)Patch,
		                     (Object *)this,
		                     0LL);
		      return v7;
		    }
		    goto LABEL_10;
		  }
		LABEL_5:
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_10;
		  v6 = (__int64 (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v6 )
		    {
		      v9 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v9, 0LL);
		    }
		    qword_18F36F138 = (__int64)v6;
		  }
		  v7 = v6(camera);
		  if ( v7 != 1 )
		    LOBYTE(v7) = 0;
		  return v7;
		}
		
		internal bool clearDepth { get => default; } // 0x0000000189B7446C-0x0000000189B74508 
		// Boolean get_clearDepth()
		bool HG::Rendering::Runtime::HGCamera::get_clearDepth(HGCamera *this, MethodInfo *method)
		{
		  Object_1 *m_AdditionalCameraData; // rbx
		  __int64 v4; // rdx
		  Camera *camera; // rcx
		  HGAdditionalCameraData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2813, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2813, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_AdditionalCameraData = (Object_1 *)this->fields.m_AdditionalCameraData;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
		    {
		      v6 = this->fields.m_AdditionalCameraData;
		      if ( v6 )
		        return v6->fields.clearDepth;
		LABEL_8:
		      sub_1800D8260(camera, v4);
		    }
		    camera = this->fields.camera;
		    if ( !camera )
		      goto LABEL_8;
		    return UnityEngine::Camera::get_clearFlags(camera, 0LL) != CameraClearFlags__Enum_Nothing;
		  }
		}
		
		internal bool enableAlpha { get => default; } // 0x000000018344DFD0-0x000000018344E0B0 
		// Boolean get_enableAlpha()
		bool HG::Rendering::Runtime::HGCamera::get_enableAlpha(HGCamera *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rbx
		  HGAdditionalCameraData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_13;
		  if ( *(int *)(v4 + 24) <= 962 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3C2u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[966] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !m_AdditionalCameraData )
		      return 0;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		      return 0;
		    v6 = this->fields.m_AdditionalCameraData;
		    if ( v6 )
		      return v6->fields.enableAlpha;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(962, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal HGAdditionalCameraData.ClearColorMode clearColorMode { get => default; } // 0x000000018344F6C0-0x000000018344F790 
		// HGAdditionalCameraData+ClearColorMode get_clearColorMode()
		HGAdditionalCameraData_ClearColorMode__Enum HG::Rendering::Runtime::HGCamera::get_clearColorMode(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  Camera *camera; // rcx
		  __int64 v4; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rdi
		  HGAdditionalCameraData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v4 )
		    goto LABEL_12;
		  if ( *(int *)(v4 + 24) > 741 )
		  {
		    if ( !LODWORD(camera[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(camera);
		      camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    camera = *(Camera **)camera[7].fields._._._.m_CachedPtr;
		    if ( !camera )
		      goto LABEL_12;
		    if ( LODWORD(camera[1].klass) <= 0x2E5 )
		      sub_1800D2AB0(camera, v4);
		    if ( camera[248].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
		      if ( !Patch )
		        goto LABEL_12;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		    }
		  }
		  camera = (Camera *)TypeInfo::UnityEngine::Object;
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    camera = (Camera *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      camera = (Camera *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_AdditionalCameraData )
		  {
		    if ( !LODWORD(camera[9].monitor) )
		      il2cpp_runtime_class_init_1(camera);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v6 = this->fields.m_AdditionalCameraData;
		      if ( v6 )
		        return v6->fields.clearColorMode;
		LABEL_12:
		      sub_1800D8260(camera, v4);
		    }
		  }
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_12;
		  if ( UnityEngine::Camera::get_clearFlags(camera, 0LL) == CameraClearFlags__Enum_Skybox )
		    return 0;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_12;
		  return (UnityEngine::Camera::get_clearFlags(camera, 0LL) != CameraClearFlags__Enum_Color) + 1;
		}
		
		internal UnityEngine.Color backgroundColorHDR { get => default; } // 0x000000018344EEF0-0x000000018344F0D0 
		// Color get_backgroundColorHDR()
		Color *HG::Rendering::Runtime::HGCamera::get_backgroundColorHDR(
		        Color *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  ITilemap *v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rax
		  Color *v6; // rdi
		  Camera **static_fields; // r8
		  Camera *camera; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rsi
		  HGAdditionalCameraData *v10; // rax
		  int32_t clearColorMode; // eax
		  HGAdditionalCameraData *v12; // rsi
		  HGAdditionalCameraData *v13; // rax
		  Color backgroundColorHDR; // xmm0
		  Color *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color *TileAnimationDataNoRef; // rax
		  __int64 v18; // rax
		  ILFixDynamicMethodWrapper_2 *v19; // rax
		  Color v20; // [rsp+20h] [rbp-28h] BYREF
		  char v21[24]; // [rsp+30h] [rbp-18h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v6 = retstr;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (Camera **)v4->static_fields;
		  camera = *static_fields;
		  if ( !*static_fields )
		    goto LABEL_31;
		  if ( SLODWORD(camera[1].klass) > 965 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    camera = (Camera *)v4->static_fields;
		    static_fields = (Camera **)camera->klass;
		    if ( !camera->klass )
		      goto LABEL_31;
		    if ( *((_DWORD *)static_fields + 6) <= 0x3C5u )
		      goto LABEL_46;
		    if ( static_fields[969] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(965, 0LL);
		      if ( !Patch )
		        goto LABEL_31;
		      TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_361(&v20, Patch, (Object *)this, 0LL);
		LABEL_54:
		      backgroundColorHDR = *TileAnimationDataNoRef;
		      goto LABEL_30;
		    }
		  }
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  retstr = (Color *)v4->static_fields;
		  camera = *(Camera **)&retstr->r;
		  if ( !*(_QWORD *)&retstr->r )
		    goto LABEL_31;
		  if ( SLODWORD(camera[1].klass) <= 741 )
		    goto LABEL_9;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  retstr = (Color *)v4->static_fields;
		  v18 = *(_QWORD *)&retstr->r;
		  if ( !*(_QWORD *)&retstr->r )
		    goto LABEL_31;
		  if ( *(_DWORD *)(v18 + 24) <= 0x2E5u )
		LABEL_46:
		    sub_1800D2AB0(retstr, camera);
		  if ( *(_QWORD *)(v18 + 5960) )
		  {
		    v19 = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
		    if ( !v19 )
		      goto LABEL_31;
		    clearColorMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                       (ILFixDynamicMethodWrapper_26 *)v19,
		                       (Object *)this,
		                       0LL);
		LABEL_19:
		    if ( clearColorMode != 2 )
		      goto LABEL_20;
		    goto LABEL_51;
		  }
		LABEL_9:
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( m_AdditionalCameraData )
		  {
		    retstr = (Color *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v10 = this->fields.m_AdditionalCameraData;
		      if ( !v10 )
		        goto LABEL_31;
		      clearColorMode = v10->fields.clearColorMode;
		      goto LABEL_19;
		    }
		  }
		  retstr = (Color *)this->fields.camera;
		  if ( !retstr )
		    goto LABEL_31;
		  if ( UnityEngine::Camera::get_clearFlags((Camera *)retstr, 0LL) != CameraClearFlags__Enum_Skybox )
		  {
		    retstr = (Color *)this->fields.camera;
		    if ( !retstr )
		      goto LABEL_31;
		    if ( UnityEngine::Camera::get_clearFlags((Camera *)retstr, 0LL) != CameraClearFlags__Enum_Color )
		    {
		LABEL_51:
		      TileAnimationDataNoRef = (Color *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                          (TileAnimationData *)&v20,
		                                          (TileBase *)camera,
		                                          (Vector3Int *)static_fields,
		                                          v3,
		                                          *(MethodInfo **)&v20.r);
		      goto LABEL_54;
		    }
		  }
		LABEL_20:
		  v12 = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  retstr = (Color *)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v12 )
		    goto LABEL_52;
		  retstr = (Color *)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v12->fields._._._._.m_CachedPtr )
		  {
		LABEL_52:
		    camera = this->fields.camera;
		    if ( camera )
		    {
		      v20 = *UnityEngine::Camera::get_backgroundColor(&v20, camera, 0LL);
		      TileAnimationDataNoRef = (Color *)sub_183C6CBA0(v21, &v20);
		      goto LABEL_54;
		    }
		LABEL_31:
		    sub_1800D8260(retstr, camera);
		  }
		  v13 = this->fields.m_AdditionalCameraData;
		  if ( !v13 )
		    goto LABEL_31;
		  backgroundColorHDR = v13->fields.backgroundColorHDR;
		LABEL_30:
		  result = v6;
		  *v6 = backgroundColorHDR;
		  return result;
		}
		
		internal HGAdditionalCameraData.FlipYMode flipYMode { get => default; } // 0x0000000189B747C4-0x0000000189B7484C 
		// HGAdditionalCameraData+FlipYMode get_flipYMode()
		HGAdditionalCameraData_FlipYMode__Enum HG::Rendering::Runtime::HGCamera::get_flipYMode(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  Object_1 *m_AdditionalCameraData; // rbx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGAdditionalCameraData *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2814, 0LL) )
		  {
		    m_AdditionalCameraData = (Object_1 *)this->fields.m_AdditionalCameraData;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
		      return 0;
		    v7 = this->fields.m_AdditionalCameraData;
		    if ( v7 )
		      return v7->fields.flipYMode;
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2814, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public HGAdditionalCameraData.AntialiasingMode antialiasing { get => default; set {} } // 0x0000000183106410-0x0000000183106470 0x000000018344ED70-0x000000018344EE50
		// HGAdditionalCameraData+AntialiasingMode get_antialiasing()
		HGAdditionalCameraData_AntialiasingMode__Enum HG::Rendering::Runtime::HGCamera::get_antialiasing(
		        HGCamera *this,
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
		  if ( wrapperArray->max_length.size <= 732 )
		    return this->fields.m_antialiasingMode;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2DC )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[15]._1.instance_size )
		    return this->fields.m_antialiasingMode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_antialiasing(HGAdditionalCameraData+AntialiasingMode)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        HGCamera *this,
		        HGAdditionalCameraData_AntialiasingMode__Enum value,
		        MethodInfo *method)
		{
		  _QWORD **v5; // rcx
		  __int64 v6; // r8
		  HGAdditionalCameraData *m_AdditionalCameraData; // rsi
		  HGAdditionalCameraData *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *v5[23];
		  if ( !v6 )
		    goto LABEL_13;
		  if ( *(int *)(v6 + 24) > 699 )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (_QWORD **)*v5[23];
		    if ( !v5 )
		      goto LABEL_13;
		    if ( *((_DWORD *)v5 + 6) <= 0x2BBu )
		      sub_1800D2AB0(v5, *(_QWORD *)&value);
		    if ( v5[703] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(699, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		        return;
		      }
		      goto LABEL_13;
		    }
		  }
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  this->fields.m_antialiasingMode = value;
		  v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_AdditionalCameraData )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		      il2cpp_runtime_class_init_1(v5);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v8 = this->fields.m_AdditionalCameraData;
		      if ( v8 )
		      {
		        v8->fields.antialiasing = value;
		        return;
		      }
		LABEL_13:
		      sub_1800D8260(v5, *(_QWORD *)&value);
		    }
		  }
		}
		
		public HGRenderPath renderPath { get => default; set {} } // 0x0000000183106070-0x00000001831060D0 0x0000000184CAB440-0x0000000184CAB490
		// HGRenderPath get_renderPath()
		HGRenderPath__Enum HG::Rendering::Runtime::HGCamera::get_renderPath(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
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
		  if ( wrapperArray->max_length.size <= 703 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2BF )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[15]._0.name )
		  {
		LABEL_5:
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( m_AdditionalCameraData )
		      return m_AdditionalCameraData->fields.hgRenderPath;
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_renderPath(HGRenderPath)
		void HG::Rendering::Runtime::HGCamera::set_renderPath(HGCamera *this, HGRenderPath__Enum value, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2816, 0LL) )
		  {
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( m_AdditionalCameraData )
		    {
		      m_AdditionalCameraData->fields.hgRenderPath = value;
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2816, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		}
		
		internal bool enableTAAU { get => default; } // 0x000000018344E530-0x000000018344E5D0 
		// Boolean get_enableTAAU()
		bool HG::Rendering::Runtime::HGCamera::get_enableTAAU(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  int *static_fields; // rdx
		  int32_t m_antialiasingMode; // eax
		  __int64 v7; // r8
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 736 )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v7 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(_DWORD *)(v7 + 24) <= 0x2E0u )
		    goto LABEL_26;
		  if ( !*(_QWORD *)(v7 + 5920) )
		  {
		LABEL_29:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_11;
		    if ( static_fields[6] <= 732 )
		    {
		LABEL_9:
		      m_antialiasingMode = v3->fields.m_antialiasingMode;
		      return (m_antialiasingMode & 2) != 0;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		LABEL_11:
		      sub_1800D8260(this, static_fields);
		    if ( LODWORD(klass->_0.namespaze) > 0x2DC )
		    {
		      if ( !*(_QWORD *)&klass[15]._1.instance_size )
		        goto LABEL_9;
		      Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( Patch )
		      {
		        LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                       (ILFixDynamicMethodWrapper_31 *)Patch,
		                                       (Object *)v3,
		                                       0LL);
		        return (m_antialiasingMode & 2) != 0;
		      }
		      goto LABEL_11;
		    }
		LABEL_26:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
		  if ( !v8 )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v8, (Object *)v3, 0LL);
		}
		
		internal bool enableMetalFXSpatialScaler { get => default; } // 0x0000000189B746A0-0x0000000189B7470C 
		// Boolean get_enableMetalFXSpatialScaler()
		bool HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(HGCamera *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2820, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2820, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    result = UnityEngine::SystemInfo::SupportsMetalFXSpatialScaler(0LL);
		    if ( result )
		      return (HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL) & 4) != 0;
		  }
		  return result;
		}
		
		internal bool enableMetalFXTemporalScaler { get => default; } // 0x000000018344D320-0x000000018344D380 
		// Boolean get_enableMetalFXTemporalScaler()
		bool HG::Rendering::Runtime::HGCamera::get_enableMetalFXTemporalScaler(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  bool result; // al
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
		  if ( wrapperArray->max_length.size > 737 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x2E1 )
		        sub_1800D2AB0(v3, method);
		      if ( !*(_QWORD *)&v3[15]._1.field_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(737, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  result = UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL);
		  if ( result )
		    return (HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL) & 8) != 0;
		  return result;
		}
		
		internal bool enablePSSR { get => default; } // 0x000000018344CF60-0x000000018344D000 
		// Boolean get_enablePSSR()
		bool HG::Rendering::Runtime::HGCamera::get_enablePSSR(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  int *static_fields; // rdx
		  int32_t m_antialiasingMode; // eax
		  __int64 v7; // r8
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 738 )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v7 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(_DWORD *)(v7 + 24) <= 0x2E2u )
		    goto LABEL_26;
		  if ( !*(_QWORD *)(v7 + 5936) )
		  {
		LABEL_29:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_11;
		    if ( static_fields[6] <= 732 )
		    {
		LABEL_9:
		      m_antialiasingMode = v3->fields.m_antialiasingMode;
		      return (m_antialiasingMode & 0x10) != 0;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		LABEL_11:
		      sub_1800D8260(this, static_fields);
		    if ( LODWORD(klass->_0.namespaze) > 0x2DC )
		    {
		      if ( !*(_QWORD *)&klass[15]._1.instance_size )
		        goto LABEL_9;
		      Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( Patch )
		      {
		        LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                       (ILFixDynamicMethodWrapper_31 *)Patch,
		                                       (Object *)v3,
		                                       0LL);
		        return (m_antialiasingMode & 0x10) != 0;
		      }
		      goto LABEL_11;
		    }
		LABEL_26:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(738, 0LL);
		  if ( !v8 )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v8, (Object *)v3, 0LL);
		}
		
		internal bool enableDLSS { get => default; } // 0x000000018344D280-0x000000018344D320 
		// Boolean get_enableDLSS()
		bool HG::Rendering::Runtime::HGCamera::get_enableDLSS(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  int *static_fields; // rdx
		  int32_t m_antialiasingMode; // eax
		  __int64 v7; // r8
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 739 )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v7 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(_DWORD *)(v7 + 24) <= 0x2E3u )
		    goto LABEL_26;
		  if ( !*(_QWORD *)(v7 + 5944) )
		  {
		LABEL_29:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_11;
		    if ( static_fields[6] <= 732 )
		    {
		LABEL_9:
		      m_antialiasingMode = v3->fields.m_antialiasingMode;
		      return (m_antialiasingMode & 0x20) != 0;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		LABEL_11:
		      sub_1800D8260(this, static_fields);
		    if ( LODWORD(klass->_0.namespaze) > 0x2DC )
		    {
		      if ( !*(_QWORD *)&klass[15]._1.instance_size )
		        goto LABEL_9;
		      Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( Patch )
		      {
		        LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                       (ILFixDynamicMethodWrapper_31 *)Patch,
		                                       (Object *)v3,
		                                       0LL);
		        return (m_antialiasingMode & 0x20) != 0;
		      }
		      goto LABEL_11;
		    }
		LABEL_26:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(739, 0LL);
		  if ( !v8 )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v8, (Object *)v3, 0LL);
		}
		
		internal bool enableFSR3 { get => default; } // 0x000000018344D1E0-0x000000018344D280 
		// Boolean get_enableFSR3()
		bool HG::Rendering::Runtime::HGCamera::get_enableFSR3(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  int *static_fields; // rdx
		  int32_t m_antialiasingMode; // eax
		  __int64 v7; // r8
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 740 )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v7 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_11;
		  if ( *(_DWORD *)(v7 + 24) <= 0x2E4u )
		    goto LABEL_26;
		  if ( !*(_QWORD *)(v7 + 5952) )
		  {
		LABEL_29:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = (int *)this->klass;
		    if ( !this->klass )
		      goto LABEL_11;
		    if ( static_fields[6] <= 732 )
		    {
		LABEL_9:
		      m_antialiasingMode = v3->fields.m_antialiasingMode;
		      return (m_antialiasingMode & 0x40) != 0;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		LABEL_11:
		      sub_1800D8260(this, static_fields);
		    if ( LODWORD(klass->_0.namespaze) > 0x2DC )
		    {
		      if ( !*(_QWORD *)&klass[15]._1.instance_size )
		        goto LABEL_9;
		      Patch = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( Patch )
		      {
		        LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                       (ILFixDynamicMethodWrapper_31 *)Patch,
		                                       (Object *)v3,
		                                       0LL);
		        return (m_antialiasingMode & 0x40) != 0;
		      }
		      goto LABEL_11;
		    }
		LABEL_26:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(740, 0LL);
		  if ( !v8 )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v8, (Object *)v3, 0LL);
		}
		
		internal bool enableMV { get => default; } // 0x0000000189B74654-0x0000000189B746A0 
		// Boolean get_enableMV()
		bool HG::Rendering::Runtime::HGCamera::get_enableMV(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(463, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(463, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool allowDynamicResolution { get => default; } // 0x0000000189B743E4-0x0000000189B7446C 
		// Boolean get_allowDynamicResolution()
		bool HG::Rendering::Runtime::HGCamera::get_allowDynamicResolution(HGCamera *this, MethodInfo *method)
		{
		  Object_1 *m_AdditionalCameraData; // rbx
		  bool result; // al
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGAdditionalCameraData *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2831, 0LL) )
		  {
		    m_AdditionalCameraData = (Object_1 *)this->fields.m_AdditionalCameraData;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL);
		    if ( !result )
		      return result;
		    v7 = this->fields.m_AdditionalCameraData;
		    if ( v7 )
		      return v7->fields.allowDynamicResolution;
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2831, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal HGPhysicalCamera physicalParameters { get; private set; } // 0x0000000184DA1660-0x0000000184DA1690 0x0000000184DA1730-0x0000000184DA1750
		// HGPhysicalCamera get_physicalParameters()
		HGPhysicalCamera *HG::Rendering::Runtime::HGCamera::get_physicalParameters(
		        HGPhysicalCamera *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  float m_Anamorphism; // eax
		  __int128 v4; // xmm1
		
		  m_Anamorphism = this->fields._physicalParameters_k__BackingField.m_Anamorphism;
		  v4 = *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_BladeCount;
		  *(_OWORD *)&retstr->m_Iso = *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_Iso;
		  *(_OWORD *)&retstr->m_BladeCount = v4;
		  retstr->m_Anamorphism = m_Anamorphism;
		  return retstr;
		}
		

		// Void set_physicalParameters(HGPhysicalCamera)
		void HG::Rendering::Runtime::HGCamera::set_physicalParameters(
		        HGCamera *this,
		        HGPhysicalCamera *value,
		        MethodInfo *method)
		{
		  float m_Anamorphism; // eax
		  __int128 v4; // xmm1
		
		  m_Anamorphism = value->m_Anamorphism;
		  v4 = *(_OWORD *)&value->m_BladeCount;
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&value->m_Iso;
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_BladeCount = v4;
		  this->fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
		}
		
		internal LayerMask probeLayerMask { get => default; } // 0x0000000189B74A74-0x0000000189B74B00 
		// LayerMask get_probeLayerMask()
		LayerMask HG::Rendering::Runtime::HGCamera::get_probeLayerMask(HGCamera *this, MethodInfo *method)
		{
		  Object_1 *m_AdditionalCameraData; // rbx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGAdditionalCameraData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2832, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2832, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1034(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_AdditionalCameraData = (Object_1 *)this->fields.m_AdditionalCameraData;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
		    {
		      v6 = this->fields.m_AdditionalCameraData;
		      if ( v6 )
		        return (LayerMask)v6->fields.probeLayerMask.m_Mask;
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return (LayerMask)-1;
		  }
		}
		
		internal float probeRangeCompressionFactor { get => default; } // 0x00000001832DE390-0x00000001832DE480 
		// Single get_probeRangeCompressionFactor()
		float HG::Rendering::Runtime::HGCamera::get_probeRangeCompressionFactor(HGCamera *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rbx
		  HGAdditionalCameraData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_13;
		  if ( *(int *)(v4 + 24) <= 893 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x37Du )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[897] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !m_AdditionalCameraData )
		      return 1.0;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		      return 1.0;
		    v6 = this->fields.m_AdditionalCameraData;
		    if ( v6 )
		      return v6->fields.probeCustomFixedExposure;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(893, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		internal DynamicResolutionRequest DynResRequest { get; set; } // 0x0000000184DA15E0-0x0000000184DA15F0 0x0000000184DA16B0-0x0000000184DA16C0
		// HGCamera+DynamicResolutionRequest get_DynResRequest()
		HGCamera_DynamicResolutionRequest HG::Rendering::Runtime::HGCamera::get_DynResRequest(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  return this->fields._DynResRequest_k__BackingField;
		}
		

		// Void set_DynResRequest(HGCamera+DynamicResolutionRequest)
		void HG::Rendering::Runtime::HGCamera::set_DynResRequest(
		        HGCamera *this,
		        HGCamera_DynamicResolutionRequest value,
		        MethodInfo *method)
		{
		  this->fields._DynResRequest_k__BackingField = value;
		}
		
		public VolumeComponentsData volumeComponentsData { get => default; } // 0x0000000183106760-0x00000001831067C0 
		// HGCamera+VolumeComponentsData get_volumeComponentsData()
		HGCamera_VolumeComponentsData *HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(
		        HGCamera *this,
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
		  if ( wrapperArray->max_length.size <= 783 )
		    return this->fields.m_volumeComponentsData;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x30F )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[16]._1.token )
		    return this->fields.m_volumeComponentsData;
		  Patch = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(Patch, (Object *)this, 0LL);
		}
		
		public HGEnvironmentVolumeCameraComponent envVolumeCameraComponent { get => default; } // 0x00000001831067C0-0x0000000183106820 
		// HGEnvironmentVolumeCameraComponent get_envVolumeCameraComponent()
		HGEnvironmentVolumeCameraComponent *HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(
		        HGCamera *this,
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
		  if ( wrapperArray->max_length.size <= 447 )
		    return this->fields.m_envVolumeCameraComponent;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1BF )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[9]._1.cctor_finished_or_no_cctor )
		    return this->fields.m_envVolumeCameraComponent;
		  Patch = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(Patch, (Object *)this, 0LL);
		}
		
		internal ProfilingSampler profilingSampler { get => default; } // 0x0000000183D9F8F0-0x0000000183D9F970 
		// ProfilingSampler get_profilingSampler()
		ProfilingSampler *HG::Rendering::Runtime::HGCamera::get_profilingSampler(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  ProfilingSampler *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 878 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x36E )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[18]._1.field_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(878, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_345(Patch, (Object *)this, 0LL);
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  if ( !m_AdditionalCameraData )
		    return UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		             (Int32Enum__Enum)0x28u,
		             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  result = m_AdditionalCameraData->fields.profilingSampler;
		  if ( !result )
		    return UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		             (Int32Enum__Enum)0x28u,
		             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  return result;
		}
		
		public uint screenCullingLayerMask { get => default; } // 0x0000000183E68CB0-0x0000000183E68EB0 
		// UInt32 get_screenCullingLayerMask()
		uint32_t HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 v6; // rax
		  String__Array *v7; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 967 )
		    goto LABEL_20;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_9;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3C7 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[20]._1.instance_size )
		  {
		LABEL_20:
		    if ( this->fields._screenCullingLayerMask )
		      return this->fields._screenCullingLayerMask;
		    v6 = il2cpp_array_new_specific_1(TypeInfo::System::String, 17LL);
		    v7 = (String__Array *)v6;
		    if ( v6 )
		    {
		      sub_180005370(v6, 0LL, "Default");
		      sub_180005370(v7, 1LL, "TransparentFX");
		      sub_180005370(v7, 2LL, "Ignore Raycast");
		      sub_180005370(v7, 3LL, "Water");
		      sub_180005370(v7, 4LL, "UI");
		      sub_180005370(v7, 5LL, "Walkable");
		      sub_180005370(v7, 6LL, "Climbable");
		      sub_180005370(v7, 7LL, "Trigger");
		      sub_180005370(v7, 8LL, "UIPP");
		      sub_180005370(v7, 9LL, "UIModel");
		      sub_180005370(v7, 10LL, "Building");
		      sub_180005370(v7, 11LL, "UIInteract");
		      sub_180005370(v7, 12LL, "WorldUI");
		      sub_180005370(v7, 13LL, "Projectile");
		      sub_180005370(v7, 14LL, "AbilityEntity");
		      sub_180005370(v7, 15LL, "Terrain");
		      sub_180005370(v7, 16LL, "IK");
		      this->fields._screenCullingLayerMask = UnityEngine::LayerMask::GetMask(v7, 0LL);
		      return this->fields._screenCullingLayerMask;
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(967, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal HGAdditionalCameraData additionalCameraData { get => default; } // 0x000000018394EE20-0x000000018394EE80 
		// HGAdditionalCameraData get_additionalCameraData()
		HGAdditionalCameraData *HG::Rendering::Runtime::HGCamera::get_additionalCameraData(HGCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 24 )
		    return this->fields.m_AdditionalCameraData;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x18 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3->_1.cctor_finished_or_no_cctor )
		    return this->fields.m_AdditionalCameraData;
		  Patch = IFix::WrappersManagerImpl::GetPatch(24, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(Patch, (Object *)this, 0LL);
		}
		
		private float sceneRTAspect { get => default; } // 0x000000018324DD70-0x000000018324DDE0 
		// Single get_sceneRTAspect()
		float HG::Rendering::Runtime::HGCamera::get_sceneRTAspect(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
		  if ( wrapperArray->max_length.size <= 765 )
		    return (float)this->fields._sceneRTSize_k__BackingField.m_X
		         / (float)(int)HIDWORD(*(_QWORD *)&this->fields._sceneRTSize_k__BackingField);
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2FD )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[16]._0.events )
		    return (float)this->fields._sceneRTSize_k__BackingField.m_X
		         / (float)(int)HIDWORD(*(_QWORD *)&this->fields._sceneRTSize_k__BackingField);
		  Patch = IFix::WrappersManagerImpl::GetPatch(765, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public struct ViewConstants // TypeDefIndex: 38095
		{
			// Fields
			public Matrix4x4 viewMatrix; // 0x00
			public Matrix4x4 invViewMatrix; // 0x40
			public Matrix4x4 projMatrix; // 0x80
			public Matrix4x4 nonJitteredProjMatrix; // 0xC0
			public Matrix4x4 invProjMatrix; // 0x100
			public Matrix4x4 viewProjMatrix; // 0x140
			public Matrix4x4 viewNoTransProjMatrix; // 0x180
			public Matrix4x4 invViewProjMatrix; // 0x1C0
			public Matrix4x4 nonJitteredViewProjMatrix; // 0x200
			public Matrix4x4 nonJitteredViewNoTransProjMatrix; // 0x240
			public Matrix4x4 invNonJitteredViewProjMatrix; // 0x280
			public Matrix4x4 prevViewMatrix; // 0x2C0
			public Matrix4x4 prevViewProjMatrix; // 0x300
			public Matrix4x4 prevViewNoTransProjMatrix; // 0x340
			public Matrix4x4 prevNonJitteredViewProjMatrix; // 0x380
			public Matrix4x4 prevNonJitteredViewNoTransProjMatrix; // 0x3C0
			public Matrix4x4 prevInvViewProjMatrix; // 0x400
			public Matrix4x4 prevNonJitteredInvViewProjMatrix; // 0x440
			public Matrix4x4 reprojectionMatrix; // 0x480
			public Matrix4x4 widerFoVViewProjMatrix; // 0x4C0
			public Matrix4x4 widerFoVInvViewProjMatrix; // 0x500
			public Matrix4x4 pixelCoordToViewDirWS; // 0x540
			public Matrix4x4 cullingMatrix; // 0x580
			public Vector3 worldSpaceCameraPos; // 0x5C0
			internal float pad0; // 0x5CC
			public Vector3 worldSpaceCameraPosViewOffset; // 0x5D0
			internal float pad1; // 0x5DC
			public Vector3 prevWorldSpaceCameraPos; // 0x5E0
			internal float pad2; // 0x5EC
		}
	
		public struct WaterMarkOutputCPP // TypeDefIndex: 38096
		{
			// Fields
			public unsafe int* srcRTs; // 0x00
			public unsafe int* dstRTs; // 0x08
			public unsafe float* heightScales; // 0x10
		}
	
		public struct InplaceWaterMarkOutputCPP // TypeDefIndex: 38097
		{
			// Fields
			public unsafe int* dstRTs; // 0x00
			public unsafe float* heightScales; // 0x08
		}
	
		internal enum HistoryEffectSlot // TypeDefIndex: 38098
		{
			GlobalIllumination0 = 0,
			GlobalIllumination1 = 1,
			RayTracedReflections = 2,
			VolumetricClouds = 3,
			Count = 4
		}
	
		internal struct HistoryEffectValidity // TypeDefIndex: 38099
		{
			// Fields
			public int frameCount; // 0x00
			public int flagMask; // 0x04
		}
	
		internal struct DynamicResolutionRequest // TypeDefIndex: 38100
		{
			// Fields
			public bool enabled; // 0x00
			public bool cameraRequested; // 0x01
			public bool hardwareEnabled; // 0x02
			public DynamicResUpscaleFilter filter; // 0x03
		}
	
		public class VolumeComponentsData // TypeDefIndex: 38101
		{
			// Fields
			public Bloom m_bloom; // 0x10
			public Vignette m_vignette; // 0x18
			public HGVignette m_hgVignette; // 0x20
			public HGDirtyLens m_hgDirtyLens; // 0x28
			public HGSharpen m_sharpen; // 0x30
			public HGRadialBlur m_radialBlur; // 0x38
			public HGHorizontalBlur m_horizontalBlur; // 0x40
			public HGBWFlash m_bwFlash; // 0x48
			public HGFisheyeEffect m_fisheyeEffect; // 0x50
			public HGChromaticAbberation m_chromaticAbberation; // 0x58
			public HGDepthOfField m_depthOfField; // 0x60
			public HGMotionBlur m_motionBlur; // 0x68
			public HGCharacterVolume m_hgCharacterVolume; // 0x70
			public HGSceneColorStylizer m_sceneColorStylizer; // 0x78
			public ScreenSpaceReflectionVolume m_hgssrVolume; // 0x80
			public ScreenSpacePlanarReflectionVolume m_ssprVolume; // 0x88
			public HGScanLine m_hgScanLine; // 0x90
			public HGBlackBox m_hgBlackBox; // 0x98
			public GTAmbientOcclusion m_GTAmbientOcclusion; // 0xA0
			public OtherSettings m_otherSettings; // 0xA8
			public RayTracingReflectionVolume m_rayTracingReflectionVolume; // 0xB0
			public HGAnamorphicStreaks m_anamorphicStreaks; // 0xB8
	
			// Constructors
			public VolumeComponentsData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		// Constructors
		public HGCamera() {} // Dummy constructor
		internal HGCamera(Camera cam) {} // 0x00000001837DD570-0x00000001837DDD50
		// HGCamera(Camera)
		void HG::Rendering::Runtime::HGCamera::HGCamera(HGCamera *this, Camera *cam, MethodInfo *method)
		{
		  Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v5; // rax
		  Type *v6; // rdx
		  Component *camera; // rcx
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *v8; // rbx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  LowLevelList_1_System_Object_ *v12; // rax
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v13; // rbx
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rcx
		  __m128 v18; // xmm2
		  __m128 v19; // xmm2
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm2
		  __int128 v24; // xmm3
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
		  List_1_System_Int32_ *v26; // rbx
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  HGPhysicalCamera *Defaults; // rax
		  float m_Anamorphism; // ecx
		  __int128 v32; // xmm1
		  HGCamera_VolumeComponentsData *v33; // rax
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  HGEnvironmentVolumeCameraComponent *v36; // rax
		  HGEnvironmentVolumeCameraComponent *v37; // rbx
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  Matrix4x4__StaticFields *v41; // rcx
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm2
		  __int128 v45; // xmm3
		  BufferedRTHandleSystem *v46; // rax
		  BufferedRTHandleSystem *v47; // rbx
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  MaterialPropertyBlock *v51; // rbx
		  Type *v52; // rdx
		  PropertyInfo_1 *v53; // r8
		  Int32__Array **v54; // r9
		  Type *v55; // rdx
		  PropertyInfo_1 *v56; // r8
		  Int32__Array **v57; // r9
		  Type *v58; // rdx
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  Type *v61; // rdx
		  PropertyInfo_1 *v62; // r8
		  Int32__Array **v63; // r9
		  Type *v64; // rdx
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  Type *v67; // rdx
		  PropertyInfo_1 *v68; // r8
		  Int32__Array **v69; // r9
		  VolumeManager *instance; // rax
		  Type *v71; // rdx
		  PropertyInfo_1 *v72; // r8
		  Int32__Array **v73; // r9
		  GameObject *gameObject; // rax
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  Type *v77; // rdx
		  PropertyInfo_1 *v78; // r8
		  Int32__Array **v79; // r9
		  int i; // r14d
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v82; // rax
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v83; // rsi
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **v85; // r9
		  int j; // esi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v87; // rax
		  List_1_System_Object_ *v88; // rbp
		  HashSet_1_System_Object_ *v89; // rax
		  Object *v90; // rbx
		  HGShadowManager *v91; // rax
		  HGShadowManager *v92; // rbx
		  Type *v93; // rdx
		  PropertyInfo_1 *v94; // r8
		  Int32__Array **v95; // r9
		  HGLightCookieManager *v96; // rax
		  HGLightCookieManager *v97; // rbx
		  Type *v98; // rdx
		  PropertyInfo_1 *v99; // r8
		  Int32__Array **v100; // r9
		  __int64 v101; // rax
		  PropertyInfo_1 *v102; // r8
		  Int32__Array **v103; // r9
		  struct Object_1__Class *v104; // rcx
		  Mesh *parafinMesh; // rbx
		  Type *v106; // rdx
		  PropertyInfo_1 *v107; // r8
		  Int32__Array **v108; // r9
		  GameObject *v109; // rax
		  Type *v110; // rdx
		  PropertyInfo_1 *v111; // r8
		  Int32__Array **v112; // r9
		  __m128 v113; // [rsp+20h] [rbp-78h]
		  MethodInfo *v114; // [rsp+20h] [rbp-78h]
		  MethodInfo *v115; // [rsp+20h] [rbp-78h]
		  MethodInfo *v116; // [rsp+20h] [rbp-78h]
		  MethodInfo *v117; // [rsp+20h] [rbp-78h]
		  MethodInfo *v118; // [rsp+20h] [rbp-78h]
		  MethodInfo *v119; // [rsp+20h] [rbp-78h]
		  MethodInfo *v120; // [rsp+20h] [rbp-78h]
		  MethodInfo *v121; // [rsp+20h] [rbp-78h]
		  MethodInfo *v122; // [rsp+20h] [rbp-78h]
		  MethodInfo *v123; // [rsp+20h] [rbp-78h]
		  MethodInfo *v124; // [rsp+20h] [rbp-78h]
		  MethodInfo *v125; // [rsp+20h] [rbp-78h]
		  MethodInfo *v126; // [rsp+20h] [rbp-78h]
		  MethodInfo *v127; // [rsp+20h] [rbp-78h]
		  MethodInfo *v128; // [rsp+20h] [rbp-78h]
		  __m256i v129; // [rsp+30h] [rbp-68h] BYREF
		  _BYTE v130[24]; // [rsp+50h] [rbp-48h]
		  __int64 v131; // [rsp+A0h] [rbp+8h]
		
		  this->fields.autoExposureReadyForNextFetch = 1;
		  this->fields.exposureTargetAdaptation = 1.0;
		  this->fields.exposureAdaptation = 1.0;
		  this->fields.waterCameraFoVInc = 20.0;
		  this->fields.m_nextWaterMarkHandle = 1;
		  this->fields.m_finalRTSize = (Vector2Int)-1LL;
		  v5 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>);
		  v8 = (Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *)v5;
		  if ( !v5 )
		    goto LABEL_37;
		  System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
		    v5,
		    MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dictionary);
		  this->fields.m_waterMarkRTs = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_waterMarkRTs, v9, v10, v11, (MethodInfo *)v113.m128_u64[0]);
		  v12 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>);
		  v13 = (List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *)v12;
		  if ( !v12 )
		    goto LABEL_37;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v12,
		    MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::List);
		  this->fields.m_inplaceWaterMarkRTs = v13;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_inplaceWaterMarkRTs,
		    v14,
		    v15,
		    v16,
		    (MethodInfo *)v113.m128_u64[0]);
		  this->fields.beforeCullingParams = 0LL;
		  v131 = sub_185EDD110(v17, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		  v113.m128_u64[0] = 0LL;
		  v18 = _mm_shuffle_ps(v113, v113, 210);
		  v18.m128_f32[0] = *(float *)&v131;
		  v19 = _mm_shuffle_ps(v18, v18, 39);
		  v19.m128_f32[0] = *((float *)&v131 + 1);
		  this->fields.finalViewport = (Rect)_mm_shuffle_ps(v19, v19, 57);
		  static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v21 = *(_OWORD *)&static_fields->identityMatrix.m00;
		  v22 = *(_OWORD *)&static_fields->identityMatrix.m01;
		  v23 = *(_OWORD *)&static_fields->identityMatrix.m02;
		  v24 = *(_OWORD *)&static_fields->identityMatrix.m03;
		  this->fields.m_firstGetDoFComponent = 1;
		  *(_OWORD *)&this->fields.frustumCornorsRay.m00 = v21;
		  this->fields.lowResScale = 0.5;
		  *(_OWORD *)&this->fields.frustumCornorsRay.m01 = v22;
		  this->fields.m_PreviousClearColorMode = 2;
		  *(_OWORD *)&this->fields.frustumCornorsRay.m02 = v23;
		  this->fields.m_uiAfterBlurSortingOrder = 0x7FFF;
		  *(_OWORD *)&this->fields.frustumCornorsRay.m03 = v24;
		  v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v26 = (List_1_System_Int32_ *)v25;
		  if ( !v25 )
		    goto LABEL_37;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v25,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_sortingOrdersToBlur = v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_sortingOrdersToBlur, v27, v28, v29, 0LL);
		  this->fields.resetPostProcessingHistory = 1;
		  Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults((HGPhysicalCamera *)&v129, 0LL);
		  m_Anamorphism = Defaults->m_Anamorphism;
		  v32 = *(_OWORD *)&Defaults->m_BladeCount;
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&Defaults->m_Iso;
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_BladeCount = v32;
		  this->fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
		  v33 = (HGCamera_VolumeComponentsData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCamera::VolumeComponentsData);
		  if ( !v33 )
		    goto LABEL_37;
		  this->fields.m_volumeComponentsData = v33;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_volumeComponentsData, v6, v34, v35, v114);
		  v36 = (HGEnvironmentVolumeCameraComponent *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent);
		  v37 = v36;
		  if ( !v36 )
		    goto LABEL_37;
		  HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::HGEnvironmentVolumeCameraComponent(v36, 0LL);
		  this->fields.m_envVolumeCameraComponent = v37;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_envVolumeCameraComponent, v38, v39, v40, v115);
		  this->fields.screenCullingRatio = 0.0049999999;
		  this->fields.screenRatioCullingDistance = 30.0;
		  this->fields.cullingViewHandle = -1;
		  *(_QWORD *)&this->fields.terrainCullViewHandle = -1LL;
		  *(_QWORD *)&this->fields.waterProxyCullHandle = -1LL;
		  v41 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v42 = *(_OWORD *)&v41->identityMatrix.m00;
		  v43 = *(_OWORD *)&v41->identityMatrix.m01;
		  v44 = *(_OWORD *)&v41->identityMatrix.m02;
		  v45 = *(_OWORD *)&v41->identityMatrix.m03;
		  this->fields.reflectionProbeOctTextureArrayCount = 1;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m00 = v42;
		  *(_QWORD *)&this->fields.rayTracingCullingViewHandle = -1LL;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m01 = v43;
		  this->fields.overrideCsmMaxDistanceValue = 80.0;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m02 = v44;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m03 = v45;
		  v46 = (BufferedRTHandleSystem *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BufferedRTHandleSystem);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_37;
		  UnityEngine::Rendering::BufferedRTHandleSystem::BufferedRTHandleSystem(v46, 0LL);
		  this->fields.m_HistoryRTSystem = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_HistoryRTSystem, v48, v49, v50, v116);
		  this->fields.m_RecorderTempRT = UnityEngine::Shader::PropertyToID((String *)"TempRecorder", 0LL);
		  v51 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v51 )
		    goto LABEL_37;
		  v51->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_RecorderPropertyBlock = v51;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RecorderPropertyBlock, v52, v53, v54, v117);
		  this->fields.m_ForceJitterIdx = -1;
		  this->fields._msaaSamples_k__BackingField = 1;
		  this->fields.camera = cam;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.camera, v55, v56, v57, v118);
		  if ( !cam )
		    goto LABEL_37;
		  this->fields._name_k__BackingField = UnityEngine::Object::get_name((Object_1 *)cam, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v58, v59, v60, v119);
		  this->fields.frustum = 0LL;
		  this->fields.frustum.planes = (Plane__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.frustum, v61, v62, v63, v120);
		  this->fields.frustum.corners = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 8LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.frustum.corners, v64, v65, v66, v121);
		  this->fields.frustumPlaneEquations = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                           TypeInfo::UnityEngine::Vector4,
		                                                           6LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.frustumPlaneEquations, v67, v68, v69, v122);
		  if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		  instance = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_37;
		  this->fields._volumeStack_k__BackingField = UnityEngine::Rendering::VolumeManager::CreateStack(instance, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._volumeStack_k__BackingField, v71, v72, v73, v123);
		  HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::Allocate(&this->fields.m_DepthBufferMipChainInfo, 0LL);
		  camera = (Component *)this->fields.camera;
		  if ( !camera )
		    goto LABEL_37;
		  gameObject = UnityEngine::Component::get_gameObject(camera, 0LL);
		  if ( !gameObject )
		    goto LABEL_37;
		  if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
		          gameObject,
		          (Object **)&this->fields.m_AdditionalCameraData,
		          MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
		  {
		    camera = (Component *)this->fields.camera;
		    if ( !camera )
		      goto LABEL_37;
		    v109 = UnityEngine::Component::get_gameObject(camera, 0LL);
		    if ( !v109 )
		      goto LABEL_37;
		    this->fields.m_AdditionalCameraData = (HGAdditionalCameraData *)UnityEngine::GameObject::AddComponent<System::Object>(
		                                                                      v109,
		                                                                      MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_AdditionalCameraData, v110, v111, v112, v124);
		  }
		  *(_OWORD *)&v130[4] = 0LL;
		  v129.m256i_i64[0] = 0LL;
		  *(__m128i *)((char *)&v129.m256i_u64[1] + 4) = _mm_load_si128((const __m128i *)&xmmword_18B9596C0);
		  v129.m256i_i32[2] = 0;
		  v129.m256i_i32[7] = 2139095039;
		  v75 = *(_OWORD *)&v129.m256i_u64[2];
		  *(_DWORD *)v130 = 2139095039;
		  *(_OWORD *)&this->fields.lodCrossFadeConfig.cameraPosition.x = *(_OWORD *)v129.m256i_i8;
		  *(_DWORD *)&v130[20] = 0;
		  v76 = *(_OWORD *)v130;
		  *(_OWORD *)&this->fields.lodCrossFadeConfig.c0.y = v75;
		  *(_QWORD *)&v75 = *(_QWORD *)&v130[16];
		  *(_OWORD *)&this->fields.lodCrossFadeConfig.c1.z = v76;
		  *(_QWORD *)&this->fields.lodCrossFadeConfig.maxProjFactorSquared1 = v75;
		  this->fields.m_rtExtractionLists = (List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *)il2cpp_array_new_specific_1(
		                                                                                                  TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>,
		                                                                                                  2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rtExtractionLists, v77, v78, v79, v124);
		  for ( i = 0; i < 2; ++i )
		  {
		    m_rtExtractionLists = this->fields.m_rtExtractionLists;
		    v82 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>);
		    v83 = (List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *)v82;
		    if ( !v82 )
		      goto LABEL_37;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v82,
		      MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::List);
		    if ( !m_rtExtractionLists )
		      goto LABEL_37;
		    sub_180031B10(m_rtExtractionLists, v83);
		    if ( (unsigned int)i >= m_rtExtractionLists->max_length.size )
		LABEL_43:
		      sub_1800D2AB0(camera, v6);
		    m_rtExtractionLists->vector[i] = v83;
		    sub_18002D1B0((SingleFieldAccessor *)&m_rtExtractionLists->vector[i], v6, v84, v85, v125);
		    for ( j = 0; j < 4; ++j )
		    {
		      v87 = this->fields.m_rtExtractionLists;
		      if ( !v87 )
		        goto LABEL_37;
		      if ( (unsigned int)i >= v87->max_length.size )
		        goto LABEL_43;
		      v88 = (List_1_System_Object_ *)v87->vector[i];
		      v89 = (HashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>);
		      v90 = (Object *)v89;
		      if ( !v89 )
		        goto LABEL_37;
		      System::Collections::Generic::HashSet<System::Object>::HashSet(
		        v89,
		        MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::HashSet);
		      if ( !v88 )
		        goto LABEL_37;
		      sub_182F01190(v88, v90);
		    }
		  }
		  v91 = (HGShadowManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		  v92 = v91;
		  if ( !v91 )
		    goto LABEL_37;
		  HG::Rendering::Runtime::HGShadowManager::HGShadowManager(v91, 0LL);
		  this->fields.shadowManager = v92;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowManager, v93, v94, v95, v125);
		  v96 = (HGLightCookieManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		  v97 = v96;
		  if ( !v96
		    || (HG::Rendering::Runtime::HGLightCookieManager::HGLightCookieManager(v96, 0LL),
		        this->fields.lightCookieManager = v97,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.lightCookieManager, v98, v99, v100, v126),
		        (v101 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager)) == 0) )
		  {
		LABEL_37:
		    sub_1800D8260(camera, v6);
		  }
		  *(_DWORD *)(v101 + 28) = 1065353216;
		  *(_DWORD *)(v101 + 32) = 1;
		  this->fields.verticalOcclusionMapManager = (HGVerticalOcclusionMapManager *)v101;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.verticalOcclusionMapManager, v6, v102, v103, v127);
		  v104 = TypeInfo::UnityEngine::Object;
		  parafinMesh = this->fields.parafinMesh;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v104 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v104 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !parafinMesh )
		    goto LABEL_34;
		  if ( !v104->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v104);
		  if ( !parafinMesh->fields._.m_CachedPtr )
		  {
		LABEL_34:
		    this->fields.parafinMesh = HG::Rendering::Runtime::HGCamera::CreateParafinTriangleMesh(this, 0.001, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.parafinMesh, v106, v107, v108, v128);
		    camera = (Component *)this->fields.parafinMesh;
		    if ( camera )
		    {
		      UnityEngine::Mesh::UploadMeshData((Mesh *)camera, 1, 0LL);
		      goto LABEL_36;
		    }
		    goto LABEL_37;
		  }
		LABEL_36:
		  HG::Rendering::Runtime::HGCamera::InitializeVolumeComponentsData(this, 0LL);
		  HG::Rendering::Runtime::HGCamera::Reset(this, 0LL);
		}
		
		static HGCamera() {} // 0x00000001849E0950-0x00000001849E0AD0
		// HGCamera()
		void HG::Rendering::Runtime::HGCamera::cctor(MethodInfo *method)
		{
		  ExtractionDoneCallback *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Type__Class *v4; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  char v8; // bl
		  char v9; // di
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v10; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  LowLevelList_1_System_Object_ *v15; // rax
		  List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *v16; // rbx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		
		  v1 = (ExtractionDoneCallback *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ExtractionDoneCallback);
		  v4 = (Type__Class *)v1;
		  if ( !v1 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::ExtractionDoneCallback::ExtractionDoneCallback(
		    v1,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::HGCamera::RTExtractionDone,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields;
		  static_fields->klass = v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields,
		    static_fields,
		    v6,
		    v7,
		    v20);
		  v8 = UnityEngine::LayerMask::NameToLayer((String *)"Character", 0LL);
		  v9 = UnityEngine::LayerMask::NameToLayer((String *)"Enemy", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->COMPOUND_CHARACTER_LAYER_MASK = (1 << (v8 & 0x1F)) | (1 << (v9 & 0x1F)) | (1 << (UnityEngine::LayerMask::NameToLayer((String *)"NPC", 0LL) & 0x1F));
		  v10 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>);
		  v11 = v10;
		  if ( !v10
		    || (System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::Dictionary(
		          v10,
		          MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Dictionary),
		        v12 = (Type *)TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields,
		        v12->fields._impl.value = v11,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->s_Cameras,
		          v12,
		          v13,
		          v14,
		          v21),
		        v15 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>),
		        (v16 = (List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *)v15) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  }
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v15,
		    MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::List);
		  TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->s_Cleanup = v16;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->s_Cleanup,
		    v17,
		    v18,
		    v19,
		    v22);
		  TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->worldUILayerIndex = 16;
		}
		
	
		// Methods
		public uint RegisterWaterMarkRTs(RTHandle srcRT, RTHandle dstRT, float heightScale) => default; // 0x0000000189B734C4-0x0000000189B735D8
		// UInt32 RegisterWaterMarkRTs(RTHandle, RTHandle, Single)
		uint32_t HG::Rendering::Runtime::HGCamera::RegisterWaterMarkRTs(
		        HGCamera *this,
		        RTHandle *srcRT,
		        RTHandle *dstRT,
		        float heightScale,
		        MethodInfo *method)
		{
		  uint32_t m_nextWaterMarkHandle; // ebx
		  uint32_t v9; // eax
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ValueTuple_3_Object_Object_Single_ v17; // [rsp+30h] [rbp-58h] BYREF
		  ValueTuple_3_Object_Object_Single_ v18; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2786, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2786, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1020(
		             Patch,
		             (Object *)this,
		             (Object *)srcRT,
		             (Object *)dstRT,
		             heightScale,
		             0LL);
		  }
		  else
		  {
		    m_nextWaterMarkHandle = this->fields.m_nextWaterMarkHandle;
		    v9 = m_nextWaterMarkHandle + 1;
		    this->fields.m_nextWaterMarkHandle = m_nextWaterMarkHandle + 1;
		    if ( !m_nextWaterMarkHandle )
		    {
		      ++m_nextWaterMarkHandle;
		      this->fields.m_nextWaterMarkHandle = v9 + 1;
		    }
		    m_waterMarkRTs = this->fields.m_waterMarkRTs;
		    memset(&v17, 0, sizeof(v17));
		    System::ValueTuple<System::Object,System::Object,float>::ValueTuple(
		      &v17,
		      (Object *)srcRT,
		      (Object *)dstRT,
		      heightScale,
		      MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
		    if ( !m_waterMarkRTs )
		      sub_1800D8260(v12, v11);
		    v18 = v17;
		    sub_1808AEE40(m_waterMarkRTs, m_nextWaterMarkHandle, &v18);
		    return m_nextWaterMarkHandle;
		  }
		}
		
		public void UnregisterWaterMarkRTs(uint waterMarkHandle) {} // 0x0000000189B74298-0x0000000189B74308
		// Void UnregisterWaterMarkRTs(UInt32)
		void HG::Rendering::Runtime::HGCamera::UnregisterWaterMarkRTs(
		        HGCamera *this,
		        uint32_t waterMarkHandle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2787, 0LL) )
		  {
		    m_waterMarkRTs = this->fields.m_waterMarkRTs;
		    if ( m_waterMarkRTs )
		    {
		      System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Core::EntityManager_EntityDataStorage::HideByTypeParams>::Remove(
		        (Dictionary_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *)m_waterMarkRTs,
		        waterMarkHandle,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Remove);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_waterMarkRTs, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2787, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		    (ILFixDynamicMethodWrapper_9 *)Patch,
		    (Object *)this,
		    (LoginSceneAnimCtrl_EState__Enum)waterMarkHandle,
		    0LL);
		}
		
		public void RegisterInplaceWaterMarkRTs(RTHandle dstRT, float heightScale) {} // 0x0000000189B73410-0x0000000189B734C4
		// Void RegisterInplaceWaterMarkRTs(RTHandle, Single)
		void HG::Rendering::Runtime::HGCamera::RegisterInplaceWaterMarkRTs(
		        HGCamera *this,
		        RTHandle *dstRT,
		        float heightScale,
		        MethodInfo *method)
		{
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rbx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  ValueTuple_2_Object_Single_ v12; // [rsp+30h] [rbp-38h] BYREF
		  ValueTuple_2_Object_Single_ v13; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2788, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2788, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (Object *)dstRT,
		      heightScale,
		      0LL);
		  }
		  else
		  {
		    m_inplaceWaterMarkRTs = this->fields.m_inplaceWaterMarkRTs;
		    v12 = 0LL;
		    System::ValueTuple<System::Object,float>::ValueTuple(
		      &v12,
		      (Object *)dstRT,
		      heightScale,
		      MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,float>::ValueTuple);
		    if ( !m_inplaceWaterMarkRTs )
		      sub_1800D8260(v8, v7);
		    v13 = v12;
		    sub_1808AEE90(m_inplaceWaterMarkRTs, &v13);
		  }
		}
		
		public Dictionary<uint, ValueTuple<RTHandle, RTHandle, float>> GetWaterMarkRTs() => default; // 0x0000000189B731A8-0x0000000189B731F8
		// Dictionary`2[System.UInt32,System.ValueTuple`3[UnityEngine.Rendering.RTHandle,UnityEngine.Rendering.RTHandle,Single]] GetWaterMarkRTs()
		Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *HG::Rendering::Runtime::HGCamera::GetWaterMarkRTs(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2789, 0LL) )
		    return this->fields.m_waterMarkRTs;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2789, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1021(Patch, (Object *)this, 0LL);
		}
		
		public List<ValueTuple<RTHandle, float>> GetInplaceWaterMarkRTs() => default; // 0x0000000189B72ED8-0x0000000189B72F28
		// List`1[System.ValueTuple`2[UnityEngine.Rendering.RTHandle,Single]] GetInplaceWaterMarkRTs()
		List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(
		        HGCamera *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2790, 0LL) )
		    return this->fields.m_inplaceWaterMarkRTs;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2790, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1022(Patch, (Object *)this, 0LL);
		}
		
		public void TransferWaterMarkRTs(HGCamera cam) {} // 0x0000000189B73D3C-0x0000000189B741E8
		// Void TransferWaterMarkRTs(HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGCamera::TransferWaterMarkRTs(HGCamera *this, HGCamera *cam, MethodInfo *method)
		{
		  HGCamera *v3; // rbx
		  HGCamera *v4; // rdi
		  unsigned __int64 v5; // rdx
		  Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *v6; // rcx
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rsi
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Dictionary_2_System_UInt32_System_ValueTuple_3_Object_Object_Single_ *v10; // rsi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rax
		  signed __int64 v14; // rcx
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v15; // xmm0
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v16; // r9
		  unsigned __int64 v17; // r8
		  signed __int64 v18; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  _BYTE v22[32]; // [rsp+0h] [rbp-158h] BYREF
		  __int128 coreZone; // [rsp+30h] [rbp-128h] BYREF
		  ValueTuple_3_Object_Object_Single_ v24; // [rsp+40h] [rbp-118h] BYREF
		  ValueTuple_3_Object_Object_Single_ v25; // [rsp+60h] [rbp-F8h] BYREF
		  FacLineDrawer_LineData value; // [rsp+88h] [rbp-D0h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ v27; // [rsp+A0h] [rbp-B8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v28; // [rsp+C0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v29; // [rsp+F8h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v30; // [rsp+100h] [rbp-58h] BYREF
		  KeyValuePair_2_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ current; // [rsp+108h] [rbp-50h] BYREF
		  uint32_t key; // [rsp+178h] [rbp+20h] BYREF
		
		  v3 = cam;
		  v4 = this;
		  memset(&v28, 0, sizeof(v28));
		  key = 0;
		  memset(&value, 0, sizeof(value));
		  memset(&v27, 0, sizeof(v27));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1204, 0LL) )
		  {
		    m_waterMarkRTs = v4->fields.m_waterMarkRTs;
		    if ( !m_waterMarkRTs )
		      sub_1800D8260(v6, v5);
		    if ( m_waterMarkRTs->fields._count != m_waterMarkRTs->fields._freeCount )
		    {
		      if ( !v3 )
		        sub_1800D8260(v6, v5);
		      if ( !v3->fields.m_waterMarkRTs )
		        sub_1800D8260(v6, v5);
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		        (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v3->fields.m_waterMarkRTs,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
		      if ( !v4->fields.m_waterMarkRTs )
		        sub_1800D8260(v9, v8);
		      v28 = *(Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)sub_1808AEE70(&current, v4->fields.m_waterMarkRTs);
		      *(_QWORD *)&coreZone = 0LL;
		      *((_QWORD *)&coreZone + 1) = &v28;
		      try
		      {
		        while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
		                  &v28,
		                  MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		        {
		          current = v28._current;
		          System::Collections::Generic::KeyValuePair<unsigned int,Beyond::UI::FacLineDrawer::LineData>::Deconstruct(
		            &current,
		            &key,
		            &value,
		            MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
		          v10 = (Dictionary_2_System_UInt32_System_ValueTuple_3_Object_Object_Single_ *)v3->fields.m_waterMarkRTs;
		          memset(&v25, 0, sizeof(v25));
		          System::ValueTuple<System::Object,System::Object,float>::ValueTuple(
		            &v25,
		            (Object *)value.start,
		            (Object *)value.end,
		            *(float *)&value.link,
		            MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
		          if ( !v10 )
		            sub_1800D8250(v12, v11);
		          v24 = v25;
		          System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<System::Object,System::Object,float>>::Add(
		            v10,
		            key,
		            &v24,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Add);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v29 )
		      {
		        v5 = (unsigned __int64)v22;
		        *(Il2CppExceptionWrapper *)&coreZone = (Il2CppExceptionWrapper)v29->ex;
		        v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)coreZone;
		        if ( (_QWORD)coreZone )
		          sub_18007E1E0(coreZone);
		        v3 = cam;
		        v4 = this;
		      }
		      if ( !v3 )
		        goto LABEL_43;
		      v3->fields.m_nextWaterMarkHandle = v4->fields.m_nextWaterMarkHandle;
		      v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v4->fields.m_waterMarkRTs;
		      if ( !v6 )
		        goto LABEL_43;
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		        v6,
		        MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
		    }
		    m_inplaceWaterMarkRTs = v4->fields.m_inplaceWaterMarkRTs;
		    if ( m_inplaceWaterMarkRTs )
		    {
		      if ( !m_inplaceWaterMarkRTs->fields._size )
		        return;
		      if ( v3 )
		      {
		        v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v3->fields.m_inplaceWaterMarkRTs;
		        if ( v6 )
		        {
		          sub_183E6E020(
		            v6,
		            MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
		          v5 = (unsigned __int64)v4->fields.m_inplaceWaterMarkRTs;
		          if ( v5 )
		          {
		            System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
		              (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&current,
		              (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v5,
		              MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
		            v27 = (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_)current;
		            v24.Item1 = 0LL;
		            v24.Item2 = (Object *)&v27;
		            try
		            {
		              while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::MoveNext(
		                        &v27,
		                        MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		              {
		                v15 = v27._current;
		                v16 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v3->fields.m_inplaceWaterMarkRTs;
		                coreZone = (unsigned __int64)v27._current.coreZone;
		                if ( dword_18F35FD08 )
		                {
		                  v17 = (((unsigned __int64)&coreZone >> 12) & 0x1FFFFF) >> 6;
		                  v5 = ((unsigned __int64)&coreZone >> 12) & 0x3F;
		                  _m_prefetchw(&qword_18F103690[v17]);
		                  do
		                  {
		                    v14 = qword_18F103690[v17] | (1LL << v5);
		                    v18 = qword_18F103690[v17];
		                  }
		                  while ( v18 != _InterlockedCompareExchange64(&qword_18F103690[v17], v14, v18) );
		                }
		                DWORD2(coreZone) = _mm_shuffle_ps((__m128)v15, (__m128)v15, 170).m128_u32[0];
		                if ( !v16 )
		                  sub_1800D8250(v14, v5);
		                *(_OWORD *)&v25.Item1 = coreZone;
		                System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::Add(
		                  v16,
		                  (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v25,
		                  MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Add);
		              }
		            }
		            catch ( Il2CppExceptionWrapper *v30 )
		            {
		              v5 = (unsigned __int64)v22;
		              v24.Item1 = (Object *)v30->ex;
		              if ( v24.Item1 )
		                sub_18007E1E0(v24.Item1);
		              v4 = this;
		            }
		            v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v4->fields.m_inplaceWaterMarkRTs;
		            if ( v6 )
		            {
		              sub_183E6E020(
		                v6,
		                MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_43:
		    sub_1800D8250(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1204, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v21, v20);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, (Object *)v3, 0LL);
		}
		
		public WaterMarkOutputCPP GetWaterMarkRTsCPP(ref int count) => default; // 0x0000000183C7C530-0x0000000183C7C8F0
		// HGCamera+WaterMarkOutputCPP GetWaterMarkRTsCPP(Int32 ByRef)
		// Hidden C++ exception states: #wind=1
		HGCamera_WaterMarkOutputCPP *HG::Rendering::Runtime::HGCamera::GetWaterMarkRTsCPP(
		        HGCamera_WaterMarkOutputCPP *__return_ptr retstr,
		        HGCamera *this,
		        int32_t *count,
		        MethodInfo *method)
		{
		  HGCamera_WaterMarkOutputCPP *v6; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGCamera_WaterMarkOutputCPP *v13; // rax
		  __int128 v14; // xmm0
		  float *heightScales; // xmm1_8
		  Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rdi
		  int32_t v17; // eax
		  FieldDescriptor *descriptor; // rsi
		  Action_2_Google_Protobuf_IMessage_Object_ *TempFromCSharp; // r12
		  Action_1_Google_Protobuf_IMessage_ *clearDelegate; // r13
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  __m128d v26; // xmm6
		  struct MethodInfo *v27; // rdi
		  Il2CppClass *klass; // rcx
		  Il2CppClass *v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  int getValueDelegate; // xmm6_4
		  RenderTexture *name; // rdi
		  RenderTexture *v34; // rsi
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // r14
		  int32_t InstanceID; // eax
		  __int64 v39; // rdi
		  HGCamera_WaterMarkOutputCPP *result; // rax
		  MethodInfo *v41; // [rsp+20h] [rbp-118h]
		  SingleFieldAccessor v42; // [rsp+30h] [rbp-108h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *v43; // [rsp+68h] [rbp-D0h]
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v44; // [rsp+78h] [rbp-C0h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v45; // [rsp+B0h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v46; // [rsp+E8h] [rbp-50h] BYREF
		
		  v6 = retstr;
		  memset(&v42, 0, 24);
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, this);
		  if ( wrapperArray->max_length.size <= 881 )
		    goto LABEL_12;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v9 = v7->static_fields->wrapperArray;
		  if ( !v9 )
		    sub_1800D8260(v7, this);
		  if ( v9->max_length.size <= 0x371u )
		    sub_1800D2AB0(v7, this);
		  if ( !v9[24].vector[17] )
		  {
		LABEL_12:
		    m_waterMarkRTs = this->fields.m_waterMarkRTs;
		    if ( !m_waterMarkRTs )
		      sub_1800D8260(v7, this);
		    v17 = m_waterMarkRTs->fields._count - m_waterMarkRTs->fields._freeCount;
		    *count = v17;
		    descriptor = 0LL;
		    TempFromCSharp = 0LL;
		    clearDelegate = 0LL;
		    if ( v17 <= 0 )
		      goto LABEL_30;
		    v42.fields._.descriptor = (FieldDescriptor *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
		                                                   4 * v17,
		                                                   0LL);
		    TempFromCSharp = (Action_2_Google_Protobuf_IMessage_Object_ *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
		                                                                    4 * *count,
		                                                                    0LL);
		    v42.fields.setValueDelegate = TempFromCSharp;
		    clearDelegate = (Action_1_Google_Protobuf_IMessage_ *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
		                                                            4 * *count,
		                                                            0LL);
		    v42.fields.clearDelegate = clearDelegate;
		    *count = 0;
		    if ( !this->fields.m_waterMarkRTs )
		      sub_1800D8260(v22, v21);
		    System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)&v44,
		      (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)this->fields.m_waterMarkRTs,
		      MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
		    v45 = v44;
		    v42.fields.hasDelegate = 0LL;
		    v43 = &v45;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
		                &v45,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		      {
		        *(_OWORD *)&v44._dictionary = *(_OWORD *)&v45._current.key;
		        v26 = *(__m128d *)&v45._current.value.end;
		        *(_OWORD *)&v44._current.key = *(_OWORD *)&v45._current.value.end;
		        v27 = MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct;
		        klass = MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct->klass;
		        if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		          sub_1800360B0(klass, v23);
		        v29 = v27->klass;
		        if ( ((__int64)v29->vtable[0].methodPtr & 1) == 0 )
		          sub_1800360B0(v29, v23);
		        *(_OWORD *)&v42.klass = *(_OWORD *)&v44._version;
		        v42.fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)*(_OWORD *)&_mm_unpackhi_pd(v26, v26);
		        sub_18002D1B0(&v42, v23, v24, v25, v41);
		        getValueDelegate = (int)v42.fields._.getValueDelegate;
		        if ( v42.klass && v42.monitor && *(float *)&v42.fields._.getValueDelegate >= 1.0 )
		        {
		          name = (RenderTexture *)v42.klass->_0.name;
		          v34 = (RenderTexture *)*((_QWORD *)v42.monitor + 2);
		          if ( !name )
		            sub_1800D8250(v31, v30);
		          UnityEngine::RenderTexture::Create(name, 0LL);
		          if ( !v34 )
		            sub_1800D8250(v36, v35);
		          UnityEngine::RenderTexture::Create(v34, 0LL);
		          v37 = *count;
		          InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)name, 0LL);
		          *((_DWORD *)&v42.fields._.descriptor->klass + v37) = InstanceID;
		          v39 = *count;
		          *((_DWORD *)&TempFromCSharp->klass + v39) = UnityEngine::Object::GetInstanceID((Object_1 *)v34, 0LL);
		          *((_DWORD *)&clearDelegate->klass + (*count)++) = getValueDelegate;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v46 )
		    {
		      v42.fields.hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v46->ex;
		      if ( v42.fields.hasDelegate )
		        sub_18007E1E0(v42.fields.hasDelegate);
		      v6 = retstr;
		      descriptor = v42.fields._.descriptor;
		      TempFromCSharp = v42.fields.setValueDelegate;
		      clearDelegate = v42.fields.clearDelegate;
		      goto LABEL_30;
		    }
		    descriptor = v42.fields._.descriptor;
		LABEL_30:
		    v42.klass = (SingleFieldAccessor__Class *)descriptor;
		    v42.monitor = (MonitorData *)TempFromCSharp;
		    v42.fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)clearDelegate;
		    v14 = *(_OWORD *)&v42.klass;
		    heightScales = (float *)clearDelegate;
		    goto LABEL_31;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(881, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v12, v11);
		  v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_346(
		          (HGCamera_WaterMarkOutputCPP *)&v42.fields.hasDelegate,
		          Patch,
		          (Object *)this,
		          count,
		          0LL);
		  v14 = *(_OWORD *)&v13->srcRTs;
		  heightScales = v13->heightScales;
		LABEL_31:
		  *(_OWORD *)&v6->srcRTs = v14;
		  result = v6;
		  v6->heightScales = heightScales;
		  return result;
		}
		
		public InplaceWaterMarkOutputCPP GetInplaceWaterMarkRTsCPP(ref int count) => default; // 0x0000000183D23F90-0x0000000183D24230
		// HGCamera+InplaceWaterMarkOutputCPP GetInplaceWaterMarkRTsCPP(Int32 ByRef)
		// Hidden C++ exception states: #wind=1
		HGCamera_InplaceWaterMarkOutputCPP *HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTsCPP(
		        HGCamera_InplaceWaterMarkOutputCPP *__return_ptr retstr,
		        HGCamera *this,
		        int32_t *count,
		        MethodInfo *method)
		{
		  HGCamera_InplaceWaterMarkOutputCPP *v6; // r12
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGCamera_InplaceWaterMarkOutputCPP v13; // xmm0
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rbx
		  int32_t size; // eax
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *TempFromCSharp; // r14
		  _DWORD *v17; // r15
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  int32_t freeBusCount; // xmm6_4
		  RenderTexture *klass; // rbx
		  __int64 v24; // rsi
		  HGCamera_InplaceWaterMarkOutputCPP *result; // rax
		  Il2CppExceptionWrapper *v26; // [rsp+40h] [rbp-A8h] BYREF
		  Il2CppException *ex; // [rsp+48h] [rbp-A0h]
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v28; // [rsp+50h] [rbp-98h]
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ v29; // [rsp+58h] [rbp-90h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ v30; // [rsp+78h] [rbp-70h] BYREF
		
		  v6 = retstr;
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, this);
		  if ( wrapperArray->max_length.size <= 882 )
		    goto LABEL_12;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v9 = v7->static_fields->wrapperArray;
		  if ( !v9 )
		    sub_1800D8260(v7, this);
		  if ( v9->max_length.size <= 0x372u )
		    sub_1800D2AB0(v7, this);
		  if ( v9[24].vector[18] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(882, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_347(
		             (HGCamera_InplaceWaterMarkOutputCPP *)&v29,
		             Patch,
		             (Object *)this,
		             count,
		             0LL);
		  }
		  else
		  {
		LABEL_12:
		    m_inplaceWaterMarkRTs = this->fields.m_inplaceWaterMarkRTs;
		    if ( !m_inplaceWaterMarkRTs )
		      sub_1800D8260(v7, this);
		    size = m_inplaceWaterMarkRTs->fields._size;
		    *count = size;
		    TempFromCSharp = 0LL;
		    v17 = 0LL;
		    if ( size > 0 )
		    {
		      TempFromCSharp = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * size, 0LL);
		      v17 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * *count, 0LL);
		      *count = 0;
		      if ( !this->fields.m_inplaceWaterMarkRTs )
		        sub_1800D8260(v19, v18);
		      System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
		        &v29,
		        (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_inplaceWaterMarkRTs,
		        MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
		      v30 = v29;
		      ex = 0LL;
		      v28 = &v30;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::MoveNext(
		                  &v30,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
		        {
		          v29._list = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v30._current.coreZone;
		          freeBusCount = v30._current.freeBusCount;
		          if ( v30._current.coreZone && *(float *)&v30._current.freeBusCount >= 1.0 )
		          {
		            klass = (RenderTexture *)v30._current.coreZone[1].klass;
		            if ( !klass )
		              sub_1800D8250(v21, v20);
		            UnityEngine::RenderTexture::Create(klass, 0LL);
		            v24 = *count;
		            *((_DWORD *)&TempFromCSharp->klass + v24) = UnityEngine::Object::GetInstanceID((Object_1 *)klass, 0LL);
		            v17[(*count)++] = freeBusCount;
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v26 )
		      {
		        ex = v26->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v6 = retstr;
		      }
		    }
		    v29._list = TempFromCSharp;
		    *(_QWORD *)&v29._index = v17;
		    v13 = *(HGCamera_InplaceWaterMarkOutputCPP *)&v29._list;
		  }
		  result = v6;
		  *v6 = v13;
		  return result;
		}
		
		public void RegisterRTExtraction(RTExtractionType type, RTExtractionDuration duration, RTHandle rt) {} // 0x00000001837DD4D0-0x00000001837DD570
		// Void RegisterRTExtraction(RTExtractionType, RTExtractionDuration, RTHandle)
		void HG::Rendering::Runtime::HGCamera::RegisterRTExtraction(
		        HGCamera *this,
		        RTExtractionType__Enum type,
		        RTExtractionDuration__Enum duration,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  __int64 v6; // rbx
		  __int64 v9; // rdx
		  List_1_System_Object_ *v10; // rcx
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = (int)duration;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2791, 0LL) )
		  {
		    m_rtExtractionLists = this->fields.m_rtExtractionLists;
		    if ( m_rtExtractionLists )
		    {
		      if ( (unsigned int)v6 >= m_rtExtractionLists->max_length.size )
		        sub_1800D2AB0(v10, v9);
		      v10 = (List_1_System_Object_ *)m_rtExtractionLists->vector[v6];
		      if ( v10 )
		      {
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 v10,
		                 type,
		                 MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
		        if ( Item )
		        {
		          System::Collections::Generic::HashSet<System::Object>::Add(
		            (HashSet_1_System_Object_ *)Item,
		            (Object *)rt,
		            MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Add);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2791, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1023(
		    Patch,
		    (Object *)this,
		    type,
		    (RTExtractionDuration__Enum)v6,
		    (Object *)rt,
		    0LL);
		}
		
		[IDTag(0)]
		[Obsolete("UnRegisterRTExtraction with RTExtractionDuration is obsolete, use other version instead")]
		public void UnRegisterRTExtraction(RTExtractionType type, RTExtractionDuration duration, RTHandle rt) {} // 0x00000001837DD260-0x00000001837DD300
		// Void UnRegisterRTExtraction(RTExtractionType, RTExtractionDuration, RTHandle)
		void HG::Rendering::Runtime::HGCamera::UnRegisterRTExtraction(
		        HGCamera *this,
		        RTExtractionType__Enum type,
		        RTExtractionDuration__Enum duration,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  __int64 v6; // rbx
		  __int64 v9; // rdx
		  List_1_System_Object_ *v10; // rcx
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = (int)duration;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2792, 0LL) )
		  {
		    m_rtExtractionLists = this->fields.m_rtExtractionLists;
		    if ( m_rtExtractionLists )
		    {
		      if ( (unsigned int)v6 >= m_rtExtractionLists->max_length.size )
		        sub_1800D2AB0(v10, v9);
		      v10 = (List_1_System_Object_ *)m_rtExtractionLists->vector[v6];
		      if ( v10 )
		      {
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 v10,
		                 type,
		                 MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
		        if ( Item )
		        {
		          System::Collections::Generic::HashSet<System::Object>::Remove(
		            (HashSet_1_System_Object_ *)Item,
		            (Object *)rt,
		            MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2792, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1023(
		    Patch,
		    (Object *)this,
		    type,
		    (RTExtractionDuration__Enum)v6,
		    (Object *)rt,
		    0LL);
		}
		
		[IDTag(1)]
		public void UnRegisterRTExtraction(RTExtractionType type, RTHandle rt) {} // 0x0000000189B741E8-0x0000000189B74298
		// Void UnRegisterRTExtraction(RTExtractionType, RTHandle)
		void HG::Rendering::Runtime::HGCamera::UnRegisterRTExtraction(
		        HGCamera *this,
		        RTExtractionType__Enum type,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  List_1_System_Object_ *v8; // rcx
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2793, 0LL) )
		  {
		    m_rtExtractionLists = this->fields.m_rtExtractionLists;
		    if ( m_rtExtractionLists )
		    {
		      if ( !m_rtExtractionLists->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (List_1_System_Object_ *)m_rtExtractionLists->vector[0];
		      if ( v8 )
		      {
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 v8,
		                 type,
		                 MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
		        if ( Item )
		        {
		          System::Collections::Generic::HashSet<System::Object>::Remove(
		            (HashSet_1_System_Object_ *)Item,
		            (Object *)rt,
		            MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2793, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_25(
		    (ILFixDynamicMethodWrapper_14 *)Patch,
		    (Object *)this,
		    (SCMessageID__Enum)type,
		    (Object *)rt,
		    0LL);
		}
		
		internal ValueTuple<HashSet<RTHandle>, HashSet<RTHandle>> GetRTForExtraction(RTExtractionType type) => default; // 0x0000000189B73070-0x0000000189B73164
		// ValueTuple`2[System.Collections.Generic.HashSet`1[UnityEngine.Rendering.RTHandle],System.Collections.Generic.HashSet`1[UnityEngine.Rendering.RTHandle]] GetRTForExtraction(RTExtractionType)
		ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
		        ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *__return_ptr retstr,
		        HGCamera *this,
		        RTExtractionType__Enum type,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  List_1_System_Object_ *klass; // rcx
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
		  Object *Item; // rax
		  Object *v11; // rbp
		  Object *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v15; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2794, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2794, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1025(&v15, Patch, (Object *)this, type, 0LL);
		      return retstr;
		    }
		    goto LABEL_11;
		  }
		  m_rtExtractionLists = this->fields.m_rtExtractionLists;
		  if ( !m_rtExtractionLists )
		    goto LABEL_11;
		  if ( !m_rtExtractionLists->max_length.size )
		LABEL_9:
		    sub_1800D2AB0(klass, v7);
		  klass = (List_1_System_Object_ *)m_rtExtractionLists->vector[0];
		  if ( !klass
		    || (Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 klass,
		                 type,
		                 MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item),
		        klass = (List_1_System_Object_ *)this->fields.m_rtExtractionLists,
		        v11 = Item,
		        !klass) )
		  {
		LABEL_11:
		    sub_1800D8260(klass, v7);
		  }
		  if ( klass->fields._size <= 1u )
		    goto LABEL_9;
		  klass = (List_1_System_Object_ *)klass[1].klass;
		  if ( !klass )
		    goto LABEL_11;
		  v12 = System::Collections::Generic::List<System::Object>::get_Item(
		          klass,
		          type,
		          MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
		  *retstr = 0LL;
		  Rewired::Utils::Classes::Data::IndexedDictionary_2_TKey_TValue_::yzhVwnWVXpgEXQufmGiVcJkbjlTI<System::Object,System::Object>::yzhVwnWVXpgEXQufmGiVcJkbjlTI(
		    (IndexedDictionary_2_TKey_TValue_yzhVwnWVXpgEXQufmGiVcJkbjlTI_System_Object_System_Object_ *)retstr,
		    v11,
		    v12,
		    MethodInfo::System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::ValueTuple);
		  return retstr;
		}
		
		internal unsafe int* GetRTForExtractionCPP(RTExtractionType type, ref int count, HGCamera uiCamera = null) => default; // 0x00000001837DE2B0-0x00000001837DE9F0
		// Int32* GetRTForExtractionCPP(RTExtractionType, Int32 ByRef, HGCamera)
		// local variable allocation has failed, the output may be wrong!
		// Hidden C++ exception states: #wind=4
		int32_t *HG::Rendering::Runtime::HGCamera::GetRTForExtractionCPP(
		        HGCamera *this,
		        RTExtractionType__Enum type,
		        int32_t *count,
		        HGCamera *uiCamera,
		        MethodInfo *method)
		{
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rdi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v6; // rdi
		  HashSet_1_UnityEngine_Rendering_RTHandle___Array *items; // rdi
		  HashSet_1_System_UInt64_ *v8; // r12
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v9; // rdi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v10; // rdi
		  HashSet_1_UnityEngine_Rendering_RTHandle___Array *v11; // rdi
		  HashSet_1_System_UInt64_ *v12; // r14
		  HashSet_1_System_UInt64_ *v13; // r13
		  HashSet_1_System_UInt64_ *v14; // r15
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v15; // rdi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v16; // rdi
		  HashSet_1_UnityEngine_Rendering_RTHandle___Array *v17; // rdi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v18; // rdi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v19; // rdi
		  HashSet_1_UnityEngine_Rendering_RTHandle___Array *v20; // rdi
		  int32_t v21; // ecx
		  int32_t *TempFromCSharp; // rbx
		  __int64 *v24; // rdx
		  HashSet_1_System_UInt64_ *set; // rcx
		  Object__Class *klass; // rdi
		  int32_t *v27; // rsi
		  __int64 *v28; // rdx
		  signed __int64 v29; // rtt
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Object__Class *v32; // rdi
		  void (__fastcall *v33)(Object__Class *); // rax
		  int32_t *v34; // rsi
		  __int64 *v35; // rdx
		  signed __int64 v36; // rtt
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  Object__Class *v39; // rdi
		  int32_t *v40; // rsi
		  __int64 *v41; // rdx
		  signed __int64 v42; // rtt
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  Object__Class *v45; // rdi
		  int32_t *v46; // rsi
		  __int64 v47; // rax
		  __int64 v48; // [rsp+0h] [rbp-B8h] BYREF
		  HashSet_1_T_Enumerator_System_Object_ v49; // [rsp+20h] [rbp-98h] BYREF
		  HashSet_1_T_Enumerator_System_Object_ v50; // [rsp+38h] [rbp-80h] BYREF
		  HashSet_1_System_UInt64_ *v51; // [rsp+50h] [rbp-68h]
		  HashSet_1_System_UInt64_ *v52; // [rsp+58h] [rbp-60h]
		  Il2CppExceptionWrapper *v53; // [rsp+60h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+68h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v55; // [rsp+70h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v56; // [rsp+78h] [rbp-40h] BYREF
		  HashSet_1_System_UInt64_ *v57; // [rsp+C0h] [rbp+8h]
		  int32_t *v58; // [rsp+D0h] [rbp+18h]
		  int32_t *v59; // [rsp+D8h] [rbp+20h]
		
		  m_rtExtractionLists = this->fields.m_rtExtractionLists;
		  if ( !m_rtExtractionLists )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( !m_rtExtractionLists->max_length.size )
		    sub_1800D2AB0(this, *(_QWORD *)&type);
		  v6 = m_rtExtractionLists->vector[0];
		  if ( !v6 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( type >= v6->fields._size )
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  items = v6->fields._items;
		  if ( !items )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( type >= items->max_length.size )
		    sub_1800D2AB0(this, *(_QWORD *)&type);
		  v8 = (HashSet_1_System_UInt64_ *)items->vector[type];
		  v9 = this->fields.m_rtExtractionLists;
		  if ( !v9 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( v9->max_length.size <= 1u )
		    sub_1800D2AB0(this, *(_QWORD *)&type);
		  v10 = v9->vector[1];
		  if ( !v10 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( type >= v10->fields._size )
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  v11 = v10->fields._items;
		  if ( !v11 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( type >= v11->max_length.size )
		    sub_1800D2AB0(this, *(_QWORD *)&type);
		  v12 = (HashSet_1_System_UInt64_ *)v11->vector[type];
		  v52 = v12;
		  v13 = 0LL;
		  v51 = 0LL;
		  v14 = 0LL;
		  v57 = 0LL;
		  if ( uiCamera )
		  {
		    v15 = uiCamera->fields.m_rtExtractionLists;
		    if ( !v15 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( !v15->max_length.size )
		      sub_1800D2AB0(this, *(_QWORD *)&type);
		    v16 = v15->vector[0];
		    if ( !v16 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( type >= v16->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    v17 = v16->fields._items;
		    if ( !v17 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( type >= v17->max_length.size )
		      sub_1800D2AB0(this, *(_QWORD *)&type);
		    v13 = (HashSet_1_System_UInt64_ *)v17->vector[type];
		    v51 = v13;
		    v18 = uiCamera->fields.m_rtExtractionLists;
		    if ( !v18 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( v18->max_length.size <= 1u )
		      sub_1800D2AB0(this, *(_QWORD *)&type);
		    v19 = v18->vector[1];
		    if ( !v19 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( type >= v19->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    v20 = v19->fields._items;
		    if ( !v20 )
		      sub_1800D8260(this, *(_QWORD *)&type);
		    if ( type >= v20->max_length.size )
		      sub_1800D2AB0(this, *(_QWORD *)&type);
		    v14 = (HashSet_1_System_UInt64_ *)v20->vector[type];
		    v57 = v14;
		  }
		  if ( !v8 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  if ( !v12 )
		    sub_1800D8260(this, *(_QWORD *)&type);
		  v21 = v8->fields._count + v12->fields._count;
		  *count = v21;
		  if ( v13 )
		    *count = v13->fields._count + v21;
		  if ( v14 )
		    *count += v14->fields._count;
		  if ( *count <= 0 )
		    return 0LL;
		  TempFromCSharp = (int32_t *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
		                                4 * *count,
		                                0LL);
		  v59 = TempFromCSharp;
		  v58 = TempFromCSharp;
		  System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
		    (HashSet_1_T_Enumerator_System_UInt64_ *)&v49,
		    v8,
		    MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
		  v50 = v49;
		  v49._set = 0LL;
		  *(_QWORD *)&v49._index = &v50;
		  try
		  {
		    while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		              &v50,
		              MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		    {
		      if ( v50._current )
		      {
		        klass = v50._current[1].klass;
		        if ( !klass )
		          sub_1800D8250(set, v24);
		        UnityEngine::RenderTexture::Create((RenderTexture *)klass, 0LL);
		        v27 = TempFromCSharp++;
		        v59 = TempFromCSharp;
		        *v27 = UnityEngine::Object::GetInstanceID((Object_1 *)klass, 0LL);
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v53 )
		  {
		    v24 = &v48;
		    v49._set = (HashSet_1_System_Object_ *)v53->ex;
		    set = (HashSet_1_System_UInt64_ *)v49._set;
		    if ( v49._set )
		      sub_18007E1E0(v49._set);
		    v12 = v52;
		    v13 = v51;
		    v14 = v57;
		    TempFromCSharp = v59;
		  }
		  if ( !v12 )
		    sub_1800D8250(set, v24);
		  *(_OWORD *)&v49._index = 0LL;
		  v49._set = (HashSet_1_System_Object_ *)v12;
		  if ( dword_18F35FD08 )
		  {
		    v28 = &qword_18F0BCBA0[(((unsigned __int64)&v49 >> 12) & 0x1FFFFF) >> 6];
		    _m_prefetchw(v28 + 36190);
		    do
		      v29 = v28[36190];
		    while ( v29 != _InterlockedCompareExchange64(
		                     v28 + 36190,
		                     v29 | (1LL << (((unsigned __int64)&v49 >> 12) & 0x3F)),
		                     v29) );
		  }
		  v49._index = 0;
		  v49._version = v12->fields._version;
		  v49._current = 0LL;
		  *(_OWORD *)&v50._set = *(_OWORD *)&v49._set;
		  v50._current = 0LL;
		  v49._set = 0LL;
		  *(_QWORD *)&v49._index = &v50;
		  try
		  {
		    while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		              &v50,
		              MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		    {
		      if ( v50._current )
		      {
		        v32 = v50._current[1].klass;
		        if ( !v32 )
		          sub_1800D8250(v31, v30);
		        v33 = (void (__fastcall *)(Object__Class *))qword_18F36F9B8;
		        if ( !qword_18F36F9B8 )
		        {
		          v33 = (void (__fastcall *)(Object__Class *))il2cpp_resolve_icall_1("UnityEngine.RenderTexture::Create()");
		          if ( !v33 )
		          {
		            v47 = sub_1802EE1B8("UnityEngine.RenderTexture::Create()");
		            sub_18007E1B0(v47, 0LL);
		          }
		          qword_18F36F9B8 = (__int64)v33;
		        }
		        v33(v32);
		        v34 = TempFromCSharp++;
		        v59 = TempFromCSharp;
		        *v34 = UnityEngine::Object::GetInstanceID((Object_1 *)v32, 0LL);
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v54 )
		  {
		    v49._set = (HashSet_1_System_Object_ *)v54->ex;
		    if ( v49._set )
		      sub_18007E1E0(v49._set);
		    v13 = v51;
		    v14 = v57;
		    TempFromCSharp = v59;
		  }
		  if ( v13 )
		  {
		    *(_OWORD *)&v49._index = 0LL;
		    v49._set = (HashSet_1_System_Object_ *)v13;
		    if ( dword_18F35FD08 )
		    {
		      v35 = &qword_18F0BCBA0[(((unsigned __int64)&v49 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v35 + 36190);
		      do
		        v36 = v35[36190];
		      while ( v36 != _InterlockedCompareExchange64(
		                       v35 + 36190,
		                       v36 | (1LL << (((unsigned __int64)&v49 >> 12) & 0x3F)),
		                       v36) );
		    }
		    v49._index = 0;
		    v49._version = v13->fields._version;
		    v49._current = 0LL;
		    *(_OWORD *)&v50._set = *(_OWORD *)&v49._set;
		    v50._current = 0LL;
		    v49._set = 0LL;
		    *(_QWORD *)&v49._index = &v50;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		                &v50,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		      {
		        if ( v50._current )
		        {
		          v39 = v50._current[1].klass;
		          if ( !v39 )
		            sub_1800D8250(v38, v37);
		          UnityEngine::RenderTexture::Create((RenderTexture *)v39, 0LL);
		          v40 = TempFromCSharp++;
		          v59 = TempFromCSharp;
		          *v40 = UnityEngine::Object::GetInstanceID((Object_1 *)v39, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v55 )
		    {
		      v49._set = (HashSet_1_System_Object_ *)v55->ex;
		      if ( v49._set )
		        sub_18007E1E0(v49._set);
		      v14 = v57;
		      TempFromCSharp = v59;
		    }
		  }
		  if ( v14 )
		  {
		    *(_OWORD *)&v49._index = 0LL;
		    v49._set = (HashSet_1_System_Object_ *)v14;
		    if ( dword_18F35FD08 )
		    {
		      v41 = &qword_18F0BCBA0[(((unsigned __int64)&v49 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v41 + 36190);
		      do
		        v42 = v41[36190];
		      while ( v42 != _InterlockedCompareExchange64(
		                       v41 + 36190,
		                       v42 | (1LL << (((unsigned __int64)&v49 >> 12) & 0x3F)),
		                       v42) );
		    }
		    v49._index = 0;
		    v49._version = v14->fields._version;
		    v49._current = 0LL;
		    *(_OWORD *)&v50._set = *(_OWORD *)&v49._set;
		    v50._current = 0LL;
		    v49._set = 0LL;
		    *(_QWORD *)&v49._index = &v50;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
		                &v50,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
		      {
		        if ( v50._current )
		        {
		          v45 = v50._current[1].klass;
		          if ( !v45 )
		            sub_1800D8250(v44, v43);
		          UnityEngine::RenderTexture::Create((RenderTexture *)v45, 0LL);
		          v46 = TempFromCSharp++;
		          *v46 = UnityEngine::Object::GetInstanceID((Object_1 *)v45, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v56 )
		    {
		      v49._set = (HashSet_1_System_Object_ *)v56->ex;
		      if ( v49._set )
		        sub_18007E1E0(v49._set);
		    }
		  }
		  return v58;
		}
		
		private static void RTExtractionDone(HGCamera camera, RTHandle rt) {} // 0x0000000189B733BC-0x0000000189B73410
		// Void RTExtractionDone(HGCamera, RTHandle)
		void HG::Rendering::Runtime::HGCamera::RTExtractionDone(HGCamera *camera, RTHandle *rt, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2795, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2795, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)camera,
		      (Object *)rt,
		      0LL);
		  }
		}
		
		public static HGCamera GetOrCreate(Camera camera, int xrMultipassId = 0 /* Metadata: 0x023038B6 */) => default; // 0x0000000183451AD0-0x0000000183451E40
		// HGCamera GetOrCreate(Camera, Int32)
		// local variable allocation has failed, the output may be wrong!
		HGCamera *HG::Rendering::Runtime::HGCamera::GetOrCreate(Camera *camera, int32_t xrMultipassId, MethodInfo *method)
		{
		  signed __int64 v4; // rcx
		  int32_t v5; // ebp
		  __int64 v6; // rbx
		  __int64 v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  struct HGCamera__Class *v12; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *s_Cameras; // r10
		  signed __int64 v14; // rtt
		  HGCamera *v15; // rax
		  __int64 *v16; // rdx
		  signed __int64 v17; // rcx
		  HGCamera *v18; // rbx
		  unsigned int InstanceID; // esi
		  __int64 (__fastcall *v20)(_QWORD); // rax
		  InsertionBehavior__Enum v21; // r9d
		  struct HGCamera__Class *v22; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v23; // rsi
		  signed __int64 v24; // rtt
		  struct MethodInfo *v25; // rbx
		  Object *v26; // rdi
		  ValueTuple_2_Object_Int32_ v27; // xmm6
		  Il2CppClass *klass; // rax
		  __int64 v29; // rax
		  ValueTuple_2_Object_Int32_ v30; // [rsp+30h] [rbp-48h] BYREF
		  ValueTuple_2_Object_Int32_ v31; // [rsp+40h] [rbp-38h] BYREF
		  HGCamera *v32; // [rsp+98h] [rbp+20h] BYREF
		
		  v32 = 0LL;
		  v4 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v5 = xrMultipassId;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(_QWORD **)(v4 + 184);
		  if ( !v6 )
		    sub_1800D8260(v4, *(_QWORD *)&xrMultipassId);
		  if ( *(int *)(v6 + 24) <= 23 )
		    goto LABEL_12;
		  if ( !*(_DWORD *)(v4 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = **(_QWORD **)(v4 + 184);
		  if ( !v7 )
		    sub_1800D8260(v4, *(_QWORD *)&xrMultipassId);
		  if ( *(_DWORD *)(v7 + 24) <= 0x17u )
		    sub_1800D2AB0(v4, *(_QWORD *)&xrMultipassId);
		  if ( *(_QWORD *)(v7 + 216) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(23, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(Patch, (Object *)camera, v5, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    v12 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v12 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    s_Cameras = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v12->static_fields->s_Cameras;
		    v31 = (ValueTuple_2_Object_Int32_)(unsigned __int64)camera;
		    if ( dword_18F35FD08 )
		    {
		      *(_QWORD *)&xrMultipassId = &qword_18F0BCBA0[(((unsigned __int64)&v31 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw((const void *)(*(_QWORD *)&xrMultipassId + 289520LL));
		      do
		      {
		        v4 = *(_QWORD *)(*(_QWORD *)&xrMultipassId + 289520LL) | (1LL << (((unsigned __int64)&v31 >> 12) & 0x3F));
		        v14 = *(_QWORD *)(*(_QWORD *)&xrMultipassId + 289520LL);
		      }
		      while ( v14 != _InterlockedCompareExchange64(
		                       (volatile signed __int64 *)(*(_QWORD *)&xrMultipassId + 289520LL),
		                       v4,
		                       v14) );
		    }
		    v31.Item2 = v5;
		    if ( !s_Cameras )
		      sub_1800D8250(v4, *(_QWORD *)&xrMultipassId);
		    v30 = v31;
		    if ( !System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
		            s_Cameras,
		            &v30,
		            (Object **)&v32,
		            MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
		    {
		      v15 = (HGCamera *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v18 = v15;
		      if ( !v15 )
		        goto LABEL_40;
		      HG::Rendering::Runtime::HGCamera::HGCamera(v15, camera, 0LL);
		      v32 = v18;
		      if ( !camera )
		        goto LABEL_40;
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
		      v20 = (__int64 (__fastcall *)(_QWORD))qword_18F3702E0;
		      if ( !qword_18F3702E0 )
		      {
		        v20 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                                "UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
		        if ( !v20 )
		        {
		          v29 = sub_1802EE1B8("UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
		          sub_18007E1B0(v29, 0LL);
		        }
		        qword_18F3702E0 = (__int64)v20;
		      }
		      v18->fields.cullingViewUniqueID = v20(InstanceID);
		      v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		      }
		      v23 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v22->static_fields->s_Cameras;
		      v31 = (ValueTuple_2_Object_Int32_)(unsigned __int64)camera;
		      if ( dword_18F35FD08 )
		      {
		        v16 = &qword_18F0BCBA0[(((unsigned __int64)&v31 >> 12) & 0x1FFFFF) >> 6];
		        _m_prefetchw(v16 + 36190);
		        do
		        {
		          v17 = v16[36190] | (1LL << (((unsigned __int64)&v31 >> 12) & 0x3F));
		          v24 = v16[36190];
		        }
		        while ( v24 != _InterlockedCompareExchange64(v16 + 36190, v17, v24) );
		      }
		      v31.Item2 = v5;
		      if ( !v23 )
		LABEL_40:
		        sub_1800D8250(v17, v16);
		      v25 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add;
		      v26 = (Object *)v32;
		      v27 = v31;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add->klass->rgctx_data[24].rgctxDataDummy
		            + 4) )
		        (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add->klass->rgctx_data[24].rgctxDataDummy)();
		      klass = v25->klass;
		      LOBYTE(v21) = 2;
		      v30 = v27;
		      System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryInsert(
		        v23,
		        &v30,
		        v26,
		        v21,
		        (MethodInfo *)klass->rgctx_data[24].rgctxDataDummy);
		    }
		    return v32;
		  }
		}
		
		public static HGCamera TryGet(Camera camera, int xrMultipassId = 0 /* Metadata: 0x023038B7 */) => default; // 0x00000001849760D0-0x0000000184976190
		// HGCamera TryGet(Camera, Int32)
		HGCamera *HG::Rendering::Runtime::HGCamera::TryGet(Camera *camera, int32_t xrMultipassId, MethodInfo *method)
		{
		  __int128 v4; // rdi
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v10; // r10
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  _BYTE v15[40]; // [rsp+20h] [rbp-28h] BYREF
		  HGCamera *v16; // [rsp+68h] [rbp+20h] BYREF
		
		  v4 = (unsigned __int64)camera;
		  v16 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2796, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2796, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(Patch, (Object *)v4, xrMultipassId, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    *(_OWORD *)v15 = v4;
		    ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		      (SingleFieldAccessor *)v15,
		      v5,
		      v6,
		      v7);
		    *(_DWORD *)&v15[8] = xrMultipassId;
		    if ( !v10 )
		      sub_1800D8260(v9, v8);
		    *(_OWORD *)&v15[16] = *(_OWORD *)v15;
		    if ( System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
		           v10,
		           (ValueTuple_2_Object_Int32_ *)&v15[16],
		           (Object **)&v16,
		           MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
		    {
		      return v16;
		    }
		    else
		    {
		      return 0LL;
		    }
		  }
		}
		
		public void Reset() {} // 0x0000000184B4ED20-0x0000000184B4ED70
		// Void Reset()
		void HG::Rendering::Runtime::HGCamera::Reset(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2797, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2797, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields._isFirstFrame_k__BackingField = 1;
		    this->fields.cameraFrameCount = 0;
		    this->fields.resetPostProcessingHistory = 1;
		    this->fields.prevTransformReset = 1;
		  }
		}
		
		public RTHandle GetPreviousFrameRT(int id) => default; // 0x0000000189B73000-0x0000000189B73070
		// RTHandle GetPreviousFrameRT(Int32)
		RTHandle *HG::Rendering::Runtime::HGCamera::GetPreviousFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2798, 0LL) )
		  {
		    m_HistoryRTSystem = this->fields.m_HistoryRTSystem;
		    if ( m_HistoryRTSystem )
		      return UnityEngine::Rendering::BufferedRTHandleSystem::GetFrameRT(m_HistoryRTSystem, id, 1, 0LL);
		LABEL_5:
		    sub_1800D8260(m_HistoryRTSystem, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2798, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1026(Patch, (Object *)this, id, 0LL);
		}
		
		public RTHandle GetCurrentFrameRT(int id) => default; // 0x0000000189B72E18-0x0000000189B72E88
		// RTHandle GetCurrentFrameRT(Int32)
		RTHandle *HG::Rendering::Runtime::HGCamera::GetCurrentFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2799, 0LL) )
		  {
		    m_HistoryRTSystem = this->fields.m_HistoryRTSystem;
		    if ( m_HistoryRTSystem )
		      return UnityEngine::Rendering::BufferedRTHandleSystem::GetFrameRT(m_HistoryRTSystem, id, 0, 0LL);
		LABEL_5:
		    sub_1800D8260(m_HistoryRTSystem, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2799, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1026(Patch, (Object *)this, id, 0LL);
		}
		
		public uint GetCameraFrameCount() => default; // 0x0000000183DF2FF0-0x0000000183DF3050
		// UInt32 GetCameraFrameCount()
		uint32_t HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(HGCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 966 )
		    return this->fields.cameraFrameCount;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3C6 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[20]._1.genericContainerHandle )
		    return this->fields.cameraFrameCount;
		  Patch = IFix::WrappersManagerImpl::GetPatch(966, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void RequestDisableFrameGenTemporarily(bool disable) {} // 0x000000018340BCE0-0x000000018340BD20
		// Void RequestDisableFrameGenTemporarily(Boolean)
		void HG::Rendering::Runtime::HGCamera::RequestDisableFrameGenTemporarily(
		        HGCamera *this,
		        bool disable,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2800, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2800, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, disable, 0LL);
		  }
		  else
		  {
		    this->fields.m_DisableFrameGenTemporarily = disable;
		  }
		}
		
		public bool ShouldDisableFrameGenTemporarily() => default; // 0x0000000183EC94E0-0x0000000183EC9540
		// Boolean ShouldDisableFrameGenTemporarily()
		bool HG::Rendering::Runtime::HGCamera::ShouldDisableFrameGenTemporarily(HGCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 948 )
		    return this->fields.m_DisableFrameGenTemporarily;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3B4 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[20]._0.generic_class )
		    return this->fields.m_DisableFrameGenTemporarily;
		  Patch = IFix::WrappersManagerImpl::GetPatch(948, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		[IDTag(0)]
		public static LayerMask RemoveWorldUILayer(LayerMask layerMask) => default; // 0x0000000189B736B0-0x0000000189B7371C
		// LayerMask RemoveWorldUILayer(LayerMask)
		LayerMask HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(LayerMask layerMask, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1170, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1170, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_443(Patch, layerMask, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    return (LayerMask)(layerMask.m_Mask & ~(1 << (TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->worldUILayerIndex & 0x1F)));
		  }
		}
		
		[IDTag(1)]
		public static uint RemoveWorldUILayer(uint layerMask) => default; // 0x0000000189B73644-0x0000000189B736B0
		// UInt32 RemoveWorldUILayer(UInt32)
		uint32_t HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(uint32_t layerMask, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2801, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2801, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, layerMask, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    return layerMask & ~(1 << (TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->worldUILayerIndex & 0x1F));
		  }
		}
		
		[IDTag(0)]
		public static LayerMask AddWorldUILayer(LayerMask layerMask) => default; // 0x0000000189B72008-0x0000000189B72074
		// LayerMask AddWorldUILayer(LayerMask)
		LayerMask HG::Rendering::Runtime::HGCamera::AddWorldUILayer(LayerMask layerMask, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2802, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2802, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_443(Patch, layerMask, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    return (LayerMask)(layerMask.m_Mask | (1 << (TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->worldUILayerIndex & 0x1F)));
		  }
		}
		
		[IDTag(1)]
		public static uint AddWorldUILayer(uint layerMask) => default; // 0x0000000189B72074-0x0000000189B720E0
		// UInt32 AddWorldUILayer(UInt32)
		uint32_t HG::Rendering::Runtime::HGCamera::AddWorldUILayer(uint32_t layerMask, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2803, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2803, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, layerMask, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    return layerMask | (1 << (TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->worldUILayerIndex & 0x1F));
		  }
		}
		
		private Mesh CreateParafinTriangleMesh(float zOffset) => default; // 0x00000001837DBD50-0x00000001837DBF40
		// Mesh CreateParafinTriangleMesh(Single)
		Mesh *HG::Rendering::Runtime::HGCamera::CreateParafinTriangleMesh(HGCamera *this, float zOffset, MethodInfo *method)
		{
		  Mesh *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Mesh *v7; // rbp
		  __int64 v8; // rax
		  Vector3__Array *v9; // rsi
		  __int64 v10; // rax
		  Vector2__Array *v11; // rdi
		  Array *v12; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2805, 0LL) )
		  {
		    v4 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		    v7 = v4;
		    if ( v4 )
		    {
		      UnityEngine::Mesh::Mesh(v4, 0LL);
		      v8 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		      v9 = (Vector3__Array *)v8;
		      if ( v8 )
		      {
		        if ( !*(_DWORD *)(v8 + 24) )
		          goto LABEL_15;
		        *(_QWORD *)(v8 + 32) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
		        *(float *)(v8 + 40) = zOffset;
		        if ( *(_DWORD *)(v8 + 24) <= 1u )
		          goto LABEL_15;
		        *(_QWORD *)(v8 + 44) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		        *(float *)(v8 + 52) = zOffset;
		        if ( *(_DWORD *)(v8 + 24) <= 2u )
		          goto LABEL_15;
		        *(_QWORD *)(v8 + 56) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0];
		        *(float *)(v8 + 64) = zOffset;
		        if ( *(_DWORD *)(v8 + 24) <= 3u )
		          goto LABEL_15;
		        *(_QWORD *)(v8 + 68) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0xBF800000).m128_u64[0];
		        *(float *)(v8 + 76) = zOffset;
		        v10 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		        v11 = (Vector2__Array *)v10;
		        if ( v10 )
		        {
		          if ( *(_DWORD *)(v10 + 24) )
		          {
		            *(_QWORD *)(v10 + 32) = 0LL;
		            if ( *(_DWORD *)(v10 + 24) > 1u )
		            {
		              *(_QWORD *)(v10 + 40) = 1065353216LL;
		              if ( *(_DWORD *)(v10 + 24) > 2u )
		              {
		                *(_DWORD *)(v10 + 48) = 0;
		                *(_DWORD *)(v10 + 52) = 1065353216;
		                if ( *(_DWORD *)(v10 + 24) > 3u )
		                {
		                  *(_DWORD *)(v10 + 56) = 1065353216;
		                  *(_DWORD *)(v10 + 60) = 1065353216;
		                  v12 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		                  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		                    v12,
		                    B2CF02C10F1F309AC8FB52A3CCE888191E73C7E1C5A0D699CA4CBBE2C76F2C0F_Field,
		                    0LL);
		                  UnityEngine::Mesh::set_vertices(v7, v9, 0LL);
		                  UnityEngine::Mesh::set_triangles(v7, (Int32__Array *)v12, 0LL);
		                  UnityEngine::Object::set_name((Object_1 *)v7, (String *)"ParafinTriangle", 0LL);
		                  UnityEngine::Mesh::set_uv(v7, v11, 0LL);
		                  UnityEngine::Mesh::RecalculateBounds(v7, MeshUpdateFlags__Enum_Default, 0LL);
		                  return v7;
		                }
		              }
		            }
		          }
		LABEL_15:
		          sub_1800D2AB0(v6, v5);
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2805, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1028(Patch, (Object *)this, zOffset, 0LL);
		}
		
		internal void SetParentCamera(HGCamera parentHdCam, bool useGpuFetchedExposure, float fetchedGpuExposure) {} // 0x0000000189B73874-0x0000000189B73918
		// Void SetParentCamera(HGCamera, Boolean, Single)
		void HG::Rendering::Runtime::HGCamera::SetParentCamera(
		        HGCamera *this,
		        HGCamera *parentHdCam,
		        bool useGpuFetchedExposure,
		        float fetchedGpuExposure,
		        MethodInfo *method)
		{
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  MethodInfo *P3; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2809, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2809, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1029(
		      Patch,
		      (Object *)this,
		      (Object *)parentHdCam,
		      useGpuFetchedExposure,
		      fetchedGpuExposure,
		      0LL);
		  }
		  else
		  {
		    if ( parentHdCam )
		      this->fields.m_parentCamera = parentHdCam->fields.camera;
		    else
		      this->fields.m_parentCamera = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_parentCamera, v8, v9, v10, P3);
		  }
		}
		
		public bool IsUICamera() => default; // 0x0000000183104560-0x0000000183104670
		// Boolean IsUICamera()
		bool HG::Rendering::Runtime::HGCamera::IsUICamera(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  HGCamera__Class *static_fields; // rdx
		  int32_t m_Y; // ecx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  int32_t hgRenderPath; // eax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCamera__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_20;
		  if ( (int)static_fields->_0.image->typeCount <= 794 )
		    goto LABEL_46;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  image = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_20;
		  if ( image->typeCount <= 0x31A )
		    goto LABEL_43;
		  if ( !image[88].nameToClassHashTable )
		  {
		LABEL_46:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_20;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 703 )
		      goto LABEL_9;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_20;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x2BF )
		      goto LABEL_43;
		    if ( static_fields[15]._0.name )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		      if ( !Patch )
		        goto LABEL_20;
		      m_Y = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)v3, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_9:
		      this = (HGCamera *)v3->fields.m_AdditionalCameraData;
		      if ( !this )
		        goto LABEL_20;
		      m_Y = this->fields.m_finalRTSize.m_Y;
		    }
		    if ( m_Y == 1 )
		      return 1;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_20;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 703 )
		      goto LABEL_16;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		      goto LABEL_20;
		    if ( LODWORD(klass->_0.namespaze) > 0x2BF )
		    {
		      if ( klass[15]._0.name )
		      {
		        v13 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		        if ( v13 )
		        {
		          hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                           (ILFixDynamicMethodWrapper_31 *)v13,
		                           (Object *)v3,
		                           0LL);
		          return hgRenderPath == 2;
		        }
		LABEL_20:
		        sub_1800D8260(this, static_fields);
		      }
		LABEL_16:
		      m_AdditionalCameraData = v3->fields.m_AdditionalCameraData;
		      if ( m_AdditionalCameraData )
		      {
		        hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		        return hgRenderPath == 2;
		      }
		      goto LABEL_20;
		    }
		LABEL_43:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v10 = IFix::WrappersManagerImpl::GetPatch(794, 0LL);
		  if ( !v10 )
		    goto LABEL_20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v10, (Object *)v3, 0LL);
		}
		
		public HGCamera GetLightWeightCamera() => default; // 0x0000000183451540-0x0000000183451A90
		// HGCamera GetLightWeightCamera()
		HGCamera *HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Camera *camera; // rbx
		  __int64 (__fastcall *v11)(Camera *, MethodInfo *); // rax
		  __int64 v12; // rax
		  struct Object_1__Class *v13; // rcx
		  Camera *v14; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v15; // rcx
		  __int64 *v16; // rdx
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  HGCamera *v20; // r9
		  signed __int64 static_fields; // rcx
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v22; // r10
		  signed __int64 v23; // rtt
		  HGCamera *v24; // rax
		  __int64 *v25; // rdx
		  signed __int64 v26; // rcx
		  HGCamera *v27; // rdi
		  unsigned int InstanceID; // esi
		  __int64 (__fastcall *v29)(_QWORD); // rax
		  InsertionBehavior__Enum v30; // r9d
		  struct HGCamera__Class *v31; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *s_Cameras; // rdi
		  signed __int64 v33; // rtt
		  struct MethodInfo *v34; // rbx
		  Object *v35; // rsi
		  ValueTuple_2_Object_Int32_ v36; // xmm6
		  Il2CppClass *klass; // rax
		  bool v38; // zf
		  __int64 *v39; // rdx
		  signed __int64 v40; // rtt
		  __int64 v41; // rax
		  __int64 v42; // rax
		  ValueTuple_2_Object_Int32_ v43; // [rsp+30h] [rbp-58h] BYREF
		  ValueTuple_2_Object_Int32_ v44; // [rsp+40h] [rbp-48h] BYREF
		  Object *v45; // [rsp+A0h] [rbp+18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size > 729 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = v3->static_fields->wrapperArray;
		    if ( !v5 )
		      sub_1800D8260(v3, method);
		    if ( v5->max_length.size <= 0x2D9u )
		      sub_1800D2AB0(v3, method);
		    if ( v5[20].vector[9] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(729, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_290(Patch, (Object *)this, 0LL);
		    }
		  }
		  camera = this->fields.camera;
		  if ( !camera )
		    sub_1800D8260(v3, method);
		  v11 = (__int64 (__fastcall *)(Camera *, MethodInfo *))qword_18F36F1B8;
		  if ( !qword_18F36F1B8 )
		  {
		    v11 = (__int64 (__fastcall *)(Camera *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Camera::GetLightWeightCamera()");
		    if ( !v11 )
		    {
		      v41 = sub_1802EE1B8("UnityEngine.Camera::GetLightWeightCamera()");
		      sub_18007E1B0(v41, 0LL);
		    }
		    qword_18F36F1B8 = (__int64)v11;
		  }
		  v12 = v11(camera, method);
		  v13 = TypeInfo::UnityEngine::Object;
		  v14 = (Camera *)v12;
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
		  if ( !v14 )
		    return 0LL;
		  if ( !v13->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v13);
		  if ( !v14->fields._._._.m_CachedPtr )
		    return 0LL;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v45 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v16 = (__int64 *)v15->static_fields->wrapperArray;
		  if ( !v16 )
		    goto LABEL_74;
		  if ( *((int *)v16 + 6) <= 23 )
		  {
		LABEL_36:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    static_fields = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields;
		    v22 = *(Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ **)(static_fields + 16);
		    v43 = (ValueTuple_2_Object_Int32_)(unsigned __int64)v14;
		    if ( dword_18F35FD08 )
		    {
		      v16 = &qword_18F0BCBA0[(((unsigned __int64)&v43 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v16 + 36190);
		      do
		      {
		        static_fields = v16[36190] | (1LL << (((unsigned __int64)&v43 >> 12) & 0x3F));
		        v23 = v16[36190];
		      }
		      while ( v23 != _InterlockedCompareExchange64(v16 + 36190, static_fields, v23) );
		    }
		    v43.Item2 = 0;
		    if ( !v22 )
		      sub_1800D8250(static_fields, v16);
		    v44 = v43;
		    if ( !System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
		            v22,
		            &v44,
		            &v45,
		            MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
		    {
		      v24 = (HGCamera *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v27 = v24;
		      if ( !v24 )
		        goto LABEL_71;
		      HG::Rendering::Runtime::HGCamera::HGCamera(v24, v14, 0LL);
		      v45 = (Object *)v27;
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v14, 0LL);
		      v29 = (__int64 (__fastcall *)(_QWORD))qword_18F3702E0;
		      if ( !qword_18F3702E0 )
		      {
		        v29 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                                "UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
		        if ( !v29 )
		        {
		          v42 = sub_1802EE1B8("UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
		          sub_18007E1B0(v42, 0LL);
		        }
		        qword_18F3702E0 = (__int64)v29;
		      }
		      v27->fields.cullingViewUniqueID = v29(InstanceID);
		      v31 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        v31 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		      }
		      s_Cameras = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v31->static_fields->s_Cameras;
		      v43 = (ValueTuple_2_Object_Int32_)(unsigned __int64)v14;
		      if ( dword_18F35FD08 )
		      {
		        v25 = &qword_18F0BCBA0[(((unsigned __int64)&v43 >> 12) & 0x1FFFFF) >> 6];
		        _m_prefetchw(v25 + 36190);
		        do
		        {
		          v26 = v25[36190] | (1LL << (((unsigned __int64)&v43 >> 12) & 0x3F));
		          v33 = v25[36190];
		        }
		        while ( v33 != _InterlockedCompareExchange64(v25 + 36190, v26, v33) );
		      }
		      v43.Item2 = 0;
		      if ( !s_Cameras )
		LABEL_71:
		        sub_1800D8250(v26, v25);
		      v34 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add;
		      v35 = v45;
		      v36 = v43;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add->klass->rgctx_data[24].rgctxDataDummy
		            + 4) )
		        (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add->klass->rgctx_data[24].rgctxDataDummy)();
		      klass = v34->klass;
		      LOBYTE(v30) = 2;
		      v44 = v36;
		      System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryInsert(
		        s_Cameras,
		        &v44,
		        v35,
		        v30,
		        (MethodInfo *)klass->rgctx_data[24].rgctxDataDummy);
		    }
		    v20 = (HGCamera *)v45;
		    goto LABEL_57;
		  }
		  if ( !v15->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v15);
		    v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v15 = (struct ILFixDynamicMethodWrapper_2__Class *)v15->static_fields->wrapperArray;
		  if ( !v15 )
		LABEL_74:
		    sub_1800D8260(v15, v16);
		  if ( LODWORD(v15->_0.namespaze) <= 0x17 )
		    sub_1800D2AB0(v15, v16);
		  if ( !*(_QWORD *)&v15->_1.initializationExceptionGCHandle )
		    goto LABEL_36;
		  v17 = IFix::WrappersManagerImpl::GetPatch(23, 0LL);
		  if ( !v17 )
		    goto LABEL_74;
		  v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(v17, (Object *)v14, 0, 0LL);
		LABEL_57:
		  if ( !v20 )
		    sub_1800D8250(v19, v18);
		  v38 = dword_18F35FD08 == 0;
		  v20->fields.m_lwCameraAttached = this;
		  if ( !v38 )
		  {
		    v39 = &qword_18F0BCBA0[(((unsigned __int64)&v20->fields.m_lwCameraAttached >> 12) & 0x1FFFFF) >> 6];
		    _m_prefetchw(v39 + 36190);
		    do
		      v40 = v39[36190];
		    while ( v40 != _InterlockedCompareExchange64(
		                     v39 + 36190,
		                     v40 | (1LL << (((unsigned __int64)&v20->fields.m_lwCameraAttached >> 12) & 0x3F)),
		                     v40) );
		  }
		  return v20;
		}
		
		public bool IsLightWeightCamera() => default; // 0x0000000189B731F8-0x0000000189B7324C
		// Boolean IsLightWeightCamera()
		bool HG::Rendering::Runtime::HGCamera::IsLightWeightCamera(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2815, 0LL) )
		    return this->fields.m_lwCameraAttached != 0LL;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2815, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetEnableUpdatingSceneFrostedGlass(bool enabled) {} // 0x0000000184A28180-0x0000000184A281C0
		// Void SetEnableUpdatingSceneFrostedGlass(Boolean)
		void HG::Rendering::Runtime::HGCamera::SetEnableUpdatingSceneFrostedGlass(
		        HGCamera *this,
		        bool enabled,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2817, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2817, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, enabled, 0LL);
		  }
		  else
		  {
		    this->fields.enableUpdatingSceneFrostedGlass = enabled;
		  }
		}
		
		public void AddSortingOrder(int sortingOrder) {} // 0x0000000183F02370-0x0000000183F02400
		// Void AddSortingOrder(Int32)
		void HG::Rendering::Runtime::HGCamera::AddSortingOrder(HGCamera *this, int32_t sortingOrder, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2818, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2818, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)this,
		        sortingOrder,
		        0LL);
		      return;
		    }
		    goto LABEL_3;
		  }
		  m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		  if ( !m_sortingOrdersToBlur )
		    goto LABEL_3;
		  if ( !System::Collections::Generic::List<int>::Contains(
		          m_sortingOrdersToBlur,
		          sortingOrder,
		          MethodInfo::System::Collections::Generic::List<int>::Contains) )
		  {
		    m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		    if ( m_sortingOrdersToBlur )
		    {
		      sub_183081250(
		        m_sortingOrdersToBlur,
		        (unsigned int)sortingOrder,
		        MethodInfo::System::Collections::Generic::List<int>::Add);
		      m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		      if ( m_sortingOrdersToBlur )
		      {
		        System::Collections::Generic::List<int>::Sort(
		          m_sortingOrdersToBlur,
		          MethodInfo::System::Collections::Generic::List<int>::Sort);
		        return;
		      }
		    }
		LABEL_3:
		    sub_1800D8260(m_sortingOrdersToBlur, v5);
		  }
		}
		
		public void RemoveSortingOrder(int sortingOrder) {} // 0x0000000183F03F80-0x0000000183F03FF0
		// Void RemoveSortingOrder(Int32)
		void HG::Rendering::Runtime::HGCamera::RemoveSortingOrder(HGCamera *this, int32_t sortingOrder, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2819, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2819, 0LL);
		    if ( !Patch )
		LABEL_5:
		      sub_1800D8260(m_sortingOrdersToBlur, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      sortingOrder,
		      0LL);
		  }
		  else
		  {
		    m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		    if ( !m_sortingOrdersToBlur )
		      goto LABEL_5;
		    if ( System::Collections::Generic::List<int>::Contains(
		           m_sortingOrdersToBlur,
		           sortingOrder,
		           MethodInfo::System::Collections::Generic::List<int>::Contains) )
		    {
		      m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		      if ( !m_sortingOrdersToBlur )
		        goto LABEL_5;
		      System::Collections::Generic::List<int>::Remove(
		        m_sortingOrdersToBlur,
		        sortingOrder,
		        MethodInfo::System::Collections::Generic::List<int>::Remove);
		    }
		  }
		}
		
		public void SetRenderingScale(float scale) {} // 0x0000000189B73918-0x0000000189B739D8
		// Void SetRenderingScale(Single)
		void HG::Rendering::Runtime::HGCamera::SetRenderingScale(HGCamera *this, float scale, MethodInfo *method)
		{
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v5; // rdx
		  SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  HGRenderPipeline *v8; // rax
		  HGSettingParameters *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2821, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( currentPipeline )
		    {
		      settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		      if ( settingParameters_k__BackingField )
		      {
		        renderingScale_k__BackingField = settingParameters_k__BackingField->fields._renderingScale_k__BackingField;
		        if ( renderingScale_k__BackingField )
		        {
		          HG::Rendering::Runtime::SettingParameter<float>::Override(
		            renderingScale_k__BackingField,
		            scale,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
		          v8 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		          if ( v8 )
		          {
		            v9 = v8->fields._settingParameters_k__BackingField;
		            if ( v9 )
		            {
		              renderingScale_k__BackingField = v9->fields._renderingScale_k__BackingField;
		              if ( renderingScale_k__BackingField )
		              {
		                HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
		                  (HGRenderPipelineSettingHub_SettingParameterBase *)renderingScale_k__BackingField,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(renderingScale_k__BackingField, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2821, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, scale, 0LL);
		}
		
		public static void SetDLSSSQuality(HGCamera hgCamera, DLSSQuality quality) {} // 0x0000000184484130-0x0000000184484230
		// Void SetDLSSSQuality(HGCamera, DLSSQuality)
		void HG::Rendering::Runtime::HGCamera::SetDLSSSQuality(
		        HGCamera *hgCamera,
		        DLSSQuality__Enum quality,
		        MethodInfo *method)
		{
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v6; // rdx
		  SettingParameter_1_System_Int32Enum_ *dlssQuality_k__BackingField; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  HGRenderPipeline *v9; // rax
		  HGSettingParameters *v10; // rax
		  HGRenderPipeline *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector2Int nonScaledViewport; // [rsp+48h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2822, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2822, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)hgCamera,
		        quality,
		        0LL);
		      return;
		    }
		    goto LABEL_5;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !currentPipeline )
		    goto LABEL_5;
		  settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_5;
		  dlssQuality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._dlssQuality_k__BackingField;
		  if ( !dlssQuality_k__BackingField )
		    goto LABEL_5;
		  HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::Override(
		    dlssQuality_k__BackingField,
		    (Int32Enum__Enum)quality,
		    MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::Override);
		  v9 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !v9 )
		    goto LABEL_5;
		  v10 = v9->fields._settingParameters_k__BackingField;
		  if ( !v10 )
		    goto LABEL_5;
		  dlssQuality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)v10->fields._dlssQuality_k__BackingField;
		  if ( !dlssQuality_k__BackingField )
		    goto LABEL_5;
		  HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
		    (HGRenderPipelineSettingHub_SettingParameterBase *)dlssQuality_k__BackingField,
		    0LL);
		  if ( !hgCamera )
		    return;
		  nonScaledViewport = *(Vector2Int *)&hgCamera->fields._actualWidth_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  v11 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !v11 )
		LABEL_5:
		    sub_1800D8260(dlssQuality_k__BackingField, v6);
		  HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
		    hgCamera,
		    v11->fields._settingParameters_k__BackingField,
		    nonScaledViewport,
		    0LL);
		}
		
		public static void SetFSR3Quality(HGCamera hgCamera, FSR3Quality quality) {} // 0x0000000184484230-0x0000000184484330
		// Void SetFSR3Quality(HGCamera, FSR3Quality)
		void HG::Rendering::Runtime::HGCamera::SetFSR3Quality(
		        HGCamera *hgCamera,
		        FSR3Quality__Enum quality,
		        MethodInfo *method)
		{
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v6; // rdx
		  SettingParameter_1_System_Int32Enum_ *fsr3Quality_k__BackingField; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  HGRenderPipeline *v9; // rax
		  HGSettingParameters *v10; // rax
		  HGRenderPipeline *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector2Int nonScaledViewport; // [rsp+48h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2823, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2823, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)hgCamera,
		        quality,
		        0LL);
		      return;
		    }
		    goto LABEL_5;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !currentPipeline )
		    goto LABEL_5;
		  settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_5;
		  fsr3Quality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._fsr3Quality_k__BackingField;
		  if ( !fsr3Quality_k__BackingField )
		    goto LABEL_5;
		  HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::Override(
		    fsr3Quality_k__BackingField,
		    (Int32Enum__Enum)quality,
		    MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::Override);
		  v9 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !v9 )
		    goto LABEL_5;
		  v10 = v9->fields._settingParameters_k__BackingField;
		  if ( !v10 )
		    goto LABEL_5;
		  fsr3Quality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)v10->fields._fsr3Quality_k__BackingField;
		  if ( !fsr3Quality_k__BackingField )
		    goto LABEL_5;
		  HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
		    (HGRenderPipelineSettingHub_SettingParameterBase *)fsr3Quality_k__BackingField,
		    0LL);
		  if ( !hgCamera )
		    return;
		  nonScaledViewport = *(Vector2Int *)&hgCamera->fields._actualWidth_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  v11 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !v11 )
		LABEL_5:
		    sub_1800D8260(fsr3Quality_k__BackingField, v6);
		  HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
		    hgCamera,
		    v11->fields._settingParameters_k__BackingField,
		    nonScaledViewport,
		    0LL);
		}
		
		public void ToggleTAAU() {} // 0x0000000189B73CC0-0x0000000189B73D3C
		// Void ToggleTAAU()
		void HG::Rendering::Runtime::HGCamera::ToggleTAAU(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2824, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasing
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasing
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2824, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleMetalFXSpatial() {} // 0x0000000189B73AD0-0x0000000189B73B4C
		// Void ToggleMetalFXSpatial()
		void HG::Rendering::Runtime::HGCamera::ToggleMetalFXSpatial(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2825, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXSpatial
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXSpatial
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2825, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleMetalFXTemporal() {} // 0x0000000189B73BC8-0x0000000189B73C44
		// Void ToggleMetalFXTemporal()
		void HG::Rendering::Runtime::HGCamera::ToggleMetalFXTemporal(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2826, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporal
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporal
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2826, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleTAAUWithMetalFXSpatial() {} // 0x0000000189B73C44-0x0000000189B73CC0
		// Void ToggleTAAUWithMetalFXSpatial()
		void HG::Rendering::Runtime::HGCamera::ToggleTAAUWithMetalFXSpatial(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2827, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasingWithMetalFXSpatial
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasingWithMetalFXSpatial
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2827, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleMetalFXTemporalWithMetalFXSpatial() {} // 0x0000000189B73B4C-0x0000000189B73BC8
		// Void ToggleMetalFXTemporalWithMetalFXSpatial()
		void HG::Rendering::Runtime::HGCamera::ToggleMetalFXTemporalWithMetalFXSpatial(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2828, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporalWithMetalFXSpatial
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporalWithMetalFXSpatial
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2828, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleFSR3() {} // 0x0000000189B73A54-0x0000000189B73AD0
		// Void ToggleFSR3()
		void HG::Rendering::Runtime::HGCamera::ToggleFSR3(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2829, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_FSR3
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_FSR3
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2829, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void ToggleDLSS() {} // 0x0000000189B739D8-0x0000000189B73A54
		// Void ToggleDLSS()
		void HG::Rendering::Runtime::HGCamera::ToggleDLSS(HGCamera *this, MethodInfo *method)
		{
		  HGAdditionalCameraData_AntialiasingMode__Enum antialiasing; // eax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2830, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) == HGRenderPath__Enum_UI )
		      return;
		    antialiasing = HG::Rendering::Runtime::HGCamera::get_antialiasing(this, 0LL);
		    if ( this )
		    {
		      HG::Rendering::Runtime::HGCamera::set_antialiasing(
		        this,
		        antialiasing != HGAdditionalCameraData_AntialiasingMode__Enum_DLSS
		      ? HGAdditionalCameraData_AntialiasingMode__Enum_DLSS
		      : HGAdditionalCameraData_AntialiasingMode__Enum_None,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2830, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void RequestDynamicResolution(bool cameraRequestedDynamicRes, DynamicResolutionHandler dynResHandler) {} // 0x0000000189B7371C-0x0000000189B737BC
		// Void RequestDynamicResolution(Boolean, DynamicResolutionHandler)
		void HG::Rendering::Runtime::HGCamera::RequestDynamicResolution(
		        HGCamera *this,
		        bool cameraRequestedDynamicRes,
		        DynamicResolutionHandler *dynResHandler,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCamera_DynamicResolutionRequest v10; // [rsp+30h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2833, 0LL) )
		  {
		    if ( dynResHandler )
		    {
		      v10.enabled = UnityEngine::Rendering::DynamicResolutionHandler::DynamicResolutionEnabled(dynResHandler, 0LL);
		      v10.cameraRequested = cameraRequestedDynamicRes;
		      v10.hardwareEnabled = UnityEngine::Rendering::DynamicResolutionHandler::HardwareDynamicResIsEnabled(
		                              dynResHandler,
		                              0LL);
		      v10.filter = dynResHandler->fields._filter_k__BackingField;
		      this->fields._DynResRequest_k__BackingField = v10;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2833, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    cameraRequestedDynamicRes,
		    (Object *)dynResHandler,
		    0LL);
		}
		
		public uint GetCullingViewUniqueID() => default; // 0x0000000189B72DC8-0x0000000189B72E18
		// UInt32 GetCullingViewUniqueID()
		uint32_t HG::Rendering::Runtime::HGCamera::GetCullingViewUniqueID(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2835, 0LL) )
		    return this->fields.cullingViewUniqueID;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2835, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void ForceOverrideCsmDistance(float csmDistance) {} // 0x0000000189B72D60-0x0000000189B72DC8
		// Void ForceOverrideCsmDistance(Single)
		void HG::Rendering::Runtime::HGCamera::ForceOverrideCsmDistance(HGCamera *this, float csmDistance, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2836, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2836, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      csmDistance,
		      0LL);
		  }
		  else
		  {
		    this->fields.overrideCsmMaxDistanceValue = csmDistance;
		    this->fields.overrideCsmShadowDistance = 1;
		  }
		}
		
		public void ResetOverrideCsmDistance() {} // 0x0000000189B737BC-0x0000000189B73818
		// Void ResetOverrideCsmDistance()
		void HG::Rendering::Runtime::HGCamera::ResetOverrideCsmDistance(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2837, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2837, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.overrideCsmShadowDistance = 0;
		    this->fields.overrideCsmMaxDistanceValue = 80.0;
		  }
		}
		
		internal bool RequiresCameraJitter() => default; // 0x000000018344E240-0x000000018344E530
		// Boolean RequiresCameraJitter()
		bool HG::Rendering::Runtime::HGCamera::RequiresCameraJitter(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGCamera *v3; // rbx
		  HGCamera__Class *static_fields; // rdx
		  int32_t m_antialiasingMode; // ecx
		  bool v6; // cl
		  int32_t v8; // eax
		  int32_t v9; // eax
		  int32_t v10; // eax
		  const Il2CppImage *image; // r8
		  int32_t v12; // ecx
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		  const Il2CppImage *v14; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  const Il2CppImage *v17; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  bool v19; // al
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		  ILFixDynamicMethodWrapper_2 *v23; // rax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_53;
		  if ( (int)static_fields->_0.image->typeCount > 735 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    image = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_53;
		    if ( image->typeCount <= 0x2DF )
		      goto LABEL_129;
		    if ( image[82].nameNoExt )
		    {
		      v12 = 735;
		      goto LABEL_60;
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 736 )
		    goto LABEL_132;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (HGCamera__Class *)v2->static_fields;
		  v14 = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_53;
		  if ( v14->typeCount <= 0x2E0 )
		    goto LABEL_129;
		  if ( v14[82].assembly )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
		    if ( !Patch )
		      goto LABEL_53;
		    v6 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)v3, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_132:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_53;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 732 )
		      goto LABEL_13;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCamera *)v2->static_fields;
		    static_fields = this->klass;
		    if ( !this->klass )
		      goto LABEL_53;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x2DC )
		      goto LABEL_129;
		    if ( *(_QWORD *)&static_fields[15]._1.instance_size )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v16 )
		        goto LABEL_53;
		      LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                     (ILFixDynamicMethodWrapper_31 *)v16,
		                                     (Object *)v3,
		                                     0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_13:
		      m_antialiasingMode = v3->fields.m_antialiasingMode;
		    }
		    v6 = (m_antialiasingMode & 2) != 0;
		  }
		  if ( v6 )
		    return 1;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCamera *)v2->static_fields;
		  static_fields = this->klass;
		  if ( !this->klass )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) > 737 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (HGCamera__Class *)v2->static_fields;
		    v17 = static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_53;
		    if ( v17->typeCount <= 0x2E1 )
		      goto LABEL_129;
		    if ( *(_QWORD *)&v17[82].typeCount )
		    {
		      v18 = IFix::WrappersManagerImpl::GetPatch(737, 0LL);
		      if ( !v18 )
		        goto LABEL_53;
		      v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v18, (Object *)v3, 0LL);
		      goto LABEL_84;
		    }
		  }
		  if ( UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL) )
		  {
		    v19 = (HG::Rendering::Runtime::HGCamera::get_antialiasing(v3, 0LL) & 8) != 0;
		LABEL_84:
		    if ( v19 )
		      return 1;
		  }
		  this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 738 )
		    goto LABEL_133;
		  if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x2E2 )
		    goto LABEL_129;
		  if ( *(_QWORD *)&static_fields[15]._1.interfaces_count )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(738, 0LL);
		    if ( !v20 )
		      goto LABEL_53;
		    if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v20, (Object *)v3, 0LL) )
		      return 1;
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_133:
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !static_fields )
		      goto LABEL_53;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 732 )
		      goto LABEL_30;
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !static_fields )
		      goto LABEL_53;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x2DC )
		      goto LABEL_129;
		    if ( *(_QWORD *)&static_fields[15]._1.instance_size )
		    {
		      v21 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v21 )
		        goto LABEL_53;
		      LOBYTE(v8) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v21, (Object *)v3, 0LL);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_30:
		      v8 = v3->fields.m_antialiasingMode;
		    }
		    if ( (v8 & 0x10) != 0 )
		      return 1;
		  }
		  if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 739 )
		    goto LABEL_134;
		  if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x2E3 )
		    goto LABEL_129;
		  if ( *(_QWORD *)&static_fields[15]._1.naturalAligment )
		  {
		    v22 = IFix::WrappersManagerImpl::GetPatch(739, 0LL);
		    if ( !v22 )
		      goto LABEL_53;
		    if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v22, (Object *)v3, 0LL) )
		      return 1;
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_134:
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !static_fields )
		      goto LABEL_53;
		    if ( SLODWORD(static_fields->_0.namespaze) <= 732 )
		      goto LABEL_40;
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !static_fields )
		      goto LABEL_53;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x2DC )
		      goto LABEL_129;
		    if ( *(_QWORD *)&static_fields[15]._1.instance_size )
		    {
		      v23 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v23 )
		        goto LABEL_53;
		      LOBYTE(v9) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v23, (Object *)v3, 0LL);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_40:
		      v9 = v3->fields.m_antialiasingMode;
		    }
		    if ( (v9 & 0x20) != 0 )
		      return 1;
		  }
		  if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) > 740 )
		  {
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !static_fields )
		      goto LABEL_53;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x2E4 )
		      goto LABEL_129;
		    if ( static_fields[15].vtable.Equals.methodPtr )
		    {
		      v12 = 740;
		LABEL_60:
		      v13 = IFix::WrappersManagerImpl::GetPatch(v12, 0LL);
		      if ( v13 )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v13, (Object *)v3, 0LL);
		      goto LABEL_53;
		    }
		  }
		  if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(HGCamera__Class ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		  if ( !static_fields )
		    goto LABEL_53;
		  if ( SLODWORD(static_fields->_0.namespaze) > 732 )
		  {
		    if ( !LODWORD(this->fields.mainViewConstants.invViewMatrix.m22) )
		    {
		      il2cpp_runtime_class_init_1(this);
		      this = (HGCamera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = **(HGCamera ***)&this->fields.mainViewConstants.invViewMatrix.m00;
		    if ( !this )
		      goto LABEL_53;
		    if ( this->fields._taauRTSize_k__BackingField.m_X > 0x2DCu )
		    {
		      if ( !*(_QWORD *)&this[2].fields.mainViewConstants.projMatrix.m22 )
		        goto LABEL_50;
		      v24 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( v24 )
		      {
		        LOBYTE(v10) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                        (ILFixDynamicMethodWrapper_31 *)v24,
		                        (Object *)v3,
		                        0LL);
		        return (v10 & 0x40) != 0;
		      }
		LABEL_53:
		      sub_1800D8260(this, static_fields);
		    }
		LABEL_129:
		    sub_1800D2AB0(this, static_fields);
		  }
		LABEL_50:
		  v10 = v3->fields.m_antialiasingMode;
		  return (v10 & 0x40) != 0;
		}
		
		private void InitializeVolumeComponentsData() {} // 0x0000000183FCF030-0x0000000183FCF5F0
		// Void InitializeVolumeComponentsData()
		void HG::Rendering::Runtime::HGCamera::InitializeVolumeComponentsData(HGCamera *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  char *volumeStack_k__BackingField; // rcx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rdi
		  Object *v6; // rax
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  HGCamera_VolumeComponentsData *v9; // rdi
		  Object *v10; // rax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HGCamera_VolumeComponentsData *v13; // rdi
		  Object *v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  HGCamera_VolumeComponentsData *v17; // rdi
		  Object *v18; // rax
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  HGCamera_VolumeComponentsData *v21; // rdi
		  Object *v22; // rax
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  SingleFieldAccessor *v25; // rdi
		  Object *v26; // rax
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  HGCamera_VolumeComponentsData *v29; // rdi
		  Object *v30; // rax
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  HGCamera_VolumeComponentsData *v33; // rdi
		  Object *v34; // rax
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  HGCamera_VolumeComponentsData *v37; // rdi
		  Object *v38; // rax
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  HGCamera_VolumeComponentsData *v41; // rdi
		  Object *v42; // rax
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  PropertyInfo_1 *v45; // r8
		  Int32__Array **v46; // r9
		  struct Object_1__Class *v47; // rcx
		  Camera *camera; // rdi
		  HGCamera_VolumeComponentsData *v49; // rdi
		  Object *v50; // rax
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **v52; // r9
		  HGCamera_VolumeComponentsData *v53; // rdi
		  Object *v54; // rax
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  SingleFieldAccessor *v57; // rdi
		  Object *v58; // rax
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  HGCamera_VolumeComponentsData *v61; // rdi
		  Object *v62; // rax
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  HGCamera_VolumeComponentsData *v65; // rdi
		  Object *v66; // rax
		  PropertyInfo_1 *v67; // r8
		  Int32__Array **v68; // r9
		  HGCamera_VolumeComponentsData *v69; // rdi
		  Object *v70; // rax
		  PropertyInfo_1 *v71; // r8
		  Int32__Array **v72; // r9
		  HGCamera_VolumeComponentsData *v73; // rdi
		  Object *v74; // rax
		  PropertyInfo_1 *v75; // r8
		  Int32__Array **v76; // r9
		  HGCamera_VolumeComponentsData *v77; // rdi
		  Object *v78; // rax
		  PropertyInfo_1 *v79; // r8
		  Int32__Array **v80; // r9
		  SingleFieldAccessor *v81; // rdi
		  Object *v82; // rax
		  PropertyInfo_1 *v83; // r8
		  Int32__Array **v84; // r9
		  HGCamera_VolumeComponentsData *v85; // rdi
		  Object *v86; // rax
		  PropertyInfo_1 *v87; // r8
		  Int32__Array **v88; // r9
		  HGCamera_VolumeComponentsData *v89; // rdi
		  Object *v90; // rax
		  PropertyInfo_1 *v91; // r8
		  Int32__Array **v92; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
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
		  MethodInfo *v113; // [rsp+20h] [rbp-8h]
		  MethodInfo *v114; // [rsp+20h] [rbp-8h]
		  MethodInfo *v115; // [rsp+20h] [rbp-8h]
		  Object *component; // [rsp+40h] [rbp+18h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2838, 0LL) )
		  {
		    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		    m_volumeComponentsData = this->fields.m_volumeComponentsData;
		    if ( volumeStack_k__BackingField )
		    {
		      v6 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		             (VolumeStack *)volumeStack_k__BackingField,
		             MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::Bloom>);
		      if ( m_volumeComponentsData )
		      {
		        m_volumeComponentsData->fields.m_bloom = (Bloom *)v6;
		        sub_18002D1B0((SingleFieldAccessor *)&m_volumeComponentsData->fields, v3, v7, v8, v94);
		        volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		        v9 = this->fields.m_volumeComponentsData;
		        if ( volumeStack_k__BackingField )
		        {
		          v10 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                  (VolumeStack *)volumeStack_k__BackingField,
		                  MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::Vignette>);
		          if ( v9 )
		          {
		            v9->fields.m_vignette = (Vignette *)v10;
		            sub_18002D1B0((SingleFieldAccessor *)&v9->fields.m_vignette, v3, v11, v12, v95);
		            volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		            v13 = this->fields.m_volumeComponentsData;
		            if ( volumeStack_k__BackingField )
		            {
		              v14 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                      (VolumeStack *)volumeStack_k__BackingField,
		                      MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGVignette>);
		              if ( v13 )
		              {
		                v13->fields.m_hgVignette = (HGVignette *)v14;
		                sub_18002D1B0((SingleFieldAccessor *)&v13->fields.m_hgVignette, v3, v15, v16, v96);
		                volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                v17 = this->fields.m_volumeComponentsData;
		                if ( volumeStack_k__BackingField )
		                {
		                  v18 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                          (VolumeStack *)volumeStack_k__BackingField,
		                          MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGDirtyLens>);
		                  if ( v17 )
		                  {
		                    v17->fields.m_hgDirtyLens = (HGDirtyLens *)v18;
		                    sub_18002D1B0((SingleFieldAccessor *)&v17->fields.m_hgDirtyLens, v3, v19, v20, v97);
		                    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                    v21 = this->fields.m_volumeComponentsData;
		                    if ( volumeStack_k__BackingField )
		                    {
		                      v22 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                              (VolumeStack *)volumeStack_k__BackingField,
		                              MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGSharpen>);
		                      if ( v21 )
		                      {
		                        v21->fields.m_sharpen = (HGSharpen *)v22;
		                        sub_18002D1B0((SingleFieldAccessor *)&v21->fields.m_sharpen, v3, v23, v24, v98);
		                        volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                        v25 = (SingleFieldAccessor *)this->fields.m_volumeComponentsData;
		                        if ( volumeStack_k__BackingField )
		                        {
		                          v26 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                  (VolumeStack *)volumeStack_k__BackingField,
		                                  MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGRadialBlur>);
		                          if ( v25 )
		                          {
		                            v25[1].klass = (SingleFieldAccessor__Class *)v26;
		                            sub_18002D1B0(v25 + 1, v3, v27, v28, v99);
		                            volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                            v29 = this->fields.m_volumeComponentsData;
		                            if ( volumeStack_k__BackingField )
		                            {
		                              v30 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                      (VolumeStack *)volumeStack_k__BackingField,
		                                      MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGHorizontalBlur>);
		                              if ( v29 )
		                              {
		                                v29->fields.m_horizontalBlur = (HGHorizontalBlur *)v30;
		                                sub_18002D1B0((SingleFieldAccessor *)&v29->fields.m_horizontalBlur, v3, v31, v32, v100);
		                                volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                v33 = this->fields.m_volumeComponentsData;
		                                if ( volumeStack_k__BackingField )
		                                {
		                                  v34 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                          (VolumeStack *)volumeStack_k__BackingField,
		                                          MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGBWFlash>);
		                                  if ( v33 )
		                                  {
		                                    v33->fields.m_bwFlash = (HGBWFlash *)v34;
		                                    sub_18002D1B0((SingleFieldAccessor *)&v33->fields.m_bwFlash, v3, v35, v36, v101);
		                                    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                    v37 = this->fields.m_volumeComponentsData;
		                                    if ( volumeStack_k__BackingField )
		                                    {
		                                      v38 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                              (VolumeStack *)volumeStack_k__BackingField,
		                                              MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGFisheyeEffect>);
		                                      if ( v37 )
		                                      {
		                                        v37->fields.m_fisheyeEffect = (HGFisheyeEffect *)v38;
		                                        sub_18002D1B0(
		                                          (SingleFieldAccessor *)&v37->fields.m_fisheyeEffect,
		                                          v3,
		                                          v39,
		                                          v40,
		                                          v102);
		                                        volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                        v41 = this->fields.m_volumeComponentsData;
		                                        if ( volumeStack_k__BackingField )
		                                        {
		                                          v42 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                  (VolumeStack *)volumeStack_k__BackingField,
		                                                  MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGChromaticAbberation>);
		                                          if ( v41 )
		                                          {
		                                            v41->fields.m_chromaticAbberation = (HGChromaticAbberation *)v42;
		                                            sub_18002D1B0(
		                                              (SingleFieldAccessor *)&v41->fields.m_chromaticAbberation,
		                                              v3,
		                                              v43,
		                                              v44,
		                                              v103);
		                                            v47 = TypeInfo::UnityEngine::Object;
		                                            camera = this->fields.camera;
		                                            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                                            {
		                                              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                                              v47 = TypeInfo::UnityEngine::Object;
		                                              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                                              {
		                                                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                                                v47 = TypeInfo::UnityEngine::Object;
		                                              }
		                                            }
		                                            if ( !camera )
		                                              goto LABEL_29;
		                                            if ( !v47->_1.cctor_finished_or_no_cctor )
		                                              il2cpp_runtime_class_init_1(v47);
		                                            if ( !camera->fields._._._.m_CachedPtr )
		                                              goto LABEL_29;
		                                            volumeStack_k__BackingField = (char *)this->fields.camera;
		                                            if ( !volumeStack_k__BackingField )
		                                              goto LABEL_54;
		                                            if ( UnityEngine::Component::TryGetComponent<System::Object>(
		                                                   (Component *)volumeStack_k__BackingField,
		                                                   &component,
		                                                   MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGDepthOfField>) )
		                                            {
		                                              volumeStack_k__BackingField = (char *)this->fields.m_volumeComponentsData;
		                                              if ( !volumeStack_k__BackingField )
		                                                goto LABEL_54;
		                                              *((_QWORD *)volumeStack_k__BackingField + 12) = component;
		                                            }
		                                            else
		                                            {
		LABEL_29:
		                                              volumeStack_k__BackingField = (char *)this->fields.m_volumeComponentsData;
		                                              if ( !volumeStack_k__BackingField )
		                                                goto LABEL_54;
		                                              *((_QWORD *)volumeStack_k__BackingField + 12) = 0LL;
		                                            }
		                                            sub_18002D1B0(
		                                              (SingleFieldAccessor *)(volumeStack_k__BackingField + 96),
		                                              v3,
		                                              v45,
		                                              v46,
		                                              v104);
		                                            volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                            v49 = this->fields.m_volumeComponentsData;
		                                            if ( volumeStack_k__BackingField )
		                                            {
		                                              v50 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                      (VolumeStack *)volumeStack_k__BackingField,
		                                                      MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGMotionBlur>);
		                                              if ( v49 )
		                                              {
		                                                v49->fields.m_motionBlur = (HGMotionBlur *)v50;
		                                                sub_18002D1B0(
		                                                  (SingleFieldAccessor *)&v49->fields.m_motionBlur,
		                                                  v3,
		                                                  v51,
		                                                  v52,
		                                                  v105);
		                                                volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                v53 = this->fields.m_volumeComponentsData;
		                                                if ( volumeStack_k__BackingField )
		                                                {
		                                                  v54 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                          (VolumeStack *)volumeStack_k__BackingField,
		                                                          MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGSceneColorStylizer>);
		                                                  if ( v53 )
		                                                  {
		                                                    v53->fields.m_sceneColorStylizer = (HGSceneColorStylizer *)v54;
		                                                    sub_18002D1B0(
		                                                      (SingleFieldAccessor *)&v53->fields.m_sceneColorStylizer,
		                                                      v3,
		                                                      v55,
		                                                      v56,
		                                                      v106);
		                                                    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                    v57 = (SingleFieldAccessor *)this->fields.m_volumeComponentsData;
		                                                    if ( volumeStack_k__BackingField )
		                                                    {
		                                                      v58 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                              (VolumeStack *)volumeStack_k__BackingField,
		                                                              MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGCharacterVolume>);
		                                                      if ( v57 )
		                                                      {
		                                                        v57[2].klass = (SingleFieldAccessor__Class *)v58;
		                                                        sub_18002D1B0(v57 + 2, v3, v59, v60, v107);
		                                                        volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                        v61 = this->fields.m_volumeComponentsData;
		                                                        if ( volumeStack_k__BackingField )
		                                                        {
		                                                          v62 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                  (VolumeStack *)volumeStack_k__BackingField,
		                                                                  MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::ScreenSpaceReflectionVolume>);
		                                                          if ( v61 )
		                                                          {
		                                                            v61->fields.m_hgssrVolume = (ScreenSpaceReflectionVolume *)v62;
		                                                            sub_18002D1B0(
		                                                              (SingleFieldAccessor *)&v61->fields.m_hgssrVolume,
		                                                              v3,
		                                                              v63,
		                                                              v64,
		                                                              v108);
		                                                            volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                            v65 = this->fields.m_volumeComponentsData;
		                                                            if ( volumeStack_k__BackingField )
		                                                            {
		                                                              v66 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                      (VolumeStack *)volumeStack_k__BackingField,
		                                                                      MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::ScreenSpacePlanarReflectionVolume>);
		                                                              if ( v65 )
		                                                              {
		                                                                v65->fields.m_ssprVolume = (ScreenSpacePlanarReflectionVolume *)v66;
		                                                                sub_18002D1B0(
		                                                                  (SingleFieldAccessor *)&v65->fields.m_ssprVolume,
		                                                                  v3,
		                                                                  v67,
		                                                                  v68,
		                                                                  v109);
		                                                                volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                v69 = this->fields.m_volumeComponentsData;
		                                                                if ( volumeStack_k__BackingField )
		                                                                {
		                                                                  v70 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                          (VolumeStack *)volumeStack_k__BackingField,
		                                                                          MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGScanLine>);
		                                                                  if ( v69 )
		                                                                  {
		                                                                    v69->fields.m_hgScanLine = (HGScanLine *)v70;
		                                                                    sub_18002D1B0(
		                                                                      (SingleFieldAccessor *)&v69->fields.m_hgScanLine,
		                                                                      v3,
		                                                                      v71,
		                                                                      v72,
		                                                                      v110);
		                                                                    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                    v73 = this->fields.m_volumeComponentsData;
		                                                                    if ( volumeStack_k__BackingField )
		                                                                    {
		                                                                      v74 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                              (VolumeStack *)volumeStack_k__BackingField,
		                                                                              MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGBlackBox>);
		                                                                      if ( v73 )
		                                                                      {
		                                                                        v73->fields.m_hgBlackBox = (HGBlackBox *)v74;
		                                                                        sub_18002D1B0(
		                                                                          (SingleFieldAccessor *)&v73->fields.m_hgBlackBox,
		                                                                          v3,
		                                                                          v75,
		                                                                          v76,
		                                                                          v111);
		                                                                        volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                        v77 = this->fields.m_volumeComponentsData;
		                                                                        if ( volumeStack_k__BackingField )
		                                                                        {
		                                                                          v78 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                                  (VolumeStack *)volumeStack_k__BackingField,
		                                                                                  MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::GTAmbientOcclusion>);
		                                                                          if ( v77 )
		                                                                          {
		                                                                            v77->fields.m_GTAmbientOcclusion = (GTAmbientOcclusion *)v78;
		                                                                            sub_18002D1B0(
		                                                                              (SingleFieldAccessor *)&v77->fields.m_GTAmbientOcclusion,
		                                                                              v3,
		                                                                              v79,
		                                                                              v80,
		                                                                              v112);
		                                                                            volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                            v81 = (SingleFieldAccessor *)this->fields.m_volumeComponentsData;
		                                                                            if ( volumeStack_k__BackingField )
		                                                                            {
		                                                                              v82 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                                      (VolumeStack *)volumeStack_k__BackingField,
		                                                                                      MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::OtherSettings>);
		                                                                              if ( v81 )
		                                                                              {
		                                                                                v81[3].klass = (SingleFieldAccessor__Class *)v82;
		                                                                                sub_18002D1B0(
		                                                                                  v81 + 3,
		                                                                                  v3,
		                                                                                  v83,
		                                                                                  v84,
		                                                                                  v113);
		                                                                                volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                                v85 = this->fields.m_volumeComponentsData;
		                                                                                if ( volumeStack_k__BackingField )
		                                                                                {
		                                                                                  v86 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                                          (VolumeStack *)volumeStack_k__BackingField,
		                                                                                          MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::RayTracingReflectionVolume>);
		                                                                                  if ( v85 )
		                                                                                  {
		                                                                                    v85->fields.m_rayTracingReflectionVolume = (RayTracingReflectionVolume *)v86;
		                                                                                    sub_18002D1B0(
		                                                                                      (SingleFieldAccessor *)&v85->fields.m_rayTracingReflectionVolume,
		                                                                                      v3,
		                                                                                      v87,
		                                                                                      v88,
		                                                                                      v114);
		                                                                                    volumeStack_k__BackingField = (char *)this->fields._volumeStack_k__BackingField;
		                                                                                    v89 = this->fields.m_volumeComponentsData;
		                                                                                    if ( volumeStack_k__BackingField )
		                                                                                    {
		                                                                                      v90 = UnityEngine::Rendering::VolumeStack::GetComponent<System::Object>(
		                                                                                              (VolumeStack *)volumeStack_k__BackingField,
		                                                                                              MethodInfo::UnityEngine::Rendering::VolumeStack::GetComponent<HG::Rendering::Runtime::HGAnamorphicStreaks>);
		                                                                                      if ( v89 )
		                                                                                      {
		                                                                                        v89->fields.m_anamorphicStreaks = (HGAnamorphicStreaks *)v90;
		                                                                                        sub_18002D1B0(
		                                                                                          (SingleFieldAccessor *)&v89->fields.m_anamorphicStreaks,
		                                                                                          v3,
		                                                                                          v91,
		                                                                                          v92,
		                                                                                          v115);
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
		LABEL_54:
		    sub_1800D8260(volumeStack_k__BackingField, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2838, 0LL);
		  if ( !Patch )
		    goto LABEL_54;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal unsafe HGRenderPathBeforeCullingParamsCPP* BeforeCullingCPP(HGSettingParameters settingParameters, bool needRenderTerrain, bool enableTerrainDeform, Transform curEnvCenter) => default; // 0x00000001831020A0-0x00000001831038D0
		// HGRenderPathBeforeCullingParamsCPP* BeforeCullingCPP(HGSettingParameters, Boolean, Boolean, Transform)
		HGRenderPathBeforeCullingParamsCPP *HG::Rendering::Runtime::HGCamera::BeforeCullingCPP(
		        HGCamera *this,
		        HGSettingParameters *settingParameters,
		        bool needRenderTerrain,
		        bool enableTerrainDeform,
		        Transform *curEnvCenter,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v6)(__int64); // rax
		  HGSettingParameters *v9; // r13
		  __int64 v11; // rbx
		  TileBase *static_fields; // rdx
		  int *klass; // rcx
		  Object *instance; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v15; // rax
		  Object__Class *v16; // rax
		  int32_t namespaze; // eax
		  Object *v18; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v19; // rax
		  Object__Class *v20; // rax
		  int32_t namespaze_high; // eax
		  struct HGCamera__Class *v22; // rax
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGEnvironmentPhase *v24; // rdi
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int64 (*v32)(void); // rax
		  unsigned int v33; // edi
		  unsigned __int8 (__fastcall *v34)(_QWORD, __int64); // rax
		  Vector3Int *v35; // r8
		  ITilemap *v36; // r9
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  int32_t hgRenderPath; // eax
		  HGAdditionalCameraData *v39; // rax
		  int32_t v40; // eax
		  bool v41; // al
		  struct Object_1__Class *v42; // rcx
		  void (__fastcall *v43)(Transform *, __m128 *); // rax
		  __m128 v44; // xmm4
		  __m128 v45; // xmm4
		  __m128 v46; // xmm4
		  HGAdditionalCameraData *v47; // rax
		  int32_t v48; // eax
		  __int64 v49; // rax
		  int32_t selfShadowCount; // eax
		  int v51; // r14d
		  __int64 (__fastcall *v52)(__int64); // rax
		  __int64 (__fastcall *v53)(_QWORD); // rax
		  __int64 v54; // r12
		  __int64 (__fastcall *v55)(_QWORD); // rax
		  __int64 v56; // rax
		  Object *camera; // r15
		  unsigned int v58; // edi
		  __int64 v59; // r8
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  Object *m_hgCharacterVolume; // rdi
		  int *v62; // rax
		  __int64 v63; // rax
		  __int64 v64; // rax
		  __int64 v65; // r14
		  bool v66; // al
		  struct Object_1__Class *v67; // rcx
		  __int64 v68; // r14
		  int v69; // eax
		  struct HGCharacterQualitySettings__Class *v70; // rcx
		  int v71; // r15d
		  bool v72; // al
		  __int64 v73; // r14
		  int32_t v74; // eax
		  __int64 v75; // r14
		  int v76; // eax
		  MonitorData *monitor; // r14
		  __int64 v78; // r15
		  __int64 (__fastcall *v79)(MonitorData *, _QWORD); // r8
		  __int64 v80; // xmm0_8
		  Object__Class *v81; // rdi
		  __int64 v82; // r14
		  Il2CppNameToTypeHandleHashTable *nameToClassHashTable; // r8
		  __int64 v84; // xmm0_8
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  unsigned int v87; // r12d
		  int32_t m_antialiasingMode; // eax
		  bool v89; // al
		  HGVerticalOcclusionMapSettingParameters *verticalOcclusionMap_k__BackingField; // rdi
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // r15
		  struct MethodInfo *v92; // r14
		  Il2CppClass *v93; // rax
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapSize_k__BackingField; // rdi
		  struct MethodInfo *v95; // r14
		  Il2CppClass *v96; // rax
		  Il2CppClass *v97; // rcx
		  Object *currentAsset; // rdi
		  HGRenderPipelineGlobalSettings *v99; // rax
		  HGRenderPipelineRuntimeResources *v100; // rax
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rdi
		  HGRainPresettingAsset *rainPresettingAsset; // rdi
		  RainCommonPreSettingParam *rainCommonPreSettingParam; // rax
		  int rainOcclusionMapHeight_low; // xmm0_4
		  __int64 (*v105)(void); // rax
		  unsigned int v106; // edi
		  unsigned __int8 (__fastcall *v107)(_QWORD, __int64); // rax
		  SettingParameter_1_System_Boolean_ *hdplsCharacterShadowEnabled_k__BackingField; // rdi
		  struct MethodInfo *v109; // r14
		  Il2CppClass *v110; // rax
		  SettingParameter_1_System_Boolean_ *enableScreenSpaceShadowMask_k__BackingField; // rdi
		  struct MethodInfo *v112; // r14
		  Il2CppClass *v113; // rax
		  Sprite__Array *m_AnimatedSprites; // r13
		  Camera *v115; // rax
		  int64_t renderPathInstanceCPP; // r14
		  void *m_CachedPtr; // rdi
		  void (__fastcall *v118)(int64_t, __int64, void *, __int64, _QWORD); // rax
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *selfShadowCharacterHelpers; // rax
		  __int64 v121; // r13
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *v122; // r15
		  struct MethodInfo *v123; // r12
		  int32_t Entry; // eax
		  __int128 v125; // xmm0
		  __int64 v126; // xmm1_8
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *v127; // rax
		  __int16 id; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v129; // rax
		  uint32_t v130; // eax
		  __int64 v131; // rdx
		  __int64 hdplsRenderCount; // rdi
		  __int64 (__fastcall *v133)(__int64); // rax
		  __int64 v134; // rax
		  struct MethodInfo *v135; // r14
		  SettingParameter_1_System_Int32_ *hdplsAtlasHeight_k__BackingField; // r15
		  Il2CppClass *v137; // rax
		  Il2CppClass *v138; // rcx
		  int paramValue_k__BackingField; // eax
		  __int64 (__fastcall *v140)(_QWORD); // rax
		  __int64 v141; // r15
		  __int64 (__fastcall *v142)(_QWORD); // rax
		  __int64 (__fastcall *v143)(_QWORD); // rax
		  __int64 v144; // rax
		  Object *v145; // r14
		  __int64 v146; // r13
		  __int64 v147; // rdi
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *hdplsCharacterHelpers; // rax
		  __int64 v149; // r15
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *v150; // rdi
		  struct MethodInfo *v151; // r14
		  int32_t v152; // eax
		  __int128 v153; // xmm0
		  __int64 v154; // xmm1_8
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *HDPLSShadowEntities; // rax
		  __m128i v156; // xmm6
		  int m_Length; // r14d
		  Void *m_Buffer; // r15
		  __int64 (__fastcall *v159)(_QWORD); // rax
		  __int64 v160; // rdi
		  void (__fastcall *v161)(__int64, __int64, _QWORD); // rax
		  int v162; // r14d
		  struct MethodInfo *v163; // rdi
		  Il2CppClass *v164; // rcx
		  Vector2 v165; // xmm1_8
		  Vector2 v166; // xmm1_8
		  __m128 v167; // xmm0
		  __m128 v168; // xmm1
		  __m128 typeMetadataHandle_high; // xmm0
		  __m128 interopData_low; // xmm1
		  __int64 v171; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v173; // rax
		  __int64 v174; // rax
		  __int64 v175; // rax
		  ILFixDynamicMethodWrapper_2 *v176; // rax
		  ILFixDynamicMethodWrapper_2 *v177; // rax
		  ILFixDynamicMethodWrapper_2 *v178; // rax
		  __int64 v179; // rax
		  ILFixDynamicMethodWrapper_2 *v180; // rax
		  __int64 v181; // rax
		  __int64 v182; // rax
		  __int64 v183; // rax
		  ILFixDynamicMethodWrapper_2 *v184; // rax
		  Bounds *overrideBound; // rax
		  ILFixDynamicMethodWrapper_2 *v186; // rax
		  ILFixDynamicMethodWrapper_2 *v187; // rax
		  ILFixDynamicMethodWrapper_2 *v188; // rax
		  ILFixDynamicMethodWrapper_2 *v189; // rax
		  ILFixDynamicMethodWrapper *v190; // rax
		  ILFixDynamicMethodWrapper *v191; // rax
		  ILFixDynamicMethodWrapper *v192; // rax
		  ILFixDynamicMethodWrapper *v193; // rax
		  ILFixDynamicMethodWrapper_2 *v194; // rax
		  ILFixDynamicMethodWrapper_2 *v195; // rax
		  __int64 v196; // rax
		  __int64 v197; // rax
		  ILFixDynamicMethodWrapper_2__Array *v198; // r8
		  ILFixDynamicMethodWrapper_2 *v199; // rax
		  ILFixDynamicMethodWrapper_2 *v200; // rax
		  __int64 v201; // rax
		  __int64 v202; // rax
		  __int64 v203; // rax
		  __int64 v204; // rax
		  __int64 v205; // rax
		  ILFixDynamicMethodWrapper_2 *v206; // rax
		  Bounds *v207; // rax
		  __int64 v208; // rax
		  __int64 v209; // rax
		  __int64 v210; // rax
		  SystemException *v211; // rbx
		  String *v212; // rax
		  __int64 v213; // rax
		  MethodInfo *v214; // [rsp+20h] [rbp-E0h]
		  Object *key; // [rsp+30h] [rbp-D0h]
		  Object *keya; // [rsp+30h] [rbp-D0h]
		  Object *keyb; // [rsp+30h] [rbp-D0h]
		  Object *keyc; // [rsp+30h] [rbp-D0h]
		  __int64 v219; // [rsp+38h] [rbp-C8h]
		  __int64 v220; // [rsp+38h] [rbp-C8h]
		  __int64 v221; // [rsp+40h] [rbp-C0h]
		  __int64 v222; // [rsp+40h] [rbp-C0h]
		  __m128 v223; // [rsp+48h] [rbp-B8h] BYREF
		  __int64 v224; // [rsp+58h] [rbp-A8h]
		  __int64 v225; // [rsp+60h] [rbp-A0h]
		  __int64 v226; // [rsp+68h] [rbp-98h]
		  TileAnimationData v227; // [rsp+70h] [rbp-90h] BYREF
		  Bounds v228; // [rsp+80h] [rbp-80h] BYREF
		  HGShadowConfig v229; // [rsp+A0h] [rbp-60h] BYREF
		  Bounds v230; // [rsp+120h] [rbp+20h] BYREF
		
		  v6 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  v9 = settingParameters;
		  if ( !qword_18F370618 )
		  {
		    v6 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v6 )
		    {
		      v171 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v171, 0LL);
		    }
		    qword_18F370618 = (__int64)v6;
		  }
		  v11 = v6(432LL);
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_318;
		  v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)v15->static_fields;
		  klass = (int *)static_fields->klass;
		  if ( !static_fields->klass )
		    goto LABEL_318;
		  if ( klass[6] <= 672 )
		    goto LABEL_7;
		  if ( !v15->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v15);
		    v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)v15->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x2A0 )
		    goto LABEL_345;
		  if ( static_fields[225].monitor )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( !Patch )
		      goto LABEL_318;
		    namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, instance, 0LL);
		  }
		  else
		  {
		LABEL_7:
		    v16 = instance[1].klass;
		    if ( !v16 )
		      goto LABEL_318;
		    namespaze = (int32_t)v16->_0.namespaze;
		  }
		  if ( !v11 )
		    goto LABEL_318;
		  *(_DWORD *)v11 = namespaze;
		  v18 = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !v18 )
		    goto LABEL_318;
		  v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)v19->static_fields;
		  klass = (int *)static_fields->klass;
		  if ( !static_fields->klass )
		    goto LABEL_318;
		  if ( klass[6] <= 856 )
		    goto LABEL_15;
		  if ( !v19->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v19);
		    v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)v19->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x358 )
		    goto LABEL_345;
		  if ( static_fields[286].fields._._.m_CachedPtr )
		  {
		    v173 = IFix::WrappersManagerImpl::GetPatch(856, 0LL);
		    if ( !v173 )
		      goto LABEL_318;
		    namespaze_high = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v173, v18, 0LL);
		  }
		  else
		  {
		LABEL_15:
		    v20 = v18[1].klass;
		    if ( !v20 )
		      goto LABEL_318;
		    namespaze_high = HIDWORD(v20->_0.namespaze);
		  }
		  *(_DWORD *)(v11 + 4) = namespaze_high;
		  *(Vector2Int *)(v11 + 8) = this->fields._sceneRTSize_k__BackingField;
		  v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  }
		  *(_DWORD *)(v11 + 16) = v22->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		  *(_QWORD *)(v11 + 24) = &this->fields.lodCrossFadeConfig;
		  *(_QWORD *)(v11 + 40) = HG::Rendering::Runtime::HGUtilsCpp::ConvertSettingParamsToCpp(v9, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(this, 0LL);
		  v24 = InterpolatedPhase;
		  if ( !InterpolatedPhase )
		    goto LABEL_318;
		  *(_QWORD *)(v11 + 48) = HG::Rendering::Runtime::HGUtilsCpp::ConvertLightConfigToCpp(
		                            &InterpolatedPhase->fields.lightConfig,
		                            0LL);
		  v25 = *(_OWORD *)&v24->fields.shadowConfig.csmIntensity;
		  *(_OWORD *)&v229.csmDepthBias = *(_OWORD *)&v24->fields.shadowConfig.csmDepthBias;
		  v26 = *(_OWORD *)&v24->fields.shadowConfig.csmShadowSoftness;
		  *(_OWORD *)&v229.csmIntensity = v25;
		  v27 = *(_OWORD *)&v24->fields.shadowConfig.contactShadowSurfaceThickness;
		  *(_OWORD *)&v229.csmShadowSoftness = v26;
		  v28 = *(_OWORD *)&v24->fields.shadowConfig.overrideCsmFarDistance;
		  *(_OWORD *)&v229.contactShadowSurfaceThickness = v27;
		  v29 = *(_OWORD *)&v24->fields.shadowConfig.overrideCsmSpherePosition.z;
		  *(_OWORD *)&v229.overrideCsmFarDistance = v28;
		  v30 = *(_OWORD *)&v24->fields.shadowConfig.csmSimulatedAttenuation;
		  *(_OWORD *)&v229.overrideCsmSpherePosition.z = v29;
		  v31 = *(_OWORD *)&v24->fields.shadowConfig.rhodesShipCenter.z;
		  *(_OWORD *)&v229.csmSimulatedAttenuation = v30;
		  *(_OWORD *)&v229.rhodesShipCenter.z = v31;
		  *(_QWORD *)(v11 + 56) = HG::Rendering::Runtime::HGUtilsCpp::ConvertShadowConfigToCpp(&v229, 0LL);
		  *(float *)(v11 + 64) = v24->fields.heightFogConfig.heightFogCullingFarClipPlane;
		  *(_BYTE *)(v11 + 72) = this->fields.overrideCsmShadowDistance;
		  *(float *)(v11 + 68) = this->fields.overrideCsmMaxDistanceValue;
		  *(_BYTE *)(v11 + 73) = this->fields.enableShadowCulling;
		  *(_BYTE *)(v11 + 74) = this->fields.regenerateAsmTriggerForCpp;
		  if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		  v32 = (__int64 (*)(void))qword_18F36F380;
		  if ( !qword_18F36F380 )
		  {
		    v32 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		    if ( !v32 )
		    {
		      v174 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		      sub_18007E1B0(v174, 0LL);
		    }
		    qword_18F36F380 = (__int64)v32;
		  }
		  v33 = v32();
		  v34 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		  if ( !qword_18F370308 )
		  {
		    v34 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                             "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Uni"
		                                                             "tyEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
		    if ( !v34 )
		    {
		      v175 = sub_1802EE1B8(
		               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Re"
		               "ndering.BuiltinShaderDefine)");
		      sub_18007E1B0(v175, 0LL);
		    }
		    qword_18F370308 = (__int64)v34;
		  }
		  *(_WORD *)(v11 + 76) = v34(v33, 33LL);
		  klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( SLODWORD(static_fields[1].klass) <= 794 )
		    goto LABEL_515;
		  if ( !klass[56] )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x31A )
		    goto LABEL_345;
		  if ( static_fields[266].klass )
		  {
		    v176 = IFix::WrappersManagerImpl::GetPatch(794, 0LL);
		    if ( !v176 )
		      goto LABEL_318;
		    v41 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v176, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_515:
		    if ( !klass[56] )
		    {
		      il2cpp_runtime_class_init_1(klass);
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (TileBase *)**((_QWORD **)klass + 23);
		    if ( !static_fields )
		      goto LABEL_318;
		    if ( SLODWORD(static_fields[1].klass) <= 703 )
		      goto LABEL_34;
		    if ( !klass[56] )
		    {
		      il2cpp_runtime_class_init_1(klass);
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (TileBase *)**((_QWORD **)klass + 23);
		    if ( !static_fields )
		      goto LABEL_318;
		    if ( LODWORD(static_fields[1].klass) <= 0x2BF )
		      goto LABEL_345;
		    if ( static_fields[235].fields._._.m_CachedPtr )
		    {
		      v177 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		      if ( !v177 )
		        goto LABEL_318;
		      hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)v177,
		                       (Object *)this,
		                       0LL);
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_34:
		      m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		      if ( !m_AdditionalCameraData )
		        goto LABEL_318;
		      hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		    }
		    if ( hgRenderPath == 1 )
		    {
		      v41 = 1;
		    }
		    else
		    {
		      if ( !klass[56] )
		      {
		        il2cpp_runtime_class_init_1(klass);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields[1].klass) <= 703 )
		        goto LABEL_41;
		      if ( !klass[56] )
		      {
		        il2cpp_runtime_class_init_1(klass);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      klass = (int *)**((_QWORD **)klass + 23);
		      if ( !klass )
		        goto LABEL_318;
		      if ( (unsigned int)klass[6] <= 0x2BF )
		        goto LABEL_345;
		      if ( *((_QWORD *)klass + 707) )
		      {
		        v178 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		        if ( !v178 )
		          goto LABEL_318;
		        v40 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v178, (Object *)this, 0LL);
		      }
		      else
		      {
		LABEL_41:
		        v39 = this->fields.m_AdditionalCameraData;
		        if ( !v39 )
		          goto LABEL_318;
		        v40 = v39->fields.hgRenderPath;
		      }
		      v41 = v40 == 2;
		    }
		  }
		  *(_BYTE *)(v11 + 78) = v41;
		  *(_BYTE *)(v11 + 79) = needRenderTerrain;
		  *(_BYTE *)(v11 + 80) = enableTerrainDeform;
		  *(TileAnimationData *)(v11 + 84) = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                        &v227,
		                                        static_fields,
		                                        v35,
		                                        v36,
		                                        v214);
		  v42 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v42 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v42 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( curEnvCenter )
		  {
		    if ( !v42->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v42);
		    if ( curEnvCenter->fields._._.m_CachedPtr )
		    {
		      v223.m128_u64[0] = 0LL;
		      v223.m128_i32[2] = 0;
		      v43 = (void (__fastcall *)(Transform *, __m128 *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v43 = (void (__fastcall *)(Transform *, __m128 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v43 )
		        {
		          v179 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v179, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v43;
		      }
		      v43(curEnvCenter, &v223);
		      v223.m128_i32[3] = 1065353216;
		      v44 = v223;
		      v44.m128_f32[0] = v223.m128_f32[0];
		      v45 = _mm_shuffle_ps(v44, v44, 225);
		      v45.m128_f32[0] = v223.m128_f32[1];
		      v46 = _mm_shuffle_ps(v45, v45, 198);
		      v46.m128_f32[0] = v223.m128_f32[2];
		      v223 = _mm_shuffle_ps(v46, v46, 201);
		      *(__m128 *)(v11 + 84) = v223;
		    }
		  }
		  *(_BYTE *)(v11 + 101) = this->fields.prevTransformReset;
		  *(_DWORD *)(v11 + 104) = this->fields.cullingViewUniqueID;
		  *(_BYTE *)(v11 + 75) = 0;
		  *(_BYTE *)(v11 + 102) = 0;
		  *(_BYTE *)(v11 + 100) = 0;
		  klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( SLODWORD(static_fields[1].klass) <= 703 )
		    goto LABEL_55;
		  if ( !klass[56] )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x2BF )
		    goto LABEL_345;
		  if ( static_fields[235].fields._._.m_CachedPtr )
		  {
		    v180 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		    if ( !v180 )
		      goto LABEL_318;
		    v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v180, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_55:
		    v47 = this->fields.m_AdditionalCameraData;
		    if ( !v47 )
		      goto LABEL_318;
		    v48 = v47->fields.hgRenderPath;
		  }
		  klass = (int *)this;
		  if ( v48 != 1 )
		    klass = (int *)HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
		  if ( klass )
		  {
		    *(_QWORD *)(v11 + 32) = klass + 634;
		    v49 = *((_QWORD *)klass + 12);
		    if ( !v49 )
		      goto LABEL_318;
		    v226 = *(_QWORD *)(v49 + 16);
		  }
		  else
		  {
		    *(_QWORD *)(v11 + 32) = 0LL;
		    v226 = 0LL;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  selfShadowCount = HG::Rendering::Runtime::HGCharacters::get_selfShadowCount(0LL);
		  v51 = 14;
		  if ( selfShadowCount < 14 )
		    v51 = selfShadowCount;
		  v52 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v52 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v52 )
		    {
		      v181 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v181, 0LL);
		    }
		    qword_18F370618 = (__int64)v52;
		  }
		  *(_QWORD *)(v11 + 112) = v52(56LL);
		  v53 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v53 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v53 )
		    {
		      v182 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v182, 0LL);
		    }
		    qword_18F370618 = (__int64)v53;
		  }
		  v54 = v53(24 * v51);
		  v225 = v54;
		  v55 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v55 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v55 )
		    {
		      v183 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v183, 0LL);
		    }
		    qword_18F370618 = (__int64)v55;
		  }
		  v56 = v55(4 * v51);
		  camera = (Object *)this->fields.camera;
		  v58 = 0;
		  v219 = v56;
		  v59 = v56;
		  key = camera;
		  if ( v51 > 0 )
		  {
		    v224 = 0LL;
		    v221 = v54;
		    while ( 1 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      selfShadowCharacterHelpers = HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(0LL);
		      if ( !selfShadowCharacterHelpers )
		        goto LABEL_318;
		      if ( v58 >= selfShadowCharacterHelpers->fields._size )
		        goto LABEL_511;
		      klass = (int *)selfShadowCharacterHelpers->fields._items;
		      if ( !klass )
		        goto LABEL_318;
		      if ( v58 >= klass[6] )
		        goto LABEL_345;
		      v121 = *(_QWORD *)&klass[2 * v58 + 8];
		      if ( !v121 )
		        goto LABEL_318;
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields[1].klass) > 2109 )
		      {
		        if ( !klass[56] )
		        {
		          il2cpp_runtime_class_init_1(klass);
		          klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        klass = (int *)**((_QWORD **)klass + 23);
		        if ( !klass )
		          goto LABEL_318;
		        if ( (unsigned int)klass[6] <= 0x83D )
		          goto LABEL_345;
		        if ( *((_QWORD *)klass + 2113) )
		          break;
		      }
		      if ( *(_BYTE *)(v121 + 160) )
		      {
		        overrideBound = HG::Rendering::Runtime::HGCharacterHelper::get_overrideBound(
		                          &v228,
		                          (HGCharacterHelper *)v121,
		                          0LL);
		LABEL_418:
		        v126 = *(_QWORD *)&overrideBound->m_Extents.y;
		        v125 = *(_OWORD *)&overrideBound->m_Center.x;
		        goto LABEL_240;
		      }
		      klass = (int *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        klass = (int *)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          klass = (int *)TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( camera )
		      {
		        if ( !klass[56] )
		          il2cpp_runtime_class_init_1(klass);
		        if ( camera[1].klass )
		        {
		          v122 = *(Dictionary_2_System_Object_UnityEngine_Bounds_ **)(v121 + 96);
		          if ( !v122 )
		            goto LABEL_318;
		          v123 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		          if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		                + 4) )
		            (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		          Entry = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		                    v122,
		                    key,
		                    (MethodInfo *)v123->klass->rgctx_data[22].rgctxDataDummy);
		          if ( Entry >= 0 )
		          {
		            static_fields = (TileBase *)v122->fields._entries;
		            if ( !static_fields )
		              goto LABEL_318;
		            if ( (unsigned int)Entry >= LODWORD(static_fields[1].klass) )
		              goto LABEL_345;
		            v54 = v221;
		            v125 = *(_OWORD *)(&static_fields[2].klass + 5 * Entry);
		            v126 = *((_QWORD *)&static_fields[2].fields._._.m_CachedPtr + 5 * Entry);
		            goto LABEL_240;
		          }
		          v54 = v221;
		        }
		      }
		      v125 = *(_OWORD *)(v121 + 112);
		      v126 = *(_QWORD *)(v121 + 128);
		LABEL_240:
		      *(_OWORD *)v54 = v125;
		      *(_QWORD *)(v54 + 16) = v126;
		      v127 = HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(0LL);
		      if ( !v127 )
		        goto LABEL_318;
		      if ( v58 >= v127->fields._size )
		LABEL_511:
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      klass = (int *)v127->fields._items;
		      if ( !klass )
		        goto LABEL_318;
		      if ( v58 >= klass[6] )
		        goto LABEL_345;
		      klass = *(int **)&klass[2 * v58 + 8];
		      if ( !klass )
		        goto LABEL_318;
		      id = HG::Rendering::Runtime::HGCharacterHelper::get_id((HGCharacterHelper *)klass, 0LL);
		      v129 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v129 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)v129->static_fields;
		      if ( !static_fields->klass )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields->klass->_0.namespaze) <= 2115 )
		        goto LABEL_249;
		      if ( !v129->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v129);
		        v129 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      klass = (int *)v129->static_fields->wrapperArray;
		      if ( !klass )
		        goto LABEL_318;
		      if ( (unsigned int)klass[6] <= 0x843 )
		        goto LABEL_345;
		      if ( *((_QWORD *)klass + 2119) )
		      {
		        v186 = IFix::WrappersManagerImpl::GetPatch(2115, 0LL);
		        if ( !v186 )
		          goto LABEL_318;
		        v130 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_852(v186, id, 0LL);
		      }
		      else
		      {
		LABEL_249:
		        if ( id < 0 )
		          v130 = 0;
		        else
		          v130 = 1 << ((id + 8) & 0x1F);
		      }
		      v131 = v224;
		      v54 += 24LL;
		      v59 = v219;
		      ++v58;
		      camera = key;
		      v221 = v54;
		      *(_DWORD *)(v219 + 4 * v224) = v130;
		      v224 = v131 + 1;
		      if ( v131 + 1 >= v51 )
		      {
		        v54 = v225;
		        v9 = settingParameters;
		        goto LABEL_70;
		      }
		    }
		    v184 = IFix::WrappersManagerImpl::GetPatch(2109, 0LL);
		    if ( !v184 )
		      goto LABEL_318;
		    overrideBound = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(&v228, v184, (Object *)v121, camera, 0LL);
		    goto LABEL_418;
		  }
		LABEL_70:
		  klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v59 = v219;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( SLODWORD(static_fields[1].klass) <= 783 )
		    goto LABEL_74;
		  if ( !klass[56] )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v59 = v219;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x30F )
		    goto LABEL_345;
		  if ( static_fields[262].monitor )
		  {
		    v187 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v187 )
		      goto LABEL_318;
		    m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v187, (Object *)this, 0LL);
		    v59 = v219;
		  }
		  else
		  {
		LABEL_74:
		    m_volumeComponentsData = this->fields.m_volumeComponentsData;
		  }
		  if ( !m_volumeComponentsData )
		    goto LABEL_318;
		  m_hgCharacterVolume = (Object *)m_volumeComponentsData->fields.m_hgCharacterVolume;
		  v62 = *(int **)(v11 + 112);
		  if ( !v62 )
		    goto LABEL_318;
		  *v62 = v51;
		  v63 = *(_QWORD *)(v11 + 112);
		  if ( !v63 )
		    goto LABEL_318;
		  *(_QWORD *)(v63 + 8) = v54;
		  v64 = *(_QWORD *)(v11 + 112);
		  if ( !v64 )
		    goto LABEL_318;
		  *(_QWORD *)(v64 + 16) = v59;
		  klass = (int *)TypeInfo::UnityEngine::Object;
		  v65 = *(_QWORD *)(v11 + 112);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    klass = (int *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      klass = (int *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_hgCharacterVolume )
		  {
		    if ( !klass[56] )
		      il2cpp_runtime_class_init_1(klass);
		    v66 = m_hgCharacterVolume[1].klass != 0LL;
		  }
		  else
		  {
		    v66 = 0;
		  }
		  if ( !v65 )
		    goto LABEL_318;
		  *(_BYTE *)(v65 + 24) = v66;
		  v67 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v67 = TypeInfo::UnityEngine::Object;
		  }
		  if ( m_hgCharacterVolume )
		  {
		    if ( !v67->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v67);
		    if ( m_hgCharacterVolume[1].klass )
		    {
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      v68 = *(_QWORD *)(v11 + 112);
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields[1].klass) <= 784 )
		        goto LABEL_95;
		      if ( !klass[56] )
		      {
		        il2cpp_runtime_class_init_1(klass);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( LODWORD(static_fields[1].klass) <= 0x310 )
		        goto LABEL_345;
		      if ( static_fields[262].fields._._.m_CachedPtr )
		      {
		        v188 = IFix::WrappersManagerImpl::GetPatch(784, 0LL);
		        if ( !v188 )
		          goto LABEL_318;
		        v72 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                (ILFixDynamicMethodWrapper_20 *)v188,
		                m_hgCharacterVolume,
		                0LL);
		      }
		      else
		      {
		LABEL_95:
		        static_fields = (TileBase *)m_hgCharacterVolume[27].klass;
		        if ( !static_fields )
		          goto LABEL_318;
		        v69 = sub_180002F70(10LL, static_fields);
		        v70 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		        v71 = v69;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
		          v70 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		        }
		        klass = &v70->static_fields->characterSelfShadowOffLodQuality;
		        v72 = klass[1] >= v71;
		      }
		      if ( !v68 )
		        goto LABEL_318;
		      *(_BYTE *)(v68 + 25) = v72;
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      v73 = *(_QWORD *)(v11 + 112);
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields[1].klass) <= 2111 )
		        goto LABEL_104;
		      if ( !klass[56] )
		      {
		        il2cpp_runtime_class_init_1(klass);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( LODWORD(static_fields[1].klass) <= 0x83F )
		        goto LABEL_345;
		      if ( static_fields[705].klass )
		      {
		        v189 = IFix::WrappersManagerImpl::GetPatch(2111, 0LL);
		        if ( !v189 )
		          goto LABEL_318;
		        v74 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                (ILFixDynamicMethodWrapper_26 *)v189,
		                m_hgCharacterVolume,
		                0LL);
		      }
		      else
		      {
		LABEL_104:
		        static_fields = (TileBase *)m_hgCharacterVolume[16].monitor;
		        if ( !static_fields )
		          goto LABEL_318;
		        v74 = sub_180002F70(10LL, static_fields);
		      }
		      if ( !v73 )
		        goto LABEL_318;
		      *(_DWORD *)(v73 + 28) = v74;
		      static_fields = (TileBase *)m_hgCharacterVolume[12].klass;
		      v75 = *(_QWORD *)(v11 + 112);
		      if ( !static_fields )
		        goto LABEL_318;
		      v76 = sub_180002F70(10LL, static_fields);
		      if ( !v75 )
		        goto LABEL_318;
		      *(_DWORD *)(v75 + 32) = v76;
		      monitor = m_hgCharacterVolume[12].monitor;
		      v78 = *(_QWORD *)(v11 + 112);
		      if ( !monitor )
		        goto LABEL_318;
		      sub_1800049A0(*(_QWORD *)monitor);
		      v79 = *(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)monitor + 480LL);
		      if ( (char *)v79 == (char *)Beyond::Gameplay::Core::PQSFilter::get_factorRange )
		      {
		        if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
		        {
		          v190 = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
		          if ( !v190 )
		            goto LABEL_318;
		          v165 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v190, (Object *)monitor, 0LL);
		        }
		        else
		        {
		          v165 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        }
		        v80 = (__int64)v165;
		      }
		      else if ( (char *)v79 == (char *)Beyond::Gameplay::Core::PQSEvaluator::get_factorRange )
		      {
		        if ( IFix::WrappersManagerImpl::IsPatched(58313, 0LL) )
		        {
		          v191 = IFix::WrappersManagerImpl::GetPatch(58313, 0LL);
		          if ( !v191 )
		            goto LABEL_318;
		          keyb = (Object *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v191, (Object *)monitor, 0LL);
		          v167 = (__m128)(unsigned int)keyb;
		          v168 = (__m128)HIDWORD(keyb);
		        }
		        else
		        {
		          v167 = (__m128)*((unsigned int *)monitor + 27);
		          v168 = (__m128)*((unsigned int *)monitor + 28);
		        }
		        v80 = _mm_unpacklo_ps(v167, v168).m128_u64[0];
		      }
		      else
		      {
		        v80 = v79(monitor, *(_QWORD *)(*(_QWORD *)monitor + 488LL));
		      }
		      if ( !v78 )
		        goto LABEL_318;
		      *(_QWORD *)(v78 + 44) = v80;
		      v81 = m_hgCharacterVolume[13].klass;
		      v82 = *(_QWORD *)(v11 + 112);
		      if ( !v81 )
		        goto LABEL_318;
		      sub_1800049A0(v81->_0.image);
		      nameToClassHashTable = v81->_0.image[6].nameToClassHashTable;
		      if ( nameToClassHashTable == (Il2CppNameToTypeHandleHashTable *)Beyond::Gameplay::Core::PQSFilter::get_factorRange )
		      {
		        if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
		        {
		          v192 = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
		          if ( !v192 )
		            goto LABEL_318;
		          v166 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v192, (Object *)v81, 0LL);
		        }
		        else
		        {
		          v166 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        }
		        v84 = (__int64)v166;
		      }
		      else if ( nameToClassHashTable == (Il2CppNameToTypeHandleHashTable *)Beyond::Gameplay::Core::PQSEvaluator::get_factorRange )
		      {
		        if ( IFix::WrappersManagerImpl::IsPatched(58313, 0LL) )
		        {
		          v193 = IFix::WrappersManagerImpl::GetPatch(58313, 0LL);
		          if ( !v193 )
		            goto LABEL_318;
		          keyc = (Object *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v193, (Object *)v81, 0LL);
		          typeMetadataHandle_high = (__m128)(unsigned int)keyc;
		          interopData_low = (__m128)HIDWORD(keyc);
		        }
		        else
		        {
		          typeMetadataHandle_high = (__m128)HIDWORD(v81->_0.typeMetadataHandle);
		          interopData_low = (__m128)LODWORD(v81->_0.interopData);
		        }
		        v84 = _mm_unpacklo_ps(typeMetadataHandle_high, interopData_low).m128_u64[0];
		      }
		      else
		      {
		        v84 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))nameToClassHashTable)(
		                v81,
		                v81->_0.image[6].codeGenModule);
		      }
		      if ( !v82 )
		        goto LABEL_318;
		      *(_QWORD *)(v82 + 36) = v84;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		  if ( !v9 )
		    goto LABEL_318;
		  if ( !s_rainRenderer )
		    goto LABEL_318;
		  *(_QWORD *)(v11 + 128) = HG::Rendering::Runtime::HGRainRenderer::PrepareCppInput(
		                             s_rainRenderer,
		                             this,
		                             v9->fields._verticalOcclusionMap_k__BackingField,
		                             0LL);
		  s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		  if ( !s_snowRenderer )
		    goto LABEL_318;
		  *(_QWORD *)(v11 + 136) = HG::Rendering::Runtime::HGSnowRenderer::PrepareCppInput(s_snowRenderer, this, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  v87 = 0;
		  *(_BYTE *)(v11 + 144) = HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(this, 0LL);
		  *(_DWORD *)(v11 + 148) = 0;
		  klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( SLODWORD(static_fields[1].klass) <= 736 )
		    goto LABEL_516;
		  if ( !klass[56] )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x2E0 )
		    goto LABEL_345;
		  if ( static_fields[246].fields._._.m_CachedPtr )
		  {
		    v194 = IFix::WrappersManagerImpl::GetPatch(736, 0LL);
		    if ( !v194 )
		      goto LABEL_318;
		    v89 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v194, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_516:
		    if ( !klass[56] )
		    {
		      il2cpp_runtime_class_init_1(klass);
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (TileBase *)**((_QWORD **)klass + 23);
		    if ( !static_fields )
		      goto LABEL_318;
		    if ( SLODWORD(static_fields[1].klass) <= 732 )
		      goto LABEL_135;
		    if ( !klass[56] )
		    {
		      il2cpp_runtime_class_init_1(klass);
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (TileBase *)**((_QWORD **)klass + 23);
		    if ( !static_fields )
		      goto LABEL_318;
		    if ( LODWORD(static_fields[1].klass) <= 0x2DC )
		      goto LABEL_345;
		    if ( static_fields[245].monitor )
		    {
		      v195 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v195 )
		        goto LABEL_318;
		      LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                     (ILFixDynamicMethodWrapper_31 *)v195,
		                                     (Object *)this,
		                                     0LL);
		    }
		    else
		    {
		LABEL_135:
		      m_antialiasingMode = this->fields.m_antialiasingMode;
		    }
		    v89 = (m_antialiasingMode & 2) != 0;
		  }
		  *(_BYTE *)(v11 + 152) = v89;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		  *(float *)(v11 + 156) = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
		  verticalOcclusionMap_k__BackingField = v9->fields._verticalOcclusionMap_k__BackingField;
		  if ( !verticalOcclusionMap_k__BackingField )
		    goto LABEL_318;
		  DepthOcclusionMapRange_k__BackingField = verticalOcclusionMap_k__BackingField->fields._DepthOcclusionMapRange_k__BackingField;
		  v92 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !DepthOcclusionMapRange_k__BackingField )
		    goto LABEL_318;
		  v93 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v93->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v93->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v196 = sub_18011C4C0(v92->klass);
		    (**(void (***)(void))(*(_QWORD *)(v196 + 192) + 48LL))();
		  }
		  klass = (int *)v92->klass;
		  if ( (klass[78] & 1) == 0 )
		    sub_1800360B0(klass, static_fields);
		  *(float *)(v11 + 160) = (float)DepthOcclusionMapRange_k__BackingField->fields._paramValue_k__BackingField;
		  DepthOcclusionMapSize_k__BackingField = verticalOcclusionMap_k__BackingField->fields._DepthOcclusionMapSize_k__BackingField;
		  v95 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !DepthOcclusionMapSize_k__BackingField )
		    goto LABEL_318;
		  v96 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v96->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v96->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v197 = sub_18011C4C0(v95->klass);
		    (**(void (***)(void))(*(_QWORD *)(v197 + 192) + 48LL))();
		  }
		  v97 = v95->klass;
		  if ( ((__int64)v97->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v97, static_fields);
		  *(_DWORD *)(v11 + 164) = DepthOcclusionMapSize_k__BackingField->fields._paramValue_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentAsset = (Object *)HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
		  if ( !currentAsset )
		    goto LABEL_318;
		  static_fields = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = (int *)static_fields[7].fields._._.m_CachedPtr;
		  if ( !*(_QWORD *)klass )
		    goto LABEL_318;
		  if ( *(int *)(*(_QWORD *)klass + 24LL) > 2960 )
		  {
		    if ( !LODWORD(static_fields[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(static_fields);
		      static_fields = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v198 = *(ILFixDynamicMethodWrapper_2__Array **)static_fields[7].fields._._.m_CachedPtr;
		    if ( !v198 )
		      goto LABEL_318;
		    if ( v198->max_length.size <= 0xB90u )
		      goto LABEL_345;
		    if ( v198[82].vector[8] )
		    {
		      v199 = IFix::WrappersManagerImpl::GetPatch(2960, 0LL);
		      if ( !v199 )
		        goto LABEL_318;
		LABEL_475:
		      v100 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_202(v199, currentAsset, 0LL);
		      goto LABEL_174;
		    }
		  }
		  if ( !LODWORD(static_fields[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = *(int **)static_fields[7].fields._._.m_CachedPtr;
		  if ( !klass )
		    goto LABEL_318;
		  if ( klass[6] <= 2959 )
		    goto LABEL_517;
		  if ( !LODWORD(static_fields[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = *(TileBase **)static_fields[7].fields._._.m_CachedPtr;
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0xB8F )
		    goto LABEL_345;
		  if ( static_fields[987].fields._._.m_CachedPtr )
		  {
		    v200 = IFix::WrappersManagerImpl::GetPatch(2959, 0LL);
		    if ( !v200 )
		      goto LABEL_318;
		    v99 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1098(v200, currentAsset, 0LL);
		  }
		  else
		  {
		LABEL_517:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		    v99 = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		  }
		  currentAsset = (Object *)v99;
		  if ( !v99 )
		    goto LABEL_318;
		  klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( SLODWORD(static_fields[1].klass) <= 417 )
		    goto LABEL_173;
		  if ( !klass[56] )
		  {
		    il2cpp_runtime_class_init_1(klass);
		    klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (TileBase *)**((_QWORD **)klass + 23);
		  if ( !static_fields )
		    goto LABEL_318;
		  if ( LODWORD(static_fields[1].klass) <= 0x1A1 )
		LABEL_345:
		    sub_1800D2AB0(klass, static_fields);
		  if ( static_fields[140].monitor )
		  {
		    v199 = IFix::WrappersManagerImpl::GetPatch(417, 0LL);
		    if ( !v199 )
		      goto LABEL_318;
		    goto LABEL_475;
		  }
		LABEL_173:
		  v100 = (HGRenderPipelineRuntimeResources *)currentAsset[7].klass;
		LABEL_174:
		  if ( !v100 )
		    goto LABEL_318;
		  assets = v100->fields.assets;
		  if ( !assets )
		    goto LABEL_318;
		  klass = (int *)TypeInfo::UnityEngine::Object;
		  rainPresettingAsset = assets->fields.rainPresettingAsset;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    klass = (int *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      klass = (int *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !rainPresettingAsset )
		    goto LABEL_214;
		  if ( !klass[56] )
		    il2cpp_runtime_class_init_1(klass);
		  if ( rainPresettingAsset->fields._._.m_CachedPtr )
		  {
		    rainCommonPreSettingParam = rainPresettingAsset->fields.rainCommonPreSettingParam;
		    if ( !rainCommonPreSettingParam )
		      goto LABEL_318;
		    rainOcclusionMapHeight_low = LODWORD(rainCommonPreSettingParam->fields.rainOcclusionMapHeight);
		  }
		  else
		  {
		LABEL_214:
		    rainOcclusionMapHeight_low = 1124073472;
		  }
		  *(_DWORD *)(v11 + 168) = rainOcclusionMapHeight_low;
		  if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		  v105 = (__int64 (*)(void))qword_18F36F380;
		  if ( !qword_18F36F380 )
		  {
		    v105 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		    if ( !v105 )
		    {
		      v201 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		      sub_18007E1B0(v201, 0LL);
		    }
		    qword_18F36F380 = (__int64)v105;
		  }
		  v106 = v105();
		  v107 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		  if ( !qword_18F370308 )
		  {
		    v107 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Un"
		                                                              "ityEngine.Rendering.GraphicsTier,UnityEngine.Rendering.Bui"
		                                                              "ltinShaderDefine)");
		    if ( !v107 )
		    {
		      v202 = sub_1802EE1B8(
		               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Re"
		               "ndering.BuiltinShaderDefine)");
		      sub_18007E1B0(v202, 0LL);
		    }
		    qword_18F370308 = (__int64)v107;
		  }
		  if ( v107(v106, 33LL) )
		    goto LABEL_210;
		  hdplsCharacterShadowEnabled_k__BackingField = v9->fields._hdplsCharacterShadowEnabled_k__BackingField;
		  v109 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !hdplsCharacterShadowEnabled_k__BackingField )
		    goto LABEL_318;
		  v110 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v110->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v110->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v203 = sub_18011C4C0(v109->klass);
		    (**(void (***)(void))(*(_QWORD *)(v203 + 192) + 48LL))();
		  }
		  klass = (int *)v109->klass;
		  if ( (klass[78] & 1) == 0 )
		    sub_1800360B0(klass, static_fields);
		  if ( !hdplsCharacterShadowEnabled_k__BackingField->fields._paramValue_k__BackingField )
		    goto LABEL_210;
		  enableScreenSpaceShadowMask_k__BackingField = v9->fields._enableScreenSpaceShadowMask_k__BackingField;
		  v112 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableScreenSpaceShadowMask_k__BackingField )
		    goto LABEL_318;
		  v113 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v113->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v113->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v204 = sub_18011C4C0(v112->klass);
		    (**(void (***)(void))(*(_QWORD *)(v204 + 192) + 48LL))();
		  }
		  klass = (int *)v112->klass;
		  if ( (klass[78] & 1) == 0 )
		    sub_1800360B0(klass, static_fields);
		  if ( !enableScreenSpaceShadowMask_k__BackingField->fields._paramValue_k__BackingField )
		    goto LABEL_210;
		  klass = (int *)TypeInfo::HG::Rendering::Runtime::HGCharacters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    klass = (int *)TypeInfo::HG::Rendering::Runtime::HGCharacters;
		  }
		  if ( !*(_QWORD *)(*((_QWORD *)klass + 23) + 8LL) )
		    goto LABEL_210;
		  if ( !klass[56] )
		    il2cpp_runtime_class_init_1(klass);
		  if ( HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(0LL) <= 0 )
		  {
		LABEL_210:
		    m_AnimatedSprites = 0LL;
		    goto LABEL_211;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  hdplsRenderCount = HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(0LL);
		  v133 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v133 = (__int64 (__fastcall *)(__int64))sub_180059EA0(
		                                              "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    qword_18F370618 = (__int64)v133;
		  }
		  v134 = v133(40LL);
		  v227.m_AnimatedSprites = (Sprite__Array *)v134;
		  m_AnimatedSprites = (Sprite__Array *)v134;
		  if ( !v134
		    || (*(_BYTE *)v134 = 1,
		        *(_DWORD *)(v134 + 4) = hdplsRenderCount,
		        v135 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit,
		        (hdplsAtlasHeight_k__BackingField = settingParameters->fields._hdplsAtlasHeight_k__BackingField) == 0LL) )
		  {
		LABEL_318:
		    sub_1800D8260(klass, static_fields);
		  }
		  v137 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v137->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, static_fields);
		  if ( !*((_QWORD *)v137->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v205 = sub_18011C4C0(v135->klass);
		    (**(void (***)(void))(*(_QWORD *)(v205 + 192) + 48LL))();
		  }
		  v138 = v135->klass;
		  if ( ((__int64)v138->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v138, static_fields);
		  paramValue_k__BackingField = hdplsAtlasHeight_k__BackingField->fields._paramValue_k__BackingField;
		  if ( paramValue_k__BackingField <= 256 )
		    paramValue_k__BackingField = 256;
		  LODWORD(m_AnimatedSprites->monitor) = paramValue_k__BackingField;
		  v140 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v140 = (__int64 (__fastcall *)(_QWORD))sub_180059EA0(
		                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    qword_18F370618 = (__int64)v140;
		  }
		  v141 = v140(24 * (int)hdplsRenderCount);
		  v223.m128_u64[0] = v141;
		  v142 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v142 = (__int64 (__fastcall *)(_QWORD))sub_180059EA0(
		                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    qword_18F370618 = (__int64)v142;
		  }
		  v224 = v142(4 * (int)hdplsRenderCount);
		  v143 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v143 = (__int64 (__fastcall *)(_QWORD))sub_180059EA0(
		                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    qword_18F370618 = (__int64)v143;
		  }
		  v144 = v143(8 * (int)hdplsRenderCount);
		  v145 = (Object *)this->fields.camera;
		  keya = v145;
		  v222 = v144;
		  if ( (int)hdplsRenderCount > 0 )
		  {
		    v225 = hdplsRenderCount;
		    v146 = 0LL;
		    v147 = v141;
		    v220 = v141;
		    while ( 1 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      hdplsCharacterHelpers = HG::Rendering::Runtime::HGCharacters::get_hdplsCharacterHelpers(0LL);
		      if ( !hdplsCharacterHelpers )
		        goto LABEL_318;
		      if ( v87 >= hdplsCharacterHelpers->fields._size )
		        goto LABEL_511;
		      klass = (int *)hdplsCharacterHelpers->fields._items;
		      if ( !klass )
		        goto LABEL_318;
		      if ( v87 >= klass[6] )
		        goto LABEL_345;
		      v149 = *(_QWORD *)&klass[2 * v87 + 8];
		      if ( !v149 )
		        goto LABEL_318;
		      klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (TileBase *)**((_QWORD **)klass + 23);
		      if ( !static_fields )
		        goto LABEL_318;
		      if ( SLODWORD(static_fields[1].klass) <= 2172 )
		        goto LABEL_288;
		      if ( !klass[56] )
		      {
		        il2cpp_runtime_class_init_1(klass);
		        klass = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      klass = (int *)**((_QWORD **)klass + 23);
		      if ( !klass )
		        goto LABEL_318;
		      if ( (unsigned int)klass[6] <= 0x87C )
		        goto LABEL_345;
		      if ( *((_QWORD *)klass + 2176) )
		      {
		        v206 = IFix::WrappersManagerImpl::GetPatch(2172, 0LL);
		        if ( !v206 )
		          goto LABEL_318;
		        v207 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(&v230, v206, (Object *)v149, v145, 0LL);
		        v153 = *(_OWORD *)&v207->m_Center.x;
		        v154 = *(_QWORD *)&v207->m_Extents.y;
		      }
		      else
		      {
		LABEL_288:
		        klass = (int *)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          klass = (int *)TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            klass = (int *)TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( !v145 )
		          goto LABEL_313;
		        if ( !klass[56] )
		          il2cpp_runtime_class_init_1(klass);
		        if ( !v145[1].klass )
		          goto LABEL_313;
		        v150 = *(Dictionary_2_System_Object_UnityEngine_Bounds_ **)(v149 + 104);
		        if ( !v150 )
		          goto LABEL_318;
		        v151 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		              + 4) )
		          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		        v152 = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		                 v150,
		                 keya,
		                 (MethodInfo *)v151->klass->rgctx_data[22].rgctxDataDummy);
		        if ( v152 < 0 )
		        {
		          v147 = v220;
		LABEL_313:
		          v153 = *(_OWORD *)(v149 + 136);
		          v154 = *(_QWORD *)(v149 + 152);
		          goto LABEL_300;
		        }
		        static_fields = (TileBase *)v150->fields._entries;
		        if ( !static_fields )
		          goto LABEL_318;
		        if ( (unsigned int)v152 >= LODWORD(static_fields[1].klass) )
		          goto LABEL_345;
		        v147 = v220;
		        v153 = *(_OWORD *)(&static_fields[2].klass + 5 * v152);
		        v154 = *((_QWORD *)&static_fields[2].fields._._.m_CachedPtr + 5 * v152);
		      }
		LABEL_300:
		      *(_OWORD *)v147 = v153;
		      *(_QWORD *)(v147 + 16) = v154;
		      HDPLSShadowEntities = HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSShadowEntities(
		                              (NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *)&v228,
		                              (HGCharacterHelper *)v149,
		                              this->fields.camera,
		                              0LL);
		      v156 = *(__m128i *)HDPLSShadowEntities;
		      m_Length = HDPLSShadowEntities->m_Length;
		      m_Buffer = HDPLSShadowEntities->m_Buffer;
		      *(_DWORD *)(v224 + 4 * v146) = m_Length;
		      if ( m_Length <= 0 )
		      {
		        v160 = 0LL;
		      }
		      else
		      {
		        v159 = (__int64 (__fastcall *)(_QWORD))qword_18F370618;
		        if ( !qword_18F370618 )
		        {
		          v159 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1(
		                                                   "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCS"
		                                                   "harp(System.Int64)");
		          if ( !v159 )
		          {
		            v208 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		            sub_18007E1B0(v208, 0LL);
		          }
		          qword_18F370618 = (__int64)v159;
		        }
		        v160 = v159(8 * m_Length);
		        v161 = (void (__fastcall *)(__int64, __int64, _QWORD))qword_18F36EF28;
		        v162 = 8 * m_Length;
		        if ( !qword_18F36EF28 )
		        {
		          v161 = (void (__fastcall *)(__int64, __int64, _QWORD))il2cpp_resolve_icall_1(
		                                                                  "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCp"
		                                                                  "y(System.Void*,System.Void*,System.Int64)");
		          if ( !v161 )
		          {
		            v209 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		            sub_18007E1B0(v209, 0LL);
		          }
		          qword_18F36EF28 = (__int64)v161;
		        }
		        v161(v160, v156.m128i_i64[0], v162);
		      }
		      *(_QWORD *)(v222 + 8 * v146) = v160;
		      v163 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose;
		      v164 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose->klass;
		      if ( ((__int64)v164->vtable[0].methodPtr & 1) == 0 )
		        sub_1800360B0(v164, static_fields);
		      if ( v156.m128i_i64[0] )
		      {
		        static_fields = (TileBase *)(unsigned int)_mm_cvtsi128_si32(_mm_srli_si128(v156, 12));
		        if ( !(_DWORD)static_fields )
		        {
		          v210 = sub_180035ED0(&TypeInfo::System::InvalidOperationException);
		          v211 = (SystemException *)sub_1800368D0(v210);
		          if ( v211 )
		          {
		            v212 = (String *)sub_180035ED0(&off_18E367388);
		            System::SystemException::SystemException(v211, v212, 0LL);
		            v211->fields._._HResult = -2146233079;
		            sub_18007E190(v211, v163);
		          }
		          goto LABEL_318;
		        }
		        if ( (int)static_fields > 1 )
		          Unity::Collections::LowLevel::Unsafe::UnsafeUtility::FreeTracked(
		            m_Buffer,
		            (Allocator__Enum)static_fields,
		            0LL);
		      }
		      ++v87;
		      v147 = v220 + 24;
		      ++v146;
		      v220 += 24LL;
		      if ( v146 >= v225 )
		      {
		        m_AnimatedSprites = v227.m_AnimatedSprites;
		        v144 = v222;
		        v141 = v223.m128_u64[0];
		        break;
		      }
		      v145 = keya;
		    }
		  }
		  klass = (int *)v224;
		  m_AnimatedSprites->max_length.value = v224;
		  m_AnimatedSprites->bounds = (Il2CppArrayBounds *)v141;
		  m_AnimatedSprites->vector[0] = (Sprite *)v144;
		LABEL_211:
		  *(_QWORD *)(v11 + 120) = m_AnimatedSprites;
		  *(_QWORD *)(v11 + 184) = 0LL;
		  v115 = this->fields.camera;
		  renderPathInstanceCPP = this->fields.renderPathInstanceCPP;
		  if ( !v115 )
		    goto LABEL_318;
		  m_CachedPtr = v115->fields._._._.m_CachedPtr;
		  v118 = (void (__fastcall *)(int64_t, __int64, void *, __int64, _QWORD))qword_18F370628;
		  if ( !qword_18F370628 )
		  {
		    v118 = (void (__fastcall *)(int64_t, __int64, void *, __int64, _QWORD))il2cpp_resolve_icall_1(
		                                                                             "UnityEngine.HyperGryphEngineCode.HGRenderGr"
		                                                                             "aphCPP::HGRenderPath_BeforeCulling(System.I"
		                                                                             "nt64,UnityEngine.HyperGryphEngineCode.HGRen"
		                                                                             "derPathBeforeCullingParamsCPP*,System.IntPt"
		                                                                             "r,System.IntPtr,System.IntPtr)");
		    if ( !v118 )
		    {
		      v213 = sub_1802EE1B8(
		               "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::HGRenderPath_BeforeCulling(System.Int64,UnityEngine.Hy"
		               "perGryphEngineCode.HGRenderPathBeforeCullingParamsCPP*,System.IntPtr,System.IntPtr,System.IntPtr)");
		      sub_18007E1B0(v213, 0LL);
		    }
		    qword_18F370628 = (__int64)v118;
		  }
		  v118(renderPathInstanceCPP, v11, m_CachedPtr, v226, 0LL);
		  return (HGRenderPathBeforeCullingParamsCPP *)v11;
		}
		
		internal void DoECSCullingCPP(HGSettingParameters settingParameters, bool needRenderTerrain, bool enableTerrainDeform, Transform curEnvCenter) {} // 0x00000001834502D0-0x00000001834503D0
		// Void DoECSCullingCPP(HGSettingParameters, Boolean, Boolean, Transform)
		void HG::Rendering::Runtime::HGCamera::DoECSCullingCPP(
		        HGCamera *this,
		        HGSettingParameters *settingParameters,
		        bool needRenderTerrain,
		        bool enableTerrainDeform,
		        Transform *curEnvCenter,
		        MethodInfo *method)
		{
		  void *beforeCullingParams; // rcx
		  __int64 v11; // r8
		  HGRenderPathBeforeCullingParamsCPP *v12; // rax
		  HGCamera *LightWeightCamera; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **((_QWORD **)beforeCullingParams + 23);
		  if ( !v11 )
		    goto LABEL_10;
		  if ( *(int *)(v11 + 24) > 854 )
		  {
		    if ( !*((_DWORD *)beforeCullingParams + 56) )
		    {
		      il2cpp_runtime_class_init_1(beforeCullingParams);
		      beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    beforeCullingParams = (void *)**((_QWORD **)beforeCullingParams + 23);
		    if ( !beforeCullingParams )
		      goto LABEL_10;
		    if ( *((_DWORD *)beforeCullingParams + 6) <= 0x356u )
		      sub_1800D2AB0(beforeCullingParams, settingParameters);
		    if ( *((_QWORD *)beforeCullingParams + 858) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(854, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_338(
		          Patch,
		          (Object *)this,
		          (Object *)settingParameters,
		          needRenderTerrain,
		          enableTerrainDeform,
		          (Object *)curEnvCenter,
		          0LL);
		        return;
		      }
		      goto LABEL_10;
		    }
		  }
		  v12 = HG::Rendering::Runtime::HGCamera::BeforeCullingCPP(
		          this,
		          settingParameters,
		          needRenderTerrain,
		          enableTerrainDeform,
		          curEnvCenter,
		          0LL);
		  this->fields.beforeCullingParams = v12;
		  if ( !v12 )
		    goto LABEL_10;
		  this->fields.cullingViewHandle = v12->cullingViewHandle;
		  this->fields.vtFeedbackViewId = v12->vtFeedbackViewId;
		  this->fields.subdivisionHandle = v12->subdivisionHandle;
		  LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
		  if ( !LightWeightCamera )
		    return;
		  beforeCullingParams = this->fields.beforeCullingParams;
		  if ( !beforeCullingParams )
		LABEL_10:
		    sub_1800D8260(beforeCullingParams, settingParameters);
		  LightWeightCamera->fields.cullingViewHandle = *((_DWORD *)beforeCullingParams + 91);
		}
		
		internal void DoECSCulling(HGSettingParameters settingParameters, ref HGRenderPipeline.HGCullingResults cullingResults) {} // 0x0000000189B721CC-0x0000000189B72A20
		// Void DoECSCulling(HGSettingParameters, HGRenderPipeline+HGCullingResults ByRef)
		void HG::Rendering::Runtime::HGCamera::DoECSCulling(
		        HGCamera *this,
		        HGSettingParameters *settingParameters,
		        HGRenderPipeline_HGCullingResults *cullingResults,
		        MethodInfo *method)
		{
		  Camera *camera; // rdx
		  Object_1 *v8; // rcx
		  Transform *transform; // rax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm7_8
		  float v12; // esi
		  Matrix4x4 *projectionMatrix; // rax
		  float v14; // xmm6_4
		  __m128 v15; // xmm6
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  float v18; // xmm6_4
		  float v19; // eax
		  float v20; // xmm6_4
		  float v21; // xmm8_4
		  float v22; // xmm6_4
		  float v23; // xmm0_4
		  float v24; // xmm7_4
		  bool useOcclusionCulling; // si
		  int32_t v26; // eax
		  Camera *v27; // rbx
		  uint64_t SceneCullingMaskFromCamera; // rax
		  int32_t cullingMask; // eax
		  unsigned int v30; // r14d
		  int v31; // ebx
		  int v32; // esi
		  Transform *v33; // rax
		  Vector3 *forward; // rax
		  float fieldOfView; // xmm0_4
		  float v36; // xmm9_4
		  float aspect; // xmm0_4
		  float v38; // xmm6_4
		  float v39; // xmm0_4
		  float farClipPlane; // xmm0_4
		  __int64 (__fastcall *v41)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD); // rax
		  HGCamera *LightWeightCamera; // rax
		  HGCamera *v43; // r14
		  Camera *v44; // rsi
		  Transform *v45; // rax
		  Vector3 *v46; // rax
		  __int64 v47; // xmm6_8
		  float v48; // ebx
		  Matrix4x4 *v49; // rax
		  __int128 v50; // xmm1
		  float v51; // xmm2_4
		  __int128 v52; // xmm0
		  unsigned int v53; // r12d
		  uint64_t v54; // r13
		  CameraType__Enum v55; // esi
		  __int64 (__fastcall *v56)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int); // rax
		  uint32_t v57; // ebx
		  Matrix4x4 *v58; // rax
		  __int128 v59; // xmm1
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  Vector3 *v62; // rax
		  __int64 v63; // xmm6_8
		  float v64; // r14d
		  int32_t v65; // esi
		  HGRenderPipelineSettingHub *v66; // rax
		  int32_t v67; // eax
		  Camera *v68; // rbx
		  uint64_t v69; // rax
		  __int64 v70; // rdx
		  Camera *v71; // rcx
		  uint64_t v72; // rbx
		  int32_t v73; // eax
		  __int128 v74; // xmm1
		  __int128 v75; // xmm0
		  uint32_t v76; // eax
		  uint32_t cullingViewHandle; // ebx
		  Matrix4x4 *cameraToWorldMatrix; // rax
		  __int128 v79; // xmm1
		  __int128 v80; // xmm0
		  __int128 v81; // xmm1
		  Vector3 *Position; // rax
		  __int64 v83; // xmm6_8
		  float z; // esi
		  int32_t InstanceID; // edi
		  HGRenderPipelineSettingHub *instance; // rax
		  int32_t currentDeviceTier; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned int v89; // [rsp+88h] [rbp-80h]
		  unsigned int v90; // [rsp+88h] [rbp-80h]
		  Vector3 v91; // [rsp+98h] [rbp-70h] BYREF
		  JobHandle v92; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v93; // [rsp+B8h] [rbp-50h] BYREF
		  uint32_t cullingViewUniqueID; // [rsp+C8h] [rbp-40h]
		  CameraType__Enum cameraType; // [rsp+CCh] [rbp-3Ch]
		  Matrix4x4 v96; // [rsp+D8h] [rbp-30h] BYREF
		  JobHandle v97; // [rsp+118h] [rbp+10h] BYREF
		  Matrix4x4 v98[2]; // [rsp+128h] [rbp+20h] BYREF
		
		  *(_QWORD *)&v93.x = 0LL;
		  v93.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(855, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(855, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(
		        Patch,
		        (Object *)this,
		        (Object *)settingParameters,
		        cullingResults,
		        0LL);
		      return;
		    }
		    goto LABEL_47;
		  }
		  if ( HG::Rendering::Runtime::HGCamera::IsUICamera(this, 0LL) )
		  {
		    camera = this->fields.camera;
		    cullingViewHandle = this->fields.cullingViewHandle;
		    if ( camera )
		    {
		      cameraToWorldMatrix = UnityEngine::Camera::get_cameraToWorldMatrix(v98, camera, 0LL);
		      v79 = *(_OWORD *)&cameraToWorldMatrix->m01;
		      *(_OWORD *)&v96.m00 = *(_OWORD *)&cameraToWorldMatrix->m00;
		      v80 = *(_OWORD *)&cameraToWorldMatrix->m02;
		      *(_OWORD *)&v96.m01 = v79;
		      v81 = *(_OWORD *)&cameraToWorldMatrix->m03;
		      *(_OWORD *)&v96.m02 = v80;
		      *(_OWORD *)&v96.m03 = v81;
		      Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v92, &v96, 0LL);
		      v8 = (Object_1 *)this->fields.camera;
		      v83 = *(_QWORD *)&Position->x;
		      z = Position->z;
		      if ( v8 )
		      {
		        InstanceID = UnityEngine::Object::GetInstanceID(v8, 0LL);
		        instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		        if ( instance )
		        {
		          currentDeviceTier = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(instance, 0LL);
		          *(_QWORD *)&v91.x = v83;
		          v91.z = z;
		          cullingResults->lightCullResult = *UnityEngine::HyperGryph::HGCullingSystem::CullLights(
		                                               (LightCullResult *)&v92,
		                                               cullingViewHandle,
		                                               &v91,
		                                               0x100u,
		                                               InstanceID,
		                                               currentDeviceTier,
		                                               0LL);
		          return;
		        }
		      }
		    }
		    goto LABEL_47;
		  }
		  this->fields.lodCrossFadeConfig.enableDither = 1;
		  v8 = (Object_1 *)this->fields.camera;
		  if ( !v8 )
		    goto LABEL_47;
		  this->fields.lodCrossFadeConfig.isOrtho = UnityEngine::Camera::get_orthographic((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  if ( !v8 )
		    goto LABEL_47;
		  transform = UnityEngine::Component::get_transform((Component *)v8, 0LL);
		  if ( !transform )
		    goto LABEL_47;
		  v10 = UnityEngine::Transform::get_position(&v91, transform, 0LL);
		  v11 = *(_QWORD *)&v10->x;
		  v12 = v10->z;
		  this->fields.lodCrossFadeConfig.enableDither &= !this->fields.prevTransformReset;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_47;
		  projectionMatrix = UnityEngine::Camera::get_projectionMatrix(v98, camera, 0LL);
		  if ( this->fields.lodCrossFadeConfig.isOrtho )
		  {
		    v8 = (Object_1 *)this->fields.camera;
		    if ( !v8 )
		      goto LABEL_47;
		    v14 = 1.0 / UnityEngine::Camera::get_orthographicSize((Camera *)v8, 0LL);
		  }
		  else
		  {
		    v15 = *(__m128 *)&projectionMatrix->m01;
		    v16 = *(_OWORD *)&projectionMatrix->m03;
		    *(_OWORD *)&v96.m00 = *(_OWORD *)&projectionMatrix->m00;
		    v17 = *(_OWORD *)&projectionMatrix->m02;
		    *(_OWORD *)&v96.m03 = v16;
		    *(_OWORD *)&v96.m02 = v17;
		    LODWORD(v14) = _mm_shuffle_ps(v15, v15, 85).m128_u32[0];
		  }
		  v18 = v14 * v14;
		  if ( !this->fields.lodCrossFadeConfig.enableDither )
		  {
		    *(_QWORD *)&this->fields.lodCrossFadeConfig.c0.x = v11;
		    this->fields.lodCrossFadeConfig.c0.z = v12;
		    *(_QWORD *)&this->fields.lodCrossFadeConfig.c1.x = v11;
		    this->fields.lodCrossFadeConfig.c1.z = v12;
		    this->fields.lodCrossFadeConfig.maxProjFactorSquared0 = v18;
		LABEL_15:
		    this->fields.lodCrossFadeConfig.maxProjFactorSquared1 = v18;
		    goto LABEL_16;
		  }
		  if ( UnityEngine::HyperGryph::HGLODStateSystem::IsCurrFrameTriggerTransition(0LL) )
		  {
		    v19 = this->fields.lodCrossFadeConfig.c1.z;
		    *(_QWORD *)&this->fields.lodCrossFadeConfig.c0.x = *(_QWORD *)&this->fields.lodCrossFadeConfig.c1.x;
		    this->fields.lodCrossFadeConfig.c0.z = v19;
		    *(_QWORD *)&this->fields.lodCrossFadeConfig.c1.x = v11;
		    this->fields.lodCrossFadeConfig.c1.z = v12;
		    this->fields.lodCrossFadeConfig.maxProjFactorSquared0 = this->fields.lodCrossFadeConfig.maxProjFactorSquared1;
		    goto LABEL_15;
		  }
		LABEL_16:
		  *(_QWORD *)&this->fields.lodCrossFadeConfig.cameraPosition.x = v11;
		  this->fields.lodCrossFadeConfig.cameraPosition.z = v12;
		  this->fields.lodCrossFadeConfig.currMaxProjFactorSquared = v18;
		  this->fields.lodCrossFadeConfig.fraction = UnityEngine::HyperGryph::HGLODStateSystem::GetLODTransitionFraction(0LL);
		  if ( !settingParameters )
		    goto LABEL_47;
		  v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._cullingViewScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v21 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._cullingViewScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		      * v20;
		  v22 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._ocScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v23 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._ocScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v8 = (Object_1 *)this->fields.camera;
		  v24 = v23 * v22;
		  if ( !v8 )
		    goto LABEL_47;
		  useOcclusionCulling = UnityEngine::Camera::get_useOcclusionCulling((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  if ( !v8 )
		    goto LABEL_47;
		  v26 = UnityEngine::Object::GetInstanceID(v8, 0LL);
		  v27 = this->fields.camera;
		  v89 = v26;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v27, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  *(_QWORD *)&v91.x = SceneCullingMaskFromCamera;
		  if ( !v8 )
		    goto LABEL_47;
		  cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  v30 = cullingMask;
		  if ( !v8 )
		    goto LABEL_47;
		  cameraType = UnityEngine::Camera::get_cameraType((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  cullingViewUniqueID = this->fields.cullingViewUniqueID;
		  v31 = useOcclusionCulling ? 0x140 : 0;
		  v32 = useOcclusionCulling ? 0xA0 : 0;
		  if ( !v8 )
		    goto LABEL_47;
		  v33 = UnityEngine::Component::get_transform((Component *)v8, 0LL);
		  if ( !v33 )
		    goto LABEL_47;
		  forward = UnityEngine::Transform::get_forward((Vector3 *)&v92, v33, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  v93 = *forward;
		  if ( !v8 )
		    goto LABEL_47;
		  fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  v36 = fieldOfView;
		  if ( !v8 )
		    goto LABEL_47;
		  aspect = UnityEngine::Camera::get_aspect((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  v38 = aspect;
		  if ( !v8 )
		    goto LABEL_47;
		  v39 = UnityEngine::Camera::get_nearClipPlane((Camera *)v8, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  if ( !v8 )
		    goto LABEL_47;
		  v92.jobGroup = __PAIR64__(LODWORD(v38), LODWORD(v36));
		  *(float *)&v92.jobType = v39;
		  farClipPlane = UnityEngine::Camera::get_farClipPlane((Camera *)v8, 0LL);
		  v41 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD))qword_18F3AB288;
		  *((float *)&v92.jobType + 1) = farClipPlane;
		  v97 = v92;
		  if ( !qword_18F3AB288 )
		  {
		    v41 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD))sub_180059EA0("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByMatrix(UnityEngine.Matrix4x4&,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
		    qword_18F3AB288 = (__int64)v41;
		  }
		  this->fields.cullingViewHandle = v41(
		                                     &this->fields.mainViewConstants.cullingMatrix,
		                                     v89,
		                                     *(_QWORD *)&v91.x,
		                                     v30,
		                                     0,
		                                     0,
		                                     &this->fields.lodCrossFadeConfig,
		                                     LODWORD(v21),
		                                     cameraType,
		                                     cullingViewUniqueID,
		                                     v31,
		                                     v32,
		                                     &v93,
		                                     &v97,
		                                     0,
		                                     LODWORD(v24));
		  LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
		  v43 = LightWeightCamera;
		  if ( LightWeightCamera )
		  {
		    v44 = LightWeightCamera->fields.camera;
		    if ( v44 )
		    {
		      v45 = UnityEngine::Component::get_transform((Component *)LightWeightCamera->fields.camera, 0LL);
		      if ( v45 )
		      {
		        v46 = UnityEngine::Transform::get_position((Vector3 *)&v92, v45, 0LL);
		        v47 = *(_QWORD *)&v46->x;
		        v48 = v46->z;
		        v49 = UnityEngine::Camera::get_projectionMatrix(v98, v44, 0LL);
		        v50 = *(_OWORD *)&v49->m03;
		        v51 = _mm_shuffle_ps(*(__m128 *)&v49->m01, *(__m128 *)&v49->m01, 85).m128_f32[0];
		        *(_OWORD *)&v96.m00 = *(_OWORD *)&v49->m00;
		        v52 = *(_OWORD *)&v49->m02;
		        v43->fields.lodCrossFadeConfig.enableDither = 0;
		        v43->fields.lodCrossFadeConfig.currMaxProjFactorSquared = v51 * v51;
		        *(_QWORD *)&v43->fields.lodCrossFadeConfig.cameraPosition.x = v47;
		        v43->fields.lodCrossFadeConfig.cameraPosition.z = v48;
		        *(_OWORD *)&v96.m02 = v52;
		        *(_OWORD *)&v96.m03 = v50;
		        v53 = UnityEngine::Object::GetInstanceID((Object_1 *)v44, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v54 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v44, 0LL);
		        v90 = UnityEngine::Camera::get_cullingMask(v44, 0LL);
		        v55 = UnityEngine::Camera::get_cameraType(v44, 0LL);
		        memset(&v93, 0, sizeof(v93));
		        v56 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int))qword_18F3AB288;
		        v97 = 0LL;
		        if ( !qword_18F3AB288 )
		        {
		          v56 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int))sub_180059EA0("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByMatrix(UnityEngine.Matrix4x4&,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
		          qword_18F3AB288 = (__int64)v56;
		        }
		        v43->fields.cullingViewHandle = v56(
		                                          &v43->fields.mainViewConstants.cullingMatrix,
		                                          v53,
		                                          v54,
		                                          v90,
		                                          0,
		                                          0,
		                                          &v43->fields.lodCrossFadeConfig,
		                                          0,
		                                          v55,
		                                          0,
		                                          0,
		                                          0,
		                                          &v93,
		                                          &v97,
		                                          0,
		                                          1028443341);
		        goto LABEL_35;
		      }
		    }
		LABEL_47:
		    sub_1800D8260(v8, camera);
		  }
		LABEL_35:
		  camera = this->fields.camera;
		  v57 = this->fields.cullingViewHandle;
		  if ( !camera )
		    goto LABEL_47;
		  v58 = UnityEngine::Camera::get_cameraToWorldMatrix(v98, camera, 0LL);
		  v59 = *(_OWORD *)&v58->m01;
		  *(_OWORD *)&v96.m00 = *(_OWORD *)&v58->m00;
		  v60 = *(_OWORD *)&v58->m02;
		  *(_OWORD *)&v96.m01 = v59;
		  v61 = *(_OWORD *)&v58->m03;
		  *(_OWORD *)&v96.m02 = v60;
		  *(_OWORD *)&v96.m03 = v61;
		  v62 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v92, &v96, 0LL);
		  v8 = (Object_1 *)this->fields.camera;
		  v63 = *(_QWORD *)&v62->x;
		  v64 = v62->z;
		  if ( !v8 )
		    goto LABEL_47;
		  v65 = UnityEngine::Object::GetInstanceID(v8, 0LL);
		  v66 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !v66 )
		    goto LABEL_47;
		  v67 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(v66, 0LL);
		  *(_QWORD *)&v91.x = v63;
		  v91.z = v64;
		  cullingResults->lightCullResult = *UnityEngine::HyperGryph::HGCullingSystem::CullLights(
		                                       (LightCullResult *)&v92,
		                                       v57,
		                                       &v91,
		                                       0x100u,
		                                       v65,
		                                       v67,
		                                       0LL);
		  UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		  this->fields.cullingJobHandle = *UnityEngine::HyperGryph::HGCullingSystem::GetCullingViewFence(
		                                     &v92,
		                                     this->fields.cullingViewHandle,
		                                     0LL);
		  if ( UnityEngine::SystemInfo::SupportsRayTracing(0LL) )
		  {
		    this->fields.lodCrossFadeConfig.enableDither = 0;
		    this->fields.lodCrossFadeConfig.lodBias = 0x80;
		    v68 = this->fields.camera;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v69 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v68, 0LL);
		    v71 = this->fields.camera;
		    v72 = v69;
		    if ( !v71 )
		      sub_1800D8260(0LL, v70);
		    v73 = UnityEngine::Camera::get_cullingMask(v71, 0LL);
		    v74 = *(_OWORD *)&this->fields.lodCrossFadeConfig.c0.y;
		    *(_OWORD *)&v96.m00 = *(_OWORD *)&this->fields.lodCrossFadeConfig.cameraPosition.x;
		    v75 = *(_OWORD *)&this->fields.lodCrossFadeConfig.c1.z;
		    *(_OWORD *)&v96.m01 = v74;
		    *(_QWORD *)&v74 = *(_QWORD *)&this->fields.lodCrossFadeConfig.maxProjFactorSquared1;
		    *(_OWORD *)&v96.m02 = v75;
		    *(_QWORD *)&v96.m03 = v74;
		    v76 = UnityEngine::HyperGryph::HGRayTracingScene::AddCullViewHandle(
		            v72,
		            v73,
		            0,
		            0,
		            (LODCrossFadeConfig *)&v96,
		            v21,
		            300.0,
		            0LL);
		    this->fields.rayTracingCullingViewHandle = v76;
		    this->fields.lodCrossFadeConfig.lodBias = 0;
		    this->fields.rayTracingTLASHandle = UnityEngine::HyperGryph::HGRayTracingScene::PrepareTLASCreationForCullView(
		                                          v76,
		                                          0LL);
		  }
		}
		
		internal void DoTerrainCulling(ScriptableRenderContext renderContext, HGRenderPipeline pipeline) {} // 0x0000000189B72A20-0x0000000189B72D60
		// Void DoTerrainCulling(ScriptableRenderContext, HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::DoTerrainCulling(
		        HGCamera *this,
		        ScriptableRenderContext renderContext,
		        HGRenderPipeline *pipeline,
		        MethodInfo *method)
		{
		  Transform *v7; // rdx
		  Camera *terrainLODFactor_k__BackingField; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  int m_CachedPtr; // r13d
		  Camera *camera; // r12
		  Vector2Int sceneRTSize_k__BackingField; // rdi
		  Matrix4x4 *cullingMatrix; // rax
		  __int128 v14; // xmm6
		  __int128 v15; // xmm7
		  __int128 v16; // xmm8
		  __int128 v17; // xmm9
		  Object_1 *currentEnvCenter; // rsi
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v21; // xmm0_8
		  Vector2Int v22; // rdi
		  Matrix4x4 *v23; // rax
		  __int128 v24; // xmm6
		  __int128 v25; // xmm7
		  __int128 v26; // xmm8
		  __int128 v27; // xmm9
		  uint32_t v28; // r12d
		  Object_1 *v29; // rsi
		  Transform *v30; // rax
		  Vector3 *v31; // rax
		  __int64 v32; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  uint32_t cullingViewHandle; // [rsp+58h] [rbp-B0h]
		  int32_t vtFeedbackViewId; // [rsp+58h] [rbp-B0h]
		  Vector3 v36; // [rsp+68h] [rbp-A0h] BYREF
		  Transform *v37; // [rsp+78h] [rbp-90h]
		  Vector3 v38; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v39; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 v40; // [rsp+D8h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(860, 0LL) )
		  {
		    if ( HG::Rendering::Runtime::HGCamera::IsUICamera(this, 0LL) )
		      return;
		    if ( pipeline )
		    {
		      settingParameters_k__BackingField = pipeline->fields._settingParameters_k__BackingField;
		      if ( settingParameters_k__BackingField )
		      {
		        terrainLODFactor_k__BackingField = (Camera *)settingParameters_k__BackingField->fields._terrainLODFactor_k__BackingField;
		        if ( terrainLODFactor_k__BackingField )
		        {
		          m_CachedPtr = (int)terrainLODFactor_k__BackingField[1].fields._._._.m_CachedPtr;
		          *(_QWORD *)&this->fields.vtFeedbackViewId = 0LL;
		          if ( !pipeline->fields.needRenderTerrain )
		          {
		            *(_QWORD *)&this->fields.terrainCullViewHandle = 0LL;
		            return;
		          }
		          camera = this->fields.camera;
		          sceneRTSize_k__BackingField = this->fields._sceneRTSize_k__BackingField;
		          v7 = (Transform *)camera;
		          if ( camera )
		          {
		            cullingMatrix = UnityEngine::Camera::get_cullingMatrix(&v39, camera, 0LL);
		            v14 = *(_OWORD *)&cullingMatrix->m00;
		            v15 = *(_OWORD *)&cullingMatrix->m01;
		            v16 = *(_OWORD *)&cullingMatrix->m02;
		            v17 = *(_OWORD *)&cullingMatrix->m03;
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            currentEnvCenter = (Object_1 *)pipeline->fields.currentEnvCenter;
		            cullingViewHandle = this->fields.cullingViewHandle;
		            LODWORD(v37) = this->fields.vtFeedbackViewId;
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Implicit(currentEnvCenter, 0LL) )
		            {
		              v7 = pipeline->fields.currentEnvCenter;
		              if ( !v7 )
		                goto LABEL_24;
		            }
		            else
		            {
		              terrainLODFactor_k__BackingField = this->fields.camera;
		              if ( !terrainLODFactor_k__BackingField )
		                goto LABEL_24;
		              transform = UnityEngine::Component::get_transform((Component *)terrainLODFactor_k__BackingField, 0LL);
		              if ( !transform )
		                goto LABEL_24;
		              v7 = transform;
		            }
		            position = UnityEngine::Transform::get_position(&v36, v7, 0LL);
		            v21 = *(_QWORD *)&position->x;
		            v38.z = position->z;
		            *(_QWORD *)&v38.x = v21;
		            *(_OWORD *)&v40.m00 = v14;
		            *(_OWORD *)&v40.m01 = v15;
		            *(_OWORD *)&v40.m02 = v16;
		            *(_OWORD *)&v40.m03 = v17;
		            this->fields.terrainCullViewHandle = UnityEngine::HyperGryph::HGTerrainManager::CullTerrainAndUpdateVTFeedbackView(
		                                                   camera,
		                                                   sceneRTSize_k__BackingField,
		                                                   &v40,
		                                                   (float)m_CachedPtr,
		                                                   1,
		                                                   renderContext.m_Ptr,
		                                                   cullingViewHandle,
		                                                   (int32_t)v37,
		                                                   &v38,
		                                                   0LL);
		            v22 = this->fields._sceneRTSize_k__BackingField;
		            v37 = (Transform *)this->fields.camera;
		            v7 = v37;
		            if ( v37 )
		            {
		              v23 = UnityEngine::Camera::get_cullingMatrix(&v39, (Camera *)v37, 0LL);
		              v24 = *(_OWORD *)&v23->m00;
		              v25 = *(_OWORD *)&v23->m01;
		              v26 = *(_OWORD *)&v23->m02;
		              v27 = *(_OWORD *)&v23->m03;
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              v28 = this->fields.cullingViewHandle;
		              v29 = (Object_1 *)pipeline->fields.currentEnvCenter;
		              vtFeedbackViewId = this->fields.vtFeedbackViewId;
		              sub_1800036A0(TypeInfo::UnityEngine::Object);
		              if ( UnityEngine::Object::op_Implicit(v29, 0LL) )
		              {
		                v7 = pipeline->fields.currentEnvCenter;
		                if ( v7 )
		                  goto LABEL_22;
		              }
		              else
		              {
		                terrainLODFactor_k__BackingField = this->fields.camera;
		                if ( terrainLODFactor_k__BackingField )
		                {
		                  v30 = UnityEngine::Component::get_transform((Component *)terrainLODFactor_k__BackingField, 0LL);
		                  if ( v30 )
		                  {
		                    v7 = v30;
		LABEL_22:
		                    v31 = UnityEngine::Transform::get_position(&v36, v7, 0LL);
		                    v32 = *(_QWORD *)&v31->x;
		                    v36.z = v31->z;
		                    *(_QWORD *)&v36.x = v32;
		                    *(_OWORD *)&v39.m00 = v24;
		                    *(_OWORD *)&v39.m01 = v25;
		                    *(_OWORD *)&v39.m02 = v26;
		                    *(_OWORD *)&v39.m03 = v27;
		                    this->fields.editorTerrainCullViewHandle = UnityEngine::HyperGryph::HGEditorTerrainManager::CullTerrainAndUpdateVTFeedbackView(
		                                                                 (Camera *)v37,
		                                                                 v22,
		                                                                 &v39,
		                                                                 (float)m_CachedPtr,
		                                                                 1,
		                                                                 renderContext.m_Ptr,
		                                                                 v28,
		                                                                 vtFeedbackViewId,
		                                                                 &v36,
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
		LABEL_24:
		    sub_1800D8260(terrainLODFactor_k__BackingField, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(860, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, renderContext, (Object *)pipeline, 0LL);
		}
		
		internal void DoWaterCulling(bool useAnchorSH) {} // 0x000000018344C370-0x000000018344C630
		// Void DoWaterCulling(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCamera::DoWaterCulling(HGCamera *this, bool useAnchorSH, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Camera *camera; // r14
		  uint32_t cullingViewHandle; // r15d
		  __int64 (__fastcall *v9)(Camera *); // rax
		  __int64 v10; // r14
		  void (__fastcall *v11)(__int64, __int64 *); // rax
		  __int64 v12; // r9
		  void (__fastcall *v13)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *); // rax
		  void (__fastcall *v14)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int); // rax
		  uint32_t v15; // edi
		  __int128 v16; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rax
		  int v19; // [rsp+20h] [rbp-118h]
		  __int64 v20; // [rsp+40h] [rbp-F8h] BYREF
		  int v21; // [rsp+48h] [rbp-F0h]
		  __int64 v22; // [rsp+50h] [rbp-E8h] BYREF
		  int v23; // [rsp+58h] [rbp-E0h]
		  __int128 v24; // [rsp+60h] [rbp-D8h]
		  __int128 v25; // [rsp+70h] [rbp-C8h]
		  __int128 v26; // [rsp+80h] [rbp-B8h]
		  __int128 v27; // [rsp+90h] [rbp-A8h]
		  _OWORD v28[4]; // [rsp+A0h] [rbp-98h] BYREF
		  _OWORD v29[4]; // [rsp+E0h] [rbp-58h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_17;
		  if ( wrapperArray->max_length.size > 864 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_17;
		    if ( LODWORD(v5->_0.namespaze) <= 0x360 )
		      sub_1800D2AB0(v5, useAnchorSH);
		    if ( v5[18].interfaceOffsets )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(864, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		          (ILFixDynamicMethodWrapper_18 *)Patch,
		          (Object *)this,
		          useAnchorSH,
		          0LL);
		        return;
		      }
		LABEL_17:
		      sub_1800D8260(v5, useAnchorSH);
		    }
		  }
		  if ( this->fields.cullingViewHandle == -1 )
		  {
		    this->fields.waterProxyCullHandle = -1;
		    this->fields.waterProxyVisibleCount = 0;
		    this->fields.waterDecalVisibleCount = 0;
		    this->fields.waterDecalCullHandle = -1;
		    return;
		  }
		  camera = this->fields.camera;
		  cullingViewHandle = this->fields.cullingViewHandle;
		  v24 = *(_OWORD *)&this->fields.waterCullingMatrix.m00;
		  v25 = *(_OWORD *)&this->fields.waterCullingMatrix.m01;
		  v26 = *(_OWORD *)&this->fields.waterCullingMatrix.m02;
		  v27 = *(_OWORD *)&this->fields.waterCullingMatrix.m03;
		  if ( !camera )
		    goto LABEL_17;
		  v9 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v9 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		    qword_18F36FBC0 = (__int64)v9;
		  }
		  v10 = v9(camera);
		  if ( !v10 )
		    goto LABEL_17;
		  v20 = 0LL;
		  v21 = 0;
		  v11 = (void (__fastcall *)(__int64, __int64 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v11 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v11 )
		    {
		      v18 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v18, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v11;
		  }
		  v11(v10, &v20);
		  v22 = v20;
		  v23 = v21;
		  v13 = (void (__fastcall *)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *))qword_18F370A68;
		  v28[0] = v24;
		  v28[1] = v25;
		  v28[2] = v26;
		  v28[3] = v27;
		  if ( !qword_18F370A68 )
		  {
		    v13 = (void (__fastcall *)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *))sub_180059EA0("UnityEngine.HyperGryph.HGWaterRender::CullWaterProxy_Injected(System.UInt32,UnityEngine.Matrix4x4&,System.UInt32,System.Boolean,System.UInt32&,System.UInt32&,System.Boolean,UnityEngine.Vector3&)");
		    qword_18F370A68 = (__int64)v13;
		  }
		  LOBYTE(v12) = 1;
		  v13(
		    cullingViewHandle,
		    v28,
		    3LL,
		    v12,
		    &this->fields.waterProxyVisibleCount,
		    &this->fields.waterProxyCullHandle,
		    1,
		    &v22);
		  v14 = (void (__fastcall *)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int))qword_18F370A70;
		  v15 = this->fields.cullingViewHandle;
		  v29[0] = *(_OWORD *)&this->fields.waterCullingMatrix.m00;
		  v16 = *(_OWORD *)&this->fields.waterCullingMatrix.m02;
		  v29[1] = *(_OWORD *)&this->fields.waterCullingMatrix.m01;
		  v29[2] = v16;
		  v29[3] = *(_OWORD *)&this->fields.waterCullingMatrix.m03;
		  if ( !qword_18F370A70 )
		  {
		    v14 = (void (__fastcall *)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int))sub_180059EA0(
		                                                                                "UnityEngine.HyperGryph.HGWaterRender::Cu"
		                                                                                "llWaterDecals_Injected(System.UInt32,Uni"
		                                                                                "tyEngine.Matrix4x4&,System.UInt32&,Syste"
		                                                                                "m.UInt32&,System.Boolean)");
		    qword_18F370A70 = (__int64)v14;
		  }
		  LOBYTE(v19) = useAnchorSH;
		  v14(v15, v29, &this->fields.waterDecalVisibleCount, &this->fields.waterDecalCullHandle, v19);
		}
		
		internal void ReflectionProbeUpdate(int octTextureSize, int textureArrayCount, bool reflectionProbeUseRGBAHalf, bool renderGraphEnableCppRenderPath) {} // 0x0000000183444D80-0x0000000183445010
		// Void ReflectionProbeUpdate(Int32, Int32, Boolean, Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCamera::ReflectionProbeUpdate(
		        HGCamera *this,
		        int32_t octTextureSize,
		        int32_t textureArrayCount,
		        bool reflectionProbeUseRGBAHalf,
		        bool renderGraphEnableCppRenderPath,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *QUALITY_VISIBLE_COUNT; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  struct ReflectionProbeBinningPassSetting__Class *v12; // rax
		  int32_t v13; // eax
		  int32_t v14; // esi
		  bool v15; // al
		  Camera *camera; // rdi
		  __int64 (__fastcall *v17)(Camera *); // rax
		  __int64 v18; // rdi
		  void (__fastcall *v19)(__int64, __int64 *); // rax
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  uint32_t reflectionProbeViewHandle; // ebx
		  void (__fastcall *v24)(_QWORD, __int64 *, __int64 *, _QWORD); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rax
		  __int64 v27; // rax
		  __int64 v28; // rax
		  __int64 v29; // [rsp+40h] [rbp-38h] BYREF
		  int v30; // [rsp+48h] [rbp-30h]
		  __int64 v31; // [rsp+50h] [rbp-28h] BYREF
		  float z; // [rsp+58h] [rbp-20h]
		  __int64 v33; // [rsp+60h] [rbp-18h] BYREF
		  int v34; // [rsp+68h] [rbp-10h]
		
		  QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = QUALITY_VISIBLE_COUNT->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_32;
		  if ( wrapperArray->max_length.size <= 868 )
		    goto LABEL_5;
		  if ( !QUALITY_VISIBLE_COUNT->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(QUALITY_VISIBLE_COUNT);
		    QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  QUALITY_VISIBLE_COUNT = (struct ILFixDynamicMethodWrapper_2__Class *)QUALITY_VISIBLE_COUNT->static_fields->wrapperArray;
		  if ( !QUALITY_VISIBLE_COUNT )
		LABEL_32:
		    sub_1800D8260(QUALITY_VISIBLE_COUNT, *(_QWORD *)&octTextureSize);
		  if ( LODWORD(QUALITY_VISIBLE_COUNT->_0.namespaze) <= 0x364 )
		    sub_1800D2AB0(QUALITY_VISIBLE_COUNT, *(_QWORD *)&octTextureSize);
		  if ( QUALITY_VISIBLE_COUNT[18]._1.unity_user_data )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(868, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_342(
		        Patch,
		        (Object *)this,
		        octTextureSize,
		        textureArrayCount,
		        reflectionProbeUseRGBAHalf,
		        renderGraphEnableCppRenderPath,
		        0LL);
		      return;
		    }
		    goto LABEL_32;
		  }
		LABEL_5:
		  if ( !this->fields.reflectionProbeViewHandle )
		    this->fields.reflectionProbeViewHandle = UnityEngine::HyperGryph::HGReflectionProbe::AddView(
		                                               this->fields.camera,
		                                               0LL);
		  v12 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting;
		  if ( !TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting);
		    v12 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting;
		  }
		  QUALITY_VISIBLE_COUNT = (struct ILFixDynamicMethodWrapper_2__Class *)v12->static_fields->QUALITY_VISIBLE_COUNT;
		  v13 = 32;
		  if ( (int)QUALITY_VISIBLE_COUNT < 32 )
		    v13 = (int)QUALITY_VISIBLE_COUNT;
		  if ( textureArrayCount < 1 )
		  {
		    textureArrayCount = 1;
		  }
		  else if ( textureArrayCount > v13 )
		  {
		    textureArrayCount = v13;
		  }
		  if ( reflectionProbeUseRGBAHalf )
		    v14 = 48;
		  else
		    v14 = 74;
		  if ( octTextureSize == this->fields.reflectionProbeOctTextureSize
		    && v14 == this->fields.reflectionProbeOctTextureFormat
		    && this->fields.preivousEnableCppRenderPath == renderGraphEnableCppRenderPath
		    && textureArrayCount == this->fields.reflectionProbeOctTextureArrayCount )
		  {
		    v15 = 0;
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGReflectionProbe::SetViewTextureArrayCount(
		      this->fields.reflectionProbeViewHandle,
		      textureArrayCount,
		      0LL);
		    UnityEngine::HyperGryph::HGReflectionProbe::ResetView(this->fields.reflectionProbeViewHandle, 0LL);
		    v15 = 1;
		    this->fields.reflectionProbeOctTextureSize = octTextureSize;
		    this->fields.reflectionProbeOctTextureFormat = v14;
		    this->fields.reflectionProbeOctTextureArrayCount = textureArrayCount;
		  }
		  this->fields.reflectionProbeReset = v15;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_32;
		  v17 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v17 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v17 )
		    {
		      v26 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v26, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v17;
		  }
		  v18 = v17(camera);
		  if ( !v18 )
		    goto LABEL_32;
		  v29 = 0LL;
		  v30 = 0;
		  v19 = (void (__fastcall *)(__int64, __int64 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v19 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v19 )
		    {
		      v27 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v27, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v19;
		  }
		  v19(v18, &v29);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(this, 0LL);
		  if ( !InterpolatedPhase )
		    sub_1800D8260(v22, v21);
		  reflectionProbeViewHandle = this->fields.reflectionProbeViewHandle;
		  v31 = *(_QWORD *)&InterpolatedPhase->fields.skyConfig.visibleBox.x;
		  z = InterpolatedPhase->fields.skyConfig.visibleBox.z;
		  v34 = v30;
		  v24 = (void (__fastcall *)(_QWORD, __int64 *, __int64 *, _QWORD))qword_18F370968;
		  v33 = v29;
		  if ( !qword_18F370968 )
		  {
		    v24 = (void (__fastcall *)(_QWORD, __int64 *, __int64 *, _QWORD))il2cpp_resolve_icall_1(
		                                                                       "UnityEngine.HyperGryph.HGReflectionProbe::UpdateV"
		                                                                       "iewPhase0_Injected(System.UInt32,UnityEngine.Vect"
		                                                                       "or3&,UnityEngine.Vector3&,System.Boolean)");
		    if ( !v24 )
		    {
		      v28 = sub_1802EE1B8(
		              "UnityEngine.HyperGryph.HGReflectionProbe::UpdateViewPhase0_Injected(System.UInt32,UnityEngine.Vector3&,Uni"
		              "tyEngine.Vector3&,System.Boolean)");
		      sub_18007E1B0(v28, 0LL);
		    }
		    qword_18F370968 = (__int64)v24;
		  }
		  v24(reflectionProbeViewHandle, &v33, &v31, 0LL);
		}
		
		internal bool ShouldRenderWater() => default; // 0x00000001831CB2E0-0x00000001831CB3A0
		// Boolean ShouldRenderWater()
		bool HG::Rendering::Runtime::HGCamera::ShouldRenderWater(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *waterManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGManagerContext *currentManagerContext; // rax
		  bool v6; // di
		  Camera *camera; // rbx
		  __int64 (__fastcall *v8)(Camera *); // rax
		  char v9; // al
		  bool v10; // dl
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rax
		
		  waterManager_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    waterManager_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = waterManager_k__BackingField->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size <= 1001 )
		    goto LABEL_5;
		  if ( !waterManager_k__BackingField->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(waterManager_k__BackingField);
		    waterManager_k__BackingField = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  waterManager_k__BackingField = (struct ILFixDynamicMethodWrapper_2__Class *)waterManager_k__BackingField->static_fields->wrapperArray;
		  if ( !waterManager_k__BackingField )
		LABEL_15:
		    sub_1800D8260(waterManager_k__BackingField, wrapperArray);
		  if ( LODWORD(waterManager_k__BackingField->_0.namespaze) <= 0x3E9 )
		    sub_1800D2AB0(waterManager_k__BackingField, wrapperArray);
		  if ( waterManager_k__BackingField[21]._0.properties )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1001, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_15;
		  }
		LABEL_5:
		  currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		  if ( !currentManagerContext )
		    goto LABEL_15;
		  waterManager_k__BackingField = (struct ILFixDynamicMethodWrapper_2__Class *)currentManagerContext->fields._waterManager_k__BackingField;
		  if ( !waterManager_k__BackingField )
		    goto LABEL_15;
		  v6 = HG::Rendering::Runtime::HGWaterManager::get_shouldRender((HGWaterManager *)waterManager_k__BackingField, 0LL)
		    && this->fields.waterProxyVisibleCount != 0;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_15;
		  v8 = (__int64 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v8 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v8 )
		    {
		      v13 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v13, 0LL);
		    }
		    qword_18F36F100 = (__int64)v8;
		  }
		  v9 = v8(camera);
		  v10 = 0;
		  if ( !v9 )
		    return v6;
		  return v10;
		}
		
		internal bool ShouldRenderWaterUnlit() => default; // 0x0000000183EFAAE0-0x0000000183EFAB40
		// Boolean ShouldRenderWaterUnlit()
		bool HG::Rendering::Runtime::HGCamera::ShouldRenderWaterUnlit(HGCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1049 )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x419 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[22]._0.methods )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1049, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal void Update(FrameSettings currentFrameSettings, HGRenderPipeline hgrp, bool allocateHistoryBuffers = true /* Metadata: 0x023038B8 */) {} // 0x0000000183100120-0x0000000183101A30
		// Void Update(FrameSettings, HGRenderPipeline, Boolean)
		void HG::Rendering::Runtime::HGCamera::Update(
		        HGCamera *this,
		        FrameSettings *currentFrameSettings,
		        HGRenderPipeline *hgrp,
		        bool allocateHistoryBuffers,
		        MethodInfo *method)
		{
		  Object *v5; // r12
		  unsigned __int64 settingParameters_k__BackingField; // rcx
		  int *wrapperArray; // rdx
		  Camera *m_parentCamera; // rbx
		  struct Object_1__Class *v13; // rcx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  unsigned int hgRenderPath; // edi
		  uint32_t v16; // r13d
		  __int64 (*v17)(void); // rax
		  unsigned int v18; // ebx
		  unsigned __int8 (__fastcall *v19)(_QWORD, __int64); // rax
		  struct ILFixDynamicMethodWrapper_2__Class *v20; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v21; // rdx
		  HGRenderPathBase *renderPathInstance_k__BackingField; // rbx
		  int32_t renderPath_k__BackingField; // eax
		  HGRenderPipeline_HGResolutionSettings *resolutionSettings; // rax
		  Camera *camera; // rbx
		  __int64 (__fastcall *v26)(Camera *); // rax
		  Camera *v27; // r15
		  HGCamera *v28; // r14
		  HGAdditionalCameraData *v29; // rax
		  int32_t v30; // edi
		  __int64 (*v31)(void); // rax
		  unsigned int v32; // ebx
		  unsigned __int8 (__fastcall *v33)(_QWORD, __int64); // rax
		  struct ILFixDynamicMethodWrapper_2__Class *v34; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v35; // rdx
		  HGRenderPathBase *v36; // rbx
		  int32_t v37; // eax
		  HGRenderPipeline_HGResolutionSettings *v38; // rax
		  HGAdditionalCameraData *v39; // rbx
		  HGAdditionalCameraData *v40; // rax
		  float materialMipBias; // xmm0_4
		  __int64 v42; // xmm1_8
		  Rect value; // xmm2
		  __m128 v44; // xmm7
		  __m128 v45; // xmm7
		  __m128 v46; // xmm7
		  __m128 v47; // xmm7
		  float v48; // xmm6_4
		  int32_t v49; // ecx
		  int32_t m_Height; // ecx
		  __int64 v51; // rax
		  Func_2_Google_Protobuf_IMessage_Object_ *getValueDelegate; // rdi
		  Camera *v53; // rbx
		  unsigned int (__fastcall *v54)(Camera *); // rax
		  __int64 v55; // rax
		  __int64 v56; // r13
		  SingleFieldAccessor__Class *klass; // rbx
		  float globalMipBias_k__BackingField; // xmm6_4
		  __int64 v59; // rax
		  float v60; // xmm1_4
		  __int64 v61; // rax
		  float lowResScale; // xmm6_4
		  __int64 v63; // rbx
		  HGSettingParameters *v64; // rbx
		  int32_t actualHeight_k__BackingField; // eax
		  __int64 klass_low; // rdx
		  SingleFieldAccessor__Class *v67; // rax
		  __m128 v68; // xmm4
		  __m128 v69; // xmm4
		  __m128 v70; // xmm4
		  int32_t v71; // eax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  int32_t actualWidth_k__BackingField; // ebx
		  int32_t v75; // eax
		  int32_t v76; // ecx
		  signed int v77; // ebx
		  SingleFieldAccessor__Class *v78; // rax
		  __m128 v79; // xmm4
		  __m128 v80; // xmm4
		  __m128 v81; // xmm4
		  void (__fastcall *v82)(Camera *, Matrix4x4 *); // rax
		  Matrix4x4 *v83; // rax
		  __int64 v84; // rdx
		  __int128 v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  void (__fastcall *v88)(__int128 *, __int64, FieldDescriptor **); // rax
		  void (__fastcall *v89)(Camera *, Matrix4x4 *); // rax
		  void (__fastcall *v90)(Camera *, __int128 *); // rax
		  __int128 v91; // xmm1
		  __int128 v92; // xmm0
		  __int128 v93; // xmm1
		  void (__fastcall *v94)(__int128 *, Matrix4x4 *); // rax
		  __int128 v95; // xmm6
		  void (__fastcall *v96)(__int128 *, FieldDescriptor **); // rax
		  __int128 v97; // xmm8
		  __int128 v98; // xmm9
		  __int128 v99; // xmm10
		  __int128 v100; // xmm1
		  __int128 v101; // xmm0
		  __int128 v102; // xmm1
		  void (__fastcall *v103)(Camera *, __int128 *); // rax
		  __int128 v104; // xmm1
		  __int128 v105; // xmm0
		  __int128 v106; // xmm1
		  void (__fastcall *v107)(__int128 *, __int128 *, FieldDescriptor **); // rax
		  void (__fastcall *v108)(Matrix4x4 *, Matrix4x4 *, __int128 *); // rax
		  __int128 v109; // xmm1
		  __int128 v110; // xmm0
		  __int128 v111; // xmm1
		  void (__fastcall *v112)(__int128 *, FieldDescriptor **); // rax
		  __int128 v113; // xmm1
		  __int128 v114; // xmm0
		  __int128 v115; // xmm1
		  __int128 v116; // xmm1
		  __int128 v117; // xmm1
		  __int64 (__fastcall *v118)(Camera *); // rax
		  __int128 v119; // xmm1
		  __int128 v120; // xmm0
		  __int128 v121; // xmm1
		  __int128 v122; // xmm1
		  __int128 v123; // xmm2
		  __int128 v124; // xmm3
		  __int128 v125; // xmm1
		  __int128 v126; // xmm2
		  __int128 v127; // xmm3
		  __int128 v128; // xmm1
		  __int128 v129; // xmm2
		  __int128 v130; // xmm3
		  __int64 v131; // rbx
		  void (__fastcall *v132)(__int64, SingleFieldAccessor *); // rax
		  float v133; // eax
		  Matrix4x4 *HGCameraCullingMatrix; // rax
		  __int128 v135; // xmm1
		  __int128 v136; // xmm2
		  __int128 v137; // xmm3
		  __m128 v138; // xmm4
		  int32_t v139; // ebx
		  __m128 v140; // xmm4
		  __m128 v141; // xmm4
		  __m128 v142; // xmm4
		  int32_t m_antialiasingMode; // eax
		  int32_t v144; // eax
		  int32_t v145; // eax
		  int32_t v146; // eax
		  bool v147; // al
		  PropertyInfo_1 *v148; // r8
		  Int32__Array **v149; // r9
		  Camera *v150; // rbx
		  double (__fastcall *v151)(Camera *); // rax
		  double v152; // xmm0_8
		  float v153; // xmm6_4
		  bool v154; // zf
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  HGDepthOfField *m_depthOfField; // rbx
		  HGCamera_VolumeComponentsData *v157; // rbx
		  Camera *v158; // rdi
		  Type *v159; // rdx
		  PropertyInfo_1 *v160; // r8
		  Int32__Array **v161; // r9
		  Type *v162; // rdx
		  PropertyInfo_1 *v163; // r8
		  Type *v164; // rdx
		  PropertyInfo_1 *v165; // r8
		  Int32__Array **v166; // r9
		  HGRenderPathBase *v167; // rbx
		  HGRenderGraph *renderGraph; // rax
		  HGRenderPipeline *v169; // rbx
		  Type *v170; // rdx
		  PropertyInfo_1 *v171; // r8
		  Int32__Array **v172; // r9
		  Type *v173; // rdx
		  PropertyInfo_1 *v174; // r8
		  Type *v175; // rdx
		  PropertyInfo_1 *v176; // r8
		  Int32__Array **v177; // r9
		  __int64 v178; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v180; // xmm1_8
		  __int64 v181; // rax
		  ILFixDynamicMethodWrapper_2 *v182; // rax
		  HGAdditionalCameraData_AntialiasingMode__Enum v183; // edx
		  SettingParameter_1_System_Boolean_ *v184; // rax
		  ILFixDynamicMethodWrapper_2 *v185; // rax
		  SettingParameter_1_System_Boolean_ *v186; // rax
		  ILFixDynamicMethodWrapper_2 *v187; // rax
		  __int64 v188; // rax
		  __int64 v189; // rax
		  ILFixDynamicMethodWrapper_2 *v190; // rax
		  ILFixDynamicMethodWrapper_2 *v191; // rax
		  __int64 v192; // rax
		  __int64 v193; // r8
		  ILFixDynamicMethodWrapper_2 *v194; // rax
		  int32_t v195; // eax
		  ILFixDynamicMethodWrapper_2 *v196; // rax
		  __int64 v197; // rax
		  __int64 v198; // rax
		  ILFixDynamicMethodWrapper_2 *v199; // rax
		  ILFixDynamicMethodWrapper_2 *v200; // rax
		  HGRenderPathBase *v201; // rdi
		  HGRenderGraph *v202; // rax
		  ILFixDynamicMethodWrapper_2 *v203; // rax
		  Rect v204; // xmm7
		  Rect v205; // xmm8
		  int32_t pixelWidth; // eax
		  __m128 v207; // xmm7
		  __m128 v208; // xmm7
		  ILFixDynamicMethodWrapper_2 *v209; // rax
		  __int64 v210; // rax
		  float v211; // xmm8_4
		  MethodInfo *v212; // r9
		  float v213; // xmm0_4
		  __int64 v214; // rax
		  __int64 v215; // rax
		  __int64 v216; // rax
		  __int64 v217; // rax
		  __int64 v218; // rax
		  __int64 v219; // rax
		  __int64 v220; // rax
		  __int64 v221; // rax
		  __int64 v222; // rax
		  __int64 v223; // rax
		  __int64 v224; // rax
		  ILFixDynamicMethodWrapper_2 *v225; // rax
		  ILFixDynamicMethodWrapper_2 *v226; // rax
		  ILFixDynamicMethodWrapper_2 *v227; // rax
		  ILFixDynamicMethodWrapper_2 *v228; // rax
		  int v229; // ecx
		  int v230; // ecx
		  int v231; // ecx
		  ILFixDynamicMethodWrapper_2 *v232; // rax
		  int v233; // ecx
		  int v234; // ecx
		  int v235; // ecx
		  ILFixDynamicMethodWrapper_2 *v236; // rax
		  ILFixDynamicMethodWrapper_2 *v237; // rax
		  __int64 v238; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-E0h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-E0h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-E0h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-E0h]
		  MethodInfo *methode; // [rsp+20h] [rbp-E0h]
		  SingleFieldAccessor size; // [rsp+30h] [rbp-D0h] BYREF
		  __int128 v245; // [rsp+68h] [rbp-98h]
		  __int128 v246; // [rsp+78h] [rbp-88h]
		  Matrix4x4 v247; // [rsp+90h] [rbp-70h] BYREF
		  __int128 v248; // [rsp+D0h] [rbp-30h] BYREF
		  __int128 v249; // [rsp+E0h] [rbp-20h]
		  __int128 v250; // [rsp+F0h] [rbp-10h]
		  __int128 v251; // [rsp+100h] [rbp+0h]
		  FrameSettings v252; // [rsp+110h] [rbp+10h] BYREF
		  __int128 v253; // [rsp+130h] [rbp+30h] BYREF
		  __int128 v254; // [rsp+140h] [rbp+40h]
		  __int128 v255; // [rsp+150h] [rbp+50h]
		  __int128 v256; // [rsp+160h] [rbp+60h]
		  Matrix4x4 v257; // [rsp+170h] [rbp+70h] BYREF
		  __int128 v258; // [rsp+1B0h] [rbp+B0h] BYREF
		  __int128 v259; // [rsp+1C0h] [rbp+C0h]
		  __int128 v260; // [rsp+1D0h] [rbp+D0h]
		  __int128 v261; // [rsp+1E0h] [rbp+E0h]
		  Matrix4x4 v262; // [rsp+1F0h] [rbp+F0h] BYREF
		
		  v5 = 0LL;
		  size.fields._.getValueDelegate = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] > 696 )
		  {
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v178 = *(_QWORD *)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_209;
		    if ( *(_DWORD *)(v178 + 24) <= 0x2B8u )
		      goto LABEL_490;
		    if ( *(_QWORD *)(v178 + 5600) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(696, 0LL);
		      if ( Patch )
		      {
		        v180 = *(_QWORD *)&currentFrameSettings->materialQuality;
		        v252.bitDatas = currentFrameSettings->bitDatas;
		        *(_QWORD *)&v252.materialQuality = v180;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_309(
		          Patch,
		          (Object *)this,
		          &v252,
		          (Object *)hgrp,
		          allocateHistoryBuffers,
		          0LL);
		        return;
		      }
		      goto LABEL_209;
		    }
		  }
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 697 )
		    goto LABEL_9;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v181 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_209;
		  if ( *(_DWORD *)(v181 + 24) <= 0x2B9u )
		    goto LABEL_490;
		  if ( *(_QWORD *)(v181 + 5608) )
		  {
		    v182 = IFix::WrappersManagerImpl::GetPatch(697, 0LL);
		    if ( !v182 )
		      goto LABEL_209;
		    m_parentCamera = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_276(v182, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_9:
		    m_parentCamera = this->fields.m_parentCamera;
		  }
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
		  if ( m_parentCamera )
		  {
		    if ( !v13->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v13);
		    if ( m_parentCamera->fields._._._.m_CachedPtr )
		      HG::Rendering::Runtime::HGCamera::get_parentCamera(this, 0LL);
		  }
		  if ( !this->fields.applyTableSettings || !hgrp )
		    goto LABEL_17;
		  settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         *(SettingParameter_1_System_Boolean_ **)(settingParameters_k__BackingField + 32),
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    HG::Rendering::Runtime::HGCamera::set_antialiasing(
		      this,
		      HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasing,
		      0LL);
		  }
		  settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         *(SettingParameter_1_System_Boolean_ **)(settingParameters_k__BackingField + 144),
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    v183 = HGAdditionalCameraData_AntialiasingMode__Enum_PSSR;
		  }
		  else
		  {
		    settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		    if ( !settingParameters_k__BackingField )
		      goto LABEL_209;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           *(SettingParameter_1_System_Boolean_ **)(settingParameters_k__BackingField + 160),
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      v183 = HGAdditionalCameraData_AntialiasingMode__Enum_DLSS;
		    }
		    else
		    {
		      settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              *(SettingParameter_1_System_Boolean_ **)(settingParameters_k__BackingField + 248),
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		        goto LABEL_239;
		      v183 = HGAdditionalCameraData_AntialiasingMode__Enum_FSR3;
		    }
		  }
		  HG::Rendering::Runtime::HGCamera::set_antialiasing(this, v183, 0LL);
		LABEL_239:
		  this->fields.applyTableSettings = 0;
		LABEL_17:
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 703 )
		    goto LABEL_21;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v184 = *(SettingParameter_1_System_Boolean_ **)settingParameters_k__BackingField;
		  if ( !*(_QWORD *)settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( LODWORD(v184->fields._._paramName_k__BackingField) <= 0x2BF )
		    goto LABEL_490;
		  if ( *(_QWORD *)&v184[117].fields._paramValue_k__BackingField )
		  {
		    v185 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		    if ( !v185 )
		      goto LABEL_209;
		    hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                     (ILFixDynamicMethodWrapper_31 *)v185,
		                     (Object *)this,
		                     0LL);
		  }
		  else
		  {
		LABEL_21:
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( !m_AdditionalCameraData )
		      goto LABEL_209;
		    hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_209;
		  v16 = 4;
		  if ( wrapperArray[6] <= 704 )
		    goto LABEL_496;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v186 = *(SettingParameter_1_System_Boolean_ **)settingParameters_k__BackingField;
		  if ( !*(_QWORD *)settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( LODWORD(v186->fields._._paramName_k__BackingField) <= 0x2C0 )
		    goto LABEL_490;
		  if ( v186[118].klass )
		  {
		    v187 = IFix::WrappersManagerImpl::GetPatch(704, 0LL);
		    if ( !v187 )
		      goto LABEL_209;
		    hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64(
		                     (ILFixDynamicMethodWrapper_18 *)v187,
		                     hgRenderPath,
		                     0LL);
		  }
		  else
		  {
		LABEL_496:
		    if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		    v17 = (__int64 (*)(void))qword_18F36F380;
		    if ( !qword_18F36F380 )
		    {
		      v17 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		      if ( !v17 )
		      {
		        v188 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		        sub_18007E1B0(v188, 0LL);
		      }
		      qword_18F36F380 = (__int64)v17;
		    }
		    v18 = v17();
		    v19 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		    if ( !qword_18F370308 )
		    {
		      v19 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(U"
		                                                               "nityEngine.Rendering.GraphicsTier,UnityEngine.Rendering.B"
		                                                               "uiltinShaderDefine)");
		      if ( !v19 )
		      {
		        v189 = sub_1802EE1B8(
		                 "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine."
		                 "Rendering.BuiltinShaderDefine)");
		        sub_18007E1B0(v189, 0LL);
		      }
		      qword_18F370308 = (__int64)v19;
		    }
		    if ( v19(v18, 37LL) && hgRenderPath == 3 )
		      hgRenderPath = 4;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  size.monitor = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v21 = v20->static_fields->wrapperArray;
		  if ( !v21 )
		    goto LABEL_225;
		  if ( v21->max_length.size <= 705 )
		    goto LABEL_40;
		  if ( !v20->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v20);
		    v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v21 = v20->static_fields->wrapperArray;
		  if ( !v21 )
		    goto LABEL_225;
		  if ( v21->max_length.size <= 0x2C1u )
		    goto LABEL_311;
		  if ( !v21[19].vector[21] )
		  {
		LABEL_40:
		    if ( !this->fields._renderPathInstance_k__BackingField )
		      goto LABEL_226;
		    renderPathInstance_k__BackingField = this->fields._renderPathInstance_k__BackingField;
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v20);
		      v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v21 = v20->static_fields->wrapperArray;
		    if ( !v21 )
		      goto LABEL_225;
		    if ( v21->max_length.size <= 706 )
		      goto LABEL_45;
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v20);
		      v20 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v20 = (struct ILFixDynamicMethodWrapper_2__Class *)v20->static_fields->wrapperArray;
		    if ( !v20 )
		      goto LABEL_225;
		    if ( LODWORD(v20->_0.namespaze) > 0x2C2 )
		    {
		      if ( *((_QWORD *)&v20[15]._0.byval_arg + 1) )
		      {
		        v191 = IFix::WrappersManagerImpl::GetPatch(706, 0LL);
		        if ( !v191 )
		          goto LABEL_225;
		        renderPath_k__BackingField = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                                       (ILFixDynamicMethodWrapper_26 *)v191,
		                                       (Object *)renderPathInstance_k__BackingField,
		                                       0LL);
		LABEL_46:
		        if ( renderPath_k__BackingField == hgRenderPath )
		          goto LABEL_47;
		        if ( this->fields._renderPathInstance_k__BackingField )
		        {
		          if ( this->fields.reflectionProbeViewHandle )
		            UnityEngine::HyperGryph::HGReflectionProbe::ResetView(this->fields.reflectionProbeViewHandle, 0LL);
		          v167 = this->fields._renderPathInstance_k__BackingField;
		          if ( hgrp )
		          {
		            renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		            if ( v167 )
		            {
		              sub_1800DA430(13LL, v167, renderGraph);
		              goto LABEL_227;
		            }
		          }
		          goto LABEL_225;
		        }
		LABEL_226:
		        if ( hgrp )
		        {
		LABEL_227:
		          size.klass = (SingleFieldAccessor__Class *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
		                                                       hgrp,
		                                                       0LL);
		          sub_18002D1B0(&size, v159, v160, v161, methoda);
		          size.monitor = (MonitorData *)hgrp->fields._settingParameters_k__BackingField;
		          sub_18002D1B0((SingleFieldAccessor *)&size.monitor, v162, v163, (Int32__Array **)size.monitor, methodb);
		          v252.bitDatas = *(BitArray128 *)&size.klass;
		          this->fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
		                                                               (HGRenderPathInternal__Enum)hgRenderPath,
		                                                               (HGRenderPathBase_HGRenderPathResources *)&v252,
		                                                               this,
		                                                               0LL);
		          sub_18002D1B0(
		            (SingleFieldAccessor *)&this->fields._renderPathInstance_k__BackingField,
		            v164,
		            v165,
		            v166,
		            methodc);
		          goto LABEL_47;
		        }
		LABEL_225:
		        sub_1800D8260(v20, v21);
		      }
		LABEL_45:
		      renderPath_k__BackingField = renderPathInstance_k__BackingField->fields._renderPath_k__BackingField;
		      goto LABEL_46;
		    }
		LABEL_311:
		    sub_1800D2AB0(v20, v21);
		  }
		  v190 = IFix::WrappersManagerImpl::GetPatch(705, 0LL);
		  if ( !v190 )
		    goto LABEL_225;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_25(
		    (ILFixDynamicMethodWrapper_14 *)v190,
		    (Object *)this,
		    (SCMessageID__Enum)hgRenderPath,
		    (Object *)hgrp,
		    0LL);
		LABEL_47:
		  this->fields.cullingViewHandle = -1;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  resolutionSettings = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		  if ( !resolutionSettings )
		    goto LABEL_209;
		  HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::UpdateHGCameraPixelRect(resolutionSettings, this, 0LL);
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_209;
		  v26 = (__int64 (__fastcall *)(Camera *))qword_18F36F1B8;
		  if ( !qword_18F36F1B8 )
		  {
		    v26 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::GetLightWeightCamera()");
		    if ( !v26 )
		    {
		      v192 = sub_1802EE1B8("UnityEngine.Camera::GetLightWeightCamera()");
		      sub_18007E1B0(v192, 0LL);
		    }
		    qword_18F36F1B8 = (__int64)v26;
		  }
		  v27 = (Camera *)v26(camera);
		  v28 = 0LL;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v27 )
		    goto LABEL_96;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v27->fields._._._.m_CachedPtr )
		    goto LABEL_96;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v28 = HG::Rendering::Runtime::HGCamera::GetOrCreate(v27, 0, 0LL);
		  if ( !v28 )
		    goto LABEL_209;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  settingParameters_k__BackingField = *((_QWORD *)wrapperArray + 23);
		  if ( !*(_QWORD *)settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( *(int *)(*(_QWORD *)settingParameters_k__BackingField + 24LL) <= 703 )
		    goto LABEL_67;
		  if ( !wrapperArray[56] )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v193 = **((_QWORD **)wrapperArray + 23);
		  if ( !v193 )
		    goto LABEL_209;
		  if ( *(_DWORD *)(v193 + 24) <= 0x2BFu )
		    goto LABEL_490;
		  if ( *(_QWORD *)(v193 + 5656) )
		  {
		    v194 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		    if ( !v194 )
		      goto LABEL_209;
		    v195 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v194, (Object *)v28, 0LL);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v30 = v195;
		  }
		  else
		  {
		LABEL_67:
		    v29 = v28->fields.m_AdditionalCameraData;
		    if ( !v29 )
		      goto LABEL_209;
		    v30 = v29->fields.hgRenderPath;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !wrapperArray[56] )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  settingParameters_k__BackingField = **((_QWORD **)wrapperArray + 23);
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( *(int *)(settingParameters_k__BackingField + 24) <= 704 )
		    goto LABEL_497;
		  if ( !wrapperArray[56] )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)**((_QWORD **)wrapperArray + 23);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2C0 )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 708) )
		  {
		    v196 = IFix::WrappersManagerImpl::GetPatch(704, 0LL);
		    if ( !v196 )
		      goto LABEL_209;
		    v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)v196, v30, 0LL);
		  }
		  else
		  {
		LABEL_497:
		    if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		    v31 = (__int64 (*)(void))qword_18F36F380;
		    if ( !qword_18F36F380 )
		    {
		      v31 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		      if ( !v31 )
		      {
		        v197 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		        sub_18007E1B0(v197, 0LL);
		      }
		      qword_18F36F380 = (__int64)v31;
		    }
		    v32 = v31();
		    v33 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		    if ( !qword_18F370308 )
		    {
		      v33 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(U"
		                                                               "nityEngine.Rendering.GraphicsTier,UnityEngine.Rendering.B"
		                                                               "uiltinShaderDefine)");
		      if ( !v33 )
		      {
		        v198 = sub_1802EE1B8(
		                 "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine."
		                 "Rendering.BuiltinShaderDefine)");
		        sub_18007E1B0(v198, 0LL);
		      }
		      qword_18F370308 = (__int64)v33;
		    }
		    if ( !v33(v32, 37LL) || v30 != 3 )
		      v16 = v30;
		  }
		  v34 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  size.monitor = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v34 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v35 = v34->static_fields->wrapperArray;
		  if ( !v35 )
		    goto LABEL_228;
		  if ( v35->max_length.size > 705 )
		  {
		    if ( !v34->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v34);
		      v34 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v35 = v34->static_fields->wrapperArray;
		    if ( !v35 )
		      goto LABEL_228;
		    if ( v35->max_length.size <= 0x2C1u )
		      goto LABEL_351;
		    if ( v35[19].vector[21] )
		    {
		      v199 = IFix::WrappersManagerImpl::GetPatch(705, 0LL);
		      if ( v199 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_25(
		          (ILFixDynamicMethodWrapper_14 *)v199,
		          (Object *)v28,
		          (SCMessageID__Enum)v16,
		          (Object *)hgrp,
		          0LL);
		        goto LABEL_92;
		      }
		      goto LABEL_228;
		    }
		  }
		  if ( !v28->fields._renderPathInstance_k__BackingField )
		    goto LABEL_246;
		  v36 = v28->fields._renderPathInstance_k__BackingField;
		  if ( !v34->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v34);
		    v34 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v35 = v34->static_fields->wrapperArray;
		  if ( !v35 )
		    goto LABEL_228;
		  if ( v35->max_length.size <= 706 )
		    goto LABEL_90;
		  if ( !v34->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v34);
		    v34 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v34 = (struct ILFixDynamicMethodWrapper_2__Class *)v34->static_fields->wrapperArray;
		  if ( !v34 )
		    goto LABEL_228;
		  if ( LODWORD(v34->_0.namespaze) <= 0x2C2 )
		LABEL_351:
		    sub_1800D2AB0(v34, v35);
		  if ( !*((_QWORD *)&v34[15]._0.byval_arg + 1) )
		  {
		LABEL_90:
		    v37 = v36->fields._renderPath_k__BackingField;
		    goto LABEL_91;
		  }
		  v200 = IFix::WrappersManagerImpl::GetPatch(706, 0LL);
		  if ( !v200 )
		    goto LABEL_228;
		  v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)v200, (Object *)v36, 0LL);
		LABEL_91:
		  if ( v37 != v16 )
		  {
		    if ( v28->fields._renderPathInstance_k__BackingField )
		    {
		      if ( v28->fields.reflectionProbeViewHandle )
		        UnityEngine::HyperGryph::HGReflectionProbe::ResetView(v28->fields.reflectionProbeViewHandle, 0LL);
		      v169 = hgrp;
		      v201 = v28->fields._renderPathInstance_k__BackingField;
		      if ( hgrp )
		      {
		        v202 = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		        if ( v201 )
		        {
		          sub_1800DA430(13LL, v201, v202);
		          goto LABEL_247;
		        }
		      }
		      goto LABEL_228;
		    }
		LABEL_246:
		    v169 = hgrp;
		    if ( hgrp )
		    {
		LABEL_247:
		      size.klass = (SingleFieldAccessor__Class *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
		                                                   v169,
		                                                   0LL);
		      sub_18002D1B0(&size, v170, v171, v172, methoda);
		      size.monitor = (MonitorData *)v169->fields._settingParameters_k__BackingField;
		      sub_18002D1B0((SingleFieldAccessor *)&size.monitor, v173, v174, (Int32__Array **)size.monitor, methodd);
		      v252.bitDatas = *(BitArray128 *)&size.klass;
		      v28->fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
		                                                          (HGRenderPathInternal__Enum)v16,
		                                                          (HGRenderPathBase_HGRenderPathResources *)&v252,
		                                                          v28,
		                                                          0LL);
		      sub_18002D1B0((SingleFieldAccessor *)&v28->fields._renderPathInstance_k__BackingField, v175, v176, v177, methode);
		      goto LABEL_92;
		    }
		LABEL_228:
		    sub_1800D8260(v34, v35);
		  }
		LABEL_92:
		  this->fields.cullingViewHandle = -1;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  v38 = HG::Rendering::Runtime::HGRenderPipeline::get_resolutionSettings(0LL);
		  if ( !v38 )
		    goto LABEL_209;
		  HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::UpdateHGCameraPixelRect(v38, v28, 0LL);
		LABEL_96:
		  v39 = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v39 )
		    goto LABEL_208;
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( v39->fields._._._._.m_CachedPtr )
		  {
		    v40 = this->fields.m_AdditionalCameraData;
		    if ( !v40 )
		      goto LABEL_209;
		    materialMipBias = v40->fields.materialMipBias;
		  }
		  else
		  {
		LABEL_208:
		    materialMipBias = 0.0;
		  }
		  this->fields._globalMipBias_k__BackingField = materialMipBias;
		  HG::Rendering::Runtime::HGCamera::UpdateVolumeAndPhysicalParameters(this, 0LL);
		  v42 = *(_QWORD *)&currentFrameSettings->materialQuality;
		  this->fields._frameSettings_k__BackingField.bitDatas = currentFrameSettings->bitDatas;
		  *(_QWORD *)&this->fields._frameSettings_k__BackingField.materialQuality = v42;
		  HG::Rendering::Runtime::HGCamera::UpdateAntialiasing(this, 0LL);
		  this->fields.prevFinalViewport = this->fields.finalViewport;
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 742 )
		    goto LABEL_498;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2E6 )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 746) )
		  {
		    v203 = IFix::WrappersManagerImpl::GetPatch(742, 0LL);
		    if ( !v203 )
		      goto LABEL_209;
		    v47 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_294((Rect *)&v252, v203, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_498:
		    if ( this->fields.overridePixelRect.hasValue )
		    {
		      value = this->fields.overridePixelRect.value;
		      v44 = _mm_shuffle_ps((__m128)value, (__m128)value, 225);
		      v44.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 85).m128_f32[0];
		      v45 = _mm_shuffle_ps(v44, v44, 198);
		      v45.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 170).m128_f32[0];
		      v46 = _mm_shuffle_ps(v45, v45, 39);
		      v46.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 255).m128_f32[0];
		    }
		    else
		    {
		      wrapperArray = (int *)this->fields.camera;
		      if ( !wrapperArray )
		        goto LABEL_209;
		      v204 = *UnityEngine::Camera::get_pixelRect((Rect *)&v252, (Camera *)wrapperArray, 0LL);
		      wrapperArray = (int *)this->fields.camera;
		      if ( !wrapperArray )
		        goto LABEL_209;
		      v205 = *UnityEngine::Camera::get_pixelRect((Rect *)&v252, (Camera *)wrapperArray, 0LL);
		      settingParameters_k__BackingField = (unsigned __int64)this->fields.camera;
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      pixelWidth = UnityEngine::Camera::get_pixelWidth((Camera *)settingParameters_k__BackingField, 0LL);
		      settingParameters_k__BackingField = (unsigned __int64)this->fields.camera;
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      v207 = _mm_shuffle_ps((__m128)v204, (__m128)v204, 225);
		      v207.m128_f32[0] = _mm_shuffle_ps((__m128)v205, (__m128)v205, 85).m128_f32[0];
		      v208 = _mm_shuffle_ps(v207, v207, 198);
		      v208.m128_f32[0] = (float)pixelWidth;
		      v46 = _mm_shuffle_ps(v208, v208, 39);
		      v46.m128_f32[0] = (float)UnityEngine::Camera::get_pixelHeight((Camera *)settingParameters_k__BackingField, 0LL);
		    }
		    v47 = _mm_shuffle_ps(v46, v46, 57);
		    *(__m128 *)&size.klass = v47;
		  }
		  LODWORD(v48) = _mm_shuffle_ps(v47, v47, 170).m128_u32[0];
		  this->fields.finalViewport = (Rect)v47;
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v49 = 1;
		  if ( (int)v48 >= 1 )
		    v49 = (int)v48;
		  this->fields._actualWidth_k__BackingField = v49;
		  m_Height = 1;
		  if ( (int)this->fields.finalViewport.m_Height >= 1 )
		    m_Height = (int)this->fields.finalViewport.m_Height;
		  this->fields._actualHeight_k__BackingField = m_Height;
		  if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
		  v51 = sub_1831019F0();
		  LODWORD(size.klass) = (int)this->fields.finalViewport.m_Width;
		  settingParameters_k__BackingField = (unsigned int)(int)this->fields.finalViewport.m_Height;
		  HIDWORD(size.klass) = (int)this->fields.finalViewport.m_Height;
		  if ( !v51 )
		    goto LABEL_209;
		  *(_QWORD *)(v51 + 72) = size.klass;
		  size.fields._.getValueDelegate = *(Func_2_Google_Protobuf_IMessage_Object_ **)&this->fields._actualWidth_k__BackingField;
		  getValueDelegate = size.fields._.getValueDelegate;
		  HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::ComputePackedMipChainInfo(
		    &this->fields.m_DepthBufferMipChainInfo,
		    (Vector2Int)size.fields._.getValueDelegate,
		    0LL);
		  this->fields.lowResScale = 0.5;
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 746 )
		    goto LABEL_126;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2EA )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 750) )
		  {
		    v209 = IFix::WrappersManagerImpl::GetPatch(746, 0LL);
		    if ( !v209 )
		      goto LABEL_209;
		    if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v209, (Object *)this, 0LL) )
		      goto LABEL_129;
		  }
		  else
		  {
		LABEL_126:
		    v53 = this->fields.camera;
		    if ( !v53 )
		      goto LABEL_209;
		    v54 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		    if ( !qword_18F36F138 )
		    {
		      v54 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		      if ( !v54 )
		      {
		        v210 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		        sub_18007E1B0(v210, 0LL);
		      }
		      qword_18F36F138 = (__int64)v54;
		    }
		    if ( v54(v53) == 1 )
		    {
		LABEL_129:
		      if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
		      v55 = sub_1831019F0();
		      v56 = v55;
		      LODWORD(size.klass) = this->fields._actualWidth_k__BackingField;
		      settingParameters_k__BackingField = (unsigned int)this->fields._actualHeight_k__BackingField;
		      HIDWORD(size.klass) = this->fields._actualHeight_k__BackingField;
		      if ( !v55 )
		        goto LABEL_209;
		      klass = size.klass;
		      *(_QWORD *)(v55 + 60) = size.klass;
		      if ( *(_BYTE *)(v55 + 16) && *(_BYTE *)(v55 + 33) )
		      {
		        klass = (SingleFieldAccessor__Class *)UnityEngine::Rendering::DynamicResolutionHandler::ApplyScalesOnSize(
		                                                (DynamicResolutionHandler *)v55,
		                                                (Vector2Int)klass,
		                                                0LL);
		        *(_QWORD *)(v56 + 52) = klass;
		      }
		      this->fields._actualWidth_k__BackingField = (int)klass;
		      globalMipBias_k__BackingField = this->fields._globalMipBias_k__BackingField;
		      this->fields._actualHeight_k__BackingField = HIDWORD(klass);
		      v59 = sub_1831019F0();
		      if ( !v59 )
		        goto LABEL_209;
		      if ( *(_BYTE *)(v59 + 17) )
		      {
		        if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		        v60 = System::Math::Log((double)(int)klass / (double)SLODWORD(size.fields._.getValueDelegate), 2.0, 0LL);
		      }
		      else
		      {
		        v60 = 0.0;
		      }
		      this->fields._globalMipBias_k__BackingField = v60 + globalMipBias_k__BackingField;
		      v61 = sub_1831019F0();
		      lowResScale = this->fields.lowResScale;
		      v63 = v61;
		      if ( !v61 )
		        goto LABEL_209;
		      if ( *(_BYTE *)(v61 + 16) )
		      {
		        v211 = *(float *)(v61 + 116);
		        if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		        v213 = System::Math::Min(v211 / 100.0, lowResScale, 0LL);
		        if ( (float)(lowResScale * *(float *)(v63 + 28)) < v213 )
		          lowResScale = Rewired::Utils::MathTools::Clamp(v213 / *(float *)(v63 + 28), 0.0, 1.0, v212);
		      }
		      this->fields.lowResScale = lowResScale;
		    }
		  }
		  this->fields._msaaSamples_k__BackingField = 1;
		  if ( !hgrp )
		    goto LABEL_209;
		  HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
		    this,
		    hgrp->fields._settingParameters_k__BackingField,
		    (Vector2Int)getValueDelegate,
		    0LL);
		  v64 = hgrp->fields._settingParameters_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  HG::Rendering::Runtime::HGUtils::GetRenderingScale(this, v64, 0LL);
		  actualHeight_k__BackingField = this->fields._actualHeight_k__BackingField;
		  LODWORD(size.klass) = this->fields._actualWidth_k__BackingField;
		  klass_low = LODWORD(size.klass);
		  HIDWORD(size.klass) = actualHeight_k__BackingField;
		  v67 = size.klass;
		  this->fields._taauRTSize_k__BackingField = (Vector2Int)size.klass;
		  v68 = _mm_shuffle_ps(
		          (__m128)COERCE_UNSIGNED_INT((float)(int)klass_low),
		          (__m128)COERCE_UNSIGNED_INT((float)(int)klass_low),
		          225);
		  v68.m128_f32[0] = (float)SHIDWORD(v67);
		  v69 = _mm_shuffle_ps(v68, v68, 198);
		  v69.m128_f32[0] = 1.0 / (float)(int)klass_low;
		  v70 = _mm_shuffle_ps(v69, v69, 39);
		  v70.m128_f32[0] = 1.0 / (float)SHIDWORD(v67);
		  *(__m128 *)&size.klass = _mm_shuffle_ps(v70, v70, 57);
		  this->fields._taauRTSizeParam_k__BackingField = *(Vector4 *)&size.klass;
		  v71 = sub_182F3EA70((unsigned __int64)v67 >> 32, klass_low);
		  actualWidth_k__BackingField = this->fields._actualWidth_k__BackingField;
		  if ( v71 < actualWidth_k__BackingField )
		    actualWidth_k__BackingField = v71;
		  v75 = sub_182F3EA70(v73, v72);
		  v76 = this->fields._actualHeight_k__BackingField;
		  if ( v75 < v76 )
		    v76 = v75;
		  v77 = actualWidth_k__BackingField & 0xFFFFFFFE;
		  LODWORD(size.klass) = v77;
		  HIDWORD(size.klass) = v76 & 0xFFFFFFFE;
		  v78 = size.klass;
		  this->fields._sceneRTSize_k__BackingField = (Vector2Int)size.klass;
		  settingParameters_k__BackingField = (unsigned __int64)v78 >> 32;
		  v79 = _mm_shuffle_ps((__m128)COERCE_UNSIGNED_INT((float)v77), (__m128)COERCE_UNSIGNED_INT((float)v77), 225);
		  v79.m128_f32[0] = (float)SHIDWORD(v78);
		  v80 = _mm_shuffle_ps(v79, v79, 198);
		  v80.m128_f32[0] = 1.0 / (float)v77;
		  v81 = _mm_shuffle_ps(v80, v80, 39);
		  v81.m128_f32[0] = 1.0 / (float)SHIDWORD(v78);
		  *(__m128 *)&size.klass = _mm_shuffle_ps(v81, v81, 57);
		  this->fields._sceneRTSizeParam_k__BackingField = *(Vector4 *)&size.klass;
		  if ( v28 )
		  {
		    if ( !v27 )
		      goto LABEL_209;
		    v82 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		    memset(&v247, 0, sizeof(v247));
		    if ( !qword_18F36F220 )
		    {
		      v82 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		      if ( !v82 )
		      {
		        v214 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v214, 0LL);
		      }
		      qword_18F36F220 = (__int64)v82;
		    }
		    v82(v27, &v247);
		    v257 = v247;
		    UnityEngine::Matrix4x4::set_Item(&v257, 12, 0.0, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v257, 13, 0.0, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v257, 14, 0.0, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v257, 15, 1.0, 0LL);
		    v28->fields._taauRTSize_k__BackingField = this->fields._taauRTSize_k__BackingField;
		    v28->fields._taauRTSizeParam_k__BackingField = this->fields._taauRTSizeParam_k__BackingField;
		    v28->fields._sceneRTSize_k__BackingField = this->fields._sceneRTSize_k__BackingField;
		    v28->fields._sceneRTSizeParam_k__BackingField = this->fields._sceneRTSizeParam_k__BackingField;
		    v83 = HG::Rendering::Runtime::HGCamera::BuildSceneRTAspectProjection(&v262, this, v27, 0LL);
		    v85 = *(_OWORD *)&v83->m01;
		    v248 = *(_OWORD *)&v83->m00;
		    v86 = *(_OWORD *)&v83->m02;
		    v249 = v85;
		    v87 = *(_OWORD *)&v83->m03;
		    v88 = (void (__fastcall *)(__int128 *, __int64, FieldDescriptor **))qword_18F36F3B8;
		    v250 = v86;
		    v251 = v87;
		    memset(&size.fields._.descriptor, 0, 32);
		    v245 = 0LL;
		    v246 = 0LL;
		    if ( !qword_18F36F3B8 )
		    {
		      v88 = (void (__fastcall *)(__int128 *, __int64, FieldDescriptor **))il2cpp_resolve_icall_1(
		                                                                            "UnityEngine.GL::GetGPUProjectionMatrix_Injec"
		                                                                            "ted(UnityEngine.Matrix4x4&,System.Boolean,Un"
		                                                                            "ityEngine.Matrix4x4&)");
		      if ( !v88 )
		      {
		        v215 = sub_1802EE1B8(
		                 "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v215, 0LL);
		      }
		      qword_18F36F3B8 = (__int64)v88;
		    }
		    LOBYTE(v84) = 1;
		    v88(&v248, v84, &size.fields._.descriptor);
		    v89 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		    memset(&v247, 0, sizeof(v247));
		    if ( !qword_18F36F220 )
		    {
		      v89 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		      if ( !v89 )
		      {
		        v216 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v216, 0LL);
		      }
		      qword_18F36F220 = (__int64)v89;
		    }
		    v89(v27, &v247);
		    v90 = (void (__fastcall *)(Camera *, __int128 *))qword_18F36F220;
		    v91 = *(_OWORD *)&v247.m01;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewMatrix.m00 = *(_OWORD *)&v247.m00;
		    v92 = *(_OWORD *)&v247.m02;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewMatrix.m01 = v91;
		    v93 = *(_OWORD *)&v247.m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewMatrix.m02 = v92;
		    v248 = 0LL;
		    v249 = 0LL;
		    v250 = 0LL;
		    v251 = 0LL;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewMatrix.m03 = v93;
		    if ( !v90 )
		    {
		      v90 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		      if ( !v90 )
		      {
		        v217 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v217, 0LL);
		      }
		      qword_18F36F220 = (__int64)v90;
		    }
		    v90(v27, &v248);
		    v94 = (void (__fastcall *)(__int128 *, Matrix4x4 *))qword_18F36FA60;
		    v258 = v248;
		    v259 = v249;
		    v260 = v250;
		    v261 = v251;
		    memset(&v247, 0, sizeof(v247));
		    if ( !qword_18F36FA60 )
		    {
		      v94 = (void (__fastcall *)(__int128 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
		                                                            "4&,UnityEngine.Matrix4x4&)");
		      if ( !v94 )
		      {
		        v218 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v218, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v94;
		    }
		    v94(&v258, &v247);
		    v95 = *(_OWORD *)&size.fields._.descriptor;
		    v96 = (void (__fastcall *)(__int128 *, FieldDescriptor **))qword_18F36FA60;
		    v97 = *(_OWORD *)&size.fields.clearDelegate;
		    v253 = *(_OWORD *)&size.fields._.descriptor;
		    v254 = *(_OWORD *)&size.fields.clearDelegate;
		    v98 = v245;
		    v99 = v246;
		    v255 = v245;
		    v256 = v246;
		    v100 = *(_OWORD *)&v247.m01;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewMatrix.m00 = *(_OWORD *)&v247.m00;
		    v101 = *(_OWORD *)&v247.m02;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewMatrix.m01 = v100;
		    v102 = *(_OWORD *)&v247.m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewMatrix.m02 = v101;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewMatrix.m03 = v102;
		    *(_OWORD *)&v28->fields.mainViewConstants.projMatrix.m00 = v95;
		    *(_OWORD *)&v28->fields.mainViewConstants.projMatrix.m01 = v97;
		    *(_OWORD *)&v28->fields.mainViewConstants.projMatrix.m02 = v98;
		    *(_OWORD *)&v28->fields.mainViewConstants.projMatrix.m03 = v99;
		    memset(&size.fields._.descriptor, 0, 32);
		    v245 = 0LL;
		    v246 = 0LL;
		    if ( !v96 )
		    {
		      v96 = (void (__fastcall *)(__int128 *, FieldDescriptor **))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.M"
		                                                                   "atrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v96 )
		      {
		        v219 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v219, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v96;
		    }
		    v96(&v253, &size.fields._.descriptor);
		    v103 = (void (__fastcall *)(Camera *, __int128 *))qword_18F36F220;
		    v104 = *(_OWORD *)&size.fields.clearDelegate;
		    *(_OWORD *)&v28->fields.mainViewConstants.invProjMatrix.m00 = *(_OWORD *)&size.fields._.descriptor;
		    v105 = v245;
		    *(_OWORD *)&v28->fields.mainViewConstants.invProjMatrix.m01 = v104;
		    v106 = v246;
		    *(_OWORD *)&v28->fields.mainViewConstants.invProjMatrix.m02 = v105;
		    v248 = 0LL;
		    v249 = 0LL;
		    v250 = 0LL;
		    v251 = 0LL;
		    *(_OWORD *)&v28->fields.mainViewConstants.invProjMatrix.m03 = v106;
		    if ( !v103 )
		    {
		      v103 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		      if ( !v103 )
		      {
		        v220 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v220, 0LL);
		      }
		      qword_18F36F220 = (__int64)v103;
		    }
		    v103(v27, &v248);
		    v107 = (void (__fastcall *)(__int128 *, __int128 *, FieldDescriptor **))qword_18F36FA50;
		    v258 = v95;
		    v253 = v248;
		    v259 = v97;
		    v260 = v98;
		    v261 = v99;
		    v254 = v249;
		    v255 = v250;
		    memset(&size.fields._.descriptor, 0, 32);
		    v256 = v251;
		    v245 = 0LL;
		    v246 = 0LL;
		    if ( !qword_18F36FA50 )
		    {
		      v107 = (void (__fastcall *)(__int128 *, __int128 *, FieldDescriptor **))il2cpp_resolve_icall_1(
		                                                                                "UnityEngine.Matrix4x4::HGMultiplyMatrix4"
		                                                                                "x4Fast_Injected(UnityEngine.Matrix4x4&,U"
		                                                                                "nityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v107 )
		      {
		        v221 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v221, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v107;
		    }
		    v107(&v258, &v253, &size.fields._.descriptor);
		    v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))qword_18F36FA50;
		    *(_OWORD *)&v262.m00 = v95;
		    *(_OWORD *)&v262.m01 = v97;
		    *(_OWORD *)&v262.m02 = v98;
		    *(_OWORD *)&v262.m03 = v99;
		    v109 = *(_OWORD *)&size.fields.clearDelegate;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m00 = *(_OWORD *)&size.fields._.descriptor;
		    v110 = v245;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m01 = v109;
		    v111 = v246;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m02 = v110;
		    *(_OWORD *)&v247.m00 = *(_OWORD *)&v257.m00;
		    *(_OWORD *)&v247.m02 = *(_OWORD *)&v257.m02;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m03 = v111;
		    *(_OWORD *)&v247.m01 = *(_OWORD *)&v257.m01;
		    *(_OWORD *)&v247.m03 = *(_OWORD *)&v257.m03;
		    v248 = 0LL;
		    v249 = 0LL;
		    v250 = 0LL;
		    v251 = 0LL;
		    if ( !v108 )
		    {
		      v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast"
		                                                                          "_Injected(UnityEngine.Matrix4x4&,UnityEngine.M"
		                                                                          "atrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v108 )
		      {
		        v222 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v222, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v108;
		    }
		    v108(&v262, &v247, &v248);
		    v112 = (void (__fastcall *)(__int128 *, FieldDescriptor **))qword_18F36FA60;
		    v113 = v249;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m00 = v248;
		    v114 = v250;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m01 = v113;
		    v115 = v251;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m02 = v114;
		    *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m03 = v115;
		    v116 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m01;
		    v253 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m00;
		    v254 = v116;
		    v117 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m03;
		    v255 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m02;
		    v256 = v117;
		    memset(&size.fields._.descriptor, 0, 32);
		    v245 = 0LL;
		    v246 = 0LL;
		    if ( !v112 )
		    {
		      v112 = (void (__fastcall *)(__int128 *, FieldDescriptor **))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine."
		                                                                    "Matrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v112 )
		      {
		        v223 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v223, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v112;
		    }
		    v112(&v253, &size.fields._.descriptor);
		    v118 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    v119 = *(_OWORD *)&size.fields.clearDelegate;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m00 = *(_OWORD *)&size.fields._.descriptor;
		    v120 = v245;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m01 = v119;
		    v121 = v246;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m02 = v120;
		    *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m03 = v121;
		    v122 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m01;
		    v123 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m02;
		    v124 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewProjMatrix.m00 = *(_OWORD *)&v28->fields.mainViewConstants.viewProjMatrix.m00;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewProjMatrix.m01 = v122;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewProjMatrix.m02 = v123;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewProjMatrix.m03 = v124;
		    v125 = *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m01;
		    v126 = *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m02;
		    v127 = *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&v28->fields.mainViewConstants.viewNoTransProjMatrix.m00;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m01 = v125;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m02 = v126;
		    *(_OWORD *)&v28->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m03 = v127;
		    v128 = *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m01;
		    v129 = *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m02;
		    v130 = *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.invNonJitteredViewProjMatrix.m00 = *(_OWORD *)&v28->fields.mainViewConstants.invViewProjMatrix.m00;
		    *(_OWORD *)&v28->fields.mainViewConstants.invNonJitteredViewProjMatrix.m01 = v128;
		    *(_OWORD *)&v28->fields.mainViewConstants.invNonJitteredViewProjMatrix.m02 = v129;
		    *(_OWORD *)&v28->fields.mainViewConstants.invNonJitteredViewProjMatrix.m03 = v130;
		    if ( !v118 )
		    {
		      v118 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		      qword_18F36FBC0 = (__int64)v118;
		    }
		    v131 = v118(v27);
		    if ( !v131 )
		      goto LABEL_209;
		    size.klass = 0LL;
		    LODWORD(size.monitor) = 0;
		    v132 = (void (__fastcall *)(__int64, SingleFieldAccessor *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v132 = (void (__fastcall *)(__int64, SingleFieldAccessor *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v132 )
		      {
		        v224 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v224, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v132;
		    }
		    v132(v131, &size);
		    v133 = *(float *)&size.monitor;
		    *(_QWORD *)&v28->fields.mainViewConstants.worldSpaceCameraPos.x = size.klass;
		    v28->fields.mainViewConstants.worldSpaceCameraPos.z = v133;
		    HGCameraCullingMatrix = HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(&v262, v28, 0LL);
		    v135 = *(_OWORD *)&HGCameraCullingMatrix->m01;
		    v136 = *(_OWORD *)&HGCameraCullingMatrix->m02;
		    v137 = *(_OWORD *)&HGCameraCullingMatrix->m03;
		    *(_OWORD *)&v28->fields.mainViewConstants.cullingMatrix.m00 = *(_OWORD *)&HGCameraCullingMatrix->m00;
		    *(_OWORD *)&v28->fields.mainViewConstants.cullingMatrix.m01 = v135;
		    *(_OWORD *)&v28->fields.mainViewConstants.cullingMatrix.m02 = v136;
		    *(_OWORD *)&v28->fields.mainViewConstants.cullingMatrix.m03 = v137;
		  }
		  v138 = 0LL;
		  v138.m128_f32[0] = (float)this->fields._taauRTSize_k__BackingField.m_X;
		  v139 = 8;
		  v140 = _mm_shuffle_ps(v138, v138, 225);
		  v140.m128_f32[0] = (float)(int)HIDWORD(*(_QWORD *)&this->fields._taauRTSize_k__BackingField);
		  v141 = _mm_shuffle_ps(v140, v140, 198);
		  v141.m128_f32[0] = (float)(1.0 / (float)this->fields._taauRTSize_k__BackingField.m_X) + 1.0;
		  v142 = _mm_shuffle_ps(v141, v141, 39);
		  v142.m128_f32[0] = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&this->fields._taauRTSize_k__BackingField)) + 1.0;
		  this->fields.screenParams = (Vector4)_mm_shuffle_ps(v142, v142, 57);
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 738 )
		    goto LABEL_499;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2E2 )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 742) )
		  {
		    v225 = IFix::WrappersManagerImpl::GetPatch(738, 0LL);
		    if ( !v225 )
		      goto LABEL_209;
		    if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v225, (Object *)this, 0LL) )
		      goto LABEL_436;
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_499:
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		    if ( !wrapperArray )
		      goto LABEL_209;
		    if ( wrapperArray[6] <= 732 )
		      goto LABEL_171;
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		    if ( !wrapperArray )
		      goto LABEL_209;
		    if ( (unsigned int)wrapperArray[6] <= 0x2DC )
		      goto LABEL_490;
		    if ( *((_QWORD *)wrapperArray + 736) )
		    {
		      v226 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v226 )
		        goto LABEL_209;
		      LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                     (ILFixDynamicMethodWrapper_31 *)v226,
		                                     (Object *)this,
		                                     0LL);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_171:
		      m_antialiasingMode = this->fields.m_antialiasingMode;
		    }
		    if ( (m_antialiasingMode & 0x10) != 0 )
		      goto LABEL_436;
		  }
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] > 739 )
		  {
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		    if ( !wrapperArray )
		      goto LABEL_209;
		    if ( (unsigned int)wrapperArray[6] <= 0x2E3 )
		      goto LABEL_490;
		    if ( *((_QWORD *)wrapperArray + 743) )
		    {
		      v227 = IFix::WrappersManagerImpl::GetPatch(739, 0LL);
		      if ( !v227 )
		        goto LABEL_209;
		      if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v227, (Object *)this, 0LL) )
		      {
		        settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        goto LABEL_183;
		      }
		LABEL_452:
		      settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      settingParameters_k__BackingField = *(_QWORD *)(settingParameters_k__BackingField + 168);
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      v229 = *(_DWORD *)(settingParameters_k__BackingField + 40);
		      if ( !v229 )
		        goto LABEL_482;
		      v230 = v229 - 1;
		      if ( !v230 )
		        goto LABEL_436;
		      v231 = v230 - 1;
		      if ( v231 )
		      {
		        if ( v231 == 1 )
		          v139 = 18;
		      }
		      else
		      {
		        v139 = 24;
		      }
		      goto LABEL_193;
		    }
		  }
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 732 )
		    goto LABEL_181;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2DC )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 736) )
		  {
		    v228 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		    if ( !v228 )
		      goto LABEL_209;
		    LOBYTE(v144) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                     (ILFixDynamicMethodWrapper_31 *)v228,
		                     (Object *)this,
		                     0LL);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_181:
		    v144 = this->fields.m_antialiasingMode;
		  }
		  if ( (v144 & 0x20) != 0 )
		    goto LABEL_452;
		LABEL_183:
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 740 )
		    goto LABEL_500;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( (unsigned int)wrapperArray[6] <= 0x2E4 )
		    goto LABEL_490;
		  if ( *((_QWORD *)wrapperArray + 744) )
		  {
		    v232 = IFix::WrappersManagerImpl::GetPatch(740, 0LL);
		    if ( !v232 )
		      goto LABEL_209;
		    if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v232, (Object *)this, 0LL) )
		      goto LABEL_467;
		  }
		  else
		  {
		LABEL_500:
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		    if ( !wrapperArray )
		      goto LABEL_209;
		    if ( wrapperArray[6] <= 732 )
		      goto LABEL_191;
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		    if ( !wrapperArray )
		      goto LABEL_209;
		    if ( (unsigned int)wrapperArray[6] <= 0x2DC )
		      goto LABEL_490;
		    if ( *((_QWORD *)wrapperArray + 736) )
		    {
		      v236 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v236 )
		        goto LABEL_209;
		      LOBYTE(v145) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)v236,
		                       (Object *)this,
		                       0LL);
		    }
		    else
		    {
		LABEL_191:
		      v145 = this->fields.m_antialiasingMode;
		    }
		    if ( (v145 & 0x40) != 0 )
		    {
		LABEL_467:
		      settingParameters_k__BackingField = (unsigned __int64)hgrp->fields._settingParameters_k__BackingField;
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      settingParameters_k__BackingField = *(_QWORD *)(settingParameters_k__BackingField + 264);
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_209;
		      v233 = *(_DWORD *)(settingParameters_k__BackingField + 40);
		      if ( v233 )
		      {
		        v234 = v233 - 1;
		        if ( v234 )
		        {
		          v235 = v234 - 1;
		          if ( v235 )
		          {
		            if ( v235 == 1 )
		              v139 = 18;
		          }
		          else
		          {
		            v139 = 23;
		          }
		          goto LABEL_193;
		        }
		LABEL_436:
		        v139 = 32;
		        goto LABEL_193;
		      }
		LABEL_482:
		      v139 = 72;
		    }
		  }
		LABEL_193:
		  v146 = this->fields.taaFrameIndex + 1;
		  this->fields.taaFrameIndex = v146;
		  if ( v146 >= v139 )
		    this->fields.taaFrameIndex = 0;
		  this->fields.taaJitterPhaseCount = v139;
		  if ( this->fields.m_ForceJitterIdx > 0 )
		    this->fields.taaFrameIndex = this->fields.m_ForceJitterIdx;
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = **(int ***)(settingParameters_k__BackingField + 184);
		  if ( !wrapperArray )
		    goto LABEL_209;
		  if ( wrapperArray[6] <= 767 )
		    goto LABEL_201;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  settingParameters_k__BackingField = **(_QWORD **)(settingParameters_k__BackingField + 184);
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_209;
		  if ( *(_DWORD *)(settingParameters_k__BackingField + 24) <= 0x2FFu )
		LABEL_490:
		    sub_1800D2AB0(settingParameters_k__BackingField, wrapperArray);
		  if ( !*(_QWORD *)(settingParameters_k__BackingField + 6168) )
		  {
		LABEL_201:
		    v147 = HG::Rendering::Runtime::HGCamera::RequiresCameraJitter(this, 0LL);
		    HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, v147, 1, hgrp, 0LL);
		    goto LABEL_202;
		  }
		  v237 = IFix::WrappersManagerImpl::GetPatch(767, 0LL);
		  if ( !v237 )
		    goto LABEL_209;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)v237,
		    (Object *)this,
		    (Object *)hgrp,
		    0LL);
		LABEL_202:
		  if ( !this->fields.m_firstGetDoFComponent )
		    goto LABEL_203;
		  m_volumeComponentsData = this->fields.m_volumeComponentsData;
		  if ( !m_volumeComponentsData )
		    goto LABEL_209;
		  settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		  m_depthOfField = m_volumeComponentsData->fields.m_depthOfField;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_depthOfField )
		    goto LABEL_216;
		  if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		  {
		    il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		    settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		  }
		  if ( !m_depthOfField->fields._._._._.m_CachedPtr )
		  {
		LABEL_216:
		    v157 = this->fields.m_volumeComponentsData;
		    v158 = this->fields.camera;
		    if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		    {
		      il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        settingParameters_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( v158 )
		    {
		      if ( !*(_DWORD *)(settingParameters_k__BackingField + 224) )
		        il2cpp_runtime_class_init_1(settingParameters_k__BackingField);
		      if ( v158->fields._._._.m_CachedPtr )
		      {
		        settingParameters_k__BackingField = (unsigned __int64)this->fields.camera;
		        if ( !settingParameters_k__BackingField )
		          goto LABEL_209;
		        v5 = UnityEngine::Component::GetComponent<System::Object>(
		               (Component *)settingParameters_k__BackingField,
		               MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGDepthOfField>);
		      }
		    }
		    if ( v157 )
		    {
		      v157->fields.m_depthOfField = (HGDepthOfField *)v5;
		      sub_18002D1B0((SingleFieldAccessor *)&v157->fields.m_depthOfField, (Type *)wrapperArray, v148, v149, methoda);
		      this->fields.m_firstGetDoFComponent = 0;
		      goto LABEL_203;
		    }
		LABEL_209:
		    sub_1800D8260(settingParameters_k__BackingField, wrapperArray);
		  }
		LABEL_203:
		  v150 = this->fields.camera;
		  if ( !v150 )
		    goto LABEL_209;
		  v151 = (double (__fastcall *)(Camera *))qword_18F36F0D0;
		  if ( !qword_18F36F0D0 )
		  {
		    v151 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_fieldOfView()");
		    if ( !v151 )
		    {
		      v238 = sub_1802EE1B8("UnityEngine.Camera::get_fieldOfView()");
		      sub_18007E1B0(v238, 0LL);
		    }
		    qword_18F36F0D0 = (__int64)v151;
		  }
		  v152 = v151(v150);
		  v153 = *(float *)&v152;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v154 = (this->fields._isFirstFrame_k__BackingField | HG::Rendering::Runtime::HGCamera::IsLargeCameraMovement(
		                                                         &this->fields.mainViewConstants,
		                                                         v153,
		                                                         5.0,
		                                                         0LL)) == 0;
		  this->fields._isFirstFrame_k__BackingField = 0;
		  ++this->fields.cameraFrameCount;
		  this->fields.prevTransformReset = !v154;
		}
		
		internal void BeginRender(CommandBuffer cmd) {} // 0x0000000189B720E0-0x0000000189B72164
		// Void BeginRender(CommandBuffer)
		void HG::Rendering::Runtime::HGCamera::BeginRender(HGCamera *this, CommandBuffer *cmd, MethodInfo *method)
		{
		  Camera *camera; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1161, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1161, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    camera = this->fields.camera;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CameraCaptureBridge);
		    this->fields.m_RecorderCaptureActions = UnityEngine::Rendering::CameraCaptureBridge::GetCaptureActions(camera, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RecorderCaptureActions, v6, v7, v8, v12);
		  }
		}
		
		[IDTag(2)]
		internal void UpdateAllViewConstants(bool jitterProjectionMatrix, HGRenderPipeline hgrp) {} // 0x0000000189B74308-0x0000000189B74388
		// Void UpdateAllViewConstants(Boolean, HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
		        HGCamera *this,
		        bool jitterProjectionMatrix,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2839, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2839, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      jitterProjectionMatrix,
		      (Object *)hgrp,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, jitterProjectionMatrix, 0, hgrp, 0LL);
		  }
		}
		
		internal void GetPixelCoordToViewDirWS(Vector4 resolution, float aspect, ref Matrix4x4 transform) {} // 0x0000000189B72F28-0x0000000189B73000
		// Void GetPixelCoordToViewDirWS(Vector4, Single, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGCamera::GetPixelCoordToViewDirWS(
		        HGCamera *this,
		        Vector4 *resolution,
		        float aspect,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  Matrix4x4 *v8; // rax
		  __int128 v9; // xmm1
		  __int128 v10; // xmm2
		  __int128 v11; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Vector4 v15; // [rsp+30h] [rbp-68h] BYREF
		  Matrix4x4 v16; // [rsp+40h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2840, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2840, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    v15 = *resolution;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1035(Patch, (Object *)this, &v15, aspect, transform, 0LL);
		  }
		  else
		  {
		    v15 = *resolution;
		    v8 = HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
		           &v16,
		           this,
		           &this->fields.mainViewConstants,
		           &v15,
		           aspect,
		           0LL);
		    v9 = *(_OWORD *)&v8->m01;
		    v10 = *(_OWORD *)&v8->m02;
		    v11 = *(_OWORD *)&v8->m03;
		    *(_OWORD *)&transform->m00 = *(_OWORD *)&v8->m00;
		    *(_OWORD *)&transform->m01 = v9;
		    *(_OWORD *)&transform->m02 = v10;
		    *(_OWORD *)&transform->m03 = v11;
		  }
		}
		
		internal static void ClearAll(HGRenderGraph renderGraph) {} // 0x00000001847003A0-0x0000000184700690
		// Void ClearAll(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCamera::ClearAll(HGRenderGraph *renderGraph, MethodInfo *method)
		{
		  Type *v3; // rdx
		  __int64 v4; // rcx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  struct HGCamera__Class *v7; // rax
		  Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *s_Cameras; // rbx
		  __int64 *v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // r8
		  Object *value; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v13; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v15; // rcx
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  BufferedRTHandleSystem *monitor; // rcx
		  struct HGCamera__Class *v21; // rax
		  List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *s_Cleanup; // rcx
		  int32_t size; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int64 v27; // [rsp+0h] [rbp-A8h] BYREF
		  SingleFieldAccessor v28; // [rsp+20h] [rbp-88h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_ValueTuple_2_Object_Int32_System_Object_ *v29; // [rsp+58h] [rbp-50h]
		  Dictionary_2_TKey_TValue_Enumerator_System_ValueTuple_2_Object_Int32_System_Object_ v30; // [rsp+60h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v31; // [rsp+90h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(529, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(529, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v26, v25);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v7 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v7 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    s_Cameras = v7->static_fields->s_Cameras;
		    if ( !s_Cameras )
		      sub_1800D8260(v4, v3);
		    memset(&v28.monitor, 0, 40);
		    v28.klass = (SingleFieldAccessor__Class *)s_Cameras;
		    ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		      &v28,
		      v3,
		      v5,
		      v6);
		    v28.monitor = (MonitorData *)(unsigned int)s_Cameras->fields._version;
		    LODWORD(v28.fields.clearDelegate) = 2;
		    v28.fields.setValueDelegate = 0LL;
		    *(_OWORD *)&v30._dictionary = *(_OWORD *)&v28.klass;
		    v30._current.key = 0LL;
		    *(_OWORD *)&v30._current.value = *(_OWORD *)&v28.fields.setValueDelegate;
		    v28.fields.hasDelegate = 0LL;
		    v29 = &v30;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<System::Object,int>,System::Object>::MoveNext(
		                &v30,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext) )
		      {
		        v28.fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)v30._current.value;
		        value = v30._current.value;
		        if ( !v30._current.value )
		          sub_1800D8250(v10, v9);
		        v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        wrapperArray = v13->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          sub_1800D8250(v13, 0LL);
		        if ( wrapperArray->max_length.size <= 530 )
		          goto LABEL_19;
		        if ( !v13->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v13);
		          v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v15 = v13->static_fields->wrapperArray;
		        if ( !v15 )
		          sub_1800D8250(0LL, wrapperArray);
		        if ( v15->max_length.size <= 0x212u )
		          sub_1800D2AA0(v15, wrapperArray, v11);
		        if ( v15[14].vector[26] )
		        {
		          v16 = IFix::WrappersManagerImpl::GetPatch(530, 0LL);
		          if ( !v16 )
		            sub_1800D8250(v18, v17);
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v16, value, 0LL);
		        }
		        else
		        {
		LABEL_19:
		          monitor = (BufferedRTHandleSystem *)value[172].monitor;
		          if ( !monitor )
		            sub_1800D8250(0LL, wrapperArray);
		          UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(monitor, 0LL);
		        }
		        if ( !v28.fields._.getValueDelegate )
		          sub_1800D8250(0LL, v19);
		        HG::Rendering::Runtime::HGCamera::Dispose((HGCamera *)v28.fields._.getValueDelegate, renderGraph, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v31 )
		    {
		      v9 = &v27;
		      v28.fields.hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v31->ex;
		      if ( v28.fields.hasDelegate )
		        sub_18007E1E0(v28.fields.hasDelegate);
		    }
		    v21 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v21 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    s_Cleanup = (List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *)v21->static_fields->s_Cameras;
		    if ( !s_Cleanup
		      || (System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
		            (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)s_Cleanup,
		            MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Clear),
		          (s_Cleanup = TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->s_Cleanup) == 0LL) )
		    {
		      sub_1800D8250(s_Cleanup, v9);
		    }
		    ++s_Cleanup->fields._version;
		    size = s_Cleanup->fields._size;
		    s_Cleanup->fields._size = 0;
		    if ( size > 0 )
		      System::Array::Clear((Array *)s_Cleanup->fields._items, 0, size, 0LL);
		  }
		}
		
		internal static void CleanUnused(HGRenderGraph renderGraph) {} // 0x0000000183450950-0x0000000183451490
		// Void CleanUnused(HGRenderGraph)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGCamera::CleanUnused(HGRenderGraph *renderGraph, MethodInfo *method)
		{
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  HGRenderGraph *v4; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  struct HGCamera__Class *v11; // rax
		  Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *s_Cameras; // rbx
		  struct MethodInfo *v13; // rdi
		  __int64 v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Dictionary_2_TKey_TValue_ValueCollection_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *v17; // rsi
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Dictionary_2_TKey_TValue_KeyCollection_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *keys; // rbx
		  __int64 dictionary; // rbx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  _BYTE *v25; // rdx
		  void *v26; // rcx
		  ValueTuple_2_Object_Int32_ currentKey; // xmm6
		  struct HGCamera__Class *v28; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v29; // rdi
		  struct MethodInfo *v30; // rbx
		  int32_t Entry; // eax
		  __int64 v32; // rcx
		  __int64 v33; // r8
		  __int64 v34; // rdx
		  Dictionary_2_TKey_TValue_Entry_System_ValueTuple_2_Object_Int32_System_Object___Array *entries; // rax
		  Object *value; // rbx
		  Object__Class *klass; // rdi
		  struct Object_1__Class *v38; // rcx
		  Object__Class *v39; // rdi
		  unsigned int (__fastcall *v40)(Object__Class *); // rax
		  Object__Class *v41; // rdi
		  struct Object_1__Class *v42; // rcx
		  Object__Class *v43; // rax
		  int events_low; // esi
		  Object__Class *v45; // rdi
		  struct Object_1__Class *v46; // rcx
		  Object__Class *v47; // rdi
		  unsigned __int8 (__fastcall *v48)(Object__Class *); // rax
		  __int64 v49; // rcx
		  Object__Class *v50; // rdi
		  unsigned int (__fastcall *v51)(Object__Class *); // rax
		  struct HGCamera__Class *v52; // rax
		  List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *s_Cleanup; // rcx
		  Object__Class *v54; // rdi
		  struct Object_1__Class *v55; // rcx
		  Object__Class *v56; // rbx
		  __int64 (__fastcall *v57)(Object__Class *); // rax
		  __int64 *v58; // rdx
		  __int64 v59; // rbx
		  signed __int64 v60; // rcx
		  struct HGCamera__Class *v61; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v62; // r10
		  signed __int64 v63; // rtt
		  __int64 v64; // rdx
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  struct HGCamera__Class *v67; // rax
		  __int64 v68; // r9
		  __int64 *v69; // rdx
		  signed __int64 v70; // rtt
		  __int64 v71; // rcx
		  ValueTuple_2_Object_Int32_ current; // xmm6
		  struct HGCamera__Class *v73; // rax
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v74; // rdi
		  struct MethodInfo *v75; // rbx
		  int32_t v76; // eax
		  __int64 v77; // rcx
		  __int64 v78; // r8
		  __int64 v79; // rdx
		  Dictionary_2_TKey_TValue_Entry_System_ValueTuple_2_Object_Int32_System_Object___Array *v80; // rax
		  HGCamera *v81; // rcx
		  __int64 v82; // rdx
		  Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *v83; // rcx
		  struct HGCamera__Class *v84; // rax
		  int32_t v85; // r8d
		  __int64 v86; // rax
		  Object *v87; // rax
		  __int64 v88; // rax
		  __int64 v89; // rax
		  __int64 v90; // rax
		  __int64 v91; // rax
		  __int64 v92; // rax
		  Object *v93; // rax
		  _BYTE v94[32]; // [rsp+0h] [rbp-E8h] BYREF
		  __m256i v95; // [rsp+20h] [rbp-C8h] BYREF
		  Il2CppException *ex; // [rsp+40h] [rbp-A8h]
		  void *v97; // [rsp+48h] [rbp-A0h]
		  __int128 v98; // [rsp+50h] [rbp-98h] BYREF
		  List_1_T_Enumerator_System_ValueTuple_2_Object_Int32_ v99; // [rsp+60h] [rbp-88h] BYREF
		  Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_ValueTuple_2_Object_Int32_System_Object_ v100; // [rsp+80h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v101; // [rsp+A0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v102; // [rsp+A8h] [rbp-40h] BYREF
		  Object *v104; // [rsp+100h] [rbp+18h] BYREF
		
		  v4 = renderGraph;
		  v104 = 0LL;
		  memset(&v99, 0, sizeof(v99));
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, method);
		  if ( wrapperArray->max_length.size <= 580 )
		    goto LABEL_12;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v5->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v5, method);
		  if ( v7->max_length.size <= 0x244u )
		    sub_1800D2AB0(v5, method);
		  if ( v7[16].vector[4] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(580, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    v11 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v11 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    s_Cameras = v11->static_fields->s_Cameras;
		    if ( !s_Cameras )
		      sub_1800D8260(v5, method);
		    v13 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Keys;
		    if ( !s_Cameras->fields._keys )
		    {
		      v14 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Keys->klass->rgctx_data[18].rgctxDataDummy);
		      v17 = (Dictionary_2_TKey_TValue_ValueCollection_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)sub_1800368D0(v14);
		      if ( !v17 )
		        sub_1800D8260(v16, v15);
		      if ( !*((_QWORD *)v13->klass->rgctx_data[19].rgctxDataDummy + 4) )
		        (*(void (**)(void))v13->klass->rgctx_data[19].rgctxDataDummy)();
		      System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Beyond::Gameplay::Core::WaterVolumePtr,Beyond::ObjectPtr<System::Object>>::ValueCollection(
		        v17,
		        (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)s_Cameras,
		        (MethodInfo *)v13->klass->rgctx_data[19].rgctxDataDummy);
		      s_Cameras->fields._keys = (Dictionary_2_TKey_TValue_KeyCollection_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *)v17;
		      sub_18002D1B0((SingleFieldAccessor *)&s_Cameras->fields._keys, v18, v19, v20, (MethodInfo *)v95.m256i_i64[0]);
		    }
		    keys = s_Cameras->fields._keys;
		    if ( !keys )
		      sub_1800D8260(v5, method);
		    dictionary = (__int64)keys->fields._dictionary;
		    memset(&v95.m256i_u64[1], 0, 24);
		    v95.m256i_i64[0] = dictionary;
		    ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		      (SingleFieldAccessor *)&v95,
		      (Type *)method,
		      v2,
		      v3);
		    if ( !dictionary )
		      sub_1800D8260(v24, v23);
		    v95.m256i_i32[3] = *(_DWORD *)(dictionary + 44);
		    v95.m256i_i32[2] = 0;
		    *(_OWORD *)&v95.m256i_u64[2] = 0LL;
		    *(_OWORD *)&v100._dictionary = *(_OWORD *)v95.m256i_i8;
		    v100._currentKey = 0LL;
		    ex = 0LL;
		    v97 = &v100;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<System::Object,int>,System::Object>::MoveNext(
		                &v100,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext) )
		      {
		        currentKey = v100._currentKey;
		        v28 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		          v28 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		        }
		        v29 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v28->static_fields->s_Cameras;
		        if ( !v29 )
		          sub_1800D8250(v26, v25);
		        v30 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item;
		        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		              + 4) )
		          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		        *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = currentKey;
		        Entry = System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::FindEntry(
		                  v29,
		                  (ValueTuple_2_Object_Int32_ *)&v95,
		                  (MethodInfo *)v30->klass->rgctx_data[22].rgctxDataDummy);
		        v34 = Entry;
		        if ( Entry < 0 )
		        {
		          *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = currentKey;
		          v86 = sub_1803626F4(v30->klass->rgctx_data, 23LL);
		          v87 = (Object *)il2cpp_value_box(v86, &v95);
		          System::ThrowHelper::ThrowKeyNotFoundException(v87, 0LL);
		        }
		        entries = v29->fields._entries;
		        if ( !entries )
		          sub_1800D8250(v32, v34);
		        if ( (unsigned int)v34 >= entries->max_length.size )
		          sub_1800D2AA0(v34, v34, v33);
		        value = entries->vector[v34].value;
		        if ( !value )
		          sub_1800D8250(32 * v34, v34);
		        klass = value[6].klass;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( klass )
		        {
		          v38 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( klass->_0.name )
		          {
		            v39 = value[6].klass;
		            if ( !v39 )
		              sub_1800D8250(v38, v34);
		            v40 = (unsigned int (__fastcall *)(Object__Class *))qword_18F36F138;
		            if ( !qword_18F36F138 )
		            {
		              v40 = (unsigned int (__fastcall *)(Object__Class *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		              if ( !v40 )
		              {
		                v88 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		                sub_18007E1B0(v88, 0LL);
		              }
		              qword_18F36F138 = (__int64)v40;
		            }
		            if ( v40(v39) == 2 )
		              continue;
		          }
		        }
		        v41 = value[172].klass;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !v41 )
		          goto LABEL_56;
		        v42 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( v41->_0.name )
		        {
		          v43 = value[172].klass;
		          if ( !v43 )
		            sub_1800D8250(v42, v34);
		          events_low = LOBYTE(v43->_0.events);
		        }
		        else
		        {
		LABEL_56:
		          events_low = 0;
		        }
		        v45 = value[6].klass;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !v45 )
		          goto LABEL_77;
		        v46 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( !v45->_0.name )
		          goto LABEL_77;
		        v47 = value[6].klass;
		        if ( !v47 )
		          sub_1800D8250(v46, v34);
		        v48 = (unsigned __int8 (__fastcall *)(Object__Class *))qword_18F36FBB8;
		        if ( !qword_18F36FBB8 )
		        {
		          v48 = (unsigned __int8 (__fastcall *)(Object__Class *))il2cpp_resolve_icall_1("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		          if ( !v48 )
		          {
		            v89 = sub_1802EE1B8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		            sub_18007E1B0(v89, 0LL);
		          }
		          qword_18F36FBB8 = (__int64)v48;
		        }
		        if ( !v48(v47) )
		        {
		          v50 = value[6].klass;
		          if ( !v50 )
		            sub_1800D8250(v49, v34);
		          v51 = (unsigned int (__fastcall *)(Object__Class *))qword_18F36F138;
		          if ( !qword_18F36F138 )
		          {
		            v51 = (unsigned int (__fastcall *)(Object__Class *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		            if ( !v51 )
		            {
		              v90 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		              sub_18007E1B0(v90, 0LL);
		            }
		            qword_18F36F138 = (__int64)v51;
		          }
		          if ( v51(v50) != 4 && !events_low && !BYTE5(value[146].monitor) )
		          {
		LABEL_77:
		            v52 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		            if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		              v52 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		            }
		            s_Cleanup = v52->static_fields->s_Cleanup;
		            if ( !s_Cleanup )
		              sub_1800D8250(0LL, v34);
		            *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = currentKey;
		            sub_184A137E0(
		              s_Cleanup,
		              &v95,
		              MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::Add);
		          }
		        }
		        if ( !v4 )
		          sub_1800D8250(v49, v34);
		        if ( v4->fields._enableCppRenderPath_k__BackingField )
		        {
		          v54 = value[6].klass;
		          v55 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v55 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v55 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( v54 )
		          {
		            if ( !v55->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v55);
		            if ( v54->_0.name )
		            {
		              v56 = value[6].klass;
		              if ( !v56 )
		                sub_1800D8250(v55, v34);
		              v57 = (__int64 (__fastcall *)(Object__Class *))qword_18F36F1B8;
		              if ( !qword_18F36F1B8 )
		              {
		                v57 = (__int64 (__fastcall *)(Object__Class *))il2cpp_resolve_icall_1("UnityEngine.Camera::GetLightWeightCamera()");
		                if ( !v57 )
		                {
		                  v91 = sub_1802EE1B8("UnityEngine.Camera::GetLightWeightCamera()");
		                  sub_18007E1B0(v91, 0LL);
		                }
		                qword_18F36F1B8 = (__int64)v57;
		              }
		              v59 = v57(v56);
		              v60 = (signed __int64)TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v60 = (signed __int64)TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  v60 = (signed __int64)TypeInfo::UnityEngine::Object;
		                }
		              }
		              if ( v59 )
		              {
		                if ( !*(_DWORD *)(v60 + 224) )
		                  il2cpp_runtime_class_init_1(v60);
		                if ( *(_QWORD *)(v59 + 16) )
		                {
		                  v61 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		                  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		                    v61 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		                  }
		                  v62 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v61->static_fields->s_Cameras;
		                  v98 = (unsigned __int64)v59;
		                  if ( dword_18F35FD08 )
		                  {
		                    v58 = &qword_18F0BCBA0[(((unsigned __int64)&v98 >> 12) & 0x1FFFFF) >> 6];
		                    _m_prefetchw(v58 + 36190);
		                    do
		                    {
		                      v60 = v58[36190] | (1LL << (((unsigned __int64)&v98 >> 12) & 0x3F));
		                      v63 = v58[36190];
		                    }
		                    while ( v63 != _InterlockedCompareExchange64(v58 + 36190, v60, v63) );
		                  }
		                  DWORD2(v98) = 0;
		                  if ( !v62 )
		                    sub_1800D8250(v60, v58);
		                  *(_OWORD *)v95.m256i_i8 = v98;
		                  if ( System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
		                         v62,
		                         (ValueTuple_2_Object_Int32_ *)&v95,
		                         &v104,
		                         MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
		                  {
		                    if ( !v104 )
		                      sub_1800D8250(0LL, v64);
		                    if ( v104[113].klass )
		                    {
		                      UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::HGRenderPath_Destroy(
		                        (int64_t)v104[113].klass,
		                        0LL);
		                      if ( !v104 )
		                        sub_1800D8250(v66, v65);
		                      v104[113].klass = 0LL;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v101 )
		    {
		      v25 = v94;
		      ex = v101->ex;
		      v26 = ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = renderGraph;
		    }
		    v67 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v67 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    v68 = (__int64)v67->static_fields->s_Cleanup;
		    if ( !v68 )
		      goto LABEL_139;
		    memset(&v95.m256i_u64[1], 0, 24);
		    v95.m256i_i64[0] = v68;
		    if ( dword_18F35FD08 )
		    {
		      v69 = &qword_18F0BCBA0[(((unsigned __int64)&v95 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v69 + 36190);
		      do
		        v70 = v69[36190];
		      while ( v70 != _InterlockedCompareExchange64(
		                       v69 + 36190,
		                       v70 | (1LL << (((unsigned __int64)&v95 >> 12) & 0x3F)),
		                       v70) );
		    }
		    v95.m256i_i32[2] = 0;
		    v95.m256i_i32[3] = *(_DWORD *)(v68 + 28);
		    *(_OWORD *)&v99._list = *(_OWORD *)v95.m256i_i8;
		    v99._current = 0LL;
		    ex = 0LL;
		    v97 = &v99;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,int>>::MoveNext(
		                &v99,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>>::MoveNext) )
		      {
		        current = v99._current;
		        v73 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		          v73 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		        }
		        v74 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v73->static_fields->s_Cameras;
		        if ( !v74 )
		          sub_1800D8250(v71, v25);
		        v75 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item;
		        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		              + 4) )
		          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		        *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = current;
		        v76 = System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::FindEntry(
		                v74,
		                (ValueTuple_2_Object_Int32_ *)&v95,
		                (MethodInfo *)v75->klass->rgctx_data[22].rgctxDataDummy);
		        v79 = v76;
		        if ( v76 < 0 )
		        {
		          *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = current;
		          v92 = sub_1803626F4(v75->klass->rgctx_data, 23LL);
		          v93 = (Object *)il2cpp_value_box(v92, &v95);
		          System::ThrowHelper::ThrowKeyNotFoundException(v93, 0LL);
		        }
		        v80 = v74->fields._entries;
		        if ( !v80 )
		          sub_1800D8250(v77, v79);
		        if ( (unsigned int)v79 >= v80->max_length.size )
		          sub_1800D2AA0(v79, v79, v78);
		        v81 = (HGCamera *)v80->vector[v79].value;
		        if ( !v81 )
		          sub_1800D8250(0LL, v79);
		        HG::Rendering::Runtime::HGCamera::Dispose(v81, v4, 0LL);
		        v83 = TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->s_Cameras;
		        if ( !v83 )
		          sub_1800D8250(0LL, v82);
		        *(ValueTuple_2_Object_Int32_ *)v95.m256i_i8 = current;
		        System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::Remove(
		          (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v83,
		          (ValueTuple_2_Object_Int32_ *)&v95,
		          MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Remove);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v102 )
		    {
		      v25 = v94;
		      ex = v102->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		    v84 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v84 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    v26 = v84->static_fields->s_Cleanup;
		    if ( !v26 )
		LABEL_139:
		      sub_1800D8250(v26, v25);
		    ++*((_DWORD *)v26 + 7);
		    v85 = *((_DWORD *)v26 + 6);
		    *((_DWORD *)v26 + 6) = 0;
		    if ( v85 > 0 )
		      System::Array::Clear(*((Array **)v26 + 2), 0, v85, 0LL);
		  }
		}
		
		internal static bool IsLargeCameraMovement([IsReadOnly] in ViewConstants viewConstants, float cameraRotationThreshold, float cameraPositionThreshold) => default; // 0x00000001839C10B0-0x00000001839C14B0
		// Boolean IsLargeCameraMovement(HGCamera+ViewConstants ByRef, Single, Single)
		bool HG::Rendering::Runtime::HGCamera::IsLargeCameraMovement(
		        HGCamera_ViewConstants *viewConstants,
		        float cameraRotationThreshold,
		        float cameraPositionThreshold,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float v8; // xmm0_4
		  __int128 v9; // xmm2
		  __int128 v10; // xmm1
		  float v11; // xmm11_4
		  __int128 v12; // xmm2
		  Vector4 v13; // xmm8
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  Vector4 *Column; // rax
		  MethodInfo *v18; // r8
		  __int128 v19; // xmm3
		  __int128 v20; // xmm2
		  float v21; // xmm9_4
		  __int128 v22; // xmm1
		  Vector4 v23; // xmm8
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  Vector4 *v27; // rax
		  MethodInfo *v28; // r8
		  __int128 v29; // xmm3
		  __int128 v30; // xmm2
		  float v31; // xmm12_4
		  __int128 v32; // xmm1
		  Vector4 v33; // xmm8
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  Vector4 v37; // xmm0
		  float z; // eax
		  float v39; // eax
		  MethodInfo *v40; // r9
		  Vector3 *v41; // rax
		  MethodInfo *v42; // rdx
		  MethodInfo *v43; // r8
		  float sqrMagnitude; // xmm3_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v47; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v48; // [rsp+48h] [rbp-C0h] BYREF
		  Matrix4x4 v49; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v50; // [rsp+98h] [rbp-70h] BYREF
		  Vector3 v51; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v52; // [rsp+B8h] [rbp-50h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size > 778 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x30A )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[16]._1.genericContainerHandle )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(778, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_308(
		                 Patch,
		                 viewConstants,
		                 cameraRotationThreshold,
		                 cameraPositionThreshold,
		                 0LL);
		    }
		LABEL_10:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  v8 = cameraRotationThreshold * 0.017453292;
		  Beyond::DampingMath::cosf((Beyond::DampingMath *)v5, cameraRotationThreshold);
		  v9 = *(_OWORD *)&viewConstants->viewMatrix.m01;
		  *(_OWORD *)&v49.m00 = *(_OWORD *)&viewConstants->viewMatrix.m00;
		  v10 = *(_OWORD *)&viewConstants->viewMatrix.m02;
		  *(_OWORD *)&v49.m01 = v9;
		  v11 = v8;
		  v12 = *(_OWORD *)&viewConstants->viewMatrix.m03;
		  *(_OWORD *)&v49.m02 = v10;
		  *(_OWORD *)&v49.m03 = v12;
		  v13 = *UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 0, 0LL);
		  v14 = *(_OWORD *)&viewConstants->prevViewMatrix.m01;
		  *(_OWORD *)&v49.m00 = *(_OWORD *)&viewConstants->prevViewMatrix.m00;
		  v15 = *(_OWORD *)&viewConstants->prevViewMatrix.m02;
		  *(_OWORD *)&v49.m01 = v14;
		  v16 = *(_OWORD *)&viewConstants->prevViewMatrix.m03;
		  *(_OWORD *)&v49.m02 = v15;
		  *(_OWORD *)&v49.m03 = v16;
		  Column = UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 0, 0LL);
		  LODWORD(v12) = _mm_shuffle_ps(*(__m128 *)Column, *(__m128 *)Column, 170).m128_u32[0];
		  *(_QWORD *)&v48.x = _mm_unpacklo_ps(*(__m128 *)Column, _mm_shuffle_ps(*(__m128 *)Column, *(__m128 *)Column, 85)).m128_u64[0];
		  LODWORD(v48.z) = v12;
		  *(_QWORD *)&v47.x = _mm_unpacklo_ps((__m128)v13, _mm_shuffle_ps((__m128)v13, (__m128)v13, 85)).m128_u64[0];
		  LODWORD(v47.z) = _mm_shuffle_ps((__m128)v13, (__m128)v13, 170).m128_u32[0];
		  *(float *)&v15 = UnityEngine::Vector3::Dot(&v47, &v48, v18);
		  v19 = *(_OWORD *)&viewConstants->viewMatrix.m00;
		  v20 = *(_OWORD *)&viewConstants->viewMatrix.m02;
		  *(_OWORD *)&v49.m01 = *(_OWORD *)&viewConstants->viewMatrix.m01;
		  v21 = *(float *)&v15;
		  v22 = *(_OWORD *)&viewConstants->viewMatrix.m03;
		  *(_OWORD *)&v49.m00 = v19;
		  *(_OWORD *)&v49.m03 = v22;
		  *(_OWORD *)&v49.m02 = v20;
		  v23 = *UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 1, 0LL);
		  v24 = *(_OWORD *)&viewConstants->prevViewMatrix.m01;
		  *(_OWORD *)&v49.m00 = *(_OWORD *)&viewConstants->prevViewMatrix.m00;
		  v25 = *(_OWORD *)&viewConstants->prevViewMatrix.m02;
		  *(_OWORD *)&v49.m01 = v24;
		  v26 = *(_OWORD *)&viewConstants->prevViewMatrix.m03;
		  *(_OWORD *)&v49.m02 = v25;
		  *(_OWORD *)&v49.m03 = v26;
		  v27 = UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 1, 0LL);
		  LODWORD(v20) = _mm_shuffle_ps(*(__m128 *)v27, *(__m128 *)v27, 170).m128_u32[0];
		  *(_QWORD *)&v47.x = _mm_unpacklo_ps(*(__m128 *)v27, _mm_shuffle_ps(*(__m128 *)v27, *(__m128 *)v27, 85)).m128_u64[0];
		  LODWORD(v47.z) = v20;
		  *(_QWORD *)&v48.x = _mm_unpacklo_ps((__m128)v23, _mm_shuffle_ps((__m128)v23, (__m128)v23, 85)).m128_u64[0];
		  LODWORD(v48.z) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 170).m128_u32[0];
		  *(float *)&v25 = UnityEngine::Vector3::Dot(&v48, &v47, v28);
		  v29 = *(_OWORD *)&viewConstants->viewMatrix.m00;
		  v30 = *(_OWORD *)&viewConstants->viewMatrix.m02;
		  *(_OWORD *)&v49.m01 = *(_OWORD *)&viewConstants->viewMatrix.m01;
		  v31 = *(float *)&v25;
		  v32 = *(_OWORD *)&viewConstants->viewMatrix.m03;
		  *(_OWORD *)&v49.m00 = v29;
		  *(_OWORD *)&v49.m03 = v32;
		  *(_OWORD *)&v49.m02 = v30;
		  v33 = *UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 2, 0LL);
		  v34 = *(_OWORD *)&viewConstants->prevViewMatrix.m01;
		  *(_OWORD *)&v49.m00 = *(_OWORD *)&viewConstants->prevViewMatrix.m00;
		  v35 = *(_OWORD *)&viewConstants->prevViewMatrix.m02;
		  *(_OWORD *)&v49.m01 = v34;
		  v36 = *(_OWORD *)&viewConstants->prevViewMatrix.m03;
		  *(_OWORD *)&v49.m02 = v35;
		  *(_OWORD *)&v49.m03 = v36;
		  v37 = *UnityEngine::Matrix4x4::GetColumn(&v50, &v49, 2, 0LL);
		  z = viewConstants->worldSpaceCameraPos.z;
		  *(_QWORD *)&v51.x = _mm_unpacklo_ps((__m128)v37, _mm_shuffle_ps((__m128)v37, (__m128)v37, 85)).m128_u64[0];
		  v47.z = z;
		  v39 = viewConstants->prevWorldSpaceCameraPos.z;
		  *(_QWORD *)&v52.x = _mm_unpacklo_ps((__m128)v33, _mm_shuffle_ps((__m128)v33, (__m128)v33, 85)).m128_u64[0];
		  *(_QWORD *)&v47.x = *(_QWORD *)&viewConstants->worldSpaceCameraPos.x;
		  *(_QWORD *)&v48.x = *(_QWORD *)&viewConstants->prevWorldSpaceCameraPos.x;
		  LODWORD(v51.z) = _mm_shuffle_ps((__m128)v37, (__m128)v37, 170).m128_u32[0];
		  LODWORD(v52.z) = _mm_shuffle_ps((__m128)v33, (__m128)v33, 170).m128_u32[0];
		  v48.z = v39;
		  v41 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v50, &v48, &v47, v40);
		  *(_QWORD *)&v29 = *(_QWORD *)&v41->x;
		  *(float *)&v41 = v41->z;
		  *(_QWORD *)&v47.x = v29;
		  LODWORD(v47.z) = (_DWORD)v41;
		  sqrMagnitude = UnityEngine::Vector3::get_sqrMagnitude(&v47, v42);
		  return v11 > v21
		      || v11 > v31
		      || v11 > UnityEngine::Vector3::Dot(&v52, &v51, v43)
		      || sqrMagnitude > (float)(cameraPositionThreshold * cameraPositionThreshold);
		}
		
		internal void PrepareBasicCameraTransforms(ref BasicTransformConstants basicTransformConstants, [IsReadOnly] in Matrix4x4? pretransformMatrix) {} // 0x000000018391B250-0x000000018391BA90
		// Void PrepareBasicCameraTransforms(BasicTransformConstants ByRef, Nullable`1[UnityEngine.Matrix4x4] ByRef)
		void HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
		        HGCamera *this,
		        BasicTransformConstants *basicTransformConstants,
		        Nullable_1_UnityEngine_Matrix4x4_ *pretransformMatrix,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int128 v9; // xmm4
		  __int128 v10; // xmm5
		  __int128 v11; // xmm6
		  Vector4 v12; // xmm7
		  __int128 v13; // xmm0
		  void (__fastcall *v14)(__int128 *, __int128 *, __int128 *, MethodInfo *); // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  __int128 v17; // xmm3
		  __int128 v18; // xmm1
		  __int128 v19; // xmm2
		  __int128 v20; // xmm3
		  __int128 v21; // xmm1
		  Vector4 v22; // xmm1
		  void (__fastcall *v23)(__int128 *, __int128 *, __int128 *); // rax
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm1
		  __int128 v28; // xmm2
		  __int128 v29; // xmm3
		  __int128 v30; // xmm0
		  Vector4 v31; // xmm1
		  __int128 v32; // xmm1
		  Vector4 v33; // xmm1
		  void (__fastcall *v34)(__int128 *, __int128 *, __int128 *); // rax
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  Vector4 v40; // xmm1
		  void (__fastcall *v41)(__int128 *, __int128 *, __int128 *); // rax
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm1
		  __int128 v46; // xmm2
		  __int128 v47; // xmm3
		  __int128 v48; // xmm0
		  __int128 v49; // xmm0
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  Vector4 v52; // xmm1
		  void (__fastcall *v53)(__int128 *, __int128 *, __int128 *); // rax
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  Vector4 v59; // xmm1
		  void (__fastcall *v60)(__int128 *, __int128 *); // rax
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int128 v64; // xmm1
		  __int128 v65; // xmm2
		  __int128 v66; // xmm3
		  __int128 v67; // xmm0
		  __int128 v68; // xmm0
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm0
		  __int128 v72; // xmm1
		  float z; // eax
		  MethodInfo *v74; // r8
		  __int128 v75; // xmm0
		  __int128 v76; // xmm2
		  __int128 v77; // xmm3
		  __int128 v78; // xmm1
		  __int128 v79; // xmm2
		  __int128 v80; // xmm3
		  __int128 v81; // xmm1
		  __int128 v82; // xmm2
		  __int128 v83; // xmm3
		  __int128 v84; // xmm1
		  __int128 v85; // xmm2
		  __int128 v86; // xmm3
		  __int128 v87; // xmm1
		  __int128 v88; // xmm2
		  __int128 v89; // xmm3
		  __int128 v90; // xmm1
		  __int128 v91; // xmm2
		  __int128 v92; // xmm3
		  __int128 v93; // xmm1
		  __int128 v94; // xmm2
		  __int128 v95; // xmm3
		  __int128 v96; // xmm1
		  __int128 v97; // xmm2
		  __int128 v98; // xmm3
		  __int128 v99; // xmm1
		  __int128 v100; // xmm2
		  __int128 v101; // xmm3
		  float v102; // eax
		  MethodInfo *v103; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int64 v106; // rax
		  __int64 v107; // rax
		  __int64 v108; // rax
		  __int64 v109; // rax
		  __int64 v110; // rax
		  __int64 v111; // rax
		  __int128 v112; // [rsp+30h] [rbp-D0h] BYREF
		  Vector4 v113; // [rsp+40h] [rbp-C0h] BYREF
		  __int128 v114; // [rsp+50h] [rbp-B0h]
		  __int128 v115; // [rsp+60h] [rbp-A0h]
		  __int128 v116; // [rsp+70h] [rbp-90h] BYREF
		  __int128 v117; // [rsp+80h] [rbp-80h]
		  __int128 v118; // [rsp+90h] [rbp-70h]
		  __int128 v119; // [rsp+A0h] [rbp-60h]
		  __int128 v120; // [rsp+B0h] [rbp-50h] BYREF
		  __int128 v121; // [rsp+C0h] [rbp-40h]
		  __int128 v122; // [rsp+D0h] [rbp-30h]
		  __int128 v123; // [rsp+E0h] [rbp-20h]
		  __int128 v124; // [rsp+F0h] [rbp-10h] BYREF
		  __int128 v125; // [rsp+100h] [rbp+0h]
		  __int128 v126; // [rsp+110h] [rbp+10h]
		  Vector4 v127; // [rsp+120h] [rbp+20h]
		  __int128 v128; // [rsp+130h] [rbp+30h] BYREF
		  __int128 v129; // [rsp+140h] [rbp+40h]
		  __int128 v130; // [rsp+150h] [rbp+50h]
		  Vector4 v131; // [rsp+160h] [rbp+60h]
		  __int128 v132; // [rsp+170h] [rbp+70h] BYREF
		  __int128 v133; // [rsp+180h] [rbp+80h]
		  __int128 v134; // [rsp+190h] [rbp+90h]
		  Vector4 v135; // [rsp+1A0h] [rbp+A0h]
		  __int128 v136; // [rsp+1B0h] [rbp+B0h] BYREF
		  __int128 v137; // [rsp+1C0h] [rbp+C0h]
		  __int128 v138; // [rsp+1D0h] [rbp+D0h]
		  Vector4 v139; // [rsp+1E0h] [rbp+E0h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_14;
		  if ( wrapperArray->max_length.size > 888 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x378 )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !v6[18].vtable.ToString.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(888, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_349(
		          Patch,
		          (Object *)this,
		          basicTransformConstants,
		          pretransformMatrix,
		          0LL);
		        return;
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  if ( pretransformMatrix->hasValue )
		  {
		    v9 = *(_OWORD *)&pretransformMatrix->value.m00;
		    v10 = *(_OWORD *)&pretransformMatrix->value.m01;
		    v11 = *(_OWORD *)&pretransformMatrix->value.m02;
		    v12 = *(Vector4 *)&pretransformMatrix->value.m03;
		  }
		  else
		  {
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v9 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v10 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    v11 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v12 = *(Vector4 *)&static_fields->identityMatrix.m03;
		  }
		  v113 = v12;
		  v115 = v11;
		  v114 = v10;
		  v112 = v9;
		  v13 = *(_OWORD *)&this->fields.mainViewConstants.viewMatrix.m00;
		  v14 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *, MethodInfo *))qword_18F36FA50;
		  v130 = v11;
		  v131 = v12;
		  v128 = v9;
		  v129 = v10;
		  v15 = *(_OWORD *)&this->fields.mainViewConstants.viewMatrix.m01;
		  v16 = *(_OWORD *)&this->fields.mainViewConstants.viewMatrix.m02;
		  v17 = *(_OWORD *)&this->fields.mainViewConstants.viewMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->current._ViewMatrix.m00 = v13;
		  *(_OWORD *)&basicTransformConstants->current._ViewMatrix.m01 = v15;
		  *(_OWORD *)&basicTransformConstants->current._ViewMatrix.m02 = v16;
		  *(_OWORD *)&basicTransformConstants->current._ViewMatrix.m03 = v17;
		  v18 = *(_OWORD *)&this->fields.mainViewConstants.invViewMatrix.m01;
		  v19 = *(_OWORD *)&this->fields.mainViewConstants.invViewMatrix.m02;
		  v20 = *(_OWORD *)&this->fields.mainViewConstants.invViewMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->current._InvViewMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.invViewMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->current._InvViewMatrix.m01 = v18;
		  *(_OWORD *)&basicTransformConstants->current._InvViewMatrix.m02 = v19;
		  *(_OWORD *)&basicTransformConstants->current._InvViewMatrix.m03 = v20;
		  v21 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m01;
		  v124 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m00;
		  v125 = v21;
		  v22 = *(Vector4 *)&this->fields.mainViewConstants.projMatrix.m03;
		  v126 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m02;
		  v127 = v22;
		  v116 = 0LL;
		  v117 = 0LL;
		  v118 = 0LL;
		  v119 = 0LL;
		  if ( !v14 )
		  {
		    v14 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                   "UnityEngine.Matrix4x4::HGMultiplyMatr"
		                                                                                   "ix4x4Fast_Injected(UnityEngine.Matrix"
		                                                                                   "4x4&,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v14 )
		    {
		      v106 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v106, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v14;
		  }
		  v14(&v128, &v124, &v116, method);
		  v23 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18F36FA50;
		  v24 = v117;
		  *(_OWORD *)&basicTransformConstants->current._ProjMatrix.m00 = v116;
		  v25 = v118;
		  *(_OWORD *)&basicTransformConstants->current._ProjMatrix.m01 = v24;
		  v26 = v119;
		  *(_OWORD *)&basicTransformConstants->current._ProjMatrix.m02 = v25;
		  *(_OWORD *)&basicTransformConstants->current._ProjMatrix.m03 = v26;
		  v27 = *(_OWORD *)&this->fields.mainViewConstants.invProjMatrix.m01;
		  v28 = *(_OWORD *)&this->fields.mainViewConstants.invProjMatrix.m02;
		  v29 = *(_OWORD *)&this->fields.mainViewConstants.invProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->current._InvProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.invProjMatrix.m00;
		  v30 = v112;
		  *(_OWORD *)&basicTransformConstants->current._InvProjMatrix.m01 = v27;
		  v132 = v30;
		  v133 = v114;
		  v134 = v115;
		  v31 = v113;
		  *(_OWORD *)&basicTransformConstants->current._InvProjMatrix.m02 = v28;
		  v135 = v31;
		  *(_OWORD *)&basicTransformConstants->current._InvProjMatrix.m03 = v29;
		  v32 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m01;
		  v136 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m00;
		  v137 = v32;
		  v33 = *(Vector4 *)&this->fields.mainViewConstants.viewProjMatrix.m03;
		  v138 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m02;
		  v139 = v33;
		  v120 = 0LL;
		  v121 = 0LL;
		  v122 = 0LL;
		  v123 = 0LL;
		  if ( !v23 )
		  {
		    v23 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v23 )
		    {
		      v107 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v107, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v23;
		  }
		  v23(&v132, &v136, &v120);
		  v34 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18F36FA50;
		  v35 = v121;
		  *(_OWORD *)&basicTransformConstants->current._ViewProjMatrix.m00 = v120;
		  v36 = v122;
		  *(_OWORD *)&basicTransformConstants->current._ViewProjMatrix.m01 = v35;
		  v37 = v123;
		  *(_OWORD *)&basicTransformConstants->current._ViewProjMatrix.m02 = v36;
		  v38 = v112;
		  *(_OWORD *)&basicTransformConstants->current._ViewProjMatrix.m03 = v37;
		  v124 = v38;
		  v39 = *(_OWORD *)&this->fields.mainViewConstants.viewNoTransProjMatrix.m01;
		  v125 = v114;
		  v129 = v39;
		  v40 = *(Vector4 *)&this->fields.mainViewConstants.viewNoTransProjMatrix.m03;
		  v126 = v115;
		  v131 = v40;
		  v127 = v113;
		  v128 = *(_OWORD *)&this->fields.mainViewConstants.viewNoTransProjMatrix.m00;
		  v130 = *(_OWORD *)&this->fields.mainViewConstants.viewNoTransProjMatrix.m02;
		  v116 = 0LL;
		  v117 = 0LL;
		  v118 = 0LL;
		  v119 = 0LL;
		  if ( !v34 )
		  {
		    v34 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v34 )
		    {
		      v108 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v108, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v34;
		  }
		  v34(&v124, &v128, &v116);
		  v41 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18F36FA50;
		  v42 = v117;
		  *(_OWORD *)&basicTransformConstants->current._ViewNoTransProjMatrix.m00 = v116;
		  v43 = v118;
		  *(_OWORD *)&basicTransformConstants->current._ViewNoTransProjMatrix.m01 = v42;
		  v44 = v119;
		  *(_OWORD *)&basicTransformConstants->current._ViewNoTransProjMatrix.m02 = v43;
		  *(_OWORD *)&basicTransformConstants->current._ViewNoTransProjMatrix.m03 = v44;
		  v45 = *(_OWORD *)&this->fields.mainViewConstants.invViewProjMatrix.m01;
		  v46 = *(_OWORD *)&this->fields.mainViewConstants.invViewProjMatrix.m02;
		  v47 = *(_OWORD *)&this->fields.mainViewConstants.invViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->current._InvViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.invViewProjMatrix.m00;
		  v48 = v112;
		  *(_OWORD *)&basicTransformConstants->current._InvViewProjMatrix.m01 = v45;
		  v136 = v48;
		  v49 = v114;
		  *(_OWORD *)&basicTransformConstants->current._InvViewProjMatrix.m02 = v46;
		  v137 = v49;
		  v50 = v115;
		  *(_OWORD *)&basicTransformConstants->current._InvViewProjMatrix.m03 = v47;
		  v138 = v50;
		  v51 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewProjMatrix.m01;
		  v139 = v113;
		  v133 = v51;
		  v52 = *(Vector4 *)&this->fields.mainViewConstants.nonJitteredViewProjMatrix.m03;
		  v132 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewProjMatrix.m00;
		  v135 = v52;
		  v134 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewProjMatrix.m02;
		  v120 = 0LL;
		  v121 = 0LL;
		  v122 = 0LL;
		  v123 = 0LL;
		  if ( !v41 )
		  {
		    v41 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v41 )
		    {
		      v109 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v109, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v41;
		  }
		  v41(&v136, &v132, &v120);
		  v53 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18F36FA50;
		  v54 = v121;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewProjMatrix.m00 = v120;
		  v55 = v122;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewProjMatrix.m01 = v54;
		  v56 = v123;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewProjMatrix.m02 = v55;
		  v57 = v112;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewProjMatrix.m03 = v56;
		  v124 = v57;
		  v58 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m01;
		  v125 = v114;
		  v129 = v58;
		  v59 = *(Vector4 *)&this->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m03;
		  v126 = v115;
		  v131 = v59;
		  v127 = v113;
		  v128 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m00;
		  v130 = *(_OWORD *)&this->fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m02;
		  v116 = 0LL;
		  v117 = 0LL;
		  v118 = 0LL;
		  v119 = 0LL;
		  if ( !v53 )
		  {
		    v53 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v53 )
		    {
		      v110 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v110, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v53;
		  }
		  v53(&v124, &v128, &v116);
		  v60 = (void (__fastcall *)(__int128 *, __int128 *))qword_18F36FA60;
		  v61 = v117;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewNoTransProjMatrix.m00 = v116;
		  v62 = v118;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewNoTransProjMatrix.m01 = v61;
		  v63 = v119;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewNoTransProjMatrix.m02 = v62;
		  *(_OWORD *)&basicTransformConstants->current._NonJitteredViewNoTransProjMatrix.m03 = v63;
		  v64 = *(_OWORD *)&this->fields.mainViewConstants.invNonJitteredViewProjMatrix.m01;
		  v65 = *(_OWORD *)&this->fields.mainViewConstants.invNonJitteredViewProjMatrix.m02;
		  v66 = *(_OWORD *)&this->fields.mainViewConstants.invNonJitteredViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->current._InvNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.invNonJitteredViewProjMatrix.m00;
		  v67 = v112;
		  *(_OWORD *)&basicTransformConstants->current._InvNonJitteredViewProjMatrix.m01 = v64;
		  v132 = v67;
		  v68 = v114;
		  *(_OWORD *)&basicTransformConstants->current._InvNonJitteredViewProjMatrix.m02 = v65;
		  v133 = v68;
		  v69 = v115;
		  *(_OWORD *)&basicTransformConstants->current._InvNonJitteredViewProjMatrix.m03 = v66;
		  v134 = v69;
		  v135 = v113;
		  v120 = 0LL;
		  v121 = 0LL;
		  v122 = 0LL;
		  v123 = 0LL;
		  if ( !v60 )
		  {
		    v60 = (void (__fastcall *)(__int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,"
		                                                         "UnityEngine.Matrix4x4&)");
		    if ( !v60 )
		    {
		      v111 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v111, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v60;
		  }
		  v60(&v132, &v120);
		  v70 = v121;
		  *(_OWORD *)&basicTransformConstants->current._InvPretransformMatrix.m00 = v120;
		  v71 = v122;
		  *(_OWORD *)&basicTransformConstants->current._InvPretransformMatrix.m01 = v70;
		  v72 = v123;
		  *(_OWORD *)&basicTransformConstants->current._InvPretransformMatrix.m02 = v71;
		  *(_OWORD *)&basicTransformConstants->current._InvPretransformMatrix.m03 = v72;
		  z = this->fields.mainViewConstants.worldSpaceCameraPos.z;
		  *(_QWORD *)&v112 = *(_QWORD *)&this->fields.mainViewConstants.worldSpaceCameraPos.x;
		  *((float *)&v112 + 2) = z;
		  basicTransformConstants->current._WorldSpaceCameraPos_Internal = *UnityEngine::Vector4::op_Implicit(
		                                                                      &v113,
		                                                                      (Vector3 *)&v112,
		                                                                      v74);
		  v75 = *(_OWORD *)&this->fields.mainViewConstants.prevViewProjMatrix.m01;
		  v76 = *(_OWORD *)&this->fields.mainViewConstants.prevViewProjMatrix.m02;
		  v77 = *(_OWORD *)&this->fields.mainViewConstants.prevViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevViewProjMatrix.m01 = v75;
		  *(_OWORD *)&basicTransformConstants->_PrevViewProjMatrix.m02 = v76;
		  *(_OWORD *)&basicTransformConstants->_PrevViewProjMatrix.m03 = v77;
		  v78 = *(_OWORD *)&this->fields.mainViewConstants.prevViewNoTransProjMatrix.m01;
		  v79 = *(_OWORD *)&this->fields.mainViewConstants.prevViewNoTransProjMatrix.m02;
		  v80 = *(_OWORD *)&this->fields.mainViewConstants.prevViewNoTransProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevViewNoTransProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevViewNoTransProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevViewNoTransProjMatrix.m01 = v78;
		  *(_OWORD *)&basicTransformConstants->_PrevViewNoTransProjMatrix.m02 = v79;
		  *(_OWORD *)&basicTransformConstants->_PrevViewNoTransProjMatrix.m03 = v80;
		  v81 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewProjMatrix.m01;
		  v82 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewProjMatrix.m02;
		  v83 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewProjMatrix.m01 = v81;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewProjMatrix.m02 = v82;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewProjMatrix.m03 = v83;
		  v84 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m01;
		  v85 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m02;
		  v86 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewNoTransProjMatrix.m01 = v84;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewNoTransProjMatrix.m02 = v85;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredViewNoTransProjMatrix.m03 = v86;
		  v87 = *(_OWORD *)&this->fields.mainViewConstants.prevInvViewProjMatrix.m01;
		  v88 = *(_OWORD *)&this->fields.mainViewConstants.prevInvViewProjMatrix.m02;
		  v89 = *(_OWORD *)&this->fields.mainViewConstants.prevInvViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevInvViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevInvViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevInvViewProjMatrix.m01 = v87;
		  *(_OWORD *)&basicTransformConstants->_PrevInvViewProjMatrix.m02 = v88;
		  *(_OWORD *)&basicTransformConstants->_PrevInvViewProjMatrix.m03 = v89;
		  v90 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m01;
		  v91 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m02;
		  v92 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredInvViewProjMatrix.m01 = v90;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredInvViewProjMatrix.m02 = v91;
		  *(_OWORD *)&basicTransformConstants->_PrevNonJitteredInvViewProjMatrix.m03 = v92;
		  v93 = *(_OWORD *)&this->fields.mainViewConstants.reprojectionMatrix.m01;
		  v94 = *(_OWORD *)&this->fields.mainViewConstants.reprojectionMatrix.m02;
		  v95 = *(_OWORD *)&this->fields.mainViewConstants.reprojectionMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_ReprojectionMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.reprojectionMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_ReprojectionMatrix.m01 = v93;
		  *(_OWORD *)&basicTransformConstants->_ReprojectionMatrix.m02 = v94;
		  *(_OWORD *)&basicTransformConstants->_ReprojectionMatrix.m03 = v95;
		  v96 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVViewProjMatrix.m01;
		  v97 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVViewProjMatrix.m02;
		  v98 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVViewProjMatrix.m01 = v96;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVViewProjMatrix.m02 = v97;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVViewProjMatrix.m03 = v98;
		  v99 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVInvViewProjMatrix.m01;
		  v100 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVInvViewProjMatrix.m02;
		  v101 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVInvViewProjMatrix.m03;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVInvViewProjMatrix.m00 = *(_OWORD *)&this->fields.mainViewConstants.widerFoVInvViewProjMatrix.m00;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVInvViewProjMatrix.m01 = v99;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVInvViewProjMatrix.m02 = v100;
		  *(_OWORD *)&basicTransformConstants->_WiderFoVInvViewProjMatrix.m03 = v101;
		  v102 = this->fields.mainViewConstants.prevWorldSpaceCameraPos.z;
		  *(_QWORD *)&v112 = *(_QWORD *)&this->fields.mainViewConstants.prevWorldSpaceCameraPos.x;
		  *((float *)&v112 + 2) = v102;
		  basicTransformConstants->_PrevCamPosRWS_Internal = *UnityEngine::Vector4::op_Implicit(&v113, (Vector3 *)&v112, v103);
		}
		
		[IDTag(1)]
		internal void UpdateShaderVariablesGlobalCB(ref ShaderVariablesGlobal cb, ref BasicTransformConstants basicTransformConstants, Matrix4x4 preTransform) {} // 0x00000001832DE2D0-0x00000001832DE390
		// Void UpdateShaderVariablesGlobalCB(ShaderVariablesGlobal ByRef, BasicTransformConstants ByRef, Matrix4x4)
		void HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
		        HGCamera *this,
		        ShaderVariablesGlobal *cb,
		        BasicTransformConstants *basicTransformConstants,
		        Matrix4x4 *preTransform,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  uint32_t cameraFrameCount; // eax
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  Matrix4x4 v19; // [rsp+30h] [rbp-48h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 886 )
		  {
		LABEL_5:
		    cameraFrameCount = this->fields.cameraFrameCount;
		    v12 = *(_OWORD *)&preTransform->m01;
		    *(_OWORD *)&v19.m00 = *(_OWORD *)&preTransform->m00;
		    v13 = *(_OWORD *)&preTransform->m02;
		    *(_OWORD *)&v19.m01 = v12;
		    v14 = *(_OWORD *)&preTransform->m03;
		    *(_OWORD *)&v19.m02 = v13;
		    *(_OWORD *)&v19.m03 = v14;
		    HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
		      this,
		      basicTransformConstants,
		      cb,
		      &v19,
		      cameraFrameCount,
		      0LL);
		    return;
		  }
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		  if ( !v7 )
		    goto LABEL_6;
		  if ( LODWORD(v7->_0.namespaze) <= 0x376 )
		    sub_1800D2AB0(v7, cb);
		  if ( !v7[18].vtable.GetHashCode.method )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(886, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v7, cb);
		  v16 = *(_OWORD *)&preTransform->m01;
		  *(_OWORD *)&v19.m00 = *(_OWORD *)&preTransform->m00;
		  v17 = *(_OWORD *)&preTransform->m02;
		  *(_OWORD *)&v19.m01 = v16;
		  v18 = *(_OWORD *)&preTransform->m03;
		  *(_OWORD *)&v19.m02 = v17;
		  *(_OWORD *)&v19.m03 = v18;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_352(Patch, (Object *)this, cb, basicTransformConstants, &v19, 0LL);
		}
		
		[IDTag(0)]
		internal void UpdateShaderVariablesGlobalCB(ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal cb, Matrix4x4 preTransform, uint frameCount) {} // 0x00000001832E0020-0x00000001832E0B60
		// Void UpdateShaderVariablesGlobalCB(BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, Matrix4x4, UInt32)
		void HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
		        HGCamera *this,
		        BasicTransformConstants *basicTransformConstants,
		        ShaderVariablesGlobal *cb,
		        Matrix4x4 *preTransform,
		        uint32_t frameCount,
		        MethodInfo *method)
		{
		  Vector4 *Patch; // rcx
		  __int64 v11; // rdx
		  bool v12; // zf
		  BitArray128 bitDatas; // xmm6
		  __int64 v14; // xmm0_8
		  bool v15; // al
		  int32_t m_antialiasingMode; // eax
		  Camera *camera; // r14
		  unsigned int (__fastcall *v18)(Camera *); // rax
		  unsigned __int8 v19; // r14
		  __int128 v20; // xmm1
		  __m128i v21; // xmm2
		  __int128 v22; // xmm0
		  Camera *v23; // rsi
		  __int64 (__fastcall *v24)(Camera *); // rax
		  __int64 v25; // rax
		  struct Object_1__Class *v26; // rcx
		  __int64 v27; // rsi
		  __m128 v28; // xmm5
		  __m128 v29; // xmm5
		  __m128 v30; // xmm5
		  __m128 v31; // xmm5
		  __m128 v32; // xmm5
		  __m128 v33; // xmm5
		  __m128 v34; // xmm5
		  __m128 v35; // xmm5
		  __m128 v36; // xmm5
		  __m128 v37; // xmm5
		  int v38; // r10d
		  __int64 v39; // r11
		  __int64 i; // r9
		  Vector4__Array *frustumPlaneEquations; // rax
		  __int64 v42; // rax
		  __m128 v43; // xmm3
		  __m128 v44; // xmm3
		  __m128 v45; // xmm3
		  float globalMipBias_k__BackingField; // xmm6_4
		  double v47; // xmm0_8
		  float v48; // xmm0_4
		  __m128 exposureAdaptation_low; // xmm6
		  Vector4 v50; // xmm7
		  float y; // xmm1_4
		  __m128 v52; // xmm0
		  __m128 v53; // xmm6
		  __m128 v54; // xmm6
		  __m128 v55; // xmm6
		  __m128 v56; // xmm15
		  float gameplayTime; // xmm14_4
		  __m128 v58; // xmm13
		  __m128 v59; // xmm2
		  float smoothDeltaTime; // xmm12_4
		  __m128 v61; // xmm0
		  __m128 v62; // xmm2
		  __m128 v63; // xmm2
		  __m128 v64; // xmm2
		  Beyond::DampingMath *v65; // rcx
		  Beyond::DampingMath *v66; // rcx
		  Beyond::DampingMath *v67; // rcx
		  Beyond::DampingMath *v68; // rcx
		  __m128 v69; // xmm8
		  __m128 v70; // xmm8
		  __m128 v71; // xmm8
		  __m128 v72; // xmm0
		  Beyond::DampingMath *v73; // rcx
		  Beyond::DampingMath *v74; // rcx
		  Beyond::DampingMath *v75; // rcx
		  Beyond::DampingMath *v76; // rcx
		  __m128 v77; // xmm8
		  __m128 v78; // xmm8
		  __m128 v79; // xmm8
		  __m128 v80; // xmm13
		  __m128 v81; // xmm13
		  __m128 v82; // xmm13
		  Beyond::DampingMath *v83; // rcx
		  float v84; // xmm6_4
		  Beyond::DampingMath *v85; // rcx
		  BitArray128 v86; // xmm7
		  __m128 v87; // xmm15
		  __m128 v88; // xmm15
		  __m128 v89; // xmm15
		  Beyond::DampingMath *v90; // rcx
		  float v91; // xmm6_4
		  Beyond::DampingMath *v92; // rcx
		  __m128 v93; // xmm7
		  __m128 v94; // xmm7
		  __m128 v95; // xmm7
		  HGAdditionalCameraData *m_AdditionalCameraData; // rsi
		  HGAdditionalCameraData *v97; // rax
		  float probeCustomFixedExposure; // xmm0_4
		  __int128 v99; // xmm1
		  __int128 v100; // xmm0
		  __int128 v101; // xmm1
		  ILFixDynamicMethodWrapper_2 *v102; // rax
		  ILFixDynamicMethodWrapper_2 *v103; // rax
		  __int64 v104; // rax
		  ILFixDynamicMethodWrapper_2 *v105; // rax
		  Vector4 taauRTSizeParam_k__BackingField; // xmm2
		  __m128 v107; // xmm5
		  __m128 v108; // xmm5
		  ILFixDynamicMethodWrapper_2 *v109; // rax
		  Vector4 v110; // xmm2
		  __m128 v111; // xmm5
		  __m128 v112; // xmm5
		  ILFixDynamicMethodWrapper_2 *v113; // rax
		  Vector4 *v114; // rax
		  ILFixDynamicMethodWrapper_2 *v115; // rax
		  Vector4 *v116; // rax
		  ILFixDynamicMethodWrapper_2 *v117; // rax
		  float lastGameplayTime; // [rsp+50h] [rbp-B0h]
		  FrameSettings P0; // [rsp+60h] [rbp-A0h] BYREF
		  _BYTE v120[68]; // [rsp+80h] [rbp-80h] BYREF
		  Nullable_1_UnityEngine_Matrix4x4_ pretransformMatrix; // [rsp+D0h] [rbp-30h] BYREF
		
		  Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) > 887 )
		  {
		    if ( !LODWORD(Patch[14].x) )
		    {
		      il2cpp_runtime_class_init_1(Patch);
		      Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v11 = **(_QWORD **)&Patch[11].z;
		    if ( !v11 )
		      goto LABEL_92;
		    if ( *(_DWORD *)(v11 + 24) <= 0x377u )
		      goto LABEL_97;
		    if ( *(_QWORD *)(v11 + 7128) )
		    {
		      Patch = (Vector4 *)IFix::WrappersManagerImpl::GetPatch(887, 0LL);
		      if ( Patch )
		      {
		        v99 = *(_OWORD *)&preTransform->m01;
		        *(_OWORD *)v120 = *(_OWORD *)&preTransform->m00;
		        v100 = *(_OWORD *)&preTransform->m02;
		        *(_OWORD *)&v120[16] = v99;
		        v101 = *(_OWORD *)&preTransform->m03;
		        *(_OWORD *)&v120[32] = v100;
		        *(_OWORD *)&v120[48] = v101;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_351(
		          (ILFixDynamicMethodWrapper_2 *)Patch,
		          (Object *)this,
		          basicTransformConstants,
		          cb,
		          (Matrix4x4 *)v120,
		          frameCount,
		          0LL);
		        return;
		      }
		      goto LABEL_92;
		    }
		  }
		  v12 = LODWORD(Patch[14].x) == 0;
		  bitDatas = this->fields._frameSettings_k__BackingField.bitDatas;
		  v14 = *(_QWORD *)&this->fields._frameSettings_k__BackingField.materialQuality;
		  P0.bitDatas = bitDatas;
		  *(_QWORD *)&P0.materialQuality = v14;
		  if ( v12 )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 734 )
		    goto LABEL_9;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(_DWORD *)(v11 + 24) <= 0x2DEu )
		    goto LABEL_97;
		  if ( *(_QWORD *)(v11 + 5904) )
		  {
		    v102 = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
		    if ( !v102 )
		      goto LABEL_92;
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_292(v102, &P0, FrameSettingsField__Enum_Postprocess, 0LL);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    v15 = (bitDatas.data1 & 0x8000) != 0LL;
		  }
		  if ( !v15 )
		    goto LABEL_91;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 732 )
		    goto LABEL_15;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(_DWORD *)(v11 + 24) <= 0x2DCu )
		    goto LABEL_97;
		  if ( *(_QWORD *)(v11 + 5888) )
		  {
		    v103 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		    if ( !v103 )
		      goto LABEL_92;
		    m_antialiasingMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                           (ILFixDynamicMethodWrapper_31 *)v103,
		                           (Object *)this,
		                           0LL);
		  }
		  else
		  {
		LABEL_15:
		    m_antialiasingMode = this->fields.m_antialiasingMode;
		  }
		  if ( m_antialiasingMode != 2 )
		    goto LABEL_91;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_92;
		  v18 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v18 = (unsigned int (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_cameraType()");
		    qword_18F36F138 = (__int64)v18;
		  }
		  if ( v18(camera) == 1 )
		    v19 = 1;
		  else
		LABEL_91:
		    v19 = 0;
		  v20 = *(_OWORD *)&preTransform->m01;
		  v21 = *(__m128i *)&preTransform->m03;
		  memset(&v120[16], 0, 48);
		  *(_OWORD *)v120 = 0LL;
		  v120[0] = 1;
		  v22 = *(_OWORD *)&preTransform->m00;
		  *(_OWORD *)&v120[20] = v20;
		  *(_OWORD *)&v120[4] = v22;
		  *(_OWORD *)&v120[36] = *(_OWORD *)&preTransform->m02;
		  *(__m128i *)&v120[52] = v21;
		  *(_OWORD *)&pretransformMatrix.hasValue = *(_OWORD *)v120;
		  *(_OWORD *)&pretransformMatrix.value.m30 = *(_OWORD *)&v120[16];
		  *(_OWORD *)&pretransformMatrix.value.m31 = *(_OWORD *)&v120[32];
		  *(_OWORD *)&pretransformMatrix.value.m32 = *(_OWORD *)&v120[48];
		  LODWORD(pretransformMatrix.value.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v21, 12));
		  HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
		    this,
		    basicTransformConstants,
		    &pretransformMatrix,
		    0LL);
		  v23 = this->fields.camera;
		  if ( !v23 )
		    goto LABEL_92;
		  v24 = (__int64 (__fastcall *)(Camera *))qword_18F36F1B8;
		  if ( !qword_18F36F1B8 )
		  {
		    v24 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::GetLightWeightCamera()");
		    if ( !v24 )
		    {
		      v104 = sub_1802EE1B8("UnityEngine.Camera::GetLightWeightCamera()");
		      sub_18007E1B0(v104, 0LL);
		    }
		    qword_18F36F1B8 = (__int64)v24;
		  }
		  v25 = v24(v23);
		  v26 = TypeInfo::UnityEngine::Object;
		  v27 = v25;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v26 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v26 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v27 && !v26->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v26);
		  cb->_ZBufferParams = this->fields.zBufferParams;
		  cb->_ProjectionParams = this->fields.projectionParams;
		  cb->unity_OrthoParams = this->fields.unity_OrthoParams;
		  Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 889 )
		    goto LABEL_33;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  Patch = **(Vector4 ***)&Patch[11].z;
		  if ( !Patch )
		    goto LABEL_92;
		  if ( LODWORD(Patch[1].z) <= 0x379 )
		    goto LABEL_97;
		  if ( *(_QWORD *)&Patch[446].z )
		  {
		    v105 = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
		    if ( !v105 )
		      goto LABEL_92;
		    v32 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&P0, v105, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_33:
		    if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		    {
		      taauRTSizeParam_k__BackingField = this->fields._taauRTSizeParam_k__BackingField;
		      v107 = _mm_shuffle_ps((__m128)taauRTSizeParam_k__BackingField, (__m128)taauRTSizeParam_k__BackingField, 225);
		      v107.m128_f32[0] = _mm_shuffle_ps(
		                           (__m128)taauRTSizeParam_k__BackingField,
		                           (__m128)taauRTSizeParam_k__BackingField,
		                           85).m128_f32[0];
		      v108 = _mm_shuffle_ps(v107, v107, 198);
		      v108.m128_f32[0] = _mm_shuffle_ps(
		                           (__m128)taauRTSizeParam_k__BackingField,
		                           (__m128)taauRTSizeParam_k__BackingField,
		                           170).m128_f32[0];
		      v31 = _mm_shuffle_ps(v108, v108, 39);
		      v31.m128_f32[0] = _mm_shuffle_ps(
		                          (__m128)taauRTSizeParam_k__BackingField,
		                          (__m128)taauRTSizeParam_k__BackingField,
		                          255).m128_f32[0];
		    }
		    else
		    {
		      v28 = 0LL;
		      v28.m128_f32[0] = (float)this->fields.m_finalRTSize.m_X;
		      v29 = _mm_shuffle_ps(v28, v28, 225);
		      v29.m128_f32[0] = (float)this->fields.m_finalRTSize.m_Y;
		      v30 = _mm_shuffle_ps(v29, v29, 198);
		      v30.m128_f32[0] = 1.0 / (float)this->fields.m_finalRTSize.m_X;
		      v31 = _mm_shuffle_ps(v30, v30, 39);
		      v31.m128_f32[0] = 1.0 / (float)this->fields.m_finalRTSize.m_Y;
		    }
		    v32 = _mm_shuffle_ps(v31, v31, 57);
		  }
		  cb->_ScreenSize = (Vector4)v32;
		  Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 889 )
		    goto LABEL_41;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  Patch = **(Vector4 ***)&Patch[11].z;
		  if ( !Patch )
		    goto LABEL_92;
		  if ( LODWORD(Patch[1].z) <= 0x379 )
		    goto LABEL_97;
		  if ( *(_QWORD *)&Patch[446].z )
		  {
		    v109 = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
		    if ( !v109 )
		      goto LABEL_92;
		    v37 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&P0, v109, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_41:
		    if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		    {
		      v110 = this->fields._taauRTSizeParam_k__BackingField;
		      v111 = _mm_shuffle_ps((__m128)v110, (__m128)v110, 225);
		      v111.m128_f32[0] = _mm_shuffle_ps((__m128)v110, (__m128)v110, 85).m128_f32[0];
		      v112 = _mm_shuffle_ps(v111, v111, 198);
		      v112.m128_f32[0] = _mm_shuffle_ps((__m128)v110, (__m128)v110, 170).m128_f32[0];
		      v36 = _mm_shuffle_ps(v112, v112, 39);
		      v36.m128_f32[0] = _mm_shuffle_ps((__m128)v110, (__m128)v110, 255).m128_f32[0];
		    }
		    else
		    {
		      v33 = 0LL;
		      v33.m128_f32[0] = (float)this->fields.m_finalRTSize.m_X;
		      v34 = _mm_shuffle_ps(v33, v33, 225);
		      v34.m128_f32[0] = (float)this->fields.m_finalRTSize.m_Y;
		      v35 = _mm_shuffle_ps(v34, v34, 198);
		      v35.m128_f32[0] = 1.0 / (float)this->fields.m_finalRTSize.m_X;
		      v36 = _mm_shuffle_ps(v35, v35, 39);
		      v36.m128_f32[0] = 1.0 / (float)this->fields.m_finalRTSize.m_Y;
		    }
		    v37 = _mm_shuffle_ps(v36, v36, 57);
		  }
		  cb->_BackBufferSize = (Vector4)v37;
		  v38 = 0;
		  v39 = 0LL;
		  cb->_ScreenParams = this->fields.screenParams;
		  do
		  {
		    v11 = 0LL;
		    for ( i = 0LL; ; ++i )
		    {
		      while ( 1 )
		      {
		        while ( 1 )
		        {
		          frustumPlaneEquations = this->fields.frustumPlaneEquations;
		          if ( !frustumPlaneEquations )
		            goto LABEL_92;
		          if ( (unsigned int)v38 >= frustumPlaneEquations->max_length.size )
		            goto LABEL_97;
		          Patch = &frustumPlaneEquations->vector[v38];
		          if ( (_DWORD)v11 )
		            break;
		          v11 = 1LL;
		          *((_DWORD *)&cb->_FrustumPlanes.FixedElementField + v39 + i++) = LODWORD(Patch->x);
		        }
		        if ( (_DWORD)v11 != 1 )
		          break;
		        v11 = 2LL;
		        *((_DWORD *)&cb->_FrustumPlanes.FixedElementField + v39 + i++) = LODWORD(Patch->y);
		      }
		      if ( (_DWORD)v11 != 2 )
		        break;
		      v11 = 3LL;
		      *((_DWORD *)&cb->_FrustumPlanes.FixedElementField + v39 + i) = LODWORD(Patch->z);
		    }
		    v42 = v39 + i;
		    v39 += 4LL;
		    *((_DWORD *)&cb->_FrustumPlanes.FixedElementField + v42) = LODWORD(Patch->w);
		    ++v38;
		  }
		  while ( v38 < 6 );
		  v43 = _mm_shuffle_ps(
		          (__m128)LODWORD(this->fields.taaSharpenStrength),
		          (__m128)LODWORD(this->fields.taaSharpenStrength),
		          225);
		  v43.m128_f32[0] = this->fields.screenParams.y / this->fields.screenParams.x;
		  v44 = _mm_shuffle_ps(v43, v43, 198);
		  v44.m128_f32[0] = (float)this->fields.taaFrameIndex;
		  v45 = _mm_shuffle_ps(v44, v44, 39);
		  v45.m128_f32[0] = (float)v19;
		  *(__m128 *)&cb->_EnvironmentGlobalParams0.z = _mm_shuffle_ps(v45, v45, 57);
		  *(Vector4 *)&cb->_GraphicsFeaturesGlobalParam0.z = this->fields.taaJitter;
		  cb->_CharacterPositionParams3.z = this->fields._globalMipBias_k__BackingField;
		  globalMipBias_k__BackingField = this->fields._globalMipBias_k__BackingField;
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  if ( globalMipBias_k__BackingField == -INFINITY )
		    goto LABEL_139;
		  if ( globalMipBias_k__BackingField == INFINITY )
		  {
		    v47 = INFINITY;
		    goto LABEL_57;
		  }
		  v47 = 2.0;
		  sub_1801D47B0();
		  if ( -0.0 == 2.0 )
		LABEL_139:
		    v47 = 0.0;
		LABEL_57:
		  v48 = v47;
		  cb->_CharacterPositionParams3.w = v48;
		  Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  exposureAdaptation_low = (__m128)LODWORD(this->fields.exposureAdaptation);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 889 )
		    goto LABEL_62;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(_DWORD *)(v11 + 24) <= 0x379u )
		    goto LABEL_97;
		  if ( *(_QWORD *)(v11 + 7144) )
		  {
		    v113 = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
		    if ( !v113 )
		      goto LABEL_92;
		    v114 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&P0, v113, (Object *)this, 0LL);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v50 = *v114;
		  }
		  else
		  {
		LABEL_62:
		    if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		      v50 = this->fields._taauRTSizeParam_k__BackingField;
		    else
		      v50.x = (float)this->fields.m_finalRTSize.m_X;
		  }
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 889 )
		    goto LABEL_69;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(_DWORD *)(v11 + 24) <= 0x379u )
		    goto LABEL_97;
		  if ( *(_QWORD *)(v11 + 7144) )
		  {
		    v115 = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
		    if ( !v115 )
		      goto LABEL_92;
		    v116 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&P0, v115, (Object *)this, 0LL);
		    LODWORD(y) = _mm_shuffle_ps(*(__m128 *)v116, *(__m128 *)v116, 85).m128_u32[0];
		  }
		  else
		  {
		LABEL_69:
		    if ( this->fields.m_finalRTSize.m_X == -1 || this->fields.m_finalRTSize.m_Y == -1 )
		      y = this->fields._taauRTSizeParam_k__BackingField.y;
		    else
		      y = (float)this->fields.m_finalRTSize.m_Y;
		  }
		  v52 = (__m128)0x3F800000u;
		  v52.m128_f32[0] = 1.0 / exposureAdaptation_low.m128_f32[0];
		  v53 = _mm_shuffle_ps(exposureAdaptation_low, exposureAdaptation_low, 225);
		  v53.m128_f32[0] = v52.m128_f32[0];
		  v54 = _mm_shuffle_ps(v53, v53, 198);
		  v54.m128_f32[0] = v50.x / y;
		  v55 = _mm_shuffle_ps(v54, v54, 39);
		  v55.m128_f32[0] = 1.0 / this->fields.zBufferParams.z;
		  *(__m128 *)&cb->_CharacterHeightParams.z = _mm_shuffle_ps(v55, v55, 57);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    *(double *)v52.m128_u64 = il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		  v52.m128_f32[0] = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
		  v56 = v52;
		  LODWORD(P0.bitDatas.data1) = HG::Rendering::Runtime::HGRPTimeManager::get_lastTime(0LL);
		  gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		  lastGameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
		  v52.m128_f32[0] = UnityEngine::Time::get_deltaTime(0LL);
		  v58 = v52;
		  v59 = v56;
		  smoothDeltaTime = UnityEngine::Time::get_smoothDeltaTime(0LL);
		  v59.m128_f32[0] = v56.m128_f32[0] * 0.050000001;
		  v61 = v56;
		  v61.m128_f32[0] = v56.m128_f32[0] * 0.125;
		  v62 = _mm_shuffle_ps(v59, v59, 225);
		  v62.m128_f32[0] = v56.m128_f32[0];
		  v63 = _mm_shuffle_ps(v62, v62, 198);
		  v63.m128_f32[0] = v56.m128_f32[0] + v56.m128_f32[0];
		  v64 = _mm_shuffle_ps(v63, v63, 39);
		  v64.m128_f32[0] = gameplayTime;
		  *(__m128 *)&cb->_GraphicsFeaturesGlobalParam1.z = _mm_shuffle_ps(v64, v64, 57);
		  Beyond::DampingMath::sinf(v65, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::sinf(v66, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::sinf(v67, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::sinf(v68, v56.m128_f32[0] + v56.m128_f32[0]);
		  v69 = _mm_shuffle_ps(v61, v61, 225);
		  v69.m128_f32[0] = v56.m128_f32[0] * 0.25;
		  v70 = _mm_shuffle_ps(v69, v69, 198);
		  v70.m128_f32[0] = v56.m128_f32[0] * 0.5;
		  v71 = _mm_shuffle_ps(v70, v70, 39);
		  v71.m128_f32[0] = v56.m128_f32[0];
		  v72 = v56;
		  v72.m128_f32[0] = v56.m128_f32[0] * 0.125;
		  *(__m128 *)&cb->_WindGlobalParams0.z = _mm_shuffle_ps(v71, v71, 57);
		  Beyond::DampingMath::cosf(v73, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::cosf(v74, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::cosf(v75, v56.m128_f32[0] + v56.m128_f32[0]);
		  Beyond::DampingMath::cosf(v76, v56.m128_f32[0] + v56.m128_f32[0]);
		  v77 = _mm_shuffle_ps(v72, v72, 225);
		  v77.m128_f32[0] = v56.m128_f32[0] * 0.25;
		  v78 = _mm_shuffle_ps(v77, v77, 198);
		  v78.m128_f32[0] = v56.m128_f32[0] * 0.5;
		  v79 = _mm_shuffle_ps(v78, v78, 39);
		  v79.m128_f32[0] = v56.m128_f32[0];
		  *(__m128 *)&cb->_WindGlobalParams2.z = _mm_shuffle_ps(v79, v79, 57);
		  v72.m128_f32[0] = 1.0 / v58.m128_f32[0];
		  v80 = _mm_shuffle_ps(v58, v58, 225);
		  v80.m128_f32[0] = v72.m128_f32[0];
		  v81 = _mm_shuffle_ps(v80, v80, 198);
		  v81.m128_f32[0] = smoothDeltaTime;
		  v82 = _mm_shuffle_ps(v81, v81, 39);
		  v82.m128_f32[0] = 1.0 / smoothDeltaTime;
		  *(__m128 *)&cb->_CharacterPositionParams0.z = _mm_shuffle_ps(v82, v82, 57);
		  Beyond::DampingMath::sinf(v83, v82.m128_f32[0]);
		  v84 = v56.m128_f32[0];
		  v72.m128_i32[0] = v56.m128_i32[0];
		  Beyond::DampingMath::cosf(v85, v82.m128_f32[0]);
		  v86 = P0.bitDatas;
		  v87 = _mm_shuffle_ps(v56, v56, 225);
		  v87.m128_f32[0] = v84;
		  v88 = _mm_shuffle_ps(v87, v87, 198);
		  v88.m128_f32[0] = v72.m128_f32[0];
		  v72.m128_i32[0] = P0.bitDatas.data1;
		  v89 = _mm_shuffle_ps(v88, v88, 39);
		  v89.m128_f32[0] = gameplayTime;
		  *(__m128 *)&cb->_CharacterPositionParams1.z = _mm_shuffle_ps(v89, v89, 57);
		  Beyond::DampingMath::sinf(v90, v82.m128_f32[0]);
		  v91 = v72.m128_f32[0];
		  v72.m128_i32[0] = v86.data1;
		  Beyond::DampingMath::cosf(v92, v82.m128_f32[0]);
		  v93 = _mm_shuffle_ps((__m128)v86, (__m128)v86, 225);
		  v93.m128_f32[0] = v91;
		  LODWORD(cb->_CharacterHeightParams.y) = frameCount;
		  v94 = _mm_shuffle_ps(v93, v93, 198);
		  v94.m128_f32[0] = v72.m128_f32[0];
		  v95 = _mm_shuffle_ps(v94, v94, 39);
		  v95.m128_f32[0] = lastGameplayTime;
		  *(__m128 *)&cb->_CharacterPositionParams2.z = _mm_shuffle_ps(v95, v95, 57);
		  Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(int *)(v11 + 24) <= 893 )
		    goto LABEL_77;
		  if ( !LODWORD(Patch[14].x) )
		  {
		    il2cpp_runtime_class_init_1(Patch);
		    Patch = (Vector4 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(_QWORD **)&Patch[11].z;
		  if ( !v11 )
		    goto LABEL_92;
		  if ( *(_DWORD *)(v11 + 24) <= 0x37Du )
		LABEL_97:
		    sub_1800D2AB0(Patch, v11);
		  if ( *(_QWORD *)(v11 + 7176) )
		  {
		    v117 = IFix::WrappersManagerImpl::GetPatch(893, 0LL);
		    if ( v117 )
		    {
		      probeCustomFixedExposure = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                                   (ILFixDynamicMethodWrapper_15 *)v117,
		                                   (Object *)this,
		                                   0LL);
		      goto LABEL_84;
		    }
		    goto LABEL_92;
		  }
		LABEL_77:
		  Patch = (Vector4 *)TypeInfo::UnityEngine::Object;
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    Patch = (Vector4 *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      Patch = (Vector4 *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_AdditionalCameraData )
		    goto LABEL_90;
		  if ( !LODWORD(Patch[14].x) )
		    il2cpp_runtime_class_init_1(Patch);
		  if ( !m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		  {
		LABEL_90:
		    probeCustomFixedExposure = 1.0;
		    goto LABEL_84;
		  }
		  v97 = this->fields.m_AdditionalCameraData;
		  if ( !v97 )
		LABEL_92:
		    sub_1800D8260(Patch, v11);
		  probeCustomFixedExposure = v97->fields.probeCustomFixedExposure;
		LABEL_84:
		  if ( probeCustomFixedExposure <= 0.000001 )
		    probeCustomFixedExposure = 0.000001;
		  cb->_CharacterHeightParams.x = 1.0 / probeCustomFixedExposure;
		}
		
		internal void ReleaseHistoryFrameRT(int id) {} // 0x0000000189B735D8-0x0000000189B73644
		// Void ReleaseHistoryFrameRT(Int32)
		void HG::Rendering::Runtime::HGCamera::ReleaseHistoryFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2841, 0LL) )
		  {
		    m_HistoryRTSystem = this->fields.m_HistoryRTSystem;
		    if ( m_HistoryRTSystem )
		    {
		      UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseBuffer(m_HistoryRTSystem, id, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_HistoryRTSystem, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2841, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, id, 0LL);
		}
		
		private void UpdateAntialiasing() {} // 0x000000018344F0D0-0x000000018344F580
		// Void UpdateAntialiasing()
		void HG::Rendering::Runtime::HGCamera::UpdateAntialiasing(HGCamera *this, MethodInfo *method)
		{
		  _DWORD *static_fields; // rcx
		  int *wrapperArray; // rdx
		  int32_t m_antialiasingMode; // ebp
		  TileAnimationData bitDatas; // xmm1
		  __int64 v7; // xmm0_8
		  bool v8; // zf
		  bool v9; // al
		  HGAdditionalCameraData *m_AdditionalCameraData; // rdi
		  HGAdditionalCameraData *v11; // rax
		  int32_t antialiasing; // edi
		  HGAdditionalCameraData *v13; // rsi
		  HGAdditionalCameraData *v14; // rax
		  int32_t v15; // eax
		  Camera *camera; // rdi
		  void (__fastcall *v17)(Camera *, __int64); // rax
		  TileBase *v18; // rdx
		  Vector3Int *v19; // r8
		  ITilemap *v20; // r9
		  int32_t clearColorMode; // edi
		  int32_t v22; // eax
		  int32_t m_PreviousClearColorMode; // ebp
		  HGAdditionalCameraData *v24; // rsi
		  HGAdditionalCameraData *v25; // rax
		  __int64 v26; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // rax
		  ILFixDynamicMethodWrapper_2 *v29; // rax
		  __int64 v30; // rax
		  ILFixDynamicMethodWrapper_2 *v31; // rax
		  __int64 v32; // rax
		  ILFixDynamicMethodWrapper_2 *v33; // rax
		  __int64 v34; // rax
		  ILFixDynamicMethodWrapper_2 *v35; // rax
		  ILFixDynamicMethodWrapper_2 *v36; // rax
		  ILFixDynamicMethodWrapper_2 *v37; // rax
		  TileAnimationData v38; // [rsp+20h] [rbp-38h] BYREF
		  FrameSettings P0; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( wrapperArray[6] > 731 )
		  {
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v26 = *(_QWORD *)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_66;
		    if ( *(_DWORD *)(v26 + 24) <= 0x2DBu )
		      goto LABEL_124;
		    if ( *(_QWORD *)(v26 + 5880) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(731, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_66;
		    }
		  }
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( wrapperArray[6] <= 732 )
		    goto LABEL_9;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v28 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_66;
		  if ( *(_DWORD *)(v28 + 24) <= 0x2DCu )
		    goto LABEL_124;
		  if ( *(_QWORD *)(v28 + 5888) )
		  {
		    v29 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		    if ( !v29 )
		      goto LABEL_66;
		    LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                   (ILFixDynamicMethodWrapper_31 *)v29,
		                                   (Object *)this,
		                                   0LL);
		  }
		  else
		  {
		LABEL_9:
		    m_antialiasingMode = this->fields.m_antialiasingMode;
		  }
		  bitDatas = (TileAnimationData)this->fields._frameSettings_k__BackingField.bitDatas;
		  v7 = *(_QWORD *)&this->fields._frameSettings_k__BackingField.materialQuality;
		  v38 = bitDatas;
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		  P0.bitDatas = (BitArray128)bitDatas;
		  *(_QWORD *)&P0.materialQuality = v7;
		  if ( v8 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    LOWORD(bitDatas.m_AnimatedSprites) = v38.m_AnimatedSprites;
		  }
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( wrapperArray[6] <= 734 )
		    goto LABEL_14;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    LOWORD(bitDatas.m_AnimatedSprites) = v38.m_AnimatedSprites;
		  }
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v30 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_66;
		  if ( *(_DWORD *)(v30 + 24) <= 0x2DEu )
		    goto LABEL_124;
		  if ( *(_QWORD *)(v30 + 5904) )
		  {
		    v31 = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
		    if ( !v31 )
		      goto LABEL_66;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_292(v31, &P0, FrameSettingsField__Enum_Postprocess, 0LL);
		  }
		  else
		  {
		LABEL_14:
		    v9 = ((__int64)bitDatas.m_AnimatedSprites & 0x8000) != 0LL;
		  }
		  if ( v9 )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    static_fields = TypeInfo::UnityEngine::Object;
		    m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      static_fields = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        static_fields = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_AdditionalCameraData )
		    {
		      if ( !static_fields[56] )
		        il2cpp_runtime_class_init_1(static_fields);
		      if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		      {
		        v11 = this->fields.m_AdditionalCameraData;
		        if ( !v11 )
		          goto LABEL_66;
		        antialiasing = v11->fields.antialiasing;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          goto LABEL_66;
		        if ( wrapperArray[6] <= 699 )
		          goto LABEL_28;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		        v32 = *(_QWORD *)wrapperArray;
		        if ( !*(_QWORD *)wrapperArray )
		          goto LABEL_66;
		        if ( *(_DWORD *)(v32 + 24) <= 0x2BBu )
		          goto LABEL_124;
		        if ( *(_QWORD *)(v32 + 5624) )
		        {
		          v33 = IFix::WrappersManagerImpl::GetPatch(699, 0LL);
		          if ( !v33 )
		            goto LABEL_66;
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		            (ILFixDynamicMethodWrapper_29 *)v33,
		            (Object *)this,
		            antialiasing,
		            0LL);
		        }
		        else
		        {
		LABEL_28:
		          v13 = this->fields.m_AdditionalCameraData;
		          this->fields.m_antialiasingMode = antialiasing;
		          static_fields = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            static_fields = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              static_fields = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( v13 )
		          {
		            if ( !static_fields[56] )
		              il2cpp_runtime_class_init_1(static_fields);
		            if ( v13->fields._._._._.m_CachedPtr )
		            {
		              v14 = this->fields.m_AdditionalCameraData;
		              if ( !v14 )
		                goto LABEL_66;
		              v14->fields.antialiasing = antialiasing;
		            }
		          }
		        }
		      }
		    }
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGCamera::set_antialiasing(this, HGAdditionalCameraData_AntialiasingMode__Enum_None, 0LL);
		  }
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( wrapperArray[6] <= 732 )
		    goto LABEL_39;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v34 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_66;
		  if ( *(_DWORD *)(v34 + 24) <= 0x2DCu )
		    goto LABEL_124;
		  if ( *(_QWORD *)(v34 + 5888) )
		  {
		    v35 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		    if ( !v35 )
		      goto LABEL_66;
		    LOBYTE(v15) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                    (ILFixDynamicMethodWrapper_31 *)v35,
		                    (Object *)this,
		                    0LL);
		  }
		  else
		  {
		LABEL_39:
		    v15 = this->fields.m_antialiasingMode;
		  }
		  if ( (v15 & 0xA) != 0 )
		  {
		    camera = this->fields.camera;
		    if ( !camera )
		      goto LABEL_66;
		    v17 = (void (__fastcall *)(Camera *, __int64))qword_18F36F158;
		    if ( !qword_18F36F158 )
		    {
		      v17 = (void (__fastcall *)(Camera *, __int64))sub_180059EA0(
		                                                      "UnityEngine.Camera::set_depthTextureMode(UnityEngine.DepthTextureMode)");
		      qword_18F36F158 = (__int64)v17;
		    }
		    v17(camera, 5LL);
		  }
		  clearColorMode = 0;
		  if ( !HG::Rendering::Runtime::HGCamera::RequiresCameraJitter(this, 0LL) )
		  {
		    this->fields.taaFrameIndex = 0;
		    this->fields.taaJitter = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                         &v38,
		                                         v18,
		                                         v19,
		                                         v20,
		                                         (MethodInfo *)v38.m_AnimatedSprites);
		  }
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)**((_QWORD **)static_fields + 23);
		  if ( !wrapperArray )
		LABEL_66:
		    sub_1800D8260(static_fields, wrapperArray);
		  if ( wrapperArray[6] <= 732 )
		    goto LABEL_51;
		  if ( !static_fields[56] )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)**((_QWORD **)static_fields + 23);
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( (unsigned int)wrapperArray[6] <= 0x2DC )
		    goto LABEL_124;
		  if ( *((_QWORD *)wrapperArray + 736) )
		  {
		    v36 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		    if ( !v36 )
		      goto LABEL_66;
		    LOBYTE(v22) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                    (ILFixDynamicMethodWrapper_31 *)v36,
		                    (Object *)this,
		                    0LL);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_51:
		    v22 = this->fields.m_antialiasingMode;
		  }
		  if ( (((unsigned __int8)m_antialiasingMode ^ (unsigned __int8)v22) & 2) != 0 )
		  {
		LABEL_67:
		    this->fields.resetPostProcessingHistory = 1;
		    this->fields.m_PreviousClearColorMode = HG::Rendering::Runtime::HGCamera::get_clearColorMode(this, 0LL);
		    return;
		  }
		  m_PreviousClearColorMode = this->fields.m_PreviousClearColorMode;
		  if ( !static_fields[56] )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)**((_QWORD **)static_fields + 23);
		  if ( !wrapperArray )
		    goto LABEL_66;
		  if ( wrapperArray[6] <= 741 )
		    goto LABEL_57;
		  if ( !static_fields[56] )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (_DWORD *)**((_QWORD **)static_fields + 23);
		  if ( !static_fields )
		    goto LABEL_66;
		  if ( static_fields[6] <= 0x2E5u )
		LABEL_124:
		    sub_1800D2AB0(static_fields, wrapperArray);
		  if ( *((_QWORD *)static_fields + 745) )
		  {
		    v37 = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
		    if ( !v37 )
		      goto LABEL_66;
		    clearColorMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                       (ILFixDynamicMethodWrapper_26 *)v37,
		                       (Object *)this,
		                       0LL);
		    goto LABEL_64;
		  }
		LABEL_57:
		  static_fields = TypeInfo::UnityEngine::Object;
		  v24 = this->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    static_fields = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      static_fields = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v24 )
		  {
		    if ( !static_fields[56] )
		      il2cpp_runtime_class_init_1(static_fields);
		    if ( v24->fields._._._._.m_CachedPtr )
		    {
		      v25 = this->fields.m_AdditionalCameraData;
		      if ( v25 )
		      {
		        clearColorMode = v25->fields.clearColorMode;
		        goto LABEL_64;
		      }
		      goto LABEL_66;
		    }
		  }
		  static_fields = this->fields.camera;
		  if ( !static_fields )
		    goto LABEL_66;
		  if ( UnityEngine::Camera::get_clearFlags((Camera *)static_fields, 0LL) != CameraClearFlags__Enum_Skybox )
		  {
		    static_fields = this->fields.camera;
		    if ( !static_fields )
		      goto LABEL_66;
		    LOBYTE(clearColorMode) = UnityEngine::Camera::get_clearFlags((Camera *)static_fields, 0LL) != CameraClearFlags__Enum_Color;
		    ++clearColorMode;
		  }
		LABEL_64:
		  if ( m_PreviousClearColorMode != clearColorMode )
		    goto LABEL_67;
		}
		
		private void UpdateRenderingScale(HGSettingParameters hgSetting, Vector2Int nonScaledViewport) {} // 0x000000018344D000-0x000000018344D1E0
		// Void UpdateRenderingScale(HGSettingParameters, Vector2Int)
		void HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
		        HGCamera *this,
		        HGSettingParameters *hgSetting,
		        Vector2Int nonScaledViewport,
		        MethodInfo *method)
		{
		  SettingParameter_1_System_Single_ *optimalRenderWidth; // rcx
		  HGSettingParameters *v7; // rbp
		  ILFixDynamicMethodWrapper_2__Array *v8; // r8
		  int32_t m_antialiasingMode; // eax
		  BOOL v10; // esi
		  int32_t v11; // eax
		  char v12; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  bool IsStreamlineDLSSSupported; // al
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  float FSR3RenderScale; // xmm0_4
		  SettingParameter_1_System_Single_ *v20; // rax
		  float v21; // xmm7_4
		  struct MathF__Class *v22; // rcx
		  float paramValue_k__BackingField; // xmm6_4
		  SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rax
		  DLSSOptimalSettings v25; // [rsp+50h] [rbp-48h] BYREF
		
		  optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = hgSetting;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = **(ILFixDynamicMethodWrapper_2__Array ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !v8 )
		    goto LABEL_30;
		  if ( v8->max_length.size > 749 )
		  {
		    if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		    {
		      il2cpp_runtime_class_init_1(optimalRenderWidth);
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		    if ( !hgSetting )
		      goto LABEL_30;
		    if ( LODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 0x2ED )
		      goto LABEL_71;
		    if ( hgSetting[3].fields._csmScreenSizeMin0_k__BackingField )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(749, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_296(Patch, (Object *)this, (Object *)v7, nonScaledViewport, 0LL);
		        return;
		      }
		      goto LABEL_30;
		    }
		  }
		  if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		  {
		    il2cpp_runtime_class_init_1(optimalRenderWidth);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !hgSetting )
		    goto LABEL_30;
		  if ( SLODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 739 )
		    goto LABEL_88;
		  if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		  {
		    il2cpp_runtime_class_init_1(optimalRenderWidth);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !hgSetting )
		    goto LABEL_30;
		  if ( LODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 0x2E3 )
		    goto LABEL_71;
		  if ( hgSetting[3].fields._csmSplitCount_k__BackingField )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(739, 0LL);
		    if ( !v14 )
		      goto LABEL_30;
		    if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v14, (Object *)this, 0LL) )
		    {
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		LABEL_15:
		      v10 = 0;
		      goto LABEL_16;
		    }
		  }
		  else
		  {
		LABEL_88:
		    if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		    {
		      il2cpp_runtime_class_init_1(optimalRenderWidth);
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		    if ( !hgSetting )
		      goto LABEL_30;
		    if ( SLODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 732 )
		      goto LABEL_13;
		    if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		    {
		      il2cpp_runtime_class_init_1(optimalRenderWidth);
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		    if ( !hgSetting )
		      goto LABEL_30;
		    if ( LODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 0x2DC )
		      goto LABEL_71;
		    if ( hgSetting[3].fields._enableShadowProxy_k__BackingField )
		    {
		      v15 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		      if ( !v15 )
		        goto LABEL_30;
		      LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                     (ILFixDynamicMethodWrapper_31 *)v15,
		                                     (Object *)this,
		                                     0LL);
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_13:
		      m_antialiasingMode = this->fields.m_antialiasingMode;
		    }
		    if ( (m_antialiasingMode & 0x20) == 0 )
		      goto LABEL_15;
		  }
		  IsStreamlineDLSSSupported = UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSSupported(0LL);
		  optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v10 = IsStreamlineDLSSSupported;
		LABEL_16:
		  if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		  {
		    il2cpp_runtime_class_init_1(optimalRenderWidth);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !hgSetting )
		    goto LABEL_30;
		  if ( SLODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) > 740 )
		  {
		    if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		    {
		      il2cpp_runtime_class_init_1(optimalRenderWidth);
		      optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		    if ( !hgSetting )
		      goto LABEL_30;
		    if ( LODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 0x2E4 )
		      goto LABEL_71;
		    if ( hgSetting[3].fields._csmSplit0_k__BackingField )
		    {
		      v17 = IFix::WrappersManagerImpl::GetPatch(740, 0LL);
		      if ( !v17 )
		        goto LABEL_30;
		      if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v17, (Object *)this, 0LL) )
		        goto LABEL_26;
		      goto LABEL_31;
		    }
		  }
		  if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		  {
		    il2cpp_runtime_class_init_1(optimalRenderWidth);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  hgSetting = **(HGSettingParameters ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !hgSetting )
		    goto LABEL_30;
		  if ( SLODWORD(hgSetting->fields._ocScreenSizeMin_k__BackingField) <= 732 )
		    goto LABEL_24;
		  if ( !LODWORD(optimalRenderWidth[4].fields._.m_paramLookupResult) )
		  {
		    il2cpp_runtime_class_init_1(optimalRenderWidth);
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  optimalRenderWidth = **(SettingParameter_1_System_Single_ ***)&optimalRenderWidth[3].fields._paramValue_k__BackingField;
		  if ( !optimalRenderWidth )
		    goto LABEL_30;
		  if ( LODWORD(optimalRenderWidth->fields._._paramName_k__BackingField) <= 0x2DC )
		LABEL_71:
		    sub_1800D2AB0(optimalRenderWidth, hgSetting);
		  if ( !optimalRenderWidth[122].fields._.m_paramLookupResult )
		  {
		LABEL_24:
		    v11 = this->fields.m_antialiasingMode;
		    goto LABEL_25;
		  }
		  v18 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		  if ( !v18 )
		    goto LABEL_30;
		  LOBYTE(v11) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v18, (Object *)this, 0LL);
		LABEL_25:
		  if ( (v11 & 0x40) == 0 )
		  {
		LABEL_26:
		    v12 = 0;
		    goto LABEL_27;
		  }
		LABEL_31:
		  if ( !UnityEngine::HyperGryphEngineCode::HGFSR3Util::IsFSR3Supported(0LL) )
		    goto LABEL_26;
		  v12 = 1;
		LABEL_27:
		  if ( v10 )
		  {
		    if ( !v7 )
		      goto LABEL_30;
		    hgSetting = (HGSettingParameters *)v7->fields._dlssQuality_k__BackingField;
		    if ( !hgSetting )
		      goto LABEL_30;
		    optimalRenderWidth = (SettingParameter_1_System_Single_ *)UnityEngine::HyperGryphEngineCode::DLSSOptimalSettings::GetDLSSOptimalSetting(
		                                                                &v25,
		                                                                (DLSSQuality__Enum)LODWORD(hgSetting->fields._taauQuality_k__BackingField),
		                                                                nonScaledViewport,
		                                                                0LL)->optimalRenderWidth;
		    renderingScale_k__BackingField = v7->fields._renderingScale_k__BackingField;
		    v21 = (float)(int)optimalRenderWidth / (float)nonScaledViewport.m_X;
		    if ( !renderingScale_k__BackingField )
		      goto LABEL_30;
		    v22 = TypeInfo::System::MathF;
		    paramValue_k__BackingField = renderingScale_k__BackingField->fields._paramValue_k__BackingField;
		    if ( !TypeInfo::System::MathF->_1.cctor_finished_or_no_cctor )
		LABEL_76:
		      il2cpp_runtime_class_init_1(v22);
		  }
		  else
		  {
		    if ( !v12 )
		      return;
		    if ( !v7
		      || (optimalRenderWidth = (SettingParameter_1_System_Single_ *)v7->fields._fsr3Quality_k__BackingField) == 0LL
		      || (FSR3RenderScale = UnityEngine::HyperGryphEngineCode::HGFSR3Util::GetFSR3RenderScale(
		                              LODWORD(optimalRenderWidth->fields._paramValue_k__BackingField),
		                              0LL),
		          v20 = v7->fields._renderingScale_k__BackingField,
		          v21 = FSR3RenderScale,
		          !v20) )
		    {
		LABEL_30:
		      sub_1800D8260(optimalRenderWidth, hgSetting);
		    }
		    v22 = TypeInfo::System::MathF;
		    paramValue_k__BackingField = v20->fields._paramValue_k__BackingField;
		    if ( !TypeInfo::System::MathF->_1.cctor_finished_or_no_cctor )
		      goto LABEL_76;
		  }
		  if ( fabs(paramValue_k__BackingField - v21) > COERCE_FLOAT(1) )
		  {
		    optimalRenderWidth = v7->fields._renderingScale_k__BackingField;
		    if ( optimalRenderWidth )
		    {
		      HG::Rendering::Runtime::SettingParameter<float>::Override(
		        optimalRenderWidth,
		        v21,
		        MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
		      optimalRenderWidth = v7->fields._renderingScale_k__BackingField;
		      if ( optimalRenderWidth )
		      {
		        HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
		          (HGRenderPipelineSettingHub_SettingParameterBase *)optimalRenderWidth,
		          0LL);
		        return;
		      }
		    }
		    goto LABEL_30;
		  }
		}
		
		[IDTag(1)]
		private void UpdateAllViewConstants(HGRenderPipeline hgrp) {} // 0x000000018344E1C0-0x000000018344E240
		// Void UpdateAllViewConstants(HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
		        HGCamera *this,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  bool v7; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 767 )
		  {
		LABEL_5:
		    v7 = HG::Rendering::Runtime::HGCamera::RequiresCameraJitter(this, 0LL);
		    HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, v7, 1, hgrp, 0LL);
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x2FF )
		    sub_1800D2AB0(v5, hgrp);
		  if ( !v5[16]._0.methods )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(767, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, hgrp);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)hgrp,
		    0LL);
		}
		
		private Matrix4x4 BuildSceneRTAspectProjection(Camera cam) => default; // 0x000000018324CC20-0x000000018324D130
		// Matrix4x4 BuildSceneRTAspectProjection(Camera)
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::BuildSceneRTAspectProjection(
		        Matrix4x4 *__return_ptr retstr,
		        HGCamera *this,
		        Camera *cam,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *wrapperArray; // rdx
		  Matrix4x4 *v9; // rax
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  Matrix4x4 *result; // rax
		  float sceneRTAspect; // xmm8_4
		  void (__fastcall *v15)(Camera *, __int128 *); // rax
		  float v16; // xmm7_4
		  __m128 v17; // xmm6
		  __int128 v18; // xmm9
		  __int128 v19; // xmm10
		  bool v20; // si
		  unsigned __int8 (__fastcall *v21)(Camera *); // rax
		  unsigned __int8 (__fastcall *v22)(Camera *); // rax
		  float fieldOfView; // xmm7_4
		  float v24; // xmm6_4
		  float v25; // xmm0_4
		  Matrix4x4 *v26; // rax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Vector2 sensorSize; // xmm7_8
		  Vector2 lensShift; // xmm6_8
		  float v32; // xmm10_4
		  float farClipPlane; // xmm0_4
		  __int64 v34; // rdx
		  void (__fastcall *v35)(__int128 *, __int64, Vector2 *, Vector2 *, _DWORD, _DWORD, _DWORD, _DWORD); // rax
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  float (__fastcall *v39)(Camera *); // rax
		  float v40; // xmm0_4
		  __int128 v41; // xmm1
		  __int64 v42; // rax
		  __int64 v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  __int64 v46; // rax
		  Vector2 v47; // [rsp+40h] [rbp-C0h] BYREF
		  Vector2 v48; // [rsp+48h] [rbp-B8h] BYREF
		  __int128 v49; // [rsp+50h] [rbp-B0h] BYREF
		  __m128 v50; // [rsp+60h] [rbp-A0h]
		  __int128 v51; // [rsp+70h] [rbp-90h]
		  __int128 v52; // [rsp+80h] [rbp-80h]
		  __int128 v53; // [rsp+90h] [rbp-70h] BYREF
		  __int128 v54; // [rsp+A0h] [rbp-60h]
		  __int128 v55; // [rsp+B0h] [rbp-50h]
		  __int128 v56; // [rsp+C0h] [rbp-40h]
		  Matrix4x4 v57; // [rsp+D0h] [rbp-30h] BYREF
		  unsigned __int64 v58; // [rsp+180h] [rbp+80h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v53 = 0LL;
		  v54 = 0LL;
		  v55 = 0LL;
		  v56 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (ILFixDynamicMethodWrapper_2 *)v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_42;
		  if ( wrapperArray->fields.methodId > 764 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (ILFixDynamicMethodWrapper_2 *)v5->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_42;
		    if ( wrapperArray->fields.methodId <= 0x2FCu )
		      goto LABEL_43;
		    if ( *(_QWORD *)&wrapperArray[153].fields.methodId )
		    {
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v5);
		        v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		      if ( !v5 )
		        goto LABEL_42;
		      if ( LODWORD(v5->_0.namespaze) > 0x2FC )
		      {
		        wrapperArray = (ILFixDynamicMethodWrapper_2 *)v5[16]._0.fields;
		        if ( wrapperArray )
		        {
		          v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_298(&v57, wrapperArray, (Object *)this, (Object *)cam, 0LL);
		          v10 = *(_OWORD *)&v9->m01;
		          *(_OWORD *)&retstr->m00 = *(_OWORD *)&v9->m00;
		          v11 = *(_OWORD *)&v9->m02;
		          *(_OWORD *)&retstr->m01 = v10;
		          v12 = *(_OWORD *)&v9->m03;
		          result = retstr;
		          *(_OWORD *)&retstr->m02 = v11;
		          *(_OWORD *)&retstr->m03 = v12;
		          return result;
		        }
		LABEL_42:
		        sub_1800D8250(v5, wrapperArray);
		      }
		LABEL_43:
		      sub_1800D2AA0(v5, wrapperArray, cam);
		    }
		  }
		  sceneRTAspect = HG::Rendering::Runtime::HGCamera::get_sceneRTAspect(this, 0LL);
		  if ( !cam )
		    goto LABEL_42;
		  v15 = (void (__fastcall *)(Camera *, __int128 *))qword_18F36F228;
		  v49 = 0LL;
		  v50 = 0LL;
		  v51 = 0LL;
		  v52 = 0LL;
		  if ( !qword_18F36F228 )
		  {
		    v15 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v15 )
		    {
		      v42 = sub_1802EE1B8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v42, 0LL);
		    }
		    qword_18F36F228 = (__int64)v15;
		  }
		  v15(cam, &v49);
		  v16 = *(float *)&v49;
		  v17 = v50;
		  v18 = v51;
		  v19 = v52;
		  *(_OWORD *)&v57.m00 = v49;
		  v20 = _mm_shuffle_ps(*(__m128 *)&v57.m00, *(__m128 *)&v57.m00, 170).m128_f32[0] != 0.0
		     || _mm_shuffle_ps(v50, v50, 170).m128_f32[0] != 0.0;
		  v21 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v21 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v21 )
		    {
		      v43 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v43, 0LL);
		    }
		    qword_18F36F100 = (__int64)v21;
		  }
		  if ( v21(cam) || v20 )
		  {
		    v39 = (float (__fastcall *)(Camera *))qword_18F36F118;
		    if ( !qword_18F36F118 )
		    {
		      v39 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_aspect()");
		      if ( !v39 )
		      {
		        v46 = sub_1802EE1B8("UnityEngine.Camera::get_aspect()");
		        sub_18007E1B0(v46, 0LL);
		      }
		      qword_18F36F118 = (__int64)v39;
		    }
		    v40 = v39(cam);
		    v41 = *(_OWORD *)&v57.m00;
		    result = retstr;
		    *(float *)&v41 = (float)(v40 / sceneRTAspect) * v16;
		    *(_OWORD *)&retstr->m00 = v41;
		    *(__m128 *)&retstr->m01 = v17;
		    *(_OWORD *)&retstr->m02 = v18;
		    *(_OWORD *)&retstr->m03 = v19;
		  }
		  else
		  {
		    v22 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F160;
		    if ( !qword_18F36F160 )
		    {
		      v22 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_usePhysicalProperties()");
		      if ( !v22 )
		      {
		        v44 = sub_1802EE1B8("UnityEngine.Camera::get_usePhysicalProperties()");
		        sub_18007E1B0(v44, 0LL);
		      }
		      qword_18F36F160 = (__int64)v22;
		    }
		    if ( v22(cam) )
		    {
		      UnityEngine::Camera::get_focalLength(cam, 0LL);
		      sensorSize = UnityEngine::Camera::get_sensorSize(cam, 0LL);
		      lensShift = UnityEngine::Camera::get_lensShift(cam, 0LL);
		      v32 = UnityEngine::Camera::get_nearClipPlane(cam, 0LL);
		      farClipPlane = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
		      v58 = __PAIR64__(LODWORD(sceneRTAspect), UnityEngine::Camera::get_gateFit(cam, 0LL));
		      v35 = (void (__fastcall *)(__int128 *, __int64, Vector2 *, Vector2 *, _DWORD, _DWORD, _DWORD, _DWORD))qword_18F371FF0;
		      v47 = lensShift;
		      v48 = sensorSize;
		      if ( !qword_18F371FF0 )
		      {
		        v35 = (void (__fastcall *)(__int128 *, __int64, Vector2 *, Vector2 *, _DWORD, _DWORD, _DWORD, _DWORD))il2cpp_resolve_icall_1("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4&,System.Single,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,System.Single,System.Single,UnityEngine.Camera/GateFitMode)");
		        if ( !v35 )
		        {
		          v45 = sub_1802EE1B8(
		                  "UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matri"
		                  "x4x4&,System.Single,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,System.Single,System.Singl"
		                  "e,UnityEngine.Camera/GateFitMode)");
		          sub_18007E1B0(v45, 0LL);
		        }
		        qword_18F371FF0 = (__int64)v35;
		      }
		      v35(&v53, v34, &v48, &v47, LODWORD(v32), LODWORD(farClipPlane), HIDWORD(v58), v58);
		      result = retstr;
		      v36 = v54;
		      *(_OWORD *)&retstr->m00 = v53;
		      v37 = v55;
		      *(_OWORD *)&retstr->m01 = v36;
		      v38 = v56;
		      *(_OWORD *)&retstr->m02 = v37;
		      *(_OWORD *)&retstr->m03 = v38;
		    }
		    else
		    {
		      fieldOfView = UnityEngine::Camera::get_fieldOfView(cam, 0LL);
		      v24 = UnityEngine::Camera::get_nearClipPlane(cam, 0LL);
		      v25 = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
		      v26 = UnityEngine::Matrix4x4::Perspective(&v57, fieldOfView, sceneRTAspect, v24, v25, 0LL);
		      v27 = *(_OWORD *)&v26->m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v26->m00;
		      v28 = *(_OWORD *)&v26->m02;
		      *(_OWORD *)&retstr->m01 = v27;
		      v29 = *(_OWORD *)&v26->m03;
		      result = retstr;
		      *(_OWORD *)&retstr->m02 = v28;
		      *(_OWORD *)&retstr->m03 = v29;
		    }
		  }
		  return result;
		}
		
		[IDTag(0)]
		private void UpdateAllViewConstants(bool jitterProjectionMatrix, bool updatePreviousFrameConstants, HGRenderPipeline hgrp) {} // 0x000000018324C570-0x000000018324C8D0
		// Void UpdateAllViewConstants(Boolean, Boolean, HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
		        HGCamera *this,
		        bool jitterProjectionMatrix,
		        bool updatePreviousFrameConstants,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Matrix4x4 *v11; // rax
		  Camera *camera; // rdi
		  void (__fastcall *v13)(Camera *, Matrix4x4 *); // rax
		  Camera *v14; // rdi
		  void (__fastcall *v15)(Camera *, Matrix4x4 *); // rax
		  Camera *v16; // rdi
		  __int64 (__fastcall *v17)(Camera *); // rax
		  __int64 v18; // rdi
		  void (__fastcall *v19)(__int64, Vector3 *); // rax
		  IEnumerator_1_System_Action_2_UnityEngine_Rendering_RenderTargetIdentifier_UnityEngine_Rendering_CommandBuffer_ *v20; // r12
		  Type *v21; // rdx
		  Dictionary_2_TKey_TValue_Entry_System_Object_System_Object___Array *entries; // rcx
		  struct CameraCaptureBridge__Class *v23; // rax
		  Object *v24; // r14
		  Dictionary_2_System_Object_System_Object_ *actionDict; // rdi
		  struct MethodInfo *v26; // rsi
		  int32_t Entry; // eax
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v31; // rax
		  __int64 v32; // rax
		  __int64 v33; // rax
		  __int64 v34; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-E0h]
		  Vector3 v36; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 v37; // [rsp+60h] [rbp-A0h] BYREF
		  Matrix4x4 v38; // [rsp+70h] [rbp-90h] BYREF
		  Matrix4x4 v39; // [rsp+B0h] [rbp-50h] BYREF
		  HashSet_1_T_Enumerator_System_UInt64_ v40; // [rsp+F0h] [rbp-10h] BYREF
		  HashSet_1_T_Enumerator_System_UInt64_ v41; // [rsp+108h] [rbp+8h] BYREF
		  __int128 v42; // [rsp+120h] [rbp+20h]
		  __int128 v43; // [rsp+130h] [rbp+30h]
		  Matrix4x4 v44; // [rsp+140h] [rbp+40h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size <= 768 )
		    goto LABEL_5;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		  if ( !v7 )
		    goto LABEL_22;
		  if ( LODWORD(v7->_0.namespaze) <= 0x300 )
		    sub_1800D2AB0(v7, wrapperArray);
		  if ( !v7[16]._0.nestedTypes )
		  {
		LABEL_5:
		    v11 = HG::Rendering::Runtime::HGCamera::BuildSceneRTAspectProjection(&v44, this, this->fields.camera, 0LL);
		    camera = this->fields.camera;
		    v42 = *(_OWORD *)&v11->m00;
		    v43 = *(_OWORD *)&v11->m01;
		    *(_OWORD *)&v40._set = *(_OWORD *)&v11->m02;
		    *(_OWORD *)&v41._set = *(_OWORD *)&v11->m03;
		    if ( camera )
		    {
		      v13 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		      memset(&v39, 0, sizeof(v39));
		      if ( !qword_18F36F220 )
		      {
		        v13 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEn"
		                                                            "gine.Matrix4x4&)");
		        if ( !v13 )
		        {
		          v31 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		          sub_18007E1B0(v31, 0LL);
		        }
		        qword_18F36F220 = (__int64)v13;
		      }
		      v13(camera, &v39);
		      v14 = this->fields.camera;
		      if ( v14 )
		      {
		        v15 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F218;
		        memset(&v38, 0, sizeof(v38));
		        if ( !qword_18F36F218 )
		        {
		          v15 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Camera::get_cameraToWorldMatrix_Injected(Unity"
		                                                              "Engine.Matrix4x4&)");
		          if ( !v15 )
		          {
		            v32 = sub_1802EE1B8("UnityEngine.Camera::get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v32, 0LL);
		          }
		          qword_18F36F218 = (__int64)v15;
		        }
		        v15(v14, &v38);
		        v16 = this->fields.camera;
		        if ( v16 )
		        {
		          v17 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		          if ( !qword_18F36FBC0 )
		          {
		            v17 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		            if ( !v17 )
		            {
		              v33 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		              sub_18007E1B0(v33, 0LL);
		            }
		            qword_18F36FBC0 = (__int64)v17;
		          }
		          v18 = v17(v16);
		          if ( v18 )
		          {
		            *(_QWORD *)&v36.x = 0LL;
		            v36.z = 0.0;
		            v19 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		            if ( !qword_18F3700F0 )
		            {
		              v19 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		              if ( !v19 )
		              {
		                v34 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                sub_18007E1B0(v34, 0LL);
		              }
		              qword_18F3700F0 = (__int64)v19;
		            }
		            v19(v18, &v36);
		            v37 = v36;
		            v20 = 0LL;
		            v44 = v38;
		            v38 = v39;
		            *(_OWORD *)&v39.m01 = v43;
		            *(_OWORD *)&v39.m00 = v42;
		            *(_OWORD *)&v39.m03 = *(_OWORD *)&v41._set;
		            *(_OWORD *)&v39.m02 = *(_OWORD *)&v40._set;
		            HG::Rendering::Runtime::HGCamera::UpdateViewConstants(
		              this,
		              &this->fields.mainViewConstants,
		              &v39,
		              &v38,
		              &v44,
		              &v37,
		              jitterProjectionMatrix,
		              updatePreviousFrameConstants,
		              hgrp,
		              0LL);
		            HG::Rendering::Runtime::HGCamera::UpdateFrustum(this, &this->fields.mainViewConstants, 0LL);
		            v23 = TypeInfo::UnityEngine::Rendering::CameraCaptureBridge;
		            v24 = (Object *)this->fields.camera;
		            if ( !TypeInfo::UnityEngine::Rendering::CameraCaptureBridge->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CameraCaptureBridge);
		              v23 = TypeInfo::UnityEngine::Rendering::CameraCaptureBridge;
		              if ( !TypeInfo::UnityEngine::Rendering::CameraCaptureBridge->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CameraCaptureBridge);
		                v23 = TypeInfo::UnityEngine::Rendering::CameraCaptureBridge;
		              }
		            }
		            actionDict = (Dictionary_2_System_Object_System_Object_ *)v23->static_fields->actionDict;
		            if ( actionDict )
		            {
		              v26 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,System::Collections::Generic::HashSet<System::Action<UnityEngine::Rendering::RenderTargetIdentifier,UnityEngine::Rendering::CommandBuffer>>>::TryGetValue;
		              if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,System::Collections::Generic::HashSet<System::Action<UnityEngine::Rendering::RenderTargetIdentifier,UnityEngine::Rendering::CommandBuffer>>>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		                    + 4) )
		                (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,System::Collections::Generic::HashSet<System::Action<UnityEngine::Rendering::RenderTargetIdentifier,UnityEngine::Rendering::CommandBuffer>>>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		              Entry = System::Collections::Generic::Dictionary<System::Object,System::Object>::FindEntry(
		                        actionDict,
		                        v24,
		                        (MethodInfo *)v26->klass->rgctx_data[22].rgctxDataDummy);
		              if ( Entry < 0 )
		                goto LABEL_21;
		              entries = actionDict->fields._entries;
		              if ( entries )
		              {
		                if ( (unsigned int)Entry >= entries->max_length.size )
		                  sub_1800D2AB0(entries, v21);
		                *(_QWORD *)&v36.x = entries->vector[Entry].value;
		                sub_18002D1B0((SingleFieldAccessor *)&v36, v21, v28, v29, P3);
		                v21 = *(Type **)&v36.x;
		                if ( *(_QWORD *)&v36.x )
		                {
		                  if ( *(_DWORD *)(*(_QWORD *)&v36.x + 32LL) )
		                  {
		                    System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
		                      &v41,
		                      *(HashSet_1_System_UInt64_ **)&v36.x,
		                      MethodInfo::System::Collections::Generic::HashSet<System::Action<UnityEngine::Rendering::RenderTargetIdentifier,UnityEngine::Rendering::CommandBuffer>>::GetEnumerator);
		                    v40 = v41;
		                    v20 = (IEnumerator_1_System_Action_2_UnityEngine_Rendering_RenderTargetIdentifier_UnityEngine_Rendering_CommandBuffer_ *)il2cpp_value_box_0(TypeInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::Action<UnityEngine::Rendering::RenderTargetIdentifier,UnityEngine::Rendering::CommandBuffer>>, &v40);
		                  }
		LABEL_21:
		                  this->fields.m_RecorderCaptureActions = v20;
		                  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RecorderCaptureActions, v21, v28, v29, P3);
		                  return;
		                }
		              }
		            }
		            sub_1800D8260(entries, v21);
		          }
		        }
		      }
		    }
		LABEL_22:
		    sub_1800D8260(v7, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(768, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_307(
		    Patch,
		    (Object *)this,
		    jitterProjectionMatrix,
		    updatePreviousFrameConstants,
		    (Object *)hgrp,
		    0LL);
		}
		
		public static Matrix4x4 CalculateInvProjectionMatrix([IsReadOnly] in Matrix4x4 matrix) => default; // 0x0000000183B72210-0x0000000183B72340
		// Matrix4x4 CalculateInvProjectionMatrix(Matrix4x4 ByRef)
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::CalculateInvProjectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Matrix4x4 *matrix,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float m12; // xmm6_4
		  float v8; // xmm1_4
		  Matrix4x4 *result; // rax
		  float v10; // xmm6_4
		  float v11; // xmm5_4
		  float v12; // xmm3_4
		  float v13; // xmm4_4
		  __int128 m00_low; // xmm0
		  __m128 v15; // xmm1
		  __m128 v16; // xmm0
		  __m128 v17; // xmm1
		  __m128 v18; // xmm0
		  __m128 v19; // xmm1
		  __m128 v20; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  Matrix4x4 v26; // [rsp+20h] [rbp-58h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 772 )
		  {
		LABEL_5:
		    m12 = matrix->m12;
		    v8 = 1.0 / matrix->m00;
		    *(_QWORD *)&v26.m30 = 0LL;
		    *(_QWORD *)&v26.m10 = 0LL;
		    memset(&v26.m21, 0, 20);
		    result = retstr;
		    v26.m23 = -1.0;
		    v10 = m12 / matrix->m11;
		    v11 = matrix->m02 / matrix->m00;
		    v12 = 1.0 / matrix->m23;
		    v13 = matrix->m22 / matrix->m23;
		    m00_low = LODWORD(v26.m00);
		    *(float *)&m00_low = v8;
		    v15 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v26.m01, (__m128)*(unsigned __int64 *)&v26.m01, 225);
		    v15.m128_f32[0] = 1.0 / matrix->m11;
		    *(_OWORD *)&retstr->m00 = m00_low;
		    v16 = *(__m128 *)&v26.m02;
		    *(__m128 *)&retstr->m01 = _mm_shuffle_ps(v15, v15, 225);
		    v17 = *(__m128 *)&v26.m03;
		    v17.m128_f32[0] = v11;
		    v18 = _mm_shuffle_ps(v16, v16, 147);
		    v19 = _mm_shuffle_ps(v17, v17, 225);
		    v18.m128_f32[0] = v12;
		    v19.m128_f32[0] = v10;
		    v20 = _mm_shuffle_ps(v19, v19, 135);
		    v20.m128_f32[0] = v13;
		    *(__m128 *)&retstr->m02 = _mm_shuffle_ps(v18, v18, 57);
		    *(__m128 *)&retstr->m03 = _mm_shuffle_ps(v20, v20, 57);
		    return result;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x304 )
		    sub_1800D2AB0(v5, matrix);
		  if ( !v5[16].rgctx_data )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(772, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, matrix);
		  v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_300(&v26, Patch, matrix, 0LL);
		  v23 = *(_OWORD *)&v22->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v22->m00;
		  v24 = *(_OWORD *)&v22->m02;
		  *(_OWORD *)&retstr->m01 = v23;
		  v25 = *(_OWORD *)&v22->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v24;
		  *(_OWORD *)&retstr->m03 = v25;
		  return result;
		}
		
		private void UpdateViewConstants(ref ViewConstants viewConstants, Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Matrix4x4 invViewMatrix, Vector3 cameraPosition, bool jitterProjectionMatrix, bool updatePreviousFrameConstants, HGRenderPipeline hgrp) {} // 0x0000000182FA2F20-0x0000000182FA4810
		// Void UpdateViewConstants(HGCamera+ViewConstants ByRef, Matrix4x4, Matrix4x4, Matrix4x4, Vector3, Boolean, Boolean, HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::UpdateViewConstants(
		        HGCamera *this,
		        HGCamera_ViewConstants *viewConstants,
		        Matrix4x4 *projMatrix,
		        Matrix4x4 *viewMatrix,
		        Matrix4x4 *invViewMatrix,
		        Vector3 *cameraPosition,
		        bool jitterProjectionMatrix,
		        bool updatePreviousFrameConstants,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  Matrix4x4 *JitteredProjectionMatrix; // rax
		  __int128 v21; // xmm2
		  __int128 v22; // xmm3
		  void (__fastcall *v23)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *); // rax
		  __int64 v24; // rdx
		  void (__fastcall *v25)(Matrix4x4 *, __int64, Matrix4x4 *); // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm11
		  __m128 v28; // xmm7
		  __m128 v29; // xmm9
		  __m128 v30; // xmm12
		  __int128 v31; // xmm1
		  void (__fastcall *v32)(__int128 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v33; // xmm1
		  __int128 v34; // xmm13
		  __int128 v35; // xmm14
		  __int128 v36; // xmm15
		  __int128 v37; // xmm6
		  __int128 v38; // xmm1
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  void (__fastcall *v42)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  void (__fastcall *v43)(Matrix4x4 *, Matrix4x4 *, __int128 *); // rax
		  __int128 v44; // xmm1
		  float v45; // eax
		  __int128 v46; // xmm0
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
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
		  __int128 v62; // xmm1
		  __int128 v63; // xmm0
		  __int128 v64; // xmm1
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  __int128 v68; // xmm0
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm1
		  Camera *camera; // r14
		  unsigned __int8 (__fastcall *v73)(Camera *); // rax
		  float v74; // xmm0_4
		  float v75; // xmm2_4
		  float v76; // xmm5_4
		  float v77; // xmm0_4
		  float v78; // xmm1_4
		  float v79; // xmm4_4
		  Quaternion m00_low; // xmm0
		  __m128 v81; // xmm0
		  __m128 v82; // xmm3
		  __m128 v83; // xmm0
		  __m128 v84; // xmm0
		  __m128 v85; // xmm2
		  __m128 v86; // xmm0
		  Quaternion v87; // xmm1
		  __m128 v88; // xmm3
		  __m128 v89; // xmm2
		  void (__fastcall *v90)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v91; // xmm1
		  __int128 v92; // xmm1
		  __int128 v93; // xmm1
		  __int128 v94; // xmm0
		  __int128 v95; // xmm1
		  __int128 v96; // xmm0
		  Camera *v97; // r14
		  unsigned __int8 (__fastcall *v98)(Camera *); // rax
		  void (__fastcall *v99)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v100; // xmm1
		  __int128 v101; // xmm1
		  __int128 v102; // xmm1
		  __int128 v103; // xmm1
		  __int128 v104; // xmm0
		  __int128 v105; // xmm1
		  __int128 v106; // xmm2
		  __int128 v107; // xmm3
		  void (__fastcall *v108)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v109; // xmm0
		  __int128 v110; // xmm0
		  __int128 v111; // xmm1
		  void (__fastcall *v112)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v113; // xmm1
		  __int128 v114; // xmm0
		  __int128 v115; // xmm1
		  __int128 v116; // xmm0
		  __int128 v117; // xmm1
		  __int128 v118; // xmm1
		  float v119; // eax
		  __int128 v120; // xmm1
		  __int128 v121; // xmm0
		  __int128 v122; // xmm1
		  Matrix4x4 *HGCameraCullingMatrix; // rax
		  __int128 v124; // xmm1
		  __int128 v125; // xmm2
		  __int128 v126; // xmm3
		  float v127; // xmm7_4
		  __int64 v128; // rax
		  float m_X; // xmm1_4
		  Matrix4x4 *v130; // rax
		  __int128 v131; // xmm1
		  __int128 v132; // xmm2
		  __int128 v133; // xmm3
		  void (__fastcall *v134)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v135; // xmm1
		  __int128 v136; // xmm1
		  void (__fastcall *v137)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v138; // xmm1
		  __int128 v139; // xmm0
		  __int128 v140; // xmm1
		  __int128 v141; // xmm1
		  __int128 v142; // xmm1
		  void (__fastcall *v143)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v144; // xmm1
		  __int128 v145; // xmm6
		  __int128 v146; // xmm7
		  __int128 v147; // xmm9
		  __int128 v148; // xmm11
		  __int128 v149; // xmm0
		  __int128 v150; // xmm1
		  __int128 v151; // xmm1
		  __int128 v152; // xmm1
		  void (__fastcall *v153)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v154; // xmm1
		  __int128 v155; // xmm0
		  __int128 v156; // xmm1
		  Camera *v157; // rsi
		  unsigned __int8 (__fastcall *v158)(Camera *); // rax
		  Camera *v159; // rsi
		  unsigned int (__fastcall *v160)(Camera *); // rax
		  Camera *v161; // rsi
		  __int64 (__fastcall *v162)(Camera *); // rax
		  __int64 v163; // rsi
		  void (__fastcall *v164)(__int64, Quaternion *); // rax
		  Vector3 *v165; // rax
		  Camera *v166; // rsi
		  __int64 v167; // xmm7_8
		  float v168; // r14d
		  __int64 (__fastcall *v169)(Camera *); // rax
		  __int64 v170; // rsi
		  void (__fastcall *v171)(__int64, Quaternion *); // rax
		  Camera *v172; // rsi
		  void (__fastcall *v173)(Camera *); // rax
		  MethodInfo *v174; // r8
		  float v175; // xmm2_4
		  MethodInfo *v176; // r9
		  Vector3 *v177; // rax
		  __int64 v178; // xmm0_8
		  __int64 v179; // xmm3_8
		  MethodInfo *v180; // r9
		  Vector3 *v181; // rax
		  __int64 v182; // xmm12_8
		  float v183; // esi
		  Matrix4x4 *v184; // rax
		  __int128 v185; // xmm7
		  __int128 v186; // xmm9
		  __int128 v187; // xmm10
		  __int128 v188; // xmm11
		  void (__fastcall *v189)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *); // rax
		  void (__fastcall *v190)(Matrix4x4 *, Matrix4x4 *); // rax
		  void (__fastcall *v191)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v192; // xmm11
		  __int128 v193; // xmm12
		  __int128 v194; // xmm13
		  __int128 v195; // xmm14
		  Camera *v196; // rsi
		  void (__fastcall *v197)(Camera *); // rax
		  Camera *v198; // rsi
		  void (__fastcall *v199)(Camera *); // rax
		  void (__fastcall *v200)(Matrix4x4 *); // rax
		  __int64 v201; // rdx
		  void (__fastcall *v202)(Matrix4x4 *, __int64, Matrix4x4 *); // rax
		  __int128 v203; // xmm15
		  float m00; // xmm10_4
		  void (__fastcall *v205)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __m128 v206; // xmm7
		  __m128 v207; // xmm6
		  __m128 v208; // xmm9
		  void (__fastcall *v209)(Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v210; // xmm1
		  __int128 v211; // xmm0
		  __int128 v212; // xmm1
		  float v213; // xmm7_4
		  float v214; // xmm9_4
		  float v215; // xmm2_4
		  __m128 v216; // xmm4
		  float v217; // xmm8_4
		  __m128 v218; // xmm5
		  __m128 v219; // xmm4
		  float v220; // xmm6_4
		  __m128 v221; // xmm4
		  __m128 v222; // xmm7
		  __m128 v223; // xmm4
		  __int128 v224; // xmm9
		  __m128 v225; // xmm5
		  __m128 v226; // xmm7
		  void (__fastcall *v227)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  void (__fastcall *v228)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int128 v229; // xmm1
		  __int128 v230; // xmm0
		  __int128 v231; // xmm1
		  __int128 v232; // xmm0
		  __int128 v233; // xmm1
		  __int128 v234; // xmm0
		  __int128 v235; // xmm1
		  __int128 v236; // xmm1
		  float v237; // eax
		  __int128 v238; // xmm0
		  __int128 v239; // xmm0
		  __int128 v240; // xmm1
		  __int128 v241; // xmm0
		  __int128 v242; // xmm1
		  __int128 v243; // xmm0
		  __int128 v244; // xmm1
		  Matrix4x4 *inverse; // rax
		  __int128 v246; // xmm1
		  __int128 v247; // xmm2
		  __int128 v248; // xmm3
		  __int128 v249; // xmm0
		  __int128 v250; // xmm0
		  __int128 v251; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // r10
		  float z; // ecx
		  __int128 v254; // xmm1
		  __int128 v255; // xmm0
		  __int128 v256; // xmm1
		  __int128 v257; // xmm0
		  __int128 v258; // xmm1
		  __int128 v259; // xmm0
		  __int128 v260; // xmm1
		  __int128 v261; // xmm0
		  __int128 v262; // xmm1
		  __int128 v263; // xmm0
		  __int128 v264; // xmm1
		  __int64 v265; // rax
		  __int64 v266; // rax
		  __int64 v267; // rax
		  __int64 v268; // rax
		  __int64 v269; // rax
		  __int64 v270; // rax
		  Matrix4x4 *v271; // rax
		  ILFixDynamicMethodWrapper_2 *v272; // rax
		  Matrix4x4 *v273; // rax
		  __int64 v274; // rax
		  __int64 v275; // rax
		  Matrix4x4 *v276; // rax
		  __int64 v277; // rax
		  __int64 v278; // rax
		  __int64 v279; // rax
		  ILFixDynamicMethodWrapper_2 *v280; // rax
		  __int64 v281; // rax
		  __int64 v282; // rax
		  __int64 v283; // rax
		  __int64 v284; // rax
		  __int64 v285; // rax
		  __int64 v286; // rax
		  __int64 v287; // rax
		  __int64 v288; // rax
		  __int64 v289; // rax
		  __int64 v290; // rax
		  __int64 v291; // rax
		  ILFixDynamicMethodWrapper_2 *v292; // rax
		  Matrix4x4 *v293; // rax
		  __int64 v294; // rax
		  __int64 v295; // rax
		  __int64 v296; // rax
		  ILFixDynamicMethodWrapper_2 *v297; // rax
		  __int64 v298; // rax
		  __int64 v299; // rax
		  __int64 v300; // rax
		  __int64 v301; // rax
		  __int64 v302; // rax
		  __int64 v303; // rax
		  ILFixDynamicMethodWrapper_2 *v304; // rax
		  Matrix4x4 *v305; // rax
		  __int64 v306; // rax
		  __int64 v307; // rax
		  __int128 v308; // xmm1
		  __int128 v309; // xmm2
		  __int128 v310; // xmm3
		  __int128 v311; // xmm0
		  __int128 v312; // xmm1
		  __int128 v313; // xmm0
		  __int128 v314; // xmm1
		  __int128 v315; // xmm0
		  __int128 v316; // xmm1
		  __int128 v317; // xmm0
		  __int128 v318; // xmm1
		  Matrix4x4 v319; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 v320; // [rsp+A0h] [rbp-60h] BYREF
		  Vector3 v321; // [rsp+B0h] [rbp-50h] BYREF
		  Matrix4x4 v322; // [rsp+C0h] [rbp-40h] BYREF
		  Quaternion v323; // [rsp+100h] [rbp+0h] BYREF
		  Matrix4x4 v324; // [rsp+110h] [rbp+10h] BYREF
		  Matrix4x4 v325; // [rsp+150h] [rbp+50h] BYREF
		  Matrix4x4 v326; // [rsp+190h] [rbp+90h] BYREF
		  Matrix4x4 v327; // [rsp+1D0h] [rbp+D0h] BYREF
		  Matrix4x4 v328; // [rsp+210h] [rbp+110h] BYREF
		  Vector4 v329; // [rsp+250h] [rbp+150h] BYREF
		  __int128 v330; // [rsp+260h] [rbp+160h] BYREF
		  __int128 v331; // [rsp+270h] [rbp+170h]
		  __int128 v332; // [rsp+280h] [rbp+180h]
		  __int128 v333; // [rsp+290h] [rbp+190h]
		  Matrix4x4 v334; // [rsp+2A0h] [rbp+1A0h] BYREF
		  Matrix4x4 P0; // [rsp+2E0h] [rbp+1E0h] BYREF
		
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size > 769 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v12->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_93;
		    if ( wrapperArray->max_length.size <= 0x301u )
		      goto LABEL_232;
		    if ( wrapperArray[21].vector[13] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(769, 0LL);
		      if ( Patch )
		      {
		        z = cameraPosition->z;
		        *(_QWORD *)&v321.x = *(_QWORD *)&cameraPosition->x;
		        v321.z = z;
		        v254 = *(_OWORD *)&invViewMatrix->m01;
		        *(_OWORD *)&v319.m00 = *(_OWORD *)&invViewMatrix->m00;
		        v255 = *(_OWORD *)&invViewMatrix->m02;
		        *(_OWORD *)&v319.m01 = v254;
		        v256 = *(_OWORD *)&invViewMatrix->m03;
		        *(_OWORD *)&v319.m02 = v255;
		        v257 = *(_OWORD *)&viewMatrix->m00;
		        *(_OWORD *)&v319.m03 = v256;
		        v258 = *(_OWORD *)&viewMatrix->m01;
		        *(_OWORD *)&v322.m00 = v257;
		        v259 = *(_OWORD *)&viewMatrix->m02;
		        *(_OWORD *)&v322.m01 = v258;
		        v260 = *(_OWORD *)&viewMatrix->m03;
		        *(_OWORD *)&v322.m02 = v259;
		        v261 = *(_OWORD *)&projMatrix->m00;
		        *(_OWORD *)&v322.m03 = v260;
		        v262 = *(_OWORD *)&projMatrix->m01;
		        *(_OWORD *)&P0.m00 = v261;
		        v263 = *(_OWORD *)&projMatrix->m02;
		        *(_OWORD *)&P0.m01 = v262;
		        v264 = *(_OWORD *)&projMatrix->m03;
		        *(_OWORD *)&P0.m02 = v263;
		        *(_OWORD *)&P0.m03 = v264;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_305(
		          Patch,
		          (Object *)this,
		          viewConstants,
		          &P0,
		          &v322,
		          &v319,
		          &v321,
		          jitterProjectionMatrix,
		          updatePreviousFrameConstants,
		          (Object *)hgrp,
		          0LL);
		        return;
		      }
		      goto LABEL_93;
		    }
		  }
		  v16 = *(_OWORD *)&projMatrix->m00;
		  v17 = *(_OWORD *)&projMatrix->m01;
		  if ( jitterProjectionMatrix )
		  {
		    *(_OWORD *)&v319.m00 = *(_OWORD *)&projMatrix->m00;
		    v18 = *(_OWORD *)&projMatrix->m02;
		    *(_OWORD *)&v319.m01 = v17;
		    v19 = *(_OWORD *)&projMatrix->m03;
		    *(_OWORD *)&v319.m02 = v18;
		    *(_OWORD *)&v319.m03 = v19;
		    JitteredProjectionMatrix = HG::Rendering::Runtime::HGCamera::GetJitteredProjectionMatrix(
		                                 &v324,
		                                 this,
		                                 &v319,
		                                 hgrp,
		                                 0LL);
		    v16 = *(_OWORD *)&JitteredProjectionMatrix->m00;
		    v17 = *(_OWORD *)&JitteredProjectionMatrix->m01;
		    v21 = *(_OWORD *)&JitteredProjectionMatrix->m02;
		    v22 = *(_OWORD *)&JitteredProjectionMatrix->m03;
		  }
		  else
		  {
		    v21 = *(_OWORD *)&projMatrix->m02;
		    v22 = *(_OWORD *)&projMatrix->m03;
		  }
		  v23 = (void (__fastcall *)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *))qword_18F36F3B8;
		  v330 = v16;
		  v331 = v17;
		  v332 = v21;
		  v333 = v22;
		  memset(&v327, 0, sizeof(v327));
		  if ( !qword_18F36F3B8 )
		  {
		    v23 = (void (__fastcall *)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                                "UnityEngine.GL::GetGPUPr"
		                                                                                                "ojectionMatrix_Injected("
		                                                                                                "UnityEngine.Matrix4x4&,S"
		                                                                                                "ystem.Boolean,UnityEngine.Matrix4x4&)");
		    if ( !v23 )
		    {
		      v265 = sub_1802EE1B8(
		               "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v265, 0LL);
		    }
		    qword_18F36F3B8 = (__int64)v23;
		  }
		  LOBYTE(wrapperArray) = 1;
		  v23(&v330, wrapperArray, &v327);
		  v25 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))qword_18F36F3B8;
		  v26 = *(_OWORD *)&projMatrix->m01;
		  *(_OWORD *)&v325.m00 = *(_OWORD *)&projMatrix->m00;
		  *(_OWORD *)&v325.m01 = v26;
		  v27 = *(_OWORD *)&v327.m00;
		  *(_OWORD *)&v325.m02 = *(_OWORD *)&projMatrix->m02;
		  *(_OWORD *)&P0.m00 = *(_OWORD *)&v327.m00;
		  v28 = *(__m128 *)&v327.m01;
		  v29 = *(__m128 *)&v327.m02;
		  *(_OWORD *)&P0.m01 = *(_OWORD *)&v327.m01;
		  *(_OWORD *)&P0.m02 = *(_OWORD *)&v327.m02;
		  v30 = *(__m128 *)&v327.m03;
		  v31 = *(_OWORD *)&projMatrix->m03;
		  *(_OWORD *)&P0.m03 = *(_OWORD *)&v327.m03;
		  *(_OWORD *)&v325.m03 = v31;
		  memset(&v322, 0, sizeof(v322));
		  if ( !qword_18F36F3B8 )
		  {
		    v25 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.GL::GetGPUProjectionMatrix_Injected(Unit"
		                                                                    "yEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		    if ( !v25 )
		    {
		      v266 = sub_1802EE1B8(
		               "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v266, 0LL);
		    }
		    qword_18F36F3B8 = (__int64)v25;
		  }
		  LOBYTE(v24) = 1;
		  v25(&v325, v24, &v322);
		  v32 = (void (__fastcall *)(__int128 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  v33 = *(_OWORD *)&viewMatrix->m01;
		  *(_OWORD *)&v327.m00 = *(_OWORD *)&viewMatrix->m00;
		  *(_OWORD *)&v327.m01 = v33;
		  v34 = *(_OWORD *)&v322.m00;
		  *(_OWORD *)&v327.m02 = *(_OWORD *)&viewMatrix->m02;
		  v330 = *(_OWORD *)&v322.m00;
		  v35 = *(_OWORD *)&v322.m01;
		  v36 = *(_OWORD *)&v322.m02;
		  v331 = *(_OWORD *)&v322.m01;
		  v332 = *(_OWORD *)&v322.m02;
		  v37 = *(_OWORD *)&v322.m03;
		  v38 = *(_OWORD *)&viewMatrix->m03;
		  v333 = *(_OWORD *)&v322.m03;
		  *(_OWORD *)&v327.m03 = v38;
		  memset(&v319, 0, sizeof(v319));
		  if ( !qword_18F36FA50 )
		  {
		    v32 = (void (__fastcall *)(__int128 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                       "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
		                                                                       "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
		                                                                       "x4&,UnityEngine.Matrix4x4&)");
		    if ( !v32 )
		    {
		      v267 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v267, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v32;
		  }
		  v32(&v330, &v327, &v319);
		  v39 = *(_OWORD *)&viewMatrix->m01;
		  *(_OWORD *)&v325.m00 = *(_OWORD *)&viewMatrix->m00;
		  v40 = *(_OWORD *)&viewMatrix->m02;
		  *(_OWORD *)&v325.m01 = v39;
		  v41 = *(_OWORD *)&viewMatrix->m03;
		  *(_OWORD *)&v325.m02 = v40;
		  *(_OWORD *)&v325.m03 = v41;
		  UnityEngine::Matrix4x4::set_Item(&v325, 12, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(&v325, 13, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(&v325, 14, 0.0, 0LL);
		  UnityEngine::Matrix4x4::set_Item(&v325, 15, 1.0, 0LL);
		  v42 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  v334 = v325;
		  *(_OWORD *)&v328.m00 = v34;
		  *(_OWORD *)&v328.m01 = v35;
		  *(_OWORD *)&v328.m02 = v36;
		  *(_OWORD *)&v328.m03 = v37;
		  memset(&v327, 0, sizeof(v327));
		  if ( !qword_18F36FA50 )
		  {
		    v42 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_I"
		                                                                        "njected(UnityEngine.Matrix4x4&,UnityEngine.Matri"
		                                                                        "x4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v42 )
		    {
		      v268 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v268, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v42;
		  }
		  v42(&v328, &v334, &v327);
		  v43 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))qword_18F36FA50;
		  v326 = v325;
		  *(_OWORD *)&v324.m00 = v27;
		  *(__m128 *)&v324.m01 = v28;
		  *(__m128 *)&v324.m02 = v29;
		  *(__m128 *)&v324.m03 = v30;
		  v330 = 0LL;
		  v331 = 0LL;
		  v332 = 0LL;
		  v333 = 0LL;
		  if ( !qword_18F36FA50 )
		  {
		    v43 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                       "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
		                                                                       "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
		                                                                       "x4&,UnityEngine.Matrix4x4&)");
		    if ( !v43 )
		    {
		      v269 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v269, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v43;
		  }
		  v43(&v324, &v326, &v330);
		  if ( updatePreviousFrameConstants )
		  {
		    if ( this->fields._isFirstFrame_k__BackingField )
		    {
		      v236 = *(_OWORD *)&viewMatrix->m01;
		      v237 = cameraPosition->z;
		      *(_QWORD *)&viewConstants->prevWorldSpaceCameraPos.x = *(_QWORD *)&cameraPosition->x;
		      v238 = *(_OWORD *)&viewMatrix->m00;
		      viewConstants->prevWorldSpaceCameraPos.z = v237;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m00 = v238;
		      v239 = *(_OWORD *)&viewMatrix->m02;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m01 = v236;
		      v240 = *(_OWORD *)&viewMatrix->m03;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m02 = v239;
		      v241 = *(_OWORD *)&v319.m00;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m03 = v240;
		      v242 = *(_OWORD *)&v319.m01;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m00 = v241;
		      v243 = *(_OWORD *)&v319.m02;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m01 = v242;
		      v244 = *(_OWORD *)&v319.m03;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m02 = v243;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m03 = v244;
		      inverse = UnityEngine::Matrix4x4::get_inverse(&v328, &viewConstants->prevNonJitteredViewProjMatrix, 0LL);
		      v246 = *(_OWORD *)&inverse->m01;
		      v247 = *(_OWORD *)&inverse->m02;
		      v248 = *(_OWORD *)&inverse->m03;
		      *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&inverse->m00;
		      v249 = v330;
		      *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m01 = v246;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m00 = v249;
		      v250 = v331;
		      *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m02 = v247;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m01 = v250;
		      v251 = v332;
		      *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m03 = v248;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m02 = v251;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m03 = v333;
		      viewConstants->prevNonJitteredViewNoTransProjMatrix = v327;
		    }
		    else
		    {
		      v44 = *(_OWORD *)&viewConstants->viewMatrix.m01;
		      v45 = viewConstants->worldSpaceCameraPos.z;
		      *(_QWORD *)&viewConstants->prevWorldSpaceCameraPos.x = *(_QWORD *)&viewConstants->worldSpaceCameraPos.x;
		      v46 = *(_OWORD *)&viewConstants->viewMatrix.m00;
		      viewConstants->prevWorldSpaceCameraPos.z = v45;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m00 = v46;
		      v47 = *(_OWORD *)&viewConstants->viewMatrix.m02;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m01 = v44;
		      v48 = *(_OWORD *)&viewConstants->viewMatrix.m03;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m02 = v47;
		      v49 = *(_OWORD *)&viewConstants->viewProjMatrix.m00;
		      *(_OWORD *)&viewConstants->prevViewMatrix.m03 = v48;
		      v50 = *(_OWORD *)&viewConstants->viewProjMatrix.m01;
		      *(_OWORD *)&viewConstants->prevViewProjMatrix.m00 = v49;
		      v51 = *(_OWORD *)&viewConstants->viewProjMatrix.m02;
		      *(_OWORD *)&viewConstants->prevViewProjMatrix.m01 = v50;
		      v52 = *(_OWORD *)&viewConstants->viewProjMatrix.m03;
		      *(_OWORD *)&viewConstants->prevViewProjMatrix.m02 = v51;
		      v53 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m00;
		      *(_OWORD *)&viewConstants->prevViewProjMatrix.m03 = v52;
		      v54 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m01;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m00 = v53;
		      v55 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m02;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m01 = v54;
		      v56 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m03;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m02 = v55;
		      v57 = *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m00;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m03 = v56;
		      v58 = *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m01;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m00 = v57;
		      v59 = *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m02;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m01 = v58;
		      v60 = *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m03;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m02 = v59;
		      v61 = *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m00;
		      *(_OWORD *)&viewConstants->prevViewNoTransProjMatrix.m03 = v60;
		      v62 = *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m01;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewNoTransProjMatrix.m00 = v61;
		      v63 = *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m02;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewNoTransProjMatrix.m01 = v62;
		      v64 = *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m03;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewNoTransProjMatrix.m02 = v63;
		      *(_OWORD *)&viewConstants->prevNonJitteredViewNoTransProjMatrix.m03 = v64;
		    }
		  }
		  v65 = *(_OWORD *)&viewMatrix->m01;
		  *(_OWORD *)&viewConstants->viewMatrix.m00 = *(_OWORD *)&viewMatrix->m00;
		  v66 = *(_OWORD *)&viewMatrix->m02;
		  *(_OWORD *)&viewConstants->viewMatrix.m01 = v65;
		  v67 = *(_OWORD *)&viewMatrix->m03;
		  *(_OWORD *)&viewConstants->viewMatrix.m02 = v66;
		  v68 = *(_OWORD *)&invViewMatrix->m00;
		  *(_OWORD *)&viewConstants->projMatrix.m00 = v27;
		  *(_OWORD *)&viewConstants->invViewMatrix.m00 = v68;
		  v69 = *(_OWORD *)&invViewMatrix->m02;
		  *(_OWORD *)&viewConstants->nonJitteredProjMatrix.m00 = v34;
		  *(_OWORD *)&viewConstants->viewMatrix.m03 = v67;
		  v70 = *(_OWORD *)&invViewMatrix->m01;
		  *(__m128 *)&viewConstants->projMatrix.m01 = v28;
		  *(_OWORD *)&viewConstants->invViewMatrix.m01 = v70;
		  v71 = *(_OWORD *)&invViewMatrix->m03;
		  *(_OWORD *)&viewConstants->nonJitteredProjMatrix.m01 = v35;
		  *(_OWORD *)&viewConstants->invViewMatrix.m02 = v69;
		  *(__m128 *)&viewConstants->projMatrix.m02 = v29;
		  *(_OWORD *)&viewConstants->nonJitteredProjMatrix.m02 = v36;
		  *(_OWORD *)&viewConstants->invViewMatrix.m03 = v71;
		  *(__m128 *)&viewConstants->projMatrix.m03 = v30;
		  *(_OWORD *)&viewConstants->nonJitteredProjMatrix.m03 = v37;
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_93;
		  v73 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v73 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v73 )
		    {
		      v270 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v270, 0LL);
		    }
		    qword_18F36F100 = (__int64)v73;
		  }
		  if ( v73(camera) )
		  {
		    v271 = UnityEngine::Matrix4x4::get_inverse(&v328, &P0, 0LL);
		    v87 = *(Quaternion *)&v271->m00;
		    v88 = *(__m128 *)&v271->m01;
		    v89 = *(__m128 *)&v271->m02;
		    v86 = *(__m128 *)&v271->m03;
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v12->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_93;
		    if ( wrapperArray->max_length.size <= 772 )
		      goto LABEL_24;
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v12 = (struct ILFixDynamicMethodWrapper_2__Class *)v12->static_fields->wrapperArray;
		    if ( !v12 )
		      goto LABEL_93;
		    if ( LODWORD(v12->_0.namespaze) <= 0x304 )
		      goto LABEL_232;
		    if ( v12[16].rgctx_data )
		    {
		      v272 = IFix::WrappersManagerImpl::GetPatch(772, 0LL);
		      if ( !v272 )
		        goto LABEL_93;
		      v273 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_300(&v328, v272, &P0, 0LL);
		      v30 = *(__m128 *)&P0.m03;
		      v29 = *(__m128 *)&P0.m02;
		      v28 = *(__m128 *)&P0.m01;
		      v87 = *(Quaternion *)&v273->m00;
		      v88 = *(__m128 *)&v273->m01;
		      v89 = *(__m128 *)&v273->m02;
		      v86 = *(__m128 *)&v273->m03;
		      v27 = *(_OWORD *)&P0.m00;
		    }
		    else
		    {
		LABEL_24:
		      v325.m01 = 0.0;
		      v325.m23 = -1.0;
		      *(_QWORD *)&v325.m02 = 0LL;
		      v325.m22 = 0.0;
		      v74 = _mm_shuffle_ps(v28, v28, 85).m128_f32[0];
		      v75 = 1.0 / v74;
		      v76 = _mm_shuffle_ps(v29, v29, 85).m128_f32[0] / v74;
		      v77 = _mm_shuffle_ps(v30, v30, 170).m128_f32[0];
		      v78 = 1.0 / v77;
		      v79 = _mm_shuffle_ps(v29, v29, 170).m128_f32[0] / v77;
		      m00_low = (Quaternion)LODWORD(v325.m00);
		      m00_low.x = 1.0 / *(float *)&v27;
		      v323 = m00_low;
		      *(Quaternion *)&v325.m00 = m00_low;
		      v81 = *(__m128 *)&v325.m03;
		      v81.m128_f32[0] = v29.m128_f32[0] / *(float *)&v27;
		      v82 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v325.m01, (__m128)*(unsigned __int64 *)&v325.m01, 225);
		      v37 = *(_OWORD *)&v322.m03;
		      v82.m128_f32[0] = v75;
		      v83 = _mm_shuffle_ps(v81, v81, 225);
		      v83.m128_f32[0] = v76;
		      v84 = _mm_shuffle_ps(v83, v83, 135);
		      v85 = _mm_shuffle_ps(*(__m128 *)&v325.m02, *(__m128 *)&v325.m02, 147);
		      v84.m128_f32[0] = v79;
		      v85.m128_f32[0] = v78;
		      v86 = _mm_shuffle_ps(v84, v84, 57);
		      v87 = v323;
		      v88 = _mm_shuffle_ps(v82, v82, 225);
		      v89 = _mm_shuffle_ps(v85, v85, 57);
		      *(__m128 *)&v325.m03 = v86;
		      *(__m128 *)&v325.m01 = v88;
		      *(__m128 *)&v325.m02 = v89;
		    }
		  }
		  v90 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  *(_OWORD *)&v326.m00 = v27;
		  *(__m128 *)&v326.m01 = v28;
		  *(__m128 *)&v326.m02 = v29;
		  *(__m128 *)&v326.m03 = v30;
		  *(Quaternion *)&viewConstants->invProjMatrix.m00 = v87;
		  v91 = *(_OWORD *)&viewMatrix->m01;
		  *(__m128 *)&viewConstants->invProjMatrix.m01 = v88;
		  *(_OWORD *)&v324.m01 = v91;
		  v92 = *(_OWORD *)&viewMatrix->m03;
		  *(__m128 *)&viewConstants->invProjMatrix.m02 = v89;
		  *(_OWORD *)&v324.m03 = v92;
		  *(__m128 *)&viewConstants->invProjMatrix.m03 = v86;
		  *(_OWORD *)&v324.m00 = *(_OWORD *)&viewMatrix->m00;
		  *(_OWORD *)&v324.m02 = *(_OWORD *)&viewMatrix->m02;
		  memset(&v319, 0, sizeof(v319));
		  if ( !v90 )
		  {
		    v90 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_I"
		                                                                        "njected(UnityEngine.Matrix4x4&,UnityEngine.Matri"
		                                                                        "x4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v90 )
		    {
		      v274 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v274, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v90;
		  }
		  v90(&v326, &v324, &v319);
		  v93 = *(_OWORD *)&v319.m01;
		  *(_OWORD *)&viewConstants->viewProjMatrix.m00 = *(_OWORD *)&v319.m00;
		  v94 = *(_OWORD *)&v319.m02;
		  *(_OWORD *)&viewConstants->viewProjMatrix.m01 = v93;
		  v95 = *(_OWORD *)&v319.m03;
		  *(_OWORD *)&viewConstants->viewProjMatrix.m02 = v94;
		  v96 = v330;
		  *(_OWORD *)&viewConstants->viewProjMatrix.m03 = v95;
		  *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m00 = v96;
		  *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m01 = v331;
		  *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m02 = v332;
		  *(_OWORD *)&viewConstants->viewNoTransProjMatrix.m03 = v333;
		  v97 = this->fields.camera;
		  if ( !v97 )
		    goto LABEL_93;
		  v98 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v98 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v98 )
		    {
		      v275 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v275, 0LL);
		    }
		    qword_18F36F100 = (__int64)v98;
		  }
		  if ( v98(v97) )
		  {
		    v276 = UnityEngine::Matrix4x4::get_inverse(&v324, &viewConstants->viewProjMatrix, 0LL);
		    v104 = *(_OWORD *)&v276->m00;
		    v105 = *(_OWORD *)&v276->m01;
		    v106 = *(_OWORD *)&v276->m02;
		    v107 = *(_OWORD *)&v276->m03;
		  }
		  else
		  {
		    v99 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		    v100 = *(_OWORD *)&viewConstants->invViewMatrix.m01;
		    *(_OWORD *)&v326.m00 = *(_OWORD *)&viewConstants->invViewMatrix.m00;
		    *(_OWORD *)&v326.m01 = v100;
		    v101 = *(_OWORD *)&viewConstants->invViewMatrix.m03;
		    *(_OWORD *)&v326.m02 = *(_OWORD *)&viewConstants->invViewMatrix.m02;
		    *(_OWORD *)&v326.m03 = v101;
		    v102 = *(_OWORD *)&viewConstants->invProjMatrix.m01;
		    *(_OWORD *)&v324.m00 = *(_OWORD *)&viewConstants->invProjMatrix.m00;
		    *(_OWORD *)&v324.m01 = v102;
		    v103 = *(_OWORD *)&viewConstants->invProjMatrix.m03;
		    *(_OWORD *)&v324.m02 = *(_OWORD *)&viewConstants->invProjMatrix.m02;
		    *(_OWORD *)&v324.m03 = v103;
		    memset(&v319, 0, sizeof(v319));
		    if ( !qword_18F36FA50 )
		    {
		      v99 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast"
		                                                                          "_Injected(UnityEngine.Matrix4x4&,UnityEngine.M"
		                                                                          "atrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v99 )
		      {
		        v277 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v277, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v99;
		    }
		    v99(&v326, &v324, &v319);
		    v104 = *(_OWORD *)&v319.m00;
		    v105 = *(_OWORD *)&v319.m01;
		    v106 = *(_OWORD *)&v319.m02;
		    v107 = *(_OWORD *)&v319.m03;
		  }
		  v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  *(_OWORD *)&v334.m00 = v34;
		  *(_OWORD *)&v334.m01 = v35;
		  *(_OWORD *)&v334.m02 = v36;
		  *(_OWORD *)&v334.m03 = v37;
		  *(_OWORD *)&viewConstants->invViewProjMatrix.m00 = v104;
		  v109 = *(_OWORD *)&viewMatrix->m00;
		  *(_OWORD *)&viewConstants->invViewProjMatrix.m01 = v105;
		  *(_OWORD *)&v328.m00 = v109;
		  v110 = *(_OWORD *)&viewMatrix->m02;
		  *(_OWORD *)&v328.m01 = *(_OWORD *)&viewMatrix->m01;
		  *(_OWORD *)&v328.m02 = v110;
		  v111 = *(_OWORD *)&viewMatrix->m03;
		  *(_OWORD *)&viewConstants->invViewProjMatrix.m02 = v106;
		  *(_OWORD *)&v328.m03 = v111;
		  memset(&v322, 0, sizeof(v322));
		  *(_OWORD *)&viewConstants->invViewProjMatrix.m03 = v107;
		  if ( !v108 )
		  {
		    v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v108 )
		    {
		      v278 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v278, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v108;
		  }
		  v108(&v334, &v328, &v322);
		  v112 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		  v113 = *(_OWORD *)&v322.m01;
		  *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m00 = *(_OWORD *)&v322.m00;
		  v114 = *(_OWORD *)&v322.m02;
		  *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m01 = v113;
		  v115 = *(_OWORD *)&v322.m03;
		  *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m02 = v114;
		  v116 = *(_OWORD *)&v327.m00;
		  *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m03 = v115;
		  v117 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m01;
		  *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m00 = v116;
		  *(_OWORD *)&v324.m01 = v117;
		  v118 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m03;
		  *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m01 = *(_OWORD *)&v327.m01;
		  *(_OWORD *)&v324.m03 = v118;
		  *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m02 = *(_OWORD *)&v327.m02;
		  *(_OWORD *)&viewConstants->nonJitteredViewNoTransProjMatrix.m03 = *(_OWORD *)&v327.m03;
		  *(_OWORD *)&v324.m00 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m00;
		  *(_OWORD *)&v324.m02 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m02;
		  memset(&v319, 0, sizeof(v319));
		  if ( !v112 )
		  {
		    v112 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
		                                                            "4&,UnityEngine.Matrix4x4&)");
		    if ( !v112 )
		    {
		      v279 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v279, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v112;
		  }
		  v112(&v324, &v319);
		  v119 = cameraPosition->z;
		  v120 = *(_OWORD *)&v319.m01;
		  *(_OWORD *)&viewConstants->invNonJitteredViewProjMatrix.m00 = *(_OWORD *)&v319.m00;
		  v121 = *(_OWORD *)&v319.m02;
		  *(_OWORD *)&viewConstants->invNonJitteredViewProjMatrix.m01 = v120;
		  v122 = *(_OWORD *)&v319.m03;
		  *(_OWORD *)&viewConstants->invNonJitteredViewProjMatrix.m02 = v121;
		  *(_QWORD *)&viewConstants->worldSpaceCameraPos.x = *(_QWORD *)&cameraPosition->x;
		  viewConstants->worldSpaceCameraPos.z = v119;
		  *(_OWORD *)&viewConstants->invNonJitteredViewProjMatrix.m03 = v122;
		  *(_QWORD *)&viewConstants->worldSpaceCameraPosViewOffset.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  viewConstants->worldSpaceCameraPosViewOffset.z = 0.0;
		  HGCameraCullingMatrix = HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(&v324, this, 0LL);
		  v124 = *(_OWORD *)&HGCameraCullingMatrix->m01;
		  v125 = *(_OWORD *)&HGCameraCullingMatrix->m02;
		  v126 = *(_OWORD *)&HGCameraCullingMatrix->m03;
		  *(_OWORD *)&viewConstants->cullingMatrix.m00 = *(_OWORD *)&HGCameraCullingMatrix->m00;
		  *(_OWORD *)&viewConstants->cullingMatrix.m01 = v124;
		  *(_OWORD *)&viewConstants->cullingMatrix.m02 = v125;
		  *(_OWORD *)&viewConstants->cullingMatrix.m03 = v126;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size <= 773 )
		    goto LABEL_39;
		  if ( !v12->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v12);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size <= 0x305u )
		    goto LABEL_232;
		  if ( wrapperArray[21].vector[17] )
		  {
		    v280 = IFix::WrappersManagerImpl::GetPatch(773, 0LL);
		    if ( !v280 )
		      goto LABEL_93;
		    v127 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_301(v280, &P0, 0LL);
		  }
		  else
		  {
		LABEL_39:
		    v127 = (float)-_mm_shuffle_ps(v28, v28, 85).m128_f32[0] / *(float *)&v27;
		  }
		  v128 = HIDWORD(*(_QWORD *)&this->fields._sceneRTSize_k__BackingField);
		  m_X = (float)this->fields._sceneRTSize_k__BackingField.m_X;
		  *(_QWORD *)&v329.z = 0LL;
		  v329.x = m_X;
		  v329.y = (float)(int)v128;
		  v130 = HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
		           &v334,
		           this,
		           viewConstants,
		           &v329,
		           v127,
		           0LL);
		  v131 = *(_OWORD *)&v130->m01;
		  v132 = *(_OWORD *)&v130->m02;
		  v133 = *(_OWORD *)&v130->m03;
		  *(_OWORD *)&viewConstants->pixelCoordToViewDirWS.m00 = *(_OWORD *)&v130->m00;
		  *(_OWORD *)&viewConstants->pixelCoordToViewDirWS.m01 = v131;
		  *(_OWORD *)&viewConstants->pixelCoordToViewDirWS.m02 = v132;
		  *(_OWORD *)&viewConstants->pixelCoordToViewDirWS.m03 = v133;
		  if ( updatePreviousFrameConstants )
		  {
		    v134 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		    v135 = *(_OWORD *)&viewConstants->prevViewProjMatrix.m01;
		    *(_OWORD *)&v324.m00 = *(_OWORD *)&viewConstants->prevViewProjMatrix.m00;
		    *(_OWORD *)&v324.m01 = v135;
		    v136 = *(_OWORD *)&viewConstants->prevViewProjMatrix.m03;
		    *(_OWORD *)&v324.m02 = *(_OWORD *)&viewConstants->prevViewProjMatrix.m02;
		    *(_OWORD *)&v324.m03 = v136;
		    memset(&v319, 0, sizeof(v319));
		    if ( !qword_18F36FA60 )
		    {
		      v134 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
		                                                              "4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v134 )
		      {
		        v281 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v281, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v134;
		    }
		    v134(&v324, &v319);
		    v137 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		    v138 = *(_OWORD *)&v319.m01;
		    *(_OWORD *)&viewConstants->prevInvViewProjMatrix.m00 = *(_OWORD *)&v319.m00;
		    v139 = *(_OWORD *)&v319.m02;
		    *(_OWORD *)&viewConstants->prevInvViewProjMatrix.m01 = v138;
		    v140 = *(_OWORD *)&v319.m03;
		    *(_OWORD *)&viewConstants->prevInvViewProjMatrix.m02 = v139;
		    *(_OWORD *)&viewConstants->prevInvViewProjMatrix.m03 = v140;
		    v141 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m01;
		    *(_OWORD *)&v326.m00 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m00;
		    *(_OWORD *)&v326.m01 = v141;
		    v142 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m03;
		    *(_OWORD *)&v326.m02 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m02;
		    *(_OWORD *)&v326.m03 = v142;
		    memset(&v322, 0, sizeof(v322));
		    if ( !v137 )
		    {
		      v137 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
		                                                              "4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v137 )
		      {
		        v282 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v282, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v137;
		    }
		    v137(&v326, &v322);
		    v143 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		    v144 = *(_OWORD *)&v322.m01;
		    v145 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m00;
		    v146 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m01;
		    v147 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m02;
		    v148 = *(_OWORD *)&viewConstants->prevNonJitteredViewProjMatrix.m03;
		    *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&v322.m00;
		    v149 = *(_OWORD *)&v322.m02;
		    *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m01 = v144;
		    v150 = *(_OWORD *)&v322.m03;
		    *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m02 = v149;
		    *(_OWORD *)&viewConstants->prevNonJitteredInvViewProjMatrix.m03 = v150;
		    v151 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m01;
		    *(_OWORD *)&v324.m00 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m00;
		    *(_OWORD *)&v324.m01 = v151;
		    v152 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m03;
		    *(_OWORD *)&v324.m02 = *(_OWORD *)&viewConstants->nonJitteredViewProjMatrix.m02;
		    *(_OWORD *)&v324.m03 = v152;
		    memset(&v319, 0, sizeof(v319));
		    if ( !v143 )
		    {
		      v143 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
		                                                              "4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v143 )
		      {
		        v283 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v283, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v143;
		    }
		    v143(&v324, &v319);
		    v153 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		    *(_OWORD *)&v328.m00 = v145;
		    v326 = v319;
		    *(_OWORD *)&v328.m01 = v146;
		    *(_OWORD *)&v328.m02 = v147;
		    *(_OWORD *)&v328.m03 = v148;
		    memset(&v322, 0, sizeof(v322));
		    if ( !qword_18F36FA50 )
		    {
		      v153 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                           "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fas"
		                                                                           "t_Injected(UnityEngine.Matrix4x4&,UnityEngine"
		                                                                           ".Matrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v153 )
		      {
		        v284 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v284, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v153;
		    }
		    v153(&v328, &v326, &v322);
		    v154 = *(_OWORD *)&v322.m01;
		    *(_OWORD *)&viewConstants->reprojectionMatrix.m00 = *(_OWORD *)&v322.m00;
		    v155 = *(_OWORD *)&v322.m02;
		    *(_OWORD *)&viewConstants->reprojectionMatrix.m01 = v154;
		    v156 = *(_OWORD *)&v322.m03;
		    *(_OWORD *)&viewConstants->reprojectionMatrix.m02 = v155;
		    *(_OWORD *)&viewConstants->reprojectionMatrix.m03 = v156;
		  }
		  v157 = this->fields.camera;
		  if ( !v157 )
		    goto LABEL_93;
		  v158 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v158 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v158 )
		    {
		      v285 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v285, 0LL);
		    }
		    qword_18F36F100 = (__int64)v158;
		  }
		  if ( v158(v157) )
		    goto LABEL_239;
		  v159 = this->fields.camera;
		  if ( !v159 )
		    goto LABEL_93;
		  v160 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v160 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v160 )
		    {
		      v286 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v286, 0LL);
		    }
		    qword_18F36F138 = (__int64)v160;
		  }
		  if ( v160(v159) == 16 )
		  {
		LABEL_239:
		    v308 = *(_OWORD *)&viewConstants->viewProjMatrix.m01;
		    v309 = *(_OWORD *)&viewConstants->cullingMatrix.m02;
		    v310 = *(_OWORD *)&viewConstants->cullingMatrix.m03;
		    *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m00 = *(_OWORD *)&viewConstants->viewProjMatrix.m00;
		    v311 = *(_OWORD *)&viewConstants->viewProjMatrix.m02;
		    *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m01 = v308;
		    v312 = *(_OWORD *)&viewConstants->viewProjMatrix.m03;
		    *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m02 = v311;
		    v313 = *(_OWORD *)&viewConstants->invViewProjMatrix.m00;
		    *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m03 = v312;
		    v314 = *(_OWORD *)&viewConstants->invViewProjMatrix.m01;
		    *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m00 = v313;
		    v315 = *(_OWORD *)&viewConstants->invViewProjMatrix.m02;
		    *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m01 = v314;
		    v316 = *(_OWORD *)&viewConstants->invViewProjMatrix.m03;
		    *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m02 = v315;
		    v317 = *(_OWORD *)&viewConstants->cullingMatrix.m00;
		    *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m03 = v316;
		    v318 = *(_OWORD *)&viewConstants->cullingMatrix.m01;
		    *(_OWORD *)&this->fields.waterCullingMatrix.m00 = v317;
		    *(_OWORD *)&this->fields.waterCullingMatrix.m01 = v318;
		    *(_OWORD *)&this->fields.waterCullingMatrix.m02 = v309;
		    *(_OWORD *)&this->fields.waterCullingMatrix.m03 = v310;
		    return;
		  }
		  v161 = this->fields.camera;
		  if ( !v161 )
		    goto LABEL_93;
		  v162 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v162 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v162 )
		    {
		      v287 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v287, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v162;
		  }
		  v163 = v162(v161);
		  if ( !v163 )
		    goto LABEL_93;
		  v164 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		  v323 = 0LL;
		  if ( !qword_18F370110 )
		  {
		    v164 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		    if ( !v164 )
		    {
		      v288 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		      sub_18007E1B0(v288, 0LL);
		    }
		    qword_18F370110 = (__int64)v164;
		  }
		  v164(v163, &v323);
		  v321.z = 1.0;
		  *(_QWORD *)&v321.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v165 = UnityEngine::Quaternion::op_Multiply(&v320, &v323, &v321, 0LL);
		  v166 = this->fields.camera;
		  v167 = *(_QWORD *)&v165->x;
		  v168 = v165->z;
		  if ( !v166 )
		    goto LABEL_93;
		  v169 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v169 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v169 )
		    {
		      v289 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v289, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v169;
		  }
		  v170 = v169(v166);
		  if ( !v170 )
		    goto LABEL_93;
		  v171 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		  v323 = 0LL;
		  if ( !qword_18F370110 )
		  {
		    v171 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		    if ( !v171 )
		    {
		      v290 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		      sub_18007E1B0(v290, 0LL);
		    }
		    qword_18F370110 = (__int64)v171;
		  }
		  v171(v170, &v323);
		  v172 = this->fields.camera;
		  if ( !v172 )
		    goto LABEL_93;
		  v173 = (void (__fastcall *)(Camera *))qword_18F36F0D0;
		  if ( !qword_18F36F0D0 )
		  {
		    v173 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_fieldOfView()");
		    if ( !v173 )
		    {
		      v291 = sub_1802EE1B8("UnityEngine.Camera::get_fieldOfView()");
		      sub_18007E1B0(v291, 0LL);
		    }
		    qword_18F36F0D0 = (__int64)v173;
		  }
		  v173(v172);
		  v321.z = 0.0;
		  *(_QWORD *)&v321.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  *(_QWORD *)&v320.x = v167;
		  v320.z = v168;
		  v175 = (float)(1.0 - fabs(UnityEngine::Vector3::Dot(&v320, &v321, v174))) * this->fields.waterCameraPositionOffset;
		  *(_QWORD *)&v320.x = v167;
		  v320.z = v168;
		  v177 = UnityEngine::Vector3::op_Multiply(&v321, &v320, v175, v176);
		  v178 = *(_QWORD *)&cameraPosition->x;
		  v179 = *(_QWORD *)&v177->x;
		  v320.z = v177->z;
		  v321.z = cameraPosition->z;
		  *(_QWORD *)&v320.x = v179;
		  *(_QWORD *)&v321.x = v178;
		  v181 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v329, &v321, &v320, v180);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v182 = *(_QWORD *)&v181->x;
		  v183 = v181->z;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_93:
		    sub_1800D8260(v12, wrapperArray);
		  if ( wrapperArray->max_length.size <= 401 )
		    goto LABEL_66;
		  if ( !v12->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v12);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size <= 0x191u )
		    goto LABEL_232;
		  if ( wrapperArray[11].vector[5] )
		  {
		    v292 = IFix::WrappersManagerImpl::GetPatch(401, 0LL);
		    if ( !v292 )
		      goto LABEL_93;
		    *(_QWORD *)&v320.x = v182;
		    v320.z = v183;
		    v293 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_192(&v324, v292, &v320, &v323, 0LL);
		    v192 = *(_OWORD *)&v293->m00;
		    v193 = *(_OWORD *)&v293->m01;
		    v194 = *(_OWORD *)&v293->m02;
		    v195 = *(_OWORD *)&v293->m03;
		  }
		  else
		  {
		LABEL_66:
		    *(_QWORD *)&v320.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    v320.z = -1.0;
		    v184 = UnityEngine::Matrix4x4::Scale(&v324, &v320, 0LL);
		    v185 = *(_OWORD *)&v184->m00;
		    v186 = *(_OWORD *)&v184->m01;
		    v187 = *(_OWORD *)&v184->m02;
		    v188 = *(_OWORD *)&v184->m03;
		    v189 = (void (__fastcall *)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *))qword_18F36FA58;
		    *(_QWORD *)&v320.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    v320.z = 1.0;
		    *(_QWORD *)&v321.x = v182;
		    v321.z = v183;
		    memset(&v319, 0, sizeof(v319));
		    if ( !qword_18F36FA58 )
		    {
		      v189 = (void (__fastcall *)(Vector3 *, Quaternion *, Vector3 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                     "UnityEngine.Matrix4x4::TRS_Injected"
		                                                                                     "(UnityEngine.Vector3&,UnityEngine.Q"
		                                                                                     "uaternion&,UnityEngine.Vector3&,Uni"
		                                                                                     "tyEngine.Matrix4x4&)");
		      if ( !v189 )
		      {
		        v294 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v294, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v189;
		    }
		    v189(&v321, &v323, &v320, &v319);
		    v190 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		    v324 = v319;
		    memset(&v322, 0, sizeof(v322));
		    if ( !qword_18F36FA60 )
		    {
		      v190 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
		                                                              "4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v190 )
		      {
		        v295 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v295, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v190;
		    }
		    v190(&v324, &v322);
		    v191 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		    *(_OWORD *)&v328.m00 = v185;
		    v326 = v322;
		    *(_OWORD *)&v328.m01 = v186;
		    *(_OWORD *)&v328.m02 = v187;
		    *(_OWORD *)&v328.m03 = v188;
		    memset(&v319, 0, sizeof(v319));
		    if ( !qword_18F36FA50 )
		    {
		      v191 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                           "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fas"
		                                                                           "t_Injected(UnityEngine.Matrix4x4&,UnityEngine"
		                                                                           ".Matrix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v191 )
		      {
		        v296 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v296, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v191;
		    }
		    v191(&v328, &v326, &v319);
		    v192 = *(_OWORD *)&v319.m00;
		    v193 = *(_OWORD *)&v319.m01;
		    v194 = *(_OWORD *)&v319.m02;
		    v195 = *(_OWORD *)&v319.m03;
		  }
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size > 765 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v12->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_93;
		    if ( wrapperArray->max_length.size <= 0x2FDu )
		      goto LABEL_232;
		    if ( wrapperArray[21].vector[9] )
		    {
		      v297 = IFix::WrappersManagerImpl::GetPatch(765, 0LL);
		      if ( !v297 )
		        goto LABEL_93;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v297, (Object *)this, 0LL);
		    }
		  }
		  v196 = this->fields.camera;
		  if ( !v196 )
		    goto LABEL_93;
		  v197 = (void (__fastcall *)(Camera *))qword_18F36F0B0;
		  if ( !qword_18F36F0B0 )
		  {
		    v197 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_nearClipPlane()");
		    if ( !v197 )
		    {
		      v298 = sub_1802EE1B8("UnityEngine.Camera::get_nearClipPlane()");
		      sub_18007E1B0(v298, 0LL);
		    }
		    qword_18F36F0B0 = (__int64)v197;
		  }
		  v197(v196);
		  v198 = this->fields.camera;
		  if ( !v198 )
		    goto LABEL_93;
		  v199 = (void (__fastcall *)(Camera *))qword_18F36F0C0;
		  if ( !qword_18F36F0C0 )
		  {
		    v199 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		    if ( !v199 )
		    {
		      v299 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		      sub_18007E1B0(v299, 0LL);
		    }
		    qword_18F36F0C0 = (__int64)v199;
		  }
		  memset(&v327, 0, sizeof(v327));
		  v199(v198);
		  v200 = (void (__fastcall *)(Matrix4x4 *))qword_18F36FA78;
		  if ( !qword_18F36FA78 )
		  {
		    v200 = (void (__fastcall *)(Matrix4x4 *))il2cpp_resolve_icall_1(
		                                               "UnityEngine.Matrix4x4::Perspective_Injected(System.Single,System.Single,S"
		                                               "ystem.Single,System.Single,UnityEngine.Matrix4x4&)");
		    if ( !v200 )
		    {
		      v300 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::Perspective_Injected(System.Single,System.Single,System.Single,System.Single,Unity"
		               "Engine.Matrix4x4&)");
		      sub_18007E1B0(v300, 0LL);
		    }
		    qword_18F36FA78 = (__int64)v200;
		  }
		  v200(&v327);
		  v202 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))qword_18F36F3B8;
		  v203 = *(_OWORD *)&v327.m00;
		  v324 = v327;
		  memset(&v319, 0, sizeof(v319));
		  if ( !qword_18F36F3B8 )
		  {
		    v202 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.GL::GetGPUProjectionMatrix_Injected(Uni"
		                                                                     "tyEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		    if ( !v202 )
		    {
		      v301 = sub_1802EE1B8(
		               "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v301, 0LL);
		    }
		    qword_18F36F3B8 = (__int64)v202;
		  }
		  LOBYTE(v201) = 1;
		  v202(&v324, v201, &v319);
		  m00 = v319.m00;
		  v205 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  *(_OWORD *)&v326.m00 = v192;
		  v334 = v319;
		  v328 = v319;
		  *(_OWORD *)&v326.m01 = v193;
		  *(_OWORD *)&v326.m02 = v194;
		  *(_OWORD *)&v326.m03 = v195;
		  v206 = *(__m128 *)&v319.m01;
		  v207 = *(__m128 *)&v319.m02;
		  v208 = *(__m128 *)&v319.m03;
		  memset(&v322, 0, sizeof(v322));
		  if ( !qword_18F36FA50 )
		  {
		    v205 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v205 )
		    {
		      v302 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v302, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v205;
		  }
		  v205(&v328, &v326, &v322);
		  v209 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		  *(_OWORD *)&v324.m00 = v192;
		  *(_OWORD *)&v324.m01 = v193;
		  *(_OWORD *)&v324.m02 = v194;
		  *(_OWORD *)&v324.m03 = v195;
		  v210 = *(_OWORD *)&v322.m01;
		  *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m00 = *(_OWORD *)&v322.m00;
		  v211 = *(_OWORD *)&v322.m02;
		  *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m01 = v210;
		  v212 = *(_OWORD *)&v322.m03;
		  *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m02 = v211;
		  memset(&v319, 0, sizeof(v319));
		  *(_OWORD *)&viewConstants->widerFoVViewProjMatrix.m03 = v212;
		  if ( !v209 )
		  {
		    v209 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
		                                                            "4&,UnityEngine.Matrix4x4&)");
		    if ( !v209 )
		    {
		      v303 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v303, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v209;
		  }
		  v209(&v324, &v319);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_93;
		  if ( wrapperArray->max_length.size > 772 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v12 = (struct ILFixDynamicMethodWrapper_2__Class *)v12->static_fields->wrapperArray;
		    if ( !v12 )
		      goto LABEL_93;
		    if ( LODWORD(v12->_0.namespaze) > 0x304 )
		    {
		      if ( !v12[16].rgctx_data )
		        goto LABEL_88;
		      v304 = IFix::WrappersManagerImpl::GetPatch(772, 0LL);
		      if ( v304 )
		      {
		        v305 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_300(&P0, v304, &v334, 0LL);
		        v224 = *(_OWORD *)&v305->m00;
		        v225 = *(__m128 *)&v305->m01;
		        v226 = *(__m128 *)&v305->m02;
		        v223 = *(__m128 *)&v305->m03;
		        goto LABEL_89;
		      }
		      goto LABEL_93;
		    }
		LABEL_232:
		    sub_1800D2AB0(v12, wrapperArray);
		  }
		LABEL_88:
		  v213 = _mm_shuffle_ps(v206, v206, 85).m128_f32[0];
		  v214 = _mm_shuffle_ps(v208, v208, 170).m128_f32[0];
		  v215 = _mm_shuffle_ps(v207, v207, 85).m128_f32[0] / v213;
		  *(_QWORD *)&v325.m30 = 0LL;
		  v325.m23 = -1.0;
		  memset(&v325.m21, 0, 20);
		  *(_QWORD *)&v325.m10 = 0LL;
		  v216 = *(__m128 *)&v325.m03;
		  v217 = 1.0 / v214;
		  v216.m128_f32[0] = v207.m128_f32[0] / m00;
		  v218 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v325.m01, (__m128)*(unsigned __int64 *)&v325.m01, 225);
		  v219 = _mm_shuffle_ps(v216, v216, 225);
		  v218.m128_f32[0] = 1.0 / v213;
		  v220 = _mm_shuffle_ps(v207, v207, 170).m128_f32[0] / v214;
		  v224 = LODWORD(v325.m00);
		  v219.m128_f32[0] = v215;
		  v221 = _mm_shuffle_ps(v219, v219, 135);
		  v222 = _mm_shuffle_ps(*(__m128 *)&v325.m02, *(__m128 *)&v325.m02, 147);
		  v221.m128_f32[0] = v220;
		  v222.m128_f32[0] = v217;
		  v223 = _mm_shuffle_ps(v221, v221, 57);
		  *(float *)&v224 = 1.0 / m00;
		  v225 = _mm_shuffle_ps(v218, v218, 225);
		  v226 = _mm_shuffle_ps(v222, v222, 57);
		LABEL_89:
		  v227 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  *(_OWORD *)&v326.m00 = v224;
		  v328 = v319;
		  *(__m128 *)&v326.m01 = v225;
		  *(__m128 *)&v326.m02 = v226;
		  *(__m128 *)&v326.m03 = v223;
		  memset(&v322, 0, sizeof(v322));
		  if ( !qword_18F36FA50 )
		  {
		    v227 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v227 )
		    {
		      v306 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v306, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v227;
		  }
		  v227(&v328, &v326, &v322);
		  v228 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		  *(_OWORD *)&v334.m00 = v203;
		  *(_OWORD *)&v324.m00 = v192;
		  *(_OWORD *)&v324.m01 = v193;
		  *(_OWORD *)&v324.m02 = v194;
		  *(_OWORD *)&v324.m03 = v195;
		  v229 = *(_OWORD *)&v322.m01;
		  *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m00 = *(_OWORD *)&v322.m00;
		  v230 = *(_OWORD *)&v322.m02;
		  *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m01 = v229;
		  v231 = *(_OWORD *)&v322.m03;
		  *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m02 = v230;
		  v232 = *(_OWORD *)&v327.m01;
		  *(_OWORD *)&viewConstants->widerFoVInvViewProjMatrix.m03 = v231;
		  *(_OWORD *)&v334.m01 = v232;
		  *(_OWORD *)&v334.m02 = *(_OWORD *)&v327.m02;
		  *(_OWORD *)&v334.m03 = *(_OWORD *)&v327.m03;
		  memset(&v319, 0, sizeof(v319));
		  if ( !v228 )
		  {
		    v228 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		    if ( !v228 )
		    {
		      v307 = sub_1802EE1B8(
		               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
		               "tyEngine.Matrix4x4&)");
		      sub_18007E1B0(v307, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v228;
		  }
		  v228(&v334, &v324, &v319);
		  v233 = *(_OWORD *)&v319.m01;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m00 = *(_OWORD *)&v319.m00;
		  v234 = *(_OWORD *)&v319.m02;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m01 = v233;
		  v235 = *(_OWORD *)&v319.m03;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m02 = v234;
		  *(_OWORD *)&this->fields.waterCullingMatrix.m03 = v235;
		}
		
		private void UpdateFrustum([IsReadOnly] in ViewConstants viewConstants) {} // 0x0000000183252130-0x00000001832527E0
		// Void UpdateFrustum(HGCamera+ViewConstants ByRef)
		void HG::Rendering::Runtime::HGCamera::UpdateFrustum(
		        HGCamera *this,
		        HGCamera_ViewConstants *viewConstants,
		        MethodInfo *method)
		{
		  void *planes; // rcx
		  Vector4__Array *frustumPlaneEquations; // rdx
		  Camera *camera; // rbx
		  __int128 v8; // xmm1
		  __int128 v9; // xmm1
		  __m128 v10; // xmm6
		  __m128 v11; // xmm8
		  __m128 v12; // xmm7
		  __m128 v13; // xmm12
		  __int128 v14; // xmm13
		  __int128 v15; // xmm14
		  __int128 v16; // xmm15
		  double (__fastcall *v17)(Camera *, Vector4__Array *, MethodInfo *); // rax
		  double v18; // xmm0_8
		  Camera *v19; // rbx
		  float v20; // xmm10_4
		  double (__fastcall *v21)(Camera *); // rax
		  double v22; // xmm0_8
		  float v23; // xmm9_4
		  bool v24; // al
		  float v25; // xmm2_4
		  __m128 v26; // xmm0
		  __m128 v27; // xmm0
		  __m128 v28; // xmm0
		  int v29; // r14d
		  int v30; // eax
		  __m128 v31; // xmm0
		  __m128 v32; // xmm0
		  __m128 v33; // xmm0
		  __m128 v34; // xmm0
		  Vector4 v35; // xmm0
		  Camera *v36; // rbx
		  unsigned __int8 (__fastcall *v37)(Camera *); // rax
		  float v38; // xmm7_4
		  Camera *v39; // rbx
		  double (__fastcall *v40)(Camera *); // rax
		  double v41; // xmm0_8
		  Camera *v42; // rbx
		  __int64 (__fastcall *v43)(Camera *); // rax
		  char v44; // al
		  int v45; // ebx
		  __m128 v46; // xmm1
		  __m128 v47; // xmm1
		  __m128 v48; // xmm1
		  Vector4 v49; // xmm1
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  MethodInfo *v54; // r8
		  __int64 v55; // rdx
		  __int64 v56; // r8
		  Vector4 v57; // xmm6
		  struct Math__Class *v58; // rcx
		  __m128 v59; // xmm7
		  float v60; // xmm8_4
		  __m128d v61; // xmm2
		  double v62; // xmm0_8
		  float v63; // xmm0_4
		  float v64; // xmm8_4
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  Vector4 v68; // xmm3
		  float v69; // r8d
		  float v70; // xmm2_4
		  __int64 v71; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v73; // rax
		  __int64 v74; // rax
		  __m128 v75; // xmm4
		  __m128 v76; // xmm4
		  __m128 v77; // xmm4
		  __m128 v78; // xmm4
		  __int64 v79; // rax
		  float orthographicSize; // xmm0_4
		  __int64 v81; // rax
		  __int64 v82; // rax
		  __m128 v83; // [rsp+40h] [rbp-C0h] BYREF
		  Vector4 v84; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 v85; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 v86; // [rsp+70h] [rbp-90h] BYREF
		  Matrix4x4 v87; // [rsp+80h] [rbp-80h] BYREF
		  __int128 v88; // [rsp+C0h] [rbp-40h]
		
		  planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  frustumPlaneEquations = (Vector4__Array *)**((_QWORD **)planes + 23);
		  if ( !frustumPlaneEquations )
		    goto LABEL_38;
		  if ( frustumPlaneEquations->max_length.size <= 777 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)planes + 56) )
		  {
		    il2cpp_runtime_class_init_1(planes);
		    planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  frustumPlaneEquations = (Vector4__Array *)**((_QWORD **)planes + 23);
		  if ( !frustumPlaneEquations )
		    goto LABEL_38;
		  if ( frustumPlaneEquations->max_length.size <= 0x309u )
		LABEL_41:
		    sub_1800D2AB0(planes, frustumPlaneEquations);
		  if ( !*(_QWORD *)&frustumPlaneEquations[11].vector[14].z )
		  {
		LABEL_5:
		    camera = this->fields.camera;
		    v8 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m01;
		    *(_OWORD *)&v87.m00 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m00;
		    *(_OWORD *)&v87.m01 = v8;
		    v9 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m03;
		    *(_OWORD *)&v87.m02 = *(_OWORD *)&this->fields.mainViewConstants.projMatrix.m02;
		    *(_OWORD *)&v87.m03 = v9;
		    v10 = *(__m128 *)&this->fields.mainViewConstants.invProjMatrix.m00;
		    v11 = *(__m128 *)&this->fields.mainViewConstants.invProjMatrix.m01;
		    v12 = *(__m128 *)&this->fields.mainViewConstants.invProjMatrix.m02;
		    v13 = *(__m128 *)&this->fields.mainViewConstants.invProjMatrix.m03;
		    v14 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m00;
		    v15 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m01;
		    v16 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m02;
		    v88 = *(_OWORD *)&this->fields.mainViewConstants.viewProjMatrix.m03;
		    if ( camera )
		    {
		      v17 = (double (__fastcall *)(Camera *, Vector4__Array *, MethodInfo *))qword_18F36F0B0;
		      if ( !qword_18F36F0B0 )
		      {
		        v17 = (double (__fastcall *)(Camera *, Vector4__Array *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                 "UnityEngine.Camera::get_nearClipPlane()");
		        if ( !v17 )
		        {
		          v73 = sub_1802EE1B8("UnityEngine.Camera::get_nearClipPlane()");
		          sub_18007E1B0(v73, 0LL);
		        }
		        qword_18F36F0B0 = (__int64)v17;
		      }
		      v18 = v17(camera, frustumPlaneEquations, method);
		      v19 = this->fields.camera;
		      v20 = *(float *)&v18;
		      if ( v19 )
		      {
		        v21 = (double (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v21 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		          if ( !v21 )
		          {
		            v74 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		            sub_18007E1B0(v74, 0LL);
		          }
		          qword_18F36F0C0 = (__int64)v21;
		        }
		        v22 = v21(v19);
		        v23 = *(float *)&v22;
		        *(float *)&v22 = UnityEngine::Matrix4x4::get_Item(&v87, 14, 0LL);
		        v24 = (float)((float)((float)((float)((float)(_mm_shuffle_ps(v10, v10, 85).m128_f32[0] * 0.0)
		                                            + _mm_shuffle_ps(v11, v11, 85).m128_f32[0])
		                                    + (float)(_mm_shuffle_ps(v12, v12, 85).m128_f32[0] * 0.0))
		                            + _mm_shuffle_ps(v13, v13, 85).m128_f32[0])
		                    * (float)(1.0
		                            / (float)((float)((float)((float)(_mm_shuffle_ps(v10, v10, 255).m128_f32[0] * 0.0)
		                                                    + _mm_shuffle_ps(v11, v11, 255).m128_f32[0])
		                                            + (float)(_mm_shuffle_ps(v12, v12, 255).m128_f32[0] * 0.0))
		                                    + _mm_shuffle_ps(v13, v13, 255).m128_f32[0]))) < 0.0;
		        v25 = 1.0 / v20;
		        if ( (float)((float)(*(float *)&v22 / (float)(v23 * v20)) * (float)(v23 - v20)) <= 0.0 )
		        {
		          v75 = (__m128)0x3F800000u;
		          v75.m128_f32[0] = 1.0 - (float)(v23 / v20);
		          v76 = _mm_shuffle_ps(v75, v75, 225);
		          v76.m128_f32[0] = v23 / v20;
		          v77 = _mm_shuffle_ps(v76, v76, 198);
		          v77.m128_f32[0] = (float)(1.0 / v23) - (float)(1.0 / v20);
		          v78 = _mm_shuffle_ps(v77, v77, 39);
		          v78.m128_f32[0] = v25;
		          v83 = _mm_shuffle_ps(v78, v78, 57);
		          this->fields.zBufferParams = (Vector4)v83;
		        }
		        else
		        {
		          v84.y = 1.0;
		          v26 = (__m128)v84;
		          v26.m128_f32[0] = (float)(v23 / v20) - 1.0;
		          v27 = _mm_shuffle_ps(v26, v26, 210);
		          v27.m128_f32[0] = v25 + (float)(-1.0 / v23);
		          v28 = _mm_shuffle_ps(v27, v27, 39);
		          v28.m128_f32[0] = 1.0 / v23;
		          v84 = (Vector4)_mm_shuffle_ps(v28, v28, 57);
		          this->fields.zBufferParams = v84;
		        }
		        v29 = 1;
		        v30 = v24 ? -1 : 1;
		        v31 = 0LL;
		        v31.m128_f32[0] = (float)v30;
		        v32 = _mm_shuffle_ps(v31, v31, 225);
		        v32.m128_f32[0] = v20;
		        v33 = _mm_shuffle_ps(v32, v32, 198);
		        v33.m128_f32[0] = v23;
		        v34 = _mm_shuffle_ps(v33, v33, 39);
		        v34.m128_f32[0] = 1.0 / v23;
		        v35 = (Vector4)_mm_shuffle_ps(v34, v34, 57);
		        this->fields.projectionParams = v35;
		        v36 = this->fields.camera;
		        v83 = (__m128)v35;
		        if ( v36 )
		        {
		          v37 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		          if ( !qword_18F36F100 )
		          {
		            v37 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		            if ( !v37 )
		            {
		              v79 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		              sub_18007E1B0(v79, 0LL);
		            }
		            qword_18F36F100 = (__int64)v37;
		          }
		          if ( v37(v36) )
		          {
		            planes = this->fields.camera;
		            if ( !planes )
		              goto LABEL_38;
		            orthographicSize = UnityEngine::Camera::get_orthographicSize((Camera *)planes, 0LL);
		            v38 = orthographicSize + orthographicSize;
		          }
		          else
		          {
		            v38 = 0.0;
		          }
		          v39 = this->fields.camera;
		          if ( v39 )
		          {
		            v40 = (double (__fastcall *)(Camera *))qword_18F36F118;
		            if ( !qword_18F36F118 )
		            {
		              v40 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_aspect()");
		              if ( !v40 )
		              {
		                v81 = sub_1802EE1B8("UnityEngine.Camera::get_aspect()");
		                sub_18007E1B0(v81, 0LL);
		              }
		              qword_18F36F118 = (__int64)v40;
		            }
		            v41 = v40(v39);
		            v42 = this->fields.camera;
		            if ( v42 )
		            {
		              v43 = (__int64 (__fastcall *)(Camera *))qword_18F36F100;
		              if ( !qword_18F36F100 )
		              {
		                v43 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		                if ( !v43 )
		                {
		                  v82 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		                  sub_18007E1B0(v82, 0LL);
		                }
		                qword_18F36F100 = (__int64)v43;
		              }
		              v44 = v43(v42);
		              v45 = 0;
		              if ( !v44 )
		                v29 = 0;
		              v84.z = 0.0;
		              v46 = (__m128)v84;
		              v46.m128_f32[0] = *(float *)&v41 * v38;
		              v47 = _mm_shuffle_ps(v46, v46, 225);
		              v47.m128_f32[0] = v38;
		              v48 = _mm_shuffle_ps(v47, v47, 135);
		              v48.m128_f32[0] = (float)v29;
		              v49 = (Vector4)_mm_shuffle_ps(v48, v48, 57);
		              this->fields.unity_OrthoParams = v49;
		              v50 = *(_OWORD *)&viewConstants->invViewMatrix.m00;
		              v84 = v49;
		              v51 = *(_OWORD *)&viewConstants->invViewMatrix.m01;
		              *(_OWORD *)&v87.m00 = v50;
		              v52 = *(_OWORD *)&viewConstants->invViewMatrix.m02;
		              *(_OWORD *)&v87.m01 = v51;
		              v53 = *(_OWORD *)&viewConstants->invViewMatrix.m03;
		              *(_OWORD *)&v87.m02 = v52;
		              *(_OWORD *)&v87.m03 = v53;
		              v83 = *(__m128 *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v83, &v87, 2, 0LL);
		              v57 = *UnityEngine::Vector4::op_UnaryNegation(&v84, (Vector4 *)&v83, v54);
		              v58 = TypeInfo::System::Math;
		              if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		              v59 = _mm_shuffle_ps((__m128)v57, (__m128)v57, 85);
		              v61 = 0LL;
		              v60 = _mm_shuffle_ps((__m128)v57, (__m128)v57, 170).m128_f32[0];
		              v61.m128d_f64[0] = (float)((float)((float)(v59.m128_f32[0] * v59.m128_f32[0]) + (float)(v57.x * v57.x))
		                                       + (float)(v60 * v60));
		              if ( v61.m128d_f64[0] < 0.0 )
		                v62 = sub_1801D32D0(v58, v55, v56);
		              else
		                *(_QWORD *)&v62 = *(_OWORD *)&_mm_sqrt_pd(v61);
		              v63 = v62;
		              if ( v63 <= 0.0000099999997 )
		              {
		                v57 = 0LL;
		                v59 = 0LL;
		                v64 = 0.0;
		              }
		              else
		              {
		                v57.x = v57.x / v63;
		                v59.m128_f32[0] = v59.m128_f32[0] / v63;
		                v64 = v60 / v63;
		              }
		              v65 = *(_OWORD *)&viewConstants->invViewMatrix.m01;
		              *(_OWORD *)&v87.m00 = *(_OWORD *)&viewConstants->invViewMatrix.m00;
		              v66 = *(_OWORD *)&viewConstants->invViewMatrix.m02;
		              *(_OWORD *)&v87.m01 = v65;
		              v67 = *(_OWORD *)&viewConstants->invViewMatrix.m03;
		              *(_OWORD *)&v87.m02 = v66;
		              *(_OWORD *)&v87.m03 = v67;
		              v68 = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v83, &v87, 3, 0LL);
		              *(_QWORD *)&v86.x = _mm_unpacklo_ps((__m128)v68, _mm_shuffle_ps((__m128)v68, (__m128)v68, 85)).m128_u64[0];
		              *(_OWORD *)&v87.m03 = v88;
		              v85.z = v64;
		              LODWORD(v86.z) = _mm_shuffle_ps((__m128)v68, (__m128)v68, 170).m128_u32[0];
		              *(_QWORD *)&v85.x = _mm_unpacklo_ps((__m128)v57, v59).m128_u64[0];
		              *(_OWORD *)&v87.m00 = v14;
		              *(_OWORD *)&v87.m01 = v15;
		              *(_OWORD *)&v87.m02 = v16;
		              HG::Rendering::Runtime::Frustum::Create(&this->fields.frustum, &v87, &v86, &v85, v20, v23, 0LL);
		              while ( 1 )
		              {
		                planes = this->fields.frustum.planes;
		                frustumPlaneEquations = this->fields.frustumPlaneEquations;
		                if ( !planes )
		                  break;
		                if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
		                  goto LABEL_41;
		                *(_QWORD *)&v86.x = *((_QWORD *)planes + 2 * v45 + 4);
		                if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
		                  goto LABEL_41;
		                *(_QWORD *)&v85.x = *((_QWORD *)planes + 2 * v45 + 4);
		                if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
		                  goto LABEL_41;
		                v69 = *((float *)planes + 4 * v45 + 10);
		                v70 = *((float *)planes + 4 * v45 + 11);
		                if ( !frustumPlaneEquations )
		                  break;
		                v83.m128_i32[0] = LODWORD(v86.x);
		                v83.m128_i32[1] = LODWORD(v85.y);
		                v83.m128_f32[3] = v70;
		                v83.m128_f32[2] = v69;
		                if ( (unsigned int)v45 >= frustumPlaneEquations->max_length.size )
		                  goto LABEL_41;
		                v71 = v45++;
		                frustumPlaneEquations->vector[v71] = (Vector4)v83;
		                if ( v45 >= 6 )
		                  return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_38:
		    sub_1800D8260(planes, frustumPlaneEquations);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(777, 0LL);
		  if ( !Patch )
		    goto LABEL_38;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_306(Patch, (Object *)this, viewConstants, 0LL);
		}
		
		internal static int GetSceneViewLayerMaskFallback() => default; // 0x0000000189B73164-0x0000000189B731A8
		// Int32 GetSceneViewLayerMaskFallback()
		int32_t HG::Rendering::Runtime::HGCamera::GetSceneViewLayerMaskFallback(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(719, 0LL) )
		    return -1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(719, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		private void UpdateVolumeAndPhysicalParameters() {} // 0x00000001834503D0-0x0000000183450900
		// Void UpdateVolumeAndPhysicalParameters()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCamera::UpdateVolumeAndPhysicalParameters(HGCamera *this, MethodInfo *method)
		{
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  HGAdditionalCameraData *m_AdditionalCameraData; // rdi
		  struct Object_1__Class *v15; // rcx
		  HGAdditionalCameraData *v16; // rdi
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  void *v19; // rdi
		  Object_1 *main; // rdi
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Type *v23; // rdx
		  __int64 v24; // rcx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Object *v27; // rdi
		  __int64 v28; // rcx
		  __int128 v29; // xmm1
		  float v30; // eax
		  HGPhysicalCamera *Defaults; // rax
		  __int128 v32; // xmm1
		  float m_Anamorphism; // ecx
		  Transform *volumeAnchor; // rdi
		  struct Object_1__Class *v35; // rcx
		  Camera *camera; // rdi
		  __int64 (__fastcall *v37)(Camera *); // rax
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  __int64 v41; // rdx
		  struct VolumeManager__Class *v42; // rax
		  Lazy_1_Object_ *s_Instance; // rcx
		  Object *Value; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // rdx
		  HGCamera *LightWeightCamera; // rbx
		  struct VolumeManager__Class *v49; // rax
		  Lazy_1_Object_ *v50; // rcx
		  Object *v51; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  __int64 v54; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-68h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-68h]
		  Il2CppExceptionWrapper *v57; // [rsp+30h] [rbp-58h] BYREF
		  Il2CppException *ex; // [rsp+38h] [rbp-50h]
		  char *v59; // [rsp+40h] [rbp-48h]
		  HGPhysicalCamera v60; // [rsp+48h] [rbp-40h] BYREF
		  char v61; // [rsp+A0h] [rbp+18h] BYREF
		  Object *component; // [rsp+A8h] [rbp+20h] BYREF
		
		  component = 0LL;
		  v61 = 0;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, method);
		  if ( wrapperArray->max_length.size > 717 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v7 = v5->static_fields->wrapperArray;
		    if ( !v7 )
		      sub_1800D8260(v5, method);
		    if ( v7->max_length.size <= 0x2CDu )
		      sub_1800D2AB0(v5, method);
		    if ( v7[20].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(717, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v10, v9);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		  }
		  this->fields.volumeAnchor = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.volumeAnchor, (Type *)method, v2, v3, methoda);
		  this->fields.volumeLayerMask = -1;
		  m_AdditionalCameraData = this->fields.m_AdditionalCameraData;
		  v15 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v15 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v15 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_AdditionalCameraData )
		    goto LABEL_23;
		  if ( !v15->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v15);
		  if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		  {
		    v16 = this->fields.m_AdditionalCameraData;
		    if ( !v16 )
		      sub_1800D8260(v15, v11);
		    this->fields.volumeLayerMask = v16->fields.volumeLayerMask.m_Mask;
		    this->fields.volumeAnchor = v16->fields.volumeAnchorOverride;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.volumeAnchor, v11, v12, v13, methodb);
		    v19 = this->fields.m_AdditionalCameraData;
		    if ( !v19 )
		      sub_1800D8260(v18, v17);
		  }
		  else
		  {
		LABEL_23:
		    if ( !this->fields.camera )
		      sub_1800D8260(v15, v11);
		    if ( UnityEngine::Camera::get_cameraType(this->fields.camera, 0LL) != CameraType__Enum_SceneView )
		      goto LABEL_36;
		    main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(main, 0LL, 0LL) )
		      goto LABEL_87;
		    if ( !main )
		      sub_1800D8260(v22, v21);
		    if ( !UnityEngine::Component::TryGetComponent<System::Object>(
		            (Component *)main,
		            &component,
		            MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
		    {
		LABEL_87:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      this->fields.volumeLayerMask = HG::Rendering::Runtime::HGCamera::GetSceneViewLayerMaskFallback(0LL);
		      Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(&v60, 0LL);
		      v32 = *(_OWORD *)&Defaults->m_BladeCount;
		      m_Anamorphism = Defaults->m_Anamorphism;
		      *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&Defaults->m_Iso;
		      *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_BladeCount = v32;
		      this->fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
		      goto LABEL_36;
		    }
		    v27 = component;
		    if ( !component )
		      sub_1800D8260(v24, v23);
		    this->fields.volumeLayerMask = (int32_t)component[3].monitor;
		    this->fields.volumeAnchor = (Transform *)v27[4].klass;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.volumeAnchor, v23, v25, v26, methodb);
		    v19 = component;
		    if ( !component )
		      sub_1800D8260(v28, v17);
		  }
		  v29 = *((_OWORD *)v19 + 6);
		  v30 = *((float *)v19 + 28);
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_Iso = *((_OWORD *)v19 + 5);
		  *(_OWORD *)&this->fields._physicalParameters_k__BackingField.m_BladeCount = v29;
		  this->fields._physicalParameters_k__BackingField.m_Anamorphism = v30;
		LABEL_36:
		  volumeAnchor = this->fields.volumeAnchor;
		  v35 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v35 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v35 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !volumeAnchor )
		    goto LABEL_43;
		  if ( !v35->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v35);
		  if ( !volumeAnchor->fields._._.m_CachedPtr )
		  {
		LABEL_43:
		    camera = this->fields.camera;
		    if ( !camera )
		      sub_1800D8260(v35, v17);
		    v37 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v37 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v37 )
		      {
		        v54 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v54, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v37;
		    }
		    this->fields.volumeAnchor = (Transform *)v37(camera);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.volumeAnchor, v38, v39, v40, methodb);
		  }
		  UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		    (Int32Enum__Enum)0x93u,
		    MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  ex = 0LL;
		  v59 = &v61;
		  try
		  {
		    v42 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		    if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		      v42 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		      if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		        v42 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		      }
		    }
		    s_Instance = (Lazy_1_Object_ *)v42->static_fields->s_Instance;
		    if ( !s_Instance )
		      sub_1800D8250(0LL, v41);
		    Value = System::Lazy<System::Object>::get_Value(
		              s_Instance,
		              MethodInfo::System::Lazy<UnityEngine::Rendering::VolumeManager>::get_Value);
		    if ( !Value )
		      sub_1800D8250(v46, v45);
		    UnityEngine::Rendering::VolumeManager::Update(
		      (VolumeManager *)Value,
		      this->fields._volumeStack_k__BackingField,
		      this->fields.volumeAnchor,
		      (LayerMask)this->fields.volumeLayerMask,
		      0LL);
		    LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
		    if ( LightWeightCamera )
		    {
		      v49 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		      if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		        v49 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		        if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		          v49 = TypeInfo::UnityEngine::Rendering::VolumeManager;
		        }
		      }
		      v50 = (Lazy_1_Object_ *)v49->static_fields->s_Instance;
		      if ( !v50 )
		        sub_1800D8250(0LL, v47);
		      v51 = System::Lazy<System::Object>::get_Value(
		              v50,
		              MethodInfo::System::Lazy<UnityEngine::Rendering::VolumeManager>::get_Value);
		      if ( !v51 )
		        sub_1800D8250(v53, v52);
		      UnityEngine::Rendering::VolumeManager::Update(
		        (VolumeManager *)v51,
		        LightWeightCamera->fields._volumeStack_k__BackingField,
		        LightWeightCamera->fields.volumeAnchor,
		        (LayerMask)LightWeightCamera->fields.volumeLayerMask,
		        0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v57 )
		  {
		    ex = v57->ex;
		    if ( ex )
		      sub_18007E1E0(ex);
		  }
		}
		
		internal Matrix4x4 GetJitteredProjectionMatrix(Matrix4x4 origProj, HGRenderPipeline hgrp) => default; // 0x000000018326B8B0-0x000000018326BDB0
		// Matrix4x4 GetJitteredProjectionMatrix(Matrix4x4, HGRenderPipeline)
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::GetJitteredProjectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCamera *this,
		        Matrix4x4 *origProj,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  __m128 v5; // xmm0
		  Camera *planes; // rcx
		  __int64 v11; // rdx
		  Vector3Int *v12; // r8
		  ITilemap *v13; // r9
		  HGSettingParameters *settingParameters_k__BackingField; // rbx
		  float RenderingScale; // xmm0_4
		  float v16; // xmm9_4
		  int32_t m_antialiasingMode; // eax
		  float v18; // xmm6_4
		  int v19; // eax
		  __m128 v20; // xmm7
		  float v21; // xmm1_4
		  int v22; // edx
		  float v23; // xmm0_4
		  float v24; // xmm1_4
		  int v25; // r8d
		  float v26; // xmm0_4
		  float v27; // xmm0_4
		  float v28; // xmm6_4
		  Camera *camera; // rbx
		  __m128 v30; // xmm0
		  __m128 v31; // xmm0
		  __m128 v32; // xmm0
		  unsigned __int8 (__fastcall *v33)(Camera *); // rax
		  void (__fastcall *v34)(Matrix4x4 *, __m128 *); // rax
		  struct Math__Class *v35; // rcx
		  bool v36; // zf
		  __int64 v37; // r8
		  void (__fastcall *v38)(Matrix4x4 *, __int64, __int64); // rax
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  __int128 v41; // xmm2
		  __int128 v42; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  Matrix4x4 *v48; // rax
		  __int128 v49; // xmm1
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  ILFixDynamicMethodWrapper_2 *v52; // rax
		  ILFixDynamicMethodWrapper_2 *v53; // rax
		  int v54; // ebx
		  __int64 v55; // rax
		  __int64 v56; // rax
		  __int64 v57; // rax
		  float orthographicSize; // xmm0_4
		  float v59; // xmm11_4
		  float aspect; // xmm0_4
		  float v61; // xmm10_4
		  float v62; // xmm0_4
		  float v63; // xmm1_4
		  float v64; // xmm7_4
		  float v65; // xmm0_4
		  float v66; // xmm8_4
		  float farClipPlane; // xmm0_4
		  Matrix4x4 *v68; // rax
		  Vector4 v69; // xmm1
		  __int128 v70; // xmm0
		  MethodInfo *v71; // [rsp+20h] [rbp-E0h]
		  __m128 taaJitter; // [rsp+40h] [rbp-C0h] BYREF
		  __int64 v73; // [rsp+50h] [rbp-B0h]
		  Matrix4x4 v74; // [rsp+60h] [rbp-A0h] BYREF
		  __m128 v75; // [rsp+A0h] [rbp-60h] BYREF
		  __int64 v76; // [rsp+B0h] [rbp-50h]
		  Matrix4x4 v77; // [rsp+B8h] [rbp-48h] BYREF
		
		  planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
		  if ( !v11 )
		    goto LABEL_36;
		  if ( *(int *)(v11 + 24) > 770 )
		  {
		    if ( !LODWORD(planes[9].monitor) )
		    {
		      *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(planes);
		      planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
		    if ( !v11 )
		      goto LABEL_36;
		    if ( *(_DWORD *)(v11 + 24) <= 0x302u )
		      goto LABEL_64;
		    if ( *(_QWORD *)(v11 + 6192) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(770, 0LL);
		      if ( !Patch )
		        goto LABEL_36;
		      v45 = *(_OWORD *)&origProj->m01;
		      *(_OWORD *)&v74.m00 = *(_OWORD *)&origProj->m00;
		      v46 = *(_OWORD *)&origProj->m02;
		      *(_OWORD *)&v74.m01 = v45;
		      v47 = *(_OWORD *)&origProj->m03;
		      *(_OWORD *)&v74.m02 = v46;
		      *(_OWORD *)&v74.m03 = v47;
		      v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_299(&v77, Patch, (Object *)this, &v74, (Object *)hgrp, 0LL);
		      v49 = *(_OWORD *)&v48->m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v48->m00;
		      v50 = *(_OWORD *)&v48->m02;
		      *(_OWORD *)&retstr->m01 = v49;
		      v51 = *(_OWORD *)&v48->m03;
		      *(_OWORD *)&retstr->m02 = v50;
		LABEL_79:
		      *(_OWORD *)&retstr->m03 = v51;
		      return retstr;
		    }
		  }
		  if ( UnityEngine::FrameDebugger::IsLocalEnabled(0LL) || UnityEngine::FrameDebugger::IsRemoteEnabled(0LL) )
		  {
		    v69 = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                      (TileAnimationData *)&taaJitter,
		                      (TileBase *)v11,
		                      v12,
		                      v13,
		                      v71);
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&origProj->m00;
		    v70 = *(_OWORD *)&origProj->m02;
		    this->fields.taaJitter = v69;
		    *(_OWORD *)&retstr->m01 = *(_OWORD *)&origProj->m01;
		    v51 = *(_OWORD *)&origProj->m03;
		    *(_OWORD *)&retstr->m02 = v70;
		    goto LABEL_79;
		  }
		  if ( !hgrp )
		    goto LABEL_36;
		  settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  RenderingScale = HG::Rendering::Runtime::HGUtils::GetRenderingScale(this, settingParameters_k__BackingField, 0LL);
		  planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v16 = 1.0 / RenderingScale;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
		  if ( !v11 )
		    goto LABEL_36;
		  if ( *(int *)(v11 + 24) > 738 )
		  {
		    if ( !LODWORD(planes[9].monitor) )
		    {
		      *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(planes);
		      planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
		    if ( !v11 )
		      goto LABEL_36;
		    if ( *(_DWORD *)(v11 + 24) <= 0x2E2u )
		      goto LABEL_64;
		    if ( *(_QWORD *)(v11 + 5936) )
		    {
		      v52 = IFix::WrappersManagerImpl::GetPatch(738, 0LL);
		      if ( !v52 )
		        goto LABEL_36;
		      if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v52, (Object *)this, 0LL) )
		        goto LABEL_20;
		LABEL_65:
		      v54 = this->fields.taaFrameIndex & 0x1F;
		      v5.m128_f32[0] = UnityEngine::Rendering::HaltonSequence::Get(v54 + 1, 2, 0LL);
		      v20 = v5;
		      v20.m128_f32[0] = v5.m128_f32[0] - 0.5;
		      v28 = 0.5 - UnityEngine::Rendering::HaltonSequence::Get(v54 + 1, 3, 0LL);
		      goto LABEL_25;
		    }
		  }
		  if ( !LODWORD(planes[9].monitor) )
		  {
		    *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(planes);
		    planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
		  if ( !v11 )
		    goto LABEL_36;
		  if ( *(int *)(v11 + 24) <= 732 )
		    goto LABEL_18;
		  if ( !LODWORD(planes[9].monitor) )
		  {
		    *(double *)v5.m128_u64 = il2cpp_runtime_class_init_1(planes);
		    planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  planes = *(Camera **)planes[7].fields._._._.m_CachedPtr;
		  if ( !planes )
		    goto LABEL_36;
		  if ( LODWORD(planes[1].klass) <= 0x2DC )
		LABEL_64:
		    sub_1800D2AB0(planes, v11);
		  if ( !planes[245].monitor )
		  {
		LABEL_18:
		    m_antialiasingMode = this->fields.m_antialiasingMode;
		    goto LABEL_19;
		  }
		  v53 = IFix::WrappersManagerImpl::GetPatch(732, 0LL);
		  if ( !v53 )
		    goto LABEL_36;
		  LOBYTE(m_antialiasingMode) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                 (ILFixDynamicMethodWrapper_31 *)v53,
		                                 (Object *)this,
		                                 0LL);
		LABEL_19:
		  if ( (m_antialiasingMode & 0x10) != 0 )
		    goto LABEL_65;
		LABEL_20:
		  v18 = 0.0;
		  v19 = (this->fields.taaFrameIndex & 0x3FF) + 1;
		  v20 = 0LL;
		  v21 = 0.5;
		  do
		  {
		    v22 = v19 % 2;
		    v19 /= 2;
		    v23 = (float)v22 * v21;
		    v21 = v21 * 0.5;
		    v20.m128_f32[0] = v20.m128_f32[0] + v23;
		  }
		  while ( v19 > 0 );
		  v20.m128_f32[0] = v20.m128_f32[0] - 0.5;
		  v24 = 0.33333334;
		  v25 = (this->fields.taaFrameIndex & 0x3FF) + 1;
		  do
		  {
		    v11 = (unsigned int)(v25 / 3);
		    planes = (Camera *)(unsigned int)(v25 % 3);
		    LODWORD(v11) = (unsigned __int64)(1431655766LL * v25) >> 32;
		    v26 = (float)(v25 % 3);
		    v25 /= 3;
		    v27 = v26 * v24;
		    v24 = v24 / 3.0;
		    v18 = v18 + v27;
		  }
		  while ( v25 > 0 );
		  v28 = v18 - 0.5;
		LABEL_25:
		  camera = this->fields.camera;
		  v30 = _mm_shuffle_ps(v20, v20, 225);
		  v30.m128_f32[0] = v28;
		  v31 = _mm_shuffle_ps(v30, v30, 198);
		  v31.m128_f32[0] = (float)(v20.m128_f32[0] / (float)this->fields._actualWidth_k__BackingField) * v16;
		  v32 = _mm_shuffle_ps(v31, v31, 39);
		  v32.m128_f32[0] = (float)(v28 / (float)this->fields._actualHeight_k__BackingField) * v16;
		  taaJitter = _mm_shuffle_ps(v32, v32, 57);
		  this->fields.taaJitter = (Vector4)taaJitter;
		  if ( !camera )
		    goto LABEL_36;
		  v33 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		  if ( !qword_18F36F100 )
		  {
		    v33 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		    if ( !v33 )
		    {
		      v55 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		      sub_18007E1B0(v55, 0LL);
		    }
		    qword_18F36F100 = (__int64)v33;
		  }
		  if ( !v33(camera) )
		  {
		    v76 = 0LL;
		    v34 = (void (__fastcall *)(Matrix4x4 *, __m128 *))qword_18F36FA48;
		    v75 = 0LL;
		    if ( !qword_18F36FA48 )
		    {
		      v34 = (void (__fastcall *)(Matrix4x4 *, __m128 *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.Matrix4x4::DecomposeProjection_Injected(UnityEngin"
		                                                          "e.Matrix4x4&,UnityEngine.FrustumPlanes&)");
		      if ( !v34 )
		      {
		        v56 = sub_1802EE1B8("UnityEngine.Matrix4x4::DecomposeProjection_Injected(UnityEngine.Matrix4x4&,UnityEngine.FrustumPlanes&)");
		        sub_18007E1B0(v56, 0LL);
		      }
		      qword_18F36FA48 = (__int64)v34;
		    }
		    v34(origProj, &v75);
		    v35 = TypeInfo::System::Math;
		    v36 = TypeInfo::System::Math->_1.cctor_finished_or_no_cctor == 0;
		    taaJitter = v75;
		    v73 = v76;
		    if ( v36 )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		    if ( !(unsigned __int8)sub_182F0F990(v35) )
		      goto LABEL_32;
		    planes = (Camera *)this->fields.frustum.planes;
		    if ( planes )
		    {
		      sub_180002100(planes, 5LL);
		LABEL_32:
		      v38 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))qword_18F36FA88;
		      memset(&v74, 0, sizeof(v74));
		      if ( !qword_18F36FA88 )
		      {
		        v38 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Matrix4x4::Frustum_Injected(System.Singl"
		                                                                    "e,System.Single,System.Single,System.Single,System.S"
		                                                                    "ingle,System.Single,UnityEngine.Matrix4x4&)");
		        if ( !v38 )
		        {
		          v57 = sub_1802EE1B8(
		                  "UnityEngine.Matrix4x4::Frustum_Injected(System.Single,System.Single,System.Single,System.Single,System"
		                  ".Single,System.Single,UnityEngine.Matrix4x4&)");
		          sub_18007E1B0(v57, 0LL);
		        }
		        qword_18F36FA88 = (__int64)v38;
		      }
		      v38(&v74, v11, v37);
		      v39 = *(_OWORD *)&v74.m00;
		      v40 = *(_OWORD *)&v74.m01;
		      v41 = *(_OWORD *)&v74.m02;
		      v42 = *(_OWORD *)&v74.m03;
		      goto LABEL_34;
		    }
		LABEL_36:
		    sub_1800D8260(planes, v11);
		  }
		  planes = this->fields.camera;
		  if ( !planes )
		    goto LABEL_36;
		  orthographicSize = UnityEngine::Camera::get_orthographicSize(planes, 0LL);
		  planes = this->fields.camera;
		  v59 = orthographicSize;
		  if ( !planes )
		    goto LABEL_36;
		  aspect = UnityEngine::Camera::get_aspect(planes, 0LL);
		  planes = this->fields.camera;
		  v61 = aspect * v59;
		  v62 = (float)this->fields._actualHeight_k__BackingField * 0.5;
		  v63 = (float)this->fields._actualWidth_k__BackingField * 0.5;
		  taaJitter = (__m128)this->fields.taaJitter;
		  v64 = (float)((float)(v59 / v62) * v16) * taaJitter.m128_f32[1];
		  if ( !planes )
		    goto LABEL_36;
		  v65 = UnityEngine::Camera::get_nearClipPlane(planes, 0LL);
		  planes = this->fields.camera;
		  v66 = v65;
		  if ( !planes )
		    goto LABEL_36;
		  farClipPlane = UnityEngine::Camera::get_farClipPlane(planes, 0LL);
		  v68 = UnityEngine::Matrix4x4::Ortho(
		          &v77,
		          (float)((float)((float)(v61 / v63) * v16) * taaJitter.m128_f32[0]) - v61,
		          (float)((float)((float)(v61 / v63) * v16) * taaJitter.m128_f32[0]) + v61,
		          v64 - v59,
		          v64 + v59,
		          v66,
		          farClipPlane,
		          0LL);
		  v39 = *(_OWORD *)&v68->m00;
		  v40 = *(_OWORD *)&v68->m01;
		  v41 = *(_OWORD *)&v68->m02;
		  v42 = *(_OWORD *)&v68->m03;
		LABEL_34:
		  *(_OWORD *)&retstr->m00 = v39;
		  *(_OWORD *)&retstr->m01 = v40;
		  *(_OWORD *)&retstr->m02 = v41;
		  *(_OWORD *)&retstr->m03 = v42;
		  return retstr;
		}
		
		private Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix([IsReadOnly] in ViewConstants viewConstants, Vector4 resolution, float aspect = -1f /* Metadata: 0x023038B9 */) => default; // 0x00000001833A2F40-0x00000001833A35A0
		// Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(HGCamera+ViewConstants ByRef, Vector4, Single)
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCamera *this,
		        HGCamera_ViewConstants *viewConstants,
		        Vector4 *resolution,
		        float aspect,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *v12; // rdi
		  unsigned __int8 (__fastcall *v13)(Camera *); // rax
		  float v14; // xmm3_4
		  float v15; // xmm2_4
		  void (__fastcall *v16)(__int128 *, __int128 *); // rax
		  __int128 v17; // xmm1
		  __int128 v18; // xmm1
		  Matrix4x4 *v19; // rax
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  void (__fastcall *v24)(_OWORD *, __int128 *, __int128 *); // rax
		  void (__fastcall *v25)(Matrix4x4 *, _OWORD *, Matrix4x4 *); // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  Matrix4x4 *result; // rax
		  bool v30; // al
		  Camera *camera; // rdi
		  double (__fastcall *v32)(Camera *); // rax
		  double v33; // xmm0_8
		  Camera *v34; // rdi
		  float v35; // xmm6_4
		  unsigned __int8 (__fastcall *v36)(Camera *); // rax
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  Beyond::DampingMath *v40; // rcx
		  Camera *v41; // rdi
		  void (__fastcall *v42)(Camera *, Vector2 *); // rax
		  __int128 v43; // xmm7
		  __int128 v44; // xmm8
		  __int128 v45; // xmm9
		  __int128 v46; // xmm10
		  Camera *v47; // rbx
		  __int64 (__fastcall *v48)(Camera *); // rax
		  char v49; // bl
		  Vector4 v50; // xmm0
		  Matrix4x4 *v51; // rax
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v55; // rax
		  __int64 v56; // rax
		  __int64 v57; // rax
		  __int64 v58; // rax
		  Vector4 v59; // [rsp+50h] [rbp-B0h] BYREF
		  Vector4 v60; // [rsp+60h] [rbp-A0h] BYREF
		  Matrix4x4 v61; // [rsp+70h] [rbp-90h] BYREF
		  __int128 v62; // [rsp+B0h] [rbp-50h] BYREF
		  __int128 v63; // [rsp+C0h] [rbp-40h]
		  __int128 v64; // [rsp+D0h] [rbp-30h]
		  __int128 v65; // [rsp+E0h] [rbp-20h]
		  __int128 v66; // [rsp+F0h] [rbp-10h] BYREF
		  __int128 v67; // [rsp+100h] [rbp+0h]
		  __int128 v68; // [rsp+110h] [rbp+10h]
		  __int128 v69; // [rsp+120h] [rbp+20h]
		  __m128i si128; // [rsp+130h] [rbp+30h] BYREF
		  __m128i v71; // [rsp+140h] [rbp+40h] BYREF
		  Matrix4x4 v72; // [rsp+150h] [rbp+50h] BYREF
		  _OWORD v73[4]; // [rsp+190h] [rbp+90h] BYREF
		  _OWORD v74[4]; // [rsp+1D0h] [rbp+D0h] BYREF
		  Vector2 v75; // [rsp+280h] [rbp+180h] BYREF
		
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_41;
		  if ( wrapperArray->max_length.size > 774 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v8->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_41;
		    if ( wrapperArray->max_length.size <= 0x306u )
		      goto LABEL_58;
		    if ( wrapperArray[21].vector[18] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(774, 0LL);
		      if ( Patch )
		      {
		        v59 = *resolution;
		        v51 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_304(
		                &v72,
		                Patch,
		                (Object *)this,
		                viewConstants,
		                &v59,
		                aspect,
		                0LL);
		LABEL_40:
		        v52 = *(_OWORD *)&v51->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v51->m00;
		        v53 = *(_OWORD *)&v51->m02;
		        *(_OWORD *)&retstr->m01 = v52;
		        v28 = *(_OWORD *)&v51->m03;
		        *(_OWORD *)&retstr->m02 = v53;
		        goto LABEL_20;
		      }
		LABEL_41:
		      sub_1800D8260(v8, wrapperArray);
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v8);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_41;
		  if ( wrapperArray->max_length.size <= 775 )
		    goto LABEL_11;
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v8);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		  if ( !v8 )
		    goto LABEL_41;
		  if ( LODWORD(v8->_0.namespaze) <= 0x307 )
		LABEL_58:
		    sub_1800D2AB0(v8, wrapperArray);
		  if ( *(_QWORD *)&v8[16]._1.initializationExceptionGCHandle )
		  {
		    v55 = IFix::WrappersManagerImpl::GetPatch(775, 0LL);
		    if ( !v55 )
		      goto LABEL_41;
		    v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_302(v55, &viewConstants->projMatrix, 0LL);
		    goto LABEL_22;
		  }
		LABEL_11:
		  if ( viewConstants->projMatrix.m02 != 0.0 )
		    goto LABEL_12;
		  v30 = viewConstants->projMatrix.m12 != 0.0;
		LABEL_22:
		  if ( !v30 )
		  {
		LABEL_23:
		    camera = this->fields.camera;
		    if ( camera )
		    {
		      v32 = (double (__fastcall *)(Camera *))qword_18F36F178;
		      if ( !qword_18F36F178 )
		      {
		        v32 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::GetGateFittedFieldOfView()");
		        qword_18F36F178 = (__int64)v32;
		      }
		      v33 = v32(camera);
		      v34 = this->fields.camera;
		      v35 = *(float *)&v33 * 0.017453292;
		      if ( v34 )
		      {
		        v36 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F160;
		        if ( !qword_18F36F160 )
		        {
		          v36 = (unsigned __int8 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_usePhysicalProperties()");
		          qword_18F36F160 = (__int64)v36;
		        }
		        if ( !v36(v34) )
		        {
		          v37 = *(_OWORD *)&viewConstants->projMatrix.m01;
		          *(_OWORD *)&v61.m00 = *(_OWORD *)&viewConstants->projMatrix.m00;
		          v38 = *(_OWORD *)&viewConstants->projMatrix.m02;
		          *(_OWORD *)&v61.m01 = v37;
		          v39 = *(_OWORD *)&viewConstants->projMatrix.m03;
		          *(_OWORD *)&v61.m02 = v38;
		          *(_OWORD *)&v61.m03 = v39;
		          *(float *)&v39 = -1.0 / UnityEngine::Matrix4x4::get_Item(&v61, 5, 0LL);
		          Beyond::DampingMath::fast_atan(v40, *(float *)&v39);
		          v35 = *(float *)&v39 + *(float *)&v39;
		        }
		        v41 = this->fields.camera;
		        if ( v41 )
		        {
		          v75 = 0LL;
		          v42 = (void (__fastcall *)(Camera *, Vector2 *))qword_18F36F208;
		          if ( !qword_18F36F208 )
		          {
		            v42 = (void (__fastcall *)(Camera *, Vector2 *))sub_180059EA0(
		                                                              "UnityEngine.Camera::GetGateFittedLensShift_Injected(UnityEngine.Vector2&)");
		            qword_18F36F208 = (__int64)v42;
		          }
		          v42(v41, &v75);
		          v43 = *(_OWORD *)&viewConstants->viewMatrix.m00;
		          v44 = *(_OWORD *)&viewConstants->viewMatrix.m01;
		          v45 = *(_OWORD *)&viewConstants->viewMatrix.m02;
		          v46 = *(_OWORD *)&viewConstants->viewMatrix.m03;
		          v47 = this->fields.camera;
		          if ( v47 )
		          {
		            v48 = (__int64 (__fastcall *)(Camera *))qword_18F36F100;
		            if ( !qword_18F36F100 )
		            {
		              v48 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_orthographic()");
		              qword_18F36F100 = (__int64)v48;
		            }
		            v49 = v48(v47);
		            if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            v50 = *resolution;
		            *(_OWORD *)&v61.m00 = v43;
		            v59 = v50;
		            *(_OWORD *)&v61.m01 = v44;
		            *(_OWORD *)&v61.m02 = v45;
		            *(_OWORD *)&v61.m03 = v46;
		            v51 = HG::Rendering::Runtime::HGUtils::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
		                    &v72,
		                    v35,
		                    v75,
		                    &v59,
		                    &v61,
		                    0,
		                    aspect,
		                    v49,
		                    0LL);
		            goto LABEL_40;
		          }
		        }
		      }
		    }
		    goto LABEL_41;
		  }
		LABEL_12:
		  v12 = this->fields.camera;
		  if ( !v12 )
		    goto LABEL_41;
		  v13 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F160;
		  if ( !qword_18F36F160 )
		  {
		    v13 = (unsigned __int8 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_usePhysicalProperties()");
		    qword_18F36F160 = (__int64)v13;
		  }
		  if ( v13(v12) )
		    goto LABEL_23;
		  v14 = resolution->z + resolution->z;
		  v15 = resolution->w * -2.0;
		  memset(&v61, 0, sizeof(v61));
		  v60.x = 0.0;
		  v60.z = 0.0;
		  v60.w = 1.0;
		  *(_QWORD *)&v59.y = 0LL;
		  v59.x = v14;
		  v60.y = v15;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  v71 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  v59.w = -1.0;
		  UnityEngine::Matrix4x4::Matrix4x4(&v61, &v59, &v60, (Vector4 *)&v71, (Vector4 *)&si128, 0LL);
		  v16 = (void (__fastcall *)(__int128 *, __int128 *))qword_18F36FA68;
		  v17 = *(_OWORD *)&viewConstants->invViewProjMatrix.m01;
		  v66 = *(_OWORD *)&viewConstants->invViewProjMatrix.m00;
		  v67 = v17;
		  v18 = *(_OWORD *)&viewConstants->invViewProjMatrix.m03;
		  v68 = *(_OWORD *)&viewConstants->invViewProjMatrix.m02;
		  v69 = v18;
		  v62 = 0LL;
		  v63 = 0LL;
		  v64 = 0LL;
		  v65 = 0LL;
		  if ( !qword_18F36FA68 )
		  {
		    v16 = (void (__fastcall *)(__int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4"
		                                                         "&,UnityEngine.Matrix4x4&)");
		    if ( !v16 )
		    {
		      v56 = sub_1802EE1B8("UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v56, 0LL);
		    }
		    qword_18F36FA68 = (__int64)v16;
		  }
		  v16(&v66, &v62);
		  v60.z = -1.0;
		  *(_QWORD *)&v60.x = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0];
		  v19 = UnityEngine::Matrix4x4::Scale(&v72, (Vector3 *)&v60, 0LL);
		  v73[0] = v62;
		  v73[1] = v63;
		  v73[2] = v64;
		  v20 = *(_OWORD *)&v19->m00;
		  v73[3] = v65;
		  v21 = *(_OWORD *)&v19->m01;
		  v66 = v20;
		  v22 = *(_OWORD *)&v19->m02;
		  v67 = v21;
		  v23 = *(_OWORD *)&v19->m03;
		  v24 = (void (__fastcall *)(_OWORD *, __int128 *, __int128 *))qword_18F36FA50;
		  v68 = v22;
		  v69 = v23;
		  v62 = 0LL;
		  v63 = 0LL;
		  v64 = 0LL;
		  v65 = 0LL;
		  if ( !qword_18F36FA50 )
		  {
		    v24 = (void (__fastcall *)(_OWORD *, __int128 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inject"
		                                                                   "ed(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		                                                                   "yEngine.Matrix4x4&)");
		    if ( !v24 )
		    {
		      v57 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v57, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v24;
		  }
		  v24(v73, &v66, &v62);
		  v25 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))qword_18F36FA50;
		  v72 = v61;
		  v74[0] = v62;
		  v74[1] = v63;
		  v74[2] = v64;
		  v74[3] = v65;
		  memset(&v61, 0, sizeof(v61));
		  if ( !qword_18F36FA50 )
		  {
		    v25 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
		                                                                     "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
		                                                                     "UnityEngine.Matrix4x4&)");
		    if ( !v25 )
		    {
		      v58 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v58, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v25;
		  }
		  v25(&v72, v74, &v61);
		  v26 = *(_OWORD *)&v61.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v61.m00;
		  v27 = *(_OWORD *)&v61.m02;
		  *(_OWORD *)&retstr->m01 = v26;
		  v28 = *(_OWORD *)&v61.m03;
		  *(_OWORD *)&retstr->m02 = v27;
		LABEL_20:
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v28;
		  return result;
		}
		
		private static void InitializeRenderPath(HGCamera camera, HGRenderPathInternal renderPathInternalEnum, HGRenderPipeline hgrp) {} // 0x00000001830FF6D0-0x00000001830FF870
		// Void InitializeRenderPath(HGCamera, HGRenderPathInternal, HGRenderPipeline)
		void HG::Rendering::Runtime::HGCamera::InitializeRenderPath(
		        HGCamera *camera,
		        HGRenderPathInternal__Enum renderPathInternalEnum,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rcx
		  HGRenderPathBase *renderPathInstance_k__BackingField; // rdi
		  int32_t renderPath_k__BackingField; // eax
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  HGRenderPathBase *v20; // rdi
		  HGRenderGraph *renderGraph; // rax
		  ILFixDynamicMethodWrapper_2__Array *v22; // r8
		  ILFixDynamicMethodWrapper_2 *v23; // rax
		  ILFixDynamicMethodWrapper_2__Array *v24; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-38h]
		  _BYTE v29[40]; // [rsp+30h] [rbp-28h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)&v29[8] = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v4->static_fields;
		  wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_16;
		  if ( SLODWORD(wrapperArray[3].wrapperArray) <= 705 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v4->static_fields;
		  v22 = static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_16;
		  if ( v22->max_length.size <= 0x2C1u )
		    goto LABEL_36;
		  if ( !v22[19].vector[21] )
		  {
		LABEL_5:
		    if ( !camera )
		      goto LABEL_16;
		    if ( !camera->fields._renderPathInstance_k__BackingField )
		      goto LABEL_13;
		    renderPathInstance_k__BackingField = camera->fields._renderPathInstance_k__BackingField;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v4->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_16;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 706 )
		      goto LABEL_11;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v4->static_fields;
		    v24 = wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_16;
		    if ( v24->max_length.size > 0x2C2u )
		    {
		      if ( v24[19].vector[22] )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(706, 0LL);
		        if ( !Patch )
		          goto LABEL_16;
		        renderPath_k__BackingField = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                                       (ILFixDynamicMethodWrapper_26 *)Patch,
		                                       (Object *)renderPathInstance_k__BackingField,
		                                       0LL);
		        goto LABEL_12;
		      }
		LABEL_11:
		      renderPath_k__BackingField = renderPathInstance_k__BackingField->fields._renderPath_k__BackingField;
		LABEL_12:
		      if ( renderPath_k__BackingField == renderPathInternalEnum )
		        return;
		LABEL_13:
		      if ( camera->fields._renderPathInstance_k__BackingField )
		      {
		        if ( camera->fields.reflectionProbeViewHandle )
		          UnityEngine::HyperGryph::HGReflectionProbe::ResetView(camera->fields.reflectionProbeViewHandle, 0LL);
		        v20 = camera->fields._renderPathInstance_k__BackingField;
		        if ( hgrp )
		        {
		          renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		          if ( v20 )
		          {
		            sub_1800DA430(13LL, v20, renderGraph);
		            goto LABEL_15;
		          }
		        }
		      }
		      else if ( hgrp )
		      {
		LABEL_15:
		        *(_QWORD *)v29 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		        sub_18002D1B0((SingleFieldAccessor *)v29, v12, v13, v14, methoda);
		        *(_QWORD *)&v29[8] = hgrp->fields._settingParameters_k__BackingField;
		        sub_18002D1B0((SingleFieldAccessor *)&v29[8], v15, v16, *(Int32__Array ***)&v29[8], methodb);
		        *(_OWORD *)&v29[16] = *(_OWORD *)v29;
		        camera->fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
		                                                               renderPathInternalEnum,
		                                                               (HGRenderPathBase_HGRenderPathResources *)&v29[16],
		                                                               camera,
		                                                               0LL);
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&camera->fields._renderPathInstance_k__BackingField,
		          v17,
		          v18,
		          v19,
		          methodc);
		        return;
		      }
		LABEL_16:
		      sub_1800D8260(wrapperArray, static_fields);
		    }
		LABEL_36:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		  v23 = IFix::WrappersManagerImpl::GetPatch(705, 0LL);
		  if ( !v23 )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_25(
		    (ILFixDynamicMethodWrapper_14 *)v23,
		    (Object *)camera,
		    (SCMessageID__Enum)renderPathInternalEnum,
		    (Object *)hgrp,
		    0LL);
		}
		
		private void Dispose(HGRenderGraph renderGraph) {} // 0x00000001837DDD50-0x00000001837DDFF0
		// Void Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HGCamera::Dispose(HGCamera *this, HGRenderGraph *renderGraph, MethodInfo *method)
		{
		  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rdi
		  __int64 v6; // rax
		  CustomDepthOnlyRequestManager *v7; // rdx
		  VolumeManager *instance; // rax
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v9; // rdx
		  HGShadowManager *shadowManager; // rcx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  BufferedRTHandleSystem *m_HistoryRTSystem; // rdi
		  int32_t i; // edi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
		  int32_t j; // esi
		  List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v18; // rax
		  Object *Item; // rax
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(531, 0LL) )
		  {
		    if ( this->fields.verticalOcclusionMapManager )
		    {
		      verticalOcclusionMapManager = this->fields.verticalOcclusionMapManager;
		      v6 = sub_180005050(
		             this->fields._renderPathInstance_k__BackingField,
		             TypeInfo::HG::Rendering::Runtime::HGRenderPathDeferred);
		      if ( v6 )
		        v7 = *(CustomDepthOnlyRequestManager **)(v6 + 5048);
		      else
		        v7 = 0LL;
		      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::Dispose(verticalOcclusionMapManager, v7, 0LL);
		    }
		    if ( this->fields.reflectionProbeViewHandle )
		      UnityEngine::HyperGryph::HGReflectionProbe::RemoveView(this->fields.reflectionProbeViewHandle, 0LL);
		    if ( this->fields.renderPathInstanceCPP )
		      UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::HGRenderPath_Destroy(this->fields.renderPathInstanceCPP, 0LL);
		    if ( this->fields._renderPathInstance_k__BackingField )
		      sub_1800DA430(13LL, this->fields._renderPathInstance_k__BackingField, renderGraph);
		    if ( !TypeInfo::UnityEngine::Rendering::VolumeManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::VolumeManager);
		    instance = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
		    if ( instance )
		    {
		      UnityEngine::Rendering::VolumeManager::DestroyStack(instance, this->fields._volumeStack_k__BackingField, 0LL);
		      if ( this->fields.m_HistoryRTSystem )
		      {
		        m_HistoryRTSystem = this->fields.m_HistoryRTSystem;
		        if ( !m_HistoryRTSystem->fields.m_DisposedValue )
		        {
		          UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(this->fields.m_HistoryRTSystem, 0LL);
		          m_HistoryRTSystem->fields.m_DisposedValue = 1;
		        }
		        this->fields.m_HistoryRTSystem = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_HistoryRTSystem, v11, v12, v13, v26);
		      }
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		        &this->fields.volumetricIntegratedLightScatteringTexture,
		        0LL);
		      HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		        &this->fields.historyVolumetricLightScatteringTexture,
		        0LL);
		      HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&this->fields.atmosphereSkyViewLutTexture, 0LL);
		      if ( this->fields.autoExposureHistogramBuffer )
		      {
		        UnityEngine::ComputeBuffer::Dispose(this->fields.autoExposureHistogramBuffer, 0LL);
		        this->fields.autoExposureHistogramBuffer = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.autoExposureHistogramBuffer, v22, v23, v24, v26);
		      }
		      for ( i = 0; ; ++i )
		      {
		        m_rtExtractionLists = this->fields.m_rtExtractionLists;
		        if ( !m_rtExtractionLists )
		          goto LABEL_34;
		        if ( i >= m_rtExtractionLists->max_length.size )
		          break;
		        for ( j = 0; ; ++j )
		        {
		          v18 = this->fields.m_rtExtractionLists;
		          if ( !v18 )
		            goto LABEL_34;
		          if ( (unsigned int)i >= v18->max_length.size )
		            sub_1800D2AB0(shadowManager, v9);
		          shadowManager = (HGShadowManager *)i;
		          v9 = v18->vector[i];
		          if ( !v9 )
		            goto LABEL_34;
		          if ( j >= v9->fields._size )
		            break;
		          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                   (List_1_System_Object_ *)this->fields.m_rtExtractionLists->vector[i],
		                   j,
		                   MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
		          if ( !Item )
		            goto LABEL_34;
		          System::Collections::Generic::HashSet<unsigned long>::Clear(
		            (HashSet_1_System_UInt64_ *)Item,
		            MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Clear);
		        }
		      }
		      UnityEngine::HyperGryph::HGCullingSystem::UnregisterCullViewUniqueId(this->fields.cullingViewUniqueID, 0LL);
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		      if ( s_rainRenderer )
		      {
		        HG::Rendering::Runtime::HGRainRenderer::DisposeSeq(s_rainRenderer, this, 0LL);
		        s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		        if ( s_snowRenderer )
		        {
		          HG::Rendering::Runtime::HGSnowRenderer::DisposeSeq(s_snowRenderer, this, 0LL);
		          shadowManager = this->fields.shadowManager;
		          if ( shadowManager )
		          {
		            HG::Rendering::Runtime::HGShadowManager::Cleanup(shadowManager, 0LL);
		            shadowManager = (HGShadowManager *)this->fields.lightCookieManager;
		            if ( shadowManager )
		            {
		              HG::Rendering::Runtime::HGLightCookieManager::Dispose((HGLightCookieManager *)shadowManager, 0LL);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_34:
		    sub_1800D8260(shadowManager, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(531, 0LL);
		  if ( !Patch )
		    goto LABEL_34;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		public int GetSortingOrdersToBlurCount() => default; // 0x0000000183E630E0-0x0000000183E63140
		// Int32 GetSortingOrdersToBlurCount()
		int32_t HG::Rendering::Runtime::HGCamera::GetSortingOrdersToBlurCount(HGCamera *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_System_Int32_ *m_sortingOrdersToBlur; // rax
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
		  if ( wrapperArray->max_length.size <= 1070 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x42E )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[22].vtable.Equals.method )
		  {
		LABEL_5:
		    m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		    if ( m_sortingOrdersToBlur )
		      return m_sortingOrdersToBlur->fields._size;
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1070, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public unsafe void ExtractSortingOrdersToBlurForCPP(int* dst, int count) {} // 0x0000000183F31000-0x0000000183F31030
		// Void ExtractSortingOrdersToBlurForCPP(Int32*, Int32)
		void HG::Rendering::Runtime::HGCamera::ExtractSortingOrdersToBlurForCPP(
		        HGCamera *this,
		        int32_t *dst,
		        int32_t count,
		        MethodInfo *method)
		{
		  int32_t *v5; // rsi
		  int32_t i; // edi
		  List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
		
		  if ( count > 0 )
		  {
		    v5 = dst;
		    for ( i = 0; i < count; ++i )
		    {
		      m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		      if ( !m_sortingOrdersToBlur )
		        sub_1800D8260(0LL, dst);
		      *v5++ = System::Collections::Generic::List<int>::get_Item(
		                m_sortingOrdersToBlur,
		                i,
		                MethodInfo::System::Collections::Generic::List<int>::get_Item);
		    }
		  }
		}
		
		internal void OnRecordingBegin() {} // 0x0000000189B7324C-0x0000000189B733BC
		// Void OnRecordingBegin()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCamera::OnRecordingBegin(HGCamera *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_System_Int32_ *m_sortingOrdersToBlur; // rdi
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  int v8; // edi
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Il2CppExceptionWrapper *v13; // [rsp+30h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Int32_ v14; // [rsp+38h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Int32_ v15; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1189, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1189, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_sortingOrdersToBlur = this->fields.m_sortingOrdersToBlur;
		    if ( !m_sortingOrdersToBlur )
		      sub_1800D8260(v4, v3);
		    *(_OWORD *)&v14._list = 0LL;
		    Unity::Collections::NativeArray<int>::NativeArray(
		      (NativeArray_1_System_Int32_ *)&v14,
		      m_sortingOrdersToBlur->fields._size,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		    this->fields.sortingOrdersToBlurInternal = *(NativeArray_1_System_Int32_ *)&v14._list;
		    v8 = 0;
		    if ( !this->fields.m_sortingOrdersToBlur )
		      sub_1800D8260(v7, v6);
		    System::Collections::Generic::List<int>::GetEnumerator(
		      &v14,
		      this->fields.m_sortingOrdersToBlur,
		      MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		    v15 = v14;
		    v14._list = 0LL;
		    *(_QWORD *)&v14._index = &v15;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v15,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		      {
		        v9 = v8++;
		        *(_DWORD *)&this->fields.sortingOrdersToBlurInternal.m_Buffer[4 * v9] = v15._current;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v13 )
		    {
		      v14._list = (List_1_System_Int32_ *)v13->ex;
		      if ( v14._list )
		        sub_18007E1E0(v14._list);
		    }
		  }
		}
		
		internal void OnRecordingEnd() {} // 0x00000001837DDFF0-0x00000001837DE2B0
		// Void OnRecordingEnd()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCamera::OnRecordingEnd(HGCamera *this, MethodInfo *method)
		{
		  Object *v2; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Object__Class *klass; // rbx
		  __int64 v10; // rbx
		  __int64 *v11; // rdx
		  signed __int64 v12; // rcx
		  __int64 v13; // rtt
		  __int64 *v14; // rdx
		  MonitorData *monitor; // rcx
		  Object__Class *v16; // rbx
		  int32_t klassIndex; // r14d
		  const char *name; // r8
		  int32_t v19; // r8d
		  __int64 v20; // [rsp+0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v21; // [rsp+20h] [rbp-58h] BYREF
		  _BYTE v22[24]; // [rsp+28h] [rbp-50h] BYREF
		  List_1_T_Enumerator_System_Object_ v23; // [rsp+40h] [rbp-38h] BYREF
		
		  v2 = (Object *)this;
		  memset(&v23, 0, sizeof(v23));
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size > 1158 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = v3->static_fields->wrapperArray;
		    if ( !v5 )
		      sub_1800D8260(v3, method);
		    if ( v5->max_length.size <= 0x486u )
		      sub_1800D2AB0(v3, method);
		    if ( v5[32].vector[6] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1158, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, v2, 0LL);
		      return;
		    }
		  }
		  klass = v2[110].klass;
		  if ( !klass )
		    sub_1800D8260(v3, method);
		  if ( LODWORD(klass->_0.namespaze) <= 1 )
		    sub_1800D2AB0(v3, method);
		  v10 = *((_QWORD *)&klass->_0.byval_arg + 1);
		  if ( !v10 )
		    sub_1800D8260(v3, method);
		  *(_OWORD *)&v22[8] = 0LL;
		  *(_QWORD *)v22 = v10;
		  if ( dword_18F35FD08 )
		  {
		    v11 = &qword_18F103690[(((unsigned __int64)v22 >> 12) & 0x1FFFFF) >> 6];
		    _m_prefetchw(v11);
		    do
		    {
		      v12 = *v11 | (1LL << (((unsigned __int64)v22 >> 12) & 0x3F));
		      v13 = *v11;
		    }
		    while ( v13 != _InterlockedCompareExchange64(v11, v12, *v11) );
		  }
		  *(_DWORD *)&v22[8] = 0;
		  *(_DWORD *)&v22[12] = *(_DWORD *)(v10 + 28);
		  *(_QWORD *)&v22[16] = 0LL;
		  *(_OWORD *)&v23._list = *(_OWORD *)v22;
		  v23._current = 0LL;
		  *(_QWORD *)v22 = 0LL;
		  *(_QWORD *)&v22[8] = &v23;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v23,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::MoveNext) )
		    {
		      if ( !v23._current )
		        sub_1800D8250(0LL, v14);
		      System::Collections::Generic::HashSet<unsigned long>::Clear(
		        (HashSet_1_System_UInt64_ *)v23._current,
		        MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Clear);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v21 )
		  {
		    v14 = &v20;
		    *(Il2CppExceptionWrapper *)v22 = (Il2CppExceptionWrapper)v21->ex;
		    monitor = *(MonitorData **)v22;
		    if ( *(_QWORD *)v22 )
		      sub_18007E1E0(*(_QWORD *)v22);
		    v2 = (Object *)this;
		  }
		  v16 = v2[111].klass;
		  if ( !v16 )
		    goto LABEL_41;
		  klassIndex = v16->_0.byval_arg.data.__klassIndex;
		  if ( klassIndex > 0 )
		  {
		    name = v16->_0.name;
		    if ( !name )
		      goto LABEL_41;
		    System::Array::Clear((Array *)v16->_0.name, 0, *((_DWORD *)name + 6), 0LL);
		    v16->_0.byval_arg.data.__klassIndex = 0;
		    HIDWORD(v16->_0.byval_arg.data.type) = -1;
		    *((_DWORD *)&v16->_0.byval_arg + 2) = 0;
		    System::Array::Clear((Array *)v16->_0.namespaze, 0, klassIndex, 0LL);
		  }
		  ++*((_DWORD *)&v16->_0.byval_arg + 3);
		  monitor = v2[111].monitor;
		  if ( !monitor )
		LABEL_41:
		    sub_1800D8250(monitor, v14);
		  ++*((_DWORD *)monitor + 7);
		  v19 = *((_DWORD *)monitor + 6);
		  *((_DWORD *)monitor + 6) = 0;
		  if ( v19 > 0 )
		    System::Array::Clear(*((Array **)monitor + 2), 0, v19, 0LL);
		}
		
		private void ReleaseHistoryBuffer() {} // 0x0000000184700690-0x00000001847006E0
		// Void ReleaseHistoryBuffer()
		void HG::Rendering::Runtime::HGCamera::ReleaseHistoryBuffer(HGCamera *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(530, 0LL) )
		  {
		    m_HistoryRTSystem = this->fields.m_HistoryRTSystem;
		    if ( m_HistoryRTSystem )
		    {
		      UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(m_HistoryRTSystem, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_HistoryRTSystem, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(530, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private Rect GetPixelRect() => default; // 0x0000000183DD3750-0x0000000183DD37F0
		// Rect GetPixelRect()
		Rect *HG::Rendering::Runtime::HGCamera::GetPixelRect(Rect *__return_ptr retstr, HGCamera *this, MethodInfo *method)
		{
		  void *v5; // rcx
		  Camera *camera; // rdx
		  Rect value; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Rect v10; // xmm7
		  Rect v11; // xmm6
		  int32_t pixelWidth; // eax
		  int v13; // esi
		  Rect v14; // [rsp+20h] [rbp-38h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  camera = (Camera *)**((_QWORD **)v5 + 23);
		  if ( !camera )
		    goto LABEL_9;
		  if ( SLODWORD(camera[1].klass) > 742 )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (void *)**((_QWORD **)v5 + 23);
		    if ( !v5 )
		      goto LABEL_9;
		    if ( *((_DWORD *)v5 + 6) <= 0x2E6u )
		      sub_1800D2AB0(v5, camera);
		    if ( *((_QWORD *)v5 + 746) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(742, 0LL);
		      if ( Patch )
		      {
		        value = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_294(&v14, Patch, (Object *)this, 0LL);
		        goto LABEL_7;
		      }
		LABEL_9:
		      sub_1800D8260(v5, camera);
		    }
		  }
		  if ( !this->fields.overridePixelRect.hasValue )
		  {
		    camera = this->fields.camera;
		    if ( camera )
		    {
		      v10 = *UnityEngine::Camera::get_pixelRect(&v14, camera, 0LL);
		      camera = this->fields.camera;
		      if ( camera )
		      {
		        v11 = *UnityEngine::Camera::get_pixelRect(&v14, camera, 0LL);
		        v5 = this->fields.camera;
		        if ( v5 )
		        {
		          pixelWidth = UnityEngine::Camera::get_pixelWidth((Camera *)v5, 0LL);
		          v5 = this->fields.camera;
		          v13 = pixelWidth;
		          if ( v5 )
		          {
		            retstr->m_Height = (float)UnityEngine::Camera::get_pixelHeight((Camera *)v5, 0LL);
		            retstr->m_XMin = v10.m_XMin;
		            LODWORD(retstr->m_YMin) = _mm_shuffle_ps((__m128)v11, (__m128)v11, 85).m128_u32[0];
		            retstr->m_Width = (float)v13;
		            return retstr;
		          }
		        }
		      }
		    }
		    goto LABEL_9;
		  }
		  value = this->fields.overridePixelRect.value;
		LABEL_7:
		  *retstr = value;
		  return retstr;
		}
		
		internal BufferedRTHandleSystem GetHistoryRTHandleSystem() => default; // 0x0000000189B72E88-0x0000000189B72ED8
		// BufferedRTHandleSystem GetHistoryRTHandleSystem()
		BufferedRTHandleSystem *HG::Rendering::Runtime::HGCamera::GetHistoryRTHandleSystem(HGCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2842, 0LL) )
		    return this->fields.m_HistoryRTSystem;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2842, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1036(Patch, (Object *)this, 0LL);
		}
		
		internal void BindHistoryRTHandleSystem(BufferedRTHandleSystem historyRTSystem) {} // 0x0000000189B72164-0x0000000189B721CC
		// Void BindHistoryRTHandleSystem(BufferedRTHandleSystem)
		void HG::Rendering::Runtime::HGCamera::BindHistoryRTHandleSystem(
		        HGCamera *this,
		        BufferedRTHandleSystem *historyRTSystem,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2843, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2843, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)historyRTSystem,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_HistoryRTSystem = historyRTSystem;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_HistoryRTSystem, v5, v6, v7, v11);
		  }
		}
		
		internal Matrix4x4 GetHGCameraCullingMatrix() => default; // 0x000000018324D170-0x000000018324DC80
		// Matrix4x4 GetHGCameraCullingMatrix()
		Matrix4x4 *HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGCamera *this,
		        MethodInfo *method)
		{
		  __int64 v4; // rcx
		  __int64 v6; // rdx
		  Matrix4x4 *v7; // rax
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  Matrix4x4 *result; // rax
		  HGRenderPipelineSettingHub *instance; // r12
		  __int64 v13; // r13
		  Call *v14; // rax
		  __m128i v15; // xmm1
		  Object__Array *managedStack; // r15
		  __int128 v17; // xmm6
		  Value_1 *v18; // rax
		  _QWORD *v19; // r8
		  char *v20; // xmm1_8
		  Il2CppClass *element_class; // r14
		  char *v22; // rsi
		  __int64 v23; // r14
		  Il2CppClass *v24; // rsi
		  int32_t currentDeviceType_k__BackingField; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  float heightFogCullingFarClipPlane; // xmm6_4
		  Camera *camera; // rsi
		  float (__fastcall *v30)(Camera *); // rax
		  Camera *v31; // rsi
		  unsigned __int8 (__fastcall *v32)(Camera *); // rax
		  Camera *v33; // rsi
		  __int64 (__fastcall *v34)(Camera *); // rax
		  char v35; // al
		  float fieldOfView; // xmm0_4
		  float v37; // xmm8_4
		  float v38; // xmm0_4
		  float v39; // xmm7_4
		  float v40; // xmm0_4
		  Matrix4x4 *v41; // rax
		  Camera *v42; // rdi
		  __int128 v43; // xmm6
		  __int128 v44; // xmm7
		  __int128 v45; // xmm8
		  __int128 v46; // xmm9
		  void (__fastcall *v47)(Camera *, Matrix4x4 *); // rax
		  void (__fastcall *v48)(Matrix4x4 *, Matrix4x4 *, __int128 *); // rax
		  Matrix4x4 *v49; // rdx
		  Matrix4x4 *v50; // rcx
		  Vector2 sensorSize; // rax
		  Vector2 v52; // xmm8_8
		  Value_1 *lensShift; // rax
		  Value_1 *v54; // xmm7_8
		  float v55; // xmm0_4
		  float v56; // xmm9_4
		  Camera_GateFitMode__Enum gateFit; // eax
		  Camera_GateFitMode__Enum v58; // esi
		  __int64 v59; // rdx
		  float aspect; // xmm0_4
		  void (__fastcall *v61)(__int128 *, __int64, __int64 *, Value_1 **, _DWORD, _DWORD, _DWORD, Camera_GateFitMode__Enum); // rax
		  Camera *v62; // rdi
		  __int128 v63; // xmm6
		  __int128 v64; // xmm7
		  __int128 v65; // xmm8
		  __int128 v66; // xmm9
		  void (__fastcall *v67)(Camera *, Matrix4x4 *); // rax
		  __m128i v68; // xmm1
		  __int128 v69; // xmm0
		  Camera *v70; // rdi
		  void (__fastcall *v71)(Camera *, Matrix4x4 *); // rax
		  __int128 v72; // xmm1
		  __int128 v73; // xmm0
		  __int64 v74; // rax
		  __int64 v75; // rax
		  __int64 v76; // rax
		  __int64 v77; // rax
		  __int64 v78; // rax
		  __int64 v79; // rax
		  __int64 v80; // rax
		  __int64 v81; // rax
		  __int64 v82; // rax
		  __int64 v83; // rax
		  __int64 v84; // rax
		  __int64 v85; // [rsp+50h] [rbp-B0h] BYREF
		  Matrix4x4 v86; // [rsp+58h] [rbp-A8h] BYREF
		  __int128 v87; // [rsp+98h] [rbp-68h] BYREF
		  __m128i v88; // [rsp+A8h] [rbp-58h]
		  Value_1 **topWriteBack[2]; // [rsp+B8h] [rbp-48h]
		  __int128 v90; // [rsp+C8h] [rbp-38h]
		  __int64 v91; // [rsp+D8h] [rbp-28h]
		  Matrix4x4 v92; // [rsp+E0h] [rbp-20h] BYREF
		  Matrix4x4 v93; // [rsp+120h] [rbp+20h] BYREF
		  __int128 v94; // [rsp+160h] [rbp+60h] BYREF
		  __int128 v95; // [rsp+170h] [rbp+70h]
		  __int128 v96; // [rsp+180h] [rbp+80h]
		  __int128 v97; // [rsp+190h] [rbp+90h]
		  _QWORD *v98; // [rsp+230h] [rbp+130h]
		  HGRenderPipelineSettingHub__Class *klass; // [rsp+230h] [rbp+130h]
		  Value_1 *evaluationStackBase; // [rsp+248h] [rbp+148h] BYREF
		
		  v4 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v94 = 0LL;
		  v95 = 0LL;
		  v96 = 0LL;
		  v97 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(_QWORD **)(v4 + 184);
		  if ( !v6 )
		    goto LABEL_118;
		  if ( *(int *)(v6 + 24) > 766 )
		  {
		    if ( !*(_DWORD *)(v4 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = **(_QWORD **)(v4 + 184);
		    if ( !v6 )
		      goto LABEL_118;
		    if ( *(_DWORD *)(v6 + 24) <= 0x2FEu )
		      goto LABEL_121;
		    if ( *(_QWORD *)(v6 + 6160) )
		    {
		      if ( !*(_DWORD *)(v4 + 224) )
		      {
		        il2cpp_runtime_class_init_1(v4);
		        v4 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = **(_QWORD **)(v4 + 184);
		      if ( !v4 )
		        goto LABEL_118;
		      if ( *(_DWORD *)(v4 + 24) > 0x2FEu )
		      {
		        v6 = *(_QWORD *)(v4 + 6160);
		        if ( v6 )
		        {
		          v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_193(
		                 &v92,
		                 (ILFixDynamicMethodWrapper_2 *)v6,
		                 (Object *)this,
		                 0LL);
		          v8 = *(_OWORD *)&v7->m01;
		          *(_OWORD *)&retstr->m00 = *(_OWORD *)&v7->m00;
		          v9 = *(_OWORD *)&v7->m02;
		          *(_OWORD *)&retstr->m01 = v8;
		          v10 = *(_OWORD *)&v7->m03;
		          *(_OWORD *)&retstr->m02 = v9;
		          goto LABEL_16;
		        }
		        goto LABEL_118;
		      }
		LABEL_121:
		      sub_1800D2AA0(v4, v6, method);
		    }
		  }
		  instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_118;
		  v6 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *(_QWORD *)(v6 + 184);
		  if ( !*(_QWORD *)v4 )
		    goto LABEL_118;
		  if ( *(int *)(*(_QWORD *)v4 + 24LL) <= 672 )
		    goto LABEL_60;
		  if ( !*(_DWORD *)(v6 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)(v6 + 184);
		  if ( !v4 )
		    goto LABEL_118;
		  if ( *(_DWORD *)(v4 + 24) <= 0x2A0u )
		    goto LABEL_121;
		  if ( *(_QWORD *)(v4 + 5408) )
		  {
		    if ( !*(_DWORD *)(v6 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = **(_QWORD **)(v6 + 184);
		    if ( !v4 )
		      goto LABEL_118;
		    if ( *(_DWORD *)(v4 + 24) <= 0x2A0u )
		      goto LABEL_121;
		    v13 = *(_QWORD *)(v4 + 5408);
		    if ( !v13 )
		      goto LABEL_118;
		    v14 = IFix::Core::Call::Begin((Call *)&v86, 0LL);
		    v15 = *(__m128i *)&v14->managedStack;
		    managedStack = v14->managedStack;
		    topWriteBack[0] = v14->topWriteBack;
		    v17 = *(_OWORD *)&v14->argumentBase;
		    v18 = v14->evaluationStackBase;
		    v88 = v15;
		    evaluationStackBase = v18;
		    if ( *(_QWORD *)(v13 + 32) )
		    {
		      v19 = *(_QWORD **)(v13 + 32);
		      v20 = (char *)_mm_srli_si128(v15, 8).m128i_u64[0];
		      v98 = v19;
		      v6 = (unsigned __int128)((v20 - (char *)v18) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v4 = (v20 - (char *)v18) / 12;
		      v85 = v4;
		      if ( !v20 )
		        goto LABEL_118;
		      *(_DWORD *)v20 = 8;
		      *((_DWORD *)v20 + 1) = v4;
		      if ( !managedStack )
		        goto LABEL_118;
		      element_class = managedStack->klass->_0.element_class;
		      v91 = *v19;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, v91)
		        && ((*(_BYTE *)(v91 + 313) & 0x10) == 0
		         || ((element_class->flags & 0x20) == 0
		          && *((_BYTE *)&element_class->byval_arg + 10) != 19
		          && *((_BYTE *)&element_class->byval_arg + 10) != 30
		          || !element_class->interopData
		          || !element_class->interopData->guid
		          || !sub_1802ED414(v98))
		         && element_class != (Il2CppClass *)qword_18F35FF70) )
		      {
		        v75 = sub_18031E23C();
		        sub_18007E190(v75, 0LL);
		      }
		      sub_180005370(managedStack, (int)v85, v98);
		      v18 = evaluationStackBase;
		      v22 = v20 + 12;
		    }
		    else
		    {
		      v22 = (char *)v88.m128i_i64[1];
		    }
		    v4 = v22 - (char *)v18;
		    v6 = (unsigned __int128)((v22 - (char *)v18) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		    v23 = (v22 - (char *)v18) / 12;
		    if ( !v22 )
		      goto LABEL_118;
		    *(_DWORD *)v22 = 8;
		    *((_DWORD *)v22 + 1) = v23;
		    if ( !managedStack )
		      goto LABEL_118;
		    v24 = managedStack->klass->_0.element_class;
		    klass = instance->klass;
		    if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v24, instance->klass)
		      && ((BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0
		       || ((v24->flags & 0x20) == 0 && *((_BYTE *)&v24->byval_arg + 10) != 19 && *((_BYTE *)&v24->byval_arg + 10) != 30
		        || !v24->interopData
		        || !v24->interopData->guid
		        || !sub_1802ED414(instance))
		       && v24 != (Il2CppClass *)qword_18F35FF70) )
		    {
		      v76 = sub_18031E23C();
		      sub_18007E190(v76, 0LL);
		    }
		    sub_180005370(managedStack, (int)v23, instance);
		    v4 = *(_QWORD *)(v13 + 16);
		    if ( !v4
		      || (IFix::Core::VirtualMachine::Execute(
		            (VirtualMachine *)v4,
		            *(Instruction **)(*(_QWORD *)(v4 + 24) + 8LL * *(int *)(v13 + 24)),
		            (Value_1 *)v17,
		            managedStack,
		            evaluationStackBase,
		            (*(_QWORD *)(v13 + 32) != 0LL) + 1,
		            *(_DWORD *)(v13 + 24),
		            0,
		            topWriteBack[0],
		            0LL),
		          !(_QWORD)v17) )
		    {
		LABEL_118:
		      sub_1800D8250(v4, v6);
		    }
		    currentDeviceType_k__BackingField = *(_DWORD *)(v17 + 4);
		  }
		  else
		  {
		LABEL_60:
		    m_impl = instance->fields.m_impl;
		    if ( !m_impl )
		      goto LABEL_118;
		    currentDeviceType_k__BackingField = m_impl->fields._currentDeviceType_k__BackingField;
		  }
		  if ( currentDeviceType_k__BackingField == 1 )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(this, 0LL);
		    if ( !InterpolatedPhase )
		      goto LABEL_118;
		    heightFogCullingFarClipPlane = InterpolatedPhase->fields.heightFogConfig.heightFogCullingFarClipPlane;
		  }
		  else
		  {
		    heightFogCullingFarClipPlane = 3.4028235e38;
		  }
		  camera = this->fields.camera;
		  if ( !camera )
		    goto LABEL_118;
		  v30 = (float (__fastcall *)(Camera *))qword_18F36F0C0;
		  if ( !qword_18F36F0C0 )
		  {
		    v30 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		    if ( !v30 )
		    {
		      v77 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		      sub_18007E1B0(v77, 0LL);
		    }
		    qword_18F36F0C0 = (__int64)v30;
		  }
		  if ( heightFogCullingFarClipPlane < v30(camera) )
		  {
		    v31 = this->fields.camera;
		    if ( !v31 )
		      goto LABEL_118;
		    v32 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		    if ( !qword_18F36F100 )
		    {
		      v32 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		      if ( !v32 )
		      {
		        v78 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		        sub_18007E1B0(v78, 0LL);
		      }
		      qword_18F36F100 = (__int64)v32;
		    }
		    if ( !v32(v31) )
		    {
		      v33 = this->fields.camera;
		      if ( !v33 )
		        goto LABEL_118;
		      v34 = (__int64 (__fastcall *)(Camera *))qword_18F36F160;
		      if ( !qword_18F36F160 )
		      {
		        v34 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_usePhysicalProperties()");
		        if ( !v34 )
		        {
		          v79 = sub_1802EE1B8("UnityEngine.Camera::get_usePhysicalProperties()");
		          sub_18007E1B0(v79, 0LL);
		        }
		        qword_18F36F160 = (__int64)v34;
		      }
		      v35 = v34(v33);
		      v4 = (__int64)this->fields.camera;
		      if ( v35 )
		      {
		        if ( !v4 )
		          goto LABEL_118;
		        UnityEngine::Camera::get_focalLength((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        if ( !v4 )
		          goto LABEL_118;
		        sensorSize = UnityEngine::Camera::get_sensorSize((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v52 = sensorSize;
		        if ( !v4 )
		          goto LABEL_118;
		        lensShift = (Value_1 *)UnityEngine::Camera::get_lensShift((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v54 = lensShift;
		        if ( !v4 )
		          goto LABEL_118;
		        v55 = UnityEngine::Camera::get_nearClipPlane((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v56 = v55;
		        if ( !v4 )
		          goto LABEL_118;
		        gateFit = UnityEngine::Camera::get_gateFit((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v58 = gateFit;
		        if ( !v4 )
		          goto LABEL_118;
		        aspect = UnityEngine::Camera::get_aspect((Camera *)v4, 0LL);
		        v61 = (void (__fastcall *)(__int128 *, __int64, __int64 *, Value_1 **, _DWORD, _DWORD, _DWORD, Camera_GateFitMode__Enum))qword_18F371FF0;
		        evaluationStackBase = v54;
		        v85 = (__int64)v52;
		        if ( !qword_18F371FF0 )
		        {
		          v61 = (void (__fastcall *)(__int128 *, __int64, __int64 *, Value_1 **, _DWORD, _DWORD, _DWORD, Camera_GateFitMode__Enum))il2cpp_resolve_icall_1("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4&,System.Single,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,System.Single,System.Single,UnityEngine.Camera/GateFitMode)");
		          if ( !v61 )
		          {
		            v82 = sub_1802EE1B8(
		                    "UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Mat"
		                    "rix4x4&,System.Single,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Single,System.Single,System.S"
		                    "ingle,UnityEngine.Camera/GateFitMode)");
		            sub_18007E1B0(v82, 0LL);
		          }
		          qword_18F371FF0 = (__int64)v61;
		        }
		        v61(
		          &v94,
		          v59,
		          &v85,
		          &evaluationStackBase,
		          LODWORD(v56),
		          LODWORD(heightFogCullingFarClipPlane),
		          LODWORD(aspect),
		          v58);
		        v62 = this->fields.camera;
		        v63 = v94;
		        v64 = v95;
		        v65 = v96;
		        v66 = v97;
		        if ( !v62 )
		          goto LABEL_118;
		        v67 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		        memset(&v86, 0, sizeof(v86));
		        if ( !qword_18F36F220 )
		        {
		          v67 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Camera::get_worldToCameraMatrix_Injected(Unity"
		                                                              "Engine.Matrix4x4&)");
		          if ( !v67 )
		          {
		            v83 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v83, 0LL);
		          }
		          qword_18F36F220 = (__int64)v67;
		        }
		        v67(v62, &v86);
		        v48 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))qword_18F36FA50;
		        *(_OWORD *)&v93.m00 = v63;
		        v92 = v86;
		        *(_OWORD *)&v93.m01 = v64;
		        *(_OWORD *)&v93.m02 = v65;
		        *(_OWORD *)&v93.m03 = v66;
		        v87 = 0LL;
		        v88 = 0LL;
		        *(_OWORD *)topWriteBack = 0LL;
		        v90 = 0LL;
		        if ( !qword_18F36FA50 )
		        {
		          v48 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                             "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4F"
		                                                                             "ast_Injected(UnityEngine.Matrix4x4&,UnityEn"
		                                                                             "gine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		          if ( !v48 )
		          {
		            v84 = sub_1802EE1B8(
		                    "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4"
		                    "&,UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v84, 0LL);
		          }
		          qword_18F36FA50 = (__int64)v48;
		        }
		        v49 = &v92;
		        v50 = &v93;
		      }
		      else
		      {
		        if ( !v4 )
		          goto LABEL_118;
		        fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v37 = fieldOfView;
		        if ( !v4 )
		          goto LABEL_118;
		        v38 = UnityEngine::Camera::get_aspect((Camera *)v4, 0LL);
		        v4 = (__int64)this->fields.camera;
		        v39 = v38;
		        if ( !v4 )
		          goto LABEL_118;
		        v40 = UnityEngine::Camera::get_nearClipPlane((Camera *)v4, 0LL);
		        v41 = UnityEngine::Matrix4x4::Perspective(&v92, v37, v39, v40, heightFogCullingFarClipPlane, 0LL);
		        v42 = this->fields.camera;
		        v43 = *(_OWORD *)&v41->m00;
		        v44 = *(_OWORD *)&v41->m01;
		        v45 = *(_OWORD *)&v41->m02;
		        v46 = *(_OWORD *)&v41->m03;
		        if ( !v42 )
		          goto LABEL_118;
		        v47 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		        memset(&v86, 0, sizeof(v86));
		        if ( !qword_18F36F220 )
		        {
		          v47 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Camera::get_worldToCameraMatrix_Injected(Unity"
		                                                              "Engine.Matrix4x4&)");
		          if ( !v47 )
		          {
		            v80 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v80, 0LL);
		          }
		          qword_18F36F220 = (__int64)v47;
		        }
		        v47(v42, &v86);
		        v48 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))qword_18F36FA50;
		        *(_OWORD *)&v92.m00 = v43;
		        v93 = v86;
		        *(_OWORD *)&v92.m01 = v44;
		        *(_OWORD *)&v92.m02 = v45;
		        *(_OWORD *)&v92.m03 = v46;
		        v87 = 0LL;
		        v88 = 0LL;
		        *(_OWORD *)topWriteBack = 0LL;
		        v90 = 0LL;
		        if ( !qword_18F36FA50 )
		        {
		          v48 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                             "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4F"
		                                                                             "ast_Injected(UnityEngine.Matrix4x4&,UnityEn"
		                                                                             "gine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		          if ( !v48 )
		          {
		            v81 = sub_1802EE1B8(
		                    "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4"
		                    "&,UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v81, 0LL);
		          }
		          qword_18F36FA50 = (__int64)v48;
		        }
		        v49 = &v93;
		        v50 = &v92;
		      }
		      v48(v50, v49, &v87);
		      v68 = v88;
		      *(_OWORD *)&retstr->m00 = v87;
		      v69 = *(_OWORD *)topWriteBack;
		      *(__m128i *)&retstr->m01 = v68;
		      v10 = v90;
		      *(_OWORD *)&retstr->m02 = v69;
		      goto LABEL_16;
		    }
		  }
		  v70 = this->fields.camera;
		  if ( !v70 )
		    goto LABEL_118;
		  v71 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F1E8;
		  memset(&v86, 0, sizeof(v86));
		  if ( !qword_18F36F1E8 )
		  {
		    v71 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v71 )
		    {
		      v74 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v74, 0LL);
		    }
		    qword_18F36F1E8 = (__int64)v71;
		  }
		  v71(v70, &v86);
		  v72 = *(_OWORD *)&v86.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v86.m00;
		  v73 = *(_OWORD *)&v86.m02;
		  *(_OWORD *)&retstr->m01 = v72;
		  v10 = *(_OWORD *)&v86.m03;
		  *(_OWORD *)&retstr->m02 = v73;
		LABEL_16:
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v10;
		  return result;
		}
		
		public void SetForceJitterPhaseIdx(int idx) {} // 0x0000000189B73818-0x0000000189B73874
		// Void SetForceJitterPhaseIdx(Int32)
		void HG::Rendering::Runtime::HGCamera::SetForceJitterPhaseIdx(HGCamera *this, int32_t idx, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2844, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2844, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, idx, 0LL);
		  }
		  else
		  {
		    this->fields.m_ForceJitterIdx = idx;
		  }
		}
		
	}
}
