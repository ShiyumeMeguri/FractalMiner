using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGWaterManager // TypeDefIndex: 38787
	{
		// Fields
		public const int INVALID_MATERIAL_INDEX = -1; // Metadata: 0x023044A2
		public const int MAX_STATIC_WATER_TYPES = 32; // Metadata: 0x023044A3
		public const int MAX_DYNAMIC_WATER_TYPES = 32; // Metadata: 0x023044A4
		public const int MAX_NUM_WATER_TYPES = 64; // Metadata: 0x023044A5
		public const int WATER_DEFAULT_TEXTURE_SIZE = 2; // Metadata: 0x023044A7
		public const int WATER_RIPPLE_DATA_VECTOR4_COUNT = 20; // Metadata: 0x023044A8
		public const int WATER_GPU_DATA_PARAMS_START = 10; // Metadata: 0x023044A9
		public const int WATER_GPU_DATA_MATERIAL_START = 18; // Metadata: 0x023044AA
		public const int WATER_GPU_DATA_MATERIAL_VECTOR4_COUNT = 20; // Metadata: 0x023044AB
		public const int WATER_GPU_DATA_VECTOR4_COUNT = 1298; // Metadata: 0x023044AC
		private int m_validGlobalConfigIndex; // 0x10
		private List<HGWaterGlobalConfig> m_globalConfigs; // 0x18
		public bool forceHideWater; // 0x20
		private bool enableOrthographicRender; // 0x21
		private bool m_shouldStoreDepth; // 0x22
		private HGWaterConfig[] m_waterConfigs; // 0x28
		public NativeArray<Vector4> waterRippleData; // 0x30
		public NativeArray<Vector4> waterGPUData; // 0x40
		public NativeArray<Vector4> defaultWaterMaterialData; // 0x50
		private readonly HGWaterConfigOverrideController m_waterConfigOverrideController; // 0x60
		private Mesh m_screenSpaceMesh; // 0x68
		public HGWaterInteractiveSetting m_hgWaterInteractiveSetting; // 0x70
		public const float RIPPLE_SIMULATION_RANGE = 32f; // Metadata: 0x023044AE
		private bool m_shouldRenderRipple; // 0x78
		private bool m_isRippleInputEmpty; // 0x79
		private RippleDataManager m_RippleDataManager; // 0x80
		private float m_terrainRippleOpacity; // 0x88
		private const float RIPPLE_SIZE_CHANGE_SPEED = 5000f; // Metadata: 0x023044B2
		private bool m_isPlayerOnBoat; // 0x8C
		private bool m_isBoatStop; // 0x8D
		private bool m_isPlayerInWater; // 0x8E
		private List<InputRippleData> m_rawRippleDataList; // 0x90
		private InputRippleData m_centerRippleData; // 0x98
		private InputRippleData m_lastCenterRippleData; // 0xAC
		private const int RIPPLE_LIST_MAX_SIZE = 8; // Metadata: 0x023044B6
		private const int RIPPLE_SIMULATION_SIZE = 12; // Metadata: 0x023044B7
		private const float characterSpeedSizeInfluence = 0.04f; // Metadata: 0x023044B8
		private const float sizeRandomInfluence = 0.04f; // Metadata: 0x023044BC
		private float m_lerpStartTimeTime; // 0xC0
		private bool m_isOnLerpProcedural; // 0xC4
		private float m_terrainRippleStrength; // 0xC8
		private float m_terrainRippleNormalStrength; // 0xCC
		private const float boatRippleRandomSize = 0.02f; // Metadata: 0x023044C0
		private const float boatRippleRandomSizeSpeed = 10f; // Metadata: 0x023044C4
		private const int kReadbackLayerCount = 4; // Metadata: 0x023044C8
		public const int kMaxReadbackWorldPositions = 8; // Metadata: 0x023044C9
		private readonly List<WaterReadbackRequest> m_ReadbackRequests; // 0xD0
		private const int kReadbackRectsCount = 4; // Metadata: 0x023044CA
		private const int kReadbackParamsCount = 12; // Metadata: 0x023044CB
		private readonly Dictionary<int, HGWaterReadbackOutputManaged> m_ReadbackResults; // 0xD8
		private readonly List<int> m_StaleReadbackKeys; // 0xE0
	
		// Properties
		public HGWaterGlobalConfig globalConfig { get => default; } // 0x0000000183106130-0x00000001831061D0 
		// HGWaterGlobalConfig get_globalConfig()
		HGWaterGlobalConfig *HG::Rendering::Runtime::HGWaterManager::get_globalConfig(HGWaterManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rcx
		  __int64 m_validGlobalConfigIndex; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size <= 994 )
		    goto LABEL_7;
		  if ( !items->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = items->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size <= 0x3E2u )
		    goto LABEL_14;
		  if ( !wrapperArray[27].vector[22] )
		  {
		LABEL_7:
		    if ( !this->fields.m_globalConfigs
		      || this->fields.m_validGlobalConfigIndex < 0
		      || this->fields.m_validGlobalConfigIndex >= this->fields.m_globalConfigs->fields._size )
		    {
		      return 0LL;
		    }
		    m_globalConfigs = this->fields.m_globalConfigs;
		    m_validGlobalConfigIndex = this->fields.m_validGlobalConfigIndex;
		    if ( (unsigned int)m_validGlobalConfigIndex >= m_globalConfigs->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = (struct ILFixDynamicMethodWrapper_2__Class *)m_globalConfigs->fields._items;
		    if ( items )
		    {
		      if ( (unsigned int)m_validGlobalConfigIndex < LODWORD(items->_0.namespaze) )
		        return (HGWaterGlobalConfig *)*((_QWORD *)&items->_0.byval_arg.data.dummy + m_validGlobalConfigIndex);
		LABEL_14:
		      sub_1800D2AB0(items, wrapperArray);
		    }
		LABEL_13:
		    sub_1800D8260(items, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(994, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_388(Patch, (Object *)this, 0LL);
		}
		
		public bool shouldRender { get => default; } // 0x00000001831CA860-0x00000001831CABF0 
		// Boolean get_shouldRender()
		bool HG::Rendering::Runtime::HGWaterManager::get_shouldRender(HGWaterManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  unsigned __int64 wrapperArray; // rcx
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rcx
		  __int64 m_validGlobalConfigIndex; // rax
		  HGWaterGlobalConfig *v7; // rdi
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *v9; // rcx
		  __int64 v10; // rax
		  Object *v11; // rdi
		  Object__Class *klass; // rsi
		  Object__Class *v13; // rax
		  const PropertyInfo *properties; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v15; // r8
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterGlobalConfig *v18; // rax
		  ILFixDynamicMethodWrapper_2__Array *v19; // r8
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  HGWaterGlobalConfig *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (unsigned __int64)v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_61;
		  if ( *(int *)(wrapperArray + 24) <= 993 )
		    goto LABEL_95;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v15 = v2->static_fields->wrapperArray;
		  if ( !v15 )
		    goto LABEL_61;
		  if ( v15->max_length.size <= 0x3E1u )
		    goto LABEL_62;
		  if ( !v15[27].vector[21] )
		  {
		LABEL_95:
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (unsigned __int64)v2->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_61;
		    if ( *(int *)(wrapperArray + 24) <= 994 )
		      goto LABEL_11;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (unsigned __int64)v2->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_61;
		    if ( *(_DWORD *)(wrapperArray + 24) <= 0x3E2u )
		      goto LABEL_62;
		    if ( *(_QWORD *)(wrapperArray + 7984) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(994, 0LL);
		      if ( !Patch )
		        goto LABEL_61;
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_388(Patch, (Object *)this, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      v7 = v18;
		    }
		    else
		    {
		LABEL_11:
		      if ( this->fields.m_globalConfigs
		        && this->fields.m_validGlobalConfigIndex >= 0
		        && this->fields.m_validGlobalConfigIndex < this->fields.m_globalConfigs->fields._size )
		      {
		        m_globalConfigs = this->fields.m_globalConfigs;
		        m_validGlobalConfigIndex = this->fields.m_validGlobalConfigIndex;
		        if ( (unsigned int)m_validGlobalConfigIndex >= m_globalConfigs->fields._size )
		          goto LABEL_92;
		        wrapperArray = (unsigned __int64)m_globalConfigs->fields._items;
		        if ( !wrapperArray )
		          goto LABEL_61;
		        if ( (unsigned int)m_validGlobalConfigIndex >= *(_DWORD *)(wrapperArray + 24) )
		          goto LABEL_62;
		        v7 = *(HGWaterGlobalConfig **)(wrapperArray + 8 * m_validGlobalConfigIndex + 32);
		      }
		      else
		      {
		        v7 = 0LL;
		      }
		    }
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v7 )
		      return 0;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v7->fields._._._._.m_CachedPtr )
		      return 0;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (unsigned __int64)v2->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_61;
		    if ( *(int *)(wrapperArray + 24) > 994 )
		    {
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v19 = v2->static_fields->wrapperArray;
		      if ( !v19 )
		        goto LABEL_61;
		      if ( v19->max_length.size <= 0x3E2u )
		        goto LABEL_62;
		      if ( v19[27].vector[22] )
		      {
		        v20 = IFix::WrappersManagerImpl::GetPatch(994, 0LL);
		        if ( !v20 )
		          goto LABEL_61;
		        v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_388(v20, (Object *)this, 0LL);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        v11 = (Object *)v21;
		LABEL_36:
		        if ( !v11 )
		          goto LABEL_61;
		        if ( !v2->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v2);
		          v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        wrapperArray = (unsigned __int64)v2->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          goto LABEL_61;
		        if ( *(int *)(wrapperArray + 24) <= 995 )
		          goto LABEL_41;
		        if ( !v2->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v2);
		          v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2->static_fields->wrapperArray;
		        if ( !v2 )
		          goto LABEL_61;
		        if ( LODWORD(v2->_0.namespaze) > 0x3E3 )
		        {
		          if ( v2[21]._0.generic_class )
		          {
		            v22 = IFix::WrappersManagerImpl::GetPatch(995, 0LL);
		            if ( v22 )
		            {
		              if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v22, v11, 0LL) )
		                return 0;
		              return !this->fields.forceHideWater;
		            }
		LABEL_61:
		            sub_1800D8260(wrapperArray, v2);
		          }
		LABEL_41:
		          klass = v11[3].klass;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !klass )
		            return 0;
		          wrapperArray = (unsigned __int64)TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !klass->_0.name )
		            return 0;
		          v13 = v11[3].klass;
		          if ( v13 )
		          {
		            properties = v13->_0.properties;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( !properties )
		              return 0;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( !properties->get )
		              return 0;
		            return !this->fields.forceHideWater;
		          }
		          goto LABEL_61;
		        }
		LABEL_62:
		        sub_1800D2AB0(wrapperArray, v2);
		      }
		    }
		    if ( !this->fields.m_globalConfigs )
		      goto LABEL_61;
		    if ( this->fields.m_validGlobalConfigIndex < 0 )
		      goto LABEL_61;
		    wrapperArray = (unsigned int)this->fields.m_validGlobalConfigIndex;
		    if ( (int)wrapperArray >= this->fields.m_globalConfigs->fields._size )
		      goto LABEL_61;
		    v9 = this->fields.m_globalConfigs;
		    v10 = this->fields.m_validGlobalConfigIndex;
		    if ( (unsigned int)v10 < v9->fields._size )
		    {
		      wrapperArray = (unsigned __int64)v9->fields._items;
		      if ( !wrapperArray )
		        goto LABEL_61;
		      if ( (unsigned int)v10 >= *(_DWORD *)(wrapperArray + 24) )
		        goto LABEL_62;
		      v11 = *(Object **)(wrapperArray + 8 * v10 + 32);
		      goto LABEL_36;
		    }
		LABEL_92:
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  }
		  v16 = IFix::WrappersManagerImpl::GetPatch(993, 0LL);
		  if ( !v16 )
		    goto LABEL_61;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v16, (Object *)this, 0LL);
		}
		
		public bool EnableOrthographicRender { get => default; set {} } // 0x0000000189C64170-0x0000000189C641BC 0x0000000189C6420C-0x0000000189C64264
		// Boolean get_EnableOrthographicRender()
		bool HG::Rendering::Runtime::HGWaterManager::get_EnableOrthographicRender(HGWaterManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5352, 0LL) )
		    return this->fields.enableOrthographicRender;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5352, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_EnableOrthographicRender(Boolean)
		void HG::Rendering::Runtime::HGWaterManager::set_EnableOrthographicRender(
		        HGWaterManager *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5353, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5353, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.enableOrthographicRender = value;
		  }
		}
		
		public bool shouldStoreDepth { get => default; set {} } // 0x0000000183E6E780-0x0000000183E6E7E0 0x0000000183E6E740-0x0000000183E6E780
		// Boolean get_shouldStoreDepth()
		bool HG::Rendering::Runtime::HGWaterManager::get_shouldStoreDepth(HGWaterManager *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1050 )
		    return this->fields.m_shouldStoreDepth;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x41A )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[22]._0.nestedTypes )
		    return this->fields.m_shouldStoreDepth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1050, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_shouldStoreDepth(Boolean)
		void HG::Rendering::Runtime::HGWaterManager::set_shouldStoreDepth(HGWaterManager *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5354, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5354, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_shouldStoreDepth = value;
		  }
		}
		
		public Mesh screenSpaceMesh { get => default; } // 0x0000000183D9DC30-0x0000000183D9DD50 
		// Mesh get_screenSpaceMesh()
		Mesh *HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(HGWaterManager *this, MethodInfo *method)
		{
		  Mesh *v3; // rcx
		  __int64 v4; // rax
		  struct Object_1__Class *v5; // rcx
		  Mesh *m_screenSpaceMesh; // rdi
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  v3 = (Mesh *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (Mesh *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *(_QWORD *)v3[7].fields._.m_CachedPtr;
		  if ( !v4 )
		    goto LABEL_14;
		  if ( *(int *)(v4 + 24) <= 1054 )
		    goto LABEL_5;
		  if ( !LODWORD(v3[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (Mesh *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = *(Mesh **)v3[7].fields._.m_CachedPtr;
		  if ( !v3 )
		    goto LABEL_14;
		  if ( LODWORD(v3[1].klass) <= 0x41E )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[352].fields._.m_CachedPtr )
		  {
		LABEL_5:
		    v5 = TypeInfo::UnityEngine::Object;
		    m_screenSpaceMesh = this->fields.m_screenSpaceMesh;
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
		    if ( m_screenSpaceMesh )
		    {
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v5);
		      if ( m_screenSpaceMesh->fields._.m_CachedPtr )
		        return this->fields.m_screenSpaceMesh;
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::WaterSettings->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::WaterSettings);
		    this->fields.m_screenSpaceMesh = HG::Rendering::Runtime::WaterSettings::CreateQuad(16, 16, 0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_screenSpaceMesh, v8, v9, v10, v12);
		    v3 = this->fields.m_screenSpaceMesh;
		    if ( v3 )
		    {
		      UnityEngine::Mesh::UploadMeshData(v3, 1, 0LL);
		      return this->fields.m_screenSpaceMesh;
		    }
		LABEL_14:
		    sub_1800D8260(v3, method);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1054, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, (Object *)this, 0LL);
		}
		
		public bool IsRippleInputEmpty { get => default; } // 0x0000000183333050-0x00000001833330B0 
		// Boolean get_IsRippleInputEmpty()
		bool HG::Rendering::Runtime::HGWaterManager::get_IsRippleInputEmpty(HGWaterManager *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 2312 )
		    return this->fields.m_isRippleInputEmpty;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x908 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[49]._0.typeMetadataHandle )
		    return this->fields.m_isRippleInputEmpty;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2312, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool IsPlayerOnBoat { get => default; set {} } // 0x0000000189C641BC-0x0000000189C6420C 0x0000000189C64264-0x0000000189C642C0
		// Boolean get_IsPlayerOnBoat()
		bool HG::Rendering::Runtime::HGWaterManager::get_IsPlayerOnBoat(HGWaterManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5361, 0LL) )
		    return this->fields.m_isPlayerOnBoat;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5361, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_IsPlayerOnBoat(Boolean)
		void HG::Rendering::Runtime::HGWaterManager::set_IsPlayerOnBoat(HGWaterManager *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5362, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5362, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_isPlayerOnBoat = value;
		  }
		}
		
		public Vector2 CenterPosition { get => default; } // 0x0000000183D522C0-0x0000000183D52330 
		// Vector2 get_CenterPosition()
		Vector2 HG::Rendering::Runtime::HGWaterManager::get_CenterPosition(HGWaterManager *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 936 )
		    return (Vector2)_mm_unpacklo_ps(
		                      (__m128)LODWORD(this->fields.m_centerRippleData.positionXZ.x),
		                      (__m128)LODWORD(this->fields.m_centerRippleData.positionXZ.y)).m128_u64[0];
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3A8 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[20]._0.image )
		    return (Vector2)_mm_unpacklo_ps(
		                      (__m128)LODWORD(this->fields.m_centerRippleData.positionXZ.x),
		                      (__m128)LODWORD(this->fields.m_centerRippleData.positionXZ.y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(936, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(Patch, (Object *)this, 0LL);
		}
		
		public float TerrainRippleNormalStrength { get => default; } // 0x0000000183EC93C0-0x0000000183EC9420 
		// Single get_TerrainRippleNormalStrength()
		float HG::Rendering::Runtime::HGWaterManager::get_TerrainRippleNormalStrength(HGWaterManager *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 937 )
		    return this->fields.m_terrainRippleNormalStrength;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3A9 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[20]._0.gc_desc )
		    return this->fields.m_terrainRippleNormalStrength;
		  Patch = IFix::WrappersManagerImpl::GetPatch(937, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public struct WaterReadbackRequest // TypeDefIndex: 38785
		{
			// Fields
			public int cameraInstanceID; // 0x00
			public HGWaterReadbackFlag flags; // 0x04
			public Vector4 readbackRect; // 0x08
			public NativeArray<Vector4> worldPositions; // 0x18
		}
	
		public class HGWaterReadbackOutputManaged // TypeDefIndex: 38786
		{
			// Fields
			public HGWaterReadbackData[] heightData; // 0x10
			public HGWaterReadbackData[] heightNormal; // 0x18
			public HGWaterReadbackData[] heightDepth; // 0x20
			public HGWaterReadbackData[] decalDisplacement; // 0x28
			public HGWaterReadbackData[] heightBuffer; // 0x30
			public Matrix4x4 orthoDeviceViewProj; // 0x38
			public Matrix4x4 orthoDeviceInvViewProj; // 0x78
			public bool aliveThisFrame; // 0xB8
			public NativeArray<byte>[] tempDataArrays; // 0xC0
	
			// Constructors
			public HGWaterReadbackOutputManaged() {} // 0x0000000184CCED60-0x0000000184CCEE30
			// HGWaterManager+HGWaterReadbackOutputManaged()
			void HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged::HGWaterReadbackOutputManaged(
			        HGWaterManager_HGWaterReadbackOutputManaged *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  HGRuntimeGrassQuery_Node *v18; // rdx
			  HGRuntimeGrassQuery_Node *v19; // r8
			  Int32__Array **v20; // r9
			  MethodInfo *v21; // [rsp+20h] [rbp-8h]
			  MethodInfo *v22; // [rsp+20h] [rbp-8h]
			  MethodInfo *v23; // [rsp+20h] [rbp-8h]
			  MethodInfo *v24; // [rsp+20h] [rbp-8h]
			  MethodInfo *v25; // [rsp+20h] [rbp-8h]
			  MethodInfo *v26; // [rsp+50h] [rbp+28h]
			
			  this->fields.heightData = (HGWaterReadbackData__Array *)il2cpp_array_new_specific_1(
			                                                            TypeInfo::UnityEngine::HyperGryphEngineCode::HGWaterReadbackData,
			                                                            4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v21);
			  this->fields.heightNormal = (HGWaterReadbackData__Array *)il2cpp_array_new_specific_1(
			                                                              TypeInfo::UnityEngine::HyperGryphEngineCode::HGWaterReadbackData,
			                                                              4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.heightNormal, v6, v7, v8, v22);
			  this->fields.heightDepth = (HGWaterReadbackData__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::HyperGryphEngineCode::HGWaterReadbackData,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.heightDepth, v9, v10, v11, v23);
			  this->fields.decalDisplacement = (HGWaterReadbackData__Array *)il2cpp_array_new_specific_1(
			                                                                   TypeInfo::UnityEngine::HyperGryphEngineCode::HGWaterReadbackData,
			                                                                   4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.decalDisplacement, v12, v13, v14, v24);
			  this->fields.heightBuffer = (HGWaterReadbackData__Array *)il2cpp_array_new_specific_1(
			                                                              TypeInfo::UnityEngine::HyperGryphEngineCode::HGWaterReadbackData,
			                                                              4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.heightBuffer, v15, v16, v17, v25);
			  this->fields.tempDataArrays = (NativeArray_1_System_Byte___Array *)il2cpp_array_new_specific_1(
			                                                                       TypeInfo::Unity::Collections::NativeArray<unsigned char>,
			                                                                       20LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.tempDataArrays, v18, v19, v20, v26);
			}
			
	
			// Methods
			public void Dispose() {} // 0x0000000189C642C0-0x0000000189C64380
			// Void Dispose()
			void HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged::Dispose(
			        HGWaterManager_HGWaterReadbackOutputManaged *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  NativeArray_1_System_Byte___Array *v4; // rcx
			  int32_t i; // edi
			  NativeArray_1_System_Byte___Array *tempDataArrays; // rax
			  MethodInfo *v7; // rbx
			  NativeArray_1_UnityEngine_Vector4_ *v8; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(2266, 0LL) )
			  {
			    for ( i = 0; ; ++i )
			    {
			      tempDataArrays = this->fields.tempDataArrays;
			      if ( !tempDataArrays )
			        break;
			      if ( i >= tempDataArrays->max_length.size )
			        return;
			      if ( *(_QWORD *)sub_180002100(this->fields.tempDataArrays, i) )
			      {
			        v4 = this->fields.tempDataArrays;
			        if ( !v4 )
			          break;
			        v7 = MethodInfo::Unity::Collections::NativeArray<unsigned char>::Dispose;
			        v8 = (NativeArray_1_UnityEngine_Vector4_ *)sub_180002100(v4, i);
			        Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(v8, v7);
			        v4 = this->fields.tempDataArrays;
			        if ( !v4 )
			          break;
			        *(_OWORD *)sub_180002100(v4, i) = 0LL;
			      }
			    }
			LABEL_11:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(2266, 0LL);
			  if ( !Patch )
			    goto LABEL_11;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
		}
	
		// Constructors
		public HGWaterManager() {} // 0x0000000182ED70E0-0x0000000182ED74F0
		// HGWaterManager()
		void HG::Rendering::Runtime::HGWaterManager::HGWaterManager(HGWaterManager *this, MethodInfo *method)
		{
		  HGWaterConfigOverrideController *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGWaterConfigOverrideController *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v10; // rax
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v11; // rbx
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v15; // rax
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *v16; // rbx
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  Dictionary_2_System_Int32_System_Object_ *v20; // rax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWaterManager_HGWaterReadbackOutputManaged_ *v21; // rbx
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
		  List_1_System_Int32_ *v26; // rbx
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v30; // rax
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *v31; // rbx
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  __int64 v35; // rsi
		  HGRuntimeGrassQuery_Node *v36; // rdx
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  NativeArray_1_UnityEngine_Vector4_ v39; // xmm0
		  RippleDataManager *v40; // rax
		  RippleDataManager *v41; // rbx
		  HGRuntimeGrassQuery_Node *v42; // rdx
		  HGRuntimeGrassQuery_Node *v43; // r8
		  Int32__Array **v44; // r9
		  __m128i si128; // xmm2
		  __int64 v46; // rbx
		  __m128i v47; // xmm1
		  __m128i v48; // xmm0
		  __m128i v49; // xmm1
		  __m128i v50; // xmm0
		  __m128i v51; // xmm1
		  __m128i v52; // xmm0
		  __m128i v53; // xmm1
		  __m128i v54; // xmm0
		  __m128i v55; // xmm1
		  __m128i v56; // xmm0
		  __m128i v57; // xmm0
		  __m128i v58; // xmm1
		  NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm6
		  struct MethodInfo *v60; // rcx
		  Void *m_Buffer; // rbp
		  NativeArray_1_UnityEngine_Vector4_ defaultWaterMaterialData; // xmm6
		  Void *v63; // rbp
		  MethodInfo *methoda; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-38h]
		  MethodInfo *methode; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodf; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodh; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodg; // [rsp+20h] [rbp-38h]
		  NativeArray_1_UnityEngine_Vector4_ v72; // [rsp+30h] [rbp-28h] BYREF
		
		  this->fields.m_validGlobalConfigIndex = -1;
		  this->fields.m_shouldStoreDepth = 1;
		  v3 = (HGWaterConfigOverrideController *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWaterConfigOverrideController);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGWaterConfigOverrideController::HGWaterConfigOverrideController(v3, 0LL);
		  this->fields.m_waterConfigOverrideController = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_waterConfigOverrideController, v7, v8, v9, methoda);
		  v10 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
		  v11 = (List_1_HG_Rendering_Runtime_InputRippleData_ *)v10;
		  if ( !v10 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
		  this->fields.m_rawRippleDataList = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_rawRippleDataList, v12, v13, v14, methodb);
		  this->fields.m_lerpStartTimeTime = -1.0;
		  v15 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterManager::WaterReadbackRequest>);
		  v16 = (List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *)v15;
		  if ( !v15 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		    v15,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterManager::WaterReadbackRequest>::List);
		  this->fields.m_ReadbackRequests = v16;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_ReadbackRequests, v17, v18, v19, methodc);
		  v20 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>);
		  v21 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWaterManager_HGWaterReadbackOutputManaged_ *)v20;
		  if ( !v20 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v20,
		    MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::Dictionary);
		  this->fields.m_ReadbackResults = v21;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_ReadbackResults, v22, v23, v24, methodd);
		  v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v26 = (List_1_System_Int32_ *)v25;
		  if ( !v25 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v25,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_StaleReadbackKeys = v26;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_StaleReadbackKeys, v27, v28, v29, methode);
		  v30 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>);
		  v31 = (List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *)v30;
		  if ( !v30 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v30,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::List);
		  this->fields.m_globalConfigs = v31;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_globalConfigs, v32, v33, v34, methodf);
		  v35 = 64LL;
		  this->fields.m_waterConfigs = (HGWaterConfig__Array *)il2cpp_array_new_specific_1(
		                                                          TypeInfo::HG::Rendering::Runtime::HGWaterConfig,
		                                                          64LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_waterConfigs, v36, v37, v38, methodh);
		  v72 = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v72,
		    20,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  this->fields.waterRippleData = v72;
		  v72 = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v72,
		    1298,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  v39 = v72;
		  *(_WORD *)&this->fields.m_isPlayerOnBoat = 0;
		  this->fields.waterGPUData = v39;
		  v40 = (RippleDataManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::RippleDataManager);
		  v41 = v40;
		  if ( !v40 )
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::RippleDataManager::RippleDataManager(v40, 8, 0LL);
		  this->fields.m_RippleDataManager = v41;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_RippleDataManager, v42, v43, v44, methodg);
		  v72 = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v72,
		    20,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		  v46 = 288LL;
		  v47 = _mm_load_si128((const __m128i *)&xmmword_18B9591D0);
		  this->fields.defaultWaterMaterialData = v72;
		  v48 = _mm_load_si128((const __m128i *)&xmmword_18B9591B0);
		  *(__m128i *)this->fields.defaultWaterMaterialData.m_Buffer = v47;
		  v49 = _mm_load_si128((const __m128i *)&xmmword_18B959120);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[16] = si128;
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[32] = si128;
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[48] = si128;
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[64] = v48;
		  v50 = _mm_load_si128((const __m128i *)&xmmword_18B9591A0);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[80] = v49;
		  v51 = _mm_load_si128((const __m128i *)&xmmword_18B959190);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[96] = v50;
		  v52 = _mm_load_si128((const __m128i *)&xmmword_18B959180);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[112] = v51;
		  v53 = _mm_load_si128((const __m128i *)&xmmword_18B959150);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[128] = v52;
		  v54 = _mm_load_si128((const __m128i *)&xmmword_18B959170);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[144] = v53;
		  v55 = _mm_load_si128((const __m128i *)&xmmword_18B959130);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[160] = v54;
		  v56 = _mm_load_si128((const __m128i *)&xmmword_18B959140);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[176] = si128;
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[192] = v56;
		  v57 = _mm_load_si128((const __m128i *)&xmmword_18B959160);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[208] = v55;
		  v58 = _mm_load_si128((const __m128i *)&xmmword_18B9591C0);
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[224] = v57;
		  *(__m128i *)&this->fields.defaultWaterMaterialData.m_Buffer[240] = v58;
		  do
		  {
		    waterGPUData = this->fields.waterGPUData;
		    v60 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		    {
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      v60 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		    }
		    m_Buffer = waterGPUData.m_Buffer;
		    defaultWaterMaterialData = this->fields.defaultWaterMaterialData;
		    v63 = &m_Buffer[v46];
		    if ( !v60->rgctx_data )
		      sub_1800430B0(v60);
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v63, defaultWaterMaterialData.m_Buffer, 320LL, 0LL);
		    v46 += 320LL;
		    --v35;
		  }
		  while ( v35 );
		}
		
	
		// Methods
		[IDTag(0)]
		public bool SetWaterConfigOverride(int materialIndex, HGWaterConfig targetConfig, float lerpFactor) => default; // 0x0000000189C64038-0x0000000189C640D0
		// Boolean SetWaterConfigOverride(Int32, HGWaterConfig, Single)
		bool HG::Rendering::Runtime::HGWaterManager::SetWaterConfigOverride(
		        HGWaterManager *this,
		        int32_t materialIndex,
		        HGWaterConfig *targetConfig,
		        float lerpFactor,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  HGWaterConfigOverrideController *m_waterConfigOverrideController; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5355, 0LL) )
		  {
		    m_waterConfigOverrideController = this->fields.m_waterConfigOverrideController;
		    if ( m_waterConfigOverrideController )
		      return HG::Rendering::Runtime::HGWaterConfigOverrideController::SetOverride(
		               m_waterConfigOverrideController,
		               materialIndex,
		               targetConfig,
		               lerpFactor,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_waterConfigOverrideController, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5355, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1547(
		           Patch,
		           (Object *)this,
		           materialIndex,
		           (Object *)targetConfig,
		           lerpFactor,
		           0LL);
		}
		
		[IDTag(1)]
		public bool SetWaterConfigOverride(int materialIndex, HGWaterConfig targetConfig) => default; // 0x0000000189C63FB4-0x0000000189C64038
		// Boolean SetWaterConfigOverride(Int32, HGWaterConfig)
		bool HG::Rendering::Runtime::HGWaterManager::SetWaterConfigOverride(
		        HGWaterManager *this,
		        int32_t materialIndex,
		        HGWaterConfig *targetConfig,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5356, 0LL) )
		    return HG::Rendering::Runtime::HGWaterManager::SetWaterConfigOverride(this, materialIndex, targetConfig, 1.0, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(5356, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(
		           (ILFixDynamicMethodWrapper_6 *)Patch,
		           (Object *)this,
		           materialIndex,
		           (Object *)targetConfig,
		           0LL);
		}
		
		public bool SetWaterConfigOverrideFactor(int materialIndex, float lerpFactor) => default; // 0x0000000189C63F34-0x0000000189C63FB4
		// Boolean SetWaterConfigOverrideFactor(Int32, Single)
		bool HG::Rendering::Runtime::HGWaterManager::SetWaterConfigOverrideFactor(
		        HGWaterManager *this,
		        int32_t materialIndex,
		        float lerpFactor,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  HGWaterConfigOverrideController *m_waterConfigOverrideController; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5357, 0LL) )
		  {
		    m_waterConfigOverrideController = this->fields.m_waterConfigOverrideController;
		    if ( m_waterConfigOverrideController )
		      return HG::Rendering::Runtime::HGWaterConfigOverrideController::SetOverrideFactor(
		               m_waterConfigOverrideController,
		               materialIndex,
		               lerpFactor,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_waterConfigOverrideController, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5357, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1548(Patch, (Object *)this, materialIndex, lerpFactor, 0LL);
		}
		
		public bool ClearWaterConfigOverride(int materialIndex) => default; // 0x0000000189C637E4-0x0000000189C6384C
		// Boolean ClearWaterConfigOverride(Int32)
		bool HG::Rendering::Runtime::HGWaterManager::ClearWaterConfigOverride(
		        HGWaterManager *this,
		        int32_t materialIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWaterConfigOverrideController *m_waterConfigOverrideController; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5358, 0LL) )
		  {
		    m_waterConfigOverrideController = this->fields.m_waterConfigOverrideController;
		    if ( m_waterConfigOverrideController )
		      return HG::Rendering::Runtime::HGWaterConfigOverrideController::ClearOverride(
		               m_waterConfigOverrideController,
		               materialIndex,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_waterConfigOverrideController, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5358, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		           (ILFixDynamicMethodWrapper_13 *)Patch,
		           (Object *)this,
		           (NaviDirection__Enum)materialIndex,
		           0LL);
		}
		
		internal void Initialize(HGRenderPipelineRuntimeResources resource) {} // 0x0000000184CDE030-0x0000000184CDE090
		// Void Initialize(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGWaterManager::Initialize(
		        HGWaterManager *this,
		        HGRenderPipelineRuntimeResources *resource,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  __int64 v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5359, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5359, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)resource,
		      0LL);
		  }
		  else
		  {
		    if ( !resource || (assets = resource->fields.assets) == 0LL )
		LABEL_4:
		      sub_1800D8260(v6, v5);
		    this->fields.m_hgWaterInteractiveSetting = assets->fields.waterInteractiveSetting;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_hgWaterInteractiveSetting, v5, v7, v8, v11);
		  }
		}
		
		public void EarlyUpdate() {} // 0x0000000183335DF0-0x0000000183335FC0
		// Void EarlyUpdate()
		void HG::Rendering::Runtime::HGWaterManager::EarlyUpdate(HGWaterManager *this, MethodInfo *method)
		{
		  __int64 m_rawRippleDataList; // rcx
		  HGWaterManager_WaterReadbackRequest__Array *items; // rdx
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *m_ReadbackRequests; // rax
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *v7; // rax
		  __int128 v8; // xmm1
		  int32_t v9; // ecx
		  ILFixDynamicMethodWrapper_2 *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_Vector4_ v12; // [rsp+38h] [rbp-20h] BYREF
		
		  m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		  if ( !items )
		    goto LABEL_29;
		  if ( items->max_length.size > 2287 )
		  {
		    if ( !*(_DWORD *)(m_rawRippleDataList + 224) )
		    {
		      il2cpp_runtime_class_init_1(m_rawRippleDataList);
		      m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		    if ( !items )
		      goto LABEL_29;
		    if ( items->max_length.size <= 0x8EFu )
		      goto LABEL_30;
		    if ( *(_QWORD *)&items[13].vector[31].cameraInstanceID )
		    {
		      v9 = 2287;
		      goto LABEL_37;
		    }
		  }
		  if ( !*(_DWORD *)(m_rawRippleDataList + 224) )
		  {
		    il2cpp_runtime_class_init_1(m_rawRippleDataList);
		    m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		  if ( !items )
		    goto LABEL_29;
		  if ( items->max_length.size <= 2288 )
		    goto LABEL_9;
		  if ( !*(_DWORD *)(m_rawRippleDataList + 224) )
		  {
		    il2cpp_runtime_class_init_1(m_rawRippleDataList);
		    m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		  if ( !items )
		    goto LABEL_29;
		  if ( items->max_length.size <= 0x8F0u )
		    goto LABEL_30;
		  if ( *(_QWORD *)&items[13].vector[31].readbackRect.x )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2288, 0LL);
		    if ( !Patch )
		      goto LABEL_29;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_9:
		    m_rawRippleDataList = (__int64)this->fields.m_rawRippleDataList;
		    if ( !m_rawRippleDataList )
		      goto LABEL_29;
		    ++*(_DWORD *)(m_rawRippleDataList + 28);
		    *(_DWORD *)(m_rawRippleDataList + 24) = 0;
		  }
		  m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		  if ( !items )
		    goto LABEL_29;
		  if ( items->max_length.size <= 2289 )
		    goto LABEL_15;
		  if ( !*(_DWORD *)(m_rawRippleDataList + 224) )
		  {
		    il2cpp_runtime_class_init_1(m_rawRippleDataList);
		    m_rawRippleDataList = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  items = **(HGWaterManager_WaterReadbackRequest__Array ***)(m_rawRippleDataList + 184);
		  if ( !items )
		LABEL_29:
		    sub_1800D8260(m_rawRippleDataList, items);
		  if ( items->max_length.size <= 0x8F1u )
		LABEL_30:
		    sub_1800D2AB0(m_rawRippleDataList, items);
		  if ( *(_QWORD *)&items[13].vector[31].readbackRect.z )
		  {
		    v9 = 2289;
		LABEL_37:
		    v10 = IFix::WrappersManagerImpl::GetPatch(v9, 0LL);
		    if ( v10 )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v10, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_29;
		  }
		LABEL_15:
		  for ( i = 0; ; ++i )
		  {
		    m_ReadbackRequests = this->fields.m_ReadbackRequests;
		    if ( !m_ReadbackRequests )
		      goto LABEL_29;
		    if ( i >= m_ReadbackRequests->fields._size )
		      break;
		    if ( (unsigned int)i >= m_ReadbackRequests->fields._size )
		      goto LABEL_52;
		    items = m_ReadbackRequests->fields._items;
		    if ( !items )
		      goto LABEL_29;
		    if ( (unsigned int)i >= items->max_length.size )
		      goto LABEL_30;
		    m_rawRippleDataList = 5LL * i;
		    *(_QWORD *)&v12.m_Length = *(_QWORD *)&items->vector[i].worldPositions.m_Length;
		    if ( items->vector[i].worldPositions.m_Buffer )
		    {
		      v7 = this->fields.m_ReadbackRequests;
		      if ( !v7 )
		        goto LABEL_29;
		      if ( (unsigned int)i >= v7->fields._size )
		LABEL_52:
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = v7->fields._items;
		      if ( !items )
		        goto LABEL_29;
		      if ( (unsigned int)i >= items->max_length.size )
		        goto LABEL_30;
		      v8 = *(_OWORD *)&items->vector[i].readbackRect.z;
		      *(_QWORD *)&v12.m_Length = *(_QWORD *)&items->vector[i].worldPositions.m_Length;
		      v12.m_Buffer = (Void *)*((_QWORD *)&v8 + 1);
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &v12,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    }
		  }
		  ++m_ReadbackRequests->fields._version;
		  m_ReadbackRequests->fields._size = 0;
		}
		
		public void PipelineUpdate() {} // 0x00000001831C8990-0x00000001831C8D00
		// Void PipelineUpdate()
		void HG::Rendering::Runtime::HGWaterManager::PipelineUpdate(HGWaterManager *this, MethodInfo *method)
		{
		  unsigned __int64 m_validGlobalConfigIndex; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rdi
		  HGWaterGlobalConfig__Array *items; // rdi
		  HGWaterGlobalConfig *v7; // rdi
		  struct Object_1__Class *v8; // rcx
		  Object *globalConfig; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v10; // rax
		  Object__Class *klass; // rax
		  String *namespaze; // rdi
		  unsigned __int8 (__fastcall *v13)(String *); // rax
		  HGWaterGlobalConfig *v14; // rax
		  String *scenePath; // r12
		  HGWaterGlobalConfig *v16; // rax
		  int32_t sectorNum; // r15d
		  HGWaterGlobalConfig *v18; // rax
		  int32_t sectorSize; // r14d
		  HGWaterGlobalConfig *v20; // rax
		  int32_t sectorCoordsMin; // ebp
		  HGWaterGlobalConfig *v22; // rax
		  int32_t sectorCoordsMax; // esi
		  HGWaterGlobalConfig *v24; // rax
		  Int64__Array *sectorDataGUIDs; // rdi
		  HGWaterGlobalConfig *v26; // rax
		  Boolean__Array *sectorDataExists; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v29; // rax
		  ILFixDynamicMethodWrapper_2 *v30; // rax
		
		  m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(ILFixDynamicMethodWrapper_2__StaticFields ***)(m_validGlobalConfigIndex + 184);
		  if ( !static_fields )
		    goto LABEL_41;
		  if ( SLODWORD(static_fields[3].wrapperArray) > 2300 )
		  {
		    if ( !*(_DWORD *)(m_validGlobalConfigIndex + 224) )
		    {
		      il2cpp_runtime_class_init_1(m_validGlobalConfigIndex);
		      m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = **(ILFixDynamicMethodWrapper_2__StaticFields ***)(m_validGlobalConfigIndex + 184);
		    if ( !static_fields )
		      goto LABEL_41;
		    if ( LODWORD(static_fields[3].wrapperArray) <= 0x8FC )
		      goto LABEL_44;
		    if ( static_fields[2304].wrapperArray )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2300, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_41;
		    }
		  }
		  HG::Rendering::Runtime::HGWaterManager::MarkReadbackResultsStale(this, 0LL);
		  HG::Rendering::Runtime::HGWaterManager::UpdateWaterCPUAndGPUData(this, 0LL);
		  HG::Rendering::Runtime::HGWaterManager::SetRippleDataToRenderPipeLine(this, 0LL);
		  m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(ILFixDynamicMethodWrapper_2__StaticFields ***)(m_validGlobalConfigIndex + 184);
		  if ( !static_fields )
		    goto LABEL_41;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 994 )
		    goto LABEL_70;
		  if ( !*(_DWORD *)(m_validGlobalConfigIndex + 224) )
		  {
		    il2cpp_runtime_class_init_1(m_validGlobalConfigIndex);
		    m_validGlobalConfigIndex = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = **(ILFixDynamicMethodWrapper_2__StaticFields ***)(m_validGlobalConfigIndex + 184);
		  if ( !static_fields )
		    goto LABEL_41;
		  if ( LODWORD(static_fields[3].wrapperArray) <= 0x3E2 )
		    goto LABEL_44;
		  if ( static_fields[998].wrapperArray )
		  {
		    v29 = IFix::WrappersManagerImpl::GetPatch(994, 0LL);
		    if ( !v29 )
		      goto LABEL_41;
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_388(v29, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_70:
		    if ( this->fields.m_globalConfigs
		      && this->fields.m_validGlobalConfigIndex >= 0
		      && (m_validGlobalConfigIndex = (unsigned int)this->fields.m_validGlobalConfigIndex,
		          (int)m_validGlobalConfigIndex < this->fields.m_globalConfigs->fields._size) )
		    {
		      m_globalConfigs = this->fields.m_globalConfigs;
		      if ( (unsigned int)m_validGlobalConfigIndex >= m_globalConfigs->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = m_globalConfigs->fields._items;
		      if ( !items )
		        goto LABEL_41;
		      if ( (unsigned int)m_validGlobalConfigIndex >= items->max_length.size )
		        goto LABEL_44;
		      v7 = items->vector[(int)m_validGlobalConfigIndex];
		    }
		    else
		    {
		      v7 = 0LL;
		    }
		  }
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v8 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v8 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v7 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v8);
		    if ( v7->fields._._._._.m_CachedPtr )
		    {
		      globalConfig = (Object *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		      if ( !globalConfig )
		        goto LABEL_41;
		      v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = v10->static_fields;
		      m_validGlobalConfigIndex = (unsigned __int64)static_fields->wrapperArray;
		      if ( !static_fields->wrapperArray )
		        goto LABEL_41;
		      if ( *(int *)(m_validGlobalConfigIndex + 24) <= 2315 )
		        goto LABEL_27;
		      if ( !v10->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v10);
		        v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      m_validGlobalConfigIndex = (unsigned __int64)v10->static_fields->wrapperArray;
		      if ( !m_validGlobalConfigIndex )
		        goto LABEL_41;
		      if ( *(_DWORD *)(m_validGlobalConfigIndex + 24) > 0x90Bu )
		      {
		        if ( *(_QWORD *)(m_validGlobalConfigIndex + 18552) )
		        {
		          v30 = IFix::WrappersManagerImpl::GetPatch(2315, 0LL);
		          if ( !v30 )
		            goto LABEL_41;
		          namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                        (ILFixDynamicMethodWrapper_26 *)v30,
		                        globalConfig,
		                        0LL);
		          goto LABEL_29;
		        }
		LABEL_27:
		        klass = globalConfig[3].klass;
		        if ( !klass || (namespaze = (String *)klass->_0.namespaze) == 0LL )
		          namespaze = (String *)"";
		LABEL_29:
		        v13 = (unsigned __int8 (__fastcall *)(String *))qword_18F370A50;
		        if ( !qword_18F370A50 )
		        {
		          v13 = (unsigned __int8 (__fastcall *)(String *))sub_180059EA0(
		                                                            "UnityEngine.HyperGryph.HGWaterRender::CheckNewHGWaterGloablC"
		                                                            "onfigCPP(System.String)");
		          qword_18F370A50 = (__int64)v13;
		        }
		        if ( !v13(namespaze) )
		          return;
		        v14 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		        if ( v14 )
		        {
		          scenePath = HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(v14, 0LL);
		          v16 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		          if ( v16 )
		          {
		            sectorNum = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(v16, 0LL);
		            v18 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		            if ( v18 )
		            {
		              sectorSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(v18, 0LL);
		              v20 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		              if ( v20 )
		              {
		                sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v20, 0LL);
		                v22 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		                if ( v22 )
		                {
		                  sectorCoordsMax = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(v22, 0LL);
		                  v24 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		                  if ( v24 )
		                  {
		                    sectorDataGUIDs = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataAssetHashes(v24, 0LL);
		                    v26 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		                    if ( v26 )
		                    {
		                      sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(v26, 0LL);
		                      UnityEngine::HyperGryph::HGWaterRender::UpdateHGWaterGloablConfigCPP(
		                        scenePath,
		                        sectorNum,
		                        sectorSize,
		                        sectorCoordsMin,
		                        sectorCoordsMax,
		                        sectorDataGUIDs,
		                        sectorDataExists,
		                        0LL);
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_41:
		        sub_1800D8260(m_validGlobalConfigIndex, static_fields);
		      }
		LABEL_44:
		      sub_1800D2AB0(m_validGlobalConfigIndex, static_fields);
		    }
		  }
		}
		
		public void Release() {} // 0x0000000189C63C90-0x0000000189C63D28
		// Void Release()
		void HG::Rendering::Runtime::HGWaterManager::Release(HGWaterManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2264, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2264, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields.waterRippleData.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.waterRippleData,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.waterGPUData.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.waterGPUData,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.defaultWaterMaterialData.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.defaultWaterMaterialData,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    HG::Rendering::Runtime::HGWaterManager::DisposeReadbackResults(this, 0LL);
		  }
		}
		
		private void UpdateWaterGlobalConfigValidIndex() {} // 0x0000000183C52BC0-0x0000000183C52C40
		// Void UpdateWaterGlobalConfigValidIndex()
		void HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(
		        HGWaterManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_HGWaterGlobalConfig_ *m_globalConfigs; // rax
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5344, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5344, 0LL);
		    if ( !Patch )
		LABEL_9:
		      sub_1800D8260(v4, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_validGlobalConfigIndex = -1;
		    for ( i = 0; ; ++i )
		    {
		      m_globalConfigs = this->fields.m_globalConfigs;
		      if ( !m_globalConfigs )
		        goto LABEL_9;
		      if ( i >= m_globalConfigs->fields._size )
		        return;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               (List_1_System_Object_ *)this->fields.m_globalConfigs,
		               i,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::get_Item);
		      if ( !Item )
		        goto LABEL_9;
		      if ( HG::Rendering::Runtime::HGWaterGlobalConfig::ShouldRenderWater((HGWaterGlobalConfig *)Item, 0LL) )
		        break;
		    }
		    this->fields.m_validGlobalConfigIndex = i;
		  }
		}
		
		public void AddWaterGlobalConfig(HGWaterGlobalConfig globalConfig) {} // 0x0000000183C52B40-0x0000000183C52BC0
		// Void AddWaterGlobalConfig(HGWaterGlobalConfig)
		void HG::Rendering::Runtime::HGWaterManager::AddWaterGlobalConfig(
		        HGWaterManager *this,
		        HGWaterGlobalConfig *globalConfig,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_globalConfigs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5343, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5343, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)globalConfig,
		        0LL);
		      return;
		    }
		    goto LABEL_7;
		  }
		  m_globalConfigs = (List_1_System_Object_ *)this->fields.m_globalConfigs;
		  if ( !m_globalConfigs )
		    goto LABEL_7;
		  if ( System::Collections::Generic::List<System::Object>::Contains(
		         m_globalConfigs,
		         (Object *)globalConfig,
		         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains) )
		  {
		    return;
		  }
		  m_globalConfigs = (List_1_System_Object_ *)this->fields.m_globalConfigs;
		  if ( !m_globalConfigs )
		LABEL_7:
		    sub_1800D8260(m_globalConfigs, v5);
		  sub_182F01190(m_globalConfigs, (Object *)globalConfig);
		  HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(this, 0LL);
		}
		
		public void RemoveWaterGlobalConfig(HGWaterGlobalConfig globalConfig) {} // 0x0000000189C63D28-0x0000000189C63DBC
		// Void RemoveWaterGlobalConfig(HGWaterGlobalConfig)
		void HG::Rendering::Runtime::HGWaterManager::RemoveWaterGlobalConfig(
		        HGWaterManager *this,
		        HGWaterGlobalConfig *globalConfig,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_globalConfigs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5348, 0LL) )
		  {
		    m_globalConfigs = (List_1_System_Object_ *)this->fields.m_globalConfigs;
		    if ( m_globalConfigs )
		    {
		      if ( !System::Collections::Generic::List<System::Object>::Contains(
		              m_globalConfigs,
		              (Object *)globalConfig,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Contains) )
		        return;
		      m_globalConfigs = (List_1_System_Object_ *)this->fields.m_globalConfigs;
		      if ( m_globalConfigs )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          m_globalConfigs,
		          (Object *)globalConfig,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterGlobalConfig>::Remove);
		        HG::Rendering::Runtime::HGWaterManager::UpdateWaterGlobalConfigValidIndex(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_globalConfigs, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5348, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)globalConfig,
		    0LL);
		}
		
		public void UpdateWaterCPUAndGPUData() {} // 0x00000001831CA170-0x00000001831CA6F0
		// Void UpdateWaterCPUAndGPUData()
		void HG::Rendering::Runtime::HGWaterManager::UpdateWaterCPUAndGPUData(HGWaterManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  int *wrapperArray; // rdx
		  HGWaterGlobalConfig *globalConfig; // rax
		  TileBase *v6; // rdx
		  Vector3Int *v7; // r8
		  ITilemap *v8; // r9
		  struct Object_1__Class *v9; // rcx
		  HGWaterGlobalConfig *v10; // rdi
		  HGWaterGlobalConfig *v11; // rax
		  Texture2D *flowMap; // rax
		  struct Object_1__Class *v13; // rcx
		  Texture2D *v14; // rdi
		  int v15; // esi
		  HGWaterGlobalConfig *v16; // rax
		  Texture2D *v17; // rax
		  int v18; // r14d
		  HGWaterGlobalConfig *v19; // rax
		  Texture2DArray *normalMapArray; // rax
		  struct Object_1__Class *v21; // rcx
		  Texture2DArray *v22; // rdi
		  HGWaterGlobalConfig *v23; // rax
		  Texture2DArray *v24; // rax
		  int v25; // r15d
		  HGWaterGlobalConfig *v26; // rax
		  Texture2DArray *v27; // rax
		  struct Object_1__Class *v28; // rcx
		  Texture2DArray *v29; // rdi
		  HGWaterGlobalConfig *v30; // rax
		  Texture2DArray *v31; // rax
		  int v32; // ebp
		  HGWaterGlobalConfig *v33; // rax
		  Texture2D *causticMap; // rax
		  TileBase *v35; // rdx
		  Vector3Int *v36; // r8
		  ITilemap *v37; // r9
		  struct Object_1__Class *v38; // rcx
		  Texture2D *v39; // rdi
		  HGWaterGlobalConfig *v40; // rax
		  Texture2D *v41; // rax
		  Void *m_Buffer; // rax
		  __m128 v43; // xmm3
		  __m128 v44; // xmm3
		  __m128 v45; // xmm3
		  __m128 v46; // xmm3
		  TileBase *v47; // rdx
		  Vector3Int *v48; // r8
		  ITilemap *v49; // r9
		  Object *v50; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v51; // rax
		  Object__Class *klass; // rax
		  int32_t castClass; // eax
		  __m128i v54; // xmm0
		  Void *v55; // rax
		  __m128 v56; // xmm1
		  ILFixDynamicMethodWrapper_2 *v57; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128 v59; // [rsp+20h] [rbp-28h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_60;
		  if ( wrapperArray[6] <= 2302 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_60;
		  if ( (unsigned int)wrapperArray[6] <= 0x8FE )
		    goto LABEL_85;
		  if ( !*((_QWORD *)wrapperArray + 2306) )
		  {
		LABEL_5:
		    if ( !HG::Rendering::Runtime::HGWaterManager::get_shouldRender(this, 0LL) )
		      return;
		    globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		    v9 = TypeInfo::UnityEngine::Object;
		    v10 = globalConfig;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v9 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !v10 )
		      goto LABEL_59;
		    if ( !v9->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v9);
		    if ( v10->fields._._._._.m_CachedPtr )
		    {
		      v11 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		      if ( !v11 )
		        goto LABEL_60;
		      flowMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(v11, 0LL);
		      v13 = TypeInfo::UnityEngine::Object;
		      v14 = flowMap;
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
		      v15 = 2;
		      if ( !v14 )
		        goto LABEL_56;
		      if ( !v13->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v13);
		      if ( v14->fields._._.m_CachedPtr )
		      {
		        v16 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		        if ( !v16 )
		          goto LABEL_60;
		        v17 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(v16, 0LL);
		        if ( !v17 )
		          goto LABEL_60;
		        v18 = sub_180002F70(7LL, v17);
		      }
		      else
		      {
		LABEL_56:
		        v18 = 2;
		      }
		      v19 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		      if ( !v19 )
		        goto LABEL_60;
		      normalMapArray = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v19, 0LL);
		      v21 = TypeInfo::UnityEngine::Object;
		      v22 = normalMapArray;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v21 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v21 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !v22 )
		        goto LABEL_57;
		      if ( !v21->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v21);
		      if ( v22->fields._._.m_CachedPtr )
		      {
		        v23 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		        if ( !v23 )
		          goto LABEL_60;
		        v24 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v23, 0LL);
		        if ( !v24 )
		          goto LABEL_60;
		        v25 = sub_180002F70(5LL, v24);
		      }
		      else
		      {
		LABEL_57:
		        v25 = 2;
		      }
		      v26 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		      if ( !v26 )
		        goto LABEL_60;
		      v27 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v26, 0LL);
		      v28 = TypeInfo::UnityEngine::Object;
		      v29 = v27;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v28 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v28 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !v29 )
		        goto LABEL_58;
		      if ( !v28->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v28);
		      if ( v29->fields._._.m_CachedPtr )
		      {
		        v30 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		        if ( !v30 )
		          goto LABEL_60;
		        v31 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v30, 0LL);
		        if ( !v31 )
		          goto LABEL_60;
		        v32 = sub_180002F70(7LL, v31);
		      }
		      else
		      {
		LABEL_58:
		        v32 = 2;
		      }
		      v33 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		      if ( !v33 )
		        goto LABEL_60;
		      causticMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(v33, 0LL);
		      v38 = TypeInfo::UnityEngine::Object;
		      v39 = causticMap;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v38 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v38 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( v39 )
		      {
		        if ( !v38->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v38);
		        if ( v39->fields._._.m_CachedPtr )
		        {
		          v40 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		          if ( !v40 )
		            goto LABEL_60;
		          v41 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(v40, 0LL);
		          if ( !v41 )
		            goto LABEL_60;
		          v15 = sub_180002F70(5LL, v41);
		        }
		      }
		      m_Buffer = this->fields.waterGPUData.m_Buffer;
		      v43 = 0LL;
		      v43.m128_f32[0] = (float)v18;
		      v44 = _mm_shuffle_ps(v43, v43, 225);
		      v44.m128_f32[0] = (float)v25;
		      v45 = _mm_shuffle_ps(v44, v44, 198);
		      v45.m128_f32[0] = (float)v32;
		      v46 = _mm_shuffle_ps(v45, v45, 39);
		      v46.m128_f32[0] = (float)v15;
		      v59 = _mm_shuffle_ps(v46, v46, 57);
		      *(__m128 *)&m_Buffer[160] = v59;
		    }
		    else
		    {
		LABEL_59:
		      *(TileAnimationData *)&this->fields.waterGPUData.m_Buffer[160] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                          (TileAnimationData *)&v59,
		                                                                          v6,
		                                                                          v7,
		                                                                          v8,
		                                                                          (MethodInfo *)v59.m128_u64[0]);
		    }
		    *(TileAnimationData *)&this->fields.waterGPUData.m_Buffer[176] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                        (TileAnimationData *)&v59,
		                                                                        v35,
		                                                                        v36,
		                                                                        v37,
		                                                                        (MethodInfo *)v59.m128_u64[0]);
		    *(TileAnimationData *)&this->fields.waterGPUData.m_Buffer[192] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                        (TileAnimationData *)&v59,
		                                                                        v47,
		                                                                        v48,
		                                                                        v49,
		                                                                        (MethodInfo *)v59.m128_u64[0]);
		    v50 = (Object *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig(this, 0LL);
		    if ( !v50 )
		      goto LABEL_60;
		    v51 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v51 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (int *)v51->static_fields;
		    v3 = *(struct ILFixDynamicMethodWrapper_2__Class **)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_60;
		    if ( SLODWORD(v3->_0.namespaze) <= 1021 )
		      goto LABEL_53;
		    if ( !v51->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v51);
		      v51 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v51->static_fields->wrapperArray;
		    if ( !v3 )
		LABEL_60:
		      sub_1800D8260(v3, wrapperArray);
		    if ( LODWORD(v3->_0.namespaze) > 0x3FD )
		    {
		      if ( !*(_QWORD *)&v3[21]._1.naturalAligment )
		      {
		LABEL_53:
		        klass = v50[3].klass;
		        if ( klass )
		          castClass = (int32_t)klass->_0.castClass;
		        else
		          castClass = 2048;
		        goto LABEL_55;
		      }
		      Patch = IFix::WrappersManagerImpl::GetPatch(1021, 0LL);
		      if ( Patch )
		      {
		        castClass = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, v50, 0LL);
		LABEL_55:
		        v54 = _mm_cvtsi32_si128(castClass);
		        v55 = this->fields.waterGPUData.m_Buffer;
		        v59.m128_u64[0] = 0LL;
		        v59.m128_i32[2] = 1107296256;
		        v56 = _mm_shuffle_ps(v59, v59, 147);
		        v56.m128_f32[0] = _mm_cvtepi32_ps(v54).m128_f32[0];
		        *(__m128 *)&v55[208] = _mm_shuffle_ps(v56, v56, 57);
		        return;
		      }
		      goto LABEL_60;
		    }
		LABEL_85:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		  v57 = IFix::WrappersManagerImpl::GetPatch(2302, 0LL);
		  if ( !v57 )
		    goto LABEL_60;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v57, (Object *)this, 0LL);
		}
		
		public void UpdateStaticWater(string name, int materialIndex, ref NativeArray<Vector4> materialData) {} // 0x0000000183C543E0-0x0000000183C544B0
		// Void UpdateStaticWater(String, Int32, NativeArray`1[UnityEngine.Vector4] ByRef)
		void HG::Rendering::Runtime::HGWaterManager::UpdateStaticWater(
		        HGWaterManager *this,
		        String *name,
		        int32_t materialIndex,
		        NativeArray_1_UnityEngine_Vector4_ *materialData,
		        MethodInfo *method)
		{
		  NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm0
		  struct MethodInfo *v10; // rcx
		  Void *v11; // rax
		  NativeArray_1_UnityEngine_Vector4_ v12; // xmm0
		  Void *v13; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Void *m_Buffer; // [rsp+30h] [rbp-18h]
		  NativeArray_1_UnityEngine_Vector4_ v18; // [rsp+30h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5328, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5328, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1544(
		      Patch,
		      (Object *)this,
		      (Object *)name,
		      materialIndex,
		      materialData,
		      0LL);
		  }
		  else if ( (unsigned int)materialIndex > 0x1F )
		  {
		    HG::Rendering::HGRPLogger::LogError<System::Object,int>(
		      (String *)"无法添静态材质水体，Asset({0})的材质索引({1})不合法，请修改",
		      (Object *)name,
		      materialIndex,
		      MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
		  }
		  else
		  {
		    waterGPUData = this->fields.waterGPUData;
		    m_Buffer = waterGPUData.m_Buffer;
		    v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		    {
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		      waterGPUData.m_Buffer = m_Buffer;
		    }
		    v11 = waterGPUData.m_Buffer;
		    v12 = *materialData;
		    v13 = &v11[320 * materialIndex + 288];
		    v18 = *materialData;
		    if ( !v10->rgctx_data )
		    {
		      sub_1800430B0(v10);
		      v12.m_Buffer = v18.m_Buffer;
		    }
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v13, v12.m_Buffer, 320LL, 0LL);
		  }
		}
		
		public void UpdateDynamicWater(string name, int materialIndex, ref NativeArray<Vector4> materialData) {} // 0x0000000183C52E50-0x0000000183C52F20
		// Void UpdateDynamicWater(String, Int32, NativeArray`1[UnityEngine.Vector4] ByRef)
		void HG::Rendering::Runtime::HGWaterManager::UpdateDynamicWater(
		        HGWaterManager *this,
		        String *name,
		        int32_t materialIndex,
		        NativeArray_1_UnityEngine_Vector4_ *materialData,
		        MethodInfo *method)
		{
		  NativeArray_1_UnityEngine_Vector4_ waterGPUData; // xmm0
		  struct MethodInfo *v10; // rcx
		  Void *v11; // rax
		  NativeArray_1_UnityEngine_Vector4_ v12; // xmm0
		  Void *v13; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Void *m_Buffer; // [rsp+30h] [rbp-18h]
		  NativeArray_1_UnityEngine_Vector4_ v18; // [rsp+30h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5360, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5360, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1544(
		      Patch,
		      (Object *)this,
		      (Object *)name,
		      materialIndex,
		      materialData,
		      0LL);
		  }
		  else if ( (unsigned int)(materialIndex - 32) > 0x1F )
		  {
		    HG::Rendering::HGRPLogger::LogError<System::Object,int>(
		      (String *)"无法添动态材质水体，WaterRenderer({0})的材质索引({1})不合法，请修改",
		      (Object *)name,
		      materialIndex,
		      MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,int>);
		  }
		  else
		  {
		    waterGPUData = this->fields.waterGPUData;
		    m_Buffer = waterGPUData.m_Buffer;
		    v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		    {
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      v10 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		      waterGPUData.m_Buffer = m_Buffer;
		    }
		    v11 = waterGPUData.m_Buffer;
		    v12 = *materialData;
		    v13 = &v11[320 * materialIndex + 288];
		    v18 = *materialData;
		    if ( !v10->rgctx_data )
		    {
		      sub_1800430B0(v10);
		      v12.m_Buffer = v18.m_Buffer;
		    }
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v13, v12.m_Buffer, 320LL, 0LL);
		  }
		}
		
		public void SetWaterDataCB(HGCamera hgCamera, HGSettingParameters settingParameters, ref CBHandle cbHandle, ref Matrix4x4 orthoViewProj, ref Matrix4x4 orthoDeviceViewProj, ref Matrix4x4 orthoDeviceInvViewProj) {} // 0x000000018334BBE0-0x000000018334CD20
		// Void SetWaterDataCB(HGCamera, HGSettingParameters, CBHandle ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
		        HGWaterManager *this,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        CBHandle *cbHandle,
		        Matrix4x4 *orthoViewProj,
		        Matrix4x4 *orthoDeviceViewProj,
		        Matrix4x4 *orthoDeviceInvViewProj,
		        MethodInfo *method)
		{
		  float v8; // xmm1_4
		  CBHandle *P3; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v14; // rdi
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  Object_1 *globalConfig; // rdi
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Camera *camera; // rdi
		  __int64 (__fastcall *v22)(Camera *); // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdi
		  void (__fastcall *v26)(__int64, __m128 *); // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  Camera *v29; // rbx
		  __int64 (__fastcall *v30)(Camera *); // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  __int64 v33; // rbx
		  __m128 v34; // xmm0
		  void (__fastcall *v35)(__int64, Vector4 *); // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  __m128 v38; // xmm7
		  HGWaterGlobalConfig *v39; // rax
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  int32_t RealHeightMapXZ; // edi
		  HGWaterGlobalConfig *v43; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  __m128 v46; // xmm0
		  System::MathF *v47; // rcx
		  __m128 v48; // xmm8
		  __int32 v49; // xmm14_4
		  float v50; // xmm0_4
		  System::MathF *v51; // rcx
		  __m128 v52; // xmm13
		  void (__fastcall *v53)(float4x4 *, Matrix4x4 *); // rax
		  float v54; // xmm11_4
		  HGWaterGlobalConfig *v55; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  int32_t heightMapY; // edi
		  HGWaterGlobalConfig *v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  float v62; // xmm5_4
		  Matrix4x4 *v63; // rax
		  __int128 v64; // xmm6
		  __int128 v65; // xmm11
		  __int128 v66; // xmm15
		  void (__fastcall *v67)(Matrix4x4 *, Matrix4x4 *, float4x4 *); // rax
		  __int64 v68; // rdx
		  void (__fastcall *v69)(Matrix4x4 *, __int64, float4x4 *); // rax
		  void (__fastcall *v70)(Matrix4x4 *, Matrix4x4 *, float4x4 *); // rax
		  Matrix4x4 *v71; // rdi
		  Matrix4x4 *inverse; // rax
		  __int128 v73; // xmm1
		  __int128 v74; // xmm2
		  __int128 v75; // xmm3
		  Matrix4x4 *v76; // rsi
		  Object *v77; // rbx
		  Object *v78; // rbx
		  Object *v79; // rbx
		  Object *v80; // rbx
		  Object *v81; // rbx
		  Object *v82; // rbx
		  Object *v83; // rbx
		  Object *v84; // rbx
		  Object *v85; // rsi
		  HGWaterGlobalConfig *v86; // rax
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  int32_t RealMeshNumPerLOD; // edi
		  HGWaterGlobalConfig *v90; // rax
		  __int64 v91; // rdx
		  __int64 v92; // rcx
		  float RealMeshSize; // xmm1_4
		  Vector4 *klass; // rax
		  __m128 v95; // xmm8
		  __m128 v96; // xmm8
		  __m128 v97; // xmm8
		  Object *v98; // rdi
		  HGWaterGlobalConfig *v99; // rax
		  __int64 v100; // rdx
		  __int64 v101; // rcx
		  HGWaterGlobalConfig *v102; // rax
		  __int64 v103; // rdx
		  __int64 v104; // rcx
		  __m128 v105; // xmm7
		  __m128 v106; // xmm7
		  __m128 v107; // xmm7
		  HGWaterGlobalConfig *v108; // rax
		  __int64 v109; // rdx
		  __int64 v110; // rcx
		  ValueTuple_2_Int32_Int32_ SectorCoords; // rax
		  int v112; // esi
		  int v113; // ebx
		  HGWaterGlobalConfig *v114; // rax
		  __int64 v115; // rdx
		  __int64 v116; // rcx
		  int v117; // edi
		  HGWaterGlobalConfig *v118; // rax
		  __int64 v119; // rdx
		  __int64 v120; // rcx
		  int32_t sectorCoordsMin; // eax
		  __int64 v122; // rdx
		  __m128 v123; // xmm3
		  Object__Class *v124; // rcx
		  __m128 v125; // xmm3
		  __m128 v126; // xmm3
		  __m128 v127; // xmm3
		  __m128 v128; // xmm3
		  Object__Class *v129; // rcx
		  __m128 v130; // xmm0
		  __m128 v131; // xmm0
		  struct MethodInfo *v132; // rcx
		  int v133; // ebx
		  Object *v134; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v135; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v136; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v137; // rdi
		  ILFixDynamicMethodWrapper_2 *v138; // rax
		  __int64 v139; // rdx
		  __int64 v140; // rcx
		  bool v141; // al
		  MonitorData *monitor; // rdi
		  Object__Class *v143; // rcx
		  NativeArray_1_UnityEngine_Vector4_ *v144; // rdx
		  void *ptr; // rdi
		  Object v146; // xmm6
		  void (__fastcall *v147)(void *, Object__Class *, _QWORD); // rax
		  __int64 v148; // rax
		  __int64 v149; // rax
		  __int64 v150; // rax
		  __int64 v151; // rax
		  __int64 v152; // rax
		  __int64 v153; // rax
		  __int64 v154; // rax
		  __int64 v155; // rax
		  __int64 v156; // rax
		  MethodInfo *v157; // [rsp+88h] [rbp-2B0h]
		  Vector4 v158; // [rsp+90h] [rbp-2A8h] BYREF
		  __m128 v159; // [rsp+A0h] [rbp-298h] BYREF
		  float v160; // [rsp+B0h] [rbp-288h]
		  Vector4 v161; // [rsp+C0h] [rbp-278h] BYREF
		  float v162; // [rsp+D0h] [rbp-268h]
		  float4x4 v163; // [rsp+D8h] [rbp-260h] BYREF
		  Vector4 si128; // [rsp+120h] [rbp-218h] BYREF
		  Matrix4x4 v165; // [rsp+130h] [rbp-208h] BYREF
		  float4x4 v166; // [rsp+170h] [rbp-1C8h] BYREF
		  Vector4 v167; // [rsp+1B0h] [rbp-188h] BYREF
		  Matrix4x4 v168; // [rsp+1C0h] [rbp-178h] BYREF
		  Matrix4x4 v169; // [rsp+200h] [rbp-138h] BYREF
		  Il2CppExceptionWrapper *v170; // [rsp+240h] [rbp-F8h] BYREF
		  Matrix4x4 v171[3]; // [rsp+250h] [rbp-E8h] BYREF
		  Object *P0; // [rsp+340h] [rbp+8h] BYREF
		  CBHandle *v173; // [rsp+358h] [rbp+20h]
		
		  v173 = cbHandle;
		  P0 = (Object *)this;
		  P3 = cbHandle;
		  memset(&v165, 0, sizeof(v165));
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v12, hgCamera);
		  if ( wrapperArray->max_length.size > 1002 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v14 = v12->static_fields->wrapperArray;
		    if ( !v14 )
		      sub_1800D8260(v12, hgCamera);
		    if ( v14->max_length.size <= 0x3EAu )
		      sub_1800D2AB0(v12, hgCamera);
		    if ( v14[27].vector[30] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1002, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v16, v15);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_401(
		        Patch,
		        P0,
		        (Object *)hgCamera,
		        (Object *)settingParameters,
		        P3,
		        orthoViewProj,
		        orthoDeviceViewProj,
		        orthoDeviceInvViewProj,
		        0LL);
		      return;
		    }
		  }
		  globalConfig = (Object_1 *)HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  }
		  if ( !UnityEngine::Object::CompareBaseObjects(globalConfig, 0LL, 0LL) )
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v20, v19);
		    camera = hgCamera->fields.camera;
		    if ( !camera )
		      sub_1800D8260(v20, v19);
		    v22 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v22 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v22 )
		      {
		        v148 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v148, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v22;
		    }
		    v25 = v22(camera);
		    if ( !v25 )
		      sub_1800D8260(v24, v23);
		    v159.m128_u64[0] = 0LL;
		    v159.m128_i32[2] = 0;
		    v26 = (void (__fastcall *)(__int64, __m128 *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v26 = (void (__fastcall *)(__int64, __m128 *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v26 )
		      {
		        v149 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v149, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v26;
		    }
		    v26(v25, &v159);
		    v29 = hgCamera->fields.camera;
		    if ( !v29 )
		      sub_1800D8260(v28, v27);
		    v30 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v30 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v30 )
		      {
		        v150 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v150, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v30;
		    }
		    v33 = v30(v29);
		    if ( !v33 )
		      sub_1800D8260(v32, v31);
		    v34 = 0LL;
		    v158 = 0LL;
		    v35 = (void (__fastcall *)(__int64, Vector4 *))qword_18F370110;
		    if ( !qword_18F370110 )
		    {
		      v35 = (void (__fastcall *)(__int64, Vector4 *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		      if ( !v35 )
		      {
		        v151 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		        sub_18007E1B0(v151, 0LL);
		      }
		      qword_18F370110 = (__int64)v35;
		    }
		    v35(v33, &v158);
		    if ( !settingParameters )
		      sub_1800D8260(v37, v36);
		    v160 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		             settingParameters->fields._waterPrepassTextureSize_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    v34.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                        settingParameters->fields._waterDisplacementWeight_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    v38 = v34;
		    v162 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		             settingParameters->fields._waterDisplacementDistance_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    v39 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v39 )
		      sub_1800D8260(v41, v40);
		    RealHeightMapXZ = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealHeightMapXZ(v39, settingParameters, 0LL);
		    v43 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v43 )
		      sub_1800D8260(v45, v44);
		    HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapOffset(v43, 0LL);
		    v46 = (__m128)v159.m128_u32[0];
		    System::MathF::Floor(v47, v8);
		    v48 = v46;
		    v49 = v159.m128_i32[2];
		    v50 = v159.m128_f32[2];
		    System::MathF::Floor(v51, v8);
		    LODWORD(v158.x) = v48.m128_i32[0];
		    v52 = (__m128)v159.m128_u32[1];
		    LODWORD(v158.y) = v159.m128_i32[1];
		    v158.z = v50;
		    v158.w = 1.0;
		    si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959930);
		    v167 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959550);
		    v161 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		    UnityEngine::Matrix4x4::Matrix4x4(&v165, &v161, &v167, &si128, &v158, 0LL);
		    v166 = (float4x4)v165;
		    memset(&v165, 0, sizeof(v165));
		    v53 = (void (__fastcall *)(float4x4 *, Matrix4x4 *))qword_18F36FA60;
		    if ( !qword_18F36FA60 )
		    {
		      v53 = (void (__fastcall *)(float4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
		                                                            "4&,UnityEngine.Matrix4x4&)");
		      if ( !v53 )
		      {
		        v152 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v152, 0LL);
		      }
		      qword_18F36FA60 = (__int64)v53;
		    }
		    v53(&v166, &v165);
		    v54 = (float)(RealHeightMapXZ + 4);
		    v55 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v55 )
		      sub_1800D8260(v57, v56);
		    heightMapY = HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v55, 0LL);
		    v59 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v59 )
		      sub_1800D8260(v61, v60);
		    v62 = (float)HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(v59, 0LL) * 0.5;
		    memset(&v163, 0, sizeof(v163));
		    Unity::Mathematics::float4x4::float4x4(
		      &v163,
		      (float)(1.0 / v54) + (float)(1.0 / v54),
		      0.0,
		      0.0,
		      0.0,
		      0.0,
		      (float)(1.0 / v54) + (float)(1.0 / v54),
		      0.0,
		      0.0,
		      0.0,
		      0.0,
		      (float)(1.0 / (float)(v62 - (float)((float)-heightMapY * 0.5))) * -2.0,
		      (float)-(float)(v62 + (float)((float)-heightMapY * 0.5))
		    * (float)(1.0 / (float)(v62 - (float)((float)-heightMapY * 0.5))),
		      0.0,
		      0.0,
		      0.0,
		      1.0,
		      v157);
		    v166 = v163;
		    v63 = Unity::Mathematics::float4x4::op_Implicit(v171, &v166, 0LL);
		    v161 = *(Vector4 *)&v63->m00;
		    v167 = *(Vector4 *)&v63->m01;
		    v158 = *(Vector4 *)&v63->m02;
		    si128 = *(Vector4 *)&v63->m03;
		    v169 = *v63;
		    v64 = *(_OWORD *)&v165.m00;
		    v168 = v165;
		    v65 = *(_OWORD *)&v165.m01;
		    v66 = *(_OWORD *)&v165.m02;
		    memset(&v163, 0, sizeof(v163));
		    v67 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, float4x4 *))qword_18F36FA50;
		    if ( !qword_18F36FA50 )
		    {
		      v67 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, float4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v67 )
		      {
		        v153 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v153, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v67;
		    }
		    v67(&v169, &v168, &v163);
		    *(float4x4 *)orthoViewProj = v163;
		    *(Vector4 *)&v171[0].m00 = v161;
		    *(Vector4 *)&v171[0].m01 = v167;
		    *(Vector4 *)&v171[0].m02 = v158;
		    *(Vector4 *)&v171[0].m03 = si128;
		    memset(&v166, 0, sizeof(v166));
		    v69 = (void (__fastcall *)(Matrix4x4 *, __int64, float4x4 *))qword_18F36F3B8;
		    if ( !qword_18F36F3B8 )
		    {
		      v69 = (void (__fastcall *)(Matrix4x4 *, __int64, float4x4 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.GL::GetGPUProjectionMatrix_Injected(Uni"
		                                                                     "tyEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		      if ( !v69 )
		      {
		        v154 = sub_1802EE1B8(
		                 "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
		        sub_18007E1B0(v154, 0LL);
		      }
		      qword_18F36F3B8 = (__int64)v69;
		    }
		    LOBYTE(v68) = 1;
		    v69(v171, v68, &v166);
		    v168 = (Matrix4x4)v166;
		    *(_OWORD *)&v169.m00 = v64;
		    *(_OWORD *)&v169.m01 = v65;
		    *(_OWORD *)&v169.m02 = v66;
		    *(_OWORD *)&v169.m03 = *(_OWORD *)&v165.m03;
		    memset(&v163, 0, sizeof(v163));
		    v70 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, float4x4 *))qword_18F36FA50;
		    if ( !qword_18F36FA50 )
		    {
		      v70 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, float4x4 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
		                                                                         "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
		                                                                         "rix4x4&,UnityEngine.Matrix4x4&)");
		      if ( !v70 )
		      {
		        v155 = sub_1802EE1B8(
		                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
		                 "nityEngine.Matrix4x4&)");
		        sub_18007E1B0(v155, 0LL);
		      }
		      qword_18F36FA50 = (__int64)v70;
		    }
		    v70(&v168, &v169, &v163);
		    v71 = orthoDeviceViewProj;
		    *(float4x4 *)orthoDeviceViewProj = v163;
		    inverse = UnityEngine::Matrix4x4::get_inverse(v171, v71, 0LL);
		    v73 = *(_OWORD *)&inverse->m01;
		    v74 = *(_OWORD *)&inverse->m02;
		    v75 = *(_OWORD *)&inverse->m03;
		    v76 = orthoDeviceInvViewProj;
		    *(_OWORD *)&orthoDeviceInvViewProj->m00 = *(_OWORD *)&inverse->m00;
		    *(_OWORD *)&v76->m01 = v73;
		    *(_OWORD *)&v76->m02 = v74;
		    *(_OWORD *)&v76->m03 = v75;
		    v77 = P0;
		    *(Vector4 *)&v77[4].klass->_0.image = *UnityEngine::Matrix4x4::GetColumn(&v161, v71, 0, 0LL);
		    v78 = P0;
		    *(Vector4 *)&v78[4].klass->_0.name = *UnityEngine::Matrix4x4::GetColumn(&v161, v71, 1, 0LL);
		    v79 = P0;
		    v79[4].klass->_0.byval_arg = (Il2CppType)*UnityEngine::Matrix4x4::GetColumn(&v161, v71, 2, 0LL);
		    v80 = P0;
		    v80[4].klass->_0.this_arg = (Il2CppType)*UnityEngine::Matrix4x4::GetColumn(&v161, v71, 3, 0LL);
		    v81 = P0;
		    *(Vector4 *)&v81[4].klass->_0.element_class = *UnityEngine::Matrix4x4::GetColumn(&v161, v76, 0, 0LL);
		    v82 = P0;
		    *(Vector4 *)&v82[4].klass->_0.declaringType = *UnityEngine::Matrix4x4::GetColumn(&v161, v76, 1, 0LL);
		    v83 = P0;
		    *(Vector4 *)&v83[4].klass->_0.generic_class = *UnityEngine::Matrix4x4::GetColumn(&v161, v76, 2, 0LL);
		    v84 = P0;
		    *(Vector4 *)&v84[4].klass->_0.interopData = *UnityEngine::Matrix4x4::GetColumn(&v161, v76, 3, 0LL);
		    v85 = P0;
		    v86 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v86 )
		      sub_1800D8260(v88, v87);
		    RealMeshNumPerLOD = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(v86, settingParameters, 0LL);
		    v90 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v90 )
		      sub_1800D8260(v92, v91);
		    RealMeshSize = (float)HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshSize(v90, settingParameters, 0LL);
		    klass = (Vector4 *)v85[4].klass;
		    v95 = _mm_shuffle_ps(v48, v48, 225);
		    v95.m128_f32[0] = v50;
		    v96 = _mm_shuffle_ps(v95, v95, 198);
		    v96.m128_f32[0] = (float)RealMeshNumPerLOD;
		    v97 = _mm_shuffle_ps(v96, v96, 39);
		    v97.m128_f32[0] = RealMeshSize;
		    v158 = (Vector4)_mm_shuffle_ps(v97, v97, 57);
		    klass[8] = v158;
		    v98 = P0;
		    v99 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v99 )
		      sub_1800D8260(v101, v100);
		    *(Vector2 *)&si128.x = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(v99, 0LL);
		    v102 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v102 )
		      sub_1800D8260(v104, v103);
		    *(Vector2 *)&v158.x = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(v102, 0LL);
		    v105 = _mm_shuffle_ps(v38, v38, 225);
		    v105.m128_f32[0] = v162;
		    v106 = _mm_shuffle_ps(v105, v105, 198);
		    v106.m128_f32[0] = si128.x;
		    v107 = _mm_shuffle_ps(v106, v106, 39);
		    v107.m128_f32[0] = v158.y;
		    *(__m128 *)&v98[4].klass->_0.properties = _mm_shuffle_ps(v107, v107, 57);
		    v108 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v108 )
		      sub_1800D8260(v110, v109);
		    v159.m128_u64[0] = _mm_unpacklo_ps((__m128)v159.m128_u32[0], v52).m128_u64[0];
		    v159.m128_i32[2] = v49;
		    SectorCoords = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(v108, (Vector3 *)&v159, 0LL);
		    v112 = SectorCoords.Item1 - 1;
		    v113 = SectorCoords.Item2 - 1;
		    v114 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v114 )
		      sub_1800D8260(v116, v115);
		    v117 = (v112 - HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v114, 0LL)) % 3;
		    v118 = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)P0, 0LL);
		    if ( !v118 )
		      sub_1800D8260(v120, v119);
		    sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(v118, 0LL);
		    v122 = (unsigned int)((v113 - sectorCoordsMin) / 3);
		    v123 = (__m128)COERCE_UNSIGNED_INT((float)v117);
		    v123.m128_f32[0] = v123.m128_f32[0] / 3.0;
		    v124 = P0[4].klass;
		    v125 = _mm_shuffle_ps(v123, v123, 225);
		    v125.m128_f32[0] = (float)((v113 - sectorCoordsMin) % 3) / 3.0;
		    v126 = _mm_shuffle_ps(v125, v125, 198);
		    v126.m128_f32[0] = (float)v112 * 128.0;
		    v127 = _mm_shuffle_ps(v126, v126, 39);
		    v127.m128_f32[0] = (float)v113 * 128.0;
		    v128 = _mm_shuffle_ps(v127, v127, 57);
		    v159.m128_u64[0] = v128.m128_u64[0];
		    *(__m128 *)&v124->interfaceOffsets = v128;
		    v159.m128_u64[1] = 0x3D80000041800000LL;
		    v129 = P0[4].klass;
		    v130 = v159;
		    v130.m128_f32[0] = v160;
		    v131 = _mm_shuffle_ps(v130, v130, 225);
		    v131.m128_f32[0] = 1.0 / v160;
		    v159 = _mm_shuffle_ps(v131, v131, 225);
		    *(__m128 *)&v129->rgctx_data = v159;
		    v132 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>;
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		    v133 = 16 * LODWORD(P0[4].monitor);
		    v160 = *(float *)&v133;
		    v134 = (Object *)P0[6].klass;
		    if ( !v134 )
		      sub_1800D8260(v132, v122);
		    v135 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v135 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v136 = v135->static_fields->wrapperArray;
		    if ( !v136 )
		      sub_1800D8260(v135, v122);
		    if ( v136->max_length.size <= 1029 )
		      goto LABEL_71;
		    if ( !v135->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v135);
		      v135 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v137 = v135->static_fields->wrapperArray;
		    if ( !v137 )
		      sub_1800D8260(v135, v122);
		    if ( v137->max_length.size <= 0x405u )
		      sub_1800D2AB0(v135, v122);
		    if ( v137[28].vector[21] )
		    {
		      v138 = IFix::WrappersManagerImpl::GetPatch(1029, 0LL);
		      if ( !v138 )
		        sub_1800D8260(v140, v139);
		      v141 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v138, v134, 0LL);
		    }
		    else
		    {
		LABEL_71:
		      monitor = v134[1].monitor;
		      if ( !monitor )
		        sub_1800D8260(v135, v122);
		      v141 = *((_DWORD *)monitor + 6) > 0;
		    }
		    if ( !v141 )
		      goto LABEL_80;
		    v159.m128_u64[0] = 0LL;
		    v159.m128_u64[1] = (unsigned __int64)&P0;
		    try
		    {
		      v143 = P0[6].klass;
		      v144 = (NativeArray_1_UnityEngine_Vector4_ *)&P0[4];
		      if ( !v143 )
		        sub_1800D8250(0LL, v144);
		      HG::Rendering::Runtime::HGWaterConfigOverrideController::ApplyForFrame(
		        (HGWaterConfigOverrideController *)v143,
		        v144,
		        0LL);
		      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)P3->ptr, (Void *)P0[4].klass, v133, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v170 )
		    {
		      *(Il2CppExceptionWrapper *)v159.m128_f32 = (Il2CppExceptionWrapper)v170->ex;
		      sub_182CB9590(&v159.m128_u16[4]);
		      if ( v159.m128_u64[0] )
		        sub_18007E1E0(v159.m128_u64[0]);
		      P3 = v173;
		      *(float *)&v133 = v160;
		LABEL_80:
		      ptr = P3->ptr;
		      v146 = P0[4];
		      v147 = (void (__fastcall *)(void *, Object__Class *, _QWORD))qword_18F36EF28;
		      if ( !qword_18F36EF28 )
		      {
		        v147 = (void (__fastcall *)(void *, Object__Class *, _QWORD))il2cpp_resolve_icall_1(
		                                                                       "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::"
		                                                                       "MemCpy(System.Void*,System.Void*,System.Int64)");
		        if ( !v147 )
		        {
		          v156 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		          sub_18007E1B0(v156, 0LL);
		        }
		        qword_18F36EF28 = (__int64)v147;
		      }
		      v147(ptr, v146.klass, v133);
		      return;
		    }
		    sub_182CB9590(&v159.m128_u16[4]);
		  }
		}
		
		public void SetWaterIntersectionCB(ref CBHandle cbHandle) {} // 0x000000018334B920-0x000000018334B9C0
		// Void SetWaterIntersectionCB(CBHandle ByRef)
		void HG::Rendering::Runtime::HGWaterManager::SetWaterIntersectionCB(
		        HGWaterManager *this,
		        CBHandle *cbHandle,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  NativeArray_1_UnityEngine_Vector4_ waterRippleData; // xmm0
		  void *ptr; // rdi
		  void (__fastcall *v9)(void *, Void *, _QWORD); // rax
		  int v10; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 1000 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3E8 )
		        sub_1800D2AB0(v5, cbHandle);
		      if ( !v5[21]._0.events )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1000, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, cbHandle, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v5, cbHandle);
		  }
		LABEL_5:
		  if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		    sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		  waterRippleData = this->fields.waterRippleData;
		  ptr = cbHandle->ptr;
		  v9 = (void (__fastcall *)(void *, Void *, _QWORD))qword_18F36EF28;
		  v10 = 16 * this->fields.waterRippleData.m_Length;
		  if ( !qword_18F36EF28 )
		  {
		    v9 = (void (__fastcall *)(void *, Void *, _QWORD))il2cpp_resolve_icall_1(
		                                                        "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.V"
		                                                        "oid*,System.Void*,System.Int64)");
		    if ( !v9 )
		    {
		      v12 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		      sub_18007E1B0(v12, 0LL);
		    }
		    qword_18F36EF28 = (__int64)v9;
		  }
		  v9(ptr, waterRippleData.m_Buffer, v10);
		}
		
		public void PrepareWaterEnvParams(HGCamera hgCamera) {} // 0x0000000183D4E7B0-0x0000000183D4E860
		// Void PrepareWaterEnvParams(HGCamera)
		void HG::Rendering::Runtime::HGWaterManager::PrepareWaterEnvParams(
		        HGWaterManager *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  Void *m_Buffer; // rcx
		  __m128 v9; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 999 )
		    goto LABEL_20;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_9;
		  if ( LODWORD(v5->_0.namespaze) <= 0x3E7 )
		    sub_1800D2AB0(v5, hgCamera);
		  if ( !v5[21]._0.fields )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( InterpolatedPhase )
		    {
		      m_Buffer = this->fields.waterRippleData.m_Buffer;
		      v9 = _mm_shuffle_ps(*(__m128 *)&m_Buffer[16], *(__m128 *)&m_Buffer[16], 147);
		      v9.m128_f32[0] = InterpolatedPhase->fields.waterEnvConfig.waterInteractionStrengthMultiplier;
		      *(__m128 *)&m_Buffer[16] = _mm_shuffle_ps(v9, v9, 57);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v5, hgCamera);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(999, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    0LL);
		}
		
		public float Frac(float value) => default; // 0x000000018485FEE0-0x000000018485FF30
		// Single Frac(Single)
		float HG::Rendering::Runtime::HGWaterManager::Frac(HGWaterManager *this, float value, MethodInfo *method)
		{
		  char v4; // dl
		  __int64 v5; // rcx
		  int v6; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2305, 0LL) )
		    return value - (float)(int)sub_1834464B0(v5, v4, v6);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2305, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111(
		           (ILFixDynamicMethodWrapper_6 *)Patch,
		           (Object *)this,
		           value,
		           0LL);
		}
		
		public float Step(float edge, float x) => default; // 0x0000000183771ED0-0x0000000183771F60
		// Single Step(Single, Single)
		float HG::Rendering::Runtime::HGWaterManager::Step(HGWaterManager *this, float edge, float x, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 5363 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x14F3 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[114]._0.castClass )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(5363, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_107(
		                 (ILFixDynamicMethodWrapper_6 *)Patch,
		                 (Object *)this,
		                 edge,
		                 x,
		                 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  if ( edge > x )
		    return 0.0;
		  else
		    return 1.0;
		}
		
		public Vector4 ToVector4(Vector2 v, float z, float w) => default; // 0x0000000183334820-0x00000001833348E0
		// Vector4 ToVector4(Vector2, Single, Single)
		Vector4 *HG::Rendering::Runtime::HGWaterManager::ToVector4(
		        Vector4 *__return_ptr retstr,
		        HGWaterManager *this,
		        Vector2 v,
		        float z,
		        float w,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v14; // [rsp+48h] [rbp-40h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 2314 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		    if ( v7 )
		    {
		      if ( LODWORD(v7->_0.namespaze) <= 0x90A )
		        sub_1800D2AB0(v7, wrapperArray);
		      if ( !v7[49]._0.klass )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2314, 0LL);
		      if ( Patch )
		      {
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_918(&v14, Patch, (Object *)this, v, z, w, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v7, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = v.x;
		  retstr->w = w;
		  retstr->y = v.y;
		  retstr->z = z;
		  return retstr;
		}
		
		private void SetRippleDataToRenderPipeLine() {} // 0x00000001833330B0-0x0000000183334820
		// Void SetRippleDataToRenderPipeLine()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGWaterManager::SetRippleDataToRenderPipeLine(HGWaterManager *this, MethodInfo *method)
		{
		  HGWaterManager *v2; // rdi
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  HGWaterInteractiveSetting *m_hgWaterInteractiveSetting; // rbx
		  struct Object_1__Class *v10; // rcx
		  RippleDataManager *m_RippleDataManager; // rsi
		  signed __int64 v12; // rcx
		  __int64 v13; // rbx
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rbx
		  float v18; // xmm7_4
		  float v19; // xmm8_4
		  float v20; // xmm6_4
		  __int128 v21; // xmm0
		  float priority; // eax
		  List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // rbx
		  __int64 v24; // rcx
		  float v25; // xmm1_4
		  __int64 v26; // rcx
		  __int64 evaluationStackBase_low; // r8
		  Il2CppClass *klass; // rcx
		  int evaluationStackBase_high; // r9d
		  Value_1 *argumentBase; // rdx
		  float frameCount; // xmm7_4
		  Beyond::DampingMath *v32; // rcx
		  float v33; // xmm1_4
		  float v34; // xmm8_4
		  Beyond::DampingMath *v35; // rcx
		  float v36; // xmm2_4
		  Value_1 *v37; // r9
		  signed __int64 v38; // rtt
		  Value_1 *v39; // rax
		  __int64 v40; // rsi
		  __m128 v41; // xmm6
		  float v42; // esi
		  __int64 v43; // r8
		  double v44; // xmm0_8
		  RippleDataManager *v45; // rbx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  ILFixDynamicMethodWrapper_2 *v48; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v49; // rax
		  __int64 size; // r8
		  InputRippleData__Array *items; // rdx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v52; // r9
		  __int64 v53; // rax
		  InputRippleData__Array *v54; // rdx
		  __int64 v55; // rax
		  __m128 v56; // xmm7
		  float v57; // r15d
		  ILFixDynamicMethodWrapper_2 *v58; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v61; // rcx
		  __int64 v62; // rax
		  InputRippleData__Array *v63; // rdx
		  __int64 v64; // rax
		  __int64 v65; // r8
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v66; // rcx
		  __int64 minIndex; // rax
		  InputRippleData__Array *v68; // rcx
		  __int64 v69; // rax
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v70; // rax
		  ILFixDynamicMethodWrapper_2 *v71; // rax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  RippleDataManager *v74; // rax
		  HGWaterInteractiveSetting *v75; // r8
		  __m128 x_low; // xmm6
		  __m128 y_low; // xmm7
		  __int64 v78; // r15
		  __int64 v79; // r15
		  Call *v80; // rax
		  __m128i v81; // xmm1
		  __m128i v82; // xmm2
		  Object__Array **v83; // r9
		  _DWORD *v84; // xmm2_8
		  signed __int64 v85; // rcx
		  __int128 v86; // rax
		  __int64 v87; // rsi
		  Object__Array *managedStack; // r13
		  Il2CppClass *element_class; // rbx
		  Value_1 *currentTop; // r8
		  signed __int64 v91; // rsi
		  Object__Array *v92; // r13
		  Il2CppClass *v93; // rbx
		  unsigned __int64 *v94; // r13
		  signed __int64 v95; // rsi
		  Il2CppClass *v96; // rbx
		  bool v97; // zf
		  Value_1 *v98; // rax
		  unsigned __int64 v99; // r8
		  struct MethodInfo *v100; // rsi
		  unsigned int v101; // ecx
		  __int64 v102; // rbx
		  unsigned int v103; // eax
		  unsigned int v104; // ecx
		  __int64 v105; // rax
		  signed __int64 v106; // r9
		  unsigned __int64 v107; // rdx
		  signed __int64 v108; // rtt
		  __int64 v109; // rbx
		  __int64 v110; // rax
		  __int64 v111; // rbx
		  _QWORD **v112; // rcx
		  __int64 v113; // r8
		  __int64 v114; // rax
		  __int64 v115; // rdx
		  __int64 Value1; // rax
		  Object *v117; // rbx
		  __m128 v118; // xmm0
		  __m128 v119; // xmm0
		  __m128 v120; // xmm0
		  __m128 v121; // xmm1
		  __m128 v122; // xmm2
		  float v123; // xmm0_4
		  float v124; // xmm1_4
		  float v125; // xmm2_4
		  Vector4 *m_Buffer; // rax
		  __m128 v127; // xmm3
		  __m128 v128; // xmm3
		  __m128 v129; // xmm3
		  Vector4 *v130; // rax
		  __m128 v131; // xmm3
		  __m128 v132; // xmm3
		  __m128 v133; // xmm3
		  int v134; // ebx
		  __int64 v135; // rsi
		  HGWaterManager *v136; // r15
		  RippleDataManager *v137; // rax
		  __m128 v138; // xmm1
		  __m128 v139; // xmm2
		  __m128 v140; // xmm0
		  float v141; // xmm3_4
		  __int64 v142; // rax
		  __int64 v143; // rax
		  __int64 v144; // rax
		  __int64 v145; // [rsp+0h] [rbp-178h] BYREF
		  __m128 v146; // [rsp+30h] [rbp-148h] BYREF
		  Call call; // [rsp+40h] [rbp-138h] BYREF
		  Call v148; // [rsp+70h] [rbp-108h] BYREF
		  float v149; // [rsp+98h] [rbp-E0h]
		  HGWaterManager *v150; // [rsp+A0h] [rbp-D8h]
		  Call v151; // [rsp+B0h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v152; // [rsp+E0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v153; // [rsp+E8h] [rbp-90h] BYREF
		  unsigned __int64 v155; // [rsp+190h] [rbp+18h] BYREF
		  Object__Array *v156; // [rsp+198h] [rbp+20h]
		
		  v2 = this;
		  v150 = this;
		  memset(&v148, 0, sizeof(v148));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  if ( !static_fields->wrapperArray )
		    sub_1800D8260(static_fields, method);
		  if ( static_fields->wrapperArray->max_length.size > 2303 )
		  {
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    wrapperArray = v4->wrapperArray;
		    if ( !v4->wrapperArray )
		      sub_1800D8260(v4, method);
		    if ( wrapperArray->max_length.size <= 0x8FFu )
		      sub_1800D2AB0(v4, method);
		    if ( wrapperArray[64].max_length.value )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2303, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		      return;
		    }
		  }
		  m_hgWaterInteractiveSetting = v2->fields.m_hgWaterInteractiveSetting;
		  v10 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v10 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_hgWaterInteractiveSetting )
		  {
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v10);
		    if ( m_hgWaterInteractiveSetting->fields._._.m_CachedPtr )
		    {
		      m_RippleDataManager = v2->fields.m_RippleDataManager;
		      if ( !m_RippleDataManager )
		        sub_1800D8260(v10, method);
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      if ( !*(_QWORD *)v12 )
		        sub_1800D8260(v12, method);
		      if ( *(int *)(*(_QWORD *)v12 + 24LL) <= 2304 )
		        goto LABEL_32;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      v13 = *(_QWORD *)v12;
		      if ( !*(_QWORD *)v12 )
		        sub_1800D8260(v12, method);
		      if ( *(_DWORD *)(v13 + 24) <= 0x900u )
		        sub_1800D2AB0(v12, method);
		      if ( *(_QWORD *)(v13 + 18464) )
		      {
		        v14 = IFix::WrappersManagerImpl::GetPatch(2304, 0LL);
		        if ( !v14 )
		          sub_1800D8260(v16, v15);
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		          (ILFixDynamicMethodWrapper_39 *)v14,
		          (Object *)m_RippleDataManager,
		          0LL);
		      }
		      else
		      {
		LABEL_32:
		        list = m_RippleDataManager->fields._list;
		        if ( !list )
		          sub_1800D8260(v12, method);
		        ++list->fields._version;
		        list->fields._size = 0;
		        m_RippleDataManager->fields._minIndex = -1;
		      }
		      v18 = 0.0;
		      LODWORD(v156) = 0;
		      v19 = 0.0;
		      v149 = 0.0;
		      v20 = 0.0;
		      LODWORD(v155) = 0;
		      v21 = *(_OWORD *)&v2->fields.m_centerRippleData.positionXZ.x;
		      *(_OWORD *)&v2->fields.m_lastCenterRippleData.positionXZ.x = v21;
		      priority = v2->fields.m_centerRippleData.priority;
		      v2->fields.m_lastCenterRippleData.priority = priority;
		      v2->fields.m_isRippleInputEmpty = 0;
		      m_rawRippleDataList = v2->fields.m_rawRippleDataList;
		      if ( !m_rawRippleDataList )
		        sub_1800D8260(v12, method);
		      if ( m_rawRippleDataList->fields._size < 1 )
		      {
		        *(_OWORD *)&v2->fields.m_centerRippleData.positionXZ.x = v21;
		        v2->fields.m_centerRippleData.priority = priority;
		      }
		      else
		      {
		        System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::GetEnumerator(
		          (List_1_T_Enumerator_HG_Rendering_Runtime_InputRippleData_ *)&call,
		          v2->fields.m_rawRippleDataList,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::GetEnumerator);
		        v148 = call;
		        v25 = *(float *)&call.managedStack;
		        v146.m128_u64[0] = 0LL;
		        v146.m128_u64[1] = (unsigned __int64)&v148;
		        try
		        {
		          evaluationStackBase_high = HIDWORD(v148.evaluationStackBase);
		          evaluationStackBase_low = LODWORD(v148.evaluationStackBase);
		          argumentBase = v148.argumentBase;
		          while ( 1 )
		          {
		            if ( !v148.argumentBase )
		              sub_1800D8250(v24, 0LL);
		            if ( HIDWORD(v148.evaluationStackBase) != v148.argumentBase[2].Value1
		              || (unsigned int)evaluationStackBase_low >= v148.argumentBase[2].Type )
		            {
		              break;
		            }
		            v26 = *(_QWORD *)&v148.argumentBase[1].Value1;
		            if ( !v26 )
		              sub_1800D8250(0LL, v148.argumentBase);
		            if ( (unsigned int)evaluationStackBase_low >= *(_DWORD *)(v26 + 24) )
		              sub_1800D2AA0(v26, v148.argumentBase, evaluationStackBase_low);
		            *(_OWORD *)&v148.managedStack = *(_OWORD *)(v26 + 20LL * (int)evaluationStackBase_low + 32);
		            v24 = *(unsigned int *)(v26 + 20LL * (int)evaluationStackBase_low + 48);
		            LODWORD(v148.topWriteBack) = v24;
		            evaluationStackBase_low = (unsigned int)(evaluationStackBase_low + 1);
		            LODWORD(v148.evaluationStackBase) = evaluationStackBase_low;
		            v25 = (float)(*(float *)&v24 * *(float *)&v148.managedStack) + v18;
		            v18 = v25;
		            v19 = (float)(*(float *)&v24
		                        * _mm_shuffle_ps(*(__m128 *)&v148.managedStack, *(__m128 *)&v148.managedStack, 85).m128_f32[0])
		                + v19;
		            *(float *)&v156 = v25;
		            v149 = v19;
		            v20 = v20 + *(float *)&v24;
		            *(float *)&v155 = v20;
		          }
		          klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		          {
		            sub_1800360B0(klass, v148.argumentBase);
		            evaluationStackBase_high = HIDWORD(v148.evaluationStackBase);
		            argumentBase = v148.argumentBase;
		          }
		          if ( !argumentBase )
		            sub_1800D8250(klass, 0LL);
		          if ( evaluationStackBase_high != argumentBase[2].Value1 )
		            System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		          LODWORD(v148.evaluationStackBase) = argumentBase[2].Type + 1;
		          memset(&v148.managedStack, 0, 20);
		        }
		        catch ( Il2CppExceptionWrapper *v152 )
		        {
		          *(Il2CppExceptionWrapper *)v146.m128_f32 = (Il2CppExceptionWrapper)v152->ex;
		          if ( v146.m128_u64[0] )
		            sub_18007E1E0(v146.m128_u64[0]);
		          v2 = this;
		          v20 = *(float *)&v155;
		          v18 = *(float *)&v156;
		          v19 = v149;
		        }
		        v2->fields.m_centerRippleData.positionXZ.x = v18 / v20;
		        v2->fields.m_centerRippleData.positionXZ.y = v19 / v20;
		        frameCount = (float)UnityEngine::Time::get_frameCount(0LL);
		        Beyond::DampingMath::sinf(v32, v25);
		        v33 = (float)(frameCount * 12.9898) * 43758.547;
		        v34 = HG::Rendering::Runtime::HGWaterManager::Frac(v2, v33, 0LL) - 0.5;
		        Beyond::DampingMath::sinf(v35, v33);
		        v36 = v2->fields.m_centerRippleData.positionXZ.y
		            + (float)((float)(HG::Rendering::Runtime::HGWaterManager::Frac(
		                                v2,
		                                (float)((float)(frameCount + 37.0) * 78.233002) * 43758.547,
		                                0LL)
		                            - 0.5)
		                    * 0.029999999);
		        v2->fields.m_centerRippleData.positionXZ.x = (float)(v34 * 0.029999999)
		                                                   + v2->fields.m_centerRippleData.positionXZ.x;
		        v2->fields.m_centerRippleData.positionXZ.y = v36;
		        v150->fields.m_centerRippleData.size = 0.0;
		      }
		      v37 = (Value_1 *)v2->fields.m_rawRippleDataList;
		      if ( !v37 )
		        goto LABEL_253;
		      memset(&call.evaluationStackBase, 0, 32);
		      call.argumentBase = v37;
		      if ( dword_18F35FD08 )
		      {
		        method = (MethodInfo *)((((unsigned __int64)&call >> 12) & 0x1FFFFF) >> 6);
		        _m_prefetchw(&qword_18F103690[(_QWORD)method]);
		        do
		        {
		          v12 = qword_18F103690[(_QWORD)method] | (1LL << (((unsigned __int64)&call >> 12) & 0x3F));
		          v38 = qword_18F103690[(_QWORD)method];
		        }
		        while ( v38 != _InterlockedCompareExchange64(&qword_18F103690[(_QWORD)method], v12, v38) );
		      }
		      LODWORD(call.evaluationStackBase) = 0;
		      HIDWORD(call.evaluationStackBase) = v37[2].Value1;
		      memset(&call.managedStack, 0, 20);
		      *(_OWORD *)&v148.argumentBase = *(_OWORD *)&call.argumentBase;
		      *(_OWORD *)&v148.managedStack = 0LL;
		      v148.topWriteBack = call.topWriteBack;
		      v146.m128_u64[0] = 0LL;
		      v146.m128_u64[1] = (unsigned __int64)&v148;
		      try
		      {
		        while ( 1 )
		        {
		          while ( 1 )
		          {
		            while ( 1 )
		            {
		              while ( 1 )
		              {
		                do
		                {
		                  v39 = v148.argumentBase;
		                  if ( !v148.argumentBase )
		                    sub_1800D8250(v12, method);
		                  method = (MethodInfo *)HIDWORD(v148.evaluationStackBase);
		                  if ( HIDWORD(v148.evaluationStackBase) != v148.argumentBase[2].Value1
		                    || LODWORD(v148.evaluationStackBase) >= v148.argumentBase[2].Type )
		                  {
		                    v12 = (signed __int64)MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext->klass;
		                    if ( (*(_BYTE *)(v12 + 312) & 1) == 0 )
		                    {
		                      sub_1800360B0(v12, HIDWORD(v148.evaluationStackBase));
		                      method = (MethodInfo *)HIDWORD(v148.evaluationStackBase);
		                      v39 = v148.argumentBase;
		                    }
		                    if ( !v39 )
		                      sub_1800D8250(v12, method);
		                    if ( (_DWORD)method != v39[2].Value1 )
		                      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		                    LODWORD(v148.evaluationStackBase) = v39[2].Type + 1;
		                    memset(&v148.managedStack, 0, 20);
		                    goto LABEL_317;
		                  }
		                  v40 = *(_QWORD *)&v148.argumentBase[1].Value1;
		                  if ( !v40 )
		                    sub_1800D8250(SLODWORD(v148.evaluationStackBase), HIDWORD(v148.evaluationStackBase));
		                  if ( LODWORD(v148.evaluationStackBase) >= *(_DWORD *)(v40 + 24) )
		                    sub_1800D2AA0(
		                      SLODWORD(v148.evaluationStackBase),
		                      HIDWORD(v148.evaluationStackBase),
		                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::InputRippleData>::MoveNext);
		                  v41 = *(__m128 *)(v40 + 20LL * SLODWORD(v148.evaluationStackBase) + 32);
		                  *(__m128 *)&v148.managedStack = v41;
		                  v42 = *(float *)(v40 + 20LL * SLODWORD(v148.evaluationStackBase) + 48);
		                  *(float *)&v148.topWriteBack = v42;
		                  ++LODWORD(v148.evaluationStackBase);
		                  v44 = sub_183913BE0(
		                          _mm_unpacklo_ps(v41, _mm_shuffle_ps(v41, v41, 85)).m128_u64[0],
		                          _mm_unpacklo_ps(
		                            (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.x),
		                            (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.y)).m128_u64[0]);
		                }
		                while ( *(float *)&v44 > 32.0 );
		                v45 = v2->fields.m_RippleDataManager;
		                if ( !v45 )
		                  sub_1800D8250(v12, method);
		                v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		                  v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                }
		                v46 = **(_QWORD **)(v12 + 184);
		                if ( !v46 )
		                  sub_1800D8250(v12, 0LL);
		                if ( *(int *)(v46 + 24) <= 2306 )
		                  break;
		                if ( !*(_DWORD *)(v12 + 224) )
		                {
		                  il2cpp_runtime_class_init_1(v12);
		                  v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                }
		                v46 = **(_QWORD **)(v12 + 184);
		                if ( !v46 )
		                  sub_1800D8250(v12, 0LL);
		                if ( *(_DWORD *)(v46 + 24) <= 0x902u )
		                  sub_1800D2AA0(v12, v46, v43);
		                if ( !*(_QWORD *)(v46 + 18480) )
		                  break;
		                if ( !*(_DWORD *)(v12 + 224) )
		                {
		                  il2cpp_runtime_class_init_1(v12);
		                  v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                }
		                v47 = **(_QWORD **)(v12 + 184);
		                if ( !v47 )
		                  sub_1800D8250(0LL, v46);
		                if ( *(_DWORD *)(v47 + 24) <= 0x902u )
		                  sub_1800D2AA0(v47, v46, v43);
		                v48 = *(ILFixDynamicMethodWrapper_2 **)(v47 + 18480);
		                if ( !v48 )
		                  sub_1800D8250(0LL, v46);
		                *(__m128 *)&v151.argumentBase = v41;
		                *(float *)&v151.managedStack = v42;
		                IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(v48, (Object *)v45, (InputRippleData *)&v151, 0LL);
		              }
		              v49 = v45->fields._list;
		              if ( !v49 )
		                sub_1800D8250(v12, v46);
		              size = (unsigned int)v49->fields._size;
		              items = v49->fields._items;
		              if ( !items )
		                sub_1800D8250(v12, 0LL);
		              v52 = v45->fields._list;
		              if ( (int)size >= items->max_length.size )
		                break;
		              *(__m128 *)&call.argumentBase = v41;
		              *(float *)&call.managedStack = v42;
		              sub_1844C82D0(
		                v49,
		                &call,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
		              if ( IFix::WrappersManagerImpl::IsPatched(2307, 0LL) )
		              {
		                v71 = IFix::WrappersManagerImpl::GetPatch(2307, 0LL);
		                if ( !v71 )
		                  sub_1800D8250(v73, v72);
		                *(__m128 *)&call.argumentBase = v41;
		                *(float *)&call.managedStack = v42;
		                IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(v71, (Object *)v45, (InputRippleData *)&call, 0LL);
		              }
		              else
		              {
		                if ( v45->fields._minIndex == -1 )
		                  goto LABEL_111;
		                v66 = v45->fields._list;
		                minIndex = v45->fields._minIndex;
		                if ( !v66 )
		                  sub_1800D8250(0LL, method);
		                if ( (unsigned int)minIndex >= v66->fields._size )
		                  System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		                v68 = v66->fields._items;
		                if ( !v68 )
		                  sub_1800D8250(0LL, method);
		                if ( (unsigned int)minIndex >= v68->max_length.size )
		                  sub_1800D2AA0(v68, method, v65);
		                v69 = minIndex;
		                *(_OWORD *)&call.argumentBase = *(_OWORD *)&v68->vector[v69].positionXZ.x;
		                *(float *)&call.managedStack = v68->vector[v69].priority;
		                *(__m128 *)&v151.argumentBase = v41;
		                *(float *)&v151.managedStack = v42;
		                if ( HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(
		                       v45,
		                       (InputRippleData *)&v151,
		                       (InputRippleData *)&call,
		                       0LL) )
		                {
		LABEL_111:
		                  v70 = v45->fields._list;
		                  if ( !v70 )
		                    sub_1800D8250(v12, method);
		                  v45->fields._minIndex = v70->fields._size - 1;
		                }
		              }
		            }
		            v53 = v45->fields._minIndex;
		            if ( (unsigned int)v53 >= v52->fields._size )
		              System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		            v54 = v52->fields._items;
		            if ( (unsigned int)v53 >= v54->max_length.size )
		              sub_1800D2AA0(v12, v54, size);
		            v55 = v53;
		            v56 = *(__m128 *)&v54->vector[v55].positionXZ.x;
		            v57 = v54->vector[v55].priority;
		            if ( !*(_DWORD *)(v12 + 224) )
		            {
		              il2cpp_runtime_class_init_1(v12);
		              v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            method = **(MethodInfo ***)(v12 + 184);
		            if ( !method )
		              sub_1800D8250(v12, 0LL);
		            if ( SLODWORD(method->name) > 2309 )
		            {
		              if ( !*(_DWORD *)(v12 + 224) )
		              {
		                il2cpp_runtime_class_init_1(v12);
		                v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v12 = **(_QWORD **)(v12 + 184);
		              if ( !v12 )
		                sub_1800D8250(0LL, method);
		              if ( *(_DWORD *)(v12 + 24) <= 0x905u )
		                sub_1800D2AA0(v12, method, size);
		              if ( *(_QWORD *)(v12 + 18504) )
		                break;
		            }
		            if ( v42 > v57
		              || v42 == v57 && _mm_shuffle_ps(v56, v56, 255).m128_f32[0] > _mm_shuffle_ps(v41, v41, 255).m128_f32[0] )
		            {
		              goto LABEL_99;
		            }
		          }
		          v58 = IFix::WrappersManagerImpl::GetPatch(2309, 0LL);
		          if ( !v58 )
		            sub_1800D8250(v60, v59);
		          *(__m128 *)&v151.argumentBase = v56;
		          *(float *)&v151.managedStack = v57;
		          *(__m128 *)&call.argumentBase = v41;
		          *(float *)&call.managedStack = v42;
		          if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_916(
		                 v58,
		                 (Object *)v45,
		                 (InputRippleData *)&call,
		                 (InputRippleData *)&v151,
		                 0LL) )
		          {
		LABEL_99:
		            v61 = v45->fields._list;
		            v62 = v45->fields._minIndex;
		            if ( !v61 )
		              sub_1800D8250(0LL, method);
		            if ( (unsigned int)v62 >= v61->fields._size )
		              System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		            v63 = v61->fields._items;
		            if ( !v63 )
		              sub_1800D8250(v61, 0LL);
		            if ( (unsigned int)v62 >= v63->max_length.size )
		              sub_1800D2AA0(v61, v63, size);
		            v64 = v62;
		            *(__m128 *)&v63->vector[v64].positionXZ.x = v41;
		            v63->vector[v64].priority = v42;
		            ++v61->fields._version;
		            HG::Rendering::Runtime::RippleDataManager::FindMinIndex(v45, 0LL);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v153 )
		      {
		        method = (MethodInfo *)&v145;
		        *(Il2CppExceptionWrapper *)v146.m128_f32 = (Il2CppExceptionWrapper)v153->ex;
		        v12 = v146.m128_u64[0];
		        if ( v146.m128_u64[0] )
		          sub_18007E1E0(v146.m128_u64[0]);
		        v2 = this;
		      }
		LABEL_317:
		      v74 = v2->fields.m_RippleDataManager;
		      if ( !v74 )
		        goto LABEL_253;
		      v12 = (signed __int64)v74->fields._list;
		      if ( !v12 )
		        goto LABEL_253;
		      if ( *(int *)(v12 + 24) < 1 )
		        v2->fields.m_isRippleInputEmpty = 1;
		      HG::Rendering::Runtime::RippleDataManager::UpdateWaterState(v74, 0LL);
		      v2->fields.m_centerRippleData.size = 0.0;
		      x_low = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.x);
		      y_low = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.y);
		      v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      method = **(MethodInfo ***)(v12 + 184);
		      if ( !method )
		LABEL_253:
		        sub_1800D8250(v12, method);
		      if ( SLODWORD(method->name) > 2314 )
		      {
		        if ( !*(_DWORD *)(v12 + 224) )
		        {
		          il2cpp_runtime_class_init_1(v12);
		          v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        method = **(MethodInfo ***)(v12 + 184);
		        if ( !method )
		          goto LABEL_253;
		        if ( LODWORD(method->name) <= 0x90A )
		          goto LABEL_308;
		        if ( method[210].genericMethod )
		        {
		          if ( !*(_DWORD *)(v12 + 224) )
		          {
		            il2cpp_runtime_class_init_1(v12);
		            v12 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v78 = **(_QWORD **)(v12 + 184);
		          if ( !v78 )
		            goto LABEL_253;
		          if ( *(_DWORD *)(v78 + 24) > 0x90Au )
		          {
		            v79 = *(_QWORD *)(v78 + 18544);
		            if ( !v79 )
		              goto LABEL_253;
		            memset(&call, 0, sizeof(call));
		            v80 = IFix::Core::Call::Begin(&v151, 0LL);
		            v81 = *(__m128i *)&v80->argumentBase;
		            *(_OWORD *)&call.argumentBase = *(_OWORD *)&v80->argumentBase;
		            v82 = *(__m128i *)&v80->managedStack;
		            *(__m128i *)&call.managedStack = v82;
		            call.topWriteBack = v80->topWriteBack;
		            if ( *(_QWORD *)(v79 + 32) )
		            {
		              v83 = *(Object__Array ***)(v79 + 32);
		              v155 = (unsigned __int64)v83;
		              v84 = (_DWORD *)_mm_srli_si128(v82, 8).m128i_u64[0];
		              v85 = (signed __int64)v84 - _mm_srli_si128(v81, 8).m128i_u64[0];
		              *((_QWORD *)&v86 + 1) = (unsigned __int128)(v85 * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		              v87 = v85 / 12;
		              if ( !v84 )
		                goto LABEL_307;
		              *v84 = 8;
		              if ( !call.currentTop )
		                goto LABEL_307;
		              call.currentTop->Value1 = v87;
		              managedStack = call.managedStack;
		              if ( !call.managedStack )
		                goto LABEL_307;
		              element_class = call.managedStack->klass->_0.element_class;
		              v156 = *v83;
		              if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, v156)
		                && ((v156[1].max_length.size & 0x1000) == 0
		                 || ((element_class->flags & 0x20) == 0
		                  && *((_BYTE *)&element_class->byval_arg + 10) != 19
		                  && *((_BYTE *)&element_class->byval_arg + 10) != 30
		                  || !element_class->interopData
		                  || !element_class->interopData->guid
		                  || !sub_1802ED414(v155))
		                 && element_class != (Il2CppClass *)qword_18F35FF70) )
		              {
		                v142 = sub_18031E23C();
		                sub_18007E190(v142, 0LL);
		              }
		              sub_180005370(managedStack, (int)v87, v155);
		              currentTop = ++call.currentTop;
		            }
		            else
		            {
		              currentTop = call.currentTop;
		            }
		            v85 = (char *)currentTop - (char *)call.evaluationStackBase;
		            *((_QWORD *)&v86 + 1) = (unsigned __int128)(((char *)currentTop - (char *)call.evaluationStackBase)
		                                                      * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		            v91 = currentTop - call.evaluationStackBase;
		            if ( currentTop )
		            {
		              currentTop->Type = 8;
		              if ( call.currentTop )
		              {
		                call.currentTop->Value1 = v91;
		                v92 = call.managedStack;
		                if ( call.managedStack )
		                {
		                  v93 = call.managedStack->klass->_0.element_class;
		                  v155 = (unsigned __int64)v2->klass;
		                  if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v93, v155)
		                    && ((*(_BYTE *)(v155 + 313) & 0x10) == 0
		                     || ((v93->flags & 0x20) == 0
		                      && *((_BYTE *)&v93->byval_arg + 10) != 19
		                      && *((_BYTE *)&v93->byval_arg + 10) != 30
		                      || !v93->interopData
		                      || !v93->interopData->guid
		                      || !sub_1802ED414(v2))
		                     && v93 != (Il2CppClass *)qword_18F35FF70) )
		                  {
		                    v143 = sub_18031E23C();
		                    sub_18007E190(v143, 0LL);
		                  }
		                  sub_180005370(v92, (int)v91, v2);
		                  ++call.currentTop;
		                  v155 = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		                  v94 = (unsigned __int64 *)il2cpp_value_box_0(TypeInfo::UnityEngine::Vector2, &v155);
		                  v86 = ((char *)call.currentTop - (char *)call.evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL;
		                  v85 = *((_QWORD *)&v86 + 1) >> 63;
		                  v95 = call.currentTop - call.evaluationStackBase;
		                  if ( call.currentTop )
		                  {
		                    call.currentTop->Type = 9;
		                    if ( call.currentTop )
		                    {
		                      call.currentTop->Value1 = v95;
		                      *((_QWORD *)&v86 + 1) = call.managedStack;
		                      v156 = call.managedStack;
		                      if ( call.managedStack )
		                      {
		                        if ( v94 )
		                        {
		                          v96 = call.managedStack->klass->_0.element_class;
		                          v155 = *v94;
		                          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v96, v155)
		                            && ((*(_BYTE *)(v155 + 313) & 0x10) == 0
		                             || ((v96->flags & 0x20) == 0
		                              && *((_BYTE *)&v96->byval_arg + 10) != 19
		                              && *((_BYTE *)&v96->byval_arg + 10) != 30
		                              || !v96->interopData
		                              || !v96->interopData->guid
		                              || !sub_1802ED414(v94))
		                             && v96 != (Il2CppClass *)qword_18F35FF70) )
		                          {
		                            v144 = sub_18031E23C();
		                            sub_18007E190(v144, 0LL);
		                          }
		                        }
		                        sub_180005370(v156, (int)v95, v94);
		                        v97 = call.currentTop == (Value_1 *)-12LL;
		                        *(_QWORD *)&v86 = ++call.currentTop;
		                        if ( !v97 )
		                        {
		                          *(_DWORD *)(v86 + 4) = 0;
		                          if ( call.currentTop )
		                          {
		                            call.currentTop->Type = 2;
		                            v97 = call.currentTop == (Value_1 *)-12LL;
		                            v98 = ++call.currentTop;
		                            if ( !v97 )
		                            {
		                              v98->Value1 = 0;
		                              if ( call.currentTop )
		                              {
		                                call.currentTop->Type = 2;
		                                ++call.currentTop;
		                                v85 = *(_QWORD *)(v79 + 16);
		                                if ( v85 )
		                                {
		                                  IFix::Core::VirtualMachine::Execute(
		                                    (VirtualMachine *)v85,
		                                    *(_DWORD *)(v79 + 24),
		                                    &call,
		                                    (*(_QWORD *)(v79 + 32) != 0LL) + 4,
		                                    0,
		                                    0LL);
		                                  v100 = MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>;
		                                  if ( !MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>->rgctx_data )
		                                    sub_1800430B0(MethodInfo::IFix::Core::Call::GetAsType<UnityEngine::Vector4>);
		                                  if ( !byte_18F3963A0 )
		                                  {
		                                    v101 = _InterlockedExchangeAdd64(
		                                             (volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetObject,
		                                             0LL);
		                                    if ( (v101 & 1) != 0 )
		                                    {
		                                      v102 = (v101 >> 1) & 0xFFFFFFF;
		                                      switch ( v101 >> 29 )
		                                      {
		                                        case 1u:
		                                          *((_QWORD *)&v86 + 1) = sub_180036020((unsigned int)v102);
		                                          goto LABEL_215;
		                                        case 2u:
		                                          *((_QWORD *)&v86 + 1) = sub_1800362C0((unsigned int)v102);
		                                          goto LABEL_215;
		                                        case 3u:
		                                        case 6u:
		                                          v103 = (v101 >> 1) & 0xFFFFFFF;
		                                          v104 = v101 >> 29;
		                                          if ( v104 )
		                                          {
		                                            if ( v104 == 3 )
		                                            {
		                                              *((_QWORD *)&v86 + 1) = sub_180009A40(v103);
		                                              goto LABEL_215;
		                                            }
		                                            if ( v104 == 6 )
		                                            {
		                                              v105 = sub_1802F8800(v103);
		                                              *((_QWORD *)&v86 + 1) = sub_180026660(v105, 0LL);
		                                              goto LABEL_215;
		                                            }
		                                          }
		                                          else if ( v103 == 1 )
		                                          {
		                                            *((_QWORD *)&v86 + 1) = off_18B8C2EC0;
		                                            goto LABEL_215;
		                                          }
		LABEL_214:
		                                          *((_QWORD *)&v86 + 1) = 0LL;
		LABEL_215:
		                                          if ( *((_QWORD *)&v86 + 1) )
		                                            *((_QWORD *)&v86 + 1) = _InterlockedExchange64(
		                                                                      (volatile __int64 *)&MethodInfo::IFix::Core::Call::GetObject,
		                                                                      *((__int64 *)&v86 + 1));
		                                          break;
		                                        case 4u:
		                                          *((_QWORD *)&v86 + 1) = sub_1802F8760((unsigned int)v102);
		                                          goto LABEL_215;
		                                        case 5u:
		                                          if ( *(_QWORD *)(qword_18F371F68 + 8 * v102) )
		                                          {
		                                            *((_QWORD *)&v86 + 1) = *(_QWORD *)(qword_18F371F68 + 8 * v102);
		                                          }
		                                          else
		                                          {
		                                            v106 = il2cpp_string_new_len(
		                                                     qword_18F360DF8
		                                                   + *(int *)(qword_18F360DF8
		                                                            + *(int *)(qword_18F360E00 + 8)
		                                                            + 8 * v102
		                                                            + 4)
		                                                   + *(int *)(qword_18F360E00 + 16),
		                                                     *(unsigned int *)(qword_18F360DF8
		                                                                     + *(int *)(qword_18F360E00 + 8)
		                                                                     + 8 * v102));
		                                            *((_QWORD *)&v86 + 1) = _InterlockedCompareExchange64(
		                                                                      (volatile signed __int64 *)(qword_18F371F68
		                                                                                                + 8 * v102),
		                                                                      v106,
		                                                                      0LL);
		                                            if ( !*((_QWORD *)&v86 + 1) )
		                                            {
		                                              if ( dword_18F35FD08 )
		                                              {
		                                                v107 = (((unsigned __int64)(qword_18F371F68 + 8 * v102) >> 12) & 0x1FFFFF) >> 6;
		                                                v99 = ((unsigned __int64)(qword_18F371F68 + 8 * v102) >> 12) & 0x3F;
		                                                _m_prefetchw(&qword_18F103690[v107]);
		                                                do
		                                                  v108 = qword_18F103690[v107];
		                                                while ( v108 != _InterlockedCompareExchange64(
		                                                                  &qword_18F103690[v107],
		                                                                  v108 | (1LL << v99),
		                                                                  v108) );
		                                              }
		                                              *((_QWORD *)&v86 + 1) = v106;
		                                            }
		                                          }
		                                          goto LABEL_215;
		                                        case 7u:
		                                          v109 = sub_1802F8760((unsigned int)v102);
		                                          v110 = *(_QWORD *)(v109 + 16);
		                                          v111 = (v109 - *(_QWORD *)(v110 + 128)) >> 5;
		                                          if ( *(_BYTE *)(v110 + 42) == 21 )
		                                          {
		                                            v112 = *(_QWORD ***)(v110 + 96);
		                                            if ( *v112 )
		                                            {
		                                              v113 = **v112 - *(int *)(qword_18F360E00 + 160) - qword_18F360DF8;
		                                              v110 = sub_180009B10(v113 / 92 + v113);
		                                            }
		                                            else
		                                            {
		                                              v110 = 0LL;
		                                            }
		                                          }
		                                          v146.m128_i32[0] = v111 + *(_DWORD *)(*(_QWORD *)(v110 + 104) + 32LL);
		                                          v114 = sub_1801CD744(
		                                                   (unsigned int)&v146,
		                                                   (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                                                   *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                                                   12,
		                                                   (__int64)sub_1802F7130);
		                                          if ( !v114 )
		                                            goto LABEL_214;
		                                          v115 = *(unsigned int *)(v114 + 8);
		                                          if ( (_DWORD)v115 == -1 )
		                                            goto LABEL_214;
		                                          *((_QWORD *)&v86 + 1) = qword_18F360DF8
		                                                                + *(int *)(qword_18F360E00 + 72)
		                                                                + v115;
		                                          goto LABEL_215;
		                                        default:
		                                          break;
		                                      }
		                                    }
		                                    byte_18F3963A0 = 1;
		                                  }
		                                  v85 = (signed __int64)call.argumentBase;
		                                  if ( call.argumentBase && call.managedStack )
		                                  {
		                                    Value1 = call.argumentBase->Value1;
		                                    if ( (unsigned int)Value1 >= call.managedStack->max_length.size )
		                                      sub_1800D2AA0(call.argumentBase, *((_QWORD *)&v86 + 1), v99);
		                                    v117 = call.managedStack->vector[Value1];
		                                    sub_180005370(call.managedStack, call.argumentBase - call.evaluationStackBase, 0LL);
		                                    *(_QWORD *)&v86 = v100->rgctx_data->rgctxDataDummy;
		                                    if ( (*(_BYTE *)(v86 + 312) & 1) == 0 )
		                                      sub_1800360B0(v100->rgctx_data->rgctxDataDummy, *((_QWORD *)&v86 + 1));
		                                    if ( v117 )
		                                    {
		                                      if ( v117->klass->_0.element_class != *(Il2CppClass **)(v86 + 64) )
		                                        sub_18031E1F4(v117, v86);
		                                      v118 = (__m128)v117[1];
		LABEL_227:
		                                      *(__m128 *)v2->fields.waterRippleData.m_Buffer = v118;
		                                      v121 = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.x);
		                                      v122 = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.y);
		                                      v121.m128_f32[0] = (float)((float)(v121.m128_f32[0]
		                                                                       - v2->fields.m_lastCenterRippleData.positionXZ.x)
		                                                               * 0.03125)
		                                                       * 0.5;
		                                      v122.m128_f32[0] = (float)((float)(v122.m128_f32[0]
		                                                                       - v2->fields.m_lastCenterRippleData.positionXZ.y)
		                                                               * 0.03125)
		                                                       * 0.5;
		                                      *(Vector4 *)&v2->fields.waterRippleData.m_Buffer[16] = *HG::Rendering::Runtime::HGWaterManager::ToVector4(
		                                                                                                (Vector4 *)&v146,
		                                                                                                v2,
		                                                                                                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v121, v122),
		                                                                                                32.0,
		                                                                                                0.0,
		                                                                                                0LL);
		                                      method = (MethodInfo *)v2->fields.m_hgWaterInteractiveSetting;
		                                      if ( method )
		                                      {
		                                        v123 = *(float *)&method->rgctx_data;
		                                        v124 = *((float *)&method->methodMetadataHandle + 1);
		                                        v125 = *((float *)&method->return_type + 1);
		                                        v146.m128_i32[3] = 0;
		                                        m_Buffer = (Vector4 *)v2->fields.waterRippleData.m_Buffer;
		                                        v127 = v146;
		                                        v127.m128_f32[0] = v123;
		                                        v128 = _mm_shuffle_ps(v127, v127, 225);
		                                        v128.m128_f32[0] = v124;
		                                        v129 = _mm_shuffle_ps(v128, v128, 198);
		                                        v129.m128_f32[0] = v125;
		                                        v146 = _mm_shuffle_ps(v129, v129, 201);
		                                        m_Buffer[2] = (Vector4)v146;
		                                        v75 = v2->fields.m_hgWaterInteractiveSetting;
		                                        if ( v75 )
		                                        {
		                                          v130 = (Vector4 *)v2->fields.waterRippleData.m_Buffer;
		                                          v131 = _mm_shuffle_ps(
		                                                   (__m128)LODWORD(v75->fields.interactiveDamp),
		                                                   (__m128)LODWORD(v75->fields.interactiveDamp),
		                                                   225);
		                                          v131.m128_f32[0] = v75->fields.interactiveAlpha;
		                                          v132 = _mm_shuffle_ps(v131, v131, 198);
		                                          v132.m128_f32[0] = v75->fields.interactiveBeta;
		                                          v133 = _mm_shuffle_ps(v132, v132, 39);
		                                          v133.m128_f32[0] = v75->fields.interactiveSpeed;
		                                          v146 = _mm_shuffle_ps(v133, v133, 57);
		                                          v130[3] = (Vector4)v146;
		                                          v134 = 0;
		                                          v135 = 64LL;
		                                          v136 = v150;
		                                          while ( 1 )
		                                          {
		                                            v137 = v2->fields.m_RippleDataManager;
		                                            if ( !v137 )
		                                              break;
		                                            v12 = (signed __int64)v137->fields._list;
		                                            if ( !v12 )
		                                              break;
		                                            if ( *(_DWORD *)(v12 + 24) > v134 )
		                                            {
		                                              v138 = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.x);
		                                              v139 = (__m128)LODWORD(v2->fields.m_centerRippleData.positionXZ.y);
		                                              v138.m128_f32[0] = v138.m128_f32[0] + v138.m128_f32[0];
		                                              v139.m128_f32[0] = v139.m128_f32[0] + v139.m128_f32[0];
		                                              if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		                                                goto LABEL_309;
		                                              v12 = *(_QWORD *)(v12 + 16);
		                                              if ( !v12 )
		                                                goto LABEL_253;
		                                              if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		                                                goto LABEL_308;
		                                              v140 = *(__m128 *)(v12 + 20LL * v134 + 32);
		                                              v138.m128_f32[0] = v138.m128_f32[0] - v140.m128_f32[0];
		                                              v139.m128_f32[0] = v139.m128_f32[0]
		                                                               - _mm_shuffle_ps(v140, v140, 85).m128_f32[0];
		                                              v12 = (signed __int64)v2->fields.m_RippleDataManager;
		                                              if ( !v12 )
		                                                goto LABEL_253;
		                                              v12 = *(_QWORD *)(v12 + 16);
		                                              if ( !v12 )
		                                                goto LABEL_253;
		                                              if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		                                                goto LABEL_309;
		                                              v12 = *(_QWORD *)(v12 + 16);
		                                              if ( !v12 )
		                                                goto LABEL_253;
		                                              if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		                                                goto LABEL_308;
		                                              if ( *(float *)(v12 + 20LL * v134 + 40) >= 0.001 )
		                                              {
		                                                v12 = (signed __int64)v2->fields.m_RippleDataManager;
		                                                if ( !v12 )
		                                                  goto LABEL_253;
		                                                v12 = *(_QWORD *)(v12 + 16);
		                                                if ( !v12 )
		                                                  goto LABEL_253;
		                                                if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		LABEL_309:
		                                                  System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		                                                v12 = *(_QWORD *)(v12 + 16);
		                                                if ( !v12 )
		                                                  goto LABEL_253;
		                                                if ( (unsigned int)v134 >= *(_DWORD *)(v12 + 24) )
		                                                  goto LABEL_308;
		                                                v141 = 1.0 / *(float *)(v12 + 20LL * v134 + 40);
		                                              }
		                                              else
		                                              {
		                                                v141 = 0.0;
		                                              }
		                                              *(Vector4 *)&v136->fields.waterRippleData.m_Buffer[v135] = *HG::Rendering::Runtime::HGWaterManager::ToVector4((Vector4 *)&v146, v2, (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v138, v139), v141, 1.0, 0LL);
		                                            }
		                                            else
		                                            {
		                                              *(_OWORD *)&v2->fields.waterRippleData.m_Buffer[v135] = 0LL;
		                                            }
		                                            ++v134;
		                                            v135 += 16LL;
		                                            if ( v134 >= 8 )
		                                              return;
		                                          }
		                                        }
		                                      }
		                                      goto LABEL_253;
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
		LABEL_307:
		            sub_1800D8250(v85, *((_QWORD *)&v86 + 1));
		          }
		LABEL_308:
		          sub_1800D2AA0(v12, method, v75);
		        }
		      }
		      v119 = (__m128)v146.m128_u64[0];
		      v119.m128_f32[0] = x_low.m128_f32[0];
		      v120 = _mm_shuffle_ps(v119, v119, 225);
		      v120.m128_f32[0] = y_low.m128_f32[0];
		      v118 = _mm_shuffle_ps(v120, v120, 225);
		      v146 = v118;
		      goto LABEL_227;
		    }
		  }
		}
		
		public void AddWaterRippleData(float rippleSize, Vector2 ripplePostion, int priority = 0 /* Metadata: 0x0230449D */) {} // 0x0000000183EFA840-0x0000000183EFA940
		// Void AddWaterRippleData(Single, Vector2, Int32)
		void HG::Rendering::Runtime::HGWaterManager::AddWaterRippleData(
		        HGWaterManager *this,
		        float rippleSize,
		        Vector2 ripplePostion,
		        int32_t priority,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // r9
		  __m128 v11; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128 v13; // [rsp+30h] [rbp-48h] BYREF
		  float v14; // [rsp+40h] [rbp-38h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 5364 )
		    goto LABEL_5;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		LABEL_7:
		    sub_1800D8260(v6, wrapperArray);
		  if ( LODWORD(v6->_0.namespaze) <= 0x14F4 )
		    sub_1800D2AB0(v6, wrapperArray);
		  if ( v6[114]._0.declaringType )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5364, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1550(Patch, (Object *)this, rippleSize, ripplePostion, priority, 0LL);
		      return;
		    }
		    goto LABEL_7;
		  }
		LABEL_5:
		  if ( rippleSize > 0.0 )
		  {
		    m_rawRippleDataList = this->fields.m_rawRippleDataList;
		    v13.m128_u64[1] = LODWORD(rippleSize);
		    v6 = 0LL;
		    *(Vector2 *)v13.m128_f32 = ripplePostion;
		    if ( !m_rawRippleDataList )
		      goto LABEL_7;
		    v13.m128_i32[3] = 0;
		    v11 = _mm_shuffle_ps(v13, v13, 210);
		    v11.m128_f32[0] = rippleSize;
		    v14 = (float)priority;
		    v13 = _mm_shuffle_ps(v11, v11, 201);
		    sub_1844C82D0(
		      m_rawRippleDataList,
		      &v13,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
		  }
		}
		
		public void SetTerrainRippleOpacity(float terrainRippleOpacity) {} // 0x0000000183F632B0-0x0000000183F632F0
		// Void SetTerrainRippleOpacity(Single)
		void HG::Rendering::Runtime::HGWaterManager::SetTerrainRippleOpacity(
		        HGWaterManager *this,
		        float terrainRippleOpacity,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5365, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5365, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      terrainRippleOpacity,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_terrainRippleOpacity = terrainRippleOpacity;
		  }
		}
		
		public float GetTerrainRippleOpacity() => default; // 0x0000000183D43CA0-0x0000000183D43D00
		// Single GetTerrainRippleOpacity()
		float HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(HGWaterManager *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 935 )
		    return this->fields.m_terrainRippleOpacity;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3A7 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[19].vtable.ToString.method )
		    return this->fields.m_terrainRippleOpacity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(935, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetShouldRenderRippleState(bool shouldRenderRipple) {} // 0x00000001845D4690-0x00000001845D46D0
		// Void SetShouldRenderRippleState(Boolean)
		void HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState(
		        HGWaterManager *this,
		        bool shouldRenderRipple,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2313, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2313, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      shouldRenderRipple,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_shouldRenderRipple = shouldRenderRipple;
		  }
		}
		
		public void ResetWaterRipple() {} // 0x0000000183335FC0-0x0000000183336030
		// Void ResetWaterRipple()
		void HG::Rendering::Runtime::HGWaterManager::ResetWaterRipple(HGWaterManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *m_rawRippleDataList; // rax
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
		  if ( wrapperArray->max_length.size <= 2288 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x8F0 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[48]._1.field_count )
		  {
		LABEL_5:
		    m_rawRippleDataList = this->fields.m_rawRippleDataList;
		    if ( m_rawRippleDataList )
		    {
		      ++m_rawRippleDataList->fields._version;
		      m_rawRippleDataList->fields._size = 0;
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2288, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public bool GetShouldRenderRippleState() => default; // 0x0000000183C04DD0-0x0000000183C04E40
		// Boolean GetShouldRenderRippleState()
		bool HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(HGWaterManager *this, MethodInfo *method)
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
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 963 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3C3 )
		        sub_1800D2AB0(v3, method);
		      if ( !*(_QWORD *)&v3[20]._1.initializationExceptionGCHandle )
		        return !HG::Rendering::Runtime::WaterQualityHelper::ShouldDisableMobileRipple(0LL)
		            && this->fields.m_shouldRenderRipple;
		      Patch = IFix::WrappersManagerImpl::GetPatch(963, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, method);
		  }
		  return !HG::Rendering::Runtime::WaterQualityHelper::ShouldDisableMobileRipple(0LL)
		      && this->fields.m_shouldRenderRipple;
		}
		
		public bool CheckIfRippleDataIsEmpty() => default; // 0x0000000189C6377C-0x0000000189C637E4
		// Boolean CheckIfRippleDataIsEmpty()
		bool HG::Rendering::Runtime::HGWaterManager::CheckIfRippleDataIsEmpty(HGWaterManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rcx
		  RippleDataManager *m_RippleDataManager; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5366, 0LL) )
		  {
		    m_RippleDataManager = this->fields.m_RippleDataManager;
		    if ( m_RippleDataManager )
		    {
		      list = m_RippleDataManager->fields._list;
		      if ( list )
		        return list->fields._size > 0;
		    }
		LABEL_6:
		    sub_1800D8260(list, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5366, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public float _CalculateCharacterRippleSize(float speed, float waterDepth, bool isLanding = false /* Metadata: 0x0230449E */, bool isGrounded = false /* Metadata: 0x0230449F */, bool hitTerrainWater = false /* Metadata: 0x023044A0 */, bool hitLiquidWater = false /* Metadata: 0x023044A1 */) => default; // 0x0000000183771680-0x0000000183771AE0
		// Single _CalculateCharacterRippleSize(Single, Single, Boolean, Boolean, Boolean, Boolean)
		float HG::Rendering::Runtime::HGWaterManager::_CalculateCharacterRippleSize(
		        HGWaterManager *this,
		        float speed,
		        float waterDepth,
		        bool isLanding,
		        bool isGrounded,
		        bool hitTerrainWater,
		        bool hitLiquidWater,
		        MethodInfo *method)
		{
		  _QWORD **v9; // rcx
		  __int64 v11; // rdx
		  HGWaterInteractiveSetting *m_hgWaterInteractiveSetting; // rdi
		  HGWaterInteractiveSetting *v13; // rax
		  float moveRippleFrequency; // xmm8_4
		  float stillRippleFrequency; // xmm15_4
		  float interactiveRippleSize; // xmm13_4
		  float v17; // xmm6_4
		  float v18; // xmm7_4
		  float v19; // xmm0_4
		  float v20; // xmm8_4
		  float v21; // xmm11_4
		  float v22; // xmm8_4
		  float v23; // xmm0_4
		  HGWaterInteractiveSetting *v24; // rax
		  float v25; // xmm2_4
		  float result; // xmm0_4
		  Beyond::JobMathf *v27; // rcx
		  float v28; // xmm4_4
		  float v29; // xmm4_4
		  float v30; // xmm9_4
		  float time; // xmm8_4
		  float v32; // xmm6_4
		  Beyond::JobMathf *v33; // rcx
		  float v34; // xmm0_4
		  float v35; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v37; // rax
		
		  v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *v9[23];
		  if ( !v11 )
		    goto LABEL_43;
		  if ( *(int *)(v11 + 24) > 5367 )
		  {
		    if ( !*((_DWORD *)v9 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v11 = *v9[23];
		    if ( !v11 )
		      goto LABEL_43;
		    if ( *(_DWORD *)(v11 + 24) <= 0x14F7u )
		      goto LABEL_61;
		    if ( *(_QWORD *)(v11 + 42968) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5367, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1551(
		                 Patch,
		                 (Object *)this,
		                 speed,
		                 waterDepth,
		                 isLanding,
		                 isGrounded,
		                 hitTerrainWater,
		                 hitLiquidWater,
		                 0LL);
		      goto LABEL_43;
		    }
		  }
		  v9 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  m_hgWaterInteractiveSetting = this->fields.m_hgWaterInteractiveSetting;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v9 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_hgWaterInteractiveSetting )
		    return 0.0;
		  if ( !*((_DWORD *)v9 + 56) )
		    il2cpp_runtime_class_init_1(v9);
		  if ( !m_hgWaterInteractiveSetting->fields._._.m_CachedPtr )
		    return 0.0;
		  v13 = this->fields.m_hgWaterInteractiveSetting;
		  if ( !v13 )
		    goto LABEL_43;
		  moveRippleFrequency = v13->fields.moveRippleFrequency;
		  stillRippleFrequency = v13->fields.stillRippleFrequency;
		  interactiveRippleSize = v13->fields.interactiveRippleSize;
		  v17 = 1.0 / speed;
		  if ( (float)(1.0 / speed) > 1.0 )
		    v17 = 1.0;
		  if ( v17 < 0.0 )
		    v17 = 0.0;
		  v18 = v17 * *(float *)(Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v9, speed) + 64);
		  if ( !TypeInfo::Beyond::RandomUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::Beyond::RandomUtils);
		  v19 = Beyond::RandomUtils::Value(0LL);
		  v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v20 = moveRippleFrequency - v18;
		  v21 = v19;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *v9[23];
		  if ( !v11 )
		    goto LABEL_43;
		  if ( *(int *)(v11 + 24) <= 5363 )
		    goto LABEL_21;
		  if ( !*((_DWORD *)v9 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v9 = (_QWORD **)*v9[23];
		  if ( !v9 )
		LABEL_43:
		    sub_1800D8260(v9, v11);
		  if ( *((_DWORD *)v9 + 6) <= 0x14F3u )
		LABEL_61:
		    sub_1800D2AB0(v9, v11);
		  if ( !v9[5367] )
		  {
		LABEL_21:
		    if ( v21 > v20 )
		      v22 = 0.0;
		    else
		      v22 = 1.0;
		    goto LABEL_23;
		  }
		  v37 = IFix::WrappersManagerImpl::GetPatch(5363, 0LL);
		  if ( !v37 )
		    goto LABEL_43;
		  v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_107(
		          (ILFixDynamicMethodWrapper_6 *)v37,
		          (Object *)this,
		          v21,
		          v20,
		          0LL);
		LABEL_23:
		  if ( waterDepth > 0.5 )
		    v22 = 0.0;
		  if ( !TypeInfo::Beyond::RandomUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::Beyond::RandomUtils);
		  v23 = Beyond::RandomUtils::Value(0LL);
		  v24 = this->fields.m_hgWaterInteractiveSetting;
		  if ( !v24 )
		    goto LABEL_43;
		  v25 = (float)((float)((float)(v23 - 0.5) * 0.039999999) + interactiveRippleSize)
		      + (float)(v17 * v24->fields.characterSpeedRippleSizeInfluence);
		  if ( (hitTerrainWater || hitLiquidWater) && isGrounded )
		  {
		    Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v9, speed);
		    Beyond::JobMathf::Clamp01(v27, speed);
		    v29 = v28 * (float)((float)(speed * 0.039999999) + v25);
		    if ( v22 < 0.0 )
		    {
		      v22 = 0.0;
		    }
		    else if ( v22 > 1.0 )
		    {
		      v22 = 1.0;
		    }
		    v30 = (float)((float)(0.0 - v29) * v22) + v29;
		    time = UnityEngine::Time::get_time(0LL);
		    if ( !TypeInfo::Beyond::RandomUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::Beyond::RandomUtils);
		    v32 = Beyond::RandomUtils::Value(0LL);
		    Beyond::JobMathf::Fmod(v33, 1024.0, v25);
		    v34 = HG::Rendering::Runtime::HGWaterManager::Frac(this, v32 + time, 0LL);
		    v35 = HG::Rendering::Runtime::HGWaterManager::Step(this, v34, stillRippleFrequency, 0LL);
		    result = (float)(HG::Rendering::Runtime::HGWaterManager::Step(this, speed, 0.050000001, 0LL)
		                   * (float)(v35 * interactiveRippleSize))
		           + v30;
		  }
		  else
		  {
		    result = 0.0;
		  }
		  if ( (hitLiquidWater || hitTerrainWater) && isLanding )
		    return result + (float)(interactiveRippleSize + 0.2);
		  return result;
		}
		
		public void UpdateTerrainRippleInfo(ColliderSurfaceType curColliderSurfaceType) {} // 0x0000000183EBBE70-0x0000000183EBC0D0
		// Void UpdateTerrainRippleInfo(ColliderSurfaceType)
		void HG::Rendering::Runtime::HGWaterManager::UpdateTerrainRippleInfo(
		        HGWaterManager *this,
		        ColliderSurfaceType__Enum curColliderSurfaceType,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  struct Object_1__Class *entries; // rcx
		  HGWaterInteractiveSetting *m_hgWaterInteractiveSetting; // rdi
		  HGWaterInteractiveSetting *v8; // rax
		  float rippleStrengthLerpTime; // xmm7_4
		  Dictionary_2_System_Int32Enum_System_Single_ *terrainRippleStrengthConfig; // rsi
		  struct MethodInfo *v11; // rdi
		  int32_t Entry; // eax
		  float v13; // xmm6_4
		  HGWaterInteractiveSetting *v14; // rax
		  float time; // xmm0_4
		  float m_terrainRippleStrength; // xmm1_4
		  float v17; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float value; // [rsp+68h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5368, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5368, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)this,
		        curColliderSurfaceType,
		        0LL);
		      return;
		    }
		    goto LABEL_29;
		  }
		  entries = TypeInfo::UnityEngine::Object;
		  m_hgWaterInteractiveSetting = this->fields.m_hgWaterInteractiveSetting;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    entries = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      entries = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_hgWaterInteractiveSetting )
		  {
		    if ( !entries->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(entries);
		    if ( m_hgWaterInteractiveSetting->fields._._.m_CachedPtr )
		    {
		      v8 = this->fields.m_hgWaterInteractiveSetting;
		      if ( v8 )
		      {
		        if ( !v8->fields.terrainRippleStrengthConfig )
		          return;
		        rippleStrengthLerpTime = v8->fields.rippleStrengthLerpTime;
		        terrainRippleStrengthConfig = (Dictionary_2_System_Int32Enum_System_Single_ *)v8->fields.terrainRippleStrengthConfig;
		        v11 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue;
		        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		              + 4) )
		          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		        Entry = System::Collections::Generic::Dictionary<System::Int32Enum,float>::FindEntry(
		                  terrainRippleStrengthConfig,
		                  (Int32Enum__Enum)curColliderSurfaceType,
		                  (MethodInfo *)v11->klass->rgctx_data[22].rgctxDataDummy);
		        if ( Entry < 0 )
		        {
		          value = 0.0;
		          v14 = this->fields.m_hgWaterInteractiveSetting;
		          if ( v14 )
		          {
		            entries = (struct Object_1__Class *)v14->fields.terrainRippleStrengthConfig;
		            if ( entries )
		            {
		              System::Collections::Generic::Dictionary<System::Int32Enum,float>::TryGetValue(
		                (Dictionary_2_System_Int32Enum_System_Single_ *)entries,
		                (Int32Enum__Enum)0,
		                &value,
		                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::ColliderSurfaceType,float>::TryGetValue);
		              v13 = value;
		LABEL_18:
		              if ( fabs(v13 - this->fields.m_terrainRippleStrength) > 0.001 )
		              {
		                this->fields.m_lerpStartTimeTime = UnityEngine::Time::get_time(0LL);
		                this->fields.m_terrainRippleStrength = v13;
		                this->fields.m_isOnLerpProcedural = 1;
		              }
		              if ( this->fields.m_isOnLerpProcedural )
		              {
		                time = UnityEngine::Time::get_time(0LL);
		                m_terrainRippleStrength = this->fields.m_terrainRippleStrength;
		                v17 = (float)(time - this->fields.m_lerpStartTimeTime) / rippleStrengthLerpTime;
		                if ( v17 >= 1.0 )
		                {
		                  this->fields.m_terrainRippleNormalStrength = m_terrainRippleStrength;
		                  this->fields.m_isOnLerpProcedural = 0;
		                }
		                else
		                {
		                  if ( v17 < 0.0 )
		                  {
		                    v17 = 0.0;
		                  }
		                  else if ( v17 > 1.0 )
		                  {
		                    v17 = 1.0;
		                  }
		                  this->fields.m_terrainRippleNormalStrength = (float)((float)(m_terrainRippleStrength
		                                                                             - this->fields.m_terrainRippleNormalStrength)
		                                                                     * v17)
		                                                             + this->fields.m_terrainRippleNormalStrength;
		                }
		              }
		              return;
		            }
		          }
		        }
		        else
		        {
		          entries = (struct Object_1__Class *)terrainRippleStrengthConfig->fields._entries;
		          if ( entries )
		          {
		            if ( (unsigned int)Entry >= LODWORD(entries->_0.namespaze) )
		              sub_1800D2AB0(entries, v5);
		            v13 = *((float *)&entries->_0.byval_arg + 4 * Entry + 3);
		            goto LABEL_18;
		          }
		        }
		      }
		LABEL_29:
		      sub_1800D8260(entries, v5);
		    }
		  }
		}
		
		public void StopUpdateBoatPosition() {} // 0x0000000189C64120-0x0000000189C64170
		// Void StopUpdateBoatPosition()
		void HG::Rendering::Runtime::HGWaterManager::StopUpdateBoatPosition(HGWaterManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5369, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5369, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_isBoatStop = 1;
		  }
		}
		
		public void StartUpdateBoatPosition() {} // 0x0000000189C640D0-0x0000000189C64120
		// Void StartUpdateBoatPosition()
		void HG::Rendering::Runtime::HGWaterManager::StartUpdateBoatPosition(HGWaterManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5370, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5370, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_isBoatStop = 0;
		  }
		}
		
		public void SetBoatPositionSpeed(List<Vector3> boatAnchors, float boatSpeed) {} // 0x0000000189C63DBC-0x0000000189C63F34
		// Void SetBoatPositionSpeed(List`1[UnityEngine.Vector3], Single)
		void HG::Rendering::Runtime::HGWaterManager::SetBoatPositionSpeed(
		        HGWaterManager *this,
		        List_1_UnityEngine_Vector3_ *boatAnchors,
		        float boatSpeed,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  int32_t size; // esi
		  int32_t i; // ebp
		  float time; // xmm6_4
		  float v11; // xmm0_4
		  Beyond::JobMathf *v12; // rcx
		  Beyond::DampingMath *v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  DynamicStreamingScene_LodRawInfo v15; // [rsp+30h] [rbp-38h] BYREF
		  DynamicStreamingScene_LodRawInfo v16; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5371, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5371, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		        (ILFixDynamicMethodWrapper_9 *)Patch,
		        (Object *)this,
		        (Object *)boatAnchors,
		        boatSpeed,
		        0LL);
		      return;
		    }
		    goto LABEL_10;
		  }
		  if ( !this->fields.m_isPlayerOnBoat || this->fields.m_isBoatStop || boatSpeed < 0.01 )
		    return;
		  if ( !boatAnchors )
		LABEL_10:
		    sub_1800D8260(v7, v6);
		  size = boatAnchors->fields._size;
		  for ( i = 0; i < size; ++i )
		  {
		    time = UnityEngine::Time::get_time(0LL);
		    sub_1800036A0(TypeInfo::Beyond::RandomUtils);
		    v11 = Beyond::RandomUtils::Value(0LL) + (float)(time * 10.0);
		    Beyond::JobMathf::Fmod(v12, 1024.0, boatSpeed);
		    Beyond::DampingMath::sinf(v13, 1024.0);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		      &v16,
		      (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)boatAnchors,
		      i,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		      &v15,
		      (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)boatAnchors,
		      i,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		    boatSpeed = *(float *)&v15.gridId;
		    HG::Rendering::Runtime::HGWaterManager::AddWaterRippleData(
		      this,
		      (float)(v11 * 0.02) + 0.40000001,
		      (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v16.distance), (__m128)v15.gridId),
		      2,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		public void AddReadbackRequest(int cameraInstanceID, HGWaterReadbackFlag flags, Vector4 readbackRect) {} // 0x0000000189C63628-0x0000000189C6377C
		// Void AddReadbackRequest(Int32, HGWaterReadbackFlag, Vector4)
		void HG::Rendering::Runtime::HGWaterManager::AddReadbackRequest(
		        HGWaterManager *this,
		        int32_t cameraInstanceID,
		        HGWaterReadbackFlag__Enum flags,
		        Vector4 *readbackRect,
		        MethodInfo *method)
		{
		  float v5; // xmm1_4
		  System::MathF *v10; // rcx
		  float x; // xmm0_4
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *m_ReadbackRequests; // r14
		  float v13; // xmm8_4
		  float y; // xmm0_4
		  System::MathF *v15; // rcx
		  float v16; // xmm7_4
		  float z; // xmm0_4
		  System::MathF *v18; // rcx
		  float v19; // xmm6_4
		  float w; // xmm0_4
		  System::MathF *v21; // rcx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v25; // [rsp+38h] [rbp-61h] BYREF
		  __int128 v26; // [rsp+48h] [rbp-51h]
		  _OWORD v27[2]; // [rsp+58h] [rbp-41h]
		  _OWORD v28[2]; // [rsp+78h] [rbp-21h] BYREF
		  __int64 v29; // [rsp+98h] [rbp-1h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5372, 0LL) )
		  {
		    x = readbackRect->x;
		    m_ReadbackRequests = this->fields.m_ReadbackRequests;
		    *(_OWORD *)((char *)v27 + 8) = 0LL;
		    *(_QWORD *)&v26 = __PAIR64__(flags, cameraInstanceID);
		    System::MathF::Floor(v10, v5);
		    v13 = x;
		    y = readbackRect->y;
		    System::MathF::Floor(v15, v5);
		    v16 = y;
		    z = readbackRect->z;
		    System::MathF::Floor(v18, v5);
		    v19 = z;
		    w = readbackRect->w;
		    System::MathF::Floor(v21, v5);
		    *((_QWORD *)&v26 + 1) = __PAIR64__(LODWORD(v16), LODWORD(v13));
		    *(_QWORD *)&v27[0] = __PAIR64__(LODWORD(w), LODWORD(v19));
		    if ( m_ReadbackRequests )
		    {
		      v28[0] = v26;
		      v28[1] = v27[0];
		      v29 = *(_OWORD *)&_mm_unpackhi_pd((__m128d)0LL, (__m128d)0LL);
		      sub_180363D30(
		        m_ReadbackRequests,
		        v28,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterManager::WaterReadbackRequest>::Add);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v23, v22);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5372, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v25 = *readbackRect;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1553(Patch, (Object *)this, cameraInstanceID, flags, &v25, 0LL);
		}
		
		[IDTag(1)]
		public void AddReadbackRequest(int cameraInstanceID, Vector4[] worldPositions) {} // 0x00000001830A1040-0x00000001830A1280
		// Void AddReadbackRequest(Int32, Vector4[])
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGWaterManager::AddReadbackRequest(
		        HGWaterManager *this,
		        int32_t cameraInstanceID,
		        Vector4__Array *worldPositions,
		        MethodInfo *method)
		{
		  __int64 size; // rcx
		  unsigned int v7; // r14d
		  __int64 v8; // r8
		  struct MethodInfo *v9; // rbp
		  __int64 v10; // rdi
		  __int64 v11; // rcx
		  __int64 v12; // rbx
		  __int64 v13; // rax
		  unsigned int v14; // edi
		  __int64 (__fastcall *v15)(__int64, _QWORD, __int64, _QWORD); // rax
		  _OWORD *v16; // rdi
		  __int64 v17; // rcx
		  void (__fastcall *v18)(_OWORD *, _QWORD, __int64); // rax
		  int32_t v19; // eax
		  __int64 v20; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rax
		  __int64 v23; // rax
		  __m128d v24; // [rsp+30h] [rbp-88h]
		  __m256i v25; // [rsp+40h] [rbp-78h]
		  __m256i v26; // [rsp+70h] [rbp-48h] BYREF
		  __int64 v27; // [rsp+90h] [rbp-28h]
		
		  size = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = cameraInstanceID;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    size = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = **(_QWORD **)(size + 184);
		  if ( !v8 )
		    goto LABEL_20;
		  if ( *(int *)(v8 + 24) <= 5373 )
		    goto LABEL_5;
		  if ( !*(_DWORD *)(size + 224) )
		  {
		    il2cpp_runtime_class_init_1(size);
		    size = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  *(_QWORD *)&cameraInstanceID = **(_QWORD **)(size + 184);
		  if ( !*(_QWORD *)&cameraInstanceID )
		    goto LABEL_20;
		  if ( *(_DWORD *)(*(_QWORD *)&cameraInstanceID + 24LL) <= 0x14FDu )
		    goto LABEL_21;
		  if ( !*(_QWORD *)(*(_QWORD *)&cameraInstanceID + 43016LL) )
		  {
		LABEL_5:
		    v9 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray;
		    v10 = **(_QWORD **)(sub_18011C4C0(MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray->klass)
		                      + 192);
		    v11 = *(_QWORD *)(*(_QWORD *)(sub_18011C4C0(*(_QWORD *)(v10 + 32)) + 192) + 16LL);
		    if ( !*(_QWORD *)(v11 + 56) )
		      sub_1800430B0(v11);
		    v12 = 0LL;
		    v13 = sub_18011C4C0(*(_QWORD *)(v10 + 32));
		    v14 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::AlignOf<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::VATFSMAudioData>(*(MethodInfo **)(*(_QWORD *)(v13 + 192) + 40LL));
		    v15 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))qword_18F36EF08;
		    if ( !qword_18F36EF08 )
		    {
		      v15 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))il2cpp_resolve_icall_1(
		                                                                        "Unity.Collections.LowLevel.Unsafe.UnsafeUtility:"
		                                                                        ":MallocTracked(System.Int64,System.Int32,Unity.C"
		                                                                        "ollections.Allocator,System.Int32)");
		      if ( !v15 )
		      {
		        v22 = sub_1802EE1B8(
		                "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MallocTracked(System.Int64,System.Int32,Unity.Collectio"
		                "ns.Allocator,System.Int32)");
		        sub_18007E1B0(v22, 0LL);
		      }
		      qword_18F36EF08 = (__int64)v15;
		    }
		    v16 = (_OWORD *)v15(128LL, v14, 3LL, 0LL);
		    *(_QWORD *)&v24.m128d_f64[0] = v16;
		    *(_QWORD *)&v24.m128d_f64[1] = 0x300000008LL;
		    v17 = *(_QWORD *)(*(_QWORD *)(sub_18011C4C0(v9->klass) + 192) + 16LL);
		    if ( !*(_QWORD *)(v17 + 56) )
		      sub_1800430B0(v17);
		    v18 = (void (__fastcall *)(_OWORD *, _QWORD, __int64))qword_18F36EF38;
		    if ( !qword_18F36EF38 )
		    {
		      v18 = (void (__fastcall *)(_OWORD *, _QWORD, __int64))il2cpp_resolve_icall_1(
		                                                              "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(Sy"
		                                                              "stem.Void*,System.Byte,System.Int64)");
		      if ( !v18 )
		      {
		        v23 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)");
		        sub_18007E1B0(v23, 0LL);
		      }
		      qword_18F36EF38 = (__int64)v18;
		    }
		    v18(v16, 0LL, 128LL);
		    if ( worldPositions )
		    {
		      size = (unsigned int)worldPositions->max_length.size;
		      v19 = 0;
		      if ( (int)size >= 8 )
		      {
		        size = 8LL;
		LABEL_14:
		        *(_QWORD *)&cameraInstanceID = (unsigned int)size;
		        while ( (unsigned int)v19 < worldPositions->max_length.size )
		        {
		          ++v12;
		          v20 = v19++ + 2LL;
		          size = 2 * v20;
		          *v16++ = *(_OWORD *)(&worldPositions->klass + size);
		          if ( v12 >= *(__int64 *)&cameraInstanceID )
		            goto LABEL_17;
		        }
		LABEL_21:
		        sub_1800D2AB0(size, *(_QWORD *)&cameraInstanceID);
		      }
		      if ( (int)size > 0 )
		        goto LABEL_14;
		LABEL_17:
		      size = (__int64)this->fields.m_ReadbackRequests;
		      v25.m256i_i64[0] = v7 | 0x1000000000LL;
		      v25.m256i_i64[3] = *(_QWORD *)&v24.m128d_f64[0];
		      *(_OWORD *)&v25.m256i_u64[1] = 0LL;
		      if ( size )
		      {
		        v26 = v25;
		        v27 = *(_OWORD *)&_mm_unpackhi_pd(v24, v24);
		        sub_183E9C610(
		          size,
		          &v26,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterManager::WaterReadbackRequest>::Add);
		        return;
		      }
		    }
		LABEL_20:
		    sub_1800D8260(size, *(_QWORD *)&cameraInstanceID);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5373, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
		    (ILFixDynamicMethodWrapper_17 *)Patch,
		    (Object *)this,
		    (AkCallbackType__Enum)v7,
		    (Object *)worldPositions,
		    0LL);
		}
		
		internal unsafe HGWaterReadbackFlag MergeReadbackRequests(int cameraInstanceID, out Vector4* outParams, out int outCount) {
			outParams = default;
			outCount = default;
			return default;
		} // 0x00000001830A1280-0x00000001830A14A0
		// HGWaterReadbackFlag MergeReadbackRequests(Int32, Vector4* ByRef, Int32 ByRef)
		// local variable allocation has failed, the output may be wrong!
		HGWaterReadbackFlag__Enum HG::Rendering::Runtime::HGWaterManager::MergeReadbackRequests(
		        HGWaterManager *this,
		        int32_t cameraInstanceID,
		        Vector4 **outParams,
		        int32_t *outCount,
		        MethodInfo *method)
		{
		  unsigned __int64 v7; // rcx
		  int32_t v9; // ebp
		  __int64 v10; // r8
		  __int64 (__fastcall *v11)(__int64); // rax
		  HGWaterReadbackFlag__Enum v12; // ebx
		  __int64 v13; // r9
		  TileBase *v14; // rdx
		  __int64 v15; // r8
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v17; // rdx
		  __int64 v18; // r8
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *m_ReadbackRequests; // rax
		  HGWaterReadbackFlag__Enum result; // eax
		  HGWaterManager_WaterReadbackRequest__Array *items; // r8
		  __m128i v22; // xmm3
		  __int128 v23; // xmm4
		  __int128 v24; // xmm0
		  _OWORD *v25; // xmm3_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rax
		  int32_t *P3; // [rsp+20h] [rbp-88h]
		  TileAnimationData v29; // [rsp+30h] [rbp-78h] BYREF
		  __m256i v30; // [rsp+40h] [rbp-68h]
		  __m256i v31; // [rsp+70h] [rbp-38h]
		
		  v7 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = cameraInstanceID;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v10 = **(_QWORD **)(v7 + 184);
		  if ( !v10 )
		    goto LABEL_28;
		  if ( *(int *)(v10 + 24) <= 1056 )
		    goto LABEL_5;
		  if ( !*(_DWORD *)(v7 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  *(_QWORD *)&cameraInstanceID = **(_QWORD **)(v7 + 184);
		  if ( !*(_QWORD *)&cameraInstanceID )
		LABEL_28:
		    sub_1800D8260(v7, *(_QWORD *)&cameraInstanceID);
		  if ( *(_DWORD *)(*(_QWORD *)&cameraInstanceID + 24LL) <= 0x420u )
		LABEL_30:
		    sub_1800D2AB0(v7, *(_QWORD *)&cameraInstanceID);
		  if ( *(_QWORD *)(*(_QWORD *)&cameraInstanceID + 8480LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1056, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_406(Patch, (Object *)this, v9, outParams, outCount, 0LL);
		    goto LABEL_28;
		  }
		LABEL_5:
		  v11 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  v12 = HGWaterReadbackFlag__Enum_None;
		  if ( !qword_18F370618 )
		  {
		    v11 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v11 )
		    {
		      v27 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v27, 0LL);
		    }
		    qword_18F370618 = (__int64)v11;
		  }
		  v13 = v11(192LL);
		  v14 = (TileBase *)v13;
		  v15 = 12LL;
		  do
		  {
		    TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                               &v29,
		                               v14,
		                               (Vector3Int *)v15,
		                               (ITilemap *)v13,
		                               (MethodInfo *)P3);
		    v14 = (TileBase *)(v17 + 16);
		    *(TileAnimationData *)&v14[-1].monitor = *TileAnimationDataNoRef;
		    v15 = v18 - 1;
		  }
		  while ( v15 );
		  for ( *(_QWORD *)&cameraInstanceID = 0LL; ; *(_QWORD *)&cameraInstanceID = (unsigned int)(cameraInstanceID + 1) )
		  {
		    m_ReadbackRequests = this->fields.m_ReadbackRequests;
		    if ( !m_ReadbackRequests )
		      goto LABEL_28;
		    if ( cameraInstanceID >= m_ReadbackRequests->fields._size )
		      break;
		    if ( (unsigned int)cameraInstanceID >= m_ReadbackRequests->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = m_ReadbackRequests->fields._items;
		    if ( !items )
		      goto LABEL_28;
		    if ( (unsigned int)cameraInstanceID >= items->max_length.size )
		      goto LABEL_30;
		    v22 = *(__m128i *)&items->vector[cameraInstanceID].readbackRect.z;
		    v23 = *(_OWORD *)&items->vector[cameraInstanceID].cameraInstanceID;
		    *(__m128i *)&v31.m256i_u64[2] = v22;
		    *(_OWORD *)v31.m256i_i8 = v23;
		    *(__m128i *)&v30.m256i_u64[2] = v22;
		    if ( items->vector[cameraInstanceID].cameraInstanceID == v9 )
		    {
		      *(__m128i *)&v30.m256i_u64[2] = v22;
		      if ( (BYTE4(v23) & 1) != 0 )
		      {
		        *(_OWORD *)v30.m256i_i8 = v23;
		        *(__m128i *)&v30.m256i_u64[2] = v22;
		        *(_OWORD *)v13 = *(_OWORD *)&v30.m256i_u64[1];
		      }
		      v24 = *(_OWORD *)&v31.m256i_u64[1];
		      if ( (BYTE4(v23) & 2) != 0 )
		        *(_OWORD *)(v13 + 16) = *(_OWORD *)&v31.m256i_u64[1];
		      if ( (BYTE4(v23) & 4) != 0 )
		        *(_OWORD *)(v13 + 32) = v24;
		      if ( (BYTE4(v23) & 8) != 0 )
		        *(_OWORD *)(v13 + 48) = v24;
		      v25 = (_OWORD *)_mm_srli_si128(v22, 8).m128i_u64[0];
		      if ( v25 )
		      {
		        *(_OWORD *)(v13 + 64) = *v25;
		        *(_OWORD *)(v13 + 80) = v25[1];
		        *(_OWORD *)(v13 + 96) = v25[2];
		        *(_OWORD *)(v13 + 112) = v25[3];
		        *(_OWORD *)(v13 + 128) = v25[4];
		        *(_OWORD *)(v13 + 144) = v25[5];
		        *(_OWORD *)(v13 + 160) = v25[6];
		        *(_OWORD *)(v13 + 176) = v25[7];
		      }
		      v7 = DWORD1(v23);
		    }
		    else
		    {
		      v7 = 0LL;
		    }
		    v12 |= v7;
		  }
		  *outParams = (Vector4 *)v13;
		  result = v12;
		  *outCount = 12;
		  return result;
		}
		
		private static unsafe HGWaterReadbackFlag MergeReadbackRequest(WaterReadbackRequest req, int cameraInstanceID, Vector4* p) => default; // 0x00000001830A14A0-0x00000001830A1590
		// HGWaterReadbackFlag MergeReadbackRequest(HGWaterManager+WaterReadbackRequest, Int32, Vector4*)
		HGWaterReadbackFlag__Enum HG::Rendering::Runtime::HGWaterManager::MergeReadbackRequest(
		        HGWaterManager_WaterReadbackRequest *req,
		        int32_t cameraInstanceID,
		        Vector4 *p,
		        MethodInfo *method)
		{
		  __int128 v4; // xmm2
		  __int128 v5; // xmm0
		  Vector4 *m_Buffer; // rax
		  __int64 v7; // rax
		  _BYTE v9[24]; // [rsp+8h] [rbp-28h]
		  Vector4 v10; // [rsp+8h] [rbp-28h]
		  Vector4 v11; // [rsp+8h] [rbp-28h]
		  Vector4 v12; // [rsp+8h] [rbp-28h]
		
		  v4 = *(_OWORD *)&req->cameraInstanceID;
		  v5 = *(_OWORD *)&req->readbackRect.z;
		  if ( _mm_cvtsi128_si32(*(__m128i *)&req->cameraInstanceID) == cameraInstanceID )
		  {
		    if ( (BYTE4(v4) & 1) != 0 )
		    {
		      *(_QWORD *)v9 = *(_QWORD *)&req->readbackRect.x;
		      *(_OWORD *)&v9[8] = *(_OWORD *)&req->readbackRect.z;
		      *p = *(Vector4 *)v9;
		    }
		    if ( (BYTE4(v4) & 2) != 0 )
		    {
		      *(_QWORD *)&v10.x = *((_QWORD *)&v4 + 1);
		      *(_QWORD *)&v10.z = v5;
		      p[1] = v10;
		    }
		    if ( (BYTE4(v4) & 4) != 0 )
		    {
		      *(_QWORD *)&v11.x = *((_QWORD *)&v4 + 1);
		      *(_QWORD *)&v11.z = v5;
		      p[2] = v11;
		    }
		    if ( (BYTE4(v4) & 8) != 0 )
		    {
		      *(_QWORD *)&v12.x = *((_QWORD *)&v4 + 1);
		      *(_QWORD *)&v12.z = v5;
		      p[3] = v12;
		    }
		    if ( req->worldPositions.m_Buffer )
		    {
		      m_Buffer = (Vector4 *)req->worldPositions.m_Buffer;
		      p[4] = *m_Buffer;
		      p[5] = m_Buffer[1];
		      p[6] = m_Buffer[2];
		      p[7] = m_Buffer[3];
		      p[8] = m_Buffer[4];
		      p[9] = m_Buffer[5];
		      p[10] = m_Buffer[6];
		      p[11] = m_Buffer[7];
		    }
		    return HIDWORD(*(_QWORD *)&req->cameraInstanceID);
		  }
		  else
		  {
		    LODWORD(v7) = 0;
		  }
		  return (unsigned int)v7;
		}
		
		private void ClearReadbackRequests() {} // 0x0000000183336030-0x0000000183336170
		// Void ClearReadbackRequests()
		void HG::Rendering::Runtime::HGWaterManager::ClearReadbackRequests(HGWaterManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  int *wrapperArray; // rdx
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *m_ReadbackRequests; // rax
		  bool v7; // zf
		  List_1_HG_Rendering_Runtime_HGWaterManager_WaterReadbackRequest_ *v8; // rax
		  __int128 v9; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_Vector4_ v11; // [rsp+38h] [rbp-20h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_19;
		  if ( wrapperArray[6] <= 2289 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_19:
		    sub_1800D8260(v3, wrapperArray);
		  if ( (unsigned int)wrapperArray[6] <= 0x8F1 )
		LABEL_20:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( *((_QWORD *)wrapperArray + 2293) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2289, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_19;
		  }
		LABEL_5:
		  for ( i = 0; ; ++i )
		  {
		    m_ReadbackRequests = this->fields.m_ReadbackRequests;
		    if ( !m_ReadbackRequests )
		      goto LABEL_19;
		    if ( i >= m_ReadbackRequests->fields._size )
		      break;
		    if ( (unsigned int)i >= m_ReadbackRequests->fields._size )
		      goto LABEL_21;
		    wrapperArray = (int *)m_ReadbackRequests->fields._items;
		    if ( !wrapperArray )
		      goto LABEL_19;
		    if ( i >= (unsigned int)wrapperArray[6] )
		      goto LABEL_20;
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)(5LL * i);
		    v7 = *(_QWORD *)&wrapperArray[10 * i + 14] == 0LL;
		    *(_QWORD *)&v11.m_Length = *(_QWORD *)&wrapperArray[10 * i + 16];
		    if ( !v7 )
		    {
		      v8 = this->fields.m_ReadbackRequests;
		      if ( !v8 )
		        goto LABEL_19;
		      if ( (unsigned int)i >= v8->fields._size )
		LABEL_21:
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      wrapperArray = (int *)v8->fields._items;
		      if ( !wrapperArray )
		        goto LABEL_19;
		      if ( i >= (unsigned int)wrapperArray[6] )
		        goto LABEL_20;
		      v9 = *(_OWORD *)&wrapperArray[10 * i + 12];
		      *(_QWORD *)&v11.m_Length = *(_QWORD *)&wrapperArray[10 * i + 16];
		      v11.m_Buffer = (Void *)*((_QWORD *)&v9 + 1);
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &v11,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    }
		  }
		  ++m_ReadbackRequests->fields._version;
		  m_ReadbackRequests->fields._size = 0;
		}
		
		internal unsafe HGWaterReadbackOutput* AllocateReadbackOutput() => default; // 0x00000001837E36E0-0x00000001837E3810
		// HGWaterReadbackOutput* AllocateReadbackOutput()
		HGWaterReadbackOutput *HG::Rendering::Runtime::HGWaterManager::AllocateReadbackOutput(
		        HGWaterManager *this,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
		  __int64 v4; // rax
		  HGWaterReadbackOutput *v5; // rbx
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v7; // xmm1
		  __int128 v8; // xmm2
		  __int128 v9; // xmm3
		  Matrix4x4__StaticFields *v10; // rcx
		  __int128 v11; // xmm1
		  __int128 v12; // xmm2
		  __int128 v13; // xmm3
		  __int64 v15; // rax
		
		  v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
		                                                          "pFromCSharp(System.Int64)");
		    if ( !v2 )
		    {
		      v15 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v15, 0LL);
		    }
		    qword_18F370618 = (__int64)v2;
		  }
		  v4 = v2(168LL, method);
		  v5 = (HGWaterReadbackOutput *)v4;
		  static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v7 = *(_OWORD *)&static_fields->identityMatrix.m01;
		  v8 = *(_OWORD *)&static_fields->identityMatrix.m02;
		  v9 = *(_OWORD *)&static_fields->identityMatrix.m03;
		  if ( !v4 )
		    sub_1800D8260(TypeInfo::UnityEngine::Matrix4x4, static_fields);
		  *(_OWORD *)(v4 + 40) = *(_OWORD *)&static_fields->identityMatrix.m00;
		  *(_OWORD *)(v4 + 56) = v7;
		  *(_OWORD *)(v4 + 72) = v8;
		  *(_OWORD *)(v4 + 88) = v9;
		  v10 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v11 = *(_OWORD *)&v10->identityMatrix.m01;
		  v12 = *(_OWORD *)&v10->identityMatrix.m02;
		  v13 = *(_OWORD *)&v10->identityMatrix.m03;
		  *(_OWORD *)(v4 + 104) = *(_OWORD *)&v10->identityMatrix.m00;
		  *(_OWORD *)(v4 + 120) = v11;
		  *(_OWORD *)(v4 + 136) = v12;
		  *(_OWORD *)(v4 + 152) = v13;
		  *(_QWORD *)v4 = HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(this, 768, 4, 0LL);
		  v5->heightNormal = HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(this, 768, 4, 0LL);
		  v5->heightDepth = HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(this, 768, 4, 0LL);
		  v5->decalDisplacement = HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(this, 768, 4, 0LL);
		  v5->heightBuffer = HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(this, 768, 4, 0LL);
		  return v5;
		}
		
		private unsafe HGWaterReadbackData* AllocateReadbackDataArray(int dataArraySize, int layerCount) => default; // 0x00000001837E3810-0x00000001837E3910
		// HGWaterReadbackData* AllocateReadbackDataArray(Int32, Int32)
		// local variable allocation has failed, the output may be wrong!
		HGWaterReadbackData *HG::Rendering::Runtime::HGWaterManager::AllocateReadbackDataArray(
		        HGWaterManager *this,
		        int32_t dataArraySize,
		        int32_t layerCount,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v4)(__int64, _QWORD, _QWORD, MethodInfo *); // rax
		  __int64 v6; // rdi
		  __int64 v7; // rax
		  __int64 v8; // r10
		  Vector3Int *v9; // r8
		  ITilemap *v10; // r9
		  __int64 v11; // rdx
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v13; // rdx
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  __int128 v17; // xmm3
		  int v18; // r9d
		  Matrix4x4__StaticFields *v19; // rcx
		  __int128 v20; // xmm1
		  __int128 v21; // xmm2
		  __int128 v22; // xmm3
		  __int64 v24; // rax
		  TileAnimationData v25; // [rsp+20h] [rbp-18h] BYREF
		
		  v4 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, MethodInfo *))qword_18F370618;
		  v6 = dataArraySize;
		  if ( !qword_18F370618 )
		  {
		    v4 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                          "UnityEngine.HyperGryphEngineCode.HGRenderGraph"
		                                                                          "CPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v4 )
		    {
		      v24 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v24, 0LL);
		    }
		    qword_18F370618 = (__int64)v4;
		  }
		  v7 = v4(v6, *(_QWORD *)&dataArraySize, *(_QWORD *)&layerCount, method);
		  v8 = 0LL;
		  v9 = (Vector3Int *)v7;
		  v10 = 0LL;
		  if ( layerCount > 0 )
		  {
		    v11 = v7 + 16;
		    do
		    {
		      if ( !&v9[16 * (int)v10] )
		        sub_1800D8260((int)v10, v11);
		      *(_BYTE *)(v11 - 16) = v8;
		      *(_QWORD *)(v11 - 8) = v8;
		      *(_QWORD *)v11 = v8;
		      *(_QWORD *)(v11 + 8) = v8;
		      *(_QWORD *)(v11 + 16) = v8;
		      *(_DWORD *)(v11 + 24) = v8;
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 &v25,
		                                 (TileBase *)v11,
		                                 v9,
		                                 v10,
		                                 (MethodInfo *)v25.m_AnimatedSprites);
		      *(TileAnimationData *)(v13 + 28) = *TileAnimationDataNoRef;
		      static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v15 = *(_OWORD *)&static_fields->identityMatrix.m01;
		      v16 = *(_OWORD *)&static_fields->identityMatrix.m02;
		      v17 = *(_OWORD *)&static_fields->identityMatrix.m03;
		      *(_OWORD *)(v13 + 44) = *(_OWORD *)&static_fields->identityMatrix.m00;
		      *(_OWORD *)(v13 + 60) = v15;
		      *(_OWORD *)(v13 + 76) = v16;
		      *(_OWORD *)(v13 + 92) = v17;
		      v10 = (ITilemap *)(unsigned int)(v18 + 1);
		      v19 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v20 = *(_OWORD *)&v19->identityMatrix.m01;
		      v21 = *(_OWORD *)&v19->identityMatrix.m02;
		      v22 = *(_OWORD *)&v19->identityMatrix.m03;
		      *(_OWORD *)(v13 + 108) = *(_OWORD *)&v19->identityMatrix.m00;
		      *(_OWORD *)(v13 + 124) = v20;
		      *(_OWORD *)(v13 + 140) = v21;
		      *(_OWORD *)(v13 + 156) = v22;
		      v11 = v13 + 192;
		    }
		    while ( (int)v10 < layerCount );
		  }
		  return (HGWaterReadbackData *)v9;
		}
		
		private void MarkReadbackResultsStale() {} // 0x00000001831C6C30-0x00000001831C7020
		// Void MarkReadbackResultsStale()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGWaterManager::MarkReadbackResultsStale(HGWaterManager *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Object *v4; // rbx
		  HGWaterManager *v5; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object__Class *klass; // rdi
		  MonitorData *monitor; // rdi
		  __int64 v14; // rdx
		  List_1_System_Int32_ *m_StaleReadbackKeys; // rcx
		  Object__Class *v16; // rcx
		  int32_t v17; // edi
		  __int64 v18; // rdx
		  Object__Class *v19; // rax
		  int32_t Item; // eax
		  int32_t v21; // esi
		  MonitorData *v22; // r9
		  __int64 *v23; // rdx
		  __int64 v24; // rtt
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  MethodInfo *v27; // [rsp+20h] [rbp-98h]
		  Il2CppException *ex; // [rsp+20h] [rbp-98h]
		  Il2CppException *v29; // [rsp+20h] [rbp-98h]
		  _BYTE v30[40]; // [rsp+30h] [rbp-88h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v31; // [rsp+58h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v32; // [rsp+80h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v33; // [rsp+88h] [rbp-30h] BYREF
		  Object *value; // [rsp+D0h] [rbp+18h] BYREF
		  HGWaterManager *v36; // [rsp+D8h] [rbp+20h]
		
		  v4 = (Object *)this;
		  v5 = this;
		  v36 = this;
		  value = 0LL;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v6, method);
		  if ( wrapperArray->max_length.size <= 2301 )
		    goto LABEL_13;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = v6->static_fields->wrapperArray;
		  if ( !v8 )
		    sub_1800D8260(v6, method);
		  if ( v8->max_length.size <= 0x8FDu )
		    sub_1800D2AB0(v6, method);
		  if ( v8[64].monitor )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2301, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, v4, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    klass = v4[14].klass;
		    if ( !klass )
		      sub_1800D8260(v6, method);
		    ++HIDWORD(klass->_0.namespaze);
		    LODWORD(klass->_0.namespaze) = 0;
		    monitor = v4[13].monitor;
		    if ( !monitor )
		      sub_1800D8260(v6, method);
		    memset(&v30[8], 0, 32);
		    *(_QWORD *)v30 = monitor;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)v30, (HGRuntimeGrassQuery_Node *)method, v2, v3, v27);
		    *(_QWORD *)&v30[8] = *((unsigned int *)monitor + 11);
		    *(_DWORD *)&v30[32] = 2;
		    *(_OWORD *)&v30[16] = 0LL;
		    *(_OWORD *)&v31._dictionary = *(_OWORD *)v30;
		    v31._current = 0LL;
		    *(_QWORD *)&v31._getEnumeratorRetType = *(_QWORD *)&v30[32];
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v31,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::MoveNext) )
		      {
		        if ( !v31._current.value )
		          sub_1800D8250(m_StaleReadbackKeys, v14);
		        if ( !LOBYTE(v31._current.value[11].monitor) )
		        {
		          v16 = v4[14].klass;
		          if ( !v16 )
		            sub_1800D8250(0LL, v14);
		          sub_183081250(v16, (unsigned int)v31._current.key, MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v32 )
		    {
		      ex = v32->ex;
		      m_StaleReadbackKeys = (List_1_System_Int32_ *)v32->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = (Object *)this;
		      v5 = v36;
		    }
		    v17 = 0;
		    v18 = 0LL;
		    v19 = v4[14].klass;
		    if ( !v19 )
		      goto LABEL_53;
		    while ( 1 )
		    {
		      m_StaleReadbackKeys = v5->fields.m_StaleReadbackKeys;
		      if ( (int)v18 >= SLODWORD(v19->_0.namespaze) )
		        break;
		      if ( !m_StaleReadbackKeys )
		        goto LABEL_53;
		      Item = System::Collections::Generic::List<int>::get_Item(
		               m_StaleReadbackKeys,
		               v17,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      v21 = Item;
		      m_StaleReadbackKeys = (List_1_System_Int32_ *)v4[13].monitor;
		      if ( !m_StaleReadbackKeys )
		        goto LABEL_53;
		      if ( System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		             (Dictionary_2_System_Int32_System_Object_ *)m_StaleReadbackKeys,
		             Item,
		             &value,
		             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue) )
		      {
		        m_StaleReadbackKeys = (List_1_System_Int32_ *)value;
		        if ( !value )
		          goto LABEL_53;
		        HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged::Dispose(
		          (HGWaterManager_HGWaterReadbackOutputManaged *)value,
		          0LL);
		        m_StaleReadbackKeys = (List_1_System_Int32_ *)v4[13].monitor;
		        if ( !m_StaleReadbackKeys )
		          goto LABEL_53;
		        System::Collections::Generic::Dictionary<int,System::Object>::Remove(
		          (Dictionary_2_System_Int32_System_Object_ *)m_StaleReadbackKeys,
		          v21,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::Remove);
		      }
		      v18 = (unsigned int)++v17;
		      v19 = v4[14].klass;
		      if ( !v19 )
		        goto LABEL_53;
		    }
		    if ( !m_StaleReadbackKeys
		      || (++m_StaleReadbackKeys->fields._version, m_StaleReadbackKeys->fields._size = 0, (v22 = v4[13].monitor) == 0LL) )
		    {
		LABEL_53:
		      sub_1800D8250(m_StaleReadbackKeys, v18);
		    }
		    memset(&v30[8], 0, 32);
		    *(_QWORD *)v30 = v22;
		    if ( dword_18F35FD08 )
		    {
		      v23 = &qword_18F103690[(((unsigned __int64)v30 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v23);
		      do
		        v24 = *v23;
		      while ( v24 != _InterlockedCompareExchange64(v23, *v23 | (1LL << (((unsigned __int64)v30 >> 12) & 0x3F)), *v23) );
		    }
		    *(_QWORD *)&v30[8] = *((unsigned int *)v22 + 11);
		    *(_DWORD *)&v30[32] = 2;
		    *(_OWORD *)&v31._dictionary = *(_OWORD *)v30;
		    v31._current = 0LL;
		    *(_QWORD *)&v31._getEnumeratorRetType = *(_QWORD *)&v30[32];
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v31,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::MoveNext) )
		      {
		        if ( !v31._current.value )
		          sub_1800D8250(v26, v25);
		        LOBYTE(v31._current.value[11].monitor) = 0;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v33 )
		    {
		      v29 = v33->ex;
		      if ( v29 )
		        sub_18007E1E0(v29);
		    }
		  }
		}
		
		private void DisposeReadbackResults() {} // 0x0000000189C6384C-0x0000000189C639B8
		// Void DisposeReadbackResults()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGWaterManager::DisposeReadbackResults(HGWaterManager *this, MethodInfo *method)
		{
		  HGWaterManager *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 *v5; // rdx
		  Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *m_ReadbackResults; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // [rsp+0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v11; // [rsp+20h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-70h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v13; // [rsp+30h] [rbp-68h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v14; // [rsp+38h] [rbp-60h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v15; // [rsp+60h] [rbp-38h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(2265, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2265, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.m_ReadbackResults )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v15,
		      (Dictionary_2_System_UInt64_System_Object_ *)v2->fields.m_ReadbackResults,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::GetEnumerator);
		    v14 = v15;
		    ex = 0LL;
		    v13 = &v14;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v14,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::MoveNext) )
		      {
		        if ( !v14._current.value )
		          sub_1800D8250(0LL, v5);
		        HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged::Dispose(
		          (HGWaterManager_HGWaterReadbackOutputManaged *)v14._current.value,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v11 )
		    {
		      v5 = &v10;
		      ex = v11->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		    }
		    m_ReadbackResults = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.m_ReadbackResults;
		    if ( !m_ReadbackResults
		      || (System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		            m_ReadbackResults,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::Clear),
		          (m_ReadbackResults = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.m_StaleReadbackKeys) == 0LL) )
		    {
		      sub_1800D8250(m_ReadbackResults, v5);
		    }
		    ++HIDWORD(m_ReadbackResults->fields._entries);
		    LODWORD(m_ReadbackResults->fields._entries) = 0;
		  }
		}
		
		private static unsafe void CopyDataArray(HGWaterReadbackData* src, int count, HGWaterReadbackData[] dst, NativeArray<byte>[] tempArrays, int tempOffset) {} // 0x00000001830A1930-0x00000001830A1C90
		// Void CopyDataArray(HGWaterReadbackData*, Int32, HGWaterReadbackData[], NativeArray`1[System.Byte][], Int32)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		        HGWaterReadbackData *src,
		        int32_t count,
		        HGWaterReadbackData__Array *dst,
		        NativeArray_1_System_Byte___Array *tempArrays,
		        int32_t tempOffset,
		        MethodInfo *method)
		{
		  int32_t v8; // r12d
		  HGWaterReadbackData *v9; // r15
		  int32_t v10; // ebx
		  void **p_tempData; // rsi
		  int v12; // r13d
		  __int64 v13; // rcx
		  __int64 v14; // rax
		  __int64 (__fastcall *v15)(_QWORD, _QWORD, __int64, _QWORD, _QWORD); // rax
		  void (__fastcall *v16)(Void *, void *, _QWORD); // rax
		  NativeArray_1_System_Byte_ v17; // [rsp+20h] [rbp-38h]
		  __int64 v18; // [rsp+60h] [rbp+8h]
		  unsigned int v19; // [rsp+60h] [rbp+8h]
		  void *v20; // [rsp+60h] [rbp+8h]
		
		  if ( src )
		  {
		    v8 = count;
		    v9 = src;
		    v10 = 0;
		    if ( count > 0 )
		    {
		      p_tempData = &src->tempData;
		      do
		      {
		        if ( !dst )
		          goto LABEL_30;
		        if ( (unsigned int)v10 >= dst->max_length.size )
		          goto LABEL_31;
		        *(_QWORD *)&count = (char *)dst + 192 * v10;
		        *(_OWORD *)(*(_QWORD *)&count + 32LL) = *(_OWORD *)(p_tempData - 1);
		        *(_OWORD *)(*(_QWORD *)&count + 48LL) = *(_OWORD *)(p_tempData + 1);
		        *(_OWORD *)(*(_QWORD *)&count + 64LL) = *(_OWORD *)(p_tempData + 3);
		        *(_OWORD *)(*(_QWORD *)&count + 80LL) = *(_OWORD *)(p_tempData + 5);
		        *(_OWORD *)(*(_QWORD *)&count + 96LL) = *(_OWORD *)(p_tempData + 7);
		        *(_OWORD *)(*(_QWORD *)&count + 112LL) = *(_OWORD *)(p_tempData + 9);
		        *(_OWORD *)(*(_QWORD *)&count + 128LL) = *(_OWORD *)(p_tempData + 11);
		        *(_OWORD *)(*(_QWORD *)&count + 144LL) = *(_OWORD *)(p_tempData + 13);
		        *(_OWORD *)(*(_QWORD *)&count + 160LL) = *(_OWORD *)(p_tempData + 15);
		        *(_OWORD *)(*(_QWORD *)&count + 176LL) = *(_OWORD *)(p_tempData + 17);
		        *(_OWORD *)(*(_QWORD *)&count + 192LL) = *(_OWORD *)(p_tempData + 19);
		        *(_OWORD *)(*(_QWORD *)&count + 208LL) = *(_OWORD *)(p_tempData + 21);
		        if ( !tempArrays )
		LABEL_30:
		          sub_1800D8260(src, *(_QWORD *)&count);
		        if ( (unsigned int)(v10 + tempOffset) >= tempArrays->max_length.size )
		          goto LABEL_31;
		        if ( tempArrays->vector[v10 + tempOffset].m_Buffer )
		        {
		          Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		            (NativeArray_1_UnityEngine_Vector4_ *)&tempArrays->vector[v10 + tempOffset],
		            MethodInfo::Unity::Collections::NativeArray<unsigned char>::Dispose);
		          if ( (unsigned int)(v10 + tempOffset) >= tempArrays->max_length.size )
		            goto LABEL_31;
		          tempArrays->vector[v10 + tempOffset] = 0LL;
		        }
		        src = &v9[v10];
		        if ( !src )
		          goto LABEL_30;
		        if ( *((_BYTE *)p_tempData - 8)
		          && (v12 = *((_DWORD *)p_tempData + 4) * *((_DWORD *)p_tempData + 6), v12 > 0)
		          && *p_tempData )
		        {
		          v18 = **(_QWORD **)(sub_18011C4C0(MethodInfo::Unity::Collections::NativeArray<unsigned char>::NativeArray->klass)
		                            + 192);
		          v13 = *(_QWORD *)(*(_QWORD *)(sub_18011C4C0(*(_QWORD *)(v18 + 32)) + 192) + 16LL);
		          if ( !*(_QWORD *)(v13 + 56) )
		            sub_1800430B0(v13);
		          v14 = sub_18011C4C0(*(_QWORD *)(v18 + 32));
		          v19 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::AlignOf<BeyondDynamicBone::VertexAttribute>(*(MethodInfo **)(*(_QWORD *)(v14 + 192) + 40LL));
		          v15 = (__int64 (__fastcall *)(_QWORD, _QWORD, __int64, _QWORD, _QWORD))qword_18F36EF08;
		          if ( !qword_18F36EF08 )
		          {
		            v15 = (__int64 (__fastcall *)(_QWORD, _QWORD, __int64, _QWORD, _QWORD))sub_180059EA0(
		                                                                                     "Unity.Collections.LowLevel.Unsafe.U"
		                                                                                     "nsafeUtility::MallocTracked(System."
		                                                                                     "Int64,System.Int32,Unity.Collection"
		                                                                                     "s.Allocator,System.Int32)");
		            qword_18F36EF08 = (__int64)v15;
		          }
		          v17.m_Buffer = (Void *)v15(v12, v19, 3LL, 0LL, 0LL);
		          src = (HGWaterReadbackData *)(unsigned int)(v10 + tempOffset);
		          if ( (unsigned int)src >= tempArrays->max_length.size )
		            goto LABEL_31;
		          src = (HGWaterReadbackData *)(unsigned int)(v10 + tempOffset);
		          *(_QWORD *)&count = 2 * ((int)src + 2LL);
		          *(_QWORD *)&v17.m_Length = (unsigned int)v12 | 0x300000000LL;
		          tempArrays->vector[(int)src] = v17;
		          if ( (unsigned int)(v10 + tempOffset) >= tempArrays->max_length.size )
		            goto LABEL_31;
		          v20 = *p_tempData;
		          v16 = (void (__fastcall *)(Void *, void *, _QWORD))qword_18F36EF28;
		          if ( !qword_18F36EF28 )
		          {
		            v16 = (void (__fastcall *)(Void *, void *, _QWORD))sub_180059EA0(
		                                                                 "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy"
		                                                                 "(System.Void*,System.Void*,System.Int64)");
		            qword_18F36EF28 = (__int64)v16;
		          }
		          v16(v17.m_Buffer, v20, v12);
		          if ( (unsigned int)(v10 + tempOffset) >= tempArrays->max_length.size
		            || (src = (HGWaterReadbackData *)(2 * (v10 + tempOffset + 2LL)), (unsigned int)v10 >= dst->max_length.size) )
		          {
		LABEL_31:
		            sub_1800D2AB0(src, *(_QWORD *)&count);
		          }
		          src = (HGWaterReadbackData *)(192LL * v10);
		          *(void **)((char *)&dst->vector[0].tempData + (_QWORD)src) = tempArrays->vector[v10 + tempOffset].m_Buffer;
		        }
		        else
		        {
		          if ( (unsigned int)v10 >= dst->max_length.size )
		            goto LABEL_31;
		          src = (HGWaterReadbackData *)(192LL * v10);
		          *(void **)((char *)&dst->vector[0].tempData + (_QWORD)src) = 0LL;
		        }
		        ++v10;
		        p_tempData += 24;
		      }
		      while ( v10 < v8 );
		    }
		  }
		}
		
		internal unsafe void ArrangeReadback(HGWaterReadbackOutput* readbackOutput, HGCamera hgCamera) {} // 0x00000001830A1670-0x00000001830A1930
		// Void ArrangeReadback(HGWaterReadbackOutput*, HGCamera)
		void HG::Rendering::Runtime::HGWaterManager::ArrangeReadback(
		        HGWaterManager *this,
		        HGWaterReadbackOutput *readbackOutput,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGWaterManager *v5; // rbp
		  int32_t InstanceID; // eax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWaterManager_HGWaterReadbackOutputManaged_ *m_ReadbackResults; // rdi
		  int32_t v8; // r14d
		  struct MethodInfo *v9; // rsi
		  int32_t Entry; // eax
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Void *v13; // rax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm2
		  __int128 v16; // xmm3
		  Void *v17; // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm2
		  __int128 v20; // xmm3
		  HGWaterManager_HGWaterReadbackOutputManaged *v21; // rax
		  Object *v22; // rdi
		  MethodInfo *tempOffset; // [rsp+20h] [rbp-28h]
		  Void *v24; // [rsp+58h] [rbp+10h] BYREF
		
		  if ( readbackOutput )
		  {
		    v5 = this;
		    if ( hgCamera )
		    {
		      this = (HGWaterManager *)hgCamera->fields.camera;
		      if ( this )
		      {
		        InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		        m_ReadbackResults = v5->fields.m_ReadbackResults;
		        v8 = InstanceID;
		        if ( m_ReadbackResults )
		        {
		          v9 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue;
		          if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		                + 4) )
		            (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		          Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
		                    (Dictionary_2_System_Int32_System_Object_ *)m_ReadbackResults,
		                    v8,
		                    (MethodInfo *)v9->klass->rgctx_data[22].rgctxDataDummy);
		          if ( Entry < 0 )
		          {
		            v21 = (HGWaterManager_HGWaterReadbackOutputManaged *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged);
		            v22 = (Object *)v21;
		            if ( !v21 )
		              goto LABEL_21;
		            HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged::HGWaterReadbackOutputManaged(v21, 0LL);
		            this = (HGWaterManager *)v5->fields.m_ReadbackResults;
		            v24 = (Void *)v22;
		            if ( !this )
		              goto LABEL_21;
		            System::Collections::Generic::Dictionary<int,System::Object>::set_Item(
		              (Dictionary_2_System_Int32_System_Object_ *)this,
		              v8,
		              v22,
		              MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::set_Item);
		          }
		          else
		          {
		            this = (HGWaterManager *)m_ReadbackResults->fields._entries;
		            if ( !this )
		              goto LABEL_21;
		            if ( (unsigned int)Entry >= LODWORD(this->fields.m_globalConfigs) )
		              sub_1800D2AB0(this, readbackOutput);
		            v24 = (&this->fields.waterRippleData.m_Buffer)[3 * Entry];
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&v24,
		              (HGRuntimeGrassQuery_Node *)readbackOutput,
		              v11,
		              v12,
		              tempOffset);
		          }
		          if ( v24 )
		          {
		            v24[184] = (Void)1;
		            if ( v24 )
		            {
		              HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		                readbackOutput->heightData,
		                4,
		                *(HGWaterReadbackData__Array **)&v24[16],
		                *(NativeArray_1_System_Byte___Array **)&v24[192],
		                0,
		                0LL);
		              if ( v24 )
		              {
		                HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		                  readbackOutput->heightNormal,
		                  4,
		                  *(HGWaterReadbackData__Array **)&v24[24],
		                  *(NativeArray_1_System_Byte___Array **)&v24[192],
		                  4,
		                  0LL);
		                if ( v24 )
		                {
		                  HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		                    readbackOutput->heightDepth,
		                    4,
		                    *(HGWaterReadbackData__Array **)&v24[32],
		                    *(NativeArray_1_System_Byte___Array **)&v24[192],
		                    8,
		                    0LL);
		                  if ( v24 )
		                  {
		                    HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		                      readbackOutput->decalDisplacement,
		                      4,
		                      *(HGWaterReadbackData__Array **)&v24[40],
		                      *(NativeArray_1_System_Byte___Array **)&v24[192],
		                      12,
		                      0LL);
		                    if ( v24 )
		                    {
		                      HG::Rendering::Runtime::HGWaterManager::CopyDataArray(
		                        readbackOutput->heightBuffer,
		                        4,
		                        *(HGWaterReadbackData__Array **)&v24[48],
		                        *(NativeArray_1_System_Byte___Array **)&v24[192],
		                        16,
		                        0LL);
		                      v13 = v24;
		                      v14 = *(_OWORD *)&readbackOutput->orthoDeviceViewProj.m01;
		                      v15 = *(_OWORD *)&readbackOutput->orthoDeviceViewProj.m02;
		                      v16 = *(_OWORD *)&readbackOutput->orthoDeviceViewProj.m03;
		                      if ( v24 )
		                      {
		                        *(_OWORD *)&v24[56] = *(_OWORD *)&readbackOutput->orthoDeviceViewProj.m00;
		                        *(_OWORD *)&v13[72] = v14;
		                        *(_OWORD *)&v13[88] = v15;
		                        *(_OWORD *)&v13[104] = v16;
		                        v17 = v24;
		                        v18 = *(_OWORD *)&readbackOutput->orthoDeviceInvViewProj.m01;
		                        v19 = *(_OWORD *)&readbackOutput->orthoDeviceInvViewProj.m02;
		                        v20 = *(_OWORD *)&readbackOutput->orthoDeviceInvViewProj.m03;
		                        if ( v24 )
		                        {
		                          *(_OWORD *)&v24[120] = *(_OWORD *)&readbackOutput->orthoDeviceInvViewProj.m00;
		                          *(_OWORD *)&v17[136] = v18;
		                          *(_OWORD *)&v17[152] = v19;
		                          *(_OWORD *)&v17[168] = v20;
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
		LABEL_21:
		    sub_1800D8260(this, readbackOutput);
		  }
		}
		
		public bool GetWaterReadbackDisplacement(int cameraInstanceID, Vector3 worldPosition, int heightLayer, out float displacement) {
			displacement = default;
			return default;
		} // 0x0000000189C639B8-0x0000000189C63C90
		// Boolean GetWaterReadbackDisplacement(Int32, Vector3, Int32, Single ByRef)
		bool HG::Rendering::Runtime::HGWaterManager::GetWaterReadbackDisplacement(
		        HGWaterManager *this,
		        int32_t cameraInstanceID,
		        Vector3 *worldPosition,
		        int32_t heightLayer,
		        float *displacement,
		        MethodInfo *method)
		{
		  __int64 v8; // rbx
		  __int64 v10; // rdx
		  Dictionary_2_System_Int32_System_Object_ *m_ReadbackResults; // rcx
		  __int64 v12; // rsi
		  unsigned __int64 v13; // rbx
		  float y; // xmm1_4
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __m128 v18; // xmm2
		  float v19; // xmm3_4
		  float v20; // xmm1_4
		  float v21; // xmm3_4
		  int v22; // ecx
		  int v23; // r8d
		  int v24; // r9d
		  unsigned __int64 v25; // rax
		  int v26; // edx
		  int v27; // ecx
		  int v28; // edx
		  bool result; // al
		  __int64 v30; // xmm0_8
		  Vector4 v31; // [rsp+40h] [rbp-C0h] BYREF
		  Object *value; // [rsp+50h] [rbp-B0h] BYREF
		  Matrix4x4 v33; // [rsp+60h] [rbp-A0h] BYREF
		  Vector4 v34; // [rsp+A0h] [rbp-60h] BYREF
		  _BYTE v35[8]; // [rsp+B0h] [rbp-50h] BYREF
		  __int64 v36; // [rsp+B8h] [rbp-48h]
		  unsigned __int64 v37; // [rsp+C0h] [rbp-40h]
		  float v38; // [rsp+DCh] [rbp-24h]
		  float v39; // [rsp+E0h] [rbp-20h]
		  float v40; // [rsp+E4h] [rbp-1Ch]
		  float v41; // [rsp+E8h] [rbp-18h]
		
		  value = 0LL;
		  v8 = heightLayer;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5374, 0LL) )
		  {
		    *displacement = 0.0;
		    if ( (unsigned int)v8 > 3 )
		      return 0;
		    m_ReadbackResults = (Dictionary_2_System_Int32_System_Object_ *)this->fields.m_ReadbackResults;
		    if ( !m_ReadbackResults )
		      goto LABEL_28;
		    if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		            m_ReadbackResults,
		            cameraInstanceID,
		            &value,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue) )
		      return 0;
		    if ( !value )
		      goto LABEL_28;
		    if ( !LOBYTE(value[11].monitor) )
		      return 0;
		    m_ReadbackResults = (Dictionary_2_System_Int32_System_Object_ *)value[2].monitor;
		    if ( !m_ReadbackResults )
		      goto LABEL_28;
		    sub_18003FE40(m_ReadbackResults, v35, v8);
		    if ( !v35[0] )
		      return 0;
		    v12 = v36;
		    if ( !v36 )
		      return 0;
		    v13 = v37;
		    if ( (int)v37 <= 0 || SHIDWORD(v37) <= 0 )
		      return 0;
		    y = worldPosition->y;
		    v31.x = worldPosition->x;
		    v31.z = worldPosition->z;
		    v31.y = y;
		    v31.w = 1.0;
		    if ( value )
		    {
		      v15 = *(_OWORD *)&value[4].monitor;
		      *(Object *)&v33.m00 = *(Object *)((char *)value + 56);
		      v16 = *(_OWORD *)&value[5].monitor;
		      *(_OWORD *)&v33.m01 = v15;
		      v17 = *(_OWORD *)&value[6].monitor;
		      *(_OWORD *)&v33.m02 = v16;
		      *(_OWORD *)&v33.m03 = v17;
		      v18 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(&v34, &v33, &v31, 0LL));
		      v19 = _mm_shuffle_ps(v18, v18, 255).m128_f32[0];
		      if ( fabs(v19) >= 0.000001 )
		      {
		        v20 = (float)((float)(v18.m128_f32[0] / v19) * 0.5) + 0.5;
		        v21 = 1.0 - (float)((float)((float)(_mm_shuffle_ps(v18, v18, 85).m128_f32[0] / v19) * 0.5) + 0.5);
		        if ( v20 >= 0.0 && v20 <= 1.0 && v21 >= 0.0 && v21 <= 1.0 )
		        {
		          v22 = (int)v40;
		          v23 = (int)v38;
		          v24 = (int)v39;
		          LODWORD(v25) = (int)v41;
		          if ( (int)v40 <= 0 || (int)v25 <= 0 )
		          {
		            v23 = 0;
		            v25 = HIDWORD(v13);
		            v22 = v13;
		            v24 = 0;
		          }
		          v26 = (int)(float)((float)v22 * v20);
		          v27 = (int)(float)((float)(int)v25 * v21) - v24;
		          v28 = v26 - v23;
		          if ( v28 >= 0 && v28 < (int)v13 && v27 >= 0 && v27 < SHIDWORD(v13) )
		          {
		            result = 1;
		            *displacement = *(float *)(v12 + 16LL * (v28 + v27 * (int)v13));
		            return result;
		          }
		        }
		      }
		      return 0;
		    }
		LABEL_28:
		    sub_1800D8260(m_ReadbackResults, v10);
		  }
		  m_ReadbackResults = (Dictionary_2_System_Int32_System_Object_ *)IFix::WrappersManagerImpl::GetPatch(5374, 0LL);
		  if ( !m_ReadbackResults )
		    goto LABEL_28;
		  v30 = *(_QWORD *)&worldPosition->x;
		  v31.z = worldPosition->z;
		  *(_QWORD *)&v31.x = v30;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1554(
		           (ILFixDynamicMethodWrapper_2 *)m_ReadbackResults,
		           (Object *)this,
		           cameraInstanceID,
		           (Vector3 *)&v31,
		           v8,
		           displacement,
		           0LL);
		}
		
		public bool GetWaterReadbackHeight(int cameraInstanceID, int heightLayer, int positionIndex, out float height) {
			height = default;
			return default;
		} // 0x000000018309FD20-0x00000001830A00F0
		// Boolean GetWaterReadbackHeight(Int32, Int32, Int32, Single ByRef)
		bool HG::Rendering::Runtime::HGWaterManager::GetWaterReadbackHeight(
		        HGWaterManager *this,
		        int32_t cameraInstanceID,
		        int32_t heightLayer,
		        int32_t positionIndex,
		        float *height,
		        MethodInfo *method)
		{
		  __int64 v7; // rbp
		  struct ILFixDynamicMethodWrapper_2__Class *entries; // rcx
		  __int64 v10; // rdi
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Dictionary_2_System_Int32_System_Object_ *m_ReadbackResults; // rbx
		  struct MethodInfo *v13; // rsi
		  int32_t Entry; // eax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  _OWORD *v17; // rdx
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
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
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
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
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-108h]
		  __int64 v64; // [rsp+40h] [rbp-E8h] BYREF
		  __int128 v65; // [rsp+50h] [rbp-D8h]
		  __int128 v66; // [rsp+60h] [rbp-C8h]
		  __int128 v67; // [rsp+70h] [rbp-B8h]
		  __int128 v68; // [rsp+80h] [rbp-A8h]
		  __int128 v69; // [rsp+90h] [rbp-98h]
		  __int128 v70; // [rsp+A0h] [rbp-88h]
		  __int128 v71; // [rsp+B0h] [rbp-78h]
		  __int128 v72; // [rsp+C0h] [rbp-68h]
		  __int128 v73; // [rsp+D0h] [rbp-58h]
		  __int128 v74; // [rsp+E0h] [rbp-48h]
		  __int128 v75; // [rsp+F0h] [rbp-38h]
		  __int128 v76; // [rsp+100h] [rbp-28h]
		
		  v7 = positionIndex;
		  entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v10 = heightLayer;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = entries->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size <= 5375 )
		    goto LABEL_5;
		  if ( !entries->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(entries);
		    entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = entries->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size <= 0x14FFu )
		    goto LABEL_23;
		  if ( !wrapperArray[149].vector[11] )
		  {
		LABEL_5:
		    entries = 0LL;
		    *height = 0.0;
		    if ( (unsigned int)v10 <= 3 && (unsigned int)v7 <= 7 )
		    {
		      m_ReadbackResults = (Dictionary_2_System_Int32_System_Object_ *)this->fields.m_ReadbackResults;
		      if ( !m_ReadbackResults )
		        goto LABEL_22;
		      v13 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		            + 4) )
		        (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWaterManager::HGWaterReadbackOutputManaged>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		      Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
		                m_ReadbackResults,
		                cameraInstanceID,
		                (MethodInfo *)v13->klass->rgctx_data[22].rgctxDataDummy);
		      if ( Entry >= 0 )
		      {
		        entries = (struct ILFixDynamicMethodWrapper_2__Class *)m_ReadbackResults->fields._entries;
		        if ( !entries )
		          goto LABEL_22;
		        if ( (unsigned int)Entry >= LODWORD(entries->_0.namespaze) )
		          goto LABEL_23;
		        v64 = *((_QWORD *)&entries->_0.this_arg.data.dummy + 3 * Entry);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v64, (HGRuntimeGrassQuery_Node *)wrapperArray, v15, v16, P3);
		        if ( !v64 )
		          goto LABEL_22;
		        if ( *(_BYTE *)(v64 + 184) )
		        {
		          wrapperArray = *(ILFixDynamicMethodWrapper_2__Array **)(v64 + 48);
		          if ( wrapperArray )
		          {
		            if ( (unsigned int)v10 < wrapperArray->max_length.size )
		            {
		              v17 = (_OWORD *)((char *)wrapperArray + 192 * v10);
		              v18 = v17[3];
		              v65 = v17[2];
		              v19 = v17[4];
		              v66 = v18;
		              v20 = v17[5];
		              v67 = v19;
		              v21 = v17[6];
		              v68 = v20;
		              v22 = v17[7];
		              v69 = v21;
		              v23 = v17[8];
		              v70 = v22;
		              v24 = v17[10];
		              v71 = v23;
		              v72 = v17[9];
		              v25 = v17[11];
		              v73 = v24;
		              v26 = v17[12];
		              v74 = v25;
		              v27 = v17[13];
		              v75 = v26;
		              v76 = v27;
		              if ( (_BYTE)v65 )
		              {
		                v28 = v17[3];
		                v65 = v17[2];
		                v29 = v17[4];
		                v66 = v28;
		                v30 = v17[5];
		                v67 = v29;
		                v31 = v17[6];
		                v68 = v30;
		                v32 = v17[7];
		                v69 = v31;
		                v33 = v17[8];
		                v70 = v32;
		                v34 = v17[9];
		                v71 = v33;
		                v35 = v17[10];
		                v72 = v34;
		                v36 = v17[11];
		                v73 = v35;
		                v37 = v17[12];
		                v74 = v36;
		                v38 = v17[13];
		                v75 = v37;
		                v76 = v38;
		                if ( *((_QWORD *)&v65 + 1) )
		                {
		                  v39 = v17[3];
		                  v65 = v17[2];
		                  v40 = v17[4];
		                  v66 = v39;
		                  v41 = v17[5];
		                  v67 = v40;
		                  v42 = v17[6];
		                  v68 = v41;
		                  v43 = v17[7];
		                  v69 = v42;
		                  v44 = v17[8];
		                  v70 = v43;
		                  v45 = v17[9];
		                  v71 = v44;
		                  v46 = v17[10];
		                  v72 = v45;
		                  v47 = v17[11];
		                  v73 = v46;
		                  v48 = v17[12];
		                  v74 = v47;
		                  v49 = v17[13];
		                  v75 = v48;
		                  v76 = v49;
		                  if ( SDWORD2(v66) >= (int)v7 + 1 )
		                  {
		                    v50 = v17[3];
		                    v65 = v17[2];
		                    v51 = v17[4];
		                    v66 = v50;
		                    v52 = v17[5];
		                    v67 = v51;
		                    v53 = v17[6];
		                    v68 = v52;
		                    v54 = v17[7];
		                    v69 = v53;
		                    v55 = v17[8];
		                    v70 = v54;
		                    v56 = v17[9];
		                    v71 = v55;
		                    v57 = v17[10];
		                    v72 = v56;
		                    v58 = v17[11];
		                    v73 = v57;
		                    v59 = v17[12];
		                    v74 = v58;
		                    v60 = v17[13];
		                    v75 = v59;
		                    v76 = v60;
		                    result = 1;
		                    *height = *(float *)(*((_QWORD *)&v65 + 1) + 4 * v7);
		                    return result;
		                  }
		                }
		              }
		              return 0;
		            }
		LABEL_23:
		            sub_1800D2AB0(entries, wrapperArray);
		          }
		LABEL_22:
		          sub_1800D8260(entries, wrapperArray);
		        }
		      }
		    }
		    return 0;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5375, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1555(Patch, (Object *)this, cameraInstanceID, v10, v7, height, 0LL);
		}
		
	}
}
