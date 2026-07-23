using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GBufferProfileManager // TypeDefIndex: 38114
	{
		// Fields
		private DynamicArray<GBufferProfile> m_profiles; // 0x10
	
		// Nested types
		internal class GBufferProfile // TypeDefIndex: 38112
		{
			// Fields
			public List<AttachmentProfile> attachmentProfiles; // 0x10
			public int[] gBufferMapping; // 0x18
	
			// Nested types
			public class AttachmentProfile // TypeDefIndex: 38111
			{
				// Fields
				internal TextureDesc attachmentDesc; // 0x10
	
				// Constructors
				public AttachmentProfile() {} // 0x00000001841E1670-0x00000001841E1680
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
			public GBufferProfile() {} // 0x0000000182EDCB30-0x0000000182EDCBD0
			// GBufferProfileManager+GBufferProfile()
			void HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::GBufferProfile(
			        GBufferProfileManager_GBufferProfile *this,
			        MethodInfo *method)
			{
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			  List_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_AttachmentProfile_ *v6; // rbx
			  Type *v7; // rdx
			  PropertyInfo_1 *v8; // r8
			  Int32__Array **v9; // r9
			  struct MethodInfo *v10; // rbx
			  IEnumerable_1_System_Int32_ *v11; // rax
			  Type *v12; // rdx
			  PropertyInfo_1 *v13; // r8
			  Int32__Array **v14; // r9
			  MethodInfo *v15; // [rsp+20h] [rbp-8h]
			  MethodInfo *v16; // [rsp+50h] [rbp+28h]
			
			  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>);
			  v6 = (List_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_AttachmentProfile_ *)v3;
			  if ( !v3 )
			    sub_1800D8260(v5, v4);
			  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			    v3,
			    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::List);
			  this->fields.attachmentProfiles = v6;
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v15);
			  v10 = MethodInfo::System::Linq::Enumerable::Repeat<int>;
			  if ( !MethodInfo::System::Linq::Enumerable::Repeat<int>->rgctx_data )
			    sub_1800430B0(MethodInfo::System::Linq::Enumerable::Repeat<int>);
			  v11 = System::Linq::Enumerable::RepeatIterator<int>(-1, 4, (MethodInfo *)v10->rgctx_data->rgctxDataDummy);
			  this->fields.gBufferMapping = System::Linq::Enumerable::ToArray<int>(
			                                  v11,
			                                  MethodInfo::System::Linq::Enumerable::ToArray<int>);
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.gBufferMapping, v12, v13, v14, v16);
			}
			
	
			// Methods
			public void AddGBufferRT(GBufferID id, GraphicsFormat format, string name, bool transient = false /* Metadata: 0x023038CD */) {} // 0x0000000182EDC480-0x0000000182EDC650
			// Void AddGBufferRT(GBufferID, GraphicsFormat, String, Boolean)
			void HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			        GBufferProfileManager_GBufferProfile *this,
			        GBufferID__Enum id,
			        GraphicsFormat__Enum format,
			        String *name,
			        bool transient,
			        MethodInfo *method)
			{
			  __int64 v7; // rdi
			  __int64 size; // rdx
			  List_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_AttachmentProfile_ *attachmentProfiles; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rcx
			  List_1_System_Object_ *v13; // rdi
			  __int64 v14; // rbx
			  Vector2Int s_One; // rcx
			  Type *v16; // rdx
			  PropertyInfo_1 *v17; // r8
			  Int32__Array **v18; // r9
			  __int128 v19; // xmm4
			  __int128 v20; // xmm5
			  Color clearColor; // xmm0
			  __int128 v22; // xmm2
			  __int128 v23; // xmm3
			  Type *v24; // rdx
			  PropertyInfo_1 *v25; // r8
			  Int32__Array **v26; // r9
			  ILFixDynamicMethodWrapper_2 *v27; // rax
			  MethodInfo *P3; // [rsp+28h] [rbp-59h]
			  MethodInfo *P3a; // [rsp+28h] [rbp-59h]
			  double v30; // [rsp+48h] [rbp-39h]
			  TextureDesc P0; // [rsp+58h] [rbp-29h] BYREF
			
			  v7 = (int)id;
			  LODWORD(v30) = 0;
			  if ( IFix::WrappersManagerImpl::IsPatched(2868, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2868, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1049(
			        Patch,
			        (Object *)this,
			        (GBufferID__Enum)v7,
			        format,
			        (Object *)name,
			        transient,
			        0LL);
			      return;
			    }
			    goto LABEL_12;
			  }
			  if ( format == GraphicsFormat__Enum_None )
			    return;
			  attachmentProfiles = this->fields.attachmentProfiles;
			  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.gBufferMapping;
			  LOBYTE(v30) = 1;
			  HIDWORD(v30) = 1;
			  if ( !attachmentProfiles )
			    goto LABEL_12;
			  size = (unsigned int)attachmentProfiles->fields._size;
			  if ( !Patch )
			    goto LABEL_12;
			  if ( (unsigned int)v7 >= Patch->fields.methodId )
			    sub_1800D2AB0(Patch, size);
			  *((_DWORD *)&Patch->fields.anonObj + v7) = size;
			  v13 = (List_1_System_Object_ *)this->fields.attachmentProfiles;
			  v14 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile);
			  if ( !v14 )
			    goto LABEL_12;
			  s_One = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One;
			  memset(&P0.slices, 0, 88);
			  *(Vector2Int *)&P0.width = s_One;
			  P0.msaaSamples = 1;
			  if ( !IFix::WrappersManagerImpl::IsPatched(325, 0LL) )
			  {
			    P0.slices = 1;
			    P0.dimension = 2;
			    goto LABEL_9;
			  }
			  v27 = IFix::WrappersManagerImpl::GetPatch(325, 0LL);
			  if ( !v27 )
			LABEL_12:
			    sub_1800D8260(Patch, size);
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_154(v27, &P0, 0LL);
			LABEL_9:
			  P0.colorFormat = format;
			  P0.memoryless = transient;
			  P0.name = name;
			  sub_18002D1B0((SingleFieldAccessor *)&P0.name, v16, v17, v18, P3);
			  v19 = *(_OWORD *)&P0.bindTextureMS;
			  P0.fastMemoryDesc.residencyFraction = 1.0;
			  *((_QWORD *)&v20 + 1) = *(_QWORD *)&P0.fastMemoryDesc.residencyFraction;
			  P0.slices = 1;
			  *(double *)&v20 = v30;
			  clearColor = P0.clearColor;
			  P0.dimension = 2;
			  v22 = *(_OWORD *)&P0.colorFormat;
			  P0.msaaSamples = 1;
			  v23 = *(_OWORD *)&P0.enableRandomWrite;
			  *(_OWORD *)&P0.fastMemoryDesc.inFastMemory = v20;
			  *(_OWORD *)(v14 + 16) = *(_OWORD *)&P0.width;
			  *(_OWORD *)(v14 + 32) = v22;
			  *(_OWORD *)(v14 + 48) = v23;
			  *(_OWORD *)(v14 + 64) = v19;
			  *(_OWORD *)(v14 + 80) = v20;
			  *(Color *)(v14 + 96) = clearColor;
			  sub_18002D1B0((SingleFieldAccessor *)(v14 + 72), v24, v25, v26, P3a);
			  if ( !v13 )
			    goto LABEL_12;
			  sub_182F01190(v13, (Object *)v14);
			}
			
		}
	
		internal enum GBufferProfileConfig // TypeDefIndex: 38113
		{
			HighEnd = 0,
			LowEnd = 1,
			Count = 2
		}
	
		// Constructors
		internal GBufferProfileManager() {} // 0x0000000182EDC220-0x0000000182EDC480
		// GBufferProfileManager()
		void HG::Rendering::Runtime::GBufferProfileManager::GBufferProfileManager(
		        GBufferProfileManager *this,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v3; // rax
		  HGRenderCapability__StaticFields *static_fields; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *instance; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  DynamicArray_1_System_Object_ *v10; // rax
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  int32_t i; // ebx
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rax
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *v17; // rcx
		  SingleFieldAccessor *Item; // r14
		  GBufferProfileManager_GBufferProfile *v19; // rax
		  GBufferProfileManager_GBufferProfile *v20; // rsi
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  Object *v24; // rbx
		  Object *v25; // rbx
		  struct HGRenderCapability__Class *v26; // rax
		  bool v27; // al
		  bool v28; // di
		  HGRenderCapability *v29; // rax
		  MethodInfo *transient; // [rsp+20h] [rbp-18h]
		  MethodInfo *transienta; // [rsp+20h] [rbp-18h]
		  MethodInfo *transientb; // [rsp+20h] [rbp-18h]
		
		  v3 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>);
		  v6 = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v3;
		  if ( !v3 )
		    goto LABEL_2;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v3,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
		  this->fields.m_profiles = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, transient);
		  v10 = (DynamicArray_1_System_Object_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>);
		  v11 = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v10;
		  if ( !v10 )
		    goto LABEL_2;
		  UnityEngine::Rendering::DynamicArray<System::Object>::DynamicArray(
		    v10,
		    2,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
		  this->fields.m_profiles = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v12, v13, v14, transienta);
		  for ( i = 0; ; ++i )
		  {
		    m_profiles = this->fields.m_profiles;
		    if ( !m_profiles )
		      goto LABEL_2;
		    v17 = this->fields.m_profiles;
		    if ( i >= m_profiles->fields._size_k__BackingField )
		      break;
		    Item = (SingleFieldAccessor *)UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                                    (DynamicArray_1_System_Object_ *)v17,
		                                    i,
		                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		    v19 = (GBufferProfileManager_GBufferProfile *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile);
		    v20 = v19;
		    if ( !v19 )
		      goto LABEL_2;
		    HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::GBufferProfile(v19, 0LL);
		    Item->klass = (SingleFieldAccessor__Class *)v20;
		    sub_18002D1B0(Item, v21, v22, v23, transientb);
		  }
		  v24 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           (DynamicArray_1_System_Object_ *)v17,
		           0,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		  if ( !v24 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		    (GBufferProfileManager_GBufferProfile *)v24,
		    GBufferID__Enum_GBufferA,
		    GraphicsFormat__Enum_A2B10G10R10_UNormPack32,
		    (String *)"GBufferA",
		    0,
		    0LL);
		  HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		    (GBufferProfileManager_GBufferProfile *)v24,
		    GBufferID__Enum_GBufferB,
		    GraphicsFormat__Enum_A2B10G10R10_UNormPack32,
		    (String *)"GBufferB",
		    0,
		    0LL);
		  HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		    (GBufferProfileManager_GBufferProfile *)v24,
		    GBufferID__Enum_GBufferC,
		    GraphicsFormat__Enum_R8G8B8A8_SRGB,
		    (String *)"GBufferC",
		    0,
		    0LL);
		  instance = this->fields.m_profiles;
		  if ( !instance )
		    goto LABEL_2;
		  v25 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           (DynamicArray_1_System_Object_ *)instance,
		           1,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		  v26 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderCapability->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderCapability);
		    v26 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability;
		  }
		  instance = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v26->static_fields->instance;
		  if ( !instance
		    || (v27 = HG::Rendering::Runtime::HGRenderCapability::SupportNativeRenderPass((HGRenderCapability *)instance, 0LL),
		        v28 = v27,
		        !v25)
		    || (HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		          (GBufferProfileManager_GBufferProfile *)v25,
		          GBufferID__Enum_GBufferA,
		          GraphicsFormat__Enum_R8G8B8A8_UNorm,
		          (String *)"GBufferA",
		          v27,
		          0LL),
		        HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		          (GBufferProfileManager_GBufferProfile *)v25,
		          GBufferID__Enum_GBufferB,
		          GraphicsFormat__Enum_R8G8B8A8_SRGB,
		          (String *)"GBufferB",
		          v28,
		          0LL),
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields,
		        (v29 = static_fields->instance) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(instance, static_fields);
		  }
		  if ( v29->fields._useGBufferDepth_k__BackingField )
		    HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
		      (GBufferProfileManager_GBufferProfile *)v25,
		      GBufferID__Enum_GBufferDepth,
		      GraphicsFormat__Enum_R32_SFloat,
		      (String *)"GBufferDepth",
		      v28,
		      0LL);
		}
		
	
		// Methods
		[IDTag(1)]
		internal TextureHandle CreateGBufferTexture(GBufferProfileConfig config, HGRenderGraph renderGraph, GBufferID gBufferID, HGCamera camera) => default; // 0x0000000189B76488-0x0000000189B765CC
		// TextureHandle CreateGBufferTexture(GBufferProfileManager+GBufferProfileConfig, HGRenderGraph, GBufferID, HGCamera)
		TextureHandle *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
		        TextureHandle *__return_ptr retstr,
		        GBufferProfileManager *this,
		        GBufferProfileManager_GBufferProfileConfig__Enum config,
		        HGRenderGraph *renderGraph,
		        GBufferID__Enum gBufferID,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rcx
		  Object *v13; // r8
		  TextureHandle *v14; // rax
		  __int64 v15; // rax
		  Exception *v16; // rbx
		  String *v17; // rax
		  __int64 v18; // rax
		  TextureHandle v19; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v21; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2864, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2864, 0LL);
		    if ( Patch )
		    {
		      v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1046(
		              &v21,
		              Patch,
		              (Object *)this,
		              config,
		              (Object *)renderGraph,
		              gBufferID,
		              (Object *)camera,
		              0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(m_profiles, Patch);
		  }
		  m_profiles = this->fields.m_profiles;
		  if ( !m_profiles )
		    goto LABEL_8;
		  v13 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           (DynamicArray_1_System_Object_ *)m_profiles,
		           config,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		  if ( !v13 )
		  {
		    v15 = sub_18007E180(&TypeInfo::System::Exception);
		    v16 = (Exception *)sub_18002C620(v15);
		    if ( v16 )
		    {
		      v17 = (String *)sub_18007E180(&off_18E263860);
		      System::Exception::Exception(v16, v17, 0LL);
		      v18 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture);
		      sub_18007E190(v16, v18);
		    }
		    goto LABEL_8;
		  }
		  v14 = HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
		          &v21,
		          this,
		          (GBufferProfileManager_GBufferProfile *)v13,
		          renderGraph,
		          gBufferID,
		          camera,
		          0LL);
		LABEL_10:
		  v19 = *v14;
		  result = retstr;
		  *retstr = v19;
		  return result;
		}
		
		[IDTag(0)]
		internal TextureHandle CreateGBufferTexture(GBufferProfile profile, HGRenderGraph renderGraph, int gBufferID, HGCamera camera) => default; // 0x0000000189B76334-0x0000000189B76488
		// TextureHandle CreateGBufferTexture(GBufferProfileManager+GBufferProfile, HGRenderGraph, Int32, HGCamera)
		TextureHandle *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
		        TextureHandle *__return_ptr retstr,
		        GBufferProfileManager *this,
		        GBufferProfileManager_GBufferProfile *profile,
		        HGRenderGraph *renderGraph,
		        int32_t gBufferID,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  List_1_System_Object_ *attachmentProfiles; // rcx
		  Object *Item; // rax
		  Object *v14; // rax
		  Object *v15; // rax
		  TextureHandle *v16; // rax
		  TextureHandle v17; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v19; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2865, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2865, 0LL);
		    if ( Patch )
		    {
		      v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1045(
		              &v19,
		              Patch,
		              (Object *)this,
		              (Object *)profile,
		              (Object *)renderGraph,
		              gBufferID,
		              (Object *)camera,
		              0LL);
		      goto LABEL_15;
		    }
		LABEL_13:
		    sub_1800D8260(attachmentProfiles, Patch);
		  }
		  if ( !profile )
		    goto LABEL_13;
		  attachmentProfiles = (List_1_System_Object_ *)profile->fields.attachmentProfiles;
		  if ( !attachmentProfiles )
		    goto LABEL_13;
		  Item = System::Collections::Generic::List<System::Object>::get_Item(
		           attachmentProfiles,
		           gBufferID,
		           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
		  if ( !Item )
		    goto LABEL_13;
		  if ( !camera )
		    goto LABEL_13;
		  LODWORD(Item[1].klass) = camera->fields._sceneRTSize_k__BackingField.m_X;
		  attachmentProfiles = (List_1_System_Object_ *)profile->fields.attachmentProfiles;
		  if ( !attachmentProfiles )
		    goto LABEL_13;
		  v14 = System::Collections::Generic::List<System::Object>::get_Item(
		          attachmentProfiles,
		          gBufferID,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
		  if ( !v14 )
		    goto LABEL_13;
		  HIDWORD(v14[1].klass) = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  attachmentProfiles = (List_1_System_Object_ *)profile->fields.attachmentProfiles;
		  if ( !attachmentProfiles )
		    goto LABEL_13;
		  v15 = System::Collections::Generic::List<System::Object>::get_Item(
		          attachmentProfiles,
		          gBufferID,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
		  if ( !v15 || !renderGraph )
		    goto LABEL_13;
		  v16 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v19, renderGraph, (TextureDesc *)&v15[1], 0LL);
		LABEL_15:
		  v17 = *v16;
		  result = retstr;
		  *retstr = v17;
		  return result;
		}
		
		internal GBufferOutput SetupGBufferOutput(GBufferProfileConfig config, HGRenderGraph renderGraph, HGCamera camera, float copyScale) => default; // 0x0000000189B766DC-0x0000000189B76914
		// GBufferOutput SetupGBufferOutput(GBufferProfileManager+GBufferProfileConfig, HGRenderGraph, HGCamera, Single)
		GBufferOutput *HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput(
		        GBufferOutput *__return_ptr retstr,
		        GBufferProfileManager *this,
		        GBufferProfileManager_GBufferProfileConfig__Enum config,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        float copyScale,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  DynamicArray_1_System_Object_ *m_profiles; // rcx
		  GBufferProfileManager_GBufferProfile *v13; // rdi
		  int32_t v14; // r14d
		  Void *m_Buffer; // rbp
		  TextureHandle *GBufferTexture; // rax
		  Void *v17; // r8
		  __int64 v18; // rax
		  NativeArray_1_System_Int32_ v19; // xmm1
		  __int64 v20; // rax
		  Exception *v21; // rbx
		  String *v22; // rax
		  __int64 v23; // rax
		  GBufferOutput *v24; // rax
		  NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v27; // [rsp+40h] [rbp-58h] BYREF
		  NativeArray_1_System_Int32_ v28; // [rsp+50h] [rbp-48h] BYREF
		  GBufferOutput v29; // [rsp+60h] [rbp-38h] BYREF
		
		  v27 = 0LL;
		  v28 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2866, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2866, 0LL);
		    if ( Patch )
		    {
		      v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1047(
		              &v29,
		              Patch,
		              (Object *)this,
		              config,
		              (Object *)renderGraph,
		              (Object *)camera,
		              copyScale,
		              0LL);
		      m_gbufferMapping = v24->m_gbufferMapping;
		      retstr->m_attachments = v24->m_attachments;
		      retstr->m_gbufferMapping = m_gbufferMapping;
		      return retstr;
		    }
		LABEL_17:
		    sub_1800D8260(m_profiles, Patch);
		  }
		  m_profiles = (DynamicArray_1_System_Object_ *)this->fields.m_profiles;
		  if ( !m_profiles )
		    goto LABEL_17;
		  v13 = (GBufferProfileManager_GBufferProfile *)*UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                                                   m_profiles,
		                                                   config,
		                                                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		  if ( !v13 )
		  {
		    v20 = sub_18007E180(&TypeInfo::System::Exception);
		    v21 = (Exception *)sub_18002C620(v20);
		    if ( v21 )
		    {
		      v22 = (String *)sub_18007E180(&off_18E263860);
		      System::Exception::Exception(v21, v22, 0LL);
		      v23 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput);
		      sub_18007E190(v21, v23);
		    }
		    goto LABEL_17;
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)v13->fields.attachmentProfiles;
		  if ( !Patch )
		    goto LABEL_17;
		  Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		    &v27,
		    Patch->fields.methodId,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
		  v14 = 0;
		  if ( v27.m_Length > 0 )
		  {
		    m_Buffer = v27.m_Buffer;
		    do
		    {
		      GBufferTexture = HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
		                         (TextureHandle *)&v29,
		                         this,
		                         v13,
		                         renderGraph,
		                         v14++,
		                         camera,
		                         0LL);
		      *(TextureHandle *)m_Buffer = *GBufferTexture;
		      m_Buffer += 16;
		    }
		    while ( v14 < v27.m_Length );
		  }
		  Unity::Collections::NativeArray<int>::NativeArray(
		    &v28,
		    4,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  v17 = v28.m_Buffer;
		  Patch = 0LL;
		  do
		  {
		    m_profiles = (DynamicArray_1_System_Object_ *)v13->fields.gBufferMapping;
		    if ( !m_profiles )
		      goto LABEL_17;
		    if ( (unsigned int)Patch >= m_profiles->fields._size_k__BackingField )
		      sub_1800D2AB0(m_profiles, Patch);
		    v18 = (int)Patch;
		    Patch = (ILFixDynamicMethodWrapper_2 *)(unsigned int)((_DWORD)Patch + 1);
		    *(_DWORD *)v17 = *((_DWORD *)&m_profiles[1].klass + v18);
		    v17 += 4;
		  }
		  while ( (int)Patch < 4 );
		  v19 = v28;
		  retstr->m_attachments = (NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_)v27;
		  retstr->m_gbufferMapping = v19;
		  return retstr;
		}
		
		internal void SetGBufferTextureMemoryless(GBufferProfileConfig config, RenderTextureMemoryless memoryless) {} // 0x0000000189B765CC-0x0000000189B766DC
		// Void SetGBufferTextureMemoryless(GBufferProfileManager+GBufferProfileConfig, RenderTextureMemoryless)
		void HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless(
		        GBufferProfileManager *this,
		        GBufferProfileManager_GBufferProfileConfig__Enum config,
		        RenderTextureMemoryless__Enum memoryless,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rcx
		  Object *v9; // rdi
		  int32_t i; // ebx
		  Object__Class *klass; // rax
		  Object *Item; // rax
		  __int64 v13; // rax
		  Exception *v14; // rbx
		  String *v15; // rax
		  __int64 v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2867, 0LL) )
		  {
		    m_profiles = this->fields.m_profiles;
		    if ( m_profiles )
		    {
		      v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		              (DynamicArray_1_System_Object_ *)m_profiles,
		              config,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
		      if ( v9 )
		      {
		        for ( i = 0; ; ++i )
		        {
		          klass = v9[1].klass;
		          if ( !klass )
		            break;
		          if ( i >= SLODWORD(klass->_0.namespaze) )
		            return;
		          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                   (List_1_System_Object_ *)v9[1].klass,
		                   i,
		                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
		          if ( !Item )
		            break;
		          HIDWORD(Item[4].klass) = memoryless;
		        }
		      }
		      else
		      {
		        v13 = sub_18007E180(&TypeInfo::System::Exception);
		        v14 = (Exception *)sub_18002C620(v13);
		        if ( v14 )
		        {
		          v15 = (String *)sub_18007E180(&off_18E263860);
		          System::Exception::Exception(v14, v15, 0LL);
		          v16 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless);
		          sub_18007E190(v14, v16);
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_profiles, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2867, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    (UIInertiaViewPager_State__Enum)config,
		    (UIInertiaViewPager_State__Enum)memoryless,
		    0LL);
		}
		
	}
}
