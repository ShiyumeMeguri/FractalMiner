using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[CreateAssetMenu(fileName = "HGWaterGlobalConfigData", menuName = "\u2605 Beyond/HGWater/HGWaterGlobalConfigData")]
	public class HGWaterGlobalConfigData : ScriptableObject // TypeDefIndex: 38782
	{
		// Fields
		public const int INVALID_SECTOR_INDEX = -1; // Metadata: 0x02304496
		public static IEnumerable mapSizeList; // 0x00
		public static IEnumerable sectorSizeList; // 0x08
		public static IEnumerable flowmapPrecisionList; // 0x10
		[SerializeField]
		public string scenePath; // 0x18
		[SerializeField]
		public Vector2 sceneCenterOffset; // 0x20
		[SerializeField]
		public bool useSectorData; // 0x28
		[SerializeField]
		public string[] sectorDataPaths; // 0x30
		[SerializeField]
		public long[] sectorDataAssetHashes; // 0x38
		[SerializeField]
		public bool[] sectorDataExists; // 0x40
		[SerializeField]
		public int mapSize; // 0x48
		[SerializeField]
		public int sectorSize; // 0x4C
		[Header("flowmap\u7CBE\u5EA6")]
		[SerializeField]
		public float flowmapPrecision; // 0x50
		[Range(1f, 4f)]
		[SerializeField]
		public int lodNum; // 0x54
		[Range(16f, 32f)]
		[SerializeField]
		public int meshNumPerLOD; // 0x58
		[Range(1f, 8f)]
		[SerializeField]
		public int meshSize; // 0x5C
		[Min(32f)]
		[SerializeField]
		public int heightMapXZ; // 0x60
		[Min(32f)]
		[SerializeField]
		public int heightMapY; // 0x64
		[Range(0f, 1f)]
		[SerializeField]
		public float heightMapOffset; // 0x68
		[Header("\u6C34\u4F53\u914D\u7F6E\u5217\u8868")]
		[SerializeField]
		public HGWaterConfig[] hgWaterConfigs; // 0x70
		[Header("\u5168\u5C40\u6D41\u5411\u8D34\u56FE")]
		[SerializeField]
		public Texture2D flowMap; // 0x78
		[Header("\u7126\u6563\u8D34\u56FE")]
		[SerializeField]
		public Texture2D causticMap; // 0x80
		[Header("\u96E8\u6EF4\u6CE2\u7EB9\u8D34\u56FE")]
		[SerializeField]
		public Texture2D rainMap; // 0x88
		[Header("\u6CD5\u7EBF\u8D34\u56FE\u5217\u8868")]
		[SerializeField]
		public Texture2DArray normalMapArray; // 0x90
	
		// Properties
		public int safeSectorSize { get => default; } // 0x00000001833C6AD0-0x00000001833C6C20 
		// Int32 get_safeSectorSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_safeSectorSize(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t result; // eax
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
		  if ( wrapperArray->max_length.size > 1028 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x404 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[21].vtable.ToString.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  result = 128;
		  if ( this->fields.sectorSize >= 128 )
		    return this->fields.sectorSize;
		  return result;
		}
		
		public int sectorXNum { get => default; } // 0x00000001833C6930-0x00000001833C6A00 
		// Int32 get_sectorXNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorXNum(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGWaterGlobalConfigData *v3; // rbx
		  int *static_fields; // rdx
		  int32_t mapSize; // edi
		  int32_t sectorSize; // ecx
		  bool v7; // zf
		  __int64 v9; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterGlobalConfigData__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_14;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 2318 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v9 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_14;
		    if ( *(_DWORD *)(v9 + 24) <= 0x90Eu )
		      goto LABEL_30;
		    if ( *(_QWORD *)(v9 + 18576) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2318, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)v3, 0LL);
		      goto LABEL_14;
		    }
		  }
		  mapSize = v3->fields.mapSize;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGWaterGlobalConfigData *)v2->static_fields;
		  static_fields = (int *)this->klass;
		  if ( !this->klass )
		    goto LABEL_14;
		  if ( static_fields[6] > 1028 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGWaterGlobalConfigData *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		      goto LABEL_14;
		    if ( LODWORD(klass->_0.namespaze) > 0x404 )
		    {
		      if ( !klass[21].vtable.ToString.methodPtr )
		        goto LABEL_9;
		      v12 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		      if ( v12 )
		      {
		        sectorSize = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)v12,
		                       (Object *)v3,
		                       0LL);
		        goto LABEL_13;
		      }
		LABEL_14:
		      sub_1800D8260(this, static_fields);
		    }
		LABEL_30:
		    sub_1800D2AB0(this, static_fields);
		  }
		LABEL_9:
		  sectorSize = v3->fields.sectorSize;
		  v7 = sectorSize == 128;
		  if ( sectorSize >= 128 )
		    goto LABEL_10;
		  sectorSize = 128;
		LABEL_13:
		  v7 = sectorSize == 128;
		LABEL_10:
		  if ( v7 )
		    return mapSize / 128;
		  else
		    return mapSize / sectorSize;
		}
		
		public int sectorZNum { get => default; } // 0x00000001833C6A00-0x00000001833C6AD0 
		// Int32 get_sectorZNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorZNum(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGWaterGlobalConfigData *v3; // rbx
		  int *static_fields; // rdx
		  int32_t mapSize; // edi
		  int32_t sectorSize; // ecx
		  bool v7; // zf
		  __int64 v9; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterGlobalConfigData__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_14;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 2320 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v9 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_14;
		    if ( *(_DWORD *)(v9 + 24) <= 0x910u )
		      goto LABEL_30;
		    if ( *(_QWORD *)(v9 + 18592) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2320, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)v3, 0LL);
		      goto LABEL_14;
		    }
		  }
		  mapSize = v3->fields.mapSize;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGWaterGlobalConfigData *)v2->static_fields;
		  static_fields = (int *)this->klass;
		  if ( !this->klass )
		    goto LABEL_14;
		  if ( static_fields[6] > 1028 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGWaterGlobalConfigData *)v2->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		      goto LABEL_14;
		    if ( LODWORD(klass->_0.namespaze) > 0x404 )
		    {
		      if ( !klass[21].vtable.ToString.methodPtr )
		        goto LABEL_9;
		      v12 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		      if ( v12 )
		      {
		        sectorSize = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)v12,
		                       (Object *)v3,
		                       0LL);
		        goto LABEL_13;
		      }
		LABEL_14:
		      sub_1800D8260(this, static_fields);
		    }
		LABEL_30:
		    sub_1800D2AB0(this, static_fields);
		  }
		LABEL_9:
		  sectorSize = v3->fields.sectorSize;
		  v7 = sectorSize == 128;
		  if ( sectorSize >= 128 )
		    goto LABEL_10;
		  sectorSize = 128;
		LABEL_13:
		  v7 = sectorSize == 128;
		LABEL_10:
		  if ( v7 )
		    return mapSize / 128;
		  else
		    return mapSize / sectorSize;
		}
		
		public int sectorNum { get => default; } // 0x00000001833C6750-0x00000001833C6930 
		// Int32 get_sectorNum()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorNum(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t mapSize; // edi
		  int32_t sectorSize; // r8d
		  bool v7; // zf
		  int v8; // esi
		  int32_t v9; // edi
		  int32_t v10; // ecx
		  bool v11; // zf
		  int32_t v12; // eax
		  int32_t v14; // eax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  int32_t v18; // eax
		  ILFixDynamicMethodWrapper_2 *v19; // rax
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_32;
		  if ( wrapperArray->max_length.size <= 2321 )
		    goto LABEL_74;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_32;
		  if ( wrapperArray->max_length.size <= 0x911u )
		    goto LABEL_71;
		  if ( !wrapperArray[64].vector[17] )
		  {
		LABEL_74:
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_32;
		    if ( wrapperArray->max_length.size > 2318 )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = v3->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        goto LABEL_32;
		      if ( wrapperArray->max_length.size <= 0x90Eu )
		        goto LABEL_71;
		      if ( wrapperArray[64].vector[14] )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(2318, 0LL);
		        if ( !Patch )
		          goto LABEL_32;
		        v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		        v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        goto LABEL_34;
		      }
		    }
		    mapSize = this->fields.mapSize;
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_32;
		    if ( wrapperArray->max_length.size <= 1028 )
		      goto LABEL_13;
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_32;
		    if ( wrapperArray->max_length.size <= 0x404u )
		      goto LABEL_71;
		    if ( wrapperArray[28].vector[20] )
		    {
		      v17 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		      if ( !v17 )
		        goto LABEL_32;
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v17, (Object *)this, 0LL);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      sectorSize = v18;
		    }
		    else
		    {
		LABEL_13:
		      sectorSize = this->fields.sectorSize;
		      v7 = sectorSize == 128;
		      if ( sectorSize >= 128 )
		      {
		LABEL_14:
		        if ( v7 )
		        {
		          v8 = mapSize / 128;
		LABEL_16:
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v3->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            goto LABEL_32;
		          if ( wrapperArray->max_length.size > 2320 )
		          {
		            if ( !v3->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v3);
		              v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = v3->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              goto LABEL_32;
		            if ( wrapperArray->max_length.size <= 0x910u )
		              goto LABEL_71;
		            if ( wrapperArray[64].vector[16] )
		            {
		              v19 = IFix::WrappersManagerImpl::GetPatch(2320, 0LL);
		              if ( v19 )
		              {
		                v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                        (ILFixDynamicMethodWrapper_31 *)v19,
		                        (Object *)this,
		                        0LL);
		                return v8 * v12;
		              }
		              goto LABEL_32;
		            }
		          }
		          v9 = this->fields.mapSize;
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = v3->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            goto LABEL_32;
		          if ( wrapperArray->max_length.size <= 1028 )
		          {
		LABEL_24:
		            v10 = this->fields.sectorSize;
		            v11 = v10 == 128;
		            if ( v10 >= 128 )
		              goto LABEL_25;
		            v10 = 128;
		LABEL_31:
		            v11 = v10 == 128;
		LABEL_25:
		            if ( v11 )
		              v12 = v9 / 128;
		            else
		              v12 = v9 / v10;
		            return v8 * v12;
		          }
		          if ( !v3->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v3);
		            v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		          if ( !v3 )
		LABEL_32:
		            sub_1800D8260(v3, wrapperArray);
		          if ( LODWORD(v3->_0.namespaze) > 0x404 )
		          {
		            if ( !v3[21].vtable.ToString.methodPtr )
		              goto LABEL_24;
		            v20 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		            if ( v20 )
		            {
		              v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                      (ILFixDynamicMethodWrapper_31 *)v20,
		                      (Object *)this,
		                      0LL);
		              goto LABEL_31;
		            }
		            goto LABEL_32;
		          }
		LABEL_71:
		          sub_1800D2AB0(v3, wrapperArray);
		        }
		        v14 = mapSize / sectorSize;
		LABEL_34:
		        v8 = v14;
		        goto LABEL_16;
		      }
		      sectorSize = 128;
		    }
		    v7 = sectorSize == 128;
		    goto LABEL_14;
		  }
		  v15 = IFix::WrappersManagerImpl::GetPatch(2321, 0LL);
		  if ( !v15 )
		    goto LABEL_32;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v15, (Object *)this, 0LL);
		}
		
		public int halfMapSize { get => default; } // 0x000000018334D080-0x000000018334D0E0 
		// Int32 get_halfMapSize()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_halfMapSize(
		        HGWaterGlobalConfigData *this,
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
		  if ( wrapperArray->max_length.size <= 1022 )
		    return this->fields.mapSize / 2;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3FE )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[21].vtable.Equals.methodPtr )
		    return this->fields.mapSize / 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1022, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int sectorCoordsMin { get => default; } // 0x000000018334CF70-0x000000018334D080 
		// Int32 get_sectorCoordsMin()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t v5; // eax
		  int32_t v6; // edi
		  int32_t sectorSize; // ecx
		  bool v8; // zf
		  int v9; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 1027 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_20;
		    if ( wrapperArray->max_length.size <= 0x403u )
		      goto LABEL_43;
		    if ( wrapperArray[28].vector[19] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1027, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		      goto LABEL_20;
		    }
		  }
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 1022 )
		    goto LABEL_9;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 0x3FEu )
		    goto LABEL_43;
		  if ( wrapperArray[28].vector[14] )
		  {
		    v12 = IFix::WrappersManagerImpl::GetPatch(1022, 0LL);
		    if ( !v12 )
		      goto LABEL_20;
		    v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v12, (Object *)this, 0LL);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_9:
		    v5 = this->fields.mapSize / 2;
		  }
		  v6 = v5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 1028 )
		    goto LABEL_14;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_20:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x404 )
		LABEL_43:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[21].vtable.ToString.methodPtr )
		  {
		    v13 = IFix::WrappersManagerImpl::GetPatch(1028, 0LL);
		    if ( v13 )
		    {
		      sectorSize = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                     (ILFixDynamicMethodWrapper_31 *)v13,
		                     (Object *)this,
		                     0LL);
		      goto LABEL_19;
		    }
		    goto LABEL_20;
		  }
		LABEL_14:
		  sectorSize = this->fields.sectorSize;
		  v8 = sectorSize == 128;
		  if ( sectorSize < 128 )
		  {
		    sectorSize = 128;
		LABEL_19:
		    v8 = sectorSize == 128;
		  }
		  if ( v8 )
		    v9 = v6 / 128;
		  else
		    v9 = v6 / sectorSize;
		  return -v9;
		}
		
		public int sectorCoordsMax { get => default; } // 0x000000018334DC60-0x000000018334DCA0 
		// Int32 get_sectorCoordsMax()
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1024, 0LL) )
		    return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_halfMapSize(this, 0LL) / this->fields.sectorSize - 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1024, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public Vector2 sceneCenterOffsetSector { get => default; } // 0x0000000189C63164-0x0000000189C631EC 
		// Vector2 get_sceneCenterOffsetSector()
		Vector2 HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sceneCenterOffsetSector(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  __m128 x_low; // xmm1
		  __m128 y_low; // xmm2
		  float sectorSize; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5338, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5338, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_375(Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.sectorSize > 0 )
		  {
		    x_low = (__m128)LODWORD(this->fields.sceneCenterOffset.x);
		    y_low = (__m128)LODWORD(this->fields.sceneCenterOffset.y);
		    sectorSize = (float)this->fields.sectorSize;
		    x_low.m128_f32[0] = x_low.m128_f32[0] / sectorSize;
		    y_low.m128_f32[0] = y_low.m128_f32[0] / sectorSize;
		    return (Vector2)_mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		  }
		  else
		  {
		    return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  }
		}
		
	
		// Constructors
		public HGWaterGlobalConfigData() {} // 0x0000000184D31670-0x0000000184D316F0
		// HGWaterGlobalConfigData()
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::HGWaterGlobalConfigData(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v2; // r8
		  __int64 v3; // r9
		  MethodInfo *v4; // [rsp+20h] [rbp-8h]
		
		  this->fields.scenePath = (String *)"";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.scenePath,
		    (HGRuntimeGrassQuery_Node *)method,
		    v2,
		    (Int32__Array **)this,
		    v4);
		  *(_BYTE *)(v3 + 40) = 1;
		  *(_QWORD *)(v3 + 32) = 0LL;
		  *(_DWORD *)(v3 + 72) = 2048;
		  *(_DWORD *)(v3 + 76) = 128;
		  *(_DWORD *)(v3 + 80) = 1056964608;
		  *(_DWORD *)(v3 + 84) = 4;
		  *(_DWORD *)(v3 + 88) = 16;
		  *(_DWORD *)(v3 + 92) = 2;
		  *(_DWORD *)(v3 + 96) = 128;
		  *(_DWORD *)(v3 + 100) = 64;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)v3, 0LL);
		}
		
		static HGWaterGlobalConfigData() {} // 0x000000018402B3A0-0x000000018402B570
		// HGWaterGlobalConfigData()
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::cctor(MethodInfo *method)
		{
		  ValueDropdownList_1_System_Int32_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ValueDropdownList_1_System_Int32_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ValueDropdownList_1_System_Int32_ *v8; // rax
		  ValueDropdownList_1_System_Int32_ *v9; // rbx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  ValueDropdownList_1_System_Single_ *v13; // rax
		  ValueDropdownList_1_System_Single_ *v14; // rbx
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+50h] [rbp+28h]
		
		  v1 = (ValueDropdownList_1_System_Int32_ *)sub_1800368D0(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<int>);
		  v4 = v1;
		  if ( !v1 )
		    goto LABEL_2;
		  Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList(
		    v1,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    1024,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    2048,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    4096,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    0x2000,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields->mapSizeList = (IEnumerable *)v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields,
		    v5,
		    v6,
		    v7,
		    v18);
		  v8 = (ValueDropdownList_1_System_Int32_ *)sub_1800368D0(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<int>);
		  v9 = v8;
		  if ( !v8 )
		    goto LABEL_2;
		  Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList(
		    v8,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v9,
		    128,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v9,
		    256,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v9,
		    512,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields->sectorSizeList = (IEnumerable *)v9;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields->sectorSizeList,
		    v10,
		    v11,
		    v12,
		    v19);
		  v13 = (ValueDropdownList_1_System_Single_ *)sub_1800368D0(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<float>);
		  v14 = v13;
		  if ( !v13 )
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  Sirenix::OdinInspector::ValueDropdownList<float>::ValueDropdownList(
		    v13,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v14,
		    0.5,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v14,
		    0.25,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v14,
		    0.125,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields->flowmapPrecisionList = (IEnumerable *)v14;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGWaterGlobalConfigData->static_fields->flowmapPrecisionList,
		    v15,
		    v16,
		    v17,
		    v20);
		}
		
	
		// Methods
		public void InitDefaultSectorData() {} // 0x0000000189C63120-0x0000000189C63164
		// Void InitDefaultSectorData()
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::InitDefaultSectorData(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5349, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5349, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void OnEnable() {} // 0x0000000184D39760-0x0000000184D397A0
		// Void OnEnable()
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::OnEnable(HGWaterGlobalConfigData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5350, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5350, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateConfig(this, 0, 0LL);
		  }
		}
		
		public void UpdateConfig(bool forceUpdate = false /* Metadata: 0x02304495 */) {} // 0x0000000184D397A0-0x0000000184D397D0
		// Void UpdateConfig(Boolean)
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateConfig(
		        HGWaterGlobalConfigData *this,
		        bool forceUpdate,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5351, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5351, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      forceUpdate,
		      0LL);
		  }
		}
		
		public ValueTuple<int, int> GetSectorCoords(Vector3 pos) => default; // 0x000000018334D880-0x000000018334D940
		// ValueTuple`2[Int32,Int32] GetSectorCoords(Vector3)
		ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorCoords(
		        HGWaterGlobalConfigData *this,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  char v7; // dl
		  __int64 v8; // rcx
		  int v9; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  ValueTuple_2_Int32_Int32_ v14; // [rsp+68h] [rbp+20h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1025 )
		  {
		LABEL_5:
		    pos->x = pos->x - this->fields.sceneCenterOffset.x;
		    v14.Item1 = sub_1834464B0(v5, (_BYTE)pos, (_DWORD)wrapperArray);
		    v14.Item2 = sub_1834464B0(v8, v7, v9);
		    return v14;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x401 )
		    sub_1800D2AB0(v5, pos);
		  if ( !v5[21].vtable.Finalize.method )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1025, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, pos);
		  v12 = *(_QWORD *)&pos->x;
		  v13.z = pos->z;
		  *(_QWORD *)&v13.x = v12;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_390(Patch, (Object *)this, &v13, 0LL);
		}
		
		public int GetSectorIndex(int coordX, int coordZ) => default; // 0x0000000189C6303C-0x0000000189C63120
		// Int32 GetSectorIndex(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorIndex(
		        HGWaterGlobalConfigData *this,
		        int32_t coordX,
		        int32_t coordZ,
		        MethodInfo *method)
		{
		  int32_t sectorCoordsMin; // edi
		  int32_t v8; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3472, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3472, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		             (ILFixDynamicMethodWrapper_14 *)Patch,
		             (Object *)this,
		             (SocketOptionLevel__Enum)coordX,
		             (SocketOptionName__Enum)coordZ,
		             0LL);
		  }
		  else if ( coordX < HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL)
		         || coordX > HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(this, 0LL)
		         || coordZ < HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL)
		         || coordZ > HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(this, 0LL) )
		  {
		    return -1;
		  }
		  else
		  {
		    sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL);
		    v8 = HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL);
		    return coordZ
		         + (coordX - v8) * HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorZNum(this, 0LL)
		         - sectorCoordsMin;
		  }
		}
		
		public void UpdateHGWaterConfigs() {} // 0x0000000183C53ED0-0x0000000183C53FD0
		// Void UpdateHGWaterConfigs()
		void HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateHGWaterConfigs(
		        HGWaterGlobalConfigData *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGWaterConfig *v4; // rcx
		  unsigned int i; // ebx
		  HGWaterConfig__Array *hgWaterConfigs; // rax
		  __int64 v7; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5346, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5346, 0LL);
		    if ( !Patch )
		      goto LABEL_21;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.hgWaterConfigs )
		  {
		    for ( i = 0; ; ++i )
		    {
		      hgWaterConfigs = this->fields.hgWaterConfigs;
		      if ( !hgWaterConfigs )
		        break;
		      if ( (signed int)i >= hgWaterConfigs->max_length.size )
		        return;
		      v4 = (HGWaterConfig *)this->fields.hgWaterConfigs;
		      if ( i >= hgWaterConfigs->max_length.size )
		        goto LABEL_22;
		      v7 = *((_QWORD *)&v4->fields.flowDirection + (int)i);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = (HGWaterConfig *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( v7 )
		      {
		        v4 = (HGWaterConfig *)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( *(_QWORD *)(v7 + 16) )
		        {
		          v4 = (HGWaterConfig *)this->fields.hgWaterConfigs;
		          if ( !v4 )
		            break;
		          if ( i >= *(_DWORD *)&v4->fields.isGamePlayConfig )
		LABEL_22:
		            sub_1800D2AB0(v4, v3);
		          v4 = (HGWaterConfig *)*((_QWORD *)&v4->fields.flowDirection + (int)i);
		          if ( !v4 )
		            break;
		          HG::Rendering::Runtime::HGWaterConfig::UpdateConfig(v4, 0LL);
		        }
		      }
		    }
		LABEL_21:
		    sub_1800D8260(v4, v3);
		  }
		}
		
	}
}
