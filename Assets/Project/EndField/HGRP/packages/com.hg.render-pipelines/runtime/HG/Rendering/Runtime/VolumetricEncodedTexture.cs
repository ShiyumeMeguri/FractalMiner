using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond.Resource;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VolumetricEncodedTexture // TypeDefIndex: 38754
	{
		// Fields
		public Texture Tex; // 0x10
		public Vector4 RangeBase; // 0x18
		public Vector4 RangeScale; // 0x28
		private long _assetHash; // 0x38
		private FAssetProxyHandle _assetHandle; // 0x40
		private static Dictionary<string, PropertyIDPack> s_EncodedTexIDPackDict; // 0x00
	
		// Properties
		public long AssetHash { get => default; set {} } // 0x0000000189C53350-0x0000000189C533A0 0x000000018412BCE0-0x000000018412BD20
		// Int64 get_AssetHash()
		int64_t HG::Rendering::Runtime::VolumetricEncodedTexture::get_AssetHash(
		        VolumetricEncodedTexture *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5235, 0LL) )
		    return this->fields._assetHash;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5235, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return (int64_t)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739(
		                    (ILFixDynamicMethodWrapper_3 *)Patch,
		                    (Object *)this,
		                    0LL);
		}
		

		// Void set_AssetHash(Int64)
		void HG::Rendering::Runtime::VolumetricEncodedTexture::set_AssetHash(
		        VolumetricEncodedTexture *this,
		        int64_t value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5236, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_6(
		      (ILFixDynamicMethodWrapper_16 *)Patch,
		      (Object *)this,
		      (void *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._assetHash = value;
		  }
		}
		
		public bool IsValid { get => default; } // 0x0000000183C528E0-0x0000000183C52980 
		// Boolean get_IsValid()
		bool HG::Rendering::Runtime::VolumetricEncodedTexture::get_IsValid(VolumetricEncodedTexture *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Texture *Tex; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5004, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5004, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::UnityEngine::Object;
		    Tex = this->fields.Tex;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( Tex )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v3);
		      if ( Tex->fields._.m_CachedPtr )
		        return 1;
		    }
		    return !this->fields._assetHash;
		  }
		}
		
	
		// Nested types
		public struct PropertyIDPack // TypeDefIndex: 38753
		{
			// Fields
			public int _Tex; // 0x00
			public int _RangeBase; // 0x04
			public int _RangeScale; // 0x08
		}
	
		// Constructors
		public VolumetricEncodedTexture() {} // 0x000000018412DC00-0x000000018412DC30
		// VolumetricEncodedTexture()
		void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
		        VolumetricEncodedTexture *this,
		        MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v5; // rdx
		  Vector4 *one; // rax
		  __int64 v7; // rdx
		  Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                             (TileAnimationData *)&v8,
		                             (TileBase *)this,
		                             v2,
		                             v3,
		                             *(MethodInfo **)&v8.x);
		  *(TileAnimationData *)(v5 + 24) = *TileAnimationDataNoRef;
		  one = UnityEngine::Vector4::get_one(&v8, (MethodInfo *)v5);
		  *(Vector4 *)(v7 + 40) = *one;
		}
		
		public VolumetricEncodedTexture(Texture tex) {} // 0x0000000189C532BC-0x0000000189C532F8
		// VolumetricEncodedTexture(Texture)
		void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
		        VolumetricEncodedTexture *this,
		        Texture *tex,
		        MethodInfo *method)
		{
		  ITilemap *v3; // r9
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v5; // r8
		  MethodInfo *v6; // rdx
		  Vector4 v7; // xmm1
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  __int64 v9; // r8
		  Int32__Array **v10; // r9
		  Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v12; // [rsp+60h] [rbp+28h]
		
		  TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                             (TileAnimationData *)&v11,
		                             (TileBase *)tex,
		                             (Vector3Int *)this,
		                             v3,
		                             *(MethodInfo **)&v11.x);
		  *(TileAnimationData *)(v5 + 24) = *TileAnimationDataNoRef;
		  v7 = *UnityEngine::Vector4::get_one(&v11, v6);
		  *(_QWORD *)(v9 + 16) = v8;
		  *(Vector4 *)(v9 + 40) = v7;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v9 + 16), v8, (HGRuntimeGrassQuery_Node *)v9, v10, v12);
		}
		
		public VolumetricEncodedTexture(Texture tex, Vector4 rangeBase, Vector4 rangeScale) {} // 0x0000000189C532F8-0x0000000189C53350
		// VolumetricEncodedTexture(Texture, Vector4, Vector4)
		void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
		        VolumetricEncodedTexture *this,
		        Texture *tex,
		        Vector4 *rangeBase,
		        Vector4 *rangeScale,
		        MethodInfo *method)
		{
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v6; // r11
		  MethodInfo *v7; // rdx
		  __m128i v8; // xmm1
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  __int64 v10; // r11
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  _OWORD *v13; // r10
		  __int128 *v14; // r9
		  __int128 v15; // xmm1
		  __int64 v16; // r11
		  Vector4 v17; // [rsp+20h] [rbp-18h] BYREF
		
		  TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                             (TileAnimationData *)&v17,
		                             (TileBase *)tex,
		                             (Vector3Int *)rangeBase,
		                             (ITilemap *)rangeScale,
		                             *(MethodInfo **)&v17.x);
		  *(__m128i *)(v6 + 24) = _mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
		  v8 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v17, v7));
		  *(_QWORD *)(v10 + 16) = v9;
		  *(__m128i *)(v10 + 40) = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v10 + 16), v9, v11, v12, *(MethodInfo **)&v17.x);
		  v15 = *v14;
		  *(_OWORD *)(v16 + 24) = *v13;
		  *(_OWORD *)(v16 + 40) = v15;
		}
		
		static VolumetricEncodedTexture() {} // 0x0000000184D55FF0-0x0000000184D56050
		// VolumetricEncodedTexture()
		void HG::Rendering::Runtime::VolumetricEncodedTexture::cctor(MethodInfo *method)
		{
		  Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Dictionary_2_System_String_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  v1 = (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>);
		  v4 = (Dictionary_2_System_String_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Dictionary(
		    v1,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Dictionary);
		  TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture->static_fields->s_EncodedTexIDPackDict = v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture->static_fields,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
	
		// Methods
		public void LoadAsset() {} // 0x0000000189C5313C-0x0000000189C53230
		// Void LoadAsset()
		void HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAsset(VolumetricEncodedTexture *this, MethodInfo *method)
		{
		  Object_1 *Tex; // rbx
		  int64_t assetHash; // rbx
		  int32_t m_mainVersion; // eax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-38h]
		  FAssetProxyHandle v13; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5067, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5067, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Tex = (Object_1 *)this->fields.Tex;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(Tex, 0LL, 0LL)
		      && this->fields._assetHash
		      && !Beyond::Resource::FAssetProxyHandle::IsValid(&this->fields._assetHandle, 0LL) )
		    {
		      assetHash = this->fields._assetHash;
		      sub_1800036A0(TypeInfo::Beyond::Resource::ResourceManager);
		      Beyond::Resource::ResourceManager::Load<System::Object>(
		        &v13,
		        (StringPathHash)assetHash,
		        RootCategory__Enum_Main,
		        EResourceRequestPriority__Enum_Default,
		        MethodInfo::Beyond::Resource::ResourceManager::Load<UnityEngine::Texture3D>);
		      m_mainVersion = v13.m_untrackedHandle.m_mainVersion;
		      *(_OWORD *)&this->fields._assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v13.m_untrackedHandle.m_handleObjectID;
		      this->fields._assetHandle.m_untrackedHandle.m_mainVersion = m_mainVersion;
		      this->fields.Tex = (Texture *)Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
		                                      &this->fields._assetHandle,
		                                      MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture3D>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v12);
		    }
		  }
		}
		
		public void LoadAssetAsync() {} // 0x0000000189C53074-0x0000000189C5313C
		// Void LoadAssetAsync()
		void HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAssetAsync(
		        VolumetricEncodedTexture *this,
		        MethodInfo *method)
		{
		  Object_1 *Tex; // rbx
		  int64_t assetHash; // rbx
		  int32_t m_mainVersion; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  FAssetProxyHandle v9; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5030, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5030, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Tex = (Object_1 *)this->fields.Tex;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(Tex, 0LL, 0LL)
		      && this->fields._assetHash
		      && !Beyond::Resource::FAssetProxyHandle::IsValid(&this->fields._assetHandle, 0LL) )
		    {
		      assetHash = this->fields._assetHash;
		      sub_1800036A0(TypeInfo::Beyond::Resource::ResourceManager);
		      Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
		        &v9,
		        (StringPathHash)assetHash,
		        RootCategory__Enum_Main,
		        EResourceRequestPriority__Enum_Default,
		        MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture3D>);
		      m_mainVersion = v9.m_untrackedHandle.m_mainVersion;
		      *(_OWORD *)&this->fields._assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v9.m_untrackedHandle.m_handleObjectID;
		      this->fields._assetHandle.m_untrackedHandle.m_mainVersion = m_mainVersion;
		    }
		  }
		}
		
		public bool UpdateAssetLoading() => default; // 0x0000000189C53230-0x0000000189C532BC
		// Boolean UpdateAssetLoading()
		bool HG::Rendering::Runtime::VolumetricEncodedTexture::UpdateAssetLoading(
		        VolumetricEncodedTexture *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5032, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5032, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this->fields._assetHandle, 0LL)
		         && Beyond::Resource::FAssetProxyHandle::get_isDone(&this->fields._assetHandle, 0LL) )
		  {
		    this->fields.Tex = (Texture *)Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
		                                    &this->fields._assetHandle,
		                                    MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture3D>);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v10);
		    return 1;
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public void UnloadAsset() {} // 0x00000001833976B0-0x0000000183398250
		// Void UnloadAsset()
		void HG::Rendering::Runtime::VolumetricEncodedTexture::UnloadAsset(VolumetricEncodedTexture *this, MethodInfo *method)
		{
		  VolumetricEncodedTexture *v2; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  unsigned __int64 v9; // rdx
		  FAssetProxyUntrackedHandle *p_m_untrackedHandle; // r12
		  ILFixDynamicMethodWrapper_3__Array *v11; // rcx
		  ILFixDynamicMethodWrapper_3__Array *v12; // r8
		  ILFixDynamicMethodWrapper_3 *v13; // rax
		  bool v14; // al
		  ILFixDynamicMethodWrapper_3__Array *v15; // r8
		  ILFixDynamicMethodWrapper_3 *v16; // rax
		  char v17; // al
		  ILFixDynamicMethodWrapper_3__Array *v18; // r8
		  ILFixDynamicMethodWrapper_3 *v19; // rax
		  bool v20; // al
		  ILFixDynamicMethodWrapper_3__Array *v21; // r8
		  int32_t v22; // ecx
		  ILFixDynamicMethodWrapper_3__Array *v23; // r8
		  ILFixDynamicMethodWrapper_3 *v24; // rax
		  Object *value; // rax
		  unsigned int m_handleID; // r15d
		  ConcurrentDictionary_2_System_Int32_System_Object_ *s_handleToObject; // r13
		  struct ILFixDynamicMethodWrapper__Class *v28; // rcx
		  ILFixDynamicMethodWrapper_3 *v29; // rax
		  struct MethodInfo *v30; // r14
		  Object *comparer; // rbx
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  Il2CppRGCTXData v33; // rsi
		  Il2CppRGCTXData v34; // rax
		  Object__Class *klass; // rbp
		  __int64 v36; // rdx
		  unsigned __int16 v37; // cx
		  int v38; // edi
		  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
		  __int64 v40; // rax
		  __int64 v41; // rcx
		  int32_t (*v42)(Array *, int32_t, MethodInfo *); // r9
		  __int64 v43; // rbp
		  _QWORD *v44; // rcx
		  __int64 v45; // rbx
		  _QWORD *v46; // rax
		  int32_t v47; // esi
		  ILFixDynamicMethodWrapper *v48; // rax
		  EntityVFXRendererMask__Enum v49; // eax
		  bool v50; // zf
		  unsigned int *p_monitor; // rsi
		  unsigned int v52; // esi
		  __int64 v53; // rax
		  ArgumentOutOfRangeException *v54; // rbx
		  ConcurrentDictionary_2_TKey_TValue_Tables_System_Int32_System_Object_ *tables; // rbx
		  size_t cctor_thread; // r14
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object___Array *buckets; // rdi
		  const char *name; // rax
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object___Array *v59; // rbx
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object_ *next; // rbx
		  IEqualityComparer_1_System_Int32_ *v61; // rdi
		  unsigned int key; // ebp
		  __int64 v63; // rcx
		  __int64 v64; // rax
		  __int64 *v65; // rdx
		  __int64 v66; // rtt
		  Object *Target; // rax
		  struct IAssetProxy__Class *v68; // rdi
		  Object *v69; // rbx
		  Object__Class *v70; // rsi
		  IAssetProxy *assetProxy; // rax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  int32_t v74; // eax
		  FAssetObjectID v75; // ebx
		  FAssetObjectID v76; // edi
		  IAssetProxy *v77; // rax
		  HGRuntimeGrassQuery_Node *v78; // rdx
		  HGRuntimeGrassQuery_Node *v79; // r8
		  Int32__Array **v80; // r9
		  __int64 v81; // rax
		  __int64 v82; // rax
		  String *v83; // rax
		  signed __int32 v84[8]; // [rsp+0h] [rbp-78h] BYREF
		  MethodInfo *v85; // [rsp+20h] [rbp-58h]
		  _QWORD v86[2]; // [rsp+30h] [rbp-48h] BYREF
		  FObjectHandle P0; // [rsp+90h] [rbp+18h] BYREF
		  Object *v89; // [rsp+98h] [rbp+20h] BYREF
		
		  v2 = this;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size > 5035 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = v3->static_fields->wrapperArray;
		    if ( !v5 )
		      sub_1800D8260(v3, method);
		    if ( v5->max_length.size <= 0x13ABu )
		      sub_1800D2AB0(v3, method);
		    if ( v5[139].vector[31] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5035, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		      return;
		    }
		  }
		  v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  p_m_untrackedHandle = &v2->fields._assetHandle.m_untrackedHandle;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v11 )
		    goto LABEL_186;
		  if ( v11->max_length.size > 579 )
		  {
		    if ( !*(_DWORD *)(v9 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v12 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		    if ( !v12 )
		      goto LABEL_186;
		    if ( v12->max_length.size <= 0x243u )
		      goto LABEL_191;
		    if ( v12[16].vector[3] )
		    {
		      v13 = IFix::WrappersManagerImpl::GetPatch(579, 0LL);
		      if ( v13 )
		      {
		        v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_194(v13, &v2->fields._assetHandle, 0LL);
		        goto LABEL_183;
		      }
		LABEL_186:
		      sub_1800D8260(v11, v9);
		    }
		  }
		  if ( !byte_18F35F78C )
		  {
		    sub_180035ED0(&TypeInfo::Beyond::Resource::FAssetObjectID);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    byte_18F35F78C = 1;
		  }
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v11 )
		    goto LABEL_186;
		  if ( v11->max_length.size > 592 )
		  {
		    if ( !*(_DWORD *)(v9 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v15 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		    if ( !v15 )
		      goto LABEL_186;
		    if ( v15->max_length.size <= 0x250u )
		      goto LABEL_191;
		    if ( v15[16].vector[16] )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(592, 0LL);
		      if ( !v16 )
		        goto LABEL_186;
		      v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_198(v16, &v2->fields._assetHandle.m_untrackedHandle, 0LL);
		      goto LABEL_165;
		    }
		  }
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v11 )
		    goto LABEL_186;
		  if ( v11->max_length.size <= 583 )
		    goto LABEL_47;
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v18 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v18 )
		    goto LABEL_186;
		  if ( v18->max_length.size <= 0x247u )
		    goto LABEL_191;
		  if ( v18[16].vector[7] )
		  {
		    v19 = IFix::WrappersManagerImpl::GetPatch(583, 0LL);
		    if ( !v19 )
		      goto LABEL_186;
		    v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(
		            v19,
		            &v2->fields._assetHandle.m_untrackedHandle.m_assetProxyObj,
		            0LL);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_47:
		    v20 = v2->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID != 0;
		  }
		  if ( !v20 )
		    goto LABEL_181;
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v11 )
		    goto LABEL_186;
		  if ( v11->max_length.size > 584 )
		  {
		    if ( !*(_DWORD *)(v9 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v21 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		    if ( !v21 )
		      goto LABEL_186;
		    if ( v21->max_length.size <= 0x248u )
		      goto LABEL_191;
		    if ( v21[16].vector[8] )
		    {
		      v22 = 584;
		LABEL_69:
		      v24 = IFix::WrappersManagerImpl::GetPatch(v22, 0LL);
		      if ( !v24 )
		        goto LABEL_186;
		      value = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_196(
		                v24,
		                &v2->fields._assetHandle.m_untrackedHandle.m_assetProxyObj,
		                0LL);
		      goto LABEL_153;
		    }
		  }
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v11 )
		    goto LABEL_186;
		  if ( v11->max_length.size <= 585 )
		    goto LABEL_71;
		  if ( !*(_DWORD *)(v9 + 224) )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v23 = **(ILFixDynamicMethodWrapper_3__Array ***)(v9 + 184);
		  if ( !v23 )
		    goto LABEL_186;
		  if ( v23->max_length.size <= 0x249u )
		LABEL_191:
		    sub_1800D2AB0(v11, v9);
		  if ( v23[16].vector[9] )
		  {
		    v22 = 585;
		    goto LABEL_69;
		  }
		LABEL_71:
		  if ( v2->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID )
		  {
		    m_handleID = v2->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID;
		    if ( !TypeInfo::Beyond::Resource::ObjectHandle->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::ObjectHandle);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    P0.m_handleID = m_handleID;
		    if ( !byte_18F363FD9 )
		    {
		      sub_180035ED0(&MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue);
		      sub_180035ED0(&TypeInfo::Beyond::Resource::ObjectHandle);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      byte_18F363FD9 = 1;
		    }
		    v89 = 0LL;
		    if ( !TypeInfo::Beyond::Resource::ObjectHandle->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::ObjectHandle);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    s_handleToObject = TypeInfo::Beyond::Resource::ObjectHandle->static_fields->s_handleToObject;
		    if ( !*(_DWORD *)(v9 + 224) )
		    {
		      il2cpp_runtime_class_init_1(v9);
		      v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v28 = **(struct ILFixDynamicMethodWrapper__Class ***)(v9 + 184);
		    if ( !v28 )
		      goto LABEL_196;
		    if ( SLODWORD(v28->_0.namespaze) > 2273 )
		    {
		      if ( !*(_DWORD *)(v9 + 224) )
		      {
		        il2cpp_runtime_class_init_1(v9);
		        v9 = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v9 = **(_QWORD **)(v9 + 184);
		      if ( !v9 )
		        goto LABEL_196;
		      if ( *(_DWORD *)(v9 + 24) <= 0x8E1u )
		        goto LABEL_195;
		      if ( *(_QWORD *)(v9 + 18216) )
		      {
		        v29 = IFix::WrappersManagerImpl::GetPatch(2273, 0LL);
		        if ( !v29 )
		          goto LABEL_196;
		        m_handleID = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_853(v29, &P0, 0LL);
		      }
		    }
		    if ( !s_handleToObject )
		      goto LABEL_196;
		    v30 = MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue;
		    comparer = (Object *)s_handleToObject->fields._comparer;
		    if ( !comparer )
		      goto LABEL_196;
		    rgctx_data = MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue->klass->rgctx_data;
		    v33.rgctxDataDummy = rgctx_data[12].rgctxDataDummy;
		    if ( (*((_BYTE *)v33.rgctxDataDummy + 312) & 1) == 0 )
		    {
		      sub_1800360B0((const Il2CppRGCTXData)rgctx_data[12].rgctxDataDummy, v9);
		      v33.rgctxDataDummy = v34.rgctxDataDummy;
		    }
		    klass = comparer->klass;
		    sub_1800049A0(comparer->klass);
		    v36 = *(unsigned __int16 *)&klass->_1.naturalAligment;
		    v37 = 0;
		    v38 = 1;
		    if ( (_WORD)v36 )
		    {
		      interfaceOffsets = klass->interfaceOffsets;
		      while ( interfaceOffsets[v37].interfaceType != v33.rgctxDataDummy )
		      {
		        if ( ++v37 >= (unsigned __int16)v36 )
		          goto LABEL_97;
		      }
		      v41 = v37;
		      v40 = (__int64)(&klass->vtable.Finalize.method + 2 * interfaceOffsets[v41].offset);
		    }
		    else
		    {
		LABEL_97:
		      v40 = ((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_1800219C0)(
		              comparer,
		              (Il2CppRGCTXData)v33.rgctxDataDummy,
		              1LL);
		    }
		    v42 = *(int32_t (**)(Array *, int32_t, MethodInfo *))v40;
		    v43 = *(_QWORD *)(v40 + 8);
		    if ( *(int32_t (**)(EnumEqualityComparer_1_System_Int32Enum_ *, Int32Enum__Enum, MethodInfo *))v40 == System::Collections::Generic::EnumEqualityComparer<System::Int32Enum>::GetHashCode )
		    {
		      v44 = *(_QWORD **)(*(_QWORD *)(v43 + 32) + 192LL);
		      v45 = *v44;
		      if ( !*(_QWORD *)(*v44 + 56LL) )
		        sub_1800430B0(*v44);
		      v46 = *(_QWORD **)(v45 + 56);
		      if ( !*(_QWORD *)(*v46 + 56LL) )
		        sub_1800430B0(*v46);
		LABEL_103:
		      v47 = m_handleID;
		      goto LABEL_130;
		    }
		    if ( (char *)v42 == (char *)Beyond::Gameplay::View::MountPointEqualityComparer::GetHashCode )
		    {
		      v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v9 = (unsigned __int64)v28->static_fields->wrapperArray;
		      if ( !v9 )
		        goto LABEL_196;
		      if ( *(int *)(v9 + 24) <= 42671 )
		        goto LABEL_103;
		      if ( !v28->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v28);
		        v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v9 = (unsigned __int64)v28->static_fields->wrapperArray;
		      if ( !v9 )
		        goto LABEL_196;
		      if ( *(_DWORD *)(v9 + 24) <= 0xA6AFu )
		        goto LABEL_195;
		      if ( !*(_QWORD *)(v9 + 341400) )
		        goto LABEL_103;
		      v48 = IFix::WrappersManagerImpl::GetPatch(42671, 0LL);
		      if ( !v48 )
		        goto LABEL_196;
		      v49 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_74(
		              (ILFixDynamicMethodWrapper_10 *)v48,
		              comparer,
		              m_handleID,
		              0LL);
		    }
		    else
		    {
		      if ( v42 == System::Array::InternalArray__IReadOnlyList_get_Item<int> )
		      {
		        v50 = comparer->klass == 0LL;
		        P0.m_handleID = 0;
		        if ( v50 )
		        {
		          v86[0] = 0LL;
		          v86[1] = 0LL;
		          v81 = sub_1800D82B0(v86);
		          sub_18007E1B0(v81, 0LL);
		        }
		        if ( !*((_BYTE *)&comparer->klass->_1 + 108) )
		        {
		          v82 = sub_1800D2AD0(v41 * 2, v36);
		          sub_18007E1B0(v82, 0LL);
		        }
		        p_monitor = (unsigned int *)&comparer[1].monitor;
		        if ( comparer[1].klass )
		          p_monitor = (unsigned int *)comparer[1].klass;
		        v52 = *p_monitor;
		        if ( *((_BYTE *)&comparer->klass->_1 + 108) > 1u )
		        {
		          do
		            v52 *= (unsigned int)System::Array::GetLength((System::Array *)comparer, v38++);
		          while ( v38 < *((unsigned __int8 *)&comparer->klass->_1 + 108) );
		        }
		        if ( m_handleID >= v52 )
		        {
		          v53 = sub_180035ED0(&TypeInfo::System::ArgumentOutOfRangeException);
		          v54 = (ArgumentOutOfRangeException *)sub_1800368D0(v53);
		          if ( v54 )
		          {
		            v83 = (String *)sub_180035ED0(&off_18E332C28);
		            System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v54, v83, 0LL);
		            sub_18007E190(v54, v43);
		          }
		          goto LABEL_196;
		        }
		        sub_18033B330(
		          &P0,
		          (char *)&comparer[2] + (int)m_handleID * (unsigned __int64)comparer->klass->_1.element_size,
		          comparer->klass->_1.element_size);
		        v47 = P0.m_handleID;
		        goto LABEL_130;
		      }
		      v49 = ((unsigned int (__fastcall *)(Object *, _QWORD, __int64))v42)(comparer, m_handleID, v43);
		    }
		    v47 = v49;
		LABEL_130:
		    v9 = (unsigned __int64)v30->klass->rgctx_data;
		    if ( !*(_QWORD *)(*(_QWORD *)(v9 + 232) + 32LL) )
		      (*(void (**)(void))v30->klass->rgctx_data[29].rgctxDataDummy)();
		    tables = s_handleToObject->fields._tables;
		    v28 = (struct ILFixDynamicMethodWrapper__Class *)v30->klass->rgctx_data;
		    cctor_thread = v28->_1.cctor_thread;
		    _InterlockedOr(v84, 0);
		    if ( tables )
		    {
		      buckets = tables->fields._buckets;
		      if ( buckets )
		      {
		        v28 = *(struct ILFixDynamicMethodWrapper__Class **)(*(_QWORD *)(cctor_thread + 32) + 192LL);
		        name = v28->_0.name;
		        if ( (name[312] & 1) == 0 )
		          sub_1800360B0(v28->_0.name, v9);
		        if ( !*((_DWORD *)name + 56) )
		          il2cpp_runtime_class_init_1(name);
		        v59 = tables->fields._buckets;
		        if ( v59 )
		        {
		          v9 = (unsigned int)((v47 & 0x7FFFFFFFu) % (__int64)buckets->max_length.size);
		          if ( (unsigned int)v9 < v59->max_length.size )
		          {
		            next = v59->vector[(int)v9];
		            _InterlockedOr(v84, 0);
		            if ( next )
		            {
		              while ( 1 )
		              {
		                if ( v47 == next->fields._hashcode )
		                {
		                  v61 = s_handleToObject->fields._comparer;
		                  key = next->fields._key;
		                  if ( !v61 )
		                    goto LABEL_196;
		                  v63 = *(_QWORD *)(*(_QWORD *)(cctor_thread + 32) + 192LL);
		                  v64 = *(_QWORD *)(v63 + 96);
		                  if ( (*(_BYTE *)(v64 + 312) & 1) == 0 )
		                    sub_1800360B0(*(_QWORD *)(v63 + 96), v9);
		                  if ( (unsigned __int8)sub_1800036E0(0LL, v64, v61, key, m_handleID) )
		                    break;
		                }
		                next = next->fields._next;
		                _InterlockedOr(v84, 0);
		                if ( !next )
		                  goto LABEL_147;
		              }
		              value = next->fields._value;
		              v89 = value;
		              if ( dword_18F35FD08 )
		              {
		                v65 = &qword_18F103690[(((unsigned __int64)&v89 >> 12) & 0x1FFFFF) >> 6];
		                _m_prefetchw(v65);
		                do
		                  v66 = *v65;
		                while ( v66 != _InterlockedCompareExchange64(
		                                 v65,
		                                 *v65 | (1LL << (((unsigned __int64)&v89 >> 12) & 0x3F)),
		                                 *v65) );
		                value = v89;
		              }
		            }
		            else
		            {
		LABEL_147:
		              value = 0LL;
		            }
		            goto LABEL_153;
		          }
		LABEL_195:
		          sub_1800D2AB0(v28, v9);
		        }
		      }
		    }
		LABEL_196:
		    sub_1800D8260(v28, v9);
		  }
		  value = 0LL;
		LABEL_153:
		  if ( !value )
		    goto LABEL_181;
		  Target = Beyond::Resource::FObjectHandle::get_Target(&p_m_untrackedHandle->m_assetProxyObj, 0LL);
		  v68 = TypeInfo::Beyond::Resource::IAssetProxy;
		  v69 = Target;
		  if ( !Target )
		    goto LABEL_181;
		  v70 = Target->klass;
		  if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(TypeInfo::Beyond::Resource::IAssetProxy, Target->klass)
		    && ((BYTE1(v70->vtable.Equals.methodPtr) & 0x10) == 0
		     || ((v68->_1.flags & 0x20) == 0
		      && *((_BYTE *)&v68->_0.byval_arg + 10) != 19
		      && *((_BYTE *)&v68->_0.byval_arg + 10) != 30
		      || !v68->_0.interopData
		      || !v68->_0.interopData->guid
		      || !sub_1802ED414(v69))
		     && v68 != (struct IAssetProxy__Class *)qword_18F35FF70) )
		  {
		    goto LABEL_181;
		  }
		  v17 = sub_182EFB400(v69, p_m_untrackedHandle->m_handleObjectID) ^ 1;
		LABEL_165:
		  if ( v17 )
		    goto LABEL_181;
		  if ( !TypeInfo::Beyond::Resource::FAssetObjectID->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::FAssetObjectID);
		  if ( !Beyond::Resource::FAssetObjectID::IsValid(&p_m_untrackedHandle->m_assetProxyID, 0LL) )
		    goto LABEL_181;
		  assetProxy = Beyond::Resource::FAssetProxyUntrackedHandle::get_assetProxy(p_m_untrackedHandle, 0LL);
		  if ( !assetProxy )
		    goto LABEL_197;
		  if ( *(_DWORD *)&assetProxy->klass->_1.method_count == 3450 )
		  {
		    v75._objectIntID_k__BackingField = (int32_t)assetProxy[10].klass;
		  }
		  else if ( *(_DWORD *)&assetProxy->klass->_1.method_count == 3451 )
		  {
		    v75._objectIntID_k__BackingField = HIDWORD(assetProxy[9].monitor);
		  }
		  else
		  {
		    sub_180207B74(0LL, TypeInfo::Beyond::Resource::IAssetProxy);
		    v75._objectIntID_k__BackingField = v74;
		  }
		  v76._objectIntID_k__BackingField = p_m_untrackedHandle->m_assetProxyID._objectIntID_k__BackingField;
		  if ( !TypeInfo::Beyond::Resource::FAssetObjectID->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::FAssetObjectID);
		  if ( !Beyond::Resource::FAssetObjectID::op_Equality(v75, v76, 0LL) )
		    goto LABEL_181;
		  v77 = Beyond::Resource::FAssetProxyUntrackedHandle::get_assetProxy(p_m_untrackedHandle, 0LL);
		  if ( !v77 )
		LABEL_197:
		    sub_1800D8250(v73, v72);
		  if ( (unsigned __int8)sub_182EFB050(v77) )
		  {
		LABEL_181:
		    v14 = 0;
		    goto LABEL_182;
		  }
		  v14 = 1;
		LABEL_182:
		  v2 = this;
		LABEL_183:
		  if ( v14 )
		  {
		    Beyond::Resource::FAssetProxyHandle::Dispose(&v2->fields._assetHandle, 0LL);
		    *(_OWORD *)&v2->fields._assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
		    v2->fields._assetHandle.m_untrackedHandle.m_mainVersion = 0;
		    v2->fields.Tex = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v2->fields, v78, v79, v80, v85);
		  }
		}
		
		public static PropertyIDPack GetEncodedTexIDPack(string name) => default; // 0x0000000189C52EFC-0x0000000189C53074
		// VolumetricEncodedTexture+PropertyIDPack GetEncodedTexIDPack(String)
		VolumetricEncodedTexture_PropertyIDPack *HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
		        VolumetricEncodedTexture_PropertyIDPack *__return_ptr retstr,
		        String *name,
		        MethodInfo *method)
		{
		  VolumetricEncodedTexture__StaticFields *static_fields; // rdx
		  Dictionary_2_System_String_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *s_EncodedTexIDPackDict; // rcx
		  String *v7; // rax
		  String *v8; // rax
		  int32_t RangeScale; // esi
		  __int64 v10; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  VolumetricEncodedTexture_PropertyIDPack *v12; // rax
		  __int64 v13; // xmm0_8
		  VolumetricEncodedTexture_PropertyIDPack value; // [rsp+20h] [rbp-10h] BYREF
		  __int64 v16; // [rsp+40h] [rbp+10h]
		
		  *(_QWORD *)&value._Tex = 0LL;
		  value._RangeScale = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5114, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5114, 0LL);
		    if ( Patch )
		    {
		      v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1490(&value, Patch, (Object *)name, 0LL);
		      v13 = *(_QWORD *)&v12->_Tex;
		      LODWORD(v12) = v12->_RangeScale;
		      *(_QWORD *)&retstr->_Tex = v13;
		      retstr->_RangeScale = (int)v12;
		      return retstr;
		    }
		    goto LABEL_9;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
		  s_EncodedTexIDPackDict = TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture->static_fields->s_EncodedTexIDPackDict;
		  if ( !s_EncodedTexIDPackDict )
		    goto LABEL_9;
		  if ( System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::TryGetValue(
		         (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)s_EncodedTexIDPackDict,
		         (Object *)name,
		         &value,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::TryGetValue) )
		  {
		    RangeScale = value._RangeScale;
		    v10 = *(_QWORD *)&value._Tex;
		    goto LABEL_7;
		  }
		  value._Tex = UnityEngine::Shader::PropertyToID(name, 0LL);
		  v7 = System::String::Concat(name, (String *)"_RemapRangeBase", 0LL);
		  value._RangeBase = UnityEngine::Shader::PropertyToID(v7, 0LL);
		  v8 = System::String::Concat(name, (String *)"_RemapRangeScale", 0LL);
		  RangeScale = UnityEngine::Shader::PropertyToID(v8, 0LL);
		  v16 = *(_QWORD *)&value._Tex;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture->static_fields;
		  s_EncodedTexIDPackDict = static_fields->s_EncodedTexIDPackDict;
		  if ( !static_fields->s_EncodedTexIDPackDict )
		LABEL_9:
		    sub_1800D8260(s_EncodedTexIDPackDict, static_fields);
		  value._RangeScale = RangeScale;
		  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Add(
		    (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)s_EncodedTexIDPackDict,
		    (Object *)name,
		    &value,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Add);
		  v10 = v16;
		LABEL_7:
		  *(_QWORD *)&retstr->_Tex = v10;
		  retstr->_RangeScale = RangeScale;
		  return retstr;
		}
		
	}
}
