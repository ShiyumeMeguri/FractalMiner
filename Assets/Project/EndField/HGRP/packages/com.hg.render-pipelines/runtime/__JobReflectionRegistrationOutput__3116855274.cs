using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3116855274 // TypeDefIndex: 38875
{
	// Constructors
	public __JobReflectionRegistrationOutput__3116855274() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000182D30DA0-0x0000000182D310B0
	// Void CreateJobReflectionData()
	void __JobReflectionRegistrationOutput__3116855274::CreateJobReflectionData(MethodInfo *method)
	{
	  __int64 v1; // rdx
	  struct MethodInfo *v2; // rbx
	  Il2CppRGCTXData v3; // rax
	  __int64 v4; // rdx
	  RuntimeTypeHandle v5; // rbx
	  __int64 v6; // rax
	  Type *TypeFromHandle; // rax
	  struct MethodInfo *v8; // rbx
	  Il2CppRGCTXData v9; // rax
	  __int64 v10; // rdx
	  RuntimeTypeHandle v11; // rbx
	  __int64 v12; // rax
	  Type *v13; // rax
	  struct MethodInfo *v14; // rbx
	  Il2CppRGCTXData v15; // rax
	  RuntimeTypeHandle v16; // rbx
	  __int64 v17; // rax
	  Type *v18; // rax
	  Il2CppExceptionWrapper *v19; // rdi
	  Il2CppClass *klass; // rbx
	  __int64 v21; // rax
	  Il2CppExceptionWrapper *v22; // rdi
	  Il2CppClass *v23; // rbx
	  __int64 v24; // rax
	  Il2CppExceptionWrapper *v25; // rdi
	  Il2CppClass *v26; // rbx
	  __int64 v27; // rax
	  Il2CppExceptionWrapper v28; // [rsp+20h] [rbp-38h] BYREF
	  Il2CppExceptionWrapper v29; // [rsp+28h] [rbp-30h] BYREF
	  Il2CppExceptionWrapper v30; // [rsp+30h] [rbp-28h] BYREF
	  Il2CppExceptionWrapper *v31; // [rsp+38h] [rbp-20h] BYREF
	  Il2CppExceptionWrapper *v32; // [rsp+40h] [rbp-18h] BYREF
	  Il2CppExceptionWrapper *v33; // [rsp+48h] [rbp-10h] BYREF
	  Il2CppException *ex; // [rsp+68h] [rbp+10h]
	  Il2CppException *exa; // [rsp+68h] [rbp+10h]
	  Il2CppException *exb; // [rsp+68h] [rbp+10h]
	
	  try
	  {
	    v2 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>;
	    if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>->rgctx_data )
	      sub_1800430B0(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>);
	    v3.rgctxDataDummy = v2->rgctx_data[1].rgctxDataDummy;
	    if ( (*((_BYTE *)v3.rgctxDataDummy + 312) & 1) == 0 )
	      sub_1800360B0((const Il2CppRGCTXData)v2->rgctx_data[1].rgctxDataDummy, v1);
	    if ( !*((_DWORD *)v3.rgctxDataDummy + 56) )
	      ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v3.rgctxDataDummy);
	    Unity::Jobs::IJobExtensions::JobStruct<BeyondDynamicBone::VirtualMesh::Work_IntersetcSortJob>::Initialize((MethodInfo *)v2->rgctx_data->rgctxDataDummy);
	  }
	  catch ( Il2CppExceptionWrapper *v31 )
	  {
	    v19 = v31;
	    klass = v31->ex->object.klass;
	    v21 = sub_180035ED0(&TypeInfo::System::Exception);
	    if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v21, klass) )
	    {
	      v30.ex = v19->ex;
	      throw &v30;
	    }
	    ex = v19->ex;
	    v5.value = (void *)sub_180035ED0(&TypeRef::HG::Rendering::Runtime::CalculatePlanesJob);
	    v6 = sub_180035ED0(&TypeInfo::System::Type);
	    if ( !*(_DWORD *)(v6 + 224) )
	      il2cpp_runtime_class_init_1(v6);
	    TypeFromHandle = System::Type::GetTypeFromHandle(v5, 0LL);
	    Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)ex, TypeFromHandle, 0LL);
	  }
	  try
	  {
	    v8 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>;
	    if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>->rgctx_data )
	      sub_1800430B0(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>);
	    v9.rgctxDataDummy = v8->rgctx_data[1].rgctxDataDummy;
	    if ( (*((_BYTE *)v9.rgctxDataDummy + 312) & 1) == 0 )
	      sub_1800360B0((const Il2CppRGCTXData)v8->rgctx_data[1].rgctxDataDummy, v4);
	    if ( !*((_DWORD *)v9.rgctxDataDummy + 56) )
	      ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v9.rgctxDataDummy);
	    Unity::Jobs::IJobExtensions::JobStruct<BeyondDynamicBone::VirtualMesh::Work_IntersetcSortJob>::Initialize((MethodInfo *)v8->rgctx_data->rgctxDataDummy);
	  }
	  catch ( Il2CppExceptionWrapper *v32 )
	  {
	    v22 = v32;
	    v23 = v32->ex->object.klass;
	    v24 = sub_180035ED0(&TypeInfo::System::Exception);
	    if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v24, v23) )
	    {
	      v29.ex = v22->ex;
	      throw &v29;
	    }
	    exa = v22->ex;
	    v11.value = (void *)sub_180035ED0(&TypeRef::HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities);
	    v12 = sub_180035ED0(&TypeInfo::System::Type);
	    if ( !*(_DWORD *)(v12 + 224) )
	      il2cpp_runtime_class_init_1(v12);
	    v13 = System::Type::GetTypeFromHandle(v11, 0LL);
	    Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)exa, v13, 0LL);
	  }
	  try
	  {
	    v14 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>;
	    if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>->rgctx_data )
	      sub_1800430B0(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>);
	    v15.rgctxDataDummy = v14->rgctx_data[1].rgctxDataDummy;
	    if ( (*((_BYTE *)v15.rgctxDataDummy + 312) & 1) == 0 )
	      sub_1800360B0((const Il2CppRGCTXData)v14->rgctx_data[1].rgctxDataDummy, v10);
	    if ( !*((_DWORD *)v15.rgctxDataDummy + 56) )
	      ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v15.rgctxDataDummy);
	    Unity::Jobs::IJobExtensions::JobStruct<BeyondDynamicBone::VirtualMesh::Work_IntersetcSortJob>::Initialize((MethodInfo *)v14->rgctx_data->rgctxDataDummy);
	  }
	  catch ( Il2CppExceptionWrapper *v33 )
	  {
	    v25 = v33;
	    v26 = v33->ex->object.klass;
	    v27 = sub_180035ED0(&TypeInfo::System::Exception);
	    if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v27, v26) )
	    {
	      v28.ex = v25->ex;
	      throw &v28;
	    }
	    exb = v25->ex;
	    v16.value = (void *)sub_180035ED0(&TypeRef::HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob);
	    v17 = sub_180035ED0(&TypeInfo::System::Type);
	    if ( !*(_DWORD *)(v17 + 224) )
	      il2cpp_runtime_class_init_1(v17);
	    v18 = System::Type::GetTypeFromHandle(v16, 0LL);
	    Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)exb, v18, 0LL);
	  }
	}
	
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit() {} // 0x0000000182D310B0-0x0000000182D310C0
	// Void EarlyInit()
	void __JobReflectionRegistrationOutput__3116855274::EarlyInit(MethodInfo *method)
	{
	  __JobReflectionRegistrationOutput__3116855274::CreateJobReflectionData(0LL);
	}
	
}

