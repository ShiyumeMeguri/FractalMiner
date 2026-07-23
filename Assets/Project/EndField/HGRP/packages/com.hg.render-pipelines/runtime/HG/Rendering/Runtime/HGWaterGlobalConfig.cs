using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGWaterGlobalConfig : MonoBehaviour // TypeDefIndex: 38781
	{
		// Fields
		public const string DEFAULT_HG_WATER_CONFIG = "Packages/com.hg.render-pipelines/Resources/Water/DefaultHGWaterConfig.asset"; // Metadata: 0x0230424D
		public const string DEFAULT_HG_WATER_GLOBAL_CONFIG_DATA = "Packages/com.hg.render-pipelines/Resources/Water/DefaultHGWaterGlobalConfigData.asset"; // Metadata: 0x0230429A
		public const string DEFAULT_FLOW_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_default_flowmap01.tga"; // Metadata: 0x023042F1
		public const string DEFAULT_CAUSTIC_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_caustic_01.png"; // Metadata: 0x02304344
		public const string DEFAULT_NORMAL_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_normal04_WN.tga"; // Metadata: 0x02304396
		public const string DEFAULT_RAIN_MAP = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_rain_01_M.tga"; // Metadata: 0x023043E9
		public const string DEFAULT_NORMAL_MAP_ARRAY_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_normal_atalas_WN.tga"; // Metadata: 0x0230443A
		private const string DEFAULT_HELP_DOCUMENT = ":)"; // Metadata: 0x02304492
		private string[] m_defaultSectorDataPaths; // 0x18
		private long[] m_defaultSectorDataAssetHashes; // 0x20
		private bool[] m_defaultSectorDataExists; // 0x28
		[Header("\u65B0\u7248\u914D\u7F6E")]
		public HGWaterGlobalConfigData data; // 0x30
	
		// Properties
		public string scenePath { get => default; } // 0x0000000183F32190-0x0000000183F32200 
		// String get_scenePath()
		String *HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGWaterGlobalConfigData *data; // rax
		  String *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 2315 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x90B )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[49]._0.fields )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2315, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  data = this->fields.data;
		  if ( !data )
		    return (String *)"";
		  result = data->fields.scenePath;
		  if ( !result )
		    return (String *)"";
		  return result;
		}
		
		public Vector2 sceneCenterOffset { get => default; } // 0x000000018334CD20-0x000000018334CD90 
		// Vector2 get_sceneCenterOffset()
		Vector2 HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGWaterGlobalConfigData *data; // rax
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
		  if ( wrapperArray->max_length.size > 1017 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3F9 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[21]._1.thread_static_fields_offset )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1017, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(Patch, (Object *)this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  data = this->fields.data;
		  if ( data )
		    return (Vector2)_mm_unpacklo_ps(
		                      (__m128)LODWORD(data->fields.sceneCenterOffset.x),
		                      (__m128)LODWORD(data->fields.sceneCenterOffset.y)).m128_u64[0];
		  else
		    return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		}
		
		public Vector2 sceneCenterOffsetSector { get => default; } // 0x0000000189C6341C-0x0000000189C63488 
		// Vector2 get_sceneCenterOffsetSector()
		Vector2 HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffsetSector(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  HGWaterGlobalConfigData *data; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5337, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5337, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = this->fields.data;
		    if ( data )
		      return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sceneCenterOffsetSector(data, 0LL);
		    else
		      return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  }
		}
		
		public string[] sectorDataPaths { get => default; } // 0x0000000189C63488-0x0000000189C634E8 
		// String[] get_sectorDataPaths()
		String__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataPaths(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  HGWaterGlobalConfigData *data; // rax
		  String__Array *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3479, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3479, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = this->fields.data;
		    if ( !data )
		      return this->fields.m_defaultSectorDataPaths;
		    result = data->fields.sectorDataPaths;
		    if ( !result )
		      return this->fields.m_defaultSectorDataPaths;
		  }
		  return result;
		}
		
		public long[] sectorDataAssetHashes { get => default; } // 0x0000000184D55270-0x0000000184D552B0 
		// Int64[] get_sectorDataAssetHashes()
		Int64__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataAssetHashes(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  HGWaterGlobalConfigData *data; // rax
		  Int64__Array *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2322, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2322, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_919(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = this->fields.data;
		    if ( !data )
		      return this->fields.m_defaultSectorDataAssetHashes;
		    result = data->fields.sectorDataAssetHashes;
		    if ( !result )
		      return this->fields.m_defaultSectorDataAssetHashes;
		  }
		  return result;
		}
		
		public bool[] sectorDataExists { get => default; } // 0x0000000184D55230-0x0000000184D55270 
		// Boolean[] get_sectorDataExists()
		Boolean__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  HGWaterGlobalConfigData *data; // rax
		  Boolean__Array *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2323, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2323, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_920(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = this->fields.data;
		    if ( !data )
		      return this->fields.m_defaultSectorDataExists;
		    result = data->fields.sectorDataExists;
		    if ( !result )
		      return this->fields.m_defaultSectorDataExists;
		  }
		  return result;
		}
		
		public int mapSize { get => default; } // 0x00000001831CBB50-0x00000001831CBBC0 
		// Int32 get_mapSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGWaterGlobalConfigData *data; // rax
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
		  if ( wrapperArray->max_length.size > 1021 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3FD )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[21]._1.naturalAligment )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1021, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  data = this->fields.data;
		  if ( data )
		    return data->fields.mapSize;
		  else
		    return 2048;
		}
		
		public int sectorSize { get => default; } // 0x0000000184D31040-0x0000000184D311A0 
		// Int32 get_sectorSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1023, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1023, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v4 = TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( data )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      if ( data->fields._._.m_CachedPtr )
		      {
		        v6 = this->fields.data;
		        if ( v6 )
		          return v6->fields.sectorSize;
		LABEL_12:
		        sub_1800D8260(v4, v3);
		      }
		    }
		    return 128;
		  }
		}
		
		public int sectorXNum { get => default; } // 0x0000000189C634E8-0x0000000189C63588 
		// Int32 get_sectorXNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorXNum(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  Object_1 *data; // rbx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *v5; // rcx
		  int32_t mapSize; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2317, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2317, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = (Object_1 *)this->fields.data;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
		    {
		      v5 = this->fields.data;
		      if ( v5 )
		        return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorXNum(v5, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    mapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL);
		    return mapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL);
		  }
		}
		
		public int sectorZNum { get => default; } // 0x0000000189C63588-0x0000000189C63628 
		// Int32 get_sectorZNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorZNum(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  Object_1 *data; // rbx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *v5; // rcx
		  int32_t mapSize; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2319, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2319, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = (Object_1 *)this->fields.data;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
		    {
		      v5 = this->fields.data;
		      if ( v5 )
		        return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorZNum(v5, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    mapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL);
		    return mapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL);
		  }
		}
		
		public int sectorNum { get => default; } // 0x00000001833C6460-0x00000001833C6750 
		// Int32 get_sectorNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v5; // rax
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v7; // rbx
		  int32_t mapSize; // edi
		  int sectorSize; // r8d
		  bool v10; // zf
		  int v11; // esi
		  int32_t v12; // edi
		  int32_t v13; // ecx
		  bool v14; // zf
		  int32_t v15; // eax
		  int32_t sectorXNum; // ebx
		  int32_t v18; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *v20; // rdx
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		  int32_t v23; // eax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  ILFixDynamicMethodWrapper_2 *v25; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_43;
		  if ( wrapperArray->max_length.size <= 2316 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_43;
		  if ( wrapperArray->max_length.size <= 0x90Cu )
		    goto LABEL_92;
		  if ( !wrapperArray[64].vector[12] )
		  {
		LABEL_5:
		    v5 = TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		    }
		    if ( !data )
		      goto LABEL_38;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		    {
		LABEL_38:
		      sectorXNum = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorXNum(this, 0LL);
		      return sectorXNum * HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorZNum(this, 0LL);
		    }
		    v7 = this->fields.data;
		    if ( !v7 )
		      goto LABEL_43;
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size > 2321 )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = v3->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        goto LABEL_43;
		      if ( wrapperArray->max_length.size <= 0x911u )
		        goto LABEL_92;
		      if ( wrapperArray[64].vector[17] )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(2321, 0LL);
		        if ( !Patch )
		          goto LABEL_43;
		        v20 = (Object *)v7;
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, v20, 0LL);
		      }
		    }
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size > 2318 )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = v3->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        goto LABEL_43;
		      if ( wrapperArray->max_length.size <= 0x90Eu )
		        goto LABEL_92;
		      if ( wrapperArray[64].vector[14] )
		      {
		        v21 = IFix::WrappersManagerImpl::GetPatch(2318, 0LL);
		        if ( !v21 )
		          goto LABEL_43;
		        v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v21, (Object *)v7, 0LL);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        goto LABEL_47;
		      }
		    }
		    mapSize = v7->fields.mapSize;
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 1028 )
		      goto LABEL_23;
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 0x404u )
		      goto LABEL_92;
		    if ( wrapperArray[28].vector[20] )
		    {
		      v22 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		      if ( !v22 )
		        goto LABEL_43;
		      v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v22, (Object *)v7, 0LL);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      sectorSize = v23;
		    }
		    else
		    {
		LABEL_23:
		      sectorSize = v7->fields.sectorSize;
		      v10 = sectorSize == 128;
		      if ( sectorSize >= 128 )
		      {
		LABEL_24:
		        if ( v10 )
		        {
		          v11 = mapSize / 128;
		LABEL_26:
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v3->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            goto LABEL_43;
		          if ( wrapperArray->max_length.size > 2320 )
		          {
		            if ( !v3->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v3);
		              v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = v3->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              goto LABEL_43;
		            if ( wrapperArray->max_length.size <= 0x910u )
		              goto LABEL_92;
		            if ( wrapperArray[64].vector[16] )
		            {
		              v24 = IFix::WrappersManagerImpl::GetPatch(2320, 0LL);
		              if ( v24 )
		              {
		                v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                        (ILFixDynamicMethodWrapper_31 *)v24,
		                        (Object *)v7,
		                        0LL);
		                return v11 * v15;
		              }
		              goto LABEL_43;
		            }
		          }
		          v12 = v7->fields.mapSize;
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v3->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            goto LABEL_43;
		          if ( wrapperArray->max_length.size <= 1028 )
		          {
		LABEL_34:
		            v13 = v7->fields.sectorSize;
		            v14 = v13 == 128;
		            if ( v13 >= 128 )
		              goto LABEL_35;
		            v13 = 128;
		LABEL_42:
		            v14 = v13 == 128;
		LABEL_35:
		            if ( v14 )
		              v15 = v12 / 128;
		            else
		              v15 = v12 / v13;
		            return v11 * v15;
		          }
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		          if ( !v3 )
		LABEL_43:
		            sub_1800D8260(v3, wrapperArray);
		          if ( LODWORD(v3->_0.namespaze) > 0x404 )
		          {
		            if ( !v3[21].vtable.ToString.methodPtr )
		              goto LABEL_34;
		            v25 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		            if ( v25 )
		            {
		              v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                      (ILFixDynamicMethodWrapper_31 *)v25,
		                      (Object *)v7,
		                      0LL);
		              goto LABEL_42;
		            }
		            goto LABEL_43;
		          }
		LABEL_92:
		          sub_1800D2AB0(v3, wrapperArray);
		        }
		        v18 = mapSize / sectorSize;
		LABEL_47:
		        v11 = v18;
		        goto LABEL_26;
		      }
		      sectorSize = 128;
		    }
		    v10 = sectorSize == 128;
		    goto LABEL_24;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2316, 0LL);
		  if ( !Patch )
		    goto LABEL_43;
		  v20 = (Object *)this;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, v20, 0LL);
		}
		
		public int halfMapSize { get => default; } // 0x0000000189C63388-0x0000000189C6341C 
		// Int32 get_halfMapSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  Object_1 *data; // rbx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1020, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1020, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = (Object_1 *)this->fields.data;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
		    {
		      v5 = this->fields.data;
		      if ( v5 )
		        return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_halfMapSize(v5, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL) / 2;
		  }
		}
		
		public int sectorCoordsMin { get => default; } // 0x000000018334CE60-0x000000018334CF70 
		// Int32 get_sectorCoordsMin()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  HGWaterGlobalConfigData *v3; // rcx
		  __int64 v4; // rdx
		  struct Object_1__Class *v5; // rcx
		  HGWaterGlobalConfigData *data; // rbx
		  int32_t halfMapSize; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&v3[1].fields.sceneCenterOffset;
		  if ( !v4 )
		    goto LABEL_13;
		  if ( *(int *)(v4 + 24) <= 1026 )
		    goto LABEL_5;
		  if ( !v3[1].fields.mapSize )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = **(HGWaterGlobalConfigData ***)&v3[1].fields.sceneCenterOffset;
		  if ( !v3 )
		    goto LABEL_13;
		  if ( LODWORD(v3->fields.scenePath) <= 0x402 )
		    sub_1800D2AB0(v3, v4);
		  if ( !*(_QWORD *)&v3[54].fields.sceneCenterOffset )
		  {
		LABEL_5:
		    v5 = TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      goto LABEL_12;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( !data->fields._._.m_CachedPtr )
		    {
		LABEL_12:
		      halfMapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(this, 0LL);
		      return -(halfMapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL));
		    }
		    v3 = this->fields.data;
		    if ( v3 )
		      return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(v3, 0LL);
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1026, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int sectorCoordsMax { get => default; } // 0x000000018334DBA0-0x000000018334DC60 
		// Int32 get_sectorCoordsMax()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rcx
		  int32_t halfMapSize; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1019, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1019, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v4 = TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( data )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      if ( data->fields._._.m_CachedPtr )
		      {
		        v6 = this->fields.data;
		        if ( v6 )
		          return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(v6, 0LL);
		LABEL_12:
		        sub_1800D8260(v6, v3);
		      }
		    }
		    halfMapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(this, 0LL);
		    return halfMapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL) - 1;
		  }
		}
		
		public float flowmapPrecision { get => default; } // 0x0000000189C63300-0x0000000189C63388 
		// Single get_flowmapPrecision()
		float HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowmapPrecision(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  Object_1 *data; // rbx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGWaterGlobalConfigData *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5339, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5339, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    data = (Object_1 *)this->fields.data;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
		    {
		      v6 = this->fields.data;
		      if ( v6 )
		        return v6->fields.flowmapPrecision;
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return 0.5;
		  }
		}
		
		public int sectorTextureSize { get => default; } // 0x0000000183EA2E70-0x0000000183EA2FD0 
		// Int32 get_sectorTextureSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorTextureSize(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 997 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3E5u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1001] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 256;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 256;
		    v6 = this->fields.data;
		    if ( v6 )
		      return (int)(float)(128.0 / v6->fields.flowmapPrecision);
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(997, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int lodNum { get => default; } // 0x0000000183E6E5C0-0x0000000183E6E690 
		// Int32 get_lodNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_lodNum(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1044 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x414u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1048] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 4;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 4;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.lodNum;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1044, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int meshNumPerLOD { get => default; } // 0x000000018334D670-0x000000018334D740 
		// Int32 get_meshNumPerLOD()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshNumPerLOD(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1013 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3F5u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1017] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 16;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 16;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.meshNumPerLOD;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1013, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int meshSize { get => default; } // 0x000000018334D3D0-0x000000018334D4A0 
		// Int32 get_meshSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshSize(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1016 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3F8u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1020] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 1;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 1;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.meshSize;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1016, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int heightMapXZ { get => default; } // 0x000000018334D300-0x000000018334D3D0 
		// Int32 get_heightMapXZ()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapXZ(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1008 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3F0u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1012] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 128;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 128;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.heightMapXZ;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1008, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int heightMapY { get => default; } // 0x000000018334CD90-0x000000018334CE60 
		// Int32 get_heightMapY()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1010 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3F2u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1014] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 64;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 64;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.heightMapY;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1010, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public float heightMapOffset { get => default; } // 0x000000018334D4A0-0x000000018334D570 
		// Single get_heightMapOffset()
		float HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapOffset(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
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
		  if ( *(int *)(v4 + 24) <= 1009 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_13;
		  if ( *((_DWORD *)v3 + 6) <= 0x3F1u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1013] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 0.0;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !data->fields._._.m_CachedPtr )
		      return 0.0;
		    v6 = this->fields.data;
		    if ( v6 )
		      return v6->fields.heightMapOffset;
		LABEL_13:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1009, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		public Texture2D flowMap { get => default; } // 0x00000001831CB400-0x00000001831CB560 
		// Texture2D get_flowMap()
		Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rdi
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2D *flowMap; // rdi
		  HGWaterGlobalConfigData *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_19;
		  if ( *(int *)(v4 + 24) <= 1045 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_19;
		  if ( *((_DWORD *)v3 + 6) <= 0x415u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1049] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v6 = this->fields.data;
		    if ( !v6 )
		      goto LABEL_19;
		    flowMap = v6->fields.flowMap;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !flowMap )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !flowMap->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v8 = this->fields.data;
		    if ( v8 )
		      return v8->fields.flowMap;
		LABEL_19:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1045, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)this, 0LL);
		}
		
		public Texture2D causticMap { get => default; } // 0x00000001831CB560-0x00000001831CB6D0 
		// Texture2D get_causticMap()
		Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rdi
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2D *causticMap; // rdi
		  HGWaterGlobalConfigData *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_19;
		  if ( *(int *)(v4 + 24) <= 1047 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_19;
		  if ( *((_DWORD *)v3 + 6) <= 0x417u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1051] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v6 = this->fields.data;
		    if ( !v6 )
		      goto LABEL_19;
		    causticMap = v6->fields.causticMap;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !causticMap )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !causticMap->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v8 = this->fields.data;
		    if ( v8 )
		      return v8->fields.causticMap;
		LABEL_19:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1047, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)this, 0LL);
		}
		
		public Texture2D rainMap { get => default; } // 0x0000000183DF3B30-0x0000000183DF3DD0 
		// Texture2D get_rainMap()
		Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rdi
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2D *rainMap; // rdi
		  HGWaterGlobalConfigData *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_19;
		  if ( *(int *)(v4 + 24) <= 1048 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_19;
		  if ( *((_DWORD *)v3 + 6) <= 0x418u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1052] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v6 = this->fields.data;
		    if ( !v6 )
		      goto LABEL_19;
		    rainMap = v6->fields.rainMap;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !rainMap )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !rainMap->fields._._.m_CachedPtr )
		      return UnityEngine::Texture2D::get_blackTexture(0LL);
		    v8 = this->fields.data;
		    if ( v8 )
		      return v8->fields.rainMap;
		LABEL_19:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1048, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)this, 0LL);
		}
		
		public Texture2DArray normalMapArray { get => default; } // 0x00000001831CA6F0-0x00000001831CA860 
		// Texture2DArray get_normalMapArray()
		Texture2DArray *HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
		        HGWaterGlobalConfig *this,
		        MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rdi
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2DArray *normalMapArray; // rdi
		  HGWaterGlobalConfigData *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_19;
		  if ( *(int *)(v4 + 24) <= 1046 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_19;
		  if ( *((_DWORD *)v3 + 6) <= 0x416u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[1050] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 0LL;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		      return 0LL;
		    v6 = this->fields.data;
		    if ( !v6 )
		      goto LABEL_19;
		    normalMapArray = v6->fields.normalMapArray;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !normalMapArray )
		      return 0LL;
		    if ( !*((_DWORD *)v3 + 56) )
		      il2cpp_runtime_class_init_1(v3);
		    if ( !normalMapArray->fields._._.m_CachedPtr )
		      return 0LL;
		    v8 = this->fields.data;
		    if ( v8 )
		      return v8->fields.normalMapArray;
		LABEL_19:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1046, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_403(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGWaterGlobalConfig() {} // 0x0000000183695570-0x0000000183695590
		// LuaUIWidget()
		void Beyond::Lua::LuaUIWidget::LuaUIWidget(LuaUIWidget *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		public int GetRealLODNum(HGSettingParameters settingParameters) => default; // 0x0000000183E6E520-0x0000000183E6E5C0
		// Int32 GetRealLODNum(HGSettingParameters)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealLODNum(
		        HGWaterGlobalConfig *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Int32Enum__Enum v7; // ebx
		  int32_t result; // eax
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
		  if ( wrapperArray->max_length.size <= 1042 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_8:
		    sub_1800D8260(v5, settingParameters);
		  if ( LODWORD(v5->_0.namespaze) <= 0x412 )
		    sub_1800D2AB0(v5, settingParameters);
		  if ( v5[22]._0.generic_class )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1042, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               (Object *)settingParameters,
		               0LL);
		    goto LABEL_8;
		  }
		LABEL_5:
		  if ( !settingParameters )
		    goto LABEL_8;
		  v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterLODNumAdded_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_lodNum(this, 0LL);
		  if ( result < 1 )
		    return 1;
		  return result;
		}
		
		public int GetRealMeshNumPerLOD(HGSettingParameters settingParameters) => default; // 0x000000018334D570-0x000000018334D670
		// Int32 GetRealMeshNumPerLOD(HGSettingParameters)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
		        HGWaterGlobalConfig *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  SettingParameter_1_System_Int32_ *waterMeshNumPerLODAdded_k__BackingField; // rbx
		  struct MethodInfo *v8; // rdi
		  Il2CppClass *klass; // rax
		  Il2CppClass *v10; // rcx
		  int32_t paramValue_k__BackingField; // ebx
		  int32_t result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size <= 1011 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_15:
		    sub_1800D8260(v5, wrapperArray);
		  if ( LODWORD(v5->_0.namespaze) <= 0x3F3 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( *(_QWORD *)&v5[21]._1.cctor_finished_or_no_cctor )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1011, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               (Object *)settingParameters,
		               0LL);
		    goto LABEL_15;
		  }
		LABEL_5:
		  if ( !settingParameters )
		    goto LABEL_15;
		  waterMeshNumPerLODAdded_k__BackingField = settingParameters->fields._waterMeshNumPerLODAdded_k__BackingField;
		  v8 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !waterMeshNumPerLODAdded_k__BackingField )
		    goto LABEL_15;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v14 = sub_18011C4C0(v8->klass);
		    (**(void (***)(void))(*(_QWORD *)(v14 + 192) + 48LL))();
		  }
		  v10 = v8->klass;
		  if ( ((__int64)v10->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v10, wrapperArray);
		  paramValue_k__BackingField = waterMeshNumPerLODAdded_k__BackingField->fields._paramValue_k__BackingField;
		  result = paramValue_k__BackingField + HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshNumPerLOD(this, 0LL);
		  if ( result < 1 )
		    return 1;
		  return result;
		}
		
		public int GetRealMeshSize(HGSettingParameters settingParameters) => default; // 0x000000018334D260-0x000000018334D300
		// Int32 GetRealMeshSize(HGSettingParameters)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshSize(
		        HGWaterGlobalConfig *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Int32Enum__Enum v7; // ebx
		  int32_t result; // eax
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
		  if ( wrapperArray->max_length.size <= 1014 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_8:
		    sub_1800D8260(v5, settingParameters);
		  if ( LODWORD(v5->_0.namespaze) <= 0x3F6 )
		    sub_1800D2AB0(v5, settingParameters);
		  if ( *(_QWORD *)&v5[21]._1.instance_size )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1014, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               (Object *)settingParameters,
		               0LL);
		    goto LABEL_8;
		  }
		LABEL_5:
		  if ( !settingParameters )
		    goto LABEL_8;
		  v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterMeshSizeAdded_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshSize(this, 0LL);
		  if ( result < 1 )
		    return 1;
		  return result;
		}
		
		public int GetRealHeightMapXZ(HGSettingParameters settingParameters) => default; // 0x000000018334D1C0-0x000000018334D260
		// Int32 GetRealHeightMapXZ(HGSettingParameters)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealHeightMapXZ(
		        HGWaterGlobalConfig *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Int32Enum__Enum v7; // ebx
		  int32_t result; // eax
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
		  if ( wrapperArray->max_length.size <= 1006 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_8:
		    sub_1800D8260(v5, settingParameters);
		  if ( LODWORD(v5->_0.namespaze) <= 0x3EE )
		    sub_1800D2AB0(v5, settingParameters);
		  if ( v5[21].static_fields )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1006, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               (Object *)settingParameters,
		               0LL);
		    goto LABEL_8;
		  }
		LABEL_5:
		  if ( !settingParameters )
		    goto LABEL_8;
		  v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterHeightMapXZAdded_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapXZ(this, 0LL);
		  if ( result < 1 )
		    return 1;
		  return result;
		}
		
		public bool ShouldRenderWater() => default; // 0x00000001831CABF0-0x00000001831CAD50
		// Boolean ShouldRenderWater()
		bool HG::Rendering::Runtime::HGWaterGlobalConfig::ShouldRenderWater(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2DArray *normalMapArray; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_18;
		  if ( *(int *)(v4 + 24) <= 995 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)v3 + 56) )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (_QWORD **)*v3[23];
		  if ( !v3 )
		    goto LABEL_18;
		  if ( *((_DWORD *)v3 + 6) <= 0x3E3u )
		    sub_1800D2AB0(v3, v4);
		  if ( !v3[999] )
		  {
		LABEL_5:
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
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
		    if ( !data )
		      return 0;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		    if ( !data->fields._._.m_CachedPtr )
		      return 0;
		    v6 = this->fields.data;
		    if ( v6 )
		    {
		      normalMapArray = v6->fields.normalMapArray;
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( normalMapArray )
		      {
		        if ( !*((_DWORD *)v3 + 56) )
		          il2cpp_runtime_class_init_1(v3);
		        if ( normalMapArray->fields._._.m_CachedPtr )
		          return 1;
		      }
		      return 0;
		    }
		LABEL_18:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(995, 0LL);
		  if ( !Patch )
		    goto LABEL_18;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void LogInfo() {} // 0x0000000183C52980-0x0000000183C52AA0
		// Void LogInfo()
		void HG::Rendering::Runtime::HGWaterGlobalConfig::LogInfo(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rax
		  Texture2DArray *normalMapArray; // rbx
		  Object *scenePath; // rbx
		  Object_1 *v9; // rax
		  Object *v10; // rax
		  Object_1 *gameObject; // rax
		  Object *name; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5340, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5340, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_18:
		    sub_1800D8260(v4, v3);
		  }
		  v4 = TypeInfo::UnityEngine::Object;
		  data = this->fields.data;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v4 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !data )
		    goto LABEL_21;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::UnityEngine::Object;
		  }
		  if ( !data->fields._._.m_CachedPtr )
		  {
		LABEL_21:
		    gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( gameObject )
		    {
		      name = (Object *)UnityEngine::Object::get_name(gameObject, 0LL);
		      HG::Rendering::HGRPLogger::LogError<System::Object,System::Object>(
		        (String *)"错误：不会绘制水，因为场景的HGWaterConfig({0})上的 data 为空，请尽快处理！如何处理可以参考文档（{1}）",
		        name,
		        (Object *)":)",
		        MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String>);
		      return;
		    }
		    goto LABEL_18;
		  }
		  v6 = this->fields.data;
		  if ( !v6 )
		    goto LABEL_18;
		  normalMapArray = v6->fields.normalMapArray;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !normalMapArray )
		    goto LABEL_19;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v4);
		  if ( !normalMapArray->fields._._.m_CachedPtr )
		  {
		LABEL_19:
		    scenePath = (Object *)HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(this, 0LL);
		    v9 = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( v9 )
		    {
		      v10 = (Object *)UnityEngine::Object::get_name(v9, 0LL);
		      HG::Rendering::HGRPLogger::LogError<System::Object,System::Object,System::Object>(
		        (String *)"错误：不会绘制水，因为场景({0})的HGWaterConfig({1})上的 normalMapArray 贴图为空，请尽快处理！如何处理可以参考文档（{2}）",
		        scenePath,
		        v10,
		        (Object *)":)",
		        MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String,System::String>);
		      return;
		    }
		    goto LABEL_18;
		  }
		}
		
		private void InitDefault() {} // 0x00000001833C62D0-0x00000001833C6460
		// Void InitDefault()
		void HG::Rendering::Runtime::HGWaterGlobalConfig::InitDefault(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  unsigned int sectorNum; // eax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  int32_t v7; // edi
		  unsigned int v8; // esi
		  __int64 v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  _DWORD *m_defaultSectorDataPaths; // rcx
		  unsigned int v13; // eax
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  int32_t i; // esi
		  __int64 v18; // rax
		  unsigned int v19; // eax
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  __int64 v23; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5341, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5341, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sectorNum = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL);
		    this->fields.m_defaultSectorDataPaths = (String__Array *)il2cpp_array_new_specific_1(
		                                                               TypeInfo::System::String,
		                                                               sectorNum);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultSectorDataPaths, v4, v5, v6, v25);
		    v7 = 0;
		    v8 = 0;
		    if ( HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL) > 0 )
		    {
		      while ( 1 )
		      {
		        m_defaultSectorDataPaths = this->fields.m_defaultSectorDataPaths;
		        if ( !m_defaultSectorDataPaths )
		          break;
		        v9 = (int)v8;
		        if ( v8 >= m_defaultSectorDataPaths[6] )
		LABEL_16:
		          sub_1800D2AB0(m_defaultSectorDataPaths, v9);
		        *(_QWORD *)&m_defaultSectorDataPaths[2 * v8 + 8] = "";
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&m_defaultSectorDataPaths[2 * v8 + 8],
		          (HGRuntimeGrassQuery_Node *)(int)v8,
		          v10,
		          v11,
		          v26);
		        if ( (int)++v8 >= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL) )
		          goto LABEL_6;
		      }
		LABEL_15:
		      sub_1800D8260(m_defaultSectorDataPaths, v9);
		    }
		LABEL_6:
		    v13 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL);
		    this->fields.m_defaultSectorDataAssetHashes = (Int64__Array *)il2cpp_array_new_specific_1(
		                                                                    TypeInfo::System::Int64,
		                                                                    v13);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultSectorDataAssetHashes, v14, v15, v16, v26);
		    for ( i = 0;
		          i < HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL);
		          *(_QWORD *)&m_defaultSectorDataPaths[2 * v18 + 8] = 0LL )
		    {
		      m_defaultSectorDataPaths = this->fields.m_defaultSectorDataAssetHashes;
		      if ( !m_defaultSectorDataPaths )
		        goto LABEL_15;
		      if ( (unsigned int)i >= m_defaultSectorDataPaths[6] )
		        goto LABEL_16;
		      v18 = i++;
		    }
		    v19 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL);
		    this->fields.m_defaultSectorDataExists = (Boolean__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::System::Boolean,
		                                                                 v19);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultSectorDataExists, v20, v21, v22, v27);
		    if ( HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL) > 0 )
		    {
		      while ( 1 )
		      {
		        m_defaultSectorDataPaths = this->fields.m_defaultSectorDataExists;
		        if ( !m_defaultSectorDataPaths )
		          goto LABEL_15;
		        if ( (unsigned int)v7 >= m_defaultSectorDataPaths[6] )
		          goto LABEL_16;
		        v23 = v7++;
		        *((_BYTE *)m_defaultSectorDataPaths + v23 + 32) = 0;
		        if ( v7 >= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(this, 0LL) )
		          return;
		      }
		    }
		  }
		}
		
		private void OnEnable() {} // 0x0000000183C52DB0-0x0000000183C52E20
		// Void OnEnable()
		void HG::Rendering::Runtime::HGWaterGlobalConfig::OnEnable(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  HGManagerContext *ManagerContext; // rax
		  __int64 v4; // rdx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5342, 0LL) )
		  {
		    HG::Rendering::Runtime::HGWaterGlobalConfig::InitDefault(this, 0LL);
		    HG::Rendering::Runtime::HGWaterGlobalConfig::LogInfo(this, 0LL);
		    ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
		    if ( ManagerContext )
		    {
		      waterManager_k__BackingField = ManagerContext->fields._waterManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGWaterManager::AddWaterGlobalConfig(waterManager_k__BackingField, this, 0LL);
		        HG::Rendering::Runtime::HGWaterGlobalConfig::UpdateHGWaterConfigs(this, 0LL);
		        return;
		      }
		    }
		LABEL_5:
		    sub_1800D8260(waterManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5342, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000189C63298-0x0000000189C63300
		// Void OnDisable()
		void HG::Rendering::Runtime::HGWaterGlobalConfig::OnDisable(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  HGManagerContext *ManagerContext; // rax
		  __int64 v4; // rdx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5347, 0LL) )
		  {
		    ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
		    if ( ManagerContext )
		    {
		      waterManager_k__BackingField = ManagerContext->fields._waterManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGWaterManager::RemoveWaterGlobalConfig(waterManager_k__BackingField, this, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(waterManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5347, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public ValueTuple<int, int> GetSectorCoords(Vector3 pos) => default; // 0x000000018334D740-0x000000018334D880
		// ValueTuple`2[Int32,Int32] GetSectorCoords(Vector3)
		ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
		        HGWaterGlobalConfig *this,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  HGWaterGlobalConfigData *v5; // rcx
		  __int64 v6; // r8
		  struct Object_1__Class *v7; // rcx
		  HGWaterGlobalConfigData *data; // rdi
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // xmm0_8
		  Vector3 v13[2]; // [rsp+20h] [rbp-18h] BYREF
		  ValueTuple_2_Int32_Int32_ v14; // [rsp+58h] [rbp+20h]
		
		  v5 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(_QWORD **)&v5[1].fields.sceneCenterOffset;
		  if ( !v6 )
		    goto LABEL_13;
		  if ( *(int *)(v6 + 24) <= 1018 )
		    goto LABEL_5;
		  if ( !v5[1].fields.mapSize )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = (HGWaterGlobalConfigData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = **(HGWaterGlobalConfigData ***)&v5[1].fields.sceneCenterOffset;
		  if ( !v5 )
		    goto LABEL_13;
		  if ( LODWORD(v5->fields.scenePath) <= 0x3FA )
		    sub_1800D2AB0(v5, pos);
		  if ( !v5[53].fields.flowMap )
		  {
		LABEL_5:
		    v7 = TypeInfo::UnityEngine::Object;
		    data = this->fields.data;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v7 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !data )
		      goto LABEL_12;
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v7);
		    if ( !data->fields._._.m_CachedPtr )
		    {
		LABEL_12:
		      v14.Item1 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(this, 0LL) + 100;
		      v14.Item2 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(this, 0LL) + 100;
		      return v14;
		    }
		    v5 = this->fields.data;
		    if ( v5 )
		    {
		      z = pos->z;
		      *(_QWORD *)&v13[0].x = *(_QWORD *)&pos->x;
		      v13[0].z = z;
		      return HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorCoords(v5, v13, 0LL);
		    }
		LABEL_13:
		    sub_1800D8260(v5, pos);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1018, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  v12 = *(_QWORD *)&pos->x;
		  v13[0].z = pos->z;
		  *(_QWORD *)&v13[0].x = v12;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_390(Patch, (Object *)this, v13, 0LL);
		}
		
		public int GetSectorIndex(int coordX, int coordZ) => default; // 0x0000000189C631EC-0x0000000189C63298
		// Int32 GetSectorIndex(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
		        HGWaterGlobalConfig *this,
		        int32_t coordX,
		        int32_t coordZ,
		        MethodInfo *method)
		{
		  Object_1 *data; // rbx
		  __int64 v8; // rdx
		  HGWaterGlobalConfigData *v9; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3471, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3471, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		             (ILFixDynamicMethodWrapper_14 *)Patch,
		             (Object *)this,
		             (SocketOptionLevel__Enum)coordX,
		             (SocketOptionName__Enum)coordZ,
		             0LL);
		  }
		  else
		  {
		    data = (Object_1 *)this->fields.data;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
		    {
		      v9 = this->fields.data;
		      if ( v9 )
		        return HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorIndex(v9, coordX, coordZ, 0LL);
		LABEL_7:
		      sub_1800D8260(v9, v8);
		    }
		    return -1;
		  }
		}
		
		public void UpdateHGWaterConfigs() {} // 0x0000000183C52AA0-0x0000000183C52B40
		// Void UpdateHGWaterConfigs()
		void HG::Rendering::Runtime::HGWaterGlobalConfig::UpdateHGWaterConfigs(HGWaterGlobalConfig *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  HGWaterGlobalConfigData *data; // rbx
		  HGWaterGlobalConfigData *v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5345, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5345, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_12;
		  }
		  v4 = TypeInfo::UnityEngine::Object;
		  data = this->fields.data;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v4 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( data )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v4);
		    if ( data->fields._._.m_CachedPtr )
		    {
		      v6 = this->fields.data;
		      if ( v6 )
		      {
		        HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateHGWaterConfigs(v6, 0LL);
		        return;
		      }
		LABEL_12:
		      sub_1800D8260(v6, v3);
		    }
		  }
		}
		
	}
}
