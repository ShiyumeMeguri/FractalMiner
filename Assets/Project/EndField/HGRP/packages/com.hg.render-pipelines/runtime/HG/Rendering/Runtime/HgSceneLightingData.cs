using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HgSceneLightingData : MonoBehaviour // TypeDefIndex: 37802
	{
		// Fields
		private const string MODULE_NAME = "[HG Scene Lighting Data]"; // Metadata: 0x02303128
		private const string LIT_DATA_GO_NAME = "!HgSceneLightingData"; // Metadata: 0x02303141
		[SerializeField]
		public List<MeshRenderer> meshRenderers; // 0x18
		[SerializeField]
		public List<Terrain> terrainRenderers; // 0x20
		[SerializeField]
		public List<MeshRenderer> hlodRenderers; // 0x28
		[SerializeField]
		[Space]
		public LightmapUsageInfo meshRendererLightmapUsageInfo; // 0x30
		[SerializeField]
		public LightmapUsageInfo terrainLightmapUsageInfo; // 0x38
		[SerializeField]
		public LightmapUsageInfo hlodLightmapUsageInfo; // 0x40
		[SerializeField]
		[Space]
		public List<HgLightmapData> lightmapData; // 0x48
		[HideInInspector]
		[SerializeField]
		public List<Renderer> dummyManualHlod; // 0x50
		[SerializeField]
		public List<Renderer> originalManualHlod; // 0x58
		[SerializeField]
		public List<HgChunkLightingData> chunkLightingData; // 0x60
	
		// Nested types
		[Serializable]
		public class LightmapUsageInfo // TypeDefIndex: 37799
		{
			// Fields
			[SerializeField]
			public List<int> lightmapIndex; // 0x10
			[SerializeField]
			public List<Vector4> lightmapScaleOffset; // 0x18
	
			// Constructors
			public LightmapUsageInfo() {} // 0x00000001841E1670-0x00000001841E1680
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
			public int AddInfo(int index, Vector4 scaleOffset) => default; // 0x0000000189D0FA98-0x0000000189D0FBD8
			// Int32 AddInfo(Int32, Vector4)
			int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::AddInfo(
			        HgSceneLightingData_LightmapUsageInfo *this,
			        int32_t index,
			        Vector4 *scaleOffset,
			        MethodInfo *method)
			{
			  __int64 v7; // rdx
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v8; // rax
			  void *lightmapIndex; // rcx
			  List_1_System_Int32_ *v10; // rdi
			  HGRuntimeGrassQuery_Node *v11; // rdx
			  HGRuntimeGrassQuery_Node *v12; // r8
			  Int32__Array **v13; // r9
			  LowLevelList_1_System_Object_ *v14; // rax
			  List_1_UnityEngine_Vector4_ *v15; // rdi
			  HGRuntimeGrassQuery_Node *v16; // rdx
			  HGRuntimeGrassQuery_Node *v17; // r8
			  Int32__Array **v18; // r9
			  List_1_System_Int32_ *v19; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *v22; // [rsp+20h] [rbp-28h]
			  Vector4 v23; // [rsp+30h] [rbp-18h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1988, 0LL) )
			  {
			    if ( !this->fields.lightmapIndex )
			    {
			      v8 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
			      v10 = (List_1_System_Int32_ *)v8;
			      if ( !v8 )
			        goto LABEL_13;
			      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			        v8,
			        MethodInfo::System::Collections::Generic::List<int>::List);
			      this->fields.lightmapIndex = v10;
			      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v11, v12, v13, v22);
			    }
			    lightmapIndex = this->fields.lightmapIndex;
			    if ( lightmapIndex )
			    {
			      sub_183081250(lightmapIndex, (unsigned int)index, MethodInfo::System::Collections::Generic::List<int>::Add);
			      if ( !this->fields.lightmapScaleOffset )
			      {
			        v14 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
			        v15 = (List_1_UnityEngine_Vector4_ *)v14;
			        if ( !v14 )
			          goto LABEL_13;
			        System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			          v14,
			          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
			        this->fields.lightmapScaleOffset = v15;
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.lightmapScaleOffset, v16, v17, v18, v22);
			      }
			      lightmapIndex = this->fields.lightmapScaleOffset;
			      if ( lightmapIndex )
			      {
			        v23 = *scaleOffset;
			        sub_183252A70(lightmapIndex, &v23, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			        v19 = this->fields.lightmapIndex;
			        if ( v19 )
			          return v19->fields._size - 1;
			      }
			    }
			LABEL_13:
			    sub_1800D8260(lightmapIndex, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1988, 0LL);
			  if ( !Patch )
			    goto LABEL_13;
			  v23 = *scaleOffset;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_802(Patch, (Object *)this, index, &v23, 0LL);
			}
			
			public int GetIndex(int index) => default; // 0x0000000189D0FCA0-0x0000000189D0FD1C
			// Int32 GetIndex(Int32)
			int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
			        HgSceneLightingData_LightmapUsageInfo *this,
			        int32_t index,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1984, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1984, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
			             (ILFixDynamicMethodWrapper_6 *)Patch,
			             (Object *)this,
			             (NaviDirection__Enum)index,
			             0LL);
			  }
			  else if ( this->fields.lightmapIndex && index < this->fields.lightmapIndex->fields._size )
			  {
			    return System::Collections::Generic::List<int>::get_Item(
			             this->fields.lightmapIndex,
			             index,
			             MethodInfo::System::Collections::Generic::List<int>::get_Item);
			  }
			  else
			  {
			    return -1;
			  }
			}
			
			public Vector4 GetScaleOffset(int index) => default; // 0x0000000189D0FD1C-0x0000000189D0FDD0
			// Vector4 GetScaleOffset(Int32)
			Vector4 *HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
			        Vector4 *__return_ptr retstr,
			        HgSceneLightingData_LightmapUsageInfo *this,
			        int32_t index,
			        MethodInfo *method)
			{
			  TileBase *v7; // rdx
			  Vector3Int *v8; // r8
			  ITilemap *v9; // r9
			  Vector4 v10; // xmm0
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  MethodInfo *v15; // [rsp+20h] [rbp-28h]
			  Vector4 v16; // [rsp+30h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1985, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1985, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_661(&v16, Patch, (Object *)this, index, 0LL);
			    goto LABEL_9;
			  }
			  if ( this->fields.lightmapScaleOffset && index < this->fields.lightmapScaleOffset->fields._size )
			  {
			    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
			      (ObjectTranslator_LuaCSFunctionPtr *)&v16,
			      (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.lightmapScaleOffset,
			      index,
			      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			    v10 = v16;
			LABEL_9:
			    *retstr = v10;
			    return retstr;
			  }
			  *retstr = *(Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			                          (TileAnimationData *)&v16,
			                          v7,
			                          v8,
			                          v9,
			                          v15);
			  return retstr;
			}
			
			public void Remove(int index) {} // 0x0000000189D0FDD0-0x0000000189D0FE54
			// Void Remove(Int32)
			void HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Remove(
			        HgSceneLightingData_LightmapUsageInfo *this,
			        int32_t index,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  List_1_System_UInt64_ *lightmapIndex; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1989, 0LL) )
			  {
			    lightmapIndex = (List_1_System_UInt64_ *)this->fields.lightmapIndex;
			    if ( lightmapIndex )
			    {
			      System::Collections::Generic::List<unsigned long>::RemoveAt(
			        lightmapIndex,
			        index,
			        MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
			      lightmapIndex = (List_1_System_UInt64_ *)this->fields.lightmapScaleOffset;
			      if ( lightmapIndex )
			      {
			        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
			          (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)lightmapIndex,
			          index,
			          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::RemoveAt);
			        return;
			      }
			    }
			LABEL_6:
			    sub_1800D8260(lightmapIndex, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1989, 0LL);
			  if ( !Patch )
			    goto LABEL_6;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, index, 0LL);
			}
			
			public void Clear() {} // 0x0000000189D0FBD8-0x0000000189D0FC44
			// Void Clear()
			void HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Clear(
			        HgSceneLightingData_LightmapUsageInfo *this,
			        MethodInfo *method)
			{
			  List_1_System_Int32_ *lightmapIndex; // rdx
			  List_1_UnityEngine_Vector4_ *lightmapScaleOffset; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1990, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1990, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    lightmapIndex = this->fields.lightmapIndex;
			    if ( lightmapIndex )
			    {
			      ++lightmapIndex->fields._version;
			      lightmapIndex->fields._size = 0;
			    }
			    lightmapScaleOffset = this->fields.lightmapScaleOffset;
			    if ( lightmapScaleOffset )
			    {
			      ++lightmapScaleOffset->fields._version;
			      lightmapScaleOffset->fields._size = 0;
			    }
			  }
			}
			
			public int Count() => default; // 0x0000000189D0FC44-0x0000000189D0FCA0
			// Int32 Count()
			int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Count(
			        HgSceneLightingData_LightmapUsageInfo *this,
			        MethodInfo *method)
			{
			  List_1_System_Int32_ *lightmapIndex; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1991, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1991, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    LODWORD(lightmapIndex) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			                               (ILFixDynamicMethodWrapper_31 *)Patch,
			                               (Object *)this,
			                               0LL);
			  }
			  else
			  {
			    lightmapIndex = this->fields.lightmapIndex;
			    if ( lightmapIndex )
			      LODWORD(lightmapIndex) = lightmapIndex->fields._size;
			  }
			  return (int)lightmapIndex;
			}
			
		}
	
		[Serializable]
		public class HgLightmapData // TypeDefIndex: 37800
		{
			// Fields
			public Texture2D color; // 0x10
			public Texture2D shadowmask; // 0x18
			public Texture2D directional; // 0x20
	
			// Properties
			public LightmapData UnityLightmapData { get => default; } // 0x0000000189D08D60-0x0000000189D08DF4 
			// LightmapData get_UnityLightmapData()
			LightmapData *HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::get_UnityLightmapData(
			        HgSceneLightingData_HgLightmapData *this,
			        MethodInfo *method)
			{
			  SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *v3; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			  ValueWatcher_1_System_Single_ *v6; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1987, 0LL) )
			  {
			    v3 = (SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *)sub_18002C620(TypeInfo::UnityEngine::LightmapData);
			    v6 = (ValueWatcher_1_System_Single_ *)v3;
			    if ( v3 )
			    {
			      System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
			        v3,
			        (SortedList_2_System_Object_System_Object_ *)this->fields.color,
			        0LL);
			      Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
			        v6,
			        (Func_1_Single_ *)this->fields.shadowmask,
			        0LL);
			      Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
			        (ValueWatcher_1_System_Boolean_ *)v6,
			        (Func_1_Boolean_ *)this->fields.directional,
			        0LL);
			      return (LightmapData *)v6;
			    }
			LABEL_5:
			    sub_1800D8260(v5, v4);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1987, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_801(Patch, (Object *)this, 0LL);
			}
			
	
			// Constructors
			public HgLightmapData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
			public HgLightmapData(LightmapData unityLmData) {} // 0x0000000189D08D58-0x0000000189D08D60
			// HgSceneLightingData+HgLightmapData(LightmapData)
			void HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::HgLightmapData(
			        HgSceneLightingData_HgLightmapData *this,
			        LightmapData *unityLmData,
			        MethodInfo *method)
			{
			  HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::Assign(this, unityLmData, 0LL);
			}
			
	
			// Methods
			public void Assign(LightmapData unityLmData) {} // 0x0000000189D08C54-0x0000000189D08CE4
			// Void Assign(LightmapData)
			void HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::Assign(
			        HgSceneLightingData_HgLightmapData *this,
			        LightmapData *unityLmData,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v5; // rdx
			  __int64 v6; // rcx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *v16; // [rsp+20h] [rbp-8h]
			  MethodInfo *v17; // [rsp+20h] [rbp-8h]
			  MethodInfo *v18; // [rsp+20h] [rbp-8h]
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1992, 0LL) )
			  {
			    if ( unityLmData )
			    {
			      this->fields.color = unityLmData->fields.m_Light;
			      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v5, v7, v8, v16);
			      this->fields.shadowmask = unityLmData->fields.m_ShadowMask;
			      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowmask, v9, v10, v11, v17);
			      this->fields.directional = unityLmData->fields.m_Dir;
			      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.directional, v12, v13, v14, v18);
			      return;
			    }
			LABEL_5:
			    sub_1800D8260(v6, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1992, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			    (ILFixDynamicMethodWrapper_39 *)Patch,
			    (Object *)this,
			    (Object *)unityLmData,
			    0LL);
			}
			
			public static HgLightmapData CreateFromUnityLightmapData(LightmapData unityLmData) => default; // 0x0000000189D08CE4-0x0000000189D08D58
			// HgSceneLightingData+HgLightmapData CreateFromUnityLightmapData(LightmapData)
			HgSceneLightingData_HgLightmapData *HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::CreateFromUnityLightmapData(
			        LightmapData *unityLmData,
			        MethodInfo *method)
			{
			  HgSceneLightingData_HgLightmapData *v3; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			  HgSceneLightingData_HgLightmapData *v6; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1993, 0LL) )
			  {
			    v3 = (HgSceneLightingData_HgLightmapData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData);
			    v6 = v3;
			    if ( v3 )
			    {
			      HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::Assign(v3, unityLmData, 0LL);
			      return v6;
			    }
			LABEL_5:
			    sub_1800D8260(v5, v4);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1993, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_803(Patch, (Object *)unityLmData, 0LL);
			}
			
		}
	
		public class HgChunkLightingData // TypeDefIndex: 37801
		{
			// Fields
			public float x; // 0x10
			public float z; // 0x14
			public float size; // 0x18
			public List<Renderer> renderers; // 0x20
			public List<List<int>> groupIndex; // 0x28
			public int lightmapCount; // 0x30
	
			// Constructors
			public HgChunkLightingData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HgSceneLightingData() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		internal static string Log(string msg, UnityEngine.LogType type = UnityEngine.LogType.Log /* Metadata: 0x02303127 */) => default; // 0x0000000189D0900C-0x0000000189D09098
		// String Log(String, LogType)
		String *HG::Rendering::Runtime::HgSceneLightingData::Log(String *msg, LogType__Enum type, MethodInfo *method)
		{
		  char *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1979, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1979, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		             (ILFixDynamicMethodWrapper_26 *)Patch,
		             (Object *)msg,
		             type,
		             0LL);
		  }
		  else
		  {
		    if ( type == LogType__Enum_Log )
		    {
		      v5 = "<color=white><b>[HG Scene Lighting Data]";
		    }
		    else if ( type == LogType__Enum_Warning )
		    {
		      v5 = "<color=yellow><b>[HG Scene Lighting Data]";
		    }
		    else
		    {
		      v5 = "<color=red><b>[HG Scene Lighting Data]";
		    }
		    return System::String::Concat((String *)v5, msg, (String *)"</b></color>", 0LL);
		  }
		}
		
		public static HgSceneLightingData GetSceneFirstActiveData() => default; // 0x0000000189D08EF4-0x0000000189D0900C
		// HgSceneLightingData GetSceneFirstActiveData()
		HgSceneLightingData *HG::Rendering::Runtime::HgSceneLightingData::GetSceneFirstActiveData(MethodInfo *method)
		{
		  Object__Array *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Object__Array *v4; // rdi
		  int32_t i; // ebx
		  Component *v6; // rsi
		  GameObject *gameObject; // rax
		  GameObject *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1980, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1980, 0LL);
		    if ( !Patch )
		LABEL_19:
		      sub_1800D8260(v3, v2);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_799(Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    v1 = UnityEngine::Object::FindObjectsOfType<System::Object>(MethodInfo::UnityEngine::Object::FindObjectsOfType<HG::Rendering::Runtime::HgSceneLightingData>);
		    v4 = v1;
		    if ( v1 && v1->max_length.value )
		    {
		      for ( i = 0; i < v4->max_length.size; ++i )
		      {
		        if ( (unsigned int)i >= v4->max_length.size )
		          sub_1800D2AB0(v3, v2);
		        v6 = (Component *)v4->vector[i];
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( !UnityEngine::Object::op_Equality((Object_1 *)v6, 0LL, 0LL) )
		        {
		          if ( !v6 )
		            goto LABEL_19;
		          if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)v6, 0LL) )
		          {
		            gameObject = UnityEngine::Component::get_gameObject(v6, 0LL);
		            if ( !gameObject )
		              goto LABEL_19;
		            if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
		            {
		              v8 = UnityEngine::Component::get_gameObject(v6, 0LL);
		              if ( !v8 )
		                goto LABEL_19;
		              if ( UnityEngine::GameObject::get_activeSelf(v8, 0LL) )
		                return (HgSceneLightingData *)v6;
		            }
		          }
		        }
		      }
		    }
		    return 0LL;
		  }
		}
		
		public static GameObject CreateLightingDataGameobject() => default; // 0x0000000189D08DF4-0x0000000189D08E70
		// GameObject CreateLightingDataGameobject()
		GameObject *HG::Rendering::Runtime::HgSceneLightingData::CreateLightingDataGameobject(MethodInfo *method)
		{
		  GameObject *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  GameObject *v4; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1981, 0LL) )
		  {
		    v1 = (GameObject *)sub_18002C620(TypeInfo::UnityEngine::GameObject);
		    v4 = v1;
		    if ( v1 )
		    {
		      UnityEngine::GameObject::GameObject(v1, (String *)"!HgSceneLightingData", 0LL);
		      UnityEngine::GameObject::AddComponent<System::Object>(
		        v4,
		        MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HgSceneLightingData>);
		      return v4;
		    }
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1981, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_800(Patch, 0LL);
		}
		
		public static GameObject GetOrCreateLightingData() => default; // 0x0000000189D08E70-0x0000000189D08EF4
		// GameObject GetOrCreateLightingData()
		GameObject *HG::Rendering::Runtime::HgSceneLightingData::GetOrCreateLightingData(MethodInfo *method)
		{
		  Object_1 *SceneFirstActiveData; // rbx
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1982, 0LL) )
		  {
		    SceneFirstActiveData = (Object_1 *)HG::Rendering::Runtime::HgSceneLightingData::GetSceneFirstActiveData(0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(SceneFirstActiveData, 0LL, 0LL) )
		      return HG::Rendering::Runtime::HgSceneLightingData::CreateLightingDataGameobject(0LL);
		    if ( SceneFirstActiveData )
		      return UnityEngine::Component::get_gameObject((Component *)SceneFirstActiveData, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1982, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_800(Patch, 0LL);
		}
		
		public void SetupScene() {} // 0x0000000189D091B4-0x0000000189D095D0
		// Void SetupScene()
		void HG::Rendering::Runtime::HgSceneLightingData::SetupScene(HgSceneLightingData *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t i; // esi
		  List_1_UnityEngine_MeshRenderer_ *meshRenderers; // rax
		  Object *Item; // r14
		  HgSceneLightingData_LightmapUsageInfo *meshRendererLightmapUsageInfo; // r15
		  int32_t Index; // r12d
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __m128i v12; // xmm6
		  int32_t j; // esi
		  List_1_UnityEngine_Terrain_ *terrainRenderers; // rax
		  Object *v15; // r14
		  HgSceneLightingData_LightmapUsageInfo *terrainLightmapUsageInfo; // r15
		  int32_t v17; // r12d
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __m128i v20; // xmm6
		  int32_t k; // esi
		  List_1_UnityEngine_MeshRenderer_ *hlodRenderers; // rax
		  Object *v23; // r14
		  HgSceneLightingData_LightmapUsageInfo *hlodLightmapUsageInfo; // r15
		  int32_t v25; // r12d
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __m128i v28; // xmm6
		  Object *v29; // rbx
		  __int64 v30; // rcx
		  Il2CppExceptionWrapper *v31; // rdx
		  String *v32; // rbx
		  String *v33; // rax
		  String *v34; // rax
		  Object *v35; // rbx
		  __int64 v36; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Il2CppExceptionWrapper *v38; // rdi
		  Il2CppClass *klass; // rbx
		  __int64 v40; // rax
		  Il2CppExceptionWrapper v41; // [rsp+20h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v42[2]; // [rsp+28h] [rbp-60h] BYREF
		  int v43; // [rsp+38h] [rbp-50h]
		  __m128i v44; // [rsp+40h] [rbp-48h] BYREF
		  Vector4 v45; // [rsp+50h] [rbp-38h] BYREF
		
		  v43 = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1983, 0LL) )
		  {
		    try
		    {
		      if ( this->fields.meshRenderers && this->fields.meshRenderers->fields._size > 0 )
		      {
		        for ( i = 0; ; ++i )
		        {
		          meshRenderers = this->fields.meshRenderers;
		          if ( !meshRenderers )
		            sub_1800D8260(v4, v3);
		          if ( i >= meshRenderers->fields._size )
		            break;
		          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                   (List_1_System_Object_ *)this->fields.meshRenderers,
		                   i,
		                   MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Item);
		          meshRendererLightmapUsageInfo = this->fields.meshRendererLightmapUsageInfo;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Equality((Object_1 *)Item, 0LL, 0LL) )
		          {
		            if ( !meshRendererLightmapUsageInfo )
		              sub_1800D8260(v4, v3);
		            Index = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
		                      meshRendererLightmapUsageInfo,
		                      i,
		                      0LL);
		            v12 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
		                                                     &v45,
		                                                     meshRendererLightmapUsageInfo,
		                                                     i,
		                                                     0LL));
		            if ( !Item )
		              sub_1800D8260(v11, v10);
		            UnityEngine::Renderer::SetLightmapIndex((Renderer *)Item, Index, LightmapType__Enum_StaticLightmap, 0LL);
		            v44 = v12;
		            UnityEngine::Renderer::set_lightmapScaleOffset((Renderer *)Item, (Vector4 *)&v44, 0LL);
		          }
		        }
		      }
		      if ( this->fields.terrainRenderers && this->fields.terrainRenderers->fields._size > 0 )
		      {
		        for ( j = 0; ; ++j )
		        {
		          terrainRenderers = this->fields.terrainRenderers;
		          if ( !terrainRenderers )
		            sub_1800D8260(v4, v3);
		          if ( j >= terrainRenderers->fields._size )
		            break;
		          v15 = System::Collections::Generic::List<System::Object>::get_Item(
		                  (List_1_System_Object_ *)this->fields.terrainRenderers,
		                  j,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::Terrain>::get_Item);
		          terrainLightmapUsageInfo = this->fields.terrainLightmapUsageInfo;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Equality((Object_1 *)v15, 0LL, 0LL) )
		          {
		            if ( !terrainLightmapUsageInfo )
		              sub_1800D8260(v4, v3);
		            v17 = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
		                    terrainLightmapUsageInfo,
		                    j,
		                    0LL);
		            v20 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
		                                                     &v45,
		                                                     terrainLightmapUsageInfo,
		                                                     j,
		                                                     0LL));
		            if ( !v15 )
		              sub_1800D8260(v19, v18);
		            UnityEngine::Terrain::set_lightmapIndex((Terrain *)v15, v17, 0LL);
		            v44 = v20;
		            UnityEngine::Terrain::set_lightmapScaleOffset((Terrain *)v15, (Vector4 *)&v44, 0LL);
		          }
		        }
		      }
		      if ( this->fields.hlodRenderers && this->fields.hlodRenderers->fields._size > 0 )
		      {
		        for ( k = 0; ; ++k )
		        {
		          hlodRenderers = this->fields.hlodRenderers;
		          if ( !hlodRenderers )
		            sub_1800D8260(v4, v3);
		          if ( k >= hlodRenderers->fields._size )
		            break;
		          v23 = System::Collections::Generic::List<System::Object>::get_Item(
		                  (List_1_System_Object_ *)this->fields.hlodRenderers,
		                  k,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Item);
		          hlodLightmapUsageInfo = this->fields.hlodLightmapUsageInfo;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Equality((Object_1 *)v23, 0LL, 0LL) )
		          {
		            if ( !hlodLightmapUsageInfo )
		              sub_1800D8260(v4, v3);
		            v25 = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
		                    hlodLightmapUsageInfo,
		                    k,
		                    0LL);
		            v28 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
		                                                     &v45,
		                                                     hlodLightmapUsageInfo,
		                                                     k,
		                                                     0LL));
		            if ( !v23 )
		              sub_1800D8260(v27, v26);
		            UnityEngine::Renderer::SetLightmapIndex((Renderer *)v23, v25, LightmapType__Enum_StaticLightmap, 0LL);
		            v44 = v28;
		            UnityEngine::Renderer::set_lightmapScaleOffset((Renderer *)v23, (Vector4 *)&v44, 0LL);
		          }
		        }
		      }
		      HG::Rendering::Runtime::HgSceneLightingData::SetSceneLightmapData(this, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v42 )
		    {
		      v38 = v42[0];
		      klass = v42[0]->ex->object.klass;
		      v40 = sub_18007E180(&TypeInfo::System::Exception);
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v40, klass) )
		      {
		        v41.ex = v38->ex;
		        throw &v41;
		      }
		      v42[++v43] = (Il2CppExceptionWrapper *)v38->ex;
		      v30 = v43 - 1;
		      v31 = v42[v30 + 1];
		      if ( v31 )
		      {
		        v32 = (String *)sub_180032CB0(5LL, v31);
		        v33 = (String *)sub_18007E180(&off_18E358788);
		        v34 = System::String::Concat(v33, v32, 0LL);
		        v35 = (Object *)HG::Rendering::Runtime::HgSceneLightingData::Log(v34, LogType__Enum_Error, 0LL);
		        v36 = sub_18007E180(&TypeInfo::UnityEngine::Debug);
		        sub_1800036A0(v36);
		        UnityEngine::Debug::LogError(v35, 0LL);
		        return;
		      }
		LABEL_47:
		      sub_1800D8260(v30, v31);
		    }
		    v29 = (Object *)HG::Rendering::Runtime::HgSceneLightingData::Log(
		                      (String *)"Setup scene: [OK]. ",
		                      LogType__Enum_Log,
		                      0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::Log(v29, 0LL);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1983, 0LL);
		  if ( !Patch )
		    goto LABEL_47;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetSceneLightmapData() {} // 0x0000000189D09098-0x0000000189D091B4
		// Void SetSceneLightmapData()
		void HG::Rendering::Runtime::HgSceneLightingData::SetSceneLightmapData(HgSceneLightingData *this, MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_HgSceneLightingData_HgLightmapData_ *lightmapData; // rax
		  __int64 v4; // rdx
		  List_1_System_Object_ *v5; // rcx
		  LightmapData__Array *v6; // rdi
		  int32_t v7; // esi
		  Object *Item; // rax
		  LightmapData *UnityLightmapData; // rax
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Object *v13; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1986, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1986, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(v5, v4);
		  }
		  if ( !this->fields.lightmapData || (lightmapData = this->fields.lightmapData, !lightmapData->fields._size) )
		  {
		    v13 = (Object *)HG::Rendering::Runtime::HgSceneLightingData::Log(
		                      (String *)"LightmapData is null",
		                      LogType__Enum_Warning,
		                      0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::LogWarning(v13, 0LL);
		    return;
		  }
		  v6 = (LightmapData__Array *)il2cpp_array_new_specific_1(
		                                TypeInfo::UnityEngine::LightmapData,
		                                (unsigned int)lightmapData->fields._size);
		  v7 = 0;
		  if ( !v6 )
		    goto LABEL_14;
		  while ( v7 < v6->max_length.size )
		  {
		    v5 = (List_1_System_Object_ *)this->fields.lightmapData;
		    if ( !v5 )
		      goto LABEL_14;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             v5,
		             v7,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData>::get_Item);
		    if ( !Item )
		      goto LABEL_14;
		    UnityLightmapData = HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::get_UnityLightmapData(
		                          (HgSceneLightingData_HgLightmapData *)Item,
		                          0LL);
		    if ( (unsigned int)v7 >= v6->max_length.size )
		      sub_1800D2AB0(v7, v10);
		    v6->vector[v7] = UnityLightmapData;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v6->vector[v7++], v10, v11, v12, v15);
		  }
		  UnityEngine::LightmapSettings::set_lightmaps(v6, 0LL);
		}
		
	}
}
