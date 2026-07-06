using System;
using System.Collections.Generic;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class GBufferProfileManager
	{
		internal GBufferProfileManager()
		{
			// // GBufferProfileManager()
			// void HG::Rendering::Runtime::GBufferProfileManager::GBufferProfileManager(
			//         GBufferProfileManager *this,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v3; // rax
			//   HGRenderCapability__StaticFields *static_fields; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *instance; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   DynamicArray_1_System_Object_ *v10; // rax
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rax
			//   OneofDescriptor *Item; // r14
			//   GBufferProfileManager_GBufferProfile *v18; // rax
			//   GBufferProfileManager_GBufferProfile *v19; // rsi
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   Object *v23; // rdi
			//   Object *v24; // rbx
			//   struct HGRenderCapability__Class *v25; // rax
			//   bool v26; // al
			//   bool v27; // di
			//   HGRenderCapability *v28; // rax
			//   String__Array *transient; // [rsp+20h] [rbp-18h]
			//   String__Array *transienta; // [rsp+20h] [rbp-18h]
			//   String__Array *transientb; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v35; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v36; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v37; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDA2B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_size);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderCapability);
			//     sub_18003C530(&off_18C8EC0D8);
			//     sub_18003C530(&off_18C8EC0E8);
			//     sub_18003C530(&off_18C8EC3D8);
			//     sub_18003C530(&off_18C8EC3E8);
			//     byte_18D8EDA2B = 1;
			//   }
			//   v3 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>);
			//   v6 = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v3;
			//   if ( !v3 )
			//     goto LABEL_10;
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v3,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
			//   this.fields.m_profiles = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v7, v8, v9, transient, (String *)methoda, v35);
			//   v10 = (DynamicArray_1_System_Object_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>);
			//   v11 = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v10;
			//   if ( !v10 )
			//     goto LABEL_10;
			//   UnityEngine::Rendering::DynamicArray<System::Object>::DynamicArray(
			//     v10,
			//     2,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::DynamicArray);
			//   this.fields.m_profiles = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v12, v13, v14, transienta, (String *)methodb, v36);
			//   for ( i = 0; ; ++i )
			//   {
			//     m_profiles = this.fields.m_profiles;
			//     if ( !m_profiles )
			//       goto LABEL_10;
			//     if ( i >= m_profiles.fields._size_k__BackingField )
			//       break;
			//     Item = (OneofDescriptor *)UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                                 (DynamicArray_1_System_Object_ *)this.fields.m_profiles,
			//                                 i,
			//                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//     v18 = (GBufferProfileManager_GBufferProfile *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile);
			//     v19 = v18;
			//     if ( !v18 )
			//       goto LABEL_10;
			//     HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::GBufferProfile(v18, 0LL);
			//     Item.klass = (OneofDescriptor__Class *)v19;
			//     sub_1800054D0(Item, v20, v21, v22, transientb, (String *)methodc, v37);
			//   }
			//   v23 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            (DynamicArray_1_System_Object_ *)this.fields.m_profiles,
			//            0,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//   if ( !v23 )
			//     goto LABEL_10;
			//   HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//     (GBufferProfileManager_GBufferProfile *)v23,
			//     GBufferID__Enum_GBufferA,
			//     GraphicsFormat__Enum_A2B10G10R10_UNormPack32,
			//     (String *)"GBufferA",
			//     0,
			//     0LL);
			//   HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//     (GBufferProfileManager_GBufferProfile *)v23,
			//     GBufferID__Enum_GBufferB,
			//     GraphicsFormat__Enum_A2B10G10R10_UNormPack32,
			//     (String *)"GBufferB",
			//     0,
			//     0LL);
			//   HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//     (GBufferProfileManager_GBufferProfile *)v23,
			//     GBufferID__Enum_GBufferC,
			//     GraphicsFormat__Enum_R8G8B8A8_SRGB,
			//     (String *)"GBufferC",
			//     0,
			//     0LL);
			//   instance = this.fields.m_profiles;
			//   if ( !instance )
			//     goto LABEL_10;
			//   v24 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            (DynamicArray_1_System_Object_ *)instance,
			//            1,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//   v25 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderCapability._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderCapability, static_fields);
			//     v25 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability;
			//   }
			//   instance = (DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *)v25.static_fields.instance;
			//   if ( !instance
			//     || (v26 = HG::Rendering::Runtime::HGRenderCapability::SupportNativeRenderPass((HGRenderCapability *)instance, 0LL),
			//         v27 = v26,
			//         !v24)
			//     || (HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//           (GBufferProfileManager_GBufferProfile *)v24,
			//           GBufferID__Enum_GBufferA,
			//           GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//           (String *)"GBufferA",
			//           v26,
			//           0LL),
			//         HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//           (GBufferProfileManager_GBufferProfile *)v24,
			//           GBufferID__Enum_GBufferB,
			//           GraphicsFormat__Enum_R8G8B8A8_SRGB,
			//           (String *)"GBufferB",
			//           v27,
			//           0LL),
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderCapability.static_fields,
			//         (v28 = static_fields.instance) == 0LL) )
			//   {
			// LABEL_10:
			//     sub_180B536AC(instance, static_fields);
			//   }
			//   if ( v28.fields._useGBufferDepth_k__BackingField )
			//     HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
			//       (GBufferProfileManager_GBufferProfile *)v24,
			//       GBufferID__Enum_GBufferDepth,
			//       GraphicsFormat__Enum_R32_SFloat,
			//       (String *)"GBufferDepth",
			//       v27,
			//       0LL);
			// }
			// 
		}

		[IDTag(1)]
		internal TextureHandle CreateGBufferTexture(GBufferProfileManager.GBufferProfileConfig config, HGRenderGraph renderGraph, GBufferID gBufferID, HGCamera camera)
		{
			// // TextureHandle CreateGBufferTexture(GBufferProfileManager+GBufferProfileConfig, HGRenderGraph, GBufferID, HGCamera)
			// TextureHandle *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
			//         TextureHandle *__return_ptr retstr,
			//         GBufferProfileManager *this,
			//         GBufferProfileManager_GBufferProfileConfig__Enum config,
			//         HGRenderGraph *renderGraph,
			//         GBufferID__Enum gBufferID,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rcx
			//   Object *v13; // r8
			//   TextureHandle *v14; // rax
			//   __int64 v15; // rax
			//   Exception *v16; // rbx
			//   String *v17; // rax
			//   __int64 v18; // rax
			//   TextureHandle v19; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v21; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9194B7 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//     byte_18D9194B7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2382, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2382, 0LL);
			//     if ( Patch )
			//     {
			//       v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_858(
			//               &v21,
			//               Patch,
			//               (Object *)this,
			//               config,
			//               (Object *)renderGraph,
			//               gBufferID,
			//               (Object *)camera,
			//               0LL);
			//       goto LABEL_12;
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_profiles, Patch);
			//   }
			//   m_profiles = this.fields.m_profiles;
			//   if ( !m_profiles )
			//     goto LABEL_10;
			//   v13 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//            (DynamicArray_1_System_Object_ *)m_profiles,
			//            config,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//   if ( !v13 )
			//   {
			//     v15 = sub_18000F7E0(&TypeInfo::System::Exception);
			//     v16 = (Exception *)sub_180004920(v15);
			//     if ( v16 )
			//     {
			//       v17 = (String *)sub_18000F7E0(&off_18D4EFEE0);
			//       System::Exception::Exception(v16, v17, 0LL);
			//       v18 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture);
			//       sub_18000F7C0(v16, v18);
			//     }
			//     goto LABEL_10;
			//   }
			//   v14 = HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
			//           &v21,
			//           this,
			//           (GBufferProfileManager_GBufferProfile *)v13,
			//           renderGraph,
			//           gBufferID,
			//           camera,
			//           0LL);
			// LABEL_12:
			//   v19 = *v14;
			//   result = retstr;
			//   *retstr = v19;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal TextureHandle CreateGBufferTexture(GBufferProfileManager.GBufferProfile profile, HGRenderGraph renderGraph, int gBufferID, HGCamera camera)
		{
			// // TextureHandle CreateGBufferTexture(GBufferProfileManager+GBufferProfile, HGRenderGraph, Int32, HGCamera)
			// TextureHandle *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
			//         TextureHandle *__return_ptr retstr,
			//         GBufferProfileManager *this,
			//         GBufferProfileManager_GBufferProfile *profile,
			//         HGRenderGraph *renderGraph,
			//         int32_t gBufferID,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   List_1_System_Object_ *attachmentProfiles; // rcx
			//   Object *Item; // rax
			//   Object *v14; // rax
			//   Object *v15; // rax
			//   TextureHandle *v16; // rax
			//   TextureHandle v17; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v19; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9194B8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//     byte_18D9194B8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2383, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2383, 0LL);
			//     if ( Patch )
			//     {
			//       v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_857(
			//               &v19,
			//               Patch,
			//               (Object *)this,
			//               (Object *)profile,
			//               (Object *)renderGraph,
			//               gBufferID,
			//               (Object *)camera,
			//               0LL);
			//       goto LABEL_17;
			//     }
			// LABEL_15:
			//     sub_180B536AC(attachmentProfiles, Patch);
			//   }
			//   if ( !profile )
			//     goto LABEL_15;
			//   attachmentProfiles = (List_1_System_Object_ *)profile.fields.attachmentProfiles;
			//   if ( !attachmentProfiles )
			//     goto LABEL_15;
			//   Item = System::Collections::Generic::List<System::Object>::get_Item(
			//            attachmentProfiles,
			//            gBufferID,
			//            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//   if ( !Item )
			//     goto LABEL_15;
			//   if ( !camera )
			//     goto LABEL_15;
			//   LODWORD(Item[1].klass) = camera.fields._sceneRTSize_k__BackingField.m_X;
			//   attachmentProfiles = (List_1_System_Object_ *)profile.fields.attachmentProfiles;
			//   if ( !attachmentProfiles )
			//     goto LABEL_15;
			//   v14 = System::Collections::Generic::List<System::Object>::get_Item(
			//           attachmentProfiles,
			//           gBufferID,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//   if ( !v14 )
			//     goto LABEL_15;
			//   HIDWORD(v14[1].klass) = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   attachmentProfiles = (List_1_System_Object_ *)profile.fields.attachmentProfiles;
			//   if ( !attachmentProfiles )
			//     goto LABEL_15;
			//   v15 = System::Collections::Generic::List<System::Object>::get_Item(
			//           attachmentProfiles,
			//           gBufferID,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//   if ( !v15 || !renderGraph )
			//     goto LABEL_15;
			//   v16 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v19, renderGraph, (TextureDesc *)&v15[1], 0LL);
			// LABEL_17:
			//   v17 = *v16;
			//   result = retstr;
			//   *retstr = v17;
			//   return result;
			// }
			// 
			return null;
		}

		internal GBufferOutput SetupGBufferOutput(GBufferProfileManager.GBufferProfileConfig config, HGRenderGraph renderGraph, HGCamera camera, float copyScale)
		{
			// // GBufferOutput SetupGBufferOutput(GBufferProfileManager+GBufferProfileConfig, HGRenderGraph, HGCamera, Single)
			// GBufferOutput *HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput(
			//         GBufferOutput *__return_ptr retstr,
			//         GBufferProfileManager *this,
			//         GBufferProfileManager_GBufferProfileConfig__Enum config,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         float copyScale,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   DynamicArray_1_System_Object_ *m_profiles; // rcx
			//   GBufferProfileManager_GBufferProfile *v13; // rdi
			//   int32_t v14; // r14d
			//   Void *m_Buffer; // rbp
			//   TextureHandle *GBufferTexture; // rax
			//   Void *v17; // r8
			//   __int64 v18; // rax
			//   NativeArray_1_System_Int32_ v19; // xmm1
			//   __int64 v20; // rax
			//   Exception *v21; // rbx
			//   String *v22; // rax
			//   __int64 v23; // rax
			//   GBufferOutput *v24; // rax
			//   NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v27; // [rsp+40h] [rbp-58h] BYREF
			//   NativeArray_1_System_Int32_ v28; // [rsp+50h] [rbp-48h] BYREF
			//   GBufferOutput v29; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9194B9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Count);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     byte_18D9194B9 = 1;
			//   }
			//   v27 = 0LL;
			//   v28 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2384, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2384, 0LL);
			//     if ( Patch )
			//     {
			//       v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_859(
			//               &v29,
			//               Patch,
			//               (Object *)this,
			//               config,
			//               (Object *)renderGraph,
			//               (Object *)camera,
			//               copyScale,
			//               0LL);
			//       m_gbufferMapping = v24.m_gbufferMapping;
			//       retstr.m_attachments = v24.m_attachments;
			//       retstr.m_gbufferMapping = m_gbufferMapping;
			//       return retstr;
			//     }
			// LABEL_19:
			//     sub_180B536AC(m_profiles, Patch);
			//   }
			//   m_profiles = (DynamicArray_1_System_Object_ *)this.fields.m_profiles;
			//   if ( !m_profiles )
			//     goto LABEL_19;
			//   v13 = (GBufferProfileManager_GBufferProfile *)*UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//                                                    m_profiles,
			//                                                    config,
			//                                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//   if ( !v13 )
			//   {
			//     v20 = sub_18000F7E0(&TypeInfo::System::Exception);
			//     v21 = (Exception *)sub_180004920(v20);
			//     if ( v21 )
			//     {
			//       v22 = (String *)sub_18000F7E0(&off_18D4EFEE0);
			//       System::Exception::Exception(v21, v22, 0LL);
			//       v23 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput);
			//       sub_18000F7C0(v21, v23);
			//     }
			//     goto LABEL_19;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)v13.fields.attachmentProfiles;
			//   if ( !Patch )
			//     goto LABEL_19;
			//   Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//     &v27,
			//     Patch.fields.methodId,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
			//   v14 = 0;
			//   if ( v27.m_Length > 0 )
			//   {
			//     m_Buffer = v27.m_Buffer;
			//     do
			//     {
			//       GBufferTexture = HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(
			//                          (TextureHandle *)&v29,
			//                          this,
			//                          v13,
			//                          renderGraph,
			//                          v14++,
			//                          camera,
			//                          0LL);
			//       *(TextureHandle *)m_Buffer = *GBufferTexture;
			//       m_Buffer += 16;
			//     }
			//     while ( v14 < v27.m_Length );
			//   }
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     &v28,
			//     4,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   v17 = v28.m_Buffer;
			//   Patch = 0LL;
			//   do
			//   {
			//     m_profiles = (DynamicArray_1_System_Object_ *)v13.fields.gBufferMapping;
			//     if ( !m_profiles )
			//       goto LABEL_19;
			//     if ( (unsigned int)Patch >= m_profiles.fields._size_k__BackingField )
			//       sub_180070270(m_profiles, Patch);
			//     v18 = (int)Patch;
			//     Patch = (ILFixDynamicMethodWrapper_2 *)(unsigned int)((_DWORD)Patch + 1);
			//     *(_DWORD *)v17 = *((_DWORD *)&m_profiles[1].klass + v18);
			//     v17 += 4;
			//   }
			//   while ( (int)Patch < 4 );
			//   v19 = v28;
			//   retstr.m_attachments = (NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_)v27;
			//   retstr.m_gbufferMapping = v19;
			//   return retstr;
			// }
			// 
			return null;
		}

		internal void SetGBufferTextureMemoryless(GBufferProfileManager.GBufferProfileConfig config, RenderTextureMemoryless memoryless)
		{
			// // Void SetGBufferTextureMemoryless(GBufferProfileManager+GBufferProfileConfig, RenderTextureMemoryless)
			// void HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless(
			//         GBufferProfileManager *this,
			//         GBufferProfileManager_GBufferProfileConfig__Enum config,
			//         RenderTextureMemoryless__Enum memoryless,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_ *m_profiles; // rcx
			//   Object *v9; // rdi
			//   int32_t i; // ebx
			//   Object__Class *klass; // rax
			//   Object *Item; // rax
			//   __int64 v13; // rax
			//   Exception *v14; // rbx
			//   String *v15; // rax
			//   __int64 v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9194BA )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//     byte_18D9194BA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2385, 0LL) )
			//   {
			//     m_profiles = this.fields.m_profiles;
			//     if ( m_profiles )
			//     {
			//       v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
			//               (DynamicArray_1_System_Object_ *)m_profiles,
			//               config,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile>::get_Item);
			//       if ( v9 )
			//       {
			//         for ( i = 0; ; ++i )
			//         {
			//           klass = v9[1].klass;
			//           if ( !klass )
			//             break;
			//           if ( i >= SLODWORD(klass._0.namespaze) )
			//             return;
			//           Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                    (List_1_System_Object_ *)v9[1].klass,
			//                    i,
			//                    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Item);
			//           if ( !Item )
			//             break;
			//           HIDWORD(Item[4].klass) = memoryless;
			//         }
			//       }
			//       else
			//       {
			//         v13 = sub_18000F7E0(&TypeInfo::System::Exception);
			//         v14 = (Exception *)sub_180004920(v13);
			//         if ( v14 )
			//         {
			//           v15 = (String *)sub_18000F7E0(&off_18D4EFEE0);
			//           System::Exception::Exception(v14, v15, 0LL);
			//           v16 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless);
			//           sub_18000F7C0(v14, v16);
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_profiles, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2385, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//     (ILFixDynamicMethodWrapper_20 *)Patch,
			//     (Object *)this,
			//     config,
			//     memoryless,
			//     0LL);
			// }
			// 
		}

		private DynamicArray<GBufferProfileManager.GBufferProfile> m_profiles;

		internal class GBufferProfile
		{
			public GBufferProfile()
			{
			}

			public void AddGBufferRT(GBufferID id, GraphicsFormat format, string name, [MetadataOffset(Offset = "0x01F914A1")] bool transient = false)
			{
				// // Void AddGBufferRT(GBufferID, GraphicsFormat, String, Boolean)
				// void HG::Rendering::Runtime::GBufferProfileManager::GBufferProfile::AddGBufferRT(
				//         GBufferProfileManager_GBufferProfile *this,
				//         GBufferID__Enum id,
				//         GraphicsFormat__Enum format,
				//         String *name,
				//         bool transient,
				//         MethodInfo *method)
				// {
				//   __int64 v8; // rdi
				//   __int64 size; // rdx
				//   List_1_HG_Rendering_Runtime_GBufferProfileManager_GBufferProfile_AttachmentProfile_ *attachmentProfiles; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
				//   List_1_System_Object_ *v13; // rdi
				//   __int64 v14; // rbx
				//   OneofDescriptorProto *v15; // rdx
				//   FileDescriptor *v16; // r8
				//   MessageDescriptor *v17; // r9
				//   __int128 v18; // xmm4
				//   __int128 v19; // xmm5
				//   Color clearColor; // xmm0
				//   __int128 v21; // xmm2
				//   __int128 v22; // xmm3
				//   OneofDescriptorProto *v23; // rdx
				//   FileDescriptor *v24; // r8
				//   MessageDescriptor *v25; // r9
				//   ILFixDynamicMethodWrapper_2 *v26; // rax
				//   Object *P3; // [rsp+20h] [rbp-59h]
				//   Object *P3a; // [rsp+20h] [rbp-59h]
				//   String *P4; // [rsp+28h] [rbp-51h]
				//   String *P4a; // [rsp+28h] [rbp-51h]
				//   MethodInfo *v31; // [rsp+30h] [rbp-49h]
				//   MethodInfo *v32; // [rsp+30h] [rbp-49h]
				//   double v33; // [rsp+40h] [rbp-39h]
				//   TextureDesc P0; // [rsp+50h] [rbp-29h] BYREF
				// 
				//   v8 = (int)id;
				//   if ( !byte_18D8EDA2D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile>::get_Count);
				//     byte_18D8EDA2D = 1;
				//   }
				//   LODWORD(v33) = 0;
				//   if ( IFix::WrappersManagerImpl::IsPatched(2386, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2386, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_861(
				//         Patch,
				//         (Object *)this,
				//         (GBufferID__Enum)v8,
				//         format,
				//         (Object *)name,
				//         transient,
				//         0LL);
				//       return;
				//     }
				//     goto LABEL_14;
				//   }
				//   if ( format == GraphicsFormat__Enum_None )
				//     return;
				//   attachmentProfiles = this.fields.attachmentProfiles;
				//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.gBufferMapping;
				//   LOBYTE(v33) = 1;
				//   HIDWORD(v33) = 1;
				//   if ( !attachmentProfiles )
				//     goto LABEL_14;
				//   size = (unsigned int)attachmentProfiles.fields._size;
				//   if ( !Patch )
				//     goto LABEL_14;
				//   if ( (unsigned int)v8 >= Patch.fields.methodId )
				//     sub_180070270(Patch, size);
				//   *((_DWORD *)&Patch.fields.anonObj + v8) = size;
				//   v13 = (List_1_System_Object_ *)this.fields.attachmentProfiles;
				//   v14 = sub_180004920(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager_GBufferProfile::AttachmentProfile);
				//   if ( !v14 )
				//     goto LABEL_14;
				//   memset(&P0.slices, 0, 88);
				//   *(_QWORD *)&P0.width = sub_182E7DDC0();
				//   P0.msaaSamples = 1;
				//   if ( !IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
				//   {
				//     P0.slices = 1;
				//     P0.dimension = 2;
				//     goto LABEL_11;
				//   }
				//   v26 = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
				//   if ( !v26 )
				// LABEL_14:
				//     sub_180B536AC(Patch, size);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(v26, &P0, 0LL);
				// LABEL_11:
				//   P0.colorFormat = format;
				//   P0.memoryless = transient;
				//   P0.name = name;
				//   sub_1800054D0((OneofDescriptor *)&P0.name, v15, v16, v17, (String__Array *)P3, P4, v31);
				//   v18 = *(_OWORD *)&P0.bindTextureMS;
				//   P0.fastMemoryDesc.residencyFraction = 1.0;
				//   *((_QWORD *)&v19 + 1) = *(_QWORD *)&P0.fastMemoryDesc.residencyFraction;
				//   P0.slices = 1;
				//   *(double *)&v19 = v33;
				//   clearColor = P0.clearColor;
				//   P0.dimension = 2;
				//   v21 = *(_OWORD *)&P0.colorFormat;
				//   P0.msaaSamples = 1;
				//   v22 = *(_OWORD *)&P0.enableRandomWrite;
				//   *(_OWORD *)&P0.fastMemoryDesc.inFastMemory = v19;
				//   *(_OWORD *)(v14 + 16) = *(_OWORD *)&P0.width;
				//   *(_OWORD *)(v14 + 32) = v21;
				//   *(_OWORD *)(v14 + 48) = v22;
				//   *(_OWORD *)(v14 + 64) = v18;
				//   *(_OWORD *)(v14 + 80) = v19;
				//   *(Color *)(v14 + 96) = clearColor;
				//   sub_1800054D0((OneofDescriptor *)(v14 + 72), v23, v24, v25, (String__Array *)P3a, P4a, v32);
				//   if ( !v13 )
				//     goto LABEL_14;
				//   sub_1822AD140(v13, (Object *)v14);
				// }
				// 
			}

			public List<GBufferProfileManager.GBufferProfile.AttachmentProfile> attachmentProfiles;

			public int[] gBufferMapping;

			public class AttachmentProfile
			{
				public AttachmentProfile()
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}

				internal TextureDesc attachmentDesc;
			}
		}

		internal enum GBufferProfileConfig
		{
			HighEnd,
			LowEnd,
			Count
		}
	}
}
