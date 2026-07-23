using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricSdfAsset : ScriptableObject // TypeDefIndex: 38755
	{
		// Fields
		public VolumetricEncodedTexture[] SdfTexs; // 0x18
		public Bounds VolumeBounds; // 0x20
		public Vector4 Payload; // 0x38
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000183C52850-0x0000000183C528E0 
		// Boolean get_IsValid()
		bool HG::Rendering::Runtime::VolumetricSdfAsset::get_IsValid(VolumetricSdfAsset *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  VolumetricEncodedTexture *v4; // rcx
		  int32_t i; // edi
		  VolumetricEncodedTexture__Array *SdfTexs; // rax
		  VolumetricEncodedTexture__Array *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5003, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5003, 0LL);
		    if ( !Patch )
		LABEL_11:
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.SdfTexs && this->fields.SdfTexs->max_length.value )
		  {
		    for ( i = 0; ; ++i )
		    {
		      SdfTexs = this->fields.SdfTexs;
		      if ( !SdfTexs )
		        goto LABEL_11;
		      if ( i >= SdfTexs->max_length.size )
		        break;
		      v7 = this->fields.SdfTexs;
		      if ( (unsigned int)i >= SdfTexs->max_length.size )
		        sub_1800D2AB0(v7, v3);
		      v4 = v7->vector[i];
		      if ( v4 && !HG::Rendering::Runtime::VolumetricEncodedTexture::get_IsValid(v4, 0LL) )
		        return 0;
		    }
		    return 1;
		  }
		  else
		  {
		    return 0;
		  }
		}
		
	
		// Constructors
		public VolumetricSdfAsset() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public void LoadAssets() {} // 0x0000000189C621C4-0x0000000189C62244
		// Void LoadAssets()
		void HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssets(VolumetricSdfAsset *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  VolumetricEncodedTexture__Array *SdfTexs; // rdi
		  int32_t i; // ebx
		  VolumetricEncodedTexture *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5066, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5066, 0LL);
		    if ( !Patch )
		LABEL_10:
		      sub_1800D8260(v7, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.SdfTexs )
		  {
		    SdfTexs = this->fields.SdfTexs;
		    for ( i = 0; i < SdfTexs->max_length.size; ++i )
		    {
		      if ( (unsigned int)i >= SdfTexs->max_length.size )
		        sub_1800D2AB0(v4, v3);
		      v7 = SdfTexs->vector[i];
		      if ( !v7 )
		        goto LABEL_10;
		      HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAsset(v7, 0LL);
		    }
		  }
		}
		
		public void LoadAssetsAsync() {} // 0x0000000189C62144-0x0000000189C621C4
		// Void LoadAssetsAsync()
		void HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssetsAsync(VolumetricSdfAsset *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  VolumetricEncodedTexture__Array *SdfTexs; // rdi
		  int32_t i; // ebx
		  VolumetricEncodedTexture *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5029, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5029, 0LL);
		    if ( !Patch )
		LABEL_10:
		      sub_1800D8260(v7, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.SdfTexs )
		  {
		    SdfTexs = this->fields.SdfTexs;
		    for ( i = 0; i < SdfTexs->max_length.size; ++i )
		    {
		      if ( (unsigned int)i >= SdfTexs->max_length.size )
		        sub_1800D2AB0(v4, v3);
		      v7 = SdfTexs->vector[i];
		      if ( !v7 )
		        goto LABEL_10;
		      HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAssetAsync(v7, 0LL);
		    }
		  }
		}
		
		public bool UpdateAssetLoading() => default; // 0x0000000189C62244-0x0000000189C622E4
		// Boolean UpdateAssetLoading()
		bool HG::Rendering::Runtime::VolumetricSdfAsset::UpdateAssetLoading(VolumetricSdfAsset *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  VolumetricEncodedTexture *v4; // rcx
		  int32_t i; // ebx
		  VolumetricEncodedTexture__Array *SdfTexs; // rax
		  VolumetricEncodedTexture__Array *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5031, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5031, 0LL);
		    if ( !Patch )
		LABEL_15:
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.SdfTexs && this->fields.SdfTexs->max_length.value )
		  {
		    for ( i = 0; ; ++i )
		    {
		      SdfTexs = this->fields.SdfTexs;
		      if ( !SdfTexs )
		        goto LABEL_15;
		      if ( i >= SdfTexs->max_length.size )
		        return 1;
		      v7 = this->fields.SdfTexs;
		      if ( (unsigned int)i >= SdfTexs->max_length.size )
		        sub_1800D2AB0(v7, v3);
		      v4 = v7->vector[i];
		      if ( !v4 )
		        goto LABEL_15;
		      if ( !HG::Rendering::Runtime::VolumetricEncodedTexture::UpdateAssetLoading(v4, 0LL) )
		        break;
		    }
		    return 0;
		  }
		  else
		  {
		    return 1;
		  }
		}
		
		public void UnloadAssets() {} // 0x0000000183398250-0x0000000183398EF0
		// Void UnloadAssets()
		void HG::Rendering::Runtime::VolumetricSdfAsset::UnloadAssets(VolumetricSdfAsset *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  unsigned __int64 static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2 *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  VolumetricEncodedTexture__Array *SdfTexs; // rcx
		  unsigned int v11; // edi
		  int32_t v12; // eax
		  VolumetricEncodedTexture *v13; // rbx
		  __int64 *v14; // rcx
		  __int64 v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FAssetProxyUntrackedHandle *p_m_untrackedHandle; // r12
		  __int64 v18; // rax
		  ILFixDynamicMethodWrapper_3 *v19; // rax
		  bool v20; // al
		  __int64 v21; // rax
		  ILFixDynamicMethodWrapper_3 *v22; // rax
		  char v23; // al
		  __int64 v24; // rax
		  ILFixDynamicMethodWrapper_3 *v25; // rax
		  bool v26; // al
		  __int64 v27; // rax
		  int32_t v28; // ecx
		  __int64 v29; // rax
		  ILFixDynamicMethodWrapper_3 *v30; // rax
		  Object *value; // rax
		  unsigned int m_handleID; // r15d
		  ConcurrentDictionary_2_System_Int32_System_Object_ *s_handleToObject; // r13
		  _QWORD *p_image; // rcx
		  __int64 v35; // rax
		  ILFixDynamicMethodWrapper_3 *v36; // rax
		  struct MethodInfo *v37; // r14
		  Object *comparer; // rdi
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  Il2CppRGCTXData v40; // rbx
		  Il2CppRGCTXData v41; // rax
		  Object__Class *v42; // rsi
		  __int64 v43; // rdx
		  unsigned __int16 v44; // cx
		  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
		  __int64 v46; // rax
		  __int64 v47; // rcx
		  int32_t (*v48)(Array *, int32_t, MethodInfo *); // r9
		  __int64 v49; // rbp
		  _QWORD *v50; // rcx
		  __int64 v51; // rbx
		  _QWORD *v52; // rax
		  int32_t v53; // ebp
		  ILFixDynamicMethodWrapper *v54; // rax
		  EntityVFXRendererMask__Enum v55; // eax
		  unsigned int *p_monitor; // rsi
		  unsigned int v57; // esi
		  int v58; // ebx
		  ConcurrentDictionary_2_TKey_TValue_Tables_System_Int32_System_Object_ *tables; // rbx
		  __int64 v60; // r14
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object___Array *buckets; // rdi
		  __int64 v62; // rax
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object___Array *v63; // rbx
		  ConcurrentDictionary_2_TKey_TValue_Node_System_Int32_System_Object_ *next; // rbx
		  IEqualityComparer_1_System_Int32_ *v65; // rdi
		  unsigned int key; // esi
		  __int64 v67; // rcx
		  __int64 v68; // rax
		  Object *Target; // rax
		  struct IAssetProxy__Class *v70; // rbx
		  Object *v71; // rdi
		  Object__Class *klass; // rsi
		  IAssetProxy *assetProxy; // rax
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  int32_t v76; // eax
		  FAssetObjectID v77; // ebx
		  __int64 v78; // rtt
		  FAssetObjectID v79; // edi
		  IAssetProxy *v80; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v81; // rdx
		  VolumetricRenderer_VolumetricBounds *v82; // r8
		  Int32__Array **v83; // r9
		  __int64 v84; // rax
		  ArgumentOutOfRangeException *v85; // rbx
		  String *v86; // rax
		  __int64 v87; // rax
		  __int64 v88; // rax
		  signed __int32 v89[8]; // [rsp+0h] [rbp-88h] BYREF
		  MethodInfo *v90; // [rsp+20h] [rbp-68h]
		  bool v91; // [rsp+28h] [rbp-60h]
		  Object *v92; // [rsp+30h] [rbp-58h] BYREF
		  VolumetricEncodedTexture *v93; // [rsp+38h] [rbp-50h]
		  VolumetricEncodedTexture__Array *v94; // [rsp+40h] [rbp-48h] BYREF
		  __int64 v95; // [rsp+48h] [rbp-40h]
		  _BOOL8 v96; // [rsp+50h] [rbp-38h]
		  _BOOL8 v97; // [rsp+58h] [rbp-30h]
		  MethodInfo *v98; // [rsp+60h] [rbp-28h]
		  FObjectHandle P0; // [rsp+A0h] [rbp+18h] BYREF
		  unsigned int v100; // [rsp+A8h] [rbp+20h]
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    sub_1800D8260(v3, static_fields);
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 5034 )
		    goto LABEL_12;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  wrapperArray = v5->wrapperArray;
		  if ( !v5->wrapperArray )
		    sub_1800D8260(v5, static_fields);
		  if ( wrapperArray->max_length.size <= 0x13AAu )
		    sub_1800D2AB0(v5, static_fields);
		  if ( !wrapperArray[139].vector[30] )
		  {
		LABEL_12:
		    if ( !this->fields.SdfTexs )
		      return;
		    SdfTexs = this->fields.SdfTexs;
		    v11 = 0;
		    v12 = 0;
		    v94 = SdfTexs;
		    while ( 1 )
		    {
		      while ( 1 )
		      {
		        v100 = v11;
		        if ( v12 >= SdfTexs->max_length.size )
		          return;
		        if ( v11 >= SdfTexs->max_length.size )
		          sub_1800D2AB0(SdfTexs, static_fields);
		        v13 = SdfTexs->vector[v11];
		        v93 = v13;
		        if ( !v13 )
		          sub_1800D8260(SdfTexs, static_fields);
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		        if ( !static_fields )
		LABEL_215:
		          sub_1800D8260(v14, static_fields);
		        if ( *(int *)(static_fields + 24) <= 5035 )
		          break;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		        v15 = *v14;
		        if ( !*v14 )
		          goto LABEL_215;
		        if ( *(_DWORD *)(v15 + 24) <= 0x13ABu )
		          goto LABEL_209;
		        if ( !*(_QWORD *)(v15 + 40312) )
		          break;
		        Patch = IFix::WrappersManagerImpl::GetPatch(5035, 0LL);
		        if ( !Patch )
		          goto LABEL_215;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v13, 0LL);
		        SdfTexs = v94;
		        v12 = ++v11;
		      }
		      p_m_untrackedHandle = &v13->fields._assetHandle.m_untrackedHandle;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		      if ( !static_fields )
		        goto LABEL_215;
		      if ( *(int *)(static_fields + 24) <= 579 )
		        break;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      v18 = *v14;
		      if ( !*v14 )
		        goto LABEL_215;
		      if ( *(_DWORD *)(v18 + 24) <= 0x243u )
		        goto LABEL_209;
		      if ( !*(_QWORD *)(v18 + 4664) )
		        break;
		      v19 = IFix::WrappersManagerImpl::GetPatch(579, 0LL);
		      if ( !v19 )
		        goto LABEL_215;
		      v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_194(v19, &v13->fields._assetHandle, 0LL);
		LABEL_197:
		      if ( v20 )
		      {
		        Beyond::Resource::FAssetProxyHandle::Dispose(&v13->fields._assetHandle, 0LL);
		        *(_OWORD *)&v13->fields._assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
		        v13->fields._assetHandle.m_untrackedHandle.m_mainVersion = 0;
		        v13->fields.Tex = 0LL;
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)&v13->fields,
		          v81,
		          v82,
		          v83,
		          v90,
		          v91,
		          (int32_t)v92,
		          (int32_t)v93,
		          *(float *)&v94,
		          v95,
		          v96,
		          v97,
		          v98);
		      }
		      SdfTexs = v94;
		      v12 = ++v11;
		    }
		    if ( !byte_18F35F78C )
		    {
		      sub_180035ED0(&TypeInfo::Beyond::Resource::FAssetObjectID);
		      byte_18F35F78C = 1;
		    }
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_215;
		    if ( *(int *)(static_fields + 24) > 592 )
		    {
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      v21 = *v14;
		      if ( !*v14 )
		        goto LABEL_215;
		      if ( *(_DWORD *)(v21 + 24) <= 0x250u )
		        goto LABEL_209;
		      if ( *(_QWORD *)(v21 + 4768) )
		      {
		        v22 = IFix::WrappersManagerImpl::GetPatch(592, 0LL);
		        if ( !v22 )
		          goto LABEL_215;
		        v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_198(v22, &v13->fields._assetHandle.m_untrackedHandle, 0LL);
		        goto LABEL_175;
		      }
		    }
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_215;
		    if ( *(int *)(static_fields + 24) <= 583 )
		      goto LABEL_63;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v24 = *v14;
		    if ( !*v14 )
		      goto LABEL_215;
		    if ( *(_DWORD *)(v24 + 24) <= 0x247u )
		      goto LABEL_209;
		    if ( *(_QWORD *)(v24 + 4696) )
		    {
		      v25 = IFix::WrappersManagerImpl::GetPatch(583, 0LL);
		      if ( !v25 )
		        goto LABEL_215;
		      v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(
		              v25,
		              &v13->fields._assetHandle.m_untrackedHandle.m_assetProxyObj,
		              0LL);
		    }
		    else
		    {
		LABEL_63:
		      v26 = v13->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID != 0;
		    }
		    if ( !v26 )
		      goto LABEL_195;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_215;
		    if ( *(int *)(static_fields + 24) > 584 )
		    {
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      v27 = *v14;
		      if ( !*v14 )
		        goto LABEL_215;
		      if ( *(_DWORD *)(v27 + 24) <= 0x248u )
		        goto LABEL_209;
		      if ( *(_QWORD *)(v27 + 4704) )
		      {
		        v28 = 584;
		LABEL_85:
		        v30 = IFix::WrappersManagerImpl::GetPatch(v28, 0LL);
		        if ( !v30 )
		          goto LABEL_215;
		        value = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_196(
		                  v30,
		                  &v13->fields._assetHandle.m_untrackedHandle.m_assetProxyObj,
		                  0LL);
		        goto LABEL_163;
		      }
		    }
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_215;
		    if ( *(int *)(static_fields + 24) > 585 )
		    {
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v14 = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		      v29 = *v14;
		      if ( !*v14 )
		        goto LABEL_215;
		      if ( *(_DWORD *)(v29 + 24) <= 0x249u )
		LABEL_209:
		        sub_1800D2AB0(v14, static_fields);
		      if ( *(_QWORD *)(v29 + 4712) )
		      {
		        v28 = 585;
		        goto LABEL_85;
		      }
		    }
		    if ( !v13->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID )
		    {
		      value = 0LL;
		LABEL_163:
		      if ( !value )
		        goto LABEL_195;
		      Target = Beyond::Resource::FObjectHandle::get_Target(&p_m_untrackedHandle->m_assetProxyObj, 0LL);
		      v70 = TypeInfo::Beyond::Resource::IAssetProxy;
		      v71 = Target;
		      if ( !Target )
		        goto LABEL_195;
		      klass = Target->klass;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(TypeInfo::Beyond::Resource::IAssetProxy, Target->klass) )
		      {
		        if ( (BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0 )
		          goto LABEL_195;
		        if ( ((v70->_1.flags & 0x20) == 0
		           && *((_BYTE *)&v70->_0.byval_arg + 10) != 19
		           && *((_BYTE *)&v70->_0.byval_arg + 10) != 30
		           || !v70->_0.interopData
		           || (static_fields = (unsigned __int64)v70->_0.interopData->guid) == 0
		           || !sub_1802ED414(v71))
		          && v70 != (struct IAssetProxy__Class *)qword_18F35FF70 )
		        {
		          goto LABEL_195;
		        }
		      }
		      v23 = sub_182EFB400(v71, p_m_untrackedHandle->m_handleObjectID) ^ 1;
		LABEL_175:
		      if ( !v23 )
		      {
		        if ( !TypeInfo::Beyond::Resource::FAssetObjectID->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::FAssetObjectID);
		        if ( Beyond::Resource::FAssetObjectID::IsValid(&p_m_untrackedHandle->m_assetProxyID, 0LL) )
		        {
		          assetProxy = Beyond::Resource::FAssetProxyUntrackedHandle::get_assetProxy(p_m_untrackedHandle, 0LL);
		          if ( !assetProxy )
		            goto LABEL_212;
		          if ( *(_DWORD *)&assetProxy->klass->_1.method_count == 3450 )
		          {
		            v77._objectIntID_k__BackingField = (int32_t)assetProxy[10].klass;
		          }
		          else if ( *(_DWORD *)&assetProxy->klass->_1.method_count == 3451 )
		          {
		            v77._objectIntID_k__BackingField = HIDWORD(assetProxy[9].monitor);
		          }
		          else
		          {
		            sub_180207B74(0LL, TypeInfo::Beyond::Resource::IAssetProxy);
		            v77._objectIntID_k__BackingField = v76;
		          }
		          v79._objectIntID_k__BackingField = p_m_untrackedHandle->m_assetProxyID._objectIntID_k__BackingField;
		          if ( !TypeInfo::Beyond::Resource::FAssetObjectID->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::FAssetObjectID);
		          if ( Beyond::Resource::FAssetObjectID::op_Equality(v77, v79, 0LL) )
		          {
		            v80 = Beyond::Resource::FAssetProxyUntrackedHandle::get_assetProxy(p_m_untrackedHandle, 0LL);
		            if ( !v80 )
		LABEL_212:
		              sub_1800D8250(v75, v74);
		            if ( !(unsigned __int8)sub_182EFB050(v80) )
		            {
		              v20 = 1;
		LABEL_196:
		              v13 = v93;
		              v11 = v100;
		              goto LABEL_197;
		            }
		          }
		        }
		      }
		LABEL_195:
		      v20 = 0;
		      goto LABEL_196;
		    }
		    m_handleID = v13->fields._assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID;
		    if ( !TypeInfo::Beyond::Resource::ObjectHandle->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::ObjectHandle);
		    P0.m_handleID = m_handleID;
		    if ( !byte_18F363FD9 )
		    {
		      sub_180035ED0(&MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue);
		      sub_180035ED0(&TypeInfo::Beyond::Resource::ObjectHandle);
		      byte_18F363FD9 = 1;
		    }
		    v92 = 0LL;
		    if ( !TypeInfo::Beyond::Resource::ObjectHandle->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::Beyond::Resource::ObjectHandle);
		    s_handleToObject = TypeInfo::Beyond::Resource::ObjectHandle->static_fields->s_handleToObject;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    p_image = &TypeInfo::IFix::ILFixDynamicMethodWrapper->_0.image;
		    static_fields = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_214;
		    if ( *(int *)(static_fields + 24) > 2273 )
		    {
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      p_image = &TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		      v35 = *p_image;
		      if ( !*p_image )
		        goto LABEL_214;
		      if ( *(_DWORD *)(v35 + 24) <= 0x8E1u )
		        goto LABEL_213;
		      if ( *(_QWORD *)(v35 + 18216) )
		      {
		        v36 = IFix::WrappersManagerImpl::GetPatch(2273, 0LL);
		        if ( !v36 )
		          goto LABEL_214;
		        m_handleID = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_853(v36, &P0, 0LL);
		      }
		    }
		    if ( !s_handleToObject )
		      goto LABEL_214;
		    v37 = MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue;
		    comparer = (Object *)s_handleToObject->fields._comparer;
		    if ( !comparer )
		      goto LABEL_214;
		    rgctx_data = MethodInfo::System::Collections::Concurrent::ConcurrentDictionary<int,System::Object>::TryGetValue->klass->rgctx_data;
		    v40.rgctxDataDummy = rgctx_data[12].rgctxDataDummy;
		    if ( (*((_BYTE *)v40.rgctxDataDummy + 312) & 1) == 0 )
		    {
		      sub_1800360B0((const Il2CppRGCTXData)rgctx_data[12].rgctxDataDummy, static_fields);
		      v40.rgctxDataDummy = v41.rgctxDataDummy;
		    }
		    v42 = comparer->klass;
		    sub_1800049A0(comparer->klass);
		    v43 = *(unsigned __int16 *)&v42->_1.naturalAligment;
		    v44 = 0;
		    if ( (_WORD)v43 )
		    {
		      interfaceOffsets = v42->interfaceOffsets;
		      while ( interfaceOffsets[v44].interfaceType != v40.rgctxDataDummy )
		      {
		        if ( ++v44 >= (unsigned __int16)v43 )
		          goto LABEL_114;
		      }
		      v47 = v44;
		      v46 = (__int64)(&v42->vtable.Finalize.method + 2 * interfaceOffsets[v47].offset);
		    }
		    else
		    {
		LABEL_114:
		      v46 = ((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_1800219C0)(
		              comparer,
		              (Il2CppRGCTXData)v40.rgctxDataDummy,
		              1LL);
		    }
		    v48 = *(int32_t (**)(Array *, int32_t, MethodInfo *))v46;
		    v49 = *(_QWORD *)(v46 + 8);
		    if ( *(int32_t (**)(EnumEqualityComparer_1_System_Int32Enum_ *, Int32Enum__Enum, MethodInfo *))v46 == System::Collections::Generic::EnumEqualityComparer<System::Int32Enum>::GetHashCode )
		    {
		      v50 = *(_QWORD **)(*(_QWORD *)(v49 + 32) + 192LL);
		      v51 = *v50;
		      if ( !*(_QWORD *)(*v50 + 56LL) )
		        sub_1800430B0(*v50);
		      v52 = *(_QWORD **)(v51 + 56);
		      if ( !*(_QWORD *)(*v52 + 56LL) )
		        sub_1800430B0(*v52);
		LABEL_120:
		      v53 = m_handleID;
		LABEL_145:
		      static_fields = (unsigned __int64)v37->klass->rgctx_data;
		      if ( !*(_QWORD *)(*(_QWORD *)(static_fields + 232) + 32LL) )
		        (*(void (**)(void))v37->klass->rgctx_data[29].rgctxDataDummy)();
		      tables = s_handleToObject->fields._tables;
		      p_image = &v37->klass->rgctx_data->rgctxDataDummy;
		      v60 = p_image[29];
		      _InterlockedOr(v89, 0);
		      if ( !tables )
		        goto LABEL_214;
		      buckets = tables->fields._buckets;
		      if ( !buckets )
		        goto LABEL_214;
		      p_image = *(_QWORD **)(*(_QWORD *)(v60 + 32) + 192LL);
		      v62 = p_image[2];
		      if ( (*(_BYTE *)(v62 + 312) & 1) == 0 )
		        sub_1800360B0(p_image[2], static_fields);
		      if ( !*(_DWORD *)(v62 + 224) )
		        il2cpp_runtime_class_init_1(v62);
		      v63 = tables->fields._buckets;
		      if ( !v63 )
		        goto LABEL_214;
		      static_fields = (unsigned int)((v53 & 0x7FFFFFFFu) % (__int64)buckets->max_length.size);
		      if ( (unsigned int)static_fields >= v63->max_length.size )
		LABEL_213:
		        sub_1800D2AB0(p_image, static_fields);
		      next = v63->vector[(int)static_fields];
		      _InterlockedOr(v89, 0);
		      if ( next )
		      {
		        while ( 1 )
		        {
		          if ( v53 == next->fields._hashcode )
		          {
		            v65 = s_handleToObject->fields._comparer;
		            key = next->fields._key;
		            if ( !v65 )
		              goto LABEL_214;
		            v67 = *(_QWORD *)(*(_QWORD *)(v60 + 32) + 192LL);
		            v68 = *(_QWORD *)(v67 + 96);
		            if ( (*(_BYTE *)(v68 + 312) & 1) == 0 )
		              sub_1800360B0(*(_QWORD *)(v67 + 96), static_fields);
		            if ( (unsigned __int8)sub_1800036E0(0LL, v68, v65, key, m_handleID) )
		              break;
		          }
		          next = next->fields._next;
		          _InterlockedOr(v89, 0);
		          if ( !next )
		            goto LABEL_162;
		        }
		        value = next->fields._value;
		        v92 = value;
		        if ( dword_18F35FD08 )
		        {
		          static_fields = (unsigned __int64)&qword_18F103690[(((unsigned __int64)&v92 >> 12) & 0x1FFFFF) >> 6];
		          _m_prefetchw((const void *)static_fields);
		          do
		            v78 = *(_QWORD *)static_fields;
		          while ( v78 != _InterlockedCompareExchange64(
		                           (volatile signed __int64 *)static_fields,
		                           *(_QWORD *)static_fields | (1LL << (((unsigned __int64)&v92 >> 12) & 0x3F)),
		                           *(_QWORD *)static_fields) );
		          value = v92;
		        }
		      }
		      else
		      {
		LABEL_162:
		        value = 0LL;
		        v92 = 0LL;
		      }
		      goto LABEL_163;
		    }
		    if ( (char *)v48 == (char *)Beyond::Gameplay::View::MountPointEqualityComparer::GetHashCode )
		    {
		      p_image = &TypeInfo::IFix::ILFixDynamicMethodWrapper->_0.image;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        p_image = &TypeInfo::IFix::ILFixDynamicMethodWrapper->_0.image;
		      }
		      static_fields = *(_QWORD *)p_image[23];
		      if ( !static_fields )
		        goto LABEL_214;
		      if ( *(int *)(static_fields + 24) <= 42671 )
		        goto LABEL_120;
		      if ( !*((_DWORD *)p_image + 56) )
		      {
		        il2cpp_runtime_class_init_1(p_image);
		        p_image = &TypeInfo::IFix::ILFixDynamicMethodWrapper->_0.image;
		      }
		      p_image = *(_QWORD **)p_image[23];
		      if ( !p_image )
		        goto LABEL_214;
		      if ( *((_DWORD *)p_image + 6) <= 0xA6AFu )
		        goto LABEL_213;
		      if ( !p_image[42675] )
		        goto LABEL_120;
		      v54 = IFix::WrappersManagerImpl::GetPatch(42671, 0LL);
		      if ( !v54 )
		        goto LABEL_214;
		      v55 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_74(
		              (ILFixDynamicMethodWrapper_10 *)v54,
		              comparer,
		              m_handleID,
		              0LL);
		    }
		    else
		    {
		      if ( v48 == System::Array::InternalArray__IReadOnlyList_get_Item<int> )
		      {
		        P0.m_handleID = 0;
		        if ( !comparer->klass )
		        {
		          v94 = 0LL;
		          v95 = 0LL;
		          v88 = sub_1800D82B0(&v94);
		          sub_18007E1B0(v88, 0LL);
		        }
		        if ( !*((_BYTE *)&comparer->klass->_1 + 108) )
		        {
		          v87 = sub_1800D2AD0(v47 * 2, v43);
		          sub_18007E1B0(v87, 0LL);
		        }
		        p_monitor = (unsigned int *)&comparer[1].monitor;
		        if ( comparer[1].klass )
		          p_monitor = (unsigned int *)comparer[1].klass;
		        v57 = *p_monitor;
		        v58 = 1;
		        if ( *((_BYTE *)&comparer->klass->_1 + 108) > 1u )
		        {
		          do
		            v57 *= (unsigned int)System::Array::GetLength((System::Array *)comparer, v58++);
		          while ( v58 < *((unsigned __int8 *)&comparer->klass->_1 + 108) );
		        }
		        if ( m_handleID >= v57 )
		        {
		          v84 = sub_180035ED0(&TypeInfo::System::ArgumentOutOfRangeException);
		          v85 = (ArgumentOutOfRangeException *)sub_1800368D0(v84);
		          if ( v85 )
		          {
		            v86 = (String *)sub_180035ED0(&off_18E332C28);
		            System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v85, v86, 0LL);
		            sub_18007E190(v85, v49);
		          }
		LABEL_214:
		          sub_1800D8260(p_image, static_fields);
		        }
		        sub_18033B330(
		          &P0,
		          (char *)&comparer[2] + (int)m_handleID * (unsigned __int64)comparer->klass->_1.element_size,
		          comparer->klass->_1.element_size);
		        v53 = P0.m_handleID;
		        goto LABEL_145;
		      }
		      v55 = ((unsigned int (__fastcall *)(Object *, _QWORD, __int64))v48)(comparer, m_handleID, v49);
		    }
		    v53 = v55;
		    goto LABEL_145;
		  }
		  v7 = IFix::WrappersManagerImpl::GetPatch(5034, 0LL);
		  if ( !v7 )
		    sub_1800D8260(v9, v8);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v7, (Object *)this, 0LL);
		}
		
	}
}
